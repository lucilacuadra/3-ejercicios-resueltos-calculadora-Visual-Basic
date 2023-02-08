Public Class frmMenuEjercicios
    Private Sub btnform1_Click(sender As Object, e As EventArgs) Handles btnform1.Click
        frmejercicioguardardatos.Show()

    End Sub

    Private Sub btnform2_Click(sender As Object, e As EventArgs) Handles btnform2.Click
        frmnombreapellidoedad.Show()
    End Sub

    Private Sub btnform3_Click(sender As Object, e As EventArgs) Handles btnform3.Click
        frmhagamoscalculos.Show()
    End Sub

    Private Sub btnform4_Click(sender As Object, e As EventArgs) Handles btnform4.Click
        FrmMenuPrincipal.Show()
    End Sub
End Class
