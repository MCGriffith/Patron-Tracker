Imports System.Data.OleDb

Public Class FrmScheduling

    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private Sub FrmScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDaysOfWeek()
        SetupShiftTemplatesGrid()
        LoadVolunteers()
        LoadShifts()
        SetupScheduleGrid()
        LoadAssignments()
        LoadSubstitutionVolunteers()
        LoadShiftsForSubstitution()
        SetupSubstitutesGrid()
        LoadSubstitutions()
    End Sub

    Private Sub LoadDaysOfWeek()
        With cboDayOfWeek.Items
            .Add("Sunday")
            .Add("Monday")
            .Add("Tuesday")
            .Add("Wednesday")
            .Add("Thursday")
            .Add("Friday")
            .Add("Saturday")
        End With
    End Sub

    Private Sub SetupShiftTemplatesGrid()
        With dgvShiftTemplates
            .Columns.Add("DayOfWeek", "Day")
            .Columns.Add("StartTime", "Start Time")
            .Columns.Add("EndTime", "End Time")
        End With
    End Sub

    Private Sub btnAddShiftTemplate_Click(sender As Object, e As EventArgs) Handles btnAddShiftTemplate.Click
        ' Validate inputs
        If cboDayOfWeek.SelectedIndex = -1 Then
            MessageBox.Show("Please select a day of the week")
            Return
        End If

        ' Get the values
        Dim dayOfWeek As String = cboDayOfWeek.SelectedItem.ToString()
        Dim startTime As DateTime = dtpStartTime.Value
        Dim endTime As DateTime = dtpEndTime.Value

        ' Add to grid
        dgvShiftTemplates.Rows.Add(dayOfWeek, startTime.ToString("HH:mm"), endTime.ToString("HH:mm"))
    End Sub

    Private Sub btnSaveShiftTemplate_Click(sender As Object, e As EventArgs) Handles btnSaveShiftTemplate.Click
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()

            For Each row As DataGridViewRow In dgvShiftTemplates.Rows
                Dim sql As String = "INSERT INTO tblShifts (ShiftDay, StartTime, EndTime) VALUES (?, ?, ?)"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@p1", row.Cells("DayOfWeek").Value)
                    cmd.Parameters.AddWithValue("@p2", row.Cells("StartTime").Value)
                    cmd.Parameters.AddWithValue("@p3", row.Cells("EndTime").Value)
                    cmd.ExecuteNonQuery()
                End Using
            Next

            MessageBox.Show("Shift templates saved successfully!")
        End Using
    End Sub

    Private Sub btnShiftsClose_Click(sender As Object, e As EventArgs) Handles btnShiftsClose.Click
        Me.Close()
    End Sub

    Private Sub LoadVolunteers()
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT VolunteerID, FullName FROM tblVolunteer ORDER BY LastName"
            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cboVolunteer.Items.Add(New With {
                        .ID = reader("VolunteerID"),
                        .Name = reader("FullName")
                    })
                    End While
                End Using
            End Using
        End Using
        cboVolunteer.DisplayMember = "Name"
        cboVolunteer.ValueMember = "ID"
    End Sub

    Private Sub LoadShifts()
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT ShiftID, ShiftDay + ' ' + Format(StartTime,'HH:mm') + ' - ' + Format(EndTime,'HH:mm') AS ShiftInfo FROM tblShifts ORDER BY ShiftDay"
            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cboShiftDay.Items.Add(New With {
                            .ID = reader("ShiftID"),
                            .Info = reader("ShiftInfo")
                        })
                    End While
                End Using
            End Using
        End Using
        cboShiftDay.DisplayMember = "Info"
        cboShiftDay.ValueMember = "ID"
    End Sub
    Private Sub SetupScheduleGrid()
        With dgvSchedule
            .Columns.Add("VolunteerName", "Volunteer")
            .Columns.Add("ShiftInfo", "Shift")
            .Columns.Add("IsSubstitute", "Substitute")
        End With
    End Sub

    Private Sub btnAssignVolunteer_Click(sender As Object, e As EventArgs) Handles btnAssignVolunteer.Click
        If cboVolunteer.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a volunteer")
            Return
        End If

        If cboShiftDay.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a shift")
            Return
        End If

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO tblVolunteerShifts (VolunteerID, ShiftID, IsSubstitute) VALUES (?, ?, ?)"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", cboVolunteer.SelectedItem.ID)
                cmd.Parameters.AddWithValue("@p2", cboShiftDay.SelectedItem.ID)
                cmd.Parameters.AddWithValue("@p3", chkIsSubstitute.Checked)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadAssignments()
    End Sub

    Private Sub LoadAssignments()
        dgvSchedule.Rows.Clear()

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT v.FullName AS VolunteerName, " &
                           "s.ShiftDay + ' ' + Format(s.StartTime,'HH:mm') + ' - ' + Format(s.EndTime,'HH:mm') AS ShiftInfo, " &
                           "vs.IsSubstitute " &
                           "FROM (tblVolunteerShifts vs " &
                           "INNER JOIN tblVolunteer v ON vs.VolunteerID = v.VolunteerID) " &
                           "INNER JOIN tblShifts s ON vs.ShiftID = s.ShiftID"

            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvSchedule.Rows.Add(
                        reader("VolunteerName"),
                        reader("ShiftInfo"),
                        reader("IsSubstitute")
                    )
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadSubstitutionVolunteers()
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT VolunteerID, FullName FROM tblVolunteer ORDER BY LastName"

            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim volunteerInfo = New With {
                            .ID = reader("VolunteerID"),
                            .Name = reader("FullName")
                        }
                        cboOriginalVolunteer.Items.Add(volunteerInfo)
                        cboSubstituteVolunteer.Items.Add(volunteerInfo)
                    End While
                End Using
            End Using
        End Using

        cboOriginalVolunteer.DisplayMember = "Name"
        cboOriginalVolunteer.ValueMember = "ID"
        cboSubstituteVolunteer.DisplayMember = "Name"
        cboSubstituteVolunteer.ValueMember = "ID"
    End Sub

    Private Sub LoadShiftsForSubstitution()
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT ShiftID, ShiftDay + ' ' + Format(StartTime,'HH:mm') + ' - ' + Format(EndTime,'HH:mm') AS ShiftInfo FROM tblShifts ORDER BY ShiftDay"
            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cboShiftToReplace.Items.Add(New With {
                            .ID = reader("ShiftID"),
                            .Info = reader("ShiftInfo")
                        })
                    End While
                End Using
            End Using
        End Using
        cboShiftToReplace.DisplayMember = "Info"
        cboShiftToReplace.ValueMember = "ID"
    End Sub

    Private Sub SetupSubstitutesGrid()
        With dgvSubstitutes
            .Columns.Add("OriginalVolunteer", "Original Volunteer")
            .Columns.Add("SubstituteVolunteer", "Substitute")
            .Columns.Add("ShiftInfo", "Shift")
            .Columns.Add("SubstituteDate", "Coverage Date")
        End With
    End Sub

    Private Sub btnRecordSubstitute_Click(sender As Object, e As EventArgs) Handles btnRecordSubstitute.Click
        If cboOriginalVolunteer.SelectedItem Is Nothing Then
            MessageBox.Show("Please select original volunteer")
            Return
        End If

        If cboSubstituteVolunteer.SelectedItem Is Nothing Then
            MessageBox.Show("Please select substitute volunteer")
            Return
        End If

        If cboShiftToReplace.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a shift")
            Return
        End If

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "INSERT INTO tblSubstitutes (OriginalVolunteerID, SubstituteVolunteerID, ShiftID, SubstituteDate) VALUES (?, ?, ?, ?)"
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", cboOriginalVolunteer.SelectedItem.ID)
                cmd.Parameters.AddWithValue("@p2", cboSubstituteVolunteer.SelectedItem.ID)
                cmd.Parameters.AddWithValue("@p3", cboShiftToReplace.SelectedItem.ID)
                cmd.Parameters.AddWithValue("@p4", dtpCoverageDate.Value.Date)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadSubstitutions()
    End Sub

    Private Sub LoadSubstitutions()
        dgvSubstitutes.Rows.Clear()

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim sql As String = "SELECT " &
                               "v1.FullName AS OriginalVolunteer, " &
                               "v2.FullName AS SubstituteVolunteer, " &
                               "s.ShiftDay + ' ' + Format(s.StartTime,'HH:mm') + ' - ' + Format(s.EndTime,'HH:mm') AS ShiftInfo, " &
                               "sub.SubstituteDate " &
                               "FROM ((tblSubstitutes sub " &
                               "INNER JOIN tblVolunteer v1 ON sub.OriginalVolunteerID = v1.VolunteerID) " &
                               "INNER JOIN tblVolunteer v2 ON sub.SubstituteVolunteerID = v2.VolunteerID) " &
                               "INNER JOIN tblShifts s ON sub.ShiftID = s.ShiftID"

            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvSubstitutes.Rows.Add(
                            reader("OriginalVolunteer"),
                            reader("SubstituteVolunteer"),
                            reader("ShiftInfo"),
                            reader("SubstituteDate")
                        )
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class