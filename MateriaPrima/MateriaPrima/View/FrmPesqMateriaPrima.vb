Public Class FrmPesqMateriaPrima
    Dim negocioProduto As produtosBLL
    Dim dt As DataTable
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            txtCodBarra.Text = String.Empty
            txtDescricao.Text = String.Empty
            dgMateriaPrima.DataSource = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Try
            Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            negocioProduto = New produtosBLL
            dt = negocioProduto.buscaProduto(txtCodBarra.Text, txtDescricao.Text)
            dgMateriaPrima.DataSource = dt
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtCodBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodBarra.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "+" Then
            e.Handled = True
        End If
    End Sub
End Class