Imports MySql.Data.MySqlClient

Public Class CLASE_HCLINICA

    Implements CLASE_GENERAL.DML


#Region "Consultas"

    Public Shared xIdUsuario As Integer
    Public Shared xIdTUsuario As Integer
    Public Shared xmconsulta_h As String
    Public Shared xdescripcion_h As String
    Public Shared xclase_h As String
    Public Shared xduracion_h As String
    Public Shared xenfe_infancia_h As String
    Public Shared xenfe_adulto_h As String
    Public Shared xinmuniza_h As String
    Public Shared xhospitaliza_h As String
    Public Shared xtraumaticoas_h As String
    Public Shared xquirurgicos_h As String
    Public Shared xtransfusi_h As String
    Public Shared xirradia_h As String
    Public Shared xhemorrag_h As String
    Public Shared xmedica_act_h As String
    Public Shared xreaccion_al_h As String
    Public Shared xotras_drogas_h As String
    Public Shared xhabitos_h As String
    Public Shared xant_here_gener_h As String
    Public Shared xant_here_bucales_h As String
    Public Shared xrsistema_piel As String
    Public Shared xrsistema_cabeza As String
    Public Shared xrsistema_cara As String
    Public Shared xrsistema_oidos As String
    Public Shared xrsistema_ojos As String
    Public Shared xrsistema_nariz As String
    Public Shared xrsistema_senos As String
    Public Shared xrsistema_cuello As String

#End Region

