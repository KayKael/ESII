Imports System

Public Class ValoresPropostos
    Public ValoresDistribuidos As ValoresDistribuidos
    Public AntigoContrato As Contrato
    Public NovoContrato As Contrato

    Public id_proposto As Integer
    Public servico As Integer
    Public valor_proposto As Double
    Public valor_contrato As Double
    Public percentagem_proposta As Single
    Public percentagem_exec As Single
    Public execucao_material As Double

    Public Sub New()
    End Sub

    Public Sub New(ByVal idProposto As Integer, ByVal servico As Integer, ByVal valorProposto As Double, ByVal valorContrato As Double, ByVal percentagemProposta As Single, ByVal percentagemExec As Single, ByVal execucaoMaterial As Double)
        Me.id_proposto = idProposto
        Me.servico = servico
        Me.valor_proposto = valorProposto
        Me.valor_contrato = valorContrato
        Me.percentagem_proposta = percentagemProposta
        Me.percentagem_exec = percentagemExec
        Me.execucao_material = execucaoMaterial
    End Sub

    Public Function CalcularEficienciaDistribuicao() As Double
        ValoresDistribuidos.ExecucaoMaterial = ValoresDistribuidos.ExecucaoMaterial
        AntigoContrato.ValorDoContrato = AntigoContrato.ValorDoContrato
        percentagem_exec = (AntigoContrato.ValorDoContrato * 100) / ValoresDistribuidos.ExecucaoMaterial



        Return percentagem_exec
    End Function

    Public Function CalcularValorProposto() As Double
        NovoContrato.ValorDoContrato = AntigoContrato.ValorDoContrato
        Dim percentagem_proposta As Single = (percentagem_exec / 100)
        Dim valor_proposto As Double = (NovoContrato.ValorDoContrato * percentagem_proposta)

        Return valor_proposto
    End Function
    Public Property IdProposto As Integer
        Get
            Return id_proposto
        End Get
        Set(value As Integer)
            id_proposto = value
        End Set
    End Property

    Public Property ServicoProposta As Integer
        Get
            Return servico
        End Get
        Set(value As Integer)
            servico = value
        End Set
    End Property

    Public Property ValorProposto As Double
        Get
            Return valor_proposto
        End Get
        Set(value As Double)
            valor_proposto = value
        End Set
    End Property

    Public Property PercentagemProposta As Single
        Get
            Return percentagem_proposta
        End Get
        Set(value As Single)
            percentagem_proposta = value
        End Set
    End Property

    Public Property PercentagemExec As Single
        Get
            Return percentagem_exec
        End Get
        Set(value As Single)
            percentagem_exec = value
        End Set
    End Property

    Public Property ExecucaoMaterial As Double
        Get
            Return execucao_material
        End Get
        Set(value As Double)
            execucao_material = value
        End Set
    End Property

End Class
