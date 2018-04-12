Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports System.Data

Public Class CLASE_GENERAL_ACCESS

#Region "objetos de conexion"

    'Objetos de conexion y manupulacion de base de datos
    Public Shared acccon As OleDbConnection ' Objeto que nos permite hacer la conexion fisica con la base de datos
    Public Shared acccomando As OleDbCommand ' Objeto para ejecutar la consulta y la conexion
    Public Shared accda As OleDbDataAdapter ' Objeto enlace entre la base de datos y los objetos de coneccion
    Public Shared accdr As OleDbDataReader ' Objeto que nos permite leer la consulta
    Public Shared accds As DataSet 'Objeto de coleccion de la base de datos en modo desconectado
    Public Shared accdt As DataTable ' Almacena en forma desconectada el contenido de la consulta para manipularla
    Public Shared accdt2 As DataTable ' otro por si las moscas
    Public Shared accsql As String ' Lo utilizaremos para llenar la consulta SQL
    Public Shared accmensaje_error As String ' Para controlar los posibles errores del programa
    Public Shared accestado_conexion As Boolean ' Para verificar si se realizo la conexion o no.

    'Variables de datos
    Public Shared maxi As Integer ' Esta variable la utilizamos para que nos retorne el valor máximo de un Id de cualquier tabla, para el consecutivo

    'objetos de captura de configuracion Call Center
    Public Shared sFicINI As String
    Public Shared accRuta As String
    Public Shared accUsuario As String
    Public Shared accClave As String


#End Region

#Region "Funciones para iniciar terminar sesion base datos"

    Public Shared Function iniciar(ByVal mensaje As String, ByVal cadenacon As String) As Boolean
        'Control de exepcion de errores
        Try
            acccon = New OleDbConnection(cadenacon) ' El objeto recibe como parametro la cadena de conexion que nos permite trabajar con la BD
            acccon.Open()
            Return True
        Catch ex As OleDbException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function
    Public Shared Function terminar(ByVal mensaje As String) As Boolean

        Try

            acccon.Close() ' Cierra la base de datos y la conexion
            acccon = Nothing

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
            accRuta = mINI.IniGet(sFicINI, "Callcenter", "ruta")
            accUsuario = mINI.IniGet(sFicINI, "Callcenter", "Usuario")
            'accClave = Crypto.Desencriptar(mINI.IniGet(sFicINI, "Callcenter", "Clave"))

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
