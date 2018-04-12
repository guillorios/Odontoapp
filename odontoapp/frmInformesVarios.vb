Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class frmInformesVarios

    Private CITA As CLASE_CITAS
    Private CTRL As CLASE_CONTROL

    Private fechaIni As String
    Private fechaFin As String


    Private Sub TreeInformes_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeInformes.AfterSelect

        If Me.TreeInformes.SelectedNode.Name = "Nodo18" Then

            Me.TabInformes.SelectedTabIndex = 0
            Me.TabInformes.Update()

        End If

    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btnInforme_csinasis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInforme_csinasis.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CITAS SIN ASISTIR")

            If respuesta = 6 Then

                CITA = New CLASE_CITAS

                Me.fechaIni = Format(Me.dateIni_csinasis.Value, "yyyy-MM-dd")
                Me.fechaFin = Format(Me.dateFin_csinasis.Value, "yyyy-MM-dd")

                CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag
                CITA.p_fecha = Me.fechaIni
                CITA.p_fecha2 = Me.fechaFin

                CITA.Seleccionar("informecitassinasistirconfecha")

                Dim oRptCitasSinAsistir As New rptCitasSinAsistir()
                Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                oRptCitasSinAsistir.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = oRptCitasSinAsistir

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe
                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtDoctor")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoDoctor.Text

                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtFechaIni")
                toTexto.Text = Me.fechaIni

                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtFechaFin")
                toTexto.Text = Me.fechaFin

                toTexto = oRptCitasSinAsistir.ReportDefinition.ReportObjects.Item("txtFecha_inf")
                toTexto.Text = Format(Date.Now, "Long Date")

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                '**************** Llenamos La Tabla Control *************************************

                CTRL = New CLASE_CONTROL
                CTRL.p_IdEmpleado = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                CTRL.p_IdTRegistro = 8 '8 Solicita Informe
                CTRL.p_Idproceso = 4

                CTRL.Insertar(CLASE_GENERAL.mensaje_error)
                CTRL.dispose()
                CTRL = Nothing

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CITA.dispose()
                CITA = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub frmInformesVarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            'Inicializamos los controles de las fechas

            Me.TabInformes.SelectedTabIndex = 0
            Me.TabInformes.Update()

            Me.dateIni_csinasis.Value = Date.Now
            Me.dateFin_csinasis.Value = Date.Now


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia
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

        'lblTituloVentana
        ubicarcontrol(Me.TreeInformes)
        ubicarcontrol(Me.TabInformes)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.lblTituloVentana)

    End Sub


    Private Sub frmInformesVarios_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

End Class