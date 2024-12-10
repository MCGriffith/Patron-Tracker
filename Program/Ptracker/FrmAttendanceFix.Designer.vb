<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttendanceFix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAttendanceFix))
        Me.btnASave = New System.Windows.Forms.Button()
        Me.btnACancel = New System.Windows.Forms.Button()
        Me.cboAName = New System.Windows.Forms.ComboBox()
        Me.lblAName = New System.Windows.Forms.Label()
        Me.grpAFirst = New System.Windows.Forms.GroupBox()
        Me.cbxAYes = New System.Windows.Forms.CheckBox()
        Me.lblAAnswer = New System.Windows.Forms.Label()
        Me.grpAReason = New System.Windows.Forms.GroupBox()
        Me.cbxAPrint = New System.Windows.Forms.CheckBox()
        Me.cbxAOther = New System.Windows.Forms.CheckBox()
        Me.cbxAIndexing = New System.Windows.Forms.CheckBox()
        Me.cbxAClass = New System.Windows.Forms.CheckBox()
        Me.cbxAWebsite = New System.Windows.Forms.CheckBox()
        Me.cbxAOnline = New System.Windows.Forms.CheckBox()
        Me.lblADate = New System.Windows.Forms.Label()
        Me.dtpADate = New System.Windows.Forms.DateTimePicker()
        Me.grpAFirst.SuspendLayout()
        Me.grpAReason.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnASave
        '
        Me.btnASave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnASave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnASave.Location = New System.Drawing.Point(403, 310)
        Me.btnASave.Name = "btnASave"
        Me.btnASave.Size = New System.Drawing.Size(261, 56)
        Me.btnASave.TabIndex = 12
        Me.btnASave.Text = "Save"
        Me.btnASave.UseVisualStyleBackColor = False
        '
        'btnACancel
        '
        Me.btnACancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnACancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnACancel.Location = New System.Drawing.Point(79, 310)
        Me.btnACancel.Name = "btnACancel"
        Me.btnACancel.Size = New System.Drawing.Size(261, 56)
        Me.btnACancel.TabIndex = 11
        Me.btnACancel.Text = "Close"
        Me.btnACancel.UseVisualStyleBackColor = False
        '
        'cboAName
        '
        Me.cboAName.FormattingEnabled = True
        Me.cboAName.Location = New System.Drawing.Point(145, 35)
        Me.cboAName.Name = "cboAName"
        Me.cboAName.Size = New System.Drawing.Size(525, 26)
        Me.cboAName.TabIndex = 2
        '
        'lblAName
        '
        Me.lblAName.AutoSize = True
        Me.lblAName.Location = New System.Drawing.Point(79, 43)
        Me.lblAName.Name = "lblAName"
        Me.lblAName.Size = New System.Drawing.Size(54, 18)
        Me.lblAName.TabIndex = 1
        Me.lblAName.Text = "Name:"
        '
        'grpAFirst
        '
        Me.grpAFirst.Controls.Add(Me.cbxAYes)
        Me.grpAFirst.Controls.Add(Me.lblAAnswer)
        Me.grpAFirst.Location = New System.Drawing.Point(82, 126)
        Me.grpAFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAFirst.Name = "grpAFirst"
        Me.grpAFirst.Padding = New System.Windows.Forms.Padding(4)
        Me.grpAFirst.Size = New System.Drawing.Size(586, 33)
        Me.grpAFirst.TabIndex = 73
        Me.grpAFirst.TabStop = False
        Me.grpAFirst.Text = "Is this your first visit?"
        '
        'cbxAYes
        '
        Me.cbxAYes.AutoSize = True
        Me.cbxAYes.Location = New System.Drawing.Point(174, 0)
        Me.cbxAYes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAYes.Name = "cbxAYes"
        Me.cbxAYes.Size = New System.Drawing.Size(52, 22)
        Me.cbxAYes.TabIndex = 4
        Me.cbxAYes.Text = "Yes"
        Me.cbxAYes.UseVisualStyleBackColor = True
        '
        'lblAAnswer
        '
        Me.lblAAnswer.AutoSize = True
        Me.lblAAnswer.Location = New System.Drawing.Point(235, 0)
        Me.lblAAnswer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAAnswer.Name = "lblAAnswer"
        Me.lblAAnswer.Size = New System.Drawing.Size(320, 18)
        Me.lblAAnswer.TabIndex = 21
        Me.lblAAnswer.Text = "Answer ONLY if you are here for the first time."
        '
        'grpAReason
        '
        Me.grpAReason.Controls.Add(Me.cbxAPrint)
        Me.grpAReason.Controls.Add(Me.cbxAOther)
        Me.grpAReason.Controls.Add(Me.cbxAIndexing)
        Me.grpAReason.Controls.Add(Me.cbxAClass)
        Me.grpAReason.Controls.Add(Me.cbxAWebsite)
        Me.grpAReason.Controls.Add(Me.cbxAOnline)
        Me.grpAReason.Location = New System.Drawing.Point(82, 167)
        Me.grpAReason.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAReason.Name = "grpAReason"
        Me.grpAReason.Padding = New System.Windows.Forms.Padding(4)
        Me.grpAReason.Size = New System.Drawing.Size(586, 120)
        Me.grpAReason.TabIndex = 72
        Me.grpAReason.TabStop = False
        Me.grpAReason.Text = "Reason for your visit?"
        '
        'cbxAPrint
        '
        Me.cbxAPrint.AutoSize = True
        Me.cbxAPrint.Location = New System.Drawing.Point(63, 37)
        Me.cbxAPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAPrint.Name = "cbxAPrint"
        Me.cbxAPrint.Size = New System.Drawing.Size(96, 22)
        Me.cbxAPrint.TabIndex = 5
        Me.cbxAPrint.Text = "Print FOR"
        Me.cbxAPrint.UseVisualStyleBackColor = True
        '
        'cbxAOther
        '
        Me.cbxAOther.AutoSize = True
        Me.cbxAOther.Location = New System.Drawing.Point(429, 76)
        Me.cbxAOther.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAOther.Name = "cbxAOther"
        Me.cbxAOther.Size = New System.Drawing.Size(65, 22)
        Me.cbxAOther.TabIndex = 10
        Me.cbxAOther.Text = "Other"
        Me.cbxAOther.UseVisualStyleBackColor = True
        '
        'cbxAIndexing
        '
        Me.cbxAIndexing.AutoSize = True
        Me.cbxAIndexing.Location = New System.Drawing.Point(173, 37)
        Me.cbxAIndexing.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAIndexing.Name = "cbxAIndexing"
        Me.cbxAIndexing.Size = New System.Drawing.Size(84, 22)
        Me.cbxAIndexing.TabIndex = 6
        Me.cbxAIndexing.Text = "Indexing"
        Me.cbxAIndexing.UseVisualStyleBackColor = True
        '
        'cbxAClass
        '
        Me.cbxAClass.AutoSize = True
        Me.cbxAClass.Location = New System.Drawing.Point(275, 76)
        Me.cbxAClass.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAClass.Name = "cbxAClass"
        Me.cbxAClass.Size = New System.Drawing.Size(134, 22)
        Me.cbxAClass.TabIndex = 9
        Me.cbxAClass.Text = "Attended Class"
        Me.cbxAClass.UseVisualStyleBackColor = True
        '
        'cbxAWebsite
        '
        Me.cbxAWebsite.AutoSize = True
        Me.cbxAWebsite.Location = New System.Drawing.Point(63, 76)
        Me.cbxAWebsite.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAWebsite.Name = "cbxAWebsite"
        Me.cbxAWebsite.Size = New System.Drawing.Size(184, 22)
        Me.cbxAWebsite.TabIndex = 8
        Me.cbxAWebsite.Text = "Subscription Websites"
        Me.cbxAWebsite.UseVisualStyleBackColor = True
        '
        'cbxAOnline
        '
        Me.cbxAOnline.AutoSize = True
        Me.cbxAOnline.Location = New System.Drawing.Point(271, 37)
        Me.cbxAOnline.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAOnline.Name = "cbxAOnline"
        Me.cbxAOnline.Size = New System.Drawing.Size(142, 22)
        Me.cbxAOnline.TabIndex = 7
        Me.cbxAOnline.Text = "Online Research"
        Me.cbxAOnline.UseVisualStyleBackColor = True
        '
        'lblADate
        '
        Me.lblADate.AutoSize = True
        Me.lblADate.Location = New System.Drawing.Point(79, 86)
        Me.lblADate.Name = "lblADate"
        Me.lblADate.Size = New System.Drawing.Size(101, 18)
        Me.lblADate.TabIndex = 74
        Me.lblADate.Text = "Record Date:"
        '
        'dtpADate
        '
        Me.dtpADate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpADate.Location = New System.Drawing.Point(203, 78)
        Me.dtpADate.Name = "dtpADate"
        Me.dtpADate.Size = New System.Drawing.Size(156, 26)
        Me.dtpADate.TabIndex = 3
        '
        'FrmAttendanceFix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 405)
        Me.Controls.Add(Me.dtpADate)
        Me.Controls.Add(Me.lblADate)
        Me.Controls.Add(Me.grpAFirst)
        Me.Controls.Add(Me.grpAReason)
        Me.Controls.Add(Me.btnASave)
        Me.Controls.Add(Me.btnACancel)
        Me.Controls.Add(Me.cboAName)
        Me.Controls.Add(Me.lblAName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAttendanceFix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fix Attendance"
        Me.grpAFirst.ResumeLayout(False)
        Me.grpAFirst.PerformLayout()
        Me.grpAReason.ResumeLayout(False)
        Me.grpAReason.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnASave As Button
    Friend WithEvents btnACancel As Button
    Friend WithEvents cboAName As ComboBox
    Friend WithEvents lblAName As Label
    Friend WithEvents grpAFirst As GroupBox
    Friend WithEvents cbxAYes As CheckBox
    Friend WithEvents lblAAnswer As Label
    Friend WithEvents grpAReason As GroupBox
    Friend WithEvents cbxAPrint As CheckBox
    Friend WithEvents cbxAOther As CheckBox
    Friend WithEvents cbxAIndexing As CheckBox
    Friend WithEvents cbxAClass As CheckBox
    Friend WithEvents cbxAWebsite As CheckBox
    Friend WithEvents cbxAOnline As CheckBox
    Friend WithEvents lblADate As Label
    Friend WithEvents dtpADate As DateTimePicker
End Class
