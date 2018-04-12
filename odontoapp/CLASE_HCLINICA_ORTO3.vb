Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA_ORTO3

    Implements CLASE_GENERAL.DML


#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer

    Public Shared xmconsulta_horto3 As String
    Public Shared xopciones_horto3 As String
    Public Shared xparentezco_horto3 As String
    Public Shared xhabitos_horto3 As String
    Public Shared xcepillarseveces_horto3 As String
    Public Shared xazucares_horto3 As String
    Public Shared xobservaciones_horto3 As String
    Public Shared xenfermedadactual_horto3 As String
    Public Shared xmedicamento_horto3 As String
    Public Shared xafecciones_horto3 As String
    Public Shared xcuandoafecciones_horto3 As String
    Public Shared xalergiasaque_horto3 As String
    Public Shared xcuandoamigdalas_horto3 As String
    Public Shared xcuandoadenoides_horto3 As String
    Public Shared xcualcirugia_horto3 As String
    Public Shared xsna_horto3 As String
    Public Shared xsnb_horto3 As String
    Public Shared xanb_horto3 As String
    Public Shared xipp_horto3 As String
    Public Shared xina_horto3 As String
    Public Shared xipm_horto3 As String
    Public Shared xinb_horto3 As String
    Public Shared xles_horto3 As String
    Public Shared xlei_horto3 As String
    Public Shared xgo_horto3 As String
    Public Shared xobservacionesaencef_horto3 As String
    Public Shared xdiag_facial_horto3 As String
    Public Shared xdiag_esque_horto3 As String
    Public Shared xdiag_dental_horto3 As String
    Public Shared xdiag_periodontal_horto3 As String
    Public Shared xplantratamiento_horto3 As String
    Public Shared xalternativas_horto3 As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer

    Private mconsulta_horto3 As String
    Private opciones_horto3 As String
    Private parentezco_horto3 As String
    Private habitos_horto3 As String
    Private cepillarseveces_horto3 As String
    Private azucares_horto3 As String
    Private observaciones_horto3 As String
    Private enfermedadactual_horto3 As String
    Private medicamento_horto3 As String
    Private afecciones_horto3 As String
    Private cuandoafecciones_horto3 As String
    Private alergiasaque_horto3 As String
    Private cuandoamigdalas_horto3 As String
    Private cuandoadenoides_horto3 As String
    Private cualcirugia_horto3 As String
    Private sna_horto3 As String
    Private snb_horto3 As String
    Private anb_horto3 As String
    Private ipp_horto3 As String
    Private ina_horto3 As String
    Private ipm_horto3 As String
    Private inb_horto3 As String
    Private les_horto3 As String
    Private lei_horto3 As String
    Private go_horto3 As String
    Private observacionesaencef_horto3 As String
    Private diag_facial_horto3 As String
    Private diag_esque_horto3 As String
    Private diag_dental_horto3 As String
    Private diag_periodontal_horto3 As String
    Private plantratamiento_horto3 As String
    Private alternativas_horto3 As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0

        Me.mconsulta_horto3 = ""
        Me.opciones_horto3 = ""
        Me.parentezco_horto3 = ""
        Me.habitos_horto3 = ""
        Me.cepillarseveces_horto3 = ""
        Me.azucares_horto3 = ""
        Me.observaciones_horto3 = ""
        Me.enfermedadactual_horto3 = ""
        Me.medicamento_horto3 = ""
        Me.afecciones_horto3 = ""
        Me.cuandoafecciones_horto3 = ""
        Me.alergiasaque_horto3 = ""
        Me.cuandoamigdalas_horto3 = ""
        Me.cuandoadenoides_horto3 = ""
        Me.cualcirugia_horto3 = ""
        Me.sna_horto3 = ""
        Me.snb_horto3 = ""
        Me.anb_horto3 = ""
        Me.ipp_horto3 = ""
        Me.ina_horto3 = ""
        Me.ipm_horto3 = ""
        Me.inb_horto3 = ""
        Me.les_horto3 = ""
        Me.lei_horto3 = ""
        Me.go_horto3 = ""
        Me.observacionesaencef_horto3 = ""
        Me.diag_facial_horto3 = ""
        Me.diag_esque_horto3 = ""
        Me.diag_dental_horto3 = ""
        Me.diag_periodontal_horto3 = ""
        Me.plantratamiento_horto3 = ""
        Me.alternativas_horto3 = ""

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"

    Public Sub dispose()
        GC.Collect()
    End Sub

