Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing

Public Class DAOconfig
    Private objConexao As SqlClient.SqlConnection

    Public Sub connectar()
        Try
            objConexao = New SqlClient.SqlConnection("Data Source = DESKTOP-599RIT3;Initial Catalog = materiaPrima; User Id = sa; Password=1234;")
            objConexao.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub fechar()
        Try
            If Not IsNothing(objConexao) Then
                If objConexao.State = ConnectionState.Open Then
                    objConexao.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function execQuery(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Dim objCommand As New SqlClient.SqlCommand
        Try
            objCommand = objConexao.CreateCommand
            objCommand.CommandText = sql
            objDataAdapter = New SqlClient.SqlDataAdapter(objCommand)
            objDataAdapter.Fill(dt)
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

End Class
