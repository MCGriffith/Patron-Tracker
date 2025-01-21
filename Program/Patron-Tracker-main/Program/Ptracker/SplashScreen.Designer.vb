<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblRegName = New System.Windows.Forms.Label()
        Me.lblRegNum = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblRoleName = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.BackColor = System.Drawing.Color.Transparent
        Me.lblProduct.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(388, 78)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(338, 55)
        Me.lblProduct.TabIndex = 0
        Me.lblProduct.Text = "Patron Tracker"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(476, 169)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(131, 27)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "Version 1.0"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(407, 221)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(281, 27)
        Me.lblCopyright.TabIndex = 5
        Me.lblCopyright.Text = "© 2024 Michael C Griffith"
        '
        'lblRegName
        '
        Me.lblRegName.AutoSize = True
        Me.lblRegName.BackColor = System.Drawing.Color.Transparent
        Me.lblRegName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegName.Location = New System.Drawing.Point(348, 351)
        Me.lblRegName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegName.Name = "lblRegName"
        Me.lblRegName.Size = New System.Drawing.Size(312, 24)
        Me.lblRegName.TabIndex = 9
        Me.lblRegName.Text = "Denton TX FamilySearch Center"
        '
        'lblRegNum
        '
        Me.lblRegNum.AutoSize = True
        Me.lblRegNum.BackColor = System.Drawing.Color.Transparent
        Me.lblRegNum.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegNum.Location = New System.Drawing.Point(677, 351)
        Me.lblRegNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegNum.Name = "lblRegNum"
        Me.lblRegNum.Size = New System.Drawing.Size(58, 24)
        Me.lblRegNum.TabIndex = 10
        Me.lblRegNum.Text = "0001"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblRoleName
        '
        Me.lblRoleName.AutoSize = True
        Me.lblRoleName.Location = New System.Drawing.Point(395, 444)
        Me.lblRoleName.Name = "lblRoleName"
        Me.lblRoleName.Size = New System.Drawing.Size(168, 18)
        Me.lblRoleName.TabIndex = 11
        Me.lblRoleName.Text = "                                        "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(388, 396)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(309, 33)
        Me.ProgressBar1.TabIndex = 12
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1092, 539)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblRoleName)
        Me.Controls.Add(Me.lblRegNum)
        Me.Controls.Add(Me.lblRegName)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProduct)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProduct As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblRegName As Label
    Friend WithEvents lblRegNum As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblRoleName As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
