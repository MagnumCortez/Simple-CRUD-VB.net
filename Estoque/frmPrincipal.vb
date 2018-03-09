Public Class frmPrincipal
    Private Sub ProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutoToolStripMenuItem.Click
        frmMain.MdiParent = Me
        frmMain.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        frmCategoria.MdiParent = Me
        frmCategoria.Show()
    End Sub
End Class