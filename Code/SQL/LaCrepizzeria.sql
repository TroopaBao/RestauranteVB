create database LaCrepizzeria
drop database LaCrepizzeria

use LaCrepizzeria 

create table Empleados
(
	idempleado int primary key, 
	nombrempleado varchar(40) not null, 
	cargoarea varchar(20) not null, 
	pagocaja decimal(5,2), 
	contraseña varchar(30) not null, 
	edoempleado int
)

create table Compras
(
	idproductocom int primary key,  
	totalcompra decimal(5,2), 
	fechacompra date, 
	idempleado int foreign key references Empleados
)

create table Ventas 
(
	idventa int primary key,  
	fechaventa date, 
	folio int, 
	nombremesa varchar(30) not null, 
	total decimal(5,2)
)


create table Ingredientes
(
	idingrediente int primary key, 
	nombreingrediente varchar(40) not null, 
	tipoingrediente varchar(15) not null, /*Unidad, ml, gr, kg, lts. */ 
	existencias int, 
	cantidadunidad int, 
	precioingrediente decimal(5,2),
	edoingrediente int /* estado de ingrediente */
)


create table ProductosProcesados
(
	idproductoproc int primary key, 
	nombreproductoproc varchar(40) not null, 
	precioproductoproc decimal (5,2), 
	edoproductoproc int 
)

create table ProductosHechos
(
	idproductohech int primary key, 
	nombreproductohech varchar(40) not null, 
	precioproductohech decimal(5,2), 
	edoproductohech int, 
	existencias int
)

create table ComprasIngredientes
(
	idproductocom int foreign key references Compras not null, 
	idingrediente int foreign key references Ingredientes not null,
	cantidadcompra int
)

create table VentasProductosProcesados
(
	idventa int foreign key references Ventas not null, 
	idproductoproc int foreign key references ProductosProcesados not null, 
	cantidadven int, 
	comentarios varchar(100)
)

create table IngredientesProductosProcesados
(
	idingrediente int foreign key references Ingredientes not null, 
	idproductoproc int foreign key references ProductosProcesados not null,
	cantidadingrediente int, 
	noingrediente int 
)

create table ComprasProductosHechos
(
	idproductocom int foreign key references Compras not null, 
	idproductohech int foreign key references ProductosHechos not null, 
	cantidadcompra int
)

create table ProductosHechosVentas
(
	idproductohech int foreign key references ProductosHechos not null, 
	idventa int foreign key references Ventas not null, 
	cantidadven int
)

insert into Ingredientes values (1, 'Nutella', 'ml', 500, 250, 35.00, 1);
insert into Ingredientes values (2, 'Kinder Delice', 'Unidad', 3, 1, 12.00, 1);
insert into Ingredientes values (3, 'Lechera', 'ml', 700, 200, 28.00, 1);
insert into Ingredientes values (4, 'Fresas Naturales', 'gr', 500, 1000, 45.00, 1);

insert into ProductosProcesados values (1, 'Crepa Kinder Delice', 45.00, 1);
insert into ProductosProcesados values (2, 'Crepa Lechera c/fresas', 38.00, 1);

insert into IngredientesProductosProcesados values (1, 1, 100, 1);
insert into IngredientesProductosProcesados values (2, 1, 1, 2);
insert into IngredientesProductosProcesados values (3, 2, 120);
insert into IngredientesProductosProcesados values (4, 2, 80);

select * from IngredientesProductosProcesados

select existencias from Ingredientes inner join IngredientesProductosProcesados 
						ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
						inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
						where ProductosProcesados.idproductoproc=1 and noingrediente=1;

update Ingredientes set existencias=0
from Ingredientes
						inner join IngredientesProductosProcesados 
						ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
						inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
						where ProductosProcesados.idproductoproc=1 and noingrediente=1;

select existencias, IngredientesProductosProcesados.cantidadingrediente, nombreingrediente, IngredientesProductosProcesados.noingrediente from Ingredientes inner join IngredientesProductosProcesados 
						ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
						inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
						where ProductosProcesados.idproductoproc=1;