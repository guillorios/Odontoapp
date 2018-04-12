Imports MySql.Data.MySqlClient

Public Class CLASE_PACIENTES

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdpaciente As Integer
    Public Shared xapellidos_pac As String
    Public Shared xnombres_pac As String
    Public Shared xresidencia_pac As String
    Public Shared xestadocivil_pac As Integer
    Public Shared xoficina_pac As String
    Public Shared xfecingreso_pac As String
    Public Shared xocupacion_pac As String
    Public Shared xreferidopor_pac As String
    Public Shared xfecnac_pac As String
    Public Shared xlugarnac_pac As String

    Public Shared xzona_pac As Integer
    Public Shared xmunicipio_pac As String
    Public Shared xdep_pac As String
    Public Shared xrh_pac As String

    Public Shared xtipodoc_pac As String
    Public Shared xnumdoc_pac As String
    Public Shared xdedoc_pac As String
    Public Shared xsexo_pac As String
    Public Shared xIdentidad As Integer
    Public Shared xnhclinica As String
    Public Shared xIdoperador As Integer
    Public Shared xIdestado_pac As Integer
    Public Shared xIdconsultorio As Integer

#End Region

#Region "Atributos"

    Private Idpaciente As Integer
    Private apellidos_pac As String
    Private nombres_pac As String
    Private residencia_pac As String
    Private estadocivil_pac As Integer
    Private oficina_pac As String
    Private fecingreso_pac As String
    Private ocupacion_pac As String
    Private referidopor_pac As String
    Private fecnac_pac As String
    Private lugarnac_pac As String

    Private zona_pac As Integer
    Private municipio_pac As String
    Private dep_pac As String
    Private rh_pac As String
   
    Private tipodoc_pac As String
    Private numdoc_pac As String
    Private dedoc_pac As String
    Private sexo_pac As String
    Private Identidad As Integer
    Private nhclinica As String
    Private Idoperador As Integer
    Private Idestado_pac As Integer
    Private Idconsultorio As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Idpaciente = 0
        Me.apellidos_pac = ""
        Me.nombres_pac = ""
        Me.residencia_pac = ""
        Me.estadocivil_pac = 0
        Me.oficina_pac = ""
        Me.fecingreso_pac = ""
        Me.ocupacion_pac = ""
        Me.referidopor_pac = ""
        Me.fecnac_pac = ""
        Me.lugarnac_pac = ""

        Me.zona_pac = 0
        Me.municipio_pac = ""
        Me.dep_pac = ""
        Me.rh_pac = ""

        Me.tipodoc_pac = ""
        Me.numdoc_pac = ""
        Me.dedoc_pac = ""
        Me.sexo_pac = ""
        Me.Identidad = 0
        Me.nhclinica = ""
        Me.Idoperador = 0
        Me.Idestado_pac = 0
        Me.Idconsultorio = 0

        Me.dt = New DataTable

    End Sub
