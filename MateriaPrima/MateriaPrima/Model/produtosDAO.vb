Imports System.Data
Imports System
Imports System.Data.SqlClient
Imports System.Text
Public Class produtosDAO
    Dim sql As String
    Dim dt As DataTable
    Dim conn As New DAOconfig
    Dim msg As String
    Public Function gravarProduto(obj)
        Try
            conn.connectar()
            sql = String.Empty
            sql = <sql>
                      SELECT * FROM TB_PRODUTOS WHERE ID_PRODUTO = <%= obj.cod_Barra %>
                  </sql>
            dt = conn.execQuery(sql)

            If dt.Rows.Count = 0 Then
                sql = <sql>
                      INSERT INTO TB_PRODUTOS
                        VALUES
                        (<%= obj.cod_Barra %>, '<%= obj.descricao %>', <%= obj.quantidade %>, <%= obj.valor_custo %>, <%= obj.valor_venda %>);
                  </sql>
                msg = "Produto inserido com sucesso!"
            Else
                sql = <sql>
                        UPDATE TB_PRODUTOS SET DESCRICAO = '<%= obj.descricao %>', 
                                                QUANTIDADE = <%= obj.quantidade %>, 
                                                VALOR_CUSTO = <%= obj.valor_custo %>, 
                                                VALOR_VENDA = <%= obj.valor_venda %>
                          WHERE ID_PRODUTO = <%= obj.cod_Barra %>;
                  </sql>
                msg = "Produto atualizado com sucesso!"
            End If
            conn.execQuery(sql)
            conn.fechar()
            Return msg
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function buscarProduto(obj)
        Try
            conn.connectar()
            sql = String.Empty
            sql = <sql>
                      SELECT ID_PRODUTO,
                             DESCRICAO,
                             QUANTIDADE,
                             VALOR_CUSTO,
                             VALOR_VENDA
                     FROM TB_PRODUTOS
                     WHERE 1=1
                  </sql>
            If obj.cod_Barra <> 0 Then
                sql += "AND ID_PRODUTO = " & obj.cod_Barra & " "
            End If
            If obj.descricao <> String.Empty Then
                sql += "AND DESCRICAO LIKE %" & obj.cod_Barra & "%; "
            End If
            dt = conn.execQuery(sql)
            conn.fechar()
            Return dt
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Function excluirProduto(obj)
        Try
            conn.connectar()
            sql = String.Empty
            sql = <sql>
                      SELECT * FROM TB_PRODUTOS WHERE ID_PRODUTO = <%= obj.cod_Barra %>
                  </sql>
            dt = conn.execQuery(sql)
            If dt.Rows.Count > 0 Then
                sql = <sql>
                      DELETE FROM TB_PRODUTOS WHERE ID_PRODUTO = <%= obj.cod_Barra %>
                      </sql>
                msg = "Produto removido com sucesso!"
            Else
                msg = "Produto inválido !"
            End If
            conn.execQuery(sql)
            conn.fechar()
            Return msg
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
