-- Create a new database called 'bd_apolice'
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'bd_apolice'
)
CREATE DATABASE bd_apolice
GO

USE bd_apolice

create table marca
(
    id int identity(1,1) primary key not null,
    nome varchar(100) not null unique
)

create table modelo
(
    id int identity(1,1) primary key not null,
    marca_id int foreign key references marca(id) not null,
    nome varchar(100) not null unique
)

create table carro
(
    id int identity(1,1) primary key not null,
    modelo_id int foreign key references modelo(id) not null,
    chassi varchar(20) not null unique,
    placa varchar(7) not null unique,
    renavam varchar(20) not null unique
)

create table apolice
(
	id int identity(1,1) primary key not null,
	carro_id int foreign key references carro(id) not null,
	dt_inicio date not null,
	dt_fim date not null,
	vl_franquia decimal not null,
	vl_premio decimal not null
)

insert into marca(nome) values 
('FIAT'),
('FORD'),
('RENAUT')

insert into modelo(nome, marca_id) values 
('UNO', 1), 
('PALIO', 1),
('PUNTO', 1),
('FIESTA', 2),
('FOCUS', 2),
('KA', 2),
('SANDERO', 3),
('CLIO', 3),
('DUSTER', 3)

insert into carro(modelo_id, chassi, placa, renavam) values 
(1, '9BWSU19F08B302158', 'JHW6773', '00123456791')
