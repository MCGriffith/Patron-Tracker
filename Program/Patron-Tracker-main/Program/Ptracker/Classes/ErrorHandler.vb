Public Class ErrorHandler
    Public Shared Sub HandleDatabaseError(ex As Exception, operation As String)
        Debug.WriteLine($"Database Error during {operation}: {ex.Message}")
        MessageBox.Show($"Database operation failed: {operation}", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Sub HandleValidationError(message As String)
        MessageBox.Show(message, "Validation Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Shared Sub HandleSystemError(ex As Exception)
        Debug.WriteLine($"System Error: {ex.Message}")
        Debug.WriteLine($"Stack Trace: {ex.StackTrace}")
        MessageBox.Show("An unexpected error occurred. Please try again.",
                       "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class