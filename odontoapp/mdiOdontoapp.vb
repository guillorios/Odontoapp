Imports Janus.Windows.Schedule
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports System.Math

Delegate Sub FunctionCall(ByVal param)

<System.Serializable()> Public Class mdiOrthoSoft

    Inherits System.Windows.Forms.Form

    Private EVEN As CLASE_EVENTOS
    Private CONS As CLASE_CONSULTORIO
    Private PAC As CLASE_PACIENTES
    Private DOC As CLASE_DOCTORES
    Private GENE As CLASE_GENERAL
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS
    Private CAL As CLASE_CALENDARIO
    Private CITA As CLASE_CITAS
    Private SCHE As CLASE_SCHEDULER
    Private EMP As CLASE_EMPLEADOS
    Private CTRL As CLASE_CONTROL
    Private CONSULTA As CLASE_CONSULTA
    Private CONSUL As CLASE_CONSULTORIO
    Private OPERADOR As CLASE_OPERADOR
    Private ASIGNAR_PERFILES As CLASE_ASIGNAR_PERFILES

    'Clases para la Historia Clinica
    Private HC As CLASE_HCLINICA
    Private HCEF As CLASE_HCLINICA_EFISICO
    Private HCP2 As CLASE_HCLINICA_P2
    Private HCP3 As CLASE_HCLINICA_P3
    Private HCP4 As CLASE_HCLINICA_P4

    Private HCORTO2 As CLASE_HCLINICA_ORTO2
    Private HCORTO3 As CLASE_HCLINICA_ORTO3
    Private HCGENE As CLASE_HCLINICA_GENERAL

    'Variable de Clases
    Public HUELLA As CLASE_HUELLAS

    'Varibles de control
    Private indice As String
    Private control As Boolean = False
    Private iniciando As Boolean = True
    Private bandera As Integer = 1
    Private Idpaciente As Integer

    ' Variables de las Huellas
    Public huellita1 As DPFP.Template
    Public huellita2 As DPFP.Template
    Public huellita3 As DPFP.Template
    Public huellita4 As DPFP.Template
    Public huellita5 As DPFP.Template
    Public huellita6 As DPFP.Template
    Public huellita7 As DPFP.Template
    Public huellita8 As DPFP.Template
    Public huellita9 As DPFP.Template
    Public huellita10 As DPFP.Template
    Public huellitaaux As DPFP.Template

    'Variables de templates
    Private Data As AppData
    Public WithEvents AppData As AppData


    'Otras Variables Auxiliares
    Private myReport As New ReportDocument

    Private pt32 As POINTAPI
    Private ptx As Integer
    Private pty As Integer

    Private mINI As New cIniArray
    Private sFicINI As String

    Private fecha As Date
    Private contar As Integer

    Private iImagen As Image

    Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer

    Private Structure POINTAPI

        Dim X As Integer
        Dim Y As Integer

    End Structure

    Dim contador As Short

    Private Sub OnDataChange()
        ExchangeData(False)
    End Sub

    Private Sub ExchangeData(ByVal read As Boolean)

        Data.EnrolledFingersMask = 0
        Data.MaxEnrollFingerCount = 10
        Data.IsEventHandlerSucceeds = True
        Data.Update()

    End Sub

    Private Sub cargarhuellitas(ByVal Idusuario As Integer)

        Try

            ' ------------------ Inicializamos los Objetos de la BD ----------------------

            huellita1 = New DPFP.Template
            huellita2 = New DPFP.Template
            huellita3 = New DPFP.Template
            huellita4 = New DPFP.Template
            huellita5 = New DPFP.Template
            huellita6 = New DPFP.Template
            huellita7 = New DPFP.Template
            huellita8 = New DPFP.Template
            huellita9 = New DPFP.Template
            huellita10 = New DPFP.Template

            '------------------- Cargamos los Datos de la Cuenta ----------------

            Data = New AppData()

            HUELLA.p_IdUsuario = Idusuario
            HUELLA.p_IdTUsuario = 1 ' Tipo Paciente

            HUELLA.Seleccionar("todos")

            If Not (CLASE_HUELLAS.xhuella1 = "") Then

                huellita1.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella1))
                Data.Templates(0) = huellita1

            End If

            If Not (CLASE_HUELLAS.xhuella2 = "") Then

                huellita2.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella2))
                Data.Templates(1) = huellita2

            End If

            If Not (CLASE_HUELLAS.xhuella3 = "") Then

                huellita3.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella3))
                Data.Templates(2) = huellita3

            End If

            If Not (CLASE_HUELLAS.xhuella4 = "") Then

                huellita4.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella4))
                Data.Templates(3) = huellita4

            End If

            If Not (CLASE_HUELLAS.xhuella5 = "") Then

                huellita5.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella5))
                Data.Templates(4) = huellita5

            End If

            If Not (CLASE_HUELLAS.xhuella6 = "") Then

                huellita6.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella6))
                Data.Templates(5) = huellita6

            End If

            If Not (CLASE_HUELLAS.xhuella7 = "") Then

                huellita7.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella7))
                Data.Templates(6) = huellita7

            End If

            If Not (CLASE_HUELLAS.xhuella8 = "") Then

                huellita8.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella8))
                Data.Templates(7) = huellita8

            End If

            If Not (CLASE_HUELLAS.xhuella9 = "") Then

                huellita9.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella9))
                Data.Templates(8) = huellita9

            End If

            If Not (CLASE_HUELLAS.xhuella10 = "") Then

                huellita10.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella10))
                Data.Templates(9) = huellita10

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Shared Function StringToByteArray(ByVal hex As String) As Byte()

        Dim NumberChars As Integer = hex.Length
        Dim bytes As Byte() = New Byte(NumberChars / 2 - 1) {}
        For i As Integer = 0 To NumberChars - 1 Step 2
            bytes(i / 2) = Convert.ToByte(hex.Substring(i, 2), 16)
        Next
        Return (bytes)

    End Function

    Private Sub mnuNuevoPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevoPaciente.Click

        Try

            'Set the Parent Form of the Child window.
            frmPacientes.MdiParent = Me
            'Display the new form.
            frmPacientes.Show()
            frmPacientes.Activate()

            CLASE_GENERAL.formload = 1 ' Nos Indica que formulario esta activo

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarpacientes")
            EVEN.limpiar("limpiarficha")
            EVEN.limpiar("limpiaractivopaciente")
            EVEN.bloquaerdesbloquear("nuevopaciente")

            EVEN = Nothing

            My.Forms.frmPacientes.txtIdpaciente.Text = (CLASE_GENERAL.maximo("IdPaciente", "pacientes", CLASE_GENERAL.mensaje_error)) + 1

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub mnuBuscarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscarPaciente.Click

        ' Cerramos todos las ventanas que intervenga informacion de un usuario

        For Each frm As Form In Me.MdiChildren

            If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Then
                frm.Close()
            End If

        Next

        'Set the Parent Form of the Child window.
        frmBuscarPacientes.MdiParent = Me
        'Display the new form.
        frmBuscarPacientes.Show()
        frmBuscarPacientes.Activate()

    End Sub

    Private Sub mnuNuevoDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevoDoctor.Click

        Try

            'Set the Parent Form of the Child window.
            frmDoctores.MdiParent = Me
            'Display the new form.
            frmDoctores.Show()
            frmDoctores.Activate()

            CLASE_GENERAL.formload = 2 ' Nos Indica que formulario esta activo

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiardoctores")
            EVEN.limpiar("limpiarficha")
            EVEN.bloquaerdesbloquear("nuevodoctor")

            EVEN = Nothing

            My.Forms.frmDoctores.txtIddoctor.Text = (CLASE_GENERAL.maximo("IdDoctor", "doctores", CLASE_GENERAL.mensaje_error)) + 1

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub mnuBuscarDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscarDoctor.Click

        'Set the Parent Form of the Child window.
        frmBuscarDoctores.MdiParent = Me
        'Display the new form.
        frmBuscarDoctores.Show()
        frmBuscarDoctores.Activate()

    End Sub

    Private Sub mdiOrthoSoft_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Clase_general.terminar(Clase_general.mensaje_error)
        Me.ScheduleOrhosoft.Appointments.Clear()
        Me.ScheduleOrhosoft.Dispose()

        'Restauramos la aplicacion a la resolucion de pantalla original 
        'CambiarResolucion.cambiarresolucion(CLASE_GENERAL.xwidth, CLASE_GENERAL.xheigth, 32)

        End

    End Sub

    Private Sub mnuAutenticacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAutenticacion.Click

        frmAutenticacion.MdiParent = Me
        'Display the new form.
        frmAutenticacion.Show()
        frmAutenticacion.Activate()

    End Sub

    Private Sub mnuInfAuditoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInfAuditoria.Click

        frmAuditoria.MdiParent = Me
        'Display the new form.
        frmAuditoria.Show()
        frmAuditoria.Activate()

    End Sub

    Private Sub mnuNuevaEntidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevaEntidad.Click

        Try

            frmEntidades.MdiParent = Me
            'Display the new form.
            frmEntidades.Show()
            frmEntidades.Activate()

            CLASE_GENERAL.formload = 4 ' Nos Indica que formulario esta activo


            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarentidades")
            EVEN.limpiar("limpiarficha")
            EVEN.bloquaerdesbloquear("nuevaentidad")

            EVEN = Nothing

            My.Forms.frmEntidades.txtIdentidad.Text = (CLASE_GENERAL.maximo("Identidad", "entidades", CLASE_GENERAL.mensaje_error)) + 1

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub mnuBuscarEntidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscarEntidad.Click

        frmBuscarEntidad.MdiParent = Me
        'Display the new form.
        frmBuscarEntidad.Show()
        frmBuscarEntidad.Activate()

    End Sub

    Private Sub mnuImporBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImporBD.Click

        frmConvertirTabla.MdiParent = Me
        'Display the new form.
        frmConvertirTabla.Show()
        frmConvertirTabla.Activate()

    End Sub

    Private Sub rbt5min_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt5min.CheckedChanged

        Me.ScheduleOrhosoft.Interval = Janus.Windows.Schedule.Interval.FiveMinutes
        Me.ScheduleOrhosoft.FirstVisibleTime = Me.ScheduleOrhosoft.WorkStartTime

    End Sub

    Private Sub rbt10min_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt10min.CheckedChanged

        Me.ScheduleOrhosoft.Interval = Janus.Windows.Schedule.Interval.TenMinutes
        Me.ScheduleOrhosoft.FirstVisibleTime = Me.ScheduleOrhosoft.WorkStartTime

    End Sub

    Private Sub rbt15min_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt15min.CheckedChanged

        Me.ScheduleOrhosoft.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
        Me.ScheduleOrhosoft.FirstVisibleTime = Me.ScheduleOrhosoft.WorkStartTime

    End Sub

    Private Sub rbt30min_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbt30min.CheckedChanged

        Me.ScheduleOrhosoft.Interval = Janus.Windows.Schedule.Interval.ThirtyMinutes
        Me.ScheduleOrhosoft.FirstVisibleTime = Me.ScheduleOrhosoft.WorkStartTime

    End Sub

    Private Sub ScheduleOrhosoft_AppointmentChanged(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AppointmentChangeEventArgs) Handles ScheduleOrhosoft.AppointmentChanged

        Try

            If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

                Me.SelectedAppointmentChanged2(Me.ScheduleOrhosoft.SelectedAppointments(0))

            Else

                Me.SelectedAppointmentChanged2(Nothing)

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub ScheduleOrhosoft_AppointmentDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleOrhosoft.AppointmentDoubleClick

        Try

            Dim WorkStartTime As Date
            Dim WorkEndTime As Date

            Dim AppStartTime As Date
            Dim AppEndTime As Date

            WorkStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.WorkStartTime.ToString), Minute(Me.ScheduleOrhosoft.WorkStartTime.ToString), 0, 0)
            AppStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.CurrentAppointment.StartTime.ToString), Minute(Me.ScheduleOrhosoft.CurrentAppointment.StartTime.ToString), 0, 0)

            WorkEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.WorkEndTime.ToString), Minute(Me.ScheduleOrhosoft.WorkEndTime.ToString), 0, 0)
            AppEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.CurrentAppointment.EndTime.ToString), Minute(Me.ScheduleOrhosoft.CurrentAppointment.EndTime.ToString), 0, 0)

            fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

            If fecha >= DateTime.Today Then

                If (AppStartTime < WorkStartTime) Or (AppEndTime > WorkEndTime) Then

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("bloquearscheduler")
                    EVEN = Nothing

                    Me.ScheduleOrhosoft.CurrentAppointment.Delete()
                    MsgBox("Este Rango de Hora no esta permitido, si quiere habilitarlo modifique el calendario ", MsgBoxStyle.OkOnly, "Citas")


                Else

                    If Me.lblActivoDoctor.Text = "" Then

                        Me.ScheduleOrhosoft.CurrentAppointment.Delete()


                        EVEN = New CLASE_EVENTOS
                        EVEN.bloquaerdesbloquear("bloquearscheduler")
                        EVEN = Nothing


                        MsgBox("No hay Doctor Activo escojalo por favor", MsgBoxStyle.OkOnly, "Citas")

                    Else

                        If Me.lblActivoPaciente.Text = "" Then

                            Me.ScheduleOrhosoft.CurrentAppointment.Delete()

                            EVEN = New CLASE_EVENTOS
                            EVEN.bloquaerdesbloquear("bloquearscheduler")
                            EVEN = Nothing

                            MsgBox("No hay Paciente Activo escojalo por favor", MsgBoxStyle.OkOnly, "Citas")

                        Else

                            If Me.PnlActivoPaciente.Style.BackColor2 = Color.Salmon Then

                                Me.ScheduleOrhosoft.CurrentAppointment.Delete()

                                EVEN = New CLASE_EVENTOS
                                EVEN.bloquaerdesbloquear("bloquearscheduler")
                                EVEN = Nothing

                                MsgBox("El Paciente esta bloqueado", MsgBoxStyle.OkOnly, "Citas")


                            Else

                                If Me.PnlActivoPaciente.Style.BackColor2 = Color.Khaki Then

                                    Me.ScheduleOrhosoft.CurrentAppointment.Delete()

                                    EVEN = New CLASE_EVENTOS
                                    EVEN.bloquaerdesbloquear("bloquearscheduler")
                                    EVEN = Nothing

                                    MsgBox("El Paciente esta Retirado", MsgBoxStyle.OkOnly, "Citas")


                                Else

                                    If CInt(Me.lblTotalPacientes.Text) >= CInt(Me.txtTopeCita.Text) Then

                                        Me.ScheduleOrhosoft.CurrentAppointment.Delete()

                                        EVEN = New CLASE_EVENTOS
                                        EVEN.bloquaerdesbloquear("bloquearscheduler")
                                        EVEN = Nothing

                                        MsgBox("No se puede adicionar mas registros, El tope de cita llego a su limite", MsgBoxStyle.OkOnly, "Citas")

                                    Else

                                        Me.txtIdcita.Text = Me.txtIdcita.Text + 1
                                        Me.ScheduleOrhosoft.CurrentAppointment.Text = Me.lblActivoPaciente.Tag & ", " & Me.lblActivoPaciente.Text
                                        Me.ScheduleOrhosoft.CurrentAppointment.Tag = Me.txtIdcita.Text
                                        Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 0

                                        Me.GroupTipoConsulta.Enabled = True
                                        Me.GroupNotaCita.Enabled = True

                                        EVEN = New CLASE_EVENTOS
                                        EVEN.limpiar("limpiarschedulernuevo")
                                        EVEN = Nothing

                                        Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex2 = 3
                                        Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex3 = 5
                                        Me.ScheduleOrhosoft.CurrentAppointment.FormatStyle.BackColor = Drawing.Color.LimeGreen
                                        Me.ScheduleOrhosoft.CurrentAppointment.FormatStyle.BackColorGradient = Drawing.Color.White
                                        Me.ScheduleOrhosoft.CurrentAppointment.FormatStyle.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
                                        Me.ScheduleOrhosoft.CurrentAppointment.BorderColor = Drawing.Color.LimeGreen

                                        EVEN = New CLASE_EVENTOS
                                        EVEN.bloquaerdesbloquear("nuevoscheduler")
                                        EVEN.bloquaerdesbloquear("bloquearcita")
                                        EVEN = Nothing

                                        Dim respuesta As Integer
                                        respuesta = MsgBox("Desea Agregar esta cita ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                                        If respuesta = MsgBoxResult.Yes Then

                                            adicionarcita()

                                        End If

                                    End If

                                End If

                            End If

                        End If

                    End If

                End If

            Else

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("bloquearscheduler")
                EVEN = Nothing

                Me.ScheduleOrhosoft.CurrentAppointment.Delete()
                MsgBox("No se pueden asignar citas en fecha pasada, revise por favor  ", MsgBoxStyle.OkOnly, "Citas")


            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub


    Private Sub btnOpCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpCalendar.Click

        Try
            'Set the Parent Form of the Child window.
            frmCalendarioPaciente.MdiParent = Me
            'Display the new form.
            frmCalendarioPaciente.Show()
            frmCalendarioPaciente.Activate()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub mnuNuevoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevoUsuario.Click

        Try

            frmUsuarios.MdiParent = Me
            'Display the new form.
            frmUsuarios.Show()
            frmUsuarios.Activate()

            CLASE_GENERAL.formload = 3 ' Nos Indica que formulario esta activo

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarempleados")
            EVEN.limpiar("limpiarficha")
            EVEN.bloquaerdesbloquear("nuevoempleado")


            EVEN = Nothing

            My.Forms.frmUsuarios.txtIdempleado.Text = (CLASE_GENERAL.maximo("Idempleado", "empleados", CLASE_GENERAL.mensaje_error)) + 1

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub mnuBuscarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscarUsuario.Click

        frmBuscarEmpleados.MdiParent = Me
        'Display the new form.
        frmBuscarEmpleados.Show()
        frmBuscarEmpleados.Activate()

    End Sub

    Private Sub btnAvanzarMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvanzarMes.Click

        Try

            Me.CalOrthosoft.NextMonth()

            fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

            SCHE = New CLASE_SCHEDULER
            SCHE.llenadoscheduler(fecha)
            SCHE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnRetrocedermes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrocedermes.Click

        Try

            Me.CalOrthosoft.LastMonth()

            fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

            SCHE = New CLASE_SCHEDULER
            SCHE.llenadoscheduler(fecha)
            SCHE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Sub btnCalAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalAdicionar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Registrar la Modificacion de la fecha ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Calendario")

        If respuesta = 6 Then

            Try

                CAL = New CLASE_CALENDARIO

                'Asignamos los valores a las variables de la clase calendario

                CAL.p_Idcalendario = Me.txtIdCalendario.Text
                CAL.p_fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CAL.p_horaini = Format(Me.StartTime.Value, "HH:mm:ss")
                CAL.p_horafin = Format(Me.EndTime.Value, "HH:mm:ss")

                If Me.rbtFestivo.Checked = True Then
                    CAL.p_Idcontroldia = 1
                ElseIf Me.rbtNolaborable.Checked = True Then
                    CAL.p_Idcontroldia = 2
                ElseIf Me.rbtModificado.Checked = True Then
                    CAL.p_Idcontroldia = 3
                End If

                CAL.p_Iddoctor = Me.cmbDoctores.SelectedValue

                If Me.rbtConfig5min.Checked = True Then
                    CAL.p_rangocal = "5"
                ElseIf Me.rbtConfig10min.Checked = True Then
                    CAL.p_rangocal = "10"
                ElseIf Me.rbtConfig15min.Checked = True Then
                    CAL.p_rangocal = "15"
                ElseIf Me.rbtConfig30min.Checked = True Then
                    CAL.p_rangocal = "30"
                End If

                CAL.p_topecita = Me.txtTopeCita.Text

                '********* MODIFICACION DE TEXTOS (Idcalendario) EN EL CALENDARIO Y ASIGNACION DE COLORES *******************

                Me.CalOrthosoft.set_DateText2(Me.CalOrthosoft.Day, Me.txtIdCalendario.Text)


                If Me.rbtFestivo.Checked = True Then
                    Me.CalOrthosoft.set_DateColor(Me.CalOrthosoft.Day, &HFFFF&) 'Set the background color From gradient color 
                ElseIf Me.rbtNolaborable.Checked = True Then
                    Me.CalOrthosoft.set_DateColor(Me.CalOrthosoft.Day, &HFF&) 'Set the background color From gradient color 
                ElseIf Me.rbtModificado.Checked = True Then
                    Me.CalOrthosoft.set_DateColor(Me.CalOrthosoft.Day, &HFF8080&) 'Set the background color From gradient color 
                End If


                '*************** INSERTAMOS REGISTROS EN LA BASE DE DATOS **********************

                CAL.Insertar(CLASE_GENERAL.mensaje_error)
                CAL.dispose() ' Liberamos recursos
                CAL = Nothing

                '*************** LLENAMOS EL SCHEDULER ******************************************

                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

                SCHE = New CLASE_SCHEDULER
                SCHE.llenadoscheduler(fecha)
                SCHE = Nothing

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 9 '9 Edita Calendario Paciente
                CTRL.p_Idproceso = Me.txtIdCalendario.Text

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing


                MsgBox("Modificacion Día registrada con Exito", MsgBoxStyle.OkOnly, "Calendario")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnCalModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalModificar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar el Día", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Calendario")

        If respuesta = 6 Then

            Try

                CAL = New CLASE_CALENDARIO

                'Asignamos los valores a las variables de la clase Calendario


                CAL.p_Idcalendario = Me.txtIdCalendario.Text
                CAL.p_fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CAL.p_horaini = Format(Me.StartTime.Value, "HH:mm:ss")
                CAL.p_horafin = Format(Me.EndTime.Value, "HH:mm:ss")

                If Me.rbtFestivo.Checked = True Then
                    CAL.p_Idcontroldia = 1
                ElseIf Me.rbtNolaborable.Checked = True Then
                    CAL.p_Idcontroldia = 2
                ElseIf Me.rbtModificado.Checked = True Then
                    CAL.p_Idcontroldia = 3
                End If

                CAL.p_Iddoctor = Me.cmbDoctores.SelectedValue

                If Me.rbtConfig5min.Checked = True Then
                    CAL.p_rangocal = "5"
                ElseIf Me.rbtConfig10min.Checked = True Then
                    CAL.p_rangocal = "10"
                ElseIf Me.rbtConfig15min.Checked = True Then
                    CAL.p_rangocal = "15"
                ElseIf Me.rbtConfig30min.Checked = True Then
                    CAL.p_rangocal = "30"
                End If

                CAL.p_topecita = Me.txtTopeCita.Text

                '********* MODIFICACION DE TEXTOS (Idcalendario) EN EL CALENDARIO Y ASIGNACION DE COLORES *******************

                Me.CalOrthosoft.set_DateText2(Me.CalOrthosoft.Day, Me.txtIdCalendario.Text)

                If Me.rbtFestivo.Checked = True Then
                    Me.CalOrthosoft.set_DateColor(Me.CalOrthosoft.Day, &HFFFF&) 'Set the background color From gradient color 
                ElseIf Me.rbtNolaborable.Checked = True Then
                    Me.CalOrthosoft.set_DateColor(Me.CalOrthosoft.Day, &HFF&) 'Set the background color From gradient color 
                ElseIf Me.rbtModificado.Checked = True Then
                    Me.CalOrthosoft.set_DateColor(Me.CalOrthosoft.Day, &HFF8080&) 'Set the background color From gradient color 
                End If


                'Insertamos en la base de datos
                CAL.Modificar("registro")
                CAL.dispose() ' Liberamos recursos
                CAL = Nothing

                '*************** LLENAMOS EL SCHEDULER ******************************************

                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

                SCHE = New CLASE_SCHEDULER
                SCHE.llenadoscheduler(fecha)
                SCHE = Nothing

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 9 '9 Edita Calendario Paciente
                CTRL.p_Idproceso = Me.txtIdCalendario.Text

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                MsgBox("Modificacion Día realizada con Exito", MsgBoxStyle.OkOnly, "Pacientes")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If
    End Sub

    Private Sub btnCalEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar La Modificación del día", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Calendario")

        If respuesta = 6 Then

            Try

                CAL = New CLASE_CALENDARIO

                CAL.p_Idcalendario = Me.txtIdCalendario.Text
                CAL.Eliminar(CLASE_GENERAL.mensaje_error)
                CAL.dispose()
                CAL = Nothing

                Me.CalOrthosoft.set_DateColor(Me.CalOrthosoft.Day, &HFFC0C0&) 'Set the background color From gradient color to a light grey/blue
                Me.CalOrthosoft.set_DateText2(Me.CalOrthosoft.Day, "")

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 9 '9 Edita Calendario Paciente
                CTRL.p_Idproceso = Me.txtIdCalendario.Text

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                '*************** LLENAMOS EL SCHEDULER ******************************************

                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

                SCHE = New CLASE_SCHEDULER
                SCHE.llenadoscheduler(fecha)
                SCHE = Nothing

                MsgBox("Registro Eliminado con Exito", MsgBoxStyle.OkOnly, "Calendario")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If

    End Sub


    Public Sub btnDocSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocSeleccionar.Click

        Try

            If Me.cmbDoctores.Text = "" Then

                MsgBox("No Hay Doctor Activo escojalo por favor", MsgBoxStyle.OkOnly, "Calendario")

            Else

                Me.lblActivoDoctor.Text = Me.cmbDoctores.Text
                Me.lblActivoDoctor.Tag = Me.cmbDoctores.SelectedValue

                'Cargamos los procedimientos del doctor activo

                DOC = New CLASE_DOCTORES
                DOC.p_Iddoctor = Me.cmbDoctores.SelectedValue
                DOC.Seleccionar("especialidad")

                CLASE_GENERAL.cargar_combo("tipoconsultadoctores", Me.cmbTipoConsulta, CLASE_DOCTORES.xIdespecialidad)

                DOC.dispose()
                DOC = Nothing

                'Llenamos la agenda

                SCHE = New CLASE_SCHEDULER

                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                SCHE.llenadoscheduler(fecha)

                SCHE = Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub ScheduleOrhosoft_SelectedAppointmentsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScheduleOrhosoft.SelectedAppointmentsChanged

        Try

            If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

                Me.SelectedAppointmentChanged(Me.ScheduleOrhosoft.SelectedAppointments(0))

            Else

                Me.SelectedAppointmentChanged(Nothing)


            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub SelectedAppointmentChanged(ByVal appointment As ScheduleAppointment)

        If Not appointment Is Nothing Then

            If Not (appointment.Text = "") Then


                '******************* CARGAMOS LOS DATOS EN LA FICHA ********************************

                '******************* CARGAMOS LOS DATOS DEL PACIENTE *******************************

                Dim y As Integer = appointment.Text.IndexOf(",")
                Dim Idpaciente As String
                Idpaciente = appointment.Text.Substring(0, y).TrimEnd()

                Me.ScheduleOrhosoft.ShowTimeHintOnAppointments = TimeHintOnAppointments.Always

                EVEN = New CLASE_EVENTOS
                EVEN.cargarpacienteficha(Idpaciente)
                EVEN = Nothing

                '*************************** verificamos que no sea un archivo para grabar **************************

                Me.txtIdPacienteTagScheduler.Text = appointment.Tag

                If appointment.ImageIndex1 = 0 Then

                    EVEN.bloquaerdesbloquear("nuevoscheduler")
                    EVEN.bloquaerdesbloquear("bloquearcita")
                    Me.GroupTipoConsulta.Enabled = True
                    Me.GroupNotaCita.Enabled = True

                Else

                    If appointment.ImageIndex1 = 1 Then

                        CITA = New CLASE_CITAS
                        CITA.p_Idcita = appointment.Tag
                        CITA.Seleccionar("cita")

                        'cargamos la consulta de acuerdo al color

                        CONSULTA = New CLASE_CONSULTA
                        CONSULTA.p_color = appointment.FormatStyle.BackColor.ToArgb
                        CONSULTA.Seleccionar("tipoconsulta3")

                        Me.cmbTipoConsulta.SelectedValue = CLASE_CONSULTA.xIdtconsulta
                        Me.lblTipoConsulta.BackColor = Color.FromArgb(CLASE_CONSULTA.xcolor)

                        CONSULTA.dispose()
                        CONSULTA = Nothing

                        If appointment.ImageIndex2 = 3 Then
                            Me.rbtCanceladaNo.Checked = True
                        Else
                            Me.rbtCanceladaSi.Checked = True
                        End If

                        If appointment.ImageIndex3 = 5 Then
                            Me.rbtAsistioNo.Checked = True
                        Else
                            Me.rbtAsistioSi.Checked = True
                        End If

                        Me.txtnotacita.Text = CLASE_CITAS.xnotacita

                        EVEN = New CLASE_EVENTOS
                        EVEN.bloquaerdesbloquear("editarscheduler")
                        EVEN.bloquaerdesbloquear("editarcita")
                        Me.GroupTipoConsulta.Enabled = True
                        Me.GroupNotaCita.Enabled = True

                        EVEN = Nothing

                        CITA.dispose()
                        CITA = Nothing

                    Else

                        '****************************CARGAMOS LA CONFIGURACION DEL SHEDULER Y DE LA CITA MISMA *************

                        CITA = New CLASE_CITAS
                        CITA.p_Idcita = appointment.Tag
                        CITA.Seleccionar("cita")

                        'cargamos la consulta de acuerdo al color

                        CONSULTA = New CLASE_CONSULTA
                        CONSULTA.p_Idtconsulta = CLASE_CITAS.xIdtconsulta
                        CONSULTA.Seleccionar("tipoconsulta1")

                        Me.cmbTipoConsulta.SelectedValue = CLASE_CONSULTA.xIdtconsulta
                        Me.lblTipoConsulta.BackColor = Color.FromArgb(CLASE_CONSULTA.xcolor)

                        CONSULTA.dispose()
                        CONSULTA = Nothing


                        If CLASE_CITAS.xcancelacion = "0" Then
                            Me.rbtCanceladaNo.Checked = True
                        Else
                            Me.rbtCanceladaSi.Checked = True
                        End If

                        If CLASE_CITAS.xasistencia = "0" Then
                            Me.rbtAsistioNo.Checked = True
                        Else
                            Me.rbtAsistioSi.Checked = True
                        End If

                        Me.txtnotacita.Text = CLASE_CITAS.xnotacita

                        EVEN = New CLASE_EVENTOS
                        EVEN.bloquaerdesbloquear("editarscheduler")
                        EVEN.bloquaerdesbloquear("editarcita")
                        Me.GroupTipoConsulta.Enabled = True
                        Me.GroupNotaCita.Enabled = True

                        CITA.dispose()
                        CITA = Nothing

                        EVEN = Nothing


                    End If

                End If

            End If


        Else

            EVEN = New CLASE_EVENTOS

            EVEN.bloquaerdesbloquear("bloquearscheduler")
            EVEN.bloquaerdesbloquear("bloquearcita")
            Me.GroupTipoConsulta.Enabled = False
            Me.GroupNotaCita.Enabled = False
            Me.txtnotacita.Text = ""
            Me.ScheduleOrhosoft.ShowTimeHintOnAppointments = TimeHintOnAppointments.Automatic

            EVEN = Nothing

        End If


    End Sub
    Private Sub adicionarcita()

        Try

            Dim WorkStartTime As Date
            Dim WorkEndTime As Date

            Dim AppStartTime As Date
            Dim AppEndTime As Date

            WorkStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.WorkStartTime.ToString), Minute(Me.ScheduleOrhosoft.WorkStartTime.ToString), 0, 0)
            AppStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.CurrentAppointment.StartTime.ToString), Minute(Me.ScheduleOrhosoft.CurrentAppointment.StartTime.ToString), 0, 0)

            WorkEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.WorkEndTime.ToString), Minute(Me.ScheduleOrhosoft.WorkEndTime.ToString), 0, 0)
            AppEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.CurrentAppointment.EndTime.ToString), Minute(Me.ScheduleOrhosoft.CurrentAppointment.EndTime.ToString), 0, 0)

            If (AppStartTime < WorkStartTime) Or (AppEndTime > WorkEndTime) Then


                MsgBox("Este Rango de Hora no esta permitido, si quiere habilitarlo modifique el calendario ", MsgBoxStyle.OkOnly, "Citas")


            Else

                If CInt(Me.lblTotalPacientes.Text) >= CInt(Me.txtTopeCita.Text) Then

                    Me.ScheduleOrhosoft.CurrentAppointment.Delete()

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("bloquearscheduler")
                    EVEN = Nothing

                    MsgBox("No se puede adicionar mas registros, El tope de cita llego a su limite", MsgBoxStyle.OkOnly, "Citas")

                Else

                    CITA = New CLASE_CITAS
                    EVEN = New CLASE_EVENTOS

                    'Asignamos los valores a las variables de la clase calendario
                    CITA.p_Idcita = Me.ScheduleOrhosoft.CurrentAppointment.Tag
                    CITA.p_fecha = Format(Me.ScheduleOrhosoft.CurrentAppointment.StartTime, "yyyy-MM-dd")
                    CITA.p_horaini = Format(Me.ScheduleOrhosoft.CurrentAppointment.StartTime, "HH:mm:ss")
                    CITA.p_horafin = Format(Me.ScheduleOrhosoft.CurrentAppointment.EndTime, "HH:mm:ss")

                    CITA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue

                    Dim i As Integer = Me.ScheduleOrhosoft.CurrentAppointment.Text.IndexOf(",")
                    Dim Idpaciente As String

                    Idpaciente = Me.ScheduleOrhosoft.CurrentAppointment.Text.Substring(0, i).TrimEnd()

                    CITA.p_Idpaciente = Idpaciente
                    CITA.p_Iddoctor = Me.cmbDoctores.SelectedValue

                    If Me.rbtCanceladaSi.Checked = True Then
                        CITA.p_cancelacion = "1"
                    ElseIf Me.rbtCanceladaNo.Checked = True Then
                        CITA.p_cancelacion = "0"
                    End If

                    If Me.rbtAsistioSi.Checked = True Then
                        CITA.p_asistencia = "1"
                    ElseIf Me.rbtAsistioNo.Checked = True Then
                        CITA.p_asistencia = "0"
                    End If

                    CITA.p_notacita = Me.txtnotacita.Text

                    '*************** INSERTAMOS REGISTROS EN LA BASE DE DATOS **********************

                    CITA.Insertar(CLASE_GENERAL.mensaje_error)
                    CITA.dispose() ' Liberamos recursos
                    CITA = Nothing

                    '*************** INGRESAMOS ASPECTOS DE CONTROL A LA CITA **********************

                    Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = -1
                    EVEN.bloquaerdesbloquear("editarcita")
                    EVEN.bloquaerdesbloquear("editarscheduler")

                    fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                    'contamos las citas de este día
                    Me.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                    Me.lblTotalPacientes.Text = CLASE_GENERAL.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), Me.cmbDoctores.SelectedValue)

                    '**************** Llenamos La Tabla Control *************************************

                    CTRL = New CLASE_CONTROL
                    CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                    CTRL.p_IdTRegistro = 1 '1 Asignar Cita
                    CTRL.p_Idproceso = Me.ScheduleOrhosoft.CurrentAppointment.Tag

                    CTRL.Insertar(CLASE_GENERAL.mensaje_error)

                    CTRL.dispose()
                    CTRL = Nothing

                    EVEN = Nothing

                    MsgBox("Cita registrada con Exito", MsgBoxStyle.OkOnly, "Citas")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
    Private Sub modificarcita()

        Try

            Dim WorkStartTime As Date
            Dim WorkEndTime As Date

            Dim AppStartTime As Date
            Dim AppEndTime As Date

            WorkStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.WorkStartTime.ToString), Minute(Me.ScheduleOrhosoft.WorkStartTime.ToString), 0, 0)
            AppStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.CurrentAppointment.StartTime.ToString), Minute(Me.ScheduleOrhosoft.CurrentAppointment.StartTime.ToString), 0, 0)

            WorkEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.WorkEndTime.ToString), Minute(Me.ScheduleOrhosoft.WorkEndTime.ToString), 0, 0)
            AppEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoft.CurrentAppointment.EndTime.ToString), Minute(Me.ScheduleOrhosoft.CurrentAppointment.EndTime.ToString), 0, 0)

            If (AppStartTime < WorkStartTime) Or (AppEndTime > WorkEndTime) Then


                MsgBox("Este Rango de Hora no esta permitido, si quiere habilitarlo modifique el calendario ", MsgBoxStyle.OkOnly, "Citas")


            Else


                CITA = New CLASE_CITAS
                CITA.p_Idcita = Me.ScheduleOrhosoft.CurrentAppointment.Tag
                CITA.p_fecha = Format(Me.ScheduleOrhosoft.CurrentAppointment.StartTime, "yyyy-MM-dd")
                CITA.p_horaini = Format(Me.ScheduleOrhosoft.CurrentAppointment.StartTime, "HH:mm:ss")
                CITA.p_horafin = Format(Me.ScheduleOrhosoft.CurrentAppointment.EndTime, "HH:mm:ss")

                CITA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue

                Dim i As Integer = Me.ScheduleOrhosoft.CurrentAppointment.Text.IndexOf(",")
                Dim Idpaciente As String
                Idpaciente = Me.ScheduleOrhosoft.CurrentAppointment.Text.Substring(0, i).TrimEnd()

                CITA.p_Idpaciente = Idpaciente
                CITA.p_Iddoctor = Me.cmbDoctores.SelectedValue

                If Me.rbtCanceladaSi.Checked = True Then
                    CITA.p_cancelacion = "1"
                ElseIf Me.rbtCanceladaNo.Checked = True Then
                    CITA.p_cancelacion = "0"
                End If

                If Me.rbtAsistioSi.Checked = True Then
                    CITA.p_asistencia = "1"
                ElseIf Me.rbtAsistioNo.Checked = True Then
                    CITA.p_asistencia = "0"
                End If

                CITA.p_notacita = Me.txtnotacita.Text

                CITA.Modificar(CLASE_GENERAL.mensaje_error)
                CITA.dispose() ' Liberamos recursos
                CITA = Nothing

                Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = -1

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 3 '1 Modificar Cita
                CTRL.p_Idproceso = Me.ScheduleOrhosoft.CurrentAppointment.Tag

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)

                CTRL.dispose()
                CTRL = Nothing

                MsgBox("Cita Modificada con Exito", MsgBoxStyle.OkOnly, "Citas")

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Public Sub btnCitaModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaModificar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar la Cita", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

        If respuesta = MsgBoxResult.Yes Then
            modificarcita()
        End If

    End Sub

    Private Sub btnCitaEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar La Cita", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

        If respuesta = MsgBoxResult.Yes Then

            Try

                CITA = New CLASE_CITAS

                CITA.p_Idcita = Me.ScheduleOrhosoft.CurrentAppointment.Tag
                CITA.Eliminar(CLASE_GENERAL.mensaje_error)
                CITA.dispose()
                CITA = Nothing

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 2 '1 Eliminar Cita
                CTRL.p_Idproceso = Me.ScheduleOrhosoft.CurrentAppointment.Tag

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                Me.ScheduleOrhosoft.CurrentAppointment.Delete()

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("bloquearscheduler")

                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                'contamos las citas de este día
                Me.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                Me.lblTotalPacientes.Text = CLASE_GENERAL.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), Me.cmbDoctores.SelectedValue)

                MsgBox("Cita Eliminada con Exito", MsgBoxStyle.OkOnly, "Citas")

                EVEN = Nothing

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If

    End Sub

    Public Sub btnCitaAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaAdicionar.Click

        adicionarcita()

    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click

        Try

            With SaveFileBackup
                ' Vea btnRetriveFileNames_Click para obtener una explicación de los valores predeterminados
                ' de las propiedades.

                ' Comprobar que el archivo seleccionado existe. El cuadro de diálogo muestra
                ' una advertencia en caso contrario.
                .CheckFileExists = False

                ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra 
                ' una advertencia en caso contrario.
                .CheckPathExists = True

                ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
                .DefaultExt = "sql"

                ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo
                ' seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
                .DereferenceLinks = True

                ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada
                ' par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario
                ' poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el
                ' filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
                .Filter = "Archivos de Copia de Seguridad (*.sql)|*.sql"

                .InitialDirectory = "c:/backups"

                ' ¿Restaurar el directorio original después de seleccionar
                ' un archivo? Si False, el directorio actual cambia
                ' al directorio en el que seleccionó el archivo.
                ' Establézcalo como True para poner la carpeta actual de nuevo
                ' donde estaba cuando comenzó.
                ' El valor predeterminado es False.
                .RestoreDirectory = True

                ' ¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
                .ShowHelp = False


                ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
                ' Esto sólo tiene sentido si ShowReadOnly es True.

                .Title = "Guardar Archivo de Seguridad"

                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
                .ValidateNames = True

                .FileName = "ORTHOSOFT-" & Format(Now(), "yyyy-MM-dd-HH-mm-ss")

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    Try


                        Shell("""c:\xampp\mysql\bin\mysqldump"" --host=" & CLASE_GENERAL.Servidor & " --user=" & CLASE_GENERAL.Usuario & " --password=" & CLASE_GENERAL.Clave & "  --databases " & CLASE_GENERAL.BD & " --result-file=" & .FileName & "")

                        '**************** Llenamos La Tabla Control *************************************

                        CTRL = New CLASE_CONTROL
                        CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                        CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                        CTRL.p_Idproceso = 13

                        CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                        CTRL.dispose()
                        CTRL = Nothing

                        MsgBox("Copia de Seguridad Realizada con Exito", MsgBoxStyle.OkOnly, "Copias de Seguridad")

                    Catch ex As Exception

                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Copias de Seguridad")

                    End Try


                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try



    End Sub

    Private Sub btnRestaurarBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaurarBackup.Click
        Try

            With OpenFileBackup
                ' Vea btnRetriveFileNames_Click para obtener una explicación de los valores predeterminados
                ' de las propiedades.

                ' Comprobar que el archivo seleccionado existe. El cuadro de diálogo muestra
                ' una advertencia en caso contrario.
                .CheckFileExists = True

                ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra 
                ' una advertencia en caso contrario.
                .CheckPathExists = True

                ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
                .DefaultExt = "sql"

                ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo
                ' seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
                .DereferenceLinks = True

                ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada
                ' par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario
                ' poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el
                ' filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
                .Filter = "Archivos de Copia de Seguridad (*.sql)|*.sql"

                .InitialDirectory = "c:\backups"

                ' ¿Restaurar el directorio original después de seleccionar
                ' un archivo? Si False, el directorio actual cambia
                ' al directorio en el que seleccionó el archivo.
                ' Establézcalo como True para poner la carpeta actual de nuevo
                ' donde estaba cuando comenzó.
                ' El valor predeterminado es False.
                .RestoreDirectory = True

                ' ¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
                .ShowHelp = False


                ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
                ' Esto sólo tiene sentido si ShowReadOnly es True.

                .Title = "Seleccione  Un Archivo Para Restaurar"

                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    Try

                        Dim respuesta As Integer
                        Dim shellop As Integer

                        respuesta = MsgBox("Esta Seguro de Restaurar La Base de Datos?, esto implica el reemplazo de los registros con el archivo seleccionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Copias de Seguridad")

                        If respuesta = 6 Then

                            Dim swEscritor As IO.StreamWriter
                            ' creamos un stream de escritura, y al mismo tiempo un
                            ' nuevo archivo para escribir texto sobre él
                            swEscritor = New IO.StreamWriter("c:\restore.bat")
                            ' escribir líneas
                            swEscritor.WriteLine("c:\xampp\mysql\bin\mysql --host=" & CLASE_GENERAL.Servidor & " --user=" & CLASE_GENERAL.Usuario & " --password=" & CLASE_GENERAL.Clave & " --database=" & CLASE_GENERAL.BD & " < " & .FileName & "")
                            swEscritor.Close()
                            shellop = Shell("c:\restore.bat", AppWinStyle.Hide, False)

                            MsgBox("Copia de Seguridad Restaurada con Exito", MsgBoxStyle.OkOnly, "Copias de Seguridad")

                            If My.Computer.FileSystem.FileExists("c:\restore.bat") Then
                                My.Computer.FileSystem.DeleteFile("c:\restore.bat")
                            End If


                            '****************************** CONFIGURACIONES INICIALES *****************************

                            Me.ScheduleOrhosoft.Date = DateTime.Today

                            Me.clcStartTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horaini), Minute(CLASE_GENERAL._horaini), Second(CLASE_GENERAL._horaini), 0)
                            Me.clcEndTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horafin), Minute(CLASE_GENERAL._horafin), Second(CLASE_GENERAL._horafin), 0)
                            Me.StartTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horaini), Minute(CLASE_GENERAL._horaini), Second(CLASE_GENERAL._horaini), 0)
                            Me.EndTime.Value = New Date(2000, 1, 1, Hour(CLASE_GENERAL._horafin), Minute(CLASE_GENERAL._horafin), Second(CLASE_GENERAL._horafin), 0)

                            Select Case CLASE_GENERAL._rangocal
                                Case "5"
                                    Me.rbt5min.Checked = True
                                Case "10"
                                    Me.rbt10min.Checked = True
                                Case "15"
                                    Me.rbt15min.Checked = True
                                Case "30"
                                    Me.rbt30min.Checked = True
                            End Select

                            Me.txtfechahoy.Text = UCase(Format(Date.Today, "Long Date"))

                            '********************************** CARGAMOS EL DOCTOR ACTIVO ************************

                            CLASE_GENERAL.cargar_combo("doctores", Me.cmbDoctores, CLASE_GENERAL.mensaje_error)
                            Me.cmbDoctores.SelectedValue = 1
                            Me.lblActivoDoctor.Text = Me.cmbDoctores.Text
                            Me.lblActivoDoctor.Tag = Me.cmbDoctores.SelectedValue

                            '*************************** CARGAMOS EL CALENDARIO DEL SCHEDULER ********************
                            fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

                            SCHE = New CLASE_SCHEDULER
                            SCHE.llenadoscheduler(fecha)
                            SCHE = Nothing

                        End If


                    Catch ex As Exception

                        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)

                    End Try


                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub rbtCanceladaSi_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtCanceladaSi.MouseClick

        If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex2 = 2
            Me.ScheduleOrhosoft.Refresh()


            If Not (Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub
    Private Sub rbtCanceladaNo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtCanceladaNo.MouseClick

        If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex2 = 3
            Me.ScheduleOrhosoft.Refresh()


            If Not (Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 0) Then
                Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub

    Private Sub rbtAsistioSi_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtAsistioSi.MouseClick

        If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex3 = 4
            Me.ScheduleOrhosoft.Refresh()


            If Not (Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub

    Private Sub rbtAsistioNo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtAsistioNo.MouseClick

        If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex3 = 5
            Me.ScheduleOrhosoft.Refresh()


            If Not (Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If



        End If

    End Sub
    Private Sub SelectedAppointmentChanged2(ByVal appointment As ScheduleAppointment)

        Try

            If Not appointment Is Nothing Then

                If Not (appointment.Text = "") Then

                    If Not (appointment.ImageIndex1 = 0) Then

                        appointment.ImageIndex1 = 1


                        If Me.btnCitaModificar.Enabled = True Then

                            Dim respuesta As Integer
                            respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                            If respuesta = MsgBoxResult.Yes Then

                                modificarcita()

                            Else

                                SCHE = New CLASE_SCHEDULER

                                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                                SCHE.llenadoscheduler(fecha)

                                SCHE = Nothing

                            End If

                        End If

                    End If
                End If
            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Public Sub CalOrthosoft_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalOrthosoft.ClickEvent

        Try

            SCHE = New CLASE_SCHEDULER

            fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")

            If CLASE_GENERAL.sheduler = 0 Then

                SCHE.llenadoscheduler(fecha)

            Else

                SCHE.llenadoschedulerMulti(fecha)

            End If


            SCHE = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub mnuConfigIni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigIni.Click

        frmConfiguraciones.MdiParent = Me
        'Display the new form.
        frmConfiguraciones.Show()
        frmConfiguraciones.Activate()

    End Sub

    Public Sub btnf6InfCumpleHoy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf6InfCumpleHoy.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CUMPLEAÑOS HOY")

            If respuesta = 6 Then

                PAC = New CLASE_PACIENTES
                PAC.Seleccionar("informecumpleañoshoy")

                Dim oRptCumpleaños As New rptCumpleaños()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptCumpleaños.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCumpleaños

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptCumpleaños.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptCumpleaños.ReportDefinition.ReportObjects.Item("txtTituloInforme")
                toTexto.Text = "INFORME PACIENTES QUE CUMPLEN AÑOS EL DIA DE HOY"

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 6

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing


                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                PAC.dispose()
                PAC = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

    Private Sub btnf8InfCumpleMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf8InfCumpleMes.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CUMPLEAÑOS MES")

            If respuesta = 6 Then

                PAC = New CLASE_PACIENTES
                PAC.Seleccionar("informecumpleañosmes")

                Dim oRptCumpleaños As New rptCumpleaños()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptCumpleaños.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCumpleaños

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptCumpleaños.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptCumpleaños.ReportDefinition.ReportObjects.Item("txtTituloInforme")
                toTexto.Text = "INFORME PACIENTES QUE CUMPLEN AÑOS EN ESTE MES"

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 8

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing


                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                PAC.dispose()
                PAC = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub btnf7InfCumpleSemana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf7InfCumpleSemana.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CUMPLEAÑOS SEMANA")

            If respuesta = 6 Then

                PAC = New CLASE_PACIENTES
                PAC.Seleccionar("informecumpleañossemana")

                Dim oRptCumpleaños As New rptCumpleaños()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptCumpleaños.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCumpleaños

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptCumpleaños.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptCumpleaños.ReportDefinition.ReportObjects.Item("txtTituloInforme")
                toTexto.Text = "INFORME PACIENTES QUE CUMPLEN AÑOS EN ESTA SEMANA"

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 7

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing


                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                PAC.dispose()
                PAC = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub mdiOrthoSoft_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown 'Handles MyBase.KeyDown 

        Try

            Dim KeyCode As Short = e.KeyCode
            Dim Shift As Short = e.KeyData \ &H10000

            contador = 0

            If e.KeyCode = Keys.F1 Then
                Me.btnf1InfPorPaciente_Click(sender, e)
            ElseIf e.KeyCode = Keys.F2 Then
                Me.btnf2Infpordia_Click(sender, e)
            ElseIf e.KeyCode = Keys.F3 Then
                Me.btnf3InfFuturas_Click(sender, e)
            ElseIf e.KeyCode = Keys.F4 Then
                Me.btnf4InfSinAsistir_Click(sender, e)
            ElseIf e.KeyCode = Keys.F5 Then
                Me.btnf5InfGeneral_Click(sender, e)
            ElseIf e.KeyCode = Keys.F6 Then
                Me.btnf6InfCumpleHoy_Click(sender, e)
            ElseIf e.KeyCode = Keys.F7 Then
                Me.btnf7InfCumpleSemana_Click(sender, e)
            ElseIf e.KeyCode = Keys.F8 Then
                Me.btnf8InfCumpleMes_Click(sender, e)
            ElseIf e.KeyCode = Keys.F9 Then
                Me.btnf9BloqueoDia_Click(sender, e)
            ElseIf e.KeyCode = Keys.F10 Then
                Me.btnf10BloqueoPac_Click(sender, e)
            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnf1InfPorPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf1InfPorPaciente.Click

        Try

            If Me.lblActivoPaciente.Text = "" Then

                MsgBox("No hay Un Paciente Seleccionado", MsgBoxStyle.OkOnly, "CITAS POR PACIENTE")

            Else

                Dim respuesta As Integer
                respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CITAS POR PACIENTE")

                If respuesta = 6 Then

                    CITA = New CLASE_CITAS
                    CITA.p_Idpaciente = Me.lblActivoPaciente.Tag
                    CITA.p_Iddoctor = Me.lblActivoDoctor.Tag

                    CITA.Seleccionar("informecitasxpaciente")

                    Dim oRptCitasPaciente As New rptCitasPaciente()
                    Dim toTexto As TextObject

                    frmInformes.MdiParent = Me
                    oRptCitasPaciente.SetDataSource(CLASE_GENERAL.xdt)
                    My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCitasPaciente


                    'Definimos El Titulo de la Clinica por Defecto
                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtEmpresa")
                    toTexto.Text = CLASE_GENERAL._razonsocial_cons

                    'Definimos los otros items del Informe
                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtDoctor")
                    toTexto.Text = Me.lblActivoDoctor.Text

                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtPaciente")
                    toTexto.Text = Me.lblActivoPaciente.Text

                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtCelular_pac")
                    toTexto.Text = Me.txtCelular_ficha.Text

                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtTelcasa_pac")
                    toTexto.Text = Me.txtTelCasa_ficha.Text

                    'toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtResidencia_pac")
                    'toTexto.Text = Me.txtReferido_ficha.Text

                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtemail_pac")
                    toTexto.Text = Me.txtEmail_ficha.Text

                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtIdpaciente")
                    toTexto.Text = Me.txtId_ficha.Text

                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtnhclinica")
                    toTexto.Text = Me.txtnhistoria_ficha.Text

                    toTexto = oRptCitasPaciente.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                    toTexto.Text = Me.lblActivoUsuario.Text


                    My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                    My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                    My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                    My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                    '**************** Llenamos La Tabla Control *************************************

                    CTRL = New CLASE_CONTROL
                    CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                    CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                    CTRL.p_Idproceso = 1

                    CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                    CTRL.dispose()
                    CTRL = Nothing


                    'Display the new form.
                    My.Forms.frmInformes.Show()
                    My.Forms.frmInformes.Activate()

                    CLASE_GENERAL.xdt.Dispose()
                    CLASE_GENERAL.xdt = Nothing

                    CITA.dispose()
                    CITA = Nothing

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnf2Infpordia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf2Infpordia.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CITAS POR DIA")

            If respuesta = 6 Then

                CITA = New CLASE_CITAS
                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CITA.p_fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CITA.p_Iddoctor = Me.lblActivoDoctor.Tag

                CITA.Seleccionar("informecitasxdia")

                Dim oRptCitasDia As New rptCitasDia()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptCitasDia.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCitasDia

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptCitasDia.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptCitasDia.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = Me.lblActivoDoctor.Text

                toTexto = oRptCitasDia.ReportDefinition.ReportObjects.Item("txtFecha_inf")
                toTexto.Text = Format(fecha, "Long Date")

                toTexto = oRptCitasDia.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                toTexto.Text = Me.lblActivoUsuario.Text

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 2

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CITA.dispose()
                CITA = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
    Private Sub btnf10BloqueoPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf10BloqueoPac.Click

        Try

            If Me.lblActivoPaciente.Text = "" Then

                MsgBox("No hay Un Paciente Seleccionado", MsgBoxStyle.OkOnly, "BLOQUEO PACIENTE")

            Else

                Dim respuesta As Integer
                respuesta = MsgBox("Desea Bloquear al Paciente ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BLOQUEO PACIENTE")

                If respuesta = 6 Then

                    If CLASE_GENERAL.formload = 1 Then

                        If My.Forms.frmPacientes.txtnombres_pac.Text <> "" Then

                            My.Forms.frmPacientes.rbtEstado_Bloqueado.Checked = True
                            My.Forms.frmPacientes.btnModificar_Click(sender, e)

                        End If

                    Else

                        PAC = New CLASE_PACIENTES
                        PAC.p_IdPaciente = Me.lblActivoPaciente.Tag

                        PAC.p_Idestado_pac = 2

                        Me.PnlActivoPaciente.Style.BackColor2 = Color.Salmon
                        PAC.Modificar("bloqueo")

                        PAC.dispose()
                        PAC = Nothing

                        MsgBox("Paciente Bloqueado con Exito", MsgBoxStyle.OkOnly, "BLOQUEO PACIENTE")


                    End If

                    '**************** Llenamos La Tabla Control *************************************

                    CTRL = New CLASE_CONTROL
                    CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                    CTRL.p_IdTRegistro = 7 '7 Bloquear Paciente
                    CTRL.p_Idproceso = Me.lblActivoPaciente.Tag

                    CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                    CTRL.dispose()
                    CTRL = Nothing

                End If



            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnf9BloqueoDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf9BloqueoDia.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea Bloquear Día Seleccionado ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BLOQUEO DIA")

            If respuesta = 6 Then

                Me.rbtNolaborable.Checked = True

                If Me.btnCalAdicionar.Enabled = True Then
                    Me.btnCalAdicionar_Click(sender, e)
                Else
                    Me.btnCalModificar_Click(sender, e)
                End If

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 9

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnCitaImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaImprimir.Click

        Try


            CITA = New CLASE_CITAS
            CITA.p_Idcita = Me.ScheduleOrhosoft.CurrentAppointment.Tag

            CITA.Seleccionar("imprimircitapaciente")

            Dim oRptSuCitaPaciente As New rptSuCitaPaciente()
            Dim toTexto As TextObject

            frmInformes.MdiParent = Me

            oRptSuCitaPaciente.SetDataSource(CLASE_GENERAL.xdt)
            My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptSuCitaPaciente


            'Especificamos los datos de la clinica en los campos

            toTexto = oRptSuCitaPaciente.ReportDefinition.ReportObjects.Item("txtClinica")
            toTexto.Text = CLASE_GENERAL._razonsocial_cons

            toTexto = oRptSuCitaPaciente.ReportDefinition.ReportObjects.Item("txtDoctor")
            toTexto.Text = CLASE_GENERAL._rtelegal_cons

            toTexto = oRptSuCitaPaciente.ReportDefinition.ReportObjects.Item("txtTelefono")
            toTexto.Text = CLASE_GENERAL._tel1_cons

            toTexto = oRptSuCitaPaciente.ReportDefinition.ReportObjects.Item("txtMensajeCita")
            toTexto.Text = CLASE_GENERAL._textopiecita

            My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
            My.Forms.frmInformes.crvOrthosoft.Zoom(100)

            'Exportamos el documento a pdf

            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

            CrDiskFileDestinationOptions.DiskFileName = "c:\Odpp\DocumentoImportante.pdf"
            CrExportOptions = oRptSuCitaPaciente.ExportOptions

            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With

            My.Forms.frmInformes.lblTituloEmail.Text = "Recordatorio de la Cita"
            My.Forms.frmInformes.lblMensajeEmail.Text = "Adjuntamos Documento en formato PDF de la Cita"

            oRptSuCitaPaciente.Export()

            '--------  Termina la Importacion ----

            'Display the new form.
            My.Forms.frmInformes.Show()
            My.Forms.frmInformes.Activate()

            EVEN = New CLASE_EVENTOS
            My.Forms.frmInformes.txtcorreos.Text = EVEN.buscarcorreos(Me.lblActivoPaciente.Tag)
            EVEN = Nothing

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            CITA.dispose()
            CITA = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnf12EnvioEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf12EnvioEmail.Click

        frmEnvioEmails.MdiParent = Me
        'Display the new form.
        frmEnvioEmails.Show()
        frmEnvioEmails.Activate()

    End Sub

    Private Sub btnf11EnvioTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf11EnvioTel.Click

        frmCentralTelefonica.MdiParent = Me
        'Display the new form.
        frmCentralTelefonica.Show()
        frmCentralTelefonica.Activate()

    End Sub

    Private Sub rbtFestivo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtFestivo.MouseClick

        Me.GroupHorarioLaboral.Enabled = True
        Me.GroupRangoAgenda.Enabled = True

    End Sub

    Private Sub rbtModificado_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtModificado.MouseClick

        Me.GroupHorarioLaboral.Enabled = True
        Me.GroupRangoAgenda.Enabled = True

    End Sub

    Private Sub rbtNolaborable_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtNolaborable.MouseClick

        Me.GroupHorarioLaboral.Enabled = False
        Me.GroupRangoAgenda.Enabled = False

    End Sub


    Private Sub btnf3InfFuturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf3InfFuturas.Click

        Try

            If Me.lblActivoPaciente.Text = "" Then

                MsgBox("No hay Un Paciente Seleccionado", MsgBoxStyle.OkOnly, "CITAS FUTURAS POR PACIENTE")

            Else


                Dim respuesta As Integer
                respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CITAS FUTURAS POR PACIENTE")

                If respuesta = 6 Then

                    CITA = New CLASE_CITAS

                    fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                    CITA.p_fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                    CITA.p_Idpaciente = Me.lblActivoPaciente.Tag
                    CITA.p_Iddoctor = Me.lblActivoDoctor.Tag

                    CITA.Seleccionar("informecitasfuturas")

                    Dim oRptCitasFuturas As New rptCitasFuturasPac()
                    Dim toTexto As TextObject

                    frmInformes.MdiParent = Me
                    oRptCitasFuturas.SetDataSource(CLASE_GENERAL.xdt)
                    My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCitasFuturas

                    'Definimos El Titulo de la Clinica por Defecto
                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtEmpresa")
                    toTexto.Text = CLASE_GENERAL._razonsocial_cons

                    'Definimos los otros items del Informe
                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtDoctor")
                    toTexto.Text = Me.lblActivoDoctor.Text

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtPaciente")
                    toTexto.Text = Me.lblActivoPaciente.Text

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtCelular_pac")
                    toTexto.Text = Me.txtCelular_ficha.Text

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtTelcasa_pac")
                    toTexto.Text = Me.txtTelCasa_ficha.Text

                    'toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtResidencia_pac")
                    'toTexto.Text = Me.txtReferido_ficha.Text

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtemail_pac")
                    toTexto.Text = Me.txtEmail_ficha.Text

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtIdpaciente")
                    toTexto.Text = Me.txtId_ficha.Text

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtnhclinica")
                    toTexto.Text = Me.txtnhistoria_ficha.Text

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtFecha_inf")
                    toTexto.Text = Format(fecha, "Long Date")

                    toTexto = oRptCitasFuturas.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                    toTexto.Text = Me.lblActivoUsuario.Text

                    My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                    My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                    My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                    My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                    '**************** Llenamos La Tabla Control *************************************

                    CTRL = New CLASE_CONTROL
                    CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                    CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                    CTRL.p_Idproceso = 3

                    CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                    CTRL.dispose()
                    CTRL = Nothing


                    'Display the new form.
                    My.Forms.frmInformes.Show()
                    My.Forms.frmInformes.Activate()

                    CLASE_GENERAL.xdt.Dispose()
                    CLASE_GENERAL.xdt = Nothing

                    CITA.dispose()
                    CITA = Nothing

                End If
            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnf4InfSinAsistir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf4InfSinAsistir.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CITAS SIN ASISTIR")

            If respuesta = 6 Then

                CITA = New CLASE_CITAS
                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CITA.p_fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CITA.p_Iddoctor = Me.lblActivoDoctor.Tag

                CITA.Seleccionar("informecitassinasistir")

                Dim oRptCitasSinAsistir As New rptCitasSinAsistir()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptCitasSinAsistir.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCitasSinAsistir

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe
                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = Me.lblActivoDoctor.Text

                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtFecha_inf")
                toTexto.Text = Format(fecha, "Long Date")

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 4

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CITA.dispose()
                CITA = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnf5InfGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnf5InfGeneral.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "INFORME GENERAL PACIENTES")

            If respuesta = 6 Then

                PAC = New CLASE_PACIENTES
                PAC.Seleccionar("informegeneral")

                Dim oRptGeneralPac As New rptGeneralPac()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptGeneralPac.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptGeneralPac

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptGeneralPac.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe
                toTexto = oRptGeneralPac.ReportDefinition.ReportObjects.Item("txtTituloInforme")
                toTexto.Text = "INFORME GENERAL DE PACIENTES ACTIVOS"

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 5

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing


                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                PAC.dispose()
                PAC = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia




    End Sub


    Private Sub mnuReminderCitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReminderCitas.Click

        frmReminderCitas.MdiParent = Me
        'Display the new form.
        frmReminderCitas.Show()
        frmReminderCitas.Activate()

    End Sub


    Public Sub btnUsuSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuSeleccionar.Click

        Try

            Me.Hide()


            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("cerrarexplorer")

            CONSUL = New CLASE_CONSULTORIO
            GENE = New CLASE_GENERAL

            CONSUL.p_Idconsultorio = 1
            CONSUL.Seleccionar("imagenesconsultorio")

            If Not (CLASE_CONSULTORIO.xinicio_cons.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xinicio_cons)
                My.Forms.frmIngreso.pbFondoVentana.Image = iImagen

            End If

            CONSUL.dispose()
            CONSUL = Nothing
            GENE = Nothing

            CLASE_GENERAL.cargar_combo("empleados", My.Forms.frmIngreso.cmbEmpleados, CLASE_GENERAL.mensaje_error)
            My.Forms.frmIngreso.Show()
            My.Forms.frmIngreso.cmbEmpleados.SelectedValue = 1
            My.Forms.frmIngreso.txtClave.Text = ""
            My.Forms.frmIngreso.StartPosition = FormStartPosition.CenterScreen

            EVEN = Nothing

            My.Forms.frmIngreso.VerificationControl.Active = True

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnInfAsignadoDia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfAsignadoDia.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CITAS POR DIA")

            If respuesta = 6 Then

                CITA = New CLASE_CITAS
                fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CITA.p_fecha = Me.CalOrthosoft.Year & "-" & Format(Me.CalOrthosoft.Month, "0#") & "-" & Format(Me.CalOrthosoft.Day, "0#")
                CITA.p_Iddoctor = Me.lblActivoDoctor.Tag

                CITA.Seleccionar("informecitasxdiabrackets")

                Dim oRptCitasDiaBrackets As New rptCitasDiaBrackets()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptCitasDiaBrackets.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCitasDiaBrackets

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptCitasDiaBrackets.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptCitasDiaBrackets.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = Me.lblActivoDoctor.Text

                toTexto = oRptCitasDiaBrackets.ReportDefinition.ReportObjects.Item("txtFecha_inf")
                toTexto.Text = Format(fecha, "Long Date")

                toTexto = oRptCitasDiaBrackets.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                toTexto.Text = Me.lblActivoUsuario.Text

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 2

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CITA.dispose()
                CITA = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub cmbTipoConsulta_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoConsulta.SelectionChangeCommitted

        If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

            ' Tipo consulta Brackets

            'cargamos la consulta de acuerdo al color

            CONSULTA = New CLASE_CONSULTA
            CONSULTA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue
            CONSULTA.Seleccionar("tipoconsulta1")

            Me.ScheduleOrhosoft.CurrentAppointment.FormatStyle.BackColor = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.ScheduleOrhosoft.CurrentAppointment.FormatStyle.BackColorGradient = Drawing.Color.White
            Me.ScheduleOrhosoft.CurrentAppointment.FormatStyle.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
            Me.ScheduleOrhosoft.CurrentAppointment.BorderColor = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.lblTipoConsulta.BackColor = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.ScheduleOrhosoft.Refresh()

            CONSULTA.dispose()
            CONSULTA = Nothing


            If Not (Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If


            End If

        End If

    End Sub

    Private Sub btnInfPacBloq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfPacBloq.Click
        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "INFORME GENERAL PACIENTES BLOQUEADOS")

            If respuesta = 6 Then

                PAC = New CLASE_PACIENTES
                PAC.Seleccionar("informegeneralpacientesbloqueados")

                Dim oRptPacientesBloqueados As New rptPacientesBloqueados()
                Dim toTexto As TextObject

                frmInformes.MdiParent = Me
                oRptPacientesBloqueados.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptPacientesBloqueados

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptPacientesBloqueados.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptPacientesBloqueados.ReportDefinition.ReportObjects.Item("txtTituloInforme")
                toTexto.Text = "INFORME GENERAL DE PACIENTES BLOQUEADOS"

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = Me.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 5

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing


                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                PAC.dispose()
                PAC = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnEditarFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarFicha.Click

        Try

            'Abrimos la Ventana Primero

            frmPacientes.MdiParent = Me
            'Display the new form.
            frmPacientes.Show()
            frmPacientes.Activate()

            EVEN = New CLASE_EVENTOS
            EVEN.cargarpacientedatos(Me.lblActivoPaciente.Tag)
            EVEN = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pacientes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            ' Cerramos todos las ventanas que intervenga informacion de un usuario
            For Each frm As Form In Me.MdiChildren
                If frm.Name = "frmEstudios" Or frm.Name = "frmPresupuesto" Or frm.Name = "frmProcedimientoDiario" Or frm.Name = "frmComposicion" Or frm.Name = "frmDocumentos" Or frm.Name = "frmInformes" Or frm.Name = "frmEstadoCuenta" Or frm.Name = "frmRcaja" Then
                    frm.Close()
                End If
            Next


            'Set the Parent Form of the Child window.
            frmBuscarPacientes.MdiParent = Me
            'Display the new form.
            frmBuscarPacientes.Show()
            frmBuscarPacientes.Activate()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Editar Pacientes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick


        'Rutina que se ejecuta para verificar Actividad de la aplicacion
        ptx = pt32.X
        pty = pt32.Y

        Call GetCursorPos(pt32)
        If pt32.X = ptx And pt32.Y = pty Then
            contador = contador + 1
            If contador = 9999 Then ' Contador por 900 segundos 15 Minutos 9000
                Me.btnUsuSeleccionar_Click(sender, e)
                contador = 0

            End If
        Else
            contador = 0

        End If

    End Sub
    Private Sub btnCalAdicionar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalAdicionar2.Click
        Me.btnCalAdicionar_Click(sender, e)
    End Sub

    Private Sub btnCalModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalModificar2.Click
        Me.btnCalModificar_Click(sender, e)
    End Sub

    Private Sub btnEnvioEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvioEmail.Click

        Try

            If InStr(Me.txtEmail_ficha.Text, "@") = 0 Or Me.txtEmail_ficha.Text = "notiene@" Then

                MsgBox("Formato de Email Incorrecto, verifique y corrijalo por favor ", MsgBoxStyle.OkOnly, "ENVIO EMAIL PERSONALIZADO")

            Else

                My.Forms.frmEnvioEmailInd.txtEmailInd.Text = Trim(Me.txtEmail_ficha.Text)

                'Set the Parent Form of the Child window.
                frmEnvioEmailInd.MdiParent = Me
                'Display the new form.
                frmEnvioEmailInd.Show()
                frmEnvioEmailInd.Activate()


            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ENVIO EMAIL PERSONALIZADO") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub mdiOrthoSoft_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Cambiamos la ubicacion de las Fichas
        ubicarcontroles()

        'Guardamos el tamaño maximo del Panel para el movimiento de ellas
        CLASE_GENERAL.xmaxiheigth = PanelFicha.Size.Height
        CLASE_GENERAL.xmaxiwidth = PanelFicha.Size.Width

        Me.Text = "Odontoapp V." & My.Settings.Version

    End Sub

    Private Sub mdiOrthoSoft_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        On Error Resume Next
        SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Width)) \ 29), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Height)) \ 29), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)

    End Sub

    Private Sub ubicarcontroles()

        'Ficha
        ubicarcontrol(Me.pbxFoto_ficha)
        ubicarcontrol(Me.btnEnvioEmail)
        ubicarcontrol(Me.btnEditarFicha)
        ubicarcontrol(Me.btnBuscar)
        ubicarcontrol(Me.lblRemitido)
        ubicarcontrol(Me.lblNombre)
        ubicarcontrol(Me.lblCelular)
        ubicarcontrol(Me.lblEmail)
        ubicarcontrol(Me.lblCodigo)
        ubicarcontrol(Me.txtNombre_ficha)
        ubicarcontrol(Me.txtReferido_ficha)
        ubicarcontrol(Me.txtCelular_ficha)
        ubicarcontrol(Me.lblTelCasa)
        ubicarcontrol(Me.txtTelCasa_ficha)
        ubicarcontrol(Me.txtEmail_ficha)
        ubicarcontrol(Me.txtId_ficha)
        ubicarcontrol(Me.lblNHclinica)
        ubicarcontrol(Me.txtnhistoria_ficha)
        ubicarcontrol(Me.gpProximaCita)
        ubicarcontrol(Me.btnEnvioSMSPersonalizado)
        ubicarcontrol(Me.btnPacOdontograma)
        ubicarcontrol(Me.btnEstadoCuenta)
        ubicarcontrol(Me.btnEstudiosPac)
        ubicarcontrol(Me.btnProcedimiento)
        ubicarcontrol(Me.btnHistoriaClinica)


        'Control Calendario
        ubicarcontrol(Me.lblConfigCal)
        ubicarcontrol(Me.txtIdCalendario)
        ubicarcontrol(Me.GroupHorarioLaboral)
        ubicarcontrol(Me.GroupRangoAgenda)
        ubicarcontrol(Me.GroupTBloqueoDia)
        ubicarcontrol(Me.btnCalAdicionar)
        ubicarcontrol(Me.btnCalModificar)
        ubicarcontrol(Me.btnCalEliminar)
        ubicarcontrol(Me.lblDiaSeleccionado)
        ubicarcontrol(Me.txtDiaSeleccionado)
        ubicarcontrol(Me.lblDiaLibre)
        ubicarcontrol(Me.txtDiaLibre)



    End Sub

    Public Sub ubicarcontrol(ByVal control As Control)

        Dim proporcionh As Integer
        Dim proporcionv As Integer

        Dim locationcontrolx As Integer
        Dim locationcontroly As Integer

        Dim desplazamiento As Integer
        desplazamiento = Round((CInt(Me.PanelFicha.Size.Width) - 550) / 2, 0)

        'btnEnvioEmail
        locationcontrolx = control.Location.X
        locationcontroly = control.Location.Y

        proporcionh = locationcontrolx + desplazamiento
        proporcionv = locationcontroly

        control.Location = New System.Drawing.Point(proporcionh, proporcionv)

    End Sub

    Private Sub mnuRcaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRcaja.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Presuuesto")
            btnBuscar_Click(sender, e)

        Else

            frmRCaja.MdiParent = Me
            'Display the new form.
            frmRCaja.Show()
            frmRCaja.Activate()

        End If

    End Sub

    Private Sub mnuProcedimientoDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProcedimientoDiario.Click


        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Procedimiento Diario")
            btnBuscar_Click(sender, e)

        Else

            frmProcedimientoDiario.MdiParent = Me
            'Display the new form.
            frmProcedimientoDiario.Show()
            frmProcedimientoDiario.Activate()

        End If


    End Sub

    Private Sub btnSincronizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSincronizar.Click

        'My.Forms.Form1.Show()
        'My.Forms.Form1.Activate()

    End Sub


    Private Sub mnuPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPresupuesto.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Presuuesto")
            btnBuscar_Click(sender, e)

        Else

            frmPresupuesto.MdiParent = Me
            'Display the new form.
            frmPresupuesto.Show()
            frmPresupuesto.Activate()

        End If

    End Sub

    Private Sub mnuGereradorInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGereradorInformes.Click

        frmInformesVarios.MdiParent = Me
        'Display the new form.
        frmInformesVarios.Show()
        frmInformesVarios.Activate()

    End Sub

    Private Sub btnAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAppointment.Click
        

        frmAppointment.MdiParent = Me
        'Display the new form.
        frmAppointment.Show()
        frmAppointment.Activate()

        'Asignamos el Perfil del Usuario

        ASIGNAR_PERFILES = New CLASE_ASIGNAR_PERFILES
        ASIGNAR_PERFILES.Seleccionar_perfil()
        ASIGNAR_PERFILES = Nothing

        'Verificamos que es la multiagenda
        Me.ExpandableAgenda.Expanded = False
        CLASE_GENERAL.sheduler = 1

    End Sub

    Private Sub mnuNivelAcceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNivelAcceso.Click

        Try

            frmNivelesAccesos.MdiParent = Me
            'Display the new form.
            frmNivelesAccesos.Show()
            frmNivelesAccesos.Activate()

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub mnuDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDocumentos.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Documentos")
            btnBuscar_Click(sender, e)

        Else

            frmDocumentos.MdiParent = Me
            'Display the new form.
            frmDocumentos.Show()
            frmDocumentos.Activate()

        End If

    End Sub

    Private Sub mnuIlustraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIlustraciones.Click

        frmImagenes.MdiParent = Me
        'Display the new form.
        frmImagenes.Show()
        frmImagenes.Activate()

    End Sub

    Private Sub btnSMS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMS.Click

        frmEnvioSMS.MdiParent = Me
        'Display the new form.
        frmEnvioSMS.Show()
        frmEnvioSMS.Activate()

    End Sub

    Private Sub mnuEgreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEgreso.Click

        frmComprobanteEgreso.MdiParent = Me
        'Display the new form.
        frmComprobanteEgreso.Show()
        frmComprobanteEgreso.Activate()

    End Sub

    Private Sub btnEstudiosPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstudiosPac.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Documentos")
            btnBuscar_Click(sender, e)

        Else

            frmEstudios.MdiParent = Me
            'Display the new form.
            frmEstudios.Show()
            frmEstudios.Activate()

        End If


    End Sub

    Private Sub btnPacOdontograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPacOdontograma.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Documentos")
            btnBuscar_Click(sender, e)

        Else

            frmOdontogramaGrafico.Show()
            frmOdontogramaGrafico.Activate()

        End If

    End Sub

    Private Sub btnEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadoCuenta.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Documentos")
            btnBuscar_Click(sender, e)

        Else

            frmEstadoCuenta.MdiParent = Me
            'Display the new form.
            frmEstadoCuenta.Show()
            frmEstadoCuenta.Activate()

        End If

    End Sub

    Private Sub mnuItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItems.Click

        frmProcedimientosItems.MdiParent = Me
        'Display the new form.
        frmProcedimientosItems.Show()
        frmProcedimientosItems.Activate()

    End Sub

    Private Sub txtnotacita_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnotacita.Leave

        If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

            If Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 1 Then

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub

    Private Sub txtnotacita_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtnotacita.MouseClick

        If (Me.ScheduleOrhosoft.SelectedAppointments.Count > 0) Then

            If Not (Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoft.CurrentAppointment.ImageIndex1 = 1

            End If

        End If

    End Sub

    Private Sub mnuEstadoCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEstadoCuenta.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Presuuesto")
            btnBuscar_Click(sender, e)

        Else

            frmEstadoCuenta.MdiParent = Me
            'Display the new form.
            frmEstadoCuenta.Show()
            frmEstadoCuenta.Activate()

        End If

    End Sub

    Private Sub mnuGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGastos.Click

        frmGastos.MdiParent = Me
        'Display the new form.
        frmGastos.Show()
        frmGastos.Activate()

    End Sub

    Private Sub btnSoporteRemoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoporteRemoto.Click

        'Process.Start(Application.StartupPath  "\SoporteRemoto.exe")
        Shell(Application.StartupPath & "\SoporteRemoto.exe")

    End Sub


    Private Sub btnActualizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizacion.Click


        My.Forms.frmAcercaOdontoapp.Show()
        My.Forms.frmAcercaOdontoapp.TopMost = True

        Buscar_Actualizacion()

    End Sub

    Private Sub mnuProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProveedores.Click

        Try

            frmProveedores.MdiParent = Me
            'Display the new form.
            frmProveedores.Show()
            frmProveedores.Activate()

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarproveedores")
            EVEN.bloquaerdesbloquear("nuevoproveedor")

            EVEN = Nothing

            My.Forms.frmProveedores.txtIdproveedor.Text = (CLASE_GENERAL.maximo("Idproveedor", "proveedores", CLASE_GENERAL.mensaje_error)) + 1

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicio.Click

        'Set the Parent Form of the Child window.
        frmInicio.MdiParent = Me
        'Display the new form.
        frmInicio.Show()
        frmInicio.Activate()


    End Sub

    Private Sub mnuBuscarProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscarProveedores.Click

        frmBuscarProveedor.MdiParent = Me
        'Display the new form.
        frmBuscarProveedor.Show()
        frmBuscarProveedor.Activate()

    End Sub

    Private Sub btnEnvioSMSPersonalizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvioSMSPersonalizado.Click

        Try

            If Me.txtCelular_ficha.Text.Length = 0 Then

                MsgBox("El paciente No tiene celular..Verifique por favor ", MsgBoxStyle.OkOnly, "ENVIO SMS PERSONALIZADO")

            Else

                PAC = New CLASE_PACIENTES

                PAC.p_IdPaciente = Me.lblActivoPaciente.Tag
                PAC.Seleccionar("operadorcelular")

                OPERADOR = New CLASE_OPERADOR
                OPERADOR.p_Idoperador = CLASE_PACIENTES.xIdoperador
                OPERADOR.Seleccionar("registro")

                My.Forms.frmEnvioSMSInd.txtSMSInd.Text = Trim(Me.txtCelular_ficha.Text & "@" & CLASE_OPERADOR.xdominio_oper)

                PAC.dispose()
                PAC = Nothing

                OPERADOR.dispose()
                OPERADOR = Nothing

                'Set the Parent Form of the Child window.
                frmEnvioSMSInd.MdiParent = Me
                'Display the new form.
                frmEnvioSMSInd.Show()
                frmEnvioSMSInd.Activate()


            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ENVIO SMS PERSONALIZADO") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub mnuMovimientoDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMovimientoDiario.Click

        Try

            frmMovimientoDiario.MdiParent = Me
            'Display the new form.
            frmMovimientoDiario.Show()
            frmMovimientoDiario.Activate()

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarlibro")
            EVEN = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ENVIO SMS PERSONALIZADO") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub mnuBloqDesCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBloqDesCalendario.Click

        frmDesbloqueoDias.MdiParent = Me
        'Display the new form.
        frmDesbloqueoDias.Show()
        frmDesbloqueoDias.Activate()

    End Sub

    Private Sub btnCalculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculadora.Click

        Process.Start("calc")

    End Sub

    Private Sub btnProcedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcedimiento.Click

        If Me.lblActivoPaciente.Text = "" Then

            MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Procedimiento Diario")
            btnBuscar_Click(sender, e)

        Else

            frmProcedimientoDiario.MdiParent = Me
            'Display the new form.
            frmProcedimientoDiario.Show()
            frmProcedimientoDiario.Activate()

        End If

    End Sub

    Private Sub btnHCGeneral_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHCGeneral.Click

        Try

            If Me.lblActivoPaciente.Text = "" Then

                MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Historias Clinicas")
                btnBuscar_Click(sender, e)

            Else

                frmHistoriaClinicaGeneral.MdiParent = Me
                'Display the new form.
                frmHistoriaClinicaGeneral.Show()
                frmHistoriaClinicaGeneral.Activate()

                'Limpiamos
                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcg")

                'Cargamos la Historia Clinica Si la Tiene
                'Controlamos que exista un registro de la historia clinica para modificarlo
                'si no existe creamos un nuevo registro al insertarlo en la base de datos

                contar = 0
                contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica_g", Me.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    HCGENE = New CLASE_HCLINICA_GENERAL
                    HCGENE.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HCGENE.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HCGENE.Seleccionar("registro")

                    'ANTECEDENTES
                    '1
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_tratam_si.Checked = True
                    End If
                    '2
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_medicam_si.Checked = True
                    End If

                    '3
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_alergias_si.Checked = True
                    End If

                    '4
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_cardiopatias_si.Checked = True
                    End If

                    '5
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_parterial_si.Checked = True
                    End If

                    '6
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_embarazo_si.Checked = True
                    End If

                    '7
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_diabetes_si.Checked = True
                    End If

                    '8
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 8, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_hepatitis_si.Checked = True
                    End If

                    '9
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 9, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_irradia_si.Checked = True
                    End If

                    '10
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 10, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_discrasia_si.Checked = True
                    End If

                    '11
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 11, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_fiebre_si.Checked = True
                    End If

                    '12
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 12, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_enfrenal_si.Checked = True
                    End If

                    '13
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 13, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_inmunos_si.Checked = True
                    End If

                    '14
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 14, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_temosionales_si.Checked = True
                    End If

                    '15
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 15, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_prespi_si.Checked = True
                    End If

                    '16
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 16, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_tgastricos_si.Checked = True
                    End If

                    '17
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 17, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_epilepsia_si.Checked = True
                    End If

                    '18
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 18, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_cirugias_si.Checked = True
                    End If

                    '19
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 19, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_eorales_si.Checked = True
                    End If

                    '20
                    If Mid(CLASE_HCLINICA_GENERAL.xantecedentes_hcg, 20, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckant_otras_si.Checked = True
                    End If

                    My.Forms.frmHistoriaClinicaGeneral.txtuconsulta_hcg.Text = CLASE_HCLINICA_GENERAL.xuconsulta_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtaconsulta_hcg.Text = CLASE_HCLINICA_GENERAL.xaconsulta_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtant_temp_hcg.Text = CLASE_HCLINICA_GENERAL.xant_temp_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtant_pulsapm_hcg.Text = CLASE_HCLINICA_GENERAL.xant_pulsapm_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtant_pulsaart_hcg.Text = CLASE_HCLINICA_GENERAL.xant_pulsaart_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtant_fresp_hcg.Text = CLASE_HCLINICA_GENERAL.xant_fresp_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtant_familiares_hcg.Text = CLASE_HCLINICA_GENERAL.xant_familiares_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtant_observa_hcg.Text = CLASE_HCLINICA_GENERAL.xant_observa_hcg

                    'TEJIDOS BLANDOS
                    '1
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lsuperior_si.Checked = True
                    End If

                    '2
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_linferior_si.Checked = True
                    End If

                    '3
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_comisuras_si.Checked = True
                    End If

                    '4
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_mucosa_si.Checked = True
                    End If

                    '5
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_surcos_si.Checked = True
                    End If

                    '6
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_frenillos_si.Checked = True
                    End If

                    '7
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros1_si.Checked = True
                    End If

                    '8
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 8, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_paladar_si.Checked = True
                    End If

                    '9
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 9, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_orofar_si.Checked = True
                    End If

                    '10
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 10, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_lengua_si.Checked = True
                    End If

                    '11
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 11, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_pisoboca_si.Checked = True
                    End If

                    '12
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 12, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_rebordes_si.Checked = True
                    End If

                    '13
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 13, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_gsalivares_si.Checked = True
                    End If

                    '14
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tblandos_hcg, 14, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_tb_otros2_si.Checked = True
                    End If


                    'ATM OCLUSION
                    '15
                    If Mid(CLASE_HCLINICA_GENERAL.xef_atm_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolormusc_si.Checked = True
                    End If

                    '16
                    If Mid(CLASE_HCLINICA_GENERAL.xef_atm_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_atm_dolorarti_si.Checked = True
                    End If

                    '17
                    If Mid(CLASE_HCLINICA_GENERAL.xef_atm_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_atm_ruidoarti_si.Checked = True
                    End If

                    '18
                    If Mid(CLASE_HCLINICA_GENERAL.xef_atm_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_atm_alterac_si.Checked = True
                    End If

                    '19
                    If Mid(CLASE_HCLINICA_GENERAL.xef_atm_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_atm_maloclu_si.Checked = True
                    End If

                    '20
                    If Mid(CLASE_HCLINICA_GENERAL.xef_atm_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_atm_cresim_si.Checked = True
                    End If

                    '21
                    If Mid(CLASE_HCLINICA_GENERAL.xef_atm_hcg, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_atm_otros_si.Checked = True
                    End If

                    'TEJIDOS DENTALES
                    '22
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tdentales_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_td_cforma_si.Checked = True
                    End If

                    '23
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tdentales_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_td_ctam_si.Checked = True
                    End If

                    '24
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tdentales_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_td_cnum_si.Checked = True
                    End If

                    '25
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tdentales_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_td_ccolor_si.Checked = True
                    End If

                    '26
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tdentales_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_td_cpos_si.Checked = True
                    End If

                    '27
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tdentales_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_td_impac_si.Checked = True
                    End If

                    '28
                    If Mid(CLASE_HCLINICA_GENERAL.xef_tdentales_hcg, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_td_otros_si.Checked = True
                    End If


                    'EXAMEN PERIODONTAL
                    '29
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exaperio_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ep_sangrado_si.Checked = True
                    End If

                    '30
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exaperio_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ep_movilidad_si.Checked = True
                    End If

                    '31
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exaperio_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ep_reces_si.Checked = True
                    End If

                    '32
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exaperio_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ep_bolsa_si.Checked = True
                    End If

                    '33
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exaperio_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ep_calculos_si.Checked = True
                    End If

                    '34
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exaperio_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ep_absceso_si.Checked = True
                    End If

                    '35
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exaperio_hcg, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ep_otros_si.Checked = True
                    End If


                    'EXAMEN PULPAR
                    '36
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exapulpar_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_epu_avital_si.Checked = True
                    End If

                    '37
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exapulpar_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dolor_si.Checked = True
                    End If

                    '38
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exapulpar_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_epu_mdelta_si.Checked = True
                    End If

                    '39
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exapulpar_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_epu_sensi_si.Checked = True
                    End If

                    '40
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exapulpar_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_epu_fistula_si.Checked = True
                    End If

                    '41
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exapulpar_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_epu_dtrata_si.Checked = True
                    End If

                    '42
                    If Mid(CLASE_HCLINICA_GENERAL.xef_exapulpar_hcg, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_epu_otros_si.Checked = True
                    End If


                    'HABITOS
                    '43
                    If Mid(CLASE_HCLINICA_GENERAL.xef_habitos_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ho_resoral_si.Checked = True
                    End If

                    '44
                    If Mid(CLASE_HCLINICA_GENERAL.xef_habitos_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ho_succdig_si.Checked = True
                    End If

                    '45
                    If Mid(CLASE_HCLINICA_GENERAL.xef_habitos_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ho_lenguap_si.Checked = True
                    End If

                    '46
                    If Mid(CLASE_HCLINICA_GENERAL.xef_habitos_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ho_queilos_si.Checked = True
                    End If

                    '47
                    If Mid(CLASE_HCLINICA_GENERAL.xef_habitos_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ho_fumador_si.Checked = True
                    End If

                    '48
                    If Mid(CLASE_HCLINICA_GENERAL.xef_habitos_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ho_onico_si.Checked = True
                    End If

                    '49
                    If Mid(CLASE_HCLINICA_GENERAL.xef_habitos_hcg, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ho_otros_si.Checked = True
                    End If


                    My.Forms.frmHistoriaClinicaGeneral.txtef_observa_hcg.Text = CLASE_HCLINICA_GENERAL.xef_observa_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtef_hallazgos_hcg.Text = CLASE_HCLINICA_GENERAL.xef_hallazgos_hcg


                    'HISTORIA CLINICA DE ACCION PREVENTIVA

                    '1
                    If Mid(CLASE_HCLINICA_GENERAL.xhc_accionp_hcg, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ap_charlas_si.Checked = True
                    End If

                    '2
                    If Mid(CLASE_HCLINICA_GENERAL.xhc_accionp_hcg, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ap_cepillado_si.Checked = True
                    End If

                    '3
                    If Mid(CLASE_HCLINICA_GENERAL.xhc_accionp_hcg, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ap_seda_si.Checked = True
                    End If

                    '4
                    If Mid(CLASE_HCLINICA_GENERAL.xhc_accionp_hcg, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ap_enguague_si.Checked = True
                    End If

                    '5
                    If Mid(CLASE_HCLINICA_GENERAL.xhc_accionp_hcg, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ap_fluor_si.Checked = True
                    End If

                    '6
                    If Mid(CLASE_HCLINICA_GENERAL.xhc_accionp_hcg, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaGeneral.ckef_ap_sellantes_si.Checked = True
                    End If


                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_charlas_hcg.Text = CLASE_HCLINICA_GENERAL.xhc_frec_charlas_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_cepillado_hcg.Text = CLASE_HCLINICA_GENERAL.xhc_frec_cepillado_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_seda_hcg.Text = CLASE_HCLINICA_GENERAL.xhc_frec_seda_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_enguague_hcg.Text = CLASE_HCLINICA_GENERAL.xhc_frec_enguague_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_fluor_hcg.Text = CLASE_HCLINICA_GENERAL.xhc_frec_fluor_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txthc_frec_sellantes_hcg.Text = CLASE_HCLINICA_GENERAL.xhc_frec_sellantes_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txthc_observa_hcg.Text = CLASE_HCLINICA_GENERAL.xhc_observa_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtexa_comp_hcg.Text = CLASE_HCLINICA_GENERAL.xexa_comp_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_psano_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_psano_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanotipo_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_psanotipo_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_psanocod_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_psanocod_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandos_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tblandos_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandostipo_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tblandostipo_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tblandoscod_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tblandoscod_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_atm_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_atm_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmtipo_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_atmtipo_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_atmcod_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_atmcod_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdental_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tdental_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentaltipo_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tdentaltipo_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tdentalcod_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tdentalcod_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperio_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tperio_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiotipo_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tperiotipo_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tperiocod_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tperiocod_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpar_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tpulpar_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulpartipo_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tpulpartipo_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_tpulparcod_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_tpulparcod_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_otros_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_otros_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_otrostipo_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_otrostipo_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_otroscod_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_otroscod_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_observa_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_observa_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtdiag_remision_hcg.Text = CLASE_HCLINICA_GENERAL.xdiag_remision_hcg

                    My.Forms.frmHistoriaClinicaGeneral.txttrata_promocion_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_promocion_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_prevencion_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_prevencion_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_radiog_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_radiog_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_operatoria_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_operatoria_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_endodoncia_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_endodoncia_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_perio_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_perio_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_prosto_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_prosto_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_oclusion_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_oclusion_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txttrata_cirugia_hcg.Text = CLASE_HCLINICA_GENERAL.xtrata_cirugia_hcg
                    My.Forms.frmHistoriaClinicaGeneral.txtpronostico_hcg.Text = CLASE_HCLINICA_GENERAL.xpronostico_hcg

                    HCGENE.dispose()
                    HCGENE = Nothing

                    EVEN.bloquaerdesbloquear("editarhcg")
                    EVEN.bloquaerdesbloquear("bloquearhclinicageneral")
                    EVEN = Nothing

                Else

                    MsgBox("El paciente aun no tiene registrada esta Historia Clinica", MsgBoxStyle.OkOnly, "Historias Clinicas")

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("nuevahcg")
                    EVEN.bloquaerdesbloquear("desbloquearhclinicageneral")
                    EVEN = Nothing

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Historias Clinicas") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub


    Private Sub btnHCOrtodoncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHCOrtodoncia.Click

        Try

            If Me.lblActivoPaciente.Text = "" Then

                MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Historias Clinicas")
                btnBuscar_Click(sender, e)

            Else

                frmHistoriaClinicaOrtodoncia.MdiParent = Me
                'Display the new form.
                frmHistoriaClinicaOrtodoncia.Show()
                frmHistoriaClinicaOrtodoncia.Activate()

                '*********************************** CARGAMOS LA HISTORIA CLINICA ***********************************

                'Limpiamos
                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcorto")

                'Cargamos la Historia Clinica Si la Tiene

                'Controlamos que exista un registro de la historia clinica para modificarlo
                'si no existe creamos un nuevo registro al insertarlo en la base de datos

                contar = 0
                contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica", Me.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    HC = New CLASE_HCLINICA
                    HC.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HC.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HC.Seleccionar("registro")

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmconsulta_h.Text = CLASE_HCLINICA.xmconsulta_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdescripcion_h.Text = CLASE_HCLINICA.xdescripcion_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtclase_h.Text = CLASE_HCLINICA.xclase_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtduracion_h.Text = CLASE_HCLINICA.xduracion_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtenfe_infancia_h.Text = CLASE_HCLINICA.xenfe_infancia_h

                    If Mid(CLASE_HCLINICA.xenfe_adulto_h, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkdiabetes.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkdiabetes.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xenfe_adulto_h, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkhepatitis.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkhepatitis.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xenfe_adulto_h, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chksinusitis.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chksinusitis.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xenfe_adulto_h, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkcardiovas.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkcardiovas.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xenfe_adulto_h, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkfiebre.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkfiebre.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xenfe_adulto_h, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkrespira.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkrespira.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xenfe_adulto_h, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkhipertension.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkhipertension.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtinmuniza_h.Text = CLASE_HCLINICA.xinmuniza_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txthospitaliza_h.Text = CLASE_HCLINICA.xhospitaliza_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttraumaticoas_h.Text = CLASE_HCLINICA.xtraumaticoas_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtquirurgicos_h.Text = CLASE_HCLINICA.xquirurgicos_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttransfusi_h.Text = CLASE_HCLINICA.xtransfusi_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtirradia_h.Text = CLASE_HCLINICA.xirradia_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txthemorrag_h.Text = CLASE_HCLINICA.xhemorrag_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmedica_act_h.Text = CLASE_HCLINICA.xmedica_act_h

                    If Mid(CLASE_HCLINICA.xreaccion_al_h, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkanestesia.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkanestesia.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xreaccion_al_h, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkpenicilina.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkpenicilina.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtotras_drogas_h.Text = CLASE_HCLINICA.xotras_drogas_h

                    If Mid(CLASE_HCLINICA.xhabitos_h, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkbruxismo.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkbruxismo.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xhabitos_h, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkdeglusion.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkdeglusion.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xhabitos_h, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkresbucal.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkresbucal.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xhabitos_h, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkinffon.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkinffon.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xhabitos_h, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkfuma.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkfuma.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xhabitos_h, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkempling.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkempling.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xhabitos_h, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chksuccdigital.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chksuccdigital.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA.xhabitos_h, 8, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkmorder.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chkmorder.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_gener_h.Text = CLASE_HCLINICA.xant_here_gener_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtant_here_bucales_h.Text = CLASE_HCLINICA.xant_here_bucales_h
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_piel.Text = CLASE_HCLINICA.xrsistema_piel
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cabeza.Text = CLASE_HCLINICA.xrsistema_cabeza
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cara.Text = CLASE_HCLINICA.xrsistema_cara
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_oidos.Text = CLASE_HCLINICA.xrsistema_oidos
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_ojos.Text = CLASE_HCLINICA.xrsistema_ojos
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_nariz.Text = CLASE_HCLINICA.xrsistema_nariz
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_senos.Text = CLASE_HCLINICA.xrsistema_senos
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtrsistema_cuello.Text = CLASE_HCLINICA.xrsistema_cuello

                    HC.dispose()
                    HC = Nothing

                    'Historia Clinica Examen Fisico
                    HCEF = New CLASE_HCLINICA_EFISICO
                    HCEF.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HCEF.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HCEF.Seleccionar("registro")

                    My.Forms.frmHistoriaClinicaOrtodoncia.txttensionart_hef.Text = CLASE_HCLINICA_EFISICO.xtensionart_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpulso_hef.Text = CLASE_HCLINICA_EFISICO.xpulso_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfr_hef.Text = CLASE_HCLINICA_EFISICO.xfr_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpiel_hef.Text = CLASE_HCLINICA_EFISICO.xpiel_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtamigdalas_hef.Text = CLASE_HCLINICA_EFISICO.xamigdalas_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtnot_linf_hef.Text = CLASE_HCLINICA_EFISICO.xnot_linf_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpisoboca_hef.Text = CLASE_HCLINICA_EFISICO.xpisoboca_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios__hef.Text = CLASE_HCLINICA_EFISICO.xlabios__hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpaladar_hef.Text = CLASE_HCLINICA_EFISICO.xpaladar_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcarrillos__hef.Text = CLASE_HCLINICA_EFISICO.xcarrillos__hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtglsalivares__hef.Text = CLASE_HCLINICA_EFISICO.xglsalivares__hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmucosa_hef.Text = CLASE_HCLINICA_EFISICO.xmucosa_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenillos_hef.Text = CLASE_HCLINICA_EFISICO.xfrenillos_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtotros_hef.Text = CLASE_HCLINICA_EFISICO.xotros_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtalarmas_hef.Text = CLASE_HCLINICA_EFISICO.xalarmas_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtnotas_hef.Text = CLASE_HCLINICA_EFISICO.xnotas_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttipofacial_hef.Text = CLASE_HCLINICA_EFISICO.xtipofacial_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtimpCabello_hef.Text = CLASE_HCLINICA_EFISICO.ximpCabello_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriav_hef.Text = CLASE_HCLINICA_EFISICO.xsimetriav_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsimetriah_hef.Text = CLASE_HCLINICA_EFISICO.xsimetriah_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcejas_hef.Text = CLASE_HCLINICA_EFISICO.xcejas_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtesclera_hef.Text = CLASE_HCLINICA_EFISICO.xesclera_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtintercantal_hef.Text = CLASE_HCLINICA_EFISICO.xintercantal_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hef.Text = CLASE_HCLINICA_EFISICO.xdorsonariz_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtalasnariz_hef.Text = CLASE_HCLINICA_EFISICO.xalasnariz_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hef.Text = CLASE_HCLINICA_EFISICO.xpuntanariz_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsimcomisur_hef.Text = CLASE_HCLINICA_EFISICO.xsimcomisur_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtselladolabial_hef.Text = CLASE_HCLINICA_EFISICO.xselladolabial_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtinscis_hef.Text = CLASE_HCLINICA_EFISICO.xinscis_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmm_hef.Text = CLASE_HCLINICA_EFISICO.xmm_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtgrosorlabial_hef.Text = CLASE_HCLINICA_EFISICO.xgrosorlabial_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisasimetria_hef.Text = CLASE_HCLINICA_EFISICO.xsonrisasimetria_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisaencia_hef.Text = CLASE_HCLINICA_EFISICO.xsonrisaencia_hef
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsonrisadientesinf_hef.Text = CLASE_HCLINICA_EFISICO.xsonrisadientesinf_hef

                    HCEF.dispose()
                    HCEF = Nothing

                    'Historia Clinica P2

                    HCP2 = New CLASE_HCLINICA_P2
                    HCP2.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HCP2.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HCP2.Seleccionar("registro")

                    My.Forms.frmHistoriaClinicaOrtodoncia.txttipoperfil_hp2.Text = CLASE_HCLINICA_P2.xtipoperfil_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtanguloconj_hp2.Text = CLASE_HCLINICA_P2.xanguloconj_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrente_hp2.Text = CLASE_HCLINICA_P2.xfrente_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdorsonariz_hp2.Text = CLASE_HCLINICA_P2.xdorsonariz_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpuntanariz_hp2.Text = CLASE_HCLINICA_P2.xpuntanariz_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcolumnea_hp2.Text = CLASE_HCLINICA_P2.xcolumnea_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolabial_hp2.Text = CLASE_HCLINICA_P2.xangnasolabial_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp2.Text = CLASE_HCLINICA_P2.xlabios_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsurcomentolabial_hp2.Text = CLASE_HCLINICA_P2.xsurcomentolabial_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmenton_hp2.Text = CLASE_HCLINICA_P2.xmenton_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtangulomentogarg__hp2.Text = CLASE_HCLINICA_P2.xangulomentogarg__hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtsecerupcion_hp2.Text = CLASE_HCLINICA_P2.xsecerupcion_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtparalelismored_hp2.Text = CLASE_HCLINICA_P2.xparalelismored_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtproporcoronaraiz_hp2.Text = CLASE_HCLINICA_P2.xproporcoronaraiz_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes__hp2.Text = CLASE_HCLINICA_P2.xdientesausentes__hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesrete_hp2.Text = CLASE_HCLINICA_P2.xdientesrete_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientessuper_hp2.Text = CLASE_HCLINICA_P2.xdientessuper_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionperio_hp2.Text = CLASE_HCLINICA_P2.xlesionperio_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlesionendod_hp2.Text = CLASE_HCLINICA_P2.xlesionendod_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtanatomiacond_hp2.Text = CLASE_HCLINICA_P2.xanatomiacond_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtestadoligamiento_hp2.Text = CLASE_HCLINICA_P2.xestadoligamiento_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtpisosenomax_hp2.Text = CLASE_HCLINICA_P2.xpisosenomax_hp2
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtagujeromento_hp2.Text = CLASE_HCLINICA_P2.xagujeromento_hp2

                    HCP2.dispose()
                    HCP2 = Nothing

                    'Historia Clinica P3

                    HCP3 = New CLASE_HCLINICA_P3
                    HCP3.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HCP3.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HCP3.Seleccionar("registro")

                    If Mid(CLASE_HCLINICA_P3.xfrentelineamsuper_hp3, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineasupercentr.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineasupercentr.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_P3.xfrentelineamsuper_hp3, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeder.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeder.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_P3.xfrentelineamsuper_hp3, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeizq.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineasuperdeizq.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm1_hp3.Text = CLASE_HCLINICA_P3.xfrentelineamsupermm1_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineamsupermm2_hp3.Text = CLASE_HCLINICA_P3.xfrentelineamsupermm2_hp3

                    If Mid(CLASE_HCLINICA_P3.xfrentelineaminfer_hp3, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfecentr.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfecentr.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_P3.xfrentelineaminfer_hp3, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfededer.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfededer.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_P3.xfrentelineaminfer_hp3, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfedeizq.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.chklineainfedeizq.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm1_hp3.Text = CLASE_HCLINICA_P3.xfrentelineaminfermm1_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentelineaminfermm2_hp3.Text = CLASE_HCLINICA_P3.xfrentelineaminfermm2_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverbite_hp3.Text = CLASE_HCLINICA_P3.xfrenteoverbite_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrenteoverjet_hp3.Text = CLASE_HCLINICA_P3.xfrenteoverjet_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtfrentedientesausen_hp3.Text = CLASE_HCLINICA_P3.xfrentedientesausen_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtldereoverject_hp3.Text = CLASE_HCLINICA_P3.xldereoverject_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderoverbite_hp3.Text = CLASE_HCLINICA_P3.xlderoverbite_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelcanina_hp3.Text = CLASE_HCLINICA_P3.xlderrelcanina_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderrelmolar_hp3.Text = CLASE_HCLINICA_P3.xlderrelmolar_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlderdientesausen_hp3.Text = CLASE_HCLINICA_P3.xlderdientesausen_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverject_hp3.Text = CLASE_HCLINICA_P3.xlizquoverject_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizquoverbite_hp3.Text = CLASE_HCLINICA_P3.xlizquoverbite_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelcanina_hp3.Text = CLASE_HCLINICA_P3.xlizqurelcanina_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqurelmolar_hp3.Text = CLASE_HCLINICA_P3.xlizqurelmolar_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlizqudientesausen_hp3.Text = CLASE_HCLINICA_P3.xlizqudientesausen_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupforma_hp3.Text = CLASE_HCLINICA_P3.xarcsupforma_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupsime_hp3.Text = CLASE_HCLINICA_P3.xarcsupsime_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcsupausen_hp3.Text = CLASE_HCLINICA_P3.xarcsupausen_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfforma_hp3.Text = CLASE_HCLINICA_P3.xarcinfforma_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfsime_hp3.Text = CLASE_HCLINICA_P3.xarcinfsime_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtarcinfausen_hp3.Text = CLASE_HCLINICA_P3.xarcinfausen_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdesviacion_hp3.Text = CLASE_HCLINICA_P3.xaarticdesviacion_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticdeflexion_hp3.Text = CLASE_HCLINICA_P3.xaarticdeflexion_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticruidosart_hp3.Text = CLASE_HCLINICA_P3.xaarticruidosart_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtaarticsintomat_hp3.Text = CLASE_HCLINICA_P3.xaarticsintomat_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialtperfil_hp3.Text = CLASE_HCLINICA_P3.xdfacialtperfil_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangconje_hp3.Text = CLASE_HCLINICA_P3.xdfacialangconje_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfaciallabios_hp3.Text = CLASE_HCLINICA_P3.xdfaciallabios_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdfacialangnasolab_hp3.Text = CLASE_HCLINICA_P3.xdfacialangnasolab_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquclase_hp3.Text = CLASE_HCLINICA_P3.xdesquclase_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdesquesqu_hp3.Text = CLASE_HCLINICA_P3.xdesquesqu_hp3
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdesqudimensvert_hp3.Text = CLASE_HCLINICA_P3.xdesqudimensvert_hp3

                    HCP3.dispose()
                    HCP3 = Nothing

                    'Historia Clinica P4

                    HCP4 = New CLASE_HCLINICA_P4
                    HCP4.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HCP4.p_IdTusuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HCP4.Seleccionar("registro")

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmalomolar_hp4.Text = CLASE_HCLINICA_P4.xmalomolar_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmalocanina_hp4.Text = CLASE_HCLINICA_P4.xmalocanina_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttdenticion_hp4.Text = CLASE_HCLINICA_P4.xtdenticion_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlmedias_hp4.Text = CLASE_HCLINICA_P4.xlmedias_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtoverjet_hp4.Text = CLASE_HCLINICA_P4.xoverjet_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtoverbite_hp4.Text = CLASE_HCLINICA_P4.xoverbite_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtdientesausentes_hp4.Text = CLASE_HCLINICA_P4.xdientesausentes_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txttipoapi_hp4.Text = CLASE_HCLINICA_P4.xtipoapi_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtmejorarperfil_hp4.Text = CLASE_HCLINICA_P4.xmejorarperfil_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfil_hp4.Text = CLASE_HCLINICA_P4.xcorrperfil_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtangnasolab_hp4.Text = CLASE_HCLINICA_P4.xangnasolab_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlabios_hp4.Text = CLASE_HCLINICA_P4.xlabios_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtctrlperfesq_hp4.Text = CLASE_HCLINICA_P4.xctrlperfesq_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrperfesq_hp4.Text = CLASE_HCLINICA_P4.xcorrperfesq_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcorrfrente_hp4.Text = CLASE_HCLINICA_P4.xcorrfrente_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlograroverjet_hp4.Text = CLASE_HCLINICA_P4.xlograroverjet_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrmolarcan_hp4.Text = CLASE_HCLINICA_P4.xlograrmolarcan_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtlograrbuenaocl_hp4.Text = CLASE_HCLINICA_P4.xlograrbuenaocl_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtplan1_hp4.Text = CLASE_HCLINICA_P4.xplan1_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtplan2_hp4.Text = CLASE_HCLINICA_P4.xplan2_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtplan3_hp4.Text = CLASE_HCLINICA_P4.xplan3_hp4

                    If CLASE_HCLINICA_P4.xtratamortognatico_hp4 = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia.rbTrataSi.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia.rbTrataSi.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia.txtreqtratam_hp4.Text = CLASE_HCLINICA_P4.xreqtratam_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.txtcuantas_hp4.Text = CLASE_HCLINICA_P4.xcuantas_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.texttratamientodef_hp4.Text = CLASE_HCLINICA_P4.xtratamientodef_hp4
                    My.Forms.frmHistoriaClinicaOrtodoncia.textlimitacaso_hp4.Text = CLASE_HCLINICA_P4.xlimitacaso_hp4

                    HCP4.dispose()
                    HCP4 = Nothing

                    EVEN.bloquaerdesbloquear("editarhcorto")
                    EVEN = Nothing

                Else

                    MsgBox("El paciente aun no Tiene registrada esta Historia Clinica", MsgBoxStyle.OkOnly, "Historias Clinicas")
                    My.Forms.frmHistoriaClinicaOrtodoncia.btnImprimirHClinica.Enabled = False

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("nuevahcorto")
                    EVEN = Nothing

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ENVIO SMS PERSONALIZADO") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnCirugia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCirugia.Click

        'Process.Start(Application.StartupPath  "\SoporteRemoto.exe")
        Shell(Application.StartupPath & "\vpss.exe", AppWinStyle.NormalFocus)

    End Sub

    Private Sub btnHCOrtodoncia2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHCOrtodoncia2.Click

        Try

            If Me.lblActivoPaciente.Text = "" Then

                MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Historias Clinicas")
                btnBuscar_Click(sender, e)

            Else

                frmHistoriaClinicaOrtodoncia2.MdiParent = Me
                'Display the new form.
                frmHistoriaClinicaOrtodoncia2.Show()
                frmHistoriaClinicaOrtodoncia2.Activate()

                'Limpiamos
                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcorto2")

                'Cargamos la Historia Clinica Si la Tiene
                'Controlamos que exista un registro de la historia clinica para modificarlo
                'si no existe creamos un nuevo registro al insertarlo en la base de datos

                contar = 0
                contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica_orto2", Me.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    HCORTO2 = New CLASE_HCLINICA_ORTO2
                    HCORTO2.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HCORTO2.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HCORTO2.Seleccionar("registro")

                    'Cargamos los datos en los campos

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtenfermedadanterior_horto2.Text = CLASE_HCLINICA_ORTO2.xenfermedadanterior_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txttratamedico_horto2.Text = CLASE_HCLINICA_ORTO2.xtratamedico_horto2

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckefebriles_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckdiarrea_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckfatiga_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckpeso_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckinfecciones_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.cksudoracion_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckTinmuno_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 8, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckTanti_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 9, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckPvalcard_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 10, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckhEB_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 11, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckhcomuq_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 12, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckhmalcard_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 13, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckhfiebrereu_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 14, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckdiabetes_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 15, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckharterial_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 16, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckpenicilina_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 17, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckanestecia_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 18, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckotros_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xpatologias_horto2, 19, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.ckembarazo_si.Checked = True
                    End If


                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtalergiasotros_horto2.Text = CLASE_HCLINICA_ORTO2.xalergiasotros_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtcresimientodesarrollo_horto2.Text = CLASE_HCLINICA_ORTO2.xcresimientodesarrollo_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtantecedentes_horto2.Text = CLASE_HCLINICA_ORTO2.xantecedentes_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_frente_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_frente_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_labios_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_labios_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_lineasonr_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_lineasonr_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_selladolabial_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_selladolabial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_perfil_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_perfil_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_menton_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_menton_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_angulonaso_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_angulonaso_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_surcolabio_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_surcolabio_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtefacial_otros_horto2.Text = CLASE_HCLINICA_ORTO2.xefacial_otros_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_tejidosblandos_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_tejidosblandos_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_rehabilitacion_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_rehabilitacion_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_endodoncia_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_endodoncia_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_periodoncia_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_periodoncia_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_dientesausentes_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_dientesausentes_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_dientesincluidos_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_dientesincluidos_horto2

                    If Mid(CLASE_HCLINICA_ORTO2.xeoral_examendental_horto2, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chkdenticion.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chkdenticion.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xeoral_examendental_horto2, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chktemporal.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chktemporal.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xeoral_examendental_horto2, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chkmixta.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chkmixta.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO2.xeoral_examendental_horto2, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chkpermanente.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia2.chkpermanente.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_apinamiento_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_apinamiento_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_diastemas_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_diastemas_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_overjet_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_overjet_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_overbite_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_overbite_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_lineamedia_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_lineamedia_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_tamdentario_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_tamdentario_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_formaarcada_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_formaarcada_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_mordidacruzada_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_mordidacruzada_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_curvaspee_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_curvaspee_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_claseangle_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_claseangle_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_bolton_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_bolton_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_habitos_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_habitos_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_atm_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_atm_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_manipulacion_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_manipulacion_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteoral_otros_horto2.Text = CLASE_HCLINICA_ORTO2.xeoral_otros_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtodonto_analisisespacio_horto2.Text = CLASE_HCLINICA_ORTO2.xodonto_analisisespacio_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_sna_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_sna_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_sna_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_sna_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_sna_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_sna_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_snb_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_snb_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_snb_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_snb_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_snb_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_snb_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_anb_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_anb_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_anb_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_anb_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_anb_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_anb_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pp_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_1pp_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pp_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_1pp_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pp_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_1pp_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pm_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_1pm_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pm_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_1pm_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_1pm_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_1pm_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_go_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_go_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_go_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_go_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_go_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_go_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_max_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_max_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_max_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_max_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_max_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_max_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_otros_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_otros_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_otros_control_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_otros_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txteesque_otros_final_horto2.Text = CLASE_HCLINICA_ORTO2.xeesque_otros_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_modelos_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_modelos_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_modelos_control_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_modelos_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_modelos_final_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_modelos_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_pano_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_pano_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_pano_control_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_pano_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_pano_final_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_pano_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_perfil_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_perfil_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_perfil_control_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_perfil_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_perfil_final_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_perfil_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_intra_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_intra_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_intra_control_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_intra_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_intra_final_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_intra_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_extra_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_extra_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_extra_control_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_extra_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_extra_final_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_extra_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_otras_inicial_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_otras_inicial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_otras_control_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_otras_control_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtreg_otras_final_horto2.Text = CLASE_HCLINICA_ORTO2.xreg_otras_final_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtdiag_facial_horto2.Text = CLASE_HCLINICA_ORTO2.xdiag_facial_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtdiag_esque_horto2.Text = CLASE_HCLINICA_ORTO2.xdiag_esque_horto2
                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtdiag_dental_horto2.Text = CLASE_HCLINICA_ORTO2.xdiag_dental_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtplantratamiento_horto2.Text = CLASE_HCLINICA_ORTO2.xplantratamiento_horto2

                    My.Forms.frmHistoriaClinicaOrtodoncia2.txtalternativas_horto2.Text = CLASE_HCLINICA_ORTO2.xalternativas_horto2

                    HCORTO2.dispose()
                    HCORTO2 = Nothing

                    EVEN.bloquaerdesbloquear("editarhcorto2")
                    EVEN = Nothing

                Else

                    MsgBox("El paciente aun no Tiene registrada esta Historia Clinica", MsgBoxStyle.OkOnly, "Historias Clinicas")

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("nuevahcorto2")
                    EVEN = Nothing

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ENVIO SMS PERSONALIZADO") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try

    End Sub

    Private Sub btnHCOrtodoncia3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHCOrtodoncia3.Click

        Try

            If Me.lblActivoPaciente.Text = "" Then

                MsgBox("Escoja un paciente por favor por favor", MsgBoxStyle.OkOnly, "Historias Clinicas")
                btnBuscar_Click(sender, e)

            Else

                frmHistoriaClinicaOrtodoncia3.MdiParent = Me
                'Display the new form.
                frmHistoriaClinicaOrtodoncia3.Show()
                frmHistoriaClinicaOrtodoncia3.Activate()

                'Limpiamos
                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarhcorto3")

                'Cargamos la Historia Clinica Si la Tiene
                'Controlamos que exista un registro de la historia clinica para modificarlo
                'si no existe creamos un nuevo registro al insertarlo en la base de datos

                contar = 0
                contar = CLASE_GENERAL.contar2("IdUsuario", "hclinica_orto3", Me.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    HCORTO3 = New CLASE_HCLINICA_ORTO3
                    HCORTO3.p_IdUsuario = Me.lblActivoPaciente.Tag
                    HCORTO3.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente 
                    HCORTO3.Seleccionar("registro")

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtmconsulta_horto3.Text = CLASE_HCLINICA_ORTO3.xmconsulta_horto3

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckconciente_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckproblemadental_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckfatiga_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckdeporte_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckinstrumento_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckrevision_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckSedadental_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 8, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckpadeceenfermedad_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 9, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckmedicamento_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 10, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckalergias_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 11, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckinfgarganta_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 12, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckamigdalas_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 13, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckadenoides_si.Checked = True
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xopciones_horto3, 14, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.ckcirugia_si.Checked = True
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtparentezco_horto3.Text = CLASE_HCLINICA_ORTO3.xparentezco_horto3


                    If Mid(CLASE_HCLINICA_ORTO3.xhabitos_horto3, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkChuparsededos.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkChuparsededos.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xhabitos_horto3, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkMorderseunas.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkMorderseunas.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xhabitos_horto3, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkMorderselabios.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkMorderselabios.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xhabitos_horto3, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkRespirarboca.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkRespirarboca.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xhabitos_horto3, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkRechinarDientes.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkRechinarDientes.Checked = False
                    End If


                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcepillarseveces_horto3.Text = CLASE_HCLINICA_ORTO3.xcepillarseveces_horto3

                    If Mid(CLASE_HCLINICA_ORTO3.xazucares_horto3, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkExcesiva.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkExcesiva.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xazucares_horto3, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkRegular.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkRegular.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xazucares_horto3, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkBaja.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkBaja.Checked = False
                    End If


                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtobservaciones_horto3.Text = CLASE_HCLINICA_ORTO3.xobservaciones_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtenfermedadactual_horto3.Text = CLASE_HCLINICA_ORTO3.xenfermedadactual_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtmedicamento_horto3.Text = CLASE_HCLINICA_ORTO3.xmedicamento_horto3

                    If Mid(CLASE_HCLINICA_ORTO3.xafecciones_horto3, 1, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkDesordenes.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkDesordenes.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xafecciones_horto3, 2, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkSangrado.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkSangrado.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xafecciones_horto3, 3, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkAnomaliasCong.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkAnomaliasCong.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xafecciones_horto3, 4, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkFiebreReum.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkFiebreReum.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xafecciones_horto3, 5, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkEConvulsivas.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkEConvulsivas.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xafecciones_horto3, 6, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkObstruccionNasal.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkObstruccionNasal.Checked = False
                    End If

                    If Mid(CLASE_HCLINICA_ORTO3.xafecciones_horto3, 7, 1) = "1" Then
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkAccidentescara.Checked = True
                    Else
                        My.Forms.frmHistoriaClinicaOrtodoncia3.chkAccidentescara.Checked = False
                    End If

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcuandoafecciones_horto3.Text = CLASE_HCLINICA_ORTO3.xcuandoafecciones_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtalergiasaque_horto3.Text = CLASE_HCLINICA_ORTO3.xalergiasaque_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcuandoamigdalas_horto3.Text = CLASE_HCLINICA_ORTO3.xcuandoamigdalas_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcuandoadenoides_horto3.Text = CLASE_HCLINICA_ORTO3.xcuandoadenoides_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtcualcirugia_horto3.Text = CLASE_HCLINICA_ORTO3.xcualcirugia_horto3

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtsna_horto3.Text = CLASE_HCLINICA_ORTO3.xsna_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtsnb_horto3.Text = CLASE_HCLINICA_ORTO3.xsnb_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtanb_horto3.Text = CLASE_HCLINICA_ORTO3.xanb_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtipp_horto3.Text = CLASE_HCLINICA_ORTO3.xipp_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtina_horto3.Text = CLASE_HCLINICA_ORTO3.xina_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtipm_horto3.Text = CLASE_HCLINICA_ORTO3.xipm_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtinb_horto3.Text = CLASE_HCLINICA_ORTO3.xinb_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtles_horto3.Text = CLASE_HCLINICA_ORTO3.xles_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtlei_horto3.Text = CLASE_HCLINICA_ORTO3.xlei_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtgo_horto3.Text = CLASE_HCLINICA_ORTO3.xgo_horto3

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtobservacionesaencef_horto3.Text = CLASE_HCLINICA_ORTO3.xobservacionesaencef_horto3

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_facial_horto3.Text = CLASE_HCLINICA_ORTO3.xdiag_facial_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_esque_horto3.Text = CLASE_HCLINICA_ORTO3.xdiag_esque_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_dental_horto3.Text = CLASE_HCLINICA_ORTO3.xdiag_dental_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtdiag_periodontal_horto3.Text = CLASE_HCLINICA_ORTO3.xdiag_periodontal_horto3

                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtplantratamiento_horto3.Text = CLASE_HCLINICA_ORTO3.xplantratamiento_horto3
                    My.Forms.frmHistoriaClinicaOrtodoncia3.txtalternativas_horto3.Text = CLASE_HCLINICA_ORTO3.xalternativas_horto3

                    HCORTO3.dispose()
                    HCORTO3 = Nothing

                    EVEN.bloquaerdesbloquear("editarhcorto3")
                    EVEN = Nothing

                Else

                    MsgBox("El paciente aun no Tiene registrada esta Historia Clinica", MsgBoxStyle.OkOnly, "Historias Clinicas")

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("nuevahcorto3")
                    EVEN = Nothing

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Historias Clinicas") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnBuscarHuella_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarHuella.Click

        frmBuscarHuella.Show()
        frmBuscarHuella.Activate()

    End Sub


    Private Sub VerificationControl_OnComplete(ByVal Control As System.Object, ByVal FeatureSet As DPFP.FeatureSet, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles VerificationControl.OnComplete

        Try

            'Verificamos Variables de Biometrico

            Dim ver As New DPFP.Verification.Verification()
            Dim res As New DPFP.Verification.Verification.Result()


            'Cargamos los Items para la busqueda

            HUELLA = New CLASE_HUELLAS
            HUELLA.p_IdTUsuario = 1 'Tipo Paciente
            HUELLA.Seleccionar("items")

            Dim i As Integer

            If CLASE_GENERAL.xdt2.Rows.Count > 0 Then

                For i = 0 To CLASE_GENERAL.xdt2.Rows.Count - 1

                    cargarhuellitas(CLASE_GENERAL.xdt2.Rows(i).Item("IdUsuario"))

                    For Each template As DPFP.Template In Data.Templates    ' Compare feature set with all stored templates:
                        If Not template Is Nothing Then                     '   Get template from storage.
                            ver.Verify(FeatureSet, template, res)           '   Compare feature set with particular template.
                            Data.IsFeatureSetMatched = res.Verified         '   Check the result of the comparison
                            Data.FalseAcceptRate = res.FARAchieved          '   Determine the current False Accept Rate
                            If res.Verified Then
                                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Success
                                Exit For ' success
                            End If
                        End If

                    Next

                    If Not res.Verified Then

                        EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
                        Data.Update()

                    Else


                        EVEN = New CLASE_EVENTOS
                        EVEN.cargarpacienteficha(CLASE_GENERAL.xdt2.Rows(i).Item("IdUsuario"))
                        EVEN = Nothing

                        HUELLA.dispose()
                        HUELLA = Nothing

                        Exit Sub

                    End If

                Next

            Else

                MessageBox.Show("No hay registros Biometicos de Pacientes", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub ExpandableSplitter1_ExpandedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs)

        CalOrthosoft.Refresh()
        CalOrthosoft.Update()

    End Sub

    Private Sub mnuHorarioDoctores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHorarioDoctores.Click
        'Set the Parent Form of the Child window.
        frmHorarios.MdiParent = Me
        'Display the new form.
        frmHorarios.Show()
        frmHorarios.Activate()

    End Sub

    Private Sub btnCitaModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaModificar2.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar la Cita", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

        If respuesta = MsgBoxResult.Yes Then
            modificarcita()
        End If

    End Sub

    Private Sub btnSkype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkype.Click

        frmskype.MdiParent = Me
        'Display the new form.
        frmskype.Show()
        frmskype.Activate()

    End Sub
End Class
