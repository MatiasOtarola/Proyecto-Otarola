<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatentes
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
        Me.gbpatentes = New System.Windows.Forms.GroupBox()
        Me.lblCondicion = New System.Windows.Forms.Label()
        Me.txtCondicion = New System.Windows.Forms.TextBox()
        Me.btnCancelarNuevo = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DGVPatents = New System.Windows.Forms.DataGridView()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.gbControls = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtpat = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.lblpat = New System.Windows.Forms.Label()
        Me.hlpPatents = New System.Windows.Forms.HelpProvider()
        Me.TTT = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbpatentes.SuspendLayout()
        CType(Me.DGVPatents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbpatentes
        '
        Me.gbpatentes.Controls.Add(Me.lblCondicion)
        Me.gbpatentes.Controls.Add(Me.txtCondicion)
        Me.gbpatentes.Controls.Add(Me.btnCancelarNuevo)
        Me.gbpatentes.Controls.Add(Me.btnNuevo)
        Me.gbpatentes.Controls.Add(Me.DGVPatents)
        Me.gbpatentes.Controls.Add(Me.lbldesc)
        Me.gbpatentes.Controls.Add(Me.gbControls)
        Me.gbpatentes.Controls.Add(Me.txtpat)
        Me.gbpatentes.Controls.Add(Me.txtdesc)
        Me.gbpatentes.Controls.Add(Me.lblpat)
        Me.gbpatentes.Location = New System.Drawing.Point(12, 12)
        Me.gbpatentes.Name = "gbpatentes"
        Me.gbpatentes.Size = New System.Drawing.Size(679, 395)
        Me.gbpatentes.TabIndex = 3
        Me.gbpatentes.TabStop = False
        Me.gbpatentes.Text = "Patentes"
        '
        'lblCondicion
        '
        Me.lblCondicion.AutoSize = True
        Me.lblCondicion.Location = New System.Drawing.Point(6, 98)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(54, 13)
        Me.lblCondicion.TabIndex = 9
        Me.lblCondicion.Text = "Condicion"
        '
        'txtCondicion
        '
        Me.txtCondicion.Location = New System.Drawing.Point(104, 96)
        Me.txtCondicion.Name = "txtCondicion"
        Me.txtCondicion.Size = New System.Drawing.Size(197, 20)
        Me.txtCondicion.TabIndex = 8
        '
        'btnCancelarNuevo
        '
        Me.btnCancelarNuevo.BackColor = System.Drawing.SystemColors.Info
        Me.btnCancelarNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelarNuevo.Location = New System.Drawing.Point(233, 17)
        Me.btnCancelarNuevo.Name = "btnCancelarNuevo"
        Me.btnCancelarNuevo.Size = New System.Drawing.Size(111, 22)
        Me.btnCancelarNuevo.TabIndex = 5
        Me.btnCancelarNuevo.Text = "Cancelar Nuevo"
        Me.btnCancelarNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCancelarNuevo.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Info
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNuevo.Location = New System.Drawing.Point(173, 17)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(54, 22)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'DGVPatents
        '
        Me.DGVPatents.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVPatents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPatents.Location = New System.Drawing.Point(6, 121)
        Me.DGVPatents.Name = "DGVPatents"
        Me.DGVPatents.Size = New System.Drawing.Size(296, 268)
        Me.DGVPatents.TabIndex = 7
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(8, 45)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(63, 13)
        Me.lbldesc.TabIndex = 2
        Me.lbldesc.Text = "Descripcion"
        '
        'gbControls
        '
        Me.gbControls.Controls.Add(Me.btnBuscar)
        Me.gbControls.Controls.Add(Me.btnLimpiar)
        Me.gbControls.Controls.Add(Me.btnActualizar)
        Me.gbControls.Controls.Add(Me.btnEliminar)
        Me.gbControls.Controls.Add(Me.btnRegistrar)
        Me.gbControls.Location = New System.Drawing.Point(307, 98)
        Me.gbControls.Name = "gbControls"
        Me.gbControls.Size = New System.Drawing.Size(358, 171)
        Me.gbControls.TabIndex = 6
        Me.gbControls.TabStop = False
        Me.gbControls.Text = "Controles"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Info
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnBuscar.Location = New System.Drawing.Point(182, 61)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(160, 47)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "btnBuscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.Info
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnActualizar.Location = New System.Drawing.Point(16, 61)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(160, 44)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "btnActualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Info
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEliminar.Location = New System.Drawing.Point(16, 111)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(160, 44)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "btnEliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.SystemColors.Info
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistrar.Location = New System.Drawing.Point(16, 11)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(160, 44)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "btnRegistrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'txtpat
        '
        Me.txtpat.Location = New System.Drawing.Point(105, 18)
        Me.txtpat.Name = "txtpat"
        Me.txtpat.Size = New System.Drawing.Size(62, 20)
        Me.txtpat.TabIndex = 1
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(105, 42)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(197, 48)
        Me.txtdesc.TabIndex = 3
        '
        'lblpat
        '
        Me.lblpat.AutoSize = True
        Me.lblpat.Location = New System.Drawing.Point(8, 21)
        Me.lblpat.Name = "lblpat"
        Me.lblpat.Size = New System.Drawing.Size(44, 13)
        Me.lblpat.TabIndex = 0
        Me.lblpat.Text = "Patente"
        '
        'hlpPatents
        '
        Me.hlpPatents.HelpNamespace = "C:\temp\Ayuda.chm"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Info
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpiar.Location = New System.Drawing.Point(182, 11)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(160, 44)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "btnLimpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'frmPatentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(703, 508)
        Me.Controls.Add(Me.gbpatentes)
        Me.Name = "frmPatentes"
        Me.Text = ".:. Administracion de patentes .:."
        Me.gbpatentes.ResumeLayout(False)
        Me.gbpatentes.PerformLayout()
        CType(Me.DGVPatents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbpatentes As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelarNuevo As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents DGVPatents As System.Windows.Forms.DataGridView
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents gbControls As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtpat As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents lblpat As System.Windows.Forms.Label
    Private WithEvents hlpPatents As System.Windows.Forms.HelpProvider
    Friend WithEvents TTT As System.Windows.Forms.ToolTip
    Friend WithEvents lblCondicion As System.Windows.Forms.Label
    Friend WithEvents txtCondicion As System.Windows.Forms.TextBox
End Class
