<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVolunteer
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
		Me.tabManagment = New System.Windows.Forms.TabControl()
		Me.tabSchedule = New System.Windows.Forms.TabPage()
		Me.grpSchedule = New System.Windows.Forms.GroupBox()
		Me.lvwSchedule = New System.Windows.Forms.ListView()
		Me.SchedDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SchedStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SchedEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SchedStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnSchedEdit = New System.Windows.Forms.Button()
		Me.btnSchedRemove = New System.Windows.Forms.Button()
		Me.btnSchedAdd = New System.Windows.Forms.Button()
		Me.lblEnd = New System.Windows.Forms.Label()
		Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
		Me.lblStart = New System.Windows.Forms.Label()
		Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
		Me.lblDay = New System.Windows.Forms.Label()
		Me.cboSchedDay = New System.Windows.Forms.ComboBox()
		Me.tabVolunteer = New System.Windows.Forms.TabPage()
		Me.grpSubstitute = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.lvwSubstitute = New System.Windows.Forms.ListView()
		Me.SubVol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SubSub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SubDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SubStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SubEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SubStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.lblSubSched = New System.Windows.Forms.Label()
		Me.lblSub = New System.Windows.Forms.Label()
		Me.cboSub = New System.Windows.Forms.ComboBox()
		Me.cboSubSched = New System.Windows.Forms.ComboBox()
		Me.grpVolunteer = New System.Windows.Forms.GroupBox()
		Me.btnVolRemove = New System.Windows.Forms.Button()
		Me.btnVolAdd = New System.Windows.Forms.Button()
		Me.lvwVolunteer = New System.Windows.Forms.ListView()
		Me.VolDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.VolStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.VolEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.VolStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.lblSched = New System.Windows.Forms.Label()
		Me.lblVol = New System.Windows.Forms.Label()
		Me.cboVol = New System.Windows.Forms.ComboBox()
		Me.cboSched = New System.Windows.Forms.ComboBox()
		Me.tabClosing = New System.Windows.Forms.TabPage()
		Me.grpClosing = New System.Windows.Forms.GroupBox()
		Me.btnCloseRemove = New System.Windows.Forms.Button()
		Me.btnCloseEdit = New System.Windows.Forms.Button()
		Me.btnCloseAdd = New System.Windows.Forms.Button()
		Me.lvwSubstitute1 = New System.Windows.Forms.ListView()
		Me.CloseStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.CloseEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.CloseEmergency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.CloseDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chkEmergency = New System.Windows.Forms.CheckBox()
		Me.lblEndDate = New System.Windows.Forms.Label()
		Me.lbStartDate = New System.Windows.Forms.Label()
		Me.dtpCloseEnd = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.tabCalendar = New System.Windows.Forms.TabPage()
		Me.tabReport = New System.Windows.Forms.TabPage()
		Me.tabManagment.SuspendLayout()
		Me.tabSchedule.SuspendLayout()
		Me.grpSchedule.SuspendLayout()
		Me.tabVolunteer.SuspendLayout()
		Me.grpSubstitute.SuspendLayout()
		Me.grpVolunteer.SuspendLayout()
		Me.tabClosing.SuspendLayout()
		Me.grpClosing.SuspendLayout()
		Me.SuspendLayout()
		'
		'tabManagment
		'
		Me.tabManagment.Controls.Add(Me.tabSchedule)
		Me.tabManagment.Controls.Add(Me.tabVolunteer)
		Me.tabManagment.Controls.Add(Me.tabClosing)
		Me.tabManagment.Controls.Add(Me.tabCalendar)
		Me.tabManagment.Controls.Add(Me.tabReport)
		Me.tabManagment.Location = New System.Drawing.Point(12, 21)
		Me.tabManagment.Name = "tabManagment"
		Me.tabManagment.SelectedIndex = 0
		Me.tabManagment.Size = New System.Drawing.Size(816, 675)
		Me.tabManagment.TabIndex = 0
		'
		'tabSchedule
		'
		Me.tabSchedule.Controls.Add(Me.grpSchedule)
		Me.tabSchedule.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tabSchedule.Location = New System.Drawing.Point(4, 27)
		Me.tabSchedule.Name = "tabSchedule"
		Me.tabSchedule.Padding = New System.Windows.Forms.Padding(3)
		Me.tabSchedule.Size = New System.Drawing.Size(808, 644)
		Me.tabSchedule.TabIndex = 0
		Me.tabSchedule.Text = "Schedules"
		Me.tabSchedule.UseVisualStyleBackColor = True
		'
		'grpSchedule
		'
		Me.grpSchedule.Controls.Add(Me.lvwSchedule)
		Me.grpSchedule.Controls.Add(Me.btnSchedEdit)
		Me.grpSchedule.Controls.Add(Me.btnSchedRemove)
		Me.grpSchedule.Controls.Add(Me.btnSchedAdd)
		Me.grpSchedule.Controls.Add(Me.lblEnd)
		Me.grpSchedule.Controls.Add(Me.dtpEndTime)
		Me.grpSchedule.Controls.Add(Me.lblStart)
		Me.grpSchedule.Controls.Add(Me.dtpStartTime)
		Me.grpSchedule.Controls.Add(Me.lblDay)
		Me.grpSchedule.Controls.Add(Me.cboSchedDay)
		Me.grpSchedule.Location = New System.Drawing.Point(27, 33)
		Me.grpSchedule.Name = "grpSchedule"
		Me.grpSchedule.Size = New System.Drawing.Size(600, 507)
		Me.grpSchedule.TabIndex = 0
		Me.grpSchedule.TabStop = False
		Me.grpSchedule.Text = "Build Schedules"
		'
		'lvwSchedule
		'
		Me.lvwSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SchedDay, Me.SchedStart, Me.SchedEnd, Me.SchedStatus})
		Me.lvwSchedule.GridLines = True
		Me.lvwSchedule.HideSelection = False
		Me.lvwSchedule.Location = New System.Drawing.Point(65, 209)
		Me.lvwSchedule.Name = "lvwSchedule"
		Me.lvwSchedule.Size = New System.Drawing.Size(445, 266)
		Me.lvwSchedule.TabIndex = 9
		Me.lvwSchedule.UseCompatibleStateImageBehavior = False
		Me.lvwSchedule.View = System.Windows.Forms.View.Details
		'
		'SchedDay
		'
		Me.SchedDay.Text = "Day of Week"
		Me.SchedDay.Width = 120
		'
		'SchedStart
		'
		Me.SchedStart.Text = "Start Time"
		Me.SchedStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SchedStart.Width = 120
		'
		'SchedEnd
		'
		Me.SchedEnd.Text = "End Time"
		Me.SchedEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SchedEnd.Width = 120
		'
		'SchedStatus
		'
		Me.SchedStatus.Text = "Status"
		Me.SchedStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SchedStatus.Width = 80
		'
		'btnSchedEdit
		'
		Me.btnSchedEdit.Location = New System.Drawing.Point(399, 90)
		Me.btnSchedEdit.Name = "btnSchedEdit"
		Me.btnSchedEdit.Size = New System.Drawing.Size(155, 32)
		Me.btnSchedEdit.TabIndex = 8
		Me.btnSchedEdit.Text = "Update Schedule"
		Me.btnSchedEdit.UseVisualStyleBackColor = True
		'
		'btnSchedRemove
		'
		Me.btnSchedRemove.Location = New System.Drawing.Point(399, 139)
		Me.btnSchedRemove.Name = "btnSchedRemove"
		Me.btnSchedRemove.Size = New System.Drawing.Size(155, 32)
		Me.btnSchedRemove.TabIndex = 7
		Me.btnSchedRemove.Text = "Remove Schedule"
		Me.btnSchedRemove.UseVisualStyleBackColor = True
		'
		'btnSchedAdd
		'
		Me.btnSchedAdd.Location = New System.Drawing.Point(399, 44)
		Me.btnSchedAdd.Name = "btnSchedAdd"
		Me.btnSchedAdd.Size = New System.Drawing.Size(155, 32)
		Me.btnSchedAdd.TabIndex = 6
		Me.btnSchedAdd.Text = "Add Schedule"
		Me.btnSchedAdd.UseVisualStyleBackColor = True
		'
		'lblEnd
		'
		Me.lblEnd.AutoSize = True
		Me.lblEnd.Location = New System.Drawing.Point(62, 153)
		Me.lblEnd.Name = "lblEnd"
		Me.lblEnd.Size = New System.Drawing.Size(79, 18)
		Me.lblEnd.TabIndex = 5
		Me.lblEnd.Text = "Start Time"
		'
		'dtpEndTime
		'
		Me.dtpEndTime.CustomFormat = "HH:mm"
		Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpEndTime.Location = New System.Drawing.Point(151, 147)
		Me.dtpEndTime.Name = "dtpEndTime"
		Me.dtpEndTime.ShowUpDown = True
		Me.dtpEndTime.Size = New System.Drawing.Size(108, 26)
		Me.dtpEndTime.TabIndex = 4
		'
		'lblStart
		'
		Me.lblStart.AutoSize = True
		Me.lblStart.Location = New System.Drawing.Point(62, 102)
		Me.lblStart.Name = "lblStart"
		Me.lblStart.Size = New System.Drawing.Size(79, 18)
		Me.lblStart.TabIndex = 3
		Me.lblStart.Text = "Start Time"
		'
		'dtpStartTime
		'
		Me.dtpStartTime.CustomFormat = "HH:mm"
		Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpStartTime.Location = New System.Drawing.Point(151, 96)
		Me.dtpStartTime.Name = "dtpStartTime"
		Me.dtpStartTime.ShowUpDown = True
		Me.dtpStartTime.Size = New System.Drawing.Size(108, 26)
		Me.dtpStartTime.TabIndex = 2
		'
		'lblDay
		'
		Me.lblDay.AutoSize = True
		Me.lblDay.Location = New System.Drawing.Point(32, 51)
		Me.lblDay.Name = "lblDay"
		Me.lblDay.Size = New System.Drawing.Size(109, 18)
		Me.lblDay.TabIndex = 1
		Me.lblDay.Text = "Schedule Day:"
		'
		'cboSchedDay
		'
		Me.cboSchedDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSchedDay.FormattingEnabled = True
		Me.cboSchedDay.Location = New System.Drawing.Point(151, 43)
		Me.cboSchedDay.Name = "cboSchedDay"
		Me.cboSchedDay.Size = New System.Drawing.Size(138, 26)
		Me.cboSchedDay.TabIndex = 0
		'
		'tabVolunteer
		'
		Me.tabVolunteer.Controls.Add(Me.grpSubstitute)
		Me.tabVolunteer.Controls.Add(Me.grpVolunteer)
		Me.tabVolunteer.Location = New System.Drawing.Point(4, 27)
		Me.tabVolunteer.Name = "tabVolunteer"
		Me.tabVolunteer.Padding = New System.Windows.Forms.Padding(3)
		Me.tabVolunteer.Size = New System.Drawing.Size(808, 644)
		Me.tabVolunteer.TabIndex = 1
		Me.tabVolunteer.Text = "Volunteers & Substitutes"
		Me.tabVolunteer.UseVisualStyleBackColor = True
		'
		'grpSubstitute
		'
		Me.grpSubstitute.Controls.Add(Me.Button1)
		Me.grpSubstitute.Controls.Add(Me.Button2)
		Me.grpSubstitute.Controls.Add(Me.lvwSubstitute)
		Me.grpSubstitute.Controls.Add(Me.lblSubSched)
		Me.grpSubstitute.Controls.Add(Me.lblSub)
		Me.grpSubstitute.Controls.Add(Me.cboSub)
		Me.grpSubstitute.Controls.Add(Me.cboSubSched)
		Me.grpSubstitute.Location = New System.Drawing.Point(29, 314)
		Me.grpSubstitute.Name = "grpSubstitute"
		Me.grpSubstitute.Size = New System.Drawing.Size(735, 302)
		Me.grpSubstitute.TabIndex = 1
		Me.grpSubstitute.TabStop = False
		Me.grpSubstitute.Text = "Assign Substitute"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(443, 77)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(150, 32)
		Me.Button1.TabIndex = 13
		Me.Button1.Text = "Remove Schedule"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(443, 32)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(150, 32)
		Me.Button2.TabIndex = 12
		Me.Button2.Text = "Add Schedule"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'lvwSubstitute
		'
		Me.lvwSubstitute.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SubVol, Me.SubSub, Me.SubDay, Me.SubStart, Me.SubEnd, Me.SubStatus})
		Me.lvwSubstitute.GridLines = True
		Me.lvwSubstitute.HideSelection = False
		Me.lvwSubstitute.Location = New System.Drawing.Point(24, 124)
		Me.lvwSubstitute.Name = "lvwSubstitute"
		Me.lvwSubstitute.Size = New System.Drawing.Size(687, 156)
		Me.lvwSubstitute.TabIndex = 11
		Me.lvwSubstitute.UseCompatibleStateImageBehavior = False
		Me.lvwSubstitute.View = System.Windows.Forms.View.Details
		'
		'SubVol
		'
		Me.SubVol.Text = "Volunteer"
		Me.SubVol.Width = 120
		'
		'SubSub
		'
		Me.SubSub.Text = "Substitute"
		Me.SubSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SubSub.Width = 120
		'
		'SubDay
		'
		Me.SubDay.Text = "Day of Week"
		Me.SubDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SubDay.Width = 120
		'
		'SubStart
		'
		Me.SubStart.Text = "Start Time"
		Me.SubStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SubStart.Width = 120
		'
		'SubEnd
		'
		Me.SubEnd.Text = "End Time"
		Me.SubEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SubEnd.Width = 120
		'
		'SubStatus
		'
		Me.SubStatus.Text = "Status"
		Me.SubStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.SubStatus.Width = 80
		'
		'lblSubSched
		'
		Me.lblSubSched.AutoSize = True
		Me.lblSubSched.Location = New System.Drawing.Point(36, 85)
		Me.lblSubSched.Name = "lblSubSched"
		Me.lblSubSched.Size = New System.Drawing.Size(77, 18)
		Me.lblSubSched.TabIndex = 10
		Me.lblSubSched.Text = "Schedule:"
		'
		'lblSub
		'
		Me.lblSub.AutoSize = True
		Me.lblSub.Location = New System.Drawing.Point(32, 42)
		Me.lblSub.Name = "lblSub"
		Me.lblSub.Size = New System.Drawing.Size(81, 18)
		Me.lblSub.TabIndex = 9
		Me.lblSub.Text = "Substitute:"
		'
		'cboSub
		'
		Me.cboSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSub.FormattingEnabled = True
		Me.cboSub.Location = New System.Drawing.Point(119, 34)
		Me.cboSub.Name = "cboSub"
		Me.cboSub.Size = New System.Drawing.Size(263, 26)
		Me.cboSub.TabIndex = 7
		'
		'cboSubSched
		'
		Me.cboSubSched.FormattingEnabled = True
		Me.cboSubSched.Location = New System.Drawing.Point(119, 77)
		Me.cboSubSched.Name = "cboSubSched"
		Me.cboSubSched.Size = New System.Drawing.Size(263, 26)
		Me.cboSubSched.TabIndex = 8
		'
		'grpVolunteer
		'
		Me.grpVolunteer.Controls.Add(Me.btnVolRemove)
		Me.grpVolunteer.Controls.Add(Me.btnVolAdd)
		Me.grpVolunteer.Controls.Add(Me.lvwVolunteer)
		Me.grpVolunteer.Controls.Add(Me.lblSched)
		Me.grpVolunteer.Controls.Add(Me.lblVol)
		Me.grpVolunteer.Controls.Add(Me.cboVol)
		Me.grpVolunteer.Controls.Add(Me.cboSched)
		Me.grpVolunteer.Location = New System.Drawing.Point(29, 29)
		Me.grpVolunteer.Name = "grpVolunteer"
		Me.grpVolunteer.Size = New System.Drawing.Size(735, 267)
		Me.grpVolunteer.TabIndex = 0
		Me.grpVolunteer.TabStop = False
		Me.grpVolunteer.Text = "Assign Volunteer"
		'
		'btnVolRemove
		'
		Me.btnVolRemove.Location = New System.Drawing.Point(443, 70)
		Me.btnVolRemove.Name = "btnVolRemove"
		Me.btnVolRemove.Size = New System.Drawing.Size(150, 32)
		Me.btnVolRemove.TabIndex = 6
		Me.btnVolRemove.Text = "Remove Schedule"
		Me.btnVolRemove.UseVisualStyleBackColor = True
		'
		'btnVolAdd
		'
		Me.btnVolAdd.Location = New System.Drawing.Point(443, 25)
		Me.btnVolAdd.Name = "btnVolAdd"
		Me.btnVolAdd.Size = New System.Drawing.Size(150, 32)
		Me.btnVolAdd.TabIndex = 5
		Me.btnVolAdd.Text = "Add Schedule"
		Me.btnVolAdd.UseVisualStyleBackColor = True
		'
		'lvwVolunteer
		'
		Me.lvwVolunteer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.VolDay, Me.VolStart, Me.VolEnd, Me.VolStatus})
		Me.lvwVolunteer.GridLines = True
		Me.lvwVolunteer.HideSelection = False
		Me.lvwVolunteer.Location = New System.Drawing.Point(24, 117)
		Me.lvwVolunteer.Name = "lvwVolunteer"
		Me.lvwVolunteer.Size = New System.Drawing.Size(449, 131)
		Me.lvwVolunteer.TabIndex = 4
		Me.lvwVolunteer.UseCompatibleStateImageBehavior = False
		Me.lvwVolunteer.View = System.Windows.Forms.View.Details
		'
		'VolDay
		'
		Me.VolDay.Text = "Day of Week"
		Me.VolDay.Width = 120
		'
		'VolStart
		'
		Me.VolStart.Text = "Start Time"
		Me.VolStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.VolStart.Width = 120
		'
		'VolEnd
		'
		Me.VolEnd.Text = "End Time"
		Me.VolEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.VolEnd.Width = 120
		'
		'VolStatus
		'
		Me.VolStatus.Text = "Status"
		Me.VolStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.VolStatus.Width = 80
		'
		'lblSched
		'
		Me.lblSched.AutoSize = True
		Me.lblSched.Location = New System.Drawing.Point(36, 78)
		Me.lblSched.Name = "lblSched"
		Me.lblSched.Size = New System.Drawing.Size(77, 18)
		Me.lblSched.TabIndex = 3
		Me.lblSched.Text = "Schedule:"
		'
		'lblVol
		'
		Me.lblVol.AutoSize = True
		Me.lblVol.Location = New System.Drawing.Point(32, 35)
		Me.lblVol.Name = "lblVol"
		Me.lblVol.Size = New System.Drawing.Size(81, 18)
		Me.lblVol.TabIndex = 2
		Me.lblVol.Text = "Volunteer: "
		'
		'cboVol
		'
		Me.cboVol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboVol.FormattingEnabled = True
		Me.cboVol.Location = New System.Drawing.Point(119, 27)
		Me.cboVol.Name = "cboVol"
		Me.cboVol.Size = New System.Drawing.Size(263, 26)
		Me.cboVol.TabIndex = 0
		'
		'cboSched
		'
		Me.cboSched.FormattingEnabled = True
		Me.cboSched.Location = New System.Drawing.Point(119, 70)
		Me.cboSched.Name = "cboSched"
		Me.cboSched.Size = New System.Drawing.Size(263, 26)
		Me.cboSched.TabIndex = 1
		'
		'tabClosing
		'
		Me.tabClosing.Controls.Add(Me.grpClosing)
		Me.tabClosing.Location = New System.Drawing.Point(4, 27)
		Me.tabClosing.Name = "tabClosing"
		Me.tabClosing.Padding = New System.Windows.Forms.Padding(3)
		Me.tabClosing.Size = New System.Drawing.Size(808, 644)
		Me.tabClosing.TabIndex = 2
		Me.tabClosing.Text = "Closings"
		Me.tabClosing.UseVisualStyleBackColor = True
		'
		'grpClosing
		'
		Me.grpClosing.Controls.Add(Me.btnCloseRemove)
		Me.grpClosing.Controls.Add(Me.btnCloseEdit)
		Me.grpClosing.Controls.Add(Me.btnCloseAdd)
		Me.grpClosing.Controls.Add(Me.lvwSubstitute1)
		Me.grpClosing.Controls.Add(Me.chkEmergency)
		Me.grpClosing.Controls.Add(Me.lblEndDate)
		Me.grpClosing.Controls.Add(Me.lbStartDate)
		Me.grpClosing.Controls.Add(Me.dtpCloseEnd)
		Me.grpClosing.Controls.Add(Me.DateTimePicker1)
		Me.grpClosing.Location = New System.Drawing.Point(43, 39)
		Me.grpClosing.Name = "grpClosing"
		Me.grpClosing.Size = New System.Drawing.Size(697, 459)
		Me.grpClosing.TabIndex = 0
		Me.grpClosing.TabStop = False
		Me.grpClosing.Text = "Enter Closings"
		'
		'btnCloseRemove
		'
		Me.btnCloseRemove.Location = New System.Drawing.Point(460, 119)
		Me.btnCloseRemove.Name = "btnCloseRemove"
		Me.btnCloseRemove.Size = New System.Drawing.Size(161, 31)
		Me.btnCloseRemove.TabIndex = 8
		Me.btnCloseRemove.Text = "Remove Closing"
		Me.btnCloseRemove.UseVisualStyleBackColor = True
		'
		'btnCloseEdit
		'
		Me.btnCloseEdit.Location = New System.Drawing.Point(257, 119)
		Me.btnCloseEdit.Name = "btnCloseEdit"
		Me.btnCloseEdit.Size = New System.Drawing.Size(161, 31)
		Me.btnCloseEdit.TabIndex = 7
		Me.btnCloseEdit.Text = "Edit Closing"
		Me.btnCloseEdit.UseVisualStyleBackColor = True
		'
		'btnCloseAdd
		'
		Me.btnCloseAdd.Location = New System.Drawing.Point(57, 119)
		Me.btnCloseAdd.Name = "btnCloseAdd"
		Me.btnCloseAdd.Size = New System.Drawing.Size(161, 31)
		Me.btnCloseAdd.TabIndex = 6
		Me.btnCloseAdd.Text = "Add Closing"
		Me.btnCloseAdd.UseVisualStyleBackColor = True
		'
		'lvwSubstitute1
		'
		Me.lvwSubstitute1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CloseStart, Me.CloseEnd, Me.CloseEmergency, Me.CloseDescription})
		Me.lvwSubstitute1.GridLines = True
		Me.lvwSubstitute1.HideSelection = False
		Me.lvwSubstitute1.Location = New System.Drawing.Point(23, 179)
		Me.lvwSubstitute1.Name = "lvwSubstitute1"
		Me.lvwSubstitute1.Size = New System.Drawing.Size(636, 255)
		Me.lvwSubstitute1.TabIndex = 5
		Me.lvwSubstitute1.UseCompatibleStateImageBehavior = False
		Me.lvwSubstitute1.View = System.Windows.Forms.View.Details
		'
		'CloseStart
		'
		Me.CloseStart.Text = "Start Date"
		Me.CloseStart.Width = 120
		'
		'CloseEnd
		'
		Me.CloseEnd.Text = "End Date"
		Me.CloseEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.CloseEnd.Width = 120
		'
		'CloseEmergency
		'
		Me.CloseEmergency.Text = "Emergency"
		Me.CloseEmergency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.CloseEmergency.Width = 131
		'
		'CloseDescription
		'
		Me.CloseDescription.Text = "Description"
		Me.CloseDescription.Width = 255
		'
		'chkEmergency
		'
		Me.chkEmergency.AutoSize = True
		Me.chkEmergency.Location = New System.Drawing.Point(370, 33)
		Me.chkEmergency.Name = "chkEmergency"
		Me.chkEmergency.Size = New System.Drawing.Size(130, 22)
		Me.chkEmergency.TabIndex = 4
		Me.chkEmergency.Text = "Is Emergency?"
		Me.chkEmergency.UseVisualStyleBackColor = True
		'
		'lblEndDate
		'
		Me.lblEndDate.AutoSize = True
		Me.lblEndDate.Location = New System.Drawing.Point(25, 85)
		Me.lblEndDate.Name = "lblEndDate"
		Me.lblEndDate.Size = New System.Drawing.Size(78, 18)
		Me.lblEndDate.TabIndex = 3
		Me.lblEndDate.Text = "End Date:"
		'
		'lbStartDate
		'
		Me.lbStartDate.AutoSize = True
		Me.lbStartDate.Location = New System.Drawing.Point(20, 37)
		Me.lbStartDate.Name = "lbStartDate"
		Me.lbStartDate.Size = New System.Drawing.Size(83, 18)
		Me.lbStartDate.TabIndex = 2
		Me.lbStartDate.Text = "Start Date:"
		'
		'dtpCloseEnd
		'
		Me.dtpCloseEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpCloseEnd.Location = New System.Drawing.Point(125, 77)
		Me.dtpCloseEnd.Name = "dtpCloseEnd"
		Me.dtpCloseEnd.Size = New System.Drawing.Size(128, 26)
		Me.dtpCloseEnd.TabIndex = 1
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker1.Location = New System.Drawing.Point(125, 29)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(128, 26)
		Me.DateTimePicker1.TabIndex = 0
		'
		'tabCalendar
		'
		Me.tabCalendar.Location = New System.Drawing.Point(4, 27)
		Me.tabCalendar.Name = "tabCalendar"
		Me.tabCalendar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCalendar.Size = New System.Drawing.Size(808, 644)
		Me.tabCalendar.TabIndex = 3
		Me.tabCalendar.Text = "Calendar View"
		Me.tabCalendar.UseVisualStyleBackColor = True
		'
		'tabReport
		'
		Me.tabReport.Location = New System.Drawing.Point(4, 27)
		Me.tabReport.Name = "tabReport"
		Me.tabReport.Padding = New System.Windows.Forms.Padding(3)
		Me.tabReport.Size = New System.Drawing.Size(808, 644)
		Me.tabReport.TabIndex = 4
		Me.tabReport.Text = "Reports"
		Me.tabReport.UseVisualStyleBackColor = True
		'
		'FrmVolunteer
		'
		Me.ClientSize = New System.Drawing.Size(844, 708)
		Me.Controls.Add(Me.tabManagment)
		Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Name = "FrmVolunteer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Schedule Management System"
		Me.tabManagment.ResumeLayout(False)
		Me.tabSchedule.ResumeLayout(False)
		Me.grpSchedule.ResumeLayout(False)
		Me.grpSchedule.PerformLayout()
		Me.tabVolunteer.ResumeLayout(False)
		Me.grpSubstitute.ResumeLayout(False)
		Me.grpSubstitute.PerformLayout()
		Me.grpVolunteer.ResumeLayout(False)
		Me.grpVolunteer.PerformLayout()
		Me.tabClosing.ResumeLayout(False)
		Me.grpClosing.ResumeLayout(False)
		Me.grpClosing.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents tabManagment As TabControl
    Friend WithEvents tabSchedule As TabPage
    Friend WithEvents tabVolunteer As TabPage
    Friend WithEvents tabClosing As TabPage
    Friend WithEvents tabCalendar As TabPage
    Friend WithEvents tabReport As TabPage
    Friend WithEvents grpSchedule As GroupBox
    Friend WithEvents lblDay As Label
    Friend WithEvents cboSchedDay As ComboBox
    Friend WithEvents lblStart As Label
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents lblEnd As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents btnSchedAdd As Button
    Friend WithEvents btnSchedRemove As Button
    Friend WithEvents btnSchedEdit As Button
    Friend WithEvents lvwSchedule As ListView
    Friend WithEvents SchedDay As ColumnHeader
    Friend WithEvents SchedStart As ColumnHeader
    Friend WithEvents SchedEnd As ColumnHeader
    Friend WithEvents SchedStatus As ColumnHeader
    Friend WithEvents grpSubstitute As GroupBox
    Friend WithEvents grpVolunteer As GroupBox
    Friend WithEvents lblSched As Label
    Friend WithEvents cboSched As ComboBox
    Friend WithEvents lblVol As Label
    Friend WithEvents cboVol As ComboBox
    Friend WithEvents lvwVolunteer As ListView
    Friend WithEvents VolDay As ColumnHeader
    Friend WithEvents VolStart As ColumnHeader
    Friend WithEvents VolEnd As ColumnHeader
    Friend WithEvents VolStatus As ColumnHeader
    Friend WithEvents btnVolAdd As Button
    Friend WithEvents btnVolRemove As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lvwSubstitute As ListView
    Friend WithEvents SubVol As ColumnHeader
    Friend WithEvents SubSub As ColumnHeader
    Friend WithEvents SubDay As ColumnHeader
    Friend WithEvents SubStart As ColumnHeader
    Friend WithEvents lblSubSched As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents cboSub As ComboBox
    Friend WithEvents cboSubSched As ComboBox
    Friend WithEvents SubEnd As ColumnHeader
    Friend WithEvents SubStatus As ColumnHeader
    Friend WithEvents grpClosing As GroupBox
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lbStartDate As Label
    Friend WithEvents dtpCloseEnd As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents chkEmergency As CheckBox
    Friend WithEvents lvwSubstitute1 As ListView
    Friend WithEvents CloseStart As ColumnHeader
    Friend WithEvents CloseEnd As ColumnHeader
    Friend WithEvents CloseEmergency As ColumnHeader
    Friend WithEvents CloseDescription As ColumnHeader
    Friend WithEvents btnCloseRemove As Button
    Friend WithEvents btnCloseEdit As Button
    Friend WithEvents btnCloseAdd As Button
End Class