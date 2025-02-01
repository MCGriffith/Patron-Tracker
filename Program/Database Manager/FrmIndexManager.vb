Imports System.Data.OleDb
Imports System.IO

Public Class FrmIndexManager
    Private Sub FrmIndexManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTables()
    End Sub

    Private Sub LoadTables()
        cboTables.Items.Clear()
        Dim tables As DataTable = DatabaseConfig.GetTableSchema()
        For Each row As DataRow In tables.Rows
            cboTables.Items.Add(row("TABLE_NAME").ToString())
        Next
        If cboTables.Items.Count > 0 Then
            cboTables.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTables.SelectedIndexChanged
        If cboTables.SelectedItem IsNot Nothing Then
            LoadIndexesForTable(cboTables.SelectedItem.ToString())
        End If
    End Sub

    Private Sub LoadIndexesForTable(tableName As String)
        dgvIndex.Rows.Clear()
        Dim indexes As DataTable = DatabaseConfig.GetForeignKeySchema()

        For Each row As DataRow In indexes.Rows
            If row("TABLE_NAME").ToString() = tableName Then
                Dim IndexName As String = row("INDEX_NAME").ToString()
                Dim FieldName As String = row("COLUMN_NAME").ToString()
                Dim IsUnique As Boolean = (row("UNIQUE").ToString() = "True")
                Dim IsPrimary As Boolean = (row("PRIMARY_KEY").ToString() = "True")

                dgvIndex.Rows.Add(IndexName, FieldName, IsUnique, IsPrimary)

                lblLastUsed.Text = "Last Used: " & GetIndexLastUsed(tableName, IndexName)
                lblIndexSize.Text = "Index Size: " & GetIndexSize(tableName, IndexName)
                lblRecommendations.Text = GetIndexRecommendations(tableName, IndexName)
            End If
        Next
    End Sub

    Private Function GetIndexLastUsed(tableName As String, indexName As String) As String
        Try
            Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
                Dim sql As String = "SELECT DateLastUpdated FROM MSysObjects WHERE Name=@IndexName"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@IndexName", indexName)
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    Return If(result IsNot Nothing, Convert.ToDateTime(result).ToString(), "Never")
                End Using
            End Using
        Catch ex As Exception
            LogError("GetIndexLastUsed", ex)
            Return "Unknown"
        End Try
    End Function

    Private Function GetIndexSize(tableName As String, indexName As String) As String
        Try
            Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
                Dim sql As String = "SELECT SizeDisk FROM MSysObjects WHERE Name=@IndexName"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@IndexName", indexName)
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    Return If(result IsNot Nothing, FormatSize(Convert.ToInt64(result)), "Unknown")
                End Using
            End Using
        Catch ex As Exception
            LogError("GetIndexSize", ex)
            Return "Size Unknown"
        End Try
    End Function

    Private Function GetIndexRecommendations(tableName As String, indexName As String) As String
        Try
            Dim recommendations As New List(Of String)

            If GetIndexLastUsed(tableName, indexName) = "Never" Then
                recommendations.Add("Consider removing unused index")
            End If

            If IsIndexDuplicate(tableName, indexName) Then
                recommendations.Add("Possible duplicate index detected")
            End If

            Return String.Join(Environment.NewLine, recommendations)
        Catch ex As Exception
            LogError("GetIndexRecommendations", ex)
            Return "Unable to generate recommendations"
        End Try
    End Function

    Private Function IsIndexDuplicate(tableName As String, indexName As String) As Boolean
        Try
            Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
                Dim sql As String = "SELECT COUNT(*) FROM MSysObjects " &
                                   "WHERE Type=3 AND Flags=2 AND Name LIKE @TablePrefix"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@TablePrefix", $"{tableName}%")
                    conn.Open()
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 1
                End Using
            End Using
        Catch ex As Exception
            LogError("IsIndexDuplicate", ex)
            Return False
        End Try
    End Function

    Private Function FormatSize(bytes As Long) As String
        If bytes < 1024 Then
            Return $"{bytes} B"
        ElseIf bytes < 1024 * 1024 Then
            Return $"{bytes / 1024:N1} KB"
        Else
            Return $"{bytes / (1024 * 1024):N1} MB"
        End If
    End Function

    Private Function LogError(methodName As String, ex As Exception) As Boolean
        Try
            Dim errorMessage As String = $"{DateTime.Now} - Error in {methodName}: {ex.Message}"
            File.AppendAllText("IndexManager.log", errorMessage & Environment.NewLine)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub DisplayError(message As String)
        MessageBox.Show(message, "Index Manager Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class