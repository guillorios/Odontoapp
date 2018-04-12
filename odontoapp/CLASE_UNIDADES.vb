Imports MySql.Data.MySqlClient

Public Class CLASE_UNIDADES

    Implements CLASE_GENERAL.DML


#Region "Consultas"


    Public Shared xIdunidad As Integer
    Public Shared xnom_unidad As String
    Public Shared xIdestado As Integer
    Public Shared xIdespecialidad As Integer

#End Region

#Region "Atributos"

    Private Idunidad As Integer
    Private nom_unidad As String
    Private Idestado As Integer
    Private Idespecialidad As Integer

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idunidad = 0
        Me.nom_unidad = ""
        Me.Idestado = 0
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

    Public Property p_Idunidad() As Integer
        Get
            Return Me.Idunidad
        End Get
        Set(ByVal Value As Integer)
            Me.Idunidad = Value
        End Set
    End Property

    Public Property p_nom_unidad() As String
        Get
            Return Me.nom_unidad
        End Get
        Set(ByVal Value As String)
            Me.nom_unidad = Value
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

    Public Property p_Idespecialidad() As Integer
        Get
            Return Me.Idespecialidad
        End Get
        Set(ByVal Value As Integer)
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.unidades WHERE Idunidad = '" & Me.Idunidad & "'"
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.unidades (Idunidad, nom_unidad, Idestado, Idespecialidad ) VALUES (" & Me.Idunidad & ", '" & Me.nom_unidad & "', " & Me.Idestado & ", " & Me.Idespecialidad & ")"
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

            CLASE_GENERAL.sql = "UPDATE(Orthosoft.unidades) SET Idunidad = " & Me.Idunidad & " , nom_unidad = '" & Me.nom_unidad & "' , Idestado = " & Me.Idestado & " , Idespecialidad = " & Me.Idespecialidad & " WHERE Idunidad = " & Me.Idunidad & ""
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
                    CLASE_GENERAL.sql = "SELECT Idunidad, nom_unidad, Idestado, Idespecialidad FROM Orthosoft.unidades"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\cuotaspaciente.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idunidad, nom_unidad, Idestado, Idespecialidad FROM Orthosoft.unidades WHERE Idunidad = " & Me.Idunidad & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdunidad = CLASE_GENERAL.xdr("Idunidad")
                        xnom_unidad = CLASE_GENERAL.xdr("nom_unidad")
                        xIdestado = CLASE_GENERAL.xdr("Idestado")
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
