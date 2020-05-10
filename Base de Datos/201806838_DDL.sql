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
	idChefPlatillo int identity(1,1) primary key not null,
	cantidad int,
	fk_chef numeric(13,0) not null,
	fk_platillo int not null
);

alter table Chef_Platillo add constraint FK_ChefPlatillo foreign key (fk_chef) references Empleado(cuiEmpleado);
alter table Chef_Platillo add constraint FK_PlatilloChef foreign key (fk_platillo) references Platillo(idPlatillo);

--Continuamos con las demas tablas

create table cliente (
	cuiCliente numeric(13, 0) primary key not null,
	nombreCliente varchar(45) not null,
	apellidoCliente varchar(45) not null,
	telefonoDomiciliar numeric(8, 0),
	telefonoCelular numeric(8,0),
	nitCliente varchar(45) not null
);

create table Bebida(
	idBebida int identity(1,1) primary key not null,
	nombre varchar(45) not null
);

create table Factura(
	idFactura int primary key not null,
	serieFactura varchar(45) not null,
	direccionEntrega text,
	hora time not null,
	fecha date not null, 
	total numeric(8, 2) not null
);



create table PedidoDomicilio (
	idPedido int primary key not null,
	hora time not null,
	fecha date not null,
	direccionEntrega text not null,
	fk_cliente numeric(13, 0) not null,
	fk_empleado numeric(13 ,0) not null,
	fk_repartidor numeric(13 ,0) not null,
	fk_factura int not null
);

alter table PedidoDomicilio add constraint fk_ClientePedido foreign key (fk_cliente) references Cliente(cuiCliente);
alter table PedidoDomicilio add constraint fk_EmpleadoPedido foreign key (fk_empleado) references Empleado(cuiEmpleado);
alter table PedidoDomicilio add constraint fk_EmpleadoRepartidor foreign key (fk_repartidor) references Empleado(cuiEmpleado);
alter table PedidoDomicilio add constraint fk_factura foreign key (fk_factura) references Factura(idFactura);



create table Pedido_Platillo (
	idPedidoPlatillo int identity(1,1) primary key not null,
	cantidad int not null,
	subTotal numeric(8,2) not null,
	fk_bebida int not null,
	fk_pedido int not null,
	fk_platillo int not null
);

alter table Pedido_Platillo add constraint fk_Bebida foreign key (fk_bebida) references Bebida(idBebida);
alter table Pedido_Platillo add constraint fk_pedido foreign key (fk_pedido) references PedidoDomicilio(idPedido);
alter table Pedido_Platillo add constraint fk_platilloPedido foreign key (fk_platillo) references Platillo (idPlatillo);
