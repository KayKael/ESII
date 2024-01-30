<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbocontratos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtinflacao = New System.Windows.Forms.TextBox()
        Me.txtvalorrecomendado = New System.Windows.Forms.Label()
        Me.valorespropostos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_calcular_valores_distribuição = New System.Windows.Forms.Button()
        Me.btncalcularrecomendado = New System.Windows.Forms.Button()
        Me.dgvtabelaresultado = New System.Windows.Forms.DataGridView()
        Me.btncalculartabela = New System.Windows.Forms.Button()
        CType(Me.valorespropostos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvtabelaresultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escolha o contrato anterior"
        '
        'cbocontratos
        '
        Me.cbocontratos.FormattingEnabled = True
        Me.cbocontratos.Location = New System.Drawing.Point(55, 44)
        Me.cbocontratos.Name = "cbocontratos"
        Me.cbocontratos.Size = New System.Drawing.Size(202, 21)
        Me.cbocontratos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Indique a inflação (Exemplo formato: 7.9 )"
        '
        'txtinflacao
        '
        Me.txtinflacao.Location = New System.Drawing.Point(55, 89)
        Me.txtinflacao.Name = "txtinflacao"
        Me.txtinflacao.Size = New System.Drawing.Size(199, 20)
        Me.txtinflacao.TabIndex = 3
        '
        'txtvalorrecomendado
        '
        Me.txtvalorrecomendado.AutoSize = True
        Me.txtvalorrecomendado.Location = New System.Drawing.Point(52, 112)
        Me.txtvalorrecomendado.Name = "txtvalorrecomendado"
        Me.txtvalorrecomendado.Size = New System.Drawing.Size(133, 13)
        Me.txtvalorrecomendado.TabIndex = 4
        Me.txtvalorrecomendado.Text = "Valor do próximo contrato: "
        '
        'valorespropostos
        '
        Me.valorespropostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.valorespropostos.Location = New System.Drawing.Point(55, 479)
        Me.valorespropostos.Name = "valorespropostos"
        Me.valorespropostos.Size = New System.Drawing.Size(639, 254)
        Me.valorespropostos.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Valores de distribuição propostos"
        '
        'btn_calcular_valores_distribuição
        '
        Me.btn_calcular_valores_distribuição.Location = New System.Drawing.Point(508, 450)
        Me.btn_calcular_valores_distribuição.Name = "btn_calcular_valores_distribuição"
        Me.btn_calcular_valores_distribuição.Size = New System.Drawing.Size(186, 23)
        Me.btn_calcular_valores_distribuição.TabIndex = 7
        Me.btn_calcular_valores_distribuição.Text = "Calcular Valores de Distribuição"
        Me.btn_calcular_valores_distribuição.UseVisualStyleBackColor = True
        '
        'btncalcularrecomendado
        '
        Me.btncalcularrecomendado.Location = New System.Drawing.Point(508, 85)
        Me.btncalcularrecomendado.Name = "btncalcularrecomendado"
        Me.btncalcularrecomendado.Size = New System.Drawing.Size(186, 23)
        Me.btncalcularrecomendado.TabIndex = 8
        Me.btncalcularrecomendado.Text = "Calcular valor do novo contrato"
        Me.btncalcularrecomendado.UseVisualStyleBackColor = True
        '
        'dgvtabelaresultado
        '
        Me.dgvtabelaresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtabelaresultado.Location = New System.Drawing.Point(55, 210)
        Me.dgvtabelaresultado.Name = "dgvtabelaresultado"
        Me.dgvtabelaresultado.Size = New System.Drawing.Size(639, 234)
        Me.dgvtabelaresultado.TabIndex = 9
        '
        'btncalculartabela
        '
        Me.btncalculartabela.Location = New System.Drawing.Point(508, 181)
        Me.btncalculartabela.Name = "btncalculartabela"
        Me.btncalculartabela.Size = New System.Drawing.Size(186, 23)
        Me.btncalculartabela.TabIndex = 10
        Me.btncalculartabela.Text = "Mostrar Contratos existentes"
        Me.btncalculartabela.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 797)
        Me.Controls.Add(Me.btncalculartabela)
        Me.Controls.Add(Me.dgvtabelaresultado)
        Me.Controls.Add(Me.btncalcularrecomendado)
        Me.Controls.Add(Me.btn_calcular_valores_distribuição)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.valorespropostos)
        Me.Controls.Add(Me.txtvalorrecomendado)
        Me.Controls.Add(Me.txtinflacao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbocontratos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "main"
        Me.Text = "Calcular Eficiência de gastos dos serviços"
        CType(Me.valorespropostos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvtabelaresultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
        CarregarContratos()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbocontratos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtinflacao As TextBox
    Friend WithEvents txtvalorrecomendado As Label
    Friend WithEvents valorespropostos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_calcular_valores_distribuição As Button
    Friend WithEvents btncalcularrecomendado As Button
    Friend WithEvents dgvtabelaresultado As DataGridView
    Friend WithEvents btncalculartabela As Button
End Class
