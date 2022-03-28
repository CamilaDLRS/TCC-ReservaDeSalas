CREATE DATABASE bdReserva
GO
USE bdReserva
--------------------TABELAS------------------------------------------------------------------------
GO
CREATE TABLE tb_reserva 
(
	id_reserva INTEGER PRIMARY KEY IDENTITY,
	id_sala INTEGER NOT NULL,
	id_usuario INTEGER NOT NULL,
	nome_disciplina VARCHAR(50) NOT NULL,
	nome_curso VARCHAR(50) NOT NULL,
	nome_modalidade VARCHAR(50) NOT NULL,
	data DATETIME NOT NULL,
	inicio DATETIME NOT NULL,
	fim DATETIME NOT NULL
)
GO
CREATE TABLE tb_sala 
(
	id_sala INTEGER PRIMARY KEY IDENTITY,
	nome_sala VARCHAR(50) NOT NULL,
	[status] BIT,
	informacoes VARCHAR(200)
)
GO
CREATE TABLE tb_usuario 
(
	id_usuario INTEGER PRIMARY KEY IDENTITY,
	nome_usuario VARCHAR(100) NOT NULL,
	[login] VARCHAR(50) NOT NULL,
	senha VARCHAR(MAX) NOT NULL,
	identificacao_adm BIT,
	id_casa INTEGER NOT NULL,
	[status] BIT
)
GO
CREATE TABLE tb_casa 
(
	id_casa INTEGER PRIMARY KEY IDENTITY,
	nome_casa VARCHAR(50) NOT NULL
)
GO
CREATE TABLE tb_modalidade 
(
	id_modalidade INTEGER PRIMARY KEY IDENTITY,
	nome_modalidade VARCHAR(50) NOT NULL,
	id_casa INTEGER NOT NULL,
	FOREIGN KEY(id_casa) REFERENCES tb_casa (id_casa)
)
GO
CREATE TABLE tb_curso 
(
	id_curso INTEGER PRIMARY KEY IDENTITY,
	nome_curso VARCHAR(50) NOT NULL,
	id_modalidade INTEGER NOT NULL,
	FOREIGN KEY(id_modalidade) REFERENCES tb_modalidade (id_modalidade)
)
GO
CREATE TABLE tb_disciplina 
(
	id_disciplina INTEGER PRIMARY KEY IDENTITY,
	nome_disciplina VARCHAR(50) NOT NULL,
	id_curso INTEGER NOT NULL,
	FOREIGN KEY(id_curso) REFERENCES tb_curso (id_curso)
)

GO
ALTER TABLE tb_reserva ADD FOREIGN KEY(id_sala) REFERENCES tb_sala (id_sala)
ALTER TABLE tb_reserva ADD FOREIGN KEY(id_usuario) REFERENCES tb_usuario (id_usuario)
ALTER TABLE tb_usuario ADD FOREIGN KEY(id_casa) REFERENCES tb_casa (id_casa)
GO
--------------------INSERÇÃO DE DADOS------------------------------------------------------------------------
INSERT INTO tb_casa VALUES('SESI'), ('SENAI'), ('SESI/SENAI')
GO
INSERT INTO tb_usuario VALUES ('Luis Carlos Hoinski Junior', 'LuisHoinski', '123456', 1, 2, 1),
							  ('Maria Cecilia', 'Cecilia', '123456', 1, 1, 1),
							  ('Bianca Carvalho', 'BiancaCarvalho', '123456', 0, 2, 1),
							  ('Wagner Santos de Oliveira', 'WagnerOliveira', '123456', 0, 2, 1),
							  ('Cristiano de Jesus', 'CrisJesus', '123456', 0, 1, 1), -- Professor de Geografia
							  ('Thatiana Teodósio ', 'ThatianaBio', '123456', 0, 1, 1), -- Professora de Biologia
							  ('Jenyfer Bartoski', 'JenyBartoski', '123456', 0, 1, 1) -- Professora de Inglês							  
GO
INSERT INTO tb_modalidade VALUES ('Ensino Médio', 1),
								 ('Aprendizagem', 2),
								 ('Ensino Técnico', 2),
								 ('Ensino Infantil', 1)
GO
INSERT INTO tb_curso VALUES	('NA', 1),
							('Informática', 3),
							('Logística', 3),
							('Segurança de Trabalho', 3),
							('NA', 4)
