Imports System.Data.OleDb
Imports DatabaseManager.Classes

Public Class FrmTableManager
    Private Sub FrmTableManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        LoadExistingTables()
    End Sub

    Private Sub SetupDataGridView()
        With dgvTables
            .Columns.Add("TableName", "Table Name")
            .Columns.Add("Description", "Description")
            .Columns.Add("IsNew", "New Table")
        End With
    End Sub

    Private Sub LoadExistingTables()
        Dim dbConn As New DatabaseConnection()
        Dim tables = dbConn.GetTableList()

        For Each row As DataRow In tables.Rows
            dgvTables.Rows.Add(row("TABLE_NAME"), "", False)
        Next
    End Sub

    Private Sub btnAddTable_Click(sender As Object, e As EventArgs) Handles btnAddTable.Click
        dgvTables.Rows.Add("", "", True)
    End Sub

    Private Sub btnDeleteTable_Click(sender As Object, e As EventArgs) Handles btnDeleteTable.Click
        If dgvTables.SelectedRows.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete this table?", "Confirm Delete",
                             MessageBoxButtons.YesNo) = DialogResult.Yes Then
                dgvTables.Rows.Remove(dgvTables.SelectedRows(0))
            End If
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim scriptGen As New ScriptGenerator()

        For Each row As DataGridViewRow In dgvTables.Rows
            If row.Cells("IsNew").Value = True Then
                Dim tableName As String = row.Cells("TableName").Value.ToString()
                Dim fields As New List(Of FieldDefinition)
                ' Add default ID field
                fields.Add(New FieldDefinition With {
                    .Name = "ID",
                    .DataType = "COUNTER",
                    .Required = True
                })

                Dim script = scriptGen.GenerateCreateTableScript(tableName, fields)
                ExecuteTableScript(script, tableName)
            End If
        Next

        LoadExistingTables()
    End Sub

    Private Sub ExecuteTableScript(script As String, tableName As String)
        Dim upgrader As New UpgradeManager()
        If upgrader.ExecuteScript(script) Then
            MessageBox.Show($"Table {tableName} created successfully!")
        Else
            MessageBox.Show($"Failed to create table {tableName}")
        End If
    End Sub
End Class