Imports MySql.Data.MySqlClient

Public Class CLASE_CONSULTORIO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdconsultorio As Integer
    Public Shared xrazonsocial_cons As String
    Public Shared xnit_cons As String
    Public Shared xdireccion_cons As String
    Public Shared xciudad_cons As String
    Public Shared xweb_cons As String
    Public Shared xemail_cons As String
    Public Shared xactividad_cons As String
    Public Shared xrtelegal_cons As String
    Public Shared xprofesionrlegal_cons As String
    Public Shared xdocumento_cons As String
    Public Shared xciudaddoc_cons As String
    Public Shared xciudadnacrlegal_cons As String
    Public Shared xtel1_cons As String
    Public Shared xtel2_cons As String
    Public Shared xcelular_cons As String
    Public Shared xfax_cons As String
    Public Shared xIddoctor As String
    Public Shared xhoraini As String
    Public Shared xhoraini2 As TimeSpan
    Public Shared xhorafin As String
    Public Shared xhorafin2 As TimeSpan
    Public Shared xrangocal As String
    Public Shared xtextopiecita As String
    Public Shared xtextopiercaja As String

    Public Shared xtextopiefactura As String
    Public Shared xtextodian As String
    Public Shared xtopecita As Integer

    Public Shared xportada_cons As Object
    Public Shared xinicio_cons As Object
    Public Shared xicono_cons As Object

    Public Shared xtipocallcenter_cons As Integer

    Public Shared xconsecrcaja_cons As Integer
    Public Shared xconseccegreso_cons As Integer
    Public Shared xconsecfactura_cons As Integer

    Public Shared xformatopos As String

#End Region

