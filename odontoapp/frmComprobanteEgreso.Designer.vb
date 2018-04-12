<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobanteEgreso
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComprobanteEgreso))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblAnulada = New DevComponents.DotNetBar.LabelX
        Me.dgCE = New System.Windows.Forms.DataGridView
        Me.btnAnular = New DevComponents.DotNetBar.ButtonX
        Me.txtciudad_ce = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblciudad_ce = New DevComponents.DotNetBar.LabelX
        Me.txtconcepto_ce = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblconcepto_ce = New DevComponents.DotNetBar.LabelX
        Me.cmbProveedores = New System.Windows.Forms.ComboBox
        Me.lblIdproveedor = New DevComponents.DotNetBar.LabelX
        Me.txtIdproveedor = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtdebitesea_ce = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lbldebitesea_ce = New DevComponents.DotNetBar.LabelX
        Me.txtobservaciones_ce = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblobservaciones_ce = New DevComponents.DotNetBar.LabelX
        Me.lblRecibimosde = New DevComponents.DotNetBar.LabelX
        Me.txttotal_ce = New DevExpress.XtraEditors.TextEdit
        Me.lbltotal_ce = New DevComponents.DotNetBar.LabelX
        Me.gpItems = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.txtobservacion_gas = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtvalor_gas = New DevExpress.XtraEditors.TextEdit
        Me.btnIngresar_Item = New DevComponents.DotNetBar.ButtonX
        Me.cmbItemGastos = New System.Windows.Forms.ComboBox
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtIdgasto = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.btnBorrarItem = New DevComponents.DotNetBar.ButtonX
        Me.gpfechaCE = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbfecha_ce = New System.Windows.Forms.DateTimePicker
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.rcBuscarCEgreso = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.btnCEBuscar = New DevComponents.DotNetBar.ButtonX
        Me.txtIdce_Bus = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.gpPagoBanco = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtbanco_ce = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.txtcheque_ce = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.gpIdce = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.txtIdce = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.dgCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttotal_ce.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpItems.SuspendLayout()
        CType(Me.txtvalor_gas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpfechaCE.SuspendLayout()
        Me.rcBuscarCEgreso.SuspendLayout()
        Me.gpPagoBanco.SuspendLayout()
        Me.gpIdce.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.lblAnulada)
        Me.RibbonClientPanel1.Controls.Add(Me.dgCE)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAnular)
        Me.RibbonClientPanel1.Controls.Add(Me.txtciudad_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.lblciudad_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.txtconcepto_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.lblconcepto_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbProveedores)
        Me.RibbonClientPanel1.Controls.Add(Me.lblIdproveedor)
        Me.RibbonClientPanel1.Controls.Add(Me.txtIdproveedor)
        Me.RibbonClientPanel1.Controls.Add(Me.txtdebitesea_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.lbldebitesea_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.txtobservaciones_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.lblobservaciones_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.lblRecibimosde)
        Me.RibbonClientPanel1.Controls.Add(Me.txttotal_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.lbltotal_ce)
        Me.RibbonClientPanel1.Controls.Add(Me.gpItems)
        Me.RibbonClientPanel1.Controls.Add(Me.gpfechaCE)
        Me.RibbonClientPanel1.Controls.Add(Me.rcBuscarCEgreso)
        Me.RibbonClientPanel1.Controls.Add(Me.btnImprimir)
        Me.RibbonClientPanel1.Controls.Add(Me.gpPagoBanco)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.gpIdce)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(532, 486)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 2
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'lblAnulada
        '
        Me.lblAnulada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAnulada.Location = New System.Drawing.Point(27, 335)
        Me.lblAnulada.Name = "lblAnulada"
        Me.lblAnulada.SingleLineColor = System.Drawing.Color.Gold
        Me.lblAnulada.Size = New System.Drawing.Size(484, 35)
        Me.lblAnulada.TabIndex = 183
        Me.lblAnulada.Text = "COMPROBANTE DE EGRESO ANULADO"
        Me.lblAnulada.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblAnulada.Visible = False
        '
        'dgCE
        '
        Me.dgCE.AllowUserToAddRows = False
        Me.dgCE.AllowUserToOrderColumns = True
        Me.dgCE.AllowUserToResizeColumns = False
        Me.dgCE.AllowUserToResizeRows = False
        Me.dgCE.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgCE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCE.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCE.EnableHeadersVisualStyles = False
        Me.dgCE.Location = New System.Drawing.Point(26, 245)
        Me.dgCE.Name = "dgCE"
        Me.dgCE.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCE.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgCE.RowHeadersVisible = False
        Me.dgCE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCE.Size = New System.Drawing.Size(486, 126)
        Me.dgCE.TabIndex = 192
        '
        'btnAnular
        '
        Me.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnular.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.Location = New System.Drawing.Point(220, 436)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(96, 39)
        Me.btnAnular.TabIndex = 191
        Me.btnAnular.Text = "ANULAR"
        '
        'txtciudad_ce
        '
        '
        '
        '
        Me.txtciudad_ce.Border.Class = "TextBoxBorder"
        Me.txtciudad_ce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtciudad_ce.Location = New System.Drawing.Point(404, 150)
        Me.txtciudad_ce.Name = "txtciudad_ce"
        Me.txtciudad_ce.Size = New System.Drawing.Size(107, 20)
        Me.txtciudad_ce.TabIndex = 190
        '
        'lblciudad_ce
        '
        Me.lblciudad_ce.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblciudad_ce.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblciudad_ce.ForeColor = System.Drawing.Color.Navy
        Me.lblciudad_ce.Location = New System.Drawing.Point(354, 150)
        Me.lblciudad_ce.Name = "lblciudad_ce"
        Me.lblciudad_ce.Size = New System.Drawing.Size(44, 20)
        Me.lblciudad_ce.TabIndex = 189
        Me.lblciudad_ce.Text = "Ciudad"
        Me.lblciudad_ce.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtconcepto_ce
        '
        '
        '
        '
        Me.txtconcepto_ce.Border.Class = "TextBoxBorder"
        Me.txtconcepto_ce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconcepto_ce.Location = New System.Drawing.Point(137, 150)
        Me.txtconcepto_ce.Name = "txtconcepto_ce"
        Me.txtconcepto_ce.Size = New System.Drawing.Size(212, 20)
        Me.txtconcepto_ce.TabIndex = 188
        '
        'lblconcepto_ce
        '
        Me.lblconcepto_ce.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblconcepto_ce.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblconcepto_ce.ForeColor = System.Drawing.Color.Navy
        Me.lblconcepto_ce.Location = New System.Drawing.Point(27, 150)
        Me.lblconcepto_ce.Name = "lblconcepto_ce"
        Me.lblconcepto_ce.Size = New System.Drawing.Size(103, 20)
        Me.lblconcepto_ce.TabIndex = 187
        Me.lblconcepto_ce.Text = "Concepto :"
        Me.lblconcepto_ce.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbProveedores
        '
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(249, 127)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(260, 21)
        Me.cmbProveedores.TabIndex = 175
        Me.cmbProveedores.Text = "ESCOJA EL PROVEEDOR"
        '
        'lblIdproveedor
        '
        Me.lblIdproveedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIdproveedor.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblIdproveedor.ForeColor = System.Drawing.Color.Navy
        Me.lblIdproveedor.Location = New System.Drawing.Point(137, 127)
        Me.lblIdproveedor.Name = "lblIdproveedor"
        Me.lblIdproveedor.Size = New System.Drawing.Size(44, 20)
        Me.lblIdproveedor.TabIndex = 176
        Me.lblIdproveedor.Text = "Codigo"
        Me.lblIdproveedor.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdproveedor
        '
        '
        '
        '
        Me.txtIdproveedor.Border.Class = "TextBoxBorder"
        Me.txtIdproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdproveedor.Location = New System.Drawing.Point(184, 127)
        Me.txtIdproveedor.Name = "txtIdproveedor"
        Me.txtIdproveedor.ReadOnly = True
        Me.txtIdproveedor.Size = New System.Drawing.Size(61, 20)
        Me.txtIdproveedor.TabIndex = 175
        '
        'txtdebitesea_ce
        '
        '
        '
        '
        Me.txtdebitesea_ce.Border.Class = "TextBoxBorder"
        Me.txtdebitesea_ce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdebitesea_ce.Location = New System.Drawing.Point(351, 377)
        Me.txtdebitesea_ce.Name = "txtdebitesea_ce"
        Me.txtdebitesea_ce.Size = New System.Drawing.Size(161, 20)
        Me.txtdebitesea_ce.TabIndex = 186
        '
        'lbldebitesea_ce
        '
        Me.lbldebitesea_ce.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbldebitesea_ce.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbldebitesea_ce.ForeColor = System.Drawing.Color.Navy
        Me.lbldebitesea_ce.Location = New System.Drawing.Point(264, 376)
        Me.lbldebitesea_ce.Name = "lbldebitesea_ce"
        Me.lbldebitesea_ce.Size = New System.Drawing.Size(84, 20)
        Me.lbldebitesea_ce.TabIndex = 185
        Me.lbldebitesea_ce.Text = "Debitese a:"
        Me.lbldebitesea_ce.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtobservaciones_ce
        '
        '
        '
        '
        Me.txtobservaciones_ce.Border.Class = "TextBoxBorder"
        Me.txtobservaciones_ce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservaciones_ce.Location = New System.Drawing.Point(113, 375)
        Me.txtobservaciones_ce.Name = "txtobservaciones_ce"
        Me.txtobservaciones_ce.Size = New System.Drawing.Size(148, 20)
        Me.txtobservaciones_ce.TabIndex = 182
        '
        'lblobservaciones_ce
        '
        Me.lblobservaciones_ce.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblobservaciones_ce.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblobservaciones_ce.ForeColor = System.Drawing.Color.Navy
        Me.lblobservaciones_ce.Location = New System.Drawing.Point(27, 375)
        Me.lblobservaciones_ce.Name = "lblobservaciones_ce"
        Me.lblobservaciones_ce.Size = New System.Drawing.Size(84, 20)
        Me.lblobservaciones_ce.TabIndex = 181
        Me.lblobservaciones_ce.Text = "Observaciones"
        Me.lblobservaciones_ce.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblRecibimosde
        '
        Me.lblRecibimosde.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblRecibimosde.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblRecibimosde.ForeColor = System.Drawing.Color.Navy
        Me.lblRecibimosde.Location = New System.Drawing.Point(27, 127)
        Me.lblRecibimosde.Name = "lblRecibimosde"
        Me.lblRecibimosde.Size = New System.Drawing.Size(103, 20)
        Me.lblRecibimosde.TabIndex = 155
        Me.lblRecibimosde.Text = "Pagado a :"
        Me.lblRecibimosde.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txttotal_ce
        '
        Me.txttotal_ce.EditValue = "0"
        Me.txttotal_ce.Location = New System.Drawing.Point(366, 89)
        Me.txttotal_ce.Name = "txttotal_ce"
        Me.txttotal_ce.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txttotal_ce.Properties.Appearance.Options.UseFont = True
        Me.txttotal_ce.Properties.Appearance.Options.UseTextOptions = True
        Me.txttotal_ce.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txttotal_ce.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txttotal_ce.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txttotal_ce.Properties.Mask.BeepOnError = True
        Me.txttotal_ce.Properties.Mask.EditMask = "c0"
        Me.txttotal_ce.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttotal_ce.Properties.Mask.ShowPlaceHolders = False
        Me.txttotal_ce.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttotal_ce.Properties.ReadOnly = True
        Me.txttotal_ce.Size = New System.Drawing.Size(141, 21)
        Me.txttotal_ce.TabIndex = 153
        '
        'lbltotal_ce
        '
        Me.lbltotal_ce.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbltotal_ce.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lbltotal_ce.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal_ce.ForeColor = System.Drawing.Color.Navy
        Me.lbltotal_ce.Location = New System.Drawing.Point(239, 90)
        Me.lbltotal_ce.Name = "lbltotal_ce"
        Me.lbltotal_ce.Size = New System.Drawing.Size(121, 20)
        Me.lbltotal_ce.TabIndex = 152
        Me.lbltotal_ce.Text = "Valor Comprobante"
        Me.lbltotal_ce.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpItems
        '
        Me.gpItems.BackColor = System.Drawing.Color.Transparent
        Me.gpItems.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpItems.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpItems.Controls.Add(Me.LabelX16)
        Me.gpItems.Controls.Add(Me.txtobservacion_gas)
        Me.gpItems.Controls.Add(Me.txtvalor_gas)
        Me.gpItems.Controls.Add(Me.btnIngresar_Item)
        Me.gpItems.Controls.Add(Me.cmbItemGastos)
        Me.gpItems.Controls.Add(Me.LabelX1)
        Me.gpItems.Controls.Add(Me.txtIdgasto)
        Me.gpItems.Controls.Add(Me.LabelX2)
        Me.gpItems.Controls.Add(Me.LabelX13)
        Me.gpItems.Controls.Add(Me.btnBorrarItem)
        Me.gpItems.Location = New System.Drawing.Point(27, 172)
        Me.gpItems.Name = "gpItems"
        Me.gpItems.Size = New System.Drawing.Size(483, 67)
        '
        '
        '
        Me.gpItems.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpItems.Style.BackColorGradientAngle = 90
        Me.gpItems.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpItems.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems.Style.BorderBottomWidth = 1
        Me.gpItems.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpItems.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems.Style.BorderLeftWidth = 1
        Me.gpItems.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems.Style.BorderRightWidth = 1
        Me.gpItems.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems.Style.BorderTopWidth = 1
        Me.gpItems.Style.CornerDiameter = 4
        Me.gpItems.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpItems.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpItems.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpItems.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpItems.TabIndex = 150
        Me.gpItems.Text = "Items"
        '
        'LabelX16
        '
        Me.LabelX16.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX16.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX16.ForeColor = System.Drawing.Color.Navy
        Me.LabelX16.Location = New System.Drawing.Point(5, 25)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(102, 20)
        Me.LabelX16.TabIndex = 179
        Me.LabelX16.Text = "Observacion Gasto"
        Me.LabelX16.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtobservacion_gas
        '
        '
        '
        '
        Me.txtobservacion_gas.Border.Class = "TextBoxBorder"
        Me.txtobservacion_gas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion_gas.Location = New System.Drawing.Point(110, 25)
        Me.txtobservacion_gas.Name = "txtobservacion_gas"
        Me.txtobservacion_gas.Size = New System.Drawing.Size(329, 20)
        Me.txtobservacion_gas.TabIndex = 178
        '
        'txtvalor_gas
        '
        Me.txtvalor_gas.EditValue = "0"
        Me.txtvalor_gas.Location = New System.Drawing.Point(356, 2)
        Me.txtvalor_gas.Name = "txtvalor_gas"
        Me.txtvalor_gas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtvalor_gas.Properties.Appearance.Options.UseFont = True
        Me.txtvalor_gas.Properties.Appearance.Options.UseTextOptions = True
        Me.txtvalor_gas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtvalor_gas.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtvalor_gas.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtvalor_gas.Properties.Mask.BeepOnError = True
        Me.txtvalor_gas.Properties.Mask.EditMask = "c0"
        Me.txtvalor_gas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtvalor_gas.Properties.Mask.ShowPlaceHolders = False
        Me.txtvalor_gas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtvalor_gas.Size = New System.Drawing.Size(83, 21)
        Me.txtvalor_gas.TabIndex = 177
        '
        'btnIngresar_Item
        '
        Me.btnIngresar_Item.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIngresar_Item.Image = CType(resources.GetObject("btnIngresar_Item.Image"), System.Drawing.Image)
        Me.btnIngresar_Item.Location = New System.Drawing.Point(448, 0)
        Me.btnIngresar_Item.Name = "btnIngresar_Item"
        Me.btnIngresar_Item.Size = New System.Drawing.Size(23, 21)
        Me.btnIngresar_Item.TabIndex = 174
        '
        'cmbItemGastos
        '
        Me.cmbItemGastos.FormattingEnabled = True
        Me.cmbItemGastos.Location = New System.Drawing.Point(143, 3)
        Me.cmbItemGastos.Name = "cmbItemGastos"
        Me.cmbItemGastos.Size = New System.Drawing.Size(179, 21)
        Me.cmbItemGastos.TabIndex = 139
        Me.cmbItemGastos.Text = "ESCOJA EL ITEM"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(5, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(44, 20)
        Me.LabelX1.TabIndex = 134
        Me.LabelX1.Text = "Codigo"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdgasto
        '
        '
        '
        '
        Me.txtIdgasto.Border.Class = "TextBoxBorder"
        Me.txtIdgasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdgasto.Location = New System.Drawing.Point(50, 4)
        Me.txtIdgasto.Name = "txtIdgasto"
        Me.txtIdgasto.ReadOnly = True
        Me.txtIdgasto.Size = New System.Drawing.Size(57, 20)
        Me.txtIdgasto.TabIndex = 133
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(109, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(31, 20)
        Me.LabelX2.TabIndex = 136
        Me.LabelX2.Text = "Item"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX13.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX13.ForeColor = System.Drawing.Color.Navy
        Me.LabelX13.Location = New System.Drawing.Point(324, 4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(30, 20)
        Me.LabelX13.TabIndex = 138
        Me.LabelX13.Text = "Valor"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnBorrarItem
        '
        Me.btnBorrarItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarItem.Image = CType(resources.GetObject("btnBorrarItem.Image"), System.Drawing.Image)
        Me.btnBorrarItem.Location = New System.Drawing.Point(448, 23)
        Me.btnBorrarItem.Name = "btnBorrarItem"
        Me.btnBorrarItem.Size = New System.Drawing.Size(23, 22)
        Me.btnBorrarItem.TabIndex = 184
        '
        'gpfechaCE
        '
        Me.gpfechaCE.BackColor = System.Drawing.Color.Transparent
        Me.gpfechaCE.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpfechaCE.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpfechaCE.Controls.Add(Me.cmbfecha_ce)
        Me.gpfechaCE.Controls.Add(Me.LabelX3)
        Me.gpfechaCE.Location = New System.Drawing.Point(25, 77)
        Me.gpfechaCE.Name = "gpfechaCE"
        Me.gpfechaCE.Size = New System.Drawing.Size(195, 44)
        '
        '
        '
        Me.gpfechaCE.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpfechaCE.Style.BackColorGradientAngle = 90
        Me.gpfechaCE.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpfechaCE.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpfechaCE.Style.BorderBottomWidth = 1
        Me.gpfechaCE.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpfechaCE.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpfechaCE.Style.BorderLeftWidth = 1
        Me.gpfechaCE.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpfechaCE.Style.BorderRightWidth = 1
        Me.gpfechaCE.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpfechaCE.Style.BorderTopWidth = 1
        Me.gpfechaCE.Style.CornerDiameter = 4
        Me.gpfechaCE.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpfechaCE.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpfechaCE.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpfechaCE.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpfechaCE.TabIndex = 147
        '
        'cmbfecha_ce
        '
        Me.cmbfecha_ce.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_ce.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_ce.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecha_ce.Location = New System.Drawing.Point(74, 7)
        Me.cmbfecha_ce.Name = "cmbfecha_ce"
        Me.cmbfecha_ce.Size = New System.Drawing.Size(103, 23)
        Me.cmbfecha_ce.TabIndex = 133
        Me.cmbfecha_ce.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(10, 10)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(59, 20)
        Me.LabelX3.TabIndex = 132
        Me.LabelX3.Text = "Fecha"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rcBuscarCEgreso
        '
        Me.rcBuscarCEgreso.CanvasColor = System.Drawing.SystemColors.Control
        Me.rcBuscarCEgreso.Controls.Add(Me.LabelX9)
        Me.rcBuscarCEgreso.Controls.Add(Me.btnCEBuscar)
        Me.rcBuscarCEgreso.Controls.Add(Me.txtIdce_Bus)
        Me.rcBuscarCEgreso.Location = New System.Drawing.Point(27, 39)
        Me.rcBuscarCEgreso.Name = "rcBuscarCEgreso"
        Me.rcBuscarCEgreso.Size = New System.Drawing.Size(311, 32)
        '
        '
        '
        Me.rcBuscarCEgreso.Style.Class = "RibbonClientPanel"
        Me.rcBuscarCEgreso.TabIndex = 146
        Me.rcBuscarCEgreso.Text = "RibbonClientPanel2"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX9.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX9.ForeColor = System.Drawing.Color.Navy
        Me.LabelX9.Location = New System.Drawing.Point(11, 5)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(96, 20)
        Me.LabelX9.TabIndex = 145
        Me.LabelX9.Text = "Buscar C.Egreso"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnCEBuscar
        '
        Me.btnCEBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCEBuscar.Image = CType(resources.GetObject("btnCEBuscar.Image"), System.Drawing.Image)
        Me.btnCEBuscar.Location = New System.Drawing.Point(212, 5)
        Me.btnCEBuscar.Name = "btnCEBuscar"
        Me.btnCEBuscar.Size = New System.Drawing.Size(87, 20)
        Me.btnCEBuscar.TabIndex = 144
        Me.btnCEBuscar.Text = "BUSCAR"
        '
        'txtIdce_Bus
        '
        '
        '
        '
        Me.txtIdce_Bus.Border.Class = "TextBoxBorder"
        Me.txtIdce_Bus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdce_Bus.Location = New System.Drawing.Point(113, 5)
        Me.txtIdce_Bus.Name = "txtIdce_Bus"
        Me.txtIdce_Bus.Size = New System.Drawing.Size(93, 20)
        Me.txtIdce_Bus.TabIndex = 128
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(322, 436)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 39)
        Me.btnImprimir.TabIndex = 145
        Me.btnImprimir.Text = "IMPRIMIR"
        '
        'gpPagoBanco
        '
        Me.gpPagoBanco.BackColor = System.Drawing.Color.Transparent
        Me.gpPagoBanco.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPagoBanco.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPagoBanco.Controls.Add(Me.txtbanco_ce)
        Me.gpPagoBanco.Controls.Add(Me.LabelX8)
        Me.gpPagoBanco.Controls.Add(Me.LabelX7)
        Me.gpPagoBanco.Controls.Add(Me.txtcheque_ce)
        Me.gpPagoBanco.Location = New System.Drawing.Point(27, 399)
        Me.gpPagoBanco.Name = "gpPagoBanco"
        Me.gpPagoBanco.Size = New System.Drawing.Size(485, 34)
        '
        '
        '
        Me.gpPagoBanco.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpPagoBanco.Style.BackColorGradientAngle = 90
        Me.gpPagoBanco.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpPagoBanco.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagoBanco.Style.BorderBottomWidth = 1
        Me.gpPagoBanco.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpPagoBanco.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagoBanco.Style.BorderLeftWidth = 1
        Me.gpPagoBanco.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagoBanco.Style.BorderRightWidth = 1
        Me.gpPagoBanco.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPagoBanco.Style.BorderTopWidth = 1
        Me.gpPagoBanco.Style.CornerDiameter = 4
        Me.gpPagoBanco.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpPagoBanco.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpPagoBanco.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpPagoBanco.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpPagoBanco.TabIndex = 131
        '
        'txtbanco_ce
        '
        '
        '
        '
        Me.txtbanco_ce.Border.Class = "TextBoxBorder"
        Me.txtbanco_ce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbanco_ce.Location = New System.Drawing.Point(265, 4)
        Me.txtbanco_ce.Name = "txtbanco_ce"
        Me.txtbanco_ce.Size = New System.Drawing.Size(206, 20)
        Me.txtbanco_ce.TabIndex = 137
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX8.ForeColor = System.Drawing.Color.Navy
        Me.LabelX8.Location = New System.Drawing.Point(194, 4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(65, 20)
        Me.LabelX8.TabIndex = 136
        Me.LabelX8.Text = "Banco"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(6, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(65, 20)
        Me.LabelX7.TabIndex = 135
        Me.LabelX7.Text = "Cheque No."
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtcheque_ce
        '
        '
        '
        '
        Me.txtcheque_ce.Border.Class = "TextBoxBorder"
        Me.txtcheque_ce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcheque_ce.Location = New System.Drawing.Point(77, 4)
        Me.txtcheque_ce.Name = "txtcheque_ce"
        Me.txtcheque_ce.Size = New System.Drawing.Size(111, 20)
        Me.txtcheque_ce.TabIndex = 127
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(125, 435)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(90, 39)
        Me.btnNuevo.TabIndex = 141
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(421, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnSalir.TabIndex = 143
        Me.btnSalir.Text = "SALIR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(29, 435)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(90, 39)
        Me.btnAdicionar.TabIndex = 139
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'gpIdce
        '
        Me.gpIdce.BackColor = System.Drawing.Color.Transparent
        Me.gpIdce.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpIdce.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpIdce.Controls.Add(Me.LabelX10)
        Me.gpIdce.Controls.Add(Me.txtIdce)
        Me.gpIdce.Location = New System.Drawing.Point(344, 39)
        Me.gpIdce.Name = "gpIdce"
        Me.gpIdce.Size = New System.Drawing.Size(165, 32)
        '
        '
        '
        Me.gpIdce.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpIdce.Style.BackColorGradientAngle = 90
        Me.gpIdce.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpIdce.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpIdce.Style.BorderBottomWidth = 1
        Me.gpIdce.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpIdce.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpIdce.Style.BorderLeftWidth = 1
        Me.gpIdce.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpIdce.Style.BorderRightWidth = 1
        Me.gpIdce.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpIdce.Style.BorderTopWidth = 1
        Me.gpIdce.Style.CornerDiameter = 4
        Me.gpIdce.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpIdce.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpIdce.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpIdce.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpIdce.TabIndex = 130
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX10.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX10.ForeColor = System.Drawing.Color.Navy
        Me.LabelX10.Location = New System.Drawing.Point(7, 5)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(45, 20)
        Me.LabelX10.TabIndex = 133
        Me.LabelX10.Text = "No."
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdce
        '
        '
        '
        '
        Me.txtIdce.Border.Class = "TextBoxBorder"
        Me.txtIdce.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdce.Location = New System.Drawing.Point(58, 4)
        Me.txtIdce.Name = "txtIdce"
        Me.txtIdce.ReadOnly = True
        Me.txtIdce.Size = New System.Drawing.Size(93, 20)
        Me.txtIdce.TabIndex = 127
        Me.txtIdce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(25, 9)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(484, 23)
        Me.lblTituloVentana.TabIndex = 125
        Me.lblTituloVentana.Text = "COMPROBANTE DE EGRESO"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'frmComprobanteEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmComprobanteEgreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Comprobante de Egreso"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.dgCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttotal_ce.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpItems.ResumeLayout(False)
        CType(Me.txtvalor_gas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpfechaCE.ResumeLayout(False)
        Me.rcBuscarCEgreso.ResumeLayout(False)
        Me.gpPagoBanco.ResumeLayout(False)
        Me.gpIdce.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpfechaCE As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents rcBuscarCEgreso As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCEBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIdce_Bus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpPagoBanco As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtbanco_ce As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcheque_ce As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpIdce As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdce As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpItems As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdgasto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecha_ce As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttotal_ce As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbltotal_ce As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbItemGastos As System.Windows.Forms.ComboBox
    Friend WithEvents lblRecibimosde As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtobservaciones_ce As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblobservaciones_ce As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblAnulada As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBorrarItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtdebitesea_ce As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lbldebitesea_ce As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblIdproveedor As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdproveedor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents txtconcepto_ce As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblconcepto_ce As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtciudad_ce As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblciudad_ce As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAnular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnIngresar_Item As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents txtvalor_gas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtobservacion_gas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgCE As System.Windows.Forms.DataGridView
End Class
