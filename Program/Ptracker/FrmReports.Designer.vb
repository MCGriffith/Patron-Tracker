<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReports))
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.cboReport = New System.Windows.Forms.ComboBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cboEvent = New System.Windows.Forms.ComboBox()
        Me.cboEventType = New System.Windows.Forms.ComboBox()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.cboDates = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(1049, 119)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(119, 26)
        Me.dtpEndDate.TabIndex = 6
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(47, 128)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(240, 54)
        Me.btnGenerate.TabIndex = 7
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(333, 165)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(835, 410)
        Me.WebBrowser1.TabIndex = 11
        '
        'cboReport
        '
        Me.cboReport.FormattingEnabled = True
        Me.cboReport.Location = New System.Drawing.Point(416, 32)
        Me.cboReport.Name = "cboReport"
        Me.cboReport.Size = New System.Drawing.Size(752, 26)
        Me.cboReport.TabIndex = 2
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(47, 46)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(240, 54)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select Report/Event"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(47, 521)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(240, 54)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(47, 303)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(240, 54)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save Report"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(47, 212)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(240, 54)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboEvent
        '
        Me.cboEvent.FormattingEnabled = True
        Me.cboEvent.Location = New System.Drawing.Point(416, 74)
        Me.cboEvent.Name = "cboEvent"
        Me.cboEvent.Size = New System.Drawing.Size(752, 26)
        Me.cboEvent.TabIndex = 3
        '
        'cboEventType
        '
        Me.cboEventType.FormattingEnabled = True
        Me.cboEventType.Location = New System.Drawing.Point(416, 119)
        Me.cboEventType.Name = "cboEventType"
        Me.cboEventType.Size = New System.Drawing.Size(168, 26)
        Me.cboEventType.TabIndex = 4
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.Location = New System.Drawing.Point(345, 40)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(59, 18)
        Me.lblReport.TabIndex = 11
        Me.lblReport.Text = "Report:"
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Location = New System.Drawing.Point(353, 77)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(51, 18)
        Me.lblEvent.TabIndex = 12
        Me.lblEvent.Text = "Event:"
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Location = New System.Drawing.Point(997, 127)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(45, 18)
        Me.lblStop.TabIndex = 15
        Me.lblStop.Text = "Stop:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(860, 119)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(123, 26)
        Me.dtpStartDate.TabIndex = 5
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(365, 127)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(45, 18)
        Me.lblType.TabIndex = 13
        Me.lblType.Text = "Type:"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(808, 127)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(45, 18)
        Me.lblStart.TabIndex = 14
        Me.lblStart.Text = "Start:"
        '
        'cboDates
        '
        Me.cboDates.FormattingEnabled = True
        Me.cboDates.Location = New System.Drawing.Point(609, 119)
        Me.cboDates.Name = "cboDates"
        Me.cboDates.Size = New System.Drawing.Size(183, 26)
        Me.cboDates.TabIndex = 16
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 606)
        Me.Controls.Add(Me.cboDates)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.cboEventType)
        Me.Controls.Add(Me.cboEvent)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cboReport)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents cboReport As ComboBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents cboEvent As ComboBox
    Friend WithEvents cboEventType As ComboBox
    Friend WithEvents lblReport As Label
    Friend WithEvents lblEvent As Label
    Friend WithEvents lblStop As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblType As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents cboDates As ComboBox
End Class
