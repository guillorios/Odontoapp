Imports System.Net

Public Class CLASE_INTERNET

    Public Function Descargar_Archivo(ByVal Url As String, ByVal Path_Destino As String) As Boolean

        If Url = vbNullString Or Path_Destino = vbNullString Then
            MsgBox("No se indicó la url o el archivo de destino", MsgBoxStyle.Critical, "Error")
        Else

            On Error Resume Next
            My.Forms.frmAcercaOdontoapp.Close()
            My.Computer.Network.DownloadFile(Url, Path_Destino, "", "", True, 15000, True)

            If Err.Number = 0 Then
                Descargar_Archivo = True
            Else
                MsgBox(Err.Description)
            End If
            Err.Clear()

        End If

    End Function

    Public Sub upload_Archivo_ftp(ByVal Url As String, ByVal Path_Archivo As String, ByVal usuario As String, ByVal password As String)
        ' Controlador de error
        Try
            ' Ejecuta el método UploadFile para subir el archivo
            My.Computer.Network.UploadFile(Path_Archivo, _
                                           Url, _
                                           usuario, _
                                           password, _
                                           True, _
                                           2500, _
                                           FileIO.UICancelOption.DoNothing)


            MessageBox.Show("Archivo enviado con éxito", "", _
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' error
        Catch mensaje As Exception
            MessageBox.Show(mensaje.Message, "", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function funConexion() As Boolean

        Dim Req As HttpWebRequest = WebRequest.Create("http://www.google.com.co")
        Dim res As System.Net.HttpWebResponse

        Try

            Req = DirectCast(System.Net.WebRequest.Create("http://www.google.com.co"), System.Net.HttpWebRequest)

            res = DirectCast(Req.GetResponse(), System.Net.HttpWebResponse)

            Req.Abort()

            If res.StatusCode = System.Net.HttpStatusCode.OK Then
                Return True
            Else
                Return False
            End If
        Catch
            Return False
        End Try

    End Function

End Class
