<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcercaOdontoapp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcercaOdontoapp))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblSerial = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.lblCodAtivacion = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.lblNombre = New DevComponents.DotNetBar.LabelX
        Me.lblVersionServidor = New DevComponents.DotNetBar.LabelX
        Me.lblActualizado = New DevComponents.DotNetBar.LabelX
        Me.gpDatos = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.TextBoxDescription = New DevComponents.DotNetBar.LabelX
        Me.LabelCompanyName = New DevComponents.DotNetBar.LabelX
        Me.LabelCopyright = New DevComponents.DotNetBar.LabelX
        Me.LabelVersion = New DevComponents.DotNetBar.LabelX
        Me.LabelProductName = New DevComponents.DotNetBar.LabelX
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnDescargarActualizacion = New DevComponents.DotNetBar.ButtonX
        Me.btnOk = New DevComponents.DotNetBar.ButtonX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpDatos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.lblSerial)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX5)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX3)
        Me.RibbonClientPanel1.Controls.Add(Me.lblCodAtivacion)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX2)
        Me.RibbonClientPanel1.Controls.Add(Me.lblNombre)
        Me.RibbonClientPanel1.Controls.Add(Me.lblVersionServidor)
        Me.RibbonClientPanel1.Controls.Add(Me.lblActualizado)
        Me.RibbonClientPanel1.Controls.Add(Me.gpDatos)
        Me.RibbonClientPanel1.Controls.Add(Me.PictureBox1)
        Me.RibbonClientPanel1.Controls.Add(Me.btnDescargarActualizacion)
        Me.RibbonClientPanel1.Controls.Add(Me.btnOk)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(570, 390)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 0
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'lblSerial
        '
        Me.lblSerial.BackColor = System.Drawing.Color.Transparent
        Me.lblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.lblSerial.ForeColor = System.Drawing.Color.White
        Me.lblSerial.Location = New System.Drawing.Point(231, 249)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(331, 23)
        Me.lblSerial.TabIndex = 11
        Me.lblSerial.Text = "Serial"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.ForeColor = System.Drawing.Color.Yellow
        Me.LabelX5.Location = New System.Drawing.Point(232, 229)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(72, 18)
        Me.LabelX5.TabIndex = 10
        Me.LabelX5.Text = "Serial No."
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.ForeColor = System.Drawing.Color.Yellow
        Me.LabelX3.Location = New System.Drawing.Point(231, 208)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(97, 23)
        Me.LabelX3.TabIndex = 8
        Me.LabelX3.Text = "Codigo Activacion:"
        '
        'lblCodAtivacion
        '
        Me.lblCodAtivacion.BackColor = System.Drawing.Color.Transparent
        Me.lblCodAtivacion.ForeColor = System.Drawing.Color.White
        Me.lblCodAtivacion.Location = New System.Drawing.Point(332, 208)
        Me.lblCodAtivacion.Name = "lblCodAtivacion"
        Me.lblCodAtivacion.Size = New System.Drawing.Size(220, 23)
        Me.lblCodAtivacion.TabIndex = 7
        Me.lblCodAtivacion.Text = "Codigo Activacion"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.ForeColor = System.Drawing.Color.Yellow
        Me.LabelX2.Location = New System.Drawing.Point(231, 187)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(97, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Registrado A:"
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(333, 187)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(220, 23)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Registrado A:"
        '
        'lblVersionServidor
        '
        Me.lblVersionServidor.BackColor = System.Drawing.Color.Transparent
        Me.lblVersionServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersionServidor.ForeColor = System.Drawing.Color.White
        Me.lblVersionServidor.Location = New System.Drawing.Point(235, 316)
        Me.lblVersionServidor.Name = "lblVersionServidor"
        Me.lblVersionServidor.Size = New System.Drawing.Size(302, 23)
        Me.lblVersionServidor.TabIndex = 4
        Me.lblVersionServidor.Text = "Version Servidor"
        '
        'lblActualizado
        '
        Me.lblActualizado.BackColor = System.Drawing.Color.Transparent
        Me.lblActualizado.BorderType = DevComponents.DotNetBar.eBorderType.Bump
        Me.lblActualizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualizado.ForeColor = System.Drawing.Color.Lime
        Me.lblActualizado.Location = New System.Drawing.Point(232, 281)
        Me.lblActualizado.Name = "lblActualizado"
        Me.lblActualizado.Size = New System.Drawing.Size(330, 31)
        Me.lblActualizado.TabIndex = 5
        Me.lblActualizado.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpDatos
        '
        Me.gpDatos.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpDatos.Controls.Add(Me.TextBoxDescription)
        Me.gpDatos.Controls.Add(Me.LabelCompanyName)
        Me.gpDatos.Controls.Add(Me.LabelCopyright)
        Me.gpDatos.Controls.Add(Me.LabelVersion)
        Me.gpDatos.Controls.Add(Me.LabelProductName)
        Me.gpDatos.Location = New System.Drawing.Point(229, 13)
        Me.gpDatos.Name = "gpDatos"
        Me.gpDatos.Size = New System.Drawing.Size(336, 168)
        '
        '
        '
        Me.gpDatos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpDatos.Style.BackColorGradientAngle = 90
        Me.gpDatos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpDatos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderBottomWidth = 1
        Me.gpDatos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpDatos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderLeftWidth = 1
        Me.gpDatos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderRightWidth = 1
        Me.gpDatos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpDatos.Style.BorderTopWidth = 1
        Me.gpDatos.Style.CornerDiameter = 4
        Me.gpDatos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpDatos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpDatos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpDatos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpDatos.TabIndex = 4
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BackColor = System.Drawing.Color.Transparent
        Me.TextBoxDescription.Location = New System.Drawing.Point(4, 118)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(322, 23)
        Me.TextBoxDescription.TabIndex = 3
        Me.TextBoxDescription.Text = "Descripcion"
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompanyName.Location = New System.Drawing.Point(3, 89)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(224, 23)
        Me.LabelCompanyName.TabIndex = 3
        Me.LabelCompanyName.Text = "Nombre Compañia"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.LabelCopyright.Location = New System.Drawing.Point(3, 60)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(224, 23)
        Me.LabelCopyright.TabIndex = 2
        Me.LabelCopyright.Text = "Copyrigth"
        '
        'LabelVersion
        '
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Location = New System.Drawing.Point(3, 31)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(224, 23)
        Me.LabelVersion.TabIndex = 1
        Me.LabelVersion.Text = "Version"
        '
        'LabelProductName
        '
        Me.LabelProductName.BackColor = System.Drawing.Color.Transparent
        Me.LabelProductName.Location = New System.Drawing.Point(4, 2)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(224, 23)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Nombre del Producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 366)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnDescargarActualizacion
        '
        Me.btnDescargarActualizacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDescargarActualizacion.Image = CType(resources.GetObject("btnDescargarActualizacion.Image"), System.Drawing.Image)
        Me.btnDescargarActualizacion.Location = New System.Drawing.Point(232, 341)
        Me.btnDescargarActualizacion.Name = "btnDescargarActualizacion"
        Me.btnDescargarActualizacion.Size = New System.Drawing.Size(171, 37)
        Me.btnDescargarActualizacion.TabIndex = 2
        Me.btnDescargarActualizacion.Text = "Descargar Actualizacion"
        '
        'btnOk
        '
        Me.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(465, 341)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(93, 37)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        '
        'frmAcercaOdontoapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 390)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAcercaOdontoapp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acerca de Odontoapp"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpDatos.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnDescargarActualizacion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOk As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpDatos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelCompanyName As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelCopyright As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelVersion As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelProductName As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxDescription As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblActualizado As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblVersionServidor As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblCodAtivacion As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblNombre As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblSerial As DevComponents.DotNetBar.LabelX
End Class
