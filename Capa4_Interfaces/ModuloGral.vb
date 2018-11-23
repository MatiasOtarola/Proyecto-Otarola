Imports Capa2_Logica
Imports Capa3_Seguridad_Servicios

Module ModuloGral
    Public MiIdioma As New Idioma
    Public MiError As New frmError
    Public MiBitacora As New Capa3_Seguridad_Servicios.Bitacora
    Public Mi_DV As New Digito_Verificador
    Public El_Encriptador As New Encriptacion
    Public EsValido As New Validar
    Public Pat As New Patente
    Public Cliente As New ClienteMod
    Public Categoria As New CategoriaMod
    Public Producto As New ProductoMod
    Public Fam As New Familia
    Public Usu As New Usuario
    Public Detalle_Venta As New Detalle_VentaMod
    Public Ingreso As New Login
    Public Venta As New VentaMod
    Public BackupRestore As New Backup


End Module
