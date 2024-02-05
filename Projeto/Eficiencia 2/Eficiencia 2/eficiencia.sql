-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 30/01/2024 às 01:30
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `eficiencia`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `contratos`
--

CREATE TABLE `contratos` (
  `ID_contrato` int(11) NOT NULL,
  `tipo_contrato` varchar(255) DEFAULT NULL,
  `valor_do_contrato` decimal(18,2) DEFAULT NULL,
  `inflacao_contrato` float DEFAULT NULL,
  `orcamento_contrato` decimal(18,2) DEFAULT NULL,
  `ano_contrato` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `contratos`
--

INSERT INTO `contratos` (`ID_contrato`, `tipo_contrato`, `valor_do_contrato`, `inflacao_contrato`, `orcamento_contrato`, `ano_contrato`) VALUES
(1, 'Papel', 2000000.00, 0, 0.00, 2022),
(2, 'Papel', 2200000.00, 0.079, 2158000.00, 2023);

-- --------------------------------------------------------

--
-- Estrutura para tabela `valoresdistribuidos`
--

CREATE TABLE `valoresdistribuidos` (
  `id_distribuicao` int(11) NOT NULL,
  `servico` int(11) DEFAULT NULL,
  `valor_inicial` decimal(18,2) DEFAULT NULL,
  `execucao_material` decimal(18,2) DEFAULT NULL,
  `porcentagem_exec` float DEFAULT NULL,
  `id_contrato` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `valoresdistribuidos`
--

INSERT INTO `valoresdistribuidos` (`id_distribuicao`, `servico`, `valor_inicial`, `execucao_material`, `porcentagem_exec`, `id_contrato`) VALUES
(1, 1, 6500.00, 3700.00, 3.7, 2),
(2, 2, 6500.00, 3700.00, 3.7, 2),
(3, 3, 6500.00, 3700.00, 3.7, 2),
(4, 4, 6500.00, 3700.00, 3.7, 2),
(5, 5, 6500.00, 3700.00, 3.7, 2),
(6, 6, 6500.00, 3700.00, 3.7, 2),
(7, 7, 6500.00, 3700.00, 3.7, 2),
(8, 8, 6500.00, 3700.00, 3.7, 2),
(9, 9, 6500.00, 3700.00, 3.7, 2),
(10, 10, 6500.00, 3700.00, 3.7, 2),
(11, 11, 6500.00, 3700.00, 3.7, 2),
(12, 12, 6500.00, 3700.00, 3.7, 2),
(13, 13, 6500.00, 3700.00, 3.7, 2),
(14, 14, 6500.00, 3700.00, 3.7, 2),
(15, 15, 6500.00, 3700.00, 3.7, 2),
(16, 16, 6500.00, 3700.00, 3.7, 2),
(17, 17, 6500.00, 3700.00, 3.7, 2),
(18, 18, 6500.00, 3700.00, 3.7, 2),
(19, 19, 6500.00, 3700.00, 3.7, 2),
(20, 20, 6500.00, 3700.00, 3.7, 2),
(21, 21, 6500.00, 3700.00, 3.7, 2),
(22, 22, 6500.00, 3700.00, 3.7, 2),
(23, 23, 6500.00, 3700.00, 3.7, 2),
(24, 24, 6500.00, 3700.00, 3.7, 2),
(25, 25, 6500.00, 3700.00, 3.7, 2),
(26, 26, 6500.00, 3700.00, 3.7, 2);
-- --------------------------------------------------------

--
-- Estrutura para tabela `valorespropostos`
--

CREATE TABLE `valorespropostos` (
  `id_proposto` int(11) NOT NULL,
  `servico` int(11) DEFAULT NULL,
  `valor_proposto` decimal(18,2) DEFAULT NULL,
  `valor_contrato` decimal(18,2) DEFAULT NULL,
  `percentagem_proposta` float DEFAULT NULL,
  `percentagem_exec` float DEFAULT NULL,
  `execucao_material` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `contratos`
--
ALTER TABLE `contratos`
  ADD PRIMARY KEY (`ID_contrato`);

--
-- Índices de tabela `valoresdistribuidos`
--
ALTER TABLE `valoresdistribuidos`
  ADD PRIMARY KEY (`id_distribuicao`),
  ADD KEY `id_contrato` (`id_contrato`);

--
-- Índices de tabela `valorespropostos`
--
ALTER TABLE `valorespropostos`
  ADD PRIMARY KEY (`id_proposto`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `valoresdistribuidos`
--
ALTER TABLE `valoresdistribuidos`
  MODIFY `id_distribuicao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `valoresdistribuidos`
--
ALTER TABLE `valoresdistribuidos`
  ADD CONSTRAINT `valoresdistribuidos_ibfk_1` FOREIGN KEY (`id_contrato`) REFERENCES `contratos` (`ID_contrato`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
