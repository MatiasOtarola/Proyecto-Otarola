<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlIdioma
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.pbUK = New System.Windows.Forms.PictureBox()
        Me.pbArgentina = New System.Windows.Forms.PictureBox()
        CType(Me.pbUK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArgentina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbUK
        '
        Me.pbUK.Image = Global.Idioma_Selector.My.Resources.Resources.depositphotos_186699216_stock_photo_letters_making_word_united_kingdom
        Me.pbUK.Location = New System.Drawing.Point(89, 3)
        Me.pbUK.Name = "pbUK"
        Me.pbUK.Size = New System.Drawing.Size(70, 70)
        Me.pbUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbUK.TabIndex = 1
        Me.pbUK.TabStop = False
        '
        'pbArgentina
        '
        Me.pbArgentina.Image = Global.Idioma_Selector.My.Resources.Resources._54cbc269d9c8135adf5adab8444b1e06
        Me.pbArgentina.Location = New System.Drawing.Point(4, 3)
        Me.pbArgentina.Name = "pbArgentina"
        Me.pbArgentina.Size = New System.Drawing.Size(70, 70)
        Me.pbArgentina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbArgentina.TabIndex = 0
        Me.pbArgentina.TabStop = False
        '
        'ctrlIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbUK)
        Me.Controls.Add(Me.pbArgentina)
        Me.Name = "ctrlIdioma"
        Me.Size = New System.Drawing.Size(163, 77)
        CType(Me.pbUK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArgentina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbArgentina As System.Windows.Forms.PictureBox
    Friend WithEvents pbUK As System.Windows.Forms.PictureBox

End Class
