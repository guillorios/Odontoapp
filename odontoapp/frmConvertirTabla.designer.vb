<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertirTabla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConvertirTabla))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnCargarFotos = New DevComponents.DotNetBar.ButtonX
        Me.ProgressBar = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnIniciar = New DevComponents.DotNetBar.ButtonX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.OpenFileExcel = New System.Windows.Forms.OpenFileDialog
        Me.RibbonClientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnCargarFotos)
        Me.RibbonClientPanel1.Controls.Add(Me.ProgressBar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnIniciar)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX1)
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
        'btnCargarFotos
        '
        Me.btnCargarFotos.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic
        Me.btnCargarFotos.Image = CType(resources.GetObject("btnCargarFotos.Image"), System.Drawing.Image)
        Me.btnCargarFotos.Location = New System.Drawing.Point(327, 97)
        Me.btnCargarFotos.Name = "btnCargarFotos"
        Me.btnCargarFotos.Size = New System.Drawing.Size(115, 44)
        Me.btnCargarFotos.TabIndex = 89
        Me.btnCargarFotos.Text = "CARGAR FOTOS "
        '
        'ProgressBar
        '
        '
        '
        '
        Me.ProgressBar.BackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2
        Me.ProgressBar.Location = New System.Drawing.Point(79, 215)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(418, 23)
        Me.ProgressBar.TabIndex = 88
        Me.ProgressBar.Text = "0 %"
        Me.ProgressBar.TextVisible = True
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(382, 413)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 44)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "SALIR"
        '
        'btnIniciar
        '
        Me.btnIniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic
        Me.btnIniciar.Image = CType(resources.GetObject("btnIniciar.Image"), System.Drawing.Image)
        Me.btnIniciar.Location = New System.Drawing.Point(134, 97)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(115, 44)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "INICIAR CARGA"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX1.Location = New System.Drawing.Point(23, 22)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(485, 23)
        Me.LabelX1.TabIndex = 84
        Me.LabelX1.Text = "CARGAR BASE DE DATOS CON INFORMACION ORIGINAL"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmConvertirTabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConvertirTabla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Convertir Tabla"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnIniciar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileExcel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProgressBar As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents btnCargarFotos As DevComponents.DotNetBar.ButtonX
End Class
