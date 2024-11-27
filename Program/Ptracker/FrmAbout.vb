Imports System.Data.OleDb

Public Class FrmAbout
    Dim connectionString As String = DatabaseConfig.ConnectionString

    'Testing the Git commit process.

    Private Sub FrmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAboutInfo()
    End Sub

    Private Sub LoadAboutInfo()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM tblAboutInfo", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                lblProduct.Text = reader("Product").ToString()
                lblVersion.Text = "Version " & reader("Version").ToString() & ".0"

                ' Format registration number with padding
                Dim regNum As Integer = Convert.ToInt32(reader("RegNumb"))
                Dim formattedRegNum As String = If(regNum < 9999, regNum.ToString("0000"), regNum.ToString())
                lblRegNum.Text = formattedRegNum

                ' Format copyright with symbol and spacing
                lblCopyright.Text = ChrW(169) & " " & reader("CopyRight").ToString() & " " & reader("ProdOwner").ToString()

                lblRegName.Text = reader("RegName").ToString()
            End If
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class