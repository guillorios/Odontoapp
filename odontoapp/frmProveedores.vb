Imports System.Math

Public Class frmProveedores

    Private PROVEE As CLASE_PROVEEDORES
    Private EVEN As CLASE_EVENTOS


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea Guardar el registro antes de salir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Proveedores")

        If respuesta = MsgBoxResult.Yes Then

            If btnAdicionar.Enabled = False Then

                btnModificar_Click(sender, e)

            Else

                btnAdicionar_Click(sender, e)

            End If

        End If

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProvider.BlinkRate = 200
        Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtnombre_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtnombre_prov, "Escriba el Nombre por favor")
            MsgBox(ErrorProvider.GetError(Me.txtnombre_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtnombre_prov.Focus()

        ElseIf Me.txtdireccion_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtdireccion_prov, "Escriba la Dirección por favor")
            MsgBox(ErrorProvider.GetError(Me.txtdireccion_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtdireccion_prov.Focus()

        ElseIf Me.txtcontacto_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtcontacto_prov, "Escriba el Nombre del Contacto por favor")
            MsgBox(ErrorProvider.GetError(Me.txtcontacto_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtcontacto_prov.Focus()

        ElseIf Me.txtteloficina_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtteloficina_prov, "Escriba el Telefono de la Oficina en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtteloficina_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtteloficina_prov.Focus()

        ElseIf Me.txtcelular_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtcelular_prov, "Escriba el No. de Celular en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtcelular_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtcelular_prov.Focus()

        ElseIf Me.txtemail_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtemail_prov, "Escriba el email en contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtemail_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtemail_prov.Focus()

        Else

            Try

                '**************************** MODULO PARA INGRESO DE LAS Proveedores *******************************
                PROVEE = New CLASE_PROVEEDORES

                'Asignamos los valores a las variables de la clase proveedores

                PROVEE.p_Idproveedor = Me.txtIdproveedor.Text
                PROVEE.p_nombre_prov = Me.txtnombre_prov.Text
                PROVEE.p_direccion_prov = Me.txtdireccion_prov.Text
                PROVEE.p_contacto_prov = Me.txtcontacto_prov.Text
                PROVEE.p_teloficina_prov = Me.txtteloficina_prov.Text
                PROVEE.p_celular_prov = Me.txtcelular_prov.Text
                PROVEE.p_fax_prov = Me.txtfax_prov.Text
                PROVEE.p_email_prov = Me.txtemail_prov.Text
                PROVEE.p_web_prov = Me.txtweb_prov.Text
                PROVEE.p_Idconsultorio = 1

                'Insertamos en la base de datos
                PROVEE.Insertar(CLASE_GENERAL.mensaje_error)

                PROVEE.dispose() ' Liberamos recursos
                PROVEE = Nothing

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarproveedor")
                EVEN = Nothing

                ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                    If frm.Name = "frmComprobanteEgreso" Then

                        CLASE_GENERAL.cargar_combo("proveedores", My.Forms.frmComprobanteEgreso.cmbProveedores, CLASE_GENERAL.mensaje_error)
                        My.Forms.frmComprobanteEgreso.cmbProveedores.Text = ""

                    End If

                Next

                MessageBox.Show("Proveedor Registrado con Exito", "Proveedores")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProvider.BlinkRate = 200
        Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtnombre_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtnombre_prov, "Escriba el Nombre por favor")
            MsgBox(ErrorProvider.GetError(Me.txtnombre_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtnombre_prov.Focus()

        ElseIf Me.txtdireccion_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtdireccion_prov, "Escriba la Dirección por favor")
            MsgBox(ErrorProvider.GetError(Me.txtdireccion_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtdireccion_prov.Focus()

        ElseIf Me.txtcontacto_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtcontacto_prov, "Escriba el Nombre del Contacto por favor")
            MsgBox(ErrorProvider.GetError(Me.txtcontacto_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtcontacto_prov.Focus()

        ElseIf Me.txtteloficina_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtteloficina_prov, "Escriba el Telefono de la Oficina en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtteloficina_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtteloficina_prov.Focus()

        ElseIf Me.txtcelular_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtcelular_prov, "Escriba el No. de Celular en Contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtcelular_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtcelular_prov.Focus()

        ElseIf Me.txtemail_prov.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtemail_prov, "Escriba el email en contactos por favor")
            MsgBox(ErrorProvider.GetError(Me.txtemail_prov), MsgBoxStyle.OkOnly, "Proveedores")
            Me.txtemail_prov.Focus()

        Else

            Try

                '**************************** MODULO PARA INGRESO DE LAS Proveedores *******************************
                PROVEE = New CLASE_PROVEEDORES

                'Asignamos los valores a las variables de la clase proveedores

                PROVEE.p_Idproveedor = Me.txtIdproveedor.Text
                PROVEE.p_nombre_prov = Me.txtnombre_prov.Text
                PROVEE.p_direccion_prov = Me.txtdireccion_prov.Text
                PROVEE.p_contacto_prov = Me.txtcontacto_prov.Text
                PROVEE.p_teloficina_prov = Me.txtteloficina_prov.Text
                PROVEE.p_celular_prov = Me.txtcelular_prov.Text
                PROVEE.p_fax_prov = Me.txtfax_prov.Text
                PROVEE.p_email_prov = Me.txtemail_prov.Text
                PROVEE.p_web_prov = Me.txtweb_prov.Text
                PROVEE.p_Idconsultorio = 1

                'Insertamos en la base de datos
                PROVEE.Modificar("registro")

                PROVEE.dispose() ' Liberamos recursos
                PROVEE = Nothing

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarproveedor")
                EVEN = Nothing

                ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                    If frm.Name = "frmComprobanteEgreso" Then

                        CLASE_GENERAL.cargar_combo("proveedores", My.Forms.frmComprobanteEgreso.cmbProveedores, CLASE_GENERAL.mensaje_error)
                        My.Forms.frmComprobanteEgreso.cmbProveedores.Text = ""

                    End If

                Next

                MessageBox.Show("Proveedor Modificado con Exito", "Proveedores")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub txtnombre_prov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre_prov.TextChanged
        Me.ErrorProvider.SetError(Me.txtnombre_prov, "")
    End Sub

    Private Sub txtdireccion_prov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion_prov.TextChanged
        Me.ErrorProvider.SetError(Me.txtdireccion_prov, "")
    End Sub

    Private Sub txtcontacto_prov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontacto_prov.TextChanged
        Me.ErrorProvider.SetError(Me.txtcontacto_prov, "")
    End Sub

    Private Sub txtteloficina_prov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtteloficina_prov.TextChanged
        Me.ErrorProvider.SetError(Me.txtteloficina_prov, "")
    End Sub

    Private Sub txtcelular_prov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcelular_prov.TextChanged
        Me.ErrorProvider.SetError(Me.txtcelular_prov, "")
    End Sub

    Private Sub txtemail_prov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail_prov.TextChanged
        Me.ErrorProvider.SetError(Me.txtemail_prov, "")
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea un Nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Proveedores")

        If respuesta = MsgBoxResult.Yes Then

            Try

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarproveedores")
                EVEN.bloquaerdesbloquear("nuevoproveedor")
                EVEN = Nothing

                Me.txtIdproveedor.Text = (CLASE_GENERAL.maximo("Idproveedor", "proveedores", CLASE_GENERAL.mensaje_error)) + 1

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If


    End Sub

    Private Sub btnNoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail.Click

        Me.txtemail_prov.Text = "notiene@"

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar el Paciente", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pacientes")

        If respuesta = MsgBoxResult.Yes Then

            Try

                PROVEE = New CLASE_PROVEEDORES
                PROVEE.p_Idproveedor = Me.txtIdproveedor.Text

                PROVEE.Eliminar(CLASE_GENERAL.mensaje_error)

                PROVEE.dispose()
                PROVEE = Nothing

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarproveedores")
                EVEN.bloquaerdesbloquear("nuevoproveedor")
                EVEN = Nothing

                Me.txtIdproveedor.Text = (CLASE_GENERAL.maximo("Idproveedor", "proveedores", CLASE_GENERAL.mensaje_error)) + 1

                ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                    If frm.Name = "frmComprobanteEgreso" Then

                        CLASE_GENERAL.cargar_combo("proveedores", My.Forms.frmComprobanteEgreso.cmbProveedores, CLASE_GENERAL.mensaje_error)
                        My.Forms.frmComprobanteEgreso.cmbProveedores.Text = ""

                    End If

                Next

                MsgBox("Proveedor Eliminado con Exito", MsgBoxStyle.OkOnly, "Proveedores")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If

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

        'Fotos Iniciales
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.lblIdproveedor)
        ubicarcontrol(Me.txtIdproveedor)
        ubicarcontrol(Me.gpDatos)
        ubicarcontrol(Me.gpContactos)
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmProveedores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "RichTxtNotas_ent") Then

            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                e.Handled = True
                SendKeys.Send(Convert.ToChar(Keys.Tab))
            End If

        End If

    End Sub


    Private Sub frmProveedores_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ubicarcontroles()
    End Sub
End Class