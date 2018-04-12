Imports MySql.Data.MySqlClient

Public Class CLASE_CALENDARIO

    Implements Clase_general.DML

#Region "Consultas"

    Public Shared xIdcalendario As Integer
    Public Shared xfecha As String
    Public Shared xhoraini As String
    Public Shared xhoraini2 As TimeSpan
    Public Shared xhorafin As String
    Public Shared xhorafin2 As TimeSpan
    Public Shared xIdcontroldia As Integer
    Public Shared xIddoctor As Integer
    Public Shared xrangocal As Integer
    Public Shared xtopecita As Integer

#End Region

#Region "Atributos"

    Private Idcalendario As Integer
    Private fecha As String
    Private horaini As String
    Private horafin As String
    Private Idcontroldia As Integer
    Private Iddoctor As Integer
    Private rangocal As String
    Private topecita As Integer
    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Idcalendario = 0
        Me.fecha = ""
        Me.horaini = ""
        Me.horafin = ""
        Me.Idcontroldia = 0
        Me.Iddoctor = 0
        Me.rangocal = ""
        Me.topecita = 0
        Me.ds = New DataSet

    End Sub
#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"
    Public Property p_Idcalendario() As Integer
        Get
            Return Me.Idcalendario
        End Get
        Set(ByVal Value As Integer)
            Me.Idcalendario = Value
        End Set
    End Property
    Public Property p_fecha() As String
        Get
            Return Me.fecha
        End Get
        Set(ByVal Value As String)
            Me.fecha = Value
        End Set
    End Property

    Public Property p_horaini() As String
        Get
            Return Me.horaini
        End Get
        Set(ByVal Value As String)
            Me.horaini = Value
        End Set
    End Property

    Public Property p_horafin() As String
        Get
            Return Me.horafin
        End Get
        Set(ByVal Value As String)
            Me.horafin = Value
        End Set
    End Property

    Public Property p_Idcontroldia() As Integer
        Get
            Return Me.Idcontroldia
        End Get
        Set(ByVal Value As Integer)
            Me.Idcontroldia = Value
        End Set
    End Property
    Public Property p_Iddoctor() As Integer
        Get
            Return Me.Iddoctor
        End Get
        Set(ByVal Value As Integer)
            Me.Iddoctor = Value
        End Set
    End Property
    Public Property p_rangocal() As String
        Get
            Return Me.rangocal
        End Get
        Set(ByVal Value As String)
            Me.rangocal = Value
        End Set
    End Property
    Public Property p_topecita() As Integer
        Get
            Return Me.topecita
        End Get
        Set(ByVal Value As Integer)
            Me.topecita = Value
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

            Clase_general.sql = "DELETE FROM calendario WHERE Idcalendario = " & Me.Idcalendario & ""
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
            CLASE_GENERAL.sql = "INSERT INTO calendario(Idcalendario, fecha, horaini, horafin, Idcontroldia, Iddoctor, rangocal, topecita) VALUES  (" & Me.Idcalendario & ", '" & Me.fecha & "', '" & Me.horaini & "', '" & Me.horafin & "', " & Me.Idcontroldia & ", " & Me.Iddoctor & ", '" & Me.rangocal & "', " & Me.topecita & ")"
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

            Select Case mensaje

                Case "registro"

                    CLASE_GENERAL.sql = "UPDATE calendario SET fecha = '" & Me.fecha & "', horaini = '" & Me.horaini & "', horafin = '" & Me.horafin & "', Idcontroldia = " & Me.Idcontroldia & ", Iddoctor = " & Me.Iddoctor & ", rangocal = '" & Me.rangocal & "', topecita = '" & Me.topecita & "' WHERE Idcalendario = " & Me.Idcalendario & ""

                Case "estado"

                    CLASE_GENERAL.sql = "UPDATE calendario SET Idcontroldia = " & Me.Idcontroldia & " WHERE Idcalendario = " & Me.Idcalendario & ""

            End Select


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

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Seleccionar

        Try

            Select Case mensaje

                Case "mes"

                    Clase_general.xdt = New DataTable
                    Clase_general.sql = "SELECT * FROM calendario where year(fecha) = year('" & Me.fecha & "') and month(fecha)= month('" & Me.fecha & "') AND Iddoctor = " & Me.Iddoctor & ""
                    Clase_general.xda = New MySqlDataAdapter(Clase_general.sql, Clase_general.xcon) 'llena el adaptador con el select enviado o el que llega

                    If Clase_general.xcon.State = Data.ConnectionState.Closed Then Clase_general.xcon.Open()
                    Clase_general.xda.Fill(Clase_general.xdt)

                    Return True

                    Clase_general.xcomando.Dispose()
                    Clase_general.xcomando = Nothing


                Case "dia"

                    Clase_general.sql = "SELECT * FROM calendario where fecha = '" & Me.fecha & "' AND Iddoctor = " & Me.Iddoctor & " "
                    Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
                    Clase_general.xdr = Clase_general.xcomando.ExecuteReader()

                    If Clase_general.xdr.Read Then 'existen datos en el dr

                        xIdcalendario = Clase_general.xdr("Idcalendario")
                        xfecha = Clase_general.xdr("fecha")
                        xhoraini = Convert.ToString(Clase_general.xdr("horaini"))
                        xhoraini2 = Clase_general.xdr("horaini")
                        xhorafin = Convert.ToString(Clase_general.xdr("horafin"))
                        xhorafin2 = Clase_general.xdr("horafin")
                        xIdcontroldia = Clase_general.xdr("Idcontroldia")
                        xrangocal = Clase_general.xdr("rangocal")
                        xtopecita = Clase_general.xdr("topecita")

                    End If

                    Clase_general.xdr.Close()
                    Clase_general.xdr = Nothing
                    Clase_general.xcomando.Dispose()
                    Clase_general.xcomando = Nothing



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
