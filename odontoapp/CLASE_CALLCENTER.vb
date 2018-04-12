Imports System.Data.OleDb

Public Class CLASE_CALLCENTER

    Implements Clase_general_fox.DML


#Region "Atributos"

    Private Telephone As String
    Private Last_Name As String
    Private First_Name As String
    Private Address_1 As String
    Private Emailaddr As String
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
        Me.Emailaddr = ""
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

    Public Property p_Last_name() As String
        Get
            Return Me.Last_name
        End Get
        Set(ByVal Value As String)
            Me.Last_name = Value
        End Set
    End Property

    Public Property p_First_name() As String
        Get
            Return Me.First_name
        End Get
        Set(ByVal Value As String)
            Me.First_name = Value
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
    Public Property p_Emailaddr() As String
        Get
            Return Me.Emailaddr
        End Get
        Set(ByVal Value As String)
            Me.Emailaddr = Value
        End Set
    End Property

    Public ReadOnly Property p_dt() As DataTable
        Get
            Return Me.dt
        End Get
    End Property

#End Region


    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements Clase_general_fox.DML.Eliminar

        Select Case mensaje

            Case "citasmañana"

                Try

                    Clase_general_fox.foxsql = "DELETE * FROM citas "
                    Clase_general_fox.foxcomando = New OleDbCommand(Clase_general_fox.foxsql, Clase_general_fox.foxcon)
                    Clase_general_fox.foxcomando.ExecuteNonQuery()

                    Return True

                    Clase_general_fox.foxcomando.Dispose()
                    Clase_general_fox.foxcomando = Nothing

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False
                End Try

            Case "citasna"

                Try

                    Clase_general_fox.foxsql = "DELETE * FROM citasna "
                    Clase_general_fox.foxcomando = New OleDbCommand(Clase_general_fox.foxsql, Clase_general_fox.foxcon)
                    Clase_general_fox.foxcomando.ExecuteNonQuery()

                    Return True

                    Clase_general_fox.foxcomando.Dispose()
                    Clase_general_fox.foxcomando = Nothing

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False
                End Try

            Case "cumpleaños"

                Try

                    Clase_general_fox.foxsql = "DELETE * FROM cumple "
                    Clase_general_fox.foxcomando = New OleDbCommand(Clase_general_fox.foxsql, Clase_general_fox.foxcon)
                    Clase_general_fox.foxcomando.ExecuteNonQuery()

                    Return True

                    Clase_general_fox.foxcomando.Dispose()
                    Clase_general_fox.foxcomando = Nothing

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False
                End Try



        End Select

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements Clase_general_fox.DML.Insertar

        Select Case mensaje

            Case "citasmañana"

                Try

                    Clase_general_fox.foxsql = "INSERT INTO citas(Telephone, Last_name, First_name, Address_1, Emailaddr) VALUES  ('" & Me.Telephone & "','" & Left(Me.Last_name, 25) & "', '" & Left(Me.First_name, 25) & "', '" & Left(Me.Address_1, 25) & "', '" & Me.Emailaddr & "')"
                    Clase_general_fox.foxcomando = New OleDbCommand(Clase_general_fox.foxsql, Clase_general_fox.foxcon)
                    Clase_general_fox.foxcomando.ExecuteNonQuery()

                    Clase_general_fox.foxcomando.Dispose()
                    Clase_general_fox.foxcomando = Nothing

                    Return True

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False

                End Try

            Case "citasna"

                Try

                    Clase_general_fox.foxsql = "INSERT INTO citasna (Telephone, Last_name, First_name, Address_1, Emailaddr) VALUES  ('" & Me.Telephone & "','" & Left(Me.Last_name, 25) & "', '" & Left(Me.First_name, 25) & "', '" & Left(Me.Address_1, 25) & "', '" & Me.Emailaddr & "')"
                    Clase_general_fox.foxcomando = New OleDbCommand(Clase_general_fox.foxsql, Clase_general_fox.foxcon)
                    Clase_general_fox.foxcomando.ExecuteNonQuery()

                    Clase_general_fox.foxcomando.Dispose()
                    Clase_general_fox.foxcomando = Nothing

                    Return True

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False

                End Try


            Case "cumpleaños"
                Try

                    Clase_general_fox.foxsql = "INSERT INTO cumple (Telephone, Last_name, First_name, Address_1, Emailaddr) VALUES  ('" & Me.Telephone & "','" & Left(Me.Last_name, 25) & "', '" & Left(Me.First_name, 25) & "', '" & Left(Me.Address_1, 25) & "', '" & Me.Emailaddr & "')"
                    Clase_general_fox.foxcomando = New OleDbCommand(Clase_general_fox.foxsql, Clase_general_fox.foxcon)
                    Clase_general_fox.foxcomando.ExecuteNonQuery()

                    Clase_general_fox.foxcomando.Dispose()
                    Clase_general_fox.foxcomando = Nothing

                    Return True

                Catch ex As Exception

                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                    Return False

                End Try

        End Select


    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements Clase_general_fox.DML.Modificar

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements Clase_general_fox.DML.Seleccionar

    End Function

End Class
