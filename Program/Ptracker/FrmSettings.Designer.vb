<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.grpDatabase = New System.Windows.Forms.GroupBox()
        Me.txtDatabasePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpBackup = New System.Windows.Forms.GroupBox()
        Me.btnBrowseLocation = New System.Windows.Forms.Button()
        Me.lblSelectedPath = New System.Windows.Forms.Label()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.lblLastBackup = New System.Windows.Forms.Label()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.cboBackupLocation = New System.Windows.Forms.ComboBox()
        Me.btnViewLogs = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpDatabase.SuspendLayout()
        Me.grpBackup.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatabase
        '
        Me.grpDatabase.Controls.Add(Me.txtDatabasePath)
        Me.grpDatabase.Location = New System.Drawing.Point(232, 35)
        Me.grpDatabase.Name = "grpDatabase"
        Me.grpDatabase.Size = New System.Drawing.Size(542, 90)
        Me.grpDatabase.TabIndex = 0
        Me.grpDatabase.TabStop = False
        Me.grpDatabase.Text = "Database Location:"
        '
        'txtDatabasePath
        '
        Me.txtDatabasePath.Location = New System.Drawing.Point(23, 38)
        Me.txtDatabasePath.Name = "txtDatabasePath"
        Me.txtDatabasePath.Size = New System.Drawing.Size(487, 26)
        Me.txtDatabasePath.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.btnBrowse.Location = New System.Drawing.Point(20, 67)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(192, 44)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse. . ."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(20, 237)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(192, 44)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'grpBackup
        '
        Me.grpBackup.Controls.Add(Me.btnBrowseLocation)
        Me.grpBackup.Controls.Add(Me.lblSelectedPath)
        Me.grpBackup.Controls.Add(Me.btnRestore)
        Me.grpBackup.Controls.Add(Me.lblLastBackup)
        Me.grpBackup.Controls.Add(Me.btnBackup)
        Me.grpBackup.Controls.Add(Me.cboBackupLocation)
        Me.grpBackup.Location = New System.Drawing.Point(233, 154)
        Me.grpBackup.Name = "grpBackup"
        Me.grpBackup.Size = New System.Drawing.Size(541, 217)
        Me.grpBackup.TabIndex = 3
        Me.grpBackup.TabStop = False
        Me.grpBackup.Text = "Database Back/Restore"
        '
        'btnBrowseLocation
        '
        Me.btnBrowseLocation.BackColor = System.Drawing.SystemColors.Control
        Me.btnBrowseLocation.Location = New System.Drawing.Point(32, 82)
        Me.btnBrowseLocation.Name = "btnBrowseLocation"
        Me.btnBrowseLocation.Size = New System.Drawing.Size(192, 45)
        Me.btnBrowseLocation.TabIndex = 4
        Me.btnBrowseLocation.Text = "Backup Location"
        Me.btnBrowseLocation.UseVisualStyleBackColor = False
        '
        'lblSelectedPath
        '
        Me.lblSelectedPath.AutoSize = True
        Me.lblSelectedPath.Location = New System.Drawing.Point(259, 40)
        Me.lblSelectedPath.Name = "lblSelectedPath"
        Me.lblSelectedPath.Size = New System.Drawing.Size(186, 18)
        Me.lblSelectedPath.TabIndex = 2
        Me.lblSelectedPath.Text = "Select a Backup Location"
        '
        'btnRestore
        '
        Me.btnRestore.BackColor = System.Drawing.SystemColors.Control
        Me.btnRestore.Location = New System.Drawing.Point(262, 151)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(192, 44)
        Me.btnRestore.TabIndex = 6
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'lblLastBackup
        '
        Me.lblLastBackup.AutoSize = True
        Me.lblLastBackup.Location = New System.Drawing.Point(259, 95)
        Me.lblLastBackup.Name = "lblLastBackup"
        Me.lblLastBackup.Size = New System.Drawing.Size(253, 18)
        Me.lblLastBackup.TabIndex = 1
        Me.lblLastBackup.Text = "Unable to determine Backup Status"
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.SystemColors.Control
        Me.btnBackup.Location = New System.Drawing.Point(32, 151)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(192, 44)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'cboBackupLocation
        '
        Me.cboBackupLocation.FormattingEnabled = True
        Me.cboBackupLocation.Location = New System.Drawing.Point(31, 37)
        Me.cboBackupLocation.Name = "cboBackupLocation"
        Me.cboBackupLocation.Size = New System.Drawing.Size(192, 26)
        Me.cboBackupLocation.TabIndex = 3
        '
        'btnViewLogs
        '
        Me.btnViewLogs.BackColor = System.Drawing.SystemColors.Control
        Me.btnViewLogs.Location = New System.Drawing.Point(20, 168)
        Me.btnViewLogs.Name = "btnViewLogs"
        Me.btnViewLogs.Size = New System.Drawing.Size(192, 44)
        Me.btnViewLogs.TabIndex = 7
        Me.btnViewLogs.Text = "View Log"
        Me.btnViewLogs.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(20, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(192, 44)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 399)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewLogs)
        Me.Controls.Add(Me.grpBackup)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.grpDatabase)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.grpDatabase.ResumeLayout(False)
        Me.grpDatabase.PerformLayout()
        Me.grpBackup.ResumeLayout(False)
        Me.grpBackup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDatabase As GroupBox
    Friend WithEvents txtDatabasePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents grpBackup As GroupBox
    Friend WithEvents lblLastBackup As Label
    Friend WithEvents cboBackupLocation As ComboBox
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents btnViewLogs As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnBrowseLocation As Button
    Friend WithEvents lblSelectedPath As Label
    Friend WithEvents txtLocalPath As TextBox
    Friend WithEvents txtNetworkPath As TextBox
    Friend WithEvents txtExternalPath As TextBox
End Class
