
/* EJECUCIONES DE PROCEDIMIENTOS ALMACENADOS */

/* ************************************************************************************************************************************************* */
/* ------------------------------------------------   INSERCIONES ------------------------------------------------------- */
/* ************************************************************************************************************************************************* */


/* ************************************************** InsEmpleados  ***************************************************** */

insEmpleados 'Gerardo Viveros', 'Gerente', 0.00, 'gerabichochas', 0        /* Dar de alta al primer empleado */
insEmpleados 'Gerardo Viveros', 'Mesero(a)', 0.00, 'gerabichochas', 0      /* Ya existe ese nombre de empleado */
update Empleados set edoempleado=0 where idempleado=1                      /* Dar de baja temporal al primer empleado */
insEmpleados 'Gerardo Viveros', 'Mesero(a)', 0.00, 'gerabichochas', 0      /* Ya existe ese nombre de empleado, y está de baja temporal*/
insEmpleados '', 'Mesero(a)', 0.00, 'gerabichochas', 0					   /* El nombre del empleado está vacío */
insEmpleados 'Diego Lua', '', 0.00, 'gerabichochas', 0                     /* El campo de cargo de área está vacío  */
insEmpleados 'Diego Lua', 'Meserito', 0.00, 'gerabichochas', 0             /* Cargo de Area solo 5 opciones */
insEmpleados 'Diego Lua', 'Caja', -2.00, 'gerabichochas', 0                /* El campo pagocaja no acepta valores negativos  */
insEmpleados 'Diego Lua', 'Caja', 10.00, '', 0                             /* Contraseña vacía  */
insEmpleados 'Diego Lua', 'Caja', 10.00, 'diegolua', 0					   /* Dar de alta al segundo empleado */

select * from Empleados



/* ************************************************** InsCompras  ***************************************************** */

insCompras 10.00, '2019/03/26',1, 0											/* Dar de alta la primer compra */
insCompras -30.00, '2019/03/26',1, 0										/* No se acepta valores negativos en totalcompra */
insCompras 124.00, '',1, 0													/* Fechacompra no debe estar vacía */
insCompras 124.00, '2019/03/27',9, 0										/* Ese id de empleado no existe */
insCompras 10.00, '2019/03/27',2, 0											/* Dar de alta la segunda compra */

select * from Compras
/* Se hace un registro de productos en grupos. Y de ahí se hace un total de todos los productos comprados en ese momento */
 


/* ************************************************** InsIngredientes  ***************************************************** */

insIngredientes 'Kinder Delice', 'Unidad', 5,1, 12.00, 0				/* Dar de alta el primer ingrediente */
insIngredientes 'Kinder Delice', 'Unidad', 5,1, 12.00, 0				/* Ese ingrediente ya existe */
update Ingredientes set edoingrediente=0 where idingrediente=1;			/* Estado de ingrediente cambia a 0 */
insIngredientes 'Kinder Delice', 'Unidad', 5,1, 12.00, 0				/* Ese ingrediente ya existe, y está de baja temporal */
insIngredientes '', 'ml', 5, 1, 12.00,0									/* Campo de nombreingrediente está vacío */
insIngredientes 'Nutella', '', 1500,500, 22.00, 0						/* Tipoingrediente está vacío */
insIngredientes 'Nutella', 'js', 1500,500, 33.00, 0						/* Tipoingrediente, solo 5 opciones */
insIngredientes 'Nutella', 'ml', -20,500, 33.00, 0						/* Existencias mayores o iguales a 0 */
insIngredientes 'Nutella', 'ml', 1500, -500, 33.00,0					/* Cantidadunidad mayores a 0 */
insIngredientes 'Nutella', 'ml', 1500, 500, -33.00,0					/* Precioingrediente, mayores a 0 */
insIngredientes 'Nutella', 'ml', 1500, 500, 33.00,0						/* Dar de alta el segundo ingrediente */

select * from Ingredientes


/* ************************************************** InsProductosHechos  ***************************************************** */


