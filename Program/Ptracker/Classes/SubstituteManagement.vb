Imports System.Data.OleDb

Public Class SubstituteValidation
    Private connectionString As String = DatabaseConfig.ConnectionString

    Public Function ValidateSubstituteIDs(originalID As Integer, substituteID As Integer) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT LoginID FROM tblLogin WHERE LoginID = ? OR LoginID = ?"
            Using cmd As New OleDbCommand(sql, connection)
                cmd.Parameters.AddWithValue("@p1", originalID)
                cmd.Parameters.AddWithValue("@p2", substituteID)
                connection.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    Return reader.HasRows
                End Using
            End Using
        End Using
    End Function
End Class