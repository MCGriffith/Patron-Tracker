<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPatronReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSelectName = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPIN = New System.Windows.Forms.Label()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.lblMatch = New System.Windows.Forms.Label()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblRoleName = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSelectName
        '
        Me.btnSelectName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSelectName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelectName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectName.Location = New System.Drawing.Point(40, 76)
        Me.btnSelectName.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectName.Name = "btnSelectName"
        Me.btnSelectName.Size = New System.Drawing.Size(221, 61)
        Me.btnSelectName.TabIndex = 0
        Me.btnSelectName.Text = "Select Name"
        Me.btnSelectName.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(40, 567)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(221, 61)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerateReport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.Location = New System.Drawing.Point(40, 175)
        Me.btnGenerateReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(221, 61)
        Me.btnGenerateReport.TabIndex = 3
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(328, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 18)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Location = New System.Drawing.Point(345, 127)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(37, 18)
        Me.lblPIN.TabIndex = 5
        Me.lblPIN.Text = "PIN:"
        '
        'txtPIN
        '
        Me.txtPIN.Location = New System.Drawing.Point(388, 119)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPIN.Size = New System.Drawing.Size(164, 26)
        Me.txtPIN.TabIndex = 2
        '
        'lblMatch
        '
        Me.lblMatch.AutoSize = True
        Me.lblMatch.Location = New System.Drawing.Point(575, 127)
        Me.lblMatch.Name = "lblMatch"
        Me.lblMatch.Size = New System.Drawing.Size(74, 18)
        Me.lblMatch.TabIndex = 7
        Me.lblMatch.Text = "No Match"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(331, 175)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(706, 453)
        Me.WebBrowser2.TabIndex = 8
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(40, 278)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(221, 61)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(40, 382)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(221, 61)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(388, 30)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(52, 18)
        Me.lblRole.TabIndex = 11
        Me.lblRole.Text = "           "
        '
        'lblRoleName
        '
        Me.lblRoleName.AutoSize = True
        Me.lblRoleName.Location = New System.Drawing.Point(338, 30)
        Me.lblRoleName.Name = "lblRoleName"
        Me.lblRoleName.Size = New System.Drawing.Size(44, 18)
        Me.lblRoleName.TabIndex = 12
        Me.lblRoleName.Text = "Role:"
        '
        'cboName
        '
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(388, 76)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(436, 26)
        Me.cboName.TabIndex = 1
        '
        'FrmPatronReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 671)
        Me.Controls.Add(Me.lblRoleName)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.lblMatch)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSelectName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPatronReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patron Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelectName As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPIN As Label
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents lblMatch As Label
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents lblRoleName As Label
    Friend WithEvents cboName As ComboBox
End Class
