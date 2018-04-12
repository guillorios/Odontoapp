Public Class MainForm

    Private Data As AppData
    Private Enroller As EnrollmentForm
    Private Verifier As VerificationForm

    Public WithEvents AppData As AppData

    Sub New()

        Try

            InitializeComponent()

            Data = New AppData()
            AddHandler Data.OnChange, AddressOf OnDataChange
            Enroller = New EnrollmentForm(Data)
            Verifier = New VerificationForm(Data)

            ExchangeData(False)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub OnDataChange()

        Try

            ExchangeData(False)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub ExchangeData(ByVal read As Boolean)

        Try

        
            If (read) Then
                If (Mask.Text.Length > 0) Then
                    Data.EnrolledFingersMask = Mask.Value
                Else
                    Data.EnrolledFingersMask = 0
                End If

                If (MaxFingers.Text.Length > 0) Then
                    Data.MaxEnrollFingerCount = MaxFingers.Value
                Else
                    Data.MaxEnrollFingerCount = 0
                End If

                Data.IsEventHandlerSucceeds = IsSuccess.Checked
                Data.Update()
            Else
                Mask.Value = Data.EnrolledFingersMask
                MaxFingers.Value = Data.MaxEnrollFingerCount
                IsSuccess.Checked = Data.IsEventHandlerSucceeds
                IsFailure.Checked = Not IsSuccess.Checked
                IsFeatureSetMatched.Checked = Data.IsFeatureSetMatched
                FalseAcceptRate.Text = Data.FalseAcceptRate.ToString()
                VerifyButton.Enabled = Data.EnrolledFingersMask > 0
            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

   
    Private Sub EnrollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrollButton.Click

        Try
            ExchangeData(True)
            Enroller.ShowDialog()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub VerifyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerifyButton.Click
        Try
            ExchangeData(True)
            Verifier.ShowDialog()
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class