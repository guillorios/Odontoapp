<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiOrthoSoft
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiOrthoSoft))
        Me.PanelMenuPrincipalSup = New DevComponents.DotNetBar.RibbonControl
        Me.PanelFunciones = New DevComponents.DotNetBar.RibbonPanel
        Me.PnlActivoDoctor = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblActivoDoctor = New DevComponents.DotNetBar.LabelX
        Me.PnlActivoPaciente = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblActivoPaciente = New DevComponents.DotNetBar.LabelX
        Me.RibbonBar1 = New DevComponents.DotNetBar.RibbonBar
        Me.btnCalculadora = New DevComponents.DotNetBar.ButtonItem
        Me.BarAutomaticos = New DevComponents.DotNetBar.RibbonBar
        Me.btnf11EnvioTel = New DevComponents.DotNetBar.ButtonItem
        Me.btnf12EnvioEmail = New DevComponents.DotNetBar.ButtonItem
        Me.btnSMS = New DevComponents.DotNetBar.ButtonItem
        Me.BarBloqueos = New DevComponents.DotNetBar.RibbonBar
        Me.btnf9BloqueoDia = New DevComponents.DotNetBar.ButtonItem
        Me.btnf10BloqueoPac = New DevComponents.DotNetBar.ButtonItem
        Me.BarInformesPacientes = New DevComponents.DotNetBar.RibbonBar
        Me.btnf5InfGeneral = New DevComponents.DotNetBar.ButtonItem
        Me.btnf6InfCumpleHoy = New DevComponents.DotNetBar.ButtonItem
        Me.btnf7InfCumpleSemana = New DevComponents.DotNetBar.ButtonItem
        Me.btnf8InfCumpleMes = New DevComponents.DotNetBar.ButtonItem
        Me.btnInfPacBloq = New DevComponents.DotNetBar.ButtonItem
        Me.BarInformesCitas = New DevComponents.DotNetBar.RibbonBar
        Me.btnf1InfPorPaciente = New DevComponents.DotNetBar.ButtonItem
        Me.btnf2Infpordia = New DevComponents.DotNetBar.ButtonItem
        Me.btnf3InfFuturas = New DevComponents.DotNetBar.ButtonItem
        Me.btnf4InfSinAsistir = New DevComponents.DotNetBar.ButtonItem
        Me.btnInfAsignadoDia = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel
        Me.btnCirugia = New DevComponents.DotNetBar.ButtonX
        Me.btnActualizacion = New DevComponents.DotNetBar.ButtonX
        Me.btnSoporteRemoto = New DevComponents.DotNetBar.ButtonX
        Me.btnSincronizar = New DevComponents.DotNetBar.ButtonX
        Me.PanelConv = New DevComponents.DotNetBar.RibbonPanel
        Me.GroupItemsCitas = New System.Windows.Forms.GroupBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupItemsPacientes = New System.Windows.Forms.GroupBox
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelUsuarios = New DevComponents.DotNetBar.RibbonPanel
        Me.PnlActivoUsuario = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblActivoUsuario = New DevComponents.DotNetBar.LabelX
        Me.btnUsuSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.PanelBackups = New DevComponents.DotNetBar.RibbonPanel
        Me.BarBackups = New DevComponents.DotNetBar.RibbonBar
        Me.btnBackup = New DevComponents.DotNetBar.ButtonItem
        Me.btnRestaurarBackup = New DevComponents.DotNetBar.ButtonItem
        Me.PanelContenedorSuperior = New DevComponents.DotNetBar.RibbonPanel
        Me.TabFunciones = New DevComponents.DotNetBar.RibbonTabItem
        Me.TabSeguridad = New DevComponents.DotNetBar.RibbonTabItem
        Me.TabUsuario = New DevComponents.DotNetBar.RibbonTabItem
        Me.TabConv = New DevComponents.DotNetBar.RibbonTabItem
        Me.RibbonTabItem1 = New DevComponents.DotNetBar.RibbonTabItem
        Me.lblFechaHoy = New DevComponents.DotNetBar.LabelItem
        Me.txtfechahoy = New DevComponents.DotNetBar.LabelItem
        Me.btnInicio = New DevComponents.DotNetBar.Office2007StartButton
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem
        Me.PanelPrincipalDerecho = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.ScheduleOrhosoft = New Janus.Windows.Schedule.Schedule
        Me.ImageScheduler = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx
        Me.btnBuscarHuella = New DevComponents.DotNetBar.ButtonX
        Me.btnAppointment = New DevComponents.DotNetBar.ButtonX
        Me.ExpandableScheduler = New DevComponents.DotNetBar.ExpandableSplitter
        Me.PanelOpcScheduler = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.FichasOpcionesCitas = New DevComponents.DotNetBar.TabControl
        Me.TabPanelRegistro = New DevComponents.DotNetBar.TabControlPanel
        Me.VerificationControl = New DPFP.Gui.Verification.VerificationControl
        Me.btnCitaImprimir = New DevComponents.DotNetBar.ButtonX
        Me.btnCitaModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnCitaEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnCitaAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.TabRegistro = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabPanelNotaCita = New DevComponents.DotNetBar.TabControlPanel
        Me.GroupNotaCita = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnCitaModificar2 = New DevComponents.DotNetBar.ButtonX
        Me.txtnotacita = New System.Windows.Forms.RichTextBox
        Me.TabNotaCita = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabPanelCitas = New DevComponents.DotNetBar.TabControlPanel
        Me.GroupAsistio = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtAsistioSi = New System.Windows.Forms.RadioButton
        Me.rbtAsistioNo = New System.Windows.Forms.RadioButton
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GroupCitaCancelada = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtCanceladaNo = New System.Windows.Forms.RadioButton
        Me.rbtCanceladaSi = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabCitas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabPanelDoctor = New DevComponents.DotNetBar.TabControlPanel
        Me.btnDocSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.GroupDoctor = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbDoctores = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.TabDoctor = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabPanelAgenda = New DevComponents.DotNetBar.TabControlPanel
        Me.GroupAgenda = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbt15min = New System.Windows.Forms.RadioButton
        Me.rbt30min = New System.Windows.Forms.RadioButton
        Me.rbt10min = New System.Windows.Forms.RadioButton
        Me.rbt5min = New System.Windows.Forms.RadioButton
        Me.TabAgenda = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabPanelConsulta = New DevComponents.DotNetBar.TabControlPanel
        Me.GroupTipoConsulta = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbTipoConsulta = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblTipoConsulta = New DevComponents.DotNetBar.LabelX
        Me.TabConsulta = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnEnvioSMSPersonalizado = New DevComponents.DotNetBar.ButtonX
        Me.btnEstadoCuenta = New DevComponents.DotNetBar.ButtonX
        Me.btnPacOdontograma = New DevComponents.DotNetBar.ButtonX
        Me.MenuPrincipal = New DevComponents.DotNetBar.ExplorerBar
        Me.ExplorerPacientes = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuNuevoPaciente = New DevComponents.DotNetBar.ButtonItem
        Me.mnuBuscarPaciente = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerDoctores = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuNuevoDoctor = New DevComponents.DotNetBar.ButtonItem
        Me.mnuBuscarDoctor = New DevComponents.DotNetBar.ButtonItem
        Me.mnuHorarioDoctores = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerUsuarios = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuNuevoUsuario = New DevComponents.DotNetBar.ButtonItem
        Me.mnuBuscarUsuario = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerEntidades = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuNuevaEntidad = New DevComponents.DotNetBar.ButtonItem
        Me.mnuBuscarEntidad = New DevComponents.DotNetBar.ButtonItem
        Me.mnuProveedores = New DevComponents.DotNetBar.ButtonItem
        Me.mnuBuscarProveedores = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerInformes = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuGereradorInformes = New DevComponents.DotNetBar.ButtonItem
        Me.mnuProcedimientoDiario = New DevComponents.DotNetBar.ButtonItem
        Me.mnuDocumentos = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerAdministracion = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuAutenticacion = New DevComponents.DotNetBar.ButtonItem
        Me.mnuInfAuditoria = New DevComponents.DotNetBar.ButtonItem
        Me.mnuImporBD = New DevComponents.DotNetBar.ButtonItem
        Me.mnuConfigIni = New DevComponents.DotNetBar.ButtonItem
        Me.mnuNivelAcceso = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerCitas = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuReminderCitas = New DevComponents.DotNetBar.ButtonItem
        Me.mnuBloqDesCalendario = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerContab = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuRcaja = New DevComponents.DotNetBar.ButtonItem
        Me.mnuEgreso = New DevComponents.DotNetBar.ButtonItem
        Me.mnuPresupuesto = New DevComponents.DotNetBar.ButtonItem
        Me.mnuItems = New DevComponents.DotNetBar.ButtonItem
        Me.mnuEstadoCuenta = New DevComponents.DotNetBar.ButtonItem
        Me.mnuGastos = New DevComponents.DotNetBar.ButtonItem
        Me.mnuMovimientoDiario = New DevComponents.DotNetBar.ButtonItem
        Me.ExplorerVarios = New DevComponents.DotNetBar.ExplorerBarGroupItem
        Me.mnuIlustraciones = New DevComponents.DotNetBar.ButtonItem
        Me.txtTopeCita = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnCalModificar2 = New DevComponents.DotNetBar.ButtonX
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.btnCalAdicionar2 = New DevComponents.DotNetBar.ButtonX
        Me.PanelMenuPrincipalIzq = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnRetrocedermes = New DevComponents.DotNetBar.ButtonX
        Me.btnAvanzarMes = New DevComponents.DotNetBar.ButtonX
        Me.btnOpCalendar = New DevComponents.DotNetBar.ButtonX
        Me.CalOrthosoft = New AxMonthLib.AxctMonth
        Me.PanelCitasHoy = New DevComponents.DotNetBar.PanelEx
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblTotalPacientes = New DevComponents.DotNetBar.LabelX
        Me.lblTituloPacientes = New DevComponents.DotNetBar.LabelX
        Me.lblPacientes = New DevComponents.DotNetBar.LabelX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.clcEndTime = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.clcStartTime = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.PanelFicha = New DevComponents.DotNetBar.PanelEx
        Me.PanelConfigCal = New DevComponents.DotNetBar.PanelEx
        Me.txtIdCalendario = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnCalEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnCalModificar = New DevComponents.DotNetBar.ButtonX
        Me.txtDiaLibre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblDiaLibre = New DevComponents.DotNetBar.LabelX
        Me.GroupTBloqueoDia = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtModificado = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtNoLaborable = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtFestivo = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.rbtModificado = New System.Windows.Forms.RadioButton
        Me.rbtNolaborable = New System.Windows.Forms.RadioButton
        Me.rbtFestivo = New System.Windows.Forms.RadioButton
        Me.txtDiaSeleccionado = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblDiaSeleccionado = New DevComponents.DotNetBar.LabelX
        Me.GroupRangoAgenda = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtConfig5min = New System.Windows.Forms.RadioButton
        Me.rbtConfig30min = New System.Windows.Forms.RadioButton
        Me.rbtConfig15min = New System.Windows.Forms.RadioButton
        Me.rbtConfig10min = New System.Windows.Forms.RadioButton
        Me.lblConfigCal = New DevComponents.DotNetBar.LabelX
        Me.GroupHorarioLaboral = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblInicio = New DevComponents.DotNetBar.LabelX
        Me.lblFin = New DevComponents.DotNetBar.LabelX
        Me.EndTime = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.StartTime = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.btnCalAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.btnEstudiosPac = New DevComponents.DotNetBar.ButtonX
        Me.ExpandableCalendario = New DevComponents.DotNetBar.ExpandableSplitter
        Me.lblCodigo = New DevComponents.DotNetBar.LabelX
        Me.lblNHclinica = New DevComponents.DotNetBar.LabelX
        Me.txtnhistoria_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtId_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtEmail_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblEmail = New DevComponents.DotNetBar.LabelX
        Me.lblCelular = New DevComponents.DotNetBar.LabelX
        Me.txtCelular_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTelCasa = New DevComponents.DotNetBar.LabelX
        Me.txtTelCasa_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtReferido_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblRemitido = New DevComponents.DotNetBar.LabelX
        Me.txtNombre_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblNombre = New DevComponents.DotNetBar.LabelX
        Me.pbxFoto_ficha = New System.Windows.Forms.PictureBox
        Me.btnBuscar = New DevComponents.DotNetBar.ButtonX
        Me.btnEditarFicha = New DevComponents.DotNetBar.ButtonX
        Me.btnEnvioEmail = New DevComponents.DotNetBar.ButtonX
        Me.gpProximaCita = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtproced_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtHFIN_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtHINI_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtProxCita_ficha = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnProcedimiento = New DevComponents.DotNetBar.ButtonX
        Me.btnHistoriaClinica = New DevComponents.DotNetBar.ButtonX
        Me.btnHCOrtodoncia = New DevComponents.DotNetBar.ButtonItem
        Me.btnHCOrtodoncia2 = New DevComponents.DotNetBar.ButtonItem
        Me.btnHCOrtodoncia3 = New DevComponents.DotNetBar.ButtonItem
        Me.btnHCGeneral = New DevComponents.DotNetBar.ButtonItem
        Me.txtIdcita = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtIdPacienteTagScheduler = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.OpenFileBackup = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileBackup = New System.Windows.Forms.SaveFileDialog
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem
        Me.PanelPrincipalIzquierdo = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.PanelTopeCitas = New DevComponents.DotNetBar.PanelEx
        Me.ExpandableNumcitas = New DevComponents.DotNetBar.ExpandableSplitter
        Me.ExpandableNPacientes = New DevComponents.DotNetBar.ExpandableSplitter
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.DefaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.SuperTooltip = New DevComponents.DotNetBar.SuperTooltip
        Me.ExpandableAgenda = New DevComponents.DotNetBar.ExpandableSplitter
        Me.txtIdunidad = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnSkype = New DevComponents.DotNetBar.ButtonX
        Me.PanelMenuPrincipalSup.SuspendLayout()
        Me.PanelFunciones.SuspendLayout()
        Me.PnlActivoDoctor.SuspendLayout()
        Me.PnlActivoPaciente.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.PanelConv.SuspendLayout()
        Me.GroupItemsCitas.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupItemsPacientes.SuspendLayout()
        Me.PanelUsuarios.SuspendLayout()
        Me.PnlActivoUsuario.SuspendLayout()
        Me.PanelBackups.SuspendLayout()
        Me.PanelPrincipalDerecho.SuspendLayout()
        CType(Me.ScheduleOrhosoft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelOpcScheduler.SuspendLayout()
        CType(Me.FichasOpcionesCitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FichasOpcionesCitas.SuspendLayout()
        Me.TabPanelRegistro.SuspendLayout()
        Me.TabPanelNotaCita.SuspendLayout()
        Me.GroupNotaCita.SuspendLayout()
        Me.TabPanelCitas.SuspendLayout()
        Me.GroupAsistio.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCitaCancelada.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPanelDoctor.SuspendLayout()
        Me.GroupDoctor.SuspendLayout()
        Me.TabPanelAgenda.SuspendLayout()
        Me.GroupAgenda.SuspendLayout()
        Me.TabPanelConsulta.SuspendLayout()
        Me.GroupTipoConsulta.SuspendLayout()
        CType(Me.MenuPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenuPrincipalIzq.SuspendLayout()
        CType(Me.CalOrthosoft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCitasHoy.SuspendLayout()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.PanelFicha.SuspendLayout()
        Me.PanelConfigCal.SuspendLayout()
        Me.GroupTBloqueoDia.SuspendLayout()
        Me.GroupRangoAgenda.SuspendLayout()
        Me.GroupHorarioLaboral.SuspendLayout()
        CType(Me.pbxFoto_ficha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpProximaCita.SuspendLayout()
        Me.PanelPrincipalIzquierdo.SuspendLayout()
        Me.PanelTopeCitas.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuPrincipalSup
        '
        Me.PanelMenuPrincipalSup.CaptionVisible = True
        Me.PanelMenuPrincipalSup.Controls.Add(Me.PanelFunciones)
        Me.PanelMenuPrincipalSup.Controls.Add(Me.RibbonPanel1)
        Me.PanelMenuPrincipalSup.Controls.Add(Me.PanelConv)
        Me.PanelMenuPrincipalSup.Controls.Add(Me.PanelUsuarios)
        Me.PanelMenuPrincipalSup.Controls.Add(Me.PanelBackups)
        Me.PanelMenuPrincipalSup.Controls.Add(Me.PanelContenedorSuperior)
        Me.PanelMenuPrincipalSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuPrincipalSup.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.TabFunciones, Me.TabSeguridad, Me.TabUsuario, Me.TabConv, Me.RibbonTabItem1, Me.lblFechaHoy, Me.txtfechahoy})
        Me.PanelMenuPrincipalSup.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.PanelMenuPrincipalSup.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuPrincipalSup.Name = "PanelMenuPrincipalSup"
        Me.PanelMenuPrincipalSup.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.PanelMenuPrincipalSup.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnInicio})
        Me.PanelMenuPrincipalSup.Size = New System.Drawing.Size(1036, 130)
        Me.PanelMenuPrincipalSup.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelMenuPrincipalSup.TabGroupHeight = 14
        Me.PanelMenuPrincipalSup.TabIndex = 0
        Me.PanelMenuPrincipalSup.Text = "11"
        '
        'PanelFunciones
        '
        Me.PanelFunciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelFunciones.Controls.Add(Me.PnlActivoDoctor)
        Me.PanelFunciones.Controls.Add(Me.PnlActivoPaciente)
        Me.PanelFunciones.Controls.Add(Me.RibbonBar1)
        Me.PanelFunciones.Controls.Add(Me.BarAutomaticos)
        Me.PanelFunciones.Controls.Add(Me.BarBloqueos)
        Me.PanelFunciones.Controls.Add(Me.BarInformesPacientes)
        Me.PanelFunciones.Controls.Add(Me.BarInformesCitas)
        Me.PanelFunciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFunciones.Location = New System.Drawing.Point(0, 65)
        Me.PanelFunciones.Name = "PanelFunciones"
        Me.PanelFunciones.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelFunciones.Size = New System.Drawing.Size(1036, 63)
        Me.PanelFunciones.TabIndex = 5
        '
        'PnlActivoDoctor
        '
        Me.PnlActivoDoctor.BackColor = System.Drawing.Color.Transparent
        Me.PnlActivoDoctor.CanvasColor = System.Drawing.SystemColors.Control
        Me.PnlActivoDoctor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PnlActivoDoctor.Controls.Add(Me.lblActivoDoctor)
        Me.PnlActivoDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlActivoDoctor.Location = New System.Drawing.Point(830, 5)
        Me.PnlActivoDoctor.Name = "PnlActivoDoctor"
        Me.PnlActivoDoctor.Size = New System.Drawing.Size(197, 50)
        '
        '
        '
        Me.PnlActivoDoctor.Style.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.PnlActivoDoctor.Style.BackColorGradientAngle = 90
        Me.PnlActivoDoctor.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.PnlActivoDoctor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground
        Me.PnlActivoDoctor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoDoctor.Style.BorderBottomWidth = 1
        Me.PnlActivoDoctor.Style.BorderColor = System.Drawing.Color.Blue
        Me.PnlActivoDoctor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoDoctor.Style.BorderLeftWidth = 1
        Me.PnlActivoDoctor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoDoctor.Style.BorderRightWidth = 1
        Me.PnlActivoDoctor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoDoctor.Style.BorderTopWidth = 1
        Me.PnlActivoDoctor.Style.CornerDiameter = 4
        Me.PnlActivoDoctor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PnlActivoDoctor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.PnlActivoDoctor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PnlActivoDoctor.TabIndex = 5
        Me.PnlActivoDoctor.Text = "DOCTOR ACTIVO"
        '
        'lblActivoDoctor
        '
        Me.lblActivoDoctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActivoDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivoDoctor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblActivoDoctor.Location = New System.Drawing.Point(0, 0)
        Me.lblActivoDoctor.Name = "lblActivoDoctor"
        Me.lblActivoDoctor.Size = New System.Drawing.Size(191, 29)
        Me.lblActivoDoctor.TabIndex = 0
        Me.lblActivoDoctor.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PnlActivoPaciente
        '
        Me.PnlActivoPaciente.BackColor = System.Drawing.Color.Transparent
        Me.PnlActivoPaciente.CanvasColor = System.Drawing.Color.Empty
        Me.PnlActivoPaciente.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PnlActivoPaciente.Controls.Add(Me.lblActivoPaciente)
        Me.PnlActivoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlActivoPaciente.Location = New System.Drawing.Point(603, 5)
        Me.PnlActivoPaciente.Name = "PnlActivoPaciente"
        Me.PnlActivoPaciente.Size = New System.Drawing.Size(221, 50)
        '
        '
        '
        Me.PnlActivoPaciente.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlActivoPaciente.Style.BackColor2 = System.Drawing.Color.LightSkyBlue
        Me.PnlActivoPaciente.Style.BackColorGradientAngle = 90
        Me.PnlActivoPaciente.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.PnlActivoPaciente.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center
        Me.PnlActivoPaciente.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoPaciente.Style.BorderBottomWidth = 1
        Me.PnlActivoPaciente.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground
        Me.PnlActivoPaciente.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoPaciente.Style.BorderLeftWidth = 1
        Me.PnlActivoPaciente.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoPaciente.Style.BorderRightWidth = 1
        Me.PnlActivoPaciente.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Dot
        Me.PnlActivoPaciente.Style.BorderTopWidth = 1
        Me.PnlActivoPaciente.Style.CornerDiameter = 4
        Me.PnlActivoPaciente.Style.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal
        Me.PnlActivoPaciente.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.PnlActivoPaciente.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PnlActivoPaciente.TabIndex = 4
        Me.PnlActivoPaciente.Text = "PACIENTE ACTIVO"
        '
        'lblActivoPaciente
        '
        Me.lblActivoPaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblActivoPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActivoPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivoPaciente.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblActivoPaciente.Location = New System.Drawing.Point(0, 0)
        Me.lblActivoPaciente.Name = "lblActivoPaciente"
        Me.lblActivoPaciente.Size = New System.Drawing.Size(215, 29)
        Me.lblActivoPaciente.TabIndex = 0
        Me.lblActivoPaciente.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'RibbonBar1
        '
        Me.RibbonBar1.AutoOverflowEnabled = True
        Me.RibbonBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RibbonBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCalculadora})
        Me.RibbonBar1.Location = New System.Drawing.Point(539, 0)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(41, 60)
        Me.RibbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonBar1.TabIndex = 6
        Me.RibbonBar1.Text = "CALC"
        '
        'btnCalculadora
        '
        Me.btnCalculadora.Image = CType(resources.GetObject("btnCalculadora.Image"), System.Drawing.Image)
        Me.btnCalculadora.ImagePaddingHorizontal = 8
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Text = "CALCULADORA"
        Me.btnCalculadora.Tooltip = "CALCULADORA"
        '
        'BarAutomaticos
        '
        Me.BarAutomaticos.AutoOverflowEnabled = True
        Me.BarAutomaticos.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarAutomaticos.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnf11EnvioTel, Me.btnf12EnvioEmail, Me.btnSMS})
        Me.BarAutomaticos.Location = New System.Drawing.Point(434, 0)
        Me.BarAutomaticos.Name = "BarAutomaticos"
        Me.BarAutomaticos.Size = New System.Drawing.Size(105, 60)
        Me.BarAutomaticos.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.BarAutomaticos.TabIndex = 3
        Me.BarAutomaticos.Text = "AUTOMATICOS"
        '
        'btnf11EnvioTel
        '
        Me.btnf11EnvioTel.Image = CType(resources.GetObject("btnf11EnvioTel.Image"), System.Drawing.Image)
        Me.btnf11EnvioTel.ImagePaddingHorizontal = 8
        Me.btnf11EnvioTel.Name = "btnf11EnvioTel"
        Me.btnf11EnvioTel.Text = "ENVIAR MENSAJE TEL"
        Me.btnf11EnvioTel.Tooltip = "F11-ENVIAR MENSAJE TEL"
        '
        'btnf12EnvioEmail
        '
        Me.btnf12EnvioEmail.Image = CType(resources.GetObject("btnf12EnvioEmail.Image"), System.Drawing.Image)
        Me.btnf12EnvioEmail.ImagePaddingHorizontal = 8
        Me.btnf12EnvioEmail.Name = "btnf12EnvioEmail"
        Me.btnf12EnvioEmail.Text = "ENVIAR EMAILS"
        Me.btnf12EnvioEmail.Tooltip = "F12-ENVIAR EMAILS"
        '
        'btnSMS
        '
        Me.btnSMS.Image = CType(resources.GetObject("btnSMS.Image"), System.Drawing.Image)
        Me.btnSMS.ImagePaddingHorizontal = 8
        Me.btnSMS.Name = "btnSMS"
        Me.btnSMS.Text = "ENVIAR SMS"
        Me.btnSMS.Tooltip = "ENVIAR SMS"
        '
        'BarBloqueos
        '
        Me.BarBloqueos.AutoOverflowEnabled = True
        Me.BarBloqueos.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarBloqueos.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnf9BloqueoDia, Me.btnf10BloqueoPac})
        Me.BarBloqueos.Location = New System.Drawing.Point(361, 0)
        Me.BarBloqueos.Name = "BarBloqueos"
        Me.BarBloqueos.Size = New System.Drawing.Size(73, 60)
        Me.BarBloqueos.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.BarBloqueos.TabIndex = 2
        Me.BarBloqueos.Text = "BLOQUEOS"
        '
        'btnf9BloqueoDia
        '
        Me.btnf9BloqueoDia.Image = CType(resources.GetObject("btnf9BloqueoDia.Image"), System.Drawing.Image)
        Me.btnf9BloqueoDia.ImagePaddingHorizontal = 8
        Me.btnf9BloqueoDia.Name = "btnf9BloqueoDia"
        Me.btnf9BloqueoDia.Text = "DIA"
        Me.btnf9BloqueoDia.Tooltip = "F9-BLOQUEAR DIA"
        '
        'btnf10BloqueoPac
        '
        Me.btnf10BloqueoPac.Image = CType(resources.GetObject("btnf10BloqueoPac.Image"), System.Drawing.Image)
        Me.btnf10BloqueoPac.ImagePaddingHorizontal = 8
        Me.btnf10BloqueoPac.Name = "btnf10BloqueoPac"
        Me.btnf10BloqueoPac.Text = "PACIENTE"
        Me.btnf10BloqueoPac.Tooltip = "F10-BLOQUEAR PACIENTE"
        '
        'BarInformesPacientes
        '
        Me.BarInformesPacientes.AutoOverflowEnabled = True
        Me.BarInformesPacientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarInformesPacientes.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnf5InfGeneral, Me.btnf6InfCumpleHoy, Me.btnf7InfCumpleSemana, Me.btnf8InfCumpleMes, Me.btnInfPacBloq})
        Me.BarInformesPacientes.Location = New System.Drawing.Point(171, 0)
        Me.BarInformesPacientes.Name = "BarInformesPacientes"
        Me.BarInformesPacientes.Size = New System.Drawing.Size(190, 60)
        Me.BarInformesPacientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.BarInformesPacientes.TabIndex = 1
        Me.BarInformesPacientes.Text = "INFORMES PACIENTES"
        '
        'btnf5InfGeneral
        '
        Me.btnf5InfGeneral.Image = CType(resources.GetObject("btnf5InfGeneral.Image"), System.Drawing.Image)
        Me.btnf5InfGeneral.ImagePaddingHorizontal = 8
        Me.btnf5InfGeneral.Name = "btnf5InfGeneral"
        Me.btnf5InfGeneral.Text = "GENERAL"
        Me.btnf5InfGeneral.Tooltip = "F5-INFORME GENERAL DE PACIENTES"
        '
        'btnf6InfCumpleHoy
        '
        Me.btnf6InfCumpleHoy.Image = CType(resources.GetObject("btnf6InfCumpleHoy.Image"), System.Drawing.Image)
        Me.btnf6InfCumpleHoy.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnf6InfCumpleHoy.ImagePaddingHorizontal = 8
        Me.btnf6InfCumpleHoy.Name = "btnf6InfCumpleHoy"
        Me.btnf6InfCumpleHoy.Text = "CUMPLEAÑOS HOY"
        Me.btnf6InfCumpleHoy.Tooltip = "F6-PACIENTES CUMPLEAÑOS HOY"
        '
        'btnf7InfCumpleSemana
        '
        Me.btnf7InfCumpleSemana.Image = CType(resources.GetObject("btnf7InfCumpleSemana.Image"), System.Drawing.Image)
        Me.btnf7InfCumpleSemana.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnf7InfCumpleSemana.ImagePaddingHorizontal = 8
        Me.btnf7InfCumpleSemana.Name = "btnf7InfCumpleSemana"
        Me.btnf7InfCumpleSemana.Text = "CUMPLEAÑOS SEMANA"
        Me.btnf7InfCumpleSemana.Tooltip = "F7-PACIENTES CUMPLEAÑOS SEMANA"
        '
        'btnf8InfCumpleMes
        '
        Me.btnf8InfCumpleMes.Image = CType(resources.GetObject("btnf8InfCumpleMes.Image"), System.Drawing.Image)
        Me.btnf8InfCumpleMes.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnf8InfCumpleMes.ImagePaddingHorizontal = 8
        Me.btnf8InfCumpleMes.Name = "btnf8InfCumpleMes"
        Me.btnf8InfCumpleMes.Text = "CUMPLEAÑOS MES"
        Me.btnf8InfCumpleMes.Tooltip = "F8-PACIENTES CUMPLEAÑOS MES"
        '
        'btnInfPacBloq
        '
        Me.btnInfPacBloq.Image = CType(resources.GetObject("btnInfPacBloq.Image"), System.Drawing.Image)
        Me.btnInfPacBloq.ImagePaddingHorizontal = 8
        Me.btnInfPacBloq.Name = "btnInfPacBloq"
        Me.btnInfPacBloq.Text = "PACIENTES BLOQUEADOS"
        Me.btnInfPacBloq.Tooltip = "PACIENTES BLOQUEADOS"
        '
        'BarInformesCitas
        '
        Me.BarInformesCitas.AutoOverflowEnabled = True
        Me.BarInformesCitas.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarInformesCitas.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnf1InfPorPaciente, Me.btnf2Infpordia, Me.btnf3InfFuturas, Me.btnf4InfSinAsistir, Me.btnInfAsignadoDia})
        Me.BarInformesCitas.Location = New System.Drawing.Point(3, 0)
        Me.BarInformesCitas.Name = "BarInformesCitas"
        Me.BarInformesCitas.Size = New System.Drawing.Size(168, 60)
        Me.BarInformesCitas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.BarInformesCitas.TabIndex = 0
        Me.BarInformesCitas.Text = "INFORMES CITAS"
        '
        'btnf1InfPorPaciente
        '
        Me.btnf1InfPorPaciente.Image = CType(resources.GetObject("btnf1InfPorPaciente.Image"), System.Drawing.Image)
        Me.btnf1InfPorPaciente.ImagePaddingHorizontal = 8
        Me.btnf1InfPorPaciente.Name = "btnf1InfPorPaciente"
        Me.SuperTooltip.SetSuperTooltip(Me.btnf1InfPorPaciente, New DevComponents.DotNetBar.SuperTooltipInfo("F1 - Todas la Citas por Paciente", "Odontoapp", "Visualiza todas la citas que un paciente haya generado desde su registro.", CType(resources.GetObject("btnf1InfPorPaciente.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        '
        'btnf2Infpordia
        '
        Me.btnf2Infpordia.Image = CType(resources.GetObject("btnf2Infpordia.Image"), System.Drawing.Image)
        Me.btnf2Infpordia.ImagePaddingHorizontal = 8
        Me.btnf2Infpordia.Name = "btnf2Infpordia"
        Me.SuperTooltip.SetSuperTooltip(Me.btnf2Infpordia, New DevComponents.DotNetBar.SuperTooltipInfo("F2 - Citas por Dia", "Odontoapp", "Visualiza el informe de la citas del dia seleccionado en el calendario, presenta " & _
                    "la informacion basica de los pacientes, la hora inicial, hora final y el procedi" & _
                    "miento.", CType(resources.GetObject("btnf2Infpordia.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnf2Infpordia.Text = "X DIA"
        '
        'btnf3InfFuturas
        '
        Me.btnf3InfFuturas.Image = CType(resources.GetObject("btnf3InfFuturas.Image"), System.Drawing.Image)
        Me.btnf3InfFuturas.ImagePaddingHorizontal = 8
        Me.btnf3InfFuturas.Name = "btnf3InfFuturas"
        Me.SuperTooltip.SetSuperTooltip(Me.btnf3InfFuturas, New DevComponents.DotNetBar.SuperTooltipInfo("F3 - Citas Futuras por Paciente", "Odontoapp", "Presenta Solo las citas asignadas en fechas posteriores a Hoy de un paciente excl" & _
                    "uyendo las que ya asistió.", CType(resources.GetObject("btnf3InfFuturas.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnf3InfFuturas.Text = "FUTURAS"
        '
        'btnf4InfSinAsistir
        '
        Me.btnf4InfSinAsistir.HotForeColor = System.Drawing.Color.Yellow
        Me.btnf4InfSinAsistir.Image = CType(resources.GetObject("btnf4InfSinAsistir.Image"), System.Drawing.Image)
        Me.btnf4InfSinAsistir.ImagePaddingHorizontal = 8
        Me.btnf4InfSinAsistir.Name = "btnf4InfSinAsistir"
        Me.SuperTooltip.SetSuperTooltip(Me.btnf4InfSinAsistir, New DevComponents.DotNetBar.SuperTooltipInfo("F4 - Citas si Asistir del Día", "Odontoapp", "Informe de las citas de Pacientes que no asistieron a su cita del dia de hoy.", CType(resources.GetObject("btnf4InfSinAsistir.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnf4InfSinAsistir.Text = "SIN ASISTIR"
        '
        'btnInfAsignadoDia
        '
        Me.btnInfAsignadoDia.Image = CType(resources.GetObject("btnInfAsignadoDia.Image"), System.Drawing.Image)
        Me.btnInfAsignadoDia.ImagePaddingHorizontal = 8
        Me.btnInfAsignadoDia.Name = "btnInfAsignadoDia"
        Me.btnInfAsignadoDia.Text = "OTROS"
        Me.btnInfAsignadoDia.Tooltip = "OTROS"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.RibbonPanel1.Controls.Add(Me.btnCirugia)
        Me.RibbonPanel1.Controls.Add(Me.btnActualizacion)
        Me.RibbonPanel1.Controls.Add(Me.btnSoporteRemoto)
        Me.RibbonPanel1.Controls.Add(Me.btnSincronizar)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 65)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(1036, 63)
        Me.RibbonPanel1.TabIndex = 1
        Me.RibbonPanel1.Visible = False
        '
        'btnCirugia
        '
        Me.btnCirugia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCirugia.Image = CType(resources.GetObject("btnCirugia.Image"), System.Drawing.Image)
        Me.btnCirugia.Location = New System.Drawing.Point(609, 3)
        Me.btnCirugia.Name = "btnCirugia"
        Me.btnCirugia.Size = New System.Drawing.Size(190, 56)
        Me.btnCirugia.TabIndex = 3
        Me.btnCirugia.Tag = "1"
        Me.btnCirugia.Text = "CIRUGIA"
        Me.btnCirugia.Tooltip = "CIRUGIA"
        '
        'btnActualizacion
        '
        Me.btnActualizacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnActualizacion.Image = CType(resources.GetObject("btnActualizacion.Image"), System.Drawing.Image)
        Me.btnActualizacion.Location = New System.Drawing.Point(413, 3)
        Me.btnActualizacion.Name = "btnActualizacion"
        Me.btnActualizacion.Size = New System.Drawing.Size(190, 56)
        Me.btnActualizacion.TabIndex = 2
        Me.btnActualizacion.Tag = "1"
        Me.btnActualizacion.Text = "ACTUALIZACION"
        Me.btnActualizacion.Tooltip = "ACTUALIZACION"
        '
        'btnSoporteRemoto
        '
        Me.btnSoporteRemoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSoporteRemoto.Image = CType(resources.GetObject("btnSoporteRemoto.Image"), System.Drawing.Image)
        Me.btnSoporteRemoto.Location = New System.Drawing.Point(216, 2)
        Me.btnSoporteRemoto.Name = "btnSoporteRemoto"
        Me.btnSoporteRemoto.Size = New System.Drawing.Size(190, 56)
        Me.btnSoporteRemoto.TabIndex = 1
        Me.btnSoporteRemoto.Tag = "1"
        Me.btnSoporteRemoto.Text = "SOPORTE REMOTO"
        Me.btnSoporteRemoto.Tooltip = "SOPORTE REMOTO"
        '
        'btnSincronizar
        '
        Me.btnSincronizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSincronizar.Image = CType(resources.GetObject("btnSincronizar.Image"), System.Drawing.Image)
        Me.btnSincronizar.Location = New System.Drawing.Point(9, 2)
        Me.btnSincronizar.Name = "btnSincronizar"
        Me.btnSincronizar.Size = New System.Drawing.Size(202, 56)
        Me.btnSincronizar.TabIndex = 0
        Me.btnSincronizar.Tag = "1"
        Me.btnSincronizar.Text = "SINCRONIZAR EQUIPOS"
        Me.btnSincronizar.Tooltip = "SELECCIONAR"
        '
        'PanelConv
        '
        Me.PanelConv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelConv.Controls.Add(Me.GroupItemsCitas)
        Me.PanelConv.Controls.Add(Me.GroupItemsPacientes)
        Me.PanelConv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConv.Location = New System.Drawing.Point(0, 65)
        Me.PanelConv.Name = "PanelConv"
        Me.PanelConv.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelConv.Size = New System.Drawing.Size(1036, 63)
        Me.PanelConv.TabIndex = 2
        Me.PanelConv.Visible = False
        '
        'GroupItemsCitas
        '
        Me.GroupItemsCitas.BackColor = System.Drawing.Color.Transparent
        Me.GroupItemsCitas.Controls.Add(Me.PictureBox6)
        Me.GroupItemsCitas.Controls.Add(Me.PictureBox5)
        Me.GroupItemsCitas.Controls.Add(Me.Label21)
        Me.GroupItemsCitas.Controls.Add(Me.Label22)
        Me.GroupItemsCitas.Location = New System.Drawing.Point(190, 0)
        Me.GroupItemsCitas.Name = "GroupItemsCitas"
        Me.GroupItemsCitas.Size = New System.Drawing.Size(178, 62)
        Me.GroupItemsCitas.TabIndex = 1
        Me.GroupItemsCitas.TabStop = False
        Me.GroupItemsCitas.Text = "Citas"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(9, 39)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(9, 18)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(38, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Cita Nueva no Grabada"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(37, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(123, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Cita Editada no Grabada"
        '
        'GroupItemsPacientes
        '
        Me.GroupItemsPacientes.BackColor = System.Drawing.Color.Transparent
        Me.GroupItemsPacientes.Controls.Add(Me.LabelX4)
        Me.GroupItemsPacientes.Controls.Add(Me.LabelX3)
        Me.GroupItemsPacientes.Controls.Add(Me.LabelX1)
        Me.GroupItemsPacientes.Controls.Add(Me.LabelX2)
        Me.GroupItemsPacientes.Controls.Add(Me.Label4)
        Me.GroupItemsPacientes.Controls.Add(Me.Label2)
        Me.GroupItemsPacientes.Controls.Add(Me.Label3)
        Me.GroupItemsPacientes.Controls.Add(Me.Label1)
        Me.GroupItemsPacientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupItemsPacientes.Location = New System.Drawing.Point(3, 0)
        Me.GroupItemsPacientes.Name = "GroupItemsPacientes"
        Me.GroupItemsPacientes.Size = New System.Drawing.Size(168, 60)
        Me.GroupItemsPacientes.TabIndex = 0
        Me.GroupItemsPacientes.TabStop = False
        Me.GroupItemsPacientes.Text = "Pacientes"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Khaki
        Me.LabelX4.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelX4.Location = New System.Drawing.Point(95, 38)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(17, 15)
        Me.LabelX4.TabIndex = 6
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.LimeGreen
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelX3.Location = New System.Drawing.Point(95, 19)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(17, 15)
        Me.LabelX3.TabIndex = 2
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelX1.Location = New System.Drawing.Point(9, 19)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(17, 15)
        Me.LabelX1.TabIndex = 0
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Salmon
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.LabelX2.Location = New System.Drawing.Point(9, 38)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(17, 15)
        Me.LabelX2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(114, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Retirado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Retencion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bloqueado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tratamiento"
        '
        'PanelUsuarios
        '
        Me.PanelUsuarios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelUsuarios.Controls.Add(Me.PnlActivoUsuario)
        Me.PanelUsuarios.Controls.Add(Me.btnUsuSeleccionar)
        Me.PanelUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelUsuarios.Location = New System.Drawing.Point(0, 65)
        Me.PanelUsuarios.Name = "PanelUsuarios"
        Me.PanelUsuarios.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelUsuarios.Size = New System.Drawing.Size(1036, 63)
        Me.PanelUsuarios.TabIndex = 3
        Me.PanelUsuarios.Visible = False
        '
        'PnlActivoUsuario
        '
        Me.PnlActivoUsuario.BackColor = System.Drawing.Color.Transparent
        Me.PnlActivoUsuario.CanvasColor = System.Drawing.SystemColors.Control
        Me.PnlActivoUsuario.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PnlActivoUsuario.Controls.Add(Me.lblActivoUsuario)
        Me.PnlActivoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlActivoUsuario.Location = New System.Drawing.Point(12, 3)
        Me.PnlActivoUsuario.Name = "PnlActivoUsuario"
        Me.PnlActivoUsuario.Size = New System.Drawing.Size(267, 50)
        '
        '
        '
        Me.PnlActivoUsuario.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PnlActivoUsuario.Style.BackColor2 = System.Drawing.Color.DarkSeaGreen
        Me.PnlActivoUsuario.Style.BackColorGradientAngle = 90
        Me.PnlActivoUsuario.Style.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.PnlActivoUsuario.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PnlActivoUsuario.Style.BorderBottomWidth = 1
        Me.PnlActivoUsuario.Style.BorderColor = System.Drawing.Color.DarkGreen
        Me.PnlActivoUsuario.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PnlActivoUsuario.Style.BorderLeftWidth = 1
        Me.PnlActivoUsuario.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PnlActivoUsuario.Style.BorderRightWidth = 1
        Me.PnlActivoUsuario.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.PnlActivoUsuario.Style.BorderTopWidth = 1
        Me.PnlActivoUsuario.Style.CornerDiameter = 4
        Me.PnlActivoUsuario.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PnlActivoUsuario.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.PnlActivoUsuario.Style.TextColor = System.Drawing.Color.DarkGreen
        Me.PnlActivoUsuario.TabIndex = 0
        Me.PnlActivoUsuario.Text = "USUARIO ACTIVO"
        '
        'lblActivoUsuario
        '
        Me.lblActivoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblActivoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivoUsuario.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblActivoUsuario.Location = New System.Drawing.Point(0, 0)
        Me.lblActivoUsuario.Name = "lblActivoUsuario"
        Me.lblActivoUsuario.Size = New System.Drawing.Size(261, 29)
        Me.lblActivoUsuario.TabIndex = 0
        Me.lblActivoUsuario.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnUsuSeleccionar
        '
        Me.btnUsuSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUsuSeleccionar.Image = CType(resources.GetObject("btnUsuSeleccionar.Image"), System.Drawing.Image)
        Me.btnUsuSeleccionar.Location = New System.Drawing.Point(285, 3)
        Me.btnUsuSeleccionar.Name = "btnUsuSeleccionar"
        Me.btnUsuSeleccionar.Size = New System.Drawing.Size(121, 56)
        Me.btnUsuSeleccionar.TabIndex = 1
        Me.btnUsuSeleccionar.Tag = "1"
        Me.btnUsuSeleccionar.Text = "CAMBIAR USUARIO"
        Me.btnUsuSeleccionar.Tooltip = "SELECCIONAR"
        '
        'PanelBackups
        '
        Me.PanelBackups.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelBackups.Controls.Add(Me.BarBackups)
        Me.PanelBackups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBackups.Location = New System.Drawing.Point(0, 65)
        Me.PanelBackups.Name = "PanelBackups"
        Me.PanelBackups.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelBackups.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PanelBackups.Size = New System.Drawing.Size(1036, 63)
        Me.PanelBackups.TabIndex = 4
        Me.PanelBackups.Visible = False
        '
        'BarBackups
        '
        Me.BarBackups.AutoOverflowEnabled = True
        Me.BarBackups.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarBackups.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnBackup, Me.btnRestaurarBackup})
        Me.BarBackups.Location = New System.Drawing.Point(3, 0)
        Me.BarBackups.Name = "BarBackups"
        Me.BarBackups.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BarBackups.Size = New System.Drawing.Size(71, 60)
        Me.BarBackups.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.BarBackups.TabIndex = 0
        Me.BarBackups.Text = "BACKUPS"
        '
        'btnBackup
        '
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImagePaddingHorizontal = 8
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Tag = "Copia de Seguridad"
        Me.btnBackup.Tooltip = "Copia de Seguridad"
        '
        'btnRestaurarBackup
        '
        Me.btnRestaurarBackup.Image = CType(resources.GetObject("btnRestaurarBackup.Image"), System.Drawing.Image)
        Me.btnRestaurarBackup.ImagePaddingHorizontal = 8
        Me.btnRestaurarBackup.Name = "btnRestaurarBackup"
        Me.btnRestaurarBackup.Tooltip = "Restaurar Copia de Seguridad"
        '
        'PanelContenedorSuperior
        '
        Me.PanelContenedorSuperior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelContenedorSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedorSuperior.Name = "PanelContenedorSuperior"
        Me.PanelContenedorSuperior.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.PanelContenedorSuperior.Size = New System.Drawing.Size(1036, 128)
        Me.PanelContenedorSuperior.TabIndex = 0
        '
        'TabFunciones
        '
        Me.TabFunciones.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.TabFunciones.Checked = True
        Me.TabFunciones.Image = CType(resources.GetObject("TabFunciones.Image"), System.Drawing.Image)
        Me.TabFunciones.ImagePaddingHorizontal = 8
        Me.TabFunciones.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.TabFunciones.Name = "TabFunciones"
        Me.TabFunciones.Panel = Me.PanelFunciones
        Me.SuperTooltip.SetSuperTooltip(Me.TabFunciones, New DevComponents.DotNetBar.SuperTooltipInfo("Ficha de Informes", "Odontoapp", "Presenta los Botones principales de Informes de la aplicacion.", CType(resources.GetObject("TabFunciones.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        '
        'TabSeguridad
        '
        Me.TabSeguridad.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.TabSeguridad.Image = CType(resources.GetObject("TabSeguridad.Image"), System.Drawing.Image)
        Me.TabSeguridad.ImagePaddingHorizontal = 8
        Me.TabSeguridad.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.TabSeguridad.Name = "TabSeguridad"
        Me.TabSeguridad.Panel = Me.PanelBackups
        Me.SuperTooltip.SetSuperTooltip(Me.TabSeguridad, New DevComponents.DotNetBar.SuperTooltipInfo("Copias de Seguridad", "Odontoapp", "Funciones para Crear y Restaura completamente una Copia de Seguridad de la Base d" & _
                    "e Datos.", CType(resources.GetObject("TabSeguridad.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        '
        'TabUsuario
        '
        Me.TabUsuario.Image = CType(resources.GetObject("TabUsuario.Image"), System.Drawing.Image)
        Me.TabUsuario.ImagePaddingHorizontal = 8
        Me.TabUsuario.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.TabUsuario.Name = "TabUsuario"
        Me.TabUsuario.Panel = Me.PanelUsuarios
        Me.TabUsuario.Tooltip = "USUARIOS"
        '
        'TabConv
        '
        Me.TabConv.Image = CType(resources.GetObject("TabConv.Image"), System.Drawing.Image)
        Me.TabConv.ImagePaddingHorizontal = 8
        Me.TabConv.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.TabConv.Name = "TabConv"
        Me.TabConv.Panel = Me.PanelConv
        Me.TabConv.Tooltip = "Convensiones"
        '
        'RibbonTabItem1
        '
        Me.RibbonTabItem1.Image = CType(resources.GetObject("RibbonTabItem1.Image"), System.Drawing.Image)
        Me.RibbonTabItem1.ImagePaddingHorizontal = 8
        Me.RibbonTabItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.RibbonTabItem1.Name = "RibbonTabItem1"
        Me.RibbonTabItem1.Panel = Me.RibbonPanel1
        '
        'lblFechaHoy
        '
        Me.lblFechaHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaHoy.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far
        Me.lblFechaHoy.Name = "lblFechaHoy"
        Me.lblFechaHoy.Text = "FECHA HOY     :"
        Me.lblFechaHoy.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtfechahoy
        '
        Me.txtfechahoy.BackColor = System.Drawing.Color.Transparent
        Me.txtfechahoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechahoy.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtfechahoy.Name = "txtfechahoy"
        Me.txtfechahoy.SingleLineColor = System.Drawing.SystemColors.Desktop
        Me.txtfechahoy.Text = "EL DIA DE HOY"
        Me.txtfechahoy.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnInicio
        '
        Me.btnInicio.AutoExpandOnClick = True
        Me.btnInicio.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnInicio.ImagePaddingHorizontal = 1
        Me.btnInicio.ImagePaddingVertical = 1
        Me.btnInicio.Name = "btnInicio"
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'PanelPrincipalDerecho
        '
        Me.PanelPrincipalDerecho.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelPrincipalDerecho.Controls.Add(Me.ScheduleOrhosoft)
        Me.PanelPrincipalDerecho.Controls.Add(Me.PanelEx1)
        Me.PanelPrincipalDerecho.Controls.Add(Me.ExpandableScheduler)
        Me.PanelPrincipalDerecho.Controls.Add(Me.PanelOpcScheduler)
        Me.PanelPrincipalDerecho.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelPrincipalDerecho.Location = New System.Drawing.Point(733, 130)
        Me.PanelPrincipalDerecho.Name = "PanelPrincipalDerecho"
        Me.PanelPrincipalDerecho.Size = New System.Drawing.Size(303, 633)
        '
        '
        '
        Me.PanelPrincipalDerecho.Style.Class = "RibbonClientPanel"
        Me.PanelPrincipalDerecho.TabIndex = 7
        Me.PanelPrincipalDerecho.Text = "RibbonClientPanel2"
        '
        'ScheduleOrhosoft
        '
        Me.ScheduleOrhosoft.AllowAppointmentDrag = CType((Janus.Windows.Schedule.AllowAppointmentDrag.Move Or Janus.Windows.Schedule.AllowAppointmentDrag.Resize), Janus.Windows.Schedule.AllowAppointmentDrag)
        Me.ScheduleOrhosoft.AllowDelete = False
        Me.ScheduleOrhosoft.AllowEdit = False
        Me.ScheduleOrhosoft.AppointmentOutLineColor = System.Drawing.Color.Empty
        Me.ScheduleOrhosoft.Date = New Date(2007, 1, 7, 0, 0, 0, 0)
        Me.ScheduleOrhosoft.Dates.Add(New Date(2007, 1, 7, 0, 0, 0, 0))
        Me.ScheduleOrhosoft.DayStartHour = 1
        Me.ScheduleOrhosoft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScheduleOrhosoft.HourBackgroundStyle.BackColor = System.Drawing.Color.Navy
        Me.ScheduleOrhosoft.ImageList = Me.ImageScheduler
        Me.ScheduleOrhosoft.Interval = Janus.Windows.Schedule.Interval.TenMinutes
        Me.ScheduleOrhosoft.Location = New System.Drawing.Point(0, 26)
        Me.ScheduleOrhosoft.MultiSelect = False
        Me.ScheduleOrhosoft.Name = "ScheduleOrhosoft"
        Me.ScheduleOrhosoft.SelectedFormatStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.ScheduleOrhosoft.ShowAllDayArea = False
        Me.ScheduleOrhosoft.ShowMinutesInTimeNavigator = True
        Me.ScheduleOrhosoft.Size = New System.Drawing.Size(303, 485)
        Me.ScheduleOrhosoft.TabIndex = 1
        Me.ScheduleOrhosoft.WorkEndTime = System.TimeSpan.Parse("19:00:00")
        Me.ScheduleOrhosoft.WorkingHourBackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ScheduleOrhosoft.WorkWeek = CType((((((Janus.Windows.Schedule.ScheduleDayOfWeek.Monday Or Janus.Windows.Schedule.ScheduleDayOfWeek.Tuesday) _
                    Or Janus.Windows.Schedule.ScheduleDayOfWeek.Wednesday) _
                    Or Janus.Windows.Schedule.ScheduleDayOfWeek.Thursday) _
                    Or Janus.Windows.Schedule.ScheduleDayOfWeek.Friday) _
                    Or Janus.Windows.Schedule.ScheduleDayOfWeek.Saturday), Janus.Windows.Schedule.ScheduleDayOfWeek)
        '
        'ImageScheduler
        '
        Me.ImageScheduler.ImageStream = CType(resources.GetObject("ImageScheduler.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageScheduler.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageScheduler.Images.SetKeyName(0, "")
        Me.ImageScheduler.Images.SetKeyName(1, "")
        Me.ImageScheduler.Images.SetKeyName(2, "alarmclock_stop.png")
        Me.ImageScheduler.Images.SetKeyName(3, "alarmclock_preferences.png")
        Me.ImageScheduler.Images.SetKeyName(4, "")
        Me.ImageScheduler.Images.SetKeyName(5, "")
        Me.ImageScheduler.Images.SetKeyName(6, "")
        Me.ImageScheduler.Images.SetKeyName(7, "")
        Me.ImageScheduler.Images.SetKeyName(8, "")
        Me.ImageScheduler.Images.SetKeyName(9, "")
        Me.ImageScheduler.Images.SetKeyName(10, "")
        Me.ImageScheduler.Images.SetKeyName(11, "")
        Me.ImageScheduler.Images.SetKeyName(12, "")
        Me.ImageScheduler.Images.SetKeyName(13, "")
        Me.ImageScheduler.Images.SetKeyName(14, "")
        Me.ImageScheduler.Images.SetKeyName(15, "")
        Me.ImageScheduler.Images.SetKeyName(16, "")
        Me.ImageScheduler.Images.SetKeyName(17, "")
        Me.ImageScheduler.Images.SetKeyName(18, "")
        Me.ImageScheduler.Images.SetKeyName(19, "")
        Me.ImageScheduler.Images.SetKeyName(20, "")
        Me.ImageScheduler.Images.SetKeyName(21, "")
        Me.ImageScheduler.Images.SetKeyName(22, "")
        Me.ImageScheduler.Images.SetKeyName(23, "help2.png")
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.Controls.Add(Me.btnSkype)
        Me.PanelEx1.Controls.Add(Me.btnBuscarHuella)
        Me.PanelEx1.Controls.Add(Me.btnAppointment)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(303, 26)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.MenuHighlight
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.SuperTooltip.SetSuperTooltip(Me.PanelEx1, New DevComponents.DotNetBar.SuperTooltipInfo("Estado de Cuentas", "Odontoapp", "Presenta el estado de pagos de tratamientos y cuotas del paciente.", CType(resources.GetObject("PanelEx1.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.PanelEx1.TabIndex = 0
        '
        'btnBuscarHuella
        '
        Me.btnBuscarHuella.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscarHuella.Image = CType(resources.GetObject("btnBuscarHuella.Image"), System.Drawing.Image)
        Me.btnBuscarHuella.Location = New System.Drawing.Point(249, 2)
        Me.btnBuscarHuella.Name = "btnBuscarHuella"
        Me.btnBuscarHuella.Size = New System.Drawing.Size(23, 21)
        Me.SuperTooltip.SetSuperTooltip(Me.btnBuscarHuella, New DevComponents.DotNetBar.SuperTooltipInfo("Desplegar Appointment", "Odontoapointment", "Despliega en modo multisilla la agenda.", CType(resources.GetObject("btnBuscarHuella.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnBuscarHuella.TabIndex = 1
        '
        'btnAppointment
        '
        Me.btnAppointment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAppointment.Image = CType(resources.GetObject("btnAppointment.Image"), System.Drawing.Image)
        Me.btnAppointment.Location = New System.Drawing.Point(277, 2)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(23, 21)
        Me.SuperTooltip.SetSuperTooltip(Me.btnAppointment, New DevComponents.DotNetBar.SuperTooltipInfo("Desplegar Appointment", "Odontoapointment", "Despliega en modo multisilla la agenda.", CType(resources.GetObject("btnAppointment.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnAppointment.TabIndex = 0
        '
        'ExpandableScheduler
        '
        Me.ExpandableScheduler.BackColor2 = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableScheduler.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableScheduler.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableScheduler.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExpandableScheduler.ExpandableControl = Me.PanelOpcScheduler
        Me.ExpandableScheduler.ExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableScheduler.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableScheduler.ExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableScheduler.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableScheduler.GripDarkColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableScheduler.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableScheduler.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableScheduler.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableScheduler.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableScheduler.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableScheduler.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableScheduler.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableScheduler.HotExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableScheduler.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableScheduler.HotExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableScheduler.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableScheduler.HotGripDarkColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableScheduler.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableScheduler.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableScheduler.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableScheduler.Location = New System.Drawing.Point(0, 511)
        Me.ExpandableScheduler.Name = "ExpandableScheduler"
        Me.ExpandableScheduler.Size = New System.Drawing.Size(303, 12)
        Me.ExpandableScheduler.TabIndex = 2
        Me.ExpandableScheduler.TabStop = False
        '
        'PanelOpcScheduler
        '
        Me.PanelOpcScheduler.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelOpcScheduler.Controls.Add(Me.FichasOpcionesCitas)
        Me.PanelOpcScheduler.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelOpcScheduler.Location = New System.Drawing.Point(0, 523)
        Me.PanelOpcScheduler.Name = "PanelOpcScheduler"
        Me.PanelOpcScheduler.Size = New System.Drawing.Size(303, 110)
        '
        '
        '
        Me.PanelOpcScheduler.Style.Class = "RibbonClientPanel"
        Me.PanelOpcScheduler.TabIndex = 3
        Me.PanelOpcScheduler.Text = "RibbonClientPanel3"
        '
        'FichasOpcionesCitas
        '
        Me.FichasOpcionesCitas.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FichasOpcionesCitas.CanReorderTabs = True
        Me.FichasOpcionesCitas.Controls.Add(Me.TabPanelRegistro)
        Me.FichasOpcionesCitas.Controls.Add(Me.TabPanelNotaCita)
        Me.FichasOpcionesCitas.Controls.Add(Me.TabPanelCitas)
        Me.FichasOpcionesCitas.Controls.Add(Me.TabPanelDoctor)
        Me.FichasOpcionesCitas.Controls.Add(Me.TabPanelAgenda)
        Me.FichasOpcionesCitas.Controls.Add(Me.TabPanelConsulta)
        Me.FichasOpcionesCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FichasOpcionesCitas.Font = New System.Drawing.Font("Arial", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FichasOpcionesCitas.Location = New System.Drawing.Point(0, 0)
        Me.FichasOpcionesCitas.Name = "FichasOpcionesCitas"
        Me.FichasOpcionesCitas.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.FichasOpcionesCitas.SelectedTabIndex = 0
        Me.FichasOpcionesCitas.Size = New System.Drawing.Size(303, 110)
        Me.FichasOpcionesCitas.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.FichasOpcionesCitas.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Bottom
        Me.FichasOpcionesCitas.TabIndex = 0
        Me.FichasOpcionesCitas.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox
        Me.FichasOpcionesCitas.Tabs.Add(Me.TabRegistro)
        Me.FichasOpcionesCitas.Tabs.Add(Me.TabConsulta)
        Me.FichasOpcionesCitas.Tabs.Add(Me.TabNotaCita)
        Me.FichasOpcionesCitas.Tabs.Add(Me.TabCitas)
        Me.FichasOpcionesCitas.Tabs.Add(Me.TabDoctor)
        Me.FichasOpcionesCitas.Tabs.Add(Me.TabAgenda)
        Me.FichasOpcionesCitas.ThemeAware = True
        '
        'TabPanelRegistro
        '
        Me.TabPanelRegistro.Controls.Add(Me.VerificationControl)
        Me.TabPanelRegistro.Controls.Add(Me.btnCitaImprimir)
        Me.TabPanelRegistro.Controls.Add(Me.btnCitaModificar)
        Me.TabPanelRegistro.Controls.Add(Me.btnCitaEliminar)
        Me.TabPanelRegistro.Controls.Add(Me.btnCitaAdicionar)
        Me.TabPanelRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPanelRegistro.Location = New System.Drawing.Point(0, 0)
        Me.TabPanelRegistro.Name = "TabPanelRegistro"
        Me.TabPanelRegistro.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPanelRegistro.Size = New System.Drawing.Size(303, 69)
        Me.TabPanelRegistro.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabPanelRegistro.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabPanelRegistro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabPanelRegistro.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabPanelRegistro.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabPanelRegistro.Style.GradientAngle = -90
        Me.TabPanelRegistro.TabIndex = 0
        Me.TabPanelRegistro.TabItem = Me.TabRegistro
        '
        'VerificationControl
        '
        Me.VerificationControl.Active = True
        Me.VerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.VerificationControl.Location = New System.Drawing.Point(7, 10)
        Me.VerificationControl.Name = "VerificationControl"
        Me.VerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.VerificationControl.Size = New System.Drawing.Size(48, 49)
        Me.VerificationControl.TabIndex = 119
        '
        'btnCitaImprimir
        '
        Me.btnCitaImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaImprimir.Image = CType(resources.GetObject("btnCitaImprimir.Image"), System.Drawing.Image)
        Me.btnCitaImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaImprimir.Location = New System.Drawing.Point(241, 12)
        Me.btnCitaImprimir.Name = "btnCitaImprimir"
        Me.btnCitaImprimir.Size = New System.Drawing.Size(57, 44)
        Me.btnCitaImprimir.TabIndex = 3
        Me.btnCitaImprimir.Text = "Imprimir"
        '
        'btnCitaModificar
        '
        Me.btnCitaModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaModificar.Image = CType(resources.GetObject("btnCitaModificar.Image"), System.Drawing.Image)
        Me.btnCitaModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaModificar.Location = New System.Drawing.Point(121, 12)
        Me.btnCitaModificar.Name = "btnCitaModificar"
        Me.btnCitaModificar.Size = New System.Drawing.Size(57, 44)
        Me.btnCitaModificar.TabIndex = 1
        Me.btnCitaModificar.Text = "Modificar"
        '
        'btnCitaEliminar
        '
        Me.btnCitaEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaEliminar.Image = CType(resources.GetObject("btnCitaEliminar.Image"), System.Drawing.Image)
        Me.btnCitaEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaEliminar.Location = New System.Drawing.Point(181, 12)
        Me.btnCitaEliminar.Name = "btnCitaEliminar"
        Me.btnCitaEliminar.Size = New System.Drawing.Size(57, 44)
        Me.btnCitaEliminar.TabIndex = 2
        Me.btnCitaEliminar.Text = "Eliminar"
        '
        'btnCitaAdicionar
        '
        Me.btnCitaAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaAdicionar.Image = CType(resources.GetObject("btnCitaAdicionar.Image"), System.Drawing.Image)
        Me.btnCitaAdicionar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaAdicionar.Location = New System.Drawing.Point(61, 12)
        Me.btnCitaAdicionar.Name = "btnCitaAdicionar"
        Me.btnCitaAdicionar.Size = New System.Drawing.Size(57, 44)
        Me.btnCitaAdicionar.TabIndex = 0
        Me.btnCitaAdicionar.Text = "Adicionar"
        '
        'TabRegistro
        '
        Me.TabRegistro.AttachedControl = Me.TabPanelRegistro
        Me.TabRegistro.Image = CType(resources.GetObject("TabRegistro.Image"), System.Drawing.Image)
        Me.TabRegistro.Name = "TabRegistro"
        Me.TabRegistro.Text = ""
        Me.TabRegistro.Tooltip = "Ficha Registro de Citas"
        '
        'TabPanelNotaCita
        '
        Me.TabPanelNotaCita.Controls.Add(Me.GroupNotaCita)
        Me.TabPanelNotaCita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPanelNotaCita.Location = New System.Drawing.Point(0, 0)
        Me.TabPanelNotaCita.Name = "TabPanelNotaCita"
        Me.TabPanelNotaCita.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPanelNotaCita.Size = New System.Drawing.Size(303, 69)
        Me.TabPanelNotaCita.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabPanelNotaCita.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabPanelNotaCita.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabPanelNotaCita.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabPanelNotaCita.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabPanelNotaCita.Style.GradientAngle = -90
        Me.TabPanelNotaCita.TabIndex = 2
        Me.TabPanelNotaCita.TabItem = Me.TabNotaCita
        '
        'GroupNotaCita
        '
        Me.GroupNotaCita.BackColor = System.Drawing.Color.Transparent
        Me.GroupNotaCita.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupNotaCita.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupNotaCita.Controls.Add(Me.btnCitaModificar2)
        Me.GroupNotaCita.Controls.Add(Me.txtnotacita)
        Me.GroupNotaCita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupNotaCita.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupNotaCita.Location = New System.Drawing.Point(1, 1)
        Me.GroupNotaCita.Name = "GroupNotaCita"
        Me.GroupNotaCita.Size = New System.Drawing.Size(301, 67)
        '
        '
        '
        Me.GroupNotaCita.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupNotaCita.Style.BackColorGradientAngle = 90
        Me.GroupNotaCita.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupNotaCita.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderBottomWidth = 1
        Me.GroupNotaCita.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupNotaCita.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderLeftWidth = 1
        Me.GroupNotaCita.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderRightWidth = 1
        Me.GroupNotaCita.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderTopWidth = 1
        Me.GroupNotaCita.Style.CornerDiameter = 4
        Me.GroupNotaCita.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupNotaCita.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupNotaCita.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupNotaCita.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupNotaCita.TabIndex = 0
        Me.GroupNotaCita.Text = "Nota Cita"
        '
        'btnCitaModificar2
        '
        Me.btnCitaModificar2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaModificar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaModificar2.Image = CType(resources.GetObject("btnCitaModificar2.Image"), System.Drawing.Image)
        Me.btnCitaModificar2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaModificar2.Location = New System.Drawing.Point(245, 1)
        Me.btnCitaModificar2.Name = "btnCitaModificar2"
        Me.btnCitaModificar2.Size = New System.Drawing.Size(46, 40)
        Me.SuperTooltip.SetSuperTooltip(Me.btnCitaModificar2, New DevComponents.DotNetBar.SuperTooltipInfo("Guardar Nota Cita", "Odontoapp", "Con este boton guardamos la nota asignada a la cita seleccionada, utilice este bo" & _
                    "ton para garantizar que la cita fue modificada.", CType(resources.GetObject("btnCitaModificar2.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnCitaModificar2.TabIndex = 2
        '
        'txtnotacita
        '
        Me.txtnotacita.Location = New System.Drawing.Point(3, 2)
        Me.txtnotacita.Name = "txtnotacita"
        Me.txtnotacita.Size = New System.Drawing.Size(236, 39)
        Me.txtnotacita.TabIndex = 0
        Me.txtnotacita.Text = ""
        '
        'TabNotaCita
        '
        Me.TabNotaCita.AttachedControl = Me.TabPanelNotaCita
        Me.TabNotaCita.Image = CType(resources.GetObject("TabNotaCita.Image"), System.Drawing.Image)
        Me.TabNotaCita.Name = "TabNotaCita"
        Me.TabNotaCita.Text = ""
        Me.TabNotaCita.Tooltip = "Ficha de Notas de Cita"
        '
        'TabPanelCitas
        '
        Me.TabPanelCitas.Controls.Add(Me.GroupAsistio)
        Me.TabPanelCitas.Controls.Add(Me.GroupCitaCancelada)
        Me.TabPanelCitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPanelCitas.Location = New System.Drawing.Point(0, 0)
        Me.TabPanelCitas.Name = "TabPanelCitas"
        Me.TabPanelCitas.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPanelCitas.Size = New System.Drawing.Size(303, 69)
        Me.TabPanelCitas.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabPanelCitas.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabPanelCitas.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabPanelCitas.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabPanelCitas.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabPanelCitas.Style.GradientAngle = -90
        Me.TabPanelCitas.TabIndex = 1
        Me.TabPanelCitas.TabItem = Me.TabCitas
        Me.TabPanelCitas.Text = "BOTONES CITA"
        '
        'GroupAsistio
        '
        Me.GroupAsistio.BackColor = System.Drawing.Color.Transparent
        Me.GroupAsistio.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupAsistio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupAsistio.Controls.Add(Me.rbtAsistioSi)
        Me.GroupAsistio.Controls.Add(Me.rbtAsistioNo)
        Me.GroupAsistio.Controls.Add(Me.PictureBox3)
        Me.GroupAsistio.Controls.Add(Me.PictureBox4)
        Me.GroupAsistio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAsistio.Location = New System.Drawing.Point(155, 10)
        Me.GroupAsistio.Name = "GroupAsistio"
        Me.GroupAsistio.Size = New System.Drawing.Size(145, 55)
        '
        '
        '
        Me.GroupAsistio.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupAsistio.Style.BackColorGradientAngle = 90
        Me.GroupAsistio.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupAsistio.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderBottomWidth = 1
        Me.GroupAsistio.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupAsistio.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderLeftWidth = 1
        Me.GroupAsistio.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderRightWidth = 1
        Me.GroupAsistio.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderTopWidth = 1
        Me.GroupAsistio.Style.CornerDiameter = 4
        Me.GroupAsistio.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupAsistio.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupAsistio.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupAsistio.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupAsistio.TabIndex = 1
        Me.GroupAsistio.Text = "Asistió a Cita"
        '
        'rbtAsistioSi
        '
        Me.rbtAsistioSi.AutoSize = True
        Me.rbtAsistioSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAsistioSi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtAsistioSi.Location = New System.Drawing.Point(26, 3)
        Me.rbtAsistioSi.Name = "rbtAsistioSi"
        Me.rbtAsistioSi.Size = New System.Drawing.Size(40, 21)
        Me.rbtAsistioSi.TabIndex = 0
        Me.rbtAsistioSi.Text = "Si"
        Me.rbtAsistioSi.UseVisualStyleBackColor = True
        '
        'rbtAsistioNo
        '
        Me.rbtAsistioNo.AutoSize = True
        Me.rbtAsistioNo.Checked = True
        Me.rbtAsistioNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAsistioNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtAsistioNo.Location = New System.Drawing.Point(99, 3)
        Me.rbtAsistioNo.Name = "rbtAsistioNo"
        Me.rbtAsistioNo.Size = New System.Drawing.Size(46, 21)
        Me.rbtAsistioNo.TabIndex = 1
        Me.rbtAsistioNo.TabStop = True
        Me.rbtAsistioNo.Text = "No"
        Me.rbtAsistioNo.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 21)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(72, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'GroupCitaCancelada
        '
        Me.GroupCitaCancelada.BackColor = System.Drawing.Color.Transparent
        Me.GroupCitaCancelada.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupCitaCancelada.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupCitaCancelada.Controls.Add(Me.rbtCanceladaNo)
        Me.GroupCitaCancelada.Controls.Add(Me.rbtCanceladaSi)
        Me.GroupCitaCancelada.Controls.Add(Me.PictureBox1)
        Me.GroupCitaCancelada.Controls.Add(Me.PictureBox2)
        Me.GroupCitaCancelada.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCitaCancelada.Location = New System.Drawing.Point(4, 10)
        Me.GroupCitaCancelada.Name = "GroupCitaCancelada"
        Me.GroupCitaCancelada.Size = New System.Drawing.Size(145, 55)
        '
        '
        '
        Me.GroupCitaCancelada.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupCitaCancelada.Style.BackColorGradientAngle = 90
        Me.GroupCitaCancelada.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupCitaCancelada.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderBottomWidth = 1
        Me.GroupCitaCancelada.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupCitaCancelada.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderLeftWidth = 1
        Me.GroupCitaCancelada.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderRightWidth = 1
        Me.GroupCitaCancelada.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderTopWidth = 1
        Me.GroupCitaCancelada.Style.CornerDiameter = 4
        Me.GroupCitaCancelada.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupCitaCancelada.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupCitaCancelada.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupCitaCancelada.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupCitaCancelada.TabIndex = 0
        Me.GroupCitaCancelada.Text = "Cita Cancelada"
        '
        'rbtCanceladaNo
        '
        Me.rbtCanceladaNo.AutoSize = True
        Me.rbtCanceladaNo.Checked = True
        Me.rbtCanceladaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCanceladaNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtCanceladaNo.Location = New System.Drawing.Point(95, 6)
        Me.rbtCanceladaNo.Name = "rbtCanceladaNo"
        Me.rbtCanceladaNo.Size = New System.Drawing.Size(46, 21)
        Me.rbtCanceladaNo.TabIndex = 1
        Me.rbtCanceladaNo.TabStop = True
        Me.rbtCanceladaNo.Text = "No"
        Me.rbtCanceladaNo.UseVisualStyleBackColor = True
        '
        'rbtCanceladaSi
        '
        Me.rbtCanceladaSi.AutoSize = True
        Me.rbtCanceladaSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCanceladaSi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtCanceladaSi.Location = New System.Drawing.Point(27, 6)
        Me.rbtCanceladaSi.Name = "rbtCanceladaSi"
        Me.rbtCanceladaSi.Size = New System.Drawing.Size(40, 21)
        Me.rbtCanceladaSi.TabIndex = 0
        Me.rbtCanceladaSi.Text = "Si"
        Me.rbtCanceladaSi.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 28)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(67, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 24)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'TabCitas
        '
        Me.TabCitas.AttachedControl = Me.TabPanelCitas
        Me.TabCitas.Image = CType(resources.GetObject("TabCitas.Image"), System.Drawing.Image)
        Me.TabCitas.Name = "TabCitas"
        Me.TabCitas.Text = ""
        Me.TabCitas.Tooltip = "Ficha Control de Cita"
        '
        'TabPanelDoctor
        '
        Me.TabPanelDoctor.Controls.Add(Me.btnDocSeleccionar)
        Me.TabPanelDoctor.Controls.Add(Me.GroupDoctor)
        Me.TabPanelDoctor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPanelDoctor.Location = New System.Drawing.Point(0, 0)
        Me.TabPanelDoctor.Name = "TabPanelDoctor"
        Me.TabPanelDoctor.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPanelDoctor.Size = New System.Drawing.Size(303, 69)
        Me.TabPanelDoctor.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabPanelDoctor.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabPanelDoctor.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabPanelDoctor.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabPanelDoctor.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabPanelDoctor.Style.GradientAngle = -90
        Me.TabPanelDoctor.TabIndex = 4
        Me.TabPanelDoctor.TabItem = Me.TabDoctor
        '
        'btnDocSeleccionar
        '
        Me.btnDocSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDocSeleccionar.Image = CType(resources.GetObject("btnDocSeleccionar.Image"), System.Drawing.Image)
        Me.btnDocSeleccionar.Location = New System.Drawing.Point(249, 9)
        Me.btnDocSeleccionar.Name = "btnDocSeleccionar"
        Me.btnDocSeleccionar.Size = New System.Drawing.Size(43, 53)
        Me.btnDocSeleccionar.TabIndex = 1
        Me.btnDocSeleccionar.Tag = "1"
        Me.btnDocSeleccionar.Tooltip = "SELECCIONAR"
        '
        'GroupDoctor
        '
        Me.GroupDoctor.BackColor = System.Drawing.Color.Transparent
        Me.GroupDoctor.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupDoctor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupDoctor.Controls.Add(Me.cmbDoctores)
        Me.GroupDoctor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDoctor.Location = New System.Drawing.Point(4, 7)
        Me.GroupDoctor.Name = "GroupDoctor"
        Me.GroupDoctor.Size = New System.Drawing.Size(233, 58)
        '
        '
        '
        Me.GroupDoctor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupDoctor.Style.BackColorGradientAngle = 90
        Me.GroupDoctor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupDoctor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderBottomWidth = 1
        Me.GroupDoctor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupDoctor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderLeftWidth = 1
        Me.GroupDoctor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderRightWidth = 1
        Me.GroupDoctor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderTopWidth = 1
        Me.GroupDoctor.Style.CornerDiameter = 4
        Me.GroupDoctor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupDoctor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupDoctor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupDoctor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupDoctor.TabIndex = 0
        Me.GroupDoctor.Text = "Doctor"
        '
        'cmbDoctores
        '
        Me.cmbDoctores.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.cmbDoctores.DisplayMember = "Text"
        Me.cmbDoctores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctores.FormattingEnabled = True
        Me.cmbDoctores.ItemHeight = 14
        Me.cmbDoctores.Location = New System.Drawing.Point(7, 10)
        Me.cmbDoctores.Name = "cmbDoctores"
        Me.cmbDoctores.Size = New System.Drawing.Size(217, 20)
        Me.cmbDoctores.TabIndex = 0
        '
        'TabDoctor
        '
        Me.TabDoctor.AttachedControl = Me.TabPanelDoctor
        Me.TabDoctor.Image = CType(resources.GetObject("TabDoctor.Image"), System.Drawing.Image)
        Me.TabDoctor.Name = "TabDoctor"
        Me.TabDoctor.Text = ""
        Me.TabDoctor.Tooltip = "Fihca de Doctores de Agenda"
        '
        'TabPanelAgenda
        '
        Me.TabPanelAgenda.AutoSize = True
        Me.TabPanelAgenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TabPanelAgenda.Controls.Add(Me.GroupAgenda)
        Me.TabPanelAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPanelAgenda.Location = New System.Drawing.Point(0, 0)
        Me.TabPanelAgenda.Name = "TabPanelAgenda"
        Me.TabPanelAgenda.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPanelAgenda.Size = New System.Drawing.Size(303, 69)
        Me.TabPanelAgenda.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabPanelAgenda.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabPanelAgenda.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabPanelAgenda.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabPanelAgenda.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabPanelAgenda.Style.GradientAngle = -90
        Me.TabPanelAgenda.TabIndex = 5
        Me.TabPanelAgenda.TabItem = Me.TabAgenda
        '
        'GroupAgenda
        '
        Me.GroupAgenda.BackColor = System.Drawing.Color.Transparent
        Me.GroupAgenda.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupAgenda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupAgenda.Controls.Add(Me.rbt15min)
        Me.GroupAgenda.Controls.Add(Me.rbt30min)
        Me.GroupAgenda.Controls.Add(Me.rbt10min)
        Me.GroupAgenda.Controls.Add(Me.rbt5min)
        Me.GroupAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupAgenda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAgenda.Location = New System.Drawing.Point(1, 1)
        Me.GroupAgenda.Name = "GroupAgenda"
        Me.GroupAgenda.Size = New System.Drawing.Size(301, 67)
        '
        '
        '
        Me.GroupAgenda.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupAgenda.Style.BackColorGradientAngle = 90
        Me.GroupAgenda.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupAgenda.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAgenda.Style.BorderBottomWidth = 1
        Me.GroupAgenda.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupAgenda.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAgenda.Style.BorderLeftWidth = 1
        Me.GroupAgenda.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAgenda.Style.BorderRightWidth = 1
        Me.GroupAgenda.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAgenda.Style.BorderTopWidth = 1
        Me.GroupAgenda.Style.CornerDiameter = 4
        Me.GroupAgenda.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupAgenda.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupAgenda.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupAgenda.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupAgenda.TabIndex = 0
        Me.GroupAgenda.Text = "Rango Agenda"
        '
        'rbt15min
        '
        Me.rbt15min.AutoSize = True
        Me.rbt15min.BackColor = System.Drawing.Color.Transparent
        Me.rbt15min.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt15min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbt15min.Location = New System.Drawing.Point(145, 12)
        Me.rbt15min.Name = "rbt15min"
        Me.rbt15min.Size = New System.Drawing.Size(74, 21)
        Me.rbt15min.TabIndex = 2
        Me.rbt15min.Text = "15 Min"
        Me.rbt15min.UseVisualStyleBackColor = False
        '
        'rbt30min
        '
        Me.rbt30min.AutoSize = True
        Me.rbt30min.BackColor = System.Drawing.Color.Transparent
        Me.rbt30min.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt30min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbt30min.Location = New System.Drawing.Point(219, 12)
        Me.rbt30min.Name = "rbt30min"
        Me.rbt30min.Size = New System.Drawing.Size(74, 21)
        Me.rbt30min.TabIndex = 3
        Me.rbt30min.Text = "30 Min"
        Me.rbt30min.UseVisualStyleBackColor = False
        '
        'rbt10min
        '
        Me.rbt10min.AutoSize = True
        Me.rbt10min.BackColor = System.Drawing.Color.Transparent
        Me.rbt10min.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt10min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbt10min.Location = New System.Drawing.Point(73, 12)
        Me.rbt10min.Name = "rbt10min"
        Me.rbt10min.Size = New System.Drawing.Size(74, 21)
        Me.rbt10min.TabIndex = 1
        Me.rbt10min.Text = "10 Min"
        Me.rbt10min.UseVisualStyleBackColor = False
        '
        'rbt5min
        '
        Me.rbt5min.AutoSize = True
        Me.rbt5min.BackColor = System.Drawing.Color.Transparent
        Me.rbt5min.Checked = True
        Me.rbt5min.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt5min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbt5min.Location = New System.Drawing.Point(10, 12)
        Me.rbt5min.Name = "rbt5min"
        Me.rbt5min.Size = New System.Drawing.Size(65, 21)
        Me.rbt5min.TabIndex = 0
        Me.rbt5min.TabStop = True
        Me.rbt5min.Text = "5 Min"
        Me.rbt5min.UseVisualStyleBackColor = False
        '
        'TabAgenda
        '
        Me.TabAgenda.AttachedControl = Me.TabPanelAgenda
        Me.TabAgenda.Image = CType(resources.GetObject("TabAgenda.Image"), System.Drawing.Image)
        Me.TabAgenda.Name = "TabAgenda"
        Me.TabAgenda.Text = ""
        Me.TabAgenda.Tooltip = "Ficha de Rango de Agenda"
        '
        'TabPanelConsulta
        '
        Me.TabPanelConsulta.Controls.Add(Me.GroupTipoConsulta)
        Me.TabPanelConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPanelConsulta.Location = New System.Drawing.Point(0, 0)
        Me.TabPanelConsulta.Name = "TabPanelConsulta"
        Me.TabPanelConsulta.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPanelConsulta.Size = New System.Drawing.Size(303, 69)
        Me.TabPanelConsulta.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabPanelConsulta.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabPanelConsulta.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabPanelConsulta.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabPanelConsulta.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Top), DevComponents.DotNetBar.eBorderSide)
        Me.TabPanelConsulta.Style.GradientAngle = -90
        Me.TabPanelConsulta.TabIndex = 3
        Me.TabPanelConsulta.TabItem = Me.TabConsulta
        '
        'GroupTipoConsulta
        '
        Me.GroupTipoConsulta.BackColor = System.Drawing.Color.Transparent
        Me.GroupTipoConsulta.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupTipoConsulta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupTipoConsulta.Controls.Add(Me.cmbTipoConsulta)
        Me.GroupTipoConsulta.Controls.Add(Me.lblTipoConsulta)
        Me.GroupTipoConsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupTipoConsulta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTipoConsulta.Location = New System.Drawing.Point(1, 1)
        Me.GroupTipoConsulta.Name = "GroupTipoConsulta"
        Me.GroupTipoConsulta.Size = New System.Drawing.Size(301, 67)
        '
        '
        '
        Me.GroupTipoConsulta.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupTipoConsulta.Style.BackColorGradientAngle = 90
        Me.GroupTipoConsulta.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupTipoConsulta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderBottomWidth = 1
        Me.GroupTipoConsulta.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupTipoConsulta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderLeftWidth = 1
        Me.GroupTipoConsulta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderRightWidth = 1
        Me.GroupTipoConsulta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderTopWidth = 1
        Me.GroupTipoConsulta.Style.CornerDiameter = 4
        Me.GroupTipoConsulta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupTipoConsulta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupTipoConsulta.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupTipoConsulta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupTipoConsulta.TabIndex = 0
        Me.GroupTipoConsulta.Text = "Tipo Consulta"
        '
        'cmbTipoConsulta
        '
        Me.cmbTipoConsulta.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.cmbTipoConsulta.DisplayMember = "Text"
        Me.cmbTipoConsulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoConsulta.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoConsulta.FormattingEnabled = True
        Me.cmbTipoConsulta.ItemHeight = 20
        Me.cmbTipoConsulta.Location = New System.Drawing.Point(6, 8)
        Me.cmbTipoConsulta.MaxDropDownItems = 25
        Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
        Me.cmbTipoConsulta.Size = New System.Drawing.Size(241, 26)
        Me.cmbTipoConsulta.TabIndex = 0
        '
        'lblTipoConsulta
        '
        Me.lblTipoConsulta.BackColor = System.Drawing.Color.Beige
        Me.lblTipoConsulta.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblTipoConsulta.Location = New System.Drawing.Point(255, 8)
        Me.lblTipoConsulta.Name = "lblTipoConsulta"
        Me.lblTipoConsulta.Size = New System.Drawing.Size(38, 31)
        Me.lblTipoConsulta.TabIndex = 1
        '
        'TabConsulta
        '
        Me.TabConsulta.AttachedControl = Me.TabPanelConsulta
        Me.TabConsulta.Image = CType(resources.GetObject("TabConsulta.Image"), System.Drawing.Image)
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.Text = ""
        Me.TabConsulta.Tooltip = "Ficha de Tipo de procedimientos"
        '
        'btnEnvioSMSPersonalizado
        '
        Me.btnEnvioSMSPersonalizado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEnvioSMSPersonalizado.Image = CType(resources.GetObject("btnEnvioSMSPersonalizado.Image"), System.Drawing.Image)
        Me.btnEnvioSMSPersonalizado.Location = New System.Drawing.Point(399, 90)
        Me.btnEnvioSMSPersonalizado.Name = "btnEnvioSMSPersonalizado"
        Me.btnEnvioSMSPersonalizado.Size = New System.Drawing.Size(27, 28)
        Me.SuperTooltip.SetSuperTooltip(Me.btnEnvioSMSPersonalizado, New DevComponents.DotNetBar.SuperTooltipInfo("SMS ", "Odontoapp", "Envio de SMS Personalizado", CType(resources.GetObject("btnEnvioSMSPersonalizado.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnEnvioSMSPersonalizado.TabIndex = 74
        '
        'btnEstadoCuenta
        '
        Me.btnEstadoCuenta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEstadoCuenta.Image = CType(resources.GetObject("btnEstadoCuenta.Image"), System.Drawing.Image)
        Me.btnEstadoCuenta.Location = New System.Drawing.Point(452, 89)
        Me.btnEstadoCuenta.Name = "btnEstadoCuenta"
        Me.btnEstadoCuenta.Size = New System.Drawing.Size(27, 28)
        Me.SuperTooltip.SetSuperTooltip(Me.btnEstadoCuenta, New DevComponents.DotNetBar.SuperTooltipInfo("Estado de Cuenta", "Odontoapp", "Presenta el estado de pagos de las cuotas y tratamientos del paciente.", CType(resources.GetObject("btnEstadoCuenta.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnEstadoCuenta.TabIndex = 73
        '
        'btnPacOdontograma
        '
        Me.btnPacOdontograma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPacOdontograma.Image = CType(resources.GetObject("btnPacOdontograma.Image"), System.Drawing.Image)
        Me.btnPacOdontograma.Location = New System.Drawing.Point(426, 89)
        Me.btnPacOdontograma.Name = "btnPacOdontograma"
        Me.btnPacOdontograma.Size = New System.Drawing.Size(27, 28)
        Me.SuperTooltip.SetSuperTooltip(Me.btnPacOdontograma, New DevComponents.DotNetBar.SuperTooltipInfo("Odontograma", "Odontoapp", "Desplega el Odontograma digital del paciente.", CType(resources.GetObject("btnPacOdontograma.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnPacOdontograma.TabIndex = 30
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.MenuPrincipal.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.MenuPrincipal.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.MenuPrincipal.BackStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.MenuPrincipal.BackStyle.BackColorGradientAngle = 90
        Me.MenuPrincipal.ContentMargin = 6
        Me.MenuPrincipal.Cursor = System.Windows.Forms.Cursors.Default
        Me.MenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuPrincipal.GroupImages = Nothing
        Me.MenuPrincipal.Groups.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ExplorerPacientes, Me.ExplorerDoctores, Me.ExplorerUsuarios, Me.ExplorerEntidades, Me.ExplorerInformes, Me.ExplorerAdministracion, Me.ExplorerCitas, Me.ExplorerContab, Me.ExplorerVarios})
        Me.MenuPrincipal.GroupSpacing = 1
        Me.MenuPrincipal.Images = Nothing
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 200)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(171, 405)
        Me.MenuPrincipal.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.BlueSpecial
        Me.MenuPrincipal.TabIndex = 1
        Me.MenuPrincipal.Text = "ExplorerBar"
        '
        'ExplorerPacientes
        '
        '
        '
        '
        Me.ExplorerPacientes.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerPacientes.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerPacientes.BackStyle.BorderBottomWidth = 1
        Me.ExplorerPacientes.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerPacientes.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerPacientes.BackStyle.BorderLeftWidth = 1
        Me.ExplorerPacientes.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerPacientes.BackStyle.BorderRightWidth = 1
        Me.ExplorerPacientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerPacientes.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerPacientes.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerPacientes.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerPacientes.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerPacientes.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerPacientes.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerPacientes.Image = CType(resources.GetObject("ExplorerPacientes.Image"), System.Drawing.Image)
        Me.ExplorerPacientes.Name = "ExplorerPacientes"
        Me.ExplorerPacientes.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuNuevoPaciente, Me.mnuBuscarPaciente})
        Me.ExplorerPacientes.Text = "PACIENTES"
        '
        '
        '
        Me.ExplorerPacientes.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerPacientes.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerPacientes.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerPacientes.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerPacientes.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerPacientes.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerPacientes.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerPacientes.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerPacientes.TitleStyle.CornerDiameter = 3
        Me.ExplorerPacientes.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerPacientes.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerPacientes.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ExplorerPacientes.XPSpecialGroup = True
        '
        'mnuNuevoPaciente
        '
        Me.mnuNuevoPaciente.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuNuevoPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuNuevoPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuNuevoPaciente.HotFontUnderline = True
        Me.mnuNuevoPaciente.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuNuevoPaciente.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuNuevoPaciente.Image = CType(resources.GetObject("mnuNuevoPaciente.Image"), System.Drawing.Image)
        Me.mnuNuevoPaciente.ImagePaddingHorizontal = 8
        Me.mnuNuevoPaciente.Name = "mnuNuevoPaciente"
        Me.mnuNuevoPaciente.Text = "Nuevo Paciente"
        Me.mnuNuevoPaciente.Tooltip = "Nuevo Paciente"
        '
        'mnuBuscarPaciente
        '
        Me.mnuBuscarPaciente.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuBuscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuBuscarPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuBuscarPaciente.HotFontUnderline = True
        Me.mnuBuscarPaciente.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuBuscarPaciente.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuBuscarPaciente.Image = CType(resources.GetObject("mnuBuscarPaciente.Image"), System.Drawing.Image)
        Me.mnuBuscarPaciente.ImagePaddingHorizontal = 8
        Me.mnuBuscarPaciente.Name = "mnuBuscarPaciente"
        Me.mnuBuscarPaciente.Text = "Buscar Paciente"
        Me.mnuBuscarPaciente.Tooltip = "Buscar Paciente"
        '
        'ExplorerDoctores
        '
        '
        '
        '
        Me.ExplorerDoctores.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerDoctores.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerDoctores.BackStyle.BorderBottomWidth = 1
        Me.ExplorerDoctores.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerDoctores.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerDoctores.BackStyle.BorderLeftWidth = 1
        Me.ExplorerDoctores.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerDoctores.BackStyle.BorderRightWidth = 1
        Me.ExplorerDoctores.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerDoctores.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerDoctores.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerDoctores.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerDoctores.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerDoctores.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerDoctores.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerDoctores.Image = CType(resources.GetObject("ExplorerDoctores.Image"), System.Drawing.Image)
        Me.ExplorerDoctores.Name = "ExplorerDoctores"
        Me.ExplorerDoctores.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuNuevoDoctor, Me.mnuBuscarDoctor, Me.mnuHorarioDoctores})
        Me.ExplorerDoctores.Text = "DOCTORES"
        '
        '
        '
        Me.ExplorerDoctores.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerDoctores.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerDoctores.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerDoctores.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerDoctores.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerDoctores.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerDoctores.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerDoctores.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerDoctores.TitleStyle.CornerDiameter = 3
        Me.ExplorerDoctores.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerDoctores.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerDoctores.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ExplorerDoctores.XPSpecialGroup = True
        '
        'mnuNuevoDoctor
        '
        Me.mnuNuevoDoctor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuNuevoDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuNuevoDoctor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuNuevoDoctor.HotFontUnderline = True
        Me.mnuNuevoDoctor.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuNuevoDoctor.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuNuevoDoctor.Image = CType(resources.GetObject("mnuNuevoDoctor.Image"), System.Drawing.Image)
        Me.mnuNuevoDoctor.ImagePaddingHorizontal = 8
        Me.mnuNuevoDoctor.Name = "mnuNuevoDoctor"
        Me.mnuNuevoDoctor.Text = "Nuevo Doctor"
        Me.mnuNuevoDoctor.Tooltip = "Nuevo Doctor"
        '
        'mnuBuscarDoctor
        '
        Me.mnuBuscarDoctor.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuBuscarDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuBuscarDoctor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuBuscarDoctor.HotFontUnderline = True
        Me.mnuBuscarDoctor.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuBuscarDoctor.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuBuscarDoctor.Image = CType(resources.GetObject("mnuBuscarDoctor.Image"), System.Drawing.Image)
        Me.mnuBuscarDoctor.ImagePaddingHorizontal = 8
        Me.mnuBuscarDoctor.Name = "mnuBuscarDoctor"
        Me.mnuBuscarDoctor.Text = "Buscar Doctor"
        '
        'mnuHorarioDoctores
        '
        Me.mnuHorarioDoctores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuHorarioDoctores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuHorarioDoctores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuHorarioDoctores.HotFontUnderline = True
        Me.mnuHorarioDoctores.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuHorarioDoctores.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuHorarioDoctores.Image = CType(resources.GetObject("mnuHorarioDoctores.Image"), System.Drawing.Image)
        Me.mnuHorarioDoctores.ImagePaddingHorizontal = 8
        Me.mnuHorarioDoctores.Name = "mnuHorarioDoctores"
        Me.mnuHorarioDoctores.Text = "Horarios "
        '
        'ExplorerUsuarios
        '
        '
        '
        '
        Me.ExplorerUsuarios.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerUsuarios.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerUsuarios.BackStyle.BorderBottomWidth = 1
        Me.ExplorerUsuarios.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerUsuarios.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerUsuarios.BackStyle.BorderLeftWidth = 1
        Me.ExplorerUsuarios.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerUsuarios.BackStyle.BorderRightWidth = 1
        Me.ExplorerUsuarios.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerUsuarios.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerUsuarios.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerUsuarios.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerUsuarios.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerUsuarios.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerUsuarios.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerUsuarios.Image = CType(resources.GetObject("ExplorerUsuarios.Image"), System.Drawing.Image)
        Me.ExplorerUsuarios.Name = "ExplorerUsuarios"
        Me.ExplorerUsuarios.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuNuevoUsuario, Me.mnuBuscarUsuario})
        Me.ExplorerUsuarios.Text = "USUARIOS"
        '
        '
        '
        Me.ExplorerUsuarios.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerUsuarios.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerUsuarios.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerUsuarios.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerUsuarios.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerUsuarios.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerUsuarios.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerUsuarios.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerUsuarios.TitleStyle.CornerDiameter = 3
        Me.ExplorerUsuarios.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerUsuarios.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerUsuarios.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ExplorerUsuarios.XPSpecialGroup = True
        '
        'mnuNuevoUsuario
        '
        Me.mnuNuevoUsuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuNuevoUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuNuevoUsuario.HotFontUnderline = True
        Me.mnuNuevoUsuario.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuNuevoUsuario.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuNuevoUsuario.Image = CType(resources.GetObject("mnuNuevoUsuario.Image"), System.Drawing.Image)
        Me.mnuNuevoUsuario.ImagePaddingHorizontal = 8
        Me.mnuNuevoUsuario.Name = "mnuNuevoUsuario"
        Me.mnuNuevoUsuario.Text = "Nuevo Usuario"
        Me.mnuNuevoUsuario.Tooltip = "Nuevo Usuario"
        '
        'mnuBuscarUsuario
        '
        Me.mnuBuscarUsuario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuBuscarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuBuscarUsuario.HotFontUnderline = True
        Me.mnuBuscarUsuario.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuBuscarUsuario.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuBuscarUsuario.Image = CType(resources.GetObject("mnuBuscarUsuario.Image"), System.Drawing.Image)
        Me.mnuBuscarUsuario.ImagePaddingHorizontal = 8
        Me.mnuBuscarUsuario.Name = "mnuBuscarUsuario"
        Me.mnuBuscarUsuario.Text = "Buscar Usuario"
        Me.mnuBuscarUsuario.Tooltip = "Buscar Usuario"
        '
        'ExplorerEntidades
        '
        '
        '
        '
        Me.ExplorerEntidades.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerEntidades.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerEntidades.BackStyle.BorderBottomWidth = 1
        Me.ExplorerEntidades.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerEntidades.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerEntidades.BackStyle.BorderLeftWidth = 1
        Me.ExplorerEntidades.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerEntidades.BackStyle.BorderRightWidth = 1
        Me.ExplorerEntidades.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerEntidades.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerEntidades.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerEntidades.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerEntidades.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerEntidades.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerEntidades.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerEntidades.Image = CType(resources.GetObject("ExplorerEntidades.Image"), System.Drawing.Image)
        Me.ExplorerEntidades.Name = "ExplorerEntidades"
        Me.ExplorerEntidades.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuNuevaEntidad, Me.mnuBuscarEntidad, Me.mnuProveedores, Me.mnuBuscarProveedores})
        Me.ExplorerEntidades.Text = "ENTIDADES"
        '
        '
        '
        Me.ExplorerEntidades.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerEntidades.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerEntidades.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerEntidades.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerEntidades.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerEntidades.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerEntidades.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerEntidades.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerEntidades.TitleStyle.CornerDiameter = 3
        Me.ExplorerEntidades.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerEntidades.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerEntidades.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ExplorerEntidades.XPSpecialGroup = True
        '
        'mnuNuevaEntidad
        '
        Me.mnuNuevaEntidad.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuNuevaEntidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuNuevaEntidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuNuevaEntidad.HotFontUnderline = True
        Me.mnuNuevaEntidad.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuNuevaEntidad.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuNuevaEntidad.Image = CType(resources.GetObject("mnuNuevaEntidad.Image"), System.Drawing.Image)
        Me.mnuNuevaEntidad.ImagePaddingHorizontal = 8
        Me.mnuNuevaEntidad.Name = "mnuNuevaEntidad"
        Me.mnuNuevaEntidad.Text = "Nueva Entidad"
        Me.mnuNuevaEntidad.Tooltip = "Nueva Entidad"
        '
        'mnuBuscarEntidad
        '
        Me.mnuBuscarEntidad.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuBuscarEntidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuBuscarEntidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuBuscarEntidad.HotFontUnderline = True
        Me.mnuBuscarEntidad.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuBuscarEntidad.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuBuscarEntidad.Image = CType(resources.GetObject("mnuBuscarEntidad.Image"), System.Drawing.Image)
        Me.mnuBuscarEntidad.ImagePaddingHorizontal = 8
        Me.mnuBuscarEntidad.Name = "mnuBuscarEntidad"
        Me.mnuBuscarEntidad.Text = "Buscar Entidad"
        Me.mnuBuscarEntidad.Tooltip = "Buscar Entidad"
        '
        'mnuProveedores
        '
        Me.mnuProveedores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuProveedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuProveedores.HotFontUnderline = True
        Me.mnuProveedores.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuProveedores.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuProveedores.Image = CType(resources.GetObject("mnuProveedores.Image"), System.Drawing.Image)
        Me.mnuProveedores.ImagePaddingHorizontal = 8
        Me.mnuProveedores.Name = "mnuProveedores"
        Me.mnuProveedores.Text = "Nuevo Proveedor"
        '
        'mnuBuscarProveedores
        '
        Me.mnuBuscarProveedores.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuBuscarProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuBuscarProveedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuBuscarProveedores.HotFontUnderline = True
        Me.mnuBuscarProveedores.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuBuscarProveedores.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuBuscarProveedores.Image = CType(resources.GetObject("mnuBuscarProveedores.Image"), System.Drawing.Image)
        Me.mnuBuscarProveedores.ImagePaddingHorizontal = 8
        Me.mnuBuscarProveedores.Name = "mnuBuscarProveedores"
        Me.mnuBuscarProveedores.Text = "Buscar Proveedor"
        '
        'ExplorerInformes
        '
        '
        '
        '
        Me.ExplorerInformes.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerInformes.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerInformes.BackStyle.BorderBottomWidth = 1
        Me.ExplorerInformes.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerInformes.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerInformes.BackStyle.BorderLeftWidth = 1
        Me.ExplorerInformes.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerInformes.BackStyle.BorderRightWidth = 1
        Me.ExplorerInformes.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerInformes.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerInformes.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerInformes.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerInformes.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerInformes.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerInformes.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerInformes.Image = CType(resources.GetObject("ExplorerInformes.Image"), System.Drawing.Image)
        Me.ExplorerInformes.Name = "ExplorerInformes"
        Me.ExplorerInformes.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuGereradorInformes, Me.mnuProcedimientoDiario, Me.mnuDocumentos})
        Me.ExplorerInformes.Text = "INFORMES"
        '
        '
        '
        Me.ExplorerInformes.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerInformes.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerInformes.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerInformes.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerInformes.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerInformes.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerInformes.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerInformes.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerInformes.TitleStyle.CornerDiameter = 3
        Me.ExplorerInformes.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerInformes.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerInformes.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ExplorerInformes.XPSpecialGroup = True
        '
        'mnuGereradorInformes
        '
        Me.mnuGereradorInformes.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuGereradorInformes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuGereradorInformes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuGereradorInformes.HotFontUnderline = True
        Me.mnuGereradorInformes.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.mnuGereradorInformes.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuGereradorInformes.Image = CType(resources.GetObject("mnuGereradorInformes.Image"), System.Drawing.Image)
        Me.mnuGereradorInformes.ImagePaddingHorizontal = 8
        Me.mnuGereradorInformes.Name = "mnuGereradorInformes"
        Me.mnuGereradorInformes.Text = "Informes Varios"
        '
        'mnuProcedimientoDiario
        '
        Me.mnuProcedimientoDiario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuProcedimientoDiario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuProcedimientoDiario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuProcedimientoDiario.HotFontUnderline = True
        Me.mnuProcedimientoDiario.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.mnuProcedimientoDiario.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuProcedimientoDiario.Image = CType(resources.GetObject("mnuProcedimientoDiario.Image"), System.Drawing.Image)
        Me.mnuProcedimientoDiario.ImagePaddingHorizontal = 8
        Me.mnuProcedimientoDiario.Name = "mnuProcedimientoDiario"
        Me.mnuProcedimientoDiario.Text = "Procedimiento Diario"
        '
        'mnuDocumentos
        '
        Me.mnuDocumentos.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuDocumentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuDocumentos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuDocumentos.HotFontUnderline = True
        Me.mnuDocumentos.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.mnuDocumentos.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuDocumentos.Image = CType(resources.GetObject("mnuDocumentos.Image"), System.Drawing.Image)
        Me.mnuDocumentos.ImagePaddingHorizontal = 8
        Me.mnuDocumentos.Name = "mnuDocumentos"
        Me.mnuDocumentos.Text = "Documentos"
        '
        'ExplorerAdministracion
        '
        '
        '
        '
        Me.ExplorerAdministracion.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerAdministracion.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerAdministracion.BackStyle.BorderBottomWidth = 1
        Me.ExplorerAdministracion.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerAdministracion.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerAdministracion.BackStyle.BorderLeftWidth = 1
        Me.ExplorerAdministracion.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerAdministracion.BackStyle.BorderRightWidth = 1
        Me.ExplorerAdministracion.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerAdministracion.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerAdministracion.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerAdministracion.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerAdministracion.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerAdministracion.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerAdministracion.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerAdministracion.Image = CType(resources.GetObject("ExplorerAdministracion.Image"), System.Drawing.Image)
        Me.ExplorerAdministracion.Name = "ExplorerAdministracion"
        Me.ExplorerAdministracion.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuAutenticacion, Me.mnuInfAuditoria, Me.mnuImporBD, Me.mnuConfigIni, Me.mnuNivelAcceso})
        Me.ExplorerAdministracion.Text = "ADMINISTRACION"
        '
        '
        '
        Me.ExplorerAdministracion.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerAdministracion.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerAdministracion.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerAdministracion.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerAdministracion.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerAdministracion.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerAdministracion.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerAdministracion.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerAdministracion.TitleStyle.CornerDiameter = 3
        Me.ExplorerAdministracion.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerAdministracion.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerAdministracion.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ExplorerAdministracion.XPSpecialGroup = True
        '
        'mnuAutenticacion
        '
        Me.mnuAutenticacion.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuAutenticacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuAutenticacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuAutenticacion.HotFontUnderline = True
        Me.mnuAutenticacion.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuAutenticacion.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuAutenticacion.Image = CType(resources.GetObject("mnuAutenticacion.Image"), System.Drawing.Image)
        Me.mnuAutenticacion.ImagePaddingHorizontal = 8
        Me.mnuAutenticacion.Name = "mnuAutenticacion"
        Me.mnuAutenticacion.Text = "Autenticación Servidor"
        '
        'mnuInfAuditoria
        '
        Me.mnuInfAuditoria.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuInfAuditoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuInfAuditoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuInfAuditoria.HotFontUnderline = True
        Me.mnuInfAuditoria.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuInfAuditoria.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuInfAuditoria.Image = CType(resources.GetObject("mnuInfAuditoria.Image"), System.Drawing.Image)
        Me.mnuInfAuditoria.ImagePaddingHorizontal = 8
        Me.mnuInfAuditoria.Name = "mnuInfAuditoria"
        Me.mnuInfAuditoria.Text = "Informe Auditoria"
        '
        'mnuImporBD
        '
        Me.mnuImporBD.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuImporBD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuImporBD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuImporBD.HotFontUnderline = True
        Me.mnuImporBD.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuImporBD.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuImporBD.Image = CType(resources.GetObject("mnuImporBD.Image"), System.Drawing.Image)
        Me.mnuImporBD.ImagePaddingHorizontal = 8
        Me.mnuImporBD.Name = "mnuImporBD"
        Me.mnuImporBD.Text = "Importacion BD Excel"
        '
        'mnuConfigIni
        '
        Me.mnuConfigIni.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuConfigIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuConfigIni.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuConfigIni.HotFontUnderline = True
        Me.mnuConfigIni.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.mnuConfigIni.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuConfigIni.Image = CType(resources.GetObject("mnuConfigIni.Image"), System.Drawing.Image)
        Me.mnuConfigIni.ImagePaddingHorizontal = 8
        Me.mnuConfigIni.Name = "mnuConfigIni"
        Me.mnuConfigIni.Text = "Configuración Inicial"
        '
        'mnuNivelAcceso
        '
        Me.mnuNivelAcceso.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuNivelAcceso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuNivelAcceso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuNivelAcceso.HotFontUnderline = True
        Me.mnuNivelAcceso.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.mnuNivelAcceso.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuNivelAcceso.Image = CType(resources.GetObject("mnuNivelAcceso.Image"), System.Drawing.Image)
        Me.mnuNivelAcceso.ImagePaddingHorizontal = 8
        Me.mnuNivelAcceso.Name = "mnuNivelAcceso"
        Me.mnuNivelAcceso.Text = "Niveles de Acceso"
        '
        'ExplorerCitas
        '
        '
        '
        '
        Me.ExplorerCitas.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerCitas.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerCitas.BackStyle.BorderBottomWidth = 1
        Me.ExplorerCitas.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerCitas.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerCitas.BackStyle.BorderLeftWidth = 1
        Me.ExplorerCitas.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerCitas.BackStyle.BorderRightWidth = 1
        Me.ExplorerCitas.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerCitas.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerCitas.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerCitas.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerCitas.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerCitas.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerCitas.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerCitas.Image = CType(resources.GetObject("ExplorerCitas.Image"), System.Drawing.Image)
        Me.ExplorerCitas.Name = "ExplorerCitas"
        Me.ExplorerCitas.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuReminderCitas, Me.mnuBloqDesCalendario})
        Me.ExplorerCitas.Text = "CITAS"
        '
        '
        '
        Me.ExplorerCitas.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerCitas.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerCitas.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerCitas.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerCitas.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerCitas.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerCitas.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerCitas.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerCitas.TitleStyle.CornerDiameter = 3
        Me.ExplorerCitas.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerCitas.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerCitas.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ExplorerCitas.XPSpecialGroup = True
        '
        'mnuReminderCitas
        '
        Me.mnuReminderCitas.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuReminderCitas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuReminderCitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuReminderCitas.HotFontUnderline = True
        Me.mnuReminderCitas.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.mnuReminderCitas.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuReminderCitas.Image = CType(resources.GetObject("mnuReminderCitas.Image"), System.Drawing.Image)
        Me.mnuReminderCitas.ImagePaddingHorizontal = 8
        Me.mnuReminderCitas.Name = "mnuReminderCitas"
        Me.mnuReminderCitas.Text = "Reminder Citas"
        Me.mnuReminderCitas.Tooltip = "Reminder Citas"
        '
        'mnuBloqDesCalendario
        '
        Me.mnuBloqDesCalendario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuBloqDesCalendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuBloqDesCalendario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuBloqDesCalendario.HotFontUnderline = True
        Me.mnuBloqDesCalendario.HotForeColor = System.Drawing.SystemColors.ControlDark
        Me.mnuBloqDesCalendario.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuBloqDesCalendario.Image = CType(resources.GetObject("mnuBloqDesCalendario.Image"), System.Drawing.Image)
        Me.mnuBloqDesCalendario.ImagePaddingHorizontal = 8
        Me.mnuBloqDesCalendario.Name = "mnuBloqDesCalendario"
        Me.mnuBloqDesCalendario.Text = "Bloq./Desbloq. Calendario"
        '
        'ExplorerContab
        '
        '
        '
        '
        Me.ExplorerContab.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerContab.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerContab.BackStyle.BorderBottomWidth = 1
        Me.ExplorerContab.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerContab.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerContab.BackStyle.BorderLeftWidth = 1
        Me.ExplorerContab.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerContab.BackStyle.BorderRightWidth = 1
        Me.ExplorerContab.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerContab.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerContab.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerContab.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerContab.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerContab.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerContab.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerContab.Image = CType(resources.GetObject("ExplorerContab.Image"), System.Drawing.Image)
        Me.ExplorerContab.Name = "ExplorerContab"
        Me.ExplorerContab.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuRcaja, Me.mnuEgreso, Me.mnuPresupuesto, Me.mnuItems, Me.mnuEstadoCuenta, Me.mnuGastos, Me.mnuMovimientoDiario})
        Me.ExplorerContab.Text = "CONTABILIDAD"
        '
        '
        '
        Me.ExplorerContab.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerContab.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerContab.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerContab.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerContab.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerContab.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerContab.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerContab.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerContab.TitleStyle.CornerDiameter = 3
        Me.ExplorerContab.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerContab.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerContab.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'mnuRcaja
        '
        Me.mnuRcaja.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuRcaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuRcaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuRcaja.HotFontUnderline = True
        Me.mnuRcaja.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuRcaja.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuRcaja.Image = CType(resources.GetObject("mnuRcaja.Image"), System.Drawing.Image)
        Me.mnuRcaja.ImagePaddingHorizontal = 8
        Me.mnuRcaja.Name = "mnuRcaja"
        Me.mnuRcaja.Text = "Recibo de Caja"
        Me.mnuRcaja.Tooltip = "Recibo de Caja"
        '
        'mnuEgreso
        '
        Me.mnuEgreso.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuEgreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuEgreso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuEgreso.HotFontUnderline = True
        Me.mnuEgreso.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuEgreso.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuEgreso.Image = CType(resources.GetObject("mnuEgreso.Image"), System.Drawing.Image)
        Me.mnuEgreso.ImagePaddingHorizontal = 8
        Me.mnuEgreso.Name = "mnuEgreso"
        Me.mnuEgreso.Text = "Comprobande de Egreso"
        '
        'mnuPresupuesto
        '
        Me.mnuPresupuesto.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuPresupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuPresupuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuPresupuesto.HotFontUnderline = True
        Me.mnuPresupuesto.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuPresupuesto.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuPresupuesto.Image = CType(resources.GetObject("mnuPresupuesto.Image"), System.Drawing.Image)
        Me.mnuPresupuesto.ImagePaddingHorizontal = 8
        Me.mnuPresupuesto.Name = "mnuPresupuesto"
        Me.mnuPresupuesto.Text = "Presupuesto"
        '
        'mnuItems
        '
        Me.mnuItems.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuItems.HotFontUnderline = True
        Me.mnuItems.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuItems.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuItems.Image = CType(resources.GetObject("mnuItems.Image"), System.Drawing.Image)
        Me.mnuItems.ImagePaddingHorizontal = 8
        Me.mnuItems.Name = "mnuItems"
        Me.mnuItems.Text = "Valor Procedimientos"
        '
        'mnuEstadoCuenta
        '
        Me.mnuEstadoCuenta.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuEstadoCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuEstadoCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuEstadoCuenta.HotFontUnderline = True
        Me.mnuEstadoCuenta.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuEstadoCuenta.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuEstadoCuenta.Image = CType(resources.GetObject("mnuEstadoCuenta.Image"), System.Drawing.Image)
        Me.mnuEstadoCuenta.ImagePaddingHorizontal = 8
        Me.mnuEstadoCuenta.Name = "mnuEstadoCuenta"
        Me.mnuEstadoCuenta.Text = "Estado de Cuenta"
        '
        'mnuGastos
        '
        Me.mnuGastos.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuGastos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuGastos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuGastos.HotFontUnderline = True
        Me.mnuGastos.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuGastos.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuGastos.Image = CType(resources.GetObject("mnuGastos.Image"), System.Drawing.Image)
        Me.mnuGastos.ImagePaddingHorizontal = 8
        Me.mnuGastos.Name = "mnuGastos"
        Me.mnuGastos.Text = "Gastos"
        '
        'mnuMovimientoDiario
        '
        Me.mnuMovimientoDiario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuMovimientoDiario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuMovimientoDiario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuMovimientoDiario.HotFontUnderline = True
        Me.mnuMovimientoDiario.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuMovimientoDiario.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuMovimientoDiario.Image = CType(resources.GetObject("mnuMovimientoDiario.Image"), System.Drawing.Image)
        Me.mnuMovimientoDiario.ImagePaddingHorizontal = 8
        Me.mnuMovimientoDiario.Name = "mnuMovimientoDiario"
        Me.mnuMovimientoDiario.Text = "Movimiento Diario"
        '
        'ExplorerVarios
        '
        '
        '
        '
        Me.ExplorerVarios.BackStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerVarios.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerVarios.BackStyle.BorderBottomWidth = 1
        Me.ExplorerVarios.BackStyle.BorderColor = System.Drawing.Color.White
        Me.ExplorerVarios.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerVarios.BackStyle.BorderLeftWidth = 1
        Me.ExplorerVarios.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ExplorerVarios.BackStyle.BorderRightWidth = 1
        Me.ExplorerVarios.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExplorerVarios.ExpandBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerVarios.ExpandBorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ExplorerVarios.ExpandForeColor = System.Drawing.Color.White
        Me.ExplorerVarios.ExpandHotBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.ExplorerVarios.ExpandHotBorderColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExplorerVarios.ExpandHotForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExplorerVarios.Image = CType(resources.GetObject("ExplorerVarios.Image"), System.Drawing.Image)
        Me.ExplorerVarios.Name = "ExplorerVarios"
        Me.ExplorerVarios.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.mnuIlustraciones})
        Me.ExplorerVarios.Text = "VARIOS"
        '
        '
        '
        Me.ExplorerVarios.TitleHotStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerVarios.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerVarios.TitleHotStyle.CornerDiameter = 3
        Me.ExplorerVarios.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerVarios.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerVarios.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.ExplorerVarios.TitleStyle.BackColor = System.Drawing.Color.White
        Me.ExplorerVarios.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ExplorerVarios.TitleStyle.CornerDiameter = 3
        Me.ExplorerVarios.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerVarios.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ExplorerVarios.TitleStyle.TextColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        '
        'mnuIlustraciones
        '
        Me.mnuIlustraciones.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.mnuIlustraciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mnuIlustraciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.mnuIlustraciones.HotFontUnderline = True
        Me.mnuIlustraciones.HotForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mnuIlustraciones.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None
        Me.mnuIlustraciones.Image = CType(resources.GetObject("mnuIlustraciones.Image"), System.Drawing.Image)
        Me.mnuIlustraciones.ImagePaddingHorizontal = 8
        Me.mnuIlustraciones.Name = "mnuIlustraciones"
        Me.mnuIlustraciones.Text = "Ilustraciones"
        '
        'txtTopeCita
        '
        Me.txtTopeCita.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTopeCita.Border.Class = "TextBoxBorder"
        Me.txtTopeCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopeCita.Location = New System.Drawing.Point(55, 37)
        Me.txtTopeCita.Name = "txtTopeCita"
        Me.txtTopeCita.Size = New System.Drawing.Size(91, 21)
        Me.txtTopeCita.TabIndex = 1
        Me.txtTopeCita.Text = "35"
        Me.txtTopeCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalModificar2
        '
        Me.btnCalModificar2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalModificar2.Image = CType(resources.GetObject("btnCalModificar2.Image"), System.Drawing.Image)
        Me.btnCalModificar2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCalModificar2.Location = New System.Drawing.Point(109, 64)
        Me.btnCalModificar2.Name = "btnCalModificar2"
        Me.btnCalModificar2.Size = New System.Drawing.Size(67, 39)
        Me.btnCalModificar2.SubItemsExpandWidth = 11
        Me.btnCalModificar2.TabIndex = 2
        Me.btnCalModificar2.Text = "MODIFICAR"
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX20.Location = New System.Drawing.Point(55, 11)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(91, 20)
        Me.LabelX20.TabIndex = 0
        Me.LabelX20.Text = "TOPE CITAS "
        Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnCalAdicionar2
        '
        Me.btnCalAdicionar2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalAdicionar2.Image = CType(resources.GetObject("btnCalAdicionar2.Image"), System.Drawing.Image)
        Me.btnCalAdicionar2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCalAdicionar2.Location = New System.Drawing.Point(18, 65)
        Me.btnCalAdicionar2.Name = "btnCalAdicionar2"
        Me.btnCalAdicionar2.Size = New System.Drawing.Size(69, 40)
        Me.btnCalAdicionar2.SubItemsExpandWidth = 10
        Me.btnCalAdicionar2.TabIndex = 3
        Me.btnCalAdicionar2.Text = "ADICIONAR"
        '
        'PanelMenuPrincipalIzq
        '
        Me.PanelMenuPrincipalIzq.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelMenuPrincipalIzq.Controls.Add(Me.btnRetrocedermes)
        Me.PanelMenuPrincipalIzq.Controls.Add(Me.btnAvanzarMes)
        Me.PanelMenuPrincipalIzq.Controls.Add(Me.btnOpCalendar)
        Me.PanelMenuPrincipalIzq.Controls.Add(Me.CalOrthosoft)
        Me.PanelMenuPrincipalIzq.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuPrincipalIzq.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuPrincipalIzq.Name = "PanelMenuPrincipalIzq"
        Me.PanelMenuPrincipalIzq.Size = New System.Drawing.Size(171, 200)
        '
        '
        '
        Me.PanelMenuPrincipalIzq.Style.Class = "RibbonClientPanel"
        Me.PanelMenuPrincipalIzq.TabIndex = 0
        Me.PanelMenuPrincipalIzq.Text = "RibbonClientPanel5"
        '
        'btnRetrocedermes
        '
        Me.btnRetrocedermes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRetrocedermes.Image = CType(resources.GetObject("btnRetrocedermes.Image"), System.Drawing.Image)
        Me.btnRetrocedermes.Location = New System.Drawing.Point(12, 7)
        Me.btnRetrocedermes.Name = "btnRetrocedermes"
        Me.btnRetrocedermes.Size = New System.Drawing.Size(43, 32)
        Me.btnRetrocedermes.TabIndex = 0
        '
        'btnAvanzarMes
        '
        Me.btnAvanzarMes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAvanzarMes.Image = CType(resources.GetObject("btnAvanzarMes.Image"), System.Drawing.Image)
        Me.btnAvanzarMes.Location = New System.Drawing.Point(123, 7)
        Me.btnAvanzarMes.Name = "btnAvanzarMes"
        Me.btnAvanzarMes.Size = New System.Drawing.Size(43, 32)
        Me.btnAvanzarMes.TabIndex = 2
        '
        'btnOpCalendar
        '
        Me.btnOpCalendar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOpCalendar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOpCalendar.Image = CType(resources.GetObject("btnOpCalendar.Image"), System.Drawing.Image)
        Me.btnOpCalendar.Location = New System.Drawing.Point(68, 7)
        Me.btnOpCalendar.Name = "btnOpCalendar"
        Me.btnOpCalendar.Size = New System.Drawing.Size(43, 32)
        Me.btnOpCalendar.TabIndex = 1
        '
        'CalOrthosoft
        '
        Me.CalOrthosoft.AllowDrop = True
        Me.CalOrthosoft.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CalOrthosoft.Location = New System.Drawing.Point(0, 45)
        Me.CalOrthosoft.Name = "CalOrthosoft"
        Me.CalOrthosoft.OcxState = CType(resources.GetObject("CalOrthosoft.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CalOrthosoft.Size = New System.Drawing.Size(171, 155)
        Me.CalOrthosoft.TabIndex = 3
        '
        'PanelCitasHoy
        '
        Me.PanelCitasHoy.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelCitasHoy.Controls.Add(Me.RibbonClientPanel1)
        Me.PanelCitasHoy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelCitasHoy.Location = New System.Drawing.Point(0, 523)
        Me.PanelCitasHoy.Name = "PanelCitasHoy"
        Me.PanelCitasHoy.Size = New System.Drawing.Size(182, 110)
        Me.PanelCitasHoy.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelCitasHoy.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelCitasHoy.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelCitasHoy.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelCitasHoy.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelCitasHoy.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelCitasHoy.Style.GradientAngle = 90
        Me.PanelCitasHoy.TabIndex = 3
        Me.PanelCitasHoy.Visible = False
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.lblTotalPacientes)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloPacientes)
        Me.RibbonClientPanel1.Controls.Add(Me.lblPacientes)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(182, 110)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 3
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'lblTotalPacientes
        '
        Me.lblTotalPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPacientes.ForeColor = System.Drawing.Color.White
        Me.lblTotalPacientes.Location = New System.Drawing.Point(0, 36)
        Me.lblTotalPacientes.Name = "lblTotalPacientes"
        Me.lblTotalPacientes.Size = New System.Drawing.Size(182, 71)
        Me.lblTotalPacientes.TabIndex = 2
        Me.lblTotalPacientes.Text = "00"
        Me.lblTotalPacientes.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloPacientes
        '
        Me.lblTituloPacientes.BackColor = System.Drawing.Color.Transparent
        Me.lblTituloPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloPacientes.ForeColor = System.Drawing.Color.White
        Me.lblTituloPacientes.Location = New System.Drawing.Point(0, 17)
        Me.lblTituloPacientes.Name = "lblTituloPacientes"
        Me.lblTituloPacientes.Size = New System.Drawing.Size(182, 19)
        Me.lblTituloPacientes.TabIndex = 1
        Me.lblTituloPacientes.Text = "PACIENTES HOY"
        Me.lblTituloPacientes.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblPacientes
        '
        Me.lblPacientes.BackColor = System.Drawing.Color.Transparent
        Me.lblPacientes.ForeColor = System.Drawing.Color.White
        Me.lblPacientes.Location = New System.Drawing.Point(0, 0)
        Me.lblPacientes.Name = "lblPacientes"
        Me.lblPacientes.Size = New System.Drawing.Size(182, 21)
        Me.lblPacientes.TabIndex = 0
        Me.lblPacientes.Text = "PACIENTES"
        Me.lblPacientes.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX19.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX19.Location = New System.Drawing.Point(12, 3)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(162, 22)
        Me.LabelX19.TabIndex = 115
        Me.LabelX19.Text = "CONFIGURAR CITAS"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'clcEndTime
        '
        Me.clcEndTime.CustomFormat = "h:mm tt"
        Me.clcEndTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.clcEndTime.DropDownCalendar.Location = New System.Drawing.Point(0, 0)
        Me.clcEndTime.DropDownCalendar.Name = ""
        Me.clcEndTime.DropDownCalendar.Size = New System.Drawing.Size(166, 136)
        Me.clcEndTime.DropDownCalendar.TabIndex = 0
        Me.clcEndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard
        Me.clcEndTime.Location = New System.Drawing.Point(217, 310)
        Me.clcEndTime.Name = "clcEndTime"
        Me.clcEndTime.ShowDropDown = False
        Me.clcEndTime.ShowUpDown = True
        Me.clcEndTime.Size = New System.Drawing.Size(111, 20)
        Me.clcEndTime.TabIndex = 5
        Me.clcEndTime.Value = New Date(2002, 1, 18, 0, 0, 0, 0)
        Me.clcEndTime.Visible = False
        '
        'clcStartTime
        '
        Me.clcStartTime.CustomFormat = "h:mm tt"
        Me.clcStartTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.clcStartTime.DropDownCalendar.Location = New System.Drawing.Point(0, 0)
        Me.clcStartTime.DropDownCalendar.Name = ""
        Me.clcStartTime.DropDownCalendar.Size = New System.Drawing.Size(166, 136)
        Me.clcStartTime.DropDownCalendar.TabIndex = 0
        Me.clcStartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard
        Me.clcStartTime.Location = New System.Drawing.Point(218, 284)
        Me.clcStartTime.Name = "clcStartTime"
        Me.clcStartTime.ShowDropDown = False
        Me.clcStartTime.ShowUpDown = True
        Me.clcStartTime.Size = New System.Drawing.Size(111, 20)
        Me.clcStartTime.TabIndex = 3
        Me.clcStartTime.Value = New Date(2002, 1, 18, 0, 0, 0, 0)
        Me.clcStartTime.Visible = False
        '
        'PanelFicha
        '
        Me.PanelFicha.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelFicha.Controls.Add(Me.PanelConfigCal)
        Me.PanelFicha.Controls.Add(Me.btnEstudiosPac)
        Me.PanelFicha.Controls.Add(Me.btnEstadoCuenta)
        Me.PanelFicha.Controls.Add(Me.btnEnvioSMSPersonalizado)
        Me.PanelFicha.Controls.Add(Me.btnPacOdontograma)
        Me.PanelFicha.Controls.Add(Me.ExpandableCalendario)
        Me.PanelFicha.Controls.Add(Me.lblCodigo)
        Me.PanelFicha.Controls.Add(Me.lblNHclinica)
        Me.PanelFicha.Controls.Add(Me.txtnhistoria_ficha)
        Me.PanelFicha.Controls.Add(Me.txtId_ficha)
        Me.PanelFicha.Controls.Add(Me.txtEmail_ficha)
        Me.PanelFicha.Controls.Add(Me.lblEmail)
        Me.PanelFicha.Controls.Add(Me.lblCelular)
        Me.PanelFicha.Controls.Add(Me.txtCelular_ficha)
        Me.PanelFicha.Controls.Add(Me.lblTelCasa)
        Me.PanelFicha.Controls.Add(Me.txtTelCasa_ficha)
        Me.PanelFicha.Controls.Add(Me.txtReferido_ficha)
        Me.PanelFicha.Controls.Add(Me.lblRemitido)
        Me.PanelFicha.Controls.Add(Me.txtNombre_ficha)
        Me.PanelFicha.Controls.Add(Me.lblNombre)
        Me.PanelFicha.Controls.Add(Me.pbxFoto_ficha)
        Me.PanelFicha.Controls.Add(Me.btnBuscar)
        Me.PanelFicha.Controls.Add(Me.btnEditarFicha)
        Me.PanelFicha.Controls.Add(Me.btnEnvioEmail)
        Me.PanelFicha.Controls.Add(Me.gpProximaCita)
        Me.PanelFicha.Controls.Add(Me.btnProcedimiento)
        Me.PanelFicha.Controls.Add(Me.btnHistoriaClinica)
        Me.PanelFicha.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFicha.Location = New System.Drawing.Point(171, 130)
        Me.PanelFicha.Name = "PanelFicha"
        Me.PanelFicha.Size = New System.Drawing.Size(562, 120)
        Me.PanelFicha.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelFicha.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelFicha.Style.BackColor2.Color = System.Drawing.Color.SteelBlue
        Me.PanelFicha.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelFicha.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelFicha.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelFicha.Style.GradientAngle = 90
        Me.PanelFicha.TabIndex = 2
        '
        'PanelConfigCal
        '
        Me.PanelConfigCal.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelConfigCal.Controls.Add(Me.txtIdCalendario)
        Me.PanelConfigCal.Controls.Add(Me.btnCalEliminar)
        Me.PanelConfigCal.Controls.Add(Me.btnCalModificar)
        Me.PanelConfigCal.Controls.Add(Me.txtDiaLibre)
        Me.PanelConfigCal.Controls.Add(Me.lblDiaLibre)
        Me.PanelConfigCal.Controls.Add(Me.GroupTBloqueoDia)
        Me.PanelConfigCal.Controls.Add(Me.txtDiaSeleccionado)
        Me.PanelConfigCal.Controls.Add(Me.lblDiaSeleccionado)
        Me.PanelConfigCal.Controls.Add(Me.GroupRangoAgenda)
        Me.PanelConfigCal.Controls.Add(Me.lblConfigCal)
        Me.PanelConfigCal.Controls.Add(Me.GroupHorarioLaboral)
        Me.PanelConfigCal.Controls.Add(Me.btnCalAdicionar)
        Me.PanelConfigCal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelConfigCal.Location = New System.Drawing.Point(0, 0)
        Me.PanelConfigCal.Name = "PanelConfigCal"
        Me.PanelConfigCal.Size = New System.Drawing.Size(552, 120)
        Me.PanelConfigCal.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelConfigCal.Style.BackColor1.Color = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelConfigCal.Style.BackColor2.Color = System.Drawing.Color.Azure
        Me.PanelConfigCal.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelConfigCal.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelConfigCal.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelConfigCal.Style.GradientAngle = 90
        Me.PanelConfigCal.TabIndex = 0
        Me.PanelConfigCal.Visible = False
        '
        'txtIdCalendario
        '
        Me.txtIdCalendario.Location = New System.Drawing.Point(461, 6)
        Me.txtIdCalendario.Name = "txtIdCalendario"
        Me.txtIdCalendario.ReadOnly = True
        Me.txtIdCalendario.Size = New System.Drawing.Size(70, 17)
        Me.txtIdCalendario.TabIndex = 1
        Me.txtIdCalendario.Visible = False
        '
        'btnCalEliminar
        '
        Me.btnCalEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalEliminar.Image = CType(resources.GetObject("btnCalEliminar.Image"), System.Drawing.Image)
        Me.btnCalEliminar.Location = New System.Drawing.Point(441, 78)
        Me.btnCalEliminar.Name = "btnCalEliminar"
        Me.btnCalEliminar.Size = New System.Drawing.Size(91, 24)
        Me.btnCalEliminar.TabIndex = 7
        Me.btnCalEliminar.Text = "ELIMINAR"
        '
        'btnCalModificar
        '
        Me.btnCalModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalModificar.Image = CType(resources.GetObject("btnCalModificar.Image"), System.Drawing.Image)
        Me.btnCalModificar.Location = New System.Drawing.Point(441, 51)
        Me.btnCalModificar.Name = "btnCalModificar"
        Me.btnCalModificar.Size = New System.Drawing.Size(91, 24)
        Me.btnCalModificar.SubItemsExpandWidth = 11
        Me.btnCalModificar.TabIndex = 6
        Me.btnCalModificar.Text = "MODIFICAR"
        '
        'txtDiaLibre
        '
        Me.txtDiaLibre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtDiaLibre.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiaLibre.Border.Class = "TextBoxBorder"
        Me.txtDiaLibre.Enabled = False
        Me.txtDiaLibre.Location = New System.Drawing.Point(219, 101)
        Me.txtDiaLibre.Name = "txtDiaLibre"
        Me.txtDiaLibre.Size = New System.Drawing.Size(15, 15)
        Me.txtDiaLibre.TabIndex = 11
        Me.txtDiaLibre.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'lblDiaLibre
        '
        Me.lblDiaLibre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaLibre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDiaLibre.Location = New System.Drawing.Point(165, 101)
        Me.lblDiaLibre.Name = "lblDiaLibre"
        Me.lblDiaLibre.Size = New System.Drawing.Size(53, 15)
        Me.lblDiaLibre.TabIndex = 10
        Me.lblDiaLibre.Text = "Día Libre"
        '
        'GroupTBloqueoDia
        '
        Me.GroupTBloqueoDia.BackColor = System.Drawing.Color.Transparent
        Me.GroupTBloqueoDia.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupTBloqueoDia.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupTBloqueoDia.Controls.Add(Me.txtModificado)
        Me.GroupTBloqueoDia.Controls.Add(Me.txtNoLaborable)
        Me.GroupTBloqueoDia.Controls.Add(Me.txtFestivo)
        Me.GroupTBloqueoDia.Controls.Add(Me.rbtModificado)
        Me.GroupTBloqueoDia.Controls.Add(Me.rbtNolaborable)
        Me.GroupTBloqueoDia.Controls.Add(Me.rbtFestivo)
        Me.GroupTBloqueoDia.Location = New System.Drawing.Point(305, 25)
        Me.GroupTBloqueoDia.Name = "GroupTBloqueoDia"
        Me.GroupTBloqueoDia.Size = New System.Drawing.Size(132, 73)
        '
        '
        '
        Me.GroupTBloqueoDia.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupTBloqueoDia.Style.BackColorGradientAngle = 90
        Me.GroupTBloqueoDia.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupTBloqueoDia.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTBloqueoDia.Style.BorderBottomWidth = 1
        Me.GroupTBloqueoDia.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupTBloqueoDia.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTBloqueoDia.Style.BorderLeftWidth = 1
        Me.GroupTBloqueoDia.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTBloqueoDia.Style.BorderRightWidth = 1
        Me.GroupTBloqueoDia.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTBloqueoDia.Style.BorderTopWidth = 1
        Me.GroupTBloqueoDia.Style.CornerDiameter = 4
        Me.GroupTBloqueoDia.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupTBloqueoDia.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupTBloqueoDia.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupTBloqueoDia.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupTBloqueoDia.TabIndex = 4
        Me.GroupTBloqueoDia.Text = "TIPO BLOQUEO DIA"
        '
        'txtModificado
        '
        Me.txtModificado.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.txtModificado.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModificado.Border.Class = "TextBoxBorder"
        Me.txtModificado.Enabled = False
        Me.txtModificado.Location = New System.Drawing.Point(105, 36)
        Me.txtModificado.Name = "txtModificado"
        Me.txtModificado.Size = New System.Drawing.Size(12, 12)
        Me.txtModificado.TabIndex = 5
        Me.txtModificado.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'txtNoLaborable
        '
        Me.txtNoLaborable.BackColor = System.Drawing.Color.Red
        '
        '
        '
        Me.txtNoLaborable.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNoLaborable.Border.Class = "TextBoxBorder"
        Me.txtNoLaborable.Enabled = False
        Me.txtNoLaborable.Location = New System.Drawing.Point(105, 19)
        Me.txtNoLaborable.Name = "txtNoLaborable"
        Me.txtNoLaborable.Size = New System.Drawing.Size(12, 12)
        Me.txtNoLaborable.TabIndex = 3
        Me.txtNoLaborable.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'txtFestivo
        '
        Me.txtFestivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        '
        '
        Me.txtFestivo.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtFestivo.Border.Class = "TextBoxBorder"
        Me.txtFestivo.Enabled = False
        Me.txtFestivo.Location = New System.Drawing.Point(105, 3)
        Me.txtFestivo.Name = "txtFestivo"
        Me.txtFestivo.Size = New System.Drawing.Size(12, 12)
        Me.txtFestivo.TabIndex = 1
        Me.txtFestivo.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'rbtModificado
        '
        Me.rbtModificado.AutoSize = True
        Me.rbtModificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtModificado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtModificado.Location = New System.Drawing.Point(3, 33)
        Me.rbtModificado.Name = "rbtModificado"
        Me.rbtModificado.Size = New System.Drawing.Size(87, 17)
        Me.rbtModificado.TabIndex = 4
        Me.rbtModificado.Text = "Modificado"
        Me.rbtModificado.UseVisualStyleBackColor = True
        '
        'rbtNolaborable
        '
        Me.rbtNolaborable.AutoSize = True
        Me.rbtNolaborable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNolaborable.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtNolaborable.Location = New System.Drawing.Point(3, 18)
        Me.rbtNolaborable.Name = "rbtNolaborable"
        Me.rbtNolaborable.Size = New System.Drawing.Size(101, 17)
        Me.rbtNolaborable.TabIndex = 2
        Me.rbtNolaborable.Text = "No Laborable"
        Me.rbtNolaborable.UseVisualStyleBackColor = True
        '
        'rbtFestivo
        '
        Me.rbtFestivo.AutoSize = True
        Me.rbtFestivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFestivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtFestivo.Location = New System.Drawing.Point(3, 3)
        Me.rbtFestivo.Name = "rbtFestivo"
        Me.rbtFestivo.Size = New System.Drawing.Size(66, 17)
        Me.rbtFestivo.TabIndex = 0
        Me.rbtFestivo.Text = "Festivo"
        Me.rbtFestivo.UseVisualStyleBackColor = True
        '
        'txtDiaSeleccionado
        '
        Me.txtDiaSeleccionado.BackColor = System.Drawing.Color.Honeydew
        '
        '
        '
        Me.txtDiaSeleccionado.Border.BackColor = System.Drawing.Color.Transparent
        Me.txtDiaSeleccionado.Border.Class = "TextBoxBorder"
        Me.txtDiaSeleccionado.Enabled = False
        Me.txtDiaSeleccionado.Location = New System.Drawing.Point(104, 100)
        Me.txtDiaSeleccionado.Name = "txtDiaSeleccionado"
        Me.txtDiaSeleccionado.Size = New System.Drawing.Size(15, 15)
        Me.txtDiaSeleccionado.TabIndex = 9
        Me.txtDiaSeleccionado.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'lblDiaSeleccionado
        '
        Me.lblDiaSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaSeleccionado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDiaSeleccionado.Location = New System.Drawing.Point(9, 99)
        Me.lblDiaSeleccionado.Name = "lblDiaSeleccionado"
        Me.lblDiaSeleccionado.Size = New System.Drawing.Size(108, 17)
        Me.lblDiaSeleccionado.TabIndex = 8
        Me.lblDiaSeleccionado.Text = "Día Seleccionado"
        '
        'GroupRangoAgenda
        '
        Me.GroupRangoAgenda.BackColor = System.Drawing.Color.Transparent
        Me.GroupRangoAgenda.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupRangoAgenda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupRangoAgenda.Controls.Add(Me.rbtConfig5min)
        Me.GroupRangoAgenda.Controls.Add(Me.rbtConfig30min)
        Me.GroupRangoAgenda.Controls.Add(Me.rbtConfig15min)
        Me.GroupRangoAgenda.Controls.Add(Me.rbtConfig10min)
        Me.GroupRangoAgenda.Location = New System.Drawing.Point(165, 25)
        Me.GroupRangoAgenda.Name = "GroupRangoAgenda"
        Me.GroupRangoAgenda.Size = New System.Drawing.Size(134, 73)
        '
        '
        '
        Me.GroupRangoAgenda.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupRangoAgenda.Style.BackColorGradientAngle = 90
        Me.GroupRangoAgenda.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupRangoAgenda.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupRangoAgenda.Style.BorderBottomWidth = 1
        Me.GroupRangoAgenda.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupRangoAgenda.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupRangoAgenda.Style.BorderLeftWidth = 1
        Me.GroupRangoAgenda.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupRangoAgenda.Style.BorderRightWidth = 1
        Me.GroupRangoAgenda.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupRangoAgenda.Style.BorderTopWidth = 1
        Me.GroupRangoAgenda.Style.CornerDiameter = 4
        Me.GroupRangoAgenda.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupRangoAgenda.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupRangoAgenda.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupRangoAgenda.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupRangoAgenda.TabIndex = 3
        Me.GroupRangoAgenda.Text = "RANGO AGENDA"
        '
        'rbtConfig5min
        '
        Me.rbtConfig5min.AutoSize = True
        Me.rbtConfig5min.Checked = True
        Me.rbtConfig5min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtConfig5min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtConfig5min.Location = New System.Drawing.Point(3, 1)
        Me.rbtConfig5min.Name = "rbtConfig5min"
        Me.rbtConfig5min.Size = New System.Drawing.Size(55, 17)
        Me.rbtConfig5min.TabIndex = 0
        Me.rbtConfig5min.TabStop = True
        Me.rbtConfig5min.Text = "5 min"
        Me.rbtConfig5min.UseVisualStyleBackColor = True
        '
        'rbtConfig30min
        '
        Me.rbtConfig30min.AutoSize = True
        Me.rbtConfig30min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtConfig30min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtConfig30min.Location = New System.Drawing.Point(64, 24)
        Me.rbtConfig30min.Name = "rbtConfig30min"
        Me.rbtConfig30min.Size = New System.Drawing.Size(62, 17)
        Me.rbtConfig30min.TabIndex = 3
        Me.rbtConfig30min.Text = "30 min"
        Me.rbtConfig30min.UseVisualStyleBackColor = True
        '
        'rbtConfig15min
        '
        Me.rbtConfig15min.AutoSize = True
        Me.rbtConfig15min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtConfig15min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtConfig15min.Location = New System.Drawing.Point(64, 1)
        Me.rbtConfig15min.Name = "rbtConfig15min"
        Me.rbtConfig15min.Size = New System.Drawing.Size(62, 17)
        Me.rbtConfig15min.TabIndex = 1
        Me.rbtConfig15min.Text = "15 min"
        Me.rbtConfig15min.UseVisualStyleBackColor = True
        '
        'rbtConfig10min
        '
        Me.rbtConfig10min.AutoSize = True
        Me.rbtConfig10min.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtConfig10min.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtConfig10min.Location = New System.Drawing.Point(3, 24)
        Me.rbtConfig10min.Name = "rbtConfig10min"
        Me.rbtConfig10min.Size = New System.Drawing.Size(62, 17)
        Me.rbtConfig10min.TabIndex = 2
        Me.rbtConfig10min.Text = "10 min"
        Me.rbtConfig10min.UseVisualStyleBackColor = True
        '
        'lblConfigCal
        '
        Me.lblConfigCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblConfigCal.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfigCal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblConfigCal.Location = New System.Drawing.Point(9, 5)
        Me.lblConfigCal.Name = "lblConfigCal"
        Me.lblConfigCal.Size = New System.Drawing.Size(525, 18)
        Me.lblConfigCal.TabIndex = 0
        Me.lblConfigCal.Text = "CONFIGURACION CALENDARIO"
        Me.lblConfigCal.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupHorarioLaboral
        '
        Me.GroupHorarioLaboral.BackColor = System.Drawing.Color.Transparent
        Me.GroupHorarioLaboral.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupHorarioLaboral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupHorarioLaboral.Controls.Add(Me.lblInicio)
        Me.GroupHorarioLaboral.Controls.Add(Me.lblFin)
        Me.GroupHorarioLaboral.Controls.Add(Me.EndTime)
        Me.GroupHorarioLaboral.Controls.Add(Me.StartTime)
        Me.GroupHorarioLaboral.Location = New System.Drawing.Point(9, 25)
        Me.GroupHorarioLaboral.Name = "GroupHorarioLaboral"
        Me.GroupHorarioLaboral.Size = New System.Drawing.Size(150, 73)
        '
        '
        '
        Me.GroupHorarioLaboral.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupHorarioLaboral.Style.BackColorGradientAngle = 90
        Me.GroupHorarioLaboral.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupHorarioLaboral.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupHorarioLaboral.Style.BorderBottomWidth = 1
        Me.GroupHorarioLaboral.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupHorarioLaboral.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupHorarioLaboral.Style.BorderLeftWidth = 1
        Me.GroupHorarioLaboral.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupHorarioLaboral.Style.BorderRightWidth = 1
        Me.GroupHorarioLaboral.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupHorarioLaboral.Style.BorderTopWidth = 1
        Me.GroupHorarioLaboral.Style.CornerDiameter = 4
        Me.GroupHorarioLaboral.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupHorarioLaboral.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupHorarioLaboral.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupHorarioLaboral.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupHorarioLaboral.TabIndex = 2
        Me.GroupHorarioLaboral.Text = "HORARIO LABORAL"
        '
        'lblInicio
        '
        Me.lblInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblInicio.Location = New System.Drawing.Point(3, 2)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(32, 23)
        Me.lblInicio.TabIndex = 0
        Me.lblInicio.Text = "Inicio"
        '
        'lblFin
        '
        Me.lblFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFin.Location = New System.Drawing.Point(3, 25)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(32, 23)
        Me.lblFin.TabIndex = 2
        Me.lblFin.Text = "Fin"
        '
        'EndTime
        '
        Me.EndTime.CustomFormat = "hh:mm tt"
        Me.EndTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.EndTime.DropDownCalendar.Location = New System.Drawing.Point(0, 0)
        Me.EndTime.DropDownCalendar.Name = ""
        Me.EndTime.DropDownCalendar.Size = New System.Drawing.Size(164, 167)
        Me.EndTime.DropDownCalendar.TabIndex = 0
        Me.EndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard
        Me.EndTime.Location = New System.Drawing.Point(41, 28)
        Me.EndTime.Name = "EndTime"
        Me.EndTime.ShowDropDown = False
        Me.EndTime.ShowUpDown = True
        Me.EndTime.Size = New System.Drawing.Size(96, 20)
        Me.EndTime.TabIndex = 3
        Me.EndTime.Value = New Date(2002, 1, 18, 0, 0, 0, 0)
        '
        'StartTime
        '
        Me.StartTime.CustomFormat = "hh:mm tt"
        Me.StartTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.StartTime.DropDownCalendar.Location = New System.Drawing.Point(15, 35)
        Me.StartTime.DropDownCalendar.Name = ""
        Me.StartTime.DropDownCalendar.Size = New System.Drawing.Size(164, 167)
        Me.StartTime.DropDownCalendar.TabIndex = 0
        Me.StartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard
        Me.StartTime.Location = New System.Drawing.Point(41, 5)
        Me.StartTime.Name = "StartTime"
        Me.StartTime.ShowDropDown = False
        Me.StartTime.ShowUpDown = True
        Me.StartTime.Size = New System.Drawing.Size(96, 20)
        Me.StartTime.TabIndex = 1
        Me.StartTime.Value = New Date(2002, 1, 18, 0, 0, 0, 0)
        '
        'btnCalAdicionar
        '
        Me.btnCalAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalAdicionar.Image = CType(resources.GetObject("btnCalAdicionar.Image"), System.Drawing.Image)
        Me.btnCalAdicionar.Location = New System.Drawing.Point(441, 25)
        Me.btnCalAdicionar.Name = "btnCalAdicionar"
        Me.btnCalAdicionar.Size = New System.Drawing.Size(91, 24)
        Me.btnCalAdicionar.SubItemsExpandWidth = 10
        Me.btnCalAdicionar.TabIndex = 5
        Me.btnCalAdicionar.Text = "ADICIONAR"
        '
        'btnEstudiosPac
        '
        Me.btnEstudiosPac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEstudiosPac.Image = CType(resources.GetObject("btnEstudiosPac.Image"), System.Drawing.Image)
        Me.btnEstudiosPac.Location = New System.Drawing.Point(478, 89)
        Me.btnEstudiosPac.Name = "btnEstudiosPac"
        Me.btnEstudiosPac.Size = New System.Drawing.Size(27, 28)
        Me.SuperTooltip.SetSuperTooltip(Me.btnEstudiosPac, New DevComponents.DotNetBar.SuperTooltipInfo("Estudios", "Odontoappointmen", "Presenta la Galería de Fotografías y Radiografías del Paciente.", CType(resources.GetObject("btnEstudiosPac.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnEstudiosPac.TabIndex = 28
        '
        'ExpandableCalendario
        '
        Me.ExpandableCalendario.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ExpandableCalendario.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableCalendario.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableCalendario.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableCalendario.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpandableCalendario.ExpandableControl = Me.PanelConfigCal
        Me.ExpandableCalendario.Expanded = False
        Me.ExpandableCalendario.ExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableCalendario.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableCalendario.ExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableCalendario.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableCalendario.GripDarkColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableCalendario.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableCalendario.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableCalendario.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableCalendario.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableCalendario.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableCalendario.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableCalendario.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableCalendario.HotExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableCalendario.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableCalendario.HotExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableCalendario.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableCalendario.HotGripDarkColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableCalendario.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableCalendario.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableCalendario.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableCalendario.Location = New System.Drawing.Point(552, 0)
        Me.ExpandableCalendario.Name = "ExpandableCalendario"
        Me.ExpandableCalendario.Size = New System.Drawing.Size(10, 120)
        Me.ExpandableCalendario.TabIndex = 19
        Me.ExpandableCalendario.TabStop = False
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.Color.LightBlue
        Me.lblCodigo.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCodigo.ForeColor = System.Drawing.Color.Navy
        Me.lblCodigo.Location = New System.Drawing.Point(149, 97)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(56, 20)
        Me.lblCodigo.TabIndex = 15
        Me.lblCodigo.Text = "Codigo"
        Me.lblCodigo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblNHclinica
        '
        Me.lblNHclinica.BackColor = System.Drawing.Color.LightBlue
        Me.lblNHclinica.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNHclinica.ForeColor = System.Drawing.Color.Navy
        Me.lblNHclinica.Location = New System.Drawing.Point(263, 97)
        Me.lblNHclinica.Name = "lblNHclinica"
        Me.lblNHclinica.Size = New System.Drawing.Size(47, 20)
        Me.lblNHclinica.TabIndex = 17
        Me.lblNHclinica.Text = "No. HC"
        Me.lblNHclinica.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtnhistoria_ficha
        '
        Me.txtnhistoria_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtnhistoria_ficha.Border.Class = "TextBoxBorder"
        Me.txtnhistoria_ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnhistoria_ficha.Location = New System.Drawing.Point(313, 97)
        Me.txtnhistoria_ficha.Name = "txtnhistoria_ficha"
        Me.txtnhistoria_ficha.ReadOnly = True
        Me.txtnhistoria_ficha.Size = New System.Drawing.Size(85, 20)
        Me.txtnhistoria_ficha.TabIndex = 18
        '
        'txtId_ficha
        '
        Me.txtId_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtId_ficha.Border.Class = "TextBoxBorder"
        Me.txtId_ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId_ficha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtId_ficha.Location = New System.Drawing.Point(209, 97)
        Me.txtId_ficha.Name = "txtId_ficha"
        Me.txtId_ficha.ReadOnly = True
        Me.txtId_ficha.Size = New System.Drawing.Size(51, 20)
        Me.txtId_ficha.TabIndex = 16
        '
        'txtEmail_ficha
        '
        Me.txtEmail_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEmail_ficha.Border.Class = "TextBoxBorder"
        Me.txtEmail_ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail_ficha.Location = New System.Drawing.Point(209, 73)
        Me.txtEmail_ficha.Name = "txtEmail_ficha"
        Me.txtEmail_ficha.ReadOnly = True
        Me.txtEmail_ficha.Size = New System.Drawing.Size(189, 21)
        Me.txtEmail_ficha.TabIndex = 12
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.LightBlue
        Me.lblEmail.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblEmail.ForeColor = System.Drawing.Color.Navy
        Me.lblEmail.Location = New System.Drawing.Point(149, 73)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(56, 21)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "E-Mail"
        Me.lblEmail.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblCelular
        '
        Me.lblCelular.BackColor = System.Drawing.Color.LightBlue
        Me.lblCelular.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCelular.ForeColor = System.Drawing.Color.Navy
        Me.lblCelular.Location = New System.Drawing.Point(149, 50)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(56, 20)
        Me.lblCelular.TabIndex = 7
        Me.lblCelular.Text = "Celular"
        Me.lblCelular.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelular_ficha
        '
        Me.txtCelular_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCelular_ficha.Border.Class = "TextBoxBorder"
        Me.txtCelular_ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular_ficha.Location = New System.Drawing.Point(209, 50)
        Me.txtCelular_ficha.Name = "txtCelular_ficha"
        Me.txtCelular_ficha.ReadOnly = True
        Me.txtCelular_ficha.Size = New System.Drawing.Size(71, 20)
        Me.txtCelular_ficha.TabIndex = 8
        '
        'lblTelCasa
        '
        Me.lblTelCasa.BackColor = System.Drawing.Color.LightBlue
        Me.lblTelCasa.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTelCasa.ForeColor = System.Drawing.Color.Navy
        Me.lblTelCasa.Location = New System.Drawing.Point(281, 50)
        Me.lblTelCasa.Name = "lblTelCasa"
        Me.lblTelCasa.Size = New System.Drawing.Size(51, 20)
        Me.lblTelCasa.TabIndex = 9
        Me.lblTelCasa.Text = "Tel. Casa"
        Me.lblTelCasa.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelCasa_ficha
        '
        Me.txtTelCasa_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTelCasa_ficha.Border.Class = "TextBoxBorder"
        Me.txtTelCasa_ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelCasa_ficha.Location = New System.Drawing.Point(335, 50)
        Me.txtTelCasa_ficha.Name = "txtTelCasa_ficha"
        Me.txtTelCasa_ficha.ReadOnly = True
        Me.txtTelCasa_ficha.Size = New System.Drawing.Size(63, 20)
        Me.txtTelCasa_ficha.TabIndex = 10
        '
        'txtReferido_ficha
        '
        Me.txtReferido_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtReferido_ficha.Border.Class = "TextBoxBorder"
        Me.txtReferido_ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferido_ficha.Location = New System.Drawing.Point(209, 28)
        Me.txtReferido_ficha.Name = "txtReferido_ficha"
        Me.txtReferido_ficha.ReadOnly = True
        Me.txtReferido_ficha.Size = New System.Drawing.Size(189, 19)
        Me.txtReferido_ficha.TabIndex = 5
        '
        'lblRemitido
        '
        Me.lblRemitido.BackColor = System.Drawing.Color.LightBlue
        Me.lblRemitido.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRemitido.ForeColor = System.Drawing.Color.Navy
        Me.lblRemitido.Location = New System.Drawing.Point(149, 28)
        Me.lblRemitido.Name = "lblRemitido"
        Me.lblRemitido.Size = New System.Drawing.Size(56, 19)
        Me.lblRemitido.TabIndex = 4
        Me.lblRemitido.Text = "Remitido"
        Me.lblRemitido.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtNombre_ficha
        '
        Me.txtNombre_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombre_ficha.Border.Class = "TextBoxBorder"
        Me.txtNombre_ficha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre_ficha.Location = New System.Drawing.Point(209, 6)
        Me.txtNombre_ficha.Name = "txtNombre_ficha"
        Me.txtNombre_ficha.ReadOnly = True
        Me.txtNombre_ficha.Size = New System.Drawing.Size(189, 20)
        Me.txtNombre_ficha.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.LightBlue
        Me.lblNombre.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Navy
        Me.lblNombre.Location = New System.Drawing.Point(149, 6)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'pbxFoto_ficha
        '
        Me.pbxFoto_ficha.BackColor = System.Drawing.Color.Transparent
        Me.pbxFoto_ficha.Image = CType(resources.GetObject("pbxFoto_ficha.Image"), System.Drawing.Image)
        Me.pbxFoto_ficha.Location = New System.Drawing.Point(8, 5)
        Me.pbxFoto_ficha.Name = "pbxFoto_ficha"
        Me.pbxFoto_ficha.Size = New System.Drawing.Size(110, 110)
        Me.pbxFoto_ficha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxFoto_ficha.TabIndex = 115
        Me.pbxFoto_ficha.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(121, 62)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(27, 29)
        Me.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.SuperTooltip.SetSuperTooltip(Me.btnBuscar, New DevComponents.DotNetBar.SuperTooltipInfo("Buscar Pacientes", "Odontoapp", "Modulo especializado en la busqueda por criterio de los pacientes registrados en " & _
                    "la Base de Datos.", CType(resources.GetObject("btnBuscar.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Tag = "1"
        '
        'btnEditarFicha
        '
        Me.btnEditarFicha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditarFicha.Enabled = False
        Me.btnEditarFicha.Image = CType(resources.GetObject("btnEditarFicha.Image"), System.Drawing.Image)
        Me.btnEditarFicha.Location = New System.Drawing.Point(121, 34)
        Me.btnEditarFicha.Name = "btnEditarFicha"
        Me.btnEditarFicha.Size = New System.Drawing.Size(27, 29)
        Me.btnEditarFicha.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.SuperTooltip.SetSuperTooltip(Me.btnEditarFicha, New DevComponents.DotNetBar.SuperTooltipInfo("Editar Registro", "Odontoapp", "Edita la informacion del Registro seleccionado, presentando el modulo para tal fi" & _
                    "n.", CType(resources.GetObject("btnEditarFicha.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnEditarFicha.TabIndex = 6
        Me.btnEditarFicha.Tag = "1"
        '
        'btnEnvioEmail
        '
        Me.btnEnvioEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEnvioEmail.Enabled = False
        Me.btnEnvioEmail.Image = CType(resources.GetObject("btnEnvioEmail.Image"), System.Drawing.Image)
        Me.btnEnvioEmail.Location = New System.Drawing.Point(121, 6)
        Me.btnEnvioEmail.Name = "btnEnvioEmail"
        Me.btnEnvioEmail.Size = New System.Drawing.Size(27, 29)
        Me.btnEnvioEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.SuperTooltip.SetSuperTooltip(Me.btnEnvioEmail, New DevComponents.DotNetBar.SuperTooltipInfo("Envio de Email", "Odontoapp", "Enviar un Correo Electronico al Paciente Seleccionado", CType(resources.GetObject("btnEnvioEmail.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnEnvioEmail.TabIndex = 1
        Me.btnEnvioEmail.Tag = "1"
        '
        'gpProximaCita
        '
        Me.gpProximaCita.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpProximaCita.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpProximaCita.Controls.Add(Me.txtproced_ficha)
        Me.gpProximaCita.Controls.Add(Me.txtHFIN_ficha)
        Me.gpProximaCita.Controls.Add(Me.txtHINI_ficha)
        Me.gpProximaCita.Controls.Add(Me.txtProxCita_ficha)
        Me.gpProximaCita.Location = New System.Drawing.Point(400, 8)
        Me.gpProximaCita.Name = "gpProximaCita"
        Me.gpProximaCita.Size = New System.Drawing.Size(137, 77)
        '
        '
        '
        Me.gpProximaCita.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpProximaCita.Style.BackColorGradientAngle = 90
        Me.gpProximaCita.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpProximaCita.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpProximaCita.Style.BorderBottomWidth = 1
        Me.gpProximaCita.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpProximaCita.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpProximaCita.Style.BorderLeftWidth = 1
        Me.gpProximaCita.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpProximaCita.Style.BorderRightWidth = 1
        Me.gpProximaCita.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpProximaCita.Style.BorderTopWidth = 1
        Me.gpProximaCita.Style.CornerDiameter = 4
        Me.gpProximaCita.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpProximaCita.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpProximaCita.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpProximaCita.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.SuperTooltip.SetSuperTooltip(Me.gpProximaCita, New DevComponents.DotNetBar.SuperTooltipInfo("PROXIMA CITA", "Odontoapp", "", CType(resources.GetObject("gpProximaCita.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.gpProximaCita.TabIndex = 13
        '
        'txtproced_ficha
        '
        Me.txtproced_ficha.BackColor = System.Drawing.Color.White
        Me.txtproced_ficha.Location = New System.Drawing.Point(7, 47)
        Me.txtproced_ficha.Name = "txtproced_ficha"
        Me.txtproced_ficha.ReadOnly = True
        Me.txtproced_ficha.Size = New System.Drawing.Size(116, 20)
        Me.SuperTooltip.SetSuperTooltip(Me.txtproced_ficha, New DevComponents.DotNetBar.SuperTooltipInfo("PROXIMA CITA", "Odontoapp", "Desplegla la Proxima Cita del Paciente", CType(resources.GetObject("txtproced_ficha.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.txtproced_ficha.TabIndex = 3
        Me.txtproced_ficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtproced_ficha.WatermarkText = "PROCEDIMIENTO"
        '
        'txtHFIN_ficha
        '
        Me.txtHFIN_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHFIN_ficha.Border.Class = "TextBoxBorder"
        Me.txtHFIN_ficha.Location = New System.Drawing.Point(65, 25)
        Me.txtHFIN_ficha.Name = "txtHFIN_ficha"
        Me.txtHFIN_ficha.ReadOnly = True
        Me.txtHFIN_ficha.Size = New System.Drawing.Size(58, 20)
        Me.SuperTooltip.SetSuperTooltip(Me.txtHFIN_ficha, New DevComponents.DotNetBar.SuperTooltipInfo("PROXIMA CITA", "Odontoapp", "Desplegla la Proxima Cita del Paciente", CType(resources.GetObject("txtHFIN_ficha.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.txtHFIN_ficha.TabIndex = 2
        Me.txtHFIN_ficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHFIN_ficha.WatermarkText = "H. FIN"
        '
        'txtHINI_ficha
        '
        Me.txtHINI_ficha.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtHINI_ficha.Border.Class = "TextBoxBorder"
        Me.txtHINI_ficha.Location = New System.Drawing.Point(7, 25)
        Me.txtHINI_ficha.Name = "txtHINI_ficha"
        Me.txtHINI_ficha.ReadOnly = True
        Me.txtHINI_ficha.Size = New System.Drawing.Size(52, 20)
        Me.SuperTooltip.SetSuperTooltip(Me.txtHINI_ficha, New DevComponents.DotNetBar.SuperTooltipInfo("PROXIMA CITA", "Odontoapp", "Desplegla la Proxima Cita del Paciente", CType(resources.GetObject("txtHINI_ficha.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.txtHINI_ficha.TabIndex = 1
        Me.txtHINI_ficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHINI_ficha.WatermarkText = "H. INI"
        '
        'txtProxCita_ficha
        '
        Me.txtProxCita_ficha.BackColor = System.Drawing.Color.White
        Me.txtProxCita_ficha.Location = New System.Drawing.Point(7, 3)
        Me.txtProxCita_ficha.Name = "txtProxCita_ficha"
        Me.txtProxCita_ficha.ReadOnly = True
        Me.txtProxCita_ficha.Size = New System.Drawing.Size(116, 20)
        Me.SuperTooltip.SetSuperTooltip(Me.txtProxCita_ficha, New DevComponents.DotNetBar.SuperTooltipInfo("PROXIMA CITA", "Odontoapp", "Desplegla la Proxima Cita del Paciente", CType(resources.GetObject("txtProxCita_ficha.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.txtProxCita_ficha.TabIndex = 0
        Me.txtProxCita_ficha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtProxCita_ficha.WatermarkText = "DIA/MES/AÑO"
        '
        'btnProcedimiento
        '
        Me.btnProcedimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProcedimiento.Image = CType(resources.GetObject("btnProcedimiento.Image"), System.Drawing.Image)
        Me.btnProcedimiento.Location = New System.Drawing.Point(121, 90)
        Me.btnProcedimiento.Name = "btnProcedimiento"
        Me.btnProcedimiento.Size = New System.Drawing.Size(27, 29)
        Me.btnProcedimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.SuperTooltip.SetSuperTooltip(Me.btnProcedimiento, New DevComponents.DotNetBar.SuperTooltipInfo("Procedimiento Diario", "Odontoapp", "Modulo para el registro de los procedimientos que se le realizan a un paciente en" & _
                    " el proceso de su tratamiento.", CType(resources.GetObject("btnProcedimiento.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnProcedimiento.TabIndex = 116
        Me.btnProcedimiento.Tag = "1"
        '
        'btnHistoriaClinica
        '
        Me.btnHistoriaClinica.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnHistoriaClinica.Image = CType(resources.GetObject("btnHistoriaClinica.Image"), System.Drawing.Image)
        Me.btnHistoriaClinica.Location = New System.Drawing.Point(504, 89)
        Me.btnHistoriaClinica.Name = "btnHistoriaClinica"
        Me.btnHistoriaClinica.Size = New System.Drawing.Size(34, 28)
        Me.btnHistoriaClinica.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnHCOrtodoncia, Me.btnHCOrtodoncia2, Me.btnHCOrtodoncia3, Me.btnHCGeneral})
        Me.SuperTooltip.SetSuperTooltip(Me.btnHistoriaClinica, New DevComponents.DotNetBar.SuperTooltipInfo("Historia Clinica", "Odontoapp", "Modulo de la Historia Clinica por Especialidad del Paciente.", CType(resources.GetObject("btnHistoriaClinica.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnHistoriaClinica.TabIndex = 29
        '
        'btnHCOrtodoncia
        '
        Me.btnHCOrtodoncia.GlobalItem = False
        Me.btnHCOrtodoncia.Image = CType(resources.GetObject("btnHCOrtodoncia.Image"), System.Drawing.Image)
        Me.btnHCOrtodoncia.ImagePaddingHorizontal = 8
        Me.btnHCOrtodoncia.Name = "btnHCOrtodoncia"
        Me.btnHCOrtodoncia.Text = "H.C. Ortodoncia"
        '
        'btnHCOrtodoncia2
        '
        Me.btnHCOrtodoncia2.GlobalItem = False
        Me.btnHCOrtodoncia2.Image = CType(resources.GetObject("btnHCOrtodoncia2.Image"), System.Drawing.Image)
        Me.btnHCOrtodoncia2.ImagePaddingHorizontal = 8
        Me.btnHCOrtodoncia2.Name = "btnHCOrtodoncia2"
        Me.btnHCOrtodoncia2.Text = "H.C. Ortodoncia No. 2"
        '
        'btnHCOrtodoncia3
        '
        Me.btnHCOrtodoncia3.Image = CType(resources.GetObject("btnHCOrtodoncia3.Image"), System.Drawing.Image)
        Me.btnHCOrtodoncia3.ImagePaddingHorizontal = 8
        Me.btnHCOrtodoncia3.Name = "btnHCOrtodoncia3"
        Me.btnHCOrtodoncia3.Text = "H.C. Ortodoncia No. 3"
        '
        'btnHCGeneral
        '
        Me.btnHCGeneral.GlobalItem = False
        Me.btnHCGeneral.Image = CType(resources.GetObject("btnHCGeneral.Image"), System.Drawing.Image)
        Me.btnHCGeneral.ImagePaddingHorizontal = 8
        Me.btnHCGeneral.Name = "btnHCGeneral"
        Me.btnHCGeneral.Text = "H.C. General"
        '
        'txtIdcita
        '
        '
        '
        '
        Me.txtIdcita.Border.Class = "TextBoxBorder"
        Me.txtIdcita.Location = New System.Drawing.Point(606, 284)
        Me.txtIdcita.Name = "txtIdcita"
        Me.txtIdcita.Size = New System.Drawing.Size(100, 20)
        Me.txtIdcita.TabIndex = 4
        Me.txtIdcita.Visible = False
        '
        'txtIdPacienteTagScheduler
        '
        Me.txtIdPacienteTagScheduler.BackColor = System.Drawing.Color.Yellow
        '
        '
        '
        Me.txtIdPacienteTagScheduler.Border.Class = "TextBoxBorder"
        Me.txtIdPacienteTagScheduler.Location = New System.Drawing.Point(606, 310)
        Me.txtIdPacienteTagScheduler.Name = "txtIdPacienteTagScheduler"
        Me.txtIdPacienteTagScheduler.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPacienteTagScheduler.TabIndex = 6
        Me.txtIdPacienteTagScheduler.Visible = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.Control = Nothing
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'PanelPrincipalIzquierdo
        '
        Me.PanelPrincipalIzquierdo.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelPrincipalIzquierdo.Controls.Add(Me.MenuPrincipal)
        Me.PanelPrincipalIzquierdo.Controls.Add(Me.PanelTopeCitas)
        Me.PanelPrincipalIzquierdo.Controls.Add(Me.ExpandableNumcitas)
        Me.PanelPrincipalIzquierdo.Controls.Add(Me.ExpandableNPacientes)
        Me.PanelPrincipalIzquierdo.Controls.Add(Me.PanelCitasHoy)
        Me.PanelPrincipalIzquierdo.Controls.Add(Me.PanelMenuPrincipalIzq)
        Me.PanelPrincipalIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelPrincipalIzquierdo.Location = New System.Drawing.Point(0, 130)
        Me.PanelPrincipalIzquierdo.Name = "PanelPrincipalIzquierdo"
        Me.PanelPrincipalIzquierdo.Size = New System.Drawing.Size(171, 633)
        '
        '
        '
        Me.PanelPrincipalIzquierdo.Style.Class = "RibbonClientPanel"
        Me.PanelPrincipalIzquierdo.TabIndex = 1
        Me.PanelPrincipalIzquierdo.Text = "RibbonClientPanel1"
        '
        'PanelTopeCitas
        '
        Me.PanelTopeCitas.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelTopeCitas.Controls.Add(Me.LabelX20)
        Me.PanelTopeCitas.Controls.Add(Me.txtTopeCita)
        Me.PanelTopeCitas.Controls.Add(Me.btnCalModificar2)
        Me.PanelTopeCitas.Controls.Add(Me.btnCalAdicionar2)
        Me.PanelTopeCitas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelTopeCitas.Location = New System.Drawing.Point(0, 379)
        Me.PanelTopeCitas.Name = "PanelTopeCitas"
        Me.PanelTopeCitas.Size = New System.Drawing.Size(194, 116)
        Me.PanelTopeCitas.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelTopeCitas.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelTopeCitas.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelTopeCitas.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelTopeCitas.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelTopeCitas.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelTopeCitas.Style.GradientAngle = 90
        Me.PanelTopeCitas.TabIndex = 2
        Me.PanelTopeCitas.Visible = False
        '
        'ExpandableNumcitas
        '
        Me.ExpandableNumcitas.BackColor2 = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNumcitas.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNumcitas.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableNumcitas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExpandableNumcitas.ExpandableControl = Me.PanelTopeCitas
        Me.ExpandableNumcitas.Expanded = False
        Me.ExpandableNumcitas.ExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNumcitas.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNumcitas.ExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableNumcitas.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableNumcitas.GripDarkColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableNumcitas.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableNumcitas.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableNumcitas.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableNumcitas.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableNumcitas.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableNumcitas.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableNumcitas.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableNumcitas.HotExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNumcitas.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNumcitas.HotExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableNumcitas.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableNumcitas.HotGripDarkColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNumcitas.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNumcitas.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableNumcitas.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableNumcitas.Location = New System.Drawing.Point(0, 605)
        Me.ExpandableNumcitas.Name = "ExpandableNumcitas"
        Me.ExpandableNumcitas.Size = New System.Drawing.Size(171, 14)
        Me.ExpandableNumcitas.TabIndex = 4
        Me.ExpandableNumcitas.TabStop = False
        '
        'ExpandableNPacientes
        '
        Me.ExpandableNPacientes.BackColor2 = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNPacientes.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNPacientes.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableNPacientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ExpandableNPacientes.ExpandableControl = Me.PanelCitasHoy
        Me.ExpandableNPacientes.Expanded = False
        Me.ExpandableNPacientes.ExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNPacientes.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNPacientes.ExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableNPacientes.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableNPacientes.GripDarkColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableNPacientes.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableNPacientes.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableNPacientes.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableNPacientes.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableNPacientes.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableNPacientes.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableNPacientes.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableNPacientes.HotExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNPacientes.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNPacientes.HotExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableNPacientes.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableNPacientes.HotGripDarkColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableNPacientes.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableNPacientes.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableNPacientes.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableNPacientes.Location = New System.Drawing.Point(0, 619)
        Me.ExpandableNPacientes.Name = "ExpandableNPacientes"
        Me.ExpandableNPacientes.Size = New System.Drawing.Size(171, 14)
        Me.ExpandableNPacientes.TabIndex = 5
        Me.ExpandableNPacientes.TabStop = False
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.XtraTabbedMdiManager1.Appearance.BackColor2 = System.Drawing.Color.CornflowerBlue
        Me.XtraTabbedMdiManager1.Appearance.BorderColor = System.Drawing.Color.Navy
        Me.XtraTabbedMdiManager1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.XtraTabbedMdiManager1.Appearance.Options.UseBackColor = True
        Me.XtraTabbedMdiManager1.Appearance.Options.UseBorderColor = True
        Me.XtraTabbedMdiManager1.AppearancePage.Header.BackColor2 = System.Drawing.Color.Lime
        Me.XtraTabbedMdiManager1.AppearancePage.Header.BorderColor = System.Drawing.Color.Red
        Me.XtraTabbedMdiManager1.AppearancePage.Header.Options.UseBorderColor = True
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.Options.UseBackColor = True
        Me.XtraTabbedMdiManager1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.XtraTabbedMdiManager1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabbedMdiManager1.Images = Me.ImageScheduler
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.Windows
        '
        'DefaultLookAndFeel
        '
        Me.DefaultLookAndFeel.LookAndFeel.SkinName = "Blue"
        '
        'ExpandableAgenda
        '
        Me.ExpandableAgenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ExpandableAgenda.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableAgenda.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableAgenda.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.None
        Me.ExpandableAgenda.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExpandableAgenda.ExpandableControl = Me.PanelPrincipalDerecho
        Me.ExpandableAgenda.ExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableAgenda.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableAgenda.ExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableAgenda.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableAgenda.GripDarkColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableAgenda.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableAgenda.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableAgenda.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableAgenda.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableAgenda.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableAgenda.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableAgenda.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableAgenda.HotExpandFillColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableAgenda.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableAgenda.HotExpandLineColor = System.Drawing.SystemColors.ControlText
        Me.ExpandableAgenda.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableAgenda.HotGripDarkColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExpandableAgenda.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableAgenda.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ExpandableAgenda.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableAgenda.Location = New System.Drawing.Point(723, 250)
        Me.ExpandableAgenda.Name = "ExpandableAgenda"
        Me.ExpandableAgenda.Size = New System.Drawing.Size(10, 513)
        Me.ExpandableAgenda.TabIndex = 21
        Me.ExpandableAgenda.TabStop = False
        Me.ExpandableAgenda.Visible = False
        '
        'txtIdunidad
        '
        Me.txtIdunidad.BackColor = System.Drawing.Color.Khaki
        '
        '
        '
        Me.txtIdunidad.Border.Class = "TextBoxBorder"
        Me.txtIdunidad.Location = New System.Drawing.Point(606, 336)
        Me.txtIdunidad.Name = "txtIdunidad"
        Me.txtIdunidad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdunidad.TabIndex = 22
        Me.txtIdunidad.Visible = False
        '
        'btnSkype
        '
        Me.btnSkype.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSkype.Image = CType(resources.GetObject("btnSkype.Image"), System.Drawing.Image)
        Me.btnSkype.Location = New System.Drawing.Point(220, 2)
        Me.btnSkype.Name = "btnSkype"
        Me.btnSkype.Size = New System.Drawing.Size(23, 21)
        Me.SuperTooltip.SetSuperTooltip(Me.btnSkype, New DevComponents.DotNetBar.SuperTooltipInfo("Desplegar Appointment", "Odontoapointment", "Despliega en modo multisilla la agenda.", CType(resources.GetObject("btnSkype.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnSkype.TabIndex = 2
        '
        'mdiOrthoSoft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1036, 763)
        Me.Controls.Add(Me.txtIdunidad)
        Me.Controls.Add(Me.ExpandableAgenda)
        Me.Controls.Add(Me.PanelFicha)
        Me.Controls.Add(Me.PanelPrincipalDerecho)
        Me.Controls.Add(Me.PanelPrincipalIzquierdo)
        Me.Controls.Add(Me.clcEndTime)
        Me.Controls.Add(Me.clcStartTime)
        Me.Controls.Add(Me.txtIdPacienteTagScheduler)
        Me.Controls.Add(Me.txtIdcita)
        Me.Controls.Add(Me.PanelMenuPrincipalSup)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "mdiOrthoSoft"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenuPrincipalSup.ResumeLayout(False)
        Me.PanelMenuPrincipalSup.PerformLayout()
        Me.PanelFunciones.ResumeLayout(False)
        Me.PnlActivoDoctor.ResumeLayout(False)
        Me.PnlActivoPaciente.ResumeLayout(False)
        Me.RibbonPanel1.ResumeLayout(False)
        Me.PanelConv.ResumeLayout(False)
        Me.GroupItemsCitas.ResumeLayout(False)
        Me.GroupItemsCitas.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupItemsPacientes.ResumeLayout(False)
        Me.GroupItemsPacientes.PerformLayout()
        Me.PanelUsuarios.ResumeLayout(False)
        Me.PnlActivoUsuario.ResumeLayout(False)
        Me.PanelBackups.ResumeLayout(False)
        Me.PanelPrincipalDerecho.ResumeLayout(False)
        CType(Me.ScheduleOrhosoft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelOpcScheduler.ResumeLayout(False)
        CType(Me.FichasOpcionesCitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FichasOpcionesCitas.ResumeLayout(False)
        Me.FichasOpcionesCitas.PerformLayout()
        Me.TabPanelRegistro.ResumeLayout(False)
        Me.TabPanelNotaCita.ResumeLayout(False)
        Me.GroupNotaCita.ResumeLayout(False)
        Me.TabPanelCitas.ResumeLayout(False)
        Me.GroupAsistio.ResumeLayout(False)
        Me.GroupAsistio.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCitaCancelada.ResumeLayout(False)
        Me.GroupCitaCancelada.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPanelDoctor.ResumeLayout(False)
        Me.GroupDoctor.ResumeLayout(False)
        Me.TabPanelAgenda.ResumeLayout(False)
        Me.GroupAgenda.ResumeLayout(False)
        Me.GroupAgenda.PerformLayout()
        Me.TabPanelConsulta.ResumeLayout(False)
        Me.GroupTipoConsulta.ResumeLayout(False)
        CType(Me.MenuPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenuPrincipalIzq.ResumeLayout(False)
        CType(Me.CalOrthosoft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCitasHoy.ResumeLayout(False)
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.PanelFicha.ResumeLayout(False)
        Me.PanelConfigCal.ResumeLayout(False)
        Me.GroupTBloqueoDia.ResumeLayout(False)
        Me.GroupTBloqueoDia.PerformLayout()
        Me.GroupRangoAgenda.ResumeLayout(False)
        Me.GroupRangoAgenda.PerformLayout()
        Me.GroupHorarioLaboral.ResumeLayout(False)
        CType(Me.pbxFoto_ficha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpProximaCita.ResumeLayout(False)
        Me.PanelPrincipalIzquierdo.ResumeLayout(False)
        Me.PanelTopeCitas.ResumeLayout(False)
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenuPrincipalSup As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents PanelFunciones As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents PanelContenedorSuperior As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents TabFunciones As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents PanelPrincipalDerecho As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents ExpandableScheduler As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents PanelOpcScheduler As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents ScheduleOrhosoft As Janus.Windows.Schedule.Schedule
    Friend WithEvents FichasOpcionesCitas As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabPanelCitas As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabCitas As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabPanelConsulta As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabConsulta As DevComponents.DotNetBar.TabItem
    Friend WithEvents MenuPrincipal As DevComponents.DotNetBar.ExplorerBar
    Friend WithEvents lblTituloPacientes As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExplorerPacientes As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuNuevoPaciente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuBuscarPaciente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExplorerDoctores As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuNuevoDoctor As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuBuscarDoctor As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExplorerInformes As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents PanelMenuPrincipalIzq As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents TabPanelAgenda As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabAgenda As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupTipoConsulta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupAgenda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbt15min As System.Windows.Forms.RadioButton
    Friend WithEvents rbt30min As System.Windows.Forms.RadioButton
    Friend WithEvents rbt10min As System.Windows.Forms.RadioButton
    Friend WithEvents rbt5min As System.Windows.Forms.RadioButton
    Friend WithEvents TabPanelRegistro As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabRegistro As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabPanelDoctor As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupDoctor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TabDoctor As DevComponents.DotNetBar.TabItem
    Friend WithEvents cmbDoctores As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents BarInformesCitas As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnf1InfPorPaciente As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf2Infpordia As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents BarAutomaticos As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents BarBloqueos As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents BarInformesPacientes As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnf7InfCumpleSemana As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf8InfCumpleMes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf11EnvioTel As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf12EnvioEmail As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf9BloqueoDia As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf10BloqueoPac As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents lblTotalPacientes As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExplorerAdministracion As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuAutenticacion As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuInfAuditoria As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuImporBD As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExplorerEntidades As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuNuevaEntidad As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuBuscarEntidad As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf6InfCumpleHoy As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnOpCalendar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PnlActivoDoctor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblActivoDoctor As DevComponents.DotNetBar.LabelX
    Friend WithEvents PnlActivoPaciente As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblActivoPaciente As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExplorerUsuarios As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuNuevoUsuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuBuscarUsuario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents CalOrthosoft As AxMonthLib.AxctMonth
    Friend WithEvents btnAvanzarMes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRetrocedermes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents clcEndTime As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents clcStartTime As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents PanelFicha As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblCodigo As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNHclinica As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtnhistoria_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtId_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEmail_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblEmail As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCelular As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelular_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTelCasa As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelCasa_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtReferido_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblRemitido As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNombre_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents pbxFoto_ficha As System.Windows.Forms.PictureBox
    Friend WithEvents ExpandableCalendario As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents PanelConfigCal As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtIdCalendario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblConfigCal As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCalAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupHorarioLaboral As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblInicio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblFin As DevComponents.DotNetBar.LabelX
    Friend WithEvents EndTime As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents StartTime As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents GroupRangoAgenda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtConfig5min As System.Windows.Forms.RadioButton
    Friend WithEvents rbtConfig30min As System.Windows.Forms.RadioButton
    Friend WithEvents rbtConfig15min As System.Windows.Forms.RadioButton
    Friend WithEvents rbtConfig10min As System.Windows.Forms.RadioButton
    Friend WithEvents GroupTBloqueoDia As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtModificado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNoLaborable As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFestivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents rbtModificado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtNolaborable As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFestivo As System.Windows.Forms.RadioButton
    Friend WithEvents txtDiaSeleccionado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblDiaSeleccionado As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDiaLibre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblDiaLibre As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCalEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCalModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblFechaHoy As DevComponents.DotNetBar.LabelItem
    Friend WithEvents txtfechahoy As DevComponents.DotNetBar.LabelItem
    Friend WithEvents btnDocSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIdcita As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdPacienteTagScheduler As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblPacientes As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCitaImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCitaModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCitaEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCitaAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupAsistio As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtAsistioNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAsistioSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupCitaCancelada As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtCanceladaNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCanceladaSi As System.Windows.Forms.RadioButton
    Friend WithEvents ImageScheduler As System.Windows.Forms.ImageList
    Friend WithEvents PanelBackups As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents TabSeguridad As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents BarBackups As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRestaurarBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents OpenFileBackup As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileBackup As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents mnuConfigIni As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf5InfGeneral As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf3InfFuturas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnf4InfSinAsistir As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelUsuarios As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents TabUsuario As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents btnUsuSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PnlActivoUsuario As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblActivoUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents ExplorerCitas As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuReminderCitas As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents TabPanelNotaCita As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabNotaCita As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupNotaCita As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtnotacita As System.Windows.Forms.RichTextBox
    Friend WithEvents btnInfAsignadoDia As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents cmbTipoConsulta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblTipoConsulta As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnInfPacBloq As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEditarFicha As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents PanelConv As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents TabConv As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents GroupItemsPacientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupItemsCitas As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCalModificar2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCalAdicionar2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEnvioEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpProximaCita As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtProxCita_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtHFIN_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtHINI_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtproced_ficha As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ExplorerContab As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuRcaja As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuProcedimientoDiario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonTabItem1 As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents btnSincronizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelCitasHoy As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtTopeCita As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents PanelPrincipalIzquierdo As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents PanelTopeCitas As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ExpandableNumcitas As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents ExpandableNPacientes As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents mnuPresupuesto As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuGereradorInformes As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnAppointment As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mnuNivelAcceso As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuDocumentos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents DefaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents btnSMS As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ExplorerVarios As DevComponents.DotNetBar.ExplorerBarGroupItem
    Friend WithEvents mnuIlustraciones As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuEgreso As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents SuperTooltip As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents btnPacOdontograma As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEstadoCuenta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mnuItems As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnEnvioSMSPersonalizado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mnuEstadoCuenta As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuGastos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSoporteRemoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnActualizacion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents mnuProveedores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuBuscarProveedores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnInicio As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents mnuMovimientoDiario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents mnuBloqDesCalendario As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents RibbonBar1 As DevComponents.DotNetBar.RibbonBar
    Friend WithEvents btnCalculadora As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnProcedimiento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnHistoriaClinica As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEstudiosPac As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnHCOrtodoncia As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHCGeneral As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnCirugia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnHCOrtodoncia2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnHCOrtodoncia3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnBuscarHuella As DevComponents.DotNetBar.ButtonX
    Friend WithEvents VerificationControl As DPFP.Gui.Verification.VerificationControl
    Friend WithEvents ExpandableAgenda As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents txtIdunidad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents mnuHorarioDoctores As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnCitaModificar2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSkype As DevComponents.DotNetBar.ButtonX

End Class
