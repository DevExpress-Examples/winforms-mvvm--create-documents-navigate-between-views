Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports DevExpress.Mvvm.POCO

Namespace MVVMSample
    Public Class BaseViewModel(Of T As {Class, New})
        Public Sub New()
            SupportNewEntities = True
        End Sub
        Public Overridable Property Entities() As BindingList(Of T)
        Public Overridable Property SupportNewEntities() As Boolean
        Public Sub Add()
            Entities.Add(New T())
        End Sub
        Public Function CanAdd() As Boolean
            Return SupportNewEntities
        End Function
        Protected Sub OnSupportNewEntitiesChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.Add())
        End Sub
        Public Sub Clear()
            Entities.Clear()
        End Sub
        Public Sub RemoveLast()
            If Entities.Count > 0 Then
                Entities.RemoveAt(Entities.Count - 1)
            End If
        End Sub
    End Class
End Namespace
