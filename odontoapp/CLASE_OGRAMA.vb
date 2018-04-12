Imports MySql.Data.MySqlClient

Public Class CLASE_OGRAMA

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xobservacionograma_ini As String
    Public Shared xobservacionograma_act As String
    Public Shared xograma_inicial As Object
    Public Shared xograma_actual As Object
    Public Shared xoleary_inicial As Object
    Public Shared xoleary_actual As Object
    Public Shared xfecha_ograma As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private observacionograma_ini As String
    Private observacionograma_act As String
    Private ograma_inicial As Object
    Private ograma_actual As Object
    Private oleary_inicial As Object
    Private oleary_actual As Object
    Private fecha_ograma As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.observacionograma_ini = ""
        Me.observacionograma_act = ""
        Me.ograma_inicial = ""
        Me.ograma_actual = ""
        Me.oleary_inicial = ""
        Me.oleary_actual = ""
        Me.fecha_ograma = ""

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_IdUsuario() As Integer
        Get
            Return Me.IdUsuario
        End Get
        Set(ByVal Value As Integer)
            Me.IdUsuario = Value
        End Set
    End Property

    Public Property p_observacionograma_ini() As String
        Get
            Return Me.observacionograma_ini
        End Get
        Set(ByVal Value As String)
            Me.observacionograma_ini = Value
        End Set
    End Property

    Public Property p_observacionograma_act() As String
        Get
            Return Me.observacionograma_act
        End Get
        Set(ByVal Value As String)
            Me.observacionograma_act = Value
        End Set
    End Property

    Public Property p_ograma_inicial() As Object
        Get
            Return Me.ograma_inicial
        End Get
        Set(ByVal Value As Object)
            Me.ograma_inicial = Value
        End Set
    End Property

    Public Property p_ograma_actual() As Object
        Get
            Return Me.ograma_actual
        End Get
        Set(ByVal Value As Object)
            Me.ograma_actual = Value
        End Set
    End Property

    Public Property p_oleary_inicial() As Object
        Get
            Return Me.oleary_inicial
        End Get
        Set(ByVal Value As Object)
            Me.oleary_inicial = Value
        End Set
    End Property


    Public Property p_oleary_actual() As Object
        Get
            Return Me.oleary_inicial
        End Get
        Set(ByVal Value As Object)
            Me.oleary_actual = Value
        End Set
    End Property

    Public Property p_fecha_ograma() As String
        Get
            Return Me.fecha_ograma
        End Get
        Set(ByVal Value As String)
            Me.fecha_ograma = Value
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

            CLASE_GENERAL.sql = "DELETE FROM ograma WHERE IdUsuario = " & Me.IdUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.ograma (IdUsuario, observacionograma_ini, observacionograma_act, ograma_inicial, " _
            & "ograma_actual, oleary_inicial, oleary_actual, fecha_ograma ) VALUES (" & Me.IdUsuario & ", '" & Me.observacionograma_ini & "', '" & Me.observacionograma_act & "', " _
            & "?ograma_inicial, ?ograma_actual, ?oleary_inicial, ?oleary_actual, '" & Me.fecha_ograma & "' )"

            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?ograma_inicial", Me.ograma_inicial)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?ograma_actual", Me.ograma_actual)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?oleary_inicial", Me.oleary_inicial)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?oleary_actual", Me.oleary_actual)

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

                Case "ograma"

                    CLASE_GENERAL.sql = "UPDATE (Orthosoft.ograma) SET observacionograma_ini = '" & Me.observacionograma_ini & "' , observacionograma_act = '" & Me.observacionograma_act & "' , " _
                    & "ograma_inicial = ?ograma_inicial , ograma_actual = ?ograma_actual , oleary_inicial = ?oleary_inicial , oleary_actual = ?oleary_actual , fecha_ograma = '" & Me.fecha_ograma & "' WHERE IdUsuario = " & Me.IdUsuario & " "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)

                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?ograma_inicial", Me.ograma_inicial)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?ograma_actual", Me.ograma_actual)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?oleary_inicial", Me.oleary_inicial)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?oleary_actual", Me.oleary_actual)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "ograma_inicial"

                    CLASE_GENERAL.sql = "UPDATE (Orthosoft.ograma) SET observacionograma_ini = '" & Me.observacionograma_ini & "' , " _
                    & "ograma_inicial = ?ograma_inicial WHERE IdUsuario = " & Me.IdUsuario & " "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?ograma_inicial", Me.ograma_inicial)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "ograma_actual"

                    CLASE_GENERAL.sql = "UPDATE (Orthosoft.ograma) SET observacionograma_act = '" & Me.observacionograma_act & "' , " _
                    & "ograma_actual = ?ograma_actual WHERE IdUsuario = " & Me.IdUsuario & " "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)

                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?ograma_actual", Me.ograma_actual)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "oleary_inicial"

                    CLASE_GENERAL.sql = "UPDATE (Orthosoft.ograma) SET oleary_inicial = ?oleary_inicial WHERE IdUsuario = " & Me.IdUsuario & " "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?oleary_inicial", Me.oleary_inicial)

                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "oleary_actual"

                    CLASE_GENERAL.sql = "UPDATE (Orthosoft.ograma) SET oleary_actual = ?oleary_actual WHERE IdUsuario = " & Me.IdUsuario & " "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?oleary_actual", Me.oleary_actual)
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

                Case "ograma"

                    CLASE_GENERAL.sql = "SELECT IdUsuario, observacionograma_ini, observacionograma_act, ograma_inicial, ograma_actual, oleary_inicial, " _
                    & "oleary_actual, fecha_ograma FROM Orthosoft.ograma WHERE IdUsuario = " & Me.IdUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("IdUsuario") Is DBNull.Value Then
                            xIdUsuario = ""
                        Else
                            xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        End If

                        If CLASE_GENERAL.xdr("observacionograma_ini") Is DBNull.Value Then
                            xobservacionograma_ini = ""
                        Else
                            xobservacionograma_ini = CLASE_GENERAL.xdr("observacionograma_ini")
                        End If

                        If CLASE_GENERAL.xdr("observacionograma_act") Is DBNull.Value Then
                            xobservacionograma_act = ""
                        Else
                            xobservacionograma_act = CLASE_GENERAL.xdr("observacionograma_act")
                        End If

                        If CLASE_GENERAL.xdr("ograma_inicial") Is DBNull.Value Then
                            xograma_inicial = ""
                        Else
                            xograma_inicial = CLASE_GENERAL.xdr("ograma_inicial")
                        End If

                        If CLASE_GENERAL.xdr("ograma_actual") Is DBNull.Value Then
                            xograma_actual = ""
                        Else
                            xograma_actual = CLASE_GENERAL.xdr("ograma_actual")
                        End If

                        If CLASE_GENERAL.xdr("oleary_inicial") Is DBNull.Value Then
                            xoleary_inicial = ""
                        Else
                            xoleary_inicial = CLASE_GENERAL.xdr("oleary_inicial")
                        End If

                        If CLASE_GENERAL.xdr("oleary_actual") Is DBNull.Value Then
                            xoleary_actual = ""
                        Else
                            xoleary_actual = CLASE_GENERAL.xdr("oleary_actual")
                        End If

                        If CLASE_GENERAL.xdr("fecha_ograma") Is DBNull.Value Then
                            xfecha_ograma = ""
                        Else
                            xfecha_ograma = CLASE_GENERAL.xdr("fecha_ograma")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "ograma_inicial"

                    CLASE_GENERAL.sql = "SELECT IdUsuario, observacionograma_ini, ograma_inicial " _
                    & "FROM Orthosoft.ograma WHERE IdUsuario = " & Me.IdUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("IdUsuario") Is DBNull.Value Then
                            xIdUsuario = ""
                        Else
                            xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        End If

                        If CLASE_GENERAL.xdr("observacionograma_ini") Is DBNull.Value Then
                            xobservacionograma_ini = ""
                        Else
                            xobservacionograma_ini = CLASE_GENERAL.xdr("observacionograma_ini")
                        End If

                        If CLASE_GENERAL.xdr("ograma_inicial") Is DBNull.Value Then
                            xograma_inicial = ""
                        Else
                            xograma_inicial = CLASE_GENERAL.xdr("ograma_inicial")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "ograma_actual"

                    CLASE_GENERAL.sql = "SELECT IdUsuario, observacionograma_act, ograma_actual " _
                    & "FROM Orthosoft.ograma WHERE IdUsuario = " & Me.IdUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("IdUsuario") Is DBNull.Value Then
                            xIdUsuario = ""
                        Else
                            xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        End If

                        If CLASE_GENERAL.xdr("observacionograma_act") Is DBNull.Value Then
                            xobservacionograma_act = ""
                        Else
                            xobservacionograma_act = CLASE_GENERAL.xdr("observacionograma_act")
                        End If

                        If CLASE_GENERAL.xdr("ograma_actual") Is DBNull.Value Then
                            xograma_actual = ""
                        Else
                            xograma_actual = CLASE_GENERAL.xdr("ograma_actual")
                        End If

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
