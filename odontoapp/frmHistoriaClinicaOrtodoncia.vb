Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Math


Public Class frmHistoriaClinicaOrtodoncia

    'Creamos las Clases
    Private PAC As CLASE_PACIENTES
    Private EVEN As CLASE_EVENTOS
    Private CTRL As CLASE_CONTROL
    Private GENE As CLASE_GENERAL
    Private CON As CLASE_CONTACTOS

    'Clases para la Historia Clinica
    Private HC As CLASE_HCLINICA
    Private HCEF As CLASE_HCLINICA_EFISICO
    Private HCP2 As CLASE_HCLINICA_P2
    Private HCP3 As CLASE_HCLINICA_P3
    Private HCP4 As CLASE_HCLINICA_P4
    Private OGRAMA As CLASE_OGRAMA

    'Varibles de control
    Private fecha As Date
    Private contar As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea Guardar el registro antes de salir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pacientes")

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
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnSalir)

        'Amnesis
        ubicarcontrol(Me.lblmconsulta_h)
        ubicarcontrol(Me.txtmconsulta_h)
        ubicarcontrol(Me.gpEnfermedadActual)
        ubicarcontrol(Me.gpAntecedentesPersonales)
        ubicarcontrol(Me.gpReaccionAlergica)
        ubicarcontrol(Me.gpHabitos)
        ubicarcontrol(Me.gpAntecedentesHereditarios)
        ubicarcontrol(Me.gpRevisionSistema)

        'Examen Fisico
        ubicarcontrol(Me.gpSignosVitales)
        ubicarcontrol(Me.gpExamenClinico)
        ubicarcontrol(Me.lblalarmas_hef)
        ubicarcontrol(Me.txtalarmas_hef)
        ubicarcontrol(Me.lblnotas_hef)
        ubicarcontrol(Me.txtnotas_hef)
        ubicarcontrol(Me.gpAnalisisFacialFrente)
        ubicarcontrol(Me.lblsonrisasimetria_hef)
        ubicarcontrol(Me.txtsonrisasimetria_hef)
        ubicarcontrol(Me.lblsonrisaencia_hef)
        ubicarcontrol(Me.txtsonrisaencia_hef)
        ubicarcontrol(Me.lblsonrisadientesinf_hef)
        ubicarcontrol(Me.txtsonrisadientesinf_hef)

        'P.2
        ubicarcontrol(Me.gpAnalisiFacialPerfil)
        ubicarcontrol(Me.gpAnalisisRadiografiaPanoramica)

        'P.3
        ubicarcontrol(Me.gpAnalisiIntraoralFrente)
        ubicarcontrol(Me.gpLateralDerecha)
        ubicarcontrol(Me.gpLateralIzquierda)
        ubicarcontrol(Me.gpArcoSuperior)
        ubicarcontrol(Me.gpArcoInferior)
        ubicarcontrol(Me.gpDiagnosticoEsqueletico)
        ubicarcontrol(Me.gpAnalisiArticular)
        ubicarcontrol(Me.gpDiagnosticoFacial)

        'P.4
        ubicarcontrol(Me.gpDiagnosticoDental)
        ubicarcontrol(Me.gpObjetivosFaciales)
        ubicarcontrol(Me.gpObjetivosEsqueleticos)
        ubicarcontrol(Me.gpObjetivosDentales)
        ubicarcontrol(Me.gpPlanTratamiento)
        ubicarcontrol(Me.lblTratamiento)
        ubicarcontrol(Me.rbTrataSi)
        ubicarcontrol(Me.rbTrataNo)

        'Tratamiento
        ubicarcontrol(Me.gpTratamientoDefinitivo)
        ubicarcontrol(Me.gpLimitaciones)

        'Impresion
        ubicarcontrol(Me.btnImprimirHClinica)
        ubicarcontrol(Me.btnOdontograma)

    End Sub

    Private Sub frmHistoriaClinicaOrtodoncia_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '**************************** MODULO INGRESO DE LA HISTORIA CLINICA **************************

            HC = New CLASE_HCLINICA

            HC.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HC.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            HC.p_mconsulta_h = Me.txtmconsulta_h.Text
            HC.p_descripcion_h = Me.txtdescripcion_h.Text
            HC.p_clase_h = Me.txtclase_h.Text
            HC.p_duracion_h = Me.txtduracion_h.Text
            HC.p_enfe_infancia_h = Me.txtenfe_infancia_h.Text

            HC.p_enfe_adulto_h = ""

            If Me.chkdiabetes.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkhepatitis.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chksinusitis.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkcardiovas.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkfiebre.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkrespira.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkhipertension.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            HC.p_inmuniza_h = Me.txtinmuniza_h.Text
            HC.p_hospitaliza_h = Me.txthospitaliza_h.Text
            HC.p_traumaticoas_h = Me.txttraumaticoas_h.Text
            HC.p_quirurgicos_h = Me.txtquirurgicos_h.Text
            HC.p_transfusi_h = Me.txttransfusi_h.Text
            HC.p_irradia_h = Me.txtirradia_h.Text
            HC.p_hemorrag_h = Me.txthemorrag_h.Text
            HC.p_medica_act_h = Me.txtmedica_act_h.Text

            HC.p_reaccion_al_h = ""

            If Me.chkanestesia.Checked = True Then
                HC.p_reaccion_al_h &= "1"
            Else
                HC.p_reaccion_al_h &= "0"
            End If

            If Me.chkpenicilina.Checked = True Then
                HC.p_reaccion_al_h &= "1"
            Else
                HC.p_reaccion_al_h &= "0"
            End If

            HC.p_otras_drogas_h = Me.txtotras_drogas_h.Text

            HC.p_habitos_h = ""

            If Me.chkbruxismo.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkdeglusion.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkresbucal.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkinffon.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkfuma.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkempling.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chksuccdigital.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkmorder.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            HC.p_ant_here_gener_h = Me.txtant_here_gener_h.Text
            HC.p_ant_here_bucales_h = Me.txtant_here_bucales_h.Text
            HC.p_rsistema_piel = Me.txtrsistema_piel.Text
            HC.p_rsistema_cabeza = Me.txtrsistema_cabeza.Text
            HC.p_rsistema_cara = Me.txtrsistema_cara.Text
            HC.p_rsistema_oidos = Me.txtrsistema_oidos.Text
            HC.p_rsistema_ojos = Me.txtrsistema_ojos.Text
            HC.p_rsistema_nariz = Me.txtrsistema_nariz.Text
            HC.p_rsistema_senos = Me.txtrsistema_senos.Text
            HC.p_rsistema_cuello = Me.txtrsistema_cuello.Text

            HC.Insertar(CLASE_GENERAL.mensaje_error)
            HC.dispose()
            HC = Nothing

            '***** Historia Clinica Amanesis

            HCEF = New CLASE_HCLINICA_EFISICO

            HCEF.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCEF.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCEF.p_tensionart_hef = Me.txttensionart_hef.Text
            HCEF.p_pulso_hef = Me.txtpulso_hef.Text
            HCEF.p_fr_hef = Me.txtfr_hef.Text
            HCEF.p_piel_hef = Me.txtpiel_hef.Text
            HCEF.p_amigdalas_hef = Me.txtamigdalas_hef.Text
            HCEF.p_not_linf_hef = Me.txtnot_linf_hef.Text
            HCEF.p_pisoboca_hef = Me.txtpisoboca_hef.Text
            HCEF.p_labios__hef = Me.txtlabios__hef.Text
            HCEF.p_paladar_hef = Me.txtpaladar_hef.Text
            HCEF.p_carrillos__hef = Me.txtcarrillos__hef.Text
            HCEF.p_glsalivares__hef = Me.txtglsalivares__hef.Text
            HCEF.p_mucosa_hef = Me.txtmucosa_hef.Text
            HCEF.p_frenillos_hef = Me.txtfrenillos_hef.Text
            HCEF.p_otros_hef = Me.txtotros_hef.Text
            HCEF.p_alarmas_hef = Me.txtalarmas_hef.Text
            HCEF.p_notas_hef = Me.txtnotas_hef.Text
            HCEF.p_tipofacial_hef = Me.txttipofacial_hef.Text
            HCEF.p_impCabello_hef = Me.txtimpCabello_hef.Text
            HCEF.p_simetriav_hef = Me.txtsimetriav_hef.Text
            HCEF.p_simetriah_hef = Me.txtsimetriah_hef.Text
            HCEF.p_cejas_hef = Me.txtcejas_hef.Text
            HCEF.p_esclera_hef = Me.txtesclera_hef.Text
            HCEF.p_intercantal_hef = Me.txtintercantal_hef.Text
            HCEF.p_dorsonariz_hef = Me.txtdorsonariz_hef.Text
            HCEF.p_alasnariz_hef = Me.txtalasnariz_hef.Text
            HCEF.p_puntanariz_hef = Me.txtpuntanariz_hef.Text
            HCEF.p_simcomisur_hef = Me.txtsimcomisur_hef.Text
            HCEF.p_selladolabial_hef = Me.txtselladolabial_hef.Text
            HCEF.p_Inscis_hef = Me.txtinscis_hef.Text
            HCEF.p_mm_hef = Me.txtmm_hef.Text
            HCEF.p_grosorlabial_hef = Me.txtgrosorlabial_hef.Text
            HCEF.p_sonrisasimetria_hef = Me.txtsonrisasimetria_hef.Text
            HCEF.p_sonrisaencia_hef = Me.txtsonrisaencia_hef.Text
            HCEF.p_sonrisadientesinf_hef = Me.txtsonrisadientesinf_hef.Text

            HCEF.Insertar(CLASE_GENERAL.mensaje_error)
            HCEF.dispose()
            HCEF = Nothing

            '******* Historia Clinica P2

            HCP2 = New CLASE_HCLINICA_P2

            HCP2.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCP2.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCP2.p_tipoperfil_hp2 = Me.txttipoperfil_hp2.Text
            HCP2.p_anguloconj_hp2 = Me.txtanguloconj_hp2.Text
            HCP2.p_frente_hp2 = Me.txtfrente_hp2.Text
            HCP2.p_dorsonariz_hp2 = Me.txtdorsonariz_hp2.Text
            HCP2.p_puntanariz_hp2 = Me.txtpuntanariz_hp2.Text
            HCP2.p_columnea_hp2 = Me.txtcolumnea_hp2.Text
            HCP2.p_angnasolabial_hp2 = Me.txtangnasolabial_hp2.Text
            HCP2.p_labios_hp2 = Me.txtlabios_hp2.Text
            HCP2.p_surcomentolabial_hp2 = Me.txtsurcomentolabial_hp2.Text
            HCP2.p_menton_hp2 = Me.txtmenton_hp2.Text
            HCP2.p_angulomentogarg__hp2 = Me.txtangulomentogarg__hp2.Text
            HCP2.p_secerupcion_hp2 = Me.txtsecerupcion_hp2.Text
            HCP2.p_paralelismored_hp2 = Me.txtparalelismored_hp2.Text
            HCP2.p_proporcoronaraiz_hp2 = Me.txtproporcoronaraiz_hp2.Text
            HCP2.p_dientesausentes__hp2 = Me.txtdientesausentes__hp2.Text
            HCP2.p_dientesrete_hp2 = Me.txtdientesrete_hp2.Text
            HCP2.p_dientessuper_hp2 = Me.txtdientessuper_hp2.Text
            HCP2.p_lesionperio_hp2 = Me.txtlesionperio_hp2.Text
            HCP2.p_lesionendod_hp2 = Me.txtlesionendod_hp2.Text
            HCP2.p_anatomiacond_hp2 = Me.txtanatomiacond_hp2.Text
            HCP2.p_estadoligamiento_hp2 = Me.txtestadoligamiento_hp2.Text
            HCP2.p_pisosenomax_hp2 = Me.txtpisosenomax_hp2.Text
            HCP2.p_agujeromento_hp2 = Me.txtagujeromento_hp2.Text

            HCP2.Insertar(CLASE_GENERAL.mensaje_error)
            HCP2.dispose()
            HCP2 = Nothing

            '******* Historia Clinica P3

            HCP3 = New CLASE_HCLINICA_P3

            HCP3.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCP3.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCP3.p_frentelineamsuper_hp3 = ""

            If Me.chklineasupercentr.Checked = True Then
                HCP3.p_frentelineamsuper_hp3 &= "1"
            Else
                HCP3.p_frentelineamsuper_hp3 &= "0"
            End If

            If Me.chklineasuperdeder.Checked = True Then
                HCP3.p_frentelineamsuper_hp3 &= "1"
            Else
                HCP3.p_frentelineamsuper_hp3 &= "0"
            End If

            If Me.chklineasuperdeizq.Checked = True Then
                HCP3.p_frentelineamsuper_hp3 &= "1"
            Else
                HCP3.p_frentelineamsuper_hp3 &= "0"
            End If


            HCP3.p_frentelineamsupermm1_hp3 = Me.txtfrentelineamsupermm1_hp3.Text
            HCP3.p_frentelineamsupermm2_hp3 = Me.txtfrentelineamsupermm2_hp3.Text

            HCP3.p_frentelineaminfer_hp3 = ""

            If Me.chklineainfecentr.Checked = True Then
                HCP3.p_frentelineaminfer_hp3 &= "1"
            Else
                HCP3.p_frentelineaminfer_hp3 &= "0"
            End If

            If Me.chklineainfededer.Checked = True Then
                HCP3.p_frentelineaminfer_hp3 &= "1"
            Else
                HCP3.p_frentelineaminfer_hp3 &= "0"
            End If

            If Me.chklineainfedeizq.Checked = True Then
                HCP3.p_frentelineaminfer_hp3 &= "1"
            Else
                HCP3.p_frentelineaminfer_hp3 &= "0"
            End If

            HCP3.p_frentelineaminfermm1_hp3 = Me.txtfrentelineaminfermm1_hp3.Text
            HCP3.p_frentelineaminfermm2_hp3 = Me.txtfrentelineaminfermm2_hp3.Text
            HCP3.p_frenteoverbite_hp3 = Me.txtfrenteoverbite_hp3.Text
            HCP3.p_frenteoverjet_hp3 = Me.txtfrenteoverjet_hp3.Text
            HCP3.p_frentedientesausen_hp3 = Me.txtfrentedientesausen_hp3.Text
            HCP3.p_ldereoverject_hp3 = Me.txtldereoverject_hp3.Text
            HCP3.p_lderoverbite_hp3 = Me.txtlderoverbite_hp3.Text
            HCP3.p_lderrelcanina_hp3 = Me.txtlderrelcanina_hp3.Text
            HCP3.p_lderrelmolar_hp3 = Me.txtlderrelmolar_hp3.Text
            HCP3.p_lderdientesausen_hp3 = Me.txtlderdientesausen_hp3.Text
            HCP3.p_lizquoverject_hp3 = Me.txtlizquoverject_hp3.Text
            HCP3.p_lizquoverbite_hp3 = Me.txtlizquoverbite_hp3.Text
            HCP3.p_lizqurelcanina_hp3 = Me.txtlizqurelcanina_hp3.Text
            HCP3.p_lizqurelmolar_hp3 = Me.txtlizqurelmolar_hp3.Text
            HCP3.p_lizqudientesausen_hp3 = Me.txtlizqudientesausen_hp3.Text
            HCP3.p_arcsupforma_hp3 = Me.txtlizqudientesausen_hp3.Text
            HCP3.p_arcsupsime_hp3 = Me.txtarcsupsime_hp3.Text
            HCP3.p_arcsupausen_hp3 = Me.txtarcsupausen_hp3.Text
            HCP3.p_arcinfforma_hp3 = Me.txtarcinfforma_hp3.Text
            HCP3.p_arcinfsime_hp3 = Me.txtarcinfsime_hp3.Text
            HCP3.p_arcinfausen_hp3 = Me.txtarcinfausen_hp3.Text
            HCP3.p_aarticdesviacion_hp3 = Me.txtaarticdesviacion_hp3.Text
            HCP3.p_aarticdeflexion_hp3 = Me.txtaarticdeflexion_hp3.Text
            HCP3.p_aarticruidosart_hp3 = Me.txtaarticruidosart_hp3.Text
            HCP3.p_aarticsintomat_hp3 = Me.txtaarticsintomat_hp3.Text
            HCP3.p_dfacialtperfil_hp3 = Me.txtdfacialtperfil_hp3.Text
            HCP3.p_dfacialangconje_hp3 = Me.txtdfacialangconje_hp3.Text
            HCP3.p_dfaciallabios_hp3 = Me.txtdfaciallabios_hp3.Text
            HCP3.p_dfacialangnasolab_hp3 = Me.txtdfacialangnasolab_hp3.Text
            HCP3.p_desquclase_hp3 = Me.txtdesquclase_hp3.Text
            HCP3.p_desquesqu_hp3 = Me.txtdesquesqu_hp3.Text
            HCP3.p_desqudimensvert_hp3 = Me.txtdesqudimensvert_hp3.Text

            HCP3.Insertar(CLASE_GENERAL.mensaje_error)
            HCP3.dispose()
            HCP3 = Nothing

            '******* Historia Clinica P4

            HCP4 = New CLASE_HCLINICA_P4

            HCP4.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCP4.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCP4.p_malomolar_hp4 = Me.txtmalomolar_hp4.Text
            HCP4.p_malocanina_hp4 = Me.txtmalocanina_hp4.Text
            HCP4.p_tdenticion_hp4 = Me.txttdenticion_hp4.Text
            HCP4.p_lmedias_hp4 = Me.txtlmedias_hp4.Text
            HCP4.p_overjet_hp4 = Me.txtoverjet_hp4.Text
            HCP4.p_overbite_hp4 = Me.txtoverbite_hp4.Text
            HCP4.p_dientesausentes_hp4 = Me.txtdientesausentes_hp4.Text
            HCP4.p_tipoapi_hp4 = Me.txttipoapi_hp4.Text
            HCP4.p_mejorarperfil_hp4 = Me.txtmejorarperfil_hp4.Text
            HCP4.p_corrperfil_hp4 = Me.txtcorrperfil_hp4.Text
            HCP4.p_angnasolab_hp4 = Me.txtangnasolab_hp4.Text
            HCP4.p_labios_hp4 = Me.txtlabios_hp4.Text
            HCP4.p_ctrlperfesq_hp4 = Me.txtctrlperfesq_hp4.Text
            HCP4.p_corrperfesq_hp4 = Me.txtcorrperfesq_hp4.Text
            HCP4.p_corrfrente_hp4 = Me.txtcorrfrente_hp4.Text
            HCP4.p_lograroverjet_hp4 = Me.txtlograroverjet_hp4.Text
            HCP4.p_lograrmolarcan_hp4 = Me.txtlograrmolarcan_hp4.Text
            HCP4.p_lograrbuenaocl_hp4 = Me.txtlograrbuenaocl_hp4.Text
            HCP4.p_plan1_hp4 = Me.txtplan1_hp4.Text
            HCP4.p_plan2_hp4 = Me.txtplan2_hp4.Text
            HCP4.p_plan3_hp4 = Me.txtplan3_hp4.Text

            HCP4.p_tratamortognatico_hp4 = ""

            If rbTrataSi.Checked = True Then

                HCP4.p_tratamortognatico_hp4 = "1"

            Else

                HCP4.p_tratamortognatico_hp4 = "0"

            End If

            HCP4.p_reqtratam_hp4 = Me.txtreqtratam_hp4.Text
            HCP4.p_cuantas_hp4 = Me.txtcuantas_hp4.Text
            HCP4.p_tratamientodef_hp4 = Me.texttratamientodef_hp4.Text
            HCP4.p_limitacaso_hp4 = Me.textlimitacaso_hp4.Text

            HCP4.Insertar(CLASE_GENERAL.mensaje_error)
            HCP4.dispose()
            HCP4 = Nothing

           
            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 14 '14 Crear Historia Clinica
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcorto")
            EVEN = Nothing

            MsgBox("Historia Clinica registrada con Exito", MsgBoxStyle.OkOnly, "H.C. Ortodocia")

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
            contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

            '***** Historia Clinica Inicial

            HC = New CLASE_HCLINICA

            HC.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HC.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            HC.p_mconsulta_h = Me.txtmconsulta_h.Text
            HC.p_descripcion_h = Me.txtdescripcion_h.Text
            HC.p_clase_h = Me.txtclase_h.Text
            HC.p_duracion_h = Me.txtduracion_h.Text
            HC.p_enfe_infancia_h = Me.txtenfe_infancia_h.Text

            HC.p_enfe_adulto_h = ""

            If Me.chkdiabetes.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkhepatitis.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chksinusitis.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkcardiovas.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkfiebre.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkrespira.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            If Me.chkhipertension.Checked = True Then
                HC.p_enfe_adulto_h &= "1"
            Else
                HC.p_enfe_adulto_h &= "0"
            End If

            HC.p_inmuniza_h = Me.txtinmuniza_h.Text
            HC.p_hospitaliza_h = Me.txthospitaliza_h.Text
            HC.p_traumaticoas_h = Me.txttraumaticoas_h.Text
            HC.p_quirurgicos_h = Me.txtquirurgicos_h.Text
            HC.p_transfusi_h = Me.txttransfusi_h.Text
            HC.p_irradia_h = Me.txtirradia_h.Text
            HC.p_hemorrag_h = Me.txthemorrag_h.Text
            HC.p_medica_act_h = Me.txtmedica_act_h.Text

            HC.p_reaccion_al_h = ""

            If Me.chkanestesia.Checked = True Then
                HC.p_reaccion_al_h &= "1"
            Else
                HC.p_reaccion_al_h &= "0"
            End If

            If Me.chkpenicilina.Checked = True Then
                HC.p_reaccion_al_h &= "1"
            Else
                HC.p_reaccion_al_h &= "0"
            End If

            HC.p_otras_drogas_h = Me.txtotras_drogas_h.Text

            HC.p_habitos_h = ""

            If Me.chkbruxismo.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkdeglusion.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkresbucal.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkinffon.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkfuma.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkempling.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chksuccdigital.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            If Me.chkmorder.Checked = True Then
                HC.p_habitos_h &= "1"
            Else
                HC.p_habitos_h &= "0"
            End If

            HC.p_ant_here_gener_h = Me.txtant_here_gener_h.Text
            HC.p_ant_here_bucales_h = Me.txtant_here_bucales_h.Text
            HC.p_rsistema_piel = Me.txtrsistema_piel.Text
            HC.p_rsistema_cabeza = Me.txtrsistema_cabeza.Text
            HC.p_rsistema_cara = Me.txtrsistema_cara.Text
            HC.p_rsistema_oidos = Me.txtrsistema_oidos.Text
            HC.p_rsistema_ojos = Me.txtrsistema_ojos.Text
            HC.p_rsistema_nariz = Me.txtrsistema_nariz.Text
            HC.p_rsistema_senos = Me.txtrsistema_senos.Text
            HC.p_rsistema_cuello = Me.txtrsistema_cuello.Text

            If contar > 0 Then
                HC.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HC.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HC.dispose()
            HC = Nothing

            '***** Historia Clinica Amanesis

            HCEF = New CLASE_HCLINICA_EFISICO

            HCEF.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCEF.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCEF.p_tensionart_hef = Me.txttensionart_hef.Text
            HCEF.p_pulso_hef = Me.txtpulso_hef.Text
            HCEF.p_fr_hef = Me.txtfr_hef.Text
            HCEF.p_piel_hef = Me.txtpiel_hef.Text
            HCEF.p_amigdalas_hef = Me.txtamigdalas_hef.Text
            HCEF.p_not_linf_hef = Me.txtnot_linf_hef.Text
            HCEF.p_pisoboca_hef = Me.txtpisoboca_hef.Text
            HCEF.p_labios__hef = Me.txtlabios__hef.Text
            HCEF.p_paladar_hef = Me.txtpaladar_hef.Text
            HCEF.p_carrillos__hef = Me.txtcarrillos__hef.Text
            HCEF.p_glsalivares__hef = Me.txtglsalivares__hef.Text
            HCEF.p_mucosa_hef = Me.txtmucosa_hef.Text
            HCEF.p_frenillos_hef = Me.txtfrenillos_hef.Text
            HCEF.p_otros_hef = Me.txtotros_hef.Text
            HCEF.p_alarmas_hef = Me.txtalarmas_hef.Text
            HCEF.p_notas_hef = Me.txtnotas_hef.Text
            HCEF.p_tipofacial_hef = Me.txttipofacial_hef.Text
            HCEF.p_impCabello_hef = Me.txtimpCabello_hef.Text
            HCEF.p_simetriav_hef = Me.txtsimetriav_hef.Text
            HCEF.p_simetriah_hef = Me.txtsimetriah_hef.Text
            HCEF.p_cejas_hef = Me.txtcejas_hef.Text
            HCEF.p_esclera_hef = Me.txtesclera_hef.Text
            HCEF.p_intercantal_hef = Me.txtintercantal_hef.Text
            HCEF.p_dorsonariz_hef = Me.txtdorsonariz_hef.Text
            HCEF.p_alasnariz_hef = Me.txtalasnariz_hef.Text
            HCEF.p_puntanariz_hef = Me.txtpuntanariz_hef.Text
            HCEF.p_simcomisur_hef = Me.txtsimcomisur_hef.Text
            HCEF.p_selladolabial_hef = Me.txtselladolabial_hef.Text
            HCEF.p_Inscis_hef = Me.txtinscis_hef.Text
            HCEF.p_mm_hef = Me.txtmm_hef.Text
            HCEF.p_grosorlabial_hef = Me.txtgrosorlabial_hef.Text
            HCEF.p_sonrisasimetria_hef = Me.txtsonrisasimetria_hef.Text
            HCEF.p_sonrisaencia_hef = Me.txtsonrisaencia_hef.Text
            HCEF.p_sonrisadientesinf_hef = Me.txtsonrisadientesinf_hef.Text

            If contar > 0 Then
                HCEF.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HCEF.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HCEF.dispose()
            HCEF = Nothing

            '******* Historia Clinica P2

            HCP2 = New CLASE_HCLINICA_P2

            HCP2.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCP2.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCP2.p_tipoperfil_hp2 = Me.txttipoperfil_hp2.Text
            HCP2.p_anguloconj_hp2 = Me.txtanguloconj_hp2.Text
            HCP2.p_frente_hp2 = Me.txtfrente_hp2.Text
            HCP2.p_dorsonariz_hp2 = Me.txtdorsonariz_hp2.Text
            HCP2.p_puntanariz_hp2 = Me.txtpuntanariz_hp2.Text
            HCP2.p_columnea_hp2 = Me.txtcolumnea_hp2.Text
            HCP2.p_angnasolabial_hp2 = Me.txtangnasolabial_hp2.Text
            HCP2.p_labios_hp2 = Me.txtlabios_hp2.Text
            HCP2.p_surcomentolabial_hp2 = Me.txtsurcomentolabial_hp2.Text
            HCP2.p_menton_hp2 = Me.txtmenton_hp2.Text
            HCP2.p_angulomentogarg__hp2 = Me.txtangulomentogarg__hp2.Text
            HCP2.p_secerupcion_hp2 = Me.txtsecerupcion_hp2.Text
            HCP2.p_paralelismored_hp2 = Me.txtparalelismored_hp2.Text
            HCP2.p_proporcoronaraiz_hp2 = Me.txtproporcoronaraiz_hp2.Text
            HCP2.p_dientesausentes__hp2 = Me.txtdientesausentes__hp2.Text
            HCP2.p_dientesrete_hp2 = Me.txtdientesrete_hp2.Text
            HCP2.p_dientessuper_hp2 = Me.txtdientessuper_hp2.Text
            HCP2.p_lesionperio_hp2 = Me.txtlesionperio_hp2.Text
            HCP2.p_lesionendod_hp2 = Me.txtlesionendod_hp2.Text
            HCP2.p_anatomiacond_hp2 = Me.txtanatomiacond_hp2.Text
            HCP2.p_estadoligamiento_hp2 = Me.txtestadoligamiento_hp2.Text
            HCP2.p_pisosenomax_hp2 = Me.txtpisosenomax_hp2.Text
            HCP2.p_agujeromento_hp2 = Me.txtagujeromento_hp2.Text

            If contar > 0 Then
                HCP2.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HCP2.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HCP2.dispose()
            HCP2 = Nothing

            '******* Historia Clinica P3

            HCP3 = New CLASE_HCLINICA_P3

            HCP3.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCP3.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCP3.p_frentelineamsuper_hp3 = ""

            If Me.chklineasupercentr.Checked = True Then
                HCP3.p_frentelineamsuper_hp3 &= "1"
            Else
                HCP3.p_frentelineamsuper_hp3 &= "0"
            End If

            If Me.chklineasuperdeder.Checked = True Then
                HCP3.p_frentelineamsuper_hp3 &= "1"
            Else
                HCP3.p_frentelineamsuper_hp3 &= "0"
            End If

            If Me.chklineasuperdeizq.Checked = True Then
                HCP3.p_frentelineamsuper_hp3 &= "1"
            Else
                HCP3.p_frentelineamsuper_hp3 &= "0"
            End If


            HCP3.p_frentelineamsupermm1_hp3 = Me.txtfrentelineamsupermm1_hp3.Text
            HCP3.p_frentelineamsupermm2_hp3 = Me.txtfrentelineamsupermm2_hp3.Text

            HCP3.p_frentelineaminfer_hp3 = ""

            If Me.chklineainfecentr.Checked = True Then
                HCP3.p_frentelineaminfer_hp3 &= "1"
            Else
                HCP3.p_frentelineaminfer_hp3 &= "0"
            End If

            If Me.chklineainfededer.Checked = True Then
                HCP3.p_frentelineaminfer_hp3 &= "1"
            Else
                HCP3.p_frentelineaminfer_hp3 &= "0"
            End If

            If Me.chklineainfedeizq.Checked = True Then
                HCP3.p_frentelineaminfer_hp3 &= "1"
            Else
                HCP3.p_frentelineaminfer_hp3 &= "0"
            End If

            HCP3.p_frentelineaminfermm1_hp3 = Me.txtfrentelineaminfermm1_hp3.Text
            HCP3.p_frentelineaminfermm2_hp3 = Me.txtfrentelineaminfermm2_hp3.Text
            HCP3.p_frenteoverbite_hp3 = Me.txtfrenteoverbite_hp3.Text
            HCP3.p_frenteoverjet_hp3 = Me.txtfrenteoverjet_hp3.Text
            HCP3.p_frentedientesausen_hp3 = Me.txtfrentedientesausen_hp3.Text
            HCP3.p_ldereoverject_hp3 = Me.txtldereoverject_hp3.Text
            HCP3.p_lderoverbite_hp3 = Me.txtlderoverbite_hp3.Text
            HCP3.p_lderrelcanina_hp3 = Me.txtlderrelcanina_hp3.Text
            HCP3.p_lderrelmolar_hp3 = Me.txtlderrelmolar_hp3.Text
            HCP3.p_lderdientesausen_hp3 = Me.txtlderdientesausen_hp3.Text
            HCP3.p_lizquoverject_hp3 = Me.txtlizquoverject_hp3.Text
            HCP3.p_lizquoverbite_hp3 = Me.txtlizquoverbite_hp3.Text
            HCP3.p_lizqurelcanina_hp3 = Me.txtlizqurelcanina_hp3.Text
            HCP3.p_lizqurelmolar_hp3 = Me.txtlizqurelmolar_hp3.Text
            HCP3.p_lizqudientesausen_hp3 = Me.txtlizqudientesausen_hp3.Text
            HCP3.p_arcsupforma_hp3 = Me.txtarcsupforma_hp3.Text
            HCP3.p_arcsupsime_hp3 = Me.txtarcsupsime_hp3.Text
            HCP3.p_arcsupausen_hp3 = Me.txtarcsupausen_hp3.Text
            HCP3.p_arcinfforma_hp3 = Me.txtarcinfforma_hp3.Text
            HCP3.p_arcinfsime_hp3 = Me.txtarcinfsime_hp3.Text
            HCP3.p_arcinfausen_hp3 = Me.txtarcinfausen_hp3.Text
            HCP3.p_aarticdesviacion_hp3 = Me.txtaarticdesviacion_hp3.Text
            HCP3.p_aarticdeflexion_hp3 = Me.txtaarticdeflexion_hp3.Text
            HCP3.p_aarticruidosart_hp3 = Me.txtaarticruidosart_hp3.Text
            HCP3.p_aarticsintomat_hp3 = Me.txtaarticsintomat_hp3.Text
            HCP3.p_dfacialtperfil_hp3 = Me.txtdfacialtperfil_hp3.Text
            HCP3.p_dfacialangconje_hp3 = Me.txtdfacialangconje_hp3.Text
            HCP3.p_dfaciallabios_hp3 = Me.txtdfaciallabios_hp3.Text
            HCP3.p_dfacialangnasolab_hp3 = Me.txtdfacialangnasolab_hp3.Text
            HCP3.p_desquclase_hp3 = Me.txtdesquclase_hp3.Text
            HCP3.p_desquesqu_hp3 = Me.txtdesquesqu_hp3.Text
            HCP3.p_desqudimensvert_hp3 = Me.txtdesqudimensvert_hp3.Text

            If contar > 0 Then
                HCP3.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HCP3.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HCP3.dispose()
            HCP3 = Nothing

            '******* Historia Clinica P4

            HCP4 = New CLASE_HCLINICA_P4

            HCP4.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCP4.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente

            HCP4.p_malomolar_hp4 = Me.txtmalomolar_hp4.Text
            HCP4.p_malocanina_hp4 = Me.txtmalocanina_hp4.Text
            HCP4.p_tdenticion_hp4 = Me.txttdenticion_hp4.Text
            HCP4.p_lmedias_hp4 = Me.txtlmedias_hp4.Text
            HCP4.p_overjet_hp4 = Me.txtoverjet_hp4.Text
            HCP4.p_overbite_hp4 = Me.txtoverbite_hp4.Text
            HCP4.p_dientesausentes_hp4 = Me.txtdientesausentes_hp4.Text
            HCP4.p_tipoapi_hp4 = Me.txttipoapi_hp4.Text
            HCP4.p_mejorarperfil_hp4 = Me.txtmejorarperfil_hp4.Text
            HCP4.p_corrperfil_hp4 = Me.txtcorrperfil_hp4.Text
            HCP4.p_angnasolab_hp4 = Me.txtangnasolab_hp4.Text
            HCP4.p_labios_hp4 = Me.txtlabios_hp4.Text
            HCP4.p_ctrlperfesq_hp4 = Me.txtctrlperfesq_hp4.Text
            HCP4.p_corrperfesq_hp4 = Me.txtcorrperfesq_hp4.Text
            HCP4.p_corrfrente_hp4 = Me.txtcorrfrente_hp4.Text
            HCP4.p_lograroverjet_hp4 = Me.txtlograroverjet_hp4.Text
            HCP4.p_lograrmolarcan_hp4 = Me.txtlograrmolarcan_hp4.Text
            HCP4.p_lograrbuenaocl_hp4 = Me.txtlograrbuenaocl_hp4.Text
            HCP4.p_plan1_hp4 = Me.txtplan1_hp4.Text
            HCP4.p_plan2_hp4 = Me.txtplan2_hp4.Text
            HCP4.p_plan3_hp4 = Me.txtplan3_hp4.Text

            HCP4.p_tratamortognatico_hp4 = ""

            If Me.rbTrataSi.Checked = True Then
                HCP4.p_tratamortognatico_hp4 = "1"
            Else
                HCP4.p_tratamortognatico_hp4 = "0"
            End If

            HCP4.p_reqtratam_hp4 = Me.txtreqtratam_hp4.Text
            HCP4.p_cuantas_hp4 = Me.txtcuantas_hp4.Text
            HCP4.p_tratamientodef_hp4 = Me.texttratamientodef_hp4.Text
            HCP4.p_limitacaso_hp4 = Me.textlimitacaso_hp4.Text

            If contar > 0 Then
                HCP4.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HCP4.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HCP4.dispose()
            HCP4 = Nothing


            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 15 '15 Modificar Historia Clinica Paciente
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcorto")
            EVEN = Nothing

            MsgBox("Historia Clinica Registrada con Exito", MsgBoxStyle.OkOnly, "H.C. Ortodoncia")

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnOdontograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdontograma.Click

        frmOdontogramaGrafico.Show()
        frmOdontogramaGrafico.Activate()

    End Sub

    Private Sub TabControl_pac_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControl_pac.SelectedTabChanged

        Try

            If Not (CStr(My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag) = "") Then


                If TabControl_pac.SelectedTabIndex = 5 Then

                    contar = 0
                    contar = CLASE_GENERAL.contar2("IdUsuario", "ograma", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                    If contar > 0 Then

                        Me.btnImprimirHClinica.Enabled = True

                    Else

                        Me.btnImprimirHClinica.Enabled = False
                        MsgBox("Debe crear un odontograma para este Paciente para imprimir la Historia Clinica.", MsgBoxStyle.OkOnly, "Buscar Pacientes")

                    End If

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub frmHistoriaClinicaOrtodoncia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "RichTxtNotas_pac" Or ActiveControl.Name.ToString = "texttratamientodef_hp4" Or ActiveControl.Name.ToString = "textlimitacaso_hp4") Then

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

                HC = New CLASE_HCLINICA
                HC.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                HC.p_IdTusuario = 1 'Es un paciente
                HC.Seleccionar("impresion")

                Dim orptHistoriaClinica As New rptHistoriaClinica
                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptHistoriaClinica.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptHistoriaClinica

                'Cargamos los CONTACTOS

                CON = New CLASE_CONTACTOS
                CON.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                '******************************** CARGAMOS LOS CONTACTOS DEL PACIENTE ***********************************

                contar = 0
                contar = CLASE_GENERAL.contarcontactostodos(My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, 1, CLASE_GENERAL.mensaje_error)

                If contar > 1 Then


                    CON.p_IdTUsuario = 1 ' Lo Utilizamos porque es un paciente
                    CON.Seleccionar("xdt2")

                    Dim i As Integer

                    For i = 0 To CLASE_GENERAL.xdt2.Rows.Count - 1

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 5 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("teloficina_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelOficina_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelOficina_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("teloficina_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("fax_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtFax_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtFax_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("fax_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelular_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelular_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtemail_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtemail_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("email_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("web_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtweb_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtweb_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("web_con") & "'"
                            End If

                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 1 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") & "'"
                            End If

                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 2 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtMadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtMadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelMadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelMadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelMadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelMadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuMadre_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuMadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") & "'"
                            End If


                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 3 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtAcudiente_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtAcudiente_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelAcudiente_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelAcudiente_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelAcudiente_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelAcudiente_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuAcudiente_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuAcudiente_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") & "'"
                            End If


                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 4 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtConyuge_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtConyuge_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelConyuge_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtTelConyuge_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelConyuge_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtCelConyuge_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") Is DBNull.Value Then
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuConyuge_pac").Text = "''"
                            Else
                                orptHistoriaClinica.DataDefinition.FormulaFields.Item("txtOcuConyuge_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("ocu_con") & "'"
                            End If

                        End If

                    Next

                    CLASE_GENERAL.xdt2.Clear()
                    CLASE_GENERAL.xdt2 = Nothing

                End If

                CON.dispose()
                CON = Nothing

                '--------- FINALIZA CONTACTOS

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                HC.dispose()
                HC = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea un nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "H.C. Ortodoncia")

            If respuesta = MsgBoxResult.Yes Then

                'CLASE_GENERAL.cargar_combo("pacientes", Me.cmbEntidad, CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcorto")
                EVEN.bloquaerdesbloquear("nuevahcorto")

                Me.btnOdontograma.Enabled = False
                Me.btnImprimirHClinica.Enabled = False

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

End Class