<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GuardarArchivo = New System.Windows.Forms.SaveFileDialog()
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.gb.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb
        '
        Me.gb.Controls.Add(Me.btnExaminar)
        Me.gb.Controls.Add(Me.lblStatus)
        Me.gb.Location = New System.Drawing.Point(12, 12)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(360, 137)
        Me.gb.TabIndex = 1
        Me.gb.TabStop = False
        Me.gb.Text = "Detalle"
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExaminar.Location = New System.Drawing.Point(6, 55)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(348, 30)
        Me.btnExaminar.TabIndex = 0
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(228, 110)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 2
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "C:\temp\Ayuda.chm"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.Controls.Add(Me.gb)
        Me.Name = "frmBackup"
        Me.Text = ".:. Copia de seguridad .:."
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents GuardarArchivo As System.Windows.Forms.SaveFileDialog
    Private WithEvents HelpProvider As System.Windows.Forms.HelpProvider
End Class
