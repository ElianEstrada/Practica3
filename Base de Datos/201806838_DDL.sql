create database Practica3;

create table ingrediente(
	idIngrediente int identity(1,1) primary key not null, 
	nombre varchar(45) not null
);

create table platillo (
	idPlatillo int identity(1,1) primary key not null,
	nombre varchar(45) not null, 
	precio decimal(5, 2) not null
);


create table ingrediente_platillo (
	idIngredientePlatillo int identity(1,1) primary key not null,
	fk_idPlatillo int not null, 
	fk_idIngrediente int not null
);

alter table ingrediente_platillo add constraint fk_platillo foreign key (fk_idPlatillo) 
references platillo (idPlatillo);
alter table ingrediente_platillo add constraint fk_ingrediente foreign key (fk_idIngrediente)
references ingrediente(idIngrediente);


create table tipoEmpleado(
	idTipoEmpleado int identity(1,1) primary key not null, 
	nombre varchar(45) not null
);


create table Empleado(
	cuiEmpleado numeric(13, 0) primary key not null,
	nombre varchar(45) not null,
	apellido varchar(45) not null, 
	telefono numeric(8,0),
	direccion text,
	sueldo numeric(7, 2) not null,
	bono numeric(2, 0),
	fk_jefe numeric(13,0),
	fk_idTipoEmpleado int not null
);

alter table Empleado add constraint fk_Jefe foreign key (fk_jefe) references Empleado(cuiEmpleado);

alter table Empleado add constraint fk_Tipo foreign key (fk_idTipoEmpleado)
references tipoEmpleado (idTipoEmpleado);

--Queda pendiente :v

create table Chef_Platillo(
	idChefPlatillo int identity(1,1) primary key not null
);


--Continuamos con las demas tablas

create table cliente (
	cuiCliente numeric(13, 0) primary key not null,
	nombreCliente varchar(45) not null,
	apellidoCliente varchar(45) not null,
	telefonoDomiciliar numeric(8, 0),
	telefonoCelular numeric(8,0),
	nitCliente varchar(45) not null
);