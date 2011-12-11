Public Class frmTrsOrder
    Private Sub frmTrsOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Splitter()
    End Sub

    Private Sub Splitter()
        SplitContainer.SplitterPosition = SplitContainer.Size.Width / 2
    End Sub

    Private Sub SplitContainer_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer.SizeChanged
        Splitter()
    End Sub

End Class