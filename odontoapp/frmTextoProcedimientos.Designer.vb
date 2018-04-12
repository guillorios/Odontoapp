<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextoProcedimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTextoProcedimientos))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.txtIdMensaje = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.RichTxtMensaje = New System.Windows.Forms.RichTextBox
        Me.cmbTitulo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.ErrorProviderEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.txtIdMensaje)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.RichTxtMensaje)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbTitulo)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX3)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX1)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX11)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(532, 486)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 1
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'txtIdMensaje
        '
        '
        '
        '
        Me.txtIdMensaje.Border.Class = "TextBoxBorder"
        Me.txtIdMensaje.Location = New System.Drawing.Point(25, 200)
        Me.txtIdMensaje.Name = "txtIdMensaje"
        Me.txtIdMensaje.Size = New System.Drawing.Size(77, 20)
        Me.txtIdMensaje.TabIndex = 143
        Me.txtIdMensaje.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(268, 334)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 39)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(167, 334)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 39)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(370, 411)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 39)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "SALIR"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(370, 334)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 39)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(65, 334)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnAdicionar.TabIndex = 3
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'RichTxtMensaje
        '
        Me.RichTxtMensaje.Location = New System.Drawing.Point(158, 135)
        Me.RichTxtMensaje.Name = "RichTxtMensaje"
        Me.RichTxtMensaje.Size = New System.Drawing.Size(352, 136)
        Me.RichTxtMensaje.TabIndex = 2
        Me.RichTxtMensaje.Text = ""
        '
        'cmbTitulo
        '
        Me.cmbTitulo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTitulo.FormattingEnabled = True
        Me.cmbTitulo.ItemHeight = 25
        Me.cmbTitulo.Location = New System.Drawing.Point(158, 91)
        Me.cmbTitulo.Name = "cmbTitulo"
        Me.cmbTitulo.Size = New System.Drawing.Size(352, 31)
        Me.cmbTitulo.Sorted = True
        Me.cmbTitulo.TabIndex = 1
        Me.cmbTitulo.WatermarkColor = System.Drawing.SystemColors.ControlLight
        Me.cmbTitulo.WatermarkText = "ESCRIBA EL TITULO DEL TEXTO"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(25, 135)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(127, 20)
        Me.LabelX3.TabIndex = 133
        Me.LabelX3.Text = "Texto del Proced."
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(25, 91)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(127, 20)
        Me.LabelX1.TabIndex = 132
        Me.LabelX1.Text = "Titulo del Proced."
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelX11.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelX11.Location = New System.Drawing.Point(12, 12)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(498, 23)
        Me.LabelX11.TabIndex = 125
        Me.LabelX11.Text = "CREACION DE TEXTOS PERSONALIZADOS PARA PROCEDIMIENTOS"
        Me.LabelX11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProviderEmail
        '
        Me.ErrorProviderEmail.ContainerControl = Me
        '
        'frmTextoProcedimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTextoProcedimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Texto Procedimientos"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents txtIdMensaje As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RichTxtMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbTitulo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ErrorProviderEmail As System.Windows.Forms.ErrorProvider
End Class
