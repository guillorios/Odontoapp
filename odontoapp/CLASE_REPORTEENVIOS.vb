Imports MySql.Data.MySqlClient

Public Class CLASE_REPORTEENVIOS

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdreporte As Integer
    Public Shared xfecha_reporte As String
    Public Shared xIdpaciente As Integer
    Public Shared xestado_reporte As Boolean
    Public Shared xtipo_reporte As Integer

#End Region

#Region "Atributos"

    Private Idreporte As Integer
    Private fecha_reporte As String
    Private Idpaciente As Integer
    Private estado_reporte As Boolean
    Private tipo_reporte As Integer

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idreporte = 0
        Me.fecha_reporte = ""
        Me.Idpaciente = 0
        Me.estado_reporte = False
        Me.tipo_reporte = 0

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region


#Region "Propiedades"

    Public Property p_Idreporte() As Integer
        Get
            Return Me.Idreporte
        End Get
        Set(ByVal Value As Integer)
            Me.Idreporte = Value
        End Set
    End Property

    Public Property p_fecha_reporte() As String
        Get
            Return Me.fecha_reporte
        End Get
        Set(ByVal Value As String)
            Me.fecha_reporte = Value
        End Set
    End Property

    Public Property p_Idpaciente() As Integer
        Get
            Return Me.Idpaciente
        End Get
        Set(ByVal Value As Integer)
            Me.Idpaciente = Value
        End Set
    End Property

    Public Property p_estado_reporte() As Boolean
        Get
            Return Me.estado_reporte
        End Get
        Set(ByVal Value As Boolean)
            Me.estado_reporte = Value
        End Set
    End Property

    Public Property p_tipo_reporte() As Integer
        Get
            Return Me.tipo_reporte
        End Get
        Set(ByVal Value As Integer)
            Me.tipo_reporte = Value
        End Set
    End Property

    Public ReadOnly Property p_ds() As DataSet
        Get
            Return Me.ds
        End Get
    End Property

#End Region

    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

        Try

            Select Case mensaje

                Case "Idreporte"

                    CLASE_GENERAL.sql = "DELETE FROM reporteenvios WHERE Idreporte = " & Me.Idreporte & " AND tipo_reporte = " & Me.tipo_reporte & ""

                Case "fecha"

                    CLASE_GENERAL.sql = "DELETE FROM reporteenvios WHERE fecha_reporte = '" & Me.fecha_reporte & "' AND tipo_reporte = " & Me.tipo_reporte & ""

            End Select


            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            Return True

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.reporteenvios (Idreporte, Idpaciente, estado_reporte, tipo_reporte ) " _
            & "VALUES (" & Me.Idreporte & ", " & Me.Idpaciente & ", " & Me.estado_reporte & ", " & Me.tipo_reporte & ")"

            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try


    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Modificar

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar

        Try

            Select Case mensaje


                Case "informes"

                    CLASE_GENERAL.xdt = New DataTable
                    'CLASE_GENERAL.sql = "SELECT CONTROL.Idcontrol, TIPOREGISTRO.nomregistro, CONTROL.fecharegistro, TIPOINFORME.nomtinforme FROM (CONTROL INNER JOIN TIPOREGISTRO ON CONTROL.Idtregistro = TIPOREGISTRO.Idtregistro) INNER JOIN TIPOINFORME ON CONTROL.Idproceso = TIPOINFORME.IdTInforme WHERE CONTROL.IdEmpleado = " & Me.IdEmpleado & " AND CONTROL.Idtregistro = 8 AND ((DATE(CONTROL.fecharegistro) >= '" & Me.fechaini & "') AND (DATE(CONTROL.fecharegistro) <= '" & Me.fechafin & "')) ORDER BY CONTROL.fecharegistro ASC "


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

               

            End Select

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try 'cierra la sentencia


    End Function
End Class
