Public Class pedidoBLL
    Dim obj As produtosVO
    Dim bd As pedidoDAO
    Public Function gravaPedido(idPedido, descricao, cor, quantidade, data)
        Try
            bd = New pedidoDAO
            Return bd.gravaPedido(idPedido, descricao, cor, quantidade, data)
        Catch ex As Exception

        End Try
    End Function
    Public Function buscaPedidos()
        Try
            bd = New pedidoDAO
            Return bd.buscaPedidos()
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function buscarResultado()
        Try
            bd = New pedidoDAO
            Return bd.buscarResultado()
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function buscaExistePedido(idPedido)
        Try
            bd = New pedidoDAO
            Return bd.buscaExistePedido(idPedido)
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
