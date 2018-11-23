<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFamilia))
        Me.DGVFamilia = New System.Windows.Forms.DataGridView()
        Me.TTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbfam2 = New System.Windows.Forms.GroupBox()
        Me.btnAceptarPat = New System.Windows.Forms.Button()
        Me.btnbaja = New System.Windows.Forms.Button()
        Me.btnalta = New System.Windows.Forms.Button()
        Me.lstpatente = New System.Windows.Forms.CheckedListBox()
        Me.lblfamilia_patente = New System.Windows.Forms.Label()
        Me.lblFamilia = New System.Windows.Forms.Label()
        Me.lstfamilia = New System.Windows.Forms.ListBox()
        Me.btnCancelarNuevo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtID_Familia = New System.Windows.Forms.TextBox()
        Me.gbfam = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gbControls = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblDescri = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Ayuda = New System.Windows.Forms.HelpProvider()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.DGVFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbfam2.SuspendLayout()
        Me.gbfam.SuspendLayout()
        Me.gbControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVFamilia
        '
        Me.DGVFamilia.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFamilia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFamilia.Location = New System.Drawing.Point(9, 154)
        Me.DGVFamilia.Name = "DGVFamilia"
        Me.DGVFamilia.Size = New System.Drawing.Size(295, 109)
        Me.DGVFamilia.TabIndex = 6
        '
        'gbfam2
        '
        Me.gbfam2.Controls.Add(Me.btnAceptarPat)
        Me.gbfam2.Controls.Add(Me.btnbaja)
        Me.gbfam2.Controls.Add(Me.btnalta)
        Me.gbfam2.Controls.Add(Me.lstpatente)
        Me.gbfam2.Controls.Add(Me.lblfamilia_patente)
        Me.gbfam2.Controls.Add(Me.lblFamilia)
        Me.gbfam2.Controls.Add(Me.lstfamilia)
        Me.gbfam2.Location = New System.Drawing.Point(8, 299)
        Me.gbfam2.Name = "gbfam2"
        Me.gbfam2.Size = New System.Drawing.Size(679, 236)
        Me.gbfam2.TabIndex = 5
        Me.gbfam2.TabStop = False
        Me.gbfam2.Text = "Administrar familias"
        '
        'btnAceptarPat
        '
        Me.btnAceptarPat.BackColor = System.Drawing.SystemColors.Info
        Me.btnAceptarPat.Location = New System.Drawing.Point(537, 105)
        Me.btnAceptarPat.Name = "btnAceptarPat"
        Me.btnAceptarPat.Size = New System.Drawing.Size(99, 30)
        Me.btnAceptarPat.TabIndex = 13
        Me.btnAceptarPat.Text = "Modificacion"
        Me.btnAceptarPat.UseVisualStyleBackColor = False
        '
        'btnbaja
        '
        Me.btnbaja.Location = New System.Drawing.Point(562, 105)
        Me.btnbaja.Name = "btnbaja"
        Me.btnbaja.Size = New System.Drawing.Size(52, 23)
        Me.btnbaja.TabIndex = 12
        Me.btnbaja.Text = "baja"
        Me.btnbaja.UseVisualStyleBackColor = True
        Me.btnbaja.Visible = False
        '
        'btnalta
        '
        Me.btnalta.Location = New System.Drawing.Point(562, 105)
        Me.btnalta.Name = "btnalta"
        Me.btnalta.Size = New System.Drawing.Size(52, 23)
        Me.btnalta.TabIndex = 11
        Me.btnalta.Text = "Alta"
        Me.btnalta.UseVisualStyleBackColor = True
        Me.btnalta.Visible = False
        '
        'lstpatente
        '
        Me.lstpatente.FormattingEnabled = True
        Me.lstpatente.Location = New System.Drawing.Point(334, 38)
        Me.lstpatente.Name = "lstpatente"
        Me.lstpatente.Size = New System.Drawing.Size(160, 184)
        Me.lstpatente.TabIndex = 10
        '
        'lblfamilia_patente
        '
        Me.lblfamilia_patente.AutoSize = True
        Me.lblfamilia_patente.Location = New System.Drawing.Point(331, 24)
        Me.lblfamilia_patente.Name = "lblfamilia_patente"
        Me.lblfamilia_patente.Size = New System.Drawing.Size(81, 13)
        Me.lblfamilia_patente.TabIndex = 5
        Me.lblfamilia_patente.Text = "Familia_patente"
        '
        'lblFamilia
        '
        Me.lblFamilia.AutoSize = True
        Me.lblFamilia.Location = New System.Drawing.Point(27, 24)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(44, 13)
        Me.lblFamilia.TabIndex = 0
        Me.lblFamilia.Text = "Familias"
        '
        'lstfamilia
        '
        Me.lstfamilia.FormattingEnabled = True
        Me.lstfamilia.Location = New System.Drawing.Point(30, 38)
        Me.lstfamilia.Name = "lstfamilia"
        Me.lstfamilia.Size = New System.Drawing.Size(161, 186)
        Me.lstfamilia.TabIndex = 1
        '
        'btnCancelarNuevo
        '
        Me.btnCancelarNuevo.BackColor = System.Drawing.SystemColors.Info
        Me.btnCancelarNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelarNuevo.Location = New System.Drawing.Point(198, 33)
        Me.btnCancelarNuevo.Name = "btnCancelarNuevo"
        Me.btnCancelarNuevo.Size = New System.Drawing.Size(111, 22)
        Me.btnCancelarNuevo.TabIndex = 3
        Me.btnCancelarNuevo.Text = "Cancelar Nuevo"
        Me.btnCancelarNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCancelarNuevo.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Info
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(15, 116)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(160, 47)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Info
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNuevo.Location = New System.Drawing.Point(138, 33)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(54, 22)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(6, 37)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.Info
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnActualizar.Location = New System.Drawing.Point(15, 66)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(160, 44)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'txtID_Familia
        '
        Me.txtID_Familia.Location = New System.Drawing.Point(75, 34)
        Me.txtID_Familia.Name = "txtID_Familia"
        Me.txtID_Familia.Size = New System.Drawing.Size(58, 20)
        Me.txtID_Familia.TabIndex = 1
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
        Me.gbfam.Location = New System.Drawing.Point(12, 12)
        Me.gbfam.Name = "gbfam"
        Me.gbfam.Size = New System.Drawing.Size(679, 281)
        Me.gbfam.TabIndex = 4
        Me.gbfam.TabStop = False
        Me.gbfam.Text = "Familias"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 64)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(75, 61)
        Me.txtNombre.MaxLength = 35
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(229, 20)
        Me.txtNombre.TabIndex = 8
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.gbControls.Size = New System.Drawing.Size(358, 176)
        Me.gbControls.TabIndex = 7
        Me.gbControls.TabStop = False
        Me.gbControls.Text = "Controles"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Info
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminar.Location = New System.Drawing.Point(181, 66)
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
        Me.btnRegistrar.Location = New System.Drawing.Point(15, 16)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(160, 44)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'lblDescri
        '
        Me.lblDescri.AutoSize = True
        Me.lblDescri.Location = New System.Drawing.Point(6, 90)
        Me.lblDescri.Name = "lblDescri"
        Me.lblDescri.Size = New System.Drawing.Size(63, 13)
        Me.lblDescri.TabIndex = 4
        Me.lblDescri.Text = "Descripcion"
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
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Info
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiar.Location = New System.Drawing.Point(181, 16)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(160, 44)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'frmFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(692, 541)
        Me.Controls.Add(Me.gbfam2)
        Me.Controls.Add(Me.gbfam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFamilia"
        Me.Text = ".:.Administracion de Familia .:."
        CType(Me.DGVFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbfam2.ResumeLayout(False)
        Me.gbfam2.PerformLayout()
        Me.gbfam.ResumeLayout(False)
        Me.gbfam.PerformLayout()
        Me.gbControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVFamilia As System.Windows.Forms.DataGridView
    Friend WithEvents TTT As System.Windows.Forms.ToolTip
    Friend WithEvents gbfam2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfamilia_patente As System.Windows.Forms.Label
    Friend WithEvents lblFamilia As System.Windows.Forms.Label
    Friend WithEvents lstfamilia As System.Windows.Forms.ListBox
    Friend WithEvents btnCancelarNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtID_Familia As System.Windows.Forms.TextBox
    Friend WithEvents gbfam As System.Windows.Forms.GroupBox
    Friend WithEvents gbControls As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblDescri As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents Ayuda As System.Windows.Forms.HelpProvider
    Friend WithEvents lstpatente As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAceptarPat As System.Windows.Forms.Button
    Friend WithEvents btnbaja As System.Windows.Forms.Button
    Friend WithEvents btnalta As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
End Class
