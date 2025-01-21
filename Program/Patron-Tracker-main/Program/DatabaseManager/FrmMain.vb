Imports System.Data.OleDb
Imports DatabaseManager.Classes

Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub mnuFileConnectToDatabase_Click(sender As Object, e As EventArgs) Handles mnuFileConnectToDatabase.Click
        Dim dbConn As New DatabaseConnection()
        If dbConn.TestConnection() Then
            IsConnected = True
            MessageBox.Show("Database connected successfully!")
        Else
            MessageBox.Show("Connection failed!")
        End If
    End Sub

    Private Sub mnuToolsTableManager_Click(sender As Object, e As EventArgs) Handles mnuToolsTableManager.Click
        Dim frmTable As New FrmTableManager()
        frmTable.MdiParent = Me
        frmTable.Show()
    End Sub

    Private Sub mnuToolsFieldManager_Click(sender As Object, e As EventArgs) Handles mnuToolsFieldManager.Click
        Dim frmField As New FrmFieldManager()
        frmField.MdiParent = Me
        frmField.Show()
    End Sub

    Private Sub mnuToolsRelationships_Click(sender As Object, e As EventArgs) Handles mnuToolsRelationships.Click
        Dim frmRelation As New FrmRelationshipManager()
        frmRelation.MdiParent = Me
        frmRelation.Show()
    End Sub

    Private Sub mnuToolsViewScripts_Click(sender As Object, e As EventArgs) Handles mnuToolsViewScripts.Click
        Dim frmScript As New FrmScriptViewer()
        frmScript.MdiParent = Me
        frmScript.Show()
    End Sub

    Private Sub mnuToolsBackupRestore_Click(sender As Object, e As EventArgs) Handles mnuToolsBackupRestore.Click
        Dim frmBackup As New FrmBackupRestore()
        frmBackup.MdiParent = Me
        frmBackup.Show()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
End Class