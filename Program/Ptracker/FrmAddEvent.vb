Imports System.Data.OleDb

Public Class FrmAddEvent
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private currentEventID As Integer = -1

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmAddEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable and disable controls as specified
        lblEventName.Enabled = True
        cboEventName.Enabled = True

        lblEventDate.Enabled = False
        dtpEventDate.Enabled = False
        lblRegStart.Enabled = False
        dtpRegStart.Enabled = False
        lblRegStop.Enabled = False
        dtpRegStop.Enabled = False
        btnRemoveEvent.Enabled = False
        btnSaveEvent.Enabled = False

        ' Populate cboEventName with active events
        PopulateEventNames()
    End Sub

    Private Sub PopulateEventNames()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT EventID, EventName FROM tblEvents " &
                           "WHERE Inactive = False " &
                           "AND RegStart <= #" & DateTime.Today.ToString("MM/dd/yyyy") & "# " &
                           "AND RegStop >= #" & DateTime.Today.ToString("MM/dd/yyyy") & "# " &
                           "ORDER BY EventName"

            Dim cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            cboEventName.Items.Clear()

            While reader.Read()
                cboEventName.Items.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32(0), reader.GetString(1)))
            End While
        End Using

        ' Set the display and value members
        cboEventName.DisplayMember = "Value"
        cboEventName.ValueMember = "Key"
    End Sub

    Private Sub cboEventName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEventName.SelectedIndexChanged
        EnableDateControls()
        If cboEventName.SelectedItem IsNot Nothing Then
            Dim selectedEvent = DirectCast(cboEventName.SelectedItem, KeyValuePair(Of Integer, String))
            currentEventID = selectedEvent.Key
            LoadEventDetails(currentEventID)
        End If
    End Sub

    Private Sub cboEventName_TextChanged(sender As Object, e As EventArgs) Handles cboEventName.TextChanged
        EnableDateControls()
        If Not cboEventName.Items.Contains(cboEventName.Text) Then
            currentEventID = -1
            ClearDateControls()
        End If
    End Sub

    Private Sub EnableDateControls()
        lblEventDate.Enabled = True
        dtpEventDate.Enabled = True
        lblRegStart.Enabled = True
        dtpRegStart.Enabled = True
        lblRegStop.Enabled = True
        dtpRegStop.Enabled = True
        btnRemoveEvent.Enabled = True
        btnSaveEvent.Enabled = True
    End Sub

    Private Sub ClearDateControls()
        dtpEventDate.Value = DateTime.Now
        dtpRegStart.Value = DateTime.Now
        dtpRegStop.Value = DateTime.Now
    End Sub

    Private Sub LoadEventDetails(eventID As Integer)

        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT EventDate, RegStart, RegStop FROM tblEvents WHERE EventID = @EventID", conn)
            cmd.Parameters.AddWithValue("@EventID", eventID)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                dtpEventDate.Value = reader.GetDateTime(0)
                dtpRegStart.Value = reader.GetDateTime(1)
                dtpRegStop.Value = reader.GetDateTime(2)
            End If
        End Using
    End Sub

    Private Sub btnSaveEvent_Click(sender As Object, e As EventArgs) Handles btnSaveEvent.Click
        If String.IsNullOrWhiteSpace(cboEventName.Text) Then
            MessageBox.Show("Please enter an event name.")
            Return
        End If


        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As OleDbCommand

            If currentEventID = -1 Then
                ' Insert new event
                cmd = New OleDbCommand("INSERT INTO tblEvents (EventName, EventDate, RegStart, RegStop) VALUES (@EventName, @EventDate, @RegStart, @RegStop)", conn)
            Else
                ' Update existing event
                cmd = New OleDbCommand("UPDATE tblEvents SET EventName = @EventName, EventDate = @EventDate, RegStart = @RegStart, RegStop = @RegStop WHERE EventID = @EventID", conn)
                cmd.Parameters.Add("@EventID", OleDbType.Integer).Value = currentEventID
            End If

            cmd.Parameters.Add("@EventName", OleDbType.VarWChar, 255).Value = cboEventName.Text
            cmd.Parameters.Add("@EventDate", OleDbType.Date).Value = dtpEventDate.Value.Date
            cmd.Parameters.Add("@RegStart", OleDbType.Date).Value = dtpRegStart.Value.Date
            cmd.Parameters.Add("@RegStop", OleDbType.Date).Value = dtpRegStop.Value.Date

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Event saved successfully.")
                PopulateEventNames()
            Catch ex As Exception
                MessageBox.Show("Error saving event: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnRemoveEvent_Click(sender As Object, e As EventArgs) Handles btnRemoveEvent.Click
        If currentEventID = -1 Then
            MessageBox.Show("Please select an existing event to remove.")
            Return
        End If

        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            ' First update - tblEvents
            Dim sqlEvents As String = "UPDATE tblEvents SET Inactive = True WHERE EventID = " & currentEventID
            Dim cmdEvents As New OleDbCommand(sqlEvents, conn)

            ' Second update - tblRegister
            Dim sqlRegister As String = "UPDATE tblRegister SET Inactive = True WHERE EventID = " & currentEventID
            Dim cmdRegister As New OleDbCommand(sqlRegister, conn)

            Try
                Dim eventsAffected = cmdEvents.ExecuteNonQuery()
                Dim registrationsAffected = cmdRegister.ExecuteNonQuery()
                MessageBox.Show($"Updated {eventsAffected} event and {registrationsAffected} registrations.")
            Catch ex As Exception
                MessageBox.Show("Database update error: " & ex.Message & vbCrLf & "SQL: " & sqlRegister)
                Return
            End Try
        End Using

        ClearDateControls()
        cboEventName.Text = ""
        currentEventID = -1
        PopulateEventNames()
    End Sub

    Private Sub dtpRegStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpRegStart.ValueChanged

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class