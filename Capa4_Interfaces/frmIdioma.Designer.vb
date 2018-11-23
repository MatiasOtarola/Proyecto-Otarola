<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdioma
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblIdioma = New System.Windows.Forms.TextBox()
        Me.hlpIdioma = New System.Windows.Forms.HelpProvider()
        Me.CtrlIdioma1 = New Idioma_Selector.ctrlIdioma()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Location = New System.Drawing.Point(224, 145)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 28)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAceptar.Location = New System.Drawing.Point(35, 145)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(78, 28)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblIdioma
        '
        Me.lblIdioma.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.lblIdioma.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblIdioma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblIdioma.Location = New System.Drawing.Point(35, 21)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(116, 13)
        Me.lblIdioma.TabIndex = 4
        Me.lblIdioma.Text = "Idioma"
        '
        'hlpIdioma
        '
        Me.hlpIdioma.HelpNamespace = "C:\temp\Ayuda.chm"
        '
        'CtrlIdioma1
        '
        Me.CtrlIdioma1.Descripcion = Nothing
        Me.CtrlIdioma1.Idioma = 2
        Me.CtrlIdioma1.Location = New System.Drawing.Point(90, 51)
        Me.CtrlIdioma1.Name = "CtrlIdioma1"
        Me.CtrlIdioma1.Size = New System.Drawing.Size(163, 77)
        Me.CtrlIdioma1.TabIndex = 7
        '
        'frmIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(344, 202)
        Me.Controls.Add(Me.CtrlIdioma1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblIdioma)
        Me.Name = "frmIdioma"
        Me.Text = ".:. Seleccion de idioma .:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblIdioma As System.Windows.Forms.TextBox
    Private WithEvents hlpIdioma As System.Windows.Forms.HelpProvider
    Friend WithEvents CtrlIdioma1 As Idioma_Selector.ctrlIdioma
End Class
