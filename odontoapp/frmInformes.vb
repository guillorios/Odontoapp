Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Net.Mail
Imports System.Math

Public Class frmInformes

    Private Sub btnSalirInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirInfo.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnEnvioInformeEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvioInformeEmail.Click

        Try

            'creamos un nuevo mensaje de correo

            Dim correo As New MailMessage

            'De
            correo.From = New MailAddress(CLASE_GENERAL.smtpCuenta, CLASE_GENERAL.smtpNombre)

            'Para
            correo.To.Add(txtcorreos.Text)

            'Asunto
            correo.Subject = Me.lblTituloEmail.Text

            'Cuerpo del correo
            correo.Body = Me.lblMensajeEmail.Text

            'Mostrar como HTML
            correo.IsBodyHtml = False

            'Prioridad de el correo
            correo.Priority = MailPriority.Normal

            'Envio de Adjuntos
            correo.Attachments.Add(New Attachment("c:\Odpp\DocumentoImportante.pdf"))

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

            frmProgresoEnvioEmail.Show()
            frmProgresoEnvioEmail.Activate()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

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
        ubicarcontrol(Me.gpEnvioInforme)

    End Sub

    Private Sub frmInformes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

End Class