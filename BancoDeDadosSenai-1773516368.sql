CREATE TABLE [Aluno] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[status] nvarchar(max) NOT NULL,
	[dataCadastro] date NOT NULL,
	[cidade] nvarchar(max) NOT NULL,
	[endereco] nvarchar(max) NOT NULL,
	[nome] nvarchar(150) NOT NULL,
	[cpf] nvarchar(11) NOT NULL,
	[email] nvarchar(30) NOT NULL,
	[telefone] nvarchar(14) NOT NULL,
	[dataNascimento] date NOT NULL,
	[genero] nvarchar(2) NOT NULL,
	PRIMARY KEY ([id])
);

CREATE TABLE [Professor] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nome] nvarchar(max) NOT NULL,
	[genero] nvarchar(max) NOT NULL,
	[formacaoAcademica] nvarchar(max) NOT NULL,
	[cpf] nvarchar(max) NOT NULL,
	[dataNascimento] date NOT NULL,
	[email] nvarchar(30) NOT NULL,
	[telefone] nvarchar(13) NOT NULL,
	[salario] decimal(9) NOT NULL,
	[status] nvarchar(max) NOT NULL,
	PRIMARY KEY ([id])
);

CREATE TABLE [Curso] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nome] nvarchar(max) NOT NULL,
	[descricao] nvarchar(max) NOT NULL,
	[duracao] nvarchar(max) NOT NULL,
	[nivel] nvarchar(max) NOT NULL,
	[preRequisitos] nvarchar(max) NOT NULL,
	[valor] int NOT NULL,
	[status] nvarchar(15) NOT NULL,
	PRIMARY KEY ([id])
);

CREATE TABLE [Turma] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[nomeTurma] nvarchar(20) NOT NULL,
	[idPeriodo] int NOT NULL,
	[idProfessor] int NOT NULL,
	[idCurso] int NOT NULL,
	PRIMARY KEY ([id])
);

CREATE TABLE [periodo_1773510615] (
	[manha] int NOT NULL
);

CREATE TABLE [Matricula] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[dataMatricula] date NOT NULL,
	[idAluno] int NOT NULL,
	[idTurma] int NOT NULL,
	PRIMARY KEY ([id])
);

CREATE TABLE [Periodo] (
	[id] int IDENTITY(1,1) NOT NULL UNIQUE,
	[periodo] nvarchar(max) NOT NULL,
	[inicio] date NOT NULL,
	[termino] date NOT NULL,
	PRIMARY KEY ([id])
);




ALTER TABLE [Turma] ADD CONSTRAINT [Turma_fk2] FOREIGN KEY ([idPeriodo]) REFERENCES [Periodo]([id]);

ALTER TABLE [Turma] ADD CONSTRAINT [Turma_fk3] FOREIGN KEY ([idProfessor]) REFERENCES [Professor]([id]);

ALTER TABLE [Turma] ADD CONSTRAINT [Turma_fk4] FOREIGN KEY ([idCurso]) REFERENCES [Curso]([id]);

ALTER TABLE [Matricula] ADD CONSTRAINT [Matricula_fk2] FOREIGN KEY ([idAluno]) REFERENCES [Aluno]([id]);

ALTER TABLE [Matricula] ADD CONSTRAINT [Matricula_fk3] FOREIGN KEY ([idTurma]) REFERENCES [Turma]([id]);
