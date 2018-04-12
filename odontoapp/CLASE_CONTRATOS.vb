Imports MySql.Data.MySqlClient

Public Class CLASE_CONTRATOS

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdcontrato As Integer
    Public Shared xIdpaciente As Integer
    Public Shared xfecha_contr As String
    Public Shared xciudad_contr As String
    Public Shared xnombre_pac As String
    Public Shared xdedoc_pac As String
    Public Shared xMesesDiag As Integer
    Public Shared xCostoTrat As Double
    Public Shared xNCuotaIni As Integer
    Public Shared xVCuotaIni As Double
    Public Shared xNCuotaMen As Integer
    Public Shared xVCuotaMen As Double
    Public Shared xVMulta As Double
    Public Shared xVTuboM As Double
    Public Shared xVBracket As Double

#End Region

#Region "Atributos"

    Private Idcontrato As Integer
    Private Idpaciente As Integer
    Private fecha_contr As String
    Private ciudad_contr As String
    Private nombre_pac As String
    Private dedoc_pac As String
    Private MesesDiag As Integer
    Private CostoTrat As Double
    Private NCuotaIni As Integer
    Private VCuotaIni As Double
    Private NCuotaMen As Integer
    Private VCuotaMen As Double
    Private VMulta As Double
    Private VTuboM As Double
    Private VBracket As Double

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Idcontrato = 0
        Me.Idpaciente = 0
        Me.fecha_contr = ""
        Me.ciudad_contr = ""
        Me.nombre_pac = ""
        Me.dedoc_pac = ""
        Me.MesesDiag = 0
        Me.CostoTrat = 0
        Me.NCuotaIni = 0
        Me.VCuotaIni = 0
        Me.NCuotaMen = 0
        Me.VCuotaMen = 0
        Me.VMulta = 0
        Me.VTuboM = 0
        Me.VBracket = 0

        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idcontrato() As Integer
        Get
            Return Me.Idcontrato
        End Get
        Set(ByVal Value As Integer)
            Me.Idcontrato = Value
        End Set
    End Property

    Public Property p_Idpaciente() As Integer
        Get
            Return Me.Idpaciente
        End Get
        Set(ByVal Value As Integer)
            Me.Idpaciente = Value
        End Set
    End Property

    Public Property p_fecha_contr() As String
        Get
            Return Me.fecha_contr
        End Get
        Set(ByVal Value As String)
            Me.fecha_contr = Value
        End Set
    End Property

    Public Property p_ciudad_contr() As String
        Get
            Return Me.ciudad_contr
        End Get
        Set(ByVal Value As String)
            Me.ciudad_contr = Value
        End Set
    End Property

    Public Property p_nombre_pac() As String
        Get
            Return Me.nombre_pac
        End Get
        Set(ByVal Value As String)
            Me.nombre_pac = Value
        End Set
    End Property

    Public Property p_dedoc_pac() As String
        Get
            Return Me.dedoc_pac
        End Get
        Set(ByVal Value As String)
            Me.dedoc_pac = Value
        End Set
    End Property

    Public Property p_MesesDiag() As Double
        Get
            Return Me.MesesDiag
        End Get
        Set(ByVal Value As Double)
            Me.MesesDiag = Value
        End Set
    End Property

    Public Property p_CostoTrat() As Double
        Get
            Return Me.CostoTrat
        End Get
        Set(ByVal Value As Double)
            Me.CostoTrat = Value
        End Set
    End Property

    Public Property p_NCuotaIni() As Double
        Get
            Return Me.NCuotaIni
        End Get
        Set(ByVal Value As Double)
            Me.NCuotaIni = Value
        End Set
    End Property

    Public Property p_VCuotaIni() As Double
        Get
            Return Me.VCuotaIni
        End Get
        Set(ByVal Value As Double)
            Me.VCuotaIni = Value
        End Set
    End Property

    Public Property p_NCuotaMen() As Double
        Get
            Return Me.NCuotaMen
        End Get
        Set(ByVal Value As Double)
            Me.NCuotaMen = Value
        End Set
    End Property

    Public Property p_VCuotaMen() As Double
        Get
            Return Me.VCuotaMen
        End Get
        Set(ByVal Value As Double)
            Me.VCuotaMen = Value
        End Set
    End Property

    Public Property p_VMulta() As Double
        Get
            Return Me.VMulta
        End Get
        Set(ByVal Value As Double)
            Me.VMulta = Value
        End Set
    End Property

    Public Property p_VTuboM() As Double
        Get
            Return Me.VTuboM
        End Get
        Set(ByVal Value As Double)
            Me.VTuboM = Value
        End Set
    End Property

    Public Property p_VBracket() As Double
        Get
            Return Me.VBracket
        End Get
        Set(ByVal Value As Double)
            Me.VBracket = Value
        End Set
    End Property

    Public ReadOnly Property p_dt() As DataTable
        Get
            Return Me.dt
        End Get
    End Property

