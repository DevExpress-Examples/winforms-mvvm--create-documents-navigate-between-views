namespace MVVMSample {
    partial class OrdersView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersView));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(MVVMSample.OrdersViewModel);
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.AllowGlyphSkinning = false;
            windowsUIButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions1.Image")));
            windowsUIButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions2.Image")));
            windowsUIButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions3.Image")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions2),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", true, windowsUIButtonImageOptions3)});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(67, 439);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(67, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(641, 439);
            this.treeList1.TabIndex = 1;
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Name = "OrdersView";
            this.Size = new System.Drawing.Size(708, 439);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
    }
}
