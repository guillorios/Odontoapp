<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcedimientosItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcedimientosItems))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.gpEspecialidades = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbEspecialidades = New System.Windows.Forms.ComboBox
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.gpEstadoCuenta = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtreferencia_proc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.txtdescripcion_proc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtIdprocedimiento = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtvalor_proc = New DevExpress.XtraEditors.TextEdit
        Me.lblCIni2_pre = New DevComponents.DotNetBar.LabelX
        Me.lblNCuotasIni_cuota = New DevComponents.DotNetBar.LabelX
        Me.dgProcedimientosItems = New System.Windows.Forms.DataGridView
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpEspecialidades.SuspendLayout()
        Me.gpEstadoCuenta.SuspendLayout()
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProcedimientosItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.gpEspecialidades)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.gpEstadoCuenta)
        Me.RibbonClientPanel1.Controls.Add(Me.dgProcedimientosItems)
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
        'gpEspecialidades
        '
        Me.gpEspecialidades.BackColor = System.Drawing.Color.Transparent
        Me.gpEspecialidades.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEspecialidades.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEspecialidades.Controls.Add(Me.cmbEspecialidades)
        Me.gpEspecialidades.Controls.Add(Me.LabelX7)
        Me.gpEspecialidades.Location = New System.Drawing.Point(22, 57)
        Me.gpEspecialidades.Name = "gpEspecialidades"
        Me.gpEspecialidades.Size = New System.Drawing.Size(488, 36)
        '
        '
        '
        Me.gpEspecialidades.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpEspecialidades.Style.BackColorGradientAngle = 90
        Me.gpEspecialidades.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpEspecialidades.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderBottomWidth = 1
        Me.gpEspecialidades.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEspecialidades.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderLeftWidth = 1
        Me.gpEspecialidades.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderRightWidth = 1
        Me.gpEspecialidades.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEspecialidades.Style.BorderTopWidth = 1
        Me.gpEspecialidades.Style.CornerDiameter = 4
        Me.gpEspecialidades.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEspecialidades.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEspecialidades.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpEspecialidades.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpEspecialidades.TabIndex = 149
        Me.gpEspecialidades.Tag = ""
        '
        'cmbEspecialidades
        '
        Me.cmbEspecialidades.FormattingEnabled = True
        Me.cmbEspecialidades.Location = New System.Drawing.Point(145, 4)
        Me.cmbEspecialidades.Name = "cmbEspecialidades"
        Me.cmbEspecialidades.Size = New System.Drawing.Size(322, 21)
        Me.cmbEspecialidades.TabIndex = 141
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(5, 5)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(134, 20)
        Me.LabelX7.TabIndex = 100
        Me.LabelX7.Text = "Nombre Especialidad"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(218, 430)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 39)
        Me.btnNuevo.TabIndex = 146
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(120, 430)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 39)
        Me.btnModificar.TabIndex = 145
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(414, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 148
        Me.btnSalir.Text = "SALIR"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(316, 430)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 39)
        Me.btnEliminar.TabIndex = 147
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(22, 430)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnAdicionar.TabIndex = 144
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'gpEstadoCuenta
        '
        Me.gpEstadoCuenta.BackColor = System.Drawing.Color.Transparent
        Me.gpEstadoCuenta.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEstadoCuenta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEstadoCuenta.Controls.Add(Me.txtreferencia_proc)
        Me.gpEstadoCuenta.Controls.Add(Me.LabelX2)
        Me.gpEstadoCuenta.Controls.Add(Me.txtdescripcion_proc)
        Me.gpEstadoCuenta.Controls.Add(Me.LabelX1)
        Me.gpEstadoCuenta.Controls.Add(Me.txtIdprocedimiento)
        Me.gpEstadoCuenta.Controls.Add(Me.txtvalor_proc)
        Me.gpEstadoCuenta.Controls.Add(Me.lblCIni2_pre)
        Me.gpEstadoCuenta.Controls.Add(Me.lblNCuotasIni_cuota)
        Me.gpEstadoCuenta.Location = New System.Drawing.Point(22, 99)
        Me.gpEstadoCuenta.Name = "gpEstadoCuenta"
        Me.gpEstadoCuenta.Size = New System.Drawing.Size(488, 96)
        '
        '
        '
        Me.gpEstadoCuenta.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpEstadoCuenta.Style.BackColorGradientAngle = 90
        Me.gpEstadoCuenta.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpEstadoCuenta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderBottomWidth = 1
        Me.gpEstadoCuenta.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEstadoCuenta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderLeftWidth = 1
        Me.gpEstadoCuenta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderRightWidth = 1
        Me.gpEstadoCuenta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEstadoCuenta.Style.BorderTopWidth = 1
        Me.gpEstadoCuenta.Style.CornerDiameter = 4
        Me.gpEstadoCuenta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEstadoCuenta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEstadoCuenta.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpEstadoCuenta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpEstadoCuenta.TabIndex = 95
        Me.gpEstadoCuenta.Tag = ""
        Me.gpEstadoCuenta.Text = "Datos Items y Procedimientos"
        '
        'txtreferencia_proc
        '
        '
        '
        '
        Me.txtreferencia_proc.Border.Class = "TextBoxBorder"
        Me.txtreferencia_proc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferencia_proc.Location = New System.Drawing.Point(84, 27)
        Me.txtreferencia_proc.Name = "txtreferencia_proc"
        Me.txtreferencia_proc.Size = New System.Drawing.Size(383, 20)
        Me.txtreferencia_proc.TabIndex = 113
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(6, 27)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 20)
        Me.LabelX2.TabIndex = 112
        Me.LabelX2.Text = "Referencia"
        '
        'txtdescripcion_proc
        '
        '
        '
        '
        Me.txtdescripcion_proc.Border.Class = "TextBoxBorder"
        Me.txtdescripcion_proc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion_proc.Location = New System.Drawing.Point(84, 3)
        Me.txtdescripcion_proc.Name = "txtdescripcion_proc"
        Me.txtdescripcion_proc.Size = New System.Drawing.Size(383, 20)
        Me.txtdescripcion_proc.TabIndex = 111
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(6, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 20)
        Me.LabelX1.TabIndex = 110
        Me.LabelX1.Text = "Descripcion"
        '
        'txtIdprocedimiento
        '
        '
        '
        '
        Me.txtIdprocedimiento.Border.Class = "TextBoxBorder"
        Me.txtIdprocedimiento.Location = New System.Drawing.Point(84, 50)
        Me.txtIdprocedimiento.Name = "txtIdprocedimiento"
        Me.txtIdprocedimiento.Size = New System.Drawing.Size(72, 20)
        Me.txtIdprocedimiento.TabIndex = 109
        '
        'txtvalor_proc
        '
        Me.txtvalor_proc.EditValue = "0"
        Me.txtvalor_proc.Location = New System.Drawing.Point(221, 49)
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
        Me.txtvalor_proc.Size = New System.Drawing.Size(95, 21)
        Me.txtvalor_proc.TabIndex = 1
        '
        'lblCIni2_pre
        '
        Me.lblCIni2_pre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCIni2_pre.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblCIni2_pre.ForeColor = System.Drawing.Color.Navy
        Me.lblCIni2_pre.Location = New System.Drawing.Point(6, 50)
        Me.lblCIni2_pre.Name = "lblCIni2_pre"
        Me.lblCIni2_pre.Size = New System.Drawing.Size(72, 20)
        Me.lblCIni2_pre.TabIndex = 2
        Me.lblCIni2_pre.Text = "Codigo"
        '
        'lblNCuotasIni_cuota
        '
        Me.lblNCuotasIni_cuota.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNCuotasIni_cuota.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNCuotasIni_cuota.ForeColor = System.Drawing.Color.Navy
        Me.lblNCuotasIni_cuota.Location = New System.Drawing.Point(175, 50)
        Me.lblNCuotasIni_cuota.Name = "lblNCuotasIni_cuota"
        Me.lblNCuotasIni_cuota.Size = New System.Drawing.Size(40, 20)
        Me.lblNCuotasIni_cuota.TabIndex = 0
        Me.lblNCuotasIni_cuota.Text = "Valor"
        '
        'dgProcedimientosItems
        '
        Me.dgProcedimientosItems.AllowUserToAddRows = False
        Me.dgProcedimientosItems.AllowUserToDeleteRows = False
        Me.dgProcedimientosItems.AllowUserToResizeColumns = False
        Me.dgProcedimientosItems.AllowUserToResizeRows = False
        Me.dgProcedimientosItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgProcedimientosItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgProcedimientosItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgProcedimientosItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProcedimientosItems.EnableHeadersVisualStyles = False
        Me.dgProcedimientosItems.Location = New System.Drawing.Point(22, 201)
        Me.dgProcedimientosItems.MultiSelect = False
        Me.dgProcedimientosItems.Name = "dgProcedimientosItems"
        Me.dgProcedimientosItems.ReadOnly = True
        Me.dgProcedimientosItems.RowHeadersVisible = False
        Me.dgProcedimientosItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProcedimientosItems.Size = New System.Drawing.Size(488, 223)
        Me.dgProcedimientosItems.TabIndex = 94
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(22, 16)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(488, 23)
        Me.lblTituloVentana.TabIndex = 93
        Me.lblTituloVentana.Text = "VALOR DE ITEMS Y PROCEDIMIENTOS"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmProcedimientosItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProcedimientosItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Procedimientos & Items"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpEspecialidades.ResumeLayout(False)
        Me.gpEstadoCuenta.ResumeLayout(False)
        CType(Me.txtvalor_proc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProcedimientosItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgProcedimientosItems As System.Windows.Forms.DataGridView
    Friend WithEvents gpEstadoCuenta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblCIni2_pre As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdprocedimiento As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtdescripcion_proc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtreferencia_proc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtvalor_proc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNCuotasIni_cuota As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpEspecialidades As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbEspecialidades As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
End Class