GO
INSERT INTO tb_disciplina VALUES ('Banco de Dados I', 3),
								 ('Banco de Dados II', 3),
								 ('Qualidade de Software I', 3),
								 ('Qualidade de Software II', 3),
								 ('Lógica de Programação', 3),
								 ('Modelagem de Sistemas', 3),
								 ('Biologia', 1),
								 ('Geografia', 1),
								 ('Inglês', 1),
								 ('Ciencias Aplicadas', 1),
								 ('História',1)
GO
INSERT INTO tb_sala VALUES ('Sala 01', 1, 'Falta uma cadeira.'),
						   ('Sala 02', 1, 'Toda quinta-feira há falta de carteiras devido ao movimento das mesmas à outras salas.'),	
						   ('Sala 03', 1, 'NA'),
						   ('Sala 04', 1, 'NA'),
						   ('Sala 05', 1, 'NA'),
						   ('Sala 06', 1, 'NA'),
						   ('Laboratório Fixo I', 1, 'Conexão de Internet falha nos computadores: 01, 08, 09'),
						   ('Laboratório Fixo II', 1, 'Alguns cabos estão deconectados dos computadores')

GO
INSERT INTO tb_reserva VALUES (8, 4, 'Qualidade de Software II','Informática','Ensino Técnico', (CONVERT(DATETIME,'2017-06-12 00:00:00')), (CONVERT(DATETIME,'2017-06-12 18:30:00')), (CONVERT(DATETIME,'2017-06-12 22:40:00' )))
--------------------STORED PROCEDURES------------------------------------------------------------------------

---USUARIO------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_usuario
	@p_id_usuario INT,
	@p_id_casa INT,
	@p_nome_usuario VARCHAR(50),
	@p_senha VARCHAR(50)
AS
BEGIN
	UPDATE tb_usuario
		SET  nome_usuario = @p_nome_usuario,
			senha = @p_senha,
			id_casa = @p_id_casa
		WHERE id_usuario = @p_id_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_usuario_adm
	@p_id_usuario INT,
	@p_adm BIT
AS
BEGIN
	UPDATE tb_usuario
		SET  identificacao_adm = @p_adm
		WHERE id_usuario = @p_id_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_usuario_resetar_senha
	@p_id_usuario INT,
	@p_senha VARCHAR(50)
AS
BEGIN
	UPDATE tb_usuario
		SET  senha = @p_senha
		WHERE id_usuario = @p_id_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_verificar_login
	@p_login VARCHAR(50)
AS
BEGIN
	SELECT [login] FROM tb_usuario WHERE [login] = @p_login
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_verificar_usuario
	@p_login VARCHAR(50)
	,@p_senha VARCHAR(MAX)
AS
BEGIN
	SELECT nome_usuario FROM tb_usuario WHERE [login] = @p_login AND senha = @p_senha
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_insert_usuario
	@p_nome_usuario VARCHAR(100),
	@p_login VARCHAR(50),
	@p_senha VARCHAR(MAX),
	@p_identificacao_adm BIT,
	@p_id_casa INT

AS
BEGIN
	IF NOT EXISTS (SELECT * FROM tb_usuario WHERE @p_login = [login])
	INSERT
		  INTO tb_usuario
	         (
			   nome_usuario
			 , [login]
			 , senha
			 , identificacao_adm
			 , id_casa
			 , [status]			 
			 )
      VALUES (
	          @p_nome_usuario            
			, @p_login       
			, @p_senha				   
			, @p_identificacao_adm	   
			, @p_id_casa
			, 1				   
	         )
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_all_usuario
AS
BEGIN
SELECT 	a.id_usuario,
		a.nome_usuario,
		a.[login],
		a.senha,
		a.identificacao_adm,
		a.id_casa,
		c.nome_casa,
		a.[status]

FROM tb_usuario a
INNER JOIN tb_casa c ON a.id_casa = c.id_casa 
ORDER BY nome_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_troca_de_status_usuario
	@p_id_usuario INT,
	@p_status BIT
AS
BEGIN	
	IF(@p_status = 0)
		BEGIN
		DELETE tb_reserva 
		WHERE id_usuario = @p_id_usuario AND inicio >= GETDATE()

		UPDATE tb_usuario
			SET  [status] = @p_status,
				nome_usuario = nome_usuario + ' - (Desativado)'
			WHERE id_usuario = @p_id_usuario
		END
	ELSE
		BEGIN
		UPDATE tb_usuario
			SET  [status] = @p_status,
				nome_usuario = REPLACE(nome_usuario, ' - (Desativado)', '')
			WHERE id_usuario = @p_id_usuario
		END
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_usuario
	@p_status BIT
