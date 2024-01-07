Imports System

Public Class ValoresPropostos
public ValoresDistribuidos as ValoresDistribuidos
public Contrato as Contrato

    Public Sub New()
    End Sub

    Public id_proposto As Integer
    Public servico As Integer
    Public valor_proposto As Double
    Public percentagem_proposta As Single
    Public percentagem_exec As Single
    Public execucao_material As Double

    Public Function calcular_eficiencia_distribuicao() As Double
        ValoresDistribuidos.GetPercentagemExec() = percentagem_exec
        ValoresDistribuidos.GetExecucaoMaterial() = execucao_material
    


        Return 0.0
    End Function

    Public Function calcular_valor_proposto() As Double
        Contrato.GetInflacao()*Contrato.GetOrcamento()= valor_proposto
        If (valor_proposto < Contrato.GetOrcamento())  Then
            Console.WriteLine("Valor Proposto menor que o valor do contrato anterior!"\n)
            Console.WriteLine("Deseja continuar?"\n)
        End If
        

        Return 0.0
    End Function

    Public Property GetIdProposto() As Integer
        Return id_proposto
    End Property

    Public Property SetIdProposto(ByVal value As Integer)
        id_proposto = value
    End Property

    Public Property GetServico() As Integer
        Return servico
    End Property

    Public Property SetServico(ByVal value As Integer)
        servico = value
    End Property

    Public Property GetValorProposto() As Double
        Return valor_proposto
    End Property

    Public Property SetValorProposto(ByVal value As Double)
        valor_proposto = value
    End Property

    Public Property GetPercentagemProposta() As Single
        Return percentagem_proposta
    End Property

    Public Property SetPercentagemProposta(ByVal value As Single)
        percentagem_proposta = value
    End Property

    Public Property GetPercentagemExec() As Single
        Return percentagem_exec
    End Property

    Public Property SetPercentagemExec(ByVal value As Single)
        percentagem_exec = value
    End Property

    Public Property GetExecucaoMaterial() As Double
        Return execucao_material
    End Property

    Public Property SetExecucaoMaterial(ByVal value As Double)
        execucao_material = value
    End Property

End Class
