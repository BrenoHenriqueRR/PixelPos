USE pixelpos;
GO

-- --------------------------------------------------------

--
-- Estrutura para tabela `fotos`
--

IF OBJECT_ID('fotos', 'U') IS NOT NULL
  DROP TABLE fotos;
GO

CREATE TABLE fotos (
  id INT NOT NULL IDENTITY(1,1),
  id_album INT NOT NULL,
  caminho_foto VARCHAR(250) DEFAULT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (id_album) REFERENCES imagens(id)
);

-- --------------------------------------------------------

--
-- Estrutura para tabela `imagens`
--

IF OBJECT_ID('imagens', 'U') IS NOT NULL
  DROP TABLE imagens;
GO

CREATE TABLE imagens (
  id INT NOT NULL IDENTITY(1,1),
  nome_album VARCHAR(25) DEFAULT NULL,
  nome_cli VARCHAR(70) DEFAULT NULL,
  email_cli VARCHAR(40) DEFAULT NULL,
  album_criacao DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (id)
);

-- --------------------------------------------------------

--
-- Estrutura para tabela `tb_cadastro`
--

IF OBJECT_ID('tb_cadastro', 'U') IS NOT NULL
  DROP TABLE tb_cadastro;
GO

CREATE TABLE tb_cadastro (
  id INT NOT NULL IDENTITY(1,1),
  NOME VARCHAR(50) DEFAULT NULL,
  Data_de_nascimento DATE DEFAULT NULL,
  email VARCHAR(100) DEFAULT NULL,
  senha VARCHAR(255) DEFAULT NULL,
  CPF VARCHAR(15) DEFAULT NULL,
  Gender VARCHAR(15) DEFAULT NULL,
  PRIMARY KEY (id)
);
GO