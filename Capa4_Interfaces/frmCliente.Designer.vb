<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.lninexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.lninexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(488, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 437)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de clientes"
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
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.PowderBlue
        Me.btneliminar.Location = New System.Drawing.Point(470, 35)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 3
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'lninexistente
        '
        Me.lninexistente.AutoSize = True
        Me.lninexistente.LinkColor = System.Drawing.Color.ForestGreen
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
        Me.cbocampo.Items.AddRange(New Object() {"Nombre", "Apellido", "Mail", "DNI"})
        Me.cbocampo.Location = New System.Drawing.Point(30, 35)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(169, 23)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "DNI"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(30, 100)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(564, 320)
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
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.txtmail)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(7, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 298)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.PowderBlue
        Me.btnguardar.Location = New System.Drawing.Point(38, 259)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(103, 23)
        Me.btnguardar.TabIndex = 13
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.PowderBlue
        Me.btncancelar.Location = New System.Drawing.Point(324, 259)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(103, 23)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(151, 220)
        Me.txtdni.MaxLength = 8
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(131, 21)
        Me.txtdni.TabIndex = 12
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.PowderBlue
        Me.btnnuevo.Location = New System.Drawing.Point(324, 30)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(103, 23)
        Me.btnnuevo.TabIndex = 1
        Me.btnnuevo.Text = "Nuevo cliente"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.PowderBlue
        Me.btneditar.Location = New System.Drawing.Point(179, 259)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(103, 23)
        Me.btneditar.TabIndex = 2
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(151, 172)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(131, 21)
        Me.txtmail.TabIndex = 10
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(151, 123)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(131, 21)
        Me.txtapellido.TabIndex = 9
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(151, 82)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(131, 21)
        Me.txtnombre.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID cliente"
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(151, 32)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(131, 21)
        Me.txtidcliente.TabIndex = 0
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(309, 73)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(51, 20)
        Me.txtflag.TabIndex = 14
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(89, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Registro de Clientes"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1113, 493)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.Label7)
        Me.Name = "frmCliente"
        Me.Text = ".:. Listado de clientes .:."
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
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents lninexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cbocampo As System.Windows.Forms.ComboBox
    Friend WithEvents datalistado As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents erroricono As System.Windows.Forms.ErrorProvider

End Class
