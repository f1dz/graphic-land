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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(656, 100)
        Me.PanelControl1.TabIndex = 0
        '
        'frmTrsOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 368)
        Me.Controls.Add(Me.PanelControl1)
        Me.LookAndFeel.SkinName = "Money Twins"
        Me.Name = "frmTrsOrder"
        Me.Text = "Transaksi Order"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
