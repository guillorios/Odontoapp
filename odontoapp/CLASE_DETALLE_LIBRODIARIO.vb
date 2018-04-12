Imports MySql.Data.MySqlClient

Public Class CLASE_DETALLE_LIBRODIARIO

    Implements CLASE_GENERAL.DML


#Region "Consultas"

    Public Shared xIdlibrodiario As Integer
    Public Shared xIddocumento As Integer
    Public Shared xconcepto_doc As String
    Public Shared xIdbeneficiario As Integer
    Public Shared xnombeneficiario As String
    Public Shared xIdtipodoc As Integer
    Public Shared xdebitos As Double
    Public Shared xcreditos As Double
    Public Shared xIdestado As Integer

#End Region

#Region "Atributos"

    Private Idlibrodiario As Integer
    Private Iddocumento As Integer
    Private concepto_doc As String
    Private Idbeneficiario As Integer
    Private nombeneficiario As String
    Private Idtipodoc As Integer
    Private debitos As Double
    Private creditos As Double
    Private Idestado As Integer

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idlibrodiario = 0
        Me.Iddocumento = 0
        Me.concepto_doc = ""
        Me.Idbeneficiario = 0
        Me.nombeneficiario = ""
        Me.Idtipodoc = 0
        Me.debitos = 0
        Me.creditos = 0
        Me.Idestado = 0

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idlibrodiario() As Integer

        Get
            Return Me.Idlibrodiario
        End Get

        Set(ByVal Value As Integer)
            Me.Idlibrodiario = Value
        End Set

    End Property

    Public Property p_Iddocumento() As Integer

        Get
            Return Me.Iddocumento
        End Get

        Set(ByVal Value As Integer)
            Me.Iddocumento = Value
        End Set

    End Property

    Public Property p_concepto_doc() As String
        Get
            Return Me.concepto_doc
        End Get
        Set(ByVal Value As String)
            Me.concepto_doc = Value
        End Set
    End Property

    Public Property p_Idbeneficiario() As Integer

        Get
            Return Me.Idbeneficiario
        End Get

        Set(ByVal Value As Integer)
            Me.Idbeneficiario = Value
        End Set

    End Property

    Public Property p_nombeneficiario() As String

        Get
            Return Me.nombeneficiario
        End Get

        Set(ByVal Value As String)
            Me.nombeneficiario = Value
        End Set

    End Property

    Public Property p_Idtipodoc() As Integer

        Get
            Return Me.Idtipodoc
        End Get

        Set(ByVal Value As Integer)
            Me.Idtipodoc = Value
        End Set

    End Property

    Public Property p_debitos() As Double
        Get
            Return Me.debitos
        End Get
        Set(ByVal Value As Double)
            Me.debitos = Value
        End Set
    End Property

    Public Property p_creditos() As Double
        Get
            Return Me.creditos
        End Get
        Set(ByVal Value As Double)
            Me.creditos = Value
        End Set
    End Property

    Public Property p_Idestado() As Integer

        Get
            Return Me.Idestado
        End Get

        Set(ByVal Value As Integer)
            Me.Idestado = Value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.detalle_librodiario WHERE Idlibrodiario = " & Me.Idlibrodiario & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.detalle_librodiario (Idlibrodiario, Iddocumento, concepto_doc, Idbeneficiario, nombeneficiario, Idtipodoc, debitos, creditos, Idestado) VALUES (" & Me.Idlibrodiario & ", " & Me.Iddocumento & ", '" & Me.concepto_doc & "', " & Me.Idbeneficiario & ", '" & Me.nombeneficiario & "', " & Me.Idtipodoc & ", " & Me.debitos & ", " & Me.creditos & ", " & Me.Idestado & ")"
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

            CLASE_GENERAL.sql = "UPDATE(Orthosoft.detalle_librodiario) SET Idlibrodiario = " & Me.Idlibrodiario & ", Iddocumento = " & Me.Iddocumento & " , concepto_doc = '" & Me.concepto_doc & "' , Idbeneficiario = " & Me.Idbeneficiario & " , nombeneficiario = '" & Me.nombeneficiario & "' , Idtipodoc = " & Me.Idtipodoc & " , debitos = " & Me.debitos & " , creditos =" & Me.creditos & " , Idestado = " & Me.Idestado & " " _
            & "WHERE Idlibrodiario = " & Me.Idlibrodiario & " AND Iddocumento = " & Me.Iddocumento & " AND concepto_doc = '" & Me.concepto_doc & "' AND Idbeneficiario = " & Me.Idbeneficiario & " AND nombeneficiario = '" & Me.nombeneficiario & "' AND Idtipodoc = " & Me.Idtipodoc & " AND debitos = " & Me.debitos & " AND creditos = " & Me.creditos & " AND Idestado = " & Me.Idestado & ""

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

                Case "tabla"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT Idlibrodiario, Iddocumento, concepto_doc, Idbeneficiario, nombeneficiario, Idtipodoc, debitos, creditos, Idestado FROM Orthosoft.detalle_librodiario "
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\varios\cuotaspaciente.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idlibrodiario, Iddocumento, concepto_doc, Idbeneficiario, nombeneficiario, Idtipodoc, debitos, creditos, Idestado FROM Orthosoft.detalle_librodiario "

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdlibrodiario = CLASE_GENERAL.xdr("Idlibrodiario")
                        xdebitos = CLASE_GENERAL.xdr("debitos")
                        xcreditos = CLASE_GENERAL.xdr("creditos")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

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
