Imports System.Data
Imports Capa1_Datos
Public Class Idioma

    Private _Cod_Idioma As Integer
    Public Property Cod_Idioma()
        Get
            Return _Cod_Idioma
        End Get
        Set(ByVal value)
            _Cod_Idioma = value
        End Set
    End Property
    Public ReadOnly Property Nombre()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Nombre
                Case 2
                    Return My.Resources.resIngles.Nombre
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Consulta()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Consulta
                Case 2
                    Return My.Resources.resIngles.Consulta
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Idioma_Cambiar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Idioma_Cambiar
                Case 2
                    Return My.Resources.resIngles.Idioma_Cambiar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ReporteEmpleados()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ReporteEmpleados
                Case 2
                    Return My.Resources.resIngles.ReporteEmpleados
            End Select
            Return Nothing
        End Get
    End Property



    Public ReadOnly Property Cobrar_Cheque()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cobrar_Cheque
                Case 2
                    Return My.Resources.resIngles.Cobrar_Cheque
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Total_Cobro()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Total_Cobro
                Case 2
                    Return My.Resources.resIngles.Total_Cobro
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cancelar_Nuevo()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cancelar_Nuevo
                Case 2
                    Return My.Resources.resIngles.Cancelar_Nuevo
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Exito()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Exito
                Case 2
                    Return My.Resources.resIngles.Exito
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Existe()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Existe
                Case 2
                    Return My.Resources.resIngles.Err_Existe
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Desde()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Desde
                Case 2
                    Return My.Resources.resIngles.Desde
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Hasta()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Hasta
                Case 2
                    Return My.Resources.resIngles.Hasta
            End Select
            Return Nothing
        End Get
    End Property
 
   
    Public ReadOnly Property Hora()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Hora
                Case 2
                    Return My.Resources.resIngles.Hora
            End Select
            Return Nothing
        End Get
    End Property
 
  
  

    Public ReadOnly Property Cod_Cheque()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cod_Cheque
                Case 2
                    Return My.Resources.resIngles.Cod_Cheque
            End Select
            Return Nothing
        End Get
    End Property
   
    Public ReadOnly Property ttEstado()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttEstado
                Case 2
                    Return My.Resources.resIngles.ttEstado
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttSucursal()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttSucursal
                Case 2
                    Return My.Resources.resIngles.ttSucursal
            End Select
            Return Nothing
        End Get
    End Property
 
 


    Public ReadOnly Property Buscar_Estado()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Buscar_Estado
                Case 2
                    Return My.Resources.resIngles.Buscar_Estado
            End Select
            Return Nothing
        End Get
    End Property
 
 







    Public ReadOnly Property Err_Busqueda()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Busqueda
                Case 2
                    Return My.Resources.resIngles.Err_Busqueda
            End Select
            Return Nothing
        End Get
    End Property

  
    Public ReadOnly Property MiembroDe()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.MiembroDe
                Case 2
                    Return My.Resources.resIngles.MiembroDe
            End Select
            Return Nothing
        End Get
    End Property
  
    Public ReadOnly Property Quitar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Quitar
                Case 2
                    Return My.Resources.resIngles.Quitar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Titulo_BU()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Titulo_BU
                Case 2
                    Return My.Resources.resIngles.Titulo_BU
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Titulo_RS()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Titulo_RS
                Case 2
                    Return My.Resources.resIngles.Titulo_RS
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Blanco()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Blanco
                Case 2
                    Return My.Resources.resIngles.Err_Blanco
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Ocupacion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Ocupacion
                Case 2

                    Return My.Resources.resIngles.Ocupacion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property DetallesCuenta()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.DetallesCuenta
                Case 2
                    Return My.Resources.resIngles.DetallesCuenta
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Controles()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Controles
                Case 2
                    Return My.Resources.resIngles.Controles
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property SiCliente()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.CheckCliente
                Case 2
                    Return My.Resources.resIngles.CheckCliente
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property NoCliente()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.CheckNoCliente
                Case 2
                    Return My.Resources.resIngles.CheckNoCliente
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Actualizar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Actualizar
                Case 2

                    Return My.Resources.resIngles.Actualizar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Limpiar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Limpiar
                Case 2

                    Return My.Resources.resIngles.Limpiar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Registrar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Registrar
                Case 2

                    Return My.Resources.resIngles.Registrar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property direccion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Direccion
                Case 2

                    Return My.Resources.resIngles.Direccion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property localidad()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Localidad
                Case 2
                    Return My.Resources.resIngles.Localidad
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property provincia()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Provincia
                Case 2
                    Return My.Resources.resIngles.Provincia
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Fecha_Nac()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Fecha_Nac
                Case 2
                    Return My.Resources.resIngles.Fecha_Nac
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Nuevo()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Nuevo
                Case 2
                    Return My.Resources.resIngles.Nuevo
            End Select
            Return Nothing
        End Get
    End Property
  
    Public ReadOnly Property Usuario()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Usuario
                Case 2
                    Return My.Resources.resIngles.Usuario
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Contrasena()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Contrasena
                Case 2
                    Return My.Resources.resIngles.Contrasena
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Examinar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Examinar
                Case 2
                    Return My.Resources.resIngles.Examinar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Esperar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Esperar
                Case 2
                    Return My.Resources.resIngles.Esperar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Error_Reing_Pass()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Error_Reing_Pass
                Case 2
                    Return My.Resources.resIngles.Error_Reing_Pass
            End Select
            Return Nothing
        End Get
    End Property
  
    Public ReadOnly Property Buscar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Buscar
                Case 2
                    Return My.Resources.resIngles.Buscar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Anterior()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Anterior
                Case 2
                    Return My.Resources.resIngles.Anterior
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Seguridad()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Seguridad
                Case 2

                    Return My.Resources.resIngles.Seguridad
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Finanzas()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Finanzas
                Case 2

                    Return My.Resources.resIngles.Finanzas
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Listado_Cheques()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Listado_Cheque
                Case 2

                    Return My.Resources.resIngles.Listado_Cheque
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Ver()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Ver
                Case 2

                    Return My.Resources.resIngles.Ver
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Descripcion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Descripcion
                Case 2

                    Return My.Resources.resIngles.Descripcion
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Aceptar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Aceptar
                Case 2
                    Return My.Resources.resIngles.Aceptar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cancelar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cancelar
                Case 2
                    Return My.Resources.resIngles.Cancelar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Detalle()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Detalle
                Case 2
                    Return My.Resources.resIngles.Detalle
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Seleccionar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Seleccionar
                Case 2
                    Return My.Resources.resIngles.Seleccionar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ID()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ID
                Case 2
                    Return My.Resources.resIngles.ID
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Comentarios()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Comentarios
                Case 2

                    Return My.Resources.resIngles.Comentarios
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Costo()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Costo
                Case 2

                    Return My.Resources.resIngles.Costo
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Eliminar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Eliminar
                Case 2

                    Return My.Resources.resIngles.Eliminar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Agregar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Registrar
                Case 2

                    Return My.Resources.resIngles.Registrar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Agregar_text()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Agregar
                Case 2

                    Return My.Resources.resIngles.Agregar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Empleado()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Empleado
                Case 2

                    Return My.Resources.resIngles.Empleado
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cargo()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cargo
                Case 2

                    Return My.Resources.resIngles.Cargo
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Telefonos()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Telefono
                Case 2

                    Return My.Resources.resIngles.Telefono
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Fecha_Ing()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Fecha_Ing
                Case 2

                    Return My.Resources.resIngles.Fecha_Ing
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Fecha()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Fecha
                Case 2

                    Return My.Resources.resIngles.Fecha
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Monto()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Monto
                Case 2

                    Return My.Resources.resIngles.Monto
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Numero()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Numero
                Case 2

                    Return My.Resources.resIngles.Numero
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Familia()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Familia
                Case 2

                    Return My.Resources.resIngles.Familia
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Concepto()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Concepto
                Case 2

                    Return My.Resources.resIngles.Concepto
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Comprobante()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Comprobante
                Case 2

                    Return My.Resources.resIngles.Comprobante
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cliente()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cliente
                Case 2

                    Return My.Resources.resIngles.Cliente
            End Select
            Return Nothing
        End Get
    End Property


    Public ReadOnly Property EMail()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.EMail
                Case 2

                    Return My.Resources.resIngles.EMail
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Estado()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Estado
                Case 2

                    Return My.Resources.resIngles.Estado
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Tipo()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.TipoTel
                Case 2

                    Return My.Resources.resIngles.TipoTel
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cod_Cuenta()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cod_Cuenta
                Case 2

                    Return My.Resources.resIngles.Cod_Cuenta
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Herramientas()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Herramientas
                Case 2

                    Return My.Resources.resIngles.Herramientas
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Ventanas()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Ventanas
                Case 2

                    Return My.Resources.resIngles.Ventanas
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Reportes()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Reportes
                Case 2

                    Return My.Resources.resIngles.Reportes
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Backup()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Backup
                Case 2
                    Return My.Resources.resIngles.Backup
            End Select
            Return Nothing
        End Get
    End Property

   
    Public ReadOnly Property SucursalNro()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.SucursalNro
                Case 2
                    Return My.Resources.resIngles.SucursalNro
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property SucursalDir()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.SucursalDir
                Case 2
                    Return My.Resources.resIngles.SucursalDir
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Comprimir()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Comprimir
                Case 2
                    Return My.Resources.resIngles.Comprimir
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Todos()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Todos
                Case 2
                    Return My.Resources.resIngles.Todos
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Error1()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Error1
                Case 2
                    Return My.Resources.resIngles.Error1
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ABMCliente()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ABMCliente
                Case 2

                    Return My.Resources.resIngles.ABMCliente
            End Select
            Return Nothing
        End Get
    End Property
  
    Public ReadOnly Property Restore()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Restore
                Case 2

                    Return My.Resources.resIngles.Restore
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property OK_Backup()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.OK_Backup
                Case 2

                    Return My.Resources.resIngles.OK_Backup
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Conexion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Conexion
                Case 2

                    Return My.Resources.resIngles.Err_Conexion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property OK_Restore()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.OK_Restore
                Case 2

                    Return My.Resources.resIngles.OK_Restore
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property OK_Idioma()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.OK_Idioma
                Case 2

                    Return My.Resources.resIngles.OK_Idioma
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Idioma_Text()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Idioma_Text
                Case 2

                    Return My.Resources.resIngles.Idioma_Text
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property OK_Password()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.OK_Password
                Case 2

                    Return My.Resources.resIngles.OK_Password
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_PassV()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_PassV
                Case 2

                    Return My.Resources.resIngles.Err_PassV
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_PassN()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_PassN
                Case 2

                    Return My.Resources.resIngles.Err_PassN
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Cantidad()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Cantidad
                Case 2

                    Return My.Resources.resIngles.Err_Cantidad
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Campo()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Campo
                Case 2

                    Return My.Resources.resIngles.Err_Campo
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Usuario()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Usuario
                Case 2

                    Return My.Resources.resIngles.Err_usuario
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Rein_Pass()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Rein_Pass
                Case 2

                    Return My.Resources.resIngles.Rein_Pass
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Pass_Vieja()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Pass_viejo
                Case 2

                    Return My.Resources.resIngles.Pass_Viejo
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Pass_Nueva()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Pass_Nuevo
                Case 2

                    Return My.Resources.resIngles.Pass_Nuevo
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_BD()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_BD
                Case 2

                    Return My.Resources.resIngles.Err_BD
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Adm()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Adm
                Case 2

                    Return My.Resources.resIngles.Err_Adm
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property RepararBD()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ReparacionBD
                Case 2

                    Return My.Resources.resIngles.ReparacionBD
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Patentes()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Patentes
                Case 2

                    Return My.Resources.resIngles.Patentes
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Iniciar_Sesion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Iniciar_Sesion
                Case 2

                    Return My.Resources.resIngles.Iniciar_Sesion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cerrar_Sesion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cerrar_Sesion
                Case 2

                    Return My.Resources.resIngles.Cerrar_Sesion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Imprimir()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Imprimir
                Case 2

                    Return My.Resources.resIngles.Imprimir
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Opciones()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Opciones
                Case 2

                    Return My.Resources.resIngles.Opciones
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Preview()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Preview
                Case 2

                    Return My.Resources.resIngles.Preview
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Ayuda()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Ayuda
                Case 2

                    Return My.Resources.resIngles.Ayuda
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttNombreU()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttNombreU
                Case 2

                    Return My.Resources.resIngles.ttNombreU
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttNombreS()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttNombreC
                Case 2

                    Return My.Resources.resIngles.ttNombreC
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttTelefono()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttTelefono
                Case 2
                    Return My.Resources.resIngles.ttTelefono
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttTipoTel()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttTipotel
                Case 2
                    Return My.Resources.resIngles.ttTipoTel
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttCod_Post()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttCod_Post
                Case 2
                    Return My.Resources.resIngles.ttCod_Post
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttEmail()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttEmail
                Case 2
                    Return My.Resources.resIngles.ttEmail
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttOcupacion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttOcupacion
                Case 2
                    Return My.Resources.resIngles.ttOcupacion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttPais()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttPais
                Case 2
                    Return My.Resources.resIngles.ttPais
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttDireccion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttDireccion
                Case 2
                    Return My.Resources.resIngles.ttDireccion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttLocalidad()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttLocalidad
                Case 2
                    Return My.Resources.resIngles.ttLocalidad
            End Select
            Return Nothing
        End Get
    End Property
  
    Public ReadOnly Property ttNroCuenta()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttNroCuenta
                Case 2
                    Return My.Resources.resIngles.ttNroCuenta
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttNoCliente()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttNoCliente
                Case 2
                    Return My.Resources.resIngles.ttNoCliente
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttSiCliente()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttSiCliente
                Case 2
                    Return My.Resources.resIngles.ttSiCliente
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttProvincia()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttProvincia
                Case 2
                    Return My.Resources.resIngles.ttProvincia
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttCUIT()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttCUIT
                Case 2
                    Return My.Resources.resIngles.ttCUIT
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ttDNI()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ttDNI
                Case 2
                    Return My.Resources.resIngles.ttDNI
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_SQL()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_SQL
                Case 2
                    Return My.Resources.resIngles.Err_SQL
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Asignar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Asignar
                Case 2
                    Return My.Resources.resIngles.Asignar
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Vertical()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Vertical
                Case 2
                    Return My.Resources.resEspañol.Vertical
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Horizontal()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Horizontal
                Case 2
                    Return My.Resources.resEspañol.Horizontal
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Acercade()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Acercade
                Case 2
                    Return My.Resources.resIngles.Acercade
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Reporte()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Reporte
                Case 2
                    Return My.Resources.resIngles.Reporte
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cascada()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cascada
                Case 2
                    Return My.Resources.resIngles.Cascada
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Listar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Listar
                Case 2
                    Return My.Resources.resIngles.Listar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Copiar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Copiar
                Case 2
                    Return My.Resources.resIngles.Copiar
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property BEstado()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.BEstado
                Case 2
                    Return My.Resources.resIngles.BEstado
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cobro()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cheque_C
                Case 2
                    Return My.Resources.resIngles.Cheque_C
            End Select
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Cambiar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cambiar
                Case 2
                    Return My.Resources.resIngles.Cambiar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Bitacora()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Bitacora
                Case 2
                    Return My.Resources.resIngles.Bitacora
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cerrar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cerrar
                Case 2

                    Return My.Resources.resIngles.Cerrar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Contenido()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Contenido
                Case 2

                    Return My.Resources.resIngles.Contenido
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Indice()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Indice
                Case 2

                    Return My.Resources.resIngles.Indice
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Salir()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Salir
                Case 2

                    Return My.Resources.resIngles.Salir
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Administracion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Administracion
                Case 2

                    Return My.Resources.resIngles.Administracion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Cod_Post()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Cod_Post
                Case 2
                    Return My.Resources.resIngles.Cod_Post
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Edad()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Edad
                Case 2
                    Return My.Resources.resIngles.Edad
            End Select
            Return Nothing
        End Get
    End Property
    
    Public ReadOnly Property Pais()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Pais
                Case 2
                    Return My.Resources.resIngles.Pais
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ABMFamilia()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ABMFamilia
                Case 2
                    Return My.Resources.resIngles.ABMFamilia
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ABMPatente()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ABMPatente
                Case 2
                    Return My.Resources.resIngles.ABMPatente
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ABMUsuario()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ABMUsuario
                Case 2
                    Return My.Resources.resIngles.ABMUsuario
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Usu_Fam()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Usu_Fam
                Case 2
                    Return My.Resources.resIngles.Err_Usu_Fam
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Activar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Activar
                Case 2
                    Return My.Resources.resIngles.Activar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Automatico()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Automatico
                Case 2
                    Return My.Resources.resIngles.Automatico
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Desactivar()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Desactivar
                Case 2
                    Return My.Resources.resIngles.Desactivar
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Activado()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Activado
                Case 2
                    Return My.Resources.resIngles.Activado
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Desactivado()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Desactivado
                Case 2
                    Return My.Resources.resIngles.Desactivado
            End Select
            Return Nothing
        End Get
    End Property
 
 
    Public ReadOnly Property Proyecto()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Proyecto
                Case 2
                    Return My.Resources.resIngles.Proyecto
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property PurchaseAndSell()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.PurchaseAndSell
                Case 2
                    Return My.Resources.resIngles.PurchaseAndSell
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Nick()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Nick
                Case 2
                    Return My.Resources.resIngles.Nick
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Condicion()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Condicion
                Case 2
                    Return My.Resources.resIngles.Condicion
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Evento()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Evento
                Case 2
                    Return My.Resources.resIngles.Evento
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Criticidad()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Criticidad
                Case 2
                    Return My.Resources.resIngles.Criticidad
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property DV()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.DV
                Case 2
                    Return My.Resources.resIngles.DV
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Preg_Opera()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Preg_Opera
                Case 2
                    Return My.Resources.resIngles.Preg_Opera
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Err_Elim_Fam()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Err_Elim_Fam
                Case 2
                    Return My.Resources.resIngles.Err_Elim_Fam
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Ingresos()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Ingresos
                Case 2
                    Return My.Resources.resIngles.Ingresos
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Categorias()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Categorias
                Case 2
                    Return My.Resources.resIngles.Categorias
            End Select
            Return Nothing
        End Get
    End Property


    Public ReadOnly Property Productos()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Productos
                Case 2
                    Return My.Resources.resIngles.Productos
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Ventas()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Ventas
                Case 2
                    Return My.Resources.resIngles.Ventas
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property RegistroVentas()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.RegistroVentas
                Case 2
                    Return My.Resources.resIngles.RegistroVentas
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Reserva()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Reserva
                Case 2
                    Return My.Resources.resIngles.Reserva
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property DetalleVentas()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.DetalleVentas
                Case 2
                    Return My.Resources.resIngles.DetalleVentas
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property ReporteProductos()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.ReporteProductos
                Case 2
                    Return My.Resources.resIngles.ReporteProductos
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Configuraciones()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Configuraciones
                Case 2
                    Return My.Resources.resIngles.Configuraciones
            End Select
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property Procesos()
        Get
            Select Case _Cod_Idioma
                Case 1
                    Return My.Resources.resEspañol.Procesos
                Case 2
                    Return My.Resources.resIngles.Procesos
            End Select
            Return Nothing
        End Get
    End Property
    Public Sub New()
        _Cod_Idioma = 1
    End Sub
    Public Function SeleccionarTipoIdioma(ByVal Cod_Idioma As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Select * from Idioma where ID_Idioma = " & Cod_Idioma
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function IIM(ByVal Cod_Idioma As Integer, ByVal Cod_Usu As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "UPDATE Usuario SET Idioma =" & Cod_Idioma & " where ID_Usuario = " & Cod_Usu
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Function Leyenda(ByVal Nombre As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String = ""
        Consulta = "SELECT * FROM (Usuario INNER JOIN Idioma ON Usuario.Idioma = Idioma.ID_Idioma) WHERE (Usuario.Nombre_Usuario = '" & Nombre & "')"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class
