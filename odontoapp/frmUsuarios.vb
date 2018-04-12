Imports System.Math

Public Class frmUsuarios

    'variables de Clases
    Private EMP As CLASE_EMPLEADOS
    Private EVEN As CLASE_EVENTOS
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS
    Private GENE As CLASE_GENERAL
    Private HUELLA As CLASE_HUELLAS

    'Varibles de control
    Private fecha As Date
    Private contar As Integer

    'Variables de Imagenes
    Private nombreImg As String = ""

    Private Sub btnEmpSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnEmpAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProvideremp.BlinkRate = 200
        Me.ErrorProvideremp.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtapellidos_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtapellidos_emp, "Escriba el Apellido Por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtapellidos_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.txtapellidos_emp.Focus()

        ElseIf Me.txtnombres_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtnombres_emp, "Escriba el Nombre por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtnombres_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.txtnombres_emp.Focus()

        ElseIf Me.txtresidencia_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtresidencia_emp, "Escriba la Dirección por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtresidencia_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.txtresidencia_emp.Focus()

        ElseIf Format(Me.cmbfecnac_emp.Value, "short date") = Format(Now(), "short date") Then
            ErrorProvideremp.SetError(Me.cmbfecnac_emp, "La Fecha de Nacimiento no puede ser Hoy rectifiquela por favor")
            MsgBox(ErrorProvideremp.GetError(Me.cmbfecnac_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.cmbfecnac_emp.Focus()

        ElseIf Me.txtEspecialidad_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtEspecialidad_emp, "Escriba la Especialidad por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtEspecialidad_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.txtEspecialidad_emp.Focus()

        ElseIf Me.cmbtipodoc_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.cmbtipodoc_emp, "Escoja el Tipo de Documento por favor")
            MsgBox(ErrorProvideremp.GetError(Me.cmbtipodoc_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.cmbtipodoc_emp.Focus()

        ElseIf Me.cmbPerfilAcceso.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.cmbPerfilAcceso, "Escoja el Nivel de Acceso por favor")
            MsgBox(ErrorProvideremp.GetError(Me.cmbPerfilAcceso), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.cmbPerfilAcceso.Focus()

        ElseIf Me.txtnumdoc_emp.Text.Length = 0 Or Me.txtnumdoc_emp.Text = "0" Then
            ErrorProvideremp.SetError(Me.txtnumdoc_emp, "Escriba el número de Documento por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtnumdoc_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.txtnumdoc_emp.Focus()

        ElseIf Me.txtClave_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtClave_emp, "Escriba La Clave por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtClave_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.txtClave_emp.Focus()

        ElseIf Not (Me.txtClave2_emp.Text = Me.txtClave_emp.Text) Then
            ErrorProvideremp.SetError(Me.txtClave2_emp, "La clave no se verifico, verifique por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtClave2_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 0
            Me.txtClave2_emp.Focus()

        ElseIf Me.txtTelCasa_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtTelCasa_emp, "Escriba el Telefono de la Casa en Contactos por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtTelCasa_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 1
            Me.txtTelCasa_emp.Focus()

        ElseIf Me.txtCelular_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtCelular_emp, "Escriba el No. de Celular en Contactos por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtCelular_emp), MsgBoxStyle.OkOnly, "Empleados")
            Me.TabControl_emp.SelectedTabIndex = 1
            Me.txtCelular_emp.Focus()

        ElseIf Me.txtemail_emp.Text.Length = 0 Then
            ErrorProvideremp.SetError(Me.txtemail_emp, "Escriba el email en contactos por favor")
            MsgBox(ErrorProvideremp.GetError(Me.txtemail_emp), MsgBoxStyle.OkOnly, "Pacientes")
            Me.TabControl_emp.SelectedTabIndex = 1
            Me.txtemail_emp.Focus()

        Else

            Try

                '**************************** MODULO PARA INGRESO DEL EMPLEADO *******************************

                EMP = New CLASE_EMPLEADOS

                'Asignamos los valores a las variables de la clase pacientes

                EMP.p_Idempleado = Me.txtIdempleado.Text
                EMP.p_apellidos_emp = Me.txtapellidos_emp.Text
                EMP.p_nombres_emp = Me.txtnombres_emp.Text
                EMP.p_residencia_emp = Me.txtresidencia_emp.Text
                EMP.p_fecingreso_emp = Format(Me.cmbfecingreso_emp.Value, "yyyy-MM-dd")
                EMP.p_especialidad_emp = Me.txtEspecialidad_emp.Text
                EMP.p_fecnac_emp = Format(Me.cmbfecnac_emp.Value, "yyyy-MM-dd")

                Select Case Me.cmbtipodoc_emp.Text

                    Case "T.I"
                        EMP.p_tipodoc_emp = 1
                    Case "CEDULA"
                        EMP.p_tipodoc_emp = 2
                    Case "PASAPORTE"
                        EMP.p_tipodoc_emp = 3
                    Case "C.EXTRANGERIA"
                        EMP.p_tipodoc_emp = 4

                End Select

                EMP.p_numdoc_emp = Me.txtnumdoc_emp.Text

                If Me.rbtMasculino_emp.Checked = True Then
                    EMP.p_sexo_emp = "M"
                Else
                    EMP.p_sexo_emp = "F"
                End If

                EMP.p_nivel_emp = Me.cmbPerfilAcceso.SelectedValue
                EMP.p_clave_emp = Me.txtClave_emp.Text

                'Insertamos en la base de datos
                EMP.Insertar(CLASE_GENERAL.mensaje_error)
                EMP.dispose() 'liberamos recursos
                EMP = Nothing

                '**************************** MODULO PARA INGRESO DE LOS CONTACTOS *******************************

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdempleado.Text
                CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes al paciente mismo
                CON.p_telcasa_con = Me.txtTelCasa_emp.Text
                CON.p_fax_con = Me.txtFax_emp.Text
                CON.p_cel_con = Me.txtCelular_emp.Text
                CON.p_email_con = Me.txtemail_emp.Text
                CON.p_web_con = Me.txtweb_emp.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdempleado.Text
                CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                CON.p_IdTTutor = 1 ' Utilizamos 1 Porque son los datos correspondientes al Padre del Paciente
                CON.p_nom_con = Me.txtPadre_emp.Text
                CON.p_telcasa_con = Me.txtTelPadre_emp.Text
                CON.p_cel_con = Me.txtCelPadre_emp.Text
                CON.p_ocu_con = Me.txtOcuPadre_emp.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdempleado.Text
                CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                CON.p_IdTTutor = 2 ' Utilizamos 2 Porque son los datos correspondientes la Madre del Paciente
                CON.p_nom_con = Me.txtMadre_emp.Text
                CON.p_telcasa_con = Me.txtTelMadre_emp.Text
                CON.p_cel_con = Me.txtCelMadre_emp.Text
                CON.p_ocu_con = Me.txtOcuMadre_emp.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIdempleado.Text
                CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipoEmpleado
                CON.p_IdTTutor = 4 ' Utilizamos 4 Porque son los datos correspondientes al Conyuge del Paciente
                CON.p_nom_con = Me.txtConyuge_emp.Text
                CON.p_telcasa_con = Me.txtTelConyuge_emp.Text
                CON.p_cel_con = Me.txtCelConyuge_emp.Text
                CON.p_ocu_con = Me.txtOcuConyuge_emp.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************
                NOTA = New CLASE_NOTAS
                GENE = New CLASE_GENERAL

                NOTA.p_IdUsuario = Me.txtIdempleado.Text
                NOTA.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                NOTA.p_nota = Me.RichTxtNotas_emp.Text

                If Not Me.pbFoto_emp.Image Is Nothing Then

                    NOTA.p_fotolong = GENE.Imagen_Bytes(Me.pbFoto_emp.Image)

                End If

                NOTA.Insertar(CLASE_GENERAL.mensaje_error)
                NOTA.dispose()
                NOTA = Nothing

                GENE = Nothing

                '**************************** MODULO PARA INGRESO EN LA FICHA *******************************

                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Me.pbFoto_emp.Image
                My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIdempleado.Text
                My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombres_emp.Text & " " & Me.txtapellidos_emp.Text
                'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtresidencia_emp.Text
                My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_emp.Text
                My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelCasa_emp.Text
                My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_emp.Text

                'Cargamos Id especial para Huellas
                CLASE_GENERAL._Idempleado_consec = Me.txtIdempleado.Text

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarempleado")
                EVEN = Nothing

                MessageBox.Show("Empleado registrado con Exito", "Empleados")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnEmpModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar Al Empleado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Empleados")

        If respuesta = 6 Then

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvideremp.BlinkRate = 200
            Me.ErrorProvideremp.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtapellidos_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.txtapellidos_emp, "Escriba el Apellido Por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtapellidos_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.txtapellidos_emp.Focus()

            ElseIf Me.txtnombres_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.txtnombres_emp, "Escriba el Nombre por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtnombres_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.txtnombres_emp.Focus()

            ElseIf Me.txtresidencia_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.txtresidencia_emp, "Escriba la Dirección por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtresidencia_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.txtresidencia_emp.Focus()

            ElseIf Format(Me.cmbfecnac_emp.Value, "short date") = Format(Now(), "short date") Then
                ErrorProvideremp.SetError(Me.cmbfecnac_emp, "La Fecha de Nacimiento no puede ser Hoy rectifiquela por favor")
                MsgBox(ErrorProvideremp.GetError(Me.cmbfecnac_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.cmbfecnac_emp.Focus()

            ElseIf Me.txtEspecialidad_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.txtEspecialidad_emp, "Escriba la Especialidad por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtEspecialidad_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.txtEspecialidad_emp.Focus()

            ElseIf Me.cmbtipodoc_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.cmbtipodoc_emp, "Escoja el Tipo de Documento por favor")
                MsgBox(ErrorProvideremp.GetError(Me.cmbtipodoc_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.cmbtipodoc_emp.Focus()

            ElseIf Me.cmbPerfilAcceso.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.cmbPerfilAcceso, "Escoja el Nivel de Acceso por favor")
                MsgBox(ErrorProvideremp.GetError(Me.cmbPerfilAcceso), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.cmbPerfilAcceso.Focus()

            ElseIf Me.txtnumdoc_emp.Text.Length = 0 Or Me.txtnumdoc_emp.Text = "0" Then
                ErrorProvideremp.SetError(Me.txtnumdoc_emp, "Escriba el número de Documento por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtnumdoc_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.txtnumdoc_emp.Focus()

                'ElseIf Me.txtClave_emp.Text.Length = 0 Then
                '    ErrorProvideremp.SetError(Me.txtClave_emp, "Escriba La Clave por favor")
                '    MsgBox(ErrorProvideremp.GetError(Me.txtClave_emp), MsgBoxStyle.OkOnly, "Empleados")
                '    Me.TabControl_emp.SelectedTabIndex = 0
                '    Me.txtClave_emp.Focus()

            ElseIf Not (Me.txtClave2_emp.Text = Me.txtClave_emp.Text) Then
                ErrorProvideremp.SetError(Me.txtClave2_emp, "La clave no se verifico, verifique por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtClave2_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 0
                Me.txtClave2_emp.Focus()

            ElseIf Me.txtTelCasa_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.txtTelCasa_emp, "Escriba el Telefono de la Casa en Contactos por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtTelCasa_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 1
                Me.txtTelCasa_emp.Focus()

            ElseIf Me.txtCelular_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.txtCelular_emp, "Escriba el No. de Celular en Contactos por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtCelular_emp), MsgBoxStyle.OkOnly, "Empleados")
                Me.TabControl_emp.SelectedTabIndex = 1
                Me.txtCelular_emp.Focus()

            ElseIf Me.txtemail_emp.Text.Length = 0 Then
                ErrorProvideremp.SetError(Me.txtemail_emp, "Escriba el email en contactos por favor")
                MsgBox(ErrorProvideremp.GetError(Me.txtemail_emp), MsgBoxStyle.OkOnly, "Pacientes")
                Me.TabControl_emp.SelectedTabIndex = 1
                Me.txtemail_emp.Focus()

            Else

                Try

                    '**************************** MODULO PARA MODIFICACION DE LOS EMPLEADOS *******************************
                    EMP = New CLASE_EMPLEADOS

                    'Asignamos los valores a las variables de la clase pacientes

                    EMP.p_Idempleado = Me.txtIdempleado.Text
                    EMP.p_apellidos_emp = Me.txtapellidos_emp.Text
                    EMP.p_nombres_emp = Me.txtnombres_emp.Text
                    EMP.p_residencia_emp = Me.txtresidencia_emp.Text
                    EMP.p_fecingreso_emp = Format(Me.cmbfecingreso_emp.Value, "yyyy-MM-dd")
                    EMP.p_especialidad_emp = Me.txtEspecialidad_emp.Text
                    EMP.p_fecnac_emp = Format(Me.cmbfecnac_emp.Value, "yyyy-MM-dd")

                    Select Case Me.cmbtipodoc_emp.Text

                        Case "T.I"
                            EMP.p_tipodoc_emp = 1
                        Case "CEDULA"
                            EMP.p_tipodoc_emp = 2
                        Case "PASAPORTE"
                            EMP.p_tipodoc_emp = 3
                        Case "C.EXTRANGERIA"
                            EMP.p_tipodoc_emp = 4

                    End Select

                    EMP.p_numdoc_emp = Me.txtnumdoc_emp.Text

                    If Me.rbtMasculino_emp.Checked = True Then
                        EMP.p_sexo_emp = "M"
                    Else
                        EMP.p_sexo_emp = "F"
                    End If

                    EMP.p_nivel_emp = Me.cmbPerfilAcceso.SelectedValue
                    EMP.p_clave_emp = Me.txtClave_emp.Text

                    'Verificamos si se escribio la clave actualizamos la clave sino la dejamos la que esta sin actualizar

                    If Me.txtClave_emp.Text.Length = 0 Then

                        EMP.Modificar("sinclave")

                    Else

                        EMP.Modificar("conclave")

                    End If

                    EMP.dispose()
                    EMP = Nothing

                    '**************************** MODULO PARA MODIFICACION DE LOS CONTACTOS *******************************

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdempleado.Text
                    CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                    CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes al paciente mismo
                    CON.p_telcasa_con = Me.txtTelCasa_emp.Text
                    CON.p_fax_con = Me.txtFax_emp.Text
                    CON.p_cel_con = Me.txtCelular_emp.Text
                    CON.p_email_con = Me.txtemail_emp.Text
                    CON.p_web_con = Me.txtweb_emp.Text

                    CON.Modificar(CLASE_GENERAL.mensaje_error)
                    CON.dispose()
                    CON = Nothing

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdempleado.Text
                    CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                    CON.p_IdTTutor = 1 ' Utilizamos 1 Porque son los datos correspondientes al Padre del Paciente
                    CON.p_nom_con = Me.txtPadre_emp.Text
                    CON.p_telcasa_con = Me.txtTelPadre_emp.Text
                    CON.p_cel_con = Me.txtCelPadre_emp.Text
                    CON.p_ocu_con = Me.txtOcuPadre_emp.Text

                    CON.Modificar(CLASE_GENERAL.mensaje_error)
                    CON.dispose()
                    CON = Nothing

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdempleado.Text
                    CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                    CON.p_IdTTutor = 2 ' Utilizamos 2 Porque son los datos correspondientes la Madre del Paciente
                    CON.p_nom_con = Me.txtMadre_emp.Text
                    CON.p_telcasa_con = Me.txtTelMadre_emp.Text
                    CON.p_cel_con = Me.txtCelMadre_emp.Text
                    CON.p_ocu_con = Me.txtOcuMadre_emp.Text

                    CON.Modificar(CLASE_GENERAL.mensaje_error)
                    CON.dispose()
                    CON = Nothing


                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIdempleado.Text
                    CON.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipoEmpleado
                    CON.p_IdTTutor = 4 ' Utilizamos 4 Porque son los datos correspondientes al Conyuge del Paciente
                    CON.p_nom_con = Me.txtConyuge_emp.Text
                    CON.p_telcasa_con = Me.txtTelConyuge_emp.Text
                    CON.p_cel_con = Me.txtCelConyuge_emp.Text
                    CON.p_ocu_con = Me.txtOcuConyuge_emp.Text

                    CON.Modificar(CLASE_GENERAL.mensaje_error)
                    CON.dispose()
                    CON = Nothing

                    '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************

                    NOTA = New CLASE_NOTAS
                    GENE = New CLASE_GENERAL

                    NOTA.p_IdUsuario = Me.txtIdempleado.Text
                    NOTA.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Empleado
                    NOTA.p_nota = Me.RichTxtNotas_emp.Text

                    If Not Me.pbFoto_emp.Image Is Nothing Then

                        NOTA.p_fotolong = GENE.Imagen_Bytes(Me.pbFoto_emp.Image)

                    End If

                    NOTA.Modificar("notas")
                    NOTA.dispose()
                    NOTA = Nothing
                    GENE = Nothing

                    '**************************** CARGAMOS LA FICHA ************************

                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiarficha")

                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Me.pbFoto_emp.Image
                    My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIdempleado.Text
                    My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombres_emp.Text & " " & Me.txtapellidos_emp.Text
                    'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtresidencia_emp.Text
                    My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_emp.Text
                    My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelCasa_emp.Text
                    My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_emp.Text

                    'Cargamos Id especial para Huellas
                    CLASE_GENERAL._Idempleado_consec = Me.txtIdempleado.Text

                    EVEN.bloquaerdesbloquear("editarempleado")
                    EVEN = Nothing

                    MsgBox("Empleado modificado con Exito", MsgBoxStyle.OkOnly, "Empleados")

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try
            End If
        End If
    End Sub

    Private Sub btnEmpNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea un Nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Usuarios")

        If respuesta = 6 Then


            Try

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarempleados")
                EVEN.limpiar("limpiarficha")
                EVEN.bloquaerdesbloquear("nuevoempleado")
                Me.txtIdempleado.Text = (CLASE_GENERAL.maximo("IdEmpleado", "empleados", CLASE_GENERAL.mensaje_error)) + 1
                EVEN = Nothing

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If


    End Sub

    Private Sub btnEmpEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar el Empleado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Empleados")

        If respuesta = 6 Then

            Try

                EMP = New CLASE_EMPLEADOS
                CON = New CLASE_CONTACTOS
                NOTA = New CLASE_NOTAS
                EVEN = New CLASE_EVENTOS

                EMP.p_Idempleado = Me.txtIdempleado.Text
                CON.p_IdUsuario = Me.txtIdempleado.Text
                CON.p_IdTUsuario = 3 ' Tipo Empleado
                NOTA.p_IdUsuario = Me.txtIdempleado.Text
                NOTA.p_IdTUsuario = 3 ' Tipo Pacientes

                EMP.Eliminar(CLASE_GENERAL.mensaje_error)
                CON.Eliminar(CLASE_GENERAL.mensaje_error)
                NOTA.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN.limpiar("limpiarempleados")
                EVEN.limpiar("limpiarficha")
                EVEN.bloquaerdesbloquear("nuevoempleado")

                Me.txtIdempleado.Text = (CLASE_GENERAL.maximo("IdEmpleado", "empleados", CLASE_GENERAL.mensaje_error)) + 1


                EMP.dispose()
                EMP = Nothing
                CON.dispose()
                CON = Nothing
                NOTA.dispose()
                NOTA = Nothing
                EVEN = Nothing

                MsgBox("Empleado Eliminado con Exito", MsgBoxStyle.OkOnly, "Empleados")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try
        End If

    End Sub

    Private Sub rbtAños_emp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAños_emp.CheckedChanged
        Me.lblNumaños.Text = DateDiff(DateInterval.Year, Me.cmbfecnac_emp.Value, Now())
    End Sub

    Private Sub rbtmeses_emp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtmeses_emp.CheckedChanged
        Me.lblNumaños.Text = DateDiff(DateInterval.Month, Me.cmbfecnac_emp.Value, Now())
    End Sub

    Private Sub cmbfecnac_emp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfecnac_emp.ValueChanged

        Me.ErrorProvideremp.SetError(Me.cmbfecnac_emp, "")

        If Me.rbtAños_emp.Checked = True Then
            Me.lblNumaños.Text = DateDiff(DateInterval.Year, Me.cmbfecnac_emp.Value, Now())
        Else
            Me.lblNumaños.Text = DateDiff(DateInterval.Month, Me.cmbfecnac_emp.Value, Now())
        End If
    End Sub

    Private Sub frmUsuarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "RichTxtNotas_emp") Then

            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                e.Handled = True
                SendKeys.Send(Convert.ToChar(Keys.Tab))
            End If

        End If

    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CLASE_GENERAL.formload = 3

        CLASE_GENERAL.cargar_combo("perfilesacceso", Me.cmbPerfilAcceso, CLASE_GENERAL.mensaje_error)
        Me.cmbPerfilAcceso.SelectedValue = 1

    End Sub

    Private Sub btnEmpFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click
        frmFotografia.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmFotografia.Show()
        frmFotografia.Activate()
        CLASE_GENERAL.formload = 3
    End Sub

    Private Sub btnEmpFotoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFotoA.Click

        Try

            OpenFileDialogEmp = New OpenFileDialog
            OpenFileDialogEmp.Filter = "Imágenes JPG (*.jpg)|*.jpg|Mapas de bits (*.bmp)|*.bmp"
            OpenFileDialogEmp.Title = "Abre una imagen JPG o BMP"

            If OpenFileDialogEmp.ShowDialog() = DialogResult.OK Then

                nombreImg = OpenFileDialogEmp.FileName
                Me.pbFoto_emp.Image = Image.FromFile(nombreImg)
                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Image.FromFile(nombreImg)
                Me.pbFoto_emp.SizeMode = PictureBoxSizeMode.Zoom

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub txtapellidos_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellidos_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtapellidos_emp, "")
    End Sub

    Private Sub txtnombres_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombres_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtnombres_emp, "")
    End Sub

    Private Sub txtresidencia_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtresidencia_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtresidencia_emp, "")
    End Sub

    Private Sub txtEspecialidad_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEspecialidad_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtEspecialidad_emp, "")
    End Sub

    Private Sub cmbtipodoc_emp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipodoc_emp.SelectedIndexChanged
        Me.ErrorProvideremp.SetError(Me.cmbtipodoc_emp, "")
    End Sub

    Private Sub txtnumdoc_emp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumdoc_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtnumdoc_emp, "")
    End Sub
    Private Sub txtTelCasa_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelCasa_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtTelCasa_emp, "")
    End Sub
    Private Sub txtCelular_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtCelular_emp, "")
    End Sub
    Private Sub txtClave_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtClave_emp, "")
    End Sub
    Private Sub txtClave2_emp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClave2_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtClave2_emp, "")
    End Sub
    Private Sub txtemail_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail_emp.TextChanged
        Me.ErrorProvideremp.SetError(Me.txtemail_emp, "")
    End Sub
    Private Sub btnNoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail.Click
        Me.txtemail_emp.Text = "notiene@"
    End Sub

    Private Sub btnBorrarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarFoto.Click

        Me.pbFoto_emp.Image = My.Resources.fondoempleado

    End Sub

    Private Sub cmbPerfilAcceso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPerfilAcceso.SelectedIndexChanged
        Me.ErrorProvideremp.SetError(Me.cmbPerfilAcceso, "")
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
        ubicarcontrol(Me.pbFoto_emp)
        ubicarcontrol(Me.btnFotoA)
        ubicarcontrol(Me.btnBorrarFoto)
        ubicarcontrol(Me.btnFoto)

        ubicarcontrol(Me.lblapellidos_emp)
        ubicarcontrol(Me.txtapellidos_emp)
        ubicarcontrol(Me.txtnombres_emp)
        ubicarcontrol(Me.lblnombres_emp)
        ubicarcontrol(Me.txtresidencia_emp)
        ubicarcontrol(Me.lblresidencia_emp)
        ubicarcontrol(Me.txtEspecialidad_emp)
        ubicarcontrol(Me.lblEspecialidad_emp)
        ubicarcontrol(Me.cmbfecingreso_emp)
        ubicarcontrol(Me.lblfecingreso_emp)
        ubicarcontrol(Me.cmbfecnac_emp)
        ubicarcontrol(Me.lblfecnac_emp)
        ubicarcontrol(Me.cmbtipodoc_emp)
        ubicarcontrol(Me.lbltipodoc_emp)
        ubicarcontrol(Me.txtnumdoc_emp)
        ubicarcontrol(Me.lblnumdoc_emp)
        ubicarcontrol(Me.txtIdempleado)
        ubicarcontrol(Me.lblIdempleado)

        ubicarcontrol(Me.txtClave_emp)
        ubicarcontrol(Me.lblClave_emp)
        ubicarcontrol(Me.txtClave2_emp)
        ubicarcontrol(Me.lblClave2_emp)

        'Notas
        ubicarcontrol(Me.gpNotas)
        ubicarcontrol(Me.lblRegistroBiometrico)
        ubicarcontrol(Me.gpRegistroBiometrico)

        ubicarcontrol(Me.gPanel_nivel)
        ubicarcontrol(Me.gPanel_Sexo)
        ubicarcontrol(Me.gPanel_Edad)

        ubicarcontrol(Me.gpContactos)
        ubicarcontrol(Me.gpPadres)
        ubicarcontrol(Me.gpConyuge)

        'Botones
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmUsuarios_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

    Private Sub btnRegistroBiometrico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroBiometrico.Click

        Try

            '*********** CREAMOS LOS ESPACIOS DE LAS HUELLAS INICIALES ******************

            CLASE_GENERAL._TipoUsuario = 3 'Tipo Empleados

            contar = 0
            contar = CLASE_GENERAL.contarhuellas(Me.txtIdempleado.Text, 3, CLASE_GENERAL.mensaje_error)

            If contar = 0 Then

                HUELLA = New CLASE_HUELLAS

                HUELLA.p_Idhuella = (CLASE_GENERAL.maximo("Idhuella", "huellas", CLASE_GENERAL.mensaje_error)) + 1
                HUELLA.p_IdUsuario = Me.txtIdempleado.Text
                HUELLA.p_IdTUsuario = 3 ' Tipo empleado
                HUELLA.p_fechareg = Format(Date.Now, "yyyy-MM-dd")

                HUELLA.Insertar(CLASE_GENERAL.mensaje_error)

                HUELLA.dispose()
                HUELLA = Nothing

            Else

                '**************************** HUELLAS REGISTRADAS *************************************

                HUELLA = New CLASE_HUELLAS

                HUELLA.p_IdUsuario = Me.txtIdempleado.Text
                HUELLA.p_IdTUsuario = 3 'Tipo empleado
                HUELLA.Seleccionar("todos")

                If Not (CLASE_HUELLAS.xhuella1 = "") Then
                    My.Forms.frmHuellas.D1.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D1.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella2 = "") Then

                    My.Forms.frmHuellas.D2.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D2.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella3 = "") Then
                    My.Forms.frmHuellas.D3.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D3.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella4 = "") Then

                    My.Forms.frmHuellas.D4.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D4.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella5 = "") Then

                    My.Forms.frmHuellas.D5.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D5.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella6 = "") Then

                    My.Forms.frmHuellas.D6.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D6.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella7 = "") Then

                    My.Forms.frmHuellas.D7.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D7.BackColor = Color.Transparent
                End If

                If Not (CLASE_HUELLAS.xhuella8 = "") Then

                    My.Forms.frmHuellas.D8.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D8.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella9 = "") Then

                    My.Forms.frmHuellas.D9.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D9.BackColor = Color.Transparent

                End If

                If Not (CLASE_HUELLAS.xhuella10 = "") Then

                    My.Forms.frmHuellas.D10.BackColor = Color.Lime
                Else
                    My.Forms.frmHuellas.D10.BackColor = Color.Transparent

                End If

                HUELLA.dispose()
                HUELLA = Nothing

            End If

            ' *********************************************************************

            frmHuellas.MdiParent = My.Forms.mdiOrthoSoft
            'Display the new form.
            frmHuellas.Show()
            frmHuellas.Activate()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub
End Class