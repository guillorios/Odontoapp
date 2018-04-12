Public Class frmIngreso

    Inherits System.Windows.Forms.Form

    Private res As Integer
    Private cont As Byte
    Private biometrico As Boolean

    'Variable de Clases
    Private EVEN As CLASE_EVENTOS
    Private EMP As CLASE_EMPLEADOS
    Private CONSUL As CLASE_CONSULTORIO
    Private REGISTRO As CLASE_REGISTRO
    Private GENE As CLASE_GENERAL
    Private ASIGNAR_PERFILES As CLASE_ASIGNAR_PERFILES
    Public HUELLA As CLASE_HUELLAS


    Private mINI As New cIniArray
    Private sFicINI As String

    Private nombreImg As String = ""
    Private iImagen As Image

    Public Usuario As String = ""
    Public Codigo As String = ""

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

    Private Sub OnDataChange()
        ExchangeData(False)
    End Sub

    Private Sub ExchangeData(ByVal read As Boolean)

        Data.EnrolledFingersMask = 0
        Data.MaxEnrollFingerCount = 10
        Data.IsEventHandlerSucceeds = True
        Data.Update()

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
            HUELLA.p_IdTUsuario = 3 ' Tipo usuario
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

    Private Sub cargarinicio()

        Try

            If Me.chkRecuperarSettings.Checked Then

                Usuario = My.Settings.GetPreviousVersion("Usuario").ToString
                Codigo = My.Settings.GetPreviousVersion("Codigo").ToString

            Else

                Usuario = My.Settings.Usuario
                Codigo = My.Settings.Codigo

            End If

            'Verificamos el registro del Serial
            REGISTRO = New CLASE_REGISTRO
            'sFicINI = Application.StartupPath & "\config.ini"

            ' Estas variables nos indican tanto el codigo de activacion que es el serial del disco duro del usuario
            ' El codigo de Registro lo genera el algoritmo y lo compara con el que se suministra

            Dim codigoactivacion As String
            Dim codigoderegistro As String

            codigoactivacion = REGISTRO.CodigoActivacion() 'Aqui generamos el serial del disco duro como codigo de activacion
            codigoderegistro = Codigo

            'Comparamos los dos registros si son iguales el programa inicia de lo contrario debemos introducir el registro valido
            If codigoderegistro = REGISTRO.GenerarClave(codigoactivacion) Then

                ' Desactivamos el Boton del registro
                btnRegistro.Visible = False

                'Cargamos en las variables la autenticación del servidor
                CLASE_GENERAL.configuracion(CLASE_GENERAL.mensaje_error)

                'Iniciamos la Base de datos
                If CLASE_GENERAL.iniciar(CLASE_GENERAL.mensaje_error, "server=" & CLASE_GENERAL.Servidor & ";database=" & CLASE_GENERAL.BD & ";user id=" & CLASE_GENERAL.Usuario & ";Password=" & CLASE_GENERAL.Clave & ";") Then

                    'Cargamos las Imagenes del Programa 

                    CONSUL = New CLASE_CONSULTORIO
                    GENE = New CLASE_GENERAL

                    CONSUL.p_Idconsultorio = 1
                    CONSUL.Seleccionar("imagenesconsultorio")

                    If Not (CLASE_CONSULTORIO.xinicio_cons.Length = 0) Then

                        iImagen = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xinicio_cons)
                        Me.pbFondoVentana.Image = iImagen
                        Me.pbFondoVentana.SizeMode = PictureBoxSizeMode.StretchImage

                    End If

                    CONSUL.dispose()
                    CONSUL = Nothing
                    GENE = Nothing

                    ' Verificamos la OpcionINI 1 o 0 del Archivo de Configuracion nos indica si es primera vez que se ejecuta el programa y abrimos la configuracion de la clinica

                    If CLASE_GENERAL.OpcionINI = 0 Then

                        My.Forms.frmConfiguraciones.Show()
                        My.Forms.frmConfiguraciones.Activate()
                        My.Forms.frmConfiguraciones.StartPosition = FormStartPosition.CenterScreen
                        My.Forms.frmConfiguraciones.btnAdicionar.Visible = True

                    Else

                        'De lo contrario Cargamos los datos de los empleados para la entrada
                        CLASE_GENERAL.cargar_combo("empleados", Me.cmbEmpleados, CLASE_GENERAL.mensaje_error)

                    End If


                Else

                    ' Si existe problemas de conexion abrimos la venatan de configuracion de servidores
                    My.Forms.frmAutenticacion.StartPosition = FormStartPosition.CenterScreen
                    My.Forms.frmAutenticacion.Show()
                    My.Forms.frmAutenticacion.Activate()

                End If

            Else

                ' Desactivamos el Boton del registro
                btnRegistro.Visible = True

                MsgBox("Aun no ha registrado la aplicacion solicite un codigo de registro por favor ....", MsgBoxStyle.Critical, "Entrada al Sistema")
                Me.Visible = False
                My.Forms.frmRegistro.Show()

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub frmIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            If My.Settings.Llave Then


                If CLASE_HARDKEY.IConexion() = "00000" Then

                    cargarinicio()

                Else

                    MessageBox.Show("No se encontro la Llave del Software, verifique por favor o " _
                        & Microsoft.VisualBasic.ControlChars.CrLf & "comuniquese con el Adminsitrador del sistema.", "Verificar Llave", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    CLASE_HARDKEY.FConexion()

                    Application.Exit()

                End If


            Else

                cargarinicio()

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub frmIngreso_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If My.Settings.Llave = True Then

            If CLASE_HARDKEY.IConexion() = "00000" Then

                If Me.btnRegistro.Visible = False Then
                    CLASE_GENERAL.terminar(CLASE_GENERAL.mensaje_error)
                End If


            End If

        Else

            If Me.btnRegistro.Visible = False Then
                CLASE_GENERAL.terminar(CLASE_GENERAL.mensaje_error)
            End If

        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub ingresar()

        Try

            ' Creamos el objeto para verificar el registro del programa

            REGISTRO = New CLASE_REGISTRO

            ' Estas variables nos indican tanto el codigo de activacion que es el serial del disco duro del usuario
            ' El codigo de Registro lo genera el algoritmo y lo compara con el que se suministra

            Dim codigoactivacion As String
            Dim codigoderegistro As String

            codigoactivacion = REGISTRO.CodigoActivacion() 'Aqui generamos el serial del disco duro como codigo de activacion
            codigoderegistro = My.Settings.Codigo

            'Comparamos los dos registros si son iguales el programa inicia de lo contrario debemos introducir el registro valido

            If codigoderegistro = REGISTRO.GenerarClave(codigoactivacion) Then

                If cont < 2 Then

                    If biometrico = True Then
                        res = 1
                    Else
                        res = CLASE_GENERAL.buscarpassw(Me.cmbEmpleados.SelectedValue, Me.txtClave.Text)
                    End If
                    
                    If res = 1 Then

                        ' Ocultamos el formulario inicial
                        Me.Hide()

                        ' Cargamos los datos de Inicio de los controles del mdi

                        My.Forms.mdiOrthoSoft.lblActivoUsuario.Text = Me.cmbEmpleados.Text
                        My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag = Me.cmbEmpleados.SelectedValue

                        My.Forms.frmSplashOrthosoft.Show()

                        '*************************** CARGAMOS EL NIVEL DE ACCESO ********************

                        EMP = New CLASE_EMPLEADOS
                        EMP.p_Idempleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                        EMP.Seleccionar(CLASE_GENERAL.mensaje_error)

                        CLASE_GENERAL.Nivel = CLASE_EMPLEADOS.xnivel_emp

                        'Asignamos el Perfil del Usuario

                        ASIGNAR_PERFILES = New CLASE_ASIGNAR_PERFILES
                        ASIGNAR_PERFILES.Seleccionar_perfil()
                        ASIGNAR_PERFILES = Nothing

                        'Bloqueamos algunos controles

                        EVEN = New CLASE_EVENTOS
                        EVEN.bloquaerdesbloquear("bloquearscheduler")
                        EVEN = Nothing

                        EMP.dispose()
                        EMP = Nothing

                    Else

                        MsgBox("Usuario no Autorizado, Verifique Por Favor", MsgBoxStyle.Exclamation, "Entrada al Sistema")
                        Me.txtClave.Text = ""
                        Me.txtClave.Focus()
                        cont = cont + 1

                    End If

                Else

                    MsgBox("Acceso Denegado, Consulte al Administrador del Sistema", MsgBoxStyle.Critical, "Entrada al Sistema")
                    Me.Dispose()
                    Me.Close()
                    End

                End If

            Else

                MsgBox("Aun no ha registrado la aplicacion solicite un codigo de registro por favor ....", MsgBoxStyle.Critical, "Entrada al Sistema")
                My.Forms.frmRegistro.Show()
                Me.Dispose()
                Me.Close()
                End

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        biometrico = False
        ingresar()
    End Sub

    Private Sub txtClave_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True
            Me.btnIngresar_Click(sender, e)
        End If

    End Sub

    Private Sub cmbEmpleados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmpleados.SelectedIndexChanged
        Me.txtClave.Focus()
    End Sub

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        My.Forms.frmRegistro.Show()
    End Sub

    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click

        My.Forms.frmAutenticacion.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        My.Forms.frmAutenticacion.StartPosition = FormStartPosition.CenterScreen
        My.Forms.frmAutenticacion.Show()

    End Sub

    Private Sub btnAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAyuda.Click

        My.Forms.frmAcercaOdontoapp.Show()
        My.Forms.frmAcercaOdontoapp.TopMost = True

        Buscar_Actualizacion()

    End Sub

    Private Sub VerificationControl_OnComplete(ByVal Control As System.Object, ByVal FeatureSet As DPFP.FeatureSet, ByRef EventHandlerStatus As DPFP.Gui.EventHandlerStatus) Handles VerificationControl.OnComplete

        Try

            'Verificamos Variables de Biometrico

            Dim ver As New DPFP.Verification.Verification()
            Dim res As New DPFP.Verification.Verification.Result()


            'Cargamos los Items para la busqueda

            HUELLA = New CLASE_HUELLAS
            HUELLA.p_IdTUsuario = 3 'Tipo Empleado
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

                        'MessageBox.Show("Usuario sin registro Biometrico", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure
                        Data.Update()

                       

                    Else

                        'Si es verdadero ingresamos

                        Me.cmbEmpleados.SelectedValue = CLASE_GENERAL.xdt2.Rows(i).Item("IdUsuario")
                        biometrico = True
                        ingresar()

                        HUELLA.dispose()
                        HUELLA = Nothing

                        Exit Sub

                    End If

                Next

            Else

                'MessageBox.Show("No hay registros Biometicos de Usuarios", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub
End Class