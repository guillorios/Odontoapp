Imports MySql.Data.MySqlClient

Public Class CLASE_ENTIDADES

    Implements CLASE_GENERAL.DML


#Region "Consultas"

    Public Shared xIdentidad As Integer
    Public Shared xnombre_ent As String
    Public Shared xdireccion_ent As String
    Public Shared xcontacto_ent As String
    Public Shared xcodigo_ent As String


#End Region

#Region "Atributos"

    Private Identidad As Integer
    Private nombre_ent As String
    Private direccion_ent As String
    Private contacto_ent As String
    Private codigo_ent As String


    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Identidad = 0
        Me.nombre_ent = ""
        Me.direccion_ent = ""
        Me.contacto_ent = ""
        Me.codigo_ent = ""

        Me.ds = New DataSet
    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"
    Public Property p_Identidad() As Integer
        Get
            Return Me.Identidad
        End Get
        Set(ByVal Value As Integer)
            Me.Identidad = Value
        End Set
    End Property
    Public Property p_nombre_ent() As String
        Get
            Return Me.nombre_ent
        End Get
        Set(ByVal Value As String)
            Me.nombre_ent = Value
        End Set
    End Property

    Public Property p_direccion_ent() As String
        Get
            Return Me.direccion_ent
        End Get
        Set(ByVal Value As String)
            Me.direccion_ent = Value
        End Set
    End Property

    Public Property p_contacto_ent() As String
        Get
            Return Me.contacto_ent
        End Get
        Set(ByVal Value As String)
            Me.contacto_ent = Value
        End Set
    End Property

    Public Property p_codigo_ent() As String
        Get
            Return Me.codigo_ent
        End Get
        Set(ByVal Value As String)
            Me.codigo_ent = Value
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

            CLASE_GENERAL.sql = "DELETE FROM entidades WHERE Identidad = " & Me.Identidad & " "
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try
            CLASE_GENERAL.sql = "INSERT INTO entidades (Identidad, nombre_ent, direccion_ent, contacto_ent, codigo_ent) VALUES  (" & Me.Identidad & ", '" & Me.nombre_ent & "', '" & Me.direccion_ent & "', '" & Me.contacto_ent & "', '" & Me.codigo_ent & "')"
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try


    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Modificar

        Try
            CLASE_GENERAL.sql = "UPDATE entidades SET nombre_ent = '" & Me.nombre_ent & "', direccion_ent = '" & Me.direccion_ent & "', contacto_ent = '" & Me.contacto_ent & "', codigo_ent = '" & Me.codigo_ent & "' WHERE Identidad = " & Me.Identidad & ""
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try


    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar



        Try
            CLASE_GENERAL.sql = "SELECT * FROM entidades WHERE Identidad = " & Me.Identidad & " ORDER BY Identidad ASC "
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

            If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                xIdentidad = CLASE_GENERAL.xdr("Identidad")
                xnombre_ent = CLASE_GENERAL.xdr("nombre_ent")
                xdireccion_ent = CLASE_GENERAL.xdr("direccion_ent")
                xcontacto_ent = CLASE_GENERAL.xdr("contacto_ent")
                xcodigo_ent = CLASE_GENERAL.xdr("codigo_ent")

            End If

            CLASE_GENERAL.xdr.Close()
            CLASE_GENERAL.xdr = Nothing
            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try


    End Function

End Class
