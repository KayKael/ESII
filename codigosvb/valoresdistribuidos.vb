Imports System

Public Class ValoresDistribuidos

    Public Sub New()
    End Sub

    Public id_distribuicao As Integer
    Public servico As Integer
    Public valor_inicial As Double
    Public execucao_material As Double
    Public porcentagem_exec As Single

    Public Property GetIdDistribuicao() As Integer
        Return id_distribuicao
    End Property

    Public Property SetIdDistribuicao(ByVal value As Integer)
        id_distribuicao = value
    End Property

    Public Property GetServico() As Integer
        Return servico
    End Property

    Public Property SetServico(ByVal value As Integer)
        servico = value
    End Property

    Public Property GetValorInicial() As Double
        Return valor_inicial
    End Property

    Public Property SetValorInicial(ByVal value As Double)
        valor_inicial = value
    End Property

    Public Property GetExecucaoMaterial() As Double
        Return execucao_material
    End Property

    Public Property SetExecucaoMaterial(ByVal value As Double)
        execucao_material = value
    End Property

    Public Property GetPorcentagemExec() As Single
        Return porcentagem_exec
    End Property

    Public Property SetPorcentagemExec(ByVal value As Single)
        porcentagem_exec = value
    End Property

End Class
