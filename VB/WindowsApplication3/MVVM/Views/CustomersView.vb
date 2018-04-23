Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace MVVMSample
    Partial Public Class CustomersView
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeBindings()
            End If
        End Sub
        Private Sub InitializeBindings()
            mvvmContext.ViewModelType = GetType(CustomersViewModel)
            Dim fluent = mvvmContext.OfType(Of CustomersViewModel)()
            fluent.SetBinding(gridControl1, Function(c) c.DataSource, Function(x) x.Entities)
            fluent.BindCommand(clearNavButton, Sub(x) x.Clear())
            fluent.BindCommand(removeLastNavButton, Sub(x) x.RemoveLast())
            fluent.BindCommand(addNavButton, Sub(x) x.Add())
        End Sub
    End Class
End Namespace
