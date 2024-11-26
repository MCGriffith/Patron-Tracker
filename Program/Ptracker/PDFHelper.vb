Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports iTextSharp.tool.xml
Imports System.Drawing.Printing

Public Class PDFHelper
    Public Shared Sub CreatePDFFromWebBrowser(webBrowser As WebBrowser, fileName As String)
        Using fs As New FileStream(fileName, FileMode.Create)
            Dim document As New Document(PageSize.A4, 25, 25, 25, 25)
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, fs)
            document.Open()

            Using srHtml As New StringReader(webBrowser.DocumentText)
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, srHtml)
            End Using

            document.Close()
        End Using
    End Sub

    Public Shared Sub CreateLabels5160(dataList As List(Of String), fileName As String)
        Using fs As New FileStream(fileName, FileMode.Create)
            ' Avery 5160 specifications (in points)
            Const LABEL_WIDTH As Single = 189.0F    ' 2.625 inches
            Const LABEL_HEIGHT As Single = 72.0F    ' 1 inch
            Const PAGE_TOP_MARGIN As Single = 36.0F  ' 0.5 inch
            Const PAGE_LEFT_MARGIN As Single = 13.5F ' 0.1875 inch
            Const VERTICAL_GAP As Single = 0.0F      ' Gap between labels
            Const HORIZONTAL_GAP As Single = 9.0F    ' Gap between columns

            Dim document As New Document(PageSize.LETTER)
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, fs)
            document.Open()

            Dim cb As PdfContentByte = writer.DirectContent
            Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)

            Dim currentLabel As Integer = 0
            While currentLabel < dataList.Count
                For row As Integer = 0 To 9  ' 10 rows
                    For col As Integer = 0 To 2  ' 3 columns
                        If currentLabel >= dataList.Count Then Exit While

                        Dim x As Single = PAGE_LEFT_MARGIN + (col * (LABEL_WIDTH + HORIZONTAL_GAP))
                        Dim y As Single = PageSize.LETTER.Height - PAGE_TOP_MARGIN - (row * (LABEL_HEIGHT + VERTICAL_GAP))

                        cb.BeginText()
                        cb.SetFontAndSize(bf, 10)
                        cb.SetTextMatrix(x, y - 15)  ' Adjust vertical position for text
                        cb.ShowText(dataList(currentLabel))
                        cb.EndText()

                        currentLabel += 1
                    Next
                Next
                If currentLabel < dataList.Count Then
                    document.NewPage()
                End If
            End While

            document.Close()
        End Using
    End Sub

    Public Shared Sub PrintLabels5160(dataList As List(Of String))
        Dim printDoc As New PrintDocument()

        AddHandler printDoc.PrintPage, Sub(sender, e)
                                           ' Avery 5160 specifications (in points)
                                           Const LABEL_WIDTH As Single = 189.0F
                                           Const LABEL_HEIGHT As Single = 72.0F

                                           ' Print logic here using e.Graphics
                                           ' This sends directly to printer
                                       End Sub

        ' Show printer dialog
        Dim printDialog As New PrintDialog
        printDialog.Document = printDoc

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub
End Class