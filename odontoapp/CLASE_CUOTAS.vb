Imports MySql.Data.MySqlClient
Public Class CLASE_CUOTAS

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdcuota As Integer
    Public Shared xIdpaciente As Integer
    Public Shared xfecha_cuota As String
    Public Shared xIdprocedimiento As String
    Public Shared xprocedimiento_cuota As String
    Public Shared xvalor_cuota As Double
    Public Shared xabono_cuota As Double
    Public Shared xsaldo_cuota As Double
    Public Shared xdescporc_cuota As Double
    Public Shared xvalorporc_cuota As Double
    Public Shared xtipo_cuota As Integer
    Public Shared xIdpresupuesto As Integer

    ' Variables para Sumar

    Public Shared xTotalCuotas As Integer
    Public Shared xTotalAbonos As Integer
    Public Shared xTotalSaldos As Integer


#End Region

#Region "Atributos"

    Private Idcuota As Integer
    Private Idpaciente As Integer
    Private fecha_cuota As String
    Private Idprocedimiento As String
    Private procedimiento_cuota As String
    Private valor_cuota As Double
    Private abono_cuota As Double
    Private saldo_cuota As Double
    Private descporc_cuota As Double
    Private valorporc_cuota As Double
    Private tipo_cuota As Integer
    Private Idpresupuesto As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idcuota = 0
        Me.Idpaciente = 0
        Me.fecha_cuota = ""
        Me.Idprocedimiento = ""
        Me.procedimiento_cuota = ""
        Me.valor_cuota = 0
        Me.abono_cuota = 0
        Me.saldo_cuota = 0
        Me.descporc_cuota = 0
        Me.valorporc_cuota = 0
        Me.tipo_cuota = 0
        Me.Idpresupuesto = 0

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

    Public Property p_Idpaciente() As Integer
        Get
            Return Me.Idpaciente
        End Get
        Set(ByVal Value As Integer)
            Me.Idpaciente = Value
        End Set
    End Property

    Public Property p_fecha_cuota() As String
        Get
            Return Me.fecha_cuota
        End Get
        Set(ByVal Value As String)
            Me.fecha_cuota = Value
        End Set
    End Property

    Public Property p_Idprocedimiento() As String
        Get
            Return Me.Idprocedimiento
        End Get
        Set(ByVal Value As String)
            Me.Idprocedimiento = Value
        End Set
    End Property

    Public Property p_procedimiento_cuota() As String
        Get
            Return Me.procedimiento_cuota
        End Get
        Set(ByVal Value As String)
            Me.procedimiento_cuota = Value
        End Set
    End Property

    Public Property p_valor_cuota() As Double
        Get
            Return Me.valor_cuota
        End Get
        Set(ByVal Value As Double)
            Me.valor_cuota = Value
        End Set
    End Property

    Public Property p_abono_cuota() As Double
        Get
            Return Me.abono_cuota
        End Get
        Set(ByVal Value As Double)
            Me.abono_cuota = Value
        End Set
    End Property

    Public Property p_saldo_cuota() As Double
        Get
            Return Me.saldo_cuota
        End Get
        Set(ByVal Value As Double)
            Me.saldo_cuota = Value
        End Set
    End Property

    Public Property p_descporc_cuota() As Double
        Get
            Return Me.descporc_cuota
        End Get
        Set(ByVal Value As Double)
            Me.descporc_cuota = Value
        End Set
    End Property

    Public Property p_valorporc_cuota() As Double
        Get
            Return Me.valorporc_cuota
        End Get
        Set(ByVal Value As Double)
            Me.valorporc_cuota = Value
        End Set
    End Property

    Public Property p_tipo_cuota() As Integer
        Get
            Return Me.tipo_cuota
        End Get
        Set(ByVal Value As Integer)
            Me.tipo_cuota = Value
        End Set
    End Property

    Public Property p_Idpresupuesto() As Integer
        Get
            Return Me.Idpresupuesto
        End Get
        Set(ByVal Value As Integer)
            Me.Idpresupuesto = Value
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

            Select Case mensaje

                Case "porpresupuesto"

                    CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.cuotas WHERE Idpaciente = " & Me.Idpaciente & " AND Idpresupuesto = " & Me.Idpresupuesto & ""

                Case "porcita"

                    CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.cuotas WHERE Idcuota = " & Me.Idcuota & ""


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

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.cuotas (Idcuota, Idpaciente, fecha_cuota, Idprocedimiento, procedimiento_cuota, valor_cuota, abono_cuota, saldo_cuota, descporc_cuota, valorporc_cuota, tipo_cuota, Idpresupuesto) " _
            & "VALUES (" & Me.Idcuota & ", " & Me.Idpaciente & ", '" & Me.fecha_cuota & "', '" & Me.Idprocedimiento & "', '" & Me.procedimiento_cuota & "', " & Me.valor_cuota & ", " & Me.abono_cuota & ", " & Me.saldo_cuota & ", " & Me.descporc_cuota & ", " & Me.valorporc_cuota & ", " & Me.tipo_cuota & ", " & Me.Idpresupuesto & ")"

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


            Select Case mensaje

                Case "registro"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.cuotas) SET Idpaciente = '" & Me.Idpaciente & "' , fecha_cuota = '" & Me.fecha_cuota & "' , " _
                    & "Idprocedimiento = '" & Me.Idprocedimiento & "', procedimiento_cuota = '" & Me.procedimiento_cuota & "' , valor_cuota = " & Me.valor_cuota & " , abono_cuota = " & Me.abono_cuota & " , " _
                    & "saldo_cuota = " & Me.saldo_cuota & ", descporc_cuota = " & Me.descporc_cuota & ", valorporc_cuota = " & Me.valorporc_cuota & ", " _
                    & "tipo_cuota = " & Me.tipo_cuota & ", Idpresupuesto = " & Me.Idpresupuesto & " " _
                    & "WHERE Idcuota = " & Me.Idcuota & ""

                Case "abono"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.cuotas) SET abono_cuota = abono_cuota + " & Me.abono_cuota & " , saldo_cuota = saldo_cuota - " & Me.saldo_cuota & " " _
                    & "WHERE Idcuota = " & Me.Idcuota & ""

                Case "reversar"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.cuotas) SET abono_cuota = abono_cuota - " & Me.abono_cuota & " , saldo_cuota = saldo_cuota + " & Me.saldo_cuota & " " _
                    & "WHERE Idcuota = " & Me.Idcuota & ""


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
                    CLASE_GENERAL.sql = "SELECT Idcuota, Idpaciente, fecha_cuota, Idprocedimiento, procedimiento_cuota, valor_cuota, abono_cuota, saldo_cuota, descporc_cuota, valorporc_cuota, tipo_cuota, Idpresupuesto FROM Orthosoft.cuotas WHERE Idpaciente = " & Me.Idpaciente & " AND tipo_cuota = " & Me.tipo_cuota & " AND Idpresupuesto = " & Me.Idpresupuesto & " ORDER BY Idcuota, fecha_cuota ASC "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\cuotaspaciente.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idcuota, Idpaciente, fecha_cuota, Idprocedimiento, procedimiento_cuota, valor_cuota, abono_cuota, saldo_cuota, descporc_cuota, valorporc_cuota, tipo_cuota, Idpresupuesto FROM Orthosoft.cuotas WHERE Idcuota = " & Me.Idcuota & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdcuota = CLASE_GENERAL.xdr("Idcuota")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xfecha_cuota = CLASE_GENERAL.xdr("fecha_cuota")
                        xIdprocedimiento = CLASE_GENERAL.xdr("Idprocedimiento")
                        xprocedimiento_cuota = CLASE_GENERAL.xdr("procedimiento_cuota")
                        xvalor_cuota = CLASE_GENERAL.xdr("valor_cuota")
                        xabono_cuota = CLASE_GENERAL.xdr("abono_cuota")
                        xsaldo_cuota = CLASE_GENERAL.xdr("saldo_cuota")
                        xdescporc_cuota = CLASE_GENERAL.xdr("descporc_cuota")
                        xvalorporc_cuota = CLASE_GENERAL.xdr("valorporc_cuota")
                        xtipo_cuota = CLASE_GENERAL.xdr("tipo_cuota")
                        xIdpresupuesto = CLASE_GENERAL.xdr("Idpresupuesto")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

                Case "ultimafecha"

                    CLASE_GENERAL.sql = "SELECT Idcuota, Idpaciente, fecha_cuota FROM Orthosoft.cuotas WHERE Idpaciente  = " & Me.Idpaciente & " AND tipo_cuota = 1 ORDER BY fecha_cuota DESC LIMIT 1 "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdcuota = CLASE_GENERAL.xdr("Idcuota")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xfecha_cuota = CLASE_GENERAL.xdr("fecha_cuota")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

                Case "sumarcuotas"

                    CLASE_GENERAL.sql = "SELECT SUM(valor_cuota) as TOTALCUOTAS, SUM(abono_cuota) as TOTALABONOS, SUM(saldo_cuota) as TOTALSALDOS FROM Orthosoft.cuotas WHERE Idpaciente = " & Me.Idpaciente & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("TOTALCUOTAS") Is DBNull.Value Then
                            xTotalCuotas = 0
                        Else
                            xTotalCuotas = CLASE_GENERAL.xdr("TOTALCUOTAS")
                        End If

                        If CLASE_GENERAL.xdr("TOTALABONOS") Is DBNull.Value Then
                            xTotalAbonos = 0
                        Else
                            xTotalAbonos = CLASE_GENERAL.xdr("TOTALABONOS")
                        End If

                        If CLASE_GENERAL.xdr("TOTALSALDOS") Is DBNull.Value Then
                            xTotalSaldos = 0
                        Else
                            xTotalSaldos = CLASE_GENERAL.xdr("TOTALSALDOS")
                        End If


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
