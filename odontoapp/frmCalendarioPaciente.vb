Public Class frmCalendarioPaciente

    Public even As Clase_eventos
    Public fecha As Date

    Private Sub btnCalSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CalOrthosoft2_ClickEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalOrthosoft2.ClickEvent

        Try

            fecha = Me.CalOrthosoft2.Year & "-" & Format(Me.CalOrthosoft2.Month, "0#") & "-" & Format(Me.CalOrthosoft2.Day, "0#")


            If Me.CalOrthosoft2.get_DateText2(Me.CalOrthosoft2.Day) = "" Then

                '******** CONFIGURACION POR DEFECTO DEL SCHEDULER

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

                even = New Clase_eventos
                even.bloquaerdesbloquear("nuevocalendario")
                even.limpiar("limpiarcalendario")
                even.bloquaerdesbloquear("editardia")
                even = Nothing

                My.Forms.mdiOrthoSoft.txtIdCalendario.Text = (Clase_general.maximo("IdCalendario", "calendario", Clase_general.mensaje_error)) + 1

                '********** CARGAMOS CITAS EN EL SCHEDULER **********************

                My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Appointments.Clear()
                My.Forms.mdiOrthoSoft.ScheduleOrhosoft.FirstVisibleTime = My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime

                even = New Clase_eventos
                even.cargarcitasdia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)
                even = Nothing

                'contamos las citas de este día
                My.Forms.mdiOrthoSoft.txtIdcita.Text = (Clase_general.maximo("IdCita", "citas", Clase_general.mensaje_error))
                My.Forms.mdiOrthoSoft.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                My.Forms.mdiOrthoSoft.lblTotalPacientes.Text = Clase_general.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)

                '************************ INICIAMOS EL CONTADOR DE CITAS ****************************

                My.Forms.mdiOrthoSoft.txtIdcita.Text = (Clase_general.maximo("IdCita", "citas", Clase_general.mensaje_error))

                even = New Clase_eventos
                even.bloquaerdesbloquear("bloquearscheduler")
                even.bloquaerdesbloquear("bloquearcita")
                even = Nothing

                My.Forms.mdiOrthoSoft.GroupTipoConsulta.Enabled = False
                My.Forms.mdiOrthoSoft.GroupNotaCita.Enabled = False


            Else

                If Me.CalOrthosoft2.get_DateColor(Me.CalOrthosoft2.Day) = Drawing.Color.Red Then

                    even = New Clase_eventos
                    even.bloquaerdesbloquear("editarcalendario")
                    even.bloquaerdesbloquear("bloqueardia")
                    even.limpiar("limpiarcalendario")
                    even.calendariodia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft2")
                    even = Nothing

                    My.Forms.mdiOrthoSoft.txtIdCalendario.Text = Me.CalOrthosoft2.get_DateText2(Me.CalOrthosoft2.Day)

                Else


                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Date = fecha

                    even = New Clase_eventos
                    even.bloquaerdesbloquear("editarcalendario")
                    even.bloquaerdesbloquear("editardia")
                    even.calendariodia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, "calorthosoft")
                    even = Nothing

                    My.Forms.mdiOrthoSoft.txtIdCalendario.Text = Me.CalOrthosoft2.get_DateText2(Me.CalOrthosoft2.Day)

                    '************** CARGAMOS LAS CITAS EN EL SCHEDULER ***************************

                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Appointments.Clear()

                    even = New Clase_eventos
                    even.cargarcitasdia(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)
                    even = Nothing

                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.FirstVisibleTime = My.Forms.mdiOrthoSoft.ScheduleOrhosoft.WorkStartTime

                    'contamos las citas de este día
                    My.Forms.mdiOrthoSoft.txtIdcita.Text = (Clase_general.maximo("IdCita", "citas", Clase_general.mensaje_error))
                    My.Forms.mdiOrthoSoft.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                    My.Forms.mdiOrthoSoft.lblTotalPacientes.Text = Clase_general.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)

                    '************************ INICIAMOS EL CONTADOR DE CITAS ****************************

                    My.Forms.mdiOrthoSoft.txtIdcita.Text = (Clase_general.maximo("IdCita", "citas", Clase_general.mensaje_error))

                    even = New Clase_eventos
                    even.bloquaerdesbloquear("bloquearscheduler")
                    even.bloquaerdesbloquear("bloquearcita")
                    even = Nothing

                    My.Forms.mdiOrthoSoft.GroupTipoConsulta.Enabled = False
                    My.Forms.mdiOrthoSoft.GroupNotaCita.Enabled = False

                End If

            End If


        Catch ex As System.NullReferenceException

            MsgBox("No selecciono ninguna Fecha, Intentelo nuevamente por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
End Class