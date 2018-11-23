Public Class vventa
    Dim Idventa, Idcliente As Integer
    Dim Fecha_venta As Date
    Dim Tipo, DNI As String
    Dim Nro_Factura As Integer


    Public Property _Idventa
        Get
            Return Idventa
        End Get
        Set(ByVal value)
            Idventa = value
        End Set
    End Property

    Public Property _Idcliente
        Get
            Return Idcliente
        End Get
        Set(ByVal value)
            Idcliente = value
        End Set
    End Property

    Public Property _Fecha_venta
        Get
            Return Fecha_venta
        End Get
        Set(ByVal value)
            Fecha_venta = value
        End Set
    End Property

    Public Property _tipo
        Get
            Return Tipo
        End Get
        Set(ByVal value)
            Tipo = value
        End Set
    End Property

    Public Property _DNI
        Get
            Return DNI
        End Get
        Set(ByVal value)
            DNI = value
        End Set
    End Property
    Public Property _Nro_Factura
        Get
            Return Nro_Factura
        End Get
        Set(ByVal value)
            Nro_Factura = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal Idventa As Integer, ByVal Idcliente As Integer, ByVal Fecha_venta As Date, ByVal Tipo As String, ByVal DNI As String, ByVal Nro_Factura As Integer)
        _Idventa = Idventa
        _Idcliente = Idcliente
        _Fecha_venta = Fecha_venta
        _tipo = Tipo
        _DNI = DNI
        _Nro_Factura = Nro_Factura
    End Sub
End Class
