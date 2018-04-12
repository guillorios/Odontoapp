<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNivelesAccesos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNivelesAccesos))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tab Funciones")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tab Backup")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tab Usuarios")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tab Sincronizacion")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fichas Funciones", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Pacientes")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Doctores")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Usuarios")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Entidades")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Informes")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Administracion")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Citas")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Contabilidad")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Varios")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menu Principal", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Botones Superiores")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Control Scheduler")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Botones Citas")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Scheduler", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ficha Paciente")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pacientes")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Doctores")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Usuarios")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entidades")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Historias Clinicas")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Procedimientos Diarios")
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.TabAccesos = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabFunciones_InfoAsignadoDia = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_Calculadora = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_EnviarMenSMS = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_EnviarMenCall = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_BlqPaciente = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_EnviarMenEmail = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_PacientesBq = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_BlqDia = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_CitasFuturas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_CumpleSem = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_CitasDia = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_CumpleHoy = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_CitasSinAsistir = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_TodasCitas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_CumpleMes = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFunciones_Infogral = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabFunciones = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel23 = New DevComponents.DotNetBar.TabControlPanel
        Me.chk_Tabproc_NProc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_Tabproc_BProc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_Tabproc_MProc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_Tabproc_AProc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX48 = New DevComponents.DotNetBar.LabelX
        Me.LabelX47 = New DevComponents.DotNetBar.LabelX
        Me.TabProcDiario = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel8 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX42 = New DevComponents.DotNetBar.LabelX
        Me.LabelX43 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabEnt_NEnt = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabEnt_BEnt = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabEnt_MEnt = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabEnt_AEnt = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabEntidades = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel7 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX40 = New DevComponents.DotNetBar.LabelX
        Me.LabelX41 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabUsu_NUsu = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabUsu_BUsu = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabUsu_MUsu = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabUsu_AUsu = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabUsuario = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX38 = New DevComponents.DotNetBar.LabelX
        Me.LabelX39 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabDoc_NDoc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabDoc_BDoc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabDoc_MDoc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabDoc_ADoc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabDoctores = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX36 = New DevComponents.DotNetBar.LabelX
        Me.LabelX37 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabPac_NPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabPac_BPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabPac_MPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabPac_APac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabPacientes = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel22 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX46 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabHC_Nuevag = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabHC_Desblg = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabHC_Modificarg = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabHC_Adicionarg = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX44 = New DevComponents.DotNetBar.LabelX
        Me.LabelX45 = New DevComponents.DotNetBar.LabelX
        Me.TabHC = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel9 = New DevComponents.DotNetBar.TabControlPanel
        Me.chk_TabFicha_HC = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFicha_Estudios = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFicha_EstadoCuenta = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFicha_Odontograma = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFicha_SMS = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFicha_ProcDiario = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX34 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabFicha_SplitAgenda = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX35 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabFicha_EmailPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFicha_BPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabFicha_EPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabFicha = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel21 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX
        Me.LabelX33 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabCitas_RangoCita = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_CambioDoc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_CitaAsis = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_CitaCanc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_NotaCita = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_TConsul = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_ICita = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_ECita = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_MCita = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabCitas_ACita = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabCitas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel20 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabSch_SplittCitas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabSch_Control = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabScheduler = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel19 = New DevComponents.DotNetBar.TabControlPanel
        Me.chk_TabSchSup_BuscaHuellas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabSchSup_Cambio = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabSchedulerSup = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel10 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuVarios_Ilustraciones = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuVarios = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuVarios = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel18 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuConta_MDiario = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuConta_Gastos = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuConta_ECuenta = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuConta_Vprocedimiento = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuConta_CEgreso = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuConta_Presupuesto = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuConta_RCaja = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuConta_Conta = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuContab = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel17 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuCitas_BloquearCitas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuCitas_Reminder = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuCitas_Citas = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuCitas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel16 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuAdm_Acceso = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuAdm_Config = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuAdm_Import = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuAdm_Audito = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuAdm_Aut = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuAdm_Adm = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuAdmon = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel15 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuInf_Documentos = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuInf_ProcD = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuInf_InfV = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuInf_Inf = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuInformes = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel14 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuEnt_BProv = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuEnt_NProv = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuEnt_BEnt = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuEnt_NEnt = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuEnt_Ent = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuEntidades = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel13 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuUsu_BUsu = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuUsu_NUsu = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuUsu_Usu = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuUsuarios = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel12 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuDoc_BDoc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuDoc_NDoc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuDoc_Doc = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuDoctores = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel11 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabMnuPac_BPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuPac_NPac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabMnuPac_Pac = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabMenuPacientes = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabSincro_Cirugia = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabSincro_Actualizacion = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabSincro_SoporteRemoto = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabSincro_Sincro = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabSincro = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabCambioUsu_Cambio = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabCambioUsuarios = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.chk_TabBackup_Restaurar = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.chk_TabBackup_Copia = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.TabBackup = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.GroupPerfilesAcceso = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtIdperfil = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbPerfilAcceso = New System.Windows.Forms.ComboBox
        Me.txtnom_perf = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.lblVTotal_cuota = New DevComponents.DotNetBar.LabelX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.TreeAccesos = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.lblNivelesAcceso = New DevComponents.DotNetBar.LabelX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.ErrorProviderPerfil = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.TabAccesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAccesos.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.TabControlPanel23.SuspendLayout()
        Me.TabControlPanel8.SuspendLayout()
        Me.TabControlPanel7.SuspendLayout()
        Me.TabControlPanel6.SuspendLayout()
        Me.TabControlPanel5.SuspendLayout()
        Me.TabControlPanel22.SuspendLayout()
        Me.TabControlPanel9.SuspendLayout()
        Me.TabControlPanel21.SuspendLayout()
        Me.TabControlPanel20.SuspendLayout()
        Me.TabControlPanel19.SuspendLayout()
        Me.TabControlPanel10.SuspendLayout()
        Me.TabControlPanel18.SuspendLayout()
        Me.TabControlPanel17.SuspendLayout()
        Me.TabControlPanel16.SuspendLayout()
        Me.TabControlPanel15.SuspendLayout()
        Me.TabControlPanel14.SuspendLayout()
        Me.TabControlPanel13.SuspendLayout()
        Me.TabControlPanel12.SuspendLayout()
        Me.TabControlPanel11.SuspendLayout()
        Me.TabControlPanel4.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPerfilesAcceso.SuspendLayout()
        CType(Me.ErrorProviderPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.TabAccesos)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPerfilesAcceso)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.TreeAccesos)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.lblNivelesAcceso)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(532, 486)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 0
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(217, 434)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 39)
        Me.btnNuevo.TabIndex = 29
        Me.btnNuevo.Text = "NUEVO"
        '
        'TabAccesos
        '
        Me.TabAccesos.CanReorderTabs = True
        Me.TabAccesos.Controls.Add(Me.TabControlPanel23)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel22)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel8)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel1)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel7)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel6)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel5)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel9)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel21)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel20)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel19)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel10)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel18)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel17)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel16)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel15)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel14)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel13)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel12)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel11)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel4)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel3)
        Me.TabAccesos.Controls.Add(Me.TabControlPanel2)
        Me.TabAccesos.Location = New System.Drawing.Point(192, 130)
        Me.TabAccesos.Name = "TabAccesos"
        Me.TabAccesos.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabAccesos.SelectedTabIndex = 0
        Me.TabAccesos.Size = New System.Drawing.Size(323, 298)
        Me.TabAccesos.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabAccesos.TabIndex = 131
        Me.TabAccesos.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabAccesos.Tabs.Add(Me.TabFunciones)
        Me.TabAccesos.Tabs.Add(Me.TabBackup)
        Me.TabAccesos.Tabs.Add(Me.TabCambioUsuarios)
        Me.TabAccesos.Tabs.Add(Me.TabSincro)
        Me.TabAccesos.Tabs.Add(Me.TabMenuPacientes)
        Me.TabAccesos.Tabs.Add(Me.TabMenuDoctores)
        Me.TabAccesos.Tabs.Add(Me.TabMenuUsuarios)
        Me.TabAccesos.Tabs.Add(Me.TabMenuEntidades)
        Me.TabAccesos.Tabs.Add(Me.TabMenuInformes)
        Me.TabAccesos.Tabs.Add(Me.TabMenuAdmon)
        Me.TabAccesos.Tabs.Add(Me.TabMenuCitas)
        Me.TabAccesos.Tabs.Add(Me.TabMenuContab)
        Me.TabAccesos.Tabs.Add(Me.TabMenuVarios)
        Me.TabAccesos.Tabs.Add(Me.TabSchedulerSup)
        Me.TabAccesos.Tabs.Add(Me.TabScheduler)
        Me.TabAccesos.Tabs.Add(Me.TabCitas)
        Me.TabAccesos.Tabs.Add(Me.TabFicha)
        Me.TabAccesos.Tabs.Add(Me.TabPacientes)
        Me.TabAccesos.Tabs.Add(Me.TabDoctores)
        Me.TabAccesos.Tabs.Add(Me.TabUsuario)
        Me.TabAccesos.Tabs.Add(Me.TabEntidades)
        Me.TabAccesos.Tabs.Add(Me.TabHC)
        Me.TabAccesos.Tabs.Add(Me.TabProcDiario)
        Me.TabAccesos.TabsVisible = False
        Me.TabAccesos.Text = "TabAccesos"
        Me.TabAccesos.ThemeAware = True
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.LabelX6)
        Me.TabControlPanel1.Controls.Add(Me.LabelX2)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_InfoAsignadoDia)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_Calculadora)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_EnviarMenSMS)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_EnviarMenCall)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_BlqPaciente)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_EnviarMenEmail)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_PacientesBq)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_BlqDia)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_CitasFuturas)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_CumpleSem)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_CitasDia)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_CumpleHoy)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_CitasSinAsistir)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_TodasCitas)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_CumpleMes)
        Me.TabControlPanel1.Controls.Add(Me.chk_TabFunciones_Infogral)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabFunciones
        '
        'LabelX6
        '
        Me.LabelX6.Location = New System.Drawing.Point(7, 8)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(41, 16)
        Me.LabelX6.TabIndex = 88
        Me.LabelX6.Text = "Index 0"
        Me.LabelX6.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX2.Location = New System.Drawing.Point(6, 7)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(314, 18)
        Me.LabelX2.TabIndex = 87
        Me.LabelX2.Text = "BOTONES DE FUNCIONES"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabFunciones_InfoAsignadoDia
        '
        Me.chk_TabFunciones_InfoAsignadoDia.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_InfoAsignadoDia.Location = New System.Drawing.Point(7, 110)
        Me.chk_TabFunciones_InfoAsignadoDia.Name = "chk_TabFunciones_InfoAsignadoDia"
        Me.chk_TabFunciones_InfoAsignadoDia.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_InfoAsignadoDia.TabIndex = 12
        Me.chk_TabFunciones_InfoAsignadoDia.Text = "Informe Asignado Dia"
        '
        'chk_TabFunciones_Calculadora
        '
        Me.chk_TabFunciones_Calculadora.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_Calculadora.Location = New System.Drawing.Point(166, 91)
        Me.chk_TabFunciones_Calculadora.Name = "chk_TabFunciones_Calculadora"
        Me.chk_TabFunciones_Calculadora.Size = New System.Drawing.Size(133, 23)
        Me.chk_TabFunciones_Calculadora.TabIndex = 11
        Me.chk_TabFunciones_Calculadora.Text = "Calculadora"
        '
        'chk_TabFunciones_EnviarMenSMS
        '
        Me.chk_TabFunciones_EnviarMenSMS.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_EnviarMenSMS.Location = New System.Drawing.Point(166, 72)
        Me.chk_TabFunciones_EnviarMenSMS.Name = "chk_TabFunciones_EnviarMenSMS"
        Me.chk_TabFunciones_EnviarMenSMS.Size = New System.Drawing.Size(136, 23)
        Me.chk_TabFunciones_EnviarMenSMS.TabIndex = 10
        Me.chk_TabFunciones_EnviarMenSMS.Text = "Enviar Mensaje SMS"
        '
        'chk_TabFunciones_EnviarMenCall
        '
        Me.chk_TabFunciones_EnviarMenCall.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_EnviarMenCall.Location = New System.Drawing.Point(166, 32)
        Me.chk_TabFunciones_EnviarMenCall.Name = "chk_TabFunciones_EnviarMenCall"
        Me.chk_TabFunciones_EnviarMenCall.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_EnviarMenCall.TabIndex = 9
        Me.chk_TabFunciones_EnviarMenCall.Text = "Enviar Mensaje Call Center"
        '
        'chk_TabFunciones_BlqPaciente
        '
        Me.chk_TabFunciones_BlqPaciente.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_BlqPaciente.Location = New System.Drawing.Point(7, 248)
        Me.chk_TabFunciones_BlqPaciente.Name = "chk_TabFunciones_BlqPaciente"
        Me.chk_TabFunciones_BlqPaciente.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_BlqPaciente.TabIndex = 7
        Me.chk_TabFunciones_BlqPaciente.Text = "Bloquear Paciente"
        '
        'chk_TabFunciones_EnviarMenEmail
        '
        Me.chk_TabFunciones_EnviarMenEmail.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_EnviarMenEmail.Location = New System.Drawing.Point(166, 53)
        Me.chk_TabFunciones_EnviarMenEmail.Name = "chk_TabFunciones_EnviarMenEmail"
        Me.chk_TabFunciones_EnviarMenEmail.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_EnviarMenEmail.TabIndex = 6
        Me.chk_TabFunciones_EnviarMenEmail.Text = "Enviar Mensaje Email"
        '
        'chk_TabFunciones_PacientesBq
        '
        Me.chk_TabFunciones_PacientesBq.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_PacientesBq.Location = New System.Drawing.Point(7, 210)
        Me.chk_TabFunciones_PacientesBq.Name = "chk_TabFunciones_PacientesBq"
        Me.chk_TabFunciones_PacientesBq.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_PacientesBq.TabIndex = 5
        Me.chk_TabFunciones_PacientesBq.Text = "Pacientes Bloqueados"
        '
        'chk_TabFunciones_BlqDia
        '
        Me.chk_TabFunciones_BlqDia.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_BlqDia.Location = New System.Drawing.Point(7, 229)
        Me.chk_TabFunciones_BlqDia.Name = "chk_TabFunciones_BlqDia"
        Me.chk_TabFunciones_BlqDia.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_BlqDia.TabIndex = 4
        Me.chk_TabFunciones_BlqDia.Text = "Bloquear Dia"
        '
        'chk_TabFunciones_CitasFuturas
        '
        Me.chk_TabFunciones_CitasFuturas.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_CitasFuturas.Location = New System.Drawing.Point(7, 70)
        Me.chk_TabFunciones_CitasFuturas.Name = "chk_TabFunciones_CitasFuturas"
        Me.chk_TabFunciones_CitasFuturas.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_CitasFuturas.TabIndex = 3
        Me.chk_TabFunciones_CitasFuturas.Text = "Citas Futuras por Paciente"
        '
        'chk_TabFunciones_CumpleSem
        '
        Me.chk_TabFunciones_CumpleSem.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_CumpleSem.Location = New System.Drawing.Point(7, 171)
        Me.chk_TabFunciones_CumpleSem.Name = "chk_TabFunciones_CumpleSem"
        Me.chk_TabFunciones_CumpleSem.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_CumpleSem.TabIndex = 3
        Me.chk_TabFunciones_CumpleSem.Text = "Cumpleaños Semana"
        '
        'chk_TabFunciones_CitasDia
        '
        Me.chk_TabFunciones_CitasDia.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_CitasDia.Location = New System.Drawing.Point(7, 51)
        Me.chk_TabFunciones_CitasDia.Name = "chk_TabFunciones_CitasDia"
        Me.chk_TabFunciones_CitasDia.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_CitasDia.TabIndex = 2
        Me.chk_TabFunciones_CitasDia.Text = "Citas por Dia"
        '
        'chk_TabFunciones_CumpleHoy
        '
        Me.chk_TabFunciones_CumpleHoy.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_CumpleHoy.Location = New System.Drawing.Point(7, 152)
        Me.chk_TabFunciones_CumpleHoy.Name = "chk_TabFunciones_CumpleHoy"
        Me.chk_TabFunciones_CumpleHoy.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_CumpleHoy.TabIndex = 2
        Me.chk_TabFunciones_CumpleHoy.Text = "Cumpleaños Hoy"
        '
        'chk_TabFunciones_CitasSinAsistir
        '
        Me.chk_TabFunciones_CitasSinAsistir.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_CitasSinAsistir.Location = New System.Drawing.Point(7, 90)
        Me.chk_TabFunciones_CitasSinAsistir.Name = "chk_TabFunciones_CitasSinAsistir"
        Me.chk_TabFunciones_CitasSinAsistir.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_CitasSinAsistir.TabIndex = 1
        Me.chk_TabFunciones_CitasSinAsistir.Text = "Citas Sin Asistir Dia"
        '
        'chk_TabFunciones_TodasCitas
        '
        Me.chk_TabFunciones_TodasCitas.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_TodasCitas.Location = New System.Drawing.Point(7, 32)
        Me.chk_TabFunciones_TodasCitas.Name = "chk_TabFunciones_TodasCitas"
        Me.chk_TabFunciones_TodasCitas.Size = New System.Drawing.Size(172, 23)
        Me.chk_TabFunciones_TodasCitas.TabIndex = 0
        Me.chk_TabFunciones_TodasCitas.Text = "Todas las Citas Paciente"
        '
        'chk_TabFunciones_CumpleMes
        '
        Me.chk_TabFunciones_CumpleMes.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_CumpleMes.Location = New System.Drawing.Point(7, 190)
        Me.chk_TabFunciones_CumpleMes.Name = "chk_TabFunciones_CumpleMes"
        Me.chk_TabFunciones_CumpleMes.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_CumpleMes.TabIndex = 1
        Me.chk_TabFunciones_CumpleMes.Text = "Cumpleaños Mes"
        '
        'chk_TabFunciones_Infogral
        '
        Me.chk_TabFunciones_Infogral.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFunciones_Infogral.Location = New System.Drawing.Point(7, 132)
        Me.chk_TabFunciones_Infogral.Name = "chk_TabFunciones_Infogral"
        Me.chk_TabFunciones_Infogral.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFunciones_Infogral.TabIndex = 0
        Me.chk_TabFunciones_Infogral.Text = "Informe General Pacientes"
        '
        'TabFunciones
        '
        Me.TabFunciones.AttachedControl = Me.TabControlPanel1
        Me.TabFunciones.Name = "TabFunciones"
        Me.TabFunciones.Text = "TabFunciones"
        '
        'TabControlPanel23
        '
        Me.TabControlPanel23.Controls.Add(Me.chk_Tabproc_NProc)
        Me.TabControlPanel23.Controls.Add(Me.chk_Tabproc_BProc)
        Me.TabControlPanel23.Controls.Add(Me.chk_Tabproc_MProc)
        Me.TabControlPanel23.Controls.Add(Me.chk_Tabproc_AProc)
        Me.TabControlPanel23.Controls.Add(Me.LabelX48)
        Me.TabControlPanel23.Controls.Add(Me.LabelX47)
        Me.TabControlPanel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel23.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel23.Name = "TabControlPanel23"
        Me.TabControlPanel23.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel23.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel23.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel23.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel23.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel23.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel23.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel23.Style.GradientAngle = 90
        Me.TabControlPanel23.TabIndex = 24
        Me.TabControlPanel23.TabItem = Me.TabProcDiario
        '
        'chk_Tabproc_NProc
        '
        Me.chk_Tabproc_NProc.BackColor = System.Drawing.Color.Transparent
        Me.chk_Tabproc_NProc.Location = New System.Drawing.Point(25, 113)
        Me.chk_Tabproc_NProc.Name = "chk_Tabproc_NProc"
        Me.chk_Tabproc_NProc.Size = New System.Drawing.Size(154, 23)
        Me.chk_Tabproc_NProc.TabIndex = 129
        Me.chk_Tabproc_NProc.Text = "Nuevo Procedimiento"
        '
        'chk_Tabproc_BProc
        '
        Me.chk_Tabproc_BProc.BackColor = System.Drawing.Color.Transparent
        Me.chk_Tabproc_BProc.Location = New System.Drawing.Point(25, 90)
        Me.chk_Tabproc_BProc.Name = "chk_Tabproc_BProc"
        Me.chk_Tabproc_BProc.Size = New System.Drawing.Size(154, 23)
        Me.chk_Tabproc_BProc.TabIndex = 128
        Me.chk_Tabproc_BProc.Text = "Borrar Procedimiento"
        '
        'chk_Tabproc_MProc
        '
        Me.chk_Tabproc_MProc.BackColor = System.Drawing.Color.Transparent
        Me.chk_Tabproc_MProc.Location = New System.Drawing.Point(25, 67)
        Me.chk_Tabproc_MProc.Name = "chk_Tabproc_MProc"
        Me.chk_Tabproc_MProc.Size = New System.Drawing.Size(154, 23)
        Me.chk_Tabproc_MProc.TabIndex = 127
        Me.chk_Tabproc_MProc.Text = "Modificar Procedimiento"
        '
        'chk_Tabproc_AProc
        '
        Me.chk_Tabproc_AProc.BackColor = System.Drawing.Color.Transparent
        Me.chk_Tabproc_AProc.Location = New System.Drawing.Point(25, 44)
        Me.chk_Tabproc_AProc.Name = "chk_Tabproc_AProc"
        Me.chk_Tabproc_AProc.Size = New System.Drawing.Size(154, 23)
        Me.chk_Tabproc_AProc.TabIndex = 126
        Me.chk_Tabproc_AProc.Text = "Adicionar Procedimiento"
        '
        'LabelX48
        '
        Me.LabelX48.Location = New System.Drawing.Point(6, 8)
        Me.LabelX48.Name = "LabelX48"
        Me.LabelX48.Size = New System.Drawing.Size(45, 16)
        Me.LabelX48.TabIndex = 125
        Me.LabelX48.Text = "Index 22"
        Me.LabelX48.Visible = False
        '
        'LabelX47
        '
        Me.LabelX47.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX47.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX47.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX47.Location = New System.Drawing.Point(5, 7)
        Me.LabelX47.Name = "LabelX47"
        Me.LabelX47.Size = New System.Drawing.Size(314, 18)
        Me.LabelX47.TabIndex = 124
        Me.LabelX47.Text = "MODULO PROCEDIMIENTOS DIARIOS"
        Me.LabelX47.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabProcDiario
        '
        Me.TabProcDiario.AttachedControl = Me.TabControlPanel23
        Me.TabProcDiario.Name = "TabProcDiario"
        Me.TabProcDiario.Text = "TabProcDiario"
        '
        'TabControlPanel8
        '
        Me.TabControlPanel8.Controls.Add(Me.LabelX42)
        Me.TabControlPanel8.Controls.Add(Me.LabelX43)
        Me.TabControlPanel8.Controls.Add(Me.chk_TabEnt_NEnt)
        Me.TabControlPanel8.Controls.Add(Me.chk_TabEnt_BEnt)
        Me.TabControlPanel8.Controls.Add(Me.chk_TabEnt_MEnt)
        Me.TabControlPanel8.Controls.Add(Me.chk_TabEnt_AEnt)
        Me.TabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel8.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel8.Name = "TabControlPanel8"
        Me.TabControlPanel8.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel8.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel8.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel8.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel8.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel8.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel8.Style.GradientAngle = 90
        Me.TabControlPanel8.TabIndex = 8
        Me.TabControlPanel8.TabItem = Me.TabEntidades
        '
        'LabelX42
        '
        Me.LabelX42.Location = New System.Drawing.Point(6, 8)
        Me.LabelX42.Name = "LabelX42"
        Me.LabelX42.Size = New System.Drawing.Size(45, 16)
        Me.LabelX42.TabIndex = 122
        Me.LabelX42.Text = "Index 20"
        Me.LabelX42.Visible = False
        '
        'LabelX43
        '
        Me.LabelX43.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX43.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX43.Location = New System.Drawing.Point(5, 7)
        Me.LabelX43.Name = "LabelX43"
        Me.LabelX43.Size = New System.Drawing.Size(314, 18)
        Me.LabelX43.TabIndex = 121
        Me.LabelX43.Text = "MODULO ENTIDADES"
        Me.LabelX43.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabEnt_NEnt
        '
        Me.chk_TabEnt_NEnt.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabEnt_NEnt.Location = New System.Drawing.Point(25, 113)
        Me.chk_TabEnt_NEnt.Name = "chk_TabEnt_NEnt"
        Me.chk_TabEnt_NEnt.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabEnt_NEnt.TabIndex = 21
        Me.chk_TabEnt_NEnt.Text = "Nueva Entidad"
        '
        'chk_TabEnt_BEnt
        '
        Me.chk_TabEnt_BEnt.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabEnt_BEnt.Location = New System.Drawing.Point(25, 90)
        Me.chk_TabEnt_BEnt.Name = "chk_TabEnt_BEnt"
        Me.chk_TabEnt_BEnt.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabEnt_BEnt.TabIndex = 20
        Me.chk_TabEnt_BEnt.Text = "Borrar Entidades"
        '
        'chk_TabEnt_MEnt
        '
        Me.chk_TabEnt_MEnt.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabEnt_MEnt.Location = New System.Drawing.Point(25, 67)
        Me.chk_TabEnt_MEnt.Name = "chk_TabEnt_MEnt"
        Me.chk_TabEnt_MEnt.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabEnt_MEnt.TabIndex = 19
        Me.chk_TabEnt_MEnt.Text = "Modificar Entidades"
        '
        'chk_TabEnt_AEnt
        '
        Me.chk_TabEnt_AEnt.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabEnt_AEnt.Location = New System.Drawing.Point(25, 44)
        Me.chk_TabEnt_AEnt.Name = "chk_TabEnt_AEnt"
        Me.chk_TabEnt_AEnt.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabEnt_AEnt.TabIndex = 18
        Me.chk_TabEnt_AEnt.Text = "Adicionar Entidades"
        '
        'TabEntidades
        '
        Me.TabEntidades.AttachedControl = Me.TabControlPanel8
        Me.TabEntidades.Name = "TabEntidades"
        Me.TabEntidades.Text = "TabEntidades"
        '
        'TabControlPanel7
        '
        Me.TabControlPanel7.Controls.Add(Me.LabelX40)
        Me.TabControlPanel7.Controls.Add(Me.LabelX41)
        Me.TabControlPanel7.Controls.Add(Me.chk_TabUsu_NUsu)
        Me.TabControlPanel7.Controls.Add(Me.chk_TabUsu_BUsu)
        Me.TabControlPanel7.Controls.Add(Me.chk_TabUsu_MUsu)
        Me.TabControlPanel7.Controls.Add(Me.chk_TabUsu_AUsu)
        Me.TabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel7.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel7.Name = "TabControlPanel7"
        Me.TabControlPanel7.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel7.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel7.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel7.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel7.Style.GradientAngle = 90
        Me.TabControlPanel7.TabIndex = 7
        Me.TabControlPanel7.TabItem = Me.TabUsuario
        '
        'LabelX40
        '
        Me.LabelX40.Location = New System.Drawing.Point(6, 8)
        Me.LabelX40.Name = "LabelX40"
        Me.LabelX40.Size = New System.Drawing.Size(45, 16)
        Me.LabelX40.TabIndex = 120
        Me.LabelX40.Text = "Index 19"
        Me.LabelX40.Visible = False
        '
        'LabelX41
        '
        Me.LabelX41.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX41.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX41.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX41.Location = New System.Drawing.Point(5, 7)
        Me.LabelX41.Name = "LabelX41"
        Me.LabelX41.Size = New System.Drawing.Size(314, 18)
        Me.LabelX41.TabIndex = 119
        Me.LabelX41.Text = "MODULO USUARIOS"
        Me.LabelX41.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabUsu_NUsu
        '
        Me.chk_TabUsu_NUsu.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabUsu_NUsu.Location = New System.Drawing.Point(25, 113)
        Me.chk_TabUsu_NUsu.Name = "chk_TabUsu_NUsu"
        Me.chk_TabUsu_NUsu.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabUsu_NUsu.TabIndex = 17
        Me.chk_TabUsu_NUsu.Text = "Nuevo Usuario"
        '
        'chk_TabUsu_BUsu
        '
        Me.chk_TabUsu_BUsu.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabUsu_BUsu.Location = New System.Drawing.Point(25, 90)
        Me.chk_TabUsu_BUsu.Name = "chk_TabUsu_BUsu"
        Me.chk_TabUsu_BUsu.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabUsu_BUsu.TabIndex = 16
        Me.chk_TabUsu_BUsu.Text = "Borrar Usuarios"
        '
        'chk_TabUsu_MUsu
        '
        Me.chk_TabUsu_MUsu.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabUsu_MUsu.Location = New System.Drawing.Point(25, 67)
        Me.chk_TabUsu_MUsu.Name = "chk_TabUsu_MUsu"
        Me.chk_TabUsu_MUsu.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabUsu_MUsu.TabIndex = 15
        Me.chk_TabUsu_MUsu.Text = "Modificar Usuarios"
        '
        'chk_TabUsu_AUsu
        '
        Me.chk_TabUsu_AUsu.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabUsu_AUsu.Location = New System.Drawing.Point(25, 44)
        Me.chk_TabUsu_AUsu.Name = "chk_TabUsu_AUsu"
        Me.chk_TabUsu_AUsu.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabUsu_AUsu.TabIndex = 14
        Me.chk_TabUsu_AUsu.Text = "Adicionar Usuarios"
        '
        'TabUsuario
        '
        Me.TabUsuario.AttachedControl = Me.TabControlPanel7
        Me.TabUsuario.Name = "TabUsuario"
        Me.TabUsuario.Text = "TabUsuarios"
        '
        'TabControlPanel6
        '
        Me.TabControlPanel6.Controls.Add(Me.LabelX38)
        Me.TabControlPanel6.Controls.Add(Me.LabelX39)
        Me.TabControlPanel6.Controls.Add(Me.chk_TabDoc_NDoc)
        Me.TabControlPanel6.Controls.Add(Me.chk_TabDoc_BDoc)
        Me.TabControlPanel6.Controls.Add(Me.chk_TabDoc_MDoc)
        Me.TabControlPanel6.Controls.Add(Me.chk_TabDoc_ADoc)
        Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel6.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel6.Name = "TabControlPanel6"
        Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel6.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel6.Style.GradientAngle = 90
        Me.TabControlPanel6.TabIndex = 6
        Me.TabControlPanel6.TabItem = Me.TabDoctores
        '
        'LabelX38
        '
        Me.LabelX38.Location = New System.Drawing.Point(6, 8)
        Me.LabelX38.Name = "LabelX38"
        Me.LabelX38.Size = New System.Drawing.Size(45, 16)
        Me.LabelX38.TabIndex = 118
        Me.LabelX38.Text = "Index 18"
        Me.LabelX38.Visible = False
        '
        'LabelX39
        '
        Me.LabelX39.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX39.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX39.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX39.Location = New System.Drawing.Point(5, 7)
        Me.LabelX39.Name = "LabelX39"
        Me.LabelX39.Size = New System.Drawing.Size(314, 18)
        Me.LabelX39.TabIndex = 117
        Me.LabelX39.Text = "MODULO DOCTORES"
        Me.LabelX39.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabDoc_NDoc
        '
        Me.chk_TabDoc_NDoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabDoc_NDoc.Location = New System.Drawing.Point(25, 113)
        Me.chk_TabDoc_NDoc.Name = "chk_TabDoc_NDoc"
        Me.chk_TabDoc_NDoc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabDoc_NDoc.TabIndex = 13
        Me.chk_TabDoc_NDoc.Text = "Nuevo Doctor"
        '
        'chk_TabDoc_BDoc
        '
        Me.chk_TabDoc_BDoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabDoc_BDoc.Location = New System.Drawing.Point(25, 90)
        Me.chk_TabDoc_BDoc.Name = "chk_TabDoc_BDoc"
        Me.chk_TabDoc_BDoc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabDoc_BDoc.TabIndex = 12
        Me.chk_TabDoc_BDoc.Text = "Borrar Doctores"
        '
        'chk_TabDoc_MDoc
        '
        Me.chk_TabDoc_MDoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabDoc_MDoc.Location = New System.Drawing.Point(25, 67)
        Me.chk_TabDoc_MDoc.Name = "chk_TabDoc_MDoc"
        Me.chk_TabDoc_MDoc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabDoc_MDoc.TabIndex = 11
        Me.chk_TabDoc_MDoc.Text = "Modificar Doctores"
        '
        'chk_TabDoc_ADoc
        '
        Me.chk_TabDoc_ADoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabDoc_ADoc.Location = New System.Drawing.Point(25, 44)
        Me.chk_TabDoc_ADoc.Name = "chk_TabDoc_ADoc"
        Me.chk_TabDoc_ADoc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabDoc_ADoc.TabIndex = 10
        Me.chk_TabDoc_ADoc.Text = "Adicionar Doctores"
        '
        'TabDoctores
        '
        Me.TabDoctores.AttachedControl = Me.TabControlPanel6
        Me.TabDoctores.Name = "TabDoctores"
        Me.TabDoctores.Text = "TabDoctores"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.LabelX36)
        Me.TabControlPanel5.Controls.Add(Me.LabelX37)
        Me.TabControlPanel5.Controls.Add(Me.chk_TabPac_NPac)
        Me.TabControlPanel5.Controls.Add(Me.chk_TabPac_BPac)
        Me.TabControlPanel5.Controls.Add(Me.chk_TabPac_MPac)
        Me.TabControlPanel5.Controls.Add(Me.chk_TabPac_APac)
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 5
        Me.TabControlPanel5.TabItem = Me.TabPacientes
        '
        'LabelX36
        '
        Me.LabelX36.Location = New System.Drawing.Point(6, 8)
        Me.LabelX36.Name = "LabelX36"
        Me.LabelX36.Size = New System.Drawing.Size(45, 16)
        Me.LabelX36.TabIndex = 116
        Me.LabelX36.Text = "Index 17"
        Me.LabelX36.Visible = False
        '
        'LabelX37
        '
        Me.LabelX37.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX37.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX37.Location = New System.Drawing.Point(5, 7)
        Me.LabelX37.Name = "LabelX37"
        Me.LabelX37.Size = New System.Drawing.Size(314, 18)
        Me.LabelX37.TabIndex = 115
        Me.LabelX37.Text = "MODULO PACIENTES"
        Me.LabelX37.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabPac_NPac
        '
        Me.chk_TabPac_NPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabPac_NPac.Location = New System.Drawing.Point(25, 113)
        Me.chk_TabPac_NPac.Name = "chk_TabPac_NPac"
        Me.chk_TabPac_NPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabPac_NPac.TabIndex = 9
        Me.chk_TabPac_NPac.Text = "Nuevo Paciente"
        '
        'chk_TabPac_BPac
        '
        Me.chk_TabPac_BPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabPac_BPac.Location = New System.Drawing.Point(25, 90)
        Me.chk_TabPac_BPac.Name = "chk_TabPac_BPac"
        Me.chk_TabPac_BPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabPac_BPac.TabIndex = 8
        Me.chk_TabPac_BPac.Text = "Borrar Pacientes"
        '
        'chk_TabPac_MPac
        '
        Me.chk_TabPac_MPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabPac_MPac.Location = New System.Drawing.Point(25, 67)
        Me.chk_TabPac_MPac.Name = "chk_TabPac_MPac"
        Me.chk_TabPac_MPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabPac_MPac.TabIndex = 7
        Me.chk_TabPac_MPac.Text = "Modificar Pacientes"
        '
        'chk_TabPac_APac
        '
        Me.chk_TabPac_APac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabPac_APac.Location = New System.Drawing.Point(25, 44)
        Me.chk_TabPac_APac.Name = "chk_TabPac_APac"
        Me.chk_TabPac_APac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabPac_APac.TabIndex = 6
        Me.chk_TabPac_APac.Text = "Adicionar Pacientes"
        '
        'TabPacientes
        '
        Me.TabPacientes.AttachedControl = Me.TabControlPanel5
        Me.TabPacientes.Name = "TabPacientes"
        Me.TabPacientes.Text = "TabPacientes"
        '
        'TabControlPanel22
        '
        Me.TabControlPanel22.Controls.Add(Me.LabelX46)
        Me.TabControlPanel22.Controls.Add(Me.chk_TabHC_Nuevag)
        Me.TabControlPanel22.Controls.Add(Me.chk_TabHC_Desblg)
        Me.TabControlPanel22.Controls.Add(Me.chk_TabHC_Modificarg)
        Me.TabControlPanel22.Controls.Add(Me.chk_TabHC_Adicionarg)
        Me.TabControlPanel22.Controls.Add(Me.LabelX44)
        Me.TabControlPanel22.Controls.Add(Me.LabelX45)
        Me.TabControlPanel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel22.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel22.Name = "TabControlPanel22"
        Me.TabControlPanel22.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel22.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel22.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel22.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel22.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel22.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel22.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel22.Style.GradientAngle = 90
        Me.TabControlPanel22.TabIndex = 23
        Me.TabControlPanel22.TabItem = Me.TabHC
        '
        'LabelX46
        '
        Me.LabelX46.Location = New System.Drawing.Point(5, 30)
        Me.LabelX46.Name = "LabelX46"
        Me.LabelX46.Size = New System.Drawing.Size(314, 16)
        Me.LabelX46.TabIndex = 129
        Me.LabelX46.Text = "HISTORIA CLINICA GENERAL"
        Me.LabelX46.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabHC_Nuevag
        '
        Me.chk_TabHC_Nuevag.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabHC_Nuevag.Location = New System.Drawing.Point(250, 47)
        Me.chk_TabHC_Nuevag.Name = "chk_TabHC_Nuevag"
        Me.chk_TabHC_Nuevag.Size = New System.Drawing.Size(69, 23)
        Me.chk_TabHC_Nuevag.TabIndex = 128
        Me.chk_TabHC_Nuevag.Text = "Nueva"
        '
        'chk_TabHC_Desblg
        '
        Me.chk_TabHC_Desblg.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabHC_Desblg.Location = New System.Drawing.Point(159, 47)
        Me.chk_TabHC_Desblg.Name = "chk_TabHC_Desblg"
        Me.chk_TabHC_Desblg.Size = New System.Drawing.Size(94, 23)
        Me.chk_TabHC_Desblg.TabIndex = 127
        Me.chk_TabHC_Desblg.Text = "Desbloquear"
        '
        'chk_TabHC_Modificarg
        '
        Me.chk_TabHC_Modificarg.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabHC_Modificarg.Location = New System.Drawing.Point(83, 47)
        Me.chk_TabHC_Modificarg.Name = "chk_TabHC_Modificarg"
        Me.chk_TabHC_Modificarg.Size = New System.Drawing.Size(78, 23)
        Me.chk_TabHC_Modificarg.TabIndex = 126
        Me.chk_TabHC_Modificarg.Text = "Modificar"
        '
        'chk_TabHC_Adicionarg
        '
        Me.chk_TabHC_Adicionarg.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabHC_Adicionarg.Location = New System.Drawing.Point(7, 47)
        Me.chk_TabHC_Adicionarg.Name = "chk_TabHC_Adicionarg"
        Me.chk_TabHC_Adicionarg.Size = New System.Drawing.Size(70, 23)
        Me.chk_TabHC_Adicionarg.TabIndex = 125
        Me.chk_TabHC_Adicionarg.Text = "Adicionar"
        '
        'LabelX44
        '
        Me.LabelX44.Location = New System.Drawing.Point(6, 8)
        Me.LabelX44.Name = "LabelX44"
        Me.LabelX44.Size = New System.Drawing.Size(45, 16)
        Me.LabelX44.TabIndex = 124
        Me.LabelX44.Text = "Index 21"
        Me.LabelX44.Visible = False
        '
        'LabelX45
        '
        Me.LabelX45.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX45.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX45.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX45.Location = New System.Drawing.Point(5, 7)
        Me.LabelX45.Name = "LabelX45"
        Me.LabelX45.Size = New System.Drawing.Size(314, 18)
        Me.LabelX45.TabIndex = 123
        Me.LabelX45.Text = "MODULO HISTORIAS CLINICAS"
        Me.LabelX45.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabHC
        '
        Me.TabHC.AttachedControl = Me.TabControlPanel22
        Me.TabHC.Name = "TabHC"
        Me.TabHC.Text = "TabHC"
        '
        'TabControlPanel9
        '
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_HC)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_Estudios)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_EstadoCuenta)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_Odontograma)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_SMS)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_ProcDiario)
        Me.TabControlPanel9.Controls.Add(Me.LabelX34)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_SplitAgenda)
        Me.TabControlPanel9.Controls.Add(Me.LabelX35)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_EmailPac)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_BPac)
        Me.TabControlPanel9.Controls.Add(Me.chk_TabFicha_EPac)
        Me.TabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel9.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel9.Name = "TabControlPanel9"
        Me.TabControlPanel9.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel9.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel9.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel9.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel9.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel9.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel9.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel9.Style.GradientAngle = 90
        Me.TabControlPanel9.TabIndex = 9
        Me.TabControlPanel9.TabItem = Me.TabFicha
        '
        'chk_TabFicha_HC
        '
        Me.chk_TabFicha_HC.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_HC.Location = New System.Drawing.Point(25, 248)
        Me.chk_TabFicha_HC.Name = "chk_TabFicha_HC"
        Me.chk_TabFicha_HC.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_HC.TabIndex = 120
        Me.chk_TabFicha_HC.Text = "Historias Clinicas"
        '
        'chk_TabFicha_Estudios
        '
        Me.chk_TabFicha_Estudios.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_Estudios.Location = New System.Drawing.Point(25, 225)
        Me.chk_TabFicha_Estudios.Name = "chk_TabFicha_Estudios"
        Me.chk_TabFicha_Estudios.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_Estudios.TabIndex = 119
        Me.chk_TabFicha_Estudios.Text = "Estudios"
        '
        'chk_TabFicha_EstadoCuenta
        '
        Me.chk_TabFicha_EstadoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_EstadoCuenta.Location = New System.Drawing.Point(25, 201)
        Me.chk_TabFicha_EstadoCuenta.Name = "chk_TabFicha_EstadoCuenta"
        Me.chk_TabFicha_EstadoCuenta.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_EstadoCuenta.TabIndex = 118
        Me.chk_TabFicha_EstadoCuenta.Text = "Estado de Cuenta"
        '
        'chk_TabFicha_Odontograma
        '
        Me.chk_TabFicha_Odontograma.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_Odontograma.Location = New System.Drawing.Point(25, 178)
        Me.chk_TabFicha_Odontograma.Name = "chk_TabFicha_Odontograma"
        Me.chk_TabFicha_Odontograma.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_Odontograma.TabIndex = 117
        Me.chk_TabFicha_Odontograma.Text = "Odontograma"
        '
        'chk_TabFicha_SMS
        '
        Me.chk_TabFicha_SMS.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_SMS.Location = New System.Drawing.Point(25, 154)
        Me.chk_TabFicha_SMS.Name = "chk_TabFicha_SMS"
        Me.chk_TabFicha_SMS.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_SMS.TabIndex = 116
        Me.chk_TabFicha_SMS.Text = "Envio SMS personalizado"
        '
        'chk_TabFicha_ProcDiario
        '
        Me.chk_TabFicha_ProcDiario.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_ProcDiario.Location = New System.Drawing.Point(25, 130)
        Me.chk_TabFicha_ProcDiario.Name = "chk_TabFicha_ProcDiario"
        Me.chk_TabFicha_ProcDiario.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_ProcDiario.TabIndex = 115
        Me.chk_TabFicha_ProcDiario.Text = "Procedimiento Diario"
        '
        'LabelX34
        '
        Me.LabelX34.Location = New System.Drawing.Point(6, 8)
        Me.LabelX34.Name = "LabelX34"
        Me.LabelX34.Size = New System.Drawing.Size(45, 16)
        Me.LabelX34.TabIndex = 114
        Me.LabelX34.Text = "Index 16"
        Me.LabelX34.Visible = False
        '
        'chk_TabFicha_SplitAgenda
        '
        Me.chk_TabFicha_SplitAgenda.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_SplitAgenda.Location = New System.Drawing.Point(25, 107)
        Me.chk_TabFicha_SplitAgenda.Name = "chk_TabFicha_SplitAgenda"
        Me.chk_TabFicha_SplitAgenda.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_SplitAgenda.TabIndex = 25
        Me.chk_TabFicha_SplitAgenda.Text = "Splitter Cambios Agenda"
        '
        'LabelX35
        '
        Me.LabelX35.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX35.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX35.Location = New System.Drawing.Point(5, 7)
        Me.LabelX35.Name = "LabelX35"
        Me.LabelX35.Size = New System.Drawing.Size(314, 18)
        Me.LabelX35.TabIndex = 113
        Me.LabelX35.Text = "BOTONES FICHA PACIENTE"
        Me.LabelX35.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabFicha_EmailPac
        '
        Me.chk_TabFicha_EmailPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_EmailPac.Location = New System.Drawing.Point(25, 83)
        Me.chk_TabFicha_EmailPac.Name = "chk_TabFicha_EmailPac"
        Me.chk_TabFicha_EmailPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_EmailPac.TabIndex = 24
        Me.chk_TabFicha_EmailPac.Text = "Email paciente Ficha"
        '
        'chk_TabFicha_BPac
        '
        Me.chk_TabFicha_BPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_BPac.Location = New System.Drawing.Point(25, 60)
        Me.chk_TabFicha_BPac.Name = "chk_TabFicha_BPac"
        Me.chk_TabFicha_BPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_BPac.TabIndex = 23
        Me.chk_TabFicha_BPac.Text = "Buscar Pacientes Ficha"
        '
        'chk_TabFicha_EPac
        '
        Me.chk_TabFicha_EPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabFicha_EPac.Location = New System.Drawing.Point(25, 37)
        Me.chk_TabFicha_EPac.Name = "chk_TabFicha_EPac"
        Me.chk_TabFicha_EPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabFicha_EPac.TabIndex = 22
        Me.chk_TabFicha_EPac.Text = "Editar Pacientes Ficha"
        '
        'TabFicha
        '
        Me.TabFicha.AttachedControl = Me.TabControlPanel9
        Me.TabFicha.Name = "TabFicha"
        Me.TabFicha.Text = "TabFicha"
        '
        'TabControlPanel21
        '
        Me.TabControlPanel21.Controls.Add(Me.LabelX32)
        Me.TabControlPanel21.Controls.Add(Me.LabelX33)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_RangoCita)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_CambioDoc)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_CitaAsis)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_CitaCanc)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_NotaCita)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_TConsul)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_ICita)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_ECita)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_MCita)
        Me.TabControlPanel21.Controls.Add(Me.chk_TabCitas_ACita)
        Me.TabControlPanel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel21.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel21.Name = "TabControlPanel21"
        Me.TabControlPanel21.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel21.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel21.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel21.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel21.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel21.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel21.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel21.Style.GradientAngle = 90
        Me.TabControlPanel21.TabIndex = 21
        Me.TabControlPanel21.TabItem = Me.TabCitas
        '
        'LabelX32
        '
        Me.LabelX32.Location = New System.Drawing.Point(6, 8)
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.Size = New System.Drawing.Size(45, 16)
        Me.LabelX32.TabIndex = 112
        Me.LabelX32.Text = "Index 15"
        Me.LabelX32.Visible = False
        '
        'LabelX33
        '
        Me.LabelX33.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX33.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX33.Location = New System.Drawing.Point(5, 7)
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.Size = New System.Drawing.Size(314, 18)
        Me.LabelX33.TabIndex = 111
        Me.LabelX33.Text = "MENU OPCIONES CITAS"
        Me.LabelX33.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabCitas_RangoCita
        '
        Me.chk_TabCitas_RangoCita.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_RangoCita.Location = New System.Drawing.Point(25, 251)
        Me.chk_TabCitas_RangoCita.Name = "chk_TabCitas_RangoCita"
        Me.chk_TabCitas_RangoCita.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_RangoCita.TabIndex = 57
        Me.chk_TabCitas_RangoCita.Text = "Rango Citas Scheduler"
        '
        'chk_TabCitas_CambioDoc
        '
        Me.chk_TabCitas_CambioDoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_CambioDoc.Location = New System.Drawing.Point(25, 222)
        Me.chk_TabCitas_CambioDoc.Name = "chk_TabCitas_CambioDoc"
        Me.chk_TabCitas_CambioDoc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_CambioDoc.TabIndex = 56
        Me.chk_TabCitas_CambioDoc.Text = "Cambio Doctor"
        '
        'chk_TabCitas_CitaAsis
        '
        Me.chk_TabCitas_CitaAsis.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_CitaAsis.Location = New System.Drawing.Point(25, 193)
        Me.chk_TabCitas_CitaAsis.Name = "chk_TabCitas_CitaAsis"
        Me.chk_TabCitas_CitaAsis.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_CitaAsis.TabIndex = 55
        Me.chk_TabCitas_CitaAsis.Text = "Asistio a Cita"
        '
        'chk_TabCitas_CitaCanc
        '
        Me.chk_TabCitas_CitaCanc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_CitaCanc.Location = New System.Drawing.Point(25, 175)
        Me.chk_TabCitas_CitaCanc.Name = "chk_TabCitas_CitaCanc"
        Me.chk_TabCitas_CitaCanc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_CitaCanc.TabIndex = 54
        Me.chk_TabCitas_CitaCanc.Text = "Cita Cancelada"
        '
        'chk_TabCitas_NotaCita
        '
        Me.chk_TabCitas_NotaCita.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_NotaCita.Location = New System.Drawing.Point(25, 146)
        Me.chk_TabCitas_NotaCita.Name = "chk_TabCitas_NotaCita"
        Me.chk_TabCitas_NotaCita.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_NotaCita.TabIndex = 53
        Me.chk_TabCitas_NotaCita.Text = "Notas Citas"
        '
        'chk_TabCitas_TConsul
        '
        Me.chk_TabCitas_TConsul.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_TConsul.Location = New System.Drawing.Point(25, 126)
        Me.chk_TabCitas_TConsul.Name = "chk_TabCitas_TConsul"
        Me.chk_TabCitas_TConsul.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_TConsul.TabIndex = 52
        Me.chk_TabCitas_TConsul.Text = "Tipo Consulta"
        '
        'chk_TabCitas_ICita
        '
        Me.chk_TabCitas_ICita.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_ICita.Location = New System.Drawing.Point(25, 97)
        Me.chk_TabCitas_ICita.Name = "chk_TabCitas_ICita"
        Me.chk_TabCitas_ICita.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_ICita.TabIndex = 51
        Me.chk_TabCitas_ICita.Text = "Imprimir Cita"
        '
        'chk_TabCitas_ECita
        '
        Me.chk_TabCitas_ECita.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_ECita.Location = New System.Drawing.Point(25, 75)
        Me.chk_TabCitas_ECita.Name = "chk_TabCitas_ECita"
        Me.chk_TabCitas_ECita.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_ECita.TabIndex = 50
        Me.chk_TabCitas_ECita.Text = "Eliminar Cita"
        '
        'chk_TabCitas_MCita
        '
        Me.chk_TabCitas_MCita.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_MCita.Location = New System.Drawing.Point(25, 55)
        Me.chk_TabCitas_MCita.Name = "chk_TabCitas_MCita"
        Me.chk_TabCitas_MCita.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_MCita.TabIndex = 49
        Me.chk_TabCitas_MCita.Text = "Modificar Cita"
        '
        'chk_TabCitas_ACita
        '
        Me.chk_TabCitas_ACita.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCitas_ACita.Location = New System.Drawing.Point(25, 35)
        Me.chk_TabCitas_ACita.Name = "chk_TabCitas_ACita"
        Me.chk_TabCitas_ACita.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCitas_ACita.TabIndex = 48
        Me.chk_TabCitas_ACita.Text = "Adicionar Cita"
        '
        'TabCitas
        '
        Me.TabCitas.AttachedControl = Me.TabControlPanel21
        Me.TabCitas.Name = "TabCitas"
        Me.TabCitas.Text = "TabCitas"
        '
        'TabControlPanel20
        '
        Me.TabControlPanel20.Controls.Add(Me.LabelX28)
        Me.TabControlPanel20.Controls.Add(Me.LabelX29)
        Me.TabControlPanel20.Controls.Add(Me.chk_TabSch_SplittCitas)
        Me.TabControlPanel20.Controls.Add(Me.chk_TabSch_Control)
        Me.TabControlPanel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel20.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel20.Name = "TabControlPanel20"
        Me.TabControlPanel20.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel20.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel20.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel20.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel20.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel20.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel20.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel20.Style.GradientAngle = 90
        Me.TabControlPanel20.TabIndex = 20
        Me.TabControlPanel20.TabItem = Me.TabScheduler
        '
        'LabelX28
        '
        Me.LabelX28.Location = New System.Drawing.Point(6, 8)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(45, 16)
        Me.LabelX28.TabIndex = 108
        Me.LabelX28.Text = "Index 14"
        Me.LabelX28.Visible = False
        '
        'LabelX29
        '
        Me.LabelX29.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX29.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX29.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX29.Location = New System.Drawing.Point(5, 7)
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.Size = New System.Drawing.Size(314, 18)
        Me.LabelX29.TabIndex = 107
        Me.LabelX29.Text = "CONTROL SCHEDULER"
        Me.LabelX29.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabSch_SplittCitas
        '
        Me.chk_TabSch_SplittCitas.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSch_SplittCitas.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabSch_SplittCitas.Name = "chk_TabSch_SplittCitas"
        Me.chk_TabSch_SplittCitas.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSch_SplittCitas.TabIndex = 48
        Me.chk_TabSch_SplittCitas.Text = "Splitter Control Citas"
        '
        'chk_TabSch_Control
        '
        Me.chk_TabSch_Control.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSch_Control.Location = New System.Drawing.Point(25, 44)
        Me.chk_TabSch_Control.Name = "chk_TabSch_Control"
        Me.chk_TabSch_Control.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSch_Control.TabIndex = 47
        Me.chk_TabSch_Control.Text = "Control Scheduler"
        '
        'TabScheduler
        '
        Me.TabScheduler.AttachedControl = Me.TabControlPanel20
        Me.TabScheduler.Name = "TabScheduler"
        Me.TabScheduler.Text = "TabScheduler"
        '
        'TabControlPanel19
        '
        Me.TabControlPanel19.Controls.Add(Me.chk_TabSchSup_BuscaHuellas)
        Me.TabControlPanel19.Controls.Add(Me.LabelX30)
        Me.TabControlPanel19.Controls.Add(Me.LabelX31)
        Me.TabControlPanel19.Controls.Add(Me.chk_TabSchSup_Cambio)
        Me.TabControlPanel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel19.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel19.Name = "TabControlPanel19"
        Me.TabControlPanel19.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel19.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel19.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel19.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel19.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel19.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel19.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel19.Style.GradientAngle = 90
        Me.TabControlPanel19.TabIndex = 19
        Me.TabControlPanel19.TabItem = Me.TabSchedulerSup
        '
        'chk_TabSchSup_BuscaHuellas
        '
        Me.chk_TabSchSup_BuscaHuellas.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSchSup_BuscaHuellas.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabSchSup_BuscaHuellas.Name = "chk_TabSchSup_BuscaHuellas"
        Me.chk_TabSchSup_BuscaHuellas.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSchSup_BuscaHuellas.TabIndex = 111
        Me.chk_TabSchSup_BuscaHuellas.Text = "Boton Buscar Huellas"
        '
        'LabelX30
        '
        Me.LabelX30.Location = New System.Drawing.Point(6, 8)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(45, 16)
        Me.LabelX30.TabIndex = 110
        Me.LabelX30.Text = "Index 13"
        Me.LabelX30.Visible = False
        '
        'LabelX31
        '
        Me.LabelX31.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX31.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX31.Location = New System.Drawing.Point(5, 7)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(314, 18)
        Me.LabelX31.TabIndex = 109
        Me.LabelX31.Text = "BOTONES SCHEDULER SUPERIOR"
        Me.LabelX31.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabSchSup_Cambio
        '
        Me.chk_TabSchSup_Cambio.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSchSup_Cambio.Location = New System.Drawing.Point(25, 44)
        Me.chk_TabSchSup_Cambio.Name = "chk_TabSchSup_Cambio"
        Me.chk_TabSchSup_Cambio.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSchSup_Cambio.TabIndex = 46
        Me.chk_TabSchSup_Cambio.Text = "Boton Cambio Scheduler"
        '
        'TabSchedulerSup
        '
        Me.TabSchedulerSup.AttachedControl = Me.TabControlPanel19
        Me.TabSchedulerSup.Name = "TabSchedulerSup"
        Me.TabSchedulerSup.Text = "TabSchedulerSup"
        '
        'TabControlPanel10
        '
        Me.TabControlPanel10.Controls.Add(Me.LabelX26)
        Me.TabControlPanel10.Controls.Add(Me.LabelX27)
        Me.TabControlPanel10.Controls.Add(Me.chk_TabMnuVarios_Ilustraciones)
        Me.TabControlPanel10.Controls.Add(Me.chk_TabMnuVarios)
        Me.TabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel10.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel10.Name = "TabControlPanel10"
        Me.TabControlPanel10.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel10.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel10.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel10.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel10.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel10.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel10.Style.GradientAngle = 90
        Me.TabControlPanel10.TabIndex = 22
        Me.TabControlPanel10.TabItem = Me.TabMenuVarios
        '
        'LabelX26
        '
        Me.LabelX26.Location = New System.Drawing.Point(6, 8)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(45, 16)
        Me.LabelX26.TabIndex = 106
        Me.LabelX26.Text = "Index 12"
        Me.LabelX26.Visible = False
        '
        'LabelX27
        '
        Me.LabelX27.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX27.Location = New System.Drawing.Point(5, 7)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(314, 18)
        Me.LabelX27.TabIndex = 105
        Me.LabelX27.Text = "MENU VARIOS"
        Me.LabelX27.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuVarios_Ilustraciones
        '
        Me.chk_TabMnuVarios_Ilustraciones.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuVarios_Ilustraciones.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuVarios_Ilustraciones.Name = "chk_TabMnuVarios_Ilustraciones"
        Me.chk_TabMnuVarios_Ilustraciones.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuVarios_Ilustraciones.TabIndex = 46
        Me.chk_TabMnuVarios_Ilustraciones.Text = "Ilustraciones"
        '
        'chk_TabMnuVarios
        '
        Me.chk_TabMnuVarios.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuVarios.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuVarios.Name = "chk_TabMnuVarios"
        Me.chk_TabMnuVarios.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuVarios.TabIndex = 45
        Me.chk_TabMnuVarios.Text = "Menu Varios"
        '
        'TabMenuVarios
        '
        Me.TabMenuVarios.AttachedControl = Me.TabControlPanel10
        Me.TabMenuVarios.Name = "TabMenuVarios"
        Me.TabMenuVarios.Text = "TabMenuVarios"
        '
        'TabControlPanel18
        '
        Me.TabControlPanel18.Controls.Add(Me.LabelX24)
        Me.TabControlPanel18.Controls.Add(Me.LabelX25)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_MDiario)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_Gastos)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_ECuenta)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_Vprocedimiento)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_CEgreso)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_Presupuesto)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_RCaja)
        Me.TabControlPanel18.Controls.Add(Me.chk_TabMnuConta_Conta)
        Me.TabControlPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel18.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel18.Name = "TabControlPanel18"
        Me.TabControlPanel18.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel18.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel18.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel18.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel18.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel18.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel18.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel18.Style.GradientAngle = 90
        Me.TabControlPanel18.TabIndex = 18
        Me.TabControlPanel18.TabItem = Me.TabMenuContab
        '
        'LabelX24
        '
        Me.LabelX24.Location = New System.Drawing.Point(6, 8)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(45, 16)
        Me.LabelX24.TabIndex = 104
        Me.LabelX24.Text = "Index 11"
        Me.LabelX24.Visible = False
        '
        'LabelX25
        '
        Me.LabelX25.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX25.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX25.Location = New System.Drawing.Point(5, 7)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(314, 18)
        Me.LabelX25.TabIndex = 103
        Me.LabelX25.Text = "MENU CONTABILIDAD"
        Me.LabelX25.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuConta_MDiario
        '
        Me.chk_TabMnuConta_MDiario.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_MDiario.Location = New System.Drawing.Point(25, 201)
        Me.chk_TabMnuConta_MDiario.Name = "chk_TabMnuConta_MDiario"
        Me.chk_TabMnuConta_MDiario.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_MDiario.TabIndex = 50
        Me.chk_TabMnuConta_MDiario.Text = "Menu Movimiento Diario"
        '
        'chk_TabMnuConta_Gastos
        '
        Me.chk_TabMnuConta_Gastos.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_Gastos.Location = New System.Drawing.Point(25, 180)
        Me.chk_TabMnuConta_Gastos.Name = "chk_TabMnuConta_Gastos"
        Me.chk_TabMnuConta_Gastos.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_Gastos.TabIndex = 49
        Me.chk_TabMnuConta_Gastos.Text = "Menu Gastos"
        '
        'chk_TabMnuConta_ECuenta
        '
        Me.chk_TabMnuConta_ECuenta.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_ECuenta.Location = New System.Drawing.Point(25, 157)
        Me.chk_TabMnuConta_ECuenta.Name = "chk_TabMnuConta_ECuenta"
        Me.chk_TabMnuConta_ECuenta.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_ECuenta.TabIndex = 48
        Me.chk_TabMnuConta_ECuenta.Text = "Menu Estado de Cuenta"
        '
        'chk_TabMnuConta_Vprocedimiento
        '
        Me.chk_TabMnuConta_Vprocedimiento.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_Vprocedimiento.Location = New System.Drawing.Point(25, 134)
        Me.chk_TabMnuConta_Vprocedimiento.Name = "chk_TabMnuConta_Vprocedimiento"
        Me.chk_TabMnuConta_Vprocedimiento.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_Vprocedimiento.TabIndex = 47
        Me.chk_TabMnuConta_Vprocedimiento.Text = "Menu Valor Procedimientos"
        '
        'chk_TabMnuConta_CEgreso
        '
        Me.chk_TabMnuConta_CEgreso.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_CEgreso.Location = New System.Drawing.Point(25, 88)
        Me.chk_TabMnuConta_CEgreso.Name = "chk_TabMnuConta_CEgreso"
        Me.chk_TabMnuConta_CEgreso.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_CEgreso.TabIndex = 46
        Me.chk_TabMnuConta_CEgreso.Text = "Menu C. Egreso"
        '
        'chk_TabMnuConta_Presupuesto
        '
        Me.chk_TabMnuConta_Presupuesto.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_Presupuesto.Location = New System.Drawing.Point(25, 111)
        Me.chk_TabMnuConta_Presupuesto.Name = "chk_TabMnuConta_Presupuesto"
        Me.chk_TabMnuConta_Presupuesto.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_Presupuesto.TabIndex = 45
        Me.chk_TabMnuConta_Presupuesto.Text = "Menu Presupuesto"
        '
        'chk_TabMnuConta_RCaja
        '
        Me.chk_TabMnuConta_RCaja.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_RCaja.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuConta_RCaja.Name = "chk_TabMnuConta_RCaja"
        Me.chk_TabMnuConta_RCaja.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_RCaja.TabIndex = 44
        Me.chk_TabMnuConta_RCaja.Text = "Menu Recibo de Caja"
        '
        'chk_TabMnuConta_Conta
        '
        Me.chk_TabMnuConta_Conta.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuConta_Conta.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuConta_Conta.Name = "chk_TabMnuConta_Conta"
        Me.chk_TabMnuConta_Conta.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuConta_Conta.TabIndex = 43
        Me.chk_TabMnuConta_Conta.Text = "Menu Contabilidad"
        '
        'TabMenuContab
        '
        Me.TabMenuContab.AttachedControl = Me.TabControlPanel18
        Me.TabMenuContab.Name = "TabMenuContab"
        Me.TabMenuContab.Text = "TabMenuContab"
        '
        'TabControlPanel17
        '
        Me.TabControlPanel17.Controls.Add(Me.LabelX22)
        Me.TabControlPanel17.Controls.Add(Me.LabelX23)
        Me.TabControlPanel17.Controls.Add(Me.chk_TabMnuCitas_BloquearCitas)
        Me.TabControlPanel17.Controls.Add(Me.chk_TabMnuCitas_Reminder)
        Me.TabControlPanel17.Controls.Add(Me.chk_TabMnuCitas_Citas)
        Me.TabControlPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel17.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel17.Name = "TabControlPanel17"
        Me.TabControlPanel17.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel17.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel17.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel17.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel17.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel17.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel17.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel17.Style.GradientAngle = 90
        Me.TabControlPanel17.TabIndex = 17
        Me.TabControlPanel17.TabItem = Me.TabMenuCitas
        '
        'LabelX22
        '
        Me.LabelX22.Location = New System.Drawing.Point(6, 8)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(45, 16)
        Me.LabelX22.TabIndex = 102
        Me.LabelX22.Text = "Index 10"
        Me.LabelX22.Visible = False
        '
        'LabelX23
        '
        Me.LabelX23.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX23.Location = New System.Drawing.Point(5, 7)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(314, 18)
        Me.LabelX23.TabIndex = 101
        Me.LabelX23.Text = "MENU CITAS"
        Me.LabelX23.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuCitas_BloquearCitas
        '
        Me.chk_TabMnuCitas_BloquearCitas.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuCitas_BloquearCitas.Location = New System.Drawing.Point(25, 83)
        Me.chk_TabMnuCitas_BloquearCitas.Name = "chk_TabMnuCitas_BloquearCitas"
        Me.chk_TabMnuCitas_BloquearCitas.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuCitas_BloquearCitas.TabIndex = 43
        Me.chk_TabMnuCitas_BloquearCitas.Text = "Menu Bloq/Desbloq Citas"
        '
        'chk_TabMnuCitas_Reminder
        '
        Me.chk_TabMnuCitas_Reminder.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuCitas_Reminder.Location = New System.Drawing.Point(25, 61)
        Me.chk_TabMnuCitas_Reminder.Name = "chk_TabMnuCitas_Reminder"
        Me.chk_TabMnuCitas_Reminder.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuCitas_Reminder.TabIndex = 42
        Me.chk_TabMnuCitas_Reminder.Text = "Menu Reminder Citas"
        '
        'chk_TabMnuCitas_Citas
        '
        Me.chk_TabMnuCitas_Citas.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuCitas_Citas.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuCitas_Citas.Name = "chk_TabMnuCitas_Citas"
        Me.chk_TabMnuCitas_Citas.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuCitas_Citas.TabIndex = 41
        Me.chk_TabMnuCitas_Citas.Text = "Menu Citas"
        '
        'TabMenuCitas
        '
        Me.TabMenuCitas.AttachedControl = Me.TabControlPanel17
        Me.TabMenuCitas.Name = "TabMenuCitas"
        Me.TabMenuCitas.Text = "TabMenuCitas"
        '
        'TabControlPanel16
        '
        Me.TabControlPanel16.Controls.Add(Me.LabelX20)
        Me.TabControlPanel16.Controls.Add(Me.LabelX21)
        Me.TabControlPanel16.Controls.Add(Me.chk_TabMnuAdm_Acceso)
        Me.TabControlPanel16.Controls.Add(Me.chk_TabMnuAdm_Config)
        Me.TabControlPanel16.Controls.Add(Me.chk_TabMnuAdm_Import)
        Me.TabControlPanel16.Controls.Add(Me.chk_TabMnuAdm_Audito)
        Me.TabControlPanel16.Controls.Add(Me.chk_TabMnuAdm_Aut)
        Me.TabControlPanel16.Controls.Add(Me.chk_TabMnuAdm_Adm)
        Me.TabControlPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel16.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel16.Name = "TabControlPanel16"
        Me.TabControlPanel16.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel16.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel16.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel16.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel16.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel16.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel16.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel16.Style.GradientAngle = 90
        Me.TabControlPanel16.TabIndex = 16
        Me.TabControlPanel16.TabItem = Me.TabMenuAdmon
        '
        'LabelX20
        '
        Me.LabelX20.Location = New System.Drawing.Point(6, 8)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(41, 16)
        Me.LabelX20.TabIndex = 100
        Me.LabelX20.Text = "Index 9"
        Me.LabelX20.Visible = False
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX21.Location = New System.Drawing.Point(5, 7)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(314, 18)
        Me.LabelX21.TabIndex = 99
        Me.LabelX21.Text = "MENU ADMINISTRACION"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuAdm_Acceso
        '
        Me.chk_TabMnuAdm_Acceso.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuAdm_Acceso.Location = New System.Drawing.Point(25, 157)
        Me.chk_TabMnuAdm_Acceso.Name = "chk_TabMnuAdm_Acceso"
        Me.chk_TabMnuAdm_Acceso.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabMnuAdm_Acceso.TabIndex = 45
        Me.chk_TabMnuAdm_Acceso.Text = "Menu Niveles de Acceso"
        '
        'chk_TabMnuAdm_Config
        '
        Me.chk_TabMnuAdm_Config.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuAdm_Config.Location = New System.Drawing.Point(25, 134)
        Me.chk_TabMnuAdm_Config.Name = "chk_TabMnuAdm_Config"
        Me.chk_TabMnuAdm_Config.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabMnuAdm_Config.TabIndex = 44
        Me.chk_TabMnuAdm_Config.Text = "Menu Configuracion Inicial"
        '
        'chk_TabMnuAdm_Import
        '
        Me.chk_TabMnuAdm_Import.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuAdm_Import.Location = New System.Drawing.Point(25, 111)
        Me.chk_TabMnuAdm_Import.Name = "chk_TabMnuAdm_Import"
        Me.chk_TabMnuAdm_Import.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabMnuAdm_Import.TabIndex = 43
        Me.chk_TabMnuAdm_Import.Text = "Menu Importacion Base de Datos"
        '
        'chk_TabMnuAdm_Audito
        '
        Me.chk_TabMnuAdm_Audito.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuAdm_Audito.Location = New System.Drawing.Point(25, 88)
        Me.chk_TabMnuAdm_Audito.Name = "chk_TabMnuAdm_Audito"
        Me.chk_TabMnuAdm_Audito.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabMnuAdm_Audito.TabIndex = 42
        Me.chk_TabMnuAdm_Audito.Text = "Menu Informes Auditoria"
        '
        'chk_TabMnuAdm_Aut
        '
        Me.chk_TabMnuAdm_Aut.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuAdm_Aut.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuAdm_Aut.Name = "chk_TabMnuAdm_Aut"
        Me.chk_TabMnuAdm_Aut.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabMnuAdm_Aut.TabIndex = 41
        Me.chk_TabMnuAdm_Aut.Text = "Menu Autenticacion servidor"
        '
        'chk_TabMnuAdm_Adm
        '
        Me.chk_TabMnuAdm_Adm.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuAdm_Adm.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuAdm_Adm.Name = "chk_TabMnuAdm_Adm"
        Me.chk_TabMnuAdm_Adm.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuAdm_Adm.TabIndex = 40
        Me.chk_TabMnuAdm_Adm.Text = "Menu Administracion"
        '
        'TabMenuAdmon
        '
        Me.TabMenuAdmon.AttachedControl = Me.TabControlPanel16
        Me.TabMenuAdmon.Name = "TabMenuAdmon"
        Me.TabMenuAdmon.Text = "TabMenuAdmon"
        '
        'TabControlPanel15
        '
        Me.TabControlPanel15.Controls.Add(Me.LabelX18)
        Me.TabControlPanel15.Controls.Add(Me.LabelX19)
        Me.TabControlPanel15.Controls.Add(Me.chk_TabMnuInf_Documentos)
        Me.TabControlPanel15.Controls.Add(Me.chk_TabMnuInf_ProcD)
        Me.TabControlPanel15.Controls.Add(Me.chk_TabMnuInf_InfV)
        Me.TabControlPanel15.Controls.Add(Me.chk_TabMnuInf_Inf)
        Me.TabControlPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel15.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel15.Name = "TabControlPanel15"
        Me.TabControlPanel15.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel15.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel15.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel15.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel15.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel15.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel15.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel15.Style.GradientAngle = 90
        Me.TabControlPanel15.TabIndex = 15
        Me.TabControlPanel15.TabItem = Me.TabMenuInformes
        '
        'LabelX18
        '
        Me.LabelX18.Location = New System.Drawing.Point(6, 8)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(41, 16)
        Me.LabelX18.TabIndex = 98
        Me.LabelX18.Text = "Index 8"
        Me.LabelX18.Visible = False
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX19.Location = New System.Drawing.Point(5, 7)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(314, 18)
        Me.LabelX19.TabIndex = 97
        Me.LabelX19.Text = "MENU INFORMES"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuInf_Documentos
        '
        Me.chk_TabMnuInf_Documentos.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuInf_Documentos.Location = New System.Drawing.Point(25, 111)
        Me.chk_TabMnuInf_Documentos.Name = "chk_TabMnuInf_Documentos"
        Me.chk_TabMnuInf_Documentos.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabMnuInf_Documentos.TabIndex = 40
        Me.chk_TabMnuInf_Documentos.Text = "Menu Documentos"
        '
        'chk_TabMnuInf_ProcD
        '
        Me.chk_TabMnuInf_ProcD.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuInf_ProcD.Location = New System.Drawing.Point(25, 88)
        Me.chk_TabMnuInf_ProcD.Name = "chk_TabMnuInf_ProcD"
        Me.chk_TabMnuInf_ProcD.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabMnuInf_ProcD.TabIndex = 39
        Me.chk_TabMnuInf_ProcD.Text = "Menu Procedimientos Diarios"
        '
        'chk_TabMnuInf_InfV
        '
        Me.chk_TabMnuInf_InfV.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuInf_InfV.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuInf_InfV.Name = "chk_TabMnuInf_InfV"
        Me.chk_TabMnuInf_InfV.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuInf_InfV.TabIndex = 38
        Me.chk_TabMnuInf_InfV.Text = "Menu Informes Varios"
        '
        'chk_TabMnuInf_Inf
        '
        Me.chk_TabMnuInf_Inf.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuInf_Inf.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuInf_Inf.Name = "chk_TabMnuInf_Inf"
        Me.chk_TabMnuInf_Inf.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuInf_Inf.TabIndex = 37
        Me.chk_TabMnuInf_Inf.Text = "Menu Informes"
        '
        'TabMenuInformes
        '
        Me.TabMenuInformes.AttachedControl = Me.TabControlPanel15
        Me.TabMenuInformes.Name = "TabMenuInformes"
        Me.TabMenuInformes.Text = "TabMenuInformes"
        '
        'TabControlPanel14
        '
        Me.TabControlPanel14.Controls.Add(Me.LabelX16)
        Me.TabControlPanel14.Controls.Add(Me.LabelX17)
        Me.TabControlPanel14.Controls.Add(Me.chk_TabMnuEnt_BProv)
        Me.TabControlPanel14.Controls.Add(Me.chk_TabMnuEnt_NProv)
        Me.TabControlPanel14.Controls.Add(Me.chk_TabMnuEnt_BEnt)
        Me.TabControlPanel14.Controls.Add(Me.chk_TabMnuEnt_NEnt)
        Me.TabControlPanel14.Controls.Add(Me.chk_TabMnuEnt_Ent)
        Me.TabControlPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel14.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel14.Name = "TabControlPanel14"
        Me.TabControlPanel14.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel14.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel14.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel14.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel14.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel14.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel14.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel14.Style.GradientAngle = 90
        Me.TabControlPanel14.TabIndex = 14
        Me.TabControlPanel14.TabItem = Me.TabMenuEntidades
        '
        'LabelX16
        '
        Me.LabelX16.Location = New System.Drawing.Point(6, 8)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(41, 16)
        Me.LabelX16.TabIndex = 96
        Me.LabelX16.Text = "Index 7"
        Me.LabelX16.Visible = False
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX17.Location = New System.Drawing.Point(5, 7)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(314, 18)
        Me.LabelX17.TabIndex = 95
        Me.LabelX17.Text = "MENU ENTIDADES"
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuEnt_BProv
        '
        Me.chk_TabMnuEnt_BProv.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuEnt_BProv.Location = New System.Drawing.Point(25, 134)
        Me.chk_TabMnuEnt_BProv.Name = "chk_TabMnuEnt_BProv"
        Me.chk_TabMnuEnt_BProv.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuEnt_BProv.TabIndex = 39
        Me.chk_TabMnuEnt_BProv.Text = "Menu Buscar Proveedor"
        '
        'chk_TabMnuEnt_NProv
        '
        Me.chk_TabMnuEnt_NProv.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuEnt_NProv.Location = New System.Drawing.Point(25, 111)
        Me.chk_TabMnuEnt_NProv.Name = "chk_TabMnuEnt_NProv"
        Me.chk_TabMnuEnt_NProv.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuEnt_NProv.TabIndex = 38
        Me.chk_TabMnuEnt_NProv.Text = "Menu Nuevo Proveedor"
        '
        'chk_TabMnuEnt_BEnt
        '
        Me.chk_TabMnuEnt_BEnt.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuEnt_BEnt.Location = New System.Drawing.Point(25, 88)
        Me.chk_TabMnuEnt_BEnt.Name = "chk_TabMnuEnt_BEnt"
        Me.chk_TabMnuEnt_BEnt.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuEnt_BEnt.TabIndex = 36
        Me.chk_TabMnuEnt_BEnt.Text = "Menu Buscar Entidad"
        '
        'chk_TabMnuEnt_NEnt
        '
        Me.chk_TabMnuEnt_NEnt.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuEnt_NEnt.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuEnt_NEnt.Name = "chk_TabMnuEnt_NEnt"
        Me.chk_TabMnuEnt_NEnt.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuEnt_NEnt.TabIndex = 35
        Me.chk_TabMnuEnt_NEnt.Text = "Menu Nueva Entidad"
        '
        'chk_TabMnuEnt_Ent
        '
        Me.chk_TabMnuEnt_Ent.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuEnt_Ent.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuEnt_Ent.Name = "chk_TabMnuEnt_Ent"
        Me.chk_TabMnuEnt_Ent.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuEnt_Ent.TabIndex = 34
        Me.chk_TabMnuEnt_Ent.Text = "Menu Entidades"
        '
        'TabMenuEntidades
        '
        Me.TabMenuEntidades.AttachedControl = Me.TabControlPanel14
        Me.TabMenuEntidades.Name = "TabMenuEntidades"
        Me.TabMenuEntidades.Text = "TabMenuEntidades"
        '
        'TabControlPanel13
        '
        Me.TabControlPanel13.Controls.Add(Me.LabelX14)
        Me.TabControlPanel13.Controls.Add(Me.LabelX15)
        Me.TabControlPanel13.Controls.Add(Me.chk_TabMnuUsu_BUsu)
        Me.TabControlPanel13.Controls.Add(Me.chk_TabMnuUsu_NUsu)
        Me.TabControlPanel13.Controls.Add(Me.chk_TabMnuUsu_Usu)
        Me.TabControlPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel13.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel13.Name = "TabControlPanel13"
        Me.TabControlPanel13.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel13.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel13.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel13.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel13.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel13.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel13.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel13.Style.GradientAngle = 90
        Me.TabControlPanel13.TabIndex = 13
        Me.TabControlPanel13.TabItem = Me.TabMenuUsuarios
        '
        'LabelX14
        '
        Me.LabelX14.Location = New System.Drawing.Point(6, 8)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(41, 16)
        Me.LabelX14.TabIndex = 94
        Me.LabelX14.Text = "Index 6"
        Me.LabelX14.Visible = False
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX15.Location = New System.Drawing.Point(5, 7)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(314, 18)
        Me.LabelX15.TabIndex = 93
        Me.LabelX15.Text = "MENU USUARIOS"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuUsu_BUsu
        '
        Me.chk_TabMnuUsu_BUsu.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuUsu_BUsu.Location = New System.Drawing.Point(25, 88)
        Me.chk_TabMnuUsu_BUsu.Name = "chk_TabMnuUsu_BUsu"
        Me.chk_TabMnuUsu_BUsu.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuUsu_BUsu.TabIndex = 33
        Me.chk_TabMnuUsu_BUsu.Text = "Menu Buscar Usuario"
        '
        'chk_TabMnuUsu_NUsu
        '
        Me.chk_TabMnuUsu_NUsu.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuUsu_NUsu.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuUsu_NUsu.Name = "chk_TabMnuUsu_NUsu"
        Me.chk_TabMnuUsu_NUsu.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuUsu_NUsu.TabIndex = 32
        Me.chk_TabMnuUsu_NUsu.Text = "Menu Nuevo Usuario"
        '
        'chk_TabMnuUsu_Usu
        '
        Me.chk_TabMnuUsu_Usu.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuUsu_Usu.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuUsu_Usu.Name = "chk_TabMnuUsu_Usu"
        Me.chk_TabMnuUsu_Usu.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuUsu_Usu.TabIndex = 31
        Me.chk_TabMnuUsu_Usu.Text = "Menu Usuarios"
        '
        'TabMenuUsuarios
        '
        Me.TabMenuUsuarios.AttachedControl = Me.TabControlPanel13
        Me.TabMenuUsuarios.Name = "TabMenuUsuarios"
        Me.TabMenuUsuarios.Text = "TabMenuUsuarios"
        '
        'TabControlPanel12
        '
        Me.TabControlPanel12.Controls.Add(Me.LabelX12)
        Me.TabControlPanel12.Controls.Add(Me.LabelX13)
        Me.TabControlPanel12.Controls.Add(Me.chk_TabMnuDoc_BDoc)
        Me.TabControlPanel12.Controls.Add(Me.chk_TabMnuDoc_NDoc)
        Me.TabControlPanel12.Controls.Add(Me.chk_TabMnuDoc_Doc)
        Me.TabControlPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel12.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel12.Name = "TabControlPanel12"
        Me.TabControlPanel12.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel12.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel12.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel12.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel12.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel12.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel12.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel12.Style.GradientAngle = 90
        Me.TabControlPanel12.TabIndex = 12
        Me.TabControlPanel12.TabItem = Me.TabMenuDoctores
        '
        'LabelX12
        '
        Me.LabelX12.Location = New System.Drawing.Point(6, 8)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(41, 16)
        Me.LabelX12.TabIndex = 92
        Me.LabelX12.Text = "Index 5"
        Me.LabelX12.Visible = False
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX13.Location = New System.Drawing.Point(5, 7)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(314, 18)
        Me.LabelX13.TabIndex = 91
        Me.LabelX13.Text = "MENU DOCTORES"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuDoc_BDoc
        '
        Me.chk_TabMnuDoc_BDoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuDoc_BDoc.Location = New System.Drawing.Point(25, 88)
        Me.chk_TabMnuDoc_BDoc.Name = "chk_TabMnuDoc_BDoc"
        Me.chk_TabMnuDoc_BDoc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuDoc_BDoc.TabIndex = 30
        Me.chk_TabMnuDoc_BDoc.Text = "Menu Buscar Doctor"
        '
        'chk_TabMnuDoc_NDoc
        '
        Me.chk_TabMnuDoc_NDoc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuDoc_NDoc.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuDoc_NDoc.Name = "chk_TabMnuDoc_NDoc"
        Me.chk_TabMnuDoc_NDoc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuDoc_NDoc.TabIndex = 29
        Me.chk_TabMnuDoc_NDoc.Text = "Menu Nuevo Doctor"
        '
        'chk_TabMnuDoc_Doc
        '
        Me.chk_TabMnuDoc_Doc.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuDoc_Doc.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuDoc_Doc.Name = "chk_TabMnuDoc_Doc"
        Me.chk_TabMnuDoc_Doc.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuDoc_Doc.TabIndex = 28
        Me.chk_TabMnuDoc_Doc.Text = "Menu Doctores"
        '
        'TabMenuDoctores
        '
        Me.TabMenuDoctores.AttachedControl = Me.TabControlPanel12
        Me.TabMenuDoctores.Name = "TabMenuDoctores"
        Me.TabMenuDoctores.Text = "TabMenuDoctores"
        '
        'TabControlPanel11
        '
        Me.TabControlPanel11.Controls.Add(Me.LabelX10)
        Me.TabControlPanel11.Controls.Add(Me.LabelX11)
        Me.TabControlPanel11.Controls.Add(Me.chk_TabMnuPac_BPac)
        Me.TabControlPanel11.Controls.Add(Me.chk_TabMnuPac_NPac)
        Me.TabControlPanel11.Controls.Add(Me.chk_TabMnuPac_Pac)
        Me.TabControlPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel11.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel11.Name = "TabControlPanel11"
        Me.TabControlPanel11.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel11.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel11.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel11.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel11.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel11.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel11.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel11.Style.GradientAngle = 90
        Me.TabControlPanel11.TabIndex = 11
        Me.TabControlPanel11.TabItem = Me.TabMenuPacientes
        '
        'LabelX10
        '
        Me.LabelX10.Location = New System.Drawing.Point(6, 8)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(41, 16)
        Me.LabelX10.TabIndex = 92
        Me.LabelX10.Text = "Index 4"
        Me.LabelX10.Visible = False
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(5, 7)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(314, 18)
        Me.LabelX11.TabIndex = 91
        Me.LabelX11.Text = "MENU PACIENTES"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabMnuPac_BPac
        '
        Me.chk_TabMnuPac_BPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuPac_BPac.Location = New System.Drawing.Point(25, 88)
        Me.chk_TabMnuPac_BPac.Name = "chk_TabMnuPac_BPac"
        Me.chk_TabMnuPac_BPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuPac_BPac.TabIndex = 27
        Me.chk_TabMnuPac_BPac.Text = "Menu Buscar Paciente"
        '
        'chk_TabMnuPac_NPac
        '
        Me.chk_TabMnuPac_NPac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuPac_NPac.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabMnuPac_NPac.Name = "chk_TabMnuPac_NPac"
        Me.chk_TabMnuPac_NPac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuPac_NPac.TabIndex = 26
        Me.chk_TabMnuPac_NPac.Text = "Menu Nuevo Paciente"
        '
        'chk_TabMnuPac_Pac
        '
        Me.chk_TabMnuPac_Pac.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabMnuPac_Pac.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabMnuPac_Pac.Name = "chk_TabMnuPac_Pac"
        Me.chk_TabMnuPac_Pac.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabMnuPac_Pac.TabIndex = 25
        Me.chk_TabMnuPac_Pac.Text = "Menu Pacientes"
        '
        'TabMenuPacientes
        '
        Me.TabMenuPacientes.AttachedControl = Me.TabControlPanel11
        Me.TabMenuPacientes.Name = "TabMenuPacientes"
        Me.TabMenuPacientes.Text = "TabMenuPacientes"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.LabelX9)
        Me.TabControlPanel4.Controls.Add(Me.chk_TabSincro_Cirugia)
        Me.TabControlPanel4.Controls.Add(Me.LabelX5)
        Me.TabControlPanel4.Controls.Add(Me.chk_TabSincro_Actualizacion)
        Me.TabControlPanel4.Controls.Add(Me.chk_TabSincro_SoporteRemoto)
        Me.TabControlPanel4.Controls.Add(Me.chk_TabSincro_Sincro)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabSincro
        '
        'LabelX9
        '
        Me.LabelX9.Location = New System.Drawing.Point(6, 8)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(41, 16)
        Me.LabelX9.TabIndex = 90
        Me.LabelX9.Text = "Index 3"
        Me.LabelX9.Visible = False
        '
        'chk_TabSincro_Cirugia
        '
        Me.chk_TabSincro_Cirugia.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSincro_Cirugia.Location = New System.Drawing.Point(25, 105)
        Me.chk_TabSincro_Cirugia.Name = "chk_TabSincro_Cirugia"
        Me.chk_TabSincro_Cirugia.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSincro_Cirugia.TabIndex = 91
        Me.chk_TabSincro_Cirugia.Text = "Cirugia"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX5.Location = New System.Drawing.Point(5, 7)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(314, 18)
        Me.LabelX5.TabIndex = 90
        Me.LabelX5.Text = "BOTONES SOPORTE"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabSincro_Actualizacion
        '
        Me.chk_TabSincro_Actualizacion.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSincro_Actualizacion.Location = New System.Drawing.Point(25, 83)
        Me.chk_TabSincro_Actualizacion.Name = "chk_TabSincro_Actualizacion"
        Me.chk_TabSincro_Actualizacion.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSincro_Actualizacion.TabIndex = 7
        Me.chk_TabSincro_Actualizacion.Text = "Actualizacion"
        '
        'chk_TabSincro_SoporteRemoto
        '
        Me.chk_TabSincro_SoporteRemoto.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSincro_SoporteRemoto.Location = New System.Drawing.Point(25, 63)
        Me.chk_TabSincro_SoporteRemoto.Name = "chk_TabSincro_SoporteRemoto"
        Me.chk_TabSincro_SoporteRemoto.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSincro_SoporteRemoto.TabIndex = 6
        Me.chk_TabSincro_SoporteRemoto.Text = "Soporte Remoto"
        '
        'chk_TabSincro_Sincro
        '
        Me.chk_TabSincro_Sincro.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabSincro_Sincro.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabSincro_Sincro.Name = "chk_TabSincro_Sincro"
        Me.chk_TabSincro_Sincro.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabSincro_Sincro.TabIndex = 5
        Me.chk_TabSincro_Sincro.Text = "Sincronizar"
        '
        'TabSincro
        '
        Me.TabSincro.AttachedControl = Me.TabControlPanel4
        Me.TabSincro.Name = "TabSincro"
        Me.TabSincro.Text = "TabSincro"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.LabelX8)
        Me.TabControlPanel3.Controls.Add(Me.LabelX4)
        Me.TabControlPanel3.Controls.Add(Me.chk_TabCambioUsu_Cambio)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabCambioUsuarios
        '
        'LabelX8
        '
        Me.LabelX8.Location = New System.Drawing.Point(7, 8)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(41, 16)
        Me.LabelX8.TabIndex = 90
        Me.LabelX8.Text = "Index 2"
        Me.LabelX8.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX4.Location = New System.Drawing.Point(6, 7)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(314, 18)
        Me.LabelX4.TabIndex = 89
        Me.LabelX4.Text = "BOTONES CAMBIO DE USUARIO"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabCambioUsu_Cambio
        '
        Me.chk_TabCambioUsu_Cambio.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabCambioUsu_Cambio.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabCambioUsu_Cambio.Name = "chk_TabCambioUsu_Cambio"
        Me.chk_TabCambioUsu_Cambio.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabCambioUsu_Cambio.TabIndex = 4
        Me.chk_TabCambioUsu_Cambio.Text = "Cambio de Usuario"
        '
        'TabCambioUsuarios
        '
        Me.TabCambioUsuarios.AttachedControl = Me.TabControlPanel3
        Me.TabCambioUsuarios.Name = "TabCambioUsuarios"
        Me.TabCambioUsuarios.Text = "TabCambioUsuarios"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.LabelX7)
        Me.TabControlPanel2.Controls.Add(Me.LabelX3)
        Me.TabControlPanel2.Controls.Add(Me.chk_TabBackup_Restaurar)
        Me.TabControlPanel2.Controls.Add(Me.chk_TabBackup_Copia)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(323, 276)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabBackup
        '
        'LabelX7
        '
        Me.LabelX7.Location = New System.Drawing.Point(7, 8)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(41, 16)
        Me.LabelX7.TabIndex = 89
        Me.LabelX7.Text = "Index 1"
        Me.LabelX7.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX3.Location = New System.Drawing.Point(6, 7)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(314, 18)
        Me.LabelX3.TabIndex = 88
        Me.LabelX3.Text = "BOTONES COPIA SEGURIDAD"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chk_TabBackup_Restaurar
        '
        Me.chk_TabBackup_Restaurar.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabBackup_Restaurar.Location = New System.Drawing.Point(25, 65)
        Me.chk_TabBackup_Restaurar.Name = "chk_TabBackup_Restaurar"
        Me.chk_TabBackup_Restaurar.Size = New System.Drawing.Size(188, 23)
        Me.chk_TabBackup_Restaurar.TabIndex = 4
        Me.chk_TabBackup_Restaurar.Text = "Restaurar Copia de Seguridad"
        '
        'chk_TabBackup_Copia
        '
        Me.chk_TabBackup_Copia.BackColor = System.Drawing.Color.Transparent
        Me.chk_TabBackup_Copia.Location = New System.Drawing.Point(25, 42)
        Me.chk_TabBackup_Copia.Name = "chk_TabBackup_Copia"
        Me.chk_TabBackup_Copia.Size = New System.Drawing.Size(154, 23)
        Me.chk_TabBackup_Copia.TabIndex = 3
        Me.chk_TabBackup_Copia.Text = "Copia de Seguridad"
        '
        'TabBackup
        '
        Me.TabBackup.AttachedControl = Me.TabControlPanel2
        Me.TabBackup.Name = "TabBackup"
        Me.TabBackup.Text = "TabBackup"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Enabled = False
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(116, 434)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 39)
        Me.btnModificar.TabIndex = 28
        Me.btnModificar.Text = "MODIFICAR"
        '
        'GroupPerfilesAcceso
        '
        Me.GroupPerfilesAcceso.BackColor = System.Drawing.Color.Transparent
        Me.GroupPerfilesAcceso.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPerfilesAcceso.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPerfilesAcceso.Controls.Add(Me.txtIdperfil)
        Me.GroupPerfilesAcceso.Controls.Add(Me.cmbPerfilAcceso)
        Me.GroupPerfilesAcceso.Controls.Add(Me.txtnom_perf)
        Me.GroupPerfilesAcceso.Controls.Add(Me.LabelX1)
        Me.GroupPerfilesAcceso.Controls.Add(Me.lblVTotal_cuota)
        Me.GroupPerfilesAcceso.Location = New System.Drawing.Point(11, 46)
        Me.GroupPerfilesAcceso.Name = "GroupPerfilesAcceso"
        Me.GroupPerfilesAcceso.Size = New System.Drawing.Size(504, 77)
        '
        '
        '
        Me.GroupPerfilesAcceso.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPerfilesAcceso.Style.BackColorGradientAngle = 90
        Me.GroupPerfilesAcceso.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPerfilesAcceso.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPerfilesAcceso.Style.BorderBottomWidth = 1
        Me.GroupPerfilesAcceso.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPerfilesAcceso.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPerfilesAcceso.Style.BorderLeftWidth = 1
        Me.GroupPerfilesAcceso.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPerfilesAcceso.Style.BorderRightWidth = 1
        Me.GroupPerfilesAcceso.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPerfilesAcceso.Style.BorderTopWidth = 1
        Me.GroupPerfilesAcceso.Style.CornerDiameter = 4
        Me.GroupPerfilesAcceso.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPerfilesAcceso.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPerfilesAcceso.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPerfilesAcceso.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPerfilesAcceso.TabIndex = 130
        Me.GroupPerfilesAcceso.Tag = ""
        Me.GroupPerfilesAcceso.Text = "Perfiles de Acceso"
        '
        'txtIdperfil
        '
        '
        '
        '
        Me.txtIdperfil.Border.Class = "TextBoxBorder"
        Me.txtIdperfil.Location = New System.Drawing.Point(145, 7)
        Me.txtIdperfil.Name = "txtIdperfil"
        Me.txtIdperfil.ReadOnly = True
        Me.txtIdperfil.Size = New System.Drawing.Size(53, 21)
        Me.txtIdperfil.TabIndex = 112
        Me.txtIdperfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbPerfilAcceso
        '
        Me.cmbPerfilAcceso.FormattingEnabled = True
        Me.cmbPerfilAcceso.Location = New System.Drawing.Point(203, 7)
        Me.cmbPerfilAcceso.Name = "cmbPerfilAcceso"
        Me.cmbPerfilAcceso.Size = New System.Drawing.Size(278, 21)
        Me.cmbPerfilAcceso.TabIndex = 111
        '
        'txtnom_perf
        '
        '
        '
        '
        Me.txtnom_perf.Border.Class = "TextBoxBorder"
        Me.txtnom_perf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnom_perf.Location = New System.Drawing.Point(145, 33)
        Me.txtnom_perf.Name = "txtnom_perf"
        Me.txtnom_perf.Size = New System.Drawing.Size(336, 20)
        Me.txtnom_perf.TabIndex = 110
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(5, 33)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(134, 20)
        Me.LabelX1.TabIndex = 109
        Me.LabelX1.Text = "Nombre Perfil de Acceso"
        '
        'lblVTotal_cuota
        '
        Me.lblVTotal_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblVTotal_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblVTotal_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblVTotal_cuota.Location = New System.Drawing.Point(5, 7)
        Me.lblVTotal_cuota.Name = "lblVTotal_cuota"
        Me.lblVTotal_cuota.Size = New System.Drawing.Size(134, 20)
        Me.lblVTotal_cuota.TabIndex = 100
        Me.lblVTotal_cuota.Text = "Perfil de Acceso"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(421, 434)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "SALIR"
        '
        'TreeAccesos
        '
        Me.TreeAccesos.BackColor = System.Drawing.Color.MintCream
        Me.TreeAccesos.HideSelection = False
        Me.TreeAccesos.ImageKey = "bullet_square_green.png"
        Me.TreeAccesos.ImageList = Me.ImageList1
        Me.TreeAccesos.Location = New System.Drawing.Point(14, 129)
        Me.TreeAccesos.Name = "TreeAccesos"
        TreeNode1.Name = "NodoTabFunciones"
        TreeNode1.Text = "Tab Funciones"
        TreeNode2.Name = "NodoTabBackup"
        TreeNode2.Text = "Tab Backup"
        TreeNode3.Name = "NodoTabUsuarios"
        TreeNode3.Text = "Tab Usuarios"
        TreeNode4.Name = "NodoTabSincro"
        TreeNode4.Text = "Tab Sincronizacion"
        TreeNode5.Name = "NodoFichasFunciones"
        TreeNode5.Tag = ""
        TreeNode5.Text = "Fichas Funciones"
        TreeNode6.Name = "NodoMenuPacientes"
        TreeNode6.Text = "Menu Pacientes"
        TreeNode7.Name = "NodoMenuDoctores"
        TreeNode7.Text = "Menu Doctores"
        TreeNode8.Name = "NodoMenuUsuarios"
        TreeNode8.Text = "Menu Usuarios"
        TreeNode9.Name = "NodoMenuEntidades"
        TreeNode9.Text = "Menu Entidades"
        TreeNode10.Name = "NodoMenuInformes"
        TreeNode10.Text = "Menu Informes"
        TreeNode11.Name = "NodoMenuAdmon"
        TreeNode11.Text = "Menu Administracion"
        TreeNode12.Name = "NodoMenuCitas"
        TreeNode12.Text = "Menu Citas"
        TreeNode13.Name = "NodoMenuContabilidad"
        TreeNode13.Text = "Menu Contabilidad"
        TreeNode14.Name = "NodoMenuVarios"
        TreeNode14.Text = "Menu Varios"
        TreeNode15.Name = "NodoMenuPrincipal"
        TreeNode15.Text = "Menu Principal"
        TreeNode16.Name = "NodoBotonesSuperiores"
        TreeNode16.Text = "Botones Superiores"
        TreeNode17.Name = "NodoControlScheduler"
        TreeNode17.Text = "Control Scheduler"
        TreeNode18.Name = "NodoBotonesCitas"
        TreeNode18.Text = "Botones Citas"
        TreeNode19.Name = "NodoScheduler"
        TreeNode19.Text = "Scheduler"
        TreeNode20.Name = "NodoFichaPaciente"
        TreeNode20.Text = "Ficha Paciente"
        TreeNode21.Name = "NodoPacientes"
        TreeNode21.Text = "Pacientes"
        TreeNode22.Name = "NodoDoctores"
        TreeNode22.Text = "Doctores"
        TreeNode23.Name = "NodoUsuarios"
        TreeNode23.Text = "Usuarios"
        TreeNode24.Name = "NodoEntidades"
        TreeNode24.Text = "Entidades"
        TreeNode25.Name = "NodoHC"
        TreeNode25.Text = "Historias Clinicas"
        TreeNode26.Name = "NodoProcDiario"
        TreeNode26.Text = "Procedimientos Diarios"
        Me.TreeAccesos.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode15, TreeNode19, TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26})
        Me.TreeAccesos.SelectedImageKey = "arrow_right_blue.png"
        Me.TreeAccesos.Size = New System.Drawing.Size(172, 299)
        Me.TreeAccesos.TabIndex = 89
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "bullet_square_green.png")
        Me.ImageList1.Images.SetKeyName(1, "arrow_right_blue.png")
        Me.ImageList1.Images.SetKeyName(2, "user1.png")
        Me.ImageList1.Images.SetKeyName(3, "clock_run.png")
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(319, 434)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 39)
        Me.btnEliminar.TabIndex = 30
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'lblNivelesAcceso
        '
        Me.lblNivelesAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNivelesAcceso.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivelesAcceso.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNivelesAcceso.Location = New System.Drawing.Point(13, 14)
        Me.lblNivelesAcceso.Name = "lblNivelesAcceso"
        Me.lblNivelesAcceso.Size = New System.Drawing.Size(504, 23)
        Me.lblNivelesAcceso.TabIndex = 86
        Me.lblNivelesAcceso.Text = "NIVELES DE ACCESO"
        Me.lblNivelesAcceso.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(14, 434)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnAdicionar.TabIndex = 27
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'ErrorProviderPerfil
        '
        Me.ErrorProviderPerfil.ContainerControl = Me
        '
        'frmNivelesAccesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNivelesAccesos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Nivel Accesos"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.TabAccesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAccesos.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel23.ResumeLayout(False)
        Me.TabControlPanel8.ResumeLayout(False)
        Me.TabControlPanel7.ResumeLayout(False)
        Me.TabControlPanel6.ResumeLayout(False)
        Me.TabControlPanel5.ResumeLayout(False)
        Me.TabControlPanel22.ResumeLayout(False)
        Me.TabControlPanel9.ResumeLayout(False)
        Me.TabControlPanel21.ResumeLayout(False)
        Me.TabControlPanel20.ResumeLayout(False)
        Me.TabControlPanel19.ResumeLayout(False)
        Me.TabControlPanel10.ResumeLayout(False)
        Me.TabControlPanel18.ResumeLayout(False)
        Me.TabControlPanel17.ResumeLayout(False)
        Me.TabControlPanel16.ResumeLayout(False)
        Me.TabControlPanel15.ResumeLayout(False)
        Me.TabControlPanel14.ResumeLayout(False)
        Me.TabControlPanel13.ResumeLayout(False)
        Me.TabControlPanel12.ResumeLayout(False)
        Me.TabControlPanel11.ResumeLayout(False)
        Me.TabControlPanel4.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPerfilesAcceso.ResumeLayout(False)
        CType(Me.ErrorProviderPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblNivelesAcceso As DevComponents.DotNetBar.LabelX
    Friend WithEvents TreeAccesos As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupPerfilesAcceso As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblVTotal_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabAccesos As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabFunciones As DevComponents.DotNetBar.TabItem
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chk_TabFunciones_TodasCitas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmbPerfilAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents txtnom_perf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chk_TabFunciones_CitasFuturas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_CitasDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_CitasSinAsistir As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_CumpleSem As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_CumpleHoy As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_CumpleMes As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_Infogral As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_EnviarMenCall As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_BlqPaciente As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_EnviarMenEmail As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_PacientesBq As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_BlqDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabBackup As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabCambioUsu_Cambio As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabCambioUsuarios As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabBackup_Restaurar As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabBackup_Copia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabSincro_Sincro As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabSincro As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabPacientes As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabPac_APac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabPac_MPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabPac_BPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabPac_NPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel6 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabDoctores As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel7 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabUsuario As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabDoc_NDoc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabDoc_BDoc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabDoc_MDoc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabDoc_ADoc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel8 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabEnt_NEnt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabEnt_BEnt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabEnt_MEnt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabEnt_AEnt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabEntidades As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabUsu_NUsu As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabUsu_BUsu As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabUsu_MUsu As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabUsu_AUsu As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel9 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabFicha_EmailPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_BPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_EPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabFicha As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel11 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabMenuPacientes As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabMnuPac_BPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuPac_NPac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuPac_Pac As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel12 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabMnuDoc_BDoc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuDoc_NDoc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuDoc_Doc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabMenuDoctores As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel13 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabMnuUsu_BUsu As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuUsu_NUsu As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuUsu_Usu As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabMenuUsuarios As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel14 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabMenuEntidades As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabMnuEnt_BEnt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuEnt_NEnt As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuEnt_Ent As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel16 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabMnuAdm_Audito As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuAdm_Aut As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuAdm_Adm As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabMenuAdmon As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel15 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabMnuInf_ProcD As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuInf_InfV As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuInf_Inf As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabMenuInformes As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel17 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabMenuCitas As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabMnuAdm_Import As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuAdm_Config As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuAdm_Acceso As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuCitas_Reminder As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuCitas_Citas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel18 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabMnuConta_RCaja As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuConta_Conta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabMenuContab As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabMnuConta_Presupuesto As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel21 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabCitas_ACita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabCitas As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel20 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabSch_Control As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabScheduler As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel19 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents chk_TabSchSup_Cambio As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabSchedulerSup As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabCitas_ICita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_ECita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_MCita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_TConsul As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_NotaCita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_CitaAsis As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_CitaCanc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_CambioDoc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabCitas_RangoCita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_SplitAgenda As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabSch_SplittCitas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtIdperfil As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ErrorProviderPerfil As System.Windows.Forms.ErrorProvider
    Friend WithEvents chk_TabFunciones_Calculadora As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_EnviarMenSMS As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFunciones_InfoAsignadoDia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabSincro_Actualizacion As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabSincro_SoporteRemoto As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuEnt_BProv As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuEnt_NProv As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuInf_Documentos As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuCitas_BloquearCitas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuConta_CEgreso As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuConta_ECuenta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuConta_Vprocedimiento As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuConta_Gastos As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuConta_MDiario As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents TabControlPanel10 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabMenuVarios As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_TabMnuVarios_Ilustraciones As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabMnuVarios As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chk_TabSincro_Cirugia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControlPanel22 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabHC As DevComponents.DotNetBar.TabItem
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chk_TabSchSup_BuscaHuellas As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX34 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX35 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chk_TabFicha_ProcDiario As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_SMS As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_Odontograma As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_EstadoCuenta As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_Estudios As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabFicha_HC As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX37 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX38 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX39 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX40 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX41 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX42 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX43 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX44 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX45 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chk_TabHC_Nuevag As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabHC_Desblg As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabHC_Modificarg As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_TabHC_Adicionarg As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX46 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControlPanel23 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents LabelX48 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX47 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabProcDiario As DevComponents.DotNetBar.TabItem
    Friend WithEvents chk_Tabproc_NProc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_Tabproc_BProc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_Tabproc_MProc As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chk_Tabproc_AProc As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
