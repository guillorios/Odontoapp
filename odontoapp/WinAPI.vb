Imports Microsoft.VisualBasic
Imports System

' Para DllImport
Imports System.Runtime.InteropServices

Namespace elGuille.Util

    Public Class WinAPI
        ' Constantes para SetWindowsPos
        '   Valores de wFlags
        Const SWP_NOSIZE As Integer = &H1
        Const SWP_NOMOVE As Integer = &H2
        Const SWP_NOACTIVATE As Integer = &H10
        Const wFlags As Integer = SWP_NOMOVE Or SWP_NOSIZE Or SWP_NOACTIVATE
        '   Valores de hwndInsertAfter
        Const HWND_TOPMOST As Integer = -1
        Const HWND_NOTOPMOST As Integer = -2
        '
        ''' <summary>
        ''' Para mantener la ventana siempre visible
        ''' </summary>
        ''' <remarks>No utilizamos el valor devuelto</remarks>
        <DllImport("user32.DLL")> _
        Private Shared Sub SetWindowPos( _
            ByVal hWnd As Integer, ByVal hWndInsertAfter As Integer, _
            ByVal X As Integer, ByVal Y As Integer, _
            ByVal cx As Integer, ByVal cy As Integer, _
            ByVal wFlags As Integer)
        End Sub

        Public Shared Sub SiempreEncima(ByVal handle As Integer)
            SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, wFlags)
        End Sub

        Public Shared Sub NoSiempreEncima(ByVal handle As Integer)
            SetWindowPos(handle, HWND_NOTOPMOST, 0, 0, 0, 0, wFlags)
        End Sub
    End Class

End Namespace
