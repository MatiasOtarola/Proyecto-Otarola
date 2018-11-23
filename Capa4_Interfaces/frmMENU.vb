Imports System.Windows.Forms
Imports System.IO
Imports Capa2_Logica
Imports Capa3_Seguridad_Servicios
Public Class frmMenu
    Dim WithEvents Mi_DV As New Digito_Verificador
    Dim DVHBit As Long
    Sub RegistrarAccionSuceso(ByVal Item As String, ByVal tabla As String) Handles Mi_DV.ErrorDV

        MiError.MostrarError("Error D.V. Item: " & Item & " Tabla/Table: " & tabla & " " & MiIdioma.DV & "", 1)
        Dim fecha As Date = Now
        Dim Descripcion As String = "Error D.V. Item: " & Item & " Tabla/Table: " & tabla & " "
        'alta de bitacora
        MiBitacora.AccesarBitacora(txtLog.Text, "Error D.V.", Descripcion, fecha, "1", 0)
        DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
        MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())

    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit() 'cierra la acplicacion
    End Sub
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.StatusStrip.Visible = Me.Bestado.Checked ' mustra el estado
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cascada.Click
        Me.LayoutMdi(MdiLayout.Cascade) 'mustra las ventanas en cascada
    End Sub
    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Vertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical) 'mustra las ventanas en vertical
    End Sub
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Horizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal) 'mustra las ventanas en horizontal
    End Sub
    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons) 'organiza lso iconos dentro del formulario mdi
    End Sub
    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cerrar.Click
        For Each ChildForm As Form In Me.MdiChildren 'por cada formulario hijo abierto
            ChildForm.Close() ' lo cierra
        Next
    End Sub
    Private m_ChildFormNumber As Integer = 0
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub
    Public Sub frmMENU_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'muestra el formulario de la presentacion
        frmConexionBD.ShowDialog()
        If frmConexionBD.DialogResult = Windows.Forms.DialogResult.OK Then
            frmLogin.ShowDialog() 'permite el loggin
            If frmLogin.DialogResult = Windows.Forms.DialogResult.OK Then ' si el resultado del dialogo loggin es OK
                MiIdioma.Cod_Idioma = Usu.Idioma
                Cargar_idioma() 'cambia el idioma
                Verificar_Accesos() 'verifica la los accesos
                Integridad_DV()
                Dim obj As IUsuario = New Proxy()
                obj.DarNombre(Usu.Nombre_Usuario)
                IniciarSesionToolStripMenuItem.Enabled = False 'deshabilita la opcion de loggin
                obj.Imprimir()
                TSSlblUsuario.Text = MiIdioma.Nombre & ": " & Usu.Nombre_Usuario 'muestra el nombre del usuario
            Else
                'en caso de no hacer el loggin cierra
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub Integridad_DV()

        'Integridad Usuario
        Dim dvv As Long
        Dim a As String
        Dim b As Long

        a = Usu.RestaurarUsu("select Nombre_Tabla from dvv where Nombre_Tabla='Usuario'", "Nombre_Tabla")
        If a <> "" Then
            b = Usu.RestaurarUsu("select dvv from dvv where Nombre_Tabla='Usuario'", "dvv")
            dvv = Mi_DV.DVV("select sum(DVH) as dvv from Usuario", "dvv")
            If b = dvv Then
                Mi_DV.IntegridadDV("select * from Usuario", "Usuario")
            End If
        End If

        'Integridad Patente_Familia
        Dim dvv2 As Long
        Dim a2 As String
        Dim b2 As Long

        a2 = Fam.Cargar_Listbox_Usuarios("select Nombre_Tabla from dvv where Nombre_Tabla='Patente_Familia'", "Nombre_Tabla")
        If a2 <> "" Then
            b2 = Fam.Cargar_Listbox_Usuarios("select dvv from dvv where Nombre_Tabla='Patente_Familia'", "dvv")
            dvv2 = Mi_DV.DVV("select sum(DVH) as dvv from Patente_Familia", "dvv")
            If b2 = dvv2 Then
            Else
                Mi_DV.IntegridadDV("select * from Patente_Familia", "Patente_Familia")
            End If

        End If

        'Integridad de Patente

        Dim dvv5 As Long
        Dim a4 As String
        Dim b4 As Long

        a4 = Pat.ActualizarFamilia_Patente("select Nombre_Tabla from dvv where Nombre_Tabla='Patente'", "Nombre_Tabla")
        If a4 <> "" Then
            b4 = Pat.ActualizarFamilia_Patente("select dvv from dvv where Nombre_Tabla='Patente'", "dvv")
            dvv5 = Mi_DV.DVV("select sum(DVH) as dvv from Patente", "dvv")
            If b4 = dvv5 Then
                Mi_DV.IntegridadDV("select * from Patente", "Patente")
            End If
        End If


        'Integridad Bitacora

        Dim dvv6 As Integer
        Dim a5 As String
        Dim b5 As Long

        a5 = MiBitacora.BuscarTablaDVH("select Nombre_Tabla from DVV where Nombre_Tabla='Bitacora'", "Nombre_Tabla")
        If a5 <> "" Then
            b5 = MiBitacora.BuscarTablaDVH("select DVV from DVV where Nombre_Tabla='Bitacora'", "DVV")
            dvv6 = Mi_DV.DVV("select sum(DVH) as dvv from Bitacora", "dvv")
            If b5 = dvv6 Then
                Mi_DV.IntegridadDV("select * from Bitacora", "Bitacora")
            End If
        End If

        Dim dvv7 As Integer
        Dim a6 As String
        Dim b6 As Long

        a6 = Usu.RestaurarUsu("select Nombre_Tabla from dvv where Nombre_Tabla='Usuario_Patente'", "Nombre_Tabla")
        If a6 <> "" Then
            b6 = Usu.RestaurarUsu("select dvv from dvv where Nombre_Tabla='Usuario_Patente'", "dvv")
            dvv7 = Mi_DV.DVV("select sum(DVH) as dvv from Usuario_Patente", "dvv")
            If b6 = dvv6 Then
                Mi_DV.IntegridadDV("select * from Usuario_Patente", "Usuario_Patente")
            End If
        End If

    End Sub
    Private Sub MVerBarraEstado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bestado.CheckedChanged
        If Me.Bestado.Checked = False Then 'comprueba el estado de la barra de estado
            StatusStrip.Visible = False
        Else
            StatusStrip.Visible = True
        End If
    End Sub

    Private Sub Cargar_idioma() ' se cambia el idioma a los elementos del formulario
        '
        'Inicios
        '
        InicioToolStripMenuItem.Text = MiIdioma.Iniciar_Sesion
        IniciarSesionToolStripMenuItem.Text = MiIdioma.Iniciar_Sesion
        CerrarSesionToolStripMenuItem.Text = MiIdioma.Cerrar_Sesion
        '
        'Ingresos
        '
        IngresosToolStripMenuItem.Text = MiIdioma.Ingresos
        CategoriasToolStripMenuItem.Text = MiIdioma.Categorias
        ProductosToolStripMenuItem.Text = MiIdioma.Productos
        '
        'Ventas
        '
        VentasToolStripMenuItem.Text = MiIdioma.Ventas
        RegistroDeVentasToolStripMenuItem.Text = MiIdioma.RegistroVentas
        ReservasToolStripMenuItem.Text = MiIdioma.reserva
        '
        'Consultas
        '
        ConsultasToolStripMenuItem.Text = MiIdioma.Consulta
        Me.DetalleventaToolStripMenuItem.Text = MiIdioma.DetalleVentas
        '
        'Reportes
        '
        ReportesToolStripMenuItem.Text = MiIdioma.Reportes
        ReporteDeProductosToolStripMenuItem.Text = MiIdioma.ReporteProductos
        '
        'Configuraciones
        '
        ConfiguracionesToolStripMenuItem.Text = MiIdioma.Configuraciones
        UsuariosToolStripMenuItem.Text = MiIdioma.ABMUsuario
        FamiliaToolStripMenuItem.Text = MiIdioma.ABMFamilia
        PatenteToolStripMenuItem.Text = MiIdioma.ABMPatente
        Me.IdiomaToolStripMenuItem.Text = MiIdioma.Idioma_Text
        XMLYBackupToolStripMenuItem.Text = MiIdioma.Backup
        RestoreToolStripMenuItem.Text = MiIdioma.Restore
        CambiarContraseñaToolStripMenuItem.Text = MiIdioma.Cambiar
        '
        'Herramientas
        '
        ProcesosToolStripMenuItem.Text = MiIdioma.Procesos
        BitacoraToolStripMenuItem.Text = MiIdioma.Bitacora
        '
        'Otros
        '
        MVer.Text = MiIdioma.Ver
        MVer.ToolTipText = MiIdioma.Ver
        MVentanas.Text = MiIdioma.Ventanas
        MVentanas.ToolTipText = MiIdioma.Ventanas
        MAyuda.Text = MiIdioma.Ayuda
        MAyuda.ToolTipText = MiIdioma.Ayuda

        Bestado.Text = MiIdioma.BEstado
        Cerrar.Text = MiIdioma.Cerrar
        Cascada.Text = MiIdioma.Cascada
        Horizontal.Text = MiIdioma.Horizontal
        Vertical.Text = MiIdioma.Vertical
        Contenido.Text = MiIdioma.Contenido
        Indice.Text = MiIdioma.Indice
        Buscar.Text = MiIdioma.Buscar
        Acercade.Text = MiIdioma.Acercade
        lblPatente.Text = MiIdioma.Patentes
        lblUsu.Text = MiIdioma.Usuario
    End Sub
    Private Sub Accesos() 'deshabilita/hailita lso elementos al iniciar
     
        MVer.Enabled = False
        MAyuda.Enabled = False
        '
        'Inicios
        '
        InicioToolStripMenuItem.Enabled = True
        IniciarSesionToolStripMenuItem.Enabled = True
        CerrarSesionToolStripMenuItem.Enabled = True
        '
        'Ingresos
        '
        IngresosToolStripMenuItem.Enabled = False
        CategoriasToolStripMenuItem.Enabled = False
        ProductosToolStripMenuItem.Enabled = False
        '
        'Ventas
        '
        VentasToolStripMenuItem.Enabled = False
        RegistroDeVentasToolStripMenuItem.Enabled = False
        ReservasToolStripMenuItem.Enabled = False
        '
        'Consultas
        '
        ConsultasToolStripMenuItem.Enabled = False
        Me.DetalleventaToolStripMenuItem.Enabled = False
        '
        'Reportes
        '
        ReportesToolStripMenuItem.Enabled = False
        ReporteDeProductosToolStripMenuItem.Enabled = False
        '
        'Configuraciones
        '
        ConfiguracionesToolStripMenuItem.Enabled = True
        UsuariosToolStripMenuItem.Enabled = False
        FamiliaToolStripMenuItem.Enabled = False
        PatenteToolStripMenuItem.Enabled = False
        Me.IdiomaToolStripMenuItem.Enabled = True
        XMLYBackupToolStripMenuItem.Enabled = False
        RestoreToolStripMenuItem.Enabled = False
        CambiarContraseñaToolStripMenuItem.Enabled = False
        '
        'Herramientas
        '
        ProcesosToolStripMenuItem.Enabled = False
        BitacoraToolStripMenuItem.Enabled = False
        '
        'Otros
        '
        MVer.Enabled = False
        MVentanas.Enabled = False
        MAyuda.Enabled = True


    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acercade.Click
        Dim AcercaDe As New frmAcercaDe 'muestra el formulario acerca de
        AcercaDe.Show()
    End Sub
    Public Sub Salir_Login() 'cierra el loggin
        frmLogin.Close()
        Me.Close()
    End Sub

    Public Sub Verificar_Accesos() 'habitlita lso elementos segun los permisos del usuario
        Dim DS As DataSet
        DS = Usu.BuscarPatentes(Me.txtLog.Text)
        For Each row As DataRow In DS.Tables(0).Rows
            lstPat.Items.Add(CInt(row("ID_Patente")))
        Next
        MAyuda.Enabled = True
        Contenido.Enabled = True
        Indice.Enabled = True
        Acercade.Enabled = True
        Buscar.Enabled = True
        For Each i As Integer In Me.lstPat.Items
            Select Case i
                Case 1, 2, 3
                    Me.InicioToolStripMenuItem.Enabled = True
                    Me.UsuariosToolStripMenuItem.Enabled = True
                Case 7, 14
                    Me.InicioToolStripMenuItem.Enabled = True
                    Me.UsuariosToolStripMenuItem.Enabled = True
                Case 8, 11
                    ConfiguracionesToolStripMenuItem.Enabled = True
                    Me.UsuariosToolStripMenuItem.Enabled = True
                    Me.PatenteToolStripMenuItem.Enabled = True
                Case 9, 12
                    ConfiguracionesToolStripMenuItem.Enabled = True
                    Me.FamiliaToolStripMenuItem.Enabled = True
                    Me.PatenteToolStripMenuItem.Enabled = True
                Case 15, 18, 19
                    VentasToolStripMenuItem.Enabled = True
                    Me.ClientesToolStripMenuItem.Enabled = True
                Case 20, 21, 22
                    RegistroDeVentasToolStripMenuItem.Enabled = True
                    Me.VentasToolStripMenuItem.Enabled = True
                Case 24, 27, 29
                    RegistroDeVentasToolStripMenuItem.Enabled = True
                    Me.ReservasToolStripMenuItem.Enabled = True
                Case 30, 31, 32
                    HerramientasToolStripMenuItem.Enabled = True
                    IngresosToolStripMenuItem.Enabled = True
                    Me.ProductosToolStripMenuItem.Enabled = True
                    Me.ProcesosToolStripMenuItem.Enabled = True
                Case 33, 34, 35
                    IngresosToolStripMenuItem.Enabled = True
                    Me.CategoriasToolStripMenuItem.Enabled = True
                Case 38
                    ConfiguracionesToolStripMenuItem.Enabled = True
                    Me.XMLYBackupToolStripMenuItem.Enabled = True
                Case 39
                    ConfiguracionesToolStripMenuItem.Enabled = True
                    Me.RestoreToolStripMenuItem.Enabled = True
                Case 40, 41
                    HerramientasToolStripMenuItem.Enabled = True
                    Me.BitacoraToolStripMenuItem.Enabled = True
                Case 42
                    ConfiguracionesToolStripMenuItem.Enabled = True
                    Me.UsuariosToolStripMenuItem.Enabled = True
            End Select
        Next
    End Sub


    Private Sub AdminUsuTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim frmUsu As New frmUsuario 'muestra el formulario de usuarios
        frmUsu.MdiParent = Me
        frmUsu.Show()
    End Sub

    Private Sub AdminFamTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmfam As New frmFamilia 'muestra el formulario de familias
        frmfam.MdiParent = Me
        frmfam.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Restart() 'reinicia la aplicación

    End Sub

    Private Sub LoginOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CerrarSesion()
    End Sub
    Private Sub CerrarSesion()
        If txtLog.Text <> "" Then
            Dim log As Integer
            log = Ingreso.ValidarPersonal() 'valida el personal del loggin, buscando el maximo de ID de la tabla LogInOut.
            Ingreso.CerrarSesion(log, 0)
            Try
                Dim fecha As Date = Now ' la fecha actual 
                Dim Descripcion As String = "USUARIO: Cierre Sesion Código:" & Me.txtLog.Text  'la descripcion que aparecerá en la bitacora
                MiBitacora.AccesarBitacora(Me.txtLog.Text, "CIERRE SESION USUARIO", Descripcion, fecha, "3", 0)
                DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
                MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
            Catch ex As Exception ' muestra una excepción en caso de error
                MiError.MostrarError(MiIdioma.Error1, 1)
            End Try
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Accesos()
            Usu = Nothing
        End If
     
    End Sub
  


    Private Sub frmMENU_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then 'si la pantalla esta maximizada
            Me.Hide() 'la oculta
            NotifyIcon.Visible = True 'y muestra el ícono de notificación
        End If
    End Sub

    Private Sub NotifyIcon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon.Click
        Me.Show() 'si se hace click en el icono de notificación
        Me.WindowState = FormWindowState.Maximized 'maximiza la pantalla
        NotifyIcon.Visible = False ' y no muestra el icono de notifiación
    End Sub

    Private Sub Contenido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contenido.Click
        Help.ShowHelp(Me, Application.StartupPath & "\Ayuda.chm", HelpNavigator.TableOfContents) 'muestra la tabla de contenido de la ayuda
    End Sub
    Private Sub Indice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Indice.Click
        Help.ShowHelp(Me, Application.StartupPath & "\Ayuda.chm", HelpNavigator.Index) 'muestra el indice de la ayuda
    End Sub
    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Help.ShowHelp(Me, Application.StartupPath & "\Ayuda.chm", HelpNavigator.Find, "") 'habilita la opcion de indice asociado 
    End Sub
    Private Sub frmMENU_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2) 'pregunta antes de cerrar, si acepta actualiza el inicio de sesion de usuario y luego cierra la aplicación
        If MiError.Seleccion = 1 Then
            Call CerrarSesion()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        frmCategoria.MdiParent = Me
        frmCategoria.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProducto.MdiParent = Me
        frmProducto.Show()
    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click
        frmVenta.MdiParent = Me
        frmVenta.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmCliente.MdiParent = Me
        frmCliente.Show()
    End Sub
    'Private Sub ReporteDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProductosToolStripMenuItem.Click
    'Reporteproducto.MdiParent = Me
    'Reporteproducto.Show()
    'End Sub

    Private Sub ProcesosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesosToolStripMenuItem.Click
        frmProcesos.MdiParent = Me
        frmProcesos.Show()
    End Sub

    Private Sub DetalleventaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleventaToolStripMenuItem.Click
        frmDetalle_venta.MdiParent = Me
        frmDetalle_venta.Show()
    End Sub


    Public Function Actualizar_Idioma()
        Me.Cargar_idioma()
        Me.Activate()
        For Each Form As Form In Me.MdiChildren
            Form.Activate()
        Next
        Return True
    End Function

    Private Sub IniciarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesionToolStripMenuItem.Click
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub

    Private Sub ReporteDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProductosToolStripMenuItem.Click
        frmReporteProducto.MdiParent = Me
        frmReporteProducto.Show()
    End Sub

    Private Sub XMLYBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XMLYBackupToolStripMenuItem.Click
        frmBackup.MdiParent = Me
        frmBackup.Show()

    End Sub

    Private Sub FamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliaToolStripMenuItem.Click
        frmFamilia.MdiParent = Me
        frmFamilia.Show()
    End Sub

    Private Sub PatenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatenteToolStripMenuItem.Click
        frmPatentes.MdiParent = Me
        frmPatentes.Show()
    End Sub



    Private Sub IdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomaToolStripMenuItem.Click
        Dim Idioma As New frmIdioma
        Idioma.MdiParent = Me
        Idioma.Show()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        frmRestore.MdiParent = Me
        frmRestore.Show()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        frmPassword.MdiParent = Me
        frmPassword.Show()
    End Sub

    Private Sub DVHDVVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DVHDVVToolStripMenuItem.Click
        frmRecalculaDV.MdiParent = Me
        frmRecalculaDV.Show()
    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        frmBitacora.MdiParent = Me
        frmBitacora.Show()
    End Sub
End Class