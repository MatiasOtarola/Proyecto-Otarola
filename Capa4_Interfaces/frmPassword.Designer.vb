<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassword
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
        Me.gbDetails = New System.Windows.Forms.GroupBox()
        Me.lblPasswordNew2 = New System.Windows.Forms.Label()
        Me.txtPasswordOld = New System.Windows.Forms.TextBox()
        Me.lblPasswordOld = New System.Windows.Forms.Label()
        Me.txtPasswordNew2 = New System.Windows.Forms.TextBox()
        Me.txtPasswordNew = New System.Windows.Forms.TextBox()
        Me.lblPasswordNew = New System.Windows.Forms.Label()
        Me.hlpPassword = New System.Windows.Forms.HelpProvider()
        Me.Ayuda = New System.Windows.Forms.HelpProvider()
        Me.gbDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Info
        Me.btnCancelar.Location = New System.Drawing.Point(204, 131)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Info
        Me.btnAceptar.Location = New System.Drawing.Point(47, 131)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'gbDetails
        '
        Me.gbDetails.Controls.Add(Me.lblPasswordNew2)
        Me.gbDetails.Controls.Add(Me.txtPasswordOld)
        Me.gbDetails.Controls.Add(Me.lblPasswordOld)
        Me.gbDetails.Controls.Add(Me.txtPasswordNew2)
        Me.gbDetails.Controls.Add(Me.txtPasswordNew)
        Me.gbDetails.Controls.Add(Me.lblPasswordNew)
        Me.gbDetails.Location = New System.Drawing.Point(12, 12)
        Me.gbDetails.Name = "gbDetails"
        Me.gbDetails.Size = New System.Drawing.Size(297, 113)
        Me.gbDetails.TabIndex = 3
        Me.gbDetails.TabStop = False
        Me.gbDetails.Text = "Detalles"
        '
        'lblPasswordNew2
        '
        Me.lblPasswordNew2.AutoSize = True
        Me.lblPasswordNew2.Location = New System.Drawing.Point(19, 78)
        Me.lblPasswordNew2.Name = "lblPasswordNew2"
        Me.lblPasswordNew2.Size = New System.Drawing.Size(81, 13)
        Me.lblPasswordNew2.TabIndex = 5
        Me.lblPasswordNew2.Text = "PasswordNew2"
        '
        'txtPasswordOld
        '
        Me.txtPasswordOld.Location = New System.Drawing.Point(157, 23)
        Me.txtPasswordOld.MaxLength = 35
        Me.txtPasswordOld.Name = "txtPasswordOld"
        Me.txtPasswordOld.Size = New System.Drawing.Size(133, 20)
        Me.txtPasswordOld.TabIndex = 0
        Me.txtPasswordOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPasswordOld.UseSystemPasswordChar = True
        '
        'lblPasswordOld
        '
        Me.lblPasswordOld.AutoSize = True
        Me.lblPasswordOld.Location = New System.Drawing.Point(19, 26)
        Me.lblPasswordOld.Name = "lblPasswordOld"
        Me.lblPasswordOld.Size = New System.Drawing.Size(69, 13)
        Me.lblPasswordOld.TabIndex = 3
        Me.lblPasswordOld.Text = "PasswordOld"
        '
        'txtPasswordNew2
        '
        Me.txtPasswordNew2.Location = New System.Drawing.Point(157, 75)
        Me.txtPasswordNew2.MaxLength = 35
        Me.txtPasswordNew2.Name = "txtPasswordNew2"
        Me.txtPasswordNew2.Size = New System.Drawing.Size(133, 20)
        Me.txtPasswordNew2.TabIndex = 2
        Me.txtPasswordNew2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPasswordNew2.UseSystemPasswordChar = True
        '
        'txtPasswordNew
        '
        Me.txtPasswordNew.Location = New System.Drawing.Point(157, 49)
        Me.txtPasswordNew.MaxLength = 35
        Me.txtPasswordNew.Name = "txtPasswordNew"
        Me.txtPasswordNew.Size = New System.Drawing.Size(133, 20)
        Me.txtPasswordNew.TabIndex = 1
        Me.txtPasswordNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPasswordNew.UseSystemPasswordChar = True
        '
        'lblPasswordNew
        '
        Me.lblPasswordNew.AutoSize = True
        Me.lblPasswordNew.Location = New System.Drawing.Point(19, 52)
        Me.lblPasswordNew.Name = "lblPasswordNew"
        Me.lblPasswordNew.Size = New System.Drawing.Size(75, 13)
        Me.lblPasswordNew.TabIndex = 4
        Me.lblPasswordNew.Text = "PasswordNew"
        '
        'hlpPassword
        '
        Me.hlpPassword.HelpNamespace = "C:\temp\Ayuda.chm"
        '
        'frmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(319, 165)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbDetails)
        Me.Name = "frmPassword"
        Me.Text = ".:. Password .:."
        Me.gbDetails.ResumeLayout(False)
        Me.gbDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents gbDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblPasswordNew2 As System.Windows.Forms.Label
    Friend WithEvents txtPasswordOld As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordOld As System.Windows.Forms.Label
    Friend WithEvents txtPasswordNew2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswordNew As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordNew As System.Windows.Forms.Label
    Private WithEvents hlpPassword As System.Windows.Forms.HelpProvider
    Friend WithEvents Ayuda As System.Windows.Forms.HelpProvider
End Class
