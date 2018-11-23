Imports Capa2_Logica
Imports Entidad
Public Class frmCategoria
    Private dt As New DataTable
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombrecategoria.Text = ""
        txtidcategoria.Text = ""
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New CategoriaMod
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
    End Sub
    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombrecategoria.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de la Categoria Por favor, este dato es obligatorio")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombrecategoria.Text <> "" Then  'me va a verificar que las cajas de texto no esten vacias'
            Try
                Dim dts As New vcategoria     'Instancio a la clase categoria donde estan todas las propiedades del mismo'
                Dim func As New CategoriaMod       'Instancio la clase donde estan las funciones de la categoria'

                dts.Nombrecategoria = txtnombrecategoria.Text            'A cada metodo le envio un textbox, y asi por cada uno'


                If func.insertar(dts) Then          'condicion que me envia todos los datos del DTS, y me diga los errores del mismo'
                    MessageBox.Show("Categoria registrada correctamente", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Categoria no fue registrada correctamente, intente de nuevo", "Guardando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
        txtnombrecategoria.Text = datalistado.SelectedCells.Item(2).Value
        btneditar.Visible = True
        btnguardar.Visible = False

    End Sub
    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult      'Que salte un mensaje en el formulario para comprobar si realmente desea modificar y no toco el boton por error'
        result = MessageBox.Show("Realmente desea editar los datos de la categoria?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then



            If Me.ValidateChildren = True And txtnombrecategoria.Text <> "" And txtidcategoria.Text <> "" Then  'me va a verificar que las cajas de texto no esten vacias'
                Try
                    Dim dts As New vcategoria    'Instancio a la clase categoria donde estan todas las propiedades del mismo'
                    Dim func As New CategoriaMod       'Instancio la clase donde estan las funciones del categoria'

                    dts._IDcategoria = txtidcategoria.Text
                    dts.Nombrecategoria = txtnombrecategoria.Text            'A cada metodo le envio un textbox, y asi por cada uno'


                    If func.editar(dts) Then          'condicion que me envia todos los datos del DTS, y me diga los errores del mismo'
                        MessageBox.Show("Categoria Modificada correctamente", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Categoria no fue Modificada correctamente, intente de nuevo", "Modificando datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente desea Eliminar la categoria seleccionada?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim mercado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If mercado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("Idcategoria").Value)
                        Dim vdb As New vcategoria
                        Dim func As New CategoriaMod
                        vdb._IDcategoria = onekey

                        If func.eliminar(vdb) Then
                        Else
                            result = MessageBox.Show("Categoria no fue eliminada correctamente", "Eliminando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            frmproducto.txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
            frmproducto.txtnombre_categoria.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub
End Class