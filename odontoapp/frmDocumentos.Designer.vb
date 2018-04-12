<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentos))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prestacion de Servicios - SCO")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contratos", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("C. Informado - SCO")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consentimiento 2")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Confirmacion del Consentimiento")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sistema Atencion al Cliente")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consentimientos", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Beneficios y Recomendaciones")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Otros Documentos", New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.TabDocumentos = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem5 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnDocumento_Beneficios = New DevComponents.DotNetBar.ButtonX
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnDocumento_CINFO_SCO = New DevComponents.DotNetBar.ButtonX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtdedoc_pac2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.txtnumdoc_pac2 = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX
        Me.txtnombre_pac2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX
        Me.Tab_ConsInfo_SCO = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.btnDocumento_CPS_SCO = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.GroupTotalDatosDoc = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtNCuotaIni = New DevExpress.XtraEditors.TextEdit
        Me.txtCiudad = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.txtVMulta = New DevExpress.XtraEditors.TextEdit
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.txtVTuboM = New DevExpress.XtraEditors.TextEdit
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.txtVBracket = New DevExpress.XtraEditors.TextEdit
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.txtVCuotaMen = New DevExpress.XtraEditors.TextEdit
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.txtNCuotaMen = New DevExpress.XtraEditors.TextEdit
        Me.lblNCuotasMen = New DevComponents.DotNetBar.LabelX
        Me.txtVCuotaIni = New DevExpress.XtraEditors.TextEdit
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.txtMesesDiag = New DevExpress.XtraEditors.TextEdit
        Me.txtCostoTrat = New DevExpress.XtraEditors.TextEdit
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.txtdedoc_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtnumdoc_pac = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtnombre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.dateDocumento = New System.Windows.Forms.DateTimePicker
        Me.lblNomPaciente = New DevComponents.DotNetBar.LabelX
        Me.Tab_pservcso = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel7 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem7 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem6 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.TreeDocumentos = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProviderpac = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.TabDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDocumentos.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupTotalDatosDoc.SuspendLayout()
        CType(Me.txtNCuotaIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVMulta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVTuboM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVBracket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVCuotaMen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNCuotaMen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVCuotaIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMesesDiag.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCostoTrat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderpac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.TabDocumentos)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.TreeDocumentos)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(532, 486)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 1
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'TabDocumentos
        '
        Me.TabDocumentos.CanReorderTabs = False
        Me.TabDocumentos.Controls.Add(Me.TabControlPanel1)
        Me.TabDocumentos.Controls.Add(Me.TabControlPanel3)
        Me.TabDocumentos.Controls.Add(Me.TabControlPanel4)
        Me.TabDocumentos.Controls.Add(Me.TabControlPanel2)
        Me.TabDocumentos.Controls.Add(Me.TabControlPanel5)
        Me.TabDocumentos.Controls.Add(Me.TabControlPanel7)
        Me.TabDocumentos.Controls.Add(Me.TabControlPanel6)
        Me.TabDocumentos.Location = New System.Drawing.Point(174, 54)
        Me.TabDocumentos.Name = "TabDocumentos"
        Me.TabDocumentos.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabDocumentos.SelectedTabIndex = 3
        Me.TabDocumentos.Size = New System.Drawing.Size(347, 372)
        Me.TabDocumentos.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabDocumentos.TabIndex = 128
        Me.TabDocumentos.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabDocumentos.Tabs.Add(Me.Tab_pservcso)
        Me.TabDocumentos.Tabs.Add(Me.Tab_ConsInfo_SCO)
        Me.TabDocumentos.Tabs.Add(Me.TabItem3)
        Me.TabDocumentos.Tabs.Add(Me.TabItem4)
        Me.TabDocumentos.Tabs.Add(Me.TabItem5)
        Me.TabDocumentos.Tabs.Add(Me.TabItem6)
        Me.TabDocumentos.Tabs.Add(Me.TabItem7)
        Me.TabDocumentos.TabsVisible = False
        Me.TabDocumentos.Text = "TabControl"
        Me.TabDocumentos.ThemeAware = True
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(347, 350)
        Me.TabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel5.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel5.Style.GradientAngle = 90
        Me.TabControlPanel5.TabIndex = 5
        Me.TabControlPanel5.TabItem = Me.TabItem5
        '
        'TabItem5
        '
        Me.TabItem5.AttachedControl = Me.TabControlPanel5
        Me.TabItem5.Name = "TabItem5"
        Me.TabItem5.Text = "TabItem5"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(347, 350)
        Me.TabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel4.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel4.Style.GradientAngle = 90
        Me.TabControlPanel4.TabIndex = 4
        Me.TabControlPanel4.TabItem = Me.TabItem4
        '
        'TabItem4
        '
        Me.TabItem4.AttachedControl = Me.TabControlPanel4
        Me.TabItem4.Name = "TabItem4"
        Me.TabItem4.Text = "TabItem4"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.btnDocumento_Beneficios)
        Me.TabControlPanel3.Controls.Add(Me.LabelX17)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(347, 350)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 3
        Me.TabControlPanel3.TabItem = Me.TabItem3
        '
        'btnDocumento_Beneficios
        '
        Me.btnDocumento_Beneficios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDocumento_Beneficios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumento_Beneficios.Image = CType(resources.GetObject("btnDocumento_Beneficios.Image"), System.Drawing.Image)
        Me.btnDocumento_Beneficios.Location = New System.Drawing.Point(81, 82)
        Me.btnDocumento_Beneficios.Name = "btnDocumento_Beneficios"
        Me.btnDocumento_Beneficios.Size = New System.Drawing.Size(199, 36)
        Me.btnDocumento_Beneficios.TabIndex = 123
        Me.btnDocumento_Beneficios.Text = "GENERAR DOCUMENTO"
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelX17.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX17.Location = New System.Drawing.Point(16, 10)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(321, 23)
        Me.LabelX17.TabIndex = 119
        Me.LabelX17.Text = "BENEFICIOS Y RECOMENDACIONES"
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "Beneficios"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.btnDocumento_CINFO_SCO)
        Me.TabControlPanel2.Controls.Add(Me.LabelX15)
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(347, 350)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.Tab_ConsInfo_SCO
        '
        'btnDocumento_CINFO_SCO
        '
        Me.btnDocumento_CINFO_SCO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDocumento_CINFO_SCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumento_CINFO_SCO.Image = CType(resources.GetObject("btnDocumento_CINFO_SCO.Image"), System.Drawing.Image)
        Me.btnDocumento_CINFO_SCO.Location = New System.Drawing.Point(80, 292)
        Me.btnDocumento_CINFO_SCO.Name = "btnDocumento_CINFO_SCO"
        Me.btnDocumento_CINFO_SCO.Size = New System.Drawing.Size(199, 36)
        Me.btnDocumento_CINFO_SCO.TabIndex = 122
        Me.btnDocumento_CINFO_SCO.Text = "GENERAR DOCUMENTO"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelX15.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX15.Location = New System.Drawing.Point(16, 10)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(321, 23)
        Me.LabelX15.TabIndex = 121
        Me.LabelX15.Text = "CONSENTIMIENTO DE INFORMADO"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtdedoc_pac2)
        Me.GroupPanel1.Controls.Add(Me.LabelX18)
        Me.GroupPanel1.Controls.Add(Me.txtnumdoc_pac2)
        Me.GroupPanel1.Controls.Add(Me.LabelX28)
        Me.GroupPanel1.Controls.Add(Me.txtnombre_pac2)
        Me.GroupPanel1.Controls.Add(Me.LabelX30)
        Me.GroupPanel1.Location = New System.Drawing.Point(16, 40)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(321, 228)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 120
        Me.GroupPanel1.Tag = ""
        Me.GroupPanel1.Text = "Datos para el Documento"
        '
        'txtdedoc_pac2
        '
        '
        '
        '
        Me.txtdedoc_pac2.Border.Class = "TextBoxBorder"
        Me.txtdedoc_pac2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdedoc_pac2.Location = New System.Drawing.Point(106, 100)
        Me.txtdedoc_pac2.Name = "txtdedoc_pac2"
        Me.txtdedoc_pac2.Size = New System.Drawing.Size(126, 20)
        Me.txtdedoc_pac2.TabIndex = 114
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX18.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(6, 100)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(99, 20)
        Me.LabelX18.TabIndex = 113
        Me.LabelX18.Text = "de"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtnumdoc_pac2
        '
        Me.txtnumdoc_pac2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtnumdoc_pac2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtnumdoc_pac2.DecimalDigits = 0
        Me.txtnumdoc_pac2.Location = New System.Drawing.Point(106, 74)
        Me.txtnumdoc_pac2.Name = "txtnumdoc_pac2"
        Me.txtnumdoc_pac2.Size = New System.Drawing.Size(126, 20)
        Me.txtnumdoc_pac2.TabIndex = 112
        Me.txtnumdoc_pac2.Text = "0"
        Me.txtnumdoc_pac2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'LabelX28
        '
        Me.LabelX28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX28.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX28.ForeColor = System.Drawing.Color.Navy
        Me.LabelX28.Location = New System.Drawing.Point(6, 73)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(99, 20)
        Me.LabelX28.TabIndex = 111
        Me.LabelX28.Text = "Doc. de Identidad"
        Me.LabelX28.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtnombre_pac2
        '
        '
        '
        '
        Me.txtnombre_pac2.Border.Class = "TextBoxBorder"
        Me.txtnombre_pac2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre_pac2.Location = New System.Drawing.Point(6, 49)
        Me.txtnombre_pac2.Name = "txtnombre_pac2"
        Me.txtnombre_pac2.Size = New System.Drawing.Size(306, 20)
        Me.txtnombre_pac2.TabIndex = 110
        '
        'LabelX30
        '
        Me.LabelX30.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX30.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX30.ForeColor = System.Drawing.Color.Navy
        Me.LabelX30.Location = New System.Drawing.Point(6, 27)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(197, 20)
        Me.LabelX30.TabIndex = 107
        Me.LabelX30.Text = "Nombre del Paciente o Representante"
        '
        'Tab_ConsInfo_SCO
        '
        Me.Tab_ConsInfo_SCO.AttachedControl = Me.TabControlPanel2
        Me.Tab_ConsInfo_SCO.Name = "Tab_ConsInfo_SCO"
        Me.Tab_ConsInfo_SCO.Text = "ConsInfo_SCO"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.btnAdicionar)
        Me.TabControlPanel1.Controls.Add(Me.btnDocumento_CPS_SCO)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.GroupTotalDatosDoc)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(347, 350)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.Tab_pservcso
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(8, 306)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 33)
        Me.btnAdicionar.TabIndex = 120
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'btnDocumento_CPS_SCO
        '
        Me.btnDocumento_CPS_SCO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDocumento_CPS_SCO.Enabled = False
        Me.btnDocumento_CPS_SCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumento_CPS_SCO.Image = CType(resources.GetObject("btnDocumento_CPS_SCO.Image"), System.Drawing.Image)
        Me.btnDocumento_CPS_SCO.Location = New System.Drawing.Point(130, 306)
        Me.btnDocumento_CPS_SCO.Name = "btnDocumento_CPS_SCO"
        Me.btnDocumento_CPS_SCO.Size = New System.Drawing.Size(199, 36)
        Me.btnDocumento_CPS_SCO.TabIndex = 119
        Me.btnDocumento_CPS_SCO.Text = "GENERAR DOCUMENTO"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelX1.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX1.Location = New System.Drawing.Point(11, 10)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(321, 23)
        Me.LabelX1.TabIndex = 118
        Me.LabelX1.Text = "CONTRATO PRESTACION DE SERVICIOS - SCO"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupTotalDatosDoc
        '
        Me.GroupTotalDatosDoc.BackColor = System.Drawing.Color.Transparent
        Me.GroupTotalDatosDoc.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupTotalDatosDoc.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtNCuotaIni)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtCiudad)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX10)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtVMulta)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX14)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtVTuboM)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX13)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtVBracket)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX12)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtVCuotaMen)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX11)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtNCuotaMen)
        Me.GroupTotalDatosDoc.Controls.Add(Me.lblNCuotasMen)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtVCuotaIni)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX8)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX7)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtMesesDiag)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtCostoTrat)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX6)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtdedoc_pac)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX5)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX4)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtnumdoc_pac)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX3)
        Me.GroupTotalDatosDoc.Controls.Add(Me.txtnombre_pac)
        Me.GroupTotalDatosDoc.Controls.Add(Me.LabelX2)
        Me.GroupTotalDatosDoc.Controls.Add(Me.dateDocumento)
        Me.GroupTotalDatosDoc.Controls.Add(Me.lblNomPaciente)
        Me.GroupTotalDatosDoc.Location = New System.Drawing.Point(8, 42)
        Me.GroupTotalDatosDoc.Name = "GroupTotalDatosDoc"
        Me.GroupTotalDatosDoc.Size = New System.Drawing.Size(330, 262)
        '
        '
        '
        Me.GroupTotalDatosDoc.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupTotalDatosDoc.Style.BackColorGradientAngle = 90
        Me.GroupTotalDatosDoc.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupTotalDatosDoc.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalDatosDoc.Style.BorderBottomWidth = 1
        Me.GroupTotalDatosDoc.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupTotalDatosDoc.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalDatosDoc.Style.BorderLeftWidth = 1
        Me.GroupTotalDatosDoc.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalDatosDoc.Style.BorderRightWidth = 1
        Me.GroupTotalDatosDoc.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalDatosDoc.Style.BorderTopWidth = 1
        Me.GroupTotalDatosDoc.Style.CornerDiameter = 4
        Me.GroupTotalDatosDoc.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupTotalDatosDoc.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupTotalDatosDoc.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupTotalDatosDoc.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupTotalDatosDoc.TabIndex = 117
        Me.GroupTotalDatosDoc.Tag = ""
        Me.GroupTotalDatosDoc.Text = "Datos para el Documento"
        '
        'txtNCuotaIni
        '
        Me.txtNCuotaIni.EditValue = "0"
        Me.txtNCuotaIni.Location = New System.Drawing.Point(122, 121)
        Me.txtNCuotaIni.Name = "txtNCuotaIni"
        Me.txtNCuotaIni.Properties.DisplayFormat.FormatString = "d2"
        Me.txtNCuotaIni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNCuotaIni.Properties.EditFormat.FormatString = "d2"
        Me.txtNCuotaIni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNCuotaIni.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtNCuotaIni.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNCuotaIni.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNCuotaIni.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.txtNCuotaIni.Properties.Mask.BeepOnError = True
        Me.txtNCuotaIni.Properties.Mask.EditMask = "d2"
        Me.txtNCuotaIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNCuotaIni.Properties.Mask.ShowPlaceHolders = False
        Me.txtNCuotaIni.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNCuotaIni.Size = New System.Drawing.Size(26, 20)
        Me.txtNCuotaIni.TabIndex = 140
        '
        'txtCiudad
        '
        '
        '
        '
        Me.txtCiudad.Border.Class = "TextBoxBorder"
        Me.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCiudad.Location = New System.Drawing.Point(213, 25)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(108, 20)
        Me.txtCiudad.TabIndex = 137
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX10.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX10.ForeColor = System.Drawing.Color.Navy
        Me.LabelX10.Location = New System.Drawing.Point(213, 3)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(108, 20)
        Me.LabelX10.TabIndex = 136
        Me.LabelX10.Text = "Ciudad"
        '
        'txtVMulta
        '
        Me.txtVMulta.EditValue = "0"
        Me.txtVMulta.Location = New System.Drawing.Point(153, 175)
        Me.txtVMulta.Name = "txtVMulta"
        Me.txtVMulta.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVMulta.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVMulta.Properties.Mask.BeepOnError = True
        Me.txtVMulta.Properties.Mask.EditMask = "c0"
        Me.txtVMulta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVMulta.Properties.Mask.ShowPlaceHolders = False
        Me.txtVMulta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVMulta.Size = New System.Drawing.Size(81, 20)
        Me.txtVMulta.TabIndex = 135
        '
        'LabelX14
        '
        Me.LabelX14.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX14.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX14.ForeColor = System.Drawing.Color.Navy
        Me.LabelX14.Location = New System.Drawing.Point(63, 175)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(87, 20)
        Me.LabelX14.TabIndex = 134
        Me.LabelX14.Text = "V. Multa"
        '
        'txtVTuboM
        '
        Me.txtVTuboM.EditValue = "0"
        Me.txtVTuboM.Location = New System.Drawing.Point(241, 211)
        Me.txtVTuboM.Name = "txtVTuboM"
        Me.txtVTuboM.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVTuboM.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVTuboM.Properties.Mask.BeepOnError = True
        Me.txtVTuboM.Properties.Mask.EditMask = "c0"
        Me.txtVTuboM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVTuboM.Properties.Mask.ShowPlaceHolders = False
        Me.txtVTuboM.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVTuboM.Size = New System.Drawing.Size(80, 20)
        Me.txtVTuboM.TabIndex = 133
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX13.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX13.ForeColor = System.Drawing.Color.Navy
        Me.LabelX13.Location = New System.Drawing.Point(172, 211)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(68, 20)
        Me.LabelX13.TabIndex = 132
        Me.LabelX13.Text = "V. Tubo Mol."
        '
        'txtVBracket
        '
        Me.txtVBracket.EditValue = "0"
        Me.txtVBracket.Location = New System.Drawing.Point(74, 211)
        Me.txtVBracket.Name = "txtVBracket"
        Me.txtVBracket.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVBracket.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVBracket.Properties.Mask.BeepOnError = True
        Me.txtVBracket.Properties.Mask.EditMask = "c0"
        Me.txtVBracket.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVBracket.Properties.Mask.ShowPlaceHolders = False
        Me.txtVBracket.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVBracket.Size = New System.Drawing.Size(80, 20)
        Me.txtVBracket.TabIndex = 131
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX12.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX12.ForeColor = System.Drawing.Color.Navy
        Me.LabelX12.Location = New System.Drawing.Point(6, 211)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(62, 20)
        Me.LabelX12.TabIndex = 130
        Me.LabelX12.Text = "V. Bracket"
        '
        'txtVCuotaMen
        '
        Me.txtVCuotaMen.EditValue = "0"
        Me.txtVCuotaMen.Location = New System.Drawing.Point(242, 144)
        Me.txtVCuotaMen.Name = "txtVCuotaMen"
        Me.txtVCuotaMen.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVCuotaMen.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVCuotaMen.Properties.Mask.BeepOnError = True
        Me.txtVCuotaMen.Properties.Mask.EditMask = "c0"
        Me.txtVCuotaMen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVCuotaMen.Properties.Mask.ShowPlaceHolders = False
        Me.txtVCuotaMen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVCuotaMen.Size = New System.Drawing.Size(79, 20)
        Me.txtVCuotaMen.TabIndex = 129
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX11.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX11.ForeColor = System.Drawing.Color.Navy
        Me.LabelX11.Location = New System.Drawing.Point(153, 144)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(87, 20)
        Me.LabelX11.TabIndex = 128
        Me.LabelX11.Text = "V. Cuota Men."
        '
        'txtNCuotaMen
        '
        Me.txtNCuotaMen.EditValue = "0"
        Me.txtNCuotaMen.Location = New System.Drawing.Point(294, 122)
        Me.txtNCuotaMen.Name = "txtNCuotaMen"
        Me.txtNCuotaMen.Properties.DisplayFormat.FormatString = "d2"
        Me.txtNCuotaMen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNCuotaMen.Properties.EditFormat.FormatString = "d2"
        Me.txtNCuotaMen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNCuotaMen.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtNCuotaMen.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtNCuotaMen.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtNCuotaMen.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.txtNCuotaMen.Properties.Mask.BeepOnError = True
        Me.txtNCuotaMen.Properties.Mask.EditMask = "d2"
        Me.txtNCuotaMen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNCuotaMen.Properties.Mask.ShowPlaceHolders = False
        Me.txtNCuotaMen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNCuotaMen.Size = New System.Drawing.Size(26, 20)
        Me.txtNCuotaMen.TabIndex = 127
        '
        'lblNCuotasMen
        '
        Me.lblNCuotasMen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNCuotasMen.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNCuotasMen.ForeColor = System.Drawing.Color.Navy
        Me.lblNCuotasMen.Location = New System.Drawing.Point(153, 122)
        Me.lblNCuotasMen.Name = "lblNCuotasMen"
        Me.lblNCuotasMen.Size = New System.Drawing.Size(135, 20)
        Me.lblNCuotasMen.TabIndex = 126
        Me.lblNCuotasMen.Text = "No. Cuotas Mensuales"
        '
        'txtVCuotaIni
        '
        Me.txtVCuotaIni.EditValue = "0"
        Me.txtVCuotaIni.Location = New System.Drawing.Point(69, 144)
        Me.txtVCuotaIni.Name = "txtVCuotaIni"
        Me.txtVCuotaIni.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtVCuotaIni.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtVCuotaIni.Properties.Mask.BeepOnError = True
        Me.txtVCuotaIni.Properties.Mask.EditMask = "c0"
        Me.txtVCuotaIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtVCuotaIni.Properties.Mask.ShowPlaceHolders = False
        Me.txtVCuotaIni.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVCuotaIni.Size = New System.Drawing.Size(81, 20)
        Me.txtVCuotaIni.TabIndex = 123
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX8.ForeColor = System.Drawing.Color.Navy
        Me.LabelX8.Location = New System.Drawing.Point(6, 144)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(62, 20)
        Me.LabelX8.TabIndex = 122
        Me.LabelX8.Text = "V Cuota Ini."
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(6, 122)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(110, 20)
        Me.LabelX7.TabIndex = 120
        Me.LabelX7.Text = "No. Cuotas Iniciales"
        '
        'txtMesesDiag
        '
        Me.txtMesesDiag.EditValue = "0"
        Me.txtMesesDiag.Location = New System.Drawing.Point(79, 96)
        Me.txtMesesDiag.Name = "txtMesesDiag"
        Me.txtMesesDiag.Properties.DisplayFormat.FormatString = "d2"
        Me.txtMesesDiag.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesesDiag.Properties.EditFormat.FormatString = "d2"
        Me.txtMesesDiag.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMesesDiag.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.txtMesesDiag.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtMesesDiag.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtMesesDiag.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.txtMesesDiag.Properties.Mask.BeepOnError = True
        Me.txtMesesDiag.Properties.Mask.EditMask = "d2"
        Me.txtMesesDiag.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMesesDiag.Properties.Mask.ShowPlaceHolders = False
        Me.txtMesesDiag.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMesesDiag.Size = New System.Drawing.Size(26, 20)
        Me.txtMesesDiag.TabIndex = 119
        '
        'txtCostoTrat
        '
        Me.txtCostoTrat.EditValue = "0"
        Me.txtCostoTrat.Location = New System.Drawing.Point(222, 96)
        Me.txtCostoTrat.Name = "txtCostoTrat"
        Me.txtCostoTrat.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtCostoTrat.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtCostoTrat.Properties.Mask.BeepOnError = True
        Me.txtCostoTrat.Properties.Mask.EditMask = "c0"
        Me.txtCostoTrat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCostoTrat.Properties.Mask.ShowPlaceHolders = False
        Me.txtCostoTrat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCostoTrat.Size = New System.Drawing.Size(99, 20)
        Me.txtCostoTrat.TabIndex = 118
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX6.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX6.ForeColor = System.Drawing.Color.Navy
        Me.LabelX6.Location = New System.Drawing.Point(106, 96)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(116, 20)
        Me.LabelX6.TabIndex = 117
        Me.LabelX6.Text = "Costo del Tratamiento"
        '
        'txtdedoc_pac
        '
        '
        '
        '
        Me.txtdedoc_pac.Border.Class = "TextBoxBorder"
        Me.txtdedoc_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdedoc_pac.Location = New System.Drawing.Point(228, 74)
        Me.txtdedoc_pac.Name = "txtdedoc_pac"
        Me.txtdedoc_pac.Size = New System.Drawing.Size(93, 20)
        Me.txtdedoc_pac.TabIndex = 116
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX5.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX5.ForeColor = System.Drawing.Color.Navy
        Me.LabelX5.Location = New System.Drawing.Point(200, 74)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(25, 20)
        Me.LabelX5.TabIndex = 115
        Me.LabelX5.Text = "de"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX4.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(6, 96)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(70, 20)
        Me.LabelX4.TabIndex = 113
        Me.LabelX4.Text = "Meses Diag."
        '
        'txtnumdoc_pac
        '
        Me.txtnumdoc_pac.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtnumdoc_pac.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtnumdoc_pac.DecimalDigits = 0
        Me.txtnumdoc_pac.Location = New System.Drawing.Point(106, 74)
        Me.txtnumdoc_pac.Name = "txtnumdoc_pac"
        Me.txtnumdoc_pac.Size = New System.Drawing.Size(93, 20)
        Me.txtnumdoc_pac.TabIndex = 112
        Me.txtnumdoc_pac.Text = "0"
        Me.txtnumdoc_pac.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(6, 73)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(99, 20)
        Me.LabelX3.TabIndex = 111
        Me.LabelX3.Text = "Doc. de Identidad"
        '
        'txtnombre_pac
        '
        '
        '
        '
        Me.txtnombre_pac.Border.Class = "TextBoxBorder"
        Me.txtnombre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre_pac.Location = New System.Drawing.Point(6, 49)
        Me.txtnombre_pac.Name = "txtnombre_pac"
        Me.txtnombre_pac.Size = New System.Drawing.Size(315, 20)
        Me.txtnombre_pac.TabIndex = 110
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(6, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(85, 20)
        Me.LabelX2.TabIndex = 109
        Me.LabelX2.Text = "Fecha Contrato"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dateDocumento
        '
        Me.dateDocumento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDocumento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateDocumento.Location = New System.Drawing.Point(96, 4)
        Me.dateDocumento.Name = "dateDocumento"
        Me.dateDocumento.Size = New System.Drawing.Size(103, 20)
        Me.dateDocumento.TabIndex = 108
        Me.dateDocumento.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblNomPaciente
        '
        Me.lblNomPaciente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNomPaciente.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomPaciente.ForeColor = System.Drawing.Color.Navy
        Me.lblNomPaciente.Location = New System.Drawing.Point(6, 27)
        Me.lblNomPaciente.Name = "lblNomPaciente"
        Me.lblNomPaciente.Size = New System.Drawing.Size(197, 20)
        Me.lblNomPaciente.TabIndex = 107
        Me.lblNomPaciente.Text = "Nombre del Paciente o Representante"
        '
        'Tab_pservcso
        '
        Me.Tab_pservcso.AttachedControl = Me.TabControlPanel1
        Me.Tab_pservcso.Name = "Tab_pservcso"
        Me.Tab_pservcso.Text = "Pres. Servicios"
        Me.Tab_pservcso.Tooltip = "Citas Sin Asistir"
        '
        'TabControlPanel7
        '
        Me.TabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel7.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel7.Name = "TabControlPanel7"
        Me.TabControlPanel7.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel7.Size = New System.Drawing.Size(347, 350)
        Me.TabControlPanel7.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel7.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel7.Style.GradientAngle = 90
        Me.TabControlPanel7.TabIndex = 7
        Me.TabControlPanel7.TabItem = Me.TabItem7
        '
        'TabItem7
        '
        Me.TabItem7.AttachedControl = Me.TabControlPanel7
        Me.TabItem7.Name = "TabItem7"
        Me.TabItem7.Text = "TabItem7"
        '
        'TabControlPanel6
        '
        Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel6.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel6.Name = "TabControlPanel6"
        Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel6.Size = New System.Drawing.Size(347, 350)
        Me.TabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel6.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel6.Style.GradientAngle = 90
        Me.TabControlPanel6.TabIndex = 6
        Me.TabControlPanel6.TabItem = Me.TabItem6
        '
        'TabItem6
        '
        Me.TabItem6.AttachedControl = Me.TabControlPanel6
        Me.TabItem6.Name = "TabItem6"
        Me.TabItem6.Text = "TabItem6"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(420, 432)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 127
        Me.btnSalir.Text = "SALIR"
        '
        'TreeDocumentos
        '
        Me.TreeDocumentos.BackColor = System.Drawing.Color.MintCream
        Me.TreeDocumentos.HideSelection = False
        Me.TreeDocumentos.ImageKey = "bullet_square_green.png"
        Me.TreeDocumentos.ImageList = Me.ImageList1
        Me.TreeDocumentos.Location = New System.Drawing.Point(12, 54)
        Me.TreeDocumentos.Name = "TreeDocumentos"
        TreeNode1.Name = "Nodo3"
        TreeNode1.Text = "Prestacion de Servicios - SCO"
        TreeNode2.ImageKey = "(predeterminada)"
        TreeNode2.Name = "Nodo0"
        TreeNode2.Text = "Contratos"
        TreeNode3.Name = "Nodo4"
        TreeNode3.Text = "C. Informado - SCO"
        TreeNode4.Name = "Nodo5"
        TreeNode4.Text = "Consentimiento 2"
        TreeNode5.Name = "Nodo6"
        TreeNode5.Text = "Confirmacion del Consentimiento"
        TreeNode6.Name = "Nodo7"
        TreeNode6.Text = "Sistema Atencion al Cliente"
        TreeNode7.ImageKey = "(predeterminada)"
        TreeNode7.Name = "Nodo1"
        TreeNode7.Text = "Consentimientos"
        TreeNode8.Name = "Nodo8"
        TreeNode8.Text = "Beneficios y Recomendaciones"
        TreeNode9.Name = "Nodo2"
        TreeNode9.Text = "Otros Documentos"
        Me.TreeDocumentos.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode7, TreeNode9})
        Me.TreeDocumentos.SelectedImageKey = "arrow_right_blue.png"
        Me.TreeDocumentos.Size = New System.Drawing.Size(156, 372)
        Me.TreeDocumentos.TabIndex = 87
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
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(12, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(504, 23)
        Me.lblTituloVentana.TabIndex = 85
        Me.lblTituloVentana.Text = "DOCUMENTOS Y CONTRATOS"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProviderpac
        '
        Me.ErrorProviderpac.ContainerControl = Me
        '
        'frmDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Documentos"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.TabDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDocumentos.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupTotalDatosDoc.ResumeLayout(False)
        CType(Me.txtNCuotaIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVMulta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVTuboM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVBracket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVCuotaMen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNCuotaMen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVCuotaIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMesesDiag.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCostoTrat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderpac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents TabDocumentos As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents btnDocumento_CPS_SCO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupTotalDatosDoc As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dateDocumento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNomPaciente As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tab_pservcso As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Tab_ConsInfo_SCO As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem5 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel6 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem6 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel7 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem7 As DevComponents.DotNetBar.TabItem
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TreeDocumentos As System.Windows.Forms.TreeView
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtnombre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnumdoc_pac As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtdedoc_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCostoTrat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVCuotaIni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMesesDiag As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVTuboM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtVBracket As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtVCuotaMen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNCuotaMen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNCuotasMen As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtVMulta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCiudad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnDocumento_CINFO_SCO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtnumdoc_pac2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtnombre_pac2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ErrorProviderpac As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnDocumento_Beneficios As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtdedoc_pac2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNCuotaIni As DevExpress.XtraEditors.TextEdit
End Class
