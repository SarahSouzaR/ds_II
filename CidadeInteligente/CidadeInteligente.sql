use master
go
drop database CidadeInteligente
go

create database CidadeInteligente
go

use CidadeInteligente
go


create table tb_pessoa(
	cd_Pessoa int NOT NULL identity (1,1),
	nm_Pessoa varchar(250),
	ds_Endereco varchar(250),
	ds_EstCivil varchar(250),
	dt_Nascimento date,

	PRIMARY KEY (cd_Pessoa)
)
create table tb_documentos(
	cd_Documento int NOT NULL identity (1,1),
	cd_Pessoa int NOT NULL,
	nr_RG varchar(32),
	nr_CPF varchar(32),
	nr_Reservista varchar(32),
	nr_CTPS varchar(32),
	nr_CNH varchar(32),
	
	PRIMARY KEY (cd_Documento),
	FOREIGN KEY (cd_Pessoa) references tb_pessoa (cd_Pessoa)
)
create table tb_funcionario(
	cd_Funcionario int not null identity (1,1),
	cd_Pessoa int not null,
	ds_Cargo varchar(150),
	nr_Salario varchar(50),
	nr_Ramal varchar(12),
	
	PRIMARY KEY (cd_Funcionario),
	FOREIGN KEY (cd_Pessoa) references tb_pessoa (cd_Pessoa)	
)
create table tb_cliente(
	cd_Cliente int not null identity (1,1),
	cd_Pessoa int not null,
	dt_Inclusao date,
	
	primary key (cd_Cliente),
	foreign key (cd_Pessoa) references tb_pessoa (cd_Pessoa)
)
