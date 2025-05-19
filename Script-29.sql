-- Eliminar tablas si existen (orden inverso por dependencias)
DROP TABLE IF EXISTS Pago, Egreso, Nomina, PagoFotografo, AsignacionDeEquipo, EquipoFotografico,
Fotografo, Despacho, Fotografia, Reserva, PaqueteDeServicio, Evento, mensajero, Bebe, Cliente, Persona CASCADE;



create table cliente
(
    id        serial
        primary key,
    nombre    varchar(100) not null,
    apellido  varchar(100) not null,
    telefono  varchar(50)  not null,
    email     varchar(100),
    direccion varchar(100) not null
);


create index idx_cliente_telefono
    on cliente (telefono);

create table bebe
(
    id              serial
        primary key,
    nombre          varchar(100) not null,
    fechanacimiento date         not null,
    sexo            varchar(10)
);


create index idx_bebe_nombre
    on bebe (nombre);

create table reserva
(
    id                 serial
        primary key,
    fecha_evento       date not null,
    fecha_reserva      date not null,
    estado             varchar(50),
    observaciones      text,
    cliente_id         integer
        constraint fk_reserva_cliente
            references cliente,
    evento_id          integer,
    paqueteservicio_id integer
);


create table evento
(
    id         serial
        primary key,
    tipo       varchar(100),
    fecha      date not null,
    ubicacion  varchar(255),
    reserva_id integer
        constraint fk_evento_reserva
            references reserva,
    bebe_id    integer
        constraint fk_evento_bebe
            references bebe
);


create index idx_evento_fecha
    on evento (fecha);

create index idx_evento_tipo
    on evento (tipo);

create table paquetedeservicio
(
    id          serial
        primary key,
    nombre      varchar(100)   not null,
    precio      numeric(10, 2) not null,
    descripcion text,
    duracion    interval       not null,
    evento_id   integer
        constraint fk_paquete_evento
            references evento
);


create index idx_paquete_precio
    on paquetedeservicio (precio);

create index idx_reserva_fecha
    on reserva (fecha_evento);

create index idx_reserva_cliente
    on reserva (cliente_id);

create table productos
(
    id                 serial
        primary key,
    nombre             varchar(100)   not null,
    precio             numeric(10, 2) not null,
    descripcion        text,
    stock              integer        not null,
    paquetesercicio_id integer
        constraint fk_productos_paquetedeservicio
            references paquetedeservicio
);


create table nomina
(
    id    serial
        primary key,
    fecha date not null,
    total numeric(10, 2)
);


create table fotografo
(
    id               serial
        primary key,
    nombre           varchar(100),
    especialidad     varchar(100),
    nomina_id        integer
        constraint fk_fotografo_nomina
            references nomina,
    pagofotografo_id integer,
    evento_id        integer
        constraint fk_fotografo_evento
            references evento,
    apellido         varchar(100),
    telefono         varchar(10),
    email            varchar(100)
);


create index idx_fotografo_especialidad
    on fotografo (especialidad);

create index idx_nomina_fecha
    on nomina (fecha);

create table asignacion
(
    id               serial
        primary key,
    fotografo_id     integer not null
        constraint fk_asignacion_fotografo
            references fotografo,
    evento_id        integer not null
        constraint fk_asignacion_evento
            references evento,
    fecha_asignacion date    not null
);


create table equipofotografico
(
    id     serial
        primary key,
    modelo varchar(50),
    estado varchar(50),
    tipo   varchar(50),
    marca  varchar(100)
);


create index idx_equipo_tipo
    on equipofotografico (tipo);

create table asignaciondeequipo
(
    id               serial
        primary key,
    fecha_asignacion date    not null,
    fecha_entrega    date,
    fotografoid      integer not null
        constraint fk_asignacion_equipo_fotografo
            references fotografo,
    equipoid         integer not null
        constraint fk_asignacion_equipo_equipo
            references equipofotografico,
    estado           varchar(100)
);



create index idx_asignacion_fecha
    on asignaciondeequipo (fecha_asignacion);

create table egreso
(
    id          serial
        primary key,
    descripcion text,
    monto       numeric(10, 2),
    fecha       date,
    metodo_pago varchar(100)
);


create index idx_egreso_fecha
    on egreso (fecha);

create table ingreso
(
    id              serial
        primary key,
    descripcion     varchar(200),
    monto           numeric(10, 2),
    fecha           date,
    concepto        varchar(50),
    cliente_id      integer
        constraint fk_ingreso_cliente
            references cliente,
    referencia_tipo varchar(50)
);


create index idx_ingreso_fecha
    on ingreso (fecha);

create table mensajero
(
    id        serial
        primary key,
    nombre    varchar(100) not null,
    telefono  varchar(20),
    email     varchar(100),
    apellido  varchar(50),
    direccion varchar(50)
);



create table despacho
(
    id                  serial
        primary key,
    fechadespacho       date,
    estado              varchar(50),
    paquete_servicio_id integer
        constraint fk_despacho_paquete
            references paquetedeservicio,
    mensajero_id        integer
        constraint fk_mensajero_despacho
            references mensajero,
    numero_paquetes     integer
);



create index idx_despacho_fecha
    on despacho (fechadespacho);

create index idx_mensajero_nombre
    on mensajero (nombre);



