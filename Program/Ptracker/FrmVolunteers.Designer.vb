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
        Me.VolMgmtTabs = New System.Windows.Forms.TabControl()
        Me.tabSchedule = New System.Windows.Forms.TabPage()
        Me.tabVolunteer = New System.Windows.Forms.TabPage()
        Me.tabSubstitute = New System.Windows.Forms.TabPage()
        Me.tabClosing = New System.Windows.Forms.TabPage()
        Me.tabCalendar = New System.Windows.Forms.TabPage()
        Me.VolMgmtTabs.SuspendLayout()
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
        Me.VolMgmtTabs.Size = New System.Drawing.Size(1238, 500)
        Me.VolMgmtTabs.TabIndex = 0
        '
        'tabSchedule
        '
        Me.tabSchedule.Location = New System.Drawing.Point(4, 27)
        Me.tabSchedule.Name = "tabSchedule"
        Me.tabSchedule.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSchedule.Size = New System.Drawing.Size(1230, 469)
        Me.tabSchedule.TabIndex = 0
        Me.tabSchedule.Text = "Schedule Management"
        Me.tabSchedule.UseVisualStyleBackColor = True
        '
        'tabVolunteer
        '
        Me.tabVolunteer.Location = New System.Drawing.Point(4, 27)
        Me.tabVolunteer.Name = "tabVolunteer"
        Me.tabVolunteer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVolunteer.Size = New System.Drawing.Size(1230, 469)
        Me.tabVolunteer.TabIndex = 1
        Me.tabVolunteer.Text = "Volunteer Assignments"
        Me.tabVolunteer.UseVisualStyleBackColor = True
        '
        'tabSubstitute
        '
        Me.tabSubstitute.Location = New System.Drawing.Point(4, 27)
        Me.tabSubstitute.Name = "tabSubstitute"
        Me.tabSubstitute.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSubstitute.Size = New System.Drawing.Size(1230, 469)
        Me.tabSubstitute.TabIndex = 2
        Me.tabSubstitute.Text = "Substitute Management"
        Me.tabSubstitute.UseVisualStyleBackColor = True
        '
        'tabClosing
        '
        Me.tabClosing.Location = New System.Drawing.Point(4, 27)
        Me.tabClosing.Name = "tabClosing"
        Me.tabClosing.Padding = New System.Windows.Forms.Padding(3)
        Me.tabClosing.Size = New System.Drawing.Size(1230, 469)
        Me.tabClosing.TabIndex = 3
        Me.tabClosing.Text = "Closing Management"
        Me.tabClosing.UseVisualStyleBackColor = True
        '
        'tabCalendar
        '
        Me.tabCalendar.Location = New System.Drawing.Point(4, 27)
        Me.tabCalendar.Name = "tabCalendar"
        Me.tabCalendar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCalendar.Size = New System.Drawing.Size(1230, 469)
        Me.tabCalendar.TabIndex = 4
        Me.tabCalendar.Text = "Calendar View"
        Me.tabCalendar.UseVisualStyleBackColor = True
        '
        'FrmVolunteers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 531)
        Me.Controls.Add(Me.VolMgmtTabs)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmVolunteers"
        Me.Text = "Volunteer Management"
        Me.VolMgmtTabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VolMgmtTabs As TabControl
    Friend WithEvents tabSchedule As TabPage
    Friend WithEvents tabVolunteer As TabPage
    Friend WithEvents tabSubstitute As TabPage
    Friend WithEvents tabClosing As TabPage
    Friend WithEvents tabCalendar As TabPage
End Class
