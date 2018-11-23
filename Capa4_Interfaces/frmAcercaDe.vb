Imports Capa3_Seguridad_Servicios
Public Class frmAcercaDe
    Private Sub frmAcercaDe_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cambiar_Idioma() ' llama a la subfuncio nde cambiar el idioma
    End Sub

    Private Sub Cambiar_Idioma() 'subfunciion de cambiar el idioma
        Me.Text = MiIdioma.Acercade
        Me.lblPurchaseAndSell.Text = MiIdioma.PurchaseAndSell
        Me.lblProyecto.Text = MiIdioma.Proyecto
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> BONUS <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private Sub pbLogoCompleto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbLogoCompleto.Click
        Call Small_EasterEgg() 'llama a un EasterEgg
    End Sub

    Private Sub Small_EasterEgg() 'subfuncion de EasterEgg
        Me.lblFrasedelDia.Visible = True 'muestra el lbael de frase del dia
        Dim fecha As Date = Now ' captura  la fecha actual
        fecha.ToShortDateString()
        ' muestra un mensaje disinto segun el dia de la semana
        If fecha.DayOfWeek = DayOfWeek.Monday Then ' dia lunes
            Me.lblFrasedelDia.Text = "Hoy Es Lunes // Today Is Monday"
        ElseIf fecha.DayOfWeek = DayOfWeek.Tuesday Then ' dia martes
            Me.lblFrasedelDia.Text = "Hoy Es Martes// Today Is Tuesday"
        ElseIf fecha.DayOfWeek = DayOfWeek.Wednesday Then ' dia miercoles
            Me.lblFrasedelDia.Text = "Hoy es Miércoles // Today Is Wednesday"
        ElseIf fecha.DayOfWeek = DayOfWeek.Thursday Then ' dia jueves
            Me.lblFrasedelDia.Text = "Hoy es Jueves // Today Is Thursday"
        ElseIf fecha.DayOfWeek = DayOfWeek.Friday Then ' dia viernes
            Me.lblFrasedelDia.Text = "Hoy es Viernes // Today Is Friday"
        ElseIf fecha.DayOfWeek = DayOfWeek.Saturday Then 'dia sabado
            Me.lblFrasedelDia.Text = "Hoy Es Sábado // Today Is Saturday"
        ElseIf fecha.DayOfWeek = DayOfWeek.Sunday Then 'dia domingo
            Me.lblFrasedelDia.Text = "Hoy Es Domingo // Today Is Sunday"
        End If
    End Sub
    Private Sub frmAcercaDe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then 'si se preciona F1 ,muestra la ayuda
            Help.ShowHelp(Me, Application.StartupPath & "\Ayuda.chm", HelpNavigator.TopicId, "250")
        End If
    End Sub

    Private Sub lblPurchaseAndSell_TextChanged(sender As Object, e As EventArgs) Handles lblPurchaseAndSell.TextChanged

    End Sub
End Class