AS
BEGIN
	SELECT 	a.id_usuario,
			a.nome_usuario,
			a.[login],
			a.senha,
			a.identificacao_adm,
			a.id_casa,
			c.nome_casa,
			a.[status]

	FROM tb_usuario a
	INNER JOIN tb_casa c ON a.id_casa = c.id_casa 
	WHERE @p_status = a.[status]
	ORDER BY nome_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_usuario_adm
	@p_adms BIT
AS
BEGIN
	SELECT 	a.id_usuario,
			a.nome_usuario,
			a.[login],
			a.senha,
			a.identificacao_adm,
			a.id_casa,
			c.nome_casa,
			a.[status]

	FROM tb_usuario a
	INNER JOIN tb_casa c ON a.id_casa = c.id_casa 
	WHERE @p_adms = a.identificacao_adm
	ORDER BY nome_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_usuario_by_casa
		@p_id_casa INT
	AS
	BEGIN
	SELECT 	a.id_usuario,
			a.nome_usuario,
			a.[login],
			a.senha,
			a.identificacao_adm,
			a.id_casa,
			c.nome_casa,
			a.[status]

	FROM tb_usuario a
	INNER JOIN tb_casa c ON a.id_casa = c.id_casa 
	WHERE @p_id_casa = a.id_casa
	ORDER BY nome_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_usuario_by_id
	@p_id_usuario INT	
AS
BEGIN
	SELECT 	a.id_usuario,
			a.nome_usuario,
			a.[login],
			a.senha,
			a.identificacao_adm,
			a.id_casa,
			c.nome_casa,
			a.[status]

	FROM tb_usuario a
	INNER JOIN tb_casa c ON a.id_casa = c.id_casa 
	WHERE @p_id_usuario = a.id_usuario
	ORDER BY nome_usuario
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_usuario_by_login
	@p_login VARCHAR(50)
	,@p_senha VARCHAR(MAX)
AS
BEGIN
	SELECT * FROM tb_usuario a 
INNER JOIN tb_casa c ON a.id_casa = c.id_casa
WHERE [login] = @p_login AND senha = @p_senha
END
----------------------------------------------------------------------------------

------DISCIPLINA------------------------------------------------------------------
GO
CREATE PROCEDURE sp_insert_disciplina
	@p_nome_disciplina VARCHAR(50),
	@p_id_curso INT
AS
BEGIN
	INSERT 
		INTO tb_disciplina
		(
			nome_disciplina,
			id_curso
		)
		VALUES
		(
			@p_nome_disciplina,
			@p_id_curso
		)
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_delete_disciplina
	@p_id_disciplina INT
AS
BEGIN
	DELETE tb_disciplina
		WHERE id_disciplina = @p_id_disciplina
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_disciplina
AS
BEGIN
	SELECT d.id_disciplina,d.nome_disciplina,d.id_curso,c.nome_curso,c.id_modalidade,m.nome_modalidade,casa.id_casa,casa.nome_casa 
	FROM tb_disciplina d
	INNER JOIN tb_curso c ON d.id_curso = c.id_curso
	INNER JOIN tb_modalidade m ON c.id_modalidade = m.id_modalidade 
	INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
	ORDER BY casa.nome_casa, m.nome_modalidade, c.nome_curso ASC
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_disciplina_by_id
	@p_id_curso INT
AS
BEGIN
	SELECT d.id_disciplina,d.nome_disciplina,d.id_curso,c.nome_curso,c.id_modalidade,m.nome_modalidade,casa.id_casa,casa.nome_casa 
	FROM tb_disciplina d
	INNER JOIN tb_curso c ON d.id_curso = c.id_curso
	INNER JOIN tb_modalidade m ON c.id_modalidade = m.id_modalidade 
	INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
	WHERE d.id_curso = @p_id_curso
	ORDER BY casa.nome_casa, m.nome_modalidade, c.nome_curso ASC
	
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_disciplina_count
	@p_id_casa INT
