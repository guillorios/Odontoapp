<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReminderCitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReminderCitas))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnPacNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnPacSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnPacEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnPacAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.GroupHorarioLaboral = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblInicio = New DevComponents.DotNetBar.LabelX
        Me.lblFin = New DevComponents.DotNetBar.LabelX
        Me.RemEndTime = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.RemStartTime = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.gPanel_Sexo = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.rbtFemenino_pac = New System.Windows.Forms.RadioButton
        Me.rbtMasculino_pac = New System.Windows.Forms.RadioButton
        Me.GroupTipoConsulta = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbTipoConsulta = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblTipoConsulta = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.GroupHorarioLaboral.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.gPanel_Sexo.SuspendLayout()
        Me.GroupTipoConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnPacNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnPacSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnPacEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnPacAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupHorarioLaboral)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel1)
        Me.RibbonClientPanel1.Controls.Add(Me.gPanel_Sexo)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupTipoConsulta)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX11)
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
        'btnPacNuevo
        '
        Me.btnPacNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPacNuevo.Image = CType(resources.GetObject("btnPacNuevo.Image"), System.Drawing.Image)
        Me.btnPacNuevo.Location = New System.Drawing.Point(141, 425)
        Me.btnPacNuevo.Name = "btnPacNuevo"
        Me.btnPacNuevo.Size = New System.Drawing.Size(96, 39)
        Me.btnPacNuevo.TabIndex = 123
        Me.btnPacNuevo.Text = "NUEVO"
        '
        'btnPacSalir
        '
        Me.btnPacSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPacSalir.Image = CType(resources.GetObject("btnPacSalir.Image"), System.Drawing.Image)
        Me.btnPacSalir.Location = New System.Drawing.Point(399, 425)
        Me.btnPacSalir.Name = "btnPacSalir"
        Me.btnPacSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnPacSalir.TabIndex = 125
        Me.btnPacSalir.Text = "SALIR"
        '
        'btnPacEliminar
        '
        Me.btnPacEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPacEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPacEliminar.Image = CType(resources.GetObject("btnPacEliminar.Image"), System.Drawing.Image)
        Me.btnPacEliminar.Location = New System.Drawing.Point(243, 425)
        Me.btnPacEliminar.Name = "btnPacEliminar"
        Me.btnPacEliminar.Size = New System.Drawing.Size(96, 39)
        Me.btnPacEliminar.TabIndex = 124
        Me.btnPacEliminar.Text = "CANCELAR"
        '
        'btnPacAdicionar
        '
        Me.btnPacAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPacAdicionar.Image = CType(resources.GetObject("btnPacAdicionar.Image"), System.Drawing.Image)
        Me.btnPacAdicionar.Location = New System.Drawing.Point(39, 425)
        Me.btnPacAdicionar.Name = "btnPacAdicionar"
        Me.btnPacAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnPacAdicionar.TabIndex = 121
        Me.btnPacAdicionar.Text = "REMINDER"
        '
        'GroupHorarioLaboral
        '
        Me.GroupHorarioLaboral.BackColor = System.Drawing.Color.Transparent
        Me.GroupHorarioLaboral.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupHorarioLaboral.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupHorarioLaboral.Controls.Add(Me.lblInicio)
        Me.GroupHorarioLaboral.Controls.Add(Me.lblFin)
        Me.GroupHorarioLaboral.Controls.Add(Me.RemEndTime)
        Me.GroupHorarioLaboral.Controls.Add(Me.RemStartTime)
        Me.GroupHorarioLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupHorarioLaboral.Location = New System.Drawing.Point(257, 217)
        Me.GroupHorarioLaboral.Name = "GroupHorarioLaboral"
        Me.GroupHorarioLaboral.Size = New System.Drawing.Size(185, 107)
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
        Me.GroupHorarioLaboral.TabIndex = 120
        Me.GroupHorarioLaboral.Text = "Hora Cita"
        '
        'lblInicio
        '
        Me.lblInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblInicio.Location = New System.Drawing.Point(19, 11)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(32, 23)
        Me.lblInicio.TabIndex = 112
        Me.lblInicio.Text = "Inicio"
        '
        'lblFin
        '
        Me.lblFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFin.Location = New System.Drawing.Point(19, 40)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(32, 23)
        Me.lblFin.TabIndex = 111
        Me.lblFin.Text = "Fin"
        '
        'RemEndTime
        '
        Me.RemEndTime.CustomFormat = "hh:mm tt"
        Me.RemEndTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.RemEndTime.DropDownCalendar.Location = New System.Drawing.Point(0, 0)
        Me.RemEndTime.DropDownCalendar.Name = ""
        Me.RemEndTime.DropDownCalendar.Size = New System.Drawing.Size(164, 167)
        Me.RemEndTime.DropDownCalendar.TabIndex = 0
        Me.RemEndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard
        Me.RemEndTime.Location = New System.Drawing.Point(57, 43)
        Me.RemEndTime.Name = "RemEndTime"
        Me.RemEndTime.ShowDropDown = False
        Me.RemEndTime.ShowUpDown = True
        Me.RemEndTime.Size = New System.Drawing.Size(108, 21)
        Me.RemEndTime.TabIndex = 2
        Me.RemEndTime.Value = New Date(2002, 1, 18, 0, 0, 0, 0)
        '
        'RemStartTime
        '
        Me.RemStartTime.CustomFormat = "hh:mm tt"
        Me.RemStartTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
        '
        '
        '
        Me.RemStartTime.DropDownCalendar.Location = New System.Drawing.Point(15, 35)
        Me.RemStartTime.DropDownCalendar.Name = ""
        Me.RemStartTime.DropDownCalendar.Size = New System.Drawing.Size(164, 167)
        Me.RemStartTime.DropDownCalendar.TabIndex = 0
        Me.RemStartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Standard
        Me.RemStartTime.Location = New System.Drawing.Point(57, 14)
        Me.RemStartTime.Name = "RemStartTime"
        Me.RemStartTime.ShowDropDown = False
        Me.RemStartTime.ShowUpDown = True
        Me.RemStartTime.Size = New System.Drawing.Size(108, 21)
        Me.RemStartTime.TabIndex = 1
        Me.RemStartTime.Value = New Date(2002, 1, 18, 0, 0, 0, 0)
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.RadioButton1)
        Me.GroupPanel1.Controls.Add(Me.RadioButton2)
        Me.GroupPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(25, 235)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(154, 89)
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
        Me.GroupPanel1.TabIndex = 95
        Me.GroupPanel1.Text = "Periodo"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(12, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.Text = "Por 6 Meses"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(12, 15)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Por 1 Año"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'gPanel_Sexo
        '
        Me.gPanel_Sexo.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Sexo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Sexo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Sexo.Controls.Add(Me.RadioButton4)
        Me.gPanel_Sexo.Controls.Add(Me.RadioButton3)
        Me.gPanel_Sexo.Controls.Add(Me.rbtFemenino_pac)
        Me.gPanel_Sexo.Controls.Add(Me.rbtMasculino_pac)
        Me.gPanel_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gPanel_Sexo.Location = New System.Drawing.Point(25, 75)
        Me.gPanel_Sexo.Name = "gPanel_Sexo"
        Me.gPanel_Sexo.Size = New System.Drawing.Size(154, 142)
        '
        '
        '
        Me.gPanel_Sexo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gPanel_Sexo.Style.BackColorGradientAngle = 90
        Me.gPanel_Sexo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gPanel_Sexo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderBottomWidth = 1
        Me.gPanel_Sexo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gPanel_Sexo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderLeftWidth = 1
        Me.gPanel_Sexo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderRightWidth = 1
        Me.gPanel_Sexo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderTopWidth = 1
        Me.gPanel_Sexo.Style.CornerDiameter = 4
        Me.gPanel_Sexo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gPanel_Sexo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gPanel_Sexo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gPanel_Sexo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gPanel_Sexo.TabIndex = 94
        Me.gPanel_Sexo.Text = "Intervalo"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton4.Location = New System.Drawing.Point(17, 88)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton4.TabIndex = 13
        Me.RadioButton4.Text = "Cada 5 Semanas"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton3.Location = New System.Drawing.Point(17, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(120, 17)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.Text = "Cada 4 Semanas"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'rbtFemenino_pac
        '
        Me.rbtFemenino_pac.AutoSize = True
        Me.rbtFemenino_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemenino_pac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtFemenino_pac.Location = New System.Drawing.Point(17, 40)
        Me.rbtFemenino_pac.Name = "rbtFemenino_pac"
        Me.rbtFemenino_pac.Size = New System.Drawing.Size(103, 17)
        Me.rbtFemenino_pac.TabIndex = 11
        Me.rbtFemenino_pac.Text = "Cada 15 Días"
        Me.rbtFemenino_pac.UseVisualStyleBackColor = True
        '
        'rbtMasculino_pac
        '
        Me.rbtMasculino_pac.AutoSize = True
        Me.rbtMasculino_pac.Checked = True
        Me.rbtMasculino_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMasculino_pac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtMasculino_pac.Location = New System.Drawing.Point(17, 15)
        Me.rbtMasculino_pac.Name = "rbtMasculino_pac"
        Me.rbtMasculino_pac.Size = New System.Drawing.Size(103, 17)
        Me.rbtMasculino_pac.TabIndex = 10
        Me.rbtMasculino_pac.TabStop = True
        Me.rbtMasculino_pac.Text = "Cada Semana"
        Me.rbtMasculino_pac.UseVisualStyleBackColor = True
        '
        'GroupTipoConsulta
        '
        Me.GroupTipoConsulta.BackColor = System.Drawing.Color.Transparent
        Me.GroupTipoConsulta.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupTipoConsulta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupTipoConsulta.Controls.Add(Me.cmbTipoConsulta)
        Me.GroupTipoConsulta.Controls.Add(Me.lblTipoConsulta)
        Me.GroupTipoConsulta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTipoConsulta.Location = New System.Drawing.Point(198, 75)
        Me.GroupTipoConsulta.Name = "GroupTipoConsulta"
        Me.GroupTipoConsulta.Size = New System.Drawing.Size(314, 107)
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
        Me.GroupTipoConsulta.TabIndex = 93
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
        Me.cmbTipoConsulta.Location = New System.Drawing.Point(13, 27)
        Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
        Me.cmbTipoConsulta.Size = New System.Drawing.Size(230, 26)
        Me.cmbTipoConsulta.TabIndex = 82
        '
        'lblTipoConsulta
        '
        Me.lblTipoConsulta.BackColor = System.Drawing.Color.Beige
        Me.lblTipoConsulta.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblTipoConsulta.Location = New System.Drawing.Point(251, 27)
        Me.lblTipoConsulta.Name = "lblTipoConsulta"
        Me.lblTipoConsulta.Size = New System.Drawing.Size(38, 26)
        Me.lblTipoConsulta.TabIndex = 81
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(25, 12)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(487, 23)
        Me.LabelX11.TabIndex = 92
        Me.LabelX11.Text = "REMINDER CITAS"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmReminderCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReminderCitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reminder Citas"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.GroupHorarioLaboral.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.gPanel_Sexo.ResumeLayout(False)
        Me.gPanel_Sexo.PerformLayout()
        Me.GroupTipoConsulta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupTipoConsulta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents gPanel_Sexo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFemenino_pac As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMasculino_pac As System.Windows.Forms.RadioButton
    Friend WithEvents GroupHorarioLaboral As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblInicio As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblFin As DevComponents.DotNetBar.LabelX
    Friend WithEvents RemEndTime As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents RemStartTime As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents btnPacNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPacSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPacEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPacAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbTipoConsulta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblTipoConsulta As DevComponents.DotNetBar.LabelX
End Class
