CREATE DATABASE BOOSTER;
GO

USE BOOSTER;
GO

CREATE TABLE tb_produto (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Preco DECIMAL(18, 2) NOT NULL
);
GO