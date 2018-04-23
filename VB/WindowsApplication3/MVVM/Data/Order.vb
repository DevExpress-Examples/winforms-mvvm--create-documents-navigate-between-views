Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace MVVMSample.MVVM.Data
    Public Class Order
        <Required> _
        Public Property ID() As Integer
        Public Property OrderDate() As Date
        Public Property Freight() As Decimal
    End Class
End Namespace
