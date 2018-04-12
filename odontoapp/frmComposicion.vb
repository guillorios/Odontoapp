Imports System.Math

Public Class frmComposicion

    'Variables de Control
    Private nombreImg As String = ""
    Private tabcontrol As Integer = 0
    Private picturecontrol As Integer = 0

    'Variables de las Imagenes
    Private imagen1 As Bitmap
    Private imagen2 As Bitmap
    Private imagen3 As Bitmap
    Private imagen4 As Bitmap
    Private imagen5 As Bitmap
    Private imagen6 As Bitmap
    Private imagen7 As Bitmap
    Private imagen8 As Bitmap

    'Variables de composicion
    Private imagenfondo As Bitmap
    Private imagenlogo As Bitmap

    'Variables de Clases
    Private CONSUL As CLASE_CONSULTORIO
    Private GENE As CLASE_GENERAL
    Private PAC As CLASE_PACIENTES

    'Variable de Imagen Base de datos
    Private iImagen As Image

    Private Sub frmComposicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            CONSUL = New CLASE_CONSULTORIO
            GENE = New CLASE_GENERAL

            CONSUL.p_Idconsultorio = 1
            CONSUL.Seleccionar("imagenesconsultorio")

            If Not (CLASE_CONSULTORIO.xicono_cons.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xicono_cons)
                pbComplogo.Image = iImagen
                pbComplogo.SizeMode = PictureBoxSizeMode.Zoom

            End If

            'Funciones para habilitar drag drop

            'Drag Drop Pictures

            pbComp1.AllowDrop = True
            pbComp2.AllowDrop = True
            pbComp3.AllowDrop = True
            pbComp4.AllowDrop = True
            pbComp5.AllowDrop = True
            pbComp6.AllowDrop = True
            pbComp7.AllowDrop = True
            pbComp8.AllowDrop = True


            CONSUL.dispose()
            CONSUL = Nothing
            GENE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnBorrarCom1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom1.Click

        pbComp1.Image.Dispose()
        pbComp1.Image = Nothing

        Me.btnBorrarCom1.Enabled = False


    End Sub

    Private Sub btnBorrarCom2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom2.Click

        pbComp2.Image.Dispose()
        pbComp2.Image = Nothing

        Me.btnBorrarCom2.Enabled = False

    End Sub

    Private Sub btnBorrarCom3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom3.Click

        pbComp3.Image.Dispose()
        pbComp3.Image = Nothing

        Me.btnBorrarCom3.Enabled = False

    End Sub

    Private Sub btnBorrarCom4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom4.Click

        pbComp4.Image.Dispose()
        pbComp4.Image = Nothing

        Me.btnBorrarCom4.Enabled = False

    End Sub

    Private Sub btnBorrarCom5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom5.Click

        pbComp5.Image.Dispose()
        pbComp5.Image = Nothing

        Me.btnBorrarCom5.Enabled = False

    End Sub

    Private Sub btnBorrarCom6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom6.Click

        pbComp6.Image.Dispose()
        pbComp6.Image = Nothing

        Me.btnBorrarCom6.Enabled = False

    End Sub

    Private Sub btnBorrarCom7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom7.Click

        pbComp7.Image.Dispose()
        pbComp7.Image = Nothing

        Me.btnBorrarCom7.Enabled = False

    End Sub

    Private Sub btnBorrarCom8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCom8.Click

        pbComp8.Image.Dispose()
        pbComp8.Image = Nothing

        Me.btnBorrarCom8.Enabled = False

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        Dim rectangulo As Rectangle = New Rectangle(0, 0, 508, 405)
        Dim imagenfinal As Bitmap = New Bitmap(rectangulo.Width, rectangulo.Height)

        Dim g As Graphics = Graphics.FromImage(imagenfinal)

        imagenfondo = New Bitmap(My.Resources.fondoplantilla)
        g.DrawImage(imagenfondo, 0, 0, 550, 408)


        If CLASE_GENERAL.formload = 17 Then

            If Not Me.pbComp1.Image Is Nothing Then

                imagen1 = New Bitmap(Me.pbComp1.Image)
                g.DrawImage(imagen1, 10, 10, 160, 140)

            End If

            If Not Me.pbComp2.Image Is Nothing Then
                imagen2 = New Bitmap(Me.pbComp2.Image)
                g.DrawImage(imagen2, 175, 10, 160, 140)
            End If


            If Not Me.pbComp3.Image Is Nothing Then
                imagen3 = New Bitmap(Me.pbComp3.Image)
                g.DrawImage(imagen3, 340, 10, 160, 140)
            End If

        Else

            ' Para Agregar datos de los pacientes


            PAC = New CLASE_PACIENTES
            PAC.p_IdPaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            PAC.Seleccionar("pacientes")

            g.DrawString("Nombre Paciente : " & CLASE_PACIENTES.xnombres_pac & " " & CLASE_PACIENTES.xapellidos_pac & " " & "Documento No. : " & CLASE_PACIENTES.xnumdoc_pac & " " & "No. Historia Clinica : " & CLASE_PACIENTES.xnhclinica, New Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point, 2), Brushes.Black, 10, 10)
            g.DrawString("Nombre Doctor : " & My.Forms.mdiOrthoSoft.lblActivoDoctor.Text, New Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point, 2), Brushes.Black, 10, 20)

            PAC.dispose()
            PAC = Nothing

            If Not Me.pbComp1.Image Is Nothing Then

                imagen1 = New Bitmap(Me.pbComp1.Image)
                g.DrawImage(imagen1, 10, 40, 160, 110)

            End If

            If Not Me.pbComp2.Image Is Nothing Then
                imagen2 = New Bitmap(Me.pbComp2.Image)
                g.DrawImage(imagen2, 175, 40, 160, 110)
            End If


            If Not Me.pbComp3.Image Is Nothing Then
                imagen3 = New Bitmap(Me.pbComp3.Image)
                g.DrawImage(imagen3, 340, 40, 160, 110)
            End If


        End If
        
        If Not Me.pbComp4.Image Is Nothing Then
            imagen4 = New Bitmap(Me.pbComp4.Image)
            g.DrawImage(imagen4, 10, 170, 160, 100)
        End If

        If Not Me.pbComplogo.Image Is Nothing Then
            imagenlogo = New Bitmap(Me.pbComplogo.Image)
            g.DrawImage(imagenlogo, 210, 170, 100, 100)
           
        End If

        If Not Me.pbComp5.Image Is Nothing Then
            imagen5 = New Bitmap(Me.pbComp5.Image)
            g.DrawImage(imagen5, 340, 170, 160, 100)
        End If

        If Not Me.pbComp6.Image Is Nothing Then
            imagen6 = New Bitmap(Me.pbComp6.Image)
            g.DrawImage(imagen6, 10, 290, 160, 100)
        End If

        If Not Me.pbComp7.Image Is Nothing Then
            imagen7 = New Bitmap(Me.pbComp7.Image)
            g.DrawImage(imagen7, 175, 290, 160, 100)
        End If

        If Not Me.pbComp8.Image Is Nothing Then
            imagen8 = New Bitmap(Me.pbComp8.Image)
            g.DrawImage(imagen8, 340, 290, 160, 100)
        End If

        g.Dispose()



        If CLASE_GENERAL.formload = 11 Then


            My.Forms.frmEstudios.pbxImg1.Image = imagenfinal
            My.Forms.frmEstudios.pbxImg1.SizeMode = PictureBoxSizeMode.Zoom

            My.Forms.frmEstudios.VScrollBar1.Enabled = True


        ElseIf CLASE_GENERAL.formload = 12 Then


            My.Forms.frmEstudios.pbxImgEv1.Image = imagenfinal
            My.Forms.frmEstudios.pbxImgEv1.SizeMode = PictureBoxSizeMode.Zoom

            My.Forms.frmEstudios.VScrollBarEv.Enabled = True

        ElseIf CLASE_GENERAL.formload = 13 Then


            My.Forms.frmEstudios.pbxImgEv2.Image = imagenfinal
            My.Forms.frmEstudios.pbxImgEv2.SizeMode = PictureBoxSizeMode.Zoom

            My.Forms.frmEstudios.VScrollBarEv.Enabled = True

        ElseIf CLASE_GENERAL.formload = 14 Then


            My.Forms.frmEstudios.pbxImgEv3.Image = imagenfinal
            My.Forms.frmEstudios.pbxImgEv3.SizeMode = PictureBoxSizeMode.Zoom

            My.Forms.frmEstudios.VScrollBarEv.Enabled = True


        ElseIf CLASE_GENERAL.formload = 15 Then


            My.Forms.frmEstudios.pbxImg3.Image = imagenfinal
            My.Forms.frmEstudios.pbxImg3.SizeMode = PictureBoxSizeMode.Zoom

            My.Forms.frmEstudios.VScrollBar3.Enabled = True

        ElseIf CLASE_GENERAL.formload = 16 Then

            My.Forms.frmEstudios.pbxGaleria.Image = imagenfinal
            My.Forms.frmEstudios.pbxGaleria.SizeMode = PictureBoxSizeMode.Zoom

            My.Forms.frmEstudios.VScrollBarGaleria.Enabled = True

        ElseIf CLASE_GENERAL.formload = 17 Then

            My.Forms.frmImagenes.pbxGaleria.Image = imagenfinal
            My.Forms.frmImagenes.pbxGaleria.SizeMode = PictureBoxSizeMode.Zoom

            My.Forms.frmImagenes.VScrollBarGaleria.Enabled = True


        End If

        My.Forms.frmEstudios.btnGuardar.Enabled = True


        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub pbComp1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp1.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp1.ImageLocation = str
            pbComp1.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom1.Enabled = True

        End If

    End Sub

    Private Sub pbComp1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp1.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbComp2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp2.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp2.ImageLocation = str
            pbComp2.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom2.Enabled = True

        End If

    End Sub

    Private Sub pbComp2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp2.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbComp3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp3.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp3.ImageLocation = str
            pbComp3.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom3.Enabled = True

        End If


    End Sub

    Private Sub pbComp3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp3.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbComp4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp4.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp4.ImageLocation = str
            pbComp4.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom4.Enabled = True

        End If

    End Sub

    Private Sub pbComp4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp4.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbComp5_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp5.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp5.ImageLocation = str
            pbComp5.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom5.Enabled = True

        End If

    End Sub

    Private Sub pbComp5_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp5.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbComp6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp6.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp6.ImageLocation = str
            pbComp6.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom6.Enabled = True

        End If

    End Sub

    Private Sub pbComp6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp6.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbComp7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp7.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp7.ImageLocation = str
            pbComp7.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom7.Enabled = True

        End If

    End Sub

    Private Sub pbComp7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp7.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub pbComp8_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp8.DragDrop

        Dim picstr() As String
        Dim str As String

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            picstr = e.Data.GetData(DataFormats.FileDrop)
            str = picstr(0)
            pbComp8.ImageLocation = str
            pbComp8.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGuardar.Enabled = True
            Me.btnBorrarCom8.Enabled = True

        End If

    End Sub

    Private Sub pbComp8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbComp8.DragEnter

        e.Effect = e.AllowedEffect

    End Sub

    Private Sub btnAbrirExplorer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirExplorer.Click

        Process.Start("explorer.exe", "/n,::{20D04FE0-3AEA-1069-A2D8-08002B30309D}")

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

        ubicarcontrol(Me.lblComp1)
        ubicarcontrol(Me.lblComp2)
        ubicarcontrol(Me.lblComp3)
        ubicarcontrol(Me.lblComp4)
        ubicarcontrol(Me.lblComp5)
        ubicarcontrol(Me.lblComp6)
        ubicarcontrol(Me.lblComp7)
        ubicarcontrol(Me.lblComp8)

        ubicarcontrol(Me.pbComp1)
        ubicarcontrol(Me.pbComp2)
        ubicarcontrol(Me.pbComp3)
        ubicarcontrol(Me.pbComp4)
        ubicarcontrol(Me.pbComp5)
        ubicarcontrol(Me.pbComp6)
        ubicarcontrol(Me.pbComp7)
        ubicarcontrol(Me.pbComp8)

        ubicarcontrol(Me.btnBorrarCom1)
        ubicarcontrol(Me.btnBorrarCom2)
        ubicarcontrol(Me.btnBorrarCom3)
        ubicarcontrol(Me.btnBorrarCom4)
        ubicarcontrol(Me.btnBorrarCom5)
        ubicarcontrol(Me.btnBorrarCom6)
        ubicarcontrol(Me.btnBorrarCom7)
        ubicarcontrol(Me.btnBorrarCom8)

        ubicarcontrol(Me.pbComplogo)

        ubicarcontrol(Me.btnAbrirExplorer)
        ubicarcontrol(Me.btnGuardar)
        ubicarcontrol(Me.btnSalir)


    End Sub

    Private Sub frmComposicion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class