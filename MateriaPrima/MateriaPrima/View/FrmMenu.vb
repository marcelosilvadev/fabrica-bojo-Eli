Public Class FrmMenu
    Private Sub btnMateriaPrima_Click(sender As Object, e As EventArgs) Handles btnMateriaPrima.Click
        FrmPedido.ShowDialog()
    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        FrmCadMateriaPrima.ShowDialog()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Panel1.Focus()
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
