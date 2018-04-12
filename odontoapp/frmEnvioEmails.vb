Imports System.Net.Mail
Imports System.Math

Public Class frmEnvioEmails

    'variables de Clases
    Private MENSAJE As CLASE_MENSAJES
    Private PAC As CLASE_PACIENTES
    Private CITA As CLASE_CITAS
    Private CTRL As CLASE_CONTROL
    Private EVEN As CLASE_EVENTOS
    Private REPORTEENVIO As CLASE_REPORTEENVIOS

    Private MENSAJE_EMAIL As String


    Private Sub btnEmailEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailEnviar.Click

        Dim i As Integer
        Me.prgBarraProgreso.Value = 0

        If Me.cmbTituloEmail.Text = "" Or Me.RichMensajeEmail.Text = "" Then

            MsgBox("Existen Campos Importantes Vacios, el mensaje no se enviará", MsgBoxStyle.OkOnly, "Mensaje")

        Else

            REPORTEENVIO = New CLASE_REPORTEENVIOS
            EVEN = New CLASE_EVENTOS

            For i = 0 To Me.dgConsultaEmail.Rows.Count - 1

                Try

                    '**************** Llenamos La Tabla Reportes ***********************

                    REPORTEENVIO.p_Idreporte = (CLASE_GENERAL.maximo("Idreporte", "reporteenvios ", CLASE_GENERAL.mensaje_error)) + 1
                    REPORTEENVIO.p_estado_reporte = True

                    'creamos un nuevo mensaje de correo

                    Dim correo As New MailMessage

                    'De
                    correo.From = New MailAddress(CLASE_GENERAL.smtpCuenta, CLASE_GENERAL.smtpNombre)

                    'Para
                    correo.To.Add(EVEN.StripString(Trim(Me.dgConsultaEmail.Rows(i).Cells("email_con").Value.ToString)))

                    'Asunto
                    correo.Subject = Me.cmbTituloEmail.Text.ToString

                    'Cuerpo del correo
                    MENSAJE_EMAIL = Me.RichMensajeEmail.Text

                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<nombre>", Me.dgConsultaEmail.Rows(i).Cells("Nombres").Value.ToString)
                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<dia>", Format(Me.dgConsultaEmail.Rows(i).Cells("fecha").Value.ToString, "Long Date"))
                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<hora>", Format(CDate(Me.dgConsultaEmail.Rows(i).Cells("horaini").Value.ToString), "hh:mm:ss tt"))
                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<procedimiento>", Me.dgConsultaEmail.Rows(i).Cells("nomconsulta").Value.ToString)
                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<tel1>", CLASE_GENERAL._tel1_cons)
                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<cel>", CLASE_GENERAL._celular_cons)
                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<doctor>", CLASE_GENERAL._rtelegal_cons)
                    MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<clinica>", CLASE_GENERAL._razonsocial_cons)

                    correo.Body = MENSAJE_EMAIL.ToUpper

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
                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaEmail.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Finally

                    REPORTEENVIO.p_estado_reporte = True
                    REPORTEENVIO.p_tipo_reporte = 1 ' Emails
                    REPORTEENVIO.p_Idpaciente = Me.dgConsultaEmail.Rows(i).Cells("Idpaciente").Value.ToString
                    REPORTEENVIO.Insertar(CLASE_GENERAL.mensaje_error)

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaEmail.Rows.Count)
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

    Private Sub btnEmailCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailCargar.Click


        If Me.rbtSMSTodos.Checked = True Then

            Me.lblTituloConsulta.Text = "Todos los Pacientes Activos"

            PAC = New CLASE_PACIENTES
            PAC.Seleccionar("informepacientesemail")

            Me.dgConsultaEmail.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaEmail.Update()

            GRIDSTYLES("pacientes")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            PAC.dispose()
            PAC = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")

            Me.btnEmailEnviar.Enabled = True


        End If


        If Me.rbtEmailCumpleAños.Checked = True Then

            Me.lblTituloConsulta.Text = "Pacientes Que Cumplen Años Hoy"

            PAC = New CLASE_PACIENTES
            PAC.Seleccionar("informecumpleañoshoymensajes")

            Me.dgConsultaEmail.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaEmail.Update()

            GRIDSTYLES("cumpleaños")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            PAC.dispose()
            PAC = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")
            Me.btnEmailEnviar.Enabled = True


        End If

        If Me.rbtEmailCitas.Checked = True Then

            Me.lblTituloConsulta.Text = "Pacientes Que Tienen Citas"

            CITA = New CLASE_CITAS
            CITA.p_fecha = Format(Me.cmbfecini_email.Value, "yyyy-MM-dd")
            CITA.p_fecha2 = Format(Me.cmbfecfin_email.Value, "yyyy-MM-dd")
            CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

            CITA.Seleccionar("informecitasmensajes")

            Me.dgConsultaEmail.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaEmail.Update()

            GRIDSTYLES("citas")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            CITA.dispose()
            CITA = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")
            Me.btnEmailEnviar.Enabled = True


        End If

        If Me.rbtEmailNoAsistieron.Checked = True Then

            Me.lblTituloConsulta.Text = "Pacientes que no Asistieron a su cita"

            CITA = New CLASE_CITAS
            CITA.p_fecha = Format(Me.cmbfecini_email.Value, "yyyy-MM-dd")
            CITA.p_fecha2 = Format(Me.cmbfecfin_email.Value, "yyyy-MM-dd")
            CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

            CITA.Seleccionar("informecitassinasistirmensajes")

            Me.dgConsultaEmail.DataSource = CLASE_GENERAL.xdt
            Me.dgConsultaEmail.Update()

            GRIDSTYLES("citas")

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            CITA.dispose()
            CITA = Nothing

            MsgBox("La Consulta Esta Lista ", MsgBoxStyle.OkOnly, "Mensajes")
            Me.btnEmailEnviar.Enabled = True


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

                    With Me.dgConsultaEmail

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
                        .Columns(4).HeaderText = "EMAIL"

                        .Columns(5).DefaultCellStyle = Style2
                        .Columns(5).HeaderText = "FECHA"

                        .Columns(6).DefaultCellStyle = Style2
                        .Columns(6).HeaderText = "HORA INI."

                        .Columns(7).DefaultCellStyle = Style2
                        .Columns(7).HeaderText = "HORA FIN."

                        .Columns(8).DefaultCellStyle = Style2
                        .Columns(8).HeaderText = "CONSULTA"

                    End With

                Case "pacientes"

                    With Me.dgConsultaEmail

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
                        .Columns(4).HeaderText = "EMAIL"

                    End With

                Case "cumpleaños"

                    With Me.dgConsultaEmail

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
                        .Columns(4).HeaderText = "EMAIL"

                        .Columns(5).DefaultCellStyle = Style2
                        .Columns(5).HeaderText = "CUMPLEAÑOS"

                    End With

            End Select

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub btnEmailSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnEmailCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailCrear.Click

        Clase_general.formload = 6

        My.Forms.frmMensajesEmail.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        My.Forms.frmMensajesEmail.Show()
        My.Forms.frmMensajesEmail.Activate()

    End Sub

    Private Sub frmEnvioEmails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try


            Clase_general.cargar_combo("mensajes", Me.cmbTituloEmail, Clase_general.mensaje_error)

            mensaje = New Clase_mensajes

            mensaje.p_IdMensaje = Me.cmbTituloEmail.SelectedValue
            mensaje.Seleccionar(Clase_general.mensaje_error)

            Me.RichMensajeEmail.Text = CLASE_MENSAJES.xMensaje

            Me.cmbfecini_email.Value = Date.Now
            Me.cmbfecfin_email.Value = Date.Now

            mensaje.dispose()
            mensaje = Nothing


        Catch ex As System.InvalidCastException

            MsgBox("No Hay Mensajes en la Base de datos : ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje 

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbTituloEmail_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTituloEmail.SelectionChangeCommitted

        Try

            mensaje = New Clase_mensajes

            mensaje.p_IdMensaje = Me.cmbTituloEmail.SelectedValue
            mensaje.Seleccionar(Clase_general.mensaje_error)

            Me.RichMensajeEmail.Text = Clase_mensajes.xMensaje

            mensaje.dispose()
            mensaje = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub rbtEmailTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSMSTodos.CheckedChanged

        Me.gpFecha.Visible = False

        If Not (dgConsultaEmail.Rows.Count = 0) Then

            Me.dgConsultaEmail.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Todos los Pacientes Activos"

    End Sub

    Private Sub rbtEmailCumpleAños_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEmailCumpleAños.CheckedChanged

        Me.gpFecha.Visible = False

        If Not (dgConsultaEmail.Rows.Count = 0) Then

            Me.dgConsultaEmail.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Pacientes Que Cumplen Años Hoy"

    End Sub

    Private Sub rbtEmailCitas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEmailCitas.CheckedChanged

        Me.gpFecha.Visible = True

        Me.cmbfecini_email.Value = Format(Now(), "short date")
        Me.cmbfecini_email.MinDate = Format(Now(), "short date")
        Me.cmbfecini_email.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.cmbfecfin_email.Value = Format(Now(), "short date")
        Me.cmbfecfin_email.MinDate = Format(Now(), "short date")
        Me.cmbfecfin_email.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)

        If Not (dgConsultaEmail.Rows.Count = 0) Then

            Me.dgConsultaEmail.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Pacientes Que Tienen Citas"

    End Sub

    Private Sub rbtEmailNoAsistieron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEmailNoAsistieron.CheckedChanged

        Me.gpFecha.Visible = True
        Me.cmbfecini_email.Value = Format(Now(), "short date")
        Me.cmbfecini_email.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.cmbfecini_email.MaxDate = Format(Now(), "short date")
        Me.cmbfecfin_email.Value = Format(Now(), "short date")
        Me.cmbfecfin_email.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.cmbfecfin_email.MaxDate = Format(Now(), "short date")

        If Not (dgConsultaEmail.Rows.Count = 0) Then

            Me.dgConsultaEmail.DataSource = Nothing

        End If

        Me.lblTituloConsulta.Text = "Pacientes que no Asistieron a su cita"

    End Sub

    Private Sub cmbfecini_email_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfecini_email.ValueChanged

        Me.cmbfecfin_email.MinDate = Me.cmbfecini_email.Value

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
        ubicarcontrol(Me.dgConsultaEmail)
        ubicarcontrol(Me.lblTituloMensaje)
        ubicarcontrol(Me.lblTextoMensaje)
        ubicarcontrol(Me.prgBarraProgreso)
        ubicarcontrol(Me.cmbTituloEmail)
        ubicarcontrol(Me.RichMensajeEmail)
        ubicarcontrol(Me.btnEmailCargar)
        ubicarcontrol(Me.btnEmailEnviar)
        ubicarcontrol(Me.btnEmailCrear)
        ubicarcontrol(Me.btnEmailSalir)

    End Sub

    Private Sub frmEnvioEmails_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

End Class