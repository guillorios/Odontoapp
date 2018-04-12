<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRCaja
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRCaja))
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.cmbDoctores = New System.Windows.Forms.ComboBox
        Me.lblDoctores = New DevComponents.DotNetBar.LabelX
        Me.txtTarjeta_rc = New DevExpress.XtraEditors.TextEdit
        Me.lblTarjeta_rc = New DevComponents.DotNetBar.LabelX
        Me.txtEfectivo_rc = New DevExpress.XtraEditors.TextEdit
        Me.lblEfectivo_rc = New DevComponents.DotNetBar.LabelX
        Me.txtobservaciones_rc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblobservaciones_rc = New DevComponents.DotNetBar.LabelX
        Me.lblAnulada = New DevComponents.DotNetBar.LabelX
        Me.txtConcepto_rc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblConcepto_rc = New DevComponents.DotNetBar.LabelX
        Me.dgRC = New System.Windows.Forms.DataGridView
        Me.gpItems_rc = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbItem = New System.Windows.Forms.ComboBox
        Me.txtreferencia_proc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.txtvalor_proc = New DevExpress.XtraEditors.TextEdit
        Me.btnBorrarItem = New DevComponents.DotNetBar.ButtonX
        Me.btnIngresar_Item = New DevComponents.DotNetBar.ButtonX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtIdprocedimiento = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.txtIdpaciente = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtNombre_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblNombre_pac = New DevComponents.DotNetBar.LabelX
        Me.txtTotal_rc = New DevExpress.XtraEditors.TextEdit
        Me.lblTotal_rc = New DevComponents.DotNetBar.LabelX
        Me.RibbonBuscar_Rc = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.btnRCBuscar = New DevComponents.DotNetBar.ButtonX
        Me.txtIdrc_Bus = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnImprimir = New DevComponents.DotNetBar.ButtonX
        Me.gpbanco_rc = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtbanco_rc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.txtcheque_rc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnAnular = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.gpNRcaja = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbfecha_rc = New System.Windows.Forms.DateTimePicker
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.txtIdrc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.SuperTooltip = New DevComponents.DotNetBar.SuperTooltip
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DxError = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.cmbEspecialidades = New System.Windows.Forms.ComboBox
        Me.lblNombreEspecialidad = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.txtTarjeta_rc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEfectivo_rc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgRC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpItems_rc.SuspendLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal_rc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonBuscar_Rc.SuspendLayout()
        Me.gpbanco_rc.SuspendLayout()
        Me.gpNRcaja.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(10, 9)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(512, 23)
        Me.lblTituloVentana.TabIndex = 125
        Me.lblTituloVentana.Text = "RECIBOS DE CAJA"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.cmbDoctores)
        Me.RibbonClientPanel1.Controls.Add(Me.lblDoctores)
        Me.RibbonClientPanel1.Controls.Add(Me.txtTarjeta_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTarjeta_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.txtEfectivo_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.lblEfectivo_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.txtobservaciones_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.lblobservaciones_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.lblAnulada)
        Me.RibbonClientPanel1.Controls.Add(Me.txtConcepto_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.lblConcepto_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.dgRC)
        Me.RibbonClientPanel1.Controls.Add(Me.gpItems_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.txtIdpaciente)
        Me.RibbonClientPanel1.Controls.Add(Me.txtNombre_pac)
        Me.RibbonClientPanel1.Controls.Add(Me.lblNombre_pac)
        Me.RibbonClientPanel1.Controls.Add(Me.txtTotal_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTotal_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.RibbonBuscar_Rc)
        Me.RibbonClientPanel1.Controls.Add(Me.btnImprimir)
        Me.RibbonClientPanel1.Controls.Add(Me.gpbanco_rc)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAnular)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.gpNRcaja)
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
        Me.RibbonClientPanel1.TabIndex = 1
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'cmbDoctores
        '
        Me.cmbDoctores.FormattingEnabled = True
        Me.cmbDoctores.Location = New System.Drawing.Point(80, 192)
        Me.cmbDoctores.Name = "cmbDoctores"
        Me.cmbDoctores.Size = New System.Drawing.Size(442, 21)
        Me.cmbDoctores.TabIndex = 186
        '
        'lblDoctores
        '
        Me.lblDoctores.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDoctores.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblDoctores.ForeColor = System.Drawing.Color.Navy
        Me.lblDoctores.Location = New System.Drawing.Point(11, 192)
        Me.lblDoctores.Name = "lblDoctores"
        Me.lblDoctores.Size = New System.Drawing.Size(63, 20)
        Me.lblDoctores.TabIndex = 185
        Me.lblDoctores.Text = "Doctor"
        Me.lblDoctores.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTarjeta_rc
        '
        Me.txtTarjeta_rc.EditValue = "0"
        Me.txtTarjeta_rc.Location = New System.Drawing.Point(409, 370)
        Me.txtTarjeta_rc.Name = "txtTarjeta_rc"
        Me.txtTarjeta_rc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTarjeta_rc.Properties.Appearance.Options.UseFont = True
        Me.txtTarjeta_rc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTarjeta_rc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTarjeta_rc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTarjeta_rc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTarjeta_rc.Properties.Mask.BeepOnError = True
        Me.txtTarjeta_rc.Properties.Mask.EditMask = "c0"
        Me.txtTarjeta_rc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarjeta_rc.Properties.Mask.ShowPlaceHolders = False
        Me.txtTarjeta_rc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTarjeta_rc.Size = New System.Drawing.Size(115, 21)
        Me.txtTarjeta_rc.TabIndex = 184
        '
        'lblTarjeta_rc
        '
        Me.lblTarjeta_rc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTarjeta_rc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTarjeta_rc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarjeta_rc.ForeColor = System.Drawing.Color.Navy
        Me.lblTarjeta_rc.Location = New System.Drawing.Point(343, 371)
        Me.lblTarjeta_rc.Name = "lblTarjeta_rc"
        Me.lblTarjeta_rc.Size = New System.Drawing.Size(63, 20)
        Me.lblTarjeta_rc.TabIndex = 183
        Me.lblTarjeta_rc.Text = "Tarjeta"
        Me.lblTarjeta_rc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtEfectivo_rc
        '
        Me.txtEfectivo_rc.EditValue = "0"
        Me.txtEfectivo_rc.Location = New System.Drawing.Point(225, 370)
        Me.txtEfectivo_rc.Name = "txtEfectivo_rc"
        Me.txtEfectivo_rc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtEfectivo_rc.Properties.Appearance.Options.UseFont = True
        Me.txtEfectivo_rc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEfectivo_rc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtEfectivo_rc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtEfectivo_rc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtEfectivo_rc.Properties.Mask.BeepOnError = True
        Me.txtEfectivo_rc.Properties.Mask.EditMask = "c0"
        Me.txtEfectivo_rc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEfectivo_rc.Properties.Mask.ShowPlaceHolders = False
        Me.txtEfectivo_rc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEfectivo_rc.Properties.ReadOnly = True
        Me.txtEfectivo_rc.Size = New System.Drawing.Size(115, 21)
        Me.txtEfectivo_rc.TabIndex = 182
        '
        'lblEfectivo_rc
        '
        Me.lblEfectivo_rc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEfectivo_rc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblEfectivo_rc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfectivo_rc.ForeColor = System.Drawing.Color.Navy
        Me.lblEfectivo_rc.Location = New System.Drawing.Point(165, 370)
        Me.lblEfectivo_rc.Name = "lblEfectivo_rc"
        Me.lblEfectivo_rc.Size = New System.Drawing.Size(56, 20)
        Me.lblEfectivo_rc.TabIndex = 181
        Me.lblEfectivo_rc.Text = "Efectivo"
        Me.lblEfectivo_rc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtobservaciones_rc
        '
        '
        '
        '
        Me.txtobservaciones_rc.Border.Class = "TextBoxBorder"
        Me.txtobservaciones_rc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservaciones_rc.Location = New System.Drawing.Point(100, 395)
        Me.txtobservaciones_rc.Name = "txtobservaciones_rc"
        Me.txtobservaciones_rc.Size = New System.Drawing.Size(422, 20)
        Me.txtobservaciones_rc.TabIndex = 138
        '
        'lblobservaciones_rc
        '
        Me.lblobservaciones_rc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblobservaciones_rc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblobservaciones_rc.ForeColor = System.Drawing.Color.Navy
        Me.lblobservaciones_rc.Location = New System.Drawing.Point(7, 395)
        Me.lblobservaciones_rc.Name = "lblobservaciones_rc"
        Me.lblobservaciones_rc.Size = New System.Drawing.Size(89, 20)
        Me.lblobservaciones_rc.TabIndex = 138
        Me.lblobservaciones_rc.Text = "Observaciones"
        Me.lblobservaciones_rc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblAnulada
        '
        Me.lblAnulada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAnulada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnulada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAnulada.Location = New System.Drawing.Point(10, 331)
        Me.lblAnulada.Name = "lblAnulada"
        Me.lblAnulada.SingleLineColor = System.Drawing.Color.Gold
        Me.lblAnulada.Size = New System.Drawing.Size(512, 35)
        Me.lblAnulada.TabIndex = 180
        Me.lblAnulada.Text = "RECIBO DE CAJA ANULADO"
        Me.lblAnulada.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblAnulada.Visible = False
        '
        'txtConcepto_rc
        '
        '
        '
        '
        Me.txtConcepto_rc.Border.Class = "TextBoxBorder"
        Me.txtConcepto_rc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto_rc.Location = New System.Drawing.Point(116, 91)
        Me.txtConcepto_rc.Name = "txtConcepto_rc"
        Me.txtConcepto_rc.Size = New System.Drawing.Size(406, 20)
        Me.txtConcepto_rc.TabIndex = 161
        '
        'lblConcepto_rc
        '
        Me.lblConcepto_rc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblConcepto_rc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblConcepto_rc.ForeColor = System.Drawing.Color.Navy
        Me.lblConcepto_rc.Location = New System.Drawing.Point(10, 91)
        Me.lblConcepto_rc.Name = "lblConcepto_rc"
        Me.lblConcepto_rc.Size = New System.Drawing.Size(100, 20)
        Me.lblConcepto_rc.TabIndex = 160
        Me.lblConcepto_rc.Text = "Concepto :"
        Me.lblConcepto_rc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgRC
        '
        Me.dgRC.AllowUserToAddRows = False
        Me.dgRC.AllowUserToOrderColumns = True
        Me.dgRC.AllowUserToResizeColumns = False
        Me.dgRC.AllowUserToResizeRows = False
        Me.dgRC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgRC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRC.EnableHeadersVisualStyles = False
        Me.dgRC.Location = New System.Drawing.Point(10, 218)
        Me.dgRC.Name = "dgRC"
        Me.dgRC.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRC.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgRC.RowHeadersVisible = False
        Me.dgRC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRC.Size = New System.Drawing.Size(512, 146)
        Me.dgRC.TabIndex = 159
        '
        'gpItems_rc
        '
        Me.gpItems_rc.BackColor = System.Drawing.Color.Transparent
        Me.gpItems_rc.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpItems_rc.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpItems_rc.Controls.Add(Me.cmbEspecialidades)
        Me.gpItems_rc.Controls.Add(Me.cmbItem)
        Me.gpItems_rc.Controls.Add(Me.lblNombreEspecialidad)
        Me.gpItems_rc.Controls.Add(Me.txtreferencia_proc)
        Me.gpItems_rc.Controls.Add(Me.LabelX15)
        Me.gpItems_rc.Controls.Add(Me.txtCantidad)
        Me.gpItems_rc.Controls.Add(Me.LabelX6)
        Me.gpItems_rc.Controls.Add(Me.txtTotal)
        Me.gpItems_rc.Controls.Add(Me.LabelX5)
        Me.gpItems_rc.Controls.Add(Me.txtvalor_proc)
        Me.gpItems_rc.Controls.Add(Me.btnBorrarItem)
        Me.gpItems_rc.Controls.Add(Me.btnIngresar_Item)
        Me.gpItems_rc.Controls.Add(Me.LabelX2)
        Me.gpItems_rc.Controls.Add(Me.txtIdprocedimiento)
        Me.gpItems_rc.Controls.Add(Me.LabelX3)
        Me.gpItems_rc.Controls.Add(Me.LabelX12)
        Me.gpItems_rc.Location = New System.Drawing.Point(10, 115)
        Me.gpItems_rc.Name = "gpItems_rc"
        Me.gpItems_rc.Size = New System.Drawing.Size(512, 75)
        '
        '
        '
        Me.gpItems_rc.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpItems_rc.Style.BackColorGradientAngle = 90
        Me.gpItems_rc.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpItems_rc.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_rc.Style.BorderBottomWidth = 1
        Me.gpItems_rc.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpItems_rc.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_rc.Style.BorderLeftWidth = 1
        Me.gpItems_rc.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_rc.Style.BorderRightWidth = 1
        Me.gpItems_rc.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpItems_rc.Style.BorderTopWidth = 1
        Me.gpItems_rc.Style.CornerDiameter = 4
        Me.gpItems_rc.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpItems_rc.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpItems_rc.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpItems_rc.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpItems_rc.TabIndex = 158
        '
        'cmbItem
        '
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(52, 24)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(219, 21)
        Me.cmbItem.TabIndex = 139
        '
        'txtreferencia_proc
        '
        '
        '
        '
        Me.txtreferencia_proc.Border.Class = "TextBoxBorder"
        Me.txtreferencia_proc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferencia_proc.Location = New System.Drawing.Point(344, 25)
        Me.txtreferencia_proc.Name = "txtreferencia_proc"
        Me.txtreferencia_proc.ReadOnly = True
        Me.txtreferencia_proc.Size = New System.Drawing.Size(131, 20)
        Me.txtreferencia_proc.TabIndex = 180
        '
        'LabelX15
        '
        Me.LabelX15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX15.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX15.ForeColor = System.Drawing.Color.Navy
        Me.LabelX15.Location = New System.Drawing.Point(274, 25)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(64, 20)
        Me.LabelX15.TabIndex = 179
        Me.LabelX15.Text = "Referencia"
        Me.LabelX15.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCantidad
        '
        Me.txtCantidad.EditValue = "1"
        Me.txtCantidad.Location = New System.Drawing.Point(274, 47)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCantidad.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtCantidad.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtCantidad.Properties.Mask.BeepOnError = True
        Me.txtCantidad.Properties.Mask.EditMask = "n0"
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Properties.Mask.ShowPlaceHolders = False
        Me.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Size = New System.Drawing.Size(32, 21)
        Me.txtCantidad.TabIndex = 178
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX6.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX6.ForeColor = System.Drawing.Color.Navy
        Me.LabelX6.Location = New System.Drawing.Point(233, 48)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(38, 20)
        Me.LabelX6.TabIndex = 177
        Me.LabelX6.Text = "Cant."
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.EditValue = "0"
        Me.txtTotal.Location = New System.Drawing.Point(344, 48)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotal.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotal.Properties.Mask.BeepOnError = True
        Me.txtTotal.Properties.Mask.EditMask = "c0"
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(131, 21)
        Me.txtTotal.TabIndex = 176
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX5.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX5.ForeColor = System.Drawing.Color.Navy
        Me.LabelX5.Location = New System.Drawing.Point(308, 48)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(30, 20)
        Me.LabelX5.TabIndex = 175
        Me.LabelX5.Text = "Total"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtvalor_proc
        '
        Me.txtvalor_proc.EditValue = "0"
        Me.txtvalor_proc.Location = New System.Drawing.Point(148, 48)
        Me.txtvalor_proc.Name = "txtvalor_proc"
        Me.txtvalor_proc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtvalor_proc.Properties.Appearance.Options.UseFont = True
        Me.txtvalor_proc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtvalor_proc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtvalor_proc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtvalor_proc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtvalor_proc.Properties.Mask.BeepOnError = True
        Me.txtvalor_proc.Properties.Mask.EditMask = "c0"
        Me.txtvalor_proc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtvalor_proc.Properties.Mask.ShowPlaceHolders = False
        Me.txtvalor_proc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtvalor_proc.Size = New System.Drawing.Size(83, 21)
        Me.txtvalor_proc.TabIndex = 174
        '
        'btnBorrarItem
        '
        Me.btnBorrarItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarItem.Image = CType(resources.GetObject("btnBorrarItem.Image"), System.Drawing.Image)
        Me.btnBorrarItem.Location = New System.Drawing.Point(481, 48)
        Me.btnBorrarItem.Name = "btnBorrarItem"
        Me.btnBorrarItem.Size = New System.Drawing.Size(22, 22)
        Me.SuperTooltip.SetSuperTooltip(Me.btnBorrarItem, New DevComponents.DotNetBar.SuperTooltipInfo("Borrar Item", "Odontoappoinment", "Borra una fila del Recibo de Caja, seleccione la fila a borrar.", CType(resources.GetObject("btnBorrarItem.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnBorrarItem.TabIndex = 179
        '
        'btnIngresar_Item
        '
        Me.btnIngresar_Item.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIngresar_Item.Image = CType(resources.GetObject("btnIngresar_Item.Image"), System.Drawing.Image)
        Me.btnIngresar_Item.Location = New System.Drawing.Point(481, 24)
        Me.btnIngresar_Item.Name = "btnIngresar_Item"
        Me.btnIngresar_Item.Size = New System.Drawing.Size(22, 22)
        Me.SuperTooltip.SetSuperTooltip(Me.btnIngresar_Item, New DevComponents.DotNetBar.SuperTooltipInfo("Insertar Item", "Odontoapp", "Inserta un item al recibo de caja debe especificar el item o procedimiento y la c" & _
                    "antidad.", CType(resources.GetObject("btnIngresar_Item.SuperTooltip"), System.Drawing.Image), Global.Orthosoft.My.Resources.Resources.bullet_triangle_blue, DevComponents.DotNetBar.eTooltipColor.Purple))
        Me.btnIngresar_Item.TabIndex = 173
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(4, 49)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(41, 20)
        Me.LabelX2.TabIndex = 134
        Me.LabelX2.Text = "Codigo"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdprocedimiento
        '
        '
        '
        '
        Me.txtIdprocedimiento.Border.Class = "TextBoxBorder"
        Me.txtIdprocedimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdprocedimiento.Location = New System.Drawing.Point(51, 49)
        Me.txtIdprocedimiento.Name = "txtIdprocedimiento"
        Me.txtIdprocedimiento.ReadOnly = True
        Me.txtIdprocedimiento.Size = New System.Drawing.Size(62, 20)
        Me.txtIdprocedimiento.TabIndex = 133
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(4, 25)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(41, 20)
        Me.LabelX3.TabIndex = 136
        Me.LabelX3.Text = "Detalle"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX12
        '
        Me.LabelX12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX12.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX12.ForeColor = System.Drawing.Color.Navy
        Me.LabelX12.Location = New System.Drawing.Point(115, 49)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(30, 20)
        Me.LabelX12.TabIndex = 138
        Me.LabelX12.Text = "Valor"
        Me.LabelX12.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdpaciente
        '
        '
        '
        '
        Me.txtIdpaciente.Border.Class = "TextBoxBorder"
        Me.txtIdpaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdpaciente.Location = New System.Drawing.Point(116, 69)
        Me.txtIdpaciente.Name = "txtIdpaciente"
        Me.txtIdpaciente.ReadOnly = True
        Me.txtIdpaciente.Size = New System.Drawing.Size(31, 21)
        Me.txtIdpaciente.TabIndex = 157
        '
        'txtNombre_pac
        '
        '
        '
        '
        Me.txtNombre_pac.Border.Class = "TextBoxBorder"
        Me.txtNombre_pac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre_pac.Location = New System.Drawing.Point(153, 70)
        Me.txtNombre_pac.Name = "txtNombre_pac"
        Me.txtNombre_pac.ReadOnly = True
        Me.txtNombre_pac.Size = New System.Drawing.Size(369, 20)
        Me.txtNombre_pac.TabIndex = 126
        '
        'lblNombre_pac
        '
        Me.lblNombre_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNombre_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNombre_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblNombre_pac.Location = New System.Drawing.Point(10, 70)
        Me.lblNombre_pac.Name = "lblNombre_pac"
        Me.lblNombre_pac.Size = New System.Drawing.Size(100, 20)
        Me.lblNombre_pac.TabIndex = 127
        Me.lblNombre_pac.Text = "Recibimos de :"
        Me.lblNombre_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtTotal_rc
        '
        Me.txtTotal_rc.EditValue = "0"
        Me.txtTotal_rc.Location = New System.Drawing.Point(48, 369)
        Me.txtTotal_rc.Name = "txtTotal_rc"
        Me.txtTotal_rc.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal_rc.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtTotal_rc.Properties.Appearance.Options.UseFont = True
        Me.txtTotal_rc.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal_rc.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal_rc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal_rc.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.txtTotal_rc.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txtTotal_rc.Properties.Mask.BeepOnError = True
        Me.txtTotal_rc.Properties.Mask.EditMask = "c0"
        Me.txtTotal_rc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal_rc.Properties.Mask.ShowPlaceHolders = False
        Me.txtTotal_rc.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal_rc.Properties.ReadOnly = True
        Me.txtTotal_rc.Size = New System.Drawing.Size(115, 21)
        Me.txtTotal_rc.TabIndex = 156
        '
        'lblTotal_rc
        '
        Me.lblTotal_rc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotal_rc.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTotal_rc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal_rc.ForeColor = System.Drawing.Color.Navy
        Me.lblTotal_rc.Location = New System.Drawing.Point(7, 369)
        Me.lblTotal_rc.Name = "lblTotal_rc"
        Me.lblTotal_rc.Size = New System.Drawing.Size(37, 20)
        Me.lblTotal_rc.TabIndex = 155
        Me.lblTotal_rc.Text = "Total"
        Me.lblTotal_rc.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'RibbonBuscar_Rc
        '
        Me.RibbonBuscar_Rc.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonBuscar_Rc.Controls.Add(Me.LabelX9)
        Me.RibbonBuscar_Rc.Controls.Add(Me.btnRCBuscar)
        Me.RibbonBuscar_Rc.Controls.Add(Me.txtIdrc_Bus)
        Me.RibbonBuscar_Rc.Location = New System.Drawing.Point(10, 37)
        Me.RibbonBuscar_Rc.Name = "RibbonBuscar_Rc"
        Me.RibbonBuscar_Rc.Size = New System.Drawing.Size(232, 29)
        '
        '
        '
        Me.RibbonBuscar_Rc.Style.Class = "RibbonClientPanel"
        Me.RibbonBuscar_Rc.TabIndex = 146
        Me.RibbonBuscar_Rc.Text = "RibbonClientPanel2"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX9.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX9.ForeColor = System.Drawing.Color.Navy
        Me.LabelX9.Location = New System.Drawing.Point(4, 4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(63, 20)
        Me.LabelX9.TabIndex = 145
        Me.LabelX9.Text = "Buscar RC."
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnRCBuscar
        '
        Me.btnRCBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRCBuscar.Image = CType(resources.GetObject("btnRCBuscar.Image"), System.Drawing.Image)
        Me.btnRCBuscar.Location = New System.Drawing.Point(153, 4)
        Me.btnRCBuscar.Name = "btnRCBuscar"
        Me.btnRCBuscar.Size = New System.Drawing.Size(76, 20)
        Me.btnRCBuscar.TabIndex = 144
        Me.btnRCBuscar.Text = "BUSCAR"
        '
        'txtIdrc_Bus
        '
        '
        '
        '
        Me.txtIdrc_Bus.Border.Class = "TextBoxBorder"
        Me.txtIdrc_Bus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdrc_Bus.Location = New System.Drawing.Point(71, 4)
        Me.txtIdrc_Bus.Name = "txtIdrc_Bus"
        Me.txtIdrc_Bus.Size = New System.Drawing.Size(80, 20)
        Me.txtIdrc_Bus.TabIndex = 128
        '
        'btnImprimir
        '
        Me.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(280, 449)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(89, 29)
        Me.btnImprimir.TabIndex = 145
        Me.btnImprimir.Text = "IMPRIMIR"
        '
        'gpbanco_rc
        '
        Me.gpbanco_rc.BackColor = System.Drawing.Color.Transparent
        Me.gpbanco_rc.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpbanco_rc.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpbanco_rc.Controls.Add(Me.txtbanco_rc)
        Me.gpbanco_rc.Controls.Add(Me.LabelX8)
        Me.gpbanco_rc.Controls.Add(Me.LabelX7)
        Me.gpbanco_rc.Controls.Add(Me.txtcheque_rc)
        Me.gpbanco_rc.Location = New System.Drawing.Point(9, 418)
        Me.gpbanco_rc.Name = "gpbanco_rc"
        Me.gpbanco_rc.Size = New System.Drawing.Size(513, 27)
        '
        '
        '
        Me.gpbanco_rc.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpbanco_rc.Style.BackColorGradientAngle = 90
        Me.gpbanco_rc.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpbanco_rc.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpbanco_rc.Style.BorderBottomWidth = 1
        Me.gpbanco_rc.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpbanco_rc.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpbanco_rc.Style.BorderLeftWidth = 1
        Me.gpbanco_rc.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpbanco_rc.Style.BorderRightWidth = 1
        Me.gpbanco_rc.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpbanco_rc.Style.BorderTopWidth = 1
        Me.gpbanco_rc.Style.CornerDiameter = 4
        Me.gpbanco_rc.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpbanco_rc.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpbanco_rc.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpbanco_rc.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpbanco_rc.TabIndex = 131
        '
        'txtbanco_rc
        '
        '
        '
        '
        Me.txtbanco_rc.Border.Class = "TextBoxBorder"
        Me.txtbanco_rc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbanco_rc.Location = New System.Drawing.Point(267, 0)
        Me.txtbanco_rc.Name = "txtbanco_rc"
        Me.txtbanco_rc.Size = New System.Drawing.Size(215, 20)
        Me.txtbanco_rc.TabIndex = 137
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX8.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX8.ForeColor = System.Drawing.Color.Navy
        Me.LabelX8.Location = New System.Drawing.Point(225, 0)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(36, 20)
        Me.LabelX8.TabIndex = 136
        Me.LabelX8.Text = "Banco"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(6, 0)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(65, 20)
        Me.LabelX7.TabIndex = 135
        Me.LabelX7.Text = "Cheque No."
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtcheque_rc
        '
        '
        '
        '
        Me.txtcheque_rc.Border.Class = "TextBoxBorder"
        Me.txtcheque_rc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcheque_rc.Location = New System.Drawing.Point(77, 0)
        Me.txtcheque_rc.Name = "txtcheque_rc"
        Me.txtcheque_rc.Size = New System.Drawing.Size(142, 20)
        Me.txtcheque_rc.TabIndex = 127
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(98, 449)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(89, 29)
        Me.btnNuevo.TabIndex = 141
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(409, 449)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 29)
        Me.btnSalir.TabIndex = 143
        Me.btnSalir.Text = "SALIR"
        '
        'btnAnular
        '
        Me.btnAnular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnular.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.Location = New System.Drawing.Point(189, 449)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(89, 29)
        Me.btnAnular.TabIndex = 142
        Me.btnAnular.Text = "ANULAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Enabled = False
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(7, 449)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(89, 29)
        Me.btnAdicionar.TabIndex = 139
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'gpNRcaja
        '
        Me.gpNRcaja.BackColor = System.Drawing.Color.Transparent
        Me.gpNRcaja.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpNRcaja.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpNRcaja.Controls.Add(Me.cmbfecha_rc)
        Me.gpNRcaja.Controls.Add(Me.LabelX10)
        Me.gpNRcaja.Controls.Add(Me.LabelX13)
        Me.gpNRcaja.Controls.Add(Me.txtIdrc)
        Me.gpNRcaja.Location = New System.Drawing.Point(245, 38)
        Me.gpNRcaja.Name = "gpNRcaja"
        Me.gpNRcaja.Size = New System.Drawing.Size(278, 29)
        '
        '
        '
        Me.gpNRcaja.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpNRcaja.Style.BackColorGradientAngle = 90
        Me.gpNRcaja.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpNRcaja.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNRcaja.Style.BorderBottomWidth = 1
        Me.gpNRcaja.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpNRcaja.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNRcaja.Style.BorderLeftWidth = 1
        Me.gpNRcaja.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNRcaja.Style.BorderRightWidth = 1
        Me.gpNRcaja.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpNRcaja.Style.BorderTopWidth = 1
        Me.gpNRcaja.Style.CornerDiameter = 4
        Me.gpNRcaja.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpNRcaja.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpNRcaja.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpNRcaja.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpNRcaja.TabIndex = 130
        '
        'cmbfecha_rc
        '
        Me.cmbfecha_rc.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_rc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecha_rc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecha_rc.Location = New System.Drawing.Point(168, 1)
        Me.cmbfecha_rc.Name = "cmbfecha_rc"
        Me.cmbfecha_rc.Size = New System.Drawing.Size(99, 21)
        Me.cmbfecha_rc.TabIndex = 133
        Me.cmbfecha_rc.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX10.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX10.ForeColor = System.Drawing.Color.Navy
        Me.LabelX10.Location = New System.Drawing.Point(0, 1)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(25, 20)
        Me.LabelX10.TabIndex = 133
        Me.LabelX10.Text = "No."
        Me.LabelX10.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX13.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX13.ForeColor = System.Drawing.Color.Navy
        Me.LabelX13.Location = New System.Drawing.Point(119, 1)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(43, 20)
        Me.LabelX13.TabIndex = 132
        Me.LabelX13.Text = "Fecha"
        Me.LabelX13.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdrc
        '
        '
        '
        '
        Me.txtIdrc.Border.Class = "TextBoxBorder"
        Me.txtIdrc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdrc.Location = New System.Drawing.Point(25, 1)
        Me.txtIdrc.Name = "txtIdrc"
        Me.txtIdrc.Size = New System.Drawing.Size(93, 20)
        Me.txtIdrc.TabIndex = 127
        Me.txtIdrc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'DxError
        '
        Me.DxError.ContainerControl = Me
        '
        'cmbEspecialidades
        '
        Me.cmbEspecialidades.FormattingEnabled = True
        Me.cmbEspecialidades.Location = New System.Drawing.Point(123, 1)
        Me.cmbEspecialidades.Name = "cmbEspecialidades"
        Me.cmbEspecialidades.Size = New System.Drawing.Size(379, 21)
        Me.cmbEspecialidades.TabIndex = 188
        '
        'lblNombreEspecialidad
        '
        Me.lblNombreEspecialidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNombreEspecialidad.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNombreEspecialidad.ForeColor = System.Drawing.Color.Navy
        Me.lblNombreEspecialidad.Location = New System.Drawing.Point(5, 2)
        Me.lblNombreEspecialidad.Name = "lblNombreEspecialidad"
        Me.lblNombreEspecialidad.Size = New System.Drawing.Size(115, 20)
        Me.lblNombreEspecialidad.TabIndex = 187
        Me.lblNombreEspecialidad.Text = "Nombre Especialidad"
        '
        'frmRCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Recibo de Caja"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.txtTarjeta_rc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEfectivo_rc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgRC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpItems_rc.ResumeLayout(False)
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal_rc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonBuscar_Rc.ResumeLayout(False)
        Me.gpbanco_rc.ResumeLayout(False)
        Me.gpNRcaja.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents txtNombre_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNombre_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpNRcaja As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtIdrc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAnular As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpbanco_rc As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtbanco_rc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtcheque_rc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RibbonBuscar_Rc As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRCBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIdrc_Bus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecha_rc As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal_rc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTotal_rc As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdpaciente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents gpItems_rc As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdprocedimiento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgRC As System.Windows.Forms.DataGridView
    Friend WithEvents btnIngresar_Item As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtConcepto_rc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblConcepto_rc As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtvalor_proc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtreferencia_proc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnBorrarItem As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTooltip As DevComponents.DotNetBar.SuperTooltip
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblAnulada As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtobservaciones_rc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblobservaciones_rc As DevComponents.DotNetBar.LabelX
    Friend WithEvents DxError As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents txtEfectivo_rc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblEfectivo_rc As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtTarjeta_rc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTarjeta_rc As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbDoctores As System.Windows.Forms.ComboBox
    Friend WithEvents lblDoctores As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbEspecialidades As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreEspecialidad As DevComponents.DotNetBar.LabelX
End Class
