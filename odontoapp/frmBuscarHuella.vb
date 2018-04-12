Public Class frmBuscarHuella

    'Variable de Clases
    Public HUELLA As CLASE_HUELLAS

    'Creamos las Clases
    Private GENE As CLASE_GENERAL
    Private PAC As CLASE_PACIENTES
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS
    Private CITA As CLASE_CITAS
    Public EVEN As CLASE_EVENTOS

    'Varibles de control
    Private indice As String
    Private control As Boolean = False
    Private fecha As Date
    Private contar As Integer
    Private iniciando As Boolean = True
    Private bandera As Integer = 1
    Private Idpaciente As Integer

    ' Variables de las Huellas
    Public huellita1 As DPFP.Template
    Public huellita2 As DPFP.Template
    Public huellita3 As DPFP.Template
    Public huellita4 As DPFP.Template
    Public huellita5 As DPFP.Template
    Public huellita6 As DPFP.Template
    Public huellita7 As DPFP.Template
    Public huellita8 As DPFP.Template
    Public huellita9 As DPFP.Template
    Public huellita10 As DPFP.Template
    Public huellitaaux As DPFP.Template

    'Variables de templates
    Private Data As AppData
    Public WithEvents AppData As AppData


    'variable de Imagen
    Private iImagen As Image

    Private Sub OnDataChange()
        ExchangeData(False)
    End Sub

    Private Sub ExchangeData(ByVal read As Boolean)

        Data.EnrolledFingersMask = 0
        Data.MaxEnrollFingerCount = 10
        Data.IsEventHandlerSucceeds = True
        Data.Update()

    End Sub

    Private Sub VerificationControl_OnComplete(ByVal Control As Object, ByVal FeatureSet As DPFP.FeatureSet, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles VerificationControl.OnComplete

        Try

            'Verificamos Variables de Biometrico

            Dim ver As New DPFP.Verification.Verification()
            Dim res As New DPFP.Verification.Verification.Result()


            'Cargamos los Items para la busqueda

            HUELLA = New CLASE_HUELLAS
            HUELLA.p_IdTUsuario = 1 'Tipo Paciente
            HUELLA.Seleccionar("items")

            Dim i As Integer

            If CLASE_GENERAL.xdt2.Rows.Count > 0 Then

                For i = 0 To CLASE_GENERAL.xdt2.Rows.Count - 1

                    cargarhuellitas(CLASE_GENERAL.xdt2.Rows(i).Item("IdUsuario"))

                    For Each template As DPFP.Template In Data.Templates    ' Compare feature set with all stored templates:
                        If Not template Is Nothing Then                     '   Get template from storage.
                            ver.Verify(FeatureSet, template, res)           '   Compare feature set with particular template.
                            Data.IsFeatureSetMatched = res.Verified         '   Check the result of the comparison
                            Data.FalseAcceptRate = res.FARAchieved          '   Determine the current False Accept Rate
                            If res.Verified Then
                                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Success
                                Exit For ' success
                            End If
                        End If

                    Next

                    If Not res.Verified Then

                        EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
                        Data.Update()

                        Me.lblStatus.Text = "Paciente no tiene registro Biometrico ..."

                    Else

                        EVEN = New CLASE_EVENTOS
                        EVEN.cargarpacienteficha(CLASE_GENERAL.xdt2.Rows(i).Item("IdUsuario"))
                        EVEN = Nothing

                        HUELLA.dispose()
                        HUELLA = Nothing

                        Exit Sub

                    End If

                Next

            Else

                MessageBox.Show("No hay registros Biometicos de Pacientes", "Buscar Huella", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cargarhuellitas(ByVal Idusuario As Integer)

        Try

            ' ------------------ Inicializamos los Objetos de la BD ----------------------

            huellita1 = New DPFP.Template
            huellita2 = New DPFP.Template
            huellita3 = New DPFP.Template
            huellita4 = New DPFP.Template
            huellita5 = New DPFP.Template
            huellita6 = New DPFP.Template
            huellita7 = New DPFP.Template
            huellita8 = New DPFP.Template
            huellita9 = New DPFP.Template
            huellita10 = New DPFP.Template

            '------------------- Cargamos los Datos de la Cuenta ----------------

            Data = New AppData()

            HUELLA.p_IdUsuario = Idusuario
            HUELLA.p_IdTUsuario = 1 ' Tipo Paciente

            HUELLA.Seleccionar("todos")

            If Not (CLASE_HUELLAS.xhuella1 = "") Then

                huellita1.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella1))
                Data.Templates(0) = huellita1

            End If

            If Not (CLASE_HUELLAS.xhuella2 = "") Then

                huellita2.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella2))
                Data.Templates(1) = huellita2

            End If

            If Not (CLASE_HUELLAS.xhuella3 = "") Then

                huellita3.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella3))
                Data.Templates(2) = huellita3

            End If

            If Not (CLASE_HUELLAS.xhuella4 = "") Then

                huellita4.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella4))
                Data.Templates(3) = huellita4

            End If

            If Not (CLASE_HUELLAS.xhuella5 = "") Then

                huellita5.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella5))
                Data.Templates(4) = huellita5

            End If

            If Not (CLASE_HUELLAS.xhuella6 = "") Then

                huellita6.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella6))
                Data.Templates(5) = huellita6

            End If

            If Not (CLASE_HUELLAS.xhuella7 = "") Then

                huellita7.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella7))
                Data.Templates(6) = huellita7

            End If

            If Not (CLASE_HUELLAS.xhuella8 = "") Then

                huellita8.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella8))
                Data.Templates(7) = huellita8

            End If

            If Not (CLASE_HUELLAS.xhuella9 = "") Then

                huellita9.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella9))
                Data.Templates(8) = huellita9

            End If

            If Not (CLASE_HUELLAS.xhuella10 = "") Then

                huellita10.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella10))
                Data.Templates(9) = huellita10

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Shared Function StringToByteArray(ByVal hex As String) As Byte()

        Dim NumberChars As Integer = hex.Length
        Dim bytes As Byte() = New Byte(NumberChars / 2 - 1) {}
        For i As Integer = 0 To NumberChars - 1 Step 2
            bytes(i / 2) = Convert.ToByte(hex.Substring(i, 2), 16)
        Next
        Return (bytes)

    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

End Class