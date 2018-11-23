Imports System.ServiceProcess
Imports Capa2_Logica
Public Class frmProcesos
    Dim ds As DataSet = New DataSet
    Dim dt As DataTable = New DataTable
    Dim filtro As Integer = 0
    Private Sub frmProcesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("DisplayName")
        dt.Columns.Add("ServiceType")
        dt.Columns.Add("Status")
        dt.Columns.Add("MachineName")

        ds.Tables.Add(dt)
        CargarServicios(filtro, dt, DataGridView1, ds)
    End Sub
    Sub CargarServicios(ByVal filtro As Integer, ByVal dt As DataTable, ByVal grilla As DataGridView, ByVal ds As DataSet)
        dt.Rows.Clear()
        For Each i In ServiceController.GetServices
            Dim servicio As fitem
            servicio = New fitem(i)
            Select Case (filtro)
                Case 1
                    If Convert.ToInt16(servicio.DisplayStatus) = 4 Then 'running
                        dt.Rows.Add(servicio.DisplayName, servicio.DisplayServiceType, servicio.DisplayStatus, servicio.MachineName)
                    End If
                Case 2
                    If Convert.ToInt16(servicio.DisplayStatus) = 1 Then 'stopped
                        dt.Rows.Add(servicio.DisplayName, servicio.DisplayServiceType, servicio.DisplayStatus, servicio.MachineName)
                    End If
                Case 3
                    If Convert.ToInt16(servicio.DisplayStatus) = 1 Or Convert.ToInt16(servicio.DisplayStatus) = 4 Then 'stopped & Running
                        dt.Rows.Add(servicio.DisplayName, servicio.DisplayServiceType, servicio.DisplayStatus, servicio.MachineName)
                    End If
                Case Else
                    dt.Rows.Add(servicio.DisplayName, servicio.DisplayServiceType, servicio.DisplayStatus, servicio.MachineName)
            End Select
        Next
        grilla.DataSource = Nothing
        grilla.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And CheckBox2.Checked = False Then
            filtro = 4
        End If

        If CheckBox2.Checked = True And CheckBox1.Checked = False Then
            filtro = 1
        End If

        If CheckBox2.Checked = True And CheckBox1.Checked = True Then
            filtro = 3
        End If

        CargarServicios(filtro, dt, DataGridView1, ds)
    End Sub

End Class