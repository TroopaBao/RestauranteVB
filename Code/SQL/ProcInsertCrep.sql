create procedure insEmpleados

	@nombrempleado varchar(40), 
	@cargoarea varchar(20),
	@pagocaja decimal(5,2), 
	@contraseña varchar(30),  
	@bandera int output 

	as

	declare @idempleado int 

	if(select COUNT(*) from Empleados)=0
		set @idempleado=1;
	else
		set @idempleado=(select MAX(idempleado) from Empleados)+1;

	if (select nombrempleado from Empleados where nombrempleado=@nombrempleado)=@nombrempleado
		begin
			if (select edoempleado from Empleados where nombrempleado=@nombrempleado)=1
				begin
					print 'Ese nombre de empleado ya existe'
					set @bandera=1;
				end
			else
				begin
					print 'Ese nombre de empleado ya existe, pero está dado de baja temporal'
					set @bandera=2;
				end
		end
	else
		if @nombrempleado=''
			begin
				print 'El campo del nombre de empleado está vacío'
				set @bandera=3;
			end
		else
			if @cargoarea=''
				begin
					print 'El campo de cargo de área está vacío'
					set @bandera=4;
				end
			else
				if ((@cargoarea='Gerente')or(@cargoarea='Caja')or(@cargoarea='Mesero(a)')or(@cargoarea='Cocina(Crepas)')or(@cargoarea='Cocina(Horno)')or(@cargoarea='Bebidas'))
					begin
						if(@pagocaja<0)
							begin
								print 'El campo de pago de caja debe ser mayor o igual a 0'
								set @bandera=6;
							end
						else
							if(@contraseña='')
								begin
									print 'El campo de contraseña no puede estar vacío'
									set @bandera=7;
								end
							else
								begin
									begin tran
										insert into Empleados values (@idempleado, @nombrempleado, @cargoarea, @pagocaja, @contraseña, 1);
									commit tran
								end
					end
				else
					begin
						print 'Cargo de Área; Solo 6 opciones: Gerente, Caja, Mesero(a), Cocina(Crepas), Cocina(Horno), Bebidas'
						set @bandera=5;
					end
/* --------------------------------------------------------------------------------------------------------------------------------------------------------- */

create procedure insCompras

	@totalcompra decimal(5,2), 
	@fechacompra date,
	@idempleado int, 
	@bandera int output 

	as 

	declare @idproductocom int 

	if (select COUNT(*) from Compras)=0
		set @idproductocom=1;
	else
		set @idproductocom=(select MAX(idproductocom) from Compras)+1;

	if(@totalcompra<=0)
		begin
			print 'El costo de producto debe ser mayor a 0'
			set @bandera=1;
		end
	else
		if(@fechacompra='')
			begin
				print 'La fecha de la compra no debe estar vacía'
				set @bandera=2;
			end
		else
			if(select idempleado from Empleados where idempleado=@idempleado)=@idempleado
				begin
					begin tran 
						insert into Compras values (@idproductocom, @totalcompra, @fechacompra, @idempleado);
					commit tran
				end
			else
				begin
					print 'Ese id de empleado no existe'
					set @bandera=3;
				end
	
/* -------------------------------------------------------------------------------------------------------------- -------------- */


create procedure insIngredientes

	@nombreingrediente varchar(40), 
	@tipoingrediente varchar(15), 
	@existencias int, 
	@cantidadunidad int, 
	@precioingrediente decimal (5,2),
	@bandera int output

	as 

	declare @idingrediente int

	if(select COUNT(*) from Ingredientes)=0
		set @idingrediente=1; 
	else
		set @idingrediente=(select MAX(idingrediente) from Ingredientes)+1;

	if(select nombreingrediente from Ingredientes where nombreingrediente=@nombreingrediente)=@nombreingrediente
		begin
			if(select edoingrediente from Ingredientes where nombreingrediente=@nombreingrediente)=1
				begin
					print 'Ya existe ese ingrediente'
					set @bandera=1;
				end
			else
				begin
					print 'Ya existe ese ingrediente, pero está dado de baja temporal'
					set @bandera=2;
				end
		end
	else
		if (@nombreingrediente='')
			begin
				print 'El campo Nombre del Ingrediente está vacío'
				set @bandera=3;
			end
		else
			if(@tipoingrediente='')
				begin
					print 'El tipo de ingrediente no debe estar vacío'
					set @bandera=4;  
				end
			else
				if ((@tipoingrediente='Kg')or(@tipoingrediente='gr')or(@tipoingrediente='ml')or(@tipoingrediente='Lts') or @tipoingrediente='Unidad')
					begin
						if(@existencias<0)
							begin
								print 'Existencias mayores o iguales a 0'
								set @bandera=6;
							end
						else
							if(@cantidadunidad<=0)
								begin
									print 'Cantidad de unidad, debe ser mayor a 0'
									set @bandera=7;
								end
							else
								begin
									if (@precioingrediente<=0)
										begin
											print 'El precio del ingrediente no debe ser menor o igual a 0'
											set @bandera=8;
										end
									else
										begin
											begin tran
												insert into Ingredientes values (@idingrediente, @nombreingrediente, @tipoingrediente, @existencias, @cantidadunidad, @precioingrediente, 1);
											commit tran
										end
								end
					end
				else
					begin
						print 'Tipo de Ingrediente; Solo 5 opciones: Kg, gr, ml, Lts o Unidad'
						set @bandera=5;
					end

