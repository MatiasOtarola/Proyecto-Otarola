Public Class vcliente
    Private Idcliente As Integer
    Private Nombre As String
    Private Apellido As String
    Private Mail As String
    Private DNI As String
    Private DVH As Integer

    Public Property ID As Integer
        Get
            Return Idcliente
        End Get
        Set(value As Integer)
            Idcliente = value
        End Set
    End Property

    Public Property _Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property _Apellido As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property

    Public Property _Mail As String
        Get
            Return Mail
        End Get
        Set(value As String)
            Mail = value
        End Set
    End Property

    Public Property _DNI As String
        Get
            Return DNI
        End Get
        Set(value As String)
            DNI = value
        End Set
    End Property

    Public Property _DVH As String
        Get
            Return DVH
        End Get
        Set(value As String)
            DVH = value
        End Set
    End Property

    'CONSTRUCTORES'
    Public Sub New()

    End Sub

    Public Sub New(ByVal Idcliente As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, ByVal Direccion As String, ByVal DNI As String)
        ID = Idcliente
        _Nombre = Nombre
        _Apellido = Apellido
        _Mail = Mail
        _DVH = DVH
        _DNI = DNI

    End Sub
End Class
