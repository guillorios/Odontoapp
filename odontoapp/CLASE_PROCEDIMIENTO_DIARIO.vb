Imports MySql.Data.MySqlClient

Public Class CLASE_PROCEDIMIENTO_DIARIO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdproced As Integer
    Public Shared xIdpaciente As Integer
    Public Shared xproced As String
    Public Shared xFecha As String
    Public Shared xfirmapaciente As Object
    Public Shared xfirmaodonto As Object

#End Region

#Region "Atributos"

    Private Idproced As Integer
    Private Idpaciente As Integer
    Private proced As String
    Private Fecha As String
    Private firmapaciente As Object
    Private firmaodonto As Object

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Idproced = 0
        Me.Idpaciente = 0
        Me.proced = ""
        Me.Fecha = ""
        Me.firmapaciente = ""
        Me.firmaodonto = ""
        Me.ds = New DataSet

    End Sub
#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idproced() As Integer
        Get
            Return Me.Idproced
        End Get
        Set(ByVal Value As Integer)
            Me.Idproced = Value
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

    Public Property p_proced() As String
        Get
            Return Me.proced
        End Get
        Set(ByVal Value As String)
            Me.proced = Value
        End Set
    End Property

    Public Property p_Fecha() As String
        Get
            Return Me.Fecha
        End Get
        Set(ByVal Value As String)
            Me.Fecha = Value
        End Set
    End Property

    Public Property p_firmapaciente() As Object
        Get
            Return Me.firmapaciente
        End Get
        Set(ByVal Value As Object)
            Me.firmapaciente = Value
        End Set
    End Property

    Public Property p_firmaodonto() As Object
        Get
            Return Me.firmaodonto
        End Get
        Set(ByVal Value As Object)
            Me.firmaodonto = Value
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

            CLASE_GENERAL.sql = "DELETE FROM procedimientodiario WHERE Idproced = " & Me.Idproced & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.procedimientodiario (Idproced, Idpaciente, proced, Fecha) VALUES (" & Me.Idproced & ", " & Me.Idpaciente & ", '" & Me.proced & "', '" & Me.Fecha & "')"
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

                Case "procedimiento"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.procedimientodiario) SET Idproced = " & Me.Idproced & ", Idpaciente = " & Me.Idpaciente & ", proced = '" & Me.proced & "', Fecha = '" & Me.Fecha & "' WHERE Idproced = " & Me.Idproced & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "firmapaciente"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.procedimientodiario) SET firmapaciente = ?firmapaciente WHERE Idproced = " & Me.Idproced & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?firmapaciente", Me.firmapaciente)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "firmaodontologo"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.procedimientodiario) SET firmaodonto = ?firmaodonto WHERE Idproced = " & Me.Idproced & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?firmaodonto", Me.firmaodonto)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

            End Select


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar

        Try

            Select Case mensaje

                Case "procedimientos"

                    CLASE_GENERAL.sql = "SELECT * FROM procedimientodiario WHERE Idproced = " & Me.Idproced & " AND Idpaciente = " & Me.Idpaciente & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdproced = CLASE_GENERAL.xdr("Idproced")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xFecha = CLASE_GENERAL.xdr("Fecha")
                        xproced = CLASE_GENERAL.xdr("proced")
                        xfirmapaciente = CLASE_GENERAL.xdr("firmapaciente")
                        xfirmaodonto = CLASE_GENERAL.xdr("firmaodonto")

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "procedimientoshuellas"

                    CLASE_GENERAL.sql = "SELECT Idproced, firmapaciente, firmaodonto FROM procedimientodiario WHERE Idproced = " & Me.Idproced & " AND Idpaciente = " & Me.Idpaciente & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdproced = CLASE_GENERAL.xdr("Idproced")
                        xfirmapaciente = CLASE_GENERAL.xdr("firmapaciente")
                        xfirmaodonto = CLASE_GENERAL.xdr("firmaodonto")

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "informegeneral"

                    CLASE_GENERAL.xdt = New DataTable

                    CLASE_GENERAL.sql = "SELECT consultorio.razonsocial_cons, consultorio.nit_cons, consultorio.actividad_cons, consultorio.icono_cons, pacientes.nombres_pac, " _
                    & "pacientes.apellidos_pac, pacientes.numdoc_pac, pacientes.dedoc_pac, pacientes.nhclinica, procedimientodiario.* " _
                    & "FROM Orthosoft.consultorio INNER JOIN orthosoft.pacientes ON (consultorio.Idconsultorio = pacientes.Idconsultorio) " _
                    & "INNER JOIN orthosoft.procedimientodiario ON (pacientes.Idpaciente = procedimientodiario.Idpaciente) WHERE procedimientodiario.Idpaciente = " & Me.Idpaciente & " ORDER BY procedimientodiario.Fecha DESC, procedimientodiario.Idproced  DESC "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("d:\varios\procdiario.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try

    End Function


End Class
