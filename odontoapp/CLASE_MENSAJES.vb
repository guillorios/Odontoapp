Imports MySql.Data.MySqlClient

Public Class CLASE_MENSAJES

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdMensaje As Integer
    Public Shared xTitulo As String
    Public Shared xMensaje As String

#End Region

#Region "Atributos"

    Private IdMensaje As Integer
    Private Titulo As String
    Private Mensaje As String
    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.IdMensaje = 0
        Me.Titulo = ""
        Me.Mensaje = ""
        Me.ds = New DataSet

    End Sub
#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"
    Public Property p_IdMensaje() As Integer
        Get
            Return Me.IdMensaje
        End Get
        Set(ByVal Value As Integer)
            Me.IdMensaje = Value
        End Set
    End Property


    Public Property p_Titulo() As String
        Get
            Return Me.Titulo
        End Get
        Set(ByVal Value As String)
            Me.Titulo = Value
        End Set
    End Property

    Public Property p_Mensaje() As String
        Get
            Return Me.Mensaje
        End Get
        Set(ByVal Value As String)
            Me.Mensaje = Value
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

            CLASE_GENERAL.sql = "Delete from mensajes where IdMensaje = " & Me.IdMensaje & " "
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

            CLASE_GENERAL.sql = "INSERT INTO mensajes (Idmensaje, titulo, mensaje) VALUES  (" & Me.IdMensaje & ", '" & Me.Titulo & "', '" & Me.Mensaje & "')"
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
            CLASE_GENERAL.sql = "UPDATE mensajes SET titulo = '" & Me.Titulo & "', mensaje = '" & Me.Mensaje & "' WHERE IdMensaje = " & Me.IdMensaje & " "
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

            CLASE_GENERAL.sql = "SELECT * FROM mensajes WHERE Idmensaje = " & Me.IdMensaje & " "
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

            If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                xIdMensaje = CLASE_GENERAL.xdr("Idmensaje")
                xTitulo = CLASE_GENERAL.xdr("titulo")
                xMensaje = CLASE_GENERAL.xdr("mensaje")

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
