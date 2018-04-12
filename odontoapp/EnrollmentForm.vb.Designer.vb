<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrollmentForm))
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel
        Me.btnDocSalir = New DevComponents.DotNetBar.ButtonX
        Me.ListEvents = New System.Windows.Forms.ListBox
        Me.EnrollmentControl = New DPFP.Gui.Enrollment.EnrollmentControl
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.TabControlPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.btnDocSalir)
        Me.TabControlPanel2.Controls.Add(Me.ListEvents)
        Me.TabControlPanel2.Controls.Add(Me.EnrollmentControl)
        Me.TabControlPanel2.Controls.Add(Me.LabelX11)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(532, 486)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
                    Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 3
        '
        'btnDocSalir
        '
        Me.btnDocSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDocSalir.Image = CType(resources.GetObject("btnDocSalir.Image"), System.Drawing.Image)
        Me.btnDocSalir.Location = New System.Drawing.Point(423, 451)
        Me.btnDocSalir.Name = "btnDocSalir"
        Me.btnDocSalir.Size = New System.Drawing.Size(91, 25)
        Me.btnDocSalir.TabIndex = 94
        Me.btnDocSalir.Text = "SALIR"
        '
        'ListEvents
        '
        Me.ListEvents.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ListEvents.FormattingEnabled = True
        Me.ListEvents.Location = New System.Drawing.Point(20, 354)
        Me.ListEvents.Name = "ListEvents"
        Me.ListEvents.Size = New System.Drawing.Size(492, 95)
        Me.ListEvents.TabIndex = 0
        '
        'EnrollmentControl
        '
        Me.EnrollmentControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EnrollmentControl.EnrolledFingerMask = 0
        Me.EnrollmentControl.Location = New System.Drawing.Point(20, 34)
        Me.EnrollmentControl.MaxEnrollFingerCount = 10
        Me.EnrollmentControl.Name = "EnrollmentControl"
        Me.EnrollmentControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.EnrollmentControl.Size = New System.Drawing.Size(492, 314)
        Me.EnrollmentControl.TabIndex = 93
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(12, 4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(508, 23)
        Me.LabelX11.TabIndex = 91
        Me.LabelX11.Text = "REGISTRO DE HUELLA"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'EnrollmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.TabControlPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EnrollmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EnrollmentForm"
        Me.TabControlPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Private WithEvents ListEvents As System.Windows.Forms.ListBox
    Friend WithEvents EnrollmentControl As DPFP.Gui.Enrollment.EnrollmentControl
    Friend WithEvents btnDocSalir As DevComponents.DotNetBar.ButtonX
End Class
