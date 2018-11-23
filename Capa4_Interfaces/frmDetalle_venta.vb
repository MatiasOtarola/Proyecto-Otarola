Imports Capa2_Logica
Imports Entidad
Public Class frmDetalle_venta
    Private dt As New DataTable
    Private Sub frmDetalle_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtprecio_unitario.Text = ""
        txtcantidad.Text = 1
        txtstock.Text = 0
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New Detalle_VentaMod
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                lninexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
                lninexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnnuevo.Visible = True


        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "Idventa='" & txtidventa.Text & "'"

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
        datalistado.Columns(3).Visible = False
    End Sub
    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "" And txtprecio_unitario.Text <> "" Then  'me va a verificar que las cajas de texto no esten vacias'
            Try
                Dim dts As New vdetalle_venta  'Instancio a la clase cliente donde estan todas las propiedades del mismo'
                Dim func As New Detalle_VentaMod        'Instancio la clase donde estan las funciones del cliente'

                dts._Idventa = txtidventa.Text      'A cada metodo le envio un textbox, y asi por cada uno'
                dts._Idproducto = txtidproducto.Text
                dts._Cantidad = txtcantidad.Text
                dts._Precio_unitario = txtprecio_unitario.Text



                If func.insertar(dts) Then          'condicion que me envia todos los datos del DTS, y me diga los errores del mismo'
                    If func.disminuir_stock(dts) Then

                    End If
                    MessageBox.Show("Articulo fue añadido correctamente a la venta", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()

                Else
                    MessageBox.Show("Articulo no fue añadido correctamente, intente de nuevo", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs)
        buscar()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea Eliminar los articulos?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim mercado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If mercado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID_detalle_venta").Value)
                        Dim vdb As New vdetalle_venta
                        Dim func As New Detalle_VentaMod
                        vdb._Iddetalle_venta = onekey

                        vdb._Idproducto = datalistado.SelectedCells.Item(3).Value
                        vdb._Idventa = datalistado.SelectedCells.Item(2).Value
                        vdb._Cantidad = datalistado.SelectedCells.Item(5).Value

                        If func.eliminar(vdb) Then
                            If func.aumentar_stock(vdb) Then

                            End If
                        Else
                            result = MessageBox.Show("Articulo fue quitado de la venta", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            result = MessageBox.Show("Cancelando eliminacion de Registros", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub

    Private Sub btnbuscar_producto_Click(sender As Object, e As EventArgs)
        frmproducto.txtflag.Text = "1"
        frmproducto.ShowDialog()
    End Sub

    Private Sub txtcantidad_ValueChanged(sender As Object, e As EventArgs) Handles txtcantidad.ValueChanged
        Dim cant As Double

        cant = txtcantidad.Value

        If txtcantidad.Value > txtstock.Value Then
            MessageBox.Show("La cantidad que intenta vender supera stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnguardar.Visible = 0
            txtcantidad.Value = txtstock.Value
        Else
            btnguardar.Visible = 1

        End If
        If txtcantidad.Value = 0 Then
            btnguardar.Visible = 0
        Else
            btnguardar.Visible = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles buttonguardar.Click
        frmproducto.txtflag.Text = "1"
        frmproducto.ShowDialog()
    End Sub
    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        'frmreportecomprobante.txtidventa.Text = txtidventa.Text
        'frmreportecomprobante.ShowDialog()
    End Sub
End Class
