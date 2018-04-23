using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVMSample {
    public class CustomersViewModel : BaseViewModel<Customer> {
        public CustomersViewModel() {
            Entities = DataAccessHelper.GetCustomers();
        }
    }
}