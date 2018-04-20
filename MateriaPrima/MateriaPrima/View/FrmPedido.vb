Public Class FrmPedido
    Dim negocioPedido As pedidoBLL
    Dim dt As DataTable
    Dim drv As DataRowView
    Dim msg As String
    Private Sub FrmPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtDataHoje.Text = Date.Now
            pesquisarPedidos()
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

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            txtCodBarra.Text = String.Empty
            txtQuantidade.Text = String.Empty
            txtDataHoje.Text = Date.Now
            cmbCor.Text = String.Empty
            DG.DataSource = Nothing
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            negocioPedido = New pedidoBLL
            msg = negocioPedido.gravaPedido(txtCodBarra.Text, txtDescricao.Text, cmbCor.Text, txtQuantidade.Text, txtDataHoje.Text)
            MessageBox.Show(msg, "Atenção")
            pesquisarPedidos()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            pesquisarPedidos()
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Public Function pesquisarPedidos()
        Try
            negocioPedido = New pedidoBLL
            dt = negocioPedido.buscaPedidos()
            DG.DataSource = dt
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnMateriaPrima_Click(sender As Object, e As EventArgs) Handles btnMateriaPrima.Click
        Try
            FrmMateriaPrimaPedido.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodBarra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            negocioPedido = New pedidoBLL
            dt = negocioPedido.buscaExistePedido(txtCodBarra.Text)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Codigo de pedido ja existente. insira um novo codigo!", "Atenção")
                txtCodBarra.Text = String.Empty
            End If
        End If
    End Sub
End Class