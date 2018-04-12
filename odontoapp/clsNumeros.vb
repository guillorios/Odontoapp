Imports System.Math
Module clsNumeros

    Public Function NroEnLetras(ByVal curNumero As Double, Optional ByVal blnO_Final As Boolean = True) As String

        'Devuelve un número expresado en letras.
        'El parámetro blnO_Final se utiliza en la recursión para saber si se debe colocar
        'la "O" final cuando la palabra es UN(O)

        Dim dblCentavos As Double
        Dim lngContDec As Long
        Dim lngContCent As Long
        Dim lngContMil As Long
        Dim lngContMillon As Long
        Dim strNumLetras As String
        Dim strNumero() As Object = {vbNullString, "UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE", "VEINTE"}
        Dim strDecenas() As Object = {vbNullString, vbNullString, "VEINTI", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA", "CIEN"}
        Dim strCentenas() As Object = {vbNullString, "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS"}
        Dim blnNegativo As Boolean
        Dim blnPlural As Boolean

        strNumLetras = ""

        If curNumero < 0.0# Then
            blnNegativo = True
            curNumero = Abs(curNumero)
        End If

        If Int(curNumero) <> curNumero Then
            dblCentavos = Abs(curNumero - Int(curNumero))
            curNumero = Int(curNumero)
        End If

        Do While curNumero >= 1000000.0#
            lngContMillon = lngContMillon + 1
            curNumero = curNumero - 1000000.0#
        Loop

        Do While curNumero >= 1000.0#
            lngContMil = lngContMil + 1
            curNumero = curNumero - 1000.0#
        Loop

        Do While curNumero >= 100.0#
            lngContCent = lngContCent + 1
            curNumero = curNumero - 100.0#
        Loop

        If Not (curNumero > 10.0# And curNumero <= 20.0#) Then
            Do While curNumero >= 10.0#
                lngContDec = lngContDec + 1
                curNumero = curNumero - 10.0#
            Loop
        End If

        If lngContMillon > 0 Then
            If lngContMillon >= 1 Then   'si el número es >1000000 usa recursividad
                strNumLetras = NroEnLetras(lngContMillon, False)
                If Not blnPlural Then blnPlural = (lngContMillon > 1)
                lngContMillon = 0
            End If
            strNumLetras = Trim(strNumLetras) & strNumero(lngContMillon) & " MILLON" & IIf(blnPlural, "ES ", " ")
        End If

        If lngContMil > 0 Then
            If lngContMil >= 1 Then   'si el número es >100000 usa recursividad
                strNumLetras = strNumLetras & NroEnLetras(lngContMil, False)
                lngContMil = 0
            End If

            If strNumLetras = "UN" Then
                strNumLetras = strNumero(lngContMil) & " MIL "
            Else
                strNumLetras = Trim(strNumLetras) & strNumero(lngContMil) & " MIL "
            End If

        End If

        If lngContCent > 0 Then
            If lngContCent = 1 And lngContDec = 0 And curNumero = 0.0# Then
                strNumLetras = strNumLetras & "CIEN"
            Else
                strNumLetras = strNumLetras & strCentenas(lngContCent) & " "
            End If
        End If

        If lngContDec >= 1 Then
            If lngContDec = 1 Then
                strNumLetras = strNumLetras & strNumero(10)
            Else
                strNumLetras = strNumLetras & strDecenas(lngContDec)
            End If

            If lngContDec >= 3 And curNumero > 0.0# Then
                strNumLetras = strNumLetras & " Y "
            End If
        Else
            If curNumero >= 0.0# And curNumero <= 20.0# Then
                strNumLetras = strNumLetras & strNumero(curNumero)
                If curNumero = 1.0# And blnO_Final Then
                    strNumLetras = strNumLetras & "O"
                End If
                If dblCentavos > 0.0# Then
                    strNumLetras = Trim(strNumLetras) & " CON " & Format$(CInt(dblCentavos * 100.0#), "00") & "/100"
                End If
                NroEnLetras = strNumLetras
                Exit Function
            End If
        End If

        If curNumero > 0.0# Then
            strNumLetras = strNumLetras & strNumero(curNumero)
            If curNumero = 1.0# And blnO_Final Then
                strNumLetras = strNumLetras & "O"
            End If
        End If

        If dblCentavos > 0.0# Then
            strNumLetras = strNumLetras & " CON " + Format$(CInt(dblCentavos * 100.0#), "00") & " CENTAVOS"
        End If

        NroEnLetras = IIf(blnNegativo, "(" & strNumLetras & ")", strNumLetras)

    End Function

End Module
