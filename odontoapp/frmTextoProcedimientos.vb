Public Class frmTextoProcedimientos

    Private TEXTOPROCED As CLASE_TEXTO_PROCEDIMIENTO
    Private EVEN As CLASE_EVENTOS

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProviderEmail.BlinkRate = 200
            Me.ErrorProviderEmail.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.cmbTitulo.Text.Length = 0 Then
                ErrorProviderEmail.SetError(Me.cmbTitulo, "Escriba el Titulo del Texto del Procedimiento Por favor")
                MsgBox(ErrorProviderEmail.GetError(Me.cmbTitulo), MsgBoxStyle.OkOnly, "Texto Procedimientos")
                Me.cmbTitulo.Focus()

            ElseIf Me.RichTxtMensaje.Text.Length = 0 Then
                ErrorProviderEmail.SetError(Me.RichTxtMensaje, "Escriba el Texto del Procedimiento por favor")
                MsgBox(ErrorProviderEmail.GetError(Me.RichTxtMensaje), MsgBoxStyle.OkOnly, "Texto Procedimientos")
                Me.RichTxtMensaje.Focus()

            Else

                TEXTOPROCED = New CLASE_TEXTO_PROCEDIMIENTO
                EVEN = New CLASE_EVENTOS

                ' Cargamos Variables para ingresar el nuevo mensaje
                TEXTOPROCED.p_IdMensaje = Me.txtIdMensaje.Text
                TEXTOPROCED.p_Titulo = Me.cmbTitulo.Text
                TEXTOPROCED.p_Mensaje = Me.RichTxtMensaje.Text

                TEXTOPROCED.Insertar(CLASE_GENERAL.mensaje_error)


                ' Actualizamos el combo y seleccionamos el ultimo mensaje creado

                CLASE_GENERAL.cargar_combo("mensajesprocedimientos", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)
                Me.cmbTitulo.SelectedValue = Me.txtIdMensaje.Text

                ' Ahora Seleccionamos el cuerpo del mensaje
                TEXTOPROCED.p_IdMensaje = Me.cmbTitulo.SelectedValue
                TEXTOPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)

                Me.RichTxtMensaje.Text = CLASE_TEXTO_PROCEDIMIENTO.xMensaje

                EVEN.bloquaerdesbloquear("editartexto")

                TEXTOPROCED.dispose() 'liberamos recursos
                TEXTOPROCED = Nothing
                EVEN = Nothing

                MsgBox("Texto Procedimiento Registrado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Texto Procedimientos") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click


        Try


            My.Forms.frmProcedimientoDiario.cmbProcedimientos.Text = ""
            My.Forms.frmProcedimientoDiario.memoProcedimiento.Text = ""

            CLASE_GENERAL.cargar_combo("mensajesprocedimientos", My.Forms.frmProcedimientoDiario.cmbProcedimientos, CLASE_GENERAL.mensaje_error)

            TEXTOPROCED = New CLASE_TEXTO_PROCEDIMIENTO

            TEXTOPROCED.p_IdMensaje = My.Forms.frmProcedimientoDiario.cmbProcedimientos.SelectedValue
            TEXTOPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)

            My.Forms.frmProcedimientoDiario.memoProcedimiento.Text = CLASE_TEXTO_PROCEDIMIENTO.xMensaje


            Me.Dispose()
            Me.Close()

            TEXTOPROCED.dispose()
            TEXTOPROCED = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar El Texto del Procedimiento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Texto Procedimientos")

            If respuesta = 6 Then

                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProviderEmail.BlinkRate = 200
                Me.ErrorProviderEmail.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.cmbTitulo.Text.Length = 0 Then
                    ErrorProviderEmail.SetError(Me.cmbTitulo, "Escriba el Titulo del Texto Procedimientos Por favor")
                    MsgBox(ErrorProviderEmail.GetError(Me.cmbTitulo), MsgBoxStyle.OkOnly, "Texto Procedimientos")
                    Me.cmbTitulo.Focus()

                ElseIf Me.RichTxtMensaje.Text.Length = 0 Then
                    ErrorProviderEmail.SetError(Me.RichTxtMensaje, "Escriba el Texto Procedimientos por favor")
                    MsgBox(ErrorProviderEmail.GetError(Me.RichTxtMensaje), MsgBoxStyle.OkOnly, "Texto Procedimientos")
                    Me.RichTxtMensaje.Focus()

                Else


                    TEXTOPROCED = New CLASE_TEXTO_PROCEDIMIENTO

                    ' Cargamos Variables para Modificar el nuevo mensaje

                    TEXTOPROCED.p_IdMensaje = Me.txtIdMensaje.Text
                    TEXTOPROCED.p_Titulo = Me.cmbTitulo.Text
                    TEXTOPROCED.p_Mensaje = Me.RichTxtMensaje.Text

                    TEXTOPROCED.Modificar(CLASE_GENERAL.mensaje_error)


                    ' Actualizamos el combo y seleccionamos el ultimo mensaje creado

                    CLASE_GENERAL.cargar_combo("mensajesprocedimientos", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)
                    Me.cmbTitulo.SelectedValue = Me.txtIdMensaje.Text

                    ' Ahora Seleccionamos el cuerpo del mensaje

                    TEXTOPROCED.p_IdMensaje = Me.cmbTitulo.SelectedValue
                    TEXTOPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)

                    Me.RichTxtMensaje.Text = CLASE_TEXTO_PROCEDIMIENTO.xMensaje

                    TEXTOPROCED.dispose() 'liberamos recursos
                    TEXTOPROCED = Nothing

                    MsgBox("Texto Procedimientos Modificado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            EVEN = New CLASE_EVENTOS

            Me.cmbTitulo.Text = ""
            Me.RichTxtMensaje.Text = ""

            Me.txtIdMensaje.Text = (CLASE_GENERAL.maximo("Idmensaje", "mensajesprocedimientos", CLASE_GENERAL.mensaje_error)) + 1

            EVEN.bloquaerdesbloquear("nuevotexto")

            EVEN = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Borrar el Texto del Procedimientos", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Texto Procedimientos")

            If respuesta = 6 Then

                TEXTOPROCED = New CLASE_TEXTO_PROCEDIMIENTO
                EVEN = New CLASE_EVENTOS

                ' Cargamos datos para eliminar el mensaje
                TEXTOPROCED.p_IdMensaje = Me.txtIdMensaje.Text
                TEXTOPROCED.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN.bloquaerdesbloquear("editartexto")

                Me.RichTxtMensaje.Text = ""
                Me.cmbTitulo.Text = ""

                ' Cargamos el Texto del Mensaje

                CLASE_GENERAL.cargar_combo("mensajesprocedimientos", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)


                If Me.cmbTitulo.Text = "" Then
                    Me.txtIdMensaje.Text = 1
                    EVEN.bloquaerdesbloquear("nuevotexto")
                Else
                    Me.txtIdMensaje.Text = Me.cmbTitulo.SelectedValue
                    EVEN.bloquaerdesbloquear("editartexto")

                    TEXTOPROCED.p_IdMensaje = Me.txtIdMensaje.Text
                    TEXTOPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)
                    Me.RichTxtMensaje.Text = CLASE_TEXTO_PROCEDIMIENTO.xMensaje

                End If



                TEXTOPROCED.dispose()
                TEXTOPROCED = Nothing

                EVEN = Nothing

                MsgBox("Texto Procedimientos Eliminado con Exito", MsgBoxStyle.OkOnly, "Texto Procedimientos")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub frmTextoProcedimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            ' Cargamos el combo con los mensajes existentes
            TEXTOPROCED = New CLASE_TEXTO_PROCEDIMIENTO
            EVEN = New CLASE_EVENTOS

            CLASE_GENERAL.cargar_combo("mensajesprocedimientos", Me.cmbTitulo, CLASE_GENERAL.mensaje_error)

            'cargamos el texto del mensaje

            If Me.cmbTitulo.Text = "" Then
                Me.txtIdMensaje.Text = 1
                EVEN.bloquaerdesbloquear("nuevotexto")
            Else
                Me.txtIdMensaje.Text = Me.cmbTitulo.SelectedValue
                EVEN.bloquaerdesbloquear("editartexto")

                TEXTOPROCED.p_IdMensaje = Me.txtIdMensaje.Text
                TEXTOPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)
                Me.RichTxtMensaje.Text = CLASE_TEXTO_PROCEDIMIENTO.xMensaje

            End If

            TEXTOPROCED.dispose()
            TEXTOPROCED = Nothing
            EVEN = Nothing


        Catch ex As System.InvalidCastException

            MsgBox("No Hay Texto de Procedimientos en la Base de datos ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Texto Procedimientos") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbTitulo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitulo.SelectionChangeCommitted

        Try

            TEXTOPROCED = New CLASE_TEXTO_PROCEDIMIENTO

            'Cargamos el texto del mensaje segun el valor seleccionado
            TEXTOPROCED.p_IdMensaje = Me.cmbTitulo.SelectedValue
            TEXTOPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)

            'Colocamos en el textbox el Id del Mensaje segun corresponda
            Me.txtIdMensaje.Text = Me.cmbTitulo.SelectedValue

            'CArgamos el texto del mensaje
            Me.RichTxtMensaje.Text = CLASE_TEXTO_PROCEDIMIENTO.xMensaje

            TEXTOPROCED.dispose()
            TEXTOPROCED = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbTitulo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitulo.TextChanged
        Me.ErrorProviderEmail.SetError(Me.cmbTitulo, "")
    End Sub

    Private Sub RichTxtMensaje_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTxtMensaje.TextChanged
        Me.ErrorProviderEmail.SetError(Me.RichTxtMensaje, "")
    End Sub
End Class