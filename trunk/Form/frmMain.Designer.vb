<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuAbsensi = New DevExpress.XtraBars.BarButtonItem()
        Me.MnuMasterProduk = New DevExpress.XtraBars.BarButtonItem()
        Me.MnuGrupProduk = New DevExpress.XtraBars.BarButtonItem()
        Me.MnuMasterKaryawan = New DevExpress.XtraBars.BarButtonItem()
        Me.biStyle = New DevExpress.XtraBars.BarEditItem()
        Me.riicStyle = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.biSkin = New DevExpress.XtraBars.BarEditItem()
        Me.ListSkin = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.TabTrs = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.GrupTrs = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.TabMaster = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.GrupMaster = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GrupPegawai = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.riicSkin = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.MdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.LookNFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListSkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riicSkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonText = Nothing
        '
        '
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ExpandCollapseItem.Name = ""
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.mnuOrder, Me.mnuAbsensi, Me.MnuMasterProduk, Me.MnuGrupProduk, Me.MnuMasterKaryawan, Me.biStyle, Me.biSkin})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 15
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.PageHeaderItemLinks.Add(Me.biStyle)
        Me.RibbonControl.PageHeaderItemLinks.Add(Me.biSkin)
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.TabTrs, Me.TabMaster})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.riicSkin, Me.ListSkin})
        Me.RibbonControl.SelectedPage = Me.TabTrs
        Me.RibbonControl.Size = New System.Drawing.Size(957, 145)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'mnuOrder
        '
        Me.mnuOrder.Caption = "Order"
        Me.mnuOrder.Id = 4
        Me.mnuOrder.LargeGlyph = Global.Graphic_Land.My.Resources.Resources.Ordering
        Me.mnuOrder.Name = "mnuOrder"
        '
        'mnuAbsensi
        '
        Me.mnuAbsensi.Caption = "Absensi"
        Me.mnuAbsensi.Id = 5
        Me.mnuAbsensi.LargeGlyph = Global.Graphic_Land.My.Resources.Resources.Absensi
        Me.mnuAbsensi.Name = "mnuAbsensi"
        '
        'MnuMasterProduk
        '
        Me.MnuMasterProduk.Caption = "Produk"
        Me.MnuMasterProduk.Id = 6
        Me.MnuMasterProduk.LargeGlyph = Global.Graphic_Land.My.Resources.Resources.Produk
        Me.MnuMasterProduk.Name = "MnuMasterProduk"
        '
        'MnuGrupProduk
        '
        Me.MnuGrupProduk.Caption = "Grup Produk"
        Me.MnuGrupProduk.Id = 7
        Me.MnuGrupProduk.LargeGlyph = Global.Graphic_Land.My.Resources.Resources.Grup_Produk
        Me.MnuGrupProduk.Name = "MnuGrupProduk"
        '
        'MnuMasterKaryawan
        '
        Me.MnuMasterKaryawan.Caption = "Pegawai"
        Me.MnuMasterKaryawan.Id = 8
        Me.MnuMasterKaryawan.LargeGlyph = Global.Graphic_Land.My.Resources.Resources.Karyawan
        Me.MnuMasterKaryawan.Name = "MnuMasterKaryawan"
        '
        'biStyle
        '
        Me.biStyle.Caption = "Style"
        Me.biStyle.Edit = Me.riicStyle
        Me.biStyle.Id = 12
        Me.biStyle.Name = "biStyle"
        Me.biStyle.Width = 100
        '
        'riicStyle
        '
        Me.riicStyle.AutoHeight = False
        Me.riicStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicStyle.Name = "riicStyle"
        '
        'biSkin
        '
        Me.biSkin.Caption = "Skin"
        Me.biSkin.Edit = Me.ListSkin
        Me.biSkin.Id = 14
        Me.biSkin.Name = "biSkin"
        Me.biSkin.Width = 100
        '
        'ListSkin
        '
        Me.ListSkin.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.ListSkin.AutoHeight = False
        Me.ListSkin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ListSkin.Name = "ListSkin"
        '
        'TabTrs
        '
        Me.TabTrs.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.GrupTrs})
        Me.TabTrs.Name = "TabTrs"
        Me.TabTrs.Text = "Transaksi"
        '
        'GrupTrs
        '
        Me.GrupTrs.ItemLinks.Add(Me.mnuOrder)
        Me.GrupTrs.ItemLinks.Add(Me.mnuAbsensi)
        Me.GrupTrs.Name = "GrupTrs"
        Me.GrupTrs.Text = "Transaksi"
        '
        'TabMaster
        '
        Me.TabMaster.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.GrupMaster, Me.GrupPegawai})
        Me.TabMaster.Name = "TabMaster"
        Me.TabMaster.Text = "Master Data"
        '
        'GrupMaster
        '
        Me.GrupMaster.ItemLinks.Add(Me.MnuGrupProduk)
        Me.GrupMaster.ItemLinks.Add(Me.MnuMasterProduk)
        Me.GrupMaster.Name = "GrupMaster"
        Me.GrupMaster.Text = "Master Produk"
        '
        'GrupPegawai
        '
        Me.GrupPegawai.ItemLinks.Add(Me.MnuMasterKaryawan)
        Me.GrupPegawai.Name = "GrupPegawai"
        Me.GrupPegawai.Text = "Master Pegawai"
        '
        'riicSkin
        '
        Me.riicSkin.AutoHeight = False
        Me.riicSkin.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.riicSkin.Name = "riicSkin"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 568)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(957, 31)
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'MdiManager
        '
        Me.MdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader
        Me.MdiManager.MdiParent = Me
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 599)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Graphic Land Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListSkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riicSkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents TabTrs As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents GrupTrs As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents mnuOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuAbsensi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TabMaster As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents GrupMaster As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents MnuMasterProduk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnuGrupProduk As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MnuMasterKaryawan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GrupPegawai As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Public WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents biStyle As DevExpress.XtraBars.BarEditItem
    Friend WithEvents riicStyle As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents riicSkin As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents biSkin As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ListSkin As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents MdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents LookNFeel As DevExpress.LookAndFeel.DefaultLookAndFeel


End Class