insProductosHechos 'Agua Natural', 10.00, 4, 0							/* Dar de alta el primer producto hecho */
insProductosHechos 'Agua Natural', 10.00, 4, 0							/* Ese producto hecho ya existe */
update ProductosHechos set edoproductohech=0 where idproductohech=1;	/* Dar de baja temporal ese producto hecho */
insProductosHechos 'Agua Natural', 10.00, 4, 0							/* Ese producto hecho ya existe, está de baja temporal */
insProductosHechos '', 10.00, 4, 0										/* Campo nombreproductohecho está vacío */
insProductosHechos 'Coca-Cola 600ml', -10.00, 4, 0						/* El precio debe ser mayor a 0 */
insProductosHechos 'Coca-Cola 600ml', 23.00, -4, 0						/* Existencias mayores a 0 */
insProductosHechos 'Coca-Cola 600ml', 23.00, 16, 0						/* Dar de alta el segundo producto hecho */

select * from ProductosHechos

/* ************************************************** InsProductosProcesados  ***************************************************** */

insProductosProcesados 'Crepa Kinder Delice', 45.00, 0					/* Dar de alta el primer producto procesado */
insProductosProcesados 'Crepa Kinder Delice', 45.00, 0					/* Ese producto procesado ya existe */
update ProductosProcesados set edoproductoproc=0 where idproductoproc=1;/* Dar de baja temporal ese producto procesado */
insProductosProcesados 'Crepa Kinder Delice', 45.00, 0					/* Ese producto procesad ya existe, y está de baja temporal */
insProductosProcesados '', 28.00, 0										/* Campo nombreproductoproc está vacío */
insProductosProcesados 'Crepa Sunday', -65.00, 0						/* Precio debe ser mayor a 0 */
insProductosProcesados 'Crepa Sunday', 65.00, 0							/* Dar de alta el segundo producto procesado */

select * from ProductosProcesados


/* ************************************************** InsVentas ***************************************************************** */

insVentas '2019/03/26', 12, 'Mesa 1A',   50.00, 0						/* Dar de alta la primer venta */
insVentas '', 12, 'Mesa 1A', 300.00, 0									/* Fecha de venta no debe estar vacía */
insVentas '2019/03/27', -12, 'Mesa 1A', 300.00, 0						/* Folio mayor a 0 */
insVentas '2019/03/27', 13, '', 300.00, 0								/* Nombremesa no debe estar vacío */
insVentas '2019/03/27', 13, 'Periquera 1', -300.00, 0					/* Total mayor a 0 */
insVentas '2019/03/27', 13, 'Periquera 1',   50.00, 0					/* Dar de alta la segunda venta */

select * from Ventas

/* ************************************************** InsComprasProductosHechos ***************************************************************** */

select * from Compras 
select * from ProductosHechos

insComprasProductosHechos 0,1,78,3										/* No existe ese id de compra */

insComprasProductosHechos 0, 78, 2, 3									/* No existe ese id de Producto Hecho */

insComprasProductosHechos 0,1,2,3										/* Inserción */
insComprasProductosHechos 0,1,2,3										/* Ya existe esa combinación */
insComprasProductosHechos 0,1,1,-2										/* Cantidad de Compra mayor a 0 */
insComprasProductosHechos 0,1,1,2										/* Inserción */

select * from ComprasProductosHechos


/* ************************************************** InsProductosHechosVentas ***************************************************************** */

select * from ProductosHechos
select * from Ventas

insProductosHechosVentas 0, 23, 1, 3									/* No existe ese id de Producto Hecho */		

insProductosHechosVentas 0, 2, 15, 3									/* No existe ese id de venta */

insProductosHechosVentas 0, 2, 1, 3										/* Inserción */
insProductosHechosVentas 0, 2, 1, 3										/* Esa combinación ya existe */
insProductosHechosVentas 0, 1, 1, -3									/* Cantidad de venta debe ser mayor a 0 */
insProductosHechosVentas 0, 1, 1, 13									/* Cantidad de venta mayor a existencias */
insProductosHechosVentas 0, 1, 1, 1										/* Inserción */

select * from ProductosHechosVentas

/* ************************************************** InsComprasIngredientes ***************************************************************** */

select * from Compras
select * from Ingredientes

insComprasIngredientes 0,1,3, 3											/* No existe ese id de compra */


insComprasIngredientes 0,78,1, 3										/* No existe ese id de ingredientes */