#Region "Atributos"

    Private Idconsultorio As Integer
    Private razonsocial_cons As String
    Private nit_cons As String
    Private direccion_cons As String
    Private ciudad_cons As String
    Private web_cons As String
    Private email_cons As String
    Private actividad_cons As String
    Private rtelegal_cons As String
    Private profesionrlegal_cons As String
    Private documento_cons As String
    Private ciudaddoc_cons As String
    Private ciudadnacrlegal_cons As String
    Private tel1_cons As String
    Private tel2_cons As String
    Private celular_cons As String
    Private fax_cons As String
    Private Iddoctor As Integer
    Private horaini As String
    Private horafin As String
    Private rangocal As String
    Private textopiecita As String
    Private textopiercaja As String
    Private textopiefactura As String
    Private textodian As String
    Private topecita As Integer

    Private portada_cons As Object
    Private inicio_cons As Object
    Private icono_cons As Object

    Private tipocallcenter_cons As Integer
    Private consecrcaja_cons As Integer
    Private conseccegreso_cons As Integer
    Private consecfactura_cons As Integer

    Private formatopos As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idconsultorio = 0
        Me.razonsocial_cons = ""
        Me.nit_cons = ""
        Me.direccion_cons = ""
        Me.ciudad_cons = ""
        Me.web_cons = ""
        Me.email_cons = ""
        Me.actividad_cons = ""
        Me.rtelegal_cons = ""
        Me.profesionrlegal_cons = ""
        Me.documento_cons = ""
        Me.ciudaddoc_cons = ""
        Me.ciudadnacrlegal_cons = ""
        Me.tel1_cons = ""
        Me.tel2_cons = ""
        Me.celular_cons = ""
        Me.fax_cons = ""
        Me.Iddoctor = 0
        Me.horaini = ""
        Me.horafin = ""
        Me.rangocal = ""
        Me.textopiecita = ""
        Me.textopiercaja = ""
        Me.textopiefactura = ""
        Me.textodian = ""
        Me.topecita = 0

        Me.portada_cons = ""
        Me.inicio_cons = ""
        Me.icono_cons = ""

        Me.tipocallcenter_cons = 1
        Me.consecrcaja_cons = 0
        Me.conseccegreso_cons = 0
        Me.consecfactura_cons = 0

        Me.formatopos = ""

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"
    Public Property p_Idconsultorio() As Integer
        Get
            Return Me.Idconsultorio
        End Get
        Set(ByVal Value As Integer)
            Me.Idconsultorio = Value
        End Set
    End Property
    Public Property p_razonsocial_cons() As String
        Get
            Return Me.razonsocial_cons
        End Get
        Set(ByVal Value As String)
            Me.razonsocial_cons = Value
        End Set
    End Property
    Public Property p_nit_cons() As String
        Get
            Return Me.nit_cons
        End Get
        Set(ByVal Value As String)
            Me.nit_cons = Value
        End Set
    End Property
    Public Property p_direccion_cons() As String
        Get
            Return Me.direccion_cons
        End Get
        Set(ByVal Value As String)
            Me.direccion_cons = Value
        End Set
    End Property

    Public Property p_ciudad_cons() As String
        Get
            Return Me.ciudad_cons
        End Get
        Set(ByVal Value As String)
            Me.ciudad_cons = Value
        End Set
    End Property
    Public Property p_web_cons() As String
        Get
            Return Me.web_cons
        End Get
        Set(ByVal Value As String)
            Me.web_cons = Value
        End Set
    End Property
    Public Property p_email_cons() As String
        Get
            Return Me.email_cons
        End Get
        Set(ByVal Value As String)
            Me.email_cons = Value
        End Set
    End Property
    Public Property p_actividad_cons() As String
        Get
            Return Me.actividad_cons
        End Get
        Set(ByVal Value As String)
            Me.actividad_cons = Value
        End Set
    End Property
    Public Property p_rtelegal_cons() As String
        Get
            Return Me.rtelegal_cons
        End Get
        Set(ByVal Value As String)
            Me.rtelegal_cons = Value
        End Set
    End Property
    Public Property p_profesionrlegal_cons() As String
        Get
            Return Me.profesionrlegal_cons
        End Get
        Set(ByVal Value As String)
            Me.profesionrlegal_cons = Value
        End Set
    End Property
    Public Property p_documento_cons() As String
        Get
            Return Me.documento_cons
        End Get
        Set(ByVal Value As String)
            Me.documento_cons = Value
        End Set
    End Property
    Public Property p_ciudaddoc_cons() As String
        Get
            Return Me.ciudaddoc_cons
        End Get
        Set(ByVal Value As String)
            Me.ciudaddoc_cons = Value
        End Set
    End Property
    Public Property p_ciudadnacrlegal_cons() As String
        Get
            Return Me.ciudadnacrlegal_cons
        End Get
        Set(ByVal Value As String)
            Me.ciudadnacrlegal_cons = Value
        End Set
    End Property
    Public Property p_tel1_cons() As String
        Get
            Return Me.tel1_cons
        End Get
        Set(ByVal Value As String)
            Me.tel1_cons = Value
        End Set
    End Property
    Public Property p_tel2_cons() As String
        Get
            Return Me.tel2_cons
        End Get
        Set(ByVal Value As String)
            Me.tel2_cons = Value
        End Set
    End Property
    Public Property p_celular_cons() As String
        Get
            Return Me.celular_cons
        End Get
        Set(ByVal Value As String)
            Me.celular_cons = Value
        End Set
    End Property
    Public Property p_fax_cons() As String
        Get
            Return Me.fax_cons
        End Get
        Set(ByVal Value As String)
            Me.fax_cons = Value
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
    Public Property p_rangocal() As String
        Get
            Return Me.rangocal
        End Get
        Set(ByVal Value As String)
            Me.rangocal = Value
        End Set
    End Property

    Public Property p_textopiecita() As String
        Get
            Return Me.textopiecita
        End Get
        Set(ByVal Value As String)
            Me.textopiecita = Value
        End Set
    End Property

    Public Property p_textopiercaja() As String
        Get
            Return Me.textopiercaja
        End Get
        Set(ByVal Value As String)
            Me.textopiercaja = Value
        End Set
    End Property

    Public Property p_textopiefactura() As String
        Get
            Return Me.textopiefactura
        End Get
        Set(ByVal Value As String)
            Me.textopiefactura = Value
        End Set
    End Property

    Public Property p_textodian() As String
        Get
            Return Me.textodian
        End Get
        Set(ByVal Value As String)
            Me.textodian = Value
        End Set
    End Property

    Public Property p_topecita() As Integer
        Get
            Return Me.topecita
        End Get
        Set(ByVal Value As Integer)
            Me.topecita = Value
        End Set
    End Property

    Public Property p_portada_cons() As Object
        Get
            Return Me.portada_cons
        End Get
        Set(ByVal Value As Object)
            Me.portada_cons = Value
        End Set
    End Property

    Public Property p_icono_cons() As Object
        Get
            Return Me.icono_cons
        End Get
        Set(ByVal Value As Object)
            Me.icono_cons = Value
        End Set
    End Property

    Public Property p_inicio_cons() As Object
        Get
            Return Me.inicio_cons
        End Get
        Set(ByVal Value As Object)
            Me.inicio_cons = Value
        End Set
    End Property

    Public Property p_tipocallcenter_cons() As Integer
        Get
            Return Me.topecita
        End Get
        Set(ByVal Value As Integer)
            Me.tipocallcenter_cons = Value
        End Set
    End Property

    Public Property p_consecrcaja_cons() As Integer
        Get
            Return Me.consecrcaja_cons
        End Get
        Set(ByVal Value As Integer)
            Me.consecrcaja_cons = Value
        End Set
    End Property

    Public Property p_conseccegreso_cons() As Integer
        Get
            Return Me.conseccegreso_cons
        End Get
        Set(ByVal Value As Integer)
            Me.conseccegreso_cons = Value
        End Set
    End Property

    Public Property p_consecfactura_cons() As Integer
        Get
            Return Me.consecfactura_cons
        End Get
        Set(ByVal Value As Integer)
            Me.consecfactura_cons = Value
        End Set
    End Property

    Public Property p_formatopos() As String
        Get
            Return Me.formatopos
        End Get
        Set(ByVal Value As String)
            Me.formatopos = Value
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

            CLASE_GENERAL.sql = "DELETE FROM consultorio WHERE Idconsultorio = " & Me.Idconsultorio & ""
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



            CLASE_GENERAL.sql = "INSERT INTO consultorio(Idconsultorio, razonsocial_cons, nit_cons, direccion_cons, ciudad_con, web_cons, email_cons, actividad_cons, rtelegal_cons, profesionrlegal_cons, documento_cons, ciudaddoc_cons, tel1_cons, tel2_cons, celular_cons, fax_cons, Iddoctor, horaini, horafin, rangocal, textopiecita, textopiercaja, textopiefactura, textodian, topecita, portada_cons, inicio_cons, icono_cons, tipocallcenter_cons, consecrcaja_cons, conseccegreso_cons, consecfactura_cons, formatopos) VALUES " _
            & "(" & Me.Idconsultorio & ", '" & Me.razonsocial_cons & "', '" & Me.nit_cons & "', '" & Me.direccion_cons & "', '" & Me.ciudad_cons & "', '" & Me.web_cons & "', '" & Me.email_cons & "', '" & Me.actividad_cons & "', '" & Me.rtelegal_cons & "', '" & Me.profesionrlegal_cons & "', '" & Me.documento_cons & "', '" & Me.ciudaddoc_cons & "', '" & Me.ciudadnacrlegal_cons & "', '" & Me.tel1_cons & "', '" & Me.tel2_cons & "', '" & Me.celular_cons & "', " _
            & "'" & Me.fax_cons & "', " & Me.Iddoctor & ",'" & Me.horaini & "', '" & Me.horafin & "', '" & Me.rangocal & "', '" & Me.textopiecita & ", '" & Me.textopiercaja & "', '" & Me.textopiefactura & "', '" & Me.textodian & "',  " & Me.topecita & ", ?imagen0, ?imagen1, ?imagen2, " & Me.tipocallcenter_cons & ", " & Me.consecrcaja_cons & ", " & Me.conseccegreso_cons & ", " & Me.consecfactura_cons & ", '" & Me.formatopos & "')"

            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?imagen0", Me.portada_cons)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?imagen1", Me.inicio_cons)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?imagen2", Me.icono_cons)
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

            Select Case mensaje

                Case "consultorio"

                    CLASE_GENERAL.sql = "UPDATE consultorio SET razonsocial_cons = '" & Me.razonsocial_cons & "', nit_cons = '" & Me.nit_cons & "', direccion_cons = '" & Me.direccion_cons & "', ciudad_cons = '" & Me.ciudad_cons & "', web_cons = '" & Me.web_cons & "', email_cons = '" & Me.email_cons & "', actividad_cons = '" & Me.actividad_cons & "', rtelegal_cons = '" & Me.rtelegal_cons & "', profesionrlegal_cons = '" & Me.profesionrlegal_cons & "', " _
                    & "documento_cons= '" & Me.documento_cons & "', ciudaddoc_cons = '" & Me.ciudaddoc_cons & "', ciudadnacrlegal_cons = '" & Me.ciudadnacrlegal_cons & "', tel1_cons = '" & Me.tel1_cons & "', tel2_cons = '" & Me.tel2_cons & "', celular_cons = '" & Me.celular_cons & "', fax_cons = '" & Me.fax_cons & "', Iddoctor = " & Me.Iddoctor & ", horaini = '" & Me.horaini & "', horafin = '" & Me.horafin & "', " _
                    & "rangocal = '" & Me.rangocal & "', textopiecita = '" & Me.textopiecita & "', textopiercaja = '" & Me.textopiercaja & "', textopiefactura = '" & Me.textopiefactura & "', textodian = '" & Me.textodian & "', topecita = '" & Me.topecita & "', portada_cons = ?imagen0, inicio_cons = ?imagen1, icono_cons = ?imagen2, tipocallcenter_cons = " & Me.tipocallcenter_cons & ", consecrcaja_cons = " & Me.consecrcaja_cons & ", conseccegreso_cons = " & Me.conseccegreso_cons & ", consecfactura_cons = " & Me.consecfactura_cons & ", formatopos = '" & Me.formatopos & "' WHERE Idconsultorio = " & Me.Idconsultorio & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?imagen0", Me.portada_cons)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?imagen1", Me.inicio_cons)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?imagen2", Me.icono_cons)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                Case "consecrcaja"

                    CLASE_GENERAL.sql = "UPDATE consultorio SET consecrcaja_cons = " & Me.consecrcaja_cons & "  WHERE Idconsultorio = " & Me.Idconsultorio & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                Case "conseccegreso"

                    CLASE_GENERAL.sql = "UPDATE consultorio SET conseccegreso_cons = " & Me.conseccegreso_cons & " WHERE Idconsultorio = " & Me.Idconsultorio & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                Case "consecfactura"

                    CLASE_GENERAL.sql = "UPDATE consultorio SET consecfactura_cons = " & Me.consecfactura_cons & " WHERE Idconsultorio = " & Me.Idconsultorio & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

            End Select



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

                Case "consultorio"

                    CLASE_GENERAL.sql = "SELECT * FROM consultorio where Idconsultorio = " & Me.Idconsultorio & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdconsultorio = CLASE_GENERAL.xdr("Idconsultorio")
                        xrazonsocial_cons = CLASE_GENERAL.xdr("razonsocial_cons")
                        xnit_cons = CLASE_GENERAL.xdr("nit_cons")
                        xdireccion_cons = CLASE_GENERAL.xdr("direccion_cons")
                        xciudad_cons = CLASE_GENERAL.xdr("ciudad_cons")
                        xweb_cons = CLASE_GENERAL.xdr("web_cons")
                        xemail_cons = CLASE_GENERAL.xdr("email_cons")
                        xactividad_cons = CLASE_GENERAL.xdr("actividad_cons")
                        xrtelegal_cons = CLASE_GENERAL.xdr("rtelegal_cons")
                        xprofesionrlegal_cons = CLASE_GENERAL.xdr("profesionrlegal_cons")
                        xdocumento_cons = CLASE_GENERAL.xdr("documento_cons")
                        xciudaddoc_cons = CLASE_GENERAL.xdr("ciudaddoc_cons")
                        xciudadnacrlegal_cons = CLASE_GENERAL.xdr("ciudadnacrlegal_cons")
                        xtel1_cons = CLASE_GENERAL.xdr("tel1_cons")
                        xtel2_cons = CLASE_GENERAL.xdr("tel2_cons")
                        xcelular_cons = CLASE_GENERAL.xdr("celular_cons")
                        xfax_cons = CLASE_GENERAL.xdr("fax_cons")
                        xIddoctor = CLASE_GENERAL.xdr("Iddoctor")
                        xhoraini = Convert.ToString(CLASE_GENERAL.xdr("horaini"))
                        xhoraini2 = CLASE_GENERAL.xdr("horaini")
                        xhorafin = Convert.ToString(CLASE_GENERAL.xdr("horafin"))
                        xhorafin2 = CLASE_GENERAL.xdr("horafin")
                        xrangocal = CLASE_GENERAL.xdr("rangocal")
                        xtextopiecita = CLASE_GENERAL.xdr("textopiecita")
                        xtextopiercaja = CLASE_GENERAL.xdr("textopiercaja")
                        xtextopiefactura = CLASE_GENERAL.xdr("textopiefactura")
                        xtextodian = CLASE_GENERAL.xdr("textodian")
                        xtopecita = CLASE_GENERAL.xdr("topecita")

                        If CLASE_GENERAL.xdr("portada_cons") Is DBNull.Value Then
                            xportada_cons = ""
                        Else
                            xportada_cons = CLASE_GENERAL.xdr("portada_cons")
                        End If

                        If CLASE_GENERAL.xdr("inicio_cons") Is DBNull.Value Then
                            xinicio_cons = ""
                        Else
                            xinicio_cons = CLASE_GENERAL.xdr("inicio_cons")
                        End If

                        If CLASE_GENERAL.xdr("icono_cons") Is DBNull.Value Then
                            xicono_cons = ""
                        Else
                            xicono_cons = CLASE_GENERAL.xdr("icono_cons")
                        End If

                        xtipocallcenter_cons = CLASE_GENERAL.xdr("tipocallcenter_cons")
                        xconsecrcaja_cons = CLASE_GENERAL.xdr("consecrcaja_cons")
                        xconseccegreso_cons = CLASE_GENERAL.xdr("conseccegreso_cons")
                        xconsecfactura_cons = CLASE_GENERAL.xdr("consecfactura_cons")

                        xformatopos = CLASE_GENERAL.xdr("formatopos")

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "imagenesconsultorio"

                    CLASE_GENERAL.sql = "SELECT portada_cons, inicio_cons, icono_cons  FROM consultorio where Idconsultorio = " & Me.Idconsultorio & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("portada_cons") Is DBNull.Value Then
                            xportada_cons = ""
                        Else
                            xportada_cons = CLASE_GENERAL.xdr("portada_cons")
                        End If

                        If CLASE_GENERAL.xdr("inicio_cons") Is DBNull.Value Then
                            xinicio_cons = ""
                        Else
                            xinicio_cons = CLASE_GENERAL.xdr("inicio_cons")
                        End If

                        If CLASE_GENERAL.xdr("icono_cons") Is DBNull.Value Then
                            xicono_cons = ""
                        Else
                            xicono_cons = CLASE_GENERAL.xdr("icono_cons")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "logoclinica"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT icono_cons, razonsocial_cons, rtelegal_cons, ciudadnacrlegal_cons, profesionrlegal_cons, actividad_cons, documento_cons, ciudaddoc_cons, web_cons, email_cons, direccion_cons, ciudad_cons, tel1_cons, celular_cons FROM consultorio where Idconsultorio = " & Me.Idconsultorio & " "


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\iconoclinica.xml", XmlWriteMode.WriteSchema)

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
