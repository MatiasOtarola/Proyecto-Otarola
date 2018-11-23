Option Explicit On
Imports Capa3_Seguridad_Servicios
Imports System.IO
Imports System
Public Class frmRestore
    Dim DVHBit As Long

    Dim MiRestore As New Backup
    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        '   Dim Directorio As String = IO.Path.GetFullPath(TraerArchivo.FileName)
        '   If My.Computer.FileSystem.FileExists(Directorio) = False Then
        'MiError.MostrarError(MiIdioma.Err_Conexion, 1)
        '    Else
        ' If TraerArchivo.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        'MiError.MostrarError(MiIdioma.Error1, 1)
        '  Else
        GenerarRestore()
        '    End If
        '   End If
    End Sub
    Private Sub Cambiar_Idioma()
        Me.Text = MiIdioma.Restore
        gb.Text = MiIdioma.Detalle
        Me.btnExaminar.Text = MiIdioma.Examinar
    End Sub

    Private Sub frmRestore_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.Cambiar_Idioma()
    End Sub
    Private Sub frmRestore_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2) ' pregunta antes de cerra, si acpeta se cierra
        If MiError.Seleccion = 1 Then
            Dim dvv2 As Long
            Dim b As String

            dvv2 = Mi_DV.DVV("select sum(DVH) as dvv from Bitacora", "dvv")
            b = MiBitacora.BuscarTablaDVH("select Nombre_Tabla from DVV where Nombre_Tabla='Bitacora'", "Nombre_Tabla")
            If b <> "" Then
                MiBitacora.ActualizarDVH("update DVV set DVV='" & dvv2 & "' where Nombre_Tabla='Bitacora'")
            Else
                MiBitacora.ActualizarDVH("insert into DVV values('Bitacora','" & dvv2 & "')")
            End If
            MiError.MostrarError("D.V. OK", 1)
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub RegistrarRestore()
        Try
            Dim fecha As Date = Now
            Dim Descripcion As String = "RESTORE:RESTAURACIÓN"
            'alta en la bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "RESTORE", Descripcion, fecha, "1", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
        Catch ex As Exception
            MiError.MostrarError(MiIdioma.Error1, 1)
        End Try
    End Sub
    Private Sub GenerarRestore()
        Try
            MiRestore.Restaurar(TraerArchivo)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            MiError.MostrarError(MiIdioma.OK_Restore, 1)
            RegistrarRestore()
        Catch ex As Exception
            MiError.MostrarError(MiIdioma.Err_SQL, 1)
        End Try

    End Sub

    Private Sub frmRestore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Help.ShowHelp(Me, "C:\temp\Ayuda.chm", HelpNavigator.TopicId)
        End If
    End Sub
End Class