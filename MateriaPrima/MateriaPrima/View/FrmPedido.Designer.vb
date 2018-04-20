<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedido
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
        Me.cmbCor = New System.Windows.Forms.ComboBox()
        Me.txtDataHoje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMateriaPrima = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnMateriaPrima)
        Me.Panel1.Controls.Add(Me.DG)
        Me.Panel1.Controls.Add(Me.cmbCor)
        Me.Panel1.Controls.Add(Me.txtDataHoje)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtQuantidade)
        Me.Panel1.Controls.Add(Me.btnGravar)
        Me.Panel1.Controls.Add(Me.txtCodBarra)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnSair)
        Me.Panel1.Controls.Add(Me.txtDescricao)
        Me.Panel1.Controls.Add(Me.btnPesquisar)
        Me.Panel1.Controls.Add(Me.btnNovo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 290)
        Me.Panel1.TabIndex = 3
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(6, 163)
        Me.DG.Name = "DG"
        Me.DG.Size = New System.Drawing.Size(511, 122)
        Me.DG.TabIndex = 28
        '
        'cmbCor
        '
        Me.cmbCor.FormattingEnabled = True
        Me.cmbCor.Items.AddRange(New Object() {"VERMELHO", "VERDE", "AZUL", "PRETO"})
        Me.cmbCor.Location = New System.Drawing.Point(266, 92)
        Me.cmbCor.Name = "cmbCor"
        Me.cmbCor.Size = New System.Drawing.Size(251, 21)
        Me.cmbCor.TabIndex = 27
        '
        'txtDataHoje
        '
        Me.txtDataHoje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDataHoje.Location = New System.Drawing.Point(6, 137)
        Me.txtDataHoje.Name = "txtDataHoje"
        Me.txtDataHoje.ReadOnly = True
        Me.txtDataHoje.Size = New System.Drawing.Size(251, 20)
        Me.txtDataHoje.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Quantidade"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtQuantidade.Location = New System.Drawing.Point(6, 92)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(249, 20)
        Me.txtQuantidade.TabIndex = 19
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(3, 6)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(75, 23)
        Me.btnGravar.TabIndex = 17
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'txtCodBarra
        '
        Me.txtCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodBarra.Location = New System.Drawing.Point(6, 52)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(251, 20)
        Me.txtCodBarra.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cód. Barra"
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(246, 6)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 13
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescricao.Location = New System.Drawing.Point(266, 52)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(251, 20)
        Me.txtDescricao.TabIndex = 9
        Me.txtDescricao.Text = "BOJO"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(84, 6)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisar.TabIndex = 5
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(165, 6)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNovo.TabIndex = 4
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Produto"
        '
        'btnMateriaPrima
        '
        Me.btnMateriaPrima.Location = New System.Drawing.Point(269, 134)
        Me.btnMateriaPrima.Name = "btnMateriaPrima"
        Me.btnMateriaPrima.Size = New System.Drawing.Size(248, 23)
        Me.btnMateriaPrima.TabIndex = 29
        Me.btnMateriaPrima.Text = "Matéria Prima"
        Me.btnMateriaPrima.UseVisualStyleBackColor = True
        '
        'FrmPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 296)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGravar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDataHoje As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents cmbCor As ComboBox
    Friend WithEvents txtCodBarra As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents DG As DataGridView
    Friend WithEvents btnMateriaPrima As Button
End Class
