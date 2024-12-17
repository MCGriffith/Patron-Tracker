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
        PropertyGrid1 = New PropertyGrid()
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
        dgvFields.Location = New Point(66, 185)
        dgvFields.Name = "dgvFields"
        dgvFields.Size = New Size(899, 191)
        dgvFields.TabIndex = 1
        ' 
        ' PropertyGrid1
        ' 
        PropertyGrid1.Location = New Point(66, 32)
        PropertyGrid1.Name = "PropertyGrid1"
        PropertyGrid1.PropertySort = PropertySort.Categorized
        PropertyGrid1.Size = New Size(899, 124)
        PropertyGrid1.TabIndex = 6
        ' 
        ' FrmFieldManager
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 540)
        Controls.Add(PropertyGrid1)
        Controls.Add(dgvFields)
        Controls.Add(cboTables)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "FrmFieldManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Field Manager"
        CType(dgvFields, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cboTables As ComboBox
    Friend WithEvents dgvFields As DataGridView
    Friend WithEvents PropertyGrid1 As PropertyGrid
End Class
