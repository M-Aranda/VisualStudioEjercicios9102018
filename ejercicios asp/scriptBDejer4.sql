CREATE DATABASE ejercicio4NETASP
GO

USE ejercicio4NETASP
GO



CREATE TABLE usuario(
id INT IDENTITY(1,1),
nombreCompleto VARCHAR (50),
correo VARCHAR (50) UNIQUE,
contrasenia VARCHAR (30),
PRIMARY KEY (id)
)
GO

CREATE TABLE blog(
id INT IDENTITY(1,1),
titulo VARCHAR (50),
texto VARCHAR (1000),
etiquetas VARCHAR (500),
fk_usuario INT,
FOREIGN KEY (fk_usuario) REFERENCES usuario (id),
PRIMARY KEY (id)
)
GO

/*
SELECT * FROM usuario
SELECT * FROM blog

USE MASTER
GO
DROP DATABASE ejercicio4NETASP
GO
*/