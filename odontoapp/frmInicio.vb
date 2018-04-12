Imports System.Math

Public Class frmInicio

    'Variables de clase
    Private CONSUL As CLASE_CONSULTORIO
    Private GENE As CLASE_GENERAL

    'Variables para imagenes
    Private nombreImg As String = ""
    Private iImagen As Image

    'Variables de Control
    Private bandera As Integer = 1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'Cuando el tiempo del timer se termina se cierra el control y liberamos recuroso
        Me.pbPortada.Image.Dispose()
        Me.pbPortada.Image = Nothing

        Me.Dispose()
        Me.Close()
        Me.Timer1.Stop()

    End Sub

    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Timer1.Start()


        Try

            'Cargamos la imagen de portada desde la Base de datos
            CONSUL = New CLASE_CONSULTORIO
            GENE = New CLASE_GENERAL

            CONSUL.p_Idconsultorio = 1
            CONSUL.Seleccionar("imagenesconsultorio")

            'Verificamos que exista una imagen en el registro de la BD
            If Not (CLASE_CONSULTORIO.xportada_cons.Length = 0) Then

                iImagen = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xportada_cons)
                Me.pbPortada.Image = iImagen
                Me.pbPortada.SizeMode = PictureBoxSizeMode.StretchImage

            End If

            'Liberamos recursos
            CONSUL.dispose()
            CONSUL = Nothing
            GENE = Nothing


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
        desplazamiento = Round((CInt(My.Forms.mdiOrthoSoft.PanelFicha.Width) - 538) / 2, 0)

        locationcontrolx = control.Location.X
        locationcontroly = control.Location.Y

        'Ubicamos el control sumandole la posisicion actual mas el desplazamiento calculado
        proporcionh = locationcontrolx + desplazamiento
        proporcionv = locationcontroly
        control.Location = New System.Drawing.Point(proporcionh, proporcionv)

    End Sub

    Public Sub ubicarcontroles()

        'lblTituloVentana
        ubicarcontrol(Me.pbPortada)

    End Sub

    Private Sub frmInicio_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class