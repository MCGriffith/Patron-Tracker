Imports System.Data.OleDb
Imports DatabaseManager.Classes
Imports System.Collections.Generic



Public Class FrmFieldManager
    Private fieldProps As New FieldProperties()

    Private Sub FrmFieldManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupComboBox()
        SetupDataGridView()
        SetupPropertyPanel()
    End Sub

    Private Sub SetupComboBox()
        Dim dbConn As New DatabaseConnection()
        cboTables.DataSource = dbConn.GetTableList()
        cboTables.DisplayMember = "TABLE_NAME"
        cboTables.ValueMember = "TABLE_NAME"
    End Sub

    Private Sub SetupDataGridView()
        With dgvFields
            .Columns.Add("FieldName", "Field Name")
            .Columns.Add("DataType", "Data Type")
            .Columns.Add("Length", "Length")
            .Columns.Add("Required", "Required")
            .Columns.Add("IsNew", "New Field")
        End With
    End Sub

    Private Sub SetupPropertyPanel()
        PropertyPanel.SelectedObject = fieldProps
        PropertyPanel.PropertySort = PropertySort.Categorized
        PropertyPanel.ToolbarVisible = True
    End Sub

    Private Sub cboTables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTables.SelectedIndexChanged
        If cboTables.SelectedValue IsNot Nothing Then
            LoadTableFields(cboTables.SelectedValue.ToString())
        End If
    End Sub

    Private Sub LoadTableFields(tableName As String)
        Dim dbConn As New DatabaseConnection()
        Dim fields = dbConn.GetFieldList(tableName)
        dgvFields.Rows.Clear()

        For Each row As DataRow In fields.Rows
            dgvFields.Rows.Add(
                row("COLUMN_NAME"),
                row("DATA_TYPE"),
                row("CHARACTER_MAXIMUM_LENGTH"),
                row("IS_NULLABLE") = "NO",
                False
            )
        Next
    End Sub

    Private Sub dgvFields_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFields.SelectionChanged
        If dgvFields.CurrentRow IsNot Nothing Then
            UpdatePropertyPanel()
        End If
    End Sub

    Private Sub UpdatePropertyPanel()
        With dgvFields.CurrentRow
            fieldProps.FieldName = .Cells("FieldName").Value?.ToString()
            fieldProps.DataType = .Cells("DataType").Value?.ToString()
            fieldProps.Length = Convert.ToInt32(.Cells("Length").Value)
            fieldProps.Required = Convert.ToBoolean(.Cells("Required").Value)
        End With
        PropertyPanel.Refresh()
    End Sub

    Private Sub PropertyPanel_Click(sender As Object, e As EventArgs) Handles PropertyPanel.Click

    End Sub
End Class

Public Class FieldProperties
    Public Property FieldName As String
    Public Property DataType As String
    Public Property Length As Integer
    Public Property Required As Boolean
    Public Property DefaultValue As String
    Public Property AutoIncrement As Boolean
    Public Property PrimaryKey As Boolean
End Class

