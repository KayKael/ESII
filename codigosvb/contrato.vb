Imports System

Public Class Contrato

    Public Sub New()
    End Sub

    Public ID_contrato As Integer
    Public valor_do_contrato As Double
    Public inflacao As Single
    Public tipo_contrato As String
    Public orcamento As Double
    Public ano As Integer

    Public Function calcular_valor_contrato() As Double
        ' TODO implementar aqui
        Return 0.0
    End Function

    Public Function calcular_orcamento_previsto() As Double
        ' TODO implementar aqui
        Return 0.0
    End Function

    Public Property GetIDContrato() As Integer
        Return ID_contrato
    End Property

       Public Property GetIDContrato() As Integer
        Return ID_contrato
    End Property

    Public Property SetIDContrato(ByVal value As Integer)
        ID_contrato = value
    End Property

    Public Property GetValorDoContrato() As Double
        Return valor_do_contrato
    End Property

    Public Property SetValorDoContrato(ByVal value As Double)
        valor_do_contrato = value
    End Property

    Public Property GetInflacao() As Single
        Return inflacao
    End Property

    Public Property SetInflacao(ByVal value As Single)
        inflacao = value
    End Property

    Public Property GetTipoContrato() As String
        Return tipo_contrato
    End Property

    Public Property SetTipoContrato(ByVal value As String)
        tipo_contrato = value
    End Property

    Public Property GetOrcamento() As Double
        Return orcamento
    End Property

    Public Property SetOrcamento(ByVal value As Double)
        orcamento = value
    End Property

    Public Property GetAno() As Integer
        Return ano
    End Property

    Public Property SetAno(ByVal value As Integer)
        ano = value
    End Property

End Class