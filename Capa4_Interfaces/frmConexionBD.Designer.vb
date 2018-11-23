<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConexionBD
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDataSource = New System.Windows.Forms.Label()
        Me.lblInitialCatalog = New System.Windows.Forms.Label()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.txtNombreBD = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(535, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDataSource
        '
        Me.lblDataSource.AutoSize = True
        Me.lblDataSource.Location = New System.Drawing.Point(25, 34)
        Me.lblDataSource.Name = "lblDataSource"
        Me.lblDataSource.Size = New System.Drawing.Size(228, 13)
        Me.lblDataSource.TabIndex = 1
        Me.lblDataSource.Text = "Data Source / Nombre del Usuario del Sistema"
        '
        'lblInitialCatalog
        '
        Me.lblInitialCatalog.AutoSize = True
        Me.lblInitialCatalog.Location = New System.Drawing.Point(25, 71)
        Me.lblInitialCatalog.Name = "lblInitialCatalog"
        Me.lblInitialCatalog.Size = New System.Drawing.Size(215, 13)
        Me.lblInitialCatalog.TabIndex = 2
        Me.lblInitialCatalog.Text = "Inital Catalog / Nombre de la Base de Datos"
        '
        'txtDataSource
        '
        Me.txtDataSource.Location = New System.Drawing.Point(259, 31)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(304, 20)
        Me.txtDataSource.TabIndex = 4
        '
        'txtNombreBD
        '
        Me.txtNombreBD.Location = New System.Drawing.Point(246, 68)
        Me.txtNombreBD.Name = "txtNombreBD"
        Me.txtNombreBD.Size = New System.Drawing.Size(317, 20)
        Me.txtNombreBD.TabIndex = 5
        '
        'frmConexionBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 175)
        Me.Controls.Add(Me.txtNombreBD)
        Me.Controls.Add(Me.txtDataSource)
        Me.Controls.Add(Me.lblInitialCatalog)
        Me.Controls.Add(Me.lblDataSource)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmConexionBD"
        Me.Text = ".:. Conexion con Base de Datos .:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblDataSource As System.Windows.Forms.Label
    Friend WithEvents lblInitialCatalog As System.Windows.Forms.Label
    Friend WithEvents txtDataSource As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreBD As System.Windows.Forms.TextBox
End Class
