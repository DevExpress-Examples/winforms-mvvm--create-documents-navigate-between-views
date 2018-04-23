using System;
using System.Collections.Generic;
using System.Linq;
using MVVMSample.MVVM.Data;

namespace MVVMSample {
    public class OrdersViewModel : BaseViewModel<Order> {
        public OrdersViewModel() {
            Entities = DataAccessHelper.GetOrders();
        }
    }
}
