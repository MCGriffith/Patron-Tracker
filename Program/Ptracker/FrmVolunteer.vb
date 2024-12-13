Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class FrmVolunteer
    Inherits Form
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Dim isEditMode As Boolean = False

    Private Sub FrmVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        btnAdd.Enabled = False
        LoadComboBoxes()
        LoadStates()
        LoadTypes()
        SetEditMode(False)
    End Sub

    Private Sub LoadComboBoxes()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT c.FullName, l.Role FROM tblContacts c INNER JOIN tblLogin l ON c.LoginID = l.LoginID WHERE l.Role IN ('Staff', 'Director', 'Admin') ORDER BY c.FullName", conn)
            Using da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Dim emptyRow As DataRow = dt.NewRow()
                emptyRow("FullName") = ""
                emptyRow("Role") = ""
                dt.Rows.InsertAt(emptyRow, 0)
                cboName.DataSource = dt
                cboName.DisplayMember = "FullName"
                cboName.ValueMember = "FullName"
            End Using
        End Using
    End Sub

    Private Sub LoadStates()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT DISTINCT States FROM (SELECT States FROM tblStates UNION SELECT State FROM tblVolunteer) AS States ORDER BY States", conn)
            Using da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Dim emptyRow As DataRow = dt.NewRow()
                emptyRow("States") = ""
                dt.Rows.InsertAt(emptyRow, 0)
                cboState.DataSource = dt
                cboState.DisplayMember = "States"
                cboState.ValueMember = "States"
            End Using
        End Using
    End Sub

    Private Sub LoadTypes()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT DISTINCT Types FROM (SELECT Types FROM tblTypes UNION SELECT PhoneType FROM tblVolunteer) AS Types ORDER BY Types", conn)
            Using da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Dim emptyRow As DataRow = dt.NewRow()
                emptyRow("Types") = ""
                dt.Rows.InsertAt(emptyRow, 0)
                cboType.DataSource = dt
                cboType.DisplayMember = "Types"
                cboType.ValueMember = "Types"
            End Using
        End Using
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If cboName.SelectedValue IsNot Nothing AndAlso cboName.SelectedValue.ToString() <> "" Then
            Dim selectedRow As DataRowView = CType(cboName.SelectedItem, DataRowView)
            txtRole.Text = selectedRow("Role").ToString()
            txtRole.ReadOnly = True

            UpdateVolunteerDetails(selectedRow("FullName").ToString())
            SetEditMode(False)
        Else
            ClearFields()
        End If
    End Sub

    Private Sub UpdateVolunteerDetails(fullName As String)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT FirstName, MiddleName, LastName, Email, Phone, PhoneType, Address, City, State, Zip, Inactive, Availability FROM tblVolunteer WHERE FullName = @FullName", conn)
            cmd.Parameters.AddWithValue("@FullName", fullName)
            Using reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtFirstName.Text = reader("FirstName").ToString()
                    txtMiddleName.Text = reader("MiddleName").ToString()
                    txtLastName.Text = reader("LastName").ToString()
                    txtEmail.Text = reader("Email").ToString()
                    txtPhone.Text = FormatPhoneNumber(reader("Phone").ToString())
                    cboType.SelectedValue = reader("PhoneType").ToString()
                    txtAddress.Text = reader("Address").ToString()
                    txtCity.Text = reader("City").ToString()
                    cboState.SelectedValue = reader("State").ToString()
                    txtZip.Text = reader("Zip").ToString()
                    cbxInactive.Checked = reader("Inactive")
                    txtAvailable.Text = reader("Availability").ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub ClearFields()
        txtRole.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        cboType.SelectedIndex = 0
        txtAddress.Text = ""
        txtCity.Text = ""
        cboState.SelectedIndex = 0
        txtZip.Text = ""
        cbxInactive.Checked = False
        txtAvailable.Text = ""
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        Dim digitsOnly As String = Regex.Replace(txtPhone.Text, "[^\d]", "")
        If digitsOnly.Length = 10 Then
            txtPhone.Text = String.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 3), digitsOnly.Substring(3, 3), digitsOnly.Substring(6))
            txtPhone.SelectionStart = txtPhone.Text.Length
        End If
    End Sub

    Private Function FormatPhoneNumber(input As String) As String
        Dim digitsOnly As String = Regex.Replace(input, "[^\d]", "")
        If digitsOnly.Length = 10 Then
            Return String.Format("({0}) {1}-{2}", digitsOnly.Substring(0, 3), digitsOnly.Substring(3, 3), digitsOnly.Substring(6))
        Else
            Return input
        End If
    End Function

    Private Sub txtZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtZip.Validating
        If Not Regex.IsMatch(txtZip.Text, "^\d{5}$") Then
            MessageBox.Show("Zip code must be exactly 5 digits.", "Invalid Zip Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub

    Private Sub txtZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZip.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso (Not Char.IsDigit(e.KeyChar) OrElse txtZip.Text.Length >= 5) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SetEditMode(True)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isEditMode Then
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("UPDATE tblVolunteer SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Email = @Email, Phone = @Phone, PhoneType = @PhoneType, Address = @Address, City = @City, State = @State, Zip = @Zip, Availability = @Availability WHERE FullName = @FullName", conn)
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                Dim phoneNumber As String = txtPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "")
                cmd.Parameters.AddWithValue("@Phone", phoneNumber)
                cmd.Parameters.AddWithValue("@PhoneType", cboType.SelectedValue)
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@City", txtCity.Text)
                cmd.Parameters.AddWithValue("@State", cboState.SelectedValue)
                cmd.Parameters.AddWithValue("@Zip", txtZip.Text)
                cmd.Parameters.AddWithValue("@Availability", txtAvailable.Text)
                cmd.Parameters.AddWithValue("@FullName", cboName.SelectedValue)
                cmd.ExecuteNonQuery()
            End Using
            UpdateVolunteerDetails(cboName.SelectedValue.ToString())
            SetEditMode(False)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE tblVolunteer SET Inactive = @Inactive WHERE FullName = @FullName", conn)
            cmd.Parameters.AddWithValue("@Inactive", Not cbxInactive.Checked)
            cmd.Parameters.AddWithValue("@FullName", cboName.SelectedValue)
            cmd.ExecuteNonQuery()
        End Using
        UpdateVolunteerDetails(cboName.SelectedValue.ToString())
    End Sub

    Private Sub SetEditMode(editMode As Boolean)
        isEditMode = editMode
        txtFirstName.ReadOnly = Not editMode
        txtMiddleName.ReadOnly = Not editMode
        txtLastName.ReadOnly = Not editMode
        txtEmail.ReadOnly = Not editMode
        txtPhone.ReadOnly = Not editMode
        cboType.Enabled = editMode
        txtAddress.ReadOnly = Not editMode
        txtCity.ReadOnly = Not editMode
        cboState.Enabled = editMode
        txtZip.ReadOnly = Not editMode
        txtAvailable.ReadOnly = Not editMode
        btnEdit.Enabled = Not editMode
        btnSave.Enabled = editMode
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
