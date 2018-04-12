<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimientoDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovimientoDiario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.btnAnular = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.TabMovimientoDiario = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.dgFac1 = New System.Windows.Forms.DataGridView
        Me.dgFac0 = New System.Windows.Forms.DataGridView
        Me.lblRecibosFac1 = New DevComponents.DotNetBar.LabelX
        Me.lblRecibosFac0 = New DevComponents.DotNetBar.LabelX
        Me.lblCuadreFac = New DevComponents.DotNetBar.LabelX
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpPagosMD = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtTotalDebitos = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalCreditos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.txtTMovimientoDiario = New DevExpress.XtraEditors.TextEdit
        Me.txtTPagoTarjetadebitos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.txtTPagoEfectivodebitos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.txtTCajaMenordebitos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.gpTotalesMD = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.txtNcegresoAnulados = New DevExpress.XtraEditors.TextEdit
        Me.txtNfacturasAnulados = New DevExpress.XtraEditors.TextEdit
        Me.txtNrcajaAnulados = New DevExpress.XtraEditors.TextEdit
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.lblCodigo = New DevComponents.DotNetBar.LabelX
        Me.txtTcegresoCreditos = New DevExpress.XtraEditors.TextEdit
        Me.txtNcegresoActivos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.txtNfacturasActivos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.txtNrcajaActivos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.txtTfacturasdebito = New DevExpress.XtraEditors.TextEdit
        Me.txtTrcajadebitos = New DevExpress.XtraEditors.TextEdit
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.RibbonBuscar_MD = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.btnLibroBuscar = New DevComponents.DotNetBar.ButtonX
        Me.txtIdLibro_Bus = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.gDatosMD = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.datefecha = New System.Windows.Forms.DateTimePicker
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtIdlibrodiario = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.TabResumen = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.chkOkRC = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.dgRC1 = New System.Windows.Forms.DataGridView
        Me.dgRC0 = New System.Windows.Forms.DataGridView
        Me.OK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.lblRecibosRC1 = New DevComponents.DotNetBar.LabelX
        Me.lblRecibosRC0 = New DevComponents.DotNetBar.LabelX
        Me.lblCuadreRC = New DevComponents.DotNetBar.LabelX
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.chkOkCE = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.dgCE0 = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dgCE1 = New System.Windows.Forms.DataGridView
        Me.lblRecibosCE1 = New DevComponents.DotNetBar.LabelX
        Me.lblRecibosCE0 = New DevComponents.DotNetBar.LabelX
        Me.lblCuadreCE = New DevComponents.DotNetBar.LabelX
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.SuperTooltip = New DevComponents.DotNetBar.SuperTooltip
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.TabMovimientoDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMovimientoDiario.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.dgFac1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgFac0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpPagosMD.SuspendLayout()
        CType(Me.txtTotalDebitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCreditos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTMovimientoDiario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTPagoTarjetadebitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTPagoEfectivodebitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTCajaMenordebitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpTotalesMD.SuspendLayout()
        CType(Me.txtNcegresoAnulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNfacturasAnulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNrcajaAnulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTcegresoCreditos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNcegresoActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNfacturasActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNrcajaActivos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTfacturasdebito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrcajadebitos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonBuscar_MD.SuspendLayout()
        Me.gDatosMD.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.dgRC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRC0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel4.SuspendLayout()
        CType(Me.dgCE0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCE1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnImprimir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAnular)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.TabMovimientoDiario)
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
        Me.btnNuevo.Location = New System.Drawing.Point(312, 440)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(89, 39)
        Me.btnNuevo.TabIndex = 148
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(217, 440)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(89, 39)
        Me.btnImprimir.TabIndex = 147
        Me.btnImprimir.Text = "IMPRIMIR"
        '
        'btnAnular
        '
        Me.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnular.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.Location = New System.Drawing.Point(122, 440)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(89, 39)
        Me.btnAnular.TabIndex = 146
        Me.btnAnular.Text = "ANULAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(22, 440)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnAdicionar.TabIndex = 10
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(416, 440)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "SALIR"
        '
        'TabMovimientoDiario
        '
        Me.TabMovimientoDiario.BackColor = System.Drawing.Color.Transparent
        Me.TabMovimientoDiario.CanReorderTabs = True
        Me.TabMovimientoDiario.Controls.Add(Me.TabControlPanel3)
        Me.TabMovimientoDiario.Controls.Add(Me.TabControlPanel2)
        Me.TabMovimientoDiario.Controls.Add(Me.TabControlPanel1)
        Me.TabMovimientoDiario.Controls.Add(Me.TabControlPanel4)
        Me.TabMovimientoDiario.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabMovimientoDiario.Location = New System.Drawing.Point(0, 0)
        Me.TabMovimientoDiario.Name = "TabMovimientoDiario"
        Me.TabMovimientoDiario.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabMovimientoDiario.SelectedTabIndex = 0
        Me.TabMovimientoDiario.Size = New System.Drawing.Size(532, 438)
        Me.TabMovimientoDiario.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabMovimientoDiario.TabIndex = 0
        Me.TabMovimientoDiario.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabMovimientoDiario.Tabs.Add(Me.TabItem1)
        Me.TabMovimientoDiario.Tabs.Add(Me.TabItem2)
        Me.TabMovimientoDiario.Tabs.Add(Me.TabItem3)
        Me.TabMovimientoDiario.Tabs.Add(Me.TabResumen)
        Me.TabMovimientoDiario.Text = "TabControl1"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.dgFac1)
        Me.TabControlPanel3.Controls.Add(Me.dgFac0)
        Me.TabControlPanel3.Controls.Add(Me.lblRecibosFac1)
        Me.TabControlPanel3.Controls.Add(Me.lblRecibosFac0)
        Me.TabControlPanel3.Controls.Add(Me.lblCuadreFac)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(532, 416)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem2
        '
        'dgFac1
        '
        Me.dgFac1.AllowUserToAddRows = False
        Me.dgFac1.AllowUserToOrderColumns = True
        Me.dgFac1.AllowUserToResizeColumns = False
        Me.dgFac1.AllowUserToResizeRows = False
        Me.dgFac1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgFac1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgFac1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFac1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgFac1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgFac1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgFac1.EnableHeadersVisualStyles = False
        Me.dgFac1.Location = New System.Drawing.Point(20, 252)
        Me.dgFac1.Name = "dgFac1"
        Me.dgFac1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFac1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgFac1.RowHeadersVisible = False
        Me.dgFac1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFac1.Size = New System.Drawing.Size(490, 160)
        Me.dgFac1.TabIndex = 201
        '
        'dgFac0
        '
        Me.dgFac0.AllowUserToAddRows = False
        Me.dgFac0.AllowUserToOrderColumns = True
        Me.dgFac0.AllowUserToResizeColumns = False
        Me.dgFac0.AllowUserToResizeRows = False
        Me.dgFac0.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgFac0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgFac0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFac0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgFac0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgFac0.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgFac0.EnableHeadersVisualStyles = False
        Me.dgFac0.Location = New System.Drawing.Point(20, 64)
        Me.dgFac0.Name = "dgFac0"
        Me.dgFac0.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFac0.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgFac0.RowHeadersVisible = False
        Me.dgFac0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFac0.Size = New System.Drawing.Size(490, 160)
        Me.dgFac0.TabIndex = 200
        '
        'lblRecibosFac1
        '
        Me.lblRecibosFac1.BackColor = System.Drawing.Color.GreenYellow
        Me.lblRecibosFac1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRecibosFac1.ForeColor = System.Drawing.Color.Navy
        Me.lblRecibosFac1.Location = New System.Drawing.Point(20, 42)
        Me.lblRecibosFac1.Name = "lblRecibosFac1"
        Me.lblRecibosFac1.Size = New System.Drawing.Size(490, 20)
        Me.lblRecibosFac1.TabIndex = 198
        Me.lblRecibosFac1.Text = "FACTURAS CUADRADAS DEL DIA"
        Me.lblRecibosFac1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblRecibosFac0
        '
        Me.lblRecibosFac0.BackColor = System.Drawing.Color.PeachPuff
        Me.lblRecibosFac0.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRecibosFac0.ForeColor = System.Drawing.Color.Navy
        Me.lblRecibosFac0.Location = New System.Drawing.Point(20, 227)
        Me.lblRecibosFac0.Name = "lblRecibosFac0"
        Me.lblRecibosFac0.Size = New System.Drawing.Size(490, 20)
        Me.lblRecibosFac0.TabIndex = 199
        Me.lblRecibosFac0.Text = "FACTURAS  SIN CUADRAR DEL DIA"
        Me.lblRecibosFac0.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblCuadreFac
        '
        Me.lblCuadreFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCuadreFac.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuadreFac.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCuadreFac.Location = New System.Drawing.Point(20, 13)
        Me.lblCuadreFac.Name = "lblCuadreFac"
        Me.lblCuadreFac.Size = New System.Drawing.Size(490, 23)
        Me.lblCuadreFac.TabIndex = 126
        Me.lblCuadreFac.Text = "CUADRE DE FACTURAS"
        Me.lblCuadreFac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel3
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "Facturas"
        Me.TabItem2.Visible = False
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.gpPagosMD)
        Me.TabControlPanel1.Controls.Add(Me.gpTotalesMD)
        Me.TabControlPanel1.Controls.Add(Me.RibbonBuscar_MD)
        Me.TabControlPanel1.Controls.Add(Me.gDatosMD)
        Me.TabControlPanel1.Controls.Add(Me.lblTituloVentana)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 416)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabResumen
        '
        'gpPagosMD
        '
        Me.gpPagosMD.BackColor = System.Drawing.Color.Transparent
        Me.gpPagosMD.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPagosMD.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPagosMD.Controls.Add(Me.txtTotalDebitos)
        Me.gpPagosMD.Controls.Add(Me.txtTotalCreditos)
        Me.gpPagosMD.Controls.Add(Me.LabelX13)
        Me.gpPagosMD.Controls.Add(Me.LabelX20)
        Me.gpPagosMD.Controls.Add(Me.LabelX21)
        Me.gpPagosMD.Controls.Add(Me.txtTMovimientoDiario)
        Me.gpPagosMD.Controls.Add(Me.txtTPagoTarjetadebitos)
        Me.gpPagosMD.Controls.Add(Me.LabelX7)
        Me.gpPagosMD.Controls.Add(Me.txtTPagoEfectivodebitos)
        Me.gpPagosMD.Controls.Add(Me.LabelX16)
        Me.gpPagosMD.Controls.Add(Me.LabelX17)
        Me.gpPagosMD.Controls.Add(Me.txtTCajaMenordebitos)
        Me.gpPagosMD.Controls.Add(Me.LabelX6)
        Me.gpPagosMD.Location = New System.Drawing.Point(20, 230)
        Me.gpPagosMD.Name = "gpPagosMD"
        Me.gpPagosMD.Size = New System.Drawing.Size(490, 179)
        '
        '
        '
        Me.gpPagosMD.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpPagosMD.Style.BackColorGradientAngle = 90
        Me.gpPagosMD.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpPagosMD.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagosMD.Style.BorderBottomWidth = 1
        Me.gpPagosMD.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpPagosMD.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagosMD.Style.BorderLeftWidth = 1
        Me.gpPagosMD.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagosMD.Style.BorderRightWidth = 1
        Me.gpPagosMD.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagosMD.Style.BorderTopWidth = 1
        Me.gpPagosMD.Style.CornerDiameter = 4
        Me.gpPagosMD.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpPagosMD.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpPagosMD.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpPagosMD.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpPagosMD.TabIndex = 149
        '
        'txtTotalDebitos
        '
        Me.txtTotalDebitos.EditValue = "0"
        Me.txtTotalDebitos.Location = New System.Drawing.Point(184, 99)
        Me.txtTotalDebitos.Name = "txtTotalDebitos"
        Me.txtTotalDebitos.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.txtTotalDebitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalDebitos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalDebitos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalDebitos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalDebitos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalDebitos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalDebitos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalDebitos.Properties.Mask.BeepOnError = True
        Me.txtTotalDebitos.Properties.Mask.EditMask = "c0"
        Me.txtTotalDebitos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalDebitos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalDebitos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalDebitos.Size = New System.Drawing.Size(129, 21)
        Me.txtTotalDebitos.TabIndex = 207
        '
        'txtTotalCreditos
        '
        Me.txtTotalCreditos.EditValue = "0"
        Me.txtTotalCreditos.Location = New System.Drawing.Point(335, 99)
        Me.txtTotalCreditos.Name = "txtTotalCreditos"
        Me.txtTotalCreditos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalCreditos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalCreditos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCreditos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCreditos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCreditos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCreditos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotalCreditos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotalCreditos.Properties.Mask.BeepOnError = True
        Me.txtTotalCreditos.Properties.Mask.EditMask = "c0"
        Me.txtTotalCreditos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalCreditos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotalCreditos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalCreditos.Size = New System.Drawing.Size(129, 21)
        Me.txtTotalCreditos.TabIndex = 206
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX13.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX13.ForeColor = System.Drawing.Color.Navy
        Me.LabelX13.Location = New System.Drawing.Point(13, 99)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(164, 20)
        Me.LabelX13.TabIndex = 204
        Me.LabelX13.Text = "Totales"
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX20.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX20.ForeColor = System.Drawing.Color.Navy
        Me.LabelX20.Location = New System.Drawing.Point(335, 3)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(129, 20)
        Me.LabelX20.TabIndex = 203
        Me.LabelX20.Text = "Creditos"
        Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX21.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX21.ForeColor = System.Drawing.Color.Navy
        Me.LabelX21.Location = New System.Drawing.Point(182, 3)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(130, 20)
        Me.LabelX21.TabIndex = 202
        Me.LabelX21.Text = "Debitos"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTMovimientoDiario
        '
        Me.txtTMovimientoDiario.EditValue = "0"
        Me.txtTMovimientoDiario.Location = New System.Drawing.Point(183, 147)
        Me.txtTMovimientoDiario.Name = "txtTMovimientoDiario"
        Me.txtTMovimientoDiario.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTMovimientoDiario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTMovimientoDiario.Properties.Appearance.Options.UseBackColor = True
        Me.txtTMovimientoDiario.Properties.Appearance.Options.UseFont = True
        Me.txtTMovimientoDiario.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTMovimientoDiario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTMovimientoDiario.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTMovimientoDiario.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTMovimientoDiario.Properties.Mask.BeepOnError = True
        Me.txtTMovimientoDiario.Properties.Mask.EditMask = "c0"
        Me.txtTMovimientoDiario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTMovimientoDiario.Properties.Mask.ShowPlaceHolders = False
        Me.txtTMovimientoDiario.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTMovimientoDiario.Size = New System.Drawing.Size(129, 21)
        Me.txtTMovimientoDiario.TabIndex = 199
        '
        'txtTPagoTarjetadebitos
        '
        Me.txtTPagoTarjetadebitos.EditValue = "0"
        Me.txtTPagoTarjetadebitos.Location = New System.Drawing.Point(183, 75)
        Me.txtTPagoTarjetadebitos.Name = "txtTPagoTarjetadebitos"
        Me.txtTPagoTarjetadebitos.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTPagoTarjetadebitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTPagoTarjetadebitos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTPagoTarjetadebitos.Properties.Appearance.Options.UseFont = True
        Me.txtTPagoTarjetadebitos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTPagoTarjetadebitos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTPagoTarjetadebitos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTPagoTarjetadebitos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTPagoTarjetadebitos.Properties.Mask.BeepOnError = True
        Me.txtTPagoTarjetadebitos.Properties.Mask.EditMask = "c0"
        Me.txtTPagoTarjetadebitos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTPagoTarjetadebitos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTPagoTarjetadebitos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTPagoTarjetadebitos.Size = New System.Drawing.Size(129, 21)
        Me.txtTPagoTarjetadebitos.TabIndex = 197
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(13, 74)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(164, 20)
        Me.LabelX7.TabIndex = 196
        Me.LabelX7.Text = "Total Pago con Tarjeta"
        '
        'txtTPagoEfectivodebitos
        '
        Me.txtTPagoEfectivodebitos.EditValue = "0"
        Me.txtTPagoEfectivodebitos.Location = New System.Drawing.Point(183, 51)
        Me.txtTPagoEfectivodebitos.Name = "txtTPagoEfectivodebitos"
        Me.txtTPagoEfectivodebitos.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTPagoEfectivodebitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTPagoEfectivodebitos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTPagoEfectivodebitos.Properties.Appearance.Options.UseFont = True
        Me.txtTPagoEfectivodebitos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTPagoEfectivodebitos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTPagoEfectivodebitos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTPagoEfectivodebitos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTPagoEfectivodebitos.Properties.Mask.BeepOnError = True
        Me.txtTPagoEfectivodebitos.Properties.Mask.EditMask = "c0"
        Me.txtTPagoEfectivodebitos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTPagoEfectivodebitos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTPagoEfectivodebitos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTPagoEfectivodebitos.Size = New System.Drawing.Size(129, 21)
        Me.txtTPagoEfectivodebitos.TabIndex = 195
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX16.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX16.ForeColor = System.Drawing.Color.Navy
        Me.LabelX16.Location = New System.Drawing.Point(13, 50)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(164, 20)
        Me.LabelX16.TabIndex = 192
        Me.LabelX16.Text = "Total en Efectivo"
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX17.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX17.ForeColor = System.Drawing.Color.Navy
        Me.LabelX17.Location = New System.Drawing.Point(13, 147)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(164, 20)
        Me.LabelX17.TabIndex = 193
        Me.LabelX17.Text = "Total Movimiento Diario"
        '
        'txtTCajaMenordebitos
        '
        Me.txtTCajaMenordebitos.EditValue = "0"
        Me.txtTCajaMenordebitos.Location = New System.Drawing.Point(183, 27)
        Me.txtTCajaMenordebitos.Name = "txtTCajaMenordebitos"
        Me.txtTCajaMenordebitos.Properties.Appearance.BackColor = System.Drawing.Color.LawnGreen
        Me.txtTCajaMenordebitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTCajaMenordebitos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTCajaMenordebitos.Properties.Appearance.Options.UseFont = True
        Me.txtTCajaMenordebitos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTCajaMenordebitos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTCajaMenordebitos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTCajaMenordebitos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTCajaMenordebitos.Properties.Mask.BeepOnError = True
        Me.txtTCajaMenordebitos.Properties.Mask.EditMask = "c0"
        Me.txtTCajaMenordebitos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTCajaMenordebitos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTCajaMenordebitos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTCajaMenordebitos.Size = New System.Drawing.Size(129, 21)
        Me.SuperTooltip.SetSuperTooltip(Me.txtTCajaMenordebitos, New DevComponents.DotNetBar.SuperTooltipInfo("Saldo Caja Menor", "Odontoapp", "Saldo de la caja menor podemos editarlo si el libro diario lo estamos creado.", CType(resources.GetObject("txtTCajaMenordebitos.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.txtTCajaMenordebitos.TabIndex = 181
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX6.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX6.ForeColor = System.Drawing.Color.Navy
        Me.LabelX6.Location = New System.Drawing.Point(13, 26)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(164, 20)
        Me.LabelX6.TabIndex = 180
        Me.LabelX6.Text = "Saldo Inicial Caja Menor"
        '
        'gpTotalesMD
        '
        Me.gpTotalesMD.BackColor = System.Drawing.Color.Transparent
        Me.gpTotalesMD.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpTotalesMD.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpTotalesMD.Controls.Add(Me.LabelX19)
        Me.gpTotalesMD.Controls.Add(Me.LabelX18)
        Me.gpTotalesMD.Controls.Add(Me.txtNcegresoAnulados)
        Me.gpTotalesMD.Controls.Add(Me.txtNfacturasAnulados)
        Me.gpTotalesMD.Controls.Add(Me.txtNrcajaAnulados)
        Me.gpTotalesMD.Controls.Add(Me.LabelX12)
        Me.gpTotalesMD.Controls.Add(Me.lblCodigo)
        Me.gpTotalesMD.Controls.Add(Me.txtTcegresoCreditos)
        Me.gpTotalesMD.Controls.Add(Me.txtNcegresoActivos)
        Me.gpTotalesMD.Controls.Add(Me.LabelX11)
        Me.gpTotalesMD.Controls.Add(Me.txtNfacturasActivos)
        Me.gpTotalesMD.Controls.Add(Me.LabelX10)
        Me.gpTotalesMD.Controls.Add(Me.txtNrcajaActivos)
        Me.gpTotalesMD.Controls.Add(Me.LabelX8)
        Me.gpTotalesMD.Controls.Add(Me.txtTfacturasdebito)
        Me.gpTotalesMD.Controls.Add(Me.txtTrcajadebitos)
        Me.gpTotalesMD.Controls.Add(Me.LabelX5)
        Me.gpTotalesMD.Controls.Add(Me.LabelX3)
        Me.gpTotalesMD.Controls.Add(Me.LabelX4)
        Me.gpTotalesMD.Location = New System.Drawing.Point(20, 113)
        Me.gpTotalesMD.Name = "gpTotalesMD"
        Me.gpTotalesMD.Size = New System.Drawing.Size(490, 113)
        '
        '
        '
        Me.gpTotalesMD.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpTotalesMD.Style.BackColorGradientAngle = 90
        Me.gpTotalesMD.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpTotalesMD.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalesMD.Style.BorderBottomWidth = 1
        Me.gpTotalesMD.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpTotalesMD.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalesMD.Style.BorderLeftWidth = 1
        Me.gpTotalesMD.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalesMD.Style.BorderRightWidth = 1
        Me.gpTotalesMD.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpTotalesMD.Style.BorderTopWidth = 1
        Me.gpTotalesMD.Style.CornerDiameter = 4
        Me.gpTotalesMD.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpTotalesMD.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpTotalesMD.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpTotalesMD.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpTotalesMD.TabIndex = 148
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX19.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX19.ForeColor = System.Drawing.Color.Navy
        Me.LabelX19.Location = New System.Drawing.Point(427, 5)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(57, 20)
        Me.LabelX19.TabIndex = 200
        Me.LabelX19.Text = "Anulados"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX18.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(375, 5)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(49, 20)
        Me.LabelX18.TabIndex = 199
        Me.LabelX18.Text = "Activos"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtNcegresoAnulados
        '
        Me.txtNcegresoAnulados.EditValue = "0"
        Me.txtNcegresoAnulados.Location = New System.Drawing.Point(437, 83)
        Me.txtNcegresoAnulados.Name = "txtNcegresoAnulados"
        Me.txtNcegresoAnulados.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.txtNcegresoAnulados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcegresoAnulados.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtNcegresoAnulados.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcegresoAnulados.Properties.Appearance.Options.UseFont = True
        Me.txtNcegresoAnulados.Properties.Appearance.Options.UseForeColor = True
        Me.txtNcegresoAnulados.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcegresoAnulados.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcegresoAnulados.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcegresoAnulados.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcegresoAnulados.Properties.Mask.BeepOnError = True
        Me.txtNcegresoAnulados.Properties.Mask.EditMask = "n0"
        Me.txtNcegresoAnulados.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcegresoAnulados.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcegresoAnulados.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcegresoAnulados.Properties.ReadOnly = True
        Me.txtNcegresoAnulados.Size = New System.Drawing.Size(36, 21)
        Me.txtNcegresoAnulados.TabIndex = 198
        '
        'txtNfacturasAnulados
        '
        Me.txtNfacturasAnulados.EditValue = "0"
        Me.txtNfacturasAnulados.Location = New System.Drawing.Point(437, 57)
        Me.txtNfacturasAnulados.Name = "txtNfacturasAnulados"
        Me.txtNfacturasAnulados.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.txtNfacturasAnulados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNfacturasAnulados.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtNfacturasAnulados.Properties.Appearance.Options.UseBackColor = True
        Me.txtNfacturasAnulados.Properties.Appearance.Options.UseFont = True
        Me.txtNfacturasAnulados.Properties.Appearance.Options.UseForeColor = True
        Me.txtNfacturasAnulados.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNfacturasAnulados.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNfacturasAnulados.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNfacturasAnulados.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNfacturasAnulados.Properties.Mask.BeepOnError = True
        Me.txtNfacturasAnulados.Properties.Mask.EditMask = "n0"
        Me.txtNfacturasAnulados.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNfacturasAnulados.Properties.Mask.ShowPlaceHolders = False
        Me.txtNfacturasAnulados.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNfacturasAnulados.Properties.ReadOnly = True
        Me.txtNfacturasAnulados.Size = New System.Drawing.Size(36, 21)
        Me.txtNfacturasAnulados.TabIndex = 197
        '
        'txtNrcajaAnulados
        '
        Me.txtNrcajaAnulados.EditValue = "0"
        Me.txtNrcajaAnulados.Location = New System.Drawing.Point(437, 31)
        Me.txtNrcajaAnulados.Name = "txtNrcajaAnulados"
        Me.txtNrcajaAnulados.Properties.Appearance.BackColor = System.Drawing.Color.Red
        Me.txtNrcajaAnulados.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNrcajaAnulados.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtNrcajaAnulados.Properties.Appearance.Options.UseBackColor = True
        Me.txtNrcajaAnulados.Properties.Appearance.Options.UseFont = True
        Me.txtNrcajaAnulados.Properties.Appearance.Options.UseForeColor = True
        Me.txtNrcajaAnulados.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNrcajaAnulados.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNrcajaAnulados.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNrcajaAnulados.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNrcajaAnulados.Properties.Mask.BeepOnError = True
        Me.txtNrcajaAnulados.Properties.Mask.EditMask = "n0"
        Me.txtNrcajaAnulados.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNrcajaAnulados.Properties.Mask.ShowPlaceHolders = False
        Me.txtNrcajaAnulados.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNrcajaAnulados.Properties.ReadOnly = True
        Me.txtNrcajaAnulados.Size = New System.Drawing.Size(36, 21)
        Me.txtNrcajaAnulados.TabIndex = 196
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX12.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX12.ForeColor = System.Drawing.Color.Navy
        Me.LabelX12.Location = New System.Drawing.Point(214, 6)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(90, 20)
        Me.LabelX12.TabIndex = 195
        Me.LabelX12.Text = "Creditos"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.Color.LightBlue
        Me.lblCodigo.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCodigo.ForeColor = System.Drawing.Color.Navy
        Me.lblCodigo.Location = New System.Drawing.Point(118, 6)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(90, 20)
        Me.lblCodigo.TabIndex = 194
        Me.lblCodigo.Text = "Debitos"
        Me.lblCodigo.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTcegresoCreditos
        '
        Me.txtTcegresoCreditos.EditValue = "0"
        Me.txtTcegresoCreditos.Location = New System.Drawing.Point(214, 82)
        Me.txtTcegresoCreditos.Name = "txtTcegresoCreditos"
        Me.txtTcegresoCreditos.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTcegresoCreditos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTcegresoCreditos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTcegresoCreditos.Properties.Appearance.Options.UseFont = True
        Me.txtTcegresoCreditos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTcegresoCreditos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTcegresoCreditos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTcegresoCreditos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTcegresoCreditos.Properties.Mask.BeepOnError = True
        Me.txtTcegresoCreditos.Properties.Mask.EditMask = "c0"
        Me.txtTcegresoCreditos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTcegresoCreditos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTcegresoCreditos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTcegresoCreditos.Properties.ReadOnly = True
        Me.txtTcegresoCreditos.Size = New System.Drawing.Size(90, 21)
        Me.txtTcegresoCreditos.TabIndex = 193
        '
        'txtNcegresoActivos
        '
        Me.txtNcegresoActivos.EditValue = "0"
        Me.txtNcegresoActivos.Location = New System.Drawing.Point(389, 83)
        Me.txtNcegresoActivos.Name = "txtNcegresoActivos"
        Me.txtNcegresoActivos.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNcegresoActivos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNcegresoActivos.Properties.Appearance.Options.UseBackColor = True
        Me.txtNcegresoActivos.Properties.Appearance.Options.UseFont = True
        Me.txtNcegresoActivos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNcegresoActivos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNcegresoActivos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNcegresoActivos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNcegresoActivos.Properties.Mask.BeepOnError = True
        Me.txtNcegresoActivos.Properties.Mask.EditMask = "n0"
        Me.txtNcegresoActivos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNcegresoActivos.Properties.Mask.ShowPlaceHolders = False
        Me.txtNcegresoActivos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNcegresoActivos.Properties.ReadOnly = True
        Me.txtNcegresoActivos.Size = New System.Drawing.Size(36, 21)
        Me.txtNcegresoActivos.TabIndex = 189
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX11.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX11.ForeColor = System.Drawing.Color.Navy
        Me.LabelX11.Location = New System.Drawing.Point(313, 83)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(70, 20)
        Me.LabelX11.TabIndex = 188
        Me.LabelX11.Text = "No. Recibos"
        '
        'txtNfacturasActivos
        '
        Me.txtNfacturasActivos.EditValue = "0"
        Me.txtNfacturasActivos.Location = New System.Drawing.Point(389, 57)
        Me.txtNfacturasActivos.Name = "txtNfacturasActivos"
        Me.txtNfacturasActivos.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNfacturasActivos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNfacturasActivos.Properties.Appearance.Options.UseBackColor = True
        Me.txtNfacturasActivos.Properties.Appearance.Options.UseFont = True
        Me.txtNfacturasActivos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNfacturasActivos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNfacturasActivos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNfacturasActivos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNfacturasActivos.Properties.Mask.BeepOnError = True
        Me.txtNfacturasActivos.Properties.Mask.EditMask = "n0"
        Me.txtNfacturasActivos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNfacturasActivos.Properties.Mask.ShowPlaceHolders = False
        Me.txtNfacturasActivos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNfacturasActivos.Properties.ReadOnly = True
        Me.txtNfacturasActivos.Size = New System.Drawing.Size(36, 21)
        Me.txtNfacturasActivos.TabIndex = 187
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX10.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX10.ForeColor = System.Drawing.Color.Navy
        Me.LabelX10.Location = New System.Drawing.Point(313, 57)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(70, 20)
        Me.LabelX10.TabIndex = 186
        Me.LabelX10.Text = "No. Recibos"
        '
        'txtNrcajaActivos
        '
        Me.txtNrcajaActivos.EditValue = "0"
        Me.txtNrcajaActivos.Location = New System.Drawing.Point(389, 31)
        Me.txtNrcajaActivos.Name = "txtNrcajaActivos"
        Me.txtNrcajaActivos.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtNrcajaActivos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNrcajaActivos.Properties.Appearance.Options.UseBackColor = True
        Me.txtNrcajaActivos.Properties.Appearance.Options.UseFont = True
        Me.txtNrcajaActivos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNrcajaActivos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNrcajaActivos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNrcajaActivos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNrcajaActivos.Properties.Mask.BeepOnError = True
        Me.txtNrcajaActivos.Properties.Mask.EditMask = "n0"
        Me.txtNrcajaActivos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNrcajaActivos.Properties.Mask.ShowPlaceHolders = False
        Me.txtNrcajaActivos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNrcajaActivos.Properties.ReadOnly = True
        Me.txtNrcajaActivos.Size = New System.Drawing.Size(36, 21)
        Me.txtNrcajaActivos.TabIndex = 185
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX8.ForeColor = System.Drawing.Color.Navy
        Me.LabelX8.Location = New System.Drawing.Point(313, 31)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(70, 20)
        Me.LabelX8.TabIndex = 184
        Me.LabelX8.Text = "No. Recibos"
        '
        'txtTfacturasdebito
        '
        Me.txtTfacturasdebito.EditValue = "0"
        Me.txtTfacturasdebito.Location = New System.Drawing.Point(118, 56)
        Me.txtTfacturasdebito.Name = "txtTfacturasdebito"
        Me.txtTfacturasdebito.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTfacturasdebito.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTfacturasdebito.Properties.Appearance.Options.UseBackColor = True
        Me.txtTfacturasdebito.Properties.Appearance.Options.UseFont = True
        Me.txtTfacturasdebito.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTfacturasdebito.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTfacturasdebito.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTfacturasdebito.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTfacturasdebito.Properties.Mask.BeepOnError = True
        Me.txtTfacturasdebito.Properties.Mask.EditMask = "c0"
        Me.txtTfacturasdebito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTfacturasdebito.Properties.Mask.ShowPlaceHolders = False
        Me.txtTfacturasdebito.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTfacturasdebito.Properties.ReadOnly = True
        Me.txtTfacturasdebito.Size = New System.Drawing.Size(90, 21)
        Me.txtTfacturasdebito.TabIndex = 178
        '
        'txtTrcajadebitos
        '
        Me.txtTrcajadebitos.EditValue = "0"
        Me.txtTrcajadebitos.Location = New System.Drawing.Point(118, 32)
        Me.txtTrcajadebitos.Name = "txtTrcajadebitos"
        Me.txtTrcajadebitos.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue
        Me.txtTrcajadebitos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTrcajadebitos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTrcajadebitos.Properties.Appearance.Options.UseFont = True
        Me.txtTrcajadebitos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTrcajadebitos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTrcajadebitos.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTrcajadebitos.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTrcajadebitos.Properties.Mask.BeepOnError = True
        Me.txtTrcajadebitos.Properties.Mask.EditMask = "c0"
        Me.txtTrcajadebitos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTrcajadebitos.Properties.Mask.ShowPlaceHolders = False
        Me.txtTrcajadebitos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTrcajadebitos.Properties.ReadOnly = True
        Me.txtTrcajadebitos.Size = New System.Drawing.Size(90, 21)
        Me.txtTrcajadebitos.TabIndex = 177
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX5.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX5.ForeColor = System.Drawing.Color.Navy
        Me.LabelX5.Location = New System.Drawing.Point(6, 82)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(104, 20)
        Me.LabelX5.TabIndex = 137
        Me.LabelX5.Text = "Total C. de Egreso"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(6, 57)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(104, 20)
        Me.LabelX3.TabIndex = 136
        Me.LabelX3.Text = "Total Facturas"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX4.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(6, 34)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(104, 20)
        Me.LabelX4.TabIndex = 135
        Me.LabelX4.Text = "Total R. de Caja"
        '
        'RibbonBuscar_MD
        '
        Me.RibbonBuscar_MD.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonBuscar_MD.Controls.Add(Me.LabelX9)
        Me.RibbonBuscar_MD.Controls.Add(Me.btnLibroBuscar)
        Me.RibbonBuscar_MD.Controls.Add(Me.txtIdLibro_Bus)
        Me.RibbonBuscar_MD.Location = New System.Drawing.Point(20, 33)
        Me.RibbonBuscar_MD.Name = "RibbonBuscar_MD"
        Me.RibbonBuscar_MD.Size = New System.Drawing.Size(214, 75)
        '
        '
        '
        Me.RibbonBuscar_MD.Style.Class = "RibbonClientPanel"
        Me.RibbonBuscar_MD.TabIndex = 147
        Me.RibbonBuscar_MD.Text = "RibbonClientPanel2"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX9.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX9.ForeColor = System.Drawing.Color.Navy
        Me.LabelX9.Location = New System.Drawing.Point(14, 13)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(104, 20)
        Me.LabelX9.TabIndex = 145
        Me.LabelX9.Text = "Buscar Movimiento"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnLibroBuscar
        '
        Me.btnLibroBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLibroBuscar.Image = CType(resources.GetObject("btnLibroBuscar.Image"), System.Drawing.Image)
        Me.btnLibroBuscar.Location = New System.Drawing.Point(126, 13)
        Me.btnLibroBuscar.Name = "btnLibroBuscar"
        Me.btnLibroBuscar.Size = New System.Drawing.Size(76, 46)
        Me.btnLibroBuscar.TabIndex = 144
        Me.btnLibroBuscar.Text = "BUSCAR"
        '
        'txtIdLibro_Bus
        '
        '
        '
        '
        Me.txtIdLibro_Bus.Border.Class = "TextBoxBorder"
        Me.txtIdLibro_Bus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdLibro_Bus.Location = New System.Drawing.Point(14, 39)
        Me.txtIdLibro_Bus.Name = "txtIdLibro_Bus"
        Me.txtIdLibro_Bus.Size = New System.Drawing.Size(104, 20)
        Me.txtIdLibro_Bus.TabIndex = 128
        '
        'gDatosMD
        '
        Me.gDatosMD.BackColor = System.Drawing.Color.Transparent
        Me.gDatosMD.CanvasColor = System.Drawing.SystemColors.Control
        Me.gDatosMD.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gDatosMD.Controls.Add(Me.datefecha)
        Me.gDatosMD.Controls.Add(Me.LabelX2)
        Me.gDatosMD.Controls.Add(Me.txtIdlibrodiario)
        Me.gDatosMD.Controls.Add(Me.LabelX1)
        Me.gDatosMD.Location = New System.Drawing.Point(240, 32)
        Me.gDatosMD.Name = "gDatosMD"
        Me.gDatosMD.Size = New System.Drawing.Size(270, 75)
        '
        '
        '
        Me.gDatosMD.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gDatosMD.Style.BackColorGradientAngle = 90
        Me.gDatosMD.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gDatosMD.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gDatosMD.Style.BorderBottomWidth = 1
        Me.gDatosMD.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gDatosMD.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gDatosMD.Style.BorderLeftWidth = 1
        Me.gDatosMD.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gDatosMD.Style.BorderRightWidth = 1
        Me.gDatosMD.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gDatosMD.Style.BorderTopWidth = 1
        Me.gDatosMD.Style.CornerDiameter = 4
        Me.gDatosMD.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gDatosMD.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gDatosMD.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gDatosMD.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gDatosMD.TabIndex = 125
        Me.gDatosMD.Text = "Datos Movimiento Diario"
        '
        'datefecha
        '
        Me.datefecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datefecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datefecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datefecha.Location = New System.Drawing.Point(133, 29)
        Me.datefecha.Name = "datefecha"
        Me.datefecha.Size = New System.Drawing.Size(120, 20)
        Me.datefecha.TabIndex = 148
        Me.datefecha.Tag = "0"
        Me.datefecha.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(8, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(119, 20)
        Me.LabelX2.TabIndex = 136
        Me.LabelX2.Text = "Fecha Movimiento"
        '
        'txtIdlibrodiario
        '
        '
        '
        '
        Me.txtIdlibrodiario.Border.Class = "TextBoxBorder"
        Me.txtIdlibrodiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdlibrodiario.Location = New System.Drawing.Point(133, 3)
        Me.txtIdlibrodiario.Name = "txtIdlibrodiario"
        Me.txtIdlibrodiario.Size = New System.Drawing.Size(120, 20)
        Me.txtIdlibrodiario.TabIndex = 134
        Me.txtIdlibrodiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(8, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(119, 20)
        Me.LabelX1.TabIndex = 135
        Me.LabelX1.Text = "No. Movimiento Diario"
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(20, 4)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(490, 23)
        Me.lblTituloVentana.TabIndex = 124
        Me.lblTituloVentana.Text = "LIBRO DE MOVIMIENTOS DIARIO"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabResumen
        '
        Me.TabResumen.AttachedControl = Me.TabControlPanel1
        Me.TabResumen.Name = "TabResumen"
        Me.TabResumen.Text = "Resumen"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.chkOkRC)
        Me.TabControlPanel2.Controls.Add(Me.dgRC1)
        Me.TabControlPanel2.Controls.Add(Me.dgRC0)
        Me.TabControlPanel2.Controls.Add(Me.lblRecibosRC1)
        Me.TabControlPanel2.Controls.Add(Me.lblRecibosRC0)
        Me.TabControlPanel2.Controls.Add(Me.lblCuadreRC)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 416)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem1
        '
        'chkOkRC
        '
        Me.chkOkRC.BackColor = System.Drawing.Color.Transparent
        Me.chkOkRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOkRC.Location = New System.Drawing.Point(22, 229)
        Me.chkOkRC.Name = "chkOkRC"
        Me.chkOkRC.Size = New System.Drawing.Size(45, 16)
        Me.chkOkRC.TabIndex = 199
        Me.chkOkRC.Text = "OK"
        Me.chkOkRC.TextColor = System.Drawing.Color.Black
        '
        'dgRC1
        '
        Me.dgRC1.AllowUserToAddRows = False
        Me.dgRC1.AllowUserToDeleteRows = False
        Me.dgRC1.AllowUserToResizeColumns = False
        Me.dgRC1.AllowUserToResizeRows = False
        Me.dgRC1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRC1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgRC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRC1.EnableHeadersVisualStyles = False
        Me.dgRC1.Location = New System.Drawing.Point(20, 65)
        Me.dgRC1.MultiSelect = False
        Me.dgRC1.Name = "dgRC1"
        Me.dgRC1.ReadOnly = True
        Me.dgRC1.RowHeadersVisible = False
        Me.dgRC1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgRC1.Size = New System.Drawing.Size(490, 155)
        Me.dgRC1.TabIndex = 198
        '
        'dgRC0
        '
        Me.dgRC0.AllowUserToAddRows = False
        Me.dgRC0.AllowUserToDeleteRows = False
        Me.dgRC0.AllowUserToResizeColumns = False
        Me.dgRC0.AllowUserToResizeRows = False
        Me.dgRC0.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRC0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRC0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRC0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgRC0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRC0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OK})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRC0.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgRC0.EnableHeadersVisualStyles = False
        Me.dgRC0.Location = New System.Drawing.Point(20, 251)
        Me.dgRC0.MultiSelect = False
        Me.dgRC0.Name = "dgRC0"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRC0.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgRC0.RowHeadersVisible = False
        Me.dgRC0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgRC0.Size = New System.Drawing.Size(490, 160)
        Me.dgRC0.TabIndex = 197
        '
        'OK
        '
        Me.OK.FalseValue = "0"
        Me.OK.HeaderText = "OK"
        Me.OK.Name = "OK"
        Me.OK.TrueValue = "1"
        Me.OK.Width = 50
        '
        'lblRecibosRC1
        '
        Me.lblRecibosRC1.BackColor = System.Drawing.Color.GreenYellow
        Me.lblRecibosRC1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRecibosRC1.ForeColor = System.Drawing.Color.Navy
        Me.lblRecibosRC1.Location = New System.Drawing.Point(20, 40)
        Me.lblRecibosRC1.Name = "lblRecibosRC1"
        Me.lblRecibosRC1.Size = New System.Drawing.Size(490, 20)
        Me.lblRecibosRC1.TabIndex = 195
        Me.lblRecibosRC1.Text = "RECIBOS DE CAJA CUADRADOS DEL DIA"
        Me.lblRecibosRC1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblRecibosRC0
        '
        Me.lblRecibosRC0.BackColor = System.Drawing.Color.PeachPuff
        Me.lblRecibosRC0.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRecibosRC0.ForeColor = System.Drawing.Color.Navy
        Me.lblRecibosRC0.Location = New System.Drawing.Point(20, 227)
        Me.lblRecibosRC0.Name = "lblRecibosRC0"
        Me.lblRecibosRC0.Size = New System.Drawing.Size(490, 20)
        Me.lblRecibosRC0.TabIndex = 195
        Me.lblRecibosRC0.Text = "RECIBOS DE CAJA  SIN CUADRAR DEL DIA"
        Me.lblRecibosRC0.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblCuadreRC
        '
        Me.lblCuadreRC.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCuadreRC.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuadreRC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCuadreRC.Location = New System.Drawing.Point(20, 13)
        Me.lblCuadreRC.Name = "lblCuadreRC"
        Me.lblCuadreRC.Size = New System.Drawing.Size(490, 23)
        Me.lblCuadreRC.TabIndex = 125
        Me.lblCuadreRC.Text = "CUADRE DE RECIBOS DE CAJA"
        Me.lblCuadreRC.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel2
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Recibos de Caja "
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Controls.Add(Me.chkOkCE)
        Me.TabControlPanel4.Controls.Add(Me.dgCE0)
        Me.TabControlPanel4.Controls.Add(Me.dgCE1)
        Me.TabControlPanel4.Controls.Add(Me.lblRecibosCE1)
        Me.TabControlPanel4.Controls.Add(Me.lblRecibosCE0)
        Me.TabControlPanel4.Controls.Add(Me.lblCuadreCE)
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(532, 416)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem3
        '
        'chkOkCE
        '
        Me.chkOkCE.BackColor = System.Drawing.Color.Transparent
        Me.chkOkCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOkCE.Location = New System.Drawing.Point(21, 230)
        Me.chkOkCE.Name = "chkOkCE"
        Me.chkOkCE.Size = New System.Drawing.Size(45, 16)
        Me.chkOkCE.TabIndex = 200
        Me.chkOkCE.Text = "OK"
        Me.chkOkCE.TextColor = System.Drawing.Color.Black
        '
        'dgCE0
        '
        Me.dgCE0.AllowUserToAddRows = False
        Me.dgCE0.AllowUserToDeleteRows = False
        Me.dgCE0.AllowUserToResizeColumns = False
        Me.dgCE0.AllowUserToResizeRows = False
        Me.dgCE0.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCE0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCE0.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCE0.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgCE0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCE0.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCE0.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgCE0.EnableHeadersVisualStyles = False
        Me.dgCE0.Location = New System.Drawing.Point(19, 253)
        Me.dgCE0.MultiSelect = False
        Me.dgCE0.Name = "dgCE0"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCE0.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgCE0.RowHeadersVisible = False
        Me.dgCE0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgCE0.Size = New System.Drawing.Size(490, 156)
        Me.dgCE0.TabIndex = 206
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.FalseValue = "0"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "OK"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.TrueValue = "1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'dgCE1
        '
        Me.dgCE1.AllowUserToAddRows = False
        Me.dgCE1.AllowUserToOrderColumns = True
        Me.dgCE1.AllowUserToResizeColumns = False
        Me.dgCE1.AllowUserToResizeRows = False
        Me.dgCE1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCE1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCE1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCE1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgCE1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCE1.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgCE1.EnableHeadersVisualStyles = False
        Me.dgCE1.Location = New System.Drawing.Point(20, 63)
        Me.dgCE1.Name = "dgCE1"
        Me.dgCE1.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCE1.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgCE1.RowHeadersVisible = False
        Me.dgCE1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCE1.Size = New System.Drawing.Size(490, 160)
        Me.dgCE1.TabIndex = 205
        '
        'lblRecibosCE1
        '
        Me.lblRecibosCE1.BackColor = System.Drawing.Color.GreenYellow
        Me.lblRecibosCE1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRecibosCE1.ForeColor = System.Drawing.Color.Navy
        Me.lblRecibosCE1.Location = New System.Drawing.Point(20, 40)
        Me.lblRecibosCE1.Name = "lblRecibosCE1"
        Me.lblRecibosCE1.Size = New System.Drawing.Size(490, 20)
        Me.lblRecibosCE1.TabIndex = 202
        Me.lblRecibosCE1.Text = "C. EGRESO CUADRADOS DEL DIA"
        Me.lblRecibosCE1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblRecibosCE0
        '
        Me.lblRecibosCE0.BackColor = System.Drawing.Color.PeachPuff
        Me.lblRecibosCE0.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRecibosCE0.ForeColor = System.Drawing.Color.Navy
        Me.lblRecibosCE0.Location = New System.Drawing.Point(20, 228)
        Me.lblRecibosCE0.Name = "lblRecibosCE0"
        Me.lblRecibosCE0.Size = New System.Drawing.Size(490, 20)
        Me.lblRecibosCE0.TabIndex = 203
        Me.lblRecibosCE0.Text = "C. EGRESO  SIN CUADRAR DEL DIA"
        Me.lblRecibosCE0.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblCuadreCE
        '
        Me.lblCuadreCE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCuadreCE.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuadreCE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCuadreCE.Location = New System.Drawing.Point(20, 13)
        Me.lblCuadreCE.Name = "lblCuadreCE"
        Me.lblCuadreCE.Size = New System.Drawing.Size(490, 23)
        Me.lblCuadreCE.TabIndex = 127
        Me.lblCuadreCE.Text = "CUADRE DE C. EGRESO"
        Me.lblCuadreCE.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel4
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "C. Egreso"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frmMovimientoDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMovimientoDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Movimiento Diario"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.TabMovimientoDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMovimientoDiario.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.dgFac1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgFac0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.gpPagosMD.ResumeLayout(False)
        CType(Me.txtTotalDebitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCreditos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTMovimientoDiario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTPagoTarjetadebitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTPagoEfectivodebitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTCajaMenordebitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpTotalesMD.ResumeLayout(False)
        CType(Me.txtNcegresoAnulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNfacturasAnulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNrcajaAnulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTcegresoCreditos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNcegresoActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNfacturasActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNrcajaActivos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTfacturasdebito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrcajadebitos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonBuscar_MD.ResumeLayout(False)
        Me.gDatosMD.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.dgRC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRC0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel4.ResumeLayout(False)
        CType(Me.dgCE0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCE1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents TabMovimientoDiario As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabResumen As DevComponents.DotNetBar.TabItem
    Friend WithEvents gDatosMD As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdlibrodiario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RibbonBuscar_MD As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnLibroBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIdLibro_Bus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents datefecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gpTotalesMD As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTCajaMenordebitos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTfacturasdebito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTrcajadebitos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNcegresoActivos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNfacturasActivos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNrcajaActivos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents lblCuadreFac As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCuadreCE As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCuadreRC As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpPagosMD As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtTPagoEfectivodebitos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTPagoTarjetadebitos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTMovimientoDiario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTcegresoCreditos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCodigo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNcegresoAnulados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNfacturasAnulados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNrcajaAnulados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblRecibosRC1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblRecibosRC0 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgFac1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgFac0 As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecibosFac1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblRecibosFac0 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCE1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblRecibosCE1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblRecibosCE0 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgRC0 As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents SuperTooltip As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents dgRC1 As System.Windows.Forms.DataGridView
    Friend WithEvents OK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkOkRC As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtTotalCreditos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCE0 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkOkCE As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtTotalDebitos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAnular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
End Class
