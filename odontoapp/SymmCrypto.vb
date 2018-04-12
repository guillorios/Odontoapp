Imports System
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class SymmCrypto
#Region "Class Variables"
    ''' <remarks>
    ''' Supported .Net intrinsic SymmetricAlgorithm classes.
    ''' </remarks>
    Public Enum SymmProvEnum As Integer
        DES
        RC2
        Rijndael
    End Enum

    Private mobjCryptoService As SymmetricAlgorithm
#End Region

#Region "Class Constructor"
    ''' <remarks>
    ''' Constructor for using an intrinsic .Net SymmetricAlgorithm class.
    ''' </remarks>
    Public Sub New(ByVal NetSelected As SymmProvEnum)
        Select Case NetSelected
            Case SymmProvEnum.DES
                mobjCryptoService = New DESCryptoServiceProvider()
                Exit Select
            Case SymmProvEnum.RC2
                mobjCryptoService = New RC2CryptoServiceProvider()
                Exit Select
            Case SymmProvEnum.Rijndael
                mobjCryptoService = New RijndaelManaged()
                Exit Select
        End Select
    End Sub

    ''' <remarks>
    ''' Constructor for using a customized SymmetricAlgorithm class.
    ''' </remarks>
    Public Sub New(ByVal ServiceProvider As SymmetricAlgorithm)
        mobjCryptoService = ServiceProvider
    End Sub
#End Region

#Region "Encrypt Data"
    ''' <summary>
    '''
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <param name="Key"></param>
    ''' <returns></returns>
    Public Function Encrypting(ByVal Source As String, ByVal Key As String) As String
        Dim bytIn As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(Source)
        ' create a MemoryStream so that the process can be done without I/O files
        Dim ms As New System.IO.MemoryStream()

        Dim bytKey As Byte() = System.Text.Encoding.Unicode.GetBytes(Key)

        ' set the private key
        mobjCryptoService.Key = bytKey
        mobjCryptoService.IV = bytKey

        ' create an Encryptor from the Provider Service instance
        Dim encrypto As ICryptoTransform = mobjCryptoService.CreateEncryptor()

        ' create Crypto Stream that transforms a stream using the encryption
        Dim cs As New CryptoStream(ms, encrypto, CryptoStreamMode.Write)

        ' write out encrypted content into MemoryStream
        cs.Write(bytIn, 0, bytIn.Length)
        cs.FlushFinalBlock()

        ' get the output and trim the '\0' bytes
        Dim bytOut As Byte() = ms.GetBuffer()
        Dim intByteCount As Integer = 0
        For intByteCount = 0 To bytOut.Length - 1
            If bytOut(intByteCount) = 0 Then
                Exit For
            End If
        Next

        ' convert into Base64 so that the result can be used in xml
        Return System.Convert.ToBase64String(bytOut, 0, intByteCount)
    End Function
#End Region

#Region "Decrypt Data"
    ''' <summary>
    '''
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <param name="Key"></param>
    ''' <returns></returns>
    Public Function Decrypting(ByVal Source As String, ByVal Key As String) As String
        ' convert from Base64 to binary
        Dim bytIn As Byte() = System.Convert.FromBase64String(Source)
        ' create a MemoryStream with the input
        Dim ms As New System.IO.MemoryStream(bytIn, 0, bytIn.Length)

        Dim bytKey As Byte() = System.Text.Encoding.Unicode.GetBytes(Key)

        ' set the private key
        mobjCryptoService.Key = bytKey
        mobjCryptoService.IV = bytKey

        ' create a Decryptor from the Provider Service instance
        Dim encrypto As ICryptoTransform = mobjCryptoService.CreateDecryptor()

        ' create Crypto Stream that transforms a stream using the decryption
        Dim cs As New CryptoStream(ms, encrypto, CryptoStreamMode.Read)

        ' read out the result from the Crypto Stream
        Dim sr As New System.IO.StreamReader(cs)
        Return sr.ReadToEnd()
    End Function
#End Region
End Class





