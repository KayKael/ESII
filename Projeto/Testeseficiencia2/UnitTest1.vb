Imports System.Data
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MySql.Data.MySqlClient

Namespace Testeseficiencia2
    <TestClass>
    Public Class UnitTest1
        <TestMethod>
        Public Sub TesteConexaoBancoDeDados()
            ' Arrange
            Using connection As New MySqlConnection(connectionString)
                ' Act
                Try
                    connection.Open()
                    ' Assert
                    Assert.IsTrue(connection.State = ConnectionState.Open, "A conexão com o banco de dados deve estar aberta.")
                Catch ex As Exception
                    ' Assert
                    Assert.Fail($"Erro ao abrir a conexão: {ex.Message}")
                End Try
            End Using
        End Sub

        <TestMethod>
        Public Sub TesteConsultaValoresPropostosVazia()
            ' Arrange
            LimparTabelaValoresPropostos()

            ' Act
            Dim resultado As Integer = ConsultarTabelaValoresPropostos()

            ' Assert
            Assert.AreEqual(0, resultado, "A tabela valorespropostos deve estar vazia.")
        End Sub

        <TestMethod>
        Public Sub TesteConsultaValoresPropostosCheia()
            ' Arrange
            PreencherTabelaValoresPropostos()

            ' Act
            Dim resultado As Integer = ConsultarTabelaValoresPropostos()

            ' Assert
            Assert.AreNotEqual(0, resultado, "A tabela valorespropostos deve estar preenchida.")
        End Sub

        <TestMethod>
        Public Sub TesteConsultaValoresPropostosParcialmenteVazia()
            ' Arrange
            LimparParteTabelaValoresPropostos()

            ' Act
            Dim resultado As Integer = ConsultarTabelaValoresPropostos()

            ' Assert
            Assert.AreNotEqual(0, resultado, "A tabela valorespropostos não deve estar completamente vazia.")
        End Sub

        <TestMethod>
        Public Sub TesteConsultaValoresPropostosFaltandoServico()
            ' Arrange
            RemoverServicoDaTabelaValoresPropostos()

            ' Act
            Dim resultado As Integer = ConsultarTabelaValoresPropostos()

            ' Assert
            Assert.AreEqual(0, resultado, "A tabela valorespropostos deve estar vazia se faltar algum serviço.")
        End Sub

        <TestMethod>
        Public Sub TesteConsultaValoresPropostosFaltandoExecucaoMaterial()
            ' Arrange
            RemoverExecucaoMaterialDaTabelaValoresPropostos()

            ' Act
            Dim resultado As Integer = ConsultarTabelaValoresPropostos()

            ' Assert
            Assert.AreEqual(0, resultado, "A tabela valorespropostos deve estar vazia se faltar alguma execução de material.")
        End Sub

        <TestMethod>
        Public Sub TesteConsultaContratosFaltandoValorDoContrato()
            ' Arrange
            RemoverValorDoContratoDaTabelaContratos()

            ' Act
            Dim resultado As Integer = ConsultarTabelaContratos()

            ' Assert
            Assert.AreEqual(0, resultado, "A tabela contratos deve estar vazia se faltar valor_do_contrato.")
        End Sub

        Private Const connectionString As String = "Server=localhost;Database=testes;User Id=root;Password=;"
        Private Sub LimparTabelaValoresPropostos()
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM valorespropostos"
                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As MySqlException
                Assert.Fail($"Erro ao limpar tabela valorespropostos: {ex.Message}")
            End Try
        End Sub

        Private Sub PreencherTabelaValoresPropostos()
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO valorespropostos (servico, valor_proposto, percentagem_proposta, percentagem_exec, execucao_material, id_contrato) " &
                                 "VALUES (1, 100, 10, 20, 10000, 1)," &
                                        "(2, 150, 15, 25, 10000, 1)," &
                                        "(3, 200, 20, 30, 10000, 1)"
                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As MySqlException
                Assert.Fail($"Erro ao preencher tabela valorespropostos: {ex.Message}")
            End Try
        End Sub

        Private Sub LimparParteTabelaValoresPropostos()
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM valorespropostos WHERE servico IN (1, 2)"
                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As MySqlException
                Assert.Fail($"Erro ao limpar parte da tabela valorespropostos: {ex.Message}")
            End Try
        End Sub

        Private Sub RemoverServicoDaTabelaValoresPropostos()
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM valorespropostos WHERE servico = 1"
                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As MySqlException
                Assert.Fail($"Erro ao remover serviço da tabela valorespropostos: {ex.Message}")
            End Try
        End Sub

        Private Sub RemoverExecucaoMaterialDaTabelaValoresPropostos()
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM valorespropostos WHERE execucao_material = 1000.00"
                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As MySqlException
                Assert.Fail($"Erro ao remover execução material da tabela valorespropostos: {ex.Message}")
            End Try
        End Sub

        Private Sub RemoverValorDoContratoDaTabelaContratos()
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM contratos WHERE valor_do_contrato = 100"
                    Using command As New MySqlCommand(query, connection)
                        command.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As MySqlException
                Assert.Fail($"Erro ao remover valor do contrato da tabela contratos: {ex.Message}")
            End Try
        End Sub
        Private Function ConsultarTabelaValoresPropostos() As Integer
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM valorespropostos"
                Using command As New MySqlCommand(query, connection)
                    Return CInt(command.ExecuteScalar())
                End Using
            End Using
        End Function

        Private Function ConsultarTabelaContratos() As Integer
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM contratos"
                Using command As New MySqlCommand(query, connection)
                    Return CInt(command.ExecuteScalar())
                End Using
            End Using
        End Function

    End Class
End Namespace
