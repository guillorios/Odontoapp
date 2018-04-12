<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFotografia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFotografia))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnOpciones = New DevComponents.DotNetBar.ButtonX
        Me.btnCapturar = New DevComponents.DotNetBar.ButtonX
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.PictureBox = New System.Windows.Forms.PictureBox
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnOpciones)
        Me.RibbonClientPanel1.Controls.Add(Me.btnCapturar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAceptar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.PictureBox)
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
        'btnOpciones
        '
        Me.btnOpciones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOpciones.Image = CType(resources.GetObject("btnOpciones.Image"), System.Drawing.Image)
        Me.btnOpciones.Location = New System.Drawing.Point(127, 411)
        Me.btnOpciones.Name = "btnOpciones"
        Me.btnOpciones.Size = New System.Drawing.Size(90, 39)
        Me.btnOpciones.TabIndex = 2
        Me.btnOpciones.Text = "OPCIONES"
        '
        'btnCapturar
        '
        Me.btnCapturar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCapturar.Image = CType(resources.GetObject("btnCapturar.Image"), System.Drawing.Image)
        Me.btnCapturar.Location = New System.Drawing.Point(31, 411)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(90, 39)
        Me.btnCapturar.TabIndex = 1
        Me.btnCapturar.Text = "CAPTURAR"
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(223, 411)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(90, 39)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "ACEPTAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(417, 411)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(90, 39)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox.Location = New System.Drawing.Point(277, 86)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(230, 172)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 95
        Me.PictureBox.TabStop = False
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(32, 12)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(475, 23)
        Me.LabelX11.TabIndex = 92
        Me.LabelX11.Text = "CAPTURA DE FOTOGRAFIA"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmFotografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFotografia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Fotografias"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Public WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOpciones As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCapturar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
End Class
