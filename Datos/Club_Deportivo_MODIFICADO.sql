DROP DATABASE club_deportivo_modif;
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

CREATE TABLE inscripcion_actividad (
    idInscripcion INT AUTO_INCREMENT PRIMARY KEY,
    idClientes INT NOT NULL,
    idActividad INT NOT NULL,
    formaPago VARCHAR(100) NOT NULL,
    monto DECIMAL(10,2) NOT NULL,
    fechaInscripcion DATETIME NOT NULL,

    CONSTRAINT fk_inscripcion_cliente
        FOREIGN KEY (idClientes)
        REFERENCES clientes(idClientes),

    CONSTRAINT fk_inscripcion_actividad
        FOREIGN KEY (idActividad)
        REFERENCES actividades(idActividades),

    CONSTRAINT uq_cliente_actividad
        UNIQUE (idClientes, idActividad)
);

--
-- PROCEDURES
--

--
-- PROCEDURE REGISTRO
--

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

SET v_existe = (
	SELECT COUNT(*)
    FROM Clientes
    WHERE tipoDoc = tDoc
    AND Dni = Doc
);

IF v_existe = 0 THEN

    INSERT INTO Clientes(Nombre ,Apellido, TipoDoc, Dni, aptoFisico)
    VALUES(Nom, Ape, tDoc, Doc, Apto);

    SET v_idClientes = LAST_INSERT_ID();

    IF esSocio = TRUE THEN

        IF (SELECT COUNT(*) FROM Socios) = 0 THEN 
			SET v_nroCarnet = 1000;
        ELSE
            SET v_nroCarnet = (SELECT MAX(nroCarnet) + 1 FROM Socios);
        END IF;

        INSERT INTO Socios(idClientes,nroCarnet,fecha_vencimiento_cuota)
        VALUES(v_idClientes,v_nroCarnet,DATE_ADD(NOW(), INTERVAL 1 MONTH));

        INSERT INTO Cuota(idClientes,Monto,fechaVencimiento,Estado)
        VALUES(v_idClientes,40000,CURDATE(),'Pendiente');
        SET rta = v_nroCarnet;

    ELSE
        INSERT INTO NoSocios(idClientes, idActividades, fechaActividad)
        VALUES(v_idClientes, idActividad, NOW());
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


--
-- OBTENER LISTADO CLIENTES
--


DELIMITER //

CREATE PROCEDURE ObtenerClientes(
    IN p_dni VARCHAR(30)
)
BEGIN

    SELECT
        c.idClientes,
        c.nombre,
        c.apellido,
        c.dni,
        a.nombreActividad,
        ia.fechaInscripcion,
	
		CASE
			WHEN s.idClientes IS NOT NULL THEN 'Socio'
			ELSE 'No Socio'
		END AS TipoCliente
        
    FROM Clientes c

    LEFT JOIN inscripcion_actividad ia ON ia.idClientes = c.idClientes
    LEFT JOIN Actividades a ON a.idActividades = ia.idActividad
	LEFT JOIN Socios s ON s.idClientes = c.idClientes
    WHERE (p_dni IS NULL OR c.dni = p_dni)
    ORDER BY c.idClientes, a.nombreActividad;

END //

DELIMITER ;


--
-- TRIGGER PARA CONFIRMAR INSCRIPCION LUEGO DEL REGISTRO
--

USE club_deportivo_modif;

DELIMITER //
CREATE TRIGGER trg_inscripcion
AFTER INSERT ON Clientes
FOR EACH ROW
BEGIN
INSERT INTO Inscripcion (idClientes, Fecha)
VALUES (NEW.idClientes, NOW());
END //
DELIMITER ;

--
-- TEST
--

INSERT INTO Usuarios (Usuario, Password) VALUES 
('admin', '1234');

INSERT INTO Actividades (nombreActividad, costo_pase_diario) VALUES 
('Spinnig', '10000'),
('Natacion', '15000'),
('Yoga', '12000'),
('Zumba', '8000');

UPDATE Inscripcion
SET IdClientes = 1
WHERE IdInscripcion = 1; 
