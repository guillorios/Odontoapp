<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDoctores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarDoctores))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.txtCount_doc = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTotalDoctores = New DevComponents.DotNetBar.LabelX
        Me.btnSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.btnEditar = New DevComponents.DotNetBar.ButtonX
        Me.listaResultados = New System.Windows.Forms.ListBox
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.dgDoctores = New System.Windows.Forms.DataGridView
        Me.gpOpcionBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtXCodigo = New System.Windows.Forms.RadioButton
        Me.rbtXApellido = New System.Windows.Forms.RadioButton
        Me.rbtXNombre = New System.Windows.Forms.RadioButton
        Me.txtBusqueda = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblNomBusqueda = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.dgDoctores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpOpcionBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.txtCount_doc)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTotalDoctores)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSeleccionar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEditar)
        Me.RibbonClientPanel1.Controls.Add(Me.listaResultados)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.dgDoctores)
        Me.RibbonClientPanel1.Controls.Add(Me.gpOpcionBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.txtBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.lblNomBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
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
        'txtCount_doc
        '
        Me.txtCount_doc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCount_doc.Border.Class = "TextBoxBorder"
        Me.txtCount_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount_doc.Location = New System.Drawing.Point(145, 443)
        Me.txtCount_doc.Name = "txtCount_doc"
        Me.txtCount_doc.ReadOnly = True
        Me.txtCount_doc.Size = New System.Drawing.Size(72, 20)
        Me.txtCount_doc.TabIndex = 100
        Me.txtCount_doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalDoctores
        '
        Me.lblTotalDoctores.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalDoctores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDoctores.ForeColor = System.Drawing.Color.White
        Me.lblTotalDoctores.Location = New System.Drawing.Point(12, 443)
        Me.lblTotalDoctores.Name = "lblTotalDoctores"
        Me.lblTotalDoctores.Size = New System.Drawing.Size(127, 20)
        Me.lblTotalDoctores.TabIndex = 99
        Me.lblTotalDoctores.Text = "TOTAL DOCTORES"
        Me.lblTotalDoctores.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.Location = New System.Drawing.Point(446, 140)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(74, 69)
        Me.btnSeleccionar.TabIndex = 98
        Me.btnSeleccionar.Tag = "1"
        Me.btnSeleccionar.Tooltip = "SELECCIONAR"
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.Enabled = False
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(334, 434)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 39)
        Me.btnEditar.TabIndex = 97
        Me.btnEditar.Tag = "1"
        Me.btnEditar.Text = "EDITAR"
        '
        'listaResultados
        '
        Me.listaResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaResultados.FormattingEnabled = True
        Me.listaResultados.ItemHeight = 16
        Me.listaResultados.Location = New System.Drawing.Point(12, 140)
        Me.listaResultados.Name = "listaResultados"
        Me.listaResultados.Size = New System.Drawing.Size(428, 68)
        Me.listaResultados.TabIndex = 96
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(430, 434)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnSalir.TabIndex = 95
        Me.btnSalir.Text = "SALIR"
        '
        'dgDoctores
        '
        Me.dgDoctores.AllowUserToDeleteRows = False
        Me.dgDoctores.AllowUserToOrderColumns = True
        Me.dgDoctores.AllowUserToResizeColumns = False
        Me.dgDoctores.AllowUserToResizeRows = False
        Me.dgDoctores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgDoctores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDoctores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDoctores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDoctores.EnableHeadersVisualStyles = False
        Me.dgDoctores.Location = New System.Drawing.Point(12, 215)
        Me.dgDoctores.Name = "dgDoctores"
        Me.dgDoctores.RowHeadersVisible = False
        Me.dgDoctores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDoctores.Size = New System.Drawing.Size(508, 213)
        Me.dgDoctores.TabIndex = 94
        '
        'gpOpcionBusqueda
        '
        Me.gpOpcionBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXCodigo)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXApellido)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXNombre)
        Me.gpOpcionBusqueda.Location = New System.Drawing.Point(12, 39)
        Me.gpOpcionBusqueda.Name = "gpOpcionBusqueda"
        Me.gpOpcionBusqueda.Size = New System.Drawing.Size(508, 61)
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
        Me.gpOpcionBusqueda.TabIndex = 93
        Me.gpOpcionBusqueda.Text = "Opción Busqueda"
        '
        'rbtXCodigo
        '
        Me.rbtXCodigo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtXCodigo.AutoSize = True
        Me.rbtXCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXCodigo.Location = New System.Drawing.Point(347, 12)
        Me.rbtXCodigo.Name = "rbtXCodigo"
        Me.rbtXCodigo.Size = New System.Drawing.Size(136, 21)
        Me.rbtXCodigo.TabIndex = 2
        Me.rbtXCodigo.Text = "Por No. Codigo"
        Me.rbtXCodigo.UseVisualStyleBackColor = True
        '
        'rbtXApellido
        '
        Me.rbtXApellido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtXApellido.AutoSize = True
        Me.rbtXApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXApellido.Location = New System.Drawing.Point(178, 12)
        Me.rbtXApellido.Name = "rbtXApellido"
        Me.rbtXApellido.Size = New System.Drawing.Size(114, 21)
        Me.rbtXApellido.TabIndex = 1
        Me.rbtXApellido.Text = "Por Apellido"
        Me.rbtXApellido.UseVisualStyleBackColor = True
        '
        'rbtXNombre
        '
        Me.rbtXNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtXNombre.AutoSize = True
        Me.rbtXNombre.Checked = True
        Me.rbtXNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXNombre.Location = New System.Drawing.Point(18, 12)
        Me.rbtXNombre.Name = "rbtXNombre"
        Me.rbtXNombre.Size = New System.Drawing.Size(112, 21)
        Me.rbtXNombre.TabIndex = 0
        Me.rbtXNombre.TabStop = True
        Me.rbtXNombre.Text = "Por Nombre"
        Me.rbtXNombre.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        '
        '
        '
        Me.txtBusqueda.Border.Class = "TextBoxBorder"
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(90, 106)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(430, 28)
        Me.txtBusqueda.TabIndex = 92
        '
        'lblNomBusqueda
        '
        Me.lblNomBusqueda.BackColor = System.Drawing.Color.LightBlue
        Me.lblNomBusqueda.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomBusqueda.ForeColor = System.Drawing.Color.Navy
        Me.lblNomBusqueda.Location = New System.Drawing.Point(12, 106)
        Me.lblNomBusqueda.Name = "lblNomBusqueda"
        Me.lblNomBusqueda.Size = New System.Drawing.Size(72, 28)
        Me.lblNomBusqueda.TabIndex = 91
        Me.lblNomBusqueda.Text = "Nombre"
        Me.lblNomBusqueda.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(12, 10)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(508, 23)
        Me.lblTituloVentana.TabIndex = 83
        Me.lblTituloVentana.Text = "BUSQUEDA DOCTORES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmBuscarDoctores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarDoctores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Buscar Doctores"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.dgDoctores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpOpcionBusqueda.ResumeLayout(False)
        Me.gpOpcionBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents listaResultados As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgDoctores As System.Windows.Forms.DataGridView
    Friend WithEvents gpOpcionBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtXCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXApellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXNombre As System.Windows.Forms.RadioButton
    Friend WithEvents txtBusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblNomBusqueda As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCount_doc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTotalDoctores As DevComponents.DotNetBar.LabelX
End Class
