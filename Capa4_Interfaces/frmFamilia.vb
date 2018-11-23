Option Explicit On
Imports Capa3_Seguridad_Servicios
Public Class frmFamilia
    Dim AdminPatFam As Integer = 0
    Dim IDFamilia(41) As Integer
    Dim DVH, DVHBit As Long
    Dim IDFamilias As String
    Dim WithEvents Mi_DV As New Digito_Verificador
    Sub RegistrarAccionSuceso(ByVal Item As String, ByVal tabla As String) Handles Mi_DV.ErrorDV
        MiError.MostrarError("Error D.V. Item: " & Item & " Tabla/Table: " & tabla & " " & MiIdioma.DV & "", 1)
        Dim fecha As Date = Now
        Dim Descripcion As String = "Error D.V. Item: " & Item & " Tabla/Table: " & tabla & " "
        'alta de bitacora
        MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "Error D.V", Descripcion, fecha, "1", 0)
        DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
        MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
    End Sub
    Private Sub frmABMFamilia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'muestra la ayuda segun el formulario
        Ayuda.ResetShowHelp(Me)
        Ayuda.HelpNamespace = Application.StartupPath & "\Ayuda.chm"
        Ayuda.SetHelpKeyword(Me, "Familia")
        Ayuda.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)

        ActualizarDS()
        CambiarNombreDG()

        Me.btnbaja.Enabled = False
        Me.btnAceptarPat.Enabled = False

        Pat.cargar_listbox(lstpatente, "select Nombre_patente from Patente", "Patente")
        Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_familia from Familia order by ID_Familia", "Familia")

        lstpatente.SelectionMode = SelectionMode.One
        lstfamilia.SelectionMode = SelectionMode.One
        lstfamilia.SetSelected(1, False)
        lstpatente.SetSelected(1, False)
    End Sub

    Private Sub CrearFamilia()
        Me.txtID_Familia.Text = Fam.crearNuevaFamilia()
    End Sub

    Private Sub frmFamilia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2) ' pregunta antes de cerra, si acpeta se cierra
        If MiError.Seleccion = 1 Then
            Dim dvv, dvv2 As Long
            Dim a, b As String
            dvv = Mi_DV.DVV("select sum(DVH) as dvv from Patente_Familia", "dvv")
            a = Fam.Cargar_Listbox_Usuarios("select Nombre_Tabla from DVV where Nombre_Tabla='Patente_Familia'", "Nombre_Tabla")
            If a <> "" Then
                Fam.AsignarUsuario("update DVV set DVV='" & dvv & "' where Nombre_Tabla='Patente_Familia'")
            Else
                Fam.AsignarUsuario("insert into DVV values('Patente_Familia','" & dvv & "')")
            End If

            dvv2 = Mi_DV.DVV("select sum(DVH) as dvv from Bitacora", "dvv")
            b = MiBitacora.BuscarTablaDVH("select Nombre_Tabla from DVV where Nombre_Tabla='Bitacora'", "Nombre_Tabla")
            If b <> "" Then
                MiBitacora.ActualizarDVH("update DVV set DVV='" & dvv2 & "' where Nombre_Tabla='Bitacora'")
            Else
                MiBitacora.ActualizarDVH("insert into DVV values('Bitacora','" & dvv2 & "')")
            End If
            MiError.MostrarError("D.V. OK", 1)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Cambiar_Idioma() 'cambia el dioma de los elementos del fomulario
        Me.Text = MiIdioma.ABMFamilia
        gbfam.Text = MiIdioma.Familia
        gbfam2.Text = MiIdioma.ABMFamilia & " / " & MiIdioma.Patentes
        gbControls.Text = MiIdioma.Controles
        btnRegistrar.Text = MiIdioma.Registrar
        btnLimpiar.Text = MiIdioma.Limpiar
        btnEliminar.Text = MiIdioma.Eliminar
        btnActualizar.Text = MiIdioma.Actualizar
        btnBuscar.Text = MiIdioma.Buscar
        lblID.Text = MiIdioma.ID
        lblDescri.Text = MiIdioma.Descripcion
        lblfamilia_patente.Text = MiIdioma.Patentes
        lblFamilia.Text = MiIdioma.Familia
        btnNuevo.Text = MiIdioma.Nuevo
        btnCancelarNuevo.Text = MiIdioma.Cancelar_Nuevo
        btnAceptarPat.Text = MiIdioma.Aceptar
        lblNombre.Text = MiIdioma.Nombre
        TTT.SetToolTip(Me.txtID_Familia, MiIdioma.ID)
        TTT.SetToolTip(Me.txtDescripcion, MiIdioma.Descripcion)

    End Sub
    Private Function Validar_Campos() As Boolean 'valida los campos
        Dim i As Boolean = True
        If EsValido.Validar_AlfaNumerico(txtDescripcion.Text) = True Or txtDescripcion.Text.Length > 50 Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Descripcion, 1)
            i = False
        End If
        Return i
    End Function
    Private Sub frmActivated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cambiar_Idioma() 'llama a la subfuncion del idioma
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            RegistrarFamilia() 'llama a la subfuncion de registrar familia
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarFamilia() 'busca familia
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            EliminarFamilia() 'llama a la subfuncion de eliminar familia
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            ActualizarFamilia() 'llama a la subfuncion de actualzia familia
        End If
    End Sub


    Private Sub BuscarFamilia() 'busca la familia
        Try
            Dim Familia As New Familia
            If txtID_Familia.Text <> "" Then
                If IsNumeric(Me.txtID_Familia.Text) = True And txtID_Familia.Text > 0 Then 'si es numerico y tiene algun valor mayor a 0
                    Dim DS As DataSet = Familia.AsignarPerfil(txtID_Familia.Text)
                    Dim row As DataRow = DS.Tables(0).Rows(0)
                    'asigna el perfil  y meustra los campos
                    txtID_Familia.Text = row.Item(0)
                    txtNombre.Text = row.Item(1)
                    txtDescripcion.Text = row.Item(2)
                End If
            End If
        Catch ex As Exception ' si no lo logra, meustra una excpecion
            MiError.MostrarError(MiIdioma.Err_Busqueda & MiIdioma.Familia, 1)
        End Try
        ActualizarDS() 'actualiza el datagridview
    End Sub
    Private Sub RegistrarFamilia()
        If Validar_Campos() = False Then ' valida los campos
            Exit Sub
        End If

        Try 'intenta
            'variables requeridas
            Dim fecha As Date = Now
            Dim Descripcion As String = "FAMILIA:Alta Código: " & Me.txtID_Familia.Text
            'alta de familia
            Fam.Alta(txtID_Familia.Text, txtNombre.Text, txtDescripcion.Text)
            Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia", "Familia")

            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "ALTA DE FAMILIA", Descripcion, fecha, "2", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())

            'alta de DVH
            DVH = Mi_DV.DVH("select * from Patente_Familia where ID_Familia=" & Me.txtID_Familia.Text, "Patente_Familia")
            Fam.AsignarUsuario("update Patente_Familia set DVH='" & DVH & "' where ID_Familia=" & Me.txtID_Familia.Text)

            limpiarfam() ' limpia la familia
            MiError.MostrarError(MiIdioma.Exito, 1) 'muestra mensaje de exito
            btnCancelarNuevo.PerformClick()
            Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia order by ID_Familia", "Familia")
        Catch ex As Exception
            MiError.MostrarError(MiIdioma.Err_Adm, 1) 'si no lo logra, muestra una excpecion
            Dim fecha As Date = Now
            Dim Descripcion As String = "Error Alta Familia" & Me.txtID_Familia.Text
            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "Error Alta Familia", Descripcion, fecha, "1", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())

        End Try
    End Sub


    Private Sub ActualizarFamilia()
        If Validar_Campos() = False Then 'valida los campos
            Exit Sub
        End If
        Try 'intenta
            'variables requeridas
            Dim fecha As Date = Now
            Dim Descripcion As String = "FAMILIA:Modific. Código: " & Me.txtID_Familia.Text
            'modificacion de familia
            Fam.Modificacion(Me.txtID_Familia.Text, Me.txtNombre.Text, Me.txtDescripcion.Text)
            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "MODIFICAR FAMILIA", Descripcion, fecha, "2", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
            'alta de DVH
            DVH = Mi_DV.DVH("select * from Patente_Familia where ID_Familia=" & Me.txtID_Familia.Text, "Familia")
            Fam.AsignarUsuario("update Patente_Familia set DVH='" & DVH & "' where ID_Familia=" & Me.txtID_Familia.Text)
            Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia order by ID_Familia", "Familia")
            limpiarfam() 'limpia familia
            MiError.MostrarError(MiIdioma.Exito, 1) 'muestra mensaje de exito
        Catch ex As Exception
            MiError.MostrarError(MiIdioma.Err_Adm, 1) 'si no lo logra, muestra una excepcion
            Dim fecha As Date = Now
            Dim Descripcion As String = "Error Modificación Familia" & txtID_Familia.Text
            'alta de bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "ERROR MODIFICAR FAMILIA", Descripcion, fecha, "2", 0)
        End Try
    End Sub
    Private Sub EliminarFamilia()
        If Me.txtID_Familia.Text = "1" Or Me.txtID_Familia.Text = "2" Or Me.txtID_Familia.Text = "3" Then
            MiError.MostrarError(MiIdioma.Err_Elim_Fam, 1)
        Else
            Try 'intenta
                'elimina la familia y las patentes
                Fam.Eliminar_Familia_Patente(Me.txtID_Familia.Text)
                Dim fecha As Date = Now
                Dim Descripcion As String = "FAMILIA:Baja Código: " & Me.txtID_Familia.Text
                'baja de familia
                Fam.Baja(Me.txtID_Familia.Text)
                'alta de bitacora
                MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "BAJA DE FAMILIA", Descripcion, fecha, "1", 0)
                DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
                MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())

                Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_Familia from Familia order by ID_Familia", "Familia")
                MiError.MostrarError(MiIdioma.Exito, 1) 'muestra mensaje de exito
            Catch ex As Exception
                MiError.MostrarError(MiIdioma.Err_Adm, 1) 'si no lo logra, muestra una excpecion
            End Try
        End If

    End Sub
    Private Sub ActualizarDS() 'actualiza el dtagridview
        Dim DS As DataSet
        DS = Fam.AsignarPerfil(0)
        DGVFamilia.DataSource = DS.Tables(0)
    End Sub

    Private Sub limpiarfam() 'limpia familia
        Me.txtID_Familia.Clear()
        Me.txtDescripcion.Clear()
        Me.txtNombre.Clear()
        Call ActualizarDS()
        Call CrearFamilia()
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiarfam() 'llama a la subfuncion de limpiar la familia
    End Sub


    Private Sub CambiarNombreDG() 'cambia el nombre a la familia
        Me.DGVFamilia.Columns(0).HeaderText = MiIdioma.Familia
        Me.DGVFamilia.Columns(1).HeaderText = MiIdioma.Nombre
        Me.DGVFamilia.Columns(2).HeaderText = MiIdioma.Descripcion
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.btnRegistrar.Enabled = True
        Me.btnActualizar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnLimpiar.Enabled = False
        Me.btnBuscar.Enabled = False

        Call limpiarfam()
        Me.txtID_Familia.Enabled = False

    End Sub

    Private Sub btnCancelarNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarNuevo.Click
        Me.btnRegistrar.Enabled = True 'habilita elementos despeus de cancelar
        Me.btnActualizar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnLimpiar.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.txtID_Familia.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lstfamilia.Items.Clear() 'limpia lso elementos al cancelar

        Me.lstpatente.Items.Clear()
    End Sub



    Private Sub btnalta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalta.Click
        Dim i As Integer
        Dim cod As Integer
        If cod = 0 Then
            For i = 0 To lstpatente.Items.Count - 1
                If lstpatente.GetItemChecked(i) Then
                    Fam.AsignarUsuario("insert into Patente_Familia ([ID_Patente],[ID_Familia],[Estado],[DVH]) values (" & lstpatente.Items.IndexOf(lstpatente.Items.Item(i)) + 1 & "," & IDFamilias & "," & 1 & "," & 1 & ")")
                    lstpatente.SetItemChecked(i, False)
                    DVH = Mi_DV.DVH("select * from Patente_Familia where ID_Familia=" & IDFamilias, "Familia")
                    Fam.AsignarUsuario("update Patente_Familia set DVH='" & DVH & "' where ID_Familia=" & IDFamilias)
                End If
            Next
        End If
    End Sub

    Private Sub lstfamilia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstfamilia.Click
        Dim i As Integer
        btnbaja.Enabled = True
        btnalta.Enabled = False
        btnAceptarPat.Enabled = False
        For i = 0 To lstpatente.Items.Count - 1
            lstpatente.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub lstfamilia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstfamilia.DoubleClick
        Dim i As Integer
        btnbaja.Enabled = False
        btnAceptarPat.Enabled = True
        btnalta.Enabled = False
        IDFamilias = Usu.RestaurarUsu("select ID_Familia from Familia where Nombre_Familia LIKE '" & lstfamilia.Text & "%'", "ID_Familia")
        Fam.cargartabla(lstpatente, "select ID_Patente from Patente_Familia where ID_Familia=(select ID_Familia from Familia where Nombre_Familia LIKE '%" & lstfamilia.Text & "%')", "Patente_Familia")
        For i = 0 To lstpatente.Items.Count - 1
            IDFamilia(i) = lstpatente.GetItemChecked(i)
        Next

    End Sub

    Private Sub btnAceptarPati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarPat.Click
        Dim i As Integer
        Dim cod As Integer
        For i = 0 To lstpatente.Items.Count - 1
            If lstpatente.GetItemChecked(i) <> IDFamilia(i) Then
                If lstpatente.GetItemChecked(i) Then
                    lstpatente.SetSelected(i, True)
                    cod = Fam.Cargar_Listbox_Usuarios("select ID_patente from Patente where Nombre_patente LIKE'" & lstpatente.Text & "'", "ID_patente")
                    Fam.AsignarUsuario("insert into Patente_Familia (ID_Patente,ID_Familia, Estado, DVH) values (" & cod & "," & IDFamilias & ",1,0)")
                    DVH = Mi_DV.DVH("select * from Patente_Familia where ID_Familia=" & IDFamilias, "Familia")
                    Fam.AsignarUsuario("update Patente_Familia set DVH='" & DVH & "' where ID_Familia=" & IDFamilias)
                Else
                    lstpatente.SetSelected(i, True)
                    cod = Fam.Cargar_Listbox_Usuarios("select ID_patente from Patente where Nombre_patente LIKE'" & lstpatente.Text & "'", "ID_patente")
                    Fam.AsignarUsuario("delete from Patente_Familia where ID_Familia=" & IDFamilias & " and ID_Patente=" & cod)
                    DVH = Mi_DV.DVH("select * from Patente_Familia where ID_Familia=" & IDFamilias, "Familia")
                    Fam.AsignarUsuario("update Patente_Familia set DVH='" & DVH & "' where ID_Familia=" & IDFamilias)
                End If
            End If
            lstpatente.SetItemChecked(i, False)
        Next
        MiError.MostrarError(MiIdioma.Exito, 1)
        Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_familia from Familia order by ID_Familia", "Familia")
        btnAceptarPat.Enabled = False
        btnalta.Enabled = True
    End Sub
    Private Sub btnbaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbaja.Click
        'Borra Patente_Familia
        Fam.AsignarUsuario("Delete from Patente_Familia where ID_Familia=(select ID_Familia from Familia where Nombre_familia LIKE'" & lstfamilia.Text & "')")


        'Actualiza DVH Patente_Familia
        DVH = Mi_DV.DVH("select * from Patente_Familia where ID_Familia=" & lstfamilia.Text, "Familia")
        Fam.AsignarUsuario("update Patente_Familia set DVH='" & DVH & "' where ID_Familia=" & lstfamilia.Text)
        Fam.Cargar_Listbox_Familia_Patente(lstfamilia, "select Nombre_familia from Familia order by ID_Familia", "Familia")

    End Sub


End Class