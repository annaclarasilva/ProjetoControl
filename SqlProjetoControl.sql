CREATE DATABASE bdProjetoControl
GO
USE bdProjetoControl
GO
CREATE TABLE Empresa(
	nomeFantasia	VARCHAR (100) NOT NULL,
	telefone		VARCHAR (13) NOT NULL,
	razaoSocial		VARCHAR (20) NOT NULL,
	cnpj			VARCHAR (100) PRIMARY KEY  NOT NULL,
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
	codSemestre		VARCHAR (20) PRIMARY KEY NOT NULL,
	numAlunos		INT NOT  NULL,
);

CREATE TABLE Aluno(
	raAluno			VARCHAR (100)  PRIMARY KEY ,
	nomeAluno		VARCHAR (100) ,
	dataNas			VARCHAR (100) ,
	idade			VARCHAR (100) ,
	sexo			VARCHAR (100) ,
	grau_instrucao	VARCHAR (100) ,
	rua				VARCHAR (100) ,
	numero			VARCHAR (100) ,
	complemento		VARCHAR (100) ,
	bairro			VARCHAR (100) ,
	estado			VARCHAR (100) ,
	cidade			VARCHAR (100) ,
	cep				VARCHAR (100) ,
	telefone1		VARCHAR (100) ,
	identidade		VARCHAR (13) ,
	cpf				VARCHAR(12) ,
	email			VARCHAR (100) ,
	carteira_de_trabalho VARCHAR (100) ,
	nomePai			VARCHAR (100) ,
	telefonePai		VARCHAR (100) ,
	nomeMae			VARCHAR (100) ,
	telefoneMae		VARCHAR (100) ,
	nomeCurso		VARCHAR (30) ,
	codTurma		VARCHAR (100) ,
	statusAluno		VARCHAR (100) ,
	telefoneAluno2	VARCHAR (100) ,
	Empresa_cnpj	VARCHAR (100) ,
	FOREIGN KEY (Empresa_cnpj) REFERENCES Empresa (cnpj),
	Semestre_codSemestre VARCHAR (20) ,
	FOREIGN KEY (Semestre_codSemestre) REFERENCES Semestre (codSemestre),
);

CREATE TABLE Funcionario (
	usuario VARCHAR (15),
	tipoFunc INT,
	senha VARCHAR (8),
	cpf VARCHAR (13) PRIMARY KEY NOT NULL,
);

CREATE TABLE Usuario (
	usuario VARCHAR (15),
	tipoFunc INT,
	senha VARCHAR (8),
	cpf VARCHAR (13) PRIMARY KEY NOT NULL,
);

select * from Aluno


INSERT INTO Usuario VALUES ('michel',1,'michel12','250111760-37'),
('rafael',2,'rafa123','858919320-91')
SELECT * FROM Usuario

--GO
--CREATE VIEW vwAlunosEmpregados AS
--SELECT A.nomeAluno, A.raAluno, A.cpf,A.codTurma,E.cnpj,E.nomeFantasia
--FROM Aluno AS A INNER JOIN Empresa AS E ON (A.Empresa_cnpj = E.cnpj) 
--SELECT * FROM vwAlunosEmpregados
--GO



--use master 
--drop database bdProjetoControl 