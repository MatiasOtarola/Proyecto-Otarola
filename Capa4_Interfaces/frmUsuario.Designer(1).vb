<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.TSUser = New System.Windows.Forms.ToolStrip()
        Me.BuscarTSMI = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AgregarTSMI = New System.Windows.Forms.ToolStripButton()
        Me.ModificarTSMI = New System.Windows.Forms.ToolStripButton()
        Me.EliminarTSMI = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LimpiarTSMI = New System.Windows.Forms.ToolStripButton()
        Me.AyudaTSMI = New System.Windows.Forms.ToolStripButton()
        Me.gbAdmUsu = New System.Windows.Forms.GroupBox()
        Me.lblpat_usu = New System.Windows.Forms.Label()
        Me.lblPatente = New System.Windows.Forms.Label()
        Me.lstpat_usu = New System.Windows.Forms.ListBox()
        Me.btnQuitarPatente = New System.Windows.Forms.Button()
        Me.btnCancelar2 = New System.Windows.Forms.Button()
        Me.btnAceptar2 = New System.Windows.Forms.Button()
        Me.btnAgregarPatente = New System.Windows.Forms.Button()
        Me.lstpatentes = New System.Windows.Forms.ListBox()
        Me.lstusuario_fam = New System.Windows.Forms.ListBox()
        Me.lblusu_fam = New System.Windows.Forms.Label()
        Me.lblFamilia = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstfamilia = New System.Windows.Forms.ListBox()
        Me.lstoculto = New System.Windows.Forms.ListBox()
        Me.lstoculto2 = New System.Windows.Forms.ListBox()
        Me.gbUsu = New System.Windows.Forms.GroupBox()
        Me.ckBloqueo = New System.Windows.Forms.CheckBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtNick = New System.Windows.Forms.TextBox()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.CtrlIdioma1 = New Idioma_Selector.ctrlIdioma()
        Me.btnCancelarNuevo = New System.Windows.Forms.Button()
        Me.lblContrasenaU2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreU = New System.Windows.Forms.TextBox()
        Me.lblNombreU = New System.Windows.Forms.Label()
        Me.txtContrasenaU2 = New System.Windows.Forms.TextBox()
        Me.txtContrasenaU = New System.Windows.Forms.TextBox()
        Me.lblContrasenaU = New System.Windows.Forms.Label()
        Me.lblIdiomaU = New System.Windows.Forms.Label()
        Me.gbControls = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtCod_Usu = New System.Windows.Forms.TextBox()
        Me.lblusu = New System.Windows.Forms.Label()
        Me.HlpUser = New System.Windows.Forms.HelpProvider()
        Me.TSUser.SuspendLayout()
        Me.gbAdmUsu.SuspendLayout()
        Me.gbUsu.SuspendLayout()
        Me.gbControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'TSUser
        '
        Me.TSUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarTSMI, Me.ToolStripSeparator3, Me.AgregarTSMI, Me.ModificarTSMI, Me.EliminarTSMI, Me.ToolStripSeparator4, Me.LimpiarTSMI, Me.AyudaTSMI})
        Me.TSUser.Location = New System.Drawing.Point(0, 0)
        Me.TSUser.Name = "TSUser"
        Me.TSUser.Size = New System.Drawing.Size(693, 45)
        Me.TSUser.TabIndex = 3
        Me.TSUser.Text = "ToolStrip2"
        '
        'BuscarTSMI
        '
        Me.BuscarTSMI.AutoSize = False
        Me.BuscarTSMI.AutoToolTip = False
        Me.BuscarTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuscarTSMI.Image = CType(resources.GetObject("BuscarTSMI.Image"), System.Drawing.Image)
        Me.BuscarTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BuscarTSMI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarTSMI.Name = "BuscarTSMI"
        Me.BuscarTSMI.Size = New System.Drawing.Size(42, 42)
        Me.BuscarTSMI.Text = "ToolStripButton5"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 45)
        '
        'AgregarTSMI
        '
        Me.AgregarTSMI.AutoSize = False
        Me.AgregarTSMI.AutoToolTip = False
        Me.AgregarTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AgregarTSMI.Image = CType(resources.GetObject("AgregarTSMI.Image"), System.Drawing.Image)
        Me.AgregarTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AgregarTSMI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AgregarTSMI.Name = "AgregarTSMI"
        Me.AgregarTSMI.Size = New System.Drawing.Size(42, 42)
        Me.AgregarTSMI.Text = "ToolStripButton1"
        '
        'ModificarTSMI
        '
        Me.ModificarTSMI.AutoSize = False
        Me.ModificarTSMI.AutoToolTip = False
        Me.ModificarTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ModificarTSMI.Image = CType(resources.GetObject("ModificarTSMI.Image"), System.Drawing.Image)
        Me.ModificarTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ModificarTSMI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ModificarTSMI.Name = "ModificarTSMI"
        Me.ModificarTSMI.Size = New System.Drawing.Size(42, 42)
        Me.ModificarTSMI.Text = "ToolStripButton2"
        '
        'EliminarTSMI
        '
        Me.EliminarTSMI.AutoSize = False
        Me.EliminarTSMI.AutoToolTip = False
        Me.EliminarTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EliminarTSMI.Image = CType(resources.GetObject("EliminarTSMI.Image"), System.Drawing.Image)
        Me.EliminarTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EliminarTSMI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EliminarTSMI.Name = "EliminarTSMI"
        Me.EliminarTSMI.Size = New System.Drawing.Size(42, 42)
        Me.EliminarTSMI.Text = "ToolStripButton3"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 45)
        '
        'LimpiarTSMI
        '
        Me.LimpiarTSMI.AutoSize = False
        Me.LimpiarTSMI.AutoToolTip = False
        Me.LimpiarTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LimpiarTSMI.Image = CType(resources.GetObject("LimpiarTSMI.Image"), System.Drawing.Image)
        Me.LimpiarTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LimpiarTSMI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LimpiarTSMI.Name = "LimpiarTSMI"
        Me.LimpiarTSMI.Size = New System.Drawing.Size(23, 42)
        Me.LimpiarTSMI.Text = "ToolStripButton4"
        '
        'AyudaTSMI
        '
        Me.AyudaTSMI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaTSMI.Image = CType(resources.GetObject("AyudaTSMI.Image"), System.Drawing.Image)
        Me.AyudaTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AyudaTSMI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaTSMI.Name = "AyudaTSMI"
        Me.AyudaTSMI.Size = New System.Drawing.Size(23, 42)
        Me.AyudaTSMI.Text = "Ay&uda"
        '
        'gbAdmUsu
        '
        Me.gbAdmUsu.Controls.Add(Me.lblpat_usu)
        Me.gbAdmUsu.Controls.Add(Me.lblPatente)
        Me.gbAdmUsu.Controls.Add(Me.lstpat_usu)
        Me.gbAdmUsu.Controls.Add(Me.btnQuitarPatente)
        Me.gbAdmUsu.Controls.Add(Me.btnCancelar2)
        Me.gbAdmUsu.Controls.Add(Me.btnAceptar2)
        Me.gbAdmUsu.Controls.Add(Me.btnAgregarPatente)
        Me.gbAdmUsu.Controls.Add(Me.lstpatentes)
        Me.gbAdmUsu.Controls.Add(Me.lstusuario_fam)
        Me.gbAdmUsu.Controls.Add(Me.lblusu_fam)
        Me.gbAdmUsu.Controls.Add(Me.lblFamilia)
        Me.gbAdmUsu.Controls.Add(Me.btnQuitar)
        Me.gbAdmUsu.Controls.Add(Me.btnCancelar)
        Me.gbAdmUsu.Controls.Add(Me.btnAceptar)
        Me.gbAdmUsu.Controls.Add(Me.btnAgregar)
        Me.gbAdmUsu.Controls.Add(Me.lstfamilia)
        Me.gbAdmUsu.Controls.Add(Me.lstoculto)
        Me.gbAdmUsu.Controls.Add(Me.lstoculto2)
        Me.gbAdmUsu.Location = New System.Drawing.Point(4, 354)
        Me.gbAdmUsu.Name = "gbAdmUsu"
        Me.gbAdmUsu.Size = New System.Drawing.Size(679, 259)
        Me.gbAdmUsu.TabIndex = 5
        Me.gbAdmUsu.TabStop = False
        Me.gbAdmUsu.Text = "gbAdmUsu"
        '
        'lblpat_usu
        '
        Me.lblpat_usu.AutoSize = True
        Me.lblpat_usu.Location = New System.Drawing.Point(340, 140)
        Me.lblpat_usu.Name = "lblpat_usu"
        Me.lblpat_usu.Size = New System.Drawing.Size(39, 13)
        Me.lblpat_usu.TabIndex = 15
        Me.lblpat_usu.Text = "Label2"
        '
        'lblPatente
        '
        Me.lblPatente.AutoSize = True
        Me.lblPatente.Location = New System.Drawing.Point(27, 140)
        Me.lblPatente.Name = "lblPatente"
        Me.lblPatente.Size = New System.Drawing.Size(39, 13)
        Me.lblPatente.TabIndex = 14
        Me.lblPatente.Text = "Label1"
        '
        'lstpat_usu
        '
        Me.lstpat_usu.FormattingEnabled = True
        Me.lstpat_usu.Location = New System.Drawing.Point(343, 156)
        Me.lstpat_usu.Name = "lstpat_usu"
        Me.lstpat_usu.Size = New System.Drawing.Size(144, 95)
        Me.lstpat_usu.TabIndex = 9
        '
        'btnQuitarPatente
        '
        Me.btnQuitarPatente.Location = New System.Drawing.Point(213, 208)
        Me.btnQuitarPatente.Name = "btnQuitarPatente"
        Me.btnQuitarPatente.Size = New System.Drawing.Size(92, 29)
        Me.btnQuitarPatente.TabIndex = 8
        Me.btnQuitarPatente.Text = "Button1"
        Me.btnQuitarPatente.UseVisualStyleBackColor = True
        '
        'btnCancelar2
        '
        Me.btnCancelar2.Location = New System.Drawing.Point(524, 207)
        Me.btnCancelar2.Name = "btnCancelar2"
        Me.btnCancelar2.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar2.TabIndex = 11
        Me.btnCancelar2.Text = "Button2"
        Me.btnCancelar2.UseVisualStyleBackColor = True
        '
        'btnAceptar2
        '
        Me.btnAceptar2.Location = New System.Drawing.Point(524, 161)
        Me.btnAceptar2.Name = "btnAceptar2"
        Me.btnAceptar2.Size = New System.Drawing.Size(99, 29)
        Me.btnAceptar2.TabIndex = 10
        Me.btnAceptar2.Text = "Button3"
        Me.btnAceptar2.UseVisualStyleBackColor = True
        '
        'btnAgregarPatente
        '
        Me.btnAgregarPatente.Location = New System.Drawing.Point(213, 162)
        Me.btnAgregarPatente.Name = "btnAgregarPatente"
        Me.btnAgregarPatente.Size = New System.Drawing.Size(92, 29)
        Me.btnAgregarPatente.TabIndex = 7
        Me.btnAgregarPatente.Text = "Button4"
        Me.btnAgregarPatente.UseVisualStyleBackColor = True
        '
        'lstpatentes
        '
        Me.lstpatentes.FormattingEnabled = True
        Me.lstpatentes.Location = New System.Drawing.Point(30, 156)
        Me.lstpatentes.Name = "lstpatentes"
        Me.lstpatentes.Size = New System.Drawing.Size(145, 95)
        Me.lstpatentes.TabIndex = 6
        '
        'lstusuario_fam
        '
        Me.lstusuario_fam.FormattingEnabled = True
        Me.lstusuario_fam.Location = New System.Drawing.Point(343, 33)
        Me.lstusuario_fam.Name = "lstusuario_fam"
        Me.lstusuario_fam.Size = New System.Drawing.Size(144, 95)
        Me.lstusuario_fam.TabIndex = 3
        '
        'lblusu_fam
        '
        Me.lblusu_fam.AutoSize = True
        Me.lblusu_fam.Location = New System.Drawing.Point(340, 17)
        Me.lblusu_fam.Name = "lblusu_fam"
        Me.lblusu_fam.Size = New System.Drawing.Size(57, 13)
        Me.lblusu_fam.TabIndex = 13
        Me.lblusu_fam.Text = "lblusu_fam"
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.Location = New System.Drawing.Point(27, 17)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(49, 13)
        Me.lblFamilia.TabIndex = 12
        Me.lblFamilia.Text = "lblFamilia"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(213, 91)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(92, 29)
        Me.btnQuitar.TabIndex = 2
        Me.btnQuitar.Text = "btnQuitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(524, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(524, 44)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 29)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "btnAceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(213, 45)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 29)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lstfamilia
        '
        Me.lstfamilia.FormattingEnabled = True
        Me.lstfamilia.Location = New System.Drawing.Point(30, 33)
        Me.lstfamilia.Name = "lstfamilia"
        Me.lstfamilia.Size = New System.Drawing.Size(145, 95)
        Me.lstfamilia.TabIndex = 0
        '
        'lstoculto
        '
        Me.lstoculto.FormattingEnabled = True
        Me.lstoculto.Location = New System.Drawing.Point(343, 33)
        Me.lstoculto.Name = "lstoculto"
        Me.lstoculto.Size = New System.Drawing.Size(144, 95)
        Me.lstoculto.TabIndex = 9
        '
        'lstoculto2
        '
        Me.lstoculto2.FormattingEnabled = True
        Me.lstoculto2.Location = New System.Drawing.Point(343, 156)
        Me.lstoculto2.Name = "lstoculto2"
        Me.lstoculto2.Size = New System.Drawing.Size(144, 95)
        Me.lstoculto2.TabIndex = 18
        '
        'gbUsu
        '
        Me.gbUsu.Controls.Add(Me.ckBloqueo)
        Me.gbUsu.Controls.Add(Me.txtMail)
        Me.gbUsu.Controls.Add(Me.lblMail)
        Me.gbUsu.Controls.Add(Me.txtDNI)
        Me.gbUsu.Controls.Add(Me.lblDNI)
        Me.gbUsu.Controls.Add(Me.txtNick)
        Me.gbUsu.Controls.Add(Me.lblNick)
        Me.gbUsu.Controls.Add(Me.CtrlIdioma1)
        Me.gbUsu.Controls.Add(Me.btnCancelarNuevo)
        Me.gbUsu.Controls.Add(Me.lblContrasenaU2)
        Me.gbUsu.Controls.Add(Me.btnNuevo)
        Me.gbUsu.Controls.Add(Me.txtNombreU)
        Me.gbUsu.Controls.Add(Me.lblNombreU)
        Me.gbUsu.Controls.Add(Me.txtContrasenaU2)
        Me.gbUsu.Controls.Add(Me.txtContrasenaU)
        Me.gbUsu.Controls.Add(Me.lblContrasenaU)
        Me.gbUsu.Controls.Add(Me.lblIdiomaU)
        Me.gbUsu.Controls.Add(Me.gbControls)
        Me.gbUsu.Controls.Add(Me.txtCod_Usu)
        Me.gbUsu.Controls.Add(Me.lblusu)
        Me.gbUsu.Location = New System.Drawing.Point(4, 67)
        Me.gbUsu.Name = "gbUsu"
        Me.gbUsu.Size = New System.Drawing.Size(679, 288)
        Me.gbUsu.TabIndex = 4
        Me.gbUsu.TabStop = False
        Me.gbUsu.Text = "gbUsu"
        '
        'ckBloqueo
        '
        Me.ckBloqueo.AutoSize = True
        Me.ckBloqueo.Location = New System.Drawing.Point(213, 15)
        Me.ckBloqueo.Name = "ckBloqueo"
        Me.ckBloqueo.Size = New System.Drawing.Size(77, 17)
        Me.ckBloqueo.TabIndex = 23
        Me.ckBloqueo.Text = "ckBloqueo"
        Me.ckBloqueo.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(135, 182)
        Me.txtMail.MaxLength = 20
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(163, 20)
        Me.txtMail.TabIndex = 21
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(14, 185)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(36, 13)
        Me.lblMail.TabIndex = 22
        Me.lblMail.Text = "lblMail"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(135, 153)
        Me.txtDNI.MaxLength = 20
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(163, 20)
        Me.txtDNI.TabIndex = 19
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(14, 156)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(36, 13)
        Me.lblDNI.TabIndex = 20
        Me.lblDNI.Text = "lblDNI"
        '
        'txtNick
        '
        Me.txtNick.Location = New System.Drawing.Point(135, 126)
        Me.txtNick.MaxLength = 20
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(163, 20)
        Me.txtNick.TabIndex = 17
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.Location = New System.Drawing.Point(14, 129)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(39, 13)
        Me.lblNick.TabIndex = 18
        Me.lblNick.Text = "lblNick"
        '
        'CtrlIdioma1
        '
        Me.CtrlIdioma1.Descripcion = Nothing
        Me.CtrlIdioma1.Idioma = 2
        Me.CtrlIdioma1.Location = New System.Drawing.Point(135, 208)
        Me.CtrlIdioma1.Name = "CtrlIdioma1"
        Me.CtrlIdioma1.Size = New System.Drawing.Size(163, 77)
        Me.CtrlIdioma1.TabIndex = 16
        '
        'btnCancelarNuevo
        '
        Me.btnCancelarNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelarNuevo.Location = New System.Drawing.Point(356, 12)
        Me.btnCancelarNuevo.Name = "btnCancelarNuevo"
        Me.btnCancelarNuevo.Size = New System.Drawing.Size(111, 22)
        Me.btnCancelarNuevo.TabIndex = 8
        Me.btnCancelarNuevo.Text = "Cancelar Nuevo"
        Me.btnCancelarNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCancelarNuevo.UseVisualStyleBackColor = True
        '
        'lblContrasenaU2
        '
        Me.lblContrasenaU2.AutoSize = True
        Me.lblContrasenaU2.Location = New System.Drawing.Point(14, 104)
        Me.lblContrasenaU2.Name = "lblContrasenaU2"
        Me.lblContrasenaU2.Size = New System.Drawing.Size(85, 13)
        Me.lblContrasenaU2.TabIndex = 14
        Me.lblContrasenaU2.Text = "lblContrasenaU2"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNuevo.Location = New System.Drawing.Point(296, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(54, 22)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtNombreU
        '
        Me.txtNombreU.Location = New System.Drawing.Point(135, 47)
        Me.txtNombreU.MaxLength = 20
        Me.txtNombreU.Name = "txtNombreU"
        Me.txtNombreU.Size = New System.Drawing.Size(163, 20)
        Me.txtNombreU.TabIndex = 3
        '
        'lblNombreU
        '
        Me.lblNombreU.AutoSize = True
        Me.lblNombreU.Location = New System.Drawing.Point(14, 50)
        Me.lblNombreU.Name = "lblNombreU"
        Me.lblNombreU.Size = New System.Drawing.Size(62, 13)
        Me.lblNombreU.TabIndex = 12
        Me.lblNombreU.Text = "lblNombreU"
        '
        'txtContrasenaU2
        '
        Me.txtContrasenaU2.Location = New System.Drawing.Point(135, 101)
        Me.txtContrasenaU2.MaxLength = 35
        Me.txtContrasenaU2.Name = "txtContrasenaU2"
        Me.txtContrasenaU2.Size = New System.Drawing.Size(163, 20)
        Me.txtContrasenaU2.TabIndex = 5
        '
        'txtContrasenaU
        '
        Me.txtContrasenaU.Location = New System.Drawing.Point(135, 74)
        Me.txtContrasenaU.MaxLength = 35
        Me.txtContrasenaU.Name = "txtContrasenaU"
        Me.txtContrasenaU.Size = New System.Drawing.Size(163, 20)
        Me.txtContrasenaU.TabIndex = 4
        '
        'lblContrasenaU
        '
        Me.lblContrasenaU.AutoSize = True
        Me.lblContrasenaU.Location = New System.Drawing.Point(14, 77)
        Me.lblContrasenaU.Name = "lblContrasenaU"
        Me.lblContrasenaU.Size = New System.Drawing.Size(79, 13)
        Me.lblContrasenaU.TabIndex = 13
        Me.lblContrasenaU.Text = "lblContrasenaU"
        '
        'lblIdiomaU
        '
        Me.lblIdiomaU.AutoSize = True
        Me.lblIdiomaU.Location = New System.Drawing.Point(14, 218)
        Me.lblIdiomaU.Name = "lblIdiomaU"
        Me.lblIdiomaU.Size = New System.Drawing.Size(56, 13)
        Me.lblIdiomaU.TabIndex = 15
        Me.lblIdiomaU.Text = "lblIdiomaU"
        '
        'gbControls
        '
        Me.gbControls.Controls.Add(Me.btnBuscar)
        Me.gbControls.Controls.Add(Me.btnLimpiar)
        Me.gbControls.Controls.Add(Me.btnActualizar)
        Me.gbControls.Controls.Add(Me.btnEliminar)
        Me.gbControls.Controls.Add(Me.btnRegistrar)
        Me.gbControls.Location = New System.Drawing.Point(310, 47)
        Me.gbControls.Name = "gbControls"
        Me.gbControls.Size = New System.Drawing.Size(365, 163)
        Me.gbControls.TabIndex = 9
        Me.gbControls.TabStop = False
        Me.gbControls.Text = "gbControls"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(181, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(178, 47)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "btnBuscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiar.Location = New System.Drawing.Point(181, 11)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(178, 44)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "btnLimpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnActualizar.Location = New System.Drawing.Point(15, 61)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(160, 44)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "btnActualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminar.Location = New System.Drawing.Point(15, 111)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 44)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "btnEliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"), System.Drawing.Image)
        Me.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistrar.Location = New System.Drawing.Point(15, 11)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(160, 44)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "btnRegistrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtCod_Usu
        '
        Me.txtCod_Usu.Location = New System.Drawing.Point(135, 14)
        Me.txtCod_Usu.Name = "txtCod_Usu"
        Me.txtCod_Usu.Size = New System.Drawing.Size(66, 20)
        Me.txtCod_Usu.TabIndex = 0
        '
        'lblusu
        '
        Me.lblusu.AutoSize = True
        Me.lblusu.Location = New System.Drawing.Point(14, 18)
        Me.lblusu.Name = "lblusu"
        Me.lblusu.Size = New System.Drawing.Size(34, 13)
        Me.lblusu.TabIndex = 10
        Me.lblusu.Text = "lblusu"
        '
        'HlpUser
        '
        Me.HlpUser.HelpNamespace = "C:\temp\Ayuda.chm"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 625)
        Me.Controls.Add(Me.TSUser)
        Me.Controls.Add(Me.gbAdmUsu)
        Me.Controls.Add(Me.gbUsu)
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuario"
        Me.TSUser.ResumeLayout(False)
        Me.TSUser.PerformLayout()
        Me.gbAdmUsu.ResumeLayout(False)
        Me.gbAdmUsu.PerformLayout()
        Me.gbUsu.ResumeLayout(False)
        Me.gbUsu.PerformLayout()
        Me.gbControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSUser As System.Windows.Forms.ToolStrip
    Friend WithEvents BuscarTSMI As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AgregarTSMI As System.Windows.Forms.ToolStripButton
    Friend WithEvents ModificarTSMI As System.Windows.Forms.ToolStripButton
    Friend WithEvents EliminarTSMI As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LimpiarTSMI As System.Windows.Forms.ToolStripButton
    Friend WithEvents AyudaTSMI As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbAdmUsu As System.Windows.Forms.GroupBox
    Friend WithEvents lblpat_usu As System.Windows.Forms.Label
    Friend WithEvents lblPatente As System.Windows.Forms.Label
    Friend WithEvents lstpat_usu As System.Windows.Forms.ListBox
    Friend WithEvents btnQuitarPatente As System.Windows.Forms.Button
    Friend WithEvents btnCancelar2 As System.Windows.Forms.Button
    Friend WithEvents btnAceptar2 As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPatente As System.Windows.Forms.Button
    Friend WithEvents lstpatentes As System.Windows.Forms.ListBox
    Friend WithEvents lstusuario_fam As System.Windows.Forms.ListBox
    Friend WithEvents lblusu_fam As System.Windows.Forms.Label
    Friend WithEvents lblFamilia As System.Windows.Forms.Label
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lstfamilia As System.Windows.Forms.ListBox
    Friend WithEvents lstoculto As System.Windows.Forms.ListBox
    Friend WithEvents lstoculto2 As System.Windows.Forms.ListBox
    Friend WithEvents gbUsu As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelarNuevo As System.Windows.Forms.Button
    Friend WithEvents lblContrasenaU2 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtNombreU As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreU As System.Windows.Forms.Label
    Friend WithEvents txtContrasenaU2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenaU As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenaU As System.Windows.Forms.Label
    Friend WithEvents lblIdiomaU As System.Windows.Forms.Label
    Friend WithEvents gbControls As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtCod_Usu As System.Windows.Forms.TextBox
    Friend WithEvents lblusu As System.Windows.Forms.Label
    Private WithEvents HlpUser As System.Windows.Forms.HelpProvider
    Friend WithEvents CtrlIdioma1 As Idioma_Selector.ctrlIdioma
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtNick As System.Windows.Forms.TextBox
    Friend WithEvents lblNick As System.Windows.Forms.Label
    Friend WithEvents ckBloqueo As System.Windows.Forms.CheckBox
End Class
