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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVolunteer))
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.lblVolunteerSearch = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lviewSkills = New System.Windows.Forms.ListView()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(188, 38)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(335, 26)
        Me.cboName.TabIndex = 0
        '
        'lblVolunteerSearch
        '
        Me.lblVolunteerSearch.AutoSize = True
        Me.lblVolunteerSearch.Location = New System.Drawing.Point(51, 47)
        Me.lblVolunteerSearch.Name = "lblVolunteerSearch"
        Me.lblVolunteerSearch.Size = New System.Drawing.Size(131, 18)
        Me.lblVolunteerSearch.TabIndex = 1
        Me.lblVolunteerSearch.Text = "Volunteer Search:"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(599, 46)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(44, 18)
        Me.lblRole.TabIndex = 2
        Me.lblRole.Text = "Role:"
        '
        'txtRole
        '
        Me.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRole.Location = New System.Drawing.Point(654, 39)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(100, 26)
        Me.txtRole.TabIndex = 3
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(93, 116)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(89, 18)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name:"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(375, 116)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(28, 18)
        Me.lblMiddleName.TabIndex = 5
        Me.lblMiddleName.Text = "MI:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(480, 116)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(88, 18)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Location = New System.Drawing.Point(188, 108)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(153, 26)
        Me.txtFirstName.TabIndex = 7
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleName.Location = New System.Drawing.Point(409, 108)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(55, 26)
        Me.txtMiddleName.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(579, 108)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(176, 26)
        Me.txtLastName.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(130, 164)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 18)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(188, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 26)
        Me.TextBox1.TabIndex = 11
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(602, 156)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(153, 26)
        Me.txtPhone.TabIndex = 12
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(538, 164)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(57, 18)
        Me.lblPhone.TabIndex = 13
        Me.lblPhone.Text = "Phone:"
        '
        'lviewSkills
        '
        Me.lviewSkills.HideSelection = False
        Me.lviewSkills.Location = New System.Drawing.Point(184, 225)
        Me.lviewSkills.Name = "lviewSkills"
        Me.lviewSkills.Size = New System.Drawing.Size(570, 147)
        Me.lviewSkills.TabIndex = 14
        Me.lviewSkills.UseCompatibleStateImageBehavior = False
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Location = New System.Drawing.Point(129, 225)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(49, 18)
        Me.lblSkills.TabIndex = 15
        Me.lblSkills.Text = "Skills:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Location = New System.Drawing.Point(789, 38)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(209, 52)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Location = New System.Drawing.Point(789, 108)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(209, 52)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(789, 176)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(209, 52)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(789, 249)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(209, 52)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(789, 320)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(209, 52)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FrmVolunteer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 431)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.lviewSkills)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblVolunteerSearch)
        Me.Controls.Add(Me.cboName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVolunteer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volunteers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboName As ComboBox
    Friend WithEvents lblVolunteerSearch As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents txtRole As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lviewSkills As ListView
    Friend WithEvents lblSkills As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
