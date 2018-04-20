Public Class FrmCadMateriaPrima
    Dim msg As String
    Dim dt As DataTable
    Dim drv As DataRowView
    Dim negocioProdutos As produtosBLL
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Try
            Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Try
            Novo()
        Catch ex As Exception

        End Try
    End Sub
    Public Function Novo()
        Try
            txtCodBarra.Text = String.Empty
            txtDescricao.Text = String.Empty
            txtQuantidade.Text = String.Empty
            txtValorCusto.Text = String.Empty
            txtValorVenda.Text = String.Empty
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            If txtCodBarra.Text = String.Empty Then
                MessageBox.Show("Por favor preencha o campo de Código de Barras !", "Atenção!")
                Exit Sub
            End If
            If txtDescricao.Text = String.Empty Then
                MessageBox.Show("Por favor preencha o campo Descrição !", "Atenção!")
                Exit Sub
            End If
            If txtQuantidade.Text = String.Empty Then
                MessageBox.Show("Por favor preencha o campo de Quantidade !", "Atenção!")
                Exit Sub
            End If
            If txtValorCusto.Text = String.Empty Then
                MessageBox.Show("Por favor preencha o campo de Valor de Custo !", "Atenção!")
                Exit Sub
            End If
            If txtValorVenda.Text = String.Empty Then
                MessageBox.Show("Por favor preencha o campo de Valor de Venda !", "Atenção!")
                Exit Sub
            End If
            negocioProdutos = New produtosBLL
            msg = negocioProdutos.gravaProduto(txtCodBarra.Text,
                                              txtDescricao.Text,
                                              txtQuantidade.Text,
                                              txtValorCusto.Text,
                                              txtValorVenda.Text)
            MessageBox.Show(msg, "Atenção!")
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            FrmPesqMateriaPrima.ShowDialog()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If txtCodBarra.Text = String.Empty Then
                MessageBox.Show("Por favor insira o código do produto qe deseja excluir!", "Atenção!")
                Exit Sub
            End If
            negocioProdutos = New produtosBLL
            msg = negocioProdutos.excluiProduto(txtCodBarra.Text)
            MessageBox.Show(msg, "Atenção!")
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub txtQuantidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantidade.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "+" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodBarra.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "+" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValorCusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorCusto.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "+" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValorVenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorVenda.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "+" Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmCadMateriaPrima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Novo()
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class