<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.TabControl_emp = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpNotas = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.RichTxtNotas_emp = New System.Windows.Forms.RichTextBox
        Me.lblRegistroBiometrico = New DevComponents.DotNetBar.LabelX
        Me.gpRegistroBiometrico = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnRegistroBiometrico = New DevComponents.DotNetBar.ButtonX
        Me.tabNotas_emp = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.txtnumdoc_emp = New DevExpress.XtraEditors.TextEdit
        Me.btnBorrarFoto = New DevComponents.DotNetBar.ButtonX
        Me.txtClave2_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblClave2_emp = New DevComponents.DotNetBar.LabelX
        Me.txtClave_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblClave_emp = New DevComponents.DotNetBar.LabelX
        Me.gPanel_nivel = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbPerfilAcceso = New System.Windows.Forms.ComboBox
        Me.btnFotoA = New DevComponents.DotNetBar.ButtonX
        Me.btnFoto = New DevComponents.DotNetBar.ButtonX
        Me.pbFoto_emp = New System.Windows.Forms.PictureBox
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.txtIdempleado = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblIdempleado = New DevComponents.DotNetBar.LabelX
        Me.gPanel_Edad = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblNumaños = New DevComponents.DotNetBar.LabelX
        Me.rbtAños_emp = New System.Windows.Forms.RadioButton
        Me.rbtmeses_emp = New System.Windows.Forms.RadioButton
        Me.gPanel_Sexo = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtFemenino_emp = New System.Windows.Forms.RadioButton
        Me.rbtMasculino_emp = New System.Windows.Forms.RadioButton
        Me.lblnumdoc_emp = New DevComponents.DotNetBar.LabelX
        Me.txtEspecialidad_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbtipodoc_emp = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.lbltipodoc_emp = New DevComponents.DotNetBar.LabelX
        Me.cmbfecnac_emp = New System.Windows.Forms.DateTimePicker
        Me.cmbfecingreso_emp = New System.Windows.Forms.DateTimePicker
        Me.lblfecnac_emp = New DevComponents.DotNetBar.LabelX
        Me.txtresidencia_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtnombres_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtapellidos_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblfecingreso_emp = New DevComponents.DotNetBar.LabelX
        Me.lblEspecialidad_emp = New DevComponents.DotNetBar.LabelX
        Me.lblnombres_emp = New DevComponents.DotNetBar.LabelX
        Me.lblresidencia_emp = New DevComponents.DotNetBar.LabelX
        Me.lblapellidos_emp = New DevComponents.DotNetBar.LabelX
        Me.tabDPersonales_emp = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpConyuge = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX
        Me.txtOcuConyuge_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX
        Me.txtCelConyuge_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX
        Me.txtTelConyuge_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtConyuge_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX
        Me.gpPadres = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX
        Me.txtOcuMadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX
        Me.txtOcuPadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX
        Me.txtCelMadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX
        Me.txtCelPadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX
        Me.txtTelMadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtMadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.txtTelPadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtPadre_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.gpContactos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnNoEmail = New DevComponents.DotNetBar.ButtonX
        Me.txtemail_emp = New DevExpress.XtraEditors.TextEdit
        Me.txtweb_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.txtCelular_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtFax_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.txtTelCasa_emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.tabContactos_emp = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.OpenFileDialogEmp = New System.Windows.Forms.OpenFileDialog
        Me.ErrorProvideremp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BalloonUsuarios = New DevComponents.DotNetBar.BalloonTip
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        CType(Me.TabControl_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_emp.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.gpNotas.SuspendLayout()
        Me.gpRegistroBiometrico.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.txtnumdoc_emp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gPanel_nivel.SuspendLayout()
        CType(Me.pbFoto_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gPanel_Edad.SuspendLayout()
        Me.gPanel_Sexo.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpConyuge.SuspendLayout()
        Me.gpPadres.SuspendLayout()
        Me.gpContactos.SuspendLayout()
        CType(Me.txtemail_emp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvideremp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_emp
        '
        Me.TabControl_emp.CanReorderTabs = True
        Me.TabControl_emp.Controls.Add(Me.TabControlPanel2)
        Me.TabControl_emp.Controls.Add(Me.TabControlPanel3)
        Me.TabControl_emp.Controls.Add(Me.TabControlPanel1)
        Me.TabControl_emp.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl_emp.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_emp.Name = "TabControl_emp"
        Me.TabControl_emp.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl_emp.SelectedTabIndex = 0
        Me.TabControl_emp.Size = New System.Drawing.Size(532, 433)
        Me.TabControl_emp.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl_emp.TabIndex = 0
        Me.TabControl_emp.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineWithNavigationBox
        Me.TabControl_emp.Tabs.Add(Me.tabDPersonales_emp)
        Me.TabControl_emp.Tabs.Add(Me.tabContactos_emp)
        Me.TabControl_emp.Tabs.Add(Me.tabNotas_emp)
        Me.TabControl_emp.Text = "Datos Personales"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.gpNotas)
        Me.TabControlPanel3.Controls.Add(Me.lblRegistroBiometrico)
        Me.TabControlPanel3.Controls.Add(Me.gpRegistroBiometrico)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(532, 411)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 1
        Me.TabControlPanel3.TabItem = Me.tabNotas_emp
        '
        'gpNotas
        '
        Me.gpNotas.BackColor = System.Drawing.Color.Transparent
        Me.gpNotas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpNotas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpNotas.Controls.Add(Me.RichTxtNotas_emp)
        Me.gpNotas.Location = New System.Drawing.Point(21, 17)
        Me.gpNotas.Name = "gpNotas"
        Me.gpNotas.Size = New System.Drawing.Size(487, 251)
        '
        '
        '
        Me.gpNotas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpNotas.Style.BackColorGradientAngle = 90
        Me.gpNotas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpNotas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNotas.Style.BorderBottomWidth = 1
        Me.gpNotas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpNotas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNotas.Style.BorderLeftWidth = 1
        Me.gpNotas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNotas.Style.BorderRightWidth = 1
        Me.gpNotas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNotas.Style.BorderTopWidth = 1
        Me.gpNotas.Style.CornerDiameter = 4
        Me.gpNotas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpNotas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpNotas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpNotas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpNotas.TabIndex = 5
        Me.gpNotas.Text = "Notas Usuarios"
        '
        'RichTxtNotas_emp
        '
        Me.RichTxtNotas_emp.Location = New System.Drawing.Point(14, 11)
        Me.RichTxtNotas_emp.Name = "RichTxtNotas_emp"
        Me.RichTxtNotas_emp.Size = New System.Drawing.Size(454, 207)
        Me.RichTxtNotas_emp.TabIndex = 0
        Me.RichTxtNotas_emp.Text = ""
        '
        'lblRegistroBiometrico
        '
        Me.lblRegistroBiometrico.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRegistroBiometrico.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroBiometrico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRegistroBiometrico.Location = New System.Drawing.Point(21, 278)
        Me.lblRegistroBiometrico.Name = "lblRegistroBiometrico"
        Me.lblRegistroBiometrico.Size = New System.Drawing.Size(488, 23)
        Me.lblRegistroBiometrico.TabIndex = 3
        Me.lblRegistroBiometrico.Text = "REGISTRO BIOMETRICO"
        Me.lblRegistroBiometrico.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpRegistroBiometrico
        '
        Me.gpRegistroBiometrico.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpRegistroBiometrico.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpRegistroBiometrico.Controls.Add(Me.btnRegistroBiometrico)
        Me.gpRegistroBiometrico.Location = New System.Drawing.Point(20, 313)
        Me.gpRegistroBiometrico.Name = "gpRegistroBiometrico"
        Me.gpRegistroBiometrico.Size = New System.Drawing.Size(488, 79)
        '
        '
        '
        Me.gpRegistroBiometrico.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpRegistroBiometrico.Style.BackColorGradientAngle = 90
        Me.gpRegistroBiometrico.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpRegistroBiometrico.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRegistroBiometrico.Style.BorderBottomWidth = 1
        Me.gpRegistroBiometrico.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpRegistroBiometrico.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRegistroBiometrico.Style.BorderLeftWidth = 1
        Me.gpRegistroBiometrico.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRegistroBiometrico.Style.BorderRightWidth = 1
        Me.gpRegistroBiometrico.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpRegistroBiometrico.Style.BorderTopWidth = 1
        Me.gpRegistroBiometrico.Style.CornerDiameter = 4
        Me.gpRegistroBiometrico.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpRegistroBiometrico.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpRegistroBiometrico.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpRegistroBiometrico.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpRegistroBiometrico.TabIndex = 4
        '
        'btnRegistroBiometrico
        '
        Me.btnRegistroBiometrico.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegistroBiometrico.Image = CType(resources.GetObject("btnRegistroBiometrico.Image"), System.Drawing.Image)
        Me.btnRegistroBiometrico.Location = New System.Drawing.Point(156, 17)
        Me.btnRegistroBiometrico.Name = "btnRegistroBiometrico"
        Me.btnRegistroBiometrico.Size = New System.Drawing.Size(166, 39)
        Me.btnRegistroBiometrico.TabIndex = 0
        Me.btnRegistroBiometrico.Text = "REGISTRO BIOMETRICO"
        '
        'tabNotas_emp
        '
        Me.tabNotas_emp.AttachedControl = Me.TabControlPanel3
        Me.tabNotas_emp.Name = "tabNotas_emp"
        Me.tabNotas_emp.Text = "Notas"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.txtnumdoc_emp)
        Me.TabControlPanel2.Controls.Add(Me.btnBorrarFoto)
        Me.TabControlPanel2.Controls.Add(Me.txtClave2_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblClave2_emp)
        Me.TabControlPanel2.Controls.Add(Me.txtClave_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblClave_emp)
        Me.TabControlPanel2.Controls.Add(Me.gPanel_nivel)
        Me.TabControlPanel2.Controls.Add(Me.btnFotoA)
        Me.TabControlPanel2.Controls.Add(Me.btnFoto)
        Me.TabControlPanel2.Controls.Add(Me.pbFoto_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblTituloVentana)
        Me.TabControlPanel2.Controls.Add(Me.txtIdempleado)
        Me.TabControlPanel2.Controls.Add(Me.lblIdempleado)
        Me.TabControlPanel2.Controls.Add(Me.gPanel_Edad)
        Me.TabControlPanel2.Controls.Add(Me.gPanel_Sexo)
        Me.TabControlPanel2.Controls.Add(Me.lblnumdoc_emp)
        Me.TabControlPanel2.Controls.Add(Me.txtEspecialidad_emp)
        Me.TabControlPanel2.Controls.Add(Me.cmbtipodoc_emp)
        Me.TabControlPanel2.Controls.Add(Me.lbltipodoc_emp)
        Me.TabControlPanel2.Controls.Add(Me.cmbfecnac_emp)
        Me.TabControlPanel2.Controls.Add(Me.cmbfecingreso_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblfecnac_emp)
        Me.TabControlPanel2.Controls.Add(Me.txtresidencia_emp)
        Me.TabControlPanel2.Controls.Add(Me.txtnombres_emp)
        Me.TabControlPanel2.Controls.Add(Me.txtapellidos_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblfecingreso_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblEspecialidad_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblnombres_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblresidencia_emp)
        Me.TabControlPanel2.Controls.Add(Me.lblapellidos_emp)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 411)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 0
        Me.TabControlPanel2.TabItem = Me.tabDPersonales_emp
        '
        'txtnumdoc_emp
        '
        Me.txtnumdoc_emp.EditValue = "0"
        Me.txtnumdoc_emp.Location = New System.Drawing.Point(381, 252)
        Me.txtnumdoc_emp.Name = "txtnumdoc_emp"
        Me.txtnumdoc_emp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtnumdoc_emp.Properties.Appearance.Options.UseFont = True
        Me.txtnumdoc_emp.Properties.Appearance.Options.UseTextOptions = True
        Me.txtnumdoc_emp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtnumdoc_emp.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtnumdoc_emp.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtnumdoc_emp.Properties.Mask.BeepOnError = True
        Me.txtnumdoc_emp.Properties.Mask.EditMask = "n0"
        Me.txtnumdoc_emp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtnumdoc_emp.Properties.Mask.ShowPlaceHolders = False
        Me.txtnumdoc_emp.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtnumdoc_emp.Size = New System.Drawing.Size(131, 21)
        Me.txtnumdoc_emp.TabIndex = 21
        '
        'btnBorrarFoto
        '
        Me.btnBorrarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarFoto.Image = CType(resources.GetObject("btnBorrarFoto.Image"), System.Drawing.Image)
        Me.btnBorrarFoto.Location = New System.Drawing.Point(78, 164)
        Me.btnBorrarFoto.Name = "btnBorrarFoto"
        Me.btnBorrarFoto.Size = New System.Drawing.Size(37, 36)
        Me.btnBorrarFoto.TabIndex = 12
        '
        'txtClave2_emp
        '
        '
        '
        '
        Me.txtClave2_emp.Border.Class = "TextBoxBorder"
        Me.txtClave2_emp.Location = New System.Drawing.Point(374, 365)
        Me.txtClave2_emp.Name = "txtClave2_emp"
        Me.txtClave2_emp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave2_emp.Size = New System.Drawing.Size(136, 20)
        Me.txtClave2_emp.TabIndex = 28
        Me.txtClave2_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lblClave2_emp
        '
        Me.lblClave2_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblClave2_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblClave2_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblClave2_emp.Location = New System.Drawing.Point(271, 365)
        Me.lblClave2_emp.Name = "lblClave2_emp"
        Me.lblClave2_emp.Size = New System.Drawing.Size(97, 20)
        Me.lblClave2_emp.TabIndex = 27
        Me.lblClave2_emp.Text = "Verificacion Clave"
        Me.lblClave2_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtClave_emp
        '
        '
        '
        '
        Me.txtClave_emp.Border.Class = "TextBoxBorder"
        Me.txtClave_emp.Location = New System.Drawing.Point(374, 339)
        Me.txtClave_emp.Name = "txtClave_emp"
        Me.txtClave_emp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave_emp.Size = New System.Drawing.Size(136, 20)
        Me.txtClave_emp.TabIndex = 26
        Me.txtClave_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lblClave_emp
        '
        Me.lblClave_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblClave_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblClave_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblClave_emp.Location = New System.Drawing.Point(271, 339)
        Me.lblClave_emp.Name = "lblClave_emp"
        Me.lblClave_emp.Size = New System.Drawing.Size(97, 20)
        Me.lblClave_emp.TabIndex = 25
        Me.lblClave_emp.Text = "Clave de Ingreso "
        Me.lblClave_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gPanel_nivel
        '
        Me.gPanel_nivel.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_nivel.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_nivel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_nivel.Controls.Add(Me.cmbPerfilAcceso)
        Me.gPanel_nivel.Location = New System.Drawing.Point(21, 324)
        Me.gPanel_nivel.Name = "gPanel_nivel"
        Me.gPanel_nivel.Size = New System.Drawing.Size(225, 68)
        '
        '
        '
        Me.gPanel_nivel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gPanel_nivel.Style.BackColorGradientAngle = 90
        Me.gPanel_nivel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gPanel_nivel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_nivel.Style.BorderBottomWidth = 1
        Me.gPanel_nivel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gPanel_nivel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_nivel.Style.BorderLeftWidth = 1
        Me.gPanel_nivel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_nivel.Style.BorderRightWidth = 1
        Me.gPanel_nivel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_nivel.Style.BorderTopWidth = 1
        Me.gPanel_nivel.Style.CornerDiameter = 4
        Me.gPanel_nivel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gPanel_nivel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gPanel_nivel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gPanel_nivel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gPanel_nivel.TabIndex = 24
        Me.gPanel_nivel.Text = "Nivel de Acceso"
        '
        'cmbPerfilAcceso
        '
        Me.cmbPerfilAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPerfilAcceso.Location = New System.Drawing.Point(11, 12)
        Me.cmbPerfilAcceso.Name = "cmbPerfilAcceso"
        Me.cmbPerfilAcceso.Size = New System.Drawing.Size(198, 21)
        Me.cmbPerfilAcceso.TabIndex = 0
        '
        'btnFotoA
        '
        Me.btnFotoA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFotoA.Image = CType(resources.GetObject("btnFotoA.Image"), System.Drawing.Image)
        Me.btnFotoA.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFotoA.Location = New System.Drawing.Point(16, 164)
        Me.btnFotoA.Name = "btnFotoA"
        Me.btnFotoA.Size = New System.Drawing.Size(58, 36)
        Me.btnFotoA.TabIndex = 11
        Me.btnFotoA.Text = "ARCHIVO"
        '
        'btnFoto
        '
        Me.btnFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFoto.Image = CType(resources.GetObject("btnFoto.Image"), System.Drawing.Image)
        Me.btnFoto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFoto.Location = New System.Drawing.Point(121, 164)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(58, 36)
        Me.btnFoto.TabIndex = 13
        Me.btnFoto.Text = "CAMARA"
        '
        'pbFoto_emp
        '
        Me.pbFoto_emp.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pbFoto_emp.Location = New System.Drawing.Point(16, 51)
        Me.pbFoto_emp.Name = "pbFoto_emp"
        Me.pbFoto_emp.Size = New System.Drawing.Size(160, 108)
        Me.pbFoto_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto_emp.TabIndex = 99
        Me.pbFoto_emp.TabStop = False
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(16, 15)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(497, 23)
        Me.lblTituloVentana.TabIndex = 0
        Me.lblTituloVentana.Text = "USUARIOS"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdempleado
        '
        Me.txtIdempleado.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdempleado.Border.Class = "TextBoxBorder"
        Me.txtIdempleado.Location = New System.Drawing.Point(441, 284)
        Me.txtIdempleado.Name = "txtIdempleado"
        Me.txtIdempleado.ReadOnly = True
        Me.txtIdempleado.Size = New System.Drawing.Size(72, 20)
        Me.txtIdempleado.TabIndex = 23
        Me.txtIdempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIdempleado
        '
        Me.lblIdempleado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIdempleado.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblIdempleado.ForeColor = System.Drawing.Color.Navy
        Me.lblIdempleado.Location = New System.Drawing.Point(344, 284)
        Me.lblIdempleado.Name = "lblIdempleado"
        Me.lblIdempleado.Size = New System.Drawing.Size(91, 20)
        Me.lblIdempleado.TabIndex = 22
        Me.lblIdempleado.Text = "Código Interno"
        Me.lblIdempleado.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gPanel_Edad
        '
        Me.gPanel_Edad.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Edad.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Edad.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Edad.Controls.Add(Me.lblNumaños)
        Me.gPanel_Edad.Controls.Add(Me.rbtAños_emp)
        Me.gPanel_Edad.Controls.Add(Me.rbtmeses_emp)
        Me.gPanel_Edad.Location = New System.Drawing.Point(121, 207)
        Me.gPanel_Edad.Name = "gPanel_Edad"
        Me.gPanel_Edad.Size = New System.Drawing.Size(120, 70)
        '
        '
        '
        Me.gPanel_Edad.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gPanel_Edad.Style.BackColorGradientAngle = 90
        Me.gPanel_Edad.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gPanel_Edad.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Edad.Style.BorderBottomWidth = 1
        Me.gPanel_Edad.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gPanel_Edad.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Edad.Style.BorderLeftWidth = 1
        Me.gPanel_Edad.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Edad.Style.BorderRightWidth = 1
        Me.gPanel_Edad.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Edad.Style.BorderTopWidth = 1
        Me.gPanel_Edad.Style.CornerDiameter = 4
        Me.gPanel_Edad.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gPanel_Edad.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gPanel_Edad.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gPanel_Edad.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gPanel_Edad.TabIndex = 17
        Me.gPanel_Edad.Text = "Edad"
        '
        'lblNumaños
        '
        Me.lblNumaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumaños.Location = New System.Drawing.Point(70, 11)
        Me.lblNumaños.Name = "lblNumaños"
        Me.lblNumaños.Size = New System.Drawing.Size(40, 23)
        Me.lblNumaños.TabIndex = 1
        Me.lblNumaños.Text = "000"
        Me.lblNumaños.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbtAños_emp
        '
        Me.rbtAños_emp.AutoSize = True
        Me.rbtAños_emp.Checked = True
        Me.rbtAños_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAños_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtAños_emp.Location = New System.Drawing.Point(3, 3)
        Me.rbtAños_emp.Name = "rbtAños_emp"
        Me.rbtAños_emp.Size = New System.Drawing.Size(53, 17)
        Me.rbtAños_emp.TabIndex = 0
        Me.rbtAños_emp.TabStop = True
        Me.rbtAños_emp.Text = "Años"
        Me.rbtAños_emp.UseVisualStyleBackColor = True
        '
        'rbtmeses_emp
        '
        Me.rbtmeses_emp.AutoSize = True
        Me.rbtmeses_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtmeses_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtmeses_emp.Location = New System.Drawing.Point(3, 26)
        Me.rbtmeses_emp.Name = "rbtmeses_emp"
        Me.rbtmeses_emp.Size = New System.Drawing.Size(61, 17)
        Me.rbtmeses_emp.TabIndex = 2
        Me.rbtmeses_emp.Text = "Meses"
        Me.rbtmeses_emp.UseVisualStyleBackColor = True
        '
        'gPanel_Sexo
        '
        Me.gPanel_Sexo.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Sexo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Sexo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Sexo.Controls.Add(Me.rbtFemenino_emp)
        Me.gPanel_Sexo.Controls.Add(Me.rbtMasculino_emp)
        Me.gPanel_Sexo.Location = New System.Drawing.Point(17, 206)
        Me.gPanel_Sexo.Name = "gPanel_Sexo"
        Me.gPanel_Sexo.Size = New System.Drawing.Size(102, 71)
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
        Me.gPanel_Sexo.TabIndex = 16
        Me.gPanel_Sexo.Text = "Sexo"
        '
        'rbtFemenino_emp
        '
        Me.rbtFemenino_emp.AutoSize = True
        Me.rbtFemenino_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemenino_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtFemenino_emp.Location = New System.Drawing.Point(3, 26)
        Me.rbtFemenino_emp.Name = "rbtFemenino_emp"
        Me.rbtFemenino_emp.Size = New System.Drawing.Size(79, 17)
        Me.rbtFemenino_emp.TabIndex = 1
        Me.rbtFemenino_emp.Text = "Femenino"
        Me.rbtFemenino_emp.UseVisualStyleBackColor = True
        '
        'rbtMasculino_emp
        '
        Me.rbtMasculino_emp.AutoSize = True
        Me.rbtMasculino_emp.Checked = True
        Me.rbtMasculino_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMasculino_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtMasculino_emp.Location = New System.Drawing.Point(3, 3)
        Me.rbtMasculino_emp.Name = "rbtMasculino_emp"
        Me.rbtMasculino_emp.Size = New System.Drawing.Size(82, 17)
        Me.rbtMasculino_emp.TabIndex = 0
        Me.rbtMasculino_emp.TabStop = True
        Me.rbtMasculino_emp.Text = "Masculino"
        Me.rbtMasculino_emp.UseVisualStyleBackColor = True
        '
        'lblnumdoc_emp
        '
        Me.lblnumdoc_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnumdoc_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblnumdoc_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblnumdoc_emp.Location = New System.Drawing.Point(344, 252)
        Me.lblnumdoc_emp.Name = "lblnumdoc_emp"
        Me.lblnumdoc_emp.Size = New System.Drawing.Size(31, 20)
        Me.lblnumdoc_emp.TabIndex = 20
        Me.lblnumdoc_emp.Text = "No."
        Me.lblnumdoc_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtEspecialidad_emp
        '
        '
        '
        '
        Me.txtEspecialidad_emp.Border.Class = "TextBoxBorder"
        Me.txtEspecialidad_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEspecialidad_emp.Location = New System.Drawing.Point(260, 131)
        Me.txtEspecialidad_emp.Name = "txtEspecialidad_emp"
        Me.txtEspecialidad_emp.Size = New System.Drawing.Size(253, 20)
        Me.txtEspecialidad_emp.TabIndex = 8
        Me.txtEspecialidad_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'cmbtipodoc_emp
        '
        Me.cmbtipodoc_emp.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte", "C.EXTRANGERIA"})
        Me.cmbtipodoc_emp.DisplayMember = "Text"
        Me.cmbtipodoc_emp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipodoc_emp.FormattingEnabled = True
        Me.cmbtipodoc_emp.ItemHeight = 25
        Me.cmbtipodoc_emp.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cmbtipodoc_emp.Location = New System.Drawing.Point(381, 215)
        Me.cmbtipodoc_emp.Name = "cmbtipodoc_emp"
        Me.cmbtipodoc_emp.Size = New System.Drawing.Size(132, 31)
        Me.cmbtipodoc_emp.TabIndex = 19
        Me.cmbtipodoc_emp.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipodoc_emp.WatermarkText = "TIPO DOCUMENTO"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "T.I"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "CEDULA"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "PASAPORTE"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "C.EXTRANGERIA"
        '
        'lbltipodoc_emp
        '
        Me.lbltipodoc_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbltipodoc_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbltipodoc_emp.ForeColor = System.Drawing.Color.Navy
        Me.lbltipodoc_emp.Location = New System.Drawing.Point(247, 215)
        Me.lbltipodoc_emp.Name = "lbltipodoc_emp"
        Me.lbltipodoc_emp.Size = New System.Drawing.Size(128, 20)
        Me.lbltipodoc_emp.TabIndex = 18
        Me.lbltipodoc_emp.Text = "Documento de Identidad"
        Me.lbltipodoc_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbfecnac_emp
        '
        Me.cmbfecnac_emp.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecnac_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecnac_emp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbfecnac_emp.Location = New System.Drawing.Point(411, 185)
        Me.cmbfecnac_emp.Name = "cmbfecnac_emp"
        Me.cmbfecnac_emp.Size = New System.Drawing.Size(101, 23)
        Me.cmbfecnac_emp.TabIndex = 15
        Me.cmbfecnac_emp.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'cmbfecingreso_emp
        '
        Me.cmbfecingreso_emp.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecingreso_emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecingreso_emp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecingreso_emp.Location = New System.Drawing.Point(412, 159)
        Me.cmbfecingreso_emp.Name = "cmbfecingreso_emp"
        Me.cmbfecingreso_emp.Size = New System.Drawing.Size(100, 23)
        Me.cmbfecingreso_emp.TabIndex = 10
        Me.cmbfecingreso_emp.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblfecnac_emp
        '
        Me.lblfecnac_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfecnac_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblfecnac_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblfecnac_emp.Location = New System.Drawing.Point(315, 185)
        Me.lblfecnac_emp.Name = "lblfecnac_emp"
        Me.lblfecnac_emp.Size = New System.Drawing.Size(90, 20)
        Me.lblfecnac_emp.TabIndex = 14
        Me.lblfecnac_emp.Text = "Fecha de Nacim."
        Me.lblfecnac_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtresidencia_emp
        '
        '
        '
        '
        Me.txtresidencia_emp.Border.Class = "TextBoxBorder"
        Me.txtresidencia_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtresidencia_emp.Location = New System.Drawing.Point(260, 103)
        Me.txtresidencia_emp.Name = "txtresidencia_emp"
        Me.txtresidencia_emp.Size = New System.Drawing.Size(253, 20)
        Me.txtresidencia_emp.TabIndex = 6
        Me.txtresidencia_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtnombres_emp
        '
        '
        '
        '
        Me.txtnombres_emp.Border.Class = "TextBoxBorder"
        Me.txtnombres_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombres_emp.Location = New System.Drawing.Point(260, 77)
        Me.txtnombres_emp.Name = "txtnombres_emp"
        Me.txtnombres_emp.Size = New System.Drawing.Size(253, 20)
        Me.txtnombres_emp.TabIndex = 4
        Me.txtnombres_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtapellidos_emp
        '
        '
        '
        '
        Me.txtapellidos_emp.Border.Class = "TextBoxBorder"
        Me.txtapellidos_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapellidos_emp.Location = New System.Drawing.Point(260, 51)
        Me.txtapellidos_emp.Name = "txtapellidos_emp"
        Me.txtapellidos_emp.Size = New System.Drawing.Size(253, 20)
        Me.txtapellidos_emp.TabIndex = 2
        Me.txtapellidos_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lblfecingreso_emp
        '
        Me.lblfecingreso_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfecingreso_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblfecingreso_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblfecingreso_emp.Location = New System.Drawing.Point(315, 159)
        Me.lblfecingreso_emp.Name = "lblfecingreso_emp"
        Me.lblfecingreso_emp.Size = New System.Drawing.Size(91, 20)
        Me.lblfecingreso_emp.TabIndex = 9
        Me.lblfecingreso_emp.Text = "Ingresó"
        Me.lblfecingreso_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblEspecialidad_emp
        '
        Me.lblEspecialidad_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEspecialidad_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblEspecialidad_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblEspecialidad_emp.Location = New System.Drawing.Point(182, 131)
        Me.lblEspecialidad_emp.Name = "lblEspecialidad_emp"
        Me.lblEspecialidad_emp.Size = New System.Drawing.Size(72, 20)
        Me.lblEspecialidad_emp.TabIndex = 7
        Me.lblEspecialidad_emp.Text = "Especialidad"
        Me.lblEspecialidad_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblnombres_emp
        '
        Me.lblnombres_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnombres_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblnombres_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblnombres_emp.Location = New System.Drawing.Point(182, 77)
        Me.lblnombres_emp.Name = "lblnombres_emp"
        Me.lblnombres_emp.Size = New System.Drawing.Size(72, 20)
        Me.lblnombres_emp.TabIndex = 3
        Me.lblnombres_emp.Text = "Nombres"
        Me.lblnombres_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblresidencia_emp
        '
        Me.lblresidencia_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblresidencia_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblresidencia_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblresidencia_emp.Location = New System.Drawing.Point(182, 103)
        Me.lblresidencia_emp.Name = "lblresidencia_emp"
        Me.lblresidencia_emp.Size = New System.Drawing.Size(72, 20)
        Me.lblresidencia_emp.TabIndex = 5
        Me.lblresidencia_emp.Text = "Residencia"
        Me.lblresidencia_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblapellidos_emp
        '
        Me.lblapellidos_emp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblapellidos_emp.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblapellidos_emp.ForeColor = System.Drawing.Color.Navy
        Me.lblapellidos_emp.Location = New System.Drawing.Point(182, 51)
        Me.lblapellidos_emp.Name = "lblapellidos_emp"
        Me.lblapellidos_emp.Size = New System.Drawing.Size(72, 20)
        Me.lblapellidos_emp.TabIndex = 1
        Me.lblapellidos_emp.Text = "Apellidos"
        Me.lblapellidos_emp.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tabDPersonales_emp
        '
        Me.tabDPersonales_emp.AttachedControl = Me.TabControlPanel2
        Me.tabDPersonales_emp.Name = "tabDPersonales_emp"
        Me.tabDPersonales_emp.Text = "Datos Personales"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.gpConyuge)
        Me.TabControlPanel1.Controls.Add(Me.gpPadres)
        Me.TabControlPanel1.Controls.Add(Me.gpContactos)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 411)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 2
        Me.TabControlPanel1.TabItem = Me.tabContactos_emp
        '
        'gpConyuge
        '
        Me.gpConyuge.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpConyuge.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpConyuge.Controls.Add(Me.LabelX31)
        Me.gpConyuge.Controls.Add(Me.txtOcuConyuge_emp)
        Me.gpConyuge.Controls.Add(Me.LabelX32)
        Me.gpConyuge.Controls.Add(Me.txtCelConyuge_emp)
        Me.gpConyuge.Controls.Add(Me.LabelX24)
        Me.gpConyuge.Controls.Add(Me.txtTelConyuge_emp)
        Me.gpConyuge.Controls.Add(Me.txtConyuge_emp)
        Me.gpConyuge.Controls.Add(Me.LabelX25)
        Me.gpConyuge.Location = New System.Drawing.Point(21, 305)
        Me.gpConyuge.Name = "gpConyuge"
        Me.gpConyuge.Size = New System.Drawing.Size(499, 87)
        '
        '
        '
        Me.gpConyuge.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpConyuge.Style.BackColorGradientAngle = 90
        Me.gpConyuge.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpConyuge.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpConyuge.Style.BorderBottomWidth = 1
        Me.gpConyuge.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpConyuge.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpConyuge.Style.BorderLeftWidth = 1
        Me.gpConyuge.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpConyuge.Style.BorderRightWidth = 1
        Me.gpConyuge.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpConyuge.Style.BorderTopWidth = 1
        Me.gpConyuge.Style.CornerDiameter = 4
        Me.gpConyuge.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpConyuge.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpConyuge.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpConyuge.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpConyuge.TabIndex = 2
        '
        'LabelX31
        '
        Me.LabelX31.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX31.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX31.ForeColor = System.Drawing.Color.Navy
        Me.LabelX31.Location = New System.Drawing.Point(254, 48)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(63, 20)
        Me.LabelX31.TabIndex = 6
        Me.LabelX31.Text = "Ocupación"
        Me.LabelX31.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtOcuConyuge_emp
        '
        '
        '
        '
        Me.txtOcuConyuge_emp.Border.Class = "TextBoxBorder"
        Me.txtOcuConyuge_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcuConyuge_emp.Location = New System.Drawing.Point(323, 48)
        Me.txtOcuConyuge_emp.Name = "txtOcuConyuge_emp"
        Me.txtOcuConyuge_emp.Size = New System.Drawing.Size(165, 20)
        Me.txtOcuConyuge_emp.TabIndex = 7
        '
        'LabelX32
        '
        Me.LabelX32.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX32.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX32.ForeColor = System.Drawing.Color.Navy
        Me.LabelX32.Location = New System.Drawing.Point(5, 48)
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.Size = New System.Drawing.Size(97, 20)
        Me.LabelX32.TabIndex = 4
        Me.LabelX32.Text = "Celular"
        Me.LabelX32.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelConyuge_emp
        '
        '
        '
        '
        Me.txtCelConyuge_emp.Border.Class = "TextBoxBorder"
        Me.txtCelConyuge_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelConyuge_emp.Location = New System.Drawing.Point(106, 48)
        Me.txtCelConyuge_emp.Name = "txtCelConyuge_emp"
        Me.txtCelConyuge_emp.Size = New System.Drawing.Size(142, 20)
        Me.txtCelConyuge_emp.TabIndex = 5
        '
        'LabelX24
        '
        Me.LabelX24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX24.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX24.ForeColor = System.Drawing.Color.Navy
        Me.LabelX24.Location = New System.Drawing.Point(289, 12)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(60, 20)
        Me.LabelX24.TabIndex = 2
        Me.LabelX24.Text = "Telefono"
        Me.LabelX24.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelConyuge_emp
        '
        '
        '
        '
        Me.txtTelConyuge_emp.Border.Class = "TextBoxBorder"
        Me.txtTelConyuge_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelConyuge_emp.Location = New System.Drawing.Point(355, 12)
        Me.txtTelConyuge_emp.Name = "txtTelConyuge_emp"
        Me.txtTelConyuge_emp.Size = New System.Drawing.Size(133, 20)
        Me.txtTelConyuge_emp.TabIndex = 3
        '
        'txtConyuge_emp
        '
        '
        '
        '
        Me.txtConyuge_emp.Border.Class = "TextBoxBorder"
        Me.txtConyuge_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConyuge_emp.Location = New System.Drawing.Point(106, 12)
        Me.txtConyuge_emp.Name = "txtConyuge_emp"
        Me.txtConyuge_emp.Size = New System.Drawing.Size(177, 20)
        Me.txtConyuge_emp.TabIndex = 1
        '
        'LabelX25
        '
        Me.LabelX25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX25.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX25.ForeColor = System.Drawing.Color.Navy
        Me.LabelX25.Location = New System.Drawing.Point(5, 12)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(98, 20)
        Me.LabelX25.TabIndex = 0
        Me.LabelX25.Text = "Nombre Esposo(a)"
        Me.LabelX25.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpPadres
        '
        Me.gpPadres.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPadres.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPadres.Controls.Add(Me.LabelX30)
        Me.gpPadres.Controls.Add(Me.txtOcuMadre_emp)
        Me.gpPadres.Controls.Add(Me.LabelX29)
        Me.gpPadres.Controls.Add(Me.txtOcuPadre_emp)
        Me.gpPadres.Controls.Add(Me.LabelX28)
        Me.gpPadres.Controls.Add(Me.txtCelMadre_emp)
        Me.gpPadres.Controls.Add(Me.LabelX27)
        Me.gpPadres.Controls.Add(Me.txtCelPadre_emp)
        Me.gpPadres.Controls.Add(Me.LabelX22)
        Me.gpPadres.Controls.Add(Me.txtTelMadre_emp)
        Me.gpPadres.Controls.Add(Me.txtMadre_emp)
        Me.gpPadres.Controls.Add(Me.LabelX23)
        Me.gpPadres.Controls.Add(Me.LabelX20)
        Me.gpPadres.Controls.Add(Me.txtTelPadre_emp)
        Me.gpPadres.Controls.Add(Me.txtPadre_emp)
        Me.gpPadres.Controls.Add(Me.LabelX19)
        Me.gpPadres.Location = New System.Drawing.Point(20, 156)
        Me.gpPadres.Name = "gpPadres"
        Me.gpPadres.Size = New System.Drawing.Size(499, 140)
        '
        '
        '
        Me.gpPadres.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpPadres.Style.BackColorGradientAngle = 90
        Me.gpPadres.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpPadres.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPadres.Style.BorderBottomWidth = 1
        Me.gpPadres.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpPadres.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPadres.Style.BorderLeftWidth = 1
        Me.gpPadres.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPadres.Style.BorderRightWidth = 1
        Me.gpPadres.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPadres.Style.BorderTopWidth = 1
        Me.gpPadres.Style.CornerDiameter = 4
        Me.gpPadres.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpPadres.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpPadres.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpPadres.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpPadres.TabIndex = 1
        '
        'LabelX30
        '
        Me.LabelX30.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX30.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX30.ForeColor = System.Drawing.Color.Navy
        Me.LabelX30.Location = New System.Drawing.Point(255, 101)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(62, 20)
        Me.LabelX30.TabIndex = 14
        Me.LabelX30.Text = "Ocupación"
        Me.LabelX30.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtOcuMadre_emp
        '
        '
        '
        '
        Me.txtOcuMadre_emp.Border.Class = "TextBoxBorder"
        Me.txtOcuMadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcuMadre_emp.Location = New System.Drawing.Point(323, 101)
        Me.txtOcuMadre_emp.Name = "txtOcuMadre_emp"
        Me.txtOcuMadre_emp.Size = New System.Drawing.Size(165, 20)
        Me.txtOcuMadre_emp.TabIndex = 15
        '
        'LabelX29
        '
        Me.LabelX29.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX29.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX29.ForeColor = System.Drawing.Color.Navy
        Me.LabelX29.Location = New System.Drawing.Point(254, 39)
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.Size = New System.Drawing.Size(63, 20)
        Me.LabelX29.TabIndex = 6
        Me.LabelX29.Text = "Ocupación"
        Me.LabelX29.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtOcuPadre_emp
        '
        '
        '
        '
        Me.txtOcuPadre_emp.Border.Class = "TextBoxBorder"
        Me.txtOcuPadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcuPadre_emp.Location = New System.Drawing.Point(323, 39)
        Me.txtOcuPadre_emp.Name = "txtOcuPadre_emp"
        Me.txtOcuPadre_emp.Size = New System.Drawing.Size(165, 20)
        Me.txtOcuPadre_emp.TabIndex = 7
        '
        'LabelX28
        '
        Me.LabelX28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX28.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX28.ForeColor = System.Drawing.Color.Navy
        Me.LabelX28.Location = New System.Drawing.Point(6, 101)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(95, 20)
        Me.LabelX28.TabIndex = 12
        Me.LabelX28.Text = "Celular"
        Me.LabelX28.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelMadre_emp
        '
        '
        '
        '
        Me.txtCelMadre_emp.Border.Class = "TextBoxBorder"
        Me.txtCelMadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelMadre_emp.Location = New System.Drawing.Point(107, 101)
        Me.txtCelMadre_emp.Name = "txtCelMadre_emp"
        Me.txtCelMadre_emp.Size = New System.Drawing.Size(141, 20)
        Me.txtCelMadre_emp.TabIndex = 13
        '
        'LabelX27
        '
        Me.LabelX27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX27.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX27.ForeColor = System.Drawing.Color.Navy
        Me.LabelX27.Location = New System.Drawing.Point(5, 39)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(95, 20)
        Me.LabelX27.TabIndex = 4
        Me.LabelX27.Text = "Celular"
        Me.LabelX27.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelPadre_emp
        '
        '
        '
        '
        Me.txtCelPadre_emp.Border.Class = "TextBoxBorder"
        Me.txtCelPadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelPadre_emp.Location = New System.Drawing.Point(106, 39)
        Me.txtCelPadre_emp.Name = "txtCelPadre_emp"
        Me.txtCelPadre_emp.Size = New System.Drawing.Size(142, 20)
        Me.txtCelPadre_emp.TabIndex = 5
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX22.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX22.ForeColor = System.Drawing.Color.Navy
        Me.LabelX22.Location = New System.Drawing.Point(289, 75)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(60, 20)
        Me.LabelX22.TabIndex = 10
        Me.LabelX22.Text = "Telefono"
        Me.LabelX22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelMadre_emp
        '
        '
        '
        '
        Me.txtTelMadre_emp.Border.Class = "TextBoxBorder"
        Me.txtTelMadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelMadre_emp.Location = New System.Drawing.Point(355, 75)
        Me.txtTelMadre_emp.Name = "txtTelMadre_emp"
        Me.txtTelMadre_emp.Size = New System.Drawing.Size(133, 20)
        Me.txtTelMadre_emp.TabIndex = 11
        '
        'txtMadre_emp
        '
        '
        '
        '
        Me.txtMadre_emp.Border.Class = "TextBoxBorder"
        Me.txtMadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMadre_emp.Location = New System.Drawing.Point(106, 75)
        Me.txtMadre_emp.Name = "txtMadre_emp"
        Me.txtMadre_emp.Size = New System.Drawing.Size(177, 20)
        Me.txtMadre_emp.TabIndex = 9
        '
        'LabelX23
        '
        Me.LabelX23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX23.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX23.ForeColor = System.Drawing.Color.Navy
        Me.LabelX23.Location = New System.Drawing.Point(5, 75)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(95, 20)
        Me.LabelX23.TabIndex = 8
        Me.LabelX23.Text = "Nombre Madre"
        Me.LabelX23.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX20.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX20.ForeColor = System.Drawing.Color.Navy
        Me.LabelX20.Location = New System.Drawing.Point(289, 13)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(60, 20)
        Me.LabelX20.TabIndex = 2
        Me.LabelX20.Text = "Telefono"
        Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelPadre_emp
        '
        '
        '
        '
        Me.txtTelPadre_emp.Border.Class = "TextBoxBorder"
        Me.txtTelPadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelPadre_emp.Location = New System.Drawing.Point(355, 13)
        Me.txtTelPadre_emp.Name = "txtTelPadre_emp"
        Me.txtTelPadre_emp.Size = New System.Drawing.Size(133, 20)
        Me.txtTelPadre_emp.TabIndex = 3
        '
        'txtPadre_emp
        '
        '
        '
        '
        Me.txtPadre_emp.Border.Class = "TextBoxBorder"
        Me.txtPadre_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPadre_emp.Location = New System.Drawing.Point(106, 13)
        Me.txtPadre_emp.Name = "txtPadre_emp"
        Me.txtPadre_emp.Size = New System.Drawing.Size(177, 20)
        Me.txtPadre_emp.TabIndex = 1
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX19.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX19.ForeColor = System.Drawing.Color.Navy
        Me.LabelX19.Location = New System.Drawing.Point(5, 13)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(95, 20)
        Me.LabelX19.TabIndex = 0
        Me.LabelX19.Text = "Nombre Padre"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpContactos
        '
        Me.gpContactos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpContactos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpContactos.Controls.Add(Me.btnNoEmail)
        Me.gpContactos.Controls.Add(Me.txtemail_emp)
        Me.gpContactos.Controls.Add(Me.txtweb_emp)
        Me.gpContactos.Controls.Add(Me.LabelX26)
        Me.gpContactos.Controls.Add(Me.LabelX21)
        Me.gpContactos.Controls.Add(Me.txtCelular_emp)
        Me.gpContactos.Controls.Add(Me.txtFax_emp)
        Me.gpContactos.Controls.Add(Me.LabelX18)
        Me.gpContactos.Controls.Add(Me.LabelX16)
        Me.gpContactos.Controls.Add(Me.txtTelCasa_emp)
        Me.gpContactos.Controls.Add(Me.LabelX15)
        Me.gpContactos.Location = New System.Drawing.Point(20, 18)
        Me.gpContactos.Name = "gpContactos"
        Me.gpContactos.Size = New System.Drawing.Size(499, 130)
        '
        '
        '
        Me.gpContactos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpContactos.Style.BackColorGradientAngle = 90
        Me.gpContactos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpContactos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpContactos.Style.BorderBottomWidth = 1
        Me.gpContactos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpContactos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpContactos.Style.BorderLeftWidth = 1
        Me.gpContactos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpContactos.Style.BorderRightWidth = 1
        Me.gpContactos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpContactos.Style.BorderTopWidth = 1
        Me.gpContactos.Style.CornerDiameter = 4
        Me.gpContactos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpContactos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpContactos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpContactos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpContactos.TabIndex = 0
        '
        'btnNoEmail
        '
        Me.btnNoEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail.Image = CType(resources.GetObject("btnNoEmail.Image"), System.Drawing.Image)
        Me.btnNoEmail.Location = New System.Drawing.Point(466, 64)
        Me.btnNoEmail.Name = "btnNoEmail"
        Me.btnNoEmail.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail.TabIndex = 8
        '
        'txtemail_emp
        '
        Me.txtemail_emp.Location = New System.Drawing.Point(106, 64)
        Me.txtemail_emp.Name = "txtemail_emp"
        Me.txtemail_emp.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemail_emp.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemail_emp.Properties.Mask.BeepOnError = True
        Me.txtemail_emp.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemail_emp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemail_emp.Properties.Mask.ShowPlaceHolders = False
        Me.txtemail_emp.Size = New System.Drawing.Size(354, 20)
        Me.txtemail_emp.TabIndex = 7
        '
        'txtweb_emp
        '
        '
        '
        '
        Me.txtweb_emp.Border.Class = "TextBoxBorder"
        Me.txtweb_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtweb_emp.Location = New System.Drawing.Point(106, 90)
        Me.txtweb_emp.Name = "txtweb_emp"
        Me.txtweb_emp.Size = New System.Drawing.Size(382, 20)
        Me.txtweb_emp.TabIndex = 10
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX26.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX26.ForeColor = System.Drawing.Color.Navy
        Me.LabelX26.Location = New System.Drawing.Point(5, 90)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(95, 21)
        Me.LabelX26.TabIndex = 9
        Me.LabelX26.Text = "Pagina Web"
        Me.LabelX26.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX21.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX21.ForeColor = System.Drawing.Color.Navy
        Me.LabelX21.Location = New System.Drawing.Point(254, 12)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(95, 20)
        Me.LabelX21.TabIndex = 2
        Me.LabelX21.Text = "Celular"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelular_emp
        '
        '
        '
        '
        Me.txtCelular_emp.Border.Class = "TextBoxBorder"
        Me.txtCelular_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular_emp.Location = New System.Drawing.Point(355, 12)
        Me.txtCelular_emp.Name = "txtCelular_emp"
        Me.txtCelular_emp.Size = New System.Drawing.Size(133, 20)
        Me.txtCelular_emp.TabIndex = 3
        Me.txtCelular_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtFax_emp
        '
        '
        '
        '
        Me.txtFax_emp.Border.Class = "TextBoxBorder"
        Me.txtFax_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax_emp.Location = New System.Drawing.Point(106, 38)
        Me.txtFax_emp.Name = "txtFax_emp"
        Me.txtFax_emp.Size = New System.Drawing.Size(142, 20)
        Me.txtFax_emp.TabIndex = 5
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX18.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(5, 38)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(95, 20)
        Me.LabelX18.TabIndex = 4
        Me.LabelX18.Text = "Fax"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX16.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX16.ForeColor = System.Drawing.Color.Navy
        Me.LabelX16.Location = New System.Drawing.Point(5, 12)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(95, 20)
        Me.LabelX16.TabIndex = 0
        Me.LabelX16.Text = "Telefono Casa"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelCasa_emp
        '
        '
        '
        '
        Me.txtTelCasa_emp.Border.Class = "TextBoxBorder"
        Me.txtTelCasa_emp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelCasa_emp.Location = New System.Drawing.Point(106, 12)
        Me.txtTelCasa_emp.Name = "txtTelCasa_emp"
        Me.txtTelCasa_emp.Size = New System.Drawing.Size(142, 20)
        Me.txtTelCasa_emp.TabIndex = 1
        Me.txtTelCasa_emp.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX15.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX15.ForeColor = System.Drawing.Color.Navy
        Me.LabelX15.Location = New System.Drawing.Point(5, 64)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(95, 20)
        Me.LabelX15.TabIndex = 6
        Me.LabelX15.Text = "E-Mail"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tabContactos_emp
        '
        Me.tabContactos_emp.AttachedControl = Me.TabControlPanel1
        Me.tabContactos_emp.Name = "tabContactos_emp"
        Me.tabContactos_emp.Text = "Contactos"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(318, 439)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(91, 39)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(118, 439)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(91, 39)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(418, 439)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 39)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(218, 439)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(91, 39)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(18, 439)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(91, 39)
        Me.btnAdicionar.TabIndex = 0
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'ErrorProvideremp
        '
        Me.ErrorProvideremp.ContainerControl = Me
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
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
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.TabControl_emp)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Usuarios"
        CType(Me.TabControl_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_emp.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        Me.gpNotas.ResumeLayout(False)
        Me.gpRegistroBiometrico.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.txtnumdoc_emp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gPanel_nivel.ResumeLayout(False)
        CType(Me.pbFoto_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gPanel_Edad.ResumeLayout(False)
        Me.gPanel_Edad.PerformLayout()
        Me.gPanel_Sexo.ResumeLayout(False)
        Me.gPanel_Sexo.PerformLayout()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.gpConyuge.ResumeLayout(False)
        Me.gpPadres.ResumeLayout(False)
        Me.gpContactos.ResumeLayout(False)
        CType(Me.txtemail_emp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvideremp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl_emp As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIdempleado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblIdempleado As DevComponents.DotNetBar.LabelX
    Friend WithEvents gPanel_Edad As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblNumaños As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbtAños_emp As System.Windows.Forms.RadioButton
    Friend WithEvents rbtmeses_emp As System.Windows.Forms.RadioButton
    Friend WithEvents gPanel_Sexo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtFemenino_emp As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMasculino_emp As System.Windows.Forms.RadioButton
    Friend WithEvents lblnumdoc_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEspecialidad_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbtipodoc_emp As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbltipodoc_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecnac_emp As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbfecingreso_emp As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfecnac_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtresidencia_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnombres_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtapellidos_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblfecingreso_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblEspecialidad_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblnombres_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblresidencia_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblapellidos_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents tabDPersonales_emp As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents RichTxtNotas_emp As System.Windows.Forms.RichTextBox
    Friend WithEvents tabNotas_emp As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents gpConyuge As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOcuConyuge_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelConyuge_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelConyuge_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtConyuge_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpPadres As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOcuMadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOcuPadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelMadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelPadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelMadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelPadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPadre_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpContactos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtweb_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelular_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFax_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelCasa_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tabContactos_emp As DevComponents.DotNetBar.TabItem
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFotoA As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pbFoto_emp As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialogEmp As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ErrorProvideremp As System.Windows.Forms.ErrorProvider
    Friend WithEvents gPanel_nivel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtClave_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblClave_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents BalloonUsuarios As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents txtemail_emp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnNoEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtClave2_emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblClave2_emp As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbPerfilAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents btnBorrarFoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtnumdoc_emp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblRegistroBiometrico As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpRegistroBiometrico As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnRegistroBiometrico As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpNotas As DevComponents.DotNetBar.Controls.GroupPanel
End Class
