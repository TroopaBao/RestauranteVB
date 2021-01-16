
create procedure DelEmpleado

	@idempleado int,
	@bandera int output /* 0.- Verificar, 1.- Eliminar, 2.- Eliminación Directa, -1= No se puede eliminar */

	as 

	declare @idproductocom int
	declare @idingrediente int
	declare @idproductohech int
	declare @cantcomprasreg int
	declare @contproductocom int
	declare @contadorcompra int
	declare @contadorproducto int
	declare @contingrediente int
	declare @contproductohech int

	declare @existencias int
	declare @valcantidadcompra int

	set @cantcomprasreg=(select COUNT(idempleado) from Compras where idempleado=@idempleado);
	if(@cantcomprasreg)>0
		begin
			/* El empleado si tiene compras registradas */
			 /* La variable cantidadcompra almacenará la cantidad de compras que tiene registrada el usuario */
			 set @contadorcompra=0;
			 set @contproductocom=0;
			 while (@contadorcompra<@cantcomprasreg)
				begin /* Ciclo que contará cada id de compra que tenga registrado el usuario */
					
					set @idproductocom=(select top 1 idproductocom from Compras  where idempleado=@idempleado 
											and idproductocom>@contproductocom  order by idproductocom ASC);

					if(select COUNT(idproductocom) from ComprasIngredientes where idproductocom=@idproductocom)>0
						begin
							/* El empleado realizó 1 o más compras de ingredientes */
							set @contadorproducto=0;
							set @contingrediente=0;
							while (@contadorproducto<(select COUNT(idproductocom) from ComprasIngredientes where idproductocom=@idproductocom))
								begin
									/* Ciclo que contará cada ingrediente que tenga registrada esa compra  */
									set @idingrediente=(select top 1 idingrediente from ComprasIngredientes where idproductocom=@idproductocom 
									and idingrediente>@contingrediente order by idingrediente asc);

									set @existencias=(select existencias from Ingredientes where idingrediente=@idingrediente);

									set @valcantidadcompra=(select cantidadcompra from ComprasIngredientes where idingrediente=@idingrediente 
															and idproductocom=@idproductocom);

									if(@existencias<@valcantidadcompra)
										begin
											print ' No se puede eliminar la compra de ese ingrediente, ya que no hay suficientes en existencia'
											set @bandera=-1;
											break;
										end
									else
										begin
											if(@bandera=1)
												begin
													/* Cuando es 1 se eliminan, cuando es 0 solo se verifica */
													update Ingredientes set existencias=existencias-@valcantidadcompra where idingrediente=@idingrediente;
													delete ComprasIngredientes where idingrediente=@idingrediente and idproductocom=@idproductocom;
												end
										end

									set @contingrediente=@idingrediente;
									set @contadorproducto=@contadorproducto+1;
								end
						end
					
					if(@bandera=-1)
						break;

					if(select COUNT(idproductocom) from ComprasProductosHechos where idproductocom=@idproductocom)>0
						begin
							/* El empleado realizó 1 o más compras de Productos Hechos */
							set @contadorproducto=0;
							set @contproductohech=0;
							while (@contadorproducto<(select COUNT(idproductocom) from ComprasProductosHechos where idproductocom=@idproductocom))
								begin
									/* Ciclo que contará cada producto hecho que tenga registrada esa compra */
									set @idproductohech=(select top 1 idproductohech from ComprasProductosHechos where idproductocom=@idproductocom 
									and idproductohech>@contproductohech order by idproductohech asc);

									set @existencias=(select existencias from ProductosHechos where idproductohech=@idproductohech);

									set @valcantidadcompra=(select cantidadcompra from ComprasProductosHechos where idproductohech=@idproductohech 
															and idproductocom=@idproductocom);

									if(@existencias<@valcantidadcompra)
										begin
											print ' No se puede eliminar la compra de ese producto hecho, ya que no hay suficientes en existencia'
											set @bandera=-1;
											break;
										end
									else
										begin
											if(@bandera=1)
												begin
													/* Cuando es 1 se eliminan, cuando es 0 solo se verifica */
													update ProductosHechos set existencias=existencias-@valcantidadcompra where idproductohech=@idproductohech;
													delete ComprasProductosHechos where idproductohech=@idproductohech and idproductocom=@idproductocom;
												end
										end

									set @contproductohech=@idproductohech;
									set @contadorproducto=@contadorproducto+1;
								end
						end
					
					if(@bandera=-1)
						break;

					set @contproductocom=@idproductocom;
					set @contadorcompra=@contadorcompra+1;
				end

				if(@bandera=1)
					begin
						/* Ya se puede eliminar al empleado */
						delete Compras where idempleado=@idempleado;
						delete Empleados where idempleado=@idempleado;
					end
				else
					if(@bandera=0)
						begin
							/* Ya está verificado, y listo para eliminar */
								print 'Listo para eliminar'
							set @bandera=1;
						end
		end
	else
		begin
			print 'El empleado no tiene compras registradas, por lo tanto se puede eliminar directamente'
			delete Empleados where idempleado=@idempleado;
			set @bandera=2;
		end



