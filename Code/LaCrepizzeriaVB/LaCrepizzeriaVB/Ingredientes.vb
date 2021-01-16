Public Class Ingredientes
    Dim idingrediente As Integer
    Dim edoingrediente As 
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        If (textboxnombre.Text <> "" Or textboxclave.Text <> "") Then
            'Es porque alguno de los 2 campos tiene algo escrito'
            If (radiobuttonclave.Checked = True) Then
                consulta1 = New ADODB.Recordset
                consulta1 = conexion.Execute("select * from Ingredientes where idingrediente=" & textboxclave.Text)
            End If
            If (radiobuttonombre.Checked = True) Then
                consulta1 = New ADODB.Recordset
                consulta1 = conexion.Execute("select * from Ingredientes where nombreingrediente='" & textboxnombre.Text & "'")
            End If

            If consulta1.EOF Then
                textboxclave.Text = consulta1.Fields(0).Value
                textboxnombre.Text = consulta1.Fields(1).Value
                textboxtipoingrediente.Text = consulta1.Fields(2).Value
                textboxexistencias.Text = consulta1.Fields(3).Value
                textboxcantidad.Text = consulta1.Fields(4).Value
                textboxcantidad.Text = consulta1.Fields(5).Value
                edoempleado = consulta1.Fields(6).Value
                If (edoempleado = 1) Then
                    radiobuttonalta.Checked = True
                    radiobuttonbaja.Checked = False
                Else
                    If (edoempleado = 0) Then
                        radiobuttonalta.Checked = False
                        radiobuttonbaja.Checked = True
                    End If
                End If
                textboxcaja.Visible = True
                textboxcaja.Enabled = True
                textboxid.Enabled = True
                textboxid.Visible = True
                labelclave.Visible = True
                modificar.Enabled = True
                radiobuttonalta.Enabled = True
                radiobuttonbaja.Enabled = True
            Else
                MsgBox("El id de empleado o el nombre con el que realizó la búsqueda no existe")
            End If

        Else
            MsgBox("El campo con el que desea realizar la búsqueda está vacío")
        End If
    End Sub
End Class