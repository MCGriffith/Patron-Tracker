<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelationshipManager
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
        PrmaryTablePanel = New Panel()
        lblPrimaryTable = New Label()
        lblPrimaryKey = New Label()
        cboPrimaryTable = New ComboBox()
        cboPrimaryKey = New ComboBox()
        ForeignTablePanel = New Panel()
        cboForeignKey = New ComboBox()
        cboForeignTable = New ComboBox()
        lblForeignKey = New Label()
        lblForeignTable = New Label()
        dgvRelationships = New DataGridView()
        PrmaryTablePanel.SuspendLayout()
        ForeignTablePanel.SuspendLayout()
        CType(dgvRelationships, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PrmaryTablePanel
        ' 
        PrmaryTablePanel.Controls.Add(cboPrimaryKey)
        PrmaryTablePanel.Controls.Add(cboPrimaryTable)
        PrmaryTablePanel.Controls.Add(lblPrimaryKey)
        PrmaryTablePanel.Controls.Add(lblPrimaryTable)
        PrmaryTablePanel.Location = New Point(53, 36)
        PrmaryTablePanel.Name = "PrmaryTablePanel"
        PrmaryTablePanel.Size = New Size(415, 109)
        PrmaryTablePanel.TabIndex = 0
        ' 
        ' lblPrimaryTable
        ' 
        lblPrimaryTable.AutoSize = True
        lblPrimaryTable.Location = New Point(57, 18)
        lblPrimaryTable.Name = "lblPrimaryTable"
        lblPrimaryTable.Size = New Size(107, 18)
        lblPrimaryTable.TabIndex = 0
        lblPrimaryTable.Text = "Primary Table:"
        ' 
        ' lblPrimaryKey
        ' 
        lblPrimaryKey.AutoSize = True
        lblPrimaryKey.Location = New Point(67, 55)
        lblPrimaryKey.Name = "lblPrimaryKey"
        lblPrimaryKey.Size = New Size(97, 18)
        lblPrimaryKey.TabIndex = 1
        lblPrimaryKey.Text = "Primary Key:"
        ' 
        ' cboPrimaryTable
        ' 
        cboPrimaryTable.FormattingEnabled = True
        cboPrimaryTable.Location = New Point(170, 15)
        cboPrimaryTable.Name = "cboPrimaryTable"
        cboPrimaryTable.Size = New Size(212, 26)
        cboPrimaryTable.TabIndex = 2
        ' 
        ' cboPrimaryKey
        ' 
        cboPrimaryKey.FormattingEnabled = True
        cboPrimaryKey.Location = New Point(170, 55)
        cboPrimaryKey.Name = "cboPrimaryKey"
        cboPrimaryKey.Size = New Size(212, 26)
        cboPrimaryKey.TabIndex = 3
        ' 
        ' ForeignTablePanel
        ' 
        ForeignTablePanel.Controls.Add(cboForeignKey)
        ForeignTablePanel.Controls.Add(cboForeignTable)
        ForeignTablePanel.Controls.Add(lblForeignKey)
        ForeignTablePanel.Controls.Add(lblForeignTable)
        ForeignTablePanel.Location = New Point(510, 36)
        ForeignTablePanel.Name = "ForeignTablePanel"
        ForeignTablePanel.Size = New Size(415, 109)
        ForeignTablePanel.TabIndex = 1
        ' 
        ' cboForeignKey
        ' 
        cboForeignKey.FormattingEnabled = True
        cboForeignKey.Location = New Point(170, 55)
        cboForeignKey.Name = "cboForeignKey"
        cboForeignKey.Size = New Size(212, 26)
        cboForeignKey.TabIndex = 3
        ' 
        ' cboForeignTable
        ' 
        cboForeignTable.FormattingEnabled = True
        cboForeignTable.Location = New Point(170, 15)
        cboForeignTable.Name = "cboForeignTable"
        cboForeignTable.Size = New Size(212, 26)
        cboForeignTable.TabIndex = 2
        ' 
        ' lblForeignKey
        ' 
        lblForeignKey.AutoSize = True
        lblForeignKey.Location = New Point(67, 55)
        lblForeignKey.Name = "lblForeignKey"
        lblForeignKey.Size = New Size(97, 18)
        lblForeignKey.TabIndex = 1
        lblForeignKey.Text = "Foreign Key:"
        ' 
        ' lblForeignTable
        ' 
        lblForeignTable.AutoSize = True
        lblForeignTable.Location = New Point(57, 18)
        lblForeignTable.Name = "lblForeignTable"
        lblForeignTable.Size = New Size(107, 18)
        lblForeignTable.TabIndex = 0
        lblForeignTable.Text = "Foreign Table:"
        ' 
        ' dgvRelationships
        ' 
        dgvRelationships.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRelationships.Location = New Point(53, 189)
        dgvRelationships.Name = "dgvRelationships"
        dgvRelationships.Size = New Size(872, 296)
        dgvRelationships.TabIndex = 2
        ' 
        ' FrmRelationshipManager
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 540)
        Controls.Add(dgvRelationships)
        Controls.Add(ForeignTablePanel)
        Controls.Add(PrmaryTablePanel)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "FrmRelationshipManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Relationship Manager"
        PrmaryTablePanel.ResumeLayout(False)
        PrmaryTablePanel.PerformLayout()
        ForeignTablePanel.ResumeLayout(False)
        ForeignTablePanel.PerformLayout()
        CType(dgvRelationships, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrmaryTablePanel As Panel
    Friend WithEvents lblPrimaryKey As Label
    Friend WithEvents lblPrimaryTable As Label
    Friend WithEvents cboPrimaryKey As ComboBox
    Friend WithEvents cboPrimaryTable As ComboBox
    Friend WithEvents ForeignTablePanel As Panel
    Friend WithEvents cboForeignKey As ComboBox
    Friend WithEvents cboForeignTable As ComboBox
    Friend WithEvents lblForeignKey As Label
    Friend WithEvents lblForeignTable As Label
    Friend WithEvents dgvRelationships As DataGridView
End Class
