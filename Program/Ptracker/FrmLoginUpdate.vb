Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Partial Public Class FrmLoginUpdate
    Inherits Form
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private currentRole As String
    Private currentUserName As String
    Private LoginID As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmLoginUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        lblRole.Text = GlobalVariables.CurrentUserRole
        InitializeControls()
        LoadComboBoxes()
    End Sub

    Private Sub InitializeControls()
        ' Enable initial controls
        cboName.Enabled = True
        lblName.Enabled = True
        lblSPIN.Enabled = True
        txtSPIN.Enabled = True
        lblSMatch.Enabled = True
        lblSMatch.BackColor = Color.Red
        lblSMatch.Text = "No Match"
        lblSMatch.ForeColor = Color.White
        btnSClose.Enabled = True

        ' Disable other controls
        lblSPassword.Enabled = False
        txtSPassword.Enabled = False
        lblSConfirm.Enabled = False
        txtSConfirm.Enabled = False
        lblSPMatch.Enabled = False
        btnSSave.Enabled = False
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
            End Select
        End Using
    End Sub

    Private Sub cboSEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        CheckCredentials()
    End Sub

    Private Sub txtSPIN_TextChanged(sender As Object, e As EventArgs) Handles txtSPIN.TextChanged
        CheckCredentials()
    End Sub

    Private Sub CheckCredentials()
        Dim fullName As String = cboName.Text

        ' Handle Staff, Director, and Admin roles
        If currentRole = "Staff" OrElse currentRole = "Director" OrElse currentRole = "Admin" Then
            txtSPIN.Enabled = False
            lblSMatch.Text = "Not Required"
            lblSMatch.BackColor = Color.Green
            lblSMatch.ForeColor = Color.White

            If Not String.IsNullOrEmpty(fullName) Then
                Using conn As New OleDbConnection(connectionString)
                    conn.Open()
                    Dim cmd As New OleDbCommand("SELECT l.LoginID FROM tblLogin l INNER JOIN tblContacts c ON l.LoginID = c.LoginID WHERE c.FullName = ?", conn)
                    cmd.Parameters.AddWithValue("?", fullName)

                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        LoginID = Convert.ToInt32(result)
                        SetMatch()
                    Else
                        SetNoMatch()
                    End If
                End Using
            End If
            Return
        End If

        ' Handle Patron role
        Dim pin As String = txtSPIN.Text
        If String.IsNullOrEmpty(fullName) OrElse String.IsNullOrEmpty(pin) Then
            SetNoMatch()
            Return
        End If

        If pin.Length >= 4 AndAlso pin.Length <= 6 AndAlso IsNumeric(pin) Then
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT l.LoginID FROM tblLogin l INNER JOIN tblContacts c ON l.LoginID = c.LoginID WHERE c.FullName = ? AND l.PIN = ?", conn)
                cmd.Parameters.AddWithValue("?", fullName)
                cmd.Parameters.AddWithValue("?", pin)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    LoginID = Convert.ToInt32(result)
                    SetMatch()
                Else
                    SetNoMatch()
                End If
            End Using
        Else
            SetNoMatch()
        End If
    End Sub

    Private Sub SetMatch()
        lblSMatch.BackColor = Color.Green
        lblSMatch.Text = "Match"
        lblSMatch.ForeColor = Color.White
        lblSPassword.Enabled = True
        txtSPassword.Enabled = True
        lblSConfirm.Enabled = True
        txtSConfirm.Enabled = True
        lblSPMatch.Enabled = True
    End Sub

    Private Sub SetNoMatch()
        LoginID = 0
        lblSMatch.BackColor = Color.Red
        lblSMatch.Text = "No Match"
        lblSMatch.ForeColor = Color.White
        lblSPassword.Enabled = False
        txtSPassword.Enabled = False
        lblSConfirm.Enabled = False
        txtSConfirm.Enabled = False
        lblSPMatch.Enabled = False
        btnSSave.Enabled = False
    End Sub

    Private Sub txtSPassword_TextChanged(sender As Object, e As EventArgs) Handles txtSPassword.TextChanged, txtSConfirm.TextChanged
        CheckPasswordMatch()
    End Sub

    Private Sub CheckPasswordMatch()
        If txtSPassword.Text = txtSConfirm.Text AndAlso Not String.IsNullOrEmpty(txtSPassword.Text) Then
            lblSPMatch.BackColor = Color.Green
            lblSPMatch.Text = "Match"
            lblSMatch.ForeColor = Color.White
            btnSSave.Enabled = True
        Else
            lblSPMatch.BackColor = Color.Red
            lblSPMatch.Text = "No Match"
            lblSPMatch.ForeColor = Color.White
            btnSSave.Enabled = False
        End If
    End Sub

    Private Sub btnSSave_Click(sender As Object, e As EventArgs) Handles btnSSave.Click
        If LoginID > 0 AndAlso Not String.IsNullOrEmpty(txtSPassword.Text) Then

            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("UPDATE tblLogin SET [Password] = ? WHERE LoginID = ?", conn)
                cmd.Parameters.AddWithValue("?", txtSPassword.Text)
                cmd.Parameters.AddWithValue("?", LoginID)

                Try
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        Me.Close()
                    Else
                        MessageBox.Show("No records were updated. Please check the LoginID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error updating password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Invalid LoginID or Password. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSClose_Click(sender As Object, e As EventArgs) Handles btnSClose.Click
        Me.Close()
    End Sub
End Class