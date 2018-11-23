Imports System.ServiceProcess
Public Class fitem
    Private ReadOnly _DisplayName As String
    Public ReadOnly Property DisplayName() As String
        Get
            Return _DisplayName
        End Get
    End Property

    Private ReadOnly _DisplayServiceType As String
    Public ReadOnly Property DisplayServiceType() As String
        Get
            Return _DisplayServiceType
        End Get
    End Property

    Private ReadOnly _DisplayStatus As String
    Public ReadOnly Property DisplayStatus() As String
        Get
            Return _DisplayStatus
        End Get
    End Property

    Private ReadOnly _MachineName As String
    Public ReadOnly Property MachineName() As String
        Get
            Return _MachineName
        End Get
    End Property

    Sub New(ByVal elemento As ServiceController)
        Me._DisplayName = elemento.DisplayName
        Me._DisplayServiceType = elemento.ServiceType
        Me._DisplayStatus = Convert.ToString(elemento.Status)
        If ServiceControllerStatus.Running = elemento.Status Then
            Me._DisplayStatus = "Running"
        End If
        If ServiceControllerStatus.Stopped = elemento.Status Then
            Me._DisplayStatus = "Stopped"
        End If

        Me._MachineName = elemento.MachineName
    End Sub
End Class
