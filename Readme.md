<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128614823/17.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T542778)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Winforms MVVM - Create documents and navigate between views (DocumentManagerService)

This example demonstrates how to use a local [DocumentManagerService](https://docs.devexpress.com/WindowsForms/114024/build-an-application/winforms-mvvm/design-time-support/control-based-services) to create new documents and navigate between them.

The example uses the [NavigationFrame]() component to navigate between views (documents).

![Winforms MVVM - Create documents and navigate between views](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-documents-and-navigate-between-views-by-using-documentmanagerservice-t542778/17.1.4%2B/media/winforms-mvvm-navigation-service.gif)


## Files to Review

* [Customer.cs](./CS/WindowsApplication3/MVVM/Data/Customer.cs) (VB: [Customer.vb](./VB/WindowsApplication3/MVVM/Data/Customer.vb))
* [DataAccess.cs](./CS/WindowsApplication3/MVVM/Data/DataAccess.cs) (VB: [DataAccess.vb](./VB/WindowsApplication3/MVVM/Data/DataAccess.vb))
* [Order.cs](./CS/WindowsApplication3/MVVM/Data/Order.cs) (VB: [Order.vb](./VB/WindowsApplication3/MVVM/Data/Order.vb))
* [DetailViewcs.cs](./CS/WindowsApplication3/MVVM/DetailViewcs.cs) (VB: [DetailViewcs.vb](./VB/WindowsApplication3/MVVM/DetailViewcs.vb))
* [BaseViewModel.cs](./CS/WindowsApplication3/MVVM/ViewModels/BaseViewModel.cs) (VB: [BaseViewModel.vb](./VB/WindowsApplication3/MVVM/ViewModels/BaseViewModel.vb))
* [CustomersViewModel.cs](./CS/WindowsApplication3/MVVM/ViewModels/CustomersViewModel.cs) (VB: [CustomersViewModel.vb](./VB/WindowsApplication3/MVVM/ViewModels/CustomersViewModel.vb))
* [DocumentsViewModel.cs](./CS/WindowsApplication3/MVVM/ViewModels/DocumentsViewModel.cs) (VB: [DocumentsViewModel.vb](./VB/WindowsApplication3/MVVM/ViewModels/DocumentsViewModel.vb))
* [OrdersViewModel.cs](./CS/WindowsApplication3/MVVM/ViewModels/OrdersViewModel.cs) (VB: [OrdersViewModel.vb](./VB/WindowsApplication3/MVVM/ViewModels/OrdersViewModel.vb))
* [CustomersView.cs](./CS/WindowsApplication3/MVVM/Views/CustomersView.cs) (VB: [CustomersView.vb](./VB/WindowsApplication3/MVVM/Views/CustomersView.vb))
* [MainView.cs](./CS/WindowsApplication3/MVVM/Views/MainView.cs) (VB: [MainView.vb](./VB/WindowsApplication3/MVVM/Views/MainView.vb))
* [OrdersTestView.cs](./CS/WindowsApplication3/MVVM/Views/OrdersTestView.cs) (VB: [OrdersTestView.vb](./VB/WindowsApplication3/MVVM/Views/OrdersTestView.vb))


## Documentation

* [WinForms MVVM](https://docs.devexpress.com/WindowsForms/113955/build-an-application/winforms-mvvm)
* [Navigation and View Management](https://docs.devexpress.com/WindowsForms/114173/build-an-application/winforms-mvvm/concepts/view-management)
