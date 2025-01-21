Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class FrmProfileUpdate
    Inherits Form
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private LoginID As Integer
    Private ContactID As Integer
    Private emailChanged As Boolean = False
    Private pinChanged As Boolean = False
    Private dataChanged As Boolean = False
    Private lblRetype As Label
    Private currentRole As String
    Private currentUserName As String
    Private fullName As String


    Public Sub New()
        InitializeComponent()
    End Sub

    ' Keep the existing constructor
    Public Sub New(dataChanged As Boolean)
        '  InitializeComponent()
        Me.dataChanged = dataChanged
    End Sub

    Private Sub FrmUpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        lblRole.Text = GlobalVariables.CurrentUserRole
        InitializeControls()
        LoadComboBoxes()
    End Sub

    Private Sub InitializeControls()
        ' Enable initial controls
        lblName.Enabled = True
        cboName.Enabled = True
        lblUPIN.Enabled = True
        txtUPIN.Enabled = True
        lblUMatch.Enabled = True
        lblUMatch.BackColor = Color.Red
        lblUMatch.Text = "No Match"
        lblUMatch.ForeColor = Color.White
        btnUCancel.Enabled = True

        ' Disable other controls
        Dim controlsToDisable() As Control = {
            lblUFirst, txtUFirst, lblUMiddle, txtUMiddle, lblULast, txtULast,
            lblUAddress, txtUAddress, lblUCity, txtUCity, lblUState, cboUState,
            lblUZip, txtUZip, lblUPhone, txtUPhone, lblUType, cboUType, btnUSave
        }

        For Each ctrl In controlsToDisable
            ctrl.Enabled = False
        Next
    End Sub

    Private Sub LoadComboBoxes()
        currentRole = GlobalVariables.CurrentUserRole
        currentUserName = GlobalVariables.CurrentUserName

        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            Select Case currentRole
                Case "Patron"
                    ' Patron can only see their own name
                    cboName.Items.Clear()
                    cboName.Items.Add(currentUserName)
                    cboName.SelectedIndex = 0
                    cboName.Enabled = False
                    txtUPIN.Enabled = True
                    lblUMatch.Enabled = True

                Case "Staff", "Director", "Admin"
                    ' Staff and above can see all names
                    Dim cmd As New OleDbCommand("SELECT FullName FROM tblContacts ORDER BY FullName", conn)
                    Using da As New OleDbDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        Dim emptyRow As DataRow = dt.NewRow()
                        emptyRow("FullName") = ""
                        dt.Rows.InsertAt(emptyRow, 0)
                        cboName.DataSource = dt
                        cboName.DisplayMember = "FullName"
                        cboName.ValueMember = "FullName"
                    End Using
                    txtUPIN.Enabled = False
                    lblUMatch.Text = "Not Required"
                    lblUMatch.BackColor = Color.Green
                    lblUMatch.ForeColor = Color.White

            End Select

            ' Load states and types (existing code)
            Dim stateCmd As New OleDbCommand("SELECT States FROM tblStates", conn)
            Using stateReader As OleDbDataReader = stateCmd.ExecuteReader()
                While stateReader.Read()
                    cboUState.Items.Add(stateReader("States").ToString())
                End While
            End Using

            Dim typeCmd As New OleDbCommand("SELECT Types FROM tblTypes", conn)
            Using typeReader As OleDbDataReader = typeCmd.ExecuteReader()
                While typeReader.Read()
                    cboUType.Items.Add(typeReader("Types").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        emailChanged = True
        CheckCredentials()
    End Sub

    Private Sub txtUPIN_TextChanged(sender As Object, e As EventArgs) Handles txtUPIN.TextChanged
        pinChanged = True
        CheckCredentials()
    End Sub

    Private Sub CheckCredentials()
        Dim fullName As String = cboName.Text

        If currentRole = "Staff" OrElse currentRole = "Director" OrElse currentRole = "Admin" Then
            txtUPIN.Enabled = False
            lblUMatch.Text = "Not Required"
            lblUMatch.BackColor = Color.Green
            lblUMatch.ForeColor = Color.White

            If Not String.IsNullOrEmpty(fullName) Then
                Using conn As New OleDbConnection(connectionString)
                    conn.Open()
                    Dim cmd As New OleDbCommand("SELECT l.LoginID FROM tblLogin l INNER JOIN tblContacts c ON l.LoginID = c.LoginID WHERE c.FullName = @FullName", conn)
                    cmd.Parameters.AddWithValue("@FullName", fullName)

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        LoginID = Convert.ToInt32(result)
                        EnableDataFields()
                        LoadUserData(fullName)
                    Else
                        DisableDataFields()
                    End If
                End Using
            End If
            Return
        End If

        ' Original PIN verification for Patron role
        If emailChanged And pinChanged Then
            Dim pin As String = txtUPIN.Text

            If pin.Length >= 4 And pin.Length <= 6 And IsNumeric(pin) Then
                Using conn As New OleDbConnection(connectionString)
                    conn.Open()
                    Dim cmd As New OleDbCommand("SELECT l.LoginID FROM tblLogin l INNER JOIN tblContacts c ON l.LoginID = c.LoginID WHERE c.FullName = @FullName AND l.PIN = @PIN", conn)
                    cmd.Parameters.AddWithValue("@FullName", fullName)
                    cmd.Parameters.AddWithValue("@PIN", pin)

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        LoginID = Convert.ToInt32(result)
                        lblUMatch.BackColor = Color.Green
                        lblUMatch.Text = "Match"
                        lblUMatch.ForeColor = Color.White
                        EnableDataFields()
                        LoadUserData(fullName)
                    Else
                        LoginID = 0
                        lblUMatch.BackColor = Color.Red
                        lblUMatch.Text = "No Match"
                        lblUMatch.ForeColor = Color.White
                        DisableDataFields()
                    End If
                End Using
            Else
                LoginID = 0
                lblUMatch.BackColor = Color.Red
                lblUMatch.Text = "No Match"
                lblUMatch.ForeColor = Color.White
                DisableDataFields()
            End If
        End If
    End Sub

    Private Sub EnableDataFields()
        Dim controlsToEnable() As Control = {
            lblUFirst, txtUFirst, lblUMiddle, txtUMiddle, lblULast, txtULast,
            lblUAddress, txtUAddress, lblUCity, txtUCity, lblUState, cboUState,
            lblUZip, txtUZip, lblUPhone, txtUPhone, lblUType, cboUType
        }

        For Each ctrl In controlsToEnable
            ctrl.Enabled = True
        Next
    End Sub

    Private Sub DisableDataFields()
        Dim controlsToDisable() As Control = {
            lblUFirst, txtUFirst, lblUMiddle, txtUMiddle, lblULast, txtULast,
            lblUAddress, txtUAddress, lblUCity, txtUCity, lblUState, cboUState,
            lblUZip, txtUZip, lblUPhone, txtUPhone, lblUType, cboUType, btnUSave
        }

        For Each ctrl In controlsToDisable
            ctrl.Enabled = False
        Next
    End Sub

    Private Sub LoadUserData(email As String)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            ' Get Contact information
            Dim contactCmd As New OleDbCommand("SELECT * FROM tblContacts WHERE LoginID = ?", conn)
            contactCmd.Parameters.AddWithValue("@LoginID", LoginID)
            Dim contactReader As OleDbDataReader = contactCmd.ExecuteReader()

            If contactReader.Read() Then
                txtUFirst.Text = contactReader("FirstName").ToString()
                txtUMiddle.Text = contactReader("MiddleName").ToString()
                txtULast.Text = contactReader("LastName").ToString()
            End If
            contactReader.Close()

            ' Get Address information
            Dim addressCmd As New OleDbCommand("SELECT * FROM tblAddress WHERE ContactID = (SELECT ContactID FROM tblContacts WHERE LoginID = ?)", conn)
            addressCmd.Parameters.AddWithValue("@LoginID", LoginID)
            Dim addressReader As OleDbDataReader = addressCmd.ExecuteReader()

            If addressReader.Read() Then
                txtUAddress.Text = addressReader("Address").ToString()
                txtUCity.Text = addressReader("City").ToString()
                cboUState.Text = addressReader("State").ToString()
                txtUZip.Text = addressReader("Zip").ToString()
            End If
            addressReader.Close()

            ' Get Phone information
            Dim phoneCmd As New OleDbCommand("SELECT * FROM tblPhone WHERE ContactID = (SELECT ContactID FROM tblContacts WHERE LoginID = ?)", conn)
            phoneCmd.Parameters.AddWithValue("@LoginID", LoginID)
            Dim phoneReader As OleDbDataReader = phoneCmd.ExecuteReader()

            If phoneReader.Read() Then
                txtUPhone.Text = phoneReader("PhoneNumber").ToString()
                cboUType.Text = phoneReader("PhoneType").ToString()
            End If
            phoneReader.Close()
        End Using

        ' Reset the dataChanged flag after loading the data
        dataChanged = False
        btnUSave.Enabled = False
    End Sub

    Private Sub DataField_TextChanged(sender As Object, e As EventArgs) Handles txtUFirst.TextChanged, txtUMiddle.TextChanged, txtULast.TextChanged, txtUAddress.TextChanged, txtUCity.TextChanged, txtUZip.TextChanged
        dataChanged = True
        btnUSave.Enabled = True
    End Sub

    Private Sub DataComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUState.SelectedIndexChanged, cboUType.SelectedIndexChanged
        dataChanged = True
        btnUSave.Enabled = True
    End Sub

    Private Sub btnUCancel_Click(sender As Object, e As EventArgs) Handles btnUCancel.Click
        Me.Close()
    End Sub

    Private Sub txtUPhone_TextChanged(sender As Object, e As EventArgs) Handles txtUPhone.TextChanged
        ' Store the current cursor position
        Dim cursorPosition As Integer = txtUPhone.SelectionStart

        ' Remove any non-digit characters
        Dim digitsOnly As String = Regex.Replace(txtUPhone.Text, "[^\d]", "")

        ' Format the phone number if it's 10 digits
        If digitsOnly.Length = 10 Then
            txtUPhone.Text = FormatPhoneNumber(digitsOnly)
        Else
            txtUPhone.Text = digitsOnly
        End If

        ' Adjust the cursor position
        If cursorPosition > txtUPhone.Text.Length Then
            txtUPhone.SelectionStart = txtUPhone.Text.Length
        Else
            txtUPhone.SelectionStart = cursorPosition
        End If

        dataChanged = True
        btnUSave.Enabled = True
    End Sub

    Private Function FormatPhoneNumber(input As String) As String
        Dim digitsOnly As String = Regex.Replace(input, "[^\d]", "")
        If digitsOnly.Length = 10 Then
            Return String.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 3), digitsOnly.Substring(3, 3), digitsOnly.Substring(6))
        Else
            Return input ' Return the original input if it's not 10 digits
        End If
    End Function

    Private Sub txtUZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUZip.KeyPress
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
        If txtUZip.Text.Length >= 5 Then
            e.Handled = True
            Return
        End If

        ' If we're here, it's a digit and the length is less than 5, so allow it
    End Sub

    Private Sub txtUZip_TextChanged(sender As Object, e As EventArgs) Handles txtUZip.TextChanged
        ' Remove any non-digit characters
        txtUZip.Text = New String(txtUZip.Text.Where(Function(c) Char.IsDigit(c)).ToArray())

        ' Limit to 5 digits if somehow more than 5 digits were entered
        If txtUZip.Text.Length > 5 Then
            txtUZip.Text = txtUZip.Text.Substring(0, 5)
        End If

        ' Move cursor to end of text
        txtUZip.SelectionStart = txtUZip.Text.Length
    End Sub

    Private Sub txtUZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUZip.Validating
        If txtUZip.Text.Length < 5 Then
            MessageBox.Show("ZIP code must be 5 digits.")
            e.Cancel = True
        End If
    End Sub

    Private Sub btnUSave_Click(sender As Object, e As EventArgs) Handles btnUSave.Click
        If LoginID = 0 Then
            MessageBox.Show("Please select a valid user before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim transaction As OleDbTransaction = connection.BeginTransaction()

            Try
                Dim contactRowsAffected = UpdateContact(connection, transaction)
                Dim addressRowsAffected = UpdateAddress(connection, transaction)
                Dim phoneRowsAffected = UpdatePhone(connection, transaction)

                transaction.Commit()

                Me.Close()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("Error updating profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function UpdateContact(connection As OleDbConnection, transaction As OleDbTransaction) As Integer
        Dim cmd As New OleDbCommand("UPDATE tblContacts SET FirstName = ?, MiddleName = ?, LastName = ?, FullName = ? WHERE LoginID = ?", connection, transaction)

        cmd.Parameters.AddWithValue("?", txtUFirst.Text)
        cmd.Parameters.AddWithValue("?", txtUMiddle.Text)
        cmd.Parameters.AddWithValue("?", txtULast.Text)
        cmd.Parameters.AddWithValue("?", $"{txtUFirst.Text} {txtUMiddle.Text} {txtULast.Text}".Trim())
        cmd.Parameters.AddWithValue("?", LoginID)

        Return cmd.ExecuteNonQuery()
    End Function

    Private Function UpdateAddress(connection As OleDbConnection, transaction As OleDbTransaction) As Integer
        Dim zipCode As String = txtUZip.Text.PadLeft(5, "0"c)

        ' First, get the ContactID
        Dim getContactIDCmd As New OleDbCommand("SELECT ContactID FROM tblContacts WHERE LoginID = ?", connection, transaction)
        getContactIDCmd.Parameters.AddWithValue("?", LoginID)
        Dim contactID As Object = getContactIDCmd.ExecuteScalar()

        If contactID Is Nothing Then
            Throw New Exception("ContactID not found for the given LoginID")
        End If

        ' Now update the address using the ContactID
        Dim cmd As New OleDbCommand("UPDATE tblAddress SET Address = ?, City = ?, State = ?, Zip = ? WHERE ContactID = ?", connection, transaction)
        cmd.Parameters.AddWithValue("?", txtUAddress.Text)
        cmd.Parameters.AddWithValue("?", txtUCity.Text)
        cmd.Parameters.AddWithValue("?", cboUState.Text)
        cmd.Parameters.Add("?", OleDbType.Char, 5).Value = zipCode
        cmd.Parameters.AddWithValue("?", contactID)

        Return cmd.ExecuteNonQuery()
    End Function

    Private Function UpdatePhone(connection As OleDbConnection, transaction As OleDbTransaction) As Integer
        ' First, get the ContactID
        Dim getContactIDCmd As New OleDbCommand("SELECT ContactID FROM tblContacts WHERE LoginID = ?", connection, transaction)
        getContactIDCmd.Parameters.AddWithValue("?", LoginID)
        Dim contactID As Object = getContactIDCmd.ExecuteScalar()

        If contactID Is Nothing Then
            Throw New Exception("ContactID not found for the given LoginID")
        End If

        ' Now update the phone using the ContactID
        Dim cmd As New OleDbCommand("UPDATE tblPhone SET PhoneNumber = ?, PhoneType = ? WHERE ContactID = ?", connection, transaction)
        cmd.Parameters.AddWithValue("?", txtUPhone.Text)
        cmd.Parameters.AddWithValue("?", cboUType.Text)
        cmd.Parameters.AddWithValue("?", contactID)

        Return cmd.ExecuteNonQuery()
    End Function
End Class