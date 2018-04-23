Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports MVVMSample.MVVM.Data

Namespace MVVMSample
    Public Class DataAccessHelper
        Public Shared Function GetCustomers() As BindingList(Of Customer)
            Dim dt As New BindingList(Of Customer)()
            For i As Integer = 0 To 9
                dt.Add(New Customer With { _
                    .ID = i, _
                    .FirstName = String.Format("Name {0}", i), _
                    .LastName = String.Format("Last Name {0}", i) _
                })
            Next i
            Return dt
        End Function
        Public Shared Function GetOrders() As BindingList(Of Order)
            Dim dt As New BindingList(Of Order)()
            For i As Integer = 0 To 9
                dt.Add(New Order With { _
                    .ID = i, _
                    .OrderDate = Date.Today.AddDays(-i), _
                    .Freight = i * 100 + 100 _
                })
            Next i
            Return dt
        End Function
    End Class
End Namespace
