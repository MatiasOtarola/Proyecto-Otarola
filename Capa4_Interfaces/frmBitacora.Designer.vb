<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacora
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGBitacora = New System.Windows.Forms.DataGridView()
        Me.gbControles = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescBitacora = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbFecha = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.Bitacora1 = New Capa4_Interfaces.Bitacora()
        CType(Me.DGBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControles.SuspendLayout()
        Me.gbFecha.SuspendLayout()
        CType(Me.Bitacora1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGBitacora
        '
        Me.DGBitacora.AllowUserToAddRows = False
        Me.DGBitacora.AllowUserToDeleteRows = False
        Me.DGBitacora.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGBitacora.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGBitacora.GridColor = System.Drawing.Color.Green
        Me.DGBitacora.Location = New System.Drawing.Point(12, 120)
        Me.DGBitacora.Name = "DGBitacora"
        Me.DGBitacora.ReadOnly = True
        Me.DGBitacora.Size = New System.Drawing.Size(777, 286)
        Me.DGBitacora.TabIndex = 5
        '
        'gbControles
        '
        Me.gbControles.Controls.Add(Me.Label4)
        Me.gbControles.Controls.Add(Me.txtUsuario)
        Me.gbControles.Controls.Add(Me.Label1)
        Me.gbControles.Controls.Add(Me.txtDescBitacora)
        Me.gbControles.Controls.Add(Me.btnLimpiar)
        Me.gbControles.Controls.Add(Me.btnBuscar)
        Me.gbControles.Controls.Add(Me.gbFecha)
        Me.gbControles.Location = New System.Drawing.Point(12, 12)
        Me.gbControles.Name = "gbControles"
        Me.gbControles.Size = New System.Drawing.Size(777, 91)
        Me.gbControles.TabIndex = 4
        Me.gbControles.TabStop = False
        Me.gbControles.Text = "Controles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(367, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(200, 20)
        Me.txtUsuario.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'txtDescBitacora
        '
        Me.txtDescBitacora.Location = New System.Drawing.Point(89, 16)
        Me.txtDescBitacora.Name = "txtDescBitacora"
        Me.txtDescBitacora.Size = New System.Drawing.Size(200, 20)
        Me.txtDescBitacora.TabIndex = 1
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Info
        Me.btnLimpiar.Location = New System.Drawing.Point(614, 62)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(141, 24)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Info
        Me.btnBuscar.Location = New System.Drawing.Point(614, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(141, 51)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'gbFecha
        '
        Me.gbFecha.Controls.Add(Me.Label3)
        Me.gbFecha.Controls.Add(Me.Label2)
        Me.gbFecha.Controls.Add(Me.dtpHasta)
        Me.gbFecha.Controls.Add(Me.dtpDesde)
        Me.gbFecha.Location = New System.Drawing.Point(21, 39)
        Me.gbFecha.Name = "gbFecha"
        Me.gbFecha.Size = New System.Drawing.Size(555, 46)
        Me.gbFecha.TabIndex = 2
        Me.gbFecha.TabStop = False
        Me.gbFecha.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde"
        '
        'dtpHasta
        '
        Me.dtpHasta.Location = New System.Drawing.Point(346, 15)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(200, 20)
        Me.dtpHasta.TabIndex = 3
        '
        'dtpDesde
        '
        Me.dtpDesde.Location = New System.Drawing.Point(68, 15)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(200, 20)
        Me.dtpDesde.TabIndex = 1
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.BackColor = System.Drawing.SystemColors.Info
        Me.btnGenerarReporte.Location = New System.Drawing.Point(12, 424)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(777, 43)
        Me.btnGenerarReporte.TabIndex = 6
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.UseVisualStyleBackColor = False
        '
        'Bitacora1
        '
        Me.Bitacora1.DataSetName = "Bitacora"
        Me.Bitacora1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(813, 479)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Controls.Add(Me.DGBitacora)
        Me.Controls.Add(Me.gbControles)
        Me.Name = "frmBitacora"
        Me.Text = ".:. Bitacora .:."
        CType(Me.DGBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControles.ResumeLayout(False)
        Me.gbControles.PerformLayout()
        Me.gbFecha.ResumeLayout(False)
        Me.gbFecha.PerformLayout()
        CType(Me.Bitacora1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGBitacora As System.Windows.Forms.DataGridView
    Friend WithEvents gbControles As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescBitacora As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbFecha As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents btnGenerarReporte As System.Windows.Forms.Button
    Friend WithEvents Bitacora1 As Capa4_Interfaces.Bitacora
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
End Class
