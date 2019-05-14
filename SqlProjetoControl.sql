CREATE DATABASE bdProjetoControl
GO
USE bdProjetoControl
GO

CREATE TABLE Empresa(
	nomeFantasia	VARCHAR (100) NOT NULL,
	telefone		VARCHAR (13) NOT NULL,
	razaoSocial		VARCHAR (20) NOT NULL,
	cnpj			VARCHAR (20) PRIMARY KEY  NOT NULL,
	email			VARCHAR (100) NOT NULL,
	responsavel		VARCHAR (100) NOT NULL,
	rua				VARCHAR (100) NOT NULL,
	numero			INT NOT NULL,
	complemento		VARCHAR (50) NOT NULL,
	bairro			VARCHAR (50) NOT NULL,
	estado			CHAR (2) NOT NULL,
	cidade			CHAR (50) NOT NULL,
	cep				CHAR (9) NOT NULL
);
INSERT INTO Empresa VALUES ('Empresa','3195958648','Empresa','28747588000160','empresa@gmail.com','Dono da Empresa','Rua Dom Manuel O Venturoso',129,'aaa','Vila Paranaguá','SP','São Paulo','03806100')

CREATE TABLE Semestre (
	dataInicio		DATE NOT NULL,
	dataFim			DATE NOT NULL,
	codSemestre		INT PRIMARY KEY NOT NULL,
	numAlunos		INT NOT  NULL,
);
CREATE TABLE Aluno(
	raAluno			INT PRIMARY KEY NOT NULL,
	nomeAluno		VARCHAR (100) NOT NULL,
	dataNas			DATE NOT NULL,
	idade			INT NOT NULL,
	sexo			CHAR (1) NOT NULL,
	grau_instrucao	VARCHAR (50) NOT NULL,
	rua				VARCHAR (100) NOT NULL,
	numero			INT NOT NULL,
	complemento		VARCHAR (50) NOT NULL,
	bairro			VARCHAR (50) NOT NULL,
	estado			CHAR (2) NOT NULL,
	cidade			CHAR (50) NOT NULL,
	cep				CHAR (9) NOT NULL,
	telefone1		VARCHAR(13) NOT NULL,
	identidade		VARCHAR (13) NOT NULL,
	cpf				CHAR (12) NOT NULL,
	email			VARCHAR (100) NOT NULL,
	carteira_de_trabalho VARCHAR (15) NOT NULL,
	nomePai			VARCHAR (100) NOT NULL,
	telefonePai		VARCHAR(13) NOT NULL,
	nomeMae			VARCHAR (100) NOT NULL,
	telefoneMae		VARCHAR(13) NOT NULL,
	nomeCurso		VARCHAR (30) NOT NULL,
	codTurma		VARCHAR (15) NOT NULL,
	statusAluno		VARCHAR (20) NOT NULL,
	telefoneAluno2	VARCHAR (13) NOT NULL,
	Empresa_cnpj	VARCHAR (20) NOT NULL,
	FOREIGN KEY (Empresa_cnpj) REFERENCES Empresa (cnpj),
	Semestre_codSemestre INT NOT NULL,
	FOREIGN KEY (Semestre_codSemestre) REFERENCES Semestre (codSemestre),
);

CREATE TABLE Usuario (
	usuario VARCHAR (15),
	tipoFunc INT,
	senha VARCHAR (8),
	cpf VARCHAR (13) PRIMARY KEY NOT NULL,
);

INSERT INTO Usuario VALUES ('michel',1,'michel12','250111760-37'),
								('rafael',2,'rafa123','858919320-91')

SELECT * FROM Usuario

SELECT * FROM Empresa WHERE cnpj LIKE 28747588000160
SELECT A.nomeAluno, A.raAluno, A.cpf,A.codTurma,E.cnpj,E.nomeFantasia FROM Aluno AS A INNER JOIN Empresa AS E ON (A.Empresa_cnpj = E.cnpj) 


--use master
--drop database bdProjetoControl