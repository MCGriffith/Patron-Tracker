Imports System.IO

Module DocumentationConfig
    Private _documentationPath As String = Path.Combine("C:\PTracker\Documentation", "Patron Tracker Documentation.pdf")

    Public Property DocumentationPath As String
        Get
            Return _documentationPath
        End Get
        Set(value As String)
            _documentationPath = value
        End Set
    End Property
End Module