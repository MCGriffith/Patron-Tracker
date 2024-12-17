Imports ADODB
Imports PTracker

Public Class UpgradeManager
    Private _conn As DatabaseConnection
    Private _scriptGen As ScriptGenerator

    Public Sub New()
        _conn = New DatabaseConnection()
        _scriptGen = New ScriptGenerator()
    End Sub

    Public Function ExecuteScript(script As String) As Boolean
        Try
            Dim conn As New ADODB.Connection
            conn.Open(DatabaseConfig.ConnectionString)
            conn.Execute(script)
            conn.Close()
            Return True
        Catch
            Return False
        End Try
    End Function
End Class