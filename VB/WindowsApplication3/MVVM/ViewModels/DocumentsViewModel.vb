Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO

Namespace MVVMSample
    Public Class DocumentsViewModel
        Private ReadOnly viewNameSuffix As String = "View"
        Public ReadOnly Property DocumentManagerService() As IDocumentManagerService
            Get
                Return Me.GetRequiredService(Of IDocumentManagerService)()
            End Get
        End Property
        Public Overridable Property DocumentType() As DocumentType
        Protected Sub OnDocumentTypeChanged()
            LoadDocument()
        End Sub
        Public Sub LoadDocument()
            If DocumentType <> MVVMSample.DocumentType.None AndAlso DocumentManagerService IsNot Nothing Then
                Dim document As IDocument = DocumentManagerService.FindDocumentByIdOrCreate(DocumentType, Function(x) CreateDocument())
                document.Show()
            End If
        End Sub
        Private Function CreateDocument() As IDocument
            Dim document = DocumentManagerService.CreateDocument(DocumentType.ToString() & viewNameSuffix, Nothing, Me)
            document.Title = DocumentType
            document.DestroyOnClose = False
            Return document
        End Function
    End Class
    Public Enum DocumentType
        None
        Customers
        Orders
    End Enum
End Namespace