create procedure DelCompra

	@idproductocom int, 
	@bandera int output

	as
	declare @idingrediente int
	declare @idproductohech int
	declare @cantcomprasreg int
	declare @contproductocom int
	declare @contadorcompra int
	declare @contadorproducto int
	declare @contingrediente int
	declare @contproductohech int

	declare @existencias int
	declare @valcantidadcompra int

	if(select COUNT(idproductocom) from ComprasIngredientes where idproductocom=@idproductocom)>0
		begin
			/* Esa compra contiene 1 o más compras de ingredientes */
			set @contadorproducto=0;
			set @contingrediente=0;
			while (@contadorproducto<(select COUNT(idproductocom) from ComprasIngredientes where idproductocom=@idproductocom))
				begin
					/* Ciclo que contará cada ingrediente que tenga registrada esa compra  */
					set @idingrediente=(select top 1 idingrediente from ComprasIngredientes where idproductocom=@idproductocom 
					and idingrediente>@contingrediente order by idingrediente asc);

					set @existencias=(select existencias from Ingredientes where idingrediente=@idingrediente);

					set @valcantidadcompra=(select cantidadcompra from ComprasIngredientes where idingrediente=@idingrediente 
											and idproductocom=@idproductocom);

					if(@existencias<@valcantidadcompra)
						begin
							print ' No se puede eliminar la compra de ese ingrediente, ya que no hay suficientes en existencia'
							set @bandera=-1;
							break;
						end
					else
						begin
							if(@bandera=1)
								begin
									/* Cuando es 1 se eliminan, cuando es 0 solo se verifica */
									update Ingredientes set existencias=existencias-@valcantidadcompra where idingrediente=@idingrediente;
									delete ComprasIngredientes where idingrediente=@idingrediente and idproductocom=@idproductocom;
								end
						end

					set @contingrediente=@idingrediente;
					set @contadorproducto=@contadorproducto+1;
				end

				if(@bandera=1)
					begin
						/* Ya se puede eliminar la compra */
						delete Compras where idproductocom=@idproductocom;
					end
				else
					if(@bandera=0)
						begin
							/* Ya está verificado, y listo para eliminar */
							print 'Listo para eliminar'
							set @bandera=1;
						end
		end
					

	if((select COUNT(idproductocom) from ComprasProductosHechos where idproductocom=@idproductocom)>0 and @bandera<>-1)
		begin
			/* El empleado realizó 1 o más compras de Productos Hechos */
			set @contadorproducto=0;
			set @contproductohech=0;
			while (@contadorproducto<(select COUNT(idproductocom) from ComprasProductosHechos where idproductocom=@idproductocom))
				begin
					/* Ciclo que contará cada producto hecho que tenga registrada esa compra */
					set @idproductohech=(select top 1 idproductohech from ComprasProductosHechos where idproductocom=@idproductocom 
					and idproductohech>@contproductohech order by idproductohech asc);

					set @existencias=(select existencias from ProductosHechos where idproductohech=@idproductohech);

					set @valcantidadcompra=(select cantidadcompra from ComprasProductosHechos where idproductohech=@idproductohech 
											and idproductocom=@idproductocom);

					if(@existencias<@valcantidadcompra)
						begin
							print ' No se puede eliminar la compra de ese producto hecho, ya que no hay suficientes en existencia'
							set @bandera=-1;
							break;
						end
					else
						begin
							if(@bandera=1)
								begin
									/* Cuando es 1 se eliminan, cuando es 0 solo se verifica */
									update ProductosHechos set existencias=existencias-@valcantidadcompra where idproductohech=@idproductohech;
									delete ComprasProductosHechos where idproductohech=@idproductohech and idproductocom=@idproductocom;
								end
						end

					set @contproductohech=@idproductohech;
					set @contadorproducto=@contadorproducto+1;
				end
		end



