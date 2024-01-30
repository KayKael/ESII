Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Diagnostics.Contracts

Public Class main
    Inherits System.Windows.Forms.Form
    Private novoContrato As Contrato
    Private novosValores As ValoresPropostos
    Private connectionString As String = "Server=localhost;Database=eficiencia;User Id=root;Password=;"

    Private myConn As MySqlConnection
    Private myCmd As MySqlCommand
    Private myReader As MySqlDataReader
    Private results As String


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles txtvalorrecomendado.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtinflacao.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles valorespropostos.CellContentClick

    End Sub

    Private Sub cbocontratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocontratos.SelectedIndexChanged
        Try
            ' Obter o ano selecionado
            Dim anoSelecionado As Integer = CInt(cbocontratos.SelectedItem)

            ' Chamar o método para obter detalhes do contrato pelo ano
            Dim contratoSelecionado As Contrato = ObterContratoPorAno(anoSelecionado)

            ' Verificar se o contrato foi encontrado
            If contratoSelecionado IsNot Nothing Then
                ' Exibir os detalhes do contrato (ou realizar outras ações necessárias)
                MessageBox.Show($"Detalhes do Contrato para o Ano {anoSelecionado}:" & vbCrLf &
                            $"ID Contrato: {contratoSelecionado.IDContrato}" & vbCrLf &
                            $"Valor do Contrato: {contratoSelecionado.ValorDoContrato}" & vbCrLf &
                            $"Inflação do Contrato: {contratoSelecionado.InflacaoContrato}" & vbCrLf &
                            $"Tipo de Contrato: {contratoSelecionado.TipoContrato}" & vbCrLf &
                            $"Orçamento do Contrato: {contratoSelecionado.OrcamentoContrato}" & vbCrLf &
                            $"Ano do Contrato: {contratoSelecionado.AnoContrato}")
            Else
                MessageBox.Show("Contrato não encontrado para o ano selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao obter detalhes do contrato: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btncalcularrecomendado_Click(sender As Object, e As EventArgs) Handles btncalcularrecomendado.Click
        Try
            ' Lógica do seu código anterior
            Dim anoSelecionado As Integer = CInt(cbocontratos.SelectedValue)
            Dim inflacao As Single = Single.Parse(txtinflacao.Text)

            Dim contratoSelecionado As Contrato = ObterContratoPorAno(anoSelecionado)

            If contratoSelecionado IsNot Nothing Then
                novoContrato = contratoSelecionado ' Atribui diretamente o objeto Contrato retornado
                Dim valorRecomendado As Double = novoContrato.calcular_valor_contrato(inflacao)

                ' Atualiza o valor do contrato no objeto Contrato
                novoContrato.ValorDoContrato = valorRecomendado

                ' Adiciona o novo contrato à tabela "Contratos" no banco de dados
                AdicionarContratoAoBanco(novoContrato)

                ' Exibe o valor recomendado no TextBox
                txtvalorrecomendado.Text = valorRecomendado.ToString("C")
            Else
                MessageBox.Show("Contrato não encontrado para o ano selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao calcular valor recomendado: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_calcular_valores_distribuição.Click

    End Sub

    Private Sub contratos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtabelaresultado.CellContentClick

    End Sub

    Private Sub btncalculartabela_Click(sender As Object, e As EventArgs) Handles btncalculartabela.Click
        Try
            ' Obter o ID do contrato selecionado
            Dim idContrato As Integer = DirectCast(cbocontratos.SelectedItem, KeyValuePair(Of Integer, String)).Key

            ' Consulta SQL para obter os valores distribuídos para o contrato selecionado
            Dim query As String = $"SELECT * FROM ValoresDistribuidos WHERE id_contrato = {idContrato}"

            ' Conectar ao banco de dados MySQL
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Executar a consulta SQL
                Using command As New MySqlCommand(query, connection)
                    ' Criar um adaptador para preencher um DataTable
                    Using adapter As New MySqlDataAdapter(command)
                        Dim tabelaResultado As New DataTable()

                        ' Preencher o DataTable com os dados do banco de dados
                        adapter.Fill(tabelaResultado)

                        ' Exibir a tabela no DataGridView
                        dgvtabelaresultado.DataSource = tabelaResultado
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao calcular tabela: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ObterContratoPorAno(ano As Integer) As Contrato
        Dim contratoSelecionado As New Contrato()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = $"SELECT * FROM Contratos WHERE ano_contrato = {ano}"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            contratoSelecionado.IDContrato = CInt(reader("ID_contrato"))
                            contratoSelecionado.ValorDoContrato = CDbl(reader("valor_do_contrato"))
                            contratoSelecionado.InflacaoContrato = CSng(reader("inflacao_contrato"))
                            contratoSelecionado.TipoContrato = CStr(reader("tipo_contrato"))
                            contratoSelecionado.OrcamentoContrato = CDbl(reader("orcamento_contrato"))
                            contratoSelecionado.AnoContrato = CInt(reader("ano_contrato"))
                        Else
                            contratoSelecionado = Nothing
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao obter detalhes do contrato: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            contratoSelecionado = Nothing
        End Try

        Return contratoSelecionado
    End Function
    Private Sub AdicionarContratoAoBanco(contrato As Contrato)
        ' Adiciona o novo contrato à tabela "Contratos" no banco de dados
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = $"INSERT INTO Contratos (valor_do_contrato, inflacao_contrato, tipo_contrato, orcamento_contrato, ano_contrato) VALUES " &
                             $"({contrato.ValorDoContrato}, {contrato.InflacaoContrato}, '{contrato.TipoContrato}', {contrato.OrcamentoContrato}, {contrato.AnoContrato})"

            Using command As New MySqlCommand(query, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub CarregarContratos()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT ano_contrato FROM Contratos"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            cbocontratos.Items.Add(reader.GetInt32("ano_contrato"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar contratos: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
