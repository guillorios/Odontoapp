<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuditoria))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.cmbfecfin_aud = New System.Windows.Forms.DateTimePicker
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.gPanel_Sexo = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtCitasEliAud = New System.Windows.Forms.RadioButton
        Me.rbtCalendarioAud = New System.Windows.Forms.RadioButton
        Me.rbtInformesAud = New System.Windows.Forms.RadioButton
        Me.rbtPacientesAud = New System.Windows.Forms.RadioButton
        Me.rbtCitasAud = New System.Windows.Forms.RadioButton
        Me.cmbEmpleados = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.cmbfecini_aud = New System.Windows.Forms.DateTimePicker
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.btnAudSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnAudInforme = New DevComponents.DotNetBar.ButtonX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gPanel_Sexo.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.cmbfecfin_aud)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX2)
        Me.RibbonClientPanel1.Controls.Add(Me.gPanel_Sexo)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbEmpleados)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX1)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbfecini_aud)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX7)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAudSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAudInforme)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX11)
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
        'cmbfecfin_aud
        '
        Me.cmbfecfin_aud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecfin_aud.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecfin_aud.Location = New System.Drawing.Point(398, 218)
        Me.cmbfecfin_aud.Name = "cmbfecfin_aud"
        Me.cmbfecfin_aud.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecfin_aud.TabIndex = 100
        Me.cmbfecfin_aud.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(309, 219)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 22)
        Me.LabelX2.TabIndex = 101
        Me.LabelX2.Text = "Fecha Final"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gPanel_Sexo
        '
        Me.gPanel_Sexo.BackColor = System.Drawing.Color.Transparent
        Me.gPanel_Sexo.CanvasColor = System.Drawing.SystemColors.Control
        Me.gPanel_Sexo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gPanel_Sexo.Controls.Add(Me.rbtCitasEliAud)
        Me.gPanel_Sexo.Controls.Add(Me.rbtCalendarioAud)
        Me.gPanel_Sexo.Controls.Add(Me.rbtInformesAud)
        Me.gPanel_Sexo.Controls.Add(Me.rbtPacientesAud)
        Me.gPanel_Sexo.Controls.Add(Me.rbtCitasAud)
        Me.gPanel_Sexo.Location = New System.Drawing.Point(28, 168)
        Me.gPanel_Sexo.Name = "gPanel_Sexo"
        Me.gPanel_Sexo.Size = New System.Drawing.Size(275, 163)
        '
        '
        '
        Me.gPanel_Sexo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gPanel_Sexo.Style.BackColorGradientAngle = 90
        Me.gPanel_Sexo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gPanel_Sexo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderBottomWidth = 1
        Me.gPanel_Sexo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gPanel_Sexo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderLeftWidth = 1
        Me.gPanel_Sexo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderRightWidth = 1
        Me.gPanel_Sexo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gPanel_Sexo.Style.BorderTopWidth = 1
        Me.gPanel_Sexo.Style.CornerDiameter = 4
        Me.gPanel_Sexo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gPanel_Sexo.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gPanel_Sexo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gPanel_Sexo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gPanel_Sexo.TabIndex = 99
        Me.gPanel_Sexo.Text = "Tipo de Registro"
        '
        'rbtCitasEliAud
        '
        Me.rbtCitasEliAud.AutoSize = True
        Me.rbtCitasEliAud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCitasEliAud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtCitasEliAud.Location = New System.Drawing.Point(12, 35)
        Me.rbtCitasEliAud.Name = "rbtCitasEliAud"
        Me.rbtCitasEliAud.Size = New System.Drawing.Size(149, 17)
        Me.rbtCitasEliAud.TabIndex = 12
        Me.rbtCitasEliAud.Text = "Citas - Pacientes Borrados"
        Me.rbtCitasEliAud.UseVisualStyleBackColor = True
        '
        'rbtCalendarioAud
        '
        Me.rbtCalendarioAud.AutoSize = True
        Me.rbtCalendarioAud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCalendarioAud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtCalendarioAud.Location = New System.Drawing.Point(12, 105)
        Me.rbtCalendarioAud.Name = "rbtCalendarioAud"
        Me.rbtCalendarioAud.Size = New System.Drawing.Size(155, 17)
        Me.rbtCalendarioAud.TabIndex = 11
        Me.rbtCalendarioAud.Text = "Modificación del Calendario"
        Me.rbtCalendarioAud.UseVisualStyleBackColor = True
        '
        'rbtInformesAud
        '
        Me.rbtInformesAud.AutoSize = True
        Me.rbtInformesAud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtInformesAud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtInformesAud.Location = New System.Drawing.Point(12, 81)
        Me.rbtInformesAud.Name = "rbtInformesAud"
        Me.rbtInformesAud.Size = New System.Drawing.Size(123, 17)
        Me.rbtInformesAud.TabIndex = 10
        Me.rbtInformesAud.Text = "Solicitud de Informes"
        Me.rbtInformesAud.UseVisualStyleBackColor = True
        '
        'rbtPacientesAud
        '
        Me.rbtPacientesAud.AutoSize = True
        Me.rbtPacientesAud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtPacientesAud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtPacientesAud.Location = New System.Drawing.Point(12, 58)
        Me.rbtPacientesAud.Name = "rbtPacientesAud"
        Me.rbtPacientesAud.Size = New System.Drawing.Size(214, 17)
        Me.rbtPacientesAud.TabIndex = 9
        Me.rbtPacientesAud.Text = "Creación y/o Modificación de Pacientes"
        Me.rbtPacientesAud.UseVisualStyleBackColor = True
        '
        'rbtCitasAud
        '
        Me.rbtCitasAud.AutoSize = True
        Me.rbtCitasAud.Checked = True
        Me.rbtCitasAud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCitasAud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtCitasAud.Location = New System.Drawing.Point(12, 12)
        Me.rbtCitasAud.Name = "rbtCitasAud"
        Me.rbtCitasAud.Size = New System.Drawing.Size(179, 17)
        Me.rbtCitasAud.TabIndex = 8
        Me.rbtCitasAud.TabStop = True
        Me.rbtCitasAud.Text = "Citas Asignadas y/o Modificadas"
        Me.rbtCitasAud.UseVisualStyleBackColor = True
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.DisplayMember = "Text"
        Me.cmbEmpleados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(106, 109)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(396, 21)
        Me.cmbEmpleados.TabIndex = 98
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(28, 109)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 20)
        Me.LabelX1.TabIndex = 97
        Me.LabelX1.Text = "Usuario"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbfecini_aud
        '
        Me.cmbfecini_aud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecini_aud.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecini_aud.Location = New System.Drawing.Point(398, 183)
        Me.cmbfecini_aud.Name = "cmbfecini_aud"
        Me.cmbfecini_aud.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecini_aud.TabIndex = 95
        Me.cmbfecini_aud.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.LightBlue
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(309, 183)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(83, 23)
        Me.LabelX7.TabIndex = 96
        Me.LabelX7.Text = "Fecha Inicial"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnAudSalir
        '
        Me.btnAudSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAudSalir.Image = CType(resources.GetObject("btnAudSalir.Image"), System.Drawing.Image)
        Me.btnAudSalir.Location = New System.Drawing.Point(398, 413)
        Me.btnAudSalir.Name = "btnAudSalir"
        Me.btnAudSalir.Size = New System.Drawing.Size(104, 46)
        Me.btnAudSalir.TabIndex = 94
        Me.btnAudSalir.Text = "SALIR"
        '
        'btnAudInforme
        '
        Me.btnAudInforme.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAudInforme.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAudInforme.Image = CType(resources.GetObject("btnAudInforme.Image"), System.Drawing.Image)
        Me.btnAudInforme.Location = New System.Drawing.Point(114, 413)
        Me.btnAudInforme.Name = "btnAudInforme"
        Me.btnAudInforme.Size = New System.Drawing.Size(104, 46)
        Me.btnAudInforme.TabIndex = 93
        Me.btnAudInforme.Text = "INFORME"
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(28, 12)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(474, 23)
        Me.LabelX11.TabIndex = 92
        Me.LabelX11.Text = "INFORMES DE AUDITORIA"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAuditoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Auditoria"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gPanel_Sexo.ResumeLayout(False)
        Me.gPanel_Sexo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAudSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAudInforme As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbEmpleados As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecini_aud As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gPanel_Sexo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtCalendarioAud As System.Windows.Forms.RadioButton
    Friend WithEvents rbtInformesAud As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPacientesAud As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCitasAud As System.Windows.Forms.RadioButton
    Friend WithEvents cmbfecfin_aud As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbtCitasEliAud As System.Windows.Forms.RadioButton
End Class