#End Region

#Region "Propiedades"

    Public Property p_IdUsuario() As Integer
        Get
            Return Me.IdUsuario
        End Get
        Set(ByVal Value As Integer)
            Me.IdUsuario = Value
        End Set
    End Property

    Public Property p_IdTUsuario() As Integer
        Get
            Return Me.IdTUsuario
        End Get
        Set(ByVal Value As Integer)
            Me.IdTUsuario = Value
        End Set
    End Property

    Public Property p_mconsulta_horto3() As String
        Get
            Return Me.mconsulta_horto3
        End Get
        Set(ByVal value As String)
            Me.mconsulta_horto3 = value
        End Set
    End Property

    Public Property p_opciones_horto3() As String
        Get
            Return Me.opciones_horto3
        End Get
        Set(ByVal value As String)
            Me.opciones_horto3 = value
        End Set
    End Property

    Public Property p_parentezco_horto3() As String
        Get
            Return Me.parentezco_horto3
        End Get
        Set(ByVal value As String)
            Me.parentezco_horto3 = value
        End Set
    End Property

    Public Property p_habitos_horto3() As String
        Get
            Return Me.habitos_horto3
        End Get
        Set(ByVal value As String)
            Me.habitos_horto3 = value
        End Set
    End Property

    Public Property p_cepillarseveces_horto3() As String
        Get
            Return Me.cepillarseveces_horto3
        End Get
        Set(ByVal value As String)
            Me.cepillarseveces_horto3 = value
        End Set
    End Property

    Public Property p_azucares_horto3() As String
        Get
            Return Me.azucares_horto3
        End Get
        Set(ByVal value As String)
            Me.azucares_horto3 = value
        End Set
    End Property

    Public Property p_observaciones_horto3() As String
        Get
            Return Me.observaciones_horto3
        End Get
        Set(ByVal value As String)
            Me.observaciones_horto3 = value
        End Set
    End Property

    Public Property p_enfermedadactual_horto3() As String
        Get
            Return Me.enfermedadactual_horto3
        End Get
        Set(ByVal value As String)
            Me.enfermedadactual_horto3 = value
        End Set
    End Property

    Public Property p_medicamento_horto3() As String
        Get
            Return Me.medicamento_horto3
        End Get
        Set(ByVal value As String)
            Me.medicamento_horto3 = value
        End Set
    End Property

    Public Property p_afecciones_horto3() As String
        Get
            Return Me.afecciones_horto3
        End Get
        Set(ByVal value As String)
            Me.afecciones_horto3 = value
        End Set
    End Property

    Public Property p_cuandoafecciones_horto3() As String
        Get
            Return Me.cuandoafecciones_horto3
        End Get
        Set(ByVal value As String)
            Me.cuandoafecciones_horto3 = value
        End Set
    End Property

    Public Property p_alergiasaque_horto3() As String
        Get
            Return Me.alergiasaque_horto3
        End Get
        Set(ByVal value As String)
            Me.alergiasaque_horto3 = value
        End Set
    End Property

    Public Property p_cuandoamigdalas_horto3() As String
        Get
            Return Me.cuandoamigdalas_horto3
        End Get
        Set(ByVal value As String)
            Me.cuandoamigdalas_horto3 = value
        End Set
    End Property

    Public Property p_cuandoadenoides_horto3() As String
        Get
            Return Me.cuandoadenoides_horto3
        End Get
        Set(ByVal value As String)
            Me.cuandoadenoides_horto3 = value
        End Set
    End Property

    Public Property p_cualcirugia_horto3() As String
        Get
            Return Me.cualcirugia_horto3
        End Get
        Set(ByVal value As String)
            Me.cualcirugia_horto3 = value
        End Set
    End Property

    Public Property p_sna_horto3() As String
        Get
            Return Me.sna_horto3
        End Get
        Set(ByVal value As String)
            Me.sna_horto3 = value
        End Set
    End Property

    Public Property p_snb_horto3() As String
        Get
            Return Me.snb_horto3
        End Get
        Set(ByVal value As String)
            Me.snb_horto3 = value
        End Set
    End Property

    Public Property p_anb_horto3() As String
        Get
            Return Me.anb_horto3
        End Get
        Set(ByVal value As String)
            Me.anb_horto3 = value
        End Set
    End Property

    Public Property p_ipp_horto3() As String
        Get
            Return Me.ipp_horto3
        End Get
        Set(ByVal value As String)
            Me.ipp_horto3 = value
        End Set
    End Property

    Public Property p_ina_horto3() As String
        Get
            Return Me.ina_horto3
        End Get
        Set(ByVal value As String)
            Me.ina_horto3 = value
        End Set
    End Property

    Public Property p_ipm_horto3() As String
        Get
            Return Me.ipm_horto3
        End Get
        Set(ByVal value As String)
            Me.ipm_horto3 = value
        End Set
    End Property

    Public Property p_inb_horto3() As String
        Get
            Return Me.inb_horto3
        End Get
        Set(ByVal value As String)
            Me.inb_horto3 = value
        End Set
    End Property

    Public Property p_les_horto3() As String
        Get
            Return Me.les_horto3
        End Get
        Set(ByVal value As String)
            Me.les_horto3 = value
        End Set
    End Property

    Public Property p_lei_horto3() As String
        Get
            Return Me.lei_horto3
        End Get
        Set(ByVal value As String)
            Me.lei_horto3 = value
        End Set
    End Property

    Public Property p_go_horto3() As String
        Get
            Return Me.go_horto3
        End Get
        Set(ByVal value As String)
            Me.go_horto3 = value
        End Set
    End Property

    Public Property p_observacionesaencef_horto3() As String
        Get
            Return Me.observacionesaencef_horto3
        End Get
        Set(ByVal value As String)
            Me.observacionesaencef_horto3 = value
        End Set
    End Property

    Public Property p_diag_facial_horto3() As String
        Get
            Return Me.diag_facial_horto3
        End Get
        Set(ByVal value As String)
            Me.diag_facial_horto3 = value
        End Set
    End Property

    Public Property p_diag_esque_horto3() As String
        Get
            Return Me.diag_esque_horto3
        End Get
        Set(ByVal value As String)
            Me.diag_esque_horto3 = value
        End Set
    End Property

    Public Property p_diag_dental_horto3() As String
        Get
            Return Me.diag_dental_horto3
        End Get
        Set(ByVal value As String)
            Me.diag_dental_horto3 = value
        End Set
    End Property

    Public Property p_diag_periodontal_horto3() As String
        Get
            Return Me.diag_periodontal_horto3
        End Get
        Set(ByVal value As String)
            Me.diag_periodontal_horto3 = value
        End Set
    End Property

    Public Property p_plantratamiento_horto3() As String
        Get
            Return Me.plantratamiento_horto3
        End Get
        Set(ByVal value As String)
            Me.plantratamiento_horto3 = value
        End Set
    End Property

    Public Property p_alternativas_horto3() As String
        Get
            Return Me.alternativas_horto3
        End Get
        Set(ByVal value As String)
            Me.alternativas_horto3 = value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica_orto3 WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = " INSERT INTO orthosoft.hclinica_orto3 (IdUsuario, IdTUsuario, mconsulta_horto3, opciones_horto3, parentezco_horto3, habitos_horto3, cepillarseveces_horto3, azucares_horto3, " _
            & "observaciones_horto3, enfermedadactual_horto3, medicamento_horto3, afecciones_horto3, cuandoafecciones_horto3, alergiasaque_horto3, cuandoamigdalas_horto3, cuandoadenoides_horto3, cualcirugia_horto3, " _
            & "sna_horto3, snb_horto3, anb_horto3, ipp_horto3, ina_horto3, ipm_horto3, inb_horto3, les_horto3, lei_horto3, go_horto3, observacionesaencef_horto3, diag_facial_horto3, diag_esque_horto3, diag_dental_horto3, " _
            & "diag_periodontal_horto3, plantratamiento_horto3, alternativas_horto3) " _
            & "VALUES(" & Me.IdUsuario & ", " & Me.IdTUsuario & ", '" & Me.mconsulta_horto3 & "', '" & Me.opciones_horto3 & "', '" & Me.parentezco_horto3 & "', '" & Me.habitos_horto3 & "', '" & Me.cepillarseveces_horto3 & "', '" & Me.azucares_horto3 & "', '" & Me.observaciones_horto3 & "', '" & Me.enfermedadactual_horto3 & "', " _
            & "'" & Me.medicamento_horto3 & "', '" & Me.afecciones_horto3 & "', '" & Me.cuandoafecciones_horto3 & "', '" & Me.alergiasaque_horto3 & "', '" & Me.cuandoamigdalas_horto3 & "', '" & Me.cuandoadenoides_horto3 & "', '" & Me.cualcirugia_horto3 & "', '" & Me.sna_horto3 & "', '" & Me.snb_horto3 & "', '" & Me.anb_horto3 & "', " _
            & "'" & Me.ipp_horto3 & "', '" & Me.ina_horto3 & "', '" & Me.ipm_horto3 & "', '" & Me.inb_horto3 & "', '" & Me.les_horto3 & "', '" & Me.lei_horto3 & "', '" & Me.go_horto3 & "', '" & Me.observacionesaencef_horto3 & "', '" & Me.diag_facial_horto3 & "', '" & Me.diag_esque_horto3 & "', '" & Me.diag_dental_horto3 & "', '" & Me.diag_periodontal_horto3 & "', " _
            & "'" & Me.plantratamiento_horto3 & "', '" & Me.alternativas_horto3 & "')"

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

            CLASE_GENERAL.sql = "UPDATE (Orthosoft.hclinica_orto3) SET mconsulta_horto3 = '" & Me.mconsulta_horto3 & "' , opciones_horto3 = '" & Me.opciones_horto3 & "' , parentezco_horto3 = '" & Me.parentezco_horto3 & "' , habitos_horto3 = '" & Me.habitos_horto3 & "' , " _
            & "cepillarseveces_horto3 = '" & Me.cepillarseveces_horto3 & "' ,azucares_horto3 = '" & Me.azucares_horto3 & "' , observaciones_horto3 = '" & Me.observaciones_horto3 & "' , enfermedadactual_horto3 = '" & Me.enfermedadactual_horto3 & "' , medicamento_horto3 = '" & Me.medicamento_horto3 & "' , afecciones_horto3 = '" & Me.afecciones_horto3 & "' , " _
            & "cuandoafecciones_horto3 = '" & Me.cuandoafecciones_horto3 & "' , alergiasaque_horto3 = '" & Me.alergiasaque_horto3 & "' , cuandoamigdalas_horto3 = '" & Me.cuandoamigdalas_horto3 & "' , cuandoadenoides_horto3 = '" & Me.cuandoadenoides_horto3 & "' , cualcirugia_horto3 = '" & Me.cualcirugia_horto3 & "' , sna_horto3 = '" & Me.sna_horto3 & "' , " _
            & "snb_horto3 = '" & Me.snb_horto3 & "' , anb_horto3 = '" & Me.anb_horto3 & "' , ipp_horto3 = '" & Me.ipp_horto3 & "' , ina_horto3 = '" & Me.ina_horto3 & "' , ipm_horto3 = '" & Me.ipm_horto3 & "' , inb_horto3 = '" & Me.inb_horto3 & "' , les_horto3 = '" & Me.les_horto3 & "' , lei_horto3 = '" & Me.lei_horto3 & "' , go_horto3 = '" & Me.go_horto3 & "' , " _
            & "observacionesaencef_horto3 = '" & Me.observacionesaencef_horto3 & "' , diag_facial_horto3 = '" & Me.diag_facial_horto3 & "' , diag_esque_horto3 = '" & Me.diag_esque_horto3 & "' , diag_dental_horto3 = '" & Me.diag_dental_horto3 & "' , diag_periodontal_horto3 = '" & Me.diag_periodontal_horto3 & "' , plantratamiento_horto3 = '" & Me.plantratamiento_horto3 & "' , " _
            & "alternativas_horto3 = '" & Me.alternativas_horto3 & " ' " _
            & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

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

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT * FROM Orthosoft.hclinica_orto3 " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")

                        xmconsulta_horto3 = CLASE_GENERAL.xdr("mconsulta_horto3")
                        xopciones_horto3 = CLASE_GENERAL.xdr("opciones_horto3")
                        xparentezco_horto3 = CLASE_GENERAL.xdr("parentezco_horto3")
                        xhabitos_horto3 = CLASE_GENERAL.xdr("habitos_horto3")
                        xcepillarseveces_horto3 = CLASE_GENERAL.xdr("cepillarseveces_horto3")
                        xazucares_horto3 = CLASE_GENERAL.xdr("azucares_horto3")
                        xobservaciones_horto3 = CLASE_GENERAL.xdr("observaciones_horto3")
                        xenfermedadactual_horto3 = CLASE_GENERAL.xdr("enfermedadactual_horto3")
                        xmedicamento_horto3 = CLASE_GENERAL.xdr("medicamento_horto3")
                        xafecciones_horto3 = CLASE_GENERAL.xdr("afecciones_horto3")
                        xcuandoafecciones_horto3 = CLASE_GENERAL.xdr("cuandoafecciones_horto3")
                        xalergiasaque_horto3 = CLASE_GENERAL.xdr("alergiasaque_horto3")
                        xcuandoamigdalas_horto3 = CLASE_GENERAL.xdr("cuandoamigdalas_horto3")
                        xcuandoadenoides_horto3 = CLASE_GENERAL.xdr("cuandoadenoides_horto3")
                        xcualcirugia_horto3 = CLASE_GENERAL.xdr("cualcirugia_horto3")
                        xsna_horto3 = CLASE_GENERAL.xdr("sna_horto3")
                        xsnb_horto3 = CLASE_GENERAL.xdr("snb_horto3")
                        xanb_horto3 = CLASE_GENERAL.xdr("anb_horto3")
                        xipp_horto3 = CLASE_GENERAL.xdr("ipp_horto3")
                        xina_horto3 = CLASE_GENERAL.xdr("ina_horto3")
                        xipm_horto3 = CLASE_GENERAL.xdr("ipm_horto3")
                        xinb_horto3 = CLASE_GENERAL.xdr("inb_horto3")
                        xles_horto3 = CLASE_GENERAL.xdr("les_horto3")
                        xlei_horto3 = CLASE_GENERAL.xdr("lei_horto3")
                        xgo_horto3 = CLASE_GENERAL.xdr("go_horto3")
                        xobservacionesaencef_horto3 = CLASE_GENERAL.xdr("observacionesaencef_horto3")
                        xdiag_facial_horto3 = CLASE_GENERAL.xdr("diag_facial_horto3")
                        xdiag_esque_horto3 = CLASE_GENERAL.xdr("diag_esque_horto3")
                        xdiag_dental_horto3 = CLASE_GENERAL.xdr("diag_dental_horto3")
                        xdiag_periodontal_horto3 = CLASE_GENERAL.xdr("diag_periodontal_horto3")
                        xplantratamiento_horto3 = CLASE_GENERAL.xdr("plantratamiento_horto3")
                        xalternativas_horto3 = CLASE_GENERAL.xdr("alternativas_horto3")


                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

                Case "impresion"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT consultorio.Idconsultorio, consultorio.razonsocial_cons, consultorio.nit_cons  , consultorio.direccion_cons, consultorio.ciudad_cons, consultorio.web_cons, consultorio.email_cons, consultorio.rtelegal_cons, consultorio.profesionrlegal_cons, consultorio.documento_cons, consultorio.ciudaddoc_cons, consultorio.actividad_cons, " _
                    & "consultorio.tel1_cons, consultorio.celular_cons, consultorio.icono_cons, Idpaciente, pacientes.nhclinica, pacientes.nombres_pac, pacientes.apellidos_pac, estadocivil.nom_estadocivil, pacientes.fecnac_pac, pacientes.lugarnac_pac, pacientes.referidopor_pac, pacientes.sexo_pac, pacientes.numdoc_pac, pacientes.dedoc_pac, pacientes.fecingreso_pac, pacientes.residencia_pac, pacientes.ocupacion_pac, " _
                    & "entidades.nombre_ent, hclinica_orto3.*, ograma.observacionograma_ini, ograma.observacionograma_act, ograma.ograma_inicial, ograma.ograma_actual, ograma.oleary_inicial, ograma.oleary_actual, ograma.fecha_ograma FROM Orthosoft.consultorio " _
                    & "INNER JOIN orthosoft.pacientes ON (consultorio.Idconsultorio = pacientes.Idconsultorio) " _
                    & "INNER JOIN orthosoft.entidades ON (pacientes.Identidad = entidades.Identidad) " _
                    & "INNER JOIN orthosoft.estadocivil ON (pacientes.estadocivil_pac = estadocivil.Idestadocivil) " _
                    & "INNER JOIN orthosoft.hclinica_orto3  ON (pacientes.Idpaciente = hclinica_orto3.IdUsuario) " _
                    & "INNER JOIN orthosoft.ograma ON (pacientes.Idpaciente = ograma.IdUsuario) " _
                    & "WHERE Idpaciente = " & Me.IdUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("d:\varios\historiaclinica3.xml", XmlWriteMode.WriteSchema)

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
