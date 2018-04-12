<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCentralTelefonica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentralTelefonica))
        Me.RibbonClientPanel = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.prgBarraProgreso = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.btnEnviarCallCenter = New DevComponents.DotNetBar.ButtonX
        Me.dgConsultaCall = New System.Windows.Forms.DataGridView
        Me.gpCallCenter = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbCallCenterV2 = New System.Windows.Forms.RadioButton
        Me.rbCallCenterV1 = New System.Windows.Forms.RadioButton
        Me.lblTituloConsulta = New DevComponents.DotNetBar.LabelX
        Me.btnCallCargar = New DevComponents.DotNetBar.ButtonX
        Me.btnCallSalir = New DevComponents.DotNetBar.ButtonX
        Me.gpOpcionInforme = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtpacCumple = New System.Windows.Forms.RadioButton
        Me.rbtpacNoAsistieron = New System.Windows.Forms.RadioButton
        Me.rbtcitas = New System.Windows.Forms.RadioButton
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel.SuspendLayout()
        CType(Me.dgConsultaCall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpCallCenter.SuspendLayout()
        Me.gpOpcionInforme.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel
        '
        Me.RibbonClientPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel.Controls.Add(Me.prgBarraProgreso)
        Me.RibbonClientPanel.Controls.Add(Me.btnEnviarCallCenter)
        Me.RibbonClientPanel.Controls.Add(Me.dgConsultaCall)
        Me.RibbonClientPanel.Controls.Add(Me.gpCallCenter)
        Me.RibbonClientPanel.Controls.Add(Me.lblTituloConsulta)
        Me.RibbonClientPanel.Controls.Add(Me.btnCallCargar)
        Me.RibbonClientPanel.Controls.Add(Me.btnCallSalir)
        Me.RibbonClientPanel.Controls.Add(Me.gpOpcionInforme)
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
        'prgBarraProgreso
        '
        Me.prgBarraProgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prgBarraProgreso.Location = New System.Drawing.Point(25, 400)
        Me.prgBarraProgreso.Name = "prgBarraProgreso"
        Me.prgBarraProgreso.Size = New System.Drawing.Size(486, 23)
        Me.prgBarraProgreso.TabIndex = 148
        Me.prgBarraProgreso.Text = "PROGRESO %"
        Me.prgBarraProgreso.TextVisible = True
        '
        'btnEnviarCallCenter
        '
        Me.btnEnviarCallCenter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEnviarCallCenter.Enabled = False
        Me.btnEnviarCallCenter.Image = CType(resources.GetObject("btnEnviarCallCenter.Image"), System.Drawing.Image)
        Me.btnEnviarCallCenter.Location = New System.Drawing.Point(171, 439)
        Me.btnEnviarCallCenter.Name = "btnEnviarCallCenter"
        Me.btnEnviarCallCenter.Size = New System.Drawing.Size(125, 35)
        Me.btnEnviarCallCenter.TabIndex = 138
        Me.btnEnviarCallCenter.Text = "ENVIAR A CALL CENTER"
        '
        'dgConsultaCall
        '
        Me.dgConsultaCall.AllowUserToAddRows = False
        Me.dgConsultaCall.AllowUserToDeleteRows = False
        Me.dgConsultaCall.AllowUserToOrderColumns = True
        Me.dgConsultaCall.AllowUserToResizeColumns = False
        Me.dgConsultaCall.AllowUserToResizeRows = False
        Me.dgConsultaCall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgConsultaCall.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgConsultaCall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgConsultaCall.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgConsultaCall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaCall.EnableHeadersVisualStyles = False
        Me.dgConsultaCall.Location = New System.Drawing.Point(25, 160)
        Me.dgConsultaCall.MultiSelect = False
        Me.dgConsultaCall.Name = "dgConsultaCall"
        Me.dgConsultaCall.ReadOnly = True
        Me.dgConsultaCall.RowHeadersVisible = False
        Me.dgConsultaCall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsultaCall.Size = New System.Drawing.Size(486, 234)
        Me.dgConsultaCall.TabIndex = 131
        '
        'gpCallCenter
        '
        Me.gpCallCenter.BackColor = System.Drawing.Color.Transparent
        Me.gpCallCenter.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpCallCenter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpCallCenter.Controls.Add(Me.rbCallCenterV2)
        Me.gpCallCenter.Controls.Add(Me.rbCallCenterV1)
        Me.gpCallCenter.Location = New System.Drawing.Point(348, 39)
        Me.gpCallCenter.Name = "gpCallCenter"
        Me.gpCallCenter.Size = New System.Drawing.Size(163, 85)
        '
        '
        '
        Me.gpCallCenter.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpCallCenter.Style.BackColorGradientAngle = 90
        Me.gpCallCenter.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpCallCenter.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCallCenter.Style.BorderBottomWidth = 1
        Me.gpCallCenter.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpCallCenter.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCallCenter.Style.BorderLeftWidth = 1
        Me.gpCallCenter.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCallCenter.Style.BorderRightWidth = 1
        Me.gpCallCenter.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCallCenter.Style.BorderTopWidth = 1
        Me.gpCallCenter.Style.CornerDiameter = 4
        Me.gpCallCenter.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpCallCenter.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpCallCenter.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpCallCenter.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpCallCenter.TabIndex = 137
        Me.gpCallCenter.Text = "Call Center"
        '
        'rbCallCenterV2
        '
        Me.rbCallCenterV2.AutoSize = True
        Me.rbCallCenterV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCallCenterV2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCallCenterV2.Location = New System.Drawing.Point(15, 29)
        Me.rbCallCenterV2.Name = "rbCallCenterV2"
        Me.rbCallCenterV2.Size = New System.Drawing.Size(92, 17)
        Me.rbCallCenterV2.TabIndex = 1
        Me.rbCallCenterV2.Text = "Call Center V2"
        Me.rbCallCenterV2.UseVisualStyleBackColor = True
        '
        'rbCallCenterV1
        '
        Me.rbCallCenterV1.AutoSize = True
        Me.rbCallCenterV1.Checked = True
        Me.rbCallCenterV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCallCenterV1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCallCenterV1.Location = New System.Drawing.Point(15, 11)
        Me.rbCallCenterV1.Name = "rbCallCenterV1"
        Me.rbCallCenterV1.Size = New System.Drawing.Size(92, 17)
        Me.rbCallCenterV1.TabIndex = 0
        Me.rbCallCenterV1.TabStop = True
        Me.rbCallCenterV1.Text = "Call Center V1"
        Me.rbCallCenterV1.UseVisualStyleBackColor = True
        '
        'lblTituloConsulta
        '
        Me.lblTituloConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloConsulta.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloConsulta.Location = New System.Drawing.Point(25, 132)
        Me.lblTituloConsulta.Name = "lblTituloConsulta"
        Me.lblTituloConsulta.Size = New System.Drawing.Size(486, 22)
        Me.lblTituloConsulta.TabIndex = 135
        Me.lblTituloConsulta.Text = "Informe Citas de Mañana"
        Me.lblTituloConsulta.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnCallCargar
        '
        Me.btnCallCargar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCallCargar.Image = CType(resources.GetObject("btnCallCargar.Image"), System.Drawing.Image)
        Me.btnCallCargar.Location = New System.Drawing.Point(25, 439)
        Me.btnCallCargar.Name = "btnCallCargar"
        Me.btnCallCargar.Size = New System.Drawing.Size(128, 35)
        Me.btnCallCargar.TabIndex = 136
        Me.btnCallCargar.Text = "CARGAR CONSULTA"
        '
        'btnCallSalir
        '
        Me.btnCallSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCallSalir.Image = CType(resources.GetObject("btnCallSalir.Image"), System.Drawing.Image)
        Me.btnCallSalir.Location = New System.Drawing.Point(421, 435)
        Me.btnCallSalir.Name = "btnCallSalir"
        Me.btnCallSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnCallSalir.TabIndex = 134
        Me.btnCallSalir.Text = "SALIR"
        '
        'gpOpcionInforme
        '
        Me.gpOpcionInforme.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionInforme.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionInforme.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionInforme.Controls.Add(Me.rbtpacCumple)
        Me.gpOpcionInforme.Controls.Add(Me.rbtpacNoAsistieron)
        Me.gpOpcionInforme.Controls.Add(Me.rbtcitas)
        Me.gpOpcionInforme.Location = New System.Drawing.Point(25, 37)
        Me.gpOpcionInforme.Name = "gpOpcionInforme"
        Me.gpOpcionInforme.Size = New System.Drawing.Size(300, 87)
        '
        '
        '
        Me.gpOpcionInforme.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpOpcionInforme.Style.BackColorGradientAngle = 90
        Me.gpOpcionInforme.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpOpcionInforme.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderBottomWidth = 1
        Me.gpOpcionInforme.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpOpcionInforme.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderLeftWidth = 1
        Me.gpOpcionInforme.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderRightWidth = 1
        Me.gpOpcionInforme.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderTopWidth = 1
        Me.gpOpcionInforme.Style.CornerDiameter = 4
        Me.gpOpcionInforme.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpOpcionInforme.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpOpcionInforme.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpOpcionInforme.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpOpcionInforme.TabIndex = 133
        Me.gpOpcionInforme.Text = "Opción Informe"
        '
        'rbtpacCumple
        '
        Me.rbtpacCumple.AutoSize = True
        Me.rbtpacCumple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtpacCumple.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtpacCumple.Location = New System.Drawing.Point(3, 40)
        Me.rbtpacCumple.Name = "rbtpacCumple"
        Me.rbtpacCumple.Size = New System.Drawing.Size(279, 17)
        Me.rbtpacCumple.TabIndex = 2
        Me.rbtpacCumple.Text = "Pacientes que Cumplen Años Hoy - Segun Calendario"
        Me.rbtpacCumple.UseVisualStyleBackColor = True
        '
        'rbtpacNoAsistieron
        '
        Me.rbtpacNoAsistieron.AutoSize = True
        Me.rbtpacNoAsistieron.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtpacNoAsistieron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtpacNoAsistieron.Location = New System.Drawing.Point(3, 22)
        Me.rbtpacNoAsistieron.Name = "rbtpacNoAsistieron"
        Me.rbtpacNoAsistieron.Size = New System.Drawing.Size(265, 17)
        Me.rbtpacNoAsistieron.TabIndex = 1
        Me.rbtpacNoAsistieron.Text = "Pacientes que no Asistieron Hoy - Segun Caledario"
        Me.rbtpacNoAsistieron.UseVisualStyleBackColor = True
        '
        'rbtcitas
        '
        Me.rbtcitas.AutoSize = True
        Me.rbtcitas.Checked = True
        Me.rbtcitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtcitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtcitas.Location = New System.Drawing.Point(3, 4)
        Me.rbtcitas.Name = "rbtcitas"
        Me.rbtcitas.Size = New System.Drawing.Size(288, 17)
        Me.rbtcitas.TabIndex = 0
        Me.rbtcitas.TabStop = True
        Me.rbtcitas.Text = "Pacientes que Tienen Cita Mañana - Segun Calendario "
        Me.rbtcitas.UseVisualStyleBackColor = True
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(25, 10)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(495, 23)
        Me.lblTituloVentana.TabIndex = 132
        Me.lblTituloVentana.Text = "GENERADOR ARCHIVO DEL CALL CENTER"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmCentralTelefonica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.lblTituloVentana)
        Me.Controls.Add(Me.RibbonClientPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCentralTelefonica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Central Telefonica"
        Me.RibbonClientPanel.ResumeLayout(False)
        CType(Me.dgConsultaCall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpCallCenter.ResumeLayout(False)
        Me.gpCallCenter.PerformLayout()
        Me.gpOpcionInforme.ResumeLayout(False)
        Me.gpOpcionInforme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnCallCargar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTituloConsulta As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnCallSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgConsultaCall As System.Windows.Forms.DataGridView
    Friend WithEvents gpOpcionInforme As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtpacCumple As System.Windows.Forms.RadioButton
    Friend WithEvents rbtpacNoAsistieron As System.Windows.Forms.RadioButton
    Friend WithEvents rbtcitas As System.Windows.Forms.RadioButton
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpCallCenter As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbCallCenterV2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCallCenterV1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnviarCallCenter As DevComponents.DotNetBar.ButtonX
    Private WithEvents prgBarraProgreso As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
