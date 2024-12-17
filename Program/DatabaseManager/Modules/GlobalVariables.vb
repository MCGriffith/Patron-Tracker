Module GlobalVariables
    Public CurrentDatabaseVersion As Integer = 1
    Public IsConnected As Boolean = False
    Public CurrentTableName As String = ""
    Public ScriptHistory As New List(Of String)

    Public Structure FieldDefinition
        Public Name As String
        Public DataType As String
        Public Required As Boolean
    End Structure

    Public Function GetDataTypeList() As List(Of String)
        Return New List(Of String) From {
            "TEXT", "INTEGER", "DATETIME", "BOOLEAN", "CURRENCY", "MEMO"
        }
    End Function
End Module