create procedure DelIngrediente

	@idingrediente int, 
	@bandera int output

	as

	declare @idproductocom int
	declare @cantidadproductosproc int
	declare @contadorcompra int
	declare @contproductocom int
	declare @existencias int
	declare @valcantidadcompra int
	declare @precio int
	declare @cantidadunidad int

	if(select COUNT(idproductocom) from ComprasIngredientes where idingrediente=@idingrediente)>0
		begin
			/* Ese ingrediente está registrado en 1 o más compras */
			set @contadorcompra=0;
			set @contproductocom=0;
			while (@contadorcompra<(select COUNT(idproductocom) from ComprasIngredientes where idingrediente=@idingrediente) and @bandera=1)
				begin
					/* Ciclo que contará cada ingrediente que tenga registrada esa compra  */
					set @idproductocom=(select top 1 idproductocom from ComprasIngredientes where idingrediente=@idingrediente 
					and idproductocom>@contproductocom order by idingrediente asc);

					/* Cuando es 1 se eliminan, cuando es 0 solo se verifica */
					set @precio=(select precioingrediente from Ingredientes where idingrediente=@idingrediente);
					set @cantidadunidad=(select cantidadunidad from Ingredientes where idingrediente=@idingrediente);
					if((select tipoingrediente from Ingredientes where idingrediente=@idingrediente)='gr' or
						(select tipoingrediente from Ingredientes where idingrediente=@idingrediente)='ml')
						begin
							set @cantidadunidad=@cantidadunidad/1000;
						end
					update Compras set totalcompra=totalcompra-((@valcantidadcompra*@precio)/@cantidadunidad) 
						where idproductocom=@idproductocom;
					delete ComprasIngredientes where idingrediente=@idingrediente and idproductocom=@idproductocom;

					set @contproductocom=@idproductocom;
					set @contadorcompra=@contadorcompra+1;
				end
		end


	set @cantidadproductosproc=(select COUNT(idingrediente) from IngredientesProductosProcesados where idingrediente=@idingrediente);
	if((@cantidadproductosproc)>0 and @bandera=1 )
		begin
			/* Existe 1 o más de un produto procesado con ese ingrediente */
			update ProductosProcesados set edoproductoproc=0 from ProductosProcesados inner join IngredientesProductosProcesados
			on ProductosProcesados.idproductoproc=IngredientesProductosProcesados.idproductoproc where idingrediente=@idingrediente;
			delete IngredientesProductosProcesados where idingrediente=@idingrediente;

			/* Ya se puede eliminar la tabla de Ingrediente */
			delete Ingredientes where idingrediente=@idingrediente;
		end

	


create procedure DelProductosProcesados

	@idproductoproc int

	as

	declare @idventa int
	declare @cantidadventas int 
	declare @contadorventa int
	declare @contventa int

	if(select COUNT(idproductoproc) from VentasProductosProcesados where idproductoproc=@idproductoproc)>0
		begin
			/* Existen registros en ventas que vendieron ese producto */
			set @contadorventa=0;
			set @cantidadventas=(select COUNT(idventa) from VentasProductosProcesados where idproductoproc=@idproductoproc);
			while (@contadorventa<@cantidadventas)
				begin
					set @contventa=0;
					set @idventa=(select top 1 idventa from VentasProductosProcesados where idproductoproc=@idproductoproc
									and idventa>@contventa order by idventa asc);

					update Ventas set total=total-(precioproductoproc*cantidadven) from Ventas inner join VentasProductosProcesados on
						VentasProductosProcesados.idventa=Ventas.idventa inner join ProductosProcesados on
						VentasProductosProcesados.idproductoproc=ProductosProcesados.idproductoproc where Ventas.idventa=@idventa and 
						ProductosProcesados.idproductoproc=@idproductoproc;
					set @contadorventa=@contadorventa+1;
					set @contventa=@idventa;
				end
				delete VentasProductosProcesados where idproductoproc=@idproductoproc;
		end
	
	if(select COUNT(idproductoproc) from IngredientesProductosProcesados where idproductoproc=@idproductoproc)>0
		begin
			/* El producto procesado tiene relaciones con ingredientes */
			delete IngredientesProductosProcesados where idproductoproc=@idproductoproc;
		end

	delete ProductosProcesados where idproductoproc=@idproductoproc;





create procedure DelProductosHechos

	@idproductohech int

	as 

	if(select COUNT(idproductocom) from ComprasProductosHechos where idproductohech=@idproductohech)>0
		begin
			/* Existen registros de compras con Productos Hechos */

		end


	delete ProductosHechos where idproductohech=@idproductohech;





create procedure DelVenta

	@idventa int, 
	@bandera int output, 
	@productohecho int /* 0.- Si el producto aún no está preparado, 1.- Si el producto fue entregado o abierto (en caso de algún producto hecho) */

	as

	delete Ventas where idventa=@idventa;