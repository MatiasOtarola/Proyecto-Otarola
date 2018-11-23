Public Class frmError
    Public CantidadBotones As Integer 'variables para el mensaje
    Public Seleccion As Integer
    Public Mensaje As String
    Private Sub frmError_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cambiar_Idioma() 'cambia el idioma
        btnCancelar.Visible = True 'todos los botones ibsibles
        btnAceptar.Visible = True
        btnAceptar2.Visible = False
        If CantidadBotones = 2 Then ' si son dos botones muestra 2
        ElseIf CantidadBotones = 1 Then ' si es 1, muestra solo aceptar
            btnCancelar.Visible = False
            btnAceptar.Visible = False
            btnAceptar2.Visible = True
        ElseIf CantidadBotones = 0 Then 'si no hay ninguno, no muestra nada
            btnCancelar.Visible = False
            btnAceptar.Visible = False
            btnAceptar2.Visible = False
        End If
        txtMensaje.Text = Mensaje
    End Sub
    Public Sub MostrarError(ByVal elError, ByVal MiBtn)
        Mensaje = elError 'permite mostrar el mensaje
        CantidadBotones = MiBtn 'la cantidad de botones
        Me.ShowDialog() ' lo muestra
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Seleccion = 1 'actua como si la seleccion fuera 1 
        Me.Close()
    End Sub
    Private Sub btnAceptar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar2.Click
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Seleccion = 2 'actua como si la seleccion fuera 2 
        Me.Close()
    End Sub
    Private Sub Cambiar_Idioma() 'cambia el idioma de los botones del formulario
        btnCancelar.Text = MiIdioma.Cancelar
        btnAceptar.Text = MiIdioma.Aceptar
        btnAceptar.Text = MiIdioma.Aceptar
        Me.Text = MiIdioma.Descripcion
    End Sub
End Class