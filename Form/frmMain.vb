Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.LookAndFeel
Public Class frmMain
    Public Overridable Property SkinName As String
    Private Sub mnuOrder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuOrder.ItemClick
        frmTrsOrder.MdiParent = Me
        frmTrsOrder.Show()
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitEditors()
        InitSkin()
    End Sub

    Sub InitEditors()
        riicStyle.Items.Add(New ImageComboBoxItem("Default", RibbonControlStyle.Default, -1))
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1))
        riicStyle.Items.Add(New ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1))
        biStyle.EditValue = RibbonControl.RibbonStyle
    End Sub

    Sub InitSkin()
        ListSkin.Items.Add(New ComboBoxItem("Black"))
        ListSkin.Items.Add(New ComboBoxItem("DevExpress Style"))
        ListSkin.Items.Add(New ComboBoxItem("Caramel"))
        ListSkin.Items.Add(New ComboBoxItem("Money Twins"))
        ListSkin.Items.Add(New ComboBoxItem("DevExpress Dark Style"))
        ListSkin.Items.Add(New ComboBoxItem("Lilian"))
        ListSkin.Items.Add(New ComboBoxItem("iMaginary"))
        ListSkin.Items.Add(New ComboBoxItem("Blue"))
        biSkin.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused
        biSkin.EditValue = DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName
    End Sub
    Private Sub biStyle_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles biStyle.EditValueChanged
        RibbonControl.RibbonStyle = CType(biStyle.EditValue, RibbonControlStyle)
    End Sub

    Private Sub biSkin_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles biSkin.EditValueChanged
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = biSkin.EditValue
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        biStyle.EditValue = RibbonControl.RibbonStyle
        'MsgBox(RibbonControl.RibbonStyle.ToString)
    End Sub
End Class