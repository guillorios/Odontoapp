Public Class frmRegistro

    Private mINI As New cIniArray
    Private sFicINI As String

    Private REGISTRO As CLASE_REGISTRO


    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        'Verificamos que los dos campos esten completos
        If Me.txtNombre.Text = "" Or Me.txtCodRegistro.Text = "" Then

            MessageBox.Show("Existen Campos vacios verifique por favor")

        Else

            REGISTRO = New CLASE_REGISTRO

            'Comparamos el registro que introduciomos con el que genera el algoritmo y deben coincidir
            'Si lo hace registramos en el archivo de configuracion el control de ello

            If Me.txtCodRegistro.Text = REGISTRO.GenerarClave(Me.txtCodAtivacion.Text) Then

                My.Settings.Usuario = Me.txtNombre.Text
                My.Settings.Codigo = Me.txtCodRegistro.Text

                'mINI.IniWrite(sFicINI, "CodigoRegistro", "Usuario", Me.txtNombre.Text)
                'mINI.IniWrite(sFicINI, "CodigoRegistro", "Codigo", Me.txtCodRegistro.Text)

                Me.txtCodAtivacion.Enabled = False
                Me.txtCodRegistro.Enabled = False
                Me.txtNombre.Enabled = False
                Me.btnRegistrar.Enabled = False
                Me.lblRegistrado.Visible = True

                MessageBox.Show("El registro se realizo con exito, reinicie la aplicacion por favor.")
                Application.Exit()

            Else

                MessageBox.Show("La licencia no es valida, cantacte por favor con el proveedor del programa")

            End If

        End If

    End Sub

    Private Sub frmRegistro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try


            My.Forms.frmIngreso.Visible = False

            ' Creamos la clase segistro para acceder  a los procedimientos
            REGISTRO = New CLASE_REGISTRO

            'Cargamos la configuracion del archivo de config.ini
            'sFicINI = Application.StartupPath & "\config.ini"

            ''Extraemos del archivo de configuracion los dos datos el nombre y el codifo de registro
            'Me.txtNombre.Text = mINI.IniGet(sFicINI, "CodigoRegistro", "Usuario")
            'Me.txtCodRegistro.Text = mINI.IniGet(sFicINI, "CodigoRegistro", "Codigo")

            Me.txtNombre.Text = My.Settings.Usuario
            Me.txtCodRegistro.Text = My.Settings.Codigo

            'El codigo de activacion lo generamos a partir del serial del disco duro
            Me.txtCodAtivacion.Text = REGISTRO.CodigoActivacion()


            'Verificamos el contenido si esta vacio quiere decir que aun no hemos colocado un registro valido

            If Me.txtCodRegistro.Text = "" Then

                Me.txtCodAtivacion.Enabled = True
                Me.txtCodRegistro.Enabled = True
                Me.txtNombre.Enabled = True
                Me.btnRegistrar.Enabled = True
                Me.lblRegistrado.Visible = False

            Else

                Me.txtCodAtivacion.Enabled = False
                Me.txtCodRegistro.Enabled = False
                Me.txtNombre.Enabled = False
                Me.btnRegistrar.Enabled = False
                Me.lblRegistrado.Visible = True

                Me.lblRegistrado.Text = "   REGISTRADO A : " & Me.txtNombre.Text

            End If

            REGISTRO = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

End Class