AS
BEGIN
	IF(@p_id_casa = 3)
	BEGIN
		SELECT COUNT (id_disciplina)
		FROM tb_disciplina d
		INNER JOIN tb_curso c ON d.id_curso = c.id_curso
		INNER JOIN tb_modalidade m ON c.id_modalidade = m.id_modalidade 
		INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
		WHERE casa.id_casa = 2 OR casa.id_casa = 1
	END
	ELSE
	BEGIN
		SELECT COUNT (id_disciplina)
		FROM tb_disciplina d
		INNER JOIN tb_curso c ON d.id_curso = c.id_curso
		INNER JOIN tb_modalidade m ON c.id_modalidade = m.id_modalidade 
		INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
		WHERE casa.id_casa = @p_id_casa
	END
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_disciplina
	@p_id_disciplina INT,
	@p_nome_disciplina VARCHAR(50),
	@p_id_curso INT
AS
BEGIN
	DECLARE @Nome VARCHAR(50)
	SET @Nome = (SELECT nome_disciplina FROM tb_disciplina	WHERE id_disciplina = @p_id_disciplina)
	
	UPDATE tb_reserva
		SET  nome_disciplina = @p_nome_disciplina
		WHERE nome_disciplina = @Nome

	UPDATE tb_disciplina
		SET  nome_disciplina = @p_nome_disciplina,
			 id_curso = @p_id_curso
		WHERE id_disciplina = @p_id_disciplina
END
----------------------------------------------------------------------------------

---CURSO--------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_insert_curso
	@p_nome_curso VARCHAR(50),
	@p_id_modalidade INT
AS
BEGIN
	INSERT 
		INTO tb_curso
		(
			nome_curso,
			id_modalidade
		)
		VALUES
		(
			@p_nome_curso,
			@p_id_modalidade
		)
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_curso
AS
BEGIN
	SELECT c.id_curso,c.nome_curso,c.id_modalidade,m.nome_modalidade,casa.id_casa,casa.nome_casa 
	FROM tb_curso c
	INNER JOIN tb_modalidade m ON c.id_modalidade = m.id_modalidade 
	INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
	ORDER BY casa.nome_casa, m.nome_modalidade, c.nome_curso ASC	
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_curso_by_id
	@p_id_modalidade INT
AS
BEGIN
	SELECT c.id_curso,c.nome_curso,c.id_modalidade,m.nome_modalidade,casa.id_casa,casa.nome_casa 
	FROM tb_curso c
	INNER JOIN tb_modalidade m ON c.id_modalidade = m.id_modalidade 
	INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
	WHERE @p_id_modalidade = c.id_modalidade 
	ORDER BY c.nome_curso
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_delete_curso
	@p_id_curso INT
AS
BEGIN
	DELETE tb_curso
		WHERE id_curso = @p_id_curso
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_curso
	@p_id_curso INT,
	@p_nome_curso VARCHAR(50),
	@p_id_modalidade INT
AS
BEGIN
	DECLARE @Nome VARCHAR(50)
	SET @Nome = (SELECT nome_curso FROM tb_curso WHERE id_curso = @p_id_curso)
	
	UPDATE tb_reserva
		SET  nome_curso = @p_nome_curso
		WHERE nome_curso = @Nome

	UPDATE tb_curso
		SET  nome_curso = @p_nome_curso,
			 id_modalidade = @p_id_modalidade
		WHERE id_curso = @p_id_curso
END
----------------------------------------------------------------------------------

------MODALIDADE------------------------------------------------------------------
GO
CREATE PROCEDURE sp_delete_modalidade
	@p_id_modalidade INT
AS
BEGIN
	DELETE tb_modalidade
		WHERE id_modalidade = @p_id_modalidade
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_insert_modalidade
	@p_nome_modalidade VARCHAR(50),
	@p_id_casa INT
AS
BEGIN
	INSERT 
		INTO tb_modalidade
		(
			nome_modalidade,
			id_casa
		)
		VALUES
		(
			@p_nome_modalidade,
			@p_id_casa
		)
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_modalidade
AS
BEGIN
	SELECT	m.id_modalidade,
			m.nome_modalidade,
			m.id_casa,
			c.nome_casa
			FROM tb_modalidade m
			INNER JOIN tb_casa c ON m.id_casa = c.id_casa
			ORDER BY m.nome_modalidade ASC	
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_modalidade_by_id
	@p_id_casa INT
