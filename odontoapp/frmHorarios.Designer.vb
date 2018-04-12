<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorarios))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.gpUnidad = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblTipoConsulta = New DevComponents.DotNetBar.LabelX
        Me.ComboBoxEx1 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.GroupDoctor = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbDoctores = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ScheduleOrhosoftMulti = New Janus.Windows.Schedule.Schedule
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.RibbonClientPanel2 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.gpDias = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.ckDomingo = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckLunes = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckSabado = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckMartes = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckJueves = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckMiercoles = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.ckViernes = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbDoctores2 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.dgCuentasadicionales = New System.Windows.Forms.DataGridView
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.TabFichaHorarios = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpUnidad.SuspendLayout()
        Me.GroupDoctor.SuspendLayout()
        CType(Me.ScheduleOrhosoftMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.RibbonClientPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.gpDias.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dgCuentasadicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.gpUnidad)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupDoctor)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(1, 404)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(439, 59)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 0
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'gpUnidad
        '
        Me.gpUnidad.BackColor = System.Drawing.Color.Transparent
        Me.gpUnidad.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpUnidad.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpUnidad.Controls.Add(Me.lblTipoConsulta)
        Me.gpUnidad.Controls.Add(Me.ComboBoxEx1)
        Me.gpUnidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpUnidad.Location = New System.Drawing.Point(228, 4)
        Me.gpUnidad.Name = "gpUnidad"
        Me.gpUnidad.Size = New System.Drawing.Size(205, 52)
        '
        '
        '
        Me.gpUnidad.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpUnidad.Style.BackColorGradientAngle = 90
        Me.gpUnidad.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpUnidad.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidad.Style.BorderBottomWidth = 1
        Me.gpUnidad.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpUnidad.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidad.Style.BorderLeftWidth = 1
        Me.gpUnidad.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidad.Style.BorderRightWidth = 1
        Me.gpUnidad.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidad.Style.BorderTopWidth = 1
        Me.gpUnidad.Style.CornerDiameter = 4
        Me.gpUnidad.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpUnidad.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpUnidad.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpUnidad.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpUnidad.TabIndex = 13
        Me.gpUnidad.Text = "Unidad / Consultorio"
        '
        'lblTipoConsulta
        '
        Me.lblTipoConsulta.BackColor = System.Drawing.Color.Beige
        Me.lblTipoConsulta.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblTipoConsulta.Location = New System.Drawing.Point(163, 3)
        Me.lblTipoConsulta.Name = "lblTipoConsulta"
        Me.lblTipoConsulta.Size = New System.Drawing.Size(26, 22)
        Me.lblTipoConsulta.TabIndex = 2
        '
        'ComboBoxEx1
        '
        Me.ComboBoxEx1.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.ComboBoxEx1.DisplayMember = "Text"
        Me.ComboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx1.FormattingEnabled = True
        Me.ComboBoxEx1.ItemHeight = 14
        Me.ComboBoxEx1.Location = New System.Drawing.Point(7, 4)
        Me.ComboBoxEx1.Name = "ComboBoxEx1"
        Me.ComboBoxEx1.Size = New System.Drawing.Size(151, 20)
        Me.ComboBoxEx1.TabIndex = 0
        '
        'GroupDoctor
        '
        Me.GroupDoctor.BackColor = System.Drawing.Color.Transparent
        Me.GroupDoctor.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupDoctor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupDoctor.Controls.Add(Me.cmbDoctores)
        Me.GroupDoctor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDoctor.Location = New System.Drawing.Point(7, 4)
        Me.GroupDoctor.Name = "GroupDoctor"
        Me.GroupDoctor.Size = New System.Drawing.Size(215, 52)
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
        Me.GroupDoctor.TabIndex = 12
        Me.GroupDoctor.Text = "Doctor"
        '
        'cmbDoctores
        '
        Me.cmbDoctores.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.cmbDoctores.DisplayMember = "Text"
        Me.cmbDoctores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctores.FormattingEnabled = True
        Me.cmbDoctores.ItemHeight = 14
        Me.cmbDoctores.Location = New System.Drawing.Point(5, 4)
        Me.cmbDoctores.Name = "cmbDoctores"
        Me.cmbDoctores.Size = New System.Drawing.Size(198, 20)
        Me.cmbDoctores.TabIndex = 0
        '
        'ScheduleOrhosoftMulti
        '
        Me.ScheduleOrhosoftMulti.AllowDelete = False
        Me.ScheduleOrhosoftMulti.AllowEdit = False
        Me.ScheduleOrhosoftMulti.Date = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.ScheduleOrhosoftMulti.Dates.Add(New Date(2007, 1, 1, 0, 0, 0, 0))
        Me.ScheduleOrhosoftMulti.DayStartHour = 1
        Me.ScheduleOrhosoftMulti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScheduleOrhosoftMulti.FirstVisibleTime = System.TimeSpan.Parse("07:00:00")
        Me.ScheduleOrhosoftMulti.HourBackgroundStyle.BackColor = System.Drawing.Color.Navy
        Me.ScheduleOrhosoftMulti.Location = New System.Drawing.Point(1, 1)
        Me.ScheduleOrhosoftMulti.MultiOwner = True
        Me.ScheduleOrhosoftMulti.Name = "ScheduleOrhosoftMulti"
        Me.ScheduleOrhosoftMulti.ShowAllDayArea = False
        Me.ScheduleOrhosoftMulti.ShowMinutesInTimeNavigator = True
        Me.ScheduleOrhosoftMulti.Size = New System.Drawing.Size(439, 403)
        Me.ScheduleOrhosoftMulti.TabIndex = 14
        Me.ScheduleOrhosoftMulti.WorkEndTime = System.TimeSpan.Parse("19:00:00")
        Me.ScheduleOrhosoftMulti.WorkingHourBackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ScheduleOrhosoftMulti.WorkStartTime = System.TimeSpan.Parse("07:00:00")
        '
        'TabControl1
        '
        Me.TabControl1.BackColor = System.Drawing.Color.Transparent
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(532, 486)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl1.TabIndex = 15
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabFichaHorarios)
        Me.TabControl1.Text = "TabHorarios"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.ScheduleOrhosoftMulti)
        Me.TabControlPanel1.Controls.Add(Me.RibbonClientPanel1)
        Me.TabControlPanel1.Controls.Add(Me.RibbonClientPanel2)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 464)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.TabItem1
        '
        'RibbonClientPanel2
        '
        Me.RibbonClientPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel2.Controls.Add(Me.GroupPanel3)
        Me.RibbonClientPanel2.Controls.Add(Me.gpDias)
        Me.RibbonClientPanel2.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel2.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel2.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.RibbonClientPanel2.Location = New System.Drawing.Point(440, 1)
        Me.RibbonClientPanel2.Name = "RibbonClientPanel2"
        Me.RibbonClientPanel2.Size = New System.Drawing.Size(91, 462)
        '
        '
        '
        Me.RibbonClientPanel2.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel2.TabIndex = 15
        Me.RibbonClientPanel2.Text = "RibbonClientPanel2"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.CheckBoxX2)
        Me.GroupPanel3.Controls.Add(Me.CheckBoxX1)
        Me.GroupPanel3.Location = New System.Drawing.Point(6, 220)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(79, 84)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 16
        Me.GroupPanel3.Text = "Visualización"
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX2.Location = New System.Drawing.Point(8, 30)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(66, 23)
        Me.CheckBoxX2.TabIndex = 1
        Me.CheckBoxX2.Text = "Actual"
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX1.Checked = True
        Me.CheckBoxX1.Location = New System.Drawing.Point(8, 7)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(66, 23)
        Me.CheckBoxX1.TabIndex = 0
        Me.CheckBoxX1.Text = "Nuevo"
        '
        'gpDias
        '
        Me.gpDias.BackColor = System.Drawing.Color.Transparent
        Me.gpDias.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDias.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDias.Controls.Add(Me.ckDomingo)
        Me.gpDias.Controls.Add(Me.ckLunes)
        Me.gpDias.Controls.Add(Me.ckSabado)
        Me.gpDias.Controls.Add(Me.ckMartes)
        Me.gpDias.Controls.Add(Me.ckJueves)
        Me.gpDias.Controls.Add(Me.ckMiercoles)
        Me.gpDias.Controls.Add(Me.ckViernes)
        Me.gpDias.Location = New System.Drawing.Point(6, 4)
        Me.gpDias.Name = "gpDias"
        Me.gpDias.Size = New System.Drawing.Size(79, 209)
        '
        '
        '
        Me.gpDias.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDias.Style.BackColorGradientAngle = 90
        Me.gpDias.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDias.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDias.Style.BorderBottomWidth = 1
        Me.gpDias.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDias.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDias.Style.BorderLeftWidth = 1
        Me.gpDias.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDias.Style.BorderRightWidth = 1
        Me.gpDias.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDias.Style.BorderTopWidth = 1
        Me.gpDias.Style.CornerDiameter = 4
        Me.gpDias.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDias.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDias.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDias.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpDias.TabIndex = 1
        Me.gpDias.Text = "Dias"
        '
        'ckDomingo
        '
        Me.ckDomingo.Location = New System.Drawing.Point(4, 154)
        Me.ckDomingo.Name = "ckDomingo"
        Me.ckDomingo.Size = New System.Drawing.Size(68, 23)
        Me.ckDomingo.TabIndex = 7
        Me.ckDomingo.Text = "Domingo"
        '
        'ckLunes
        '
        Me.ckLunes.Location = New System.Drawing.Point(5, 5)
        Me.ckLunes.Name = "ckLunes"
        Me.ckLunes.Size = New System.Drawing.Size(51, 23)
        Me.ckLunes.TabIndex = 0
        Me.ckLunes.Text = "Lunes"
        '
        'ckSabado
        '
        Me.ckSabado.Location = New System.Drawing.Point(4, 129)
        Me.ckSabado.Name = "ckSabado"
        Me.ckSabado.Size = New System.Drawing.Size(68, 23)
        Me.ckSabado.TabIndex = 6
        Me.ckSabado.Text = "Sabado"
        '
        'ckMartes
        '
        Me.ckMartes.Location = New System.Drawing.Point(4, 29)
        Me.ckMartes.Name = "ckMartes"
        Me.ckMartes.Size = New System.Drawing.Size(68, 23)
        Me.ckMartes.TabIndex = 4
        Me.ckMartes.Text = "Martes"
        '
        'ckJueves
        '
        Me.ckJueves.Location = New System.Drawing.Point(4, 79)
        Me.ckJueves.Name = "ckJueves"
        Me.ckJueves.Size = New System.Drawing.Size(68, 23)
        Me.ckJueves.TabIndex = 2
        Me.ckJueves.Text = "Jueves"
        '
        'ckMiercoles
        '
        Me.ckMiercoles.Location = New System.Drawing.Point(4, 54)
        Me.ckMiercoles.Name = "ckMiercoles"
        Me.ckMiercoles.Size = New System.Drawing.Size(68, 23)
        Me.ckMiercoles.TabIndex = 3
        Me.ckMiercoles.Text = "Miercoles"
        '
        'ckViernes
        '
        Me.ckViernes.Location = New System.Drawing.Point(4, 104)
        Me.ckViernes.Name = "ckViernes"
        Me.ckViernes.Size = New System.Drawing.Size(68, 23)
        Me.ckViernes.TabIndex = 5
        Me.ckViernes.Text = "Viernes"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnModificar.Location = New System.Drawing.Point(18, 361)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(57, 44)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalir.Location = New System.Drawing.Point(18, 409)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(57, 44)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAdicionar.Location = New System.Drawing.Point(18, 313)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(57, 44)
        Me.btnAdicionar.TabIndex = 13
        Me.btnAdicionar.Text = "Adicionar"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "Asignar Horario"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.btnEliminar)
        Me.TabControlPanel2.Controls.Add(Me.btnImprimir)
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel2)
        Me.TabControlPanel2.Controls.Add(Me.dgCuentasadicionales)
        Me.TabControlPanel2.Controls.Add(Me.lblTituloVentana)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 464)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.TabFichaHorarios
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnEliminar.Location = New System.Drawing.Point(470, 408)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(50, 44)
        Me.btnEliminar.TabIndex = 99
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnImprimir.Location = New System.Drawing.Point(418, 408)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(50, 44)
        Me.btnImprimir.TabIndex = 100
        Me.btnImprimir.Text = "Imprimir"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cmbDoctores2)
        Me.GroupPanel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel2.Location = New System.Drawing.Point(16, 42)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(504, 52)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 98
        Me.GroupPanel2.Text = "Doctor"
        '
        'cmbDoctores2
        '
        Me.cmbDoctores2.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.cmbDoctores2.DisplayMember = "Text"
        Me.cmbDoctores2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctores2.FormattingEnabled = True
        Me.cmbDoctores2.ItemHeight = 14
        Me.cmbDoctores2.Location = New System.Drawing.Point(5, 4)
        Me.cmbDoctores2.Name = "cmbDoctores2"
        Me.cmbDoctores2.Size = New System.Drawing.Size(490, 20)
        Me.cmbDoctores2.TabIndex = 0
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
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuentasadicionales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgCuentasadicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCuentasadicionales.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgCuentasadicionales.EnableHeadersVisualStyles = False
        Me.dgCuentasadicionales.Location = New System.Drawing.Point(16, 111)
        Me.dgCuentasadicionales.MultiSelect = False
        Me.dgCuentasadicionales.Name = "dgCuentasadicionales"
        Me.dgCuentasadicionales.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCuentasadicionales.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgCuentasadicionales.RowHeadersVisible = False
        Me.dgCuentasadicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCuentasadicionales.Size = New System.Drawing.Size(504, 292)
        Me.dgCuentasadicionales.TabIndex = 97
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(16, 13)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(504, 23)
        Me.lblTituloVentana.TabIndex = 1
        Me.lblTituloVentana.Text = "TABLA DE HORARIOS ASIGNADOS"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabFichaHorarios
        '
        Me.TabFichaHorarios.AttachedControl = Me.TabControlPanel2
        Me.TabFichaHorarios.Name = "TabFichaHorarios"
        Me.TabFichaHorarios.Text = "Horarios"
        '
        'frmHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horarios"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpUnidad.ResumeLayout(False)
        Me.GroupDoctor.ResumeLayout(False)
        CType(Me.ScheduleOrhosoftMulti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.RibbonClientPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.gpDias.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dgCuentasadicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents ScheduleOrhosoftMulti As Janus.Windows.Schedule.Schedule
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents RibbonClientPanel2 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpDias As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ckDomingo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckSabado As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckViernes As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckMartes As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckMiercoles As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckJueves As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ckLunes As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents GroupDoctor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbDoctores As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpUnidad As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents ComboBoxEx1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabFichaHorarios As DevComponents.DotNetBar.TabItem
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgCuentasadicionales As System.Windows.Forms.DataGridView
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbDoctores2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblTipoConsulta As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
