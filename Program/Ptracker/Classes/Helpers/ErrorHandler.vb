Public Class ErrorHandler
    Public Shared Sub HandleDatabaseError(ex As Exception, operation As String)
        MessageBox.Show($"Database operation failed: {operation}", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Sub HandleValidationError(message As String)
        MessageBox.Show(message, "Validation Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Shared Sub HandleSystemError(ex As Exception)
        MessageBox.Show("An unexpected error occurred. Please try again.",
                       "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class