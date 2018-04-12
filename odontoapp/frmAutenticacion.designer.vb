<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutenticacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutenticacion))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.TabControl1 = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtRutaImagenes = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtRutaCallCenter2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.txtClaveCallCenter = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtUsuarioCallCenter = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtRutaCallCenter = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtClave = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtBD = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtServidor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.TabItem1 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtsmtpPass = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.txtsmtpPort = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtsmtpHost = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtsmtpCuenta = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtsmtpNombre = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.TabItem2 = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnGrabar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.TabControl1)
        Me.RibbonClientPanel1.Controls.Add(Me.btnGrabar)
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
        'TabControl1
        '
        Me.TabControl1.CanReorderTabs = True
        Me.TabControl1.CloseButtonOnTabsAlwaysDisplayed = False
        Me.TabControl1.Controls.Add(Me.TabControlPanel1)
        Me.TabControl1.Controls.Add(Me.TabControlPanel2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.SelectedTabIndex = 2
        Me.TabControl1.Size = New System.Drawing.Size(532, 417)
        Me.TabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl1.TabIndex = 86
        Me.TabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox
        Me.TabControl1.Tabs.Add(Me.TabItem1)
        Me.TabControl1.Tabs.Add(Me.TabItem2)
        Me.TabControl1.Text = "TabControl1"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel4)
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel2)
        Me.TabControlPanel1.Controls.Add(Me.LabelX5)
        Me.TabControlPanel1.Controls.Add(Me.GroupPanel1)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 395)
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
        'GroupPanel4
        '
        Me.GroupPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.txtRutaImagenes)
        Me.GroupPanel4.Controls.Add(Me.LabelX19)
        Me.GroupPanel4.Location = New System.Drawing.Point(27, 322)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(459, 60)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel4.TabIndex = 87
        Me.GroupPanel4.Text = "RUTA IMAGENES"
        '
        'txtRutaImagenes
        '
        '
        '
        '
        Me.txtRutaImagenes.Border.Class = "TextBoxBorder"
        Me.txtRutaImagenes.Location = New System.Drawing.Point(179, 12)
        Me.txtRutaImagenes.Name = "txtRutaImagenes"
        Me.txtRutaImagenes.Size = New System.Drawing.Size(237, 20)
        Me.txtRutaImagenes.TabIndex = 5
        '
        'LabelX19
        '
        Me.LabelX19.ForeColor = System.Drawing.Color.Navy
        Me.LabelX19.Location = New System.Drawing.Point(23, 9)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(131, 23)
        Me.LabelX19.TabIndex = 0
        Me.LabelX19.Text = "RUTA IMAGENES"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtRutaCallCenter2)
        Me.GroupPanel2.Controls.Add(Me.LabelX15)
        Me.GroupPanel2.Controls.Add(Me.txtClaveCallCenter)
        Me.GroupPanel2.Controls.Add(Me.txtUsuarioCallCenter)
        Me.GroupPanel2.Controls.Add(Me.txtRutaCallCenter)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Location = New System.Drawing.Point(27, 173)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(459, 143)
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
        Me.GroupPanel2.TabIndex = 86
        Me.GroupPanel2.Text = "AUTENTICACION CALL CENTER"
        '
        'txtRutaCallCenter2
        '
        '
        '
        '
        Me.txtRutaCallCenter2.Border.Class = "TextBoxBorder"
        Me.txtRutaCallCenter2.Location = New System.Drawing.Point(179, 41)
        Me.txtRutaCallCenter2.Name = "txtRutaCallCenter2"
        Me.txtRutaCallCenter2.Size = New System.Drawing.Size(237, 20)
        Me.txtRutaCallCenter2.TabIndex = 9
        '
        'LabelX15
        '
        Me.LabelX15.ForeColor = System.Drawing.Color.Navy
        Me.LabelX15.Location = New System.Drawing.Point(23, 38)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(131, 23)
        Me.LabelX15.TabIndex = 8
        Me.LabelX15.Text = "RUTA CALL CENTER 2"
        '
        'txtClaveCallCenter
        '
        '
        '
        '
        Me.txtClaveCallCenter.Border.Class = "TextBoxBorder"
        Me.txtClaveCallCenter.Location = New System.Drawing.Point(179, 93)
        Me.txtClaveCallCenter.Name = "txtClaveCallCenter"
        Me.txtClaveCallCenter.Size = New System.Drawing.Size(237, 20)
        Me.txtClaveCallCenter.TabIndex = 7
        Me.txtClaveCallCenter.UseSystemPasswordChar = True
        '
        'txtUsuarioCallCenter
        '
        '
        '
        '
        Me.txtUsuarioCallCenter.Border.Class = "TextBoxBorder"
        Me.txtUsuarioCallCenter.Location = New System.Drawing.Point(179, 67)
        Me.txtUsuarioCallCenter.Name = "txtUsuarioCallCenter"
        Me.txtUsuarioCallCenter.Size = New System.Drawing.Size(237, 20)
        Me.txtUsuarioCallCenter.TabIndex = 6
        '
        'txtRutaCallCenter
        '
        '
        '
        '
        Me.txtRutaCallCenter.Border.Class = "TextBoxBorder"
        Me.txtRutaCallCenter.Location = New System.Drawing.Point(179, 12)
        Me.txtRutaCallCenter.Name = "txtRutaCallCenter"
        Me.txtRutaCallCenter.Size = New System.Drawing.Size(237, 20)
        Me.txtRutaCallCenter.TabIndex = 5
        '
        'LabelX6
        '
        Me.LabelX6.ForeColor = System.Drawing.Color.Navy
        Me.LabelX6.Location = New System.Drawing.Point(23, 93)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 23)
        Me.LabelX6.TabIndex = 3
        Me.LabelX6.Text = "CLAVE"
        '
        'LabelX7
        '
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(23, 67)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 23)
        Me.LabelX7.TabIndex = 2
        Me.LabelX7.Text = "USUARIO"
        '
        'LabelX9
        '
        Me.LabelX9.ForeColor = System.Drawing.Color.Navy
        Me.LabelX9.Location = New System.Drawing.Point(23, 9)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(131, 23)
        Me.LabelX9.TabIndex = 0
        Me.LabelX9.Text = "RUTA CALL CENTER"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX5.Location = New System.Drawing.Point(27, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(459, 23)
        Me.LabelX5.TabIndex = 84
        Me.LabelX5.Text = "CONEXION SERVIDOR MYSQL - CALL CENTER"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtClave)
        Me.GroupPanel1.Controls.Add(Me.txtUsuario)
        Me.GroupPanel1.Controls.Add(Me.txtBD)
        Me.GroupPanel1.Controls.Add(Me.txtServidor)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Location = New System.Drawing.Point(27, 33)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(459, 134)
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
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "AUTENTICACION BASE DE DATOS MYSQL"
        '
        'txtClave
        '
        '
        '
        '
        Me.txtClave.Border.Class = "TextBoxBorder"
        Me.txtClave.Location = New System.Drawing.Point(179, 81)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(237, 20)
        Me.txtClave.TabIndex = 7
        Me.txtClave.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.Border.Class = "TextBoxBorder"
        Me.txtUsuario.Location = New System.Drawing.Point(179, 55)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(237, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'txtBD
        '
        '
        '
        '
        Me.txtBD.Border.Class = "TextBoxBorder"
        Me.txtBD.Location = New System.Drawing.Point(179, 29)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(237, 20)
        Me.txtBD.TabIndex = 5
        '
        'txtServidor
        '
        '
        '
        '
        Me.txtServidor.Border.Class = "TextBoxBorder"
        Me.txtServidor.Location = New System.Drawing.Point(179, 3)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(237, 20)
        Me.txtServidor.TabIndex = 4
        '
        'LabelX4
        '
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(23, 81)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "CLAVE"
        '
        'LabelX3
        '
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(23, 55)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "USUARIO"
        '
        'LabelX2
        '
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(23, 0)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "SERVIDOR"
        '
        'LabelX1
        '
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(23, 26)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(103, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "BASE DE DATOS"
        '
        'TabItem1
        '
        Me.TabItem1.AttachedControl = Me.TabControlPanel1
        Me.TabItem1.Name = "TabItem1"
        Me.TabItem1.Text = "MYSQ - CALLCENTER"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.GroupPanel3)
        Me.TabControlPanel2.Controls.Add(Me.LabelX8)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 395)
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
        'GroupPanel3
        '
        Me.GroupPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.txtsmtpPass)
        Me.GroupPanel3.Controls.Add(Me.LabelX14)
        Me.GroupPanel3.Controls.Add(Me.txtsmtpPort)
        Me.GroupPanel3.Controls.Add(Me.txtsmtpHost)
        Me.GroupPanel3.Controls.Add(Me.txtsmtpCuenta)
        Me.GroupPanel3.Controls.Add(Me.txtsmtpNombre)
        Me.GroupPanel3.Controls.Add(Me.LabelX10)
        Me.GroupPanel3.Controls.Add(Me.LabelX11)
        Me.GroupPanel3.Controls.Add(Me.LabelX12)
        Me.GroupPanel3.Controls.Add(Me.LabelX13)
        Me.GroupPanel3.Location = New System.Drawing.Point(19, 89)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(470, 224)
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
        Me.GroupPanel3.TabIndex = 86
        Me.GroupPanel3.Text = "AUTENTICACION SERVIDOR SMTP EMAIL"
        '
        'txtsmtpPass
        '
        '
        '
        '
        Me.txtsmtpPass.Border.Class = "TextBoxBorder"
        Me.txtsmtpPass.Location = New System.Drawing.Point(165, 125)
        Me.txtsmtpPass.Name = "txtsmtpPass"
        Me.txtsmtpPass.Size = New System.Drawing.Size(276, 20)
        Me.txtsmtpPass.TabIndex = 9
        Me.txtsmtpPass.UseSystemPasswordChar = True
        '
        'LabelX14
        '
        Me.LabelX14.ForeColor = System.Drawing.Color.Navy
        Me.LabelX14.Location = New System.Drawing.Point(23, 125)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(75, 23)
        Me.LabelX14.TabIndex = 8
        Me.LabelX14.Text = "PASSWORD"
        '
        'txtsmtpPort
        '
        '
        '
        '
        Me.txtsmtpPort.Border.Class = "TextBoxBorder"
        Me.txtsmtpPort.Location = New System.Drawing.Point(165, 96)
        Me.txtsmtpPort.Name = "txtsmtpPort"
        Me.txtsmtpPort.Size = New System.Drawing.Size(276, 20)
        Me.txtsmtpPort.TabIndex = 7
        '
        'txtsmtpHost
        '
        '
        '
        '
        Me.txtsmtpHost.Border.Class = "TextBoxBorder"
        Me.txtsmtpHost.Location = New System.Drawing.Point(165, 70)
        Me.txtsmtpHost.Name = "txtsmtpHost"
        Me.txtsmtpHost.Size = New System.Drawing.Size(276, 20)
        Me.txtsmtpHost.TabIndex = 6
        '
        'txtsmtpCuenta
        '
        '
        '
        '
        Me.txtsmtpCuenta.Border.Class = "TextBoxBorder"
        Me.txtsmtpCuenta.Location = New System.Drawing.Point(165, 44)
        Me.txtsmtpCuenta.Name = "txtsmtpCuenta"
        Me.txtsmtpCuenta.Size = New System.Drawing.Size(276, 20)
        Me.txtsmtpCuenta.TabIndex = 5
        '
        'txtsmtpNombre
        '
        '
        '
        '
        Me.txtsmtpNombre.Border.Class = "TextBoxBorder"
        Me.txtsmtpNombre.Location = New System.Drawing.Point(165, 18)
        Me.txtsmtpNombre.Name = "txtsmtpNombre"
        Me.txtsmtpNombre.Size = New System.Drawing.Size(276, 20)
        Me.txtsmtpNombre.TabIndex = 4
        '
        'LabelX10
        '
        Me.LabelX10.ForeColor = System.Drawing.Color.Navy
        Me.LabelX10.Location = New System.Drawing.Point(23, 96)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(75, 23)
        Me.LabelX10.TabIndex = 3
        Me.LabelX10.Text = "SMTP PORT"
        '
        'LabelX11
        '
        Me.LabelX11.ForeColor = System.Drawing.Color.Navy
        Me.LabelX11.Location = New System.Drawing.Point(23, 70)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(75, 23)
        Me.LabelX11.TabIndex = 2
        Me.LabelX11.Text = "SMTP HOST"
        '
        'LabelX12
        '
        Me.LabelX12.ForeColor = System.Drawing.Color.Navy
        Me.LabelX12.Location = New System.Drawing.Point(23, 15)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(75, 23)
        Me.LabelX12.TabIndex = 1
        Me.LabelX12.Text = "NOMBRE"
        '
        'LabelX13
        '
        Me.LabelX13.ForeColor = System.Drawing.Color.Navy
        Me.LabelX13.Location = New System.Drawing.Point(23, 41)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(128, 23)
        Me.LabelX13.TabIndex = 0
        Me.LabelX13.Text = "CUENTA DE CORREO"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX8.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX8.Location = New System.Drawing.Point(19, 13)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(470, 23)
        Me.LabelX8.TabIndex = 85
        Me.LabelX8.Text = "CONFIGURACION CUENTA DE CORREO ELECTRONICO"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'TabItem2
        '
        Me.TabItem2.AttachedControl = Me.TabControlPanel2
        Me.TabItem2.Name = "TabItem2"
        Me.TabItem2.Text = "EMAIL"
        '
        'btnGrabar
        '
        Me.btnGrabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.Location = New System.Drawing.Point(330, 435)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(91, 39)
        Me.btnGrabar.TabIndex = 2
        Me.btnGrabar.Text = "GRABAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(429, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 39)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "SALIR"
        '
        'frmAutenticacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAutenticacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Autenticacion"
        Me.TopMost = True
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnGrabar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabControl1 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem2 As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtClaveCallCenter As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsuarioCallCenter As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRutaCallCenter As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtClave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBD As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtServidor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TabItem1 As DevComponents.DotNetBar.TabItem
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtsmtpPort As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsmtpHost As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsmtpCuenta As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtsmtpNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtsmtpPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtRutaImagenes As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRutaCallCenter2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
End Class
