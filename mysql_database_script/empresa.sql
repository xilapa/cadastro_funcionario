create database if not exists empresa;

create table if not exists funcionarios (
 matricula int auto_increment primary key not null,
 cpf varchar(11) unique	not null,
 nome varchar(80)  not null,
 data_nascimento date not null,
 endereco varchar(200) not null 
);

desc funcionarios;

select * from funcionarios;

insert into funcionarios(cpf,nome,data_nascimento,endereco) values ("12345678911","Teste","2020-08-29","Rua Joaquim");