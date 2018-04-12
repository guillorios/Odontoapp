
Public Class frmAutenticacion

    Private mINI As New cIniArray
    Private sFicINI As String

    Dim CRIPTO As CLASE_ENCRIPTAR
    

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub


    Private Sub frmAutenticacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            sFicINI = Application.StartupPath & "\config.ini"
            CRIPTO = New CLASE_ENCRIPTAR

            ' Lectura Archivo de Configuración Con datos de Autenticación de Mysql

            Me.txtServidor.Text = mINI.IniGet(sFicINI, "Autenticacion", "Servidor")
            Me.txtBD.Text = mINI.IniGet(sFicINI, "Autenticacion", "BD")
            Me.txtUsuario.Text = mINI.IniGet(sFicINI, "Autenticacion", "Usuario")
            Me.txtClave.Text = CRIPTO.DesEncripta(mINI.IniGet(sFicINI, "Autenticacion", "Clave"))


            ' Lectura Archivo de Configuración Con datos de Autenticación del Call Center

            Me.txtRutaCallCenter.Text = mINI.IniGet(sFicINI, "Callcenter", "Ruta")
            Me.txtRutaCallCenter2.Text = mINI.IniGet(sFicINI, "Callcenter", "Ruta2")

            Me.txtUsuarioCallCenter.Text = mINI.IniGet(sFicINI, "Callcenter", "Usuario")
            Me.txtClaveCallCenter.Text = CRIPTO.DesEncripta(mINI.IniGet(sFicINI, "Callcenter", "Clave"))

            ' Lectura Archivo de Configuracion Con Datos de Autenticación de SMTP Email

            Me.txtsmtpNombre.Text = mINI.IniGet(sFicINI, "Email", "Nombre")
            Me.txtsmtpCuenta.Text = mINI.IniGet(sFicINI, "Email", "Cuenta")
            Me.txtsmtpHost.Text = mINI.IniGet(sFicINI, "Email", "Smtphost")
            Me.txtsmtpPort.Text = mINI.IniGet(sFicINI, "Email", "Smtpport")
            Me.txtsmtpPass.Text = CRIPTO.DesEncripta(mINI.IniGet(sFicINI, "Email", "Clave"))

            ' Lectura Archivo de Configuración Con Datos de Ruta de las Imagenes

            Me.txtRutaImagenes.Text = mINI.IniGet(sFicINI, "Rutaimagenes", "Ruta")

            CRIPTO = Nothing


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        Try

            CRIPTO = New CLASE_ENCRIPTAR

            If Me.txtServidor.Text = "" Or Me.txtBD.Text = "" Or Me.txtUsuario.Text = "" Or Me.txtClave.Text = "" Then

                MessageBox.Show("Existen Campos vacios verifique por favor")

            Else

                ' Escritura Archivo Config.ini con la autenticacion del servidor Mysql

                mINI.IniWrite(sFicINI, "Autenticacion", "Servidor", Me.txtServidor.Text)
                mINI.IniWrite(sFicINI, "Autenticacion", "BD", Me.txtBD.Text)
                mINI.IniWrite(sFicINI, "Autenticacion", "Usuario", Me.txtUsuario.Text)
                mINI.IniWrite(sFicINI, "Autenticacion", "Clave", CRIPTO.Encripta(Me.txtClave.Text))

                ' Escritura Archivo Config.ini con la autenticacion del Call Center

                mINI.IniWrite(sFicINI, "Callcenter", "Ruta", Me.txtRutaCallCenter.Text)
                mINI.IniWrite(sFicINI, "Callcenter", "Ruta2", Me.txtRutaCallCenter2.Text)

                mINI.IniWrite(sFicINI, "Callcenter", "Usuario", Me.txtUsuarioCallCenter.Text)
                mINI.IniWrite(sFicINI, "Callcenter", "Clave", CRIPTO.Encripta(Me.txtClaveCallCenter.Text))

                ' Escritura Archivo de Configuracion Con Datos de Autenticación de SMTP Email

                mINI.IniWrite(sFicINI, "Email", "Nombre", Me.txtsmtpNombre.Text)
                mINI.IniWrite(sFicINI, "Email", "Cuenta", Me.txtsmtpCuenta.Text)
                mINI.IniWrite(sFicINI, "Email", "Smtphost", Me.txtsmtpHost.Text)
                mINI.IniWrite(sFicINI, "Email", "Smtpport", Me.txtsmtpPort.Text)
                mINI.IniWrite(sFicINI, "Email", "Clave", CRIPTO.Encripta(Me.txtsmtpPass.Text))


                ' Escritura Archivo de Configuración COn Datos de Ruta de las Imagenes

                mINI.IniWrite(sFicINI, "Rutaimagenes", "Ruta", Me.txtRutaImagenes.Text)

                Dim respuesta As Integer

                respuesta = MsgBox("ARCHIVO GRABADO CON EXITO, DESEA REINICIAR LA APLICACION ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Autenticacion")

                If respuesta = 6 Then
                    Application.Exit()
                Else
                    Me.Dispose()
                    Me.Close()
                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub


End Class