Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class frmReporteProducto

    Private Sub frmReporteProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dsCustomers As Productos = GetData()
        Dim datasource As New ReportDataSource("Productos", dsCustomers.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Function GetData() As Productos


        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\conexion.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        Using con As New SqlConnection(stringReader)
            Using cmd As New SqlCommand("SELECT Producto.ID_Producto, Categoria.Nombre_Categoria as Categoria, Producto.ID_Reserva, Producto.Descripcion [Descripcion], Producto.Nombre_Producto, Producto.Stock, Producto.Precio_Compra, Producto.Precio_Venta FROM  Producto INNER JOIN Categoria ON Producto.ID_Categoria = Categoria.ID_Categoria")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsProductos As New Productos()
                        sda.Fill(dsProductos, "Productos")
                        Return dsProductos
                    End Using
                End Using
            End Using
        End Using
    End Function
End Class