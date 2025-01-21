Imports PTracker
Imports System.IO
Imports System.Data.OleDb
Imports DatabaseManager.Classes
Imports System.Collections.Generic

Public Class FrmBackupRestore
    Private Sub btnBrowseBackup_Click(sender As Object, e As EventArgs) Handles btnBrowseBackup.Click
        Using folderDialog As New FolderBrowserDialog()
            If folderDialog.ShowDialog() = DialogResult.OK Then
                txtBackupPath.Text = folderDialog.SelectedPath
            End If
        End Using
    End Sub

    Private Sub btnCreateBackup_Click(sender As Object, e As EventArgs) Handles btnCreateBackup.Click
        If String.IsNullOrEmpty(txtBackupPath.Text) Then
            MessageBox.Show("Please select a backup location")
            Return
        End If

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 100

        Try
            ' Create backup filename with timestamp
            Dim backupFile = Path.Combine(txtBackupPath.Text,
                $"DatabaseBackup_{DateTime.Now:yyyyMMdd_HHmmss}.bak")

            ' Copy database file
            ProgressBar1.Value = 50
            File.Copy(DatabaseConfig.DatabasePath, backupFile)
            ProgressBar1.Value = 100

            MessageBox.Show("Backup created successfully!")
        Catch ex As Exception
            MessageBox.Show($"Backup failed: {ex.Message}")
        End Try
    End Sub

    Private Sub btnBrowseRestore_Click(sender As Object, e As EventArgs) Handles btnBrowseRestore.Click
        Using fileDialog As New OpenFileDialog()
            fileDialog.Filter = "Backup files|*.bak|All files|*.*"
            If fileDialog.ShowDialog() = DialogResult.OK Then
                txtRestorePath.Text = fileDialog.FileName
            End If
        End Using
    End Sub

    Private Sub btnRestoreDatabase_Click(sender As Object, e As EventArgs) Handles btnRestoreDatabase.Click
        If String.IsNullOrEmpty(txtRestorePath.Text) Then
            MessageBox.Show("Please select a backup file to restore")
            Return
        End If

        If MessageBox.Show("This will overwrite the current database. Continue?",
                          "Confirm Restore", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 100

        Try
            ' Close all database connections
            ProgressBar1.Value = 25
            GC.Collect()
            GC.WaitForPendingFinalizers()

            ' Restore database file
            ProgressBar1.Value = 75
            File.Copy(txtRestorePath.Text, DatabaseConfig.DatabasePath, True)
            ProgressBar1.Value = 100

            MessageBox.Show("Database restored successfully!")
        Catch ex As Exception
            MessageBox.Show($"Restore failed: {ex.Message}")
        End Try
    End Sub

    Private Sub FrmBackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class