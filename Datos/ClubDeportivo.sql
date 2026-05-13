CREATE DATABASE club_deportivo;

USE club_deportivo;

CREATE TABLE Usuarios (
	IdUsuario INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Usuario VARCHAR(20),
    Password VARCHAR(20)
);
    
INSERT INTO Usuarios
(Usuario, Password) VALUES ('admin', '1234');


SELECT * FROM Usuarios;

--
-- PROCEDURE INGRESO LOGIH
--

DROP PROCEDURE IF EXISTS IngresoLogin;

DELIMITER //
CREATE PROCEDURE IngresoLogin(
    IN Usu VARCHAR(20),
    IN Pass VARCHAR(20)
)
BEGIN
    SELECT *
    FROM Usuarios
    WHERE Usuario = Usu
      AND Password = Pass;
END //
DELIMITER ;

CALL IngresoLogin('admin', '1234');