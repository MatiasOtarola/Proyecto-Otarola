<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmError
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
        Me.pbError = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar2 = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbError
        '
        Me.pbError.Image = Global.Capa4_Interfaces.My.Resources.Resources.que_significa_alerta_amarilla
        Me.pbError.Location = New System.Drawing.Point(10, 10)
        Me.pbError.Name = "pbError"
        Me.pbError.Size = New System.Drawing.Size(73, 70)
        Me.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbError.TabIndex = 16
        Me.pbError.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Location = New System.Drawing.Point(249, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar2
        '
        Me.btnAceptar2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar2.Location = New System.Drawing.Point(168, 90)
        Me.btnAceptar2.Name = "btnAceptar2"
        Me.btnAceptar2.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar2.TabIndex = 14
        Me.btnAceptar2.Text = "Aceptar"
        Me.btnAceptar2.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(87, 90)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.BackColor = System.Drawing.SystemColors.Control
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(96, 10)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(295, 70)
        Me.txtMensaje.TabIndex = 12
        Me.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 125)
        Me.Controls.Add(Me.pbError)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar2)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtMensaje)
        Me.Name = "frmError"
        Me.Text = "¡Alerta!"
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbError As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar2 As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
End Class
