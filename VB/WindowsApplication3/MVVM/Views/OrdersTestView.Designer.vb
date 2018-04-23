Namespace MVVMSample
    Partial Public Class OrdersView
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
            Dim windowsUIButtonImageOptions1 As New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(OrdersView))
            Dim windowsUIButtonImageOptions2 As New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim windowsUIButtonImageOptions3 As New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.windowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(MVVMSample.OrdersViewModel)
            ' 
            ' windowsUIButtonPanel1
            ' 
            Me.windowsUIButtonPanel1.AllowGlyphSkinning = False
            windowsUIButtonImageOptions1.Image = (CType(resources.GetObject("windowsUIButtonImageOptions1.Image"), System.Drawing.Image))
            windowsUIButtonImageOptions2.Image = (CType(resources.GetObject("windowsUIButtonImageOptions2.Image"), System.Drawing.Image))
            windowsUIButtonImageOptions3.Image = (CType(resources.GetObject("windowsUIButtonImageOptions3.Image"), System.Drawing.Image))
            Me.windowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { _
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions1), _
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions2), _
                New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, windowsUIButtonImageOptions3) _
            })
            Me.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.windowsUIButtonPanel1.Location = New System.Drawing.Point(0, 0)
            Me.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1"
            Me.windowsUIButtonPanel1.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.windowsUIButtonPanel1.Size = New System.Drawing.Size(67, 439)
            Me.windowsUIButtonPanel1.TabIndex = 0
            Me.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1"
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList1.Location = New System.Drawing.Point(67, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.Size = New System.Drawing.Size(641, 439)
            Me.treeList1.TabIndex = 1
            ' 
            ' OrdersView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList1)
            Me.Controls.Add(Me.windowsUIButtonPanel1)
            Me.Name = "OrdersView"
            Me.Size = New System.Drawing.Size(708, 439)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private treeList1 As DevExpress.XtraTreeList.TreeList
        Private windowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    End Class
End Namespace
