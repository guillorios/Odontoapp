Imports System.Management
Imports System.Text
Imports Microsoft.VisualBasic
Imports Scripting

Public Class CLASE_REGISTRO

    Public Function GenerarClave(ByVal usuario As String) As String

        ' Obtenemos la longitud de la cadena de usuario
        Dim longitud As Byte = usuario.Length
        ' Declaramos valorEntrada para obtener el valor general
        ' correspondiente a la entrada de usuario
        Dim valorEntrada As Long = 0
        ' Recorremos la cadena entera para sumar el valor
        ' total de sus cASCII
        For I As Byte = 0 To longitud - 1
            valorEntrada += Asc(usuario.Substring(I, 1))
        Next
        ' Dividimos el valor final resultante de la suma de
        ' sus valores ASCII entre la longitud de la cadena
        valorEntrada \= longitud
        ' Obtenemos un valor base que corresponde con el
        ' cdel producto entre el valor de entrada 
        ' anteriormente calcula por su longitud
        Dim valorBase As Integer = valorEntrada * longitud
        Dim key As String = ""
        ' Empezamos obteniento valores
        ' Obtenemos el valor hexadecimal
        Dim valor As String = Hex(valorBase + (123 * 15000))
        key &= valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (98 * 66300))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (77 * 15200))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (121 * 87100))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (55 * 27000))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (134 * 29900))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (63 * 25300))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(valor.Length - 6, 6)
        ' Obtenemos el valor hexadecimal
        valor = Hex(valorBase + (117 * 77500))
        ' Obtenemos el valor de clave
        key &= "-" & valor.Substring(0, 6)
        ' Devolvemos el valor final (xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx-xxxxxx)
        Return key

    End Function

    Public Function GenerarCodigoActivacion() As String

        'Declaramos una coleccion del tipo ArrayList
        Dim hdLista As New ArrayList
        Dim codigo As String

        codigo = ""

        'Creamos ahora un objeto ManagementObjectSearcher y agregaremos la cadena de seleccion 
        'para obtener de la clase Win32_DiskDrive
        ' la Informacion del modelo y el tipo del Disco Duro
        Dim BuscardorWMI As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive")

        For Each wmi_HD As ManagementObject In BuscardorWMI.Get
            'creamos un objeto del tipo DiscoDuro
            Dim Hd As New DiscoDuro
            'asignamos el valor del Modelo obtenido de la consulta
            ' en la propiedad Modelo del objeto Hd
            Hd.Modelo = wmi_HD("Model").ToString
            'asignamos el valor del Tipo obtenido de la consulta
            ' en la propiedad Modelo del objeto Hd
            Hd.Tipo = wmi_HD("InterfaceType").ToString
            'y Finalmente agregamos dicho objeto Hd al ArrayList que creamos
            hdLista.Add(Hd)
        Next


        'Creamos ahora una nueva instancia del objeto que habiamos
        ' creado del tipo ManagementObjectSearcher 
        'y agregaremos la cadena de seleccion para obtener de la clase Win32_PhysicalMedia
        ' los seriales internos 
        'de los Discos Duros que hallamos encontrado en el ciclo anterior
        BuscardorWMI = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")
        'Deifinimos a i como un contador para manejar el ArrayList
        Dim i As Integer = 0

        For Each wmi_HD As ManagementObject In BuscardorWMI.Get
            'Indica continuar con el ciclo mientras que i sea menor que
            ' la cantidad de discos encontrados
            If i < hdLista.Count - 1 Then
                'creamos  un nuevo objeto del Tipo DiscoDuro para ir almacenando alli 
                'cada uno de los discos duros encontrados
                Dim hd As New DiscoDuro
                'asignamos el valor acutalde la lista en el objeto HD
                hd = hdLista(i)
                'debemos verificar que el valor del campo "SerialNumber" obtenido en la busqueda 
                'no sea un valor nulo de lo contrario 
                'la aplicacion arrojará una excepcion
                If wmi_HD("SerialNumber").ToString = Nothing Then
                    'en el caso de  que se halla encontrado el serial la propiedad "Serial" del
                    ' objeto hd se guardará los siguiente:
                    hd.Serial = "No se Pudo Obtener El Serial"
                Else
                    'en el caso contrario almacenaremos el numero de serial interno 
                    'del disco duro en la propiedad "Serial" del objeto hd
                    hd.Serial = wmi_HD("SerialNumber").ToString
                End If
                'incrementando i
                i += 1
            End If
        Next

        'aqui coloco una manera de mostrarlo ustedes pueden escoger la que mejor les paresca
        For Each hd As DiscoDuro In hdLista

            'por cuestiones de tiempo yo escogí usar un MessageBox
            codigo = Strings.Left(hd.Modelo & hd.Tipo & hd.Serial, 18)

        Next

        Return codigo

    End Function

    Public Function CodigoActivacion() As String

        Dim fso As New FileSystemObject
        Dim codigo As String

        Dim selected_drive As Drive = fso.GetDrive(Application.ExecutablePath.Substring(0, 3))

        codigo = selected_drive.SerialNumber.ToString()

        Return codigo

    End Function


End Class
