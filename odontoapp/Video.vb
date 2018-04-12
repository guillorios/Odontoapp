Module Video

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Short, ByVal lParam As Integer) As Integer
    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" (ByVal lpszWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Short, ByVal hWndParent As Integer, ByVal nID As Integer) As Integer
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, ByVal cbVer As Integer) As Boolean
    Declare Function SetWindowText Lib "user32" Alias "SetWindowTextA" (ByVal hWnd As Integer, ByVal lpString As String) As Integer

    Public lwndC As Integer

    Public Const WM_USER As Short = &H400S
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const WS_THICKFRAME As Integer = &H40000
    Public Const WM_CAP_START As Short = WM_USER
    Public Const WM_CAP_SET_CALLBACK_ERROR As Integer = WM_CAP_START + 2
    Public Const WM_CAP_SET_CALLBACK_STATUS As Integer = WM_CAP_START + 3
    Public Const WM_CAP_SET_CALLBACK_YIELD As Integer = WM_CAP_START + 4
    Public Const WM_CAP_SET_CALLBACK_FRAME As Integer = WM_CAP_START + 5
    Public Const WM_CAP_SET_CALLBACK_VIDEOSTREAM As Integer = WM_CAP_START + 6
    Public Const WM_CAP_SET_CALLBACK_WAVESTREAM As Integer = WM_CAP_START + 7
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP_START + 10
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP_START + 30
    Public Const WM_CAP_DLG_VIDEOSOURCE As Integer = WM_CAP_START + 42 '42
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP_START + 50 '50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP_START + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP_START + 53 '53
    Public Const WM_CAP_SET_CALLBACK_CAPCONTROL As Integer = WM_CAP_START + 85 '85
    Public Const WM_CAP_END As Short = WM_CAP_SET_CALLBACK_CAPCONTROL

    Function capSetCallbackOnError(ByVal lwnd As Integer, ByVal lpProc As Integer) As Boolean
        capSetCallbackOnError = SendMessage(lwnd, WM_CAP_SET_CALLBACK_ERROR, 0, lpProc)
    End Function
    Function capSetCallbackOnStatus(ByVal lwnd As Integer, ByVal lpProc As Integer) As Boolean
        capSetCallbackOnStatus = SendMessage(lwnd, WM_CAP_SET_CALLBACK_STATUS, 0, lpProc)
    End Function
    Function capSetCallbackOnYield(ByVal lwnd As Integer, ByVal lpProc As Integer) As Boolean
        capSetCallbackOnYield = SendMessage(lwnd, WM_CAP_SET_CALLBACK_YIELD, 0, lpProc)
    End Function
    Function capSetCallbackOnFrame(ByVal lwnd As Integer, ByVal lpProc As Integer) As Boolean
        capSetCallbackOnFrame = SendMessage(lwnd, WM_CAP_SET_CALLBACK_FRAME, 0, lpProc)
    End Function
    Function capSetCallbackOnVideoStream(ByVal lwnd As Integer, ByVal lpProc As Integer) As Boolean
        capSetCallbackOnVideoStream = SendMessage(lwnd, WM_CAP_SET_CALLBACK_VIDEOSTREAM, 0, lpProc)
    End Function
    Function capSetCallbackOnWaveStream(ByVal lwnd As Integer, ByVal lpProc As Integer) As Boolean
        capSetCallbackOnWaveStream = SendMessage(lwnd, WM_CAP_SET_CALLBACK_WAVESTREAM, 0, lpProc)
    End Function
    Function capSetCallbackOnCapControl(ByVal lwnd As Integer, ByVal lpProc As Integer) As Boolean
        capSetCallbackOnCapControl = SendMessage(lwnd, WM_CAP_SET_CALLBACK_CAPCONTROL, 0, lpProc)
    End Function
    Function capDriverConnect(ByVal lwnd As Integer, ByVal i As Short) As Boolean
        capDriverConnect = SendMessage(lwnd, WM_CAP_DRIVER_CONNECT, i, 0)
    End Function
    Function capEditCopy(ByVal lwnd As Integer) As Boolean
        capEditCopy = SendMessage(lwnd, WM_CAP_EDIT_COPY, 0, 0)
    End Function
    Function capDlgVideoSource(ByVal lwnd As Integer) As Boolean
        capDlgVideoSource = SendMessage(lwnd, WM_CAP_DLG_VIDEOSOURCE, 0, 0)
    End Function
    Function capPreview(ByVal lwnd As Integer, ByVal f As Boolean) As Boolean
        capPreview = SendMessage(lwnd, WM_CAP_SET_PREVIEW, f, 0)
    End Function
    Function capPreviewRate(ByVal lwnd As Integer, ByVal wMS As Short) As Boolean
        capPreviewRate = SendMessage(lwnd, WM_CAP_SET_PREVIEWRATE, wMS, 0)
    End Function
    Function capPreviewScale(ByVal lwnd As Integer, ByVal f As Boolean) As Boolean
        capPreviewScale = SendMessage(lwnd, WM_CAP_SET_SCALE, f, 0)
    End Function

End Module

