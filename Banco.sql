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
    nome varchar(100) not null
)

create table modelo
(
    id int identity(1,1) primary key not null,
    marca_id int foreign key references marca(id) not null,
    nome varchar(100) not null
)

create table carro
(
    id int identity(1,1) primary key not null,
    modelo_id int foreign key references modelo(id) not null,
    chassi varchar(20) not null,
    placa varchar(7),
    renavam varchar(15)
)