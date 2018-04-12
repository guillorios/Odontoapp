Public Class frmAcercaOdontoapp

    Private INTERNET As CLASE_INTERNET
    Private REGISTRO As CLASE_REGISTRO

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub frmAcercaOdontoapp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", ApplicationTitle)
        ' Inicialice el texto mostrado en el cuadro Acerca de.
        ' TODO: Personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Settings.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description

        ' Creamos la clase segistro para acceder  a los procedimientos
        REGISTRO = New CLASE_REGISTRO

        'Cargamos la configuracion del archivo de config.ini

        'Extraemos del archivo de configuracion los dos datos el nombre y el codifo de registro
        Me.lblNombre.Text = My.Settings.Usuario
        Me.lblSerial.Text = My.Settings.Codigo

        'El codigo de activacion lo generamos a partir del serial del disco duro
        Me.lblCodAtivacion.Text = REGISTRO.CodigoActivacion()

        REGISTRO = Nothing

    End Sub

   
    Private Sub btnDescargarActualizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescargarActualizacion.Click

        INTERNET = New CLASE_INTERNET

        If INTERNET.funConexion() Then

            Dim Version As String = My.Settings.Version.ToString
            Dim txt_Url As String = ""
            Dim txt_path_destino As String = ""

            txt_Url = "http://www.Odontoapp.com/update/Actualizacion_Odontoapp.exe"
            txt_path_destino = My.Computer.FileSystem.SpecialDirectories.Temp & "\Actualizacion_Odontoapp.exe"

            INTERNET = New CLASE_INTERNET

            If txt_path_destino = "" Or txt_Url = "" Then

                MsgBox("Version Incorrecta para su actualizacion. Comuniquese con el administrador del Sistema", MsgBoxStyle.Information)

            Else

                Dim ret As Boolean
                ret = INTERNET.Descargar_Archivo(txt_Url, txt_path_destino)

                If ret Then
                    MsgBox("Archivo descargado correctamente", MsgBoxStyle.Information)
                    Shell(txt_path_destino)
                    Application.Exit()
                End If

            End If


        Else

            MessageBox.Show("No hay conexion a internet, revisela e intentelo Nuevamente.", "Conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If

        INTERNET = Nothing

    End Sub

End Class