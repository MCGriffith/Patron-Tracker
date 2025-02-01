<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelationManager
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
        Me.grpPrimary = New System.Windows.Forms.GroupBox()
        Me.lstFieldsPrimary = New System.Windows.Forms.ListBox()
        Me.cboTablePrimary = New System.Windows.Forms.ComboBox()
        Me.grpForeign = New System.Windows.Forms.GroupBox()
        Me.lstFieldsForeign = New System.Windows.Forms.ListBox()
        Me.cboTableForeign = New System.Windows.Forms.ComboBox()
        Me.dgvRelations = New System.Windows.Forms.DataGridView()
        Me.PrimaryTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForeignTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForeignField = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRelationClose = New System.Windows.Forms.Button()
        Me.grpPrimary.SuspendLayout()
        Me.grpForeign.SuspendLayout()
        CType(Me.dgvRelations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPrimary
        '
        Me.grpPrimary.Controls.Add(Me.lstFieldsPrimary)
        Me.grpPrimary.Controls.Add(Me.cboTablePrimary)
        Me.grpPrimary.Location = New System.Drawing.Point(12, 12)
        Me.grpPrimary.Name = "grpPrimary"
        Me.grpPrimary.Size = New System.Drawing.Size(287, 150)
        Me.grpPrimary.TabIndex = 0
        Me.grpPrimary.TabStop = False
        Me.grpPrimary.Text = "Primary"
        '
        'lstFieldsPrimary
        '
        Me.lstFieldsPrimary.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFieldsPrimary.FormattingEnabled = True
        Me.lstFieldsPrimary.ItemHeight = 18
        Me.lstFieldsPrimary.Location = New System.Drawing.Point(10, 50)
        Me.lstFieldsPrimary.Name = "lstFieldsPrimary"
        Me.lstFieldsPrimary.Size = New System.Drawing.Size(200, 76)
        Me.lstFieldsPrimary.TabIndex = 1
        '
        'cboTablePrimary
        '
        Me.cboTablePrimary.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTablePrimary.FormattingEnabled = True
        Me.cboTablePrimary.Location = New System.Drawing.Point(10, 20)
        Me.cboTablePrimary.Name = "cboTablePrimary"
        Me.cboTablePrimary.Size = New System.Drawing.Size(220, 26)
        Me.cboTablePrimary.TabIndex = 0
        '
        'grpForeign
        '
        Me.grpForeign.Controls.Add(Me.lstFieldsForeign)
        Me.grpForeign.Controls.Add(Me.cboTableForeign)
        Me.grpForeign.Location = New System.Drawing.Point(324, 12)
        Me.grpForeign.Name = "grpForeign"
        Me.grpForeign.Size = New System.Drawing.Size(280, 150)
        Me.grpForeign.TabIndex = 1
        Me.grpForeign.TabStop = False
        Me.grpForeign.Text = "Foreign"
        '
        'lstFieldsForeign
        '
        Me.lstFieldsForeign.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFieldsForeign.FormattingEnabled = True
        Me.lstFieldsForeign.ItemHeight = 18
        Me.lstFieldsForeign.Location = New System.Drawing.Point(10, 50)
        Me.lstFieldsForeign.Name = "lstFieldsForeign"
        Me.lstFieldsForeign.Size = New System.Drawing.Size(200, 76)
        Me.lstFieldsForeign.TabIndex = 1
        '
        'cboTableForeign
        '
        Me.cboTableForeign.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTableForeign.FormattingEnabled = True
        Me.cboTableForeign.Location = New System.Drawing.Point(10, 20)
        Me.cboTableForeign.Name = "cboTableForeign"
        Me.cboTableForeign.Size = New System.Drawing.Size(220, 26)
        Me.cboTableForeign.TabIndex = 0
        '
        'dgvRelations
        '
        Me.dgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PrimaryTable, Me.PrimaryField, Me.ForeignTable, Me.ForeignField})
        Me.dgvRelations.Location = New System.Drawing.Point(12, 180)
        Me.dgvRelations.Name = "dgvRelations"
        Me.dgvRelations.Size = New System.Drawing.Size(542, 150)
        Me.dgvRelations.TabIndex = 2
        '
        'PrimaryTable
        '
        Me.PrimaryTable.HeaderText = "Primary Table"
        Me.PrimaryTable.Name = "PrimaryTable"
        Me.PrimaryTable.Width = 150
        '
        'PrimaryField
        '
        Me.PrimaryField.HeaderText = "Primary Field"
        Me.PrimaryField.Name = "PrimaryField"
        '
        'ForeignTable
        '
        Me.ForeignTable.HeaderText = "Foreign Table"
        Me.ForeignTable.Name = "ForeignTable"
        Me.ForeignTable.Width = 150
        '
        'ForeignField
        '
        Me.ForeignField.HeaderText = "Foreign Field"
        Me.ForeignField.Name = "ForeignField"
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(12, 340)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 27)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(124, 340)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 27)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(236, 340)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 27)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRelationClose
        '
        Me.btnRelationClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelationClose.Location = New System.Drawing.Point(374, 340)
        Me.btnRelationClose.Name = "btnRelationClose"
        Me.btnRelationClose.Size = New System.Drawing.Size(100, 27)
        Me.btnRelationClose.TabIndex = 6
        Me.btnRelationClose.Text = "Close"
        Me.btnRelationClose.UseVisualStyleBackColor = True
        '
        'FrmRelationManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 419)
        Me.Controls.Add(Me.btnRelationClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dgvRelations)
        Me.Controls.Add(Me.grpForeign)
        Me.Controls.Add(Me.grpPrimary)
        Me.Name = "FrmRelationManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relationship Manager"
        Me.grpPrimary.ResumeLayout(False)
        Me.grpForeign.ResumeLayout(False)
        CType(Me.dgvRelations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPrimary As GroupBox
    Friend WithEvents cboTablePrimary As ComboBox
    Friend WithEvents lstFieldsPrimary As ListBox
    Friend WithEvents grpForeign As GroupBox
    Friend WithEvents lstFieldsForeign As ListBox
    Friend WithEvents cboTableForeign As ComboBox
    Friend WithEvents dgvRelations As DataGridView
    Friend WithEvents PrimaryTable As DataGridViewTextBoxColumn
    Friend WithEvents PrimaryField As DataGridViewTextBoxColumn
    Friend WithEvents ForeignTable As DataGridViewTextBoxColumn
    Friend WithEvents ForeignField As DataGridViewTextBoxColumn
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnRelationClose As Button
End Class
