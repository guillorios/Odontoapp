Imports MySql.Data.MySqlClient

Public Class CLASE_CONSULTA

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdtconsulta As Integer
    Public Shared xnomconsulta As String
    Public Shared xcolor As Integer
    Public Shared xIdespecialidad As Integer

#End Region

#Region "Atributos"

    Private Idtconsulta As Integer
    Private nomconsulta As String
    Private color As Integer
    Private Idespecialidad As Integer

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Idtconsulta = 0
        Me.nomconsulta = ""
        Me.color = 0
        Me.Idespecialidad = 0

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"
    Public Property p_Idtconsulta() As Integer
        Get
            Return Me.Idtconsulta
        End Get
        Set(ByVal Value As Integer)
            Me.Idtconsulta = Value
        End Set
    End Property
    Public Property p_nomconsulta() As String
        Get
            Return Me.nomconsulta
        End Get
        Set(ByVal Value As String)
            Me.nomconsulta = Value
        End Set
    End Property
    Public Property p_color() As Integer
        Get
            Return Me.color
        End Get
        Set(ByVal Value As Integer)
            Me.color = Value
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

    Public ReadOnly Property p_ds() As DataSet
        Get
            Return Me.ds
        End Get
    End Property

#End Region

    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

        Try

            CLASE_GENERAL.sql = "DELETE FROM tipoconsulta WHERE Idtconsulta = " & Me.Idtconsulta & ""
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

            CLASE_GENERAL.sql = "INSERT INTO tipoconsulta(Idtconsulta, nomconsulta, color, Idespecialidad) VALUES  (" & Me.Idtconsulta & ", '" & Me.nomconsulta & "', " & Me.color & ", " & Me.Idespecialidad & ")"
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

            CLASE_GENERAL.sql = "UPDATE tipoconsulta SET nomconsulta = '" & Me.nomconsulta & "', color = " & Me.color & ", Idespecialidad = " & Me.Idespecialidad & " WHERE Idtconsulta = " & Me.Idtconsulta & ""
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


                Case "tipoconsulta1"

                    CLASE_GENERAL.sql = "SELECT * FROM tipoconsulta where Idtconsulta = '" & Me.Idtconsulta & "' "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdtconsulta = CLASE_GENERAL.xdr("Idtconsulta")
                        xnomconsulta = CLASE_GENERAL.xdr("nomconsulta")
                        xcolor = CLASE_GENERAL.xdr("color")
                        xIdespecialidad = CLASE_GENERAL.xdr("Idespecialidad")

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "tipoconsulta2"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT * FROM tipoconsulta"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'Clase_general.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "tipoconsulta3"

                    CLASE_GENERAL.sql = "SELECT * FROM tipoconsulta WHERE color = " & Me.color & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdtconsulta = CLASE_GENERAL.xdr("Idtconsulta")
                        xnomconsulta = CLASE_GENERAL.xdr("nomconsulta")
                        xcolor = CLASE_GENERAL.xdr("color")
                        xIdespecialidad = CLASE_GENERAL.xdr("Idespecialidad")

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
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
