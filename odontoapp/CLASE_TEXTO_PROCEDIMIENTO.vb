Imports MySql.Data.MySqlClient

Public Class CLASE_TEXTO_PROCEDIMIENTO

    Implements Clase_general.DML

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

    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Eliminar

        Try

            Clase_general.sql = "Delete from mensajesprocedimientos where IdMensaje = " & Me.IdMensaje & " "
            Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
            Clase_general.xcomando.ExecuteNonQuery()

            Return True

            Clase_general.xcomando.Dispose()
            Clase_general.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Insertar

        Try

            Clase_general.sql = "INSERT INTO mensajesprocedimientos (Idmensaje, titulo, mensaje) VALUES  (" & Me.IdMensaje & ", '" & Me.Titulo & "', '" & Me.Mensaje & "')"
            Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
            Clase_general.xcomando.ExecuteNonQuery()

            Return True

            Clase_general.xcomando.Dispose()
            Clase_general.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Modificar

        Try
            Clase_general.sql = "UPDATE mensajesprocedimientos set titulo = '" & Me.Titulo & "', mensaje = '" & Me.Mensaje & "' WHERE IdMensaje = " & Me.IdMensaje & " "
            Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
            Clase_general.xcomando.ExecuteNonQuery()

            Return True

            Clase_general.xcomando.Dispose()
            Clase_general.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Seleccionar

        Try

            Clase_general.sql = "SELECT * FROM mensajesprocedimientos WHERE Idmensaje = " & Me.IdMensaje & " "
            Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
            Clase_general.xdr = Clase_general.xcomando.ExecuteReader()

            If Clase_general.xdr.Read Then 'existen datos en el dr

                xIdMensaje = Clase_general.xdr("Idmensaje")
                xTitulo = Clase_general.xdr("titulo")
                xMensaje = Clase_general.xdr("mensaje")

            End If

            Clase_general.xdr.Close()
            Clase_general.xdr = Nothing
            Clase_general.xcomando.Dispose()
            Clase_general.xcomando = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try

    End Function

End Class
