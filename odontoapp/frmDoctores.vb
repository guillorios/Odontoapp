Imports System.Math

Public Class frmDoctores

    'Variables de Clases
    Private DOC As CLASE_DOCTORES
    Private EVEN As CLASE_EVENTOS
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS
    Private GENE As CLASE_GENERAL
    Private HUELLA As CLASE_HUELLAS

    'Varibles de control
    Private fecha As Date
    Private contar As Integer

    'Variables de imagen
    Private nombreImg As String = ""

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProviderdoc.BlinkRate = 200
        Me.ErrorProviderdoc.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtapellidos_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtapellidos_doc, "Escriba el Apellido Por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtapellidos_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.txtapellidos_doc.Focus()

        ElseIf Me.txtnombres_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtnombres_doc, "Escriba el Nombre por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtnombres_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.txtnombres_doc.Focus()

        ElseIf Me.txtresidencia_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtresidencia_doc, "Escriba la Dirección por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtresidencia_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.txtresidencia_doc.Focus()

        ElseIf Me.txtoficina_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtoficina_doc, "Escriba la Ocupación por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtoficina_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.txtoficina_doc.Focus()

        ElseIf Format(Me.cmbfecnac_doc.Value, "short date") = Format(Now(), "short date") Then
            ErrorProviderdoc.SetError(Me.cmbfecnac_doc, "La Fecha de Nacimiento no puede ser Hoy rectifiquela por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.cmbfecnac_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.cmbfecnac_doc.Focus()

        ElseIf Me.cmbEspecialidades.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.cmbEspecialidades, "Seleccione la Especialidad por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.cmbEspecialidades), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.cmbEspecialidades.Focus()

        ElseIf Me.cmbtipodoc_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.cmbtipodoc_doc, "Escoja el Tipo de Documento por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.cmbtipodoc_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.cmbtipodoc_doc.Focus()

        ElseIf Me.txtnumdoc_doc.Text.Length = 0 Or Me.txtnumdoc_doc.Text = "0" Then
            ErrorProviderdoc.SetError(Me.txtnumdoc_doc, "Escriba el número de Documento por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtnumdoc_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 0
            Me.txtnumdoc_doc.Focus()

        ElseIf Me.txtTelCasa_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtTelCasa_doc, "Escriba el Telefono de la Casa en Contactos por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtTelCasa_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 1
            Me.txtTelCasa_doc.Focus()

        ElseIf Me.txtTelOficina_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtTelOficina_doc, "Escriba el Telefono de la Oficina en Contactos por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtTelOficina_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 1
            Me.txtTelOficina_doc.Focus()

        ElseIf Me.txtCelular_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtCelular_doc, "Escriba el No. de Celular en Contactos por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtCelular_doc), MsgBoxStyle.OkOnly, "Doctores")
            Me.TabControl_Doc.SelectedTabIndex = 1
            Me.txtCelular_doc.Focus()

        ElseIf Me.txtemail_doc.Text.Length = 0 Then
            ErrorProviderdoc.SetError(Me.txtemail_doc, "Escriba el email en contactos por favor")
            MsgBox(ErrorProviderdoc.GetError(Me.txtemail_doc), MsgBoxStyle.OkOnly, "Pacientes")
            Me.TabControl_Doc.SelectedTabIndex = 1
            Me.txtemail_doc.Focus()

        Else

            Try

                '**************************** MODULO PARA INGRESO DEL DOCTORES *******************************
                DOC = New CLASE_DOCTORES

                'Asignamos los valores a las variables de la clase pacientes

                DOC.p_Iddoctor = Me.txtIddoctor.Text
                DOC.p_apellidos_doc = Me.txtapellidos_doc.Text
                DOC.p_nombres_doc = Me.txtnombres_doc.Text
                DOC.p_residencia_doc = Me.txtresidencia_doc.Text
                DOC.p_oficina_doc = Me.txtoficina_doc.Text
                DOC.p_fecingreso_doc = Format(Me.cmbfecingreso_doc.Value, "yyyy-MM-dd")
                DOC.p_Idespecialidad = Me.cmbEspecialidades.SelectedValue
                DOC.p_fecnac_doc = Format(Me.cmbfecnac_doc.Value, "yyyy-MM-dd")

                Select Case Me.cmbtipodoc_doc.Text

                    Case "T.I"
                        DOC.p_tipodoc_doc = 1
                    Case "CEDULA"
                        DOC.p_tipodoc_doc = 2
                    Case "PASAPORTE"
                        DOC.p_tipodoc_doc = 3
                    Case "C.EXTRANGERIA"
                        DOC.p_tipodoc_doc = 4

                End Select

                DOC.p_numdoc_doc = Me.txtnumdoc_doc.Text

                If Me.rbtMasculino_doc.Checked = True Then
                    DOC.p_sexo_doc = "M"
                Else
                    DOC.p_sexo_doc = "F"
                End If

                'Insertamos en la base de datos lo correspondiente a los datos basicos del doctor

                DOC.Insertar(CLASE_GENERAL.mensaje_error)
                DOC.dispose() ' Liberamos recursos
                DOC = Nothing

                '**************************** MODULO PARA INGRESO DE LOS CONTACTOS *******************************
                CON = New CLASE_CONTACTOS

                CON.p_IdUsuario = Me.txtIddoctor.Text
                CON.p_IdTUsuario = 2 ' Utilizamos uno porque es de tipo Doctor ******
                CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes al doctor mismo
                CON.p_telcasa_con = Me.txtTelCasa_doc.Text
                CON.p_teloficina_con = Me.txtTelOficina_doc.Text
                CON.p_fax_con = Me.txtFax_doc.Text
                CON.p_cel_con = Me.txtCelular_doc.Text
                CON.p_email_con = Me.txtemail_doc.Text
                CON.p_web_con = Me.txtweb_doc.Text

                CON.Insertar(CLASE_GENERAL.mensaje_error)
                CON.dispose()
                CON = Nothing

                '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************

                NOTA = New CLASE_NOTAS
                GENE = New CLASE_GENERAL

                NOTA.p_IdUsuario = Me.txtIddoctor.Text
                NOTA.p_IdTUsuario = 2 ' Utilizamos uno porque es de tipo Doctor
                NOTA.p_nota = Me.RichTxtNotas_doc.Text

                If Not Me.pbFoto_doc.Image Is Nothing Then

                    NOTA.p_fotolong = GENE.Imagen_Bytes(Me.pbFoto_doc.Image)

                End If


                NOTA.Insertar(CLASE_GENERAL.mensaje_error)
                NOTA.dispose()
                NOTA = Nothing

                GENE = Nothing

                '**************************** MODULO PARA INGRESO EN LA FICHA *******************************

                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Me.pbFoto_doc.Image
                My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIddoctor.Text
                My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombres_doc.Text & " " & Me.txtapellidos_doc.Text
                'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtresidencia_doc.Text
                My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_doc.Text
                My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelCasa_doc.Text
                My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_doc.Text

                '***************************** MODULO PARA INGRESO EN EL ESTADO ******************************

                CLASE_GENERAL.cargar_combo("doctores", My.Forms.mdiOrthoSoft.cmbDoctores, CLASE_GENERAL.mensaje_error)
                My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue = Me.txtIddoctor.Text
                My.Forms.mdiOrthoSoft.CalOrthosoft.ClearDays()

                'Cargamos los Labels principales
                My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = Me.txtnombres_doc.Text & " " & Me.txtapellidos_doc.Text
                My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag = Me.txtIddoctor.Text

                'Cargamos Id especial para Huellas
                CLASE_GENERAL._Iddoctor_consec = Me.txtIddoctor.Text()

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editardoctor")
                EVEN = Nothing

                MsgBox("Doctor registrado con Exito", MsgBoxStyle.OkOnly, "Doctores")

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar al Doctor", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Doctores")

        If respuesta = 6 Then


            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProviderdoc.BlinkRate = 200
            Me.ErrorProviderdoc.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtapellidos_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtapellidos_doc, "Escriba el Apellido Por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtapellidos_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.txtapellidos_doc.Focus()

            ElseIf Me.txtnombres_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtnombres_doc, "Escriba el Nombre por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtnombres_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.txtnombres_doc.Focus()

            ElseIf Me.txtresidencia_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtresidencia_doc, "Escriba la Dirección por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtresidencia_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.txtresidencia_doc.Focus()

            ElseIf Me.txtoficina_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtoficina_doc, "Escriba la Ocupación por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtoficina_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.txtoficina_doc.Focus()

            ElseIf Format(Me.cmbfecnac_doc.Value, "short date") = Format(Now(), "short date") Then
                ErrorProviderdoc.SetError(Me.cmbfecnac_doc, "La Fecha de Nacimiento no puede ser Hoy rectifiquela por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.cmbfecnac_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.cmbfecnac_doc.Focus()

            ElseIf Me.cmbEspecialidades.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.cmbEspecialidades, "Escriba la Especialidad por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.cmbEspecialidades), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.cmbEspecialidades.Focus()

            ElseIf Me.cmbtipodoc_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.cmbtipodoc_doc, "Escoja el Tipo de Documento por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.cmbtipodoc_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.cmbtipodoc_doc.Focus()

            ElseIf Me.txtnumdoc_doc.Text.Length = 0 Or Me.txtnumdoc_doc.Text = "0" Then
                ErrorProviderdoc.SetError(Me.txtnumdoc_doc, "Escriba el número de Documento por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtnumdoc_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 0
                Me.txtnumdoc_doc.Focus()

            ElseIf Me.txtTelCasa_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtTelCasa_doc, "Escriba el Telefono de la Casa en Contactos por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtTelCasa_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 1
                Me.txtTelCasa_doc.Focus()

            ElseIf Me.txtTelOficina_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtTelOficina_doc, "Escriba el Telefono de la Oficina en Contactos por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtTelOficina_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 1
                Me.txtTelOficina_doc.Focus()

            ElseIf Me.txtCelular_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtCelular_doc, "Escriba el No. de Celular en Contactos por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtCelular_doc), MsgBoxStyle.OkOnly, "Doctores")
                Me.TabControl_Doc.SelectedTabIndex = 1
                Me.txtCelular_doc.Focus()

            ElseIf Me.txtemail_doc.Text.Length = 0 Then
                ErrorProviderdoc.SetError(Me.txtemail_doc, "Escriba el email en contactos por favor")
                MsgBox(ErrorProviderdoc.GetError(Me.txtemail_doc), MsgBoxStyle.OkOnly, "Pacientes")
                Me.TabControl_Doc.SelectedTabIndex = 1
                Me.txtemail_doc.Focus()

            Else

                Try

                    '**************************** MODULO PARA MODIFICACION DE LOS DOCTORES *******************************

                    DOC = New CLASE_DOCTORES

                    'Asignamos los valores a las variables de la clase doctores

                    DOC.p_Iddoctor = Me.txtIddoctor.Text
                    DOC.p_apellidos_doc = Me.txtapellidos_doc.Text
                    DOC.p_nombres_doc = Me.txtnombres_doc.Text
                    DOC.p_residencia_doc = Me.txtresidencia_doc.Text
                    DOC.p_oficina_doc = Me.txtoficina_doc.Text
                    DOC.p_fecingreso_doc = Format(Me.cmbfecingreso_doc.Value, "yyyy-MM-dd")
                    DOC.p_Idespecialidad = Me.cmbEspecialidades.SelectedValue
                    DOC.p_fecnac_doc = Format(Me.cmbfecnac_doc.Value, "yyyy-MM-dd")

                    Select Case Me.cmbtipodoc_doc.Text

                        Case "T.I"
                            DOC.p_tipodoc_doc = 1
                        Case "CEDULA"
                            DOC.p_tipodoc_doc = 2
                        Case "PASAPORTE"
                            DOC.p_tipodoc_doc = 3
                        Case "C.EXTRANGERIA"
                            DOC.p_tipodoc_doc = 4

                    End Select

                    DOC.p_numdoc_doc = Me.txtnumdoc_doc.Text

                    If Me.rbtMasculino_doc.Checked = True Then
                        DOC.p_sexo_doc = "M"
                    Else
                        DOC.p_sexo_doc = "F"
                    End If

                    DOC.Modificar(CLASE_GENERAL.mensaje_error)
                    DOC.dispose()
                    DOC = Nothing

                    '**************************** MODULO PARA MODIFICACION DE LOS CONTACTOS *******************************

                    CON = New CLASE_CONTACTOS

                    CON.p_IdUsuario = Me.txtIddoctor.Text
                    CON.p_IdTUsuario = 2 ' Utilizamos uno porque es de tipo Doctor ******
                    CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes al doctor mismo
                    CON.p_telcasa_con = Me.txtTelCasa_doc.Text
                    CON.p_teloficina_con = Me.txtTelOficina_doc.Text
                    CON.p_fax_con = Me.txtFax_doc.Text
                    CON.p_cel_con = Me.txtCelular_doc.Text
                    CON.p_email_con = Me.txtemail_doc.Text
                    CON.p_web_con = Me.txtweb_doc.Text

                    CON.Modificar(CLASE_GENERAL.mensaje_error)
                    CON.dispose()
                    CON = Nothing

                    '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************

                    NOTA = New CLASE_NOTAS
                    GENE = New CLASE_GENERAL

                    NOTA.p_IdUsuario = Me.txtIddoctor.Text
                    NOTA.p_IdTUsuario = 2 ' Utilizamos uno porque es de tipo Doctor
                    NOTA.p_nota = Me.RichTxtNotas_doc.Text

                    If Not Me.pbFoto_doc.Image Is Nothing Then

                        NOTA.p_fotolong = GENE.Imagen_Bytes(Me.pbFoto_doc.Image)

                    End If

                    NOTA.Modificar("notas")
                    NOTA.dispose()
                    NOTA = Nothing

                    GENE = Nothing

                    '**************************** CARGAMOS LA FICHA ************************

                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiarficha")

                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Me.pbFoto_doc.Image
                    My.Forms.mdiOrthoSoft.txtId_ficha.Text = Me.txtIddoctor.Text
                    My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = Me.txtnombres_doc.Text & " " & Me.txtapellidos_doc.Text
                    'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Me.txtresidencia_doc.Text
                    My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = Me.txtCelular_doc.Text
                    My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = Me.txtTelCasa_doc.Text
                    My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = Me.txtemail_doc.Text

                    '**************************** Cargamos El Combo Doctores y el Estado **********************

                    CLASE_GENERAL.cargar_combo("doctores", My.Forms.mdiOrthoSoft.cmbDoctores, CLASE_GENERAL.mensaje_error)
                    My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue = Me.txtIddoctor.Text
                    My.Forms.mdiOrthoSoft.btnDocSeleccionar_Click(sender, e)

                    'Cargamos los Labels principales
                    My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = Me.txtnombres_doc.Text & " " & Me.txtapellidos_doc.Text
                    My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag = Me.txtIddoctor.Text

                    'Cargamos Id especial para Huellas
                    CLASE_GENERAL._Iddoctor_consec = Me.txtIddoctor.Text()


                    EVEN.bloquaerdesbloquear("editardoctor")
                    EVEN = Nothing

                    MsgBox("Doctor modificado con Exito", MsgBoxStyle.OkOnly, "Doctores")

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try
            End If
        End If


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea un Nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Doctores")

        If respuesta = 6 Then

            Try

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiardoctores")
                EVEN.limpiar("limpiarficha")
                EVEN.bloquaerdesbloquear("nuevodoctor")
                Me.txtIddoctor.Text = (CLASE_GENERAL.maximo("Iddoctor", "doctores", CLASE_GENERAL.mensaje_error)) + 1
                EVEN = Nothing

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar el Doctor", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pacientes")

        If respuesta = 6 Then

            Try

                DOC = New CLASE_DOCTORES
                CON = New CLASE_CONTACTOS
                NOTA = New CLASE_NOTAS
                EVEN = New CLASE_EVENTOS

                DOC.p_Iddoctor = Me.txtIddoctor.Text
                CON.p_IdUsuario = Me.txtIddoctor.Text
                CON.p_IdTUsuario = 2 ' Tipo Doctores
                NOTA.p_IdUsuario = Me.txtIddoctor.Text
                NOTA.p_IdTUsuario = 2 ' Tipo Doctor

                DOC.Eliminar(CLASE_GENERAL.mensaje_error)
                CON.Eliminar(CLASE_GENERAL.mensaje_error)
                NOTA.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN.limpiar("limpiarficha")
                EVEN.limpiar("limpiardoctores")
                EVEN.bloquaerdesbloquear("nuevodoctor")

                Me.txtIddoctor.Text = (CLASE_GENERAL.maximo("Iddoctor", "doctores", CLASE_GENERAL.mensaje_error)) + 1

                'Cargamos El Combo Doctores y el Estado

                CLASE_GENERAL.cargar_combo("doctores", My.Forms.mdiOrthoSoft.cmbDoctores, CLASE_GENERAL.mensaje_error)

                My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue = 1
                My.Forms.mdiOrthoSoft.btnDocSeleccionar_Click(sender, e)

                If My.Computer.FileSystem.FileExists(CLASE_GENERAL.rutaimagenes & NOTA.p_IdUsuario & "doc" & ".bmp") Then
                    My.Computer.FileSystem.DeleteFile(CLASE_GENERAL.rutaimagenes & NOTA.p_IdUsuario & "doc" & ".bmp")
                End If

                DOC.dispose()
                DOC = Nothing
                CON.dispose()
                CON = Nothing
                NOTA.dispose()
                NOTA = Nothing
                EVEN = Nothing

                MsgBox("Doctor Eliminado con Exito", MsgBoxStyle.OkOnly, "Doctores")


            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If
    End Sub

    Private Sub rbtAños_doc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAños_doc.CheckedChanged
        Me.lblNumaños.Text = DateDiff(DateInterval.Year, Me.cmbfecnac_doc.Value, Now())

    End Sub

    Private Sub rbtmeses_doc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtmeses_doc.CheckedChanged
        Me.lblNumaños.Text = DateDiff(DateInterval.Month, Me.cmbfecnac_doc.Value, Now())
    End Sub

    Private Sub cmbfecnac_doc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfecnac_doc.ValueChanged

        Me.ErrorProviderdoc.SetError(Me.cmbfecnac_doc, "")

        If Me.rbtAños_doc.Checked = True Then
            Me.lblNumaños.Text = DateDiff(DateInterval.Year, Me.cmbfecnac_doc.Value, Now())
        Else
            Me.lblNumaños.Text = DateDiff(DateInterval.Month, Me.cmbfecnac_doc.Value, Now())
        End If

    End Sub

    Private Sub frmDoctores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CLASE_GENERAL.formload = 2

        'Cargamos las Especialidades
        CLASE_GENERAL.cargar_combo("especialidades", Me.cmbespecialidades, CLASE_GENERAL.mensaje_error)
        Me.cmbespecialidades.SelectedValue = 1

    End Sub

    Private Sub btnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFoto.Click

        frmFotografia.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmFotografia.Show()
        frmFotografia.Activate()
        CLASE_GENERAL.formload = 2

    End Sub

    Private Sub btnFotoA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFotoA.Click

        Try

            'Me.OpenFileDialogPac.Filter = "Todos los Archivos (*.*)|*.*|Archivos BMP (*.bmp)|*.bmp|Iconos (*.ico)|*.ico|Archivos JPG (*.jpg)|*.jpg|Archivos JPEG (*.jpeg)|*.jpeg|Archivos GIF (*.gif)|*.gif"

            OpenFileDialogDoc = New OpenFileDialog
            OpenFileDialogDoc.Filter = "Imágenes JPG (*.jpg)|*.jpg|Mapas de bits (*.bmp)|*.bmp"
            OpenFileDialogDoc.Title = "Abre una imagen JPG o BMP"

            If OpenFileDialogDoc.ShowDialog() = DialogResult.OK Then

                nombreImg = OpenFileDialogDoc.FileName
                Me.pbFoto_doc.Image = Image.FromFile(nombreImg)
                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = Image.FromFile(nombreImg)
                Me.pbFoto_doc.SizeMode = PictureBoxSizeMode.Zoom

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub txtapellidos_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtapellidos_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtapellidos_doc, "")
    End Sub

    Private Sub txtnombres_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombres_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtnombres_doc, "")
    End Sub

    Private Sub txtresidencia_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtresidencia_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtresidencia_doc, "")
    End Sub

    Private Sub txtoficina_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoficina_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtoficina_doc, "")
    End Sub

    Private Sub txtnumdoc_doc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumdoc_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtnumdoc_doc, "")
    End Sub

    Private Sub txtTelCasa_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelCasa_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtTelCasa_doc, "")
    End Sub

    Private Sub txtTelOficina_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelOficina_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtTelOficina_doc, "")
    End Sub

    Private Sub txtCelular_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtCelular_doc, "")
    End Sub

    Private Sub cmbtipodoc_doc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipodoc_doc.SelectedIndexChanged
        Me.ErrorProviderdoc.SetError(Me.cmbtipodoc_doc, "")
    End Sub

    Private Sub txtemail_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail_doc.TextChanged
        Me.ErrorProviderdoc.SetError(Me.txtemail_doc, "")
    End Sub

    Private Sub btnNoEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEmail.Click
        Me.txtemail_doc.Text = "notiene@"
    End Sub

    Private Sub btnBorrarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarFoto.Click

        Me.pbFoto_doc.Image = My.Resources.fondodoctor

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
        ubicarcontrol(Me.pbFoto_doc)
        ubicarcontrol(Me.btnFotoA)
        ubicarcontrol(Me.btnBorrarFoto)
        ubicarcontrol(Me.btnFoto)

        ubicarcontrol(Me.lblapellidos_doc)
        ubicarcontrol(Me.txtapellidos_doc)
        ubicarcontrol(Me.txtnombres_doc)
        ubicarcontrol(Me.lblnombres_doc)
        ubicarcontrol(Me.txtresidencia_doc)
        ubicarcontrol(Me.lblresidencia_doc)
        ubicarcontrol(Me.txtoficina_doc)
        ubicarcontrol(Me.lbloficina_doc)
        ubicarcontrol(Me.cmbfecingreso_doc)
        ubicarcontrol(Me.lblfecingreso_doc)
        ubicarcontrol(Me.cmbfecnac_doc)
        ubicarcontrol(Me.lblfecnac_doc)
        ubicarcontrol(Me.cmbEspecialidades)
        ubicarcontrol(Me.lblEspecialidad_doc)
        ubicarcontrol(Me.cmbtipodoc_doc)
        ubicarcontrol(Me.lbltipodoc_doc)
        ubicarcontrol(Me.txtnumdoc_doc)
        ubicarcontrol(Me.lblnumdoc_doc)
        ubicarcontrol(Me.txtIddoctor)
        ubicarcontrol(Me.lblIddoctor)


        'Notas
        ubicarcontrol(Me.gpNotas)
        ubicarcontrol(Me.lblRegistroBiometrico)
        ubicarcontrol(Me.gpRegistroBiometrico)

        ubicarcontrol(Me.gpContactos)


        ubicarcontrol(Me.gPanel_Sexo)
        ubicarcontrol(Me.gPanel_Edad)

        'Botones
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmDoctores_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

    Private Sub cmbEspecialidades_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecialidades.TextChanged

        Me.ErrorProviderdoc.SetError(Me.cmbEspecialidades, "")

    End Sub

    Private Sub frmDoctores_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        ' Si la tecla pulsada es la tecla Intro ...

        If Not (ActiveControl.Name.ToString = "RichTxtNotas_doc") Then

            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                e.Handled = True
                SendKeys.Send(Convert.ToChar(Keys.Tab))
            End If

        End If

    End Sub

    Private Sub btnRegistroBiometrico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistroBiometrico.Click

        Try

            '*********** CREAMOS LOS ESPACIOS DE LAS HUELLAS INICIALES ******************

            CLASE_GENERAL._TipoUsuario = 2 'Tipo Doctor

            contar = 0
            contar = CLASE_GENERAL.contarhuellas(Me.txtIddoctor.Text, 2, CLASE_GENERAL.mensaje_error)

            If contar = 0 Then

                HUELLA = New CLASE_HUELLAS

                HUELLA.p_Idhuella = (CLASE_GENERAL.maximo("Idhuella", "huellas", CLASE_GENERAL.mensaje_error)) + 1
                HUELLA.p_IdUsuario = Me.txtIddoctor.Text
                HUELLA.p_IdTUsuario = 2 ' Tipo Doctor
                HUELLA.p_fechareg = Format(Date.Now, "yyyy-MM-dd")

                HUELLA.Insertar(CLASE_GENERAL.mensaje_error)

                HUELLA.dispose()
                HUELLA = Nothing

            Else

                '**************************** HUELLAS REGISTRADAS *************************************

                HUELLA = New CLASE_HUELLAS

                HUELLA.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                HUELLA.p_IdTUsuario = 2 'Tipo Doctor

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