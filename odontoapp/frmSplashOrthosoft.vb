Public Class frmSplashOrthosoft

    Private CONS As CLASE_CONSULTORIO
    Private SCHE As CLASE_SCHEDULER
    Private GENE As CLASE_GENERAL
    Private DOC As CLASE_DOCTORES

    Private fecha As Date

    Private intBarra As Integer = 0
    Private dblTransparencia As Double = 0.0

    Private Sub frmSplashOrthosoft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'user = System.Environment.UserName
        Me.prgBarraProgreso.Text = "Bienvenido " & System.Environment.UserName & ". Espere a que se cargue la aplicación ..."
        Me.prgBarraProgreso.Refresh()

        ' Aplicar el efecto
        Me.prgBarraProgreso.Value = 0

        Timer1.Enabled = True
        Timer1.Interval = 100

    End Sub

    Private Sub cargardatosiniciales()

        Try

            Me.prgBarraProgreso.Text = "Montando Imagen inicial"
            Me.prgBarraProgreso.Refresh()

            'Set the Parent Form of the Child window.
            frmInicio.MdiParent = My.Forms.mdiOrthoSoft
            'Display the new form.
            frmInicio.Show()
            frmInicio.Activate()

            ' Guardamos la resolución Actual para revertirlas cuando salgamos de la aplicacion
            CLASE_GENERAL.xheigth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
            CLASE_GENERAL.xwidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width

            'Utilizamos La Funcion Para cambiar la resolucion lo hacemos pora que la mayoria de las
            'pantallas puedan visualizar correctamente la disposicion de los controles
            Me.prgBarraProgreso.Text = "Cambiando Resolucion de Pantalla"
            Me.prgBarraProgreso.Refresh()

            'CambiarResolucion.cambiarresolucion(1024, 768, 32)


            '******************************* CONFIGURACION DE LA CLINICA **************************
            Me.prgBarraProgreso.Text = "Cargando datos iniciales de la clinica"
            Me.prgBarraProgreso.Refresh()

            CONS = New CLASE_CONSULTORIO
            GENE = New CLASE_GENERAL

            CONS.p_Idconsultorio = 1
            CONS.Seleccionar("consultorio")

            CLASE_GENERAL._Idconsultorio = CLASE_CONSULTORIO.xIdconsultorio
            CLASE_GENERAL._razonsocial_cons = CLASE_CONSULTORIO.xrazonsocial_cons
            CLASE_GENERAL._nit_cons = CLASE_CONSULTORIO.xnit_cons
            CLASE_GENERAL._direccion_cons = CLASE_CONSULTORIO.xdireccion_cons
            CLASE_GENERAL._web_cons = CLASE_CONSULTORIO.xweb_cons
            CLASE_GENERAL._email_cons = CLASE_CONSULTORIO.xemail_cons
            CLASE_GENERAL._actividad_cons = CLASE_CONSULTORIO.xactividad_cons
            CLASE_GENERAL._rtelegal_cons = CLASE_CONSULTORIO.xrtelegal_cons
            CLASE_GENERAL._documento_cons = CLASE_CONSULTORIO.xdocumento_cons
            CLASE_GENERAL._ciudaddoc_cons = CLASE_CONSULTORIO.xciudaddoc_cons
            CLASE_GENERAL._tel1_cons = CLASE_CONSULTORIO.xtel1_cons
            CLASE_GENERAL._tel2_cons = CLASE_CONSULTORIO.xtel2_cons
            CLASE_GENERAL._celular_cons = CLASE_CONSULTORIO.xcelular_cons
            CLASE_GENERAL._fax_cons = CLASE_CONSULTORIO.xfax_cons
            CLASE_GENERAL._Iddoctor = CLASE_CONSULTORIO.xIddoctor
            CLASE_GENERAL._horaini = CLASE_CONSULTORIO.xhoraini
            CLASE_GENERAL._horafin = CLASE_CONSULTORIO.xhorafin
            CLASE_GENERAL._rangocal = CLASE_CONSULTORIO.xrangocal
            CLASE_GENERAL._tipocallcenter_cons = CLASE_CONSULTORIO.xtipocallcenter_cons
            CLASE_GENERAL._textopiecita = CLASE_CONSULTORIO.xtextopiecita
            CLASE_GENERAL._topecita = CLASE_CONSULTORIO.xtopecita
            CLASE_GENERAL._formatopos = CLASE_CONSULTORIO.xformatopos

            If Not (CLASE_CONSULTORIO.xicono_cons.Length = 0) Then

                CLASE_GENERAL._icono_cons = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xicono_cons)

            End If


            CONS.dispose()
            CONS = Nothing

            '****************************** CONFIGURACIONES INICIALES POR DEFECTO *****************************

            GENE = New CLASE_GENERAL

            Me.prgBarraProgreso.Text = "Cargando datos iniciales de citas"
            Me.prgBarraProgreso.Refresh()

            My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Date = DateTime.Today

            My.Forms.mdiOrthoSoft.clcStartTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horaini), Minute(CLASE_GENERAL._horaini), Second(CLASE_GENERAL._horaini), 0)
            My.Forms.mdiOrthoSoft.clcEndTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horafin), Minute(CLASE_GENERAL._horafin), Second(CLASE_GENERAL._horafin), 0)
            My.Forms.mdiOrthoSoft.StartTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horaini), Minute(CLASE_GENERAL._horaini), Second(CLASE_GENERAL._horaini), 0)
            My.Forms.mdiOrthoSoft.EndTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horafin), Minute(CLASE_GENERAL._horafin), Second(CLASE_GENERAL._horafin), 0)

            Select Case CLASE_GENERAL._rangocal
                Case "5"
                    My.Forms.mdiOrthoSoft.rbt5min.Checked = True
                Case "10"
                    My.Forms.mdiOrthoSoft.rbt10min.Checked = True
                Case "15"
                    My.Forms.mdiOrthoSoft.rbt15min.Checked = True
                Case "30"
                    My.Forms.mdiOrthoSoft.rbt30min.Checked = True
            End Select

            My.Forms.mdiOrthoSoft.txtfechahoy.Text = UCase(Format(Date.Today, "Long Date"))

            '********************************** CARGAMOS EL DOCTOR ACTIVO ************************

            Me.prgBarraProgreso.Text = "Configurando Doctor Activo"
            Me.prgBarraProgreso.Refresh()

            CLASE_GENERAL.cargar_combo("doctores", My.Forms.mdiOrthoSoft.cmbDoctores, CLASE_GENERAL.mensaje_error)
            My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue = CLASE_GENERAL._Iddoctor
            My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = My.Forms.mdiOrthoSoft.cmbDoctores.Text
            My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue

            '**************************** CARGAMOS LOS TIPOS DE CONSULTA **************************

            'Cargamos los tipos de consulta de acuerdo al doctor y su especialidad

            DOC = New CLASE_DOCTORES
            DOC.p_Iddoctor = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue
            DOC.Seleccionar("especialidad")

            CLASE_GENERAL.cargar_combo("tipoconsultadoctores", My.Forms.mdiOrthoSoft.cmbTipoConsulta, CLASE_DOCTORES.xIdespecialidad)

            DOC.dispose()
            DOC = Nothing

            '**************************** CARGAMOS EL CALENDARIO DEL SCHEDULER ********************

            Me.prgBarraProgreso.Text = "Actualizando calendario"
            Me.prgBarraProgreso.Refresh()

            fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

            SCHE = New CLASE_SCHEDULER
            SCHE.llenadoscheduler(fecha)
            SCHE = Nothing

            GENE = Nothing

        Catch ex As Exception

            Me.Close()
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        intBarra += 4
        'prgBarraProgreso.Text = "Cargando la aplicación, por favor espere ..."
        prgBarraProgreso.Value = intBarra
        Me.prgBarraProgreso.Refresh()

        If prgBarraProgreso.Value = 100 Then

            Timer1.Stop()
            Timer1.Enabled = False
            cargardatosiniciales()
            My.Forms.mdiOrthoSoft.Show()
            Me.Close()

        End If

        'dblTransparencia += 0.1
        'If dblTransparencia <> 1 Then
        '    Me.Opacity = dblTransparencia
        'End If

    End Sub

   
End Class