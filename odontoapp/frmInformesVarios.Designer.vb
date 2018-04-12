<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformesVarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformesVarios))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pacientes Activos")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pacientes Bloqueados")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cumpleaños del Dia")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cumpleaños de la Semana")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cumpleaños del Mes")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cumpleaños", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pacientes", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Citas del Dia")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Citas por fecha")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Citas por Paciente")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Citas no Asistidas")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Citas", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10, TreeNode11})
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.TabInformes = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnInforme_csinasis = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.GroupTotalPresupuesto = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.dateFin_csinasis = New System.Windows.Forms.DateTimePicker
        Me.lblFecha = New DevComponents.DotNetBar.LabelX
        Me.dateIni_csinasis = New System.Windows.Forms.DateTimePicker
        Me.Tab_csinasis = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel4 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem4 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem3 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel5 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem5 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel6 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem6 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel7 = New DevComponents.DotNetBar.TabControlPanel
        Me.TabItem7 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.TreeInformes = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.TabInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInformes.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupTotalPresupuesto.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.TabInformes)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.TreeInformes)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
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
        'TabInformes
        '
        Me.TabInformes.CanReorderTabs = False
        Me.TabInformes.Controls.Add(Me.TabControlPanel7)
        Me.TabInformes.Controls.Add(Me.TabControlPanel6)
        Me.TabInformes.Controls.Add(Me.TabControlPanel5)
        Me.TabInformes.Controls.Add(Me.TabControlPanel4)
        Me.TabInformes.Controls.Add(Me.TabControlPanel3)
        Me.TabInformes.Controls.Add(Me.TabControlPanel2)
        Me.TabInformes.Controls.Add(Me.TabControlPanel1)
        Me.TabInformes.Location = New System.Drawing.Point(202, 54)
        Me.TabInformes.Name = "TabInformes"
        Me.TabInformes.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabInformes.SelectedTabIndex = 3
        Me.TabInformes.Size = New System.Drawing.Size(314, 372)
        Me.TabInformes.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabInformes.TabIndex = 128
        Me.TabInformes.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabInformes.Tabs.Add(Me.Tab_csinasis)
        Me.TabInformes.Tabs.Add(Me.TabItem2)
        Me.TabInformes.Tabs.Add(Me.TabItem3)
        Me.TabInformes.Tabs.Add(Me.TabItem4)
        Me.TabInformes.Tabs.Add(Me.TabItem5)
        Me.TabInformes.Tabs.Add(Me.TabItem6)
        Me.TabInformes.Tabs.Add(Me.TabItem7)
        Me.TabInformes.TabsVisible = False
        Me.TabInformes.Text = "TabControl"
        Me.TabInformes.ThemeAware = True
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.btnInforme_csinasis)
        Me.TabControlPanel1.Controls.Add(Me.LabelX1)
        Me.TabControlPanel1.Controls.Add(Me.GroupTotalPresupuesto)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(314, 350)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.Tab_csinasis
        '
        'btnInforme_csinasis
        '
        Me.btnInforme_csinasis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnInforme_csinasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInforme_csinasis.Image = CType(resources.GetObject("btnInforme_csinasis.Image"), System.Drawing.Image)
        Me.btnInforme_csinasis.Location = New System.Drawing.Point(87, 219)
        Me.btnInforme_csinasis.Name = "btnInforme_csinasis"
        Me.btnInforme_csinasis.Size = New System.Drawing.Size(159, 44)
        Me.btnInforme_csinasis.TabIndex = 119
        Me.btnInforme_csinasis.Text = "GENERAR INFORME"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.DodgerBlue
        Me.LabelX1.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX1.Location = New System.Drawing.Point(4, 8)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(306, 23)
        Me.LabelX1.TabIndex = 118
        Me.LabelX1.Text = "CITAS SIN ASISTIR"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupTotalPresupuesto
        '
        Me.GroupTotalPresupuesto.BackColor = System.Drawing.Color.Transparent
        Me.GroupTotalPresupuesto.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupTotalPresupuesto.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupTotalPresupuesto.Controls.Add(Me.LabelX2)
        Me.GroupTotalPresupuesto.Controls.Add(Me.dateFin_csinasis)
        Me.GroupTotalPresupuesto.Controls.Add(Me.lblFecha)
        Me.GroupTotalPresupuesto.Controls.Add(Me.dateIni_csinasis)
        Me.GroupTotalPresupuesto.Location = New System.Drawing.Point(22, 45)
        Me.GroupTotalPresupuesto.Name = "GroupTotalPresupuesto"
        Me.GroupTotalPresupuesto.Size = New System.Drawing.Size(271, 111)
        '
        '
        '
        Me.GroupTotalPresupuesto.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupTotalPresupuesto.Style.BackColorGradientAngle = 90
        Me.GroupTotalPresupuesto.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupTotalPresupuesto.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalPresupuesto.Style.BorderBottomWidth = 1
        Me.GroupTotalPresupuesto.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupTotalPresupuesto.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalPresupuesto.Style.BorderLeftWidth = 1
        Me.GroupTotalPresupuesto.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalPresupuesto.Style.BorderRightWidth = 1
        Me.GroupTotalPresupuesto.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTotalPresupuesto.Style.BorderTopWidth = 1
        Me.GroupTotalPresupuesto.Style.CornerDiameter = 4
        Me.GroupTotalPresupuesto.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupTotalPresupuesto.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupTotalPresupuesto.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupTotalPresupuesto.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupTotalPresupuesto.TabIndex = 117
        Me.GroupTotalPresupuesto.Tag = ""
        Me.GroupTotalPresupuesto.Text = "Datos para el Informe"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(40, 47)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 21)
        Me.LabelX2.TabIndex = 109
        Me.LabelX2.Text = "Fecha Fin"
        '
        'dateFin_csinasis
        '
        Me.dateFin_csinasis.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFin_csinasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFin_csinasis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFin_csinasis.Location = New System.Drawing.Point(118, 46)
        Me.dateFin_csinasis.Name = "dateFin_csinasis"
        Me.dateFin_csinasis.Size = New System.Drawing.Size(103, 21)
        Me.dateFin_csinasis.TabIndex = 108
        Me.dateFin_csinasis.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFecha.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblFecha.ForeColor = System.Drawing.Color.Navy
        Me.lblFecha.Location = New System.Drawing.Point(39, 18)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(72, 21)
        Me.lblFecha.TabIndex = 107
        Me.lblFecha.Text = "Fecha Inicio"
        '
        'dateIni_csinasis
        '
        Me.dateIni_csinasis.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateIni_csinasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateIni_csinasis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateIni_csinasis.Location = New System.Drawing.Point(117, 17)
        Me.dateIni_csinasis.Name = "dateIni_csinasis"
        Me.dateIni_csinasis.Size = New System.Drawing.Size(103, 21)
        Me.dateIni_csinasis.TabIndex = 106
        Me.dateIni_csinasis.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'Tab_csinasis
        '
        Me.Tab_csinasis.AttachedControl = Me.TabControlPanel1
        Me.Tab_csinasis.Name = "Tab_csinasis"
        Me.Tab_csinasis.Text = "C.N.A"
        Me.Tab_csinasis.Tooltip = "Citas Sin Asistir"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(314, 350)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabItem2
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "TabItem2"
        '
        'TabControlPanel4
        '
        Me.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel4.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel4.Name = "TabControlPanel4"
        Me.TabControlPanel4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel4.Size = New System.Drawing.Size(314, 350)
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
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(314, 350)
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
        'TabItem3
        '
        Me.TabItem3.AttachedControl = Me.TabControlPanel3
        Me.TabItem3.Name = "TabItem3"
        Me.TabItem3.Text = "TabItem3"
        '
        'TabControlPanel5
        '
        Me.TabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel5.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel5.Name = "TabControlPanel5"
        Me.TabControlPanel5.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel5.Size = New System.Drawing.Size(314, 350)
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
        'TabControlPanel6
        '
        Me.TabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel6.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel6.Name = "TabControlPanel6"
        Me.TabControlPanel6.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel6.Size = New System.Drawing.Size(314, 350)
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
        'TabControlPanel7
        '
        Me.TabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel7.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel7.Name = "TabControlPanel7"
        Me.TabControlPanel7.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel7.Size = New System.Drawing.Size(314, 350)
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
        'TreeInformes
        '
        Me.TreeInformes.BackColor = System.Drawing.Color.MintCream
        Me.TreeInformes.HideSelection = False
        Me.TreeInformes.ImageKey = "bullet_square_green.png"
        Me.TreeInformes.ImageList = Me.ImageList1
        Me.TreeInformes.Location = New System.Drawing.Point(12, 54)
        Me.TreeInformes.Name = "TreeInformes"
        TreeNode1.Name = "Nodo10"
        TreeNode1.Text = "Pacientes Activos"
        TreeNode2.Name = "Nodo11"
        TreeNode2.Text = "Pacientes Bloqueados"
        TreeNode3.Name = "Nodo13"
        TreeNode3.Text = "Cumpleaños del Dia"
        TreeNode4.Name = "Nodo14"
        TreeNode4.Text = "Cumpleaños de la Semana"
        TreeNode5.Name = "Nodo16"
        TreeNode5.Text = "Cumpleaños del Mes"
        TreeNode6.Name = "Nodo12"
        TreeNode6.Text = "Cumpleaños"
        TreeNode7.ImageKey = "user1.png"
        TreeNode7.Name = "Nodo0"
        TreeNode7.Text = "Pacientes"
        TreeNode8.Name = "Nodo7"
        TreeNode8.Text = "Citas del Dia"
        TreeNode9.Name = "Nodo9"
        TreeNode9.Text = "Citas por fecha"
        TreeNode10.Name = "Nodo17"
        TreeNode10.Text = "Citas por Paciente"
        TreeNode11.Name = "Nodo18"
        TreeNode11.Text = "Citas no Asistidas"
        TreeNode12.ImageKey = "clock_run.png"
        TreeNode12.Name = "Nodo5"
        TreeNode12.Text = "Citas"
        Me.TreeInformes.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode12})
        Me.TreeInformes.SelectedImageKey = "arrow_right_blue.png"
        Me.TreeInformes.Size = New System.Drawing.Size(184, 372)
        Me.TreeInformes.TabIndex = 87
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
        Me.lblTituloVentana.Text = "INFORMES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmInformesVarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInformesVarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Informes Varios"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.TabInformes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInformes.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupTotalPresupuesto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents TreeInformes As System.Windows.Forms.TreeView
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabInformes As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents Tab_csinasis As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem3 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel4 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem4 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel5 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem5 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel6 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem6 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel7 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem7 As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupTotalPresupuesto As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dateIni_csinasis As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dateFin_csinasis As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInforme_csinasis As DevComponents.DotNetBar.ButtonX
End Class
