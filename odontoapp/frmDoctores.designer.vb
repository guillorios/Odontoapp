<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoctores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDoctores))
        Me.TabControl_Doc = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.cmbEspecialidades = New System.Windows.Forms.ComboBox
        Me.txtnumdoc_doc = New DevExpress.XtraEditors.TextEdit
        Me.btnBorrarFoto = New DevComponents.DotNetBar.ButtonX
        Me.btnFotoA = New DevComponents.DotNetBar.ButtonX
        Me.btnFoto = New DevComponents.DotNetBar.ButtonX
        Me.pbFoto_doc = New System.Windows.Forms.PictureBox
        Me.txtoficina_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lbloficina_doc = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.txtIddoctor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblIddoctor = New DevComponents.DotNetBar.LabelX
        Me.gPanel_Edad = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblNumaños = New DevComponents.DotNetBar.LabelX
        Me.rbtAños_doc = New System.Windows.Forms.RadioButton
        Me.rbtmeses_doc = New System.Windows.Forms.RadioButton
        Me.gPanel_Sexo = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtFemenino_doc = New System.Windows.Forms.RadioButton
        Me.rbtMasculino_doc = New System.Windows.Forms.RadioButton
        Me.lblnumdoc_doc = New DevComponents.DotNetBar.LabelX
        Me.cmbtipodoc_doc = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.lbltipodoc_doc = New DevComponents.DotNetBar.LabelX
        Me.cmbfecnac_doc = New System.Windows.Forms.DateTimePicker
        Me.cmbfecingreso_doc = New System.Windows.Forms.DateTimePicker
        Me.lblfecnac_doc = New DevComponents.DotNetBar.LabelX
        Me.txtresidencia_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtnombres_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtapellidos_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblfecingreso_doc = New DevComponents.DotNetBar.LabelX
        Me.lblEspecialidad_doc = New DevComponents.DotNetBar.LabelX
        Me.lblnombres_doc = New DevComponents.DotNetBar.LabelX
        Me.lblresidencia_doc = New DevComponents.DotNetBar.LabelX
        Me.lblapellidos_doc = New DevComponents.DotNetBar.LabelX
        Me.tabDPersonales_doc = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.RichTxtNotas_doc = New System.Windows.Forms.RichTextBox
        Me.tabNotas_doc = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpContactos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnNoEmail = New DevComponents.DotNetBar.ButtonX
        Me.txtemail_doc = New DevExpress.XtraEditors.TextEdit
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.txtTelOficina_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtweb_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.txtCelular_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtFax_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.txtTelCasa_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.tabContactos_doc = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.OpenFileDialogDoc = New System.Windows.Forms.OpenFileDialog
        Me.ErrorProviderdoc = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblRegistroBiometrico = New DevComponents.DotNetBar.LabelX
        Me.gpRegistroBiometrico = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnRegistroBiometrico = New DevComponents.DotNetBar.ButtonX
        Me.gpNotas = New DevComponents.DotNetBar.Controls.GroupPanel
        CType(Me.TabControl_Doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_Doc.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.txtnumdoc_doc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFoto_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gPanel_Edad.SuspendLayout()
        Me.gPanel_Sexo.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpContactos.SuspendLayout()
        CType(Me.txtemail_doc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderdoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpRegistroBiometrico.SuspendLayout()
        Me.gpNotas.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_Doc
        '
        Me.TabControl_Doc.CanReorderTabs = True
        Me.TabControl_Doc.Controls.Add(Me.TabControlPanel3)
        Me.TabControl_Doc.Controls.Add(Me.TabControlPanel1)
        Me.TabControl_Doc.Controls.Add(Me.TabControlPanel2)
        Me.TabControl_Doc.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl_Doc.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Doc.Name = "TabControl_Doc"
        Me.TabControl_Doc.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl_Doc.SelectedTabIndex = 0
        Me.TabControl_Doc.Size = New System.Drawing.Size(532, 428)
        Me.TabControl_Doc.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl_Doc.TabIndex = 0
        Me.TabControl_Doc.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineWithNavigationBox
        Me.TabControl_Doc.Tabs.Add(Me.tabDPersonales_doc)
        Me.TabControl_Doc.Tabs.Add(Me.tabContactos_doc)
        Me.TabControl_Doc.Tabs.Add(Me.tabNotas_doc)
        Me.TabControl_Doc.Text = "Datos Personales"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.cmbEspecialidades)
        Me.TabControlPanel2.Controls.Add(Me.txtnumdoc_doc)
        Me.TabControlPanel2.Controls.Add(Me.btnBorrarFoto)
        Me.TabControlPanel2.Controls.Add(Me.btnFotoA)
        Me.TabControlPanel2.Controls.Add(Me.btnFoto)
        Me.TabControlPanel2.Controls.Add(Me.pbFoto_doc)
        Me.TabControlPanel2.Controls.Add(Me.txtoficina_doc)
        Me.TabControlPanel2.Controls.Add(Me.lbloficina_doc)
        Me.TabControlPanel2.Controls.Add(Me.lblTituloVentana)
        Me.TabControlPanel2.Controls.Add(Me.txtIddoctor)
        Me.TabControlPanel2.Controls.Add(Me.lblIddoctor)
        Me.TabControlPanel2.Controls.Add(Me.gPanel_Edad)
        Me.TabControlPanel2.Controls.Add(Me.gPanel_Sexo)
        Me.TabControlPanel2.Controls.Add(Me.lblnumdoc_doc)
        Me.TabControlPanel2.Controls.Add(Me.cmbtipodoc_doc)
        Me.TabControlPanel2.Controls.Add(Me.lbltipodoc_doc)
        Me.TabControlPanel2.Controls.Add(Me.cmbfecnac_doc)
        Me.TabControlPanel2.Controls.Add(Me.cmbfecingreso_doc)
        Me.TabControlPanel2.Controls.Add(Me.lblfecnac_doc)
        Me.TabControlPanel2.Controls.Add(Me.txtresidencia_doc)
        Me.TabControlPanel2.Controls.Add(Me.txtnombres_doc)
        Me.TabControlPanel2.Controls.Add(Me.txtapellidos_doc)
        Me.TabControlPanel2.Controls.Add(Me.lblfecingreso_doc)
        Me.TabControlPanel2.Controls.Add(Me.lblEspecialidad_doc)
        Me.TabControlPanel2.Controls.Add(Me.lblnombres_doc)
        Me.TabControlPanel2.Controls.Add(Me.lblresidencia_doc)
        Me.TabControlPanel2.Controls.Add(Me.lblapellidos_doc)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 406)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 0
        Me.TabControlPanel2.TabItem = Me.tabDPersonales_doc
        '
        'cmbEspecialidades
        '
        Me.cmbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEspecialidades.FormattingEnabled = True
        Me.cmbEspecialidades.Location = New System.Drawing.Point(97, 220)
        Me.cmbEspecialidades.Name = "cmbEspecialidades"
        Me.cmbEspecialidades.Size = New System.Drawing.Size(423, 21)
        Me.cmbEspecialidades.TabIndex = 17
        '
        'txtnumdoc_doc
        '
        Me.txtnumdoc_doc.EditValue = "0"
        Me.txtnumdoc_doc.Location = New System.Drawing.Point(367, 294)
        Me.txtnumdoc_doc.Name = "txtnumdoc_doc"
        Me.txtnumdoc_doc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtnumdoc_doc.Properties.Appearance.Options.UseFont = True
        Me.txtnumdoc_doc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtnumdoc_doc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtnumdoc_doc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtnumdoc_doc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtnumdoc_doc.Properties.Mask.BeepOnError = True
        Me.txtnumdoc_doc.Properties.Mask.EditMask = "n0"
        Me.txtnumdoc_doc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtnumdoc_doc.Properties.Mask.ShowPlaceHolders = False
        Me.txtnumdoc_doc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtnumdoc_doc.Size = New System.Drawing.Size(153, 21)
        Me.txtnumdoc_doc.TabIndex = 23
        '
        'btnBorrarFoto
        '
        Me.btnBorrarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarFoto.Image = CType(resources.GetObject("btnBorrarFoto.Image"), System.Drawing.Image)
        Me.btnBorrarFoto.Location = New System.Drawing.Point(72, 156)
        Me.btnBorrarFoto.Name = "btnBorrarFoto"
        Me.btnBorrarFoto.Size = New System.Drawing.Size(37, 37)
        Me.btnBorrarFoto.TabIndex = 10
        '
        'btnFotoA
        '
        Me.btnFotoA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFotoA.Image = CType(resources.GetObject("btnFotoA.Image"), System.Drawing.Image)
        Me.btnFotoA.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFotoA.Location = New System.Drawing.Point(12, 156)
        Me.btnFotoA.Name = "btnFotoA"
        Me.btnFotoA.Size = New System.Drawing.Size(58, 37)
        Me.btnFotoA.TabIndex = 9
        Me.btnFotoA.Text = "ARCHIVO"
        '
        'btnFoto
        '
        Me.btnFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFoto.Image = CType(resources.GetObject("btnFoto.Image"), System.Drawing.Image)
        Me.btnFoto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFoto.Location = New System.Drawing.Point(112, 156)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(58, 37)
        Me.btnFoto.TabIndex = 11
        Me.btnFoto.Text = "CAMARA"
        '
        'pbFoto_doc
        '
        Me.pbFoto_doc.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pbFoto_doc.Location = New System.Drawing.Point(12, 43)
        Me.pbFoto_doc.Name = "pbFoto_doc"
        Me.pbFoto_doc.Size = New System.Drawing.Size(158, 108)
        Me.pbFoto_doc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto_doc.TabIndex = 99
        Me.pbFoto_doc.TabStop = False
        '
        'txtoficina_doc
        '
        '
        '
        '
        Me.txtoficina_doc.Border.Class = "TextBoxBorder"
        Me.txtoficina_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtoficina_doc.Location = New System.Drawing.Point(254, 124)
        Me.txtoficina_doc.Name = "txtoficina_doc"
        Me.txtoficina_doc.Size = New System.Drawing.Size(266, 20)
        Me.txtoficina_doc.TabIndex = 8
        Me.txtoficina_doc.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lbloficina_doc
        '
        Me.lbloficina_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbloficina_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbloficina_doc.ForeColor = System.Drawing.Color.Navy
        Me.lbloficina_doc.Location = New System.Drawing.Point(176, 124)
        Me.lbloficina_doc.Name = "lbloficina_doc"
        Me.lbloficina_doc.Size = New System.Drawing.Size(72, 20)
        Me.lbloficina_doc.TabIndex = 7
        Me.lbloficina_doc.Text = "Oficina"
        Me.lbloficina_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(12, 8)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(508, 23)
        Me.lblTituloVentana.TabIndex = 0
        Me.lblTituloVentana.Text = "DOCTORES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIddoctor
        '
        Me.txtIddoctor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIddoctor.Border.Class = "TextBoxBorder"
        Me.txtIddoctor.Location = New System.Drawing.Point(476, 331)
        Me.txtIddoctor.Name = "txtIddoctor"
        Me.txtIddoctor.ReadOnly = True
        Me.txtIddoctor.Size = New System.Drawing.Size(44, 20)
        Me.txtIddoctor.TabIndex = 25
        Me.txtIddoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIddoctor
        '
        Me.lblIddoctor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIddoctor.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblIddoctor.ForeColor = System.Drawing.Color.Navy
        Me.lblIddoctor.Location = New System.Drawing.Point(379, 331)
        Me.lblIddoctor.Name = "lblIddoctor"
        Me.lblIddoctor.Size = New System.Drawing.Size(91, 20)
        Me.lblIddoctor.TabIndex = 24
        Me.lblIddoctor.Text = "Código Interno"
        Me.lblIddoctor.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gPanel_Edad
        '
        Me.gPanel_Edad.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Edad.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Edad.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Edad.Controls.Add(Me.lblNumaños)
        Me.gPanel_Edad.Controls.Add(Me.rbtAños_doc)
        Me.gPanel_Edad.Controls.Add(Me.rbtmeses_doc)
        Me.gPanel_Edad.Location = New System.Drawing.Point(119, 263)
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
        Me.gPanel_Edad.TabIndex = 21
        Me.gPanel_Edad.Text = "Edad"
        '
        'lblNumaños
        '
        Me.lblNumaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumaños.Location = New System.Drawing.Point(70, 11)
        Me.lblNumaños.Name = "lblNumaños"
        Me.lblNumaños.Size = New System.Drawing.Size(40, 23)
        Me.lblNumaños.TabIndex = 1
        Me.lblNumaños.Text = "0"
        Me.lblNumaños.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbtAños_doc
        '
        Me.rbtAños_doc.AutoSize = True
        Me.rbtAños_doc.Checked = True
        Me.rbtAños_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAños_doc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtAños_doc.Location = New System.Drawing.Point(3, 3)
        Me.rbtAños_doc.Name = "rbtAños_doc"
        Me.rbtAños_doc.Size = New System.Drawing.Size(53, 17)
        Me.rbtAños_doc.TabIndex = 0
        Me.rbtAños_doc.TabStop = True
        Me.rbtAños_doc.Text = "Años"
        Me.rbtAños_doc.UseVisualStyleBackColor = True
        '
        'rbtmeses_doc
        '
        Me.rbtmeses_doc.AutoSize = True
        Me.rbtmeses_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtmeses_doc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtmeses_doc.Location = New System.Drawing.Point(3, 26)
        Me.rbtmeses_doc.Name = "rbtmeses_doc"
        Me.rbtmeses_doc.Size = New System.Drawing.Size(61, 17)
        Me.rbtmeses_doc.TabIndex = 2
        Me.rbtmeses_doc.Text = "Meses"
        Me.rbtmeses_doc.UseVisualStyleBackColor = True
        '
        'gPanel_Sexo
        '
        Me.gPanel_Sexo.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Sexo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Sexo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Sexo.Controls.Add(Me.rbtFemenino_doc)
        Me.gPanel_Sexo.Controls.Add(Me.rbtMasculino_doc)
        Me.gPanel_Sexo.Location = New System.Drawing.Point(15, 262)
        Me.gPanel_Sexo.Name = "gPanel_Sexo"
        Me.gPanel_Sexo.Size = New System.Drawing.Size(98, 71)
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
        Me.gPanel_Sexo.TabIndex = 20
        Me.gPanel_Sexo.Text = "Sexo"
        '
        'rbtFemenino_doc
        '
        Me.rbtFemenino_doc.AutoSize = True
        Me.rbtFemenino_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemenino_doc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtFemenino_doc.Location = New System.Drawing.Point(3, 26)
        Me.rbtFemenino_doc.Name = "rbtFemenino_doc"
        Me.rbtFemenino_doc.Size = New System.Drawing.Size(79, 17)
        Me.rbtFemenino_doc.TabIndex = 1
        Me.rbtFemenino_doc.Text = "Femenino"
        Me.rbtFemenino_doc.UseVisualStyleBackColor = True
        '
        'rbtMasculino_doc
        '
        Me.rbtMasculino_doc.AutoSize = True
        Me.rbtMasculino_doc.Checked = True
        Me.rbtMasculino_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMasculino_doc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtMasculino_doc.Location = New System.Drawing.Point(3, 3)
        Me.rbtMasculino_doc.Name = "rbtMasculino_doc"
        Me.rbtMasculino_doc.Size = New System.Drawing.Size(82, 17)
        Me.rbtMasculino_doc.TabIndex = 0
        Me.rbtMasculino_doc.TabStop = True
        Me.rbtMasculino_doc.Text = "Masculino"
        Me.rbtMasculino_doc.UseVisualStyleBackColor = True
        '
        'lblnumdoc_doc
        '
        Me.lblnumdoc_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnumdoc_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblnumdoc_doc.ForeColor = System.Drawing.Color.Navy
        Me.lblnumdoc_doc.Location = New System.Drawing.Point(330, 295)
        Me.lblnumdoc_doc.Name = "lblnumdoc_doc"
        Me.lblnumdoc_doc.Size = New System.Drawing.Size(31, 20)
        Me.lblnumdoc_doc.TabIndex = 22
        Me.lblnumdoc_doc.Text = "No."
        Me.lblnumdoc_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbtipodoc_doc
        '
        Me.cmbtipodoc_doc.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte", "C.EXTRANGERIA"})
        Me.cmbtipodoc_doc.DisplayMember = "Text"
        Me.cmbtipodoc_doc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipodoc_doc.FormattingEnabled = True
        Me.cmbtipodoc_doc.ItemHeight = 25
        Me.cmbtipodoc_doc.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cmbtipodoc_doc.Location = New System.Drawing.Point(367, 252)
        Me.cmbtipodoc_doc.Name = "cmbtipodoc_doc"
        Me.cmbtipodoc_doc.Size = New System.Drawing.Size(153, 31)
        Me.cmbtipodoc_doc.TabIndex = 19
        Me.cmbtipodoc_doc.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipodoc_doc.WatermarkText = "TIPO DOCUMENTO"
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
        'lbltipodoc_doc
        '
        Me.lbltipodoc_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbltipodoc_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbltipodoc_doc.ForeColor = System.Drawing.Color.Navy
        Me.lbltipodoc_doc.Location = New System.Drawing.Point(262, 252)
        Me.lbltipodoc_doc.Name = "lbltipodoc_doc"
        Me.lbltipodoc_doc.Size = New System.Drawing.Size(100, 29)
        Me.lbltipodoc_doc.TabIndex = 18
        Me.lbltipodoc_doc.Text = "Doc. de Identidad"
        Me.lbltipodoc_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbfecnac_doc
        '
        Me.cmbfecnac_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecnac_doc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbfecnac_doc.Location = New System.Drawing.Point(418, 190)
        Me.cmbfecnac_doc.Name = "cmbfecnac_doc"
        Me.cmbfecnac_doc.Size = New System.Drawing.Size(102, 21)
        Me.cmbfecnac_doc.TabIndex = 15
        Me.cmbfecnac_doc.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'cmbfecingreso_doc
        '
        Me.cmbfecingreso_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecingreso_doc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecingreso_doc.Location = New System.Drawing.Point(418, 156)
        Me.cmbfecingreso_doc.Name = "cmbfecingreso_doc"
        Me.cmbfecingreso_doc.Size = New System.Drawing.Size(102, 21)
        Me.cmbfecingreso_doc.TabIndex = 13
        Me.cmbfecingreso_doc.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblfecnac_doc
        '
        Me.lblfecnac_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfecnac_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblfecnac_doc.ForeColor = System.Drawing.Color.Navy
        Me.lblfecnac_doc.Location = New System.Drawing.Point(298, 190)
        Me.lblfecnac_doc.Name = "lblfecnac_doc"
        Me.lblfecnac_doc.Size = New System.Drawing.Size(113, 20)
        Me.lblfecnac_doc.TabIndex = 14
        Me.lblfecnac_doc.Text = "Fecha de Nacimiento"
        Me.lblfecnac_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtresidencia_doc
        '
        '
        '
        '
        Me.txtresidencia_doc.Border.Class = "TextBoxBorder"
        Me.txtresidencia_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtresidencia_doc.Location = New System.Drawing.Point(254, 95)
        Me.txtresidencia_doc.Name = "txtresidencia_doc"
        Me.txtresidencia_doc.Size = New System.Drawing.Size(266, 20)
        Me.txtresidencia_doc.TabIndex = 6
        Me.txtresidencia_doc.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtnombres_doc
        '
        '
        '
        '
        Me.txtnombres_doc.Border.Class = "TextBoxBorder"
        Me.txtnombres_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombres_doc.Location = New System.Drawing.Point(254, 69)
        Me.txtnombres_doc.Name = "txtnombres_doc"
        Me.txtnombres_doc.Size = New System.Drawing.Size(266, 20)
        Me.txtnombres_doc.TabIndex = 4
        Me.txtnombres_doc.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtapellidos_doc
        '
        '
        '
        '
        Me.txtapellidos_doc.Border.Class = "TextBoxBorder"
        Me.txtapellidos_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapellidos_doc.Location = New System.Drawing.Point(254, 43)
        Me.txtapellidos_doc.Name = "txtapellidos_doc"
        Me.txtapellidos_doc.Size = New System.Drawing.Size(266, 20)
        Me.txtapellidos_doc.TabIndex = 2
        Me.txtapellidos_doc.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lblfecingreso_doc
        '
        Me.lblfecingreso_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfecingreso_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblfecingreso_doc.ForeColor = System.Drawing.Color.Navy
        Me.lblfecingreso_doc.Location = New System.Drawing.Point(298, 156)
        Me.lblfecingreso_doc.Name = "lblfecingreso_doc"
        Me.lblfecingreso_doc.Size = New System.Drawing.Size(113, 20)
        Me.lblfecingreso_doc.TabIndex = 12
        Me.lblfecingreso_doc.Text = "Ingresó"
        Me.lblfecingreso_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblEspecialidad_doc
        '
        Me.lblEspecialidad_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEspecialidad_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblEspecialidad_doc.ForeColor = System.Drawing.Color.Navy
        Me.lblEspecialidad_doc.Location = New System.Drawing.Point(15, 221)
        Me.lblEspecialidad_doc.Name = "lblEspecialidad_doc"
        Me.lblEspecialidad_doc.Size = New System.Drawing.Size(72, 20)
        Me.lblEspecialidad_doc.TabIndex = 16
        Me.lblEspecialidad_doc.Text = "Especialidad"
        Me.lblEspecialidad_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblnombres_doc
        '
        Me.lblnombres_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnombres_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblnombres_doc.ForeColor = System.Drawing.Color.Navy
        Me.lblnombres_doc.Location = New System.Drawing.Point(176, 69)
        Me.lblnombres_doc.Name = "lblnombres_doc"
        Me.lblnombres_doc.Size = New System.Drawing.Size(72, 20)
        Me.lblnombres_doc.TabIndex = 3
        Me.lblnombres_doc.Text = "Nombres"
        Me.lblnombres_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblresidencia_doc
        '
        Me.lblresidencia_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblresidencia_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblresidencia_doc.ForeColor = System.Drawing.Color.Navy
        Me.lblresidencia_doc.Location = New System.Drawing.Point(176, 95)
        Me.lblresidencia_doc.Name = "lblresidencia_doc"
        Me.lblresidencia_doc.Size = New System.Drawing.Size(72, 20)
        Me.lblresidencia_doc.TabIndex = 5
        Me.lblresidencia_doc.Text = "Residencia"
        Me.lblresidencia_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblapellidos_doc
        '
        Me.lblapellidos_doc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblapellidos_doc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblapellidos_doc.ForeColor = System.Drawing.Color.Navy
        Me.lblapellidos_doc.Location = New System.Drawing.Point(176, 43)
        Me.lblapellidos_doc.Name = "lblapellidos_doc"
        Me.lblapellidos_doc.Size = New System.Drawing.Size(72, 20)
        Me.lblapellidos_doc.TabIndex = 1
        Me.lblapellidos_doc.Text = "Apellidos"
        Me.lblapellidos_doc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tabDPersonales_doc
        '
        Me.tabDPersonales_doc.AttachedControl = Me.TabControlPanel2
        Me.tabDPersonales_doc.Name = "tabDPersonales_doc"
        Me.tabDPersonales_doc.Text = "Datos Personales"
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
        Me.TabControlPanel3.Size = New System.Drawing.Size(532, 406)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 1
        Me.TabControlPanel3.TabItem = Me.tabNotas_doc
        '
        'RichTxtNotas_doc
        '
        Me.RichTxtNotas_doc.Location = New System.Drawing.Point(13, 16)
        Me.RichTxtNotas_doc.Name = "RichTxtNotas_doc"
        Me.RichTxtNotas_doc.Size = New System.Drawing.Size(445, 193)
        Me.RichTxtNotas_doc.TabIndex = 0
        Me.RichTxtNotas_doc.Text = ""
        '
        'tabNotas_doc
        '
        Me.tabNotas_doc.AttachedControl = Me.TabControlPanel3
        Me.tabNotas_doc.Name = "tabNotas_doc"
        Me.tabNotas_doc.Text = "Notas"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.gpContactos)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 406)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 2
        Me.TabControlPanel1.TabItem = Me.tabContactos_doc
        '
        'gpContactos
        '
        Me.gpContactos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpContactos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpContactos.Controls.Add(Me.btnNoEmail)
        Me.gpContactos.Controls.Add(Me.txtemail_doc)
        Me.gpContactos.Controls.Add(Me.LabelX17)
        Me.gpContactos.Controls.Add(Me.txtTelOficina_doc)
        Me.gpContactos.Controls.Add(Me.txtweb_doc)
        Me.gpContactos.Controls.Add(Me.LabelX26)
        Me.gpContactos.Controls.Add(Me.LabelX21)
        Me.gpContactos.Controls.Add(Me.txtCelular_doc)
        Me.gpContactos.Controls.Add(Me.txtFax_doc)
        Me.gpContactos.Controls.Add(Me.LabelX18)
        Me.gpContactos.Controls.Add(Me.LabelX16)
        Me.gpContactos.Controls.Add(Me.txtTelCasa_doc)
        Me.gpContactos.Controls.Add(Me.LabelX15)
        Me.gpContactos.Location = New System.Drawing.Point(19, 28)
        Me.gpContactos.Name = "gpContactos"
        Me.gpContactos.Size = New System.Drawing.Size(501, 130)
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
        Me.btnNoEmail.Location = New System.Drawing.Point(458, 64)
        Me.btnNoEmail.Name = "btnNoEmail"
        Me.btnNoEmail.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail.TabIndex = 10
        '
        'txtemail_doc
        '
        Me.txtemail_doc.Location = New System.Drawing.Point(106, 64)
        Me.txtemail_doc.Name = "txtemail_doc"
        Me.txtemail_doc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemail_doc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemail_doc.Properties.Mask.BeepOnError = True
        Me.txtemail_doc.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemail_doc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemail_doc.Properties.Mask.ShowPlaceHolders = False
        Me.txtemail_doc.Size = New System.Drawing.Size(346, 20)
        Me.txtemail_doc.TabIndex = 9
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX17.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX17.ForeColor = System.Drawing.Color.Navy
        Me.LabelX17.Location = New System.Drawing.Point(244, 12)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(95, 20)
        Me.LabelX17.TabIndex = 2
        Me.LabelX17.Text = "Telefono Oficina"
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelOficina_doc
        '
        '
        '
        '
        Me.txtTelOficina_doc.Border.Class = "TextBoxBorder"
        Me.txtTelOficina_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelOficina_doc.Location = New System.Drawing.Point(345, 12)
        Me.txtTelOficina_doc.Name = "txtTelOficina_doc"
        Me.txtTelOficina_doc.Size = New System.Drawing.Size(134, 20)
        Me.txtTelOficina_doc.TabIndex = 3
        Me.txtTelOficina_doc.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtweb_doc
        '
        '
        '
        '
        Me.txtweb_doc.Border.Class = "TextBoxBorder"
        Me.txtweb_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtweb_doc.Location = New System.Drawing.Point(106, 90)
        Me.txtweb_doc.Name = "txtweb_doc"
        Me.txtweb_doc.Size = New System.Drawing.Size(373, 20)
        Me.txtweb_doc.TabIndex = 12
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX26.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX26.ForeColor = System.Drawing.Color.Navy
        Me.LabelX26.Location = New System.Drawing.Point(5, 90)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(95, 21)
        Me.LabelX26.TabIndex = 11
        Me.LabelX26.Text = "Pagina Web"
        Me.LabelX26.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX21.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX21.ForeColor = System.Drawing.Color.Navy
        Me.LabelX21.Location = New System.Drawing.Point(244, 38)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(95, 20)
        Me.LabelX21.TabIndex = 6
        Me.LabelX21.Text = "Celular"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelular_doc
        '
        '
        '
        '
        Me.txtCelular_doc.Border.Class = "TextBoxBorder"
        Me.txtCelular_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular_doc.Location = New System.Drawing.Point(345, 38)
        Me.txtCelular_doc.Name = "txtCelular_doc"
        Me.txtCelular_doc.Size = New System.Drawing.Size(134, 20)
        Me.txtCelular_doc.TabIndex = 7
        Me.txtCelular_doc.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtFax_doc
        '
        '
        '
        '
        Me.txtFax_doc.Border.Class = "TextBoxBorder"
        Me.txtFax_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax_doc.Location = New System.Drawing.Point(106, 38)
        Me.txtFax_doc.Name = "txtFax_doc"
        Me.txtFax_doc.Size = New System.Drawing.Size(132, 20)
        Me.txtFax_doc.TabIndex = 5
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
        'txtTelCasa_doc
        '
        '
        '
        '
        Me.txtTelCasa_doc.Border.Class = "TextBoxBorder"
        Me.txtTelCasa_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelCasa_doc.Location = New System.Drawing.Point(106, 12)
        Me.txtTelCasa_doc.Name = "txtTelCasa_doc"
        Me.txtTelCasa_doc.Size = New System.Drawing.Size(132, 20)
        Me.txtTelCasa_doc.TabIndex = 1
        Me.txtTelCasa_doc.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX15.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX15.ForeColor = System.Drawing.Color.Navy
        Me.LabelX15.Location = New System.Drawing.Point(5, 64)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(95, 20)
        Me.LabelX15.TabIndex = 8
        Me.LabelX15.Text = "E-Mail"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tabContactos_doc
        '
        Me.tabContactos_doc.AttachedControl = Me.TabControlPanel1
        Me.tabContactos_doc.Name = "tabContactos_doc"
        Me.tabContactos_doc.Text = "Contactos"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(306, 437)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(91, 39)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(112, 437)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(91, 39)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(429, 437)
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
        Me.btnNuevo.Location = New System.Drawing.Point(209, 437)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(91, 39)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(15, 437)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(91, 39)
        Me.btnAdicionar.TabIndex = 0
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'ErrorProviderdoc
        '
        Me.ErrorProviderdoc.ContainerControl = Me
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
        'lblRegistroBiometrico
        '
        Me.lblRegistroBiometrico.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRegistroBiometrico.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroBiometrico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRegistroBiometrico.Location = New System.Drawing.Point(24, 270)
        Me.lblRegistroBiometrico.Name = "lblRegistroBiometrico"
        Me.lblRegistroBiometrico.Size = New System.Drawing.Size(481, 23)
        Me.lblRegistroBiometrico.TabIndex = 1
        Me.lblRegistroBiometrico.Text = "REGISTRO BIOMETRICO"
        Me.lblRegistroBiometrico.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpRegistroBiometrico
        '
        Me.gpRegistroBiometrico.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpRegistroBiometrico.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpRegistroBiometrico.Controls.Add(Me.btnRegistroBiometrico)
        Me.gpRegistroBiometrico.Location = New System.Drawing.Point(23, 305)
        Me.gpRegistroBiometrico.Name = "gpRegistroBiometrico"
        Me.gpRegistroBiometrico.Size = New System.Drawing.Size(481, 79)
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
        Me.gpRegistroBiometrico.TabIndex = 2
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
        'gpNotas
        '
        Me.gpNotas.BackColor = System.Drawing.Color.Transparent
        Me.gpNotas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpNotas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpNotas.Controls.Add(Me.RichTxtNotas_doc)
        Me.gpNotas.Location = New System.Drawing.Point(24, 17)
        Me.gpNotas.Name = "gpNotas"
        Me.gpNotas.Size = New System.Drawing.Size(481, 247)
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
        Me.gpNotas.TabIndex = 0
        Me.gpNotas.Text = "Notas Doctor"
        '
        'frmDoctores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.TabControl_Doc)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmDoctores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Doctores"
        CType(Me.TabControl_Doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_Doc.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.txtnumdoc_doc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFoto_doc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gPanel_Edad.ResumeLayout(False)
        Me.gPanel_Edad.PerformLayout()
        Me.gPanel_Sexo.ResumeLayout(False)
        Me.gPanel_Sexo.PerformLayout()
        Me.TabControlPanel3.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.gpContactos.ResumeLayout(False)
        CType(Me.txtemail_doc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderdoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpRegistroBiometrico.ResumeLayout(False)
        Me.gpNotas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl_Doc As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents RichTxtNotas_doc As System.Windows.Forms.RichTextBox
    Friend WithEvents tabNotas_doc As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents gpContactos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtweb_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelular_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFax_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelCasa_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tabContactos_doc As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIddoctor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblIddoctor As DevComponents.DotNetBar.LabelX
    Friend WithEvents gPanel_Edad As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblNumaños As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbtAños_doc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtmeses_doc As System.Windows.Forms.RadioButton
    Friend WithEvents gPanel_Sexo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtFemenino_doc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMasculino_doc As System.Windows.Forms.RadioButton
    Friend WithEvents lblnumdoc_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbtipodoc_doc As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lbltipodoc_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecnac_doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbfecingreso_doc As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfecnac_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtresidencia_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnombres_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtapellidos_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblfecingreso_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblEspecialidad_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblnombres_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblresidencia_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblapellidos_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents tabDPersonales_doc As DevComponents.DotNetBar.TabItem
    Friend WithEvents txtoficina_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbloficina_doc As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelOficina_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileDialogDoc As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFotoA As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents pbFoto_doc As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProviderdoc As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtemail_doc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnNoEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBorrarFoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtnumdoc_doc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents cmbEspecialidades As System.Windows.Forms.ComboBox
    Friend WithEvents gpNotas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblRegistroBiometrico As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpRegistroBiometrico As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnRegistroBiometrico As DevComponents.DotNetBar.ButtonX
End Class
