<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProfileUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProfileUpdate))
        Me.btnUSave = New System.Windows.Forms.Button()
        Me.btnUCancel = New System.Windows.Forms.Button()
        Me.cboUType = New System.Windows.Forms.ComboBox()
        Me.txtUPhone = New System.Windows.Forms.TextBox()
        Me.lblUType = New System.Windows.Forms.Label()
        Me.lblUPhone = New System.Windows.Forms.Label()
        Me.cboUState = New System.Windows.Forms.ComboBox()
        Me.txtUZip = New System.Windows.Forms.TextBox()
        Me.txtUCity = New System.Windows.Forms.TextBox()
        Me.lblUZip = New System.Windows.Forms.Label()
        Me.lblUState = New System.Windows.Forms.Label()
        Me.lblUCity = New System.Windows.Forms.Label()
        Me.txtUAddress = New System.Windows.Forms.TextBox()
        Me.lblUAddress = New System.Windows.Forms.Label()
        Me.txtULast = New System.Windows.Forms.TextBox()
        Me.txtUMiddle = New System.Windows.Forms.TextBox()
        Me.txtUFirst = New System.Windows.Forms.TextBox()
        Me.lblULast = New System.Windows.Forms.Label()
        Me.lblUMiddle = New System.Windows.Forms.Label()
        Me.lblUFirst = New System.Windows.Forms.Label()
        Me.txtUPIN = New System.Windows.Forms.TextBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.lblUMatch = New System.Windows.Forms.Label()
        Me.lblUPIN = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRoleName = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUSave
        '
        Me.btnUSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUSave.Location = New System.Drawing.Point(381, 400)
        Me.btnUSave.Name = "btnUSave"
        Me.btnUSave.Size = New System.Drawing.Size(261, 56)
        Me.btnUSave.TabIndex = 15
        Me.btnUSave.Text = "Save"
        Me.btnUSave.UseVisualStyleBackColor = False
        '
        'btnUCancel
        '
        Me.btnUCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUCancel.Location = New System.Drawing.Point(57, 400)
        Me.btnUCancel.Name = "btnUCancel"
        Me.btnUCancel.Size = New System.Drawing.Size(261, 56)
        Me.btnUCancel.TabIndex = 14
        Me.btnUCancel.Text = "Close"
        Me.btnUCancel.UseVisualStyleBackColor = False
        '
        'cboUType
        '
        Me.cboUType.FormattingEnabled = True
        Me.cboUType.Location = New System.Drawing.Point(467, 325)
        Me.cboUType.Name = "cboUType"
        Me.cboUType.Size = New System.Drawing.Size(92, 26)
        Me.cboUType.TabIndex = 13
        '
        'txtUPhone
        '
        Me.txtUPhone.Location = New System.Drawing.Point(117, 325)
        Me.txtUPhone.Name = "txtUPhone"
        Me.txtUPhone.Size = New System.Drawing.Size(219, 26)
        Me.txtUPhone.TabIndex = 12
        '
        'lblUType
        '
        Me.lblUType.AutoSize = True
        Me.lblUType.Location = New System.Drawing.Point(367, 333)
        Me.lblUType.Name = "lblUType"
        Me.lblUType.Size = New System.Drawing.Size(94, 18)
        Me.lblUType.TabIndex = 46
        Me.lblUType.Text = "Phone Type:"
        '
        'lblUPhone
        '
        Me.lblUPhone.AutoSize = True
        Me.lblUPhone.Location = New System.Drawing.Point(54, 333)
        Me.lblUPhone.Name = "lblUPhone"
        Me.lblUPhone.Size = New System.Drawing.Size(57, 18)
        Me.lblUPhone.TabIndex = 44
        Me.lblUPhone.Text = "Phone:"
        '
        'cboUState
        '
        Me.cboUState.FormattingEnabled = True
        Me.cboUState.Location = New System.Drawing.Point(410, 273)
        Me.cboUState.Name = "cboUState"
        Me.cboUState.Size = New System.Drawing.Size(65, 26)
        Me.cboUState.TabIndex = 10
        '
        'txtUZip
        '
        Me.txtUZip.Location = New System.Drawing.Point(542, 273)
        Me.txtUZip.Name = "txtUZip"
        Me.txtUZip.Size = New System.Drawing.Size(100, 26)
        Me.txtUZip.TabIndex = 11
        '
        'txtUCity
        '
        Me.txtUCity.Location = New System.Drawing.Point(117, 273)
        Me.txtUCity.Name = "txtUCity"
        Me.txtUCity.Size = New System.Drawing.Size(219, 26)
        Me.txtUCity.TabIndex = 9
        '
        'lblUZip
        '
        Me.lblUZip.AutoSize = True
        Me.lblUZip.Location = New System.Drawing.Point(495, 281)
        Me.lblUZip.Name = "lblUZip"
        Me.lblUZip.Size = New System.Drawing.Size(34, 18)
        Me.lblUZip.TabIndex = 42
        Me.lblUZip.Text = "Zip:"
        '
        'lblUState
        '
        Me.lblUState.AutoSize = True
        Me.lblUState.Location = New System.Drawing.Point(355, 281)
        Me.lblUState.Name = "lblUState"
        Me.lblUState.Size = New System.Drawing.Size(49, 18)
        Me.lblUState.TabIndex = 40
        Me.lblUState.Text = "State:"
        '
        'lblUCity
        '
        Me.lblUCity.AutoSize = True
        Me.lblUCity.Location = New System.Drawing.Point(72, 281)
        Me.lblUCity.Name = "lblUCity"
        Me.lblUCity.Size = New System.Drawing.Size(39, 18)
        Me.lblUCity.TabIndex = 38
        Me.lblUCity.Text = "City:"
        '
        'txtUAddress
        '
        Me.txtUAddress.Location = New System.Drawing.Point(117, 230)
        Me.txtUAddress.Name = "txtUAddress"
        Me.txtUAddress.Size = New System.Drawing.Size(525, 26)
        Me.txtUAddress.TabIndex = 6
        '
        'lblUAddress
        '
        Me.lblUAddress.AutoSize = True
        Me.lblUAddress.Location = New System.Drawing.Point(40, 238)
        Me.lblUAddress.Name = "lblUAddress"
        Me.lblUAddress.Size = New System.Drawing.Size(71, 18)
        Me.lblUAddress.TabIndex = 36
        Me.lblUAddress.Text = "Address:"
        '
        'txtULast
        '
        Me.txtULast.Location = New System.Drawing.Point(479, 190)
        Me.txtULast.Name = "txtULast"
        Me.txtULast.Size = New System.Drawing.Size(163, 26)
        Me.txtULast.TabIndex = 5
        '
        'txtUMiddle
        '
        Me.txtUMiddle.Location = New System.Drawing.Point(329, 190)
        Me.txtUMiddle.Name = "txtUMiddle"
        Me.txtUMiddle.Size = New System.Drawing.Size(56, 26)
        Me.txtUMiddle.TabIndex = 4
        '
        'txtUFirst
        '
        Me.txtUFirst.Location = New System.Drawing.Point(117, 190)
        Me.txtUFirst.Name = "txtUFirst"
        Me.txtUFirst.Size = New System.Drawing.Size(139, 26)
        Me.txtUFirst.TabIndex = 3
        '
        'lblULast
        '
        Me.lblULast.AutoSize = True
        Me.lblULast.Location = New System.Drawing.Point(419, 198)
        Me.lblULast.Name = "lblULast"
        Me.lblULast.Size = New System.Drawing.Size(42, 18)
        Me.lblULast.TabIndex = 32
        Me.lblULast.Text = "Last:"
        '
        'lblUMiddle
        '
        Me.lblUMiddle.AutoSize = True
        Me.lblUMiddle.Location = New System.Drawing.Point(291, 198)
        Me.lblUMiddle.Name = "lblUMiddle"
        Me.lblUMiddle.Size = New System.Drawing.Size(32, 18)
        Me.lblUMiddle.TabIndex = 31
        Me.lblUMiddle.Text = "M I:"
        '
        'lblUFirst
        '
        Me.lblUFirst.AutoSize = True
        Me.lblUFirst.Location = New System.Drawing.Point(68, 198)
        Me.lblUFirst.Name = "lblUFirst"
        Me.lblUFirst.Size = New System.Drawing.Size(43, 18)
        Me.lblUFirst.TabIndex = 30
        Me.lblUFirst.Text = "First:"
        '
        'txtUPIN
        '
        Me.txtUPIN.Location = New System.Drawing.Point(117, 104)
        Me.txtUPIN.Name = "txtUPIN"
        Me.txtUPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUPIN.Size = New System.Drawing.Size(114, 26)
        Me.txtUPIN.TabIndex = 2
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(117, 63)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(525, 26)
        Me.cboName.TabIndex = 1
        '
        'lblUMatch
        '
        Me.lblUMatch.AutoSize = True
        Me.lblUMatch.Location = New System.Drawing.Point(257, 102)
        Me.lblUMatch.Name = "lblUMatch"
        Me.lblUMatch.Size = New System.Drawing.Size(28, 18)
        Me.lblUMatch.TabIndex = 27
        Me.lblUMatch.Text = "     "
        '
        'lblUPIN
        '
        Me.lblUPIN.AutoSize = True
        Me.lblUPIN.Location = New System.Drawing.Point(74, 112)
        Me.lblUPIN.Name = "lblUPIN"
        Me.lblUPIN.Size = New System.Drawing.Size(37, 18)
        Me.lblUPIN.TabIndex = 26
        Me.lblUPIN.Text = "PIN:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(59, 71)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 18)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblRoleName
        '
        Me.lblRoleName.AutoSize = True
        Me.lblRoleName.Location = New System.Drawing.Point(67, 34)
        Me.lblRoleName.Name = "lblRoleName"
        Me.lblRoleName.Size = New System.Drawing.Size(44, 18)
        Me.lblRoleName.TabIndex = 47
        Me.lblRoleName.Text = "Role:"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(127, 35)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(80, 18)
        Me.lblRole.TabIndex = 48
        Me.lblRole.Text = "                  "
        '
        'FrmProfileUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 491)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblRoleName)
        Me.Controls.Add(Me.btnUSave)
        Me.Controls.Add(Me.btnUCancel)
        Me.Controls.Add(Me.cboUType)
        Me.Controls.Add(Me.txtUPhone)
        Me.Controls.Add(Me.lblUType)
        Me.Controls.Add(Me.lblUPhone)
        Me.Controls.Add(Me.cboUState)
        Me.Controls.Add(Me.txtUZip)
        Me.Controls.Add(Me.txtUCity)
        Me.Controls.Add(Me.lblUZip)
        Me.Controls.Add(Me.lblUState)
        Me.Controls.Add(Me.lblUCity)
        Me.Controls.Add(Me.txtUAddress)
        Me.Controls.Add(Me.lblUAddress)
        Me.Controls.Add(Me.txtULast)
        Me.Controls.Add(Me.txtUMiddle)
        Me.Controls.Add(Me.txtUFirst)
        Me.Controls.Add(Me.lblULast)
        Me.Controls.Add(Me.lblUMiddle)
        Me.Controls.Add(Me.lblUFirst)
        Me.Controls.Add(Me.txtUPIN)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.lblUMatch)
        Me.Controls.Add(Me.lblUPIN)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProfileUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUSave As Button
    Friend WithEvents btnUCancel As Button
    Friend WithEvents cboUType As ComboBox
    Friend WithEvents txtUPhone As TextBox
    Friend WithEvents lblUType As Label
    Friend WithEvents lblUPhone As Label
    Friend WithEvents cboUState As ComboBox
    Friend WithEvents txtUZip As TextBox
    Friend WithEvents txtUCity As TextBox
    Friend WithEvents lblUZip As Label
    Friend WithEvents lblUState As Label
    Friend WithEvents lblUCity As Label
    Friend WithEvents txtUAddress As TextBox
    Friend WithEvents lblUAddress As Label
    Friend WithEvents txtULast As TextBox
    Friend WithEvents txtUMiddle As TextBox
    Friend WithEvents txtUFirst As TextBox
    Friend WithEvents lblULast As Label
    Friend WithEvents lblUMiddle As Label
    Friend WithEvents lblUFirst As Label
    Friend WithEvents txtUPIN As TextBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents lblUMatch As Label
    Friend WithEvents lblUPIN As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblRoleName As Label
    Friend WithEvents lblRole As Label
End Class
