Public Interface IUsuario
    Function ObtenerNombre() As String 'funcion para obtener el nombre del empleado
    Sub DarNombre(ByVal Nombre As String) 'funcion que introduce la variable del nombre
    Sub Imprimir() 'imprime el nombre del empleado
End Interface
