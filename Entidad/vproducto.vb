Public Class vproducto
    Dim Idproducto, Idcategoria As Integer
    Dim Nombre_Producto, Descripcion As String
    Dim Stock, Precio_compra, Precio_venta As Double
    Dim Imagen() As Byte
    Public Property _Idproducto
        Get
            Return Idproducto
        End Get
        Set(ByVal value)
            Idproducto = value
        End Set
    End Property
    Public Property _Idcategoria
        Get
            Return Idcategoria
        End Get
        Set(ByVal value)
            Idcategoria = value
        End Set
    End Property
    Public Property _Nombre_Producto
        Get
            Return Nombre_Producto
        End Get
        Set(ByVal value)
            Nombre_Producto = value
        End Set
    End Property

    Public Property _Descripcion
        Get
            Return Descripcion
        End Get
        Set(ByVal value)
            Descripcion = value
        End Set
    End Property

    Public Property Precio_comprap
        Get
            Return Precio_compra
        End Get
        Set(ByVal value)
            Precio_compra = value
        End Set
    End Property

    Public Property precio_ventap
        Get
            Return Precio_venta
        End Get
        Set(ByVal value)
            Precio_venta = value
        End Set
    End Property
    Public Property _Imagen
        Get
            Return Imagen
        End Get
        Set(ByVal value)
            Imagen = value
        End Set
    End Property
    Public Property _stock
        Get
            Return Stock
        End Get
        Set(ByVal value)
            Stock = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal Idproducto As Integer, ByVal Idcategoria As Integer, ByVal Nombre_Producto As String, ByVal Descripcion As String, ByVal Stock As Double, ByVal Precio_compra As Double, ByVal Precio_venta As Double, ByVal Imagen() As Byte)
        _Idproducto = Idproducto
        _Idcategoria = Idcategoria
        _Nombre_Producto = Nombre_Producto
        _Descripcion = Descripcion
        _stock = Stock
        Precio_comprap = Precio_compra
        precio_ventap = Precio_venta
        _Imagen = Imagen
    End Sub
End Class
