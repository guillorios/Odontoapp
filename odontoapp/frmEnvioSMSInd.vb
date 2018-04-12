Imports System.Net.Mail
Imports System.Math

Public Class frmEnvioSMSInd

    Private MENSAJE As CLASE_MENSAJES
    Private CTRL As CLASE_CONTROL

    Private Sub btnSMSSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub
    Private Sub cmbTituloEmail_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTituloSMS.SelectionChangeCommitted

        Try

            mensaje = New CLASE_MENSAJES

            mensaje.p_IdMensaje = Me.cmbTituloSMS.SelectedValue
            mensaje.Seleccionar(CLASE_GENERAL.mensaje_error)

            Me.RichMensajeSMS.Text = CLASE_MENSAJES.xMensaje

            mensaje.dispose()
            mensaje = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub
    Private Sub btnSMSCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSCrear.Click

        CLASE_GENERAL.formload = 22

        My.Forms.frmMensajesEmail.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        My.Forms.frmMensajesEmail.Show()
        My.Forms.frmMensajesEmail.Activate()

    End Sub
    Private Sub btnSMSEnviarInd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMSEnviarInd.Click

        Try

            If Me.cmbTituloSMS.Text = "" Then
                MsgBox("El Titulo del SMS esta vacio, verifique y corrijalo por favor ", MsgBoxStyle.OkOnly, "ENVIO SMS PERSONALIZADO")
            Else
                If Me.RichMensajeSMS.Text = "" Then
                    MsgBox("El Texto del SMS esta vacio, verifique y corrijalo por favor ", MsgBoxStyle.OkOnly, "ENVIO SMS PERSONALIZADO")
                Else

                    'creamos un nuevo mensaje de correo

                    Dim correo As New MailMessage

                    'De
                    correo.From = New MailAddress(CLASE_GENERAL.smtpCuenta, CLASE_GENERAL.smtpNombre)

                    'Para
                    correo.To.Add(Me.txtSMSInd.Text)

                    'Asunto
                    correo.Subject = Me.cmbTituloSMS.Text.ToString

                    'Cuerpo del correo
                    correo.Body = Me.RichMensajeSMS.Text

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

                    Try

                        'listo tenemos la estructura de nuestro mensaje armada ahora enviemosla a nuestro destinatario y listo

                        smtp.Send(correo)

                        '**************** Llenamos La Tabla Control *************************************

                        CTRL = New CLASE_CONTROL
                        CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                        CTRL.p_IdTRegistro = 8 '8 Envio Correo Electronico
                        CTRL.p_Idproceso = 12

                        CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                        CTRL.dispose()
                        CTRL = Nothing

                        MsgBox("Mensaje enviado satisfactoriamente")

                    Catch ex As Exception

                        MsgBox("ERROR: " & ex.Message & " Verifique Su conexion a Internet")

                    End Try

                End If
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "ENVIO SMS PERSONALIZADO") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub frmEnvioSMSInd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        ubicarcontrol(Me.lblSMSInd)
        ubicarcontrol(Me.txtSMSInd)
        ubicarcontrol(Me.lblTituloSMS)
        ubicarcontrol(Me.cmbTituloSMS)
        ubicarcontrol(Me.RichMensajeSMS)
        ubicarcontrol(Me.lblMensajeSMS)
        ubicarcontrol(Me.btnSMSCrear)
        ubicarcontrol(Me.btnSMSEnviarInd)
        ubicarcontrol(Me.btnSMSSalir)

    End Sub

    Private Sub frmEnvioSMSInd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class