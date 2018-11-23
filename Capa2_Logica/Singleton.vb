Public Class Singleton
    Private Shared mInstance As Singleton

    Private mFecha As String 'variable utilizada

    ' Constructor
    Public Sub New()
        mFecha = Now.ToShortDateString 'convierte la variable en fecha corta
    End Sub
    Public Shared Function GetInstance() As Singleton 'crea la funcion compartida que captura la instancai utilizando en el patron singleton
        If mInstance Is Nothing Then 'si la instnacia en nula
            mInstance = New Singleton() 'devuelve la nueva instancia
        End If
        Return mInstance 'retorno de instancia
    End Function
    Public Function GetDate() As String 'funcion que devuelve la fecha asignada
        Return mFecha 'devolucion de la variable
    End Function
End Class
