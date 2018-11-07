use master
go

drop database cadastroFunc
go

create database cadastroFunc
go

use cadastroFunc
go

create table tb_funcionario(
	id int not null identity(1,1),
	nmFuncionario varchar(50) not null,
	email varchar(180),
	telefone varchar(30),
	endereco varchar(180)
	
	PRIMARY KEY(id)
)

INSERT INTO tb_funcionario(nmFUncionario) values('Carlos') 
 
insert into tb_funcionario(nmFuncionario,email,endereco,telefone) values('João','joaovictor@outlook.com','Rua ABCD, 103','2654-5698')

select * from tb_funcionario