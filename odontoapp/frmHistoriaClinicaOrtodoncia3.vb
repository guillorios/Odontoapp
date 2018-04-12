Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Math

Public Class frmHistoriaClinicaOrtodoncia3

    'Creamos las Clases
    Private PAC As CLASE_PACIENTES
    Private EVEN As CLASE_EVENTOS
    Private CTRL As CLASE_CONTROL
    Private GENE As CLASE_GENERAL
    Private CON As CLASE_CONTACTOS

    'Clases para la Historia Clinica
    Private HCORTO3 As CLASE_HCLINICA_ORTO3

    'Variables
    Private contar As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea Guardar el registro antes de salir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "H.C. Ortodoncia 3")

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
        ubicarcontrol(Me.lblTituloInfoOrtodoncia)
        ubicarcontrol(Me.gpInfoOrtodoncia)
        ubicarcontrol(Me.lblTituloInfoMedica)
        ubicarcontrol(Me.gpInfoMedica)
        ubicarcontrol(Me.lblTituloOdontograma)
        ubicarcontrol(Me.btnOdontograma)
        ubicarcontrol(Me.gpAnalisisEncefalo)
        ubicarcontrol(Me.lblTituloAnalisisEncefalo)
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

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '**************************** MODULO INGRESO DE LA HISTORIA CLINICA **************************

            '***** Historia Clinica Ortodoncia 3

            HCORTO3 = New CLASE_HCLINICA_ORTO3

            HCORTO3.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCORTO3.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            HCORTO3.p_mconsulta_horto3 = Me.txtmconsulta_horto3.Text

            If ckconciente_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckproblemadental_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckfatiga_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckdeporte_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckinstrumento_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckrevision_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckSedadental_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckpadeceenfermedad_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckmedicamento_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckalergias_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckinfgarganta_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckamigdalas_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckadenoides_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckcirugia_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            HCORTO3.p_parentezco_horto3 = Me.txtparentezco_horto3.Text

            If chkChuparsededos.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkMorderseunas.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkMorderselabios.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkRespirarboca.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkRechinarDientes.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            HCORTO3.p_cepillarseveces_horto3 = Me.txtcepillarseveces_horto3.Text

            If chkExcesiva.Checked = True Then
                HCORTO3.p_azucares_horto3 &= "1"
            Else
                HCORTO3.p_azucares_horto3 &= "0"
            End If

            If chkRegular.Checked = True Then
                HCORTO3.p_azucares_horto3 &= "1"
            Else
                HCORTO3.p_azucares_horto3 &= "0"
            End If

            If chkBaja.Checked = True Then
                HCORTO3.p_azucares_horto3 &= "1"
            Else
                HCORTO3.p_azucares_horto3 &= "0"
            End If

            HCORTO3.p_observaciones_horto3 = Me.txtobservaciones_horto3.Text

            HCORTO3.p_enfermedadactual_horto3 = Me.txtenfermedadactual_horto3.Text
            HCORTO3.p_medicamento_horto3 = Me.txtmedicamento_horto3.Text

            If chkDesordenes.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkSangrado.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkAnomaliasCong.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkFiebreReum.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkEConvulsivas.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkObstruccionNasal.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkAccidentescara.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            HCORTO3.p_cuandoafecciones_horto3 = Me.txtcuandoafecciones_horto3.Text

            HCORTO3.p_alergiasaque_horto3 = Me.txtalergiasaque_horto3.Text
            HCORTO3.p_cuandoamigdalas_horto3 = Me.txtcuandoamigdalas_horto3.Text
            HCORTO3.p_cuandoadenoides_horto3 = Me.txtcuandoadenoides_horto3.Text
            HCORTO3.p_cualcirugia_horto3 = Me.txtcualcirugia_horto3.Text

            HCORTO3.p_sna_horto3 = Me.txtsna_horto3.Text
            HCORTO3.p_snb_horto3 = Me.txtsnb_horto3.Text
            HCORTO3.p_anb_horto3 = Me.txtanb_horto3.Text
            HCORTO3.p_ipp_horto3 = Me.txtipp_horto3.Text
            HCORTO3.p_ina_horto3 = Me.txtina_horto3.Text
            HCORTO3.p_ipm_horto3 = Me.txtipm_horto3.Text
            HCORTO3.p_inb_horto3 = Me.txtinb_horto3.Text
            HCORTO3.p_les_horto3 = Me.txtles_horto3.Text
            HCORTO3.p_lei_horto3 = Me.txtlei_horto3.Text
            HCORTO3.p_go_horto3 = Me.txtgo_horto3.Text

            HCORTO3.p_observacionesaencef_horto3 = Me.txtobservacionesaencef_horto3.Text

            HCORTO3.p_diag_facial_horto3 = Me.txtdiag_facial_horto3.Text
            HCORTO3.p_diag_esque_horto3 = Me.txtdiag_esque_horto3.Text
            HCORTO3.p_diag_dental_horto3 = Me.txtdiag_dental_horto3.Text
            HCORTO3.p_diag_periodontal_horto3 = Me.txtdiag_periodontal_horto3.Text

            HCORTO3.p_plantratamiento_horto3 = Me.txtplantratamiento_horto3.Text
            HCORTO3.p_alternativas_horto3 = Me.txtalternativas_horto3.Text

            HCORTO3.Insertar(CLASE_GENERAL.mensaje_error)
            HCORTO3.dispose()
            HCORTO3 = Nothing

            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 14 '4 Crear Historia Clinica
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcorto3")
            EVEN = Nothing

            MsgBox("Historia Clinica registrada con exito.", MsgBoxStyle.OkOnly, "H.C. Ortodoncia 3")

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            '**************************** MODULO INGRESO DE LA HISTORIA CLINICA **************************

            '***** Historia Clinica Ortodoncia 3

            'Controlamos que exista un registro de la historia clinica para modificarlo
            'si no existe creamos un nuevo registro al insertarlo en la base de datos
            contar = 0
            contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica_orto3", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

            HCORTO3 = New CLASE_HCLINICA_ORTO3

            HCORTO3.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            HCORTO3.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 

            HCORTO3.p_mconsulta_horto3 = Me.txtmconsulta_horto3.Text

            If ckconciente_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckproblemadental_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckfatiga_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckdeporte_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckinstrumento_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckrevision_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckSedadental_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckpadeceenfermedad_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckmedicamento_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckalergias_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckinfgarganta_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckamigdalas_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckadenoides_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            If ckcirugia_si.Checked = True Then
                HCORTO3.p_opciones_horto3 &= "1"
            Else
                HCORTO3.p_opciones_horto3 &= "0"
            End If

            HCORTO3.p_parentezco_horto3 = Me.txtparentezco_horto3.Text

            If chkChuparsededos.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkMorderseunas.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkMorderselabios.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkRespirarboca.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            If chkRechinarDientes.Checked = True Then
                HCORTO3.p_habitos_horto3 &= "1"
            Else
                HCORTO3.p_habitos_horto3 &= "0"
            End If

            HCORTO3.p_cepillarseveces_horto3 = Me.txtcepillarseveces_horto3.Text

            If chkExcesiva.Checked = True Then
                HCORTO3.p_azucares_horto3 &= "1"
            Else
                HCORTO3.p_azucares_horto3 &= "0"
            End If

            If chkRegular.Checked = True Then
                HCORTO3.p_azucares_horto3 &= "1"
            Else
                HCORTO3.p_azucares_horto3 &= "0"
            End If

            If chkBaja.Checked = True Then
                HCORTO3.p_azucares_horto3 &= "1"
            Else
                HCORTO3.p_azucares_horto3 &= "0"
            End If

            HCORTO3.p_observaciones_horto3 = Me.txtobservaciones_horto3.Text

            HCORTO3.p_enfermedadactual_horto3 = Me.txtenfermedadactual_horto3.Text
            HCORTO3.p_medicamento_horto3 = Me.txtmedicamento_horto3.Text

            If chkDesordenes.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkSangrado.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkAnomaliasCong.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkFiebreReum.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkEConvulsivas.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkObstruccionNasal.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            If chkAccidentescara.Checked = True Then
                HCORTO3.p_afecciones_horto3 &= "1"
            Else
                HCORTO3.p_afecciones_horto3 &= "0"
            End If

            HCORTO3.p_cuandoafecciones_horto3 = Me.txtcuandoafecciones_horto3.Text

            HCORTO3.p_alergiasaque_horto3 = Me.txtalergiasaque_horto3.Text
            HCORTO3.p_cuandoamigdalas_horto3 = Me.txtcuandoamigdalas_horto3.Text
            HCORTO3.p_cuandoadenoides_horto3 = Me.txtcuandoadenoides_horto3.Text
            HCORTO3.p_cualcirugia_horto3 = Me.txtcualcirugia_horto3.Text

            HCORTO3.p_sna_horto3 = Me.txtsna_horto3.Text
            HCORTO3.p_snb_horto3 = Me.txtsnb_horto3.Text
            HCORTO3.p_anb_horto3 = Me.txtanb_horto3.Text
            HCORTO3.p_ipp_horto3 = Me.txtipp_horto3.Text
            HCORTO3.p_ina_horto3 = Me.txtina_horto3.Text
            HCORTO3.p_ipm_horto3 = Me.txtipm_horto3.Text
            HCORTO3.p_inb_horto3 = Me.txtinb_horto3.Text
            HCORTO3.p_les_horto3 = Me.txtles_horto3.Text
            HCORTO3.p_lei_horto3 = Me.txtlei_horto3.Text
            HCORTO3.p_go_horto3 = Me.txtgo_horto3.Text

            HCORTO3.p_observacionesaencef_horto3 = Me.txtobservacionesaencef_horto3.Text

            HCORTO3.p_diag_facial_horto3 = Me.txtdiag_facial_horto3.Text
            HCORTO3.p_diag_esque_horto3 = Me.txtdiag_esque_horto3.Text
            HCORTO3.p_diag_dental_horto3 = Me.txtdiag_dental_horto3.Text
            HCORTO3.p_diag_periodontal_horto3 = Me.txtdiag_periodontal_horto3.Text

            HCORTO3.p_plantratamiento_horto3 = Me.txtplantratamiento_horto3.Text
            HCORTO3.p_alternativas_horto3 = Me.txtalternativas_horto3.Text

            If contar > 0 Then
                HCORTO3.Modificar(CLASE_GENERAL.mensaje_error)
            Else
                HCORTO3.Insertar(CLASE_GENERAL.mensaje_error)
            End If

            HCORTO3.dispose()
            HCORTO3 = Nothing

            '***************************** MODULO DE LA TABLA CONTROL *************************************

            CTRL = New CLASE_CONTROL
            CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
            CTRL.p_IdTRegistro = 15 '15 Modificar Historia Clinica
            CTRL.p_Idproceso = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

            CTRL.Insertar(CLASE_GENERAL.mensaje_error)
            CTRL.dispose()
            CTRL = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarhcorto3")
            EVEN = Nothing

            MsgBox("Historia Clinica modificada con exito.", MsgBoxStyle.OkOnly, "H.C. Ortodoncia 3")

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia
    End Sub

    Private Sub frmHistoriaClinicaOrtodoncia3_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

    Private Sub btnOdontograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOdontograma.Click

        frmOdontogramaGrafico.Show()
        frmOdontogramaGrafico.Activate()

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea un nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "H.C. Ortodoncia 3")

            If respuesta = MsgBoxResult.Yes Then

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcorto3")
                EVEN.bloquaerdesbloquear("nuevahcorto3")

                Me.btnOdontograma.Enabled = False
                Me.btnImprimirHClinica.Enabled = False

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub TabHCOrto3_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabHCOrto3.SelectedTabChanged

        Try

            If TabHCOrto3.SelectedTabIndex = 3 Then

                contar = 0
                contar = CLASE_GENERAL.contar2("IdUsuario", "ograma", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    Me.btnImprimirHClinica.Enabled = True

                Else

                    Me.btnImprimirHClinica.Enabled = False
                    MsgBox("Debe crear un odontograma para este Paciente para imprimir la Historia Clinica.", MsgBoxStyle.OkOnly, "H.C. Ortodoncia 3")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub frmHistoriaClinicaOrtodoncia3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "txtobservaciones_horto3" Or ActiveControl.Name.ToString = "txtobservacionesaencef_horto3" Or ActiveControl.Name.ToString = "txtplantratamiento_horto3" Or ActiveControl.Name.ToString = "txtalternativas_horto3" Or ActiveControl.Name.ToString = "txtdiag_facial_horto3" Or ActiveControl.Name.ToString = "txtdiag_esque_horto3" Or ActiveControl.Name.ToString = "txtdiag_dental_horto3" Or ActiveControl.Name.ToString = "txtdiag_periodontal_horto3") Then

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
                HCORTO3 = New CLASE_HCLINICA_ORTO3
                HCORTO3.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                HCORTO3.p_IdTUsuario = 1 'Es un paciente
                HCORTO3.Seleccionar("impresion")

                'Creamos Objetos para generar el informe
                Dim orptHistoriaClinicaOrto3 As New rptHistoriaClinicaOrto3
                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptHistoriaClinicaOrto3.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptHistoriaClinicaOrto3

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
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtTelCasa_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("email_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtemail_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtemail_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("email_con") & "'"
                            End If

                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 1 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtTelPadre_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtTelPadre_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                        End If

                        If CLASE_GENERAL.xdt2.Rows(i).Item("IdTTutor") = 3 Then

                            If CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtAcudiente_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtAcudiente_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("nom_con") & "'"
                            End If

                            If CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") Is DBNull.Value Then
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtTelAcudiente_pac").Text = "''"
                            Else
                                orptHistoriaClinicaOrto3.DataDefinition.FormulaFields.Item("txtTelAcudiente_pac").Text = "'" & CLASE_GENERAL.xdt2.Rows(i).Item("telcasa_con") & "'"
                            End If

                        End If

                    Next

                    CLASE_GENERAL.xdt2.Clear()
                    CLASE_GENERAL.xdt2 = Nothing

                End If

                CON.dispose()
                CON = Nothing

                '----------- FINALIZAMOS CARGA DE CONTACTOS -------------

                ' Cargamos el Infome desde su contro y modificamos algunas opciones
                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                HCORTO3.dispose()
                HCORTO3 = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

End Class