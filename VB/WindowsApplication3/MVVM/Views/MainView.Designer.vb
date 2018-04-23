Imports DevExpress.XtraGrid.Views.Grid
Namespace MVVMSample
    Partial Public Class Main
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.documentTypeComboBoxEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationFrame.SuspendLayout()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.documentTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(0, 0)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.simpleButton1.TabIndex = 0
            ' 
            ' mvvmContext
            ' 
            Me.mvvmContext.ContainerControl = Me
            ' 
            ' navigationFrame
            ' 
            Me.navigationFrame.Controls.Add(Me.navigationPage1)
            Me.navigationFrame.Location = New System.Drawing.Point(112, 12)
            Me.navigationFrame.Name = "navigationFrame"
            Me.navigationFrame.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
            Me.navigationFrame.SelectedPage = Me.navigationPage1
            Me.navigationFrame.Size = New System.Drawing.Size(792, 543)
            Me.navigationFrame.TabIndex = 0
            Me.navigationFrame.Text = "navigationFrame1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "navigationPage1"
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(792, 543)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.navigationFrame)
            Me.layoutControl1.Controls.Add(Me.documentTypeComboBoxEdit)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(916, 567)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(916, 567)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.navigationFrame
            Me.layoutControlItem1.Location = New System.Drawing.Point(100, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(796, 547)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.documentTypeComboBoxEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(100, 547)
            Me.layoutControlItem2.Text = "Choose View Type"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' documentTypeComboBoxEdit
            ' 
            Me.documentTypeComboBoxEdit.Location = New System.Drawing.Point(12, 28)
            Me.documentTypeComboBoxEdit.Name = "documentTypeComboBoxEdit"
            Me.documentTypeComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.documentTypeComboBoxEdit.Size = New System.Drawing.Size(96, 20)
            Me.documentTypeComboBoxEdit.StyleController = Me.layoutControl1
            Me.documentTypeComboBoxEdit.TabIndex = 1
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(916, 567)
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "Main"
            Me.Text = "Simple Navigation"
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationFrame.ResumeLayout(False)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.documentTypeComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
        Private navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
        Private navigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private documentTypeComboBoxEdit As DevExpress.XtraEditors.ImageComboBoxEdit



    End Class
End Namespace

