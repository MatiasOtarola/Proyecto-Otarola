<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalle_venta
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.lninexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnum_fac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.txtprecio_unitario = New System.Windows.Forms.TextBox()
        Me.buttonguardar = New System.Windows.Forms.Button()
        Me.txtstock = New System.Windows.Forms.NumericUpDown()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnombre_producto = New System.Windows.Forms.TextBox()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbtipo_documento = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.lninexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(513, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(753, 477)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de articulos de la  venta"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PowderBlue
        Me.Button1.Location = New System.Drawing.Point(194, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Quitar articulos"
        Me.Button1.UseVisualStyleBackColor = False
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
        'lninexistente
        '
        Me.lninexistente.AutoSize = True
        Me.lninexistente.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lninexistente.Location = New System.Drawing.Point(224, 240)
        Me.lninexistente.Name = "lninexistente"
        Me.lninexistente.Size = New System.Drawing.Size(125, 15)
        Me.lninexistente.TabIndex = 3
        Me.lninexistente.TabStop = True
        Me.lninexistente.Text = "Datos inexistentes"
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
        Me.datalistado.Size = New System.Drawing.Size(720, 330)
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
        Me.GroupBox1.Controls.Add(Me.txtnum_fac)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnimprimir)
        Me.GroupBox1.Controls.Add(Me.txtprecio_unitario)
        Me.GroupBox1.Controls.Add(Me.buttonguardar)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtnombre_producto)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbtipo_documento)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txtnombrecliente)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtcodcliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidventa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 566)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtnum_fac
        '
        Me.txtnum_fac.Location = New System.Drawing.Point(151, 259)
        Me.txtnum_fac.Name = "txtnum_fac"
        Me.txtnum_fac.Size = New System.Drawing.Size(131, 21)
        Me.txtnum_fac.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Nro de factura"
        '
        'btnimprimir
        '
        Me.btnimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnimprimir.Location = New System.Drawing.Point(37, 410)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(407, 111)
        Me.btnimprimir.TabIndex = 30
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'txtprecio_unitario
        '
        Me.txtprecio_unitario.Location = New System.Drawing.Point(172, 374)
        Me.txtprecio_unitario.Name = "txtprecio_unitario"
        Me.txtprecio_unitario.Size = New System.Drawing.Size(139, 21)
        Me.txtprecio_unitario.TabIndex = 29
        '
        'buttonguardar
        '
        Me.buttonguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonguardar.ForeColor = System.Drawing.Color.White
        Me.buttonguardar.Location = New System.Drawing.Point(352, 296)
        Me.buttonguardar.Name = "buttonguardar"
        Me.buttonguardar.Size = New System.Drawing.Size(50, 23)
        Me.buttonguardar.TabIndex = 28
        Me.buttonguardar.Text = "..."
        Me.buttonguardar.UseVisualStyleBackColor = False
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(270, 341)
        Me.txtstock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtstock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(64, 21)
        Me.txtstock.TabIndex = 27
        Me.txtstock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(120, 341)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(64, 21)
        Me.txtcantidad.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Precio unitario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Cantidad"
        '
        'txtnombre_producto
        '
        Me.txtnombre_producto.Location = New System.Drawing.Point(211, 297)
        Me.txtnombre_producto.Name = "txtnombre_producto"
        Me.txtnombre_producto.Size = New System.Drawing.Size(123, 21)
        Me.txtnombre_producto.TabIndex = 20
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(151, 297)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(45, 21)
        Me.txtidproducto.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Producto"
        '
        'cbtipo_documento
        '
        Me.cbtipo_documento.Enabled = False
        Me.cbtipo_documento.FormattingEnabled = True
        Me.cbtipo_documento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cbtipo_documento.Location = New System.Drawing.Point(151, 170)
        Me.cbtipo_documento.Name = "cbtipo_documento"
        Me.cbtipo_documento.Size = New System.Drawing.Size(131, 23)
        Me.cbtipo_documento.TabIndex = 17
        Me.cbtipo_documento.Text = "Factura"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(151, 123)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(200, 21)
        Me.txtfecha.TabIndex = 16
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Enabled = False
        Me.txtnombrecliente.Location = New System.Drawing.Point(211, 82)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(123, 21)
        Me.txtnombrecliente.TabIndex = 14
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnguardar.Location = New System.Drawing.Point(172, 527)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(130, 23)
        Me.btnguardar.TabIndex = 13
        Me.btnguardar.Text = "Agregar articulos"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.PowderBlue
        Me.btncancelar.Location = New System.Drawing.Point(352, 527)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Salir"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Location = New System.Drawing.Point(151, 218)
        Me.txtdni.MaxLength = 10
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(131, 21)
        Me.txtdni.TabIndex = 11
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.PowderBlue
        Me.btnnuevo.Location = New System.Drawing.Point(37, 527)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(103, 23)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "Nuevo cliente"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Enabled = False
        Me.txtcodcliente.Location = New System.Drawing.Point(151, 82)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(45, 21)
        Me.txtcodcliente.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo Doc"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID venta"
        '
        'txtidventa
        '
        Me.txtidventa.Enabled = False
        Me.txtidventa.Location = New System.Drawing.Point(151, 32)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(131, 21)
        Me.txtidventa.TabIndex = 0
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmDetalle_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(1276, 599)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDetalle_venta"
        Me.Text = ".:. Detalle de la venta .:."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents lninexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents txtprecio_unitario As System.Windows.Forms.TextBox
    Friend WithEvents buttonguardar As System.Windows.Forms.Button
    Friend WithEvents txtstock As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtcantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnombre_producto As System.Windows.Forms.TextBox
    Friend WithEvents txtidproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbtipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnombrecliente As System.Windows.Forms.TextBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents txtnum_fac As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
End Class
