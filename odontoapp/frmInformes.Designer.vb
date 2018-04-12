<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformes))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.gpEnvioInforme = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnEnvioInformeEmail = New DevComponents.DotNetBar.ButtonX
        Me.crvOrthosoft = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.btnSalirInfo = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtcorreos = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblMensajeEmail = New DevComponents.DotNetBar.LabelX
        Me.lblTituloEmail = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpEnvioInforme.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.gpEnvioInforme)
        Me.RibbonClientPanel1.Controls.Add(Me.crvOrthosoft)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX5)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalirInfo)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(532, 486)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 89
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'gpEnvioInforme
        '
        Me.gpEnvioInforme.BackColor = System.Drawing.Color.Transparent
        Me.gpEnvioInforme.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEnvioInforme.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEnvioInforme.Controls.Add(Me.txtcorreos)
        Me.gpEnvioInforme.Controls.Add(Me.LabelX1)
        Me.gpEnvioInforme.Controls.Add(Me.lblMensajeEmail)
        Me.gpEnvioInforme.Controls.Add(Me.lblTituloEmail)
        Me.gpEnvioInforme.Controls.Add(Me.btnEnvioInformeEmail)
        Me.gpEnvioInforme.Location = New System.Drawing.Point(13, 13)
        Me.gpEnvioInforme.Name = "gpEnvioInforme"
        Me.gpEnvioInforme.Size = New System.Drawing.Size(507, 47)
        '
        '
        '
        Me.gpEnvioInforme.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpEnvioInforme.Style.BackColorGradientAngle = 90
        Me.gpEnvioInforme.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpEnvioInforme.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEnvioInforme.Style.BorderBottomWidth = 1
        Me.gpEnvioInforme.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEnvioInforme.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEnvioInforme.Style.BorderLeftWidth = 1
        Me.gpEnvioInforme.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEnvioInforme.Style.BorderRightWidth = 1
        Me.gpEnvioInforme.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEnvioInforme.Style.BorderTopWidth = 1
        Me.gpEnvioInforme.Style.CornerDiameter = 4
        Me.gpEnvioInforme.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEnvioInforme.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEnvioInforme.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpEnvioInforme.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpEnvioInforme.TabIndex = 93
        '
        'btnEnvioInformeEmail
        '
        Me.btnEnvioInformeEmail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEnvioInformeEmail.Image = CType(resources.GetObject("btnEnvioInformeEmail.Image"), System.Drawing.Image)
        Me.btnEnvioInformeEmail.Location = New System.Drawing.Point(392, 1)
        Me.btnEnvioInformeEmail.Name = "btnEnvioInformeEmail"
        Me.btnEnvioInformeEmail.Size = New System.Drawing.Size(104, 37)
        Me.btnEnvioInformeEmail.TabIndex = 129
        Me.btnEnvioInformeEmail.Text = "Enviar Informe"
        '
        'crvOrthosoft
        '
        Me.crvOrthosoft.ActiveViewIndex = -1
        Me.crvOrthosoft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvOrthosoft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvOrthosoft.DisplayGroupTree = False
        Me.crvOrthosoft.Location = New System.Drawing.Point(13, 66)
        Me.crvOrthosoft.Name = "crvOrthosoft"
        Me.crvOrthosoft.SelectionFormula = ""
        Me.crvOrthosoft.Size = New System.Drawing.Size(507, 360)
        Me.crvOrthosoft.TabIndex = 92
        Me.crvOrthosoft.ViewTimeSelectionFormula = ""
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelX5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX5.Location = New System.Drawing.Point(13, 432)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(410, 39)
        Me.LabelX5.TabIndex = 91
        Me.LabelX5.Text = "INFORMES"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnSalirInfo
        '
        Me.btnSalirInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalirInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalirInfo.Image = CType(resources.GetObject("btnSalirInfo.Image"), System.Drawing.Image)
        Me.btnSalirInfo.Location = New System.Drawing.Point(429, 432)
        Me.btnSalirInfo.Name = "btnSalirInfo"
        Me.btnSalirInfo.Size = New System.Drawing.Size(91, 39)
        Me.btnSalirInfo.TabIndex = 1
        Me.btnSalirInfo.Text = "SALIR"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(119, 20)
        Me.LabelX1.TabIndex = 132
        Me.LabelX1.Text = "Correos Electrónicos"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtcorreos
        '
        '
        '
        '
        Me.txtcorreos.Border.Class = "TextBoxBorder"
        Me.txtcorreos.Location = New System.Drawing.Point(125, 2)
        Me.txtcorreos.Name = "txtcorreos"
        Me.txtcorreos.Size = New System.Drawing.Size(262, 38)
        Me.txtcorreos.TabIndex = 133
        '
        'lblMensajeEmail
        '
        Me.lblMensajeEmail.Location = New System.Drawing.Point(3, 31)
        Me.lblMensajeEmail.Name = "lblMensajeEmail"
        Me.lblMensajeEmail.Size = New System.Drawing.Size(119, 13)
        Me.lblMensajeEmail.TabIndex = 131
        Me.lblMensajeEmail.Text = "Mensaje"
        Me.lblMensajeEmail.Visible = False
        '
        'lblTituloEmail
        '
        Me.lblTituloEmail.Location = New System.Drawing.Point(3, 22)
        Me.lblTituloEmail.Name = "lblTituloEmail"
        Me.lblTituloEmail.Size = New System.Drawing.Size(119, 22)
        Me.lblTituloEmail.TabIndex = 130
        Me.lblTituloEmail.Text = "Titulo"
        Me.lblTituloEmail.Visible = False
        '
        'frmInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInformes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Informes"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpEnvioInforme.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnSalirInfo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents crvOrthosoft As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents gpEnvioInforme As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnEnvioInformeEmail As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtcorreos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMensajeEmail As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTituloEmail As DevComponents.DotNetBar.LabelX
End Class
