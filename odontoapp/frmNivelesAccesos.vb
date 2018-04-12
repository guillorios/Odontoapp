Imports System.Math

Public Class frmNivelesAccesos

    Private PERFILESACCESO As CLASE_PERFILESACCESO
    Private EVEN As CLASE_EVENTOS
    Private GENE As CLASE_GENERAL

    Private Sub TreeAccesos_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeAccesos.AfterSelect

        ' Menu Fichas Funciones

        If TreeAccesos.SelectedNode.Name = "NodoFichasFunciones" Or TreeAccesos.SelectedNode.Name = "NodoTabFunciones" Then

            Me.TabAccesos.SelectedTabIndex = 0
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoTabBackup" Then

            Me.TabAccesos.SelectedTabIndex = 1
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoTabUsuarios" Then

            Me.TabAccesos.SelectedTabIndex = 2
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoTabSincro" Then

            Me.TabAccesos.SelectedTabIndex = 3
            Me.TabAccesos.Update()

        End If

        ' Menu Fichas Principal

        If TreeAccesos.SelectedNode.Name = "NodoMenuPrincipal" Or TreeAccesos.SelectedNode.Name = "NodoMenuPacientes" Then

            Me.TabAccesos.SelectedTabIndex = 4
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuDoctores" Then

            Me.TabAccesos.SelectedTabIndex = 5
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuUsuarios" Then

            Me.TabAccesos.SelectedTabIndex = 6
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuEntidades" Then

            Me.TabAccesos.SelectedTabIndex = 7
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuInformes" Then

            Me.TabAccesos.SelectedTabIndex = 8
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuAdmon" Then

            Me.TabAccesos.SelectedTabIndex = 9
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuCitas" Then

            Me.TabAccesos.SelectedTabIndex = 10
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuContabilidad" Then

            Me.TabAccesos.SelectedTabIndex = 11
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoMenuVarios" Then

            Me.TabAccesos.SelectedTabIndex = 12
            Me.TabAccesos.Update()

        End If


        ' Menu Fichas Principal

        If TreeAccesos.SelectedNode.Name = "NodoScheduler" Or TreeAccesos.SelectedNode.Name = "NodoBotonesSuperiores" Then

            Me.TabAccesos.SelectedTabIndex = 13
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoControlScheduler" Then

            Me.TabAccesos.SelectedTabIndex = 14
            Me.TabAccesos.Update()

        ElseIf TreeAccesos.SelectedNode.Name = "NodoBotonesCitas" Then

            Me.TabAccesos.SelectedTabIndex = 15
            Me.TabAccesos.Update()

        End If

        If TreeAccesos.SelectedNode.Name = "NodoFichaPaciente" Then

            Me.TabAccesos.SelectedTabIndex = 16
            Me.TabAccesos.Update()

        End If

        If TreeAccesos.SelectedNode.Name = "NodoPacientes" Then

            Me.TabAccesos.SelectedTabIndex = 17
            Me.TabAccesos.Update()

        End If

        If TreeAccesos.SelectedNode.Name = "NodoDoctores" Then

            Me.TabAccesos.SelectedTabIndex = 18
            Me.TabAccesos.Update()

        End If

        If TreeAccesos.SelectedNode.Name = "NodoUsuarios" Then

            Me.TabAccesos.SelectedTabIndex = 19
            Me.TabAccesos.Update()

        End If

        If TreeAccesos.SelectedNode.Name = "NodoEntidades" Then

            Me.TabAccesos.SelectedTabIndex = 20
            Me.TabAccesos.Update()

        End If

        If TreeAccesos.SelectedNode.Name = "NodoHC" Then

            Me.TabAccesos.SelectedTabIndex = 21
            Me.TabAccesos.Update()

        End If

        If TreeAccesos.SelectedNode.Name = "NodoProcDiario" Then

            Me.TabAccesos.SelectedTabIndex = 22
            Me.TabAccesos.Update()

        End If



    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try
            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProviderPerfil.BlinkRate = 200
            Me.ErrorProviderPerfil.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            If Me.txtnom_perf.Text.Length = 0 Then
                ErrorProviderPerfil.SetError(Me.txtnom_perf, "Escriba el Nombre del Perfil")
                MsgBox(ErrorProviderPerfil.GetError(Me.txtnom_perf), MsgBoxStyle.OkOnly, "Perfil")
                Me.txtnom_perf.Focus()

            Else

                '**************************** MODULO PARA INGRESO PERFIL *******************************

                PERFILESACCESO = New CLASE_PERFILESACCESO

                PERFILESACCESO.p_Idperfil = Me.txtIdperfil.Text
                PERFILESACCESO.p_nom_perf = Me.txtnom_perf.Text


                '**************** Tab Funciones

                '1
                If Me.chk_TabFunciones_TodasCitas.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '2
                If Me.chk_TabFunciones_CitasDia.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '3
                If Me.chk_TabFunciones_CitasFuturas.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '4
                If Me.chk_TabFunciones_CitasSinAsistir.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '5
                If Me.chk_TabFunciones_InfoAsignadoDia.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '6
                If Me.chk_TabFunciones_Infogral.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '7
                If Me.chk_TabFunciones_CumpleHoy.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '8
                If Me.chk_TabFunciones_CumpleSem.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '9
                If Me.chk_TabFunciones_CumpleMes.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '10
                If Me.chk_TabFunciones_PacientesBq.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '11
                If Me.chk_TabFunciones_BlqDia.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '12
                If Me.chk_TabFunciones_BlqPaciente.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '13
                If Me.chk_TabFunciones_EnviarMenCall.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '14
                If Me.chk_TabFunciones_EnviarMenEmail.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '15
                If Me.chk_TabFunciones_EnviarMenSMS.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If

                '16
                If Me.chk_TabFunciones_Calculadora.Checked = True Then
                    PERFILESACCESO.p_TabFunciones &= "1"
                Else
                    PERFILESACCESO.p_TabFunciones &= "0"
                End If


                '**************** Tab Backup

                '1
                If Me.chk_TabBackup_Copia.Checked = True Then
                    PERFILESACCESO.p_TabBackups &= "1"
                Else
                    PERFILESACCESO.p_TabBackups &= "0"
                End If

                '2
                If Me.chk_TabBackup_Restaurar.Checked = True Then
                    PERFILESACCESO.p_TabBackups &= "1"
                Else
                    PERFILESACCESO.p_TabBackups &= "0"
                End If

                '**************** Tab Ingreso Usuarios

                '1
                If Me.chk_TabCambioUsu_Cambio.Checked = True Then
                    PERFILESACCESO.p_TabCambioUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabCambioUsuarios &= "0"
                End If

                '**************** Tab Sincro

                '1
                If Me.chk_TabSincro_Sincro.Checked = True Then
                    PERFILESACCESO.p_TabSincro &= "1"
                Else
                    PERFILESACCESO.p_TabSincro &= "0"
                End If

                '2
                If Me.chk_TabSincro_SoporteRemoto.Checked = True Then
                    PERFILESACCESO.p_TabSincro &= "1"
                Else
                    PERFILESACCESO.p_TabSincro &= "0"
                End If

                '3
                If Me.chk_TabSincro_Actualizacion.Checked = True Then
                    PERFILESACCESO.p_TabSincro &= "1"
                Else
                    PERFILESACCESO.p_TabSincro &= "0"
                End If

                '4
                If Me.chk_TabSincro_Cirugia.Checked = True Then
                    PERFILESACCESO.p_TabSincro &= "1"
                Else
                    PERFILESACCESO.p_TabSincro &= "0"
                End If



                '**************** Tab Menu Pacientes

                '1
                If Me.chk_TabMnuPac_Pac.Checked = True Then
                    PERFILESACCESO.p_TabMenuPacientes &= "1"
                Else
                    PERFILESACCESO.p_TabMenuPacientes &= "0"
                End If

                '2
                If Me.chk_TabMnuPac_NPac.Checked = True Then
                    PERFILESACCESO.p_TabMenuPacientes &= "1"
                Else
                    PERFILESACCESO.p_TabMenuPacientes &= "0"
                End If

                '3
                If Me.chk_TabMnuPac_BPac.Checked = True Then
                    PERFILESACCESO.p_TabMenuPacientes &= "1"
                Else
                    PERFILESACCESO.p_TabMenuPacientes &= "0"
                End If

                '**************** Tab Menu Doctores

                '1
                If Me.chk_TabMnuDoc_Doc.Checked = True Then
                    PERFILESACCESO.p_TabMenuDoctores &= "1"
                Else
                    PERFILESACCESO.p_TabMenuDoctores &= "0"
                End If

                '2
                If Me.chk_TabMnuDoc_NDoc.Checked = True Then
                    PERFILESACCESO.p_TabMenuDoctores &= "1"
                Else
                    PERFILESACCESO.p_TabMenuDoctores &= "0"
                End If

                '3
                If Me.chk_TabMnuDoc_BDoc.Checked = True Then
                    PERFILESACCESO.p_TabMenuDoctores &= "1"
                Else
                    PERFILESACCESO.p_TabMenuDoctores &= "0"
                End If

                '**************** Tab Menu Usuarios

                '1
                If Me.chk_TabMnuUsu_Usu.Checked = True Then
                    PERFILESACCESO.p_TabMenuUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabMenuUsuarios &= "0"
                End If

                '2
                If Me.chk_TabMnuUsu_NUsu.Checked = True Then
                    PERFILESACCESO.p_TabMenuUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabMenuUsuarios &= "0"
                End If

                '3
                If Me.chk_TabMnuUsu_BUsu.Checked = True Then
                    PERFILESACCESO.p_TabMenuUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabMenuUsuarios &= "0"
                End If

                '**************** Tab Menu Entidades

                '1
                If Me.chk_TabMnuEnt_Ent.Checked = True Then
                    PERFILESACCESO.p_TabMenuEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabMenuEntidades &= "0"
                End If

                '2
                If Me.chk_TabMnuEnt_NEnt.Checked = True Then
                    PERFILESACCESO.p_TabMenuEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabMenuEntidades &= "0"
                End If

                '3
                If Me.chk_TabMnuEnt_BEnt.Checked = True Then
                    PERFILESACCESO.p_TabMenuEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabMenuEntidades &= "0"
                End If

                '4
                If Me.chk_TabMnuEnt_NProv.Checked = True Then
                    PERFILESACCESO.p_TabMenuEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabMenuEntidades &= "0"
                End If

                '5
                If Me.chk_TabMnuEnt_BProv.Checked = True Then
                    PERFILESACCESO.p_TabMenuEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabMenuEntidades &= "0"
                End If

                '**************** Tab Menu Informes

                '1
                If Me.chk_TabMnuInf_Inf.Checked = True Then
                    PERFILESACCESO.p_TabMenuInformes &= "1"
                Else
                    PERFILESACCESO.p_TabMenuInformes &= "0"
                End If

                '2
                If Me.chk_TabMnuInf_InfV.Checked = True Then
                    PERFILESACCESO.p_TabMenuInformes &= "1"
                Else
                    PERFILESACCESO.p_TabMenuInformes &= "0"
                End If

                '3
                If Me.chk_TabMnuInf_ProcD.Checked = True Then
                    PERFILESACCESO.p_TabMenuInformes &= "1"
                Else
                    PERFILESACCESO.p_TabMenuInformes &= "0"
                End If

                '4
                If Me.chk_TabMnuInf_Documentos.Checked = True Then
                    PERFILESACCESO.p_TabMenuInformes &= "1"
                Else
                    PERFILESACCESO.p_TabMenuInformes &= "0"
                End If

                '**************** Tab Menu Administracion

                '1
                If Me.chk_TabMnuAdm_Adm.Checked = True Then
                    PERFILESACCESO.p_TabMenuAdmon &= "1"
                Else
                    PERFILESACCESO.p_TabMenuAdmon &= "0"
                End If

                '2
                If Me.chk_TabMnuAdm_Aut.Checked = True Then
                    PERFILESACCESO.p_TabMenuAdmon &= "1"
                Else
                    PERFILESACCESO.p_TabMenuAdmon &= "0"
                End If

                '3
                If Me.chk_TabMnuAdm_Audito.Checked = True Then
                    PERFILESACCESO.p_TabMenuAdmon &= "1"
                Else
                    PERFILESACCESO.p_TabMenuAdmon &= "0"
                End If

                '4
                If Me.chk_TabMnuAdm_Import.Checked = True Then
                    PERFILESACCESO.p_TabMenuAdmon &= "1"
                Else
                    PERFILESACCESO.p_TabMenuAdmon &= "0"
                End If

                '5
                If Me.chk_TabMnuAdm_Config.Checked = True Then
                    PERFILESACCESO.p_TabMenuAdmon &= "1"
                Else
                    PERFILESACCESO.p_TabMenuAdmon &= "0"
                End If

                '6
                If Me.chk_TabMnuAdm_Acceso.Checked = True Then
                    PERFILESACCESO.p_TabMenuAdmon &= "1"
                Else
                    PERFILESACCESO.p_TabMenuAdmon &= "0"
                End If

                '**************** Tab Menu Citas

                '1
                If Me.chk_TabMnuCitas_Citas.Checked = True Then
                    PERFILESACCESO.p_TabMenuCitas &= "1"
                Else
                    PERFILESACCESO.p_TabMenuCitas &= "0"
                End If

                '2
                If Me.chk_TabMnuCitas_Reminder.Checked = True Then
                    PERFILESACCESO.p_TabMenuCitas &= "1"
                Else
                    PERFILESACCESO.p_TabMenuCitas &= "0"
                End If

                '3
                If Me.chk_TabMnuCitas_BloquearCitas.Checked = True Then
                    PERFILESACCESO.p_TabMenuCitas &= "1"
                Else
                    PERFILESACCESO.p_TabMenuCitas &= "0"
                End If

                '**************** Tab Menu Contab

                '1
                If Me.chk_TabMnuConta_Conta.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '2
                If Me.chk_TabMnuConta_CEgreso.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '3
                If Me.chk_TabMnuConta_RCaja.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '4
                If Me.chk_TabMnuConta_Presupuesto.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '5
                If Me.chk_TabMnuConta_Vprocedimiento.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '6
                If Me.chk_TabMnuConta_ECuenta.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '7
                If Me.chk_TabMnuConta_Gastos.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '8
                If Me.chk_TabMnuConta_MDiario.Checked = True Then
                    PERFILESACCESO.p_TabMenuContab &= "1"
                Else
                    PERFILESACCESO.p_TabMenuContab &= "0"
                End If

                '**************** Tab Menu Varios

                '1
                If Me.chk_TabMnuVarios.Checked = True Then
                    PERFILESACCESO.p_TabMenuVarios &= "1"
                Else
                    PERFILESACCESO.p_TabMenuVarios &= "0"
                End If

                '2
                If Me.chk_TabMnuVarios_Ilustraciones.Checked = True Then
                    PERFILESACCESO.p_TabMenuVarios &= "1"
                Else
                    PERFILESACCESO.p_TabMenuVarios &= "0"
                End If

                '**************** Tab Menu Sheduler Superior

                If Me.chk_TabSchSup_Cambio.Checked = True Then
                    PERFILESACCESO.p_TabSchedulerSup &= "1"
                Else
                    PERFILESACCESO.p_TabSchedulerSup &= "0"
                End If

                If Me.chk_TabSchSup_BuscaHuellas.Checked = True Then
                    PERFILESACCESO.p_TabSchedulerSup &= "1"
                Else
                    PERFILESACCESO.p_TabSchedulerSup &= "0"
                End If

                '**************** Tab Menu Sheduler

                If Me.chk_TabSch_Control.Checked = True Then
                    PERFILESACCESO.p_TabScheduler &= "1"
                Else
                    PERFILESACCESO.p_TabScheduler &= "0"
                End If

                If Me.chk_TabSch_SplittCitas.Checked = True Then
                    PERFILESACCESO.p_TabScheduler &= "1"
                Else
                    PERFILESACCESO.p_TabScheduler &= "0"
                End If

                '**************** Tab Citas

                If Me.chk_TabCitas_ACita.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_MCita.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_ECita.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_ICita.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_TConsul.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_NotaCita.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_CitaCanc.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_CitaAsis.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_CambioDoc.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                If Me.chk_TabCitas_RangoCita.Checked = True Then
                    PERFILESACCESO.p_TabCitas &= "1"
                Else
                    PERFILESACCESO.p_TabCitas &= "0"
                End If

                '**************** Tab Ficha

                If Me.chk_TabFicha_EPac.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_BPac.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_EmailPac.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_SplitAgenda.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_ProcDiario.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_SMS.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_Odontograma.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_EstadoCuenta.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_Estudios.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                If Me.chk_TabFicha_HC.Checked = True Then
                    PERFILESACCESO.p_TabFicha &= "1"
                Else
                    PERFILESACCESO.p_TabFicha &= "0"
                End If

                '**************** Tab Pacientes

                If Me.chk_TabPac_APac.Checked = True Then
                    PERFILESACCESO.p_TabPacientes &= "1"
                Else
                    PERFILESACCESO.p_TabPacientes &= "0"
                End If

                If Me.chk_TabPac_MPac.Checked = True Then
                    PERFILESACCESO.p_TabPacientes &= "1"
                Else
                    PERFILESACCESO.p_TabPacientes &= "0"
                End If

                If Me.chk_TabPac_BPac.Checked = True Then
                    PERFILESACCESO.p_TabPacientes &= "1"
                Else
                    PERFILESACCESO.p_TabPacientes &= "0"
                End If

                If Me.chk_TabPac_NPac.Checked = True Then
                    PERFILESACCESO.p_TabPacientes &= "1"
                Else
                    PERFILESACCESO.p_TabPacientes &= "0"
                End If

                '**************** Tab Doctores

                If Me.chk_TabDoc_ADoc.Checked = True Then
                    PERFILESACCESO.p_TabDoctores &= "1"
                Else
                    PERFILESACCESO.p_TabDoctores &= "0"
                End If

                If Me.chk_TabDoc_MDoc.Checked = True Then
                    PERFILESACCESO.p_TabDoctores &= "1"
                Else
                    PERFILESACCESO.p_TabDoctores &= "0"
                End If

                If Me.chk_TabDoc_BDoc.Checked = True Then
                    PERFILESACCESO.p_TabDoctores &= "1"
                Else
                    PERFILESACCESO.p_TabDoctores &= "0"
                End If

                If Me.chk_TabDoc_NDoc.Checked = True Then
                    PERFILESACCESO.p_TabDoctores &= "1"
                Else
                    PERFILESACCESO.p_TabDoctores &= "0"
                End If

                '**************** Tab Usuarios

                If Me.chk_TabUsu_AUsu.Checked = True Then
                    PERFILESACCESO.p_TabUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabUsuarios &= "0"
                End If

                If Me.chk_TabUsu_MUsu.Checked = True Then
                    PERFILESACCESO.p_TabUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabUsuarios &= "0"
                End If

                If Me.chk_TabUsu_BUsu.Checked = True Then
                    PERFILESACCESO.p_TabUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabUsuarios &= "0"
                End If

                If Me.chk_TabUsu_NUsu.Checked = True Then
                    PERFILESACCESO.p_TabUsuarios &= "1"
                Else
                    PERFILESACCESO.p_TabUsuarios &= "0"
                End If

                '**************** Tab Entidades

                If Me.chk_TabEnt_AEnt.Checked = True Then
                    PERFILESACCESO.p_TabEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabEntidades &= "0"
                End If

                If Me.chk_TabEnt_MEnt.Checked = True Then
                    PERFILESACCESO.p_TabEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabEntidades &= "0"
                End If

                If Me.chk_TabEnt_BEnt.Checked = True Then
                    PERFILESACCESO.p_TabEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabEntidades &= "0"
                End If

                If Me.chk_TabEnt_NEnt.Checked = True Then
                    PERFILESACCESO.p_TabEntidades &= "1"
                Else
                    PERFILESACCESO.p_TabEntidades &= "0"
                End If

                ' Tab Historias Clinicas
                ' ----- General ------

                If Me.chk_TabHC_Adicionarg.Checked = True Then
                    PERFILESACCESO.p_TabHC &= "1"
                Else
                    PERFILESACCESO.p_TabHC &= "0"
                End If

                If Me.chk_TabHC_Modificarg.Checked = True Then
                    PERFILESACCESO.p_TabHC &= "1"
                Else
                    PERFILESACCESO.p_TabHC &= "0"
                End If

                If Me.chk_TabHC_Desblg.Checked = True Then
                    PERFILESACCESO.p_TabHC &= "1"
                Else
                    PERFILESACCESO.p_TabHC &= "0"
                End If

                If Me.chk_TabHC_Nuevag.Checked = True Then
                    PERFILESACCESO.p_TabHC &= "1"
                Else
                    PERFILESACCESO.p_TabHC &= "0"
                End If


                'Tab Procedimientos diarios

                If Me.chk_Tabproc_AProc.Checked = True Then
                    PERFILESACCESO.p_TabProcdiario &= "1"
                Else
                    PERFILESACCESO.p_TabProcdiario &= "0"
                End If

                If Me.chk_Tabproc_MProc.Checked = True Then
                    PERFILESACCESO.p_TabProcdiario &= "1"
                Else
                    PERFILESACCESO.p_TabProcdiario &= "0"
                End If

                If Me.chk_Tabproc_BProc.Checked = True Then
                    PERFILESACCESO.p_TabProcdiario &= "1"
                Else
                    PERFILESACCESO.p_TabProcdiario &= "0"
                End If

                If Me.chk_Tabproc_NProc.Checked = True Then
                    PERFILESACCESO.p_TabProcdiario &= "1"
                Else
                    PERFILESACCESO.p_TabProcdiario &= "0"
                End If

                '------------------------------------------


                'Insertamos en la base de datos
                PERFILESACCESO.Insertar(CLASE_GENERAL.mensaje_error)
                PERFILESACCESO.dispose() 'liberamos recursos
                PERFILESACCESO = Nothing

                'Cargamos los perfiles nuevamente
                CLASE_GENERAL.cargar_combo("perfilesacceso", Me.cmbPerfilAcceso, CLASE_GENERAL.mensaje_error)
                Me.cmbPerfilAcceso.SelectedValue = Me.txtIdperfil.Text

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarperfil")
                EVEN = Nothing

                MessageBox.Show("Perfil Registrado con Exito", "Perfil")

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub txtnom_perf_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnom_perf.TextChanged

        Me.ErrorProviderPerfil.SetError(Me.txtnom_perf, "")

    End Sub


    Private Sub frmNivelesAccesos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            CLASE_GENERAL.cargar_combo("perfilesacceso", Me.cmbPerfilAcceso, CLASE_GENERAL.mensaje_error)
            Me.cmbPerfilAcceso.SelectedValue = 1
            cmbPerfilAcceso_SelectionChangeCommitted(sender, e)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbPerfilAcceso_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPerfilAcceso.SelectionChangeCommitted

        Try

            PERFILESACCESO = New CLASE_PERFILESACCESO
            PERFILESACCESO.p_Idperfil = Me.cmbPerfilAcceso.SelectedValue

            PERFILESACCESO.Seleccionar("registro")

            Me.txtIdperfil.Text = CLASE_PERFILESACCESO.xIdperfil
            Me.txtnom_perf.Text = CLASE_PERFILESACCESO.xnom_perf


            ' **** Tab Funciones

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 1, 1) = "1" Then
                Me.chk_TabFunciones_TodasCitas.Checked = True
            Else
                Me.chk_TabFunciones_TodasCitas.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 2, 1) = "1" Then
                Me.chk_TabFunciones_CitasDia.Checked = True
            Else
                Me.chk_TabFunciones_CitasDia.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 3, 1) = "1" Then
                Me.chk_TabFunciones_CitasFuturas.Checked = True
            Else
                Me.chk_TabFunciones_CitasFuturas.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 4, 1) = "1" Then
                Me.chk_TabFunciones_CitasSinAsistir.Checked = True
            Else
                Me.chk_TabFunciones_CitasSinAsistir.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 5, 1) = "1" Then
                Me.chk_TabFunciones_InfoAsignadoDia.Checked = True
            Else
                Me.chk_TabFunciones_InfoAsignadoDia.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 6, 1) = "1" Then
                Me.chk_TabFunciones_Infogral.Checked = True
            Else
                Me.chk_TabFunciones_Infogral.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 7, 1) = "1" Then
                Me.chk_TabFunciones_CumpleHoy.Checked = True
            Else
                Me.chk_TabFunciones_CumpleHoy.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 8, 1) = "1" Then
                Me.chk_TabFunciones_CumpleSem.Checked = True
            Else
                Me.chk_TabFunciones_CumpleSem.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 9, 1) = "1" Then
                Me.chk_TabFunciones_CumpleMes.Checked = True
            Else
                Me.chk_TabFunciones_CumpleMes.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 10, 1) = "1" Then
                Me.chk_TabFunciones_PacientesBq.Checked = True
            Else
                Me.chk_TabFunciones_PacientesBq.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 11, 1) = "1" Then
                Me.chk_TabFunciones_BlqDia.Checked = True
            Else
                Me.chk_TabFunciones_BlqDia.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 12, 1) = "1" Then
                Me.chk_TabFunciones_BlqPaciente.Checked = True
            Else
                Me.chk_TabFunciones_BlqPaciente.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 13, 1) = "1" Then
                Me.chk_TabFunciones_EnviarMenCall.Checked = True
            Else
                Me.chk_TabFunciones_EnviarMenCall.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 14, 1) = "1" Then
                Me.chk_TabFunciones_EnviarMenEmail.Checked = True
            Else
                Me.chk_TabFunciones_EnviarMenEmail.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 15, 1) = "1" Then
                Me.chk_TabFunciones_EnviarMenSMS.Checked = True
            Else
                Me.chk_TabFunciones_EnviarMenSMS.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFunciones, 16, 1) = "1" Then
                Me.chk_TabFunciones_Calculadora.Checked = True
            Else
                Me.chk_TabFunciones_Calculadora.Checked = False
            End If


            ' **** Tab Backup

            If Mid(CLASE_PERFILESACCESO.xTabBackup, 1, 1) = "1" Then
                Me.chk_TabBackup_Copia.Checked = True
            Else
                Me.chk_TabBackup_Copia.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabBackup, 2, 1) = "1" Then
                Me.chk_TabBackup_Restaurar.Checked = True
            Else
                Me.chk_TabBackup_Restaurar.Checked = False
            End If

            ' **** Tab Cambio Usuarios

            If Mid(CLASE_PERFILESACCESO.xTabCambioUsuarios, 1, 1) = "1" Then
                Me.chk_TabCambioUsu_Cambio.Checked = True
            Else
                Me.chk_TabCambioUsu_Cambio.Checked = False
            End If

            ' **** Tab Sincro

            If Mid(CLASE_PERFILESACCESO.xTabSincro, 1, 1) = "1" Then
                Me.chk_TabSincro_Sincro.Checked = True
            Else
                Me.chk_TabSincro_Sincro.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabSincro, 2, 1) = "1" Then
                Me.chk_TabSincro_SoporteRemoto.Checked = True
            Else
                Me.chk_TabSincro_SoporteRemoto.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabSincro, 3, 1) = "1" Then
                Me.chk_TabSincro_Actualizacion.Checked = True
            Else
                Me.chk_TabSincro_Actualizacion.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabSincro, 4, 1) = "1" Then
                Me.chk_TabSincro_Cirugia.Checked = True
            Else
                Me.chk_TabSincro_Cirugia.Checked = False
            End If

            ' **** Tab Menu Pacientes

            If Mid(CLASE_PERFILESACCESO.xTabMenuPacientes, 1, 1) = "1" Then
                Me.chk_TabMnuPac_Pac.Checked = True
            Else
                Me.chk_TabMnuPac_Pac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuPacientes, 2, 1) = "1" Then
                Me.chk_TabMnuPac_NPac.Checked = True
            Else
                Me.chk_TabMnuPac_NPac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuPacientes, 3, 1) = "1" Then
                Me.chk_TabMnuPac_BPac.Checked = True
            Else
                Me.chk_TabMnuPac_BPac.Checked = False
            End If

            ' **** Tab Menu Doctores

            If Mid(CLASE_PERFILESACCESO.xTabMenuDoctores, 1, 1) = "1" Then
                Me.chk_TabMnuDoc_Doc.Checked = True
            Else
                Me.chk_TabMnuDoc_Doc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuDoctores, 2, 1) = "1" Then
                Me.chk_TabMnuDoc_NDoc.Checked = True
            Else
                Me.chk_TabMnuDoc_NDoc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuDoctores, 3, 1) = "1" Then
                Me.chk_TabMnuDoc_BDoc.Checked = True
            Else
                Me.chk_TabMnuDoc_BDoc.Checked = False
            End If

            ' **** Tab Menu Usuarios

            If Mid(CLASE_PERFILESACCESO.xTabMenuUsuarios, 1, 1) = "1" Then
                Me.chk_TabMnuUsu_Usu.Checked = True
            Else
                Me.chk_TabMnuUsu_Usu.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuUsuarios, 2, 1) = "1" Then
                Me.chk_TabMnuUsu_NUsu.Checked = True
            Else
                Me.chk_TabMnuUsu_NUsu.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuUsuarios, 3, 1) = "1" Then
                Me.chk_TabMnuUsu_BUsu.Checked = True
            Else
                Me.chk_TabMnuUsu_BUsu.Checked = False
            End If

            ' **** Tab Menu Entidades

            If Mid(CLASE_PERFILESACCESO.xTabMenuEntidades, 1, 1) = "1" Then
                Me.chk_TabMnuEnt_Ent.Checked = True
            Else
                Me.chk_TabMnuEnt_Ent.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuEntidades, 2, 1) = "1" Then
                Me.chk_TabMnuEnt_NEnt.Checked = True
            Else
                Me.chk_TabMnuEnt_NEnt.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuEntidades, 3, 1) = "1" Then
                Me.chk_TabMnuEnt_BEnt.Checked = True
            Else
                Me.chk_TabMnuEnt_BEnt.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuEntidades, 4, 1) = "1" Then
                Me.chk_TabMnuEnt_NProv.Checked = True
            Else
                Me.chk_TabMnuEnt_NProv.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuEntidades, 5, 1) = "1" Then
                Me.chk_TabMnuEnt_BProv.Checked = True
            Else
                Me.chk_TabMnuEnt_BProv.Checked = False
            End If

            ' **** Tab Menu Informes

            If Mid(CLASE_PERFILESACCESO.xTabMenuInformes, 1, 1) = "1" Then
                Me.chk_TabMnuInf_Inf.Checked = True
            Else
                Me.chk_TabMnuInf_Inf.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuInformes, 2, 1) = "1" Then
                Me.chk_TabMnuInf_InfV.Checked = True
            Else
                Me.chk_TabMnuInf_InfV.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuInformes, 3, 1) = "1" Then
                Me.chk_TabMnuInf_ProcD.Checked = True
            Else
                Me.chk_TabMnuInf_ProcD.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuInformes, 4, 1) = "1" Then
                Me.chk_TabMnuInf_Documentos.Checked = True
            Else
                Me.chk_TabMnuInf_Documentos.Checked = False
            End If

            ' **** Tab Menu Admon 

            If Mid(CLASE_PERFILESACCESO.xTabMenuAdmon, 1, 1) = "1" Then
                Me.chk_TabMnuAdm_Adm.Checked = True
            Else
                Me.chk_TabMnuAdm_Adm.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuAdmon, 2, 1) = "1" Then
                Me.chk_TabMnuAdm_Aut.Checked = True
            Else
                Me.chk_TabMnuAdm_Aut.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuAdmon, 3, 1) = "1" Then
                Me.chk_TabMnuAdm_Audito.Checked = True
            Else
                Me.chk_TabMnuAdm_Audito.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuAdmon, 4, 1) = "1" Then
                Me.chk_TabMnuAdm_Import.Checked = True
            Else
                Me.chk_TabMnuAdm_Import.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuAdmon, 5, 1) = "1" Then
                Me.chk_TabMnuAdm_Config.Checked = True
            Else
                Me.chk_TabMnuAdm_Config.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuAdmon, 6, 1) = "1" Then
                Me.chk_TabMnuAdm_Acceso.Checked = True
            Else
                Me.chk_TabMnuAdm_Acceso.Checked = False
            End If

            ' **** Tab Menu Citas 

            If Mid(CLASE_PERFILESACCESO.xTabMenuCitas, 1, 1) = "1" Then
                Me.chk_TabMnuCitas_Citas.Checked = True
            Else
                Me.chk_TabMnuCitas_Citas.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuCitas, 2, 1) = "1" Then
                Me.chk_TabMnuCitas_Reminder.Checked = True
            Else
                Me.chk_TabMnuCitas_Reminder.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuCitas, 3, 1) = "1" Then
                Me.chk_TabMnuCitas_BloquearCitas.Checked = True
            Else
                Me.chk_TabMnuCitas_BloquearCitas.Checked = False
            End If

            ' **** Tab Menu Contabilidad

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 1, 1) = "1" Then
                Me.chk_TabMnuConta_Conta.Checked = True
            Else
                Me.chk_TabMnuConta_Conta.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 2, 1) = "1" Then
                Me.chk_TabMnuConta_RCaja.Checked = True
            Else
                Me.chk_TabMnuConta_RCaja.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 3, 1) = "1" Then
                Me.chk_TabMnuConta_CEgreso.Checked = True
            Else
                Me.chk_TabMnuConta_CEgreso.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 4, 1) = "1" Then
                Me.chk_TabMnuConta_Presupuesto.Checked = True
            Else
                Me.chk_TabMnuConta_Presupuesto.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 5, 1) = "1" Then
                Me.chk_TabMnuConta_Vprocedimiento.Checked = True
            Else
                Me.chk_TabMnuConta_Vprocedimiento.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 6, 1) = "1" Then
                Me.chk_TabMnuConta_ECuenta.Checked = True
            Else
                Me.chk_TabMnuConta_ECuenta.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 7, 1) = "1" Then
                Me.chk_TabMnuConta_Gastos.Checked = True
            Else
                Me.chk_TabMnuConta_Gastos.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuContab, 8, 1) = "1" Then
                Me.chk_TabMnuConta_MDiario.Checked = True
            Else
                Me.chk_TabMnuConta_MDiario.Checked = False
            End If

            ' **** Tab Menu Varios

            If Mid(CLASE_PERFILESACCESO.xTabMenuVarios, 1, 1) = "1" Then
                Me.chk_TabMnuVarios.Checked = True
            Else
                Me.chk_TabMnuVarios.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabMenuVarios, 2, 1) = "1" Then
                Me.chk_TabMnuVarios_Ilustraciones.Checked = True
            Else
                Me.chk_TabMnuVarios_Ilustraciones.Checked = False
            End If

            ' **** Tab Menu Scheduler Sup

            If Mid(CLASE_PERFILESACCESO.xTabSchedulerSup, 1, 1) = "1" Then
                Me.chk_TabSchSup_Cambio.Checked = True
            Else
                Me.chk_TabSchSup_Cambio.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabSchedulerSup, 2, 1) = "1" Then
                Me.chk_TabSchSup_BuscaHuellas.Checked = True
            Else
                Me.chk_TabSchSup_BuscaHuellas.Checked = False
            End If

            ' **** Tab Menu Scheduler

            If Mid(CLASE_PERFILESACCESO.xTabScheduler, 1, 1) = "1" Then
                Me.chk_TabSch_Control.Checked = True
            Else
                Me.chk_TabSch_Control.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabScheduler, 2, 1) = "1" Then
                Me.chk_TabSch_SplittCitas.Checked = True
            Else
                Me.chk_TabSch_SplittCitas.Checked = False
            End If

            ' **** Tab Citas

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 1, 1) = "1" Then
                Me.chk_TabCitas_ACita.Checked = True
            Else
                Me.chk_TabCitas_ACita.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 2, 1) = "1" Then
                Me.chk_TabCitas_MCita.Checked = True
            Else
                Me.chk_TabCitas_MCita.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 3, 1) = "1" Then
                Me.chk_TabCitas_ECita.Checked = True
            Else
                Me.chk_TabCitas_ECita.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 4, 1) = "1" Then
                Me.chk_TabCitas_ICita.Checked = True
            Else
                Me.chk_TabCitas_ICita.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 5, 1) = "1" Then
                Me.chk_TabCitas_TConsul.Checked = True
            Else
                Me.chk_TabCitas_TConsul.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 6, 1) = "1" Then
                Me.chk_TabCitas_NotaCita.Checked = True
            Else
                Me.chk_TabCitas_NotaCita.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 7, 1) = "1" Then
                Me.chk_TabCitas_CitaCanc.Checked = True
            Else
                Me.chk_TabCitas_CitaCanc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 8, 1) = "1" Then
                Me.chk_TabCitas_CitaAsis.Checked = True
            Else
                Me.chk_TabCitas_CitaAsis.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 9, 1) = "1" Then
                Me.chk_TabCitas_CambioDoc.Checked = True
            Else
                Me.chk_TabCitas_CambioDoc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabCitas, 10, 1) = "1" Then
                Me.chk_TabCitas_RangoCita.Checked = True
            Else
                Me.chk_TabCitas_RangoCita.Checked = False
            End If

            ' **** Tab Fichas

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 1, 1) = "1" Then
                Me.chk_TabFicha_EPac.Checked = True
            Else
                Me.chk_TabFicha_EPac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 2, 1) = "1" Then
                Me.chk_TabFicha_BPac.Checked = True
            Else
                Me.chk_TabFicha_BPac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 3, 1) = "1" Then
                Me.chk_TabFicha_EmailPac.Checked = True
            Else
                Me.chk_TabFicha_EmailPac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 4, 1) = "1" Then
                Me.chk_TabFicha_SplitAgenda.Checked = True
            Else
                Me.chk_TabFicha_SplitAgenda.Checked = False
            End If


            If Mid(CLASE_PERFILESACCESO.xTabFicha, 5, 1) = "1" Then
                Me.chk_TabFicha_ProcDiario.Checked = True
            Else
                Me.chk_TabFicha_ProcDiario.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 6, 1) = "1" Then
                Me.chk_TabFicha_SMS.Checked = True
            Else
                Me.chk_TabFicha_SMS.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 7, 1) = "1" Then
                Me.chk_TabFicha_Odontograma.Checked = True
            Else
                Me.chk_TabFicha_Odontograma.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 8, 1) = "1" Then
                Me.chk_TabFicha_EstadoCuenta.Checked = True
            Else
                Me.chk_TabFicha_EstadoCuenta.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 9, 1) = "1" Then
                Me.chk_TabFicha_Estudios.Checked = True
            Else
                Me.chk_TabFicha_Estudios.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabFicha, 10, 1) = "1" Then
                Me.chk_TabFicha_HC.Checked = True
            Else
                Me.chk_TabFicha_HC.Checked = False
            End If


            ' **** Tab Pacientes

            If Mid(CLASE_PERFILESACCESO.xTabPacientes, 1, 1) = "1" Then
                Me.chk_TabPac_APac.Checked = True
            Else
                Me.chk_TabPac_APac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabPacientes, 2, 1) = "1" Then
                Me.chk_TabPac_MPac.Checked = True
            Else
                Me.chk_TabPac_MPac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabPacientes, 3, 1) = "1" Then
                Me.chk_TabPac_BPac.Checked = True
            Else
                Me.chk_TabPac_BPac.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabPacientes, 4, 1) = "1" Then
                Me.chk_TabPac_NPac.Checked = True
            Else
                Me.chk_TabPac_NPac.Checked = False
            End If

            ' **** Tab Doctores

            If Mid(CLASE_PERFILESACCESO.xTabDoctores, 1, 1) = "1" Then
                Me.chk_TabDoc_ADoc.Checked = True
            Else
                Me.chk_TabDoc_ADoc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabDoctores, 2, 1) = "1" Then
                Me.chk_TabDoc_MDoc.Checked = True
            Else
                Me.chk_TabDoc_MDoc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabDoctores, 3, 1) = "1" Then
                Me.chk_TabDoc_BDoc.Checked = True
            Else
                Me.chk_TabDoc_BDoc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabDoctores, 4, 1) = "1" Then
                Me.chk_TabDoc_NDoc.Checked = True
            Else
                Me.chk_TabDoc_NDoc.Checked = False
            End If

            ' **** Tab Usuarios

            If Mid(CLASE_PERFILESACCESO.xTabUsuarios, 1, 1) = "1" Then
                Me.chk_TabUsu_AUsu.Checked = True
            Else
                Me.chk_TabUsu_AUsu.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabUsuarios, 2, 1) = "1" Then
                Me.chk_TabUsu_MUsu.Checked = True
            Else
                Me.chk_TabUsu_MUsu.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabUsuarios, 3, 1) = "1" Then
                Me.chk_TabUsu_BUsu.Checked = True
            Else
                Me.chk_TabUsu_BUsu.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabUsuarios, 4, 1) = "1" Then
                Me.chk_TabUsu_NUsu.Checked = True
            Else
                Me.chk_TabUsu_NUsu.Checked = False
            End If

            ' **** Tab Entidades

            If Mid(CLASE_PERFILESACCESO.xTabEntidades, 1, 1) = "1" Then
                Me.chk_TabEnt_AEnt.Checked = True
            Else
                Me.chk_TabEnt_AEnt.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabEntidades, 2, 1) = "1" Then
                Me.chk_TabEnt_MEnt.Checked = True
            Else
                Me.chk_TabEnt_MEnt.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabEntidades, 3, 1) = "1" Then
                Me.chk_TabEnt_BEnt.Checked = True
            Else
                Me.chk_TabEnt_BEnt.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabEntidades, 4, 1) = "1" Then
                Me.chk_TabEnt_NEnt.Checked = True
            Else
                Me.chk_TabEnt_NEnt.Checked = False
            End If

            ' **** Tab HC
            '------------ General

            If Mid(CLASE_PERFILESACCESO.xTabHC, 1, 1) = "1" Then
                Me.chk_TabHC_Adicionarg.Checked = True
            Else
                Me.chk_TabHC_Adicionarg.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabHC, 2, 1) = "1" Then
                Me.chk_TabHC_Modificarg.Checked = True
            Else
                Me.chk_TabHC_Modificarg.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabHC, 3, 1) = "1" Then
                Me.chk_TabHC_Desblg.Checked = True
            Else
                Me.chk_TabHC_Desblg.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabHC, 4, 1) = "1" Then
                Me.chk_TabHC_Nuevag.Checked = True
            Else
                Me.chk_TabHC_Nuevag.Checked = False
            End If

            'Tab procedimientos diarios

            If Mid(CLASE_PERFILESACCESO.xTabProcdiario, 1, 1) = "1" Then
                Me.chk_Tabproc_AProc.Checked = True
            Else
                Me.chk_Tabproc_AProc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabProcdiario, 2, 1) = "1" Then
                Me.chk_Tabproc_MProc.Checked = True
            Else
                Me.chk_Tabproc_MProc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabProcdiario, 3, 1) = "1" Then
                Me.chk_Tabproc_BProc.Checked = True
            Else
                Me.chk_Tabproc_BProc.Checked = False
            End If

            If Mid(CLASE_PERFILESACCESO.xTabProcdiario, 4, 1) = "1" Then
                Me.chk_Tabproc_NProc.Checked = True
            Else
                Me.chk_Tabproc_NProc.Checked = False
            End If

            '------------------------------------------------------------

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarperfil")
            EVEN = Nothing

            PERFILESACCESO.dispose()
            PERFILESACCESO = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Desea un Nuevo registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Perfiles")

        If respuesta = 6 Then


            Try

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarperfiles")

                EVEN.bloquaerdesbloquear("nuevoperfil")
                Me.txtIdperfil.Text = (CLASE_GENERAL.maximo("Idperfil", "perfilesaccceso", CLASE_GENERAL.mensaje_error)) + 1
                EVEN = Nothing

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar el Perfil", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Perfiles")

        If respuesta = 6 Then

            Try

                PERFILESACCESO = New CLASE_PERFILESACCESO
                PERFILESACCESO.p_Idperfil = Me.txtIdperfil.Text
                PERFILESACCESO.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarperfiles")
                EVEN.bloquaerdesbloquear("nuevoperfil")

                'Cargamos los perfiles nuevamente
                CLASE_GENERAL.cargar_combo("perfilesacceso", Me.cmbPerfilAcceso, CLASE_GENERAL.mensaje_error)
                Me.cmbPerfilAcceso.SelectedValue = CStr(CInt(Me.txtIdperfil.Text) - 1)


                Me.txtIdperfil.Text = (CLASE_GENERAL.maximo("Idperfil", "perfilesaccceso", CLASE_GENERAL.mensaje_error)) + 1

                PERFILESACCESO.dispose()
                PERFILESACCESO = Nothing
                EVEN = Nothing

                MsgBox("Perfil Eliminado con Exito", MsgBoxStyle.OkOnly, "Perfiles")

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try
        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar Al Empleado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Empleados")

            If respuesta = 6 Then

                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProviderPerfil.BlinkRate = 200
                Me.ErrorProviderPerfil.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                If Me.txtnom_perf.Text.Length = 0 Then
                    ErrorProviderPerfil.SetError(Me.txtnom_perf, "Escriba el Nombre del Perfil")
                    MsgBox(ErrorProviderPerfil.GetError(Me.txtnom_perf), MsgBoxStyle.OkOnly, "Perfil")
                    Me.txtnom_perf.Focus()

                Else

                    '**************************** MODULO PARA INGRESO PERFIL *******************************

                    PERFILESACCESO = New CLASE_PERFILESACCESO

                    PERFILESACCESO.p_Idperfil = Me.txtIdperfil.Text
                    PERFILESACCESO.p_nom_perf = Me.txtnom_perf.Text


                    '**************** Tab Funciones

                    '1
                    If Me.chk_TabFunciones_TodasCitas.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '2
                    If Me.chk_TabFunciones_CitasDia.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '3
                    If Me.chk_TabFunciones_CitasFuturas.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '4
                    If Me.chk_TabFunciones_CitasSinAsistir.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '5
                    If Me.chk_TabFunciones_InfoAsignadoDia.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '6
                    If Me.chk_TabFunciones_Infogral.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '7
                    If Me.chk_TabFunciones_CumpleHoy.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '8
                    If Me.chk_TabFunciones_CumpleSem.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '9
                    If Me.chk_TabFunciones_CumpleMes.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '10
                    If Me.chk_TabFunciones_PacientesBq.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '11
                    If Me.chk_TabFunciones_BlqDia.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '12
                    If Me.chk_TabFunciones_BlqPaciente.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '13
                    If Me.chk_TabFunciones_EnviarMenCall.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '14
                    If Me.chk_TabFunciones_EnviarMenEmail.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '15
                    If Me.chk_TabFunciones_EnviarMenSMS.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '16
                    If Me.chk_TabFunciones_Calculadora.Checked = True Then
                        PERFILESACCESO.p_TabFunciones &= "1"
                    Else
                        PERFILESACCESO.p_TabFunciones &= "0"
                    End If

                    '**************** Tab Backup

                    '1
                    If Me.chk_TabBackup_Copia.Checked = True Then
                        PERFILESACCESO.p_TabBackups &= "1"
                    Else
                        PERFILESACCESO.p_TabBackups &= "0"
                    End If

                    '2
                    If Me.chk_TabBackup_Restaurar.Checked = True Then
                        PERFILESACCESO.p_TabBackups &= "1"
                    Else
                        PERFILESACCESO.p_TabBackups &= "0"
                    End If

                    '**************** Tab Ingreso Usuarios

                    '1
                    If Me.chk_TabCambioUsu_Cambio.Checked = True Then
                        PERFILESACCESO.p_TabCambioUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabCambioUsuarios &= "0"
                    End If

                    '**************** Tab Sincro

                    '1
                    If Me.chk_TabSincro_Sincro.Checked = True Then
                        PERFILESACCESO.p_TabSincro &= "1"
                    Else
                        PERFILESACCESO.p_TabSincro &= "0"
                    End If

                    '2
                    If Me.chk_TabSincro_SoporteRemoto.Checked = True Then
                        PERFILESACCESO.p_TabSincro &= "1"
                    Else
                        PERFILESACCESO.p_TabSincro &= "0"
                    End If

                    '3
                    If Me.chk_TabSincro_Actualizacion.Checked = True Then
                        PERFILESACCESO.p_TabSincro &= "1"
                    Else
                        PERFILESACCESO.p_TabSincro &= "0"
                    End If

                    '4
                    If Me.chk_TabSincro_Cirugia.Checked = True Then
                        PERFILESACCESO.p_TabSincro &= "1"
                    Else
                        PERFILESACCESO.p_TabSincro &= "0"
                    End If

                    '**************** Tab Menu Pacientes

                    '1
                    If Me.chk_TabMnuPac_Pac.Checked = True Then
                        PERFILESACCESO.p_TabMenuPacientes &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuPacientes &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuPac_NPac.Checked = True Then
                        PERFILESACCESO.p_TabMenuPacientes &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuPacientes &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuPac_BPac.Checked = True Then
                        PERFILESACCESO.p_TabMenuPacientes &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuPacientes &= "0"
                    End If

                    '**************** Tab Menu Doctores

                    '1
                    If Me.chk_TabMnuDoc_Doc.Checked = True Then
                        PERFILESACCESO.p_TabMenuDoctores &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuDoctores &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuDoc_NDoc.Checked = True Then
                        PERFILESACCESO.p_TabMenuDoctores &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuDoctores &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuDoc_BDoc.Checked = True Then
                        PERFILESACCESO.p_TabMenuDoctores &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuDoctores &= "0"
                    End If

                    '**************** Tab Menu Usuarios

                    '1
                    If Me.chk_TabMnuUsu_Usu.Checked = True Then
                        PERFILESACCESO.p_TabMenuUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuUsuarios &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuUsu_NUsu.Checked = True Then
                        PERFILESACCESO.p_TabMenuUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuUsuarios &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuUsu_BUsu.Checked = True Then
                        PERFILESACCESO.p_TabMenuUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuUsuarios &= "0"
                    End If


                    '**************** Tab Menu Entidades

                    '1
                    If Me.chk_TabMnuEnt_Ent.Checked = True Then
                        PERFILESACCESO.p_TabMenuEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuEntidades &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuEnt_NEnt.Checked = True Then
                        PERFILESACCESO.p_TabMenuEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuEntidades &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuEnt_BEnt.Checked = True Then
                        PERFILESACCESO.p_TabMenuEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuEntidades &= "0"
                    End If

                    '4
                    If Me.chk_TabMnuEnt_NProv.Checked = True Then
                        PERFILESACCESO.p_TabMenuEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuEntidades &= "0"
                    End If

                    '5
                    If Me.chk_TabMnuEnt_BProv.Checked = True Then
                        PERFILESACCESO.p_TabMenuEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuEntidades &= "0"
                    End If

                    '**************** Tab Menu Informes

                    '1
                    If Me.chk_TabMnuInf_Inf.Checked = True Then
                        PERFILESACCESO.p_TabMenuInformes &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuInformes &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuInf_InfV.Checked = True Then
                        PERFILESACCESO.p_TabMenuInformes &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuInformes &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuInf_ProcD.Checked = True Then
                        PERFILESACCESO.p_TabMenuInformes &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuInformes &= "0"
                    End If

                    '4
                    If Me.chk_TabMnuInf_Documentos.Checked = True Then
                        PERFILESACCESO.p_TabMenuInformes &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuInformes &= "0"
                    End If

                    '**************** Tab Menu Administracion

                    '1
                    If Me.chk_TabMnuAdm_Adm.Checked = True Then
                        PERFILESACCESO.p_TabMenuAdmon &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuAdmon &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuAdm_Aut.Checked = True Then
                        PERFILESACCESO.p_TabMenuAdmon &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuAdmon &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuAdm_Audito.Checked = True Then
                        PERFILESACCESO.p_TabMenuAdmon &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuAdmon &= "0"
                    End If

                    '4
                    If Me.chk_TabMnuAdm_Import.Checked = True Then
                        PERFILESACCESO.p_TabMenuAdmon &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuAdmon &= "0"
                    End If

                    '5
                    If Me.chk_TabMnuAdm_Config.Checked = True Then
                        PERFILESACCESO.p_TabMenuAdmon &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuAdmon &= "0"
                    End If

                    '6
                    If Me.chk_TabMnuAdm_Acceso.Checked = True Then
                        PERFILESACCESO.p_TabMenuAdmon &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuAdmon &= "0"
                    End If

                    '**************** Tab Menu Citas

                    '1
                    If Me.chk_TabMnuCitas_Citas.Checked = True Then
                        PERFILESACCESO.p_TabMenuCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuCitas &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuCitas_Reminder.Checked = True Then
                        PERFILESACCESO.p_TabMenuCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuCitas &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuCitas_BloquearCitas.Checked = True Then
                        PERFILESACCESO.p_TabMenuCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuCitas &= "0"
                    End If

                    '**************** Tab Menu Contab

                    '1
                    If Me.chk_TabMnuConta_Conta.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuConta_CEgreso.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '3
                    If Me.chk_TabMnuConta_RCaja.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '4
                    If Me.chk_TabMnuConta_Presupuesto.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '5
                    If Me.chk_TabMnuConta_Vprocedimiento.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '6
                    If Me.chk_TabMnuConta_ECuenta.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '7
                    If Me.chk_TabMnuConta_Gastos.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '8
                    If Me.chk_TabMnuConta_MDiario.Checked = True Then
                        PERFILESACCESO.p_TabMenuContab &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuContab &= "0"
                    End If

                    '**************** Tab Menu Varios

                    '1
                    If Me.chk_TabMnuVarios.Checked = True Then
                        PERFILESACCESO.p_TabMenuVarios &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuVarios &= "0"
                    End If

                    '2
                    If Me.chk_TabMnuVarios_Ilustraciones.Checked = True Then
                        PERFILESACCESO.p_TabMenuVarios &= "1"
                    Else
                        PERFILESACCESO.p_TabMenuVarios &= "0"
                    End If

                    '**************** Tab Menu Sheduler Superior

                    If Me.chk_TabSchSup_Cambio.Checked = True Then
                        PERFILESACCESO.p_TabSchedulerSup &= "1"
                    Else
                        PERFILESACCESO.p_TabSchedulerSup &= "0"
                    End If


                    If Me.chk_TabSchSup_BuscaHuellas.Checked = True Then
                        PERFILESACCESO.p_TabSchedulerSup &= "1"
                    Else
                        PERFILESACCESO.p_TabSchedulerSup &= "0"
                    End If

                    '**************** Tab Menu Sheduler

                    If Me.chk_TabSch_Control.Checked = True Then
                        PERFILESACCESO.p_TabScheduler &= "1"
                    Else
                        PERFILESACCESO.p_TabScheduler &= "0"
                    End If

                    If Me.chk_TabSch_SplittCitas.Checked = True Then
                        PERFILESACCESO.p_TabScheduler &= "1"
                    Else
                        PERFILESACCESO.p_TabScheduler &= "0"
                    End If

                   

                    '**************** Tab Citas

                    If Me.chk_TabCitas_ACita.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_MCita.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_ECita.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_ICita.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_TConsul.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_NotaCita.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_CitaCanc.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_CitaAsis.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_CambioDoc.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    If Me.chk_TabCitas_RangoCita.Checked = True Then
                        PERFILESACCESO.p_TabCitas &= "1"
                    Else
                        PERFILESACCESO.p_TabCitas &= "0"
                    End If

                    '**************** Tab Ficha

                    If Me.chk_TabFicha_EPac.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_BPac.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_EmailPac.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_SplitAgenda.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If


                    If Me.chk_TabFicha_ProcDiario.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_SMS.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_Odontograma.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_EstadoCuenta.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_Estudios.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    If Me.chk_TabFicha_HC.Checked = True Then
                        PERFILESACCESO.p_TabFicha &= "1"
                    Else
                        PERFILESACCESO.p_TabFicha &= "0"
                    End If

                    '**************** Tab Pacientes

                    If Me.chk_TabPac_APac.Checked = True Then
                        PERFILESACCESO.p_TabPacientes &= "1"
                    Else
                        PERFILESACCESO.p_TabPacientes &= "0"
                    End If

                    If Me.chk_TabPac_MPac.Checked = True Then
                        PERFILESACCESO.p_TabPacientes &= "1"
                    Else
                        PERFILESACCESO.p_TabPacientes &= "0"
                    End If

                    If Me.chk_TabPac_BPac.Checked = True Then
                        PERFILESACCESO.p_TabPacientes &= "1"
                    Else
                        PERFILESACCESO.p_TabPacientes &= "0"
                    End If

                    If Me.chk_TabPac_NPac.Checked = True Then
                        PERFILESACCESO.p_TabPacientes &= "1"
                    Else
                        PERFILESACCESO.p_TabPacientes &= "0"
                    End If

                    '**************** Tab Doctores

                    If Me.chk_TabDoc_ADoc.Checked = True Then
                        PERFILESACCESO.p_TabDoctores &= "1"
                    Else
                        PERFILESACCESO.p_TabDoctores &= "0"
                    End If

                    If Me.chk_TabDoc_MDoc.Checked = True Then
                        PERFILESACCESO.p_TabDoctores &= "1"
                    Else
                        PERFILESACCESO.p_TabDoctores &= "0"
                    End If

                    If Me.chk_TabDoc_BDoc.Checked = True Then
                        PERFILESACCESO.p_TabDoctores &= "1"
                    Else
                        PERFILESACCESO.p_TabDoctores &= "0"
                    End If

                    If Me.chk_TabDoc_NDoc.Checked = True Then
                        PERFILESACCESO.p_TabDoctores &= "1"
                    Else
                        PERFILESACCESO.p_TabDoctores &= "0"
                    End If

                    '**************** Tab Usuarios

                    If Me.chk_TabUsu_AUsu.Checked = True Then
                        PERFILESACCESO.p_TabUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabUsuarios &= "0"
                    End If

                    If Me.chk_TabUsu_MUsu.Checked = True Then
                        PERFILESACCESO.p_TabUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabUsuarios &= "0"
                    End If

                    If Me.chk_TabUsu_BUsu.Checked = True Then
                        PERFILESACCESO.p_TabUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabUsuarios &= "0"
                    End If

                    If Me.chk_TabUsu_NUsu.Checked = True Then
                        PERFILESACCESO.p_TabUsuarios &= "1"
                    Else
                        PERFILESACCESO.p_TabUsuarios &= "0"
                    End If

                    '**************** Tab Entidades

                    If Me.chk_TabEnt_AEnt.Checked = True Then
                        PERFILESACCESO.p_TabEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabEntidades &= "0"
                    End If

                    If Me.chk_TabEnt_MEnt.Checked = True Then
                        PERFILESACCESO.p_TabEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabEntidades &= "0"
                    End If

                    If Me.chk_TabEnt_BEnt.Checked = True Then
                        PERFILESACCESO.p_TabEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabEntidades &= "0"
                    End If

                    If Me.chk_TabEnt_NEnt.Checked = True Then
                        PERFILESACCESO.p_TabEntidades &= "1"
                    Else
                        PERFILESACCESO.p_TabEntidades &= "0"
                    End If

                    ' Tab Historias Clinicas
                    ' ----- General ------

                    If Me.chk_TabHC_Adicionarg.Checked = True Then
                        PERFILESACCESO.p_TabHC &= "1"
                    Else
                        PERFILESACCESO.p_TabHC &= "0"
                    End If

                    If Me.chk_TabHC_Modificarg.Checked = True Then
                        PERFILESACCESO.p_TabHC &= "1"
                    Else
                        PERFILESACCESO.p_TabHC &= "0"
                    End If

                    If Me.chk_TabHC_Desblg.Checked = True Then
                        PERFILESACCESO.p_TabHC &= "1"
                    Else
                        PERFILESACCESO.p_TabHC &= "0"
                    End If

                    If Me.chk_TabHC_Nuevag.Checked = True Then
                        PERFILESACCESO.p_TabHC &= "1"
                    Else
                        PERFILESACCESO.p_TabHC &= "0"
                    End If


                    'Tab Procedimientos diarios

                    If Me.chk_Tabproc_AProc.Checked = True Then
                        PERFILESACCESO.p_TabProcdiario &= "1"
                    Else
                        PERFILESACCESO.p_TabProcdiario &= "0"
                    End If

                    If Me.chk_Tabproc_MProc.Checked = True Then
                        PERFILESACCESO.p_TabProcdiario &= "1"
                    Else
                        PERFILESACCESO.p_TabProcdiario &= "0"
                    End If

                    If Me.chk_Tabproc_BProc.Checked = True Then
                        PERFILESACCESO.p_TabProcdiario &= "1"
                    Else
                        PERFILESACCESO.p_TabProcdiario &= "0"
                    End If

                    If Me.chk_Tabproc_NProc.Checked = True Then
                        PERFILESACCESO.p_TabProcdiario &= "1"
                    Else
                        PERFILESACCESO.p_TabProcdiario &= "0"
                    End If


                    '-----------------------------------------------------

                    'Insertamos en la base de datos
                    PERFILESACCESO.Modificar(CLASE_GENERAL.mensaje_error)
                    PERFILESACCESO.dispose() 'liberamos recursos
                    PERFILESACCESO = Nothing

                    'Cargamos los perfiles nuevamente
                    CLASE_GENERAL.cargar_combo("perfilesacceso", Me.cmbPerfilAcceso, CLASE_GENERAL.mensaje_error)
                    Me.cmbPerfilAcceso.SelectedValue = Me.txtIdperfil.Text

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editarperfil")
                    EVEN = Nothing

                    MessageBox.Show("Perfil Modificado con Exito", "Perfil")

                End If

            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub ubicarcontrol(ByVal control As Control)

        'Este codigo nos permite hacer la ubicacion de los controles centrandolos
        Dim proporcionh As Integer
        Dim proporcionv As Integer

        Dim locationcontrolx As Integer
        Dim locationcontroly As Integer

        'Calculamos el desplazamiento del control con el valor actual de la ventana restandole una constante que es el tamaño de una resolucion de Horizontal 1024 x Vertical 768 
        Dim desplazamiento As Integer
        desplazamiento = Round((CInt(My.Forms.mdiOrthoSoft.PanelFicha.Size.Width) - 538) / 2, 0)

        locationcontrolx = control.Location.X
        locationcontroly = control.Location.Y

        'Ubicamos el control sumandole la posisicion actual mas el desplazamiento calculado
        proporcionh = locationcontrolx + desplazamiento
        proporcionv = locationcontroly
        control.Location = New System.Drawing.Point(proporcionh, proporcionv)

    End Sub

    Public Sub ubicarcontroles()

        'Fotos Iniciales
        ubicarcontrol(Me.lblNivelesAcceso)
        ubicarcontrol(Me.GroupPerfilesAcceso)
        ubicarcontrol(Me.TreeAccesos)
        ubicarcontrol(Me.TabAccesos)
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmNivelesAccesos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        ubicarcontroles()

    End Sub

End Class