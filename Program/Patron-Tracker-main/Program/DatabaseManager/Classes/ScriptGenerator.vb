Imports System.Reflection.Metadata
Imports System.Text
Imports System.Collections.Generic
Imports System.Data.OleDb

Public Class ScriptGenerator
    Public Function GenerateCreateTableScript(tableName As String, fields As List(Of FieldDefinition)) As String
        Dim script As New StringBuilder
        script.AppendLine($"CREATE TABLE {tableName} (")

        For i As Integer = 0 To fields.Count - 1
            Dim field = fields(i)
            script.Append($"    {field.Name} {field.DataType}")
            If field.Required Then script.Append(" NOT NULL")
            If i < fields.Count - 1 Then script.Append(",")
            script.AppendLine()
        Next

        script.AppendLine(")")
        Return script.ToString()
    End Function

    Public Function GenerateAddFieldScript(tableName As String, fieldName As String, dataType As String) As String
        Return $"ALTER TABLE {tableName} ADD COLUMN {fieldName} {dataType}"
    End Function
End Class
