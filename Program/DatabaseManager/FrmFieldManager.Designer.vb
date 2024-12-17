<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFieldManager
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
        cboTables = New ComboBox()
        dgvFields = New DataGridView()
        PropertyPanel = New PropertyGrid()
        CType(dgvFields, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboTables
        ' 
        cboTables.Dock = DockStyle.Top
        cboTables.FormattingEnabled = True
        cboTables.Location = New Point(0, 0)
        cboTables.Name = "cboTables"
        cboTables.Size = New Size(1029, 26)
        cboTables.TabIndex = 0
        ' 
        ' dgvFields
        ' 
        dgvFields.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFields.Location = New Point(0, 192)
        dgvFields.Name = "dgvFields"
        dgvFields.Size = New Size(1029, 150)
        dgvFields.TabIndex = 1
        ' 
        ' PropertyPanel
        ' 
        PropertyPanel.Location = New Point(56, 45)
        PropertyPanel.Name = "PropertyPanel"
        PropertyPanel.Size = New Size(928, 130)
        PropertyPanel.TabIndex = 2
        ' 
        ' FrmFieldManager
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 540)
        Controls.Add(PropertyPanel)
        Controls.Add(dgvFields)
        Controls.Add(cboTables)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "FrmFieldManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Field Manager"
        CType(dgvFields, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cboTables As ComboBox
    Friend WithEvents dgvFields As DataGridView
    Friend WithEvents PropertyPanel As PropertyGrid
End Class
