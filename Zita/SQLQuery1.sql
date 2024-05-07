CREATE TABLE Usuarios (
    IDUsuario int PRIMARY KEY IDENTITY,
    NomeUsuario varchar(50) NOT NULL,
    Email varchar(100) NOT NULL,
    Senha varchar(255) NOT NULL
);