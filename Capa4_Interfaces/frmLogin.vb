Imports Capa3_Seguridad_Servicios
Imports Capa2_Logica
Imports Idioma_Selector
Public Class frmLogin

     Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'si es valido el usuario y la contraseña
        If Usu.ValidarContraseña(UsernameTextBox.Text, El_Encriptador.EncriptarMD5(PasswordTextBox.Text)) Then

            Dim DS As DataSet
            DS = Ingreso.SeleccionarUsuario(UsernameTextBox.Text) 'busca el maximo de ID de usuario
            frmMenu.txtLog.Text = DS.Tables(0).Rows(0).Item("ID_Usuario") ' y lo agrega al formulario MDIPrincipal

            Dim log As Integer
            log = Ingreso.MAXIMO

            Dim FechaHoy As DateTime 'toma la fecha del patron singleton
            Dim Hoy As New Singleton
            FechaHoy = Hoy.GetDate()

            Dim FechaHora As DateTime = Now
            'alta de un nuevo loggin
            Ingreso.HabilitarLogin(frmMenu.txtLog.Text, "LOGIN", "LOGIN SATISFACTORIO", FechaHoy, "3", 0)
            Try 'intenta
                'variables requeridas
                Dim fecha As Date = Now
                Dim Descripcion As String = "LOGIN:Ingreso Nombre: " & UsernameTextBox.Text

                'alta de bitacora
                MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "LOGIN USER", Descripcion, fecha, "3", 0) 'alta a la bitacora
            Catch ex As Exception 'en caso de error,muestra una excepción
                MiError.MostrarError(MiIdioma.Err_Adm & " " & MiIdioma.Bitacora, 1)
            End Try
            DialogResult = Windows.Forms.DialogResult.OK 'envia resultado ok al formulario MDIPrincipal
            Close() 'cieraa
        Else
            Select Case CtrlIdioma1.Idioma 'segun el idioma muestra un mensaje
                Case 1 'idioma español
                    MsgBox("Usuario o Contraseña Incorrecto", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atención")
                Case 2 ' idioma inglés
                    MsgBox("Incorrect Username or Password", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Attention")
            End Select
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'cierra la aplicacion completa
        frmMenu.Close()
        Me.Close()
    End Sub
    Private Sub CtrlIdioma_IdiomaChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CtrlIdioma1.IdiomaChanged
        Select Case CtrlIdioma1.Idioma 'camia el idioma de lso textos segun la seleccion del usuario
            Case 1 'idioma español
                UsernameLabel.Text = "Usuario:"
                PasswordLabel.Text = "Contraseña:"
                OK.Text = "Aceptar"
                Cancel.Text = "Salir"
            Case 2 ' idioma inglés
                UsernameLabel.Text = "User:"
                PasswordLabel.Text = "Password:"
                OK.Text = "Accept"
                Cancel.Text = "Exit"
        End Select
    End Sub


    Private Sub PasswordTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasswordTextBox.LostFocus
        Try
            Dim DS As DataSet
            DS = MiIdioma.Leyenda(UsernameTextBox.Text)
            Me.CtrlIdioma1.Cambiar_Seleccion(DS.Tables(0).Rows(0).Item("Idioma"))
        Catch ex As Exception
            MsgBox("Usuario Incorrecto // Incorrect Username", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atención // Attention")
        End Try

    End Sub
End Class