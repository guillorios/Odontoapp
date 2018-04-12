Imports MySql.Data.MySqlClient

Public Class CLASE_CITAS

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdcita As Integer
    Public Shared xfecha As String
    Public Shared xfecha2 As String
    Public Shared xhoraini As String
    Public Shared xhoraini2 As TimeSpan
    Public Shared xhorafin As String
    Public Shared xhorafin2 As TimeSpan
    Public Shared xIdtconsulta As Integer
    Public Shared xIdpaciente As Integer
    Public Shared xIddoctor As Integer
    Public Shared xcancelacion As String
    Public Shared xasistencia As String
    Public Shared xnotacita As String
    Public Shared xIdunidad As Integer

#End Region

#Region "Atributos"

    Private Idcita As Integer
    Private fecha As String
    Private fecha2 As String
    Private horaini As String
    Private horafin As String
    Private Idtconsulta As Integer
    Private Idpaciente As Integer
    Private Iddoctor As Integer
    Private cancelacion As String
    Private asistencia As String
    Private notacita As String
    Private Idunidad As Integer

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Idcita = 0
        Me.fecha = ""
        Me.fecha2 = ""
        Me.horaini = ""
        Me.horafin = ""
        Me.Idtconsulta = 0
        Me.Idpaciente = 0
        Me.Iddoctor = 0
        Me.cancelacion = ""
        Me.asistencia = ""
        Me.notacita = ""
        Me.Idunidad = 1
        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idcita() As Integer
        Get
            Return Me.Idcita
        End Get
        Set(ByVal Value As Integer)
            Me.Idcita = Value
        End Set
    End Property
    Public Property p_fecha() As String
        Get
            Return Me.fecha
        End Get
        Set(ByVal Value As String)
            Me.fecha = Value
        End Set
    End Property
    Public Property p_fecha2() As String
        Get
            Return Me.fecha2
        End Get
        Set(ByVal Value As String)
            Me.fecha2 = Value
        End Set
    End Property
    Public Property p_horaini() As String
        Get
            Return Me.horaini
        End Get
        Set(ByVal Value As String)
            Me.horaini = Value
        End Set
    End Property

    Public Property p_horafin() As String
        Get
            Return Me.horafin
        End Get
        Set(ByVal Value As String)
            Me.horafin = Value
        End Set
    End Property

    Public Property p_Idtconsulta() As Integer
        Get
            Return Me.Idtconsulta
        End Get
        Set(ByVal Value As Integer)
            Me.Idtconsulta = Value
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
    Public Property p_Iddoctor() As Integer
        Get
            Return Me.Iddoctor
        End Get
        Set(ByVal Value As Integer)
            Me.Iddoctor = Value
        End Set
    End Property
    Public Property p_cancelacion() As String
        Get
            Return Me.cancelacion
        End Get
        Set(ByVal Value As String)
            Me.cancelacion = Value
        End Set
    End Property
    Public Property p_asistencia() As String
        Get
            Return Me.asistencia
        End Get
        Set(ByVal Value As String)
            Me.asistencia = Value
        End Set
    End Property
    Public Property p_notacita() As String
        Get
            Return Me.notacita
        End Get
        Set(ByVal Value As String)
            Me.notacita = Value
        End Set
    End Property
    Public Property p_Idunidad() As Integer
        Get
            Return Me.Idunidad
        End Get
        Set(ByVal Value As Integer)
            Me.Idunidad = Value
        End Set
    End Property

    Public ReadOnly Property p_ds() As DataSet
        Get
            Return Me.ds
        End Get
    End Property

