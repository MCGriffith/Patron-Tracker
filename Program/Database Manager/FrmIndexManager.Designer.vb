﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndexManager
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
        Me.SuspendLayout()
        '
        'FrmIndexManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "FrmIndexManager"
        Me.Text = "Index Manager"
        Me.ResumeLayout(False)



    End Sub

    Friend WithEvents grpTable As GroupBox
    Friend WithEvents lblTable As Label
    Friend WithEvents cboTables As ComboBox
    Friend WithEvents grpIndex As GroupBox
    Friend WithEvents dgvIndex As DataGridView
    Friend WithEvents IndexName As DataGridViewTextBoxColumn
    Friend WithEvents FieldName As DataGridViewTextBoxColumn
    Friend WithEvents IsUnique As DataGridViewTextBoxColumn
    Friend WithEvents IsPrimary As DataGridViewTextBoxColumn
    Friend WithEvents lblRecommendations As Label
    Friend WithEvents lblIndexSize As Label
    Friend WithEvents lblLastUsed As Label
End Class
