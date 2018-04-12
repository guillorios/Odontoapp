Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA_P3

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xfrentelineamsuper_hp3 As String
    Public Shared xfrentelineamsupermm1_hp3 As String
    Public Shared xfrentelineamsupermm2_hp3 As String
    Public Shared xfrentelineaminfer_hp3 As String
    Public Shared xfrentelineaminfermm1_hp3 As String
    Public Shared xfrentelineaminfermm2_hp3 As String
    Public Shared xfrenteoverbite_hp3 As String
    Public Shared xfrenteoverjet_hp3 As String
    Public Shared xfrentedientesausen_hp3 As String
    Public Shared xldereoverject_hp3 As String
    Public Shared xlderoverbite_hp3 As String
    Public Shared xlderrelcanina_hp3 As String
    Public Shared xlderrelmolar_hp3 As String
    Public Shared xlderdientesausen_hp3 As String
    Public Shared xlizquoverject_hp3 As String
    Public Shared xlizquoverbite_hp3 As String
    Public Shared xlizqurelcanina_hp3 As String
    Public Shared xlizqurelmolar_hp3 As String
    Public Shared xlizqudientesausen_hp3 As String
    Public Shared xarcsupforma_hp3 As String
    Public Shared xarcsupsime_hp3 As String
    Public Shared xarcsupausen_hp3 As String
    Public Shared xarcinfforma_hp3 As String
    Public Shared xarcinfsime_hp3 As String
    Public Shared xarcinfausen_hp3 As String
    Public Shared xaarticdesviacion_hp3 As String
    Public Shared xaarticdeflexion_hp3 As String
    Public Shared xaarticruidosart_hp3 As String
    Public Shared xaarticsintomat_hp3 As String
    Public Shared xdfacialtperfil_hp3 As String
    Public Shared xdfacialangconje_hp3 As String
    Public Shared xdfaciallabios_hp3 As String
    Public Shared xdfacialangnasolab_hp3 As String
    Public Shared xdesquclase_hp3 As String
    Public Shared xdesquesqu_hp3 As String
    Public Shared xdesqudimensvert_hp3 As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private frentelineamsuper_hp3 As String
    Private frentelineamsupermm1_hp3 As String
    Private frentelineamsupermm2_hp3 As String
    Private frentelineaminfer_hp3 As String
    Private frentelineaminfermm1_hp3 As String
    Private frentelineaminfermm2_hp3 As String
    Private frenteoverbite_hp3 As String
    Private frenteoverjet_hp3 As String
    Private frentedientesausen_hp3 As String
    Private ldereoverject_hp3 As String
    Private lderoverbite_hp3 As String
    Private lderrelcanina_hp3 As String
    Private lderrelmolar_hp3 As String
    Private lderdientesausen_hp3 As String
    Private lizquoverject_hp3 As String
    Private lizquoverbite_hp3 As String
    Private lizqurelcanina_hp3 As String
    Private lizqurelmolar_hp3 As String
    Private lizqudientesausen_hp3 As String
    Private arcsupforma_hp3 As String
    Private arcsupsime_hp3 As String
    Private arcsupausen_hp3 As String
    Private arcinfforma_hp3 As String
    Private arcinfsime_hp3 As String
    Private arcinfausen_hp3 As String
    Private aarticdesviacion_hp3 As String
    Private aarticdeflexion_hp3 As String
    Private aarticruidosart_hp3 As String
    Private aarticsintomat_hp3 As String
    Private dfacialtperfil_hp3 As String
    Private dfacialangconje_hp3 As String
    Private dfaciallabios_hp3 As String
    Private dfacialangnasolab_hp3 As String
    Private desquclase_hp3 As String
    Private desquesqu_hp3 As String
    Private desqudimensvert_hp3 As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0
        Me.frentelineamsuper_hp3 = ""
        Me.frentelineamsupermm1_hp3 = ""
        Me.frentelineamsupermm2_hp3 = ""
        Me.frentelineaminfer_hp3 = ""
        Me.frentelineaminfermm1_hp3 = ""
        Me.frentelineaminfermm2_hp3 = ""
        Me.frenteoverbite_hp3 = ""
        Me.frenteoverjet_hp3 = ""
        Me.frentedientesausen_hp3 = ""
        Me.ldereoverject_hp3 = ""
        Me.lderoverbite_hp3 = ""
        Me.lderrelcanina_hp3 = ""
        Me.lderrelmolar_hp3 = ""
        Me.lderdientesausen_hp3 = ""
        Me.lizquoverject_hp3 = ""
        Me.lizquoverbite_hp3 = ""
        Me.lizqurelcanina_hp3 = ""
        Me.lizqurelmolar_hp3 = ""
        Me.lizqudientesausen_hp3 = ""
        Me.arcsupforma_hp3 = ""
        Me.arcsupsime_hp3 = ""
        Me.arcsupausen_hp3 = ""
        Me.arcinfforma_hp3 = ""
        Me.arcinfsime_hp3 = ""
        Me.arcinfausen_hp3 = ""
        Me.aarticdesviacion_hp3 = ""
        Me.aarticdeflexion_hp3 = ""
        Me.aarticruidosart_hp3 = ""
        Me.aarticsintomat_hp3 = ""
        Me.dfacialtperfil_hp3 = ""
        Me.dfacialangconje_hp3 = ""
        Me.dfaciallabios_hp3 = ""
        Me.dfacialangnasolab_hp3 = ""
        Me.desquclase_hp3 = ""
        Me.desquesqu_hp3 = ""
        Me.desqudimensvert_hp3 = ""

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

    Public Property p_frentelineamsuper_hp3() As String
        Get
            Return Me.frentelineamsuper_hp3
        End Get
        Set(ByVal Value As String)
            Me.frentelineamsuper_hp3 = Value
        End Set
    End Property

    Public Property p_frentelineamsupermm1_hp3() As String
        Get
            Return Me.frentelineamsupermm1_hp3
        End Get
        Set(ByVal Value As String)
            Me.frentelineamsupermm1_hp3 = Value
        End Set
    End Property

    Public Property p_frentelineamsupermm2_hp3() As String
        Get
            Return Me.frentelineamsupermm2_hp3
        End Get
        Set(ByVal Value As String)
            Me.frentelineamsupermm2_hp3 = Value
        End Set
    End Property


    Public Property p_frentelineaminfer_hp3() As String
        Get
            Return Me.frentelineaminfer_hp3
        End Get
        Set(ByVal Value As String)
            Me.frentelineaminfer_hp3 = Value
        End Set
    End Property


    Public Property p_frentelineaminfermm1_hp3() As String
        Get
            Return Me.frentelineaminfermm1_hp3
        End Get
        Set(ByVal Value As String)
            Me.frentelineaminfermm1_hp3 = Value
        End Set
    End Property

    Public Property p_frentelineaminfermm2_hp3() As String
        Get
            Return Me.frentelineaminfermm2_hp3
        End Get
        Set(ByVal Value As String)
            Me.frentelineaminfermm2_hp3 = Value
        End Set
    End Property

    Public Property p_frenteoverbite_hp3() As String
        Get
            Return Me.frenteoverbite_hp3
        End Get
        Set(ByVal Value As String)
            Me.frenteoverbite_hp3 = Value
        End Set
    End Property

    Public Property p_frenteoverjet_hp3() As String
        Get
            Return Me.frenteoverjet_hp3
        End Get
        Set(ByVal Value As String)
            Me.frenteoverjet_hp3 = Value
        End Set
    End Property

    Public Property p_frentedientesausen_hp3() As String
        Get
            Return Me.frentedientesausen_hp3
        End Get
        Set(ByVal Value As String)
            Me.frentedientesausen_hp3 = Value
        End Set
    End Property

    Public Property p_ldereoverject_hp3() As String
        Get
            Return Me.ldereoverject_hp3
        End Get
        Set(ByVal Value As String)
            Me.ldereoverject_hp3 = Value
        End Set
    End Property

    Public Property p_lderoverbite_hp3() As String
        Get
            Return Me.lderoverbite_hp3
        End Get
        Set(ByVal Value As String)
            Me.lderoverbite_hp3 = Value
        End Set
    End Property

    Public Property p_lderrelcanina_hp3() As String
        Get
            Return Me.lderrelcanina_hp3
        End Get
        Set(ByVal Value As String)
            Me.lderrelcanina_hp3 = Value
        End Set
    End Property

    Public Property p_lderrelmolar_hp3() As String
        Get
            Return Me.lderrelmolar_hp3
        End Get
        Set(ByVal Value As String)
            Me.lderrelmolar_hp3 = Value
        End Set
    End Property

    Public Property p_lderdientesausen_hp3() As String
        Get
            Return Me.lderdientesausen_hp3
        End Get
        Set(ByVal Value As String)
            Me.lderdientesausen_hp3 = Value
        End Set
    End Property

    Public Property p_lizquoverject_hp3() As String
        Get
            Return Me.lizquoverject_hp3
        End Get
        Set(ByVal Value As String)
            Me.lizquoverject_hp3 = Value
        End Set
    End Property

    Public Property p_lizquoverbite_hp3() As String
        Get
            Return Me.lizquoverbite_hp3
        End Get
        Set(ByVal Value As String)
            Me.lizquoverbite_hp3 = Value
        End Set
    End Property

    Public Property p_lizqurelcanina_hp3() As String
        Get
            Return Me.lizqurelcanina_hp3
        End Get
        Set(ByVal Value As String)
            Me.lizqurelcanina_hp3 = Value
        End Set
    End Property

    Public Property p_lizqurelmolar_hp3() As String
        Get
            Return Me.lizqurelmolar_hp3
        End Get
        Set(ByVal Value As String)
            Me.lizqurelmolar_hp3 = Value
        End Set
    End Property

    Public Property p_lizqudientesausen_hp3() As String
        Get
            Return Me.lizqudientesausen_hp3
        End Get
        Set(ByVal Value As String)
            Me.lizqudientesausen_hp3 = Value
        End Set
    End Property

    Public Property p_arcsupforma_hp3() As String
        Get
            Return Me.arcsupforma_hp3
        End Get
        Set(ByVal Value As String)
            Me.arcsupforma_hp3 = Value
        End Set
    End Property

    Public Property p_arcsupsime_hp3() As String
        Get
            Return Me.arcsupsime_hp3
        End Get
        Set(ByVal Value As String)
            Me.arcsupsime_hp3 = Value
        End Set
    End Property

    Public Property p_arcsupausen_hp3() As String
        Get
            Return Me.arcsupausen_hp3
        End Get
        Set(ByVal Value As String)
            Me.arcsupausen_hp3 = Value
        End Set
    End Property

    Public Property p_arcinfforma_hp3() As String
        Get
            Return Me.arcinfforma_hp3
        End Get
        Set(ByVal Value As String)
            Me.arcinfforma_hp3 = Value
        End Set
    End Property

    Public Property p_arcinfsime_hp3() As String
        Get
            Return Me.arcinfsime_hp3
        End Get
        Set(ByVal Value As String)
            Me.arcinfsime_hp3 = Value
        End Set
    End Property

    Public Property p_arcinfausen_hp3() As String
        Get
            Return Me.arcinfausen_hp3
        End Get
        Set(ByVal Value As String)
            Me.arcinfausen_hp3 = Value
        End Set
    End Property

    Public Property p_aarticdesviacion_hp3() As String
        Get
            Return Me.aarticdesviacion_hp3
        End Get
        Set(ByVal Value As String)
            Me.aarticdesviacion_hp3 = Value
        End Set
    End Property

    Public Property p_aarticdeflexion_hp3() As String
        Get
            Return Me.aarticdeflexion_hp3
        End Get
        Set(ByVal Value As String)
            Me.aarticdeflexion_hp3 = Value
        End Set
    End Property

    Public Property p_aarticruidosart_hp3() As String
        Get
            Return Me.aarticruidosart_hp3
        End Get
        Set(ByVal Value As String)
            Me.aarticruidosart_hp3 = Value
        End Set
    End Property

    Public Property p_aarticsintomat_hp3() As String
        Get
            Return Me.aarticsintomat_hp3
        End Get
        Set(ByVal Value As String)
            Me.aarticsintomat_hp3 = Value
        End Set
    End Property

    Public Property p_dfacialtperfil_hp3() As String
        Get
            Return Me.dfacialtperfil_hp3
        End Get
        Set(ByVal Value As String)
            Me.dfacialtperfil_hp3 = Value
        End Set
    End Property

    Public Property p_dfacialangconje_hp3() As String
        Get
            Return Me.dfacialangconje_hp3
        End Get
        Set(ByVal Value As String)
            Me.dfacialangconje_hp3 = Value
        End Set
    End Property

    Public Property p_dfaciallabios_hp3() As String
        Get
            Return Me.dfaciallabios_hp3
        End Get
        Set(ByVal Value As String)
            Me.dfaciallabios_hp3 = Value
        End Set
    End Property
       
    Public Property p_dfacialangnasolab_hp3() As String
        Get
            Return Me.dfacialangnasolab_hp3
        End Get
        Set(ByVal Value As String)
            Me.dfacialangnasolab_hp3 = Value
        End Set
    End Property

    Public Property p_desquclase_hp3() As String
        Get
            Return Me.desquclase_hp3
        End Get
        Set(ByVal Value As String)
            Me.desquclase_hp3 = Value
        End Set
    End Property

    Public Property p_desquesqu_hp3() As String
        Get
            Return Me.desquesqu_hp3
        End Get
        Set(ByVal Value As String)
            Me.desquesqu_hp3 = Value
        End Set
    End Property

    Public Property p_desqudimensvert_hp3() As String
        Get
            Return Me.desqudimensvert_hp3
        End Get
        Set(ByVal Value As String)
            Me.desqudimensvert_hp3 = Value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica_p3 WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.hclinica_p3 (IdUsuario, IdTUsuario, frentelineamsuper_hp3, frentelineamsupermm1_hp3, frentelineamsupermm2_hp3, frentelineaminfer_hp3, frentelineaminfermm1_hp3, " _
            & "frentelineaminfermm2_hp3, frenteoverbite_hp3, frenteoverjet_hp3, frentedientesausen_hp3, ldereoverject_hp3, lderoverbite_hp3, lderrelcanina_hp3, lderrelmolar_hp3, lderdientesausen_hp3, lizquoverject_hp3, " _
            & "lizquoverbite_hp3, lizqurelcanina_hp3, lizqurelmolar_hp3, lizqudientesausen_hp3, arcsupforma_hp3, arcsupsime_hp3, arcsupausen_hp3, arcinfforma_hp3, arcinfsime_hp3, arcinfausen_hp3, aarticdesviacion_hp3, " _
            & "aarticdeflexion_hp3, aarticruidosart_hp3, aarticsintomat_hp3, dfacialtperfil_hp3, dfacialangconje_hp3, dfaciallabios_hp3, dfacialangnasolab_hp3, desquclase_hp3, desquesqu_hp3, desqudimensvert_hp3) VALUES (" & Me.IdUsuario & ", " _
            & "" & Me.IdTUsuario & ", '" & Me.frentelineamsuper_hp3 & "', '" & Me.frentelineamsupermm1_hp3 & "', '" & Me.frentelineamsupermm2_hp3 & "', '" & Me.frentelineaminfer_hp3 & "', '" & Me.frentelineaminfermm1_hp3 & "', '" & Me.frentelineaminfermm2_hp3 & "', '" & Me.frenteoverbite_hp3 & "', '" & Me.frenteoverjet_hp3 & "', " _
            & "'" & Me.frentedientesausen_hp3 & "', '" & Me.ldereoverject_hp3 & "', '" & Me.lderoverbite_hp3 & "', '" & Me.lderrelcanina_hp3 & "', '" & Me.lderrelmolar_hp3 & "', '" & Me.lderdientesausen_hp3 & "', '" & Me.lizquoverject_hp3 & "', '" & Me.lizquoverbite_hp3 & "', '" & Me.lizqurelcanina_hp3 & "', '" & Me.lizqurelmolar_hp3 & "', " _
            & "'" & Me.lizqudientesausen_hp3 & "', '" & Me.arcsupforma_hp3 & "', '" & Me.arcsupsime_hp3 & "', '" & Me.arcsupausen_hp3 & "', '" & Me.arcinfforma_hp3 & "', ' " & Me.arcinfsime_hp3 & "', '" & Me.arcinfausen_hp3 & "', '" & Me.aarticdesviacion_hp3 & "', '" & Me.aarticdeflexion_hp3 & "', '" & Me.aarticruidosart_hp3 & "', '" & Me.aarticsintomat_hp3 & "', " _
            & "'" & Me.dfacialtperfil_hp3 & "', '" & Me.dfacialangconje_hp3 & "', '" & Me.dfaciallabios_hp3 & "', '" & Me.dfacialangnasolab_hp3 & "', '" & Me.desquclase_hp3 & "', '" & Me.desquesqu_hp3 & "', '" & Me.desqudimensvert_hp3 & "')"

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

            CLASE_GENERAL.sql = "UPDATE(Orthosoft.hclinica_p3) SET frentelineamsuper_hp3 = '" & Me.frentelineamsuper_hp3 & "' , frentelineamsupermm1_hp3 = '" & Me.frentelineamsupermm1_hp3 & "' , " _
            & "frentelineamsupermm2_hp3 = '" & Me.frentelineamsupermm2_hp3 & "' , frentelineaminfer_hp3 = '" & Me.frentelineaminfer_hp3 & "' , frentelineaminfermm1_hp3 = '" & Me.frentelineaminfermm1_hp3 & "' , frentelineaminfermm2_hp3 = '" & Me.frentelineaminfermm2_hp3 & "' , " _
            & "frenteoverbite_hp3 = '" & Me.frenteoverbite_hp3 & "' , frenteoverjet_hp3 = '" & Me.frenteoverjet_hp3 & "' , frentedientesausen_hp3 = '" & Me.frentedientesausen_hp3 & "' , ldereoverject_hp3 = '" & Me.ldereoverject_hp3 & "' , lderoverbite_hp3 = '" & Me.lderoverbite_hp3 & "' , " _
            & "lderrelcanina_hp3 = '" & Me.lderrelcanina_hp3 & "' , lderrelmolar_hp3 = '" & Me.lderrelmolar_hp3 & "' , lderdientesausen_hp3 = '" & Me.lderdientesausen_hp3 & "' , lizquoverject_hp3 = '" & Me.lizquoverject_hp3 & "' , lizquoverbite_hp3 = '" & Me.lizquoverbite_hp3 & "' , " _
            & "lizqurelcanina_hp3 = '" & Me.lizqurelcanina_hp3 & "' , lizqurelmolar_hp3 = '" & Me.lizqurelmolar_hp3 & "' , lizqudientesausen_hp3 = '" & Me.lizqudientesausen_hp3 & "' , arcsupforma_hp3 = '" & Me.arcsupforma_hp3 & "' , arcsupsime_hp3 = '" & Me.arcsupsime_hp3 & "' , " _
            & "arcsupausen_hp3 = '" & Me.arcsupausen_hp3 & "' , arcinfforma_hp3 = '" & Me.arcinfforma_hp3 & "' , arcinfsime_hp3 = '" & Me.arcinfsime_hp3 & "' , arcinfausen_hp3 = '" & Me.arcinfausen_hp3 & "' , aarticdesviacion_hp3 = '" & Me.aarticdesviacion_hp3 & "' , " _
            & "aarticdeflexion_hp3 = '" & Me.aarticdeflexion_hp3 & "' , aarticruidosart_hp3 = '" & Me.aarticruidosart_hp3 & "' , aarticsintomat_hp3 = '" & Me.aarticsintomat_hp3 & "' , dfacialtperfil_hp3 = '" & Me.dfacialtperfil_hp3 & "' , dfacialangconje_hp3 = '" & Me.dfacialangconje_hp3 & "' , " _
            & "dfaciallabios_hp3 = '" & Me.dfaciallabios_hp3 & "' , dfacialangnasolab_hp3 = '" & Me.dfacialangnasolab_hp3 & "' , desquclase_hp3 = '" & Me.desquclase_hp3 & "' , desquesqu_hp3 = '" & Me.desquesqu_hp3 & "' , desqudimensvert_hp3 = '" & Me.desqudimensvert_hp3 & "' " _
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

                    CLASE_GENERAL.sql = "SELECT IdUsuario, IdTUsuario, frentelineamsuper_hp3, frentelineamsupermm1_hp3, frentelineamsupermm2_hp3, frentelineaminfer_hp3, frentelineaminfermm1_hp3, frentelineaminfermm2_hp3, " _
                    & "frenteoverbite_hp3, frenteoverjet_hp3, frentedientesausen_hp3, ldereoverject_hp3, lderoverbite_hp3, lderrelcanina_hp3, lderrelmolar_hp3, lderdientesausen_hp3, lizquoverject_hp3, lizquoverbite_hp3, " _
                    & "lizqurelcanina_hp3, lizqurelmolar_hp3, lizqudientesausen_hp3, arcsupforma_hp3, arcsupsime_hp3, arcsupausen_hp3, arcinfforma_hp3, arcinfsime_hp3, arcinfausen_hp3, aarticdesviacion_hp3, aarticdeflexion_hp3, " _
                    & "aarticruidosart_hp3, aarticsintomat_hp3, dfacialtperfil_hp3, dfacialangconje_hp3, dfaciallabios_hp3, dfacialangnasolab_hp3, desquclase_hp3, desquesqu_hp3, desqudimensvert_hp3 FROM Orthosoft.hclinica_p3 " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()


                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")
                        xfrentelineamsuper_hp3 = CLASE_GENERAL.xdr("frentelineamsuper_hp3")
                        xfrentelineamsupermm1_hp3 = CLASE_GENERAL.xdr("frentelineamsupermm1_hp3")
                        xfrentelineamsupermm2_hp3 = CLASE_GENERAL.xdr("frentelineamsupermm2_hp3")
                        xfrentelineaminfer_hp3 = CLASE_GENERAL.xdr("frentelineaminfer_hp3")
                        xfrentelineaminfermm1_hp3 = CLASE_GENERAL.xdr("frentelineaminfermm1_hp3")
                        xfrentelineaminfermm2_hp3 = CLASE_GENERAL.xdr("frentelineaminfermm2_hp3")
                        xfrenteoverbite_hp3 = CLASE_GENERAL.xdr("frenteoverbite_hp3")
                        xfrenteoverjet_hp3 = CLASE_GENERAL.xdr("frenteoverjet_hp3")
                        xfrentedientesausen_hp3 = CLASE_GENERAL.xdr("frentedientesausen_hp3")
                        xldereoverject_hp3 = CLASE_GENERAL.xdr("ldereoverject_hp3")
                        xlderoverbite_hp3 = CLASE_GENERAL.xdr("lderoverbite_hp3")
                        xlderrelcanina_hp3 = CLASE_GENERAL.xdr("lderrelcanina_hp3")
                        xlderrelmolar_hp3 = CLASE_GENERAL.xdr("lderrelmolar_hp3")
                        xlderdientesausen_hp3 = CLASE_GENERAL.xdr("lderdientesausen_hp3")
                        xlizquoverject_hp3 = CLASE_GENERAL.xdr("lizquoverject_hp3")
                        xlizquoverbite_hp3 = CLASE_GENERAL.xdr("lizquoverbite_hp3")
                        xlizqurelcanina_hp3 = CLASE_GENERAL.xdr("lizqurelcanina_hp3")
                        xlizqurelmolar_hp3 = CLASE_GENERAL.xdr("lizqurelmolar_hp3")
                        xlizqudientesausen_hp3 = CLASE_GENERAL.xdr("lizqudientesausen_hp3")
                        xarcsupforma_hp3 = CLASE_GENERAL.xdr("arcsupforma_hp3")
                        xarcsupsime_hp3 = CLASE_GENERAL.xdr("arcsupsime_hp3")
                        xarcsupausen_hp3 = CLASE_GENERAL.xdr("arcsupausen_hp3")
                        xarcinfforma_hp3 = CLASE_GENERAL.xdr("arcinfforma_hp3")
                        xarcinfsime_hp3 = CLASE_GENERAL.xdr("arcinfsime_hp3")
                        xarcinfausen_hp3 = CLASE_GENERAL.xdr("arcinfausen_hp3")
                        xaarticdesviacion_hp3 = CLASE_GENERAL.xdr("aarticdesviacion_hp3")
                        xaarticdeflexion_hp3 = CLASE_GENERAL.xdr("aarticdeflexion_hp3")
                        xaarticruidosart_hp3 = CLASE_GENERAL.xdr("aarticruidosart_hp3")
                        xaarticsintomat_hp3 = CLASE_GENERAL.xdr("aarticsintomat_hp3")
                        xdfacialtperfil_hp3 = CLASE_GENERAL.xdr("dfacialtperfil_hp3")
                        xdfacialangconje_hp3 = CLASE_GENERAL.xdr("dfacialangconje_hp3")
                        xdfaciallabios_hp3 = CLASE_GENERAL.xdr("dfaciallabios_hp3")
                        xdfacialangnasolab_hp3 = CLASE_GENERAL.xdr("dfacialangnasolab_hp3")
                        xdesquclase_hp3 = CLASE_GENERAL.xdr("desquclase_hp3")
                        xdesquesqu_hp3 = CLASE_GENERAL.xdr("desquesqu_hp3")
                        xdesqudimensvert_hp3 = CLASE_GENERAL.xdr("desqudimensvert_hp3")

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
