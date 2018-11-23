Imports Capa2_Logica
Imports Entidad
Public Class frmVenta
    Private dt As New DataTable
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtcodcliente.Text = ""
        txtnombrecliente.Text = ""
        txtdni.Text = ""
        txtnum_fac.Text = ""
        txtidventa.Text = ""
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New VentaMod
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                lninexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                lninexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo.Text & " LIKE'" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                lninexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                lninexistente.Visible = True
                datalistado.DataSource = Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtcodcliente.Text <> "" And txtnombrecliente.Text <> "" And txtdni.Text <> "" Then  'me va a verificar que las cajas de texto no esten vacias'
            Try
                Dim dts As New vventa    'Instancio a la clase cliente donde estan todas las propiedades del mismo'
                Dim func As New VentaMod       'Instancio la clase donde estan las funciones del cliente'

                dts._Idcliente = txtcodcliente.Text            'A cada metodo le envio un textbox, y asi por cada uno'
                dts._Fecha_venta = txtfecha.Text
                dts._tipo = cbtipo_documento.Text
                dts._DNI = txtdni.Text
                dts._Nro_Factura = txtnum_fac.Text

                If func.insertar(dts) Then          'condicion que me envia todos los datos del DTS, y me diga los errores del mismo'
                    MessageBox.Show("Venta registrada correctamente, Vamos añadir productos", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cargar_detalle()
                Else
                    MessageBox.Show("Venta no fue registrada correctamente, intente de nuevo", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar algunos datos", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidventa.Text = datalistado.SelectedCells.Item(1).Value
        txtcodcliente.Text = datalistado.SelectedCells.Item(2).Value
        txtnombrecliente.Text = datalistado.SelectedCells.Item(3).Value
        txtdni.Text = datalistado.SelectedCells.Item(4).Value
        txtnum_fac.Text = datalistado.SelectedCells.Item(5).Value
        cbtipo_documento.Text = datalistado.SelectedCells.Item(6).Value
        txtfecha.Text = datalistado.SelectedCells.Item(7).Value
        btneditar.Visible = True
        btnguardar.Visible = False

    End Sub


    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult      'Que salte un mensaje en el formulario para comprobar si realmente desea modificar y no toco el boton por error'
        result = MessageBox.Show("Realmente desea editar los datos de la venta?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then



            If Me.ValidateChildren = True And txtcodcliente.Text <> "" And txtdni.Text <> "" And txtidventa.Text <> "" Then  'me va a verificar que las cajas de texto no esten vacias'
                Try
                    Dim dts As New vventa    'Instancio a la clase cliente donde estan todas las propiedades del mismo'
                    Dim func As New VentaMod        'Instancio la clase donde estan las funciones del cliente'

                    dts._Idventa = txtidventa.Text
                    dts._Idcliente = txtcodcliente.Text            'A cada metodo le envio un textbox, y asi por cada uno'
                    dts._Fecha_venta = txtfecha.Text
                    dts._tipo = cbtipo_documento.Text
                    dts._DNI = txtdni.Text
                    dts._Nro_Factura = txtnum_fac.Text

                    If func.editar(dts) Then          'condicion que me envia todos los datos del DTS, y me diga los errores del mismo'
                        MessageBox.Show("Venta Modificada correctamente", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Venta no fue Modificado correctamente, intente de nuevo", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Faltan ingresar algunos datos", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value

        End If
    End Sub



    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub cargar_detalle()
        frmdetalle_venta.txtidventa.Text = datalistado.SelectedCells.Item(1).Value
        frmdetalle_venta.txtcodcliente.Text = datalistado.SelectedCells.Item(2).Value
        frmdetalle_venta.txtnombrecliente.Text = datalistado.SelectedCells.Item(3).Value
        frmdetalle_venta.txtfecha.Text = datalistado.SelectedCells.Item(6).Value
        frmdetalle_venta.cbtipo_documento.Text = datalistado.SelectedCells.Item(5).Value
        frmdetalle_venta.txtdni.Text = datalistado.SelectedCells.Item(4).Value
        frmdetalle_venta.txtnum_fac.Text = datalistado.SelectedCells.Item(7).Value
        frmdetalle_venta.ShowDialog()

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()
    End Sub

    Private Sub btnbuscarcliente_Click(sender As Object, e As EventArgs) Handles btnbuscarcliente.Click
        frmcliente.txtflag.Text = "1"
        frmcliente.ShowDialog()
    End Sub
End Class