<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbout))
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblRegName = New System.Windows.Forms.Label()
        Me.lblRegNum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.BackColor = System.Drawing.Color.Transparent
        Me.lblProduct.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.Location = New System.Drawing.Point(268, 60)
        Me.lblProduct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(169, 27)
        Me.lblProduct.TabIndex = 2
        Me.lblProduct.Text = "Patron Tracker"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(309, 106)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(87, 18)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Version 1.0"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Location = New System.Drawing.Point(270, 140)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(183, 18)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "© 2024 Michael C Griffith"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Location = New System.Drawing.Point(273, 207)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(164, 34)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblRegName
        '
        Me.lblRegName.AutoSize = True
        Me.lblRegName.BackColor = System.Drawing.Color.Transparent
        Me.lblRegName.Location = New System.Drawing.Point(222, 175)
        Me.lblRegName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegName.Name = "lblRegName"
        Me.lblRegName.Size = New System.Drawing.Size(233, 18)
        Me.lblRegName.TabIndex = 8
        Me.lblRegName.Text = "Denton TX FamilySearch Center"
        '
        'lblRegNum
        '
        Me.lblRegNum.AutoSize = True
        Me.lblRegNum.BackColor = System.Drawing.Color.Transparent
        Me.lblRegNum.Location = New System.Drawing.Point(463, 175)
        Me.lblRegNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegNum.Name = "lblRegNum"
        Me.lblRegNum.Size = New System.Drawing.Size(44, 18)
        Me.lblRegNum.TabIndex = 9
        Me.lblRegNum.Text = "0001"
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(732, 288)
        Me.Controls.Add(Me.lblRegNum)
        Me.Controls.Add(Me.lblRegName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblProduct)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Patron Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblRegName As Label
    Friend WithEvents lblRegNum As Label
End Class
