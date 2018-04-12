<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImagenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImagenes))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnAbrirExplorer = New DevComponents.DotNetBar.ButtonX
        Me.btnGuardar = New DevComponents.DotNetBar.ButtonX
        Me.btnComposicionGaleria = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnBorrarGaleria = New DevComponents.DotNetBar.ButtonX
        Me.VScrollBarGaleria = New System.Windows.Forms.VScrollBar
        Me.gpGaleria = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txtdescripcion_img = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnGrabarGaleria = New DevComponents.DotNetBar.ButtonX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cmbGaleria = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblGaleria = New DevComponents.DotNetBar.LabelX
        Me.pbxGaleria = New System.Windows.Forms.PictureBox
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpGaleria.SuspendLayout()
        CType(Me.pbxGaleria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnAbrirExplorer)
        Me.RibbonClientPanel1.Controls.Add(Me.btnGuardar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnComposicionGaleria)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnBorrarGaleria)
        Me.RibbonClientPanel1.Controls.Add(Me.VScrollBarGaleria)
        Me.RibbonClientPanel1.Controls.Add(Me.gpGaleria)
        Me.RibbonClientPanel1.Controls.Add(Me.lblGaleria)
        Me.RibbonClientPanel1.Controls.Add(Me.pbxGaleria)
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
        'btnAbrirExplorer
        '
        Me.btnAbrirExplorer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAbrirExplorer.Image = CType(resources.GetObject("btnAbrirExplorer.Image"), System.Drawing.Image)
        Me.btnAbrirExplorer.Location = New System.Drawing.Point(33, 427)
        Me.btnAbrirExplorer.Name = "btnAbrirExplorer"
        Me.btnAbrirExplorer.Size = New System.Drawing.Size(102, 35)
        Me.btnAbrirExplorer.TabIndex = 185
        '
        'btnGuardar
        '
        Me.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(311, 428)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 34)
        Me.btnGuardar.TabIndex = 183
        Me.btnGuardar.Text = "GUARDAR"
        '
        'btnComposicionGaleria
        '
        Me.btnComposicionGaleria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnComposicionGaleria.Image = CType(resources.GetObject("btnComposicionGaleria.Image"), System.Drawing.Image)
        Me.btnComposicionGaleria.Location = New System.Drawing.Point(484, 360)
        Me.btnComposicionGaleria.Name = "btnComposicionGaleria"
        Me.btnComposicionGaleria.Size = New System.Drawing.Size(26, 30)
        Me.btnComposicionGaleria.TabIndex = 179
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(413, 428)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 34)
        Me.btnSalir.TabIndex = 184
        Me.btnSalir.Text = "SALIR"
        '
        'btnBorrarGaleria
        '
        Me.btnBorrarGaleria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrarGaleria.Image = CType(resources.GetObject("btnBorrarGaleria.Image"), System.Drawing.Image)
        Me.btnBorrarGaleria.Location = New System.Drawing.Point(484, 394)
        Me.btnBorrarGaleria.Name = "btnBorrarGaleria"
        Me.btnBorrarGaleria.Size = New System.Drawing.Size(26, 26)
        Me.btnBorrarGaleria.TabIndex = 178
        '
        'VScrollBarGaleria
        '
        Me.VScrollBarGaleria.Enabled = False
        Me.VScrollBarGaleria.Location = New System.Drawing.Point(484, 91)
        Me.VScrollBarGaleria.Maximum = 107
        Me.VScrollBarGaleria.Minimum = 10
        Me.VScrollBarGaleria.Name = "VScrollBarGaleria"
        Me.VScrollBarGaleria.Size = New System.Drawing.Size(26, 265)
        Me.VScrollBarGaleria.TabIndex = 176
        Me.VScrollBarGaleria.Value = 100
        '
        'gpGaleria
        '
        Me.gpGaleria.BackColor = System.Drawing.Color.Transparent
        Me.gpGaleria.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpGaleria.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpGaleria.Controls.Add(Me.txtdescripcion_img)
        Me.gpGaleria.Controls.Add(Me.btnGrabarGaleria)
        Me.gpGaleria.Controls.Add(Me.LabelX2)
        Me.gpGaleria.Controls.Add(Me.LabelX1)
        Me.gpGaleria.Controls.Add(Me.cmbGaleria)
        Me.gpGaleria.Location = New System.Drawing.Point(32, 50)
        Me.gpGaleria.Name = "gpGaleria"
        Me.gpGaleria.Size = New System.Drawing.Size(478, 37)
        '
        '
        '
        Me.gpGaleria.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpGaleria.Style.BackColorGradientAngle = 90
        Me.gpGaleria.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpGaleria.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGaleria.Style.BorderBottomWidth = 1
        Me.gpGaleria.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpGaleria.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGaleria.Style.BorderLeftWidth = 1
        Me.gpGaleria.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGaleria.Style.BorderRightWidth = 1
        Me.gpGaleria.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpGaleria.Style.BorderTopWidth = 1
        Me.gpGaleria.Style.CornerDiameter = 4
        Me.gpGaleria.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpGaleria.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpGaleria.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpGaleria.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpGaleria.TabIndex = 175
        '
        'txtdescripcion_img
        '
        '
        '
        '
        Me.txtdescripcion_img.Border.Class = "TextBoxBorder"
        Me.txtdescripcion_img.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion_img.Location = New System.Drawing.Point(76, 4)
        Me.txtdescripcion_img.Name = "txtdescripcion_img"
        Me.txtdescripcion_img.Size = New System.Drawing.Size(120, 20)
        Me.txtdescripcion_img.TabIndex = 103
        '
        'btnGrabarGaleria
        '
        Me.btnGrabarGaleria.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnGrabarGaleria.Image = CType(resources.GetObject("btnGrabarGaleria.Image"), System.Drawing.Image)
        Me.btnGrabarGaleria.Location = New System.Drawing.Point(443, 0)
        Me.btnGrabarGaleria.Name = "btnGrabarGaleria"
        Me.btnGrabarGaleria.Size = New System.Drawing.Size(26, 26)
        Me.btnGrabarGaleria.TabIndex = 172
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(3, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(69, 20)
        Me.LabelX2.TabIndex = 102
        Me.LabelX2.Text = "Descripcion"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(201, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 20)
        Me.LabelX1.TabIndex = 101
        Me.LabelX1.Text = "Imagen"
        '
        'cmbGaleria
        '
        Me.cmbGaleria.AutoCompleteCustomSource.AddRange(New String() {"Radiografia de Perfil", "Senos Paranasales", "Panorámica", "ATM", "Coronales", "Anteroposterior", "Posteoanterior", "Periapical 1", "Periapical 2", "Periapical 3", "periapical 4", "Periapicales Completos"})
        Me.cmbGaleria.DisplayMember = "Text"
        Me.cmbGaleria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGaleria.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGaleria.FormattingEnabled = True
        Me.cmbGaleria.ItemHeight = 14
        Me.cmbGaleria.Location = New System.Drawing.Point(256, 4)
        Me.cmbGaleria.Name = "cmbGaleria"
        Me.cmbGaleria.Size = New System.Drawing.Size(179, 20)
        Me.cmbGaleria.TabIndex = 81
        Me.cmbGaleria.WatermarkText = "GALERIA"
        '
        'lblGaleria
        '
        Me.lblGaleria.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGaleria.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGaleria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGaleria.Location = New System.Drawing.Point(30, 23)
        Me.lblGaleria.Name = "lblGaleria"
        Me.lblGaleria.Size = New System.Drawing.Size(484, 23)
        Me.lblGaleria.TabIndex = 174
        Me.lblGaleria.Text = "IMAGENES E ILUSTRACIONES"
        Me.lblGaleria.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'pbxGaleria
        '
        Me.pbxGaleria.BackColor = System.Drawing.Color.CornflowerBlue
        Me.pbxGaleria.Location = New System.Drawing.Point(32, 91)
        Me.pbxGaleria.Name = "pbxGaleria"
        Me.pbxGaleria.Size = New System.Drawing.Size(449, 329)
        Me.pbxGaleria.TabIndex = 177
        Me.pbxGaleria.TabStop = False
        '
        'frmImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmImagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Ilustraciones"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpGaleria.ResumeLayout(False)
        CType(Me.pbxGaleria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnComposicionGaleria As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBorrarGaleria As DevComponents.DotNetBar.ButtonX
    Friend WithEvents VScrollBarGaleria As System.Windows.Forms.VScrollBar
    Friend WithEvents gpGaleria As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtdescripcion_img As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnGrabarGaleria As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbGaleria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblGaleria As DevComponents.DotNetBar.LabelX
    Friend WithEvents pbxGaleria As System.Windows.Forms.PictureBox
    Friend WithEvents btnAbrirExplorer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnGuardar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
End Class
