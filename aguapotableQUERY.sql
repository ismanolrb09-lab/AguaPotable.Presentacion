
USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'AguaPotableDB')
    DROP DATABASE AguaPotableDB;
GO

CREATE DATABASE AguaPotableDB;
GO
USE AguaPotableDB;
GO


-- TABLA: Usuarios (para frmLogin)

CREATE TABLE Usuarios (
    UsuarioID      INT          IDENTITY PRIMARY KEY,
    NombreUsuario  VARCHAR(50)  NOT NULL UNIQUE,
    Contrasena     VARCHAR(100) NOT NULL,
    NombreCompleto VARCHAR(100) NOT NULL,
    Rol            VARCHAR(20)  NOT NULL DEFAULT 'Operador'
        CONSTRAINT CHK_Usuarios_Rol CHECK (Rol IN ('Administrador','Supervisor','Operador')),
    Activo         BIT          NOT NULL DEFAULT 1
);
GO


--TABLA: Clientes (R = Residencial, C = Comercial)

CREATE TABLE Clientes (
    ClienteID   INT          IDENTITY PRIMARY KEY,
    Cedula      VARCHAR(13)  NOT NULL
        CONSTRAINT UQ_Clientes_Cedula UNIQUE,
    Nombre      VARCHAR(100) NOT NULL,
    Apellido    VARCHAR(100) NOT NULL,
    Telefono    VARCHAR(20)  NULL,
    Direccion   VARCHAR(200) NOT NULL,
    TipoCliente CHAR(1)      NOT NULL
        CONSTRAINT CHK_Clientes_Tipo CHECK (TipoCliente IN ('R','C')),
    Activo      BIT          NOT NULL DEFAULT 1
);
GO

--TABLA: Medidores

CREATE TABLE Medidores (
    MedidorID    INT         IDENTITY PRIMARY KEY,
    NumeroSerial VARCHAR(50) NOT NULL
        CONSTRAINT UQ_Medidores_Serial UNIQUE,
    ClienteID    INT         NULL,
    Estado       VARCHAR(20) NOT NULL DEFAULT 'Activo'
        CONSTRAINT CHK_Medidores_Estado CHECK (Estado IN ('Activo','Suspendido','Retirado')),
    CONSTRAINT FK_Medidores_Clientes
        FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);
GO


--TABLA: Lecturas
CREATE TABLE Lecturas (
    LecturaID       INT           IDENTITY PRIMARY KEY,
    MedidorID       INT           NOT NULL,
    FechaLectura    DATE          NOT NULL DEFAULT GETDATE(),
    LecturaAnterior DECIMAL(10,2) NOT NULL,
    LecturaActual   DECIMAL(10,2) NOT NULL,
    ConsumoM3 AS (LecturaActual - LecturaAnterior) PERSISTED,
    CONSTRAINT CHK_Lecturas_Valor
        CHECK (LecturaActual >= LecturaAnterior),
    CONSTRAINT FK_Lecturas_Medidores
        FOREIGN KEY (MedidorID) REFERENCES Medidores(MedidorID)
);
GO

--TABLA: Facturas

CREATE TABLE Facturas (
    FacturaID        INT           IDENTITY PRIMARY KEY,
    NumeroFactura    VARCHAR(20)   NOT NULL
        CONSTRAINT UQ_Facturas_Numero UNIQUE,
    ClienteID        INT           NOT NULL,
    LecturaID        INT           NOT NULL,
    FechaEmision     DATE          NOT NULL DEFAULT GETDATE(),
    FechaVencimiento DATE          NOT NULL,
    ConsumoM3        DECIMAL(10,2) NOT NULL
        CONSTRAINT CHK_Facturas_Consumo CHECK (ConsumoM3 >= 0),
    Total            DECIMAL(10,2) NOT NULL
        CONSTRAINT CHK_Facturas_Total CHECK (Total >= 0),
    Estado           VARCHAR(20)   NOT NULL DEFAULT 'Pendiente'
        CONSTRAINT CHK_Facturas_Estado CHECK (Estado IN ('Pendiente','Pagada','Vencida','Anulada')),
    FechaPago        DATE          NULL,
    CONSTRAINT FK_Facturas_Clientes
        FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    CONSTRAINT FK_Facturas_Lecturas
        FOREIGN KEY (LecturaID) REFERENCES Lecturas(LecturaID)
);
GO


