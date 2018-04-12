Friend Class frmFotografia

    Private bmap As Bitmap
    Private data As IDataObject

    Private GENE As CLASE_GENERAL


    Private Sub frmFotografia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            capSetCallbackOnError(lwndC, VariantType.Null)
            capSetCallbackOnStatus(lwndC, VariantType.Null)
            capSetCallbackOnYield(lwndC, VariantType.Null)
            capSetCallbackOnFrame(lwndC, VariantType.Null)
            capSetCallbackOnVideoStream(lwndC, VariantType.Null)
            capSetCallbackOnWaveStream(lwndC, VariantType.Null)
            capSetCallbackOnCapControl(lwndC, VariantType.Null)

        Catch ex As Exception

            MsgBox("Existen Problemas al cerrar la Cámara", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try
    End Sub

    Private Sub frmCamara_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Try

            Dim lpszName As New Compatibility.VB6.FixedLengthString(100)
            Dim lpszVer As New Compatibility.VB6.FixedLengthString(100)


            capGetDriverDescriptionA(0, lpszName.Value, 100, lpszVer.Value, 100)
            lwndC = capCreateCaptureWindowA(lpszName.Value, WS_VISIBLE Or WS_CHILD, 35, 87, 230, 170, Me.Handle.ToInt32, 0)

            If capDriverConnect(lwndC, 0) Then
                capPreviewScale(lwndC, True)
                capPreviewRate(lwndC, 1)
                capPreview(lwndC, True)
            End If

        Catch ex As Exception

            MsgBox("No se puede iniciar la Cámara", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpciones.Click
        Try

            capDlgVideoSource(lwndC)

        Catch ex As Exception

            MsgBox("Existen Problemas con La Configuracion de la Cámara", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try
    End Sub

    Private Sub btnCapturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapturar.Click

        Try


            capEditCopy(lwndC)                  ' Llama a copiar la imagen al portapapeles
            data = Clipboard.GetDataObject()    ' Obtiene la imagen del portapapeles
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Bitmap) ' Lo comvierte a bmp

            Me.PictureBox.Image = bmap ' La copia
            Me.btnAceptar.Enabled = True


        Catch ex As Exception

            MsgBox("No se pude capturar Imagen de la Camara", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try

            GENE = New CLASE_GENERAL

            Select Case CLASE_GENERAL.formload 'Variable para controlar

                Case 1
                    My.Forms.frmPacientes.pbFoto_pac.Image = CType(GENE.comprimir_imagen(CType(Me.PictureBox.Image, Bitmap), 80), Image)
                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Forms.frmPacientes.pbFoto_pac.Image
                Case 2
                    My.Forms.frmDoctores.pbFoto_doc.Image = CType(GENE.comprimir_imagen(CType(Me.PictureBox.Image, Bitmap), 80), Image)
                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Forms.frmDoctores.pbFoto_doc.Image
                Case 3
                    My.Forms.frmUsuarios.pbFoto_emp.Image = CType(GENE.comprimir_imagen(CType(Me.PictureBox.Image, Bitmap), 80), Image)
                    My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Forms.frmUsuarios.pbFoto_emp.Image

            End Select

            GENE = Nothing
            Me.Dispose()
            Me.Close()

        Catch ex As Exception

            MsgBox("No se pueden Cargar las Imagenes", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

End Class
