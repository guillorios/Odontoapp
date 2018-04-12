<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.gpDatos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtdireccion_prov = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtcontacto_prov = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtnombre_prov = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.gpContactos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnNoEmail = New DevComponents.DotNetBar.ButtonX
        Me.txtemail_prov = New DevExpress.XtraEditors.TextEdit
        Me.txtweb_prov = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.txtcelular_prov = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtfax_prov = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.txtteloficina_prov = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.txtIdproveedor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblIdproveedor = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpDatos.SuspendLayout()
        Me.gpContactos.SuspendLayout()
        CType(Me.txtemail_prov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.gpDatos)
        Me.RibbonClientPanel1.Controls.Add(Me.gpContactos)
        Me.RibbonClientPanel1.Controls.Add(Me.txtIdproveedor)
        Me.RibbonClientPanel1.Controls.Add(Me.lblIdproveedor)
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
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(296, 436)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 39)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(17, 435)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(86, 39)
        Me.btnAdicionar.TabIndex = 5
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(109, 435)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(89, 39)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(204, 436)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 39)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(425, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "SALIR"
        '
        'gpDatos
        '
        Me.gpDatos.BackColor = System.Drawing.Color.Transparent
        Me.gpDatos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatos.Controls.Add(Me.LabelX3)
        Me.gpDatos.Controls.Add(Me.LabelX1)
        Me.gpDatos.Controls.Add(Me.LabelX2)
        Me.gpDatos.Controls.Add(Me.txtdireccion_prov)
        Me.gpDatos.Controls.Add(Me.txtcontacto_prov)
        Me.gpDatos.Controls.Add(Me.txtnombre_prov)
        Me.gpDatos.Location = New System.Drawing.Point(20, 87)
        Me.gpDatos.Name = "gpDatos"
        Me.gpDatos.Size = New System.Drawing.Size(491, 117)
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
        Me.gpDatos.TabIndex = 3
        Me.gpDatos.Text = "Datos"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(9, 34)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(104, 20)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Direccion"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(9, 8)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(104, 20)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Nombre"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(9, 61)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(104, 20)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "Contacto"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtdireccion_prov
        '
        '
        '
        '
        Me.txtdireccion_prov.Border.Class = "TextBoxBorder"
        Me.txtdireccion_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion_prov.Location = New System.Drawing.Point(122, 34)
        Me.txtdireccion_prov.Name = "txtdireccion_prov"
        Me.txtdireccion_prov.Size = New System.Drawing.Size(347, 20)
        Me.txtdireccion_prov.TabIndex = 3
        Me.txtdireccion_prov.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtcontacto_prov
        '
        '
        '
        '
        Me.txtcontacto_prov.Border.Class = "TextBoxBorder"
        Me.txtcontacto_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontacto_prov.Location = New System.Drawing.Point(122, 61)
        Me.txtcontacto_prov.Name = "txtcontacto_prov"
        Me.txtcontacto_prov.Size = New System.Drawing.Size(347, 20)
        Me.txtcontacto_prov.TabIndex = 5
        Me.txtcontacto_prov.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtnombre_prov
        '
        '
        '
        '
        Me.txtnombre_prov.Border.Class = "TextBoxBorder"
        Me.txtnombre_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre_prov.Location = New System.Drawing.Point(122, 8)
        Me.txtnombre_prov.Name = "txtnombre_prov"
        Me.txtnombre_prov.Size = New System.Drawing.Size(347, 20)
        Me.txtnombre_prov.TabIndex = 1
        Me.txtnombre_prov.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'gpContactos
        '
        Me.gpContactos.BackColor = System.Drawing.Color.Transparent
        Me.gpContactos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpContactos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpContactos.Controls.Add(Me.btnNoEmail)
        Me.gpContactos.Controls.Add(Me.txtemail_prov)
        Me.gpContactos.Controls.Add(Me.txtweb_prov)
        Me.gpContactos.Controls.Add(Me.LabelX26)
        Me.gpContactos.Controls.Add(Me.LabelX21)
        Me.gpContactos.Controls.Add(Me.txtcelular_prov)
        Me.gpContactos.Controls.Add(Me.txtfax_prov)
        Me.gpContactos.Controls.Add(Me.LabelX18)
        Me.gpContactos.Controls.Add(Me.LabelX16)
        Me.gpContactos.Controls.Add(Me.txtteloficina_prov)
        Me.gpContactos.Controls.Add(Me.LabelX15)
        Me.gpContactos.Location = New System.Drawing.Point(20, 226)
        Me.gpContactos.Name = "gpContactos"
        Me.gpContactos.Size = New System.Drawing.Size(491, 145)
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
        Me.gpContactos.TabIndex = 4
        Me.gpContactos.Text = "Contactos"
        '
        'btnNoEmail
        '
        Me.btnNoEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNoEmail.Image = CType(resources.GetObject("btnNoEmail.Image"), System.Drawing.Image)
        Me.btnNoEmail.Location = New System.Drawing.Point(447, 64)
        Me.btnNoEmail.Name = "btnNoEmail"
        Me.btnNoEmail.Size = New System.Drawing.Size(21, 20)
        Me.btnNoEmail.TabIndex = 8
        '
        'txtemail_prov
        '
        Me.txtemail_prov.Location = New System.Drawing.Point(110, 64)
        Me.txtemail_prov.Name = "txtemail_prov"
        Me.txtemail_prov.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtemail_prov.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtemail_prov.Properties.Mask.BeepOnError = True
        Me.txtemail_prov.Properties.Mask.EditMask = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Me.txtemail_prov.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtemail_prov.Properties.Mask.ShowPlaceHolders = False
        Me.txtemail_prov.Size = New System.Drawing.Size(331, 20)
        Me.txtemail_prov.TabIndex = 7
        '
        'txtweb_prov
        '
        '
        '
        '
        Me.txtweb_prov.Border.Class = "TextBoxBorder"
        Me.txtweb_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtweb_prov.Location = New System.Drawing.Point(110, 90)
        Me.txtweb_prov.Name = "txtweb_prov"
        Me.txtweb_prov.Size = New System.Drawing.Size(359, 21)
        Me.txtweb_prov.TabIndex = 10
        '
        'LabelX26
        '
        Me.LabelX26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX26.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX26.ForeColor = System.Drawing.Color.Navy
        Me.LabelX26.Location = New System.Drawing.Point(9, 90)
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
        Me.LabelX21.Location = New System.Drawing.Point(250, 12)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(59, 20)
        Me.LabelX21.TabIndex = 2
        Me.LabelX21.Text = "Celular"
        Me.LabelX21.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtcelular_prov
        '
        '
        '
        '
        Me.txtcelular_prov.Border.Class = "TextBoxBorder"
        Me.txtcelular_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcelular_prov.Location = New System.Drawing.Point(315, 12)
        Me.txtcelular_prov.Name = "txtcelular_prov"
        Me.txtcelular_prov.Size = New System.Drawing.Size(154, 20)
        Me.txtcelular_prov.TabIndex = 3
        Me.txtcelular_prov.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'txtfax_prov
        '
        '
        '
        '
        Me.txtfax_prov.Border.Class = "TextBoxBorder"
        Me.txtfax_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfax_prov.Location = New System.Drawing.Point(110, 38)
        Me.txtfax_prov.Name = "txtfax_prov"
        Me.txtfax_prov.Size = New System.Drawing.Size(134, 20)
        Me.txtfax_prov.TabIndex = 5
        '
        'LabelX18
        '
        Me.LabelX18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX18.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX18.ForeColor = System.Drawing.Color.Navy
        Me.LabelX18.Location = New System.Drawing.Point(9, 38)
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
        Me.LabelX16.Location = New System.Drawing.Point(9, 12)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(95, 20)
        Me.LabelX16.TabIndex = 0
        Me.LabelX16.Text = "Telefono Oficina"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtteloficina_prov
        '
        '
        '
        '
        Me.txtteloficina_prov.Border.Class = "TextBoxBorder"
        Me.txtteloficina_prov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtteloficina_prov.Location = New System.Drawing.Point(110, 12)
        Me.txtteloficina_prov.Name = "txtteloficina_prov"
        Me.txtteloficina_prov.Size = New System.Drawing.Size(134, 20)
        Me.txtteloficina_prov.TabIndex = 1
        Me.txtteloficina_prov.WatermarkText = "CAMPO OBLIGATORIO"
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX15.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX15.ForeColor = System.Drawing.Color.Navy
        Me.LabelX15.Location = New System.Drawing.Point(9, 64)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(95, 20)
        Me.LabelX15.TabIndex = 6
        Me.LabelX15.Text = "E-Mail"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdproveedor
        '
        Me.txtIdproveedor.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtIdproveedor.Border.Class = "TextBoxBorder"
        Me.txtIdproveedor.ForeColor = System.Drawing.Color.Black
        Me.txtIdproveedor.Location = New System.Drawing.Point(435, 48)
        Me.txtIdproveedor.Name = "txtIdproveedor"
        Me.txtIdproveedor.ReadOnly = True
        Me.txtIdproveedor.Size = New System.Drawing.Size(80, 20)
        Me.txtIdproveedor.TabIndex = 2
        Me.txtIdproveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIdproveedor
        '
        Me.lblIdproveedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIdproveedor.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblIdproveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblIdproveedor.Location = New System.Drawing.Point(338, 48)
        Me.lblIdproveedor.Name = "lblIdproveedor"
        Me.lblIdproveedor.Size = New System.Drawing.Size(91, 20)
        Me.lblIdproveedor.TabIndex = 1
        Me.lblIdproveedor.Text = "Código Interno"
        Me.lblIdproveedor.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(24, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(491, 23)
        Me.lblTituloVentana.TabIndex = 0
        Me.lblTituloVentana.Text = "PROVEEDORES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Proveedores"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpDatos.ResumeLayout(False)
        Me.gpContactos.ResumeLayout(False)
        CType(Me.txtemail_prov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdproveedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblIdproveedor As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcontacto_prov As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdireccion_prov As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtnombre_prov As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpDatos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gpContactos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnNoEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtemail_prov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtweb_prov As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcelular_prov As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtfax_prov As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtteloficina_prov As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
