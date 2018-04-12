Imports MySql.Data.MySqlClient

Public Class CLASE_IMAGENES

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xIiniciales As Object
    Public Shared xIfinales As Object
    Public Shared xIevolucion1 As Object
    Public Shared xIevolucion2 As Object
    Public Shared xIevolucion3 As Object
    Public Shared xIR0 As Object
    Public Shared xIR1 As Object
    Public Shared xIR2 As Object
    Public Shared xIR3 As Object
    Public Shared xIR4 As Object
    Public Shared xIR5 As Object
    Public Shared xIR6 As Object
    Public Shared xIR7 As Object
    Public Shared xIR8 As Object
    Public Shared xIR9 As Object

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer

    'Consultas fotograficas
    Private Iiniciales As Object
    Private Ifinales As Object
    Private Ievolucion1 As Object
    Private Ievolucion2 As Object
    Private Ievolucion3 As Object
    Private IR0 As Object
    Private IR1 As Object
    Private IR2 As Object
    Private IR3 As Object
    Private IR4 As Object
    Private IR5 As Object
    Private IR6 As Object
    Private IR7 As Object
    Private IR8 As Object
    Private IR9 As Object

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()


        Me.IdUsuario = 0
        Me.IdTUsuario = 0

        'Consultas fotograficas
        Me.Iiniciales = ""
        Me.Ifinales = ""
        Me.Ievolucion1 = ""
        Me.Ievolucion2 = ""
        Me.Ievolucion3 = ""
        Me.IR0 = ""
        Me.IR1 = ""
        Me.IR2 = ""
        Me.IR3 = ""
        Me.IR4 = ""
        Me.IR5 = ""
        Me.IR6 = ""
        Me.IR7 = ""
        Me.IR8 = ""
        Me.IR9 = ""

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

    Public Property p_IdTUsuario() As Integer
        Get
            Return Me.IdTUsuario
        End Get
        Set(ByVal Value As Integer)
            Me.IdTUsuario = Value
        End Set
    End Property

    Public Property p_Iiniciales() As Object
        Get
            Return Me.Iiniciales
        End Get
        Set(ByVal Value As Object)
            Me.Iiniciales = Value
        End Set
    End Property

    Public Property p_Ifinales() As Object
        Get
            Return Me.Ifinales
        End Get
        Set(ByVal Value As Object)
            Me.Ifinales = Value
        End Set
    End Property

    Public Property p_Ievolucion1() As Object
        Get
            Return Me.Ievolucion1
        End Get
        Set(ByVal Value As Object)
            Me.Ievolucion1 = Value
        End Set
    End Property

    Public Property p_Ievolucion2() As Object
        Get
            Return Me.Ievolucion2
        End Get
        Set(ByVal Value As Object)
            Me.Ievolucion2 = Value
        End Set
    End Property

    Public Property p_Ievolucion3() As Object
        Get
            Return Me.Ievolucion3
        End Get
        Set(ByVal Value As Object)
            Me.Ievolucion3 = Value
        End Set
    End Property

    Public Property p_IR0() As Object
        Get
            Return Me.IR0
        End Get
        Set(ByVal Value As Object)
            Me.IR0 = Value
        End Set
    End Property

    Public Property p_IR1() As Object
        Get
            Return Me.IR1
        End Get
        Set(ByVal Value As Object)
            Me.IR1 = Value
        End Set
    End Property

    Public Property p_IR2() As Object
        Get
            Return Me.IR2
        End Get
        Set(ByVal Value As Object)
            Me.IR2 = Value
        End Set
    End Property

    Public Property p_IR3() As Object
        Get
            Return Me.IR3
        End Get
        Set(ByVal Value As Object)
            Me.IR3 = Value
        End Set
    End Property

    Public Property p_IR4() As Object
        Get
            Return Me.IR4
        End Get
        Set(ByVal Value As Object)
            Me.IR4 = Value
        End Set
    End Property

    Public Property p_IR5() As Object
        Get
            Return Me.IR5
        End Get
        Set(ByVal Value As Object)
            Me.IR5 = Value
        End Set
    End Property


    Public Property p_IR6() As Object
        Get
            Return Me.IR6
        End Get
        Set(ByVal Value As Object)
            Me.IR6 = Value
        End Set
    End Property

    Public Property p_IR7() As Object
        Get
            Return Me.IR7
        End Get
        Set(ByVal Value As Object)
            Me.IR7 = Value
        End Set
    End Property

    Public Property p_IR8() As Object
        Get
            Return Me.IR8
        End Get
        Set(ByVal Value As Object)
            Me.IR8 = Value
        End Set
    End Property

    Public Property p_IR9() As Object
        Get
            Return Me.IR9
        End Get
        Set(ByVal Value As Object)
            Me.IR9 = Value
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

            CLASE_GENERAL.sql = "DELETE FROM imagenes WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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


            CLASE_GENERAL.sql = "INSERT INTO imagenes (IdUsuario, IdTUsuario, Iiniciales, Ifinales, Ievolucion1, Ievolucion2, Ievolucion3, IR0, IR1, IR2, IR3, IR4, IR5, IR6, IR7, IR8, IR9) VALUES  (" & Me.IdUsuario & ", " & Me.IdTUsuario & ", ?Iiniciales, ?Ifinales, ?Ievolucion1, ?Ievolucion2, ?Ievolucion3, ?IR0, ?IR1, ?IR2, ?IR3, ?IR4, ?IR5, ?IR6, ?IR7, ?IR8, ?IR9)"
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Iiniciales", Me.Iiniciales)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ifinales", Me.Ifinales)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ievolucion1", Me.Ievolucion1)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ievolucion2", Me.Ievolucion2)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ievolucion3", Me.Ievolucion3)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR0", Me.IR0)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR1", Me.IR1)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR2", Me.IR2)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR3", Me.IR3)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR4", Me.IR4)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR5", Me.IR5)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR6", Me.IR6)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR7", Me.IR7)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR8", Me.IR8)
            CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR9", Me.IR9)

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


                Case "estudios"

                    CLASE_GENERAL.sql = "UPDATE imagenes SET Iiniciales = ?Iiniciales, Ifinales = ?Ifinales, Ievolucion1 = ?Ievolucion1, Ievolucion2 = ?Ievolucion2, Ievolucion3 = ?Ievolucion3, " _
                    & "IR0 = ?IR0, IR1 = ?IR1 , IR2 = ?IR2, IR3 = ?IR3, IR4 = ?IR4, IR5 = ?IR5, IR6 = ?IR6, IR7 = ?IR7, IR8 = ?IR8, IR9 = ?IR9  WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Iiniciales", Me.Iiniciales)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ifinales", Me.Ifinales)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ievolucion1", Me.Ievolucion1)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ievolucion2", Me.Ievolucion2)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?Ievolucion3", Me.Ievolucion3)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR0", Me.IR0)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR1", Me.IR1)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR2", Me.IR2)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR3", Me.IR3)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR4", Me.IR4)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR5", Me.IR5)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR6", Me.IR6)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR7", Me.IR7)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR8", Me.IR8)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?IR9", Me.IR9)
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


                Case "estudios"

                    CLASE_GENERAL.sql = "SELECT Iiniciales, Ifinales, Ievolucion1, Ievolucion2, Ievolucion3, IR0, IR1, IR2, IR3, IR4, IR5, IR6, IR7, IR8, IR9 FROM imagenes WHERE IdUsuario = " & Me.IdUsuario & " and IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("Iiniciales") Is DBNull.Value Then
                            xIiniciales = ""
                        Else
                            xIiniciales = CLASE_GENERAL.xdr("Iiniciales")
                        End If

                        If CLASE_GENERAL.xdr("Ifinales") Is DBNull.Value Then
                            xIfinales = ""
                        Else
                            xIfinales = CLASE_GENERAL.xdr("Ifinales")
                        End If

                        If CLASE_GENERAL.xdr("Ievolucion1") Is DBNull.Value Then
                            xIevolucion1 = ""
                        Else
                            xIevolucion1 = CLASE_GENERAL.xdr("Ievolucion1")
                        End If

                        If CLASE_GENERAL.xdr("Ievolucion2") Is DBNull.Value Then
                            xIevolucion2 = ""
                        Else
                            xIevolucion2 = CLASE_GENERAL.xdr("Ievolucion2")
                        End If

                        If CLASE_GENERAL.xdr("Ievolucion3") Is DBNull.Value Then
                            xIevolucion3 = ""
                        Else
                            xIevolucion3 = CLASE_GENERAL.xdr("Ievolucion3")
                        End If

                        If CLASE_GENERAL.xdr("IR0") Is DBNull.Value Then
                            xIR0 = ""
                        Else
                            xIR0 = CLASE_GENERAL.xdr("IR0")
                        End If

                        If CLASE_GENERAL.xdr("IR1") Is DBNull.Value Then
                            xIR1 = ""
                        Else
                            xIR1 = CLASE_GENERAL.xdr("IR1")
                        End If


                        If CLASE_GENERAL.xdr("IR2") Is DBNull.Value Then
                            xIR2 = ""
                        Else
                            xIR2 = CLASE_GENERAL.xdr("IR2")
                        End If

                        If CLASE_GENERAL.xdr("IR3") Is DBNull.Value Then
                            xIR3 = ""
                        Else
                            xIR3 = CLASE_GENERAL.xdr("IR3")
                        End If

                        If CLASE_GENERAL.xdr("IR4") Is DBNull.Value Then
                            xIR4 = ""
                        Else
                            xIR4 = CLASE_GENERAL.xdr("IR4")
                        End If

                        If CLASE_GENERAL.xdr("IR5") Is DBNull.Value Then
                            xIR5 = ""
                        Else
                            xIR5 = CLASE_GENERAL.xdr("IR5")
                        End If

                        If CLASE_GENERAL.xdr("IR6") Is DBNull.Value Then
                            xIR6 = ""
                        Else
                            xIR6 = CLASE_GENERAL.xdr("IR6")
                        End If

                        If CLASE_GENERAL.xdr("IR7") Is DBNull.Value Then
                            xIR7 = ""
                        Else
                            xIR7 = CLASE_GENERAL.xdr("IR7")
                        End If

                        If CLASE_GENERAL.xdr("IR8") Is DBNull.Value Then
                            xIR8 = ""
                        Else
                            xIR8 = CLASE_GENERAL.xdr("IR8")
                        End If

                        If CLASE_GENERAL.xdr("IR9") Is DBNull.Value Then
                            xIR9 = ""
                        Else
                            xIR9 = CLASE_GENERAL.xdr("IR9")
                        End If

                    Else


                        xIiniciales = ""
                        xIfinales = ""
                        xIevolucion1 = ""
                        xIevolucion2 = ""
                        xIevolucion3 = ""
                        xIR0 = ""
                        xIR1 = ""
                        xIR2 = ""
                        xIR3 = ""
                        xIR4 = ""
                        xIR5 = ""
                        xIR6 = ""
                        xIR7 = ""
                        xIR8 = ""
                        xIR9 = ""

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