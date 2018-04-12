Imports MySql.Data.MySqlClient

Public Class CLASE_DETALLE_FACTURA

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdfactura As Integer
    Public Shared xIdprocedimiento As Integer
    Public Shared xvalor As Double
    Public Shared xcantidad As Integer

#End Region

#Region "Atributos"

    Private Idfactura As Integer
    Private Idprocedimiento As Integer
    Private valor As Double
    Private cantidad As Integer


    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idfactura = 0
        Me.Idprocedimiento = 0
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

    Public Property p_Idfactura() As Integer
        Get
            Return Me.Idfactura
        End Get
        Set(ByVal Value As Integer)
            Me.Idfactura = Value
        End Set
    End Property

    Public Property p_Idprocedimiento() As Integer
        Get
            Return Me.Idprocedimiento
        End Get
        Set(ByVal Value As Integer)
            Me.Idprocedimiento = Value
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

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.detalle_factura  WHERE Idfactura = " & Me.Idfactura & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.detalle_factura (Idfactura, Idprocedimiento, valor, cantidad) " _
            & "VALUES (" & Me.Idfactura & ", " & Me.Idprocedimiento & ", " & Me.valor & ", " & Me.cantidad & " )"


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

            CLASE_GENERAL.sql = "UPDATE orthosoft.detalle_factura SET Idfactura = " & Me.Idfactura & " , Idprocedimiento = " & Me.Idprocedimiento & " , valor = " & Me.valor & " , cantidad = " & Me.cantidad & " " _
            & "WHERE Idfactura = " & Me.Idfactura & " AND Idprocedimiento = " & Me.Idprocedimiento & " AND valor = " & Me.valor & " AND cantidad = " & Me.cantidad & ""

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
                    CLASE_GENERAL.sql = "SELECT Idfactura, Idprocedimiento, valor, cantidad FROM Orthosoft.detalle_cegreso WHERE Idfactura = " & Me.Idfactura & " "

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
