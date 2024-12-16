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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVolunteer))
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.lblVolunteerSearch = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lviewSkills = New System.Windows.Forms.ListView()
        Me.lblSkills = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cbxInactive = New System.Windows.Forms.CheckBox()
        Me.lblAvailable = New System.Windows.Forms.Label()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.btnManageSchedules = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(188, 39)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(259, 26)
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
        Me.lblMiddleName.Location = New System.Drawing.Point(358, 116)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(28, 18)
        Me.lblMiddleName.TabIndex = 5
        Me.lblMiddleName.Text = "MI:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(469, 116)
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
        Me.txtMiddleName.Location = New System.Drawing.Point(392, 108)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(55, 26)
        Me.txtMiddleName.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(563, 108)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(176, 26)
        Me.txtLastName.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(189, 258)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(135, 26)
        Me.txtPhone.TabIndex = 12
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(125, 266)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(57, 18)
        Me.lblPhone.TabIndex = 13
        Me.lblPhone.Text = "Phone:"
        '
        'lviewSkills
        '
        Me.lviewSkills.HideSelection = False
        Me.lviewSkills.Location = New System.Drawing.Point(186, 373)
        Me.lviewSkills.Name = "lviewSkills"
        Me.lviewSkills.Size = New System.Drawing.Size(551, 147)
        Me.lviewSkills.TabIndex = 14
        Me.lviewSkills.UseCompatibleStateImageBehavior = False
        '
        'lblSkills
        '
        Me.lblSkills.AutoSize = True
        Me.lblSkills.Location = New System.Drawing.Point(131, 373)
        Me.lblSkills.Name = "lblSkills"
        Me.lblSkills.Size = New System.Drawing.Size(49, 18)
        Me.lblSkills.TabIndex = 15
        Me.lblSkills.Text = "Skills:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Location = New System.Drawing.Point(800, 39)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(209, 52)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Location = New System.Drawing.Point(800, 109)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(209, 52)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Location = New System.Drawing.Point(800, 177)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(209, 52)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Activate / Inactivate"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(800, 339)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(209, 52)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(800, 411)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(209, 52)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(111, 162)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(71, 18)
        Me.lblAddress.TabIndex = 21
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(188, 154)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(549, 26)
        Me.txtAddress.TabIndex = 22
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(188, 202)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(183, 26)
        Me.txtCity.TabIndex = 24
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(143, 210)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(39, 18)
        Me.lblCity.TabIndex = 23
        Me.lblCity.Text = "City:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(394, 210)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(49, 18)
        Me.lblState.TabIndex = 25
        Me.lblState.Text = "State:"
        '
        'txtZip
        '
        Me.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZip.Location = New System.Drawing.Point(585, 202)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(152, 26)
        Me.txtZip.TabIndex = 28
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(549, 210)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(34, 18)
        Me.lblZip.TabIndex = 27
        Me.lblZip.Text = "Zip:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(469, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Role:"
        '
        'txtRole
        '
        Me.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRole.Location = New System.Drawing.Point(524, 39)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(100, 26)
        Me.txtRole.TabIndex = 3
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(341, 266)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(45, 18)
        Me.lblType.TabIndex = 30
        Me.lblType.Text = "Type:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(130, 320)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 18)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(188, 312)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(549, 26)
        Me.txtEmail.TabIndex = 11
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(450, 207)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(73, 26)
        Me.cboState.TabIndex = 31
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(402, 258)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(73, 26)
        Me.cboType.TabIndex = 32
        '
        'cbxInactive
        '
        Me.cbxInactive.AutoSize = True
        Me.cbxInactive.Location = New System.Drawing.Point(658, 43)
        Me.cbxInactive.Name = "cbxInactive"
        Me.cbxInactive.Size = New System.Drawing.Size(79, 22)
        Me.cbxInactive.TabIndex = 33
        Me.cbxInactive.Text = "Inactive"
        Me.cbxInactive.UseVisualStyleBackColor = True
        '
        'lblAvailable
        '
        Me.lblAvailable.AutoSize = True
        Me.lblAvailable.Location = New System.Drawing.Point(501, 266)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(82, 18)
        Me.lblAvailable.TabIndex = 34
        Me.lblAvailable.Text = "Avalability:"
        '
        'txtAvailable
        '
        Me.txtAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAvailable.Location = New System.Drawing.Point(585, 258)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.Size = New System.Drawing.Size(152, 26)
        Me.txtAvailable.TabIndex = 35
        '
        'btnManageSchedules
        '
        Me.btnManageSchedules.BackColor = System.Drawing.SystemColors.Control
        Me.btnManageSchedules.Location = New System.Drawing.Point(800, 258)
        Me.btnManageSchedules.Name = "btnManageSchedules"
        Me.btnManageSchedules.Size = New System.Drawing.Size(209, 52)
        Me.btnManageSchedules.TabIndex = 36
        Me.btnManageSchedules.Text = "Manage Schedules"
        Me.btnManageSchedules.UseVisualStyleBackColor = False
        '
        'FrmVolunteer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 570)
        Me.Controls.Add(Me.btnManageSchedules)
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.lblAvailable)
        Me.Controls.Add(Me.cbxInactive)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSkills)
        Me.Controls.Add(Me.lviewSkills)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lviewSkills As ListView
    Friend WithEvents lblSkills As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRole As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents cboState As ComboBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cbxInactive As CheckBox
    Friend WithEvents lblAvailable As Label
    Friend WithEvents txtAvailable As TextBox
    Friend WithEvents btnManageSchedules As Button
End Class
