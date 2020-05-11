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
where P.idPlatillo = 2;

select * from Factura;

create procedure add_Factura
@idFactura int,  @serieFactura varchar(45), @direccionEntrega text, @hora time, @fecha date, @total numeric(8,2)
as
begin
insert into Factura values (@idFactura, @serieFactura, @direccionEntrega, @hora, @fecha, @total);
end;

select * from cliente;

select * from PedidoDomicilio;

select * from Chef_Platillo;

create procedure ChefPlatillo
@cantidad int, @chef numeric(13, 0), @platillo int
as
begin
insert into Chef_Platillo values (@cantidad, @chef, @platillo);
end;

exec show_Chef;


exec ChefPlatillo 12, 3034366110108, 2;
exec ChefPlatillo 45, 3034366110110, 2;

create procedure existePlatilloChef
@cui numeric(13, 0), @idPlatillo int
as
begin
select * from Chef_Platillo as CP
where CP.fk_platillo = @idPlatillo and CP.fk_chef = @cui;
end;


create procedure modificaCantidad
@cantidad int, @cui numeric(13, 0), @platillo int
as
begin
update Chef_Platillo set cantidad += @cantidad
where Chef_Platillo.fk_chef = @cui and Chef_Platillo.fk_platillo = @platillo;
end;

exec modificaCantidad 12, 3034366110108, 2;

select * from Pedido_Platillo;

create procedure add_PedidoPlatillo
@cantidad int, @subTotal numeric(8,2), @bebida int, @pedido int, @platillo int
as
begin
insert into Pedido_Platillo values(@cantidad, @subTotal, @bebida, @pedido, @platillo);
end;

select * from Factura;
select * from PedidoDomicilio;
select * from Pedido_Platillo;


create procedure show_Pedidos
as
begin
select PD.idPedido, PD.hora, PD.fecha, PD.direccionEntrega, C.nombreCliente, E.nombre as Empleado, E2.nombre as Repartidor, F.idFactura, F.total from PedidoDomicilio as PD
join cliente as C
on PD.fk_cliente = C.cuiCliente
join Empleado as E
on PD.fk_empleado = E.cuiEmpleado
join Empleado as E2
on PD.fk_repartidor = E2.cuiEmpleado
join Factura as F
on PD.fk_factura = F.idFactura;
end;

exec show_Pedidos;

create procedure show_Factura
as
begin
select F.idFactura, F.serieFactura, F.direccionEntrega, F.hora, F.fecha, C.nitCliente, C.nombreCliente, F.total from Factura as F
join PedidoDomicilio as PD
on PD.fk_factura = F.idFactura
join cliente as C
on PD.fk_cliente = C.cuiCliente;
end;

exec show_Factura;

exec show_clientes;
exec show_TipoEmpleado;
exec show_Empleado;
select * from Empleado;

create procedure aplicarBono
@cui numeric(13, 0)
as
begin
update Empleado set bono += 20
where Empleado.fk_idTipoEmpleado = 8 and Empleado.cuiEmpleado = @cui;
end;


--Reporte de Repartidor con mas entregas
select COUNT(E.cuiEmpleado) as Entregas, E.nombre, E.apellido, E.sueldo, E.bono from Empleado as E
join PedidoDomicilio as PD
on PD.fk_repartidor = E.cuiEmpleado
group by E.nombre, E.apellido,E.sueldo, E.bono
order by Entregas desc;


create procedure repartidorEntregas
as 
begin
select COUNT(E.cuiEmpleado) as Entregas, E.nombre, E.apellido, E.sueldo, E.bono from Empleado as E
join PedidoDomicilio as PD
on PD.fk_repartidor = E.cuiEmpleado
group by E.nombre, E.apellido,E.sueldo, E.bono
order by Entregas desc;
end;




