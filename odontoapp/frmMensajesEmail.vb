Imports System.Math

Public Class frmMensajesEmail

    Private MENSAJE As CLASE_MENSAJES
    Private EVEN As CLASE_EVENTOS
    Private PositionChar As Integer
    Private Textauxini As String
    Private textauxfin As String

    Private Sub btnEmailAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.cmbTitulo.Text.Length = 0 Then
                ErrorProvider.SetError(Me.cmbTitulo, "Escriba el Titulo del Mensaje Por favor")
                MsgBox(ErrorProvider.GetError(Me.cmbTitulo), MsgBoxStyle.OkOnly, "Mensajes")
                Me.cmbTitulo.Focus()

            ElseIf Me.RichTxtMensaje.Text.Length = 0 Then
                ErrorProvider.SetError(Me.RichTxtMensaje, "Escriba el Mensaje por favor")
                MsgBox(ErrorProvider.GetError(Me.RichTxtMensaje), MsgBoxStyle.OkOnly, "Mensajes")
                Me.RichTxtMensaje.Focus()

            Else

                MENSAJE = New CLASE_MENSAJES
                EVEN = New CLASE_EVENTOS

                ' Cargamos Variables para ingresar el nuevo mensaje
                MENSAJE.p_IdMensaje = Me.txtIdMensaje.Text
                MENSAJE.p_Titulo = Me.cmbTitulo.Text
                MENSAJE.p_Mensaje = Me.RichTxtMensaje.Text

                MENSAJE.Insertar(CLASE_GENERAL.mensaje_error)


                ' Actualizamos el combo y seleccionamos el ultimo mensaje creado

                CLASE_GENERAL.cargar_combo("mensajes", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)
                Me.cmbTitulo.SelectedValue = Me.txtIdMensaje.Text

                ' Ahora Seleccionamos el cuerpo del mensaje

                MENSAJE.p_IdMensaje = Me.cmbTitulo.SelectedValue
                MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

                Me.RichTxtMensaje.Text = CLASE_MENSAJES.xMensaje

                EVEN.bloquaerdesbloquear("editarmensaje")

                MENSAJE.dispose() 'liberamos recursos
                MENSAJE = Nothing
                EVEN = Nothing

                MsgBox("Mensaje Registrado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnEmailSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Try

            Select Case CLASE_GENERAL.formload 'Variable para controlar

                Case 6

                    My.Forms.frmEnvioEmails.cmbTituloEmail.Text = ""
                    My.Forms.frmEnvioEmails.RichMensajeEmail.Text = ""

                    CLASE_GENERAL.cargar_combo("mensajes", My.Forms.frmEnvioEmails.cmbTituloEmail, CLASE_GENERAL.mensaje_error)

                    MENSAJE = New CLASE_MENSAJES

                    MENSAJE.p_IdMensaje = My.Forms.frmEnvioEmails.cmbTituloEmail.SelectedValue
                    MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

                    My.Forms.frmEnvioEmails.RichMensajeEmail.Text = CLASE_MENSAJES.xMensaje

                Case 7

                    My.Forms.frmEnvioEmailInd.cmbTituloEmail.Text = ""
                    My.Forms.frmEnvioEmailInd.RichMensajeEmail.Text = ""

                    CLASE_GENERAL.cargar_combo("mensajes", My.Forms.frmEnvioEmailInd.cmbTituloEmail, CLASE_GENERAL.mensaje_error)

                    MENSAJE = New CLASE_MENSAJES

                    MENSAJE.p_IdMensaje = My.Forms.frmEnvioEmailInd.cmbTituloEmail.SelectedValue
                    MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

                    My.Forms.frmEnvioEmailInd.RichMensajeEmail.Text = CLASE_MENSAJES.xMensaje

                Case 18

                    My.Forms.frmEnvioSMS.cmbTituloSMS.Text = ""
                    My.Forms.frmEnvioSMS.RichMensajeSMS.Text = ""

                    CLASE_GENERAL.cargar_combo("mensajes", My.Forms.frmEnvioSMS.cmbTituloSMS, CLASE_GENERAL.mensaje_error)

                    MENSAJE = New CLASE_MENSAJES

                    MENSAJE.p_IdMensaje = My.Forms.frmEnvioSMS.cmbTituloSMS.SelectedValue
                    MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

                    My.Forms.frmEnvioSMS.RichMensajeSMS.Text = CLASE_MENSAJES.xMensaje

                Case 22

                    My.Forms.frmEnvioSMSInd.cmbTituloSMS.Text = ""
                    My.Forms.frmEnvioSMS.RichMensajeSMS.Text = ""

                    CLASE_GENERAL.cargar_combo("mensajes", My.Forms.frmEnvioSMS.cmbTituloSMS, CLASE_GENERAL.mensaje_error)

                    MENSAJE = New CLASE_MENSAJES

                    MENSAJE.p_IdMensaje = My.Forms.frmEnvioSMS.cmbTituloSMS.SelectedValue
                    MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

                    My.Forms.frmEnvioSMS.RichMensajeSMS.Text = CLASE_MENSAJES.xMensaje

            End Select

            Me.Dispose()
            Me.Close()

            MENSAJE.dispose()
            MENSAJE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try
    End Sub

    Private Sub btnEmailModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar El Mensaje ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensajes")

            If respuesta = 6 Then

                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProvider.BlinkRate = 200
                Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.cmbTitulo.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.cmbTitulo, "Escriba el Titulo del Mensaje Por favor")
                    MsgBox(ErrorProvider.GetError(Me.cmbTitulo), MsgBoxStyle.OkOnly, "Mensajes")
                    Me.cmbTitulo.Focus()

                ElseIf Me.RichTxtMensaje.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.RichTxtMensaje, "Escriba el Mensaje por favor")
                    MsgBox(ErrorProvider.GetError(Me.RichTxtMensaje), MsgBoxStyle.OkOnly, "Mensajes")
                    Me.RichTxtMensaje.Focus()

                Else


                    MENSAJE = New CLASE_MENSAJES

                    ' Cargamos Variables para Modificar el nuevo mensaje

                    MENSAJE.p_IdMensaje = Me.txtIdMensaje.Text
                    MENSAJE.p_Titulo = Me.cmbTitulo.Text
                    MENSAJE.p_Mensaje = Me.RichTxtMensaje.Text

                    MENSAJE.Modificar(CLASE_GENERAL.mensaje_error)


                    ' Actualizamos el combo y seleccionamos el ultimo mensaje creado

                    CLASE_GENERAL.cargar_combo("mensajes", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)
                    Me.cmbTitulo.SelectedValue = Me.txtIdMensaje.Text

                    ' Ahora Seleccionamos el cuerpo del mensaje

                    MENSAJE.p_IdMensaje = Me.cmbTitulo.SelectedValue
                    MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

                    Me.RichTxtMensaje.Text = CLASE_MENSAJES.xMensaje

                    MENSAJE.dispose() 'liberamos recursos
                    MENSAJE = Nothing

                    MsgBox("Mensaje Modificado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try
    End Sub

    Private Sub btnEmailNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            EVEN = New CLASE_EVENTOS

            Me.cmbTitulo.Text = ""
            Me.RichTxtMensaje.Text = ""

            Me.txtIdMensaje.Text = (CLASE_GENERAL.maximo("Idmensaje", "mensajes", CLASE_GENERAL.mensaje_error)) + 1

            EVEN.bloquaerdesbloquear("nuevomensaje")

            EVEN = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnEmailEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Borrar el Mensaje", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Mensajes")

            If respuesta = 6 Then

                MENSAJE = New CLASE_MENSAJES
                EVEN = New CLASE_EVENTOS

                ' Cargamos datos para eliminar el mensaje
                MENSAJE.p_IdMensaje = Me.txtIdMensaje.Text
                MENSAJE.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN.bloquaerdesbloquear("editarmensajes")

                Me.RichTxtMensaje.Text = ""
                Me.cmbTitulo.Text = ""

                ' Cargamos el Texto del Mensaje

                CLASE_GENERAL.cargar_combo("mensajes", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)


                If Me.cmbTitulo.Text = "" Then
                    Me.txtIdMensaje.Text = 1
                    EVEN.bloquaerdesbloquear("nuevomensaje")
                Else
                    Me.txtIdMensaje.Text = Me.cmbTitulo.SelectedValue
                    EVEN.bloquaerdesbloquear("editarmensaje")

                    MENSAJE.p_IdMensaje = Me.txtIdMensaje.Text
                    MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)
                    Me.RichTxtMensaje.Text = CLASE_MENSAJES.xMensaje

                End If



                MENSAJE.dispose()
                MENSAJE = Nothing

                EVEN = Nothing

                MsgBox("Mensaje Eliminado con Exito", MsgBoxStyle.OkOnly, "Mensajes")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub frmMensajesEmail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            ' Cargamos el combo con los mensajes existentes
            MENSAJE = New CLASE_MENSAJES
            EVEN = New CLASE_EVENTOS

            CLASE_GENERAL.cargar_combo("mensajes", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)

            'cargamos el texto del mensaje

            If Me.cmbTitulo.Text = "" Then
                Me.txtIdMensaje.Text = 1
                EVEN.bloquaerdesbloquear("nuevomensaje")
            Else
                Me.txtIdMensaje.Text = Me.cmbTitulo.SelectedValue
                EVEN.bloquaerdesbloquear("editarmensaje")

                MENSAJE.p_IdMensaje = Me.txtIdMensaje.Text
                MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)
                Me.RichTxtMensaje.Text = CLASE_MENSAJES.xMensaje

            End If

            MENSAJE.dispose()
            MENSAJE = Nothing
            EVEN = Nothing


        Catch ex As System.InvalidCastException

            MsgBox("No Hay Mensajes en la Base de datos ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbTitulo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitulo.SelectionChangeCommitted

        Try

            MENSAJE = New CLASE_MENSAJES

            'Cargamos el texto del mensaje segun el valor seleccionado
            MENSAJE.p_IdMensaje = Me.cmbTitulo.SelectedValue
            MENSAJE.Seleccionar(CLASE_GENERAL.mensaje_error)

            'Colocamos en el textbox el Id del Mensaje segun corresponda
            Me.txtIdMensaje.Text = Me.cmbTitulo.SelectedValue

            'CArgamos el texto del mensaje
            Me.RichTxtMensaje.Text = CLASE_MENSAJES.xMensaje

            MENSAJE.dispose()
            MENSAJE = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub cmbTitulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTitulo.TextChanged
        Me.ErrorProvider.SetError(Me.cmbTitulo, "")
    End Sub

    Private Sub RichTxtMensaje_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTxtMensaje.Click
        PositionChar = Me.RichTxtMensaje.SelectionStart
    End Sub

    Private Sub RichTxtMensaje_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTxtMensaje.KeyUp
        PositionChar = Me.RichTxtMensaje.SelectionStart
    End Sub

    Private Sub RichTxtMensaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTxtMensaje.TextChanged
        Me.ErrorProvider.SetError(Me.RichTxtMensaje, "")
    End Sub

    Private Sub btnENomPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnENomPac.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<nombre>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 9

    End Sub

    Private Sub btnEDiaCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDiaCita.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<dia>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 6

    End Sub

    Private Sub btnEHoraCita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEHoraCita.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<hora>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 7


    End Sub

    Private Sub btnEprocedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEprocedimiento.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<procedimiento>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 16

    End Sub

    Private Sub btnETelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnETelefono.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<tel1>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 7


    End Sub

    Private Sub btnECelClinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnECelClinica.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<cel>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 6

    End Sub

    Private Sub btnEDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEDoc.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<doctor>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 9

    End Sub

    Private Sub btnENomClinica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnENomClinica.Click

        PositionChar = Me.RichTxtMensaje.SelectionStart

        Me.RichTxtMensaje.SelectionStart = PositionChar
        Textauxini = Mid(Me.RichTxtMensaje.Text, 1, PositionChar)
        textauxfin = Mid(Me.RichTxtMensaje.Text, PositionChar + 1, Len(Me.RichTxtMensaje.Text))
        Me.RichTxtMensaje.Text = Textauxini & "<clinica>" & " " & textauxfin
        Me.RichTxtMensaje.Focus()
        Me.RichTxtMensaje.SelectionStart = PositionChar + 10

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

        'Datos Iniciales
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpCrearMensaje)
        ubicarcontrol(Me.gpEtiquetas)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnAdicionar)

    End Sub

    Private Sub frmMensajesEmail_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class