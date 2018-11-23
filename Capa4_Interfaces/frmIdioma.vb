Public Class frmIdioma
    Dim DR As SqlClient.SqlDataReader
    Private Sub frmIdioma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cambiar_Idioma()
        Me.CtrlIdioma1.Cambiar_Seleccion(Usu.Idioma)
    End Sub
    Private Sub Cambiar_Idioma()
        Me.Text = MiIdioma.Idioma_Text
        lblIdioma.Text = MiIdioma.Seleccionar & " " & MiIdioma.Idioma_Text
        btnAceptar.Text = MiIdioma.Aceptar
        btnCancelar.Text = MiIdioma.Cancelar
    End Sub
    Private Sub Backup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MiError.MostrarError(MiIdioma.Esperar, 2)
        If MiError.Seleccion = 1 Then
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub frmPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Help.ShowHelp(Me, "Ayuda.chm")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        MiError.MostrarError(MiIdioma.OK_Idioma, 2)
        If MiError.Seleccion = 1 Then
            Me.Close()
            MiIdioma.Cod_Idioma = CtrlIdioma1.Idioma
            Usu.Idioma = MiIdioma.Cod_Idioma
            MiIdioma.IIM(MiIdioma.Cod_Idioma, Usu.ID_Usuario)
            frmMenu.Actualizar_Idioma()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub frmActivated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cambiar_Idioma()
    End Sub
End Class