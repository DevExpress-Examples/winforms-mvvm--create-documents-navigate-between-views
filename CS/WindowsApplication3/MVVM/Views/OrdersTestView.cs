using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010;

namespace MVVMSample {
    public partial class OrdersView : UserControl {
        public OrdersView() {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode) {
                InitializeBindings();
            }
        }
        private void InitializeBindings() {
            var fluent = mvvmContext.OfType<OrdersViewModel>();
            fluent.SetBinding(treeList1, c => c.DataSource, x => x.Entities);
            fluent.BindCommand(windowsUIButtonPanel1.Buttons[0] as WindowsUIButton, x => x.Clear());
            fluent.BindCommand(windowsUIButtonPanel1.Buttons[1] as WindowsUIButton, x => x.RemoveLast());
            fluent.BindCommand(windowsUIButtonPanel1.Buttons[2] as WindowsUIButton, x => x.Add());
        }
    }
}
