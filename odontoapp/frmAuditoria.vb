Imports CrystalDecisions.CrystalReports.Engine
Public Class frmAuditoria

    Public ctrl As Clase_control

    Private Sub frmAuditoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Clase_general.cargar_combo("empleados", Me.cmbEmpleados, Clase_general.mensaje_error)
            Me.cmbfecfin_aud.Value = Format(Now(), "short date")
            Me.cmbfecini_aud.Value = Format(Now(), "short date")

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try
    End Sub

    Private Sub btnAudSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAudSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnAudInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAudInforme.Click

        Try

            ctrl = New Clase_control

            ctrl.p_IdEmpleado = Me.cmbEmpleados.SelectedValue
            ctrl.p_fechaini = Format(Me.cmbfecini_aud.Value, "yyyy-MM-dd")
            ctrl.p_fechafin = Format(Me.cmbfecfin_aud.Value, "yyyy-MM-dd")

            If Me.rbtCitasAud.Checked = True Then

                ctrl.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

                ctrl.Seleccionar("citasasignadasmodificadas")

                Dim oRptAuditoriaCitas As New rptAuditoriaCitas()
                Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                oRptAuditoriaCitas.SetDataSource(Clase_general.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptAuditoriaCitas

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptAuditoriaCitas.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = Clase_general._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptAuditoriaCitas.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoDoctor.Text

                toTexto = oRptAuditoriaCitas.ReportDefinition.ReportObjects.Item("txtFechaIni")
                toTexto.Text = Format(Me.cmbfecini_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaCitas.ReportDefinition.ReportObjects.Item("txtFechaFin")
                toTexto.Text = Format(Me.cmbfecfin_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaCitas.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoUsuario.Text

                toTexto = oRptAuditoriaCitas.ReportDefinition.ReportObjects.Item("txtUsuario")
                toTexto.Text = Me.cmbEmpleados.Text

                toTexto = oRptAuditoriaCitas.ReportDefinition.ReportObjects.Item("txtIdEmpleado")
                toTexto.Text = Me.cmbEmpleados.SelectedValue

            End If

            If Me.rbtCitasEliAud.Checked = True Then

                ctrl.Seleccionar("citasborradas")

                Dim oRptAuditoriaCitasPacBorr As New rptAuditoriaCitasPacBorr
                Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                oRptAuditoriaCitasPacBorr.SetDataSource(Clase_general.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptAuditoriaCitasPacBorr

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptAuditoriaCitasPacBorr.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = Clase_general._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptAuditoriaCitasPacBorr.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoDoctor.Text

                toTexto = oRptAuditoriaCitasPacBorr.ReportDefinition.ReportObjects.Item("txtFechaIni")
                toTexto.Text = Format(Me.cmbfecini_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaCitasPacBorr.ReportDefinition.ReportObjects.Item("txtFechaFin")
                toTexto.Text = Format(Me.cmbfecfin_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaCitasPacBorr.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoUsuario.Text

                toTexto = oRptAuditoriaCitasPacBorr.ReportDefinition.ReportObjects.Item("txtUsuario")
                toTexto.Text = Me.cmbEmpleados.Text

                toTexto = oRptAuditoriaCitasPacBorr.ReportDefinition.ReportObjects.Item("txtIdEmpleado")
                toTexto.Text = Me.cmbEmpleados.SelectedValue

            End If

            If Me.rbtPacientesAud.Checked = True Then

                ctrl.Seleccionar("pacientes")

                Dim oRptAuditoriaPacientes As New rptAuditoriaPacientes()
                Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                oRptAuditoriaPacientes.SetDataSource(Clase_general.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptAuditoriaPacientes

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptAuditoriaPacientes.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = Clase_general._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptAuditoriaPacientes.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoDoctor.Text

                toTexto = oRptAuditoriaPacientes.ReportDefinition.ReportObjects.Item("txtFechaIni")
                toTexto.Text = Format(Me.cmbfecini_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaPacientes.ReportDefinition.ReportObjects.Item("txtFechaFin")
                toTexto.Text = Format(Me.cmbfecfin_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaPacientes.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoUsuario.Text

                toTexto = oRptAuditoriaPacientes.ReportDefinition.ReportObjects.Item("txtUsuario")
                toTexto.Text = Me.cmbEmpleados.Text

                toTexto = oRptAuditoriaPacientes.ReportDefinition.ReportObjects.Item("txtIdEmpleado")
                toTexto.Text = Me.cmbEmpleados.SelectedValue

            End If

            If Me.rbtInformesAud.Checked = True Then

                ctrl.Seleccionar("informes")

                Dim oRptAuditoriaInformes As New rptAuditoriaInformes
                Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                oRptAuditoriaInformes.SetDataSource(Clase_general.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptAuditoriaInformes

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptAuditoriaInformes.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = Clase_general._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptAuditoriaInformes.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoDoctor.Text

                toTexto = oRptAuditoriaInformes.ReportDefinition.ReportObjects.Item("txtFechaIni")
                toTexto.Text = Format(Me.cmbfecini_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaInformes.ReportDefinition.ReportObjects.Item("txtFechaFin")
                toTexto.Text = Format(Me.cmbfecfin_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaInformes.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoUsuario.Text

                toTexto = oRptAuditoriaInformes.ReportDefinition.ReportObjects.Item("txtUsuario")
                toTexto.Text = Me.cmbEmpleados.Text

                toTexto = oRptAuditoriaInformes.ReportDefinition.ReportObjects.Item("txtIdEmpleado")
                toTexto.Text = Me.cmbEmpleados.SelectedValue

            End If

            If Me.rbtCalendarioAud.Checked = True Then

                ctrl.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                ctrl.Seleccionar("calendario")

                Dim oRptAuditoriaCalendario As New rptAuditoriaCalendario
                Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                oRptAuditoriaCalendario.SetDataSource(Clase_general.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptAuditoriaCalendario

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptAuditoriaCalendario.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = Clase_general._razonsocial_cons

                'Definimos los otros items del Informe

                toTexto = oRptAuditoriaCalendario.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoDoctor.Text

                toTexto = oRptAuditoriaCalendario.ReportDefinition.ReportObjects.Item("txtFechaIni")
                toTexto.Text = Format(Me.cmbfecini_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaCalendario.ReportDefinition.ReportObjects.Item("txtFechaFin")
                toTexto.Text = Format(Me.cmbfecfin_aud.Value, "yyyy-MM-dd")

                toTexto = oRptAuditoriaCalendario.ReportDefinition.ReportObjects.Item("txtImpresoPor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoUsuario.Text

                toTexto = oRptAuditoriaCalendario.ReportDefinition.ReportObjects.Item("txtUsuario")
                toTexto.Text = Me.cmbEmpleados.Text

                toTexto = oRptAuditoriaCalendario.ReportDefinition.ReportObjects.Item("txtIdEmpleado")
                toTexto.Text = Me.cmbEmpleados.SelectedValue

            End If

            My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
            My.Forms.frmInformes.crvOrthosoft.Zoom(70)


            My.Forms.frmInformes.Show()
            My.Forms.frmInformes.Activate()

            Clase_general.xdt.Dispose()
            Clase_general.xdt = Nothing

            ctrl.dispose()
            ctrl = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

End Class