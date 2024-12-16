Imports System.Data.OleDb

Public Class FrmLogin
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private LoginID As Integer = 0
    Private attempts As Integer = 0
    Private Const maxAttempts As Integer = 3
    Private selectedEvents As New List(Of EventInfo)
    Private conn As OleDbConnection

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        btnLogon.Enabled = False
        btnCreate.Enabled = False
        LoadAvailableEvents()
    End Sub
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ValidateInputs()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ValidateInputs()
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPrint.CheckedChanged,
            cbxIndexing.CheckedChanged, cbxOnline.CheckedChanged, cbxWebsite.CheckedChanged,
            cbxClass.CheckedChanged, cbxOther.CheckedChanged
        ValidateInputs()
    End Sub

    Private Sub ValidateInputs()
        If Not String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso
           Not String.IsNullOrWhiteSpace(txtPassword.Text) AndAlso
           (cbxPrint.Checked Or cbxIndexing.Checked Or
            cbxOnline.Checked Or cbxWebsite.Checked Or cbxClass.Checked Or cbxOther.Checked) Then
            ValidateCredentials()
        Else
            btnLogon.Enabled = False
            btnCreate.Enabled = False
            LoginID = 0
        End If
    End Sub

    Private Sub ValidateCredentials()
        Using conn As New OleDbConnection(connectionString)
            Dim command As New OleDbCommand("SELECT LoginID, Password, Role FROM tblLogin WHERE Email = ?", conn)
            command.Parameters.Add("?", OleDbType.VarWChar).Value = txtEmail.Text

            Try
                conn.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim dbPassword As String = reader("Password").ToString()
                    Dim dbLoginID As Integer = Convert.ToInt32(reader("LoginID"))
                    Dim dbRole As String = reader("Role").ToString()

                    If txtPassword.Text = dbPassword Then
                        LoginID = dbLoginID
                        CurrentUser.SetCurrentUser(LoginID, dbRole)
                        StoreLoginInfo(LoginID)
                        btnLogon.Enabled = True
                    Else
                        HandleFailedLogin(dbPassword, dbLoginID)
                    End If
                Else
                    HandleNewUser()
                End If

            Catch ex As Exception
                MessageBox.Show("Error validating credentials: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub HandleFailedLogin(dbPassword As String, dbLoginID As Integer)
        attempts += 1
        If attempts >= maxAttempts Then
            MessageBox.Show($"Maximum attempts reached. The correct password '{dbPassword}' will be entered automatically.")
            txtPassword.Text = dbPassword
            LoginID = dbLoginID
            btnLogon.Enabled = True
            attempts = 0
        Else
            MessageBox.Show($"Incorrect password. Attempt {attempts} of {maxAttempts}. Please try again.")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub HandleNewUser()
        btnLogon.Enabled = False
        btnCreate.Enabled = True
        LoginID = 0
        attempts = 0
    End Sub

    Private Sub StoreLoginInfo(loginID As Integer)
        Using conn = New OleDbConnection(connectionString)
            conn.Open()
            Dim sql As String = "SELECT c.FullName, l.Role " &
                           "FROM tblContacts c, tblLogin l " &
                           "WHERE c.LoginID = l.LoginID " &
                           "AND l.LoginID = @LoginID"

            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@LoginID", loginID)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        GlobalVariables.CurrentUserRole = reader("Role").ToString()
                        GlobalVariables.CurrentUserName = reader("FullName").ToString()
                        GlobalVariables.CurrentUserID = loginID
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnLogon_Click(sender As Object, e As EventArgs) Handles btnLogon.Click
        If LoginID > 0 Then
            Try
                RecordAttendance()
                RegisterForEvents()
                If TypeOf Me.Owner Is FrmMain Then
                    CType(Application.OpenForms("FrmMain"), FrmMain).UpdateMenuVisibility()
                End If
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error during login process: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please enter valid credentials and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub RecordAttendance()
        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim command As New OleDbCommand("INSERT INTO tblAttendance (LogDate, LogTime, FirstVisit, PrintFOR, Indexing, OnlineRsrch, SubWebsite, AttendClass, Other, LoginID, People) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)

                command.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now.Date
                command.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now.ToString("HH:mm:ss") ' 24-hour time
                command.Parameters.Add("?", OleDbType.Boolean).Value = cbxYes.Checked
                command.Parameters.Add("?", OleDbType.Boolean).Value = cbxPrint.Checked
                command.Parameters.Add("?", OleDbType.Boolean).Value = cbxIndexing.Checked
                command.Parameters.Add("?", OleDbType.Boolean).Value = cbxOnline.Checked
                command.Parameters.Add("?", OleDbType.Boolean).Value = cbxWebsite.Checked
                command.Parameters.Add("?", OleDbType.Boolean).Value = cbxClass.Checked
                command.Parameters.Add("?", OleDbType.Boolean).Value = cbxOther.Checked
                command.Parameters.Add("?", OleDbType.Integer).Value = LoginID
                command.Parameters.Add("?", OleDbType.Boolean).Value = True ' Always set People to True

                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error recording attendance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub RegisterForEvents()
        If selectedEvents.Count = 0 Then
            ' MessageBox.Show("No events selected for registration.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                For Each eventInfo In selectedEvents
                    Dim command As New OleDbCommand("INSERT INTO tblRegister (EventName, EventDate, RegisterDate, EventID, LoginID) VALUES (?, ?, ?, ?, ?)", conn)

                    command.Parameters.Add("?", OleDbType.VarWChar).Value = eventInfo.EventName
                    command.Parameters.Add("?", OleDbType.Date).Value = eventInfo.EventDate
                    command.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now.Date
                    command.Parameters.Add("?", OleDbType.Integer).Value = eventInfo.EventID
                    command.Parameters.Add("?", OleDbType.Integer).Value = LoginID

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Throw New Exception($"Failed to insert event {eventInfo.EventName} into tblRegister")
                    End If
                Next
                '  MessageBox.Show($"Successfully registered for {selectedEvents.Count} event(s).", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error registering for events: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim profileForm As New FrmProfile()

        ' Set the MdiParent instead of Owner
        If TypeOf Me.Owner Is FrmMain Then
            profileForm.MdiParent = DirectCast(Me.Owner, FrmMain)
        End If

        ' Pass Email and Password
        profileForm.txtPEmail.Text = txtEmail.Text
        profileForm.txtPPassword.Text = txtPassword.Text

        ' Pass Checkbox States
        profileForm.cbxPYes.Checked = cbxYes.Checked
        profileForm.cbxPPrint.Checked = cbxPrint.Checked
        profileForm.cbxPIndexing.Checked = cbxIndexing.Checked
        profileForm.cbxPOnline.Checked = cbxOnline.Checked
        profileForm.cbxPWebsite.Checked = cbxWebsite.Checked
        profileForm.cbxPClass.Checked = cbxClass.Checked
        profileForm.cbxPOther.Checked = cbxOther.Checked

        ' Pass Selected Event
        profileForm.cboPRegister.Text = cboRegister.Text

        ' Pass the selected events to FrmProfile
        profileForm.RegisteredEvents = New List(Of EventInfo)(selectedEvents)

        ' Show the form without using ShowDialog
        profileForm.Show()

        ' Close the login form
        Me.Close()
    End Sub

    Private Sub LoadAvailableEvents()
        Dim currentDate As Date = DateTime.Now.Date
        Dim query As String = "SELECT EventName FROM tblEvents WHERE RegStart <= ? AND RegStop >= ? AND Inactive = False"


        Using conn As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, conn)
                command.Parameters.Add("?", OleDbType.Date).Value = currentDate
                command.Parameters.Add("?", OleDbType.Date).Value = currentDate

                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    cboRegister.Items.Clear()

                    While reader.Read()
                        cboRegister.Items.Add(reader("EventName").ToString())
                    End While

                    reader.Close()
                    cboRegister.Visible = cboRegister.Items.Count > 0
                    lblRegister.Visible = cboRegister.Visible
                Catch ex As Exception
                    MessageBox.Show("Error loading events: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cboRegister_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRegister.SelectedIndexChanged
        cbxEYes.Checked = False
    End Sub

    Private Sub cbxEYes_CheckedChanged(sender As Object, e As EventArgs) Handles cbxEYes.CheckedChanged
        If cbxEYes.Checked AndAlso cboRegister.SelectedIndex >= 0 Then
            Dim eventName As String = cboRegister.SelectedItem.ToString()
            Dim eventInfo = GetEventInfoFromDatabase(eventName)

            If eventInfo IsNot Nothing Then
                Dim alreadyAdded As Boolean = False
                For Each existingEvent In selectedEvents
                    If existingEvent.EventID = eventInfo.EventID Then
                        alreadyAdded = True
                        Exit For
                    End If
                Next

                If Not alreadyAdded Then
                    selectedEvents.Add(eventInfo)
                    MessageBox.Show($"Event '{eventInfo.EventName}' added to registration list.")
                Else
                    MessageBox.Show($"Event '{eventInfo.EventName}' is already in the registration list.")
                End If
                cboRegister.SelectedIndex = -1
                cbxEYes.Checked = False
            Else
                MessageBox.Show("Error: Could not find event details in the database.")
            End If
        End If
    End Sub
    Private Function GetEventInfoFromDatabase(eventName As String) As EventInfo

        Using conn As New OleDbConnection(connectionString)
            Dim query As String = "SELECT EventID, EventName, EventDate FROM tblEvents WHERE EventName = ?"
            Using command As New OleDbCommand(query, conn)
                command.Parameters.Add("?", OleDbType.VarWChar).Value = eventName
                Try
                    conn.Open()
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Return New EventInfo With {
                                .EventID = Convert.ToInt32(reader("EventID")),
                                .EventName = reader("EventName").ToString(),
                                .EventDate = Convert.ToDateTime(reader("EventDate")),
                                .RegisterDate = DateTime.Now.Date
                            }
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error fetching event details: " & ex.Message)
                End Try
            End Using
        End Using
        Return Nothing
    End Function
End Class

Public Class CurrentUser
    Public Shared Property LoginID As Integer
    Public Shared Property Role As String

    Public Shared Sub SetCurrentUser(id As Integer, role As String)
        LoginID = id
        CurrentUser.Role = role
    End Sub
End Class