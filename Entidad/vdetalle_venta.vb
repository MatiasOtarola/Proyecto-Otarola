Public Class vdetalle_venta
    Dim Iddetalle_Venta, Idventa, Idproducto As Integer
    Dim Precio_unitario, Cantidad As Double
    Public Property _Iddetalle_venta
        Get
            Return Iddetalle_Venta
        End Get
        Set(ByVal value)
            Iddetalle_Venta = value
        End Set
    End Property

    Public Property _Idventa
        Get
            Return Idventa
        End Get
        Set(ByVal value)
            Idventa = value
        End Set
    End Property
    Public Property _Idproducto
        Get
            Return Idproducto
        End Get
        Set(ByVal value)
            Idproducto = value
        End Set
    End Property
    Public Property _Precio_unitario
        Get
            Return Precio_unitario
        End Get
        Set(ByVal value)
            Precio_unitario = value
        End Set
    End Property
    Public Property _Cantidad
        Get
            Return Cantidad
        End Get
        Set(ByVal value)
            Cantidad = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal Iddetalle_venta As Integer, ByVal Idventa As Integer, ByVal Idproducto As Integer, ByVal Precio_unitario As Double, ByVal Cantidad As Double)
        _Iddetalle_venta = Iddetalle_venta
        _Idventa = Idventa
        _Idproducto = Idproducto
        _Precio_unitario = Precio_unitario
        _Cantidad = Cantidad
    End Sub
End Class
