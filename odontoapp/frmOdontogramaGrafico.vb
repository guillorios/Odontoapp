Imports System.Math


Public Class frmOdontogramaGrafico

    'Variables de clases
    Private OGRAMA As CLASE_OGRAMA
    Private GENE As CLASE_GENERAL

    'Variables de las Imagenes
    Private odontograma As Bitmap
    Private imagenaux As Bitmap

    'Variable de Imagen Base de datos
    Private iImagen As Image
    Private contar As Integer

    'Variables de Dibujo
    Private m_Drawing As Boolean
    Private m_LastX As Integer
    Private m_LastY As Integer

    'Variables auxiliares 
    Private m_Bitmap As Bitmap = Nothing
    Private m_Graphics As Graphics = Nothing

    'Variables de composicion
    Private imagenfondo As Bitmap

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea Guardar el registro antes de salir ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Odontograma")

        If respuesta = MsgBoxResult.Yes Then

            btnModificar_Click(sender, e)

        End If

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub AllocateBitmap()

        Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
        Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

        Dim g As Graphics = Graphics.FromImage(imagenfinal)

        imagenfondo = New Bitmap(My.Resources.fondoplantilla)
        g.DrawImage(imagenfondo, 0, 0, 628, 254)

        odontograma = New Bitmap(Me.pbxOdontograma.Image)
        g.DrawImage(odontograma, 0, 0, 628, 254)

        ' Make a Graphics object to draw on the Bitmap.
        m_Graphics = Graphics.FromImage(odontograma)

        ' Make the PictureBox show the Bitmap.
        pbxOdontograma.Image = odontograma

        m_Bitmap = odontograma

    End Sub

    '+++ ARCO SUPERIOR DERECHO PERMANENTE

    Private Sub ArcoSuperiorDerecho_Permanente()

        dibujardientepermanente(0, 0)


    End Sub

    Private Sub ArcoSuperiorDerecho_Permanente_AreaSuperior()

        Try

            Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
            Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

            Dim g As Graphics = Graphics.FromImage(imagenfinal)

            imagenfondo = New Bitmap(My.Resources.fondoplantilla)
            g.DrawImage(imagenfondo, 0, 0, 628, 254)

            odontograma = New Bitmap(Me.pbxOdontograma.Image)
            g.DrawImage(odontograma, 0, 0, 628, 254)

            'Lapiz
            Dim oPen As New Pen(Me.colorButton.SelectedColor, 2)
            oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

            'Brocha
            Dim oBrush As New SolidBrush(Me.colorButton.SelectedColor)


            'Pieza 18
            If (Me.txtPosX.Text >= 6 And Me.txtPosX.Text <= 36) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then


                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21, 6)
                    Points(1) = New Point(10, 20)
                    Points(2) = New Point(32, 20)

                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)


                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21, 6)
                    Points(1) = New Point(10, 20)
                    Points(2) = New Point(32, 20)

                    g.FillPolygon(oBrush, Points)

                End If


                'pieza 17
            ElseIf (Me.txtPosX.Text >= 42 And Me.txtPosX.Text <= 72) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57, 6)
                    Points(1) = New Point(46, 20)
                    Points(2) = New Point(68, 20)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57, 6)
                    Points(1) = New Point(46, 20)
                    Points(2) = New Point(68, 20)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 16

            ElseIf (Me.txtPosX.Text >= 78 And Me.txtPosX.Text <= 109) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93, 6)
                    Points(1) = New Point(82, 20)
                    Points(2) = New Point(105, 20)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93, 6)
                    Points(1) = New Point(82, 20)
                    Points(2) = New Point(105, 20)

                    g.FillPolygon(oBrush, Points)

                End If


                'pieza 15
            ElseIf (Me.txtPosX.Text >= 115 And Me.txtPosX.Text <= 145) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130, 6)
                    Points(1) = New Point(119, 20)
                    Points(2) = New Point(141, 20)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130, 6)
                    Points(1) = New Point(119, 20)
                    Points(2) = New Point(141, 20)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 14
            ElseIf (Me.txtPosX.Text >= 153 And Me.txtPosX.Text <= 183) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168, 6)
                    Points(1) = New Point(157, 20)
                    Points(2) = New Point(179, 20)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168, 6)
                    Points(1) = New Point(157, 20)
                    Points(2) = New Point(179, 20)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 13
            ElseIf (Me.txtPosX.Text >= 192 And Me.txtPosX.Text <= 222) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207, 6)
                    Points(1) = New Point(196, 20)
                    Points(2) = New Point(218, 20)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207, 6)
                    Points(1) = New Point(196, 20)
                    Points(2) = New Point(218, 20)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 12
            ElseIf (Me.txtPosX.Text >= 229 And Me.txtPosX.Text <= 259) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244, 6)
                    Points(1) = New Point(233, 20)
                    Points(2) = New Point(255, 20)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244, 6)
                    Points(1) = New Point(233, 20)
                    Points(2) = New Point(255, 20)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 11

            ElseIf (Me.txtPosX.Text >= 267 And Me.txtPosX.Text <= 297) And (Me.txtPosY.Text >= 0 And Me.txtPosY.Text <= 20) Then


                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282, 6)
                    Points(1) = New Point(271, 20)
                    Points(2) = New Point(293, 20)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282, 6)
                    Points(1) = New Point(271, 20)
                    Points(2) = New Point(293, 20)

                    g.FillPolygon(oBrush, Points)

                End If

            End If

            Me.pbxOdontograma.Image = imagenfinal

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    '+++ ARCO INFERIOR DERECHO PERMANENTE

    Private Sub ArcoInferiorDerecho_Permanente()

        dibujardientepermanente(0, 64)

    End Sub

    Private Sub ArcoInferiorDerecho_Permanente_AreaSuperior()

        dibujardientepermanentesup(0, 64)

    End Sub

    '+++ ARCO SUPERIOR IZQUIERDO PERMANENTE

    Private Sub ArcoSuperiorIzquierdo_Permanente()

        dibujardientepermanente(318, 0)

    End Sub

    Private Sub ArcoSuperiorIzquierdo_Permanente_AreaSuperior()

        dibujardientepermanentesup(318, 0)

    End Sub

    '+++ ARCO INFERIOR IZQUIERDO PERMANENTE

    Private Sub ArcoInferiorIzquierdo_Permanente()

        dibujardientepermanente(318, 64)

    End Sub

    Private Sub ArcoInferiorIzquierdo_Permanente_AreaSuperior()

        dibujardientepermanentesup(318, 64)

    End Sub

    '+++ ARCO SUPERIOR TEMPORTAL DERECHO

    Private Sub ArcoSuperiorDerecho_Temporal()

        dibujardientetemporalder(0, 127)

    End Sub

    Private Sub ArcoSuperiorDerecho_Temporal_AreaSuperior()

        dibujardientetemporalsupder(0, 127)

    End Sub

    '+++ ARCO INFERIOR TEMPORTAL DERECHO

    Private Sub ArcoInferiorDerecho_Temporal()

        dibujardientetemporalder(0, 190)

    End Sub

    Private Sub ArcoInferiorDerecho_Temporal_AreaSuperior()

        dibujardientetemporalsupder(0, 190)

    End Sub

    '++++ ARCO SUPERIOR TEMPORAL IZQUIERDO

    Private Sub ArcoSuperiorIzquierdo_Temporal()

        dibujardientetemporalizq(318, 127)

    End Sub

    Private Sub ArcoSuperiorIzquierdo_Temporal_AreaSuperior()

        dibujardientetemporalsupizq(318, 127)

    End Sub

    '++++ ARCO INFERIOR TEMPORAL IZQUIERDO

    Private Sub ArcoInferiorIzquierdo_Temporal()

        dibujardientetemporalizq(318, 190)

    End Sub

    Private Sub ArcoInferiorIzquierdo_Temporal_AreaSuperior()

        dibujardientetemporalsupizq(318, 190)

    End Sub

    '******************************************************************************

    Private Sub dibujardientepermanente(ByVal sX As Integer, ByVal sY As Integer)

        Try

            Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
            Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

            Dim g As Graphics = Graphics.FromImage(imagenfinal)

            imagenfondo = New Bitmap(My.Resources.fondoplantilla)
            g.DrawImage(imagenfondo, 0, 0, 628, 254)

            odontograma = New Bitmap(Me.pbxOdontograma.Image)
            g.DrawImage(odontograma, 0, 0, 628, 254)

            'Lapiz
            Dim oPen As New Pen(Me.colorButton.SelectedColor, 2)
            oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

            'Brocha
            Dim oBrush As New SolidBrush(Me.colorButton.SelectedColor)



            '************** Pieza 48
            If (Me.txtPosX.Text >= 6 + sX And Me.txtPosX.Text <= 36 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 6 + sX, 20 + sY, 30, 30)
                    'objLTTS.Read("18: Protesis Fija.")

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 7 + (sX), 21 + (sY), 28, 28)
                    ''objLTTS.Read("18: Corona.")


                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21 + sX, 20 + sY)
                    Points(1) = New Point(6 + sX, 50 + sY)
                    Points(2) = New Point(36 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                    'objLTTS.Read("18: Nucleo.")

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(6 + sX, 20 + sY)
                    Points(1) = New Point(36 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(6 + sX, 50 + sY)
                    Points2(1) = New Point(36 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                    'objLTTS.Read("18: Exodoncia Indicada.")

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(6 + sX, 35 + sY)
                    Points(1) = New Point(36 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                    'objLTTS.Read("18: Protesis Removible.")

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(22 + sX, 20 + sY)
                    Points(1) = New Point(22 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                    'objLTTS.Read("18: Ausente por Endodoncia.")

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(6 + sX, 20 + sY)
                    Points(1) = New Point(36 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(6 + sX, 50 + sY)
                    Points2(1) = New Point(36 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                    'objLTTS.Read("18: Diente extraido.")

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 2 + (sX), 14 + (sY))

                    'objLTTS.Read("18: Superficie Sellada.")

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(6 + sX, 30 + sY), New Point(6 + sX, 20 + sY), New Point(36 + sX, 20 + sY), New Point(36 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(6 + sX, 40 + sY), New Point(6 + sX, 50 + sY), New Point(36 + sX, 50 + sY), New Point(36 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                    'objLTTS.Read("18: Diente Ausente.")

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(6 + sX, 50 + sY), New Point(6 + sX, 20 + sY), New Point(36 + sX, 20 + sY), New Point(36 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                    'objLTTS.Read("18: Protesis Removible.")

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 5 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 8 + (sX), 13 + (sY))

                    'objLTTS.Read("18: Incrustacion.")

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(8 + (sX), 21 + (sY)), New Point(35 + (sX), 21 + (sY)), New Point(27 + (sX), 29 + (sY)), New Point(16 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(35 + (sX), 21 + (sY)), New Point(36 + (sX), 49 + (sY)), New Point(28 + (sX), 41 + (sY)), New Point(28 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(35 + (sX), 50 + (sY)), New Point(6 + (sX), 50 + (sY)), New Point(15 + (sX), 42 + (sY)), New Point(28 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(7 + (sX), 49 + (sY)), New Point(7 + (sX), 21 + (sY)), New Point(15 + (sX), 30 + (sY)), New Point(15 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(16 + (sX), 30 + (sY)), New Point(27 + (sX), 30 + (sY)), New Point(27 + (sX), 41 + (sY)), New Point(16 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

                ' ****************** pieza 47
            ElseIf (Me.txtPosX.Text >= 42 + sX And Me.txtPosX.Text <= 72 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 42 + sX, 20 + sY, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 43 + (sX), 21 + (sY), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57 + sX, 20 + sY)
                    Points(1) = New Point(42 + sX, 50 + sY)
                    Points(2) = New Point(72 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(42 + sX, 20 + sY)
                    Points(1) = New Point(72 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(42 + sX, 50 + sY)
                    Points2(1) = New Point(72 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(42 + sX, 35 + sY)
                    Points(1) = New Point(72 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(58 + sX, 20 + sY)
                    Points(1) = New Point(58 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(42 + sX, 20 + sY)
                    Points(1) = New Point(72 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(42 + sX, 50 + sY)
                    Points2(1) = New Point(72 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 38 + (sX), 14 + (sY))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))


                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(42 + sX, 30 + sY), New Point(42 + sX, 20 + sY), New Point(72 + sX, 20 + sY), New Point(72 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(42 + sX, 40 + sY), New Point(42 + sX, 50 + sY), New Point(72 + sX, 50 + sY), New Point(72 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(42 + sX, 50 + sY), New Point(42 + sX, 20 + sY), New Point(72 + sX, 20 + sY), New Point(72 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 41 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 44 + (sX), 13 + (sY))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(44 + (sX), 21 + (sY)), New Point(71 + (sX), 21 + (sY)), New Point(63 + (sX), 29 + (sY)), New Point(52 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(72 + (sX), 21 + (sY)), New Point(72 + (sX), 49 + (sY)), New Point(64 + (sX), 41 + (sY)), New Point(64 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(71 + (sX), 50 + (sY)), New Point(43 + (sX), 50 + (sY)), New Point(51 + (sX), 42 + (sY)), New Point(64 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(43 + (sX), 49 + (sY)), New Point(43 + (sX), 21 + (sY)), New Point(51 + (sX), 30 + (sY)), New Point(51 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(52 + (sX), 30 + (sY)), New Point(63 + (sX), 30 + (sY)), New Point(63 + (sX), 41 + (sY)), New Point(52 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If



                End If


                'pieza 46

            ElseIf (Me.txtPosX.Text >= 78 + sX And Me.txtPosX.Text <= 109 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 78 + sX, 20 + sY, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 79 + (sX), 21 + (sY), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93 + sX, 20 + sY)
                    Points(1) = New Point(78 + sX, 50 + sY)
                    Points(2) = New Point(109 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(78 + sX, 20 + sY)
                    Points(1) = New Point(108 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(78 + sX, 50 + sY)
                    Points2(1) = New Point(108 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(78 + sX, 35 + sY)
                    Points(1) = New Point(109 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(94 + sX, 20 + sY)
                    Points(1) = New Point(94 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(78 + sX, 20 + sY)
                    Points(1) = New Point(109 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(78 + sX, 50 + sY)
                    Points2(1) = New Point(109 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 74 + (sX), 14 + (sY))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(78 + sX, 30 + sY), New Point(78 + sX, 20 + sY), New Point(109 + sX, 20 + sY), New Point(109 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(78 + sX, 40 + sY), New Point(78 + sX, 50 + sY), New Point(109 + sX, 50 + sY), New Point(109 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(78 + sX, 50 + sY), New Point(78 + sX, 20 + sY), New Point(109 + sX, 20 + sY), New Point(109 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 77 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 80 + (sX), 13 + (sY))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(80 + (sX), 21 + (sY)), New Point(107 + (sX), 21 + (sY)), New Point(99 + (sX), 29 + (sY)), New Point(88 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(108 + (sX), 21 + (sY)), New Point(108 + (sX), 49 + (sY)), New Point(100 + (sX), 41 + (sY)), New Point(100 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(108 + (sX), 50 + (sY)), New Point(79 + (sX), 50 + (sY)), New Point(87 + (sX), 42 + (sY)), New Point(100 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(79 + (sX), 49 + (sY)), New Point(79 + (sX), 21 + (sY)), New Point(87 + (sX), 30 + (sY)), New Point(87 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(88 + (sX), 30 + (sY)), New Point(99 + (sX), 30 + (sY)), New Point(99 + (sX), 41 + (sY)), New Point(88 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If

                End If

                'pieza 45
            ElseIf (Me.txtPosX.Text >= 115 + sX And Me.txtPosX.Text <= 145 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 115 + sX, 20 + sY, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 116 + (sX), 21 + (sY), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 20 + sY)
                    Points(1) = New Point(115 + sX, 50 + sY)
                    Points(2) = New Point(145 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 20 + sY)
                    Points(1) = New Point(145 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(115 + sX, 50 + sY)
                    Points2(1) = New Point(145 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 35 + sY)
                    Points(1) = New Point(145 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(131 + sX, 20 + sY)
                    Points(1) = New Point(131 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 20 + sY)
                    Points(1) = New Point(145 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(115 + sX, 50 + sY)
                    Points2(1) = New Point(145 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 111 + (sX), 14 + (sY))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(115 + sX, 30 + sY), New Point(115 + sX, 20 + sY), New Point(145 + sX, 20 + sY), New Point(145 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(115 + sX, 40 + sY), New Point(115 + sX, 50 + sY), New Point(145 + sX, 50 + sY), New Point(145 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(115 + sX, 50 + sY), New Point(115 + sX, 20 + sY), New Point(145 + sX, 20 + sY), New Point(145 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 114 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 117 + (sX), 13 + (sY))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(117 + (sX), 21 + (sY)), New Point(144 + (sX), 21 + (sY)), New Point(136 + (sX), 29 + (sY)), New Point(125 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(145 + (sX), 21 + (sY)), New Point(145 + (sX), 49 + (sY)), New Point(137 + (sX), 41 + (sY)), New Point(137 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(145 + (sX), 50 + (sY)), New Point(116 + (sX), 50 + (sY)), New Point(124 + (sX), 42 + (sY)), New Point(137 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(116 + (sX), 49 + (sY)), New Point(116 + (sX), 21 + (sY)), New Point(124 + (sX), 30 + (sY)), New Point(124 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(125 + (sX), 30 + (sY)), New Point(136 + (sX), 30 + (sY)), New Point(136 + (sX), 41 + (sY)), New Point(125 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If


                'pieza 44
            ElseIf (Me.txtPosX.Text >= 153 + sX And Me.txtPosX.Text <= 183 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 153 + sX, 20 + sY, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 154 + (sX), 21 + (sY), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 20 + sY)
                    Points(1) = New Point(153 + sX, 50 + sY)
                    Points(2) = New Point(183 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 20 + sY)
                    Points(1) = New Point(183 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(153 + sX, 50 + sY)
                    Points2(1) = New Point(183 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 35 + sY)
                    Points(1) = New Point(183 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(169 + sX, 20 + sY)
                    Points(1) = New Point(169 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 20 + sY)
                    Points(1) = New Point(183 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(153 + sX, 50 + sY)
                    Points2(1) = New Point(183 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 149 + (sX), 14 + (sY))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(153 + sX, 30 + sY), New Point(153 + sX, 20 + sY), New Point(183 + sX, 20 + sY), New Point(183 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(153 + sX, 40 + sY), New Point(153 + sX, 50 + sY), New Point(183 + sX, 50 + sY), New Point(183 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(153 + sX, 50 + sY), New Point(153 + sX, 20 + sY), New Point(183 + sX, 20 + sY), New Point(183 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 152 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 155 + (sX), 13 + (sY))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(155 + (sX), 21 + (sY)), New Point(182 + (sX), 21 + (sY)), New Point(174 + (sX), 29 + (sY)), New Point(163 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(183 + (sX), 21 + (sY)), New Point(183 + (sX), 49 + (sY)), New Point(175 + (sX), 41 + (sY)), New Point(175 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(182 + (sX), 50 + (sY)), New Point(154 + (sX), 50 + (sY)), New Point(162 + (sX), 42 + (sY)), New Point(175 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(154 + (sX), 49 + (sY)), New Point(154 + (sX), 21 + (sY)), New Point(162 + (sX), 30 + (sY)), New Point(162 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(163 + (sX), 30 + (sY)), New Point(174 + (sX), 30 + (sY)), New Point(174 + (sX), 41 + (sY)), New Point(163 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If


                'pieza 43
            ElseIf (Me.txtPosX.Text >= 192 + sX And Me.txtPosX.Text <= 222 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 192 + sX, 20 + sY, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 193 + (sX), 21 + (sY), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207 + sX, 20 + sY)
                    Points(1) = New Point(192 + sX, 50 + sY)
                    Points(2) = New Point(222 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 20 + sY)
                    Points(1) = New Point(222 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(192 + sX, 50 + sY)
                    Points2(1) = New Point(222 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 35 + sY)
                    Points(1) = New Point(222 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(208 + sX, 20 + sY)
                    Points(1) = New Point(208 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 20 + sY)
                    Points(1) = New Point(222 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(192 + sX, 50 + sY)
                    Points2(1) = New Point(222 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 188 + (sX), 14 + (sY))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(192 + sX, 30 + sY), New Point(192 + sX, 20 + sY), New Point(222 + sX, 20 + sY), New Point(222 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(192 + sX, 40 + sY), New Point(192 + sX, 50 + sY), New Point(222 + sX, 50 + sY), New Point(222 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(192 + sX, 50 + sY), New Point(192 + sX, 20 + sY), New Point(222 + sX, 20 + sY), New Point(222 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 191 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 194 + (sX), 13 + (sY))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(194 + (sX), 21 + (sY)), New Point(221 + (sX), 21 + (sY)), New Point(212 + (sX), 29 + (sY)), New Point(202 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(222 + (sX), 21 + (sY)), New Point(222 + (sX), 49 + (sY)), New Point(214 + (sX), 41 + (sY)), New Point(214 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(222 + (sX), 50 + (sY)), New Point(193 + (sX), 50 + (sY)), New Point(201 + (sX), 42 + (sY)), New Point(214 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(193 + (sX), 49 + (sY)), New Point(193 + (sX), 21 + (sY)), New Point(201 + (sX), 30 + (sY)), New Point(201 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(202 + (sX), 30 + (sY)), New Point(213 + (sX), 30 + (sY)), New Point(213 + (sX), 41 + (sY)), New Point(202 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If

                End If


                'pieza 42
            ElseIf (Me.txtPosX.Text >= 229 + sX And Me.txtPosX.Text <= 259 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 229 + sX, 20 + sY, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 230 + (sX), 21 + (sY), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244 + sX, 20 + sY)
                    Points(1) = New Point(229 + sX, 50 + sY)
                    Points(2) = New Point(259 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 20 + sY)
                    Points(1) = New Point(259 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(229 + sX, 50 + sY)
                    Points2(1) = New Point(259 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 35 + sY)
                    Points(1) = New Point(259 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(245 + sX, 20 + sY)
                    Points(1) = New Point(245 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 20 + sY)
                    Points(1) = New Point(259 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(229 + sX, 50 + sY)
                    Points2(1) = New Point(259 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 225 + (sX), 14 + (sY))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))


                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(229 + sX, 30 + sY), New Point(229 + sX, 20 + sY), New Point(259 + sX, 20 + sY), New Point(259 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(229 + sX, 40 + sY), New Point(229 + sX, 50 + sY), New Point(259 + sX, 50 + sY), New Point(259 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(229 + sX, 50 + sY), New Point(229 + sX, 20 + sY), New Point(259 + sX, 20 + sY), New Point(259 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 228 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 231 + (sX), 13 + (sY))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(231 + (sX), 21 + (sY)), New Point(258 + (sX), 21 + (sY)), New Point(250 + (sX), 29 + (sY)), New Point(239 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(259 + (sX), 21 + (sY)), New Point(259 + (sX), 49 + (sY)), New Point(251 + (sX), 41 + (sY)), New Point(251 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(259 + (sX), 50 + (sY)), New Point(229 + (sX), 50 + (sY)), New Point(238 + (sX), 42 + (sY)), New Point(251 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(230 + (sX), 49 + (sY)), New Point(230 + (sX), 21 + (sY)), New Point(238 + (sX), 30 + (sY)), New Point(238 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(239 + (sX), 30 + (sY)), New Point(250 + (sX), 30 + (sY)), New Point(250 + (sX), 41 + (sY)), New Point(239 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

                'pieza 41
            ElseIf (Me.txtPosX.Text >= 267 + sX And Me.txtPosX.Text <= 297 + sX) And (Me.txtPosY.Text >= 20 + sY And Me.txtPosY.Text <= 50 + sY) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 267 + sX, 20 + sY, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 268 + (sX), 21 + (sY), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282 + sX, 20 + sY)
                    Points(1) = New Point(267 + sX, 50 + sY)
                    Points(2) = New Point(297 + sX, 50 + sY)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 20 + sY)
                    Points(1) = New Point(297 + sX, 50 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(267 + sX, 50 + sY)
                    Points2(1) = New Point(297 + sX, 20 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 35 + sY)
                    Points(1) = New Point(297 + sX, 35 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(283 + sX, 20 + sY)
                    Points(1) = New Point(283 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 20 + sY)
                    Points(1) = New Point(297 + sX, 20 + sY)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(267 + sX, 50 + sY)
                    Points2(1) = New Point(297 + sX, 50 + sY)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 263 + (sX), 14 + (sY))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(267 + sX, 30 + sY), New Point(267 + sX, 20 + sY), New Point(297 + sX, 20 + sY), New Point(297 + sX, 30 + sY)}
                    Dim points2 As Point() = {New Point(267 + sX, 40 + sY), New Point(267 + sX, 50 + sY), New Point(297 + sX, 50 + sY), New Point(297 + sX, 40 + sY)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(267 + sX, 50 + sY), New Point(267 + sX, 20 + sY), New Point(297 + sX, 20 + sY), New Point(297 + sX, 50 + sY)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 266 + (sX), 3 + (sY))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 268 + (sX), 13 + (sY))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(269 + (sX), 21 + (sY)), New Point(296 + (sX), 21 + (sY)), New Point(288 + (sX), 29 + (sY)), New Point(277 + (sX), 29 + (sY))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(297 + (sX), 21 + (sY)), New Point(297 + (sX), 49 + (sY)), New Point(289 + (sX), 41 + (sY)), New Point(289 + (sX), 29 + (sY))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(296 + (sX), 50 + (sY)), New Point(268 + (sX), 50 + (sY)), New Point(276 + (sX), 42 + (sY)), New Point(289 + (sX), 42 + (sY))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(268 + (sX), 49 + (sY)), New Point(268 + (sX), 21 + (sY)), New Point(276 + (sX), 30 + (sY)), New Point(276 + (sX), 41 + (sY))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(277 + (sX), 30 + (sY)), New Point(288 + (sX), 30 + (sY)), New Point(288 + (sX), 41 + (sY)), New Point(277 + (sX), 41 + (sY))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

            End If

            Me.pbxOdontograma.Image = imagenfinal


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub dibujardientepermanentesup(ByVal sX As Integer, ByVal sy As Integer)

        Try

            Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
            Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

            Dim g As Graphics = Graphics.FromImage(imagenfinal)

            imagenfondo = New Bitmap(My.Resources.fondoplantilla)
            g.DrawImage(imagenfondo, 0, 0, 628, 254)

            odontograma = New Bitmap(Me.pbxOdontograma.Image)
            g.DrawImage(odontograma, 0, 0, 628, 254)

            'Lapiz
            Dim oPen As New Pen(Me.colorButton.SelectedColor, 2)
            oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

            'Brocha
            Dim oBrush As New SolidBrush(Me.colorButton.SelectedColor)


            'Pieza 18
            If (Me.txtPosX.Text >= 6 + sX And Me.txtPosX.Text <= 36 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then


                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21 + sX, 6 + sY)
                    Points(1) = New Point(10 + sX, 20 + sY)
                    Points(2) = New Point(32 + sX, 20 + sY)

                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)


                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21 + sX, 6 + sY)
                    Points(1) = New Point(10 + sX, 20 + sY)
                    Points(2) = New Point(32 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If


                'pieza 17
            ElseIf (Me.txtPosX.Text >= 42 + sX And Me.txtPosX.Text <= 72 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57 + sX, 6 + sY)
                    Points(1) = New Point(46 + sX, 20 + sY)
                    Points(2) = New Point(68 + sX, 20 + sY)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57 + sX, 6 + sY)
                    Points(1) = New Point(46 + sX, 20 + sY)
                    Points(2) = New Point(68 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 16

            ElseIf (Me.txtPosX.Text >= 78 + sX And Me.txtPosX.Text <= 109 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93 + sX, 6 + sY)
                    Points(1) = New Point(82 + sX, 20 + sY)
                    Points(2) = New Point(105 + sX, 20 + sY)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93 + sX, 6 + sY)
                    Points(1) = New Point(82 + sX, 20 + sY)
                    Points(2) = New Point(105 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If


                'pieza 15
            ElseIf (Me.txtPosX.Text >= 115 + sX And Me.txtPosX.Text <= 145 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 6 + sY)
                    Points(1) = New Point(119 + sX, 20 + sY)
                    Points(2) = New Point(141 + sX, 20 + sY)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 6 + sY)
                    Points(1) = New Point(119 + sX, 20 + sY)
                    Points(2) = New Point(141 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 14
            ElseIf (Me.txtPosX.Text >= 153 + sX And Me.txtPosX.Text <= 183 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 6 + sY)
                    Points(1) = New Point(157 + sX, 20 + sY)
                    Points(2) = New Point(179 + sX, 20 + sY)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 6 + sY)
                    Points(1) = New Point(157 + sX, 20 + sY)
                    Points(2) = New Point(179 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 13
            ElseIf (Me.txtPosX.Text >= 192 + sX And Me.txtPosX.Text <= 222 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207 + sX, 6 + sY)
                    Points(1) = New Point(196 + sX, 20 + sY)
                    Points(2) = New Point(218 + sX, 20 + sY)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207 + sX, 6 + sY)
                    Points(1) = New Point(196 + sX, 20 + sY)
                    Points(2) = New Point(218 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 12
            ElseIf (Me.txtPosX.Text >= 229 + sX And Me.txtPosX.Text <= 259 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244 + sX, 6 + sY)
                    Points(1) = New Point(233 + sX, 20 + sY)
                    Points(2) = New Point(255 + sX, 20 + sY)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244 + sX, 6 + sY)
                    Points(1) = New Point(233 + sX, 20 + sY)
                    Points(2) = New Point(255 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 11

            ElseIf (Me.txtPosX.Text >= 267 + sX And Me.txtPosX.Text <= 297 + sX) And (Me.txtPosY.Text >= 0 + sY And Me.txtPosY.Text <= 20 + sY) Then


                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282 + sX, 6 + sY)
                    Points(1) = New Point(271 + sX, 20 + sY)
                    Points(2) = New Point(293 + sX, 20 + sY)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282 + sX, 6 + sY)
                    Points(1) = New Point(271 + sX, 20 + sY)
                    Points(2) = New Point(293 + sX, 20 + sY)

                    g.FillPolygon(oBrush, Points)

                End If

            End If

            Me.pbxOdontograma.Image = imagenfinal

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub dibujardientetemporalder(ByVal sX As Integer, ByVal sy As Integer)

        Try

            Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
            Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

            Dim g As Graphics = Graphics.FromImage(imagenfinal)

            imagenfondo = New Bitmap(My.Resources.fondoplantilla)
            g.DrawImage(imagenfondo, 0, 0, 628, 254)

            odontograma = New Bitmap(Me.pbxOdontograma.Image)
            g.DrawImage(odontograma, 0, 0, 628, 254)

            'Lapiz
            Dim oPen As New Pen(Me.colorButton.SelectedColor, 2)
            oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

            'Brocha
            Dim oBrush As New SolidBrush(Me.colorButton.SelectedColor)

            ''Loquendo
            'objLTTS.Voice = "Carlos"
            'objLTTS.Language = "SpanishAm"

            If (Me.txtPosX.Text >= 115 + sX And Me.txtPosX.Text <= 145 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 115 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 116 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 20 + sy)
                    Points(1) = New Point(115 + sX, 50 + sy)
                    Points(2) = New Point(145 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 20 + sy)
                    Points(1) = New Point(145 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(115 + sX, 50 + sy)
                    Points2(1) = New Point(145 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 35 + sy)
                    Points(1) = New Point(145 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(131 + sX, 20 + sy)
                    Points(1) = New Point(131 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 20 + sy)
                    Points(1) = New Point(145 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(115 + sX, 50 + sy)
                    Points2(1) = New Point(145 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 111 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(115 + sX, 30 + sy), New Point(115 + sX, 20 + sy), New Point(145 + sX, 20 + sy), New Point(145 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(115 + sX, 40 + sy), New Point(115 + sX, 50 + sy), New Point(145 + sX, 50 + sy), New Point(145 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(115 + sX, 50 + sy), New Point(115 + sX, 20 + sy), New Point(145 + sX, 20 + sy), New Point(145 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 114 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 117 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(117 + (sX), 21 + (sy)), New Point(144 + (sX), 21 + (sy)), New Point(136 + (sX), 29 + (sy)), New Point(125 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(145 + (sX), 21 + (sy)), New Point(145 + (sX), 49 + (sy)), New Point(137 + (sX), 41 + (sy)), New Point(137 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(145 + (sX), 50 + (sy)), New Point(116 + (sX), 50 + (sy)), New Point(124 + (sX), 42 + (sy)), New Point(137 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(116 + (sX), 49 + (sy)), New Point(116 + (sX), 21 + (sy)), New Point(124 + (sX), 30 + (sy)), New Point(124 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(125 + (sX), 30 + (sy)), New Point(136 + (sX), 30 + (sy)), New Point(136 + (sX), 41 + (sy)), New Point(125 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If


                'pieza 44
            ElseIf (Me.txtPosX.Text >= 153 + sX And Me.txtPosX.Text <= 183 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 153 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 154 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 20 + sy)
                    Points(1) = New Point(153 + sX, 50 + sy)
                    Points(2) = New Point(183 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 20 + sy)
                    Points(1) = New Point(183 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(153 + sX, 50 + sy)
                    Points2(1) = New Point(183 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 35 + sy)
                    Points(1) = New Point(183 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(169 + sX, 20 + sy)
                    Points(1) = New Point(169 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 20 + sy)
                    Points(1) = New Point(183 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(153 + sX, 50 + sy)
                    Points2(1) = New Point(183 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 149 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(153 + sX, 30 + sy), New Point(153 + sX, 20 + sy), New Point(183 + sX, 20 + sy), New Point(183 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(153 + sX, 40 + sy), New Point(153 + sX, 50 + sy), New Point(183 + sX, 50 + sy), New Point(183 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(153 + sX, 50 + sy), New Point(153 + sX, 20 + sy), New Point(183 + sX, 20 + sy), New Point(183 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 152 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 155 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(155 + (sX), 21 + (sy)), New Point(182 + (sX), 21 + (sy)), New Point(174 + (sX), 29 + (sy)), New Point(163 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(183 + (sX), 21 + (sy)), New Point(183 + (sX), 49 + (sy)), New Point(175 + (sX), 41 + (sy)), New Point(175 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(182 + (sX), 50 + (sy)), New Point(154 + (sX), 50 + (sy)), New Point(162 + (sX), 42 + (sy)), New Point(175 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(154 + (sX), 49 + (sy)), New Point(154 + (sX), 21 + (sy)), New Point(162 + (sX), 30 + (sy)), New Point(162 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(163 + (sX), 30 + (sy)), New Point(174 + (sX), 30 + (sy)), New Point(174 + (sX), 41 + (sy)), New Point(163 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If


                'pieza 43
            ElseIf (Me.txtPosX.Text >= 192 + sX And Me.txtPosX.Text <= 222 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 192 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 193 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207 + sX, 20 + sy)
                    Points(1) = New Point(192 + sX, 50 + sy)
                    Points(2) = New Point(222 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 20 + sy)
                    Points(1) = New Point(222 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(192 + sX, 50 + sy)
                    Points2(1) = New Point(222 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 35 + sy)
                    Points(1) = New Point(222 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(208 + sX, 20 + sy)
                    Points(1) = New Point(208 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 20 + sy)
                    Points(1) = New Point(222 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(192 + sX, 50 + sy)
                    Points2(1) = New Point(222 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 188 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(192 + sX, 30 + sy), New Point(192 + sX, 20 + sy), New Point(222 + sX, 20 + sy), New Point(222 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(192 + sX, 40 + sy), New Point(192 + sX, 50 + sy), New Point(222 + sX, 50 + sy), New Point(222 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(192 + sX, 50 + sy), New Point(192 + sX, 20 + sy), New Point(222 + sX, 20 + sy), New Point(222 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 191 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 194 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(194 + (sX), 21 + (sy)), New Point(221 + (sX), 21 + (sy)), New Point(212 + (sX), 29 + (sy)), New Point(202 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(222 + (sX), 21 + (sy)), New Point(222 + (sX), 49 + (sy)), New Point(214 + (sX), 41 + (sy)), New Point(214 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(222 + (sX), 50 + (sy)), New Point(193 + (sX), 50 + (sy)), New Point(201 + (sX), 42 + (sy)), New Point(214 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(193 + (sX), 49 + (sy)), New Point(193 + (sX), 21 + (sy)), New Point(201 + (sX), 30 + (sy)), New Point(201 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(202 + (sX), 30 + (sy)), New Point(213 + (sX), 30 + (sy)), New Point(213 + (sX), 41 + (sy)), New Point(202 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If

                End If


                'pieza 42
            ElseIf (Me.txtPosX.Text >= 229 + sX And Me.txtPosX.Text <= 259 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 229 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 230 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244 + sX, 20 + sy)
                    Points(1) = New Point(229 + sX, 50 + sy)
                    Points(2) = New Point(259 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 20 + sy)
                    Points(1) = New Point(259 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(229 + sX, 50 + sy)
                    Points2(1) = New Point(259 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 35 + sy)
                    Points(1) = New Point(259 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(245 + sX, 20 + sy)
                    Points(1) = New Point(245 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 20 + sy)
                    Points(1) = New Point(259 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(229 + sX, 50 + sy)
                    Points2(1) = New Point(259 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 225 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))


                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(229 + sX, 30 + sy), New Point(229 + sX, 20 + sy), New Point(259 + sX, 20 + sy), New Point(259 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(229 + sX, 40 + sy), New Point(229 + sX, 50 + sy), New Point(259 + sX, 50 + sy), New Point(259 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(229 + sX, 50 + sy), New Point(229 + sX, 20 + sy), New Point(259 + sX, 20 + sy), New Point(259 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 228 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 231 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(231 + (sX), 21 + (sy)), New Point(258 + (sX), 21 + (sy)), New Point(250 + (sX), 29 + (sy)), New Point(239 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(259 + (sX), 21 + (sy)), New Point(259 + (sX), 49 + (sy)), New Point(251 + (sX), 41 + (sy)), New Point(251 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(259 + (sX), 50 + (sy)), New Point(229 + (sX), 50 + (sy)), New Point(238 + (sX), 42 + (sy)), New Point(251 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(230 + (sX), 49 + (sy)), New Point(230 + (sX), 21 + (sy)), New Point(238 + (sX), 30 + (sy)), New Point(238 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(239 + (sX), 30 + (sy)), New Point(250 + (sX), 30 + (sy)), New Point(250 + (sX), 41 + (sy)), New Point(239 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

                'pieza 41
            ElseIf (Me.txtPosX.Text >= 267 + sX And Me.txtPosX.Text <= 297 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 267 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 268 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282 + sX, 20 + sy)
                    Points(1) = New Point(267 + sX, 50 + sy)
                    Points(2) = New Point(297 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 20 + sy)
                    Points(1) = New Point(297 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(267 + sX, 50 + sy)
                    Points2(1) = New Point(297 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 35 + sy)
                    Points(1) = New Point(297 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(283 + sX, 20 + sy)
                    Points(1) = New Point(283 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 20 + sy)
                    Points(1) = New Point(297 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(267 + sX, 50 + sy)
                    Points2(1) = New Point(297 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 263 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(267 + sX, 30 + sy), New Point(267 + sX, 20 + sy), New Point(297 + sX, 20 + sy), New Point(297 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(267 + sX, 40 + sy), New Point(267 + sX, 50 + sy), New Point(297 + sX, 50 + sy), New Point(297 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(267 + sX, 50 + sy), New Point(267 + sX, 20 + sy), New Point(297 + sX, 20 + sy), New Point(297 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 266 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 268 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(269 + (sX), 21 + (sy)), New Point(296 + (sX), 21 + (sy)), New Point(288 + (sX), 29 + (sy)), New Point(277 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(297 + (sX), 21 + (sy)), New Point(297 + (sX), 49 + (sy)), New Point(289 + (sX), 41 + (sy)), New Point(289 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(296 + (sX), 50 + (sy)), New Point(268 + (sX), 50 + (sy)), New Point(276 + (sX), 42 + (sy)), New Point(289 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(268 + (sX), 49 + (sy)), New Point(268 + (sX), 21 + (sy)), New Point(276 + (sX), 30 + (sy)), New Point(276 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(277 + (sX), 30 + (sy)), New Point(288 + (sX), 30 + (sy)), New Point(288 + (sX), 41 + (sy)), New Point(277 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

            End If

            Me.pbxOdontograma.Image = imagenfinal


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub dibujardientetemporalsupder(ByVal sX As Integer, ByVal sy As Integer)

        Try

            Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
            Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

            Dim g As Graphics = Graphics.FromImage(imagenfinal)

            imagenfondo = New Bitmap(My.Resources.fondoplantilla)
            g.DrawImage(imagenfondo, 0, 0, 628, 254)

            odontograma = New Bitmap(Me.pbxOdontograma.Image)
            g.DrawImage(odontograma, 0, 0, 628, 254)

            'Lapiz
            Dim oPen As New Pen(Me.colorButton.SelectedColor, 2)
            oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

            'Brocha
            Dim oBrush As New SolidBrush(Me.colorButton.SelectedColor)


            If (Me.txtPosX.Text >= 115 + sX And Me.txtPosX.Text <= 145 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 6 + sy)
                    Points(1) = New Point(119 + sX, 20 + sy)
                    Points(2) = New Point(141 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 6 + sy)
                    Points(1) = New Point(119 + sX, 20 + sy)
                    Points(2) = New Point(141 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 14
            ElseIf (Me.txtPosX.Text >= 153 + sX And Me.txtPosX.Text <= 183 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 6 + sy)
                    Points(1) = New Point(157 + sX, 20 + sy)
                    Points(2) = New Point(179 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 6 + sy)
                    Points(1) = New Point(157 + sX, 20 + sy)
                    Points(2) = New Point(179 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 13
            ElseIf (Me.txtPosX.Text >= 192 + sX And Me.txtPosX.Text <= 222 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207 + sX, 6 + sy)
                    Points(1) = New Point(196 + sX, 20 + sy)
                    Points(2) = New Point(218 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207 + sX, 6 + sy)
                    Points(1) = New Point(196 + sX, 20 + sy)
                    Points(2) = New Point(218 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 12
            ElseIf (Me.txtPosX.Text >= 229 + sX And Me.txtPosX.Text <= 259 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244 + sX, 6 + sy)
                    Points(1) = New Point(233 + sX, 20 + sy)
                    Points(2) = New Point(255 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244 + sX, 6 + sy)
                    Points(1) = New Point(233 + sX, 20 + sy)
                    Points(2) = New Point(255 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 11

            ElseIf (Me.txtPosX.Text >= 267 + sX And Me.txtPosX.Text <= 297 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then


                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282 + sX, 6 + sy)
                    Points(1) = New Point(271 + sX, 20 + sy)
                    Points(2) = New Point(293 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282 + sX, 6 + sy)
                    Points(1) = New Point(271 + sX, 20 + sy)
                    Points(2) = New Point(293 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

            End If

            Me.pbxOdontograma.Image = imagenfinal

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub dibujardientetemporalizq(ByVal sX As Integer, ByVal sy As Integer)

        Try

            Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
            Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

            Dim g As Graphics = Graphics.FromImage(imagenfinal)

            imagenfondo = New Bitmap(My.Resources.fondoplantilla)
            g.DrawImage(imagenfondo, 0, 0, 628, 254)

            odontograma = New Bitmap(Me.pbxOdontograma.Image)
            g.DrawImage(odontograma, 0, 0, 628, 254)

            'Lapiz
            Dim oPen As New Pen(Me.colorButton.SelectedColor, 2)
            oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

            'Brocha
            Dim oBrush As New SolidBrush(Me.colorButton.SelectedColor)

            ''Loquendo
            'objLTTS.Voice = "Carlos"
            'objLTTS.Language = "SpanishAm"

            '************** Pieza 48
            If (Me.txtPosX.Text >= 6 + sX And Me.txtPosX.Text <= 36 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 6 + sX, 20 + sy, 30, 30)
                    'objLTTS.Read("18: Protesis Fija.")

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 7 + (sX), 21 + (sy), 28, 28)
                    ''objLTTS.Read("18: Corona.")


                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21 + sX, 20 + sy)
                    Points(1) = New Point(6 + sX, 50 + sy)
                    Points(2) = New Point(36 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                    'objLTTS.Read("18: Nucleo.")

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(6 + sX, 20 + sy)
                    Points(1) = New Point(36 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(6 + sX, 50 + sy)
                    Points2(1) = New Point(36 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                    'objLTTS.Read("18: Exodoncia Indicada.")

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(6 + sX, 35 + sy)
                    Points(1) = New Point(36 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                    'objLTTS.Read("18: Protesis Removible.")

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(22 + sX, 20 + sy)
                    Points(1) = New Point(22 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                    'objLTTS.Read("18: Ausente por Endodoncia.")

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(6 + sX, 20 + sy)
                    Points(1) = New Point(36 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(6 + sX, 50 + sy)
                    Points2(1) = New Point(36 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                    'objLTTS.Read("18: Diente extraido.")

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 2 + (sX), 14 + (sy))

                    'objLTTS.Read("18: Superficie Sellada.")

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(6 + sX, 30 + sy), New Point(6 + sX, 20 + sy), New Point(36 + sX, 20 + sy), New Point(36 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(6 + sX, 40 + sy), New Point(6 + sX, 50 + sy), New Point(36 + sX, 50 + sy), New Point(36 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                    'objLTTS.Read("18: Diente Ausente.")

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(6 + sX, 50 + sy), New Point(6 + sX, 20 + sy), New Point(36 + sX, 20 + sy), New Point(36 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                    'objLTTS.Read("18: Protesis Removible.")

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 5 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 8 + (sX), 13 + (sy))

                    'objLTTS.Read("18: Incrustacion.")

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(8 + (sX), 21 + (sy)), New Point(35 + (sX), 21 + (sy)), New Point(27 + (sX), 29 + (sy)), New Point(16 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(35 + (sX), 21 + (sy)), New Point(36 + (sX), 49 + (sy)), New Point(28 + (sX), 41 + (sy)), New Point(28 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(35 + (sX), 50 + (sy)), New Point(6 + (sX), 50 + (sy)), New Point(15 + (sX), 42 + (sy)), New Point(28 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(7 + (sX), 49 + (sy)), New Point(7 + (sX), 21 + (sy)), New Point(15 + (sX), 30 + (sy)), New Point(15 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(16 + (sX), 30 + (sy)), New Point(27 + (sX), 30 + (sy)), New Point(27 + (sX), 41 + (sy)), New Point(16 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

                ' ****************** pieza 47
            ElseIf (Me.txtPosX.Text >= 42 + sX And Me.txtPosX.Text <= 72 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 42 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 43 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57 + sX, 20 + sy)
                    Points(1) = New Point(42 + sX, 50 + sy)
                    Points(2) = New Point(72 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(42 + sX, 20 + sy)
                    Points(1) = New Point(72 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(42 + sX, 50 + sy)
                    Points2(1) = New Point(72 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(42 + sX, 35 + sy)
                    Points(1) = New Point(72 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(58 + sX, 20 + sy)
                    Points(1) = New Point(58 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(42 + sX, 20 + sy)
                    Points(1) = New Point(72 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(42 + sX, 50 + sy)
                    Points2(1) = New Point(72 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 38 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))


                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(42 + sX, 30 + sy), New Point(42 + sX, 20 + sy), New Point(72 + sX, 20 + sy), New Point(72 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(42 + sX, 40 + sy), New Point(42 + sX, 50 + sy), New Point(72 + sX, 50 + sy), New Point(72 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(42 + sX, 50 + sy), New Point(42 + sX, 20 + sy), New Point(72 + sX, 20 + sy), New Point(72 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 41 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 44 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(44 + (sX), 21 + (sy)), New Point(71 + (sX), 21 + (sy)), New Point(63 + (sX), 29 + (sy)), New Point(52 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(72 + (sX), 21 + (sy)), New Point(72 + (sX), 49 + (sy)), New Point(64 + (sX), 41 + (sy)), New Point(64 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(71 + (sX), 50 + (sy)), New Point(43 + (sX), 50 + (sy)), New Point(51 + (sX), 42 + (sy)), New Point(64 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(43 + (sX), 49 + (sy)), New Point(43 + (sX), 21 + (sy)), New Point(51 + (sX), 30 + (sy)), New Point(51 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(52 + (sX), 30 + (sy)), New Point(63 + (sX), 30 + (sy)), New Point(63 + (sX), 41 + (sy)), New Point(52 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If



                End If


                'pieza 46

            ElseIf (Me.txtPosX.Text >= 78 + sX And Me.txtPosX.Text <= 109 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 78 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 79 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93 + sX, 20 + sy)
                    Points(1) = New Point(78 + sX, 50 + sy)
                    Points(2) = New Point(109 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(78 + sX, 20 + sy)
                    Points(1) = New Point(108 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(78 + sX, 50 + sy)
                    Points2(1) = New Point(108 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(78 + sX, 35 + sy)
                    Points(1) = New Point(109 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(94 + sX, 20 + sy)
                    Points(1) = New Point(94 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(78 + sX, 20 + sy)
                    Points(1) = New Point(109 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(78 + sX, 50 + sy)
                    Points2(1) = New Point(109 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 74 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(78 + sX, 30 + sy), New Point(78 + sX, 20 + sy), New Point(109 + sX, 20 + sy), New Point(109 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(78 + sX, 40 + sy), New Point(78 + sX, 50 + sy), New Point(109 + sX, 50 + sy), New Point(109 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(78 + sX, 50 + sy), New Point(78 + sX, 20 + sy), New Point(109 + sX, 20 + sy), New Point(109 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 77 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 80 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(80 + (sX), 21 + (sy)), New Point(107 + (sX), 21 + (sy)), New Point(99 + (sX), 29 + (sy)), New Point(88 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(108 + (sX), 21 + (sy)), New Point(108 + (sX), 49 + (sy)), New Point(100 + (sX), 41 + (sy)), New Point(100 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(108 + (sX), 50 + (sy)), New Point(79 + (sX), 50 + (sy)), New Point(87 + (sX), 42 + (sy)), New Point(100 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(79 + (sX), 49 + (sy)), New Point(79 + (sX), 21 + (sy)), New Point(87 + (sX), 30 + (sy)), New Point(87 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(88 + (sX), 30 + (sy)), New Point(99 + (sX), 30 + (sy)), New Point(99 + (sX), 41 + (sy)), New Point(88 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If

                End If

                'pieza 45
            ElseIf (Me.txtPosX.Text >= 115 + sX And Me.txtPosX.Text <= 145 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 115 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 116 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 20 + sy)
                    Points(1) = New Point(115 + sX, 50 + sy)
                    Points(2) = New Point(145 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 20 + sy)
                    Points(1) = New Point(145 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(115 + sX, 50 + sy)
                    Points2(1) = New Point(145 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 35 + sy)
                    Points(1) = New Point(145 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(131 + sX, 20 + sy)
                    Points(1) = New Point(131 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(115 + sX, 20 + sy)
                    Points(1) = New Point(145 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(115 + sX, 50 + sy)
                    Points2(1) = New Point(145 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 111 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(115 + sX, 30 + sy), New Point(115 + sX, 20 + sy), New Point(145 + sX, 20 + sy), New Point(145 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(115 + sX, 40 + sy), New Point(115 + sX, 50 + sy), New Point(145 + sX, 50 + sy), New Point(145 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(115 + sX, 50 + sy), New Point(115 + sX, 20 + sy), New Point(145 + sX, 20 + sy), New Point(145 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 114 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 117 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(117 + (sX), 21 + (sy)), New Point(144 + (sX), 21 + (sy)), New Point(136 + (sX), 29 + (sy)), New Point(125 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(145 + (sX), 21 + (sy)), New Point(145 + (sX), 49 + (sy)), New Point(137 + (sX), 41 + (sy)), New Point(137 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(145 + (sX), 50 + (sy)), New Point(116 + (sX), 50 + (sy)), New Point(124 + (sX), 42 + (sy)), New Point(137 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(116 + (sX), 49 + (sy)), New Point(116 + (sX), 21 + (sy)), New Point(124 + (sX), 30 + (sy)), New Point(124 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(125 + (sX), 30 + (sy)), New Point(136 + (sX), 30 + (sy)), New Point(136 + (sX), 41 + (sy)), New Point(125 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If


                'pieza 44
            ElseIf (Me.txtPosX.Text >= 153 + sX And Me.txtPosX.Text <= 183 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 153 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 154 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 20 + sy)
                    Points(1) = New Point(153 + sX, 50 + sy)
                    Points(2) = New Point(183 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 20 + sy)
                    Points(1) = New Point(183 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(153 + sX, 50 + sy)
                    Points2(1) = New Point(183 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 35 + sy)
                    Points(1) = New Point(183 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(169 + sX, 20 + sy)
                    Points(1) = New Point(169 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(153 + sX, 20 + sy)
                    Points(1) = New Point(183 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(153 + sX, 50 + sy)
                    Points2(1) = New Point(183 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 149 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(153 + sX, 30 + sy), New Point(153 + sX, 20 + sy), New Point(183 + sX, 20 + sy), New Point(183 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(153 + sX, 40 + sy), New Point(153 + sX, 50 + sy), New Point(183 + sX, 50 + sy), New Point(183 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(153 + sX, 50 + sy), New Point(153 + sX, 20 + sy), New Point(183 + sX, 20 + sy), New Point(183 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 152 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 155 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(155 + (sX), 21 + (sy)), New Point(182 + (sX), 21 + (sy)), New Point(174 + (sX), 29 + (sy)), New Point(163 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(183 + (sX), 21 + (sy)), New Point(183 + (sX), 49 + (sy)), New Point(175 + (sX), 41 + (sy)), New Point(175 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(182 + (sX), 50 + (sy)), New Point(154 + (sX), 50 + (sy)), New Point(162 + (sX), 42 + (sy)), New Point(175 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(154 + (sX), 49 + (sy)), New Point(154 + (sX), 21 + (sy)), New Point(162 + (sX), 30 + (sy)), New Point(162 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(163 + (sX), 30 + (sy)), New Point(174 + (sX), 30 + (sy)), New Point(174 + (sX), 41 + (sy)), New Point(163 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If


                'pieza 43
            ElseIf (Me.txtPosX.Text >= 192 + sX And Me.txtPosX.Text <= 222 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 192 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 193 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(207 + sX, 20 + sy)
                    Points(1) = New Point(192 + sX, 50 + sy)
                    Points(2) = New Point(222 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 20 + sy)
                    Points(1) = New Point(222 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(192 + sX, 50 + sy)
                    Points2(1) = New Point(222 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 35 + sy)
                    Points(1) = New Point(222 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(208 + sX, 20 + sy)
                    Points(1) = New Point(208 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(192 + sX, 20 + sy)
                    Points(1) = New Point(222 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(192 + sX, 50 + sy)
                    Points2(1) = New Point(222 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 188 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))


                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(192 + sX, 30 + sy), New Point(192 + sX, 20 + sy), New Point(222 + sX, 20 + sy), New Point(222 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(192 + sX, 40 + sy), New Point(192 + sX, 50 + sy), New Point(222 + sX, 50 + sy), New Point(222 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(192 + sX, 50 + sy), New Point(192 + sX, 20 + sy), New Point(222 + sX, 20 + sy), New Point(222 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 191 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 194 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(194 + (sX), 21 + (sy)), New Point(221 + (sX), 21 + (sy)), New Point(212 + (sX), 29 + (sy)), New Point(202 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(222 + (sX), 21 + (sy)), New Point(222 + (sX), 49 + (sy)), New Point(214 + (sX), 41 + (sy)), New Point(214 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(222 + (sX), 50 + (sy)), New Point(193 + (sX), 50 + (sy)), New Point(201 + (sX), 42 + (sy)), New Point(214 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(193 + (sX), 49 + (sy)), New Point(193 + (sX), 21 + (sy)), New Point(201 + (sX), 30 + (sy)), New Point(201 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(202 + (sX), 30 + (sy)), New Point(213 + (sX), 30 + (sy)), New Point(213 + (sX), 41 + (sy)), New Point(202 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If

                End If


                'pieza 42
            ElseIf (Me.txtPosX.Text >= 229 + sX And Me.txtPosX.Text <= 259 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 229 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 230 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(244 + sX, 20 + sy)
                    Points(1) = New Point(229 + sX, 50 + sy)
                    Points(2) = New Point(259 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 20 + sy)
                    Points(1) = New Point(259 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(229 + sX, 50 + sy)
                    Points2(1) = New Point(259 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 35 + sy)
                    Points(1) = New Point(259 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(245 + sX, 20 + sy)
                    Points(1) = New Point(245 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(229 + sX, 20 + sy)
                    Points(1) = New Point(259 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(229 + sX, 50 + sy)
                    Points2(1) = New Point(259 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 225 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))


                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(229 + sX, 30 + sy), New Point(229 + sX, 20 + sy), New Point(259 + sX, 20 + sy), New Point(259 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(229 + sX, 40 + sy), New Point(229 + sX, 50 + sy), New Point(259 + sX, 50 + sy), New Point(259 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(229 + sX, 50 + sy), New Point(229 + sX, 20 + sy), New Point(259 + sX, 20 + sy), New Point(259 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 228 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 231 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(231 + (sX), 21 + (sy)), New Point(258 + (sX), 21 + (sy)), New Point(250 + (sX), 29 + (sy)), New Point(239 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(259 + (sX), 21 + (sy)), New Point(259 + (sX), 49 + (sy)), New Point(251 + (sX), 41 + (sy)), New Point(251 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(259 + (sX), 50 + (sy)), New Point(229 + (sX), 50 + (sy)), New Point(238 + (sX), 42 + (sy)), New Point(251 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(230 + (sX), 49 + (sy)), New Point(230 + (sX), 21 + (sy)), New Point(238 + (sX), 30 + (sy)), New Point(238 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(239 + (sX), 30 + (sy)), New Point(250 + (sX), 30 + (sy)), New Point(250 + (sX), 41 + (sy)), New Point(239 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

                'pieza 41
            ElseIf (Me.txtPosX.Text >= 267 + sX And Me.txtPosX.Text <= 297 + sX) And (Me.txtPosY.Text >= 20 + sy And Me.txtPosY.Text <= 50 + sy) Then

                If btnProtesisFija.Checked = True Then

                    g.DrawRectangle(oPen, 267 + sX, 20 + sy, 30, 30)

                ElseIf btnCorona.Checked = True Then

                    g.DrawEllipse(oPen, 268 + (sX), 21 + (sy), 28, 28)

                ElseIf btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(282 + sX, 20 + sy)
                    Points(1) = New Point(267 + sX, 50 + sy)
                    Points(2) = New Point(297 + sX, 50 + sy)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnExodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 20 + sy)
                    Points(1) = New Point(297 + sX, 50 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(267 + sX, 50 + sy)
                    Points2(1) = New Point(297 + sX, 20 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnProtesis.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 35 + sy)
                    Points(1) = New Point(297 + sX, 35 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnAusenteEndodoncia.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(283 + sX, 20 + sy)
                    Points(1) = New Point(283 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))

                ElseIf btnExtraccion.Checked = True Then

                    Dim Points(2) As Point
                    Points(0) = New Point(267 + sX, 20 + sy)
                    Points(1) = New Point(297 + sX, 20 + sy)

                    Dim Points2(2) As Point

                    Points2(0) = New Point(267 + sX, 50 + sy)
                    Points2(1) = New Point(297 + sX, 50 + sy)

                    g.DrawLine(oPen, Points(0), Points(1))
                    g.DrawLine(oPen, Points2(0), Points2(1))

                ElseIf btnSuperficieSellada.Checked = True Then

                    Dim letra As New Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("S", letra, oBrush, 263 + (sX), 14 + (sy))

                ElseIf btnPunto.Checked = True Then

                    g.FillEllipse(oBrush, CInt(Me.txtPosX.Text - 2), CInt(Me.txtPosY.Text - 2), 5, 5)

                ElseIf btnRestauracion.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("+", letra, oBrush, CInt(Me.txtPosX.Text - 8), CInt(Me.txtPosY.Text - 8))

                ElseIf btnSuperficieXSellar.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("s", letra, oBrush, CInt(Me.txtPosX.Text - 7), CInt(Me.txtPosY.Text - 10))

                ElseIf btnAmalgama.Checked = True Then

                    Dim letra As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point, 5)
                    g.DrawString("-", letra, oBrush, CInt(Me.txtPosX.Text - 6), CInt(Me.txtPosY.Text - 11))

                ElseIf Me.btnDienteAustente.Checked = True Then

                    Dim points As Point() = {New Point(267 + sX, 30 + sy), New Point(267 + sX, 20 + sy), New Point(297 + sX, 20 + sy), New Point(297 + sX, 30 + sy)}
                    Dim points2 As Point() = {New Point(267 + sX, 40 + sy), New Point(267 + sX, 50 + sy), New Point(297 + sX, 50 + sy), New Point(297 + sX, 40 + sy)}

                    g.DrawLines(oPen, points)
                    g.DrawLines(oPen, points2)

                ElseIf Me.btnProtesisRemovible.Checked = True Then

                    Dim points As Point() = {New Point(267 + sX, 50 + sy), New Point(267 + sX, 20 + sy), New Point(297 + sX, 20 + sy), New Point(297 + sX, 50 + sy)}
                    g.DrawLines(oPen, points)

                ElseIf Me.btnBorrar.Checked = True Then

                    imagenaux = New Bitmap(My.Resources.DienteSolo)
                    g.DrawImage(imagenaux, 266 + (sX), 3 + (sy))

                ElseIf btnIncrustacion.Checked = True Then

                    Dim letra As New Font("Times", 30, FontStyle.Regular, GraphicsUnit.Point, 5)
                    g.DrawString("I", letra, oBrush, 268 + (sX), 13 + (sy))

                ElseIf Me.btnSuperficies.Checked = True Then

                    Dim mousepoint As Point

                    mousepoint.X = Me.txtPosX.Text
                    mousepoint.Y = Me.txtPosY.Text

                    '1 ---------------
                    Dim points As Point() = {New Point(269 + (sX), 21 + (sy)), New Point(296 + (sX), 21 + (sy)), New Point(288 + (sX), 29 + (sy)), New Point(277 + (sX), 29 + (sy))}

                    If insidePolygon(points, mousepoint) = True Then

                        g.FillPolygon(oBrush, points)

                    End If

                    '2 ---------------

                    Dim points2 As Point() = {New Point(297 + (sX), 21 + (sy)), New Point(297 + (sX), 49 + (sy)), New Point(289 + (sX), 41 + (sy)), New Point(289 + (sX), 29 + (sy))}

                    If insidePolygon(points2, mousepoint) = True Then

                        g.FillPolygon(oBrush, points2)

                    End If

                    '3-------------

                    Dim points3 As Point() = {New Point(296 + (sX), 50 + (sy)), New Point(268 + (sX), 50 + (sy)), New Point(276 + (sX), 42 + (sy)), New Point(289 + (sX), 42 + (sy))}

                    If insidePolygon(points3, mousepoint) = True Then

                        g.FillPolygon(oBrush, points3)

                    End If

                    '4-------------

                    Dim points4 As Point() = {New Point(268 + (sX), 49 + (sy)), New Point(268 + (sX), 21 + (sy)), New Point(276 + (sX), 30 + (sy)), New Point(276 + (sX), 41 + (sy))}

                    If insidePolygon(points4, mousepoint) = True Then

                        g.FillPolygon(oBrush, points4)

                    End If

                    '5 -------------

                    Dim points5 As Point() = {New Point(277 + (sX), 30 + (sy)), New Point(288 + (sX), 30 + (sy)), New Point(288 + (sX), 41 + (sy)), New Point(277 + (sX), 41 + (sy))}

                    If insidePolygon(points5, mousepoint) = True Then

                        g.FillPolygon(oBrush, points5)

                    End If


                End If

            End If

            Me.pbxOdontograma.Image = imagenfinal


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub dibujardientetemporalsupizq(ByVal sX As Integer, ByVal sy As Integer)

        Try

            Dim rectangulo As Rectangle = New Rectangle(0, 0, 628, 254)
            Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

            Dim g As Graphics = Graphics.FromImage(imagenfinal)

            imagenfondo = New Bitmap(My.Resources.fondoplantilla)
            g.DrawImage(imagenfondo, 0, 0, 628, 254)

            odontograma = New Bitmap(Me.pbxOdontograma.Image)
            g.DrawImage(odontograma, 0, 0, 628, 254)

            'Lapiz
            Dim oPen As New Pen(Me.colorButton.SelectedColor, 2)
            oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

            'Brocha
            Dim oBrush As New SolidBrush(Me.colorButton.SelectedColor)


            'Pieza 18
            If (Me.txtPosX.Text >= 6 + sX And Me.txtPosX.Text <= 36 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then


                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21 + sX, 6 + sy)
                    Points(1) = New Point(10 + sX, 20 + sy)
                    Points(2) = New Point(32 + sX, 20 + sy)

                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)


                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(21 + sX, 6 + sy)
                    Points(1) = New Point(10 + sX, 20 + sy)
                    Points(2) = New Point(32 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If


                'pieza 17
            ElseIf (Me.txtPosX.Text >= 42 + sX And Me.txtPosX.Text <= 72 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57 + sX, 6 + sy)
                    Points(1) = New Point(46 + sX, 20 + sy)
                    Points(2) = New Point(68 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(57 + sX, 6 + sy)
                    Points(1) = New Point(46 + sX, 20 + sy)
                    Points(2) = New Point(68 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 16

            ElseIf (Me.txtPosX.Text >= 78 + sX And Me.txtPosX.Text <= 109 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93 + sX, 6 + sy)
                    Points(1) = New Point(82 + sX, 20 + sy)
                    Points(2) = New Point(105 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(93 + sX, 6 + sy)
                    Points(1) = New Point(82 + sX, 20 + sy)
                    Points(2) = New Point(105 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If


                'pieza 15
            ElseIf (Me.txtPosX.Text >= 115 + sX And Me.txtPosX.Text <= 145 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 6 + sy)
                    Points(1) = New Point(119 + sX, 20 + sy)
                    Points(2) = New Point(141 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(130 + sX, 6 + sy)
                    Points(1) = New Point(119 + sX, 20 + sy)
                    Points(2) = New Point(141 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

                'pieza 14
            ElseIf (Me.txtPosX.Text >= 153 + sX And Me.txtPosX.Text <= 183 + sX) And (Me.txtPosY.Text >= 0 + sy And Me.txtPosY.Text <= 20 + sy) Then

                If btnNucleo.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 6 + sy)
                    Points(1) = New Point(157 + sX, 20 + sy)
                    Points(2) = New Point(179 + sX, 20 + sy)
                    g.FillPolygon(Brushes.White, Points)
                    g.DrawPolygon(oPen, Points)

                ElseIf btnEndodoncia.Checked = True Then

                    Dim Points(2) As Point

                    Points(0) = New Point(168 + sX, 6 + sy)
                    Points(1) = New Point(157 + sX, 20 + sy)
                    Points(2) = New Point(179 + sX, 20 + sy)

                    g.FillPolygon(oBrush, Points)

                End If

            End If

            Me.pbxOdontograma.Image = imagenfinal

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub


    '******************************************************************************

    Private Sub pbxOdontograma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxOdontograma.Click

        'ARCOS PERMANENTES
        ArcoSuperiorDerecho_Permanente()
        ArcoSuperiorDerecho_Permanente_AreaSuperior()

        ArcoInferiorDerecho_Permanente()
        ArcoInferiorDerecho_Permanente_AreaSuperior()

        ArcoSuperiorIzquierdo_Permanente()
        ArcoSuperiorIzquierdo_Permanente_AreaSuperior()

        ArcoInferiorIzquierdo_Permanente()
        ArcoInferiorIzquierdo_Permanente_AreaSuperior()

        'ARCOS TEMPORALES
        ArcoSuperiorDerecho_Temporal()
        ArcoSuperiorDerecho_Temporal_AreaSuperior()

        ArcoInferiorDerecho_Temporal()
        ArcoInferiorDerecho_Temporal_AreaSuperior()

        ArcoSuperiorIzquierdo_Temporal()
        ArcoSuperiorIzquierdo_Temporal_AreaSuperior()

        ArcoInferiorIzquierdo_Temporal()
        ArcoInferiorIzquierdo_Temporal_AreaSuperior()


    End Sub

    Private Sub pbxOdontograma_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbxOdontograma.MouseDown

        m_Drawing = True

        m_LastX = e.X
        m_LastY = e.Y

    End Sub

    Private Sub pbxOdontograma_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbxOdontograma.MouseMove

        Me.txtPosX.Text = e.X.ToString
        Me.txtPosY.Text = e.Y.ToString

        If Me.btnLapiz.Checked = True Then


            If m_Drawing Then

                'Lapiz
                Dim oPen As New Pen(Me.colorButton.SelectedColor, 1)
                oPen.DashStyle = Drawing.Drawing2D.DashStyle.Solid

                ' Draw the new line.
                m_Graphics.DrawLine(oPen, m_LastX, m_LastY, e.X, e.Y)

                ' Display the result.
                pbxOdontograma.Image = m_Bitmap

                ' Save the latest point.
                m_LastX = e.X
                m_LastY = e.Y

            End If

        End If


    End Sub

    Private Sub frmOdontogramaGrafico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.colorButton.SelectedColor = Color.Blue
        Me.cmbGaleria.SelectedIndex = 0

        cargarodontograma()

    End Sub

    Private Sub btnProtesisFija_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProtesisFija.Click

        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnProtesisFija.Checked = True

        'Desactivamos los otros botones
        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False


    End Sub

    Private Sub btnCorona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorona.Click

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnCorona.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnNucleo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNucleo.Click

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnNucleo.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnExodoncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExodoncia.Click

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnExodoncia.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False


    End Sub

    Private Sub btnProtesis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProtesis.Click

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnProtesis.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnAusenteEndodoncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAusenteEndodoncia.Click

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAusenteEndodoncia.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False


    End Sub

    Private Sub btnExtraccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtraccion.Click

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnExtraccion.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False


    End Sub

    Private Sub btnSuperficieSellada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuperficieSellada.Click

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnSuperficieSellada.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False


    End Sub

    Private Sub btnSuperficieXSellar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuperficieXSellar.Click

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnSuperficieXSellar.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnPunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunto.Click

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnPunto.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False


    End Sub

    Private Sub btnRestauracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestauracion.Click

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnRestauracion.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnAmalgama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmalgama.Click

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnAmalgama.Checked = True


        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnDienteAustente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDienteAustente.Click

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnDienteAustente.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnProtesisRemovible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProtesisRemovible.Click

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnProtesisRemovible.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnEndodoncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndodoncia.Click

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnEndodoncia.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnBorrar.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnSuperficies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuperficies.Click

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnSuperficies.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnLapiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLapiz.Click

        AllocateBitmap()

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnLapiz.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnIncrustacion.Checked = False

    End Sub

    Private Sub btnIncrustacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncrustacion.Click

        Me.btnIncrustacion.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnIncrustacion.Checked = True

        'Desactivamos los otros botones
        Me.btnProtesisFija.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisFija.Checked = False

        Me.btnCorona.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnCorona.Checked = False

        Me.btnNucleo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnNucleo.Checked = False

        Me.btnExodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExodoncia.Checked = False

        Me.btnProtesis.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesis.Checked = False

        Me.btnAusenteEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAusenteEndodoncia.Checked = False

        Me.btnExtraccion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnExtraccion.Checked = False

        Me.btnSuperficieSellada.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieSellada.Checked = False

        Me.btnSuperficieXSellar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficieXSellar.Checked = False

        Me.btnPunto.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnPunto.Checked = False

        Me.btnRestauracion.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnRestauracion.Checked = False

        Me.btnAmalgama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnAmalgama.Checked = False

        Me.btnDienteAustente.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnDienteAustente.Checked = False

        Me.btnProtesisRemovible.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnProtesisRemovible.Checked = False

        Me.btnEndodoncia.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnEndodoncia.Checked = False

        Me.btnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnBorrar.Checked = False

        Me.btnSuperficies.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSuperficies.Checked = False

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            OGRAMA = New CLASE_OGRAMA
            GENE = New CLASE_GENERAL

            OGRAMA.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            OGRAMA.p_fecha_ograma = Format(Date.Now, "yyyy-MM-dd")

            If Not Me.pbxOdontograma.Image Is Nothing Then

                OGRAMA.p_ograma_inicial = GENE.Imagen_Bytes(Me.pbxOdontograma.Image)

            End If

            OGRAMA.p_observacionograma_ini = Me.RichTxtMensaje.Text

            If Not Me.pbxOdontograma.Image Is Nothing Then

                OGRAMA.p_ograma_actual = GENE.Imagen_Bytes(Me.pbxOdontograma.Image)

            End If

            OGRAMA.p_observacionograma_act = Me.RichTxtMensaje.Text


            contar = 0
            contar = CLASE_GENERAL.contar2("IdUsuario", "ograma", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

            If contar > 0 Then

                If Me.cmbGaleria.SelectedIndex = 0 Then

                    If Not Me.pbxOdontograma.Image Is Nothing Then

                        OGRAMA.Modificar("ograma_inicial")

                    End If

                Else

                    If Not Me.pbxOdontograma.Image Is Nothing Then

                        OGRAMA.Modificar("ograma_actual")

                    End If

                End If


            Else

                OGRAMA.Insertar(CLASE_GENERAL.mensaje_error)

            End If

            OGRAMA.dispose()
            OGRAMA = Nothing

            GENE = Nothing

            Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
            Me.btnLapiz.Checked = False

            MsgBox("Registro Guardado con Exito", MsgBoxStyle.OkOnly, "Odontograma")

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub cargarodontograma()

        Try

            contar = 0
            contar = CLASE_GENERAL.contar2("IdUsuario", "ograma", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

            If contar > 0 Then

                GENE = New CLASE_GENERAL
                OGRAMA = New CLASE_OGRAMA

                OGRAMA.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                If Me.cmbGaleria.SelectedIndex = 0 Then

                    OGRAMA.Seleccionar("ograma_inicial")

                    If Not (CLASE_OGRAMA.xograma_inicial.Length = 0) Then

                        iImagen = GENE.Bytes_Imagen(CLASE_OGRAMA.xograma_inicial)
                        Me.pbxOdontograma.Image = iImagen
                        Me.RichTxtMensaje.Text = CLASE_OGRAMA.xobservacionograma_ini

                    Else

                        pbxOdontograma.Image = My.Resources.OdontoIni


                    End If

                Else

                    OGRAMA.Seleccionar("ograma_actual")

                    If Not (CLASE_OGRAMA.xograma_actual.Length = 0) Then

                        iImagen = GENE.Bytes_Imagen(CLASE_OGRAMA.xograma_actual)
                        Me.pbxOdontograma.Image = iImagen
                        Me.RichTxtMensaje.Text = CLASE_OGRAMA.xobservacionograma_act

                    Else

                        pbxOdontograma.Image = My.Resources.OdontoIni

                    End If

                End If

                OGRAMA.dispose()
                OGRAMA = Nothing

            Else

                pbxOdontograma.Image = My.Resources.OdontoIni

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbGaleria_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGaleria.SelectionChangeCommitted

        cargarodontograma()

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        pbxOdontograma.Image = My.Resources.OdontoIni
        Me.RichTxtMensaje.Text = ""

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

    End Sub

    Private Function insidePolygon(ByVal pointList() As Point, ByVal p As Point) As Boolean

        Dim counter As Integer = 0
        Dim i As Integer
        Dim xinters As Integer
        Dim p1 As Point
        Dim p2 As Point
        Dim n As Integer = pointList.Length

        p1 = pointList(0)

        For i = 1 To n
            p2 = pointList(i Mod n)
            If p.Y > Math.Min(p1.Y, p2.Y) Then
                If p.Y <= Math.Max(p1.Y, p2.Y) Then
                    If p.X <= Math.Max(p1.X, p2.X) Then
                        If p1.Y <> p2.Y Then
                            xinters = (p.Y - p1.Y) * (p2.X - p1.X) / (p2.Y - p1.Y) + p1.X
                            If p1.X = p2.X OrElse p.X <= xinters Then
                                counter += 1
                            End If
                        End If
                    End If
                End If
            End If
            p1 = p2
        Next

        If (counter Mod 2 = 0) Then
            Return (False)
        Else
            Return (True)
        End If


    End Function

    Private Sub pbxOdontograma_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbxOdontograma.MouseUp

        m_Drawing = False

    End Sub

    Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click

        cargarodontograma()

        Me.btnLapiz.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnLapiz.Checked = False

    End Sub

    Private Sub btnConvensiones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvensiones.Click

        My.Forms.FrmConvensiones.Show()

    End Sub

End Class