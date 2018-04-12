<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendarioPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalendarioPaciente))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.TextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.TextBoxX7 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.btnCalSalir = New DevComponents.DotNetBar.ButtonX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.CalOrthosoft2 = New AxMonthLib.AxctMonth
        Me.RibbonClientPanel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.CalOrthosoft2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.GroupPanel1)
        Me.RibbonClientPanel1.Controls.Add(Me.btnCalSalir)
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
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TextBoxX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX10)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX2)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX7)
        Me.GroupPanel1.Controls.Add(Me.TextBoxX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Location = New System.Drawing.Point(22, 368)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(392, 94)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "CONVENCIONES"
        '
        'TextBoxX5
        '
        Me.TextBoxX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX5.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxX5.Border.Class = "TextBoxBorder"
        Me.TextBoxX5.Location = New System.Drawing.Point(351, 39)
        Me.TextBoxX5.Name = "TextBoxX5"
        Me.TextBoxX5.ReadOnly = True
        Me.TextBoxX5.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxX5.TabIndex = 126
        Me.TextBoxX5.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'LabelX1
        '
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelX1.Location = New System.Drawing.Point(5, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 10
        Me.LabelX1.Text = "Festivo"
        '
        'LabelX10
        '
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelX10.Location = New System.Drawing.Point(273, 36)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(53, 23)
        Me.LabelX10.TabIndex = 127
        Me.LabelX10.Text = "Día Libre"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        '
        '
        Me.TextBoxX1.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Location = New System.Drawing.Point(86, 16)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.ReadOnly = True
        Me.TextBoxX1.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxX1.TabIndex = 3
        Me.TextBoxX1.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'LabelX5
        '
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelX5.Location = New System.Drawing.Point(273, 13)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(72, 23)
        Me.LabelX5.TabIndex = 12
        Me.LabelX5.Text = "Modificado"
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.Red
        '
        '
        '
        Me.TextBoxX2.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Location = New System.Drawing.Point(86, 39)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.ReadOnly = True
        Me.TextBoxX2.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxX2.TabIndex = 4
        Me.TextBoxX2.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'LabelX2
        '
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelX2.Location = New System.Drawing.Point(5, 36)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 11
        Me.LabelX2.Text = "No Laborable"
        '
        'TextBoxX3
        '
        Me.TextBoxX3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        '
        '
        Me.TextBoxX3.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Location = New System.Drawing.Point(351, 13)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.ReadOnly = True
        Me.TextBoxX3.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxX3.TabIndex = 5
        Me.TextBoxX3.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'LabelX3
        '
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelX3.Location = New System.Drawing.Point(126, 13)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(93, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Fin de Semana"
        '
        'TextBoxX7
        '
        Me.TextBoxX7.BackColor = System.Drawing.Color.LightGreen
        '
        '
        '
        Me.TextBoxX7.Border.BackColor = System.Drawing.Color.LightGreen
        Me.TextBoxX7.Border.Class = "TextBoxBorder"
        Me.TextBoxX7.Location = New System.Drawing.Point(228, 39)
        Me.TextBoxX7.Name = "TextBoxX7"
        Me.TextBoxX7.ReadOnly = True
        Me.TextBoxX7.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxX7.TabIndex = 9
        Me.TextBoxX7.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'TextBoxX4
        '
        Me.TextBoxX4.BackColor = System.Drawing.Color.Blue
        '
        '
        '
        Me.TextBoxX4.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.Location = New System.Drawing.Point(228, 13)
        Me.TextBoxX4.Name = "TextBoxX4"
        Me.TextBoxX4.ReadOnly = True
        Me.TextBoxX4.Size = New System.Drawing.Size(28, 20)
        Me.TextBoxX4.TabIndex = 7
        Me.TextBoxX4.WatermarkColor = System.Drawing.SystemColors.GradientInactiveCaption
        '
        'LabelX4
        '
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LabelX4.Location = New System.Drawing.Point(126, 36)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(93, 23)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Día Seleccionado"
        '
        'btnCalSalir
        '
        Me.btnCalSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCalSalir.Image = CType(resources.GetObject("btnCalSalir.Image"), System.Drawing.Image)
        Me.btnCalSalir.Location = New System.Drawing.Point(424, 423)
        Me.btnCalSalir.Name = "btnCalSalir"
        Me.btnCalSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnCalSalir.TabIndex = 112
        Me.btnCalSalir.Text = "SALIR"
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(22, 12)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(498, 23)
        Me.LabelX11.TabIndex = 110
        Me.LabelX11.Text = "CALENDARIO CITAS PACIENTE"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'CalOrthosoft2
        '
        Me.CalOrthosoft2.AllowDrop = True
        Me.CalOrthosoft2.Location = New System.Drawing.Point(22, 51)
        Me.CalOrthosoft2.Name = "CalOrthosoft2"
        Me.CalOrthosoft2.OcxState = CType(resources.GetObject("CalOrthosoft2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CalOrthosoft2.Size = New System.Drawing.Size(498, 311)
        Me.CalOrthosoft2.TabIndex = 1
        '
        'frmCalendarioPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.CalOrthosoft2)
        Me.Controls.Add(Me.LabelX11)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCalendarioPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Calendario Paciente"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.CalOrthosoft2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents CalOrthosoft2 As AxMonthLib.AxctMonth
    Friend WithEvents btnCalSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents TextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX7 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
