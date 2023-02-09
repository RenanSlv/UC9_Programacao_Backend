--comando para criação do banco de dados
CREATE DATABASE	TesteSegurancaBE11;

--comando para colocar um banco de dados em uso
USE TesteSegurancaBE11;

--comando para criar uma tabela no banco de dados
CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
);

--comando para inserir valores na tabela de usuários
INSERT INTO Usuarios VALUES ('email@email.com',1234);

--comando para selecionar os usuários do banco
SELECT * FROM Usuarios;

--hashear a senha
SELECT Email, HASHBYTES('MD2',Senha) FROM Usuarios;

SELECT Email, HASHBYTES('MD2',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;

SELECT Email, HASHBYTES('MD4',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;

SELECT Email, HASHBYTES('MD5',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;

SELECT Email, HASHBYTES('SHA',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;

SELECT Email, HASHBYTES('SHA1',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;

SELECT Email, HASHBYTES('SHA_256',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;

SELECT Email, HASHBYTES('SHA2_512',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id=1;