#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_IdPaciente() As Integer
        Get
            Return Me.Idpaciente
        End Get
        Set(ByVal Value As Integer)
            Me.Idpaciente = Value
        End Set
    End Property

    Public Property p_apellidos_pac() As String
        Get
            Return Me.apellidos_pac
        End Get
        Set(ByVal Value As String)
            Me.apellidos_pac = Value
        End Set
    End Property

    Public Property p_nombres_pac() As String
        Get
            Return Me.nombres_pac
        End Get
        Set(ByVal Value As String)
            Me.nombres_pac = Value
        End Set
    End Property

    Public Property p_residencia_pac() As String
        Get
            Return Me.residencia_pac
        End Get
        Set(ByVal Value As String)
            Me.residencia_pac = Value
        End Set
    End Property

    Public Property p_estadocivil_pac() As Integer
        Get
            Return Me.estadocivil_pac
        End Get
        Set(ByVal Value As Integer)
            Me.estadocivil_pac = Value
        End Set
    End Property

    Public Property p_oficina_pac() As String
        Get
            Return Me.oficina_pac
        End Get
        Set(ByVal Value As String)
            Me.oficina_pac = Value
        End Set
    End Property
    Public Property p_fecingreso_pac() As String
        Get
            Return Me.fecingreso_pac
        End Get
        Set(ByVal Value As String)
            Me.fecingreso_pac = Value
        End Set
    End Property

    Public Property p_ocupacion_pac() As String
        Get
            Return Me.ocupacion_pac
        End Get
        Set(ByVal Value As String)
            Me.ocupacion_pac = Value
        End Set
    End Property

    Public Property p_referidopor_pac() As String
        Get
            Return Me.referidopor_pac
        End Get
        Set(ByVal Value As String)
            Me.referidopor_pac = Value
        End Set
    End Property

    Public Property p_fecnac_pac() As String
        Get
            Return Me.fecnac_pac
        End Get
        Set(ByVal Value As String)
            Me.fecnac_pac = Value
        End Set
    End Property

    Public Property p_lugarnac_pac() As String
        Get
            Return Me.lugarnac_pac
        End Get
        Set(ByVal Value As String)
            Me.lugarnac_pac = Value
        End Set
    End Property

    Public Property p_zona_pac() As Integer
        Get
            Return Me.zona_pac
        End Get
        Set(ByVal Value As Integer)
            Me.zona_pac = Value
        End Set
    End Property

    Public Property p_municipio_pac() As String
        Get
            Return Me.municipio_pac
        End Get
        Set(ByVal Value As String)
            Me.municipio_pac = Value
        End Set
    End Property

    Public Property p_dep_pac() As String
        Get
            Return Me.dep_pac
        End Get
        Set(ByVal Value As String)
            Me.dep_pac = Value
        End Set
    End Property

    Public Property p_rh_pac() As String
        Get
            Return Me.rh_pac
        End Get
        Set(ByVal Value As String)
            Me.rh_pac = Value
        End Set
    End Property

    Public Property p_tipodoc_pac() As String
        Get
            Return Me.tipodoc_pac
        End Get
        Set(ByVal Value As String)
            Me.tipodoc_pac = Value
        End Set
    End Property

    Public Property p_numdoc_pac() As String
        Get
            Return Me.numdoc_pac
        End Get
        Set(ByVal Value As String)
            Me.numdoc_pac = Value
        End Set
    End Property

    Public Property p_dedoc_pac() As String
        Get
            Return Me.dedoc_pac
        End Get
        Set(ByVal Value As String)
            Me.dedoc_pac = Value
        End Set
    End Property

    Public Property p_sexo_pac() As String
        Get
            Return Me.sexo_pac
        End Get
        Set(ByVal Value As String)
            Me.sexo_pac = Value
        End Set
    End Property

    Public Property p_Identidad() As Integer
        Get
            Return Me.Identidad
        End Get
        Set(ByVal Value As Integer)
            Me.Identidad = Value
        End Set
    End Property

    Public Property p_nhclinica() As String
        Get
            Return Me.nhclinica
        End Get
        Set(ByVal Value As String)
            Me.nhclinica = Value
        End Set
    End Property

    Public Property p_Idoperador() As Integer
        Get
            Return Me.Idoperador
        End Get
        Set(ByVal Value As Integer)
            Me.Idoperador = Value
        End Set
    End Property

    Public Property p_Idestado_pac() As Integer
        Get
            Return Me.Idestado_pac
        End Get
        Set(ByVal Value As Integer)
            Me.Idestado_pac = Value
        End Set
    End Property

    Public Property p_Idconsultorio() As Integer
        Get
            Return Me.Idconsultorio
        End Get
        Set(ByVal Value As Integer)
            Me.Idconsultorio = Value
        End Set
    End Property

    Public ReadOnly Property p_dt() As DataTable
        Get
            Return Me.dt
        End Get
    End Property

