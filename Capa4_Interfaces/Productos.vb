Partial Class Productos
    Partial Class ProductosDataTable

        Private Sub ProductosDataTable_ProductosRowChanging(sender As Object, e As ProductosRowChangeEvent) Handles Me.ProductosRowChanging

        End Sub

        Private Sub ProductosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Precio_CompraColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
