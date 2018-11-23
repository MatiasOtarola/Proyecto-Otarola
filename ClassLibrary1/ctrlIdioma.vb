Public Class ctrlIdioma

    Public Event IdiomaChanged As EventHandler

    Dim _idioma As Integer
    Dim _Descripcion As String
    Public Property Idioma() As Integer
        Get
            Return _idioma
        End Get
        Set(ByVal value As Integer)
            _idioma = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _idioma = 1
    End Sub
    Public Sub ctrlIdioma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pbArgentina.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        pbUK.BorderStyle = Windows.Forms.BorderStyle.None
        _idioma = 2
    End Sub
    Private Sub pbArgentina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbArgentina.Click
        pbArgentina.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        pbUK.BorderStyle = Windows.Forms.BorderStyle.None
        _idioma = 1
        RaiseEvent IdiomaChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub pbUK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbUK.Click
        pbArgentina.BorderStyle = Windows.Forms.BorderStyle.None
        pbUK.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        _idioma = 2
        RaiseEvent IdiomaChanged(Me, EventArgs.Empty)
    End Sub
  
    Public Sub Cambiar_Seleccion(ByVal ID_Idioma As Integer)
        Select Case ID_Idioma
            Case 1
                pbArgentina.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
                pbUK.BorderStyle = Windows.Forms.BorderStyle.None
            Case 2
                pbArgentina.BorderStyle = Windows.Forms.BorderStyle.None
                pbUK.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        End Select
    End Sub

End Class
