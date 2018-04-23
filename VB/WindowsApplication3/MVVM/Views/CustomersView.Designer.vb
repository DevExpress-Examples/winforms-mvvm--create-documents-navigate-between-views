Namespace MVVMSample
    Partial Public Class CustomersView
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomersView))
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.tileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
            Me.clearNavButton = New DevExpress.XtraBars.Navigation.NavButton()
            Me.removeLastNavButton = New DevExpress.XtraBars.Navigation.NavButton()
            Me.addNavButton = New DevExpress.XtraBars.Navigation.NavButton()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tileNavPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            ' 
            ' tileNavPane1
            ' 
            Me.tileNavPane1.Buttons.Add(Me.clearNavButton)
            Me.tileNavPane1.Buttons.Add(Me.removeLastNavButton)
            Me.tileNavPane1.Buttons.Add(Me.addNavButton)
            ' 
            ' tileNavCategory1
            ' 
            Me.tileNavPane1.DefaultCategory.Name = "tileNavCategory1"
            Me.tileNavPane1.DefaultCategory.OwnerCollection = Nothing
            ' 
            ' 
            ' 
            Me.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            Me.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top
            Me.tileNavPane1.Location = New System.Drawing.Point(0, 0)
            Me.tileNavPane1.Name = "tileNavPane1"
            Me.tileNavPane1.Size = New System.Drawing.Size(891, 40)
            Me.tileNavPane1.TabIndex = 0
            Me.tileNavPane1.Text = "tileNavPane1"
            ' 
            ' clearNavButton
            ' 
            Me.clearNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
            Me.clearNavButton.Caption = "Clear"
            Me.clearNavButton.Glyph = (CType(resources.GetObject("clearNavButton.Glyph"), System.Drawing.Image))
            Me.clearNavButton.Name = "clearNavButton"
            ' 
            ' removeLastNavButton
            ' 
            Me.removeLastNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
            Me.removeLastNavButton.Caption = "Remove Last"
            Me.removeLastNavButton.Glyph = (CType(resources.GetObject("removeLastNavButton.Glyph"), System.Drawing.Image))
            Me.removeLastNavButton.Name = "removeLastNavButton"
            ' 
            ' addNavButton
            ' 
            Me.addNavButton.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
            Me.addNavButton.Caption = "Add"
            Me.addNavButton.Glyph = (CType(resources.GetObject("addNavButton.Glyph"), System.Drawing.Image))
            Me.addNavButton.Name = "addNavButton"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 40)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(891, 498)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' CustomersView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.tileNavPane1)
            Me.Name = "CustomersView"
            Me.Size = New System.Drawing.Size(891, 538)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tileNavPane1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private tileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
        Private clearNavButton As DevExpress.XtraBars.Navigation.NavButton
        Private removeLastNavButton As DevExpress.XtraBars.Navigation.NavButton
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private addNavButton As DevExpress.XtraBars.Navigation.NavButton
    End Class
End Namespace