#End Region


    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

        Try

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.contratos WHERE Idpaciente = " & Me.Idpaciente & ""

            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            Return True

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.contratos (Idcontrato, Idpaciente, fecha_contr, ciudad_contr, nombre_pac, dedoc_pac, MesesDiag, " _
            & "CostoTrat, NCuotaIni, VCuotaIni, NCuotaMen, VCuotaMen, VMulta, VTuboM, VBracket) " _
            & "VALUES (" & Me.Idcontrato & ", " & Me.Idpaciente & ", '" & Me.fecha_contr & "', '" & Me.ciudad_contr & "', '" & Me.nombre_pac & "', '" & Me.dedoc_pac & "', " & Me.MesesDiag & ", " _
            & "" & Me.CostoTrat & ", " & Me.NCuotaIni & ", " & Me.VCuotaIni & ", " & Me.NCuotaMen & ", " & Me.VCuotaMen & ", " & Me.VMulta & ", " & Me.VTuboM & ", " & Me.VBracket & ")"

            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            Return True

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Modificar

        Try

            CLASE_GENERAL.sql = "UPDATE (Orthosoft.contratos) SET fecha_contr = '" & Me.fecha_contr & "' , ciudad_contr = '" & Me.ciudad_contr & "' , nombre_pac = '" & Me.nombre_pac & "' , " _
            & "dedoc_pac = '" & Me.dedoc_pac & "' , MesesDiag = " & Me.MesesDiag & " , CostoTrat = " & Me.CostoTrat & " , NCuotaIni = " & Me.NCuotaIni & " , VCuotaIni = " & Me.VCuotaIni & ", NCuotaMen = " & Me.NCuotaMen & " , " _
            & "VCuotaMen = " & Me.VCuotaMen & " , VMulta = " & Me.VMulta & " , VTuboM = " & Me.VTuboM & ", VBracket = " & Me.VBracket & " WHERE Idpaciente = " & Me.Idpaciente & ""

            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            Return True

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar
        Try

            Select Case mensaje

                Case "tabla"

                    CLASE_GENERAL.xds = New DataSet
                    CLASE_GENERAL.sql = "SELECT Idcontrato, Idpaciente, fecha_contr, ciudad_contr, nombre_pac, dedoc_pac, MesesDiag, CostoTrat, NCuotaIni, VCuotaIni, NCuotaMen, " _
                    & "VCuotaMen, VMulta, VTuboM, VBracket FROM Orthosoft.contratos"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xds) 'Ejecutar par cargar en combo

                    CLASE_GENERAL.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idcontrato, Idpaciente, fecha_contr, ciudad_contr, nombre_pac, dedoc_pac, MesesDiag, CostoTrat, NCuotaIni, VCuotaIni, NCuotaMen, " _
                    & "VCuotaMen, VMulta, VTuboM, VBracket FROM Orthosoft.contratos WHERE Idpaciente = " & Me.Idpaciente & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdcontrato = CLASE_GENERAL.xdr("Idcontrato")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xfecha_contr = CLASE_GENERAL.xdr("fecha_contr")
                        xciudad_contr = CLASE_GENERAL.xdr("ciudad_contr")
                        xnombre_pac = CLASE_GENERAL.xdr("nombre_pac")
                        xdedoc_pac = CLASE_GENERAL.xdr("dedoc_pac")
                        xMesesDiag = CLASE_GENERAL.xdr("MesesDiag")
                        xCostoTrat = CLASE_GENERAL.xdr("CostoTrat")
                        xNCuotaIni = CLASE_GENERAL.xdr("NCuotaIni")
                        xVCuotaIni = CLASE_GENERAL.xdr("VCuotaIni")
                        xNCuotaMen = CLASE_GENERAL.xdr("NCuotaMen")
                        xVCuotaMen = CLASE_GENERAL.xdr("VCuotaMen")
                        xVMulta = CLASE_GENERAL.xdr("VMulta")
                        xVTuboM = CLASE_GENERAL.xdr("VTuboM")
                        xVBracket = CLASE_GENERAL.xdr("VBracket")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If


            End Select

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try 'cierra la sentencia


    End Function
End Class