/* ---------------------------------------------------------------------------------------------------------------------------------------------------------------- */


create procedure insProductosHechos

	@nombreproductohech varchar(40), 
	@precioproductohech decimal (5,2), 
	@existencias int, 
	@bandera int output

	as

	declare @idproductohech int

	if(select COUNT(*) from ProductosHechos)=0
		set @idproductohech=1;
	else
		set @idproductohech=(select MAX(idproductohech) from ProductosHechos)+1;

	if(select nombreproductohech from ProductosHechos where @nombreproductohech=nombreproductohech)=@nombreproductohech
		begin
			if(select edoproductohech from ProductosHechos where @nombreproductohech=nombreproductohech)=1
				begin
					print 'Ese nombre de producto hecho ya existe'
					set @bandera=1;
				end
			else
				begin
					print 'Ese nombre de producto hecho ya existe, pero está dado de baja temporal'
					set @bandera=2;
				end
		end
	else
		if(@nombreproductohech='')
			begin
				print 'Nombre de producto hecho no debe estar vacío'
				set @bandera=3;
			end
		else
				if(@precioproductohech<=0)
					begin
						print 'El precio del producto hecho debe ser mayor a 0'
						set @bandera=4;
					end
				else
						if(@existencias<0)
							begin
								print 'El campo de existencias debe ser mayor o igual a 0'
								set @bandera=5;
							end
						else
							begin
								begin tran
									insert into ProductosHechos values (@idproductohech, @nombreproductohech, @precioproductohech, 1, @existencias);
								commit tran
							end

/* -------------------------------------------------------------------------------------------------------------------------------------------------------------------- */

create procedure insProductosProcesados 

	@nombreproductoproc varchar(40), 
	@precioproductoproc decimal (5,2), 
	@bandera int output

	as

	declare @idproductoproc int

	if(select COUNT(*) from ProductosProcesados)=0
		set @idproductoproc=1;
	else
		set @idproductoproc=(select MAX(idproductoproc) from ProductosProcesados)+1;

	if(select nombreproductoproc from ProductosProcesados where nombreproductoproc=@nombreproductoproc)=@nombreproductoproc
		begin
			if (select edoproductoproc from ProductosProcesados where nombreproductoproc=@nombreproductoproc)=1
				begin
					print 'El campo nombre de producto procesado ya existe'
					set @bandera=1;
				end
			else
				begin
					print 'El campo nombre de producto procesado ya existe, pero esta dado de baja temporal'
					set @bandera=2;
				end
		end
	else
		if(@nombreproductoproc='')
			begin
				print 'El campo nombre de producto procesado está vacío'
				set @bandera=3;
			end
		else
				if(@precioproductoproc<=0)
					begin
						print 'El precio del producto procesado debe ser mayor a 0'
						set @bandera=4;
					end
				else
					begin
						begin tran
							insert into ProductosProcesados values (@idproductoproc, @nombreproductoproc, @precioproductoproc, 1);
						commit tran
					end


/* ------------------------------------------------------------------------------------------------------------------------------------------------------------------ */



create procedure insVentas

	@fechaventa date, 
	@folio int, 
	@nombremesa varchar (30), 
	@total decimal (5,2),
	@bandera int output

	as 

	declare @idventa int

	if(select COUNT(*) from Ventas)=0
		set @idventa=1;
	else
		set @idventa=(select MAX(idventa) from Ventas)+1;

	if (@fechaventa='')
		begin
			print 'El campo de Fecha de venta no debe estar vacío'
			set @bandera=1;
		end
	else
		if (@folio<1)
			begin
				print 'Valores de Folio mayores a 0'
				set @bandera=2;
			end
		else
			if(@nombremesa='')
				begin
					print 'El nombre de mesa no debe estar vacío'
					set @bandera=3;
				end
			else
				if(@total<=0)
					begin
						print 'Total debe ser mayor a 0'
						set @bandera=4;
					end
				else
					begin
						begin tran
							insert into Ventas values (@idventa, @fechaventa, @folio, @nombremesa, @total);
						commit tran
					end
				

