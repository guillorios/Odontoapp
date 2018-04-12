Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA_ORTO2

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xenfermedadanterior_horto2 As String
    Public Shared xtratamedico_horto2 As String
    Public Shared xpatologias_horto2 As String
    Public Shared xalergiasotros_horto2 As String
    Public Shared xcresimientodesarrollo_horto2 As String
    Public Shared xantecedentes_horto2 As String
    Public Shared xefacial_frente_horto2 As String
    Public Shared xefacial_labios_horto2 As String
    Public Shared xefacial_lineasonr_horto2 As String
    Public Shared xefacial_selladolabial_horto2 As String
    Public Shared xefacial_perfil_horto2 As String
    Public Shared xefacial_menton_horto2 As String
    Public Shared xefacial_angulonaso_horto2 As String
    Public Shared xefacial_surcolabio_horto2 As String
    Public Shared xefacial_otros_horto2 As String
    Public Shared xeoral_tejidosblandos_horto2 As String
    Public Shared xeoral_rehabilitacion_horto2 As String
    Public Shared xeoral_endodoncia_horto2 As String
    Public Shared xeoral_periodoncia_horto2 As String
    Public Shared xeoral_dientesausentes_horto2 As String
    Public Shared xeoral_dientesincluidos_horto2 As String
    Public Shared xeoral_examendental_horto2 As String
    Public Shared xeoral_apinamiento_horto2 As String
    Public Shared xeoral_diastemas_horto2 As String
    Public Shared xeoral_overjet_horto2 As String
    Public Shared xeoral_overbite_horto2 As String
    Public Shared xeoral_lineamedia_horto2 As String
    Public Shared xeoral_tamdentario_horto2 As String
    Public Shared xeoral_formaarcada_horto2 As String
    Public Shared xeoral_mordidacruzada_horto2 As String
    Public Shared xeoral_curvaspee_horto2 As String
    Public Shared xeoral_claseangle_horto2 As String
    Public Shared xeoral_bolton_horto2 As String
    Public Shared xeoral_habitos_horto2 As String
    Public Shared xeoral_atm_horto2 As String
    Public Shared xeoral_manipulacion_horto2 As String
    Public Shared xeoral_otros_horto2 As String
    Public Shared xodonto_analisisespacio_horto2 As String
    Public Shared xeesque_sna_inicial_horto2 As String
    Public Shared xeesque_sna_control_horto2 As String
    Public Shared xeesque_sna_final_horto2 As String
    Public Shared xeesque_snb_inicial_horto2 As String
    Public Shared xeesque_snb_control_horto2 As String
    Public Shared xeesque_snb_final_horto2 As String
    Public Shared xeesque_anb_inicial_horto2 As String
    Public Shared xeesque_anb_control_horto2 As String
    Public Shared xeesque_anb_final_horto2 As String
    Public Shared xeesque_1pp_inicial_horto2 As String
    Public Shared xeesque_1pp_control_horto2 As String
    Public Shared xeesque_1pp_final_horto2 As String
    Public Shared xeesque_1pm_inicial_horto2 As String
    Public Shared xeesque_1pm_control_horto2 As String
    Public Shared xeesque_1pm_final_horto2 As String
    Public Shared xeesque_go_inicial_horto2 As String
    Public Shared xeesque_go_control_horto2 As String
    Public Shared xeesque_go_final_horto2 As String
    Public Shared xeesque_max_inicial_horto2 As String
    Public Shared xeesque_max_control_horto2 As String
    Public Shared xeesque_max_final_horto2 As String
    Public Shared xeesque_otros_inicial_horto2 As String
    Public Shared xeesque_otros_control_horto2 As String
    Public Shared xeesque_otros_final_horto2 As String
    Public Shared xreg_modelos_inicial_horto2 As String
    Public Shared xreg_modelos_control_horto2 As String
    Public Shared xreg_modelos_final_horto2 As String
    Public Shared xreg_pano_inicial_horto2 As String
    Public Shared xreg_pano_control_horto2 As String
    Public Shared xreg_pano_final_horto2 As String
    Public Shared xreg_perfil_inicial_horto2 As String
    Public Shared xreg_perfil_control_horto2 As String
    Public Shared xreg_perfil_final_horto2 As String
    Public Shared xreg_intra_inicial_horto2 As String
    Public Shared xreg_intra_control_horto2 As String
    Public Shared xreg_intra_final_horto2 As String
    Public Shared xreg_extra_inicial_horto2 As String
    Public Shared xreg_extra_control_horto2 As String
    Public Shared xreg_extra_final_horto2 As String
    Public Shared xreg_otras_inicial_horto2 As String
    Public Shared xreg_otras_control_horto2 As String
    Public Shared xreg_otras_final_horto2 As String
    Public Shared xdiag_facial_horto2 As String
    Public Shared xdiag_esque_horto2 As String
    Public Shared xdiag_dental_horto2 As String
    Public Shared xplantratamiento_horto2 As String
    Public Shared xalternativas_horto2 As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private enfermedadanterior_horto2 As String
    Private tratamedico_horto2 As String
    Private patologias_horto2 As String
    Private alergiasotros_horto2 As String
    Private cresimientodesarrollo_horto2 As String
    Private antecedentes_horto2 As String
    Private efacial_frente_horto2 As String
    Private efacial_labios_horto2 As String
    Private efacial_lineasonr_horto2 As String
    Private efacial_selladolabial_horto2 As String
    Private efacial_perfil_horto2 As String
    Private efacial_menton_horto2 As String
    Private efacial_angulonaso_horto2 As String
    Private efacial_surcolabio_horto2 As String
    Private efacial_otros_horto2 As String
    Private eoral_tejidosblandos_horto2 As String
    Private eoral_rehabilitacion_horto2 As String
    Private eoral_endodoncia_horto2 As String
    Private eoral_periodoncia_horto2 As String
    Private eoral_dientesausentes_horto2 As String
    Private eoral_dientesincluidos_horto2 As String
    Private eoral_examendental_horto2 As String
    Private eoral_apinamiento_horto2 As String
    Private eoral_diastemas_horto2 As String
    Private eoral_overjet_horto2 As String
    Private eoral_overbite_horto2 As String
    Private eoral_lineamedia_horto2 As String
    Private eoral_tamdentario_horto2 As String
    Private eoral_formaarcada_horto2 As String
    Private eoral_mordidacruzada_horto2 As String
    Private eoral_curvaspee_horto2 As String
    Private eoral_claseangle_horto2 As String
    Private eoral_bolton_horto2 As String
    Private eoral_habitos_horto2 As String
    Private eoral_atm_horto2 As String
    Private eoral_manipulacion_horto2 As String
    Private eoral_otros_horto2 As String
    Private odonto_analisisespacio_horto2 As String
    Private eesque_sna_inicial_horto2 As String
    Private eesque_sna_control_horto2 As String
    Private eesque_sna_final_horto2 As String
    Private eesque_snb_inicial_horto2 As String
    Private eesque_snb_control_horto2 As String
    Private eesque_snb_final_horto2 As String
    Private eesque_anb_inicial_horto2 As String
    Private eesque_anb_control_horto2 As String
    Private eesque_anb_final_horto2 As String
    Private eesque_1pp_inicial_horto2 As String
    Private eesque_1pp_control_horto2 As String
    Private eesque_1pp_final_horto2 As String
    Private eesque_1pm_inicial_horto2 As String
    Private eesque_1pm_control_horto2 As String
    Private eesque_1pm_final_horto2 As String
    Private eesque_go_inicial_horto2 As String
    Private eesque_go_control_horto2 As String
    Private eesque_go_final_horto2 As String
    Private eesque_max_inicial_horto2 As String
    Private eesque_max_control_horto2 As String
    Private eesque_max_final_horto2 As String
    Private eesque_otros_inicial_horto2 As String
    Private eesque_otros_control_horto2 As String
    Private eesque_otros_final_horto2 As String
    Private reg_modelos_inicial_horto2 As String
    Private reg_modelos_control_horto2 As String
    Private reg_modelos_final_horto2 As String
    Private reg_pano_inicial_horto2 As String
    Private reg_pano_control_horto2 As String
    Private reg_pano_final_horto2 As String
    Private reg_perfil_inicial_horto2 As String
    Private reg_perfil_control_horto2 As String
    Private reg_perfil_final_horto2 As String
    Private reg_intra_inicial_horto2 As String
    Private reg_intra_control_horto2 As String
    Private reg_intra_final_horto2 As String
    Private reg_extra_inicial_horto2 As String
    Private reg_extra_control_horto2 As String
    Private reg_extra_final_horto2 As String
    Private reg_otras_inicial_horto2 As String
    Private reg_otras_control_horto2 As String
    Private reg_otras_final_horto2 As String
    Private diag_facial_horto2 As String
    Private diag_esque_horto2 As String
    Private diag_dental_horto2 As String
    Private plantratamiento_horto2 As String
    Private alternativas_horto2 As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0

        Me.enfermedadanterior_horto2 = ""
        Me.tratamedico_horto2 = ""
        Me.patologias_horto2 = ""

        Me.alergiasotros_horto2 = ""
        Me.cresimientodesarrollo_horto2 = ""
        Me.antecedentes_horto2 = ""

        Me.efacial_frente_horto2 = ""
        Me.efacial_labios_horto2 = ""
        Me.efacial_lineasonr_horto2 = ""
        Me.efacial_selladolabial_horto2 = ""
        Me.efacial_perfil_horto2 = ""
        Me.efacial_menton_horto2 = ""
        Me.efacial_angulonaso_horto2 = ""
        Me.efacial_surcolabio_horto2 = ""
        Me.efacial_otros_horto2 = ""

        Me.eoral_tejidosblandos_horto2 = ""
        Me.eoral_rehabilitacion_horto2 = ""
        Me.eoral_endodoncia_horto2 = ""
        Me.eoral_periodoncia_horto2 = ""
        Me.eoral_dientesausentes_horto2 = ""
        Me.eoral_dientesincluidos_horto2 = ""

        Me.eoral_examendental_horto2 = ""

        Me.eoral_apinamiento_horto2 = ""
        Me.eoral_diastemas_horto2 = ""
        Me.eoral_overjet_horto2 = ""
        Me.eoral_overbite_horto2 = ""
        Me.eoral_lineamedia_horto2 = ""
        Me.eoral_tamdentario_horto2 = ""
        Me.eoral_formaarcada_horto2 = ""
        Me.eoral_mordidacruzada_horto2 = ""
        Me.eoral_curvaspee_horto2 = ""
        Me.eoral_claseangle_horto2 = ""
        Me.eoral_bolton_horto2 = ""
        Me.eoral_habitos_horto2 = ""
        Me.eoral_atm_horto2 = ""
        Me.eoral_manipulacion_horto2 = ""
        Me.eoral_otros_horto2 = ""

        Me.odonto_analisisespacio_horto2 = ""

        Me.eesque_sna_inicial_horto2 = ""
        Me.eesque_sna_control_horto2 = ""
        Me.eesque_sna_final_horto2 = ""
        Me.eesque_snb_inicial_horto2 = ""
        Me.eesque_snb_control_horto2 = ""
        Me.eesque_snb_final_horto2 = ""
        Me.eesque_anb_inicial_horto2 = ""
        Me.eesque_anb_control_horto2 = ""
        Me.eesque_anb_final_horto2 = ""
        Me.eesque_1pp_inicial_horto2 = ""
        Me.eesque_1pp_control_horto2 = ""
        Me.eesque_1pp_final_horto2 = ""
        Me.eesque_1pm_inicial_horto2 = ""
        Me.eesque_1pm_control_horto2 = ""
        Me.eesque_1pm_final_horto2 = ""
        Me.eesque_go_inicial_horto2 = ""
        Me.eesque_go_control_horto2 = ""
        Me.eesque_go_final_horto2 = ""
        Me.eesque_max_inicial_horto2 = ""
        Me.eesque_max_control_horto2 = ""
        Me.eesque_max_final_horto2 = ""
        Me.eesque_otros_inicial_horto2 = ""
        Me.eesque_otros_control_horto2 = ""
        Me.eesque_otros_final_horto2 = ""

        Me.reg_modelos_inicial_horto2 = ""
        Me.reg_modelos_control_horto2 = ""
        Me.reg_modelos_final_horto2 = ""
        Me.reg_pano_inicial_horto2 = ""
        Me.reg_pano_control_horto2 = ""
        Me.reg_pano_final_horto2 = ""
        Me.reg_perfil_inicial_horto2 = ""
        Me.reg_perfil_control_horto2 = ""
        Me.reg_perfil_final_horto2 = ""
        Me.reg_intra_inicial_horto2 = ""
        Me.reg_intra_control_horto2 = ""
        Me.reg_intra_final_horto2 = ""
        Me.reg_extra_inicial_horto2 = ""
        Me.reg_extra_control_horto2 = ""
        Me.reg_extra_final_horto2 = ""
        Me.reg_otras_inicial_horto2 = ""
        Me.reg_otras_control_horto2 = ""
        Me.reg_otras_final_horto2 = ""

        Me.diag_facial_horto2 = ""
        Me.diag_esque_horto2 = ""
        Me.diag_dental_horto2 = ""

        Me.plantratamiento_horto2 = ""

        Me.alternativas_horto2 = ""

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

    Public Property p_enfermedadanterior_horto2() As String
        Get
            Return Me.enfermedadanterior_horto2
        End Get
        Set(ByVal value As String)
            Me.enfermedadanterior_horto2 = value
        End Set
    End Property

    Public Property p_tratamedico_horto2() As String
        Get
            Return Me.tratamedico_horto2
        End Get
        Set(ByVal value As String)
            Me.tratamedico_horto2 = value
        End Set
    End Property

    Public Property p_patologias_horto2() As String
        Get
            Return Me.patologias_horto2
        End Get
        Set(ByVal value As String)
            Me.patologias_horto2 = value
        End Set
    End Property

    Public Property p_alergiasotros_horto2() As String
        Get
            Return Me.alergiasotros_horto2
        End Get
        Set(ByVal value As String)
            Me.alergiasotros_horto2 = value
        End Set
    End Property

    Public Property p_cresimientodesarrollo_horto2() As String
        Get
            Return Me.cresimientodesarrollo_horto2
        End Get
        Set(ByVal value As String)
            Me.cresimientodesarrollo_horto2 = value
        End Set
    End Property

    Public Property p_antecedentes_horto2() As String
        Get
            Return Me.antecedentes_horto2
        End Get
        Set(ByVal value As String)
            Me.antecedentes_horto2 = value
        End Set
    End Property

    Public Property p_efacial_frente_horto2() As String
        Get
            Return Me.efacial_frente_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_frente_horto2 = value
        End Set
    End Property

    Public Property p_efacial_labios_horto2() As String
        Get
            Return Me.efacial_labios_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_labios_horto2 = value
        End Set
    End Property

    Public Property p_Efacial_lineasonr_horto2() As String
        Get
            Return Me.Efacial_lineasonr_horto2
        End Get
        Set(ByVal value As String)
            Me.Efacial_lineasonr_horto2 = value
        End Set
    End Property

    Public Property p_efacial_selladolabial_horto2() As String
        Get
            Return Me.efacial_selladolabial_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_selladolabial_horto2 = value
        End Set
    End Property

    Public Property p_efacial_perfil_horto2() As String
        Get
            Return Me.efacial_perfil_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_perfil_horto2 = value
        End Set
    End Property

    Public Property p_efacial_menton_horto2() As String
        Get
            Return Me.efacial_menton_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_menton_horto2 = value
        End Set
    End Property

    Public Property p_efacial_angulonaso_horto2() As String
        Get
            Return Me.efacial_angulonaso_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_angulonaso_horto2 = value
        End Set
    End Property

    Public Property p_efacial_surcolabio_horto2() As String
        Get
            Return Me.efacial_surcolabio_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_surcolabio_horto2 = value
        End Set
    End Property

    Public Property p_efacial_otros_horto2() As String
        Get
            Return Me.efacial_otros_horto2
        End Get
        Set(ByVal value As String)
            Me.efacial_otros_horto2 = value
        End Set
    End Property

    Public Property p_eoral_tejidosblandos_horto2() As String
        Get
            Return Me.eoral_tejidosblandos_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_tejidosblandos_horto2 = value
        End Set
    End Property

    Public Property p_eoral_rehabilitacion_horto2() As String
        Get
            Return Me.eoral_rehabilitacion_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_rehabilitacion_horto2 = value
        End Set
    End Property

    Public Property p_eoral_endodoncia_horto2() As String
        Get
            Return Me.eoral_endodoncia_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_endodoncia_horto2 = value
        End Set
    End Property

    Public Property p_eoral_periodoncia_horto2() As String
        Get
            Return Me.eoral_periodoncia_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_periodoncia_horto2 = value
        End Set
    End Property

    Public Property p_eoral_dientesausentes_horto2() As String
        Get
            Return Me.eoral_dientesausentes_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_dientesausentes_horto2 = value
        End Set
    End Property

    Public Property p_eoral_dientesincluidos_horto2() As String
        Get
            Return Me.eoral_dientesincluidos_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_dientesincluidos_horto2 = value
        End Set
    End Property

    Public Property p_eoral_examendental_horto2() As String
        Get
            Return Me.eoral_examendental_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_examendental_horto2 = value
        End Set
    End Property

    Public Property p_eoral_apinamiento_horto2() As String
        Get
            Return Me.eoral_apinamiento_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_apinamiento_horto2 = value
        End Set
    End Property

    Public Property p_eoral_diastemas_horto2() As String
        Get
            Return Me.eoral_diastemas_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_diastemas_horto2 = value
        End Set
    End Property

    Public Property p_eoral_overjet_horto2() As String
        Get
            Return Me.eoral_overjet_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_overjet_horto2 = value
        End Set
    End Property

    Public Property p_eoral_overbite_horto2() As String
        Get
            Return Me.eoral_overbite_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_overbite_horto2 = value
        End Set
    End Property

    Public Property p_eoral_lineamedia_horto2() As String
        Get
            Return Me.eoral_lineamedia_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_lineamedia_horto2 = value
        End Set
    End Property

    Public Property p_eoral_tamdentario_horto2() As String
        Get
            Return Me.eoral_tamdentario_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_tamdentario_horto2 = value
        End Set
    End Property

    Public Property p_eoral_formaarcada_horto2() As String
        Get
            Return Me.eoral_formaarcada_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_formaarcada_horto2 = value
        End Set
    End Property

    Public Property p_eoral_mordidacruzada_horto2() As String
        Get
            Return Me.eoral_mordidacruzada_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_mordidacruzada_horto2 = value
        End Set
    End Property

    Public Property p_eoral_curvaspee_horto2() As String
        Get
            Return Me.eoral_curvaspee_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_curvaspee_horto2 = value
        End Set
    End Property

    Public Property p_eoral_claseangle_horto2() As String
        Get
            Return Me.eoral_claseangle_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_claseangle_horto2 = value
        End Set
    End Property

    Public Property p_eoral_bolton_horto2() As String
        Get
            Return Me.eoral_bolton_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_bolton_horto2 = value
        End Set
    End Property

    Public Property p_eoral_habitos_horto2() As String
        Get
            Return Me.eoral_habitos_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_habitos_horto2 = value
        End Set
    End Property

    Public Property p_eoral_atm_horto2() As String
        Get
            Return Me.eoral_atm_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_atm_horto2 = value
        End Set
    End Property

    Public Property p_eoral_manipulacion_horto2() As String
        Get
            Return Me.eoral_manipulacion_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_manipulacion_horto2 = value
        End Set
    End Property

    Public Property p_eoral_otros_horto2() As String
        Get
            Return Me.eoral_otros_horto2
        End Get
        Set(ByVal value As String)
            Me.eoral_otros_horto2 = value
        End Set
    End Property

    Public Property p_odonto_analisisespacio_horto2() As String
        Get
            Return Me.odonto_analisisespacio_horto2
        End Get
        Set(ByVal value As String)
            Me.odonto_analisisespacio_horto2 = value
        End Set
    End Property

    Public Property p_eesque_sna_inicial_horto2() As String
        Get
            Return Me.eesque_sna_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_sna_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_sna_control_horto2() As String
        Get
            Return Me.eesque_sna_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_sna_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_sna_final_horto2() As String
        Get
            Return Me.eesque_sna_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_sna_final_horto2 = value
        End Set
    End Property

    Public Property p_eesque_snb_inicial_horto2() As String
        Get
            Return Me.eesque_snb_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_snb_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_snb_control_horto2() As String
        Get
            Return Me.eesque_snb_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_snb_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_snb_final_horto2() As String
        Get
            Return Me.eesque_snb_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_snb_final_horto2 = value
        End Set
    End Property

    Public Property p_eesque_anb_inicial_horto2() As String
        Get
            Return Me.eesque_anb_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_anb_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_anb_control_horto2() As String
        Get
            Return Me.eesque_anb_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_anb_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_anb_final_horto2() As String
        Get
            Return Me.eesque_anb_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_anb_final_horto2 = value
        End Set
    End Property

    Public Property p_eesque_1pp_inicial_horto2() As String
        Get
            Return Me.eesque_1pp_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_1pp_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_1pp_control_horto2() As String
        Get
            Return Me.eesque_1pp_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_1pp_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_1pp_final_horto2() As String
        Get
            Return Me.eesque_1pp_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_1pp_final_horto2 = value
        End Set
    End Property

    Public Property p_eesque_1pm_inicial_horto2() As String
        Get
            Return Me.eesque_1pm_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_1pm_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_1pm_control_horto2() As String
        Get
            Return Me.eesque_1pm_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_1pm_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_1pm_final_horto2() As String
        Get
            Return Me.eesque_1pm_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_1pm_final_horto2 = value
        End Set
    End Property

    Public Property p_eesque_go_inicial_horto2() As String
        Get
            Return Me.eesque_go_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_go_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_go_control_horto2() As String
        Get
            Return Me.eesque_go_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_go_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_go_final_horto2() As String
        Get
            Return Me.eesque_go_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_go_final_horto2 = value
        End Set
    End Property

    Public Property p_eesque_max_inicial_horto2() As String
        Get
            Return Me.eesque_max_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_max_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_max_control_horto2() As String
        Get
            Return Me.eesque_max_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_max_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_max_final_horto2() As String
        Get
            Return Me.eesque_max_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_max_final_horto2 = value
        End Set
    End Property

    Public Property p_eesque_otros_inicial_horto2() As String
        Get
            Return Me.eesque_otros_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_otros_inicial_horto2 = value
        End Set
    End Property

    Public Property p_eesque_otros_control_horto2() As String
        Get
            Return Me.eesque_otros_control_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_otros_control_horto2 = value
        End Set
    End Property

    Public Property p_eesque_otros_final_horto2() As String
        Get
            Return Me.eesque_otros_final_horto2
        End Get
        Set(ByVal value As String)
            Me.eesque_otros_final_horto2 = value
        End Set
    End Property

    Public Property p_reg_modelos_inicial_horto2() As String
        Get
            Return Me.reg_modelos_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_modelos_inicial_horto2 = value
        End Set
    End Property

    Public Property p_reg_modelos_control_horto2() As String
        Get
            Return Me.reg_modelos_control_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_modelos_control_horto2 = value
        End Set
    End Property

    Public Property p_reg_modelos_final_horto2() As String
        Get
            Return Me.reg_modelos_final_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_modelos_final_horto2 = value
        End Set
    End Property

    Public Property p_reg_pano_inicial_horto2() As String
        Get
            Return Me.reg_pano_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_pano_inicial_horto2 = value
        End Set
    End Property

    Public Property p_reg_pano_control_horto2() As String
        Get
            Return Me.reg_pano_control_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_pano_control_horto2 = value
        End Set
    End Property

    Public Property p_reg_pano_final_horto2() As String
        Get
            Return Me.reg_pano_final_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_pano_final_horto2 = value
        End Set
    End Property

    Public Property p_reg_perfil_inicial_horto2() As String
        Get
            Return Me.reg_perfil_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_perfil_inicial_horto2 = value
        End Set
    End Property

    Public Property p_reg_perfil_control_horto2() As String
        Get
            Return Me.reg_perfil_control_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_perfil_control_horto2 = value
        End Set
    End Property

    Public Property p_reg_perfil_final_horto2() As String
        Get
            Return Me.reg_perfil_final_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_perfil_final_horto2 = value
        End Set
    End Property

    Public Property p_reg_intra_inicial_horto2() As String
        Get
            Return Me.reg_intra_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_intra_inicial_horto2 = value
        End Set
    End Property

    Public Property p_reg_intra_control_horto2() As String
        Get
            Return Me.reg_intra_control_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_intra_control_horto2 = value
        End Set
    End Property

    Public Property p_reg_intra_final_horto2() As String
        Get
            Return Me.reg_intra_final_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_intra_final_horto2 = value
        End Set
    End Property

    Public Property p_reg_extra_inicial_horto2() As String
        Get
            Return Me.reg_extra_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_extra_inicial_horto2 = value
        End Set
    End Property

    Public Property p_reg_extra_control_horto2() As String
        Get
            Return Me.reg_extra_control_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_extra_control_horto2 = value
        End Set
    End Property

    Public Property p_reg_extra_final_horto2() As String
        Get
            Return Me.reg_extra_final_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_extra_final_horto2 = value
        End Set
    End Property

    Public Property p_reg_otras_inicial_horto2() As String
        Get
            Return Me.reg_otras_inicial_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_otras_inicial_horto2 = value
        End Set
    End Property

    Public Property p_reg_otras_control_horto2() As String
        Get
            Return Me.reg_otras_control_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_otras_control_horto2 = value
        End Set
    End Property

    Public Property p_reg_otras_final_horto2() As String
        Get
            Return Me.reg_otras_final_horto2
        End Get
        Set(ByVal value As String)
            Me.reg_otras_final_horto2 = value
        End Set
    End Property

    Public Property p_diag_facial_horto2() As String
        Get
            Return Me.diag_facial_horto2
        End Get
        Set(ByVal value As String)
            Me.diag_facial_horto2 = value
        End Set
    End Property

    Public Property p_diag_esque_horto2() As String
        Get
            Return Me.diag_esque_horto2
        End Get
        Set(ByVal value As String)
            Me.diag_esque_horto2 = value
        End Set
    End Property

    Public Property p_diag_dental_horto2() As String
        Get
            Return Me.diag_dental_horto2
        End Get
        Set(ByVal value As String)
            Me.diag_dental_horto2 = value
        End Set
    End Property

    Public Property p_plantratamiento_horto2() As String
        Get
            Return Me.plantratamiento_horto2
        End Get
        Set(ByVal value As String)
            Me.plantratamiento_horto2 = value
        End Set
    End Property

    Public Property p_alternativas_horto2() As String
        Get
            Return Me.alternativas_horto2
        End Get
        Set(ByVal value As String)
            Me.alternativas_horto2 = value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica_orto2 WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.hclinica_orto2 (IdUsuario, IdTUsuario, enfermedadanterior_horto2, tratamedico_horto2, patologias_horto2, alergiasotros_horto2, cresimientodesarrollo_horto2, " _
            & "antecedentes_horto2, efacial_frente_horto2, efacial_labios_horto2, efacial_lineasonr_horto2, efacial_selladolabial_horto2, efacial_perfil_horto2, efacial_menton_horto2, efacial_angulonaso_horto2, efacial_surcolabio_horto2, " _
            & "efacial_otros_horto2, eoral_tejidosblandos_horto2, eoral_rehabilitacion_horto2, eoral_endodoncia_horto2, eoral_periodoncia_horto2, eoral_dientesausentes_horto2, eoral_dientesincluidos_horto2, eoral_examendental_horto2, " _
            & "eoral_apinamiento_horto2, eoral_diastemas_horto2, eoral_overjet_horto2, eoral_overbite_horto2, eoral_lineamedia_horto2, eoral_tamdentario_horto2, eoral_formaarcada_horto2, eoral_mordidacruzada_horto2, eoral_curvaspee_horto2, " _
            & "eoral_claseangle_horto2, eoral_bolton_horto2, eoral_habitos_horto2, eoral_atm_horto2, eoral_manipulacion_horto2, eoral_otros_horto2, odonto_analisisespacio_horto2, eesque_sna_inicial_horto2, eesque_sna_control_horto2, " _
            & "eesque_sna_final_horto2, eesque_snb_inicial_horto2, eesque_snb_control_horto2, eesque_snb_final_horto2, eesque_anb_inicial_horto2, eesque_anb_control_horto2, eesque_anb_final_horto2, eesque_1pp_inicial_horto2, " _
            & "eesque_1pp_control_horto2, eesque_1pp_final_horto2, eesque_1pm_inicial_horto2, eesque_1pm_control_horto2, eesque_1pm_final_horto2, eesque_go_inicial_horto2, eesque_go_control_horto2, eesque_go_final_horto2, eesque_max_inicial_horto2, " _
            & "eesque_max_control_horto2, eesque_max_final_horto2, eesque_otros_inicial_horto2, eesque_otros_control_horto2, eesque_otros_final_horto2, reg_modelos_inicial_horto2, reg_modelos_control_horto2, reg_modelos_final_horto2, reg_pano_inicial_horto2, " _
            & "reg_pano_control_horto2, reg_pano_final_horto2, reg_perfil_inicial_horto2, reg_perfil_control_horto2, reg_perfil_final_horto2, reg_intra_inicial_horto2, reg_intra_control_horto2, reg_intra_final_horto2, reg_extra_inicial_horto2, " _
            & "reg_extra_control_horto2, reg_extra_final_horto2, reg_otras_inicial_horto2, reg_otras_control_horto2, reg_otras_final_horto2, diag_facial_horto2, diag_esque_horto2, diag_dental_horto2, plantratamiento_horto2, alternativas_horto2) " _
            & "VALUES (" & Me.IdUsuario & ", " & Me.IdTUsuario & ", '" & Me.enfermedadanterior_horto2 & "', '" & Me.tratamedico_horto2 & "', '" & Me.patologias_horto2 & "', '" & Me.alergiasotros_horto2 & "', '" & Me.cresimientodesarrollo_horto2 & "', '" & Me.antecedentes_horto2 & "', '" & Me.efacial_frente_horto2 & "', " _
            & "'" & Me.efacial_labios_horto2 & "', '" & Me.efacial_lineasonr_horto2 & "', '" & Me.efacial_selladolabial_horto2 & "', '" & Me.efacial_perfil_horto2 & "', '" & Me.efacial_menton_horto2 & "', '" & Me.efacial_angulonaso_horto2 & "', '" & Me.efacial_surcolabio_horto2 & "', '" & Me.efacial_otros_horto2 & "', '" & Me.eoral_tejidosblandos_horto2 & "', " _
            & "'" & Me.eoral_rehabilitacion_horto2 & "', '" & Me.eoral_endodoncia_horto2 & "', '" & Me.eoral_periodoncia_horto2 & "', '" & Me.eoral_dientesausentes_horto2 & "', '" & Me.eoral_dientesincluidos_horto2 & "', '" & Me.eoral_examendental_horto2 & "', '" & Me.eoral_apinamiento_horto2 & "', '" & Me.eoral_diastemas_horto2 & "', '" & Me.eoral_overjet_horto2 & "', " _
            & "'" & Me.eoral_overbite_horto2 & "', '" & Me.eoral_lineamedia_horto2 & "', '" & Me.eoral_tamdentario_horto2 & "', '" & Me.eoral_formaarcada_horto2 & "', '" & Me.eoral_mordidacruzada_horto2 & "', '" & Me.eoral_curvaspee_horto2 & "', '" & Me.eoral_claseangle_horto2 & "', '" & Me.eoral_bolton_horto2 & "', '" & Me.eoral_habitos_horto2 & "', " _
            & "'" & Me.eoral_atm_horto2 & "', '" & Me.eoral_manipulacion_horto2 & "', '" & Me.eoral_otros_horto2 & "', '" & Me.odonto_analisisespacio_horto2 & "', '" & Me.eesque_sna_inicial_horto2 & "', '" & Me.eesque_sna_control_horto2 & "', '" & Me.eesque_sna_final_horto2 & "', '" & Me.eesque_snb_inicial_horto2 & "', '" & Me.eesque_snb_control_horto2 & "', " _
            & "'" & Me.eesque_snb_final_horto2 & "', '" & Me.eesque_anb_inicial_horto2 & "', '" & Me.eesque_anb_control_horto2 & "', '" & Me.eesque_anb_final_horto2 & "', '" & Me.eesque_1pp_inicial_horto2 & "', '" & Me.eesque_1pp_control_horto2 & "', '" & Me.eesque_1pp_final_horto2 & "', '" & Me.eesque_1pm_inicial_horto2 & "', '" & Me.eesque_1pm_control_horto2 & "', " _
            & "'" & Me.eesque_1pm_final_horto2 & "', '" & Me.eesque_go_inicial_horto2 & "', '" & Me.eesque_go_control_horto2 & "', '" & Me.eesque_go_final_horto2 & "', '" & Me.eesque_max_inicial_horto2 & "', '" & Me.eesque_max_control_horto2 & "', '" & Me.eesque_max_final_horto2 & "', '" & Me.eesque_otros_inicial_horto2 & "', '" & Me.eesque_otros_control_horto2 & "', " _
            & "'" & Me.eesque_otros_final_horto2 & "', '" & Me.reg_modelos_inicial_horto2 & "', '" & Me.reg_modelos_control_horto2 & "', '" & Me.reg_modelos_final_horto2 & "', '" & Me.reg_pano_inicial_horto2 & "', '" & Me.reg_pano_control_horto2 & "', '" & Me.reg_pano_final_horto2 & "', '" & Me.reg_perfil_inicial_horto2 & "', '" & Me.reg_perfil_control_horto2 & "', " _
            & "'" & Me.reg_perfil_final_horto2 & "', '" & Me.reg_intra_inicial_horto2 & "', '" & Me.reg_intra_control_horto2 & "', '" & Me.reg_intra_final_horto2 & "', '" & Me.reg_extra_inicial_horto2 & "', '" & Me.reg_extra_control_horto2 & "', '" & Me.reg_extra_final_horto2 & "', '" & Me.reg_otras_inicial_horto2 & "', '" & Me.reg_otras_control_horto2 & "', " _
            & "'" & Me.reg_otras_final_horto2 & "', '" & Me.diag_facial_horto2 & "', '" & Me.diag_esque_horto2 & "', '" & Me.diag_dental_horto2 & "', '" & Me.plantratamiento_horto2 & "', '" & Me.alternativas_horto2 & "')"


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

            CLASE_GENERAL.sql = "UPDATE (Orthosoft.hclinica_orto2) SET enfermedadanterior_horto2 = '" & Me.enfermedadanterior_horto2 & "' , tratamedico_horto2 = '" & Me.tratamedico_horto2 & "' , patologias_horto2 = '" & Me.patologias_horto2 & "' , " _
            & "alergiasotros_horto2 = '" & Me.alergiasotros_horto2 & "' , cresimientodesarrollo_horto2 = '" & Me.cresimientodesarrollo_horto2 & "' , antecedentes_horto2 = '" & Me.antecedentes_horto2 & "' , efacial_frente_horto2 = '" & Me.efacial_frente_horto2 & "' , efacial_labios_horto2 = '" & Me.efacial_labios_horto2 & "' , efacial_lineasonr_horto2 = '" & Me.efacial_lineasonr_horto2 & "' , " _
            & "efacial_selladolabial_horto2 = '" & Me.efacial_selladolabial_horto2 & "' , efacial_perfil_horto2 = '" & Me.efacial_perfil_horto2 & "' , efacial_menton_horto2 = '" & Me.efacial_menton_horto2 & "' , efacial_angulonaso_horto2 = '" & Me.efacial_angulonaso_horto2 & "' , efacial_surcolabio_horto2 = '" & Me.efacial_surcolabio_horto2 & "' , " _
            & "efacial_otros_horto2 = '" & Me.efacial_otros_horto2 & "' , eoral_tejidosblandos_horto2 = '" & Me.eoral_tejidosblandos_horto2 & "' , eoral_rehabilitacion_horto2 = '" & Me.eoral_rehabilitacion_horto2 & "' , eoral_endodoncia_horto2 = '" & Me.eoral_endodoncia_horto2 & "' , eoral_periodoncia_horto2 = '" & Me.eoral_periodoncia_horto2 & "' , " _
            & "eoral_dientesausentes_horto2 = '" & Me.eoral_dientesausentes_horto2 & "' , eoral_dientesincluidos_horto2 = '" & Me.eoral_dientesincluidos_horto2 & "' , eoral_examendental_horto2 = '" & Me.eoral_examendental_horto2 & "' , eoral_apinamiento_horto2 = '" & Me.eoral_apinamiento_horto2 & "' , eoral_diastemas_horto2 = '" & Me.eoral_diastemas_horto2 & "' , " _
            & "eoral_overjet_horto2 = '" & Me.eoral_overjet_horto2 & "' , eoral_overbite_horto2 = '" & Me.eoral_overbite_horto2 & "' , eoral_lineamedia_horto2 = '" & Me.eoral_lineamedia_horto2 & "' , eoral_tamdentario_horto2 = '" & Me.eoral_tamdentario_horto2 & "' , eoral_formaarcada_horto2 = '" & Me.eoral_formaarcada_horto2 & "' , eoral_mordidacruzada_horto2 = '" & Me.eoral_mordidacruzada_horto2 & "' , " _
            & "eoral_curvaspee_horto2 = '" & Me.eoral_curvaspee_horto2 & "' , eoral_claseangle_horto2 = '" & Me.eoral_claseangle_horto2 & "' , eoral_bolton_horto2 = '" & Me.eoral_bolton_horto2 & "' , eoral_habitos_horto2 = '" & Me.eoral_habitos_horto2 & "' , eoral_atm_horto2 = '" & Me.eoral_atm_horto2 & "' , eoral_manipulacion_horto2 = '" & Me.eoral_manipulacion_horto2 & "' , " _
            & "eoral_otros_horto2 = '" & Me.eoral_otros_horto2 & "' , odonto_analisisespacio_horto2 = '" & Me.odonto_analisisespacio_horto2 & "' , eesque_sna_inicial_horto2 = '" & Me.eesque_sna_inicial_horto2 & "' , eesque_sna_control_horto2 = '" & Me.eesque_sna_control_horto2 & "' , eesque_sna_final_horto2 = '" & Me.eesque_sna_final_horto2 & "' , " _
            & "eesque_snb_inicial_horto2 = '" & Me.eesque_snb_inicial_horto2 & "' , eesque_snb_control_horto2 = '" & Me.eesque_snb_control_horto2 & "' , eesque_snb_final_horto2 = '" & Me.eesque_snb_final_horto2 & "' , eesque_anb_inicial_horto2 = '" & Me.eesque_anb_inicial_horto2 & "' , eesque_anb_control_horto2 = '" & Me.eesque_anb_control_horto2 & "' , " _
            & "eesque_anb_final_horto2 = '" & Me.eesque_anb_final_horto2 & "' , eesque_1pp_inicial_horto2 = '" & Me.eesque_1pp_inicial_horto2 & "' , eesque_1pp_control_horto2 = '" & Me.eesque_1pp_control_horto2 & "' , eesque_1pp_final_horto2 = '" & Me.eesque_1pp_final_horto2 & "' , eesque_1pm_inicial_horto2 = '" & Me.eesque_1pm_inicial_horto2 & "' , " _
            & "eesque_1pm_control_horto2 = '" & Me.eesque_1pm_control_horto2 & "' , eesque_1pm_final_horto2 = '" & Me.eesque_1pm_final_horto2 & "' , eesque_go_inicial_horto2 = '" & Me.eesque_go_inicial_horto2 & "' , eesque_go_control_horto2 = '" & Me.eesque_go_control_horto2 & "' , eesque_go_final_horto2 = '" & Me.eesque_go_final_horto2 & "' , " _
            & "eesque_max_inicial_horto2 = '" & Me.eesque_max_inicial_horto2 & "' , eesque_max_control_horto2 = '" & Me.eesque_max_control_horto2 & "' , eesque_max_final_horto2 = '" & Me.eesque_max_final_horto2 & "' , eesque_otros_inicial_horto2 = '" & Me.eesque_otros_inicial_horto2 & "' , eesque_otros_control_horto2 = '" & Me.eesque_otros_control_horto2 & "' , " _
            & "eesque_otros_final_horto2 = '" & Me.eesque_otros_final_horto2 & "' , reg_modelos_inicial_horto2 = '" & Me.reg_modelos_inicial_horto2 & "' , reg_modelos_control_horto2 = '" & Me.reg_modelos_control_horto2 & "' , reg_modelos_final_horto2 = '" & Me.reg_modelos_final_horto2 & "' , reg_pano_inicial_horto2 = '" & Me.reg_pano_inicial_horto2 & "' , " _
            & "reg_pano_control_horto2 = '" & Me.reg_pano_control_horto2 & "' , reg_pano_final_horto2 = '" & Me.reg_pano_final_horto2 & "' , reg_perfil_inicial_horto2 = '" & Me.reg_perfil_inicial_horto2 & "' , reg_perfil_control_horto2 = '" & Me.reg_perfil_control_horto2 & "' , reg_perfil_final_horto2 = '" & Me.reg_perfil_final_horto2 & "' , reg_intra_inicial_horto2 = '" & Me.reg_intra_inicial_horto2 & "' , " _
            & "reg_intra_control_horto2 = '" & Me.reg_intra_control_horto2 & "' , reg_intra_final_horto2 = '" & Me.reg_intra_final_horto2 & "' , reg_extra_inicial_horto2 = '" & Me.reg_extra_inicial_horto2 & "' , reg_extra_control_horto2 = '" & Me.reg_extra_control_horto2 & "' , reg_extra_final_horto2 = '" & Me.reg_extra_final_horto2 & "' , reg_otras_inicial_horto2 = '" & Me.reg_otras_inicial_horto2 & "' , " _
            & "reg_otras_control_horto2 = '" & Me.reg_otras_control_horto2 & "' , reg_otras_final_horto2 = '" & Me.reg_otras_final_horto2 & "' , diag_facial_horto2 = '" & Me.diag_facial_horto2 & "' , diag_esque_horto2 = '" & Me.diag_esque_horto2 & "' , diag_dental_horto2 = '" & Me.diag_dental_horto2 & "' , plantratamiento_horto2 = '" & Me.plantratamiento_horto2 & "' , alternativas_horto2 = '" & Me.alternativas_horto2 & "' " _
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

                    CLASE_GENERAL.sql = "SELECT * FROM Orthosoft.hclinica_orto2 " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()


                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")
                        xenfermedadanterior_horto2 = CLASE_GENERAL.xdr("enfermedadanterior_horto2")
                        xtratamedico_horto2 = CLASE_GENERAL.xdr("tratamedico_horto2")
                        xpatologias_horto2 = CLASE_GENERAL.xdr("patologias_horto2")
                        xalergiasotros_horto2 = CLASE_GENERAL.xdr("alergiasotros_horto2")
                        xcresimientodesarrollo_horto2 = CLASE_GENERAL.xdr("cresimientodesarrollo_horto2")
                        xantecedentes_horto2 = CLASE_GENERAL.xdr("antecedentes_horto2")
                        xefacial_frente_horto2 = CLASE_GENERAL.xdr("efacial_frente_horto2")
                        xefacial_labios_horto2 = CLASE_GENERAL.xdr("efacial_labios_horto2")
                        xefacial_lineasonr_horto2 = CLASE_GENERAL.xdr("efacial_lineasonr_horto2")
                        xefacial_selladolabial_horto2 = CLASE_GENERAL.xdr("efacial_selladolabial_horto2")
                        xefacial_perfil_horto2 = CLASE_GENERAL.xdr("efacial_perfil_horto2")
                        xefacial_menton_horto2 = CLASE_GENERAL.xdr("efacial_menton_horto2")
                        xefacial_angulonaso_horto2 = CLASE_GENERAL.xdr("efacial_angulonaso_horto2")
                        xefacial_surcolabio_horto2 = CLASE_GENERAL.xdr("efacial_surcolabio_horto2")
                        xefacial_otros_horto2 = CLASE_GENERAL.xdr("efacial_otros_horto2")
                        xeoral_tejidosblandos_horto2 = CLASE_GENERAL.xdr("eoral_tejidosblandos_horto2")
                        xeoral_rehabilitacion_horto2 = CLASE_GENERAL.xdr("eoral_rehabilitacion_horto2")
                        xeoral_endodoncia_horto2 = CLASE_GENERAL.xdr("eoral_endodoncia_horto2")
                        xeoral_periodoncia_horto2 = CLASE_GENERAL.xdr("eoral_periodoncia_horto2")
                        xeoral_dientesausentes_horto2 = CLASE_GENERAL.xdr("eoral_dientesausentes_horto2")
                        xeoral_dientesincluidos_horto2 = CLASE_GENERAL.xdr("eoral_dientesincluidos_horto2")
                        xeoral_examendental_horto2 = CLASE_GENERAL.xdr("eoral_examendental_horto2")
                        xeoral_apinamiento_horto2 = CLASE_GENERAL.xdr("eoral_apinamiento_horto2")
                        xeoral_diastemas_horto2 = CLASE_GENERAL.xdr("eoral_diastemas_horto2")
                        xeoral_overjet_horto2 = CLASE_GENERAL.xdr("eoral_overjet_horto2")
                        xeoral_overbite_horto2 = CLASE_GENERAL.xdr("eoral_overbite_horto2")
                        xeoral_lineamedia_horto2 = CLASE_GENERAL.xdr("eoral_lineamedia_horto2")
                        xeoral_tamdentario_horto2 = CLASE_GENERAL.xdr("eoral_tamdentario_horto2")
                        xeoral_formaarcada_horto2 = CLASE_GENERAL.xdr("eoral_formaarcada_horto2")
                        xeoral_mordidacruzada_horto2 = CLASE_GENERAL.xdr("eoral_mordidacruzada_horto2")
                        xeoral_curvaspee_horto2 = CLASE_GENERAL.xdr("eoral_curvaspee_horto2")
                        xeoral_claseangle_horto2 = CLASE_GENERAL.xdr("eoral_claseangle_horto2")
                        xeoral_bolton_horto2 = CLASE_GENERAL.xdr("eoral_bolton_horto2")
                        xeoral_habitos_horto2 = CLASE_GENERAL.xdr("eoral_habitos_horto2")
                        xeoral_atm_horto2 = CLASE_GENERAL.xdr("eoral_atm_horto2")
                        xeoral_manipulacion_horto2 = CLASE_GENERAL.xdr("eoral_manipulacion_horto2")
                        xeoral_otros_horto2 = CLASE_GENERAL.xdr("eoral_otros_horto2")
                        xodonto_analisisespacio_horto2 = CLASE_GENERAL.xdr("odonto_analisisespacio_horto2")
                        xeesque_sna_inicial_horto2 = CLASE_GENERAL.xdr("eesque_sna_inicial_horto2")
                        xeesque_sna_control_horto2 = CLASE_GENERAL.xdr("eesque_sna_control_horto2")
                        xeesque_sna_final_horto2 = CLASE_GENERAL.xdr("eesque_sna_final_horto2")
                        xeesque_snb_inicial_horto2 = CLASE_GENERAL.xdr("eesque_snb_inicial_horto2")
                        xeesque_snb_control_horto2 = CLASE_GENERAL.xdr("eesque_snb_control_horto2")
                        xeesque_snb_final_horto2 = CLASE_GENERAL.xdr("eesque_snb_final_horto2")
                        xeesque_anb_inicial_horto2 = CLASE_GENERAL.xdr("eesque_anb_inicial_horto2")
                        xeesque_anb_control_horto2 = CLASE_GENERAL.xdr("eesque_anb_control_horto2")
                        xeesque_anb_final_horto2 = CLASE_GENERAL.xdr("eesque_anb_final_horto2")
                        xeesque_1pp_inicial_horto2 = CLASE_GENERAL.xdr("eesque_1pp_inicial_horto2")
                        xeesque_1pp_control_horto2 = CLASE_GENERAL.xdr("eesque_1pp_control_horto2")
                        xeesque_1pp_final_horto2 = CLASE_GENERAL.xdr("eesque_1pp_final_horto2")
                        xeesque_1pm_inicial_horto2 = CLASE_GENERAL.xdr("eesque_1pm_inicial_horto2")
                        xeesque_1pm_control_horto2 = CLASE_GENERAL.xdr("eesque_1pm_control_horto2")
                        xeesque_1pm_final_horto2 = CLASE_GENERAL.xdr("eesque_1pm_final_horto2")
                        xeesque_go_inicial_horto2 = CLASE_GENERAL.xdr("eesque_go_inicial_horto2")
                        xeesque_go_control_horto2 = CLASE_GENERAL.xdr("eesque_go_control_horto2")
                        xeesque_go_final_horto2 = CLASE_GENERAL.xdr("eesque_go_final_horto2")
                        xeesque_max_inicial_horto2 = CLASE_GENERAL.xdr("eesque_max_inicial_horto2")
                        xeesque_max_control_horto2 = CLASE_GENERAL.xdr("eesque_max_control_horto2")
                        xeesque_max_final_horto2 = CLASE_GENERAL.xdr("eesque_max_final_horto2")
                        xeesque_otros_inicial_horto2 = CLASE_GENERAL.xdr("eesque_otros_inicial_horto2")
                        xeesque_otros_control_horto2 = CLASE_GENERAL.xdr("eesque_otros_control_horto2")
                        xeesque_otros_final_horto2 = CLASE_GENERAL.xdr("eesque_otros_final_horto2")
                        xreg_modelos_inicial_horto2 = CLASE_GENERAL.xdr("reg_modelos_inicial_horto2")
                        xreg_modelos_control_horto2 = CLASE_GENERAL.xdr("reg_modelos_control_horto2")
                        xreg_modelos_final_horto2 = CLASE_GENERAL.xdr("reg_modelos_final_horto2")
                        xreg_pano_inicial_horto2 = CLASE_GENERAL.xdr("reg_pano_inicial_horto2")
                        xreg_pano_control_horto2 = CLASE_GENERAL.xdr("reg_pano_control_horto2")
                        xreg_pano_final_horto2 = CLASE_GENERAL.xdr("reg_pano_final_horto2")
                        xreg_perfil_inicial_horto2 = CLASE_GENERAL.xdr("reg_perfil_inicial_horto2")
                        xreg_perfil_control_horto2 = CLASE_GENERAL.xdr("reg_perfil_control_horto2")
                        xreg_perfil_final_horto2 = CLASE_GENERAL.xdr("reg_perfil_final_horto2")
                        xreg_intra_inicial_horto2 = CLASE_GENERAL.xdr("reg_intra_inicial_horto2")
                        xreg_intra_control_horto2 = CLASE_GENERAL.xdr("reg_intra_control_horto2")
                        xreg_intra_final_horto2 = CLASE_GENERAL.xdr("reg_intra_final_horto2")
                        xreg_extra_inicial_horto2 = CLASE_GENERAL.xdr("reg_extra_inicial_horto2")
                        xreg_extra_control_horto2 = CLASE_GENERAL.xdr("reg_extra_control_horto2")
                        xreg_extra_final_horto2 = CLASE_GENERAL.xdr("reg_extra_final_horto2")
                        xreg_otras_inicial_horto2 = CLASE_GENERAL.xdr("reg_otras_inicial_horto2")
                        xreg_otras_control_horto2 = CLASE_GENERAL.xdr("reg_otras_control_horto2")
                        xreg_otras_final_horto2 = CLASE_GENERAL.xdr("reg_otras_final_horto2")
                        xdiag_facial_horto2 = CLASE_GENERAL.xdr("diag_facial_horto2")
                        xdiag_esque_horto2 = CLASE_GENERAL.xdr("diag_esque_horto2")
                        xdiag_dental_horto2 = CLASE_GENERAL.xdr("diag_dental_horto2")
                        xplantratamiento_horto2 = CLASE_GENERAL.xdr("plantratamiento_horto2")
                        xalternativas_horto2 = CLASE_GENERAL.xdr("alternativas_horto2")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

                Case "impresion"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT consultorio.Idconsultorio, consultorio.razonsocial_cons, consultorio.nit_cons  , consultorio.direccion_cons, consultorio.ciudad_cons, consultorio.web_cons, consultorio.email_cons, consultorio.rtelegal_cons, consultorio.profesionrlegal_cons, consultorio.documento_cons, consultorio.ciudaddoc_cons, consultorio.actividad_cons, " _
                    & "consultorio.tel1_cons, consultorio.celular_cons, consultorio.icono_cons, Idpaciente, pacientes.nhclinica, pacientes.nombres_pac, pacientes.apellidos_pac, estadocivil.nom_estadocivil, pacientes.fecnac_pac, pacientes.lugarnac_pac, pacientes.referidopor_pac, pacientes.sexo_pac, pacientes.numdoc_pac, pacientes.dedoc_pac, pacientes.fecingreso_pac, pacientes.residencia_pac, pacientes.ocupacion_pac, " _
                    & "entidades.nombre_ent, hclinica_orto2.*, ograma.observacionograma_ini, ograma.observacionograma_act, ograma.ograma_inicial, ograma.ograma_actual, ograma.oleary_inicial, ograma.oleary_actual, ograma.fecha_ograma FROM Orthosoft.consultorio " _
                    & "INNER JOIN orthosoft.pacientes ON (consultorio.Idconsultorio = pacientes.Idconsultorio) " _
                    & "INNER JOIN orthosoft.entidades ON (pacientes.Identidad = entidades.Identidad) " _
                    & "INNER JOIN orthosoft.estadocivil ON (pacientes.estadocivil_pac = estadocivil.Idestadocivil) " _
                    & "INNER JOIN orthosoft.hclinica_orto2  ON (pacientes.Idpaciente = hclinica_orto2.IdUsuario) " _
                    & "INNER JOIN orthosoft.ograma ON (pacientes.Idpaciente = ograma.IdUsuario) " _
                    & "WHERE Idpaciente = " & Me.IdUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("d:\varios\historiaclinica2.xml", XmlWriteMode.WriteSchema)

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
