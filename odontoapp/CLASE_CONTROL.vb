Imports MySql.Data.MySqlClient

Public Class CLASE_CONTROL

    Implements CLASE_GENERAL.DML


#Region "Consultas"

    Public Shared xIdcontrol As Integer
    Public Shared xIdEmpleado As Integer
    Public Shared xIdTRegistro As Integer
    Public Shared xIdproceso As Integer

#End Region

#Region "Atributos"

    Private Idcontrol As Integer
    Private IdEmpleado As Integer
    Private IdTRegistro As Integer
    Private Idproceso As Integer
    Private Iddoctor As Integer
    Private fechaini As String
    Private fechafin As String
    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()
        Me.Idcontrol = 0
        Me.IdEmpleado = 0
        Me.IdTRegistro = 0
        Me.Idproceso = 0
        Me.Iddoctor = 0
        Me.fechaini = ""
        Me.fechafin = ""
        Me.ds = New DataSet
    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idcontrol() As Integer
        Get
            Return Me.Idcontrol
        End Get
        Set(ByVal Value As Integer)
            Me.Idcontrol = Value
        End Set
    End Property

    Public Property p_IdEmpleado() As Integer
        Get
            Return Me.IdEmpleado
        End Get
        Set(ByVal Value As Integer)
            Me.IdEmpleado = Value
        End Set
    End Property

    Public Property p_IdTRegistro() As Integer
        Get
            Return Me.IdTRegistro
        End Get
        Set(ByVal Value As Integer)
            Me.IdTRegistro = Value
        End Set
    End Property
    Public Property p_Idproceso() As Integer
        Get
            Return Me.Idproceso
        End Get
        Set(ByVal Value As Integer)
            Me.Idproceso = Value
        End Set
    End Property
    Public Property p_Iddoctor() As Integer
        Get
            Return Me.Iddoctor
        End Get
        Set(ByVal Value As Integer)
            Me.Iddoctor = Value
        End Set
    End Property
    Public Property p_fechaini() As String
        Get
            Return Me.fechaini
        End Get
        Set(ByVal Value As String)
            Me.fechaini = Value
        End Set
    End Property

    Public Property p_fechafin() As String
        Get
            Return Me.fechafin
        End Get
        Set(ByVal Value As String)
            Me.fechafin = Value
        End Set
    End Property

    Public ReadOnly Property p_ds() As DataSet
        Get
            Return Me.ds
        End Get
    End Property

#End Region


    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try
            CLASE_GENERAL.sql = "INSERT INTO control (Idempleado, Idtregistro, Idproceso) VALUES (" & Me.IdEmpleado & ", " & Me.IdTRegistro & ", " & Me.Idproceso & ")"
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


                Case "citasasignadasmodificadas"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONTROL.Idcontrol, TIPOREGISTRO.nomregistro, CONTROL.fecharegistro, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.nhclinica, CITAS.fecha, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), DATE_FORMAT(citas.horafin,'%h:%i:%s %p'), TIPOCONSULTA.nomconsulta FROM ((CONTROL INNER JOIN TIPOREGISTRO ON CONTROL.Idtregistro = TIPOREGISTRO.Idtregistro) INNER JOIN (CITAS INNER JOIN PACIENTES ON CITAS.Idpaciente = PACIENTES.Idpaciente) ON CONTROL.Idproceso = CITAS.Idcita) INNER JOIN TIPOCONSULTA ON CITAS.Idtconsulta = TIPOCONSULTA.IdTconsulta WHERE CONTROL.IdEmpleado = " & Me.IdEmpleado & " AND (CONTROL.Idtregistro = 1 OR CONTROL.Idtregistro = 3) AND ((DATE(CONTROL.fecharegistro) >= '" & Me.fechaini & "') AND (DATE(CONTROL.fecharegistro) <= '" & Me.fechafin & "')) AND CITAS.Iddoctor = " & Me.Iddoctor & " ORDER BY CONTROL.fecharegistro ASC "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "citasborradas"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONTROL.Idcontrol, TIPOREGISTRO.nomregistro, CONTROL.fecharegistro FROM CONTROL INNER JOIN TIPOREGISTRO ON CONTROL.Idtregistro = TIPOREGISTRO.Idtregistro WHERE CONTROL.IdEmpleado = " & Me.IdEmpleado & " AND (CONTROL.Idtregistro = 2 OR CONTROL.Idtregistro = 5) AND ((DATE(CONTROL.fecharegistro) >= '" & Me.fechaini & "') AND (DATE(CONTROL.fecharegistro) <= '" & Me.fechafin & "')) ORDER BY CONTROL.fecharegistro ASC "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "pacientes"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONTROL.Idcontrol, TIPOREGISTRO.nomregistro, CONTROL.fecharegistro,  PACIENTES.nombres_pac, PACIENTES.apellidos_pac, PACIENTES.nhclinica FROM PACIENTES INNER JOIN (CONTROL INNER JOIN TIPOREGISTRO ON CONTROL.Idtregistro = TIPOREGISTRO.Idtregistro) ON PACIENTES.Idpaciente = CONTROL.Idproceso WHERE CONTROL.IdEmpleado = " & Me.IdEmpleado & " AND (CONTROL.Idtregistro = 4 OR CONTROL.Idtregistro = 6 OR CONTROL.Idtregistro = 7) AND ((DATE(CONTROL.fecharegistro) >= '" & Me.fechaini & "') AND (DATE(CONTROL.fecharegistro) <= '" & Me.fechafin & "')) ORDER BY CONTROL.fecharegistro ASC "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informes"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONTROL.Idcontrol, TIPOREGISTRO.nomregistro, CONTROL.fecharegistro, TIPOINFORME.nomtinforme FROM (CONTROL INNER JOIN TIPOREGISTRO ON CONTROL.Idtregistro = TIPOREGISTRO.Idtregistro) INNER JOIN TIPOINFORME ON CONTROL.Idproceso = TIPOINFORME.IdTInforme WHERE CONTROL.IdEmpleado = " & Me.IdEmpleado & " AND CONTROL.Idtregistro = 8 AND ((DATE(CONTROL.fecharegistro) >= '" & Me.fechaini & "') AND (DATE(CONTROL.fecharegistro) <= '" & Me.fechafin & "')) ORDER BY CONTROL.fecharegistro ASC "


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "calendario"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONTROL.Idcontrol, TIPOREGISTRO.nomregistro, CONTROL.fecharegistro, CALENDARIO.fecha, DATE_FORMAT(CALENDARIO.horaini,'%h:%i:%s %p'), DATE_FORMAT(CALENDARIO.horafin,'%h:%i:%s %p'), CONTROLDIA.nomcontroldia FROM ((CONTROL INNER JOIN TIPOREGISTRO ON CONTROL.Idtregistro = TIPOREGISTRO.Idtregistro) INNER JOIN CALENDARIO ON CONTROL.Idproceso = CALENDARIO.Idcalendario) INNER JOIN CONTROLDIA ON CALENDARIO.Idcontroldia = CONTROLDIA.Idcontroldia WHERE CONTROL.IdEmpleado = " & Me.IdEmpleado & " AND CONTROL.Idtregistro = 9 AND ((DATE(CONTROL.fecharegistro) >= '" & Me.fechaini & "') AND (DATE(CONTROL.fecharegistro) <= '" & Me.fechafin & "')) AND CALENDARIO.Iddoctor = " & Me.Iddoctor & " ORDER BY CONTROL.fecharegistro ASC "


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
