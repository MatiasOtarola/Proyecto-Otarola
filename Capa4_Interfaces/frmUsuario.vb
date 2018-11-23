Imports Capa3_Seguridad_Servicios
Imports Capa2_Logica
Imports Idioma_Selector
Public Class frmUsuario
    Dim accion As Integer
    Dim DVH, DVHUP, DVHBit As Long
    Dim IDUsuario As String
    Dim Usuarios(41) As Integer
    Dim Familias(41) As Integer
    Dim WithEvents Mi_DV As New Digito_Verificador

    Sub RegistrarAccionSuceso(ByVal Item As String, ByVal tabla As String) Handles Mi_DV.ErrorDV
        MiError.MostrarError("Error D.V. Item: " & Item & " Tabla/Table: " & tabla & " " & MiIdioma.DV & "", 1)
        Dim fecha As Date = Now
        Dim Descripcion As String = "Error D.V. Item: " & Item & " Tabla/Table: " & tabla & " "
        'alta de bitacora
        MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "Error D.V.", Descripcion, fecha, "1", 0)
        DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
        MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
    End Sub
    Private Sub frmAdminUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ayuda.ResetShowHelp(Me)
        Ayuda.HelpNamespace = Application.StartupPath + "\Ayuda.chm"
        Ayuda.SetHelpKeyword(Me, "AdministrarUsuarioEs")
        Ayuda.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)

        Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
        Pat.cargar_listbox(lstpatente, "select Nombre_Patente from Patente", "Patente")
        Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia", "Familia")

        btnbaja.Enabled = False
        btnAceptarPat.Enabled = False
        btnbaja2.Enabled = False
        btnAceptarPat2.Enabled = False
        lstfamilia.SelectionMode = SelectionMode.One
        lstpatente.SelectionMode = SelectionMode.One
        ltbusuario.SelectionMode = SelectionMode.One
        lstfamilia.SetSelected(0, False)
        lstpatente.SetSelected(0, False)
        ltbusuario.SetSelected(0, False)
    End Sub
    Private Sub frmUsuarios_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2) 'muestra un mensaje antes de salir del formulario, si acepta cierra
        If MiError.Seleccion = 1 Then
            Dim dvv, dvv2, dvv3 As Long
            Dim a, b, c As String
            dvv = Mi_DV.DVV("select sum(DVH) as dvv from Usuario", "dvv")
            a = Usu.RestaurarUsu("select Nombre_Tabla from DVV where Nombre_Tabla='Usuario'", "Nombre_Tabla")
            If a <> "" Then
                Usu.ConsultarUsu("update DVV set DVV='" & dvv & "' where Nombre_Tabla='Usuario'")
            Else
                Usu.ConsultarUsu("insert into DVV values('Usuario','" & dvv & "')")
            End If

            dvv2 = Mi_DV.DVV("select sum(DVH) as dvv from Usuario_Patente", "dvv")
            b = Usu.RestaurarUsu("select Nombre_Tabla from DVV where Nombre_Tabla='Usuario_Patente'", "Nombre_Tabla")
            If b <> "" Then
                Usu.ConsultarUsu("update DVV set DVV='" & dvv2 & "' where Nombre_Tabla='Usuario_Patente'")
            Else
                Usu.ConsultarUsu("insert into DVV values('Usuario_Patente','" & dvv2 & "')")
            End If

            dvv3 = Mi_DV.DVV("select sum(DVH) as dvv from Bitacora", "dvv")
            c = MiBitacora.BuscarTablaDVH("select Nombre_Tabla from DVV where Nombre_Tabla='Bitacora'", "Nombre_Tabla")
            If c <> "" Then
                MiBitacora.ActualizarDVH("update DVV set DVV='" & dvv3 & "' where Nombre_Tabla='Bitacora'")
            Else
                MiBitacora.ActualizarDVH("insert into DVV values('Bitacora','" & dvv3 & "')")
            End If
            MiError.MostrarError("D.V. OK", 1)
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub crearUsuario() ' método que permite crear un codigo de identifiacion nuevo
        txtCod_Usu.Text = Usu.crearUsuario()
    End Sub
    Private Function Validar_Campos() As Boolean 'valida los campos del formulario
        Dim i As Boolean = True
        If EsValido.Validar_Numericos_Positivos(txtCod_Usu.Text) = True Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Usuario, 1)
            i = False
        End If
        If EsValido.Validar_AlfaNumerico(txtNombreU.Text) = True Or txtNombreU.Text.Length > 50 Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Nombre, 1)
            i = False
        End If
        If EsValido.Validar_AlfaNumerico(txtContrasenaU.Text) = True Or txtContrasenaU.Text.Length > 50 Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Contrasena, 1)
            i = False
        End If
        If txtContrasenaU.Text <> txtContrasenaU2.Text Then
            MiError.MostrarError(MiIdioma.Error_Reing_Pass, 1)
            txtContrasenaU.Text = ""
            txtContrasenaU2.Text = ""
            i = False
        End If
        Return i
    End Function
    Private Sub Cambiar_Idioma() 'cambia el idioma a los elementos del formulario
        Me.Text = MiIdioma.ABMUsuario
        lblusu.Text = MiIdioma.ID
        lblDNI.Text = "D.N.I"
        lblNombreU.Text = MiIdioma.Nombre
        lblIdiomaU.Text = MiIdioma.Seleccionar
        lblMail.Text = MiIdioma.EMail
        lblContrasenaU.Text = MiIdioma.Contrasena
        lblContrasenaU2.Text = MiIdioma.Rein_Pass
        lblNick.Text = MiIdioma.Nick

        gbUsu.Text = MiIdioma.Usuario
        gbAdmUsu.Text = MiIdioma.ABMUsuario
        gbControls.Text = MiIdioma.Controles

        btnNuevo.Text = MiIdioma.Nuevo
        btnCancelarNuevo.Text = MiIdioma.Cancelar_Nuevo

        lblFamilias.Text = MiIdioma.Familia
        lblPatentes.Text = MiIdioma.Patentes
        lblUsuarios.Text = MiIdioma.Usuario

        btnAceptarPat.Text = MiIdioma.Aceptar
        btnAceptarPat2.Text = MiIdioma.Aceptar
        btnRegistrar.Text = MiIdioma.Registrar
        btnActualizar.Text = MiIdioma.Actualizar
        btnEliminar.Text = MiIdioma.Eliminar
        btnLimpiar.Text = MiIdioma.Limpiar
        btnBuscar.Text = MiIdioma.Buscar

        TTT.SetToolTip(txtCod_Usu, MiIdioma.Usuario)
        TTT.SetToolTip(txtDNI, MiIdioma.ttDNI)
        TTT.SetToolTip(txtNombreU, MiIdioma.ttNombreU)
        TTT.SetToolTip(txtContrasenaU, MiIdioma.Contrasena)
        TTT.SetToolTip(txtContrasenaU2, MiIdioma.Rein_Pass)


    End Sub
    Private Sub frmActivated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cambiar_Idioma() 'llama a la subfuncion para cambiar el idioma de los elementos del formulario
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            ActualizarUsu() ' llama a la subfuncion de actualizar el usuario
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            EliminarUsu() ' llama a la subfuncion de eliminar el usuario
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarUsu() ' llama a la subfuncion de limpiar el usuario
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            RegistrarUsu() ' llama a la subfuncion de registrar el usuario
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarUsu() ' llama a la subfuncion de buscar el usuario
    End Sub
    Private Sub LimpiarUsu() 'limpia los elementos del formulario

        Me.txtCod_Usu.Clear()
        Me.txtDNI.Clear()
        Me.txtMail.Clear()
        Me.txtNick.Clear()
        Me.txtNombreU.Clear()
        Me.txtContrasenaU.Clear()
        Me.txtContrasenaU2.Clear()
        crearUsuario()
    End Sub

    Private Sub EliminarUsu()
        Try 'intenta
            'variables requeridas
            Dim fecha As Date = Now
            Dim Descripcion As String = "USUARIO:Baja Código: " & txtCod_Usu.Text
            Usu.Baja(Me.txtCod_Usu.Text) 'baja de usuario
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "BAJA DE USUARIO", Descripcion, fecha, "2", 0)

            'alta de bitacora
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())

            MiError.MostrarError(MiIdioma.Exito, 1) 'mensaje de existo
            Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
            Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia", "Familia")
        Catch ex As Exception 'en caso de error, muestra una excepción
            MiError.MostrarError(MiIdioma.Err_Adm, 1)
            Dim fecha As Date = Now
            Dim Descripcion As String = "Error Modificación Usuario" & txtCod_Usu.Text
            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "Error Modificacion Usuario", Descripcion, fecha, "1", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
        End Try
    End Sub
    Private Sub RegistrarUsu()
        If Validar_Campos() = False Then 'valida los campos
            Exit Sub
        End If
        Try
            Dim fecha As Date = Now
            Dim Descripcion As String = "USUARIO:Alta,Código: " & txtCod_Usu.Text
            'alta de usuario
            Usu.Alta(Me.txtCod_Usu.Text, Me.txtNombreU.Text, El_Encriptador.EncriptarMD5(Me.txtContrasenaU.Text), Me.txtNick.Text, ckBloqueo.Checked, Me.txtDNI.Text, Me.txtMail.Text, CtrlIdioma1.Idioma, 0)
            Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")

            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, El_Encriptador.EncriptarMD5("ALTA DE USUARIO"), El_Encriptador.EncriptarMD5(Descripcion), fecha, El_Encriptador.EncriptarMD5("2"), 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())

            'actualiza el DVH
            DVH = Mi_DV.DVH("select * from Usuario where ID_Usuario=" & Me.txtCod_Usu.Text, "Usuario")
            Usu.ConsultarUsu("update Usuario set DVH=" & DVH & " where ID_Usuario=" & Me.txtCod_Usu.Text)
            'meustra mensaje de exito
            MiError.MostrarError(MiIdioma.Exito, 1)
            'simula precionar en cancelar nuevo
            Me.btnCancelarNuevo.PerformClick()
            Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
            Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia", "Familia")
        Catch ex As Exception 'en caso de error, meustra una excepcion
            MiError.MostrarError(MiIdioma.Err_Adm, 1)
            Dim fecha As Date = Now
            Dim Descripcion As String = "Error Alta Usuario" & txtCod_Usu.Text
            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "Error Alta Usuario", Descripcion, fecha, "1", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
        End Try
    End Sub

    Private Sub BuscarUsu() 'busca el usuario
        Try
            If IsNumeric(Me.txtCod_Usu.Text) And Me.txtCod_Usu.Text > 0 Then 'si es numeri y mayor a 0
                Dim DS As DataSet = Usu.AsignarPerfil(Me.txtCod_Usu.Text) 'busca el usuario y meustra los campos, desencriptando la contraseña
                Dim row As DataRow = DS.Tables(0).Rows(0)
                Me.txtCod_Usu.Text = DS.Tables(0).Rows(0).Item(0)
                Me.txtNombreU.Text = DS.Tables(0).Rows(0).Item(1)
                Me.txtContrasenaU.Text = El_Encriptador.DesencriptarMD5(DS.Tables(0).Rows(0).Item(2))
                Me.txtContrasenaU2.Text = El_Encriptador.DesencriptarMD5(DS.Tables(0).Rows(0).Item(2))
                Me.txtNick.Text = DS.Tables(0).Rows(0).Item(3)
                Me.ckBloqueo.Checked = Convert.ToBoolean(DS.Tables(0).Rows(0).Item(4))
                Me.txtDNI.Text = DS.Tables(0).Rows(0).Item(5)
                Me.txtMail.Text = DS.Tables(0).Rows(0).Item(6)
                Me.CtrlIdioma1.Cambiar_Seleccion(DS.Tables(0).Rows(0).Item(7))
            End If
        Catch ex As Exception 'en caso de error,meustra uan excepción
            MiError.MostrarError(MiIdioma.Err_Busqueda & MiIdioma.Cliente, 1)
        End Try 'limpia los listbox
    End Sub

    Private Sub ActualizarUsu()
        If Validar_Campos() = False Then 'valida los campos
            Exit Sub
        End If
        Try
            Dim fecha As Date = Now
            Dim Descripcion As String = "USUARIO:Modificación Código: " & txtCod_Usu.Text
            'modificacion de usuario
            Usu.Modificacion(Me.txtCod_Usu.Text, Me.txtNombreU.Text, El_Encriptador.EncriptarMD5(Me.txtContrasenaU.Text), Me.txtNick.Text, ckBloqueo.Checked, Me.txtDNI.Text, Me.txtMail.Text, CtrlIdioma1.Idioma, 0)
            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "MODIFICACION DE USUARIO", Descripcion, fecha, "2", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
            'alta de DVH
            DVH = Mi_DV.DVH("select * from Usuario where ID_Usuario=" & Me.txtCod_Usu.Text, "Usuario")
            Usu.ConsultarUsu("update Usuario set DVH=" & DVH & " where ID_Usuario=" & Me.txtCod_Usu.Text)
            MiError.MostrarError(MiIdioma.Exito, 1) 'muestra mensaje de exito
            Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
            Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia", "Familia")
        Catch ex As Exception 'en caso de error, meustra una excepcion
            MiError.MostrarError(MiIdioma.Err_Adm, 1)
            Dim fecha As Date = Now
            Dim Descripcion As String = "Error Modificación Usuario: " & txtCod_Usu.Text
            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "Error Modificación Usuario", Descripcion, fecha, "1", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
        End Try
    End Sub

    Private Sub BuscarTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarUsu() 'llama a la subfuncion para buscar el usuario
    End Sub

    Private Sub AgregarTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            RegistrarUsu() 'llama a la subfuncion para registrar el usuario
        End If
    End Sub

    Private Sub ModificarTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            ActualizarUsu() 'llama a la subfuncion para actualizar el usuario
        End If

    End Sub

    Private Sub EliminarTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            EliminarUsu() 'llama a la subfuncion para eliminar el usuario
        End If

    End Sub

    Private Sub LimpiarTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarUsu() 'llama a la subfuncion para limpiar el usuario
    End Sub
    Private Sub ActualizarBitacoraYDV()
        Try 'variables requeridas
            Dim fecha As Date = Now
            Dim Descripcion As String = ""

            If accion = 1 Then 'cambios usuario_familia
                Descripcion = "USU_FAM:Cambio Código: " & txtCod_Usu.Text
            End If

            If accion = 2 Then 'cambios usuario_patente
                Descripcion = "USU_PAT:Cambio Código: " & txtCod_Usu.Text
            End If

            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "USUARIO FAMILIA PATENTE", Descripcion, fecha, "2", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
        Catch ex As Exception 'en caso de error,muestra uan excpeción
            MiError.MostrarError(MiIdioma.Err_Adm, 1)
        End Try
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.btnRegistrar.Enabled = True 'nuevo usuario, deshabilita los elementos no desados
        Me.btnActualizar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnLimpiar.Enabled = False
        Me.btnBuscar.Enabled = False

        Call Me.LimpiarUsu() 'limpia el usuario
        Me.txtCod_Usu.Enabled = False
    End Sub

    Private Sub btnCancelarNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarNuevo.Click
        Me.btnRegistrar.Enabled = True 'habiltia lso elementos deshabiltiados
        Me.btnActualizar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnLimpiar.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.txtCod_Usu.Enabled = True
    End Sub
    Private Sub AyudaTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Help.ShowHelp(Me, Application.StartupPath & "\Ayuda.chm", HelpNavigator.TopicId, "290") 'muestra la ayuda al hacer click en el boton correspondiente
    End Sub
    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        Dim i As Integer
        Dim cod As Integer
        If cod = 0 Then
            For i = 0 To lstpatente.Items.Count - 1
                If lstpatente.GetItemChecked(i) Then
                    Usu.ConsultarUsu("insert into Usuario_Patente values(" & IDUsuario & "," & lstpatente.Items.IndexOf(lstpatente.Items.Item(i)) + 1 & "," & 1 & "," & 0 & ")")
                    DVHUP = Mi_DV.DVH("select * from Usuario_Patente where ID_Usuario=" & IDUsuario, "Usuario_Patente")
                    Usu.ConsultarUsu("update Usuario_Patente set DVH='" & DVHUP & "' where ID_Usuario=" & IDUsuario)
                    lstpatente.SetItemChecked(i, False)
                End If
            Next
        End If
    End Sub
    Private Sub btnalta2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta2.Click
        Dim i As Integer
        Dim cod As Integer
        If cod = 0 Then
            For i = 0 To lstfamilia.Items.Count - 1
                If lstfamilia.GetItemChecked(i) Then
                    Usu.ConsultarUsu("insert into Familia_Usuario values(" & IDUsuario & "," & lstfamilia.Items.IndexOf(lstfamilia.Items.Item(i)) + 1 & "," & lstfamilia.Items.IndexOf(lstfamilia.Items.Item(i)) + 1 & ")")
                    lstfamilia.SetItemChecked(i, False)
                End If
            Next
        End If
    End Sub
    Private Sub ltbusuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltbusuario.Click
        Dim i As Integer
        btnbaja.Enabled = True
        btnalta.Enabled = False
        btnAceptarPat.Enabled = False
        btnbaja2.Enabled = True
        btnalta2.Enabled = False
        btnAceptarPat2.Enabled = False

        For i = 0 To lstpatente.Items.Count - 1
            lstpatente.SetItemChecked(i, False)
        Next
        For i = 0 To lstfamilia.Items.Count - 1
            lstfamilia.SetItemChecked(i, False)
        Next
    End Sub
    Private Sub ltbusuario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltbusuario.DoubleClick
        Dim i As Integer
        btnbaja.Enabled = False
        btnAceptarPat.Enabled = True
        btnalta.Enabled = False
        btnbaja2.Enabled = False
        btnAceptarPat2.Enabled = True
        btnalta2.Enabled = False
        IDUsuario = Usu.RestaurarUsu("select ID_Usuario from Usuario where Nombre_Usuario LIKE '" & ltbusuario.Text & "%'", "ID_Usuario")
        Usu.Cargar_Listbox_Usuario_Patente(lstpatente, "select ID_Patente from Usuario_Patente where ID_Usuario=(select ID_Usuario from Usuario where Nombre_Usuario LIKE '" & ltbusuario.Text & "')", "Usuario_Patente")
        Usu.Cargar_Listbox_Usuario_Patente(lstfamilia, "select ID_Familia from Familia_Usuario where ID_Usuario=(select ID_Usuario from Usuario where Nombre_Usuario LIKE '" & ltbusuario.Text & "')", "Familia_Usuario")
        For i = 0 To lstpatente.Items.Count - 1
            Usuarios(i) = lstpatente.GetItemChecked(i)
        Next

        For i = 0 To lstfamilia.Items.Count - 1
            Familias(i) = lstfamilia.GetItemChecked(i)
        Next
    End Sub
    Private Sub btnAceptarPati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarPat.Click
        Dim i As Integer
        Dim cod As Integer
        For i = 0 To lstpatente.Items.Count - 1
            If lstpatente.GetItemChecked(i) <> Usuarios(i) Then
                If lstpatente.GetItemChecked(i) Then
                    lstpatente.SetSelected(i, True)
                    cod = Usu.RestaurarUsu("select ID_patente from Patente where Nombre_Patente LIKE'" & lstpatente.Text & "'", "ID_patente")
                    Usu.ConsultarUsu("insert into Usuario_Patente (ID_Usuario,ID_Patente, Estado, DVH) values (" & IDUsuario & "," & cod & ", 1, 0)")
                Else
                    lstpatente.SetSelected(i, True)
                    cod = Usu.RestaurarUsu("select ID_patente from Patente where Nombre_Patente LIKE'" & lstpatente.Text & "'", "ID_patente")
                    Usu.ConsultarUsu("delete from Usuario_Patente where ID_Usuario=(select ID_Usuario from Usuario where Nombre_Usuario LIKE'" & ltbusuario.Text & "') and ID_Patente=" & cod)
                End If
            End If
            lstpatente.SetItemChecked(i, False)
        Next
        MiError.MostrarError(MiIdioma.Exito, 1)
        Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
        btnAceptarPat.Enabled = False
        btnalta.Enabled = True
    End Sub
    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        Usu.ConsultarUsu("delete from Usuario_Patente where ID_Usuario=(select ID_Usuario from Usuario where Nombre_Usuario LIKE'" & ltbusuario.Text & "')")
        Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
    End Sub

    Private Sub btnAceptarPat2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarPat2.Click
        Dim i As Integer
        Dim cod As Integer
        For i = 0 To lstfamilia.Items.Count - 1
            If lstfamilia.GetItemChecked(i) <> Familias(i) Then
                If Me.lstfamilia.GetItemChecked(i) Then
                    Me.lstfamilia.SetSelected(i, True)
                    cod = Usu.RestaurarUsu("select ID_Familia from Familia where Nombre_Familia LIKE'" & lstfamilia.Text & "'", "ID_Familia")
                    Usu.ConsultarUsu("insert into Familia_Usuario (ID_Usuario,ID_Familia, Descripcion_familia_usuario) values (" & IDUsuario & "," & cod & ",'" & lstfamilia.Text & "')")
                Else
                    Me.lstfamilia.SetSelected(i, True)
                    cod = Usu.RestaurarUsu("select ID_Familia from Familia where Nombre_Familia  LIKE'" & lstfamilia.Text & "'", "ID_Familia")
                    Usu.ConsultarUsu("delete from Familia_Usuario where ID_Usuario=(select ID_Usuario from Usuario where Nombre_Usuario LIKE'" & ltbusuario.Text & "') and ID_Familia=" & cod)
                End If
            End If
            lstfamilia.SetItemChecked(i, False)
        Next
        MiError.MostrarError(MiIdioma.Exito, 1)
        Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
        btnAceptarPat2.Enabled = False
        btnalta2.Enabled = True
    End Sub
    Private Sub btnbaja2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja2.Click
        Usu.ConsultarUsu("delete from Familia_Usuario where ID_Usuario=(select ID_Usuario from Usuario where Nombre_Usuario LIKE'" & ltbusuario.Text & "')")
        Usu.Cargar_Listbox_Usuario_Familia(ltbusuario, "select Nombre_Usuario from Usuario order by ID_Usuario", "Usuario")
    End Sub

End Class