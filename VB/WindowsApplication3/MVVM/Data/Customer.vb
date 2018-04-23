Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Text

Namespace MVVMSample
    Public Class Customer
        <Required> _
        Public Property ID() As Integer
        <Required> _
        Public Property FirstName() As String
        <Required> _
        Public Property LastName() As String
    End Class
End Namespace
