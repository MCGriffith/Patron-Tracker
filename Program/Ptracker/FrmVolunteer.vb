Imports System.Data.OleDb

Public Class FrmVolunteer
    Inherits Form
    Dim connectionString As String = DatabaseConfig.ConnectionString

    Private Sub FrmVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        LoadComboBoxes()
    End Sub

    Private Sub LoadComboBoxes()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            ' Modified SQL query to include Role from tblLogin
            Dim cmd As New OleDbCommand("SELECT c.FullName, l.Role FROM tblContacts c INNER JOIN tblLogin l ON c.LoginID = l.LoginID WHERE l.Role IN ('Staff', 'Director', 'Admin') ORDER BY c.FullName", conn)
            Using da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Dim emptyRow As DataRow = dt.NewRow()
                emptyRow("FullName") = ""
                emptyRow("Role") = "" ' Ensure Role column is also populated
                dt.Rows.InsertAt(emptyRow, 0)
                cboName.DataSource = dt
                cboName.DisplayMember = "FullName"
                cboName.ValueMember = "FullName"
            End Using
        End Using
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If cboName.SelectedValue IsNot Nothing AndAlso cboName.SelectedValue.ToString() <> "" Then
            Dim selectedRow As DataRowView = CType(cboName.SelectedItem, DataRowView)
            txtRole.Text = selectedRow("Role").ToString()
            txtRole.ReadOnly = True
        Else
            txtRole.Text = ""
        End If
    End Sub
End Class