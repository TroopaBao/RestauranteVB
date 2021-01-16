Imports ADODB

Public Class Empleado
    Dim edoempleado As Integer
    Dim idempleado As Integer
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Close()
        Inicio.Show()
    End Sub

    Private Sub insertar_Click(sender As Object, e As EventArgs) Handles insertar.Click
        ban = New ADODB.Parameter
        Dim cvedit1, entrada As Integer
        cvedit1 = 0
        entrada = 0

        If (textboxnombre.Text = "") Then
            MsgBox("El campo de nombre de empleado está vacío")
        Else
            If (textboxcargo.Text = "") Then
                MsgBox("El campo de Cargo está vacío ")
            Else
                If (textboxcontra.Text = "") Then
                    MsgBox("El campo Contraseña está vacío ")
                Else
                    entrada = 1
                End If
            End If
        End If

        If (entrada = 1) Then
            comando = New ADODB.Command
            With comando
                .CommandText = "insEmpleados"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Append(.CreateParameter("0", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 40, textboxnombre.Text))
                .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, textboxcargo.Text))
                .Parameters.Append(.CreateParameter("2", DataTypeEnum.adDecimal, ParameterDirectionEnum.adParamInput, , 0.00))
                .Parameters.Append(.CreateParameter("3", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 30, textboxcontra.Text))
                .Parameters.Append(.CreateParameter("4", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))

                .ActiveConnection = conexion
                .Execute()
                ban.Value = .Parameters(4).Value
            End With
            If ban.Value = 1 Then
                MsgBox("Ese nombre de empleado ya existe")
            Else
                If ban.Value = 2 Then
                    MsgBox("Ese nombre de empleado ya existe, pero está dado de baja temporal")
                Else
                    If ban.Value = 3 Then
                        MsgBox("El campo del nombre de empleado está vacío")
                    Else
                        If ban.Value = 4 Then
                            MsgBox("El campo de cargo de área está vacío")
                        Else
                            If ban.Value = 5 Then
                                MsgBox("Cargo de Área; Solo 6 opciones: Gerente, Caja, Mesero(a), Cocina(Crepas), Cocina(Horno), Bebidas")
                            Else
                                If ban.Value = 6 Then
                                    MsgBox("El campo de pago de caja debe ser mayor o igual a 0")
                                Else
                                    If ban.Value = 7 Then
                                        MsgBox("El campo de contraseña no puede estar vacío")
                                    Else
                                        consql = ("select MAX(idempleado) from empleados")
                                        consulta = New ADODB.Recordset
                                        consulta = conexion.Execute(consql)

                                        cvedit1 = consulta.Fields(0).Value
                                        MsgBox("Id de Empleado: " & cvedit1 & ". Inserción Correcta")
                                        textboxnombre.Text = ""
                                        textboxcargo.Text = ""
                                        textboxcontra.Text = ""
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click

        If (textboxnombre.Text <> "" Or textboxid.Text <> "") Then
            'Es porque alguno de los 2 campos tiene algo escrito'
            If (RadioButtonid.Checked = True) Then
                consulta1 = New ADODB.Recordset
                consulta1 = conexion.Execute("select * from Empleados where idempleado=" & textboxid.Text)
            End If
            If (RadioButtonnombre.Checked = True) Then
                consulta1 = New ADODB.Recordset
                consulta1 = conexion.Execute("select * from Empleados where nombrempleado='" & textboxnombre.Text & "'")
            End If

            If consulta1.EOF Then
                textboxid.Text = consulta1.Fields(0).Value
                textboxnombre.Text = consulta1.Fields(1).Value
                textboxcargo.Text = consulta1.Fields(2).Value
                textboxcaja.Text = consulta1.Fields(3).Value
                textboxcontra.Text = consulta1.Fields(4).Value
                edoempleado = consulta1.Fields(5).Value
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
                Labelclave.Visible = True
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

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        Dim cvedit1, entrada As Integer
        cvedit1 = 0
        entrada = 0

        If (textboxnombre.Text = "") Then
            MsgBox("El campo de nombre de empleado está vacío")
        Else
            If (textboxcargo.Text = "") Then
                MsgBox("El campo de Cargo está vacío ")
            Else
                If (textboxcontra.Text = "") Then
                    MsgBox("El campo Contraseña está vacío ")
                Else
                    If (textboxcaja.Text = "") Then
                        MsgBox("El campo de Saldo está vacío")
                    Else
                        entrada = 1
                    End If
                End If
            End If
        End If

        If (entrada = 1) Then
            comando = New ADODB.Command
            With comando
                .CommandText = "actEmpleados"
                .CommandType = CommandType.StoredProcedure
                .Parameters.Append(.CreateParameter("0", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , idempleado))
                .Parameters.Append(.CreateParameter("1", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 40, textboxnombre.Text))
                .Parameters.Append(.CreateParameter("2", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, textboxcargo.Text))
                .Parameters.Append(.CreateParameter("3", DataTypeEnum.adDecimal, ParameterDirectionEnum.adParamInput, , Convert.ToDecimal(textboxcaja.Text)))
                .Parameters.Append(.CreateParameter("4", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 30, textboxcontra.Text))
                .Parameters.Append(.CreateParameter("5", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, , edoempleado))
                .Parameters.Append(.CreateParameter("6", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamOutput, , 0))
                .ActiveConnection = conexion
                .Execute()
                ban.Value = .Parameters(6).Value
            End With
            If ban.Value = 1 Then
                MsgBox("Ese nombre de empleado ya existe")
            Else
                If ban.Value = 2 Then
                    MsgBox("Ese nombre de empleado ya existe, pero está dado de baja temporal")
                Else
                    If ban.Value = 3 Then
                        MsgBox("El campo del nombre de empleado está vacío")
                    Else
                        If ban.Value = 4 Then
                            MsgBox("El campo de cargo de área está vacío")
                        Else
                            If ban.Value = 5 Then
                                MsgBox("Cargo de Área; Solo 6 opciones: Gerente, Caja, Mesero(a), Cocina(Crepas), Cocina(Horno), Bebidas")
                            Else
                                If ban.Value = 6 Then
                                    MsgBox("El campo de pago de caja debe ser mayor o igual a 0")
                                Else
                                    If ban.Value = 7 Then
                                        MsgBox("El campo de contraseña no puede estar vacío")
                                    Else

                                        MsgBox("Modificación realizada correctamente")
                                        textboxnombre.Text = ""
                                        textboxcargo.Text = ""
                                        textboxcontra.Text = ""
                                        textboxid.Text = ""
                                        textboxcaja.Text = ""
                                        radiobuttonalta.Checked = False
                                        radiobuttonbaja.Checked = False

                                        modificar.Enabled = False
                                        textboxcaja.Enabled = False
                                        textboxcargo.Enabled = False
                                        textboxcontra.Enabled = False
                                        radiobuttonalta.Enabled = False
                                        radiobuttonbaja.Enabled = False
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub radiobuttonalta_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonalta.CheckedChanged
        radiobuttonbaja.Checked = False
        radiobuttonalta.Checked = True
    End Sub

    Private Sub radiobuttonbaja_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonbaja.CheckedChanged
        radiobuttonbaja.Checked = True
        radiobuttonalta.Checked = False
    End Sub
End Class