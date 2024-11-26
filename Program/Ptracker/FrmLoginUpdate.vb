Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Partial Public Class FrmLoginUpdate
    Inherits Form
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private LoginID As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmLoginUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        InitializeControls()
        LoadComboBoxes()
    End Sub

    Private Sub InitializeControls()
        ' Enable initial controls
        lblSEmail.Enabled = True
        lblSPIN.Enabled = True
        cboSEmail.Enabled = True
        txtSPIN.Enabled = True
        lblSMatch.Enabled = True
        lblSMatch.BackColor = Color.Red
        lblSMatch.Text = "No Match"
        lblSMatch.ForeColor = Color.White
        btnSCancel.Enabled = True

        ' Disable other controls
        lblSPassword.Enabled = False
        txtSPassword.Enabled = False
        lblSConfirm.Enabled = False
        txtSConfirm.Enabled = False
        lblSPMatch.Enabled = False
        btnSSave.Enabled = False
    End Sub

    Private Sub LoadComboBoxes()

        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim emailCmd As New OleDbCommand("SELECT Email FROM tblLogin", conn)
            Using emailReader As OleDbDataReader = emailCmd.ExecuteReader()
                While emailReader.Read()
                    cboSEmail.Items.Add(emailReader("Email").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub cboSEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSEmail.SelectedIndexChanged
        CheckCredentials()
    End Sub

    Private Sub txtSPIN_TextChanged(sender As Object, e As EventArgs) Handles txtSPIN.TextChanged
        CheckCredentials()
    End Sub

    Private Sub CheckCredentials()
        Dim email As String = cboSEmail.Text
        Dim pin As String = txtSPIN.Text

        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(pin) Then
            SetNoMatch()
            Return
        End If

        If pin.Length >= 4 AndAlso pin.Length <= 6 AndAlso IsNumeric(pin) Then

            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT LoginID FROM tblLogin WHERE Email = ? AND PIN = ?", conn)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@PIN", pin)

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

    Private Sub btnSCancel_Click(sender As Object, e As EventArgs) Handles btnSCancel.Click
        Me.Close()
    End Sub
End Class