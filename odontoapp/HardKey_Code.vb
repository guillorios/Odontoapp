Module HardKey_Code

    '---------------------------------------------------------
    '                      HKEYDEMO.BAS
    '
    'Este módulo contiene la declaración de la librería DLL con la
    'función HARDkey(), las variables públicas y dos vectores que
    'usan las rutinas para encriptar la cadena de comandos. Estos
    'vectores son distintos para cada kit. No cambie sus valores,
    'incluya este módulo en su proyecto tal como está.
    '
    'ATENCION: Este proyecto debe ser compilado y ejecutado
    '"FUERA" del entorno de Visual Basic, ya que el mismo no
    'es compatible con algunas rutinas antidebug que posee la
    'dll Hkey-w32.dll


    'This module include DLL library where HARDkey function
    'is declared, variables and vectors for encription routines.
    'This vectors are diferent fon each kit. Don't change it's values,
    'include this module in you proyect.
    '
    'ATENTION: This proyect must be executed out of
    'Visual Basic environment, because it is incompatible
    'with security routines.
    Declare Function HARDkey Lib "hkey-w32.dll" (ByVal buf As String) As Long

    Public sBox1() As Integer = {&H83, &HE9, &H57, &HB1, &H0, &H1D, &HEF, &H4F, &HCB, &HA2, &H5B, &H25, &HD7, &H22, &H87, &HA9, _
&HC3, &H99, &HBF, &H2D, &H17, &H9C, &H81, &H66, &HDB, &HC8, &H41, &HAD, &HA, &H38, &HCF, &H96, _
&H23, &H43, &H6, &HDE, &H1E, &H7C, &HC5, &H26, &HFB, &HCD, &H13, &H64, &H6B, &H19, &H85, &H3, _
&HF3, &H2F, &H77, &H9B, &H30, &HB, &HAB, &HF7, &H28, &H1C, &H69, &H15, &HC7, &H8C, &HE3, &HDA, _
&H4, &H10, &H4D, &H59, &H5F, &H29, &H24, &H31, &H1A, &H9E, &HD1, &HF8, &H2C, &HFE, &H8, &HB4, _
&H63, &HBD, &H61, &HE8, &H7B, &H9, &H6D, &H5C, &H33, &H3A, &H27, &H98, &HBB, &HD2, &H4A, &HED, _
&H3E, &HAC, &H97, &HB0, &H46, &H3C, &H36, &HC, &HEB, &HA3, &H9F, &HD6, &HE7, &HAF, &H5, &H4C, _
&H34, &HDC, &HB5, &HA8, &H65, &H67, &H4E, &H52, &HD3, &HF5, &HD, &HFA, &H6A, &H93, &H7D, &HE, _
&H40, &HF1, &HA5, &HB3, &H35, &H94, &H45, &H2B, &H18, &HCC, &H5E, &H78, &H8F, &H9A, &H14, &H16, _
&H7E, &HBE, &H72, &HC1, &H62, &HFC, &H86, &H32, &H8B, &HAE, &H88, &HAA, &H68, &HB7, &H37, &HC2, _
&H21, &HDF, &HDD, &HD8, &H70, &HA7, &H8E, &H12, &H8D, &HEE, &H1B, &H49, &H39, &HE1, &H48, &HD0, _
&H2E, &H42, &H7A, &H84, &H76, &H95, &H51, &HA1, &H7, &HB2, &H2, &HE2, &H11, &H3B, &H1, &HA6, _
&HBC, &H20, &H50, &H56, &HB6, &H53, &H7F, &HA4, &HB8, &H8A, &HD5, &H91, &H80, &H2A, &HC6, &H73, _
&H89, &HC0, &HFF, &H75, &H6C, &HE4, &H74, &H6E, &H6F, &HB9, &H82, &H1F, &HC4, &HE0, &HD4, &H58, _
&H60, &HE6, &HD9, &H71, &H55, &HE5, &HA0, &H9D, &HC9, &HCA, &H5D, &H5A, &HEA, &H3D, &HEC, &H90, _
&HBA, &HCE, &HF0, &HF4, &HF, &H54, &HF2, &H79, &H44, &H4B, &HF9, &HF6, &H3F, &HFD, &H92, &H47}

    Public sBox2() As Integer = {&H3, &H59, &HAF, &H79, &H3B, &HF4, &H73, &HA9, &H8B, &HE8, &H33, &HB6, &HFF, &HE3, &H5B, &H36, _
    &H13, &H9C, &HF7, &H77, &H4, &H4B, &HB5, &HA, &H83, &H0, &H87, &H57, &HFB, &HAA, &HA3, &HD6, _
    &H1E, &HDA, &HAD, &HDB, &H2, &HF, &H6D, &H42, &HD, &H22, &H39, &H82, &H24, &H9B, &H18, &H65, _
    &HB3, &H32, &HD5, &H9F, &H1C, &HD3, &HF3, &HB9, &H20, &H74, &HE, &H8, &H3A, &H14, &HCF, &H25, _
    &HC3, &H9D, &H28, &H1A, &H30, &H5C, &H15, &H72, &H2D, &HE6, &H85, &H69, &H12, &HBB, &H19, &H61, _
    &H44, &HAC, &H67, &H6B, &H50, &H84, &H38, &HB, &H35, &HD0, &H99, &HC0, &H54, &H45, &HC5, &HF9, _
    &H40, &HFA, &H56, &HF0, &H97, &HA7, &H5D, &HCD, &H3D, &H23, &HA1, &H52, &HC7, &H93, &H6F, &HBA, _
    &H6, &H3E, &H17, &HE2, &H58, &H4C, &HD9, &H60, &H48, &H62, &H5A, &HC2, &H10, &HE5, &H2E, &HB7, _
    &H7E, &HFC, &H7D, &HE1, &H2F, &H78, &H34, &H8C, &H46, &H2B, &H5E, &H51, &HE7, &H2C, &HDF, &H31, _
    &H4E, &HEA, &H89, &HDE, &H66, &HBD, &H8E, &HDC, &HAB, &H98, &H92, &H49, &H86, &H41, &H5F, &HCE, _
    &H7C, &H75, &H8F, &HC4, &H27, &HB4, &H95, &HEF, &HA4, &H90, &H71, &H64, &HD7, &HC, &H53, &HD8, _
    &H94, &HAE, &HED, &HFD, &H6C, &H26, &HD1, &HBC, &H88, &HCC, &HF5, &HDD, &H1D, &HA6, &H96, &H8A, _
    &HA0, &H3C, &HF1, &HF6, &H7F, &H9E, &H43, &H7B, &H3F, &H1, &H55, &HFE, &HBE, &H8D, &H11, &HE4, _
    &HC8, &H63, &H76, &H6A, &HC6, &HF2, &H4D, &H6E, &HC9, &H1F, &HCA, &HA8, &H47, &HB0, &H7A, &HC1, _
    &HB8, &HA5, &HE0, &HEC, &HD4, &HEE, &HD2, &H37, &HB1, &HBF, &HE9, &H70, &H16, &H4F, &H4A, &HA2, _
    &H9, &H91, &H1B, &HCB, &H29, &HF8, &HEB, &H7, &H2A, &H9A, &H5, &H80, &HB2, &H68, &H81, &H21}

    Public password As String = "HTaVMjeaAjEZUhxu"

End Module
