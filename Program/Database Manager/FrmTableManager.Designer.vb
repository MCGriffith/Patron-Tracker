<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTableManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Private Sub InitializeComponent()
        Me.dgvFields = New System.Windows.Forms.DataGridView()
        Me.FieldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Required = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlProperties = New System.Windows.Forms.Panel()
        Me.cboDataType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDeleteField = New System.Windows.Forms.Button()
        Me.btnAddField = New System.Windows.Forms.Button()
        Me.cboTables = New System.Windows.Forms.ComboBox()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.btnTableClose = New System.Windows.Forms.Button()
        Me.lblDataType = New System.Windows.Forms.Label()
        CType(Me.dgvFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProperties.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFields
        '
        Me.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFields.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FieldName, Me.DataType, Me.Size, Me.Required, Me.Description})
        Me.dgvFields.Location = New System.Drawing.Point(5, 72)
        Me.dgvFields.Name = "dgvFields"
        Me.dgvFields.Size = New System.Drawing.Size(595, 200)
        Me.dgvFields.TabIndex = 0
        '
        'FieldName
        '
        Me.FieldName.HeaderText = "Field Name"
        Me.FieldName.Name = "FieldName"
        Me.FieldName.Width = 150
        '
        'DataType
        '
        Me.DataType.HeaderText = "Data Type"
        Me.DataType.Name = "DataType"
        '
        'Size
        '
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        Me.Size.Width = 75
        '
        'Required
        '
        Me.Required.HeaderText = "Required"
        Me.Required.Name = "Required"
        Me.Required.Width = 75
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 150
        '
        'pnlProperties
        '
        Me.pnlProperties.Controls.Add(Me.lblDataType)
        Me.pnlProperties.Controls.Add(Me.btnTableClose)
        Me.pnlProperties.Controls.Add(Me.cboDataType)
        Me.pnlProperties.Controls.Add(Me.btnSave)
        Me.pnlProperties.Controls.Add(Me.btnDeleteField)
        Me.pnlProperties.Controls.Add(Me.btnAddField)
        Me.pnlProperties.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlProperties.Location = New System.Drawing.Point(5, 288)
        Me.pnlProperties.Name = "pnlProperties"
        Me.pnlProperties.Size = New System.Drawing.Size(595, 104)
        Me.pnlProperties.TabIndex = 1
        '
        'cboDataType
        '
        Me.cboDataType.FormattingEnabled = True
        Me.cboDataType.Location = New System.Drawing.Point(109, 62)
        Me.cboDataType.Name = "cboDataType"
        Me.cboDataType.Size = New System.Drawing.Size(200, 26)
        Me.cboDataType.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(266, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 27)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDeleteField
        '
        Me.btnDeleteField.Location = New System.Drawing.Point(124, 12)
        Me.btnDeleteField.Name = "btnDeleteField"
        Me.btnDeleteField.Size = New System.Drawing.Size(125, 27)
        Me.btnDeleteField.TabIndex = 1
        Me.btnDeleteField.Text = "Delete Field"
        Me.btnDeleteField.UseVisualStyleBackColor = True
        '
        'btnAddField
        '
        Me.btnAddField.Location = New System.Drawing.Point(12, 12)
        Me.btnAddField.Name = "btnAddField"
        Me.btnAddField.Size = New System.Drawing.Size(100, 27)
        Me.btnAddField.TabIndex = 0
        Me.btnAddField.Text = "Add Field"
        Me.btnAddField.UseVisualStyleBackColor = True
        '
        'cboTables
        '
        Me.cboTables.FormattingEnabled = True
        Me.cboTables.Location = New System.Drawing.Point(129, 17)
        Me.cboTables.Name = "cboTables"
        Me.cboTables.Size = New System.Drawing.Size(185, 21)
        Me.cboTables.TabIndex = 2
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.Location = New System.Drawing.Point(29, 20)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(97, 18)
        Me.lblTable.TabIndex = 3
        Me.lblTable.Text = "Select Table:"
        '
        'btnTableClose
        '
        Me.btnTableClose.Location = New System.Drawing.Point(401, 12)
        Me.btnTableClose.Name = "btnTableClose"
        Me.btnTableClose.Size = New System.Drawing.Size(100, 27)
        Me.btnTableClose.TabIndex = 4
        Me.btnTableClose.Text = "Close"
        Me.btnTableClose.UseVisualStyleBackColor = True
        '
        'lblDataType
        '
        Me.lblDataType.AutoSize = True
        Me.lblDataType.Location = New System.Drawing.Point(24, 65)
        Me.lblDataType.Name = "lblDataType"
        Me.lblDataType.Size = New System.Drawing.Size(79, 18)
        Me.lblDataType.TabIndex = 5
        Me.lblDataType.Text = "Data Type"
        '
        'FrmTableManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 404)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.cboTables)
        Me.Controls.Add(Me.pnlProperties)
        Me.Controls.Add(Me.dgvFields)
        Me.Name = "FrmTableManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table Manager"
        CType(Me.dgvFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProperties.ResumeLayout(False)
        Me.pnlProperties.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFields As DataGridView
    Friend WithEvents pnlProperties As Panel
    Friend WithEvents btnDeleteField As Button
    Friend WithEvents btnAddField As Button
    Friend WithEvents cboDataType As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents FieldName As DataGridViewTextBoxColumn
    Friend WithEvents DataType As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Required As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents cboTables As ComboBox
    Friend WithEvents lblTable As Label
    Friend WithEvents btnTableClose As Button
    Friend WithEvents lblDataType As Label
End Class
