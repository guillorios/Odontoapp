Imports MySql.Data.MySqlClient

Public Class CLASE_HORARIOS

    Implements CLASE_GENERAL.DML


#Region "Consultas"

    Public Shared xIdhorario As Integer
    Public Shared xIddoctor As Integer
    Public Shared xIdunidad As Integer
    Public Shared xIdconsultorio As Integer
    Public Shared xhora_ini As String
    Public Shared xhora_ini2 As TimeSpan
    Public Shared xhora_fin As String
    Public Shared xhora_fin2 As TimeSpan
    Public Shared xdias_horario As String
    Public Shared xfecha_horario As String
    Public Shared xIdtipohorario As Integer
    Public Shared xobservacion_horario As String

#End Region

#Region "Atributos"

    Private Idhorario As Integer
    Private Iddoctor As Integer
    Private Idunidad As Integer
    Private Idconsultorio As Integer
    Private hora_ini As String
    Private hora_fin As String
    Private dias_horario As String
    Private fecha_horario As String
    Private Idtipohorario As Integer
    Private observacion_horario As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idhorario = 0
        Me.Iddoctor = 0
        Me.Idunidad = 1
        Me.Idconsultorio = 0
        Me.hora_ini = ""
        Me.hora_fin = ""
        Me.dias_horario = ""
        Me.fecha_horario = ""
        Me.Idtipohorario = 0
        Me.observacion_horario = ""

        Me.ds = New DataSet

    End Sub

#End Region
   
#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idhorario() As Integer
        Get
            Return Idhorario
        End Get
        Set(ByVal value As Integer)
            Idhorario = value
        End Set
    End Property

    Public Property p_Iddoctor() As Integer
        Get
            Return Iddoctor
        End Get
        Set(ByVal value As Integer)
            Iddoctor = value
        End Set
    End Property

    Public Property p_Idunidad() As Integer
        Get
            Return Idunidad
        End Get
        Set(ByVal value As Integer)
            Idunidad = value
        End Set
    End Property

    Public Property p_Idconsultorio() As Integer
        Get
            Return Idconsultorio
        End Get
        Set(ByVal value As Integer)
            Idconsultorio = value
        End Set
    End Property

    Public Property p_hora_ini() As String
        Get
            Return hora_ini
        End Get
        Set(ByVal value As String)
            hora_ini = value
        End Set
    End Property

    Public Property p_hora_fin() As String
        Get
            Return hora_fin
        End Get
        Set(ByVal value As String)
            hora_fin = value
        End Set
    End Property

    Public Property p_dias_horario() As String
        Get
            Return dias_horario
        End Get
        Set(ByVal value As String)
            dias_horario = value
        End Set
    End Property

    Public Property p_fecha_horario() As String
        Get
            Return fecha_horario
        End Get
        Set(ByVal value As String)
            fecha_horario = value
        End Set
    End Property

    Public Property p_Idtipohorario() As Integer
        Get
            Return Idtipohorario
        End Get
        Set(ByVal value As Integer)
            Idtipohorario = value
        End Set
    End Property

    Public Property p_observacion_horario() As String
        Get
            Return observacion_horario
        End Get
        Set(ByVal value As String)
            observacion_horario = value
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

            CLASE_GENERAL.sql = "DELETE FROM horarios WHERE Idhorario = " & Me.Idhorario & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.horarios (Idhorario, Iddoctor, Idunidad, Idconsultorio, hora_ini, hora_fin, dias_horario, fecha_horario, Idtipohorario, observacion_horario) " _
            & "VALUES (" & Me.Idhorario & ", " & Me.Iddoctor & ", " & Me.Idunidad & ", " & Me.Idconsultorio & ", '" & Me.hora_ini & "', '" & Me.hora_fin & "', '" & Me.dias_horario & "', '" & Me.fecha_horario & "', " & Me.Idtipohorario & ", '" & Me.observacion_horario & "')"
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

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Modificar

        Try

            CLASE_GENERAL.sql = "UPDATE orthosoft.horarios SET Idhorario = " & Me.Idhorario & " , Iddoctor = " & Me.Iddoctor & " , Idunidad = " & Me.Idunidad & " , Idconsultorio = " & Me.Idconsultorio & " , hora_ini = '" & Me.hora_ini & "' , hora_fin = '" & Me.hora_fin & "' , dias_horario = '" & Me.dias_horario & "' , fecha_horario = '" & Me.fecha_horario & "' , Idtipohorario = " & Me.Idtipohorario & " , observacion_horario = '" & Me.observacion_horario & "' WHERE Idhorario = " & Me.Idhorario & " "
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

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar

        Try

            Select Case mensaje

                Case "tabla"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT Idhorario, Iddoctor, Idunidad, Idconsultorio, hora_ini, hora_fin, dias_horario, fecha_horario, Idtipohorario, observacion_horario FROM Orthosoft.horarios"
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\horarios.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idhorario, Iddoctor, Idunidad, Idconsultorio, hora_ini, hora_fin, dias_horario, fecha_horario, Idtipohorario, observacion_horario FROM Orthosoft.horarios WHERE Idhorario = " & Me.Idhorario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdhorario = CLASE_GENERAL.xdr("Idhorario")
                        xIddoctor = CLASE_GENERAL.xdr("Iddoctor")
                        xIdunidad = CLASE_GENERAL.xdr("Idunidad")
                        xIdconsultorio = CLASE_GENERAL.xdr("Idconsultorio ")
                        xhora_ini = Convert.ToString(CLASE_GENERAL.xdr("hora_ini"))
                        xhora_ini2 = CLASE_GENERAL.xdr("hora_ini2")
                        xhora_fin = Convert.ToString(CLASE_GENERAL.xdr("hora_fin"))
                        xhora_fin2 = (CLASE_GENERAL.xdr("hora_fin2"))
                        xdias_horario = CLASE_GENERAL.xdr("dias_horario")
                        xfecha_horario = CLASE_GENERAL.xdr("fecha_horario")
                        xIdtipohorario = CLASE_GENERAL.xdr("Idtipohorario")
                        xobservacion_horario = CLASE_GENERAL.xdr("observacion_horario")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

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
