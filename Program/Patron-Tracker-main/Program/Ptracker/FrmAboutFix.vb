Imports System.Data.OleDb

Public Class FrmAboutFix

    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private dataChanged As Boolean = False

    Private Sub FrmAboutFix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAboutInfo()
        btnSave.Enabled = False
    End Sub

    Private Sub LoadAboutInfo()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM tblAboutInfo", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtProduct.Text = reader("Product").ToString()
                txtVersion.Text = reader("Version").ToString()
                txtProdOwner.Text = reader("ProdOwner").ToString()
                txtRegName.Text = reader("RegName").ToString()
                txtRegNum.Text = reader("RegNumb").ToString()
            End If
        End Using
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
              txtProduct.TextChanged,
            txtVersion.TextChanged, txtProdOwner.TextChanged, txtRegName.TextChanged,
            txtRegNum.TextChanged

        dataChanged = True
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE tblAboutInfo SET " &
                "Product = @prod, " & "Version = @ver, " &
                "ProdOwner = @owner, RegName = @regname, " &
                "RegNumb = @regnum", conn)

            cmd.Parameters.AddWithValue("@prod", txtProduct.Text)
            cmd.Parameters.AddWithValue("@ver", txtVersion.Text)
            cmd.Parameters.AddWithValue("@owner", txtProdOwner.Text)
            cmd.Parameters.AddWithValue("@regname", txtRegName.Text)
            cmd.Parameters.AddWithValue("@regnum", txtRegNum.Text)

            cmd.ExecuteNonQuery()
        End Using

        dataChanged = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class