/* ------------------------------------------------------------------------------------------------------------------------------------------------- */

create procedure insComprasProductosHechos

	@bandera int output, 
	@idproductohech int, 
	@idproductocom int, 
	@cantidadcompra int

	as 

	declare @banhec int
	declare @bancom int

	if (select COUNT(idproductocom) from Compras)=0
		begin
			print 'No existe ninguna id en la tabla Compras'
			set @bandera=1;
		end
	else
		if (select idproductocom from Compras where @idproductocom=idproductocom)=@idproductocom
			begin
				set @bancom=1;
			end
		else
			begin
				print 'No existe ese id de compra'
				set @bandera=2;
			end


	if (select COUNT(idproductohech) from ProductosHechos)=0
		begin
			print 'No existe ninguna id en la tabla Productos Hechos'
			set @bandera=3;
		end
	else
		if (select idproductohech from ProductosHechos where @idproductohech=idproductohech)=@idproductohech
			begin 
				set @banhec=1;
			end
		else
			begin 
				print 'No existe ese id del Producto Hecho'
				set @bandera=4;
			end

	if(@banhec=1 and @bancom=1)
		begin
			if (select idproductocom from ComprasProductosHechos where @idproductocom=idproductocom and @idproductohech=idproductohech)=@idproductocom and
			 (select idproductohech from ComprasProductosHechos where @idproductocom=idproductocom and @idproductohech=idproductohech)=@idproductohech
				begin 
					print 'Esa combinación ya existe'
					set @bandera=5;
				end
			else
				if(@cantidadcompra<=0)
					begin
						print 'Cantidad de compra debe ser mayor a 0'
						set @bandera=6;
					end
				else	
					begin
						begin tran
							insert into ComprasProductosHechos values (@idproductocom, @idproductohech, @cantidadcompra);
							set @cantidadcompra=(select existencias from ProductosHechos where idproductohech=@idproductohech)+@cantidadcompra;
							update ProductosHechos set existencias=@cantidadcompra where idproductohech=@idproductohech;
							update Compras set totalcompra=((select precioproductohech from ProductosHechos)*@cantidadcompra)+totalcompra 
						    from Compras inner join ComprasProductosHechos on Compras.idproductocom=ComprasProductosHechos.idproductocom 
							inner join ProductosHechos on ProductosHechos.idproductohech=ComprasProductosHechos.idproductohech 
							where Compras.idproductocom=@idproductocom and ProductosHechos.idproductohech=@idproductohech;
						commit tran
					end
		end

/* .....................................................................................................................................................  */

create procedure insProductosHechosVentas

	@bandera int output, 
	@idproductohech int, 
	@idventa int, 
	@cantidadven int

	as 

	declare @banhec int
	declare @banven int
	
	if (select COUNT(idventa) from Ventas)=0
		begin
			print 'No existe ninguna id en la tabla Ventas'
			set @bandera=1;
		end
	else
		if (select idventa from Ventas where @idventa=idventa)=@idventa
			begin
				set @banven=1;
			end
		else
			begin
				print 'No existe ese id de venta'
				set @bandera=2;
			end

	
	if (select COUNT(idproductohech) from ProductosHechos)=0
		begin
			print 'No existe ninguna id en la tabla Productos Hechos'
			set @bandera=3;
		end
	else
		if (select idproductohech from ProductosHechos where @idproductohech=idproductohech)=@idproductohech
			begin 
				set @banhec=1;
			end
		else
			begin 
				print 'No existe ese id del Producto Hecho'
				set @bandera=4;
			end

	if(@banhec=1 and @banven=1)
		begin
			if (select idventa from ProductosHechosVentas where @idventa=idventa and @idproductohech=idproductohech)=@idventa and
			 (select idproductohech from ProductosHechosVentas where @idventa=idventa and @idproductohech=idproductohech)=@idproductohech
				begin 
					print 'Esa combinación ya existe'
					set @bandera=5;
				end
			else
				if(@cantidadven<=0)
					begin
						print 'Cantidad de venta debe ser mayor a 0'
						set @bandera=6;
					end
				else
					if(select existencias from ProductosHechos where idproductohech=@idproductohech)<@cantidadven
						begin
							print 'No puedes vender más productos de los que tienes en existencias'
							set @bandera=7;
						end
					else
						begin
							begin tran
								insert into ProductosHechosVentas values ( @idproductohech,@idventa, @cantidadven);
								update Ventas set total=((select precioproductohech from ProductosHechos where idproductohech=@idproductohech)*@cantidadven)+total where idventa=@idventa;
								update ProductosHechos set existencias=existencias-@cantidadven where idproductohech=@idproductohech;
							commit tran
						end
		end

