use master
go

drop database SistemaBiblioteca
go

create database SistemaBiblioteca
go

use SistemaBiblioteca
go

create table tbAluno (
	idAluno int primary key identity(1,1) not null,
	nome varchar (150),
	dtNasc varchar (30),
	email varchar (150),
	endereco varchar (150),
	telefone varchar (50),
	rg varchar (50),
	cpf varchar (50),
	rm varchar (50),
	turma varchar (50)
)
go

insert into tbAluno(nome, dtNasc, email, endereco, telefone, rg, cpf, rm, turma) values
('Antonio', '01/06/1999','antonio.marcos@gmail.com', 'Rua Moraes Souza, 548', '3658-9647', '23.659.965-6', '456.654.987-23', '14291', '3º Info'),
('Bruno', '20/08/1999','bruninho.amaral@outlook.com', 'Rua Lopes Oliveira, 495', '6598-5287', '23.654.456-9', '132.654.159-45', '14289', '3º Info'),
('Carla', '15/07/1999','carla_gomes@hotmail.com', 'Rua das Margaridas, 30', '96879-4562', '26.549.874-2', '654.987.632-12', '14365', '3º Info'),
('Daniel', '08/11/2000','daniel.ribeiro@gmail.com', 'Av. São Miguel, 2200', '94248-6598', '24.564.987-9', '345.698.321-98', '15654', '2º Info'),
('Eduarda', '19/10/2000','eduarda.faria@outlook.com', 'Av. Amaral, 1565', '2345-9865', '28.659.654-2', '321.659.854-66', '15987', '2º Info'),
('Fabricio', '04/12/2000','fabricio_goncalves@outlook.com', 'Rua das Flores, 654', '3265-9865', '26.326.659-1', '326.659.612-65', '15456', '2º Info'),
('Gabriel', '16/03/2001','gabriel.desouza@gmail.com', 'Rua Oliveira Garcia, 348', '98745-6598', '29.659.642-3', '324.658.319-45', '16326', '1º Info'),
('Helena', '27/10/2001','helena.oliveira@outlook.com', 'Av. Celso Garcia, 1698', '96512-9869', '27.659.412-1', '327.987.653-22', '16498', '1º Info'),
('Igor', '02/07/2001','igor.s.santos@outlook.com', 'Rua das Amélias, 321', '93654-9861', '25.986.325-8', '329.824.915-11', '16598', '1º Info')
go

create table tbEmprestimo (
	idEmprestimo int primary key identity(1,1) not null,
	nmLivro varchar (50),
	dtDevolucao varchar (50),
	nmAluno varchar (150),
	turma varchar(50)	
)
go

insert into tbEmprestimo (nmLivro, dtDevolucao, nmAluno, turma) values
('A Garota no Trem', '14/12/2018', 'Carla', '3° Info'),
('A Sorte do Agora', '07/12/2018', 'Eduarda', '2° Info'),
('Blackbird', '12/12/2018', 'Helena', '1° Info'),
('Jeremy Fink e o Sentido da Vida', '05/12/2018', 'Igor', '1° Info')
go

select * from tbAluno
select * from tbEmprestimo