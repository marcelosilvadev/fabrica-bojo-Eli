Public Class pedidoDAO
    Dim sql As String
    Dim dt As DataTable
    Dim conn As New DAOconfig
    Dim msg As String
    Public Function gravaPedido(idPedido, descricao, cor, quantidade, data)
        Try
            conn.connectar()
            sql = String.Empty
            sql = <sql>
                      INSERT INTO TB_PEDIDOS VALUES(<%= idPedido %>, '<%= descricao %>', '<%= cor %>', <%= quantidade %>, '<%= data %>')
                  </sql>
            conn.execQuery(sql)
            conn.fechar()
            Return "Pedido inserido com sucesso!"
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function buscaPedidos()
        Try
            conn.connectar()
            sql = String.Empty
            sql = <sql>
                      SELECT * FROM TB_PEDIDOS
                  </sql>
            dt = conn.execQuery(sql)
            conn.fechar()
            Return dt
        Catch ex As Exception

        End Try
    End Function
    Public Function buscarResultado()
        Try
            conn.connectar()
            sql = String.Empty
            sql = <sql>
                      SELECT	COR,
		                        TOTAL, 
		                        TOTAL_PLACAS, 
		                        TOTAL_PLACAS*1.2 AS ESPUMA, 
		                        TOTAL_PLACAS*0.4 AS TECIDO, 
		                        ROUND(TOTAL_PLACAS*1.2 * (SELECT VALOR_CUSTO FROM tb_produtos WHERE descricao LIKE 'Espuma'), 2) AS CUSTO_ESPUMA,
		                        ROUND(TOTAL_PLACAS*0.4 * (SELECT VALOR_CUSTO FROM tb_produtos WHERE descricao LIKE 'Tecido'), 2) AS CUSTO_TECIDO
	                        FROM (
			                        SELECT COR, TOTAL, ROUND(((TOTAL_MARGEM - (TOTAL_MARGEM % 8)) / 8 + 1), 0) AS TOTAL_PLACAS
				                        FROM (
						                        SELECT COR, TOTAL, (TOTAL*1.1) AS TOTAL_MARGEM
						                        FROM (
								                        SELECT COR, SUM(CAST(QUANTIDADE AS NUMERIC)) AS TOTAL
									                        FROM TB_PEDIDOS
								                        GROUP BY COR
						                        ) AS PEDIDO
				                        ) AS PLACAS
	                        ) AS CUSTO 
	                        ORDER BY COR;
                  </sql>
            dt = conn.execQuery(sql)
            conn.fechar()
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function buscaExistePedido(idPedido)
        Try
            conn.connectar()
            sql = String.Empty
            sql = <sql>
                      SELECT * FROM TB_PEDIDOS WHERE ID_PEDIDO = <%= idPedido %>
                  </sql>
            dt = conn.execQuery(sql)
            conn.fechar()
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
