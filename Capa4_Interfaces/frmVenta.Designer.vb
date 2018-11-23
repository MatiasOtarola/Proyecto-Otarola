<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbtipo_documento = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnbuscarcliente = New System.Windows.Forms.Button()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.txtnum_fac = New System.Windows.Forms.TextBox()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.lninexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(492, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 447)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de ventas"
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
        Me.lninexistente.LinkColor = System.Drawing.Color.Yellow
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
        Me.cbocampo.Items.AddRange(New Object() {"Num_documento", "DNI"})
        Me.cbocampo.Location = New System.Drawing.Point(30, 35)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(169, 23)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "Num_documento"
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
        Me.datalistado.Size = New System.Drawing.Size(476, 330)
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
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbtipo_documento)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcliente)
        Me.GroupBox1.Controls.Add(Me.txtnombrecliente)
        Me.GroupBox1.Controls.Add(Me.txtnum_fac)
        Me.GroupBox1.Controls.Add(Me.txtcodcliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidventa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(11, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 388)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnguardar.Location = New System.Drawing.Point(171, 331)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(78, 23)
        Me.btnguardar.TabIndex = 23
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.PowderBlue
        Me.btncancelar.Location = New System.Drawing.Point(287, 331)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 22
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.PowderBlue
        Me.btneditar.Location = New System.Drawing.Point(171, 331)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(78, 23)
        Me.btneditar.TabIndex = 21
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.PowderBlue
        Me.btnnuevo.Location = New System.Drawing.Point(37, 331)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(103, 23)
        Me.btnnuevo.TabIndex = 20
        Me.btnnuevo.Text = "Nuevo cliente"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(151, 218)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(131, 21)
        Me.txtdni.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "DNI"
        '
        'cbtipo_documento
        '
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
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(151, 123)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(200, 21)
        Me.txtfecha.TabIndex = 16
        '
        'btnbuscarcliente
        '
        Me.btnbuscarcliente.BackColor = System.Drawing.Color.Black
        Me.btnbuscarcliente.Location = New System.Drawing.Point(340, 80)
        Me.btnbuscarcliente.Name = "btnbuscarcliente"
        Me.btnbuscarcliente.Size = New System.Drawing.Size(45, 23)
        Me.btnbuscarcliente.TabIndex = 15
        Me.btnbuscarcliente.Text = "..."
        Me.btnbuscarcliente.UseVisualStyleBackColor = False
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Location = New System.Drawing.Point(211, 82)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(123, 21)
        Me.txtnombrecliente.TabIndex = 14
        '
        'txtnum_fac
        '
        Me.txtnum_fac.Location = New System.Drawing.Point(151, 268)
        Me.txtnum_fac.MaxLength = 10
        Me.txtnum_fac.Name = "txtnum_fac"
        Me.txtnum_fac.Size = New System.Drawing.Size(131, 21)
        Me.txtnum_fac.TabIndex = 11
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(151, 82)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(45, 21)
        Me.txtcodcliente.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nro de factura"
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
        Me.txtidventa.Location = New System.Drawing.Point(151, 32)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(131, 21)
        Me.txtidventa.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(83, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Registro de ventas"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(1030, 478)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmVenta"
        Me.Text = ".:. Listado de ventas .:."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbeliminar As System.Windows.Forms.CheckBox
    Friend WithEvents lninexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbtipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnbuscarcliente As System.Windows.Forms.Button
    Friend WithEvents txtnombrecliente As System.Windows.Forms.TextBox
    Friend WithEvents txtnum_fac As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidventa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider
End Class
