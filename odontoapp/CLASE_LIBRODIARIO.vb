Imports MySql.Data.MySqlClient

Public Class CLASE_LIBRODIARIO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdlibrodiario As Integer
    Public Shared xdebitos As Double
    Public Shared xcreditos As Double
    Public Shared xsaldocajamenor As Double
    Public Shared xfecha As String
    Public Shared xIdconsultorio As Integer
    Public Shared xIdUsuario As Integer

#End Region

#Region "Atributos"

    Private Idlibrodiario As Integer
    Private debitos As Double
    Private creditos As Double
    Private saldocajamenor As Double
    Private fecha As String
    Private Idconsultorio As Integer
    Private IdUsuario As Integer

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idlibrodiario = 0
        Me.debitos = 0
        Me.creditos = 0
        Me.saldocajamenor = 0
        Me.fecha = ""
        Me.Idconsultorio = 0
        Me.IdUsuario = 0

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idlibrodiario() As Integer

        Get
            Return Me.Idlibrodiario
        End Get

        Set(ByVal Value As Integer)
            Me.Idlibrodiario = Value
        End Set

    End Property

    Public Property p_debitos() As Double
        Get
            Return Me.debitos
        End Get
        Set(ByVal Value As Double)
            Me.debitos = Value
        End Set
    End Property

    Public Property p_creditos() As Double
        Get
            Return Me.creditos
        End Get
        Set(ByVal Value As Double)
            Me.creditos = Value
        End Set
    End Property

    Public Property p_saldocajamenor() As Double
        Get
            Return Me.saldocajamenor
        End Get
        Set(ByVal Value As Double)
            Me.saldocajamenor = Value
        End Set
    End Property

    Public Property p_fecha() As String
        Get
            Return Me.fecha
        End Get
        Set(ByVal Value As String)
            Me.fecha = Value
        End Set
    End Property

    Public Property p_Idconsultorio() As Integer

        Get
            Return Me.Idconsultorio
        End Get

        Set(ByVal Value As Integer)
            Me.Idconsultorio = Value
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

    Public ReadOnly Property p_ds() As DataSet
        Get
            Return Me.ds
        End Get
    End Property

#End Region


    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

        Try

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.librodiario WHERE Idlibrodiario = " & Me.Idlibrodiario & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.librodiario (Idlibrodiario, debitos, creditos, saldocajamenor, fecha, Idconsultorio, IdUsuario) " _
            & "VALUES (" & Me.Idlibrodiario & ", " & Me.debitos & ", " & Me.creditos & ", " & Me.saldocajamenor & ", '" & Me.fecha & "', " & Me.Idconsultorio & ", " & Me.IdUsuario & ")"

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

            CLASE_GENERAL.sql = "UPDATE orthosoft.librodiario SET debitos = " & Me.debitos & " , creditos = " & Me.creditos & ", saldocajamenor = " & Me.saldocajamenor & ", fecha = '" & Me.fecha & " , Idconsultorio = " & Me.Idconsultorio & ", IdUsuario = " & Me.IdUsuario & " WHERE Idlibrodiario = " & Me.Idlibrodiario & ""
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
                    CLASE_GENERAL.sql = "SELECT Idlibrodiario, debitos, creditos, fecha, Idconsultorio, IdUsuario FROM Orthosoft.librodiario"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\cuotaspaciente.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "informe"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT consultorio.*, empleados.*, librodiario.*, detalle_librodiario.*, tipodocumento.nomtipodoc, estadodocumentos.nom_estado FROM Orthosoft.consultorio INNER JOIN orthosoft.librodiario ON (consultorio.Idconsultorio = librodiario.Idconsultorio) INNER JOIN orthosoft.empleados ON (empleados.Idempleado = librodiario.IdUsuario) INNER JOIN orthosoft.detalle_librodiario ON (librodiario.Idlibrodiario = detalle_librodiario.Idlibrodiario) INNER JOIN orthosoft.tipodocumento ON (detalle_librodiario.Idtipodoc = tipodocumento.Idtipodoc) INNER JOIN orthosoft.estadodocumentos ON (estadodocumentos.Idestado = detalle_librodiario.Idestado) WHERE detalle_librodiario.Idlibrodiario = " & Me.Idlibrodiario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("d:\varios\librodiario.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idlibrodiario, debitos, creditos, saldocajamenor, fecha, Idconsultorio, IdUsuario FROM Orthosoft.librodiario WHERE Idlibrodiario = " & Me.Idlibrodiario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdlibrodiario = CLASE_GENERAL.xdr("Idlibrodiario")
                        xdebitos = CLASE_GENERAL.xdr("debitos")
                        xcreditos = CLASE_GENERAL.xdr("creditos")
                        xsaldocajamenor = CLASE_GENERAL.xdr("saldocajamenor")
                        xfecha = CLASE_GENERAL.xdr("fecha")
                        xIdconsultorio = CLASE_GENERAL.xdr("Idconsultorio")
                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")

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
