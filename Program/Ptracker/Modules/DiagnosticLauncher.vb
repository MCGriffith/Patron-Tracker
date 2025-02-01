Imports System.Windows.Forms
Imports System.Data.OleDb

Module DiagnosticLauncher
    Sub Main()
        Console.WriteLine("=== Patron Tracker Full Startup Test ===")
        Console.WriteLine($"Time: {DateTime.Now}")

        Try
            Using splash As New FrmSplashScreen
                Console.WriteLine("1. Splash screen initialized")
                Application.DoEvents()

                ' Simulate the normal startup sequence
                For i As Integer = 0 To 100 Step 20
                    Console.WriteLine($"Loading: {i}%")
                    System.Threading.Thread.Sleep(500)
                Next

                Using mainForm As New FrmMain
                    Console.WriteLine("2. Main form initialized")
                    Console.WriteLine("3. Ready to show UI")
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine($"Startup sequence failed at: {ex.Message}")
            Console.WriteLine($"Location: {ex.StackTrace}")
        End Try

        Console.WriteLine(vbNewLine & "Press any key to exit")
        Console.ReadKey()
    End Sub
End Module