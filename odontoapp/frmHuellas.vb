Imports System.Math

'Delegate Sub FunctionCall(ByVal param)

Public Class frmHuellas

    'Variables de Clases
    Private HUELLAS As CLASE_HUELLAS
    Private GENE As CLASE_GENERAL

    'variable de Imagen
    Private iImagen As Image

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnregistrarHuella_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrarHuella.Click

        'Display the new form.
        My.Forms.mdiOrthoSoft.VerificationControl.Active = False
        My.Forms.frmIngreso.VerificationControl.Active = False

        My.Forms.MainForm.StartPosition = FormStartPosition.CenterScreen
        My.Forms.MainForm.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Dim Enroller2 As New EnrollmentForm2()
        Enroller2.ShowDialog()


    End Sub

    Private Sub D1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 1

            If Me.D1.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If
                


                HUELLAS.Seleccionar("huella1")

                If Not (CLASE_HUELLAS.xhuella1_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella1_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing
                Me.btnregistrarHuella.Enabled = True

            End If


            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.Fixed3D
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle



        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 2

            If Me.D2.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella2")

                If Not (CLASE_HUELLAS.xhuella2_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella2_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.Fixed3D
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 3

            If Me.D3.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella3")

                If Not (CLASE_HUELLAS.xhuella3_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella3_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.Fixed3D
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 4

            If Me.D4.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella4")

                If Not (CLASE_HUELLAS.xhuella4_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella4_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.Fixed3D
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 5

            If Me.D5.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella5")

                If Not (CLASE_HUELLAS.xhuella5_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella5_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.Fixed3D
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 6

            If Me.D6.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella6")

                If Not (CLASE_HUELLAS.xhuella6_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella6_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.Fixed3D
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D7.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 7

            If Me.D7.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella7")

                If Not (CLASE_HUELLAS.xhuella7_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella7_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.Fixed3D
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D8.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 8

            If Me.D8.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella8")

                If Not (CLASE_HUELLAS.xhuella8_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella8_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.Fixed3D
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D9.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 9

            If Me.D9.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella9")

                If Not (CLASE_HUELLAS.xhuella9_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella9_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            'Colocamos o Undimos el boton

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.Fixed3D
            Me.D10.BorderStyle = BorderStyle.FixedSingle

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub D10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D10.Click

        Try

            CLASE_GENERAL._Iddedo_consec = 10

            If Me.D10.BackColor = Color.Lime Then

                HUELLAS = New CLASE_HUELLAS
                GENE = New CLASE_GENERAL

                If CLASE_GENERAL._TipoUsuario = 1 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    HUELLAS.p_IdTUsuario = 1 'Tipo Paciente

                ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                    HUELLAS.p_IdTUsuario = 2 'Tipo Doctor

                ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                    HUELLAS.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                    HUELLAS.p_IdTUsuario = 3 'Tipo Usuario

                End If

                HUELLAS.Seleccionar("huella10")

                If Not (CLASE_HUELLAS.xhuella10_reg.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_HUELLAS.xhuella10_reg)
                    Me.pbxHuella.Image = iImagen

                End If

                Me.lblEstadoHuella.Text = "REGISTRO"
                Me.btnregistrarHuella.Enabled = True


            Else

                Me.lblEstadoHuella.Text = "SIN REGISTRO"
                Me.pbxHuella.Image = Nothing

                Me.btnregistrarHuella.Enabled = True

            End If

            Me.D1.BorderStyle = BorderStyle.FixedSingle
            Me.D2.BorderStyle = BorderStyle.FixedSingle
            Me.D3.BorderStyle = BorderStyle.FixedSingle
            Me.D4.BorderStyle = BorderStyle.FixedSingle
            Me.D5.BorderStyle = BorderStyle.FixedSingle
            Me.D6.BorderStyle = BorderStyle.FixedSingle
            Me.D7.BorderStyle = BorderStyle.FixedSingle
            Me.D8.BorderStyle = BorderStyle.FixedSingle
            Me.D9.BorderStyle = BorderStyle.FixedSingle
            Me.D10.BorderStyle = BorderStyle.Fixed3D

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

        'Datos Iniciales
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpRegistro)
        ubicarcontrol(Me.gpHuella)
        ubicarcontrol(Me.btnSalir)


    End Sub

    Private Sub frmHuellas_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub



End Class