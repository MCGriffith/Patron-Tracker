<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmScriptViewer
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
        txtScript = New TextBox()
        btnGenerateScript = New Button()
        btnExecute = New Button()
        btnSaveScript = New Button()
        ButtonPanel = New Panel()
        ButtonPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtScript
        ' 
        txtScript.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtScript.Location = New Point(28, 37)
        txtScript.Multiline = True
        txtScript.Name = "txtScript"
        txtScript.ScrollBars = ScrollBars.Both
        txtScript.Size = New Size(974, 389)
        txtScript.TabIndex = 0
        ' 
        ' btnGenerateScript
        ' 
        btnGenerateScript.Location = New Point(110, 23)
        btnGenerateScript.Name = "btnGenerateScript"
        btnGenerateScript.Size = New Size(150, 45)
        btnGenerateScript.TabIndex = 1
        btnGenerateScript.Text = "Generate Script"
        btnGenerateScript.UseVisualStyleBackColor = True
        ' 
        ' btnExecute
        ' 
        btnExecute.Location = New Point(372, 23)
        btnExecute.Name = "btnExecute"
        btnExecute.Size = New Size(150, 45)
        btnExecute.TabIndex = 2
        btnExecute.Text = "Generate Script"
        btnExecute.UseVisualStyleBackColor = True
        ' 
        ' btnSaveScript
        ' 
        btnSaveScript.Location = New Point(592, 23)
        btnSaveScript.Name = "btnSaveScript"
        btnSaveScript.Size = New Size(150, 45)
        btnSaveScript.TabIndex = 3
        btnSaveScript.Text = "Save Script"
        btnSaveScript.UseVisualStyleBackColor = True
        ' 
        ' ButtonPanel
        ' 
        ButtonPanel.Controls.Add(btnGenerateScript)
        ButtonPanel.Controls.Add(btnSaveScript)
        ButtonPanel.Controls.Add(btnExecute)
        ButtonPanel.Location = New Point(28, 444)
        ButtonPanel.Name = "ButtonPanel"
        ButtonPanel.Size = New Size(974, 84)
        ButtonPanel.TabIndex = 4
        ' 
        ' FrmScriptViewer
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 540)
        Controls.Add(ButtonPanel)
        Controls.Add(txtScript)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "FrmScriptViewer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Script Viewer"
        ButtonPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtScript As TextBox
    Friend WithEvents btnGenerateScript As Button
    Friend WithEvents btnExecute As Button
    Friend WithEvents btnSaveScript As Button
    Friend WithEvents ButtonPanel As Panel
End Class
