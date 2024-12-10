<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttendanceAnalytics
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cboDateRange = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.cbxOther = New System.Windows.Forms.CheckBox()
        Me.cbxAttendClass = New System.Windows.Forms.CheckBox()
        Me.cbxSubWebsite = New System.Windows.Forms.CheckBox()
        Me.cbxOnlineRsrch = New System.Windows.Forms.CheckBox()
        Me.cbxIndexing = New System.Windows.Forms.CheckBox()
        Me.cbxPrintFOR = New System.Windows.Forms.CheckBox()
        Me.cbxFirstVisit = New System.Windows.Forms.CheckBox()
        Me.cbxPeople = New System.Windows.Forms.CheckBox()
        Me.cboExport = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chartAttendance = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblDateRange = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblExport = New System.Windows.Forms.Label()
        Me.grpFilters.SuspendLayout()
        CType(Me.chartAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDateRange
        '
        Me.cboDateRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDateRange.DropDownWidth = 121
        Me.cboDateRange.FormattingEnabled = True
        Me.cboDateRange.Location = New System.Drawing.Point(141, 32)
        Me.cboDateRange.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDateRange.Name = "cboDateRange"
        Me.cboDateRange.Size = New System.Drawing.Size(248, 26)
        Me.cboDateRange.TabIndex = 0
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(113, 116)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(124, 26)
        Me.dtpStartDate.TabIndex = 1
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(286, 116)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(124, 26)
        Me.dtpEndDate.TabIndex = 2
        '
        'grpFilters
        '
        Me.grpFilters.BackColor = System.Drawing.SystemColors.Control
        Me.grpFilters.Controls.Add(Me.cbxOther)
        Me.grpFilters.Controls.Add(Me.cbxAttendClass)
        Me.grpFilters.Controls.Add(Me.cbxSubWebsite)
        Me.grpFilters.Controls.Add(Me.cbxOnlineRsrch)
        Me.grpFilters.Controls.Add(Me.cbxIndexing)
        Me.grpFilters.Controls.Add(Me.cbxPrintFOR)
        Me.grpFilters.Controls.Add(Me.cbxFirstVisit)
        Me.grpFilters.Controls.Add(Me.cbxPeople)
        Me.grpFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpFilters.Location = New System.Drawing.Point(141, 163)
        Me.grpFilters.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFilters.Size = New System.Drawing.Size(219, 292)
        Me.grpFilters.TabIndex = 3
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Filters"
        '
        'cbxOther
        '
        Me.cbxOther.AutoSize = True
        Me.cbxOther.Location = New System.Drawing.Point(22, 240)
        Me.cbxOther.Name = "cbxOther"
        Me.cbxOther.Size = New System.Drawing.Size(65, 22)
        Me.cbxOther.TabIndex = 7
        Me.cbxOther.Text = "Other"
        Me.cbxOther.UseVisualStyleBackColor = True
        '
        'cbxAttendClass
        '
        Me.cbxAttendClass.AutoSize = True
        Me.cbxAttendClass.Location = New System.Drawing.Point(22, 212)
        Me.cbxAttendClass.Name = "cbxAttendClass"
        Me.cbxAttendClass.Size = New System.Drawing.Size(116, 22)
        Me.cbxAttendClass.TabIndex = 6
        Me.cbxAttendClass.Text = "Attend Class"
        Me.cbxAttendClass.UseVisualStyleBackColor = True
        '
        'cbxSubWebsite
        '
        Me.cbxSubWebsite.AutoSize = True
        Me.cbxSubWebsite.Location = New System.Drawing.Point(22, 184)
        Me.cbxSubWebsite.Name = "cbxSubWebsite"
        Me.cbxSubWebsite.Size = New System.Drawing.Size(184, 22)
        Me.cbxSubWebsite.TabIndex = 5
        Me.cbxSubWebsite.Text = "Subscription Websites"
        Me.cbxSubWebsite.UseVisualStyleBackColor = True
        '
        'cbxOnlineRsrch
        '
        Me.cbxOnlineRsrch.AutoSize = True
        Me.cbxOnlineRsrch.Location = New System.Drawing.Point(22, 156)
        Me.cbxOnlineRsrch.Name = "cbxOnlineRsrch"
        Me.cbxOnlineRsrch.Size = New System.Drawing.Size(142, 22)
        Me.cbxOnlineRsrch.TabIndex = 4
        Me.cbxOnlineRsrch.Text = "Online Research"
        Me.cbxOnlineRsrch.UseVisualStyleBackColor = True
        '
        'cbxIndexing
        '
        Me.cbxIndexing.AutoSize = True
        Me.cbxIndexing.Location = New System.Drawing.Point(22, 128)
        Me.cbxIndexing.Name = "cbxIndexing"
        Me.cbxIndexing.Size = New System.Drawing.Size(84, 22)
        Me.cbxIndexing.TabIndex = 3
        Me.cbxIndexing.Text = "Indexing"
        Me.cbxIndexing.UseVisualStyleBackColor = True
        '
        'cbxPrintFOR
        '
        Me.cbxPrintFOR.AutoSize = True
        Me.cbxPrintFOR.Location = New System.Drawing.Point(22, 100)
        Me.cbxPrintFOR.Name = "cbxPrintFOR"
        Me.cbxPrintFOR.Size = New System.Drawing.Size(96, 22)
        Me.cbxPrintFOR.TabIndex = 2
        Me.cbxPrintFOR.Text = "Print FOR"
        Me.cbxPrintFOR.UseVisualStyleBackColor = True
        '
        'cbxFirstVisit
        '
        Me.cbxFirstVisit.AutoSize = True
        Me.cbxFirstVisit.Location = New System.Drawing.Point(22, 72)
        Me.cbxFirstVisit.Name = "cbxFirstVisit"
        Me.cbxFirstVisit.Size = New System.Drawing.Size(93, 22)
        Me.cbxFirstVisit.TabIndex = 1
        Me.cbxFirstVisit.Text = "First Visit"
        Me.cbxFirstVisit.UseVisualStyleBackColor = True
        '
        'cbxPeople
        '
        Me.cbxPeople.AutoSize = True
        Me.cbxPeople.Location = New System.Drawing.Point(22, 44)
        Me.cbxPeople.Name = "cbxPeople"
        Me.cbxPeople.Size = New System.Drawing.Size(77, 22)
        Me.cbxPeople.TabIndex = 0
        Me.cbxPeople.Text = "People"
        Me.cbxPeople.UseVisualStyleBackColor = True
        '
        'cboExport
        '
        Me.cboExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExport.FormattingEnabled = True
        Me.cboExport.Location = New System.Drawing.Point(558, 497)
        Me.cboExport.Name = "cboExport"
        Me.cboExport.Size = New System.Drawing.Size(121, 26)
        Me.cboExport.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Location = New System.Drawing.Point(700, 489)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(108, 40)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(879, 489)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 40)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(1038, 489)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 40)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'chartAttendance
        '
        Me.chartAttendance.BorderlineColor = System.Drawing.Color.Black
        ChartArea2.Name = "ChartArea1"
        Me.chartAttendance.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartAttendance.Legends.Add(Legend2)
        Me.chartAttendance.Location = New System.Drawing.Point(444, 40)
        Me.chartAttendance.Name = "chartAttendance"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartAttendance.Series.Add(Series2)
        Me.chartAttendance.Size = New System.Drawing.Size(760, 415)
        Me.chartAttendance.TabIndex = 9
        Me.chartAttendance.Text = "Chart1"
        '
        'lblDateRange
        '
        Me.lblDateRange.AutoSize = True
        Me.lblDateRange.Location = New System.Drawing.Point(34, 40)
        Me.lblDateRange.Name = "lblDateRange"
        Me.lblDateRange.Size = New System.Drawing.Size(92, 18)
        Me.lblDateRange.TabIndex = 10
        Me.lblDateRange.Text = "Date Range"
        '
        'lblStartDate
        '
        Me.lblStartDate.AutoSize = True
        Me.lblStartDate.Location = New System.Drawing.Point(138, 85)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(79, 18)
        Me.lblStartDate.TabIndex = 11
        Me.lblStartDate.Text = "Start Date"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(315, 85)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(74, 18)
        Me.lblEndDate.TabIndex = 12
        Me.lblEndDate.Text = "End Date"
        '
        'lblExport
        '
        Me.lblExport.AutoSize = True
        Me.lblExport.Location = New System.Drawing.Point(480, 500)
        Me.lblExport.Name = "lblExport"
        Me.lblExport.Size = New System.Drawing.Size(53, 18)
        Me.lblExport.TabIndex = 13
        Me.lblExport.Text = "Export"
        '
        'FrmAttendanceAnalytics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 557)
        Me.Controls.Add(Me.lblExport)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblStartDate)
        Me.Controls.Add(Me.lblDateRange)
        Me.Controls.Add(Me.chartAttendance)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cboExport)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.cboDateRange)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAttendanceAnalytics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Analytics"
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        CType(Me.chartAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDateRange As ComboBox
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents cbxOther As CheckBox
    Friend WithEvents cbxAttendClass As CheckBox
    Friend WithEvents cbxSubWebsite As CheckBox
    Friend WithEvents cbxOnlineRsrch As CheckBox
    Friend WithEvents cbxIndexing As CheckBox
    Friend WithEvents cbxPrintFOR As CheckBox
    Friend WithEvents cbxFirstVisit As CheckBox
    Friend WithEvents cbxPeople As CheckBox
    Friend WithEvents cboExport As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents chartAttendance As DataVisualization.Charting.Chart
    Friend WithEvents lblDateRange As Label
    Friend WithEvents lblStartDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblExport As Label
End Class
