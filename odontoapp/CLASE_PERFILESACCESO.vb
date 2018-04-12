Imports MySql.Data.MySqlClient

Public Class CLASE_PERFILESACCESO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdperfil As Integer
    Public Shared xnom_perf As String
    Public Shared xTabFunciones As String
    Public Shared xTabBackup As String
    Public Shared xTabCambioUsuarios As String
    Public Shared xTabSincro As String
    Public Shared xTabMenuPacientes As String
    Public Shared xTabMenuDoctores As String
    Public Shared xTabMenuUsuarios As String
    Public Shared xTabMenuEntidades As String
    Public Shared xTabMenuInformes As String
    Public Shared xTabMenuAdmon As String
    Public Shared xTabMenuCitas As String
    Public Shared xTabMenuContab As String
    Public Shared xTabMenuVarios As String
    Public Shared xTabSchedulerSup As String
    Public Shared xTabScheduler As String
    Public Shared xTabCitas As String
    Public Shared xTabFicha As String
    Public Shared xTabPacientes As String
    Public Shared xTabDoctores As String
    Public Shared xTabUsuarios As String
    Public Shared xTabEntidades As String
    Public Shared xTabHC As String
    Public Shared xTabProcdiario As String

#End Region

#Region "Atributos"

    Private Idperfil As Integer
    Private nom_perf As String
    Private TabFunciones As String
    Private TabBackup As String
    Private TabCambioUsuarios As String
    Private TabSincro As String
    Private TabMenuPacientes As String
    Private TabMenuDoctores As String
    Private TabMenuUsuarios As String
    Private TabMenuEntidades As String
    Private TabMenuInformes As String
    Private TabMenuAdmon As String
    Private TabMenuCitas As String
    Private TabMenuContab As String
    Private TabMenuVarios As String
    Private TabSchedulerSup As String
    Private TabScheduler As String
    Private TabCitas As String
    Private TabFicha As String
    Private TabPacientes As String
    Private TabDoctores As String
    Private TabUsuarios As String
    Private TabEntidades As String
    Private TabHC As String
    Private TabProcdiario As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idperfil = 0
        Me.nom_perf = ""
        Me.TabFunciones = ""
        Me.TabBackup = ""
        Me.TabCambioUsuarios = ""
        Me.TabSincro = ""
        Me.TabMenuPacientes = ""
        Me.TabMenuDoctores = ""
        Me.TabMenuUsuarios = ""
        Me.TabMenuEntidades = ""
        Me.TabMenuInformes = ""
        Me.TabMenuAdmon = ""
        Me.TabMenuCitas = ""
        Me.TabMenuContab = ""
        Me.TabMenuVarios = ""
        Me.TabSchedulerSup = ""
        Me.TabScheduler = ""
        Me.TabCitas = ""
        Me.TabFicha = ""
        Me.TabPacientes = ""
        Me.TabDoctores = ""
        Me.TabUsuarios = ""
        Me.TabEntidades = ""
        Me.TabHC = ""
        Me.TabProcdiario = ""

        Me.ds = New DataSet

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idperfil() As Integer
        Get
            Return Me.Idperfil
        End Get
        Set(ByVal Value As Integer)
            Me.Idperfil = Value
        End Set
    End Property

    Public Property p_nom_perf() As String
        Get
            Return Me.nom_perf
        End Get
        Set(ByVal Value As String)
            Me.nom_perf = Value
        End Set
    End Property

    Public Property p_TabFunciones() As String
        Get
            Return Me.TabFunciones
        End Get
        Set(ByVal Value As String)
            Me.TabFunciones = Value
        End Set
    End Property

    Public Property p_TabBackups() As String
        Get
            Return Me.TabBackup
        End Get
        Set(ByVal Value As String)
            Me.TabBackup = Value
        End Set
    End Property

    Public Property p_TabCambioUsuarios() As String
        Get
            Return Me.TabCambioUsuarios
        End Get
        Set(ByVal Value As String)
            Me.TabCambioUsuarios = Value
        End Set
    End Property

    Public Property p_TabSincro() As String
        Get
            Return Me.TabSincro
        End Get
        Set(ByVal Value As String)
            Me.TabSincro = Value
        End Set
    End Property

    Public Property p_TabMenuPacientes() As String
        Get
            Return Me.TabMenuPacientes
        End Get
        Set(ByVal Value As String)
            Me.TabMenuPacientes = Value
        End Set
    End Property

    Public Property p_TabMenuDoctores() As String
        Get
            Return Me.TabMenuDoctores
        End Get
        Set(ByVal Value As String)
            Me.TabMenuDoctores = Value
        End Set
    End Property

    Public Property p_TabMenuUsuarios() As String
        Get
            Return Me.TabMenuUsuarios
        End Get
        Set(ByVal Value As String)
            Me.TabMenuUsuarios = Value
        End Set
    End Property

    Public Property p_TabMenuEntidades() As String
        Get
            Return Me.TabMenuEntidades
        End Get
        Set(ByVal Value As String)
            Me.TabMenuEntidades = Value
        End Set
    End Property

    Public Property p_TabMenuInformes() As String
        Get
            Return Me.TabMenuInformes
        End Get
        Set(ByVal Value As String)
            Me.TabMenuInformes = Value
        End Set
    End Property

    Public Property p_TabMenuAdmon() As String
        Get
            Return Me.TabMenuAdmon
        End Get
        Set(ByVal Value As String)
            Me.TabMenuAdmon = Value
        End Set
    End Property

    Public Property p_TabMenuCitas() As String
        Get
            Return Me.TabMenuCitas
        End Get
        Set(ByVal Value As String)
            Me.TabMenuCitas = Value
        End Set
    End Property

    Public Property p_TabMenuContab() As String
        Get
            Return Me.TabMenuContab
        End Get
        Set(ByVal Value As String)
            Me.TabMenuContab = Value
        End Set
    End Property

    Public Property p_TabMenuVarios() As String
        Get
            Return Me.TabMenuVarios
        End Get
        Set(ByVal Value As String)
            Me.TabMenuVarios = Value
        End Set
    End Property


    Public Property p_TabSchedulerSup() As String
        Get
            Return Me.TabSchedulerSup
        End Get
        Set(ByVal Value As String)
            Me.TabSchedulerSup = Value
        End Set
    End Property

    Public Property p_TabScheduler() As String
        Get
            Return Me.TabScheduler
        End Get
        Set(ByVal Value As String)
            Me.TabScheduler = Value
        End Set
    End Property

    Public Property p_TabCitas() As String
        Get
            Return Me.TabCitas
        End Get
        Set(ByVal Value As String)
            Me.TabCitas = Value
        End Set
    End Property

    Public Property p_TabFicha() As String
        Get
            Return Me.TabFicha
        End Get
        Set(ByVal Value As String)
            Me.TabFicha = Value
        End Set
    End Property

    Public Property p_TabPacientes() As String
        Get
            Return Me.TabPacientes
        End Get
        Set(ByVal Value As String)
            Me.TabPacientes = Value
        End Set
    End Property

    Public Property p_TabDoctores() As String
        Get
            Return Me.TabDoctores
        End Get
        Set(ByVal Value As String)
            Me.TabDoctores = Value
        End Set
    End Property

    Public Property p_TabUsuarios() As String
        Get
            Return Me.TabUsuarios
        End Get
        Set(ByVal Value As String)
            Me.TabUsuarios = Value
        End Set
    End Property

    Public Property p_TabEntidades() As String
        Get
            Return Me.TabEntidades
        End Get
        Set(ByVal Value As String)
            Me.TabEntidades = Value
        End Set
    End Property

    Public Property p_TabHC() As String
        Get
            Return Me.TabHC
        End Get
        Set(ByVal Value As String)
            Me.TabHC = Value
        End Set
    End Property

    Public Property p_TabProcdiario() As String
        Get
            Return Me.TabProcdiario
        End Get
        Set(ByVal Value As String)
            Me.TabProcdiario = Value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.perfilesaccceso WHERE Idperfil = " & Me.Idperfil & ""
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

            CLASE_GENERAL.sql = " INSERT INTO orthosoft.perfilesaccceso (Idperfil, nom_perf, TabFunciones, TabBackup, TabCambioUsuarios, TabSincro, TabMenuPacientes, TabMenuDoctores, " _
            & "TabMenuUsuarios, TabMenuEntidades, TabMenuInformes, TabMenuAdmon, TabMenuCitas, TabMenuContab, TabMenuVarios, TabSchedulerSup, TabScheduler, TabCitas, TabFicha, TabPacientes, " _
            & "TabDoctores, TabUsuarios, TabEntidades, TabHC, TabProcdiario) VALUES (" & Me.Idperfil & ", '" & Me.nom_perf & "', '" & Me.TabFunciones & "', '" & Me.TabBackup & "', '" & Me.TabCambioUsuarios & "', '" & Me.TabSincro & "', '" & Me.TabMenuPacientes & "', '" & Me.TabMenuDoctores & "', " _
            & "'" & Me.TabMenuUsuarios & "', '" & Me.TabMenuEntidades & "', '" & Me.TabMenuInformes & "', '" & Me.TabMenuAdmon & "', '" & Me.TabMenuCitas & "', '" & Me.TabMenuContab & "', '" & Me.TabMenuVarios & "', '" & Me.TabSchedulerSup & "', '" & Me.TabScheduler & "', '" & Me.TabCitas & "', '" & Me.TabFicha & "', " _
            & "'" & Me.TabPacientes & "', '" & Me.TabDoctores & "', '" & Me.TabUsuarios & "', '" & Me.TabEntidades & "', '" & Me.TabHC & "', '" & Me.TabProcdiario & "')"


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

            CLASE_GENERAL.sql = " UPDATE orthosoft.perfilesaccceso SET nom_perf = '" & Me.nom_perf & "' , TabFunciones = '" & Me.TabFunciones & "' , TabBackup = '" & Me.TabBackup & "' , TabCambioUsuarios = '" & Me.TabCambioUsuarios & "' , " _
            & "TabSincro = '" & Me.TabSincro & "' , TabMenuPacientes = '" & Me.TabMenuPacientes & "' , TabMenuDoctores = '" & Me.TabMenuDoctores & "' , TabMenuUsuarios = '" & Me.TabMenuUsuarios & "' , TabMenuEntidades = '" & Me.TabMenuEntidades & "' , " _
            & "TabMenuInformes = '" & Me.TabMenuInformes & "' , TabMenuAdmon = '" & Me.TabMenuAdmon & "' , TabMenuCitas = '" & Me.TabMenuCitas & "' , TabMenuContab = '" & Me.TabMenuContab & "', TabMenuVarios = '" & Me.TabMenuVarios & "' , TabSchedulerSup = '" & Me.TabSchedulerSup & "' , " _
            & "TabScheduler = '" & Me.TabScheduler & "' , TabCitas = '" & Me.TabCitas & "' , TabFicha = '" & Me.TabFicha & "' , TabPacientes = '" & Me.TabPacientes & "' , TabDoctores = '" & Me.TabDoctores & "' , TabUsuarios = '" & Me.TabUsuarios & "' , TabEntidades = '" & Me.TabEntidades & "', TabHC = '" & Me.TabHC & "', TabProcdiario = '" & Me.TabProcdiario & "' " _
            & "WHERE Idperfil = '" & Me.Idperfil & "'"

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

                    CLASE_GENERAL.sql = "SELECT Idperfil, nom_perf, TabFunciones, TabBackup, TabCambioUsuarios, TabSincro, TabMenuPacientes, TabMenuDoctores, TabMenuUsuarios, " _
                    & "TabMenuEntidades, TabMenuInformes, TabMenuAdmon, TabMenuCitas, TabMenuContab, TabMenuVarios, TabSchedulerSup, TabScheduler, TabCitas, TabFicha, TabPacientes, " _
                    & "TabDoctores, TabUsuarios, TabEntidades, TabHC, TabProcdiario FROM Orthosoft.perfilesaccceso " _
                    & "WHERE Idperfil = " & Me.Idperfil & ""


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()


                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdperfil = CLASE_GENERAL.xdr("Idperfil")
                        xnom_perf = CLASE_GENERAL.xdr("nom_perf")
                        xTabFunciones = CLASE_GENERAL.xdr("TabFunciones")
                        xTabBackup = CLASE_GENERAL.xdr("TabBackup")
                        xTabCambioUsuarios = CLASE_GENERAL.xdr("TabCambioUsuarios")
                        xTabSincro = CLASE_GENERAL.xdr("TabSincro")
                        xTabMenuPacientes = CLASE_GENERAL.xdr("TabMenuPacientes")
                        xTabMenuDoctores = CLASE_GENERAL.xdr("TabMenuDoctores")
                        xTabMenuUsuarios = CLASE_GENERAL.xdr("TabMenuUsuarios")
                        xTabMenuEntidades = CLASE_GENERAL.xdr("TabMenuEntidades")
                        xTabMenuInformes = CLASE_GENERAL.xdr("TabMenuInformes")
                        xTabMenuAdmon = CLASE_GENERAL.xdr("TabMenuAdmon")
                        xTabMenuCitas = CLASE_GENERAL.xdr("TabMenuCitas")
                        xTabMenuContab = CLASE_GENERAL.xdr("TabMenuContab")
                        xTabMenuVarios = CLASE_GENERAL.xdr("TabMenuVarios")
                        xTabSchedulerSup = CLASE_GENERAL.xdr("TabSchedulerSup")
                        xTabScheduler = CLASE_GENERAL.xdr("TabScheduler")
                        xTabCitas = CLASE_GENERAL.xdr("TabCitas")
                        xTabFicha = CLASE_GENERAL.xdr("TabFicha")
                        xTabPacientes = CLASE_GENERAL.xdr("TabPacientes")
                        xTabDoctores = CLASE_GENERAL.xdr("TabDoctores")
                        xTabUsuarios = CLASE_GENERAL.xdr("TabUsuarios")
                        xTabEntidades = CLASE_GENERAL.xdr("TabEntidades")
                        xTabHC = CLASE_GENERAL.xdr("TabHC")
                        xTabProcdiario = CLASE_GENERAL.xdr("TabProcdiario")

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
