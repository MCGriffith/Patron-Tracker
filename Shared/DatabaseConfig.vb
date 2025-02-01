Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports PTracker.ClosingManager

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

    Public Shared Function UpdateClosing(closing As FSCClosingData) As Boolean
        Dim sql As String = "UPDATE tblClosings SET " &
                "StartDate = ?, " &
                "EndDate = ?, " &
                "ClosingType = ?, " &
                "Description = ?, " &
                "IsEmergency = ? " &
                "WHERE ClosingsID = ?"

        Using conn As New OleDb.OleDbConnection(ConnectionString)
            Using cmd As New OleDb.OleDbCommand(sql, conn)
                With cmd.Parameters
                    .Add("StartDate", OleDbType.Date).Value = closing.StartDate
                    .Add("EndDate", OleDbType.Date).Value = closing.EndDate
                    .Add("ClosingType", OleDbType.VarChar).Value = closing.ClosingType
                    .Add("Description", OleDbType.VarChar).Value = closing.Description
                    .Add("IsEmergency", OleDbType.Boolean).Value = closing.IsEmergency
                    .Add("ClosingsID", OleDbType.Integer).Value = closing.ClosingID
                End With
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Shared Property ConnectionString As String
        Get
            Return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath}"
        End Get
        Set(value As String)
            Dim dataSourcePattern As String = "Data Source=([^;]+)"
            Dim match As Match = Regex.Match(value, dataSourcePattern)
            If match.Success Then
                My.Settings.DatabasePath = match.Groups(1).Value
                My.Settings.Save()
            End If
        End Set
    End Property

    Public Shared Function GetTableSchema() As DataTable
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Return conn.GetSchema("Tables", New String() {Nothing, Nothing, Nothing, "TABLE"})
        End Using
    End Function

    Public Shared Function GetColumnSchema(tableName As String) As DataTable
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Return conn.GetSchema("Columns", New String() {Nothing, Nothing, tableName})
        End Using
    End Function

    Public Shared Function GetRelationshipSchema() As DataTable
        Using conn As New OleDbConnection(ConnectionString)
            conn.Open()
            Return conn.GetSchema("Tables", New String() {Nothing, Nothing, Nothing, "TABLE"})
        End Using
    End Function

    Public Shared Function ExecuteSchemaChange(sql As String) As Boolean
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                Return True
            End Using
        End Using
    End Function
End Class