
Public Class Contrato

    Public ID_contrato As Integer
    Public valor_contrato As Double
    Public inflacao As Single
    Public tipo_contrato As String
    Public orcamento As Double
    Public ano As Integer

    Public Sub New()
    End Sub

    Public Sub New(ByVal idContrato As Integer, ByVal valorContrato As Double, ByVal inflacao As Single, ByVal tipoContrato As String, ByVal orcamento As Double, ByVal ano As Integer)
        Me.ID_contrato = idContrato
        Me.valor_contrato = valorContrato
        Me.inflacao = inflacao
        Me.tipo_contrato = tipoContrato
        Me.orcamento = orcamento
        Me.ano = ano
    End Sub

    Public Function calcular_valor_contrato(Float) As Double
        Return valor_contrato * (1 + inflacao)
    End Function

    Public Function calcular_orcamento_previsto(Float) As Double

        Return orcamento * (1 + inflacao)
    End Function

    Public Function CalcularTabela(idContrato As Integer, inflacao As Single, valorRecomendado As Double) As DataTable
        Dim novaTabela As New DataTable()
        novaTabela.Columns.Add("ID_contrato", GetType(Integer))
        novaTabela.Columns.Add("tipo_contrato", GetType(String))
        novaTabela.Columns.Add("valor_recomendado", GetType(Double))

        ' Adicione as linhas da tabela com os dados calculados
        novaTabela.Rows.Add(idContrato, "Contrato Recomendado", valorRecomendado * (1 + inflacao))

        Return novaTabela
    End Function


    Public Property IDContrato() As Integer
        Get
            Return ID_contrato
        End Get
        Set(ByVal value As Integer)
            ID_contrato = value
        End Set
    End Property

    Public Property ValorDoContrato() As Double
        Get
            Return valor_contrato
        End Get
        Set(ByVal value As Double)
            valor_contrato = value
        End Set
    End Property

    Public Property InflacaoContrato() As Single
        Get
            Return inflacao
        End Get
        Set(ByVal value As Single)
            inflacao = value
        End Set
    End Property

    Public Property TipoContrato() As String
        Get
            Return tipo_contrato
        End Get
        Set(ByVal value As String)
            tipo_contrato = value
        End Set
    End Property

    Public Property OrcamentoContrato() As Double
        Get
            Return orcamento
        End Get
        Set(ByVal value As Double)
            orcamento = value
        End Set
    End Property

    Public Property AnoContrato() As Integer
        Get
            Return ano
        End Get
        Set(ByVal value As Integer)
            ano = value
        End Set
    End Property
End Class
