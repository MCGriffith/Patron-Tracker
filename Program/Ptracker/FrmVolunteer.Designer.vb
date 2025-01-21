<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVolunteer
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
        Me.tabScheduleManagement = New System.Windows.Forms.TabControl()
        Me.tabSchedule = New System.Windows.Forms.TabPage()
        Me.grpSchedule = New System.Windows.Forms.GroupBox()
        Me.btnSchedRemove = New System.Windows.Forms.Button()
        Me.btnSchedEdit = New System.Windows.Forms.Button()
        Me.btnSchedAdd = New System.Windows.Forms.Button()
        Me.lvwSchedule = New System.Windows.Forms.ListView()
        Me.SchedDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SchedStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SchedEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SchedStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblSelectDay = New System.Windows.Forms.Label()
        Me.cboSchedDay = New System.Windows.Forms.ComboBox()
        Me.tabVolunteer = New System.Windows.Forms.TabPage()
        Me.grpSubstitute = New System.Windows.Forms.GroupBox()
        Me.btnSubRemove = New System.Windows.Forms.Button()
        Me.btnSubAdd = New System.Windows.Forms.Button()
        Me.lvwSubstitute = New System.Windows.Forms.ListView()
        Me.SubDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubVol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubSub = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboSubSched = New System.Windows.Forms.ComboBox()
        Me.lblSubSched = New System.Windows.Forms.Label()
        Me.cboSub = New System.Windows.Forms.ComboBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.grpVolunteer = New System.Windows.Forms.GroupBox()
        Me.btnVolRemove = New System.Windows.Forms.Button()
        Me.btnVolAdd = New System.Windows.Forms.Button()
        Me.lvwVolunteer = New System.Windows.Forms.ListView()
        Me.VolDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VolStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VolEndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VolStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboSched = New System.Windows.Forms.ComboBox()
        Me.lblVolSched = New System.Windows.Forms.Label()
        Me.cboVol = New System.Windows.Forms.ComboBox()
        Me.lblVolunteer = New System.Windows.Forms.Label()
        Me.tabClosing = New System.Windows.Forms.TabPage()
        Me.grpClosing = New System.Windows.Forms.GroupBox()
        Me.lvwClosing = New System.Windows.Forms.ListView()
        Me.CloseStart = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseEnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseEmergency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCloseRemove = New System.Windows.Forms.Button()
        Me.btnCloseEdit = New System.Windows.Forms.Button()
        Me.btnCloseAdd = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.chkEmergency = New System.Windows.Forms.CheckBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblCloseEnd = New System.Windows.Forms.Label()
        Me.dtpCloseEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblCloseStart = New System.Windows.Forms.Label()
        Me.dtpCloseStart = New System.Windows.Forms.DateTimePicker()
        Me.tabCalendar = New System.Windows.Forms.TabPage()
        Me.tabReport = New System.Windows.Forms.TabPage()
        Me.tabScheduleManagement.SuspendLayout()
        Me.tabSchedule.SuspendLayout()
        Me.grpSchedule.SuspendLayout()
        Me.tabVolunteer.SuspendLayout()
        Me.grpSubstitute.SuspendLayout()
        Me.grpVolunteer.SuspendLayout()
        Me.tabClosing.SuspendLayout()
        Me.grpClosing.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabScheduleManagement
        '
        Me.tabScheduleManagement.Controls.Add(Me.tabSchedule)
        Me.tabScheduleManagement.Controls.Add(Me.tabVolunteer)
        Me.tabScheduleManagement.Controls.Add(Me.tabClosing)
        Me.tabScheduleManagement.Controls.Add(Me.tabCalendar)
        Me.tabScheduleManagement.Controls.Add(Me.tabReport)
        Me.tabScheduleManagement.Location = New System.Drawing.Point(12, 39)
        Me.tabScheduleManagement.Name = "tabScheduleManagement"
        Me.tabScheduleManagement.SelectedIndex = 0
        Me.tabScheduleManagement.Size = New System.Drawing.Size(820, 525)
        Me.tabScheduleManagement.TabIndex = 0
        '
        'tabSchedule
        '
        Me.tabSchedule.Controls.Add(Me.grpSchedule)
        Me.tabSchedule.Location = New System.Drawing.Point(4, 27)
        Me.tabSchedule.Name = "tabSchedule"
        Me.tabSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSchedule.Size = New System.Drawing.Size(812, 494)
        Me.tabSchedule.TabIndex = 0
        Me.tabSchedule.Text = "Scheduleing"
        Me.tabSchedule.UseVisualStyleBackColor = True
        '
        'grpSchedule
        '
        Me.grpSchedule.Controls.Add(Me.btnSchedRemove)
        Me.grpSchedule.Controls.Add(Me.btnSchedEdit)
        Me.grpSchedule.Controls.Add(Me.btnSchedAdd)
        Me.grpSchedule.Controls.Add(Me.lvwSchedule)
        Me.grpSchedule.Controls.Add(Me.dtpEndTime)
        Me.grpSchedule.Controls.Add(Me.lblEnd)
        Me.grpSchedule.Controls.Add(Me.dtpStartTime)
        Me.grpSchedule.Controls.Add(Me.lblStart)
        Me.grpSchedule.Controls.Add(Me.lblSelectDay)
        Me.grpSchedule.Controls.Add(Me.cboSchedDay)
        Me.grpSchedule.Location = New System.Drawing.Point(20, 19)
        Me.grpSchedule.Name = "grpSchedule"
        Me.grpSchedule.Size = New System.Drawing.Size(770, 452)
        Me.grpSchedule.TabIndex = 0
        Me.grpSchedule.TabStop = False
        Me.grpSchedule.Text = "Build Schedules"
        '
        'btnSchedRemove
        '
        Me.btnSchedRemove.Location = New System.Drawing.Point(610, 97)
        Me.btnSchedRemove.Name = "btnSchedRemove"
        Me.btnSchedRemove.Size = New System.Drawing.Size(112, 34)
        Me.btnSchedRemove.TabIndex = 9
        Me.btnSchedRemove.Text = "Remove"
        Me.btnSchedRemove.UseVisualStyleBackColor = True
        '
        'btnSchedEdit
        '
        Me.btnSchedEdit.Location = New System.Drawing.Point(463, 97)
        Me.btnSchedEdit.Name = "btnSchedEdit"
        Me.btnSchedEdit.Size = New System.Drawing.Size(112, 34)
        Me.btnSchedEdit.TabIndex = 8
        Me.btnSchedEdit.Text = "Edit"
        Me.btnSchedEdit.UseVisualStyleBackColor = True
        '
        'btnSchedAdd
        '
        Me.btnSchedAdd.Location = New System.Drawing.Point(328, 97)
        Me.btnSchedAdd.Name = "btnSchedAdd"
        Me.btnSchedAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnSchedAdd.TabIndex = 7
        Me.btnSchedAdd.Text = "Add"
        Me.btnSchedAdd.UseVisualStyleBackColor = True
        '
        'lvwSchedule
        '
        Me.lvwSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SchedDay, Me.SchedStart, Me.SchedEnd, Me.SchedStatus})
        Me.lvwSchedule.GridLines = True
        Me.lvwSchedule.HideSelection = False
        Me.lvwSchedule.Location = New System.Drawing.Point(6, 153)
        Me.lvwSchedule.Name = "lvwSchedule"
        Me.lvwSchedule.Size = New System.Drawing.Size(758, 293)
        Me.lvwSchedule.TabIndex = 6
        Me.lvwSchedule.UseCompatibleStateImageBehavior = False
        Me.lvwSchedule.View = System.Windows.Forms.View.Details
        '
        'SchedDay
        '
        Me.SchedDay.Text = "Schedule Day"
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
        Me.SchedStatus.Width = 70
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "HH:mm"
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndTime.Location = New System.Drawing.Point(125, 107)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(168, 26)
        Me.dtpEndTime.TabIndex = 5
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Location = New System.Drawing.Point(30, 113)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(88, 18)
        Me.lblEnd.TabIndex = 4
        Me.lblEnd.Text = "Select End:"
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CustomFormat = "HH:mm"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTime.Location = New System.Drawing.Point(125, 65)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(168, 26)
        Me.dtpStartTime.TabIndex = 3
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(26, 73)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(93, 18)
        Me.lblStart.TabIndex = 2
        Me.lblStart.Text = "Select Start:"
        '
        'lblSelectDay
        '
        Me.lblSelectDay.AutoSize = True
        Me.lblSelectDay.Location = New System.Drawing.Point(26, 33)
        Me.lblSelectDay.Name = "lblSelectDay"
        Me.lblSelectDay.Size = New System.Drawing.Size(92, 18)
        Me.lblSelectDay.TabIndex = 1
        Me.lblSelectDay.Text = "Select Day: "
        '
        'cboSchedDay
        '
        Me.cboSchedDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSchedDay.FormattingEnabled = True
        Me.cboSchedDay.Location = New System.Drawing.Point(124, 25)
        Me.cboSchedDay.Name = "cboSchedDay"
        Me.cboSchedDay.Size = New System.Drawing.Size(169, 26)
        Me.cboSchedDay.TabIndex = 0
        '
        'tabVolunteer
        '
        Me.tabVolunteer.Controls.Add(Me.grpSubstitute)
        Me.tabVolunteer.Controls.Add(Me.grpVolunteer)
        Me.tabVolunteer.Location = New System.Drawing.Point(4, 27)
        Me.tabVolunteer.Name = "tabVolunteer"
        Me.tabVolunteer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVolunteer.Size = New System.Drawing.Size(812, 494)
        Me.tabVolunteer.TabIndex = 1
        Me.tabVolunteer.Text = "Volunteerss & Substitutes"
        Me.tabVolunteer.UseVisualStyleBackColor = True
        '
        'grpSubstitute
        '
        Me.grpSubstitute.Controls.Add(Me.btnSubRemove)
        Me.grpSubstitute.Controls.Add(Me.btnSubAdd)
        Me.grpSubstitute.Controls.Add(Me.lvwSubstitute)
        Me.grpSubstitute.Controls.Add(Me.cboSubSched)
        Me.grpSubstitute.Controls.Add(Me.lblSubSched)
        Me.grpSubstitute.Controls.Add(Me.cboSub)
        Me.grpSubstitute.Controls.Add(Me.lblSub)
        Me.grpSubstitute.Location = New System.Drawing.Point(15, 247)
        Me.grpSubstitute.Name = "grpSubstitute"
        Me.grpSubstitute.Size = New System.Drawing.Size(767, 244)
        Me.grpSubstitute.TabIndex = 1
        Me.grpSubstitute.TabStop = False
        Me.grpSubstitute.Text = "Assign Substitutes"
        '
        'btnSubRemove
        '
        Me.btnSubRemove.Location = New System.Drawing.Point(485, 63)
        Me.btnSubRemove.Name = "btnSubRemove"
        Me.btnSubRemove.Size = New System.Drawing.Size(142, 33)
        Me.btnSubRemove.TabIndex = 11
        Me.btnSubRemove.Text = "Remove"
        Me.btnSubRemove.UseVisualStyleBackColor = True
        '
        'btnSubAdd
        '
        Me.btnSubAdd.Location = New System.Drawing.Point(485, 23)
        Me.btnSubAdd.Name = "btnSubAdd"
        Me.btnSubAdd.Size = New System.Drawing.Size(142, 33)
        Me.btnSubAdd.TabIndex = 10
        Me.btnSubAdd.Text = "Add"
        Me.btnSubAdd.UseVisualStyleBackColor = True
        '
        'lvwSubstitute
        '
        Me.lvwSubstitute.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SubDay, Me.SubStart, Me.SubEnd, Me.SubStatus, Me.SubVol, Me.SubSub})
        Me.lvwSubstitute.GridLines = True
        Me.lvwSubstitute.HideSelection = False
        Me.lvwSubstitute.Location = New System.Drawing.Point(6, 112)
        Me.lvwSubstitute.Name = "lvwSubstitute"
        Me.lvwSubstitute.Size = New System.Drawing.Size(755, 126)
        Me.lvwSubstitute.TabIndex = 9
        Me.lvwSubstitute.UseCompatibleStateImageBehavior = False
        Me.lvwSubstitute.View = System.Windows.Forms.View.Details
        '
        'SubDay
        '
        Me.SubDay.DisplayIndex = 2
        Me.SubDay.Text = "Day Of Week"
        Me.SubDay.Width = 120
        '
        'SubStart
        '
        Me.SubStart.DisplayIndex = 3
        Me.SubStart.Text = "Start Time"
        Me.SubStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubStart.Width = 120
        '
        'SubEnd
        '
        Me.SubEnd.DisplayIndex = 4
        Me.SubEnd.Text = "End Time"
        Me.SubEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubEnd.Width = 120
        '
        'SubStatus
        '
        Me.SubStatus.DisplayIndex = 5
        Me.SubStatus.Text = "Status"
        Me.SubStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubStatus.Width = 100
        '
        'SubVol
        '
        Me.SubVol.DisplayIndex = 0
        Me.SubVol.Text = "Original Volunteer"
        Me.SubVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubVol.Width = 150
        '
        'SubSub
        '
        Me.SubSub.DisplayIndex = 1
        Me.SubSub.Text = "Substitute"
        Me.SubSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubSub.Width = 136
        '
        'cboSubSched
        '
        Me.cboSubSched.FormattingEnabled = True
        Me.cboSubSched.Location = New System.Drawing.Point(166, 66)
        Me.cboSubSched.Name = "cboSubSched"
        Me.cboSubSched.Size = New System.Drawing.Size(250, 26)
        Me.cboSubSched.TabIndex = 8
        '
        'lblSubSched
        '
        Me.lblSubSched.AutoSize = True
        Me.lblSubSched.Location = New System.Drawing.Point(31, 69)
        Me.lblSubSched.Name = "lblSubSched"
        Me.lblSubSched.Size = New System.Drawing.Size(129, 18)
        Me.lblSubSched.TabIndex = 7
        Me.lblSubSched.Text = "Select Schedule: "
        '
        'cboSub
        '
        Me.cboSub.FormattingEnabled = True
        Me.cboSub.Location = New System.Drawing.Point(166, 30)
        Me.cboSub.Name = "cboSub"
        Me.cboSub.Size = New System.Drawing.Size(250, 26)
        Me.cboSub.TabIndex = 6
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(31, 33)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(133, 18)
        Me.lblSub.TabIndex = 5
        Me.lblSub.Text = "Select Substitute: "
        '
        'grpVolunteer
        '
        Me.grpVolunteer.Controls.Add(Me.btnVolRemove)
        Me.grpVolunteer.Controls.Add(Me.btnVolAdd)
        Me.grpVolunteer.Controls.Add(Me.lvwVolunteer)
        Me.grpVolunteer.Controls.Add(Me.cboSched)
        Me.grpVolunteer.Controls.Add(Me.lblVolSched)
        Me.grpVolunteer.Controls.Add(Me.cboVol)
        Me.grpVolunteer.Controls.Add(Me.lblVolunteer)
        Me.grpVolunteer.Location = New System.Drawing.Point(15, 18)
        Me.grpVolunteer.Name = "grpVolunteer"
        Me.grpVolunteer.Size = New System.Drawing.Size(767, 230)
        Me.grpVolunteer.TabIndex = 0
        Me.grpVolunteer.TabStop = False
        Me.grpVolunteer.Text = "Assign Volunteers"
        '
        'btnVolRemove
        '
        Me.btnVolRemove.Location = New System.Drawing.Point(485, 68)
        Me.btnVolRemove.Name = "btnVolRemove"
        Me.btnVolRemove.Size = New System.Drawing.Size(142, 33)
        Me.btnVolRemove.TabIndex = 6
        Me.btnVolRemove.Text = "Remove"
        Me.btnVolRemove.UseVisualStyleBackColor = True
        '
        'btnVolAdd
        '
        Me.btnVolAdd.Location = New System.Drawing.Point(485, 28)
        Me.btnVolAdd.Name = "btnVolAdd"
        Me.btnVolAdd.Size = New System.Drawing.Size(142, 33)
        Me.btnVolAdd.TabIndex = 5
        Me.btnVolAdd.Text = "Add"
        Me.btnVolAdd.UseVisualStyleBackColor = True
        '
        'lvwVolunteer
        '
        Me.lvwVolunteer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.VolDay, Me.VolStartTime, Me.VolEndTime, Me.VolStatus})
        Me.lvwVolunteer.GridLines = True
        Me.lvwVolunteer.HideSelection = False
        Me.lvwVolunteer.Location = New System.Drawing.Point(6, 114)
        Me.lvwVolunteer.Name = "lvwVolunteer"
        Me.lvwVolunteer.Size = New System.Drawing.Size(755, 109)
        Me.lvwVolunteer.TabIndex = 4
        Me.lvwVolunteer.UseCompatibleStateImageBehavior = False
        Me.lvwVolunteer.View = System.Windows.Forms.View.Details
        '
        'VolDay
        '
        Me.VolDay.Text = "Day Of Week"
        Me.VolDay.Width = 120
        '
        'VolStartTime
        '
        Me.VolStartTime.Text = "Start Time"
        Me.VolStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.VolStartTime.Width = 120
        '
        'VolEndTime
        '
        Me.VolEndTime.Text = "End Time"
        Me.VolEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.VolEndTime.Width = 120
        '
        'VolStatus
        '
        Me.VolStatus.Text = "Status"
        Me.VolStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.VolStatus.Width = 100
        '
        'cboSched
        '
        Me.cboSched.FormattingEnabled = True
        Me.cboSched.Location = New System.Drawing.Point(166, 68)
        Me.cboSched.Name = "cboSched"
        Me.cboSched.Size = New System.Drawing.Size(250, 26)
        Me.cboSched.TabIndex = 3
        '
        'lblVolSched
        '
        Me.lblVolSched.AutoSize = True
        Me.lblVolSched.Location = New System.Drawing.Point(31, 71)
        Me.lblVolSched.Name = "lblVolSched"
        Me.lblVolSched.Size = New System.Drawing.Size(129, 18)
        Me.lblVolSched.TabIndex = 2
        Me.lblVolSched.Text = "Select Schedule: "
        '
        'cboVol
        '
        Me.cboVol.FormattingEnabled = True
        Me.cboVol.Location = New System.Drawing.Point(166, 32)
        Me.cboVol.Name = "cboVol"
        Me.cboVol.Size = New System.Drawing.Size(250, 26)
        Me.cboVol.TabIndex = 1
        '
        'lblVolunteer
        '
        Me.lblVolunteer.AutoSize = True
        Me.lblVolunteer.Location = New System.Drawing.Point(31, 35)
        Me.lblVolunteer.Name = "lblVolunteer"
        Me.lblVolunteer.Size = New System.Drawing.Size(129, 18)
        Me.lblVolunteer.TabIndex = 0
        Me.lblVolunteer.Text = "Select Volunteer: "
        '
        'tabClosing
        '
        Me.tabClosing.Controls.Add(Me.grpClosing)
        Me.tabClosing.Location = New System.Drawing.Point(4, 27)
        Me.tabClosing.Name = "tabClosing"
        Me.tabClosing.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClosing.Size = New System.Drawing.Size(812, 494)
        Me.tabClosing.TabIndex = 2
        Me.tabClosing.Text = "Closings"
        Me.tabClosing.UseVisualStyleBackColor = True
        '
        'grpClosing
        '
        Me.grpClosing.Controls.Add(Me.lvwClosing)
        Me.grpClosing.Controls.Add(Me.btnCloseRemove)
        Me.grpClosing.Controls.Add(Me.btnCloseEdit)
        Me.grpClosing.Controls.Add(Me.btnCloseAdd)
        Me.grpClosing.Controls.Add(Me.cboType)
        Me.grpClosing.Controls.Add(Me.chkEmergency)
        Me.grpClosing.Controls.Add(Me.lblType)
        Me.grpClosing.Controls.Add(Me.lblCloseEnd)
        Me.grpClosing.Controls.Add(Me.dtpCloseEnd)
        Me.grpClosing.Controls.Add(Me.lblCloseStart)
        Me.grpClosing.Controls.Add(Me.dtpCloseStart)
        Me.grpClosing.Location = New System.Drawing.Point(23, 21)
        Me.grpClosing.Name = "grpClosing"
        Me.grpClosing.Size = New System.Drawing.Size(769, 450)
        Me.grpClosing.TabIndex = 0
        Me.grpClosing.TabStop = False
        Me.grpClosing.Text = "Record Closing"
        '
        'lvwClosing
        '
        Me.lvwClosing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CloseStart, Me.CloseEnd, Me.CloseType, Me.CloseEmergency, Me.CloseDescription})
        Me.lvwClosing.GridLines = True
        Me.lvwClosing.HideSelection = False
        Me.lvwClosing.Location = New System.Drawing.Point(18, 184)
        Me.lvwClosing.Name = "lvwClosing"
        Me.lvwClosing.Size = New System.Drawing.Size(725, 260)
        Me.lvwClosing.TabIndex = 13
        Me.lvwClosing.UseCompatibleStateImageBehavior = False
        Me.lvwClosing.View = System.Windows.Forms.View.Details
        '
        'CloseStart
        '
        Me.CloseStart.DisplayIndex = 1
        Me.CloseStart.Text = "Start Date"
        Me.CloseStart.Width = 120
        '
        'CloseEnd
        '
        Me.CloseEnd.DisplayIndex = 2
        Me.CloseEnd.Text = "End Date"
        Me.CloseEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseEnd.Width = 120
        '
        'CloseType
        '
        Me.CloseType.DisplayIndex = 0
        Me.CloseType.Text = "Type"
        Me.CloseType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseType.Width = 120
        '
        'CloseEmergency
        '
        Me.CloseEmergency.Text = "Is Emergency"
        Me.CloseEmergency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseEmergency.Width = 147
        '
        'CloseDescription
        '
        Me.CloseDescription.Text = "Description"
        Me.CloseDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseDescription.Width = 210
        '
        'btnCloseRemove
        '
        Me.btnCloseRemove.Location = New System.Drawing.Point(434, 129)
        Me.btnCloseRemove.Name = "btnCloseRemove"
        Me.btnCloseRemove.Size = New System.Drawing.Size(112, 34)
        Me.btnCloseRemove.TabIndex = 12
        Me.btnCloseRemove.Text = "Remove"
        Me.btnCloseRemove.UseVisualStyleBackColor = True
        '
        'btnCloseEdit
        '
        Me.btnCloseEdit.Location = New System.Drawing.Point(274, 129)
        Me.btnCloseEdit.Name = "btnCloseEdit"
        Me.btnCloseEdit.Size = New System.Drawing.Size(112, 34)
        Me.btnCloseEdit.TabIndex = 11
        Me.btnCloseEdit.Text = "Edit"
        Me.btnCloseEdit.UseVisualStyleBackColor = True
        '
        'btnCloseAdd
        '
        Me.btnCloseAdd.Location = New System.Drawing.Point(114, 129)
        Me.btnCloseAdd.Name = "btnCloseAdd"
        Me.btnCloseAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnCloseAdd.TabIndex = 10
        Me.btnCloseAdd.Text = "Add"
        Me.btnCloseAdd.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Holiday", "Maintenance", "Weather", "Other"})
        Me.cboType.Location = New System.Drawing.Point(425, 47)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 26)
        Me.cboType.TabIndex = 6
        '
        'chkEmergency
        '
        Me.chkEmergency.AutoSize = True
        Me.chkEmergency.Location = New System.Drawing.Point(425, 93)
        Me.chkEmergency.Name = "chkEmergency"
        Me.chkEmergency.Size = New System.Drawing.Size(151, 22)
        Me.chkEmergency.TabIndex = 5
        Me.chkEmergency.Text = "Is an Emergency?"
        Me.chkEmergency.UseVisualStyleBackColor = True
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(317, 55)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(102, 18)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Closing Type:"
        '
        'lblCloseEnd
        '
        Me.lblCloseEnd.AutoSize = True
        Me.lblCloseEnd.Location = New System.Drawing.Point(29, 93)
        Me.lblCloseEnd.Name = "lblCloseEnd"
        Me.lblCloseEnd.Size = New System.Drawing.Size(78, 18)
        Me.lblCloseEnd.TabIndex = 3
        Me.lblCloseEnd.Text = "End Date:"
        '
        'dtpCloseEnd
        '
        Me.dtpCloseEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCloseEnd.Location = New System.Drawing.Point(118, 85)
        Me.dtpCloseEnd.Name = "dtpCloseEnd"
        Me.dtpCloseEnd.Size = New System.Drawing.Size(130, 26)
        Me.dtpCloseEnd.TabIndex = 2
        '
        'lblCloseStart
        '
        Me.lblCloseStart.AutoSize = True
        Me.lblCloseStart.Location = New System.Drawing.Point(25, 55)
        Me.lblCloseStart.Name = "lblCloseStart"
        Me.lblCloseStart.Size = New System.Drawing.Size(83, 18)
        Me.lblCloseStart.TabIndex = 1
        Me.lblCloseStart.Text = "Start Date:"
        '
        'dtpCloseStart
        '
        Me.dtpCloseStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCloseStart.Location = New System.Drawing.Point(114, 47)
        Me.dtpCloseStart.Name = "dtpCloseStart"
        Me.dtpCloseStart.Size = New System.Drawing.Size(130, 26)
        Me.dtpCloseStart.TabIndex = 0
        '
        'tabCalendar
        '
        Me.tabCalendar.Location = New System.Drawing.Point(4, 27)
        Me.tabCalendar.Name = "tabCalendar"
        Me.tabCalendar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalendar.Size = New System.Drawing.Size(812, 494)
        Me.tabCalendar.TabIndex = 3
        Me.tabCalendar.Text = "Calendar"
        Me.tabCalendar.UseVisualStyleBackColor = True
        '
        'tabReport
        '
        Me.tabReport.Location = New System.Drawing.Point(4, 27)
        Me.tabReport.Name = "tabReport"
        Me.tabReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReport.Size = New System.Drawing.Size(812, 494)
        Me.tabReport.TabIndex = 4
        Me.tabReport.Text = "Reporting"
        Me.tabReport.UseVisualStyleBackColor = True
        '
        'FrmVolunteer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 576)
        Me.Controls.Add(Me.tabScheduleManagement)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVolunteer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule Management System"
        Me.tabScheduleManagement.ResumeLayout(False)
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

    Friend WithEvents tabScheduleManagement As TabControl
    Friend WithEvents tabSchedule As TabPage
    Friend WithEvents tabVolunteer As TabPage
    Friend WithEvents tabClosing As TabPage
    Friend WithEvents tabCalendar As TabPage
    Friend WithEvents grpSchedule As GroupBox
    Friend WithEvents tabReport As TabPage
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents lblStart As Label
    Friend WithEvents lblSelectDay As Label
    Friend WithEvents cboSchedDay As ComboBox
    Friend WithEvents lvwSchedule As ListView
    Friend WithEvents SchedDay As ColumnHeader
    Friend WithEvents SchedStart As ColumnHeader
    Friend WithEvents SchedEnd As ColumnHeader
    Friend WithEvents SchedStatus As ColumnHeader
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents lblEnd As Label
    Friend WithEvents btnSchedAdd As Button
    Friend WithEvents btnSchedRemove As Button
    Friend WithEvents btnSchedEdit As Button
    Friend WithEvents grpVolunteer As GroupBox
    Friend WithEvents grpSubstitute As GroupBox
    Friend WithEvents cboSched As ComboBox
    Friend WithEvents lblVolSched As Label
    Friend WithEvents cboVol As ComboBox
    Friend WithEvents lblVolunteer As Label
    Friend WithEvents lvwVolunteer As ListView
    Friend WithEvents VolDay As ColumnHeader
    Friend WithEvents VolStartTime As ColumnHeader
    Friend WithEvents VolEndTime As ColumnHeader
    Friend WithEvents VolStatus As ColumnHeader
    Friend WithEvents lvwSubstitute As ListView
    Friend WithEvents SubDay As ColumnHeader
    Friend WithEvents SubStart As ColumnHeader
    Friend WithEvents SubEnd As ColumnHeader
    Friend WithEvents SubStatus As ColumnHeader
    Friend WithEvents cboSubSched As ComboBox
    Friend WithEvents lblSubSched As Label
    Friend WithEvents cboSub As ComboBox
    Friend WithEvents lblSub As Label
    Friend WithEvents SubVol As ColumnHeader
    Friend WithEvents SubSub As ColumnHeader
    Friend WithEvents btnVolRemove As Button
    Friend WithEvents btnVolAdd As Button
    Friend WithEvents btnSubRemove As Button
    Friend WithEvents btnSubAdd As Button
    Friend WithEvents grpClosing As GroupBox
    Friend WithEvents lblCloseStart As Label
    Friend WithEvents dtpCloseStart As DateTimePicker
    Friend WithEvents chkEmergency As CheckBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblCloseEnd As Label
    Friend WithEvents dtpCloseEnd As DateTimePicker
    Friend WithEvents lvwClosing As ListView
    Friend WithEvents btnCloseRemove As Button
    Friend WithEvents btnCloseEdit As Button
    Friend WithEvents btnCloseAdd As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents CloseStart As ColumnHeader
    Friend WithEvents CloseEnd As ColumnHeader
    Friend WithEvents CloseType As ColumnHeader
    Friend WithEvents CloseEmergency As ColumnHeader
    Friend WithEvents CloseDescription As ColumnHeader
End Class
