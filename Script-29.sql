-- Eliminar tablas si existen (orden inverso por dependencias)
DROP TABLE IF EXISTS Pago, Egreso, Nomina, PagoFotografo, AsignacionDeEquipo, EquipoFotografico,
Fotografo, Despacho, Fotografia, Reserva, PaqueteDeServicio, Evento, mensajero, Bebe, Cliente, Persona CASCADE;


-- Tabla Cliente
CREATE TABLE Cliente (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Telefono VARCHAR(50) NOT NULL,
    Email VARCHAR(50),
    Direccion VARCHAR(50) NOT NULL
);
CREATE INDEX idx_cliente_telefono ON Cliente(Telefono);

-- Tabla Bebe
CREATE TABLE Bebe (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Fecha_Nacimiento DATE NOT NULL,
    Sexo VARCHAR(10)
);
CREATE INDEX idx_bebe_nombre ON Bebe(Nombre);

-- Tabla Mensajero
CREATE TABLE Mensajero (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(50) NOT NULL,
    Email VARCHAR(50),
    Tipo VARCHAR(50) NOT NULL,
    Direccion VARCHAR(50) NOT NULL
);
CREATE INDEX idx_mensajero_telefono ON Mensajero(Telefono);

-- Tabla Evento
CREATE TABLE Evento (
    Id SERIAL PRIMARY KEY,
    Tipo VARCHAR(100),
    Fecha DATE NOT NULL,
    Ubicacion VARCHAR(255)
);
CREATE INDEX idx_evento_fecha ON Evento(Fecha);
CREATE INDEX idx_evento_tipo ON Evento(Tipo);

-- Tabla PaqueteDeServicio
CREATE TABLE PaqueteDeServicio (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Descripcion TEXT,
    Duración INT NOT NULL
);
CREATE INDEX idx_paquete_precio ON PaqueteDeServicio(Precio);

-- Tabla Reserva
CREATE TABLE Reserva (
    Id SERIAL PRIMARY KEY,
    Fecha DATE NOT NULL,
    Estado VARCHAR(50),
    Cliente_Id INT NOT NULL,
    Evento_Id INT NOT NULL,
    Paquete_ServicioId INT NOT NULL,
    FOREIGN KEY (Cliente_Id) REFERENCES Cliente(Id),
    FOREIGN KEY (Evento_Id) REFERENCES Evento(Id),
    FOREIGN KEY (Paquete_ServicioId) REFERENCES PaqueteDeServicio(Id)
);
CREATE INDEX idx_reserva_fecha ON Reserva(Fecha);
CREATE INDEX idx_reserva_cliente ON Reserva(Cliente_Id);

-- Tabla Fotografia
CREATE TABLE Fotografia (
    Id SERIAL PRIMARY KEY,
    Formato VARCHAR(10),
    Tamaño_MB DOUBLE PRECISION,
    Evento_Id INT NOT NULL,
    FOREIGN KEY (Evento_Id) REFERENCES Evento(Id)
);
CREATE INDEX idx_foto_evento ON Fotografia(Evento_Id);

-- Tabla Despacho
CREATE TABLE Despacho (
    Id SERIAL PRIMARY KEY,
    Fecha_Despacho DATE,
    Estado VARCHAR(50),
    Cliente_Id INT NOT NULL,
    Mensajero_Id INT,
    Numero_Paquetes INT NOT NULL,
    FOREIGN KEY (Cliente_Id) REFERENCES Cliente(Id),
    FOREIGN KEY (Mensajero_Id) REFERENCES Mensajero(Id)
);
CREATE INDEX idx_despacho_fecha ON Despacho(Fecha_Despacho);

-- Tabla Fotografo
CREATE TABLE Fotografo (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(100),
    Especialidad VARCHAR(100)
);
CREATE INDEX idx_fotografo_especialidad ON Fotografo(Especialidad);

-- Tabla EquipoFotografico
CREATE TABLE EquipoFotografico (
    Id SERIAL PRIMARY KEY,
    Nombre VARCHAR(100),
    Modelo VARCHAR(50),
    Estado VARCHAR(50),
    Tipo VARCHAR(50)
);
CREATE INDEX idx_equipo_tipo ON EquipoFotografico(Tipo);

-- Tabla AsignacionDeEquipo
CREATE TABLE AsignacionDeEquipo (
    Id SERIAL PRIMARY KEY,
    Fecha_asignacion DATE NOT NULL,
    Fecha_entrega DATE NOT NULL,
    Fotografo_Id INT NOT NULL,
    Equipo_Id INT NOT NULL,
    Estado VARCHAR(100),
    FOREIGN KEY (Fotografo_Id) REFERENCES Fotografo(Id),
    FOREIGN KEY (Equipo_Id) REFERENCES EquipoFotografico(Id)
);
CREATE INDEX idx_asignacion_fecha ON AsignacionDeEquipo(Fecha_asignacion);

-- Tabla PagoFotografo
CREATE TABLE PagoFotografo (
    Id SERIAL PRIMARY KEY,
    Monto DECIMAL(10,2) NOT NULL,
    FechaPago DATE NOT NULL,
    Metodo VARCHAR(50),
    FotografoId INT NOT NULL,
    FOREIGN KEY (FotografoId) REFERENCES Fotografo(Id)
);
CREATE INDEX idx_pago_fotografo_fecha ON PagoFotografo(FechaPago);

-- Tabla Nomina
CREATE TABLE Nomina (
    Id SERIAL PRIMARY KEY,
    Fecha DATE NOT NULL,
    
    Total DECIMAL(10,2)
);
CREATE INDEX idx_nomina_fecha ON Nomina(Fecha);

-- Tabla Egreso
CREATE TABLE Egreso (
    Id SERIAL PRIMARY KEY,
    Descripcion TEXT,
    Monto DECIMAL(10,2),
    Fecha DATE
);
CREATE INDEX idx_egreso_fecha ON Egreso(Fecha);

-- Tabla Pago
CREATE TABLE Pago (
    Id SERIAL PRIMARY KEY,
    Monto DECIMAL(10,2),
    FechaPago DATE NOT NULL,
    Metodo VARCHAR(50)
);
CREATE INDEX idx_pago_fecha ON Pago(FechaPago);
