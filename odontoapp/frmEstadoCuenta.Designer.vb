<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoCuenta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.TabControlCuentas = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpPresupuestos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbPresupuestos = New System.Windows.Forms.ComboBox
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.btnBorrarItem = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevaCuentaAdicional = New DevComponents.DotNetBar.ButtonX
        Me.btnCrearCuentaAdicional = New DevComponents.DotNetBar.ButtonX
        Me.txtTotal_Cuenta_ad = New DevExpress.XtraEditors.TextEdit
        Me.lblTotal_Cuenta_ad = New DevComponents.DotNetBar.LabelX
        Me.dgCrearCuentaAd = New System.Windows.Forms.DataGridView
        Me.lblCrearCuentaAd = New DevComponents.DotNetBar.LabelX
        Me.gpItems_cuentas = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbEspecialidades = New System.Windows.Forms.ComboBox
        Me.lblNombreEspecialidad = New DevComponents.DotNetBar.LabelX
        Me.cmbItem = New System.Windows.Forms.ComboBox
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.txtNCuentaAd = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbfecha_ad = New System.Windows.Forms.DateTimePicker
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtreferencia_proc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.txtvalor_proc = New DevExpress.XtraEditors.TextEdit
        Me.btnIngresar_Item = New DevComponents.DotNetBar.ButtonX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtIdprocedimiento = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.TabCrearCuentaAdicional = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.gpTipoInforme = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rbEvolucion1 = New System.Windows.Forms.RadioButton
        Me.lblTotalPagos = New DevComponents.DotNetBar.LabelX
        Me.txtTotalPagos = New DevExpress.XtraEditors.TextEdit
        Me.lblDetalle = New DevComponents.DotNetBar.LabelX
        Me.lblMaestro = New DevComponents.DotNetBar.LabelX
        Me.dgDetalleRcaja = New System.Windows.Forms.DataGridView
        Me.dgMaestroRcaja = New System.Windows.Forms.DataGridView
        Me.lblResumenPagos = New DevComponents.DotNetBar.LabelX
        Me.TabResumenPagos = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnBorrarCuentaAdicional = New DevComponents.DotNetBar.ButtonX
        Me.btnPagoCuentaAd = New DevComponents.DotNetBar.ButtonX
        Me.lblValorCuota_ad = New DevComponents.DotNetBar.LabelX
        Me.txtValorCuota_ad = New DevExpress.XtraEditors.TextEdit
        Me.lblAbonoCuota_ad = New DevComponents.DotNetBar.LabelX
        Me.txtAbonoCuota_ad = New DevExpress.XtraEditors.TextEdit
        Me.txtSaldoCuota_ad = New DevExpress.XtraEditors.TextEdit
        Me.txtNomCuota_ad = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblSaldoCuota_ad = New DevComponents.DotNetBar.LabelX
        Me.txtCodigoCuota_ad = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblNomCuota_ad = New DevComponents.DotNetBar.LabelX
        Me.lblCodigoCuota_ad = New DevComponents.DotNetBar.LabelX
        Me.lblPagoCuota_ad = New DevComponents.DotNetBar.LabelX
        Me.txtPagoCuota_ad = New DevExpress.XtraEditors.TextEdit
        Me.dgCuentasadicionales = New System.Windows.Forms.DataGridView
        Me.lblCuentasAdicionales = New DevComponents.DotNetBar.LabelX
        Me.TabCuentasAdicionales = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel
        Me.lblResumenCuentas = New DevComponents.DotNetBar.LabelX
        Me.gpEstadoCuenta = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtTotalPresupuesto = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalAbonos = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalSaldo = New DevExpress.XtraEditors.TextEdit
        Me.lblCIni3_pre = New DevComponents.DotNetBar.LabelX
        Me.lblCIni2_pre = New DevComponents.DotNetBar.LabelX
        Me.lblNCuotasIni_cuota = New DevComponents.DotNetBar.LabelX
        Me.gpTotalCuotas = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtNcuotas_deuda = New DevExpress.XtraEditors.TextEdit
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.txtNcuotas = New DevExpress.XtraEditors.TextEdit
        Me.txtNcuotas_pagadas = New DevExpress.XtraEditors.TextEdit
        Me.txtNcuotas_Saldo = New DevExpress.XtraEditors.TextEdit
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.gpTotalTratamiento = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtTotalTratamiento = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalTratamientoAbonos = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalTratamientoSaldo = New DevExpress.XtraEditors.TextEdit
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX
        Me.gpTotalCuentasAd = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtNcuotas_deuda_ad = New DevExpress.XtraEditors.TextEdit
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.txtNcuotas_ad = New DevExpress.XtraEditors.TextEdit
        Me.txtNcuotas_pagadas_ad = New DevExpress.XtraEditors.TextEdit
        Me.txtNcuotas_Saldo_ad = New DevExpress.XtraEditors.TextEdit
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX
        Me.gpEstadoCuentasAd = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtTotalAdicionales = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalAbonos_ad = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalSaldo_ad = New DevExpress.XtraEditors.TextEdit
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.tabResumenCuenta = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.chkdescuento = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.gpDescuentos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtPorcDesc = New DevExpress.XtraEditors.TextEdit
        Me.txtValorDesc = New DevExpress.XtraEditors.TextEdit
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.dgCuotas = New System.Windows.Forms.DataGridView
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.lblValorCuota = New DevComponents.DotNetBar.LabelX
        Me.txtValorCuota = New DevExpress.XtraEditors.TextEdit
        Me.lblAbonoCuota = New DevComponents.DotNetBar.LabelX
        Me.txtAbonoCuota = New DevExpress.XtraEditors.TextEdit
        Me.txtSaldoCuota = New DevExpress.XtraEditors.TextEdit
        Me.txtNomCuota = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblSaldoCuota = New DevComponents.DotNetBar.LabelX
        Me.txtCodigoCuota = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblNomCuota = New DevComponents.DotNetBar.LabelX
        Me.lblCodigoCuota = New DevComponents.DotNetBar.LabelX
        Me.btnPagarCuota = New DevComponents.DotNetBar.ButtonX
        Me.lblPagoCuota = New DevComponents.DotNetBar.LabelX
        Me.txtPagoCuota = New DevExpress.XtraEditors.TextEdit
        Me.TabEstadoCuentas = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.SuperTooltip = New DevComponents.DotNetBar.SuperTooltip
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.TabControlCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlCuentas.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.gpPresupuestos.SuspendLayout()
        CType(Me.txtTotal_Cuenta_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCrearCuentaAd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpItems_cuentas.SuspendLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel4.SuspendLayout()
        Me.gpTipoInforme.SuspendLayout()
        CType(Me.txtTotalPagos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleRcaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMaestroRcaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.txtValorCuota_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoCuota_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoCuota_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPagoCuota_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuentasadicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel5.SuspendLayout()
        Me.gpEstadoCuenta.SuspendLayout()
        CType(Me.txtTotalPresupuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAbonos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpTotalCuotas.SuspendLayout()
        CType(Me.txtNcuotas_deuda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcuotas_pagadas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcuotas_Saldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpTotalTratamiento.SuspendLayout()
        CType(Me.txtTotalTratamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalTratamientoAbonos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalTratamientoSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpTotalCuentasAd.SuspendLayout()
        CType(Me.txtNcuotas_deuda_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcuotas_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcuotas_pagadas_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcuotas_Saldo_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpEstadoCuentasAd.SuspendLayout()
        CType(Me.txtTotalAdicionales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAbonos_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalSaldo_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpDescuentos.SuspendLayout()
        CType(Me.txtPorcDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorCuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbonoCuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaldoCuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPagoCuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.TabControlCuentas)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
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
        'TabControlCuentas
        '
        Me.TabControlCuentas.CanReorderTabs = False
        Me.TabControlCuentas.Controls.Add(Me.TabControlPanel3)
        Me.TabControlCuentas.Controls.Add(Me.TabControlPanel2)
        Me.TabControlCuentas.Controls.Add(Me.TabControlPanel1)
        Me.TabControlCuentas.Controls.Add(Me.TabControlPanel4)
        Me.TabControlCuentas.Controls.Add(Me.TabControlPanel5)
        Me.TabControlCuentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControlCuentas.Location = New System.Drawing.Point(0, 0)
        Me.TabControlCuentas.Name = "TabControlCuentas"
        Me.TabControlCuentas.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControlCuentas.SelectedTabIndex = 0
        Me.TabControlCuentas.Size = New System.Drawing.Size(532, 442)
        Me.TabControlCuentas.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControlCuentas.TabIndex = 110
        Me.TabControlCuentas.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControlCuentas.Tabs.Add(Me.TabEstadoCuentas)
        Me.TabControlCuentas.Tabs.Add(Me.TabCuentasAdicionales)
        Me.TabControlCuentas.Tabs.Add(Me.TabCrearCuentaAdicional)
        Me.TabControlCuentas.Tabs.Add(Me.TabResumenPagos)
        Me.TabControlCuentas.Tabs.Add(Me.tabResumenCuenta)
        Me.TabControlCuentas.Text = "TabControl"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.gpPresupuestos)
        Me.TabControlPanel3.Controls.Add(Me.btnBorrarItem)
        Me.TabControlPanel3.Controls.Add(Me.btnNuevaCuentaAdicional)
        Me.TabControlPanel3.Controls.Add(Me.btnCrearCuentaAdicional)
        Me.TabControlPanel3.Controls.Add(Me.txtTotal_Cuenta_ad)
        Me.TabControlPanel3.Controls.Add(Me.lblTotal_Cuenta_ad)
        Me.TabControlPanel3.Controls.Add(Me.dgCrearCuentaAd)
        Me.TabControlPanel3.Controls.Add(Me.lblCrearCuentaAd)
        Me.TabControlPanel3.Controls.Add(Me.gpItems_cuentas)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(532, 417)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabCrearCuentaAdicional
        '
        'gpPresupuestos
        '
        Me.gpPresupuestos.BackColor = System.Drawing.Color.Transparent
        Me.gpPresupuestos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPresupuestos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPresupuestos.Controls.Add(Me.cmbPresupuestos)
        Me.gpPresupuestos.Controls.Add(Me.LabelX14)
        Me.gpPresupuestos.Location = New System.Drawing.Point(11, 338)
        Me.gpPresupuestos.Name = "gpPresupuestos"
        Me.gpPresupuestos.Size = New System.Drawing.Size(507, 30)
        '
        '
        '
        Me.gpPresupuestos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpPresupuestos.Style.BackColorGradientAngle = 90
        Me.gpPresupuestos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpPresupuestos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPresupuestos.Style.BorderBottomWidth = 1
        Me.gpPresupuestos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpPresupuestos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPresupuestos.Style.BorderLeftWidth = 1
        Me.gpPresupuestos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPresupuestos.Style.BorderRightWidth = 1
        Me.gpPresupuestos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPresupuestos.Style.BorderTopWidth = 1
        Me.gpPresupuestos.Style.CornerDiameter = 4
        Me.gpPresupuestos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpPresupuestos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpPresupuestos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpPresupuestos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpPresupuestos.TabIndex = 182
        Me.gpPresupuestos.Tag = ""
        '
        'cmbPresupuestos
        '
        Me.cmbPresupuestos.FormattingEnabled = True
        Me.cmbPresupuestos.Location = New System.Drawing.Point(145, 2)
        Me.cmbPresupuestos.Name = "cmbPresupuestos"
        Me.cmbPresupuestos.Size = New System.Drawing.Size(345, 21)
        Me.cmbPresupuestos.TabIndex = 141
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX14.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX14.ForeColor = System.Drawing.Color.Navy
        Me.LabelX14.Location = New System.Drawing.Point(5, 2)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(134, 20)
        Me.LabelX14.TabIndex = 100
        Me.LabelX14.Text = "Nombre Presupuesto"
        '
        'btnBorrarItem
        '
        Me.btnBorrarItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarItem.Enabled = False
        Me.btnBorrarItem.Image = CType(resources.GetObject("btnBorrarItem.Image"), System.Drawing.Image)
        Me.btnBorrarItem.Location = New System.Drawing.Point(486, 373)
        Me.btnBorrarItem.Name = "btnBorrarItem"
        Me.btnBorrarItem.Size = New System.Drawing.Size(33, 33)
        Me.btnBorrarItem.TabIndex = 180
        '
        'btnNuevaCuentaAdicional
        '
        Me.btnNuevaCuentaAdicional.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevaCuentaAdicional.Image = CType(resources.GetObject("btnNuevaCuentaAdicional.Image"), System.Drawing.Image)
        Me.btnNuevaCuentaAdicional.Location = New System.Drawing.Point(310, 373)
        Me.btnNuevaCuentaAdicional.Name = "btnNuevaCuentaAdicional"
        Me.btnNuevaCuentaAdicional.Size = New System.Drawing.Size(122, 33)
        Me.btnNuevaCuentaAdicional.TabIndex = 165
        Me.btnNuevaCuentaAdicional.Text = "NUEVA CUENTA"
        '
        'btnCrearCuentaAdicional
        '
        Me.btnCrearCuentaAdicional.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCrearCuentaAdicional.Enabled = False
        Me.btnCrearCuentaAdicional.Image = CType(resources.GetObject("btnCrearCuentaAdicional.Image"), System.Drawing.Image)
        Me.btnCrearCuentaAdicional.Location = New System.Drawing.Point(182, 373)
        Me.btnCrearCuentaAdicional.Name = "btnCrearCuentaAdicional"
        Me.btnCrearCuentaAdicional.Size = New System.Drawing.Size(122, 33)
        Me.btnCrearCuentaAdicional.TabIndex = 164
        Me.btnCrearCuentaAdicional.Text = "CREAR CUENTA "
        '
        'txtTotal_Cuenta_ad
        '
        Me.txtTotal_Cuenta_ad.EditValue = "0"
        Me.txtTotal_Cuenta_ad.Location = New System.Drawing.Point(12, 392)
        Me.txtTotal_Cuenta_ad.Name = "txtTotal_Cuenta_ad"
        Me.txtTotal_Cuenta_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal_Cuenta_ad.Properties.Appearance.Options.UseFont = True
        Me.txtTotal_Cuenta_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal_Cuenta_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtTotal_Cuenta_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotal_Cuenta_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotal_Cuenta_ad.Properties.Mask.BeepOnError = True
        Me.txtTotal_Cuenta_ad.Properties.Mask.EditMask = "c0"
        Me.txtTotal_Cuenta_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal_Cuenta_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotal_Cuenta_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal_Cuenta_ad.Properties.ReadOnly = True
        Me.txtTotal_Cuenta_ad.Size = New System.Drawing.Size(148, 21)
        Me.txtTotal_Cuenta_ad.TabIndex = 163
        '
        'lblTotal_Cuenta_ad
        '
        Me.lblTotal_Cuenta_ad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotal_Cuenta_ad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTotal_Cuenta_ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_Cuenta_ad.ForeColor = System.Drawing.Color.Navy
        Me.lblTotal_Cuenta_ad.Location = New System.Drawing.Point(12, 372)
        Me.lblTotal_Cuenta_ad.Name = "lblTotal_Cuenta_ad"
        Me.lblTotal_Cuenta_ad.Size = New System.Drawing.Size(148, 20)
        Me.lblTotal_Cuenta_ad.TabIndex = 162
        Me.lblTotal_Cuenta_ad.Text = "Valor Total Recibo de Caja"
        Me.lblTotal_Cuenta_ad.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgCrearCuentaAd
        '
        Me.dgCrearCuentaAd.AllowUserToAddRows = False
        Me.dgCrearCuentaAd.AllowUserToDeleteRows = False
        Me.dgCrearCuentaAd.AllowUserToResizeColumns = False
        Me.dgCrearCuentaAd.AllowUserToResizeRows = False
        Me.dgCrearCuentaAd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCrearCuentaAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCrearCuentaAd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCrearCuentaAd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCrearCuentaAd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCrearCuentaAd.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCrearCuentaAd.EnableHeadersVisualStyles = False
        Me.dgCrearCuentaAd.Location = New System.Drawing.Point(12, 167)
        Me.dgCrearCuentaAd.MultiSelect = False
        Me.dgCrearCuentaAd.Name = "dgCrearCuentaAd"
        Me.dgCrearCuentaAd.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCrearCuentaAd.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgCrearCuentaAd.RowHeadersVisible = False
        Me.dgCrearCuentaAd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCrearCuentaAd.Size = New System.Drawing.Size(508, 164)
        Me.dgCrearCuentaAd.TabIndex = 161
        '
        'lblCrearCuentaAd
        '
        Me.lblCrearCuentaAd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCrearCuentaAd.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCuentaAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCrearCuentaAd.Location = New System.Drawing.Point(12, 7)
        Me.lblCrearCuentaAd.Name = "lblCrearCuentaAd"
        Me.lblCrearCuentaAd.Size = New System.Drawing.Size(504, 23)
        Me.lblCrearCuentaAd.TabIndex = 96
        Me.lblCrearCuentaAd.Text = "CREAR CUENTA ADICIONAL"
        Me.lblCrearCuentaAd.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpItems_cuentas
        '
        Me.gpItems_cuentas.BackColor = System.Drawing.Color.Transparent
        Me.gpItems_cuentas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpItems_cuentas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpItems_cuentas.Controls.Add(Me.cmbEspecialidades)
        Me.gpItems_cuentas.Controls.Add(Me.lblNombreEspecialidad)
        Me.gpItems_cuentas.Controls.Add(Me.cmbItem)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX11)
        Me.gpItems_cuentas.Controls.Add(Me.txtNCuentaAd)
        Me.gpItems_cuentas.Controls.Add(Me.cmbfecha_ad)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX4)
        Me.gpItems_cuentas.Controls.Add(Me.txtreferencia_proc)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX15)
        Me.gpItems_cuentas.Controls.Add(Me.txtCantidad)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX1)
        Me.gpItems_cuentas.Controls.Add(Me.txtTotal)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX5)
        Me.gpItems_cuentas.Controls.Add(Me.txtvalor_proc)
        Me.gpItems_cuentas.Controls.Add(Me.btnIngresar_Item)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX2)
        Me.gpItems_cuentas.Controls.Add(Me.txtIdprocedimiento)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX3)
        Me.gpItems_cuentas.Controls.Add(Me.LabelX12)
        Me.gpItems_cuentas.Location = New System.Drawing.Point(13, 35)
        Me.gpItems_cuentas.Name = "gpItems_cuentas"
        Me.gpItems_cuentas.Size = New System.Drawing.Size(505, 127)
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
        Me.gpItems_cuentas.TabIndex = 160
        Me.gpItems_cuentas.Text = "Items"
        '
        'cmbEspecialidades
        '
        Me.cmbEspecialidades.Enabled = False
        Me.cmbEspecialidades.FormattingEnabled = True
        Me.cmbEspecialidades.Location = New System.Drawing.Point(152, 2)
        Me.cmbEspecialidades.Name = "cmbEspecialidades"
        Me.cmbEspecialidades.Size = New System.Drawing.Size(340, 21)
        Me.cmbEspecialidades.TabIndex = 186
        '
        'lblNombreEspecialidad
        '
        Me.lblNombreEspecialidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNombreEspecialidad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNombreEspecialidad.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEspecialidad.Location = New System.Drawing.Point(12, 3)
        Me.lblNombreEspecialidad.Name = "lblNombreEspecialidad"
        Me.lblNombreEspecialidad.Size = New System.Drawing.Size(134, 20)
        Me.lblNombreEspecialidad.TabIndex = 185
        Me.lblNombreEspecialidad.Text = "Nombre Especialidad"
        '
        'cmbItem
        '
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(59, 27)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(433, 21)
        Me.cmbItem.TabIndex = 139
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX11.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX11.ForeColor = System.Drawing.Color.Navy
        Me.LabelX11.Location = New System.Drawing.Point(245, 53)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(112, 20)
        Me.LabelX11.TabIndex = 184
        Me.LabelX11.Text = "No. Cuenta Adicional"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtNCuentaAd
        '
        '
        '
        '
        Me.txtNCuentaAd.Border.Class = "TextBoxBorder"
        Me.txtNCuentaAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNCuentaAd.Location = New System.Drawing.Point(363, 53)
        Me.txtNCuentaAd.Name = "txtNCuentaAd"
        Me.txtNCuentaAd.ReadOnly = True
        Me.txtNCuentaAd.Size = New System.Drawing.Size(62, 20)
        Me.txtNCuentaAd.TabIndex = 183
        Me.txtNCuentaAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbfecha_ad
        '
        Me.cmbfecha_ad.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_ad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_ad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecha_ad.Location = New System.Drawing.Point(322, 78)
        Me.cmbfecha_ad.Name = "cmbfecha_ad"
        Me.cmbfecha_ad.Size = New System.Drawing.Size(103, 23)
        Me.cmbfecha_ad.TabIndex = 182
        Me.cmbfecha_ad.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX4.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(246, 81)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(70, 20)
        Me.LabelX4.TabIndex = 181
        Me.LabelX4.Text = "Fecha"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtreferencia_proc
        '
        '
        '
        '
        Me.txtreferencia_proc.Border.Class = "TextBoxBorder"
        Me.txtreferencia_proc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferencia_proc.Location = New System.Drawing.Point(352, 27)
        Me.txtreferencia_proc.Name = "txtreferencia_proc"
        Me.txtreferencia_proc.ReadOnly = True
        Me.txtreferencia_proc.Size = New System.Drawing.Size(131, 20)
        Me.txtreferencia_proc.TabIndex = 180
        Me.txtreferencia_proc.Visible = False
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX15.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX15.ForeColor = System.Drawing.Color.Navy
        Me.LabelX15.Location = New System.Drawing.Point(293, 27)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(58, 20)
        Me.LabelX15.TabIndex = 179
        Me.LabelX15.Text = "Referencia"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        Me.LabelX15.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.EditValue = "1"
        Me.txtCantidad.Location = New System.Drawing.Point(59, 78)
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
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(12, 79)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(41, 20)
        Me.LabelX1.TabIndex = 177
        Me.LabelX1.Text = "Cant."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Location = New System.Drawing.Point(129, 79)
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
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX5.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX5.ForeColor = System.Drawing.Color.Navy
        Me.LabelX5.Location = New System.Drawing.Point(93, 79)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(30, 20)
        Me.LabelX5.TabIndex = 175
        Me.LabelX5.Text = "Total"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtvalor_proc
        '
        Me.txtvalor_proc.EditValue = "0"
        Me.txtvalor_proc.Location = New System.Drawing.Point(156, 52)
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
        Me.btnIngresar_Item.Location = New System.Drawing.Point(434, 54)
        Me.btnIngresar_Item.Name = "btnIngresar_Item"
        Me.btnIngresar_Item.Size = New System.Drawing.Size(49, 46)
        Me.SuperTooltip.SetSuperTooltip(Me.btnIngresar_Item, New DevComponents.DotNetBar.SuperTooltipInfo("Agregar Item", "Odontoapp", "Agregar Item en la Cuenta Adicional", CType(resources.GetObject("btnIngresar_Item.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnIngresar_Item.TabIndex = 173
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(12, 53)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(41, 20)
        Me.LabelX2.TabIndex = 134
        Me.LabelX2.Text = "Codigo"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdprocedimiento
        '
        '
        '
        '
        Me.txtIdprocedimiento.Border.Class = "TextBoxBorder"
        Me.txtIdprocedimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdprocedimiento.Location = New System.Drawing.Point(59, 53)
        Me.txtIdprocedimiento.Name = "txtIdprocedimiento"
        Me.txtIdprocedimiento.ReadOnly = True
        Me.txtIdprocedimiento.Size = New System.Drawing.Size(62, 20)
        Me.txtIdprocedimiento.TabIndex = 133
        Me.txtIdprocedimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(12, 28)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(42, 20)
        Me.LabelX3.TabIndex = 136
        Me.LabelX3.Text = "Item"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX12.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX12.ForeColor = System.Drawing.Color.Navy
        Me.LabelX12.Location = New System.Drawing.Point(123, 53)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(30, 20)
        Me.LabelX12.TabIndex = 138
        Me.LabelX12.Text = "Valor"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabCrearCuentaAdicional
        '
        Me.TabCrearCuentaAdicional.AttachedControl = Me.TabControlPanel3
        Me.TabCrearCuentaAdicional.Image = CType(resources.GetObject("TabCrearCuentaAdicional.Image"), System.Drawing.Image)
        Me.TabCrearCuentaAdicional.Name = "TabCrearCuentaAdicional"
        Me.TabCrearCuentaAdicional.Text = "Crear Cuenta Adicional"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.btnImprimir)
        Me.TabControlPanel4.Controls.Add(Me.gpTipoInforme)
        Me.TabControlPanel4.Controls.Add(Me.lblTotalPagos)
        Me.TabControlPanel4.Controls.Add(Me.txtTotalPagos)
        Me.TabControlPanel4.Controls.Add(Me.lblDetalle)
        Me.TabControlPanel4.Controls.Add(Me.lblMaestro)
        Me.TabControlPanel4.Controls.Add(Me.dgDetalleRcaja)
        Me.TabControlPanel4.Controls.Add(Me.dgMaestroRcaja)
        Me.TabControlPanel4.Controls.Add(Me.lblResumenPagos)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(532, 417)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabResumenPagos
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(422, 374)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 37)
        Me.btnImprimir.TabIndex = 163
        Me.btnImprimir.Text = "IMPRIMIR"
        '
        'gpTipoInforme
        '
        Me.gpTipoInforme.BackColor = System.Drawing.Color.Transparent
        Me.gpTipoInforme.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpTipoInforme.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpTipoInforme.Controls.Add(Me.RadioButton1)
        Me.gpTipoInforme.Controls.Add(Me.rbEvolucion1)
        Me.gpTipoInforme.Location = New System.Drawing.Point(198, 369)
        Me.gpTipoInforme.Name = "gpTipoInforme"
        Me.gpTipoInforme.Size = New System.Drawing.Size(206, 42)
        '
        '
        '
        Me.gpTipoInforme.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpTipoInforme.Style.BackColorGradientAngle = 90
        Me.gpTipoInforme.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpTipoInforme.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTipoInforme.Style.BorderBottomWidth = 1
        Me.gpTipoInforme.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpTipoInforme.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTipoInforme.Style.BorderLeftWidth = 1
        Me.gpTipoInforme.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTipoInforme.Style.BorderRightWidth = 1
        Me.gpTipoInforme.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTipoInforme.Style.BorderTopWidth = 1
        Me.gpTipoInforme.Style.CornerDiameter = 4
        Me.gpTipoInforme.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpTipoInforme.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpTipoInforme.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpTipoInforme.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpTipoInforme.TabIndex = 162
        Me.gpTipoInforme.Tag = ""
        Me.gpTipoInforme.Text = "Tipo Informe"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(101, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(78, 19)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "Detallado"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbEvolucion1
        '
        Me.rbEvolucion1.AutoSize = True
        Me.rbEvolucion1.Checked = True
        Me.rbEvolucion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEvolucion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbEvolucion1.Location = New System.Drawing.Point(16, 3)
        Me.rbEvolucion1.Name = "rbEvolucion1"
        Me.rbEvolucion1.Size = New System.Drawing.Size(79, 19)
        Me.rbEvolucion1.TabIndex = 2
        Me.rbEvolucion1.TabStop = True
        Me.rbEvolucion1.Text = "Resumen"
        Me.rbEvolucion1.UseVisualStyleBackColor = True
        '
        'lblTotalPagos
        '
        Me.lblTotalPagos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotalPagos.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTotalPagos.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalPagos.Location = New System.Drawing.Point(10, 385)
        Me.lblTotalPagos.Name = "lblTotalPagos"
        Me.lblTotalPagos.Size = New System.Drawing.Size(67, 20)
        Me.lblTotalPagos.TabIndex = 160
        Me.lblTotalPagos.Text = "Total Pagos"
        '
        'txtTotalPagos
        '
        Me.txtTotalPagos.EditValue = "0"
        Me.txtTotalPagos.Location = New System.Drawing.Point(83, 384)
        Me.txtTotalPagos.Name = "txtTotalPagos"
        Me.txtTotalPagos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPagos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPagos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalPagos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalPagos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalPagos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalPagos.Properties.Mask.BeepOnError = True
        Me.txtTotalPagos.Properties.Mask.EditMask = "c0"
        Me.txtTotalPagos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalPagos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalPagos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalPagos.Properties.ReadOnly = True
        Me.txtTotalPagos.Size = New System.Drawing.Size(109, 21)
        Me.txtTotalPagos.TabIndex = 161
        '
        'lblDetalle
        '
        Me.lblDetalle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDetalle.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblDetalle.ForeColor = System.Drawing.Color.Navy
        Me.lblDetalle.Location = New System.Drawing.Point(10, 224)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(79, 20)
        Me.lblDetalle.TabIndex = 159
        Me.lblDetalle.Text = "Detalle"
        '
        'lblMaestro
        '
        Me.lblMaestro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblMaestro.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblMaestro.ForeColor = System.Drawing.Color.Navy
        Me.lblMaestro.Location = New System.Drawing.Point(10, 33)
        Me.lblMaestro.Name = "lblMaestro"
        Me.lblMaestro.Size = New System.Drawing.Size(79, 20)
        Me.lblMaestro.TabIndex = 158
        Me.lblMaestro.Text = "Maestro"
        '
        'dgDetalleRcaja
        '
        Me.dgDetalleRcaja.AllowUserToAddRows = False
        Me.dgDetalleRcaja.AllowUserToDeleteRows = False
        Me.dgDetalleRcaja.AllowUserToResizeColumns = False
        Me.dgDetalleRcaja.AllowUserToResizeRows = False
        Me.dgDetalleRcaja.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDetalleRcaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDetalleRcaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalleRcaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgDetalleRcaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDetalleRcaja.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgDetalleRcaja.EnableHeadersVisualStyles = False
        Me.dgDetalleRcaja.Location = New System.Drawing.Point(10, 247)
        Me.dgDetalleRcaja.MultiSelect = False
        Me.dgDetalleRcaja.Name = "dgDetalleRcaja"
        Me.dgDetalleRcaja.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalleRcaja.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgDetalleRcaja.RowHeadersVisible = False
        Me.dgDetalleRcaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetalleRcaja.Size = New System.Drawing.Size(508, 121)
        Me.dgDetalleRcaja.TabIndex = 157
        '
        'dgMaestroRcaja
        '
        Me.dgMaestroRcaja.AllowUserToAddRows = False
        Me.dgMaestroRcaja.AllowUserToDeleteRows = False
        Me.dgMaestroRcaja.AllowUserToResizeColumns = False
        Me.dgMaestroRcaja.AllowUserToResizeRows = False
        Me.dgMaestroRcaja.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgMaestroRcaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgMaestroRcaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMaestroRcaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgMaestroRcaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMaestroRcaja.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgMaestroRcaja.EnableHeadersVisualStyles = False
        Me.dgMaestroRcaja.Location = New System.Drawing.Point(10, 53)
        Me.dgMaestroRcaja.MultiSelect = False
        Me.dgMaestroRcaja.Name = "dgMaestroRcaja"
        Me.dgMaestroRcaja.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMaestroRcaja.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgMaestroRcaja.RowHeadersVisible = False
        Me.dgMaestroRcaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMaestroRcaja.Size = New System.Drawing.Size(508, 168)
        Me.dgMaestroRcaja.TabIndex = 156
        '
        'lblResumenPagos
        '
        Me.lblResumenPagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblResumenPagos.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResumenPagos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResumenPagos.Location = New System.Drawing.Point(12, 7)
        Me.lblResumenPagos.Name = "lblResumenPagos"
        Me.lblResumenPagos.Size = New System.Drawing.Size(504, 23)
        Me.lblResumenPagos.TabIndex = 155
        Me.lblResumenPagos.Text = "RESUMEN DE PAGOS"
        Me.lblResumenPagos.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabResumenPagos
        '
        Me.TabResumenPagos.AttachedControl = Me.TabControlPanel4
        Me.TabResumenPagos.Image = CType(resources.GetObject("TabResumenPagos.Image"), System.Drawing.Image)
        Me.TabResumenPagos.Name = "TabResumenPagos"
        Me.TabResumenPagos.Text = "Resumen de Pagos"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.btnBorrarCuentaAdicional)
        Me.TabControlPanel2.Controls.Add(Me.btnPagoCuentaAd)
        Me.TabControlPanel2.Controls.Add(Me.lblValorCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.txtValorCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.lblAbonoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.txtAbonoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.txtSaldoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.txtNomCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.lblSaldoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.txtCodigoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.lblNomCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.lblCodigoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.lblPagoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.txtPagoCuota_ad)
        Me.TabControlPanel2.Controls.Add(Me.dgCuentasadicionales)
        Me.TabControlPanel2.Controls.Add(Me.lblCuentasAdicionales)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 417)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabCuentasAdicionales
        '
        'btnBorrarCuentaAdicional
        '
        Me.btnBorrarCuentaAdicional.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarCuentaAdicional.Enabled = False
        Me.btnBorrarCuentaAdicional.Image = CType(resources.GetObject("btnBorrarCuentaAdicional.Image"), System.Drawing.Image)
        Me.btnBorrarCuentaAdicional.Location = New System.Drawing.Point(482, 365)
        Me.btnBorrarCuentaAdicional.Name = "btnBorrarCuentaAdicional"
        Me.btnBorrarCuentaAdicional.Size = New System.Drawing.Size(33, 33)
        Me.btnBorrarCuentaAdicional.TabIndex = 181
        '
        'btnPagoCuentaAd
        '
        Me.btnPagoCuentaAd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPagoCuentaAd.Enabled = False
        Me.btnPagoCuentaAd.Image = CType(resources.GetObject("btnPagoCuentaAd.Image"), System.Drawing.Image)
        Me.btnPagoCuentaAd.Location = New System.Drawing.Point(184, 361)
        Me.btnPagoCuentaAd.Name = "btnPagoCuentaAd"
        Me.btnPagoCuentaAd.Size = New System.Drawing.Size(148, 40)
        Me.btnPagoCuentaAd.TabIndex = 96
        Me.btnPagoCuentaAd.Text = "PAGAR CUENTA ADICIONAL"
        '
        'lblValorCuota_ad
        '
        Me.lblValorCuota_ad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblValorCuota_ad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblValorCuota_ad.ForeColor = System.Drawing.Color.Navy
        Me.lblValorCuota_ad.Location = New System.Drawing.Point(12, 334)
        Me.lblValorCuota_ad.Name = "lblValorCuota_ad"
        Me.lblValorCuota_ad.Size = New System.Drawing.Size(41, 20)
        Me.lblValorCuota_ad.TabIndex = 160
        Me.lblValorCuota_ad.Text = "Valor"
        '
        'txtValorCuota_ad
        '
        Me.txtValorCuota_ad.EditValue = "0"
        Me.txtValorCuota_ad.Location = New System.Drawing.Point(59, 333)
        Me.txtValorCuota_ad.Name = "txtValorCuota_ad"
        Me.txtValorCuota_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorCuota_ad.Properties.Appearance.Options.UseFont = True
        Me.txtValorCuota_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorCuota_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorCuota_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtValorCuota_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtValorCuota_ad.Properties.Mask.BeepOnError = True
        Me.txtValorCuota_ad.Properties.Mask.EditMask = "c0"
        Me.txtValorCuota_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorCuota_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtValorCuota_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorCuota_ad.Properties.ReadOnly = True
        Me.txtValorCuota_ad.Size = New System.Drawing.Size(79, 21)
        Me.txtValorCuota_ad.TabIndex = 161
        '
        'lblAbonoCuota_ad
        '
        Me.lblAbonoCuota_ad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAbonoCuota_ad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblAbonoCuota_ad.ForeColor = System.Drawing.Color.Navy
        Me.lblAbonoCuota_ad.Location = New System.Drawing.Point(140, 334)
        Me.lblAbonoCuota_ad.Name = "lblAbonoCuota_ad"
        Me.lblAbonoCuota_ad.Size = New System.Drawing.Size(41, 20)
        Me.lblAbonoCuota_ad.TabIndex = 162
        Me.lblAbonoCuota_ad.Text = "Abono"
        '
        'txtAbonoCuota_ad
        '
        Me.txtAbonoCuota_ad.EditValue = "0"
        Me.txtAbonoCuota_ad.Location = New System.Drawing.Point(186, 334)
        Me.txtAbonoCuota_ad.Name = "txtAbonoCuota_ad"
        Me.txtAbonoCuota_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAbonoCuota_ad.Properties.Appearance.Options.UseFont = True
        Me.txtAbonoCuota_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAbonoCuota_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAbonoCuota_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtAbonoCuota_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtAbonoCuota_ad.Properties.Mask.BeepOnError = True
        Me.txtAbonoCuota_ad.Properties.Mask.EditMask = "c0"
        Me.txtAbonoCuota_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAbonoCuota_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtAbonoCuota_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAbonoCuota_ad.Properties.ReadOnly = True
        Me.txtAbonoCuota_ad.Size = New System.Drawing.Size(88, 21)
        Me.txtAbonoCuota_ad.TabIndex = 163
        '
        'txtSaldoCuota_ad
        '
        Me.txtSaldoCuota_ad.EditValue = "0"
        Me.txtSaldoCuota_ad.Location = New System.Drawing.Point(326, 335)
        Me.txtSaldoCuota_ad.Name = "txtSaldoCuota_ad"
        Me.txtSaldoCuota_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoCuota_ad.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoCuota_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoCuota_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoCuota_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtSaldoCuota_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtSaldoCuota_ad.Properties.Mask.BeepOnError = True
        Me.txtSaldoCuota_ad.Properties.Mask.EditMask = "c0"
        Me.txtSaldoCuota_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoCuota_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtSaldoCuota_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSaldoCuota_ad.Properties.ReadOnly = True
        Me.txtSaldoCuota_ad.Size = New System.Drawing.Size(89, 21)
        Me.txtSaldoCuota_ad.TabIndex = 165
        '
        'txtNomCuota_ad
        '
        '
        '
        '
        Me.txtNomCuota_ad.Border.Class = "TextBoxBorder"
        Me.txtNomCuota_ad.Location = New System.Drawing.Point(186, 308)
        Me.txtNomCuota_ad.Name = "txtNomCuota_ad"
        Me.txtNomCuota_ad.ReadOnly = True
        Me.txtNomCuota_ad.Size = New System.Drawing.Size(229, 20)
        Me.txtNomCuota_ad.TabIndex = 169
        '
        'lblSaldoCuota_ad
        '
        Me.lblSaldoCuota_ad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSaldoCuota_ad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblSaldoCuota_ad.ForeColor = System.Drawing.Color.Navy
        Me.lblSaldoCuota_ad.Location = New System.Drawing.Point(281, 335)
        Me.lblSaldoCuota_ad.Name = "lblSaldoCuota_ad"
        Me.lblSaldoCuota_ad.Size = New System.Drawing.Size(41, 20)
        Me.lblSaldoCuota_ad.TabIndex = 164
        Me.lblSaldoCuota_ad.Text = "Saldo"
        '
        'txtCodigoCuota_ad
        '
        '
        '
        '
        Me.txtCodigoCuota_ad.Border.Class = "TextBoxBorder"
        Me.txtCodigoCuota_ad.Location = New System.Drawing.Point(97, 308)
        Me.txtCodigoCuota_ad.Name = "txtCodigoCuota_ad"
        Me.txtCodigoCuota_ad.ReadOnly = True
        Me.txtCodigoCuota_ad.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigoCuota_ad.TabIndex = 171
        '
        'lblNomCuota_ad
        '
        Me.lblNomCuota_ad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNomCuota_ad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomCuota_ad.ForeColor = System.Drawing.Color.Navy
        Me.lblNomCuota_ad.Location = New System.Drawing.Point(140, 308)
        Me.lblNomCuota_ad.Name = "lblNomCuota_ad"
        Me.lblNomCuota_ad.Size = New System.Drawing.Size(41, 20)
        Me.lblNomCuota_ad.TabIndex = 168
        Me.lblNomCuota_ad.Text = "Detalle"
        '
        'lblCodigoCuota_ad
        '
        Me.lblCodigoCuota_ad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCodigoCuota_ad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCodigoCuota_ad.ForeColor = System.Drawing.Color.Navy
        Me.lblCodigoCuota_ad.Location = New System.Drawing.Point(12, 308)
        Me.lblCodigoCuota_ad.Name = "lblCodigoCuota_ad"
        Me.lblCodigoCuota_ad.Size = New System.Drawing.Size(79, 20)
        Me.lblCodigoCuota_ad.TabIndex = 170
        Me.lblCodigoCuota_ad.Text = "Codigo Cuota"
        '
        'lblPagoCuota_ad
        '
        Me.lblPagoCuota_ad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPagoCuota_ad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblPagoCuota_ad.ForeColor = System.Drawing.Color.Navy
        Me.lblPagoCuota_ad.Location = New System.Drawing.Point(424, 308)
        Me.lblPagoCuota_ad.Name = "lblPagoCuota_ad"
        Me.lblPagoCuota_ad.Size = New System.Drawing.Size(96, 23)
        Me.lblPagoCuota_ad.TabIndex = 166
        Me.lblPagoCuota_ad.Text = "Pago"
        Me.lblPagoCuota_ad.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtPagoCuota_ad
        '
        Me.txtPagoCuota_ad.EditValue = "0"
        Me.txtPagoCuota_ad.Location = New System.Drawing.Point(424, 334)
        Me.txtPagoCuota_ad.Name = "txtPagoCuota_ad"
        Me.txtPagoCuota_ad.Properties.Appearance.BackColor = System.Drawing.Color.Aqua
        Me.txtPagoCuota_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPagoCuota_ad.Properties.Appearance.Options.UseBackColor = True
        Me.txtPagoCuota_ad.Properties.Appearance.Options.UseFont = True
        Me.txtPagoCuota_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPagoCuota_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPagoCuota_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtPagoCuota_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtPagoCuota_ad.Properties.Mask.BeepOnError = True
        Me.txtPagoCuota_ad.Properties.Mask.EditMask = "c0"
        Me.txtPagoCuota_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPagoCuota_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtPagoCuota_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPagoCuota_ad.Size = New System.Drawing.Size(94, 23)
        Me.txtPagoCuota_ad.TabIndex = 167
        '
        'dgCuentasadicionales
        '
        Me.dgCuentasadicionales.AllowUserToAddRows = False
        Me.dgCuentasadicionales.AllowUserToDeleteRows = False
        Me.dgCuentasadicionales.AllowUserToResizeColumns = False
        Me.dgCuentasadicionales.AllowUserToResizeRows = False
        Me.dgCuentasadicionales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCuentasadicionales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCuentasadicionales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuentasadicionales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCuentasadicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuentasadicionales.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgCuentasadicionales.EnableHeadersVisualStyles = False
        Me.dgCuentasadicionales.Location = New System.Drawing.Point(12, 35)
        Me.dgCuentasadicionales.MultiSelect = False
        Me.dgCuentasadicionales.Name = "dgCuentasadicionales"
        Me.dgCuentasadicionales.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuentasadicionales.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgCuentasadicionales.RowHeadersVisible = False
        Me.dgCuentasadicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuentasadicionales.Size = New System.Drawing.Size(504, 269)
        Me.dgCuentasadicionales.TabIndex = 96
        '
        'lblCuentasAdicionales
        '
        Me.lblCuentasAdicionales.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCuentasAdicionales.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuentasAdicionales.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCuentasAdicionales.Location = New System.Drawing.Point(12, 7)
        Me.lblCuentasAdicionales.Name = "lblCuentasAdicionales"
        Me.lblCuentasAdicionales.Size = New System.Drawing.Size(504, 23)
        Me.lblCuentasAdicionales.TabIndex = 95
        Me.lblCuentasAdicionales.Text = "CUENTAS ADICIONALES"
        Me.lblCuentasAdicionales.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabCuentasAdicionales
        '
        Me.TabCuentasAdicionales.AttachedControl = Me.TabControlPanel2
        Me.TabCuentasAdicionales.Image = CType(resources.GetObject("TabCuentasAdicionales.Image"), System.Drawing.Image)
        Me.TabCuentasAdicionales.Name = "TabCuentasAdicionales"
        Me.TabCuentasAdicionales.Text = "Cuentas Adicionales"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Controls.Add(Me.lblResumenCuentas)
        Me.TabControlPanel5.Controls.Add(Me.gpEstadoCuenta)
        Me.TabControlPanel5.Controls.Add(Me.gpTotalCuotas)
        Me.TabControlPanel5.Controls.Add(Me.gpTotalTratamiento)
        Me.TabControlPanel5.Controls.Add(Me.gpTotalCuentasAd)
        Me.TabControlPanel5.Controls.Add(Me.gpEstadoCuentasAd)
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(532, 417)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 5
        Me.TabControlPanel5.TabItem = Me.tabResumenCuenta
        '
        'lblResumenCuentas
        '
        Me.lblResumenCuentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblResumenCuentas.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResumenCuentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResumenCuentas.Location = New System.Drawing.Point(12, 7)
        Me.lblResumenCuentas.Name = "lblResumenCuentas"
        Me.lblResumenCuentas.Size = New System.Drawing.Size(504, 23)
        Me.lblResumenCuentas.TabIndex = 95
        Me.lblResumenCuentas.Text = "RESUMEN DE CUENTAS"
        Me.lblResumenCuentas.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpEstadoCuenta
        '
        Me.gpEstadoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.gpEstadoCuenta.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEstadoCuenta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEstadoCuenta.Controls.Add(Me.txtTotalPresupuesto)
        Me.gpEstadoCuenta.Controls.Add(Me.txtTotalAbonos)
        Me.gpEstadoCuenta.Controls.Add(Me.txtTotalSaldo)
        Me.gpEstadoCuenta.Controls.Add(Me.lblCIni3_pre)
        Me.gpEstadoCuenta.Controls.Add(Me.lblCIni2_pre)
        Me.gpEstadoCuenta.Controls.Add(Me.lblNCuotasIni_cuota)
        Me.gpEstadoCuenta.Location = New System.Drawing.Point(46, 39)
        Me.gpEstadoCuenta.Name = "gpEstadoCuenta"
        Me.gpEstadoCuenta.Size = New System.Drawing.Size(207, 112)
        '
        '
        '
        Me.gpEstadoCuenta.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpEstadoCuenta.Style.BackColorGradientAngle = 90
        Me.gpEstadoCuenta.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpEstadoCuenta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderBottomWidth = 1
        Me.gpEstadoCuenta.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEstadoCuenta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderLeftWidth = 1
        Me.gpEstadoCuenta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderRightWidth = 1
        Me.gpEstadoCuenta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderTopWidth = 1
        Me.gpEstadoCuenta.Style.CornerDiameter = 4
        Me.gpEstadoCuenta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEstadoCuenta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEstadoCuenta.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpEstadoCuenta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpEstadoCuenta.TabIndex = 117
        Me.gpEstadoCuenta.Tag = ""
        Me.gpEstadoCuenta.Text = "Estado Cuenta"
        '
        'txtTotalPresupuesto
        '
        Me.txtTotalPresupuesto.EditValue = "0"
        Me.txtTotalPresupuesto.Location = New System.Drawing.Point(105, 13)
        Me.txtTotalPresupuesto.Name = "txtTotalPresupuesto"
        Me.txtTotalPresupuesto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPresupuesto.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPresupuesto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalPresupuesto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalPresupuesto.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalPresupuesto.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalPresupuesto.Properties.Mask.BeepOnError = True
        Me.txtTotalPresupuesto.Properties.Mask.EditMask = "c0"
        Me.txtTotalPresupuesto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalPresupuesto.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalPresupuesto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalPresupuesto.Properties.ReadOnly = True
        Me.txtTotalPresupuesto.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalPresupuesto.TabIndex = 1
        '
        'txtTotalAbonos
        '
        Me.txtTotalAbonos.EditValue = "0"
        Me.txtTotalAbonos.Location = New System.Drawing.Point(105, 35)
        Me.txtTotalAbonos.Name = "txtTotalAbonos"
        Me.txtTotalAbonos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAbonos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalAbonos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalAbonos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalAbonos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalAbonos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalAbonos.Properties.Mask.BeepOnError = True
        Me.txtTotalAbonos.Properties.Mask.EditMask = "c0"
        Me.txtTotalAbonos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalAbonos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalAbonos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalAbonos.Properties.ReadOnly = True
        Me.txtTotalAbonos.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalAbonos.TabIndex = 3
        '
        'txtTotalSaldo
        '
        Me.txtTotalSaldo.EditValue = "0"
        Me.txtTotalSaldo.Location = New System.Drawing.Point(105, 57)
        Me.txtTotalSaldo.Name = "txtTotalSaldo"
        Me.txtTotalSaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalSaldo.Properties.Appearance.Options.UseFont = True
        Me.txtTotalSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalSaldo.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalSaldo.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalSaldo.Properties.Mask.BeepOnError = True
        Me.txtTotalSaldo.Properties.Mask.EditMask = "c0"
        Me.txtTotalSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalSaldo.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalSaldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalSaldo.Properties.ReadOnly = True
        Me.txtTotalSaldo.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalSaldo.TabIndex = 5
        '
        'lblCIni3_pre
        '
        Me.lblCIni3_pre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCIni3_pre.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCIni3_pre.ForeColor = System.Drawing.Color.Navy
        Me.lblCIni3_pre.Location = New System.Drawing.Point(6, 58)
        Me.lblCIni3_pre.Name = "lblCIni3_pre"
        Me.lblCIni3_pre.Size = New System.Drawing.Size(98, 20)
        Me.lblCIni3_pre.TabIndex = 4
        Me.lblCIni3_pre.Text = "Saldo"
        '
        'lblCIni2_pre
        '
        Me.lblCIni2_pre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCIni2_pre.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCIni2_pre.ForeColor = System.Drawing.Color.Navy
        Me.lblCIni2_pre.Location = New System.Drawing.Point(6, 37)
        Me.lblCIni2_pre.Name = "lblCIni2_pre"
        Me.lblCIni2_pre.Size = New System.Drawing.Size(98, 20)
        Me.lblCIni2_pre.TabIndex = 2
        Me.lblCIni2_pre.Text = "Total Abonos"
        '
        'lblNCuotasIni_cuota
        '
        Me.lblNCuotasIni_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNCuotasIni_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNCuotasIni_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblNCuotasIni_cuota.Location = New System.Drawing.Point(6, 15)
        Me.lblNCuotasIni_cuota.Name = "lblNCuotasIni_cuota"
        Me.lblNCuotasIni_cuota.Size = New System.Drawing.Size(98, 20)
        Me.lblNCuotasIni_cuota.TabIndex = 0
        Me.lblNCuotasIni_cuota.Text = "Total Presupuesto"
        '
        'gpTotalCuotas
        '
        Me.gpTotalCuotas.BackColor = System.Drawing.Color.Transparent
        Me.gpTotalCuotas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpTotalCuotas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpTotalCuotas.Controls.Add(Me.txtNcuotas_deuda)
        Me.gpTotalCuotas.Controls.Add(Me.LabelX9)
        Me.gpTotalCuotas.Controls.Add(Me.txtNcuotas)
        Me.gpTotalCuotas.Controls.Add(Me.txtNcuotas_pagadas)
        Me.gpTotalCuotas.Controls.Add(Me.txtNcuotas_Saldo)
        Me.gpTotalCuotas.Controls.Add(Me.LabelX6)
        Me.gpTotalCuotas.Controls.Add(Me.LabelX7)
        Me.gpTotalCuotas.Controls.Add(Me.LabelX8)
        Me.gpTotalCuotas.Location = New System.Drawing.Point(273, 40)
        Me.gpTotalCuotas.Name = "gpTotalCuotas"
        Me.gpTotalCuotas.Size = New System.Drawing.Size(218, 111)
        '
        '
        '
        Me.gpTotalCuotas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpTotalCuotas.Style.BackColorGradientAngle = 90
        Me.gpTotalCuotas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpTotalCuotas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuotas.Style.BorderBottomWidth = 1
        Me.gpTotalCuotas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpTotalCuotas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuotas.Style.BorderLeftWidth = 1
        Me.gpTotalCuotas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuotas.Style.BorderRightWidth = 1
        Me.gpTotalCuotas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuotas.Style.BorderTopWidth = 1
        Me.gpTotalCuotas.Style.CornerDiameter = 4
        Me.gpTotalCuotas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpTotalCuotas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpTotalCuotas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpTotalCuotas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpTotalCuotas.TabIndex = 118
        Me.gpTotalCuotas.Tag = ""
        Me.gpTotalCuotas.Text = "Total Cuotas"
        '
        'txtNcuotas_deuda
        '
        Me.txtNcuotas_deuda.EditValue = "0"
        Me.txtNcuotas_deuda.Location = New System.Drawing.Point(159, 67)
        Me.txtNcuotas_deuda.Name = "txtNcuotas_deuda"
        Me.txtNcuotas_deuda.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNcuotas_deuda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas_deuda.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas_deuda.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas_deuda.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas_deuda.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas_deuda.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas_deuda.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas_deuda.Properties.Mask.BeepOnError = True
        Me.txtNcuotas_deuda.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas_deuda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas_deuda.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas_deuda.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas_deuda.Properties.ReadOnly = True
        Me.txtNcuotas_deuda.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas_deuda.TabIndex = 7
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX9.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX9.ForeColor = System.Drawing.Color.Navy
        Me.LabelX9.Location = New System.Drawing.Point(3, 68)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(150, 20)
        Me.LabelX9.TabIndex = 6
        Me.LabelX9.Text = "Cuotas Sin Cancelar"
        '
        'txtNcuotas
        '
        Me.txtNcuotas.EditValue = "0"
        Me.txtNcuotas.Location = New System.Drawing.Point(159, 1)
        Me.txtNcuotas.Name = "txtNcuotas"
        Me.txtNcuotas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNcuotas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas.Properties.Mask.BeepOnError = True
        Me.txtNcuotas.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas.Properties.ReadOnly = True
        Me.txtNcuotas.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas.TabIndex = 1
        '
        'txtNcuotas_pagadas
        '
        Me.txtNcuotas_pagadas.EditValue = "0"
        Me.txtNcuotas_pagadas.Location = New System.Drawing.Point(159, 23)
        Me.txtNcuotas_pagadas.Name = "txtNcuotas_pagadas"
        Me.txtNcuotas_pagadas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNcuotas_pagadas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas_pagadas.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas_pagadas.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas_pagadas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas_pagadas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas_pagadas.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas_pagadas.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas_pagadas.Properties.Mask.BeepOnError = True
        Me.txtNcuotas_pagadas.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas_pagadas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas_pagadas.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas_pagadas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas_pagadas.Properties.ReadOnly = True
        Me.txtNcuotas_pagadas.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas_pagadas.TabIndex = 3
        '
        'txtNcuotas_Saldo
        '
        Me.txtNcuotas_Saldo.EditValue = "0"
        Me.txtNcuotas_Saldo.Location = New System.Drawing.Point(159, 45)
        Me.txtNcuotas_Saldo.Name = "txtNcuotas_Saldo"
        Me.txtNcuotas_Saldo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNcuotas_Saldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas_Saldo.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas_Saldo.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas_Saldo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas_Saldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas_Saldo.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas_Saldo.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas_Saldo.Properties.Mask.BeepOnError = True
        Me.txtNcuotas_Saldo.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas_Saldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas_Saldo.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas_Saldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas_Saldo.Properties.ReadOnly = True
        Me.txtNcuotas_Saldo.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas_Saldo.TabIndex = 5
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX6.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX6.ForeColor = System.Drawing.Color.Navy
        Me.LabelX6.Location = New System.Drawing.Point(3, 46)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(150, 20)
        Me.LabelX6.TabIndex = 4
        Me.LabelX6.Text = "Cuotas Con Saldo"
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(3, 25)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(150, 20)
        Me.LabelX7.TabIndex = 2
        Me.LabelX7.Text = "Cuotas Pagadas"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX8.ForeColor = System.Drawing.Color.Navy
        Me.LabelX8.Location = New System.Drawing.Point(3, 3)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(150, 20)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "No. Cuotas"
        '
        'gpTotalTratamiento
        '
        Me.gpTotalTratamiento.BackColor = System.Drawing.Color.Transparent
        Me.gpTotalTratamiento.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpTotalTratamiento.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpTotalTratamiento.Controls.Add(Me.txtTotalTratamiento)
        Me.gpTotalTratamiento.Controls.Add(Me.txtTotalTratamientoAbonos)
        Me.gpTotalTratamiento.Controls.Add(Me.txtTotalTratamientoSaldo)
        Me.gpTotalTratamiento.Controls.Add(Me.LabelX24)
        Me.gpTotalTratamiento.Controls.Add(Me.LabelX25)
        Me.gpTotalTratamiento.Controls.Add(Me.LabelX26)
        Me.gpTotalTratamiento.Location = New System.Drawing.Point(154, 294)
        Me.gpTotalTratamiento.Name = "gpTotalTratamiento"
        Me.gpTotalTratamiento.Size = New System.Drawing.Size(207, 112)
        '
        '
        '
        Me.gpTotalTratamiento.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpTotalTratamiento.Style.BackColorGradientAngle = 90
        Me.gpTotalTratamiento.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpTotalTratamiento.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalTratamiento.Style.BorderBottomWidth = 1
        Me.gpTotalTratamiento.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpTotalTratamiento.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalTratamiento.Style.BorderLeftWidth = 1
        Me.gpTotalTratamiento.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalTratamiento.Style.BorderRightWidth = 1
        Me.gpTotalTratamiento.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalTratamiento.Style.BorderTopWidth = 1
        Me.gpTotalTratamiento.Style.CornerDiameter = 4
        Me.gpTotalTratamiento.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpTotalTratamiento.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpTotalTratamiento.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpTotalTratamiento.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpTotalTratamiento.TabIndex = 118
        Me.gpTotalTratamiento.Tag = ""
        Me.gpTotalTratamiento.Text = "Total Tratamiento"
        '
        'txtTotalTratamiento
        '
        Me.txtTotalTratamiento.EditValue = "0"
        Me.txtTotalTratamiento.Location = New System.Drawing.Point(105, 13)
        Me.txtTotalTratamiento.Name = "txtTotalTratamiento"
        Me.txtTotalTratamiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalTratamiento.Properties.Appearance.Options.UseFont = True
        Me.txtTotalTratamiento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalTratamiento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalTratamiento.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalTratamiento.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalTratamiento.Properties.Mask.BeepOnError = True
        Me.txtTotalTratamiento.Properties.Mask.EditMask = "c0"
        Me.txtTotalTratamiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalTratamiento.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalTratamiento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalTratamiento.Properties.ReadOnly = True
        Me.txtTotalTratamiento.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalTratamiento.TabIndex = 1
        '
        'txtTotalTratamientoAbonos
        '
        Me.txtTotalTratamientoAbonos.EditValue = "0"
        Me.txtTotalTratamientoAbonos.Location = New System.Drawing.Point(105, 35)
        Me.txtTotalTratamientoAbonos.Name = "txtTotalTratamientoAbonos"
        Me.txtTotalTratamientoAbonos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalTratamientoAbonos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalTratamientoAbonos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalTratamientoAbonos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalTratamientoAbonos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalTratamientoAbonos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalTratamientoAbonos.Properties.Mask.BeepOnError = True
        Me.txtTotalTratamientoAbonos.Properties.Mask.EditMask = "c0"
        Me.txtTotalTratamientoAbonos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalTratamientoAbonos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalTratamientoAbonos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalTratamientoAbonos.Properties.ReadOnly = True
        Me.txtTotalTratamientoAbonos.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalTratamientoAbonos.TabIndex = 3
        '
        'txtTotalTratamientoSaldo
        '
        Me.txtTotalTratamientoSaldo.EditValue = "0"
        Me.txtTotalTratamientoSaldo.Location = New System.Drawing.Point(105, 57)
        Me.txtTotalTratamientoSaldo.Name = "txtTotalTratamientoSaldo"
        Me.txtTotalTratamientoSaldo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalTratamientoSaldo.Properties.Appearance.Options.UseFont = True
        Me.txtTotalTratamientoSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalTratamientoSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalTratamientoSaldo.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalTratamientoSaldo.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalTratamientoSaldo.Properties.Mask.BeepOnError = True
        Me.txtTotalTratamientoSaldo.Properties.Mask.EditMask = "c0"
        Me.txtTotalTratamientoSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalTratamientoSaldo.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalTratamientoSaldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalTratamientoSaldo.Properties.ReadOnly = True
        Me.txtTotalTratamientoSaldo.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalTratamientoSaldo.TabIndex = 5
        '
        'LabelX24
        '
        Me.LabelX24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX24.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX24.ForeColor = System.Drawing.Color.Navy
        Me.LabelX24.Location = New System.Drawing.Point(6, 58)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(98, 20)
        Me.LabelX24.TabIndex = 4
        Me.LabelX24.Text = "Saldo"
        '
        'LabelX25
        '
        Me.LabelX25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX25.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX25.ForeColor = System.Drawing.Color.Navy
        Me.LabelX25.Location = New System.Drawing.Point(6, 37)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(98, 20)
        Me.LabelX25.TabIndex = 2
        Me.LabelX25.Text = "Total Abonos"
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX26.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX26.ForeColor = System.Drawing.Color.Navy
        Me.LabelX26.Location = New System.Drawing.Point(6, 15)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(98, 20)
        Me.LabelX26.TabIndex = 0
        Me.LabelX26.Text = "Total Tratamiento"
        '
        'gpTotalCuentasAd
        '
        Me.gpTotalCuentasAd.BackColor = System.Drawing.Color.Transparent
        Me.gpTotalCuentasAd.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpTotalCuentasAd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpTotalCuentasAd.Controls.Add(Me.txtNcuotas_deuda_ad)
        Me.gpTotalCuentasAd.Controls.Add(Me.LabelX20)
        Me.gpTotalCuentasAd.Controls.Add(Me.txtNcuotas_ad)
        Me.gpTotalCuentasAd.Controls.Add(Me.txtNcuotas_pagadas_ad)
        Me.gpTotalCuentasAd.Controls.Add(Me.txtNcuotas_Saldo_ad)
        Me.gpTotalCuentasAd.Controls.Add(Me.LabelX21)
        Me.gpTotalCuentasAd.Controls.Add(Me.LabelX22)
        Me.gpTotalCuentasAd.Controls.Add(Me.LabelX23)
        Me.gpTotalCuentasAd.Location = New System.Drawing.Point(273, 171)
        Me.gpTotalCuentasAd.Name = "gpTotalCuentasAd"
        Me.gpTotalCuentasAd.Size = New System.Drawing.Size(218, 111)
        '
        '
        '
        Me.gpTotalCuentasAd.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpTotalCuentasAd.Style.BackColorGradientAngle = 90
        Me.gpTotalCuentasAd.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpTotalCuentasAd.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuentasAd.Style.BorderBottomWidth = 1
        Me.gpTotalCuentasAd.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpTotalCuentasAd.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuentasAd.Style.BorderLeftWidth = 1
        Me.gpTotalCuentasAd.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuentasAd.Style.BorderRightWidth = 1
        Me.gpTotalCuentasAd.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalCuentasAd.Style.BorderTopWidth = 1
        Me.gpTotalCuentasAd.Style.CornerDiameter = 4
        Me.gpTotalCuentasAd.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpTotalCuentasAd.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpTotalCuentasAd.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpTotalCuentasAd.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpTotalCuentasAd.TabIndex = 119
        Me.gpTotalCuentasAd.Tag = ""
        Me.gpTotalCuentasAd.Text = "Total Cuentas Adicionales"
        '
        'txtNcuotas_deuda_ad
        '
        Me.txtNcuotas_deuda_ad.EditValue = "0"
        Me.txtNcuotas_deuda_ad.Location = New System.Drawing.Point(159, 67)
        Me.txtNcuotas_deuda_ad.Name = "txtNcuotas_deuda_ad"
        Me.txtNcuotas_deuda_ad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNcuotas_deuda_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas_deuda_ad.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas_deuda_ad.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas_deuda_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas_deuda_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas_deuda_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas_deuda_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas_deuda_ad.Properties.Mask.BeepOnError = True
        Me.txtNcuotas_deuda_ad.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas_deuda_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas_deuda_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas_deuda_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas_deuda_ad.Properties.ReadOnly = True
        Me.txtNcuotas_deuda_ad.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas_deuda_ad.TabIndex = 7
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX20.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX20.ForeColor = System.Drawing.Color.Navy
        Me.LabelX20.Location = New System.Drawing.Point(3, 68)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(150, 20)
        Me.LabelX20.TabIndex = 6
        Me.LabelX20.Text = "C. Adicionales Sin Cancelar"
        '
        'txtNcuotas_ad
        '
        Me.txtNcuotas_ad.EditValue = "0"
        Me.txtNcuotas_ad.Location = New System.Drawing.Point(159, 1)
        Me.txtNcuotas_ad.Name = "txtNcuotas_ad"
        Me.txtNcuotas_ad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNcuotas_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas_ad.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas_ad.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas_ad.Properties.Mask.BeepOnError = True
        Me.txtNcuotas_ad.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas_ad.Properties.ReadOnly = True
        Me.txtNcuotas_ad.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas_ad.TabIndex = 1
        '
        'txtNcuotas_pagadas_ad
        '
        Me.txtNcuotas_pagadas_ad.EditValue = "0"
        Me.txtNcuotas_pagadas_ad.Location = New System.Drawing.Point(159, 23)
        Me.txtNcuotas_pagadas_ad.Name = "txtNcuotas_pagadas_ad"
        Me.txtNcuotas_pagadas_ad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNcuotas_pagadas_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas_pagadas_ad.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas_pagadas_ad.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas_pagadas_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas_pagadas_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas_pagadas_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas_pagadas_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas_pagadas_ad.Properties.Mask.BeepOnError = True
        Me.txtNcuotas_pagadas_ad.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas_pagadas_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas_pagadas_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas_pagadas_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas_pagadas_ad.Properties.ReadOnly = True
        Me.txtNcuotas_pagadas_ad.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas_pagadas_ad.TabIndex = 3
        '
        'txtNcuotas_Saldo_ad
        '
        Me.txtNcuotas_Saldo_ad.EditValue = "0"
        Me.txtNcuotas_Saldo_ad.Location = New System.Drawing.Point(159, 45)
        Me.txtNcuotas_Saldo_ad.Name = "txtNcuotas_Saldo_ad"
        Me.txtNcuotas_Saldo_ad.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNcuotas_Saldo_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcuotas_Saldo_ad.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcuotas_Saldo_ad.Properties.Appearance.Options.UseFont = True
        Me.txtNcuotas_Saldo_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcuotas_Saldo_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcuotas_Saldo_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcuotas_Saldo_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcuotas_Saldo_ad.Properties.Mask.BeepOnError = True
        Me.txtNcuotas_Saldo_ad.Properties.Mask.EditMask = "n0"
        Me.txtNcuotas_Saldo_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcuotas_Saldo_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcuotas_Saldo_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcuotas_Saldo_ad.Properties.ReadOnly = True
        Me.txtNcuotas_Saldo_ad.Size = New System.Drawing.Size(47, 21)
        Me.txtNcuotas_Saldo_ad.TabIndex = 5
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX21.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX21.ForeColor = System.Drawing.Color.Navy
        Me.LabelX21.Location = New System.Drawing.Point(3, 46)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(150, 20)
        Me.LabelX21.TabIndex = 4
        Me.LabelX21.Text = "C. Adicionales Con Saldo"
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX22.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX22.ForeColor = System.Drawing.Color.Navy
        Me.LabelX22.Location = New System.Drawing.Point(3, 25)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(150, 20)
        Me.LabelX22.TabIndex = 2
        Me.LabelX22.Text = "C. Adicionales Pagadas"
        '
        'LabelX23
        '
        Me.LabelX23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX23.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX23.ForeColor = System.Drawing.Color.Navy
        Me.LabelX23.Location = New System.Drawing.Point(3, 3)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(150, 20)
        Me.LabelX23.TabIndex = 0
        Me.LabelX23.Text = "No. C. Adicionales"
        '
        'gpEstadoCuentasAd
        '
        Me.gpEstadoCuentasAd.BackColor = System.Drawing.Color.Transparent
        Me.gpEstadoCuentasAd.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEstadoCuentasAd.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEstadoCuentasAd.Controls.Add(Me.txtTotalAdicionales)
        Me.gpEstadoCuentasAd.Controls.Add(Me.txtTotalAbonos_ad)
        Me.gpEstadoCuentasAd.Controls.Add(Me.txtTotalSaldo_ad)
        Me.gpEstadoCuentasAd.Controls.Add(Me.LabelX17)
        Me.gpEstadoCuentasAd.Controls.Add(Me.LabelX18)
        Me.gpEstadoCuentasAd.Controls.Add(Me.LabelX19)
        Me.gpEstadoCuentasAd.Location = New System.Drawing.Point(46, 171)
        Me.gpEstadoCuentasAd.Name = "gpEstadoCuentasAd"
        Me.gpEstadoCuentasAd.Size = New System.Drawing.Size(207, 112)
        '
        '
        '
        Me.gpEstadoCuentasAd.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpEstadoCuentasAd.Style.BackColorGradientAngle = 90
        Me.gpEstadoCuentasAd.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpEstadoCuentasAd.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuentasAd.Style.BorderBottomWidth = 1
        Me.gpEstadoCuentasAd.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEstadoCuentasAd.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuentasAd.Style.BorderLeftWidth = 1
        Me.gpEstadoCuentasAd.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuentasAd.Style.BorderRightWidth = 1
        Me.gpEstadoCuentasAd.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuentasAd.Style.BorderTopWidth = 1
        Me.gpEstadoCuentasAd.Style.CornerDiameter = 4
        Me.gpEstadoCuentasAd.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEstadoCuentasAd.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEstadoCuentasAd.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpEstadoCuentasAd.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpEstadoCuentasAd.TabIndex = 117
        Me.gpEstadoCuentasAd.Tag = ""
        Me.gpEstadoCuentasAd.Text = "Estado Cuenta Adicionales"
        '
        'txtTotalAdicionales
        '
        Me.txtTotalAdicionales.EditValue = "0"
        Me.txtTotalAdicionales.Location = New System.Drawing.Point(105, 13)
        Me.txtTotalAdicionales.Name = "txtTotalAdicionales"
        Me.txtTotalAdicionales.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAdicionales.Properties.Appearance.Options.UseFont = True
        Me.txtTotalAdicionales.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalAdicionales.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalAdicionales.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalAdicionales.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalAdicionales.Properties.Mask.BeepOnError = True
        Me.txtTotalAdicionales.Properties.Mask.EditMask = "c0"
        Me.txtTotalAdicionales.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalAdicionales.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalAdicionales.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalAdicionales.Properties.ReadOnly = True
        Me.txtTotalAdicionales.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalAdicionales.TabIndex = 1
        '
        'txtTotalAbonos_ad
        '
        Me.txtTotalAbonos_ad.EditValue = "0"
        Me.txtTotalAbonos_ad.Location = New System.Drawing.Point(105, 35)
        Me.txtTotalAbonos_ad.Name = "txtTotalAbonos_ad"
        Me.txtTotalAbonos_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAbonos_ad.Properties.Appearance.Options.UseFont = True
        Me.txtTotalAbonos_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalAbonos_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalAbonos_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalAbonos_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalAbonos_ad.Properties.Mask.BeepOnError = True
        Me.txtTotalAbonos_ad.Properties.Mask.EditMask = "c0"
        Me.txtTotalAbonos_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalAbonos_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalAbonos_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalAbonos_ad.Properties.ReadOnly = True
        Me.txtTotalAbonos_ad.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalAbonos_ad.TabIndex = 3
        '
        'txtTotalSaldo_ad
        '
        Me.txtTotalSaldo_ad.EditValue = "0"
        Me.txtTotalSaldo_ad.Location = New System.Drawing.Point(105, 57)
        Me.txtTotalSaldo_ad.Name = "txtTotalSaldo_ad"
        Me.txtTotalSaldo_ad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalSaldo_ad.Properties.Appearance.Options.UseFont = True
        Me.txtTotalSaldo_ad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalSaldo_ad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalSaldo_ad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalSaldo_ad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalSaldo_ad.Properties.Mask.BeepOnError = True
        Me.txtTotalSaldo_ad.Properties.Mask.EditMask = "c0"
        Me.txtTotalSaldo_ad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalSaldo_ad.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalSaldo_ad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalSaldo_ad.Properties.ReadOnly = True
        Me.txtTotalSaldo_ad.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalSaldo_ad.TabIndex = 5
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX17.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX17.ForeColor = System.Drawing.Color.Navy
        Me.LabelX17.Location = New System.Drawing.Point(6, 58)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(98, 20)
        Me.LabelX17.TabIndex = 4
        Me.LabelX17.Text = "Saldo"
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX18.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(6, 37)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(98, 20)
        Me.LabelX18.TabIndex = 2
        Me.LabelX18.Text = "Total Abonos"
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX19.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX19.ForeColor = System.Drawing.Color.Navy
        Me.LabelX19.Location = New System.Drawing.Point(6, 15)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(98, 20)
        Me.LabelX19.TabIndex = 0
        Me.LabelX19.Text = "Total Adicionales"
        '
        'tabResumenCuenta
        '
        Me.tabResumenCuenta.AttachedControl = Me.TabControlPanel5
        Me.tabResumenCuenta.Image = CType(resources.GetObject("tabResumenCuenta.Image"), System.Drawing.Image)
        Me.tabResumenCuenta.Name = "tabResumenCuenta"
        Me.tabResumenCuenta.Text = "Resumen de Cuentas"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.chkdescuento)
        Me.TabControlPanel1.Controls.Add(Me.gpDescuentos)
        Me.TabControlPanel1.Controls.Add(Me.dgCuotas)
        Me.TabControlPanel1.Controls.Add(Me.lblTituloVentana)
        Me.TabControlPanel1.Controls.Add(Me.lblValorCuota)
        Me.TabControlPanel1.Controls.Add(Me.txtValorCuota)
        Me.TabControlPanel1.Controls.Add(Me.lblAbonoCuota)
        Me.TabControlPanel1.Controls.Add(Me.txtAbonoCuota)
        Me.TabControlPanel1.Controls.Add(Me.txtSaldoCuota)
        Me.TabControlPanel1.Controls.Add(Me.txtNomCuota)
        Me.TabControlPanel1.Controls.Add(Me.lblSaldoCuota)
        Me.TabControlPanel1.Controls.Add(Me.txtCodigoCuota)
        Me.TabControlPanel1.Controls.Add(Me.lblNomCuota)
        Me.TabControlPanel1.Controls.Add(Me.lblCodigoCuota)
        Me.TabControlPanel1.Controls.Add(Me.btnPagarCuota)
        Me.TabControlPanel1.Controls.Add(Me.lblPagoCuota)
        Me.TabControlPanel1.Controls.Add(Me.txtPagoCuota)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 417)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabEstadoCuentas
        '
        'chkdescuento
        '
        Me.chkdescuento.Location = New System.Drawing.Point(14, 370)
        Me.chkdescuento.Name = "chkdescuento"
        Me.chkdescuento.Size = New System.Drawing.Size(78, 37)
        Me.chkdescuento.TabIndex = 110
        Me.chkdescuento.Text = "Descuento"
        '
        'gpDescuentos
        '
        Me.gpDescuentos.BackColor = System.Drawing.Color.Transparent
        Me.gpDescuentos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDescuentos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDescuentos.Controls.Add(Me.txtPorcDesc)
        Me.gpDescuentos.Controls.Add(Me.txtValorDesc)
        Me.gpDescuentos.Controls.Add(Me.LabelX13)
        Me.gpDescuentos.Controls.Add(Me.LabelX10)
        Me.gpDescuentos.Enabled = False
        Me.gpDescuentos.Location = New System.Drawing.Point(95, 361)
        Me.gpDescuentos.Name = "gpDescuentos"
        Me.gpDescuentos.Size = New System.Drawing.Size(324, 46)
        '
        '
        '
        Me.gpDescuentos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDescuentos.Style.BackColorGradientAngle = 90
        Me.gpDescuentos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDescuentos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDescuentos.Style.BorderBottomWidth = 1
        Me.gpDescuentos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDescuentos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDescuentos.Style.BorderLeftWidth = 1
        Me.gpDescuentos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDescuentos.Style.BorderRightWidth = 1
        Me.gpDescuentos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDescuentos.Style.BorderTopWidth = 1
        Me.gpDescuentos.Style.CornerDiameter = 4
        Me.gpDescuentos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDescuentos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDescuentos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDescuentos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpDescuentos.TabIndex = 109
        Me.gpDescuentos.Text = "Descuentos"
        '
        'txtPorcDesc
        '
        Me.txtPorcDesc.EditValue = "% 0"
        Me.txtPorcDesc.Location = New System.Drawing.Point(84, 1)
        Me.txtPorcDesc.Name = "txtPorcDesc"
        Me.txtPorcDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPorcDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPorcDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtPorcDesc.Properties.Appearance.Options.UseFont = True
        Me.txtPorcDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPorcDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtPorcDesc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtPorcDesc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtPorcDesc.Properties.Mask.BeepOnError = True
        Me.txtPorcDesc.Properties.Mask.EditMask = "n0"
        Me.txtPorcDesc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcDesc.Properties.Mask.ShowPlaceHolders = False
        Me.txtPorcDesc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcDesc.Size = New System.Drawing.Size(40, 21)
        Me.txtPorcDesc.TabIndex = 104
        '
        'txtValorDesc
        '
        Me.txtValorDesc.EditValue = "0"
        Me.txtValorDesc.Location = New System.Drawing.Point(223, 1)
        Me.txtValorDesc.Name = "txtValorDesc"
        Me.txtValorDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtValorDesc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtValorDesc.Properties.Appearance.Options.UseFont = True
        Me.txtValorDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorDesc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtValorDesc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtValorDesc.Properties.Mask.BeepOnError = True
        Me.txtValorDesc.Properties.Mask.EditMask = "c0"
        Me.txtValorDesc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorDesc.Properties.Mask.ShowPlaceHolders = False
        Me.txtValorDesc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorDesc.Size = New System.Drawing.Size(89, 21)
        Me.txtValorDesc.TabIndex = 103
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX13.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX13.ForeColor = System.Drawing.Color.Navy
        Me.LabelX13.Location = New System.Drawing.Point(5, 2)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(73, 20)
        Me.LabelX13.TabIndex = 99
        Me.LabelX13.Text = "% Descuento"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX10.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX10.ForeColor = System.Drawing.Color.Navy
        Me.LabelX10.Location = New System.Drawing.Point(126, 2)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(88, 20)
        Me.LabelX10.TabIndex = 98
        Me.LabelX10.Text = "Valor Descuento"
        '
        'dgCuotas
        '
        Me.dgCuotas.AllowUserToAddRows = False
        Me.dgCuotas.AllowUserToDeleteRows = False
        Me.dgCuotas.AllowUserToResizeColumns = False
        Me.dgCuotas.AllowUserToResizeRows = False
        Me.dgCuotas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCuotas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCuotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuotas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuotas.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgCuotas.EnableHeadersVisualStyles = False
        Me.dgCuotas.Location = New System.Drawing.Point(12, 35)
        Me.dgCuotas.MultiSelect = False
        Me.dgCuotas.Name = "dgCuotas"
        Me.dgCuotas.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgCuotas.RowHeadersVisible = False
        Me.dgCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuotas.Size = New System.Drawing.Size(504, 269)
        Me.dgCuotas.TabIndex = 0
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(12, 7)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(504, 23)
        Me.lblTituloVentana.TabIndex = 92
        Me.lblTituloVentana.Text = "ESTADO DE CUENTA"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblValorCuota
        '
        Me.lblValorCuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblValorCuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblValorCuota.ForeColor = System.Drawing.Color.Navy
        Me.lblValorCuota.Location = New System.Drawing.Point(12, 334)
        Me.lblValorCuota.Name = "lblValorCuota"
        Me.lblValorCuota.Size = New System.Drawing.Size(41, 20)
        Me.lblValorCuota.TabIndex = 97
        Me.lblValorCuota.Text = "Valor"
        '
        'txtValorCuota
        '
        Me.txtValorCuota.EditValue = "0"
        Me.txtValorCuota.Location = New System.Drawing.Point(59, 333)
        Me.txtValorCuota.Name = "txtValorCuota"
        Me.txtValorCuota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtValorCuota.Properties.Appearance.Options.UseFont = True
        Me.txtValorCuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtValorCuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtValorCuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtValorCuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtValorCuota.Properties.Mask.BeepOnError = True
        Me.txtValorCuota.Properties.Mask.EditMask = "c0"
        Me.txtValorCuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtValorCuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtValorCuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtValorCuota.Properties.ReadOnly = True
        Me.txtValorCuota.Size = New System.Drawing.Size(79, 21)
        Me.txtValorCuota.TabIndex = 98
        '
        'lblAbonoCuota
        '
        Me.lblAbonoCuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAbonoCuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblAbonoCuota.ForeColor = System.Drawing.Color.Navy
        Me.lblAbonoCuota.Location = New System.Drawing.Point(145, 334)
        Me.lblAbonoCuota.Name = "lblAbonoCuota"
        Me.lblAbonoCuota.Size = New System.Drawing.Size(41, 20)
        Me.lblAbonoCuota.TabIndex = 99
        Me.lblAbonoCuota.Text = "Abono"
        '
        'txtAbonoCuota
        '
        Me.txtAbonoCuota.EditValue = "0"
        Me.txtAbonoCuota.Location = New System.Drawing.Point(191, 334)
        Me.txtAbonoCuota.Name = "txtAbonoCuota"
        Me.txtAbonoCuota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtAbonoCuota.Properties.Appearance.Options.UseFont = True
        Me.txtAbonoCuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAbonoCuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAbonoCuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtAbonoCuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtAbonoCuota.Properties.Mask.BeepOnError = True
        Me.txtAbonoCuota.Properties.Mask.EditMask = "c0"
        Me.txtAbonoCuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAbonoCuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtAbonoCuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAbonoCuota.Properties.ReadOnly = True
        Me.txtAbonoCuota.Size = New System.Drawing.Size(88, 21)
        Me.txtAbonoCuota.TabIndex = 100
        '
        'txtSaldoCuota
        '
        Me.txtSaldoCuota.EditValue = "0"
        Me.txtSaldoCuota.Location = New System.Drawing.Point(331, 334)
        Me.txtSaldoCuota.Name = "txtSaldoCuota"
        Me.txtSaldoCuota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldoCuota.Properties.Appearance.Options.UseFont = True
        Me.txtSaldoCuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSaldoCuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSaldoCuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtSaldoCuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtSaldoCuota.Properties.Mask.BeepOnError = True
        Me.txtSaldoCuota.Properties.Mask.EditMask = "c0"
        Me.txtSaldoCuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoCuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtSaldoCuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSaldoCuota.Properties.ReadOnly = True
        Me.txtSaldoCuota.Size = New System.Drawing.Size(89, 21)
        Me.txtSaldoCuota.TabIndex = 102
        '
        'txtNomCuota
        '
        '
        '
        '
        Me.txtNomCuota.Border.Class = "TextBoxBorder"
        Me.txtNomCuota.Location = New System.Drawing.Point(191, 308)
        Me.txtNomCuota.Name = "txtNomCuota"
        Me.txtNomCuota.ReadOnly = True
        Me.txtNomCuota.Size = New System.Drawing.Size(229, 20)
        Me.txtNomCuota.TabIndex = 106
        '
        'lblSaldoCuota
        '
        Me.lblSaldoCuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSaldoCuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblSaldoCuota.ForeColor = System.Drawing.Color.Navy
        Me.lblSaldoCuota.Location = New System.Drawing.Point(286, 335)
        Me.lblSaldoCuota.Name = "lblSaldoCuota"
        Me.lblSaldoCuota.Size = New System.Drawing.Size(41, 20)
        Me.lblSaldoCuota.TabIndex = 101
        Me.lblSaldoCuota.Text = "Saldo"
        '
        'txtCodigoCuota
        '
        '
        '
        '
        Me.txtCodigoCuota.Border.Class = "TextBoxBorder"
        Me.txtCodigoCuota.Location = New System.Drawing.Point(97, 308)
        Me.txtCodigoCuota.Name = "txtCodigoCuota"
        Me.txtCodigoCuota.ReadOnly = True
        Me.txtCodigoCuota.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigoCuota.TabIndex = 108
        '
        'lblNomCuota
        '
        Me.lblNomCuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNomCuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomCuota.ForeColor = System.Drawing.Color.Navy
        Me.lblNomCuota.Location = New System.Drawing.Point(145, 308)
        Me.lblNomCuota.Name = "lblNomCuota"
        Me.lblNomCuota.Size = New System.Drawing.Size(41, 20)
        Me.lblNomCuota.TabIndex = 105
        Me.lblNomCuota.Text = "Detalle"
        '
        'lblCodigoCuota
        '
        Me.lblCodigoCuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCodigoCuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCodigoCuota.ForeColor = System.Drawing.Color.Navy
        Me.lblCodigoCuota.Location = New System.Drawing.Point(12, 308)
        Me.lblCodigoCuota.Name = "lblCodigoCuota"
        Me.lblCodigoCuota.Size = New System.Drawing.Size(79, 20)
        Me.lblCodigoCuota.TabIndex = 107
        Me.lblCodigoCuota.Text = "Codigo Cuota"
        '
        'btnPagarCuota
        '
        Me.btnPagarCuota.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPagarCuota.Enabled = False
        Me.btnPagarCuota.Image = CType(resources.GetObject("btnPagarCuota.Image"), System.Drawing.Image)
        Me.btnPagarCuota.Location = New System.Drawing.Point(424, 365)
        Me.btnPagarCuota.Name = "btnPagarCuota"
        Me.btnPagarCuota.Size = New System.Drawing.Size(94, 40)
        Me.btnPagarCuota.TabIndex = 95
        Me.btnPagarCuota.Text = "PAGAR CUOTA"
        '
        'lblPagoCuota
        '
        Me.lblPagoCuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPagoCuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblPagoCuota.ForeColor = System.Drawing.Color.Navy
        Me.lblPagoCuota.Location = New System.Drawing.Point(424, 308)
        Me.lblPagoCuota.Name = "lblPagoCuota"
        Me.lblPagoCuota.Size = New System.Drawing.Size(96, 23)
        Me.lblPagoCuota.TabIndex = 103
        Me.lblPagoCuota.Text = "Pago"
        Me.lblPagoCuota.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtPagoCuota
        '
        Me.txtPagoCuota.EditValue = "0"
        Me.txtPagoCuota.Location = New System.Drawing.Point(424, 334)
        Me.txtPagoCuota.Name = "txtPagoCuota"
        Me.txtPagoCuota.Properties.Appearance.BackColor = System.Drawing.Color.Aqua
        Me.txtPagoCuota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPagoCuota.Properties.Appearance.Options.UseBackColor = True
        Me.txtPagoCuota.Properties.Appearance.Options.UseFont = True
        Me.txtPagoCuota.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPagoCuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPagoCuota.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtPagoCuota.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtPagoCuota.Properties.Mask.BeepOnError = True
        Me.txtPagoCuota.Properties.Mask.EditMask = "c0"
        Me.txtPagoCuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPagoCuota.Properties.Mask.ShowPlaceHolders = False
        Me.txtPagoCuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPagoCuota.Size = New System.Drawing.Size(94, 23)
        Me.txtPagoCuota.TabIndex = 104
        '
        'TabEstadoCuentas
        '
        Me.TabEstadoCuentas.AttachedControl = Me.TabControlPanel1
        Me.TabEstadoCuentas.Image = CType(resources.GetObject("TabEstadoCuentas.Image"), System.Drawing.Image)
        Me.TabEstadoCuentas.Name = "TabEstadoCuentas"
        Me.TabEstadoCuentas.Text = "Estado Cuentas"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(424, 446)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 33)
        Me.btnSalir.TabIndex = 96
        Me.btnSalir.Text = "SALIR"
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel4
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Estadisticas de Cuotas"
        '
        'frmEstadoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEstadoCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Estado Cuenta"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.TabControlCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlCuentas.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.gpPresupuestos.ResumeLayout(False)
        CType(Me.txtTotal_Cuenta_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCrearCuentaAd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpItems_cuentas.ResumeLayout(False)
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel4.ResumeLayout(False)
        Me.gpTipoInforme.ResumeLayout(False)
        Me.gpTipoInforme.PerformLayout()
        CType(Me.txtTotalPagos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleRcaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMaestroRcaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.txtValorCuota_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoCuota_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoCuota_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPagoCuota_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuentasadicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel5.ResumeLayout(False)
        Me.gpEstadoCuenta.ResumeLayout(False)
        CType(Me.txtTotalPresupuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAbonos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpTotalCuotas.ResumeLayout(False)
        CType(Me.txtNcuotas_deuda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcuotas_pagadas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcuotas_Saldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpTotalTratamiento.ResumeLayout(False)
        CType(Me.txtTotalTratamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalTratamientoAbonos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalTratamientoSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpTotalCuentasAd.ResumeLayout(False)
        CType(Me.txtNcuotas_deuda_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcuotas_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcuotas_pagadas_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcuotas_Saldo_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpEstadoCuentasAd.ResumeLayout(False)
        CType(Me.txtTotalAdicionales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAbonos_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalSaldo_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.gpDescuentos.ResumeLayout(False)
        CType(Me.txtPorcDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorCuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbonoCuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaldoCuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPagoCuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCuotas As System.Windows.Forms.DataGridView
    Friend WithEvents btnPagarCuota As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPagoCuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPagoCuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSaldoCuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSaldoCuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAbonoCuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAbonoCuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtValorCuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblValorCuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNomCuota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNomCuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigoCuota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblCodigoCuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControlCuentas As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabEstadoCuentas As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabCuentasAdicionales As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabCrearCuentaAdicional As DevComponents.DotNetBar.TabItem
    Friend WithEvents lblCuentasAdicionales As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCuentasadicionales As System.Windows.Forms.DataGridView
    Friend WithEvents lblValorCuota_ad As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtValorCuota_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAbonoCuota_ad As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAbonoCuota_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSaldoCuota_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomCuota_ad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblSaldoCuota_ad As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigoCuota_ad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNomCuota_ad As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCodigoCuota_ad As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPagoCuota_ad As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPagoCuota_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabResumenPagos As DevComponents.DotNetBar.TabItem
    Friend WithEvents btnPagoCuentaAd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabResumenCuenta As DevComponents.DotNetBar.TabItem
    Friend WithEvents gpTotalTratamiento As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtTotalTratamiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalTratamientoAbonos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalTratamientoSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpTotalCuentasAd As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtNcuotas_deuda_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNcuotas_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNcuotas_pagadas_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNcuotas_Saldo_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpEstadoCuentasAd As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtTotalAdicionales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalAbonos_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalSaldo_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpTipoInforme As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbEvolucion1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblTotalPagos As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotalPagos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDetalle As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMaestro As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgDetalleRcaja As System.Windows.Forms.DataGridView
    Friend WithEvents dgMaestroRcaja As System.Windows.Forms.DataGridView
    Friend WithEvents lblResumenPagos As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblResumenCuentas As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpEstadoCuenta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtTotalPresupuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalAbonos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCIni3_pre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCIni2_pre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNCuotasIni_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpTotalCuotas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtNcuotas_deuda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNcuotas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNcuotas_pagadas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNcuotas_Saldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCrearCuentaAd As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpItems_cuentas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbfecha_ad As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtreferencia_proc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtvalor_proc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnIngresar_Item As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdprocedimiento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCrearCuentaAd As System.Windows.Forms.DataGridView
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNCuentaAd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTotal_Cuenta_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotal_Cuenta_ad As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCrearCuentaAdicional As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevaCuentaAdicional As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBorrarItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBorrarCuentaAdicional As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTooltip As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents gpDescuentos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtValorDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkdescuento As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtPorcDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbEspecialidades As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreEspecialidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpPresupuestos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbPresupuestos As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
End Class
