Public Class FrmMenuPrincipal
    Private Sub btnform1_Click(sender As Object, e As EventArgs) Handles btnform1.Click
        frmFormulario1.Show()
    End Sub

    Private Sub btnform2_Click(sender As Object, e As EventArgs) Handles btnform2.Click
        frmFormulario2.ShowDialog()
    End Sub

    Private Sub btnform3_Click(sender As Object, e As EventArgs) Handles btnform3.Click
        frmFormulario3.Show()
    End Sub
End Class