<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleventaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMLYBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DVHDVVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bestado = New System.Windows.Forms.ToolStripMenuItem()
        Me.MVentanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.Vertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.Horizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contenido = New System.Windows.Forms.ToolStripMenuItem()
        Me.Indice = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSS1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Acercade = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PatentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Idioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CuentasCorrientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TSSlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lstPat = New System.Windows.Forms.ListBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lblUsu = New System.Windows.Forms.Label()
        Me.lblPatente = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.IngresosToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.MVer, Me.MVentanas, Me.MAyuda})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.MVentanas
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1022, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesionToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "&Inicio"
        '
        'IniciarSesionToolStripMenuItem
        '
        Me.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem"
        Me.IniciarSesionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.IniciarSesionToolStripMenuItem.Text = "I&niciar Sesion"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "&Cerrar Sesion"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.ProductosToolStripMenuItem})
        Me.IngresosToolStripMenuItem.Image = Global.Capa4_Interfaces.My.Resources.Resources.agregar
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.IngresosToolStripMenuItem.Text = "Ing&resos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoriasToolStripMenuItem.Text = "Cate&gorias"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeVentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ReservasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Image = Global.Capa4_Interfaces.My.Resources.Resources.agregar
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.VentasToolStripMenuItem.Text = "&Ventas"
        '
        'RegistroDeVentasToolStripMenuItem
        '
        Me.RegistroDeVentasToolStripMenuItem.Name = "RegistroDeVentasToolStripMenuItem"
        Me.RegistroDeVentasToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RegistroDeVentasToolStripMenuItem.Text = "&Registro de ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClientesToolStripMenuItem.Text = "C&lientes"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ReservasToolStripMenuItem.Text = "Re&servas"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalleventaToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Image = Global.Capa4_Interfaces.My.Resources.Resources.agregar
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ConsultasToolStripMenuItem.Text = "C&onsultas"
        '
        'DetalleventaToolStripMenuItem
        '
        Me.DetalleventaToolStripMenuItem.Name = "DetalleventaToolStripMenuItem"
        Me.DetalleventaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DetalleventaToolStripMenuItem.Text = "&Detalle de Venta"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteDeProductosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Image = Global.Capa4_Interfaces.My.Resources.Resources.agregar
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ReportesToolStripMenuItem.Text = "Re&portes"
        '
        'ReporteDeProductosToolStripMenuItem
        '
        Me.ReporteDeProductosToolStripMenuItem.Name = "ReporteDeProductosToolStripMenuItem"
        Me.ReporteDeProductosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ReporteDeProductosToolStripMenuItem.Text = "Reporte de &productos"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.FamiliaToolStripMenuItem, Me.PatenteToolStripMenuItem, Me.IdiomaToolStripMenuItem, Me.XMLYBackupToolStripMenuItem, Me.RestoreToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem})
        Me.ConfiguracionesToolStripMenuItem.Image = Global.Capa4_Interfaces.My.Resources.Resources.eliminar
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.ConfiguracionesToolStripMenuItem.Text = "Confi&guraciones"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UsuariosToolStripMenuItem.Text = "&Usuarios"
        '
        'FamiliaToolStripMenuItem
        '
        Me.FamiliaToolStripMenuItem.Name = "FamiliaToolStripMenuItem"
        Me.FamiliaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.FamiliaToolStripMenuItem.Text = "&Familias"
        '
        'PatenteToolStripMenuItem
        '
        Me.PatenteToolStripMenuItem.Name = "PatenteToolStripMenuItem"
        Me.PatenteToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PatenteToolStripMenuItem.Text = "&Patentes"
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        Me.IdiomaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.IdiomaToolStripMenuItem.Text = "I&dioma"
        '
        'XMLYBackupToolStripMenuItem
        '
        Me.XMLYBackupToolStripMenuItem.Name = "XMLYBackupToolStripMenuItem"
        Me.XMLYBackupToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.XMLYBackupToolStripMenuItem.Text = "&XML y Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RestoreToolStripMenuItem.Text = "Res&tore"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "&Cambiar Contraseña"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesosToolStripMenuItem, Me.BitacoraToolStripMenuItem, Me.DVHDVVToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Image = Global.Capa4_Interfaces.My.Resources.Resources.images
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProcesosToolStripMenuItem.Text = "Proce&sos"
        '
        'BitacoraToolStripMenuItem
        '
        Me.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem"
        Me.BitacoraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BitacoraToolStripMenuItem.Text = "&Bitacora"
        '
        'DVHDVVToolStripMenuItem
        '
        Me.DVHDVVToolStripMenuItem.Name = "DVHDVVToolStripMenuItem"
        Me.DVHDVVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DVHDVVToolStripMenuItem.Text = "DVH && DVV"
        '
        'MVer
        '
        Me.MVer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Bestado})
        Me.MVer.Name = "MVer"
        Me.MVer.Size = New System.Drawing.Size(35, 20)
        Me.MVer.Text = "&Ver"
        '
        'Bestado
        '
        Me.Bestado.Checked = True
        Me.Bestado.CheckOnClick = True
        Me.Bestado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Bestado.Name = "Bestado"
        Me.Bestado.Size = New System.Drawing.Size(155, 22)
        Me.Bestado.Text = "&Barra de Estado"
        '
        'MVentanas
        '
        Me.MVentanas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cascada, Me.Vertical, Me.Horizontal, Me.Cerrar})
        Me.MVentanas.Name = "MVentanas"
        Me.MVentanas.Size = New System.Drawing.Size(66, 20)
        Me.MVentanas.Text = "&Ventanas"
        '
        'Cascada
        '
        Me.Cascada.Name = "Cascada"
        Me.Cascada.Size = New System.Drawing.Size(202, 22)
        Me.Cascada.Text = "&Cascada"
        '
        'Vertical
        '
        Me.Vertical.Name = "Vertical"
        Me.Vertical.Size = New System.Drawing.Size(202, 22)
        Me.Vertical.Text = "Organización &Vertical"
        '
        'Horizontal
        '
        Me.Horizontal.Name = "Horizontal"
        Me.Horizontal.Size = New System.Drawing.Size(202, 22)
        Me.Horizontal.Text = "Organización &Horizontal"
        '
        'Cerrar
        '
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(202, 22)
        Me.Cerrar.Text = "C&errar Todas"
        '
        'MAyuda
        '
        Me.MAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Contenido, Me.Indice, Me.Buscar, Me.TSS1, Me.Acercade})
        Me.MAyuda.Enabled = False
        Me.MAyuda.Name = "MAyuda"
        Me.MAyuda.Size = New System.Drawing.Size(53, 20)
        Me.MAyuda.Text = "&Ayuda"
        '
        'Contenido
        '
        Me.Contenido.Enabled = False
        Me.Contenido.Name = "Contenido"
        Me.Contenido.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.Contenido.Size = New System.Drawing.Size(176, 22)
        Me.Contenido.Text = "&Contenido"
        '
        'Indice
        '
        Me.Indice.Enabled = False
        Me.Indice.ImageTransparentColor = System.Drawing.Color.Black
        Me.Indice.Name = "Indice"
        Me.Indice.Size = New System.Drawing.Size(176, 22)
        Me.Indice.Text = "&Indice"
        '
        'Buscar
        '
        Me.Buscar.Enabled = False
        Me.Buscar.ImageTransparentColor = System.Drawing.Color.Black
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(176, 22)
        Me.Buscar.Text = "&Buscar"
        '
        'TSS1
        '
        Me.TSS1.Name = "TSS1"
        Me.TSS1.Size = New System.Drawing.Size(173, 6)
        '
        'Acercade
        '
        Me.Acercade.Enabled = False
        Me.Acercade.Name = "Acercade"
        Me.Acercade.Size = New System.Drawing.Size(176, 22)
        Me.Acercade.Text = "&Acerca de ..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(171, 6)
        '
        'PatentesToolStripMenuItem
        '
        Me.PatentesToolStripMenuItem.Name = "PatentesToolStripMenuItem"
        Me.PatentesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.PatentesToolStripMenuItem.Text = "Administrar Patentes"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(171, 6)
        '
        'Idioma
        '
        Me.Idioma.Name = "Idioma"
        Me.Idioma.Size = New System.Drawing.Size(174, 22)
        Me.Idioma.Text = "&Idioma"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(171, 6)
        '
        'CuentasCorrientesToolStripMenuItem
        '
        Me.CuentasCorrientesToolStripMenuItem.Name = "CuentasCorrientesToolStripMenuItem"
        Me.CuentasCorrientesToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.CuentasCorrientesToolStripMenuItem.Text = "Cuentas Corrientes y Cheques"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(40, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSlblUsuario})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 561)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1022, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip"
        '
        'TSSlblUsuario
        '
        Me.TSSlblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSlblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TSSlblUsuario.Name = "TSSlblUsuario"
        Me.TSSlblUsuario.Size = New System.Drawing.Size(54, 17)
        Me.TSSlblUsuario.Text = "Nombre:"
        '
        'lstPat
        '
        Me.lstPat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lstPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lstPat.FormattingEnabled = True
        Me.lstPat.Location = New System.Drawing.Point(961, 5)
        Me.lstPat.Name = "lstPat"
        Me.lstPat.Size = New System.Drawing.Size(35, 13)
        Me.lstPat.TabIndex = 15
        Me.lstPat.TabStop = False
        Me.lstPat.UseTabStops = False
        Me.lstPat.Visible = False
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Purchase and Sell Checks System"
        Me.NotifyIcon.Visible = True
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtLog.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLog.Location = New System.Drawing.Point(872, 5)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.Size = New System.Drawing.Size(27, 14)
        Me.txtLog.TabIndex = 17
        Me.txtLog.Visible = False
        '
        'lblUsu
        '
        Me.lblUsu.AutoSize = True
        Me.lblUsu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblUsu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUsu.Location = New System.Drawing.Point(823, 5)
        Me.lblUsu.Name = "lblUsu"
        Me.lblUsu.Size = New System.Drawing.Size(43, 13)
        Me.lblUsu.TabIndex = 18
        Me.lblUsu.Text = "Usuario"
        Me.lblUsu.Visible = False
        '
        'lblPatente
        '
        Me.lblPatente.AutoSize = True
        Me.lblPatente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblPatente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPatente.Location = New System.Drawing.Point(905, 5)
        Me.lblPatente.Name = "lblPatente"
        Me.lblPatente.Size = New System.Drawing.Size(50, 13)
        Me.lblPatente.TabIndex = 19
        Me.lblPatente.Text = "Patentes"
        Me.lblPatente.Visible = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1022, 583)
        Me.Controls.Add(Me.lblPatente)
        Me.Controls.Add(Me.lblUsu)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lstPat)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:MENU:."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MVer As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Bestado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MVentanas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Vertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Horizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cerrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Contenido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Indice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Buscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSS1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Acercade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents Idioma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CuentasCorrientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstPat As System.Windows.Forms.ListBox
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents lblUsu As System.Windows.Forms.Label
    Friend WithEvents lblPatente As System.Windows.Forms.Label
    Friend WithEvents TSSlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetalleventaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XMLYBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DVHDVVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
