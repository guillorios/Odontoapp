<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresupuesto))
        Me.RibbonPresupuesto = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.TabPresupuesto = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.lblCuotas = New DevComponents.DotNetBar.LabelX
        Me.lblPresupuestoPaciente = New DevComponents.DotNetBar.LabelX
        Me.dgCuotasPresupuestos = New System.Windows.Forms.DataGridView
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.dgPresupuestos = New System.Windows.Forms.DataGridView
        Me.TabPesupuestos = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.lblIdPres = New DevComponents.DotNetBar.LabelX
        Me.txtIdPres = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.gpEspecialidades = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbEspecialidades = New System.Windows.Forms.ComboBox
        Me.lblNombreEspecialidad = New DevComponents.DotNetBar.LabelX
        Me.cmbDoctores = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblDoctores = New DevComponents.DotNetBar.LabelX
        Me.lblPresupuesto = New DevComponents.DotNetBar.LabelX
        Me.cmbIntervaloCuotas = New System.Windows.Forms.ComboBox
        Me.GroupOtrosConcep_cuota = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbfec_cuota = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New DevComponents.DotNetBar.LabelX
        Me.txtVTotal_cuota = New DevExpress.XtraEditors.CalcEdit
        Me.txtIdprocedimiento1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbItem = New System.Windows.Forms.ComboBox
        Me.lblVTotal_cuota = New DevComponents.DotNetBar.LabelX
        Me.btnOtrosConceptos = New DevComponents.DotNetBar.ButtonX
        Me.lblConcepto_cuota = New DevComponents.DotNetBar.LabelX
        Me.lblIntervalocuotas = New DevComponents.DotNetBar.LabelX
        Me.txtVTotalPresupuesto = New DevExpress.XtraEditors.TextEdit
        Me.gpCInicial_pre = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtTCuotas_cuota = New DevExpress.XtraEditors.TextEdit
        Me.txtVCuotas_cuota = New DevExpress.XtraEditors.TextEdit
        Me.txtNCuotasIni_cuota = New DevExpress.XtraEditors.TextEdit
        Me.txtNCuotas_cuota = New DevExpress.XtraEditors.TextEdit
        Me.txtTCuotasIni_cuota = New DevExpress.XtraEditors.TextEdit
        Me.lblTotalCuotas_cuota = New DevComponents.DotNetBar.LabelX
        Me.lblCMen = New DevComponents.DotNetBar.LabelX
        Me.lblValorCuota_cuota = New DevComponents.DotNetBar.LabelX
        Me.txtVCuotasIni_cuota = New DevExpress.XtraEditors.TextEdit
        Me.lblNCuotas_cuota = New DevComponents.DotNetBar.LabelX
        Me.lblCIni3_pre = New DevComponents.DotNetBar.LabelX
        Me.lblCIni2_pre = New DevComponents.DotNetBar.LabelX
        Me.lblCIni = New DevComponents.DotNetBar.LabelX
        Me.lblNCuotasIni_cuota = New DevComponents.DotNetBar.LabelX
        Me.lblVTotalPresupuesto = New DevComponents.DotNetBar.LabelX
        Me.dgCuotas = New System.Windows.Forms.DataGridView
        Me.TabOrtodoncia = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpItems_cuentas = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbfecha_ad = New System.Windows.Forms.DateTimePicker
        Me.lblFechaCotizacion = New DevComponents.DotNetBar.LabelX
        Me.txtreferencia_proc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.txtvalor_proc = New DevExpress.XtraEditors.TextEdit
        Me.btnIngresar_Item = New DevComponents.DotNetBar.ButtonX
        Me.cmbItemCotiza = New System.Windows.Forms.ComboBox
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.txtIdprocedimiento = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX
        Me.dgCotizaciones = New System.Windows.Forms.DataGridView
        Me.lblCotizaciones = New DevComponents.DotNetBar.LabelX
        Me.TabCotizaciones = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.TabEspecilidades = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ErrorProviderpac = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonPresupuesto.SuspendLayout()
        CType(Me.TabPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPresupuesto.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.dgCuotasPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpEspecialidades.SuspendLayout()
        Me.GroupOtrosConcep_cuota.SuspendLayout()
        CType(Me.txtVTotal_cuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVTotalPresupuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpCInicial_pre.SuspendLayout()
        CType(Me.txtTCuotas_cuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVCuotas_cuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCuotasIni_cuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCuotas_cuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTCuotasIni_cuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVCuotasIni_cuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel4.SuspendLayout()
        Me.gpItems_cuentas.SuspendLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderpac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPresupuesto
        '
        Me.RibbonPresupuesto.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonPresupuesto.Controls.Add(Me.btnNuevo)
        Me.RibbonPresupuesto.Controls.Add(Me.TabPresupuesto)
        Me.RibbonPresupuesto.Controls.Add(Me.btnImprimir)
        Me.RibbonPresupuesto.Controls.Add(Me.btnSalir)
        Me.RibbonPresupuesto.Controls.Add(Me.btnAdicionar)
        Me.RibbonPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPresupuesto.Name = "RibbonPresupuesto"
        Me.RibbonPresupuesto.Size = New System.Drawing.Size(532, 486)
        '
        '
        '
        Me.RibbonPresupuesto.Style.Class = "RibbonClientPanel"
        Me.RibbonPresupuesto.TabIndex = 0
        Me.RibbonPresupuesto.Text = "RibbonClientPanel1"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(113, 448)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 29)
        Me.btnNuevo.TabIndex = 143
        Me.btnNuevo.Text = "NUEVO"
        '
        'TabPresupuesto
        '
        Me.TabPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.TabPresupuesto.CanReorderTabs = True
        Me.TabPresupuesto.Controls.Add(Me.TabControlPanel1)
        Me.TabPresupuesto.Controls.Add(Me.TabControlPanel4)
        Me.TabPresupuesto.Controls.Add(Me.TabControlPanel3)
        Me.TabPresupuesto.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPresupuesto.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabPresupuesto.Location = New System.Drawing.Point(0, 0)
        Me.TabPresupuesto.Name = "TabPresupuesto"
        Me.TabPresupuesto.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabPresupuesto.SelectedTabIndex = 0
        Me.TabPresupuesto.Size = New System.Drawing.Size(532, 440)
        Me.TabPresupuesto.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabPresupuesto.TabIndex = 142
        Me.TabPresupuesto.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineWithNavigationBox
        Me.TabPresupuesto.Tabs.Add(Me.TabOrtodoncia)
        Me.TabPresupuesto.Tabs.Add(Me.TabPesupuestos)
        Me.TabPresupuesto.Tabs.Add(Me.TabCotizaciones)
        Me.TabPresupuesto.Text = "TabControl"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.btnModificar)
        Me.TabControlPanel3.Controls.Add(Me.lblCuotas)
        Me.TabControlPanel3.Controls.Add(Me.lblPresupuestoPaciente)
        Me.TabControlPanel3.Controls.Add(Me.dgCuotasPresupuestos)
        Me.TabControlPanel3.Controls.Add(Me.btnEliminar)
        Me.TabControlPanel3.Controls.Add(Me.dgPresupuestos)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(532, 418)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabPesupuestos
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(316, 385)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 29)
        Me.btnModificar.TabIndex = 150
        Me.btnModificar.Text = "MODIFICAR"
        '
        'lblCuotas
        '
        Me.lblCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCuotas.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCuotas.Location = New System.Drawing.Point(12, 194)
        Me.lblCuotas.Name = "lblCuotas"
        Me.lblCuotas.Size = New System.Drawing.Size(505, 23)
        Me.lblCuotas.TabIndex = 149
        Me.lblCuotas.Text = "CUOTAS"
        Me.lblCuotas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblPresupuestoPaciente
        '
        Me.lblPresupuestoPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPresupuestoPaciente.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresupuestoPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPresupuestoPaciente.Location = New System.Drawing.Point(12, 11)
        Me.lblPresupuestoPaciente.Name = "lblPresupuestoPaciente"
        Me.lblPresupuestoPaciente.Size = New System.Drawing.Size(509, 23)
        Me.lblPresupuestoPaciente.TabIndex = 118
        Me.lblPresupuestoPaciente.Text = "PRESUPUESTOS PACIENTE"
        Me.lblPresupuestoPaciente.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgCuotasPresupuestos
        '
        Me.dgCuotasPresupuestos.AllowUserToAddRows = False
        Me.dgCuotasPresupuestos.AllowUserToDeleteRows = False
        Me.dgCuotasPresupuestos.AllowUserToOrderColumns = True
        Me.dgCuotasPresupuestos.AllowUserToResizeColumns = False
        Me.dgCuotasPresupuestos.AllowUserToResizeRows = False
        Me.dgCuotasPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCuotasPresupuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCuotasPresupuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCuotasPresupuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgCuotasPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuotasPresupuestos.EnableHeadersVisualStyles = False
        Me.dgCuotasPresupuestos.Location = New System.Drawing.Point(10, 224)
        Me.dgCuotasPresupuestos.MultiSelect = False
        Me.dgCuotasPresupuestos.Name = "dgCuotasPresupuestos"
        Me.dgCuotasPresupuestos.ReadOnly = True
        Me.dgCuotasPresupuestos.RowHeadersVisible = False
        Me.dgCuotasPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuotasPresupuestos.Size = New System.Drawing.Size(504, 158)
        Me.dgCuotasPresupuestos.TabIndex = 148
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(418, 385)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 29)
        Me.btnEliminar.TabIndex = 126
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'dgPresupuestos
        '
        Me.dgPresupuestos.AllowUserToAddRows = False
        Me.dgPresupuestos.AllowUserToDeleteRows = False
        Me.dgPresupuestos.AllowUserToOrderColumns = True
        Me.dgPresupuestos.AllowUserToResizeColumns = False
        Me.dgPresupuestos.AllowUserToResizeRows = False
        Me.dgPresupuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPresupuestos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPresupuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgPresupuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPresupuestos.EnableHeadersVisualStyles = False
        Me.dgPresupuestos.Location = New System.Drawing.Point(12, 40)
        Me.dgPresupuestos.MultiSelect = False
        Me.dgPresupuestos.Name = "dgPresupuestos"
        Me.dgPresupuestos.ReadOnly = True
        Me.dgPresupuestos.RowHeadersVisible = False
        Me.dgPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPresupuestos.Size = New System.Drawing.Size(504, 149)
        Me.dgPresupuestos.TabIndex = 147
        '
        'TabPesupuestos
        '
        Me.TabPesupuestos.AttachedControl = Me.TabControlPanel3
        Me.TabPesupuestos.Name = "TabPesupuestos"
        Me.TabPesupuestos.Text = "Presupuestos"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.lblIdPres)
        Me.TabControlPanel1.Controls.Add(Me.txtIdPres)
        Me.TabControlPanel1.Controls.Add(Me.gpEspecialidades)
        Me.TabControlPanel1.Controls.Add(Me.cmbDoctores)
        Me.TabControlPanel1.Controls.Add(Me.lblDoctores)
        Me.TabControlPanel1.Controls.Add(Me.lblPresupuesto)
        Me.TabControlPanel1.Controls.Add(Me.cmbIntervaloCuotas)
        Me.TabControlPanel1.Controls.Add(Me.GroupOtrosConcep_cuota)
        Me.TabControlPanel1.Controls.Add(Me.lblIntervalocuotas)
        Me.TabControlPanel1.Controls.Add(Me.txtVTotalPresupuesto)
        Me.TabControlPanel1.Controls.Add(Me.gpCInicial_pre)
        Me.TabControlPanel1.Controls.Add(Me.lblVTotalPresupuesto)
        Me.TabControlPanel1.Controls.Add(Me.dgCuotas)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 418)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabOrtodoncia
        '
        'lblIdPres
        '
        Me.lblIdPres.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIdPres.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblIdPres.ForeColor = System.Drawing.Color.Navy
        Me.lblIdPres.Location = New System.Drawing.Point(14, 392)
        Me.lblIdPres.Name = "lblIdPres"
        Me.lblIdPres.Size = New System.Drawing.Size(44, 20)
        Me.lblIdPres.TabIndex = 148
        Me.lblIdPres.Text = "Id Pres."
        '
        'txtIdPres
        '
        '
        '
        '
        Me.txtIdPres.Border.Class = "TextBoxBorder"
        Me.txtIdPres.Location = New System.Drawing.Point(59, 392)
        Me.txtIdPres.Name = "txtIdPres"
        Me.txtIdPres.ReadOnly = True
        Me.txtIdPres.Size = New System.Drawing.Size(66, 20)
        Me.txtIdPres.TabIndex = 147
        '
        'gpEspecialidades
        '
        Me.gpEspecialidades.BackColor = System.Drawing.Color.Transparent
        Me.gpEspecialidades.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEspecialidades.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEspecialidades.Controls.Add(Me.cmbEspecialidades)
        Me.gpEspecialidades.Controls.Add(Me.lblNombreEspecialidad)
        Me.gpEspecialidades.Location = New System.Drawing.Point(13, 31)
        Me.gpEspecialidades.Name = "gpEspecialidades"
        Me.gpEspecialidades.Size = New System.Drawing.Size(507, 29)
        '
        '
        '
        Me.gpEspecialidades.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpEspecialidades.Style.BackColorGradientAngle = 90
        Me.gpEspecialidades.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpEspecialidades.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderBottomWidth = 1
        Me.gpEspecialidades.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEspecialidades.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderLeftWidth = 1
        Me.gpEspecialidades.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderRightWidth = 1
        Me.gpEspecialidades.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderTopWidth = 1
        Me.gpEspecialidades.Style.CornerDiameter = 4
        Me.gpEspecialidades.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEspecialidades.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEspecialidades.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpEspecialidades.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpEspecialidades.TabIndex = 144
        Me.gpEspecialidades.Tag = ""
        '
        'cmbEspecialidades
        '
        Me.cmbEspecialidades.FormattingEnabled = True
        Me.cmbEspecialidades.Location = New System.Drawing.Point(145, 0)
        Me.cmbEspecialidades.Name = "cmbEspecialidades"
        Me.cmbEspecialidades.Size = New System.Drawing.Size(345, 21)
        Me.cmbEspecialidades.TabIndex = 141
        '
        'lblNombreEspecialidad
        '
        Me.lblNombreEspecialidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNombreEspecialidad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNombreEspecialidad.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEspecialidad.Location = New System.Drawing.Point(5, 1)
        Me.lblNombreEspecialidad.Name = "lblNombreEspecialidad"
        Me.lblNombreEspecialidad.Size = New System.Drawing.Size(134, 20)
        Me.lblNombreEspecialidad.TabIndex = 100
        Me.lblNombreEspecialidad.Text = "Nombre Especialidad"
        '
        'cmbDoctores
        '
        Me.cmbDoctores.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.cmbDoctores.DisplayMember = "Text"
        Me.cmbDoctores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctores.FormattingEnabled = True
        Me.cmbDoctores.ItemHeight = 12
        Me.cmbDoctores.Location = New System.Drawing.Point(70, 197)
        Me.cmbDoctores.Name = "cmbDoctores"
        Me.cmbDoctores.Size = New System.Drawing.Size(447, 18)
        Me.cmbDoctores.TabIndex = 142
        '
        'lblDoctores
        '
        Me.lblDoctores.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDoctores.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblDoctores.ForeColor = System.Drawing.Color.Navy
        Me.lblDoctores.Location = New System.Drawing.Point(15, 196)
        Me.lblDoctores.Name = "lblDoctores"
        Me.lblDoctores.Size = New System.Drawing.Size(48, 20)
        Me.lblDoctores.TabIndex = 117
        Me.lblDoctores.Text = "Doctor"
        '
        'lblPresupuesto
        '
        Me.lblPresupuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPresupuesto.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresupuesto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPresupuesto.Location = New System.Drawing.Point(10, 4)
        Me.lblPresupuesto.Name = "lblPresupuesto"
        Me.lblPresupuesto.Size = New System.Drawing.Size(509, 23)
        Me.lblPresupuesto.TabIndex = 84
        Me.lblPresupuesto.Text = "PRESUPUESTOS"
        Me.lblPresupuesto.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbIntervaloCuotas
        '
        Me.cmbIntervaloCuotas.FormattingEnabled = True
        Me.cmbIntervaloCuotas.Items.AddRange(New Object() {"CADA 15 DIAS", "CADA 20 DIAS", "CADA MES"})
        Me.cmbIntervaloCuotas.Location = New System.Drawing.Point(187, 392)
        Me.cmbIntervaloCuotas.Name = "cmbIntervaloCuotas"
        Me.cmbIntervaloCuotas.Size = New System.Drawing.Size(91, 21)
        Me.cmbIntervaloCuotas.TabIndex = 140
        '
        'GroupOtrosConcep_cuota
        '
        Me.GroupOtrosConcep_cuota.BackColor = System.Drawing.Color.Transparent
        Me.GroupOtrosConcep_cuota.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupOtrosConcep_cuota.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.cmbfec_cuota)
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.lblFecha)
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.txtVTotal_cuota)
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.txtIdprocedimiento1)
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.cmbItem)
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.lblVTotal_cuota)
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.btnOtrosConceptos)
        Me.GroupOtrosConcep_cuota.Controls.Add(Me.lblConcepto_cuota)
        Me.GroupOtrosConcep_cuota.Location = New System.Drawing.Point(13, 62)
        Me.GroupOtrosConcep_cuota.Name = "GroupOtrosConcep_cuota"
        Me.GroupOtrosConcep_cuota.Size = New System.Drawing.Size(507, 74)
        '
        '
        '
        Me.GroupOtrosConcep_cuota.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupOtrosConcep_cuota.Style.BackColorGradientAngle = 90
        Me.GroupOtrosConcep_cuota.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupOtrosConcep_cuota.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupOtrosConcep_cuota.Style.BorderBottomWidth = 1
        Me.GroupOtrosConcep_cuota.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupOtrosConcep_cuota.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupOtrosConcep_cuota.Style.BorderLeftWidth = 1
        Me.GroupOtrosConcep_cuota.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupOtrosConcep_cuota.Style.BorderRightWidth = 1
        Me.GroupOtrosConcep_cuota.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupOtrosConcep_cuota.Style.BorderTopWidth = 1
        Me.GroupOtrosConcep_cuota.Style.CornerDiameter = 4
        Me.GroupOtrosConcep_cuota.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupOtrosConcep_cuota.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupOtrosConcep_cuota.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupOtrosConcep_cuota.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupOtrosConcep_cuota.TabIndex = 141
        Me.GroupOtrosConcep_cuota.Tag = ""
        Me.GroupOtrosConcep_cuota.Text = "Procedimientos"
        '
        'cmbfec_cuota
        '
        Me.cmbfec_cuota.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfec_cuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfec_cuota.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfec_cuota.Location = New System.Drawing.Point(316, 28)
        Me.cmbfec_cuota.Name = "cmbfec_cuota"
        Me.cmbfec_cuota.Size = New System.Drawing.Size(99, 21)
        Me.cmbfec_cuota.TabIndex = 106
        Me.cmbfec_cuota.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFecha.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblFecha.ForeColor = System.Drawing.Color.Navy
        Me.lblFecha.Location = New System.Drawing.Point(242, 28)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(72, 20)
        Me.lblFecha.TabIndex = 107
        Me.lblFecha.Text = "Fecha Inicio"
        Me.lblFecha.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtVTotal_cuota
        '
        Me.txtVTotal_cuota.Location = New System.Drawing.Point(107, 28)
        Me.txtVTotal_cuota.Name = "txtVTotal_cuota"
        Me.txtVTotal_cuota.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtVTotal_cuota.Properties.Mask.EditMask = "c0"
        Me.txtVTotal_cuota.Size = New System.Drawing.Size(130, 20)
        Me.txtVTotal_cuota.TabIndex = 108
        '
        'txtIdprocedimiento1
        '
        '
        '
        '
        Me.txtIdprocedimiento1.Border.Class = "TextBoxBorder"
        Me.txtIdprocedimiento1.Location = New System.Drawing.Point(64, 5)
        Me.txtIdprocedimiento1.Name = "txtIdprocedimiento1"
        Me.txtIdprocedimiento1.ReadOnly = True
        Me.txtIdprocedimiento1.Size = New System.Drawing.Size(41, 20)
        Me.txtIdprocedimiento1.TabIndex = 142
        '
        'cmbItem
        '
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(107, 4)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(310, 21)
        Me.cmbItem.TabIndex = 140
        '
        'lblVTotal_cuota
        '
        Me.lblVTotal_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblVTotal_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblVTotal_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblVTotal_cuota.Location = New System.Drawing.Point(4, 28)
        Me.lblVTotal_cuota.Name = "lblVTotal_cuota"
        Me.lblVTotal_cuota.Size = New System.Drawing.Size(101, 20)
        Me.lblVTotal_cuota.TabIndex = 100
        Me.lblVTotal_cuota.Text = "Valor Presupuesto"
        '
        'btnOtrosConceptos
        '
        Me.btnOtrosConceptos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOtrosConceptos.Enabled = False
        Me.btnOtrosConceptos.Image = CType(resources.GetObject("btnOtrosConceptos.Image"), System.Drawing.Image)
        Me.btnOtrosConceptos.Location = New System.Drawing.Point(423, 5)
        Me.btnOtrosConceptos.Name = "btnOtrosConceptos"
        Me.btnOtrosConceptos.Size = New System.Drawing.Size(72, 45)
        Me.btnOtrosConceptos.TabIndex = 113
        Me.btnOtrosConceptos.Text = "Ingresar"
        '
        'lblConcepto_cuota
        '
        Me.lblConcepto_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConcepto_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblConcepto_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblConcepto_cuota.Location = New System.Drawing.Point(6, 4)
        Me.lblConcepto_cuota.Name = "lblConcepto_cuota"
        Me.lblConcepto_cuota.Size = New System.Drawing.Size(56, 20)
        Me.lblConcepto_cuota.TabIndex = 100
        Me.lblConcepto_cuota.Text = "Concepto"
        '
        'lblIntervalocuotas
        '
        Me.lblIntervalocuotas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIntervalocuotas.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblIntervalocuotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntervalocuotas.ForeColor = System.Drawing.Color.Navy
        Me.lblIntervalocuotas.Location = New System.Drawing.Point(127, 392)
        Me.lblIntervalocuotas.Name = "lblIntervalocuotas"
        Me.lblIntervalocuotas.Size = New System.Drawing.Size(54, 20)
        Me.lblIntervalocuotas.TabIndex = 130
        Me.lblIntervalocuotas.Text = "Intervalo"
        Me.lblIntervalocuotas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtVTotalPresupuesto
        '
        Me.txtVTotalPresupuesto.EditValue = "0"
        Me.txtVTotalPresupuesto.Location = New System.Drawing.Point(386, 393)
        Me.txtVTotalPresupuesto.Name = "txtVTotalPresupuesto"
        Me.txtVTotalPresupuesto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtVTotalPresupuesto.Properties.Appearance.Options.UseFont = True
        Me.txtVTotalPresupuesto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVTotalPresupuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtVTotalPresupuesto.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVTotalPresupuesto.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVTotalPresupuesto.Properties.Mask.BeepOnError = True
        Me.txtVTotalPresupuesto.Properties.Mask.EditMask = "c0"
        Me.txtVTotalPresupuesto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVTotalPresupuesto.Properties.Mask.ShowPlaceHolders = False
        Me.txtVTotalPresupuesto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVTotalPresupuesto.Properties.ReadOnly = True
        Me.txtVTotalPresupuesto.Size = New System.Drawing.Size(133, 21)
        Me.txtVTotalPresupuesto.TabIndex = 128
        '
        'gpCInicial_pre
        '
        Me.gpCInicial_pre.BackColor = System.Drawing.Color.Transparent
        Me.gpCInicial_pre.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpCInicial_pre.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpCInicial_pre.Controls.Add(Me.txtTCuotas_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.txtVCuotas_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.txtNCuotasIni_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.txtNCuotas_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.txtTCuotasIni_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.lblTotalCuotas_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.lblCMen)
        Me.gpCInicial_pre.Controls.Add(Me.lblValorCuota_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.txtVCuotasIni_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.lblNCuotas_cuota)
        Me.gpCInicial_pre.Controls.Add(Me.lblCIni3_pre)
        Me.gpCInicial_pre.Controls.Add(Me.lblCIni2_pre)
        Me.gpCInicial_pre.Controls.Add(Me.lblCIni)
        Me.gpCInicial_pre.Controls.Add(Me.lblNCuotasIni_cuota)
        Me.gpCInicial_pre.Location = New System.Drawing.Point(13, 139)
        Me.gpCInicial_pre.Name = "gpCInicial_pre"
        Me.gpCInicial_pre.Size = New System.Drawing.Size(506, 53)
        '
        '
        '
        Me.gpCInicial_pre.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpCInicial_pre.Style.BackColorGradientAngle = 90
        Me.gpCInicial_pre.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpCInicial_pre.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCInicial_pre.Style.BorderBottomWidth = 1
        Me.gpCInicial_pre.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpCInicial_pre.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCInicial_pre.Style.BorderLeftWidth = 1
        Me.gpCInicial_pre.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCInicial_pre.Style.BorderRightWidth = 1
        Me.gpCInicial_pre.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCInicial_pre.Style.BorderTopWidth = 1
        Me.gpCInicial_pre.Style.CornerDiameter = 4
        Me.gpCInicial_pre.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpCInicial_pre.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpCInicial_pre.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpCInicial_pre.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpCInicial_pre.TabIndex = 117
        Me.gpCInicial_pre.Tag = ""
        '
        'txtTCuotas_cuota
        '
        Me.txtTCuotas_cuota.EditValue = "0"
        Me.txtTCuotas_cuota.Location = New System.Drawing.Point(390, 25)
        Me.txtTCuotas_cuota.Name = "txtTCuotas_cuota"
        Me.txtTCuotas_cuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTCuotas_cuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTCuotas_cuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTCuotas_cuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTCuotas_cuota.Properties.Mask.BeepOnError = True
        Me.txtTCuotas_cuota.Properties.Mask.EditMask = "c0"
        Me.txtTCuotas_cuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTCuotas_cuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtTCuotas_cuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTCuotas_cuota.Properties.ReadOnly = True
        Me.txtTCuotas_cuota.Size = New System.Drawing.Size(107, 20)
        Me.txtTCuotas_cuota.TabIndex = 115
        '
        'txtVCuotas_cuota
        '
        Me.txtVCuotas_cuota.EditValue = "0"
        Me.txtVCuotas_cuota.Location = New System.Drawing.Point(243, 25)
        Me.txtVCuotas_cuota.Name = "txtVCuotas_cuota"
        Me.txtVCuotas_cuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVCuotas_cuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVCuotas_cuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVCuotas_cuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVCuotas_cuota.Properties.Mask.BeepOnError = True
        Me.txtVCuotas_cuota.Properties.Mask.EditMask = "c0"
        Me.txtVCuotas_cuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVCuotas_cuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtVCuotas_cuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVCuotas_cuota.Properties.ReadOnly = True
        Me.txtVCuotas_cuota.Size = New System.Drawing.Size(106, 20)
        Me.txtVCuotas_cuota.TabIndex = 114
        '
        'txtNCuotasIni_cuota
        '
        Me.txtNCuotasIni_cuota.EditValue = "01"
        Me.txtNCuotasIni_cuota.Location = New System.Drawing.Point(167, 2)
        Me.txtNCuotasIni_cuota.Name = "txtNCuotasIni_cuota"
        Me.txtNCuotasIni_cuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNCuotasIni_cuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNCuotasIni_cuota.Properties.DisplayFormat.FormatString = "d2"
        Me.txtNCuotasIni_cuota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNCuotasIni_cuota.Properties.EditFormat.FormatString = "d2"
        Me.txtNCuotasIni_cuota.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNCuotasIni_cuota.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtNCuotasIni_cuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNCuotasIni_cuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNCuotasIni_cuota.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.txtNCuotasIni_cuota.Properties.Mask.BeepOnError = True
        Me.txtNCuotasIni_cuota.Properties.Mask.EditMask = "(1?[1-5])"
        Me.txtNCuotasIni_cuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNCuotasIni_cuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtNCuotasIni_cuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNCuotasIni_cuota.Size = New System.Drawing.Size(26, 20)
        Me.txtNCuotasIni_cuota.TabIndex = 116
        '
        'txtNCuotas_cuota
        '
        Me.txtNCuotas_cuota.EditValue = "0"
        Me.txtNCuotas_cuota.Location = New System.Drawing.Point(167, 25)
        Me.txtNCuotas_cuota.Name = "txtNCuotas_cuota"
        Me.txtNCuotas_cuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNCuotas_cuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtNCuotas_cuota.Properties.DisplayFormat.FormatString = "d2"
        Me.txtNCuotas_cuota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNCuotas_cuota.Properties.EditFormat.FormatString = "d"
        Me.txtNCuotas_cuota.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNCuotas_cuota.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtNCuotas_cuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNCuotas_cuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNCuotas_cuota.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.txtNCuotas_cuota.Properties.Mask.BeepOnError = True
        Me.txtNCuotas_cuota.Properties.Mask.EditMask = "(1?[0-9])|([12345][0-9])"
        Me.txtNCuotas_cuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtNCuotas_cuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtNCuotas_cuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNCuotas_cuota.Size = New System.Drawing.Size(26, 20)
        Me.txtNCuotas_cuota.TabIndex = 113
        '
        'txtTCuotasIni_cuota
        '
        Me.txtTCuotasIni_cuota.EditValue = "0"
        Me.txtTCuotasIni_cuota.Location = New System.Drawing.Point(389, 2)
        Me.txtTCuotasIni_cuota.Name = "txtTCuotasIni_cuota"
        Me.txtTCuotasIni_cuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTCuotasIni_cuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTCuotasIni_cuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTCuotasIni_cuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTCuotasIni_cuota.Properties.Mask.BeepOnError = True
        Me.txtTCuotasIni_cuota.Properties.Mask.EditMask = "c0"
        Me.txtTCuotasIni_cuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTCuotasIni_cuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtTCuotasIni_cuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTCuotasIni_cuota.Properties.ReadOnly = True
        Me.txtTCuotasIni_cuota.Size = New System.Drawing.Size(108, 20)
        Me.txtTCuotasIni_cuota.TabIndex = 111
        '
        'lblTotalCuotas_cuota
        '
        Me.lblTotalCuotas_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotalCuotas_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTotalCuotas_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalCuotas_cuota.Location = New System.Drawing.Point(351, 25)
        Me.lblTotalCuotas_cuota.Name = "lblTotalCuotas_cuota"
        Me.lblTotalCuotas_cuota.Size = New System.Drawing.Size(35, 20)
        Me.lblTotalCuotas_cuota.TabIndex = 112
        Me.lblTotalCuotas_cuota.Text = "Total"
        '
        'lblCMen
        '
        Me.lblCMen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCMen.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCMen.ForeColor = System.Drawing.Color.Navy
        Me.lblCMen.Location = New System.Drawing.Point(3, 26)
        Me.lblCMen.Name = "lblCMen"
        Me.lblCMen.Size = New System.Drawing.Size(88, 20)
        Me.lblCMen.TabIndex = 146
        Me.lblCMen.Text = "C. MENSUALES"
        '
        'lblValorCuota_cuota
        '
        Me.lblValorCuota_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblValorCuota_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblValorCuota_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblValorCuota_cuota.Location = New System.Drawing.Point(194, 25)
        Me.lblValorCuota_cuota.Name = "lblValorCuota_cuota"
        Me.lblValorCuota_cuota.Size = New System.Drawing.Size(47, 20)
        Me.lblValorCuota_cuota.TabIndex = 110
        Me.lblValorCuota_cuota.Text = "V. Cuota"
        '
        'txtVCuotasIni_cuota
        '
        Me.txtVCuotasIni_cuota.EditValue = "0"
        Me.txtVCuotasIni_cuota.Location = New System.Drawing.Point(243, 2)
        Me.txtVCuotasIni_cuota.Name = "txtVCuotasIni_cuota"
        Me.txtVCuotasIni_cuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtVCuotasIni_cuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtVCuotasIni_cuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVCuotasIni_cuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVCuotasIni_cuota.Properties.Mask.BeepOnError = True
        Me.txtVCuotasIni_cuota.Properties.Mask.EditMask = "c0"
        Me.txtVCuotasIni_cuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVCuotasIni_cuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtVCuotasIni_cuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVCuotasIni_cuota.Size = New System.Drawing.Size(106, 20)
        Me.txtVCuotasIni_cuota.TabIndex = 110
        '
        'lblNCuotas_cuota
        '
        Me.lblNCuotas_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNCuotas_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNCuotas_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblNCuotas_cuota.Location = New System.Drawing.Point(103, 25)
        Me.lblNCuotas_cuota.Name = "lblNCuotas_cuota"
        Me.lblNCuotas_cuota.Size = New System.Drawing.Size(62, 20)
        Me.lblNCuotas_cuota.TabIndex = 100
        Me.lblNCuotas_cuota.Text = "No. Cuotas"
        '
        'lblCIni3_pre
        '
        Me.lblCIni3_pre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCIni3_pre.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCIni3_pre.ForeColor = System.Drawing.Color.Navy
        Me.lblCIni3_pre.Location = New System.Drawing.Point(351, 2)
        Me.lblCIni3_pre.Name = "lblCIni3_pre"
        Me.lblCIni3_pre.Size = New System.Drawing.Size(35, 20)
        Me.lblCIni3_pre.TabIndex = 108
        Me.lblCIni3_pre.Text = "Total"
        '
        'lblCIni2_pre
        '
        Me.lblCIni2_pre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCIni2_pre.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCIni2_pre.ForeColor = System.Drawing.Color.Navy
        Me.lblCIni2_pre.Location = New System.Drawing.Point(194, 2)
        Me.lblCIni2_pre.Name = "lblCIni2_pre"
        Me.lblCIni2_pre.Size = New System.Drawing.Size(47, 20)
        Me.lblCIni2_pre.TabIndex = 106
        Me.lblCIni2_pre.Text = "V. Cuota"
        '
        'lblCIni
        '
        Me.lblCIni.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCIni.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCIni.ForeColor = System.Drawing.Color.Navy
        Me.lblCIni.Location = New System.Drawing.Point(3, 3)
        Me.lblCIni.Name = "lblCIni"
        Me.lblCIni.Size = New System.Drawing.Size(88, 20)
        Me.lblCIni.TabIndex = 145
        Me.lblCIni.Text = "C. INICIALES"
        '
        'lblNCuotasIni_cuota
        '
        Me.lblNCuotasIni_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNCuotasIni_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNCuotasIni_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblNCuotasIni_cuota.Location = New System.Drawing.Point(104, 2)
        Me.lblNCuotasIni_cuota.Name = "lblNCuotasIni_cuota"
        Me.lblNCuotasIni_cuota.Size = New System.Drawing.Size(61, 20)
        Me.lblNCuotasIni_cuota.TabIndex = 100
        Me.lblNCuotasIni_cuota.Text = "No. Cuotas"
        '
        'lblVTotalPresupuesto
        '
        Me.lblVTotalPresupuesto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblVTotalPresupuesto.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblVTotalPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVTotalPresupuesto.ForeColor = System.Drawing.Color.Navy
        Me.lblVTotalPresupuesto.Location = New System.Drawing.Point(285, 393)
        Me.lblVTotalPresupuesto.Name = "lblVTotalPresupuesto"
        Me.lblVTotalPresupuesto.Size = New System.Drawing.Size(97, 20)
        Me.lblVTotalPresupuesto.TabIndex = 127
        Me.lblVTotalPresupuesto.Text = "V.T Presupuesto"
        Me.lblVTotalPresupuesto.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgCuotas
        '
        Me.dgCuotas.AllowUserToDeleteRows = False
        Me.dgCuotas.AllowUserToOrderColumns = True
        Me.dgCuotas.AllowUserToResizeColumns = False
        Me.dgCuotas.AllowUserToResizeRows = False
        Me.dgCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCuotas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCuotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuotas.EnableHeadersVisualStyles = False
        Me.dgCuotas.Location = New System.Drawing.Point(14, 221)
        Me.dgCuotas.Name = "dgCuotas"
        Me.dgCuotas.RowHeadersVisible = False
        Me.dgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuotas.Size = New System.Drawing.Size(503, 168)
        Me.dgCuotas.TabIndex = 120
        '
        'TabOrtodoncia
        '
        Me.TabOrtodoncia.AttachedControl = Me.TabControlPanel1
        Me.TabOrtodoncia.Name = "TabOrtodoncia"
        Me.TabOrtodoncia.Text = "Crear Presupuestos"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.gpItems_cuentas)
        Me.TabControlPanel4.Controls.Add(Me.dgCotizaciones)
        Me.TabControlPanel4.Controls.Add(Me.lblCotizaciones)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(532, 418)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabCotizaciones
        '
        'gpItems_cuentas
        '
        Me.gpItems_cuentas.BackColor = System.Drawing.Color.Transparent
        Me.gpItems_cuentas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpItems_cuentas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpItems_cuentas.Controls.Add(Me.cmbfecha_ad)
        Me.gpItems_cuentas.Controls.Add(Me.lblFechaCotizacion)
        Me.gpItems_cuentas.Controls.Add(Me.txtreferencia_proc)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX18)
        Me.gpItems_cuentas.Controls.Add(Me.txtCantidad)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX19)
        Me.gpItems_cuentas.Controls.Add(Me.txtTotal)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX20)
        Me.gpItems_cuentas.Controls.Add(Me.txtvalor_proc)
        Me.gpItems_cuentas.Controls.Add(Me.btnIngresar_Item)
        Me.gpItems_cuentas.Controls.Add(Me.cmbItemCotiza)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX21)
        Me.gpItems_cuentas.Controls.Add(Me.txtIdprocedimiento)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX22)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX23)
        Me.gpItems_cuentas.Location = New System.Drawing.Point(11, 37)
        Me.gpItems_cuentas.Name = "gpItems_cuentas"
        Me.gpItems_cuentas.Size = New System.Drawing.Size(505, 110)
        '
        '
        '
        Me.gpItems_cuentas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpItems_cuentas.Style.BackColorGradientAngle = 90
        Me.gpItems_cuentas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpItems_cuentas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_cuentas.Style.BorderBottomWidth = 1
        Me.gpItems_cuentas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpItems_cuentas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_cuentas.Style.BorderLeftWidth = 1
        Me.gpItems_cuentas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_cuentas.Style.BorderRightWidth = 1
        Me.gpItems_cuentas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_cuentas.Style.BorderTopWidth = 1
        Me.gpItems_cuentas.Style.CornerDiameter = 4
        Me.gpItems_cuentas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpItems_cuentas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpItems_cuentas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpItems_cuentas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpItems_cuentas.TabIndex = 164
        Me.gpItems_cuentas.Text = "Items"
        '
        'cmbfecha_ad
        '
        Me.cmbfecha_ad.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_ad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecha_ad.Location = New System.Drawing.Point(352, 55)
        Me.cmbfecha_ad.Name = "cmbfecha_ad"
        Me.cmbfecha_ad.Size = New System.Drawing.Size(132, 23)
        Me.cmbfecha_ad.TabIndex = 182
        Me.cmbfecha_ad.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblFechaCotizacion
        '
        Me.lblFechaCotizacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFechaCotizacion.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblFechaCotizacion.ForeColor = System.Drawing.Color.Navy
        Me.lblFechaCotizacion.Location = New System.Drawing.Point(352, 32)
        Me.lblFechaCotizacion.Name = "lblFechaCotizacion"
        Me.lblFechaCotizacion.Size = New System.Drawing.Size(131, 20)
        Me.lblFechaCotizacion.TabIndex = 181
        Me.lblFechaCotizacion.Text = "Fecha"
        Me.lblFechaCotizacion.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtreferencia_proc
        '
        '
        '
        '
        Me.txtreferencia_proc.Border.Class = "TextBoxBorder"
        Me.txtreferencia_proc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferencia_proc.Location = New System.Drawing.Point(352, 6)
        Me.txtreferencia_proc.Name = "txtreferencia_proc"
        Me.txtreferencia_proc.ReadOnly = True
        Me.txtreferencia_proc.Size = New System.Drawing.Size(131, 20)
        Me.txtreferencia_proc.TabIndex = 180
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX18.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(293, 6)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(58, 20)
        Me.LabelX18.TabIndex = 179
        Me.LabelX18.Text = "Referencia"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCantidad
        '
        Me.txtCantidad.EditValue = "1"
        Me.txtCantidad.Location = New System.Drawing.Point(59, 57)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCantidad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtCantidad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtCantidad.Properties.Mask.BeepOnError = True
        Me.txtCantidad.Properties.Mask.EditMask = "n0"
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Properties.Mask.ShowPlaceHolders = False
        Me.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Size = New System.Drawing.Size(32, 21)
        Me.txtCantidad.TabIndex = 178
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX19.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX19.ForeColor = System.Drawing.Color.Navy
        Me.LabelX19.Location = New System.Drawing.Point(12, 58)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(41, 20)
        Me.LabelX19.TabIndex = 177
        Me.LabelX19.Text = "Cant."
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Location = New System.Drawing.Point(129, 58)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotal.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotal.Properties.Mask.BeepOnError = True
        Me.txtTotal.Properties.Mask.EditMask = "c0"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(109, 21)
        Me.txtTotal.TabIndex = 176
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX20.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX20.ForeColor = System.Drawing.Color.Navy
        Me.LabelX20.Location = New System.Drawing.Point(93, 58)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(30, 20)
        Me.LabelX20.TabIndex = 175
        Me.LabelX20.Text = "Total"
        Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtvalor_proc
        '
        Me.txtvalor_proc.EditValue = "0"
        Me.txtvalor_proc.Location = New System.Drawing.Point(156, 31)
        Me.txtvalor_proc.Name = "txtvalor_proc"
        Me.txtvalor_proc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtvalor_proc.Properties.Appearance.Options.UseFont = True
        Me.txtvalor_proc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtvalor_proc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtvalor_proc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtvalor_proc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtvalor_proc.Properties.Mask.BeepOnError = True
        Me.txtvalor_proc.Properties.Mask.EditMask = "c0"
        Me.txtvalor_proc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtvalor_proc.Properties.Mask.ShowPlaceHolders = False
        Me.txtvalor_proc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtvalor_proc.Size = New System.Drawing.Size(83, 21)
        Me.txtvalor_proc.TabIndex = 174
        '
        'btnIngresar_Item
        '
        Me.btnIngresar_Item.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIngresar_Item.Image = CType(resources.GetObject("btnIngresar_Item.Image"), System.Drawing.Image)
        Me.btnIngresar_Item.Location = New System.Drawing.Point(269, 32)
        Me.btnIngresar_Item.Name = "btnIngresar_Item"
        Me.btnIngresar_Item.Size = New System.Drawing.Size(49, 46)
        Me.btnIngresar_Item.TabIndex = 173
        '
        'cmbItemCotiza
        '
        Me.cmbItemCotiza.FormattingEnabled = True
        Me.cmbItemCotiza.Location = New System.Drawing.Point(59, 6)
        Me.cmbItemCotiza.Name = "cmbItemCotiza"
        Me.cmbItemCotiza.Size = New System.Drawing.Size(228, 21)
        Me.cmbItemCotiza.TabIndex = 139
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX21.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX21.ForeColor = System.Drawing.Color.Navy
        Me.LabelX21.Location = New System.Drawing.Point(12, 32)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(41, 20)
        Me.LabelX21.TabIndex = 134
        Me.LabelX21.Text = "Codigo"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdprocedimiento
        '
        '
        '
        '
        Me.txtIdprocedimiento.Border.Class = "TextBoxBorder"
        Me.txtIdprocedimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdprocedimiento.Location = New System.Drawing.Point(59, 32)
        Me.txtIdprocedimiento.Name = "txtIdprocedimiento"
        Me.txtIdprocedimiento.ReadOnly = True
        Me.txtIdprocedimiento.Size = New System.Drawing.Size(62, 20)
        Me.txtIdprocedimiento.TabIndex = 133
        Me.txtIdprocedimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX22.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX22.ForeColor = System.Drawing.Color.Navy
        Me.LabelX22.Location = New System.Drawing.Point(12, 7)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(42, 20)
        Me.LabelX22.TabIndex = 136
        Me.LabelX22.Text = "Item"
        Me.LabelX22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX23
        '
        Me.LabelX23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX23.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX23.ForeColor = System.Drawing.Color.Navy
        Me.LabelX23.Location = New System.Drawing.Point(123, 32)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(30, 20)
        Me.LabelX23.TabIndex = 138
        Me.LabelX23.Text = "Valor"
        Me.LabelX23.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgCotizaciones
        '
        Me.dgCotizaciones.AllowUserToDeleteRows = False
        Me.dgCotizaciones.AllowUserToOrderColumns = True
        Me.dgCotizaciones.AllowUserToResizeColumns = False
        Me.dgCotizaciones.AllowUserToResizeRows = False
        Me.dgCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCotizaciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCotizaciones.EnableHeadersVisualStyles = False
        Me.dgCotizaciones.Location = New System.Drawing.Point(12, 153)
        Me.dgCotizaciones.Name = "dgCotizaciones"
        Me.dgCotizaciones.RowHeadersVisible = False
        Me.dgCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCotizaciones.Size = New System.Drawing.Size(504, 249)
        Me.dgCotizaciones.TabIndex = 163
        '
        'lblCotizaciones
        '
        Me.lblCotizaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCotizaciones.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCotizaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCotizaciones.Location = New System.Drawing.Point(12, 8)
        Me.lblCotizaciones.Name = "lblCotizaciones"
        Me.lblCotizaciones.Size = New System.Drawing.Size(509, 23)
        Me.lblCotizaciones.TabIndex = 162
        Me.lblCotizaciones.Text = "COTIZACIONES"
        Me.lblCotizaciones.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabCotizaciones
        '
        Me.TabCotizaciones.AttachedControl = Me.TabControlPanel4
        Me.TabCotizaciones.Name = "TabCotizaciones"
        Me.TabCotizaciones.Text = "Cotizaciones"
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.Enabled = False
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(306, 448)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 29)
        Me.btnImprimir.TabIndex = 129
        Me.btnImprimir.Text = "IMPRIMIR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(421, 447)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 29)
        Me.btnSalir.TabIndex = 125
        Me.btnSalir.Text = "SALIR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(13, 448)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 29)
        Me.btnAdicionar.TabIndex = 121
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'TabEspecilidades
        '
        Me.TabEspecilidades.Name = "TabEspecilidades"
        Me.TabEspecilidades.Text = "Presupuesto Especialidades"
        '
        'ErrorProviderpac
        '
        Me.ErrorProviderpac.ContainerControl = Me
        '
        'frmPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonPresupuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Presupuesto"
        Me.RibbonPresupuesto.ResumeLayout(False)
        CType(Me.TabPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPresupuesto.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.dgCuotasPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.gpEspecialidades.ResumeLayout(False)
        Me.GroupOtrosConcep_cuota.ResumeLayout(False)
        CType(Me.txtVTotal_cuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVTotalPresupuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpCInicial_pre.ResumeLayout(False)
        CType(Me.txtTCuotas_cuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVCuotas_cuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCuotasIni_cuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCuotas_cuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTCuotasIni_cuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVCuotasIni_cuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel4.ResumeLayout(False)
        Me.gpItems_cuentas.ResumeLayout(False)
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderpac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonPresupuesto As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblPresupuesto As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblValorCuota_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNCuotas_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpCInicial_pre As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblCIni3_pre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCIni2_pre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNCuotasIni_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblVTotal_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotalCuotas_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfec_cuota As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCuotas As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNCuotas_cuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTCuotasIni_cuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVCuotasIni_cuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTCuotas_cuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVCuotas_cuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNCuotasIni_cuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtVTotalPresupuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblVTotalPresupuesto As DevComponents.DotNetBar.LabelX
    Friend WithEvents ErrorProviderpac As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblIntervalocuotas As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbIntervaloCuotas As System.Windows.Forms.ComboBox
    Friend WithEvents txtVTotal_cuota As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents GroupOtrosConcep_cuota As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnOtrosConceptos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblConcepto_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdprocedimiento1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TabPresupuesto As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabOrtodoncia As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabEspecilidades As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabPesupuestos As DevComponents.DotNetBar.TabItem
    Friend WithEvents lblDoctores As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbDoctores As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabCotizaciones As DevComponents.DotNetBar.TabItem
    Friend WithEvents gpItems_cuentas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbfecha_ad As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaCotizacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtreferencia_proc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtvalor_proc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnIngresar_Item As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbItemCotiza As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdprocedimiento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCotizaciones As System.Windows.Forms.DataGridView
    Friend WithEvents lblCotizaciones As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCuotas As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPresupuestoPaciente As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCuotasPresupuestos As System.Windows.Forms.DataGridView
    Friend WithEvents dgPresupuestos As System.Windows.Forms.DataGridView
    Friend WithEvents gpEspecialidades As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbEspecialidades As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreEspecialidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCMen As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCIni As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblIdPres As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdPres As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
End Class
