﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAboutFix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAboutFix))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtRegNum = New System.Windows.Forms.TextBox()
        Me.txtRegName = New System.Windows.Forms.TextBox()
        Me.txtProdOwner = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(240, 34)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(270, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Fix About Information"
        '
        'txtProduct
        '
        Me.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProduct.Location = New System.Drawing.Point(69, 99)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(285, 26)
        Me.txtProduct.TabIndex = 3
        '
        'txtVersion
        '
        Me.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVersion.Location = New System.Drawing.Point(383, 99)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(285, 26)
        Me.txtVersion.TabIndex = 4
        '
        'txtRegNum
        '
        Me.txtRegNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegNum.Location = New System.Drawing.Point(383, 200)
        Me.txtRegNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegNum.Name = "txtRegNum"
        Me.txtRegNum.Size = New System.Drawing.Size(285, 26)
        Me.txtRegNum.TabIndex = 7
        '
        'txtRegName
        '
        Me.txtRegName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegName.Location = New System.Drawing.Point(69, 200)
        Me.txtRegName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegName.Name = "txtRegName"
        Me.txtRegName.Size = New System.Drawing.Size(285, 26)
        Me.txtRegName.TabIndex = 6
        '
        'txtProdOwner
        '
        Me.txtProdOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdOwner.Location = New System.Drawing.Point(246, 151)
        Me.txtProdOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProdOwner.Name = "txtProdOwner"
        Me.txtProdOwner.Size = New System.Drawing.Size(285, 26)
        Me.txtProdOwner.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(69, 249)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(214, 49)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(454, 249)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(214, 49)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmAboutFix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 332)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtProdOwner)
        Me.Controls.Add(Me.txtRegName)
        Me.Controls.Add(Me.txtRegNum)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAboutFix"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Fix"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents txtRegNum As TextBox
    Friend WithEvents txtRegName As TextBox
    Friend WithEvents txtProdOwner As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class