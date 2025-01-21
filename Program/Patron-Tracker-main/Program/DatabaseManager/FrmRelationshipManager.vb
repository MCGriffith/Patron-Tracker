Imports System.Data.OleDb
Imports DatabaseManager.Classes
Imports System.Collections.Generic

Public Class FrmRelationshipManager
    Private Sub FrmRelationshipManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupDataGridView()
        SetupComboBoxes()
        LoadExistingRelationships()
    End Sub

    Private Sub SetupDataGridView()
        With dgvRelationships
            .Columns.Add("PrimaryTable", "Primary Table")
            .Columns.Add("PrimaryKey", "Primary Key")
            .Columns.Add("ForeignTable", "Foreign Table")
            .Columns.Add("ForeignKey", "Foreign Key")
        End With
    End Sub

    Private Sub SetupComboBoxes()
        Dim dbConn As New DatabaseConnection()
        Dim tables = dbConn.GetTableList()

        ' Setup Primary Table ComboBox
        cboPrimaryTable.DataSource = tables.Copy()
        cboPrimaryTable.DisplayMember = "TABLE_NAME"
        cboPrimaryTable.ValueMember = "TABLE_NAME"

        ' Setup Foreign Table ComboBox
        cboForeignTable.DataSource = tables.Copy()
        cboForeignTable.DisplayMember = "TABLE_NAME"
        cboForeignTable.ValueMember = "TABLE_NAME"
    End Sub

    Private Sub cboPrimaryTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPrimaryTable.SelectedIndexChanged
        LoadPrimaryKeys()
    End Sub

    Private Sub cboForeignTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboForeignTable.SelectedIndexChanged
        LoadForeignKeys()
    End Sub

    Private Sub LoadPrimaryKeys()
        If cboPrimaryTable.SelectedValue IsNot Nothing Then
            Dim dbConn As New DatabaseConnection()
            Dim fields = dbConn.GetFieldList(cboPrimaryTable.SelectedValue.ToString())
            cboPrimaryKey.DataSource = fields
            cboPrimaryKey.DisplayMember = "COLUMN_NAME"
            cboPrimaryKey.ValueMember = "COLUMN_NAME"
        End If
    End Sub

    Private Sub LoadForeignKeys()
        If cboForeignTable.SelectedValue IsNot Nothing Then
            Dim dbConn As New DatabaseConnection()
            Dim fields = dbConn.GetFieldList(cboForeignTable.SelectedValue.ToString())
            cboForeignKey.DataSource = fields
            cboForeignKey.DisplayMember = "COLUMN_NAME"
            cboForeignKey.ValueMember = "COLUMN_NAME"
        End If
    End Sub

    Private Sub LoadExistingRelationships()
        ' This will be implemented when we add relationship tracking to the database
        dgvRelationships.Rows.Clear()
    End Sub
End Class