insComprasIngredientes 0,1,1, 3											/* Inserción */
insComprasIngredientes 0,1,1, 3											/* Esa combinación ya existe */
insComprasIngredientes 0,1,2, -3										/* Cantidad de compra mayor a 0 */
insComprasIngredientes 0,1,2, 1											/* Inserción */

select * from ComprasIngredientes


/* ************************************************** InsIngredientesProductosProcesados ************************************************************* */

select * from Ingredientes
select * from ProductosProcesados

insIngredientesProductosProcesados 0,6,1, 3								/* No existe ese id de Ingredientes */
insIngredientesProductosProcesados 0, 1, 15, 3							/* No existe ese id de Producto Procesado */

insIngredientesProductosProcesados 0,1,1, 1								/* Inserción */
insIngredientesProductosProcesados 0,1,1, 3								/* Esa combinación ya existe */
insIngredientesProductosProcesados 0,2,1, -23							/* Cantidad de ingrediente mayor a 0 */
insIngredientesProductosProcesados 0,2,1, 100							/* Inserción */	

select * from IngredientesProductosProcesados

/* ************************************************** InsVentasProductosProcesados ***************************************************************** */

select * from Ventas 
select * from ProductosProcesados
select * from Ingredientes
select * from IngredientesProductosProcesados

insVentasProductosProcesados 0, 19, 1, 1, 'Poca Nutella'				/* No existe ese id de Ventas */
insVentasProductosProcesados 0, 1, 19, 1, 'Poca Nutella'				/* No existe ese id de Producto Procesado */

insVentasProductosProcesados 0, 1, 1, 1, 'Poca Nutella'					/* Inserción */
insVentasProductosProcesados 0, 1, 1, 1, 'Poca Nutella'					/* Esa combinación ya existe */
insVentasProductosProcesados 0, 2, 1, -15, 'Poca Nutella'				/* Cantidad de venta, mayor que 0 */
insVentasProductosProcesados 0, 1, 2, 1, 'crepa sunday sin mermelada'	/* Producto no tiene relación con ingredientes */
insVentasProductosProcesados 0, 2, 1, 15, 'Poca Nutella'				/* Pocos ingredientes para hacer esos productos */
insVentasProductosProcesados 0, 2, 1, 2, 'Poca Nutella'					/* Inserción */

select * from VentasProductosProcesados


/* ************************************************************************************************************************************************* */

/* ----------------------------------------------------   ALTAS Y BAJAS TEMPORALES  -------- ------------------------------------------------------- */

/* ************************************************************************************************************************************************* */

select * from Empleados where idempleado=1;

AltasBajasEmpleados 1
select * from Empleados where idempleado=1;

AltasBajasEmpleados 1
select * from Empleados where idempleado=1;

/* ************************************************************************************************************************************************* */

select * from ProductosHechos where idproductohech=1;

update ProductosHechos set existencias=0 where idproductohech=1;
AltasBajasProductosHechos 1
select * from ProductosHechos where idproductohech=1;

update ProductosHechos set existencias=100 where idproductohech=1;
AltasBajasProductosHechos 1
select * from ProductosHechos where idproductohech=1;

/* ************************************************************************************************************************************************* */


select * from Ingredientes where idingrediente=1;

update Ingredientes set existencias=0 where idingrediente=1;
AltasBajasIngredientes 1
select * from Ingredientes where idingrediente=1;

update Ingredientes set existencias=100 where idingrediente=1;
AltasBajasIngredientes 1
select * from Ingredientes where idingrediente=1;

/* ************************************************************************************************************************************************* */

select nombreingrediente, existencias, edoingrediente from Ingredientes inner join 
	IngredientesProductosProcesados on IngredientesProductosProcesados.idingrediente=Ingredientes.idingrediente where idproductoproc=1;

select * from ProductosProcesados;

update Ingredientes set existencias=0 where idingrediente=1;
AltasBajasProductosProcesados 1

update Ingredientes set existencias=100 where idingrediente=1;
AltasBajasProductosProcesados 1

AltasBajasProductosProcesados 2

/* ************************************************************************************************************************************************* */

/* ----------------------------------------------------  ELIMINACIONES   ------------ ------------------------------------------------------- */

/* ************************************************************************************************************************************************* */


/* -------------------------------------------------------    DelEmpleado   ------------------------------------------------------------------ */

