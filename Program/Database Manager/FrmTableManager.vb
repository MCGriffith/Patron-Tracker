Public Class FrmTableManager
    Private currentTable As String = ""

    Public Sub New(Optional tableName As String = "")
        InitializeComponent()
        currentTable = tableName
    End Sub

    Private Sub FrmTableManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataTypes()
        InitializeFieldsGrid()
        LoadTables()
        If Not String.IsNullOrEmpty(currentTable) Then
            cboTables.SelectedItem = currentTable
        End If
    End Sub

    Private Sub LoadTables()
        cboTables.Items.Clear()
        cboTables.Items.Add("")  ' Add blank line first

        Dim tables As DataTable = DatabaseConfig.GetTableSchema()
        For Each row As DataRow In tables.Rows
            Dim tableName As String = row("TABLE_NAME").ToString()
            If Not tableName.StartsWith("MSys") Then
                cboTables.Items.Add(tableName)
            End If
        Next

        If cboTables.Items.Count > 0 Then
            cboTables.SelectedIndex = 0
        End If
    End Sub

    Private Sub cboTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTables.SelectedIndexChanged
        If cboTables.SelectedItem IsNot Nothing Then
            LoadTableSchema(cboTables.SelectedItem.ToString())
        End If
    End Sub

    Private Sub LoadDataTypes()
        cboDataType.Items.Clear()
        cboDataType.Items.AddRange(New String() {
           "Text",
           "Memo",
           "Number",
           "Date/Time",
           "Yes/No",
            "AutoNumber"
           })
        cboDataType.SelectedIndex = 0
    End Sub

    Private Sub InitializeFieldsGrid()
        With dgvFields
            .Rows.Clear()
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .MultiSelect = False
        End With
    End Sub

    Private Sub LoadTableSchema(tableName As String)
        currentTable = tableName
        dgvFields.Rows.Clear()

        Dim schema As DataTable = DatabaseConfig.GetColumnSchema(tableName)

        ' Sort by ordinal position
        Dim sortedRows = schema.Select("", "ORDINAL_POSITION ASC")

        For Each row As DataRow In sortedRows
            Dim fieldName As String = row("COLUMN_NAME").ToString()
            Dim dataType As String = row("DATA_TYPE").ToString()
            Dim columnFlags As Integer = CInt(row("COLUMN_FLAGS"))
            Dim size As String = row("CHARACTER_MAXIMUM_LENGTH").ToString()
            Dim required As Boolean = Convert.ToBoolean(row("IS_NULLABLE"))

            dgvFields.Rows.Add(fieldName, ConvertSQLTypeToDisplay(dataType, columnFlags), size, required, "")
        Next
    End Sub

    Private Function ConvertSQLTypeToDisplay(dataType As String, columnFlags As Integer) As String
        Select Case dataType
            Case "2"
                Return "Number"  'DayOfWeek
            Case "3"
                If columnFlags = 90 Then
                    Return "AutoNumber"  'Primary Keys
                Else
                    Return "Number"  'Regular numbers
                End If
            Case "7"
                Return "Date/Time"
            Case "11"
                Return "Yes/No"
            Case "130"
                Return "Text"
            Case Else
                Return dataType & "-Unknown"
        End Select
    End Function

    Private Sub btnAddField_Click(sender As Object, e As EventArgs) Handles btnAddField.Click
        Dim newRow = dgvFields.Rows.Add()
        dgvFields.Rows(newRow).Cells("FieldName").Value = "NewField"
        dgvFields.Rows(newRow).Cells("DataType").Value = cboDataType.SelectedItem
        dgvFields.Rows(newRow).Cells("Size").Value = "50"
        dgvFields.Rows(newRow).Cells("Required").Value = False
    End Sub

    Private Sub btnDeleteField_Click(sender As Object, e As EventArgs) Handles btnDeleteField.Click
        If dgvFields.SelectedRows.Count > 0 Then
            dgvFields.Rows.Remove(dgvFields.SelectedRows(0))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sql As String = GenerateTableSQL()
        If DatabaseConfig.ExecuteSchemaChange(sql) Then
            MessageBox.Show("Table structure saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function GenerateTableSQL() As String
        Dim sql As New System.Text.StringBuilder

        If cboTables.Text.Trim() = "" Then
            currentTable = "NewTable"
        Else
            currentTable = cboTables.Text.Trim()
        End If

        sql.AppendLine($"CREATE TABLE {currentTable}")
        sql.AppendLine("(")

        For Each row As DataGridViewRow In dgvFields.Rows
            If row.IsNewRow Then Continue For
            If row.Cells("FieldName").Value Is Nothing Then Continue For

            Dim fieldName As String = row.Cells("FieldName").Value.ToString()
            Dim dataType As String = If(row.Cells("DataType").Value IsNot Nothing,
                                   row.Cells("DataType").Value.ToString(),
                                   "Text")

            sql.Append($"[{fieldName}] ")

            If dataType = "AutoNumber" Then
                sql.Append("COUNTER CONSTRAINT PK_" & fieldName & " PRIMARY KEY")
            Else
                sql.Append(ConvertDisplayTypeToSQL(dataType))

                Dim size As String = If(row.Cells("Size").Value IsNot Nothing,
                                  row.Cells("Size").Value.ToString(),
                                  "")

                If Not String.IsNullOrEmpty(size) AndAlso dataType = "Text" Then
                    sql.Append($"({size})")
                End If
            End If

            sql.AppendLine(",")
        Next

        If sql.ToString().EndsWith("," & Environment.NewLine) Then
            sql.Length = sql.Length - 3
        End If

        sql.AppendLine(")")

        Return sql.ToString()
    End Function


    Private Function ConvertDisplayTypeToSQL(displayType As String) As String
        Select Case displayType
            Case "Text"
                Return "VARCHAR"
            Case "Memo"
                Return "TEXT"
            Case "Number"
                Return "INT"
            Case "Date/Time"
                Return "DATETIME"
            Case "Yes/No"
                Return "BIT"
            Case "Currency"
                Return "MONEY"
            Case "AutoNumber"
                Return "IDENTITY"
            Case Else
                Return displayType
        End Select
    End Function

    Private Sub btnTableClose_Click(sender As Object, e As EventArgs) Handles btnTableClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class