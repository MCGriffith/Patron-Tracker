<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddEvent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddEvent))
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.cboEventName = New System.Windows.Forms.ComboBox()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpRegStop = New System.Windows.Forms.DateTimePicker()
        Me.lblRegStop = New System.Windows.Forms.Label()
        Me.dtpRegStart = New System.Windows.Forms.DateTimePicker()
        Me.lblRegStart = New System.Windows.Forms.Label()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnRemoveEvent = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Location = New System.Drawing.Point(62, 45)
        Me.lblEventName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(319, 18)
        Me.lblEventName.TabIndex = 0
        Me.lblEventName.Text = "Enter a New Event or Select one from the list:"
        '
        'cboEventName
        '
        Me.cboEventName.FormattingEnabled = True
        Me.cboEventName.Location = New System.Drawing.Point(389, 37)
        Me.cboEventName.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEventName.Name = "cboEventName"
        Me.cboEventName.Size = New System.Drawing.Size(279, 26)
        Me.cboEventName.TabIndex = 1
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Location = New System.Drawing.Point(230, 89)
        Me.lblEventDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(151, 18)
        Me.lblEventDate.TabIndex = 2
        Me.lblEventDate.Text = "Enter an Event Date:"
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEventDate.Location = New System.Drawing.Point(389, 83)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(279, 26)
        Me.dtpEventDate.TabIndex = 3
        '
        'dtpRegStop
        '
        Me.dtpRegStop.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegStop.Location = New System.Drawing.Point(389, 181)
        Me.dtpRegStop.Name = "dtpRegStop"
        Me.dtpRegStop.Size = New System.Drawing.Size(279, 26)
        Me.dtpRegStop.TabIndex = 7
        '
        'lblRegStop
        '
        Me.lblRegStop.AutoSize = True
        Me.lblRegStop.Location = New System.Drawing.Point(156, 187)
        Me.lblRegStop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegStop.Name = "lblRegStop"
        Me.lblRegStop.Size = New System.Drawing.Size(221, 18)
        Me.lblRegStop.TabIndex = 6
        Me.lblRegStop.Text = "Enter a Registration Stop Date"
        '
        'dtpRegStart
        '
        Me.dtpRegStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegStart.Location = New System.Drawing.Point(389, 130)
        Me.dtpRegStart.Name = "dtpRegStart"
        Me.dtpRegStart.Size = New System.Drawing.Size(279, 26)
        Me.dtpRegStart.TabIndex = 5
        '
        'lblRegStart
        '
        Me.lblRegStart.AutoSize = True
        Me.lblRegStart.Location = New System.Drawing.Point(156, 136)
        Me.lblRegStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegStart.Name = "lblRegStart"
        Me.lblRegStart.Size = New System.Drawing.Size(225, 18)
        Me.lblRegStart.TabIndex = 4
        Me.lblRegStart.Text = "Enter a Registration Start Date:"
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(530, 236)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(138, 37)
        Me.btnSaveEvent.TabIndex = 10
        Me.btnSaveEvent.Text = "Save Event"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'btnRemoveEvent
        '
        Me.btnRemoveEvent.Location = New System.Drawing.Point(375, 236)
        Me.btnRemoveEvent.Name = "btnRemoveEvent"
        Me.btnRemoveEvent.Size = New System.Drawing.Size(138, 37)
        Me.btnRemoveEvent.TabIndex = 9
        Me.btnRemoveEvent.Text = "Remove Event "
        Me.btnRemoveEvent.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(196, 236)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 37)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FrmAddEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 293)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemoveEvent)
        Me.Controls.Add(Me.btnSaveEvent)
        Me.Controls.Add(Me.dtpRegStart)
        Me.Controls.Add(Me.lblRegStart)
        Me.Controls.Add(Me.dtpRegStop)
        Me.Controls.Add(Me.lblRegStop)
        Me.Controls.Add(Me.dtpEventDate)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.cboEventName)
        Me.Controls.Add(Me.lblEventName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAddEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEventName As Label
    Friend WithEvents cboEventName As ComboBox
    Friend WithEvents lblEventDate As Label
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents dtpRegStop As DateTimePicker
    Friend WithEvents lblRegStop As Label
    Friend WithEvents dtpRegStart As DateTimePicker
    Friend WithEvents lblRegStart As Label
    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents btnRemoveEvent As Button
    Friend WithEvents btnClose As Button
End Class
