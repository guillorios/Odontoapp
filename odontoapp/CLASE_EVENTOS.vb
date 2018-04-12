Imports Microsoft.VisualBasic
Imports Janus.Windows.Schedule
Imports System.Math

Public Class CLASE_EVENTOS

    'Clase Base de Datos
    Private CAL As CLASE_CALENDARIO
    Private CITA As CLASE_CITAS
    Private GENE As CLASE_GENERAL
    Private CONSULTA As CLASE_CONSULTA
    Private EVEN As CLASE_EVENTOS
    Private CONS As CLASE_CONSULTORIO
    Private PAC As CLASE_PACIENTES
    Private DOC As CLASE_DOCTORES
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS
    Private SCHE As CLASE_SCHEDULER
    Private EMP As CLASE_EMPLEADOS
    Private CTRL As CLASE_CONTROL
    Private CONSUL As CLASE_CONSULTORIO
    Private OPERADOR As CLASE_OPERADOR

    'Clases para la Historia Clinica
    Private HC As CLASE_HCLINICA
    Private HCEF As CLASE_HCLINICA_EFISICO
    Private HCP2 As CLASE_HCLINICA_P2
    Private HCP3 As CLASE_HCLINICA_P3
    Private HCP4 As CLASE_HCLINICA_P4
    Private HCORTO2 As CLASE_HCLINICA_ORTO2
    Private HCORTO3 As CLASE_HCLINICA_ORTO3
    Private HCGENE As CLASE_HCLINICA_GENERAL

    'Variable Operaciones
    Private Shared VTOTAL As Double

    Private Shared NCUOTASINI As Double
    Private Shared VCUOTASINI As Double
    Private Shared TCUOTASINI As Double

    Private Shared NCUOTAS As Double
    Private Shared VCUOTAS As Double
    Private Shared TCUOTAS As Double

    'Variables Operaciones R Caja

    Private Shared TOTAL_RC As Double
    Private Shared EFECTIVO_RC As Double
    Private Shared TARJETA_RC As Double

    'Variables Operaciones MDiario
    Private Shared SaldoInicialCMenor As Double
    Private Shared TPagoEfectivodebitos As Double
    Private Shared TPagoTarjetadebitos As Double
    Private Shared TotalEgresosCreditos As Double
    Private Shared TotalMovimientoDiario As Double
    Private Shared TotalDebitos As Double

    'Operaciones

    Private fecha As Date
    Private contar As Integer
    Private Idpaciente As Integer

    'Variables de Imagen
    Private iImagen As Image

    'Variables de Citas


    Public Sub limpiar(ByVal opcion As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        Try 'sentencia para el manejo de errores

            Select Case opcion

                Case "limpiarpacientes"

                    My.Forms.frmPacientes.pbFoto_pac.Image = My.Resources.fondopaciente
                    My.Forms.frmPacientes.txtIdpaciente.Text = ""
                    My.Forms.frmPacientes.txtnhclinica.Text = "0"
                    My.Forms.frmPacientes.txtapellidos_pac.Text = ""
                    My.Forms.frmPacientes.txtapellidos_pac.Focus()
                    My.Forms.frmPacientes.txtnombres_pac.Text = ""
                    My.Forms.frmPacientes.txtnumdoc_pac.Text = ""
                    My.Forms.frmPacientes.txtresidencia_pac.Text = ""
                    My.Forms.frmPacientes.cmbestadocivil_pac.SelectedIndex = 0
                    My.Forms.frmPacientes.txtocupacion_pac.Text = ""
                    My.Forms.frmPacientes.txtoficina_pac.Text = ""
                    My.Forms.frmPacientes.txtreferido_pac.Text = ""

                    My.Forms.frmPacientes.txtlugarnac_pac.Text = ""
                    My.Forms.frmPacientes.txtdedoc_pac.Text = ""

                    My.Forms.frmPacientes.cmbzona_pac.SelectedIndex = 0
                    My.Forms.frmPacientes.txtmunicipio_pac.Text = ""
                    My.Forms.frmPacientes.txtdep_pac.Text = ""
                    My.Forms.frmPacientes.txtrh_Pac.Text = ""

                    My.Forms.frmPacientes.cmbfecingreso_pac.Value = Format(Now(), "short date")
                    My.Forms.frmPacientes.cmbfecingreso_pac.MaxDate = Format(Now(), "short date")
                    My.Forms.frmPacientes.cmbfecnac_pac.Value = Format(Now(), "short date")
                    My.Forms.frmPacientes.cmbfecnac_pac.MaxDate = Format(Now(), "short date")
                    My.Forms.frmPacientes.cmbEntidad.SelectedItem = 1
                    My.Forms.frmPacientes.cmbOperadorCel.SelectedValue = 1
                    My.Forms.frmPacientes.cmbtipodoc_pac.Text = "CEDULA"
                    My.Forms.frmPacientes.rbtMasculino_pac.Checked = True
                    My.Forms.frmPacientes.rbtEstado_Entratamiento.Checked = True
                    My.Forms.frmPacientes.rbtAños_pac.Checked = True
                    My.Forms.frmPacientes.lblNumaños.Text = "0"

                    My.Forms.frmPacientes.txtAcudiente_pac.Text = ""
                    My.Forms.frmPacientes.txtCelAcudiente_pac.Text = ""
                    My.Forms.frmPacientes.txtCelConyuge_pac.Text = ""
                    My.Forms.frmPacientes.txtCelMadre_pac.Text = ""
                    My.Forms.frmPacientes.txtCelPadre_pac.Text = ""
                    My.Forms.frmPacientes.txtCelular_pac.Text = ""
                    My.Forms.frmPacientes.txtConyuge_pac.Text = ""
                    My.Forms.frmPacientes.txtemail_pac.Text = ""
                    My.Forms.frmPacientes.txtemailPadre_pac.Text = ""
                    My.Forms.frmPacientes.txtemailMadre_pac.Text = ""
                    My.Forms.frmPacientes.txtemailAcudiente_pac.Text = ""
                    My.Forms.frmPacientes.txtemailConyuge_pac.Text = ""

                    My.Forms.frmPacientes.txtFax_pac.Text = ""
                    My.Forms.frmPacientes.txtMadre_pac.Text = ""
                    My.Forms.frmPacientes.txtOcuAcudiente_pac.Text = ""
                    My.Forms.frmPacientes.txtOcuConyuge_pac.Text = ""
                    My.Forms.frmPacientes.txtOcuMadre_pac.Text = ""
                    My.Forms.frmPacientes.txtOcuPadre_pac.Text = ""
                    My.Forms.frmPacientes.txtPadre_pac.Text = ""
                    My.Forms.frmPacientes.txtTelAcudiente_pac.Text = ""
                    My.Forms.frmPacientes.txtTelCasa_pac.Text = ""
                    My.Forms.frmPacientes.txtTelConyuge_pac.Text = ""
                    My.Forms.frmPacientes.txtTelMadre_pac.Text = ""
                    My.Forms.frmPacientes.txtTelOficina_pac.Text = ""
                    My.Forms.frmPacientes.txtTelPadre_pac.Text = ""
                    My.Forms.frmPacientes.txtweb_pac.Text = ""
                    My.Forms.frmPacientes.RichTxtNotas_pac.Text = ""

                Case "limpiarhcg"

                    'ANTECEDENTES
                    '1
                    My.Forms.frmHistoriaClinicaGeneral.ckant_tratam_no.Checked = True
                    '2
                    My.Forms.frmHistoriaClinicaGeneral.ckant_medicam_no.Checked = True
                    '3
                    My.Forms.frmHistoriaClinicaGeneral.ckant_alergias_no.Checked = True
                    '4
                    My.Forms.frmHistoriaClinicaGeneral.ckant_cardiopatias_no.Checked = True
                    '5
                    My.Forms.frmHistoriaClinicaGeneral.ckant_parterial_no.Checked = True
                    '6
                    My.Forms.frmHistoriaClinicaGeneral.ckant_embarazo_no.Checked = True
                    '7
                    My.Forms.frmHistoriaClinicaGeneral.ckant_diabetes_no.Checked = True
                    '8
                    My.Forms.frmHistoriaClinicaGeneral.ckant_hepatitis_no.Checked = True
                    '9
                    My.Forms.frmHistoriaClinicaGeneral.ckant_irradia_no.Checked = True
                    '10
                    My.Forms.frmHistoriaClinicaGeneral.ckant_discrasia_no.Checked = True
                    '11
                    My.Forms.frmHistoriaClinicaGeneral.ckant_fiebre_no.Checked = True
                    '12
                    My.Forms.frmHistoriaClinicaGeneral.ckant_enfrenal_no.Checked = True
                    '13
                    My.Forms.frmHistoriaClinicaGeneral.ckant_inmunos_no.Checked = True
                    '14
                    My.Forms.frmHistoriaClinicaGeneral.ckant_temosionales_no.Checked = True
                    '15
                    My.Forms.frmHistoriaClinicaGeneral.ckant_prespi_no.Checked = True
                    '16
                    My.Forms.frmHistoriaClinicaGeneral.ckant_tgastricos_no.Checked = True
                    '17
                    My.Forms.frmHistoriaClinicaGeneral.ckant_epilepsia_no.Checked = True
                    '18
                    My.Forms.frmHistoriaClinicaGeneral.ckant_cirugias_no.Checked = True
                    '19
                    My.Forms.frmHistoriaClinicaGeneral.ckant_eorales_no.Checked = True
                    '20
                    My.Forms.frmHistoriaClinicaGeneral.ckant_otras_no.Checked = True

                    My.Forms.frmHistoriaClinicaGeneral.txtuconsulta_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtaconsulta_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtant_temp_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtant_pulsapm_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtant_pulsaart_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtant_fresp_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtant_familiares_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtant_observa_hcg.Text = ""

                    'TEJIDOS BLANDOS
                    '1
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lsuperior_no.Checked = True
                    '2
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_linferior_no.Checked = True
                    '3
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_comisuras_no.Checked = True
                    '4
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_mucosa_no.Checked = True
                    '5
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_surcos_no.Checked = True
                    '6
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_frenillos_no.Checked = True
                    '7
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros1_no.Checked = True
                    '8
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_paladar_no.Checked = True
                    '9
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_orofar_no.Checked = True
                    '10
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lengua_no.Checked = True
                    '11
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_pisoboca_no.Checked = True
                    '12
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_rebordes_no.Checked = True
                    '13
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_gsalivares_no.Checked = True
                    '14
                    My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros2_no.Checked = True

                    'ATM OCLUSION
                    '15
                    My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolormusc_no.Checked = True
                    '16
                    My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolorarti_no.Checked = True
                    '17
                    My.Forms.frmHistoriaClinicaGeneral.ckef_atm_ruidoarti_no.Checked = True
                    '18
                    My.Forms.frmHistoriaClinicaGeneral.ckef_atm_alterac_no.Checked = True
                    '19
                    My.Forms.frmHistoriaClinicaGeneral.ckef_atm_maloclu_no.Checked = True

                    '20
                    My.Forms.frmHistoriaClinicaGeneral.ckef_atm_cresim_no.Checked = True
                    '21
                    My.Forms.frmHistoriaClinicaGeneral.ckef_atm_otros_no.Checked = True

                    'TEJIDOS DENTALES
                    '22
                    My.Forms.frmHistoriaClinicaGeneral.ckef_td_cforma_no.Checked = True
                    '23
                    My.Forms.frmHistoriaClinicaGeneral.ckef_td_ctam_no.Checked = True
                    '24
                    My.Forms.frmHistoriaClinicaGeneral.ckef_td_cnum_no.Checked = True
                    '25
                    My.Forms.frmHistoriaClinicaGeneral.ckef_td_ccolor_no.Checked = True
                    '26
                    My.Forms.frmHistoriaClinicaGeneral.ckef_td_cpos_no.Checked = True
                    '27
                    My.Forms.frmHistoriaClinicaGeneral.ckef_td_impac_no.Checked = True
                    '28
                    My.Forms.frmHistoriaClinicaGeneral.ckef_td_otros_no.Checked = True

                    'EXAMEN PERIODONTAL
                    '29
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ep_sangrado_no.Checked = True
                    '30
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ep_movilidad_no.Checked = True
                    '31
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ep_reces_no.Checked = True
                    '32
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ep_bolsa_no.Checked = True
                    '33
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ep_calculos_no.Checked = True
                    '34
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ep_absceso_no.Checked = True
                    '35
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ep_otros_no.Checked = True

                    'EXAMEN PULPAR
                    '36
                    My.Forms.frmHistoriaClinicaGeneral.ckef_epu_avital_no.Checked = True
                    '37
                    My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dolor_no.Checked = True
                    '38
                    My.Forms.frmHistoriaClinicaGeneral.ckef_epu_mdelta_no.Checked = True
                    '39
                    My.Forms.frmHistoriaClinicaGeneral.ckef_epu_sensi_no.Checked = True
                    '40
                    My.Forms.frmHistoriaClinicaGeneral.ckef_epu_fistula_no.Checked = True
                    '41
                    My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dtrata_no.Checked = True
                    '42
                    My.Forms.frmHistoriaClinicaGeneral.ckef_epu_otros_no.Checked = True

                    'HABITOS
                    '43
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ho_resoral_no.Checked = True
                    '44
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ho_succdig_no.Checked = True
                    '45
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ho_lenguap_no.Checked = True
                    '46
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ho_queilos_no.Checked = True
                    '47
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ho_fumador_no.Checked = True
                    '48
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ho_onico_no.Checked = True
                    '49
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ho_otros_no.Checked = True

                    My.Forms.frmHistoriaClinicaGeneral.txtef_observa_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtef_hallazgos_hcg.Text = ""


                    'HISTORIA CLINICA DE ACCION PREVENTIVA

                    '1
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ap_charlas_no.Checked = True
                    '2
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ap_cepillado_no.Checked = True
                    '3
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ap_seda_no.Checked = True
                    '4
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ap_enguague_no.Checked = True
                    '5
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ap_fluor_no.Checked = True
                    '6
                    My.Forms.frmHistoriaClinicaGeneral.ckef_ap_sellantes_no.Checked = True

                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_charlas_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_cepillado_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_seda_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_enguague_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_fluor_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_sellantes_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txthc_observa_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtexa_comp_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_psano_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanotipo_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanocod_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandos_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandostipo_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandoscod_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_atm_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmtipo_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmcod_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdental_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentaltipo_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentalcod_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperio_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiotipo_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiocod_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpar_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpartipo_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulparcod_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_otros_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_otrostipo_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_otroscod_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_observa_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_remision_hcg.Text = ""

                    My.Forms.frmHistoriaClinicaGeneral.txttrata_promocion_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_prevencion_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_radiog_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_operatoria_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_endodoncia_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_perio_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_prosto_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_oclusion_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_cirugia_hcg.Text = ""
                    My.Forms.frmHistoriaClinicaGeneral.txtpronostico_hcg.Text = ""

                Case "limpiarhcorto"

                    ' Limpiamos Historia Clinica tambien

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmconsulta_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdescripcion_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtclase_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtduracion_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtenfe_infancia_h.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.chkdiabetes.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkhepatitis.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chksinusitis.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkcardiovas.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkfiebre.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkrespira.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkhipertension.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtinmuniza_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txthospitaliza_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttraumaticoas_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtquirurgicos_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttransfusi_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtirradia_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txthemorrag_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmedica_act_h.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.chkanestesia.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkpenicilina.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtotras_drogas_h.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.chkbruxismo.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkdeglusion.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkresbucal.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkinffon.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkfuma.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkempling.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chksuccdigital.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chkmorder.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_gener_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_bucales_h.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_piel.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cabeza.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cara.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_oidos.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_ojos.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_nariz.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_senos.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cuello.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.txttensionart_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpulso_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfr_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpiel_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtamigdalas_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtnot_linf_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpisoboca_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios__hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpaladar_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcarrillos__hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtglsalivares__hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmucosa_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenillos_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtotros_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtalarmas_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtnotas_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttipofacial_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtimpCabello_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriav_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriah_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcejas_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtesclera_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtintercantal_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtalasnariz_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsimcomisur_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtselladolabial_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtinscis_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmm_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtgrosorlabial_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisasimetria_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisaencia_hef.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisadientesinf_hef.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.txttipoperfil_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtanguloconj_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrente_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcolumnea_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolabial_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsurcomentolabial_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmenton_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtangulomentogarg__hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsecerupcion_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtparalelismored_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtproporcoronaraiz_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes__hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesrete_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientessuper_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionperio_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionendod_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtanatomiacond_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtestadoligamiento_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpisosenomax_hp2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtagujeromento_hp2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.chklineasupercentr.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeder.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeizq.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm1_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm2_hp3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfecentr.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfededer.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfedeizq.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm1_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm2_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverbite_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverjet_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentedientesausen_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtldereoverject_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderoverbite_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelcanina_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelmolar_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderdientesausen_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverject_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverbite_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelcanina_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelmolar_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqudientesausen_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupforma_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupsime_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupausen_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfforma_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfsime_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfausen_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdesviacion_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdeflexion_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticruidosart_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticsintomat_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialtperfil_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangconje_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfaciallabios_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangnasolab_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquclase_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquesqu_hp3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdesqudimensvert_hp3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmalomolar_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmalocanina_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttdenticion_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlmedias_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtoverjet_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtoverbite_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttipoapi_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmejorarperfil_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfil_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolab_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtctrlperfesq_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfesq_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrfrente_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlograroverjet_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrmolarcan_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrbuenaocl_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtplan1_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtplan2_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtplan3_hp4.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia.rbTrataNo.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtreqtratam_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcuantas_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.texttratamientodef_hp4.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia.textlimitacaso_hp4.Text = ""

                Case "limpiarhcorto2"

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtenfermedadanterior_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txttratamedico_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckefebriles_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckdiarrea_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckfatiga_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckpeso_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckinfecciones_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.cksudoracion_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckTinmuno_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckTanti_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckPvalcard_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckhEB_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckhcomuq_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckhmalcard_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckhfiebrereu_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckdiabetes_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckharterial_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckpenicilina_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckanestecia_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckotros_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia2.ckembarazo_no.Checked = True

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtalergiasotros_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtcresimientodesarrollo_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtantecedentes_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_frente_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_labios_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_lineasonr_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_selladolabial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_perfil_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_menton_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_angulonaso_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_surcolabio_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_otros_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_tejidosblandos_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_rehabilitacion_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_endodoncia_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_periodoncia_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_dientesausentes_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_dientesincluidos_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.chkdenticion.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia2.chktemporal.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia2.chkmixta.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia2.chkpermanente.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_apinamiento_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_diastemas_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_overjet_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_overbite_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_lineamedia_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_tamdentario_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_formaarcada_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_mordidacruzada_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_curvaspee_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_claseangle_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_bolton_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_habitos_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_atm_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_manipulacion_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_otros_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtodonto_analisisespacio_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_sna_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_sna_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_sna_final_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_snb_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_snb_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_snb_final_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_anb_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_anb_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_anb_final_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pp_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pp_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pp_final_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pm_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pm_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pm_final_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_go_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_go_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_go_final_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_max_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_max_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_max_final_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_otros_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_otros_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_otros_final_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_modelos_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_modelos_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_modelos_final_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_pano_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_pano_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_pano_final_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_perfil_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_perfil_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_perfil_final_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_intra_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_intra_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_intra_final_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_extra_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_extra_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_extra_final_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_otras_inicial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_otras_control_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_otras_final_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtdiag_facial_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtdiag_esque_horto2.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtdiag_dental_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtplantratamiento_horto2.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtalternativas_horto2.Text = ""

                Case "limpiarhcorto3"

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtmconsulta_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckconciente_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckproblemadental_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckfatiga_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckdeporte_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckinstrumento_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckrevision_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckSedadental_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckpadeceenfermedad_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckmedicamento_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckalergias_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckinfgarganta_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckamigdalas_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckadenoides_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckcirugia_no.Checked = True
                    My.Forms.frmHistoriaClinicaOrtodoncia3.ckcirugia_no.Checked = True

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtparentezco_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkChuparsededos.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkMorderseunas.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkMorderselabios.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkRespirarboca.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkRechinarDientes.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcepillarseveces_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkExcesiva.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkRegular.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkBaja.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtobservaciones_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtenfermedadactual_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtmedicamento_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkDesordenes.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkSangrado.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkAnomaliasCong.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkFiebreReum.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkEConvulsivas.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkObstruccionNasal.Checked = False
                    My.Forms.frmHistoriaClinicaOrtodoncia3.chkAccidentescara.Checked = False

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcuandoafecciones_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtalergiasaque_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcuandoamigdalas_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcuandoadenoides_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcualcirugia_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtsna_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtsnb_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtanb_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtipp_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtina_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtipm_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtinb_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtles_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtlei_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtgo_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtobservacionesaencef_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_facial_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_esque_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_dental_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_periodontal_horto3.Text = ""

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtplantratamiento_horto3.Text = ""
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtalternativas_horto3.Text = ""

                Case "limpiardoctores"

                    My.Forms.frmDoctores.pbFoto_doc.Image = My.Resources.fondodoctor
                    My.Forms.frmDoctores.txtIddoctor.Text = ""
                    My.Forms.frmDoctores.txtapellidos_doc.Text = ""
                    My.Forms.frmDoctores.txtapellidos_doc.Focus()
                    My.Forms.frmDoctores.txtnombres_doc.Text = ""
                    My.Forms.frmDoctores.txtnumdoc_doc.Text = ""
                    My.Forms.frmDoctores.txtresidencia_doc.Text = ""
                    My.Forms.frmDoctores.txtIddoctor.Text = ""
                    My.Forms.frmDoctores.cmbEspecialidades.SelectedValue = 1
                    My.Forms.frmDoctores.txtoficina_doc.Text = ""
                    My.Forms.frmDoctores.cmbfecingreso_doc.Value = Format(Now(), "short date")
                    My.Forms.frmDoctores.cmbfecingreso_doc.MaxDate = Format(Now(), "short date")
                    My.Forms.frmDoctores.cmbfecnac_doc.Value = Format(Now(), "short date")
                    My.Forms.frmDoctores.cmbfecnac_doc.MaxDate = Format(Now(), "short date")
                    My.Forms.frmDoctores.cmbtipodoc_doc.Text = ""
                    My.Forms.frmDoctores.rbtMasculino_doc.Checked = True
                    My.Forms.frmDoctores.rbtAños_doc.Checked = True
                    My.Forms.frmDoctores.lblNumaños.Text = "0"

                    My.Forms.frmDoctores.txtCelular_doc.Text = ""
                    My.Forms.frmDoctores.txtemail_doc.Text = ""
                    My.Forms.frmDoctores.txtTelOficina_doc.Text = ""
                    My.Forms.frmDoctores.txtFax_doc.Text = ""
                    My.Forms.frmDoctores.txtTelCasa_doc.Text = ""
                    My.Forms.frmDoctores.txtweb_doc.Text = ""
                    My.Forms.frmDoctores.txtoficina_doc.Text = ""
                    My.Forms.frmDoctores.RichTxtNotas_doc.Text = ""

                Case "limpiarempleados"

                    My.Forms.frmUsuarios.pbFoto_emp.Image = My.Resources.fondoempleado
                    My.Forms.frmUsuarios.txtIdempleado.Text = ""
                    My.Forms.frmUsuarios.txtapellidos_emp.Text = ""
                    My.Forms.frmUsuarios.txtapellidos_emp.Focus()
                    My.Forms.frmUsuarios.txtnombres_emp.Text = ""
                    My.Forms.frmUsuarios.txtnumdoc_emp.Text = ""
                    My.Forms.frmUsuarios.txtresidencia_emp.Text = ""
                    My.Forms.frmUsuarios.txtIdempleado.Text = ""
                    My.Forms.frmUsuarios.txtEspecialidad_emp.Text = ""
                    My.Forms.frmUsuarios.cmbfecingreso_emp.Value = Format(Now(), "short date")
                    My.Forms.frmUsuarios.cmbfecingreso_emp.MaxDate = Format(Now(), "short date")
                    My.Forms.frmUsuarios.cmbfecnac_emp.Value = Format(Now(), "short date")
                    My.Forms.frmUsuarios.cmbfecnac_emp.MaxDate = Format(Now(), "short date")
                    My.Forms.frmUsuarios.cmbtipodoc_emp.Text = ""
                    My.Forms.frmUsuarios.txtClave_emp.Text = ""
                    My.Forms.frmUsuarios.txtClave2_emp.Text = ""
                    My.Forms.frmUsuarios.rbtMasculino_emp.Checked = True
                    My.Forms.frmUsuarios.rbtAños_emp.Checked = True
                    My.Forms.frmUsuarios.cmbPerfilAcceso.Text = ""
                    My.Forms.frmUsuarios.lblNumaños.Text = "0"

                    My.Forms.frmUsuarios.txtCelConyuge_emp.Text = ""
                    My.Forms.frmUsuarios.txtCelMadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtCelPadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtCelular_emp.Text = ""
                    My.Forms.frmUsuarios.txtConyuge_emp.Text = ""
                    My.Forms.frmUsuarios.txtemail_emp.Text = ""
                    My.Forms.frmUsuarios.txtFax_emp.Text = ""
                    My.Forms.frmUsuarios.txtMadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtOcuConyuge_emp.Text = ""
                    My.Forms.frmUsuarios.txtOcuMadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtOcuPadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtPadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtTelCasa_emp.Text = ""
                    My.Forms.frmUsuarios.txtTelConyuge_emp.Text = ""
                    My.Forms.frmUsuarios.txtTelMadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtTelPadre_emp.Text = ""
                    My.Forms.frmUsuarios.txtweb_emp.Text = ""
                    My.Forms.frmUsuarios.RichTxtNotas_emp.Text = ""

                Case "limpiarentidades"

                    My.Forms.frmEntidades.txtIdentidad.Text = ""
                    My.Forms.frmEntidades.txtcontacto_ent.Text = ""
                    My.Forms.frmEntidades.txtnombre_ent.Text = ""
                    My.Forms.frmEntidades.txtnombre_ent.Focus()
                    My.Forms.frmEntidades.txtdireccion_ent.Text = ""
                    My.Forms.frmEntidades.txtcontacto_ent.Text = ""
                    My.Forms.frmEntidades.txtcodigo_ent.Text = ""

                    My.Forms.frmEntidades.txtCelular_ent.Text = ""
                    My.Forms.frmEntidades.txtemail_ent.Text = ""
                    My.Forms.frmEntidades.txtFax_ent.Text = ""
                    My.Forms.frmEntidades.txtweb_ent.Text = ""
                    My.Forms.frmEntidades.txtTelOficina_ent.Text = ""
                    My.Forms.frmEntidades.RichTxtNotas_ent.Text = ""

                Case "limpiarproveedores"

                    My.Forms.frmProveedores.txtIdproveedor.Text = ""
                    My.Forms.frmProveedores.txtnombre_prov.Text = ""
                    My.Forms.frmProveedores.txtdireccion_prov.Text = ""
                    My.Forms.frmProveedores.txtcontacto_prov.Text = ""
                    My.Forms.frmProveedores.txtteloficina_prov.Text = ""
                    My.Forms.frmProveedores.txtcelular_prov.Text = ""
                    My.Forms.frmProveedores.txtfax_prov.Text = ""
                    My.Forms.frmProveedores.txtemail_prov.Text = ""
                    My.Forms.frmProveedores.txtweb_prov.Text = ""

                Case "limpiarficha"

                    Select Case CLASE_GENERAL.formload
                        Case 1
                            My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Resources.fondopaciente
                        Case 2
                            My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Resources.fondodoctor
                        Case 3
                            My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Resources.fondoempleado
                        Case 4
                            My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Resources.fondoentidad

                    End Select

                    My.Forms.mdiOrthoSoft.txtId_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtnhistoria_ficha.Text = ""

                    My.Forms.mdiOrthoSoft.txtProxCita_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtHINI_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtHFIN_ficha.Text = ""
                    My.Forms.mdiOrthoSoft.txtproced_ficha.Text = ""

                Case "limpiaractivopaciente"

                    My.Forms.mdiOrthoSoft.lblActivoPaciente.Text = ""
                    My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag = ""
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LightSkyBlue

                Case "limpiarcalendario"

                    My.Forms.mdiOrthoSoft.StartTime.Value = New Date(2000, 1, 1, 8, 0, 0, 0)
                    My.Forms.mdiOrthoSoft.EndTime.Value = New Date(2000, 1, 1, 18, 0, 0, 0)
                    My.Forms.mdiOrthoSoft.rbtModificado.Checked = True

                    Select Case CLASE_GENERAL._rangocal
                        Case "5"
                            My.Forms.mdiOrthoSoft.rbtConfig5min.Checked = True
                        Case "10"
                            My.Forms.mdiOrthoSoft.rbtConfig10min.Checked = True
                        Case "15"
                            My.Forms.mdiOrthoSoft.rbtConfig15min.Checked = True
                        Case "30"
                            My.Forms.mdiOrthoSoft.rbtConfig30min.Checked = True
                    End Select

                    My.Forms.mdiOrthoSoft.txtTopeCita.Text = CLASE_GENERAL._topecita

                Case "limpiarscheduler"

                    My.Forms.mdiOrthoSoft.rbtModificado.Checked = True

                    Select Case CLASE_GENERAL._rangocal
                        Case "5"
                            My.Forms.mdiOrthoSoft.rbtConfig5min.Checked = True
                        Case "10"
                            My.Forms.mdiOrthoSoft.rbtConfig10min.Checked = True
                        Case "15"
                            My.Forms.mdiOrthoSoft.rbtConfig15min.Checked = True
                        Case "30"
                            My.Forms.mdiOrthoSoft.rbtConfig30min.Checked = True
                    End Select

                    My.Forms.mdiOrthoSoft.cmbTipoConsulta.SelectedValue = 3
                    My.Forms.mdiOrthoSoft.lblTipoConsulta.BackColor = Color.LimeGreen
                    My.Forms.mdiOrthoSoft.rbtCanceladaNo.Checked = True
                    My.Forms.mdiOrthoSoft.rbtAsistioNo.Checked = True


                Case "limpiarschedulernuevo"

                    My.Forms.mdiOrthoSoft.cmbTipoConsulta.SelectedValue = 3
                    My.Forms.mdiOrthoSoft.lblTipoConsulta.BackColor = Color.LimeGreen
                    My.Forms.mdiOrthoSoft.rbtCanceladaNo.Checked = True
                    My.Forms.mdiOrthoSoft.rbtAsistioNo.Checked = True

                Case "limpiarschedulermulti"

                    My.Forms.mdiOrthoSoft.rbtModificado.Checked = True

                    Select Case CLASE_GENERAL._rangocal
                        Case "5"
                            My.Forms.mdiOrthoSoft.rbtConfig5min.Checked = True
                        Case "10"
                            My.Forms.mdiOrthoSoft.rbtConfig10min.Checked = True
                        Case "15"
                            My.Forms.mdiOrthoSoft.rbtConfig15min.Checked = True
                        Case "30"
                            My.Forms.mdiOrthoSoft.rbtConfig30min.Checked = True
                    End Select

                    My.Forms.frmAppointment.cmbTipoConsulta.SelectedValue = 3
                    My.Forms.frmAppointment.lblTipoConsulta.BackColor = Color.LimeGreen
                    My.Forms.frmAppointment.rbtCanceladaNo.Checked = True
                    My.Forms.frmAppointment.rbtAsistioNo.Checked = True


                Case "limpiarschedulernuevomulti"

                    My.Forms.frmAppointment.cmbTipoConsulta.SelectedValue = 3
                    My.Forms.frmAppointment.lblTipoConsulta.BackColor = Color.LimeGreen
                    My.Forms.frmAppointment.rbtCanceladaNo.Checked = True
                    My.Forms.frmAppointment.rbtAsistioNo.Checked = True

                Case "limpiarrcaja"

                    My.Forms.frmRCaja.cmbfecha_rc.Value = Date.Now
                    My.Forms.frmRCaja.txtTotal_rc.Text = 0
                    My.Forms.frmRCaja.txtEfectivo_rc.Text = 0
                    My.Forms.frmRCaja.txtTarjeta_rc.Text = 0
                    My.Forms.frmRCaja.txtIdpaciente.Text = ""
                    My.Forms.frmRCaja.txtNombre_pac.Text = ""
                    My.Forms.frmRCaja.txtConcepto_rc.Text = ""
                    My.Forms.frmRCaja.txtIdprocedimiento.Text = ""
                    My.Forms.frmRCaja.txtvalor_proc.Text = 0
                    My.Forms.frmRCaja.txtCantidad.Text = 1
                    My.Forms.frmRCaja.txtTotal.Text = 0
                    My.Forms.frmRCaja.cmbItem.Text = ""
                    My.Forms.frmRCaja.txtcheque_rc.Text = ""
                    My.Forms.frmRCaja.txtbanco_rc.Text = ""
                    My.Forms.frmRCaja.txtobservaciones_rc.Text = ""

                Case "limpiacegreso"

                    My.Forms.frmComprobanteEgreso.txtIdce.Text = ""
                    My.Forms.frmComprobanteEgreso.txttotal_ce.Text = 0
                    My.Forms.frmComprobanteEgreso.txtIdproveedor.Text = ""
                    My.Forms.frmComprobanteEgreso.cmbProveedores.Text = ""
                    My.Forms.frmComprobanteEgreso.txtconcepto_ce.Text = ""
                    My.Forms.frmComprobanteEgreso.txtciudad_ce.Text = ""
                    My.Forms.frmComprobanteEgreso.txtIdgasto.Text = ""
                    My.Forms.frmComprobanteEgreso.cmbItemGastos.Text = ""
                    My.Forms.frmComprobanteEgreso.txtobservacion_gas.Text = ""
                    My.Forms.frmComprobanteEgreso.txtvalor_gas.Text = ""
                    My.Forms.frmComprobanteEgreso.txtobservaciones_ce.Text = ""
                    My.Forms.frmComprobanteEgreso.txtdebitesea_ce.Text = ""
                    My.Forms.frmComprobanteEgreso.txtcheque_ce.Text = ""
                    My.Forms.frmComprobanteEgreso.txtbanco_ce.Text = ""

                Case "limpiarprocedimientodiario"

                    My.Forms.frmProcedimientoDiario.memoProcedimiento.Text = ""

                Case "limpiarperfiles"

                    My.Forms.frmNivelesAccesos.txtnom_perf.Text = ""
                    My.Forms.frmNivelesAccesos.cmbPerfilAcceso.Text = ""

                    My.Forms.frmNivelesAccesos.chk_TabFunciones_TodasCitas.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_CitasDia.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_CitasFuturas.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_CitasSinAsistir.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_InfoAsignadoDia.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_Infogral.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_CumpleHoy.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_CumpleSem.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_CumpleMes.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_PacientesBq.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_BlqDia.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_BlqPaciente.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_EnviarMenCall.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_EnviarMenEmail.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_EnviarMenSMS.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFunciones_Calculadora.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabBackup_Copia.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabBackup_Restaurar.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabCambioUsu_Cambio.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabSincro_Sincro.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabSincro_SoporteRemoto.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabSincro_Actualizacion.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabSincro_Cirugia.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuPac_Pac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuPac_NPac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuPac_BPac.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuDoc_Doc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuDoc_NDoc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuDoc_BDoc.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuUsu_Usu.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuUsu_NUsu.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuUsu_BUsu.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuEnt_Ent.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuEnt_NEnt.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuEnt_BEnt.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuEnt_NProv.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuEnt_BProv.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuInf_Inf.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuInf_InfV.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuInf_ProcD.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuInf_Documentos.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuAdm_Adm.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuAdm_Aut.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuAdm_Audito.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuAdm_Import.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuAdm_Config.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuAdm_Acceso.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuCitas_Citas.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuCitas_Reminder.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuCitas_BloquearCitas.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_Conta.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_RCaja.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_CEgreso.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_Presupuesto.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_Vprocedimiento.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_ECuenta.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_Gastos.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuConta_MDiario.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabMnuVarios.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabMnuVarios_Ilustraciones.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabSchSup_Cambio.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabSchSup_BuscaHuellas.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabSch_Control.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabSch_SplittCitas.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabCitas_ACita.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_MCita.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_ECita.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_ICita.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_TConsul.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_NotaCita.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_CitaCanc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_CitaAsis.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_CambioDoc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabCitas_RangoCita.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabFicha_EPac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_BPac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_EmailPac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_SplitAgenda.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabFicha_ProcDiario.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_SMS.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_Odontograma.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_EstadoCuenta.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_Estudios.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabFicha_HC.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabPac_APac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabPac_MPac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabPac_BPac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabPac_NPac.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabDoc_ADoc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabDoc_MDoc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabDoc_BDoc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabDoc_NDoc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabUsu_AUsu.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabUsu_MUsu.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabUsu_BUsu.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabUsu_NUsu.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabEnt_AEnt.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabEnt_MEnt.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabEnt_BEnt.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabEnt_NEnt.Checked = False

                    My.Forms.frmNivelesAccesos.chk_TabHC_Nuevag.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabHC_Modificarg.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabHC_Desblg.Checked = False
                    My.Forms.frmNivelesAccesos.chk_TabHC_Nuevag.Checked = False

                    My.Forms.frmNivelesAccesos.chk_Tabproc_AProc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_Tabproc_MProc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_Tabproc_BProc.Checked = False
                    My.Forms.frmNivelesAccesos.chk_Tabproc_NProc.Checked = False

                Case "limpiarpresupuesto"

                    My.Forms.frmPresupuesto.cmbfec_cuota.Value = Date.Now
                    My.Forms.frmPresupuesto.cmbfecha_ad.Value = Date.Now
                    My.Forms.frmPresupuesto.txtVTotal_cuota.Text = "0"
                    My.Forms.frmPresupuesto.txtNCuotasIni_cuota.Text = "01"
                    My.Forms.frmPresupuesto.txtVCuotasIni_cuota.Text = "0"
                    My.Forms.frmPresupuesto.txtTCuotasIni_cuota.Text = "0"
                    My.Forms.frmPresupuesto.txtNCuotas_cuota.Text = "01"
                    My.Forms.frmPresupuesto.txtVCuotas_cuota.Text = "0"
                    My.Forms.frmPresupuesto.txtTCuotas_cuota.Text = "0"
                    My.Forms.frmPresupuesto.txtVTotalPresupuesto.Text = "0"
                    My.Forms.frmPresupuesto.cmbIntervaloCuotas.SelectedIndex = 2
                    My.Forms.frmPresupuesto.txtIdPres.Text = ""
                    My.Forms.frmPresupuesto.dgCuotas.DataSource = Nothing
                    My.Forms.frmPresupuesto.dgCuotas.Rows.Clear()

                Case "limpiarvalorprocedimientos"

                    My.Forms.frmProcedimientosItems.txtIdprocedimiento.Text = ""
                    My.Forms.frmProcedimientosItems.txtdescripcion_proc.Text = ""
                    My.Forms.frmProcedimientosItems.txtreferencia_proc.Text = ""
                    My.Forms.frmProcedimientosItems.txtvalor_proc.Text = "0"
                    My.Forms.frmProcedimientosItems.cmbEspecialidades.SelectedValue = 1

                Case "limpiargastos"

                    My.Forms.frmGastos.txtIdgasto.Text = ""
                    My.Forms.frmGastos.txtconcepto_gas.Text = ""
                    My.Forms.frmGastos.txtobservacion_gas.Text = ""

                Case "limpiarespecialidad"

                    My.Forms.frmConfiguraciones.txtIdespecialidad.Text = ""
                    My.Forms.frmConfiguraciones.txtnom_especialidad.Text = ""

                Case "limpiaroperador"

                    My.Forms.frmConfiguraciones.txtIdoperador.Text = ""
                    My.Forms.frmConfiguraciones.txtnom_oper.Text = ""
                    My.Forms.frmConfiguraciones.txtdominio_oper.Text = ""

                Case "limpiarunidad"

                    My.Forms.frmConfiguraciones.txtIdunidad.Text = ""
                    My.Forms.frmConfiguraciones.cmbIdestado.SelectedValue = 1
                    My.Forms.frmConfiguraciones.txtnom_unidad.Text = ""
                    My.Forms.frmConfiguraciones.cmbIdespecialidad.SelectedValue = 1

                Case "limpiarlibro"

                    My.Forms.frmMovimientoDiario.txtTrcajadebitos.Text = 0
                    My.Forms.frmMovimientoDiario.txtTfacturasdebito.Text = 0
                    My.Forms.frmMovimientoDiario.txtTcegresoCreditos.Text = 0
                    My.Forms.frmMovimientoDiario.txtNrcajaActivos.Text = 0
                    My.Forms.frmMovimientoDiario.txtNfacturasActivos.Text = 0
                    My.Forms.frmMovimientoDiario.txtNcegresoActivos.Text = 0
                    My.Forms.frmMovimientoDiario.txtNrcajaAnulados.Text = 0
                    My.Forms.frmMovimientoDiario.txtNfacturasAnulados.Text = 0
                    My.Forms.frmMovimientoDiario.txtNcegresoAnulados.Text = 0
                    My.Forms.frmMovimientoDiario.txtTCajaMenordebitos.Text = 0
                    My.Forms.frmMovimientoDiario.txtTPagoEfectivodebitos.Text = 0
                    My.Forms.frmMovimientoDiario.txtTPagoTarjetadebitos.Text = 0
                    My.Forms.frmMovimientoDiario.txtTotalDebitos.Text = 0
                    My.Forms.frmMovimientoDiario.txtTMovimientoDiario.Text = 0
                    My.Forms.frmMovimientoDiario.txtTotalCreditos.Text = 0

            End Select

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Public Sub bloquaerdesbloquear(ByVal opcion As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        Select Case opcion

            ' Perfiles

            Case "nuevoperfil"

                My.Forms.frmNivelesAccesos.btnModificar.Enabled = False
                My.Forms.frmNivelesAccesos.btnEliminar.Enabled = False
                My.Forms.frmNivelesAccesos.btnAdicionar.Enabled = True

            Case "editarperfil"

                My.Forms.frmNivelesAccesos.btnAdicionar.Enabled = False
                My.Forms.frmNivelesAccesos.btnModificar.Enabled = True
                My.Forms.frmNivelesAccesos.btnEliminar.Enabled = True

                'Pacientes

            Case "nuevopaciente"

                My.Forms.frmPacientes.btnModificar.Enabled = False
                My.Forms.frmPacientes.btnEliminar.Enabled = False

                If My.Forms.frmPacientes.btnAdicionar.Tag = "1" Then
                    My.Forms.frmPacientes.btnAdicionar.Enabled = True
                End If


            Case "editarpaciente"

                My.Forms.frmPacientes.btnAdicionar.Enabled = False

                If My.Forms.frmPacientes.btnModificar.Tag = "1" Then
                    My.Forms.frmPacientes.btnModificar.Enabled = True
                End If

                If My.Forms.frmPacientes.btnEliminar.Tag = "1" Then
                    My.Forms.frmPacientes.btnEliminar.Enabled = True
                End If


                'H. C. general

            Case "nuevahcg"

                If My.Forms.frmHistoriaClinicaGeneral.btnAdicionar.Tag = "1" Then
                    My.Forms.frmHistoriaClinicaGeneral.btnAdicionar.Enabled = True
                End If

                My.Forms.frmHistoriaClinicaGeneral.btnModificar.Enabled = False

                If My.Forms.frmHistoriaClinicaGeneral.btnNuevo.Tag = "1" Then
                    My.Forms.frmHistoriaClinicaGeneral.btnNuevo.Enabled = True
                End If

            Case "editarhcg"

                My.Forms.frmHistoriaClinicaGeneral.btnAdicionar.Enabled = False

                If My.Forms.frmHistoriaClinicaGeneral.btnModificar.Tag = "1" Then
                    My.Forms.frmHistoriaClinicaGeneral.btnModificar.Enabled = True
                End If

                My.Forms.frmHistoriaClinicaGeneral.btnNuevo.Enabled = False

                'H. C. Orto

            Case "nuevahcorto"

                My.Forms.frmHistoriaClinicaOrtodoncia.btnAdicionar.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.btnModificar.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.btnNuevo.Enabled = True


            Case "editarhcorto"

                My.Forms.frmHistoriaClinicaOrtodoncia.btnAdicionar.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.btnModificar.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.btnNuevo.Enabled = False


                'H. C. Orto 2

            Case "nuevahcorto2"

                My.Forms.frmHistoriaClinicaOrtodoncia2.btnAdicionar.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia2.btnModificar.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia2.btnNuevo.Enabled = True

            Case "editarhcorto2"

                My.Forms.frmHistoriaClinicaOrtodoncia2.btnAdicionar.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia2.btnModificar.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia2.btnNuevo.Enabled = False

                'H. C. Orto 3

            Case "nuevahcorto3"

                My.Forms.frmHistoriaClinicaOrtodoncia3.btnAdicionar.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia3.btnModificar.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia3.btnNuevo.Enabled = True

            Case "editarhcorto3"

                My.Forms.frmHistoriaClinicaOrtodoncia3.btnAdicionar.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia3.btnModificar.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia3.btnNuevo.Enabled = False

                'Doctores

            Case "nuevodoctor"

                My.Forms.frmDoctores.btnModificar.Enabled = False
                My.Forms.frmDoctores.btnEliminar.Enabled = False

                If My.Forms.frmDoctores.btnAdicionar.Tag = "1" Then
                    My.Forms.frmDoctores.btnAdicionar.Enabled = True
                End If


            Case "editardoctor"

                My.Forms.frmDoctores.btnAdicionar.Enabled = False

                If My.Forms.frmDoctores.btnModificar.Tag = "1" Then
                    My.Forms.frmDoctores.btnModificar.Enabled = True
                End If

                If My.Forms.frmDoctores.btnEliminar.Tag = "1" Then
                    My.Forms.frmDoctores.btnEliminar.Enabled = True
                End If

                'Empleados

            Case "nuevoempleado"

                My.Forms.frmUsuarios.btnModificar.Enabled = False
                My.Forms.frmUsuarios.btnEliminar.Enabled = False

                If My.Forms.frmUsuarios.btnAdicionar.Tag = "1" Then
                    My.Forms.frmUsuarios.btnAdicionar.Enabled = True
                End If


            Case "editarempleado"

                My.Forms.frmUsuarios.btnAdicionar.Enabled = False

                If My.Forms.frmUsuarios.btnModificar.Tag = "1" Then
                    My.Forms.frmUsuarios.btnModificar.Enabled = True
                End If

                If My.Forms.frmUsuarios.btnEliminar.Tag = "1" Then
                    My.Forms.frmUsuarios.btnEliminar.Enabled = True
                End If

                'Entidades

            Case "nuevaentidad"

                My.Forms.frmEntidades.btnModificar.Enabled = False
                My.Forms.frmEntidades.btnEliminar.Enabled = False

                If My.Forms.frmEntidades.btnAdicionar.Tag = "1" Then
                    My.Forms.frmEntidades.btnAdicionar.Enabled = True
                End If

            Case "editarentidad"

                My.Forms.frmEntidades.btnAdicionar.Enabled = False

                If My.Forms.frmEntidades.btnModificar.Tag = "1" Then
                    My.Forms.frmEntidades.btnModificar.Enabled = True
                End If

                If My.Forms.frmEntidades.btnEliminar.Tag = "1" Then
                    My.Forms.frmEntidades.btnEliminar.Enabled = True
                End If

                'proveedores

            Case "nuevoproveedor"

                My.Forms.frmProveedores.btnModificar.Enabled = False
                My.Forms.frmProveedores.btnEliminar.Enabled = False
                My.Forms.frmProveedores.btnAdicionar.Enabled = True

            Case "editarproveedor"

                My.Forms.frmProveedores.btnAdicionar.Enabled = False
                My.Forms.frmProveedores.btnModificar.Enabled = True
                My.Forms.frmProveedores.btnEliminar.Enabled = True

                'Calendario

            Case "nuevocalendario"
                My.Forms.mdiOrthoSoft.btnCalModificar.Enabled = False
                My.Forms.mdiOrthoSoft.btnCalEliminar.Enabled = False
                My.Forms.mdiOrthoSoft.btnCalAdicionar.Enabled = True

                My.Forms.mdiOrthoSoft.btnCalModificar2.Enabled = False
                My.Forms.mdiOrthoSoft.btnCalAdicionar2.Enabled = True

            Case "editarcalendario"
                My.Forms.mdiOrthoSoft.btnCalAdicionar.Enabled = False
                My.Forms.mdiOrthoSoft.btnCalModificar.Enabled = True
                My.Forms.mdiOrthoSoft.btnCalEliminar.Enabled = True

                My.Forms.mdiOrthoSoft.btnCalAdicionar2.Enabled = False
                My.Forms.mdiOrthoSoft.btnCalModificar2.Enabled = True

                'Sheduler

            Case "nuevoscheduler"


                My.Forms.mdiOrthoSoft.btnCitaModificar.Enabled = False
                My.Forms.mdiOrthoSoft.btnCitaModificar2.Enabled = False
                My.Forms.mdiOrthoSoft.btnCitaEliminar.Enabled = False
                My.Forms.mdiOrthoSoft.btnCitaImprimir.Enabled = False

                If My.Forms.mdiOrthoSoft.btnCitaAdicionar.Tag = "1" Then
                    My.Forms.mdiOrthoSoft.btnCitaAdicionar.Enabled = True
                End If

            Case "nuevoschedulermulti"

                My.Forms.frmAppointment.btnCitaModificar.Enabled = False
                My.Forms.frmAppointment.btnCitaModificar2.Enabled = False
                My.Forms.frmAppointment.btnCitaEliminar.Enabled = False
                My.Forms.frmAppointment.btnCitaImprimir.Enabled = False

                If My.Forms.frmAppointment.btnCitaAdicionar.Tag = "1" Then
                    My.Forms.frmAppointment.btnCitaAdicionar.Enabled = True
                End If

            Case "editarscheduler"

                If My.Forms.mdiOrthoSoft.btnCitaModificar.Tag = "1" Then
                    My.Forms.mdiOrthoSoft.btnCitaModificar.Enabled = True
                    My.Forms.mdiOrthoSoft.btnCitaModificar2.Enabled = True
                End If

                If My.Forms.mdiOrthoSoft.btnCitaEliminar.Tag = "1" Then
                    My.Forms.mdiOrthoSoft.btnCitaEliminar.Enabled = True
                End If

                If My.Forms.mdiOrthoSoft.btnCitaImprimir.Tag = "1" Then
                    My.Forms.mdiOrthoSoft.btnCitaImprimir.Enabled = True
                End If

                My.Forms.mdiOrthoSoft.btnCitaAdicionar.Enabled = False

            Case "editarschedulermulti"

                If My.Forms.frmAppointment.btnCitaModificar.Tag = "1" Then
                    My.Forms.frmAppointment.btnCitaModificar.Enabled = True
                    My.Forms.frmAppointment.btnCitaModificar2.Enabled = True
                End If

                If My.Forms.frmAppointment.btnCitaEliminar.Tag = "1" Then
                    My.Forms.frmAppointment.btnCitaEliminar.Enabled = True
                End If

                If My.Forms.frmAppointment.btnCitaImprimir.Tag = "1" Then
                    My.Forms.frmAppointment.btnCitaImprimir.Enabled = True
                End If

                My.Forms.frmAppointment.btnCitaAdicionar.Enabled = False


            Case "bloquearscheduler"

                My.Forms.mdiOrthoSoft.btnCitaModificar.Enabled = False
                My.Forms.mdiOrthoSoft.btnCitaModificar2.Enabled = False
                My.Forms.mdiOrthoSoft.btnCitaEliminar.Enabled = False
                My.Forms.mdiOrthoSoft.btnCitaImprimir.Enabled = False
                My.Forms.mdiOrthoSoft.btnCitaAdicionar.Enabled = False

            Case "bloquearschedulermulti"

                My.Forms.frmAppointment.btnCitaModificar.Enabled = False
                My.Forms.frmAppointment.btnCitaModificar2.Enabled = False
                My.Forms.frmAppointment.btnCitaEliminar.Enabled = False
                My.Forms.frmAppointment.btnCitaImprimir.Enabled = False
                My.Forms.frmAppointment.btnCitaAdicionar.Enabled = False

                'Tipo de las Consultas

            Case "nuevaconsulta"

                My.Forms.frmConfiguraciones.btnConModificar.Enabled = False
                My.Forms.frmConfiguraciones.btnConEliminar.Enabled = False
                My.Forms.frmConfiguraciones.btnConAdicionar.Enabled = True

            Case "editarconsulta"

                My.Forms.frmConfiguraciones.btnConModificar.Enabled = True
                My.Forms.frmConfiguraciones.btnConEliminar.Enabled = True
                My.Forms.frmConfiguraciones.btnConAdicionar.Enabled = False

                'Mensajes Email

            Case "editarmensaje"
                My.Forms.frmMensajesEmail.btnAdicionar.Enabled = False
                My.Forms.frmMensajesEmail.btnEliminar.Enabled = True
                My.Forms.frmMensajesEmail.btnModificar.Enabled = True

            Case "nuevomensaje"
                My.Forms.frmMensajesEmail.btnAdicionar.Enabled = True
                My.Forms.frmMensajesEmail.btnEliminar.Enabled = False
                My.Forms.frmMensajesEmail.btnModificar.Enabled = False

                'Texto procedimientos

            Case "editartexto"

                My.Forms.frmTextoProcedimientos.btnAdicionar.Enabled = False
                My.Forms.frmTextoProcedimientos.btnEliminar.Enabled = True
                My.Forms.frmTextoProcedimientos.btnModificar.Enabled = True

            Case "nuevotexto"

                My.Forms.frmTextoProcedimientos.btnAdicionar.Enabled = True
                My.Forms.frmTextoProcedimientos.btnEliminar.Enabled = False
                My.Forms.frmTextoProcedimientos.btnModificar.Enabled = False

                ' Procedimientos Diarios

            Case "nuevoprocedimientodiario"

                If My.Forms.frmProcedimientoDiario.btnAdicionar.Tag = "1" Then
                    My.Forms.frmProcedimientoDiario.btnAdicionar.Enabled = True
                End If

                My.Forms.frmProcedimientoDiario.btnEliminar.Enabled = False
                My.Forms.frmProcedimientoDiario.btnModificar.Enabled = False

            Case "editarprocedimientodiario"

                My.Forms.frmProcedimientoDiario.btnAdicionar.Enabled = False

                If My.Forms.frmProcedimientoDiario.btnEliminar.Tag = "1" Then
                    My.Forms.frmProcedimientoDiario.btnEliminar.Enabled = True
                End If

                If My.Forms.frmProcedimientoDiario.btnModificar.Tag = "1" Then
                    My.Forms.frmProcedimientoDiario.btnModificar.Enabled = True
                End If

                ' Editar Dias

            Case "editardia"

                My.Forms.mdiOrthoSoft.GroupHorarioLaboral.Enabled = True
                My.Forms.mdiOrthoSoft.GroupRangoAgenda.Enabled = True
                My.Forms.mdiOrthoSoft.txtTopeCita.Enabled = True

            Case "bloqueardia"

                My.Forms.mdiOrthoSoft.GroupHorarioLaboral.Enabled = False
                My.Forms.mdiOrthoSoft.GroupRangoAgenda.Enabled = False
                My.Forms.mdiOrthoSoft.txtTopeCita.Enabled = False

                'Citas

            Case "bloquearcita"

                My.Forms.mdiOrthoSoft.rbtAsistioSi.Enabled = False
                My.Forms.mdiOrthoSoft.rbtAsistioNo.Enabled = False
                My.Forms.mdiOrthoSoft.rbtAsistioNo.Checked = True
                My.Forms.mdiOrthoSoft.rbtCanceladaSi.Enabled = False
                My.Forms.mdiOrthoSoft.rbtCanceladaNo.Enabled = False
                My.Forms.mdiOrthoSoft.rbtCanceladaNo.Checked = True

            Case "bloquearcitamulti"

                My.Forms.frmAppointment.rbtAsistioSi.Enabled = False
                My.Forms.frmAppointment.rbtAsistioNo.Enabled = False
                My.Forms.frmAppointment.rbtAsistioNo.Checked = True
                My.Forms.frmAppointment.rbtCanceladaSi.Enabled = False
                My.Forms.frmAppointment.rbtCanceladaNo.Enabled = False
                My.Forms.frmAppointment.rbtCanceladaNo.Checked = True

            Case "editarcita"

                My.Forms.mdiOrthoSoft.rbtAsistioSi.Enabled = True
                My.Forms.mdiOrthoSoft.rbtAsistioNo.Enabled = True
                My.Forms.mdiOrthoSoft.rbtCanceladaSi.Enabled = True
                My.Forms.mdiOrthoSoft.rbtCanceladaNo.Enabled = True

            Case "editarcitamulti"

                My.Forms.frmAppointment.rbtAsistioSi.Enabled = True
                My.Forms.frmAppointment.rbtAsistioNo.Enabled = True
                My.Forms.frmAppointment.rbtCanceladaSi.Enabled = True
                My.Forms.frmAppointment.rbtCanceladaNo.Enabled = True

                'Valorprocedimientos

            Case "editarvalorprocedimiento"

                My.Forms.frmProcedimientosItems.btnAdicionar.Enabled = False
                My.Forms.frmProcedimientosItems.btnEliminar.Enabled = True
                My.Forms.frmProcedimientosItems.btnModificar.Enabled = True

            Case "nuevovalorprocedimiento"

                My.Forms.frmProcedimientosItems.btnAdicionar.Enabled = True
                My.Forms.frmProcedimientosItems.btnEliminar.Enabled = False
                My.Forms.frmProcedimientosItems.btnModificar.Enabled = False

                'Valorprocedimientos

            Case "editaritemgasto"

                My.Forms.frmGastos.btnAdicionar.Enabled = False
                My.Forms.frmGastos.btnEliminar.Enabled = True
                My.Forms.frmGastos.btnModificar.Enabled = True

            Case "nuevoitemgasto"

                My.Forms.frmGastos.btnAdicionar.Enabled = True
                My.Forms.frmGastos.btnEliminar.Enabled = False
                My.Forms.frmGastos.btnModificar.Enabled = False

                'Especialidades

            Case "editarespecialidad"

                My.Forms.frmConfiguraciones.btnAdicionarEsp.Enabled = False
                My.Forms.frmConfiguraciones.btnEliminarEsp.Enabled = True
                My.Forms.frmConfiguraciones.btnModificarEsp.Enabled = True

            Case "nuevaespecialidad"

                My.Forms.frmConfiguraciones.btnAdicionarEsp.Enabled = True
                My.Forms.frmConfiguraciones.btnEliminarEsp.Enabled = False
                My.Forms.frmConfiguraciones.btnModificarEsp.Enabled = False

            Case "editaroperador"

                My.Forms.frmConfiguraciones.btnAdicionarCel.Enabled = False
                My.Forms.frmConfiguraciones.btnEliminarCel.Enabled = True
                My.Forms.frmConfiguraciones.btnModificarCel.Enabled = True

            Case "nuevaunidad"

                My.Forms.frmConfiguraciones.btnAdicionarUni.Enabled = True
                My.Forms.frmConfiguraciones.btnEliminarUni.Enabled = False
                My.Forms.frmConfiguraciones.btnModificarUni.Enabled = False

            Case "editarunidad"

                My.Forms.frmConfiguraciones.btnAdicionarUni.Enabled = False
                My.Forms.frmConfiguraciones.btnEliminarUni.Enabled = True
                My.Forms.frmConfiguraciones.btnModificarUni.Enabled = True

            Case "nuevooperador"

                My.Forms.frmConfiguraciones.btnAdicionarCel.Enabled = True
                My.Forms.frmConfiguraciones.btnEliminarCel.Enabled = False
                My.Forms.frmConfiguraciones.btnModificarCel.Enabled = False

            Case "cerrarexplorer"

                My.Forms.mdiOrthoSoft.ExplorerCitas.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerDoctores.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerAdministracion.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerEntidades.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerInformes.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerPacientes.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerUsuarios.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerVarios.Expanded = False
                My.Forms.mdiOrthoSoft.ExplorerContab.Expanded = False

                ' ****************** BLOQUEAR DESBLOQUEAR HISTORIA CLINICA *******************

            Case "bloquearhclinicageneral"

                'ANTECEDENTES
                '1
                My.Forms.frmHistoriaClinicaGeneral.ckant_tratam_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_tratam_si.Enabled = False
                '2
                My.Forms.frmHistoriaClinicaGeneral.ckant_medicam_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_medicam_si.Enabled = False
                '3
                My.Forms.frmHistoriaClinicaGeneral.ckant_alergias_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_alergias_si.Enabled = False
                '4
                My.Forms.frmHistoriaClinicaGeneral.ckant_cardiopatias_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_cardiopatias_si.Enabled = False
                '5
                My.Forms.frmHistoriaClinicaGeneral.ckant_parterial_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_parterial_si.Enabled = False
                '6
                My.Forms.frmHistoriaClinicaGeneral.ckant_embarazo_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_embarazo_si.Enabled = False
                '7
                My.Forms.frmHistoriaClinicaGeneral.ckant_diabetes_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_diabetes_si.Enabled = False
                '8
                My.Forms.frmHistoriaClinicaGeneral.ckant_hepatitis_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_hepatitis_si.Enabled = False
                '9
                My.Forms.frmHistoriaClinicaGeneral.ckant_irradia_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_irradia_si.Enabled = False
                '10
                My.Forms.frmHistoriaClinicaGeneral.ckant_discrasia_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_discrasia_si.Enabled = False
                '11
                My.Forms.frmHistoriaClinicaGeneral.ckant_fiebre_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_fiebre_si.Enabled = False
                '12
                My.Forms.frmHistoriaClinicaGeneral.ckant_enfrenal_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_enfrenal_si.Enabled = False
                '13
                My.Forms.frmHistoriaClinicaGeneral.ckant_inmunos_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_inmunos_si.Enabled = False
                '14
                My.Forms.frmHistoriaClinicaGeneral.ckant_temosionales_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_temosionales_si.Enabled = False
                '15
                My.Forms.frmHistoriaClinicaGeneral.ckant_prespi_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_prespi_si.Enabled = False
                '16
                My.Forms.frmHistoriaClinicaGeneral.ckant_tgastricos_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_tgastricos_si.Enabled = False
                '17
                My.Forms.frmHistoriaClinicaGeneral.ckant_epilepsia_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_epilepsia_si.Enabled = False
                '18
                My.Forms.frmHistoriaClinicaGeneral.ckant_cirugias_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_cirugias_si.Enabled = False
                '19
                My.Forms.frmHistoriaClinicaGeneral.ckant_eorales_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_eorales_si.Enabled = False
                '20
                My.Forms.frmHistoriaClinicaGeneral.ckant_otras_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckant_otras_si.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtuconsulta_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtaconsulta_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtant_temp_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtant_pulsapm_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtant_pulsaart_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtant_fresp_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtant_familiares_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtant_observa_hcg.Enabled = False

                'TEJIDOS BLANDOS
                '1
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lsuperior_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lsuperior_si.Enabled = False
                '2
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_linferior_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_linferior_si.Enabled = False
                '3
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_comisuras_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_comisuras_si.Enabled = False
                '4
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_mucosa_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_mucosa_si.Enabled = False
                '5
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_surcos_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_surcos_si.Enabled = False
                '6
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_frenillos_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_frenillos_si.Enabled = False
                '7
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros1_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros1_si.Enabled = False
                '8
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_paladar_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_paladar_si.Enabled = False
                '9
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_orofar_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_orofar_si.Enabled = False
                '10
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lengua_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lengua_si.Enabled = False
                '11
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_pisoboca_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_pisoboca_si.Enabled = False
                '12
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_rebordes_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_rebordes_si.Enabled = False
                '13
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_gsalivares_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_gsalivares_si.Enabled = False
                '14
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros2_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros2_si.Enabled = False

                'ATM OCLUSION
                '15
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolormusc_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolormusc_si.Enabled = False
                '16
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolorarti_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolorarti_si.Enabled = False
                '17
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_ruidoarti_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_ruidoarti_si.Enabled = False
                '18
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_alterac_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_alterac_si.Enabled = False
                '19
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_maloclu_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_maloclu_si.Enabled = False

                '20
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_cresim_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_cresim_si.Enabled = False
                '21
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_otros_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_otros_si.Enabled = False

                'TEJIDOS DENTALES
                '22
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cforma_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cforma_si.Enabled = False
                '23
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ctam_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ctam_si.Enabled = False
                '24
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cnum_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cnum_si.Enabled = False
                '25
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ccolor_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ccolor_si.Enabled = False
                '26
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cpos_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cpos_si.Enabled = False
                '27
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_impac_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_impac_si.Enabled = False
                '28
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_otros_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_otros_si.Enabled = False

                'EXAMEN PERIODONTAL
                '29
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_sangrado_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_sangrado_si.Enabled = False
                '30
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_movilidad_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_movilidad_si.Enabled = False
                '31
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_reces_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_reces_si.Enabled = False
                '32
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_bolsa_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_bolsa_si.Enabled = False
                '33
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_calculos_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_calculos_si.Enabled = False
                '34
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_absceso_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_absceso_si.Enabled = False
                '35
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_otros_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_otros_si.Enabled = False

                'EXAMEN PULPAR
                '36
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_avital_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_avital_si.Enabled = False
                '37
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dolor_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dolor_si.Enabled = False
                '38
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_mdelta_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_mdelta_si.Enabled = False
                '39
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_sensi_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_sensi_si.Enabled = False
                '40
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_fistula_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_fistula_si.Enabled = False
                '41
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dtrata_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dtrata_si.Enabled = False
                '42
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_otros_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_otros_si.Enabled = False

                'HABITOS
                '43
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_resoral_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_resoral_si.Enabled = False
                '44
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_succdig_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_succdig_si.Enabled = False
                '45
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_lenguap_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_lenguap_si.Enabled = False
                '46
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_queilos_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_queilos_si.Enabled = False
                '47
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_fumador_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_fumador_si.Enabled = False
                '48
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_onico_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_onico_si.Enabled = False
                '49
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_otros_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_otros_si.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtef_observa_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtef_hallazgos_hcg.Enabled = False


                'HISTORIA CLINICA DE ACCION PREVENTIVA

                '1
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_charlas_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_charlas_si.Enabled = False
                '2
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_cepillado_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_cepillado_si.Enabled = False
                '3
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_seda_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_seda_si.Enabled = False
                '4
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_enguague_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_enguague_si.Enabled = False
                '5
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_fluor_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_fluor_si.Enabled = False
                '6
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_sellantes_no.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_sellantes_si.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_charlas_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_cepillado_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_seda_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_enguague_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_fluor_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_sellantes_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txthc_observa_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtexa_comp_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_psano_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanotipo_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanocod_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandos_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandostipo_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandoscod_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_atm_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmtipo_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmcod_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdental_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentaltipo_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentalcod_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperio_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiotipo_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiocod_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpar_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpartipo_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulparcod_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_otros_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_otrostipo_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_otroscod_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_observa_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_remision_hcg.Enabled = False

                My.Forms.frmHistoriaClinicaGeneral.txttrata_promocion_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_prevencion_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_radiog_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_operatoria_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_endodoncia_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_perio_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_prosto_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_oclusion_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txttrata_cirugia_hcg.Enabled = False
                My.Forms.frmHistoriaClinicaGeneral.txtpronostico_hcg.Enabled = False

            Case "desbloquearhclinicageneral"

                'ANTECEDENTES
                '1
                My.Forms.frmHistoriaClinicaGeneral.ckant_tratam_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_tratam_si.Enabled = True
                '2
                My.Forms.frmHistoriaClinicaGeneral.ckant_medicam_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_medicam_si.Enabled = True
                '3
                My.Forms.frmHistoriaClinicaGeneral.ckant_alergias_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_alergias_si.Enabled = True
                '4
                My.Forms.frmHistoriaClinicaGeneral.ckant_cardiopatias_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_cardiopatias_si.Enabled = True
                '5
                My.Forms.frmHistoriaClinicaGeneral.ckant_parterial_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_parterial_si.Enabled = True
                '6
                My.Forms.frmHistoriaClinicaGeneral.ckant_embarazo_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_embarazo_si.Enabled = True
                '7
                My.Forms.frmHistoriaClinicaGeneral.ckant_diabetes_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_diabetes_si.Enabled = True
                '8
                My.Forms.frmHistoriaClinicaGeneral.ckant_hepatitis_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_hepatitis_si.Enabled = True
                '9
                My.Forms.frmHistoriaClinicaGeneral.ckant_irradia_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_irradia_si.Enabled = True
                '10
                My.Forms.frmHistoriaClinicaGeneral.ckant_discrasia_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_discrasia_si.Enabled = True
                '11
                My.Forms.frmHistoriaClinicaGeneral.ckant_fiebre_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_fiebre_si.Enabled = True
                '12
                My.Forms.frmHistoriaClinicaGeneral.ckant_enfrenal_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_enfrenal_si.Enabled = True
                '13
                My.Forms.frmHistoriaClinicaGeneral.ckant_inmunos_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_inmunos_si.Enabled = True
                '14
                My.Forms.frmHistoriaClinicaGeneral.ckant_temosionales_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_temosionales_si.Enabled = True
                '15
                My.Forms.frmHistoriaClinicaGeneral.ckant_prespi_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_prespi_si.Enabled = True
                '16
                My.Forms.frmHistoriaClinicaGeneral.ckant_tgastricos_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_tgastricos_si.Enabled = True
                '17
                My.Forms.frmHistoriaClinicaGeneral.ckant_epilepsia_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_epilepsia_si.Enabled = True
                '18
                My.Forms.frmHistoriaClinicaGeneral.ckant_cirugias_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_cirugias_si.Enabled = True
                '19
                My.Forms.frmHistoriaClinicaGeneral.ckant_eorales_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_eorales_si.Enabled = True
                '20
                My.Forms.frmHistoriaClinicaGeneral.ckant_otras_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckant_otras_si.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtuconsulta_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtaconsulta_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtant_temp_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtant_pulsapm_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtant_pulsaart_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtant_fresp_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtant_familiares_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtant_observa_hcg.Enabled = True

                'TEJIDOS BLANDOS
                '1
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lsuperior_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lsuperior_si.Enabled = True
                '2
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_linferior_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_linferior_si.Enabled = True
                '3
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_comisuras_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_comisuras_si.Enabled = True
                '4
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_mucosa_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_mucosa_si.Enabled = True
                '5
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_surcos_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_surcos_si.Enabled = True
                '6
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_frenillos_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_frenillos_si.Enabled = True
                '7
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros1_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros1_si.Enabled = True
                '8
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_paladar_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_paladar_si.Enabled = True
                '9
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_orofar_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_orofar_si.Enabled = True
                '10
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lengua_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lengua_si.Enabled = True
                '11
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_pisoboca_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_pisoboca_si.Enabled = True
                '12
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_rebordes_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_rebordes_si.Enabled = True
                '13
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_gsalivares_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_gsalivares_si.Enabled = True
                '14
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros2_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros2_si.Enabled = True

                'ATM OCLUSION
                '15
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolormusc_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolormusc_si.Enabled = True
                '16
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolorarti_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolorarti_si.Enabled = True
                '17
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_ruidoarti_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_ruidoarti_si.Enabled = True
                '18
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_alterac_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_alterac_si.Enabled = True
                '19
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_maloclu_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_maloclu_si.Enabled = True

                '20
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_cresim_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_cresim_si.Enabled = True
                '21
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_otros_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_atm_otros_si.Enabled = True

                'TEJIDOS DENTALES
                '22
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cforma_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cforma_si.Enabled = True
                '23
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ctam_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ctam_si.Enabled = True
                '24
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cnum_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cnum_si.Enabled = True
                '25
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ccolor_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_ccolor_si.Enabled = True
                '26
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cpos_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_cpos_si.Enabled = True
                '27
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_impac_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_impac_si.Enabled = True
                '28
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_otros_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_td_otros_si.Enabled = True

                'EXAMEN PERIODONTAL
                '29
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_sangrado_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_sangrado_si.Enabled = True
                '30
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_movilidad_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_movilidad_si.Enabled = True
                '31
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_reces_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_reces_si.Enabled = True
                '32
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_bolsa_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_bolsa_si.Enabled = True
                '33
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_calculos_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_calculos_si.Enabled = True
                '34
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_absceso_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_absceso_si.Enabled = True
                '35
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_otros_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ep_otros_si.Enabled = True

                'EXAMEN PULPAR
                '36
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_avital_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_avital_si.Enabled = True
                '37
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dolor_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dolor_si.Enabled = True
                '38
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_mdelta_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_mdelta_si.Enabled = True
                '39
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_sensi_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_sensi_si.Enabled = True
                '40
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_fistula_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_fistula_si.Enabled = True
                '41
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dtrata_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dtrata_si.Enabled = True
                '42
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_otros_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_epu_otros_si.Enabled = True

                'HABITOS
                '43
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_resoral_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_resoral_si.Enabled = True
                '44
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_succdig_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_succdig_si.Enabled = True
                '45
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_lenguap_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_lenguap_si.Enabled = True
                '46
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_queilos_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_queilos_si.Enabled = True
                '47
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_fumador_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_fumador_si.Enabled = True
                '48
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_onico_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_onico_si.Enabled = True
                '49
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_otros_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ho_otros_si.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtef_observa_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtef_hallazgos_hcg.Enabled = True


                'HISTORIA CLINICA DE ACCION PREVENTIVA

                '1
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_charlas_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_charlas_si.Enabled = True
                '2
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_cepillado_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_cepillado_si.Enabled = True
                '3
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_seda_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_seda_si.Enabled = True
                '4
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_enguague_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_enguague_si.Enabled = True
                '5
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_fluor_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_fluor_si.Enabled = True
                '6
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_sellantes_no.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.ckef_ap_sellantes_si.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_charlas_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_cepillado_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_seda_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_enguague_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_fluor_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txthc_frec_sellantes_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txthc_observa_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtexa_comp_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_psano_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanotipo_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanocod_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandos_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandostipo_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandoscod_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_atm_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmtipo_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmcod_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdental_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentaltipo_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentalcod_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperio_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiotipo_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiocod_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpar_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpartipo_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulparcod_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_otros_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_otrostipo_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_otroscod_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txtdiag_observa_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtdiag_remision_hcg.Enabled = True

                My.Forms.frmHistoriaClinicaGeneral.txttrata_promocion_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_prevencion_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_radiog_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_operatoria_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_endodoncia_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_perio_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_prosto_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_oclusion_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txttrata_cirugia_hcg.Enabled = True
                My.Forms.frmHistoriaClinicaGeneral.txtpronostico_hcg.Enabled = True


            Case "bloquearhclinicaortodoncia"

                'Bloquear Historia Clinica

                My.Forms.frmHistoriaClinicaOrtodoncia.txtmconsulta_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdescripcion_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtclase_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtduracion_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtenfe_infancia_h.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.chkdiabetes.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkhepatitis.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chksinusitis.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkcardiovas.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkfiebre.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkrespira.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkhipertension.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txtinmuniza_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txthospitaliza_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txttraumaticoas_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtquirurgicos_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txttransfusi_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtirradia_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txthemorrag_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmedica_act_h.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.chkanestesia.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkpenicilina.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txtotras_drogas_h.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.chkbruxismo.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkdeglusion.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkresbucal.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkinffon.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkfuma.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkempling.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chksuccdigital.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chkmorder.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_gener_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_bucales_h.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_piel.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cabeza.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cara.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_oidos.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_ojos.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_nariz.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_senos.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cuello.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txttensionart_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpulso_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfr_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpiel_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtamigdalas_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtnot_linf_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpisoboca_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios__hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpaladar_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcarrillos__hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtglsalivares__hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmucosa_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenillos_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtotros_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtalarmas_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtnotas_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txttipofacial_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtimpCabello_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriav_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriah_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcejas_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtesclera_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtintercantal_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtalasnariz_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsimcomisur_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtselladolabial_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtinscis_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmm_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtgrosorlabial_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisasimetria_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisaencia_hef.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisadientesinf_hef.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txttipoperfil_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtanguloconj_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrente_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcolumnea_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolabial_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsurcomentolabial_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmenton_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtangulomentogarg__hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsecerupcion_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtparalelismored_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtproporcoronaraiz_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes__hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesrete_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientessuper_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionperio_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionendod_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtanatomiacond_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtestadoligamiento_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpisosenomax_hp2.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtagujeromento_hp2.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.chklineasupercentr.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeder.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeizq.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm1_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm2_hp3.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfecentr.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfededer.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfedeizq.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm1_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm2_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverbite_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverjet_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentedientesausen_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtldereoverject_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderoverbite_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelcanina_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelmolar_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderdientesausen_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverject_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverbite_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelcanina_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelmolar_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqudientesausen_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupforma_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupsime_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupausen_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfforma_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfsime_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfausen_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdesviacion_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdeflexion_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticruidosart_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticsintomat_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialtperfil_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangconje_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfaciallabios_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangnasolab_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquclase_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquesqu_hp3.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdesqudimensvert_hp3.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txtmalomolar_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmalocanina_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txttdenticion_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlmedias_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtoverjet_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtoverbite_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txttipoapi_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmejorarperfil_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfil_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolab_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtctrlperfesq_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfesq_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrfrente_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlograroverjet_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrmolarcan_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrbuenaocl_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtplan1_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtplan2_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtplan3_hp4.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.rbTrataNo.Enabled = False

                My.Forms.frmHistoriaClinicaOrtodoncia.txtreqtratam_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcuantas_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.texttratamientodef_hp4.Enabled = False
                My.Forms.frmHistoriaClinicaOrtodoncia.textlimitacaso_hp4.Enabled = False

            Case "desbloquearhclinica"

                ' Desbloquear Historia Clinica

                My.Forms.frmHistoriaClinicaOrtodoncia.txtmconsulta_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdescripcion_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtclase_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtduracion_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtenfe_infancia_h.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.chkdiabetes.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkhepatitis.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chksinusitis.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkcardiovas.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkfiebre.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkrespira.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkhipertension.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txtinmuniza_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txthospitaliza_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txttraumaticoas_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtquirurgicos_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txttransfusi_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtirradia_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txthemorrag_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmedica_act_h.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.chkanestesia.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkpenicilina.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txtotras_drogas_h.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.chkbruxismo.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkdeglusion.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkresbucal.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkinffon.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkfuma.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkempling.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chksuccdigital.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chkmorder.Checked = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_gener_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_bucales_h.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_piel.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cabeza.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cara.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_oidos.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_ojos.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_nariz.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_senos.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cuello.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txttensionart_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpulso_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfr_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpiel_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtamigdalas_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtnot_linf_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpisoboca_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios__hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpaladar_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcarrillos__hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtglsalivares__hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmucosa_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenillos_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtotros_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtalarmas_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtnotas_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txttipofacial_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtimpCabello_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriav_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriah_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcejas_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtesclera_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtintercantal_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtalasnariz_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsimcomisur_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtselladolabial_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtinscis_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmm_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtgrosorlabial_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisasimetria_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisaencia_hef.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisadientesinf_hef.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txttipoperfil_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtanguloconj_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrente_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcolumnea_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolabial_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsurcomentolabial_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmenton_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtangulomentogarg__hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtsecerupcion_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtparalelismored_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtproporcoronaraiz_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes__hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesrete_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientessuper_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionperio_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionendod_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtanatomiacond_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtestadoligamiento_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtpisosenomax_hp2.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtagujeromento_hp2.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.chklineasupercentr.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeder.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeizq.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm1_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm2_hp3.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfecentr.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfededer.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfedeizq.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm1_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm2_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverbite_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverjet_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentedientesausen_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtldereoverject_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderoverbite_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelcanina_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelmolar_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlderdientesausen_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverject_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverbite_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelcanina_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelmolar_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqudientesausen_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupforma_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupsime_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupausen_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfforma_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfsime_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfausen_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdesviacion_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdeflexion_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticruidosart_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticsintomat_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialtperfil_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangconje_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfaciallabios_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangnasolab_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquclase_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquesqu_hp3.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdesqudimensvert_hp3.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txtmalomolar_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmalocanina_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txttdenticion_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlmedias_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtoverjet_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtoverbite_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txttipoapi_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtmejorarperfil_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfil_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolab_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtctrlperfesq_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfesq_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrfrente_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlograroverjet_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrmolarcan_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrbuenaocl_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtplan1_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtplan2_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtplan3_hp4.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.rbTrataNo.Enabled = True

                My.Forms.frmHistoriaClinicaOrtodoncia.txtreqtratam_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.txtcuantas_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.texttratamientodef_hp4.Enabled = True
                My.Forms.frmHistoriaClinicaOrtodoncia.textlimitacaso_hp4.Enabled = True


        End Select

    End Sub

    Public Sub calendariomes(ByVal fecha As String, ByVal doctor As Integer, ByVal opcion As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        Select Case opcion

            Case "calorthosoft" ' Calendario Normal

                Try

                    CAL = New CLASE_CALENDARIO
                    CAL.p_fecha = fecha
                    CAL.p_Iddoctor = doctor
                    CAL.Seleccionar("mes")

                    Dim i As Integer

                    For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                        My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateText2(Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), CLASE_GENERAL.xdt.Rows(i).Item("Idcalendario"))

                        If CLASE_GENERAL.xdt.Rows(i).Item("Idcontroldia") = 1 Then
                            My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateColor(Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), &HFFFF&) 'Set the background color From gradient color 
                        ElseIf CLASE_GENERAL.xdt.Rows(i).Item("Idcontroldia") = 2 Then
                            My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateColor(Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), &HFF&) 'Set the background color From gradient color 
                        ElseIf CLASE_GENERAL.xdt.Rows(i).Item("Idcontroldia") = 3 Then
                            My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateColor(Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), &HFF8080&) 'Set the background color From gradient color 
                        End If

                    Next

                    CAL.dispose()
                    CLASE_GENERAL.xdt.Clear()
                    CLASE_GENERAL.xdt = Nothing


                Catch ex As InvalidCastException

                    MsgBox("CONSULTA VACIA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try


        End Select


    End Sub

    Public Sub calendariodia(ByVal fecha As String, ByVal doctor As Integer, ByVal opcion As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        Select Case opcion

            Case "calorthosoft" 'Calendario Normal
                Try

                    CAL = New CLASE_CALENDARIO
                    CAL.p_fecha = fecha
                    CAL.p_Iddoctor = doctor
                    CAL.Seleccionar("dia")

                    'CAL.dispose()

                    My.Forms.mdiOrthoSoft.StartTime.Value = New Date(2000, 1, 1, Hour(CLASE_CALENDARIO.xhoraini), Minute(CLASE_CALENDARIO.xhoraini), Second(CLASE_CALENDARIO.xhoraini), 0)
                    My.Forms.mdiOrthoSoft.EndTime.Value = New Date(2000, 1, 1, Hour(CLASE_CALENDARIO.xhorafin), Minute(CLASE_CALENDARIO.xhorafin), Second(CLASE_CALENDARIO.xhorafin), 0)
                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime = CLASE_CALENDARIO.xhoraini2
                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkEndTime = CLASE_CALENDARIO.xhorafin2

                    If CLASE_CALENDARIO.xIdcontroldia = 1 Then
                        My.Forms.mdiOrthoSoft.rbtFestivo.Checked = True
                    ElseIf CLASE_CALENDARIO.xIdcontroldia = 2 Then
                        My.Forms.mdiOrthoSoft.rbtNolaborable.Checked = True
                    ElseIf CLASE_CALENDARIO.xIdcontroldia = 3 Then
                        My.Forms.mdiOrthoSoft.rbtModificado.Checked = True
                    End If

                    If CLASE_GENERAL.sheduler = 0 Then

                        If CLASE_CALENDARIO.xrangocal = "5" Then
                            My.Forms.mdiOrthoSoft.rbt5min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig5min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "10" Then
                            My.Forms.mdiOrthoSoft.rbt10min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig10min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "15" Then
                            My.Forms.mdiOrthoSoft.rbt15min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig15min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "30" Then
                            My.Forms.mdiOrthoSoft.rbt30min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig30min.Checked = True
                        End If

                    Else

                        If CLASE_CALENDARIO.xrangocal = "5" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 0
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig5min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "10" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 1
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig10min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "15" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 2
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig15min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "30" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 3
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig30min.Checked = True
                        End If

                    End If

                    My.Forms.mdiOrthoSoft.txtTopeCita.Text = CLASE_CALENDARIO.xtopecita

                    CAL.dispose()

                Catch ex As InvalidCastException

                    MsgBox("CONSULTA VACIA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try

            Case "calorthosoft2" ' Calendario Bloqueado
                Try

                    CAL = New CLASE_CALENDARIO
                    CAL.p_fecha = fecha
                    CAL.p_Iddoctor = doctor
                    CAL.Seleccionar("dia")

                    'CAL.dispose()

                    My.Forms.mdiOrthoSoft.StartTime.Value = New Date(2000, 1, 1, Hour(CLASE_CALENDARIO.xhoraini), Minute(CLASE_CALENDARIO.xhoraini), Second(CLASE_CALENDARIO.xhoraini), 0)
                    My.Forms.mdiOrthoSoft.EndTime.Value = New Date(2000, 1, 1, Hour(CLASE_CALENDARIO.xhorafin), Minute(CLASE_CALENDARIO.xhorafin), Second(CLASE_CALENDARIO.xhorafin), 0)

                    If CLASE_CALENDARIO.xIdcontroldia = 1 Then
                        My.Forms.mdiOrthoSoft.rbtFestivo.Checked = True
                    ElseIf CLASE_CALENDARIO.xIdcontroldia = 2 Then
                        My.Forms.mdiOrthoSoft.rbtNolaborable.Checked = True
                    ElseIf CLASE_CALENDARIO.xIdcontroldia = 3 Then
                        My.Forms.mdiOrthoSoft.rbtModificado.Checked = True
                    End If

                    If CLASE_GENERAL.sheduler = 0 Then

                        If CLASE_CALENDARIO.xrangocal = "5" Then
                            My.Forms.mdiOrthoSoft.rbt5min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig5min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "10" Then
                            My.Forms.mdiOrthoSoft.rbt10min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig10min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "15" Then
                            My.Forms.mdiOrthoSoft.rbt15min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig15min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "30" Then
                            My.Forms.mdiOrthoSoft.rbt30min.Checked = True
                            My.Forms.mdiOrthoSoft.rbtConfig30min.Checked = True
                        End If

                    Else

                        If CLASE_CALENDARIO.xrangocal = "5" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 0
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig5min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "10" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 1
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig10min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "15" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 2
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig15min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "30" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 3
                            My.Forms.frmAppointment.cmbRangoAgenda.Update()
                            My.Forms.mdiOrthoSoft.rbtConfig30min.Checked = True
                        End If

                    End If

                    'My.Forms.mdiOrthoSoft.txtTopeCita.Text = Clase_calendario.xtopecita

                    CAL.dispose()


                Catch ex As InvalidCastException

                    MsgBox("CONSULTA VACIA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try

            Case "calorthosoft3"

                Try

                    CAL = New CLASE_CALENDARIO
                    CAL.p_fecha = fecha
                    CAL.p_Iddoctor = doctor
                    CAL.Seleccionar("dia")

                    'CAL.dispose()

                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime = CLASE_CALENDARIO.xhoraini2
                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkEndTime = CLASE_CALENDARIO.xhorafin2

                    If CLASE_GENERAL.sheduler = 0 Then

                        If CLASE_CALENDARIO.xrangocal = "5" Then
                            My.Forms.mdiOrthoSoft.rbt5min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "10" Then
                            My.Forms.mdiOrthoSoft.rbt10min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "15" Then
                            My.Forms.mdiOrthoSoft.rbt15min.Checked = True
                        ElseIf CLASE_CALENDARIO.xrangocal = "30" Then
                            My.Forms.mdiOrthoSoft.rbt30min.Checked = True
                        End If

                    Else

                        If CLASE_CALENDARIO.xrangocal = "5" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 0
                        ElseIf CLASE_CALENDARIO.xrangocal = "10" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 1
                        ElseIf CLASE_CALENDARIO.xrangocal = "15" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 2
                        ElseIf CLASE_CALENDARIO.xrangocal = "30" Then
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 3
                        End If

                    End If


                    My.Forms.mdiOrthoSoft.txtTopeCita.Text = CLASE_CALENDARIO.xtopecita

                    CAL.dispose()


                Catch ex As InvalidCastException

                    MsgBox("CONSULTA VACIA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try

        End Select


    End Sub

    Public Sub cargarcitasdia(ByVal fecha As String, ByVal doctor As Integer) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar


        Try

            Dim StartDate As DateTime
            Dim EndDate As DateTime
            Dim App1 As ScheduleAppointment

            CITA = New CLASE_CITAS
            CITA.p_fecha = fecha
            CITA.p_Iddoctor = doctor
            CITA.Seleccionar("dia")

            Dim i As Integer

            For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                StartDate = New Date(Year(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Month(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Hour(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horaini"))), Minute(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horaini"))), 0, 0)
                EndDate = New Date(Year(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Month(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Hour(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horafin"))), Minute(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horafin"))), 0, 0)
                App1 = New ScheduleAppointment(StartDate, EndDate, CLASE_GENERAL.xdt.Rows(i).Item("Idpaciente") & ", " & CLASE_GENERAL.xdt.Rows(i).Item("Nombres"))
                App1.Tag = CLASE_GENERAL.xdt.Rows(i).Item("Idcita")


                ' Cargamos las citas de acuerdo a los colores

                CONSULTA = New CLASE_CONSULTA
                CONSULTA.p_Idtconsulta = CLASE_GENERAL.xdt.Rows(i).Item("Idtconsulta")
                CONSULTA.Seleccionar("tipoconsulta1")

                App1.FormatStyle.BackColor = Drawing.Color.FromArgb(CLASE_CONSULTA.xcolor)
                App1.FormatStyle.BackColorGradient = Drawing.Color.White
                App1.FormatStyle.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
                App1.BorderColor = Drawing.Color.FromArgb(CLASE_CONSULTA.xcolor)

                CONSULTA.dispose()
                CONSULTA = Nothing

                If CLASE_GENERAL.xdt.Rows(i).Item("cancelacion") = 1 Then

                    App1.ImageIndex2 = 2

                Else

                    App1.ImageIndex2 = 3

                End If

                If CLASE_GENERAL.xdt.Rows(i).Item("asistencia") = 1 Then

                    App1.ImageIndex3 = 4

                Else

                    App1.ImageIndex3 = 5

                End If


                My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Appointments.Add(App1)

            Next


            CITA.dispose()
            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing


        Catch ex As InvalidCastException

            MsgBox("CONSULTA VACIA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Sub cargarcitasdiaMulti(ByVal fecha As String, ByVal doctor As Integer) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar


        Try

            Dim StartDate As DateTime
            Dim EndDate As DateTime
            Dim App1 As ScheduleAppointment

            CITA = New CLASE_CITAS
            CITA.p_fecha = fecha
            CITA.p_Iddoctor = doctor
            CITA.Seleccionar("dia")

            Dim i As Integer

            For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                StartDate = New Date(Year(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Month(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Hour(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horaini"))), Minute(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horaini"))), 0, 0)
                EndDate = New Date(Year(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Month(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Day(CLASE_GENERAL.xdt.Rows(i).Item("fecha")), Hour(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horafin"))), Minute(Convert.ToString(CLASE_GENERAL.xdt.Rows(i).Item("horafin"))), 0, 0)
                App1 = New ScheduleAppointment(StartDate, EndDate, CLASE_GENERAL.xdt.Rows(i).Item("Idpaciente") & ", " & CLASE_GENERAL.xdt.Rows(i).Item("Nombres"))
                App1.Tag = CLASE_GENERAL.xdt.Rows(i).Item("Idcita")


                ' Cargamos las citas de acuerdo a los colores

                CONSULTA = New CLASE_CONSULTA
                CONSULTA.p_Idtconsulta = CLASE_GENERAL.xdt.Rows(i).Item("Idtconsulta")
                CONSULTA.Seleccionar("tipoconsulta1")

                App1.FormatStyle.BackColor = Drawing.Color.FromArgb(CLASE_CONSULTA.xcolor)
                App1.FormatStyle.BackColorGradient = Drawing.Color.White
                App1.FormatStyle.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
                App1.BorderColor = Drawing.Color.FromArgb(CLASE_CONSULTA.xcolor)

                CONSULTA.dispose()
                CONSULTA = Nothing

                If CLASE_GENERAL.xdt.Rows(i).Item("cancelacion") = 1 Then

                    App1.ImageIndex2 = 2

                Else

                    App1.ImageIndex2 = 3

                End If

                If CLASE_GENERAL.xdt.Rows(i).Item("asistencia") = 1 Then

                    App1.ImageIndex3 = 4

                Else

                    App1.ImageIndex3 = 5

                End If

                App1.Owner = CInt(CLASE_GENERAL.xdt.Rows(i).Item("Idunidad"))


                My.Forms.frmAppointment.ScheduleOrhosoftMulti.Appointments.Add(App1)
                My.Forms.frmAppointment.ScheduleOrhosoftMulti.Update()

            Next


            CITA.dispose()
            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing


        Catch ex As InvalidCastException

            MsgBox("CONSULTA VACIA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    ' --------------------------------------------------
    ' Function StripString()
    '
    ' Returns a string minus a set of specified chars.
    ' --------------------------------------------------

    Function StripString(ByVal MyStr As Object) As Object


        Dim strChar As String = "", strHoldString As String = ""
        Dim i As Integer

        ' Exit if the passed value is null.
        If (MyStr) Is DBNull.Value Then

            End

        Else

            ' Exit if the passed value is not a string.
            If VarType(MyStr) <> 8 Then

                End

            Else


                ' Check each value for invalid characters.
                For i = 1 To Len(MyStr)
                    strChar = Mid$(MyStr, i, 1)
                    Select Case strChar
                        'Case ".", "#", ",", "-"
                        Case ",", "ñ", "Ñ"
                            ' Do nothing
                        Case Else
                            strHoldString = strHoldString & strChar
                    End Select
                Next i

                ' Pass back corrected string.
                StripString = strHoldString

            End If

        End If

    End Function

    Public Shared Sub operaciones()

        Try

            If My.Forms.frmPresupuesto.txtVTotal_cuota.Text = "" Then
                VTOTAL = 0
            Else
                VTOTAL = CDbl(My.Forms.frmPresupuesto.txtVTotal_cuota.Text)
            End If

            If My.Forms.frmPresupuesto.txtNCuotasIni_cuota.Text = "" Then
                NCUOTASINI = 0
            Else
                NCUOTASINI = CDbl(My.Forms.frmPresupuesto.txtNCuotasIni_cuota.Text)
            End If

            If My.Forms.frmPresupuesto.txtVCuotasIni_cuota.Text = "" Then
                VCUOTASINI = 0
            Else
                VCUOTASINI = CDbl(My.Forms.frmPresupuesto.txtVCuotasIni_cuota.Text)
            End If

            If My.Forms.frmPresupuesto.txtTCuotasIni_cuota.Text = "" Then
                TCUOTASINI = 0
            Else
                TCUOTASINI = CDbl(My.Forms.frmPresupuesto.txtTCuotasIni_cuota.Text)
            End If

            If My.Forms.frmPresupuesto.txtNCuotas_cuota.Text = "" Then
                NCUOTAS = 0
            Else
                NCUOTAS = CDbl(My.Forms.frmPresupuesto.txtNCuotas_cuota.Text)
            End If

            If My.Forms.frmPresupuesto.txtVCuotas_cuota.Text = "" Then
                VCUOTAS = 0
            Else
                VCUOTAS = CDbl(My.Forms.frmPresupuesto.txtVCuotas_cuota.Text)
            End If

            If My.Forms.frmPresupuesto.txtTCuotas_cuota.Text = "" Then
                TCUOTAS = 0
            Else
                TCUOTAS = CDbl(My.Forms.frmPresupuesto.txtTCuotas_cuota.Text)
            End If

            If NCUOTAS = 0 Then

                VCUOTASINI = Round(VTOTAL / NCUOTASINI, 0, MidpointRounding.ToEven)
                TCUOTASINI = VCUOTASINI * NCUOTASINI

                My.Forms.frmPresupuesto.txtVCuotasIni_cuota.Text = VCUOTASINI
                My.Forms.frmPresupuesto.txtTCuotasIni_cuota.Text = TCUOTASINI
                My.Forms.frmPresupuesto.txtVCuotas_cuota.Text = 0
                My.Forms.frmPresupuesto.txtTCuotas_cuota.Text = 0

                My.Forms.frmPresupuesto.txtVCuotasIni_cuota.Properties.ReadOnly = True

            Else

                TCUOTASINI = NCUOTASINI * VCUOTASINI
                VCUOTAS = Round((VTOTAL - TCUOTASINI) / NCUOTAS, 0, MidpointRounding.ToEven)
                TCUOTAS = NCUOTAS * VCUOTAS

                My.Forms.frmPresupuesto.txtTCuotasIni_cuota.Text = TCUOTASINI
                My.Forms.frmPresupuesto.txtVCuotas_cuota.Text = VCUOTAS
                My.Forms.frmPresupuesto.txtTCuotas_cuota.Text = TCUOTAS

                My.Forms.frmPresupuesto.txtVCuotasIni_cuota.Properties.ReadOnly = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Shared Sub operaciones_rc()

        Try

            If My.Forms.frmRCaja.txtTotal_rc.Text = "" Then
                TOTAL_RC = 0
            Else
                TOTAL_RC = CDbl(My.Forms.frmRCaja.txtTotal_rc.Text)
            End If

            If My.Forms.frmRCaja.txtEfectivo_rc.Text = "" Then
                EFECTIVO_RC = 0
            Else
                EFECTIVO_RC = CDbl(My.Forms.frmRCaja.txtEfectivo_rc.Text)
            End If

            If My.Forms.frmRCaja.txtTarjeta_rc.Text = "" Then
                TARJETA_RC = 0
            Else
                TARJETA_RC = CDbl(My.Forms.frmRCaja.txtTarjeta_rc.Text)
            End If

            EFECTIVO_RC = TOTAL_RC - TARJETA_RC

            My.Forms.frmRCaja.txtEfectivo_rc.Text = EFECTIVO_RC

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Shared Sub operaciones_mdiario()

        Try

            'Verificamos Saldos Iniciales

            If My.Forms.frmMovimientoDiario.txtTCajaMenordebitos.Text = "" Then
                SaldoInicialCMenor = 0
            Else
                SaldoInicialCMenor = CDbl(My.Forms.frmMovimientoDiario.txtTCajaMenordebitos.Text)
            End If

            If My.Forms.frmMovimientoDiario.txtTPagoEfectivodebitos.Text = "" Then
                TPagoEfectivodebitos = 0
            Else
                TPagoEfectivodebitos = CDbl(My.Forms.frmMovimientoDiario.txtTPagoEfectivodebitos.Text)
            End If

            If My.Forms.frmMovimientoDiario.txtTPagoTarjetadebitos.Text = "" Then
                TPagoTarjetadebitos = 0
            Else
                TPagoTarjetadebitos = CDbl(My.Forms.frmMovimientoDiario.txtTPagoTarjetadebitos.Text)
            End If

            If My.Forms.frmMovimientoDiario.txtTotalCreditos.Text = "" Then
                TotalEgresosCreditos = 0
            Else
                TotalEgresosCreditos = CDbl(My.Forms.frmMovimientoDiario.txtTotalCreditos.Text)
            End If

            If My.Forms.frmMovimientoDiario.txtTotalDebitos.Text = "" Then
                TotalDebitos = 0
            Else
                TotalDebitos = CDbl(My.Forms.frmMovimientoDiario.txtTotalDebitos.Text)
            End If


            'Hacemos las operaiones
            TotalDebitos = TPagoEfectivodebitos + TPagoTarjetadebitos + SaldoInicialCMenor
            TotalMovimientoDiario = (TotalDebitos) - TotalEgresosCreditos

            'Cargamos los datos en los controles
            My.Forms.frmMovimientoDiario.txtTMovimientoDiario.Text = TotalMovimientoDiario


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Sub cargarpacienteficha(ByVal paciente As Integer)

        Try
            ' Cerramos todos las ventanas que intervenga informacion de un usuario
            For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren
                If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Or frm.Name = "frmRCaja" Or frm.Name = "frmPacientes" Or frm.Name = "frmEnvioEmailInd" Or frm.Name = "frmEnvioSMSInd" Or frm.Name = "frmFotografia" Or frm.Name = "frmHistoriaClinicaGeneral" Or frm.Name = "frmHistoriaClinicaOrtodoncia" Or frm.Name = "frmHistoriaClinicaOrtodoncia2" Or frm.Name = "frmHistoriaClinicaOrtodoncia3" Or frm.Name = "frmHuellas" Then
                    frm.Close()
                End If
            Next

            PAC = New CLASE_PACIENTES
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS
            CITA = New CLASE_CITAS
            GENE = New CLASE_GENERAL

            PAC.p_IdPaciente = paciente
            CON.p_IdUsuario = paciente
            NOTA.p_IdUsuario = paciente

            EVEN.limpiar("limpiarficha")
            EVEN.limpiar("limpiaractivopaciente")

            PAC.Seleccionar("pacientes")

            'Cargamos los Datos en la ficha del Paciente

            My.Forms.mdiOrthoSoft.txtId_ficha.Text = CLASE_PACIENTES.xIdpaciente
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = CLASE_PACIENTES.xnombres_pac & " " & CLASE_PACIENTES.xapellidos_pac
            My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = CLASE_PACIENTES.xreferidopor_pac
            My.Forms.mdiOrthoSoft.txtnhistoria_ficha.Text = CLASE_PACIENTES.xnhclinica

            My.Forms.mdiOrthoSoft.lblActivoPaciente.Text = CLASE_PACIENTES.xnombres_pac & " " & CLASE_PACIENTES.xapellidos_pac
            My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag = CLASE_PACIENTES.xIdpaciente

            'Cargamos Id Especial para Huellas
            CLASE_GENERAL._Idpaciente_consec = CLASE_PACIENTES.xIdpaciente

            Select Case CLASE_PACIENTES.xIdestado_pac

                Case 1
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LightSkyBlue
                Case 2
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Salmon
                Case 3
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LimeGreen
                Case 4
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Khaki

            End Select


            PAC.dispose()
            PAC = Nothing


            '******************************** CARGAMOS LOS CONTACTOS DEL PACIENTE ***********************************

            'Verificamos que exista este contacto tipo 5

            contar = 0
            contar = CLASE_GENERAL.contarcontactostodos(CON.p_IdUsuario, 1, CLASE_GENERAL.mensaje_error)

            If contar > 1 Then


                CON.p_IdTUsuario = 1 ' Lo Utilizamos porque es un paciente
                CON.Seleccionar("xdt")

                Dim j As Integer

                For j = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    If CLASE_GENERAL.xdt.Rows(j).Item("IdTTutor") = 5 Then

                        If CLASE_GENERAL.xdt.Rows(j).Item("cel_con") Is DBNull.Value Then
                            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = ""
                        Else
                            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = CLASE_GENERAL.xdt.Rows(j).Item("cel_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(j).Item("telcasa_con") Is DBNull.Value Then
                            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = ""
                        Else
                            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = CLASE_GENERAL.xdt.Rows(j).Item("telcasa_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(j).Item("email_con") Is DBNull.Value Then
                            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = ""
                        Else
                            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = CLASE_GENERAL.xdt.Rows(j).Item("email_con")
                        End If

                    End If

                Next

                CLASE_GENERAL.xdt.Clear()
                CLASE_GENERAL.xdt = Nothing

            End If

            CON.dispose()
            CON = Nothing


            '************************************* CARGAMOS FOTO DEL PACIENTE **************************

            'Verificamos que exista las notas y las fotos
            contar = 0
            contar = CLASE_GENERAL.contarnotas(NOTA.p_IdUsuario, 1, CLASE_GENERAL.mensaje_error)

            If contar = 1 Then


                NOTA.p_IdTUsuario = 1 ' Lo Utilizamos porque es un paciente
                NOTA.Seleccionar("notas")

                If Not (CLASE_NOTAS.xfotolong.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_NOTAS.xfotolong)
                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = iImagen

                Else

                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Resources.fondopaciente

                End If

                My.Forms.mdiOrthoSoft.btnEditarFicha.Enabled = True

                NOTA.dispose()
                NOTA = Nothing
                GENE = Nothing

            Else

                NOTA.dispose()
                NOTA = Nothing
                GENE = Nothing

            End If

            '*********************************** CARGAMOS LA PROXIMA CITA DEL PACIENTE *******************

            CITA = New CLASE_CITAS

            fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

            CITA.p_fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
            CITA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

            CITA.Seleccionar("proximacita")

            If CLASE_GENERAL.xdt.Rows.Count <> 0 Then

                If CLASE_GENERAL.xdt.Rows(0).Item("FECHA") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtProxCita_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtProxCita_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("FECHA")
                End If

                If CLASE_GENERAL.xdt.Rows(0).Item("HORAINI") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtHINI_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtHINI_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("HORAINI")
                End If

                If CLASE_GENERAL.xdt.Rows(0).Item("HORAFIN") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtHFIN_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtHFIN_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("HORAFIN")
                End If

                If CLASE_GENERAL.xdt.Rows(0).Item("CONSULTA") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtproced_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtproced_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("CONSULTA")
                End If

            End If

            CITA.dispose()
            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing


            EVEN = Nothing

            My.Forms.mdiOrthoSoft.btnEnvioEmail.Enabled = True
            My.Forms.mdiOrthoSoft.btnEditarFicha.Enabled = True


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Public Sub cargarpacientedatos(ByVal paciente As Integer)

        Try

            'Abrimos la Ventana Primero

            frmPacientes.MdiParent = mdiOrthoSoft
            'Display the new form.
            frmPacientes.Show()
            frmPacientes.Activate()

            '*************************************** CARGAMOS LOS DATOS DEL PACIENTE *******************************

            ' Cerramos todos las ventanas que intervenga informacion de un usuario
            For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren
                If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Or frm.Name = "frmRCaja" Or frm.Name = "frmEnvioEmailInd" Or frm.Name = "frmEnvioSMSInd" Or frm.Name = "frmFotografia" Or frm.Name = "frmHistoriaClinicaGeneral" Or frm.Name = "frmHistoriaClinicaOrtodoncia" Or frm.Name = "frmHistoriaClinicaOrtodoncia2" Or frm.Name = "frmHistoriaClinicaOrtodoncia3" Or frm.Name = "frmHuellas" Then
                    frm.Close()
                End If
            Next

            PAC = New CLASE_PACIENTES
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS
            GENE = New CLASE_GENERAL

            PAC.p_IdPaciente = paciente
            CON.p_IdUsuario = paciente
            NOTA.p_IdUsuario = paciente

            Idpaciente = paciente

            EVEN.limpiar("limpiarpacientes")
            EVEN.limpiar("limpiarficha")
            EVEN.limpiar("limpiaractivopaciente")

            PAC.Seleccionar("pacientes")

            My.Forms.frmPacientes.txtIdpaciente.Text = CLASE_PACIENTES.xIdpaciente
            My.Forms.frmPacientes.txtapellidos_pac.Text = CLASE_PACIENTES.xapellidos_pac
            My.Forms.frmPacientes.txtnombres_pac.Text = CLASE_PACIENTES.xnombres_pac
            My.Forms.frmPacientes.txtresidencia_pac.Text = CLASE_PACIENTES.xresidencia_pac
            My.Forms.frmPacientes.cmbestadocivil_pac.SelectedIndex = CLASE_PACIENTES.xestadocivil_pac
            My.Forms.frmPacientes.txtoficina_pac.Text = CLASE_PACIENTES.xoficina_pac
            My.Forms.frmPacientes.cmbfecingreso_pac.Value = CLASE_PACIENTES.xfecingreso_pac
            My.Forms.frmPacientes.txtocupacion_pac.Text = CLASE_PACIENTES.xocupacion_pac
            My.Forms.frmPacientes.txtreferido_pac.Text = CLASE_PACIENTES.xreferidopor_pac
            My.Forms.frmPacientes.cmbfecnac_pac.Value = CLASE_PACIENTES.xfecnac_pac
            My.Forms.frmPacientes.txtlugarnac_pac.Text = CLASE_PACIENTES.xlugarnac_pac

            My.Forms.frmPacientes.cmbzona_pac.SelectedIndex = CLASE_PACIENTES.xzona_pac
            My.Forms.frmPacientes.txtmunicipio_pac.Text = CLASE_PACIENTES.xmunicipio_pac
            My.Forms.frmPacientes.txtdep_pac.Text = CLASE_PACIENTES.xdep_pac
            My.Forms.frmPacientes.txtrh_Pac.Text = CLASE_PACIENTES.xrh_pac

            Select Case CLASE_PACIENTES.xtipodoc_pac

                Case 1
                    My.Forms.frmPacientes.cmbtipodoc_pac.Text = "T.I"
                Case 2
                    My.Forms.frmPacientes.cmbtipodoc_pac.Text = "CEDULA"
                Case 3
                    My.Forms.frmPacientes.cmbtipodoc_pac.Text = "PASAPORTE"
                Case 4
                    My.Forms.frmPacientes.cmbtipodoc_pac.Text = "C.EXTRANGERIA"

            End Select

            My.Forms.frmPacientes.txtnumdoc_pac.Text = CLASE_PACIENTES.xnumdoc_pac
            My.Forms.frmPacientes.txtdedoc_pac.Text = CLASE_PACIENTES.xdedoc_pac

            If CLASE_PACIENTES.xsexo_pac = "M" Then
                My.Forms.frmPacientes.rbtMasculino_pac.Checked = True
            Else
                My.Forms.frmPacientes.rbtFemenino_pac.Checked = True
            End If

            CLASE_GENERAL.cargar_combo("pacientes", My.Forms.frmPacientes.cmbEntidad, CLASE_GENERAL.mensaje_error)

            My.Forms.frmPacientes.cmbEntidad.SelectedValue = CLASE_PACIENTES.xIdentidad
            My.Forms.frmPacientes.txtnhclinica.Text = CLASE_PACIENTES.xnhclinica

            My.Forms.frmPacientes.cmbOperadorCel.SelectedValue = CLASE_PACIENTES.xIdoperador

            Select Case CLASE_PACIENTES.xIdestado_pac

                Case 1
                    My.Forms.frmPacientes.rbtEstado_Entratamiento.Checked = True
                Case 2
                    My.Forms.frmPacientes.rbtEstado_Bloqueado.Checked = True
                Case 3
                    My.Forms.frmPacientes.rbtEstado_Retencion.Checked = True
                Case 4
                    My.Forms.frmPacientes.rbtEstado_Retirado.Checked = True

            End Select

            PAC.dispose()
            PAC = Nothing

            '******************************** CARGAMOS LOS CONTACTOS DEL PACIENTE ***********************************

            contar = 0
            contar = CLASE_GENERAL.contarcontactostodos(CON.p_IdUsuario, 1, CLASE_GENERAL.mensaje_error)

            If contar > 1 Then


                CON.p_IdTUsuario = 1 ' Lo Utilizamos porque es un paciente
                CON.Seleccionar("xdt")

                Dim i As Integer

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 5 Then

                        If CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtTelCasa_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtTelCasa_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("teloficina_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtTelOficina_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtTelOficina_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("teloficina_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("fax_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtFax_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtFax_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("fax_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("cel_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtCelular_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtCelular_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("email_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtemail_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtemail_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("web_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtweb_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtweb_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("web_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 1 Then

                        If CLASE_GENERAL.xdt.Rows(i).Item("nom_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtPadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtPadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("nom_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtTelPadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtTelPadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("cel_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtCelPadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtCelPadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("ocu_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtOcuPadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtOcuPadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("ocu_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("email_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtemailPadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtemailPadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 2 Then

                        If CLASE_GENERAL.xdt.Rows(i).Item("nom_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtMadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtMadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("nom_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtTelMadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtTelMadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("cel_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtCelMadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtCelMadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("ocu_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtOcuMadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtOcuMadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("ocu_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("email_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtemailMadre_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtemailMadre_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 3 Then

                        If CLASE_GENERAL.xdt.Rows(i).Item("nom_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtAcudiente_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtAcudiente_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("nom_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtTelAcudiente_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtTelAcudiente_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("cel_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtCelAcudiente_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtCelAcudiente_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("ocu_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtOcuAcudiente_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtOcuAcudiente_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("ocu_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("email_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtemailAcudiente_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtemailAcudiente_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 4 Then

                        If CLASE_GENERAL.xdt.Rows(i).Item("nom_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtConyuge_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtConyuge_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("nom_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtTelConyuge_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtTelConyuge_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("cel_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtCelConyuge_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtCelConyuge_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("ocu_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtOcuConyuge_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtOcuConyuge_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("ocu_con")
                        End If

                        If CLASE_GENERAL.xdt.Rows(i).Item("email_con") Is DBNull.Value Then
                            My.Forms.frmPacientes.txtemailConyuge_pac.Text = ""
                        Else
                            My.Forms.frmPacientes.txtemailConyuge_pac.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                        End If

                    End If

                Next

                CLASE_GENERAL.xdt.Clear()
                CLASE_GENERAL.xdt = Nothing

            End If

            CON.dispose()
            CON = Nothing

            '******************************** CARGAMOS FOTO Y NOTAS DEL PACIENTE ***********************************

            'Verificamos que exista las notas y las fotos
            contar = 0
            contar = CLASE_GENERAL.contarnotas(NOTA.p_IdUsuario, 1, CLASE_GENERAL.mensaje_error)

            If contar = 1 Then


                NOTA.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                NOTA.Seleccionar("notas")

                If CLASE_NOTAS.xnota Is DBNull.Value Then
                    My.Forms.frmPacientes.RichTxtNotas_pac.Text = ""
                Else
                    My.Forms.frmPacientes.RichTxtNotas_pac.Text = CLASE_NOTAS.xnota
                End If


                If Not (CLASE_NOTAS.xfotolong.Length = 0) Then
                    iImagen = GENE.Bytes_Imagen(CLASE_NOTAS.xfotolong)
                    My.Forms.frmPacientes.pbFoto_pac.Image = iImagen

                Else

                    My.Forms.frmPacientes.pbFoto_pac.Image = My.Resources.fondopaciente

                End If

                NOTA.dispose()
                NOTA = Nothing
                GENE = Nothing

            Else

                NOTA.dispose()
                NOTA = Nothing
                GENE = Nothing

            End If

            '************************************  CARGAR LA FICHA CON LOS DATOS****************************

            My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Forms.frmPacientes.pbFoto_pac.Image
            My.Forms.mdiOrthoSoft.txtId_ficha.Text = My.Forms.frmPacientes.txtIdpaciente.Text
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = My.Forms.frmPacientes.txtnombres_pac.Text & " " & My.Forms.frmPacientes.txtapellidos_pac.Text
            My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = My.Forms.frmPacientes.txtreferido_pac.Text
            My.Forms.mdiOrthoSoft.txtnhistoria_ficha.Text = My.Forms.frmPacientes.txtnhclinica.Text
            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = My.Forms.frmPacientes.txtCelular_pac.Text
            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = My.Forms.frmPacientes.txtTelCasa_pac.Text
            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = My.Forms.frmPacientes.txtemail_pac.Text

            '***************************** MODULO PARA INGRESO EN EL ESTADO ******************************

            My.Forms.mdiOrthoSoft.lblActivoPaciente.Text = My.Forms.frmPacientes.txtnombres_pac.Text & " " & My.Forms.frmPacientes.txtapellidos_pac.Text
            My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag = My.Forms.frmPacientes.txtIdpaciente.Text

            'Cargamos Id especial para Huellas
            CLASE_GENERAL._Idpaciente_consec = CLASE_PACIENTES.xIdpaciente

            If My.Forms.frmPacientes.rbtEstado_Entratamiento.Checked = True Then
                My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LightSkyBlue
            ElseIf My.Forms.frmPacientes.rbtEstado_Bloqueado.Checked = True Then
                My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Salmon
            ElseIf My.Forms.frmPacientes.rbtEstado_Retencion.Checked = True Then
                My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LimeGreen
            ElseIf My.Forms.frmPacientes.rbtEstado_Retirado.Checked = True Then
                My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Khaki
            End If

            '*********************************** CARGAMOS LA PROXIMA CITA DEL PACIENTE *******************

            CITA = New CLASE_CITAS

            fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
            CITA.p_fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
            CITA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

            CITA.Seleccionar("proximacita")

            If CLASE_GENERAL.xdt.Rows.Count <> 0 Then

                If CLASE_GENERAL.xdt.Rows(0).Item("FECHA") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtProxCita_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtProxCita_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("FECHA")
                End If

                If CLASE_GENERAL.xdt.Rows(0).Item("HORAINI") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtHINI_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtHINI_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("HORAINI")
                End If

                If CLASE_GENERAL.xdt.Rows(0).Item("HORAFIN") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtHFIN_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtHFIN_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("HORAFIN")
                End If

                If CLASE_GENERAL.xdt.Rows(0).Item("CONSULTA") Is DBNull.Value Then
                    My.Forms.mdiOrthoSoft.txtproced_ficha.Text = ""
                Else
                    My.Forms.mdiOrthoSoft.txtproced_ficha.Text = CLASE_GENERAL.xdt.Rows(0).Item("CONSULTA")
                End If

            End If

            CITA.dispose()

            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing

            EVEN.bloquaerdesbloquear("editarpaciente")
            EVEN = Nothing

            My.Forms.frmPacientes.btnEstudiosPac.Enabled = True
            My.Forms.frmPacientes.btnPacOdontograma.Enabled = True
            My.Forms.frmPacientes.btnEstadoCuenta.Enabled = True
            My.Forms.frmPacientes.gpHC_NDoc.Enabled = False

            My.Forms.mdiOrthoSoft.btnEnvioEmail.Enabled = True
            My.Forms.mdiOrthoSoft.btnEditarFicha.Enabled = False


        Catch ex As Exception

            MsgBox("Seleccione un Registro por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pacientes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Public Shared Function CalcularEdad(ByVal fechaNacimiento As DateTime) As Integer

        Dim fechaActual As DateTime = DateTime.Now
        Dim edad As Integer = fechaActual.Year - fechaNacimiento.Year

        ' Calcular si no ha cumplido aun
        If DateTime.Now.Month < fechaNacimiento.Month OrElse (DateTime.Now.Month = fechaNacimiento.Month AndAlso DateTime.Now.Day < fechaNacimiento.Day) Then

            edad -= 1

        End If

        Return edad

    End Function

    Public Function buscarcorreos(ByVal paciente As Integer) As String

        Dim correos As String
        Dim edad As Integer

        PAC = New CLASE_PACIENTES
        CON = New CLASE_CONTACTOS

        PAC.p_IdPaciente = paciente
        CON.p_IdUsuario = paciente

        Idpaciente = paciente

        PAC.Seleccionar("solofechanacimiento")

        edad = CalcularEdad(CLASE_PACIENTES.xfecnac_pac)

        PAC.dispose()
        PAC = Nothing


        If edad < 18 Then

            correos = ""

            contar = 0
            contar = CLASE_GENERAL.contarcontactostodos(paciente, 1, CLASE_GENERAL.mensaje_error)

            If contar > 1 Then

                CON.p_IdTUsuario = 1 ' Lo Utilizamos porque es un paciente
                CON.Seleccionar("xdtemail")

                Dim i As Integer

                For i = 0 To CLASE_GENERAL.xdt2.Rows.Count - 1

                    If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 5 Then

                        If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "notiene@" Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "" Then
                            correos = correos & ""
                        Else
                            correos = correos & CLASE_GENERAL.xdt2.Rows(i).Item("email_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 1 Then

                        If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "notiene@" Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "" Then
                            correos = correos & ""
                        Else
                            correos = correos & ", " & CLASE_GENERAL.xdt2.Rows(i).Item("email_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 2 Then

                        If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "notiene@" Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "" Then
                            correos = correos & ""
                        Else
                            correos = correos & ", " & CLASE_GENERAL.xdt2.Rows(i).Item("email_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 3 Then

                        If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "notiene@" Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "" Then
                            correos = correos & ""
                        Else
                            correos = correos & ", " & CLASE_GENERAL.xdt2.Rows(i).Item("email_con")
                        End If

                    End If

                    If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 4 Then

                        If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "notiene@" Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "" Then
                            correos = correos & ""
                        Else
                            correos = correos & ", " & CLASE_GENERAL.xdt2.Rows(i).Item("email_con")
                        End If

                    End If

                Next

            End If

            CLASE_GENERAL.xdt2.Clear()
            CLASE_GENERAL.xdt2 = Nothing

            CON.dispose()
            CON = Nothing

        Else

            correos = ""

            contar = 0
            contar = CLASE_GENERAL.contarcontactostodos(paciente, 1, CLASE_GENERAL.mensaje_error)

            If contar > 1 Then

                CON.p_IdTUsuario = 1 ' Lo Utilizamos porque es un paciente
                CON.Seleccionar("xdtemail")

                Dim i As Integer

                For i = 0 To CLASE_GENERAL.xdt2.Rows.Count - 1

                    If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 5 Then

                        If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "notiene@" Or CLASE_GENERAL.xdt2.Rows(i).Item("email_con") = "" Then
                            correos = ""
                        Else
                            correos = CLASE_GENERAL.xdt2.Rows(i).Item("email_con")
                        End If

                    End If

                Next


            End If


            CLASE_GENERAL.xdt2.Clear()
            CLASE_GENERAL.xdt2 = Nothing

            CON.dispose()
            CON = Nothing

        End If

        Return correos

    End Function

End Class
