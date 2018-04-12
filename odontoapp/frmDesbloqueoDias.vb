Imports Microsoft.VisualBasic
Imports System.Math


Public Class frmDesbloqueoDias

    Private contar As Integer
    Private fecha As Date
    Private fechaaux As Date
    Private diasdiferencia As Integer


    Private CAL As CLASE_CALENDARIO
    Private SCHE As CLASE_SCHEDULER
    Private CTRL As CLASE_CONTROL

    Private Sub btnBloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloquear.Click

        Try

            MsgBox("Desea Bloquear los Días Seleccionado ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Bloqueo Calendario")

            If MsgBoxResult.Yes Then

                If (CDate(Me.cmbfecfin_bloq.Value) < CDate(Me.cmbfecini_bloq.Value)) Or (CDate(Me.cmbfecfin_bloq.Value) < Date.Now.Date) Or (CDate(Me.cmbfecini_bloq.Value) < Date.Now.Date) Then

                    MessageBox.Show("El intervalo de fechas para el bloqueo no es valido, reviselo por favor.", "Bloquear Calendario", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else

                    diasdiferencia = DateDiff(DateInterval.Day, Me.cmbfecini_bloq.Value, Me.cmbfecfin_bloq.Value)
                    fechaaux = Me.cmbfecini_bloq.Value

                    CAL = New CLASE_CALENDARIO

                    For i As Integer = 1 To diasdiferencia + 1

                        'Buscamos si existe ya registrada la fecha en el control del calendario
                        contar = 0
                        contar = CLASE_GENERAL.contarcalendario(Format(fechaaux, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue)

                        If contar = 0 Then

                            'Buscamos el consecutivo del Calendario 
                            CAL.p_Idcalendario = CLASE_GENERAL.maximo("Idcalendario", "calendario", CLASE_GENERAL.mensaje_error) + 1

                            '*************** INSERTAMOS REGISTROS EN LA BASE DE DATOS **********************

                            CAL.p_fecha = Format(fechaaux, "yyyy-MM-dd")
                            CAL.p_horaini = CLASE_GENERAL._horaini
                            CAL.p_horafin = CLASE_GENERAL._horafin
                            CAL.p_Idcontroldia = 2 ' Bloqueo
                            CAL.p_Iddoctor = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue
                            CAL.p_rangocal = CLASE_GENERAL._rangocal
                            CAL.p_topecita = CLASE_GENERAL._topecita

                            CAL.Insertar(CLASE_GENERAL.mensaje_error)

                        Else

                            'Asignamos los valores a las variables de la clase calendario

                            CAL.p_fecha = Format(fechaaux, "yyyy-MM-dd")
                            CAL.p_Iddoctor = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue
                            CAL.Seleccionar("dia")

                            CAL.p_Idcalendario = CLASE_CALENDARIO.xIdcalendario
                            CAL.p_Idcontroldia = 2

                            CAL.Modificar("estado")


                        End If

                        '********* MODIFICACION DE TEXTOS (Idcalendario) EN EL CALENDARIO Y ASIGNACION DE COLORES *******************
                        My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateText2(fechaaux.Day, CAL.p_Idcalendario)
                        My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateColor(fechaaux.Day, &HFF&) 'Set the background color From gradient color 

                        fechaaux = Format((DateAdd(DateInterval.Day, 1, fechaaux)), "yyyy-MM-dd")

                    Next

                    CAL.dispose()
                    CAL = Nothing

                    '*************** LLENAMOS EL SCHEDULER ******************************************

                    fecha = fechaaux

                    While My.Forms.mdiOrthoSoft.CalOrthosoft.get_DateColor(Day(fecha)) = Drawing.Color.Red
                        fecha = DateAdd(DateInterval.Day, 1, fecha)
                    End While

                    'llenamos el scheduler de un dia siguiente

                    My.Forms.mdiOrthoSoft.CalOrthosoft.Day = Day(fecha)
                    My.Forms.mdiOrthoSoft.CalOrthosoft.Month = Month(fecha)
                    My.Forms.mdiOrthoSoft.CalOrthosoft.Year = Year(fecha)

                    SCHE = New CLASE_SCHEDULER
                    SCHE.llenadoscheduler(fecha)
                    SCHE = Nothing

                    '**************** Llenamos La Tabla Control *************************************

                    CTRL = New CLASE_CONTROL
                    CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    CTRL.p_IdTRegistro = 9 '9 Edita Calendario Paciente
                    CTRL.p_Idproceso = CLASE_GENERAL.maximo("Idcalendario", "calendario", CLASE_GENERAL.mensaje_error)

                    CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                    CTRL.dispose()
                    CTRL = Nothing

                    MsgBox("Modificacion Días registrada con Exito", MsgBoxStyle.OkOnly, "Bloqueo Calendario")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub frmDesbloqueoDias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Datos de combos de fechas

        Me.cmbfecini_bloq.Value = Date.Now
        Me.cmbfecini_desbloq.Value = Date.Now

        Me.cmbfecfin_bloq.Value = Date.Now
        Me.cmbfecfin_desbloq.Value = Date.Now

    End Sub

    Private Sub btnDesbloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesbloquear.Click

        Try

            MsgBox("Desea Desbloquear los Días Seleccionados ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Desbloqueo Calendario")

            If MsgBoxResult.Yes Then

                If Me.cmbfecfin_desbloq.Value < Me.cmbfecini_desbloq.Value Then

                    MessageBox.Show("El intervalo de fechas para el bloqueo no es valido, reviselo por favor.", "Bloquear Calendario", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else

                    diasdiferencia = DateDiff(DateInterval.Day, Me.cmbfecini_desbloq.Value, Me.cmbfecfin_desbloq.Value)
                    fechaaux = Me.cmbfecini_desbloq.Value

                    CAL = New CLASE_CALENDARIO

                    For i As Integer = 1 To diasdiferencia + 1

                        'Buscamos si existe ya registrada la fecha en el control del calendario
                        contar = 0
                        contar = CLASE_GENERAL.contarcalendario2(Format(fechaaux, "yyyy-MM-dd"), My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue, 2)

                        If contar <> 0 Then

                            CAL.p_fecha = Format(fechaaux, "yyyy-MM-dd")
                            CAL.p_Iddoctor = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue
                            CAL.Seleccionar("dia")

                            CAL.p_Idcalendario = CLASE_CALENDARIO.xIdcalendario
                            CAL.Eliminar(CLASE_GENERAL.mensaje_error)

                            My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateColor(fechaaux.Day, &HFFC0C0&) 'Set the background color From gradient color to a light grey/blue
                            My.Forms.mdiOrthoSoft.CalOrthosoft.set_DateText2(fechaaux.Day, "")

                        End If

                        fechaaux = DateAdd(DateInterval.Day, 1, fechaaux)

                    Next


                    CAL.dispose()
                    CAL = Nothing

                    My.Forms.mdiOrthoSoft.CalOrthosoft.Day = Day(fechaaux)
                    My.Forms.mdiOrthoSoft.CalOrthosoft.Month = Month(fechaaux)
                    My.Forms.mdiOrthoSoft.CalOrthosoft.Year = Year(fechaaux)

                    fecha = Format(fechaaux, "yyyy-MM-dd")

                    SCHE = New CLASE_SCHEDULER
                    SCHE.llenadoscheduler(fecha)
                    SCHE = Nothing

                    MsgBox("Modificacion Días registrado con Exito", MsgBoxStyle.OkOnly, "Desbloqueo Calendario")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

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

        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpBloqueo)
        ubicarcontrol(Me.gpDesBloqueo)
        ubicarcontrol(Me.btnBloquear)
        ubicarcontrol(Me.btnDesbloquear)
        ubicarcontrol(Me.btnSalir)


    End Sub


    Private Sub frmDesbloqueoDias_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class