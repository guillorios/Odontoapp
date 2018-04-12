Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA_P4

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xmalomolar_hp4 As String
    Public Shared xmalocanina_hp4 As String
    Public Shared xtdenticion_hp4 As String
    Public Shared xlmedias_hp4 As String
    Public Shared xoverjet_hp4 As String
    Public Shared xoverbite_hp4 As String
    Public Shared xdientesausentes_hp4 As String
    Public Shared xtipoapi_hp4 As String
    Public Shared xmejorarperfil_hp4 As String
    Public Shared xcorrperfil_hp4 As String
    Public Shared xangnasolab_hp4 As String
    Public Shared xlabios_hp4 As String
    Public Shared xctrlperfesq_hp4 As String
    Public Shared xcorrperfesq_hp4 As String
    Public Shared xcorrfrente_hp4 As String
    Public Shared xlograroverjet_hp4 As String
    Public Shared xlograrmolarcan_hp4 As String
    Public Shared xlograrbuenaocl_hp4 As String
    Public Shared xplan1_hp4 As String
    Public Shared xplan2_hp4 As String
    Public Shared xplan3_hp4 As String
    Public Shared xtratamortognatico_hp4 As String
    Public Shared xreqtratam_hp4 As String
    Public Shared xcuantas_hp4 As String
    Public Shared xtratamientodef_hp4 As String
    Public Shared xlimitacaso_hp4 As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private malomolar_hp4 As String
    Private malocanina_hp4 As String
    Private tdenticion_hp4 As String
    Private lmedias_hp4 As String
    Private overjet_hp4 As String
    Private overbite_hp4 As String
    Private dientesausentes_hp4 As String
    Private tipoapi_hp4 As String
    Private mejorarperfil_hp4 As String
    Private corrperfil_hp4 As String
    Private angnasolab_hp4 As String
    Private labios_hp4 As String
    Private ctrlperfesq_hp4 As String
    Private corrperfesq_hp4 As String
    Private corrfrente_hp4 As String
    Private lograroverjet_hp4 As String
    Private lograrmolarcan_hp4 As String
    Private lograrbuenaocl_hp4 As String
    Private plan1_hp4 As String
    Private plan2_hp4 As String
    Private plan3_hp4 As String
    Private tratamortognatico_hp4 As String
    Private reqtratam_hp4 As String
    Private cuantas_hp4 As String
    Private tratamientodef_hp4 As String
    Private limitacaso_hp4 As String
    

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0
        Me.malomolar_hp4 = ""
        Me.malocanina_hp4 = ""
        Me.tdenticion_hp4 = ""
        Me.lmedias_hp4 = ""
        Me.overjet_hp4 = ""
        Me.overbite_hp4 = ""
        Me.dientesausentes_hp4 = ""
        Me.tipoapi_hp4 = ""
        Me.mejorarperfil_hp4 = ""
        Me.corrperfil_hp4 = ""
        Me.angnasolab_hp4 = ""
        Me.labios_hp4 = ""
        Me.ctrlperfesq_hp4 = ""
        Me.corrperfesq_hp4 = ""
        Me.corrfrente_hp4 = ""
        Me.lograroverjet_hp4 = ""
        Me.lograrmolarcan_hp4 = ""
        Me.lograrbuenaocl_hp4 = ""
        Me.plan1_hp4 = ""
        Me.plan2_hp4 = ""
        Me.plan3_hp4 = ""
        Me.tratamortognatico_hp4 = ""
        Me.reqtratam_hp4 = ""
        Me.cuantas_hp4 = ""
        Me.tratamientodef_hp4 = ""
        Me.limitacaso_hp4 = ""

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

    Public Property p_malomolar_hp4() As String
        Get
            Return Me.malomolar_hp4
        End Get
        Set(ByVal Value As String)
            Me.malomolar_hp4 = Value
        End Set
    End Property

    Public Property p_malocanina_hp4() As String
        Get
            Return Me.malocanina_hp4
        End Get
        Set(ByVal Value As String)
            Me.malocanina_hp4 = Value
        End Set
    End Property

    Public Property p_tdenticion_hp4() As String
        Get
            Return Me.tdenticion_hp4
        End Get
        Set(ByVal Value As String)
            Me.tdenticion_hp4 = Value
        End Set
    End Property

    Public Property p_lmedias_hp4() As String
        Get
            Return Me.lmedias_hp4
        End Get
        Set(ByVal Value As String)
            Me.lmedias_hp4 = Value
        End Set
    End Property

    Public Property p_overjet_hp4() As String
        Get
            Return Me.overjet_hp4
        End Get
        Set(ByVal Value As String)
            Me.overjet_hp4 = Value
        End Set
    End Property

    Public Property p_overbite_hp4() As String
        Get
            Return Me.overbite_hp4
        End Get
        Set(ByVal Value As String)
            Me.overbite_hp4 = Value
        End Set
    End Property

    Public Property p_dientesausentes_hp4() As String
        Get
            Return Me.dientesausentes_hp4
        End Get
        Set(ByVal Value As String)
            Me.dientesausentes_hp4 = Value
        End Set
    End Property

    Public Property p_tipoapi_hp4() As String
        Get
            Return Me.tipoapi_hp4
        End Get
        Set(ByVal Value As String)
            Me.tipoapi_hp4 = Value
        End Set
    End Property

    Public Property p_mejorarperfil_hp4() As String
        Get
            Return Me.mejorarperfil_hp4
        End Get
        Set(ByVal Value As String)
            Me.mejorarperfil_hp4 = Value
        End Set
    End Property

    Public Property p_corrperfil_hp4() As String
        Get
            Return Me.corrperfil_hp4
        End Get
        Set(ByVal Value As String)
            Me.corrperfil_hp4 = Value
        End Set
    End Property

    Public Property p_angnasolab_hp4() As String
        Get
            Return Me.angnasolab_hp4
        End Get
        Set(ByVal Value As String)
            Me.angnasolab_hp4 = Value
        End Set
    End Property

    Public Property p_labios_hp4() As String
        Get
            Return Me.labios_hp4
        End Get
        Set(ByVal Value As String)
            Me.labios_hp4 = Value
        End Set
    End Property

    Public Property p_ctrlperfesq_hp4() As String
        Get
            Return Me.ctrlperfesq_hp4
        End Get
        Set(ByVal Value As String)
            Me.ctrlperfesq_hp4 = Value
        End Set
    End Property

    Public Property p_corrperfesq_hp4() As String
        Get
            Return Me.corrperfesq_hp4
        End Get
        Set(ByVal Value As String)
            Me.corrperfesq_hp4 = Value
        End Set
    End Property

    Public Property p_corrfrente_hp4() As String
        Get
            Return Me.corrfrente_hp4
        End Get
        Set(ByVal Value As String)
            Me.corrfrente_hp4 = Value
        End Set
    End Property

    Public Property p_lograroverjet_hp4() As String
        Get
            Return Me.lograroverjet_hp4
        End Get
        Set(ByVal Value As String)
            Me.lograroverjet_hp4 = Value
        End Set
    End Property

    Public Property p_lograrmolarcan_hp4() As String
        Get
            Return Me.lograrmolarcan_hp4
        End Get
        Set(ByVal Value As String)
            Me.lograrmolarcan_hp4 = Value
        End Set
    End Property

    Public Property p_lograrbuenaocl_hp4() As String
        Get
            Return Me.lograrbuenaocl_hp4
        End Get
        Set(ByVal Value As String)
            Me.lograrbuenaocl_hp4 = Value
        End Set
    End Property

    Public Property p_plan1_hp4() As String
        Get
            Return Me.plan1_hp4
        End Get
        Set(ByVal Value As String)
            Me.plan1_hp4 = Value
        End Set
    End Property

    Public Property p_plan2_hp4() As String
        Get
            Return Me.plan2_hp4
        End Get
        Set(ByVal Value As String)
            Me.plan2_hp4 = Value
        End Set
    End Property

    Public Property p_plan3_hp4() As String
        Get
            Return Me.plan3_hp4
        End Get
        Set(ByVal Value As String)
            Me.plan3_hp4 = Value
        End Set
    End Property

    Public Property p_tratamortognatico_hp4() As String
        Get
            Return Me.tratamortognatico_hp4
        End Get
        Set(ByVal Value As String)
            Me.tratamortognatico_hp4 = Value
        End Set
    End Property

    Public Property p_reqtratam_hp4() As String
        Get
            Return Me.reqtratam_hp4
        End Get
        Set(ByVal Value As String)
            Me.reqtratam_hp4 = Value
        End Set
    End Property

    Public Property p_cuantas_hp4() As String
        Get
            Return Me.cuantas_hp4
        End Get
        Set(ByVal Value As String)
            Me.cuantas_hp4 = Value
        End Set
    End Property

    Public Property p_tratamientodef_hp4() As String
        Get
            Return Me.tratamientodef_hp4
        End Get
        Set(ByVal Value As String)
            Me.tratamientodef_hp4 = Value
        End Set
    End Property

    Public Property p_limitacaso_hp4() As String
        Get
            Return Me.limitacaso_hp4
        End Get
        Set(ByVal Value As String)
            Me.limitacaso_hp4 = Value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica_p4 WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.hclinica_p4 (IdUsuario, IdTUsuario, malomolar_hp4, malocanina_hp4, tdenticion_hp4, lmedias_hp4, overjet_hp4, overbite_hp4, dientesausentes_hp4, tipoapi_hp4, mejorarperfil_hp4, corrperfil_hp4, angnasolab_hp4, " _
            & "labios_hp4, ctrlperfesq_hp4, corrperfesq_hp4, corrfrente_hp4, lograroverjet_hp4, lograrmolarcan_hp4, lograrbuenaocl_hp4, plan1_hp4, plan2_hp4, plan3_hp4, tratamortognatico_hp4, reqtratam_hp4, cuantas_hp4, tratamientodef_hp4, limitacaso_hp4) VALUES (" & Me.IdUsuario & ", " _
            & "" & Me.IdTUsuario & ", '" & Me.malomolar_hp4 & "', '" & Me.malocanina_hp4 & "', '" & Me.tdenticion_hp4 & "', '" & Me.lmedias_hp4 & "', '" & Me.overjet_hp4 & "', '" & Me.overbite_hp4 & "', '" & Me.dientesausentes_hp4 & "', '" & Me.tipoapi_hp4 & "', '" & Me.mejorarperfil_hp4 & "', '" & Me.corrperfil_hp4 & "', '" & Me.angnasolab_hp4 & "', '" & Me.labios_hp4 & "', '" & Me.ctrlperfesq_hp4 & "', '" & Me.corrperfesq_hp4 & "', " _
            & "'" & Me.corrfrente_hp4 & "', '" & Me.lograroverjet_hp4 & "', '" & Me.lograrmolarcan_hp4 & "', '" & Me.lograrbuenaocl_hp4 & "', '" & Me.plan1_hp4 & "', '" & Me.plan2_hp4 & "', '" & Me.plan3_hp4 & "', '" & Me.tratamortognatico_hp4 & "', '" & Me.reqtratam_hp4 & "', '" & Me.cuantas_hp4 & "', '" & Me.tratamientodef_hp4 & "', '" & Me.limitacaso_hp4 & "')"

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

            CLASE_GENERAL.sql = "UPDATE orthosoft.hclinica_p4 SET malomolar_hp4 = '" & Me.malomolar_hp4 & "' , malocanina_hp4 = '" & Me.malocanina_hp4 & "' , tdenticion_hp4 = '" & Me.tdenticion_hp4 & "' , lmedias_hp4 = '" & Me.lmedias_hp4 & "' , " _
            & "overjet_hp4 = '" & Me.overjet_hp4 & "' , overbite_hp4 = '" & Me.overbite_hp4 & "' , dientesausentes_hp4 = '" & Me.dientesausentes_hp4 & "' , tipoapi_hp4 = '" & Me.tipoapi_hp4 & "' , mejorarperfil_hp4 = '" & Me.mejorarperfil_hp4 & "' , corrperfil_hp4 = '" & Me.corrperfil_hp4 & "' , angnasolab_hp4 = '" & Me.angnasolab_hp4 & "' , " _
            & "labios_hp4 = '" & Me.labios_hp4 & "' , ctrlperfesq_hp4 = '" & Me.ctrlperfesq_hp4 & "' , corrperfesq_hp4 = '" & Me.corrperfesq_hp4 & "' , corrfrente_hp4 = '" & Me.corrfrente_hp4 & "' , lograroverjet_hp4 = '" & Me.lograroverjet_hp4 & "' , lograrmolarcan_hp4 = '" & Me.lograrmolarcan_hp4 & "' , lograrbuenaocl_hp4 = '" & Me.lograrbuenaocl_hp4 & "' , " _
            & "plan1_hp4 = '" & Me.plan1_hp4 & "' , plan2_hp4 = '" & Me.plan2_hp4 & "' , plan3_hp4 = '" & Me.plan3_hp4 & "' , tratamortognatico_hp4 = '" & Me.tratamortognatico_hp4 & "' , reqtratam_hp4 = '" & Me.reqtratam_hp4 & "' , cuantas_hp4 = '" & Me.cuantas_hp4 & "' , tratamientodef_hp4 = '" & Me.tratamientodef_hp4 & "' , limitacaso_hp4 = '" & Me.limitacaso_hp4 & "' " _
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

                    CLASE_GENERAL.sql = "SELECT IdUsuario, IdTUsuario, malomolar_hp4, malocanina_hp4, tdenticion_hp4, lmedias_hp4, overjet_hp4, overbite_hp4, " _
                    & "dientesausentes_hp4, tipoapi_hp4, mejorarperfil_hp4, corrperfil_hp4, angnasolab_hp4, labios_hp4, ctrlperfesq_hp4, corrperfesq_hp4, corrfrente_hp4, " _
                    & "lograroverjet_hp4, lograrmolarcan_hp4, lograrbuenaocl_hp4, plan1_hp4, plan2_hp4, plan3_hp4, tratamortognatico_hp4, reqtratam_hp4, cuantas_hp4, " _
                    & "tratamientodef_hp4, limitacaso_hp4 FROM Orthosoft.hclinica_p4 " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()


                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")
                        xmalomolar_hp4 = CLASE_GENERAL.xdr("malomolar_hp4")
                        xmalocanina_hp4 = CLASE_GENERAL.xdr("malocanina_hp4")
                        xtdenticion_hp4 = CLASE_GENERAL.xdr("tdenticion_hp4")
                        xlmedias_hp4 = CLASE_GENERAL.xdr("lmedias_hp4")
                        xoverjet_hp4 = CLASE_GENERAL.xdr("overjet_hp4")
                        xoverbite_hp4 = CLASE_GENERAL.xdr("overbite_hp4")
                        xdientesausentes_hp4 = CLASE_GENERAL.xdr("dientesausentes_hp4")
                        xtipoapi_hp4 = CLASE_GENERAL.xdr("tipoapi_hp4")
                        xmejorarperfil_hp4 = CLASE_GENERAL.xdr("mejorarperfil_hp4")
                        xcorrperfil_hp4 = CLASE_GENERAL.xdr("corrperfil_hp4")
                        xangnasolab_hp4 = CLASE_GENERAL.xdr("angnasolab_hp4")
                        xlabios_hp4 = CLASE_GENERAL.xdr("labios_hp4")
                        xctrlperfesq_hp4 = CLASE_GENERAL.xdr("ctrlperfesq_hp4")
                        xcorrperfesq_hp4 = CLASE_GENERAL.xdr("corrperfesq_hp4")
                        xcorrfrente_hp4 = CLASE_GENERAL.xdr("corrfrente_hp4")
                        xlograroverjet_hp4 = CLASE_GENERAL.xdr("lograroverjet_hp4")
                        xlograrmolarcan_hp4 = CLASE_GENERAL.xdr("lograrmolarcan_hp4")
                        xlograrbuenaocl_hp4 = CLASE_GENERAL.xdr("lograrbuenaocl_hp4")
                        xplan1_hp4 = CLASE_GENERAL.xdr("plan1_hp4")
                        xplan2_hp4 = CLASE_GENERAL.xdr("plan2_hp4")
                        xplan3_hp4 = CLASE_GENERAL.xdr("plan3_hp4")
                        xtratamortognatico_hp4 = CLASE_GENERAL.xdr("tratamortognatico_hp4")
                        xreqtratam_hp4 = CLASE_GENERAL.xdr("reqtratam_hp4")
                        xcuantas_hp4 = CLASE_GENERAL.xdr("cuantas_hp4")
                        xtratamientodef_hp4 = CLASE_GENERAL.xdr("tratamientodef_hp4")
                        xlimitacaso_hp4 = CLASE_GENERAL.xdr("limitacaso_hp4")

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
