Public Class FrmMain2
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "Connecting to database..."
        pbProgress.Value = 0

        Try
            RefreshObjectList()
            lblStatus.Text = "Ready"
        Catch ex As Exception
            lblStatus.Text = "Error: " & ex.Message
        End Try
    End Sub

    Private Sub RefreshObjectList()
        lvwObjects.Items.Clear()
        pbProgress.Value = 30

        Dim schema As DataTable = DatabaseConfig.GetTableSchema()
        pbProgress.Value = 60

        For Each row As DataRow In schema.Rows
            Dim tableName As String = row("TABLE_NAME").ToString()
            Dim item As New ListViewItem(tableName)
            item.SubItems.Add("Table")  ' Changed from direct string assignment to using SubItems.Add
            lvwObjects.Items.Add(item)
        Next

        pbProgress.Value = 100
    End Sub

    Private Sub mnuDatabaseTables_Click(sender As Object, e As EventArgs) Handles mnuDatabaseTables.Click
        Dim frmTable As New FrmTableManager
        frmTable.ShowDialog()
        RefreshObjectList()
    End Sub

    Private Sub mnuDatabaseRelations_Click(sender As Object, e As EventArgs) Handles mnuDatabaseRelations.Click
        Dim frmRelation As New FrmRelationManager
        frmRelation.ShowDialog()
        RefreshObjectList()
    End Sub

    Private Sub mnuDatabaseIndexes_Click(sender As Object, e As EventArgs) Handles mnuDatabaseIndexes.Click
        Dim frmIndex As New FrmIndexManager
        frmIndex.ShowDialog()
        RefreshObjectList()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
End Class
