Imports System

Public Class ValoresDistribuidos

    Public id_distribuicao As Integer
    Public servico As Integer
    Public valor_inicial As Double
    Public execucao_material As Double
    Public porcentagem_exec As Single

    Public Sub New(ByVal idDistribuicao As Integer, ByVal servico As Integer, ByVal valorInicial As Double, ByVal execucaoMaterial As Double, ByVal porcentagemExec As Single)
        Me.id_distribuicao = idDistribuicao
        Me.servico = servico
        Me.valor_inicial = valorInicial
        Me.execucao_material = execucaoMaterial
        Me.porcentagem_exec = porcentagemExec
    End Sub

    Public Sub New()
    End Sub

    Public Property IdDistribuicao As Integer
        Get
            Return id_distribuicao
        End Get
        Set(value As Integer)
            id_distribuicao = value
        End Set
    End Property

    Public Property ServicoPropiedade As Integer
        Get
            Return servico
        End Get
        Set(value As Integer)
            servico = value
        End Set
    End Property

    Public Property ValorInicial As Double
        Get
            Return valor_inicial
        End Get
        Set(value As Double)
            valor_inicial = value
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

    Public Property PorcentagemExec As Single
        Get
            Return porcentagem_exec
        End Get
        Set(value As Single)
            porcentagem_exec = value
        End Set
    End Property

End Class
