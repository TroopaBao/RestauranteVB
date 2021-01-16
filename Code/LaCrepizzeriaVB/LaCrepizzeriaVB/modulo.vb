Module modulo
    Public consulta As ADODB.Recordset

    Public consulta1 As ADODB.Recordset
    Public consulta2 As ADODB.Recordset
    Public consulta3 As ADODB.Recordset
    Public consulta4 As ADODB.Recordset
    Public consulta5 As ADODB.Recordset
    Public ban As ADODB.Parameter
    Public comando As ADODB.Command
    Public conexion As ADODB.Connection
    Public consql As String
    Public conectado As Boolean

    Public Sub conectar()
        conexion = New ADODB.Connection
        conectado = False
        With conexion
            .Provider = "sqloledb"
            .ConnectionString = "INITIAL CATALOG=LaCrepizzeria; SERVER=HEISENBERG; INTEGRATED SECURITY=SSPI; PERSIST SECURITY INFO=TRUE"
            Try
                .Open()
                MessageBox.Show("Conexión Correcta")
                conectado = True
            Catch ex As Exception
                MessageBox.Show("Conexión Fallida: " + ex.ToString)
            End Try
        End With
    End Sub
End Module
