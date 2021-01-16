Public Class Inicio

    Private Sub insertarempleado_Click(sender As Object, e As EventArgs) Handles insertarempleado.Click
        Empleado.Labelclave.Visible = False
        Empleado.Labelbusqueda.Visible = False
        Empleado.labelestado.Visible = False
        Empleado.labelsaldo.Visible = False
        Empleado.textboxid.Visible = False
        Empleado.textboxcaja.Visible = False
        Empleado.radiobuttonalta.Visible = False
        Empleado.radiobuttonbaja.Visible = False
        Empleado.RadioButtonid.Visible = False
        Empleado.RadioButtonnombre.Visible = False
        Empleado.modificar.Visible = False
        Empleado.buscar.Visible = False

        Empleado.cancelar.Visible = True
        Empleado.insertar.Visible = True
        Empleado.Labelnombre.Visible = True
        Empleado.textboxnombre.Visible = True
        Empleado.Labelcargo.Visible = True
        Empleado.textboxcargo.Visible = True
        Empleado.labelsaldo.Visible = True
        Empleado.textboxcaja.Visible = True
        Empleado.Labelcontra.Visible = True
        Empleado.textboxcontra.Visible = True


        Close()
        Empleado.Show()
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Close()
        Login.Show()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub modificarempleado_Click(sender As Object, e As EventArgs) Handles modificarempleado.Click
        Empleado.Labelclave.Visible = True
        Empleado.Labelbusqueda.Visible = True
        Empleado.labelestado.Visible = True
        Empleado.labelsaldo.Visible = True
        Empleado.textboxid.Visible = True
        Empleado.textboxcaja.Visible = True
        Empleado.radiobuttonalta.Visible = True
        Empleado.radiobuttonbaja.Visible = True
        Empleado.RadioButtonid.Visible = True
        Empleado.RadioButtonnombre.Visible = True
        Empleado.modificar.Visible = True
        Empleado.buscar.Visible = True

        Empleado.cancelar.Visible = True
        Empleado.insertar.Visible = False
        Empleado.Labelnombre.Visible = True
        Empleado.textboxnombre.Visible = True
        Empleado.Labelcargo.Visible = True
        Empleado.textboxcargo.Visible = True
        Empleado.labelsaldo.Visible = True
        Empleado.textboxcaja.Visible = True
        Empleado.Labelcontra.Visible = True
        Empleado.textboxcontra.Visible = True

        Empleado.modificar.Enabled = False
        Empleado.textboxcaja.Enabled = False
        Empleado.textboxcargo.Enabled = False
        Empleado.textboxcontra.Enabled = False
        Empleado.radiobuttonalta.Enabled = False
        Empleado.radiobuttonbaja.Enabled = False

        Close()
        Empleado.Show()
    End Sub

    Private Sub insertarcompra_Click(sender As Object, e As EventArgs) Handles insertarcompra.Click
        Compras.labelclave.Visible = False
        Compras.textboxidcompra.Visible = False
        Compras.buscar.Visible = False

        Compras.aceptar.Enabled = True
        Compras.textboxempleado.Enabled = True
        Compras.datacompras.Enabled = True
        Compras.agregar.Enabled = True
        Compras.quitar.Enabled = True

        Close()
        Compras.Show()
    End Sub

    Private Sub modificarcompra_Click(sender As Object, e As EventArgs) Handles modificarcompra.Click
        Compras.labelclave.Visible = True
        Compras.textboxidcompra.Visible = True
        Compras.buscar.Visible = True

        Compras.aceptar.Enabled = False
        Compras.textboxempleado.Enabled = False
        Compras.datacompras.Enabled = False
        Compras.agregar.Enabled = False
        Compras.quitar.Enabled = False

        Close()
        Compras.Show()
    End Sub

    Private Sub insertaringrediente_Click(sender As Object, e As EventArgs) Handles insertaringrediente.Click
        Ingredientes.textboxclave.Visible = False
        Ingredientes.labelclave.Visible = False
        Ingredientes.labelexistencias.Visible = False
        Ingredientes.textboxexistencias.Visible = False
        Ingredientes.labelestado.Visible = False
        Ingredientes.labelbusqueda.Visible = False
        Ingredientes.radiobuttonalta.Visible = False
        Ingredientes.radiobuttonbaja.Visible = False
        Ingredientes.radiobuttonclave.Visible = False
        Ingredientes.radiobuttonombre.Visible = False
        Ingredientes.modificar.Visible = False

        Ingredientes.insertar.Visible = True
        Ingredientes.textboxcantidad.Enabled = True
        Ingredientes.textboxexistencias.Enabled = True
        Ingredientes.textboxprecio.Enabled = True
        Ingredientes.textboxtipoingrediente.Enabled = True
        Ingredientes.radiobuttonalta.Enabled = True
        Ingredientes.radiobuttonbaja.Enabled = True

        Close()
        Ingredientes.Show()
    End Sub

    Private Sub modificaringrediente_Click(sender As Object, e As EventArgs) Handles modificaringrediente.Click
        Ingredientes.textboxclave.Visible = True
        Ingredientes.labelclave.Visible = True
        Ingredientes.labelexistencias.Visible = True
        Ingredientes.textboxexistencias.Visible = True
        Ingredientes.labelestado.Visible = True
        Ingredientes.labelbusqueda.Visible = True
        Ingredientes.radiobuttonalta.Visible = True
        Ingredientes.radiobuttonbaja.Visible = True
        Ingredientes.radiobuttonclave.Visible = True
        Ingredientes.radiobuttonombre.Visible = True
        Ingredientes.modificar.Visible = True

        Ingredientes.insertar.Visible = False
        Ingredientes.textboxcantidad.Enabled = False
        Ingredientes.textboxexistencias.Enabled = False
        Ingredientes.textboxprecio.Enabled = False
        Ingredientes.textboxtipoingrediente.Enabled = False
        Ingredientes.radiobuttonalta.Enabled = False
        Ingredientes.radiobuttonbaja.Enabled = False

        Close()
        Ingredientes.Show()
    End Sub

    Private Sub insertarprodhech_Click(sender As Object, e As EventArgs) Handles insertarprodhech.Click
        ProductosHechos.labelclave.Visible = False
        ProductosHechos.textboxclave.Visible = False
        ProductosHechos.labelexistencias.Visible = False
        ProductosHechos.textboxexistencias.Visible = False
        ProductosHechos.labelestado.Visible = False
        ProductosHechos.radiobuttonalta.Visible = False
        ProductosHechos.radiobuttonbaja.Visible = False
        ProductosHechos.labelbusqueda.Visible = False
        ProductosHechos.radiobuttonclave.Visible = False
        ProductosHechos.radiobuttonombre.Visible = False
        ProductosHechos.modificar.Visible = False

        ProductosHechos.insertar.Visible = True
        ProductosHechos.modificar.Visible = False
        ProductosHechos.textboxexistencias.Enabled = True
        ProductosHechos.textboxprecio.Enabled = True
        ProductosHechos.radiobuttonalta.Enabled = True
        ProductosHechos.radiobuttonbaja.Enabled = True

        Close()
        ProductosHechos.Show()
    End Sub

    Private Sub modificarprodhech_Click(sender As Object, e As EventArgs) Handles modificarprodhech.Click
        ProductosHechos.labelclave.Visible = True
        ProductosHechos.textboxclave.Visible = True
        ProductosHechos.labelexistencias.Visible = True
        ProductosHechos.textboxexistencias.Visible = True
        ProductosHechos.labelestado.Visible = True
        ProductosHechos.radiobuttonalta.Visible = True
        ProductosHechos.radiobuttonbaja.Visible = True
        ProductosHechos.labelbusqueda.Visible = True
        ProductosHechos.radiobuttonclave.Visible = True
        ProductosHechos.radiobuttonombre.Visible = True
        ProductosHechos.modificar.Visible = True

        ProductosHechos.insertar.Visible = False
        ProductosHechos.modificar.Visible = True
        ProductosHechos.textboxexistencias.Enabled = False
        ProductosHechos.textboxprecio.Enabled = False
        ProductosHechos.radiobuttonalta.Enabled = False
        ProductosHechos.radiobuttonbaja.Enabled = False

        Close()
        ProductosHechos.Show()
    End Sub

    Private Sub insertarprodproc_Click(sender As Object, e As EventArgs) Handles insertarprodproc.Click

        ProductosProcesados.labelclave.Visible = False
        ProductosProcesados.textboxclave.Visible = False
        ProductosProcesados.labelestado.Visible = False
        ProductosProcesados.radiobuttonalta.Visible = False
        ProductosProcesados.radiobuttonbaja.Visible = False
        ProductosProcesados.busqueda.Visible = False
        ProductosProcesados.buscar.Visible = False
        ProductosProcesados.radiobuttonclave.Visible = False
        ProductosProcesados.radiobuttonombre.Visible = False

        ProductosProcesados.aceptar.Visible = True
        ProductosProcesados.aceptar.Enabled = True

        Close()
        ProductosProcesados.Show()

    End Sub

    Private Sub modificarprodproc_Click(sender As Object, e As EventArgs) Handles modificarprodproc.Click

        ProductosProcesados.labelclave.Visible = True
        ProductosProcesados.textboxclave.Visible = True
        ProductosProcesados.labelestado.Visible = True
        ProductosProcesados.radiobuttonalta.Visible = True
        ProductosProcesados.radiobuttonbaja.Visible = True
        ProductosProcesados.busqueda.Visible = True
        ProductosProcesados.buscar.Visible = True
        ProductosProcesados.radiobuttonclave.Visible = True
        ProductosProcesados.radiobuttonombre.Visible = True

        ProductosProcesados.aceptar.Enabled = False
        ProductosProcesados.radiobuttonalta.Enabled = False
        ProductosProcesados.radiobuttonbaja.Enabled = False


        Close()
        ProductosProcesados.Show()

    End Sub

    Private Sub insertarventa_Click(sender As Object, e As EventArgs) Handles insertarventa.Click
        Ventas.labelclave.Visible = False
        Ventas.textboxclave.Visible = False
        Ventas.buscar.Visible = False

        Ventas.fechaventa.Enabled = True
        Ventas.textboxnombremesa.Enabled = True
        Ventas.agregar.Enabled = True
        Ventas.quitar.Enabled = True

        Close()
        Ventas.Show()
    End Sub

    Private Sub modificarventa_Click(sender As Object, e As EventArgs) Handles modificarventa.Click
        Ventas.labelclave.Visible = True
        Ventas.textboxclave.Visible = True
        Ventas.buscar.Visible = True

        Ventas.fechaventa.Enabled = False
        Ventas.textboxnombremesa.Enabled = False
        Ventas.agregar.Enabled = False
        Ventas.quitar.Enabled = False

        Close()
        Ventas.Show()
    End Sub

End Class