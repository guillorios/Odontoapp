Imports System.Math
Imports System.IO

Public Class frmEstudios

    'Variables de Clases
    Private GENE As CLASE_GENERAL
    Private IMAGENES As CLASE_IMAGENES
    Private GALERIA As CLASE_GALERIA

    'Variables de Imagen
    Private nombreImg As String = ""
    Private tabcontrol As Integer = 0
    Private picturecontrol As Integer = 0

    'Variables de tipo de archivo
    Private iImagen As Image
    Private bImagen As Bitmap
    Private fImagen As Bitmap
    Private bmap As Bitmap

    'Variable para el fondo blanco de la composicion
    Private imagenfondo As Bitmap

    'Variables de control
    Private g As Graphics
    Private contar As Integer
    Private ruta As String

    Private Sub formatografico(ByRef imagen As Bitmap)

        'Con esta rutina logramos realizar los cuadrados blancos

        Dim rectangulo As Rectangle = New Rectangle(0, 0, 508, 405)
        Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

        Dim g As Graphics = Graphics.FromImage(imagenfinal)

        imagenfondo = New Bitmap(My.Resources.fondoplantilla)
        g.DrawImage(imagenfondo, 0, 0, 550, 408)

        bImagen = New Bitmap(imagen)
        g.DrawImage(bImagen, 0, 0, 550, 408)

        fImagen = imagenfinal

        g.Dispose()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    'Mover la barra de desplazamiento vertical

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        'entero para almacenar el valor de la barra de desplazamiento
        Dim imgZoom As Single = VScrollBar1.Value

        'para que solamente lo haga si hay imagen en la caja de imagen
        If Not pbxImg1.Image Is Nothing Then
            'código para que la caja de imagen sea redimensionada
            'manteniendo el modo de colocación de la imagen: centrada o ajustada
            If (pbxImg1.SizeMode = PictureBoxSizeMode.Zoom) Then
                pbxImg1.Width = (449 * imgZoom) \ 100
                pbxImg1.Height = (330 * imgZoom) \ 100
            End If

            If (pbxImg1.SizeMode = PictureBoxSizeMode.Normal) Then
                pbxImg1.Width = (449 * imgZoom) / 100
                pbxImg1.Height = (330 * imgZoom) / 100
            End If
        End If

        'Recarga la imagen
        pbxImg1.Refresh()

    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try

            GENE = New CLASE_GENERAL
            IMAGENES = New CLASE_IMAGENES
            GALERIA = New CLASE_GALERIA

            IMAGENES.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            IMAGENES.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
            GALERIA.p_IdImagen = Me.cmbGaleria.SelectedValue

            If Not Me.pbxImg1.Image Is Nothing Then

                IMAGENES.p_Iiniciales = GENE.Imagen_Bytes(Me.pbxImg1.Image)
                Me.btnBorrar1.Enabled = True

            End If

            If Not Me.pbxImg3.Image Is Nothing Then

                IMAGENES.p_Ifinales = GENE.Imagen_Bytes(Me.pbxImg3.Image)
                Me.btnBorrar3.Enabled = True

            End If

            If Not Me.pbxImgEv1.Image Is Nothing Then

                IMAGENES.p_Ievolucion1 = GENE.Imagen_Bytes(Me.pbxImgEv1.Image)
                Me.btnBorrarEv.Enabled = True

            End If

            If Not Me.pbxImgEv2.Image Is Nothing Then

                IMAGENES.p_Ievolucion2 = GENE.Imagen_Bytes(Me.pbxImgEv2.Image)
                Me.btnBorrarEv.Enabled = True

            End If

            If Not Me.pbxImgEv3.Image Is Nothing Then

                IMAGENES.p_Ievolucion3 = GENE.Imagen_Bytes(Me.pbxImgEv3.Image)
                Me.btnBorrarEv.Enabled = True

            End If

            If Not Me.pbxImgR0.Image Is Nothing Then

                IMAGENES.p_IR0 = GENE.Imagen_Bytes(Me.pbxImgR0.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR1.Image Is Nothing Then

                IMAGENES.p_IR1 = GENE.Imagen_Bytes(Me.pbxImgR1.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR2.Image Is Nothing Then

                IMAGENES.p_IR2 = GENE.Imagen_Bytes(Me.pbxImgR2.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR3.Image Is Nothing Then

                IMAGENES.p_IR3 = GENE.Imagen_Bytes(Me.pbxImgR3.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR4.Image Is Nothing Then

                IMAGENES.p_IR4 = GENE.Imagen_Bytes(Me.pbxImgR4.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR5.Image Is Nothing Then

                IMAGENES.p_IR5 = GENE.Imagen_Bytes(Me.pbxImgR5.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR6.Image Is Nothing Then

                IMAGENES.p_IR6 = GENE.Imagen_Bytes(Me.pbxImgR6.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR7.Image Is Nothing Then

                IMAGENES.p_IR7 = GENE.Imagen_Bytes(Me.pbxImgR7.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR8.Image Is Nothing Then

                IMAGENES.p_IR8 = GENE.Imagen_Bytes(Me.pbxImgR8.Image)
                Me.btnBorrarR.Enabled = True

            End If

            If Not Me.pbxImgR9.Image Is Nothing Then

                IMAGENES.p_IR9 = GENE.Imagen_Bytes(Me.pbxImgR9.Image)
                Me.btnBorrarR.Enabled = True

            End If


            If Not Me.pbxGaleria.Image Is Nothing Then

                GALERIA.p_Imagen_img = GENE.Imagen_Bytes(Me.pbxGaleria.Image)
                Me.btnBorrarGaleria.Enabled = True

            End If

            contar = 0
            contar = CLASE_GENERAL.contarimagenes(My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, 1, CLASE_GENERAL.mensaje_error)

            If contar > 0 Then

                IMAGENES.Modificar("estudios")

                If Not (Me.cmbGaleria.Items.Count = 0) Then

                    GALERIA.Modificar("imagen")

                End If

            Else

                IMAGENES.Insertar(CLASE_GENERAL.mensaje_error)

            End If



            IMAGENES.dispose()
            IMAGENES = Nothing

            GALERIA.dispose()
            GALERIA = Nothing

            GENE = Nothing

            MsgBox("Registro Guardado con Exito", MsgBoxStyle.OkOnly, "Estudios")


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar1.Click

        pbxImg1.Image = Nothing
        Me.btnBorrar1.Enabled = False

    End Sub

    Private Sub cargargaleria()

        Try

            If Not (Me.cmbGaleria.Items.Count = 0) Then


                GENE = New CLASE_GENERAL
                GALERIA = New CLASE_GALERIA
                GALERIA.p_IdImagen = Me.cmbGaleria.SelectedValue
                GALERIA.Seleccionar("galeria")

                If Not (CLASE_GALERIA.xImagen_img.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_GALERIA.xImagen_img)
                    Me.pbxGaleria.Image = iImagen
                    Me.pbxGaleria.SizeMode = PictureBoxSizeMode.Zoom

                    VScrollBarGaleria.Enabled = True
                    Me.btnBorrarGaleria.Enabled = True

                Else

                    pbxGaleria.Image = Nothing
                    Me.btnBorrarGaleria.Enabled = False

                End If

                GALERIA.dispose()
                GALERIA = Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub frmEstudios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            tabcontrol = 1

            Me.cmbTipoRadiografia.SelectedIndex = 0

            GENE = New CLASE_GENERAL
            IMAGENES = New CLASE_IMAGENES

            IMAGENES.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            IMAGENES.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente

            IMAGENES.Seleccionar("estudios")

            ' REGISTRO PARA FOTOS INICIALES

            If Not (CLASE_IMAGENES.xIiniciales.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIiniciales)
                Me.pbxImg1.Image = iImagen
                Me.pbxImg1.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBar1.Enabled = True
                Me.btnBorrar1.Enabled = True

            Else

                Me.btnBorrar1.Enabled = False

            End If

            ' REGISTRO PARA FOTOS FINALES

            If Not (CLASE_IMAGENES.xIfinales.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIfinales)
                Me.pbxImg3.Image = iImagen
                Me.pbxImg3.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBar3.Enabled = True
                Me.btnBorrar3.Enabled = True

            Else

                Me.btnBorrar3.Enabled = False

            End If

            ' REGISTRO PARA FOTOS EVOLUCION 1

            If Not (CLASE_IMAGENES.xIevolucion1.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIevolucion1)
                Me.pbxImgEv1.Image = iImagen
                Me.pbxImgEv1.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarEv.Enabled = True
                Me.btnBorrarEv.Enabled = True

            Else

                Me.btnBorrarEv.Enabled = False

            End If

            ' REGISTRO PARA FOTOS EVOLUCION 2

            If Not (CLASE_IMAGENES.xIevolucion2.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIevolucion2)
                Me.pbxImgEv2.Image = iImagen
                Me.pbxImgEv2.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarEv.Enabled = True
                Me.btnBorrarEv.Enabled = True

            Else

                Me.btnBorrarEv.Enabled = False

            End If

            ' REGISTRO PARA FOTOS EVOLUCION 3

            If Not (CLASE_IMAGENES.xIevolucion3.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIevolucion3)
                Me.pbxImgEv3.Image = iImagen
                Me.pbxImgEv3.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarEv.Enabled = True
                Me.btnBorrarEv.Enabled = True

            Else

                Me.btnBorrarEv.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 0

            If Not (CLASE_IMAGENES.xIR0.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR0)
                Me.pbxImgR0.Image = iImagen
                Me.pbxImgR0.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 1

            If Not (CLASE_IMAGENES.xIR1.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR1)
                Me.pbxImgR1.Image = iImagen
                Me.pbxImgR1.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 2

            If Not (CLASE_IMAGENES.xIR2.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR2)
                Me.pbxImgR2.Image = iImagen
                Me.pbxImgR2.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If


            ' REGISTRO PARA FOTOS RADIOGRAFIAS 3

            If Not (CLASE_IMAGENES.xIR3.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR3)
                Me.pbxImgR3.Image = iImagen
                Me.pbxImgR3.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 4

            If Not (CLASE_IMAGENES.xIR4.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR4)
                Me.pbxImgR4.Image = iImagen
                Me.pbxImgR4.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 5

            If Not (CLASE_IMAGENES.xIR5.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR5)
                Me.pbxImgR5.Image = iImagen
                Me.pbxImgR5.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 6

            If Not (CLASE_IMAGENES.xIR6.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR6)
                Me.pbxImgR6.Image = iImagen
                Me.pbxImgR6.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 7

            If Not (CLASE_IMAGENES.xIR7.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR7)
                Me.pbxImgR7.Image = iImagen
                Me.pbxImgR7.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 8

            If Not (CLASE_IMAGENES.xIR8.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR8)
                Me.pbxImgR8.Image = iImagen
                Me.pbxImgR8.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO PARA FOTOS RADIOGRAFIAS 9

            If Not (CLASE_IMAGENES.xIR9.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_IMAGENES.xIR9)

                Me.pbxImgR9.Image = iImagen
                Me.pbxImgR9.SizeMode = PictureBoxSizeMode.Zoom

                VScrollBarR.Enabled = True
                Me.btnBorrarR.Enabled = True

            Else

                Me.btnBorrarR.Enabled = False

            End If

            ' REGISTRO pARA LA GALERIA

            CLASE_GENERAL.cargar_combo("galeria", Me.cmbGaleria, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
            cargargaleria()

            'Drag Drop Pictures

            pbxImg1.AllowDrop = True

            pbxImgEv1.AllowDrop = True
            pbxImgEv2.AllowDrop = True
            pbxImgEv3.AllowDrop = True

            pbxImg3.AllowDrop = True

            pbxImgR0.AllowDrop = True
            pbxImgR1.AllowDrop = True
            pbxImgR2.AllowDrop = True
            pbxImgR3.AllowDrop = True
            pbxImgR4.AllowDrop = True
            pbxImgR5.AllowDrop = True
            pbxImgR6.AllowDrop = True
            pbxImgR7.AllowDrop = True
            pbxImgR8.AllowDrop = True
            pbxImgR9.AllowDrop = True

            pbxGaleria.AllowDrop = True

            IMAGENES.dispose()
            IMAGENES = Nothing

            GENE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub tabFEvolucion_pac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabFEvolucion_pac.Click

        rbEvolucion1_Click(sender, e)
        rbEvolucion1.Checked = True

    End Sub

    Private Sub btnBorrar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar3.Click

        pbxImg3.Image = Nothing
        Me.btnBorrar3.Enabled = False

    End Sub

    Private Sub rbEvolucion1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEvolucion1.Click

        Me.pbxImgEv1.Visible = True
        Me.pbxImgEv2.Visible = False
        Me.pbxImgEv3.Visible = False

        If Me.pbxImgEv1.Image Is Nothing Then

            Me.btnBorrarEv.Enabled = False

        Else

            Me.btnBorrarEv.Enabled = True

        End If

    End Sub

    Private Sub rbEvolucion2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEvolucion2.Click

        Me.pbxImgEv2.Visible = True
        Me.pbxImgEv1.Visible = False
        Me.pbxImgEv3.Visible = False

        If Me.pbxImgEv2.Image Is Nothing Then

            Me.btnBorrarEv.Enabled = False

        Else

            Me.btnBorrarEv.Enabled = True

        End If

    End Sub

    Private Sub rbEvolucion3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbEvolucion3.Click

        Me.pbxImgEv3.Visible = True
        Me.pbxImgEv2.Visible = False
        Me.pbxImgEv1.Visible = False

        If Me.pbxImgEv3.Image Is Nothing Then

            Me.btnBorrarEv.Enabled = False

        Else

            Me.btnBorrarEv.Enabled = True

        End If

    End Sub

    Private Sub btnBorrarEv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrarEv.Click

        If Me.rbEvolucion1.Checked = True Then

            pbxImgEv1.Image = Nothing
            Me.btnBorrarEv.Enabled = False

        ElseIf Me.rbEvolucion2.Checked = True Then

            pbxImgEv2.Image = Nothing
            Me.btnBorrarEv.Enabled = False

        ElseIf Me.rbEvolucion3.Checked = True Then

            pbxImgEv3.Image = Nothing
            Me.btnBorrarEv.Enabled = False

        End If


    End Sub

    Private Sub VScrollBar3_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar3.Scroll

        'entero para almacenar el valor de la barra de desplazamiento
        Dim imgZoom As Single = VScrollBar3.Value

        'para que solamente lo haga si hay imagen en la caja de imagen
        If Not pbxImg3.Image Is Nothing Then
            'código para que la caja de imagen sea redimensionada
            'manteniendo el modo de colocación de la imagen: centrada o ajustada
            If (pbxImg3.SizeMode = PictureBoxSizeMode.Zoom) Then
                pbxImg3.Width = (449 * imgZoom) \ 100
                pbxImg3.Height = (330 * imgZoom) \ 100
            End If

            If (pbxImg3.SizeMode = PictureBoxSizeMode.Normal) Then
                pbxImg3.Width = (449 * imgZoom) / 100
                pbxImg3.Height = (330 * imgZoom) / 100
            End If
        End If

        'Recarga la imagen
        pbxImg3.Refresh()

    End Sub

    Private Sub VScrollBarEv_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBarEv.Scroll


        If Me.rbEvolucion1.Checked = True Then

            'entero para almacenar el valor de la barra de desplazamiento
            Dim imgZoom As Single = VScrollBarEv.Value

            'para que solamente lo haga si hay imagen en la caja de imagen
            If Not pbxImgEv1.Image Is Nothing Then
                'código para que la caja de imagen sea redimensionada
                'manteniendo el modo de colocación de la imagen: centrada o ajustada
                If (pbxImgEv1.SizeMode = PictureBoxSizeMode.Zoom) Then
                    pbxImgEv1.Width = (449 * imgZoom) \ 100
                    pbxImgEv1.Height = (330 * imgZoom) \ 100
                End If

                If (pbxImgEv1.SizeMode = PictureBoxSizeMode.Normal) Then
                    pbxImgEv1.Width = (449 * imgZoom) / 100
                    pbxImgEv1.Height = (330 * imgZoom) / 100
                End If
            End If

            'Recarga la imagen
            pbxImgEv1.Refresh()

        ElseIf Me.rbEvolucion2.Checked = True Then

            'entero para almacenar el valor de la barra de desplazamiento
            Dim imgZoom As Single = VScrollBarEv.Value

            'para que solamente lo haga si hay imagen en la caja de imagen
            If Not pbxImgEv2.Image Is Nothing Then
                'código para que la caja de imagen sea redimensionada
                'manteniendo el modo de colocación de la imagen: centrada o ajustada
                If (pbxImgEv2.SizeMode = PictureBoxSizeMode.Zoom) Then
                    pbxImgEv2.Width = (449 * imgZoom) \ 100
                    pbxImgEv2.Height = (330 * imgZoom) \ 100
                End If

                If (pbxImgEv2.SizeMode = PictureBoxSizeMode.Normal) Then
                    pbxImgEv2.Width = (449 * imgZoom) / 100
                    pbxImgEv2.Height = (330 * imgZoom) / 100
                End If
            End If

            'Recarga la imagen
            pbxImgEv2.Refresh()

        ElseIf Me.rbEvolucion3.Checked = True Then

            'entero para almacenar el valor de la barra de desplazamiento
            Dim imgZoom As Single = VScrollBarEv.Value

            'para que solamente lo haga si hay imagen en la caja de imagen
            If Not pbxImgEv3.Image Is Nothing Then
                'código para que la caja de imagen sea redimensionada
                'manteniendo el modo de colocación de la imagen: centrada o ajustada
                If (pbxImgEv3.SizeMode = PictureBoxSizeMode.Zoom) Then
                    pbxImgEv3.Width = (449 * imgZoom) \ 100
                    pbxImgEv3.Height = (330 * imgZoom) \ 100
                End If

                If (pbxImgEv3.SizeMode = PictureBoxSizeMode.Normal) Then
                    pbxImgEv3.Width = (449 * imgZoom) / 100
                    pbxImgEv3.Height = (330 * imgZoom) / 100
                End If
            End If

            'Recarga la imagen
            pbxImgEv3.Refresh()

        End If

    End Sub

    Private Sub VScrollBarR_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBarR.Scroll

        Select Case Me.cmbTipoRadiografia.SelectedIndex

            Case 0

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR0.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR0.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR0.Width = (449 * imgZoom) \ 100
                        pbxImgR0.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR0.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR0.Width = (449 * imgZoom) / 100
                        pbxImgR0.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR0.Refresh()

            Case 1

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR1.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR1.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR1.Width = (449 * imgZoom) \ 100
                        pbxImgR1.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR1.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR1.Width = (449 * imgZoom) / 100
                        pbxImgR1.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR1.Refresh()

            Case 2

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR2.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR2.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR2.Width = (449 * imgZoom) \ 100
                        pbxImgR2.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR2.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR2.Width = (449 * imgZoom) / 100
                        pbxImgR2.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR2.Refresh()

            Case 3

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR3.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR3.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR3.Width = (449 * imgZoom) \ 100
                        pbxImgR3.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR3.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR3.Width = (449 * imgZoom) / 100
                        pbxImgR3.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR3.Refresh()


            Case 4

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR4.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR4.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR4.Width = (449 * imgZoom) \ 100
                        pbxImgR4.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR4.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR4.Width = (449 * imgZoom) / 100
                        pbxImgR4.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR4.Refresh()

            Case 5

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR5.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR5.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR5.Width = (449 * imgZoom) \ 100
                        pbxImgR5.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR5.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR5.Width = (449 * imgZoom) / 100
                        pbxImgR5.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR5.Refresh()

            Case 6

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR6.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR6.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR6.Width = (449 * imgZoom) \ 100
                        pbxImgR6.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR6.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR6.Width = (449 * imgZoom) / 100
                        pbxImgR6.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR6.Refresh()

            Case 7

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR7.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR7.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR7.Width = (449 * imgZoom) \ 100
                        pbxImgR7.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR7.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR7.Width = (449 * imgZoom) / 100
                        pbxImgR7.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR7.Refresh()

            Case 8

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR8.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR8.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR8.Width = (449 * imgZoom) \ 100
                        pbxImgR8.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR8.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR8.Width = (449 * imgZoom) / 100
                        pbxImgR8.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR8.Refresh()

            Case 9

                'entero para almacenar el valor de la barra de desplazamiento
                Dim imgZoom As Single = VScrollBarR.Value

                'para que solamente lo haga si hay imagen en la caja de imagen
                If Not pbxImgR9.Image Is Nothing Then
                    'código para que la caja de imagen sea redimensionada
                    'manteniendo el modo de colocación de la imagen: centrada o ajustada
                    If (pbxImgR9.SizeMode = PictureBoxSizeMode.Zoom) Then
                        pbxImgR9.Width = (449 * imgZoom) \ 100
                        pbxImgR9.Height = (330 * imgZoom) \ 100
                    End If

                    If (pbxImgR9.SizeMode = PictureBoxSizeMode.Normal) Then
                        pbxImgR9.Width = (449 * imgZoom) / 100
                        pbxImgR9.Height = (330 * imgZoom) / 100
                    End If
                End If

                'Recarga la imagen
                pbxImgR9.Refresh()

        End Select

    End Sub

    Private Sub btnBorrarR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrarR.Click

        Select Case Me.cmbTipoRadiografia.SelectedIndex

            Case 0

                pbxImgR0.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 1

                pbxImgR1.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 2

                pbxImgR2.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 3

                pbxImgR3.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 4

                pbxImgR4.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 5

                pbxImgR5.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 6

                pbxImgR6.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 7

                pbxImgR7.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 8

                pbxImgR8.Image = Nothing
                Me.btnBorrarR.Enabled = False

            Case 9

                pbxImgR9.Image = Nothing
                Me.btnBorrarR.Enabled = False

        End Select

    End Sub

    Private Sub cmbTipoRadiografia_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoRadiografia.SelectionChangeCommitted

        Select Case Me.cmbTipoRadiografia.SelectedIndex

            Case 0

                pbxImgR0.Visible = True
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR0.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 1

                pbxImgR0.Visible = False
                pbxImgR1.Visible = True
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR1.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 2

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = True
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR2.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 3

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = True
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR3.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 4

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = True
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR4.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 5

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = True
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR5.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 6

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = True
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR6.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 7

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = True
                pbxImgR8.Visible = False
                pbxImgR9.Visible = False

                If Me.pbxImgR7.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 8

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = True
                pbxImgR9.Visible = False

                If Me.pbxImgR8.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If

            Case 9

                pbxImgR0.Visible = False
                pbxImgR1.Visible = False
                pbxImgR2.Visible = False
                pbxImgR3.Visible = False
                pbxImgR4.Visible = False
                pbxImgR5.Visible = False
                pbxImgR6.Visible = False
                pbxImgR7.Visible = False
                pbxImgR8.Visible = False
                pbxImgR9.Visible = True

                If Me.pbxImgR9.Image Is Nothing Then

                    Me.btnBorrarR.Enabled = False

                Else

                    Me.btnBorrarR.Enabled = True

                End If


        End Select

    End Sub

    Private Sub btnComposicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComposicion.Click

        frmComposicion.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmComposicion.Show()
        frmComposicion.Activate()

        CLASE_GENERAL.formload = 11

    End Sub


    Private Sub btnComposicion2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComposicion2.Click

        frmComposicion.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmComposicion.Show()
        frmComposicion.Activate()

        If Me.rbEvolucion1.Checked = True Then

            CLASE_GENERAL.formload = 12

        ElseIf Me.rbEvolucion2.Checked = True Then

            CLASE_GENERAL.formload = 13

        ElseIf Me.rbEvolucion3.Checked = True Then

            CLASE_GENERAL.formload = 14

        End If


    End Sub

    Private Sub btnComposicion3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComposicion3.Click

        frmComposicion.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmComposicion.Show()
        frmComposicion.Activate()

        CLASE_GENERAL.formload = 15


    End Sub

    Private Sub pbxImg1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImg1.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImg1.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImg1.Image = fImagen
            pbxImg1.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBar1.Enabled = True

        End If


    End Sub


    Private Sub pbxImg1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImg1.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub btnAbrirExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirExplorer.Click

        Process.Start("explorer.exe", "/n,::{20D04FE0-3AEA-1069-A2D8-08002B30309D}")
        'My.Forms.frmExplorer.Show()

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
        ubicarcontrol(Me.lblFotosIniciales)
        ubicarcontrol(Me.pbxImg1)
        ubicarcontrol(Me.VScrollBar1)
        ubicarcontrol(Me.btnBorrar1)
        ubicarcontrol(Me.btnComposicion)
        ubicarcontrol(Me.btnAbrirExplorer)
        ubicarcontrol(Me.btnGuardar)
        ubicarcontrol(Me.btnSalir)

        'Fotografias Iniciales
        ubicarcontrol(Me.lblFotografiasEvolucion)
        ubicarcontrol(Me.gpEvolucionPaciente)
        ubicarcontrol(Me.btnComposicion2)
        ubicarcontrol(Me.pbxImgEv1)
        ubicarcontrol(Me.pbxImgEv2)
        ubicarcontrol(Me.pbxImgEv3)
        ubicarcontrol(Me.VScrollBarEv)
        ubicarcontrol(Me.btnBorrarEv)

        'Fotografias Finales
        ubicarcontrol(Me.pbxImg3)
        ubicarcontrol(Me.lblFotografiasFinales)
        ubicarcontrol(Me.VScrollBar3)
        ubicarcontrol(Me.btnBorrar3)
        ubicarcontrol(Me.btnComposicion3)

        'Radiografias
        ubicarcontrol(Me.lblRadiografias)
        ubicarcontrol(Me.gpTipoRadiografias)
        ubicarcontrol(Me.VScrollBarR)
        ubicarcontrol(Me.btnBorrarR)
        ubicarcontrol(Me.pbxImgR0)
        ubicarcontrol(Me.pbxImgR1)
        ubicarcontrol(Me.pbxImgR2)
        ubicarcontrol(Me.pbxImgR3)
        ubicarcontrol(Me.pbxImgR4)
        ubicarcontrol(Me.pbxImgR5)
        ubicarcontrol(Me.pbxImgR6)
        ubicarcontrol(Me.pbxImgR7)
        ubicarcontrol(Me.pbxImgR8)
        ubicarcontrol(Me.pbxImgR9)

        'Galeria

        ubicarcontrol(Me.lblGaleria)
        ubicarcontrol(Me.gpGaleria)
        ubicarcontrol(Me.pbxGaleria)
        ubicarcontrol(Me.VScrollBarGaleria)
        ubicarcontrol(Me.btnComposicionGaleria)
        ubicarcontrol(Me.btnBorrarGaleria)

    End Sub

    Private Sub frmEstudios_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

    Private Sub pbxImgEv3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgEv3.DoubleClick

        If Not (Me.pbxImgEv3.Image Is Nothing) Then

            bmap = Me.pbxImgEv3.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgEv3_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgEv3.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgEv3.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgEv3.Image = fImagen
            pbxImgEv3.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarEv.Enabled = True

        End If

    End Sub

    Private Sub pbxImgEv3_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgEv3.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbxImgEv2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgEv2.DoubleClick

        If Not (Me.pbxImgEv2.Image Is Nothing) Then

            bmap = Me.pbxImgEv2.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgEv2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgEv2.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgEv2.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgEv2.Image = fImagen
            pbxImgEv2.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarEv.Enabled = True

        End If

    End Sub

    Private Sub pbxImgEv2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgEv2.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbxImgEv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgEv1.DoubleClick


        If Not (Me.pbxImgEv1.Image Is Nothing) Then

            bmap = Me.pbxImgEv1.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgEv1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgEv1.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgEv1.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgEv1.Image = fImagen
            pbxImgEv1.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarEv.Enabled = True

        End If


    End Sub

    Private Sub pbxImgEv1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgEv1.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbxImg3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImg3.DoubleClick

        If Not (Me.pbxImg3.Image Is Nothing) Then

            bmap = Me.pbxImg3.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImg3_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImg3.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImg3.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImg3.Image = fImagen
            pbxImg3.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBar3.Enabled = True

        End If

    End Sub

    Private Sub pbxImg3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImg3.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbxImgR0_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR0.DoubleClick

        If Not (Me.pbxImgR0.Image Is Nothing) Then

            bmap = Me.pbxImgR0.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR0_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR0.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR0.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR0.Image = fImagen
            pbxImgR0.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR1.DoubleClick

        If Not (Me.pbxImgR1.Image Is Nothing) Then

            bmap = Me.pbxImgR1.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR1.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR1.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR1.Image = fImagen
            pbxImgR1.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR2.DoubleClick

        If Not (Me.pbxImgR2.Image Is Nothing) Then

            bmap = Me.pbxImgR2.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR2.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR2.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR2.Image = fImagen
            pbxImgR2.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR3.DoubleClick

        If Not (Me.pbxImgR3.Image Is Nothing) Then

            bmap = Me.pbxImgR3.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR3.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR3.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR3.Image = fImagen
            pbxImgR3.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR4.DoubleClick

        If Not (Me.pbxImgR4.Image Is Nothing) Then

            bmap = Me.pbxImgR4.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR4.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR4.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR4.Image = fImagen
            pbxImgR4.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR5.DoubleClick

        If Not (Me.pbxImgR5.Image Is Nothing) Then

            bmap = Me.pbxImgR5.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR5.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR5.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR5.Image = fImagen
            pbxImgR5.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR6.DoubleClick

        If Not (Me.pbxImgR6.Image Is Nothing) Then

            bmap = Me.pbxImgR6.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR6.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR6.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR6.Image = fImagen
            pbxImgR6.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR7_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR7.DoubleClick

        If Not (Me.pbxImgR7.Image Is Nothing) Then

            bmap = Me.pbxImgR7.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR7.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR7.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR7.Image = fImagen
            pbxImgR7.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR8_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR8.DoubleClick

        If Not (Me.pbxImgR8.Image Is Nothing) Then

            bmap = Me.pbxImgR8.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR8_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR8.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR8.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR8.Image = fImagen
            pbxImgR8.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR9_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxImgR9.DoubleClick

        If Not (Me.pbxImgR9.Image Is Nothing) Then

            bmap = Me.pbxImgR9.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxImgR9_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR9.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxImgR9.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxImgR9.Image = fImagen
            pbxImgR9.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxImgR0_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR0.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR1.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR2.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR3.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR4.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR5.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR6.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR7.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR8.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub pbxImgR9_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxImgR9.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub btnGrabarGaleria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarGaleria.Click

        Try

            GALERIA = New CLASE_GALERIA
            GALERIA.p_IdImagen = (CLASE_GENERAL.maximo("IdImagen", "galeria", CLASE_GENERAL.mensaje_error)) + 1
            GALERIA.p_IdTipo_img = 1 '1 Personal 2 General
            GALERIA.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            GALERIA.p_descripcion_img = Me.txtdescripcion_img.Text
            GALERIA.Insertar(CLASE_GENERAL.mensaje_error)

            CLASE_GENERAL.cargar_combo("galeria", Me.cmbGaleria, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
            Me.cmbGaleria.SelectedValue = GALERIA.p_IdImagen

            If Not (Me.pbxGaleria.Image Is Nothing) Then

                Me.pbxGaleria.Image = Nothing
                Me.btnBorrarGaleria.Enabled = False

            End If

            GALERIA.dispose()
            GALERIA = Nothing

            Me.txtdescripcion_img.Text = ""

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub pbxGaleria_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbxGaleria.DoubleClick

        If Not (Me.pbxGaleria.Image Is Nothing) Then

            bmap = Me.pbxGaleria.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)

        End If

    End Sub

    Private Sub pbxGaleria_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxGaleria.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbxGaleria.ImageLocation = str

            nombreImg = str
            formatografico(Image.FromFile(nombreImg))
            pbxGaleria.Image = fImagen
            pbxGaleria.SizeMode = PictureBoxSizeMode.Zoom

            VScrollBarR.Enabled = True

        End If

    End Sub

    Private Sub pbxGaleria_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxGaleria.DragEnter
        e.Effect = e.AllowedEffect
    End Sub

    Private Sub VScrollBarGaleria_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBarGaleria.Scroll

        'entero para almacenar el valor de la barra de desplazamiento
        Dim imgZoom As Single = VScrollBarGaleria.Value

        'para que solamente lo haga si hay imagen en la caja de imagen
        If Not pbxGaleria.Image Is Nothing Then
            'código para que la caja de imagen sea redimensionada
            'manteniendo el modo de colocación de la imagen: centrada o ajustada
            If (pbxGaleria.SizeMode = PictureBoxSizeMode.Zoom) Then
                pbxGaleria.Width = (449 * imgZoom) \ 100
                pbxGaleria.Height = (330 * imgZoom) \ 100
            End If

            If (pbxGaleria.SizeMode = PictureBoxSizeMode.Normal) Then
                pbxGaleria.Width = (449 * imgZoom) / 100
                pbxGaleria.Height = (330 * imgZoom) / 100
            End If
        End If

        'Recarga la imagen
        pbxGaleria.Refresh()

    End Sub

    Private Sub btnComposicionGaleria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComposicionGaleria.Click

        frmComposicion.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmComposicion.Show()
        frmComposicion.Activate()

        CLASE_GENERAL.formload = 16

    End Sub

    Private Sub btnBorrarGaleria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarGaleria.Click

        Try

            If Not (Me.cmbGaleria.Items.Count = 0) Then

                GALERIA = New CLASE_GALERIA
                GALERIA.p_IdImagen = Me.cmbGaleria.SelectedValue
                GALERIA.Eliminar(CLASE_GENERAL.mensaje_error)

                pbxGaleria.Image = Nothing

                Me.btnBorrarGaleria.Enabled = False

                CLASE_GENERAL.cargar_combo("galeria", Me.cmbGaleria, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)

                GALERIA.dispose()
                GALERIA = Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbGaleria_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGaleria.SelectionChangeCommitted

        cargargaleria()

    End Sub

    Private Sub pbxImg1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxImg1.DoubleClick

        If Not (Me.pbxImg1.Image Is Nothing) Then

            bmap = Me.pbxImg1.Image
            Dim attribute As System.IO.FileAttributes = FileAttributes.Hidden

            ruta = "c:\Odpp\imagetemp.jpg"

            bmap.Save(ruta)
            File.SetAttributes(ruta, attribute)

            Process.Start("C:\WINDOWS\system32\mspaint.exe ", ruta)
            'Shell("mspaint.exe " & ruta, vbNormalFocus)
           
        End If

    End Sub

End Class