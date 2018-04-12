Imports MySql.Data.MySqlClient

Public Class CLASE_PROCEDIMIENTOS

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdprocedimiento As String
    Public Shared xdescripcion_proc As String
    Public Shared xreferencia_proc As String
    Public Shared xvalor_proc As Double
    Public Shared xIdespecialidad As Integer

#End Region

#Region "Atributos"

    Private Idprocedimiento As String
    Private descripcion_proc As String
    Private referencia_proc As String
    Private valor_proc As Double
    Private Idespecialidad As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idprocedimiento = ""
        Me.descripcion_proc = ""
        Me.referencia_proc = ""
        Me.valor_proc = 0
        Me.Idespecialidad = 0

        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idprocedimiento() As String
        Get
            Return Me.Idprocedimiento
        End Get
        Set(ByVal Value As String)
            Me.Idprocedimiento = Value
        End Set
    End Property

    Public Property p_descripcion_proc() As String
        Get
            Return Me.descripcion_proc
        End Get
        Set(ByVal Value As String)
            Me.descripcion_proc = Value
        End Set
    End Property

    Public Property p_referencia_proc() As String
        Get
            Return Me.referencia_proc
        End Get
        Set(ByVal Value As String)
            Me.referencia_proc = Value
        End Set
    End Property

    Public Property p_valor_proc() As Double
        Get
            Return Me.valor_proc
        End Get
        Set(ByVal Value As Double)
            Me.valor_proc = Value
        End Set
    End Property

    Public Property p_Idespecialidad() As Double
        Get
            Return Me.Idespecialidad
        End Get
        Set(ByVal Value As Double)
            Me.Idespecialidad = Value
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

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.procedimientos  WHERE Idprocedimiento = '" & Me.Idprocedimiento & "'"
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.procedimientos (Idprocedimiento, descripcion_proc, referencia_proc, valor_proc, Idespecialidad) VALUES " _
            & "('" & Me.Idprocedimiento & "', '" & Me.descripcion_proc & "', '" & Me.referencia_proc & "', " & Me.valor_proc & ", " & Me.Idespecialidad & ")"

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

            CLASE_GENERAL.sql = "UPDATE orthosoft.procedimientos SET descripcion_proc = '" & Me.descripcion_proc & "' , referencia_proc = '" & Me.referencia_proc & "' , valor_proc = " & Me.valor_proc & " , Idespecialidad = " & Me.Idespecialidad & "" _
            & " WHERE Idprocedimiento = '" & Me.Idprocedimiento & "'"

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
                    CLASE_GENERAL.sql = "SELECT Idprocedimiento, descripcion_proc, referencia_proc, valor_proc FROM Orthosoft.procedimientos"


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\cuotaspaciente.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idprocedimiento, descripcion_proc, referencia_proc, valor_proc, Idespecialidad FROM Orthosoft.procedimientos WHERE Idprocedimiento = '" & Me.Idprocedimiento & "'"
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdprocedimiento = CLASE_GENERAL.xdr("Idprocedimiento")
                        xdescripcion_proc = CLASE_GENERAL.xdr("descripcion_proc")
                        xreferencia_proc = CLASE_GENERAL.xdr("referencia_proc")
                        xvalor_proc = CLASE_GENERAL.xdr("valor_proc")
                        xIdespecialidad = CLASE_GENERAL.xdr("Idespecialidad")

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
