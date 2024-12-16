Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class FrmProfile
    Inherits Form

    Public Property RegisteredEvents As List(Of EventInfo)

    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private dataChanged As Boolean
    Private LoginID As Integer
    Private ContactID As Integer
    Private StakeID As Integer = 0
    Private WardID As Integer = 0
    Private selectedEvents As New List(Of EventInfo) ' This will hold events selected in FrmProfile

    Private Const Director As String = "staciebriggs23@gmail.com"
    Private Const Admin As String = "mcgriffith1965@gmail.com"

    Public Sub New()
        InitializeComponent()
        RegisteredEvents = New List(Of EventInfo)() ' Initialize the list
    End Sub

    Private Sub FrmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        InitializeControls()
        LoadDropdowns()
        LoadAvailableEvents()
    End Sub

    Private Sub InitializeControls()
        ' Disable controls initially
        SetControlsEnabled(False)
        SetRoleControlsEnabled(False)
        SetLDSControlsEnabled(False)
        lblPMatch.BackColor = Color.Red
        btnPSave.Enabled = False
    End Sub

    Private Sub SetControlsEnabled(enabled As Boolean)
        Dim controls() As Control = {
        lblPFirst, txtPFirst, lblPMiddle, txtPMiddle, lblPLast, txtPLast,
        lblPAddress, txtPAddress, lblPCity, txtPCity, lblPState, cboPState,
        lblPZip, txtPZip, lblPPhone, txtPPhone, lblPType, cboPType, GroupBox3, rbPYes, rbPNo
    }
        For Each ctrl In controls
            ctrl.Enabled = enabled
        Next
    End Sub

    Private Sub SetRoleControlsEnabled(enabled As Boolean)
        Dim controls() As Control = {
        rbPPatron, rbPStaff, rbPDirector, rbPAdmin
    }
        For Each ctrl In controls
            ctrl.Enabled = enabled
        Next
    End Sub

    Private Sub SetLDSControlsEnabled(enabled As Boolean)
        Dim controls() As Control = {
        lblPStake, cboPStake, lblPWard, cboPWard
    }
        For Each ctrl In controls
            ctrl.Enabled = enabled
        Next
    End Sub

    Private Sub LoadDropdowns()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            LoadComboBox(cboPState, "SELECT States FROM tblStates", conn)
            LoadComboBox(cboPType, "SELECT Types FROM tblTypes", conn)
        End Using
        LoadStakes()
    End Sub

    Private Sub LoadComboBox(comboBox As ComboBox, query As String, connection As OleDbConnection)
        Using command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()
            While reader.Read()
                comboBox.Items.Add(reader(0).ToString())
            End While
        End Using
    End Sub



    Private Sub txtPRetype_TextChanged(sender As Object, e As EventArgs) Handles txtPRetype.TextChanged
        If txtPRetype.Text = txtPPassword.Text Then
            lblRetype.ForeColor = Color.Black
            lblPMatch.BackColor = Color.Green
            SetControlsEnabled(True)
        Else
            lblRetype.ForeColor = Color.Red
            lblPMatch.BackColor = Color.Red
            SetControlsEnabled(False)
        End If
    End Sub

    Private Sub txtPPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPPhone.TextChanged
        ' Store the current cursor position
        Dim cursorPosition As Integer = txtPPhone.SelectionStart

        ' Remove any non-digit characters
        Dim digitsOnly As String = Regex.Replace(txtPPhone.Text, "[^\d]", "")

        ' Format the phone number if it's 10 digits
        If digitsOnly.Length = 10 Then
            txtPPhone.Text = FormatPhoneNumber(digitsOnly)
        Else
            txtPPhone.Text = digitsOnly
        End If

        ' Adjust the cursor position
        If cursorPosition > txtPPhone.Text.Length Then
            txtPPhone.SelectionStart = txtPPhone.Text.Length
        Else
            txtPPhone.SelectionStart = cursorPosition
        End If

        dataChanged = True
        '   btnPSave.Enabled = True
    End Sub

    Private Function FormatPhoneNumber(input As String) As String
        Dim digitsOnly As String = Regex.Replace(input, "[^\d]", "")
        If digitsOnly.Length = 10 Then
            Return String.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 3), digitsOnly.Substring(3, 3), digitsOnly.Substring(6))
        Else
            Return input ' Return the original input if it's not 10 digits
        End If
    End Function

    Private Sub txtPZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPZip.KeyPress
        ' Allow only digits and control characters
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        ' Allow backspace (to delete) even if length is less than 5
        If e.KeyChar = ChrW(Keys.Back) Then
            Return
        End If

        ' Prevent input if length is already 5 and it's not a control character
        If txtPZip.Text.Length >= 5 Then
            e.Handled = True
            Return
        End If

        ' If we're here, it's a digit and the length is less than 5, so allow it
    End Sub

    Private Sub txtPZip_TextChanged(sender As Object, e As EventArgs) Handles txtPZip.TextChanged
        ' Remove any non-digit characters
        txtPZip.Text = New String(txtPZip.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Limit to 5 digits if somehow more than 5 digits were entered
        If txtPZip.Text.Length > 5 Then
            txtPZip.Text = txtPZip.Text.Substring(0, 5)
        End If

        ' Move cursor to end of text
        txtPZip.SelectionStart = txtPZip.Text.Length
    End Sub

    Private Sub txtPZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPZip.Validating
        If txtPZip.Text.Length < 5 Then
            MessageBox.Show("ZIP code must be 5 digits.")
            e.Cancel = True
        End If
    End Sub

    Private Sub rbPNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPNo.CheckedChanged
        If rbPNo.Checked And txtPRetype.Text = txtPPassword.Text Then
            rbPPatron.Enabled = True
            rbPPatron.Checked = True
            SetLDSControlsVisibility(False)
        End If
        UpdateSaveButtonState()
    End Sub

    Private Sub rbPYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbPYes.CheckedChanged
        If rbPYes.Checked And txtPRetype.Text = txtPPassword.Text Then
            SetLDSControlsVisibility(True)
            SetRoleBasedOnEmail()
        Else
            SetLDSControlsVisibility(False)
        End If

    End Sub

    Private Sub cboPStake_TextChanged(sender As Object, e As EventArgs) Handles cboPStake.TextChanged
        UpdateSaveButtonState()
    End Sub

    Private Sub cboPWard_TextChanged(sender As Object, e As EventArgs) Handles cboPWard.TextChanged
        UpdateSaveButtonState()
    End Sub

    Private Sub SetLDSControlsVisibility(visible As Boolean)
        lblPStake.Enabled = visible
        lblPWard.Enabled = visible
        cboPStake.Enabled = visible
        cboPWard.Enabled = visible
    End Sub

    Private Sub SetRoleBasedOnEmail()
        Select Case txtPEmail.Text.Trim()
            Case Director
                SetRoleControls(False, False, True, False)
                rbPDirector.Checked = True
            Case Admin
                SetRoleControls(False, False, False, True)
                rbPAdmin.Checked = True
            Case Else
                SetRoleControls(True, True, False, False)
        End Select
    End Sub

    Private Sub SetRoleControls(patron As Boolean, staff As Boolean, director As Boolean, admin As Boolean)
        rbPPatron.Enabled = patron
        rbPStaff.Enabled = staff
        rbPDirector.Enabled = director
        rbPAdmin.Enabled = admin
    End Sub

    Public Sub SetRegisteredEvents(events As List(Of EventInfo))
        RegisteredEvents = events
        LoadAvailableEvents() ' Refresh the events list
    End Sub

    Private Sub LoadStakes()
        cboPStake.Items.Clear()
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            LoadComboBox(cboPStake, "SELECT StakeNames FROM tblStakes ORDER BY StakeNames", connection)
        End Using
    End Sub

    Private Sub cboPStake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPStake.SelectedIndexChanged
        If cboPStake.SelectedIndex <> -1 Then
            Dim selectedStake As String = cboPStake.SelectedItem.ToString()
            StakeID = GetStakeID(selectedStake)
            LoadWards(StakeID)
        Else
            StakeID = 0
            cboPWard.Items.Clear()
            cboPWard.Text = ""
        End If
        UpdateSaveButtonState()
    End Sub

    Private Sub cboPStake_Leave(sender As Object, e As EventArgs) Handles cboPStake.Leave
        If Not String.IsNullOrWhiteSpace(cboPStake.Text) Then
            Dim stakeName As String = StrConv(cboPStake.Text.Trim(), VbStrConv.ProperCase)
            StakeID = GetOrCreateStake(stakeName)
            If Not cboPStake.Items.Contains(stakeName) Then
                cboPStake.Items.Add(stakeName)
            End If
            cboPStake.Text = stakeName
            LoadWards(StakeID)
        End If
    End Sub

    Private Function GetOrCreateStake(stakeName As String) As Integer
        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            ' Check if the stake exists
            Dim cmd As New OleDbCommand("SELECT StakeID FROM tblStakes WHERE StakeNames = ?", conn)
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = stakeName
            Dim result As Object = cmd.ExecuteScalar()

            If result Is Nothing Then
                ' Insert new stake
                cmd.CommandText = "INSERT INTO tblStakes (StakeNames, CreatedDate) VALUES (?, ?)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = stakeName
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
                cmd.ExecuteNonQuery()

                ' Get the ID of the newly inserted stake
                cmd.CommandText = "SELECT @@IDENTITY"
                Return Convert.ToInt32(cmd.ExecuteScalar())
            Else
                ' Return existing stake ID
                Return Convert.ToInt32(result)
            End If
        End Using
    End Function

    Private Function GetStakeID(stakeName As String) As Integer
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT StakeID FROM tblStakes WHERE StakeNames = ?", conn)
            cmd.Parameters.AddWithValue("@StakeNames", stakeName)
            Dim result As Object = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, Convert.ToInt32(result), 0)
        End Using
    End Function

    Private Sub UpdateStakeLastAccessed(stakeId As Integer, connection As OleDbConnection)
        Dim cmd As New OleDbCommand("UPDATE tblStakes SET LastAccessed = ? WHERE StakeID = ?", connection)
        cmd.Parameters.AddWithValue("@LastAccessed", DateTime.Now)
        cmd.Parameters.AddWithValue("@StakeID", stakeId)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub LoadWards(stakeId As Integer)
        cboPWard.Items.Clear()
        If stakeId = 0 Then Return

        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT WardNames FROM tblWards WHERE StakeID = ? ORDER BY WardNames", conn)
            cmd.Parameters.AddWithValue("@StakeID", stakeId)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                cboPWard.Items.Add(reader("WardNames").ToString())
            End While
        End Using
    End Sub

    Private Sub cboPWard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPWard.SelectedIndexChanged
        If cboPWard.SelectedIndex <> -1 And StakeID <> 0 Then
            Dim selectedWard As String = cboPWard.SelectedItem.ToString()
            WardID = GetWardID(selectedWard, StakeID)
        Else
            WardID = 0
        End If
        UpdateSaveButtonState()
    End Sub

    Private Sub cboPWard_Leave(sender As Object, e As EventArgs) Handles cboPWard.Leave
        If Not String.IsNullOrWhiteSpace(cboPWard.Text) And StakeID <> 0 Then
            Dim wardName As String = StrConv(cboPWard.Text.Trim(), VbStrConv.ProperCase)
            WardID = GetOrCreateWard(wardName, StakeID)
            If Not cboPWard.Items.Contains(wardName) Then
                cboPWard.Items.Add(wardName)
            End If
            cboPWard.Text = wardName
        End If
    End Sub

    Private Function GetOrCreateWard(wardName As String, stakeId As Integer) As Integer
        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            Dim cmd As New OleDbCommand("SELECT WardID FROM tblWards WHERE WardNames = ? AND StakeID = ?", conn)
            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = wardName
            cmd.Parameters.Add("?", OleDbType.Integer).Value = stakeId
            Dim result As Object = cmd.ExecuteScalar()

            If result Is Nothing Then
                cmd.CommandText = "INSERT INTO tblWards (WardNames, CreatedDate, StakeID) VALUES (?, ?, ?)"
                cmd.Parameters.Clear()
                cmd.Parameters.Add("?", OleDbType.VarWChar).Value = wardName
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now
                cmd.Parameters.Add("?", OleDbType.Integer).Value = stakeId
                cmd.ExecuteNonQuery()

                cmd.CommandText = "SELECT @@IDENTITY"
                Return Convert.ToInt32(cmd.ExecuteScalar())
            Else
                Return Convert.ToInt32(result)
            End If
        End Using
    End Function

    Private Function GetWardID(wardName As String, stakeId As Integer) As Integer
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT WardID FROM tblWards WHERE WardNames = ? AND StakeID = ?", conn)
            cmd.Parameters.AddWithValue("@WardNames", wardName)
            cmd.Parameters.AddWithValue("@StakeID", stakeId)
            Dim result As Object = cmd.ExecuteScalar()
            Return If(result IsNot Nothing, Convert.ToInt32(result), 0)
        End Using
    End Function

    Private Sub UpdateWardLastAccessed(wardId As Integer, connection As OleDbConnection)
        Dim cmd As New OleDbCommand("UPDATE tblWards SET LastAccessed = ? WHERE WardID = ?", connection)
        cmd.Parameters.AddWithValue("@LastAccessed", DateTime.Now)
        cmd.Parameters.AddWithValue("@WardID", wardId)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub UpdateSaveButtonState()
        Dim saveEnabled As Boolean = False

        If rbPNo.Checked Then
            ' If LDS is set to No, enable the Save button
            rbPNo.Checked = True
            saveEnabled = True
        ElseIf rbPYes.Checked Then
            ' If LDS is set to Yes, check if both Stake and Ward are selected or entered
            If Not String.IsNullOrWhiteSpace(cboPStake.Text) AndAlso Not String.IsNullOrWhiteSpace(cboPWard.Text) Then
                saveEnabled = True
            End If
        End If

        ' Enable or disable the Save button
        btnPSave.Enabled = saveEnabled
    End Sub

    Private Function GetSelectedRole() As String
        If rbPAdmin.Checked Then
            Return "Admin"
        ElseIf rbPDirector.Checked Then
            Return "Director"
        ElseIf rbPStaff.Checked Then
            Return "Staff"
        Else
            Return "Patron"
        End If
    End Function

    Private Sub LoadAvailableEvents()
        Dim currentDate As Date = DateTime.Now.Date
        Dim query As String = "SELECT EventID, EventName, EventDate FROM tblEvents WHERE RegStart <= ? AND RegStop >= ? AND Inactive = False"

        Using conn As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, conn)
                command.Parameters.AddWithValue("?", currentDate)
                command.Parameters.AddWithValue("?", currentDate)

                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = command.ExecuteReader()
                    cboPRegister.Items.Clear()
                    selectedEvents.Clear() ' Clear previous selections

                    While reader.Read()
                        Dim eventInfo As New EventInfo With {
                        .EventID = CInt(reader("EventID")),
                        .EventName = reader("EventName").ToString(),
                        .EventDate = CDate(reader("EventDate"))
                    }
                        cboPRegister.Items.Add(eventInfo.EventName)
                        selectedEvents.Add(eventInfo) ' Add to selected events
                    End While

                    ' Add previously registered events from FrmLogin
                    For Each registeredEvent In RegisteredEvents
                        If Not cboPRegister.Items.Contains(registeredEvent.EventName) Then
                            cboPRegister.Items.Add(registeredEvent.EventName)
                            selectedEvents.Add(registeredEvent) ' Ensure it's also in the selectedEvents list
                        End If
                    Next

                    cboPRegister.Visible = (cboPRegister.Items.Count > 0)
                    lblPRegister.Visible = (cboPRegister.Items.Count > 0)
                    cbxPEYes.Visible = (cboPRegister.Items.Count > 0)

                Catch ex As Exception
                    MessageBox.Show("Error loading events: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cbxPEYes_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPEYes.CheckedChanged
        If cbxPEYes.Checked AndAlso cboPRegister.SelectedIndex >= 0 Then
            Dim selectedEvent = selectedEvents(cboPRegister.SelectedIndex)
            selectedEvent.IsSelected = True

            MessageBox.Show($"Selected for registration: {selectedEvent.EventName} on {selectedEvent.EventDate.ToShortDateString()}")

            ' Add to RegisteredEvents if not already present
            If Not RegisteredEvents.Any(Function(evt) evt.EventID = selectedEvent.EventID) Then
                RegisteredEvents.Add(selectedEvent)
            End If

            cboPRegister.SelectedIndex = -1
            cbxPEYes.Checked = False
        Else
            If cbxPEYes.Checked Then
                MessageBox.Show("Please select an event first.")
                cbxPEYes.Checked = False
            End If
        End If
    End Sub

    Private Sub btnPSave_Click(sender As Object, e As EventArgs) Handles btnPSave.Click
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim transaction As OleDbTransaction = conn.BeginTransaction()

            Try
                LoginID = InsertLogin(conn, transaction)
                ContactID = InsertContact(conn, transaction)
                Dim AddressID As Integer = InsertAddress(conn, transaction)
                Dim PhoneID As Integer = InsertPhone(conn, transaction, AddressID)
                InsertLDS(conn, transaction)
                InsertAttendance(conn, transaction)
                RegisterForEvents(conn, transaction) ' Register only selected events
                InsertVolunteer(conn, transaction, LoginID, ContactID, AddressID, PhoneID)

                transaction.Commit()
                MessageBox.Show("Profile created successfully!")

                ' Enable the Patron menu in the main form  
                If TypeOf Me.MdiParent Is FrmMain Then
                    CType(Application.OpenForms("FrmMain"), FrmMain).UpdateMenuAccess()
                End If

                ' Close the form  
                Me.Close()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error saving profile: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Function InsertLogin(connection As OleDbConnection, transaction As OleDbTransaction) As Integer
        Dim cmd As New OleDbCommand("INSERT INTO tblLogin ([Email], [Password], [Role], [PIN]) VALUES (@Email, @Password, @Role, @PIN)", connection, transaction)

        cmd.Parameters.AddWithValue("@Email", txtPEmail.Text)
        cmd.Parameters.AddWithValue("@Password", txtPPassword.Text)
        cmd.Parameters.AddWithValue("@Role", GetSelectedRole())
        cmd.Parameters.AddWithValue("@PIN", txtPIN.Text)

        cmd.ExecuteNonQuery()

        cmd.CommandText = "SELECT @@IDENTITY"
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function InsertContact(connection As OleDbConnection, transaction As OleDbTransaction) As Integer
        Dim cmd As New OleDbCommand("INSERT INTO tblContacts ([FirstName], [MiddleName], [LastName], [FullName], [LoginID]) VALUES (@FirstName, @MiddleName, @LastName, @FullName, @LoginID)", connection, transaction)

        cmd.Parameters.AddWithValue("@FirstName", txtPFirst.Text)
        cmd.Parameters.AddWithValue("@MiddleName", txtPMiddle.Text)
        cmd.Parameters.AddWithValue("@LastName", txtPLast.Text)
        cmd.Parameters.AddWithValue("@FullName", $"{txtPFirst.Text} {txtPMiddle.Text} {txtPLast.Text}".Trim())
        cmd.Parameters.AddWithValue("@LoginID", LoginID)

        cmd.ExecuteNonQuery()

        cmd.CommandText = "SELECT @@IDENTITY"
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function InsertAddress(connection As OleDbConnection, transaction As OleDbTransaction) As Integer
        Dim zipCode As String = txtPZip.Text.PadLeft(5, "0"c)
        Dim cmd As New OleDbCommand("INSERT INTO tblAddress ([Address], [City], [State], [Zip], [ContactID]) VALUES (@Address, @City, @State, @Zip, @ContactID)", connection, transaction)

        cmd.Parameters.AddWithValue("@Address", txtPAddress.Text)
        cmd.Parameters.AddWithValue("@City", txtPCity.Text)
        cmd.Parameters.AddWithValue("@State", cboPState.Text)
        cmd.Parameters.Add("@ZipCode", OleDbType.Char, 5).Value = zipCode
        cmd.Parameters.AddWithValue("@ContactID", ContactID)

        cmd.ExecuteNonQuery()

        cmd.CommandText = "SELECT @@IDENTITY"
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Function InsertPhone(connection As OleDbConnection, transaction As OleDbTransaction, AddressID As Integer) As Integer
        Dim cmd As New OleDbCommand("INSERT INTO tblPhone ([PhoneNumber], [PhoneType], [ContactID], [AddressID]) VALUES (@PhoneNumber, @PhoneType, @ContactID, @AddressID)", connection, transaction)

        cmd.Parameters.AddWithValue("@PhoneNumber", txtPPhone.Text)
        cmd.Parameters.AddWithValue("@PhoneType", cboPType.Text)
        cmd.Parameters.AddWithValue("@ContactID", ContactID)
        cmd.Parameters.AddWithValue("@AddressID", AddressID)

        cmd.ExecuteNonQuery()

        cmd.CommandText = "SELECT @@IDENTITY"
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function
    Private Sub InsertLDS(connection As OleDbConnection, transaction As OleDbTransaction)
        Dim cmd As New OleDbCommand("INSERT INTO tblLDS ([LDSID], [LDSYes], [LDSNo], [StakeName], [WardName]) VALUES (@LDSID, @LDSYes, @LDSNo, @StakeName, @WardName)", connection, transaction)

        cmd.Parameters.AddWithValue("@LDSID", LoginID)
        cmd.Parameters.AddWithValue("@LDSYes", rbPYes.Checked)
        cmd.Parameters.AddWithValue("@LDSNo", rbPNo.Checked)
        cmd.Parameters.AddWithValue("@StakeName", If(rbPYes.Checked, cboPStake.Text, DBNull.Value))
        cmd.Parameters.AddWithValue("@WardName", If(rbPYes.Checked, cboPWard.Text, DBNull.Value))

        cmd.ExecuteNonQuery()
    End Sub

    Private Sub InsertAttendance(connection As OleDbConnection, transaction As OleDbTransaction)
        Dim cmd As New OleDbCommand("INSERT INTO tblAttendance ([LogDate], [LogTime], [FirstVisit], [PrintFOR], [Indexing], [OnlineRsrch], [SubWebsite], [AttendClass], [Other], [LoginID], [People]) VALUES (@LogDate, @LogTime, @FirstVisit, @PrintFOR, @Indexing, @OnlineRsrch, @SubWebsite, @AttendClass, @Other, @LoginID, @People)", connection, transaction)

        cmd.Parameters.AddWithValue("@LogDate", DateTime.Now.Date)
        cmd.Parameters.AddWithValue("@LogTime", DateTime.Now.ToString("HH:mm:ss"))
        cmd.Parameters.AddWithValue("@FirstVisit", cbxPYes.Checked)
        cmd.Parameters.AddWithValue("@PrintFOR", cbxPPrint.Checked)
        cmd.Parameters.AddWithValue("@Indexing", cbxPIndexing.Checked)
        cmd.Parameters.AddWithValue("@OnlineRsrch", cbxPOnline.Checked)
        cmd.Parameters.AddWithValue("@SubWebsite", cbxPWebsite.Checked)
        cmd.Parameters.AddWithValue("@AttendClass", cbxPClass.Checked)
        cmd.Parameters.AddWithValue("@Other", cbxPOther.Checked)
        cmd.Parameters.AddWithValue("@LoginID", LoginID)
        cmd.Parameters.AddWithValue("@People", True) ' Always set People to True

        cmd.ExecuteNonQuery()
    End Sub


    Private Sub RegisterForEvents(connection As OleDbConnection, transaction As OleDbTransaction)
        For Each eventToRegister In RegisteredEvents
            Dim cmd As New OleDbCommand(
            "INSERT INTO tblRegister " &
            "(EventName, EventDate, RegisterDate, EventID, LoginID, Inactive) " &
            "VALUES (?, ?, ?, ?, ?, ?)", connection, transaction)

            cmd.Parameters.Add("EventName", OleDbType.VarChar).Value = eventToRegister.EventName
            cmd.Parameters.Add("EventDate", OleDbType.Date).Value = eventToRegister.EventDate
            cmd.Parameters.Add("RegisterDate", OleDbType.Date).Value = DateTime.Now.Date
            cmd.Parameters.Add("EventID", OleDbType.Integer).Value = eventToRegister.EventID
            cmd.Parameters.Add("LoginID", OleDbType.Integer).Value = LoginID
            cmd.Parameters.Add("Inactive", OleDbType.Boolean).Value = False

            cmd.ExecuteNonQuery()
        Next
    End Sub

    Private Sub InsertVolunteer(connection As OleDbConnection, transaction As OleDbTransaction, LoginID As Integer, ContactID As Integer, AddressID As Integer, PhoneID As Integer)
        ' Only create volunteer records for Staff, Director, and Admin roles
        Dim currentRole As String = GetSelectedRole()

        If currentRole = "Staff" OrElse currentRole = "Director" OrElse currentRole = "Admin" Then
            Dim cmd As New OleDbCommand("INSERT INTO tblVolunteer ([LoginID], [ContactID], [AddressID], [PhoneID], [FullName], [FirstName], [MiddleName], [LastName], [Email], [Phone], [PhoneType], [Address], [City], [State], [Zip], [Role], [Inactive]) VALUES (@LoginID, @ContactID, @AddressID, @PhoneID, @FullName, @FirstName, @MiddleName, @LastName, @Email, @Phone, @PhoneType, @Address, @City, @State, @Zip, @Role, @Inactive)", connection, transaction)

            cmd.Parameters.AddWithValue("@LoginID", LoginID)
            cmd.Parameters.AddWithValue("@ContactID", ContactID)
            cmd.Parameters.AddWithValue("@AddressID", AddressID)
            cmd.Parameters.AddWithValue("@PhoneID", PhoneID)
            cmd.Parameters.AddWithValue("@FullName", CreateFullName())
            cmd.Parameters.AddWithValue("@FirstName", txtPFirst.Text)
            cmd.Parameters.AddWithValue("@MiddleName", txtPMiddle.Text)
            cmd.Parameters.AddWithValue("@LastName", txtPLast.Text)
            cmd.Parameters.AddWithValue("@Email", txtPEmail.Text)
            cmd.Parameters.AddWithValue("@Phone", txtPPhone.Text.Replace("(", "").Replace(")", "").Replace("-", ""))
            cmd.Parameters.AddWithValue("@PhoneType", cboPType.Text)
            cmd.Parameters.AddWithValue("@Address", txtPAddress.Text)
            cmd.Parameters.AddWithValue("@City", txtPCity.Text)
            cmd.Parameters.AddWithValue("@State", cboPState.Text)
            cmd.Parameters.AddWithValue("@Zip", txtPZip.Text)
            cmd.Parameters.AddWithValue("@Role", currentRole)
            cmd.Parameters.AddWithValue("@Inactive", False)

            cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Function CreateFullName() As String
        Dim firstName As String = txtPFirst.Text.Trim()
        Dim middleName As String = txtPMiddle.Text.Trim()
        Dim lastName As String = txtPLast.Text.Trim()

        If String.IsNullOrEmpty(middleName) Then
            Return $"{firstName} {lastName}".Trim()
        Else
            Return $"{firstName} {middleName} {lastName}".Trim()
        End If
    End Function

    Private Sub btnPClose_Click(sender As Object, e As EventArgs) Handles btnPClose.Click
        Me.Close()
    End Sub
End Class