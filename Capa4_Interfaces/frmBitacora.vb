Option Explicit On
Imports Capa3_Seguridad_Servicios
Imports Capa2_Logica
Public Class frmBitacora
    Dim DS As DataSet 'declara el Dataset
    Dim DV As New DataView 'declara el dataview
    Dim DT As New DataTable 'declara el datatable

    Private Sub frmBitacora_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cambiar_Idioma() 'llama a la subrutina  de cambiar el idioma
    End Sub

    Private Sub frmBitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ERROR
        '    HelpProvider.HelpNamespace = Application.StartupPath & "\Ayuda.chm" 'carga la ayuda
        'habilita checksbox en los datatimepicker
        dtpDesde.ShowCheckBox = True
        dtpHasta.ShowCheckBox = True
        'deshabilita los datatimepicker
        dtpDesde.Checked = False
        dtpHasta.Checked = False
        ' llama a la función y la mantiene en un datatable
        DT = MiBitacora.Visualizar().tables(0)
        DV = DT.DefaultView ' la muestra en un dataview por default
        DGBitacora.DataSource = DV ' muestra la informacion en el Datagridview
        ColumnasDG()
    End Sub
    Private Sub frmBitacora_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2) ' pregunta si desea cerrarlo
        If MiError.Seleccion = 1 Then
        Else
            e.Cancel = True ' si contesta que no,lo cierra
        End If
    End Sub
    Private Sub VisualizarBitacora() 'subrutina que permite visualizar la bitacora
        Try

            If dtpDesde.Checked = True And dtpHasta.Checked = True And Me.txtDescBitacora.Text = "" And Me.txtusuario.Text = "" Then ' si ambos están habilitados con el check, busca entre las dos fechas
                DV.RowFilter = "Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "'"
                Me.DGBitacora.Refresh() 'refresca el datagridview
            ElseIf Me.txtDescBitacora.Text <> "" And dtpDesde.Checked = False And dtpHasta.Checked = False And Me.txtusuario.Text = "" Then  ' si el texto de buscaque de la bitacora tiene algo
                DV.RowFilter = "Descripción like '%" & txtDescBitacora.Text & "%'"   'busca según la descripcion de la bitácora
                Me.DGBitacora.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = True And dtpHasta.Checked = True And Me.txtDescBitacora.Text <> "" And Me.txtusuario.Text = "" Then
                DV.RowFilter = "Descripción like '%" & txtDescBitacora.Text & "%' AND Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "'"
                Me.DGBitacora.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = False And dtpHasta.Checked = False And Me.txtDescBitacora.Text = "" And Me.txtusuario.Text <> "" Then
                DV.RowFilter = "Usuario like '%" & txtusuario.Text & "%'"
                Me.DGBitacora.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = True And dtpHasta.Checked = True And Me.txtDescBitacora.Text = "" And Me.txtusuario.Text <> "" Then
                DV.RowFilter = "Usuario like '%" & txtusuario.Text & "%' AND Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "'"
                Me.DGBitacora.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = True And dtpHasta.Checked = True And Me.txtDescBitacora.Text <> "" And Me.txtusuario.Text <> "" Then
                DV.RowFilter = "Usuario like '%" & txtusuario.Text & "%' AND Descripción like '%" & txtDescBitacora.Text & "%' AND Fecha >= '" & Convert.ToDateTime(dtpDesde.Value).ToShortDateString & "' AND Fecha <= '" & Convert.ToDateTime(dtpHasta.Value).ToShortDateString & "'"
                Me.DGBitacora.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = False And dtpHasta.Checked = False And Me.txtDescBitacora.Text <> "" And Me.txtusuario.Text <> "" Then
                DV.RowFilter = "Usuario like '%" & txtusuario.Text & "%' AND Descripción like '%" & txtDescBitacora.Text & "%'"
                Me.DGBitacora.Refresh() 'refresca el datagridview
            ElseIf dtpDesde.Checked = False And dtpHasta.Checked = False And Me.txtDescBitacora.Text = "" And Me.txtusuario.Text = "" Then
                MiError.MostrarError(MiIdioma.Err_Busqueda & MiIdioma.Bitacora, 1)
            End If
        Catch ex As Exception ' en caso de error, muestra una excepción
            MiError.MostrarError(MiIdioma.Err_BD & MiIdioma.Bitacora, 1)
        End Try
    End Sub
    Private Sub ColumnasDG() 'subrutina cambia los nombres de las columnas segun el idioma
        DGBitacora.Columns(0).HeaderText = MiIdioma.Bitacora
        DGBitacora.Columns(1).HeaderText = MiIdioma.Usuario
        DGBitacora.Columns(2).HeaderText = MiIdioma.Evento
        DGBitacora.Columns(3).HeaderText = MiIdioma.Descripcion
        DGBitacora.Columns(4).HeaderText = MiIdioma.Fecha
        DGBitacora.Columns(5).HeaderText = MiIdioma.Hora
        DGBitacora.Columns(6).HeaderText = MiIdioma.Criticidad
    End Sub
    Private Sub Cambiar_Idioma() 'subrutina que cambia los textbox,labels,botones,groupbox segun el idioma
        Me.Label1.Text = MiIdioma.Descripcion
        Me.Label2.Text = MiIdioma.Desde
        Me.Label3.Text = MiIdioma.Hasta
        Me.Label4.Text = MiIdioma.Usuario
        Me.gbFecha.Text = MiIdioma.Fecha
        Me.gbControles.Text = MiIdioma.Controles
        Me.btnBuscar.Text = MiIdioma.Buscar
        Me.btnLimpiar.Text = MiIdioma.Limpiar
        Me.Text = MiIdioma.Bitacora
    End Sub
    Private Sub limpiarBitacora() 'subrutina que limpia la bitacora
        DT = MiBitacora.Visualizar().tables(0)
        DV = DT.DefaultView ' la muestra en un dataview por default
        DGBitacora.DataSource = DV ' muestra la informacion en el Datagridvie
        Me.DGBitacora.Refresh()
        Me.txtDescBitacora.Text = ""
        Me.txtUsuario.Text = ""
        Me.dtpDesde.Checked = False
        Me.dtpHasta.Checked = False
    End Sub
    Private Sub TSBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        VisualizarBitacora() 'llama a la subrutina visualiza la bitacora
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        VisualizarBitacora() 'llama a la subrutina visualiza la bitacora
    End Sub

    Private Sub TSLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarBitacora() 'llama a la subrutina de limpiar la bitácora
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiarBitacora() 'llama a la subrutina de limpiar la bitácora
    End Sub
    Private Sub frmBitacora_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Help.ShowHelp(Me, "Ayuda.chm")
        End If
    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("NroBitacora")
        dt.Columns.Add("Usuario")
        dt.Columns.Add("Evento")
        dt.Columns.Add("Descripción")
        dt.Columns.Add("Fecha")
        dt.Columns.Add("Hora")
        dt.Columns.Add("Criticidad")

        For i = 0 To DGBitacora.Rows.Count - 1
            r = dt.NewRow
            r("NroBitacora") = DGBitacora.Item(0, i).Value.ToString
            r("Usuario") = DGBitacora.Item(1, i).Value.ToString
            r("Evento") = DGBitacora.Item(2, i).Value.ToString
            r("Descripción") = DGBitacora.Item(3, i).Value.ToString
            r("Fecha") = DGBitacora.Item(4, i).Value.ToString
            r("Hora") = DGBitacora.Item(5, i).Value.ToString
            r("Criticidad") = DGBitacora.Item(6, i).Value.ToString
            dt.Rows.Add(r)

        Next

        frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Bitacora", dt))
        frmReporte.ReportViewer1.RefreshReport()
        frmReporte.Show()

    End Sub
End Class