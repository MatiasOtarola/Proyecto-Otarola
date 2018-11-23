Public Class Proxy
    Implements IUsuario 'hereda de la interfaz IEmpleado
    Private UsuIngreso As Usuario 'nuevo ingreso empleado
    Public Sub Imprimir() Implements IUsuario.Imprimir
        If UsuIngreso Is Nothing Then ' si es nulo
            UsuIngreso = New Usuario() 'nueva instancia de IngresoEmpleado
        End If
        UsuIngreso.Imprimir() 'imprime el empleado
    End Sub

    Public Function ObtenerNombre() As String Implements IUsuario.ObtenerNombre
        If UsuIngreso Is Nothing Then ' si es nulo
            UsuIngreso = New Usuario() 'nueva instancia de IngresoEmpleado
        End If
        Return UsuIngreso.ObtenerNombre() 'obtiene el nombre del empleado
    End Function

    Public Sub DarNombre(ByVal Nombre As String) Implements IUsuario.DarNombre
        If UsuIngreso Is Nothing Then ' si es nulo
            UsuIngreso = New Usuario() 'nueva instancia de IngresoEmpleado
        End If
        UsuIngreso.DarNombre(Nombre) 'obtiene el nombre del empleado
    End Sub
End Class
