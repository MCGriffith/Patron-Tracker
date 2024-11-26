<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnLogon = New System.Windows.Forms.Button()
        Me.cbxPrint = New System.Windows.Forms.CheckBox()
        Me.cbxIndexing = New System.Windows.Forms.CheckBox()
        Me.cbxOnline = New System.Windows.Forms.CheckBox()
        Me.cbxWebsite = New System.Windows.Forms.CheckBox()
        Me.cbxClass = New System.Windows.Forms.CheckBox()
        Me.cbxOther = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxYes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.cbxEYes = New System.Windows.Forms.CheckBox()
        Me.cboRegister = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(157, 38)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(417, 26)
        Me.txtEmail.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Location = New System.Drawing.Point(157, 80)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(417, 26)
        Me.txtPassword.TabIndex = 2
        '
        'btnCreate
        '
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreate.Location = New System.Drawing.Point(72, 364)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(185, 31)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Create Profile"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnLogon
        '
        Me.btnLogon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogon.Location = New System.Drawing.Point(389, 364)
        Me.btnLogon.Name = "btnLogon"
        Me.btnLogon.Size = New System.Drawing.Size(185, 31)
        Me.btnLogon.TabIndex = 13
        Me.btnLogon.Text = "Login"
        Me.btnLogon.UseVisualStyleBackColor = True
        '
        'cbxPrint
        '
        Me.cbxPrint.AutoSize = True
        Me.cbxPrint.Location = New System.Drawing.Point(30, 33)
        Me.cbxPrint.Name = "cbxPrint"
        Me.cbxPrint.Size = New System.Drawing.Size(96, 22)
        Me.cbxPrint.TabIndex = 6
        Me.cbxPrint.Text = "Print FOR"
        Me.cbxPrint.UseVisualStyleBackColor = True
        '
        'cbxIndexing
        '
        Me.cbxIndexing.AutoSize = True
        Me.cbxIndexing.Location = New System.Drawing.Point(137, 33)
        Me.cbxIndexing.Name = "cbxIndexing"
        Me.cbxIndexing.Size = New System.Drawing.Size(84, 22)
        Me.cbxIndexing.TabIndex = 7
        Me.cbxIndexing.Text = "Indexing"
        Me.cbxIndexing.UseVisualStyleBackColor = True
        '
        'cbxOnline
        '
        Me.cbxOnline.AutoSize = True
        Me.cbxOnline.Location = New System.Drawing.Point(232, 33)
        Me.cbxOnline.Name = "cbxOnline"
        Me.cbxOnline.Size = New System.Drawing.Size(142, 22)
        Me.cbxOnline.TabIndex = 8
        Me.cbxOnline.Text = "Online Research"
        Me.cbxOnline.UseVisualStyleBackColor = True
        '
        'cbxWebsite
        '
        Me.cbxWebsite.AutoSize = True
        Me.cbxWebsite.Location = New System.Drawing.Point(30, 61)
        Me.cbxWebsite.Name = "cbxWebsite"
        Me.cbxWebsite.Size = New System.Drawing.Size(184, 22)
        Me.cbxWebsite.TabIndex = 9
        Me.cbxWebsite.Text = "Subscription Websites"
        Me.cbxWebsite.UseVisualStyleBackColor = True
        '
        'cbxClass
        '
        Me.cbxClass.AutoSize = True
        Me.cbxClass.Location = New System.Drawing.Point(232, 61)
        Me.cbxClass.Name = "cbxClass"
        Me.cbxClass.Size = New System.Drawing.Size(134, 22)
        Me.cbxClass.TabIndex = 10
        Me.cbxClass.Text = "Attended Class"
        Me.cbxClass.UseVisualStyleBackColor = True
        '
        'cbxOther
        '
        Me.cbxOther.AutoSize = True
        Me.cbxOther.Location = New System.Drawing.Point(381, 61)
        Me.cbxOther.Name = "cbxOther"
        Me.cbxOther.Size = New System.Drawing.Size(65, 22)
        Me.cbxOther.TabIndex = 11
        Me.cbxOther.Text = "Other"
        Me.cbxOther.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxPrint)
        Me.GroupBox1.Controls.Add(Me.cbxOther)
        Me.GroupBox1.Controls.Add(Me.cbxIndexing)
        Me.GroupBox1.Controls.Add(Me.cbxClass)
        Me.GroupBox1.Controls.Add(Me.cbxWebsite)
        Me.GroupBox1.Controls.Add(Me.cbxOnline)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 99)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reason for your visit?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxYes)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 35)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Is this your first visit?"
        '
        'cbxYes
        '
        Me.cbxYes.AutoSize = True
        Me.cbxYes.Location = New System.Drawing.Point(169, 0)
        Me.cbxYes.Name = "cbxYes"
        Me.cbxYes.Size = New System.Drawing.Size(52, 22)
        Me.cbxYes.TabIndex = 5
        Me.cbxYes.Text = "Yes"
        Me.cbxYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Answer ONLY if you are here for the first time."
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Location = New System.Drawing.Point(56, 147)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(93, 18)
        Me.lblRegister.TabIndex = 21
        Me.lblRegister.Text = "Register for:"
        '
        'cbxEYes
        '
        Me.cbxEYes.AutoSize = True
        Me.cbxEYes.Location = New System.Drawing.Point(587, 145)
        Me.cbxEYes.Name = "cbxEYes"
        Me.cbxEYes.Size = New System.Drawing.Size(52, 22)
        Me.cbxEYes.TabIndex = 4
        Me.cbxEYes.Text = "Yes"
        Me.cbxEYes.UseVisualStyleBackColor = True
        '
        'cboRegister
        '
        Me.cboRegister.FormattingEnabled = True
        Me.cboRegister.Location = New System.Drawing.Point(155, 139)
        Me.cboRegister.Name = "cboRegister"
        Me.cboRegister.Size = New System.Drawing.Size(416, 26)
        Me.cboRegister.TabIndex = 3
        '
        'FrmLogin
        '
        Me.ClientSize = New System.Drawing.Size(685, 413)
        Me.Controls.Add(Me.cboRegister)
        Me.Controls.Add(Me.cbxEYes)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLogon)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents tvtLoginEmail As TextBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnLogon As Button
    Friend WithEvents cbxPrint As CheckBox
    Friend WithEvents cbxIndexing As CheckBox
    Friend WithEvents cbxOnline As CheckBox
    Friend WithEvents cbxWebsite As CheckBox
    Friend WithEvents cbxClass As CheckBox
    Friend WithEvents cbxOther As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbxYes As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents cbxEYes As CheckBox
    Friend WithEvents cboRegister As ComboBox
End Class
