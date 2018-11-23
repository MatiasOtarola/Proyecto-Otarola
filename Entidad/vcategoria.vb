Public Class vcategoria
    Dim Idcategoria As Integer
    Dim Nombre_categoria As String
    Public Property _IDcategoria As Integer
        Get
            Return Idcategoria
        End Get
        Set(ByVal value As Integer)
            Idcategoria = value
        End Set
    End Property
    Public Property Nombrecategoria() As String
        Get
            Return Nombre_categoria
        End Get
        Set(ByVal value As String)
            Nombre_categoria = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal Idcategoria As Integer, ByVal Nombre_categoria As String)
        _IDcategoria = Idcategoria
        Nombrecategoria = Nombre_categoria
    End Sub
End Class
