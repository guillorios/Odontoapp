Imports System.Data.OleDb

Public Class CLASE_CALLCENTER_N

    Implements CLASE_GENERAL_ACCESS.DML


#Region "Atributos"

    Private Telephone As String
    Private Last_Name As String
    Private First_Name As String
    Private Address_1 As String
    Private Email_Address As String

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Telephone = ""
        Me.Last_Name = ""
        Me.First_Name = ""
        Me.Address_1 = ""
        Me.Email_Address = ""
        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Telephone() As String
        Get
            Return Me.Telephone
        End Get
        Set(ByVal Value As String)
            Me.Telephone = Value
        End Set
    End Property

    Public Property p_Last_Name() As String
        Get
            Return Me.Last_Name
        End Get
        Set(ByVal Value As String)
            Me.Last_Name = Value
        End Set
    End Property

    Public Property p_First_Name() As String
        Get
            Return Me.First_Name
        End Get
        Set(ByVal Value As String)
            Me.First_Name = Value
        End Set
    End Property

    Public Property p_Address_1() As String
        Get
            Return Me.Address_1
        End Get
        Set(ByVal Value As String)
            Me.Address_1 = Value
        End Set
    End Property
    Public Property p_Email_Address() As String
        Get
            Return Me.Email_Address
        End Get
        Set(ByVal Value As String)
            Me.Email_Address = Value
        End Set
    End Property

    Public ReadOnly Property p_dt() As DataTable
        Get
            Return Me.dt
        End Get
    End Property

#End Region


    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL_ACCESS.DML.Eliminar

        Select Case mensaje

            Case "citasmañana"

                Try

                    CLASE_GENERAL_ACCESS.accsql = "DELETE * FROM DialList"
                    CLASE_GENERAL_ACCESS.acccomando = New OleDbCommand(CLASE_GENERAL_ACCESS.accsql, CLASE_GENERAL_ACCESS.acccon)
                    CLASE_GENERAL_ACCESS.acccomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL_ACCESS.acccomando.Dispose()
                    CLASE_GENERAL_ACCESS.acccomando = Nothing

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False
                End Try

            Case "citasna"

                Try

                    CLASE_GENERAL_ACCESS.accsql = "DELETE * FROM DialList"
                    CLASE_GENERAL_ACCESS.acccomando = New OleDbCommand(CLASE_GENERAL_ACCESS.accsql, CLASE_GENERAL_ACCESS.acccon)
                    CLASE_GENERAL_ACCESS.acccomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL_ACCESS.acccomando.Dispose()
                    CLASE_GENERAL_ACCESS.acccomando = Nothing

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False
                End Try

            Case "cumpleaños"

                Try

                    CLASE_GENERAL_ACCESS.accsql = "DELETE * FROM DialList"
                    CLASE_GENERAL_ACCESS.acccomando = New OleDbCommand(CLASE_GENERAL_ACCESS.accsql, CLASE_GENERAL_ACCESS.acccon)
                    CLASE_GENERAL_ACCESS.acccomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL_ACCESS.acccomando.Dispose()
                    CLASE_GENERAL_ACCESS.acccomando = Nothing

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False
                End Try



        End Select

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL_ACCESS.DML.Insertar

        Select Case mensaje

            Case "citasmañana"

                Try

                    CLASE_GENERAL_ACCESS.accsql = "INSERT INTO DialList(Telephone, Last_name, First_name, Address_1, Email_Address) VALUES  ('" & Me.Telephone & "','" & Left(Me.Last_Name, 25) & "', '" & Left(Me.First_Name, 25) & "', '" & Left(Me.Address_1, 25) & "', '" & Me.Email_Address & "')"
                    CLASE_GENERAL_ACCESS.acccomando = New OleDbCommand(CLASE_GENERAL_ACCESS.accsql, CLASE_GENERAL_ACCESS.acccon)
                    CLASE_GENERAL_ACCESS.acccomando.ExecuteNonQuery()

                    CLASE_GENERAL_ACCESS.acccomando.Dispose()
                    CLASE_GENERAL_ACCESS.acccomando = Nothing

                    Return True

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False

                End Try

            Case "citasna"

                Try

                    CLASE_GENERAL_ACCESS.accsql = "INSERT INTO DialList(Telephone, Last_name, First_name, Address_1, Email_Address) VALUES  ('" & Me.Telephone & "','" & Left(Me.Last_Name, 25) & "', '" & Left(Me.First_Name, 25) & "', '" & Left(Me.Address_1, 25) & "', '" & Me.Email_Address & "')"
                    CLASE_GENERAL_ACCESS.acccomando = New OleDbCommand(CLASE_GENERAL_ACCESS.accsql, CLASE_GENERAL_ACCESS.acccon)
                    CLASE_GENERAL_ACCESS.acccomando.ExecuteNonQuery()

                    CLASE_GENERAL_ACCESS.acccomando.Dispose()
                    CLASE_GENERAL_ACCESS.acccomando = Nothing

                    Return True

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False

                End Try


            Case "cumpleaños"

                Try

                    CLASE_GENERAL_ACCESS.accsql = "INSERT INTO DialList(Telephone, Last_name, First_name, Address_1, Email_Address) VALUES  ('" & Me.Telephone & "','" & Left(Me.Last_Name, 25) & "', '" & Left(Me.First_Name, 25) & "', '" & Left(Me.Address_1, 25) & "', '" & Me.Email_Address & "')"
                    CLASE_GENERAL_ACCESS.acccomando = New OleDbCommand(CLASE_GENERAL_ACCESS.accsql, CLASE_GENERAL_ACCESS.acccon)
                    CLASE_GENERAL_ACCESS.acccomando.ExecuteNonQuery()

                    CLASE_GENERAL_ACCESS.acccomando.Dispose()
                    CLASE_GENERAL_ACCESS.acccomando = Nothing

                    Return True

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False

                End Try

        End Select


    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL_ACCESS.DML.Modificar

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL_ACCESS.DML.Seleccionar

    End Function

End Class