/* .....................................................................................................................................................  */

create procedure insComprasIngredientes

	@bandera int output, 
	@idingrediente int, 
	@idproductocom int, 
	@cantidadcompra int

	as 

	declare @baning int 
	declare @bancom int
	declare @precio int
	declare @cantidadunidad int

	if (select COUNT(idproductocom) from Compras)=0
		begin
			print 'No existe ninguna id en la tabla Compras'
			set @bandera=1;
		end
	else
		if (select idproductocom from Compras where @idproductocom=idproductocom)=@idproductocom
			begin
				set @bancom=1;
			end
		else
			begin
				print 'No existe ese id de compra'
				set @bandera=2;
			end


		if (select COUNT(idingrediente) from Ingredientes)=0
			begin
				print 'No existe ninguna id en la tabla Ingredientes'
				set @bandera=3;
			end
		else
			if (select idingrediente from Ingredientes where @idingrediente=idingrediente)=@idingrediente
				begin 
					set @baning=1;
				end
			else
				begin 
					print 'No existe ese id de Ingredientes'
					set @bandera=4;
				end

	if(@baning=1 and @bancom=1)
		begin
			if (select idproductocom from ComprasIngredientes where @idproductocom=idproductocom and @idingrediente=idingrediente)=@idproductocom and
			 (select idingrediente from ComprasIngredientes where @idproductocom=idproductocom and @idingrediente=idingrediente)=@idingrediente
				begin 
					print 'Esa combinación ya existe'
					set @bandera=5;
				end
			else
				if(@cantidadcompra<=0)
					begin
						print 'Cantidad de compra debe ser mayor a 0'
						set @bandera=6;
					end
				else	
					begin
						begin tran
							insert into ComprasIngredientes values (@idproductocom, @idingrediente, @cantidadcompra);
							set @precio=(select precioingrediente from Ingredientes where idingrediente=@idingrediente);
							set @cantidadunidad=(select cantidadunidad from Ingredientes where idingrediente=@idingrediente);
							update Compras set totalcompra=((@cantidadcompra*@precio)/@cantidadunidad)+totalcompra where idproductocom=@idproductocom;

							update Ingredientes set existencias=((select existencias from Ingredientes where idingrediente=@idingrediente)+@cantidadcompra) where idingrediente=@idingrediente;
						commit tran
					end
		end

/* .....................................................................................................................................................  */

create procedure insIngredientesProductosProcesados

	@bandera int output, 
	@idingrediente int, 
	@idproductoproc int, 
	@cantidadingrediente int

	as 

	declare @banpro int 
	declare @baning int
	declare @noingrediente int


	if (select COUNT(idproductoproc) from ProductosProcesados)=0
		begin
			print 'No existe ninguna id en la tabla Productos Procesados'
			set @bandera=1;
		end
	else
		if (select idproductoproc from ProductosProcesados where @idproductoproc=idproductoproc)=@idproductoproc
			begin
				set @banpro=1;
			end
		else
			begin
				print 'No existe ese id de Producto Procesado'
				set @bandera=2;
			end


	if (select COUNT(idingrediente) from Ingredientes)=0
		begin
			print 'No existe ninguna id en la tabla Ingredientes'
			set @bandera=3;
		end
	else
		if (select idingrediente from Ingredientes where @idingrediente=idingrediente)=@idingrediente
			begin 
				set @baning=1;
			end
		else
			begin 
				print 'No existe ese id de Ingredientes'
				set @bandera=4;
			end

	if(@banpro=1 and @baning=1)
		begin
			if (select idproductoproc from IngredientesProductosProcesados where @idproductoproc=idproductoproc and @idingrediente=idingrediente)=@idproductoproc and
			 (select idingrediente from IngredientesProductosProcesados where @idproductoproc=idproductoproc and @idingrediente=idingrediente)=@idingrediente
				begin 
					print 'Esa combinación ya existe'
					set @bandera=5;
				end
			else
				if(@cantidadingrediente<=0)
					begin
						print 'Cantidad de ingrediente debe ser mayor a 0'
						set @bandera=6;
					end
				else	
					begin
						begin tran
							if(select COUNT(noingrediente) from IngredientesProductosProcesados where idproductoproc=@idproductoproc)=0
								begin
									set @noingrediente=1;
								end
							else
								set @noingrediente=(select MAX(noingrediente) from IngredientesProductosProcesados where idproductoproc=@idproductoproc)+1;

							insert into IngredientesProductosProcesados values (@idingrediente, @idproductoproc, @cantidadingrediente, @noingrediente);
						commit tran
					end
		end

