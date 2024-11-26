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
        Me.btnSCancel = New System.Windows.Forms.Button()
        Me.txtSPIN = New System.Windows.Forms.TextBox()
        Me.cboSEmail = New System.Windows.Forms.ComboBox()
        Me.lblSMatch = New System.Windows.Forms.Label()
        Me.lblSPIN = New System.Windows.Forms.Label()
        Me.lblSEmail = New System.Windows.Forms.Label()
        Me.lblSPassword = New System.Windows.Forms.Label()
        Me.lblSConfirm = New System.Windows.Forms.Label()
        Me.txtSPassword = New System.Windows.Forms.TextBox()
        Me.txtSConfirm = New System.Windows.Forms.TextBox()
        Me.lblSPMatch = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSSave
        '
        Me.btnSSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSSave.Location = New System.Drawing.Point(425, 252)
        Me.btnSSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSSave.Name = "btnSSave"
        Me.btnSSave.Size = New System.Drawing.Size(191, 47)
        Me.btnSSave.TabIndex = 7
        Me.btnSSave.Text = "Save"
        Me.btnSSave.UseVisualStyleBackColor = True
        '
        'btnSCancel
        '
        Me.btnSCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSCancel.Location = New System.Drawing.Point(174, 252)
        Me.btnSCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSCancel.Name = "btnSCancel"
        Me.btnSCancel.Size = New System.Drawing.Size(191, 47)
        Me.btnSCancel.TabIndex = 6
        Me.btnSCancel.Text = "Close"
        Me.btnSCancel.UseVisualStyleBackColor = True
        '
        'txtSPIN
        '
        Me.txtSPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSPIN.Location = New System.Drawing.Point(174, 75)
        Me.txtSPIN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSPIN.Name = "txtSPIN"
        Me.txtSPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSPIN.Size = New System.Drawing.Size(138, 26)
        Me.txtSPIN.TabIndex = 3
        '
        'cboSEmail
        '
        Me.cboSEmail.FormattingEnabled = True
        Me.cboSEmail.Location = New System.Drawing.Point(174, 34)
        Me.cboSEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSEmail.Name = "cboSEmail"
        Me.cboSEmail.Size = New System.Drawing.Size(442, 26)
        Me.cboSEmail.TabIndex = 2
        '
        'lblSMatch
        '
        Me.lblSMatch.AutoSize = True
        Me.lblSMatch.Location = New System.Drawing.Point(365, 83)
        Me.lblSMatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSMatch.Name = "lblSMatch"
        Me.lblSMatch.Size = New System.Drawing.Size(68, 18)
        Me.lblSMatch.TabIndex = 27
        Me.lblSMatch.Text = "               "
        '
        'lblSPIN
        '
        Me.lblSPIN.AutoSize = True
        Me.lblSPIN.Location = New System.Drawing.Point(129, 83)
        Me.lblSPIN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSPIN.Name = "lblSPIN"
        Me.lblSPIN.Size = New System.Drawing.Size(37, 18)
        Me.lblSPIN.TabIndex = 26
        Me.lblSPIN.Text = "PIN:"
        '
        'lblSEmail
        '
        Me.lblSEmail.AutoSize = True
        Me.lblSEmail.Location = New System.Drawing.Point(114, 42)
        Me.lblSEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSEmail.Name = "lblSEmail"
        Me.lblSEmail.Size = New System.Drawing.Size(52, 18)
        Me.lblSEmail.TabIndex = 1
        Me.lblSEmail.Text = "Email:"
        '
        'lblSPassword
        '
        Me.lblSPassword.AutoSize = True
        Me.lblSPassword.Location = New System.Drawing.Point(49, 144)
        Me.lblSPassword.Name = "lblSPassword"
        Me.lblSPassword.Size = New System.Drawing.Size(117, 18)
        Me.lblSPassword.TabIndex = 32
        Me.lblSPassword.Text = "New Password:"
        '
        'lblSConfirm
        '
        Me.lblSConfirm.AutoSize = True
        Me.lblSConfirm.Location = New System.Drawing.Point(25, 186)
        Me.lblSConfirm.Name = "lblSConfirm"
        Me.lblSConfirm.Size = New System.Drawing.Size(141, 18)
        Me.lblSConfirm.TabIndex = 33
        Me.lblSConfirm.Text = "Confirm Password:"
        '
        'txtSPassword
        '
        Me.txtSPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSPassword.Location = New System.Drawing.Point(174, 141)
        Me.txtSPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSPassword.Name = "txtSPassword"
        Me.txtSPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSPassword.Size = New System.Drawing.Size(284, 26)
        Me.txtSPassword.TabIndex = 4
        '
        'txtSConfirm
        '
        Me.txtSConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSConfirm.Location = New System.Drawing.Point(174, 183)
        Me.txtSConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSConfirm.Name = "txtSConfirm"
        Me.txtSConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSConfirm.Size = New System.Drawing.Size(284, 26)
        Me.txtSConfirm.TabIndex = 5
        '
        'lblSPMatch
        '
        Me.lblSPMatch.AutoSize = True
        Me.lblSPMatch.Location = New System.Drawing.Point(483, 167)
        Me.lblSPMatch.Name = "lblSPMatch"
        Me.lblSPMatch.Size = New System.Drawing.Size(64, 18)
        Me.lblSPMatch.TabIndex = 36
        Me.lblSPMatch.Text = "              "
        '
        'FrmLoginUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 336)
        Me.Controls.Add(Me.lblSPMatch)
        Me.Controls.Add(Me.txtSConfirm)
        Me.Controls.Add(Me.txtSPassword)
        Me.Controls.Add(Me.lblSConfirm)
        Me.Controls.Add(Me.lblSPassword)
        Me.Controls.Add(Me.btnSSave)
        Me.Controls.Add(Me.btnSCancel)
        Me.Controls.Add(Me.txtSPIN)
        Me.Controls.Add(Me.cboSEmail)
        Me.Controls.Add(Me.lblSMatch)
        Me.Controls.Add(Me.lblSPIN)
        Me.Controls.Add(Me.lblSEmail)
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
    Friend WithEvents btnSCancel As Button
    Friend WithEvents txtSPIN As TextBox
    Friend WithEvents cboSEmail As ComboBox
    Friend WithEvents lblSMatch As Label
    Friend WithEvents lblSPIN As Label
    Friend WithEvents lblSEmail As Label
    Friend WithEvents lblSPassword As Label
    Friend WithEvents lblSConfirm As Label
    Friend WithEvents txtSPassword As TextBox
    Friend WithEvents txtSConfirm As TextBox
    Friend WithEvents lblSPMatch As Label
End Class
