using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVVMSample {
    public partial class CustomersView : UserControl {
        public CustomersView() {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode) {
                InitializeBindings();
            }
        }
        private void InitializeBindings() {
            mvvmContext.ViewModelType = typeof(CustomersViewModel);
            var fluent = mvvmContext.OfType<CustomersViewModel>();
            fluent.SetBinding(gridControl1, c => c.DataSource, x => x.Entities);
            fluent.BindCommand(clearNavButton, x => x.Clear());
            fluent.BindCommand(removeLastNavButton, x => x.RemoveLast());
            fluent.BindCommand(addNavButton, x => x.Add());
        }
    }
}
