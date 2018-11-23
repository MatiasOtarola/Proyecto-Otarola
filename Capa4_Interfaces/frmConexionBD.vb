Imports System
Imports System.IO
Imports System.Text

Public Class frmConexionBD

    Private Sub frmConexionBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtDataSource.Text = My.Computer.Name
        Me.txtNombreBD.Text = "SistemaVentas"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\conexion.txt"
        If System.IO.File.Exists(path) = True Then
            System.IO.File.Delete(path)
        Else
            System.IO.File.Create(path)
        End If
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(path, False)
            file.WriteLine("Data Source=" & Me.txtDataSource.Text.ToString & ";Initial Catalog=" & Me.txtNombreBD.Text.ToString & ";Integrated Security=True")
            file.Close()
        Catch ex As Exception
            MessageBox.Show("I can't access to the conexion.txt file / No puedo acceder al archivo conexion.txt.", _
         "Important Note / Nota Importante", _
         MessageBoxButtons.OK, _
         MessageBoxIcon.Exclamation, _
         MessageBoxDefaultButton.Button1)
        Finally
            DialogResult = Windows.Forms.DialogResult.OK
            Close()
        End Try


    End Sub
End Class