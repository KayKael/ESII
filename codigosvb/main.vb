Module MainModule

    Sub Main()
        ' Exemplo de leitura de dados de uma tabela (substitua isso com sua lógica real)
        Dim dadosDaTabela As DataTable = LerDadosDaTabela()

        ' Lista para armazenar instâncias de ValoresPropostos
        Dim listaValoresPropostos As New List(Of ValoresPropostos)()

        ' Loop sobre as linhas da tabela
        For Each linha As DataRow In dadosDaTabela.Rows
            ' Criar instância da classe Contrato com base nos dados da linha
            Dim meuContrato As New Contrato(Convert.ToInt32(linha("ID_contrato")), Convert.ToDouble(linha("valor_do_contrato")), Convert.ToSingle(linha("inflacao")), linha("tipo_contrato").ToString(), Convert.ToDouble(linha("orcamento")), Convert.ToInt32(linha("ano")))

            ' Criar instância da classe ValoresDistribuidos com base nos dados da linha
            Dim meusValoresDistribuidos As New ValoresDistribuidos(Convert.ToInt32(linha("id_distribuicao")), Convert.ToInt32(linha("servico")), Convert.ToDouble(linha("valor_inicial")), Convert.ToDouble(linha("execucao_material")), Convert.ToSingle(linha("porcentagem_exec")))

            ' Criar instância da classe ValoresPropostos com base nos dados da linha
            Dim meusValoresPropostos As New ValoresPropostos(Convert.ToInt32(linha("id_proposto")), Convert.ToInt32(linha("servico")), Convert.ToDouble(linha("valor_proposto")), Convert.ToDouble(linha("valor_contrato")), Convert.ToSingle(linha("percentagem_proposta")), Convert.ToSingle(linha("percentagem_exec")), Convert.ToDouble(linha("execucao_material")))

            ' Atribuir instâncias de Contrato e ValoresDistribuidos a ValoresPropostos
            meusValoresPropostos.ValoresDistribuidos = meusValoresDistribuidos
            meusValoresPropostos.antigoContrato = meuContrato
            meusValoresPropostos.novoContrato = meuContrato

            ' Adicionar a instância à lista
            listaValoresPropostos.Add(meusValoresPropostos)
        Next

        ' Exemplo de uso da lista (você pode fazer o que for necessário com os ValoresPropostos)
        For Each valoresPropostos As ValoresPropostos In listaValoresPropostosSim 
            Console.WriteLine("ID dos Valores Propostos: " & valoresPropostos.GetIdProposto())
            Console.WriteLine("Valor Proposto: " & valoresPropostos.GetValorProposto())
            Console.WriteLine("Percentagem Exec: " & valoresPropostos.calcular_eficiencia_distribuicao())
            Console.WriteLine("Valor Proposto Calculado: " & valoresPropostos.calcular_valor_proposto())
            Console.WriteLine()
        Next

        Console.ReadLine()
    End Sub

    ' Função de exemplo para simular leitura de dados da tabela (substitua com sua lógica real)
    Function LerDadosDaTabela() As DataTable
        ' Crie uma DataTable de exemplo
        Dim tabela As New DataTable()

        ' Adicione as colunas necessárias à tabela (substitua com suas colunas reais)
        tabela.Columns.Add("ID_contrato", GetType(Integer))
        tabela.Columns.Add("valor_do_contrato", GetType(Double))
        tabela.Columns.Add("inflacao", GetType(Single))
        tabela.Columns.Add("tipo_contrato", GetType(String))
        tabela.Columns.Add("orcamento", GetType(Double))
        tabela.Columns.Add("ano", GetType(Integer))
        tabela.Columns.Add("id_distribuicao", GetType(Integer))
        tabela.Columns.Add("servico", GetType(Integer))
        tabela.Columns.Add("valor_inicial", GetType(Double))
        tabela.Columns.Add("execucao_material", GetType(Double))
        tabela.Columns.Add("porcentagem_exec", GetType(Single))
        tabela.Columns.Add("id_proposto", GetType(Integer))
        tabela.Columns.Add("valor_proposto", GetType(Double))
        tabela.Columns.Add("valor_contrato", GetType(Double))
        tabela.Columns.Add("percentagem_proposta", GetType(Single))
        tabela.Columns.Add("percentagem_exec", GetType(Single))
        tabela.Columns.Add("execucao_material", GetType(Double))

        ' Adicione algumas linhas de dados de exemplo à tabela
        tabela.Rows.Add(1, 10000.0, 0.05, "Contrato A", 150000.0, 2022, 1, 123, 5000.0, 2000.0, 0.1, 1, 5000.0, 10000.0, 0.5, 10.0, 2000.0)
        tabela.Rows.Add(2, 12000.0, 0.08, "Contrato B", 180000.0, 2023, 2, 456, 6000.0, 2500.0, 0.15, 2, 6000.0, 12000.0, 0.6, 12.0, 2500.0)

        Return tabela
    End Function

End Module