--Rorte de Empleado con Mas ingresos de ordenes.
select COUNT(E.cuiEmpleado) as Ingresos, E.nombre, E.apellido, E.sueldo from Empleado as E
join PedidoDomicilio as PD
on PD.fk_empleado = E.cuiEmpleado
group by E.nombre, E.apellido, E.sueldo
order by Ingresos desc;


create procedure empleadoIngresos
as
begin
select COUNT(E.cuiEmpleado) as Ingresos, E.nombre, E.apellido, E.sueldo from Empleado as E
join PedidoDomicilio as PD
on PD.fk_empleado = E.cuiEmpleado
group by E.nombre, E.apellido, E.sueldo
order by Ingresos desc;
end;












--Reporte de mas platillos ordenados

--Versión 1
select SUM(PP.cantidad) as Ordenados, P.nombre, P.precio from platillo as P
join Pedido_Platillo as PP
on PP.fk_platillo = P.idPlatillo
group by P.nombre, P.precio
order by Ordenados desc;


create procedure platillosOrdenadosV1
as 
begin
select SUM(PP.cantidad) as Ordenados, P.nombre, P.precio from platillo as P
join Pedido_Platillo as PP
on PP.fk_platillo = P.idPlatillo
group by P.nombre, P.precio
order by Ordenados desc;
end;

--Version 2
select COUNT(P.idPlatillo) as Ordenados, P.nombre, P.precio from platillo as P
join Pedido_Platillo as PP
on PP.fk_platillo = P.idPlatillo
group by P.nombre, P.precio
order by Ordenados desc;


create procedure platillosOrdenadosV2
as
begin
select COUNT(P.idPlatillo) as Ordenados, P.nombre, P.precio from platillo as P
join Pedido_Platillo as PP
on PP.fk_platillo = P.idPlatillo
group by P.nombre, P.precio
order by Ordenados desc;
end;









--Reporte facturación por Mes
select COUNT(*) as TotalFacturas, SUM(F.total) as TotalFacturacion from Factura as F
where MONTH(F.fecha) = 5 and YEAR(F.fecha) = 2020;

--Reporte Facturación por día.
select COUNT(*) as TotalFacturas, SUM(F.total) as TotalFacturacion from Factura as F
where DAY(F.fecha) = 9 and MONTH(F.fecha) = 5 and YEAR(F.fecha) = 2020;

create procedure facturacionMes
@fecha date
as
begin 
select COUNT(*) as TotalFacturas, SUM(F.total) as TotalFacturacion from Factura as F
where MONTH(F.fecha) = MONTH(@fecha) and YEAR(F.fecha) = YEAR(@fecha);
end;

create procedure facturacionDia
@fecha date
as
begin 
select COUNT(*) as TotalFacturas, SUM(F.total) as TotalFacturacion from Factura as F
where DAY(F.fecha) = DAY(@fecha) and MONTH(F.fecha) = MONTH(@fecha) and YEAR(F.fecha) = YEAR(@fecha);
end;







--Reporte de Platillos Concinados por Chef
select SUM(CP.cantidad) as pedidos, E.cuiEmpleado, E.nombre, E.apellido from Empleado as E 
join Chef_Platillo as CP 
on CP.fk_chef = E.cuiEmpleado 
group by cuiEmpleado, E.nombre, E.apellido 
order by pedidos desc;


create procedure platillosChef 
as 
begin
select SUM(CP.cantidad) as pedidos, E.cuiEmpleado, E.nombre, E.apellido from Empleado as E 
join Chef_Platillo as CP 
on CP.fk_chef = E.cuiEmpleado 
group by cuiEmpleado, E.nombre, E.apellido 
order by pedidos desc;
end;











select * from Empleado as E
join Chef_Platillo as CP
on CP.fk_chef = E.cuiEmpleado
where E.cuiEmpleado = 3034366110110;

delete from Chef_Platillo;

delete from Pedido_Platillo;
delete from PedidoDomicilio;
delete from Factura;

select * from Factura;