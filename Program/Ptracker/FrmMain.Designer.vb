<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lblConnect = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSwitchUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpDoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPatron = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPatronLoginUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPatronPatron = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPatronReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStafLoginUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStafPatron = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStaffPatronReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirector = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirectorAddEvents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirectorLoginUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirectorPatron = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirectorReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirectorAttendFix = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirectorPatronReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDirectorAttendanceAnalytics = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminAddEvents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminLoginUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminPatron = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminAttendFix = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminPatronReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminAttendanceAnalytics = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdminSchedulingManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConnect
        '
        Me.lblConnect.AutoSize = True
        Me.lblConnect.Location = New System.Drawing.Point(973, 511)
        Me.lblConnect.Name = "lblConnect"
        Me.lblConnect.Size = New System.Drawing.Size(104, 18)
        Me.lblConnect.TabIndex = 1
        Me.lblConnect.Text = "Disconnected"
        Me.lblConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuView, Me.mnuHelp, Me.mnuPatron, Me.mnuStaff, Me.mnuDirector, Me.mnuAdmin})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1089, 26)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileClose, Me.mnuFileSwitchUser})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 22)
        Me.mnuFile.Text = "File"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(159, 22)
        Me.mnuFileClose.Text = "Close"
        '
        'mnuFileSwitchUser
        '
        Me.mnuFileSwitchUser.Name = "mnuFileSwitchUser"
        Me.mnuFileSwitchUser.Size = New System.Drawing.Size(159, 22)
        Me.mnuFileSwitchUser.Text = "Switch User"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(48, 22)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuView
        '
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(55, 22)
        Me.mnuView.Text = "View"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout, Me.mnuHelpDoc})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(52, 22)
        Me.mnuHelp.Text = "Help"
        Me.mnuHelp.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(181, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'mnuHelpDoc
        '
        Me.mnuHelpDoc.Name = "mnuHelpDoc"
        Me.mnuHelpDoc.Size = New System.Drawing.Size(181, 22)
        Me.mnuHelpDoc.Text = "Documentation"
        '
        'mnuPatron
        '
        Me.mnuPatron.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPatronLoginUpdate, Me.mnuPatronPatron, Me.mnuPatronReport})
        Me.mnuPatron.Name = "mnuPatron"
        Me.mnuPatron.Size = New System.Drawing.Size(66, 22)
        Me.mnuPatron.Text = "Patron"
        '
        'mnuPatronLoginUpdate
        '
        Me.mnuPatronLoginUpdate.Name = "mnuPatronLoginUpdate"
        Me.mnuPatronLoginUpdate.Size = New System.Drawing.Size(176, 22)
        Me.mnuPatronLoginUpdate.Text = "Update Login"
        '
        'mnuPatronPatron
        '
        Me.mnuPatronPatron.Name = "mnuPatronPatron"
        Me.mnuPatronPatron.Size = New System.Drawing.Size(176, 22)
        Me.mnuPatronPatron.Text = "Update Profile"
        '
        'mnuPatronReport
        '
        Me.mnuPatronReport.Name = "mnuPatronReport"
        Me.mnuPatronReport.Size = New System.Drawing.Size(176, 22)
        Me.mnuPatronReport.Text = "Patron Report"
        '
        'mnuStaff
        '
        Me.mnuStaff.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStafLoginUpdate, Me.mnuStafPatron, Me.mnuStaffPatronReport})
        Me.mnuStaff.Name = "mnuStaff"
        Me.mnuStaff.Size = New System.Drawing.Size(52, 22)
        Me.mnuStaff.Text = "Staff"
        '
        'mnuStafLoginUpdate
        '
        Me.mnuStafLoginUpdate.Name = "mnuStafLoginUpdate"
        Me.mnuStafLoginUpdate.Size = New System.Drawing.Size(176, 22)
        Me.mnuStafLoginUpdate.Text = "Update Login"
        '
        'mnuStafPatron
        '
        Me.mnuStafPatron.Name = "mnuStafPatron"
        Me.mnuStafPatron.Size = New System.Drawing.Size(176, 22)
        Me.mnuStafPatron.Text = "Update Profile"
        '
        'mnuStaffPatronReport
        '
        Me.mnuStaffPatronReport.Name = "mnuStaffPatronReport"
        Me.mnuStaffPatronReport.Size = New System.Drawing.Size(176, 22)
        Me.mnuStaffPatronReport.Text = "Patron Report"
        '
        'mnuDirector
        '
        Me.mnuDirector.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDirectorAddEvents, Me.mnuDirectorLoginUpdate, Me.mnuDirectorPatron, Me.mnuDirectorReport, Me.mnuDirectorAttendFix, Me.mnuDirectorPatronReport, Me.mnuDirectorAttendanceAnalytics})
        Me.mnuDirector.Name = "mnuDirector"
        Me.mnuDirector.Size = New System.Drawing.Size(76, 22)
        Me.mnuDirector.Text = "Director"
        '
        'mnuDirectorAddEvents
        '
        Me.mnuDirectorAddEvents.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDirectorAddEvents.Name = "mnuDirectorAddEvents"
        Me.mnuDirectorAddEvents.Size = New System.Drawing.Size(220, 22)
        Me.mnuDirectorAddEvents.Text = "A/C/D Events"
        '
        'mnuDirectorLoginUpdate
        '
        Me.mnuDirectorLoginUpdate.Name = "mnuDirectorLoginUpdate"
        Me.mnuDirectorLoginUpdate.Size = New System.Drawing.Size(220, 22)
        Me.mnuDirectorLoginUpdate.Text = "Update Login"
        '
        'mnuDirectorPatron
        '
        Me.mnuDirectorPatron.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuDirectorPatron.Name = "mnuDirectorPatron"
        Me.mnuDirectorPatron.Size = New System.Drawing.Size(220, 22)
        Me.mnuDirectorPatron.Text = "Update Profile"
        '
        'mnuDirectorReport
        '
        Me.mnuDirectorReport.Name = "mnuDirectorReport"
        Me.mnuDirectorReport.Size = New System.Drawing.Size(220, 22)
        Me.mnuDirectorReport.Text = "Reports"
        '
        'mnuDirectorAttendFix
        '
        Me.mnuDirectorAttendFix.Name = "mnuDirectorAttendFix"
        Me.mnuDirectorAttendFix.Size = New System.Drawing.Size(220, 22)
        Me.mnuDirectorAttendFix.Text = "Fix Attendance"
        '
        'mnuDirectorPatronReport
        '
        Me.mnuDirectorPatronReport.Name = "mnuDirectorPatronReport"
        Me.mnuDirectorPatronReport.Size = New System.Drawing.Size(220, 22)
        Me.mnuDirectorPatronReport.Text = "Patron Report"
        '
        'mnuDirectorAttendanceAnalytics
        '
        Me.mnuDirectorAttendanceAnalytics.Name = "mnuDirectorAttendanceAnalytics"
        Me.mnuDirectorAttendanceAnalytics.Size = New System.Drawing.Size(220, 22)
        Me.mnuDirectorAttendanceAnalytics.Text = "Attendance Analytics"
        '
        'mnuAdmin
        '
        Me.mnuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdminAddEvents, Me.mnuAdminLoginUpdate, Me.mnuAdminPatron, Me.mnuAdminReports, Me.mnuAdminAbout, Me.mnuAdminAttendFix, Me.mnuAdminSettings, Me.mnuAdminPatronReport, Me.mnuAdminAttendanceAnalytics, Me.mnuAdminSchedulingManagement})
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Size = New System.Drawing.Size(65, 22)
        Me.mnuAdmin.Text = "Admin"
        '
        'mnuAdminAddEvents
        '
        Me.mnuAdminAddEvents.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAdminAddEvents.Name = "mnuAdminAddEvents"
        Me.mnuAdminAddEvents.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminAddEvents.Text = "A/C/D Events"
        '
        'mnuAdminLoginUpdate
        '
        Me.mnuAdminLoginUpdate.Name = "mnuAdminLoginUpdate"
        Me.mnuAdminLoginUpdate.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminLoginUpdate.Text = "Update Login"
        '
        'mnuAdminPatron
        '
        Me.mnuAdminPatron.Name = "mnuAdminPatron"
        Me.mnuAdminPatron.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminPatron.Text = "Update Profile"
        '
        'mnuAdminReports
        '
        Me.mnuAdminReports.Name = "mnuAdminReports"
        Me.mnuAdminReports.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminReports.Text = "Reports"
        '
        'mnuAdminAbout
        '
        Me.mnuAdminAbout.Name = "mnuAdminAbout"
        Me.mnuAdminAbout.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminAbout.Text = "Fix About"
        '
        'mnuAdminAttendFix
        '
        Me.mnuAdminAttendFix.Name = "mnuAdminAttendFix"
        Me.mnuAdminAttendFix.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminAttendFix.Text = "Fix Attendance"
        '
        'mnuAdminSettings
        '
        Me.mnuAdminSettings.Name = "mnuAdminSettings"
        Me.mnuAdminSettings.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminSettings.Text = "Settings"
        '
        'mnuAdminPatronReport
        '
        Me.mnuAdminPatronReport.Name = "mnuAdminPatronReport"
        Me.mnuAdminPatronReport.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminPatronReport.Text = "Patron Report"
        '
        'mnuAdminAttendanceAnalytics
        '
        Me.mnuAdminAttendanceAnalytics.Name = "mnuAdminAttendanceAnalytics"
        Me.mnuAdminAttendanceAnalytics.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminAttendanceAnalytics.Text = "Attendance Analytics"
        '
        'mnuAdminSchedulingManagement
        '
        Me.mnuAdminSchedulingManagement.Name = "mnuAdminSchedulingManagement"
        Me.mnuAdminSchedulingManagement.Size = New System.Drawing.Size(248, 22)
        Me.mnuAdminSchedulingManagement.Text = "Scheduling Management"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 538)
        Me.Controls.Add(Me.lblConnect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.Text = "Patron Tracker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConnect As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents mnuPatron As ToolStripMenuItem
    Friend WithEvents mnuStaff As ToolStripMenuItem
    Friend WithEvents mnuStaffPatron As ToolStripMenuItem
    Friend WithEvents mnuDirector As ToolStripMenuItem
    Friend WithEvents mnuAdmin As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuStafPatron As ToolStripMenuItem
    Friend WithEvents mnuDirectorPatron As ToolStripMenuItem
    Friend WithEvents mnuAdminPatron As ToolStripMenuItem
    Friend WithEvents mnuDirectorAddEvents As ToolStripMenuItem
    Friend WithEvents mnuAdminAddEvents As ToolStripMenuItem
    Friend WithEvents mnuPatronPatron As ToolStripMenuItem
    Friend WithEvents mnuAdminLoginUpdate As ToolStripMenuItem
    Friend WithEvents mnuStafLoginUpdate As ToolStripMenuItem
    Friend WithEvents mnuDirectorLoginUpdate As ToolStripMenuItem
    Friend WithEvents mnuAdminReports As ToolStripMenuItem
    Friend WithEvents mnuDirectorReport As ToolStripMenuItem
    Friend WithEvents mnuPatronLoginUpdate As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuAdminAbout As ToolStripMenuItem
    Friend WithEvents mnuAdminAttendFix As ToolStripMenuItem
    Friend WithEvents mnuDirectorAttendFix As ToolStripMenuItem
    Friend WithEvents mnuAdminSettings As ToolStripMenuItem
    Friend WithEvents mnuPatronReport As ToolStripMenuItem
    Friend WithEvents mnuStaffPatronReport As ToolStripMenuItem
    Friend WithEvents mnuDirectorPatronReport As ToolStripMenuItem
    Friend WithEvents mnuAdminPatronReport As ToolStripMenuItem
    Friend WithEvents mnuFileSwitchUser As ToolStripMenuItem
    Friend WithEvents mnuHelpDoc As ToolStripMenuItem
    Friend WithEvents mnuAdminAttendanceAnalytics As ToolStripMenuItem
    Friend WithEvents mnuDirectorAttendanceAnalytics As ToolStripMenuItem
    Friend WithEvents mnuAdminSchedulingManagement As ToolStripMenuItem
End Class
