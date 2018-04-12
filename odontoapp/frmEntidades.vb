Imports System.Math

Public Class frmEntidades

    Private ENT As CLASE_ENTIDADES
    Private EVEN As CLASE_EVENTOS
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS


    Private Sub btnEntSalir_Clic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnEntModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar la Entidad", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Entidades")

        If respuesta = 6 Then

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtnombre_ent.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnombre_ent, "Escriba el Nombre por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnombre_ent), MsgBoxStyle.OkOnly, "Entidades")
                Me.TabControl_Ent.SelectedTabIndex = 0
                Me.txtnombre_ent.Focus()

            ElseIf Me.txtdireccion_ent.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtdireccion_ent, "Escriba la Dirección por favor")
                MsgBox(ErrorProvider.GetError(Me.txtdireccion_ent), MsgBoxStyle.OkOnly, "Entidades")
                Me.TabControl_Ent.SelectedTabIndex = 0
                Me.txtdireccion_ent.Focus()

            ElseIf Me.txtcontacto_ent.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtcontacto_ent, "Escriba el Nombre del Contacto por favor")
                MsgBox(ErrorProvider.GetError(Me.txtcontacto_ent), MsgBoxStyle.OkOnly, "Entidades")
                Me.TabControl_Ent.SelectedTabIndex = 0
                Me.txtcontacto_ent.Focus()

            ElseIf Me.txtTelOficina_ent.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtTelOficina_ent, "Escriba el Telefono de la Oficina en Contactos por favor")
                MsgBox(ErrorProvider.GetError(Me.txtTelOficina_ent), MsgBoxStyle.OkOnly, "Entidades")
                Me.TabControl_Ent.SelectedTabIndex = 0
                Me.txtTelOficina_ent.Focus()

            ElseIf Me.txtCelular_ent.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtCelular_ent, "Escriba el No. de Celular en Contactos por favor")
                MsgBox(ErrorProvider.GetError(Me.txtCelular_ent), MsgBoxStyle.OkOnly, "Entidades")
                Me.TabControl_Ent.SelectedTabIndex = 0
                Me.txtCelular_ent.Focus()

            ElseIf Me.txtemail_ent.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtemail_ent, "Escriba el email en contactos por favor")
                MsgBox(ErrorProvider.GetError(Me.txtemail_ent), MsgBoxStyle.OkOnly, "Entidades")
                Me.TabControl_Ent.SelectedTabIndex = 0
                Me.txtemail_ent.Focus()

            Else

                Try

                    '**************************** MODULO PARA MODIFICACION DE LAS ENTIDADES *******************************

                    ENT = New CLASE_ENTIDADES

                    'Asignamos los valores a las variables de la clase pacientes

                    ENT.p_Identidad = Me.txtIdentidad.Text
                    ENT.p_nombre_ent = Me.txtnombre_ent.Text
                    ENT.p_direccion_ent = Me.txtdireccion_ent.Text
                    ENT.p_contacto_ent = Me.txtcontacto_ent.Text
                    ENT.p_codigo_ent = Me.txtcodigo_ent.Text

                    ENT.Modificar(CLASE_GENERAL.mensaje_error)
                    ENT.dispose()
                    ENT = Nothing

                    '**************************** MODULO PARA MODIFICACION DE LOS CONTACTOS *******************************

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdentidad.Text
                    CON.p_IdTUsuario = 4 ' Utilizamos uno porque es de tipo Entidad ******
                    CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes a la entidad misma
                    CON.p_teloficina_con = Me.txtTelOficina_ent.Text
                    CON.p_fax_con = Me.txtFax_ent.Text
                    CON.p_cel_con = Me.txtCelular_ent.Text
                    CON.p_email_con = Me.txtemail_ent.Text
                    CON.p_web_con = Me.txtweb_ent.Text

                    CON.Modificar(CLASE_GENERAL.mensaje_error)
                    CON.dispose()
                    CON = Nothing

                    '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************
                    NOTA = New CLASE_NOTAS

                    NOTA.p_IdUsuario = Me.txtIdentidad.Text
                    NOTA.p_IdTUsuario = 4 ' Utilizamos uno porque es de tipo Entidad
                    NOTA.p_nota = Me.RichTxtNotas_ent.Text

                    NOTA.Modificar(CLASE_GENERAL.mensaje_error)
                    NOTA.dispose()
                    NOTA = Nothing

                    '**************************** CARGAMOS LA FICHA ************************
                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiarficha")

                    My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIdentidad.Text
                    My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombre_ent.Text & " " & Me.txtcontacto_ent.Text
                    'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtdireccion_ent.Text
                    My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_ent.Text
                    My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelOficina_ent.Text
                    My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_ent.Text


                    EVEN.bloquaerdesbloquear("editarentidad")
                    EVEN = Nothing

                    MsgBox("Entidad modificada con Exito", MsgBoxStyle.OkOnly, "Entidades")

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try
            End If
        End If

    End Sub

    Private Sub btnEntNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea un Nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Entidades")

        If respuesta = 6 Then

            Try

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarentidades")
                EVEN.limpiar("limpiarficha")
                EVEN.bloquaerdesbloquear("nuevaentidad")

                Me.txtIdentidad.Text = (CLASE_GENERAL.maximo("Identidad", "entidades", CLASE_GENERAL.mensaje_error)) + 1
                EVEN = Nothing

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnEntAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click


        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProvider.BlinkRate = 200
        Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtnombre_ent.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtnombre_ent, "Escriba el Nombre por favor")
            MsgBox(ErrorProvider.GetError(Me.txtnombre_ent), MsgBoxStyle.OkOnly, "Entidades")
            Me.TabControl_Ent.SelectedTabIndex = 0
            Me.txtnombre_ent.Focus()

        ElseIf Me.txtdireccion_ent.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtdireccion_ent, "Escriba la Dirección por favor")
            MsgBox(ErrorProvider.GetError(Me.txtdireccion_ent), MsgBoxStyle.OkOnly, "Entidades")
            Me.TabControl_Ent.SelectedTabIndex = 0
            Me.txtdireccion_ent.Focus()

        ElseIf Me.txtcontacto_ent.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtcontacto_ent, "Escriba el Nombre del Contacto por favor")
            MsgBox(ErrorProvider.GetError(Me.txtcontacto_ent), MsgBoxStyle.OkOnly, "Entidades")
            Me.TabControl_Ent.SelectedTabIndex = 0
            Me.txtcontacto_ent.Focus()

        ElseIf Me.txtTelOficina_ent.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtTelOficina_ent, "Escriba el Telefono de la Oficina en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtTelOficina_ent), MsgBoxStyle.OkOnly, "Entidades")
            Me.TabControl_Ent.SelectedTabIndex = 0
            Me.txtTelOficina_ent.Focus()

        ElseIf Me.txtCelular_ent.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtCelular_ent, "Escriba el No. de Celular en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtCelular_ent), MsgBoxStyle.OkOnly, "Entidades")
            Me.TabControl_Ent.SelectedTabIndex = 0
            Me.txtCelular_ent.Focus()

        ElseIf Me.txtemail_ent.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtemail_ent, "Escriba el email en contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtemail_ent), MsgBoxStyle.OkOnly, "Entidades")
            Me.TabControl_Ent.SelectedTabIndex = 0
            Me.txtemail_ent.Focus()

        Else

            Try

                '**************************** MODULO PARA INGRESO DE LAS ENTIDADES *******************************
                ENT = New CLASE_ENTIDADES

                'Asignamos los valores a las variables de la clase pacientes
                ENT.p_Identidad = Me.txtIdentidad.Text
                ENT.p_nombre_ent = Me.txtnombre_ent.Text
                ENT.p_direccion_ent = Me.txtdireccion_ent.Text
                ENT.p_contacto_ent = Me.txtcontacto_ent.Text
                ENT.p_codigo_ent = Me.txtcodigo_ent.Text

                'Insertamos en la base de datos
                ENT.Insertar(CLASE_GENERAL.mensaje_error)
                ENT.dispose() ' Liberamos recursos
                ENT = Nothing

                '**************************** MODULO PARA INGRESO DE LOS CONTACTOS *******************************

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdentidad.Text
                CON.p_IdTUsuario = 4 ' Utilizamos uno porque es de tipo Entidad ******
                CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes a la entidad misma
                CON.p_teloficina_con = Me.txtTelOficina_ent.Text
                CON.p_fax_con = Me.txtFax_ent.Text
                CON.p_cel_con = Me.txtCelular_ent.Text
                CON.p_email_con = Me.txtemail_ent.Text
                CON.p_web_con = Me.txtweb_ent.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                '**************************** MODULO PARA INGRESO DE LAS NOTAS  *******************************
                NOTA = New CLASE_NOTAS

                NOTA.p_IdUsuario = Me.txtIdentidad.Text
                NOTA.p_IdTUsuario = 4 ' Utilizamos uno porque es de tipo Entidad
                NOTA.p_nota = Me.RichTxtNotas_ent.Text

                NOTA.Insertar(CLASE_GENERAL.mensaje_error)
                NOTA.dispose()
                NOTA = Nothing


                '**************************** MODULO PARA INGRESO EN LA FICHA *******************************

                My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIdentidad.Text
                My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombre_ent.Text & " " & Me.txtcontacto_ent.Text
                'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtdireccion_ent.Text
                My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_ent.Text
                My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelOficina_ent.Text
                My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_ent.Text

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarentidad")
                EVEN = Nothing

                MessageBox.Show("Entidad registrada con Exito", "Entidades")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnEntEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar la Entidad", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Entidades")

        If respuesta = 6 Then

            Try

                ENT = New CLASE_ENTIDADES
                CON = New CLASE_CONTACTOS
                NOTA = New CLASE_NOTAS
                EVEN = New CLASE_EVENTOS

                ENT.p_Identidad = Me.txtIdentidad.Text
                CON.p_IdUsuario = Me.txtIdentidad.Text
                CON.p_IdTUsuario = 4 ' Tipo Entidad
                NOTA.p_IdUsuario = Me.txtIdentidad.Text
                NOTA.p_IdTUsuario = 4 ' Tipo Entidad

                ENT.Eliminar(CLASE_GENERAL.mensaje_error)
                CON.Eliminar(CLASE_GENERAL.mensaje_error)
                NOTA.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN.limpiar("limpiarficha")
                EVEN.limpiar("limpiarentidades")
                EVEN.bloquaerdesbloquear("nuevaentidad")

                Me.txtIdentidad.Text = (CLASE_GENERAL.maximo("Identidad", "entidades", CLASE_GENERAL.mensaje_error)) + 1

                ENT.dispose()
                ENT = Nothing
                CON.dispose()
                CON = Nothing
                NOTA.dispose()
                NOTA = Nothing
                EVEN = Nothing

                MsgBox("Entidad Eliminada con Exito", MsgBoxStyle.OkOnly, "Entidades")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If
    End Sub

    Private Sub frmEntidades_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "RichTxtNotas_ent") Then

            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                e.Handled = True
                SendKeys.Send(Convert.ToChar(Keys.Tab))
            End If

        End If

    End Sub

    Private Sub frmEntidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLASE_GENERAL.formload = 4
    End Sub

    Private Sub txtnombre_ent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre_ent.TextChanged
        Me.ErrorProvider.SetError(Me.txtnombre_ent, "")
    End Sub

    Private Sub txtdireccion_ent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion_ent.TextChanged
        Me.ErrorProvider.SetError(Me.txtdireccion_ent, "")
    End Sub

    Private Sub txtcontacto_ent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontacto_ent.TextChanged
        Me.ErrorProvider.SetError(Me.txtcontacto_ent, "")
    End Sub

    Private Sub txtTelOficina_ent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.SetError(Me.txtTelOficina_ent, "")
    End Sub

    Private Sub txtCelular_ent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.SetError(Me.txtCelular_ent, "")
    End Sub

    Private Sub txtemail_ent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProvider.SetError(Me.txtemail_ent, "")
    End Sub

    Private Sub btnNoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail.Click
        Me.txtemail_ent.Text = "notiene@"
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
        ubicarcontrol(Me.gpContactos)
        ubicarcontrol(Me.gpDatos)
        ubicarcontrol(Me.RichTxtNotas_ent)

        'Botones
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmEntidades_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class