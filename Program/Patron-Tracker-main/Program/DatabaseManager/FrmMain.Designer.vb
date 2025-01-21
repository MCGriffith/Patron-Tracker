<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuFileConnectToDatabase = New ToolStripMenuItem()
        mnuFileExit = New ToolStripMenuItem()
        mnuTools = New ToolStripMenuItem()
        mnuToolsTableManager = New ToolStripMenuItem()
        mnuToolsFieldManager = New ToolStripMenuItem()
        mnuToolsRelationships = New ToolStripMenuItem()
        mnuToolsViewScripts = New ToolStripMenuItem()
        mnuToolsBackupRestore = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile, mnuTools})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 26)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuFileConnectToDatabase, mnuFileExit})
        mnuFile.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(46, 22)
        mnuFile.Text = "File"
        ' 
        ' mnuFileConnectToDatabase
        ' 
        mnuFileConnectToDatabase.Name = "mnuFileConnectToDatabase"
        mnuFileConnectToDatabase.Size = New Size(224, 22)
        mnuFileConnectToDatabase.Text = "Connect to Database"
        ' 
        ' mnuFileExit
        ' 
        mnuFileExit.Name = "mnuFileExit"
        mnuFileExit.Size = New Size(224, 22)
        mnuFileExit.Text = "Exit"
        ' 
        ' mnuTools
        ' 
        mnuTools.DropDownItems.AddRange(New ToolStripItem() {mnuToolsTableManager, mnuToolsFieldManager, mnuToolsRelationships, mnuToolsViewScripts, mnuToolsBackupRestore})
        mnuTools.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mnuTools.Name = "mnuTools"
        mnuTools.Size = New Size(56, 22)
        mnuTools.Text = "Tools"
        ' 
        ' mnuToolsTableManager
        ' 
        mnuToolsTableManager.Name = "mnuToolsTableManager"
        mnuToolsTableManager.Size = New Size(196, 22)
        mnuToolsTableManager.Text = "Table Manager"
        ' 
        ' mnuToolsFieldManager
        ' 
        mnuToolsFieldManager.Name = "mnuToolsFieldManager"
        mnuToolsFieldManager.Size = New Size(196, 22)
        mnuToolsFieldManager.Text = "Field Manager"
        ' 
        ' mnuToolsRelationships
        ' 
        mnuToolsRelationships.Name = "mnuToolsRelationships"
        mnuToolsRelationships.Size = New Size(196, 22)
        mnuToolsRelationships.Text = "Relationships"
        ' 
        ' mnuToolsViewScripts
        ' 
        mnuToolsViewScripts.Name = "mnuToolsViewScripts"
        mnuToolsViewScripts.Size = New Size(196, 22)
        mnuToolsViewScripts.Text = "View Scripts"
        ' 
        ' mnuToolsBackupRestore
        ' 
        mnuToolsBackupRestore.Name = "mnuToolsBackupRestore"
        mnuToolsBackupRestore.Size = New Size(196, 22)
        mnuToolsBackupRestore.Text = "Backup / Restore"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FrmMain"
        Text = "Database Manager"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileConnectToDatabase As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuTools As ToolStripMenuItem
    Friend WithEvents mnuToolsTableManager As ToolStripMenuItem
    Friend WithEvents mnuToolsFieldManager As ToolStripMenuItem
    Friend WithEvents mnuToolsRelationships As ToolStripMenuItem
    Friend WithEvents mnuToolsViewScripts As ToolStripMenuItem
    Friend WithEvents mnuToolsBackupRestore As ToolStripMenuItem
End Class
