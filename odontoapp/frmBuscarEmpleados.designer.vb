<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarEmpleados))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblNomBusqueda = New DevComponents.DotNetBar.LabelX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.listaResultados = New System.Windows.Forms.ListBox
        Me.btnEditar = New DevComponents.DotNetBar.ButtonX
        Me.txtBusqueda = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.txtCount_Emp = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTotalUsuarios = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.gpOpcionBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtXCodigo = New System.Windows.Forms.RadioButton
        Me.rbtXApellido = New System.Windows.Forms.RadioButton
        Me.rbtXNombre = New System.Windows.Forms.RadioButton
        Me.dgEmpleados = New System.Windows.Forms.DataGridView
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpOpcionBusqueda.SuspendLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.lblNomBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.listaResultados)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEditar)
        Me.RibbonClientPanel1.Controls.Add(Me.txtBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSeleccionar)
        Me.RibbonClientPanel1.Controls.Add(Me.txtCount_Emp)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTotalUsuarios)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
        Me.RibbonClientPanel1.Controls.Add(Me.gpOpcionBusqueda)
        Me.RibbonClientPanel1.Controls.Add(Me.dgEmpleados)
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
        'lblNomBusqueda
        '
        Me.lblNomBusqueda.BackColor = System.Drawing.Color.LightBlue
        Me.lblNomBusqueda.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomBusqueda.ForeColor = System.Drawing.Color.Navy
        Me.lblNomBusqueda.Location = New System.Drawing.Point(12, 111)
        Me.lblNomBusqueda.Name = "lblNomBusqueda"
        Me.lblNomBusqueda.Size = New System.Drawing.Size(72, 28)
        Me.lblNomBusqueda.TabIndex = 108
        Me.lblNomBusqueda.Text = "Nombre"
        Me.lblNomBusqueda.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(432, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnSalir.TabIndex = 104
        Me.btnSalir.Text = "SALIR"
        '
        'listaResultados
        '
        Me.listaResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaResultados.FormattingEnabled = True
        Me.listaResultados.ItemHeight = 16
        Me.listaResultados.Location = New System.Drawing.Point(12, 143)
        Me.listaResultados.Name = "listaResultados"
        Me.listaResultados.Size = New System.Drawing.Size(429, 68)
        Me.listaResultados.TabIndex = 105
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.Enabled = False
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(336, 435)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 39)
        Me.btnEditar.TabIndex = 106
        Me.btnEditar.Tag = "1"
        Me.btnEditar.Text = "EDITAR"
        '
        'txtBusqueda
        '
        '
        '
        '
        Me.txtBusqueda.Border.Class = "TextBoxBorder"
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(90, 112)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(432, 25)
        Me.txtBusqueda.TabIndex = 101
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.Location = New System.Drawing.Point(447, 143)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 69)
        Me.btnSeleccionar.TabIndex = 107
        Me.btnSeleccionar.Tag = "1"
        Me.btnSeleccionar.Tooltip = "SELECCIONAR"
        '
        'txtCount_Emp
        '
        Me.txtCount_Emp.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCount_Emp.Border.Class = "TextBoxBorder"
        Me.txtCount_Emp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount_Emp.Location = New System.Drawing.Point(145, 444)
        Me.txtCount_Emp.Name = "txtCount_Emp"
        Me.txtCount_Emp.ReadOnly = True
        Me.txtCount_Emp.Size = New System.Drawing.Size(72, 20)
        Me.txtCount_Emp.TabIndex = 96
        Me.txtCount_Emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalUsuarios
        '
        Me.lblTotalUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblTotalUsuarios.Location = New System.Drawing.Point(12, 444)
        Me.lblTotalUsuarios.Name = "lblTotalUsuarios"
        Me.lblTotalUsuarios.Size = New System.Drawing.Size(127, 20)
        Me.lblTotalUsuarios.TabIndex = 95
        Me.lblTotalUsuarios.Text = "TOTAL USUARIOS"
        Me.lblTotalUsuarios.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(12, 16)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(510, 23)
        Me.lblTituloVentana.TabIndex = 99
        Me.lblTituloVentana.Text = "BUSQUEDA EMPLEADOS"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpOpcionBusqueda
        '
        Me.gpOpcionBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXCodigo)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXApellido)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXNombre)
        Me.gpOpcionBusqueda.Location = New System.Drawing.Point(12, 45)
        Me.gpOpcionBusqueda.Name = "gpOpcionBusqueda"
        Me.gpOpcionBusqueda.Size = New System.Drawing.Size(510, 61)
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
        Me.gpOpcionBusqueda.TabIndex = 94
        Me.gpOpcionBusqueda.Text = "Opción Busqueda"
        '
        'rbtXCodigo
        '
        Me.rbtXCodigo.AutoSize = True
        Me.rbtXCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXCodigo.Location = New System.Drawing.Point(365, 12)
        Me.rbtXCodigo.Name = "rbtXCodigo"
        Me.rbtXCodigo.Size = New System.Drawing.Size(136, 21)
        Me.rbtXCodigo.TabIndex = 2
        Me.rbtXCodigo.Text = "Por No. Codigo"
        Me.rbtXCodigo.UseVisualStyleBackColor = True
        '
        'rbtXApellido
        '
        Me.rbtXApellido.AutoSize = True
        Me.rbtXApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXApellido.Location = New System.Drawing.Point(192, 12)
        Me.rbtXApellido.Name = "rbtXApellido"
        Me.rbtXApellido.Size = New System.Drawing.Size(114, 21)
        Me.rbtXApellido.TabIndex = 1
        Me.rbtXApellido.Text = "Por Apellido"
        Me.rbtXApellido.UseVisualStyleBackColor = True
        '
        'rbtXNombre
        '
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
        'dgEmpleados
        '
        Me.dgEmpleados.AllowUserToAddRows = False
        Me.dgEmpleados.AllowUserToDeleteRows = False
        Me.dgEmpleados.AllowUserToOrderColumns = True
        Me.dgEmpleados.AllowUserToResizeColumns = False
        Me.dgEmpleados.AllowUserToResizeRows = False
        Me.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmpleados.EnableHeadersVisualStyles = False
        Me.dgEmpleados.Location = New System.Drawing.Point(12, 218)
        Me.dgEmpleados.Name = "dgEmpleados"
        Me.dgEmpleados.RowHeadersVisible = False
        Me.dgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEmpleados.Size = New System.Drawing.Size(510, 205)
        Me.dgEmpleados.TabIndex = 103
        '
        'frmBuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Buscar Empleados"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpOpcionBusqueda.ResumeLayout(False)
        Me.gpOpcionBusqueda.PerformLayout()
        CType(Me.dgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents listaResultados As System.Windows.Forms.ListBox
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpOpcionBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtXCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXApellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXNombre As System.Windows.Forms.RadioButton
    Friend WithEvents txtCount_Emp As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTotalUsuarios As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNomBusqueda As DevComponents.DotNetBar.LabelX
End Class
