Imports System.Math
Imports System.IO

Public Class frmImagenes

    'Variables de Clases
    Private GENE As CLASE_GENERAL
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

    Private Sub VScrollBarGaleria_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBarGaleria.Scroll

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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try

            GENE = New CLASE_GENERAL

            GALERIA = New CLASE_GALERIA
            GALERIA.p_IdImagen = Me.cmbGaleria.SelectedValue

            If Not Me.pbxGaleria.Image Is Nothing Then

                GALERIA.p_Imagen_img = GENE.Imagen_Bytes(Me.pbxGaleria.Image)
                Me.btnBorrarGaleria.Enabled = True

            End If

            If Not (Me.cmbGaleria.Items.Count = 0) Then

                GALERIA.Modificar("imagen")

            End If

            GALERIA.dispose()
            GALERIA = Nothing

            GENE = Nothing

            MsgBox("Registro Guardado con Exito", MsgBoxStyle.OkOnly, "Ilustraciones")


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnBorrarGaleria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarGaleria.Click

        Try

            If Not (Me.cmbGaleria.Items.Count = 0) Then

                GALERIA = New CLASE_GALERIA
                GALERIA.p_IdImagen = Me.cmbGaleria.SelectedValue
                GALERIA.Eliminar(CLASE_GENERAL.mensaje_error)

                pbxGaleria.Image = Nothing

                Me.btnBorrarGaleria.Enabled = False

                CLASE_GENERAL.cargar_combo("galeriageneral", Me.cmbGaleria, CLASE_GENERAL.mensaje_error)

                GALERIA.dispose()
                GALERIA = Nothing

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

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

    Private Sub frmImagenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            tabcontrol = 1

            GENE = New CLASE_GENERAL

            ' REGISTRO pARA LA GALERIA

            CLASE_GENERAL.cargar_combo("galeriageneral", Me.cmbGaleria, CLASE_GENERAL.mensaje_error)
            cargargaleria()

            'Drag Drop Pictures

            pbxGaleria.AllowDrop = True

            GENE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnComposicionGaleria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComposicionGaleria.Click

        frmComposicion.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        frmComposicion.Show()
        frmComposicion.Activate()

        CLASE_GENERAL.formload = 17

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

    Private Sub pbxGaleria_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxGaleria.DragDrop

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

            VScrollBarGaleria.Enabled = True

        End If

    End Sub

    Private Sub pbxGaleria_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pbxGaleria.DragEnter

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

        'Botones Iniciales
        ubicarcontrol(Me.btnAbrirExplorer)
        ubicarcontrol(Me.btnGuardar)
        ubicarcontrol(Me.btnSalir)

        'Galeria
        ubicarcontrol(Me.lblGaleria)
        ubicarcontrol(Me.gpGaleria)
        ubicarcontrol(Me.pbxGaleria)
        ubicarcontrol(Me.VScrollBarGaleria)
        ubicarcontrol(Me.btnComposicionGaleria)
        ubicarcontrol(Me.btnBorrarGaleria)

    End Sub


    Private Sub frmImagenes_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ubicarcontroles()
    End Sub

    Private Sub btnGrabarGaleria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarGaleria.Click


        Try

            GALERIA = New CLASE_GALERIA
            GALERIA.p_IdImagen = (CLASE_GENERAL.maximo("IdImagen", "galeria", CLASE_GENERAL.mensaje_error)) + 1
            GALERIA.p_IdTipo_img = 2 '1 Personal 2 General
            GALERIA.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            GALERIA.p_descripcion_img = Me.txtdescripcion_img.Text
            GALERIA.Insertar(CLASE_GENERAL.mensaje_error)

            CLASE_GENERAL.cargar_combo("galeriageneral", Me.cmbGaleria, CLASE_GENERAL.mensaje_error)
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

    Private Sub cmbGaleria_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGaleria.SelectionChangeCommitted

        cargargaleria()

    End Sub

End Class