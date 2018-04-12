Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA_GENERAL

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xaconsulta_hcg As String
    Public Shared xuconsulta_hcg As String
    Public Shared xantecedentes_hcg As String
    Public Shared xant_temp_hcg As String
    Public Shared xant_pulsapm_hcg As String
    Public Shared xant_pulsaart_hcg As String
    Public Shared xant_fresp_hcg As String
    Public Shared xant_familiares_hcg As String
    Public Shared xant_observa_hcg As String
    Public Shared xef_tblandos_hcg As String
    Public Shared xef_atm_hcg As String
    Public Shared xef_tdentales_hcg As String
    Public Shared xef_exaperio_hcg As String
    Public Shared xef_exapulpar_hcg As String
    Public Shared xef_habitos_hcg As String
    Public Shared xef_observa_hcg As String
    Public Shared xef_hallazgos_hcg As String
    Public Shared xhc_accionp_hcg As String

    Public Shared xhc_frec_charlas_hcg As String
    Public Shared xhc_frec_cepillado_hcg As String
    Public Shared xhc_frec_seda_hcg As String
    Public Shared xhc_frec_enguague_hcg As String
    Public Shared xhc_frec_fluor_hcg As String
    Public Shared xhc_frec_sellantes_hcg As String

    Public Shared xhc_observa_hcg As String
    Public Shared xexa_comp_hcg As String
    Public Shared xdiag_psano_hcg As String
    Public Shared xdiag_psanotipo_hcg As String
    Public Shared xdiag_psanocod_hcg As String
    Public Shared xdiag_tblandos_hcg As String
    Public Shared xdiag_tblandostipo_hcg As String
    Public Shared xdiag_tblandoscod_hcg As String
    Public Shared xdiag_atm_hcg As String
    Public Shared xdiag_atmtipo_hcg As String
    Public Shared xdiag_atmcod_hcg As String
    Public Shared xdiag_tdental_hcg As String
    Public Shared xdiag_tdentaltipo_hcg As String
    Public Shared xdiag_tdentalcod_hcg As String
    Public Shared xdiag_tperio_hcg As String
    Public Shared xdiag_tperiotipo_hcg As String
    Public Shared xdiag_tperiocod_hcg As String
    Public Shared xdiag_tpulpar_hcg As String
    Public Shared xdiag_tpulpartipo_hcg As String
    Public Shared xdiag_tpulparcod_hcg As String
    Public Shared xdiag_otros_hcg As String
    Public Shared xdiag_otrostipo_hcg As String
    Public Shared xdiag_otroscod_hcg As String
    Public Shared xdiag_observa_hcg As String
    Public Shared xdiag_remision_hcg As String
    Public Shared xtrata_promocion_hcg As String
    Public Shared xtrata_prevencion_hcg As String
    Public Shared xtrata_radiog_hcg As String
    Public Shared xtrata_operatoria_hcg As String
    Public Shared xtrata_endodoncia_hcg As String

    Public Shared xtrata_perio_hcg As String
    Public Shared xtrata_prosto_hcg As String
    Public Shared xtrata_oclusion_hcg As String
    Public Shared xtrata_cirugia_hcg As String
    Public Shared xpronostico_hcg As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer

    Private aconsulta_hcg As String
    Private uconsulta_hcg As String
    Private antecedentes_hcg As String
    Private ant_temp_hcg As String
    Private ant_pulsapm_hcg As String
    Private ant_pulsaart_hcg As String
    Private ant_fresp_hcg As String
    Private ant_familiares_hcg As String
    Private ant_observa_hcg As String
    Private ef_tblandos_hcg As String
    Private ef_atm_hcg As String
    Private ef_tdentales_hcg As String
    Private ef_exaperio_hcg As String
    Private ef_exapulpar_hcg As String
    Private ef_habitos_hcg As String
    Private ef_observa_hcg As String
    Private ef_hallazgos_hcg As String
    Private hc_accionp_hcg As String

    Private hc_frec_charlas_hcg As String
    Private hc_frec_cepillado_hcg As String
    Private hc_frec_seda_hcg As String
    Private hc_frec_enguague_hcg As String
    Private hc_frec_fluor_hcg As String
    Private hc_frec_sellantes_hcg As String

    Private hc_observa_hcg As String
    Private exa_comp_hcg As String
    Private diag_psano_hcg As String
    Private diag_psanotipo_hcg As String
    Private diag_psanocod_hcg As String
    Private diag_tblandos_hcg As String
    Private diag_tblandostipo_hcg As String
    Private diag_tblandoscod_hcg As String
    Private diag_atm_hcg As String
    Private diag_atmtipo_hcg As String
    Private diag_atmcod_hcg As String
    Private diag_tdental_hcg As String
    Private diag_tdentaltipo_hcg As String
    Private diag_tdentalcod_hcg As String
    Private diag_tperio_hcg As String
    Private diag_tperiotipo_hcg As String
    Private diag_tperiocod_hcg As String
    Private diag_tpulpar_hcg As String
    Private diag_tpulpartipo_hcg As String
    Private diag_tpulparcod_hcg As String
    Private diag_otros_hcg As String
    Private diag_otrostipo_hcg As String
    Private diag_otroscod_hcg As String
    Private diag_observa_hcg As String
    Private diag_remision_hcg As String
    Private trata_promocion_hcg As String
    Private trata_prevencion_hcg As String
    Private trata_radiog_hcg As String
    Private trata_operatoria_hcg As String
    Private trata_endodoncia_hcg As String

    Private trata_perio_hcg As String
    Private trata_prosto_hcg As String
    Private trata_oclusion_hcg As String
    Private trata_cirugia_hcg As String
    Private pronostico_hcg As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0

        Me.aconsulta_hcg = ""
        Me.uconsulta_hcg = ""
        Me.antecedentes_hcg = ""
        Me.ant_temp_hcg = ""
        Me.ant_pulsapm_hcg = ""
        Me.ant_pulsaart_hcg = ""
        Me.ant_fresp_hcg = ""
        Me.ant_familiares_hcg = ""
        Me.ant_observa_hcg = ""
        Me.ef_tblandos_hcg = ""
        Me.ef_atm_hcg = ""
        Me.ef_tdentales_hcg = ""
        Me.ef_exaperio_hcg = ""
        Me.ef_exapulpar_hcg = ""
        Me.ef_habitos_hcg = ""
        Me.ef_observa_hcg = ""
        Me.ef_hallazgos_hcg = ""
        Me.hc_accionp_hcg = ""

        Me.hc_frec_charlas_hcg = ""
        Me.hc_frec_cepillado_hcg = ""
        Me.hc_frec_seda_hcg = ""
        Me.hc_frec_enguague_hcg = ""
        Me.hc_frec_fluor_hcg = ""
        Me.hc_frec_sellantes_hcg = ""

        Me.hc_observa_hcg = ""
        Me.exa_comp_hcg = ""
        Me.diag_psano_hcg = ""
        Me.diag_psanotipo_hcg = ""
        Me.diag_psanocod_hcg = ""
        Me.diag_tblandos_hcg = ""
        Me.diag_tblandostipo_hcg = ""
        Me.diag_tblandoscod_hcg = ""
        Me.diag_atm_hcg = ""
        Me.diag_atmtipo_hcg = ""
        Me.diag_atmcod_hcg = ""
        Me.diag_tdental_hcg = ""
        Me.diag_tdentaltipo_hcg = ""
        Me.diag_tdentalcod_hcg = ""
        Me.diag_tperio_hcg = ""
        Me.diag_tperiotipo_hcg = ""
        Me.diag_tperiocod_hcg = ""
        Me.diag_tpulpar_hcg = ""
        Me.diag_tpulpartipo_hcg = ""
        Me.diag_tpulparcod_hcg = ""
        Me.diag_otros_hcg = ""
        Me.diag_otrostipo_hcg = ""
        Me.diag_otroscod_hcg = ""
        Me.diag_observa_hcg = ""
        Me.diag_remision_hcg = ""
        Me.trata_promocion_hcg = ""
        Me.trata_prevencion_hcg = ""
        Me.trata_radiog_hcg = ""
        Me.trata_operatoria_hcg = ""
        Me.trata_endodoncia_hcg = ""

        Me.trata_perio_hcg = ""
        Me.trata_prosto_hcg = ""
        Me.trata_oclusion_hcg = ""
        Me.trata_cirugia_hcg = ""
        Me.pronostico_hcg = ""

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

    Public Property p_aconsulta_hcg() As String
        Get
            Return Me.aconsulta_hcg
        End Get
        Set(ByVal value As String)
            Me.aconsulta_hcg = value
        End Set
    End Property

    Public Property p_uconsulta_hcg() As String
        Get
            Return Me.uconsulta_hcg
        End Get
        Set(ByVal value As String)
            Me.uconsulta_hcg = value
        End Set
    End Property

    Public Property p_antecedentes_hcg() As String
        Get
            Return Me.antecedentes_hcg
        End Get
        Set(ByVal value As String)
            Me.antecedentes_hcg = value
        End Set
    End Property

    Public Property p_ant_temp_hcg() As String
        Get
            Return Me.ant_temp_hcg
        End Get
        Set(ByVal value As String)
            Me.ant_temp_hcg = value
        End Set
    End Property

    Public Property p_ant_pulsapm_hcg() As String
        Get
            Return Me.ant_pulsapm_hcg
        End Get
        Set(ByVal value As String)
            Me.ant_pulsapm_hcg = value
        End Set
    End Property

    Public Property p_ant_pulsaart_hcg() As String
        Get
            Return Me.ant_pulsaart_hcg
        End Get
        Set(ByVal value As String)
            Me.ant_pulsaart_hcg = value
        End Set
    End Property

    Public Property p_ant_fresp_hcg() As String
        Get
            Return Me.ant_fresp_hcg
        End Get
        Set(ByVal value As String)
            Me.ant_fresp_hcg = value
        End Set
    End Property

    Public Property p_ant_familiares_hcg() As String
        Get
            Return Me.ant_familiares_hcg
        End Get
        Set(ByVal value As String)
            Me.ant_familiares_hcg = value
        End Set
    End Property

    Public Property p_ant_observa_hcg() As String
        Get
            Return Me.ant_observa_hcg
        End Get
        Set(ByVal value As String)
            Me.ant_observa_hcg = value
        End Set
    End Property

    Public Property p_ef_tblandos_hcg() As String
        Get
            Return Me.ef_tblandos_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_tblandos_hcg = value
        End Set
    End Property

    Public Property p_ef_atm_hcg() As String
        Get
            Return Me.ef_atm_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_atm_hcg = value
        End Set
    End Property

    Public Property p_ef_tdentales_hcg() As String
        Get
            Return Me.ef_tdentales_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_tdentales_hcg = value
        End Set
    End Property

    Public Property p_ef_exaperio_hcg() As String
        Get
            Return Me.ef_exaperio_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_exaperio_hcg = value
        End Set
    End Property

    Public Property p_ef_exapulpar_hcg() As String
        Get
            Return Me.ef_exapulpar_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_exapulpar_hcg = value
        End Set
    End Property

    Public Property p_ef_habitos_hcg() As String
        Get
            Return Me.ef_habitos_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_habitos_hcg = value
        End Set
    End Property

    Public Property p_ef_observa_hcg() As String
        Get
            Return Me.ef_observa_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_observa_hcg = value
        End Set
    End Property

    Public Property p_ef_hallazgos_hcg() As String
        Get
            Return Me.ef_hallazgos_hcg
        End Get
        Set(ByVal value As String)
            Me.ef_hallazgos_hcg = value
        End Set
    End Property

    Public Property p_hc_accionp_hcg() As String
        Get
            Return Me.hc_accionp_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_accionp_hcg = value
        End Set
    End Property

    Public Property p_hc_frec_charlas_hcg() As String
        Get
            Return Me.hc_frec_charlas_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_frec_charlas_hcg = value
        End Set
    End Property

    Public Property p_hc_frec_cepillado_hcg() As String
        Get
            Return Me.hc_frec_cepillado_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_frec_cepillado_hcg = value
        End Set
    End Property

    Public Property p_hc_frec_seda_hcg() As String
        Get
            Return Me.hc_frec_seda_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_frec_seda_hcg = value
        End Set
    End Property

    Public Property p_hc_frec_enguague_hcg() As String
        Get
            Return Me.hc_frec_enguague_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_frec_enguague_hcg = value
        End Set
    End Property

    Public Property p_hc_frec_fluor_hcg() As String
        Get
            Return Me.hc_frec_fluor_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_frec_fluor_hcg = value
        End Set
    End Property

    Public Property p_hc_frec_sellantes_hcg() As String
        Get
            Return Me.hc_frec_sellantes_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_frec_sellantes_hcg = value
        End Set
    End Property

    Public Property p_hc_observa_hcg() As String
        Get
            Return Me.hc_observa_hcg
        End Get
        Set(ByVal value As String)
            Me.hc_observa_hcg = value
        End Set
    End Property

    Public Property p_exa_comp_hcg() As String
        Get
            Return Me.exa_comp_hcg
        End Get
        Set(ByVal value As String)
            Me.exa_comp_hcg = value
        End Set
    End Property

    Public Property p_diag_psano_hcg() As String
        Get
            Return Me.diag_psano_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_psano_hcg = value
        End Set
    End Property

    Public Property p_diag_psanotipo_hcg() As String
        Get
            Return Me.diag_psanotipo_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_psanotipo_hcg = value
        End Set
    End Property

    Public Property p_diag_psanocod_hcg() As String
        Get
            Return Me.diag_psanocod_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_psanocod_hcg = value
        End Set
    End Property

    Public Property p_diag_tblandos_hcg() As String
        Get
            Return Me.diag_tblandos_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tblandos_hcg = value
        End Set
    End Property

    Public Property p_diag_tblandostipo_hcg() As String
        Get
            Return Me.diag_tblandostipo_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tblandostipo_hcg = value
        End Set
    End Property

    Public Property p_diag_tblandoscod_hcg() As String
        Get
            Return Me.diag_tblandoscod_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tblandoscod_hcg = value
        End Set
    End Property

    Public Property p_diag_atm_hcg() As String
        Get
            Return Me.diag_atm_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_atm_hcg = value
        End Set
    End Property

    Public Property p_diag_atmtipo_hcg() As String
        Get
            Return Me.diag_atmtipo_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_atmtipo_hcg = value
        End Set
    End Property

    Public Property p_diag_atmcod_hcg() As String
        Get
            Return Me.diag_atmcod_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_atmcod_hcg = value
        End Set
    End Property

    Public Property p_diag_tdental_hcg() As String
        Get
            Return Me.diag_tdental_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tdental_hcg = value
        End Set
    End Property

    Public Property p_diag_tdentaltipo_hcg() As String
        Get
            Return Me.diag_tdentaltipo_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tdentaltipo_hcg = value
        End Set
    End Property

    Public Property p_diag_tdentalcod_hcg() As String
        Get
            Return Me.diag_tdentalcod_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tdentalcod_hcg = value
        End Set
    End Property

    Public Property p_diag_tperio_hcg() As String
        Get
            Return Me.diag_tperio_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tperio_hcg = value
        End Set
    End Property

    Public Property p_diag_tperiotipo_hcg() As String
        Get
            Return Me.diag_tperiotipo_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tperiotipo_hcg = value
        End Set
    End Property

    Public Property p_diag_tperiocod_hcg() As String
        Get
            Return Me.diag_tperiocod_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tperiocod_hcg = value
        End Set
    End Property

    Public Property p_diag_tpulpar_hcg() As String
        Get
            Return Me.diag_tpulpar_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tpulpar_hcg = value
        End Set
    End Property

    Public Property p_diag_tpulpartipo_hcg() As String
        Get
            Return Me.diag_tpulpartipo_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tpulpartipo_hcg = value
        End Set
    End Property

    Public Property p_diag_tpulparcod_hcg() As String
        Get
            Return Me.diag_tpulparcod_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_tpulparcod_hcg = value
        End Set
    End Property

    Public Property p_diag_otros_hcg() As String
        Get
            Return Me.diag_otros_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_otros_hcg = value
        End Set
    End Property

    Public Property p_diag_otrostipo_hcg() As String
        Get
            Return Me.diag_otrostipo_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_otrostipo_hcg = value
        End Set
    End Property

    Public Property p_diag_otroscod_hcg() As String
        Get
            Return Me.diag_otroscod_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_otroscod_hcg = value
        End Set
    End Property

    Public Property p_diag_observa_hcg() As String
        Get
            Return Me.diag_observa_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_observa_hcg = value
        End Set
    End Property

    Public Property p_diag_remision_hcg() As String
        Get
            Return Me.diag_remision_hcg
        End Get
        Set(ByVal value As String)
            Me.diag_remision_hcg = value
        End Set
    End Property

    Public Property p_trata_promocion_hcg() As String
        Get
            Return Me.trata_promocion_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_promocion_hcg = value
        End Set
    End Property

    Public Property p_trata_prevencion_hcg() As String
        Get
            Return Me.trata_prevencion_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_prevencion_hcg = value
        End Set
    End Property

    Public Property p_trata_radiog_hcg() As String
        Get
            Return Me.trata_radiog_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_radiog_hcg = value
        End Set
    End Property

    Public Property p_trata_operatoria_hcg() As String
        Get
            Return Me.trata_operatoria_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_operatoria_hcg = value
        End Set
    End Property

    Public Property p_trata_endodoncia_hcg() As String
        Get
            Return Me.trata_endodoncia_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_endodoncia_hcg = value
        End Set
    End Property

    Public Property p_trata_perio_hcg() As String
        Get
            Return Me.trata_perio_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_perio_hcg = value
        End Set
    End Property

    Public Property p_trata_prosto_hcg() As String
        Get
            Return Me.trata_prosto_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_prosto_hcg = value
        End Set
    End Property

    Public Property p_trata_oclusion_hcg() As String
        Get
            Return Me.trata_oclusion_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_oclusion_hcg = value
        End Set
    End Property

    Public Property p_trata_cirugia_hcg() As String
        Get
            Return Me.trata_cirugia_hcg
        End Get
        Set(ByVal value As String)
            Me.trata_cirugia_hcg = value
        End Set
    End Property

    Public Property p_pronostico_hcg() As String
        Get
            Return Me.pronostico_hcg
        End Get
        Set(ByVal value As String)
            Me.pronostico_hcg = value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica_g WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.hclinica_g (IdUsuario, IdTUsuario, aconsulta_hcg, uconsulta_hcg, antecedentes_hcg, ant_temp_hcg, ant_pulsapm_hcg, ant_pulsaart_hcg, ant_fresp_hcg, ant_familiares_hcg, ant_observa_hcg, ef_tblandos_hcg, " _
            & "ef_atm_hcg, ef_tdentales_hcg, ef_exaperio_hcg, ef_exapulpar_hcg, ef_habitos_hcg, ef_observa_hcg, ef_hallazgos_hcg, hc_accionp_hcg, hc_frec_charlas_hcg, hc_frec_cepillado_hcg, hc_frec_seda_hcg, " _
            & "hc_frec_enguague_hcg, hc_frec_fluor_hcg, hc_frec_sellantes_hcg, hc_observa_hcg, exa_comp_hcg, diag_psano_hcg, diag_psanotipo_hcg, diag_psanocod_hcg, " _
            & "diag_tblandos_hcg, diag_tblandostipo_hcg, diag_tblandoscod_hcg, diag_atm_hcg, diag_atmtipo_hcg, diag_atmcod_hcg, diag_tdental_hcg, diag_tdentaltipo_hcg, diag_tdentalcod_hcg, diag_tperio_hcg, diag_tperiotipo_hcg, " _
            & "diag_tperiocod_hcg, diag_tpulpar_hcg, diag_tpulpartipo_hcg, diag_tpulparcod_hcg, diag_otros_hcg, diag_otrostipo_hcg, diag_otroscod_hcg, diag_observa_hcg, diag_remision_hcg, trata_promocion_hcg, trata_prevencion_hcg, " _
            & "trata_radiog_hcg, trata_operatoria_hcg, trata_endodoncia_hcg, trata_perio_hcg, trata_prosto_hcg, trata_oclusion_hcg, trata_cirugia_hcg, pronostico_hcg ) " _
            & "VALUES (" & Me.IdUsuario & ", " & Me.IdTUsuario & ", '" & Me.aconsulta_hcg & "', '" & Me.uconsulta_hcg & "', '" & Me.antecedentes_hcg & "', '" & Me.ant_temp_hcg & "', '" & Me.ant_pulsapm_hcg & "', '" & Me.ant_pulsaart_hcg & "', '" & Me.ant_fresp_hcg & "', '" & Me.ant_familiares_hcg & "', '" & Me.ant_observa_hcg & "', '" & Me.ef_tblandos_hcg & "', '" & Me.ef_atm_hcg & "', '" & Me.ef_tdentales_hcg & "', " _
            & "'" & Me.ef_exaperio_hcg & "', '" & Me.ef_exapulpar_hcg & "', '" & Me.ef_habitos_hcg & "', '" & Me.ef_observa_hcg & "', '" & Me.ef_hallazgos_hcg & "', '" & Me.hc_accionp_hcg & "', '" & Me.hc_frec_charlas_hcg & "', '" & Me.hc_frec_cepillado_hcg & "', '" & Me.hc_frec_seda_hcg & "', '" & Me.hc_frec_enguague_hcg & "', '" & Me.hc_frec_fluor_hcg & "', " _
            & "'" & Me.hc_frec_sellantes_hcg & "', '" & Me.hc_observa_hcg & "', '" & Me.exa_comp_hcg & "', '" & Me.diag_psano_hcg & "', '" & Me.diag_psanotipo_hcg & "', '" & Me.diag_psanocod_hcg & "', '" & Me.diag_tblandos_hcg & "', " _
            & "'" & Me.diag_tblandostipo_hcg & "', '" & Me.diag_tblandoscod_hcg & "', '" & Me.diag_atm_hcg & "', '" & Me.diag_atmtipo_hcg & "', '" & Me.diag_atmcod_hcg & "', '" & Me.diag_tdental_hcg & "', '" & Me.diag_tdentaltipo_hcg & "', '" & Me.diag_tdentalcod_hcg & "', '" & Me.diag_tperio_hcg & "', '" & Me.diag_tperiotipo_hcg & "', '" & Me.diag_tperiocod_hcg & "', " _
            & "'" & Me.diag_tpulpar_hcg & "', '" & Me.diag_tpulpartipo_hcg & "', '" & Me.diag_tpulparcod_hcg & "', '" & Me.diag_otros_hcg & "', '" & Me.diag_otrostipo_hcg & "', '" & Me.diag_otroscod_hcg & "', '" & Me.diag_observa_hcg & "', '" & Me.diag_remision_hcg & "', '" & Me.trata_promocion_hcg & "', '" & Me.trata_prevencion_hcg & "', '" & Me.trata_radiog_hcg & "', " _
            & "'" & Me.trata_operatoria_hcg & "', '" & Me.trata_endodoncia_hcg & "', '" & Me.trata_perio_hcg & "', '" & Me.trata_prosto_hcg & "', '" & Me.trata_oclusion_hcg & "', '" & Me.trata_cirugia_hcg & "', '" & Me.pronostico_hcg & "')"

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

            CLASE_GENERAL.sql = "UPDATE orthosoft.hclinica_g SET aconsulta_hcg = '" & Me.aconsulta_hcg & "', uconsulta_hcg = '" & Me.uconsulta_hcg & "', antecedentes_hcg = '" & Me.antecedentes_hcg & "' , ant_temp_hcg = '" & Me.ant_temp_hcg & "' , ant_pulsapm_hcg = '" & Me.ant_pulsapm_hcg & "' , ant_pulsaart_hcg = '" & Me.ant_pulsaart_hcg & "' , ant_fresp_hcg = '" & Me.ant_fresp_hcg & "' , ant_familiares_hcg = '" & Me.ant_familiares_hcg & "' , ant_observa_hcg = '" & Me.ant_observa_hcg & "' , ef_tblandos_hcg = '" & Me.ef_tblandos_hcg & "' , ef_atm_hcg = '" & Me.ef_atm_hcg & "' , " _
            & "ef_tdentales_hcg = '" & Me.ef_tdentales_hcg & "' , ef_exaperio_hcg = '" & Me.ef_exaperio_hcg & "' , ef_exapulpar_hcg = '" & Me.ef_exapulpar_hcg & "' , ef_habitos_hcg = '" & Me.ef_habitos_hcg & "' , ef_observa_hcg = '" & Me.ef_observa_hcg & "' , ef_hallazgos_hcg = '" & Me.ef_hallazgos_hcg & "' , hc_accionp_hcg = '" & Me.hc_accionp_hcg & "' , hc_frec_charlas_hcg = '" & Me.hc_frec_charlas_hcg & "' , hc_frec_cepillado_hcg = '" & Me.hc_frec_cepillado_hcg & "' , hc_frec_seda_hcg = '" & Me.hc_frec_seda_hcg & "' , " _
            & "hc_frec_enguague_hcg = '" & Me.hc_frec_enguague_hcg & "' , hc_frec_fluor_hcg = '" & Me.hc_frec_fluor_hcg & "' , hc_frec_sellantes_hcg = '" & Me.hc_frec_sellantes_hcg & "' , hc_observa_hcg = '" & Me.hc_observa_hcg & "' , exa_comp_hcg = '" & Me.exa_comp_hcg & "' , diag_psano_hcg = '" & Me.diag_psano_hcg & "' , diag_psanotipo_hcg = '" & Me.diag_psanotipo_hcg & "' , diag_psanocod_hcg = '" & Me.diag_psanocod_hcg & "' , " _
            & "diag_tblandos_hcg = '" & Me.diag_tblandos_hcg & "' , diag_tblandostipo_hcg = '" & Me.diag_tblandostipo_hcg & "' , diag_tblandoscod_hcg = '" & Me.diag_tblandoscod_hcg & "' , diag_atm_hcg = '" & Me.diag_atm_hcg & "' , diag_atmtipo_hcg = '" & Me.diag_atmtipo_hcg & "' , diag_atmcod_hcg = '" & Me.diag_atmcod_hcg & "' , diag_tdental_hcg = '" & Me.diag_tdental_hcg & "' , diag_tdentaltipo_hcg = '" & Me.diag_tdentaltipo_hcg & "' , diag_tdentalcod_hcg = '" & Me.diag_tdentalcod_hcg & "' , diag_tperio_hcg = '" & Me.diag_tperio_hcg & "' , " _
            & "diag_tperiotipo_hcg = '" & Me.diag_tperiotipo_hcg & "' , diag_tperiocod_hcg = '" & Me.diag_tperiocod_hcg & "' , diag_tpulpar_hcg = '" & Me.diag_tpulpar_hcg & "' , diag_tpulpartipo_hcg = '" & Me.diag_tpulpartipo_hcg & "' , diag_tpulparcod_hcg = '" & Me.diag_tpulparcod_hcg & "' , diag_otros_hcg = '" & Me.diag_otros_hcg & "' , diag_otrostipo_hcg = '" & Me.diag_otrostipo_hcg & "' , diag_otroscod_hcg = '" & Me.diag_otroscod_hcg & "' , diag_observa_hcg = '" & Me.diag_observa_hcg & "' , diag_remision_hcg = '" & Me.diag_remision_hcg & "' , " _
            & "trata_promocion_hcg = '" & Me.trata_promocion_hcg & "' , trata_prevencion_hcg = '" & Me.trata_prevencion_hcg & "' , trata_radiog_hcg = '" & Me.trata_radiog_hcg & "' , trata_operatoria_hcg = '" & Me.trata_operatoria_hcg & "' , trata_endodoncia_hcg = '" & Me.trata_endodoncia_hcg & "' , trata_perio_hcg = '" & Me.trata_perio_hcg & "' , trata_prosto_hcg = '" & Me.trata_prosto_hcg & "' , trata_oclusion_hcg = '" & Me.trata_oclusion_hcg & "' , trata_cirugia_hcg = '" & Me.trata_cirugia_hcg & "' , " _
            & "pronostico_hcg = '" & Me.pronostico_hcg & "' " _
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

                    CLASE_GENERAL.sql = "SELECT * FROM Orthosoft.hclinica_g " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")

                        xaconsulta_hcg = CLASE_GENERAL.xdr("aconsulta_hcg")
                        xuconsulta_hcg = CLASE_GENERAL.xdr("uconsulta_hcg")
                        xantecedentes_hcg = CLASE_GENERAL.xdr("antecedentes_hcg")
                        xant_temp_hcg = CLASE_GENERAL.xdr("ant_temp_hcg")
                        xant_pulsapm_hcg = CLASE_GENERAL.xdr("ant_pulsapm_hcg")
                        xant_pulsaart_hcg = CLASE_GENERAL.xdr("ant_pulsaart_hcg")
                        xant_fresp_hcg = CLASE_GENERAL.xdr("ant_fresp_hcg")
                        xant_familiares_hcg = CLASE_GENERAL.xdr("ant_familiares_hcg")
                        xant_observa_hcg = CLASE_GENERAL.xdr("ant_observa_hcg")
                        xef_tblandos_hcg = CLASE_GENERAL.xdr("ef_tblandos_hcg")
                        xef_atm_hcg = CLASE_GENERAL.xdr("ef_atm_hcg")
                        xef_tdentales_hcg = CLASE_GENERAL.xdr("ef_tdentales_hcg")
                        xef_exaperio_hcg = CLASE_GENERAL.xdr("ef_exaperio_hcg")
                        xef_exapulpar_hcg = CLASE_GENERAL.xdr("ef_exapulpar_hcg")
                        xef_habitos_hcg = CLASE_GENERAL.xdr("ef_habitos_hcg")
                        xef_observa_hcg = CLASE_GENERAL.xdr("ef_observa_hcg")
                        xef_hallazgos_hcg = CLASE_GENERAL.xdr("ef_hallazgos_hcg")
                        xhc_accionp_hcg = CLASE_GENERAL.xdr("hc_accionp_hcg")

                        xhc_frec_charlas_hcg = CLASE_GENERAL.xdr("hc_frec_charlas_hcg")
                        xhc_frec_cepillado_hcg = CLASE_GENERAL.xdr("hc_frec_cepillado_hcg")
                        xhc_frec_seda_hcg = CLASE_GENERAL.xdr("hc_frec_seda_hcg")
                        xhc_frec_enguague_hcg = CLASE_GENERAL.xdr("hc_frec_enguague_hcg")
                        xhc_frec_fluor_hcg = CLASE_GENERAL.xdr("hc_frec_fluor_hcg")
                        xhc_frec_sellantes_hcg = CLASE_GENERAL.xdr("hc_frec_sellantes_hcg")

                        xhc_observa_hcg = CLASE_GENERAL.xdr("hc_observa_hcg")
                        xexa_comp_hcg = CLASE_GENERAL.xdr("exa_comp_hcg")
                        xdiag_psano_hcg = CLASE_GENERAL.xdr("diag_psano_hcg")
                        xdiag_psanotipo_hcg = CLASE_GENERAL.xdr("diag_psanotipo_hcg")
                        xdiag_psanocod_hcg = CLASE_GENERAL.xdr("diag_psanocod_hcg")
                        xdiag_tblandos_hcg = CLASE_GENERAL.xdr("diag_tblandos_hcg")
                        xdiag_tblandostipo_hcg = CLASE_GENERAL.xdr("diag_tblandostipo_hcg")
                        xdiag_tblandoscod_hcg = CLASE_GENERAL.xdr("diag_tblandoscod_hcg")
                        xdiag_atm_hcg = CLASE_GENERAL.xdr("diag_atm_hcg")
                        xdiag_atmtipo_hcg = CLASE_GENERAL.xdr("diag_atmtipo_hcg")
                        xdiag_atmcod_hcg = CLASE_GENERAL.xdr("diag_atmcod_hcg")
                        xdiag_tdental_hcg = CLASE_GENERAL.xdr("diag_tdental_hcg")
                        xdiag_tdentaltipo_hcg = CLASE_GENERAL.xdr("diag_tdentaltipo_hcg")
                        xdiag_tdentalcod_hcg = CLASE_GENERAL.xdr("diag_tdentalcod_hcg")
                        xdiag_tperio_hcg = CLASE_GENERAL.xdr("diag_tperio_hcg")
                        xdiag_tperiotipo_hcg = CLASE_GENERAL.xdr("diag_tperiotipo_hcg")
                        xdiag_tperiocod_hcg = CLASE_GENERAL.xdr("diag_tperiocod_hcg")
                        xdiag_tpulpar_hcg = CLASE_GENERAL.xdr("diag_tpulpar_hcg")
                        xdiag_tpulpartipo_hcg = CLASE_GENERAL.xdr("diag_tpulpartipo_hcg")
                        xdiag_tpulparcod_hcg = CLASE_GENERAL.xdr("diag_tpulparcod_hcg")
                        xdiag_otros_hcg = CLASE_GENERAL.xdr("diag_otros_hcg")
                        xdiag_otrostipo_hcg = CLASE_GENERAL.xdr("diag_otrostipo_hcg")
                        xdiag_otroscod_hcg = CLASE_GENERAL.xdr("diag_otroscod_hcg")
                        xdiag_observa_hcg = CLASE_GENERAL.xdr("diag_observa_hcg")
                        xdiag_remision_hcg = CLASE_GENERAL.xdr("diag_remision_hcg")
                        xtrata_promocion_hcg = CLASE_GENERAL.xdr("trata_promocion_hcg")
                        xtrata_prevencion_hcg = CLASE_GENERAL.xdr("trata_prevencion_hcg")
                        xtrata_radiog_hcg = CLASE_GENERAL.xdr("trata_radiog_hcg")
                        xtrata_operatoria_hcg = CLASE_GENERAL.xdr("trata_operatoria_hcg")
                        xtrata_endodoncia_hcg = CLASE_GENERAL.xdr("trata_endodoncia_hcg")
                        xtrata_perio_hcg = CLASE_GENERAL.xdr("trata_perio_hcg")
                        xtrata_prosto_hcg = CLASE_GENERAL.xdr("trata_prosto_hcg")
                        xtrata_oclusion_hcg = CLASE_GENERAL.xdr("trata_oclusion_hcg")
                        xtrata_cirugia_hcg = CLASE_GENERAL.xdr("trata_cirugia_hcg")
                        xpronostico_hcg = CLASE_GENERAL.xdr("pronostico_hcg")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

                Case "impresion"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT consultorio.Idconsultorio, consultorio.razonsocial_cons, consultorio.nit_cons  , consultorio.direccion_cons, consultorio.ciudad_cons, consultorio.web_cons, consultorio.email_cons, consultorio.rtelegal_cons, consultorio.profesionrlegal_cons, consultorio.documento_cons, consultorio.ciudaddoc_cons, consultorio.actividad_cons, " _
                    & "consultorio.tel1_cons, consultorio.celular_cons, consultorio.icono_cons, Idpaciente, pacientes.nhclinica, pacientes.nombres_pac, pacientes.apellidos_pac, estadocivil.nom_estadocivil, pacientes.fecnac_pac, pacientes.lugarnac_pac, pacientes.referidopor_pac, pacientes.sexo_pac, pacientes.tipodoc_pac, pacientes.numdoc_pac, pacientes.dedoc_pac, " _
                    & "pacientes.fecingreso_pac, pacientes.residencia_pac, pacientes.ocupacion_pac, pacientes.oficina_pac, pacientes.zona_pac, pacientes.municipio_pac, pacientes.dep_pac, pacientes.rh_pac,  " _
                    & "entidades.nombre_ent, entidades.codigo_ent, hclinica_g.*, ograma.observacionograma_ini, ograma.observacionograma_act, ograma.ograma_inicial, ograma.ograma_actual, ograma.oleary_inicial, ograma.oleary_actual, ograma.fecha_ograma FROM Orthosoft.consultorio " _
                    & "INNER JOIN orthosoft.pacientes ON (consultorio.Idconsultorio = pacientes.Idconsultorio) " _
                    & "INNER JOIN orthosoft.entidades ON (pacientes.Identidad = entidades.Identidad) " _
                    & "INNER JOIN orthosoft.estadocivil ON (pacientes.estadocivil_pac = estadocivil.Idestadocivil) " _
                    & "INNER JOIN orthosoft.hclinica_g  ON (pacientes.Idpaciente = hclinica_g.IdUsuario) " _
                    & "INNER JOIN orthosoft.ograma ON (pacientes.Idpaciente = ograma.IdUsuario) " _
                    & "WHERE Idpaciente = " & Me.IdUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("d:\varios\historiageneral.xml", XmlWriteMode.WriteSchema)

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
