Public Class CLASE_HARDKEY

    'Variables de Conexion de la Llave
    Public Shared buffer As String
    Public Shared l As Long
    Public Shared relleno As String
    Public Shared random As String
    Public Shared hkestado As String
    Public Shared st As String
    Public Shared conexion As String


    'Codigo de la Llave
    Public Shared Sub InitBuffer()
        'Inicializa con 10 bytes al azar la string usada para
        'pasar los parámetros a la función HARDkey()

        Randomize()
        relleno = Space(200)
        buffer = ""
        For l = 1 To 10
            buffer = buffer + Chr(1) 'Chr(Int((Rnd * 255) + 1))
        Next l
    End Sub

    Public Shared Function IConexion() As String

        'Primero deshabilito el chequeo en red, limitando la
        'busqueda de la llave a los puertos paralelo locales.
        'Para chequear en red y local elimine esta parte.
        InitBuffer()
        'Selección de distintos chequeos
        ' Los siguiente ejemplos muestran como armar la string para los distintos
        ' tipos de chequeos, según se desee buscar la llave en los puertos locales
        ' o en la red, y el orden en que se realizará la búsqueda.
        '    Chequeo de la llave SuperPro en puertos USB y paralelo.
        '          strIN := strIN + '00004 00000 00000 00000 00000 00000 00000 00000';
        '    Chequeo de la llave SuperPro y HARDkey en puertos USB y paralelo.
        '    En este caso primero buscará la llave HARDkey y luego las llaves SuperPro
        '          strIN := strIN + '00001 00004 00000 00000 00000 00000 00000 00000';
        '    Chequeo de la llave HARDkey en red. En este caso busca primero la llave
        '    por MAILSLOT, luego por el protocolo IPX
        '          strIN := strIN + '00002 00003 00000 00000 00000 00000 00000 00000';
        buffer = buffer + " 00000000 01379 02849 0009 00001 00000 00000 00000 00000 00000 00000 00000"
        buffer = buffer + relleno
        Call EncriptaString(buffer, password)
        l = HARDkey(buffer)

        'Chequeo la llave invocando el comando Iniciar Conexión
        InitBuffer()
        random = buffer
        buffer = buffer + " 00000000 01379 02849 0000 00 0"
        buffer = buffer + relleno
        '        CadenaEnviada.Text = Mid(buffer, 12)
        Call EncriptaString(buffer, password)
        l = HARDkey(buffer)
        Call DesencriptaString(buffer, password)

        'Analizo la respuesta para determinar si está la llave
        'm_envio.Text = Mid(buffer, 12)
        If (ValidaString(buffer, random) = True) Then
            'LMemoria.Enabled = True
            'FConexion.Enabled = True
            'm_recibo.Text = Mid(buffer, 12)
            'm_campos.Text = "conexión  estado lote-serie    vDll   vDRV   vRed  FechaVence         Módulos habilitados                  LiEjec LiGlo  LiUso"
            'conexion = Mid(buffer, 12, 8)
            'LMemoria.Enabled = True
            'LMemoria.Select()
            'FConexion.Enabled = True
            conexion = st

            'Else
            '    'm_recibo.Text = Mid(buffer, 12) ' Eliminar No se encontro la llave
            'conexion = "00000000"

        End If

        Return conexion

    End Function

    Public Shared Sub EncriptaString(ByRef buffer As String, ByVal password As String)
        'Esta rutina encripta la cadena que se pasa como parámetro
        'a la función HARDkey().

        Dim i As Integer
        Dim ctemp As Integer
        Dim cAnterior As Integer
        Dim k As Integer
        Dim pw As Integer
        Dim bufEnc As String

        cAnterior = 0
        bufEnc = ""
        For i = 0 To 199
            ctemp = Asc(Mid(buffer, i + 1, 1))
            If (ctemp < 0) Then
                ctemp = ctemp + 256
            End If
            ctemp = ctemp Xor sBox1(cAnterior)
            For k = 0 To 15
                pw = Asc(Mid(password, k + 1, 1))
                If ((k Mod 2) = 1) Then
                    ctemp = ctemp Xor sBox1(sBox2(pw))
                    ctemp = sBox2(ctemp)
                Else
                    ctemp = ctemp Xor sBox2(sBox1(pw))
                    ctemp = sBox1(ctemp)
                End If
            Next k
            ctemp = ctemp Xor sBox1(i)
            cAnterior = ctemp
            bufEnc = bufEnc + Chr(ctemp)
        Next i
        buffer = bufEnc
    End Sub

    Public Shared Sub DesencriptaString(ByRef buffer As String, ByVal password As String)
        'Esta rutina desencripta la cadena que devuelve la
        'función HARDkey().

        Dim i As Integer
        Dim ctemp As Integer
        Dim cAnterior As Integer
        Dim k As Integer
        Dim pw As Integer
        Dim bufEnc As String

        cAnterior = 0
        bufEnc = ""
        For i = 0 To 199
            ctemp = Asc(Mid(buffer, i + 1, 1))
            If (ctemp < 0) Then
                ctemp = ctemp + 256
            End If
            ctemp = ctemp Xor sBox1(cAnterior)
            For k = 0 To 15
                pw = Asc(Mid(password, k + 1, 1))
                If ((k Mod 2) = 1) Then
                    ctemp = ctemp Xor sBox1(sBox2(pw))
                    ctemp = sBox2(ctemp)
                Else
                    ctemp = ctemp Xor sBox2(sBox1(pw))
                    ctemp = sBox1(ctemp)
                End If
            Next k
            ctemp = ctemp Xor sBox1(i)
            cAnterior = Asc(Mid(buffer, i + 1, 1))
            bufEnc = bufEnc + Chr(ctemp)
        Next i
        buffer = bufEnc

    End Sub

    Public Shared Function ValidaString(ByVal buffer As String, ByVal random As String) As Boolean

        'Esta rutina analiza que la string devuelta por la
        'función HARDkey() sea consistente.

        Dim i As Integer
        Dim result As Boolean


        For i = 1 To 10
            Mid(buffer, i, 1) = Chr(sBox2(Asc(Mid(buffer, i, 1))))
        Next i
        result = True
        For i = 1 To 10
            If (Mid(buffer, i, 1) <> Mid(random, i, 1)) Then
                result = False
            End If
        Next i
        If (Mid(buffer, 11, 1) <> " ") Then
            result = False
        End If
        If (Mid(buffer, 20, 1) <> " ") Then
            result = False
        End If
        If (Mid(buffer, 26, 1) <> " ") Then
            result = False
        End If
        If (Mid(buffer, 31, 1) <> "-") Then
            result = False
        End If
        If (Val(Mid(buffer, 21, 5)) <> 0) Then
            result = False
        End If

        'VERIFICAMOS COMANDOS

        st = Mid(buffer, 21, 5)

        If (st = "00000") Then hkestado = "El comando se completó con exito"
        If (st = "00002") Then hkestado = "No se encontró protector"
        If (st = "00004") Then hkestado = "Formato de cadena o parámetro incorrecto"
        If (st = "00010") Then hkestado = "Número de conexión no válida"
        If (st = "00011") Then hkestado = "Se superó límite de usuarios permitidos"
        If (st = "00012") Then hkestado = "Módulo yá en uso por la aplicación"
        If (st = "00013") Then hkestado = "Módulo no levantado por la aplicación"
        If (st = "00020") Then hkestado = "No hay drivers HARDkey instalados"
        If (st = "00021") Then hkestado = "Versión de drivers obsoleta"
        If (st = "00022") Then hkestado = "No hay drivers SuperPro instalados"

        ValidaString = result

    End Function

    Public Shared Sub FConexion()
        'Este botón cierra la conexión con la llave

        InitBuffer()
        random = buffer
        buffer = buffer + " " + conexion + " 01379 02849 0002 00"
        buffer = buffer + relleno
        'm_envio.Text = Mid(buffer, 12)
        Call EncriptaString(buffer, password)
        l = HARDkey(buffer)
        Call DesencriptaString(buffer, password)

        'Analizo respuesta para ver si el comando fue completado
        'm_recibo.Text = Mid(buffer, 12)
        If (ValidaString(buffer, random) = True) Then
            'LMemoria.Enabled = False
            'FConexion.Enabled = False
            'm_campos.Text = "conexión  estado  lote-serie   LiGlo"
        Else
            'm_campos.Text = "No se encontró protector"
        End If

    End Sub

    Private Shared Sub LMemoria_Click()
        'Este botón leer los 64 bytes de memoria no-volátil
        'de la llave reservados para el desarrollador

        InitBuffer()
        random = buffer
        buffer = buffer + " " + conexion + " 01379 02849 0005 00044 00064"
        buffer = buffer + relleno
        'm_envio.Text = Mid(buffer, 12)
        Call EncriptaString(buffer, password)
        l = HARDkey(buffer)
        Call DesencriptaString(buffer, password)

        'Analizo respuesta para ver si el comando fue completado
        'm_recibo.Text = Mid(buffer, 12)
        If (ValidaString(buffer, random) = True) Then
            'm_campos.Text = "conexión  estado lote-serie               64 bytes de memoria leidos de la llave. "
            ' FConexion.Select()
        Else
            'm_campos.Text = "No se encontro protector"
        End If

    End Sub



End Class
