create procedure actEmpleados

	@idempleado int, 
	@nombrempleado varchar(40), 
	@cargoarea varchar(20),
	@pagocaja decimal(5,2), 
	@contraseña varchar(30),
	@edoempleado int,
	@bandera int output 

	as

	if(select nombrempleado from Empleados where @idempleado=idempleado)<>@nombrempleado
		begin
			/* Se editará el nombre del empleado */
			if (select nombrempleado from Empleados where nombrempleado=@nombrempleado)=@nombrempleado and 
				(select idempleado from Empleados where nombrempleado=@nombrempleado)<>@idempleado
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
		end


	if(@bandera<>1 and @bandera<>2)
		begin
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
					if ((@cargoarea='Caja')or(@cargoarea='Mesero(a)')or(@cargoarea='Cocina(Crepas)')or(@cargoarea='Cocina(Horno)')or(@cargoarea='Bebidas'))
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
											update Empleados set  nombrempleado=@nombrempleado, cargoarea=@cargoarea, pagocaja=@pagocaja,
												contraseña=@contraseña, edoempleado=@edoempleado where idempleado=@idempleado;
										commit tran
									end
						end
					else
						begin
							print 'Cargo de Área; Solo 5 opciones: Caja, Mesero(a), Cocina(Crepas), Cocina(Horno), Bebidas'
							set @bandera=5;
						end
		end
		
/* --------------------------------------------------------------------------------------------------------------------------------------------------------- */

create procedure actCompras

	@idproductocom int,
	@totalcompra decimal(5,2), 
	@fechacompra date,
	@idempleado int, 
	@bandera int output 

	as 


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


create procedure actIngredientes
	
	/* El cambio del precio de ingrediente solo afectará a compras posteriores a ésta */

	@idingrediente int,
	@nombreingrediente varchar(40), 
	@tipoingrediente varchar(15), 
	@existencias int, 
	@cantidadunidad int, 
	@precioingrediente decimal (5,2),
	@bandera int output

	as 


	if(select nombreingrediente from Ingredientes where idingrediente=@idingrediente)<>@nombreingrediente
		begin
			/* Se editará el nombre de ingrediente */
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


create procedure actProductosHechos

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

create procedure actProductosProcesados 

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



create procedure actVentas

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
