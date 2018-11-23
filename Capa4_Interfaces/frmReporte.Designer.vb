<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BitacoraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BitacoraReport = New Capa4_Interfaces.Bitacora()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Bitacora = New Capa4_Interfaces.Bitacora()
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BitacoraReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BitacoraBindingSource
        '
        Me.BitacoraBindingSource.DataMember = "Bitacora"
        Me.BitacoraBindingSource.DataSource = Me.BitacoraReport
        '
        'BitacoraReport
        '
        Me.BitacoraReport.DataSetName = "BitacoraReport"
        Me.BitacoraReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Bitacora"
        ReportDataSource1.Value = Me.BitacoraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Capa4_Interfaces.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(731, 340)
        Me.ReportViewer1.TabIndex = 0
        '
        'Bitacora
        '
        Me.Bitacora.DataSetName = "Bitacora"
        Me.Bitacora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 364)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporte"
        Me.Text = ".:. Reporte de bitacora .:."
        CType(Me.BitacoraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BitacoraReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BitacoraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BitacoraReport As Capa4_Interfaces.Bitacora
    Friend WithEvents Bitacora As Capa4_Interfaces.Bitacora
End Class
