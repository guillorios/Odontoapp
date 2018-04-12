<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacientes))
        Me.TabControl_pac = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.cmbzona_pac = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem9 = New DevComponents.Editors.ComboItem
        Me.ComboItem10 = New DevComponents.Editors.ComboItem
        Me.lblzona_pac = New DevComponents.DotNetBar.LabelX
        Me.txtrh_Pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblrh_Pac = New DevComponents.DotNetBar.LabelX
        Me.txtdep_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lbldep_pac = New DevComponents.DotNetBar.LabelX
        Me.txtmunicipio_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblmunicipio_pac = New DevComponents.DotNetBar.LabelX
        Me.txtlugarnac_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lbllugarnac_pac = New DevComponents.DotNetBar.LabelX
        Me.cmbtipodoc_pac = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.cmbestadocivil_pac = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem5 = New DevComponents.Editors.ComboItem
        Me.ComboItem6 = New DevComponents.Editors.ComboItem
        Me.ComboItem7 = New DevComponents.Editors.ComboItem
        Me.ComboItem8 = New DevComponents.Editors.ComboItem
        Me.ComboItem11 = New DevComponents.Editors.ComboItem
        Me.lblestadocivil_pac = New DevComponents.DotNetBar.LabelX
        Me.gpHC_NDoc = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbNoHC_NDoc = New System.Windows.Forms.RadioButton
        Me.rbSiHC_NDoc = New System.Windows.Forms.RadioButton
        Me.txtnumdoc_pac = New DevExpress.XtraEditors.TextEdit
        Me.txtnhclinica = New DevExpress.XtraEditors.TextEdit
        Me.txtdedoc_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lbldedoc_pac = New DevComponents.DotNetBar.LabelX
        Me.panelEstado = New DevComponents.DotNetBar.ExpandablePanel
        Me.rbtEstado_Retirado = New System.Windows.Forms.RadioButton
        Me.rbtEstado_Retencion = New System.Windows.Forms.RadioButton
        Me.rbtEstado_Bloqueado = New System.Windows.Forms.RadioButton
        Me.rbtEstado_Entratamiento = New System.Windows.Forms.RadioButton
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.cmbEntidad = New System.Windows.Forms.ComboBox
        Me.txtIdpaciente = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblnhclinica = New DevComponents.DotNetBar.LabelX
        Me.lblIdpaciente = New DevComponents.DotNetBar.LabelX
        Me.lblEntidad = New DevComponents.DotNetBar.LabelX
        Me.gPanel_Edad = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblNumaños = New DevComponents.DotNetBar.LabelX
        Me.rbtAños_pac = New System.Windows.Forms.RadioButton
        Me.rbtmeses_pac = New System.Windows.Forms.RadioButton
        Me.gPanel_Sexo = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtFemenino_pac = New System.Windows.Forms.RadioButton
        Me.rbtMasculino_pac = New System.Windows.Forms.RadioButton
        Me.lblnumdoc_pac = New DevComponents.DotNetBar.LabelX
        Me.txtocupacion_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lbltipodoc_pac = New DevComponents.DotNetBar.LabelX
        Me.cmbfecnac_pac = New System.Windows.Forms.DateTimePicker
        Me.cmbfecingreso_pac = New System.Windows.Forms.DateTimePicker
        Me.lblfecnac_pac = New DevComponents.DotNetBar.LabelX
        Me.txtreferido_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtoficina_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtresidencia_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtnombres_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtapellidos_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblfecingreso_pac = New DevComponents.DotNetBar.LabelX
        Me.lbloficina_pac = New DevComponents.DotNetBar.LabelX
        Me.lblocupacion_pac = New DevComponents.DotNetBar.LabelX
        Me.lblresidencia_pac = New DevComponents.DotNetBar.LabelX
        Me.lblnombres_pac = New DevComponents.DotNetBar.LabelX
        Me.lblreferido_pac = New DevComponents.DotNetBar.LabelX
        Me.lblapellidos_pac = New DevComponents.DotNetBar.LabelX
        Me.btnEstadoCuenta = New DevComponents.DotNetBar.ButtonX
        Me.btnFotoA = New DevComponents.DotNetBar.ButtonX
        Me.btnFoto = New DevComponents.DotNetBar.ButtonX
        Me.btnBorrarFoto = New DevComponents.DotNetBar.ButtonX
        Me.btnPacOdontograma = New DevComponents.DotNetBar.ButtonX
        Me.btnEstudiosPac = New DevComponents.DotNetBar.ButtonX
        Me.pbFoto_pac = New System.Windows.Forms.PictureBox
        Me.tabDPersonales_pac = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpConyuge = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX
        Me.txtOcuConyuge_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX
        Me.txtCelConyuge_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX
        Me.txtTelConyuge_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtConyuge_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX
        Me.gpPadres = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX33 = New DevComponents.DotNetBar.LabelX
        Me.txtOcuAcudiente_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX34 = New DevComponents.DotNetBar.LabelX
        Me.txtCelAcudiente_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX35 = New DevComponents.DotNetBar.LabelX
        Me.txtTelAcudiente_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtAcudiente_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX36 = New DevComponents.DotNetBar.LabelX
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX
        Me.txtOcuMadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX
        Me.txtOcuPadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX
        Me.txtCelMadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX
        Me.txtCelPadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX
        Me.txtTelMadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtMadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.txtTelPadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtPadre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.gpContactos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbOperadorCel = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.btnNoEmail = New DevComponents.DotNetBar.ButtonX
        Me.txtemail_pac = New DevExpress.XtraEditors.TextEdit
        Me.txtweb_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.txtCelular_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtFax_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.txtTelOficina_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.txtTelCasa_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.tabContactos_pac = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpNotas = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.RichTxtNotas_pac = New System.Windows.Forms.RichTextBox
        Me.lblRegistroBiometrico = New DevComponents.DotNetBar.LabelX
        Me.gpRegistroBiometrico = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnRegistroBiometrico = New DevComponents.DotNetBar.ButtonX
        Me.tabNotas_pac = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TimerPac = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnNoEmail_Padre = New DevComponents.DotNetBar.ButtonX
        Me.txtemailPadre_pac = New DevExpress.XtraEditors.TextEdit
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.btnNoEmail_Madre = New DevComponents.DotNetBar.ButtonX
        Me.txtemailMadre_pac = New DevExpress.XtraEditors.TextEdit
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.btnNoEmail_Conyuge = New DevComponents.DotNetBar.ButtonX
        Me.txtemailConyuge_pac = New DevExpress.XtraEditors.TextEdit
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.btnNoEmail_Acudiente = New DevComponents.DotNetBar.ButtonX
        Me.txtemailAcudiente_pac = New DevExpress.XtraEditors.TextEdit
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        CType(Me.TabControl_pac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_pac.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.gpHC_NDoc.SuspendLayout()
        CType(Me.txtnumdoc_pac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnhclinica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEstado.SuspendLayout()
        Me.gPanel_Edad.SuspendLayout()
        Me.gPanel_Sexo.SuspendLayout()
        CType(Me.pbFoto_pac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel1.SuspendLayout()
        Me.gpConyuge.SuspendLayout()
        Me.gpPadres.SuspendLayout()
        Me.gpContactos.SuspendLayout()
        CType(Me.txtemail_pac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel3.SuspendLayout()
        Me.gpNotas.SuspendLayout()
        Me.gpRegistroBiometrico.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.txtemailPadre_pac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemailMadre_pac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemailConyuge_pac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtemailAcudiente_pac.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl_pac
        '
        Me.TabControl_pac.CanReorderTabs = True
        Me.TabControl_pac.Controls.Add(Me.TabControlPanel1)
        Me.TabControl_pac.Controls.Add(Me.TabControlPanel3)
        Me.TabControl_pac.Controls.Add(Me.TabControlPanel2)
        Me.TabControl_pac.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl_pac.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_pac.Name = "TabControl_pac"
        Me.TabControl_pac.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl_pac.SelectedTabIndex = 0
        Me.TabControl_pac.Size = New System.Drawing.Size(532, 440)
        Me.TabControl_pac.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl_pac.TabIndex = 0
        Me.TabControl_pac.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl_pac.Tabs.Add(Me.tabDPersonales_pac)
        Me.TabControl_pac.Tabs.Add(Me.tabContactos_pac)
        Me.TabControl_pac.Tabs.Add(Me.tabNotas_pac)
        Me.TabControl_pac.Text = "Tab"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.cmbzona_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblzona_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtrh_Pac)
        Me.TabControlPanel2.Controls.Add(Me.lblrh_Pac)
        Me.TabControlPanel2.Controls.Add(Me.txtdep_pac)
        Me.TabControlPanel2.Controls.Add(Me.lbldep_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtmunicipio_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblmunicipio_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtlugarnac_pac)
        Me.TabControlPanel2.Controls.Add(Me.lbllugarnac_pac)
        Me.TabControlPanel2.Controls.Add(Me.cmbtipodoc_pac)
        Me.TabControlPanel2.Controls.Add(Me.cmbestadocivil_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblestadocivil_pac)
        Me.TabControlPanel2.Controls.Add(Me.gpHC_NDoc)
        Me.TabControlPanel2.Controls.Add(Me.txtnumdoc_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtnhclinica)
        Me.TabControlPanel2.Controls.Add(Me.txtdedoc_pac)
        Me.TabControlPanel2.Controls.Add(Me.lbldedoc_pac)
        Me.TabControlPanel2.Controls.Add(Me.panelEstado)
        Me.TabControlPanel2.Controls.Add(Me.lblTituloVentana)
        Me.TabControlPanel2.Controls.Add(Me.cmbEntidad)
        Me.TabControlPanel2.Controls.Add(Me.txtIdpaciente)
        Me.TabControlPanel2.Controls.Add(Me.lblnhclinica)
        Me.TabControlPanel2.Controls.Add(Me.lblIdpaciente)
        Me.TabControlPanel2.Controls.Add(Me.lblEntidad)
        Me.TabControlPanel2.Controls.Add(Me.gPanel_Edad)
        Me.TabControlPanel2.Controls.Add(Me.gPanel_Sexo)
        Me.TabControlPanel2.Controls.Add(Me.lblnumdoc_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtocupacion_pac)
        Me.TabControlPanel2.Controls.Add(Me.lbltipodoc_pac)
        Me.TabControlPanel2.Controls.Add(Me.cmbfecnac_pac)
        Me.TabControlPanel2.Controls.Add(Me.cmbfecingreso_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblfecnac_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtreferido_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtoficina_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtresidencia_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtnombres_pac)
        Me.TabControlPanel2.Controls.Add(Me.txtapellidos_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblfecingreso_pac)
        Me.TabControlPanel2.Controls.Add(Me.lbloficina_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblocupacion_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblresidencia_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblnombres_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblreferido_pac)
        Me.TabControlPanel2.Controls.Add(Me.lblapellidos_pac)
        Me.TabControlPanel2.Controls.Add(Me.btnEstadoCuenta)
        Me.TabControlPanel2.Controls.Add(Me.btnFotoA)
        Me.TabControlPanel2.Controls.Add(Me.btnFoto)
        Me.TabControlPanel2.Controls.Add(Me.btnBorrarFoto)
        Me.TabControlPanel2.Controls.Add(Me.btnPacOdontograma)
        Me.TabControlPanel2.Controls.Add(Me.btnEstudiosPac)
        Me.TabControlPanel2.Controls.Add(Me.pbFoto_pac)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 418)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 0
        Me.TabControlPanel2.TabItem = Me.tabDPersonales_pac
        '
        'cmbzona_pac
        '
        Me.cmbzona_pac.DisplayMember = "TEXT"
        Me.cmbzona_pac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbzona_pac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbzona_pac.ItemHeight = 15
        Me.cmbzona_pac.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10})
        Me.cmbzona_pac.Location = New System.Drawing.Point(429, 152)
        Me.cmbzona_pac.Name = "cmbzona_pac"
        Me.cmbzona_pac.Size = New System.Drawing.Size(82, 21)
        Me.cmbzona_pac.TabIndex = 81
        Me.cmbzona_pac.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "URBANA"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "RURAL"
        '
        'lblzona_pac
        '
        Me.lblzona_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblzona_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblzona_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblzona_pac.Location = New System.Drawing.Point(391, 152)
        Me.lblzona_pac.Name = "lblzona_pac"
        Me.lblzona_pac.Size = New System.Drawing.Size(34, 20)
        Me.lblzona_pac.TabIndex = 80
        Me.lblzona_pac.Text = "Zona"
        Me.lblzona_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtrh_Pac
        '
        '
        '
        '
        Me.txtrh_Pac.Border.Class = "TextBoxBorder"
        Me.txtrh_Pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrh_Pac.Location = New System.Drawing.Point(195, 287)
        Me.txtrh_Pac.Name = "txtrh_Pac"
        Me.txtrh_Pac.Size = New System.Drawing.Size(33, 20)
        Me.txtrh_Pac.TabIndex = 79
        '
        'lblrh_Pac
        '
        Me.lblrh_Pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblrh_Pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblrh_Pac.ForeColor = System.Drawing.Color.Navy
        Me.lblrh_Pac.Location = New System.Drawing.Point(94, 287)
        Me.lblrh_Pac.Name = "lblrh_Pac"
        Me.lblrh_Pac.Size = New System.Drawing.Size(95, 20)
        Me.lblrh_Pac.TabIndex = 78
        Me.lblrh_Pac.Text = "Grupo Sanguineo"
        Me.lblrh_Pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtdep_pac
        '
        '
        '
        '
        Me.txtdep_pac.Border.Class = "TextBoxBorder"
        Me.txtdep_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdep_pac.Location = New System.Drawing.Point(428, 175)
        Me.txtdep_pac.Name = "txtdep_pac"
        Me.txtdep_pac.Size = New System.Drawing.Size(83, 20)
        Me.txtdep_pac.TabIndex = 77
        '
        'lbldep_pac
        '
        Me.lbldep_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbldep_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbldep_pac.ForeColor = System.Drawing.Color.Navy
        Me.lbldep_pac.Location = New System.Drawing.Point(350, 175)
        Me.lbldep_pac.Name = "lbldep_pac"
        Me.lbldep_pac.Size = New System.Drawing.Size(76, 20)
        Me.lbldep_pac.TabIndex = 76
        Me.lbldep_pac.Text = "Departamento"
        Me.lbldep_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtmunicipio_pac
        '
        '
        '
        '
        Me.txtmunicipio_pac.Border.Class = "TextBoxBorder"
        Me.txtmunicipio_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmunicipio_pac.Location = New System.Drawing.Point(253, 175)
        Me.txtmunicipio_pac.Name = "txtmunicipio_pac"
        Me.txtmunicipio_pac.Size = New System.Drawing.Size(94, 20)
        Me.txtmunicipio_pac.TabIndex = 75
        '
        'lblmunicipio_pac
        '
        Me.lblmunicipio_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblmunicipio_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblmunicipio_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblmunicipio_pac.Location = New System.Drawing.Point(175, 175)
        Me.lblmunicipio_pac.Name = "lblmunicipio_pac"
        Me.lblmunicipio_pac.Size = New System.Drawing.Size(72, 20)
        Me.lblmunicipio_pac.TabIndex = 74
        Me.lblmunicipio_pac.Text = "Municipio"
        Me.lblmunicipio_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtlugarnac_pac
        '
        '
        '
        '
        Me.txtlugarnac_pac.Border.Class = "TextBoxBorder"
        Me.txtlugarnac_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlugarnac_pac.Location = New System.Drawing.Point(56, 247)
        Me.txtlugarnac_pac.Name = "txtlugarnac_pac"
        Me.txtlugarnac_pac.Size = New System.Drawing.Size(173, 20)
        Me.txtlugarnac_pac.TabIndex = 73
        Me.txtlugarnac_pac.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lbllugarnac_pac
        '
        Me.lbllugarnac_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbllugarnac_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbllugarnac_pac.ForeColor = System.Drawing.Color.Navy
        Me.lbllugarnac_pac.Location = New System.Drawing.Point(12, 246)
        Me.lbllugarnac_pac.Name = "lbllugarnac_pac"
        Me.lbllugarnac_pac.Size = New System.Drawing.Size(42, 22)
        Me.lbllugarnac_pac.TabIndex = 72
        Me.lbllugarnac_pac.Text = "Lugar"
        Me.lbllugarnac_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbtipodoc_pac
        '
        Me.cmbtipodoc_pac.DisplayMember = "Text"
        Me.cmbtipodoc_pac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtipodoc_pac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipodoc_pac.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cmbtipodoc_pac.Location = New System.Drawing.Point(336, 222)
        Me.cmbtipodoc_pac.Name = "cmbtipodoc_pac"
        Me.cmbtipodoc_pac.Size = New System.Drawing.Size(174, 21)
        Me.cmbtipodoc_pac.TabIndex = 21
        Me.cmbtipodoc_pac.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipodoc_pac.WatermarkText = "CAMPO OBLIGATORIO"
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
        'cmbestadocivil_pac
        '
        Me.cmbestadocivil_pac.DisplayMember = "Text"
        Me.cmbestadocivil_pac.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbestadocivil_pac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestadocivil_pac.ItemHeight = 15
        Me.cmbestadocivil_pac.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8, Me.ComboItem11})
        Me.cmbestadocivil_pac.Location = New System.Drawing.Point(336, 198)
        Me.cmbestadocivil_pac.Name = "cmbestadocivil_pac"
        Me.cmbestadocivil_pac.Size = New System.Drawing.Size(174, 21)
        Me.cmbestadocivil_pac.TabIndex = 16
        Me.cmbestadocivil_pac.WatermarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestadocivil_pac.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "SOLTERO(A)"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "CASADO(A)"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "VIUDO(A)"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "UNION LIBRE"
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "SEPARADO(A)"
        '
        'lblestadocivil_pac
        '
        Me.lblestadocivil_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblestadocivil_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblestadocivil_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblestadocivil_pac.Location = New System.Drawing.Point(232, 200)
        Me.lblestadocivil_pac.Name = "lblestadocivil_pac"
        Me.lblestadocivil_pac.Size = New System.Drawing.Size(94, 20)
        Me.lblestadocivil_pac.TabIndex = 17
        Me.lblestadocivil_pac.Text = "Estado Civil"
        Me.lblestadocivil_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpHC_NDoc
        '
        Me.gpHC_NDoc.BackColor = System.Drawing.Color.Transparent
        Me.gpHC_NDoc.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpHC_NDoc.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpHC_NDoc.Controls.Add(Me.rbNoHC_NDoc)
        Me.gpHC_NDoc.Controls.Add(Me.rbSiHC_NDoc)
        Me.gpHC_NDoc.Location = New System.Drawing.Point(402, 246)
        Me.gpHC_NDoc.Name = "gpHC_NDoc"
        Me.gpHC_NDoc.Size = New System.Drawing.Size(117, 48)
        '
        '
        '
        Me.gpHC_NDoc.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpHC_NDoc.Style.BackColorGradientAngle = 90
        Me.gpHC_NDoc.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpHC_NDoc.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHC_NDoc.Style.BorderBottomWidth = 1
        Me.gpHC_NDoc.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpHC_NDoc.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHC_NDoc.Style.BorderLeftWidth = 1
        Me.gpHC_NDoc.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHC_NDoc.Style.BorderRightWidth = 1
        Me.gpHC_NDoc.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHC_NDoc.Style.BorderTopWidth = 1
        Me.gpHC_NDoc.Style.CornerDiameter = 4
        Me.gpHC_NDoc.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpHC_NDoc.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpHC_NDoc.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpHC_NDoc.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpHC_NDoc.TabIndex = 26
        Me.gpHC_NDoc.Text = "H. Clinica = No. Doc"
        '
        'rbNoHC_NDoc
        '
        Me.rbNoHC_NDoc.AutoSize = True
        Me.rbNoHC_NDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNoHC_NDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbNoHC_NDoc.Location = New System.Drawing.Point(57, 5)
        Me.rbNoHC_NDoc.Name = "rbNoHC_NDoc"
        Me.rbNoHC_NDoc.Size = New System.Drawing.Size(41, 17)
        Me.rbNoHC_NDoc.TabIndex = 0
        Me.rbNoHC_NDoc.Text = "No"
        Me.rbNoHC_NDoc.UseVisualStyleBackColor = True
        '
        'rbSiHC_NDoc
        '
        Me.rbSiHC_NDoc.AutoSize = True
        Me.rbSiHC_NDoc.Checked = True
        Me.rbSiHC_NDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSiHC_NDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbSiHC_NDoc.Location = New System.Drawing.Point(23, 6)
        Me.rbSiHC_NDoc.Name = "rbSiHC_NDoc"
        Me.rbSiHC_NDoc.Size = New System.Drawing.Size(36, 17)
        Me.rbSiHC_NDoc.TabIndex = 1
        Me.rbSiHC_NDoc.TabStop = True
        Me.rbSiHC_NDoc.Text = "Si"
        Me.rbSiHC_NDoc.UseVisualStyleBackColor = True
        '
        'txtnumdoc_pac
        '
        Me.txtnumdoc_pac.EditValue = ""
        Me.txtnumdoc_pac.Location = New System.Drawing.Point(264, 245)
        Me.txtnumdoc_pac.Name = "txtnumdoc_pac"
        Me.txtnumdoc_pac.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtnumdoc_pac.Properties.Appearance.Options.UseFont = True
        Me.txtnumdoc_pac.Properties.Appearance.Options.UseTextOptions = True
        Me.txtnumdoc_pac.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtnumdoc_pac.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtnumdoc_pac.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtnumdoc_pac.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None
        Me.txtnumdoc_pac.Properties.Mask.BeepOnError = True
        Me.txtnumdoc_pac.Properties.Mask.ShowPlaceHolders = False
        Me.txtnumdoc_pac.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtnumdoc_pac.Size = New System.Drawing.Size(133, 21)
        Me.txtnumdoc_pac.TabIndex = 25
        '
        'txtnhclinica
        '
        Me.txtnhclinica.EditValue = "0"
        Me.txtnhclinica.Location = New System.Drawing.Point(233, 393)
        Me.txtnhclinica.Name = "txtnhclinica"
        Me.txtnhclinica.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txtnhclinica.Properties.Appearance.Options.UseFont = True
        Me.txtnhclinica.Properties.Appearance.Options.UseTextOptions = True
        Me.txtnhclinica.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtnhclinica.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtnhclinica.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtnhclinica.Properties.Mask.BeepOnError = True
        Me.txtnhclinica.Properties.Mask.EditMask = "d"
        Me.txtnhclinica.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtnhclinica.Properties.Mask.ShowPlaceHolders = False
        Me.txtnhclinica.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtnhclinica.Size = New System.Drawing.Size(130, 21)
        Me.txtnhclinica.TabIndex = 39
        '
        'txtdedoc_pac
        '
        '
        '
        '
        Me.txtdedoc_pac.Border.Class = "TextBoxBorder"
        Me.txtdedoc_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdedoc_pac.Location = New System.Drawing.Point(264, 270)
        Me.txtdedoc_pac.Name = "txtdedoc_pac"
        Me.txtdedoc_pac.Size = New System.Drawing.Size(133, 20)
        Me.txtdedoc_pac.TabIndex = 29
        Me.txtdedoc_pac.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lbldedoc_pac
        '
        Me.lbldedoc_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbldedoc_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbldedoc_pac.ForeColor = System.Drawing.Color.Navy
        Me.lbldedoc_pac.Location = New System.Drawing.Point(232, 270)
        Me.lbldedoc_pac.Name = "lbldedoc_pac"
        Me.lbldedoc_pac.Size = New System.Drawing.Size(31, 20)
        Me.lbldedoc_pac.TabIndex = 28
        Me.lbldedoc_pac.Text = "De"
        Me.lbldedoc_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'panelEstado
        '
        Me.panelEstado.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEstado.ColorScheme.ItemDesignTimeBorder = System.Drawing.Color.Black
        Me.panelEstado.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelEstado.Controls.Add(Me.rbtEstado_Retirado)
        Me.panelEstado.Controls.Add(Me.rbtEstado_Retencion)
        Me.panelEstado.Controls.Add(Me.rbtEstado_Bloqueado)
        Me.panelEstado.Controls.Add(Me.rbtEstado_Entratamiento)
        Me.panelEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEstado.Location = New System.Drawing.Point(399, 299)
        Me.panelEstado.Name = "panelEstado"
        Me.panelEstado.Size = New System.Drawing.Size(121, 115)
        Me.panelEstado.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEstado.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEstado.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEstado.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEstado.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEstado.Style.ForeColor.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panelEstado.Style.GradientAngle = 90
        Me.panelEstado.TabIndex = 40
        Me.panelEstado.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEstado.TitleStyle.BackColor1.Color = System.Drawing.Color.Yellow
        Me.panelEstado.TitleStyle.BackColor2.Color = System.Drawing.Color.White
        Me.panelEstado.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEstado.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEstado.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEstado.TitleStyle.GradientAngle = 90
        Me.panelEstado.TitleText = "ESTADO"
        '
        'rbtEstado_Retirado
        '
        Me.rbtEstado_Retirado.AutoSize = True
        Me.rbtEstado_Retirado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtEstado_Retirado.Location = New System.Drawing.Point(6, 93)
        Me.rbtEstado_Retirado.Name = "rbtEstado_Retirado"
        Me.rbtEstado_Retirado.Size = New System.Drawing.Size(73, 17)
        Me.rbtEstado_Retirado.TabIndex = 3
        Me.rbtEstado_Retirado.Text = "Retirado"
        Me.rbtEstado_Retirado.UseVisualStyleBackColor = True
        '
        'rbtEstado_Retencion
        '
        Me.rbtEstado_Retencion.AutoSize = True
        Me.rbtEstado_Retencion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtEstado_Retencion.Location = New System.Drawing.Point(6, 72)
        Me.rbtEstado_Retencion.Name = "rbtEstado_Retencion"
        Me.rbtEstado_Retencion.Size = New System.Drawing.Size(83, 17)
        Me.rbtEstado_Retencion.TabIndex = 2
        Me.rbtEstado_Retencion.Text = "Retencion"
        Me.rbtEstado_Retencion.UseVisualStyleBackColor = True
        '
        'rbtEstado_Bloqueado
        '
        Me.rbtEstado_Bloqueado.AutoSize = True
        Me.rbtEstado_Bloqueado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtEstado_Bloqueado.Location = New System.Drawing.Point(6, 51)
        Me.rbtEstado_Bloqueado.Name = "rbtEstado_Bloqueado"
        Me.rbtEstado_Bloqueado.Size = New System.Drawing.Size(85, 17)
        Me.rbtEstado_Bloqueado.TabIndex = 1
        Me.rbtEstado_Bloqueado.Text = "Bloqueado"
        Me.rbtEstado_Bloqueado.UseVisualStyleBackColor = True
        '
        'rbtEstado_Entratamiento
        '
        Me.rbtEstado_Entratamiento.AutoSize = True
        Me.rbtEstado_Entratamiento.Checked = True
        Me.rbtEstado_Entratamiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtEstado_Entratamiento.Location = New System.Drawing.Point(6, 30)
        Me.rbtEstado_Entratamiento.Name = "rbtEstado_Entratamiento"
        Me.rbtEstado_Entratamiento.Size = New System.Drawing.Size(111, 17)
        Me.rbtEstado_Entratamiento.TabIndex = 0
        Me.rbtEstado_Entratamiento.TabStop = True
        Me.rbtEstado_Entratamiento.Text = "En Tratamiento"
        Me.rbtEstado_Entratamiento.UseVisualStyleBackColor = True
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(14, 7)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(499, 23)
        Me.lblTituloVentana.TabIndex = 0
        Me.lblTituloVentana.Text = "PACIENTES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbEntidad
        '
        Me.cmbEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEntidad.FormattingEnabled = True
        Me.cmbEntidad.ItemHeight = 13
        Me.cmbEntidad.Location = New System.Drawing.Point(99, 369)
        Me.cmbEntidad.Name = "cmbEntidad"
        Me.cmbEntidad.Size = New System.Drawing.Size(264, 21)
        Me.cmbEntidad.TabIndex = 35
        '
        'txtIdpaciente
        '
        Me.txtIdpaciente.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdpaciente.Border.Class = "TextBoxBorder"
        Me.txtIdpaciente.Location = New System.Drawing.Point(99, 393)
        Me.txtIdpaciente.Name = "txtIdpaciente"
        Me.txtIdpaciente.ReadOnly = True
        Me.txtIdpaciente.Size = New System.Drawing.Size(55, 20)
        Me.txtIdpaciente.TabIndex = 37
        Me.txtIdpaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblnhclinica
        '
        Me.lblnhclinica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnhclinica.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblnhclinica.ForeColor = System.Drawing.Color.Navy
        Me.lblnhclinica.Location = New System.Drawing.Point(155, 393)
        Me.lblnhclinica.Name = "lblnhclinica"
        Me.lblnhclinica.Size = New System.Drawing.Size(75, 20)
        Me.lblnhclinica.TabIndex = 38
        Me.lblnhclinica.Text = "No. Historia"
        Me.lblnhclinica.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblIdpaciente
        '
        Me.lblIdpaciente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIdpaciente.Location = New System.Drawing.Point(12, 393)
        Me.lblIdpaciente.Name = "lblIdpaciente"
        Me.lblIdpaciente.Size = New System.Drawing.Size(81, 20)
        Me.lblIdpaciente.TabIndex = 36
        Me.lblIdpaciente.Text = "No. Afiliación"
        Me.lblIdpaciente.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblEntidad
        '
        Me.lblEntidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEntidad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblEntidad.ForeColor = System.Drawing.Color.Navy
        Me.lblEntidad.Location = New System.Drawing.Point(12, 369)
        Me.lblEntidad.Name = "lblEntidad"
        Me.lblEntidad.Size = New System.Drawing.Size(81, 20)
        Me.lblEntidad.TabIndex = 34
        Me.lblEntidad.Text = "Empresa"
        Me.lblEntidad.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gPanel_Edad
        '
        Me.gPanel_Edad.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Edad.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Edad.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Edad.Controls.Add(Me.lblNumaños)
        Me.gPanel_Edad.Controls.Add(Me.rbtAños_pac)
        Me.gPanel_Edad.Controls.Add(Me.rbtmeses_pac)
        Me.gPanel_Edad.Location = New System.Drawing.Point(15, 321)
        Me.gPanel_Edad.Name = "gPanel_Edad"
        Me.gPanel_Edad.Size = New System.Drawing.Size(192, 46)
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
        Me.gPanel_Edad.TabIndex = 32
        Me.gPanel_Edad.Text = "Edad"
        '
        'lblNumaños
        '
        Me.lblNumaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumaños.Location = New System.Drawing.Point(144, -2)
        Me.lblNumaños.Name = "lblNumaños"
        Me.lblNumaños.Size = New System.Drawing.Size(39, 24)
        Me.lblNumaños.TabIndex = 2
        Me.lblNumaños.Text = "0"
        Me.lblNumaños.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rbtAños_pac
        '
        Me.rbtAños_pac.AutoSize = True
        Me.rbtAños_pac.Checked = True
        Me.rbtAños_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAños_pac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtAños_pac.Location = New System.Drawing.Point(3, 3)
        Me.rbtAños_pac.Name = "rbtAños_pac"
        Me.rbtAños_pac.Size = New System.Drawing.Size(53, 17)
        Me.rbtAños_pac.TabIndex = 0
        Me.rbtAños_pac.TabStop = True
        Me.rbtAños_pac.Text = "Años"
        Me.rbtAños_pac.UseVisualStyleBackColor = True
        '
        'rbtmeses_pac
        '
        Me.rbtmeses_pac.AutoSize = True
        Me.rbtmeses_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtmeses_pac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtmeses_pac.Location = New System.Drawing.Point(64, 4)
        Me.rbtmeses_pac.Name = "rbtmeses_pac"
        Me.rbtmeses_pac.Size = New System.Drawing.Size(61, 17)
        Me.rbtmeses_pac.TabIndex = 1
        Me.rbtmeses_pac.Text = "Meses"
        Me.rbtmeses_pac.UseVisualStyleBackColor = True
        '
        'gPanel_Sexo
        '
        Me.gPanel_Sexo.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Sexo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Sexo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Sexo.Controls.Add(Me.rbtFemenino_pac)
        Me.gPanel_Sexo.Controls.Add(Me.rbtMasculino_pac)
        Me.gPanel_Sexo.Location = New System.Drawing.Point(13, 270)
        Me.gPanel_Sexo.Name = "gPanel_Sexo"
        Me.gPanel_Sexo.Size = New System.Drawing.Size(76, 49)
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
        Me.gPanel_Sexo.TabIndex = 27
        Me.gPanel_Sexo.Text = "Sexo"
        '
        'rbtFemenino_pac
        '
        Me.rbtFemenino_pac.AutoSize = True
        Me.rbtFemenino_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemenino_pac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtFemenino_pac.Location = New System.Drawing.Point(40, 3)
        Me.rbtFemenino_pac.Name = "rbtFemenino_pac"
        Me.rbtFemenino_pac.Size = New System.Drawing.Size(32, 17)
        Me.rbtFemenino_pac.TabIndex = 1
        Me.rbtFemenino_pac.Text = "F"
        Me.rbtFemenino_pac.UseVisualStyleBackColor = True
        '
        'rbtMasculino_pac
        '
        Me.rbtMasculino_pac.AutoSize = True
        Me.rbtMasculino_pac.Checked = True
        Me.rbtMasculino_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMasculino_pac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtMasculino_pac.Location = New System.Drawing.Point(3, 3)
        Me.rbtMasculino_pac.Name = "rbtMasculino_pac"
        Me.rbtMasculino_pac.Size = New System.Drawing.Size(35, 17)
        Me.rbtMasculino_pac.TabIndex = 0
        Me.rbtMasculino_pac.TabStop = True
        Me.rbtMasculino_pac.Text = "M"
        Me.rbtMasculino_pac.UseVisualStyleBackColor = True
        '
        'lblnumdoc_pac
        '
        Me.lblnumdoc_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnumdoc_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblnumdoc_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblnumdoc_pac.Location = New System.Drawing.Point(232, 246)
        Me.lblnumdoc_pac.Name = "lblnumdoc_pac"
        Me.lblnumdoc_pac.Size = New System.Drawing.Size(31, 20)
        Me.lblnumdoc_pac.TabIndex = 24
        Me.lblnumdoc_pac.Text = "No."
        Me.lblnumdoc_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtocupacion_pac
        '
        '
        '
        '
        Me.txtocupacion_pac.Border.Class = "TextBoxBorder"
        Me.txtocupacion_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtocupacion_pac.Location = New System.Drawing.Point(253, 129)
        Me.txtocupacion_pac.Name = "txtocupacion_pac"
        Me.txtocupacion_pac.Size = New System.Drawing.Size(258, 20)
        Me.txtocupacion_pac.TabIndex = 10
        '
        'lbltipodoc_pac
        '
        Me.lbltipodoc_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbltipodoc_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbltipodoc_pac.ForeColor = System.Drawing.Color.Navy
        Me.lbltipodoc_pac.Location = New System.Drawing.Point(232, 223)
        Me.lbltipodoc_pac.Name = "lbltipodoc_pac"
        Me.lbltipodoc_pac.Size = New System.Drawing.Size(93, 20)
        Me.lbltipodoc_pac.TabIndex = 20
        Me.lbltipodoc_pac.Text = "Doc. de Identidad"
        Me.lbltipodoc_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbfecnac_pac
        '
        Me.cmbfecnac_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecnac_pac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbfecnac_pac.Location = New System.Drawing.Point(129, 221)
        Me.cmbfecnac_pac.Name = "cmbfecnac_pac"
        Me.cmbfecnac_pac.Size = New System.Drawing.Size(100, 21)
        Me.cmbfecnac_pac.TabIndex = 22
        Me.cmbfecnac_pac.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'cmbfecingreso_pac
        '
        Me.cmbfecingreso_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecingreso_pac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecingreso_pac.Location = New System.Drawing.Point(130, 198)
        Me.cmbfecingreso_pac.Name = "cmbfecingreso_pac"
        Me.cmbfecingreso_pac.Size = New System.Drawing.Size(99, 21)
        Me.cmbfecingreso_pac.TabIndex = 18
        Me.cmbfecingreso_pac.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblfecnac_pac
        '
        Me.lblfecnac_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfecnac_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblfecnac_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblfecnac_pac.Location = New System.Drawing.Point(13, 222)
        Me.lblfecnac_pac.Name = "lblfecnac_pac"
        Me.lblfecnac_pac.Size = New System.Drawing.Size(113, 22)
        Me.lblfecnac_pac.TabIndex = 23
        Me.lblfecnac_pac.Text = "Fecha de Nacimiento"
        Me.lblfecnac_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtreferido_pac
        '
        '
        '
        '
        Me.txtreferido_pac.Border.Class = "TextBoxBorder"
        Me.txtreferido_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferido_pac.Location = New System.Drawing.Point(253, 81)
        Me.txtreferido_pac.Name = "txtreferido_pac"
        Me.txtreferido_pac.Size = New System.Drawing.Size(258, 20)
        Me.txtreferido_pac.TabIndex = 6
        '
        'txtoficina_pac
        '
        '
        '
        '
        Me.txtoficina_pac.Border.Class = "TextBoxBorder"
        Me.txtoficina_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtoficina_pac.Location = New System.Drawing.Point(253, 105)
        Me.txtoficina_pac.Name = "txtoficina_pac"
        Me.txtoficina_pac.Size = New System.Drawing.Size(258, 20)
        Me.txtoficina_pac.TabIndex = 8
        '
        'txtresidencia_pac
        '
        '
        '
        '
        Me.txtresidencia_pac.Border.Class = "TextBoxBorder"
        Me.txtresidencia_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtresidencia_pac.Location = New System.Drawing.Point(253, 152)
        Me.txtresidencia_pac.Name = "txtresidencia_pac"
        Me.txtresidencia_pac.Size = New System.Drawing.Size(135, 20)
        Me.txtresidencia_pac.TabIndex = 15
        '
        'txtnombres_pac
        '
        '
        '
        '
        Me.txtnombres_pac.Border.Class = "TextBoxBorder"
        Me.txtnombres_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombres_pac.Location = New System.Drawing.Point(253, 58)
        Me.txtnombres_pac.Name = "txtnombres_pac"
        Me.txtnombres_pac.Size = New System.Drawing.Size(258, 20)
        Me.txtnombres_pac.TabIndex = 4
        Me.txtnombres_pac.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtapellidos_pac
        '
        '
        '
        '
        Me.txtapellidos_pac.Border.Class = "TextBoxBorder"
        Me.txtapellidos_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtapellidos_pac.Location = New System.Drawing.Point(253, 35)
        Me.txtapellidos_pac.Name = "txtapellidos_pac"
        Me.txtapellidos_pac.Size = New System.Drawing.Size(258, 20)
        Me.txtapellidos_pac.TabIndex = 2
        Me.txtapellidos_pac.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lblfecingreso_pac
        '
        Me.lblfecingreso_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfecingreso_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblfecingreso_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblfecingreso_pac.Location = New System.Drawing.Point(12, 199)
        Me.lblfecingreso_pac.Name = "lblfecingreso_pac"
        Me.lblfecingreso_pac.Size = New System.Drawing.Size(113, 22)
        Me.lblfecingreso_pac.TabIndex = 19
        Me.lblfecingreso_pac.Text = "Ingresó"
        Me.lblfecingreso_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lbloficina_pac
        '
        Me.lbloficina_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbloficina_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbloficina_pac.ForeColor = System.Drawing.Color.Navy
        Me.lbloficina_pac.Location = New System.Drawing.Point(175, 105)
        Me.lbloficina_pac.Name = "lbloficina_pac"
        Me.lbloficina_pac.Size = New System.Drawing.Size(72, 20)
        Me.lbloficina_pac.TabIndex = 7
        Me.lbloficina_pac.Text = "Oficina"
        Me.lbloficina_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblocupacion_pac
        '
        Me.lblocupacion_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblocupacion_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblocupacion_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblocupacion_pac.Location = New System.Drawing.Point(175, 129)
        Me.lblocupacion_pac.Name = "lblocupacion_pac"
        Me.lblocupacion_pac.Size = New System.Drawing.Size(72, 20)
        Me.lblocupacion_pac.TabIndex = 9
        Me.lblocupacion_pac.Text = "Ocupación"
        Me.lblocupacion_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblresidencia_pac
        '
        Me.lblresidencia_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblresidencia_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblresidencia_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblresidencia_pac.Location = New System.Drawing.Point(175, 152)
        Me.lblresidencia_pac.Name = "lblresidencia_pac"
        Me.lblresidencia_pac.Size = New System.Drawing.Size(72, 20)
        Me.lblresidencia_pac.TabIndex = 14
        Me.lblresidencia_pac.Text = "Residencia"
        Me.lblresidencia_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblnombres_pac
        '
        Me.lblnombres_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnombres_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblnombres_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblnombres_pac.Location = New System.Drawing.Point(175, 58)
        Me.lblnombres_pac.Name = "lblnombres_pac"
        Me.lblnombres_pac.Size = New System.Drawing.Size(72, 20)
        Me.lblnombres_pac.TabIndex = 3
        Me.lblnombres_pac.Text = "Nombres"
        Me.lblnombres_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblreferido_pac
        '
        Me.lblreferido_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblreferido_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblreferido_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblreferido_pac.Location = New System.Drawing.Point(175, 81)
        Me.lblreferido_pac.Name = "lblreferido_pac"
        Me.lblreferido_pac.Size = New System.Drawing.Size(72, 20)
        Me.lblreferido_pac.TabIndex = 5
        Me.lblreferido_pac.Text = "Remitido Por"
        Me.lblreferido_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblapellidos_pac
        '
        Me.lblapellidos_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblapellidos_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblapellidos_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblapellidos_pac.Location = New System.Drawing.Point(175, 35)
        Me.lblapellidos_pac.Name = "lblapellidos_pac"
        Me.lblapellidos_pac.Size = New System.Drawing.Size(72, 20)
        Me.lblapellidos_pac.TabIndex = 1
        Me.lblapellidos_pac.Text = "Apellidos"
        Me.lblapellidos_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnEstadoCuenta
        '
        Me.btnEstadoCuenta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEstadoCuenta.Enabled = False
        Me.btnEstadoCuenta.Image = CType(resources.GetObject("btnEstadoCuenta.Image"), System.Drawing.Image)
        Me.btnEstadoCuenta.Location = New System.Drawing.Point(232, 343)
        Me.btnEstadoCuenta.Name = "btnEstadoCuenta"
        Me.btnEstadoCuenta.Size = New System.Drawing.Size(131, 23)
        Me.btnEstadoCuenta.TabIndex = 33
        Me.btnEstadoCuenta.Text = "ESTADO CUENTA"
        Me.btnEstadoCuenta.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnFotoA
        '
        Me.btnFotoA.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFotoA.Image = CType(resources.GetObject("btnFotoA.Image"), System.Drawing.Image)
        Me.btnFotoA.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnFotoA.Location = New System.Drawing.Point(12, 151)
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
        Me.btnFoto.Location = New System.Drawing.Point(111, 151)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(58, 36)
        Me.btnFoto.TabIndex = 13
        Me.btnFoto.Text = "CAMARA"
        '
        'btnBorrarFoto
        '
        Me.btnBorrarFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarFoto.Image = CType(resources.GetObject("btnBorrarFoto.Image"), System.Drawing.Image)
        Me.btnBorrarFoto.Location = New System.Drawing.Point(73, 151)
        Me.btnBorrarFoto.Name = "btnBorrarFoto"
        Me.btnBorrarFoto.Size = New System.Drawing.Size(35, 36)
        Me.btnBorrarFoto.TabIndex = 12
        '
        'btnPacOdontograma
        '
        Me.btnPacOdontograma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPacOdontograma.Enabled = False
        Me.btnPacOdontograma.Image = CType(resources.GetObject("btnPacOdontograma.Image"), System.Drawing.Image)
        Me.btnPacOdontograma.Location = New System.Drawing.Point(232, 318)
        Me.btnPacOdontograma.Name = "btnPacOdontograma"
        Me.btnPacOdontograma.Size = New System.Drawing.Size(131, 23)
        Me.btnPacOdontograma.TabIndex = 31
        Me.btnPacOdontograma.Text = "ODONTOGRAMA"
        Me.btnPacOdontograma.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnEstudiosPac
        '
        Me.btnEstudiosPac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEstudiosPac.Enabled = False
        Me.btnEstudiosPac.Image = CType(resources.GetObject("btnEstudiosPac.Image"), System.Drawing.Image)
        Me.btnEstudiosPac.Location = New System.Drawing.Point(232, 293)
        Me.btnEstudiosPac.Name = "btnEstudiosPac"
        Me.btnEstudiosPac.Size = New System.Drawing.Size(132, 23)
        Me.btnEstudiosPac.TabIndex = 30
        Me.btnEstudiosPac.Text = "ESTUDIOS"
        Me.btnEstudiosPac.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'pbFoto_pac
        '
        Me.pbFoto_pac.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pbFoto_pac.Location = New System.Drawing.Point(12, 35)
        Me.pbFoto_pac.Name = "pbFoto_pac"
        Me.pbFoto_pac.Size = New System.Drawing.Size(157, 108)
        Me.pbFoto_pac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto_pac.TabIndex = 71
        Me.pbFoto_pac.TabStop = False
        '
        'tabDPersonales_pac
        '
        Me.tabDPersonales_pac.AttachedControl = Me.TabControlPanel2
        Me.tabDPersonales_pac.Name = "tabDPersonales_pac"
        Me.tabDPersonales_pac.Text = "Datos Personales"
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
        Me.TabControlPanel1.Size = New System.Drawing.Size(532, 418)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 8
        Me.TabControlPanel1.TabItem = Me.tabContactos_pac
        '
        'gpConyuge
        '
        Me.gpConyuge.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpConyuge.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpConyuge.Controls.Add(Me.btnNoEmail_Conyuge)
        Me.gpConyuge.Controls.Add(Me.txtemailConyuge_pac)
        Me.gpConyuge.Controls.Add(Me.LabelX4)
        Me.gpConyuge.Controls.Add(Me.LabelX31)
        Me.gpConyuge.Controls.Add(Me.txtOcuConyuge_pac)
        Me.gpConyuge.Controls.Add(Me.LabelX32)
        Me.gpConyuge.Controls.Add(Me.txtCelConyuge_pac)
        Me.gpConyuge.Controls.Add(Me.LabelX24)
        Me.gpConyuge.Controls.Add(Me.txtTelConyuge_pac)
        Me.gpConyuge.Controls.Add(Me.txtConyuge_pac)
        Me.gpConyuge.Controls.Add(Me.LabelX25)
        Me.gpConyuge.Location = New System.Drawing.Point(13, 339)
        Me.gpConyuge.Name = "gpConyuge"
        Me.gpConyuge.Size = New System.Drawing.Size(499, 75)
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
        Me.LabelX31.Location = New System.Drawing.Point(247, 25)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(63, 20)
        Me.LabelX31.TabIndex = 6
        Me.LabelX31.Text = "Ocupación"
        Me.LabelX31.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtOcuConyuge_pac
        '
        '
        '
        '
        Me.txtOcuConyuge_pac.Border.Class = "TextBoxBorder"
        Me.txtOcuConyuge_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcuConyuge_pac.Location = New System.Drawing.Point(316, 25)
        Me.txtOcuConyuge_pac.Name = "txtOcuConyuge_pac"
        Me.txtOcuConyuge_pac.Size = New System.Drawing.Size(161, 20)
        Me.txtOcuConyuge_pac.TabIndex = 7
        '
        'LabelX32
        '
        Me.LabelX32.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX32.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX32.ForeColor = System.Drawing.Color.Navy
        Me.LabelX32.Location = New System.Drawing.Point(5, 25)
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.Size = New System.Drawing.Size(97, 20)
        Me.LabelX32.TabIndex = 4
        Me.LabelX32.Text = "Celular"
        Me.LabelX32.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelConyuge_pac
        '
        '
        '
        '
        Me.txtCelConyuge_pac.Border.Class = "TextBoxBorder"
        Me.txtCelConyuge_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelConyuge_pac.Location = New System.Drawing.Point(106, 25)
        Me.txtCelConyuge_pac.Name = "txtCelConyuge_pac"
        Me.txtCelConyuge_pac.Size = New System.Drawing.Size(132, 20)
        Me.txtCelConyuge_pac.TabIndex = 5
        '
        'LabelX24
        '
        Me.LabelX24.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX24.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX24.ForeColor = System.Drawing.Color.Navy
        Me.LabelX24.Location = New System.Drawing.Point(285, 3)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(61, 20)
        Me.LabelX24.TabIndex = 2
        Me.LabelX24.Text = "Telefono"
        Me.LabelX24.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelConyuge_pac
        '
        '
        '
        '
        Me.txtTelConyuge_pac.Border.Class = "TextBoxBorder"
        Me.txtTelConyuge_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelConyuge_pac.Location = New System.Drawing.Point(348, 3)
        Me.txtTelConyuge_pac.Name = "txtTelConyuge_pac"
        Me.txtTelConyuge_pac.Size = New System.Drawing.Size(130, 20)
        Me.txtTelConyuge_pac.TabIndex = 3
        '
        'txtConyuge_pac
        '
        '
        '
        '
        Me.txtConyuge_pac.Border.Class = "TextBoxBorder"
        Me.txtConyuge_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConyuge_pac.Location = New System.Drawing.Point(106, 3)
        Me.txtConyuge_pac.Name = "txtConyuge_pac"
        Me.txtConyuge_pac.Size = New System.Drawing.Size(172, 20)
        Me.txtConyuge_pac.TabIndex = 1
        '
        'LabelX25
        '
        Me.LabelX25.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX25.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX25.ForeColor = System.Drawing.Color.Navy
        Me.LabelX25.Location = New System.Drawing.Point(5, 3)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(97, 20)
        Me.LabelX25.TabIndex = 0
        Me.LabelX25.Text = "Nombre Esposo(a)"
        Me.LabelX25.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpPadres
        '
        Me.gpPadres.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPadres.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPadres.Controls.Add(Me.btnNoEmail_Acudiente)
        Me.gpPadres.Controls.Add(Me.txtemailAcudiente_pac)
        Me.gpPadres.Controls.Add(Me.LabelX5)
        Me.gpPadres.Controls.Add(Me.btnNoEmail_Madre)
        Me.gpPadres.Controls.Add(Me.txtemailMadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX3)
        Me.gpPadres.Controls.Add(Me.btnNoEmail_Padre)
        Me.gpPadres.Controls.Add(Me.txtemailPadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX2)
        Me.gpPadres.Controls.Add(Me.LabelX33)
        Me.gpPadres.Controls.Add(Me.txtOcuAcudiente_pac)
        Me.gpPadres.Controls.Add(Me.LabelX34)
        Me.gpPadres.Controls.Add(Me.txtCelAcudiente_pac)
        Me.gpPadres.Controls.Add(Me.LabelX35)
        Me.gpPadres.Controls.Add(Me.txtTelAcudiente_pac)
        Me.gpPadres.Controls.Add(Me.txtAcudiente_pac)
        Me.gpPadres.Controls.Add(Me.LabelX36)
        Me.gpPadres.Controls.Add(Me.LabelX30)
        Me.gpPadres.Controls.Add(Me.txtOcuMadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX29)
        Me.gpPadres.Controls.Add(Me.txtOcuPadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX28)
        Me.gpPadres.Controls.Add(Me.txtCelMadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX27)
        Me.gpPadres.Controls.Add(Me.txtCelPadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX22)
        Me.gpPadres.Controls.Add(Me.txtTelMadre_pac)
        Me.gpPadres.Controls.Add(Me.txtMadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX23)
        Me.gpPadres.Controls.Add(Me.LabelX20)
        Me.gpPadres.Controls.Add(Me.txtTelPadre_pac)
        Me.gpPadres.Controls.Add(Me.txtPadre_pac)
        Me.gpPadres.Controls.Add(Me.LabelX19)
        Me.gpPadres.Location = New System.Drawing.Point(12, 109)
        Me.gpPadres.Name = "gpPadres"
        Me.gpPadres.Size = New System.Drawing.Size(501, 226)
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
        'LabelX33
        '
        Me.LabelX33.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX33.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX33.ForeColor = System.Drawing.Color.Navy
        Me.LabelX33.Location = New System.Drawing.Point(248, 177)
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.Size = New System.Drawing.Size(63, 20)
        Me.LabelX33.TabIndex = 22
        Me.LabelX33.Text = "Ocupación"
        Me.LabelX33.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtOcuAcudiente_pac
        '
        '
        '
        '
        Me.txtOcuAcudiente_pac.Border.Class = "TextBoxBorder"
        Me.txtOcuAcudiente_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcuAcudiente_pac.Location = New System.Drawing.Point(318, 177)
        Me.txtOcuAcudiente_pac.Name = "txtOcuAcudiente_pac"
        Me.txtOcuAcudiente_pac.Size = New System.Drawing.Size(161, 20)
        Me.txtOcuAcudiente_pac.TabIndex = 23
        '
        'LabelX34
        '
        Me.LabelX34.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX34.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX34.ForeColor = System.Drawing.Color.Navy
        Me.LabelX34.Location = New System.Drawing.Point(5, 177)
        Me.LabelX34.Name = "LabelX34"
        Me.LabelX34.Size = New System.Drawing.Size(97, 20)
        Me.LabelX34.TabIndex = 20
        Me.LabelX34.Text = "Celular"
        Me.LabelX34.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelAcudiente_pac
        '
        '
        '
        '
        Me.txtCelAcudiente_pac.Border.Class = "TextBoxBorder"
        Me.txtCelAcudiente_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelAcudiente_pac.Location = New System.Drawing.Point(106, 177)
        Me.txtCelAcudiente_pac.Name = "txtCelAcudiente_pac"
        Me.txtCelAcudiente_pac.Size = New System.Drawing.Size(132, 20)
        Me.txtCelAcudiente_pac.TabIndex = 21
        '
        'LabelX35
        '
        Me.LabelX35.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX35.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX35.ForeColor = System.Drawing.Color.Navy
        Me.LabelX35.Location = New System.Drawing.Point(286, 155)
        Me.LabelX35.Name = "LabelX35"
        Me.LabelX35.Size = New System.Drawing.Size(61, 20)
        Me.LabelX35.TabIndex = 18
        Me.LabelX35.Text = "Telefono"
        Me.LabelX35.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelAcudiente_pac
        '
        '
        '
        '
        Me.txtTelAcudiente_pac.Border.Class = "TextBoxBorder"
        Me.txtTelAcudiente_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelAcudiente_pac.Location = New System.Drawing.Point(356, 155)
        Me.txtTelAcudiente_pac.Name = "txtTelAcudiente_pac"
        Me.txtTelAcudiente_pac.Size = New System.Drawing.Size(123, 20)
        Me.txtTelAcudiente_pac.TabIndex = 19
        '
        'txtAcudiente_pac
        '
        '
        '
        '
        Me.txtAcudiente_pac.Border.Class = "TextBoxBorder"
        Me.txtAcudiente_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAcudiente_pac.Location = New System.Drawing.Point(106, 155)
        Me.txtAcudiente_pac.Name = "txtAcudiente_pac"
        Me.txtAcudiente_pac.Size = New System.Drawing.Size(172, 20)
        Me.txtAcudiente_pac.TabIndex = 17
        '
        'LabelX36
        '
        Me.LabelX36.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX36.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX36.ForeColor = System.Drawing.Color.Navy
        Me.LabelX36.Location = New System.Drawing.Point(6, 155)
        Me.LabelX36.Name = "LabelX36"
        Me.LabelX36.Size = New System.Drawing.Size(96, 20)
        Me.LabelX36.TabIndex = 16
        Me.LabelX36.Text = "Nombre Acudiente"
        Me.LabelX36.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX30
        '
        Me.LabelX30.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX30.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX30.ForeColor = System.Drawing.Color.Navy
        Me.LabelX30.Location = New System.Drawing.Point(248, 100)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(63, 20)
        Me.LabelX30.TabIndex = 14
        Me.LabelX30.Text = "Ocupación"
        Me.LabelX30.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtOcuMadre_pac
        '
        '
        '
        '
        Me.txtOcuMadre_pac.Border.Class = "TextBoxBorder"
        Me.txtOcuMadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcuMadre_pac.Location = New System.Drawing.Point(318, 100)
        Me.txtOcuMadre_pac.Name = "txtOcuMadre_pac"
        Me.txtOcuMadre_pac.Size = New System.Drawing.Size(160, 20)
        Me.txtOcuMadre_pac.TabIndex = 15
        '
        'LabelX29
        '
        Me.LabelX29.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX29.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX29.ForeColor = System.Drawing.Color.Navy
        Me.LabelX29.Location = New System.Drawing.Point(247, 25)
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.Size = New System.Drawing.Size(63, 20)
        Me.LabelX29.TabIndex = 6
        Me.LabelX29.Text = "Ocupación"
        Me.LabelX29.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtOcuPadre_pac
        '
        '
        '
        '
        Me.txtOcuPadre_pac.Border.Class = "TextBoxBorder"
        Me.txtOcuPadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcuPadre_pac.Location = New System.Drawing.Point(317, 25)
        Me.txtOcuPadre_pac.Name = "txtOcuPadre_pac"
        Me.txtOcuPadre_pac.Size = New System.Drawing.Size(161, 20)
        Me.txtOcuPadre_pac.TabIndex = 7
        '
        'LabelX28
        '
        Me.LabelX28.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX28.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX28.ForeColor = System.Drawing.Color.Navy
        Me.LabelX28.Location = New System.Drawing.Point(5, 100)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(97, 20)
        Me.LabelX28.TabIndex = 12
        Me.LabelX28.Text = "Celular"
        Me.LabelX28.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelMadre_pac
        '
        '
        '
        '
        Me.txtCelMadre_pac.Border.Class = "TextBoxBorder"
        Me.txtCelMadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelMadre_pac.Location = New System.Drawing.Point(105, 100)
        Me.txtCelMadre_pac.Name = "txtCelMadre_pac"
        Me.txtCelMadre_pac.Size = New System.Drawing.Size(132, 20)
        Me.txtCelMadre_pac.TabIndex = 13
        '
        'LabelX27
        '
        Me.LabelX27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX27.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX27.ForeColor = System.Drawing.Color.Navy
        Me.LabelX27.Location = New System.Drawing.Point(5, 25)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(97, 20)
        Me.LabelX27.TabIndex = 4
        Me.LabelX27.Text = "Celular"
        Me.LabelX27.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelPadre_pac
        '
        '
        '
        '
        Me.txtCelPadre_pac.Border.Class = "TextBoxBorder"
        Me.txtCelPadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelPadre_pac.Location = New System.Drawing.Point(106, 25)
        Me.txtCelPadre_pac.Name = "txtCelPadre_pac"
        Me.txtCelPadre_pac.Size = New System.Drawing.Size(132, 20)
        Me.txtCelPadre_pac.TabIndex = 5
        '
        'LabelX22
        '
        Me.LabelX22.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX22.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX22.ForeColor = System.Drawing.Color.Navy
        Me.LabelX22.Location = New System.Drawing.Point(285, 78)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(61, 20)
        Me.LabelX22.TabIndex = 10
        Me.LabelX22.Text = "Telefono"
        Me.LabelX22.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelMadre_pac
        '
        '
        '
        '
        Me.txtTelMadre_pac.Border.Class = "TextBoxBorder"
        Me.txtTelMadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelMadre_pac.Location = New System.Drawing.Point(355, 78)
        Me.txtTelMadre_pac.Name = "txtTelMadre_pac"
        Me.txtTelMadre_pac.Size = New System.Drawing.Size(123, 20)
        Me.txtTelMadre_pac.TabIndex = 11
        '
        'txtMadre_pac
        '
        '
        '
        '
        Me.txtMadre_pac.Border.Class = "TextBoxBorder"
        Me.txtMadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMadre_pac.Location = New System.Drawing.Point(105, 78)
        Me.txtMadre_pac.Name = "txtMadre_pac"
        Me.txtMadre_pac.Size = New System.Drawing.Size(173, 20)
        Me.txtMadre_pac.TabIndex = 9
        '
        'LabelX23
        '
        Me.LabelX23.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX23.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX23.ForeColor = System.Drawing.Color.Navy
        Me.LabelX23.Location = New System.Drawing.Point(5, 78)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(97, 20)
        Me.LabelX23.TabIndex = 8
        Me.LabelX23.Text = "Nombre Madre"
        Me.LabelX23.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX20
        '
        Me.LabelX20.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX20.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX20.ForeColor = System.Drawing.Color.Navy
        Me.LabelX20.Location = New System.Drawing.Point(285, 3)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(61, 20)
        Me.LabelX20.TabIndex = 2
        Me.LabelX20.Text = "Telefono"
        Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelPadre_pac
        '
        '
        '
        '
        Me.txtTelPadre_pac.Border.Class = "TextBoxBorder"
        Me.txtTelPadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelPadre_pac.Location = New System.Drawing.Point(352, 3)
        Me.txtTelPadre_pac.Name = "txtTelPadre_pac"
        Me.txtTelPadre_pac.Size = New System.Drawing.Size(126, 20)
        Me.txtTelPadre_pac.TabIndex = 3
        '
        'txtPadre_pac
        '
        '
        '
        '
        Me.txtPadre_pac.Border.Class = "TextBoxBorder"
        Me.txtPadre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPadre_pac.Location = New System.Drawing.Point(106, 3)
        Me.txtPadre_pac.Name = "txtPadre_pac"
        Me.txtPadre_pac.Size = New System.Drawing.Size(173, 20)
        Me.txtPadre_pac.TabIndex = 1
        '
        'LabelX19
        '
        Me.LabelX19.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX19.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX19.ForeColor = System.Drawing.Color.Navy
        Me.LabelX19.Location = New System.Drawing.Point(5, 3)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(97, 20)
        Me.LabelX19.TabIndex = 0
        Me.LabelX19.Text = "Nombre Padre"
        Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpContactos
        '
        Me.gpContactos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpContactos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpContactos.Controls.Add(Me.cmbOperadorCel)
        Me.gpContactos.Controls.Add(Me.LabelX1)
        Me.gpContactos.Controls.Add(Me.btnNoEmail)
        Me.gpContactos.Controls.Add(Me.txtemail_pac)
        Me.gpContactos.Controls.Add(Me.txtweb_pac)
        Me.gpContactos.Controls.Add(Me.LabelX26)
        Me.gpContactos.Controls.Add(Me.LabelX21)
        Me.gpContactos.Controls.Add(Me.txtCelular_pac)
        Me.gpContactos.Controls.Add(Me.txtFax_pac)
        Me.gpContactos.Controls.Add(Me.LabelX18)
        Me.gpContactos.Controls.Add(Me.LabelX17)
        Me.gpContactos.Controls.Add(Me.txtTelOficina_pac)
        Me.gpContactos.Controls.Add(Me.LabelX16)
        Me.gpContactos.Controls.Add(Me.txtTelCasa_pac)
        Me.gpContactos.Controls.Add(Me.LabelX15)
        Me.gpContactos.Location = New System.Drawing.Point(14, 5)
        Me.gpContactos.Name = "gpContactos"
        Me.gpContactos.Size = New System.Drawing.Size(499, 99)
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
        'cmbOperadorCel
        '
        Me.cmbOperadorCel.AutoCompleteCustomSource.AddRange(New String() {"Radiografia de Perfil", "Senos Paranasales", "Panorámica", "ATM", "Coronales", "Anteroposterior", "Posteoanterior", "Periapical 1", "Periapical 2", "Periapical 3", "periapical 4", "Periapicales Completos"})
        Me.cmbOperadorCel.DisplayMember = "Text"
        Me.cmbOperadorCel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbOperadorCel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperadorCel.FormattingEnabled = True
        Me.cmbOperadorCel.ItemHeight = 14
        Me.cmbOperadorCel.Location = New System.Drawing.Point(97, 47)
        Me.cmbOperadorCel.Name = "cmbOperadorCel"
        Me.cmbOperadorCel.Size = New System.Drawing.Size(147, 20)
        Me.cmbOperadorCel.TabIndex = 9
        Me.cmbOperadorCel.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(5, 47)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(86, 20)
        Me.LabelX1.TabIndex = 8
        Me.LabelX1.Tag = ""
        Me.LabelX1.Text = "Oper.Celular"
        '
        'btnNoEmail
        '
        Me.btnNoEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail.Image = CType(resources.GetObject("btnNoEmail.Image"), System.Drawing.Image)
        Me.btnNoEmail.Location = New System.Drawing.Point(456, 71)
        Me.btnNoEmail.Name = "btnNoEmail"
        Me.btnNoEmail.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail.TabIndex = 13
        '
        'txtemail_pac
        '
        Me.txtemail_pac.Location = New System.Drawing.Point(96, 71)
        Me.txtemail_pac.Name = "txtemail_pac"
        Me.txtemail_pac.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemail_pac.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemail_pac.Properties.Mask.BeepOnError = True
        Me.txtemail_pac.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemail_pac.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemail_pac.Properties.Mask.ShowPlaceHolders = False
        Me.txtemail_pac.Size = New System.Drawing.Size(355, 20)
        Me.txtemail_pac.TabIndex = 12
        '
        'txtweb_pac
        '
        '
        '
        '
        Me.txtweb_pac.Border.Class = "TextBoxBorder"
        Me.txtweb_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtweb_pac.Location = New System.Drawing.Point(348, 47)
        Me.txtweb_pac.Name = "txtweb_pac"
        Me.txtweb_pac.Size = New System.Drawing.Size(130, 20)
        Me.txtweb_pac.TabIndex = 11
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX26.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX26.ForeColor = System.Drawing.Color.Navy
        Me.LabelX26.Location = New System.Drawing.Point(250, 47)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(95, 21)
        Me.LabelX26.TabIndex = 10
        Me.LabelX26.Text = "Pagina Web"
        Me.LabelX26.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX21
        '
        Me.LabelX21.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX21.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX21.ForeColor = System.Drawing.Color.Navy
        Me.LabelX21.Location = New System.Drawing.Point(250, 25)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(95, 20)
        Me.LabelX21.TabIndex = 6
        Me.LabelX21.Text = "Celular"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelular_pac
        '
        '
        '
        '
        Me.txtCelular_pac.Border.Class = "TextBoxBorder"
        Me.txtCelular_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular_pac.Location = New System.Drawing.Point(348, 25)
        Me.txtCelular_pac.Name = "txtCelular_pac"
        Me.txtCelular_pac.Size = New System.Drawing.Size(130, 20)
        Me.txtCelular_pac.TabIndex = 7
        Me.txtCelular_pac.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtFax_pac
        '
        '
        '
        '
        Me.txtFax_pac.Border.Class = "TextBoxBorder"
        Me.txtFax_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax_pac.Location = New System.Drawing.Point(96, 25)
        Me.txtFax_pac.Name = "txtFax_pac"
        Me.txtFax_pac.Size = New System.Drawing.Size(149, 20)
        Me.txtFax_pac.TabIndex = 5
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX18.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(5, 25)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(86, 20)
        Me.LabelX18.TabIndex = 4
        Me.LabelX18.Text = "Fax"
        Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX17
        '
        Me.LabelX17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX17.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX17.ForeColor = System.Drawing.Color.Navy
        Me.LabelX17.Location = New System.Drawing.Point(250, 3)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(95, 20)
        Me.LabelX17.TabIndex = 2
        Me.LabelX17.Text = "Telefono Oficina"
        Me.LabelX17.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelOficina_pac
        '
        '
        '
        '
        Me.txtTelOficina_pac.Border.Class = "TextBoxBorder"
        Me.txtTelOficina_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelOficina_pac.Location = New System.Drawing.Point(348, 3)
        Me.txtTelOficina_pac.Name = "txtTelOficina_pac"
        Me.txtTelOficina_pac.Size = New System.Drawing.Size(130, 20)
        Me.txtTelOficina_pac.TabIndex = 3
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX16.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX16.ForeColor = System.Drawing.Color.Navy
        Me.LabelX16.Location = New System.Drawing.Point(5, 3)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(86, 20)
        Me.LabelX16.TabIndex = 0
        Me.LabelX16.Text = "Telefono Casa"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelCasa_pac
        '
        '
        '
        '
        Me.txtTelCasa_pac.Border.Class = "TextBoxBorder"
        Me.txtTelCasa_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelCasa_pac.Location = New System.Drawing.Point(96, 3)
        Me.txtTelCasa_pac.Name = "txtTelCasa_pac"
        Me.txtTelCasa_pac.Size = New System.Drawing.Size(149, 20)
        Me.txtTelCasa_pac.TabIndex = 1
        Me.txtTelCasa_pac.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX15.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX15.ForeColor = System.Drawing.Color.Navy
        Me.LabelX15.Location = New System.Drawing.Point(5, 72)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(86, 20)
        Me.LabelX15.TabIndex = 14
        Me.LabelX15.Text = "E-Mail"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tabContactos_pac
        '
        Me.tabContactos_pac.AttachedControl = Me.TabControlPanel1
        Me.tabContactos_pac.Name = "tabContactos_pac"
        Me.tabContactos_pac.Text = "Contactos"
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
        Me.TabControlPanel3.Size = New System.Drawing.Size(532, 418)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 2
        Me.TabControlPanel3.TabItem = Me.tabNotas_pac
        '
        'gpNotas
        '
        Me.gpNotas.BackColor = System.Drawing.Color.Transparent
        Me.gpNotas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpNotas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpNotas.Controls.Add(Me.RichTxtNotas_pac)
        Me.gpNotas.Location = New System.Drawing.Point(27, 9)
        Me.gpNotas.Name = "gpNotas"
        Me.gpNotas.Size = New System.Drawing.Size(481, 260)
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
        Me.gpNotas.Text = "Notas paciente"
        '
        'RichTxtNotas_pac
        '
        Me.RichTxtNotas_pac.Location = New System.Drawing.Point(11, 11)
        Me.RichTxtNotas_pac.Name = "RichTxtNotas_pac"
        Me.RichTxtNotas_pac.Size = New System.Drawing.Size(453, 214)
        Me.RichTxtNotas_pac.TabIndex = 0
        Me.RichTxtNotas_pac.TabStop = False
        Me.RichTxtNotas_pac.Text = ""
        '
        'lblRegistroBiometrico
        '
        Me.lblRegistroBiometrico.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRegistroBiometrico.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroBiometrico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRegistroBiometrico.Location = New System.Drawing.Point(27, 285)
        Me.lblRegistroBiometrico.Name = "lblRegistroBiometrico"
        Me.lblRegistroBiometrico.Size = New System.Drawing.Size(481, 23)
        Me.lblRegistroBiometrico.TabIndex = 4
        Me.lblRegistroBiometrico.Text = "REGISTRO BIOMETRICO"
        Me.lblRegistroBiometrico.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpRegistroBiometrico
        '
        Me.gpRegistroBiometrico.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpRegistroBiometrico.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpRegistroBiometrico.Controls.Add(Me.btnRegistroBiometrico)
        Me.gpRegistroBiometrico.Location = New System.Drawing.Point(26, 320)
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
        Me.gpRegistroBiometrico.TabIndex = 3
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
        'tabNotas_pac
        '
        Me.tabNotas_pac.AttachedControl = Me.TabControlPanel3
        Me.tabNotas_pac.Name = "tabNotas_pac"
        Me.tabNotas_pac.Text = "Notas"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'TimerPac
        '
        Me.TimerPac.Interval = 6000
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
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
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(316, 441)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 39)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(12, 441)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnAdicionar.TabIndex = 0
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(416, 441)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(113, 441)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 39)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(214, 441)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 39)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnNoEmail_Padre
        '
        Me.btnNoEmail_Padre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail_Padre.Image = CType(resources.GetObject("btnNoEmail_Padre.Image"), System.Drawing.Image)
        Me.btnNoEmail_Padre.Location = New System.Drawing.Point(458, 48)
        Me.btnNoEmail_Padre.Name = "btnNoEmail_Padre"
        Me.btnNoEmail_Padre.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail_Padre.TabIndex = 25
        '
        'txtemailPadre_pac
        '
        Me.txtemailPadre_pac.Location = New System.Drawing.Point(106, 48)
        Me.txtemailPadre_pac.Name = "txtemailPadre_pac"
        Me.txtemailPadre_pac.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemailPadre_pac.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemailPadre_pac.Properties.Mask.BeepOnError = True
        Me.txtemailPadre_pac.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemailPadre_pac.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemailPadre_pac.Properties.Mask.ShowPlaceHolders = False
        Me.txtemailPadre_pac.Size = New System.Drawing.Size(347, 20)
        Me.txtemailPadre_pac.TabIndex = 24
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(5, 48)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(97, 20)
        Me.LabelX2.TabIndex = 26
        Me.LabelX2.Text = "E-Mail"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnNoEmail_Madre
        '
        Me.btnNoEmail_Madre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail_Madre.Image = CType(resources.GetObject("btnNoEmail_Madre.Image"), System.Drawing.Image)
        Me.btnNoEmail_Madre.Location = New System.Drawing.Point(457, 123)
        Me.btnNoEmail_Madre.Name = "btnNoEmail_Madre"
        Me.btnNoEmail_Madre.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail_Madre.TabIndex = 28
        '
        'txtemailMadre_pac
        '
        Me.txtemailMadre_pac.Location = New System.Drawing.Point(105, 123)
        Me.txtemailMadre_pac.Name = "txtemailMadre_pac"
        Me.txtemailMadre_pac.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemailMadre_pac.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemailMadre_pac.Properties.Mask.BeepOnError = True
        Me.txtemailMadre_pac.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemailMadre_pac.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemailMadre_pac.Properties.Mask.ShowPlaceHolders = False
        Me.txtemailMadre_pac.Size = New System.Drawing.Size(347, 20)
        Me.txtemailMadre_pac.TabIndex = 27
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(5, 123)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(97, 20)
        Me.LabelX3.TabIndex = 29
        Me.LabelX3.Text = "E-Mail"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnNoEmail_Conyuge
        '
        Me.btnNoEmail_Conyuge.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail_Conyuge.Image = CType(resources.GetObject("btnNoEmail_Conyuge.Image"), System.Drawing.Image)
        Me.btnNoEmail_Conyuge.Location = New System.Drawing.Point(457, 47)
        Me.btnNoEmail_Conyuge.Name = "btnNoEmail_Conyuge"
        Me.btnNoEmail_Conyuge.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail_Conyuge.TabIndex = 31
        '
        'txtemailConyuge_pac
        '
        Me.txtemailConyuge_pac.Location = New System.Drawing.Point(106, 47)
        Me.txtemailConyuge_pac.Name = "txtemailConyuge_pac"
        Me.txtemailConyuge_pac.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemailConyuge_pac.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemailConyuge_pac.Properties.Mask.BeepOnError = True
        Me.txtemailConyuge_pac.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemailConyuge_pac.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemailConyuge_pac.Properties.Mask.ShowPlaceHolders = False
        Me.txtemailConyuge_pac.Size = New System.Drawing.Size(347, 20)
        Me.txtemailConyuge_pac.TabIndex = 30
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX4.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(5, 47)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(97, 20)
        Me.LabelX4.TabIndex = 32
        Me.LabelX4.Text = "E-Mail"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnNoEmail_Acudiente
        '
        Me.btnNoEmail_Acudiente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail_Acudiente.Image = CType(resources.GetObject("btnNoEmail_Acudiente.Image"), System.Drawing.Image)
        Me.btnNoEmail_Acudiente.Location = New System.Drawing.Point(457, 199)
        Me.btnNoEmail_Acudiente.Name = "btnNoEmail_Acudiente"
        Me.btnNoEmail_Acudiente.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail_Acudiente.TabIndex = 31
        '
        'txtemailAcudiente_pac
        '
        Me.txtemailAcudiente_pac.Location = New System.Drawing.Point(106, 199)
        Me.txtemailAcudiente_pac.Name = "txtemailAcudiente_pac"
        Me.txtemailAcudiente_pac.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemailAcudiente_pac.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemailAcudiente_pac.Properties.Mask.BeepOnError = True
        Me.txtemailAcudiente_pac.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemailAcudiente_pac.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemailAcudiente_pac.Properties.Mask.ShowPlaceHolders = False
        Me.txtemailAcudiente_pac.Size = New System.Drawing.Size(347, 20)
        Me.txtemailAcudiente_pac.TabIndex = 30
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX5.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX5.ForeColor = System.Drawing.Color.Navy
        Me.LabelX5.Location = New System.Drawing.Point(5, 199)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(97, 20)
        Me.LabelX5.TabIndex = 32
        Me.LabelX5.Text = "E-Mail"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.TabControl_pac)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmPacientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.TabControl_pac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_pac.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.gpHC_NDoc.ResumeLayout(False)
        Me.gpHC_NDoc.PerformLayout()
        CType(Me.txtnumdoc_pac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnhclinica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEstado.ResumeLayout(False)
        Me.panelEstado.PerformLayout()
        Me.gPanel_Edad.ResumeLayout(False)
        Me.gPanel_Edad.PerformLayout()
        Me.gPanel_Sexo.ResumeLayout(False)
        Me.gPanel_Sexo.PerformLayout()
        CType(Me.pbFoto_pac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel1.ResumeLayout(False)
        Me.gpConyuge.ResumeLayout(False)
        Me.gpPadres.ResumeLayout(False)
        Me.gpContactos.ResumeLayout(False)
        CType(Me.txtemail_pac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel3.ResumeLayout(False)
        Me.gpNotas.ResumeLayout(False)
        Me.gpRegistroBiometrico.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.txtemailPadre_pac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemailMadre_pac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemailConyuge_pac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtemailAcudiente_pac.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl_pac As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabDPersonales_pac As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabNotas_pac As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tabContactos_pac As DevComponents.DotNetBar.TabItem
    Friend WithEvents RichTxtNotas_pac As System.Windows.Forms.RichTextBox
    Friend WithEvents gpConyuge As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOcuConyuge_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelConyuge_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelConyuge_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtConyuge_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpPadres As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOcuAcudiente_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX34 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelAcudiente_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX35 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelAcudiente_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAcudiente_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOcuMadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtOcuPadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelMadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelPadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelMadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelPadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPadre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpContactos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelular_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFax_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelOficina_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelCasa_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbEntidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIdpaciente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblnhclinica As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblIdpaciente As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblEntidad As DevComponents.DotNetBar.LabelX
    Friend WithEvents gPanel_Edad As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblNumaños As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbtAños_pac As System.Windows.Forms.RadioButton
    Friend WithEvents rbtmeses_pac As System.Windows.Forms.RadioButton
    Friend WithEvents lblnumdoc_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtocupacion_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbltipodoc_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecnac_pac As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbfecingreso_pac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfecnac_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtreferido_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtoficina_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnombres_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtapellidos_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblfecingreso_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbloficina_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblocupacion_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblresidencia_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblnombres_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblreferido_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblapellidos_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents pbFoto_pac As System.Windows.Forms.PictureBox
    Friend WithEvents panelEstado As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents rbtEstado_Retirado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEstado_Retencion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEstado_Bloqueado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEstado_Entratamiento As System.Windows.Forms.RadioButton
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents gPanel_Sexo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtFemenino_pac As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMasculino_pac As System.Windows.Forms.RadioButton
    Friend WithEvents txtemail_pac As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtweb_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TimerPac As System.Windows.Forms.Timer
    Friend WithEvents btnEstudiosPac As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPacOdontograma As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNoEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBorrarFoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtdedoc_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbldedoc_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnFotoA As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnFoto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbOperadorCel As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents btnEstadoCuenta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtnumdoc_pac As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtnhclinica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gpHC_NDoc As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbNoHC_NDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rbSiHC_NDoc As System.Windows.Forms.RadioButton
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblestadocivil_pac As DevComponents.DotNetBar.LabelX
    Public WithEvents txtresidencia_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbestadocivil_pac As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cmbtipodoc_pac As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents gpRegistroBiometrico As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblRegistroBiometrico As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRegistroBiometrico As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpNotas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lbllugarnac_pac As DevComponents.DotNetBar.LabelX
    Public WithEvents txtlugarnac_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Public WithEvents txtdep_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbldep_pac As DevComponents.DotNetBar.LabelX
    Public WithEvents txtmunicipio_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblmunicipio_pac As DevComponents.DotNetBar.LabelX
    Public WithEvents txtrh_Pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblrh_Pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbzona_pac As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblzona_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents btnNoEmail_Conyuge As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtemailConyuge_pac As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNoEmail_Acudiente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtemailAcudiente_pac As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNoEmail_Madre As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtemailMadre_pac As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNoEmail_Padre As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtemailPadre_pac As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
