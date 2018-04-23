Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraEditors

Namespace MVVMSample
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeBindings()
            End If
        End Sub

        Private Sub InitializeBindings()
            documentTypeComboBoxEdit.Properties.Items.AddEnum(Of DocumentType)()
            mvvmContext.ViewModelType = GetType(DocumentsViewModel)
            mvvmContext.RegisterDefaultService(DocumentManagerService.Create(navigationFrame))
            Dim fluentAPI = mvvmContext.OfType(Of DocumentsViewModel)()
            fluentAPI.SetBinding(documentTypeComboBoxEdit, Function(c) c.EditValue, Function(x) x.DocumentType)
        End Sub
    End Class
End Namespace

