Imports System.IO
Imports System.Text.RegularExpressions

Public Class DatabaseConfig
    Private Shared ReadOnly Property DefaultPath As String
        Get
            Return Path.Combine(Application.StartupPath, "Database", "PTrackerDb.accdb")
        End Get
    End Property

    Public Shared ReadOnly Property DatabasePath As String
        Get
            Return My.Settings.DatabasePath
        End Get
    End Property

    Public Shared Property ConnectionString As String
        Get
            Dim dbPath As String = My.Settings.DatabasePath
            If String.IsNullOrEmpty(dbPath) Then
                dbPath = DefaultPath
                My.Settings.DatabasePath = dbPath
                My.Settings.Save()
            End If
            Return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}"
        End Get
        Set(value As String)
            ' Extract the Data Source path from the connection string
            Dim dataSourcePattern As String = "Data Source=([^;]+)"
            Dim match As Match = Regex.Match(value, dataSourcePattern)
            If match.Success Then
                My.Settings.DatabasePath = match.Groups(1).Value
                My.Settings.Save()
            End If
        End Set
    End Property
End Class


