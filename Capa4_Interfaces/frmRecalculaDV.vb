Public Class frmRecalculaDV

    Private Sub frmRecalculaDVH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaID.Visible = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (ComboBox1.SelectedIndex > -1) Then

            Dim DVH As Long
            Select Case ComboBox1.SelectedItem.ToString

                Case "Usuario"
                    Usu.Cargar_Listbox_Usuario_Familia(ListaID, "select ID_Usuario from Usuario order by ID_Usuario", "Usuario")
                    Dim tempRow As DataRowView
                    For Each tempRow_Variable As DataRowView In ListaID.Items
                        tempRow = tempRow_Variable
                        DVH = Mi_DV.DVH("select * from Usuario where ID_Usuario='" & tempRow(0) & "'", "Usuario")
                        Usu.ConsultarUsu("update Usuario set DVH='" & CInt(DVH) & "' where ID_Usuario='" & tempRow(0) & "'")
                        DVH = 0
                    Next

                    ListaID.DataSource = Nothing
                    ListaID.Items.Clear()
                    MiError.MostrarError("DVH OK", 1) 'muestra mensaje de exito

                Case "Patente"

                    Fam.Cargar_Listbox_Familia_Patente(ListaID, "select ID_Patente from Patente order by ID_Patente", "Patente")
                    Dim tempRow As DataRowView
                    For Each tempRow_Variable As DataRowView In ListaID.Items
                        tempRow = tempRow_Variable
                        DVH = Mi_DV.DVH("select * from Patente where ID_Patente='" & tempRow(0) & "'", "Patente")
                        Pat.AsignarPatente("update Patente set DVH='" & CInt(DVH) & "' where ID_Patente='" & tempRow(0) & "'")
                        DVH = 0
                    Next

                    ListaID.DataSource = Nothing
                    ListaID.Items.Clear()
                    MiError.MostrarError("DVH OK", 1) 'muestra mensaje de exito
                Case "Patente_Familia"

                    Fam.Cargar_Listbox_Familia_Patente(ListaID, "select ID_Patente from Patente_Familia order by ID_Patente", "Patente_Familia")
                    Dim tempRow As DataRowView
                    For Each tempRow_Variable As DataRowView In ListaID.Items
                        tempRow = tempRow_Variable
                        DVH = Mi_DV.DVH("select * from Patente_Familia where ID_Patente='" & tempRow(0) & "'", "Patente_Familia")
                        Pat.AsignarPatente("update Patente_Familia set DVH='" & CInt(DVH) & "' where ID_Patente='" & tempRow(0) & "'")
                        DVH = 0
                    Next

                    ListaID.DataSource = Nothing
                    ListaID.Items.Clear()
                    MiError.MostrarError("DVH OK", 1) 'muestra mensaje de exito
                Case "Usuario_Patente"

                    Usu.Cargar_Listbox_Usuario_Familia(ListaID, "select ID_Usuario from Usuario_Patente order by ID_Usuario", "Usuario_Patente")
                    Dim tempRow As DataRowView
                    For Each tempRow_Variable As DataRowView In ListaID.Items
                        tempRow = tempRow_Variable
                        DVH = Mi_DV.DVH("select * from Usuario_Patente where ID_Usuario='" & tempRow(0) & "'", "Usuario_Patente")
                        Usu.ConsultarUsu("update Usuario_Patente set DVH='" & CInt(DVH) & "' where ID_Usuario='" & tempRow(0) & "'")
                        DVH = 0
                    Next

                    ListaID.DataSource = Nothing
                    ListaID.Items.Clear()
                    MiError.MostrarError("DVH OK", 1) 'muestra mensaje de exito

                Case "Bitacora"




                    Usu.Cargar_Listbox_Usuario_Familia(ListaID, "select ID_Bitacora from Bitacora order by ID_Bitacora", "Bitacora")

                    Dim tempRow As DataRowView
                    For Each tempRow_Variable As DataRowView In ListaID.Items
                        tempRow = tempRow_Variable
                        DVH = Mi_DV.DVH("select * from Bitacora where ID_Bitacora='" & tempRow(0) & "'", "Bitacora")
                        MiBitacora.ActualizarDVH("update Bitacora set DVH='" & CInt(DVH) & "' where ID_Bitacora='" & tempRow(0) & "'")
                        DVH = 0

                    Next
                    MiError.MostrarError("DVH OK", 1) 'muestra mensaje de exito
            End Select
        Else
            MiError.MostrarError(MiIdioma.Err_Blanco, 1)
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dvv, dvv2, dvv3, dvv4, dvv5 As Long
        Dim a, b, c, d, f As String

        Select Case ComboBox1.SelectedItem.ToString

            Case "Usuario"


                dvv3 = Mi_DV.DVV("select sum(DVH) as dvv from Usuario", "dvv")
                c = Usu.RestaurarUsu("select Nombre_Tabla from DVV where Nombre_Tabla='Usuario'", "Nombre_Tabla")
                If c <> "" Then
                    Usu.ConsultarUsu("update DVV set DVV='" & dvv3 & "' where Nombre_Tabla='Usuario'")
                Else
                    Usu.ConsultarUsu("insert into DVV values('Usuario','" & dvv3 & "')")
                End If
            Case "Patente_Familia"

                dvv = Mi_DV.DVV("select sum(DVH) as dvv from Patente_Familia", "dvv")
                a = Fam.Cargar_Listbox_Usuarios("select Nombre_Tabla from DVV where Nombre_Tabla='Patente_Familia'", "Nombre_Tabla")
                If a <> "" Then
                    Fam.AsignarUsuario("update DVV set DVV='" & dvv & "' where Nombre_Tabla='Patente_Familia'")
                Else
                    Fam.AsignarUsuario("insert into DVV values('Patente_Familia','" & dvv & "')")
                End If

            Case "Bitacora"
                dvv2 = Mi_DV.DVV("select sum(DVH) as dvv from Bitacora", "dvv")
                b = MiBitacora.BuscarTablaDVH("select Nombre_Tabla from DVV where Nombre_Tabla='Bitacora'", "Nombre_Tabla")
                If b <> "" Then
                    MiBitacora.ActualizarDVH("update DVV set DVV='" & dvv2 & "' where Nombre_Tabla='Bitacora'")
                Else
                    MiBitacora.ActualizarDVH("insert into DVV values('Bitacora','" & dvv2 & "')")
                End If

            Case "Usuario_Patente"

                dvv4 = Mi_DV.DVV("select sum(DVH) as dvv from Usuario_Patente", "dvv")
                d = Usu.RestaurarUsu("select Nombre_Tabla from DVV where Nombre_Tabla='Usuario_Patente'", "Nombre_Tabla")
                If d <> "" Then
                    Usu.ConsultarUsu("update DVV set DVV='" & dvv4 & "' where Nombre_Tabla='Usuario_Patente'")
                Else
                    Usu.ConsultarUsu("insert into DVV values('Usuario_Patente','" & dvv4 & "')")
                End If
            Case "Patente"
                dvv5 = Mi_DV.DVV("select sum(DVH) as dvv from Patente", "dvv")
                f = Pat.ActualizarFamilia_Patente("select Nombre_Tabla from DVV where Nombre_Tabla='Patente'", "Nombre_Tabla")
                If f <> "" Then
                    Pat.AsignarPatente("update DVV set DVV='" & dvv5 & "' where Nombre_Tabla='Patente'")
                Else
                    Pat.AsignarPatente("insert into DVV values('Patente','" & dvv5 & "')")
                End If
        End Select
        MiError.MostrarError("DVV OK", 1)
    End Sub

End Class