Option Strict Off
Option Explicit On

Module CambiarResolucion


    '------------------------------------------------------------------
    ' Cambiar la resolución de la pantalla                  (22/Jul/07)
    ' Basado en un artículo de la Knowledge Base:
    ' Changing the Screen Resolution at Run Time in Visual Basic 4.0
    '------------------------------------------------------------------


    Private Structure tResol
        'UPGRADE_NOTE: Width was upgraded to Width_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Width_Renamed As Integer
        'UPGRADE_NOTE: Height was upgraded to Height_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        Dim Height_Renamed As Integer
        Dim Bits As Short
    End Structure

    Private Disponibles() As tResol

    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function EnumDisplaySettings Lib "user32" Alias "EnumDisplaySettingsA" (ByVal lpszDeviceName As Integer, ByVal iModeNum As Integer, ByRef lpDevMode As DEVMODE) As Boolean

    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function ChangeDisplaySettings Lib "user32" Alias "ChangeDisplaySettingsA" (ByRef lpDevMode As DEVMODE, ByVal dwflags As Integer) As Integer

    Const CCDEVICENAME As Short = 32
    Const CCFORMNAME As Short = 32
    'Las declaraciones de estas constantes están en: Wingdi.h
    Const DM_BITSPERPEL As Integer = &H40000
    Const DM_PELSWIDTH As Integer = &H80000
    Const DM_PELSHEIGHT As Integer = &H100000

    Private Structure DEVMODE
        'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
        <VBFixedString(CCDEVICENAME), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=CCDEVICENAME)> Public dmDeviceName() As Char
        Dim dmSpecVersion As Short
        Dim dmDriverVersion As Short
        Dim dmSize As Short
        Dim dmDriverExtra As Short
        Dim dmFields As Integer
        Dim dmOrientation As Short
        Dim dmPaperSize As Short
        Dim dmPaperLength As Short
        Dim dmPaperWidth As Short
        Dim dmScale As Short
        Dim dmCopies As Short
        Dim dmDefaultSource As Short
        Dim dmPrintQuality As Short
        Dim dmColor As Short
        Dim dmDuplex As Short
        Dim dmYResolution As Short
        Dim dmTTOption As Short
        Dim dmCollate As Short
        'UPGRADE_WARNING: Fixed-length string size must fit in the buffer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
        <VBFixedString(CCFORMNAME), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=CCFORMNAME)> Public dmFormName() As Char
        Dim dmUnusedPadding As Short
        Dim dmBitsPerPel As Short
        Dim dmPelsWidth As Integer
        Dim dmPelsHeight As Integer
        Dim dmDisplayFlags As Integer
        Dim dmDisplayFrequency As Integer
    End Structure
    Dim DevM As DEVMODE

    Public Sub cambiarresolucion(ByVal width As Integer, ByVal height As Integer, ByVal resol As Integer)

        Dim i As Integer

        EnumDisplaySettings(0, i, DevM)

        DevM.dmFields = DM_PELSWIDTH Or DM_PELSHEIGHT

        DevM.dmPelsWidth = width
        DevM.dmPelsHeight = height
        DevM.dmBitsPerPel = resol
        Debug.Print(resol)

        'UPGRADE_WARNING: Couldn't resolve default property of object DevM. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Call ChangeDisplaySettings(DevM, 0)

    End Sub

End Module
