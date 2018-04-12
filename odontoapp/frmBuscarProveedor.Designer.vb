<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarProveedor))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.gpOpcionBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtXCodigo = New System.Windows.Forms.RadioButton
        Me.rbtXContacto = New System.Windows.Forms.RadioButton
        Me.rbtXNombre = New System.Windows.Forms.RadioButton
        Me.lblNomBusqueda = New DevComponents.DotNetBar.LabelX
        Me.txtCount_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.lblTotalProveedores = New DevComponents.DotNetBar.LabelX
        Me.btnEditar = New DevComponents.DotNetBar.ButtonX
        Me.listaResultados = New System.Windows.Forms.ListBox
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.dgProveedores = New System.Windows.Forms.DataGridView
        Me.txtBusqueda = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpOpcionBusqueda.SuspendLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.gpOpcionBusqueda)
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
        'gpOpcionBusqueda
        '
        Me.gpOpcionBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXCodigo)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXContacto)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXNombre)
        Me.gpOpcionBusqueda.Location = New System.Drawing.Point(14, 45)
        Me.gpOpcionBusqueda.Name = "gpOpcionBusqueda"
        Me.gpOpcionBusqueda.Size = New System.Drawing.Size(504, 61)
        '
        '
        '
        Me.gpOpcionBusqueda.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpOpcionBusqueda.Style.BackColorGradientAngle = 90
        Me.gpOpcionBusqueda.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpOpcionBusqueda.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionBusqueda.Style.BorderBottomWidth = 1
        Me.gpOpcionBusqueda.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpOpcionBusqueda.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionBusqueda.Style.BorderLeftWidth = 1
        Me.gpOpcionBusqueda.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionBusqueda.Style.BorderRightWidth = 1
        Me.gpOpcionBusqueda.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionBusqueda.Style.BorderTopWidth = 1
        Me.gpOpcionBusqueda.Style.CornerDiameter = 4
        Me.gpOpcionBusqueda.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpOpcionBusqueda.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpOpcionBusqueda.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpOpcionBusqueda.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpOpcionBusqueda.TabIndex = 116
        Me.gpOpcionBusqueda.Text = "Opción Busqueda"
        '
        'rbtXCodigo
        '
        Me.rbtXCodigo.AutoSize = True
        Me.rbtXCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXCodigo.Location = New System.Drawing.Point(351, 12)
        Me.rbtXCodigo.Name = "rbtXCodigo"
        Me.rbtXCodigo.Size = New System.Drawing.Size(136, 21)
        Me.rbtXCodigo.TabIndex = 2
        Me.rbtXCodigo.Text = "Por No. Codigo"
        Me.rbtXCodigo.UseVisualStyleBackColor = True
        '
        'rbtXContacto
        '
        Me.rbtXContacto.AutoSize = True
        Me.rbtXContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXContacto.Location = New System.Drawing.Point(184, 12)
        Me.rbtXContacto.Name = "rbtXContacto"
        Me.rbtXContacto.Size = New System.Drawing.Size(120, 21)
        Me.rbtXContacto.TabIndex = 1
        Me.rbtXContacto.Text = "Por Contacto"
        Me.rbtXContacto.UseVisualStyleBackColor = True
        '
        'rbtXNombre
        '
        Me.rbtXNombre.AutoSize = True
        Me.rbtXNombre.Checked = True
        Me.rbtXNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXNombre.Location = New System.Drawing.Point(21, 14)
        Me.rbtXNombre.Name = "rbtXNombre"
        Me.rbtXNombre.Size = New System.Drawing.Size(112, 21)
        Me.rbtXNombre.TabIndex = 0
        Me.rbtXNombre.TabStop = True
        Me.rbtXNombre.Text = "Por Nombre"
        Me.rbtXNombre.UseVisualStyleBackColor = True
        '
        'lblNomBusqueda
        '
        Me.lblNomBusqueda.BackColor = System.Drawing.Color.LightBlue
        Me.lblNomBusqueda.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomBusqueda.ForeColor = System.Drawing.Color.Navy
        Me.lblNomBusqueda.Location = New System.Drawing.Point(14, 114)
        Me.lblNomBusqueda.Name = "lblNomBusqueda"
        Me.lblNomBusqueda.Size = New System.Drawing.Size(72, 26)
        Me.lblNomBusqueda.TabIndex = 126
        Me.lblNomBusqueda.Text = "Nombre"
        Me.lblNomBusqueda.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCount_ent
        '
        Me.txtCount_ent.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCount_ent.Border.Class = "TextBoxBorder"
        Me.txtCount_ent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount_ent.Location = New System.Drawing.Point(147, 445)
        Me.txtCount_ent.Name = "txtCount_ent"
        Me.txtCount_ent.ReadOnly = True
        Me.txtCount_ent.Size = New System.Drawing.Size(72, 20)
        Me.txtCount_ent.TabIndex = 119
        Me.txtCount_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.Location = New System.Drawing.Point(432, 146)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(86, 69)
        Me.btnSeleccionar.TabIndex = 125
        Me.btnSeleccionar.Tag = "1"
        Me.btnSeleccionar.Tooltip = "SELECCIONAR"
        '
        'lblTotalProveedores
        '
        Me.lblTotalProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProveedores.ForeColor = System.Drawing.Color.White
        Me.lblTotalProveedores.Location = New System.Drawing.Point(14, 445)
        Me.lblTotalProveedores.Name = "lblTotalProveedores"
        Me.lblTotalProveedores.Size = New System.Drawing.Size(127, 20)
        Me.lblTotalProveedores.TabIndex = 118
        Me.lblTotalProveedores.Text = "TOTAL ENTIDADES"
        Me.lblTotalProveedores.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.Enabled = False
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(332, 435)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 39)
        Me.btnEditar.TabIndex = 124
        Me.btnEditar.Tag = "1"
        Me.btnEditar.Text = "EDITAR"
        '
        'listaResultados
        '
        Me.listaResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaResultados.FormattingEnabled = True
        Me.listaResultados.ItemHeight = 16
        Me.listaResultados.Location = New System.Drawing.Point(14, 146)
        Me.listaResultados.Name = "listaResultados"
        Me.listaResultados.Size = New System.Drawing.Size(412, 68)
        Me.listaResultados.TabIndex = 123
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(428, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnSalir.TabIndex = 122
        Me.btnSalir.Text = "SALIR"
        '
        'dgProveedores
        '
        Me.dgProveedores.AllowUserToDeleteRows = False
        Me.dgProveedores.AllowUserToOrderColumns = True
        Me.dgProveedores.AllowUserToResizeColumns = False
        Me.dgProveedores.AllowUserToResizeRows = False
        Me.dgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgProveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProveedores.EnableHeadersVisualStyles = False
        Me.dgProveedores.Location = New System.Drawing.Point(14, 221)
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.RowHeadersVisible = False
        Me.dgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProveedores.Size = New System.Drawing.Size(504, 208)
        Me.dgProveedores.TabIndex = 121
        '
        'txtBusqueda
        '
        '
        '
        '
        Me.txtBusqueda.Border.Class = "TextBoxBorder"
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(92, 114)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(426, 26)
        Me.txtBusqueda.TabIndex = 120
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(14, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(504, 23)
        Me.lblTituloVentana.TabIndex = 117
        Me.lblTituloVentana.Text = "BUSQUEDA PROVEEDORES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmBuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.lblNomBusqueda)
        Me.Controls.Add(Me.txtCount_ent)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.lblTotalProveedores)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.listaResultados)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgProveedores)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.lblTituloVentana)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarProveedor"
        Me.Text = "Buscar Proveedor"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpOpcionBusqueda.ResumeLayout(False)
        Me.gpOpcionBusqueda.PerformLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpOpcionBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtXCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXContacto As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXNombre As System.Windows.Forms.RadioButton
    Friend WithEvents lblNomBusqueda As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCount_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTotalProveedores As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents listaResultados As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
End Class
