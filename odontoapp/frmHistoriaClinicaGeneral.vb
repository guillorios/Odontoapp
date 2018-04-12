Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Math

Public Class frmHistoriaClinicaGeneral


    'Creamos las Clases
    Private PAC As CLASE_PACIENTES
    Private EVEN As CLASE_EVENTOS
    Private CTRL As CLASE_CONTROL
    Private GENE As CLASE_GENERAL
    Private CON As CLASE_CONTACTOS

    'Clases para la Historia Clinica
    Private HCGENE As CLASE_HCLINICA_GENERAL

    'Variables
    Private contar As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea Guardar el registro antes de salir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "H.C. General")

        If respuesta = MsgBoxResult.Yes Then

            If btnAdicionar.Enabled = False Then

                btnModificar_Click(sender, e)

            Else

                btnAdicionar_Click(sender, e)

            End If

        End If

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub ubicarcontrol(ByVal control As Control)

        'Este codigo nos permite hacer la ubicacion de los controles centrandolos
        Dim proporcionh As Integer
        Dim proporcionv As Integer

        Dim locationcontrolx As Integer
        Dim locationcontroly As Integer

        'Calculamos el desplazamiento del control con el valor actual de la ventana restandole una constante que es el tamaño de una resolucion de Horizontal 1024 x Vertical 768 
        Dim desplazamiento As Integer
        desplazamiento = Round((CInt(My.Forms.mdiOrthoSoft.PanelFicha.Size.Width) - 538) / 2, 0)

        locationcontrolx = control.Location.X
        locationcontroly = control.Location.Y

        'Ubicamos el control sumandole la posisicion actual mas el desplazamiento calculado
        proporcionh = locationcontrolx + desplazamiento
        proporcionv = locationcontroly
        control.Location = New System.Drawing.Point(proporcionh, proporcionv)

    End Sub


    Public Sub ubicarcontroles()

        'Botones
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnDesbloquear)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnSalir)

        'Amnesis
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpAntecedentes1)
        ubicarcontrol(Me.gpAntecedentes2)
        ubicarcontrol(Me.gpAntecedentes3)
        ubicarcontrol(Me.gpAntecedentes4)
        ubicarcontrol(Me.gpAntecedentes5)

        'Examen Fisico
        ubicarcontrol(Me.lblExamenFisico)
        ubicarcontrol(Me.gpTejidosBlandos)
        ubicarcontrol(Me.gpATMOclusion)
        ubicarcontrol(Me.gpTejidosDentales)

        ubicarcontrol(Me.txtaconsulta_hcg)
        ubicarcontrol(Me.lblaconsulta_hcg)
        ubicarcontrol(Me.txtuconsulta_hcg)
        ubicarcontrol(Me.lbluconsulta_hcg)

        'P.2
        ubicarcontrol(Me.gpExamenPeriodontal)
        ubicarcontrol(Me.gpHabitosOrales)
        ubicarcontrol(Me.gpExamenPulpar)
        ubicarcontrol(Me.gpObservacionesEFisico)

        'P.3
        ubicarcontrol(Me.lblHistoriaClinicaPreventiva)
        ubicarcontrol(Me.gpPreventiva)
        ubicarcontrol(Me.gpObservacionesPreventivas)
        ubicarcontrol(Me.lblExamenesComplementarios)
        ubicarcontrol(Me.gpExamenesComplementarios)

        'Diagnosticos
        ubicarcontrol(Me.lblDiagnosticos)
        ubicarcontrol(Me.gpDiagnosticos)
        ubicarcontrol(Me.gpRemisionEspecialistas)

        'Tratamiento
        ubicarcontrol(Me.lblPlanTratamiento)
        ubicarcontrol(Me.gpPlanTratamiento)
        ubicarcontrol(Me.lblPronostico)
        ubicarcontrol(Me.gpPronostico)

        'Impresion
        ubicarcontrol(Me.btnImprimirHClinica)
        ubicarcontrol(Me.btnOdontograma)

    End Sub


    Private Sub frmHistoriaClinicaGeneral_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '**************************** MODULO INGRESO DE LA HISTORIA CLINICA **************************

            '***** Historia Clinica Ortodoncia 3

            HCGENE = New CLASE_HCLINICA_GENERAL

            HCGENE.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCGENE.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            'ANTECEDENTES
            '1
            If ckant_tratam_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '2
            If ckant_medicam_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '3
            If ckant_alergias_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '4
            If ckant_cardiopatias_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '5
            If ckant_parterial_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '6
            If ckant_embarazo_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '7
            If ckant_diabetes_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '8
            If ckant_hepatitis_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '9
            If ckant_irradia_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '10
            If ckant_discrasia_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '11
            If ckant_fiebre_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '12
            If ckant_enfrenal_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '13
            If ckant_inmunos_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '14
            If ckant_temosionales_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '15
            If ckant_prespi_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '16
            If ckant_tgastricos_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '17
            If ckant_epilepsia_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '18
            If ckant_cirugias_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '19
            If ckant_eorales_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '20
            If ckant_otras_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            HCGENE.p_uconsulta_hcg = Me.txtuconsulta_hcg.Text
            HCGENE.p_aconsulta_hcg = Me.txtaconsulta_hcg.Text

            HCGENE.p_ant_temp_hcg = Me.txtant_temp_hcg.Text
            HCGENE.p_ant_pulsapm_hcg = Me.txtant_pulsapm_hcg.Text
            HCGENE.p_ant_pulsaart_hcg = Me.txtant_pulsaart_hcg.Text
            HCGENE.p_ant_fresp_hcg = Me.txtant_fresp_hcg.Text
            HCGENE.p_ant_familiares_hcg = Me.txtant_familiares_hcg.Text
            HCGENE.p_ant_observa_hcg = Me.txtant_observa_hcg.Text

            'TEJIDOS BLANDOS
            '1
            If ckef_tb_lsuperior_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '2
            If ckef_tb_linferior_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '3
            If ckef_tb_comisuras_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '4
            If ckef_tb_mucosa_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '5
            If ckef_tb_surcos_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '6
            If ckef_tb_frenillos_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '7
            If ckef_tb_otros1_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '8
            If ckef_tb_paladar_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '9
            If ckef_tb_orofar_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '10
            If ckef_tb_lengua_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '11
            If ckef_tb_pisoboca_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '12
            If ckef_tb_rebordes_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '13
            If ckef_tb_gsalivares_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '14
            If ckef_tb_otros2_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            'ATM OCLUSION
            '15
            If ckef_atm_dolormusc_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '16
            If ckef_atm_dolorarti_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '17
            If ckef_atm_ruidoarti_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '18
            If ckef_atm_alterac_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '19
            If ckef_atm_maloclu_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '20
            If ckef_atm_cresim_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '21
            If ckef_atm_otros_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            'TEJIDOS DENTALES
            '22
            If ckef_td_cforma_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '23
            If ckef_td_ctam_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '24
            If ckef_td_cnum_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '25
            If ckef_td_ccolor_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '26
            If ckef_td_cpos_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '27
            If ckef_td_impac_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '28
            If ckef_td_otros_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            'EXAMEN PERIODONTAL
            '29
            If ckef_ep_sangrado_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '30
            If ckef_ep_movilidad_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '31
            If ckef_ep_reces_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '32
            If ckef_ep_bolsa_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '33
            If ckef_ep_calculos_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '34
            If ckef_ep_absceso_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '35
            If ckef_ep_otros_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            'EXAMEN PULPAR
            '36
            If ckef_epu_avital_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '37
            If ckef_epu_dolor_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '38
            If ckef_epu_mdelta_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '39
            If ckef_epu_sensi_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '40
            If ckef_epu_fistula_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '41
            If ckef_epu_dtrata_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '42
            If ckef_epu_otros_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            'HABITOS
            '43
            If ckef_ho_resoral_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '44
            If ckef_ho_succdig_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '45
            If ckef_ho_lenguap_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '46
            If ckef_ho_queilos_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '47
            If ckef_ho_fumador_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '48
            If ckef_ho_onico_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '49
            If ckef_ho_otros_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            HCGENE.p_ef_observa_hcg = Me.txtef_observa_hcg.Text
            HCGENE.p_ef_hallazgos_hcg = Me.txtef_hallazgos_hcg.Text


            'HISTORIA CLINICA DE ACCION PREVENTIVA

            '1
            If ckef_ap_charlas_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '2
            If ckef_ap_cepillado_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '3
            If ckef_ap_seda_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '4
            If ckef_ap_enguague_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '5
            If ckef_ap_fluor_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '6
            If ckef_ap_sellantes_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            HCGENE.p_hc_frec_charlas_hcg = Me.txthc_frec_charlas_hcg.Text
            HCGENE.p_hc_frec_cepillado_hcg = Me.txthc_frec_cepillado_hcg.Text
            HCGENE.p_hc_frec_seda_hcg = Me.txthc_frec_seda_hcg.Text
            HCGENE.p_hc_frec_enguague_hcg = Me.txthc_frec_enguague_hcg.Text
            HCGENE.p_hc_frec_fluor_hcg = Me.txthc_frec_fluor_hcg.Text
            HCGENE.p_hc_frec_sellantes_hcg = Me.txthc_frec_sellantes_hcg.Text

            HCGENE.p_hc_observa_hcg = Me.txthc_observa_hcg.Text
            HCGENE.p_exa_comp_hcg = Me.txtexa_comp_hcg.Text

            HCGENE.p_diag_psano_hcg = Me.txtdiag_psano_hcg.Text
            HCGENE.p_diag_psanotipo_hcg = Me.txtdiag_psanotipo_hcg.Text
            HCGENE.p_diag_psanocod_hcg = Me.txtdiag_psanocod_hcg.Text

            HCGENE.p_diag_tblandos_hcg = Me.txtdiag_tblandos_hcg.Text
            HCGENE.p_diag_tblandostipo_hcg = Me.txtdiag_tblandostipo_hcg.Text
            HCGENE.p_diag_tblandoscod_hcg = Me.txtdiag_tblandoscod_hcg.Text

            HCGENE.p_diag_atm_hcg = Me.txtdiag_atm_hcg.Text
            HCGENE.p_diag_atmtipo_hcg = Me.txtdiag_atmtipo_hcg.Text
            HCGENE.p_diag_atmcod_hcg = Me.txtdiag_atmcod_hcg.Text

            HCGENE.p_diag_tdental_hcg = Me.txtdiag_tdental_hcg.Text
            HCGENE.p_diag_tdentaltipo_hcg = Me.txtdiag_tdentaltipo_hcg.Text
            HCGENE.p_diag_tdentalcod_hcg = Me.txtdiag_tdentalcod_hcg.Text

            HCGENE.p_diag_tperio_hcg = Me.txtdiag_tperio_hcg.Text
            HCGENE.p_diag_tperiotipo_hcg = Me.txtdiag_tperiotipo_hcg.Text
            HCGENE.p_diag_tperiocod_hcg = Me.txtdiag_tperiocod_hcg.Text

            HCGENE.p_diag_tpulpar_hcg = Me.txtdiag_tpulpar_hcg.Text
            HCGENE.p_diag_tpulpartipo_hcg = Me.txtdiag_tpulpartipo_hcg.Text
            HCGENE.p_diag_tpulparcod_hcg = Me.txtdiag_tpulparcod_hcg.Text

            HCGENE.p_diag_otros_hcg = Me.txtdiag_otros_hcg.Text
            HCGENE.p_diag_otrostipo_hcg = Me.txtdiag_otrostipo_hcg.Text
            HCGENE.p_diag_otroscod_hcg = Me.txtdiag_otroscod_hcg.Text

            HCGENE.p_diag_observa_hcg = Me.txtdiag_observa_hcg.Text
            HCGENE.p_diag_remision_hcg = Me.txtdiag_remision_hcg.Text

            HCGENE.p_trata_promocion_hcg = Me.txttrata_promocion_hcg.Text
            HCGENE.p_trata_prevencion_hcg = Me.txttrata_prevencion_hcg.Text
            HCGENE.p_trata_radiog_hcg = Me.txttrata_radiog_hcg.Text
            HCGENE.p_trata_operatoria_hcg = Me.txttrata_operatoria_hcg.Text
            HCGENE.p_trata_endodoncia_hcg = Me.txttrata_endodoncia_hcg.Text
            HCGENE.p_trata_perio_hcg = Me.txttrata_perio_hcg.Text
            HCGENE.p_trata_prosto_hcg = Me.txttrata_prosto_hcg.Text
            HCGENE.p_trata_oclusion_hcg = Me.txttrata_oclusion_hcg.Text
            HCGENE.p_trata_cirugia_hcg = Me.txttrata_cirugia_hcg.Text
            HCGENE.p_pronostico_hcg = Me.txtpronostico_hcg.Text

            HCGENE.Insertar(CLASE_GENERAL.mensaje_error)
            HCGENE.dispose()
            HCGENE = Nothing

            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 14 '4 Crear Historia Clinica
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcg")
            EVEN.bloquaerdesbloquear("bloquearhclinicageneral")
            EVEN = Nothing

            MsgBox("Historia Clinica registrada con exito.", MsgBoxStyle.OkOnly, "H.C. General")

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            '**************************** MODULO INGRESO DE LA HISTORIA CLINICA **************************

            'Controlamos que exista un registro de la historia clinica para modificarlo
            'si no existe creamos un nuevo registro al insertarlo en la base de datos
            contar = 0
            contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica_g", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

            HCGENE = New CLASE_HCLINICA_GENERAL

            HCGENE.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCGENE.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            'ANTECEDENTES
            '1
            If ckant_tratam_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '2
            If ckant_medicam_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '3
            If ckant_alergias_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '4
            If ckant_cardiopatias_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '5
            If ckant_parterial_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '6
            If ckant_embarazo_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '7
            If ckant_diabetes_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '8
            If ckant_hepatitis_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '9
            If ckant_irradia_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '10
            If ckant_discrasia_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '11
            If ckant_fiebre_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '12
            If ckant_enfrenal_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '13
            If ckant_inmunos_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '14
            If ckant_temosionales_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '15
            If ckant_prespi_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '16
            If ckant_tgastricos_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '17
            If ckant_epilepsia_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '18
            If ckant_cirugias_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '19
            If ckant_eorales_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            '20
            If ckant_otras_si.Checked = True Then
                HCGENE.p_antecedentes_hcg &= "1"
            Else
                HCGENE.p_antecedentes_hcg &= "0"
            End If

            HCGENE.p_uconsulta_hcg = Me.txtuconsulta_hcg.Text
            HCGENE.p_aconsulta_hcg = Me.txtaconsulta_hcg.Text

            HCGENE.p_ant_temp_hcg = Me.txtant_temp_hcg.Text
            HCGENE.p_ant_pulsapm_hcg = Me.txtant_pulsapm_hcg.Text
            HCGENE.p_ant_pulsaart_hcg = Me.txtant_pulsaart_hcg.Text
            HCGENE.p_ant_fresp_hcg = Me.txtant_fresp_hcg.Text
            HCGENE.p_ant_familiares_hcg = Me.txtant_familiares_hcg.Text
            HCGENE.p_ant_observa_hcg = Me.txtant_observa_hcg.Text

            'TEJIDOS BLANDOS
            '1
            If ckef_tb_lsuperior_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '2
            If ckef_tb_linferior_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '3
            If ckef_tb_comisuras_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '4
            If ckef_tb_mucosa_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '5
            If ckef_tb_surcos_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '6
            If ckef_tb_frenillos_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '7
            If ckef_tb_otros1_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '8
            If ckef_tb_paladar_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '9
            If ckef_tb_orofar_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '10
            If ckef_tb_lengua_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '11
            If ckef_tb_pisoboca_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '12
            If ckef_tb_rebordes_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '13
            If ckef_tb_gsalivares_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            '14
            If ckef_tb_otros2_si.Checked = True Then
                HCGENE.p_ef_tblandos_hcg &= "1"
            Else
                HCGENE.p_ef_tblandos_hcg &= "0"
            End If

            'ATM OCLUSION
            '15
            If ckef_atm_dolormusc_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '16
            If ckef_atm_dolorarti_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '17
            If ckef_atm_ruidoarti_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '18
            If ckef_atm_alterac_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '19
            If ckef_atm_maloclu_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '20
            If ckef_atm_cresim_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            '21
            If ckef_atm_otros_si.Checked = True Then
                HCGENE.p_ef_atm_hcg &= "1"
            Else
                HCGENE.p_ef_atm_hcg &= "0"
            End If

            'TEJIDOS DENTALES
            '22
            If ckef_td_cforma_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '23
            If ckef_td_ctam_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '24
            If ckef_td_cnum_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '25
            If ckef_td_ccolor_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '26
            If ckef_td_cpos_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '27
            If ckef_td_impac_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            '28
            If ckef_td_otros_si.Checked = True Then
                HCGENE.p_ef_tdentales_hcg &= "1"
            Else
                HCGENE.p_ef_tdentales_hcg &= "0"
            End If

            'EXAMEN PERIODONTAL
            '29
            If ckef_ep_sangrado_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '30
            If ckef_ep_movilidad_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '31
            If ckef_ep_reces_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '32
            If ckef_ep_bolsa_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '33
            If ckef_ep_calculos_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '34
            If ckef_ep_absceso_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            '35
            If ckef_ep_otros_si.Checked = True Then
                HCGENE.p_ef_exaperio_hcg &= "1"
            Else
                HCGENE.p_ef_exaperio_hcg &= "0"
            End If

            'EXAMEN PULPAR
            '36
            If ckef_epu_avital_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '37
            If ckef_epu_dolor_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '38
            If ckef_epu_mdelta_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '39
            If ckef_epu_sensi_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '40
            If ckef_epu_fistula_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '41
            If ckef_epu_dtrata_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            '42
            If ckef_epu_otros_si.Checked = True Then
                HCGENE.p_ef_exapulpar_hcg &= "1"
            Else
                HCGENE.p_ef_exapulpar_hcg &= "0"
            End If

            'HABITOS
            '43
            If ckef_ho_resoral_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '44
            If ckef_ho_succdig_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '45
            If ckef_ho_lenguap_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '46
            If ckef_ho_queilos_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '47
            If ckef_ho_fumador_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '48
            If ckef_ho_onico_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            '49
            If ckef_ho_otros_si.Checked = True Then
                HCGENE.p_ef_habitos_hcg &= "1"
            Else
                HCGENE.p_ef_habitos_hcg &= "0"
            End If

            HCGENE.p_ef_observa_hcg = Me.txtef_observa_hcg.Text
            HCGENE.p_ef_hallazgos_hcg = Me.txtef_hallazgos_hcg.Text


            'HISTORIA CLINICA DE ACCION PREVENTIVA

            '1
            If ckef_ap_charlas_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '2
            If ckef_ap_cepillado_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '3
            If ckef_ap_seda_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '4
            If ckef_ap_enguague_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '5
            If ckef_ap_fluor_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            '6
            If ckef_ap_sellantes_si.Checked = True Then
                HCGENE.p_hc_accionp_hcg &= "1"
            Else
                HCGENE.p_hc_accionp_hcg &= "0"
            End If

            HCGENE.p_hc_frec_charlas_hcg = Me.txthc_frec_charlas_hcg.Text
            HCGENE.p_hc_frec_cepillado_hcg = Me.txthc_frec_cepillado_hcg.Text
            HCGENE.p_hc_frec_seda_hcg = Me.txthc_frec_seda_hcg.Text
            HCGENE.p_hc_frec_enguague_hcg = Me.txthc_frec_enguague_hcg.Text
            HCGENE.p_hc_frec_fluor_hcg = Me.txthc_frec_fluor_hcg.Text
            HCGENE.p_hc_frec_sellantes_hcg = Me.txthc_frec_sellantes_hcg.Text

            HCGENE.p_hc_observa_hcg = Me.txthc_observa_hcg.Text
            HCGENE.p_exa_comp_hcg = Me.txtexa_comp_hcg.Text

            HCGENE.p_diag_psano_hcg = Me.txtdiag_psano_hcg.Text
            HCGENE.p_diag_psanotipo_hcg = Me.txtdiag_psanotipo_hcg.Text
            HCGENE.p_diag_psanocod_hcg = Me.txtdiag_psanocod_hcg.Text

            HCGENE.p_diag_tblandos_hcg = Me.txtdiag_tblandos_hcg.Text
            HCGENE.p_diag_tblandostipo_hcg = Me.txtdiag_tblandostipo_hcg.Text
            HCGENE.p_diag_tblandoscod_hcg = Me.txtdiag_tblandoscod_hcg.Text

            HCGENE.p_diag_atm_hcg = Me.txtdiag_atm_hcg.Text
            HCGENE.p_diag_atmtipo_hcg = Me.txtdiag_atmtipo_hcg.Text
            HCGENE.p_diag_atmcod_hcg = Me.txtdiag_atmcod_hcg.Text

            HCGENE.p_diag_tdental_hcg = Me.txtdiag_tdental_hcg.Text
            HCGENE.p_diag_tdentaltipo_hcg = Me.txtdiag_tdentaltipo_hcg.Text
            HCGENE.p_diag_tdentalcod_hcg = Me.txtdiag_tdentalcod_hcg.Text

            HCGENE.p_diag_tperio_hcg = Me.txtdiag_tperio_hcg.Text
            HCGENE.p_diag_tperiotipo_hcg = Me.txtdiag_tperiotipo_hcg.Text
            HCGENE.p_diag_tperiocod_hcg = Me.txtdiag_tperiocod_hcg.Text

            HCGENE.p_diag_tpulpar_hcg = Me.txtdiag_tpulpar_hcg.Text
            HCGENE.p_diag_tpulpartipo_hcg = Me.txtdiag_tpulpartipo_hcg.Text
            HCGENE.p_diag_tpulparcod_hcg = Me.txtdiag_tpulparcod_hcg.Text

            HCGENE.p_diag_otros_hcg = Me.txtdiag_otros_hcg.Text
            HCGENE.p_diag_otrostipo_hcg = Me.txtdiag_otrostipo_hcg.Text
            HCGENE.p_diag_otroscod_hcg = Me.txtdiag_otroscod_hcg.Text

            HCGENE.p_diag_observa_hcg = Me.txtdiag_observa_hcg.Text
            HCGENE.p_diag_remision_hcg = Me.txtdiag_remision_hcg.Text

            HCGENE.p_trata_promocion_hcg = Me.txttrata_promocion_hcg.Text
            HCGENE.p_trata_prevencion_hcg = Me.txttrata_prevencion_hcg.Text
            HCGENE.p_trata_radiog_hcg = Me.txttrata_radiog_hcg.Text
            HCGENE.p_trata_operatoria_hcg = Me.txttrata_operatoria_hcg.Text
            HCGENE.p_trata_endodoncia_hcg = Me.txttrata_endodoncia_hcg.Text
            HCGENE.p_trata_perio_hcg = Me.txttrata_perio_hcg.Text
            HCGENE.p_trata_prosto_hcg = Me.txttrata_prosto_hcg.Text
            HCGENE.p_trata_oclusion_hcg = Me.txttrata_oclusion_hcg.Text
            HCGENE.p_trata_cirugia_hcg = Me.txttrata_cirugia_hcg.Text
            HCGENE.p_pronostico_hcg = Me.txtpronostico_hcg.Text

            If contar > 0 Then
                HCGENE.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HCGENE.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HCGENE.dispose()
            HCGENE = Nothing

            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 15 '15 Modificar Historia Clinica
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcg")
            EVEN.bloquaerdesbloquear("bloquearhclinicageneral")
            EVEN = Nothing

            MsgBox("Historia Clinica modificada con exito.", MsgBoxStyle.OkOnly, "H.C. General")

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnOdontograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdontograma.Click

        frmOdontogramaGrafico.Show()
        frmOdontogramaGrafico.Activate()

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea un nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "H.C. General")

            If respuesta = MsgBoxResult.Yes Then

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcg")
                EVEN.bloquaerdesbloquear("nuevahcg")
                EVEN.bloquaerdesbloquear("desbloquearhclinicageneral")
                EVEN = Nothing

                Me.btnOdontograma.Enabled = False
                Me.btnImprimirHClinica.Enabled = False



            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub TabHCG_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabHCG.SelectedTabChanged

        Try

            If TabHCG.SelectedTabIndex = 5 Then

                contar = 0
                contar = CLASE_GENERAL.contar2("IdUsuario", "ograma", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    Me.btnImprimirHClinica.Enabled = True

                Else

                    Me.btnImprimirHClinica.Enabled = False
                    MsgBox("Debe crear un odontograma para este Paciente para imprimir la Historia Clinica.", MsgBoxStyle.OkOnly, "H.C. General")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub frmHistoriaClinicaGeneral_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "txtant_familiares_hcg" Or ActiveControl.Name.ToString = "txtant_observa_hcg" Or ActiveControl.Name.ToString = "txtef_observa_hcg" Or ActiveControl.Name.ToString = "txtef_hallazgos_hcg" Or ActiveControl.Name.ToString = "txthc_observa_hcg" Or ActiveControl.Name.ToString = "txtexa_comp_hcg" Or ActiveControl.Name.ToString = "txtdiag_observa_hcg" Or ActiveControl.Name.ToString = "txtdiag_remision_hcg" Or ActiveControl.Name.ToString = "txtpronostico_hcg") Then

            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                e.Handled = True
                SendKeys.Send(Convert.ToChar(Keys.Tab))
            End If

        End If

    End Sub

    Private Sub btnImprimirHClinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirHClinica.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Documento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Histroria Clinica")

            If respuesta = 6 Then

                'Cargamos el Infomre con datos de la base de datos
                HCGENE = New CLASE_HCLINICA_GENERAL
                HCGENE.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                HCGENE.p_IdTUsuario = 1 'Es un paciente
                HCGENE.Seleccionar("impresion")

                'Creamos Objetos para generar el informe
                Dim orptHistoriaClinicaGeneral As New rptHistoriaClinicaGeneral
                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptHistoriaClinicaGeneral.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptHistoriaClinicaGeneral

                '******************************** CARGAMOS LOS CONTACTOS DEL PACIENTE ***********************************

                CON = New CLASE_CONTACTOS
                CON.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                contar = 0
                contar = CLASE_GENERAL.contarcontactostodos(My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, 1, CLASE_GENERAL.mensaje_error)

                If contar > 1 Then


                    CON.p_IdTUsuario = 1 ' Lo Utilizamos porque es un paciente
                    CON.Seleccionar("xdt2")

                    Dim i As Integer

                    For i = 0 To CLASE_GENERAL.xdt2.Rows.Count - 1

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 5 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "''"
                            Else
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") Is DBNull.Value Then
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtCelular_pac").Text = "''"
                            Else
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtCelular_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") & "'"
                            End If

                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 1 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtTelPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinicaGeneral.DataDefinition.FormulaFields.Item("txtTelPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                        End If

                    Next

                    CLASE_GENERAL.xdt2.Clear()
                    CLASE_GENERAL.xdt2 = Nothing

                End If


                '----------- FINALIZAMOS CARGA DE CONTACTOS -------------

                ' Cargamos el Infome desde su contro y modificamos algunas opciones
                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                HCGENE.dispose()
                HCGENE = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnDesbloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesbloquear.Click

        Try

      
            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("desbloquearhclinicageneral")
            EVEN = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub
End Class