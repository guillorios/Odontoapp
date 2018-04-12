Imports MySql.Data.MySqlClient

Public Class CLASE_FACTURA

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdfactura As Integer
    Public Shared xIdpaciente As Integer
    Public Shared xremitidopor_fac As String
    Public Shared xfecha_fac As String
    Public Shared xvalor_fac As Double
    Public Shared xdescuento_fac As Integer
    Public Shared xiva_fac As Integer
    Public Shared xsubtotal_fac As Double
    Public Shared xtotal_fac As Double

#End Region

#Region "Atributos"

    Private Idfactura As Integer
    Private Idpaciente As Integer
    Private remitidopor_fac As String
    Private fecha_fac As String
    Private valor_fac As Double
    Private descuento_fac As Integer
    Private iva_fac As Integer
    Private subtotal_fac As Double
    Private total_fac As Double

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idpaciente = 0
        Me.remitidopor_fac = ""
        Me.fecha_fac = ""
        Me.valor_fac = 0
        Me.descuento_fac = 0
        Me.iva_fac = 0
        Me.subtotal_fac = 0
        Me.total_fac = 0

        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idpaciente() As Integer
        Get
            Return Me.Idpaciente
        End Get
        Set(ByVal Value As Integer)
            Me.Idpaciente = Value
        End Set
    End Property

    Public Property p_remitidopor_fac() As String
        Get
            Return Me.remitidopor_fac
        End Get
        Set(ByVal Value As String)
            Me.remitidopor_fac = Value
        End Set
    End Property

    Public Property p_fecha_fac() As String
        Get
            Return Me.fecha_fac
        End Get
        Set(ByVal Value As String)
            Me.fecha_fac = Value
        End Set
    End Property

    Public Property p_valor_fac() As Double
        Get
            Return Me.valor_fac
        End Get
        Set(ByVal Value As Double)
            Me.valor_fac = Value
        End Set
    End Property

    Public Property p_descuento_fac() As Integer
        Get
            Return Me.descuento_fac
        End Get
        Set(ByVal Value As Integer)
            Me.descuento_fac = Value
        End Set
    End Property

    Public Property p_iva_facc() As Integer
        Get
            Return Me.iva_fac
        End Get
        Set(ByVal Value As Integer)
            Me.iva_fac = Value
        End Set
    End Property

    Public Property p_subtotal_fac() As Double
        Get
            Return Me.subtotal_fac
        End Get
        Set(ByVal Value As Double)
            Me.subtotal_fac = Value
        End Set
    End Property

    Public Property p_total_fac() As Double
        Get
            Return Me.total_fac
        End Get
        Set(ByVal Value As Double)
            Me.total_fac = Value
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

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.factura WHERE Idfactura = " & Me.Idfactura & ""
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

            CLASE_GENERAL.sql = "IINSERT INTO orthosoft.factura (Idfactura, Idpaciente, remitidopor_fac, fecha_fac, valor_fac, descuento_fac, iva_fac, subtotal_fac, total_fac) " _
            & "VALUES (" & Me.Idfactura & ", " & Me.Idpaciente & ", '" & Me.remitidopor_fac & "', '" & Me.fecha_fac & "', " & Me.valor_fac & ", " & Me.descuento_fac & ", " & Me.iva_fac & ", " & Me.subtotal_fac & ", " & Me.total_fac & ")"

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

            CLASE_GENERAL.sql = "UPDATE orthosoft.factura SET Idfactura = " & Me.Idfactura & " , Idpaciente = " & Me.Idpaciente & " , remitidopor_fac = '" & Me.remitidopor_fac & "' , fecha_fac = '" & Me.fecha_fac & "' , valor_fac = " & Me.valor_fac & " , descuento_fac = " & Me.descuento_fac & " , iva_fac = " & Me.iva_fac & " , subtotal_fac = " & Me.subtotal_fac & " , total_fac = " & Me.total_fac & "" _
            & "WHERE Idfactura = " & Me.Idfactura & ""

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

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT RC.*, RIGHT(CONCAT('0000000000000', RC.IDRC), 7) AS IDRC FROM RCAJA RC WHERE RC.IDRC = " & Me.Idfactura & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informe"

                    CLASE_GENERAL.xdt = New DataTable

                    CLASE_GENERAL.sql = "SELECT RC.*, RIGHT(CONCAT('0000000000000', RC.IDRC), 4) AS IDRCFORM, CONCAT(EMP.nombres_emp,' ', EMP.apellidos_emp) as Nombres  FROM RCAJA RC, EMPLEADOS EMP WHERE RC.recibido = EMP.IDEMPLEADO AND RC.IDRC = " & Me.Idfactura & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\pruebas\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idfactura, Idpaciente, remitidopor_fac, fecha_fac, valor_fac, descuento_fac, iva_fac, subtotal_fac, total_fac FROM Orthosoft.factura"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdfactura = CLASE_GENERAL.xdr("Idfactura")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xremitidopor_fac = CLASE_GENERAL.xdr("remitidopor_fac")
                        xfecha_fac = CLASE_GENERAL.xdr("fecha_fac")
                        xvalor_fac = CLASE_GENERAL.xdr("Idrc")
                        xdescuento_fac = CLASE_GENERAL.xdr("descuento_fac")
                        xiva_fac = CLASE_GENERAL.xdr("iva_fac")
                        xsubtotal_fac = CLASE_GENERAL.xdr("subtotal_fac")
                        xtotal_fac = CLASE_GENERAL.xdr("total_fac")

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
