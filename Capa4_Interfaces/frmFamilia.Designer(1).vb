<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFamilias))
        Me.gbfam2 = New System.Windows.Forms.GroupBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstFamiliaPatente = New System.Windows.Forms.ListBox()
        Me.lblMiembroDe = New System.Windows.Forms.Label()
        Me.lblPatente = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lstPatentes = New System.Windows.Forms.ListBox()
        Me.lstoculto = New System.Windows.Forms.ListBox()
        Me.lstusuarios = New System.Windows.Forms.ListBox()
        Me.gbfam = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCancelarNuevo = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DGVFamilia = New System.Windows.Forms.DataGridView()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID_Familia = New System.Windows.Forms.TextBox()
        Me.gbControls = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblDescri = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.gbfam2.SuspendLayout()
        Me.gbfam.SuspendLayout()
        CType(Me.DGVFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbfam2
        '
        Me.gbfam2.Controls.Add(Me.btnQuitar)
        Me.gbfam2.Controls.Add(Me.btnAgregar)
        Me.gbfam2.Controls.Add(Me.lstFamiliaPatente)
        Me.gbfam2.Controls.Add(Me.lblMiembroDe)
        Me.gbfam2.Controls.Add(Me.lblPatente)
        Me.gbfam2.Controls.Add(Me.btnCancelar)
        Me.gbfam2.Controls.Add(Me.btnAceptar)
        Me.gbfam2.Controls.Add(Me.lstPatentes)
        Me.gbfam2.Controls.Add(Me.lstoculto)
        Me.gbfam2.Controls.Add(Me.lstusuarios)
        Me.gbfam2.Location = New System.Drawing.Point(4, 319)
        Me.gbfam2.Name = "gbfam2"
        Me.gbfam2.Size = New System.Drawing.Size(679, 236)
        Me.gbfam2.TabIndex = 5
        Me.gbfam2.TabStop = False
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(210, 143)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(99, 30)
        Me.btnQuitar.TabIndex = 4
        Me.btnQuitar.Text = "btnQuitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(210, 93)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(99, 30)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lstFamiliaPatente
        '
        Me.lstFamiliaPatente.FormattingEnabled = True
        Me.lstFamiliaPatente.Location = New System.Drawing.Point(334, 40)
        Me.lstFamiliaPatente.Name = "lstFamiliaPatente"
        Me.lstFamiliaPatente.Size = New System.Drawing.Size(161, 186)
        Me.lstFamiliaPatente.TabIndex = 6
        '
        'lblMiembroDe
        '
        Me.lblMiembroDe.AutoSize = True
        Me.lblMiembroDe.Location = New System.Drawing.Point(331, 24)
        Me.lblMiembroDe.Name = "lblMiembroDe"
        Me.lblMiembroDe.Size = New System.Drawing.Size(57, 13)
        Me.lblMiembroDe.TabIndex = 5
        Me.lblMiembroDe.Text = "lblusu_fam"
        '
        'lblPatente
        '
        Me.lblPatente.AutoSize = True
        Me.lblPatente.Location = New System.Drawing.Point(27, 24)
        Me.lblPatente.Name = "lblPatente"
        Me.lblPatente.Size = New System.Drawing.Size(54, 13)
        Me.lblPatente.TabIndex = 0
        Me.lblPatente.Text = "lblPatente"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(535, 143)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(99, 30)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(535, 97)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "btnAceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lstPatentes
        '
        Me.lstPatentes.FormattingEnabled = True
        Me.lstPatentes.Location = New System.Drawing.Point(30, 40)
        Me.lstPatentes.Name = "lstPatentes"
        Me.lstPatentes.Size = New System.Drawing.Size(161, 186)
        Me.lstPatentes.TabIndex = 1
        '
        'lstoculto
        '
        Me.lstoculto.FormattingEnabled = True
        Me.lstoculto.Location = New System.Drawing.Point(334, 40)
        Me.lstoculto.Name = "lstoculto"
        Me.lstoculto.Size = New System.Drawing.Size(161, 186)
        Me.lstoculto.TabIndex = 9
        '
        'lstusuarios
        '
        Me.lstusuarios.FormattingEnabled = True
        Me.lstusuarios.Location = New System.Drawing.Point(30, 40)
        Me.lstusuarios.Name = "lstusuarios"
        Me.lstusuarios.Size = New System.Drawing.Size(161, 186)
        Me.lstusuarios.TabIndex = 2
        '
        'gbfam
        '
        Me.gbfam.Controls.Add(Me.lblNombre)
        Me.gbfam.Controls.Add(Me.txtNombre)
        Me.gbfam.Controls.Add(Me.btnCancelarNuevo)
        Me.gbfam.Controls.Add(Me.btnNuevo)
        Me.gbfam.Controls.Add(Me.DGVFamilia)
        Me.gbfam.Controls.Add(Me.lblID)
        Me.gbfam.Controls.Add(Me.txtID_Familia)
        Me.gbfam.Controls.Add(Me.gbControls)
        Me.gbfam.Controls.Add(Me.lblDescri)
        Me.gbfam.Controls.Add(Me.txtDescripcion)
        Me.gbfam.Location = New System.Drawing.Point(5, 12)
        Me.gbfam.Name = "gbfam"
        Me.gbfam.Size = New System.Drawing.Size(679, 281)
        Me.gbfam.TabIndex = 4
        Me.gbfam.TabStop = False
        Me.gbfam.Text = "gbfam"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 63)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "lblNombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(229, 20)
        Me.txtNombre.TabIndex = 8
        '
        'btnCancelarNuevo
        '
        Me.btnCancelarNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelarNuevo.Location = New System.Drawing.Point(198, 33)
        Me.btnCancelarNuevo.Name = "btnCancelarNuevo"
        Me.btnCancelarNuevo.Size = New System.Drawing.Size(111, 22)
        Me.btnCancelarNuevo.TabIndex = 3
        Me.btnCancelarNuevo.Text = "Cancelar Nuevo"
        Me.btnCancelarNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCancelarNuevo.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNuevo.Location = New System.Drawing.Point(138, 33)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(54, 22)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'DGVFamilia
        '
        Me.DGVFamilia.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFamilia.Location = New System.Drawing.Point(9, 154)
        Me.DGVFamilia.Name = "DGVFamilia"
        Me.DGVFamilia.Size = New System.Drawing.Size(295, 109)
        Me.DGVFamilia.TabIndex = 6
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 37)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(28, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "lblID"
        '
        'txtID_Familia
        '
        Me.txtID_Familia.Location = New System.Drawing.Point(75, 34)
        Me.txtID_Familia.Name = "txtID_Familia"
        Me.txtID_Familia.Size = New System.Drawing.Size(58, 20)
        Me.txtID_Familia.TabIndex = 1
        '
        'gbControls
        '
        Me.gbControls.Controls.Add(Me.btnBuscar)
        Me.gbControls.Controls.Add(Me.btnLimpiar)
        Me.gbControls.Controls.Add(Me.btnActualizar)
        Me.gbControls.Controls.Add(Me.btnEliminar)
        Me.gbControls.Controls.Add(Me.btnRegistrar)
        Me.gbControls.Location = New System.Drawing.Point(310, 43)
        Me.gbControls.Name = "gbControls"
        Me.gbControls.Size = New System.Drawing.Size(365, 168)
        Me.gbControls.TabIndex = 7
        Me.gbControls.TabStop = False
        Me.gbControls.Text = "gbControls"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
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
        Me.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistrar.Location = New System.Drawing.Point(15, 11)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(160, 44)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "btnRegistrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblDescri
        '
        Me.lblDescri.AutoSize = True
        Me.lblDescri.Location = New System.Drawing.Point(6, 90)
        Me.lblDescri.Name = "lblDescri"
        Me.lblDescri.Size = New System.Drawing.Size(47, 13)
        Me.lblDescri.TabIndex = 4
        Me.lblDescri.Text = "lblDescri"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(75, 87)
        Me.txtDescripcion.MaxLength = 35
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(229, 61)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "C:\temp\Ayuda.chm"
        '
        'frmFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 564)
        Me.Controls.Add(Me.gbfam2)
        Me.Controls.Add(Me.gbfam)
        Me.Name = "frmFamilias"
        Me.Text = "frmFamilia"
        Me.gbfam2.ResumeLayout(False)
        Me.gbfam2.PerformLayout()
        Me.gbfam.ResumeLayout(False)
        Me.gbfam.PerformLayout()
        CType(Me.DGVFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbfam2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents lstFamiliaPatente As System.Windows.Forms.ListBox
    Friend WithEvents lblMiembroDe As System.Windows.Forms.Label
    Friend WithEvents lblPatente As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lstPatentes As System.Windows.Forms.ListBox
    Friend WithEvents lstoculto As System.Windows.Forms.ListBox
    Friend WithEvents lstusuarios As System.Windows.Forms.ListBox
    Friend WithEvents gbfam As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelarNuevo As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents DGVFamilia As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID_Familia As System.Windows.Forms.TextBox
    Friend WithEvents gbControls As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblDescri As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
End Class
