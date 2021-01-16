Imports ADODB

Public Class Login

    Public consultausuario As Recordset
    Public nombre As String

    Private Sub btnentrar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click
        Call conectar()
        If (modulo.conectado = True) Then
            consultausuario = New ADODB.Recordset
            consultausuario = conexion.Execute("select nombrempleado from Empleados where nombrempleado='" & textboxusuario.Text & "' and contraseña='" & textboxcontra.Text & "'")
            If Not consultausuario.EOF Then
                nombre = consultausuario.Fields("nombrempleado").Value
                consultausuario = conexion.Execute("select cargoarea from Empleados where nombrempleado='" & textboxusuario.Text & "' and contraseña='" & textboxcontra.Text & "'")
                nombre = consultausuario.Fields("cargoarea").Value
                If nombre = "Mesero(a)" Then
                    'Meseros solo podrán ingresar ventas. '
                    MsgBox("Opcion Mesero")
                Else
                    If nombre = "Cocina(Crepas)" Or nombre = "Cocina(Horno)" Or nombre = "Bebidas" Then
                        'Bebidas y Cocina solo podrán ingresar compras'}
                        MsgBox("Opcion Crepas")
                        Hide()
                        MesaPlantaBaja.Show()
                    Else
                        If nombre = "Cajero(a)" Then
                            'Cajeros tendrán acceso a cancelar ventas y compras, modificar ellas mismas'
                            MsgBox("Opcion Cajero")
                            Hide()
                            Pedidos.Show()
                        Else
                            If nombre = "Gerente" Then
                                'Acceso total'
                                MsgBox("Opcion Gerente")
                                Inicio.Show()
                                Hide()
                            End If

                        End If
                    End If
                End If
            Else
                MsgBox("Usuario y/o contraseña son incorrectos")

            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
