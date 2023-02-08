Public Class frmejercicioguardardatos


    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click


        If Val(Me.txtnumero.Text) = 0 Then
            MsgBox("ingrese un numero", vbCritical)
            txtnumero.Text = ""
            txtnumero.Focus()

        End If

        lblpenultimo.Text = lblanteultimo.Text
        lblanteultimo.Text = lblultimo.Text
        lblultimo.Text = txtnumero.Text

        lbltotalingresados.Text = Val(lbltotalingresados.Text) + 1
        lbltotalnumero.Text = Val(lbltotalnumero.Text) + Val(txtnumero.Text)
        lblpromedio.Text = Val(lbltotalnumero.Text) / Val(lbltotalingresados.Text)
        txtnumero.Text = ""
        txtnumero.Focus()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbltotalingresados.Click

    End Sub

    Private Sub lblanteultimo_Click(sender As Object, e As EventArgs) Handles lblanteultimo.Click

    End Sub
End Class