AS
BEGIN
		SELECT m.id_modalidade,m.nome_modalidade,casa.id_casa,casa.nome_casa 
		FROM tb_modalidade m	
		INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
		WHERE @p_id_casa = m.id_casa
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_modalidade_sesi_senai
AS
BEGIN
		SELECT m.id_modalidade,m.nome_modalidade,casa.id_casa,casa.nome_casa 
		FROM tb_modalidade m	
		INNER JOIN tb_casa casa ON m.id_casa = casa.id_casa
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_modalidade
	@p_id_modalidade INT,
	@p_nome_modalidade VARCHAR(50),
	@p_id_casa INT
AS
BEGIN
	DECLARE @Nome VARCHAR(50)
	SET @Nome = (SELECT nome_modalidade FROM tb_modalidade WHERE id_modalidade = @p_id_modalidade)
	
	UPDATE tb_reserva
		SET  nome_modalidade = @p_nome_modalidade
		WHERE nome_modalidade = @Nome

	UPDATE tb_modalidade
		SET  nome_modalidade = @p_nome_modalidade,
			id_casa = @p_id_casa
		WHERE id_modalidade = @p_id_modalidade
END
----------------------------------------------------------------------------------

------CASA------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_insert_casa
	@p_nome_casa VARCHAR(50)	
AS
BEGIN
	INSERT 
		INTO tb_casa
		(
			nome_casa			
		)
		VALUES
		(
			@p_nome_casa			
		)
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_casa
AS
BEGIN
	SELECT id_casa,nome_casa FROM tb_casa
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_casa
	@p_id_casa INT,
	@p_nome_casa VARCHAR(50)
AS	
BEGIN
	UPDATE tb_casa
		SET  nome_casa = @p_nome_casa			 
		WHERE id_casa = @p_id_casa
END
----------------------------------------------------------------------------------

------SALA------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_troca_de_status_sala
	@p_id_sala INT,
	@p_status BIT	
AS
BEGIN

DELETE tb_reserva 
	WHERE id_sala = @p_id_sala AND inicio >= GETDATE()

	UPDATE tb_sala
		SET  [status] = @p_status,
			nome_sala = nome_sala + ' - (Excluída)'
		WHERE id_sala = @p_id_sala
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_insert_sala
	 @p_nome_sala	VARCHAR(50),
	 @p_informacoes VARCHAR(200)
AS
BEGIN
      INSERT
		  INTO tb_sala
	         (
			   nome_sala,
			   [status],
			   informacoes
			 )
      VALUES (
	           @p_nome_sala,
			   1,
			   @p_informacoes
	         )
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_sala
	@p_status	BIT
AS
BEGIN
	 
		  if(@p_status = 1)
			  BEGIN
			  SELECT id_sala
				, nome_sala
				, informacoes
				, [status]
			  FROM tb_sala
			  WHERE [status] = @p_status
			  END
		  ELSE
			  BEGIN
			  SELECT id_sala
				, nome_sala
				, informacoes
				, [status]
			  FROM tb_sala
		  END
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_sala_by_id
    @p_id_sala INT
AS
BEGIN
	SELECT nome_sala 
         FROM tb_sala
         WHERE id_sala = @p_id_sala;
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_sala
    @p_id_sala		INT
  , @p_nome_sala    VARCHAR(50)
  , @p_informacoes VARCHAR(200)
  
AS
BEGIN
     UPDATE tb_sala
     SET nome_sala  = @p_nome_sala,
		informacoes = @p_informacoes
			   
         WHERE id_sala = @p_id_sala;
END
----------------------------------------------------------------------------------

------RESERVA---------------------------------------------------------------------
GO
CREATE PROCEDURE sp_delete_reserva
	@p_id_reserva INT
AS
BEGIN
	DELETE tb_reserva
		WHERE id_reserva = @p_id_reserva
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_insert_reserva
	@p_id_sala INT,
	@p_id_usuario INT,
	@p_nome_disciplina VARCHAR(50),
	@p_nome_curso VARCHAR(50),
	@p_nome_modalidade VARCHAR(50),
	@p_data DATE,
	@p_inicio DATETIME,
	@p_fim DATETIME

