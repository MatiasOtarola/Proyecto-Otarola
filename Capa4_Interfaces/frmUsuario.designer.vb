<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.btnCancelarNuevo = New System.Windows.Forms.Button()
        Me.lblContrasenaU2 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreU = New System.Windows.Forms.TextBox()
        Me.lblNombreU = New System.Windows.Forms.Label()
        Me.txtContrasenaU2 = New System.Windows.Forms.TextBox()
        Me.txtContrasenaU = New System.Windows.Forms.TextBox()
        Me.lblContrasenaU = New System.Windows.Forms.Label()
        Me.lblIdiomaU = New System.Windows.Forms.Label()
        Me.tsNombre = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsID = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ayuda = New System.Windows.Forms.HelpProvider()
        Me.gbAdmUsu = New System.Windows.Forms.GroupBox()
        Me.lstfamilia = New System.Windows.Forms.CheckedListBox()
        Me.btnAceptarPat2 = New System.Windows.Forms.Button()
        Me.btnbaja2 = New System.Windows.Forms.Button()
        Me.btnalta2 = New System.Windows.Forms.Button()
        Me.btnAceptarPat = New System.Windows.Forms.Button()
        Me.lblPatentes = New System.Windows.Forms.Label()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.btnalta = New System.Windows.Forms.Button()
        Me.lstpatente = New System.Windows.Forms.CheckedListBox()
        Me.ltbusuario = New System.Windows.Forms.ListBox()
        Me.lblFamilias = New System.Windows.Forms.Label()
        Me.gbControls = New System.Windows.Forms.GroupBox()
        Me.txtCod_Usu = New System.Windows.Forms.TextBox()
        Me.lblusu = New System.Windows.Forms.Label()
        Me.gbUsu = New System.Windows.Forms.GroupBox()
        Me.CtrlIdioma1 = New Idioma_Selector.ctrlIdioma()
        Me.ckBloqueo = New System.Windows.Forms.CheckBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtNick = New System.Windows.Forms.TextBox()
        Me.lblNick = New System.Windows.Forms.Label()
        Me.TTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.gbAdmUsu.SuspendLayout()
        Me.gbControls.SuspendLayout()
        Me.gbUsu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelarNuevo
        '
        Me.btnCancelarNuevo.BackColor = System.Drawing.SystemColors.Info
        Me.btnCancelarNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelarNuevo.Location = New System.Drawing.Point(350, 13)
        Me.btnCancelarNuevo.Name = "btnCancelarNuevo"
        Me.btnCancelarNuevo.Size = New System.Drawing.Size(111, 22)
        Me.btnCancelarNuevo.TabIndex = 8
        Me.btnCancelarNuevo.Text = "Cancelar Nuevo"
        Me.btnCancelarNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCancelarNuevo.UseVisualStyleBackColor = False
        '
        'lblContrasenaU2
        '
        Me.lblContrasenaU2.AutoSize = True
        Me.lblContrasenaU2.Location = New System.Drawing.Point(14, 101)
        Me.lblContrasenaU2.Name = "lblContrasenaU2"
        Me.lblContrasenaU2.Size = New System.Drawing.Size(103, 13)
        Me.lblContrasenaU2.TabIndex = 14
        Me.lblContrasenaU2.Text = "ContrasenaUsuario2"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Info
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNuevo.Location = New System.Drawing.Point(290, 13)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(54, 22)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'txtNombreU
        '
        Me.txtNombreU.Location = New System.Drawing.Point(135, 44)
        Me.txtNombreU.MaxLength = 20
        Me.txtNombreU.Name = "txtNombreU"
        Me.txtNombreU.Size = New System.Drawing.Size(107, 20)
        Me.txtNombreU.TabIndex = 3
        '
        'lblNombreU
        '
        Me.lblNombreU.AutoSize = True
        Me.lblNombreU.Location = New System.Drawing.Point(14, 47)
        Me.lblNombreU.Name = "lblNombreU"
        Me.lblNombreU.Size = New System.Drawing.Size(80, 13)
        Me.lblNombreU.TabIndex = 12
        Me.lblNombreU.Text = "NombreUsuario"
        '
        'txtContrasenaU2
        '
        Me.txtContrasenaU2.Location = New System.Drawing.Point(135, 98)
        Me.txtContrasenaU2.MaxLength = 35
        Me.txtContrasenaU2.Name = "txtContrasenaU2"
        Me.txtContrasenaU2.Size = New System.Drawing.Size(107, 20)
        Me.txtContrasenaU2.TabIndex = 5
        Me.txtContrasenaU2.UseSystemPasswordChar = True
        '
        'txtContrasenaU
        '
        Me.txtContrasenaU.Location = New System.Drawing.Point(135, 71)
        Me.txtContrasenaU.MaxLength = 35
        Me.txtContrasenaU.Name = "txtContrasenaU"
        Me.txtContrasenaU.Size = New System.Drawing.Size(107, 20)
        Me.txtContrasenaU.TabIndex = 4
        Me.txtContrasenaU.UseSystemPasswordChar = True
        '
        'lblContrasenaU
        '
        Me.lblContrasenaU.AutoSize = True
        Me.lblContrasenaU.Location = New System.Drawing.Point(14, 74)
        Me.lblContrasenaU.Name = "lblContrasenaU"
        Me.lblContrasenaU.Size = New System.Drawing.Size(97, 13)
        Me.lblContrasenaU.TabIndex = 13
        Me.lblContrasenaU.Text = "ContrasenaUsuario"
        '
        'lblIdiomaU
        '
        Me.lblIdiomaU.AutoSize = True
        Me.lblIdiomaU.Location = New System.Drawing.Point(14, 211)
        Me.lblIdiomaU.Name = "lblIdiomaU"
        Me.lblIdiomaU.Size = New System.Drawing.Size(74, 13)
        Me.lblIdiomaU.TabIndex = 15
        Me.lblIdiomaU.Text = "IdiomaUsuario"
        '
        'tsNombre
        '
        Me.tsNombre.Name = "tsNombre"
        Me.tsNombre.Size = New System.Drawing.Size(111, 22)
        Me.tsNombre.Text = "Nombre"
        '
        'tsID
        '
        Me.tsID.Name = "tsID"
        Me.tsID.Size = New System.Drawing.Size(111, 22)
        Me.tsID.Text = "ID"
        '
        'Ayuda
        '
        Me.Ayuda.HelpNamespace = ""
        '
        'gbAdmUsu
        '
        Me.gbAdmUsu.Controls.Add(Me.lstfamilia)
        Me.gbAdmUsu.Controls.Add(Me.btnAceptarPat2)
        Me.gbAdmUsu.Controls.Add(Me.btnbaja2)
        Me.gbAdmUsu.Controls.Add(Me.btnalta2)
        Me.gbAdmUsu.Controls.Add(Me.btnAceptarPat)
        Me.gbAdmUsu.Controls.Add(Me.lblPatentes)
        Me.gbAdmUsu.Controls.Add(Me.btnbaja)
        Me.gbAdmUsu.Controls.Add(Me.lblUsuarios)
        Me.gbAdmUsu.Controls.Add(Me.btnalta)
        Me.gbAdmUsu.Controls.Add(Me.lstpatente)
        Me.gbAdmUsu.Controls.Add(Me.ltbusuario)
        Me.gbAdmUsu.Controls.Add(Me.lblFamilias)
        Me.gbAdmUsu.Location = New System.Drawing.Point(4, 312)
        Me.gbAdmUsu.Name = "gbAdmUsu"
        Me.gbAdmUsu.Size = New System.Drawing.Size(679, 261)
        Me.gbAdmUsu.TabIndex = 5
        Me.gbAdmUsu.TabStop = False
        Me.gbAdmUsu.Text = "Administracion de usuarios"
        '
        'lstfamilia
        '
        Me.lstfamilia.FormattingEnabled = True
        Me.lstfamilia.Location = New System.Drawing.Point(340, 31)
        Me.lstfamilia.Name = "lstfamilia"
        Me.lstfamilia.Size = New System.Drawing.Size(145, 94)
        Me.lstfamilia.TabIndex = 19
        '
        'btnAceptarPat2
        '
        Me.btnAceptarPat2.BackColor = System.Drawing.SystemColors.Info
        Me.btnAceptarPat2.Location = New System.Drawing.Point(524, 63)
        Me.btnAceptarPat2.Name = "btnAceptarPat2"
        Me.btnAceptarPat2.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptarPat2.TabIndex = 18
        Me.btnAceptarPat2.Text = "Modificacion"
        Me.btnAceptarPat2.UseVisualStyleBackColor = False
        '
        'btnbaja2
        '
        Me.btnbaja2.BackColor = System.Drawing.SystemColors.Info
        Me.btnbaja2.Location = New System.Drawing.Point(534, 63)
        Me.btnbaja2.Name = "btnbaja2"
        Me.btnbaja2.Size = New System.Drawing.Size(52, 23)
        Me.btnbaja2.TabIndex = 17
        Me.btnbaja2.Text = "baja"
        Me.btnbaja2.UseVisualStyleBackColor = False
        Me.btnbaja2.Visible = False
        '
        'btnalta2
        '
        Me.btnalta2.BackColor = System.Drawing.SystemColors.Info
        Me.btnalta2.Location = New System.Drawing.Point(534, 63)
        Me.btnalta2.Name = "btnalta2"
        Me.btnalta2.Size = New System.Drawing.Size(52, 23)
        Me.btnalta2.TabIndex = 16
        Me.btnalta2.Text = "Alta"
        Me.btnalta2.UseVisualStyleBackColor = False
        Me.btnalta2.Visible = False
        '
        'btnAceptarPat
        '
        Me.btnAceptarPat.BackColor = System.Drawing.SystemColors.Info
        Me.btnAceptarPat.Location = New System.Drawing.Point(524, 179)
        Me.btnAceptarPat.Name = "btnAceptarPat"
        Me.btnAceptarPat.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptarPat.TabIndex = 10
        Me.btnAceptarPat.Text = "Modificacion"
        Me.btnAceptarPat.UseVisualStyleBackColor = False
        '
        'lblPatentes
        '
        Me.lblPatentes.AutoSize = True
        Me.lblPatentes.Location = New System.Drawing.Point(340, 140)
        Me.lblPatentes.Name = "lblPatentes"
        Me.lblPatentes.Size = New System.Drawing.Size(49, 13)
        Me.lblPatentes.TabIndex = 15
        Me.lblPatentes.Text = "Patentes"
        '
        'btnbaja
        '
        Me.btnbaja.BackColor = System.Drawing.SystemColors.Info
        Me.btnbaja.Location = New System.Drawing.Point(553, 186)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(52, 23)
        Me.btnbaja.TabIndex = 9
        Me.btnbaja.Text = "baja"
        Me.btnbaja.UseVisualStyleBackColor = False
        Me.btnbaja.Visible = False
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Location = New System.Drawing.Point(119, 11)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(48, 13)
        Me.lblUsuarios.TabIndex = 14
        Me.lblUsuarios.Text = "Usuarios"
        '
        'btnalta
        '
        Me.btnalta.BackColor = System.Drawing.SystemColors.Info
        Me.btnalta.Location = New System.Drawing.Point(553, 186)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(52, 23)
        Me.btnalta.TabIndex = 8
        Me.btnalta.Text = "Alta"
        Me.btnalta.UseVisualStyleBackColor = False
        Me.btnalta.Visible = False
        '
        'lstpatente
        '
        Me.lstpatente.FormattingEnabled = True
        Me.lstpatente.Location = New System.Drawing.Point(340, 156)
        Me.lstpatente.Name = "lstpatente"
        Me.lstpatente.Size = New System.Drawing.Size(145, 94)
        Me.lstpatente.TabIndex = 7
        '
        'ltbusuario
        '
        Me.ltbusuario.FormattingEnabled = True
        Me.ltbusuario.Location = New System.Drawing.Point(122, 31)
        Me.ltbusuario.Name = "ltbusuario"
        Me.ltbusuario.Size = New System.Drawing.Size(145, 212)
        Me.ltbusuario.TabIndex = 6
        '
        'lblFamilias
        '
        Me.lblFamilias.AutoSize = True
        Me.lblFamilias.Location = New System.Drawing.Point(340, 14)
        Me.lblFamilias.Name = "lblFamilias"
        Me.lblFamilias.Size = New System.Drawing.Size(44, 13)
        Me.lblFamilias.TabIndex = 12
        Me.lblFamilias.Text = "Familias"
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
        Me.gbControls.Size = New System.Drawing.Size(365, 166)
        Me.gbControls.TabIndex = 9
        Me.gbControls.TabStop = False
        Me.gbControls.Text = "Controles"
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
        Me.lblusu.Size = New System.Drawing.Size(41, 13)
        Me.lblusu.TabIndex = 10
        Me.lblusu.Text = "usuario"
        '
        'gbUsu
        '
        Me.gbUsu.Controls.Add(Me.CtrlIdioma1)
        Me.gbUsu.Controls.Add(Me.ckBloqueo)
        Me.gbUsu.Controls.Add(Me.txtMail)
        Me.gbUsu.Controls.Add(Me.lblMail)
        Me.gbUsu.Controls.Add(Me.txtDNI)
        Me.gbUsu.Controls.Add(Me.lblDNI)
        Me.gbUsu.Controls.Add(Me.txtNick)
        Me.gbUsu.Controls.Add(Me.lblNick)
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
        Me.gbUsu.Location = New System.Drawing.Point(4, 12)
        Me.gbUsu.Name = "gbUsu"
        Me.gbUsu.Size = New System.Drawing.Size(679, 294)
        Me.gbUsu.TabIndex = 4
        Me.gbUsu.TabStop = False
        Me.gbUsu.Text = "Usuario"
        '
        'CtrlIdioma1
        '
        Me.CtrlIdioma1.Descripcion = Nothing
        Me.CtrlIdioma1.Idioma = 2
        Me.CtrlIdioma1.Location = New System.Drawing.Point(135, 211)
        Me.CtrlIdioma1.Name = "CtrlIdioma1"
        Me.CtrlIdioma1.Size = New System.Drawing.Size(163, 77)
        Me.CtrlIdioma1.TabIndex = 30
        '
        'ckBloqueo
        '
        Me.ckBloqueo.AutoSize = True
        Me.ckBloqueo.Location = New System.Drawing.Point(207, 16)
        Me.ckBloqueo.Name = "ckBloqueo"
        Me.ckBloqueo.Size = New System.Drawing.Size(77, 17)
        Me.ckBloqueo.TabIndex = 29
        Me.ckBloqueo.Text = "ckBloqueo"
        Me.ckBloqueo.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(135, 180)
        Me.txtMail.MaxLength = 20
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(163, 20)
        Me.txtMail.TabIndex = 27
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(14, 183)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(26, 13)
        Me.lblMail.TabIndex = 28
        Me.lblMail.Text = "Mail"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(135, 151)
        Me.txtDNI.MaxLength = 20
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(163, 20)
        Me.txtDNI.TabIndex = 25
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(14, 154)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(26, 13)
        Me.lblDNI.TabIndex = 26
        Me.lblDNI.Text = "DNI"
        '
        'txtNick
        '
        Me.txtNick.Location = New System.Drawing.Point(135, 124)
        Me.txtNick.MaxLength = 20
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(163, 20)
        Me.txtNick.TabIndex = 23
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.Location = New System.Drawing.Point(14, 127)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(29, 13)
        Me.lblNick.TabIndex = 24
        Me.lblNick.Text = "Nick"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Info
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(181, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(178, 47)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Info
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiar.Location = New System.Drawing.Point(181, 11)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(178, 44)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.Info
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnActualizar.Location = New System.Drawing.Point(15, 61)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(160, 44)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Info
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminar.Location = New System.Drawing.Point(15, 111)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 44)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.Info
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistrar.Location = New System.Drawing.Point(15, 11)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(160, 44)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(690, 612)
        Me.Controls.Add(Me.gbAdmUsu)
        Me.Controls.Add(Me.gbUsu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmUsuario"
        Me.Text = ".:. Administrar Usuarios .:."
        Me.gbAdmUsu.ResumeLayout(False)
        Me.gbAdmUsu.PerformLayout()
        Me.gbControls.ResumeLayout(False)
        Me.gbUsu.ResumeLayout(False)
        Me.gbUsu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelarNuevo As System.Windows.Forms.Button
    Friend WithEvents lblContrasenaU2 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txtNombreU As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreU As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtContrasenaU2 As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenaU As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenaU As System.Windows.Forms.Label
    Friend WithEvents lblIdiomaU As System.Windows.Forms.Label
    Friend WithEvents tsNombre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsID As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Ayuda As System.Windows.Forms.HelpProvider
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbAdmUsu As System.Windows.Forms.GroupBox
    Friend WithEvents lblFamilias As System.Windows.Forms.Label
    Friend WithEvents gbControls As System.Windows.Forms.GroupBox
    Friend WithEvents txtCod_Usu As System.Windows.Forms.TextBox
    Friend WithEvents lblusu As System.Windows.Forms.Label
    Friend WithEvents gbUsu As System.Windows.Forms.GroupBox
    Friend WithEvents TTT As System.Windows.Forms.ToolTip
    Friend WithEvents ltbusuario As System.Windows.Forms.ListBox
    Friend WithEvents lstpatente As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnalta As System.Windows.Forms.Button
    Friend WithEvents btnbaja As System.Windows.Forms.Button
    Friend WithEvents btnAceptarPat As System.Windows.Forms.Button
    Friend WithEvents lblPatentes As System.Windows.Forms.Label
    Friend WithEvents lblUsuarios As System.Windows.Forms.Label
    Friend WithEvents lstfamilia As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAceptarPat2 As System.Windows.Forms.Button
    Friend WithEvents btnbaja2 As System.Windows.Forms.Button
    Friend WithEvents btnalta2 As System.Windows.Forms.Button
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents txtNick As System.Windows.Forms.TextBox
    Friend WithEvents lblNick As System.Windows.Forms.Label
    Friend WithEvents ckBloqueo As System.Windows.Forms.CheckBox
    Friend WithEvents CtrlIdioma1 As Idioma_Selector.ctrlIdioma
End Class
