Imports System.Math
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarPacientes))
        Me.RibbonClientPanel = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblNomBusqueda = New DevComponents.DotNetBar.LabelX
        Me.txtCount_pac = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTotalPacientes = New DevComponents.DotNetBar.LabelX
        Me.btnSeleccionar = New DevComponents.DotNetBar.ButtonX
        Me.btnEditar = New DevComponents.DotNetBar.ButtonX
        Me.listaResultados = New System.Windows.Forms.ListBox
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.dgPacientes = New System.Windows.Forms.DataGridView
        Me.gpOpcionBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtXApellidos = New System.Windows.Forms.RadioButton
        Me.rbtXHistoria = New System.Windows.Forms.RadioButton
        Me.rbtXCodigo = New System.Windows.Forms.RadioButton
        Me.rbtXDocumento = New System.Windows.Forms.RadioButton
        Me.rbtXNombres = New System.Windows.Forms.RadioButton
        Me.txtBusqueda = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.RibbonClientPanel.SuspendLayout()
        CType(Me.dgPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpOpcionBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel
        '
        Me.RibbonClientPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel.Controls.Add(Me.lblNomBusqueda)
        Me.RibbonClientPanel.Controls.Add(Me.txtCount_pac)
        Me.RibbonClientPanel.Controls.Add(Me.lblTotalPacientes)
        Me.RibbonClientPanel.Controls.Add(Me.btnSeleccionar)
        Me.RibbonClientPanel.Controls.Add(Me.btnEditar)
        Me.RibbonClientPanel.Controls.Add(Me.listaResultados)
        Me.RibbonClientPanel.Controls.Add(Me.lblTituloVentana)
        Me.RibbonClientPanel.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel.Controls.Add(Me.dgPacientes)
        Me.RibbonClientPanel.Controls.Add(Me.gpOpcionBusqueda)
        Me.RibbonClientPanel.Controls.Add(Me.txtBusqueda)
        Me.RibbonClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel.Name = "RibbonClientPanel"
        Me.RibbonClientPanel.Size = New System.Drawing.Size(532, 486)
        '
        '
        '
        Me.RibbonClientPanel.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel.TabIndex = 0
        Me.RibbonClientPanel.Text = "RibbonClientPanel1"
        '
        'lblNomBusqueda
        '
        Me.lblNomBusqueda.BackColor = System.Drawing.Color.LightBlue
        Me.lblNomBusqueda.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblNomBusqueda.ForeColor = System.Drawing.Color.Navy
        Me.lblNomBusqueda.Location = New System.Drawing.Point(12, 111)
        Me.lblNomBusqueda.Name = "lblNomBusqueda"
        Me.lblNomBusqueda.Size = New System.Drawing.Size(72, 28)
        Me.lblNomBusqueda.TabIndex = 2
        Me.lblNomBusqueda.Text = "Nombre"
        Me.lblNomBusqueda.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtCount_pac
        '
        Me.txtCount_pac.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCount_pac.Border.Class = "TextBoxBorder"
        Me.txtCount_pac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCount_pac.Location = New System.Drawing.Point(145, 444)
        Me.txtCount_pac.Name = "txtCount_pac"
        Me.txtCount_pac.ReadOnly = True
        Me.txtCount_pac.Size = New System.Drawing.Size(72, 20)
        Me.txtCount_pac.TabIndex = 8
        Me.txtCount_pac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalPacientes
        '
        Me.lblTotalPacientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPacientes.ForeColor = System.Drawing.Color.White
        Me.lblTotalPacientes.Location = New System.Drawing.Point(12, 444)
        Me.lblTotalPacientes.Name = "lblTotalPacientes"
        Me.lblTotalPacientes.Size = New System.Drawing.Size(127, 20)
        Me.lblTotalPacientes.TabIndex = 7
        Me.lblTotalPacientes.Text = "TOTAL PACIENTES"
        Me.lblTotalPacientes.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.Location = New System.Drawing.Point(441, 145)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 69)
        Me.btnSeleccionar.TabIndex = 5
        Me.btnSeleccionar.Tag = "1"
        Me.btnSeleccionar.Tooltip = "SELECCIONAR"
        '
        'btnEditar
        '
        Me.btnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditar.Enabled = False
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(331, 435)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(90, 39)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Tag = "1"
        Me.btnEditar.Text = "EDITAR"
        '
        'listaResultados
        '
        Me.listaResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaResultados.FormattingEnabled = True
        Me.listaResultados.ItemHeight = 16
        Me.listaResultados.Location = New System.Drawing.Point(12, 145)
        Me.listaResultados.Name = "listaResultados"
        Me.listaResultados.Size = New System.Drawing.Size(423, 68)
        Me.listaResultados.TabIndex = 4
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(12, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(504, 23)
        Me.lblTituloVentana.TabIndex = 0
        Me.lblTituloVentana.Text = "BUSQUEDA PACIENTES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(427, 435)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        '
        'dgPacientes
        '
        Me.dgPacientes.AllowUserToAddRows = False
        Me.dgPacientes.AllowUserToDeleteRows = False
        Me.dgPacientes.AllowUserToOrderColumns = True
        Me.dgPacientes.AllowUserToResizeColumns = False
        Me.dgPacientes.AllowUserToResizeRows = False
        Me.dgPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgPacientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPacientes.EnableHeadersVisualStyles = False
        Me.dgPacientes.Location = New System.Drawing.Point(12, 220)
        Me.dgPacientes.Name = "dgPacientes"
        Me.dgPacientes.ReadOnly = True
        Me.dgPacientes.RowHeadersVisible = False
        Me.dgPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPacientes.Size = New System.Drawing.Size(504, 209)
        Me.dgPacientes.TabIndex = 6
        '
        'gpOpcionBusqueda
        '
        Me.gpOpcionBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXApellidos)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXHistoria)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXCodigo)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXDocumento)
        Me.gpOpcionBusqueda.Controls.Add(Me.rbtXNombres)
        Me.gpOpcionBusqueda.Location = New System.Drawing.Point(12, 41)
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
        Me.gpOpcionBusqueda.TabIndex = 1
        Me.gpOpcionBusqueda.Text = "Opción Busqueda"
        '
        'rbtXApellidos
        '
        Me.rbtXApellidos.AutoSize = True
        Me.rbtXApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXApellidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXApellidos.Location = New System.Drawing.Point(314, 17)
        Me.rbtXApellidos.Name = "rbtXApellidos"
        Me.rbtXApellidos.Size = New System.Drawing.Size(92, 21)
        Me.rbtXApellidos.TabIndex = 4
        Me.rbtXApellidos.Text = "Apellidos"
        Me.rbtXApellidos.UseVisualStyleBackColor = True
        '
        'rbtXHistoria
        '
        Me.rbtXHistoria.AutoSize = True
        Me.rbtXHistoria.Checked = True
        Me.rbtXHistoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXHistoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXHistoria.Location = New System.Drawing.Point(3, 15)
        Me.rbtXHistoria.Name = "rbtXHistoria"
        Me.rbtXHistoria.Size = New System.Drawing.Size(96, 21)
        Me.rbtXHistoria.TabIndex = 0
        Me.rbtXHistoria.TabStop = True
        Me.rbtXHistoria.Text = "# Historia"
        Me.rbtXHistoria.UseVisualStyleBackColor = True
        '
        'rbtXCodigo
        '
        Me.rbtXCodigo.AutoSize = True
        Me.rbtXCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXCodigo.Location = New System.Drawing.Point(420, 16)
        Me.rbtXCodigo.Name = "rbtXCodigo"
        Me.rbtXCodigo.Size = New System.Drawing.Size(76, 21)
        Me.rbtXCodigo.TabIndex = 3
        Me.rbtXCodigo.Text = "Código"
        Me.rbtXCodigo.UseVisualStyleBackColor = True
        '
        'rbtXDocumento
        '
        Me.rbtXDocumento.AutoSize = True
        Me.rbtXDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXDocumento.Location = New System.Drawing.Point(99, 16)
        Me.rbtXDocumento.Name = "rbtXDocumento"
        Me.rbtXDocumento.Size = New System.Drawing.Size(107, 21)
        Me.rbtXDocumento.TabIndex = 1
        Me.rbtXDocumento.Text = "Documento"
        Me.rbtXDocumento.UseVisualStyleBackColor = True
        '
        'rbtXNombres
        '
        Me.rbtXNombres.AutoSize = True
        Me.rbtXNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtXNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtXNombres.Location = New System.Drawing.Point(213, 16)
        Me.rbtXNombres.Name = "rbtXNombres"
        Me.rbtXNombres.Size = New System.Drawing.Size(90, 21)
        Me.rbtXNombres.TabIndex = 2
        Me.rbtXNombres.Text = "Nombres"
        Me.rbtXNombres.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        '
        '
        '
        Me.txtBusqueda.Border.Class = "TextBoxBorder"
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(90, 108)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(426, 31)
        Me.txtBusqueda.TabIndex = 3
        '
        'frmBuscarPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBuscarPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Buscar Pacientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonClientPanel.ResumeLayout(False)
        CType(Me.dgPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpOpcionBusqueda.ResumeLayout(False)
        Me.gpOpcionBusqueda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpOpcionBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtBusqueda As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents rbtXHistoria As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents rbtXNombres As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents listaResultados As System.Windows.Forms.ListBox
    Friend WithEvents btnEditar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSeleccionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCount_pac As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTotalPacientes As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNomBusqueda As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbtXApellidos As System.Windows.Forms.RadioButton


End Class
