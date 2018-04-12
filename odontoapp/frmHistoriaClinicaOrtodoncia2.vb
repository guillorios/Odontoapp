Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Math

Public Class frmHistoriaClinicaOrtodoncia2

    'Creamos las Clases
    Private PAC As CLASE_PACIENTES
    Private EVEN As CLASE_EVENTOS
    Private CTRL As CLASE_CONTROL
    Private GENE As CLASE_GENERAL
    Private CON As CLASE_CONTACTOS

    'Clases para la Historia Clinica
    Private HCORTO2 As CLASE_HCLINICA_ORTO2

    'Variables
    Private contar As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea Guardar el registro antes de salir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "H.C. Ortodoncia 2")

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

        'Paneles y grupos
        ubicarcontrol(Me.lblTituloAnamnesis1)
        ubicarcontrol(Me.gpAnamnesis)
        ubicarcontrol(Me.lblTituloAnamnesis2)
        ubicarcontrol(Me.gpAnamnesis2)
        ubicarcontrol(Me.lblTituloExamenFacial)
        ubicarcontrol(Me.gpExamneFacial)
        ubicarcontrol(Me.lblTituloExamenOral)
        ubicarcontrol(Me.gpExamenOral)
        ubicarcontrol(Me.lblTituloOdontograma)
        ubicarcontrol(Me.gpOdontograma)
        ubicarcontrol(Me.lblTituloExamenEsqueletico)
        ubicarcontrol(Me.gpExamenEsqueletico)
        ubicarcontrol(Me.lblTituloRegistrosDiagnosticos)
        ubicarcontrol(Me.gpRegistrosDiagnosticos)
        ubicarcontrol(Me.lblTituloDiagnosticos)
        ubicarcontrol(Me.gpDiagnosticos)
        ubicarcontrol(Me.lblTituloPlanTratamiento)
        ubicarcontrol(Me.gpPlanTratamiento)

        'Botones
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnImprimirHClinica)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnSalir)

    End Sub


    Private Sub frmHistoriaClinicaOrtodoncia2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '**************************** MODULO INGRESO DE LA HISTORIA CLINICA **************************

            '***** Historia Clinica Ortodoncia 2

            HCORTO2 = New CLASE_HCLINICA_ORTO2

            HCORTO2.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCORTO2.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            HCORTO2.p_enfermedadanterior_horto2 = Me.txtenfermedadanterior_horto2.Text
            HCORTO2.p_tratamedico_horto2 = Me.txttratamedico_horto2.Text

            If ckefebriles_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckdiarrea_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckfatiga_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckpeso_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckinfecciones_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If cksudoracion_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckTinmuno_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckTanti_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckPvalcard_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhEB_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhcomuq_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhmalcard_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhfiebrereu_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckdiabetes_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckharterial_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckpenicilina_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckanestecia_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckotros_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckembarazo_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            HCORTO2.p_alergiasotros_horto2 = Me.txtalergiasotros_horto2.Text
            HCORTO2.p_cresimientodesarrollo_horto2 = Me.txtcresimientodesarrollo_horto2.Text
            HCORTO2.p_antecedentes_horto2 = Me.txtantecedentes_horto2.Text

            HCORTO2.p_efacial_frente_horto2 = Me.txtefacial_frente_horto2.Text
            HCORTO2.p_efacial_labios_horto2 = Me.txtefacial_labios_horto2.Text
            HCORTO2.p_Efacial_lineasonr_horto2 = Me.txtefacial_lineasonr_horto2.Text
            HCORTO2.p_efacial_selladolabial_horto2 = Me.txtefacial_selladolabial_horto2.Text
            HCORTO2.p_efacial_perfil_horto2 = Me.txtefacial_perfil_horto2.Text
            HCORTO2.p_efacial_menton_horto2 = Me.txtefacial_menton_horto2.Text
            HCORTO2.p_efacial_angulonaso_horto2 = Me.txtefacial_angulonaso_horto2.Text
            HCORTO2.p_efacial_surcolabio_horto2 = Me.txtefacial_surcolabio_horto2.Text
            HCORTO2.p_efacial_otros_horto2 = Me.txtefacial_otros_horto2.Text

            HCORTO2.p_eoral_tejidosblandos_horto2 = Me.txteoral_tejidosblandos_horto2.Text
            HCORTO2.p_eoral_rehabilitacion_horto2 = Me.txteoral_rehabilitacion_horto2.Text
            HCORTO2.p_eoral_endodoncia_horto2 = Me.txteoral_endodoncia_horto2.Text
            HCORTO2.p_eoral_periodoncia_horto2 = Me.txteoral_periodoncia_horto2.Text
            HCORTO2.p_eoral_dientesausentes_horto2 = Me.txteoral_dientesausentes_horto2.Text
            HCORTO2.p_eoral_dientesincluidos_horto2 = Me.txteoral_dientesincluidos_horto2.Text

            If chkdenticion.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            If chktemporal.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            If chkmixta.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            If chkpermanente.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            HCORTO2.p_eoral_apinamiento_horto2 = Me.txteoral_apinamiento_horto2.Text
            HCORTO2.p_eoral_diastemas_horto2 = Me.txteoral_diastemas_horto2.Text
            HCORTO2.p_eoral_overjet_horto2 = Me.txteoral_overjet_horto2.Text
            HCORTO2.p_eoral_overbite_horto2 = Me.txteoral_overbite_horto2.Text
            HCORTO2.p_eoral_lineamedia_horto2 = Me.txteoral_lineamedia_horto2.Text
            HCORTO2.p_eoral_tamdentario_horto2 = Me.txteoral_tamdentario_horto2.Text
            HCORTO2.p_eoral_formaarcada_horto2 = Me.txteoral_formaarcada_horto2.Text
            HCORTO2.p_eoral_mordidacruzada_horto2 = Me.txteoral_mordidacruzada_horto2.Text
            HCORTO2.p_eoral_curvaspee_horto2 = Me.txteoral_curvaspee_horto2.Text
            HCORTO2.p_eoral_claseangle_horto2 = Me.txteoral_claseangle_horto2.Text
            HCORTO2.p_eoral_bolton_horto2 = Me.txteoral_bolton_horto2.Text
            HCORTO2.p_eoral_habitos_horto2 = Me.txteoral_habitos_horto2.Text
            HCORTO2.p_eoral_atm_horto2 = Me.txteoral_atm_horto2.Text
            HCORTO2.p_eoral_manipulacion_horto2 = Me.txteoral_manipulacion_horto2.Text
            HCORTO2.p_eoral_otros_horto2 = Me.txteoral_otros_horto2.Text

            HCORTO2.p_odonto_analisisespacio_horto2 = Me.txtodonto_analisisespacio_horto2.Text

            HCORTO2.p_eesque_sna_inicial_horto2 = Me.txteesque_sna_inicial_horto2.Text
            HCORTO2.p_eesque_sna_control_horto2 = Me.txteesque_sna_control_horto2.Text
            HCORTO2.p_eesque_sna_final_horto2 = Me.txteesque_sna_final_horto2.Text
            HCORTO2.p_eesque_snb_inicial_horto2 = Me.txteesque_snb_inicial_horto2.Text
            HCORTO2.p_eesque_snb_control_horto2 = Me.txteesque_snb_control_horto2.Text
            HCORTO2.p_eesque_snb_final_horto2 = Me.txteesque_snb_final_horto2.Text
            HCORTO2.p_eesque_anb_inicial_horto2 = Me.txteesque_anb_inicial_horto2.Text
            HCORTO2.p_eesque_anb_control_horto2 = Me.txteesque_anb_control_horto2.Text
            HCORTO2.p_eesque_anb_final_horto2 = Me.txteesque_anb_final_horto2.Text
            HCORTO2.p_eesque_1pp_inicial_horto2 = Me.txteesque_1pp_inicial_horto2.Text
            HCORTO2.p_eesque_1pp_control_horto2 = Me.txteesque_1pp_control_horto2.Text
            HCORTO2.p_eesque_1pp_final_horto2 = Me.txteesque_1pp_final_horto2.Text
            HCORTO2.p_eesque_1pm_inicial_horto2 = Me.txteesque_1pm_inicial_horto2.Text
            HCORTO2.p_eesque_1pm_control_horto2 = Me.txteesque_1pm_control_horto2.Text
            HCORTO2.p_eesque_1pm_final_horto2 = Me.txteesque_1pm_final_horto2.Text
            HCORTO2.p_eesque_go_inicial_horto2 = Me.txteesque_go_inicial_horto2.Text
            HCORTO2.p_eesque_go_control_horto2 = Me.txteesque_go_control_horto2.Text
            HCORTO2.p_eesque_go_final_horto2 = Me.txteesque_go_final_horto2.Text
            HCORTO2.p_eesque_max_inicial_horto2 = Me.txteesque_max_inicial_horto2.Text
            HCORTO2.p_eesque_max_control_horto2 = Me.txteesque_max_control_horto2.Text
            HCORTO2.p_eesque_max_final_horto2 = Me.txteesque_max_final_horto2.Text
            HCORTO2.p_eesque_otros_inicial_horto2 = Me.txteesque_otros_inicial_horto2.Text
            HCORTO2.p_eesque_otros_control_horto2 = Me.txteesque_otros_control_horto2.Text
            HCORTO2.p_eesque_otros_final_horto2 = Me.txteesque_otros_final_horto2.Text

            HCORTO2.p_reg_modelos_inicial_horto2 = Me.txtreg_modelos_inicial_horto2.Text
            HCORTO2.p_reg_modelos_control_horto2 = Me.txtreg_modelos_control_horto2.Text
            HCORTO2.p_reg_modelos_final_horto2 = Me.txtreg_modelos_final_horto2.Text

            HCORTO2.p_reg_pano_inicial_horto2 = Me.txtreg_pano_inicial_horto2.Text
            HCORTO2.p_reg_pano_control_horto2 = Me.txtreg_pano_control_horto2.Text
            HCORTO2.p_reg_pano_final_horto2 = Me.txtreg_pano_final_horto2.Text

            HCORTO2.p_reg_perfil_inicial_horto2 = Me.txtreg_perfil_inicial_horto2.Text
            HCORTO2.p_reg_perfil_control_horto2 = Me.txtreg_perfil_control_horto2.Text
            HCORTO2.p_reg_perfil_final_horto2 = Me.txtreg_perfil_final_horto2.Text

            HCORTO2.p_reg_intra_inicial_horto2 = Me.txtreg_intra_inicial_horto2.Text
            HCORTO2.p_reg_intra_control_horto2 = Me.txtreg_intra_control_horto2.Text
            HCORTO2.p_reg_intra_final_horto2 = Me.txtreg_intra_final_horto2.Text

            HCORTO2.p_reg_extra_inicial_horto2 = Me.txtreg_extra_inicial_horto2.Text
            HCORTO2.p_reg_extra_control_horto2 = Me.txtreg_extra_control_horto2.Text
            HCORTO2.p_reg_extra_final_horto2 = Me.txtreg_extra_final_horto2.Text

            HCORTO2.p_reg_otras_inicial_horto2 = Me.txtreg_otras_inicial_horto2.Text
            HCORTO2.p_reg_otras_control_horto2 = Me.txtreg_otras_control_horto2.Text
            HCORTO2.p_reg_otras_final_horto2 = Me.txtreg_otras_final_horto2.Text

            HCORTO2.p_diag_facial_horto2 = Me.txtdiag_facial_horto2.Text
            HCORTO2.p_diag_esque_horto2 = Me.txtdiag_esque_horto2.Text
            HCORTO2.p_diag_dental_horto2 = Me.txtdiag_dental_horto2.Text

            HCORTO2.p_plantratamiento_horto2 = Me.txtplantratamiento_horto2.Text

            HCORTO2.p_alternativas_horto2 = Me.txtalternativas_horto2.Text

            HCORTO2.Insertar(CLASE_GENERAL.mensaje_error)
            HCORTO2.dispose()
            HCORTO2 = Nothing

            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 14 '4 Crear Historia Clinica
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcorto2")
            EVEN = Nothing

            MsgBox("Historia Clinica registrada con exito.", MsgBoxStyle.OkOnly, "H.C. Ortodoncia 2")

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub frmHistoriaClinicaOrtodoncia2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EVEN = New CLASE_EVENTOS
        EVEN.bloquaerdesbloquear("nuevarhcorto2")
        EVEN = Nothing


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        Try

            '**************************** MODULO INGRESO DE LA HISTORIA CLINICA **************************

            '***** Historia Clinica Ortodoncia 2

            'Controlamos que exista un registro de la historia clinica para modificarlo
            'si no existe creamos un nuevo registro al insertarlo en la base de datos
            contar = 0
            contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica_orto2", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)


            HCORTO2 = New CLASE_HCLINICA_ORTO2

            HCORTO2.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCORTO2.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            HCORTO2.p_enfermedadanterior_horto2 = Me.txtenfermedadanterior_horto2.Text
            HCORTO2.p_tratamedico_horto2 = Me.txttratamedico_horto2.Text

            If ckefebriles_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckdiarrea_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckfatiga_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckpeso_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckinfecciones_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If cksudoracion_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckTinmuno_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckTanti_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckPvalcard_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhEB_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhcomuq_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhmalcard_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckhfiebrereu_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckdiabetes_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckharterial_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckpenicilina_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckanestecia_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckotros_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            If ckembarazo_si.Checked = True Then
                HCORTO2.p_patologias_horto2 &= "1"
            Else
                HCORTO2.p_patologias_horto2 &= "0"
            End If

            HCORTO2.p_alergiasotros_horto2 = Me.txtalergiasotros_horto2.Text
            HCORTO2.p_cresimientodesarrollo_horto2 = Me.txtcresimientodesarrollo_horto2.Text
            HCORTO2.p_antecedentes_horto2 = Me.txtantecedentes_horto2.Text

            HCORTO2.p_efacial_frente_horto2 = Me.txtefacial_frente_horto2.Text
            HCORTO2.p_efacial_labios_horto2 = Me.txtefacial_labios_horto2.Text
            HCORTO2.p_Efacial_lineasonr_horto2 = Me.txtefacial_lineasonr_horto2.Text
            HCORTO2.p_efacial_selladolabial_horto2 = Me.txtefacial_selladolabial_horto2.Text
            HCORTO2.p_efacial_perfil_horto2 = Me.txtefacial_perfil_horto2.Text
            HCORTO2.p_efacial_menton_horto2 = Me.txtefacial_menton_horto2.Text
            HCORTO2.p_efacial_angulonaso_horto2 = Me.txtefacial_angulonaso_horto2.Text
            HCORTO2.p_efacial_surcolabio_horto2 = Me.txtefacial_surcolabio_horto2.Text
            HCORTO2.p_efacial_otros_horto2 = Me.txtefacial_otros_horto2.Text

            HCORTO2.p_eoral_tejidosblandos_horto2 = Me.txteoral_tejidosblandos_horto2.Text
            HCORTO2.p_eoral_rehabilitacion_horto2 = Me.txteoral_rehabilitacion_horto2.Text
            HCORTO2.p_eoral_endodoncia_horto2 = Me.txteoral_endodoncia_horto2.Text
            HCORTO2.p_eoral_periodoncia_horto2 = Me.txteoral_periodoncia_horto2.Text
            HCORTO2.p_eoral_dientesausentes_horto2 = Me.txteoral_dientesausentes_horto2.Text
            HCORTO2.p_eoral_dientesincluidos_horto2 = Me.txteoral_dientesincluidos_horto2.Text

            If chkdenticion.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            If chktemporal.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            If chkmixta.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            If chkpermanente.Checked = True Then
                HCORTO2.p_eoral_examendental_horto2 &= "1"
            Else
                HCORTO2.p_eoral_examendental_horto2 &= "0"
            End If

            HCORTO2.p_eoral_apinamiento_horto2 = Me.txteoral_apinamiento_horto2.Text
            HCORTO2.p_eoral_diastemas_horto2 = Me.txteoral_diastemas_horto2.Text
            HCORTO2.p_eoral_overjet_horto2 = Me.txteoral_overjet_horto2.Text
            HCORTO2.p_eoral_overbite_horto2 = Me.txteoral_overbite_horto2.Text
            HCORTO2.p_eoral_lineamedia_horto2 = Me.txteoral_lineamedia_horto2.Text
            HCORTO2.p_eoral_tamdentario_horto2 = Me.txteoral_tamdentario_horto2.Text
            HCORTO2.p_eoral_formaarcada_horto2 = Me.txteoral_formaarcada_horto2.Text
            HCORTO2.p_eoral_mordidacruzada_horto2 = Me.txteoral_mordidacruzada_horto2.Text
            HCORTO2.p_eoral_curvaspee_horto2 = Me.txteoral_curvaspee_horto2.Text
            HCORTO2.p_eoral_claseangle_horto2 = Me.txteoral_claseangle_horto2.Text
            HCORTO2.p_eoral_bolton_horto2 = Me.txteoral_bolton_horto2.Text
            HCORTO2.p_eoral_habitos_horto2 = Me.txteoral_habitos_horto2.Text
            HCORTO2.p_eoral_atm_horto2 = Me.txteoral_atm_horto2.Text
            HCORTO2.p_eoral_manipulacion_horto2 = Me.txteoral_manipulacion_horto2.Text
            HCORTO2.p_eoral_otros_horto2 = Me.txteoral_otros_horto2.Text

            HCORTO2.p_odonto_analisisespacio_horto2 = Me.txtodonto_analisisespacio_horto2.Text

            HCORTO2.p_eesque_sna_inicial_horto2 = Me.txteesque_sna_inicial_horto2.Text
            HCORTO2.p_eesque_sna_control_horto2 = Me.txteesque_sna_control_horto2.Text
            HCORTO2.p_eesque_sna_final_horto2 = Me.txteesque_sna_final_horto2.Text
            HCORTO2.p_eesque_snb_inicial_horto2 = Me.txteesque_snb_inicial_horto2.Text
            HCORTO2.p_eesque_snb_control_horto2 = Me.txteesque_snb_control_horto2.Text
            HCORTO2.p_eesque_snb_final_horto2 = Me.txteesque_snb_final_horto2.Text
            HCORTO2.p_eesque_anb_inicial_horto2 = Me.txteesque_anb_inicial_horto2.Text
            HCORTO2.p_eesque_anb_control_horto2 = Me.txteesque_anb_control_horto2.Text
            HCORTO2.p_eesque_anb_final_horto2 = Me.txteesque_anb_final_horto2.Text
            HCORTO2.p_eesque_1pp_inicial_horto2 = Me.txteesque_1pp_inicial_horto2.Text
            HCORTO2.p_eesque_1pp_control_horto2 = Me.txteesque_1pp_control_horto2.Text
            HCORTO2.p_eesque_1pp_final_horto2 = Me.txteesque_1pp_final_horto2.Text
            HCORTO2.p_eesque_1pm_inicial_horto2 = Me.txteesque_1pm_inicial_horto2.Text
            HCORTO2.p_eesque_1pm_control_horto2 = Me.txteesque_1pm_control_horto2.Text
            HCORTO2.p_eesque_1pm_final_horto2 = Me.txteesque_1pm_final_horto2.Text
            HCORTO2.p_eesque_go_inicial_horto2 = Me.txteesque_go_inicial_horto2.Text
            HCORTO2.p_eesque_go_control_horto2 = Me.txteesque_go_control_horto2.Text
            HCORTO2.p_eesque_go_final_horto2 = Me.txteesque_go_final_horto2.Text
            HCORTO2.p_eesque_max_inicial_horto2 = Me.txteesque_max_inicial_horto2.Text
            HCORTO2.p_eesque_max_control_horto2 = Me.txteesque_max_control_horto2.Text
            HCORTO2.p_eesque_max_final_horto2 = Me.txteesque_max_final_horto2.Text
            HCORTO2.p_eesque_otros_inicial_horto2 = Me.txteesque_otros_inicial_horto2.Text
            HCORTO2.p_eesque_otros_control_horto2 = Me.txteesque_otros_control_horto2.Text
            HCORTO2.p_eesque_otros_final_horto2 = Me.txteesque_otros_final_horto2.Text

            HCORTO2.p_reg_modelos_inicial_horto2 = Me.txtreg_modelos_inicial_horto2.Text
            HCORTO2.p_reg_modelos_control_horto2 = Me.txtreg_modelos_control_horto2.Text
            HCORTO2.p_reg_modelos_final_horto2 = Me.txtreg_modelos_final_horto2.Text

            HCORTO2.p_reg_pano_inicial_horto2 = Me.txtreg_pano_inicial_horto2.Text
            HCORTO2.p_reg_pano_control_horto2 = Me.txtreg_pano_control_horto2.Text
            HCORTO2.p_reg_pano_final_horto2 = Me.txtreg_pano_final_horto2.Text

            HCORTO2.p_reg_perfil_inicial_horto2 = Me.txtreg_perfil_inicial_horto2.Text
            HCORTO2.p_reg_perfil_control_horto2 = Me.txtreg_perfil_control_horto2.Text
            HCORTO2.p_reg_perfil_final_horto2 = Me.txtreg_perfil_final_horto2.Text

            HCORTO2.p_reg_intra_inicial_horto2 = Me.txtreg_intra_inicial_horto2.Text
            HCORTO2.p_reg_intra_control_horto2 = Me.txtreg_intra_control_horto2.Text
            HCORTO2.p_reg_intra_final_horto2 = Me.txtreg_intra_final_horto2.Text

            HCORTO2.p_reg_extra_inicial_horto2 = Me.txtreg_extra_inicial_horto2.Text
            HCORTO2.p_reg_extra_control_horto2 = Me.txtreg_extra_control_horto2.Text
            HCORTO2.p_reg_extra_final_horto2 = Me.txtreg_extra_final_horto2.Text

            HCORTO2.p_reg_otras_inicial_horto2 = Me.txtreg_otras_inicial_horto2.Text
            HCORTO2.p_reg_otras_control_horto2 = Me.txtreg_otras_control_horto2.Text
            HCORTO2.p_reg_otras_final_horto2 = Me.txtreg_otras_final_horto2.Text

            HCORTO2.p_diag_facial_horto2 = Me.txtdiag_facial_horto2.Text
            HCORTO2.p_diag_esque_horto2 = Me.txtdiag_esque_horto2.Text
            HCORTO2.p_diag_dental_horto2 = Me.txtdiag_dental_horto2.Text

            HCORTO2.p_plantratamiento_horto2 = Me.txtplantratamiento_horto2.Text

            HCORTO2.p_alternativas_horto2 = Me.txtalternativas_horto2.Text

            If contar > 0 Then
                HCORTO2.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HCORTO2.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HCORTO2.dispose()
            HCORTO2 = Nothing

            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 15 '15 Modificar Historia Clinica
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcorto2")
            EVEN = Nothing

            MsgBox("Historia Clinica modificada con exito.", MsgBoxStyle.OkOnly, "H.C. Ortodoncia 2")

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

            respuesta = MsgBox("Desea un nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "H.C. Ortodoncia 2")

            If respuesta = MsgBoxResult.Yes Then

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcorto2")
                EVEN.bloquaerdesbloquear("nuevahcorto2")

                Me.btnOdontograma.Enabled = False
                Me.btnImprimirHClinica.Enabled = False

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

   
    Private Sub TabHCOrto2_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabHCOrto2.SelectedTabChanged

        Try

            If TabHCOrto2.SelectedTabIndex = 4 Then

                contar = 0
                contar = CLASE_GENERAL.contar2("IdUsuario", "ograma", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    Me.btnImprimirHClinica.Enabled = True

                Else

                    Me.btnImprimirHClinica.Enabled = False
                    MsgBox("Debe crear un odontograma para este Paciente para imprimir la Historia Clinica.", MsgBoxStyle.OkOnly, "H.C. Ortodoncia 2")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnImprimirHClinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirHClinica.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Documento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Histroria Clinica")

            If respuesta = 6 Then

                'Cargamos el Infomre con datos de la base de datos
                HCORTO2 = New CLASE_HCLINICA_ORTO2
                HCORTO2.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                HCORTO2.p_IdTUsuario = 1 'Es un paciente
                HCORTO2.Seleccionar("impresion")

                'Creamos Objetos para generar el informe
                Dim orptHistoriaClinicaOrto2 As New rptHistoriaClinicaOrto2
                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptHistoriaClinicaOrto2.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptHistoriaClinicaOrto2

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
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("teloficina_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtTelOficina_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtTelOficina_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("teloficina_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtCelular_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtCelular_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("cel_con") & "'"
                            End If

                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 3 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtAcudiente_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto2.DataDefinition.FormulaFields.Item("txtAcudiente_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If


                        End If

                    Next

                    CLASE_GENERAL.xdt2.Clear()
                    CLASE_GENERAL.xdt2 = Nothing

                End If

                CON.dispose()
                CON = Nothing

                '----

                ' Cargamos el Infome desde su contro y modificamos algunas opciones
                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                HCORTO2.dispose()
                HCORTO2 = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub frmHistoriaClinicaOrtodoncia2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "txtodonto_analisisespacio_horto2" Or ActiveControl.Name.ToString = "txtplantratamiento_horto2" Or ActiveControl.Name.ToString = "txtalternativas_horto2") Then

            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                e.Handled = True
                SendKeys.Send(Convert.ToChar(Keys.Tab))
            End If

        End If

    End Sub

  
End Class