--TABLA: OrdenesCorte
CREATE TABLE OrdenesCorte (
    OrdenID        INT          IDENTITY PRIMARY KEY,
    ClienteID      INT          NOT NULL,
    MedidorID      INT          NOT NULL,
    TipoOrden      VARCHAR(20)  NOT NULL
        CONSTRAINT CHK_Ordenes_Tipo CHECK (TipoOrden IN ('Corte','Reconexion')),
    FechaOrden     DATE         NOT NULL DEFAULT GETDATE(),
    FechaEjecucion DATE         NULL,
    Estado         VARCHAR(20)  NOT NULL DEFAULT 'Pendiente'
        CONSTRAINT CHK_Ordenes_Estado CHECK (Estado IN ('Pendiente','Ejecutada','Cancelada')),
    Motivo         VARCHAR(200) NULL,
    CONSTRAINT FK_Ordenes_Clientes
        FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    CONSTRAINT FK_Ordenes_Medidores
        FOREIGN KEY (MedidorID) REFERENCES Medidores(MedidorID)
);
GO

-- DATOS DE PRUEBA

INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, Rol) VALUES
('admin',     'admin123', 'Administrador', 'Administrador'),
('operador1', 'op2025',   'Juan Santos',   'Operador');

INSERT INTO Clientes (Cedula, Nombre, Apellido, Telefono, Direccion, TipoCliente) VALUES
('001-1234567-8', 'Maria',    'Gonzalez', '809-555-1001', 'Calle Duarte #12',       'R'),
('001-2345678-9', 'Pedro',    'Martinez', '829-555-1002', 'Av. Independencia #45',  'R'),
('001-3456789-0', 'Ana',      'Ramirez',  '849-555-1003', 'Calle El Conde #8',      'R'),
('001-4567890-1', 'Luis',     'Fernandez','809-555-1004', 'Av. 27 de Febrero #101', 'R'),
('001-5678901-2', 'Roberto',  'Sanchez',  '809-555-2001', 'Calle Comercio #55',     'C'),
('001-6789012-3', 'Patricia', 'Vargas',   '829-555-2002', 'Av. Zona Franca #10',    'C');

INSERT INTO Medidores (NumeroSerial, ClienteID, Estado) VALUES
('MED-001', 1, 'Activo'),
('MED-002', 2, 'Activo'),
('MED-003', 3, 'Activo'),
('MED-004', 4, 'Activo'),
('MED-005', 5, 'Activo'),
('MED-006', 6, 'Suspendido'),
('MED-007', NULL, 'Activo');

INSERT INTO Lecturas (MedidorID, FechaLectura, LecturaAnterior, LecturaActual) VALUES
(1, '2025-06-05', 1240, 1268),
(2, '2025-06-05',  890,  923),
(3, '2025-06-06',  456,  479),
(4, '2025-06-06', 2100, 2148),
(5, '2025-06-07', 5600, 5682),
(6, '2025-06-07', 3200, 3318);

INSERT INTO Facturas (NumeroFactura, ClienteID, LecturaID, FechaEmision, FechaVencimiento, ConsumoM3, Total, Estado) VALUES
('FAC-2025-001', 1, 1, '2025-06-10', '2025-06-25',  28,  2630,   'Pagada'),
('FAC-2025-002', 2, 2, '2025-06-10', '2025-06-25',  33,  3055,   'Pendiente'),
('FAC-2025-003', 3, 3, '2025-06-10', '2025-06-25',  23,  2205,   'Pendiente'),
('FAC-2025-004', 4, 4, '2025-06-10', '2025-06-25',  48,  4330,   'Vencida'),
('FAC-2025-005', 5, 5, '2025-06-10', '2025-06-25',  82, 14431,   'Pendiente'),
('FAC-2025-006', 6, 6, '2025-06-10', '2025-06-25', 118, 20378,   'Vencida');

INSERT INTO OrdenesCorte (ClienteID, MedidorID, TipoOrden, FechaOrden, Estado, Motivo) VALUES
(4, 4, 'Corte',      '2025-06-26', 'Pendiente', 'Factura vencida'),
(6, 6, 'Corte',      '2025-06-26', 'Ejecutada', 'Factura vencida'),
(6, 6, 'Reconexion', '2025-06-28', 'Pendiente', 'Pago recibido');
GO

