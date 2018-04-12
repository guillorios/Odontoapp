<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioEmailInd
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvioEmailInd))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnEmailCrear = New DevComponents.DotNetBar.ButtonX
        Me.RichMensajeEmail = New System.Windows.Forms.RichTextBox
        Me.cmbTituloEmail = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblMensajeEmail = New DevComponents.DotNetBar.LabelX
        Me.txtEmailInd = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTituloEmail = New DevComponents.DotNetBar.LabelX
        Me.lblEmailInd = New DevComponents.DotNetBar.LabelX
        Me.btnEmailSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnEmailEnviarInd = New DevComponents.DotNetBar.ButtonX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProviderEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnEmailCrear)
        Me.RibbonClientPanel1.Controls.Add(Me.RichMensajeEmail)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbTituloEmail)
        Me.RibbonClientPanel1.Controls.Add(Me.lblMensajeEmail)
        Me.RibbonClientPanel1.Controls.Add(Me.txtEmailInd)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloEmail)
        Me.RibbonClientPanel1.Controls.Add(Me.lblEmailInd)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEmailSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEmailEnviarInd)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
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
        'btnEmailCrear
        '
        Me.btnEmailCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailCrear.Image = CType(resources.GetObject("btnEmailCrear.Image"), System.Drawing.Image)
        Me.btnEmailCrear.Location = New System.Drawing.Point(24, 419)
        Me.btnEmailCrear.Name = "btnEmailCrear"
        Me.btnEmailCrear.Size = New System.Drawing.Size(101, 39)
        Me.btnEmailCrear.TabIndex = 143
        Me.btnEmailCrear.Text = "CREAR MENSAJE"
        '
        'RichMensajeEmail
        '
        Me.RichMensajeEmail.Location = New System.Drawing.Point(195, 160)
        Me.RichMensajeEmail.Name = "RichMensajeEmail"
        Me.RichMensajeEmail.Size = New System.Drawing.Size(313, 235)
        Me.RichMensajeEmail.TabIndex = 135
        Me.RichMensajeEmail.Text = ""
        '
        'cmbTituloEmail
        '
        Me.cmbTituloEmail.DisplayMember = "Text"
        Me.cmbTituloEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTituloEmail.FormattingEnabled = True
        Me.cmbTituloEmail.ItemHeight = 20
        Me.cmbTituloEmail.Location = New System.Drawing.Point(195, 128)
        Me.cmbTituloEmail.Name = "cmbTituloEmail"
        Me.cmbTituloEmail.Size = New System.Drawing.Size(313, 26)
        Me.cmbTituloEmail.TabIndex = 134
        '
        'lblMensajeEmail
        '
        Me.lblMensajeEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblMensajeEmail.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblMensajeEmail.ForeColor = System.Drawing.Color.Navy
        Me.lblMensajeEmail.Location = New System.Drawing.Point(24, 160)
        Me.lblMensajeEmail.Name = "lblMensajeEmail"
        Me.lblMensajeEmail.Size = New System.Drawing.Size(148, 20)
        Me.lblMensajeEmail.TabIndex = 133
        Me.lblMensajeEmail.Text = "Texto del Mensaje"
        Me.lblMensajeEmail.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtEmailInd
        '
        '
        '
        '
        Me.txtEmailInd.Border.Class = "TextBoxBorder"
        Me.txtEmailInd.Location = New System.Drawing.Point(195, 88)
        Me.txtEmailInd.Name = "txtEmailInd"
        Me.txtEmailInd.Size = New System.Drawing.Size(313, 20)
        Me.txtEmailInd.TabIndex = 142
        '
        'lblTituloEmail
        '
        Me.lblTituloEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTituloEmail.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTituloEmail.ForeColor = System.Drawing.Color.Navy
        Me.lblTituloEmail.Location = New System.Drawing.Point(24, 128)
        Me.lblTituloEmail.Name = "lblTituloEmail"
        Me.lblTituloEmail.Size = New System.Drawing.Size(148, 20)
        Me.lblTituloEmail.TabIndex = 132
        Me.lblTituloEmail.Text = "Titulo del Mensaje"
        Me.lblTituloEmail.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblEmailInd
        '
        Me.lblEmailInd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblEmailInd.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblEmailInd.ForeColor = System.Drawing.Color.Navy
        Me.lblEmailInd.Location = New System.Drawing.Point(24, 88)
        Me.lblEmailInd.Name = "lblEmailInd"
        Me.lblEmailInd.Size = New System.Drawing.Size(148, 20)
        Me.lblEmailInd.TabIndex = 141
        Me.lblEmailInd.Text = "Correo Electronico"
        Me.lblEmailInd.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnEmailSalir
        '
        Me.btnEmailSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailSalir.Image = CType(resources.GetObject("btnEmailSalir.Image"), System.Drawing.Image)
        Me.btnEmailSalir.Location = New System.Drawing.Point(407, 419)
        Me.btnEmailSalir.Name = "btnEmailSalir"
        Me.btnEmailSalir.Size = New System.Drawing.Size(101, 39)
        Me.btnEmailSalir.TabIndex = 135
        Me.btnEmailSalir.Text = "SALIR"
        '
        'btnEmailEnviarInd
        '
        Me.btnEmailEnviarInd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailEnviarInd.Image = CType(resources.GetObject("btnEmailEnviarInd.Image"), System.Drawing.Image)
        Me.btnEmailEnviarInd.Location = New System.Drawing.Point(278, 419)
        Me.btnEmailEnviarInd.Name = "btnEmailEnviarInd"
        Me.btnEmailEnviarInd.Size = New System.Drawing.Size(101, 39)
        Me.btnEmailEnviarInd.TabIndex = 133
        Me.btnEmailEnviarInd.Text = "ENVIAR MENSAJES"
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(24, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(484, 23)
        Me.lblTituloVentana.TabIndex = 136
        Me.lblTituloVentana.Text = "ENVIO CORREO ELECTRONICO PERSONALIZADO"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProviderEmail
        '
        Me.ErrorProviderEmail.ContainerControl = Me
        '
        'frmEnvioEmailInd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnvioEmailInd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Envio Email"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents ErrorProviderEmail As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblEmailInd As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEmailSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEmailEnviarInd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEmailInd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents RichMensajeEmail As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbTituloEmail As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblMensajeEmail As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTituloEmail As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEmailCrear As DevComponents.DotNetBar.ButtonX
End Class
