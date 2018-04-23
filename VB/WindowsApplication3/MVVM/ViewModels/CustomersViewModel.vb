Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace MVVMSample
    Public Class CustomersViewModel
        Inherits BaseViewModel(Of Customer)

        Public Sub New()
            Entities = DataAccessHelper.GetCustomers()
        End Sub
    End Class
End Namespace