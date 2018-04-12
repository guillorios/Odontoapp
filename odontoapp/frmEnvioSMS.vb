Imports System.Net.Mail
Imports System.Math

Public Class frmEnvioSMS

    Private MENSAJE As CLASE_MENSAJES
    Private PAC As CLASE_PACIENTES
    Private CITA As CLASE_CITAS
    Private CTRL As CLASE_CONTROL
    Private EVEN As CLASE_EVENTOS
    Private REPORTEENVIO As CLASE_REPORTEENVIOS

    Private MENSAJE_SMS As String


    Private Sub btnSMSCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSCargar.Click

        If Me.rbtSMSTodos.Checked = True Then

            Me.lblTituloConsulta.Text = "Todos los Pacientes Activos"

            PAC = New CLASE_PACIENTES
            PAC.Seleccionar("informepacientesSMS")

            Me.dgConsultaSMS.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaSMS.Update()

            GRIDSTYLES("pacientes")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            PAC.dispose()
            PAC = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")

            Me.btnSMSEnviar.Enabled = True


        End If


        If Me.rbtSMSCumpleAños.Checked = True Then

            Me.lblTituloConsulta.Text = "Pacientes Que Cumplen Años Hoy"

            PAC = New CLASE_PACIENTES
            PAC.Seleccionar("informecumpleañoshoySMS")

            Me.dgConsultaSMS.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaSMS.Update()

            GRIDSTYLES("cumpleaños")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            PAC.dispose()
            PAC = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")
            Me.btnSMSEnviar.Enabled = True


        End If

        If Me.rbtSMSCitas.Checked = True Then

            Me.lblTituloConsulta.Text = "Pacientes Que Tienen Citas"

            CITA = New CLASE_CITAS
            CITA.p_fecha = Format(Me.cmbfecini_SMS.Value, "yyyy-MM-dd")
            CITA.p_fecha2 = Format(Me.cmbfecfin_SMS.Value, "yyyy-MM-dd")
            CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

            CITA.Seleccionar("informecitasSMS")

            Me.dgConsultaSMS.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaSMS.Update()

            GRIDSTYLES("citas")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            CITA.dispose()
            CITA = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")
            Me.btnSMSEnviar.Enabled = True


        End If

        If Me.rbtSMSNoAsistieron.Checked = True Then

            Me.lblTituloConsulta.Text = "Pacientes que no Asistieron a su cita"

            CITA = New CLASE_CITAS
            CITA.p_fecha = Format(Me.cmbfecini_SMS.Value, "yyyy-MM-dd")
            CITA.p_fecha2 = Format(Me.cmbfecfin_SMS.Value, "yyyy-MM-dd")
            CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

            CITA.Seleccionar("informecitassinasistirSMS")

            Me.dgConsultaSMS.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaSMS.Update()

            GRIDSTYLES("citas")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            CITA.dispose()
            CITA = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")
            Me.btnSMSEnviar.Enabled = True


        End If


    End Sub

    Private Sub GRIDSTYLES(ByVal opcion As String) ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle
            Style1.Alignment = DataGridViewContentAlignment.BottomLeft

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Select Case opcion

                Case "citas"

                    With Me.dgConsultaSMS

                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                        .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                        .Columns(0).DefaultCellStyle = Style1
                        .Columns(0).HeaderText = "ID"

                        .Columns(1).DefaultCellStyle = Style1
                        .Columns(1).HeaderText = "NOMBRES"

                        .Columns(2).DefaultCellStyle = Style1
                        .Columns(2).HeaderText = "TELEFONO"

                        .Columns(3).DefaultCellStyle = Style1
                        .Columns(3).HeaderText = "CELULAR"

                        .Columns(4).DefaultCellStyle = Style1
                        .Columns(4).HeaderText = "OPERADOR CEL"

                        .Columns(5).DefaultCellStyle = Style1
                        .Columns(5).HeaderText = "DOMINIO"

                        .Columns(6).DefaultCellStyle = Style1
                        .Columns(6).HeaderText = "EMAIL"

                        .Columns(7).DefaultCellStyle = Style2
                        .Columns(7).HeaderText = "FECHA"

                        .Columns(8).DefaultCellStyle = Style2
                        .Columns(8).HeaderText = "HORA INI."

                        .Columns(9).DefaultCellStyle = Style2
                        .Columns(9).HeaderText = "HORA FIN."

                        .Columns(10).DefaultCellStyle = Style2
                        .Columns(10).HeaderText = "CONSULTA"

                    End With

                Case "pacientes"

                    With Me.dgConsultaSMS

                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                        .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                        .Columns(0).DefaultCellStyle = Style1
                        .Columns(0).HeaderText = "ID"

                        .Columns(1).DefaultCellStyle = Style1
                        .Columns(1).HeaderText = "NOMBRES"

                        .Columns(2).DefaultCellStyle = Style1
                        .Columns(2).HeaderText = "TELEFONO"

                        .Columns(3).DefaultCellStyle = Style1
                        .Columns(3).HeaderText = "CELULAR"

                        .Columns(4).DefaultCellStyle = Style1
                        .Columns(4).HeaderText = "OPERADOR CEL"

                        .Columns(5).DefaultCellStyle = Style1
                        .Columns(5).HeaderText = "DOMINIO"

                        .Columns(6).DefaultCellStyle = Style1
                        .Columns(6).HeaderText = "EMAIL"

                    End With

                Case "cumpleaños"

                    With Me.dgConsultaSMS

                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                        .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                        .Columns(0).DefaultCellStyle = Style1
                        .Columns(0).HeaderText = "ID"

                        .Columns(1).DefaultCellStyle = Style1
                        .Columns(1).HeaderText = "NOMBRES"

                        .Columns(2).DefaultCellStyle = Style1
                        .Columns(2).HeaderText = "TELEFONO"

                        .Columns(3).DefaultCellStyle = Style1
                        .Columns(3).HeaderText = "CELULAR"

                        .Columns(4).DefaultCellStyle = Style1
                        .Columns(4).HeaderText = "OPERADOR CEL"

                        .Columns(5).DefaultCellStyle = Style2
                        .Columns(5).HeaderText = "DOMINIO"

                        .Columns(6).DefaultCellStyle = Style2
                        .Columns(6).HeaderText = "EMAIL"

                        .Columns(7).DefaultCellStyle = Style2
                        .Columns(7).HeaderText = "CUMPLEAÑOS"

                    End With

            End Select

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub btnSMSSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnSMSCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSCrear.Click

        CLASE_GENERAL.formload = 18

        My.Forms.frmMensajesEmail.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        My.Forms.frmMensajesEmail.Show()
        My.Forms.frmMensajesEmail.Activate()

    End Sub

    Private Sub frmEnvioSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try


            CLASE_GENERAL.cargar_combo("mensajes", Me.cmbTituloSMS, CLASE_GENERAL.mensaje_error)

            MENSAJE = New CLASE_MENSAJES

            MENSAJE.p_IdMensaje = Me.cmbTituloSMS.SelectedValue
            MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

            Me.RichMensajeSMS.Text = CLASE_MENSAJES.xMensaje

            MENSAJE.dispose()
            MENSAJE = Nothing


        Catch ex As System.InvalidCastException

            MsgBox("No Hay Mensajes en la Base de datos : ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje 

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes SMS") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbTituloSMS_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTituloSMS.SelectionChangeCommitted

        Try

            MENSAJE = New CLASE_MENSAJES

            MENSAJE.p_IdMensaje = Me.cmbTituloSMS.SelectedValue
            MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

            Me.RichMensajeSMS.Text = CLASE_MENSAJES.xMensaje

            MENSAJE.dispose()
            MENSAJE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub rbtSMSCumpleAños_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSMSCumpleAños.CheckedChanged

        Me.gpFecha.Visible = False

        If Not (dgConsultaSMS.Rows.Count = 0) Then

            Me.dgConsultaSMS.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Pacientes Que Cumplen Años Hoy"

    End Sub

    Private Sub rbtSMSCitas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSMSCitas.CheckedChanged

        Me.gpFecha.Visible = True
        Me.cmbfecini_SMS.Value = Format(Now(), "short date")
        Me.cmbfecini_SMS.MinDate = Format(Now(), "short date")
        Me.cmbfecini_SMS.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.cmbfecfin_SMS.Value = Format(Now(), "short date")
        Me.cmbfecfin_SMS.MinDate = Format(Now(), "short date")
        Me.cmbfecfin_SMS.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)

        If Not (dgConsultaSMS.Rows.Count = 0) Then

            Me.dgConsultaSMS.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Pacientes Que Tienen Citas"

    End Sub

    Private Sub rbtSMSNoAsistieron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSMSNoAsistieron.CheckedChanged

        Me.gpFecha.Visible = True
        Me.cmbfecini_SMS.Value = Format(Now(), "short date")
        Me.cmbfecini_SMS.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.cmbfecini_SMS.MaxDate = Format(Now(), "short date")
        Me.cmbfecfin_SMS.Value = Format(Now(), "short date")
        Me.cmbfecfin_SMS.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.cmbfecfin_SMS.MaxDate = Format(Now(), "short date")

        If Not (dgConsultaSMS.Rows.Count = 0) Then

            Me.dgConsultaSMS.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Pacientes que no Asistieron a su cita"

    End Sub

    Private Sub cmbfecini_SMS_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfecini_SMS.ValueChanged

        Me.cmbfecfin_SMS.MinDate = Me.cmbfecini_SMS.Value

    End Sub

    Private Sub btnSMSEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSEnviar.Click

        Dim i As Integer
        Me.prgBarraProgreso.Value = 0

        If Me.cmbTituloSMS.Text = "" Or Me.RichMensajeSMS.Text = "" Then

            MsgBox("Existen Campos Importantes Vacios, el mensaje no se enviará", MsgBoxStyle.OkOnly, "Mensajes SMS")

        Else

            REPORTEENVIO = New CLASE_REPORTEENVIOS
            EVEN = New CLASE_EVENTOS

            For i = 0 To Me.dgConsultaSMS.Rows.Count - 1

                Try

                    '**************** Llenamos La Tabla Reportes ***********************

                    REPORTEENVIO.p_Idreporte = (CLASE_GENERAL.maximo("Idreporte", "reporteenvios ", CLASE_GENERAL.mensaje_error)) + 1
                    REPORTEENVIO.p_estado_reporte = True

                    'creamos un nuevo mensaje de correo

                    Dim correo As New MailMessage

                    'De
                    correo.From = New MailAddress(CLASE_GENERAL.smtpCuenta, CLASE_GENERAL.smtpNombre)

                    'Para
                    correo.To.Add(EVEN.StripString(Trim(Me.dgConsultaSMS.Rows(i).Cells("cel_con").Value.ToString & "@" & Me.dgConsultaSMS.Rows(i).Cells("dominio_oper").Value.ToString)))

                    'Asunto
                    correo.Subject = Me.cmbTituloSMS.Text.ToString

                    'Cuerpo del correo

                    'Cuerpo del correo
                    MENSAJE_SMS = Me.RichMensajeSMS.Text

                    MENSAJE_SMS = MENSAJE_SMS.Replace("<nombre>", Me.dgConsultaSMS.Rows(i).Cells("Nombres").Value.ToString)
                    MENSAJE_SMS = MENSAJE_SMS.Replace("<dia>", Format(Me.dgConsultaSMS.Rows(i).Cells("fecha").Value.ToString, "Long Date"))
                    MENSAJE_SMS = MENSAJE_SMS.Replace("<hora>", Format(CDate(Me.dgConsultaSMS.Rows(i).Cells("horaini").Value.ToString), "hh:mm:ss tt"))
                    MENSAJE_SMS = MENSAJE_SMS.Replace("<procedimiento>", Me.dgConsultaSMS.Rows(i).Cells("nomconsulta").Value.ToString)
                    MENSAJE_SMS = MENSAJE_SMS.Replace("<tel1>", CLASE_GENERAL._tel1_cons)
                    MENSAJE_SMS = MENSAJE_SMS.Replace("<cel>", CLASE_GENERAL._celular_cons)
                    MENSAJE_SMS = MENSAJE_SMS.Replace("<doctor>", CLASE_GENERAL._rtelegal_cons)
                    MENSAJE_SMS = MENSAJE_SMS.Replace("<clinica>", CLASE_GENERAL._razonsocial_cons)

                    correo.Body = MENSAJE_SMS.ToUpper

                    'Mostrar como HTML
                    correo.IsBodyHtml = False

                    'Prioridad de el correo
                    correo.Priority = MailPriority.Normal

                    'acto seguido le indicamos cual servidor utilizaremos
                    'aquì usaremos por default a gmail y su puerto SMTP
                    'pero en una futura entrega les mostraré como hacerlo
                    'cn cualquier servidor

                    Dim smtp As New SmtpClient()

                    'smtp.Host = "smtp.gmail.com"
                    smtp.Host = CLASE_GENERAL.smtpHost

                    'smtp.Port = 587
                    smtp.Port = CLASE_GENERAL.smtpPort

                    smtp.Credentials = New System.Net.NetworkCredential(CLASE_GENERAL.smtpCuenta, CLASE_GENERAL.smtpPass)

                    smtp.EnableSsl = True

                    'listo tenemos la estructura de nuestro mensaje armada ahora enviemosla a nuestro destinatario y listo

                    smtp.Send(correo)



                Catch ex As Exception

                    REPORTEENVIO.p_estado_reporte = False

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaSMS.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Finally

                    REPORTEENVIO.p_estado_reporte = True
                    REPORTEENVIO.p_tipo_reporte = 1 ' Emails
                    REPORTEENVIO.p_Idpaciente = Me.dgConsultaSMS.Rows(i).Cells("Idpaciente").Value.ToString
                    REPORTEENVIO.Insertar(CLASE_GENERAL.mensaje_error)

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaSMS.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                End Try

            Next

            REPORTEENVIO.dispose()
            REPORTEENVIO = Nothing

            Me.prgBarraProgreso.Value = 100
            Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
            Me.prgBarraProgreso.Refresh()

        End If

        '**************** Llenamos La Tabla Control *************************************

        CTRL = New CLASE_CONTROL
        CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
        CTRL.p_IdTRegistro = 8 '8 Solicita Informe
        CTRL.p_Idproceso = 12

        CTRL.Insertar(CLASE_GENERAL.mensaje_error)
        CTRL.dispose()
        CTRL = Nothing

        EVEN = Nothing

        MsgBox("Mensajes enviados por favor genere el reporte")

    End Sub

    Private Sub rbtSMSTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSMSTodos.CheckedChanged

        Me.gpFecha.Visible = False

        If Not (dgConsultaSMS.Rows.Count = 0) Then

            Me.dgConsultaSMS.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Todos los Pacientes Activos"

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

        'Estado de Cuenta
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpOpcionInforme)
        ubicarcontrol(Me.gpFecha)
        ubicarcontrol(Me.lblTituloConsulta)
        ubicarcontrol(Me.dgConsultaSMS)
        ubicarcontrol(Me.lblTituloMensaje)
        ubicarcontrol(Me.lblTextoMensaje)
        ubicarcontrol(Me.prgBarraProgreso)
        ubicarcontrol(Me.cmbTituloSMS)
        ubicarcontrol(Me.RichMensajeSMS)
        ubicarcontrol(Me.btnSMSCargar)
        ubicarcontrol(Me.btnSMSEnviar)
        ubicarcontrol(Me.btnSMSCrear)
        ubicarcontrol(Me.btnSMSSalir)

    End Sub

    Private Sub frmEnvioSMS_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub
End Class