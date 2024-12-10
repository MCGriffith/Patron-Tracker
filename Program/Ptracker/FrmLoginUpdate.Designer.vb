<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class FrmLoginUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoginUpdate))
        Me.btnSSave = New System.Windows.Forms.Button()
        Me.btnSClose = New System.Windows.Forms.Button()
        Me.txtSPIN = New System.Windows.Forms.TextBox()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.lblSMatch = New System.Windows.Forms.Label()
        Me.lblSPIN = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSPassword = New System.Windows.Forms.Label()
        Me.lblSConfirm = New System.Windows.Forms.Label()
        Me.txtSPassword = New System.Windows.Forms.TextBox()
        Me.txtSConfirm = New System.Windows.Forms.TextBox()
        Me.lblSPMatch = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblRoleName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSSave
        '
        Me.btnSSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSSave.Location = New System.Drawing.Point(419, 279)
        Me.btnSSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSSave.Name = "btnSSave"
        Me.btnSSave.Size = New System.Drawing.Size(191, 47)
        Me.btnSSave.TabIndex = 7
        Me.btnSSave.Text = "Save"
        Me.btnSSave.UseVisualStyleBackColor = False
        '
        'btnSClose
        '
        Me.btnSClose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSClose.Location = New System.Drawing.Point(168, 279)
        Me.btnSClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSClose.Name = "btnSClose"
        Me.btnSClose.Size = New System.Drawing.Size(191, 47)
        Me.btnSClose.TabIndex = 6
        Me.btnSClose.Text = "Close"
        Me.btnSClose.UseVisualStyleBackColor = False
        '
        'txtSPIN
        '
        Me.txtSPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSPIN.Location = New System.Drawing.Point(168, 102)
        Me.txtSPIN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSPIN.Name = "txtSPIN"
        Me.txtSPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSPIN.Size = New System.Drawing.Size(138, 26)
        Me.txtSPIN.TabIndex = 3
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(168, 61)
        Me.cboName.Margin = New System.Windows.Forms.Padding(4)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(442, 26)
        Me.cboName.TabIndex = 2
        '
        'lblSMatch
        '
        Me.lblSMatch.AutoSize = True
        Me.lblSMatch.Location = New System.Drawing.Point(359, 110)
        Me.lblSMatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSMatch.Name = "lblSMatch"
        Me.lblSMatch.Size = New System.Drawing.Size(68, 18)
        Me.lblSMatch.TabIndex = 27
        Me.lblSMatch.Text = "               "
        '
        'lblSPIN
        '
        Me.lblSPIN.AutoSize = True
        Me.lblSPIN.Location = New System.Drawing.Point(123, 110)
        Me.lblSPIN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSPIN.Name = "lblSPIN"
        Me.lblSPIN.Size = New System.Drawing.Size(37, 18)
        Me.lblSPIN.TabIndex = 26
        Me.lblSPIN.Text = "PIN:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(108, 69)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 18)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblSPassword
        '
        Me.lblSPassword.AutoSize = True
        Me.lblSPassword.Location = New System.Drawing.Point(43, 171)
        Me.lblSPassword.Name = "lblSPassword"
        Me.lblSPassword.Size = New System.Drawing.Size(117, 18)
        Me.lblSPassword.TabIndex = 32
        Me.lblSPassword.Text = "New Password:"
        '
        'lblSConfirm
        '
        Me.lblSConfirm.AutoSize = True
        Me.lblSConfirm.Location = New System.Drawing.Point(19, 213)
        Me.lblSConfirm.Name = "lblSConfirm"
        Me.lblSConfirm.Size = New System.Drawing.Size(141, 18)
        Me.lblSConfirm.TabIndex = 33
        Me.lblSConfirm.Text = "Confirm Password:"
        '
        'txtSPassword
        '
        Me.txtSPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSPassword.Location = New System.Drawing.Point(168, 168)
        Me.txtSPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSPassword.Name = "txtSPassword"
        Me.txtSPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSPassword.Size = New System.Drawing.Size(284, 26)
        Me.txtSPassword.TabIndex = 4
        '
        'txtSConfirm
        '
        Me.txtSConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSConfirm.Location = New System.Drawing.Point(168, 210)
        Me.txtSConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSConfirm.Name = "txtSConfirm"
        Me.txtSConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSConfirm.Size = New System.Drawing.Size(284, 26)
        Me.txtSConfirm.TabIndex = 5
        '
        'lblSPMatch
        '
        Me.lblSPMatch.AutoSize = True
        Me.lblSPMatch.Location = New System.Drawing.Point(477, 194)
        Me.lblSPMatch.Name = "lblSPMatch"
        Me.lblSPMatch.Size = New System.Drawing.Size(64, 18)
        Me.lblSPMatch.TabIndex = 36
        Me.lblSPMatch.Text = "              "
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(172, 20)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(68, 18)
        Me.lblRole.TabIndex = 37
        Me.lblRole.Text = "               "
        '
        'lblRoleName
        '
        Me.lblRoleName.AutoSize = True
        Me.lblRoleName.Location = New System.Drawing.Point(116, 20)
        Me.lblRoleName.Name = "lblRoleName"
        Me.lblRoleName.Size = New System.Drawing.Size(44, 18)
        Me.lblRoleName.TabIndex = 38
        Me.lblRoleName.Text = "Role:"
        '
        'FrmLoginUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 387)
        Me.Controls.Add(Me.lblRoleName)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblSPMatch)
        Me.Controls.Add(Me.txtSConfirm)
        Me.Controls.Add(Me.txtSPassword)
        Me.Controls.Add(Me.lblSConfirm)
        Me.Controls.Add(Me.lblSPassword)
        Me.Controls.Add(Me.btnSSave)
        Me.Controls.Add(Me.btnSClose)
        Me.Controls.Add(Me.txtSPIN)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.lblSMatch)
        Me.Controls.Add(Me.lblSPIN)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLoginUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSSave As Button
    Friend WithEvents btnSClose As Button
    Friend WithEvents txtSPIN As TextBox
    Friend WithEvents cboName As ComboBox
    Friend WithEvents lblSMatch As Label
    Friend WithEvents lblSPIN As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSPassword As Label
    Friend WithEvents lblSConfirm As Label
    Friend WithEvents txtSPassword As TextBox
    Friend WithEvents txtSConfirm As TextBox
    Friend WithEvents lblSPMatch As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblRoleName As Label
End Class
