<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackupRestore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvBackupPanel = New Panel()
        btnCreateBackup = New Button()
        btnBrowseBackup = New Button()
        txtBackupPath = New TextBox()
        lblBackupLocation = New Label()
        RestorePanel = New Panel()
        btnRestoreDatabase = New Button()
        btnBrowseRestore = New Button()
        txtRestorePath = New TextBox()
        lblRestoreFrom = New Label()
        ProgressPanel = New Panel()
        ProgressBar1 = New ProgressBar()
        lblStatus = New Label()
        dgvBackupPanel.SuspendLayout()
        RestorePanel.SuspendLayout()
        ProgressPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvBackupPanel
        ' 
        dgvBackupPanel.Controls.Add(btnCreateBackup)
        dgvBackupPanel.Controls.Add(btnBrowseBackup)
        dgvBackupPanel.Controls.Add(txtBackupPath)
        dgvBackupPanel.Controls.Add(lblBackupLocation)
        dgvBackupPanel.Location = New Point(28, 20)
        dgvBackupPanel.Name = "dgvBackupPanel"
        dgvBackupPanel.Size = New Size(939, 123)
        dgvBackupPanel.TabIndex = 0
        ' 
        ' btnCreateBackup
        ' 
        btnCreateBackup.Location = New Point(719, 67)
        btnCreateBackup.Name = "btnCreateBackup"
        btnCreateBackup.Size = New Size(173, 37)
        btnCreateBackup.TabIndex = 3
        btnCreateBackup.Text = "Create Backup"
        btnCreateBackup.UseVisualStyleBackColor = True
        ' 
        ' btnBrowseBackup
        ' 
        btnBrowseBackup.Location = New Point(172, 67)
        btnBrowseBackup.Name = "btnBrowseBackup"
        btnBrowseBackup.Size = New Size(173, 37)
        btnBrowseBackup.TabIndex = 2
        btnBrowseBackup.Text = "Browse Backup"
        btnBrowseBackup.UseVisualStyleBackColor = True
        ' 
        ' txtBackupPath
        ' 
        txtBackupPath.Location = New Point(172, 19)
        txtBackupPath.Name = "txtBackupPath"
        txtBackupPath.Size = New Size(720, 26)
        txtBackupPath.TabIndex = 1
        ' 
        ' lblBackupLocation
        ' 
        lblBackupLocation.AutoSize = True
        lblBackupLocation.Location = New Point(34, 24)
        lblBackupLocation.Name = "lblBackupLocation"
        lblBackupLocation.Size = New Size(129, 18)
        lblBackupLocation.TabIndex = 0
        lblBackupLocation.Text = "Backup Location:"
        ' 
        ' RestorePanel
        ' 
        RestorePanel.Controls.Add(btnRestoreDatabase)
        RestorePanel.Controls.Add(btnBrowseRestore)
        RestorePanel.Controls.Add(txtRestorePath)
        RestorePanel.Controls.Add(lblRestoreFrom)
        RestorePanel.Location = New Point(28, 172)
        RestorePanel.Name = "RestorePanel"
        RestorePanel.Size = New Size(939, 123)
        RestorePanel.TabIndex = 4
        ' 
        ' btnRestoreDatabase
        ' 
        btnRestoreDatabase.Location = New Point(719, 67)
        btnRestoreDatabase.Name = "btnRestoreDatabase"
        btnRestoreDatabase.Size = New Size(173, 37)
        btnRestoreDatabase.TabIndex = 3
        btnRestoreDatabase.Text = "Restore Database"
        btnRestoreDatabase.UseVisualStyleBackColor = True
        ' 
        ' btnBrowseRestore
        ' 
        btnBrowseRestore.Location = New Point(172, 67)
        btnBrowseRestore.Name = "btnBrowseRestore"
        btnBrowseRestore.Size = New Size(173, 37)
        btnBrowseRestore.TabIndex = 2
        btnBrowseRestore.Text = "Browse  Restore"
        btnBrowseRestore.UseVisualStyleBackColor = True
        ' 
        ' txtRestorePath
        ' 
        txtRestorePath.Location = New Point(172, 19)
        txtRestorePath.Name = "txtRestorePath"
        txtRestorePath.Size = New Size(720, 26)
        txtRestorePath.TabIndex = 1
        ' 
        ' lblRestoreFrom
        ' 
        lblRestoreFrom.AutoSize = True
        lblRestoreFrom.Location = New Point(34, 24)
        lblRestoreFrom.Name = "lblRestoreFrom"
        lblRestoreFrom.Size = New Size(108, 18)
        lblRestoreFrom.TabIndex = 0
        lblRestoreFrom.Text = "Restore From:"
        ' 
        ' ProgressPanel
        ' 
        ProgressPanel.Controls.Add(ProgressBar1)
        ProgressPanel.Controls.Add(lblStatus)
        ProgressPanel.Location = New Point(28, 327)
        ProgressPanel.Name = "ProgressPanel"
        ProgressPanel.Size = New Size(939, 120)
        ProgressPanel.TabIndex = 5
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(125, 39)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(765, 39)
        ProgressBar1.TabIndex = 1
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(47, 50)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(56, 18)
        lblStatus.TabIndex = 0
        lblStatus.Text = "Status:"
        ' 
        ' FrmBackupRestore
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 540)
        Controls.Add(ProgressPanel)
        Controls.Add(RestorePanel)
        Controls.Add(dgvBackupPanel)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "FrmBackupRestore"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Backup/Restore"
        dgvBackupPanel.ResumeLayout(False)
        dgvBackupPanel.PerformLayout()
        RestorePanel.ResumeLayout(False)
        RestorePanel.PerformLayout()
        ProgressPanel.ResumeLayout(False)
        ProgressPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvBackupPanel As Panel
    Friend WithEvents btnBrowseBackup As Button
    Friend WithEvents txtBackupPath As TextBox
    Friend WithEvents lblBackupLocation As Label
    Friend WithEvents btnCreateBackup As Button
    Friend WithEvents RestorePanel As Panel
    Friend WithEvents btnRestoreDatabase As Button
    Friend WithEvents btnBrowseRestore As Button
    Friend WithEvents txtRestorePath As TextBox
    Friend WithEvents lblRestoreFrom As Label
    Friend WithEvents ProgressPanel As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblStatus As Label
End Class
