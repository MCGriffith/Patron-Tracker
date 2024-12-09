Imports System.Data.OleDb

Public Class FrmAttendanceFix
    Dim connectionString As String = DatabaseConfig.ConnectionString

    Private LoginID As Integer
    Private ContactID As Integer

    Private Sub FrmAttendanceFix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable initial controls
        lblAName.Enabled = True
        cboAName.Enabled = True
        btnACancel.Enabled = True

        ' Disable all other controls
        DisableControls()

        ' Populate combo boxes
        PopulateComboBoxes()
    End Sub

    Private Sub DisableControls()
        lblADate.Enabled = False
        dtpADate.Enabled = False
        grpAFirst.Enabled = False
        cbxAYes.Enabled = False
        lblAAnswer.Enabled = False
        grpAReason.Enabled = False
        cbxAPrint.Enabled = False
        cbxAIndexing.Enabled = False
        cbxAOnline.Enabled = False
        cbxAWebsite.Enabled = False
        cbxAClass.Enabled = False
        cbxAOther.Enabled = False
        btnASave.Enabled = False
    End Sub

    Private Sub PopulateComboBoxes()

        ' Populate cboAName from tblContacts
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT FullName FROM tblContacts ORDER BY FullName", conn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            While dr.Read()
                cboAName.Items.Add(dr("FullName"))
            End While
        End Using

    End Sub

    Private Sub cboAName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAName.SelectedIndexChanged
        If cboAName.SelectedIndex = -1 Then Return

        ' Enable all controls
        EnableAllControls()

        ' Get LoginID and populate fields
        PopulateUserData()
    End Sub

    Private Sub EnableAllControls()
        ' Enable all previously disabled controls
        lblADate.Enabled = True
        dtpADate.Enabled = True
        grpAFirst.Enabled = True
        cbxAYes.Enabled = True
        lblAAnswer.Enabled = True
        grpAReason.Enabled = True
        cbxAPrint.Enabled = True
        cbxAIndexing.Enabled = True
        cbxAOnline.Enabled = True
        cbxAWebsite.Enabled = True
        cbxAClass.Enabled = True
        cbxAOther.Enabled = True
        btnASave.Enabled = True
    End Sub

    Private Sub PopulateUserData()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            ' Get LoginID and ContactID from tblContacts using FullName
            Dim loginCmd As New OleDbCommand("SELECT LoginID, ContactID FROM tblContacts WHERE FullName = ?", conn)
            loginCmd.Parameters.Add("FullName", OleDbType.LongVarWChar).Value = cboAName.Text
            Dim loginReader As OleDbDataReader = loginCmd.ExecuteReader()


            If loginReader.Read() Then
                LoginID = Convert.ToInt32(loginReader("LoginID"))
                ContactID = Convert.ToInt32(loginReader("ContactID"))
            End If
            loginReader.Close()
        End Using
    End Sub

    Private Sub btnASave_Click(sender As Object, e As EventArgs) Handles btnASave.Click
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Using trans As OleDbTransaction = conn.BeginTransaction()
                Try
                    Dim cmdAttendance As New OleDbCommand("INSERT INTO tblAttendance (LogDate, LogTime, FirstVisit, PrintFOR, " &
                "Indexing, OnlineRsrch, SubWebsite, AttendClass, Other, LoginID, People) VALUES " &
                "(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn, trans)

                    cmdAttendance.Parameters.Add("LogDate", OleDbType.Date).Value = dtpADate.Value.Date
                    cmdAttendance.Parameters.Add("LogTime", OleDbType.Date).Value = DateTime.Now.ToString("HH:mm:ss")
                    cmdAttendance.Parameters.Add("FirstVisit", OleDbType.Boolean).Value = cbxAYes.Checked
                    cmdAttendance.Parameters.Add("PrintFOR", OleDbType.Boolean).Value = cbxAPrint.Checked
                    cmdAttendance.Parameters.Add("Indexing", OleDbType.Boolean).Value = cbxAIndexing.Checked
                    cmdAttendance.Parameters.Add("OnlineRsrch", OleDbType.Boolean).Value = cbxAOnline.Checked
                    cmdAttendance.Parameters.Add("SubWebsite", OleDbType.Boolean).Value = cbxAWebsite.Checked
                    cmdAttendance.Parameters.Add("AttendClass", OleDbType.Boolean).Value = cbxAClass.Checked
                    cmdAttendance.Parameters.Add("Other", OleDbType.Boolean).Value = cbxAOther.Checked
                    cmdAttendance.Parameters.Add("LoginID", OleDbType.Integer).Value = LoginID
                    cmdAttendance.Parameters.Add("People", OleDbType.Boolean).Value = True ' Always set People to True

                    cmdAttendance.ExecuteNonQuery()
                    trans.Commit()
                    MessageBox.Show("Data saved successfully!")

                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Error saving data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnACancel_Click(sender As Object, e As EventArgs) Handles btnACancel.Click
        Me.Close()
    End Sub
End Class