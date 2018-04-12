Imports MySql.Data.MySqlClient

Public Class CLASE_CEGRESO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdce As Integer
    Public Shared xciudad_ce As String
    Public Shared xIdproveedor As Integer
    Public Shared xconcepto_ce As String
    Public Shared xcheque_ce As String
    Public Shared xbanco_ce As String
    Public Shared xdebitesea_ce As String
    Public Shared xIdUsuario As Integer
    Public Shared xfecha_ce As String
    Public Shared xtotal_ce As Double
    Public Shared xIdestado As Integer
    Public Shared xobservaciones_ce As String
    Public Shared xestado_cuadre As Integer
    Public Shared xIdlibrodiario As Integer

#End Region

#Region "Atributos"

    Private Idce As Integer
    Private ciudad_ce As String
    Private Idproveedor As Integer
    Private concepto_ce As String
    Private cheque_ce As String
    Private banco_ce As String
    Private debitesea_ce As String
    Private IdUsuario As Integer
    Private fecha_ce As String
    Private total_ce As Double
    Private Idestado As Integer
    Private observaciones_ce As String
    Private estado_cuadre As Integer
    Private Idlibrodiario As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idce = 0
        Me.ciudad_ce = ""
        Me.Idproveedor = 0
        Me.concepto_ce = ""
        Me.cheque_ce = ""
        Me.banco_ce = ""
        Me.debitesea_ce = ""
        Me.IdUsuario = 0
        Me.fecha_ce = ""
        Me.total_ce = 0
        Me.Idestado = 0
        Me.observaciones_ce = ""
        Me.estado_cuadre = 0
        Me.Idlibrodiario = 0

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

    Public Property p_ciudad_ce() As String
        Get
            Return Me.ciudad_ce
        End Get
        Set(ByVal Value As String)
            Me.ciudad_ce = Value
        End Set
    End Property

    Public Property p_Idproveedor() As Integer
        Get
            Return Me.Idproveedor
        End Get
        Set(ByVal Value As Integer)
            Me.Idproveedor = Value
        End Set
    End Property

    Public Property p_concepto_ce() As String
        Get
            Return Me.concepto_ce
        End Get
        Set(ByVal Value As String)
            Me.concepto_ce = Value
        End Set
    End Property

    Public Property p_cheque_ce() As String
        Get
            Return Me.cheque_ce
        End Get
        Set(ByVal Value As String)
            Me.cheque_ce = Value
        End Set
    End Property

    Public Property p_banco_ce() As String
        Get
            Return Me.banco_ce
        End Get
        Set(ByVal Value As String)
            Me.banco_ce = Value
        End Set
    End Property

    Public Property p_debitesea_ce() As String
        Get
            Return Me.debitesea_ce
        End Get
        Set(ByVal Value As String)
            Me.debitesea_ce = Value
        End Set
    End Property

    Public Property p_IdUsuario() As Integer
        Get
            Return Me.IdUsuario
        End Get
        Set(ByVal Value As Integer)
            Me.IdUsuario = Value
        End Set
    End Property

    Public Property p_fecha_ce() As String
        Get
            Return Me.fecha_ce
        End Get
        Set(ByVal Value As String)
            Me.fecha_ce = Value
        End Set
    End Property

    Public Property p_total_ce() As Double
        Get
            Return Me.total_ce
        End Get
        Set(ByVal Value As Double)
            Me.total_ce = Value
        End Set
    End Property

    Public Property p_Idestado() As Integer
        Get
            Return Me.Idestado
        End Get
        Set(ByVal Value As Integer)
            Me.Idestado = Value
        End Set
    End Property

    Public Property p_observaciones_ce() As String
        Get
            Return Me.observaciones_ce
        End Get
        Set(ByVal Value As String)
            Me.observaciones_ce = Value
        End Set
    End Property

    Public Property p_estado_cuadre() As Integer
        Get
            Return Me.estado_cuadre
        End Get
        Set(ByVal Value As Integer)
            Me.estado_cuadre = Value
        End Set
    End Property

    Public Property p_Idlibrodiario() As Integer

        Get
            Return Me.Idlibrodiario
        End Get

        Set(ByVal Value As Integer)
            Me.Idlibrodiario = Value
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

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.cegreso WHERE Idce = " & Me.Idce & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.cegreso (Idce, ciudad_ce, Idproveedor, concepto_ce, cheque_ce, banco_ce, debitesea_ce, IdUsuario, fecha_ce, total_ce, Idestado, observaciones_ce, estado_cuadre, Idlibrodiario) " _
            & "VALUES (" & Me.Idce & ", '" & Me.ciudad_ce & "', " & Me.Idproveedor & ", '" & Me.concepto_ce & "', '" & Me.cheque_ce & "', '" & Me.banco_ce & "', '" & Me.debitesea_ce & "', " & Me.IdUsuario & ", '" & Me.fecha_ce & "', " & Me.total_ce & ", " & Me.Idestado & ", '" & Me.observaciones_ce & "', " & Me.estado_cuadre & ", " & Me.Idlibrodiario & ")"

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

            Select mensaje

                Case "registro"

                    CLASE_GENERAL.sql = "UPDATE orthosoft.cegreso SET ciudad_ce = '" & Me.ciudad_ce & " , Idproveedor = " & Me.Idproveedor & " , concepto_ce = '" & Me.concepto_ce & "' , cheque_ce = '" & Me.cheque_ce & "' , banco_ce = '" & Me.banco_ce & "' , " _
                    & "debitesea_ce = '" & Me.debitesea_ce & "' , IdUsuario = " & Me.IdUsuario & " , fecha_ce = '" & Me.fecha_ce & "' , total_ce = " & Me.total_ce & ", Idestado = " & Me.Idestado & ", observaciones_ce = '" & Me.observaciones_ce & ", estado_cuadre = " & Me.estado_cuadre & " WHERE Idce = " & Me.Idce & ""

                Case "estado"

                    CLASE_GENERAL.sql = "UPDATE orthosoft.cegreso SET Idestado = " & Me.Idestado & " WHERE Idce = " & Me.Idce & ""

                Case "cuadre"

                    CLASE_GENERAL.sql = "UPDATE orthosoft.cegreso SET estado_cuadre = " & Me.estado_cuadre & ", Idlibrodiario = " & Me.Idlibrodiario & " WHERE Idce = " & Me.Idce & ""


            End Select

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
                    CLASE_GENERAL.sql = "SELECT Idce, ciudad_ce, Idproveedor, concepto_ce, cheque_ce, banco_ce, debitesea_ce, IdUsuario, fecha_ce, total_ce, Idestado, observaciones_ce, estado_cuadre, Idlibrodiario FROM Orthosoft.cegreso"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\cuotaspaciente.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "recibo"

                    CLASE_GENERAL.xdt = New DataTable

                    CLASE_GENERAL.sql = "SELECT consultorio.*, proveedores.*, empleados.*, cegreso.*, detalle_cegreso.* FROM Orthosoft.cegreso INNER JOIN orthosoft.detalle_cegreso ON (cegreso.Idce = detalle_cegreso.Idce) INNER JOIN orthosoft.proveedores ON (proveedores.Idproveedor = cegreso.Idproveedor) INNER JOIN orthosoft.empleados ON (cegreso.Idusuario = empleados.Idempleado) INNER JOIN orthosoft.consultorio ON (consultorio.Idconsultorio = proveedores.Idconsultorio) WHERE detalle_cegreso.Idce = " & Me.Idce & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\recibocegreso.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idce, ciudad_ce, Idproveedor, concepto_ce, cheque_ce, banco_ce, debitesea_ce, IdUsuario, fecha_ce, total_ce, Idestado, observaciones_ce, estado_cuadre, Idlibrodiario FROM Orthosoft.cegreso WHERE Idce = " & Me.Idce & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdce = CLASE_GENERAL.xdr("Idce")
                        xciudad_ce = CLASE_GENERAL.xdr("ciudad_ce")
                        xIdproveedor = CLASE_GENERAL.xdr("Idproveedor")
                        xconcepto_ce = CLASE_GENERAL.xdr("concepto_ce")
                        xcheque_ce = CLASE_GENERAL.xdr("cheque_ce")
                        xbanco_ce = CLASE_GENERAL.xdr("banco_ce")
                        xdebitesea_ce = CLASE_GENERAL.xdr("debitesea_ce")
                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xfecha_ce = CLASE_GENERAL.xdr("fecha_ce")
                        xtotal_ce = CLASE_GENERAL.xdr("total_ce")
                        xIdestado = CLASE_GENERAL.xdr("Idestado")
                        xobservaciones_ce = CLASE_GENERAL.xdr("observaciones_ce")
                        xestado_cuadre = CLASE_GENERAL.xdr("estado_cuadre")
                        xIdlibrodiario = CLASE_GENERAL.xdr("Idlibrodiario")

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
