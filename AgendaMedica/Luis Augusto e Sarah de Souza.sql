--use master
--go
--drop database AgendaMedica
--go

--create database AgendaMedica
--go
use AgendaMedica
go




--create table tb_funcionario(
--	id_funcionario int NOT NULL identity (1,1),
--	nmFuncioario VARCHAR(180),
--	dsEmail VARCHAR(180),
--	nrTelefone VARCHAR(180),
--	dtNascimento VARCHAR(36),
--	dsEndereco VARCHAR(250),
	
--	PRIMARY KEY (id_funcionario),
--)

--create table tb_clientes(
--	id_cliente int NOT NULL identity (1,1),
--	nmCliente VARCHAR(180),
--	dsEmail VARCHAR(180),
--	nrTelefone VARCHAR(16),
--	dtNascimento VARCHAR(36),
--	dsEndereco VARCHAR(180),
--	nrCPF VARCHAR(15),
--	id_funcionario int NOT NULL,
	
--	PRIMARY KEY (id_cliente),
--	FOREIGN KEY (id_funcionario) references tb_funcionario(id_funcionario),
--)

--create table tb_consulta(
--	id_consulta int NOT NULL identity (1,1),
--	id_cliente int not null,
--	id_funcionario int not null,
--	dtConsulta VARCHAR(36),
--	hrConsulta VARCHAR(36),
--	nmMedico VARCHAR(180),
	
--	PRIMARY KEY (id_consulta),
--	FOREIGN KEY (id_cliente) references tb_clientes (id_cliente),
--	FOREIGN KEY (id_funcionario) references tb_funcionario (id_funcionario),  	
--)

--insert into tb_funcionario (nmFuncioario,dsEmail,nrTelefone,dtNascimento,dsEndereco)
--values ('Carlos','carlos@carlos.com','1120380172','20-08-1996','rua tal, n 2');
--insert into tb_funcionario (nmFuncioario,dsEmail,nrTelefone,dtNascimento,dsEndereco)
--values ('Livia','livia@livia.com','1120450722','01-02-1996','rua tal, n 3');
--insert into tb_funcionario (nmFuncioario,dsEmail,nrTelefone,dtNascimento,dsEndereco)
--values ('Andre','andre@andre.com','1145820172','17-17-1982','rua ali, n 4');
--insert into tb_funcionario (nmFuncioario,dsEmail,nrTelefone,dtNascimento,dsEndereco)
--values ('Bianca','bianca@bianca.com','1120153857','01-06-1935','rua tal, n 2');
--insert into tb_funcionario (nmFuncioario,dsEmail,nrTelefone,dtNascimento,dsEndereco)
--values ('silvana','silvana@silvana.com','1120380172','20-08-1996','rua tal, n 2');


--insert into tb_clientes(nmCliente,nrCPF,dsEmail,dtNascimento, dsEndereco,nrTelefone,id_funcionario)
--values ('sarah','03186211633','sarah@sarah.com','10-09-1999','rua qualquer uma, 0','119968537',1);
--insert into tb_clientes(nmCliente,nrCPF,dsEmail,dtNascimento, dsEndereco,nrTelefone,id_funcionario)
--values ('giovanni','0626645622','giovanni@giovanni.com','07-12-1999','rua qualquer uma, 0','119965537',1);
--insert into tb_clientes(nmCliente,nrCPF,dsEmail,dtNascimento, dsEndereco,nrTelefone,id_funcionario)
--values ('diego','03186211633','sarah@sarah.com','22-06-2019','rua qualquer uma, 0','119968537',1);
--insert into tb_clientes(nmCliente,nrCPF,dsEmail,dtNascimento, dsEndereco,nrTelefone,id_funcionario)
--values ('thiago','03186211633','sarah@sarah.com','22-06-2019','rua qualquer uma, 0','119968537',1);
--insert into tb_clientes(nmCliente,nrCPF,dsEmail,dtNascimento, dsEndereco,nrTelefone,id_funcionario)
--values ('Evora','03186211633','sarah@sarah.com','12-03-2017','rua qualquer uma, 0','119968537',1);

--insert into tb_consulta(id_cliente,id_funcionario,dtConsulta,hrConsulta,nmMedico)
--values (1,1,'01-01-2019','7:00:00 AM','henrique');
--insert into tb_consulta(id_cliente,id_funcionario,dtConsulta,hrConsulta,nmMedico)
--values (2,3,'02-03-2019','7:00:00 AM','henrique');
--insert into tb_consulta(id_cliente,id_funcionario,dtConsulta,hrConsulta,nmMedico)
--values (3,2,'05-08-2019','7:00:00 AM','henrique');
--insert into tb_consulta(id_cliente,id_funcionario,dtConsulta,hrConsulta,nmMedico)
--values (4,5,'09-01-2020','7:00:00 AM','henrique');
--insert into tb_consulta(id_cliente,id_funcionario,dtConsulta,hrConsulta,nmMedico)
--values (5,4,'12-03-2019','7:00:00 AM','henrique');

select * from tb_funcionario

select * from tb_clientes

select * from tb_consulta