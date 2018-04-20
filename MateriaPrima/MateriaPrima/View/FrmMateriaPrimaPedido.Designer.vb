<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateriaPrimaPedido
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.txtCustoTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVerba = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaoObra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.colMateriaPrima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtMaoObra)
        Me.Panel1.Controls.Add(Me.DG)
        Me.Panel1.Controls.Add(Me.txtCustoTotal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtVerba)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 191)
        Me.Panel1.TabIndex = 4
        '
        'DG
        '
        Me.DG.AllowUserToAddRows = False
        Me.DG.AllowUserToDeleteRows = False
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMateriaPrima, Me.colCor, Me.colQuantidade, Me.colValor})
        Me.DG.Location = New System.Drawing.Point(3, 3)
        Me.DG.Name = "DG"
        Me.DG.ReadOnly = True
        Me.DG.Size = New System.Drawing.Size(516, 122)
        Me.DG.TabIndex = 28
        '
        'txtCustoTotal
        '
        Me.txtCustoTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustoTotal.Location = New System.Drawing.Point(3, 157)
        Me.txtCustoTotal.Name = "txtCustoTotal"
        Me.txtCustoTotal.ReadOnly = True
        Me.txtCustoTotal.Size = New System.Drawing.Size(146, 20)
        Me.txtCustoTotal.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Custo Total"
        '
        'txtVerba
        '
        Me.txtVerba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVerba.Location = New System.Drawing.Point(155, 157)
        Me.txtVerba.Name = "txtVerba"
        Me.txtVerba.ReadOnly = True
        Me.txtVerba.Size = New System.Drawing.Size(181, 20)
        Me.txtVerba.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Verba de MKT"
        '
        'txtMaoObra
        '
        Me.txtMaoObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaoObra.Location = New System.Drawing.Point(342, 157)
        Me.txtMaoObra.Name = "txtMaoObra"
        Me.txtMaoObra.ReadOnly = True
        Me.txtMaoObra.Size = New System.Drawing.Size(177, 20)
        Me.txtMaoObra.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Custo Mão de Obra"
        '
        'colMateriaPrima
        '
        Me.colMateriaPrima.HeaderText = "Materia Prima"
        Me.colMateriaPrima.Name = "colMateriaPrima"
        Me.colMateriaPrima.ReadOnly = True
        '
        'colCor
        '
        Me.colCor.HeaderText = "Cor"
        Me.colCor.Name = "colCor"
        Me.colCor.ReadOnly = True
        '
        'colQuantidade
        '
        Me.colQuantidade.HeaderText = "Quantidade"
        Me.colQuantidade.Name = "colQuantidade"
        Me.colQuantidade.ReadOnly = True
        '
        'colValor
        '
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        Me.colValor.ReadOnly = True
        '
        'FrmMateriaPrimaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 193)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMateriaPrimaPedido"
        Me.Text = "FrmMateriaPrimaPedido"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DG As DataGridView
    Friend WithEvents txtCustoTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVerba As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaoObra As TextBox
    Friend WithEvents colMateriaPrima As DataGridViewTextBoxColumn
    Friend WithEvents colCor As DataGridViewTextBoxColumn
    Friend WithEvents colQuantidade As DataGridViewTextBoxColumn
    Friend WithEvents colValor As DataGridViewTextBoxColumn
End Class
