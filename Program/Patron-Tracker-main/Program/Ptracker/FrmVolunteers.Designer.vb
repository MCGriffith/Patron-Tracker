<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVolunteers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVolunteers))
        Me.VolMgmtTabs = New System.Windows.Forms.TabControl()
        Me.tabSchedule = New System.Windows.Forms.TabPage()
        Me.lvwSchedule = New System.Windows.Forms.ListView()
        Me.DayOFWeek = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ManageSchedule = New System.Windows.Forms.GroupBox()
        Me.btnEditSchedule1 = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnDeactivate = New System.Windows.Forms.Button()
        Me.btnEditSchedule = New System.Windows.Forms.Button()
        Me.CreateSchedule = New System.Windows.Forms.GroupBox()
        Me.btnAddSchedule = New System.Windows.Forms.Button()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.cboDayOfWeek = New System.Windows.Forms.ComboBox()
        Me.tabVolunteer = New System.Windows.Forms.TabPage()
        Me.lvwSubs = New System.Windows.Forms.ListView()
        Me.OriginalVolunteer1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubstituteVolunteer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubstituteDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubstituteStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubstituteEndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubstituteStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AssignSchedule = New System.Windows.Forms.GroupBox()
        Me.btnRemoveAssignment = New System.Windows.Forms.Button()
        Me.btnAssignSchedule = New System.Windows.Forms.Button()
        Me.cboAvailableSchedule = New System.Windows.Forms.ComboBox()
        Me.lvwVolunteerSchedule = New System.Windows.Forms.ListView()
        Me.SchedDay1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SchedStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SchedEndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SchedStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SelectVolunteer = New System.Windows.Forms.GroupBox()
        Me.lblVolunteerDetails = New System.Windows.Forms.Label()
        Me.cboVolunteer = New System.Windows.Forms.ComboBox()
        Me.lblSelectVolunteer = New System.Windows.Forms.Label()
        Me.tabSubstitute = New System.Windows.Forms.TabPage()
        Me.SubstituteAssignment = New System.Windows.Forms.GroupBox()
        Me.btnRemoveSubstitute = New System.Windows.Forms.Button()
        Me.btnAssignSubstitute = New System.Windows.Forms.Button()
        Me.dtpSubDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSubDate = New System.Windows.Forms.Label()
        Me.cboSubstituteVolunteer = New System.Windows.Forms.ComboBox()
        Me.lblSubstituteVolunteer1 = New System.Windows.Forms.Label()
        Me.lblSubstituteVolunteer = New System.Windows.Forms.Label()
        Me.lvwOrgs = New System.Windows.Forms.ListView()
        Me.SubDay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubStartTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubEndTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubSubstitute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OriginalVolunteer = New System.Windows.Forms.GroupBox()
        Me.cboOriginalVolunteer = New System.Windows.Forms.ComboBox()
        Me.lblOriginalVolunteer = New System.Windows.Forms.Label()
        Me.tabClosing = New System.Windows.Forms.TabPage()
        Me.lvwClosings = New System.Windows.Forms.ListView()
        Me.CloseStartDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseEndDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseEmergency = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CloseDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonPanel = New System.Windows.Forms.GroupBox()
        Me.btnCancelEdit = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnRemoveClosing = New System.Windows.Forms.Button()
        Me.btnUpdateClosing = New System.Windows.Forms.Button()
        Me.btnAddClosing1 = New System.Windows.Forms.Button()
        Me.btnAddClosing = New System.Windows.Forms.Button()
        Me.ClosingDetails = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.chkEmergency = New System.Windows.Forms.CheckBox()
        Me.cboClosingType = New System.Windows.Forms.ComboBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.tabCalendar = New System.Windows.Forms.TabPage()
        Me.VolMgmtTabs.SuspendLayout()
        Me.tabSchedule.SuspendLayout()
        Me.ManageSchedule.SuspendLayout()
        Me.CreateSchedule.SuspendLayout()
        Me.tabVolunteer.SuspendLayout()
        Me.AssignSchedule.SuspendLayout()
        Me.SelectVolunteer.SuspendLayout()
        Me.tabSubstitute.SuspendLayout()
        Me.SubstituteAssignment.SuspendLayout()
        Me.OriginalVolunteer.SuspendLayout()
        Me.tabClosing.SuspendLayout()
        Me.ButtonPanel.SuspendLayout()
        Me.ClosingDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'VolMgmtTabs
        '
        Me.VolMgmtTabs.Controls.Add(Me.tabSchedule)
        Me.VolMgmtTabs.Controls.Add(Me.tabVolunteer)
        Me.VolMgmtTabs.Controls.Add(Me.tabSubstitute)
        Me.VolMgmtTabs.Controls.Add(Me.tabClosing)
        Me.VolMgmtTabs.Controls.Add(Me.tabCalendar)
        Me.VolMgmtTabs.Location = New System.Drawing.Point(26, 12)
        Me.VolMgmtTabs.Name = "VolMgmtTabs"
        Me.VolMgmtTabs.SelectedIndex = 0
        Me.VolMgmtTabs.Size = New System.Drawing.Size(859, 621)
        Me.VolMgmtTabs.TabIndex = 0
        '
        'tabSchedule
        '
        Me.tabSchedule.Controls.Add(Me.lvwSchedule)
        Me.tabSchedule.Controls.Add(Me.ManageSchedule)
        Me.tabSchedule.Controls.Add(Me.CreateSchedule)
        Me.tabSchedule.Location = New System.Drawing.Point(4, 27)
        Me.tabSchedule.Name = "tabSchedule"
        Me.tabSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSchedule.Size = New System.Drawing.Size(851, 590)
        Me.tabSchedule.TabIndex = 0
        Me.tabSchedule.Text = "Schedule Management"
        Me.tabSchedule.UseVisualStyleBackColor = True
        '
        'lvwSchedule
        '
        Me.lvwSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DayOFWeek, Me.StartTime, Me.EndTime, Me.Status})
        Me.lvwSchedule.FullRowSelect = True
        Me.lvwSchedule.GridLines = True
        Me.lvwSchedule.HideSelection = False
        Me.lvwSchedule.Location = New System.Drawing.Point(20, 240)
        Me.lvwSchedule.Name = "lvwSchedule"
        Me.lvwSchedule.Size = New System.Drawing.Size(800, 300)
        Me.lvwSchedule.TabIndex = 5
        Me.lvwSchedule.UseCompatibleStateImageBehavior = False
        Me.lvwSchedule.View = System.Windows.Forms.View.Details
        '
        'DayOFWeek
        '
        Me.DayOFWeek.Text = "Day of Week"
        Me.DayOFWeek.Width = 150
        '
        'StartTime
        '
        Me.StartTime.Text = "Start Time"
        Me.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.StartTime.Width = 150
        '
        'EndTime
        '
        Me.EndTime.Text = "End Time"
        Me.EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EndTime.Width = 150
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Status.Width = 100
        '
        'ManageSchedule
        '
        Me.ManageSchedule.Controls.Add(Me.btnEditSchedule1)
        Me.ManageSchedule.Controls.Add(Me.btnActivate)
        Me.ManageSchedule.Controls.Add(Me.btnDeactivate)
        Me.ManageSchedule.Controls.Add(Me.btnEditSchedule)
        Me.ManageSchedule.Location = New System.Drawing.Point(450, 20)
        Me.ManageSchedule.Name = "ManageSchedule"
        Me.ManageSchedule.Size = New System.Drawing.Size(370, 200)
        Me.ManageSchedule.TabIndex = 4
        Me.ManageSchedule.TabStop = False
        Me.ManageSchedule.Text = "Manage Schedule"
        '
        'btnEditSchedule1
        '
        Me.btnEditSchedule1.Location = New System.Drawing.Point(40, 40)
        Me.btnEditSchedule1.Name = "btnEditSchedule1"
        Me.btnEditSchedule1.Size = New System.Drawing.Size(120, 30)
        Me.btnEditSchedule1.TabIndex = 1
        Me.btnEditSchedule1.Text = "Edit Selected"
        Me.btnEditSchedule1.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(40, 140)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(120, 30)
        Me.btnActivate.TabIndex = 3
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnDeactivate
        '
        Me.btnDeactivate.Location = New System.Drawing.Point(40, 90)
        Me.btnDeactivate.Name = "btnDeactivate"
        Me.btnDeactivate.Size = New System.Drawing.Size(120, 30)
        Me.btnDeactivate.TabIndex = 2
        Me.btnDeactivate.Text = "Deactivate"
        Me.btnDeactivate.UseVisualStyleBackColor = True
        '
        'btnEditSchedule
        '
        Me.btnEditSchedule.Location = New System.Drawing.Point(470, 40)
        Me.btnEditSchedule.Name = "btnEditSchedule"
        Me.btnEditSchedule.Size = New System.Drawing.Size(75, 23)
        Me.btnEditSchedule.TabIndex = 0
        Me.btnEditSchedule.Text = "Button1"
        Me.btnEditSchedule.UseVisualStyleBackColor = True
        '
        'CreateSchedule
        '
        Me.CreateSchedule.Controls.Add(Me.btnAddSchedule)
        Me.CreateSchedule.Controls.Add(Me.chkIsActive)
        Me.CreateSchedule.Controls.Add(Me.dtpEndTime)
        Me.CreateSchedule.Controls.Add(Me.dtpStartTime)
        Me.CreateSchedule.Controls.Add(Me.cboDayOfWeek)
        Me.CreateSchedule.Location = New System.Drawing.Point(20, 20)
        Me.CreateSchedule.Name = "CreateSchedule"
        Me.CreateSchedule.Size = New System.Drawing.Size(400, 200)
        Me.CreateSchedule.TabIndex = 3
        Me.CreateSchedule.TabStop = False
        Me.CreateSchedule.Text = "Create Schedule"
        '
        'btnAddSchedule
        '
        Me.btnAddSchedule.Location = New System.Drawing.Point(30, 164)
        Me.btnAddSchedule.Name = "btnAddSchedule"
        Me.btnAddSchedule.Size = New System.Drawing.Size(120, 30)
        Me.btnAddSchedule.TabIndex = 4
        Me.btnAddSchedule.Text = "Add Schedule"
        Me.btnAddSchedule.UseVisualStyleBackColor = True
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Checked = True
        Me.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIsActive.Location = New System.Drawing.Point(30, 120)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(139, 22)
        Me.chkIsActive.TabIndex = 3
        Me.chkIsActive.Text = "Active Schedule"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "HH:mm"
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndTime.Location = New System.Drawing.Point(200, 80)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(150, 26)
        Me.dtpEndTime.TabIndex = 2
        Me.dtpEndTime.TabStop = False
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CustomFormat = "HH:mm"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTime.Location = New System.Drawing.Point(30, 80)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(150, 26)
        Me.dtpStartTime.TabIndex = 1
        '
        'cboDayOfWeek
        '
        Me.cboDayOfWeek.FormattingEnabled = True
        Me.cboDayOfWeek.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.cboDayOfWeek.Location = New System.Drawing.Point(30, 40)
        Me.cboDayOfWeek.Name = "cboDayOfWeek"
        Me.cboDayOfWeek.Size = New System.Drawing.Size(150, 26)
        Me.cboDayOfWeek.TabIndex = 0
        '
        'tabVolunteer
        '
        Me.tabVolunteer.Controls.Add(Me.lvwSubs)
        Me.tabVolunteer.Controls.Add(Me.AssignSchedule)
        Me.tabVolunteer.Controls.Add(Me.lvwVolunteerSchedule)
        Me.tabVolunteer.Controls.Add(Me.SelectVolunteer)
        Me.tabVolunteer.Location = New System.Drawing.Point(4, 27)
        Me.tabVolunteer.Name = "tabVolunteer"
        Me.tabVolunteer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVolunteer.Size = New System.Drawing.Size(851, 590)
        Me.tabVolunteer.TabIndex = 1
        Me.tabVolunteer.Text = "Volunteer Assignments"
        Me.tabVolunteer.UseVisualStyleBackColor = True
        '
        'lvwSubs
        '
        Me.lvwSubs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OriginalVolunteer1, Me.SubstituteVolunteer, Me.SubstituteDate, Me.SubstituteStartTime, Me.SubstituteEndTime, Me.SubstituteStatus})
        Me.lvwSubs.FullRowSelect = True
        Me.lvwSubs.GridLines = True
        Me.lvwSubs.HideSelection = False
        Me.lvwSubs.Location = New System.Drawing.Point(20, 290)
        Me.lvwSubs.Name = "lvwSubs"
        Me.lvwSubs.Size = New System.Drawing.Size(800, 120)
        Me.lvwSubs.TabIndex = 3
        Me.lvwSubs.UseCompatibleStateImageBehavior = False
        Me.lvwSubs.View = System.Windows.Forms.View.Details
        '
        'OriginalVolunteer1
        '
        Me.OriginalVolunteer1.Text = "Original Volunteer"
        Me.OriginalVolunteer1.Width = 150
        '
        'SubstituteVolunteer
        '
        Me.SubstituteVolunteer.Text = "Substitute Volunteer"
        Me.SubstituteVolunteer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubstituteVolunteer.Width = 150
        '
        'SubstituteDate
        '
        Me.SubstituteDate.Text = "Date"
        Me.SubstituteDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubstituteDate.Width = 120
        '
        'SubstituteStartTime
        '
        Me.SubstituteStartTime.Text = "Start Time"
        Me.SubstituteStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubstituteStartTime.Width = 120
        '
        'SubstituteEndTime
        '
        Me.SubstituteEndTime.Text = "End Time"
        Me.SubstituteEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubstituteEndTime.Width = 120
        '
        'SubstituteStatus
        '
        Me.SubstituteStatus.Text = "Status"
        Me.SubstituteStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubstituteStatus.Width = 100
        '
        'AssignSchedule
        '
        Me.AssignSchedule.Controls.Add(Me.btnRemoveAssignment)
        Me.AssignSchedule.Controls.Add(Me.btnAssignSchedule)
        Me.AssignSchedule.Controls.Add(Me.cboAvailableSchedule)
        Me.AssignSchedule.Location = New System.Drawing.Point(20, 443)
        Me.AssignSchedule.Name = "AssignSchedule"
        Me.AssignSchedule.Size = New System.Drawing.Size(800, 100)
        Me.AssignSchedule.TabIndex = 2
        Me.AssignSchedule.TabStop = False
        Me.AssignSchedule.Text = "Assign Schedule"
        '
        'btnRemoveAssignment
        '
        Me.btnRemoveAssignment.Location = New System.Drawing.Point(520, 45)
        Me.btnRemoveAssignment.Name = "btnRemoveAssignment"
        Me.btnRemoveAssignment.Size = New System.Drawing.Size(177, 30)
        Me.btnRemoveAssignment.TabIndex = 2
        Me.btnRemoveAssignment.Text = "Remove Assignment"
        Me.btnRemoveAssignment.UseVisualStyleBackColor = True
        '
        'btnAssignSchedule
        '
        Me.btnAssignSchedule.Location = New System.Drawing.Point(350, 45)
        Me.btnAssignSchedule.Name = "btnAssignSchedule"
        Me.btnAssignSchedule.Size = New System.Drawing.Size(150, 30)
        Me.btnAssignSchedule.TabIndex = 1
        Me.btnAssignSchedule.Text = "Assign Schedule"
        Me.btnAssignSchedule.UseVisualStyleBackColor = True
        '
        'cboAvailableSchedule
        '
        Me.cboAvailableSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAvailableSchedule.FormattingEnabled = True
        Me.cboAvailableSchedule.Location = New System.Drawing.Point(30, 45)
        Me.cboAvailableSchedule.Name = "cboAvailableSchedule"
        Me.cboAvailableSchedule.Size = New System.Drawing.Size(300, 26)
        Me.cboAvailableSchedule.TabIndex = 0
        '
        'lvwVolunteerSchedule
        '
        Me.lvwVolunteerSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SchedDay1, Me.SchedStartTime, Me.SchedEndTime, Me.SchedStatus})
        Me.lvwVolunteerSchedule.FullRowSelect = True
        Me.lvwVolunteerSchedule.GridLines = True
        Me.lvwVolunteerSchedule.HideSelection = False
        Me.lvwVolunteerSchedule.Location = New System.Drawing.Point(20, 140)
        Me.lvwVolunteerSchedule.Name = "lvwVolunteerSchedule"
        Me.lvwVolunteerSchedule.Size = New System.Drawing.Size(800, 120)
        Me.lvwVolunteerSchedule.TabIndex = 1
        Me.lvwVolunteerSchedule.UseCompatibleStateImageBehavior = False
        Me.lvwVolunteerSchedule.View = System.Windows.Forms.View.Details
        '
        'SchedDay1
        '
        Me.SchedDay1.Text = "Day"
        Me.SchedDay1.Width = 120
        '
        'SchedStartTime
        '
        Me.SchedStartTime.Text = "Start Time"
        Me.SchedStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SchedStartTime.Width = 120
        '
        'SchedEndTime
        '
        Me.SchedEndTime.Text = "End Time"
        Me.SchedEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SchedEndTime.Width = 120
        '
        'SchedStatus
        '
        Me.SchedStatus.Text = "Status"
        Me.SchedStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SchedStatus.Width = 100
        '
        'SelectVolunteer
        '
        Me.SelectVolunteer.Controls.Add(Me.lblVolunteerDetails)
        Me.SelectVolunteer.Controls.Add(Me.cboVolunteer)
        Me.SelectVolunteer.Controls.Add(Me.lblSelectVolunteer)
        Me.SelectVolunteer.Location = New System.Drawing.Point(20, 20)
        Me.SelectVolunteer.Name = "SelectVolunteer"
        Me.SelectVolunteer.Size = New System.Drawing.Size(800, 100)
        Me.SelectVolunteer.TabIndex = 0
        Me.SelectVolunteer.TabStop = False
        Me.SelectVolunteer.Text = "Select Volunteer"
        '
        'lblVolunteerDetails
        '
        Me.lblVolunteerDetails.AutoSize = True
        Me.lblVolunteerDetails.Location = New System.Drawing.Point(30, 65)
        Me.lblVolunteerDetails.Name = "lblVolunteerDetails"
        Me.lblVolunteerDetails.Size = New System.Drawing.Size(748, 18)
        Me.lblVolunteerDetails.TabIndex = 2
        Me.lblVolunteerDetails.Text = "                                                                                 " &
    "                                                                                " &
    "                        "
        '
        'cboVolunteer
        '
        Me.cboVolunteer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVolunteer.FormattingEnabled = True
        Me.cboVolunteer.Location = New System.Drawing.Point(157, 27)
        Me.cboVolunteer.Name = "cboVolunteer"
        Me.cboVolunteer.Size = New System.Drawing.Size(300, 26)
        Me.cboVolunteer.TabIndex = 1
        '
        'lblSelectVolunteer
        '
        Me.lblSelectVolunteer.AutoSize = True
        Me.lblSelectVolunteer.Location = New System.Drawing.Point(27, 35)
        Me.lblSelectVolunteer.Name = "lblSelectVolunteer"
        Me.lblSelectVolunteer.Size = New System.Drawing.Size(125, 18)
        Me.lblSelectVolunteer.TabIndex = 0
        Me.lblSelectVolunteer.Text = "Select Volunteer:"
        '
        'tabSubstitute
        '
        Me.tabSubstitute.Controls.Add(Me.SubstituteAssignment)
        Me.tabSubstitute.Controls.Add(Me.lvwOrgs)
        Me.tabSubstitute.Controls.Add(Me.OriginalVolunteer)
        Me.tabSubstitute.Location = New System.Drawing.Point(4, 27)
        Me.tabSubstitute.Name = "tabSubstitute"
        Me.tabSubstitute.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSubstitute.Size = New System.Drawing.Size(851, 590)
        Me.tabSubstitute.TabIndex = 2
        Me.tabSubstitute.Text = "Substitute Management"
        Me.tabSubstitute.UseVisualStyleBackColor = True
        '
        'SubstituteAssignment
        '
        Me.SubstituteAssignment.Controls.Add(Me.btnRemoveSubstitute)
        Me.SubstituteAssignment.Controls.Add(Me.btnAssignSubstitute)
        Me.SubstituteAssignment.Controls.Add(Me.dtpSubDate)
        Me.SubstituteAssignment.Controls.Add(Me.lblSubDate)
        Me.SubstituteAssignment.Controls.Add(Me.cboSubstituteVolunteer)
        Me.SubstituteAssignment.Controls.Add(Me.lblSubstituteVolunteer1)
        Me.SubstituteAssignment.Controls.Add(Me.lblSubstituteVolunteer)
        Me.SubstituteAssignment.Location = New System.Drawing.Point(20, 360)
        Me.SubstituteAssignment.Name = "SubstituteAssignment"
        Me.SubstituteAssignment.Size = New System.Drawing.Size(800, 150)
        Me.SubstituteAssignment.TabIndex = 2
        Me.SubstituteAssignment.TabStop = False
        Me.SubstituteAssignment.Text = "Substitute Assignment"
        '
        'btnRemoveSubstitute
        '
        Me.btnRemoveSubstitute.Location = New System.Drawing.Point(500, 90)
        Me.btnRemoveSubstitute.Name = "btnRemoveSubstitute"
        Me.btnRemoveSubstitute.Size = New System.Drawing.Size(150, 30)
        Me.btnRemoveSubstitute.TabIndex = 6
        Me.btnRemoveSubstitute.Text = "Remove Substitute"
        Me.btnRemoveSubstitute.UseVisualStyleBackColor = True
        '
        'btnAssignSubstitute
        '
        Me.btnAssignSubstitute.Location = New System.Drawing.Point(500, 40)
        Me.btnAssignSubstitute.Name = "btnAssignSubstitute"
        Me.btnAssignSubstitute.Size = New System.Drawing.Size(150, 30)
        Me.btnAssignSubstitute.TabIndex = 5
        Me.btnAssignSubstitute.Text = "Assign Substitute"
        Me.btnAssignSubstitute.UseVisualStyleBackColor = True
        '
        'dtpSubDate
        '
        Me.dtpSubDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSubDate.Location = New System.Drawing.Point(165, 72)
        Me.dtpSubDate.Name = "dtpSubDate"
        Me.dtpSubDate.Size = New System.Drawing.Size(200, 26)
        Me.dtpSubDate.TabIndex = 4
        '
        'lblSubDate
        '
        Me.lblSubDate.AutoSize = True
        Me.lblSubDate.Location = New System.Drawing.Point(30, 80)
        Me.lblSubDate.Name = "lblSubDate"
        Me.lblSubDate.Size = New System.Drawing.Size(119, 18)
        Me.lblSubDate.TabIndex = 3
        Me.lblSubDate.Text = "Substitute Date:"
        '
        'cboSubstituteVolunteer
        '
        Me.cboSubstituteVolunteer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubstituteVolunteer.FormattingEnabled = True
        Me.cboSubstituteVolunteer.Location = New System.Drawing.Point(165, 37)
        Me.cboSubstituteVolunteer.Name = "cboSubstituteVolunteer"
        Me.cboSubstituteVolunteer.Size = New System.Drawing.Size(300, 26)
        Me.cboSubstituteVolunteer.TabIndex = 2
        '
        'lblSubstituteVolunteer1
        '
        Me.lblSubstituteVolunteer1.AutoSize = True
        Me.lblSubstituteVolunteer1.Location = New System.Drawing.Point(30, 45)
        Me.lblSubstituteVolunteer1.Name = "lblSubstituteVolunteer1"
        Me.lblSubstituteVolunteer1.Size = New System.Drawing.Size(129, 18)
        Me.lblSubstituteVolunteer1.TabIndex = 1
        Me.lblSubstituteVolunteer1.Text = "Select Substitute:"
        '
        'lblSubstituteVolunteer
        '
        Me.lblSubstituteVolunteer.AutoSize = True
        Me.lblSubstituteVolunteer.Location = New System.Drawing.Point(30, 390)
        Me.lblSubstituteVolunteer.Name = "lblSubstituteVolunteer"
        Me.lblSubstituteVolunteer.Size = New System.Drawing.Size(56, 18)
        Me.lblSubstituteVolunteer.TabIndex = 0
        Me.lblSubstituteVolunteer.Text = "Label1"
        '
        'lvwOrgs
        '
        Me.lvwOrgs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SubDay, Me.SubStartTime, Me.SubEndTime, Me.SubStatus, Me.SubDate, Me.SubSubstitute})
        Me.lvwOrgs.FullRowSelect = True
        Me.lvwOrgs.GridLines = True
        Me.lvwOrgs.HideSelection = False
        Me.lvwOrgs.Location = New System.Drawing.Point(20, 140)
        Me.lvwOrgs.Name = "lvwOrgs"
        Me.lvwOrgs.Size = New System.Drawing.Size(800, 200)
        Me.lvwOrgs.TabIndex = 1
        Me.lvwOrgs.UseCompatibleStateImageBehavior = False
        Me.lvwOrgs.View = System.Windows.Forms.View.Details
        '
        'SubDay
        '
        Me.SubDay.Text = "Day"
        Me.SubDay.Width = 120
        '
        'SubStartTime
        '
        Me.SubStartTime.Text = "Start time"
        Me.SubStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubStartTime.Width = 120
        '
        'SubEndTime
        '
        Me.SubEndTime.Text = "End Time"
        Me.SubEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubEndTime.Width = 120
        '
        'SubStatus
        '
        Me.SubStatus.Text = "Status"
        Me.SubStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubStatus.Width = 100
        '
        'SubDate
        '
        Me.SubDate.Text = "Date"
        Me.SubDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubDate.Width = 120
        '
        'SubSubstitute
        '
        Me.SubSubstitute.Text = "Substitute"
        Me.SubSubstitute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubSubstitute.Width = 150
        '
        'OriginalVolunteer
        '
        Me.OriginalVolunteer.Controls.Add(Me.cboOriginalVolunteer)
        Me.OriginalVolunteer.Controls.Add(Me.lblOriginalVolunteer)
        Me.OriginalVolunteer.Location = New System.Drawing.Point(20, 20)
        Me.OriginalVolunteer.Name = "OriginalVolunteer"
        Me.OriginalVolunteer.Size = New System.Drawing.Size(800, 100)
        Me.OriginalVolunteer.TabIndex = 0
        Me.OriginalVolunteer.TabStop = False
        Me.OriginalVolunteer.Text = "Original Volunteer"
        '
        'cboOriginalVolunteer
        '
        Me.cboOriginalVolunteer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOriginalVolunteer.FormattingEnabled = True
        Me.cboOriginalVolunteer.Location = New System.Drawing.Point(160, 28)
        Me.cboOriginalVolunteer.Name = "cboOriginalVolunteer"
        Me.cboOriginalVolunteer.Size = New System.Drawing.Size(300, 26)
        Me.cboOriginalVolunteer.TabIndex = 1
        '
        'lblOriginalVolunteer
        '
        Me.lblOriginalVolunteer.AutoSize = True
        Me.lblOriginalVolunteer.Location = New System.Drawing.Point(30, 36)
        Me.lblOriginalVolunteer.Name = "lblOriginalVolunteer"
        Me.lblOriginalVolunteer.Size = New System.Drawing.Size(125, 18)
        Me.lblOriginalVolunteer.TabIndex = 0
        Me.lblOriginalVolunteer.Text = "Select Volunteer:"
        '
        'tabClosing
        '
        Me.tabClosing.Controls.Add(Me.lvwClosings)
        Me.tabClosing.Controls.Add(Me.ButtonPanel)
        Me.tabClosing.Controls.Add(Me.ClosingDetails)
        Me.tabClosing.Location = New System.Drawing.Point(4, 27)
        Me.tabClosing.Name = "tabClosing"
        Me.tabClosing.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClosing.Size = New System.Drawing.Size(851, 590)
        Me.tabClosing.TabIndex = 3
        Me.tabClosing.Text = "Closing Management"
        Me.tabClosing.UseVisualStyleBackColor = True
        '
        'lvwClosings
        '
        Me.lvwClosings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CloseStartDate, Me.CloseEndDate, Me.CloseType, Me.CloseEmergency, Me.CloseDescription})
        Me.lvwClosings.FullRowSelect = True
        Me.lvwClosings.GridLines = True
        Me.lvwClosings.HideSelection = False
        Me.lvwClosings.Location = New System.Drawing.Point(20, 370)
        Me.lvwClosings.Name = "lvwClosings"
        Me.lvwClosings.Size = New System.Drawing.Size(600, 200)
        Me.lvwClosings.TabIndex = 1
        Me.lvwClosings.UseCompatibleStateImageBehavior = False
        Me.lvwClosings.View = System.Windows.Forms.View.Details
        '
        'CloseStartDate
        '
        Me.CloseStartDate.Text = "Start Date"
        Me.CloseStartDate.Width = 100
        '
        'CloseEndDate
        '
        Me.CloseEndDate.Text = "End Date"
        Me.CloseEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseEndDate.Width = 100
        '
        'CloseType
        '
        Me.CloseType.Text = "Type"
        Me.CloseType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseType.Width = 100
        '
        'CloseEmergency
        '
        Me.CloseEmergency.Text = "Emergency"
        Me.CloseEmergency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseEmergency.Width = 70
        '
        'CloseDescription
        '
        Me.CloseDescription.Text = "Description"
        Me.CloseDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CloseDescription.Width = 230
        '
        'ButtonPanel
        '
        Me.ButtonPanel.Controls.Add(Me.btnCancelEdit)
        Me.ButtonPanel.Controls.Add(Me.btnSaveChanges)
        Me.ButtonPanel.Controls.Add(Me.btnRemoveClosing)
        Me.ButtonPanel.Controls.Add(Me.btnUpdateClosing)
        Me.ButtonPanel.Controls.Add(Me.btnAddClosing1)
        Me.ButtonPanel.Controls.Add(Me.btnAddClosing)
        Me.ButtonPanel.Location = New System.Drawing.Point(20, 306)
        Me.ButtonPanel.Name = "ButtonPanel"
        Me.ButtonPanel.Size = New System.Drawing.Size(600, 50)
        Me.ButtonPanel.TabIndex = 0
        Me.ButtonPanel.TabStop = False
        Me.ButtonPanel.Text = "Button Panel"
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Location = New System.Drawing.Point(380, 18)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(141, 26)
        Me.btnCancelEdit.TabIndex = 5
        Me.btnCancelEdit.Text = "Cancel Edit"
        Me.btnCancelEdit.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(194, 18)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(141, 26)
        Me.btnSaveChanges.TabIndex = 4
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnRemoveClosing
        '
        Me.btnRemoveClosing.Location = New System.Drawing.Point(380, 18)
        Me.btnRemoveClosing.Name = "btnRemoveClosing"
        Me.btnRemoveClosing.Size = New System.Drawing.Size(141, 26)
        Me.btnRemoveClosing.TabIndex = 3
        Me.btnRemoveClosing.Text = "Delete Closing"
        Me.btnRemoveClosing.UseVisualStyleBackColor = True
        '
        'btnUpdateClosing
        '
        Me.btnUpdateClosing.Location = New System.Drawing.Point(194, 18)
        Me.btnUpdateClosing.Name = "btnUpdateClosing"
        Me.btnUpdateClosing.Size = New System.Drawing.Size(141, 26)
        Me.btnUpdateClosing.TabIndex = 2
        Me.btnUpdateClosing.Text = "Update Closing"
        Me.btnUpdateClosing.UseVisualStyleBackColor = True
        '
        'btnAddClosing1
        '
        Me.btnAddClosing1.Location = New System.Drawing.Point(33, 18)
        Me.btnAddClosing1.Name = "btnAddClosing1"
        Me.btnAddClosing1.Size = New System.Drawing.Size(120, 26)
        Me.btnAddClosing1.TabIndex = 1
        Me.btnAddClosing1.Text = "Add Closing"
        Me.btnAddClosing1.UseVisualStyleBackColor = True
        '
        'btnAddClosing
        '
        Me.btnAddClosing.Location = New System.Drawing.Point(30, 100)
        Me.btnAddClosing.Name = "btnAddClosing"
        Me.btnAddClosing.Size = New System.Drawing.Size(75, 23)
        Me.btnAddClosing.TabIndex = 0
        Me.btnAddClosing.Text = "Button1"
        Me.btnAddClosing.UseVisualStyleBackColor = True
        '
        'ClosingDetails
        '
        Me.ClosingDetails.Controls.Add(Me.txtDescription)
        Me.ClosingDetails.Controls.Add(Me.lblDescription)
        Me.ClosingDetails.Controls.Add(Me.chkEmergency)
        Me.ClosingDetails.Controls.Add(Me.cboClosingType)
        Me.ClosingDetails.Controls.Add(Me.lblType)
        Me.ClosingDetails.Controls.Add(Me.dtpEndDate)
        Me.ClosingDetails.Controls.Add(Me.lblEndDate)
        Me.ClosingDetails.Controls.Add(Me.dtpStartDate)
        Me.ClosingDetails.Controls.Add(Me.lblStartDate)
        Me.ClosingDetails.Location = New System.Drawing.Point(20, 20)
        Me.ClosingDetails.Name = "ClosingDetails"
        Me.ClosingDetails.Size = New System.Drawing.Size(600, 280)
        Me.ClosingDetails.TabIndex = 0
        Me.ClosingDetails.TabStop = False
        Me.ClosingDetails.Text = "Closing Details"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Location = New System.Drawing.Point(30, 175)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(550, 80)
        Me.txtDescription.TabIndex = 8
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(30, 155)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(88, 18)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkEmergency
        '
        Me.chkEmergency.AutoSize = True
        Me.chkEmergency.Location = New System.Drawing.Point(250, 115)
        Me.chkEmergency.Name = "chkEmergency"
        Me.chkEmergency.Size = New System.Drawing.Size(163, 22)
        Me.chkEmergency.TabIndex = 6
        Me.chkEmergency.Text = "Emergency Closing"
        Me.chkEmergency.UseVisualStyleBackColor = True
        '
        'cboClosingType
        '
        Me.cboClosingType.FormattingEnabled = True
        Me.cboClosingType.Items.AddRange(New Object() {"Holiday", "Maintenance", "Weather", "Other"})
        Me.cboClosingType.Location = New System.Drawing.Point(30, 115)
        Me.cboClosingType.Name = "cboClosingType"
        Me.cboClosingType.Size = New System.Drawing.Size(200, 26)
        Me.cboClosingType.TabIndex = 5
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(30, 95)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(98, 18)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Closing Type"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(253, 55)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(100, 26)
        Me.dtpEndDate.TabIndex = 3
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(250, 35)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(74, 18)
        Me.lblEndDate.TabIndex = 2
        Me.lblEndDate.Text = "End Date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(30, 55)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(100, 26)
        Me.dtpStartDate.TabIndex = 1
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(30, 35)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(79, 18)
        Me.lblStartDate.TabIndex = 0
        Me.lblStartDate.Text = "Start Date"
        '
        'tabCalendar
        '
        Me.tabCalendar.Location = New System.Drawing.Point(4, 27)
        Me.tabCalendar.Name = "tabCalendar"
        Me.tabCalendar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalendar.Size = New System.Drawing.Size(851, 590)
        Me.tabCalendar.TabIndex = 4
        Me.tabCalendar.Text = "Calendar View"
        Me.tabCalendar.UseVisualStyleBackColor = True
        '
        'FrmVolunteers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 657)
        Me.Controls.Add(Me.VolMgmtTabs)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVolunteers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volunteer Management"
        Me.VolMgmtTabs.ResumeLayout(False)
        Me.tabSchedule.ResumeLayout(False)
        Me.ManageSchedule.ResumeLayout(False)
        Me.CreateSchedule.ResumeLayout(False)
        Me.CreateSchedule.PerformLayout()
        Me.tabVolunteer.ResumeLayout(False)
        Me.AssignSchedule.ResumeLayout(False)
        Me.SelectVolunteer.ResumeLayout(False)
        Me.SelectVolunteer.PerformLayout()
        Me.tabSubstitute.ResumeLayout(False)
        Me.SubstituteAssignment.ResumeLayout(False)
        Me.SubstituteAssignment.PerformLayout()
        Me.OriginalVolunteer.ResumeLayout(False)
        Me.OriginalVolunteer.PerformLayout()
        Me.tabClosing.ResumeLayout(False)
        Me.ButtonPanel.ResumeLayout(False)
        Me.ClosingDetails.ResumeLayout(False)
        Me.ClosingDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VolMgmtTabs As TabControl
    Friend WithEvents tabSchedule As TabPage
    Friend WithEvents tabVolunteer As TabPage
    Friend WithEvents tabSubstitute As TabPage
    Friend WithEvents tabClosing As TabPage
    Friend WithEvents lvwSchedule As ListView
    Friend WithEvents DayOFWeek As ColumnHeader
    Friend WithEvents StartTime As ColumnHeader
    Friend WithEvents EndTime As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents ManageSchedule As GroupBox
    Friend WithEvents btnEditSchedule1 As Button
    Friend WithEvents btnActivate As Button
    Friend WithEvents btnDeactivate As Button
    Friend WithEvents btnEditSchedule As Button
    Friend WithEvents CreateSchedule As GroupBox
    Friend WithEvents btnAddSchedule As Button
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents cboDayOfWeek As ComboBox
    Friend WithEvents tabCalendar As TabPage
    Friend WithEvents SelectVolunteer As GroupBox
    Friend WithEvents AssignSchedule As GroupBox
    Friend WithEvents lvwVolunteerSchedule As ListView
    Friend WithEvents btnAssignSchedule As Button
    Friend WithEvents cboAvailableSchedule As ComboBox
    Friend WithEvents btnRemoveAssignment As Button
    Friend WithEvents SchedStartTime As ColumnHeader
    Friend WithEvents SchedEndTime As ColumnHeader
    Friend WithEvents SchedStatus As ColumnHeader
    Friend WithEvents lblSelectVolunteer As Label
    Friend WithEvents lblVolunteerDetails As Label
    Friend WithEvents cboVolunteer As ComboBox
    Friend WithEvents SubstituteAssignment As GroupBox
    Friend WithEvents lvwOrgs As ListView
    Friend WithEvents OriginalVolunteer As GroupBox
    Friend WithEvents cboOriginalVolunteer As ComboBox
    Friend WithEvents lblOriginalVolunteer As Label
    Friend WithEvents lblSubstituteVolunteer As Label
    Friend WithEvents SubDay As ColumnHeader
    Friend WithEvents SubStartTime As ColumnHeader
    Friend WithEvents SubEndTime As ColumnHeader
    Friend WithEvents SubStatus As ColumnHeader
    Friend WithEvents lblSubDate As Label
    Friend WithEvents cboSubstituteVolunteer As ComboBox
    Friend WithEvents lblSubstituteVolunteer1 As Label
    Friend WithEvents btnAssignSubstitute As Button
    Friend WithEvents dtpSubDate As DateTimePicker
    Friend WithEvents btnRemoveSubstitute As Button
    Friend WithEvents lvwSubs As ListView
    Friend WithEvents OriginalVolunteer1 As ColumnHeader
    Friend WithEvents SubstituteVolunteer As ColumnHeader
    Friend WithEvents SubstituteDate As ColumnHeader
    Friend WithEvents SubstituteStartTime As ColumnHeader
    Friend WithEvents SubstituteEndTime As ColumnHeader
    Friend WithEvents SchedDay1 As ColumnHeader
    Friend WithEvents SubstituteStatus As ColumnHeader
    Friend WithEvents SubSubstitute As ColumnHeader
    Friend WithEvents SubDate As ColumnHeader
    Friend WithEvents ClosingDetails As GroupBox
    Friend WithEvents ButtonPanel As GroupBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblStartDate As Label
    Friend WithEvents cboClosingType As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents chkEmergency As CheckBox
    Friend WithEvents btnAddClosing1 As Button
    Friend WithEvents btnAddClosing As Button
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnRemoveClosing As Button
    Friend WithEvents btnUpdateClosing As Button
    Friend WithEvents lvwClosings As ListView
    Friend WithEvents CloseStartDate As ColumnHeader
    Friend WithEvents CloseEndDate As ColumnHeader
    Friend WithEvents CloseType As ColumnHeader
    Friend WithEvents CloseEmergency As ColumnHeader
    Friend WithEvents CloseDescription As ColumnHeader
    Friend WithEvents btnCancelEdit As Button
    Friend WithEvents btnSaveChanges As Button
End Class
