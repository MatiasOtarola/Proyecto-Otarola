Imports Capa3_Seguridad_Servicios
Imports System.IO
Public Class frmBackup
    Dim DVHBit As Long
    Dim MiBackUp As New Backup
    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Dim fecha As Date = Now
        GenerarBackUp()
    End Sub

    Private Sub Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cambiar_Idioma()
        HelpProvider.HelpNamespace = Application.StartupPath & "\Ayuda.chm" 'carga la ayuda
    End Sub

    Private Sub Cambiar_Idioma()
        Me.Text = MiIdioma.Backup
        gb.Text = MiIdioma.Detalle
        btnExaminar.Text = MiIdioma.Examinar
    End Sub

    Private Sub GenerarBackUp()
        Try

            MiBackUp.Generar(GuardarArchivo)
            MiBackUp.RegistrarBackup("Backup: " & GuardarArchivo.FileName & " Fecha: " & Now)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            MiError.MostrarError(MiIdioma.OK_Backup, 1)
            RegistrarBackup()


        Catch ex As Exception
            MiError.MostrarError(MiIdioma.Err_SQL, 1)
        End Try

    End Sub
    Private Sub RegistrarBackup()


        Try 'intenta registrarlo
            Dim fecha As Date = Now
            Dim Descripcion As String = "BACKUP:GENERACIÓN"
            'accesa a la bitacora
            MiBitacora.AccesarBitacora(frmMenu.txtLog.Text, "BACKUP", Descripcion, fecha, "3", 0)
            DVHBit = Mi_DV.DVH("select * from Bitacora where ID_Bitacora=" & MiBitacora.crearNuevaBitacora(), "Bitacora")
            MiBitacora.ActualizarDVH("update Bitacora set DVH='" & DVHBit & "' where ID_Bitacora=" & MiBitacora.crearNuevaBitacora())
        Catch ex As Exception ' si surge un error, meustra una excepción
            MiError.MostrarError(MiIdioma.Error1, 1)
        End Try



    End Sub
    Private Sub frmBackup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub frmBackUp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Help.ShowHelp(Me, "Ayuda.chm")
        End If
    End Sub

End Class