#End Region

    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Eliminar

        Try

            CLASE_GENERAL.sql = "DELETE FROM citas WHERE Idcita = " & Me.Idcita & ""
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

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Insertar

        Try

            CLASE_GENERAL.sql = "INSERT INTO citas(Idcita, fecha, horaini, horafin, Idtconsulta, Idpaciente, Iddoctor, cancelacion, asistencia, notacita, Idunidad) VALUES  (" & Me.Idcita & ", '" & Me.fecha & "', '" & Me.horaini & "', '" & Me.horafin & "', " & Me.Idtconsulta & ", " & Me.Idpaciente & ", " & Me.Iddoctor & ", '" & Me.cancelacion & "', '" & Me.asistencia & "', '" & Me.notacita & "', " & Me.Idunidad & ")"
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

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Modificar

        Try

            CLASE_GENERAL.sql = "UPDATE citas SET fecha = '" & Me.fecha & "', horaini = '" & Me.horaini & "', horafin = '" & Me.horafin & "', Idtconsulta = " & Me.Idtconsulta & ", Idpaciente = " & Me.Idpaciente & ", Iddoctor = " & Me.Iddoctor & ", cancelacion = '" & Me.cancelacion & "', asistencia = '" & Me.asistencia & "', notacita = '" & Me.notacita & "', Idunidad = " & Me.Idunidad & " WHERE Idcita = " & Me.Idcita & ""
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

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Seleccionar

        Try

            Select Case mensaje

                Case "dia"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, citas.Idcita, citas.fecha, citas.horaini, citas.horafin, citas.IdTconsulta, citas.cancelacion, citas.asistencia, citas.Idunidad FROM pacientes INNER JOIN citas ON pacientes.Idpaciente = citas.Idpaciente WHERE fecha = '" & Me.fecha & "' AND Iddoctor = " & Me.Iddoctor & ""
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.sql, CLASE_GENERAL.xcon) 'llena el adaptador con el select enviado o el que llega

                    If CLASE_GENERAL.xcon.State = Data.ConnectionState.Closed Then CLASE_GENERAL.xcon.Open()
                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt)

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "cita"

                    CLASE_GENERAL.sql = "SELECT * FROM citas where Idcita = '" & Me.Idcita & "' "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdcita = CLASE_GENERAL.xdr("Idcita")
                        xfecha = CLASE_GENERAL.xdr("fecha")
                        xhoraini = Convert.ToString(CLASE_GENERAL.xdr("horaini"))
                        xhoraini2 = CLASE_GENERAL.xdr("horaini")
                        xhorafin = Convert.ToString(CLASE_GENERAL.xdr("horafin"))
                        xhorafin2 = CLASE_GENERAL.xdr("horafin")
                        xIdtconsulta = CLASE_GENERAL.xdr("Idtconsulta")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xIddoctor = CLASE_GENERAL.xdr("Iddoctor")
                        xcancelacion = CLASE_GENERAL.xdr("cancelacion")
                        xasistencia = CLASE_GENERAL.xdr("asistencia")
                        xnotacita = CLASE_GENERAL.xdr("notacita")
                        xIdunidad = CLASE_GENERAL.xdr("Idunidad")

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitasxpaciente"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT citas.fecha, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), DATE_FORMAT(citas.horafin,'%h:%i:%s %p'), tipoconsulta.nomconsulta, if(cancelacion=1,'CANCELADA','CONFIRMADA'), if(asistencia=1,'SI','N0') FROM (tipoconsulta INNER JOIN (pacientes INNER JOIN citas ON pacientes.Idpaciente = citas.Idpaciente) ON tipoconsulta.IdTconsulta = citas.Idtconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE citas.Idpaciente =" & Me.Idpaciente & " AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.fecha ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitasxdia"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.nhclinica, contactos.telcasa_con, contactos.cel_con, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), DATE_FORMAT(citas.horafin,'%h:%i:%s %p'), tipoconsulta.nomconsulta FROM contactos INNER JOIN ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) ON contactos.IdUsuario = pacientes.Idpaciente WHERE citas.fecha = '" & Me.fecha & "' AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitasxdiabrackets"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.nhclinica, contactos.telcasa_con, contactos.cel_con, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), DATE_FORMAT(citas.horafin,'%h:%i:%s %p'), tipoconsulta.nomconsulta FROM contactos INNER JOIN ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) ON contactos.IdUsuario = pacientes.Idpaciente WHERE citas.fecha = '" & Me.fecha & "' AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND citas.idtconsulta = 1  ORDER BY citas.horaini "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitasfuturas"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT citas.fecha, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), DATE_FORMAT(citas.horafin,'%h:%i:%s %p'), tipoconsulta.nomconsulta FROM (tipoconsulta INNER JOIN (pacientes INNER JOIN citas ON pacientes.Idpaciente = citas.Idpaciente) ON tipoconsulta.IdTconsulta = citas.Idtconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE citas.fecha > '" & Me.fecha & "' AND citas.Idpaciente =" & Me.Idpaciente & " AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.fecha, citas.horaini  ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdS.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "proximacita"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT citas.fecha as FECHA, DATE_FORMAT(citas.horaini,'%h:%i %p') as HORAINI, DATE_FORMAT(citas.horafin,'%h:%i %p') as HORAFIN, tipoconsulta.nomconsulta as CONSULTA FROM (tipoconsulta INNER JOIN (pacientes INNER JOIN citas ON pacientes.Idpaciente = citas.Idpaciente) ON tipoconsulta.IdTconsulta = citas.Idtconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE citas.fecha > '" & Me.fecha & "' AND citas.Idpaciente =" & Me.Idpaciente & " AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 limit 1"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdS.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitassinasistir"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.nhclinica, pacientes.residencia_pac, contactos.telcasa_con, contactos.cel_con, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), DATE_FORMAT(citas.horafin,'%h:%i:%s %p'), tipoconsulta.nomconsulta FROM ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE citas.fecha = '" & Me.fecha & "' AND citas.asistencia= '0' AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitassinasistirconfecha"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.nhclinica, pacientes.residencia_pac, contactos.telcasa_con, contactos.cel_con, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), DATE_FORMAT(citas.horafin,'%h:%i:%s %p'), tipoconsulta.nomconsulta FROM ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE DATE(citas.fecha) BETWEEN '" & Me.fecha & "' AND '" & Me.fecha2 & "' AND citas.asistencia= '0' AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitasdiasiguiente"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.nombres_pac, pacientes.apellidos_pac, pacientes.residencia_pac, pacientes.nhclinica, contactos.telcasa_con, contactos.email_con, contactos.cel_con, citas.horaini, citas.horafin, tipoconsulta.nomconsulta FROM contactos INNER JOIN ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) ON contactos.IdUsuario = pacientes.Idpaciente WHERE citas.fecha = ADDDATE('" & Me.fecha & "',1) AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitassinasistirhoy"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.nombres_pac, pacientes.apellidos_pac, pacientes.residencia_pac, pacientes.nhclinica, contactos.telcasa_con, contactos.email_con, contactos.cel_con, citas.horaini, citas.horafin, tipoconsulta.nomconsulta FROM ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE citas.fecha = '" & Me.fecha & "' AND citas.asistencia= '0' AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "informecitasmensajes"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, contactos.email_con, citas.fecha, citas.horaini, citas.horafin, tipoconsulta.nomconsulta FROM contactos INNER JOIN ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) ON contactos.IdUsuario = pacientes.Idpaciente WHERE citas.fecha >= '" & Me.fecha & "' AND citas.fecha <= '" & Me.fecha2 & "'  AND citas.asistencia= '0' AND citas.cancelacion= '0' AND Iddoctor = " & Me.Iddoctor & " AND POSITION('@' in contactos.email_con)  <> 0 AND contactos.email_con <> 'notiene@' AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitasSMS"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, operadorcel.nom_oper, operadorcel.dominio_oper, contactos.email_con, citas.fecha, citas.horaini, citas.horafin, tipoconsulta.nomconsulta FROM contactos INNER JOIN ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) ON contactos.IdUsuario = pacientes.Idpaciente INNER JOIN orthosoft.operadorcel ON (pacientes.Idoperador = operadorcel.Idoperador) WHERE citas.fecha >= '" & Me.fecha & "' AND citas.fecha <= '" & Me.fecha2 & "'  AND citas.asistencia= '0' AND citas.cancelacion= '0' AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitassinasistirmensajes"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, contactos.email_con, citas.fecha, citas.horaini, citas.horafin, tipoconsulta.nomconsulta FROM ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE citas.fecha >= '" & Me.fecha & "' AND citas.fecha <= '" & Me.fecha2 & "' AND citas.asistencia= '0' AND citas.cancelacion= '0' AND Iddoctor = " & Me.Iddoctor & " AND POSITION('@' in contactos.email_con) <> 0 AND contactos.email_con <> 'notiene@' AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini "
                    '

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informecitassinasistirSMS"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, operadorcel.nom_oper, operadorcel.dominio_oper, contactos.email_con, citas.fecha, citas.horaini, citas.horafin, tipoconsulta.nomconsulta FROM contactos INNER JOIN ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) ON contactos.IdUsuario = pacientes.Idpaciente INNER JOIN orthosoft.operadorcel ON (pacientes.Idoperador = operadorcel.Idoperador) WHERE citas.fecha >= '" & Me.fecha & "' AND citas.fecha <= '" & Me.fecha2 & "' AND citas.asistencia= '0' AND citas.cancelacion= '0' AND Iddoctor = " & Me.Iddoctor & " AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 ORDER BY citas.horaini "
                    
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "imprimircitapaciente"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT citas.fecha, DATE_FORMAT(citas.horaini,'%h:%i:%s %p'), CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, CONCAT(doctores.nombres_doc,' ', doctores.apellidos_doc) as Doctores, tipoconsulta.nomconsulta, citas.notacita FROM ((citas INNER JOIN pacientes ON citas.Idpaciente = pacientes.Idpaciente) INNER JOIN tipoconsulta ON citas.Idtconsulta = tipoconsulta.IdTconsulta) INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario INNER JOIN doctores ON citas.Iddoctor = doctores.Iddoctor WHERE citas.idcita = '" & Me.Idcita & "' AND contactos.IdTUsuario= 1 AND contactos.IdTTutor=5"


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\pruebas\dataset.xml", XmlWriteMode.WriteSchema)

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
