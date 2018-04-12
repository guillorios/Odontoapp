Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Math

Public Class frmPacientes

    'Creamos las Clases
    Private PAC As CLASE_PACIENTES
    Private EVEN As CLASE_EVENTOS
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS
    Private CTRL As CLASE_CONTROL
    Private GENE As CLASE_GENERAL
    Private CITA As CLASE_CITAS
    Private PRESUPUESTO As CLASE_PRESUPUESTO
    Private OGRAMA As CLASE_OGRAMA
    Private HUELLA As CLASE_HUELLAS

    'Varibles de control
    Private fecha As Date
    Private contar As Integer

    'variable de Imagen
    Private nombreImg As String = ""

    'Variables de composicion
    Private imagenfondo As Bitmap
    Private imagenlogo As Bitmap

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

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProvider.BlinkRate = 200
        Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtapellidos_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtapellidos_pac, "Escriba el Apellido Por favor")
            MsgBox(ErrorProvider.GetError(Me.txtapellidos_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 0
            Me.txtapellidos_pac.Focus()

        ElseIf Me.txtnombres_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtnombres_pac, "Escriba el Nombre por favor")
            MsgBox(ErrorProvider.GetError(Me.txtnombres_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 0
            Me.txtnombres_pac.Focus()

        ElseIf Me.cmbtipodoc_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.cmbtipodoc_pac, "Escoja el tipo de Documento")
            MsgBox(ErrorProvider.GetError(Me.cmbtipodoc_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 0
            Me.cmbtipodoc_pac.Focus()

        ElseIf Me.txtnumdoc_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtnumdoc_pac, "Escriba el numero del Documento")
            MsgBox(ErrorProvider.GetError(Me.txtnumdoc_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 0
            Me.txtnumdoc_pac.Focus()

        ElseIf Me.txtdedoc_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtdedoc_pac, "Escriba el lugar de expedicion del Documento")
            MsgBox(ErrorProvider.GetError(Me.txtdedoc_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 0
            Me.txtdedoc_pac.Focus()

        ElseIf Me.txtTelCasa_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtTelCasa_pac, "Escriba el Telefono de la Casa en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtTelCasa_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 1
            Me.txtTelCasa_pac.Focus()

        ElseIf Me.txtCelular_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtCelular_pac, "Escriba el No. de Celular en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtCelular_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 1
            Me.txtCelular_pac.Focus()

        ElseIf Me.txtemail_pac.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtemail_pac, "Escriba el email en contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtemail_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 1
            Me.txtemail_pac.Focus()

        ElseIf Not IsDate(Me.cmbfecingreso_pac.Value) Then
            ErrorProvider.SetError(Me.cmbfecingreso_pac, "Fecha no valida revisela por favor.")
            MsgBox(ErrorProvider.GetError(Me.cmbfecingreso_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 0
            Me.cmbfecingreso_pac.Focus()

        ElseIf Not IsDate(Me.cmbfecnac_pac.Value) Then
            ErrorProvider.SetError(Me.cmbfecnac_pac, "Fecha no valida revisela por favor.")
            MsgBox(ErrorProvider.GetError(Me.cmbfecnac_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
            Me.TabControl_pac.SelectedTabIndex = 0
            Me.cmbfecnac_pac.Focus()

        Else

            Try

                '**************************** MODULO PARA INGRESO DEL PACIENTE *******************************

                PAC = New CLASE_PACIENTES

                'Asignamos los valores a las variables de la clase pacientes 

                PAC.p_IdPaciente = Me.txtIdpaciente.Text
                PAC.p_apellidos_pac = Me.txtapellidos_pac.Text
                PAC.p_nombres_pac = Me.txtnombres_pac.Text
                PAC.p_residencia_pac = Me.txtresidencia_pac.Text
                PAC.p_estadocivil_pac = Me.cmbestadocivil_pac.SelectedIndex
                PAC.p_oficina_pac = Me.txtoficina_pac.Text
                PAC.p_fecingreso_pac = Format(Me.cmbfecingreso_pac.Value, "yyyy-MM-dd")
                PAC.p_ocupacion_pac = Me.txtocupacion_pac.Text
                PAC.p_referidopor_pac = Me.txtreferido_pac.Text
                PAC.p_fecnac_pac = Format(Me.cmbfecnac_pac.Value, "yyyy-MM-dd")
                PAC.p_lugarnac_pac = Me.txtlugarnac_pac.Text

                PAC.p_zona_pac = Me.cmbzona_pac.SelectedIndex
                PAC.p_municipio_pac = Me.txtmunicipio_pac.Text
                PAC.p_dep_pac = Me.txtdep_pac.Text
                PAC.p_rh_pac = Me.txtrh_Pac.Text

                Select Case Me.cmbtipodoc_pac.Text

                    Case "T.I"
                        PAC.p_tipodoc_pac = 1
                    Case "CEDULA"
                        PAC.p_tipodoc_pac = 2
                    Case "PASAPORTE"
                        PAC.p_tipodoc_pac = 3
                    Case "C.EXTRANGERIA"
                        PAC.p_tipodoc_pac = 4

                End Select

                PAC.p_numdoc_pac = Me.txtnumdoc_pac.Text
                PAC.p_dedoc_pac = Me.txtdedoc_pac.Text

                If Me.rbtMasculino_pac.Checked = True Then
                    PAC.p_sexo_pac = "M"
                Else
                    PAC.p_sexo_pac = "F"
                End If

                PAC.p_Identidad = Me.cmbEntidad.SelectedValue
                PAC.p_nhclinica = Me.txtnhclinica.Text
                PAC.p_Idoperador = Me.cmbOperadorCel.SelectedValue

                If Me.rbtEstado_Entratamiento.Checked = True Then
                    PAC.p_Idestado_pac = 1
                ElseIf Me.rbtEstado_Bloqueado.Checked = True Then
                    PAC.p_Idestado_pac = 2
                ElseIf Me.rbtEstado_Retencion.Checked = True Then
                    PAC.p_Idestado_pac = 3
                ElseIf Me.rbtEstado_Retirado.Checked = True Then
                    PAC.p_Idestado_pac = 4
                End If

                PAC.p_Idconsultorio = CLASE_GENERAL._Idconsultorio

                'Insertamos en la base de datos lo correspondiente a los datos basicos del paciente

                PAC.Insertar(CLASE_GENERAL.mensaje_error)
                PAC.dispose() 'Liberamos recursos 
                PAC = Nothing

                '**************************** MODULO PARA INGRESO DE LOS CONTACTOS *******************************

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdpaciente.Text
                CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes al paciente mismo
                CON.p_telcasa_con = Me.txtTelCasa_pac.Text
                CON.p_teloficina_con = Me.txtTelOficina_pac.Text
                CON.p_fax_con = Me.txtFax_pac.Text
                CON.p_cel_con = Me.txtCelular_pac.Text
                CON.p_email_con = Me.txtemail_pac.Text
                CON.p_web_con = Me.txtweb_pac.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdpaciente.Text
                CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                CON.p_IdTTutor = 1 ' Utilizamos 1 Porque son los datos correspondientes al Padre del Paciente
                CON.p_nom_con = Me.txtPadre_pac.Text
                CON.p_telcasa_con = Me.txtTelPadre_pac.Text
                CON.p_cel_con = Me.txtCelPadre_pac.Text
                CON.p_ocu_con = Me.txtOcuPadre_pac.Text
                CON.p_email_con = Me.txtemailPadre_pac.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdpaciente.Text
                CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                CON.p_IdTTutor = 2 ' Utilizamos 2 Porque son los datos correspondientes la Madre del Paciente
                CON.p_nom_con = Me.txtMadre_pac.Text
                CON.p_telcasa_con = Me.txtTelMadre_pac.Text
                CON.p_cel_con = Me.txtCelMadre_pac.Text
                CON.p_ocu_con = Me.txtOcuMadre_pac.Text
                CON.p_email_con = Me.txtemailMadre_pac.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdpaciente.Text
                CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                CON.p_IdTTutor = 3 ' Utilizamos 3 Porque son los datos correspondientes al Acudiente del Paciente
                CON.p_nom_con = Me.txtAcudiente_pac.Text
                CON.p_telcasa_con = Me.txtTelAcudiente_pac.Text
                CON.p_cel_con = Me.txtCelAcudiente_pac.Text
                CON.p_ocu_con = Me.txtOcuAcudiente_pac.Text
                CON.p_email_con = Me.txtemailAcudiente_pac.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdpaciente.Text
                CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                CON.p_IdTTutor = 4 ' Utilizamos 4 Porque son los datos correspondientes al Conyuge del Paciente
                CON.p_nom_con = Me.txtConyuge_pac.Text
                CON.p_telcasa_con = Me.txtTelConyuge_pac.Text
                CON.p_cel_con = Me.txtCelConyuge_pac.Text
                CON.p_ocu_con = Me.txtOcuConyuge_pac.Text
                CON.p_email_con = Me.txtemailConyuge_pac.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************

                NOTA = New CLASE_NOTAS
                GENE = New CLASE_GENERAL

                NOTA.p_IdUsuario = Me.txtIdpaciente.Text
                NOTA.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                NOTA.p_nota = Me.RichTxtNotas_pac.Text

                If Not Me.pbFoto_pac.Image Is Nothing Then

                    NOTA.p_fotolong = GENE.Imagen_Bytes(Me.pbFoto_pac.Image)

                End If

                NOTA.Insertar(CLASE_GENERAL.mensaje_error)
                NOTA.dispose()
                NOTA = Nothing

                GENE = Nothing

                '*********** CREAMOS LOS ODONTOGRAMAS INICIALES ******************

                OGRAMA = New CLASE_OGRAMA
                GENE = New CLASE_GENERAL

                OGRAMA.p_IdUsuario = Me.txtIdpaciente.Text
                OGRAMA.p_fecha_ograma = Format(Date.Now, "yyyy-MM-dd")
                OGRAMA.p_ograma_inicial = GENE.Imagen_Bytes(My.Resources.OdontoIni)
                OGRAMA.p_observacionograma_ini = ""
                OGRAMA.p_ograma_actual = GENE.Imagen_Bytes(My.Resources.OdontoIni)
                OGRAMA.p_observacionograma_act = ""

                OGRAMA.Insertar(CLASE_GENERAL.mensaje_error)

                OGRAMA.dispose()
                OGRAMA = Nothing

                GENE = Nothing

                '*********** CREAMOS LOS ESPACIOS DE LAS HUELLAS INICIALES ******************

                HUELLA = New CLASE_HUELLAS

                HUELLA.p_Idhuella = (CLASE_GENERAL.maximo("Idhuella", "huellas", CLASE_GENERAL.mensaje_error)) + 1
                HUELLA.p_IdUsuario = Me.txtIdpaciente.Text
                HUELLA.p_IdTUsuario = 1 ' Tipo Paciente
                HUELLA.p_fechareg = Format(Date.Now, "yyyy-MM-dd")

                HUELLA.Insertar(CLASE_GENERAL.mensaje_error)

                HUELLA.dispose()
                HUELLA = Nothing

                '***************************** MODULO PARA INGRESO EN LA FICHA *******************************

                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Me.pbFoto_pac.Image
                My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIdpaciente.Text
                My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombres_pac.Text & " " & Me.txtapellidos_pac.Text
                My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtreferido_pac.Text
                My.Forms.mdiOrthoSoft.txtnhistoria_ficha.Text = Me.txtnhclinica.Text
                My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_pac.Text
                My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelCasa_pac.Text
                My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_pac.Text

                '***************************** MODULO PARA INGRESO EN EL ESTADO ******************************

                My.Forms.mdiOrthoSoft.lblActivoPaciente.Text = Me.txtnombres_pac.Text & " " & Me.txtapellidos_pac.Text
                My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag = Me.txtIdpaciente.Text

                'Cargamos Id especial para Huellas
                CLASE_GENERAL._Idpaciente_consec = Me.txtIdpaciente.Text

                If Me.rbtEstado_Entratamiento.Checked = True Then
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LightSkyBlue
                ElseIf Me.rbtEstado_Bloqueado.Checked = True Then
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Salmon
                ElseIf Me.rbtEstado_Retencion.Checked = True Then
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LimeGreen
                ElseIf Me.rbtEstado_Retirado.Checked = True Then
                    My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Khaki
                End If

                '***************************** MODULO DE LA TABLA CONTROL *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 4 '4 Crear Paciente
                CTRL.p_Idproceso = Me.txtIdpaciente.Text

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarpaciente")
                EVEN = Nothing

                Me.btnEstudiosPac.Enabled = True
                Me.btnPacOdontograma.Enabled = True
                Me.btnEstadoCuenta.Enabled = True
                Me.gpHC_NDoc.Enabled = False

                My.Forms.mdiOrthoSoft.btnEnvioEmail.Enabled = True

                If My.Forms.mdiOrthoSoft.btnEditarFicha.Tag = "1" Then
                    My.Forms.mdiOrthoSoft.btnEditarFicha.Enabled = True
                End If


                ' Cerramos todos las ventanas que intervenga informacion de un usuario
                For Each frm As Form In Me.MdiChildren
                    If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmBuscarPaciente" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Or frm.Name = "frmRcaja" Then
                        frm.Close()
                    End If
                Next

                MsgBox("Paciente registrado con Exito", MsgBoxStyle.OkOnly, "Pacientes")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia


        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea un Nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pacientes")

        If respuesta = MsgBoxResult.Yes Then


            Try

                ' Cerramos todos las ventanas que intervenga informacion de un usuario
                For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren
                    If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Or frm.Name = "frmRcaja" Or frm.Name = "frmEnvioEmailInd" Or frm.Name = "frmEnvioSMSInd" Or frm.Name = "frmFotografia" Or frm.Name = "frmHistoriaClinicaGeneral" Or frm.Name = "frmHistoriaClinicaOrtodoncia" Or frm.Name = "frmHistoriaClinicaOrtodoncia2" Or frm.Name = "frmHistoriaClinicaOrtodoncia3" Or frm.Name = "frmHuellas" Then
                        frm.Close()
                    End If
                Next

                'CLASE_GENERAL.cargar_combo("pacientes", Me.cmbEntidad, CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarpacientes")
                EVEN.limpiar("limpiarficha")
                EVEN.limpiar("limpiaractivopaciente")

                EVEN.bloquaerdesbloquear("nuevopaciente")

                Me.btnEstudiosPac.Enabled = False
                Me.btnPacOdontograma.Enabled = False
                Me.btnEstadoCuenta.Enabled = False
                Me.gpHC_NDoc.Enabled = True

                My.Forms.mdiOrthoSoft.btnEditarFicha.Enabled = False
                My.Forms.mdiOrthoSoft.btnEnvioEmail.Enabled = False

                Me.txtIdpaciente.Text = (CLASE_GENERAL.maximo("IdPaciente", "pacientes", CLASE_GENERAL.mensaje_error)) + 1

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar el Paciente", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pacientes")

        If respuesta = MsgBoxResult.Yes Then

            Try

                PAC = New CLASE_PACIENTES
                CON = New CLASE_CONTACTOS
                NOTA = New CLASE_NOTAS
                EVEN = New CLASE_EVENTOS

                PAC.p_IdPaciente = Me.txtIdpaciente.Text
                CON.p_IdUsuario = Me.txtIdpaciente.Text
                CON.p_IdTUsuario = 1 ' Tipo Pacientes
                NOTA.p_IdUsuario = Me.txtIdpaciente.Text
                NOTA.p_IdTUsuario = 1 ' Tipo Pacientes

                PAC.Eliminar(CLASE_GENERAL.mensaje_error)
                CON.Eliminar(CLASE_GENERAL.mensaje_error)
                NOTA.Eliminar(CLASE_GENERAL.mensaje_error)


                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 5 '5 Elimina Paciente
                CTRL.p_Idproceso = Me.txtIdpaciente.Text

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                EVEN.limpiar("limpiarficha")
                EVEN.limpiar("limpiarpacientes")
                EVEN.limpiar("limpiaractivopaciente")

                EVEN.bloquaerdesbloquear("nuevopaciente")

                Me.txtIdpaciente.Text = (CLASE_GENERAL.maximo("IdPaciente", "pacientes", CLASE_GENERAL.mensaje_error)) + 1

                PAC.dispose()
                PAC = Nothing
                CON.dispose()
                CON = Nothing
                NOTA.dispose()
                NOTA = Nothing
                EVEN = Nothing

                Me.btnEstudiosPac.Enabled = False
                Me.btnPacOdontograma.Enabled = False
                Me.btnEstadoCuenta.Enabled = False
                Me.gpHC_NDoc.Enabled = True

                My.Forms.mdiOrthoSoft.btnEditarFicha.Enabled = False
                My.Forms.mdiOrthoSoft.btnEnvioEmail.Enabled = False

                ' Cerramos todos las ventanas que intervenga informacion de un usuario
                For Each frm As Form In Me.MdiChildren
                    If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmBuscarPaciente" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Or frm.Name = "frmRcaja" Then
                        frm.Close()
                    End If
                Next

                MsgBox("Paciente Eliminado con Exito", MsgBoxStyle.OkOnly, "Pacientes")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If


    End Sub

    Public Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar el Paciente", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pacientes")

        If respuesta = MsgBoxResult.Yes Then


            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink


            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtapellidos_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtapellidos_pac, "Escriba el Apellido Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtapellidos_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 0
                Me.txtapellidos_pac.Focus()

            ElseIf Me.txtnombres_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnombres_pac, "Escriba el Nombre por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnombres_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 0
                Me.txtnombres_pac.Focus()

            ElseIf Me.cmbtipodoc_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.cmbtipodoc_pac, "Escoja el tipo de Documento")
                MsgBox(ErrorProvider.GetError(Me.cmbtipodoc_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 0
                Me.cmbtipodoc_pac.Focus()

            ElseIf Me.txtnumdoc_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnumdoc_pac, "Escriba el numero del Documento")
                MsgBox(ErrorProvider.GetError(Me.txtnumdoc_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 0
                Me.txtnumdoc_pac.Focus()

            ElseIf Me.txtdedoc_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtdedoc_pac, "Escriba el lugar de expedicion del Documento")
                MsgBox(ErrorProvider.GetError(Me.txtdedoc_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 0
                Me.txtdedoc_pac.Focus()

            ElseIf Me.txtTelCasa_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtTelCasa_pac, "Escriba el Telefono de la Casa en Contactos por favor")
                MsgBox(ErrorProvider.GetError(Me.txtTelCasa_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 1
                Me.txtTelCasa_pac.Focus()

            ElseIf Me.txtCelular_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtCelular_pac, "Escriba el No. de Celular en Contactos por favor")
                MsgBox(ErrorProvider.GetError(Me.txtCelular_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 1
                Me.txtCelular_pac.Focus()

            ElseIf Me.txtemail_pac.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtemail_pac, "Escriba el email en contactos por favor")
                MsgBox(ErrorProvider.GetError(Me.txtemail_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 1
                Me.txtemail_pac.Focus()

            ElseIf Not IsDate(Me.cmbfecingreso_pac.Value) Then
                ErrorProvider.SetError(Me.cmbfecingreso_pac, "Fecha no valida revisela por favor.")
                MsgBox(ErrorProvider.GetError(Me.cmbfecingreso_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 0
                Me.cmbfecingreso_pac.Focus()

            ElseIf Not IsDate(Me.cmbfecnac_pac.Value) Then
                ErrorProvider.SetError(Me.cmbfecnac_pac, "Fecha no valida revisela por favor.")
                MsgBox(ErrorProvider.GetError(Me.cmbfecnac_pac), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Pacientes")
                Me.TabControl_pac.SelectedTabIndex = 0
                Me.cmbfecnac_pac.Focus()

            Else

                Try

                    '**************************** MODULO PARA MODIFICACION DE LOS PACIENTES *******************************

                    PAC = New CLASE_PACIENTES

                    'Asignamos los valores a las variables de la clase pacientes

                    PAC.p_IdPaciente = Me.txtIdpaciente.Text
                    PAC.p_apellidos_pac = Me.txtapellidos_pac.Text
                    PAC.p_nombres_pac = Me.txtnombres_pac.Text
                    PAC.p_residencia_pac = Me.txtresidencia_pac.Text
                    PAC.p_estadocivil_pac = Me.cmbestadocivil_pac.SelectedIndex
                    PAC.p_oficina_pac = Me.txtoficina_pac.Text
                    PAC.p_fecingreso_pac = Format(Me.cmbfecingreso_pac.Value, "yyyy-MM-dd")
                    PAC.p_ocupacion_pac = Me.txtocupacion_pac.Text
                    PAC.p_referidopor_pac = Me.txtreferido_pac.Text
                    PAC.p_fecnac_pac = Format(Me.cmbfecnac_pac.Value, "yyyy-MM-dd")
                    PAC.p_lugarnac_pac = Me.txtlugarnac_pac.Text

                    PAC.p_zona_pac = Me.cmbzona_pac.SelectedIndex
                    PAC.p_municipio_pac = Me.txtmunicipio_pac.Text
                    PAC.p_dep_pac = Me.txtdep_pac.Text
                    PAC.p_rh_pac = Me.txtrh_Pac.Text

                    Select Case Me.cmbtipodoc_pac.Text

                        Case "T.I"
                            PAC.p_tipodoc_pac = 1
                        Case "CEDULA"
                            PAC.p_tipodoc_pac = 2
                        Case "PASAPORTE"
                            PAC.p_tipodoc_pac = 3
                        Case "C.EXTRANGERIA"
                            PAC.p_tipodoc_pac = 4

                    End Select

                    PAC.p_numdoc_pac = Me.txtnumdoc_pac.Text
                    PAC.p_dedoc_pac = Me.txtdedoc_pac.Text

                    If Me.rbtMasculino_pac.Checked = True Then
                        PAC.p_sexo_pac = "M"
                    Else
                        PAC.p_sexo_pac = "F"
                    End If

                    PAC.p_Identidad = Me.cmbEntidad.SelectedValue
                    PAC.p_nhclinica = Me.txtnhclinica.Text
                    PAC.p_Idoperador = Me.cmbOperadorCel.SelectedValue

                    If Me.rbtEstado_Entratamiento.Checked = True Then
                        PAC.p_Idestado_pac = 1
                    ElseIf Me.rbtEstado_Bloqueado.Checked = True Then
                        PAC.p_Idestado_pac = 2
                    ElseIf Me.rbtEstado_Retencion.Checked = True Then
                        PAC.p_Idestado_pac = 3
                    ElseIf Me.rbtEstado_Retirado.Checked = True Then
                        PAC.p_Idestado_pac = 4
                    End If

                    PAC.p_Idconsultorio = CLASE_GENERAL._Idconsultorio

                    PAC.Modificar("ingreso")
                    PAC.dispose()
                    PAC = Nothing

                    '**************************** MODULO PARA MODIFICACION DE LOS CONTACTOS *******************************

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdpaciente.Text
                    CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                    CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes al paciente mismo
                    CON.p_telcasa_con = Me.txtTelCasa_pac.Text
                    CON.p_teloficina_con = Me.txtTelOficina_pac.Text
                    CON.p_fax_con = Me.txtFax_pac.Text
                    CON.p_cel_con = Me.txtCelular_pac.Text
                    CON.p_email_con = Me.txtemail_pac.Text
                    CON.p_web_con = Me.txtweb_pac.Text

                    contar = 0
                    contar = CLASE_GENERAL.contarcontactos(Me.txtIdpaciente.Text, 1, 5, CLASE_GENERAL.mensaje_error)

                    If contar >= 1 Then

                        CON.Modificar(CLASE_GENERAL.mensaje_error)

                    Else

                        CON.Insertar(CLASE_GENERAL.mensaje_error)

                    End If

                    CON.dispose()
                    CON = Nothing

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdpaciente.Text
                    CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                    CON.p_IdTTutor = 1 ' Utilizamos 1 Porque son los datos correspondientes al Padre del Paciente
                    CON.p_nom_con = Me.txtPadre_pac.Text
                    CON.p_telcasa_con = Me.txtTelPadre_pac.Text
                    CON.p_cel_con = Me.txtCelPadre_pac.Text
                    CON.p_ocu_con = Me.txtOcuPadre_pac.Text
                    CON.p_email_con = Me.txtemailPadre_pac.Text

                    contar = 0
                    contar = CLASE_GENERAL.contarcontactos(Me.txtIdpaciente.Text, 1, 1, CLASE_GENERAL.mensaje_error)

                    If contar >= 1 Then

                        CON.Modificar(CLASE_GENERAL.mensaje_error)

                    Else

                        CON.Insertar(CLASE_GENERAL.mensaje_error)

                    End If

                    CON.dispose()
                    CON = Nothing

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdpaciente.Text
                    CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                    CON.p_IdTTutor = 2 ' Utilizamos 2 Porque son los datos correspondientes la Madre del Paciente
                    CON.p_nom_con = Me.txtMadre_pac.Text
                    CON.p_telcasa_con = Me.txtTelMadre_pac.Text
                    CON.p_cel_con = Me.txtCelMadre_pac.Text
                    CON.p_ocu_con = Me.txtOcuMadre_pac.Text
                    CON.p_email_con = Me.txtemailMadre_pac.Text

                    contar = 0
                    contar = CLASE_GENERAL.contarcontactos(Me.txtIdpaciente.Text, 1, 2, CLASE_GENERAL.mensaje_error)

                    If contar >= 1 Then

                        CON.Modificar(CLASE_GENERAL.mensaje_error)

                    Else

                        CON.Insertar(CLASE_GENERAL.mensaje_error)

                    End If

                    CON.dispose()

                    CON = Nothing

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdpaciente.Text
                    CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                    CON.p_IdTTutor = 3 ' Utilizamos 3 Porque son los datos correspondientes al Acudiente del Paciente
                    CON.p_nom_con = Me.txtAcudiente_pac.Text
                    CON.p_telcasa_con = Me.txtTelAcudiente_pac.Text
                    CON.p_cel_con = Me.txtCelAcudiente_pac.Text
                    CON.p_ocu_con = Me.txtOcuAcudiente_pac.Text
                    CON.p_email_con = Me.txtemailAcudiente_pac.Text

                    contar = 0
                    contar = CLASE_GENERAL.contarcontactos(Me.txtIdpaciente.Text, 1, 3, CLASE_GENERAL.mensaje_error)

                    If contar >= 1 Then

                        CON.Modificar(CLASE_GENERAL.mensaje_error)

                    Else

                        CON.Insertar(CLASE_GENERAL.mensaje_error)

                    End If

                    CON.dispose()
                    CON = Nothing

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdpaciente.Text
                    CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                    CON.p_IdTTutor = 4 ' Utilizamos 4 Porque son los datos correspondientes al Conyuge del Paciente
                    CON.p_nom_con = Me.txtConyuge_pac.Text
                    CON.p_telcasa_con = Me.txtTelConyuge_pac.Text
                    CON.p_cel_con = Me.txtCelConyuge_pac.Text
                    CON.p_ocu_con = Me.txtOcuConyuge_pac.Text
                    CON.p_email_con = Me.txtemailConyuge_pac.Text

                    contar = 0
                    contar = CLASE_GENERAL.contarcontactos(Me.txtIdpaciente.Text, 1, 4, CLASE_GENERAL.mensaje_error)

                    If contar >= 1 Then

                        CON.Modificar(CLASE_GENERAL.mensaje_error)

                    Else

                        CON.Insertar(CLASE_GENERAL.mensaje_error)

                    End If

                    CON.dispose()
                    CON = Nothing

                    '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************

                    NOTA = New CLASE_NOTAS
                    GENE = New CLASE_GENERAL

                    NOTA.p_IdUsuario = Me.txtIdpaciente.Text
                    NOTA.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                    NOTA.p_nota = Me.RichTxtNotas_pac.Text

                    If Not Me.pbFoto_pac.Image Is Nothing Then

                        NOTA.p_fotolong = GENE.Imagen_Bytes(Me.pbFoto_pac.Image)

                    End If

                    contar = 0
                    contar = CLASE_GENERAL.contarnotas(Me.txtIdpaciente.Text, 1, CLASE_GENERAL.mensaje_error)

                    If contar >= 1 Then

                        NOTA.Modificar("notas")

                    Else

                        NOTA.Insertar(CLASE_GENERAL.mensaje_error)

                    End If

                    NOTA.dispose()
                    NOTA = Nothing

                    GENE = Nothing

                    '*************************** CREAMOS EL ODONTOGRAMA EN BLANCO *********

                    OGRAMA = New CLASE_OGRAMA
                    GENE = New CLASE_GENERAL

                    OGRAMA.p_IdUsuario = Me.txtIdpaciente.Text
                    OGRAMA.p_fecha_ograma = Format(Date.Now, "yyyy-MM-dd")
                    OGRAMA.p_ograma_inicial = GENE.Imagen_Bytes(My.Resources.OdontoIni)
                    OGRAMA.p_observacionograma_ini = ""
                    OGRAMA.p_ograma_actual = GENE.Imagen_Bytes(My.Resources.OdontoIni)
                    OGRAMA.p_observacionograma_act = ""

                    contar = 0
                    contar = CLASE_GENERAL.contar2("IdUsuario", "ograma", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                    If Not (contar = 1) Then

                        OGRAMA.Insertar(CLASE_GENERAL.mensaje_error)

                    End If


                    OGRAMA.dispose()
                    OGRAMA = Nothing

                    GENE = Nothing

                    '**************************** CARGAMOS LA FICHA ************************

                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiarficha")

                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Me.pbFoto_pac.Image
                    My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIdpaciente.Text
                    My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombres_pac.Text & " " & Me.txtapellidos_pac.Text
                    My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtreferido_pac.Text
                    My.Forms.mdiOrthoSoft.txtnhistoria_ficha.Text = Me.txtnhclinica.Text
                    My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_pac.Text
                    My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelCasa_pac.Text
                    My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_pac.Text


                    '***************************** MODULO PARA INGRESO EN EL ESTADO ******************************

                    My.Forms.mdiOrthoSoft.lblActivoPaciente.Text = Me.txtnombres_pac.Text & " " & Me.txtapellidos_pac.Text
                    My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag = Me.txtIdpaciente.Text

                    'Cargamos Id especial para Huellas
                    CLASE_GENERAL._Idpaciente_consec = Me.txtIdpaciente.Text

                    If Me.rbtEstado_Entratamiento.Checked = True Then
                        My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LightSkyBlue
                    ElseIf Me.rbtEstado_Bloqueado.Checked = True Then
                        My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Salmon
                    ElseIf Me.rbtEstado_Retencion.Checked = True Then
                        My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.LimeGreen
                    ElseIf Me.rbtEstado_Retirado.Checked = True Then
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


                    '**************** Llenamos La Tabla Control *************************************

                    CTRL = New CLASE_CONTROL
                    CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    CTRL.p_IdTRegistro = 6 '6 Modifica Paciente
                    CTRL.p_Idproceso = Me.txtIdpaciente.Text

                    CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                    CTRL.dispose()
                    CTRL = Nothing

                    EVEN.bloquaerdesbloquear("editarpaciente")
                    EVEN = Nothing

                    Me.btnEstudiosPac.Enabled = True
                    Me.btnPacOdontograma.Enabled = True
                    Me.btnEstadoCuenta.Enabled = True
                    Me.gpHC_NDoc.Enabled = False

                    My.Forms.mdiOrthoSoft.btnEnvioEmail.Enabled = True

                    If My.Forms.mdiOrthoSoft.btnEditarFicha.Tag = "1" Then
                        My.Forms.mdiOrthoSoft.btnEditarFicha.Enabled = True
                    End If


                    ' Cerramos todos las ventanas que intervenga informacion de un usuario
                    For Each frm As Form In Me.MdiChildren
                        If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmBuscarPaciente" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Or frm.Name = "frmRcaja" Then
                            frm.Close()
                        End If
                    Next


                    MsgBox("Paciente modificado con Exito", MsgBoxStyle.OkOnly, "Pacientes")

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try

            End If

        End If

    End Sub

    Private Sub rbtAños_pac_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtAños_pac.Click

        Me.lblNumaños.Text = CLASE_EVENTOS.CalcularEdad(Me.cmbfecnac_pac.Value)

        'Me.lblNumaños.Text = Round((DateDiff(DateInterval.Month, Me.cmbfecnac_pac.Value, Now()) / 12), MidpointRounding.AwayFromZero)

    End Sub

    Private Sub cmbfecnac_pac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfecnac_pac.ValueChanged

        Me.ErrorProvider.SetError(Me.cmbfecnac_pac, "")

        If Me.rbtAños_pac.Checked = True Then

            Me.lblNumaños.Text = CLASE_EVENTOS.CalcularEdad(Me.cmbfecnac_pac.Value)
            'Me.lblNumaños.Text = Round((DateDiff(DateInterval.Day, Me.cmbfecnac_pac.Value, Now()) / 365), MidpointRounding.AwayFromZero)
        Else

            Me.lblNumaños.Text = DateDiff(DateInterval.Month, Me.cmbfecnac_pac.Value, Now())

        End If

    End Sub

    Private Sub rbtmeses_pac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtmeses_pac.CheckedChanged
        Me.lblNumaños.Text = DateDiff(DateInterval.Month, Me.cmbfecnac_pac.Value, Now(), )
    End Sub

    Private Sub frmPacientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CLASE_GENERAL.formload = 1

        Try

            CLASE_GENERAL.cargar_combo("entidades", Me.cmbEntidad, CLASE_GENERAL.mensaje_error)
            'Me.cmbEntidad.SelectedValue = 0

            CLASE_GENERAL.cargar_combo("operadorescel", Me.cmbOperadorCel, CLASE_GENERAL.mensaje_error)
            'Me.cmbEntidad.SelectedIndex = 0

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub rbtEstado_Entratamiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEstado_Entratamiento.CheckedChanged
        Me.panelEstado.TitleStyle.BackColor1.Color = Color.LightSkyBlue
    End Sub

    Private Sub rbtEstado_Bloqueado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEstado_Bloqueado.CheckedChanged
        Me.panelEstado.TitleStyle.BackColor1.Color = Color.Salmon
    End Sub

    Private Sub rbtEstado_Retencion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEstado_Retencion.CheckedChanged
        Me.panelEstado.TitleStyle.BackColor1.Color = Color.LimeGreen
    End Sub

    Private Sub rbtEstado_Retirado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEstado_Retirado.CheckedChanged
        Me.panelEstado.TitleStyle.BackColor1.Color = Color.Khaki
    End Sub

    Private Sub txtapellidos_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellidos_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtapellidos_pac, "")
    End Sub

    Private Sub txtnombres_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombres_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtnombres_pac, "")
    End Sub

    Private Sub txtresidencia_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtresidencia_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtresidencia_pac, "")
    End Sub

    Private Sub txtocupacion_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtocupacion_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtocupacion_pac, "")
    End Sub

    Private Sub cmbtipodoc_pac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.SetError(Me.cmbtipodoc_pac, "")
    End Sub

    Private Sub cmbEntidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEntidad.SelectedIndexChanged
        Me.ErrorProvider.SetError(Me.cmbEntidad, "")
    End Sub

    Private Sub txtnhclinica_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.SetError(Me.txtnhclinica, "")
    End Sub

    Private Sub txtTelCasa_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelCasa_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtTelCasa_pac, "")
    End Sub

    Private Sub txtCelular_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtCelular_pac, "")
    End Sub

    Private Sub frmPacientes_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CLASE_GENERAL.formload = 0
    End Sub

    Private Sub txtemail_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtemail_pac, "")
    End Sub

    Private Sub btnEstudiosPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstudiosPac.Click

        frmEstudios.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmEstudios.Show()
        frmEstudios.Activate()

    End Sub

    Private Sub btnPacOdontograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPacOdontograma.Click

        frmOdontogramaGrafico.Show()
        frmOdontogramaGrafico.Activate()

    End Sub

    Private Sub btnNoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail.Click

        Me.txtemail_pac.Text = "notiene@"

    End Sub

    Private Sub btnBorrarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarFoto.Click

        Me.pbFoto_pac.Image = My.Resources.fondopaciente

    End Sub

    Private Sub frmPacientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "RichTxtNotas_pac") Then

            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                e.Handled = True
                SendKeys.Send(Convert.ToChar(Keys.Tab))
            End If

        End If


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

        'Datos Iniciales
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.pbFoto_pac)
        ubicarcontrol(Me.panelEstado)
        ubicarcontrol(Me.btnFotoA)
        ubicarcontrol(Me.btnBorrarFoto)
        ubicarcontrol(Me.btnFoto)
        ubicarcontrol(Me.lblfecingreso_pac)
        ubicarcontrol(Me.cmbfecingreso_pac)
        ubicarcontrol(Me.lbllugarnac_pac)
        ubicarcontrol(Me.txtlugarnac_pac)
        ubicarcontrol(Me.txtrh_Pac)
        ubicarcontrol(Me.lblrh_Pac)
        ubicarcontrol(Me.cmbzona_pac)
        ubicarcontrol(Me.lblzona_pac)
        ubicarcontrol(Me.txtmunicipio_pac)
        ubicarcontrol(Me.lblmunicipio_pac)
        ubicarcontrol(Me.txtdep_pac)
        ubicarcontrol(Me.lbldep_pac)
        ubicarcontrol(Me.cmbestadocivil_pac)
        ubicarcontrol(Me.lblestadocivil_pac)
        ubicarcontrol(Me.lblfecnac_pac)
        ubicarcontrol(Me.cmbfecnac_pac)
        ubicarcontrol(Me.btnEstadoCuenta)

        ubicarcontrol(Me.gPanel_Sexo)
        ubicarcontrol(Me.gPanel_Edad)
        ubicarcontrol(Me.gpHC_NDoc)
        ubicarcontrol(Me.lblEntidad)
        ubicarcontrol(Me.cmbEntidad)
        ubicarcontrol(Me.lblIdpaciente)
        ubicarcontrol(Me.txtIdpaciente)
        ubicarcontrol(Me.lblnhclinica)
        ubicarcontrol(Me.txtnhclinica)

        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

        ubicarcontrol(Me.btnEstudiosPac)
        ubicarcontrol(Me.btnPacOdontograma)

        ubicarcontrol(Me.lblapellidos_pac)
        ubicarcontrol(Me.txtapellidos_pac)
        ubicarcontrol(Me.txtnombres_pac)
        ubicarcontrol(Me.lblnombres_pac)
        ubicarcontrol(Me.txtreferido_pac)
        ubicarcontrol(Me.lblreferido_pac)
        ubicarcontrol(Me.txtoficina_pac)
        ubicarcontrol(Me.lbloficina_pac)
        ubicarcontrol(Me.lblocupacion_pac)
        ubicarcontrol(Me.txtocupacion_pac)
        ubicarcontrol(Me.lblresidencia_pac)
        ubicarcontrol(Me.txtresidencia_pac)

        ubicarcontrol(Me.cmbtipodoc_pac)
        ubicarcontrol(Me.lbltipodoc_pac)
        ubicarcontrol(Me.txtnumdoc_pac)
        ubicarcontrol(Me.lblnumdoc_pac)
        ubicarcontrol(Me.txtdedoc_pac)
        ubicarcontrol(Me.lbldedoc_pac)

        'Contactos
        ubicarcontrol(Me.gpContactos)
        ubicarcontrol(Me.gpPadres)
        ubicarcontrol(Me.gpConyuge)

        'Notas
        ubicarcontrol(Me.gpNotas)
        ubicarcontrol(Me.lblRegistroBiometrico)
        ubicarcontrol(Me.gpRegistroBiometrico)

    End Sub

    Private Sub frmPacientes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

    Private Sub btnFotoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFotoA.Click
        Try

            'Me.OpenFileDialogPac.Filter = "Todos los Archivos (*.*)|*.*|Archivos BMP (*.bmp)|*.bmp|Iconos (*.ico)|*.ico|Archivos JPG (*.jpg)|*.jpg|Archivos JPEG (*.jpeg)|*.jpeg|Archivos GIF (*.gif)|*.gif"

            OpenFileDialog = New OpenFileDialog
            OpenFileDialog.Filter = "Imágenes JPG (*.jpg)|*.jpg|Mapas de bits (*.bmp)|*.bmp"
            OpenFileDialog.Title = "Abre una imagen JPG o BMP"

            If OpenFileDialog.ShowDialog() = DialogResult.OK Then

                nombreImg = OpenFileDialog.FileName
                Me.pbFoto_pac.Image = Image.FromFile(nombreImg)
                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Image.FromFile(nombreImg)
                Me.pbFoto_pac.SizeMode = PictureBoxSizeMode.Zoom

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click

        frmFotografia.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmFotografia.Show()
        frmFotografia.Activate()
        CLASE_GENERAL.formload = 1

    End Sub

    Private Sub btnEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadoCuenta.Click

        frmEstadoCuenta.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmEstadoCuenta.Show()
        frmEstadoCuenta.Activate()

    End Sub

    Private Sub txtnumdoc_pac_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumdoc_pac.EditValueChanged

        If Me.btnAdicionar.Enabled = True And Me.rbSiHC_NDoc.Checked = True Then

            Me.txtnhclinica.Text = Me.txtnumdoc_pac.Text

        End If


    End Sub

    Private Sub rbSiHC_NDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSiHC_NDoc.CheckedChanged


        If Me.btnAdicionar.Enabled = True And Me.rbSiHC_NDoc.Checked = True Then

            Me.txtnhclinica.Text = Me.txtnumdoc_pac.Text

        Else

            Me.txtnhclinica.Text = 0

        End If

    End Sub

    Private Sub rbNoHC_NDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoHC_NDoc.CheckedChanged

        If Me.btnAdicionar.Enabled = True And Me.rbSiHC_NDoc.Checked = True Then

            Me.txtnhclinica.Text = Me.txtnumdoc_pac.Text

        Else

            Me.txtnhclinica.Text = 0

        End If

    End Sub

    Private Sub cmbfecingreso_pac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfecingreso_pac.ValueChanged
        Me.ErrorProvider.SetError(Me.cmbfecingreso_pac, "")
    End Sub

    Private Sub btnRegistroBiometrico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroBiometrico.Click

        Try

            '*********** CREAMOS LOS ESPACIOS DE LAS HUELLAS INICIALES ******************
            CLASE_GENERAL._TipoUsuario = 1 'Tipo PAciente

            contar = 0
            contar = CLASE_GENERAL.contarhuellas(Me.txtIdpaciente.Text, 1, CLASE_GENERAL.mensaje_error)

            If contar = 0 Then

                HUELLA = New CLASE_HUELLAS

                HUELLA.p_Idhuella = (CLASE_GENERAL.maximo("Idhuella", "huellas", CLASE_GENERAL.mensaje_error)) + 1
                HUELLA.p_IdUsuario = Me.txtIdpaciente.Text
                HUELLA.p_IdTUsuario = 1 ' Tipo Paciente
                HUELLA.p_fechareg = Format(Date.Now, "yyyy-MM-dd")

                HUELLA.Insertar(CLASE_GENERAL.mensaje_error)

                HUELLA.dispose()
                HUELLA = Nothing

            Else

                '**************************** HUELLAS REGISTRADAS *************************************

                HUELLA = New CLASE_HUELLAS

                HUELLA.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                HUELLA.p_IdTUsuario = 1 'Tipo Paciente

                HUELLA.Seleccionar("todos")

                If Not (CLASE_HUELLAS.xhuella1 = "") Then
                    My.Forms.frmHuellas.D1.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D1.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella2 = "") Then

                    My.Forms.frmHuellas.D2.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D2.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella3 = "") Then
                    My.Forms.frmHuellas.D3.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D3.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella4 = "") Then

                    My.Forms.frmHuellas.D4.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D4.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella5 = "") Then

                    My.Forms.frmHuellas.D5.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D5.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella6 = "") Then

                    My.Forms.frmHuellas.D6.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D6.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella7 = "") Then

                    My.Forms.frmHuellas.D7.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D7.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella8 = "") Then

                    My.Forms.frmHuellas.D8.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D8.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella9 = "") Then

                    My.Forms.frmHuellas.D9.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D9.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella10 = "") Then

                    My.Forms.frmHuellas.D10.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D10.BackColor = Color.Transparent

                End If

                HUELLA.dispose()
                HUELLA = Nothing

            End If

            ' *********************************************************************

            frmHuellas.MdiParent = My.Forms.mdiOrthoSoft
            'Display the new form.
            frmHuellas.Show()
            frmHuellas.Activate()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbtipodoc_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipodoc_pac.TextChanged
        Me.ErrorProvider.SetError(Me.cmbtipodoc_pac, "")
    End Sub

    Private Sub txtdedoc_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdedoc_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtdedoc_pac, "")
    End Sub

    Private Sub txtnumdoc_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumdoc_pac.TextChanged
        Me.ErrorProvider.SetError(Me.txtnumdoc_pac, "")
    End Sub

    Private Sub btnNoEmail_Padre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail_Padre.Click
        Me.txtemailPadre_pac.Text = "notiene@"
    End Sub

    Private Sub btnNoEmail_Madre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail_Madre.Click
        Me.txtemailMadre_pac.Text = "notiene@"
    End Sub

    Private Sub btnNoEmail_Acudiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail_Acudiente.Click
        Me.txtemailAcudiente_pac.Text = "notiene@"
    End Sub

    Private Sub btnNoEmail_Conyuge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail_Conyuge.Click
        Me.txtemailConyuge_pac.Text = "notiene@"
    End Sub
End Class
