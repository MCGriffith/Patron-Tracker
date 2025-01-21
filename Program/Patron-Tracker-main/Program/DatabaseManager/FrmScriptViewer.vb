Imports System.Data.OleDb
Imports DatabaseManager.Classes
Imports System.Collections.Generic

Public Class FrmScriptViewer
    Private Sub FrmScriptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupScriptTextBox()
    End Sub

    Private Sub SetupScriptTextBox()
        With txtScript
            .Multiline = True
            .ScrollBars = ScrollBars.Both
            .Font = New Font("Consolas", 10)
            .WordWrap = False
        End With
    End Sub

    Private Sub btnGenerateScript_Click(sender As Object, e As EventArgs) Handles btnGenerateScript.Click
        Dim scriptGen As New ScriptGenerator()
        ' Generate script based on pending changes
        txtScript.Text = String.Join(vbCrLf & "GO" & vbCrLf, ScriptHistory)
    End Sub

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim upgrader As New UpgradeManager()

        If upgrader.ExecuteScript(txtScript.Text) Then
            MessageBox.Show("Script executed successfully!")
            ScriptHistory.Clear()
            txtScript.Clear()
        Else
            MessageBox.Show("Script execution failed!")
        End If
    End Sub

    Private Sub btnSaveScript_Click(sender As Object, e As EventArgs) Handles btnSaveScript.Click
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "SQL Files|*.sql|Text Files|*.txt|All Files|*.*"
            saveDialog.DefaultExt = "sql"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(saveDialog.FileName, txtScript.Text)
                MessageBox.Show("Script saved successfully!")
            End If
        End Using
    End Sub
End Class