-- Eliminar tablas si existen (orden inverso por dependencias)
DROP TABLE IF EXISTS Pago, Egreso, Nomina, PagoFotografo, AsignacionDeEquipo, EquipoFotografico,
Fotografo, Despacho, Fotografia, Reserva, PaqueteDeServicio, Evento, Bebe, Cliente, Persona CASCADE;


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
    FechaNacimiento DATE NOT NULL,
    Sexo VARCHAR(10)
);
CREATE INDEX idx_bebe_nombre ON Bebe(Nombre);

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
    Duración DATATIME
);
CREATE INDEX idx_paquete_precio ON PaqueteDeServicio(Precio);

-- Tabla Reserva
CREATE TABLE Reserva (
    Id SERIAL PRIMARY KEY,
    Fecha DATE NOT NULL,
    Estado VARCHAR(50),
    ClienteId INT NOT NULL,
    EventoId INT NOT NULL,
    PaqueteServicioId INT NOT NULL,
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id),
    FOREIGN KEY (EventoId) REFERENCES Evento(Id),
    FOREIGN KEY (PaqueteServicioId) REFERENCES PaqueteDeServicio(Id)
);
CREATE INDEX idx_reserva_fecha ON Reserva(Fecha);
CREATE INDEX idx_reserva_cliente ON Reserva(ClienteId);

-- Tabla Fotografia
CREATE TABLE Fotografia (
    Id SERIAL PRIMARY KEY,
    Formato VARCHAR(10),
    TamañoMB DOUBLE PRECISION,
    EventoId INT NOT NULL,
    FOREIGN KEY (EventoId) REFERENCES Evento(Id)
);
CREATE INDEX idx_foto_evento ON Fotografia(EventoId);

-- Tabla Despacho
CREATE TABLE Despacho (
    Id SERIAL PRIMARY KEY,
    FechaDespacho DATE,
    TipoEntrega VARCHAR(50),
    Estado VARCHAR(50),
    FotografiaId INT NOT NULL,
    ClienteId INT NOT NULL,
    FOREIGN KEY (FotografiaId) REFERENCES Fotografia(Id),
    FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);
CREATE INDEX idx_despacho_fecha ON Despacho(FechaDespacho);

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
    FotografoId INT NOT NULL,
    EquipoId INT NOT NULL,
    Estado VARCHAR(100),
    FOREIGN KEY (FotografoId) REFERENCES Fotografo(Id),
    FOREIGN KEY (EquipoId) REFERENCES EquipoFotografico(Id)
);
CREATE INDEX idx_asignacion_fecha ON AsignacionDeEquipo(Fecha);

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
