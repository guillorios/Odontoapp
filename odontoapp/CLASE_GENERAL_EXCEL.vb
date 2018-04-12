Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports System.Data

Public Class CLASE_GENERAL_EXCEL

#Region "objetos de conexion"

    'Objetos de conexion y manupulacion de base de datos
    Public Shared excon As OleDbConnection ' Objeto que nos permite hacer la conexion fisica con la base de datos
    Public Shared excomando As OleDbCommand ' Objeto para ejecutar la consulta y la conexion
    Public Shared exda As OleDbDataAdapter ' Objeto enlace entre la base de datos y los objetos de coneccion
    Public Shared exdr As OleDbDataReader ' Objeto que nos permite leer la consulta
    Public Shared exds As DataSet 'Objeto de coleccion de la base de datos en modo desconectado
    Public Shared exdt As DataTable ' Almacena en forma desconectada el contenido de la consulta para manipularla
    Public Shared exdt2 As DataTable ' otro por si las moscas
    Public Shared exsql As String ' Lo utilizaremos para llenar la consulta SQL
    Public Shared exmensaje_error As String ' Para controlar los posibles errores del programa
    Public Shared exestado_conexion As Boolean ' Para verificar si se realizo la conexion o no.

    'Variables de datos
    Public Shared maxi As Integer ' Esta variable la utilizamos para que nos retorne el valor máximo de un Id de cualquier tabla, para el consecutivo


#End Region

#Region "Funciones para iniciar terminar sesion base datos"
    Public Shared Function iniciar(ByVal mensaje As String, ByVal cadenacon As String) As Boolean
        'Control de exepcion de errores
        Try
            excon = New OleDbConnection(cadenacon) ' El objeto recibe como parametro la cadena de conexion que nos permite trabajar con la BD
            excon.Open()
            Return True
        Catch ex As OleDbException
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function
    Public Shared Function terminar(ByVal mensaje As String) As Boolean
        Try

            excon.Close() ' Cierra la base de datos y la conexion
            excon = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try
    End Function

#End Region

#Region "Selecionar tabla"

    Public Sub seleccionar_tabla(ByVal mensaje As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        exdt = New DataTable

        exsql = "SELECT Id1, apellidos, nombres, residencia, oficina, tel_res, tel_of, referido, ocupacion, ID, notas, NO_AFILIACION, FECHA_ING, FECHA_NAC, SEXO FROM [T_PACIENTES$]"
        exda = New OleDbDataAdapter(exsql, excon) 'llena el adaptador con el select enviado o el que llega

        Try 'sentencia para el manejo de errores
            If excon.State = Data.ConnectionState.Closed Then excon.Open()
            exda.Fill(exdt)

            exda.Dispose()
            exda = Nothing

        Catch ex As OleDbException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

#End Region

#Region "Operaciones DML"
    Public Interface DML
        Function Seleccionar(ByVal mensaje As String) As Boolean
    End Interface
#End Region

End Class
