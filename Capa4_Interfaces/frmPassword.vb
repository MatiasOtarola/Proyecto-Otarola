Imports Capa3_Seguridad_Servicios
Imports Capa2_Logica

Public Class frmPassword
    Dim NuevaContraseña As String
    Dim WithEvents Mi_DV As New Digito_Verificador
    Dim DVH, DVHBIT As Long

    Sub RegistrarAccionSuceso(ByVal Item As String, ByVal tabla As String) Handles Mi_DV.ErrorDV
        MiError.MostrarError("Error D.V. Item: " & Item & " Tabla/Table: " & tabla & " " & MiIdioma.DV & "", 1)
    End Sub
    Private Sub Cambiar_Idioma() 'cambia idioma
        Me.Text = MiIdioma.Contrasena
        lblPasswordOld.Text = MiIdioma.Pass_Vieja
        lblPasswordNew.Text = MiIdioma.Pass_Nueva
        lblPasswordNew2.Text = MiIdioma.Rein_Pass
        gbDetails.Text = MiIdioma.Contrasena
        btnAceptar.Text = MiIdioma.Aceptar
        btnCancelar.Text = MiIdioma.Cancelar
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close() 'cierra
    End Sub
    Private Sub frmPassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2) ' muestra mensaje antes de cerrar
        If MiError.Seleccion = 1 Then
            Dim dvv As Long
            Dim a As String
            dvv = Mi_DV.DVV("select sum(DVH) as dvv from Usuario", "dvv")
            a = Usu.RestaurarUsu("select Nombre_Tabla from dvv where Nombre_Tabla='Usuario'", "Nombre_Tabla")
            If a <> "" Then
                Usu.ConsultarUsu("update dvv set dvv='" & dvv & "' where Nombre_Tabla='Usuario'")
            Else
                Usu.ConsultarUsu("insert into Nombre_Tabla values('Usuario','" & dvv & "')")
            End If
            MiError.MostrarError("D.V. OK", 1)
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Validar_Campos() = False Then 'valida campos
            Exit Sub
        End If
        If txtPasswordNew.Text = txtPasswordNew2.Text Then ' si son iguales ambos password nuevos
            MiError.MostrarError(MiIdioma.OK_Password, 2) 'pregunta 
            If MiError.Seleccion = 1 Then 'si acepeta
                NuevaContraseña = El_Encriptador.EncriptarMD5(txtPasswordNew.Text) 'encripta
                Usu.ModificarContraseña(frmMenu.txtLog.Text, NuevaContraseña) 'modifica la contraseña
                DVH = Mi_DV.DVH("select * from Usuario where ID_Usuarios=" & frmMenu.txtLog.Text, "Usuario")
                Usu.ConsultarUsu("update Usuario set DVH=" & DVH & " where ID_Usuario=" & frmMenu.txtLog.Text)
                Try 'variables requeridas
                    Dim fecha As Date = Now
                    Dim Descripcion As String = "USUARIO:Modificación Contraseña Código: " & frmMenu.txtLog.Text
                    'alta de bitacora
                    MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "MODIFICA CONTRASEÑA", Descripcion, fecha, "2", 0)
                    DVHBIT = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
                    MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBIT & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
                Catch ex As Exception
                    MiError.MostrarError(MiIdioma.Err_PassV, 1)
                End Try
            Else
                Exit Sub
            End If
        Else
            MiError.MostrarError(MiIdioma.Err_PassN, 1)
        End If
    End Sub
    Private Function Validar_Campos() As Boolean 'valida los campos
        Dim i As Boolean = True
        If EsValido.Validar_AlfaNumerico(txtPasswordNew.Text) = True Or txtPasswordNew.Text.Length > 50 Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Pass_Nueva, 1)
            i = False
        End If
        If EsValido.Validar_AlfaNumerico(txtPasswordNew2.Text) = True Or txtPasswordNew2.Text.Length > 50 Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Pass_Nueva, 1)
            i = False
        End If
        Return i
    End Function
    Private Sub frmActivated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cambiar_Idioma() 'cambia el idioma
    End Sub

    Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'muestra la ayuda segun este formulario (solo con F1)
        Ayuda.ResetShowHelp(Me)
        Ayuda.HelpNamespace = Application.StartupPath & "\Ayuda.chm"
        Ayuda.SetHelpKeyword(Me, "Contra")
        Ayuda.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
    End Sub
End Class