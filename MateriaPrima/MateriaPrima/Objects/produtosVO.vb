Public Class produtosVO
    Private codBarra As Integer
    Private descricao_produto As String
    Private quantidade_produto As Integer
    Private valorCusto As Decimal
    Private valorVenda As Decimal

    Public Property cod_barra() As Integer
        Get
            Return codBarra
        End Get
        Set(ByVal Value As Integer)
            codBarra = Value
        End Set
    End Property
    Public Property descricao() As String
        Get
            Return descricao_produto
        End Get
        Set(ByVal Value As String)
            descricao_produto = Value
        End Set
    End Property

    Public Property quantidade() As Integer
        Get
            Return quantidade_produto
        End Get
        Set(ByVal Value As Integer)
            quantidade_produto = Value
        End Set
    End Property
    Public Property valor_custo() As Decimal
        Get
            Return valorCusto
        End Get
        Set(ByVal Value As Decimal)
            valorCusto = Value
        End Set
    End Property
    Public Property valor_venda() As Decimal
        Get
            Return valorVenda
        End Get
        Set(ByVal Value As Decimal)
            valorVenda = Value
        End Set
    End Property
End Class
