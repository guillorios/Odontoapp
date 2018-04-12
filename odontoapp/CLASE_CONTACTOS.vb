Imports MySql.Data.MySqlClient

Public Class CLASE_CONTACTOS

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xIdTTutor As Integer
    Public Shared xtelcasacontacto As String
    Public Shared xteloficinacontacto As String
    Public Shared xfaxcontacto As String
    Public Shared xcelcontacto As String
    Public Shared xemailcontacto As String
    Public Shared xwebcontacto As String
    Public Shared xnomcontacto As String
    Public Shared xocucontacto As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private IdTTutor As Integer
    Private telcasa_con As String
    Private teloficina_con As String
    Private fax_con As String
    Private cel_con As String
    Private email_con As String
    Private web_con As String
    Private nom_con As String
    Private ocu_con As String
    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0
        Me.IdTTutor = 0
        Me.telcasa_con = ""
        Me.teloficina_con = ""
        Me.fax_con = ""
        Me.cel_con = ""
        Me.email_con = ""
        Me.web_con = ""
        Me.nom_con = ""
        Me.ocu_con = ""
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

    Public Property p_IdTTutor() As Integer
        Get
            Return Me.IdTTutor
        End Get
        Set(ByVal Value As Integer)
            Me.IdTTutor = Value
        End Set
    End Property

    Public Property p_telcasa_con() As String
        Get
            Return Me.telcasa_con
        End Get
        Set(ByVal Value As String)
            Me.telcasa_con = Value
        End Set
    End Property

    Public Property p_teloficina_con() As String
        Get
            Return Me.teloficina_con
        End Get
        Set(ByVal Value As String)
            Me.teloficina_con = Value
        End Set
    End Property

    Public Property p_fax_con() As String
        Get
            Return Me.fax_con
        End Get
        Set(ByVal Value As String)
            Me.fax_con = Value
        End Set
    End Property

    Public Property p_cel_con() As String
        Get
            Return Me.cel_con
        End Get
        Set(ByVal Value As String)
            Me.cel_con = Value
        End Set
    End Property

    Public Property p_email_con() As String
        Get
            Return Me.email_con
        End Get
        Set(ByVal Value As String)
            Me.email_con = Value
        End Set
    End Property

    Public Property p_web_con() As String
        Get
            Return Me.web_con
        End Get
        Set(ByVal Value As String)
            Me.web_con = Value
        End Set
    End Property

    Public Property p_nom_con() As String
        Get
            Return Me.nom_con
        End Get
        Set(ByVal Value As String)
            Me.nom_con = Value
        End Set
    End Property

    Public Property p_ocu_con() As String
        Get
            Return Me.ocu_con
        End Get
        Set(ByVal Value As String)
            Me.ocu_con = Value
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

            CLASE_GENERAL.sql = "Delete from contactos where IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

    Public Function Insertar(ByVal sql As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try
            CLASE_GENERAL.sql = "INSERT INTO contactos (IdUsuario, IdTUsuario, IdTTutor, telcasa_con, teloficina_con, fax_con, cel_con, email_con, web_con, nom_con, ocu_con) VALUES  (" & Me.IdUsuario & ", " & Me.IdTUsuario & ", " & Me.IdTTutor & ", '" & Me.telcasa_con & "', '" & Me.teloficina_con & "', '" & Me.fax_con & "', '" & Me.cel_con & "', '" & Me.email_con & "','" & Me.web_con & "','" & Me.nom_con & "', '" & Me.ocu_con & "' )"
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
            CLASE_GENERAL.sql = "UPDATE contactos set telcasa_con = '" & Me.telcasa_con & "', teloficina_con = '" & Me.teloficina_con & "', fax_con = '" & Me.fax_con & "', cel_con = '" & Me.cel_con & "', email_con = '" & Me.email_con & "', web_con = '" & Me.web_con & "', nom_con = '" & Me.nom_con & "', ocu_con = '" & Me.ocu_con & "' WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " AND IdTTutor = " & Me.IdTTutor & " "
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

            Select Case mensaje

                Case "xdt"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT * FROM contactos where IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.sql, CLASE_GENERAL.xcon) 'llena el adaptador con el select enviado o el que llega

                    If CLASE_GENERAL.xcon.State = Data.ConnectionState.Closed Then CLASE_GENERAL.xcon.Open()
                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt)

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "xdt2"

                    CLASE_GENERAL.xdt2 = New DataTable
                    CLASE_GENERAL.sql = "SELECT * FROM contactos where IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.sql, CLASE_GENERAL.xcon) 'llena el adaptador con el select enviado o el que llega

                    If CLASE_GENERAL.xcon.State = Data.ConnectionState.Closed Then CLASE_GENERAL.xcon.Open()
                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt2)

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "xdtemail"

                    CLASE_GENERAL.xdt2 = New DataTable
                    CLASE_GENERAL.sql = "SELECT IdUsuario, IdTUsuario, IdTTutor, email_con FROM contactos where IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " ORDER BY IdTTutor DESC "
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.sql, CLASE_GENERAL.xcon) 'llena el adaptador con el select enviado o el que llega

                    If CLASE_GENERAL.xcon.State = Data.ConnectionState.Closed Then CLASE_GENERAL.xcon.Open()
                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt2)

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

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
