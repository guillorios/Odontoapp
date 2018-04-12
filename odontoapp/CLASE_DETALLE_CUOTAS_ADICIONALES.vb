Imports MySql.Data.MySqlClient

Public Class CLASE_DETALLE_CUOTAS_ADICIONALES

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdcuota As Integer
    Public Shared xIdprocedimiento As Integer
    Public Shared xdetalle As String
    Public Shared xreferencia As String
    Public Shared xvalor As Double
    Public Shared xcantidad As Integer

#End Region

#Region "Atributos"

    Private Idcuota As Integer
    Private Idprocedimiento As Integer
    Private detalle As String
    Private referencia As String
    Private valor As Double
    Private cantidad As Integer


    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idcuota = 0
        Me.Idprocedimiento = 0
        Me.detalle = ""
        Me.referencia = ""
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

    Public Property p_Idcuota() As Integer
        Get
            Return Me.Idcuota
        End Get
        Set(ByVal Value As Integer)
            Me.Idcuota = Value
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

    Public Property p_detalle() As String
        Get
            Return Me.detalle
        End Get
        Set(ByVal Value As String)
            Me.detalle = Value
        End Set
    End Property

    Public Property p_referencia() As String
        Get
            Return Me.referencia
        End Get
        Set(ByVal Value As String)
            Me.referencia = Value
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

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.detalle_cuotas_adicionales WHERE Idcuota = " & Me.Idcuota & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.detalle_cuotas_adicionales (Idcuota, Idprocedimiento, detalle, referencia, valor, cantidad) " _
            & "VALUES (" & Me.Idcuota & ", " & Me.Idprocedimiento & ", '" & Me.detalle & "', '" & Me.referencia & "', " & Me.valor & ", " & Me.cantidad & " )"


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

            CLASE_GENERAL.sql = "UPDATE orthosoft.detalle_cuotas_adicionales  SET Idcuota = " & Me.Idcuota & " , Idprocedimiento = " & Me.Idprocedimiento & " , detalle= '" & Me.detalle & "', referencia = '" & Me.referencia & "', valor = " & Me.valor & " , cantidad = " & Me.cantidad & " " _
            & "WHERE Idcuota = " & Me.Idcuota & " AND Idprocedimiento = " & Me.Idprocedimiento & " AND detalle = '" & Me.detalle & "' AND referencia = '" & Me.referencia & "' AND valor = " & Me.valor & " AND cantidad = " & Me.cantidad & ""

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
                    CLASE_GENERAL.sql = "SELECT Idcuota, Idprocedimiento, detalle, referencia, valor, cantidad , (valor * cantidad) as Total FROM orthosoft.detalle_cuotas_adicionales WHERE Idcuota = " & Me.Idcuota & " "

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
