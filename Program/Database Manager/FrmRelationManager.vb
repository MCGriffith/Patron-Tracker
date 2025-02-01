Imports System.Data.OleDb

Public Class FrmRelationManager
    Private Sub FrmRelationManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTables()
        LoadExistingRelations()
    End Sub

    Private Sub LoadTables()
        cboTablePrimary.Items.Clear()
        cboTableForeign.Items.Clear()

        Dim schema As DataTable = DatabaseConfig.GetTableSchema()
        For Each row As DataRow In schema.Rows
            Dim tableName As String = row("TABLE_NAME").ToString()
            If Not tableName.StartsWith("MSys") Then
                cboTablePrimary.Items.Add(tableName)
                cboTableForeign.Items.Add(tableName)
            End If
        Next
    End Sub

    Private Sub cboTablePrimary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTablePrimary.SelectedIndexChanged
        LoadPrimaryFields()
        LoadExistingRelations()
    End Sub

    Private Sub cboTableForeign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTableForeign.SelectedIndexChanged
        LoadForeignFields()
        LoadExistingRelations()
    End Sub

    Private Sub LoadPrimaryFields()
        lstFieldsPrimary.Items.Clear()
        If cboTablePrimary.SelectedIndex < 0 Then Return

        Dim schema As DataTable = DatabaseConfig.GetColumnSchema(cboTablePrimary.SelectedItem.ToString())
        For Each row As DataRow In schema.Rows
            ' Only show primary key fields in the primary list
            If row("COLUMN_FLAGS").ToString().Contains("90") Then
                lstFieldsPrimary.Items.Add(row("COLUMN_NAME").ToString())
            End If
        Next
    End Sub

    Private Sub LoadForeignFields()
        lstFieldsForeign.Items.Clear()
        If cboTableForeign.SelectedIndex < 0 Then Return

        Dim foreignTable As String = cboTableForeign.SelectedItem.ToString()
        Dim primaryTable As String = cboTablePrimary.SelectedItem.ToString()

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim cmd As New OleDbCommand($"SELECT * FROM {foreignTable}", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.SchemaOnly)
            Dim schema As DataTable = reader.GetSchemaTable()

            For Each row As DataRow In schema.Rows
                Dim columnName As String = row("ColumnName").ToString()
                ' Only show fields that could be foreign keys (not primary keys)
                If Not CBool(row("IsKey")) Then
                    lstFieldsForeign.Items.Add(columnName)
                End If
            Next
        End Using
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If ValidateSelections() Then
            Dim sql As String = GenerateCreateRelationSQL()
            If DatabaseConfig.ExecuteSchemaChange(sql) Then
                LoadExistingRelations()
                MessageBox.Show("Relationship created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvRelations.SelectedRows.Count > 0 AndAlso ValidateSelections() Then
            ' Drop the existing relationship
            Dim dropSQL As String = GenerateDropRelationSQL()
            ' Create the new relationship
            Dim createSQL As String = GenerateCreateRelationSQL()

            If DatabaseConfig.ExecuteSchemaChange(dropSQL) AndAlso
           DatabaseConfig.ExecuteSchemaChange(createSQL) Then
                LoadExistingRelations()
                MessageBox.Show("Relationship updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvRelations.SelectedRows.Count > 0 Then
            Dim sql As String = GenerateDropRelationSQL()
            If DatabaseConfig.ExecuteSchemaChange(sql) Then
                LoadExistingRelations()
                MessageBox.Show("Relationship deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Function ValidateSelections() As Boolean
        If cboTablePrimary.SelectedIndex = -1 OrElse cboTableForeign.SelectedIndex = -1 Then
            MessageBox.Show("Please select both primary and foreign tables.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If lstFieldsPrimary.SelectedIndex = -1 OrElse lstFieldsForeign.SelectedIndex = -1 Then
            MessageBox.Show("Please select both primary and foreign fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function GenerateCreateRelationSQL() As String
        Dim primaryTable As String = cboTablePrimary.SelectedItem.ToString()
        Dim primaryField As String = lstFieldsPrimary.SelectedItem.ToString()
        Dim foreignTable As String = cboTableForeign.SelectedItem.ToString()
        Dim foreignField As String = lstFieldsForeign.SelectedItem.ToString()

        Dim constraintName As String = $"FK_{foreignTable}_{primaryTable}"

        Return $"ALTER TABLE {foreignTable} " &
           $"ADD CONSTRAINT {constraintName} " &
           $"FOREIGN KEY ({foreignField}) " &
           $"REFERENCES {primaryTable}({primaryField})"
    End Function

    Private Function GenerateUpdateRelationshipSQL() As String
        ' First delete the old relationship
        Dim deleteSQL As String = GenerateDropRelationSQL()
        ' Then create the new one
        Dim createSQL As String = GenerateCreateRelationSQL()

        Return deleteSQL & ";" & vbCrLf & createSQL
    End Function

    Private Function GenerateDropRelationSQL() As String
        Dim row As DataGridViewRow = dgvRelations.SelectedRows(0)
        Dim foreignTable As String = row.Cells("ForeignTable").Value.ToString()
        Dim primaryTable As String = row.Cells("PrimaryTable").Value.ToString()

        Dim constraintName As String = $"FK_{foreignTable}_{primaryTable}"

        Return $"ALTER TABLE {foreignTable} DROP CONSTRAINT {constraintName}"
    End Function

    Private Sub LoadExistingRelations()
        dgvRelations.Rows.Clear()

        If cboTablePrimary.SelectedIndex < 0 OrElse cboTableForeign.SelectedIndex < 0 Then Return

        Dim primaryTable As String = cboTablePrimary.SelectedItem.ToString()
        Dim foreignTable As String = cboTableForeign.SelectedItem.ToString()

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()

            ' Get relationships from MSysRelationships
            Dim sql As String = "SELECT szObject, szReferencedObject, szColumn, szReferencedColumn " &
                           "FROM MSysRelationships " &
                           "WHERE (szObject = ?) AND (szReferencedObject = ?)"

            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p1", foreignTable)
                cmd.Parameters.AddWithValue("@p2", primaryTable)

                Try
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dgvRelations.Rows.Add(
                            reader("szReferencedObject"),
                            reader("szReferencedColumn"),
                            reader("szObject"),
                            reader("szColumn")
                        )
                        End While
                    End Using
                Catch ex As Exception
                    ' If we can't access system tables, we'll use an alternative method
                    LoadRelationshipsAlternative(primaryTable, foreignTable)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadRelationshipsAlternative(primaryTable As String, foreignTable As String)
        ' Use the Indexes schema collection which includes relationship information
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            conn.Open()
            Dim schema As DataTable = conn.GetSchema("Indexes")

            For Each row As DataRow In schema.Rows
                If row("TABLE_NAME").ToString() = foreignTable Then
                    Dim indexName As String = row("INDEX_NAME").ToString()
                    If indexName.StartsWith("FK_") Then
                        dgvRelations.Rows.Add(
                        primaryTable,
                        row("COLUMN_NAME").ToString(),
                        foreignTable,
                        row("COLUMN_NAME").ToString()
                    )
                    End If
                End If
            Next
        End Using
    End Sub
    Private Sub InitializeRelationClose()
        btnRelationClose = New Button With {
        .Text = "Close",
        .Location = New Point(btnDelete.Right + 10, btnDelete.Top),
        .Size = btnDelete.Size
    }
        Me.Controls.Add(btnRelationClose)
    End Sub

    Private Sub btnRelationClose_Click(sender As Object, e As EventArgs) Handles btnRelationClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class