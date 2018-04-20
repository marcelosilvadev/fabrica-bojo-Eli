Public Class FrmMateriaPrimaPedido
    Dim negocioPedido As pedidoBLL
    Dim dt As DataTable
    Dim drv As DataRowView
    Dim msg As String
    Dim totalEspuma As Decimal = 0
    Dim totalCusto As Decimal = 0
    Dim custoEpuma As Decimal = 0
    Dim verba As Decimal
    Dim maoObra As Decimal
    Private Sub FrmMateriaPrimaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            negocioPedido = New pedidoBLL
            dt = negocioPedido.buscarResultado()
            For i = 0 To dt.Rows.Count - 1
                drv = dt.DefaultView(i)
                totalCusto += (drv.Item("CUSTO_ESPUMA") + drv.Item("CUSTO_TECIDO"))
                totalEspuma += (drv.Item("ESPUMA"))
                custoEpuma += (drv.Item("CUSTO_ESPUMA"))
            Next
            DG.Rows.Add()
            DG.Rows(0).Cells(0).Value = "Espuma"
            DG.Rows(0).Cells(1).Value = "----"
            DG.Rows(0).Cells(2).Value = totalEspuma
            DG.Rows(0).Cells(3).Value = custoEpuma

            For i = 0 To dt.Rows.Count - 1
                drv = dt.DefaultView(i)
                DG.Rows.Add()
                DG.Rows(i + 1).Cells(0).Value = "Tecido"
                DG.Rows(i + 1).Cells(1).Value = drv.Item("COR")
                DG.Rows(i + 1).Cells(2).Value = drv.Item("TECIDO")
                DG.Rows(i + 1).Cells(3).Value = drv.Item("CUSTO_TECIDO")
            Next
            txtCustoTotal.Text = totalCusto
            txtVerba.Text = totalCusto * 0.1
            txtMaoObra.Text = totalCusto * 0.3
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class