/* .....................................................................................................................................................  */

create procedure insVentasProductosProcesados

	@bandera int output, 
	@idventa int, 
	@idproductoproc int, 
	@cantidadven int, 
	@comentarios varchar(50)

	as 

	declare @banven int 
	declare @banpro int
	declare @contador int
	declare @numingredientes int
	declare @valexistencia int 
	declare @valcantidadingrediente int 
	declare @nombreingrediente varchar(50)

	
	if (select COUNT(idventa) from Ventas)=0
		begin
			print 'No existe ninguna id en la tabla Ventas'
			set @bandera=1;
		end
	else
		if (select idventa from Ventas where @idventa=idventa)=@idventa
			begin
				set @banven=1;
			end
		else
			begin
				print 'No existe ese id de venta'
				set @bandera=2;
			end

	
	if (select COUNT(idproductoproc) from ProductosProcesados)=0
		begin
			print 'No existe ninguna id en la tabla Productos Procesados'
			set @bandera=3;
		end
	else
		if (select idproductoproc from ProductosProcesados where @idproductoproc=idproductoproc)=@idproductoproc
			begin 
				set @banpro=1;
			end
		else
			begin 
				print 'No existe ese id del Producto Procesado'
				set @bandera=4;
			end

	if(@banpro=1 and @banven=1)
		begin
			if (select idventa from VentasProductosProcesados where @idventa=idventa and @idproductoproc=idproductoproc)=@idventa and
			 (select idproductoproc from VentasProductosProcesados where @idventa=idventa and @idproductoproc=idproductoproc)=@idproductoproc
				begin 
					print 'Esa combinación ya existe'
					set @bandera=5;
				end
			else
				if(@cantidadven<=0)
					begin
						print 'Cantidad de compra debe ser mayor a 0'
						set @bandera=6;
					end
				else
					begin
						set @contador=0;
						set @numingredientes=(select COUNT(existencias) from Ingredientes inner join IngredientesProductosProcesados 
						ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
						inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
						where ProductosProcesados.idproductoproc=@idproductoproc);
						while (@contador<@numingredientes)
							begin

								set @valexistencia= (select existencias from Ingredientes inner join IngredientesProductosProcesados 
								ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
								inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
								where ProductosProcesados.idproductoproc=@idproductoproc and IngredientesProductosProcesados.noingrediente=@contador+1);

								set @valcantidadingrediente= (select IngredientesProductosProcesados.cantidadingrediente from Ingredientes 
								inner join IngredientesProductosProcesados 
								ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
								inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
								where ProductosProcesados.idproductoproc=@idproductoproc and IngredientesProductosProcesados.noingrediente=@contador+1);

								set @nombreingrediente= (select nombreingrediente from Ingredientes 
								inner join IngredientesProductosProcesados 
								ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
								inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
								where ProductosProcesados.idproductoproc=@idproductoproc and IngredientesProductosProcesados.noingrediente=@contador+1);

								if(@valexistencia<(@valcantidadingrediente*@cantidadven))
									begin
										print (@nombreingrediente)
										print 'No hay suficiente ingredientes suficientes para poder realizar esa venta'
										set @bandera=8;
										break;
									end
								else
									set @contador=@contador+1;
							end
						if(@contador=@numingredientes and @contador<>0 and @bandera<>8)
							begin
								begin tran
									update Ventas set total=((select precioproductoproc from ProductosProcesados where idproductoproc=@idproductoproc)*@cantidadven)+total where idventa=@idventa;
									insert into VentasProductosProcesados values (@idventa, @idproductoproc, @cantidadven, @comentarios);
									set @contador=0;
									while (@contador<@numingredientes)
										begin
											update Ingredientes set existencias=existencias-(cantidadingrediente * @cantidadven)
											from Ingredientes inner join IngredientesProductosProcesados 
											ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
											inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
											where ProductosProcesados.idproductoproc=@idproductoproc and noingrediente=@contador+1;

											set @contador=@contador+1;
										end
								commit tran
							end
						else	
							if(@contador=0 and @bandera<>8)
								begin
									print 'El producto que desea vender no está relacionado con ningún ingrediente'
									set @bandera=7;
								end
					end
					
		end

/* .....................................................................................................................................................  */

