Public Class produtosBLL
    Dim obj As produtosVO
    Dim bd As produtosDAO
    Public Function gravaProduto(codBarra, descricao, quantidade, valorCusto, valorVenda)
        Try
            obj = New produtosVO
            obj.cod_barra = IIf(codBarra = String.Empty, 0, codBarra)
            obj.descricao = descricao
            obj.quantidade = quantidade
            obj.valor_custo = valorCusto
            obj.valor_venda = valorVenda
            bd = New produtosDAO
            Return bd.gravarProduto(obj)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function buscaProduto(codBarra, descricao)
        Try
            obj = New produtosVO
            obj.cod_barra = IIf(codBarra = String.Empty, 0, codBarra)
            obj.descricao = descricao
            bd = New produtosDAO
            Return bd.buscarProduto(obj)
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function excluiProduto(codBarra)
        Try
            obj = New produtosVO
            obj.cod_barra = IIf(codBarra = String.Empty, 0, codBarra)
            bd = New produtosDAO
            Return bd.excluirProduto(obj)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class