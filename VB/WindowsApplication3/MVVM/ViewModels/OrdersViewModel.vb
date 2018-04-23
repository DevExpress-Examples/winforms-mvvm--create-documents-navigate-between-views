Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports MVVMSample.MVVM.Data

Namespace MVVMSample
    Public Class OrdersViewModel
        Inherits BaseViewModel(Of Order)

        Public Sub New()
            Entities = DataAccessHelper.GetOrders()
        End Sub
    End Class
End Namespace
