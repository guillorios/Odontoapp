Imports System.Net.Mail
Imports System.Math

Public Class frmEnvioEmailInd

    Private MENSAJE As CLASE_MENSAJES
    Private CTRL As CLASE_CONTROL

    'MENSAJE DE EMAIL
    Private MENSAJE_EMAIL As String

    Private Sub btnEmailSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnEmailEnviarInd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailEnviarInd.Click

        Try

            If Me.cmbTituloEmail.Text = "" Then
                MsgBox("El Titulo del Email esta vacio, verifique y corrijalo por favor ", MsgBoxStyle.OkOnly, "ENVIO EMAIL PERSONALIZADO")
            Else
                If Me.RichMensajeEmail.Text = "" Then
                    MsgBox("El Texto del Email esta vacio, verifique y corrijalo por favor ", MsgBoxStyle.OkOnly, "ENVIO EMAIL PERSONALIZADO")
                Else

                    'creamos un nuevo mensaje de correo

                    Dim correo As New MailMessage

                    'De
                    correo.From = New MailAddress(Clase_general.smtpCuenta, Clase_general.smtpNombre)

                    'Para
                    correo.To.Add(Me.txtEmailInd.Text)

                    'Asunto
                    correo.Subject = Me.cmbTituloEmail.Text.ToString

                    'Cuerpo del correo
                    'MENSAJE_EMAIL = Me.RichMensajeEmail.Text

                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<nombre>", Me.dgConsultaEmail.Rows(i).Cells("Nombres").Value.ToString)
                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<dia>", Format(Me.dgConsultaEmail.Rows(i).Cells("fecha").Value.ToString, "Long Date"))
                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<hora>", Format(CDate(Me.dgConsultaEmail.Rows(i).Cells("horaini").Value.ToString), "hh:mm:ss tt"))
                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<procedimiento>", Me.dgConsultaEmail.Rows(i).Cells("nomconsulta").Value.ToString)
                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<tel1>", CLASE_GENERAL._tel1_cons)
                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<cel>", CLASE_GENERAL._celular_cons)
                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<doctor>", CLASE_GENERAL._rtelegal_cons)
                    'MENSAJE_EMAIL = MENSAJE_EMAIL.Replace("<clinica>", CLASE_GENERAL._razonsocial_cons)

                    correo.Body = Me.RichMensajeEmail.Text

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
                    smtp.Host = Clase_general.smtpHost

                    'smtp.Port = 587
                    smtp.Port = Clase_general.smtpPort

                    smtp.Credentials = New System.Net.NetworkCredential(Clase_general.smtpCuenta, Clase_general.smtpPass)

                    smtp.EnableSsl = True

                    Try

                        'listo tenemos la estructura de nuestro mensaje armada ahora enviemosla a nuestro destinatario y listo

                        smtp.Send(correo)

                        '**************** Llenamos La Tabla Control *************************************

                        ctrl = New Clase_control
                        ctrl.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                        ctrl.p_IdTRegistro = 8 '8 Envio Correo Electronico
                        ctrl.p_Idproceso = 12

                        ctrl.Insertar(Clase_general.mensaje_error)
                        ctrl.dispose()
                        ctrl = Nothing

                        MsgBox("Mensaje enviado satisfactoriamente")

                    Catch ex As Exception

                        MsgBox("ERROR: " & ex.Message & " Verifique Su conexion a Internet")

                    End Try

                End If
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ENVIO EMAIL PERSONALIZADO") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub


    Private Sub btnEmailCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailCrear.Click

        Clase_general.formload = 7

        My.Forms.frmMensajesEmail.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        My.Forms.frmMensajesEmail.Show()
        My.Forms.frmMensajesEmail.Activate()

    End Sub

    Private Sub frmEnvioEmailInd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try


            Clase_general.cargar_combo("mensajes", Me.cmbTituloEmail, Clase_general.mensaje_error)

            mensaje = New Clase_mensajes

            mensaje.p_IdMensaje = Me.cmbTituloEmail.SelectedValue
            mensaje.Seleccionar(Clase_general.mensaje_error)

            Me.RichMensajeEmail.Text = Clase_mensajes.xMensaje

            mensaje.dispose()
            mensaje = Nothing


        Catch ex As System.InvalidCastException

            MsgBox("No Hay Mensajes en la Base de datos : ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje 

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbTituloEmail_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTituloEmail.SelectionChangeCommitted

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
        ubicarcontrol(Me.txtEmailInd)
        ubicarcontrol(Me.lblEmailInd)
        ubicarcontrol(Me.cmbTituloEmail)
        ubicarcontrol(Me.lblTituloEmail)
        ubicarcontrol(Me.RichMensajeEmail)
        ubicarcontrol(Me.lblMensajeEmail)
        ubicarcontrol(Me.btnEmailCrear)
        ubicarcontrol(Me.btnEmailEnviarInd)
        ubicarcontrol(Me.btnEmailSalir)

    End Sub

    Private Sub frmEnvioEmailInd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class