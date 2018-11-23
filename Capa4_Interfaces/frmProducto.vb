Imports Capa2_Logica
Imports Entidad
Public Class frmProducto
    Private dt As New DataTable
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombreproducto.Text = ""
        txtdescripcion.Text = ""
        txtprecio_compra.Text = "0"
        txtstock.Text = "0"
        txtidproducto.Text = ""
        txtprecio_venta.Text = "0"

        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.imagen_transparente
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New ProductoMod
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



    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombreproducto.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del producto Por favor, este dato es obligatorio")
        End If
    End Sub






    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombreproducto.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then  'me va a verificar que las cajas de texto no esten vacias'
            Try
                Dim dts As New vproducto   'Instancio a la clase cliente donde estan todas las propiedades del mismo'
                Dim func As New ProductoMod       'Instancio la clase donde estan las funciones del cliente'


                dts._Nombre_Producto = txtnombreproducto.Text            'A cada metodo le envio un textbox, y asi por cada uno'
                dts._Idcategoria = txtidcategoria.Text
                dts._Descripcion = txtdescripcion.Text
                dts.precio_ventap = txtprecio_venta.Text
                dts.Precio_comprap = txtprecio_compra.Text
                dts._stock = txtstock.Text

                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.imagen_transparente
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If
                dts._Imagen = ms.GetBuffer


                If func.insertar(dts) Then          'condicion que me envia todos los datos del DTS, y me diga los errores del mismo'
                    MessageBox.Show("Producto registrado correctamente", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("El producto no fue registrado correctamente, intente de nuevo", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_categoria.Text = datalistado.SelectedCells.Item(3).Value
        txtnombreproducto.Text = datalistado.SelectedCells.Item(4).Value
        txtdescripcion.Text = datalistado.SelectedCells.Item(5).Value
        txtstock.Text = datalistado.SelectedCells.Item(6).Value
        txtprecio_compra.Text = datalistado.SelectedCells.Item(7).Value
        txtprecio_venta.Text = datalistado.SelectedCells.Item(8).Value


        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(9).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage


        btneditar.Visible = True
        btnguardar.Visible = False

    End Sub


    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult      'Que salte un mensaje en el formulario para comprobar si realmente desea modificar y no toco el boton por error'
        result = MessageBox.Show("Realmente desea editar los datos del producto?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then



            If Me.ValidateChildren = True And txtnombreproducto.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" And txtidproducto.Text <> "" Then  'me va a verificar que las cajas de texto no esten vacias'
                Try
                    Dim dts As New vproducto     'Instancio a la clase cliente donde estan todas las propiedades del mismo'
                    Dim func As New ProductoMod        'Instancio la clase donde estan las funciones del cliente'


                    dts._Idproducto = txtidproducto.Text
                    dts._Nombre_Producto = txtnombreproducto.Text            'A cada metodo le envio un textbox, y asi por cada uno'
                    dts._Idcategoria = txtidcategoria.Text
                    dts._Descripcion = txtdescripcion.Text
                    dts.precio_ventap = txtprecio_venta.Text
                    dts.Precio_comprap = txtprecio_compra.Text
                    dts._stock = txtstock.Text

                    Dim ms As New IO.MemoryStream()

                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    Else
                        imagen.Image = My.Resources.imagen_transparente
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    End If
                    dts._Imagen = ms.GetBuffer

                    If func.editar(dts) Then          'condicion que me envia todos los datos del DTS, y me diga los errores del mismo'
                        MessageBox.Show("Producto Modificado correctamente", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("El producto no fue Modificado correctamente, intente de nuevo", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente desea Eliminar el producto seleccionado?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim mercado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If mercado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("ID_Producto").Value)
                        Dim vdb As New vproducto
                        Dim func As New ProductoMod
                        vdb._Idproducto = onekey

                        If func.eliminar(vdb) Then
                        Else
                            result = MessageBox.Show("Producto no fue eliminado correctamente", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.imagen_transparente
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        frmcategoria.txtflag.Text = "1"
        frmcategoria.ShowDialog()
    End Sub
    'Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
    '    If txtflag.Text = "1" Then
    '        frmdetalle_venta.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
    '        frmdetalle_venta.txtnombre_producto.Text = datalistado.SelectedCells.Item(4).Value
    '        frmdetalle_venta.txtstock.Text = datalistado.SelectedCells.Item(6).Value
    '        frmdetalle_venta.txtprecio_unitario.Text = datalistado.SelectedCells.Item(8).Value
    '        Me.Close()
    '    End If
    'End Sub
End Class