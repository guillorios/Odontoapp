Imports MySql.Data.MySqlClient

Public Class CLASE_HUELLAS

    Implements CLASE_GENERAL.DML

    Public Templateaux As DPFP.Template

#Region "Consultas"

    Public Shared xIdhuella As Integer
    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer

    Public Shared xhuella1 As String
    Public Shared xhuella1_reg As Object

    Public Shared xhuella2 As String
    Public Shared xhuella2_reg As Object

    Public Shared xhuella3 As String
    Public Shared xhuella3_reg As Object

    Public Shared xhuella4 As String
    Public Shared xhuella4_reg As Object

    Public Shared xhuella5 As String
    Public Shared xhuella5_reg As Object

    Public Shared xhuella6 As String
    Public Shared xhuella6_reg As Object

    Public Shared xhuella7 As String
    Public Shared xhuella7_reg As Object

    Public Shared xhuella8 As String
    Public Shared xhuella8_reg As Object

    Public Shared xhuella9 As String
    Public Shared xhuella9_reg As Object

    Public Shared xhuella10 As String
    Public Shared xhuella10_reg As Object

    Public Shared xfechareg As String

#End Region

#Region "Atributos"

    Private Idhuella As Integer
    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private huella1 As String
    Private huella1_reg As Object

    Private huella2 As String
    Private huella2_reg As Object

    Private huella3 As String
    Private huella3_reg As Object

    Private huella4 As String
    Private huella4_reg As Object

    Private huella5 As String
    Private huella5_reg As Object

    Private huella6 As String
    Private huella6_reg As Object

    Private huella7 As String
    Private huella7_reg As Object

    Private huella8 As String
    Private huella8_reg As Object

    Private huella9 As String
    Private huella9_reg As Object

    Private huella10 As String
    Private huella10_reg As Object

    Private fechareg As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idhuella = 0
        Me.IdUsuario = 0
        Me.IdTUsuario = 0

        Me.huella1 = ""
        Me.huella1_reg = ""

        Me.huella2 = ""
        Me.huella2_reg = ""

        Me.huella3 = ""
        Me.huella3_reg = ""

        Me.huella4 = ""
        Me.huella4_reg = ""

        Me.huella5 = ""
        Me.huella5_reg = ""

        Me.huella6 = ""
        Me.huella6_reg = ""

        Me.huella7 = ""
        Me.huella7_reg = ""

        Me.huella8 = ""
        Me.huella8_reg = ""

        Me.huella9 = ""
        Me.huella9_reg = ""

        Me.huella10 = ""
        Me.huella10_reg = ""

        Me.fechareg = ""

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idhuella() As Integer
        Get
            Return Me.Idhuella
        End Get
        Set(ByVal Value As Integer)
            Me.Idhuella = Value
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

    Public Property p_IdTUsuario() As Integer
        Get
            Return Me.IdTUsuario
        End Get
        Set(ByVal Value As Integer)
            Me.IdTUsuario = Value
        End Set
    End Property

    Public Property p_huella1() As String
        Get
            Return Me.huella1
        End Get
        Set(ByVal Value As String)
            Me.huella1 = Value
        End Set
    End Property

    Public Property p_huella1_reg() As Object
        Get
            Return Me.huella1_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella1_reg = Value
        End Set
    End Property


    Public Property p_huella2() As String
        Get
            Return Me.huella2
        End Get
        Set(ByVal Value As String)
            Me.huella2 = Value
        End Set
    End Property

    Public Property p_huella2_reg() As Object
        Get
            Return Me.huella2_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella2_reg = Value
        End Set
    End Property

    Public Property p_huella3() As String
        Get
            Return Me.huella3
        End Get
        Set(ByVal Value As String)
            Me.huella3 = Value
        End Set
    End Property

    Public Property p_huella3_reg() As Object
        Get
            Return Me.huella3_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella3_reg = Value
        End Set
    End Property

    Public Property p_huella4() As String
        Get
            Return Me.huella4
        End Get
        Set(ByVal Value As String)
            Me.huella4 = Value
        End Set
    End Property

    Public Property p_huella4_reg() As Object
        Get
            Return Me.huella4_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella4_reg = Value
        End Set
    End Property

    Public Property p_huella5() As String
        Get
            Return Me.huella5
        End Get
        Set(ByVal Value As String)
            Me.huella5 = Value
        End Set
    End Property

    Public Property p_huella5_reg() As Object
        Get
            Return Me.huella5_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella5_reg = Value
        End Set
    End Property

    Public Property p_huella6() As String
        Get
            Return Me.huella6
        End Get
        Set(ByVal Value As String)
            Me.huella6 = Value
        End Set
    End Property

    Public Property p_huella6_reg() As Object
        Get
            Return Me.huella6_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella6_reg = Value
        End Set
    End Property

    Public Property p_huella7() As String
        Get
            Return Me.huella7
        End Get
        Set(ByVal Value As String)
            Me.huella7 = Value
        End Set
    End Property

    Public Property p_huella7_reg() As Object
        Get
            Return Me.huella7_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella7_reg = Value
        End Set
    End Property

    Public Property p_huella8() As String
        Get
            Return Me.huella8
        End Get
        Set(ByVal Value As String)
            Me.huella8 = Value
        End Set
    End Property

    Public Property p_huella8_reg() As Object
        Get
            Return Me.huella8_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella8_reg = Value
        End Set
    End Property

    Public Property p_huella9() As String
        Get
            Return Me.huella9
        End Get
        Set(ByVal Value As String)
            Me.huella9 = Value
        End Set
    End Property

    Public Property p_huella9_reg() As Object
        Get
            Return Me.huella9_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella9_reg = Value
        End Set
    End Property

    Public Property p_huella10() As String
        Get
            Return Me.huella10
        End Get
        Set(ByVal Value As String)
            Me.huella10 = Value
        End Set
    End Property

    Public Property p_huella10_reg() As Object
        Get
            Return Me.huella10_reg
        End Get
        Set(ByVal Value As Object)
            Me.huella10_reg = Value
        End Set
    End Property

    Public Property p_fechareg() As String
        Get
            Return Me.fechareg
        End Get
        Set(ByVal Value As String)
            Me.fechareg = Value
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

            CLASE_GENERAL.sql = "DELETE FROM huellas WHERE Idhuella = " & Me.Idhuella & ""
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

            CLASE_GENERAL.sql = "INSERT INTO huellas (Idhuella, IdUsuario, IdTUsuario, fechareg) VALUES (" & Me.Idhuella & ", " & Me.IdUsuario & ", " & Me.IdTUsuario & ", '" & Me.fechareg & "')"
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

                Case "huella1"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella1 = '" & Me.huella1 & "', huella1_reg = ?huella1_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella1_reg", Me.huella1_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella2"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella2 = '" & Me.huella2 & "', huella2_reg = ?huella2_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella2_reg", Me.huella2_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella3"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella3 = '" & Me.huella3 & "', huella3_reg = ?huella3_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella3_reg", Me.huella3_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "huella4"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella4 = '" & Me.huella4 & "', huella4_reg = ?huella4_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella4_reg", Me.huella4_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella5"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella5 = '" & Me.huella5 & "', huella5_reg = ?huella5_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella5_reg", Me.huella5_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "huella6"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella6 = '" & Me.huella6 & "', huella6_reg = ?huella6_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella6_reg", Me.huella6_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "huella7"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella7 = '" & Me.huella7 & "', huella7_reg = ?huella7_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella7_reg", Me.huella7_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "huella8"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella8 = '" & Me.huella8 & "', huella8_reg = ?huella8_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella8_reg", Me.huella8_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "huella9"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella9 = '" & Me.huella9 & "', huella9_reg = ?huella9_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella9_reg", Me.huella9_reg)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella10"

                    CLASE_GENERAL.sql = "UPDATE huellas SET huella10 = '" & Me.huella10 & "', huella10_reg = ?huella10_reg WHERE IdUsuario= " & Me.IdUsuario & " AND IdTUsuario= " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.Parameters.AddWithValue("?huella10_reg", Me.huella10_reg)
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

                Case "items"

                    CLASE_GENERAL.xdt2 = New DataTable
                    CLASE_GENERAL.sql = "SELECT Idhuella, IdUsuario, IdTUsuario FROM Orthosoft.huellas WHERE IdTUsuario = " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt2) 'Ejecutar par cargar en combo

                    'Clase_general.xdt.WriteXml("C:\dataset1.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                    Return True

                Case "todos"

                    CLASE_GENERAL.sql = "SELECT * FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdhuella = CLASE_GENERAL.xdr("Idhuella")
                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")

                        If CLASE_GENERAL.xdr("huella1") Is DBNull.Value Then
                            xhuella1 = ""
                        Else
                            xhuella1 = CLASE_GENERAL.xdr("huella1")
                        End If

                        If CLASE_GENERAL.xdr("huella2") Is DBNull.Value Then
                            xhuella2 = ""
                        Else
                            xhuella2 = CLASE_GENERAL.xdr("huella2")
                        End If

                        If CLASE_GENERAL.xdr("huella3") Is DBNull.Value Then
                            xhuella3 = ""
                        Else
                            xhuella3 = CLASE_GENERAL.xdr("huella3")
                        End If


                        If CLASE_GENERAL.xdr("huella4") Is DBNull.Value Then
                            xhuella4 = ""
                        Else
                            xhuella4 = CLASE_GENERAL.xdr("huella4")
                        End If

                        If CLASE_GENERAL.xdr("huella5") Is DBNull.Value Then
                            xhuella5 = ""
                        Else
                            xhuella5 = CLASE_GENERAL.xdr("huella5")
                        End If

                        If CLASE_GENERAL.xdr("huella6") Is DBNull.Value Then
                            xhuella6 = ""
                        Else
                            xhuella6 = CLASE_GENERAL.xdr("huella6")
                        End If

                        If CLASE_GENERAL.xdr("huella7") Is DBNull.Value Then
                            xhuella7 = ""
                        Else
                            xhuella7 = CLASE_GENERAL.xdr("huella7")
                        End If

                        If CLASE_GENERAL.xdr("huella8") Is DBNull.Value Then
                            xhuella8 = ""
                        Else
                            xhuella8 = CLASE_GENERAL.xdr("huella8")
                        End If

                        If CLASE_GENERAL.xdr("huella9") Is DBNull.Value Then
                            xhuella9 = ""
                        Else
                            xhuella9 = CLASE_GENERAL.xdr("huella9")
                        End If

                        If CLASE_GENERAL.xdr("huella10") Is DBNull.Value Then
                            xhuella10 = ""
                        Else
                            xhuella10 = CLASE_GENERAL.xdr("huella10")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella1"

                    CLASE_GENERAL.sql = "SELECT huella1, huella1_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella1") Is DBNull.Value Then
                            xhuella1 = ""
                        Else
                            xhuella1 = CLASE_GENERAL.xdr("huella1")
                        End If

                        If CLASE_GENERAL.xdr("huella1_reg") Is DBNull.Value Then
                            xhuella1_reg = ""
                        Else
                            xhuella1_reg = CLASE_GENERAL.xdr("huella1_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella2"

                    CLASE_GENERAL.sql = "SELECT huella2, huella2_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella2") Is DBNull.Value Then
                            xhuella2 = ""
                        Else
                            xhuella2 = CLASE_GENERAL.xdr("huella2")
                        End If

                        If CLASE_GENERAL.xdr("huella2_reg") Is DBNull.Value Then
                            xhuella2_reg = ""
                        Else
                            xhuella2_reg = CLASE_GENERAL.xdr("huella2_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella3"

                    CLASE_GENERAL.sql = "SELECT huella3, huella3_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella3") Is DBNull.Value Then
                            xhuella3 = ""
                        Else
                            xhuella3 = CLASE_GENERAL.xdr("huella3")
                        End If

                        If CLASE_GENERAL.xdr("huella3_reg") Is DBNull.Value Then
                            xhuella3_reg = ""
                        Else
                            xhuella3_reg = CLASE_GENERAL.xdr("huella3_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella4"

                    CLASE_GENERAL.sql = "SELECT huella4, huella4_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella4") Is DBNull.Value Then
                            xhuella4 = ""
                        Else
                            xhuella4 = CLASE_GENERAL.xdr("huella4")
                        End If

                        If CLASE_GENERAL.xdr("huella4_reg") Is DBNull.Value Then
                            xhuella4_reg = ""
                        Else
                            xhuella4_reg = CLASE_GENERAL.xdr("huella4_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella5"

                    CLASE_GENERAL.sql = "SELECT huella5, huella5_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella5") Is DBNull.Value Then
                            xhuella5 = ""
                        Else
                            xhuella5 = CLASE_GENERAL.xdr("huella5")
                        End If

                        If CLASE_GENERAL.xdr("huella5_reg") Is DBNull.Value Then
                            xhuella5_reg = ""
                        Else
                            xhuella5_reg = CLASE_GENERAL.xdr("huella5_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "huella6"

                    CLASE_GENERAL.sql = "SELECT huella6, huella6_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella6") Is DBNull.Value Then
                            xhuella6 = ""
                        Else
                            xhuella6 = CLASE_GENERAL.xdr("huella6")
                        End If

                        If CLASE_GENERAL.xdr("huella6_reg") Is DBNull.Value Then
                            xhuella6_reg = ""
                        Else
                            xhuella6_reg = CLASE_GENERAL.xdr("huella6_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "huella7"

                    CLASE_GENERAL.sql = "SELECT huella7, huella7_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella7") Is DBNull.Value Then
                            xhuella7 = ""
                        Else
                            xhuella7 = CLASE_GENERAL.xdr("huella7")
                        End If

                        If CLASE_GENERAL.xdr("huella7_reg") Is DBNull.Value Then
                            xhuella7_reg = ""
                        Else
                            xhuella7_reg = CLASE_GENERAL.xdr("huella7_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella8"

                    CLASE_GENERAL.sql = "SELECT huella8, huella8_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella8") Is DBNull.Value Then
                            xhuella8 = ""
                        Else
                            xhuella8 = CLASE_GENERAL.xdr("huella8")
                        End If

                        If CLASE_GENERAL.xdr("huella8_reg") Is DBNull.Value Then
                            xhuella8_reg = ""
                        Else
                            xhuella8_reg = CLASE_GENERAL.xdr("huella8_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella9"

                    CLASE_GENERAL.sql = "SELECT huella9, huella9_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella9") Is DBNull.Value Then
                            xhuella9 = ""
                        Else
                            xhuella9 = CLASE_GENERAL.xdr("huella9")
                        End If

                        If CLASE_GENERAL.xdr("huella9_reg") Is DBNull.Value Then
                            xhuella9_reg = ""
                        Else
                            xhuella9_reg = CLASE_GENERAL.xdr("huella9_reg")
                        End If

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "huella10"

                    CLASE_GENERAL.sql = "SELECT huella10, huella10_reg  FROM huellas WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        If CLASE_GENERAL.xdr("huella10") Is DBNull.Value Then
                            xhuella10 = ""
                        Else
                            xhuella10 = CLASE_GENERAL.xdr("huella10")
                        End If

                        If CLASE_GENERAL.xdr("huella10_reg") Is DBNull.Value Then
                            xhuella10_reg = ""
                        Else
                            xhuella10_reg = CLASE_GENERAL.xdr("huella10_reg")
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

