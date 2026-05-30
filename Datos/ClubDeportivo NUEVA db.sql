
CREATE DATABASE club_deportivo_modif;
USE club_deportivo_modif;

--
-- CREAR TABLAS
--

CREATE TABLE Usuarios (
    idUsuario INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Usuario VARCHAR(20) UNIQUE,
    Password VARCHAR(20)
);

CREATE TABLE Clientes (
    idClientes INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(30),
    apellido VARCHAR(30),
	tipoDoc VARCHAR(10),
    dni VARCHAR(30) UNIQUE,
    aptoFisico BOOLEAN
);

CREATE TABLE Socios (
    idClientes INT NOT NULL PRIMARY KEY,
    nroCarnet INT,
    fecha_vencimiento_cuota DATETIME(6),
    FOREIGN KEY (idClientes) REFERENCES Clientes (idClientes)
);

CREATE TABLE Actividades (
    idActividades INT NOT NULL AUTO_INCREMENT PRIMARY KEY, 
    nombreActividad VARCHAR (30),
    costo_pase_diario DECIMAL(10,2)
);

CREATE TABLE NoSocios (
    idClientes INT NOT NULL PRIMARY KEY,
    idActividades INT, 
    fechaActividad DATETIME (6),
    FOREIGN KEY (idClientes) REFERENCES Clientes (idClientes),
	FOREIGN KEY (idActividades) REFERENCES Actividades (idActividades)
);

CREATE TABLE Inscripcion (
    idInscripcion INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    idClientes INT,
    Fecha DATETIME(6),
    FOREIGN KEY (idClientes) REFERENCES Clientes (idClientes)
);

CREATE TABLE Cuota (
    idCuota INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    idClientes INT NOT NULL, 
    Monto DECIMAL(10,2),
    fechaVencimiento DATETIME(6),
    Estado VARCHAR(20),
    FOREIGN KEY (idClientes) REFERENCES Socios (idClientes)
);

CREATE TABLE Pagos (
    idPagos INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    idCuota INT NULL, 
    idClientes INT NOT NULL, 
    Monto DECIMAL(10,2),
    fechaPago DATETIME(6),
    nroComprobante INT,
    FOREIGN KEY (idCuota) REFERENCES Cuota (idCuota),
	FOREIGN KEY (idClientes) REFERENCES Clientes (idClientes)
);

CREATE TABLE Carnet (
    idCarnet INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nroCarnet INT,
    fechaEmision DATETIME(6),
    idClientes INT,
    FOREIGN KEY (idClientes) REFERENCES Clientes (idClientes)
);

CREATE TABLE socio_actividad(
    idCliente INT,
    idActividad INT,
    fechaInscripcion DATETIME,
    PRIMARY KEY(idCliente,idActividad),
    FOREIGN KEY(idCliente) REFERENCES clientes(idClientes),
    FOREIGN KEY(idActividad) REFERENCES actividades(idActividades)
);

--
-- PROCEDURES
--

--
-- PROCEDURE REGISTRO
--

DROP PROCEDURE IF EXISTS RegistrarCliente;
DROP PROCEDURE IF EXISTS IngresoLogin;

DELIMITER //
CREATE PROCEDURE RegistrarCliente(
    IN Nom VARCHAR(30),
    IN Ape VARCHAR(30),
    IN tDoc VARCHAR(10),
    IN Doc VARCHAR(30),
    IN Apto BOOLEAN,
    IN esSocio BOOLEAN,
    IN idActividad INT,
    OUT rta INT
)
BEGIN
    DECLARE v_idClientes INT DEFAULT 0;
    DECLARE v_existe INT;
    DECLARE v_nroCarnet INT;
    
    SET v_existe = (SELECT COUNT(*) FROM Clientes WHERE tipoDoc = tDoc AND Dni = Doc);

    IF v_existe = 0 THEN
        INSERT INTO Clientes (Nombre, Apellido, TipoDoc, Dni, aptoFisico)
        VALUES (Nom, Ape, tDoc, Doc, Apto);
        SET v_idClientes = LAST_INSERT_ID();
        
        IF esSocio = TRUE THEN
		     IF (SELECT COUNT(*) FROM Socios) = 0 THEN
                 SET v_nroCarnet = 1000;
             ELSE
                 SET v_nroCarnet = (SELECT MAX(nroCarnet) + 1 FROM Socios);
			 END IF;
             
             INSERT INTO Socios (idClientes, nroCarnet, fecha_vencimiento_cuota)
             VALUES (v_idClientes, v_nroCarnet, DATE_ADD(NOW(), INTERVAL 1 MONTH));
             
             INSERT INTO Cuota (idClientes, Monto, fechaVencimiento, Estado)
			 VALUES(v_idClientes,40000,DATE_ADD(NOW(), INTERVAL 1 MONTH),'Pendiente');
             
             SET rta = v_nroCarnet;
	    ELSE
            INSERT INTO NoSocios (idClientes, idActividades, fechaActividad)
			VALUES (v_idClientes, idActividad, NOW());
        
			SET rta = v_idClientes;
		END IF;
        
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
('admin', '1234');

INSERT INTO Clientes (Nombre, Apellido, tipoDoc, Dni, aptoFisico) VALUES 
('Maria', 'Gomez', 'DNI', '32456741', TRUE),
('Jose', 'Perez', 'DNI', '32554124', TRUE),
('Camila', 'Sanchez', 'DNI', '29445114', TRUE),
('Federico', 'Gimenez', 'DNI', '30125998', TRUE);

INSERT INTO Socios (idClientes, nroCarnet, fecha_vencimiento_cuota) VALUES 
(1,'0001', '2026-04-30 14:30:00'),
(2, '0002', '2025-05-31 10:00:00');

INSERT INTO Actividades (nombreActividad, costo_pase_diario) VALUES 
('Spinnig', '10000'),
('Natacion', '15000'),
('Yoga', '12000'),
('Zumba', '8000');

INSERT INTO NoSocios (idClientes, idActividades, fechaActividad) VALUES 
(3, 1, '2026-04-11 14:00:00'),
(4, 2, '2025-05-15 10:00:00');

INSERT INTO Inscripcion (idClientes, Fecha) VALUES
(1,'2026-04-10 14:30:00'),
(2,'2025-05-10 10:00:00');

INSERT INTO Cuota (idClientes, Monto, fechaVencimiento, Estado) VALUES
(1, 40000, '2026-04-30 14:30:00', 'Pendiente'),
(2, 25000, '2025-05-31 10:00:00', 'Pendiente');

INSERT INTO Pagos (idCuota, idClientes, Monto, fechaPago, nroComprobante) VALUES
(1, 1, 40000, '2026-04-10 14:40:00', 1),
(2, 2, 25000, '2025-05-10 10:10:00', 2);

INSERT INTO Carnet (nroCarnet, fechaEmision, idClientes) VALUES
(0001, '2026-04-10 14:45:00',1),
(0002, '2025-05-10 10:15:00',2);

UPDATE club_deportivo.Inscripcion
SET IdClientes = 1
WHERE IdInscripcion = 1;

SELECT c.IdCuota, c.Monto, c.Estado, c.FechaVencimiento, c.IdClientes
FROM club_deportivo.cuota c
INNER JOIN club_deportivo.clientes p ON p.IdClientes = c.IdClientes
WHERE p.dni = "32456741";