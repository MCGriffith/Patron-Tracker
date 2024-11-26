Imports System.Data.OleDb

Public Class SplashScreen
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private timeLeft As Integer = 5

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSlpashScreenInfo()
    End Sub

    Private Sub LoadSlpashScreenInfo()
        Timer1.Interval = 1000
        Timer1.Start()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLeft = timeLeft - 1
        If timeLeft = 0 Then
            Timer1.Stop()
            Me.Hide()
            Dim mainForm As New FrmMain()
            mainForm.Show()
        End If
    End Sub
End Class