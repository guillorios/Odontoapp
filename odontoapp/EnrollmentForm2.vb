' NOTE: This form is inherited from the CaptureForm,
' so the VisualStudio Form Designer may not load this properly
' (at least until you build the project).
' If you want to make changes in the form layout - do it in the base CaptureForm.
' All changes in the CaptureForm will be reflected in all derived forms 
' (i.e. in the EnrollmentForm and in the VerificationForm)
Imports System.Text

Public Class EnrollmentForm2

    Inherits CaptureForm
    Public Event OnTemplate(ByVal template)

    Private Enroller As DPFP.Processing.Enrollment
    Private Template As DPFP.Template

    Private HUELLA As CLASE_HUELLAS
    Private GENE As CLASE_GENERAL

    Public AUX() As Byte
    Public Shared PICTURE As PictureBox

    Protected Overrides Sub Init()

        MyBase.Init()
        MyBase.Text = "Inclusión de huellas digitales"
        Enroller = New DPFP.Processing.Enrollment()         ' Create an enrollment.
        UpdateStatus()

    End Sub

    Protected Overrides Sub Process(ByVal Sample As DPFP.Sample)

        MyBase.Process(Sample)

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)

        ' Check quality of the sample and add to enroller if it's good
        If (Not features Is Nothing) Then

            Try

                MakeReport("El conjunto de características de huellas dactilares se creó.")
                Enroller.AddFeatures(features)

                ' Add feature set to template.

            Catch ex As DPFP.Error.SDKException

                MakeReport("Error en la captura de los registros dactilares.")

            Finally

                UpdateStatus()

                ' Check if template has been created.
                Select Case Enroller.TemplateStatus

                    Case DPFP.Processing.Enrollment.Status.Ready' Report success and stop capturing
                        RaiseEvent OnTemplate(Enroller.Template)

                        HUELLA = New CLASE_HUELLAS
                        GENE = New CLASE_GENERAL

                        If CLASE_GENERAL._TipoUsuario = 1 Then

                            HUELLA.p_IdUsuario = CLASE_GENERAL._Idpaciente_consec
                            HUELLA.p_IdTUsuario = 1 'Tipo Paciente

                        ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                            HUELLA.p_IdUsuario = CLASE_GENERAL._Iddoctor_consec
                            HUELLA.p_IdTUsuario = 2 'Tipo Doctor

                        ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                            HUELLA.p_IdUsuario = CLASE_GENERAL._Idempleado_consec
                            HUELLA.p_IdTUsuario = 3 'Tipo Usuario

                        End If


                        Dim finger As Integer = CLASE_GENERAL._Iddedo_consec

                        Select Case finger

                            Case 1

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella1 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella1_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella1")

                            Case 2

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella2 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella2_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella2")

                            Case 3

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella3 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella3_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella3")

                            Case 4

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella4 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella4_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella4")

                            Case 5

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella5 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella5_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella5")

                            Case 6

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella6 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella6_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella6")

                            Case 7

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella7 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella7_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella7")


                            Case 8

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella8 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella8_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella8")


                            Case 9

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella9 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella9_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella9")

                            Case 10

                                Enroller.Template.Serialize(AUX)
                                HUELLA.p_huella10 = ByteArrayToString(AUX)

                                Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                                Dim bitmap As Bitmap = Nothing
                                convertor.ConvertToPicture(Sample, bitmap)
                                HUELLA.p_huella10_reg = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                                HUELLA.Modificar("huella10")

                                My.Forms.frmHuellas.pbxHuella.Image = CType(GENE.comprimir_imagen(bitmap, 150), Image)

                        End Select

                        HUELLA.dispose()
                        HUELLA = Nothing

                        GENE = Nothing

                        SetPrompt("Haga clic en Cerrar y, a continuación, haga clic verificación de huellas dactilares.")
                        MessageBox.Show("La huella ha sido registrada con Exito.", "Registro Huellas", MessageBoxButtons.OK, MessageBoxIcon.None)
                        StopCapture()


                    Case DPFP.Processing.Enrollment.Status.Failed       ' Report failure and restart capturing
                        Enroller.Clear()
                        StopCapture()
                        RaiseEvent OnTemplate(Nothing)
                        StartCapture()

                End Select
            End Try
        End If
    End Sub

    Protected Sub UpdateStatus()
        ' Show number of samples needed.
        SetStatus(String.Format("Muestras de huellas dactilares necesarios: {0}", Enroller.FeaturesNeeded))
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'EnrollmentForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(581, 354)
        Me.Name = "EnrollmentForm2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Shared Function ByteArrayToString(ByVal ba As Byte()) As String

        Dim hex As New StringBuilder(ba.Length * 2)
        For Each b As Byte In ba
            hex.AppendFormat("{0:x2}", b)
        Next
        Return hex.ToString()

    End Function

    Private Sub EnrollmentForm2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try

            HUELLA = New CLASE_HUELLAS
            GENE = New CLASE_GENERAL

            If CLASE_GENERAL._TipoUsuario = 1 Then

                HUELLA.p_IdUsuario = CLASE_GENERAL._Idpaciente_consec
                HUELLA.p_IdTUsuario = 1 'Tipo Paciente

            ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                HUELLA.p_IdUsuario = CLASE_GENERAL._Iddoctor_consec
                HUELLA.p_IdTUsuario = 2 'Tipo Doctor

            ElseIf CLASE_GENERAL._TipoUsuario = 3 Then

                HUELLA.p_IdUsuario = CLASE_GENERAL._Idempleado_consec
                HUELLA.p_IdTUsuario = 3 'Tipo Usuario

            End If

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

            GENE = Nothing

            My.Forms.mdiOrthoSoft.VerificationControl.Active = True
            My.Forms.frmIngreso.VerificationControl.Active = False

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

End Class
