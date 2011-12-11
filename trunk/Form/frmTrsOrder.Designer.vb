<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrsOrder
    'Inherits DevExpress.XtraEditors.XtraForm
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Me.Hide()
    '    Me.AllowFormSkin = False

    '    If disposing AndAlso components IsNot Nothing Then
    '        components.Dispose()
    '    End If

    '    MyBase.Dispose(disposing)
    'End Sub
    'Protected Overrides Function GetAllowSkin() As Boolean
    '    If DesignMode Then Return False
    '    If AllowFormSkin AndAlso DevExpress.Skins.SkinManager.AllowFormSkins Then
    '        If FormBorderStyle = Windows.Forms.FormBorderStyle.None Then Return False
    '        If Not ControlBox AndAlso (String.IsNullOrEmpty(Text)) Then Return False
    '        Return LookAndFeel.ActiveStyle = DevExpress.LookAndFeel.ActiveLookAndFeelStyle.Skin
    '    End If
    '    Return False
    'End Function


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTelp = New DevExpress.XtraEditors.TextEdit()
        Me.TxtAlmPelanggan = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtNmPelanggan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtKdOrder = New DevExpress.XtraEditors.ButtonEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtNmSales = New DevExpress.XtraEditors.TextEdit()
        Me.LabelSales = New DevExpress.XtraEditors.LabelControl()
        Me.TxtKdSales = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.TxtJamOrder = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtTglOrder = New DevExpress.XtraEditors.DateEdit()
        Me.SplitContainer = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.KodeProduk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxtKodeProduk = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.NamaProduk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TxtTelp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAlmPelanggan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNmPelanggan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKdOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TxtNmSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKdSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtJamOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglOrder.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTglOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtKodeProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.TxtTelp)
        Me.GroupControl1.Controls.Add(Me.TxtAlmPelanggan)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.TxtNmPelanggan)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TxtKdOrder)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(412, 154)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Data Pelanggan"
        '
        'LabelControl4
        '
        Me.LabelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl4.Location = New System.Drawing.Point(47, 130)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Telepon"
        '
        'TxtTelp
        '
        Me.TxtTelp.EnterMoveNextControl = True
        Me.TxtTelp.Location = New System.Drawing.Point(91, 127)
        Me.TxtTelp.Name = "TxtTelp"
        Me.TxtTelp.Size = New System.Drawing.Size(201, 20)
        Me.TxtTelp.TabIndex = 7
        '
        'TxtAlmPelanggan
        '
        Me.TxtAlmPelanggan.Location = New System.Drawing.Point(91, 77)
        Me.TxtAlmPelanggan.Name = "TxtAlmPelanggan"
        Me.TxtAlmPelanggan.Size = New System.Drawing.Size(316, 44)
        Me.TxtAlmPelanggan.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl3.Location = New System.Drawing.Point(52, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Alamat"
        '
        'LabelControl2
        '
        Me.LabelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl2.Location = New System.Drawing.Point(5, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Nama Pelanggan"
        '
        'TxtNmPelanggan
        '
        Me.TxtNmPelanggan.EnterMoveNextControl = True
        Me.TxtNmPelanggan.Location = New System.Drawing.Point(91, 51)
        Me.TxtNmPelanggan.Name = "TxtNmPelanggan"
        Me.TxtNmPelanggan.Size = New System.Drawing.Size(316, 20)
        Me.TxtNmPelanggan.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl1.Location = New System.Drawing.Point(30, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Kode Order"
        '
        'TxtKdOrder
        '
        Me.TxtKdOrder.EditValue = ""
        Me.TxtKdOrder.EnterMoveNextControl = True
        Me.TxtKdOrder.Location = New System.Drawing.Point(91, 25)
        Me.TxtKdOrder.Name = "TxtKdOrder"
        Me.TxtKdOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKdOrder.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtKdOrder.Size = New System.Drawing.Size(90, 20)
        Me.TxtKdOrder.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TxtNmSales)
        Me.GroupControl2.Controls.Add(Me.LabelSales)
        Me.GroupControl2.Controls.Add(Me.TxtKdSales)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.DateEdit1)
        Me.GroupControl2.Controls.Add(Me.TxtJamOrder)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.TxtTglOrder)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(410, 154)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Data Order"
        '
        'TxtNmSales
        '
        Me.TxtNmSales.EnterMoveNextControl = True
        Me.TxtNmSales.Location = New System.Drawing.Point(155, 76)
        Me.TxtNmSales.Name = "TxtNmSales"
        Me.TxtNmSales.Properties.ReadOnly = True
        Me.TxtNmSales.Size = New System.Drawing.Size(250, 20)
        Me.TxtNmSales.TabIndex = 15
        '
        'LabelSales
        '
        Me.LabelSales.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelSales.Location = New System.Drawing.Point(34, 79)
        Me.LabelSales.Name = "LabelSales"
        Me.LabelSales.Size = New System.Drawing.Size(55, 13)
        Me.LabelSales.TabIndex = 14
        Me.LabelSales.Text = "Kode Order"
        '
        'TxtKdSales
        '
        Me.TxtKdSales.EditValue = ""
        Me.TxtKdSales.EnterMoveNextControl = True
        Me.TxtKdSales.Location = New System.Drawing.Point(95, 76)
        Me.TxtKdSales.Name = "TxtKdSales"
        Me.TxtKdSales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKdSales.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtKdSales.Properties.MaxLength = 5
        Me.TxtKdSales.Size = New System.Drawing.Size(54, 20)
        Me.TxtKdSales.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl6.Location = New System.Drawing.Point(15, 54)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Tanggal Selesai"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2011, 12, 1, 6, 41, 50, 0)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(95, 51)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.DateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit1.TabIndex = 11
        '
        'TxtJamOrder
        '
        Me.TxtJamOrder.EditValue = "00:00:00"
        Me.TxtJamOrder.EnterMoveNextControl = True
        Me.TxtJamOrder.Location = New System.Drawing.Point(181, 25)
        Me.TxtJamOrder.Name = "TxtJamOrder"
        Me.TxtJamOrder.Size = New System.Drawing.Size(52, 20)
        Me.TxtJamOrder.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.LabelControl5.Location = New System.Drawing.Point(20, 28)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Tanggal Order"
        '
        'TxtTglOrder
        '
        Me.TxtTglOrder.EditValue = New Date(2011, 12, 1, 6, 41, 50, 0)
        Me.TxtTglOrder.EnterMoveNextControl = True
        Me.TxtTglOrder.Location = New System.Drawing.Point(95, 25)
        Me.TxtTglOrder.Name = "TxtTglOrder"
        Me.TxtTglOrder.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.TxtTglOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtTglOrder.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglOrder.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglOrder.Properties.EditFormat.FormatString = "dd-MM-yyyy"
        Me.TxtTglOrder.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TxtTglOrder.Properties.Mask.EditMask = "dd-MM-yyyy"
        Me.TxtTglOrder.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtTglOrder.Size = New System.Drawing.Size(80, 20)
        Me.TxtTglOrder.TabIndex = 0
        '
        'SplitContainer
        '
        Me.SplitContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainer.Panel1.Text = "Panel1"
        Me.SplitContainer.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainer.Panel2.Text = "Panel2"
        Me.SplitContainer.Size = New System.Drawing.Size(827, 154)
        Me.SplitContainer.SplitterPosition = 412
        Me.SplitContainer.TabIndex = 3
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 172)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(827, 312)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Data Order"
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(2, 22)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.TxtKodeProduk, Me.RepositoryItemTextEdit1})
        Me.GridControl.Size = New System.Drawing.Size(823, 288)
        Me.GridControl.TabIndex = 0
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Appearance.OddRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GridView.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KodeProduk, Me.NamaProduk, Me.Qty})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'KodeProduk
        '
        Me.KodeProduk.Caption = "Kode"
        Me.KodeProduk.ColumnEdit = Me.TxtKodeProduk
        Me.KodeProduk.Name = "KodeProduk"
        Me.KodeProduk.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.KodeProduk.Visible = True
        Me.KodeProduk.VisibleIndex = 0
        '
        'TxtKodeProduk
        '
        Me.TxtKodeProduk.AutoHeight = False
        Me.TxtKodeProduk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TxtKodeProduk.Name = "TxtKodeProduk"
        '
        'NamaProduk
        '
        Me.NamaProduk.Caption = "Nama Produk"
        Me.NamaProduk.Name = "NamaProduk"
        Me.NamaProduk.OptionsColumn.AllowEdit = False
        Me.NamaProduk.OptionsColumn.AllowFocus = False
        Me.NamaProduk.Visible = True
        Me.NamaProduk.VisibleIndex = 1
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.Qty.DisplayFormat.FormatString = "0"
        Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty.Name = "Qty"
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 2
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatString = "#"
        Me.RepositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.EditFormat.FormatString = "#"
        Me.RepositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'frmTrsOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 496)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.SplitContainer)
        Me.LookAndFeel.SkinName = "Money Twins"
        Me.Name = "frmTrsOrder"
        Me.Text = "Transaksi Order"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TxtTelp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAlmPelanggan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNmPelanggan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKdOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TxtNmSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKdSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtJamOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglOrder.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTglOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtKodeProduk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainer As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents TxtAlmPelanggan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtNmPelanggan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtKdOrder As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtTelp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelSales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtKdSales As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TxtNmSales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtJamOrder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTglOrder As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtKodeProduk As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KodeProduk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaProduk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
