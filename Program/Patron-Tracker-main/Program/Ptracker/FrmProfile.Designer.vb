<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProfile
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProfile))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxPYes = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxPPrint = New System.Windows.Forms.CheckBox()
        Me.cbxPOther = New System.Windows.Forms.CheckBox()
        Me.cbxPIndexing = New System.Windows.Forms.CheckBox()
        Me.cbxPClass = New System.Windows.Forms.CheckBox()
        Me.cbxPWebsite = New System.Windows.Forms.CheckBox()
        Me.cbxPOnline = New System.Windows.Forms.CheckBox()
        Me.txtPPassword = New System.Windows.Forms.TextBox()
        Me.txtPEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPRetype = New System.Windows.Forms.TextBox()
        Me.lblRetype = New System.Windows.Forms.Label()
        Me.lblPFirst = New System.Windows.Forms.Label()
        Me.txtPFirst = New System.Windows.Forms.TextBox()
        Me.lblPMiddle = New System.Windows.Forms.Label()
        Me.txtPLast = New System.Windows.Forms.TextBox()
        Me.lblPLast = New System.Windows.Forms.Label()
        Me.txtPAddress = New System.Windows.Forms.TextBox()
        Me.lblPAddress = New System.Windows.Forms.Label()
        Me.txtPCity = New System.Windows.Forms.TextBox()
        Me.lblPCity = New System.Windows.Forms.Label()
        Me.lblPState = New System.Windows.Forms.Label()
        Me.cboPState = New System.Windows.Forms.ComboBox()
        Me.txtPZip = New System.Windows.Forms.TextBox()
        Me.lblPZip = New System.Windows.Forms.Label()
        Me.rbPYes = New System.Windows.Forms.RadioButton()
        Me.rbPNo = New System.Windows.Forms.RadioButton()
        Me.lblPStake = New System.Windows.Forms.Label()
        Me.lblPWard = New System.Windows.Forms.Label()
        Me.txtPPhone = New System.Windows.Forms.TextBox()
        Me.lblPPhone = New System.Windows.Forms.Label()
        Me.lblPType = New System.Windows.Forms.Label()
        Me.cboPType = New System.Windows.Forms.ComboBox()
        Me.rbPPatron = New System.Windows.Forms.RadioButton()
        Me.rbPStaff = New System.Windows.Forms.RadioButton()
        Me.btnPSave = New System.Windows.Forms.Button()
        Me.cboPStake = New System.Windows.Forms.ComboBox()
        Me.cboPWard = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbPAdmin = New System.Windows.Forms.RadioButton()
        Me.rbPDirector = New System.Windows.Forms.RadioButton()
        Me.txtPMiddle = New System.Windows.Forms.TextBox()
        Me.lblPMatch = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.cbxPEYes = New System.Windows.Forms.CheckBox()
        Me.lblPRegister = New System.Windows.Forms.Label()
        Me.cboPRegister = New System.Windows.Forms.ComboBox()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.lblPIN = New System.Windows.Forms.Label()
        Me.lblPINInfo = New System.Windows.Forms.Label()
        Me.btnPClose = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 18)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Answer ONLY if you are here for the first time."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxPYes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 256)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(586, 33)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Is this your first visit?"
        '
        'cbxPYes
        '
        Me.cbxPYes.AutoSize = True
        Me.cbxPYes.Location = New System.Drawing.Point(174, 0)
        Me.cbxPYes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPYes.Name = "cbxPYes"
        Me.cbxPYes.Size = New System.Drawing.Size(52, 22)
        Me.cbxPYes.TabIndex = 7
        Me.cbxPYes.Text = "Yes"
        Me.cbxPYes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxPPrint)
        Me.GroupBox1.Controls.Add(Me.cbxPOther)
        Me.GroupBox1.Controls.Add(Me.cbxPIndexing)
        Me.GroupBox1.Controls.Add(Me.cbxPClass)
        Me.GroupBox1.Controls.Add(Me.cbxPWebsite)
        Me.GroupBox1.Controls.Add(Me.cbxPOnline)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 297)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(572, 120)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reason for your visit?"
        '
        'cbxPPrint
        '
        Me.cbxPPrint.AutoSize = True
        Me.cbxPPrint.Location = New System.Drawing.Point(63, 38)
        Me.cbxPPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPPrint.Name = "cbxPPrint"
        Me.cbxPPrint.Size = New System.Drawing.Size(96, 22)
        Me.cbxPPrint.TabIndex = 8
        Me.cbxPPrint.Text = "Print FOR"
        Me.cbxPPrint.UseVisualStyleBackColor = True
        '
        'cbxPOther
        '
        Me.cbxPOther.AutoSize = True
        Me.cbxPOther.Location = New System.Drawing.Point(429, 77)
        Me.cbxPOther.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPOther.Name = "cbxPOther"
        Me.cbxPOther.Size = New System.Drawing.Size(65, 22)
        Me.cbxPOther.TabIndex = 13
        Me.cbxPOther.Text = "Other"
        Me.cbxPOther.UseVisualStyleBackColor = True
        '
        'cbxPIndexing
        '
        Me.cbxPIndexing.AutoSize = True
        Me.cbxPIndexing.Location = New System.Drawing.Point(173, 38)
        Me.cbxPIndexing.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPIndexing.Name = "cbxPIndexing"
        Me.cbxPIndexing.Size = New System.Drawing.Size(84, 22)
        Me.cbxPIndexing.TabIndex = 9
        Me.cbxPIndexing.Text = "Indexing"
        Me.cbxPIndexing.UseVisualStyleBackColor = True
        '
        'cbxPClass
        '
        Me.cbxPClass.AutoSize = True
        Me.cbxPClass.Location = New System.Drawing.Point(275, 77)
        Me.cbxPClass.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPClass.Name = "cbxPClass"
        Me.cbxPClass.Size = New System.Drawing.Size(134, 22)
        Me.cbxPClass.TabIndex = 12
        Me.cbxPClass.Text = "Attended Class"
        Me.cbxPClass.UseVisualStyleBackColor = True
        '
        'cbxPWebsite
        '
        Me.cbxPWebsite.AutoSize = True
        Me.cbxPWebsite.Location = New System.Drawing.Point(63, 77)
        Me.cbxPWebsite.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPWebsite.Name = "cbxPWebsite"
        Me.cbxPWebsite.Size = New System.Drawing.Size(184, 22)
        Me.cbxPWebsite.TabIndex = 11
        Me.cbxPWebsite.Text = "Subscription Websites"
        Me.cbxPWebsite.UseVisualStyleBackColor = True
        '
        'cbxPOnline
        '
        Me.cbxPOnline.AutoSize = True
        Me.cbxPOnline.Location = New System.Drawing.Point(271, 38)
        Me.cbxPOnline.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPOnline.Name = "cbxPOnline"
        Me.cbxPOnline.Size = New System.Drawing.Size(142, 22)
        Me.cbxPOnline.TabIndex = 10
        Me.cbxPOnline.Text = "Online Research"
        Me.cbxPOnline.UseVisualStyleBackColor = True
        '
        'txtPPassword
        '
        Me.txtPPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPPassword.Location = New System.Drawing.Point(206, 73)
        Me.txtPPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPPassword.Name = "txtPPassword"
        Me.txtPPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPPassword.Size = New System.Drawing.Size(415, 26)
        Me.txtPPassword.TabIndex = 2
        '
        'txtPEmail
        '
        Me.txtPEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPEmail.Location = New System.Drawing.Point(207, 31)
        Me.txtPEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPEmail.Name = "txtPEmail"
        Me.txtPEmail.Size = New System.Drawing.Size(415, 26)
        Me.txtPEmail.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email:"
        '
        'txtPRetype
        '
        Me.txtPRetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPRetype.Location = New System.Drawing.Point(207, 112)
        Me.txtPRetype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPRetype.Name = "txtPRetype"
        Me.txtPRetype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPRetype.Size = New System.Drawing.Size(415, 26)
        Me.txtPRetype.TabIndex = 3
        '
        'lblRetype
        '
        Me.lblRetype.AutoSize = True
        Me.lblRetype.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetype.ForeColor = System.Drawing.Color.Red
        Me.lblRetype.Location = New System.Drawing.Point(57, 120)
        Me.lblRetype.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRetype.Name = "lblRetype"
        Me.lblRetype.Size = New System.Drawing.Size(141, 18)
        Me.lblRetype.TabIndex = 27
        Me.lblRetype.Text = "Confirm Password:"
        '
        'lblPFirst
        '
        Me.lblPFirst.AutoSize = True
        Me.lblPFirst.Location = New System.Drawing.Point(28, 441)
        Me.lblPFirst.Name = "lblPFirst"
        Me.lblPFirst.Size = New System.Drawing.Size(89, 18)
        Me.lblPFirst.TabIndex = 29
        Me.lblPFirst.Text = "First Name:"
        '
        'txtPFirst
        '
        Me.txtPFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPFirst.Location = New System.Drawing.Point(117, 433)
        Me.txtPFirst.Name = "txtPFirst"
        Me.txtPFirst.Size = New System.Drawing.Size(145, 26)
        Me.txtPFirst.TabIndex = 14
        '
        'lblPMiddle
        '
        Me.lblPMiddle.AutoSize = True
        Me.lblPMiddle.Location = New System.Drawing.Point(289, 441)
        Me.lblPMiddle.Name = "lblPMiddle"
        Me.lblPMiddle.Size = New System.Drawing.Size(32, 18)
        Me.lblPMiddle.TabIndex = 31
        Me.lblPMiddle.Text = "M I:"
        '
        'txtPLast
        '
        Me.txtPLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPLast.Location = New System.Drawing.Point(510, 433)
        Me.txtPLast.Name = "txtPLast"
        Me.txtPLast.Size = New System.Drawing.Size(146, 26)
        Me.txtPLast.TabIndex = 16
        '
        'lblPLast
        '
        Me.lblPLast.AutoSize = True
        Me.lblPLast.Location = New System.Drawing.Point(414, 441)
        Me.lblPLast.Name = "lblPLast"
        Me.lblPLast.Size = New System.Drawing.Size(88, 18)
        Me.lblPLast.TabIndex = 33
        Me.lblPLast.Text = "Last Name:"
        '
        'txtPAddress
        '
        Me.txtPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPAddress.Location = New System.Drawing.Point(117, 484)
        Me.txtPAddress.Name = "txtPAddress"
        Me.txtPAddress.Size = New System.Drawing.Size(361, 26)
        Me.txtPAddress.TabIndex = 17
        '
        'lblPAddress
        '
        Me.lblPAddress.AutoSize = True
        Me.lblPAddress.Location = New System.Drawing.Point(46, 492)
        Me.lblPAddress.Name = "lblPAddress"
        Me.lblPAddress.Size = New System.Drawing.Size(71, 18)
        Me.lblPAddress.TabIndex = 35
        Me.lblPAddress.Text = "Address:"
        '
        'txtPCity
        '
        Me.txtPCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPCity.Location = New System.Drawing.Point(120, 537)
        Me.txtPCity.Name = "txtPCity"
        Me.txtPCity.Size = New System.Drawing.Size(148, 26)
        Me.txtPCity.TabIndex = 18
        '
        'lblPCity
        '
        Me.lblPCity.AutoSize = True
        Me.lblPCity.Location = New System.Drawing.Point(64, 545)
        Me.lblPCity.Name = "lblPCity"
        Me.lblPCity.Size = New System.Drawing.Size(39, 18)
        Me.lblPCity.TabIndex = 37
        Me.lblPCity.Text = "City:"
        '
        'lblPState
        '
        Me.lblPState.AutoSize = True
        Me.lblPState.Location = New System.Drawing.Point(287, 545)
        Me.lblPState.Name = "lblPState"
        Me.lblPState.Size = New System.Drawing.Size(49, 18)
        Me.lblPState.TabIndex = 39
        Me.lblPState.Text = "State:"
        '
        'cboPState
        '
        Me.cboPState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPState.FormattingEnabled = True
        Me.cboPState.Location = New System.Drawing.Point(342, 537)
        Me.cboPState.Name = "cboPState"
        Me.cboPState.Size = New System.Drawing.Size(74, 26)
        Me.cboPState.TabIndex = 19
        '
        'txtPZip
        '
        Me.txtPZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPZip.Location = New System.Drawing.Point(481, 537)
        Me.txtPZip.Name = "txtPZip"
        Me.txtPZip.Size = New System.Drawing.Size(91, 26)
        Me.txtPZip.TabIndex = 20
        '
        'lblPZip
        '
        Me.lblPZip.AutoSize = True
        Me.lblPZip.Location = New System.Drawing.Point(437, 545)
        Me.lblPZip.Name = "lblPZip"
        Me.lblPZip.Size = New System.Drawing.Size(34, 18)
        Me.lblPZip.TabIndex = 41
        Me.lblPZip.Text = "Zip:"
        '
        'rbPYes
        '
        Me.rbPYes.AutoSize = True
        Me.rbPYes.Location = New System.Drawing.Point(139, 0)
        Me.rbPYes.Name = "rbPYes"
        Me.rbPYes.Size = New System.Drawing.Size(51, 22)
        Me.rbPYes.TabIndex = 23
        Me.rbPYes.TabStop = True
        Me.rbPYes.Text = "Yes"
        Me.rbPYes.UseVisualStyleBackColor = True
        '
        'rbPNo
        '
        Me.rbPNo.AutoSize = True
        Me.rbPNo.Location = New System.Drawing.Point(203, 0)
        Me.rbPNo.Name = "rbPNo"
        Me.rbPNo.Size = New System.Drawing.Size(46, 22)
        Me.rbPNo.TabIndex = 24
        Me.rbPNo.TabStop = True
        Me.rbPNo.Text = "No"
        Me.rbPNo.UseVisualStyleBackColor = True
        '
        'lblPStake
        '
        Me.lblPStake.AutoSize = True
        Me.lblPStake.Location = New System.Drawing.Point(43, 743)
        Me.lblPStake.Name = "lblPStake"
        Me.lblPStake.Size = New System.Drawing.Size(53, 18)
        Me.lblPStake.TabIndex = 46
        Me.lblPStake.Text = "Stake:"
        '
        'lblPWard
        '
        Me.lblPWard.AutoSize = True
        Me.lblPWard.Location = New System.Drawing.Point(339, 743)
        Me.lblPWard.Name = "lblPWard"
        Me.lblPWard.Size = New System.Drawing.Size(49, 18)
        Me.lblPWard.TabIndex = 48
        Me.lblPWard.Text = "Ward:"
        '
        'txtPPhone
        '
        Me.txtPPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPPhone.Location = New System.Drawing.Point(120, 589)
        Me.txtPPhone.Name = "txtPPhone"
        Me.txtPPhone.Size = New System.Drawing.Size(148, 26)
        Me.txtPPhone.TabIndex = 21
        '
        'lblPPhone
        '
        Me.lblPPhone.AutoSize = True
        Me.lblPPhone.Location = New System.Drawing.Point(46, 597)
        Me.lblPPhone.Name = "lblPPhone"
        Me.lblPPhone.Size = New System.Drawing.Size(57, 18)
        Me.lblPPhone.TabIndex = 50
        Me.lblPPhone.Text = "Phone:"
        '
        'lblPType
        '
        Me.lblPType.AutoSize = True
        Me.lblPType.Location = New System.Drawing.Point(289, 597)
        Me.lblPType.Name = "lblPType"
        Me.lblPType.Size = New System.Drawing.Size(45, 18)
        Me.lblPType.TabIndex = 52
        Me.lblPType.Text = "Type:"
        '
        'cboPType
        '
        Me.cboPType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboPType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPType.FormattingEnabled = True
        Me.cboPType.Location = New System.Drawing.Point(342, 589)
        Me.cboPType.Name = "cboPType"
        Me.cboPType.Size = New System.Drawing.Size(77, 26)
        Me.cboPType.TabIndex = 22
        '
        'rbPPatron
        '
        Me.rbPPatron.AutoSize = True
        Me.rbPPatron.Location = New System.Drawing.Point(6, 0)
        Me.rbPPatron.Name = "rbPPatron"
        Me.rbPPatron.Size = New System.Drawing.Size(72, 22)
        Me.rbPPatron.TabIndex = 25
        Me.rbPPatron.TabStop = True
        Me.rbPPatron.Text = "Patron"
        Me.rbPPatron.UseVisualStyleBackColor = True
        '
        'rbPStaff
        '
        Me.rbPStaff.AutoSize = True
        Me.rbPStaff.Location = New System.Drawing.Point(99, 0)
        Me.rbPStaff.Name = "rbPStaff"
        Me.rbPStaff.Size = New System.Drawing.Size(58, 22)
        Me.rbPStaff.TabIndex = 26
        Me.rbPStaff.TabStop = True
        Me.rbPStaff.Text = "Staff"
        Me.rbPStaff.UseVisualStyleBackColor = True
        '
        'btnPSave
        '
        Me.btnPSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnPSave.Location = New System.Drawing.Point(381, 789)
        Me.btnPSave.Name = "btnPSave"
        Me.btnPSave.Size = New System.Drawing.Size(214, 39)
        Me.btnPSave.TabIndex = 32
        Me.btnPSave.Text = "Save Profile"
        Me.btnPSave.UseVisualStyleBackColor = False
        '
        'cboPStake
        '
        Me.cboPStake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPStake.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPStake.FormattingEnabled = True
        Me.cboPStake.Location = New System.Drawing.Point(110, 735)
        Me.cboPStake.Name = "cboPStake"
        Me.cboPStake.Size = New System.Drawing.Size(201, 26)
        Me.cboPStake.TabIndex = 29
        '
        'cboPWard
        '
        Me.cboPWard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPWard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPWard.FormattingEnabled = True
        Me.cboPWard.Location = New System.Drawing.Point(394, 735)
        Me.cboPWard.Name = "cboPWard"
        Me.cboPWard.Size = New System.Drawing.Size(201, 26)
        Me.cboPWard.TabIndex = 30
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbPYes)
        Me.GroupBox3.Controls.Add(Me.rbPNo)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 642)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(249, 28)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Are you LDS ?"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbPAdmin)
        Me.GroupBox4.Controls.Add(Me.rbPDirector)
        Me.GroupBox4.Controls.Add(Me.rbPStaff)
        Me.GroupBox4.Controls.Add(Me.rbPPatron)
        Me.GroupBox4.Location = New System.Drawing.Point(150, 685)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(367, 28)
        Me.GroupBox4.TabIndex = 60
        Me.GroupBox4.TabStop = False
        '
        'rbPAdmin
        '
        Me.rbPAdmin.AutoSize = True
        Me.rbPAdmin.Location = New System.Drawing.Point(281, 0)
        Me.rbPAdmin.Name = "rbPAdmin"
        Me.rbPAdmin.Size = New System.Drawing.Size(71, 22)
        Me.rbPAdmin.TabIndex = 28
        Me.rbPAdmin.TabStop = True
        Me.rbPAdmin.Text = "Admin"
        Me.rbPAdmin.UseVisualStyleBackColor = True
        '
        'rbPDirector
        '
        Me.rbPDirector.AutoSize = True
        Me.rbPDirector.Location = New System.Drawing.Point(181, 0)
        Me.rbPDirector.Name = "rbPDirector"
        Me.rbPDirector.Size = New System.Drawing.Size(82, 22)
        Me.rbPDirector.TabIndex = 27
        Me.rbPDirector.TabStop = True
        Me.rbPDirector.Text = "Director"
        Me.rbPDirector.UseVisualStyleBackColor = True
        '
        'txtPMiddle
        '
        Me.txtPMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPMiddle.Location = New System.Drawing.Point(325, 433)
        Me.txtPMiddle.Name = "txtPMiddle"
        Me.txtPMiddle.Size = New System.Drawing.Size(60, 26)
        Me.txtPMiddle.TabIndex = 15
        '
        'lblPMatch
        '
        Me.lblPMatch.AutoSize = True
        Me.lblPMatch.Location = New System.Drawing.Point(642, 98)
        Me.lblPMatch.Name = "lblPMatch"
        Me.lblPMatch.Size = New System.Drawing.Size(24, 18)
        Me.lblPMatch.TabIndex = 61
        Me.lblPMatch.Text = "    "
        '
        'cbxPEYes
        '
        Me.cbxPEYes.AutoSize = True
        Me.cbxPEYes.Location = New System.Drawing.Point(641, 200)
        Me.cbxPEYes.Name = "cbxPEYes"
        Me.cbxPEYes.Size = New System.Drawing.Size(52, 22)
        Me.cbxPEYes.TabIndex = 6
        Me.cbxPEYes.Text = "Yes"
        Me.cbxPEYes.UseVisualStyleBackColor = True
        '
        'lblPRegister
        '
        Me.lblPRegister.AutoSize = True
        Me.lblPRegister.Location = New System.Drawing.Point(84, 202)
        Me.lblPRegister.Name = "lblPRegister"
        Me.lblPRegister.Size = New System.Drawing.Size(93, 18)
        Me.lblPRegister.TabIndex = 63
        Me.lblPRegister.Text = "Register for:"
        '
        'cboPRegister
        '
        Me.cboPRegister.FormattingEnabled = True
        Me.cboPRegister.Location = New System.Drawing.Point(207, 194)
        Me.cboPRegister.Name = "cboPRegister"
        Me.cboPRegister.Size = New System.Drawing.Size(416, 26)
        Me.cboPRegister.TabIndex = 5
        '
        'txtPIN
        '
        Me.txtPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPIN.Location = New System.Drawing.Point(206, 150)
        Me.txtPIN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPIN.Size = New System.Drawing.Size(95, 26)
        Me.txtPIN.TabIndex = 4
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Location = New System.Drawing.Point(161, 158)
        Me.lblPIN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(37, 18)
        Me.lblPIN.TabIndex = 66
        Me.lblPIN.Text = "PIN:"
        '
        'lblPINInfo
        '
        Me.lblPINInfo.AutoSize = True
        Me.lblPINInfo.Location = New System.Drawing.Point(308, 158)
        Me.lblPINInfo.Name = "lblPINInfo"
        Me.lblPINInfo.Size = New System.Drawing.Size(222, 18)
        Me.lblPINInfo.TabIndex = 68
        Me.lblPINInfo.Text = "- Type a PIN, (4 to 6 digits only)"
        '
        'btnPClose
        '
        Me.btnPClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnPClose.Location = New System.Drawing.Point(97, 789)
        Me.btnPClose.Name = "btnPClose"
        Me.btnPClose.Size = New System.Drawing.Size(214, 39)
        Me.btnPClose.TabIndex = 31
        Me.btnPClose.Text = "Close"
        Me.btnPClose.UseVisualStyleBackColor = False
        '
        'FrmProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(704, 855)
        Me.Controls.Add(Me.btnPClose)
        Me.Controls.Add(Me.lblPINInfo)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.cboPRegister)
        Me.Controls.Add(Me.cbxPEYes)
        Me.Controls.Add(Me.lblPRegister)
        Me.Controls.Add(Me.lblPMatch)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cboPWard)
        Me.Controls.Add(Me.cboPStake)
        Me.Controls.Add(Me.btnPSave)
        Me.Controls.Add(Me.cboPType)
        Me.Controls.Add(Me.lblPType)
        Me.Controls.Add(Me.txtPPhone)
        Me.Controls.Add(Me.lblPPhone)
        Me.Controls.Add(Me.lblPWard)
        Me.Controls.Add(Me.lblPStake)
        Me.Controls.Add(Me.txtPZip)
        Me.Controls.Add(Me.lblPZip)
        Me.Controls.Add(Me.cboPState)
        Me.Controls.Add(Me.lblPState)
        Me.Controls.Add(Me.txtPCity)
        Me.Controls.Add(Me.lblPCity)
        Me.Controls.Add(Me.txtPAddress)
        Me.Controls.Add(Me.lblPAddress)
        Me.Controls.Add(Me.txtPLast)
        Me.Controls.Add(Me.lblPLast)
        Me.Controls.Add(Me.txtPMiddle)
        Me.Controls.Add(Me.lblPMiddle)
        Me.Controls.Add(Me.txtPFirst)
        Me.Controls.Add(Me.lblPFirst)
        Me.Controls.Add(Me.txtPRetype)
        Me.Controls.Add(Me.lblRetype)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPPassword)
        Me.Controls.Add(Me.txtPEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbxPYes As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxPPrint As CheckBox
    Friend WithEvents cbxPOther As CheckBox
    Friend WithEvents cbxPIndexing As CheckBox
    Friend WithEvents cbxPClass As CheckBox
    Friend WithEvents cbxPWebsite As CheckBox
    Friend WithEvents cbxPOnline As CheckBox
    Friend WithEvents txtPPassword As TextBox
    Friend WithEvents txtPEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPRetype As TextBox
    Friend WithEvents lblRetype As Label
    Friend WithEvents lblPFirst As Label
    Friend WithEvents txtPFirst As TextBox
    Friend WithEvents lblPMiddle As Label
    Friend WithEvents txtPLast As TextBox
    Friend WithEvents lblPLast As Label
    Friend WithEvents txtPAddress As TextBox
    Friend WithEvents lblPAddress As Label
    Friend WithEvents txtPCity As TextBox
    Friend WithEvents lblPCity As Label
    Friend WithEvents lblPState As Label
    Friend WithEvents cboPState As ComboBox
    Friend WithEvents txtPZip As TextBox
    Friend WithEvents lblPZip As Label
    Friend WithEvents rbPYes As RadioButton
    Friend WithEvents rbPNo As RadioButton
    Friend WithEvents lblPStake As Label
    Friend WithEvents lblPWard As Label
    Friend WithEvents txtPPhone As TextBox
    Friend WithEvents lblPPhone As Label
    Friend WithEvents lblPType As Label
    Friend WithEvents cboPType As ComboBox
    Friend WithEvents rbPPatron As RadioButton
    Friend WithEvents rbPStaff As RadioButton
    Friend WithEvents btnPSave As Button
    Friend WithEvents cboPStake As ComboBox
    Friend WithEvents cboPWard As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbPAdmin As RadioButton
    Friend WithEvents rbPDirector As RadioButton
    Friend WithEvents txtPMiddle As TextBox
    Friend WithEvents lblMatch As Label
    Friend WithEvents lblPMatch As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents typingTimer2 As New Timer
    Friend WithEvents typingTimer3 As New Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents cbxPEYes As CheckBox
    Friend WithEvents lblPRegister As Label
    Friend WithEvents cboPRegister As ComboBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents lblPIN As Label
    Friend WithEvents lblPINInfo As Label
    Friend WithEvents btnPClose As Button
End Class
