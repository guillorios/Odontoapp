Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports System.Data

Public Class CLASE_GENERAL_FOX

#Region "objetos de conexion"

    'Objetos de conexion y manupulacion de base de datos
    Public Shared foxcon As OleDbConnection ' Objeto que nos permite hacer la conexion fisica con la base de datos
    Public Shared foxcomando As OleDbCommand ' Objeto para ejecutar la consulta y la conexion
    Public Shared foxda As OleDbDataAdapter ' Objeto enlace entre la base de datos y los objetos de coneccion
    Public Shared foxdr As OleDbDataReader ' Objeto que nos permite leer la consulta
    Public Shared foxds As DataSet 'Objeto de coleccion de la base de datos en modo desconectado
    Public Shared foxdt As DataTable ' Almacena en forma desconectada el contenido de la consulta para manipularla
    Public Shared foxdt2 As DataTable ' otro por si las moscas
    Public Shared foxsql As String ' Lo utilizaremos para llenar la consulta SQL
    Public Shared foxmensaje_error As String ' Para controlar los posibles errores del programa
    Public Shared foxestado_conexion As Boolean ' Para verificar si se realizo la conexion o no.

    'Variables de datos
    Public Shared maxi As Integer ' Esta variable la utilizamos para que nos retorne el valor máximo de un Id de cualquier tabla, para el consecutivo

    'objetos de captura de configuracion Call Center
    Public Shared sFicINI As String
    Public Shared foxRuta As String
    Public Shared foxUsuario As String
    Public Shared foxClave As String


#End Region

#Region "Funciones para iniciar terminar sesion base datos"
    Public Shared Function iniciar(ByVal mensaje As String, ByVal cadenacon As String) As Boolean
        'Control de exepcion de errores
        Try
            foxcon = New OleDbConnection(cadenacon) ' El objeto recibe como parametro la cadena de conexion que nos permite trabajar con la BD
            foxcon.Open()
            Return True
        Catch ex As OleDbException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function
    Public Shared Function terminar(ByVal mensaje As String) As Boolean
        Try

            foxcon.Close() ' Cierra la base de datos y la conexion
            foxcon = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try
    End Function

    Public Shared Function configuracion(ByVal mensaje As String) As Boolean

        Dim mINI As New cIniArray
        'Control de exepcion de errores

        Try

            sFicINI = Application.StartupPath & "\config.ini"
            foxRuta = mINI.IniGet(sFicINI, "Callcenter", "ruta")
            foxUsuario = mINI.IniGet(sFicINI, "Callcenter", "Usuario")
            'foxClave = Crypto.Desencriptar(mINI.IniGet(sFicINI, "Callcenter", "Clave"))

            'Opciones de Inicio

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

#End Region

#Region "Operaciones DML"
    Public Interface DML
        Function Insertar(ByVal mensaje As String) As Boolean
        Function Eliminar(ByVal mensaje As String) As Boolean
        Function Seleccionar(ByVal mensaje As String) As Boolean
        Function Modificar(ByVal mensaje As String) As Boolean
    End Interface
#End Region

End Class
