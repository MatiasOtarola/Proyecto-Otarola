Option Explicit On
Imports Capa3_Seguridad_Servicios
Public Class frmPatentes
    Dim DVH, DVHBit As Long
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

    Private Sub frmPatente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2) 'muestra un mensaje antes de salir, si acepta cierra
        If MiError.Seleccion = 1 Then
            Dim dvv As Long
            Dim a As String
            dvv = Mi_DV.DVV("select sum(DVH) as dvv from Patente", "dvv")
            a = Pat.ActualizarFamilia_Patente("select Nombre_Tabla from DVV where Nombre_Tabla='Patente'", "Nombre_Tabla")
            If a <> "" Then
                Pat.AsignarPatente("update DVV set DVV='" & dvv & "' where Nombre_Tabla='Patente'")
            Else
                Pat.AsignarPatente("insert into DVV values('Patente','" & dvv & "')")
            End If

            Dim dvv2 As Long
            Dim b As String

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
    Private Sub crearPatente()
        Me.txtpat.Text = Pat.crearNuevaPatente()
    End Sub
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            RegistrarPatente() 'llama a la subfuncion de registrar la patente
        End If
    End Sub
    Private Sub RegistrarPatente()
        If Validar_Campos() = False Then
            Exit Sub
        End If
        Try
            Dim ascii As String = "" 'declara una variable para utilizar para guardar el texto ANCII
            Dim campos As String = "" 'declara una variable para utilizar para sumar
            Dim fecha As Date = Now ' la fecha actual 
            Dim Descripcion As String = ""
            Descripcion = "PATENTE: Alta Código: " & txtpat.Text
            'alta de patente
            Pat.Alta(Me.txtpat.Text, Me.txtdesc.Text, txtCondicion.Text, 0)
            ' accede al digito verificador mediante la funcion con los datos dados
            DVH = Mi_DV.DVH("select * from Patente where ID_patente=" & Me.txtpat.Text, "Patente")
            Pat.AsignarPatente("update Patente set DVH='" & DVH & "' where ID_patente=" & Me.txtpat.Text)
            ' accede a la bitacora mediante la funcion con los datos dados
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "ALTA PATENTE", Descripcion, fecha, "2", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
            ActualizarDG() 'llama a la subfuncion de actualziar el datagriview
            LimpiarPatente() 'llama a la subfuncion de  limpair la patente
            DGVPatents.Refresh() 'refresca el datagridview
            MiError.MostrarError(MiIdioma.Exito, 1)
            Me.btnCancelarNuevo.PerformClick()
        Catch ex As Exception ' en caso de error, muestra un mensaje
            MiError.MostrarError(MiIdioma.Error1, 1)
        End Try


    End Sub

    Private Sub frmPatentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cambiar_Idioma() 'llama a la subfuncion de cambiar el idioma
        crearPatente() 'llama a la subfuncion de crear patente
        ActualizarDG() 'llama a la subfuncion de actualizar el datagridview
        CambiarNombreDG() 'llama a la subfuncion de cambiar el nobmre a las columnas

    End Sub


    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            ActualizarPatente() 'llama a la subfuncion de actualizar la patente
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarPatente() 'llama a la subfuncion de buscar la patente
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim Result As MsgBoxResult = MsgBox(MiIdioma.Preg_Opera, MsgBoxStyle.Question Or MsgBoxStyle.YesNo, MiIdioma.Descripcion)
        If Result = MsgBoxResult.Yes Then 'pregunta para operar
            EliminarPatente() 'llama a la subfuncion de  elimianr la patente
        End If
    End Sub

    Private Sub ActualizarPatente()
        If Validar_Campos() = False Then
            Exit Sub
        End If
        Try
            Dim fecha As Date = Now ' la fecha actual 
            Dim Descripcion As String = ""
            Descripcion = "PATENTE:Modificación Código " & txtpat.Text
            Pat.Modificacion(Me.txtpat.Text, Me.txtdesc.Text, Me.txtCondicion.Text, "1")
            'accede al digito verificador mediante la funcion con los datos dados
            DVH = Mi_DV.DVH("select * from Patente where ID_patente=" & Me.txtpat.Text, "Patente")
            Pat.AsignarPatente("update Patente set DVH='" & DVH & "' where ID_patente=" & Me.txtpat.Text)
            ' accede a la bitacora mediante la funcion con los datos dados
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "ACTUALIZA PATENTE", Descripcion, fecha, "2", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
            ' Mi_DV.ManejarError("Bitacoras")
            ActualizarDG() 'llama a la subfuncion de actualziar el datagridview
            LimpiarPatente() 'llama a la subfuncion de limpiar la patente
            DGVPatents.Refresh() 'refresca el datagridview
            MiError.MostrarError(MiIdioma.Exito, 1)
        Catch ex As Exception ' en caso de error, muestra un mensaje
            MiError.MostrarError(MiIdioma.Error1, 1)
        End Try


    End Sub

    Private Sub BuscarPatente()
        Try
            Dim DS As DataSet
            Dim Patente As New Patente
            If Me.txtpat.Text > 0 And IsNumeric(Me.txtpat.Text) Then ' si es numerico y mayor a 0
                DS = Patente.AsignarPerfil(txtpat.Text) ' busca la patente segun el id de patente y muestra los campos
                txtpat.Text = DS.Tables(0).Rows(0).Item(0)
                txtdesc.Text = DS.Tables(0).Rows(0).Item(1)
                txtCondicion.Text = DS.Tables(0).Rows(0).Item(2)
            End If
            ActualizarDG() 'llama a la subfuncion de actualizar el datagriview
        Catch ex As Exception ' si ocurre un error,muestra una excepcion
            MiError.MostrarError(MiIdioma.Err_Busqueda & " " & MiIdioma.Patentes, 1)
        End Try
    End Sub

    Private Sub EliminarPatente()
        Try
            Dim fecha As Date = Now ' la fecha actual 
            Dim Descripcion As String
            Descripcion = "PATENTE:Eliminación Código: " & txtpat.Text
            Pat.Baja(Me.txtpat.Text)
            ' accede a la bitacora mediante la funcion con los datos dados
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "ELIMINA PATENTE", Descripcion, fecha, "2", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
            ' Mi_DV.ManejarError("Bitacoras")
            ActualizarDG() 'llama a la subfuncion de actualziar el datagridview
            LimpiarPatente() 'llama a la subfuncion de limpiar la patente
            DGVPatents.Refresh() 'refresca el datagridview
            MiError.MostrarError(MiIdioma.Exito, 1)
        Catch ex As Exception ' en caso de error, muestra un mensaje
            MiError.MostrarError(MiIdioma.Err_Adm, 1)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarPatente()
    End Sub

    Private Sub tsBuscarClie_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarPatente()
    End Sub

    Private Sub tsBuscarClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BuscarPatente()

    End Sub

    Private Sub tsAgregClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RegistrarPatente()

    End Sub

    Private Sub tsModificarClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ActualizarPatente()

    End Sub

    Private Sub tsEliminarClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EliminarPatente()

    End Sub

    Private Sub ActualizarDG()
        Dim DS As DataSet
        DS = Pat.AsignarPerfil(0)
        Me.DGVPatents.DataSource = DS.Tables(0)
    End Sub

    Private Sub LimpiarPatente()
        Me.txtpat.Text = ""
        Me.txtdesc.Text = ""
        Me.txtCondicion.Text = ""
        ActualizarDG()
        crearPatente()
    End Sub
    Public Sub CambiarNombreDG() ' permite cambiar el nombre a las columnas del DataGridView por otro segun el idioma seleccionado
        DGVPatents.Columns(0).HeaderText = MiIdioma.Patentes
        DGVPatents.Columns(1).HeaderText = MiIdioma.Descripcion
        DGVPatents.Columns(2).HeaderText = MiIdioma.Condicion
    End Sub
    Private Sub Cambiar_Idioma()
        Me.lblpat.Text = MiIdioma.Patentes
        Me.lbldesc.Text = MiIdioma.Descripcion
        Me.gbpatentes.Text = MiIdioma.ABMPatente
        Me.gbControls.Text = MiIdioma.Controles
        Me.lblCondicion.Text = MiIdioma.Condicion
        Me.Text = MiIdioma.ABMPatente

        btnRegistrar.Text = MiIdioma.Registrar
        btnActualizar.Text = MiIdioma.Actualizar
        btnEliminar.Text = MiIdioma.Eliminar
        btnLimpiar.Text = MiIdioma.Limpiar
        btnBuscar.Text = MiIdioma.Buscar
        btnNuevo.Text = MiIdioma.Nuevo
        btnCancelarNuevo.Text = MiIdioma.Cancelar_Nuevo

        TTT.SetToolTip(txtpat, MiIdioma.Patentes)
        TTT.SetToolTip(txtdesc, MiIdioma.Descripcion)
    End Sub
    Private Function Validar_Campos() As Boolean
        Dim Valido As Boolean = True

        If EsValido.Validar_Numerico(Me.txtpat.Text) = True Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Patentes, 1)
            Valido = False
        End If

        If EsValido.Validar_AlfaNumerico(Me.txtdesc.Text) = True Or Me.txtdesc.Text.Length > 50 Then
            MiError.MostrarError(MiIdioma.Err_Campo & MiIdioma.Descripcion, 1)
            Valido = False
        End If

        '-----------------------------------validar campos en blanco----------------------

        If Me.txtpat.Text = "" Then
            MiError.MostrarError(MiIdioma.Err_Blanco & MiIdioma.Patentes, 1)
            Valido = False
        End If
        If Me.txtdesc.Text = "" Then
            MiError.MostrarError(MiIdioma.Err_Blanco & MiIdioma.Descripcion, 1)
            Valido = False
        End If

        Return Valido
    End Function

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.btnRegistrar.Enabled = True
        Me.btnActualizar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.btnLimpiar.Enabled = False
        Me.btnBuscar.Enabled = False

        Call LimpiarPatente()
        Me.txtpat.Enabled = False

    End Sub

    Private Sub btnCancelarNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarNuevo.Click
        Me.btnRegistrar.Enabled = True
        Me.btnActualizar.Enabled = True
        Me.btnEliminar.Enabled = True
        Me.btnLimpiar.Enabled = True
        Me.btnBuscar.Enabled = True
        Me.txtpat.Enabled = True
    End Sub

    Private Sub tsAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Help.ShowHelp(Me, "C:\temp\Ayuda.chm", HelpNavigator.TopicId)
    End Sub

    Private Sub tsLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LimpiarPatente()
    End Sub
    Private Sub frmPatentes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Help.ShowHelp(Me, "C:\temp\Ayuda.chm")
        End If
    End Sub

End Class