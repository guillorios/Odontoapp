Imports MySql.Data.MySqlClient

Public Class CLASE_DOCTORES

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIddoctor As Integer
    Public Shared xapellidos_doc As String
    Public Shared xnombres_doc As String
    Public Shared xresidencia_doc As String
    Public Shared xoficina_doc As String
    Public Shared xfecingreso_doc As String
    Public Shared xIdespecialidad As Integer
    Public Shared xfecnac_doc As String
    Public Shared xtipodoc_doc As String
    Public Shared xnumdoc_doc As String
    Public Shared xsexo_doc As String

#End Region

#Region "Atributos"

    Private Iddoctor As Integer
    Private apellidos_doc As String
    Private nombres_doc As String
    Private residencia_doc As String
    Private oficina_doc As String
    Private fecingreso_doc As String
    Private Idespecialidad As Integer
    Private fecnac_doc As String
    Private tipodoc_doc As String
    Private numdoc_doc As String
    Private sexo_doc As String
    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Iddoctor = 0
        Me.apellidos_doc = ""
        Me.nombres_doc = ""
        Me.residencia_doc = ""
        Me.oficina_doc = ""
        Me.fecingreso_doc = ""
        Me.Idespecialidad = 0
        Me.fecnac_doc = ""
        Me.tipodoc_doc = ""
        Me.numdoc_doc = ""
        Me.sexo_doc = ""
        Me.ds = New DataSet

    End Sub
#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"
    Public Property p_Iddoctor() As Integer
        Get
            Return Me.Iddoctor
        End Get
        Set(ByVal Value As Integer)
            Me.Iddoctor = Value
        End Set
    End Property
    Public Property p_apellidos_doc() As String
        Get
            Return Me.apellidos_doc
        End Get
        Set(ByVal Value As String)
            Me.apellidos_doc = Value
        End Set
    End Property

    Public Property p_nombres_doc() As String
        Get
            Return Me.nombres_doc
        End Get
        Set(ByVal Value As String)
            Me.nombres_doc = Value
        End Set
    End Property

    Public Property p_residencia_doc() As String
        Get
            Return Me.residencia_doc
        End Get
        Set(ByVal Value As String)
            Me.residencia_doc = Value
        End Set
    End Property

    Public Property p_oficina_doc() As String
        Get
            Return Me.oficina_doc
        End Get
        Set(ByVal Value As String)
            Me.oficina_doc = Value
        End Set
    End Property
    Public Property p_fecingreso_doc() As String
        Get
            Return Me.fecingreso_doc
        End Get
        Set(ByVal Value As String)
            Me.fecingreso_doc = Value
        End Set
    End Property

    Public Property p_Idespecialidad() As Integer
        Get
            Return Me.Idespecialidad
        End Get
        Set(ByVal Value As Integer)
            Me.Idespecialidad = Value
        End Set
    End Property

    Public Property p_fecnac_doc() As String
        Get
            Return Me.fecnac_doc
        End Get
        Set(ByVal Value As String)
            Me.fecnac_doc = Value
        End Set
    End Property

    Public Property p_tipodoc_doc() As String
        Get
            Return Me.tipodoc_doc
        End Get
        Set(ByVal Value As String)
            Me.tipodoc_doc = Value
        End Set
    End Property

    Public Property p_numdoc_doc() As String
        Get
            Return Me.numdoc_doc
        End Get
        Set(ByVal Value As String)
            Me.numdoc_doc = Value
        End Set
    End Property

    Public Property p_sexo_doc() As String
        Get
            Return Me.sexo_doc
        End Get
        Set(ByVal Value As String)
            Me.sexo_doc = Value
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
            CLASE_GENERAL.sql = "Delete from doctores where Iddoctor = " & Me.Iddoctor & ""
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try
            CLASE_GENERAL.sql = "INSERT INTO doctores (Iddoctor, apellidos_doc, nombres_doc, residencia_doc, oficina_doc, fecingreso_doc, Idespecialidad, fecnac_doc, tipodoc_doc, numdoc_doc, sexo_doc) VALUES  (" & Me.Iddoctor & ", '" & Me.apellidos_doc & "', '" & Me.nombres_doc & "', '" & Me.residencia_doc & "', '" & Me.oficina_doc & "', '" & Me.fecingreso_doc & "', " & Me.Idespecialidad & ", '" & Me.fecnac_doc & "', '" & Me.tipodoc_doc & "', '" & Me.numdoc_doc & "', '" & Me.sexo_doc & "')"
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()


            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Modificar

        Try
            CLASE_GENERAL.sql = "UPDATE doctores SET apellidos_doc = '" & Me.apellidos_doc & "', nombres_doc = '" & Me.nombres_doc & "', residencia_doc = '" & Me.residencia_doc & "',   oficina_doc = '" & Me.oficina_doc & "', fecingreso_doc = '" & Me.fecingreso_doc & "', Idespecialidad = " & Me.Idespecialidad & ", fecnac_doc = '" & Me.fecnac_doc & "', tipodoc_doc = '" & Me.tipodoc_doc & "', numdoc_doc = '" & Me.numdoc_doc & "', sexo_doc = '" & Me.sexo_doc & "' WHERE Iddoctor = " & Me.Iddoctor & ""
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try


    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar


        Try

            Select mensaje

                Case "doctores"

                    CLASE_GENERAL.sql = "SELECT * FROM doctores WHERE Iddoctor = '" & Me.Iddoctor & "' ORDER BY Iddoctor ASC "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIddoctor = CLASE_GENERAL.xdr("Iddoctor")
                        xapellidos_doc = CLASE_GENERAL.xdr("apellidos_doc")
                        xnombres_doc = CLASE_GENERAL.xdr("nombres_doc")
                        xresidencia_doc = CLASE_GENERAL.xdr("residencia_doc")
                        xoficina_doc = CLASE_GENERAL.xdr("oficina_doc")
                        xfecingreso_doc = CLASE_GENERAL.xdr("fecingreso_doc")
                        xIdespecialidad = CLASE_GENERAL.xdr("Idespecialidad")
                        xfecnac_doc = CLASE_GENERAL.xdr("fecnac_doc")
                        xtipodoc_doc = CLASE_GENERAL.xdr("tipodoc_doc")
                        xnumdoc_doc = CLASE_GENERAL.xdr("numdoc_doc")
                        xsexo_doc = CLASE_GENERAL.xdr("sexo_doc")

                    End If

                    CLASE_GENERAL.xdr.Close()
                    CLASE_GENERAL.xdr = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "especialidad"

                    CLASE_GENERAL.sql = "SELECT Iddoctor, Idespecialidad FROM doctores WHERE Iddoctor = '" & Me.Iddoctor & "' ORDER BY Iddoctor ASC "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIddoctor = CLASE_GENERAL.xdr("Iddoctor")
                        xIdespecialidad = CLASE_GENERAL.xdr("Idespecialidad")

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
