<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.lblRegistrado = New DevComponents.DotNetBar.LabelX
        Me.btnRegistrar = New DevComponents.DotNetBar.ButtonX
        Me.RibbonClientPanel4 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.txtCodRegistro = New DevExpress.XtraEditors.TextEdit
        Me.txtCodAtivacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.rtxtTotalLetras = New System.Windows.Forms.RichTextBox
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.RibbonClientPanel4.SuspendLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodRegistro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodAtivacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.lblRegistrado)
        Me.RibbonClientPanel1.Controls.Add(Me.btnRegistrar)
        Me.RibbonClientPanel1.Controls.Add(Me.RibbonClientPanel4)
        Me.RibbonClientPanel1.Controls.Add(Me.rtxtTotalLetras)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX11)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(542, 434)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 2
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(413, 370)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 149
        Me.btnSalir.Text = "SALIR"
        '
        'lblRegistrado
        '
        Me.lblRegistrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRegistrado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrado.ForeColor = System.Drawing.Color.White
        Me.lblRegistrado.Location = New System.Drawing.Point(25, 334)
        Me.lblRegistrado.Name = "lblRegistrado"
        Me.lblRegistrado.Size = New System.Drawing.Size(484, 23)
        Me.lblRegistrado.TabIndex = 148
        Me.lblRegistrado.Text = "    REGISTRO DEL PROGRAMA"
        Me.lblRegistrado.Visible = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"), System.Drawing.Image)
        Me.btnRegistrar.Location = New System.Drawing.Point(296, 370)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(111, 39)
        Me.btnRegistrar.TabIndex = 144
        Me.btnRegistrar.Text = "REGISTRAR"
        '
        'RibbonClientPanel4
        '
        Me.RibbonClientPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel4.Controls.Add(Me.txtNombre)
        Me.RibbonClientPanel4.Controls.Add(Me.txtCodRegistro)
        Me.RibbonClientPanel4.Controls.Add(Me.txtCodAtivacion)
        Me.RibbonClientPanel4.Controls.Add(Me.LabelX9)
        Me.RibbonClientPanel4.Controls.Add(Me.LabelX3)
        Me.RibbonClientPanel4.Controls.Add(Me.LabelX1)
        Me.RibbonClientPanel4.Location = New System.Drawing.Point(25, 224)
        Me.RibbonClientPanel4.Name = "RibbonClientPanel4"
        Me.RibbonClientPanel4.Size = New System.Drawing.Size(484, 100)
        '
        '
        '
        Me.RibbonClientPanel4.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel4.TabIndex = 147
        Me.RibbonClientPanel4.Text = "RibbonClientPanel4"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(138, 11)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Properties.Appearance.Options.UseForeColor = True
        Me.txtNombre.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.PowderBlue
        Me.txtNombre.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNombre.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNombre.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.PowderBlue
        Me.txtNombre.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtNombre.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtNombre.Size = New System.Drawing.Size(338, 20)
        Me.txtNombre.TabIndex = 151
        '
        'txtCodRegistro
        '
        Me.txtCodRegistro.EditValue = ""
        Me.txtCodRegistro.Location = New System.Drawing.Point(138, 63)
        Me.txtCodRegistro.Name = "txtCodRegistro"
        Me.txtCodRegistro.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtCodRegistro.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodRegistro.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCodRegistro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodRegistro.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodRegistro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodRegistro.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCodRegistro.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodRegistro.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodRegistro.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodRegistro.Properties.Mask.EditMask = "[0-9A-Z]{0,6}-[0-9A-Z]{0,6}-[0-9A-Z]{0,6}-[0-9A-Z]{0,6}-[0-9A-Z]{0,6}-[0-9A-Z]{0," & _
            "6}-[0-9A-Z]{0,6}-[0-9A-Z]{0,6}"
        Me.txtCodRegistro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtCodRegistro.Size = New System.Drawing.Size(338, 20)
        Me.txtCodRegistro.TabIndex = 150
        '
        'txtCodAtivacion
        '
        Me.txtCodAtivacion.Location = New System.Drawing.Point(138, 37)
        Me.txtCodAtivacion.Name = "txtCodAtivacion"
        Me.txtCodAtivacion.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtCodAtivacion.Properties.Appearance.Options.UseForeColor = True
        Me.txtCodAtivacion.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCodAtivacion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCodAtivacion.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCodAtivacion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCodAtivacion.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.PowderBlue
        Me.txtCodAtivacion.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.Black
        Me.txtCodAtivacion.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtCodAtivacion.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtCodAtivacion.Size = New System.Drawing.Size(338, 20)
        Me.txtCodAtivacion.TabIndex = 150
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX9.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX9.ForeColor = System.Drawing.Color.Navy
        Me.LabelX9.Location = New System.Drawing.Point(11, 37)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(121, 20)
        Me.LabelX9.TabIndex = 145
        Me.LabelX9.Text = "Codigo de Activacion"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(11, 63)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(121, 20)
        Me.LabelX3.TabIndex = 145
        Me.LabelX3.Text = "Codigo de Registro"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(11, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(121, 20)
        Me.LabelX1.TabIndex = 145
        Me.LabelX1.Text = "Nombre"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rtxtTotalLetras
        '
        Me.rtxtTotalLetras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rtxtTotalLetras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtTotalLetras.Location = New System.Drawing.Point(25, 41)
        Me.rtxtTotalLetras.Name = "rtxtTotalLetras"
        Me.rtxtTotalLetras.Size = New System.Drawing.Size(484, 177)
        Me.rtxtTotalLetras.TabIndex = 144
        Me.rtxtTotalLetras.Text = resources.GetString("rtxtTotalLetras.Text")
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(25, 12)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(484, 23)
        Me.LabelX11.TabIndex = 125
        Me.LabelX11.Text = "REGISTRO DEL PROGRAMA"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 434)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de la Aplicacion"
        Me.TopMost = True
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.RibbonClientPanel4.ResumeLayout(False)
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodRegistro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodAtivacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents rtxtTotalLetras As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents RibbonClientPanel4 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnRegistrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblRegistrado As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtCodRegistro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodAtivacion As DevExpress.XtraEditors.TextEdit
End Class
