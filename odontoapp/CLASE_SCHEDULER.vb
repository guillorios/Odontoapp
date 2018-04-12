Imports Janus.Windows.Schedule
Imports Microsoft.VisualBasic

Public Class CLASE_SCHEDULER

    Public EVEN As CLASE_EVENTOS

    Public Sub llenadoscheduler(ByVal fecha As Date)

        Try

            '***************************** CARGAMOS EL CALENDARIO DEL SCHEDULER ********************

            'Verificamos que exita un doctor
            If My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = "" Then

                MsgBox("No hay Doctor Activo escojalo por favor", MsgBoxStyle.OkOnly, "Citas")

            Else

                EVEN = New CLASE_EVENTOS

                'Limpiamos le calendario de cualquier basura
                My.Forms.mdiOrthoSoft.CalOrthosoft.ClearDays()

                'Con esta funcion coloreamos el calendario de acuerdo a lo que nececitamos y a lo que esta guardado
                EVEN.calendariomes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")

                '************************************ NUEVA FUNCION ******************************************

                'Verificamos el texto del Clendario Verificando el tipo si esta vacio dejamos los valores por defecto

                If My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day) = "" Then

                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Date = fecha
                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime = My.Forms.mdiOrthoSoft.clcStartTime.Value.TimeOfDay
                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkEndTime = My.Forms.mdiOrthoSoft.clcEndTime.Value.TimeOfDay

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

                    EVEN.bloquaerdesbloquear("nuevocalendario")
                    EVEN.limpiar("limpiarcalendario")
                    EVEN.bloquaerdesbloquear("editardia")
                    My.Forms.mdiOrthoSoft.txtIdCalendario.Text = (CLASE_GENERAL.maximo("IdCalendario", "calendario", CLASE_GENERAL.mensaje_error)) + 1

                Else

                    If My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateColor(Day(fecha)) = Drawing.Color.Red Then


                        EVEN.bloquaerdesbloquear("editarcalendario")
                        EVEN.bloquaerdesbloquear("bloqueardia")
                        EVEN.limpiar("limpiarcalendario")

                        While My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateColor(Day(fecha)) = Drawing.Color.Red
                            fecha = DateAdd(DateInterval.Day, 1, fecha)
                        End While

                        My.Forms.mdiOrthoSoft.CalOrthosoft.Day = Day(fecha)
                        My.Forms.mdiOrthoSoft.CalOrthosoft.Month = Month(fecha)
                        My.Forms.mdiOrthoSoft.CalOrthosoft.Year = Year(fecha)

                        fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

                        If My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day) = "" Then

                            My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Date = fecha
                            My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime = My.Forms.mdiOrthoSoft.clcStartTime.Value.TimeOfDay
                            My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkEndTime = My.Forms.mdiOrthoSoft.clcEndTime.Value.TimeOfDay

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

                            EVEN.bloquaerdesbloquear("nuevocalendario")
                            EVEN.limpiar("limpiarcalendario")
                            EVEN.bloquaerdesbloquear("editardia")
                            EVEN.calendariomes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                            My.Forms.mdiOrthoSoft.txtIdCalendario.Text = (CLASE_GENERAL.maximo("IdCalendario", "calendario", CLASE_GENERAL.mensaje_error)) + 1

                        Else

                            My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Date = fecha
                            My.Forms.mdiOrthoSoft.CalOrthosoft.ClearDays()
                            EVEN.calendariomes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                            EVEN.calendariodia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                            My.Forms.mdiOrthoSoft.txtIdCalendario.Text = My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day)

                        End If

                    Else

                        My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Date = fecha
                        EVEN.bloquaerdesbloquear("editarcalendario")
                        EVEN.bloquaerdesbloquear("editardia")
                        EVEN.calendariodia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                        My.Forms.mdiOrthoSoft.txtIdCalendario.Text = My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day)

                    End If
                End If


                '********************** CARGAMOS LAS CITAS DEL SCHEDULER *******************************

                My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Appointments.Clear()
                My.Forms.mdiOrthoSoft.ScheduleOrhosoft.FirstVisibleTime = My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime

                EVEN.cargarcitasdia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)
                My.Forms.mdiOrthoSoft.ScheduleOrhosoft.FirstVisibleTime = My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime

                'contamos las citas de este día
                My.Forms.mdiOrthoSoft.txtIdcita.Text = (CLASE_GENERAL.maximo("IdCita", "citas", CLASE_GENERAL.mensaje_error))
                My.Forms.mdiOrthoSoft.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                My.Forms.mdiOrthoSoft.lblTotalPacientes.Text = CLASE_GENERAL.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)

                '************************ INICIAMOS EL CONTADOR DE CITAS ****************************

                My.Forms.mdiOrthoSoft.txtIdcita.Text = (CLASE_GENERAL.maximo("IdCita", "citas", CLASE_GENERAL.mensaje_error))
                EVEN.bloquaerdesbloquear("bloquearscheduler")
                EVEN.bloquaerdesbloquear("bloquearcita")
                My.Forms.mdiOrthoSoft.GroupTipoConsulta.Enabled = False

                EVEN = Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Public Sub llenadoschedulerMulti(ByVal fecha As Date)

        Try

            '***************************** CARGAMOS EL CALENDARIO DEL SCHEDULER ********************

            'Verificamos que exita un doctor
            If My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = "" Then

                MsgBox("No hay Doctor Activo escojalo por favor", MsgBoxStyle.OkOnly, "Citas")

            Else

                EVEN = New CLASE_EVENTOS

                'Limpiamos le calendario de cualquier basura
                My.Forms.mdiOrthoSoft.CalOrthosoft.ClearDays()

                'Con esta funcion coloreamos el calendario de acuerdo a lo que nececitamos y a lo que esta guardado
                EVEN.calendariomes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")


                '************************************ NUEVA FUNCION ******************************************

                'Verificamos el texto del Clendario Verificando el tipo si esta vacio dejamos los valores por defecto

                If My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day) = "" Then

                    My.Forms.frmAppointment.ScheduleOrhosoftMulti.Date = fecha
                    My.Forms.frmAppointment.ScheduleOrhosoftMulti.WorkStartTime = My.Forms.mdiOrthoSoft.clcStartTime.Value.TimeOfDay
                    My.Forms.frmAppointment.ScheduleOrhosoftMulti.WorkEndTime = My.Forms.mdiOrthoSoft.clcEndTime.Value.TimeOfDay

                    Select Case CLASE_GENERAL._rangocal
                        Case "5"
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 0
                        Case "10"
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 1
                        Case "15"
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 2
                        Case "30"
                            My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 3
                    End Select

                    EVEN.bloquaerdesbloquear("nuevocalendario")
                    EVEN.limpiar("limpiarcalendario")
                    EVEN.bloquaerdesbloquear("editardia")
                    My.Forms.mdiOrthoSoft.txtIdCalendario.Text = (CLASE_GENERAL.maximo("IdCalendario", "calendario", CLASE_GENERAL.mensaje_error)) + 1

                Else

                    If My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateColor(Day(fecha)) = Drawing.Color.Red Then


                        EVEN.bloquaerdesbloquear("editarcalendario")
                        EVEN.bloquaerdesbloquear("bloqueardia")
                        EVEN.limpiar("limpiarcalendario")

                        While My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateColor(Day(fecha)) = Drawing.Color.Red
                            fecha = DateAdd(DateInterval.Day, 1, fecha)
                        End While

                        My.Forms.mdiOrthoSoft.CalOrthosoft.Day = Day(fecha)
                        My.Forms.mdiOrthoSoft.CalOrthosoft.Month = Month(fecha)
                        My.Forms.mdiOrthoSoft.CalOrthosoft.Year = Year(fecha)

                        fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

                        If My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day) = "" Then

                            My.Forms.frmAppointment.ScheduleOrhosoftMulti.Date = fecha
                            My.Forms.frmAppointment.ScheduleOrhosoftMulti.WorkStartTime = My.Forms.mdiOrthoSoft.clcStartTime.Value.TimeOfDay
                            My.Forms.frmAppointment.ScheduleOrhosoftMulti.WorkEndTime = My.Forms.mdiOrthoSoft.clcEndTime.Value.TimeOfDay

                            Select Case CLASE_GENERAL._rangocal
                                Case "5"
                                    My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 0
                                Case "10"
                                    My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 1
                                Case "15"
                                    My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 2
                                Case "30"
                                    My.Forms.frmAppointment.cmbRangoAgenda.SelectedIndex = 3
                            End Select

                            EVEN.bloquaerdesbloquear("nuevocalendario")
                            EVEN.limpiar("limpiarcalendario")
                            EVEN.bloquaerdesbloquear("editardia")
                            EVEN.calendariomes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                            My.Forms.mdiOrthoSoft.txtIdCalendario.Text = (CLASE_GENERAL.maximo("IdCalendario", "calendario", CLASE_GENERAL.mensaje_error)) + 1

                        Else

                            My.Forms.frmAppointment.ScheduleOrhosoftMulti.Date = fecha
                            My.Forms.mdiOrthoSoft.CalOrthosoft.ClearDays()
                            EVEN.calendariomes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                            EVEN.calendariodia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                            My.Forms.mdiOrthoSoft.txtIdCalendario.Text = My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day)

                        End If

                    Else

                        My.Forms.frmAppointment.ScheduleOrhosoftMulti.Date = fecha
                        EVEN.bloquaerdesbloquear("editarcalendario")
                        EVEN.bloquaerdesbloquear("editardia")
                        EVEN.calendariodia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                        My.Forms.mdiOrthoSoft.txtIdCalendario.Text = My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateText2(My.Forms.mdiOrthoSoft.CalOrthosoft.Day)

                    End If
                End If


                '********************** CARGAMOS LAS CITAS DEL SCHEDULER *******************************

                My.Forms.frmAppointment.ScheduleOrhosoftMulti.Appointments.Clear()
                My.Forms.frmAppointment.ScheduleOrhosoftMulti.FirstVisibleTime = My.Forms.frmAppointment.ScheduleOrhosoftMulti.WorkStartTime

                EVEN.cargarcitasdiaMulti(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)
                My.Forms.frmAppointment.ScheduleOrhosoftMulti.FirstVisibleTime = My.Forms.frmAppointment.ScheduleOrhosoftMulti.WorkStartTime

                'contamos las citas de este día
                My.Forms.mdiOrthoSoft.txtIdcita.Text = (CLASE_GENERAL.maximo("IdCita", "citas", CLASE_GENERAL.mensaje_error))
                My.Forms.mdiOrthoSoft.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                My.Forms.mdiOrthoSoft.lblTotalPacientes.Text = CLASE_GENERAL.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)

                '************************ INICIAMOS EL CONTADOR DE CITAS ****************************

                My.Forms.mdiOrthoSoft.txtIdcita.Text = (CLASE_GENERAL.maximo("IdCita", "citas", CLASE_GENERAL.mensaje_error))
                EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                EVEN.bloquaerdesbloquear("bloquearcitamulti")
                My.Forms.mdiOrthoSoft.GroupTipoConsulta.Enabled = False

                EVEN = Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub


End Class
