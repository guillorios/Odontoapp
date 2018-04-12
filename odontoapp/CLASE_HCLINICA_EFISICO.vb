Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA_EFISICO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xtensionart_hef As String
    Public Shared xpulso_hef As String
    Public Shared xfr_hef As String
    Public Shared xpiel_hef As String
    Public Shared xamigdalas_hef As String
    Public Shared xnot_linf_hef As String
    Public Shared xpisoboca_hef As String
    Public Shared xlabios__hef As String
    Public Shared xpaladar_hef As String
    Public Shared xcarrillos__hef As String
    Public Shared xglsalivares__hef As String
    Public Shared xmucosa_hef As String
    Public Shared xfrenillos_hef As String
    Public Shared xotros_hef As String
    Public Shared xalarmas_hef As String
    Public Shared xnotas_hef As String
    Public Shared xtipofacial_hef As String
    Public Shared ximpCabello_hef As String
    Public Shared xsimetriav_hef As String
    Public Shared xsimetriah_hef As String
    Public Shared xcejas_hef As String
    Public Shared xesclera_hef As String
    Public Shared xintercantal_hef As String
    Public Shared xdorsonariz_hef As String
    Public Shared xalasnariz_hef As String
    Public Shared xpuntanariz_hef As String
    Public Shared xsimcomisur_hef As String
    Public Shared xselladolabial_hef As String
    Public Shared xinscis_hef As String
    Public Shared xmm_hef As String
    Public Shared xgrosorlabial_hef As String
    Public Shared xsonrisasimetria_hef As String
    Public Shared xsonrisaencia_hef As String
    Public Shared xsonrisadientesinf_hef As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private tensionart_hef As String
    Private pulso_hef As String
    Private fr_hef As String
    Private piel_hef As String
    Private amigdalas_hef As String
    Private not_linf_hef As String
    Private pisoboca_hef As String
    Private labios__hef As String
    Private paladar_hef As String
    Private carrillos__hef As String
    Private glsalivares__hef As String
    Private mucosa_hef As String
    Private frenillos_hef As String
    Private otros_hef As String
    Private alarmas_hef As String
    Private notas_hef As String
    Private tipofacial_hef As String
    Private impCabello_hef As String
    Private simetriav_hef As String
    Private simetriah_hef As String
    Private cejas_hef As String
    Private esclera_hef As String
    Private intercantal_hef As String
    Private dorsonariz_hef As String
    Private alasnariz_hef As String
    Private puntanariz_hef As String
    Private simcomisur_hef As String
    Private selladolabial_hef As String
    Private inscis_hef As String
    Private mm_hef As String
    Private grosorlabial_hef As String
    Private sonrisasimetria_hef As String
    Private sonrisaencia_hef As String
    Private sonrisadientesinf_hef As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0
        Me.tensionart_hef = ""
        Me.pulso_hef = ""
        Me.fr_hef = ""
        Me.piel_hef = ""
        Me.amigdalas_hef = ""
        Me.not_linf_hef = ""
        Me.pisoboca_hef = ""
        Me.labios__hef = ""
        Me.paladar_hef = ""
        Me.carrillos__hef = ""
        Me.glsalivares__hef = ""
        Me.mucosa_hef = ""
        Me.frenillos_hef = ""
        Me.otros_hef = ""
        Me.alarmas_hef = ""
        Me.notas_hef = ""
        Me.tipofacial_hef = ""
        Me.impCabello_hef = ""
        Me.simetriav_hef = ""
        Me.simetriah_hef = ""
        Me.cejas_hef = ""
        Me.esclera_hef = ""
        Me.intercantal_hef = ""
        Me.dorsonariz_hef = ""
        Me.alasnariz_hef = ""
        Me.puntanariz_hef = ""
        Me.simcomisur_hef = ""
        Me.selladolabial_hef = ""
        Me.Inscis_hef = ""
        Me.mm_hef = ""
        Me.grosorlabial_hef = ""
        Me.sonrisasimetria_hef = ""
        Me.sonrisaencia_hef = ""
        Me.sonrisadientesinf_hef = ""
        
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

    Public Property p_tensionart_hef() As String
        Get
            Return Me.tensionart_hef
        End Get
        Set(ByVal Value As String)
            Me.tensionart_hef = Value
        End Set
    End Property

    Public Property p_pulso_hef() As String
        Get
            Return Me.pulso_hef
        End Get
        Set(ByVal Value As String)
            Me.pulso_hef = Value
        End Set
    End Property

    Public Property p_fr_hef() As String
        Get
            Return Me.fr_hef
        End Get
        Set(ByVal Value As String)
            Me.fr_hef = Value
        End Set
    End Property

    Public Property p_amigdalas_hef() As String
        Get
            Return Me.amigdalas_hef
        End Get
        Set(ByVal Value As String)
            Me.amigdalas_hef = Value
        End Set
    End Property

    Public Property p_piel_hef() As String
        Get
            Return Me.piel_hef
        End Get
        Set(ByVal Value As String)
            Me.piel_hef = Value
        End Set
    End Property

    Public Property p_not_linf_hef() As String
        Get
            Return Me.not_linf_hef
        End Get
        Set(ByVal Value As String)
            Me.not_linf_hef = Value
        End Set
    End Property

    Public Property p_pisoboca_hef() As String
        Get
            Return Me.pisoboca_hef
        End Get
        Set(ByVal Value As String)
            Me.pisoboca_hef = Value
        End Set
    End Property

    Public Property p_labios__hef() As String
        Get
            Return Me.labios__hef
        End Get
        Set(ByVal Value As String)
            Me.labios__hef = Value
        End Set
    End Property

    Public Property p_paladar_hef() As String
        Get
            Return Me.paladar_hef
        End Get
        Set(ByVal Value As String)
            Me.paladar_hef = Value
        End Set
    End Property

    Public Property p_carrillos__hef() As String
        Get
            Return Me.carrillos__hef
        End Get
        Set(ByVal Value As String)
            Me.carrillos__hef = Value
        End Set
    End Property

    Public Property p_glsalivares__hef() As String
        Get
            Return Me.glsalivares__hef
        End Get
        Set(ByVal Value As String)
            Me.glsalivares__hef = Value
        End Set
    End Property

    Public Property p_mucosa_hef() As String
        Get
            Return Me.mucosa_hef
        End Get
        Set(ByVal Value As String)
            Me.mucosa_hef = Value
        End Set
    End Property

    Public Property p_frenillos_hef() As String
        Get
            Return Me.frenillos_hef
        End Get
        Set(ByVal Value As String)
            Me.frenillos_hef = Value
        End Set
    End Property

    Public Property p_otros_hef() As String
        Get
            Return Me.otros_hef
        End Get
        Set(ByVal Value As String)
            Me.otros_hef = Value
        End Set
    End Property

    Public Property p_alarmas_hef() As String
        Get
            Return Me.alarmas_hef
        End Get
        Set(ByVal Value As String)
            Me.alarmas_hef = Value
        End Set
    End Property

    Public Property p_notas_hef() As String
        Get
            Return Me.notas_hef
        End Get
        Set(ByVal Value As String)
            Me.notas_hef = Value
        End Set
    End Property

    Public Property p_tipofacial_hef() As String
        Get
            Return Me.tipofacial_hef
        End Get
        Set(ByVal Value As String)
            Me.tipofacial_hef = Value
        End Set
    End Property

    Public Property p_impCabello_hef() As String
        Get
            Return Me.impCabello_hef
        End Get
        Set(ByVal Value As String)
            Me.impCabello_hef = Value
        End Set
    End Property

    Public Property p_simetriav_hef() As String
        Get
            Return Me.simetriav_hef
        End Get
        Set(ByVal Value As String)
            Me.simetriav_hef = Value
        End Set
    End Property

    Public Property p_simetriah_hef() As String
        Get
            Return Me.simetriah_hef
        End Get
        Set(ByVal Value As String)
            Me.simetriah_hef = Value
        End Set
    End Property

    Public Property p_cejas_hef() As String
        Get
            Return Me.cejas_hef
        End Get
        Set(ByVal Value As String)
            Me.cejas_hef = Value
        End Set
    End Property

    Public Property p_esclera_hef() As String
        Get
            Return Me.esclera_hef
        End Get
        Set(ByVal Value As String)
            Me.esclera_hef = Value
        End Set
    End Property

    Public Property p_intercantal_hef() As String
        Get
            Return Me.intercantal_hef
        End Get
        Set(ByVal Value As String)
            Me.intercantal_hef = Value
        End Set
    End Property

    Public Property p_dorsonariz_hef() As String
        Get
            Return Me.dorsonariz_hef
        End Get
        Set(ByVal Value As String)
            Me.dorsonariz_hef = Value
        End Set
    End Property

    Public Property p_alasnariz_hef() As String
        Get
            Return Me.alasnariz_hef
        End Get
        Set(ByVal Value As String)
            Me.alasnariz_hef = Value
        End Set
    End Property

    Public Property p_puntanariz_hef() As String
        Get
            Return Me.puntanariz_hef
        End Get
        Set(ByVal Value As String)
            Me.puntanariz_hef = Value
        End Set
    End Property

    Public Property p_simcomisur_hef() As String
        Get
            Return Me.simcomisur_hef
        End Get
        Set(ByVal Value As String)
            Me.simcomisur_hef = Value
        End Set
    End Property

    Public Property p_selladolabial_hef() As String
        Get
            Return Me.selladolabial_hef
        End Get
        Set(ByVal Value As String)
            Me.selladolabial_hef = Value
        End Set
    End Property

    Public Property p_Inscis_hef() As String
        Get
            Return Me.Inscis_hef
        End Get
        Set(ByVal Value As String)
            Me.Inscis_hef = Value
        End Set
    End Property

    Public Property p_mm_hef() As String
        Get
            Return Me.mm_hef
        End Get
        Set(ByVal Value As String)
            Me.mm_hef = Value
        End Set
    End Property

    Public Property p_grosorlabial_hef() As String
        Get
            Return Me.grosorlabial_hef
        End Get
        Set(ByVal Value As String)
            Me.grosorlabial_hef = Value
        End Set
    End Property

    Public Property p_sonrisasimetria_hef() As String
        Get
            Return Me.sonrisasimetria_hef
        End Get
        Set(ByVal Value As String)
            Me.sonrisasimetria_hef = Value
        End Set
    End Property
     
    Public Property p_sonrisaencia_hef() As String
        Get
            Return Me.sonrisaencia_hef
        End Get
        Set(ByVal Value As String)
            Me.sonrisaencia_hef = Value
        End Set
    End Property

    Public Property p_sonrisadientesinf_hef() As String
        Get
            Return Me.sonrisadientesinf_hef
        End Get
        Set(ByVal Value As String)
            Me.sonrisadientesinf_hef = Value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica_efisico WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.hclinica_efisico (IdUsuario, IdTUsuario, tensionart_hef, pulso_hef, " _
            & "fr_hef, piel_hef, amigdalas_hef, not_linf_hef, pisoboca_hef, labios__hef, paladar_hef, carrillos__hef, glsalivares__hef, " _
            & "mucosa_hef, frenillos_hef, otros_hef, alarmas_hef, notas_hef, tipofacial_hef, impCabello_hef, simetriav_hef, simetriah_hef, cejas_hef, " _
            & "esclera_hef, intercantal_hef, dorsonariz_hef, alasnariz_hef, puntanariz_hef, simcomisur_hef, selladolabial_hef, Inscis_hef, " _
            & "mm_hef, grosorlabial_hef, sonrisasimetria_hef, sonrisaencia_hef, sonrisadientesinf_hef) VALUES (" & Me.IdUsuario & ", " & Me.IdTUsuario & ", " _
            & "'" & Me.tensionart_hef & "', '" & Me.pulso_hef & "', '" & Me.fr_hef & "', '" & Me.piel_hef & "', '" & Me.amigdalas_hef & "', '" & Me.not_linf_hef & "', '" & Me.pisoboca_hef & "', '" & Me.labios__hef & "', '" & Me.paladar_hef & "', " _
            & "'" & Me.carrillos__hef & "', '" & Me.glsalivares__hef & "', '" & Me.mucosa_hef & "', '" & Me.frenillos_hef & "', '" & Me.otros_hef & "', '" & Me.alarmas_hef & "', '" & Me.notas_hef & "', '" & Me.tipofacial_hef & "', '" & Me.impCabello_hef & "', " _
            & "'" & Me.simetriav_hef & "', '" & Me.simetriah_hef & "', '" & Me.cejas_hef & "', '" & Me.esclera_hef & "', '" & Me.intercantal_hef & "', '" & Me.dorsonariz_hef & "', '" & Me.alasnariz_hef & "', '" & Me.puntanariz_hef & "', " _
            & "'" & Me.simcomisur_hef & "', '" & Me.selladolabial_hef & "', '" & Me.inscis_hef & "', '" & Me.mm_hef & "', '" & Me.grosorlabial_hef & "', '" & Me.sonrisasimetria_hef & "', '" & Me.sonrisaencia_hef & "', " _
            & "'" & Me.sonrisadientesinf_hef & "')"

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


            CLASE_GENERAL.sql = " UPDATE(Orthosoft.hclinica_efisico) SET tensionart_hef = '" & Me.tensionart_hef & "', pulso_hef = '" & Me.pulso_hef & "', " _
            & "fr_hef = '" & Me.fr_hef & "', piel_hef = '" & Me.piel_hef & "', amigdalas_hef = '" & Me.amigdalas_hef & "', not_linf_hef = '" & Me.not_linf_hef & "', pisoboca_hef = '" & Me.pisoboca_hef & "', " _
            & "labios__hef = '" & Me.labios__hef & "', paladar_hef = '" & Me.paladar_hef & "', carrillos__hef = '" & Me.carrillos__hef & "', glsalivares__hef = '" & Me.glsalivares__hef & "', " _
            & "mucosa_hef = '" & Me.mucosa_hef & "', frenillos_hef = '" & Me.frenillos_hef & "', otros_hef = '" & Me.otros_hef & "', alarmas_hef = '" & Me.alarmas_hef & "', notas_hef = '" & Me.notas_hef & "', tipofacial_hef = '" & Me.tipofacial_hef & "', " _
            & "impCabello_hef = '" & Me.impCabello_hef & "' , simetriav_hef = '" & Me.simetriav_hef & "', simetriah_hef = '" & Me.simetriah_hef & "', cejas_hef = '" & Me.cejas_hef & "', " _
            & "esclera_hef = '" & Me.esclera_hef & "', intercantal_hef = '" & Me.intercantal_hef & "', dorsonariz_hef = '" & Me.dorsonariz_hef & "', alasnariz_hef = '" & Me.alasnariz_hef & "', " _
            & "puntanariz_hef = '" & Me.puntanariz_hef & "', simcomisur_hef = '" & Me.simcomisur_hef & "', selladolabial_hef = '" & Me.selladolabial_hef & "' , inscis_hef = '" & Me.inscis_hef & "' , " _
            & "mm_hef = '" & Me.mm_hef & "' , grosorlabial_hef = '" & Me.grosorlabial_hef & "' , sonrisasimetria_hef = '" & Me.sonrisasimetria_hef & "' , sonrisaencia_hef = '" & Me.sonrisaencia_hef & "' , " _
            & "sonrisadientesinf_hef = '" & Me.sonrisadientesinf_hef & "' " _
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

                    CLASE_GENERAL.sql = "SELECT IdUsuario, IdTUsuario, tensionart_hef, pulso_hef, fr_hef, piel_hef, amigdalas_hef, " _
                    & "not_linf_hef, pisoboca_hef, labios__hef, paladar_hef, carrillos__hef, glsalivares__hef, mucosa_hef, frenillos_hef, " _
                    & "otros_hef, alarmas_hef, notas_hef, tipofacial_hef, impCabello_hef, simetriav_hef, simetriah_hef, cejas_hef, esclera_hef, " _
                    & "intercantal_hef, dorsonariz_hef, alasnariz_hef, puntanariz_hef, simcomisur_hef, selladolabial_hef, inscis_hef, " _
                    & "mm_hef, grosorlabial_hef, sonrisasimetria_hef, sonrisaencia_hef, sonrisadientesinf_hef FROM Orthosoft.hclinica_efisico " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()


                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")
                        xtensionart_hef = CLASE_GENERAL.xdr("tensionart_hef")
                        xpulso_hef = CLASE_GENERAL.xdr("pulso_hef")
                        xfr_hef = CLASE_GENERAL.xdr("fr_hef")
                        xpiel_hef = CLASE_GENERAL.xdr("piel_hef")
                        xamigdalas_hef = CLASE_GENERAL.xdr("amigdalas_hef")
                        xnot_linf_hef = CLASE_GENERAL.xdr("not_linf_hef")
                        xpisoboca_hef = CLASE_GENERAL.xdr("pisoboca_hef")
                        xlabios__hef = CLASE_GENERAL.xdr("labios__hef")
                        xpaladar_hef = CLASE_GENERAL.xdr("paladar_hef")
                        xcarrillos__hef = CLASE_GENERAL.xdr("carrillos__hef")
                        xglsalivares__hef = CLASE_GENERAL.xdr("glsalivares__hef")
                        xmucosa_hef = CLASE_GENERAL.xdr("mucosa_hef")
                        xfrenillos_hef = CLASE_GENERAL.xdr("frenillos_hef")
                        xotros_hef = CLASE_GENERAL.xdr("otros_hef")
                        xalarmas_hef = CLASE_GENERAL.xdr("alarmas_hef")
                        xnotas_hef = CLASE_GENERAL.xdr("notas_hef")
                        xtipofacial_hef = CLASE_GENERAL.xdr("tipofacial_hef")
                        ximpCabello_hef = CLASE_GENERAL.xdr("impCabello_hef")
                        xsimetriav_hef = CLASE_GENERAL.xdr("simetriav_hef")
                        xsimetriah_hef = CLASE_GENERAL.xdr("simetriah_hef")
                        xcejas_hef = CLASE_GENERAL.xdr("cejas_hef")
                        xesclera_hef = CLASE_GENERAL.xdr("esclera_hef")
                        xintercantal_hef = CLASE_GENERAL.xdr("intercantal_hef")
                        xdorsonariz_hef = CLASE_GENERAL.xdr("dorsonariz_hef")
                        xalasnariz_hef = CLASE_GENERAL.xdr("alasnariz_hef")
                        xpuntanariz_hef = CLASE_GENERAL.xdr("puntanariz_hef")
                        xsimcomisur_hef = CLASE_GENERAL.xdr("simcomisur_hef")
                        xselladolabial_hef = CLASE_GENERAL.xdr("selladolabial_hef")
                        xinscis_hef = CLASE_GENERAL.xdr("inscis_hef")
                        xmm_hef = CLASE_GENERAL.xdr("mm_hef")
                        xgrosorlabial_hef = CLASE_GENERAL.xdr("grosorlabial_hef")
                        xsonrisasimetria_hef = CLASE_GENERAL.xdr("sonrisasimetria_hef")
                        xsonrisaencia_hef = CLASE_GENERAL.xdr("sonrisaencia_hef")
                        xsonrisadientesinf_hef = CLASE_GENERAL.xdr("sonrisadientesinf_hef")

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
