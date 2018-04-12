Imports MySql.Data.MySqlClient

Public Class CLASE_RCAJA

    Implements Clase_general.DML

#Region "Consultas"

    Public Shared xIdrc As Integer
    Public Shared xfecha_rc As String
    Public Shared xIdpaciente As Integer
    Public Shared xtotal_rc As Double
    Public Shared xconcepto_rc As String
    Public Shared xcheque_rc As String
    Public Shared xbanco_rc As String
    Public Shared xefectivo_rc As Double
    Public Shared xtarjeta_rc As Double
    Public Shared xabono_rc As Double
    Public Shared xsaldo_rc As Double
    Public Shared xIdusuario As Integer
    Public Shared xIdestado As Integer
    Public Shared xobservaciones_rc As String
    Public Shared xestado_cuadre As Integer
    Public Shared xIdlibrodiario As Integer
    Public Shared xIddoctor As Integer

#End Region

#Region "Atributos"

    Private Idrc As Integer
    Private fecha_rc As String
    Private Idpaciente As Integer
    Private total_rc As Double
    Private concepto_rc As String
    Private cheque_rc As String
    Private banco_rc As String
    Private efectivo_rc As Double
    Private tarjeta_rc As Double
    Private abono_rc As Double
    Private saldo_rc As Double
    Private Idusuario As Integer
    Private Idestado As Integer
    Private observaciones_rc As String
    Private estado_cuadre As Integer
    Private Idlibrodiario As Integer
    Private Iddoctor As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idrc = 0
        Me.fecha_rc = ""
        Me.Idpaciente = 0
        Me.total_rc = 0
        Me.concepto_rc = ""
        Me.cheque_rc = ""
        Me.banco_rc = ""
        Me.efectivo_rc = 0
        Me.tarjeta_rc = 0
        Me.abono_rc = 0
        Me.saldo_rc = 0
        Me.Idusuario = 0
        Me.Idestado = 0
        Me.observaciones_rc = ""
        Me.estado_cuadre = 0
        Me.Idlibrodiario = 0
        Me.Iddoctor = 0

        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idrc() As Integer
        Get
            Return Me.Idrc
        End Get
        Set(ByVal Value As Integer)
            Me.Idrc = Value
        End Set
    End Property

    Public Property p_fecha_rc() As String
        Get
            Return Me.fecha_rc
        End Get
        Set(ByVal Value As String)
            Me.fecha_rc = Value
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

    Public Property p_total_rc() As Double
        Get
            Return Me.total_rc
        End Get
        Set(ByVal Value As Double)
            Me.total_rc = Value
        End Set
    End Property

    Public Property p_concepto_rc() As String
        Get
            Return Me.concepto_rc
        End Get
        Set(ByVal Value As String)
            Me.concepto_rc = Value
        End Set
    End Property

    Public Property p_cheque_rc() As String
        Get
            Return Me.cheque_rc
        End Get
        Set(ByVal Value As String)
            Me.cheque_rc = Value
        End Set
    End Property

    Public Property p_banco_rc() As String
        Get
            Return Me.banco_rc
        End Get
        Set(ByVal Value As String)
            Me.banco_rc = Value
        End Set
    End Property

    Public Property p_efectivo_rc() As Double
        Get
            Return Me.efectivo_rc
        End Get
        Set(ByVal Value As Double)
            Me.efectivo_rc = Value
        End Set
    End Property

    Public Property p_tarjeta_rc() As Double
        Get
            Return Me.tarjeta_rc
        End Get
        Set(ByVal Value As Double)
            Me.tarjeta_rc = Value
        End Set
    End Property

    Public Property p_abono_rc() As Double
        Get
            Return Me.abono_rc
        End Get
        Set(ByVal Value As Double)
            Me.abono_rc = Value
        End Set
    End Property

    Public Property p_saldo_rc() As Double
        Get
            Return Me.saldo_rc
        End Get
        Set(ByVal Value As Double)
            Me.saldo_rc = Value
        End Set
    End Property

    Public Property p_Idusuario() As Integer
        Get
            Return Me.Idusuario
        End Get
        Set(ByVal Value As Integer)
            Me.Idusuario = Value
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

    Public Property p_observaciones_rc() As String
        Get
            Return Me.observaciones_rc
        End Get
        Set(ByVal Value As String)
            Me.observaciones_rc = Value
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

    Public Property p_Iddoctor() As Integer
        Get
            Return Me.Iddoctor
        End Get
        Set(ByVal Value As Integer)
            Me.Iddoctor = Value
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

            CLASE_GENERAL.sql = "DELETE QUICK FROM rcaja WHERE Idrc = " & Me.Idrc & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.rcaja (Idrc, fecha_rc, Idpaciente, total_rc, concepto_rc, cheque_rc, banco_rc, efectivo_rc, tarjeta_rc, abono_rc, saldo_rc, Idusuario, Idestado, observaciones_rc, estado_cuadre, Idlibrodiario, Iddoctor) " _
            & "VALUES (" & Me.Idrc & ", '" & Me.fecha_rc & "', " & Me.Idpaciente & ", " & Me.total_rc & ", '" & Me.concepto_rc & "', '" & Me.cheque_rc & "', '" & Me.banco_rc & "', " & Me.efectivo_rc & ", " & Me.tarjeta_rc & ", " & Me.abono_rc & ", " & Me.saldo_rc & ", " & Me.Idusuario & ", " & Me.Idestado & ", '" & Me.observaciones_rc & "', " & Me.estado_cuadre & ", " & Me.Idlibrodiario & ", " & Me.Iddoctor & ")"

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

                    CLASE_GENERAL.sql = "UPDATE orthosoft.rcaja SET fecha_rc = '" & Me.fecha_rc & "' , Idpaciente = " & Me.Idpaciente & " , total_rc = '" & Me.total_rc & "' , concepto_rc = '" & Me.concepto_rc & "' , cheque_rc = '" & Me.cheque_rc & "' , banco_rc = '" & Me.banco_rc & "' , " _
                    & "efectivo_rc = " & Me.efectivo_rc & "', tarjeta_rc = " & Me.tarjeta_rc & ", abono_rc = " & Me.abono_rc & " , saldo_rc = " & Me.saldo_rc & " , Idusuario = " & Me.Idusuario & ", Idestado = " & Me.Idestado & ", observaciones_rc = '" & Me.observaciones_rc & "', estado_cuadre = " & Me.estado_cuadre & ", Idlibrodiario = " & Me.Idlibrodiario & ", Iddoctor = " & Me.Iddoctor & " WHERE Idrc = " & Me.Idrc & ""

                Case "estado"

                    CLASE_GENERAL.sql = "UPDATE orthosoft.rcaja SET Idestado = " & Me.Idestado & " WHERE Idrc = " & Me.Idrc & ""

                Case "cuadre"

                    CLASE_GENERAL.sql = "UPDATE orthosoft.rcaja SET estado_cuadre = " & Me.estado_cuadre & ", Idlibrodiario = " & Me.Idlibrodiario & " WHERE Idrc = " & Me.Idrc & ""



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
                    CLASE_GENERAL.sql = "SELECT RC.*, RIGHT(CONCAT('0000000000000', RC.IDRC), 7) AS IDRC FROM RCAJA RC WHERE RC.IDRC = " & Me.Idrc & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informe"

                    Clase_general.xdt = New DataTable

                    CLASE_GENERAL.sql = "SELECT RC.*, RIGHT(CONCAT('0000000000000', RC.IDRC), 4) AS IDRCFORM, CONCAT(EMP.nombres_emp,' ', EMP.apellidos_emp) as Nombres  FROM RCAJA RC, EMPLEADOS EMP WHERE RC.recibido = EMP.IDEMPLEADO AND RC.IDRC = " & Me.IDRC & ""

                    Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
                    Clase_general.xda = New MySqlDataAdapter(Clase_general.xcomando)

                    Clase_general.xda.Fill(Clase_general.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\pruebas\dataset.xml", XmlWriteMode.WriteSchema)

                    Clase_general.xda.Dispose()
                    Clase_general.xda = Nothing
                    Clase_general.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "recibo"

                    CLASE_GENERAL.xdt = New DataTable

                    CLASE_GENERAL.sql = "SELECT consultorio.*, pacientes.apellidos_pac, pacientes.nombres_pac, pacientes.residencia_pac, pacientes.numdoc_pac, pacientes.dedoc_pac, pacientes.nhclinica, empleados.nombres_emp, empleados.apellidos_emp, rcaja.*, detalle_rcaja.*, doctores.nombres_doc, doctores.apellidos_doc  FROM Orthosoft.consultorio " _
                    & "INNER JOIN orthosoft.pacientes ON (consultorio.Idconsultorio = pacientes.Idconsultorio) " _
                    & "INNER JOIN orthosoft.rcaja ON (pacientes.Idpaciente = rcaja.Idpaciente) " _
                    & "INNER JOIN orthosoft.empleados ON (empleados.Idempleado = rcaja.Idusuario) " _
                    & "INNER JOIN orthosoft.detalle_rcaja ON (rcaja.Idrc = detalle_rcaja.Idrc) " _
                    & "INNER JOIN orthosoft.doctores ON (doctores.Iddoctor = rcaja.Iddoctor) " _
                    & "WHERE detalle_rcaja.Idrc = " & Me.Idrc & ""


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("d:\varios\recibocaja.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idrc, fecha_rc, Idpaciente, total_rc, concepto_rc, cheque_rc, banco_rc, efectivo_rc, tarjeta_rc, abono_rc, saldo_rc, Idusuario, Idestado, observaciones_rc, estado_cuadre, Idlibrodiario, Iddoctor FROM Orthosoft.rcaja WHERE Idrc = " & Me.Idrc & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdrc = CLASE_GENERAL.xdr("Idrc")
                        xfecha_rc = CLASE_GENERAL.xdr("fecha_rc")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xtotal_rc = CLASE_GENERAL.xdr("total_rc")
                        xconcepto_rc = CLASE_GENERAL.xdr("concepto_rc")
                        xcheque_rc = CLASE_GENERAL.xdr("cheque_rc")
                        xbanco_rc = CLASE_GENERAL.xdr("banco_rc")
                        xefectivo_rc = CLASE_GENERAL.xdr("efectivo_rc")
                        xtarjeta_rc = CLASE_GENERAL.xdr("tarjeta_rc")
                        xabono_rc = CLASE_GENERAL.xdr("abono_rc")
                        xsaldo_rc = CLASE_GENERAL.xdr("saldo_rc")
                        xIdusuario = CLASE_GENERAL.xdr("Idusuario")
                        xIdestado = CLASE_GENERAL.xdr("Idestado")
                        xobservaciones_rc = CLASE_GENERAL.xdr("observaciones_rc")
                        xestado_cuadre = CLASE_GENERAL.xdr("estado_cuadre")
                        xIdlibrodiario = CLASE_GENERAL.xdr("Idlibrodiario")
                        xIddoctor = CLASE_GENERAL.xdr("Iddoctor")

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
