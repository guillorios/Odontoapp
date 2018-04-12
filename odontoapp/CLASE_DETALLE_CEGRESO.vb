Imports MySql.Data.MySqlClient

Public Class CLASE_DETALLE_CEGRESO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdce As Integer
    Public Shared xIdgasto As Integer
    Public Shared xconcepto As String
    Public Shared xobservacion As String
    Public Shared xvalor As Double
    Public Shared xcantidad As Integer

#End Region

#Region "Atributos"

    Private Idce As Integer
    Private Idgasto As Integer
    Private concepto As String
    Private observacion As String
    Private valor As Double
    Private cantidad As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idce = 0
        Me.Idgasto = 0
        Me.concepto = ""
        Me.observacion = ""
        Me.valor = 0
        Me.cantidad = 0

        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idce() As Integer
        Get
            Return Me.Idce
        End Get
        Set(ByVal Value As Integer)
            Me.Idce = Value
        End Set
    End Property

    Public Property p_Idgasto() As Integer
        Get
            Return Me.Idgasto
        End Get
        Set(ByVal Value As Integer)
            Me.Idgasto = Value
        End Set
    End Property

    Public Property p_concepto() As String
        Get
            Return Me.concepto
        End Get
        Set(ByVal Value As String)
            Me.concepto = Value
        End Set
    End Property

    Public Property p_observacion() As String
        Get
            Return Me.observacion
        End Get
        Set(ByVal Value As String)
            Me.observacion = Value
        End Set
    End Property

    Public Property p_valor() As Double
        Get
            Return Me.valor
        End Get
        Set(ByVal Value As Double)
            Me.valor = Value
        End Set
    End Property

    Public Property p_cantidad() As Integer
        Get
            Return Me.cantidad
        End Get
        Set(ByVal Value As Integer)
            Me.cantidad = Value
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

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.detalle_cegreso WHERE Idce = " & Me.Idce & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.detalle_cegreso (Idce, Idgasto, concepto, observacion, valor, cantidad) " _
            & "VALUES (" & Me.Idce & ", " & Me.Idgasto & ", '" & Me.concepto & "', '" & Me.observacion & "',  " & Me.valor & ", " & Me.cantidad & " )"


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

            CLASE_GENERAL.sql = "UPDATE orthosoft.detalle_cegreso SET Idce = " & Me.Idce & " , concepto = '" & Me.concepto & "', observacion = " & Me.concepto & "',  Idgasto = " & Me.Idgasto & " , valor = " & Me.valor & " , cantidad = " & Me.cantidad & " " _
            & "WHERE Idce = " & Me.Idce & " AND Idgasto = " & Me.Idgasto & " AND valor = " & Me.valor & " AND cantidad = " & Me.cantidad & ""

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
                    CLASE_GENERAL.sql = "SELECT Idce, Idgasto, concepto, observacion, valor, cantidad, (valor * cantidad) as Total FROM Orthosoft.detalle_cegreso WHERE Idce = " & Me.Idce & " "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\cuotaspaciente.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

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
