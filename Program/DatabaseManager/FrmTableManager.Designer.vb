<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTableManager
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
        dvgTables = New DataGridView()
        btnAddTable = New Button()
        btnDeleteTable = New Button()
        btnSaveChanges = New Button()
        FlowLayoutPanel1 = New Panel()
        CType(dvgTables, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dvgTables
        ' 
        dvgTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dvgTables.Location = New Point(48, 55)
        dvgTables.Name = "dvgTables"
        dvgTables.Size = New Size(926, 263)
        dvgTables.TabIndex = 0
        ' 
        ' btnAddTable
        ' 
        btnAddTable.Location = New Point(167, 10)
        btnAddTable.Name = "btnAddTable"
        btnAddTable.Size = New Size(169, 54)
        btnAddTable.TabIndex = 1
        btnAddTable.Text = "Add Table"
        btnAddTable.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteTable
        ' 
        btnDeleteTable.Location = New Point(383, 10)
        btnDeleteTable.Name = "btnDeleteTable"
        btnDeleteTable.Size = New Size(169, 54)
        btnDeleteTable.TabIndex = 2
        btnDeleteTable.Text = "Delete Table"
        btnDeleteTable.UseVisualStyleBackColor = True
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.Location = New Point(591, 10)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(169, 54)
        btnSaveChanges.TabIndex = 3
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(btnAddTable)
        FlowLayoutPanel1.Controls.Add(btnSaveChanges)
        FlowLayoutPanel1.Controls.Add(btnDeleteTable)
        FlowLayoutPanel1.Location = New Point(48, 373)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(926, 81)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' FrmTableManager
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 540)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(dvgTables)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "FrmTableManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "`"
        CType(dvgTables, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dvgTables As DataGridView
    Friend WithEvents btnAddTable As Button
    Friend WithEvents btnDeleteTable As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents FlowLayoutPanel1 As Panel
End Class
