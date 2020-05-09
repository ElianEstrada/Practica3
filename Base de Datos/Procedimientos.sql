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


exec add_Empleado	3034366110108	,'Elian Sa�l',	'Estrada Urbina',	35384675	,'Direccion1',	12000, null,	null,	1;
exec add_Empleado	3034366110109	, 'Madelyn Maricarmen',	'Mendoza Lemus',	35384676	,'Direccion2',	8000, null,	3034366110108,	2;
exec add_Empleado	3034366110110	, 'Alex Fenrando',	'Mendez L�pez',	35384677	,'Direccion3',	6500, null,	3034366110108	,3;
exec add_Empleado	3034366110111	, 'Allan Gabriel',	'Estrada Urbina',	35384678	,'Direccion4',	6500, null,	3034366110108,	3;
exec add_Empleado	3034366110112	, 'Norman Enrique',	'Estrada Urbina',	35384679	,'Direccion5',	4500,null,	3034366110113,	5;
exec add_Empleado	3034366110113	, 'Norma Lisbeth',	'Urbina Marroqu�n',	35384680	,'Direccion6',	5000,null,	3034366110108,	4;
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