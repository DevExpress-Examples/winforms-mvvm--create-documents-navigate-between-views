using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraEditors;

namespace MVVMSample {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings() {
            documentTypeComboBoxEdit.Properties.Items.AddEnum<DocumentType>();
            mvvmContext.ViewModelType = typeof(DocumentsViewModel);
            mvvmContext.RegisterDefaultService(DocumentManagerService.Create(navigationFrame));
            var fluentAPI = mvvmContext.OfType<DocumentsViewModel>();
            fluentAPI.SetBinding(documentTypeComboBoxEdit, c => c.EditValue, x => x.DocumentType);
        }
    }
}

