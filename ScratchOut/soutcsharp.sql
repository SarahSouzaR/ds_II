use master
go
drop database sout
go
Create database sout
go
use sout


create table usuario (
	idUsuario int NOT NULL identity(0,1),
	nmUsuario varchar(250),
	sexo varchar (12),
	senha varchar(36),
	
	PRIMARY KEY(idUsuario)
)


create table metodologia(
	idMetodologia int NOT NULL identity(0,1),
	dsNome varchar(180),
	
	PRIMARY KEY(idMetodologia)
)

create table tarefa(
	idTarefa int NOT NULL identity(0,1),
	idUsuario int NOT NULL,
	dsTitulo varchar(180),
	dtPrazoEst date,
	dsDescricao varchar(180),
	dtInicio date,
	dtFim date,
	idMetodologia int,
	
	primary key(idTarefa),
	FOREIGN KEY(idUsuario) references usuario(idUsuario),
	FOREIGN key(idMetodologia) references metodologia(idMetodologia)
)