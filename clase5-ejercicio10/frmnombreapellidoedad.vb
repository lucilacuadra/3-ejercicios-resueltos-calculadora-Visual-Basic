Public Class frmnombreapellidoedad





    Private Sub btnnombre_Click(sender As Object, e As EventArgs) Handles btnnombre.Click
        Me.lblnombre.Text = "Lucila"
    End Sub

    Private Sub btnapellido_Click(sender As Object, e As EventArgs) Handles btnapellido.Click

        Me.lblapellido.Text = "Cuadra"

    End Sub

    Private Sub btnedad_Click(sender As Object, e As EventArgs) Handles btnedad.Click

        Me.lbledad.Text = "26"
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        Me.lblnombre.Text = ""
        Me.lblapellido.Text = ""
        Me.lbledad.Text = ""
    End Sub

    Private Sub frmnombreapellidoedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
