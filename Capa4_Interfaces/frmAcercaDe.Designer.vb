<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaDe
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pbLogoCompleto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProyecto = New System.Windows.Forms.TextBox()
        Me.lblPurchaseAndSell = New System.Windows.Forms.TextBox()
        Me.lblFrasedelDia = New System.Windows.Forms.Label()
        CType(Me.pbLogoCompleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbLogoCompleto
        '
        Me.pbLogoCompleto.Location = New System.Drawing.Point(12, 12)
        Me.pbLogoCompleto.Name = "pbLogoCompleto"
        Me.pbLogoCompleto.Size = New System.Drawing.Size(493, 103)
        Me.pbLogoCompleto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogoCompleto.TabIndex = 0
        Me.pbLogoCompleto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "---------------------------------------------------------------------------------" & _
    "----------------------------------------------------"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'lblProyecto
        '
        Me.lblProyecto.BackColor = System.Drawing.Color.White
        Me.lblProyecto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblProyecto.Location = New System.Drawing.Point(12, 179)
        Me.lblProyecto.Multiline = True
        Me.lblProyecto.Name = "lblProyecto"
        Me.lblProyecto.ReadOnly = True
        Me.lblProyecto.Size = New System.Drawing.Size(493, 55)
        Me.lblProyecto.TabIndex = 4
        Me.lblProyecto.TabStop = False
        Me.lblProyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPurchaseAndSell
        '
        Me.lblPurchaseAndSell.BackColor = System.Drawing.Color.White
        Me.lblPurchaseAndSell.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblPurchaseAndSell.Location = New System.Drawing.Point(12, 121)
        Me.lblPurchaseAndSell.Multiline = True
        Me.lblPurchaseAndSell.Name = "lblPurchaseAndSell"
        Me.lblPurchaseAndSell.ReadOnly = True
        Me.lblPurchaseAndSell.Size = New System.Drawing.Size(493, 40)
        Me.lblPurchaseAndSell.TabIndex = 5
        Me.lblPurchaseAndSell.TabStop = False
        Me.lblPurchaseAndSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFrasedelDia
        '
        Me.lblFrasedelDia.AutoSize = True
        Me.lblFrasedelDia.ForeColor = System.Drawing.Color.Red
        Me.lblFrasedelDia.Location = New System.Drawing.Point(12, 231)
        Me.lblFrasedelDia.Name = "lblFrasedelDia"
        Me.lblFrasedelDia.Size = New System.Drawing.Size(73, 13)
        Me.lblFrasedelDia.TabIndex = 6
        Me.lblFrasedelDia.Text = "lblFrasedelDia"
        Me.lblFrasedelDia.Visible = False
        '
        'frmAcercaDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(516, 246)
        Me.Controls.Add(Me.lblFrasedelDia)
        Me.Controls.Add(Me.lblPurchaseAndSell)
        Me.Controls.Add(Me.lblProyecto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbLogoCompleto)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmAcercaDe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:. AcercaDeDiploma .:."
        CType(Me.pbLogoCompleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLogoCompleto As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProyecto As System.Windows.Forms.TextBox
    Friend WithEvents lblPurchaseAndSell As System.Windows.Forms.TextBox
    Friend WithEvents lblFrasedelDia As System.Windows.Forms.Label
End Class
