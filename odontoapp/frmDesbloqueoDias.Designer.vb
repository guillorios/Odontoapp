<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesbloqueoDias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDesbloqueoDias))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnDesbloquear = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnBloquear = New DevComponents.DotNetBar.ButtonX
        Me.gpDesBloqueo = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbfecfin_desbloq = New System.Windows.Forms.DateTimePicker
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cmbfecini_desbloq = New System.Windows.Forms.DateTimePicker
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.gpBloqueo = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbfecfin_bloq = New System.Windows.Forms.DateTimePicker
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.cmbfecini_bloq = New System.Windows.Forms.DateTimePicker
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.btnf9BloqueoDia = New DevComponents.DotNetBar.ButtonItem
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpDesBloqueo.SuspendLayout()
        Me.gpBloqueo.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnDesbloquear)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnBloquear)
        Me.RibbonClientPanel1.Controls.Add(Me.gpDesBloqueo)
        Me.RibbonClientPanel1.Controls.Add(Me.gpBloqueo)
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
        'btnDesbloquear
        '
        Me.btnDesbloquear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDesbloquear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDesbloquear.Image = CType(resources.GetObject("btnDesbloquear.Image"), System.Drawing.Image)
        Me.btnDesbloquear.Location = New System.Drawing.Point(27, 430)
        Me.btnDesbloquear.Name = "btnDesbloquear"
        Me.btnDesbloquear.Size = New System.Drawing.Size(149, 46)
        Me.btnDesbloquear.TabIndex = 98
        Me.btnDesbloquear.Text = "DESBLOQUEAR DIAS"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(397, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(104, 46)
        Me.btnSalir.TabIndex = 97
        Me.btnSalir.Text = "SALIR"
        '
        'btnBloquear
        '
        Me.btnBloquear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBloquear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBloquear.Image = CType(resources.GetObject("btnBloquear.Image"), System.Drawing.Image)
        Me.btnBloquear.Location = New System.Drawing.Point(27, 215)
        Me.btnBloquear.Name = "btnBloquear"
        Me.btnBloquear.Size = New System.Drawing.Size(149, 46)
        Me.btnBloquear.TabIndex = 96
        Me.btnBloquear.Text = "BLOQUEAR DIAS"
        '
        'gpDesBloqueo
        '
        Me.gpDesBloqueo.BackColor = System.Drawing.Color.Transparent
        Me.gpDesBloqueo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDesBloqueo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDesBloqueo.Controls.Add(Me.cmbfecfin_desbloq)
        Me.gpDesBloqueo.Controls.Add(Me.LabelX1)
        Me.gpDesBloqueo.Controls.Add(Me.cmbfecini_desbloq)
        Me.gpDesBloqueo.Controls.Add(Me.LabelX3)
        Me.gpDesBloqueo.Location = New System.Drawing.Point(27, 266)
        Me.gpDesBloqueo.Name = "gpDesBloqueo"
        Me.gpDesBloqueo.Size = New System.Drawing.Size(474, 158)
        '
        '
        '
        Me.gpDesBloqueo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDesBloqueo.Style.BackColorGradientAngle = 90
        Me.gpDesBloqueo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDesBloqueo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDesBloqueo.Style.BorderBottomWidth = 1
        Me.gpDesBloqueo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDesBloqueo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDesBloqueo.Style.BorderLeftWidth = 1
        Me.gpDesBloqueo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDesBloqueo.Style.BorderRightWidth = 1
        Me.gpDesBloqueo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDesBloqueo.Style.BorderTopWidth = 1
        Me.gpDesBloqueo.Style.CornerDiameter = 4
        Me.gpDesBloqueo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDesBloqueo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDesBloqueo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDesBloqueo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpDesBloqueo.TabIndex = 95
        Me.gpDesBloqueo.Text = "Desbloquear Dias"
        '
        'cmbfecfin_desbloq
        '
        Me.cmbfecfin_desbloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecfin_desbloq.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecfin_desbloq.Location = New System.Drawing.Point(220, 66)
        Me.cmbfecfin_desbloq.Name = "cmbfecfin_desbloq"
        Me.cmbfecfin_desbloq.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecfin_desbloq.TabIndex = 108
        Me.cmbfecfin_desbloq.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(131, 67)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(83, 22)
        Me.LabelX1.TabIndex = 109
        Me.LabelX1.Text = "Fecha Final"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbfecini_desbloq
        '
        Me.cmbfecini_desbloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecini_desbloq.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecini_desbloq.Location = New System.Drawing.Point(220, 31)
        Me.cmbfecini_desbloq.Name = "cmbfecini_desbloq"
        Me.cmbfecini_desbloq.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecini_desbloq.TabIndex = 106
        Me.cmbfecini_desbloq.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(131, 31)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(83, 23)
        Me.LabelX3.TabIndex = 107
        Me.LabelX3.Text = "Fecha Inicial"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpBloqueo
        '
        Me.gpBloqueo.BackColor = System.Drawing.Color.Transparent
        Me.gpBloqueo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpBloqueo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpBloqueo.Controls.Add(Me.cmbfecfin_bloq)
        Me.gpBloqueo.Controls.Add(Me.LabelX2)
        Me.gpBloqueo.Controls.Add(Me.cmbfecini_bloq)
        Me.gpBloqueo.Controls.Add(Me.LabelX7)
        Me.gpBloqueo.Location = New System.Drawing.Point(27, 53)
        Me.gpBloqueo.Name = "gpBloqueo"
        Me.gpBloqueo.Size = New System.Drawing.Size(474, 156)
        '
        '
        '
        Me.gpBloqueo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpBloqueo.Style.BackColorGradientAngle = 90
        Me.gpBloqueo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpBloqueo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBloqueo.Style.BorderBottomWidth = 1
        Me.gpBloqueo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpBloqueo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBloqueo.Style.BorderLeftWidth = 1
        Me.gpBloqueo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBloqueo.Style.BorderRightWidth = 1
        Me.gpBloqueo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpBloqueo.Style.BorderTopWidth = 1
        Me.gpBloqueo.Style.CornerDiameter = 4
        Me.gpBloqueo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpBloqueo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpBloqueo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpBloqueo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpBloqueo.TabIndex = 94
        Me.gpBloqueo.Text = "Bloqueo de Dias"
        '
        'cmbfecfin_bloq
        '
        Me.cmbfecfin_bloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecfin_bloq.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecfin_bloq.Location = New System.Drawing.Point(220, 54)
        Me.cmbfecfin_bloq.Name = "cmbfecfin_bloq"
        Me.cmbfecfin_bloq.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecfin_bloq.TabIndex = 104
        Me.cmbfecfin_bloq.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(131, 55)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 22)
        Me.LabelX2.TabIndex = 105
        Me.LabelX2.Text = "Fecha Final"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbfecini_bloq
        '
        Me.cmbfecini_bloq.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecini_bloq.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecini_bloq.Location = New System.Drawing.Point(220, 19)
        Me.cmbfecini_bloq.Name = "cmbfecini_bloq"
        Me.cmbfecini_bloq.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecini_bloq.TabIndex = 102
        Me.cmbfecini_bloq.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(131, 19)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(83, 23)
        Me.LabelX7.TabIndex = 103
        Me.LabelX7.Text = "Fecha Inicial"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(27, 15)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(474, 23)
        Me.lblTituloVentana.TabIndex = 93
        Me.lblTituloVentana.Text = "BLOQUEO / DESBLOQUEO DE DIAS CALENDARIO"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnf9BloqueoDia
        '
        Me.btnf9BloqueoDia.Image = CType(resources.GetObject("btnf9BloqueoDia.Image"), System.Drawing.Image)
        Me.btnf9BloqueoDia.ImagePaddingHorizontal = 8
        Me.btnf9BloqueoDia.Name = "btnf9BloqueoDia"
        Me.btnf9BloqueoDia.Text = "DIA"
        Me.btnf9BloqueoDia.Tooltip = "F9-BLOQUEAR DIA"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Image = CType(resources.GetObject("ButtonItem1.Image"), System.Drawing.Image)
        Me.ButtonItem1.ImagePaddingHorizontal = 8
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "DIA"
        Me.ButtonItem1.Tooltip = "F9-BLOQUEAR DIA"
        '
        'frmDesbloqueoDias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDesbloqueoDias"
        Me.Text = "Bloq/Desbloq Calendario"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpDesBloqueo.ResumeLayout(False)
        Me.gpBloqueo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpDesBloqueo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents gpBloqueo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecfin_desbloq As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecini_desbloq As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecfin_bloq As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecini_bloq As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnf9BloqueoDia As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDesbloquear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBloquear As DevComponents.DotNetBar.ButtonX
End Class
