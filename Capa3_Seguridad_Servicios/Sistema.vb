Imports Capa1_Datos
Public Class Sistema
    Dim MiAcceso As New Acceso
    Public Function consultarBDD(ByVal query As String)
        Return MiAcceso.EjecutarConsultaDR(query)
    End Function
End Class

