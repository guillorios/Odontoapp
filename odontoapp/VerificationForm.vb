' NOTE: This form is inherited from the CaptureForm,
' so the VisualStudio Form Designer may not load this properly
' (at least until you build the project).
' If you want to make changes in the form layout - do it in the base CaptureForm.
' All changes in the CaptureForm will be reflected in all derived forms 
' (i.e. in the EnrollmentForm and in the VerificationForm)

Public Class VerificationForm

    Inherits CaptureForm

    Public WithEvents AppData As AppData
    Public Data As AppData

    Private Template As DPFP.Template
    Private Verificator As DPFP.Verification.Verification

    'Variable de Clases
    Private PROCE As CLASE_PROCEDIMIENTO_DIARIO
    Private GENE As CLASE_GENERAL

    Public AUX() As Byte
    Public Shared PICTURE As PictureBox


    Public Sub Verify(ByVal template As DPFP.Template)
        Me.Template = template
        ShowDialog()
    End Sub

    Private Sub OnDataChange()
        ExchangeData(False)
    End Sub

    Private Sub ExchangeData(ByVal read As Boolean)

        Data.EnrolledFingersMask = 0
        Data.MaxEnrollFingerCount = 10
        Data.IsEventHandlerSucceeds = True
        Data.Update()

    End Sub

    Sub New(ByVal data As AppData)

        InitializeComponent()
        Me.Data = data

        data.EnrolledFingersMask = 0
        data.MaxEnrollFingerCount = 10
        data.IsEventHandlerSucceeds = True
        data.Update()

    End Sub

    Protected Overrides Sub Init()
        MyBase.Init()
        MyBase.Text = "Verificacion de Huellas"
        Verificator = New DPFP.Verification.Verification()
        UpdateStatus(0)
    End Sub

    Protected Overrides Sub Process(ByVal Sample As DPFP.Sample)

        MyBase.Process(Sample)

        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)
        Dim ver As New DPFP.Verification.Verification()
        Dim res As New DPFP.Verification.Verification.Result()

        For Each template As DPFP.Template In Data.Templates    ' Compare feature set with all stored templates:

            If Not template Is Nothing Then                     '   Get template from storage.
                ver.Verify(features, template, res)             '   Compare feature set with particular template.
                Data.IsFeatureSetMatched = res.Verified         '   Check the result of the comparison
                Data.FalseAcceptRate = res.FARAchieved          '   Determine the current False Accept Rate
                UpdateStatus(res.FARAchieved)

                If res.Verified Then

                    MakeReport("La Huella es VERIFICADA.")

                    PROCE = New CLASE_PROCEDIMIENTO_DIARIO
                    GENE = New CLASE_GENERAL

                    PROCE.p_Idproced = CLASE_GENERAL._Idprocedimiento

                    Dim convertor As New DPFP.Capture.SampleConversion()    ' Create a sample convertor.
                    Dim bitmap As Bitmap = Nothing
                    convertor.ConvertToPicture(Sample, bitmap)

                    If CLASE_GENERAL._TipoUsuario = 1 Then

                        PROCE.p_firmapaciente = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                        PROCE.Modificar("firmapaciente")

                        MessageBox.Show("El Paciente ha sido autenticado y la firma se realizo correctamente.", "Firma Huellas", MessageBoxButtons.OK, MessageBoxIcon.None)

                    ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                        PROCE.p_firmaodonto = GENE.Imagen_Bytes(CType(GENE.comprimir_imagen(bitmap, 150), Image))
                        PROCE.Modificar("firmaodontologo")

                        MessageBox.Show("El Doctor ha sido autenticado y la firma se realizo correctamente.", "Firma Huellas", MessageBoxButtons.OK, MessageBoxIcon.None)

                    End If


                    PROCE.dispose()
                    PROCE = Nothing

                    GENE = Nothing

                    Exit For ' success

                End If

            End If

        Next

        If Not res.Verified Then

            MakeReport("La Huella es NO VERIFICADA.")

            If CLASE_GENERAL._TipoUsuario = 1 Then

                MessageBox.Show("La firma no corresponde al Paciente, verifique por favor", "Firma Huellas", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

                MessageBox.Show("La firma no corresponde al Doctor, verifique por favor", "Firma Huellas", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
            
        End If

        Data.Update()

    End Sub

    Protected Sub UpdateStatus(ByVal FAR As Integer)
        ' Show "False accept rate" value
        SetStatus(String.Format("Tasa de falsa aceptación (FAR) = {0}", FAR))
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'VerificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(581, 354)
        Me.Name = "VerificationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub VerificationForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        My.Forms.mdiOrthoSoft.VerificationControl.Active = True
        My.Forms.frmIngreso.VerificationControl.Active = False


        If CLASE_GENERAL._TipoUsuario = 1 Then

            My.Forms.frmProcedimientoDiario.btnFirmaPaciente.Enabled = False
            My.Forms.frmProcedimientoDiario.formatorow()
            My.Forms.frmProcedimientoDiario.Activate()

        ElseIf CLASE_GENERAL._TipoUsuario = 2 Then

            My.Forms.frmProcedimientoDiario.btnFirmaOdonto.Enabled = False
            My.Forms.frmProcedimientoDiario.formatorow()
            My.Forms.frmProcedimientoDiario.Activate()

        End If

    End Sub

End Class
