<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioSMSInd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvioSMSInd))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnSMSCrear = New DevComponents.DotNetBar.ButtonX
        Me.RichMensajeSMS = New System.Windows.Forms.RichTextBox
        Me.cmbTituloSMS = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblMensajeSMS = New DevComponents.DotNetBar.LabelX
        Me.txtSMSInd = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.lblTituloSMS = New DevComponents.DotNetBar.LabelX
        Me.lblSMSInd = New DevComponents.DotNetBar.LabelX
        Me.btnSMSSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnSMSEnviarInd = New DevComponents.DotNetBar.ButtonX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnSMSCrear)
        Me.RibbonClientPanel1.Controls.Add(Me.RichMensajeSMS)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbTituloSMS)
        Me.RibbonClientPanel1.Controls.Add(Me.lblMensajeSMS)
        Me.RibbonClientPanel1.Controls.Add(Me.txtSMSInd)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloSMS)
        Me.RibbonClientPanel1.Controls.Add(Me.lblSMSInd)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSMSSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSMSEnviarInd)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
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
        'btnSMSCrear
        '
        Me.btnSMSCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSMSCrear.Image = CType(resources.GetObject("btnSMSCrear.Image"), System.Drawing.Image)
        Me.btnSMSCrear.Location = New System.Drawing.Point(25, 415)
        Me.btnSMSCrear.Name = "btnSMSCrear"
        Me.btnSMSCrear.Size = New System.Drawing.Size(101, 39)
        Me.btnSMSCrear.TabIndex = 162
        Me.btnSMSCrear.Text = "CREAR MENSAJE"
        '
        'RichMensajeSMS
        '
        Me.RichMensajeSMS.Location = New System.Drawing.Point(195, 129)
        Me.RichMensajeSMS.Name = "RichMensajeSMS"
        Me.RichMensajeSMS.Size = New System.Drawing.Size(313, 235)
        Me.RichMensajeSMS.TabIndex = 159
        Me.RichMensajeSMS.Text = ""
        '
        'cmbTituloSMS
        '
        Me.cmbTituloSMS.DisplayMember = "Text"
        Me.cmbTituloSMS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTituloSMS.FormattingEnabled = True
        Me.cmbTituloSMS.ItemHeight = 20
        Me.cmbTituloSMS.Location = New System.Drawing.Point(196, 97)
        Me.cmbTituloSMS.Name = "cmbTituloSMS"
        Me.cmbTituloSMS.Size = New System.Drawing.Size(313, 26)
        Me.cmbTituloSMS.TabIndex = 157
        '
        'lblMensajeSMS
        '
        Me.lblMensajeSMS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblMensajeSMS.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblMensajeSMS.ForeColor = System.Drawing.Color.Navy
        Me.lblMensajeSMS.Location = New System.Drawing.Point(25, 129)
        Me.lblMensajeSMS.Name = "lblMensajeSMS"
        Me.lblMensajeSMS.Size = New System.Drawing.Size(148, 20)
        Me.lblMensajeSMS.TabIndex = 155
        Me.lblMensajeSMS.Text = "Texto del Mensaje"
        Me.lblMensajeSMS.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtSMSInd
        '
        '
        '
        '
        Me.txtSMSInd.Border.Class = "TextBoxBorder"
        Me.txtSMSInd.Location = New System.Drawing.Point(194, 51)
        Me.txtSMSInd.Name = "txtSMSInd"
        Me.txtSMSInd.Size = New System.Drawing.Size(313, 20)
        Me.txtSMSInd.TabIndex = 161
        Me.txtSMSInd.Visible = False
        '
        'lblTituloSMS
        '
        Me.lblTituloSMS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTituloSMS.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTituloSMS.ForeColor = System.Drawing.Color.Navy
        Me.lblTituloSMS.Location = New System.Drawing.Point(25, 97)
        Me.lblTituloSMS.Name = "lblTituloSMS"
        Me.lblTituloSMS.Size = New System.Drawing.Size(148, 20)
        Me.lblTituloSMS.TabIndex = 154
        Me.lblTituloSMS.Text = "Titulo del Mensaje"
        Me.lblTituloSMS.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblSMSInd
        '
        Me.lblSMSInd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSMSInd.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblSMSInd.ForeColor = System.Drawing.Color.Navy
        Me.lblSMSInd.Location = New System.Drawing.Point(23, 51)
        Me.lblSMSInd.Name = "lblSMSInd"
        Me.lblSMSInd.Size = New System.Drawing.Size(148, 20)
        Me.lblSMSInd.TabIndex = 160
        Me.lblSMSInd.Text = "Correo Electronico"
        Me.lblSMSInd.TextAlignment = System.Drawing.StringAlignment.Center
        Me.lblSMSInd.Visible = False
        '
        'btnSMSSalir
        '
        Me.btnSMSSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSMSSalir.Image = CType(resources.GetObject("btnSMSSalir.Image"), System.Drawing.Image)
        Me.btnSMSSalir.Location = New System.Drawing.Point(408, 415)
        Me.btnSMSSalir.Name = "btnSMSSalir"
        Me.btnSMSSalir.Size = New System.Drawing.Size(101, 39)
        Me.btnSMSSalir.TabIndex = 158
        Me.btnSMSSalir.Text = "SALIR"
        '
        'btnSMSEnviarInd
        '
        Me.btnSMSEnviarInd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSMSEnviarInd.Image = CType(resources.GetObject("btnSMSEnviarInd.Image"), System.Drawing.Image)
        Me.btnSMSEnviarInd.Location = New System.Drawing.Point(279, 415)
        Me.btnSMSEnviarInd.Name = "btnSMSEnviarInd"
        Me.btnSMSEnviarInd.Size = New System.Drawing.Size(101, 39)
        Me.btnSMSEnviarInd.TabIndex = 156
        Me.btnSMSEnviarInd.Text = "ENVIAR MENSAJES"
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(23, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(484, 23)
        Me.lblTituloVentana.TabIndex = 153
        Me.lblTituloVentana.Text = "ENVIO MENSAJES SMS INDIVUDUALES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmEnvioSMSInd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnvioSMSInd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Envio SMS Individual"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSMSCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RichMensajeSMS As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbTituloSMS As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblMensajeSMS As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSMSInd As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblTituloSMS As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblSMSInd As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSMSSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSMSEnviarInd As DevComponents.DotNetBar.ButtonX
End Class
