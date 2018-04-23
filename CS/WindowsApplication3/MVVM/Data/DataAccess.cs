using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using MVVMSample.MVVM.Data;

namespace MVVMSample {
    public class DataAccessHelper {
        public static BindingList<Customer> GetCustomers() {
            BindingList<Customer> dt = new BindingList<Customer>();
            for (int i = 0; i < 10; i++)
            {
                dt.Add(new Customer { ID = i, FirstName = string.Format("Name {0}", i), LastName = string.Format("Last Name {0}", i) });
            }
            return dt;
        }
        public static BindingList<Order> GetOrders() {
            BindingList<Order> dt = new BindingList<Order>();
            for (int i = 0; i < 10; i++) {
                dt.Add(new Order { ID = i, OrderDate = DateTime.Today.AddDays(-i), Freight = i * 100 + 100 });
            }
            return dt;
        }
    }
}
