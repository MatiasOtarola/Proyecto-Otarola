<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.lninexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprecio_venta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbuscarcategoria = New System.Windows.Forms.Button()
        Me.txtnombre_categoria = New System.Windows.Forms.TextBox()
        Me.txtprecio_compra = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.txtnombreproducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btnborrar)
        Me.GroupBox2.Controls.Add(Me.lninexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.GroupBox2.Location = New System.Drawing.Point(495, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 477)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de productos"
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(30, 75)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(80, 19)
        Me.cbeliminar.TabIndex = 4
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.Crimson
        Me.btnborrar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnborrar.Location = New System.Drawing.Point(17, 448)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(75, 23)
        Me.btnborrar.TabIndex = 3
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'lninexistente
        '
        Me.lninexistente.AutoSize = True
        Me.lninexistente.LinkColor = System.Drawing.Color.Lime
        Me.lninexistente.Location = New System.Drawing.Point(224, 240)
        Me.lninexistente.Name = "lninexistente"
        Me.lninexistente.Size = New System.Drawing.Size(125, 15)
        Me.lninexistente.TabIndex = 3
        Me.lninexistente.TabStop = True
        Me.lninexistente.Text = "Datos inexistentes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(227, 35)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(215, 21)
        Me.txtbuscar.TabIndex = 2
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"Nombre", "Nombre_categoria"})
        Me.cbocampo.Location = New System.Drawing.Point(30, 35)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(169, 23)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "Nombre"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(17, 100)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(575, 330)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btncargar)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtprecio_venta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcategoria)
        Me.GroupBox1.Controls.Add(Me.txtnombre_categoria)
        Me.GroupBox1.Controls.Add(Me.txtprecio_compra)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.txtnombreproducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.GroupBox1.Location = New System.Drawing.Point(29, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 457)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Crimson
        Me.btnguardar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnguardar.Location = New System.Drawing.Point(141, 375)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(78, 23)
        Me.btnguardar.TabIndex = 28
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.Crimson
        Me.btncancelar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btncancelar.Location = New System.Drawing.Point(268, 375)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 27
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.Crimson
        Me.btneditar.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btneditar.Location = New System.Drawing.Point(141, 375)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(78, 23)
        Me.btneditar.TabIndex = 26
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Crimson
        Me.btnnuevo.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnnuevo.Location = New System.Drawing.Point(6, 375)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(116, 23)
        Me.btnnuevo.TabIndex = 25
        Me.btnnuevo.Text = "Nuevo producto"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Imagen"
        '
        'txtprecio_venta
        '
        Me.txtprecio_venta.Location = New System.Drawing.Point(151, 235)
        Me.txtprecio_venta.MaxLength = 8
        Me.txtprecio_venta.Name = "txtprecio_venta"
        Me.txtprecio_venta.Size = New System.Drawing.Size(108, 21)
        Me.txtprecio_venta.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Precio_venta"
        '
        'btnbuscarcategoria
        '
        Me.btnbuscarcategoria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnbuscarcategoria.ForeColor = System.Drawing.Color.Indigo
        Me.btnbuscarcategoria.Location = New System.Drawing.Point(383, 81)
        Me.btnbuscarcategoria.Name = "btnbuscarcategoria"
        Me.btnbuscarcategoria.Size = New System.Drawing.Size(43, 23)
        Me.btnbuscarcategoria.TabIndex = 15
        Me.btnbuscarcategoria.Text = "..."
        Me.btnbuscarcategoria.UseVisualStyleBackColor = False
        '
        'txtnombre_categoria
        '
        Me.txtnombre_categoria.Location = New System.Drawing.Point(234, 83)
        Me.txtnombre_categoria.Name = "txtnombre_categoria"
        Me.txtnombre_categoria.Size = New System.Drawing.Size(131, 21)
        Me.txtnombre_categoria.TabIndex = 14
        '
        'txtprecio_compra
        '
        Me.txtprecio_compra.Location = New System.Drawing.Point(151, 200)
        Me.txtprecio_compra.MaxLength = 8
        Me.txtprecio_compra.Name = "txtprecio_compra"
        Me.txtprecio_compra.Size = New System.Drawing.Size(108, 21)
        Me.txtprecio_compra.TabIndex = 12
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(151, 169)
        Me.txtstock.MaxLength = 10
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(108, 21)
        Me.txtstock.TabIndex = 11
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(151, 123)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(214, 40)
        Me.txtdescripcion.TabIndex = 10
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(151, 83)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(61, 21)
        Me.txtidcategoria.TabIndex = 9
        '
        'txtnombreproducto
        '
        Me.txtnombreproducto.Location = New System.Drawing.Point(151, 49)
        Me.txtnombreproducto.Name = "txtnombreproducto"
        Me.txtnombreproducto.Size = New System.Drawing.Size(131, 21)
        Me.txtnombreproducto.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Precio_compra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID producto"
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(151, 17)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(131, 21)
        Me.txtidproducto.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.Label10.Location = New System.Drawing.Point(88, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(244, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Registro de productos"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(372, 12)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(51, 20)
        Me.txtflag.TabIndex = 13
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImage = Global.Capa4_Interfaces.My.Resources.Resources.eliminar
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Location = New System.Drawing.Point(357, 344)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(69, 66)
        Me.btnlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnlimpiar.TabIndex = 24
        Me.btnlimpiar.TabStop = False
        '
        'btncargar
        '
        Me.btncargar.BackgroundImage = Global.Capa4_Interfaces.My.Resources.Resources.agregar
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncargar.Location = New System.Drawing.Point(357, 251)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(69, 66)
        Me.btncargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncargar.TabIndex = 23
        Me.btncargar.TabStop = False
        '
        'imagen
        '
        Me.imagen.BackgroundImage = Global.Capa4_Interfaces.My.Resources.Resources.imagen_transparente
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Location = New System.Drawing.Point(151, 287)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(143, 64)
        Me.imagen.TabIndex = 22
        Me.imagen.TabStop = False
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1142, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtflag)
        Me.Name = "frmProducto"
        Me.Text = ".:. Listado del catalago de productos .:."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents lninexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.PictureBox
    Friend WithEvents btncargar As System.Windows.Forms.PictureBox
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtprecio_venta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnbuscarcategoria As System.Windows.Forms.Button
    Friend WithEvents txtnombre_categoria As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio_compra As System.Windows.Forms.TextBox
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtidcategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtnombreproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
    Friend WithEvents dlg As System.Windows.Forms.OpenFileDialog
End Class
