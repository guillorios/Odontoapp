Option Strict Off
Option Explicit On

Module Actt

    Private Declare Function URLDownloadToFile Lib "urlmon" Alias "URLDownloadToFileA" (ByVal pCaller As Integer, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Integer, ByVal lpfnCB As Integer) As Integer
    Private Declare Function DoFileDownload Lib "shdocvw.dll" (ByVal lpszFile As String) As Integer
    
    Private version As String = My.Settings.Version  'version del software actual
    Const pagver As String = "http://www.Odontoapp.com/update/version.txt" 'la pagina web donde se encuentra la ultima version, este archivo tiene que contener el último número de versión
    Const pagdown As String = "http://artehack.net/acct/programa.exe" 'donde tengas el ejecutable actualizado

    Private Sub Descargar(ByVal link As String, ByVal slocalfile As String)

        URLDownloadToFile(0, link, slocalfile, 0, 0)

    End Sub


    Private Function verificar(ByVal version As String) As Boolean

        Dim alexay As Short
        Dim Versver As String
        alexay = FreeFile()
        FileOpen(alexay, My.Application.Info.DirectoryPath & "\version.txt", OpenMode.Input)
        Versver = InputString(alexay, LOF(alexay))
        FileClose(alexay)

        If Versver = version Then
            My.Forms.frmAcercaOdontoapp.lblActualizado.Text = "SU SOFTWARE ESTA ACTUALIZADO"
            My.Forms.frmAcercaOdontoapp.lblVersionServidor.Text = ""
            My.Forms.frmAcercaOdontoapp.btnDescargarActualizacion.Visible = False
        Else
            My.Forms.frmAcercaOdontoapp.lblActualizado.Text = "EXISTE UNA NUEVA VERSION POR FAVOR ACTUALICELA"
            My.Forms.frmAcercaOdontoapp.lblVersionServidor.Text = "Version Servidor : " & Versver
            My.Forms.frmAcercaOdontoapp.btnDescargarActualizacion.Visible = True
            My.Forms.frmAcercaOdontoapp.Show()
            My.Forms.frmAcercaOdontoapp.TopMost = True
        End If

    End Function

    Public Sub Buscar_Actualizacion()

        Descargar(pagver, My.Application.Info.DirectoryPath & "\version.txt")
        verificar(LCase(UCase(version)))

    End Sub

End Module
