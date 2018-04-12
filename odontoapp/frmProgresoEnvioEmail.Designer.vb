<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgresoEnvioEmail
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgresoEnvioEmail))
        Me.ProgressBar1 = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.btnEmailSalir = New DevComponents.DotNetBar.ButtonX
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(439, 41)
        Me.ProgressBar1.TabIndex = 149
        Me.ProgressBar1.Text = "PROGRESO"
        Me.ProgressBar1.TextVisible = True
        '
        'btnEmailSalir
        '
        Me.btnEmailSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailSalir.Image = CType(resources.GetObject("btnEmailSalir.Image"), System.Drawing.Image)
        Me.btnEmailSalir.Location = New System.Drawing.Point(457, 16)
        Me.btnEmailSalir.Name = "btnEmailSalir"
        Me.btnEmailSalir.Size = New System.Drawing.Size(86, 41)
        Me.btnEmailSalir.TabIndex = 148
        Me.btnEmailSalir.Text = "SALIR"
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(559, 75)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 150
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'frmProgresoEnvioEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 75)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnEmailSalir)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProgresoEnvioEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progreso Envio"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ProgressBar1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents btnEmailSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