#Region "Atributos"

    Private IdUsuario As Integer
    Private IdTUsuario As Integer
    Private mconsulta_h As String
    Private descripcion_h As String
    Private clase_h As String
    Private duracion_h As String
    Private enfe_infancia_h As String
    Private enfe_adulto_h As String
    Private inmuniza_h As String
    Private hospitaliza_h As String
    Private traumaticoas_h As String
    Private quirurgicos_h As String
    Private transfusi_h As String
    Private irradia_h As String
    Private hemorrag_h As String
    Private medica_act_h As String
    Private reaccion_al_h As String
    Private otras_drogas_h As String
    Private habitos_h As String
    Private ant_here_gener_h As String
    Private ant_here_bucales_h As String
    Private rsistema_piel As String
    Private rsistema_cabeza As String
    Private rsistema_cara As String
    Private rsistema_oidos As String
    Private rsistema_ojos As String
    Private rsistema_nariz As String
    Private rsistema_senos As String
    Private rsistema_cuello As String

    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.IdUsuario = 0
        Me.IdTUsuario = 0
        Me.mconsulta_h = ""
        Me.descripcion_h = ""
        Me.clase_h = ""
        Me.duracion_h = ""
        Me.enfe_infancia_h = ""
        Me.enfe_adulto_h = ""
        Me.inmuniza_h = ""
        Me.hospitaliza_h = ""
        Me.traumaticoas_h = ""
        Me.quirurgicos_h = ""
        Me.transfusi_h = ""
        Me.irradia_h = ""
        Me.hemorrag_h = ""
        Me.medica_act_h = ""
        Me.reaccion_al_h = ""
        Me.otras_drogas_h = ""
        Me.habitos_h = ""
        Me.ant_here_gener_h = ""
        Me.ant_here_bucales_h = ""
        Me.rsistema_piel = ""
        Me.rsistema_cabeza = ""
        Me.rsistema_cara = ""
        Me.rsistema_oidos = ""
        Me.rsistema_ojos = ""
        Me.rsistema_nariz = ""
        Me.rsistema_senos = ""
        Me.rsistema_cuello = ""

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

    Public Property p_mconsulta_h() As String
        Get
            Return Me.mconsulta_h
        End Get
        Set(ByVal Value As String)
            Me.mconsulta_h = Value
        End Set
    End Property

    Public Property p_descripcion_h() As String
        Get
            Return Me.descripcion_h
        End Get
        Set(ByVal Value As String)
            Me.descripcion_h = Value
        End Set
    End Property

    Public Property p_clase_h() As String
        Get
            Return Me.clase_h
        End Get
        Set(ByVal Value As String)
            Me.clase_h = Value
        End Set
    End Property

    Public Property p_duracion_h() As String
        Get
            Return Me.duracion_h
        End Get
        Set(ByVal Value As String)
            Me.duracion_h = Value
        End Set
    End Property

    Public Property p_enfe_infancia_h() As String
        Get
            Return Me.enfe_infancia_h
        End Get
        Set(ByVal Value As String)
            Me.enfe_infancia_h = Value
        End Set
    End Property

    Public Property p_enfe_adulto_h() As String
        Get
            Return Me.enfe_adulto_h
        End Get
        Set(ByVal Value As String)
            Me.enfe_adulto_h = Value
        End Set
    End Property

    Public Property p_inmuniza_h() As String
        Get
            Return Me.inmuniza_h
        End Get
        Set(ByVal Value As String)
            Me.inmuniza_h = Value
        End Set
    End Property

    Public Property p_hospitaliza_h() As String
        Get
            Return Me.hospitaliza_h
        End Get
        Set(ByVal Value As String)
            Me.hospitaliza_h = Value
        End Set
    End Property

    Public Property p_traumaticoas_h() As String
        Get
            Return Me.traumaticoas_h
        End Get
        Set(ByVal Value As String)
            Me.traumaticoas_h = Value
        End Set
    End Property

    Public Property p_quirurgicos_h() As String
        Get
            Return Me.quirurgicos_h
        End Get
        Set(ByVal Value As String)
            Me.quirurgicos_h = Value
        End Set
    End Property

    Public Property p_transfusi_h() As String
        Get
            Return Me.transfusi_h
        End Get
        Set(ByVal Value As String)
            Me.transfusi_h = Value
        End Set
    End Property

    Public Property p_irradia_h() As String
        Get
            Return Me.irradia_h
        End Get
        Set(ByVal Value As String)
            Me.irradia_h = Value
        End Set
    End Property

    Public Property p_hemorrag_h() As String
        Get
            Return Me.hemorrag_h
        End Get
        Set(ByVal Value As String)
            Me.hemorrag_h = Value
        End Set
    End Property

    Public Property p_medica_act_h() As String
        Get
            Return Me.medica_act_h
        End Get
        Set(ByVal Value As String)
            Me.medica_act_h = Value
        End Set
    End Property

    Public Property p_reaccion_al_h() As String
        Get
            Return Me.reaccion_al_h
        End Get
        Set(ByVal Value As String)
            Me.reaccion_al_h = Value
        End Set
    End Property

    Public Property p_otras_drogas_h() As String
        Get
            Return Me.otras_drogas_h
        End Get
        Set(ByVal Value As String)
            Me.otras_drogas_h = Value
        End Set
    End Property

    Public Property p_habitos_h() As String
        Get
            Return Me.habitos_h
        End Get
        Set(ByVal Value As String)
            Me.habitos_h = Value
        End Set
    End Property

    Public Property p_ant_here_gener_h() As String
        Get
            Return Me.ant_here_gener_h
        End Get
        Set(ByVal Value As String)
            Me.ant_here_gener_h = Value
        End Set
    End Property

    Public Property p_ant_here_bucales_h() As String
        Get
            Return Me.ant_here_bucales_h
        End Get
        Set(ByVal Value As String)
            Me.ant_here_bucales_h = Value
        End Set
    End Property

    Public Property p_rsistema_piel() As String
        Get
            Return Me.rsistema_piel
        End Get
        Set(ByVal Value As String)
            Me.rsistema_piel = Value
        End Set
    End Property

    Public Property p_rsistema_cabeza() As String
        Get
            Return Me.rsistema_cabeza
        End Get
        Set(ByVal Value As String)
            Me.rsistema_cabeza = Value
        End Set
    End Property

    Public Property p_rsistema_cara() As String
        Get
            Return Me.rsistema_cara
        End Get
        Set(ByVal Value As String)
            Me.rsistema_cara = Value
        End Set
    End Property

    Public Property p_rsistema_oidos() As String
        Get
            Return Me.rsistema_oidos
        End Get
        Set(ByVal Value As String)
            Me.rsistema_oidos = Value
        End Set
    End Property

    Public Property p_rsistema_ojos() As String
        Get
            Return Me.rsistema_ojos
        End Get
        Set(ByVal Value As String)
            Me.rsistema_ojos = Value
        End Set
    End Property

    Public Property p_rsistema_nariz() As String
        Get
            Return Me.rsistema_nariz
        End Get
        Set(ByVal Value As String)
            Me.rsistema_nariz = Value
        End Set
    End Property

    Public Property p_rsistema_senos() As String
        Get
            Return Me.rsistema_senos
        End Get
        Set(ByVal Value As String)
            Me.rsistema_senos = Value
        End Set
    End Property

    Public Property p_rsistema_cuello() As String
        Get
            Return Me.rsistema_cuello
        End Get
        Set(ByVal Value As String)
            Me.rsistema_cuello = Value
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

            CLASE_GENERAL.sql = "DELETE FROM orthosoft.hclinica WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & " "
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

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.hclinica (IdUsuario, IdTUsuario, mconsulta_h, descripcion_h, clase_h, duracion_h, enfe_infancia_h, enfe_adulto_h, " _
            & "inmuniza_h, hospitaliza_h, traumaticoas_h, quirurgicos_h, transfusi_h, irradia_h, hemorrag_h, medica_act_h, reaccion_al_h, otras_drogas_h, habitos_h, " _
            & "ant_here_gener_h, ant_here_bucales_h, rsistema_piel, rsistema_cabeza, rsistema_cara, rsistema_oidos, rsistema_ojos, rsistema_nariz, rsistema_senos, " _
            & "rsistema_cuello) VALUES (" & Me.IdUsuario & ", " & Me.IdTUsuario & ", '" & Me.mconsulta_h & "', '" & Me.descripcion_h & "', '" & Me.clase_h & "', '" & Me.duracion_h & "', '" & Me.enfe_infancia_h & "', '" & Me.enfe_adulto_h & "', '" & Me.inmuniza_h & "', " _
            & "'" & Me.hospitaliza_h & "', '" & Me.traumaticoas_h & "', '" & Me.quirurgicos_h & "', '" & Me.transfusi_h & "', '" & Me.irradia_h & "', '" & Me.hemorrag_h & "', '" & Me.medica_act_h & "', '" & Me.reaccion_al_h & "', '" & Me.otras_drogas_h & "', '" & Me.habitos_h & "', " _
            & "'" & Me.ant_here_gener_h & "', '" & Me.ant_here_bucales_h & "', '" & Me.rsistema_piel & "', '" & Me.rsistema_cabeza & "', '" & Me.rsistema_cara & "', '" & Me.rsistema_oidos & "', '" & Me.rsistema_ojos & "', '" & Me.rsistema_nariz & "', '" & Me.rsistema_senos & "', '" & Me.rsistema_cuello & "')"

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

            CLASE_GENERAL.sql = " UPDATE(Orthosoft.hclinica) SET mconsulta_h = '" & Me.mconsulta_h & "', " _
            & "descripcion_h = '" & Me.descripcion_h & "', clase_h = '" & Me.clase_h & "', duracion_h = '" & Me.duracion_h & "', enfe_infancia_h = '" & Me.enfe_infancia_h & "', enfe_adulto_h = '" & Me.enfe_adulto_h & "', " _
            & "inmuniza_h = '" & Me.inmuniza_h & "', hospitaliza_h = '" & Me.hospitaliza_h & "', traumaticoas_h = '" & Me.traumaticoas_h & "', quirurgicos_h = '" & Me.quirurgicos_h & "', " _
            & "transfusi_h = '" & Me.transfusi_h & "', irradia_h = '" & Me.irradia_h & "', hemorrag_h = '" & Me.hemorrag_h & "', medica_act_h = '" & Me.medica_act_h & "', reaccion_al_h = '" & Me.reaccion_al_h & "', " _
            & "otras_drogas_h = '" & Me.otras_drogas_h & "', habitos_h = '" & Me.habitos_h & "', ant_here_gener_h = '" & Me.ant_here_gener_h & "', ant_here_bucales_h = '" & Me.ant_here_bucales_h & "', " _
            & "rsistema_piel = '" & Me.rsistema_piel & "', rsistema_cabeza = '" & Me.rsistema_cabeza & "', rsistema_cara = '" & Me.rsistema_cara & "', rsistema_oidos = '" & Me.rsistema_oidos & "', " _
            & "rsistema_ojos = '" & Me.rsistema_ojos & "', rsistema_nariz = '" & Me.rsistema_nariz & "', rsistema_senos = '" & Me.rsistema_senos & "', rsistema_cuello = '" & Me.rsistema_cuello & "' " _
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

                    CLASE_GENERAL.sql = "SELECT IdUsuario, IdTUsuario, mconsulta_h, descripcion_h, clase_h, " _
                    & "duracion_h, enfe_infancia_h, enfe_adulto_h, inmuniza_h, hospitaliza_h, traumaticoas_h, " _
                    & "quirurgicos_h, transfusi_h, irradia_h, hemorrag_h, medica_act_h, reaccion_al_h, otras_drogas_h, " _
                    & "habitos_h, ant_here_gener_h, ant_here_bucales_h, rsistema_piel, rsistema_cabeza, rsistema_cara, " _
                    & "rsistema_oidos, rsistema_ojos, rsistema_nariz, rsistema_senos, rsistema_cuello FROM Orthosoft.hclinica " _
                    & "WHERE IdUsuario = " & Me.IdUsuario & " AND IdTUsuario = " & Me.IdTUsuario & ""


                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()


                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdUsuario = CLASE_GENERAL.xdr("IdUsuario")
                        xIdTUsuario = CLASE_GENERAL.xdr("IdTUsuario")
                        xmconsulta_h = CLASE_GENERAL.xdr("mconsulta_h")
                        xdescripcion_h = CLASE_GENERAL.xdr("descripcion_h")
                        xclase_h = CLASE_GENERAL.xdr("clase_h")
                        xduracion_h = CLASE_GENERAL.xdr("duracion_h")
                        xenfe_infancia_h = CLASE_GENERAL.xdr("enfe_infancia_h")
                        xenfe_adulto_h = CLASE_GENERAL.xdr("enfe_adulto_h")
                        xinmuniza_h = CLASE_GENERAL.xdr("inmuniza_h")
                        xhospitaliza_h = CLASE_GENERAL.xdr("hospitaliza_h")
                        xtraumaticoas_h = CLASE_GENERAL.xdr("traumaticoas_h")
                        xquirurgicos_h = CLASE_GENERAL.xdr("quirurgicos_h")
                        xtransfusi_h = CLASE_GENERAL.xdr("transfusi_h")
                        xirradia_h = CLASE_GENERAL.xdr("irradia_h")
                        xhemorrag_h = CLASE_GENERAL.xdr("hemorrag_h")
                        xmedica_act_h = CLASE_GENERAL.xdr("medica_act_h")
                        xreaccion_al_h = CLASE_GENERAL.xdr("reaccion_al_h")
                        xotras_drogas_h = CLASE_GENERAL.xdr("otras_drogas_h")
                        xhabitos_h = CLASE_GENERAL.xdr("habitos_h")
                        xant_here_gener_h = CLASE_GENERAL.xdr("ant_here_gener_h")
                        xant_here_bucales_h = CLASE_GENERAL.xdr("ant_here_bucales_h")
                        xrsistema_piel = CLASE_GENERAL.xdr("rsistema_piel")
                        xrsistema_cabeza = CLASE_GENERAL.xdr("rsistema_cabeza")
                        xrsistema_cara = CLASE_GENERAL.xdr("rsistema_cara")
                        xrsistema_oidos = CLASE_GENERAL.xdr("rsistema_oidos")
                        xrsistema_ojos = CLASE_GENERAL.xdr("rsistema_ojos")
                        xrsistema_nariz = CLASE_GENERAL.xdr("rsistema_nariz")
                        xrsistema_senos = CLASE_GENERAL.xdr("rsistema_senos")
                        xrsistema_cuello = CLASE_GENERAL.xdr("rsistema_cuello")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

                Case "impresion"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT consultorio.Idconsultorio, consultorio.razonsocial_cons, consultorio.nit_cons  , consultorio.direccion_cons, consultorio.ciudad_cons, consultorio.web_cons, consultorio.email_cons, consultorio.rtelegal_cons, consultorio.profesionrlegal_cons, consultorio.documento_cons, consultorio.ciudaddoc_cons, consultorio.actividad_cons, " _
                    & "consultorio.tel1_cons, consultorio.celular_cons, consultorio.icono_cons, Idpaciente, pacientes.nhclinica, pacientes.nombres_pac, pacientes.apellidos_pac, estadocivil.nom_estadocivil, pacientes.fecnac_pac, pacientes.referidopor_pac, pacientes.sexo_pac, pacientes.numdoc_pac, pacientes.dedoc_pac, pacientes.fecingreso_pac, hclinica.*, " _
                    & "entidades.nombre_ent, hclinica_efisico.*, hclinica_p2.*, hclinica_p3.*, hclinica_p4.*, ograma.observacionograma_ini, ograma.observacionograma_act, ograma.ograma_inicial, ograma.ograma_actual, ograma.oleary_inicial, ograma.oleary_actual, ograma.fecha_ograma, notas.nota, notas.fotolong " _
                    & "FROM Orthosoft.consultorio " _
                    & "INNER JOIN orthosoft.pacientes ON (consultorio.Idconsultorio = pacientes.Idconsultorio) " _
                    & "INNER JOIN orthosoft.entidades ON (pacientes.Identidad = entidades.Identidad) " _
                    & "INNER JOIN orthosoft.estadocivil ON (pacientes.estadocivil_pac = estadocivil.Idestadocivil) " _
                    & "INNER JOIN orthosoft.hclinica  ON (pacientes.Idpaciente = hclinica.IdUsuario) " _
                    & "INNER JOIN orthosoft.hclinica_efisico ON (pacientes.Idpaciente = hclinica_efisico.IdUsuario) " _
                    & "INNER JOIN orthosoft.hclinica_p2 ON (pacientes.Idpaciente = hclinica_p2.IdUsuario) " _
                    & "INNER JOIN orthosoft.hclinica_p3 ON (pacientes.Idpaciente = hclinica_p3.IdUsuario) " _
                    & "INNER JOIN orthosoft.hclinica_p4 ON (pacientes.Idpaciente = hclinica_p4.IdUsuario) " _
                    & "INNER JOIN orthosoft.ograma ON (pacientes.Idpaciente = ograma.IdUsuario) " _
                    & "INNER JOIN orthosoft.notas ON (pacientes.Idpaciente = notas.IdUsuario) " _
                    & "WHERE Idpaciente = " & Me.IdUsuario & " AND notas.IdTUsuario = 1"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("d:\varios\historiaclinica.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
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
