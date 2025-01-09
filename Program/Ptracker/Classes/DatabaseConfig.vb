Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class DatabaseConfig
    Private Shared ReadOnly Property DefaultPath As String
        Get
            Return Path.Combine(Application.StartupPath, "Database", "PTrackerDb.accdb")
        End Get
    End Property

    Public Shared ReadOnly Property DatabasePath As String
        Get
            Dim dbPath As String = My.Settings.DatabasePath
            If String.IsNullOrEmpty(dbPath) OrElse Not File.Exists(dbPath) Then
                dbPath = GetDatabasePathFromUser()
                My.Settings.DatabasePath = dbPath
                My.Settings.Save()
            End If
            Return dbPath
        End Get
    End Property

    Private Shared Function GetDatabasePathFromUser() As String
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Access Database Files (*.accdb)|*.accdb"
        openFileDialog.Title = "Select PTracker Database"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Return openFileDialog.FileName
        Else
            Throw New Exception("Database not found. Please select a valid database location.")
        End If
    End Function

    Public Shared Property ConnectionString As String
        Get
            Return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath}"
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
