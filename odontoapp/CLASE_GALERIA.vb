Imports MySql.Data.MySqlClient

Public Class CLASE_GALERIA

    Implements CLASE_GENERAL.DML


#Region "Consultas"

    Public Shared xIdImagen As Integer
    Public Shared xdescripcion_img As String
    Public Shared xIdTipo_img As Integer
    Public Shared xIdUsuario As Integer
    Public Shared xImagen_img As Object

#End Region

#Region "Atributos"

    Private IdImagen As Integer
    Private descripcion_img As String
    Private IdTipo_img As Integer
    Private IdUsuario As Integer
    Private Imagen_img As Object

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdImagen = 0
        Me.descripcion_img = ""
        Me.IdTipo_img = 0
        Me.IdUsuario = 0
        Me.Imagen_img = ""

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_IdImagen() As Integer
        Get
            Return Me.IdImagen
        End Get
        Set(ByVal Value As Integer)
            Me.IdImagen = Value
        End Set
    End Property

    Public Property p_descripcion_img() As String
        Get
            Return Me.descripcion_img
        End Get
        Set(ByVal Value As String)
            Me.descripcion_img = Value
        End Set
    End Property

    Public Property p_IdTipo_img() As Integer
        Get
            Return Me.IdTipo_img
        End Get
        Set(ByVal Value As Integer)
            Me.IdTipo_img = Value
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

    Public Property p_Imagen_img() As Object
        Get
            Return Me.Imagen_img
        End Get
        Set(ByVal Value As Object)
            Me.Imagen_img = Value
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

            CLASE_GENERAL.sql = "DELETE FROM galeria WHERE IdImagen = " & Me.IdImagen & " "
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


            CLASE_GENERAL.sql = "INSERT INTO orthosoft.galeria (IdImagen, descripcion_img, IdTipo_img, IdUsuario, Imagen_img) " _
            & "VALUES (" & Me.IdImagen & ", '" & Me.descripcion_img & "', " & Me.IdTipo_img & ", " & Me.IdUsuario & ", ?Imagen_img)"
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Imagen_img", Me.Imagen_img)

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

                    CLASE_GENERAL.sql = " UPDATE(Orthosoft.galeria) SET descripcion_img = '" & Me.descripcion_img & "' , IdTipo_img = " & Me.IdTipo_img & " , IdUsuario = " & Me.IdUsuario & " , Imagen_img = ?Imagen_img " _
                    & "WHERE IdImagen = " & Me.IdImagen & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Imagen_img", Me.Imagen_img)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "imagen"

                    CLASE_GENERAL.sql = " UPDATE(Orthosoft.galeria) SET Imagen_img = ?Imagen_img " _
                    & "WHERE IdImagen = " & Me.IdImagen & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Imagen_img", Me.Imagen_img)
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

                Case "galeria"

                    CLASE_GENERAL.sql = "SELECT IdImagen, descripcion_img, IdTipo_img, IdUsuario, Imagen_img FROM Orthosoft.galeria WHERE IdImagen= '" & Me.IdImagen & "' "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdImagen = CLASE_GENERAL.xdr("IdImagen")
                        xdescripcion_img = CLASE_GENERAL.xdr("descripcion_img")
                        xIdTipo_img = CLASE_GENERAL.xdr("IdTipo_img")
                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")

                        If CLASE_GENERAL.xdr("Imagen_img") Is DBNull.Value Then
                            xImagen_img = ""
                        Else
                            xImagen_img = CLASE_GENERAL.xdr("Imagen_img")
                        End If



                    Else

                        xIdImagen = ""
                        xdescripcion_img = ""
                        xIdTipo_img = ""
                        xIdUsuario = ""
                        xImagen_img = ""

                    End If


                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try


    End Function

End Class
