<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseTables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseRelations = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatabaseIndexes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvwObjects = New System.Windows.Forms.ListView()
        Me.MainName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MainType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.pbProgress = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuDatabase, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(664, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 19)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuDatabase
        '
        Me.mnuDatabase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatabaseTables, Me.mnuDatabaseRelations, Me.mnuDatabaseIndexes})
        Me.mnuDatabase.Name = "mnuDatabase"
        Me.mnuDatabase.Size = New System.Drawing.Size(67, 19)
        Me.mnuDatabase.Text = "Database"
        '
        'mnuDatabaseTables
        '
        Me.mnuDatabaseTables.Name = "mnuDatabaseTables"
        Me.mnuDatabaseTables.Size = New System.Drawing.Size(167, 22)
        Me.mnuDatabaseTables.Text = "Table Manager"
        '
        'mnuDatabaseRelations
        '
        Me.mnuDatabaseRelations.Name = "mnuDatabaseRelations"
        Me.mnuDatabaseRelations.Size = New System.Drawing.Size(167, 22)
        Me.mnuDatabaseRelations.Text = "Relation Manager"
        '
        'mnuDatabaseIndexes
        '
        Me.mnuDatabaseIndexes.Name = "mnuDatabaseIndexes"
        Me.mnuDatabaseIndexes.Size = New System.Drawing.Size(167, 22)
        Me.mnuDatabaseIndexes.Text = "Index Manager"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 19)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'lvwObjects
        '
        Me.lvwObjects.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MainName, Me.MainType})
        Me.lvwObjects.GridLines = True
        Me.lvwObjects.HideSelection = False
        Me.lvwObjects.Location = New System.Drawing.Point(22, 43)
        Me.lvwObjects.Name = "lvwObjects"
        Me.lvwObjects.Size = New System.Drawing.Size(259, 401)
        Me.lvwObjects.TabIndex = 1
        Me.lvwObjects.UseCompatibleStateImageBehavior = False
        Me.lvwObjects.View = System.Windows.Forms.View.Details
        '
        'MainName
        '
        Me.MainName.Text = "Name"
        Me.MainName.Width = 150
        '
        'MainType
        '
        Me.MainType.Text = "Type"
        Me.MainType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MainType.Width = 100
        '
        'ssMain
        '
        Me.ssMain.Location = New System.Drawing.Point(0, 458)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Size = New System.Drawing.Size(664, 22)
        Me.ssMain.TabIndex = 2
        Me.ssMain.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(19, 458)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 18)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Label1"
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(354, 458)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(290, 21)
        Me.pbProgress.TabIndex = 4
        '
        'FrmMain2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 480)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.lvwObjects)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuDatabase As ToolStripMenuItem
    Friend WithEvents mnuDatabaseTables As ToolStripMenuItem
    Friend WithEvents mnuDatabaseRelations As ToolStripMenuItem
    Friend WithEvents mnuDatabaseIndexes As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents lvwObjects As ListView
    Friend WithEvents MainName As ColumnHeader
    Friend WithEvents MainType As ColumnHeader
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents lblStatus As Label
    Friend WithEvents pbProgress As ProgressBar
End Class
