Imports MySql.Data.MySqlClient

Public Class CLASE_PROVEEDORES

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdproveedor As Integer
    Public Shared xnombre_prov As String
    Public Shared xdireccion_prov As String
    Public Shared xcontacto_prov As String
    Public Shared xteloficina_prov As String
    Public Shared xcelular_prov As String
    Public Shared xfax_prov As String
    Public Shared xemail_prov As String
    Public Shared xweb_prov As String
    Public Shared xIdconsultorio As Integer

#End Region

#Region "Atributos"

    Private Idproveedor As Integer
    Private nombre_prov As String
    Private direccion_prov As String
    Private contacto_prov As String
    Private teloficina_prov As String
    Private celular_prov As String
    Private fax_prov As String
    Private email_prov As String
    Private web_prov As String
    Private Idconsultorio As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idproveedor = 0
        Me.nombre_prov = ""
        Me.direccion_prov = ""
        Me.contacto_prov = ""
        Me.teloficina_prov = ""
        Me.celular_prov = ""
        Me.fax_prov = ""
        Me.email_prov = ""
        Me.web_prov = ""
        Me.Idconsultorio = 0

        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idproveedor() As Integer
        Get
            Return Me.Idproveedor
        End Get
        Set(ByVal Value As Integer)
            Me.Idproveedor = Value
        End Set
    End Property

    Public Property p_nombre_prov() As String
        Get
            Return Me.nombre_prov
        End Get
        Set(ByVal Value As String)
            Me.nombre_prov = Value
        End Set
    End Property

    Public Property p_direccion_prov() As String
        Get
            Return Me.direccion_prov
        End Get
        Set(ByVal Value As String)
            Me.direccion_prov = Value
        End Set
    End Property

    Public Property p_contacto_prov() As String
        Get
            Return Me.contacto_prov
        End Get
        Set(ByVal Value As String)
            Me.contacto_prov = Value
        End Set
    End Property

    Public Property p_teloficina_prov() As String
        Get
            Return Me.teloficina_prov
        End Get
        Set(ByVal Value As String)
            Me.teloficina_prov = Value
        End Set
    End Property

    Public Property p_celular_prov() As String
        Get
            Return Me.celular_prov
        End Get
        Set(ByVal Value As String)
            Me.celular_prov = Value
        End Set
    End Property

    Public Property p_fax_prov() As String
        Get
            Return Me.fax_prov
        End Get
        Set(ByVal Value As String)
            Me.fax_prov = Value
        End Set
    End Property

    Public Property p_email_prov() As String
        Get
            Return Me.email_prov
        End Get
        Set(ByVal Value As String)
            Me.email_prov = Value
        End Set
    End Property

    Public Property p_web_prov() As String
        Get
            Return Me.web_prov
        End Get
        Set(ByVal Value As String)
            Me.web_prov = Value
        End Set
    End Property

    Public Property p_Idconsultorio() As Integer
        Get
            Return Me.Idconsultorio
        End Get
        Set(ByVal Value As Integer)
            Me.Idconsultorio = Value
        End Set
    End Property

    Public ReadOnly Property p_dt() As DataTable
        Get
            Return Me.dt
        End Get
    End Property

#End Region

    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

        Try

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.proveedores WHERE Idproveedor = " & Me.Idproveedor & ""
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.proveedores (Idproveedor, nombre_prov, direccion_prov, contacto_prov, teloficina_prov, celular_prov, fax_prov, email_prov, web_prov, Idconsultorio) " _
            & "VALUES (" & Me.Idproveedor & ", '" & Me.nombre_prov & "', '" & Me.direccion_prov & "', '" & Me.contacto_prov & "', '" & Me.teloficina_prov & "', '" & Me.celular_prov & "', '" & Me.fax_prov & "', '" & Me.email_prov & "', '" & Me.web_prov & "', " & Me.Idconsultorio & ")"

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

                Case "registro"

                    CLASE_GENERAL.sql = "UPDATE orthosoft.proveedores SET nombre_prov = '" & Me.nombre_prov & "' , direccion_prov = '" & Me.direccion_prov & "' , contacto_prov = '" & Me.contacto_prov & "' , teloficina_prov = '" & Me.teloficina_prov & "' , celular_prov = '" & Me.celular_prov & "' , " _
                    & "fax_prov = '" & Me.fax_prov & "' , email_prov = '" & Me.email_prov & "' , web_prov = '" & Me.web_prov & "', Idconsultorio = " & Me.Idconsultorio & " WHERE Idproveedor = " & Me.Idproveedor & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
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

                Case "tabla"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT Idproveedor, nombre_prov, direccion_prov, contacto_prov, teloficina_prov, celular_prov, fax_prov, email_prov, web_prov, Idconsultorio FROM Orthosoft.proveedores"


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


                Case "registro"

                    CLASE_GENERAL.sql = "SELECT Idproveedor, nombre_prov, direccion_prov, contacto_prov, teloficina_prov, celular_prov, fax_prov, email_prov, web_prov, Idconsultorio FROM Orthosoft.proveedores WHERE Idproveedor = " & Me.Idproveedor & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdproveedor = CLASE_GENERAL.xdr("Idproveedor")
                        xnombre_prov = CLASE_GENERAL.xdr("nombre_prov")
                        xdireccion_prov = CLASE_GENERAL.xdr("direccion_prov")
                        xcontacto_prov = CLASE_GENERAL.xdr("contacto_prov")
                        xteloficina_prov = CLASE_GENERAL.xdr("teloficina_prov")
                        xcelular_prov = CLASE_GENERAL.xdr("celular_prov")
                        xfax_prov = CLASE_GENERAL.xdr("fax_prov")
                        xemail_prov = CLASE_GENERAL.xdr("email_prov")
                        xweb_prov = CLASE_GENERAL.xdr("web_prov")
                        xIdconsultorio = CLASE_GENERAL.xdr("Idconsultorio")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try


    End Function
End Class
