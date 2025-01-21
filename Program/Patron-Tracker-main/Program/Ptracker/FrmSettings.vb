Imports System.IO
Imports System.IO.Compression

Public Class FrmSettings
    Inherits Form

    Private backupPath As String

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)
        backupPath = Path.Combine(Application.StartupPath, "Backups")
        txtDatabasePath.Text = My.Settings.DatabasePath
        InitializeBackupControls()

        If Not Directory.Exists(backupPath) Then
            Directory.CreateDirectory(backupPath)
        End If
    End Sub

    Private Sub InitializeBackupControls()
        cboBackupLocation.Items.Clear()
        cboBackupLocation.Items.AddRange(New String() {"Local Backup", "Network Drive", "External Drive"})
        cboBackupLocation.SelectedIndex = 0
        lblLastBackup.Text = GetBackupStatus()

        ' Add handler for the browse button
        AddHandler btnBrowseLocation.Click, AddressOf SelectBackupLocation
    End Sub

    Private Sub SelectBackupLocation()
        Using dialog As New FolderBrowserDialog()
            Select Case cboBackupLocation.SelectedIndex
                Case 0 ' Local Backup
                    dialog.Description = "Select Local Backup Location"
                Case 1 ' Network Drive
                    dialog.Description = "Select Network Drive Location"
                Case 2 ' External Drive
                    dialog.Description = "Select External Drive Location"
            End Select

            If dialog.ShowDialog() = DialogResult.OK Then
                backupPath = dialog.SelectedPath
                lblSelectedPath.Text = $"Selected Path: {backupPath}"
                lblLastBackup.Text = GetBackupStatus()
            End If
        End Using
    End Sub

    Private Function GetBackupStatus() As String
        Try
            Dim files() As String = Directory.GetFiles(backupPath, "PTrackerDB_Backup_*.zip")
            If files.Length = 0 Then Return "No backups found"

            Dim lastBackup As String = files.OrderByDescending(Function(f) File.GetCreationTime(f)).First()
            Return $"Last backup: {File.GetCreationTime(lastBackup):yyyy-MM-dd HH:mm:ss}"
        Catch ex As Exception
            Return "Unable to determine backup status"
        End Try
    End Function

    Private Sub BackupDatabase(destinationPath As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            Dim backupName As String = $"PTrackerDB_Backup_{timestamp}.accdb"
            Dim fullPath As String = Path.Combine(destinationPath, backupName)
            Dim zipPath As String = $"{fullPath}.zip"

            ' First copy the database file
            File.Copy(My.Settings.DatabasePath, fullPath)

            ' Create zip file using ZipArchive
            Using archive As ZipArchive = ZipFile.Open(zipPath, ZipArchiveMode.Create)
                archive.CreateEntryFromFile(fullPath, backupName)
            End Using

            ' Clean up the temporary database file
            If File.Exists(fullPath) Then File.Delete(fullPath)

            CleanupOldBackups(destinationPath, 7)
            LogBackupOperation(fullPath, True, "Backup")
            VerifyBackup(zipPath)
            MonitorBackupSize(destinationPath)

            MessageBox.Show("Backup completed successfully!", "Backup Status")
        Catch ex As Exception
            LogBackupOperation("", False, ex.Message)
            MessageBox.Show($"Backup failed: {ex.Message}", "Backup Error")
        End Try
    End Sub

    Private Sub RestoreDatabase(backupPath As String)
        Try
            Dim tempPath As String = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName())
            Directory.CreateDirectory(tempPath)

            Using archive As ZipArchive = ZipFile.OpenRead(backupPath)
                archive.ExtractToDirectory(tempPath)
            End Using

            Dim restoredFile As String = Directory.GetFiles(tempPath, "*.accdb").FirstOrDefault()
            If restoredFile IsNot Nothing Then
                File.Copy(restoredFile, My.Settings.DatabasePath, True)
                LogBackupOperation(backupPath, True, "Restore")
                MessageBox.Show("Database restored successfully!", "Restore Complete")
            End If

            Directory.Delete(tempPath, True)
        Catch ex As Exception
            LogBackupOperation(backupPath, False, "Restore", ex.Message)
            MessageBox.Show($"Restore failed: {ex.Message}", "Restore Error")
        End Try
    End Sub

    Private Sub CleanupOldBackups(backupPath As String, daysToKeep As Integer)
        Try
            Dim files() As String = Directory.GetFiles(backupPath, "PTrackerDB_Backup_*.zip")
            Dim cutoffDate As DateTime = DateTime.Now.AddDays(-daysToKeep)

            For Each filePath In files
                Dim fileInfo As New FileInfo(filePath)
                If fileInfo.CreationTime < cutoffDate Then
                    fileInfo.Delete()
                End If
            Next
        Catch ex As Exception
            LogBackupOperation("", False, "Cleanup failed: " & ex.Message)
        End Try
    End Sub

    Private Sub LogBackupOperation(filePath As String, success As Boolean, operationType As String, Optional errorMessage As String = "")
        Dim logEntry As String = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}|{operationType}|{filePath}|{success}"
        If Not String.IsNullOrEmpty(errorMessage) Then
            logEntry &= $"|{errorMessage}"
        End If
        File.AppendAllText(Path.Combine(Application.StartupPath, "backup_log.txt"), logEntry & Environment.NewLine)
    End Sub

    Private Sub VerifyBackup(backupPath As String)
        Using archive As ZipArchive = ZipFile.OpenRead(backupPath)
            If archive.Entries.Count = 0 Then
                Throw New Exception("Backup verification failed: Empty archive")
            End If
        End Using
    End Sub

    Private Sub MonitorBackupSize(backupPath As String)
        Dim directoryInfo As New DirectoryInfo(backupPath)
        Dim totalSize As Long = directoryInfo.GetFiles("PTrackerDB_Backup_*.zip").Sum(Function(f) f.Length)

        If totalSize > 1024L * 1024L * 1024L Then
            MessageBox.Show("Total backup size exceeds 1GB. Consider archiving older backups.",
                          "Backup Size Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnViewLogs_Click(sender As Object, e As EventArgs) Handles btnViewLogs.Click
        Dim logPath As String = Path.Combine(Application.StartupPath, "backup_log.txt")
        If File.Exists(logPath) Then
            Process.Start(logPath)
        Else
            MessageBox.Show("No log file found.", "Log Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using dialog As New OpenFileDialog()
            dialog.Filter = "Access Database|*.accdb"
            dialog.InitialDirectory = Path.GetDirectoryName(My.Settings.DatabasePath)
            dialog.FileName = Path.GetFileName(My.Settings.DatabasePath)

            If dialog.ShowDialog() = DialogResult.OK Then
                txtDatabasePath.Text = dialog.FileName
            End If
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtDatabasePath.Text) Then
            MessageBox.Show("Please select a database location.", "Database Path Required",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        My.Settings.DatabasePath = txtDatabasePath.Text
        My.Settings.Save()
        MessageBox.Show("Database location saved successfully.", "Settings Saved",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        BackupDatabase(backupPath)
        lblLastBackup.Text = GetBackupStatus()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Using dialog As New OpenFileDialog()
            dialog.Filter = "Backup Files|*.zip"
            dialog.InitialDirectory = backupPath
            If dialog.ShowDialog() = DialogResult.OK Then
                RestoreDatabase(dialog.FileName)
            End If
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
