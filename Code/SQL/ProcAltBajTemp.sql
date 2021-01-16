create procedure AltasBajasEmpleados

	@idempleado int

	as 

	if(select edoempleado From Empleados where @idempleado=idempleado)=1
		begin
			/* Se dará de baja */
			update Empleados set edoempleado=0 where idempleado=@idempleado;
		end
	else
		begin
			/* Se dará de alta */
			update Empleados set edoempleado=1 where idempleado=@idempleado;
		end

/* ----------------------------------------------------------------------------------------------------------------------------------------- */

create procedure AltasBajasProductosHechos

	@idproductohech int

	as

	if(select existencias from ProductosHechos where @idproductohech=idproductohech)>0
		begin
			/* Si hay de ese producto en existencia, por lo tanto se da de alta */
			update ProductosHechos set edoproductohech=1 where @idproductohech=idproductohech;
		end
	else
		begin
			/* No hay de ese producto en existencia, por lo tanto se da de baja */
			update ProductosHechos set edoproductohech=0 where @idproductohech=idproductohech;
		end


/* ----------------------------------------------------------------------------------------------------------------------------------------- */

create procedure AltasBajasIngredientes

	@idingrediente int

	as

	if(select existencias from Ingredientes where idingrediente=@idingrediente)>0
		begin
			/* Sí hay de ese ingrediente en existencia, por lo tanto se dará de alta */
			update Ingredientes set edoingrediente=1 where @idingrediente=idingrediente;
		end
	else
		begin
			/* No hay de ese ingrediente en existencia, por lo tanto se dará de baja */
			update Ingredientes set edoingrediente=0 where @idingrediente=idingrediente;
		end


/* ----------------------------------------------------------------------------------------------------------------------------------------- */


create procedure AltasBajasProductosProcesados

	@idproductoproc int

	as 

	declare @cantidadingredientes int
	declare @contador int
	declare @valexistencia int
	declare @ban int

	set @ban=1;
	set @contador=0;
	set @cantidadingredientes= (select COUNT(noingrediente) from IngredientesProductosProcesados where idproductoproc=@idproductoproc);

	while (@contador<@cantidadingredientes)
		begin
			/* Estará validando ingrediente por ingrediente, para ver si tiene en existencia todos los ingredientes que ocupa ese producto*/
			set @valexistencia= (select existencias from Ingredientes inner join IngredientesProductosProcesados 
								ON Ingredientes.idingrediente=IngredientesProductosProcesados.idingrediente
								inner join ProductosProcesados on IngredientesProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc
								where ProductosProcesados.idproductoproc=@idproductoproc and IngredientesProductosProcesados.noingrediente=@contador+1);
			print (@valexistencia)
			if(@valexistencia>0)
				begin
					/* Si hay existencias de ese ingrediente */
					set @contador=@contador+1;
				end
			else
				begin
					print 'No tienes los ingredientes suficientes para hacer este producto'
					update ProductosProcesados set edoproductoproc=0 where @idproductoproc=idproductoproc;
					set @ban=0;
					break;
				end
		end
		
		if(@ban=1)
			begin
				if(@contador<>0)
					begin
						update ProductosProcesados set edoproductoproc=1 where @idproductoproc=idproductoproc;
					end
				else
					begin
						/* Ese producto no está en condiciones para venderse, por lo tanto se da de baja */
						print 'El producto que desea dar de alta o baja no está relacionado con ningún ingrediente'
						update ProductosProcesados set edoproductoproc=0 where @idproductoproc=idproductoproc;
					end
			end
		
	


/* ----------------------------------------------------------------------------------------------------------------------------------------- */