AS
BEGIN
	INSERT
		  INTO tb_reserva
	         (
			 	id_sala,
				id_usuario,
				nome_disciplina,
				nome_curso,
				nome_modalidade,
				data,
				inicio,
				fim
	         )	 
      VALUES (
	          	@p_id_sala,
				@p_id_usuario,
				@p_nome_disciplina,
				@p_nome_curso,
				@p_nome_modalidade,
				@p_data,
				@p_inicio,
				@p_fim
	         )
	
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_reserva	
AS
BEGIN
	SELECT 
				r.id_reserva,
				s.id_sala,
				r.id_usuario,
				u.nome_usuario,
				u.id_casa,
				c.nome_casa,
				r.nome_disciplina,
				r.nome_curso,
				r.nome_modalidade,
				r.data,
				r.inicio,
				r.fim,
				s.nome_sala

FROM tb_reserva r
INNER JOIN tb_sala s ON r.id_sala = s.id_sala
INNER JOIN tb_usuario u ON r.id_usuario = u.id_usuario
INNER JOIN tb_casa c ON u.id_casa = c.id_casa
WHERE r.inicio <= GETDATE() AND r.fim > GETDATE()
ORDER BY r.inicio
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_reserva_filtros
	@p_id_sala CHAR NULL,
	@p_id_usuario CHAR NULL,
	@p_id_casa CHAR NULL
AS
BEGIN
	DECLARE @String VARCHAR(8000)
	SET @String = 'SELECT 
				id_reserva,
				s.id_sala,
				r.id_usuario,
				u.nome_usuario,
				u.id_casa,
				c.nome_casa,
				nome_disciplina,
				nome_curso,
				nome_modalidade,
				data,
				inicio,
				fim,
				s.nome_sala

FROM tb_reserva r 
INNER JOIN tb_sala s ON r.id_sala = s.id_sala
INNER JOIN tb_usuario u ON r.id_usuario = u.id_usuario
INNER JOIN tb_casa c ON u.id_casa = c.id_casa

WHERE u.id_casa < 100 '	
		IF(@p_id_sala != '0')
		BEGIN
			SET @String = @String + ' AND (r.id_sala = '+@p_id_sala+')'
		END
		IF(@p_id_casa != '0')
		BEGIN
			SET @String = @String + ' AND u.id_casa = '+@p_id_casa+''
		END
		IF(@p_id_usuario != '0')
		BEGIN
			SET @String = @String + 'AND r.id_usuario = '+@p_id_usuario+''
		END
			
		SET @String = @String + ' ORDER BY r.inicio'
EXEC (@String)
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_select_reserva_sala_data
	@p_id_sala INT,
	@p_data DATE
AS
BEGIN
	SELECT 
				id_reserva,
				s.id_sala,
				r.id_usuario,
				u.nome_usuario,
				u.id_casa,
				c.nome_casa,
				nome_disciplina,
				nome_curso,
				nome_modalidade,
				data,
				inicio,
				fim,
				s.nome_sala

FROM tb_reserva r 
INNER JOIN tb_sala s ON r.id_sala = s.id_sala
INNER JOIN tb_usuario u ON r.id_usuario = u.id_usuario
INNER JOIN tb_casa c ON u.id_casa = c.id_casa
WHERE r.id_sala = @p_id_sala AND r.data = @p_data
ORDER BY r.inicio
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_adm_reserva
	@p_id_reserva INT,
	@p_id_sala INT,
	@p_data DATE,
	@p_inicio DATETIME,
	@p_fim DATETIME
AS
BEGIN
	UPDATE tb_reserva
	         SET
			 	id_sala = @p_id_sala,
				data = @p_data,
				inicio = @p_inicio,
				fim = @p_fim
	WHERE id_reserva = @p_id_reserva
END
----------------------------------------------------------------------------------
GO
CREATE PROCEDURE sp_update_reserva
	@p_id_reserva INT,
	@p_id_sala INT,
	@p_nome_disciplina VARCHAR(50),
	@p_nome_curso VARCHAR(50),
	@p_nome_modalidade VARCHAR(50),
	@p_data DATE,
	@p_inicio DATETIME,
	@p_fim DATETIME
AS
BEGIN
	UPDATE tb_reserva
	         SET
			 	id_sala = @p_id_sala,
				nome_disciplina = @p_nome_disciplina,
				nome_curso = @p_nome_curso,
				nome_modalidade = @p_nome_modalidade,
				data = @p_data,
				inicio = @p_inicio,
				fim = @p_fim
	WHERE id_reserva = @p_id_reserva
END
----------------------------------------------------------------------------------

