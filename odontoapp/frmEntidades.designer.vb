<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntidades))
        Me.TabControl_Ent = New DevComponents.DotNetBar.TabControl
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.gpContactos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnNoEmail = New DevComponents.DotNetBar.ButtonX
        Me.txtemail_ent = New DevExpress.XtraEditors.TextEdit
        Me.txtweb_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.txtCelular_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtFax_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.txtTelOficina_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.gpDatos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.txtcodigo_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtIdentidad = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.txtnombre_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtcontacto_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtdireccion_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.tabDPersonales_ent = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel3 = New DevComponents.DotNetBar.TabControlPanel
        Me.RichTxtNotas_ent = New System.Windows.Forms.RichTextBox
        Me.tabNotas_ent = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        CType(Me.TabControl_Ent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl_Ent.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        Me.gpContactos.SuspendLayout()
        CType(Me.txtemail_ent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpDatos.SuspendLayout()
        Me.TabControlPanel3.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl_Ent
        '
        Me.TabControl_Ent.CanReorderTabs = True
        Me.TabControl_Ent.Controls.Add(Me.TabControlPanel2)
        Me.TabControl_Ent.Controls.Add(Me.TabControlPanel3)
        Me.TabControl_Ent.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl_Ent.Location = New System.Drawing.Point(0, 0)
        Me.TabControl_Ent.Name = "TabControl_Ent"
        Me.TabControl_Ent.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl_Ent.SelectedTabIndex = 0
        Me.TabControl_Ent.Size = New System.Drawing.Size(532, 432)
        Me.TabControl_Ent.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Dock
        Me.TabControl_Ent.TabIndex = 0
        Me.TabControl_Ent.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineWithNavigationBox
        Me.TabControl_Ent.Tabs.Add(Me.tabDPersonales_ent)
        Me.TabControl_Ent.Tabs.Add(Me.tabNotas_ent)
        Me.TabControl_Ent.Text = "Datos Personales"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.gpContactos)
        Me.TabControlPanel2.Controls.Add(Me.gpDatos)
        Me.TabControlPanel2.Controls.Add(Me.lblTituloVentana)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 410)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 0
        Me.TabControlPanel2.TabItem = Me.tabDPersonales_ent
        '
        'gpContactos
        '
        Me.gpContactos.BackColor = System.Drawing.Color.Transparent
        Me.gpContactos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpContactos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpContactos.Controls.Add(Me.btnNoEmail)
        Me.gpContactos.Controls.Add(Me.txtemail_ent)
        Me.gpContactos.Controls.Add(Me.txtweb_ent)
        Me.gpContactos.Controls.Add(Me.LabelX26)
        Me.gpContactos.Controls.Add(Me.LabelX21)
        Me.gpContactos.Controls.Add(Me.txtCelular_ent)
        Me.gpContactos.Controls.Add(Me.txtFax_ent)
        Me.gpContactos.Controls.Add(Me.LabelX18)
        Me.gpContactos.Controls.Add(Me.LabelX16)
        Me.gpContactos.Controls.Add(Me.txtTelOficina_ent)
        Me.gpContactos.Controls.Add(Me.LabelX15)
        Me.gpContactos.Location = New System.Drawing.Point(29, 246)
        Me.gpContactos.Name = "gpContactos"
        Me.gpContactos.Size = New System.Drawing.Size(479, 142)
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
        Me.gpContactos.TabIndex = 2
        Me.gpContactos.Text = "Contactos"
        '
        'btnNoEmail
        '
        Me.btnNoEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail.Image = CType(resources.GetObject("btnNoEmail.Image"), System.Drawing.Image)
        Me.btnNoEmail.Location = New System.Drawing.Point(446, 64)
        Me.btnNoEmail.Name = "btnNoEmail"
        Me.btnNoEmail.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail.TabIndex = 8
        '
        'txtemail_ent
        '
        Me.txtemail_ent.Location = New System.Drawing.Point(106, 64)
        Me.txtemail_ent.Name = "txtemail_ent"
        Me.txtemail_ent.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemail_ent.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemail_ent.Properties.Mask.BeepOnError = True
        Me.txtemail_ent.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemail_ent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemail_ent.Properties.Mask.ShowPlaceHolders = False
        Me.txtemail_ent.Size = New System.Drawing.Size(334, 20)
        Me.txtemail_ent.TabIndex = 7
        '
        'txtweb_ent
        '
        '
        '
        '
        Me.txtweb_ent.Border.Class = "TextBoxBorder"
        Me.txtweb_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtweb_ent.Location = New System.Drawing.Point(106, 90)
        Me.txtweb_ent.Name = "txtweb_ent"
        Me.txtweb_ent.Size = New System.Drawing.Size(361, 21)
        Me.txtweb_ent.TabIndex = 10
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
        Me.LabelX21.Location = New System.Drawing.Point(259, 12)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(51, 20)
        Me.LabelX21.TabIndex = 2
        Me.LabelX21.Text = "Celular"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCelular_ent
        '
        '
        '
        '
        Me.txtCelular_ent.Border.Class = "TextBoxBorder"
        Me.txtCelular_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular_ent.Location = New System.Drawing.Point(315, 12)
        Me.txtCelular_ent.Name = "txtCelular_ent"
        Me.txtCelular_ent.Size = New System.Drawing.Size(131, 20)
        Me.txtCelular_ent.TabIndex = 3
        Me.txtCelular_ent.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtFax_ent
        '
        '
        '
        '
        Me.txtFax_ent.Border.Class = "TextBoxBorder"
        Me.txtFax_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax_ent.Location = New System.Drawing.Point(106, 38)
        Me.txtFax_ent.Name = "txtFax_ent"
        Me.txtFax_ent.Size = New System.Drawing.Size(147, 20)
        Me.txtFax_ent.TabIndex = 5
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
        Me.LabelX16.Text = "Telefono Oficina"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTelOficina_ent
        '
        '
        '
        '
        Me.txtTelOficina_ent.Border.Class = "TextBoxBorder"
        Me.txtTelOficina_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelOficina_ent.Location = New System.Drawing.Point(106, 12)
        Me.txtTelOficina_ent.Name = "txtTelOficina_ent"
        Me.txtTelOficina_ent.Size = New System.Drawing.Size(147, 20)
        Me.txtTelOficina_ent.TabIndex = 1
        Me.txtTelOficina_ent.WatermarkText = "CAMPO OBLIGATORIO"
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
        'gpDatos
        '
        Me.gpDatos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatos.Controls.Add(Me.LabelX4)
        Me.gpDatos.Controls.Add(Me.txtcodigo_ent)
        Me.gpDatos.Controls.Add(Me.LabelX2)
        Me.gpDatos.Controls.Add(Me.LabelX1)
        Me.gpDatos.Controls.Add(Me.txtIdentidad)
        Me.gpDatos.Controls.Add(Me.LabelX13)
        Me.gpDatos.Controls.Add(Me.LabelX3)
        Me.gpDatos.Controls.Add(Me.txtnombre_ent)
        Me.gpDatos.Controls.Add(Me.txtcontacto_ent)
        Me.gpDatos.Controls.Add(Me.txtdireccion_ent)
        Me.gpDatos.Location = New System.Drawing.Point(29, 67)
        Me.gpDatos.Name = "gpDatos"
        Me.gpDatos.Size = New System.Drawing.Size(479, 173)
        '
        '
        '
        Me.gpDatos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatos.Style.BackColorGradientAngle = 90
        Me.gpDatos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderBottomWidth = 1
        Me.gpDatos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderLeftWidth = 1
        Me.gpDatos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderRightWidth = 1
        Me.gpDatos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderTopWidth = 1
        Me.gpDatos.Style.CornerDiameter = 4
        Me.gpDatos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpDatos.TabIndex = 1
        Me.gpDatos.Text = "Datos "
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX4.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(15, 121)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(121, 20)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Código EPS, ARS, ESS"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtcodigo_ent
        '
        '
        '
        '
        Me.txtcodigo_ent.Border.Class = "TextBoxBorder"
        Me.txtcodigo_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo_ent.Location = New System.Drawing.Point(142, 121)
        Me.txtcodigo_ent.Name = "txtcodigo_ent"
        Me.txtcodigo_ent.Size = New System.Drawing.Size(309, 20)
        Me.txtcodigo_ent.TabIndex = 9
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(15, 95)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(121, 20)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Nombre Contacto"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(15, 43)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(121, 20)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Nombre Entidad"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdentidad
        '
        Me.txtIdentidad.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdentidad.Border.Class = "TextBoxBorder"
        Me.txtIdentidad.ForeColor = System.Drawing.Color.Black
        Me.txtIdentidad.Location = New System.Drawing.Point(371, 8)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.ReadOnly = True
        Me.txtIdentidad.Size = New System.Drawing.Size(80, 20)
        Me.txtIdentidad.TabIndex = 1
        Me.txtIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX13.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX13.ForeColor = System.Drawing.Color.Navy
        Me.LabelX13.Location = New System.Drawing.Point(258, 8)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(91, 20)
        Me.LabelX13.TabIndex = 0
        Me.LabelX13.Text = "Código Interno"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(15, 69)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(121, 20)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Direccion"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtnombre_ent
        '
        '
        '
        '
        Me.txtnombre_ent.Border.Class = "TextBoxBorder"
        Me.txtnombre_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre_ent.Location = New System.Drawing.Point(142, 43)
        Me.txtnombre_ent.Name = "txtnombre_ent"
        Me.txtnombre_ent.Size = New System.Drawing.Size(309, 20)
        Me.txtnombre_ent.TabIndex = 3
        Me.txtnombre_ent.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtcontacto_ent
        '
        '
        '
        '
        Me.txtcontacto_ent.Border.Class = "TextBoxBorder"
        Me.txtcontacto_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontacto_ent.Location = New System.Drawing.Point(142, 95)
        Me.txtcontacto_ent.Name = "txtcontacto_ent"
        Me.txtcontacto_ent.Size = New System.Drawing.Size(309, 20)
        Me.txtcontacto_ent.TabIndex = 7
        Me.txtcontacto_ent.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtdireccion_ent
        '
        '
        '
        '
        Me.txtdireccion_ent.Border.Class = "TextBoxBorder"
        Me.txtdireccion_ent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion_ent.Location = New System.Drawing.Point(142, 69)
        Me.txtdireccion_ent.Name = "txtdireccion_ent"
        Me.txtdireccion_ent.Size = New System.Drawing.Size(309, 20)
        Me.txtdireccion_ent.TabIndex = 5
        Me.txtdireccion_ent.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(29, 20)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(479, 23)
        Me.lblTituloVentana.TabIndex = 0
        Me.lblTituloVentana.Text = "ENTIDADES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'tabDPersonales_ent
        '
        Me.tabDPersonales_ent.AttachedControl = Me.TabControlPanel2
        Me.tabDPersonales_ent.Name = "tabDPersonales_ent"
        Me.tabDPersonales_ent.Text = "Datos Personales"
        '
        'TabControlPanel3
        '
        Me.TabControlPanel3.Controls.Add(Me.RichTxtNotas_ent)
        Me.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel3.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel3.Name = "TabControlPanel3"
        Me.TabControlPanel3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel3.Size = New System.Drawing.Size(532, 410)
        Me.TabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel3.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel3.Style.GradientAngle = 90
        Me.TabControlPanel3.TabIndex = 1
        Me.TabControlPanel3.TabItem = Me.tabNotas_ent
        '
        'RichTxtNotas_ent
        '
        Me.RichTxtNotas_ent.Location = New System.Drawing.Point(45, 26)
        Me.RichTxtNotas_ent.Name = "RichTxtNotas_ent"
        Me.RichTxtNotas_ent.Size = New System.Drawing.Size(438, 363)
        Me.RichTxtNotas_ent.TabIndex = 0
        Me.RichTxtNotas_ent.Text = ""
        '
        'tabNotas_ent
        '
        Me.tabNotas_ent.AttachedControl = Me.TabControlPanel3
        Me.tabNotas_ent.Name = "tabNotas_ent"
        Me.tabNotas_ent.Text = "Notas"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(291, 439)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 39)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(104, 438)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(89, 39)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(420, 438)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(199, 439)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 39)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(12, 438)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(86, 39)
        Me.btnAdicionar.TabIndex = 0
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
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
        'frmEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.TabControl_Ent)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmEntidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Entidades"
        CType(Me.TabControl_Ent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl_Ent.ResumeLayout(False)
        Me.TabControlPanel2.ResumeLayout(False)
        Me.gpContactos.ResumeLayout(False)
        CType(Me.txtemail_ent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpDatos.ResumeLayout(False)
        Me.TabControlPanel3.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl_Ent As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel3 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents RichTxtNotas_ent As System.Windows.Forms.RichTextBox
    Friend WithEvents tabNotas_ent As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdentidad As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcontacto_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdireccion_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnombre_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tabDPersonales_ent As DevComponents.DotNetBar.TabItem
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpDatos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gpContactos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnNoEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtemail_ent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtweb_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCelular_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFax_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTelOficina_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcodigo_ent As DevComponents.DotNetBar.Controls.TextBoxX
End Class
