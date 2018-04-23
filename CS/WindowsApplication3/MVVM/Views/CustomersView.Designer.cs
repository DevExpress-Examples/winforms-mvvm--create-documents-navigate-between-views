namespace MVVMSample {
    partial class CustomersView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.clearNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.removeLastNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.addNavButton = new DevExpress.XtraBars.Navigation.NavButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.clearNavButton);
            this.tileNavPane1.Buttons.Add(this.removeLastNavButton);
            this.tileNavPane1.Buttons.Add(this.addNavButton);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(891, 40);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // clearNavButton
            // 
            this.clearNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.clearNavButton.Caption = "Clear";
            this.clearNavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("clearNavButton.Glyph")));
            this.clearNavButton.Name = "clearNavButton";
            // 
            // removeLastNavButton
            // 
            this.removeLastNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.removeLastNavButton.Caption = "Remove Last";
            this.removeLastNavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("removeLastNavButton.Glyph")));
            this.removeLastNavButton.Name = "removeLastNavButton";
            // 
            // addNavButton
            // 
            this.addNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.addNavButton.Caption = "Add";
            this.addNavButton.Glyph = ((System.Drawing.Image)(resources.GetObject("addNavButton.Glyph")));
            this.addNavButton.Name = "addNavButton";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(891, 498);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "CustomersView";
            this.Size = new System.Drawing.Size(891, 538);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton clearNavButton;
        private DevExpress.XtraBars.Navigation.NavButton removeLastNavButton;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.NavButton addNavButton;
    }
}
