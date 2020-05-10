use Practica3;

select * from Empleado;

select * from tipoEmpleado;

insert into tipoEmpleado values('Chef de Cuisine');
insert into tipoEmpleado values('Asistente de Cuisine');
insert into tipoEmpleado values('Chef De Partie');
insert into tipoEmpleado values('Primer Cocinero');
insert into tipoEmpleado values('Segudno Cocinero');
insert into tipoEmpleado values('Tercer Cocinero');
insert into tipoEmpleado values('Asistente Chef');
insert into tipoEmpleado values('Repartidor');
insert into tipoEmpleado values('Tomador de Pedidos');

create procedure add_Empleado
@cui numeric(13, 0), @nombre varchar(45), @apellido varchar(45), @telefono numeric(8,0), @direccion text, @sueldo numeric(7,2), @bono int, @jefe numeric(13, 0), @tipo int
as 
begin
insert into Empleado values(@cui, @nombre, @apellido, @telefono, @direccion, @sueldo, @bono, @jefe, @tipo);
end;


exec add_Empleado	3034366110108	,'Elian Saúl',	'Estrada Urbina',	35384675	,'Direccion1',	12000, null,	null,	1;
exec add_Empleado	3034366110109	, 'Madelyn Maricarmen',	'Mendoza Lemus',	35384676	,'Direccion2',	8000, null,	3034366110108,	2;
exec add_Empleado	3034366110110	, 'Alex Fenrando',	'Mendez López',	35384677	,'Direccion3',	6500, null,	3034366110108	,3;
exec add_Empleado	3034366110111	, 'Allan Gabriel',	'Estrada Urbina',	35384678	,'Direccion4',	6500, null,	3034366110108,	3;
exec add_Empleado	3034366110112	, 'Norman Enrique',	'Estrada Urbina',	35384679	,'Direccion5',	4500,null,	3034366110113,	5;
exec add_Empleado	3034366110113	, 'Norma Lisbeth',	'Urbina Marroquín',	35384680	,'Direccion6',	5000,null,	3034366110108,	4;
exec add_Empleado	3034366110114	, 'Luis Enrique',	'Estrada Galindo',	35384681	,'Direccion7',	4500,null,	3034366110113,	6;
exec add_Empleado	3034366110115	, 'Marco Antonio',	'Solis Gallardo',	35384682	,'Direccion8',	3500,null,	3034366110108,	7;

delete from Empleado 
where cuiEmpleado = 3034366110115;

select * from Empleado;

create procedure show_TipoEmpleado
as
begin
select * from tipoEmpleado;
end;

update Empleado set bono = null;


create procedure show_jefes
as 
begin
select * from Empleado as E
join tipoEmpleado as TE
on E.fk_idTipoEmpleado = TE.idTipoEmpleado
where TE.idTipoEmpleado = 1
or TE.idTipoEmpleado = 4;
end;

exec show_jefes;


update tipoEmpleado set nombre = 'Segundo Cocinero' 
where tipoEmpleado.idTipoEmpleado = 5;

create procedure show_Empleado
as
begin
select E.cuiEmpleado, E.nombre, E.apellido, E.telefono, E.direccion, E.sueldo, EM.nombre as jefe, TE.nombre as tipo from Empleado as E
left join Empleado as EM
on E.fk_jefe = EM.cuiEmpleado
join tipoEmpleado TE
on E.fk_idTipoEmpleado = TE.idTipoEmpleado;
end;

exec show_Empleado;

create procedure existeCuisine
as
begin 
select * from Empleado as E
where E.fk_idTipoEmpleado = 1;
end;

delete from Empleado
where cuiEmpleado between 1 and 2;

select * from Platillo;


insert into platillo values('Arroz con Pollo', 17.5);
insert into platillo values('Tacos', 10);
insert into platillo values('Tofu', 7.5);
insert into platillo values('Pollo a la Parmesana', 22.5);
insert into platillo values('Pescado con papas', 20);
insert into platillo values('Lasaña', 25);
insert into platillo values('Croissant', 12);
insert into platillo values('Arepas', 15);
insert into platillo values('Pastel de Nata', 35);
insert into platillo values('Donas', 5.5);


create procedure show_platillos
as
begin
select * from platillo;
end;

select * from cliente;

create procedure show_clientes
as
begin
select * from cliente;
end;

exec show_clientes;

create procedure add_cliente
@cui numeric(13,0), @nombre varchar(45), @apellido varchar(45), @celular numeric(8,0), @nit varchar(45)
as
begin
insert into cliente values(@cui, @nombre, @apellido, null, @celular, @nit);
end;


exec add_cliente 3034366110108, 'Elian', 'Estrada', 35384675, '1234567';

create procedure existeCliente
@cuiCliente numeric(13,0)
as
begin
select * from cliente 
where cuiCliente = @cuiCliente;
end;

exec existeCliente 3034366110108;


select * from PedidoDomicilio;

create procedure add_PedidoDomicilio
@idPedido int, @hora time, @fecha date, @direccionEntrega text, @cliente numeric(13, 0), @empleado numeric(13,0), @repartidor numeric(13,0), @factura int
as
begin
insert into PedidoDomicilio values (@idPedido, @hora, @fecha, @direccionEntrega, @cliente, @empleado, @repartidor, @factura);
end;

select * from tipoEmpleado;

create procedure show_Chef
as
begin
select * from Empleado as E
join tipoEmpleado as TE
on E.fk_idTipoEmpleado = TE.idTipoEmpleado
where TE.idTipoEmpleado between 3 and 6
or TE.idTipoEmpleado = 1;
end;

exec show_Chef;

exec show_platillos;

create procedure show_bebidas
as
begin
select * from Bebida;
end;

exec show_bebidas;

insert into Bebida values('Coca-Cola');
insert into Bebida values('Pepsi');
insert into Bebida values('Seven Up');
insert into Bebida values('Mirinda');
insert into Bebida values('Agua Mineral');
insert into Bebida values('Agua Pura');
insert into Bebida values('Té Frio de Frambuesa');
insert into Bebida values('Té Frio de Durazno');
insert into Bebida values('Té Frio de Limón');
insert into Bebida values('Fresco de Naranja');
insert into Bebida values('Fresco de Melón');

exec show_platillos;
exec show_bebidas;
exec show_jefes;
exec show_TipoEmpleado;
exec show_Empleado;
exec show_clientes;
exec show_Chef;

create procedure searchPlatillo
@idPlatillo int
as
begin
select * from platillo as P
where P.idPlatillo = @idPlatillo;
end;


select * from platillo as P
where P.idPlatillo = 1;