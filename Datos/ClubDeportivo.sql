CREATE DATABASE club_deportivo;
USE club_deportivo;

--
-- CREAR TABLAS
--

CREATE TABLE Usuarios (
    IdUsuario INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Usuario VARCHAR(20) UNIQUE,
    Password VARCHAR(20)
);

CREATE TABLE Socios (
    IdSocio INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    TipoDoc VARCHAR(10),
    Documento VARCHAR(20)
);

CREATE TABLE Inscripcion (
    IdInscripcion INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Fecha DATETIME(6)
);

CREATE TABLE Cuota (
    IdCuota INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Monto DECIMAL(10,2),
    FechaPago DATETIME(6),
    FechaVencimiento DATETIME(6),
    Estado VARCHAR(20) DEFAULT 'Pendiente',
    IdSocio INT,
    FOREIGN KEY (IdSocio) REFERENCES Socios (IdSocio)
);

CREATE TABLE Pagos (
    IdPagos INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Monto DECIMAL(10,2),
    FechaPago DATETIME(6),
    NroComprobante INT(20)
);

CREATE TABLE Carnet (
    IdPagos INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    NroCarnet INT(30),
    FechaEmision DATETIME(6)
);

CREATE TABLE Actividad (
    IdActividad INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(30),
    Horario TIME
);

--
-- PROCEDURES
--

--
-- PROCEDURE REGISTRO
--

DROP PROCEDURE IF EXISTS RegistroSocio;
DROP PROCEDURE IF EXISTS IngresoLogin;

DELIMITER //
CREATE PROCEDURE RegistroSocio(
    IN Nom VARCHAR(50),
    IN Ape VARCHAR(50),
    IN TDoc VARCHAR(10),
    IN Doc VARCHAR(20),
    OUT rta INT
)
BEGIN
    DECLARE filas INT DEFAULT 0;
    DECLARE existe INT DEFAULT 0;

    SET filas = (SELECT COUNT(*) FROM Socios);

    IF filas = 0 THEN
        SET filas = 1000;
    ELSE
        SET filas = (SELECT MAX(IdSocio) + 1 FROM Socios);
        SET existe = (SELECT COUNT(*) FROM Socios WHERE TipoDoc = TDoc AND Documento = Doc);
    END IF;

    IF existe = 0 THEN
        INSERT INTO Socios VALUES(filas, Nom, Ape, TDoc, Doc);
        SET rta = filas;
    ELSE
        SET rta = 1;
    END IF;
END //
DELIMITER ;

--
-- PROCEDURE LOGIN
--

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

-- TEST
INSERT INTO Usuarios (Usuario, Password) VALUES 
('Admin', '1234');

INSERT INTO Socios (Nombre, Apellido, TipoDoc, Documento) VALUES 
('Maria', 'Gomez', 'DNI', '32456741'),
('Carla', 'Sanchez', 'DNI', '29456741'),
('Pedro', 'Perez', 'DNI', '15454441'),
('Mario', 'Ferreyra', 'DNI', '19456741');

INSERT INTO Inscripcion (Fecha) VALUES
('2026-05-10 14:30:00'),
('2025-04-14 10:30:00'),
('2026-01-18 19:30:00'),
('2025-08-30 09:25:00');

INSERT INTO Cuota (IdSocio, Monto, Estado, FechaPago, FechaVencimiento) VALUES
(1, 40000.00, 'Pendiente', '2026-05-10 14:30:00', '2026-06-10 00:00:00'),
(2, 25000.00, 'Pendiente', '2025-04-14 10:30:00', '2025-05-14 00:00:00'),
(3, 10000.00, 'Pendiente','2026-01-18 19:30:00', '2026-02-18 00:00:00'),
(4, 35000.00, 'Pendiente','2025-08-30 09:25:00', '2025-09-30 00:00:00');

INSERT INTO Pagos (Monto, FechaPago, NroComprobante) VALUES
(40000.00, '2026-05-10 14:30:00', 1),
(25000.00, '2025-04-14 10:30:00', 2),
(10000.00, '2026-01-18 19:30:00', 3),
(35000.00, '2025-08-30 09:25:00', 4);

INSERT INTO Carnet (NroCarnet, FechaEmision) VALUES
(144, '2026-05-10 14:30:00'),
(29, '2025-04-14 10:30:00'),
(41, '2026-01-18 19:30:00'),
(7, '2025-08-30 09:25:00');

INSERT INTO Actividad (Nombre, Horario) VALUES
('Natacion', '14:00:00'),
('Spinning', '20:00:00'),
('Yoga', '09:00:00'),
('Zumba', '15:00:00');

CALL RegistroSocio('Juan', 'Pérez', 'DNI', '12345678');
CALL IngresoLogin('admin', '1234');

SELECT * FROM Usuarios;
SELECT * FROM Socios;
SELECT * FROM Cuota;