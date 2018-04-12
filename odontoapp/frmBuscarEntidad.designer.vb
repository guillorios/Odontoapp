<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEntidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarEntidad))
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblNomBusqueda = New DevComponents.DotNetBar.LabelX
        Me.txtCount_ent = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.lblTotaleEntidades = New DevComponents.DotNetBar.LabelX
        Me.btnEditar = New DevComponents.DotNetBar.ButtonX
        Me.listaResultados = New System.Windows.Forms.ListBox
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.dgEntidades = New System.Windows.Forms.DataGridView
        Me.txtBusqueda = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.gpOpcionBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtXCodigo = New System.Windows.Forms.RadioButton
        Me.rbtXContacto = New System.Windows.Forms.RadioButton
        Me.rbtXNombre = New System.Windows.Forms.RadioButton
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.dgEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpOpcionBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(12, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(504, 23)
        Me.lblTituloVentana.TabIndex = 83
        Me.lblTituloVentana.Text = "BUSQUEDA ENTIDADES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.lblNomBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.txtCount_ent)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSeleccionar)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTotaleEntidades)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEditar)
        Me.RibbonClientPanel1.Controls.Add(Me.listaResultados)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.dgEntidades)
        Me.RibbonClientPanel1.Controls.Add(Me.txtBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
        Me.RibbonClientPanel1.Controls.Add(Me.gpOpcionBusqueda)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
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
        'lblNomBusqueda
        '
        Me.lblNomBusqueda.BackColor = System.Drawing.Color.LightBlue
        Me.lblNomBusqueda.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomBusqueda.ForeColor = System.Drawing.Color.Navy
        Me.lblNomBusqueda.Location = New System.Drawing.Point(12, 114)
        Me.lblNomBusqueda.Name = "lblNomBusqueda"
        Me.lblNomBusqueda.Size = New System.Drawing.Size(72, 26)
        Me.lblNomBusqueda.TabIndex = 115
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
        Me.txtCount_ent.Location = New System.Drawing.Point(145, 445)
        Me.txtCount_ent.Name = "txtCount_ent"
        Me.txtCount_ent.ReadOnly = True
        Me.txtCount_ent.Size = New System.Drawing.Size(72, 20)
        Me.txtCount_ent.TabIndex = 102
        Me.txtCount_ent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.Location = New System.Drawing.Point(430, 146)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(86, 69)
        Me.btnSeleccionar.TabIndex = 114
        Me.btnSeleccionar.Tag = "1"
        Me.btnSeleccionar.Tooltip = "SELECCIONAR"
        '
        'lblTotaleEntidades
        '
        Me.lblTotaleEntidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotaleEntidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotaleEntidades.ForeColor = System.Drawing.Color.White
        Me.lblTotaleEntidades.Location = New System.Drawing.Point(12, 445)
        Me.lblTotaleEntidades.Name = "lblTotaleEntidades"
        Me.lblTotaleEntidades.Size = New System.Drawing.Size(127, 20)
        Me.lblTotaleEntidades.TabIndex = 101
        Me.lblTotaleEntidades.Text = "TOTAL ENTIDADES"
        Me.lblTotaleEntidades.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.Enabled = False
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(330, 435)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 39)
        Me.btnEditar.TabIndex = 113
        Me.btnEditar.Tag = "1"
        Me.btnEditar.Text = "EDITAR"
        '
        'listaResultados
        '
        Me.listaResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaResultados.FormattingEnabled = True
        Me.listaResultados.ItemHeight = 16
        Me.listaResultados.Location = New System.Drawing.Point(12, 146)
        Me.listaResultados.Name = "listaResultados"
        Me.listaResultados.Size = New System.Drawing.Size(412, 68)
        Me.listaResultados.TabIndex = 112
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(426, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnSalir.TabIndex = 111
        Me.btnSalir.Text = "SALIR"
        '
        'dgEntidades
        '
        Me.dgEntidades.AllowUserToDeleteRows = False
        Me.dgEntidades.AllowUserToOrderColumns = True
        Me.dgEntidades.AllowUserToResizeColumns = False
        Me.dgEntidades.AllowUserToResizeRows = False
        Me.dgEntidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgEntidades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEntidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgEntidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEntidades.EnableHeadersVisualStyles = False
        Me.dgEntidades.Location = New System.Drawing.Point(12, 221)
        Me.dgEntidades.Name = "dgEntidades"
        Me.dgEntidades.RowHeadersVisible = False
        Me.dgEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEntidades.Size = New System.Drawing.Size(504, 208)
        Me.dgEntidades.TabIndex = 110
        '
        'txtBusqueda
        '
        '
        '
        '
        Me.txtBusqueda.Border.Class = "TextBoxBorder"
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(90, 114)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(426, 26)
        Me.txtBusqueda.TabIndex = 109
        '
        'gpOpcionBusqueda
        '
        Me.gpOpcionBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXCodigo)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXContacto)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXNombre)
        Me.gpOpcionBusqueda.Location = New System.Drawing.Point(12, 47)
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
        Me.gpOpcionBusqueda.TabIndex = 78
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
        Me.rbtXNombre.Location = New System.Drawing.Point(21, 12)
        Me.rbtXNombre.Name = "rbtXNombre"
        Me.rbtXNombre.Size = New System.Drawing.Size(112, 21)
        Me.rbtXNombre.TabIndex = 0
        Me.rbtXNombre.TabStop = True
        Me.rbtXNombre.Text = "Por Nombre"
        Me.rbtXNombre.UseVisualStyleBackColor = True
        '
        'frmBuscarEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarEntidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Buscar Entidad"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.dgEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpOpcionBusqueda.ResumeLayout(False)
        Me.gpOpcionBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpOpcionBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtXCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXContacto As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXNombre As System.Windows.Forms.RadioButton
    Friend WithEvents btnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents listaResultados As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgEntidades As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCount_ent As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTotaleEntidades As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNomBusqueda As DevComponents.DotNetBar.LabelX
End Class
