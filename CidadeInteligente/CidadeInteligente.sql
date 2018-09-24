--use master
--go
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

insert into tb_pessoa values ('Sarah','Rua X','Solteira','1999-09-10')


if OBJECT_ID (ps_Nome) is not null
drop proc ps_Nome
go
	create procedure ps_Nome
	@nm_Pessoa varchar(250) = null
as 
begin
	select * from tb_pessoa
	where @nm_Pessoa is null or nm_Pessoa like '%' + @nm_Pessoa + '%'
end


if OBJECT_ID (cd_CliPessoa) is not null
drop proc cd_CliPessoa
go
	create procedure cd_CliPessoa
	@cd_Pessoa int = null
as
begin
	select * from tb_cliente
	where @cd_Pessoa is null or cd_Pessoa like '%' + @cd_Pessoa + '%'
end


if object_id (cpf) is not null
drop cpf
go
	create procedure cpf
	@nr_CPF varchar(32) = null
as
begin
	select * from tb_documentos
	where @nr_CPF is null or nr_CPF like '%' + @nr_CPF + '%'
end




select * from tb_pessoa

ps_Nome