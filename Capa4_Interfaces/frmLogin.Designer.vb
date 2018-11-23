<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.hlpLogin = New System.Windows.Forms.HelpProvider()
        Me.CtrlIdioma1 = New Idioma_Selector.ctrlIdioma()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.SystemColors.Info
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cancel.Location = New System.Drawing.Point(156, 222)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.SystemColors.Info
        Me.OK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OK.Location = New System.Drawing.Point(31, 222)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 11
        Me.OK.Text = "&Aceptar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(30, 91)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 10
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(30, 34)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 8
        '
        'PasswordLabel
        '
        Me.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PasswordLabel.Location = New System.Drawing.Point(28, 71)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 9
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UsernameLabel.Location = New System.Drawing.Point(28, 14)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'hlpLogin
        '
        Me.hlpLogin.HelpNamespace = "C:\temp\Ayuda.chm"
        '
        'CtrlIdioma1
        '
        Me.CtrlIdioma1.Descripcion = Nothing
        Me.CtrlIdioma1.Idioma = 2
        Me.CtrlIdioma1.Location = New System.Drawing.Point(64, 126)
        Me.CtrlIdioma1.Name = "CtrlIdioma1"
        Me.CtrlIdioma1.Size = New System.Drawing.Size(163, 77)
        Me.CtrlIdioma1.TabIndex = 13
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(282, 257)
        Me.Controls.Add(Me.CtrlIdioma1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "frmLogin"
        Me.Text = ".:. Login .:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Private WithEvents hlpLogin As System.Windows.Forms.HelpProvider
    Friend WithEvents CtrlIdioma1 As Idioma_Selector.ctrlIdioma
End Class
