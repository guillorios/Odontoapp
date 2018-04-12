Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA_P2

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xtipoperfil_hp2 As String
    Public Shared xanguloconj_hp2 As String
    Public Shared xfrente_hp2 As String
    Public Shared xdorsonariz_hp2 As String
    Public Shared xpuntanariz_hp2 As String
    Public Shared xcolumnea_hp2 As String
    Public Shared xangnasolabial_hp2 As String
    Public Shared xlabios_hp2 As String
    Public Shared xsurcomentolabial_hp2 As String
    Public Shared xmenton_hp2 As String
    Public Shared xangulomentogarg__hp2 As String
    Public Shared xsecerupcion_hp2 As String
    Public Shared xparalelismored_hp2 As String
    Public Shared xproporcoronaraiz_hp2 As String
    Public Shared xdientesausentes__hp2 As String
    Public Shared xdientesrete_hp2 As String
    Public Shared xdientessuper_hp2 As String
    Public Shared xlesionperio_hp2 As String
    Public Shared xlesionendod_hp2 As String
    Public Shared xanatomiacond_hp2 As String
    Public Shared xestadoligamiento_hp2 As String
    Public Shared xpisosenomax_hp2 As String
    Public Shared xagujeromento_hp2 As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private tipoperfil_hp2 As String
    Private anguloconj_hp2 As String
    Private frente_hp2 As String
    Private dorsonariz_hp2 As String
    Private puntanariz_hp2 As String
    Private columnea_hp2 As String
    Private angnasolabial_hp2 As String
    Private labios_hp2 As String
    Private surcomentolabial_hp2 As String
    Private menton_hp2 As String
    Private angulomentogarg__hp2 As String
    Private secerupcion_hp2 As String
    Private paralelismored_hp2 As String
    Private proporcoronaraiz_hp2 As String
    Private dientesausentes__hp2 As String
    Private dientesrete_hp2 As String
    Private dientessuper_hp2 As String
    Private lesionperio_hp2 As String
    Private lesionendod_hp2 As String
    Private anatomiacond_hp2 As String
    Private estadoligamiento_hp2 As String
    Private pisosenomax_hp2 As String
    Private agujeromento_hp2 As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0
        Me.tipoperfil_hp2 = ""
        Me.anguloconj_hp2 = ""
        Me.frente_hp2 = ""
        Me.dorsonariz_hp2 = ""
        Me.puntanariz_hp2 = ""
        Me.columnea_hp2 = ""
        Me.angnasolabial_hp2 = ""
        Me.labios_hp2 = ""
        Me.surcomentolabial_hp2 = ""
        Me.menton_hp2 = ""
        Me.angulomentogarg__hp2 = ""
        Me.secerupcion_hp2 = ""
        Me.paralelismored_hp2 = ""
        Me.proporcoronaraiz_hp2 = ""
        Me.dientesausentes__hp2 = ""
        Me.dientesrete_hp2 = ""
        Me.dientessuper_hp2 = ""
        Me.lesionperio_hp2 = ""
        Me.lesionendod_hp2 = ""
        Me.anatomiacond_hp2 = ""
        Me.estadoligamiento_hp2 = ""
        Me.pisosenomax_hp2 = ""
        Me.agujeromento_hp2 = ""

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

    Public Property p_IdTusuario() As Integer
        Get
            Return Me.IdTusuario
        End Get
        Set(ByVal Value As Integer)
            Me.IdTusuario = Value
        End Set
    End Property

    Public Property p_tipoperfil_hp2() As String
        Get
            Return Me.tipoperfil_hp2
        End Get
        Set(ByVal Value As String)
            Me.tipoperfil_hp2 = Value
        End Set
    End Property

    Public Property p_anguloconj_hp2() As String
        Get
            Return Me.anguloconj_hp2
        End Get
        Set(ByVal Value As String)
            Me.anguloconj_hp2 = Value
        End Set
    End Property

    Public Property p_frente_hp2() As String
        Get
            Return Me.frente_hp2
        End Get
        Set(ByVal Value As String)
            Me.frente_hp2 = Value
        End Set
    End Property

    Public Property p_dorsonariz_hp2() As String
        Get
            Return Me.dorsonariz_hp2
        End Get
        Set(ByVal Value As String)
            Me.dorsonariz_hp2 = Value
        End Set
    End Property

    Public Property p_puntanariz_hp2() As String
        Get
            Return Me.puntanariz_hp2
        End Get
        Set(ByVal Value As String)
            Me.puntanariz_hp2 = Value
        End Set
    End Property

    Public Property p_columnea_hp2() As String
        Get
            Return Me.columnea_hp2
        End Get
        Set(ByVal Value As String)
            Me.columnea_hp2 = Value
        End Set
    End Property

    Public Property p_angnasolabial_hp2() As String
        Get
            Return Me.angnasolabial_hp2
        End Get
        Set(ByVal Value As String)
            Me.angnasolabial_hp2 = Value
        End Set
    End Property

    Public Property p_labios_hp2() As String
        Get
            Return Me.labios_hp2
        End Get
        Set(ByVal Value As String)
            Me.labios_hp2 = Value
        End Set
    End Property

    Public Property p_surcomentolabial_hp2() As String
        Get
            Return Me.surcomentolabial_hp2
        End Get
        Set(ByVal Value As String)
            Me.surcomentolabial_hp2 = Value
        End Set
    End Property

    Public Property p_menton_hp2() As String
        Get
            Return Me.menton_hp2
        End Get
        Set(ByVal Value As String)
            Me.menton_hp2 = Value
        End Set
    End Property

    Public Property p_angulomentogarg__hp2() As String
        Get
            Return Me.angulomentogarg__hp2
        End Get
        Set(ByVal Value As String)
            Me.angulomentogarg__hp2 = Value
        End Set
    End Property

    Public Property p_secerupcion_hp2() As String
        Get
            Return Me.secerupcion_hp2
        End Get
        Set(ByVal Value As String)
            Me.secerupcion_hp2 = Value
        End Set
    End Property

    Public Property p_paralelismored_hp2() As String
        Get
            Return Me.paralelismored_hp2
        End Get
        Set(ByVal Value As String)
            Me.paralelismored_hp2 = Value
        End Set
    End Property

    Public Property p_proporcoronaraiz_hp2() As String
        Get
            Return Me.proporcoronaraiz_hp2
        End Get
        Set(ByVal Value As String)
            Me.proporcoronaraiz_hp2 = Value
        End Set
    End Property

    Public Property p_dientesausentes__hp2() As String
        Get
            Return Me.dientesausentes__hp2
        End Get
        Set(ByVal Value As String)
            Me.dientesausentes__hp2 = Value
        End Set
    End Property

    Public Property p_dientesrete_hp2() As String
        Get
            Return Me.dientesrete_hp2
        End Get
        Set(ByVal Value As String)
            Me.dientesrete_hp2 = Value
        End Set
    End Property

    Public Property p_dientessuper_hp2() As String
        Get
            Return Me.dientessuper_hp2
        End Get
        Set(ByVal Value As String)
            Me.dientessuper_hp2 = Value
        End Set
    End Property

    Public Property p_lesionperio_hp2() As String
        Get
            Return Me.lesionperio_hp2
        End Get
        Set(ByVal Value As String)
            Me.lesionperio_hp2 = Value
        End Set
    End Property

    Public Property p_lesionendod_hp2() As String
        Get
            Return Me.lesionendod_hp2
        End Get
        Set(ByVal Value As String)
            Me.lesionendod_hp2 = Value
        End Set
    End Property

    Public Property p_anatomiacond_hp2() As String
        Get
            Return Me.anatomiacond_hp2
        End Get
        Set(ByVal Value As String)
            Me.anatomiacond_hp2 = Value
        End Set
    End Property

    Public Property p_estadoligamiento_hp2() As String
        Get
            Return Me.estadoligamiento_hp2
        End Get
        Set(ByVal Value As String)
            Me.estadoligamiento_hp2 = Value
        End Set
    End Property

    Public Property p_pisosenomax_hp2() As String
        Get
            Return Me.pisosenomax_hp2
        End Get
        Set(ByVal Value As String)
            Me.pisosenomax_hp2 = Value
        End Set
    End Property

    Public Property p_agujeromento_hp2() As String
        Get
            Return Me.agujeromento_hp2
        End Get
        Set(ByVal Value As String)
            Me.agujeromento_hp2 = Value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica_p2 WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.hclinica_p2 (IdUsuario, IdTUsuario, tipoperfil_hp2, anguloconj_hp2, frente_hp2, dorsonariz_hp2, puntanariz_hp2, columnea_hp2, " _
            & "angnasolabial_hp2, labios_hp2, surcomentolabial_hp2, menton_hp2, angulomentogarg__hp2, secerupcion_hp2, paralelismored_hp2, proporcoronaraiz_hp2, dientesausentes__hp2, " _
            & "dientesrete_hp2, dientessuper_hp2, lesionperio_hp2, lesionendod_hp2, anatomiacond_hp2, estadoligamiento_hp2, pisosenomax_hp2, agujeromento_hp2) VALUES (" & Me.IdUsuario & ", " & Me.IdTUsuario & ", " _
            & "'" & Me.tipoperfil_hp2 & "', '" & Me.anguloconj_hp2 & "', '" & Me.frente_hp2 & "', '" & Me.dorsonariz_hp2 & "', '" & Me.puntanariz_hp2 & "', '" & Me.columnea_hp2 & "', '" & Me.angnasolabial_hp2 & "', '" & Me.labios_hp2 & "', '" & Me.surcomentolabial_hp2 & "', '" & Me.menton_hp2 & "', " _
            & "'" & Me.angulomentogarg__hp2 & "', '" & Me.secerupcion_hp2 & "', '" & Me.paralelismored_hp2 & "', '" & Me.proporcoronaraiz_hp2 & "', '" & Me.dientesausentes__hp2 & "', '" & Me.dientesrete_hp2 & "', '" & Me.dientessuper_hp2 & "', '" & Me.lesionperio_hp2 & "', '" & Me.lesionendod_hp2 & "', " _
            & "'" & Me.anatomiacond_hp2 & "', '" & Me.estadoligamiento_hp2 & "', '" & Me.pisosenomax_hp2 & "', '" & Me.agujeromento_hp2 & "')"

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

            CLASE_GENERAL.sql = "UPDATE orthosoft.hclinica_p2 SET tipoperfil_hp2 = '" & Me.tipoperfil_hp2 & "' , anguloconj_hp2 = '" & Me.anguloconj_hp2 & "' , frente_hp2 = '" & Me.frente_hp2 & "' , dorsonariz_hp2 = '" & Me.dorsonariz_hp2 & "' , " _
            & "puntanariz_hp2 = '" & Me.puntanariz_hp2 & "' , columnea_hp2 = '" & Me.columnea_hp2 & "' , angnasolabial_hp2 = '" & Me.angnasolabial_hp2 & "' , labios_hp2 = '" & Me.labios_hp2 & "' , surcomentolabial_hp2 = '" & Me.surcomentolabial_hp2 & "' , menton_hp2 = '" & Me.menton_hp2 & "' , angulomentogarg__hp2 = '" & Me.angulomentogarg__hp2 & "' , " _
            & "secerupcion_hp2 = '" & Me.secerupcion_hp2 & "' , paralelismored_hp2 = '" & Me.paralelismored_hp2 & "' , proporcoronaraiz_hp2 = '" & Me.proporcoronaraiz_hp2 & "' , dientesausentes__hp2 = '" & Me.dientesausentes__hp2 & "' , dientesrete_hp2 = '" & Me.dientesrete_hp2 & "' , dientessuper_hp2 = '" & Me.dientessuper_hp2 & "' , " _
            & "lesionperio_hp2 = '" & Me.lesionperio_hp2 & "' , lesionendod_hp2 = '" & Me.lesionendod_hp2 & "' , anatomiacond_hp2 = '" & Me.anatomiacond_hp2 & "' , estadoligamiento_hp2 = '" & Me.estadoligamiento_hp2 & "' , pisosenomax_hp2 = '" & Me.pisosenomax_hp2 & "' , agujeromento_hp2 = '" & Me.agujeromento_hp2 & "' " _
            & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

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

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT IdUsuario, IdTUsuario, tipoperfil_hp2, anguloconj_hp2, frente_hp2, dorsonariz_hp2, puntanariz_hp2, columnea_hp2, angnasolabial_hp2, " _
                    & "labios_hp2, surcomentolabial_hp2, menton_hp2, angulomentogarg__hp2, secerupcion_hp2, paralelismored_hp2, proporcoronaraiz_hp2, dientesausentes__hp2, dientesrete_hp2, " _
                    & "dientessuper_hp2, lesionperio_hp2, lesionendod_hp2, anatomiacond_hp2, estadoligamiento_hp2, pisosenomax_hp2, agujeromento_hp2 FROM Orthosoft.hclinica_p2 " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()


                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")
                        xtipoperfil_hp2 = CLASE_GENERAL.xdr("tipoperfil_hp2")
                        xanguloconj_hp2 = CLASE_GENERAL.xdr("anguloconj_hp2")
                        xfrente_hp2 = CLASE_GENERAL.xdr("frente_hp2")
                        xdorsonariz_hp2 = CLASE_GENERAL.xdr("dorsonariz_hp2")
                        xpuntanariz_hp2 = CLASE_GENERAL.xdr("puntanariz_hp2")
                        xcolumnea_hp2 = CLASE_GENERAL.xdr("columnea_hp2")
                        xangnasolabial_hp2 = CLASE_GENERAL.xdr("angnasolabial_hp2")
                        xlabios_hp2 = CLASE_GENERAL.xdr("labios_hp2")
                        xsurcomentolabial_hp2 = CLASE_GENERAL.xdr("surcomentolabial_hp2")
                        xmenton_hp2 = CLASE_GENERAL.xdr("menton_hp2")
                        xangulomentogarg__hp2 = CLASE_GENERAL.xdr("angulomentogarg__hp2")
                        xsecerupcion_hp2 = CLASE_GENERAL.xdr("secerupcion_hp2")
                        xparalelismored_hp2 = CLASE_GENERAL.xdr("paralelismored_hp2")
                        xproporcoronaraiz_hp2 = CLASE_GENERAL.xdr("proporcoronaraiz_hp2")
                        xdientesausentes__hp2 = CLASE_GENERAL.xdr("dientesausentes__hp2")
                        xdientesrete_hp2 = CLASE_GENERAL.xdr("dientesrete_hp2")
                        xdientessuper_hp2 = CLASE_GENERAL.xdr("dientessuper_hp2")
                        xlesionperio_hp2 = CLASE_GENERAL.xdr("lesionperio_hp2")
                        xlesionendod_hp2 = CLASE_GENERAL.xdr("lesionendod_hp2")
                        xanatomiacond_hp2 = CLASE_GENERAL.xdr("anatomiacond_hp2")
                        xestadoligamiento_hp2 = CLASE_GENERAL.xdr("estadoligamiento_hp2")
                        xpisosenomax_hp2 = CLASE_GENERAL.xdr("pisosenomax_hp2")
                        xagujeromento_hp2 = CLASE_GENERAL.xdr("agujeromento_hp2")


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
