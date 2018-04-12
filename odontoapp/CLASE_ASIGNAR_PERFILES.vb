Public Class CLASE_ASIGNAR_PERFILES

    Private ACCESO As CLASE_PERFILESACCESO

    Public Sub Seleccionar_perfil()

        Try

            ACCESO = New CLASE_PERFILESACCESO
            ACCESO.p_Idperfil = CLASE_GENERAL.Nivel
            ACCESO.Seleccionar("registro")

            Asignar_Perfil("TabFunciones", CLASE_PERFILESACCESO.xTabFunciones)
            Asignar_Perfil("TabBackup", CLASE_PERFILESACCESO.xTabBackup)
            Asignar_Perfil("TabCambioUsuarios", CLASE_PERFILESACCESO.xTabCambioUsuarios)
            Asignar_Perfil("TabSincro", CLASE_PERFILESACCESO.xTabSincro)
            Asignar_Perfil("TabMenuPacientes", CLASE_PERFILESACCESO.xTabMenuPacientes)
            Asignar_Perfil("TabMenuDoctores", CLASE_PERFILESACCESO.xTabMenuDoctores)
            Asignar_Perfil("TabMenuUsuarios", CLASE_PERFILESACCESO.xTabMenuUsuarios)
            Asignar_Perfil("TabMenuEntidades", CLASE_PERFILESACCESO.xTabMenuEntidades)
            Asignar_Perfil("TabMenuInformes", CLASE_PERFILESACCESO.xTabMenuInformes)
            Asignar_Perfil("TabMenuAdmon", CLASE_PERFILESACCESO.xTabMenuAdmon)
            Asignar_Perfil("TabMenuCitas", CLASE_PERFILESACCESO.xTabMenuCitas)
            Asignar_Perfil("TabMenuContab", CLASE_PERFILESACCESO.xTabMenuContab)
            Asignar_Perfil("TabMenuVarios", CLASE_PERFILESACCESO.xTabMenuVarios)
            Asignar_Perfil("TabSchedulerSup", CLASE_PERFILESACCESO.xTabSchedulerSup)
            Asignar_Perfil("TabScheduler", CLASE_PERFILESACCESO.xTabScheduler)
            Asignar_Perfil("TabCitas", CLASE_PERFILESACCESO.xTabCitas)
            Asignar_Perfil("TabCitasMulti", CLASE_PERFILESACCESO.xTabCitas)
            Asignar_Perfil("TabFicha", CLASE_PERFILESACCESO.xTabFicha)
            Asignar_Perfil("TabPacientes", CLASE_PERFILESACCESO.xTabPacientes)
            Asignar_Perfil("TabDoctores", CLASE_PERFILESACCESO.xTabDoctores)
            Asignar_Perfil("TabUsuarios", CLASE_PERFILESACCESO.xTabUsuarios)
            Asignar_Perfil("TabEntidades", CLASE_PERFILESACCESO.xTabEntidades)
            Asignar_Perfil("TabHC", CLASE_PERFILESACCESO.xTabHC)
            Asignar_Perfil("TabProcdiario", CLASE_PERFILESACCESO.xTabProcdiario)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try


    End Sub

    Public Sub Asignar_Perfil(ByVal modulo As String, ByVal permisos As String)

        Try

            Select Case modulo

                Case "TabFunciones"

                    My.Forms.mdiOrthoSoft.btnf1InfPorPaciente.Enabled = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.btnf2Infpordia.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.btnf3InfFuturas.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.mdiOrthoSoft.btnf4InfSinAsistir.Enabled = convertir_booleano((Mid(permisos, 4, 1)))
                    My.Forms.mdiOrthoSoft.btnInfAsignadoDia.Enabled = convertir_booleano((Mid(permisos, 5, 1)))
                    My.Forms.mdiOrthoSoft.btnf5InfGeneral.Enabled = convertir_booleano((Mid(permisos, 6, 1)))
                    My.Forms.mdiOrthoSoft.btnf6InfCumpleHoy.Enabled = convertir_booleano((Mid(permisos, 7, 1)))
                    My.Forms.mdiOrthoSoft.btnf7InfCumpleSemana.Enabled = convertir_booleano((Mid(permisos, 8, 1)))
                    My.Forms.mdiOrthoSoft.btnf8InfCumpleMes.Enabled = convertir_booleano((Mid(permisos, 9, 1)))
                    My.Forms.mdiOrthoSoft.btnInfPacBloq.Enabled = convertir_booleano((Mid(permisos, 10, 1)))
                    My.Forms.mdiOrthoSoft.btnf9BloqueoDia.Enabled = convertir_booleano((Mid(permisos, 11, 1)))
                    My.Forms.mdiOrthoSoft.btnf10BloqueoPac.Enabled = convertir_booleano((Mid(permisos, 12, 1)))
                    My.Forms.mdiOrthoSoft.btnf11EnvioTel.Enabled = convertir_booleano((Mid(permisos, 13, 1)))
                    My.Forms.mdiOrthoSoft.btnf12EnvioEmail.Enabled = convertir_booleano((Mid(permisos, 14, 1)))
                    My.Forms.mdiOrthoSoft.btnSMS.Enabled = convertir_booleano((Mid(permisos, 15, 1)))
                    My.Forms.mdiOrthoSoft.btnCalculadora.Enabled = convertir_booleano((Mid(permisos, 16, 1)))

                Case "TabBackup"

                    My.Forms.mdiOrthoSoft.btnBackup.Enabled = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.btnRestaurarBackup.Enabled = convertir_booleano((Mid(permisos, 2, 1)))

                Case "TabCambioUsuarios"

                    My.Forms.mdiOrthoSoft.btnUsuSeleccionar.Enabled = convertir_booleano((Mid(permisos, 1, 1)))

                Case "TabSincro"

                    My.Forms.mdiOrthoSoft.btnSincronizar.Enabled = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.btnSoporteRemoto.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.btnActualizacion.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.mdiOrthoSoft.btnCirugia.Enabled = convertir_booleano((Mid(permisos, 4, 1)))

                Case "TabMenuPacientes"

                    My.Forms.mdiOrthoSoft.ExplorerPacientes.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerPacientes.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuNuevoPaciente.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuBuscarPaciente.Enabled = convertir_booleano((Mid(permisos, 3, 1)))

                Case "TabMenuDoctores"

                    My.Forms.mdiOrthoSoft.ExplorerDoctores.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerDoctores.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuNuevoDoctor.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuBuscarDoctor.Enabled = convertir_booleano((Mid(permisos, 3, 1)))

                Case "TabMenuUsuarios"

                    My.Forms.mdiOrthoSoft.ExplorerUsuarios.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerUsuarios.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuNuevoUsuario.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuBuscarUsuario.Enabled = convertir_booleano((Mid(permisos, 3, 1)))

                Case "TabMenuEntidades"

                    My.Forms.mdiOrthoSoft.ExplorerEntidades.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerEntidades.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuNuevaEntidad.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuBuscarEntidad.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.mdiOrthoSoft.mnuProveedores.Enabled = convertir_booleano((Mid(permisos, 4, 1)))
                    My.Forms.mdiOrthoSoft.mnuBuscarProveedores.Enabled = convertir_booleano((Mid(permisos, 5, 1)))
                    
                Case "TabMenuInformes"

                    My.Forms.mdiOrthoSoft.ExplorerInformes.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerInformes.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuGereradorInformes.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuProcedimientoDiario.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.mdiOrthoSoft.mnuDocumentos.Enabled = convertir_booleano((Mid(permisos, 4, 1)))

                Case "TabMenuAdmon"

                    My.Forms.mdiOrthoSoft.ExplorerAdministracion.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerAdministracion.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuAutenticacion.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuInfAuditoria.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.mdiOrthoSoft.mnuImporBD.Enabled = convertir_booleano((Mid(permisos, 4, 1)))
                    My.Forms.mdiOrthoSoft.mnuConfigIni.Enabled = convertir_booleano((Mid(permisos, 5, 1)))
                    My.Forms.mdiOrthoSoft.mnuNivelAcceso.Enabled = convertir_booleano((Mid(permisos, 6, 1)))

                Case "TabMenuCitas"

                    My.Forms.mdiOrthoSoft.ExplorerCitas.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerCitas.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuReminderCitas.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuBloqDesCalendario.Enabled = convertir_booleano((Mid(permisos, 3, 1)))

                Case "TabMenuContab"

                    My.Forms.mdiOrthoSoft.ExplorerContab.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerContab.ExpandButtonVisible = convertir_booleano((Mid(permisos, 1, 1)))

                    My.Forms.mdiOrthoSoft.mnuRcaja.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.mnuEgreso.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.mdiOrthoSoft.mnuPresupuesto.Enabled = convertir_booleano((Mid(permisos, 4, 1)))
                    My.Forms.mdiOrthoSoft.mnuItems.Enabled = convertir_booleano((Mid(permisos, 5, 1)))
                    My.Forms.mdiOrthoSoft.mnuEstadoCuenta.Enabled = convertir_booleano((Mid(permisos, 6, 1)))
                    My.Forms.mdiOrthoSoft.mnuGastos.Enabled = convertir_booleano((Mid(permisos, 7, 1)))
                    My.Forms.mdiOrthoSoft.mnuMovimientoDiario.Enabled = convertir_booleano((Mid(permisos, 8, 1)))

                Case "TabMenuVarios"

                    My.Forms.mdiOrthoSoft.ExplorerVarios.HeaderExpands = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExplorerVarios.ExpandButtonVisible = convertir_booleano((Mid(permisos, 2, 1)))

                    My.Forms.mdiOrthoSoft.mnuIlustraciones.Enabled = convertir_booleano((Mid(permisos, 2, 1)))

                Case "TabSchedulerSup"

                    My.Forms.mdiOrthoSoft.btnAppointment.Enabled = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.btnBuscarHuella.Enabled = convertir_booleano((Mid(permisos, 2, 1)))

                Case "TabScheduler"

                    My.Forms.mdiOrthoSoft.ScheduleOrhosoft.Enabled = convertir_booleano((Mid(permisos, 1, 1)))
                    My.Forms.mdiOrthoSoft.ExpandableScheduler.Enabled = convertir_booleano((Mid(permisos, 2, 1)))

                Case "TabCitas"

                    My.Forms.mdiOrthoSoft.btnCitaAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.mdiOrthoSoft.btnCitaModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.mdiOrthoSoft.btnCitaEliminar.Tag = Mid(permisos, 3, 1)
                    My.Forms.mdiOrthoSoft.btnCitaImprimir.Tag = Mid(permisos, 4, 1)

                    My.Forms.mdiOrthoSoft.cmbTipoConsulta.Enabled = convertir_booleano((Mid(permisos, 5, 1)))
                    My.Forms.mdiOrthoSoft.txtnotacita.Enabled = convertir_booleano((Mid(permisos, 6, 1)))

                    My.Forms.mdiOrthoSoft.GroupCitaCancelada.Enabled = convertir_booleano((Mid(permisos, 7, 1)))
                    My.Forms.mdiOrthoSoft.GroupAsistio.Enabled = convertir_booleano((Mid(permisos, 8, 1)))

                    My.Forms.mdiOrthoSoft.cmbDoctores.Enabled = convertir_booleano((Mid(permisos, 9, 1)))
                    My.Forms.mdiOrthoSoft.GroupAgenda.Enabled = convertir_booleano((Mid(permisos, 10, 1)))

                Case "TabCitasMulti"

                    My.Forms.frmAppointment.btnCitaAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.frmAppointment.btnCitaModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.frmAppointment.btnCitaEliminar.Tag = Mid(permisos, 3, 1)
                    My.Forms.frmAppointment.btnCitaImprimir.Tag = Mid(permisos, 4, 1)

                    My.Forms.frmAppointment.cmbTipoConsulta.Enabled = convertir_booleano((Mid(permisos, 5, 1)))
                    My.Forms.frmAppointment.txtnotacita.Enabled = convertir_booleano((Mid(permisos, 6, 1)))

                    My.Forms.frmAppointment.GroupCitaCancelada.Enabled = convertir_booleano((Mid(permisos, 7, 1)))
                    My.Forms.frmAppointment.GroupAsistio.Enabled = convertir_booleano((Mid(permisos, 8, 1)))

                    My.Forms.frmAppointment.cmbDoctores.Enabled = convertir_booleano((Mid(permisos, 9, 1)))
                    'My.Forms.frmAppointment.GroupAgenda.Enabled = convertir_booleano((Mid(permisos, 10, 1)))


                Case "TabFicha"

                    My.Forms.mdiOrthoSoft.btnEditarFicha.Tag = Mid(permisos, 1, 1)
                    My.Forms.mdiOrthoSoft.btnBuscar.Enabled = convertir_booleano((Mid(permisos, 2, 1)))
                    My.Forms.mdiOrthoSoft.btnEnvioEmail.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.mdiOrthoSoft.ExpandableCalendario.Enabled = convertir_booleano((Mid(permisos, 4, 1)))
                    My.Forms.mdiOrthoSoft.btnProcedimiento.Enabled = convertir_booleano((Mid(permisos, 5, 1)))
                    My.Forms.mdiOrthoSoft.btnEnvioSMSPersonalizado.Enabled = convertir_booleano((Mid(permisos, 6, 1)))
                    My.Forms.mdiOrthoSoft.btnPacOdontograma.Enabled = convertir_booleano((Mid(permisos, 7, 1)))
                    My.Forms.mdiOrthoSoft.btnEstadoCuenta.Enabled = convertir_booleano((Mid(permisos, 8, 1)))
                    My.Forms.mdiOrthoSoft.btnEstudiosPac.Enabled = convertir_booleano((Mid(permisos, 9, 1)))
                    My.Forms.mdiOrthoSoft.btnHistoriaClinica.Enabled = convertir_booleano((Mid(permisos, 9, 1)))

                Case "TabPacientes"

                    My.Forms.frmPacientes.btnAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.frmPacientes.btnModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.frmPacientes.btnEliminar.Tag = Mid(permisos, 3, 1)
                    My.Forms.frmPacientes.btnNuevo.Enabled = convertir_booleano((Mid(permisos, 4, 1)))

                Case "TabDoctores"

                    My.Forms.frmDoctores.btnAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.frmDoctores.btnModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.frmDoctores.btnEliminar.Tag = Mid(permisos, 3, 1)
                    My.Forms.frmDoctores.btnNuevo.Enabled = convertir_booleano((Mid(permisos, 4, 1)))

                Case "TabUsuarios"

                    My.Forms.frmUsuarios.btnAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.frmUsuarios.btnModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.frmUsuarios.btnEliminar.Tag = Mid(permisos, 3, 1)
                    My.Forms.frmUsuarios.btnNuevo.Enabled = convertir_booleano((Mid(permisos, 4, 1)))

                Case "TabEntidades"

                    My.Forms.frmEntidades.btnAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.frmEntidades.btnModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.frmEntidades.btnEliminar.Tag = Mid(permisos, 3, 1)
                    My.Forms.frmEntidades.btnNuevo.Enabled = convertir_booleano((Mid(permisos, 4, 1)))

                Case "TabHC"

                    My.Forms.frmHistoriaClinicaGeneral.btnAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.frmHistoriaClinicaGeneral.btnModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.frmHistoriaClinicaGeneral.btnDesbloquear.Enabled = convertir_booleano((Mid(permisos, 3, 1)))
                    My.Forms.frmHistoriaClinicaGeneral.btnNuevo.Tag = Mid(permisos, 4, 1)

                Case "TabProcdiario"

                    My.Forms.frmProcedimientoDiario.btnAdicionar.Tag = Mid(permisos, 1, 1)
                    My.Forms.frmProcedimientoDiario.btnModificar.Tag = Mid(permisos, 2, 1)
                    My.Forms.frmProcedimientoDiario.btnEliminar.Tag = Mid(permisos, 3, 1)
                    My.Forms.frmProcedimientoDiario.btnNuevo.Enabled = convertir_booleano((Mid(permisos, 4, 1)))

            End Select

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Function convertir_booleano(ByVal valor As String) As Boolean

        If valor = "1" Then

            Return True

        Else

            Return False

        End If


    End Function

End Class
