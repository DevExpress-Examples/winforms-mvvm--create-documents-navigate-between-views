Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010

Namespace MVVMSample
    Partial Public Class OrdersView
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeBindings()
            End If
        End Sub
        Private Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of OrdersViewModel)()
            fluent.SetBinding(treeList1, Function(c) c.DataSource, Function(x) x.Entities)
            fluent.BindCommand(TryCast(windowsUIButtonPanel1.Buttons(0), WindowsUIButton), Sub(x) x.Clear())
            fluent.BindCommand(TryCast(windowsUIButtonPanel1.Buttons(1), WindowsUIButton), Sub(x) x.RemoveLast())
            fluent.BindCommand(TryCast(windowsUIButtonPanel1.Buttons(2), WindowsUIButton), Sub(x) x.Add())
        End Sub
    End Class
End Namespace
