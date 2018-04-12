Imports Janus.Windows.Schedule
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports System.Math

Public Class frmAppointment

    Private SCHE As CLASE_SCHEDULER
    Private GENE As CLASE_GENERAL
    Private DOC As CLASE_DOCTORES
    Private EVEN As CLASE_EVENTOS
    Private CONSULTA As CLASE_CONSULTA
    Private CITA As CLASE_CITAS
    Private CTRL As CLASE_CONTROL

    Private fecha As Date
    Private count As Integer = 0

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        My.Forms.mdiOrthoSoft.ExpandableAgenda.Expanded = True
        'Verificamos que es la multiagenda
        CLASE_GENERAL.sheduler = 0
        Me.Close()

        My.Forms.mdiOrthoSoft.CalOrthosoft_ClickEvent(sender, e)

    End Sub

    Private Sub frmAppointment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CLASE_GENERAL.sheduler = 0
    End Sub

    Private Sub frmAppointment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            'Cargamos el tipo de scheduler

            CLASE_GENERAL.sheduler = 1

            'Cargamos las Unidades de la Clinica

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("unidadesagenda", Me.dgUnidades, CLASE_GENERAL.mensaje_error)
            GENE = Nothing
            GRIDSTYLES()

            Me.dgUnidades.ClearSelection()
            'Cargamos los doctores

            CLASE_GENERAL.cargar_combo("doctores", Me.cmbDoctores, CLASE_GENERAL.mensaje_error)
            Me.cmbDoctores.SelectedValue = CLASE_GENERAL._Iddoctor

            '**************************** CARGAMOS LOS TIPOS DE CONSULTA **************************

            'Cargamos los tipos de consulta de acuerdo al doctor y su especialidad

            DOC = New CLASE_DOCTORES
            DOC.p_Iddoctor = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue
            DOC.Seleccionar("especialidad")

            CLASE_GENERAL.cargar_combo("tipoconsultadoctores", Me.cmbTipoConsulta, CLASE_DOCTORES.xIdespecialidad)

            DOC.dispose()
            DOC = Nothing

            'Cargamos las unidades

            If Not (Me.dgUnidades.Rows.Count = 0) Then

                For Each row As DataGridViewRow In Me.dgUnidades.Rows

                    ' Cargar las agendas
                    Dim owner As ScheduleAppointmentOwner

                    owner = New ScheduleAppointmentOwner(CInt(Me.dgUnidades.Rows(row.Index).Cells("Idunidad").Value), Me.dgUnidades.Rows(row.Index).Cells("nom_unidad").Value)
                    owner.Key = CInt(Me.dgUnidades.Rows(row.Index).Cells("Idunidad").Value)

                    Me.ScheduleOrhosoftMulti.Owners.Add(owner)

                Next

            End If

            'llenamos el sheduler

            'Cargamos la fecha Del calendario
            fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

            'Llamamos la clase Sheduler para llenar la agenda
            SCHE = New CLASE_SCHEDULER
            SCHE.llenadoschedulerMulti(fecha)
            SCHE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle
            Style1.Format = "N0"
            Style1.Alignment = DataGridViewContentAlignment.MiddleLeft

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim Style3 As New DataGridViewCellStyle
            Style3.Format = "C0"
            Style3.Alignment = DataGridViewContentAlignment.MiddleRight

            With Me.dgUnidades

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).HeaderText = "OK"
                .Columns(0).Width = 25

                .Columns(1).DefaultCellStyle = Style2
                .Columns(1).HeaderText = "ID"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 30

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "UNIDAD"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 80

            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub


    Private Sub cmbTipoConsulta_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoConsulta.SelectionChangeCommitted

        If (Me.ScheduleOrhosoftMulti.SelectedAppointments.Count > 0) Then

            ' Tipo consulta Brackets

            'cargamos la consulta de acuerdo al color

            CONSULTA = New CLASE_CONSULTA
            CONSULTA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue
            CONSULTA.Seleccionar("tipoconsulta1")

            Me.ScheduleOrhosoftMulti.CurrentAppointment.FormatStyle.BackColor = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.ScheduleOrhosoftMulti.CurrentAppointment.FormatStyle.BackColorGradient = Drawing.Color.White
            Me.ScheduleOrhosoftMulti.CurrentAppointment.FormatStyle.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
            Me.ScheduleOrhosoftMulti.CurrentAppointment.BorderColor = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.lblTipoConsulta.BackColor = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.ScheduleOrhosoftMulti.Refresh()

            CONSULTA.dispose()
            CONSULTA = Nothing


            If Not (Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub

    Private Sub ScheduleOrhosoftMulti_AppointmentChanged(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AppointmentChangeEventArgs) Handles ScheduleOrhosoftMulti.AppointmentChanged

        Try

            If (Me.ScheduleOrhosoftMulti.SelectedAppointments.Count > 0) Then

                Me.SelectedAppointmentChanged2(Me.ScheduleOrhosoftMulti.SelectedAppointments(0))

            Else

                Me.SelectedAppointmentChanged2(Nothing)

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub ScheduleOrhosoftMulti_AppointmentDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles ScheduleOrhosoftMulti.AppointmentDoubleClick

        Try

            Dim WorkStartTime As Date
            Dim WorkEndTime As Date

            Dim AppStartTime As Date
            Dim AppEndTime As Date

            WorkStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.WorkStartTime.ToString), Minute(Me.ScheduleOrhosoftMulti.WorkStartTime.ToString), 0, 0)
            AppStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime.ToString), Minute(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime.ToString), 0, 0)

            WorkEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.WorkEndTime.ToString), Minute(Me.ScheduleOrhosoftMulti.WorkEndTime.ToString), 0, 0)
            AppEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime.ToString), Minute(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime.ToString), 0, 0)

            fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

            If fecha >= DateTime.Today Then

                If (AppStartTime < WorkStartTime) Or (AppEndTime > WorkEndTime) Then

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                    EVEN = Nothing

                    Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()
                    MsgBox("Este Rango de Hora no esta permitido, si quiere habilitarlo modifique el calendario ", MsgBoxStyle.OkOnly, "Citas")


                Else

                    If My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = "" Then

                        Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()


                        EVEN = New CLASE_EVENTOS
                        EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                        EVEN = Nothing


                        MsgBox("No hay Doctor Activo escojalo por favor", MsgBoxStyle.OkOnly, "Citas")

                    Else

                        If My.Forms.mdiOrthoSoft.lblActivoPaciente.Text = "" Then

                            Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()

                            EVEN = New CLASE_EVENTOS
                            EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                            EVEN = Nothing

                            MsgBox("No hay Paciente Activo escojalo por favor", MsgBoxStyle.OkOnly, "Citas")

                        Else

                            If My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Salmon Then

                                Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()

                                EVEN = New CLASE_EVENTOS
                                EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                                EVEN = Nothing

                                MsgBox("El Paciente esta bloqueado", MsgBoxStyle.OkOnly, "Citas")


                            Else

                                If My.Forms.mdiOrthoSoft.PnlActivoPaciente.Style.BackColor2 = Color.Khaki Then

                                    Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()

                                    EVEN = New CLASE_EVENTOS
                                    EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                                    EVEN = Nothing

                                    MsgBox("El Paciente esta Retirado", MsgBoxStyle.OkOnly, "Citas")


                                Else

                                    If CInt(My.Forms.mdiOrthoSoft.lblTotalPacientes.Text) >= CInt(My.Forms.mdiOrthoSoft.txtTopeCita.Text) Then

                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()

                                        EVEN = New CLASE_EVENTOS
                                        EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                                        EVEN = Nothing

                                        MsgBox("No se puede adicionar mas registros, El tope de cita llego a su limite", MsgBoxStyle.OkOnly, "Citas")

                                    Else

                                        My.Forms.mdiOrthoSoft.txtIdcita.Text = My.Forms.mdiOrthoSoft.txtIdcita.Text + 1
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.Text = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag & ", " & My.Forms.mdiOrthoSoft.lblActivoPaciente.Text
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag = My.Forms.mdiOrthoSoft.txtIdcita.Text
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 0

                                        Me.GroupTipoConsulta.Enabled = True
                                        Me.GroupNotaCita.Enabled = True

                                        EVEN = New CLASE_EVENTOS
                                        EVEN.limpiar("limpiarschedulernuevomulti")
                                        EVEN = Nothing

                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex2 = 3
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex3 = 5
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.FormatStyle.BackColor = Drawing.Color.LimeGreen
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.FormatStyle.BackColorGradient = Drawing.Color.White
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.FormatStyle.BackgroundGradientMode = BackgroundGradientMode.DiagonalBackwards
                                        Me.ScheduleOrhosoftMulti.CurrentAppointment.BorderColor = Drawing.Color.LimeGreen

                                        EVEN = New CLASE_EVENTOS
                                        EVEN.bloquaerdesbloquear("nuevoschedulermulti")
                                        EVEN.bloquaerdesbloquear("bloquearcitamulti")
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
                EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                EVEN = Nothing

                Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()
                MsgBox("No se pueden asignar citas en fecha pasada, revise por favor  ", MsgBoxStyle.OkOnly, "Citas")


            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub ScheduleOrhosoftMulti_SelectedAppointmentsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScheduleOrhosoftMulti.SelectedAppointmentsChanged

        Try

            If (Me.ScheduleOrhosoftMulti.SelectedAppointments.Count > 0) Then

                Me.SelectedAppointmentChanged(Me.ScheduleOrhosoftMulti.SelectedAppointments(0))

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


                
                '******************* CARGAMOS LOS DATOS DEL PACIENTE *******************************

                Dim y As Integer = appointment.Text.IndexOf(",")
                Dim Idpaciente As String
                Idpaciente = appointment.Text.Substring(0, y).TrimEnd()

                Me.ScheduleOrhosoftMulti.ShowTimeHintOnAppointments = TimeHintOnAppointments.Always

                '******************* CARGAMOS LOS DATOS EN LA FICHA ********************************

                EVEN = New CLASE_EVENTOS
                EVEN.cargarpacienteficha(Idpaciente)
                EVEN = Nothing

                '*************************** verificamos que no sea un archivo para grabar **************************

                My.Forms.mdiOrthoSoft.txtIdPacienteTagScheduler.Text = appointment.Tag

                If appointment.ImageIndex1 = 0 Then

                    EVEN.bloquaerdesbloquear("nuevoschedulermulti")
                    EVEN.bloquaerdesbloquear("bloquearcitamulti")
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
                        EVEN.bloquaerdesbloquear("editarschedulermulti")
                        EVEN.bloquaerdesbloquear("editarcitamulti")
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
                        EVEN.bloquaerdesbloquear("editarschedulermulti")
                        EVEN.bloquaerdesbloquear("editarcitamulti")
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

            EVEN.bloquaerdesbloquear("bloquearschedulermulti")
            EVEN.bloquaerdesbloquear("bloquearcitamulti")
            Me.GroupTipoConsulta.Enabled = False
            Me.GroupNotaCita.Enabled = False
            Me.txtnotacita.Text = ""
            Me.ScheduleOrhosoftMulti.ShowTimeHintOnAppointments = TimeHintOnAppointments.Automatic

            EVEN = Nothing

        End If


    End Sub
    Private Sub adicionarcita()

        Try

            Dim WorkStartTime As Date
            Dim WorkEndTime As Date

            Dim AppStartTime As Date
            Dim AppEndTime As Date

            WorkStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.WorkStartTime.ToString), Minute(Me.ScheduleOrhosoftMulti.WorkStartTime.ToString), 0, 0)
            AppStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime.ToString), Minute(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime.ToString), 0, 0)

            WorkEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.WorkEndTime.ToString), Minute(Me.ScheduleOrhosoftMulti.WorkEndTime.ToString), 0, 0)
            AppEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime.ToString), Minute(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime.ToString), 0, 0)

            If (AppStartTime < WorkStartTime) Or (AppEndTime > WorkEndTime) Then


                MsgBox("Este Rango de Hora no esta permitido, si quiere habilitarlo modifique el calendario ", MsgBoxStyle.OkOnly, "Citas")


            Else

                If CInt(My.Forms.mdiOrthoSoft.lblTotalPacientes.Text) >= CInt(My.Forms.mdiOrthoSoft.txtTopeCita.Text) Then

                    Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("bloquearschedulermulti")
                    EVEN = Nothing

                    MsgBox("No se puede adicionar mas registros, El tope de cita llego a su limite", MsgBoxStyle.OkOnly, "Citas")

                Else

                    CITA = New CLASE_CITAS
                    EVEN = New CLASE_EVENTOS

                    'Asignamos los valores a las variables de la clase calendario
                    CITA.p_Idcita = Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag
                    CITA.p_fecha = Format(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime, "yyyy-MM-dd")
                    CITA.p_horaini = Format(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime, "HH:mm:ss")
                    CITA.p_horafin = Format(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime, "HH:mm:ss")

                    CITA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue

                    Dim i As Integer = Me.ScheduleOrhosoftMulti.CurrentAppointment.Text.IndexOf(",")
                    Dim Idpaciente As String

                    Idpaciente = Me.ScheduleOrhosoftMulti.CurrentAppointment.Text.Substring(0, i).TrimEnd()

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
                    CITA.p_Idunidad = Me.ScheduleOrhosoftMulti.CurrentAppointment.Owner

                    '*************** INSERTAMOS REGISTROS EN LA BASE DE DATOS **********************

                    CITA.Insertar(CLASE_GENERAL.mensaje_error)
                    CITA.dispose() ' Liberamos recursos
                    CITA = Nothing

                    '*************** INGRESAMOS ASPECTOS DE CONTROL A LA CITA **********************

                    Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = -1
                    EVEN.bloquaerdesbloquear("editarcitamulti")
                    EVEN.bloquaerdesbloquear("editarschedulermulti")

                    fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
                    'contamos las citas de este día
                    My.Forms.mdiOrthoSoft.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                    My.Forms.mdiOrthoSoft.lblTotalPacientes.Text = CLASE_GENERAL.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), Me.cmbDoctores.SelectedValue)

                    '**************** Llenamos La Tabla Control *************************************

                    CTRL = New CLASE_CONTROL
                    CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    CTRL.p_IdTRegistro = 1 '1 Asignar Cita
                    CTRL.p_Idproceso = Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag

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

            WorkStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.WorkStartTime.ToString), Minute(Me.ScheduleOrhosoftMulti.WorkStartTime.ToString), 0, 0)
            AppStartTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime.ToString), Minute(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime.ToString), 0, 0)

            WorkEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.WorkEndTime.ToString), Minute(Me.ScheduleOrhosoftMulti.WorkEndTime.ToString), 0, 0)
            AppEndTime = New Date(2000, 1, 1, Hour(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime.ToString), Minute(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime.ToString), 0, 0)

            If (AppStartTime < WorkStartTime) Or (AppEndTime > WorkEndTime) Then

                MsgBox("Este Rango de Hora no esta permitido, si quiere habilitarlo modifique el calendario ", MsgBoxStyle.OkOnly, "Citas")

            Else

                CITA = New CLASE_CITAS
                CITA.p_Idcita = Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag
                CITA.p_fecha = Format(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime, "yyyy-MM-dd")
                CITA.p_horaini = Format(Me.ScheduleOrhosoftMulti.CurrentAppointment.StartTime, "HH:mm:ss")
                CITA.p_horafin = Format(Me.ScheduleOrhosoftMulti.CurrentAppointment.EndTime, "HH:mm:ss")

                CITA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue

                Dim i As Integer = Me.ScheduleOrhosoftMulti.CurrentAppointment.Text.IndexOf(",")
                Dim Idpaciente As String
                Idpaciente = Me.ScheduleOrhosoftMulti.CurrentAppointment.Text.Substring(0, i).TrimEnd()

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
                CITA.p_Idunidad = Me.ScheduleOrhosoftMulti.CurrentAppointment.Owner

                CITA.Modificar(CLASE_GENERAL.mensaje_error)
                CITA.dispose() ' Liberamos recursos
                CITA = Nothing

                Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = -1

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 3 '1 Modificar Cita
                CTRL.p_Idproceso = Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)

                CTRL.dispose()
                CTRL = Nothing

                MsgBox("Cita Modificada con Exito", MsgBoxStyle.OkOnly, "Citas")

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub rbtCanceladaSi_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtCanceladaSi.MouseClick

        If (Me.ScheduleOrhosoftMulti.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex2 = 2
            Me.ScheduleOrhosoftMulti.Refresh()

            If Not (Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub
    Private Sub rbtCanceladaNo_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtCanceladaNo.MouseClick

        If (Me.ScheduleOrhosoftMulti.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex2 = 3
            Me.ScheduleOrhosoftMulti.Refresh()

            If Not (Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 0) Then
                Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub

    Private Sub rbtAsistioSi_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtAsistioSi.MouseClick

        If (Me.ScheduleOrhosoftMulti.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex3 = 4
            Me.ScheduleOrhosoftMulti.Refresh()

            If Not (Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 1

                Dim respuesta As Integer
                respuesta = MsgBox("La cita fue Modificada desea guardarla ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

                If respuesta = MsgBoxResult.Yes Then

                    modificarcita()

                End If

            End If

        End If

    End Sub

    Private Sub rbtAsistioNo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rbtAsistioNo.MouseClick

        If (Me.ScheduleOrhosoftMulti.SelectedAppointments.Count > 0) Then

            Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex3 = 5
            Me.ScheduleOrhosoftMulti.Refresh()

            If Not (Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 0) Then

                Me.ScheduleOrhosoftMulti.CurrentAppointment.ImageIndex1 = 1

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

                                fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
                                SCHE.llenadoschedulerMulti(fecha)

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

    Private Sub btnCitaImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaImprimir.Click

        Try


            CITA = New CLASE_CITAS
            CITA.p_Idcita = Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag

            CITA.Seleccionar("imprimircitapaciente")

            Dim oRptSuCitaPaciente As New rptSuCitaPaciente()
            Dim toTexto As TextObject

            frmInformes.MdiParent = My.Forms.mdiOrthoSoft

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

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            CITA.dispose()
            CITA = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia
    End Sub

    Private Sub btnCitaEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar La Cita", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

        If respuesta = 6 Then

            Try

                CITA = New CLASE_CITAS

                CITA.p_Idcita = Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag
                CITA.Eliminar(CLASE_GENERAL.mensaje_error)
                CITA.dispose()
                CITA = Nothing

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 2 '1 Eliminar Cita
                CTRL.p_Idproceso = Me.ScheduleOrhosoftMulti.CurrentAppointment.Tag

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                Me.ScheduleOrhosoftMulti.CurrentAppointment.Delete()

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("bloquearschedulermulti")

                fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
                'contamos las citas de este día
                My.Forms.mdiOrthoSoft.lblTituloPacientes.Text = UCase(Format(fecha, "Long Date"))
                My.Forms.mdiOrthoSoft.lblTotalPacientes.Text = CLASE_GENERAL.contarcitaspacientes(Format(fecha, "yyyy-MM-dd"), Me.cmbDoctores.SelectedValue)

                MsgBox("Cita Eliminada con Exito", MsgBoxStyle.OkOnly, "Citas")

                EVEN = Nothing

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If

    End Sub
    Private Sub dgUnidades_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUnidades.CellContentClick

        'If Not (Me.dgUnidades.Rows.Count = 0) Then

        ' Cargar las agendas
        Dim owner As ScheduleAppointmentOwner

        owner = New ScheduleAppointmentOwner(Me.dgUnidades.Rows(e.RowIndex).Cells("Idunidad").Value, Me.dgUnidades.Rows(e.RowIndex).Cells("nom_unidad").Value)
        owner.Key = Me.dgUnidades.Rows(e.RowIndex).Cells("Idunidad").Value

        If dgUnidades.Rows(e.RowIndex).Cells(0).Value = False Then

            count += 1

            dgUnidades.Rows(e.RowIndex).Cells(0).Value = True
            dgUnidades.Update()
            Me.ScheduleOrhosoftMulti.Owners(owner.Key).Visible = True

        Else

            count -= 1

            If count >= 1 Then

                dgUnidades.Rows(e.RowIndex).Cells(0).Value = False
                dgUnidades.Update()
                Me.ScheduleOrhosoftMulti.Owners(owner.Key).Visible = False

            Else

                dgUnidades.Rows(e.RowIndex).Cells(0).Value = True
                dgUnidades.Update()
                dgUnidades.RefreshEdit()

                count += 1

                MsgBox("Debe por lo menos quedar una agenda visible")

            End If


        End If


    End Sub
    Private Sub frmAppointment_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Chequeamos todos los checkboxes

        For i As Integer = 0 To Me.dgUnidades.Rows.Count - 1

            Me.dgUnidades.Rows(i).Cells(0).Value = 1
            Me.dgUnidades.Update()
            count += 1

        Next
    End Sub

    Private Sub btnCitaModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaModificar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar la Cita", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

        If respuesta = MsgBoxResult.Yes Then
            modificarcita()
        End If

    End Sub

    Private Sub btnCitaModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaModificar2.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar la Cita", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Citas")

        If respuesta = MsgBoxResult.Yes Then
            modificarcita()
        End If

    End Sub

    Private Sub btnCitaAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCitaAdicionar.Click
        adicionarcita()
    End Sub

    Private Sub cmbRangoAgenda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRangoAgenda.SelectedIndexChanged

        Select Me.cmbRangoAgenda.SelectedIndex

            Case 0

                Me.ScheduleOrhosoftMulti.Interval = Janus.Windows.Schedule.Interval.FiveMinutes
                Me.ScheduleOrhosoftMulti.FirstVisibleTime = Me.ScheduleOrhosoftMulti.WorkStartTime

            Case 1

                Me.ScheduleOrhosoftMulti.Interval = Janus.Windows.Schedule.Interval.TenMinutes
                Me.ScheduleOrhosoftMulti.FirstVisibleTime = Me.ScheduleOrhosoftMulti.WorkStartTime


            Case 2

                Me.ScheduleOrhosoftMulti.Interval = Janus.Windows.Schedule.Interval.FifteenMinutes
                Me.ScheduleOrhosoftMulti.FirstVisibleTime = Me.ScheduleOrhosoftMulti.WorkStartTime


            Case 3

                Me.ScheduleOrhosoftMulti.Interval = Janus.Windows.Schedule.Interval.ThirtyMinutes
                Me.ScheduleOrhosoftMulti.FirstVisibleTime = Me.ScheduleOrhosoftMulti.WorkStartTime


        End Select

    End Sub
End Class