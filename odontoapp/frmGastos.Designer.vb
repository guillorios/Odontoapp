<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGastos))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.gpGastos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtobservacion_gas = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblobservacion_gas = New DevComponents.DotNetBar.LabelX
        Me.txtconcepto_gas = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblconcepto_gas = New DevComponents.DotNetBar.LabelX
        Me.txtIdgasto = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblIdgasto = New DevComponents.DotNetBar.LabelX
        Me.dgGastos = New System.Windows.Forms.DataGridView
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpGastos.SuspendLayout()
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.gpGastos)
        Me.RibbonClientPanel1.Controls.Add(Me.dgGastos)
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
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(218, 431)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 39)
        Me.btnNuevo.TabIndex = 154
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(120, 431)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 39)
        Me.btnModificar.TabIndex = 153
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(414, 431)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 156
        Me.btnSalir.Text = "SALIR"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(316, 431)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 39)
        Me.btnEliminar.TabIndex = 155
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(22, 431)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnAdicionar.TabIndex = 152
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'gpGastos
        '
        Me.gpGastos.BackColor = System.Drawing.Color.Transparent
        Me.gpGastos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpGastos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpGastos.Controls.Add(Me.txtobservacion_gas)
        Me.gpGastos.Controls.Add(Me.lblobservacion_gas)
        Me.gpGastos.Controls.Add(Me.txtconcepto_gas)
        Me.gpGastos.Controls.Add(Me.lblconcepto_gas)
        Me.gpGastos.Controls.Add(Me.txtIdgasto)
        Me.gpGastos.Controls.Add(Me.lblIdgasto)
        Me.gpGastos.Location = New System.Drawing.Point(22, 327)
        Me.gpGastos.Name = "gpGastos"
        Me.gpGastos.Size = New System.Drawing.Size(488, 96)
        '
        '
        '
        Me.gpGastos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpGastos.Style.BackColorGradientAngle = 90
        Me.gpGastos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpGastos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGastos.Style.BorderBottomWidth = 1
        Me.gpGastos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpGastos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGastos.Style.BorderLeftWidth = 1
        Me.gpGastos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGastos.Style.BorderRightWidth = 1
        Me.gpGastos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGastos.Style.BorderTopWidth = 1
        Me.gpGastos.Style.CornerDiameter = 4
        Me.gpGastos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpGastos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpGastos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpGastos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpGastos.TabIndex = 151
        Me.gpGastos.Tag = ""
        Me.gpGastos.Text = "Datos Items de Gastos"
        '
        'txtobservacion_gas
        '
        '
        '
        '
        Me.txtobservacion_gas.Border.Class = "TextBoxBorder"
        Me.txtobservacion_gas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobservacion_gas.Location = New System.Drawing.Point(84, 51)
        Me.txtobservacion_gas.Name = "txtobservacion_gas"
        Me.txtobservacion_gas.Size = New System.Drawing.Size(383, 20)
        Me.txtobservacion_gas.TabIndex = 113
        '
        'lblobservacion_gas
        '
        Me.lblobservacion_gas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblobservacion_gas.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblobservacion_gas.ForeColor = System.Drawing.Color.Navy
        Me.lblobservacion_gas.Location = New System.Drawing.Point(6, 51)
        Me.lblobservacion_gas.Name = "lblobservacion_gas"
        Me.lblobservacion_gas.Size = New System.Drawing.Size(72, 20)
        Me.lblobservacion_gas.TabIndex = 112
        Me.lblobservacion_gas.Text = "Observacion"
        '
        'txtconcepto_gas
        '
        '
        '
        '
        Me.txtconcepto_gas.Border.Class = "TextBoxBorder"
        Me.txtconcepto_gas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconcepto_gas.Location = New System.Drawing.Point(84, 28)
        Me.txtconcepto_gas.Name = "txtconcepto_gas"
        Me.txtconcepto_gas.Size = New System.Drawing.Size(383, 20)
        Me.txtconcepto_gas.TabIndex = 111
        '
        'lblconcepto_gas
        '
        Me.lblconcepto_gas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblconcepto_gas.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblconcepto_gas.ForeColor = System.Drawing.Color.Navy
        Me.lblconcepto_gas.Location = New System.Drawing.Point(6, 28)
        Me.lblconcepto_gas.Name = "lblconcepto_gas"
        Me.lblconcepto_gas.Size = New System.Drawing.Size(72, 20)
        Me.lblconcepto_gas.TabIndex = 110
        Me.lblconcepto_gas.Text = "Concepto"
        '
        'txtIdgasto
        '
        '
        '
        '
        Me.txtIdgasto.Border.Class = "TextBoxBorder"
        Me.txtIdgasto.Location = New System.Drawing.Point(84, 4)
        Me.txtIdgasto.Name = "txtIdgasto"
        Me.txtIdgasto.Size = New System.Drawing.Size(72, 20)
        Me.txtIdgasto.TabIndex = 109
        '
        'lblIdgasto
        '
        Me.lblIdgasto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblIdgasto.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblIdgasto.ForeColor = System.Drawing.Color.Navy
        Me.lblIdgasto.Location = New System.Drawing.Point(6, 4)
        Me.lblIdgasto.Name = "lblIdgasto"
        Me.lblIdgasto.Size = New System.Drawing.Size(72, 20)
        Me.lblIdgasto.TabIndex = 2
        Me.lblIdgasto.Text = "Codigo"
        '
        'dgGastos
        '
        Me.dgGastos.AllowUserToAddRows = False
        Me.dgGastos.AllowUserToDeleteRows = False
        Me.dgGastos.AllowUserToResizeColumns = False
        Me.dgGastos.AllowUserToResizeRows = False
        Me.dgGastos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGastos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGastos.EnableHeadersVisualStyles = False
        Me.dgGastos.Location = New System.Drawing.Point(22, 54)
        Me.dgGastos.MultiSelect = False
        Me.dgGastos.Name = "dgGastos"
        Me.dgGastos.ReadOnly = True
        Me.dgGastos.RowHeadersVisible = False
        Me.dgGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGastos.Size = New System.Drawing.Size(488, 267)
        Me.dgGastos.TabIndex = 150
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(22, 17)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(488, 23)
        Me.lblTituloVentana.TabIndex = 149
        Me.lblTituloVentana.Text = "CREACION DE ITMES DE GASTOS"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gastos"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpGastos.ResumeLayout(False)
        CType(Me.dgGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpGastos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtobservacion_gas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblobservacion_gas As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtconcepto_gas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblconcepto_gas As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdgasto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblIdgasto As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgGastos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
