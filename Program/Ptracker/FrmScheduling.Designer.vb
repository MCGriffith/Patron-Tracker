<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScheduling
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
        Me.tabScheduling = New System.Windows.Forms.TabControl()
        Me.tabTemplates = New System.Windows.Forms.TabPage()
        Me.btnShiftsClose = New System.Windows.Forms.Button()
        Me.btnSaveShiftTemplate = New System.Windows.Forms.Button()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblDayOfWeek = New System.Windows.Forms.Label()
        Me.dgvShiftTemplates = New System.Windows.Forms.DataGridView()
        Me.btnAddShiftTemplate = New System.Windows.Forms.Button()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.cboDayOfWeek = New System.Windows.Forms.ComboBox()
        Me.tabAssignments = New System.Windows.Forms.TabPage()
        Me.lblSelectShift = New System.Windows.Forms.Label()
        Me.lblSelectVolunteer = New System.Windows.Forms.Label()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.btnAssignVolunteer = New System.Windows.Forms.Button()
        Me.chkIsSubstitute = New System.Windows.Forms.CheckBox()
        Me.cboShiftDay = New System.Windows.Forms.ComboBox()
        Me.cboVolunteer = New System.Windows.Forms.ComboBox()
        Me.tabSubstitutes = New System.Windows.Forms.TabPage()
        Me.lblSubstituteDate = New System.Windows.Forms.Label()
        Me.lblShiftToReplace = New System.Windows.Forms.Label()
        Me.lblSubstituteVolunteer = New System.Windows.Forms.Label()
        Me.lblOriginalVoluntee = New System.Windows.Forms.Label()
        Me.dgvSubstitutes = New System.Windows.Forms.DataGridView()
        Me.btnRecordSubstitute = New System.Windows.Forms.Button()
        Me.dtpCoverageDate = New System.Windows.Forms.DateTimePicker()
        Me.cboShiftToReplace = New System.Windows.Forms.ComboBox()
        Me.cboSubstituteVolunteer = New System.Windows.Forms.ComboBox()
        Me.cboOriginalVolunteer = New System.Windows.Forms.ComboBox()
        Me.tabScheduling.SuspendLayout()
        Me.tabTemplates.SuspendLayout()
        CType(Me.dgvShiftTemplates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAssignments.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSubstitutes.SuspendLayout()
        CType(Me.dgvSubstitutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabScheduling
        '
        Me.tabScheduling.Controls.Add(Me.tabTemplates)
        Me.tabScheduling.Controls.Add(Me.tabAssignments)
        Me.tabScheduling.Controls.Add(Me.tabSubstitutes)
        Me.tabScheduling.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabScheduling.Location = New System.Drawing.Point(0, 0)
        Me.tabScheduling.Name = "tabScheduling"
        Me.tabScheduling.SelectedIndex = 0
        Me.tabScheduling.Size = New System.Drawing.Size(804, 491)
        Me.tabScheduling.TabIndex = 0
        '
        'tabTemplates
        '
        Me.tabTemplates.Controls.Add(Me.btnShiftsClose)
        Me.tabTemplates.Controls.Add(Me.btnSaveShiftTemplate)
        Me.tabTemplates.Controls.Add(Me.lblEndTime)
        Me.tabTemplates.Controls.Add(Me.lblStartTime)
        Me.tabTemplates.Controls.Add(Me.lblDayOfWeek)
        Me.tabTemplates.Controls.Add(Me.dgvShiftTemplates)
        Me.tabTemplates.Controls.Add(Me.btnAddShiftTemplate)
        Me.tabTemplates.Controls.Add(Me.dtpEndTime)
        Me.tabTemplates.Controls.Add(Me.dtpStartTime)
        Me.tabTemplates.Controls.Add(Me.cboDayOfWeek)
        Me.tabTemplates.Location = New System.Drawing.Point(4, 27)
        Me.tabTemplates.Name = "tabTemplates"
        Me.tabTemplates.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTemplates.Size = New System.Drawing.Size(796, 460)
        Me.tabTemplates.TabIndex = 0
        Me.tabTemplates.Text = "Shift Templates"
        Me.tabTemplates.UseVisualStyleBackColor = True
        '
        'btnShiftsClose
        '
        Me.btnShiftsClose.Location = New System.Drawing.Point(571, 385)
        Me.btnShiftsClose.Name = "btnShiftsClose"
        Me.btnShiftsClose.Size = New System.Drawing.Size(183, 41)
        Me.btnShiftsClose.TabIndex = 9
        Me.btnShiftsClose.Text = "Close"
        Me.btnShiftsClose.UseVisualStyleBackColor = True
        '
        'btnSaveShiftTemplate
        '
        Me.btnSaveShiftTemplate.Location = New System.Drawing.Point(571, 110)
        Me.btnSaveShiftTemplate.Name = "btnSaveShiftTemplate"
        Me.btnSaveShiftTemplate.Size = New System.Drawing.Size(183, 41)
        Me.btnSaveShiftTemplate.TabIndex = 8
        Me.btnSaveShiftTemplate.Text = "Save Templates"
        Me.btnSaveShiftTemplate.UseVisualStyleBackColor = True
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(383, 35)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(74, 18)
        Me.lblEndTime.TabIndex = 7
        Me.lblEndTime.Text = "End Time"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Location = New System.Drawing.Point(241, 35)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(79, 18)
        Me.lblStartTime.TabIndex = 6
        Me.lblStartTime.Text = "Start Time"
        '
        'lblDayOfWeek
        '
        Me.lblDayOfWeek.AutoSize = True
        Me.lblDayOfWeek.Location = New System.Drawing.Point(24, 35)
        Me.lblDayOfWeek.Name = "lblDayOfWeek"
        Me.lblDayOfWeek.Size = New System.Drawing.Size(98, 18)
        Me.lblDayOfWeek.TabIndex = 5
        Me.lblDayOfWeek.Text = "Day of Week"
        '
        'dgvShiftTemplates
        '
        Me.dgvShiftTemplates.AllowUserToAddRows = False
        Me.dgvShiftTemplates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvShiftTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShiftTemplates.Location = New System.Drawing.Point(27, 171)
        Me.dgvShiftTemplates.Name = "dgvShiftTemplates"
        Me.dgvShiftTemplates.Size = New System.Drawing.Size(727, 184)
        Me.dgvShiftTemplates.TabIndex = 4
        '
        'btnAddShiftTemplate
        '
        Me.btnAddShiftTemplate.Location = New System.Drawing.Point(570, 54)
        Me.btnAddShiftTemplate.Name = "btnAddShiftTemplate"
        Me.btnAddShiftTemplate.Size = New System.Drawing.Size(184, 40)
        Me.btnAddShiftTemplate.TabIndex = 3
        Me.btnAddShiftTemplate.Text = "Add Shift Template"
        Me.btnAddShiftTemplate.UseVisualStyleBackColor = True
        '
        'dtpEndTime
        '
        Me.dtpEndTime.CustomFormat = "HH:mm"
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndTime.Location = New System.Drawing.Point(386, 62)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.ShowUpDown = True
        Me.dtpEndTime.Size = New System.Drawing.Size(78, 26)
        Me.dtpEndTime.TabIndex = 2
        '
        'dtpStartTime
        '
        Me.dtpStartTime.CustomFormat = "HH:mm"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTime.Location = New System.Drawing.Point(244, 62)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.ShowUpDown = True
        Me.dtpStartTime.Size = New System.Drawing.Size(86, 26)
        Me.dtpStartTime.TabIndex = 1
        '
        'cboDayOfWeek
        '
        Me.cboDayOfWeek.FormattingEnabled = True
        Me.cboDayOfWeek.Location = New System.Drawing.Point(27, 62)
        Me.cboDayOfWeek.Name = "cboDayOfWeek"
        Me.cboDayOfWeek.Size = New System.Drawing.Size(169, 26)
        Me.cboDayOfWeek.TabIndex = 0
        '
        'tabAssignments
        '
        Me.tabAssignments.Controls.Add(Me.lblSelectShift)
        Me.tabAssignments.Controls.Add(Me.lblSelectVolunteer)
        Me.tabAssignments.Controls.Add(Me.dgvSchedule)
        Me.tabAssignments.Controls.Add(Me.btnAssignVolunteer)
        Me.tabAssignments.Controls.Add(Me.chkIsSubstitute)
        Me.tabAssignments.Controls.Add(Me.cboShiftDay)
        Me.tabAssignments.Controls.Add(Me.cboVolunteer)
        Me.tabAssignments.Location = New System.Drawing.Point(4, 27)
        Me.tabAssignments.Name = "tabAssignments"
        Me.tabAssignments.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAssignments.Size = New System.Drawing.Size(796, 460)
        Me.tabAssignments.TabIndex = 1
        Me.tabAssignments.Text = "Volunteer Assignments"
        Me.tabAssignments.UseVisualStyleBackColor = True
        '
        'lblSelectShift
        '
        Me.lblSelectShift.AutoSize = True
        Me.lblSelectShift.Location = New System.Drawing.Point(405, 39)
        Me.lblSelectShift.Name = "lblSelectShift"
        Me.lblSelectShift.Size = New System.Drawing.Size(84, 18)
        Me.lblSelectShift.TabIndex = 6
        Me.lblSelectShift.Text = "Select shift"
        '
        'lblSelectVolunteer
        '
        Me.lblSelectVolunteer.AutoSize = True
        Me.lblSelectVolunteer.Location = New System.Drawing.Point(23, 39)
        Me.lblSelectVolunteer.Name = "lblSelectVolunteer"
        Me.lblSelectVolunteer.Size = New System.Drawing.Size(121, 18)
        Me.lblSelectVolunteer.TabIndex = 5
        Me.lblSelectVolunteer.Text = "Select Volunteer"
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToResizeRows = False
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSchedule.Location = New System.Drawing.Point(26, 210)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.Size = New System.Drawing.Size(735, 186)
        Me.dgvSchedule.TabIndex = 4
        '
        'btnAssignVolunteer
        '
        Me.btnAssignVolunteer.Location = New System.Drawing.Point(408, 129)
        Me.btnAssignVolunteer.Name = "btnAssignVolunteer"
        Me.btnAssignVolunteer.Size = New System.Drawing.Size(238, 50)
        Me.btnAssignVolunteer.TabIndex = 3
        Me.btnAssignVolunteer.Text = "Assign Volunteer"
        Me.btnAssignVolunteer.UseVisualStyleBackColor = True
        '
        'chkIsSubstitute
        '
        Me.chkIsSubstitute.AutoSize = True
        Me.chkIsSubstitute.Location = New System.Drawing.Point(622, 77)
        Me.chkIsSubstitute.Name = "chkIsSubstitute"
        Me.chkIsSubstitute.Size = New System.Drawing.Size(111, 22)
        Me.chkIsSubstitute.TabIndex = 2
        Me.chkIsSubstitute.Text = "Is Substitute"
        Me.chkIsSubstitute.UseVisualStyleBackColor = True
        '
        'cboShiftDay
        '
        Me.cboShiftDay.FormattingEnabled = True
        Me.cboShiftDay.Location = New System.Drawing.Point(408, 73)
        Me.cboShiftDay.Name = "cboShiftDay"
        Me.cboShiftDay.Size = New System.Drawing.Size(180, 26)
        Me.cboShiftDay.TabIndex = 1
        '
        'cboVolunteer
        '
        Me.cboVolunteer.FormattingEnabled = True
        Me.cboVolunteer.Location = New System.Drawing.Point(26, 73)
        Me.cboVolunteer.Name = "cboVolunteer"
        Me.cboVolunteer.Size = New System.Drawing.Size(334, 26)
        Me.cboVolunteer.TabIndex = 0
        '
        'tabSubstitutes
        '
        Me.tabSubstitutes.Controls.Add(Me.lblSubstituteDate)
        Me.tabSubstitutes.Controls.Add(Me.lblShiftToReplace)
        Me.tabSubstitutes.Controls.Add(Me.lblSubstituteVolunteer)
        Me.tabSubstitutes.Controls.Add(Me.lblOriginalVoluntee)
        Me.tabSubstitutes.Controls.Add(Me.dgvSubstitutes)
        Me.tabSubstitutes.Controls.Add(Me.btnRecordSubstitute)
        Me.tabSubstitutes.Controls.Add(Me.dtpCoverageDate)
        Me.tabSubstitutes.Controls.Add(Me.cboShiftToReplace)
        Me.tabSubstitutes.Controls.Add(Me.cboSubstituteVolunteer)
        Me.tabSubstitutes.Controls.Add(Me.cboOriginalVolunteer)
        Me.tabSubstitutes.Location = New System.Drawing.Point(4, 27)
        Me.tabSubstitutes.Name = "tabSubstitutes"
        Me.tabSubstitutes.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSubstitutes.Size = New System.Drawing.Size(796, 460)
        Me.tabSubstitutes.TabIndex = 2
        Me.tabSubstitutes.Text = "Substitutions"
        Me.tabSubstitutes.UseVisualStyleBackColor = True
        '
        'lblSubstituteDate
        '
        Me.lblSubstituteDate.AutoSize = True
        Me.lblSubstituteDate.Location = New System.Drawing.Point(355, 136)
        Me.lblSubstituteDate.Name = "lblSubstituteDate"
        Me.lblSubstituteDate.Size = New System.Drawing.Size(115, 18)
        Me.lblSubstituteDate.TabIndex = 9
        Me.lblSubstituteDate.Text = "Coverage Date"
        '
        'lblShiftToReplace
        '
        Me.lblShiftToReplace.AutoSize = True
        Me.lblShiftToReplace.Location = New System.Drawing.Point(31, 136)
        Me.lblShiftToReplace.Name = "lblShiftToReplace"
        Me.lblShiftToReplace.Size = New System.Drawing.Size(118, 18)
        Me.lblShiftToReplace.TabIndex = 8
        Me.lblShiftToReplace.Text = "Shift to Replace"
        '
        'lblSubstituteVolunteer
        '
        Me.lblSubstituteVolunteer.AutoSize = True
        Me.lblSubstituteVolunteer.Location = New System.Drawing.Point(390, 50)
        Me.lblSubstituteVolunteer.Name = "lblSubstituteVolunteer"
        Me.lblSubstituteVolunteer.Size = New System.Drawing.Size(146, 18)
        Me.lblSubstituteVolunteer.TabIndex = 7
        Me.lblSubstituteVolunteer.Text = "Substitute Volunteer"
        '
        'lblOriginalVoluntee
        '
        Me.lblOriginalVoluntee.AutoSize = True
        Me.lblOriginalVoluntee.Location = New System.Drawing.Point(31, 50)
        Me.lblOriginalVoluntee.Name = "lblOriginalVoluntee"
        Me.lblOriginalVoluntee.Size = New System.Drawing.Size(131, 18)
        Me.lblOriginalVoluntee.TabIndex = 6
        Me.lblOriginalVoluntee.Text = "Original Volunteer"
        '
        'dgvSubstitutes
        '
        Me.dgvSubstitutes.AllowUserToAddRows = False
        Me.dgvSubstitutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubstitutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubstitutes.Location = New System.Drawing.Point(34, 243)
        Me.dgvSubstitutes.Name = "dgvSubstitutes"
        Me.dgvSubstitutes.Size = New System.Drawing.Size(712, 188)
        Me.dgvSubstitutes.TabIndex = 5
        '
        'btnRecordSubstitute
        '
        Me.btnRecordSubstitute.Location = New System.Drawing.Point(546, 157)
        Me.btnRecordSubstitute.Name = "btnRecordSubstitute"
        Me.btnRecordSubstitute.Size = New System.Drawing.Size(181, 46)
        Me.btnRecordSubstitute.TabIndex = 4
        Me.btnRecordSubstitute.Text = "Record Substitution"
        Me.btnRecordSubstitute.UseVisualStyleBackColor = True
        '
        'dtpCoverageDate
        '
        Me.dtpCoverageDate.CustomFormat = ""
        Me.dtpCoverageDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCoverageDate.Location = New System.Drawing.Point(358, 170)
        Me.dtpCoverageDate.Name = "dtpCoverageDate"
        Me.dtpCoverageDate.Size = New System.Drawing.Size(130, 26)
        Me.dtpCoverageDate.TabIndex = 3
        '
        'cboShiftToReplace
        '
        Me.cboShiftToReplace.FormattingEnabled = True
        Me.cboShiftToReplace.Location = New System.Drawing.Point(34, 170)
        Me.cboShiftToReplace.Name = "cboShiftToReplace"
        Me.cboShiftToReplace.Size = New System.Drawing.Size(259, 26)
        Me.cboShiftToReplace.TabIndex = 2
        '
        'cboSubstituteVolunteer
        '
        Me.cboSubstituteVolunteer.FormattingEnabled = True
        Me.cboSubstituteVolunteer.Location = New System.Drawing.Point(393, 84)
        Me.cboSubstituteVolunteer.Name = "cboSubstituteVolunteer"
        Me.cboSubstituteVolunteer.Size = New System.Drawing.Size(334, 26)
        Me.cboSubstituteVolunteer.TabIndex = 1
        '
        'cboOriginalVolunteer
        '
        Me.cboOriginalVolunteer.FormattingEnabled = True
        Me.cboOriginalVolunteer.Location = New System.Drawing.Point(34, 84)
        Me.cboOriginalVolunteer.Name = "cboOriginalVolunteer"
        Me.cboOriginalVolunteer.Size = New System.Drawing.Size(334, 26)
        Me.cboOriginalVolunteer.TabIndex = 0
        '
        'FrmScheduling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 491)
        Me.Controls.Add(Me.tabScheduling)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmScheduling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scheduling"
        Me.tabScheduling.ResumeLayout(False)
        Me.tabTemplates.ResumeLayout(False)
        Me.tabTemplates.PerformLayout()
        CType(Me.dgvShiftTemplates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAssignments.ResumeLayout(False)
        Me.tabAssignments.PerformLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSubstitutes.ResumeLayout(False)
        Me.tabSubstitutes.PerformLayout()
        CType(Me.dgvSubstitutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabScheduling As TabControl
    Friend WithEvents tabTemplates As TabPage
    Friend WithEvents tabAssignments As TabPage
    Friend WithEvents tabSubstitutes As TabPage
    Friend WithEvents dgvShiftTemplates As DataGridView
    Friend WithEvents btnAddShiftTemplate As Button
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents cboDayOfWeek As ComboBox
    Friend WithEvents lblEndTime As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblDayOfWeek As Label
    Friend WithEvents cboVolunteer As ComboBox
    Friend WithEvents dgvSchedule As DataGridView
    Friend WithEvents btnAssignVolunteer As Button
    Friend WithEvents chkIsSubstitute As CheckBox
    Friend WithEvents cboShiftDay As ComboBox
    Friend WithEvents lblSelectShift As Label
    Friend WithEvents lblSelectVolunteer As Label
    Friend WithEvents cboOriginalVolunteer As ComboBox
    Friend WithEvents dtpCoverageDate As DateTimePicker
    Friend WithEvents cboShiftToReplace As ComboBox
    Friend WithEvents cboSubstituteVolunteer As ComboBox
    Friend WithEvents lblOriginalVoluntee As Label
    Friend WithEvents dgvSubstitutes As DataGridView
    Friend WithEvents btnRecordSubstitute As Button
    Friend WithEvents lblSubstituteDate As Label
    Friend WithEvents lblShiftToReplace As Label
    Friend WithEvents lblSubstituteVolunteer As Label
    Friend WithEvents btnShiftsClose As Button
    Friend WithEvents btnSaveShiftTemplate As Button
End Class