#End Region


    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

        Try

            CLASE_GENERAL.sql = "DELETE FROM pacientes WHERE Idpaciente = " & Me.Idpaciente & ""
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

            CLASE_GENERAL.sql = "INSERT INTO pacientes (IdPaciente, apellidos_pac, nombres_pac, residencia_pac, estadocivil_pac, oficina_pac, fecingreso_pac, ocupacion_pac, referidopor_pac, fecnac_pac, lugarnac_pac, zona_pac, municipio_pac, dep_pac, rh_pac, tipodoc_pac, numdoc_pac, dedoc_pac, sexo_pac, Identidad, nhclinica, Idoperador, Idestado_pac, Idconsultorio) VALUES  " _
            & "(" & Me.Idpaciente & ",'" & Me.apellidos_pac & "', '" & Me.nombres_pac & "', '" & Me.residencia_pac & "', " & Me.estadocivil_pac & ", '" & Me.oficina_pac & "', '" & Me.fecingreso_pac & "', '" & Me.ocupacion_pac & "', '" & Me.referidopor_pac & "', '" & Me.fecnac_pac & "', '" & Me.lugarnac_pac & "', " & Me.zona_pac & ", '" & Me.municipio_pac & "', '" & Me.dep_pac & "', '" & Me.rh_pac & "', '" & Me.tipodoc_pac & "', " _
            & "'" & Me.numdoc_pac & "', '" & Me.dedoc_pac & "',  '" & Me.sexo_pac & "', " & Me.Identidad & ", '" & Me.nhclinica & "', " & Me.Idoperador & ", " & Me.Idestado_pac & ", " & Me.Idconsultorio & ")"

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

        Select Case mensaje

            Case "ingreso"

                Try
                    CLASE_GENERAL.sql = "UPDATE pacientes SET apellidos_pac = '" & Me.apellidos_pac & "', nombres_pac = '" & Me.nombres_pac & "', residencia_pac = '" & Me.residencia_pac & "', estadocivil_pac = " & Me.estadocivil_pac & ", oficina_pac = '" & Me.oficina_pac & "', fecingreso_pac = '" & Me.fecingreso_pac & "', " _
                    & "ocupacion_pac = '" & Me.ocupacion_pac & "', referidopor_pac = '" & Me.referidopor_pac & "', fecnac_pac = '" & Me.fecnac_pac & "', lugarnac_pac = '" & Me.lugarnac_pac & "', zona_pac = " & Me.zona_pac & ", municipio_pac = '" & Me.municipio_pac & "', dep_pac = '" & Me.dep_pac & "', rh_pac = '" & Me.rh_pac & "', " _
                    & "tipodoc_pac = '" & Me.tipodoc_pac & "', numdoc_pac = '" & Me.numdoc_pac & "', dedoc_pac = '" & Me.dedoc_pac & "', sexo_pac = '" & Me.sexo_pac & "', " _
                    & "Identidad = " & Me.Identidad & ", nhclinica = '" & Me.nhclinica & "', Idoperador = " & Me.Idoperador & ", Idestado_pac = " & Me.Idestado_pac & ", Idconsultorio = " & Me.Idconsultorio & " WHERE IdPaciente = " & Me.Idpaciente & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Catch ex As Exception
                    CLASE_GENERAL.mensaje_error = ex.Message
                    Return False
                End Try

            Case "bloqueo"

                Try
                    CLASE_GENERAL.sql = "UPDATE pacientes set Idestado_pac = " & Me.Idestado_pac & " where IdPaciente = " & Me.Idpaciente & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False
                End Try


        End Select

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar

        Try

            Dim fecha As String
            fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

            Select Case mensaje

                Case "pacientes"

                    CLASE_GENERAL.sql = "SELECT * FROM pacientes WHERE Idpaciente = " & Me.Idpaciente & " ORDER BY idpaciente ASC "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr


                        If CLASE_GENERAL.xdr("Idpaciente") Is DBNull.Value Then
                            xIdpaciente = ""
                        Else
                            xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        End If

                        If CLASE_GENERAL.xdr("apellidos_pac") Is DBNull.Value Then
                            xapellidos_pac = ""
                        Else
                            xapellidos_pac = CLASE_GENERAL.xdr("apellidos_pac")
                        End If

                        If CLASE_GENERAL.xdr("nombres_pac") Is DBNull.Value Then
                            xnombres_pac = ""
                        Else
                            xnombres_pac = CLASE_GENERAL.xdr("nombres_pac")
                        End If

                        If CLASE_GENERAL.xdr("residencia_pac") Is DBNull.Value Then
                            xresidencia_pac = ""
                        Else
                            xresidencia_pac = CLASE_GENERAL.xdr("residencia_pac")
                        End If

                        If CLASE_GENERAL.xdr("estadocivil_pac") Is DBNull.Value Then
                            xestadocivil_pac = 0
                        Else
                            xestadocivil_pac = CLASE_GENERAL.xdr("estadocivil_pac")
                        End If

                        If CLASE_GENERAL.xdr("oficina_pac") Is DBNull.Value Then
                            xoficina_pac = ""
                        Else
                            xoficina_pac = CLASE_GENERAL.xdr("oficina_pac")
                        End If

                        If CLASE_GENERAL.xdr("fecingreso_pac") Is DBNull.Value Then
                            xfecingreso_pac = Format(Date.Now, "yyyy-MM-dd")
                        Else
                            xfecingreso_pac = CLASE_GENERAL.xdr("fecingreso_pac")
                        End If

                        If CLASE_GENERAL.xdr("ocupacion_pac") Is DBNull.Value Then
                            xocupacion_pac = ""
                        Else
                            xocupacion_pac = CLASE_GENERAL.xdr("ocupacion_pac")
                        End If

                        If CLASE_GENERAL.xdr("referidopor_pac") Is DBNull.Value Then
                            xreferidopor_pac = ""
                        Else
                            xreferidopor_pac = CLASE_GENERAL.xdr("referidopor_pac")
                        End If

                        If CLASE_GENERAL.xdr("fecnac_pac") Is DBNull.Value Then
                            xfecnac_pac = Format(Date.Now, "yyyy-MM-dd")
                        Else
                            xfecnac_pac = CLASE_GENERAL.xdr("fecnac_pac")
                        End If

                        If CLASE_GENERAL.xdr("lugarnac_pac") Is DBNull.Value Then
                            xlugarnac_pac = ""
                        Else
                            xlugarnac_pac = CLASE_GENERAL.xdr("lugarnac_pac")
                        End If

                        If CLASE_GENERAL.xdr("zona_pac") Is DBNull.Value Then
                            xzona_pac = 0
                        Else
                            xzona_pac = CLASE_GENERAL.xdr("zona_pac")
                        End If

                        If CLASE_GENERAL.xdr("municipio_pac") Is DBNull.Value Then
                            xmunicipio_pac = ""
                        Else
                            xmunicipio_pac = CLASE_GENERAL.xdr("municipio_pac")
                        End If

                        If CLASE_GENERAL.xdr("dep_pac") Is DBNull.Value Then
                            xdep_pac = ""
                        Else
                            xdep_pac = CLASE_GENERAL.xdr("dep_pac")
                        End If

                        If CLASE_GENERAL.xdr("rh_pac") Is DBNull.Value Then
                            xrh_pac = ""
                        Else
                            xrh_pac = CLASE_GENERAL.xdr("rh_pac")
                        End If

                        If CLASE_GENERAL.xdr("tipodoc_pac") Is DBNull.Value Then
                            xtipodoc_pac = "2"
                        Else
                            xtipodoc_pac = CLASE_GENERAL.xdr("tipodoc_pac")
                        End If

                        If CLASE_GENERAL.xdr("numdoc_pac") Is DBNull.Value Then
                            xnumdoc_pac = ""
                        Else
                            xnumdoc_pac = CLASE_GENERAL.xdr("numdoc_pac")
                        End If

                        If CLASE_GENERAL.xdr("dedoc_pac") Is DBNull.Value Then
                            xdedoc_pac = ""
                        Else
                            xdedoc_pac = CLASE_GENERAL.xdr("dedoc_pac")
                        End If

                        If CLASE_GENERAL.xdr("sexo_pac") Is DBNull.Value Then
                            xsexo_pac = "M"
                        Else
                            xsexo_pac = CLASE_GENERAL.xdr("sexo_pac")
                        End If

                        If CLASE_GENERAL.xdr("Identidad") Is DBNull.Value Then
                            xIdentidad = 0
                        Else
                            xIdentidad = CLASE_GENERAL.xdr("Identidad")
                        End If

                        If CLASE_GENERAL.xdr("nhclinica") Is DBNull.Value Then
                            xnhclinica = ""
                        Else
                            xnhclinica = CLASE_GENERAL.xdr("nhclinica")
                        End If

                        If CLASE_GENERAL.xdr("Idoperador") Is DBNull.Value Then
                            xIdoperador = 0
                        Else
                            xIdoperador = CLASE_GENERAL.xdr("Idoperador")
                        End If

                        If CLASE_GENERAL.xdr("Idestado_pac") Is DBNull.Value Then
                            xIdestado_pac = 0
                        Else
                            xIdestado_pac = CLASE_GENERAL.xdr("Idestado_pac")
                        End If

                        If CLASE_GENERAL.xdr("Idconsultorio") Is DBNull.Value Then
                            xIdconsultorio = 0
                        Else
                            xIdconsultorio = CLASE_GENERAL.xdr("Idconsultorio")
                        End If


                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "solofechanacimiento"

                    CLASE_GENERAL.sql = "SELECT Idpaciente, fecnac_pac FROM pacientes WHERE Idpaciente = " & Me.Idpaciente & " ORDER BY idpaciente ASC "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr


                        If CLASE_GENERAL.xdr("Idpaciente") Is DBNull.Value Then
                            xIdpaciente = ""
                        Else
                            xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        End If


                        If CLASE_GENERAL.xdr("fecnac_pac") Is DBNull.Value Then
                            xfecnac_pac = Format(Date.Now, "yyyy-MM-dd")
                        Else
                            xfecnac_pac = CLASE_GENERAL.xdr("fecnac_pac")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "nombrepaciente"

                    CLASE_GENERAL.sql = "SELECT Idpaciente, pacientes.nombres_pac, pacientes.apellidos_pac FROM pacientes WHERE Idpaciente = " & Me.Idpaciente & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("Idpaciente") Is DBNull.Value Then
                            xIdpaciente = ""
                        Else
                            xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        End If

                        If CLASE_GENERAL.xdr("apellidos_pac") Is DBNull.Value Then
                            xapellidos_pac = ""
                        Else
                            xapellidos_pac = CLASE_GENERAL.xdr("apellidos_pac")
                        End If

                        If CLASE_GENERAL.xdr("nombres_pac") Is DBNull.Value Then
                            xnombres_pac = ""
                        Else
                            xnombres_pac = CLASE_GENERAL.xdr("nombres_pac")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "operadorcelular"

                    CLASE_GENERAL.sql = "SELECT Idpaciente, Idoperador FROM orthosoft.pacientes WHERE Idpaciente = " & Me.Idpaciente & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("Idpaciente") Is DBNull.Value Then
                            xIdpaciente = ""
                        Else
                            xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        End If

                        If CLASE_GENERAL.xdr("Idoperador") Is DBNull.Value Then
                            xIdoperador = 0
                        Else
                            xIdoperador = CLASE_GENERAL.xdr("Idoperador")
                        End If


                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informegeneral"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.nhclinica, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.residencia_pac, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) ORDER BY Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset1.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informegeneralpacientesbloqueados"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.nhclinica, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.residencia_pac, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND pacientes.Idestado_pac = 2 ORDER BY Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset1.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informecumpleañoshoy"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, pacientes.nombres_pac, pacientes.apellidos_pac, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.fecnac_pac, pacientes.residencia_pac, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND DAY(pacientes.fecnac_pac) = " & My.Forms.mdiOrthoSoft.CalOrthosoft.Day & " AND MONTH(pacientes.fecnac_pac)= " & My.Forms.mdiOrthoSoft.CalOrthosoft.Month & " ORDER BY Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset1.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informecumpleañoshoycallcenter"

                    CLASE_GENERAL.xdt = New DataTable
                    'CLASE_GENERAL.sql = "SELECT pacientes.nombres_pac, pacientes.apellidos_pac, pacientes.residencia_pac, pacientes.nhclinica, contactos.telcasa_con, contactos.email_con, pacientes.fecnac_pac, contactos.cel_con  FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND DAY(pacientes.fecnac_pac) = DAY(NOW()) AND MONTH(pacientes.fecnac_pac)=MONTH(NOW()) ORDER BY pacientes.nombres_pac ASC"
                    CLASE_GENERAL.sql = "SELECT pacientes.nombres_pac, pacientes.apellidos_pac, pacientes.residencia_pac, pacientes.nhclinica, contactos.telcasa_con, contactos.email_con, pacientes.fecnac_pac, contactos.cel_con  FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND DAY(pacientes.fecnac_pac) = " & My.Forms.mdiOrthoSoft.CalOrthosoft.Day & " AND MONTH(pacientes.fecnac_pac)=" & My.Forms.mdiOrthoSoft.CalOrthosoft.Month & " ORDER BY pacientes.nombres_pac ASC"
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset1.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informecumpleañoshoySMS"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.Idpaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, operadorcel.nom_oper, operadorcel.dominio_oper, contactos.email_con, pacientes.fecnac_pac FROM orthosoft.pacientes INNER JOIN orthosoft.operadorcel ON (pacientes.Idoperador = operadorcel.Idoperador) INNER JOIN orthosoft.contactos ON (pacientes.Idpaciente = contactos.IdUsuario) WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND DAY(pacientes.fecnac_pac) = " & My.Forms.mdiOrthoSoft.CalOrthosoft.Day & " AND MONTH(pacientes.fecnac_pac)=" & My.Forms.mdiOrthoSoft.CalOrthosoft.Month & " ORDER BY Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset1.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informecumpleañossemana"

                    CLASE_GENERAL.xdt = New DataTable
                    'CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.fecnac_pac, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE (contactos.IdTUsuario= 1) AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND (DAY(pacientes.fecnac_pac) BETWEEN  DAY(NOW()) AND DAY(ADDDATE(NOW(), 7))) AND (MONTH(pacientes.fecnac_pac)=MONTH(NOW()))  ORDER BY DAY(pacientes.fecnac_pac), YEAR(pacientes.fecnac_pac), MONTH(pacientes.fecnac_pac), Nombres ASC"
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.fecnac_pac, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE (contactos.IdTUsuario= 1) AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND (DAY(pacientes.fecnac_pac) BETWEEN  " & My.Forms.mdiOrthoSoft.CalOrthosoft.Day & " AND DAY(ADDDATE('" & fecha & "', 7))) AND MONTH(pacientes.fecnac_pac)=" & My.Forms.mdiOrthoSoft.CalOrthosoft.Month & "  ORDER BY DAY(pacientes.fecnac_pac), YEAR(pacientes.fecnac_pac), MONTH(pacientes.fecnac_pac), Nombres ASC"
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset2.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informecumpleañosmes"

                    CLASE_GENERAL.xdt = New DataTable
                    'CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.fecnac_pac, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND MONTH(pacientes.fecnac_pac)=MONTH(NOW()) ORDER BY DAY(pacientes.fecnac_pac), Nombres ASC"
                    CLASE_GENERAL.sql = "SELECT pacientes.IdPaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, pacientes.fecnac_pac, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND MONTH(pacientes.fecnac_pac)= " & My.Forms.mdiOrthoSoft.CalOrthosoft.Month & " ORDER BY DAY(pacientes.fecnac_pac), Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset3.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                    Return True

                Case "informepacientesemail"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.Idpaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, contactos.email_con FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND POSITION('@' in contactos.email_con)  <> 0 AND contactos.email_con <> 'notiene@' ORDER BY Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset3.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                    Return True

                Case "informepacientesSMS"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT pacientes.Idpaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, operadorcel.nom_oper, operadorcel.dominio_oper, contactos.email_con FROM orthosoft.pacientes INNER JOIN orthosoft.operadorcel ON (pacientes.Idoperador = operadorcel.Idoperador) INNER JOIN orthosoft.contactos ON (pacientes.Idpaciente = contactos.IdUsuario) WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) ORDER BY Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset3.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                    Return True

                Case "informecumpleañoshoymensajes"

                    CLASE_GENERAL.xdt = New DataTable
                    'CLASE_GENERAL.sql = "SELECT CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, contactos.email_con, pacientes.fecnac_pac  FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND POSITION('@' in contactos.email_con)  <> 0 AND DAY(pacientes.fecnac_pac) = DAY(NOW()) AND MONTH(pacientes.fecnac_pac)=MONTH(NOW()) AND contactos.email_con <> 'notiene@' ORDER BY Nombres ASC"
                    CLASE_GENERAL.sql = "SELECT pacientes.Idpaciente, CONCAT(pacientes.nombres_pac,' ', pacientes.apellidos_pac) as Nombres, contactos.telcasa_con, contactos.cel_con, contactos.email_con, pacientes.fecnac_pac  FROM pacientes INNER JOIN contactos ON pacientes.Idpaciente = contactos.IdUsuario WHERE contactos.IdTUsuario= 1 AND contactos.IdTTutor=5 AND (pacientes.Idestado_pac <> 2 AND pacientes.Idestado_pac <> 4) AND POSITION('@' in contactos.email_con)  <> 0 AND DAY(pacientes.fecnac_pac) = " & My.Forms.mdiOrthoSoft.CalOrthosoft.Day & " AND MONTH(pacientes.fecnac_pac)=" & My.Forms.mdiOrthoSoft.CalOrthosoft.Month & " AND contactos.email_con <> 'notiene@' ORDER BY Nombres ASC"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset1.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try


    End Function

End Class
