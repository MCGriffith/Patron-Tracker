Imports System.Data.OleDb

Public Class FrmSplashScreen
    Dim connectionString As String = DatabaseConfig.ConnectionString

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Timer1.Interval = 60  ' Increased to 60ms for smoother progress
        LoadSlpashScreenInfo()
        Timer1.Start()
    End Sub

    Private Sub LoadSlpashScreenInfo()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM tblAboutInfo", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                lblProduct.Text = reader("Product").ToString()
                lblVersion.Text = "Version " & reader("Version").ToString() & ".0"

                Dim regNum As Integer = Convert.ToInt32(reader("RegNumb"))
                Dim formattedRegNum As String = If(regNum < 9999, regNum.ToString("0000"), regNum.ToString())
                lblRegNum.Text = formattedRegNum

                lblCopyright.Text = ChrW(169) & " " & reader("CopyRight").ToString() & " " & reader("ProdOwner").ToString()
                lblRegName.Text = reader("RegName").ToString()
            End If
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1  ' Changed to 1 for slower progress



        Select Case ProgressBar1.Value
            Case 0 To 20
                lblRoleName.Text = "Initializing System..."
            Case 21 To 40
                lblRoleName.Text = "Loading Configurations..."
            Case 41 To 60
                lblRoleName.Text = "Connecting to Database..."
            Case 61 To 80
                lblRoleName.Text = "Loading User Interface..."
            Case 81 To 99
                lblRoleName.Text = "Starting Application..."
            Case 100
                Timer1.Enabled = False
                Me.Hide()
                Dim mainForm As New FrmMain()
                mainForm.Show()
        End Select
    End Sub
End Class