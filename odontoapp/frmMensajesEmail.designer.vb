<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajesEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMensajesEmail))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.gpEtiquetas = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnENomClinica = New DevComponents.DotNetBar.ButtonX
        Me.btnEDoc = New DevComponents.DotNetBar.ButtonX
        Me.btnECelClinica = New DevComponents.DotNetBar.ButtonX
        Me.btnETelefono = New DevComponents.DotNetBar.ButtonX
        Me.btnEprocedimiento = New DevComponents.DotNetBar.ButtonX
        Me.btnEHoraCita = New DevComponents.DotNetBar.ButtonX
        Me.btnEDiaCita = New DevComponents.DotNetBar.ButtonX
        Me.btnENomPac = New DevComponents.DotNetBar.ButtonX
        Me.gpCrearMensaje = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtIdMensaje = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.cmbTitulo = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.RichTxtMensaje = New System.Windows.Forms.RichTextBox
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpEtiquetas.SuspendLayout()
        Me.gpCrearMensaje.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.gpEtiquetas)
        Me.RibbonClientPanel1.Controls.Add(Me.gpCrearMensaje)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
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
        'gpEtiquetas
        '
        Me.gpEtiquetas.BackColor = System.Drawing.Color.Transparent
        Me.gpEtiquetas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpEtiquetas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpEtiquetas.Controls.Add(Me.btnENomClinica)
        Me.gpEtiquetas.Controls.Add(Me.btnEDoc)
        Me.gpEtiquetas.Controls.Add(Me.btnECelClinica)
        Me.gpEtiquetas.Controls.Add(Me.btnETelefono)
        Me.gpEtiquetas.Controls.Add(Me.btnEprocedimiento)
        Me.gpEtiquetas.Controls.Add(Me.btnEHoraCita)
        Me.gpEtiquetas.Controls.Add(Me.btnEDiaCita)
        Me.gpEtiquetas.Controls.Add(Me.btnENomPac)
        Me.gpEtiquetas.Location = New System.Drawing.Point(25, 284)
        Me.gpEtiquetas.Name = "gpEtiquetas"
        Me.gpEtiquetas.Size = New System.Drawing.Size(489, 104)
        '
        '
        '
        Me.gpEtiquetas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpEtiquetas.Style.BackColorGradientAngle = 90
        Me.gpEtiquetas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpEtiquetas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEtiquetas.Style.BorderBottomWidth = 1
        Me.gpEtiquetas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpEtiquetas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEtiquetas.Style.BorderLeftWidth = 1
        Me.gpEtiquetas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEtiquetas.Style.BorderRightWidth = 1
        Me.gpEtiquetas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpEtiquetas.Style.BorderTopWidth = 1
        Me.gpEtiquetas.Style.CornerDiameter = 4
        Me.gpEtiquetas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpEtiquetas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpEtiquetas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpEtiquetas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpEtiquetas.TabIndex = 165
        Me.gpEtiquetas.Text = "Etiquetas"
        '
        'btnENomClinica
        '
        Me.btnENomClinica.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnENomClinica.Location = New System.Drawing.Point(364, 46)
        Me.btnENomClinica.Name = "btnENomClinica"
        Me.btnENomClinica.Size = New System.Drawing.Size(112, 30)
        Me.btnENomClinica.TabIndex = 11
        Me.btnENomClinica.Text = "Nombre Clinica"
        Me.btnENomClinica.Tooltip = "Razon Social de la Clinica"
        '
        'btnEDoc
        '
        Me.btnEDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEDoc.Location = New System.Drawing.Point(246, 46)
        Me.btnEDoc.Name = "btnEDoc"
        Me.btnEDoc.Size = New System.Drawing.Size(112, 30)
        Me.btnEDoc.TabIndex = 10
        Me.btnEDoc.Text = "Nombre Doctor"
        Me.btnEDoc.Tooltip = "Nombre del Doctor predefinido"
        '
        'btnECelClinica
        '
        Me.btnECelClinica.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnECelClinica.Location = New System.Drawing.Point(128, 46)
        Me.btnECelClinica.Name = "btnECelClinica"
        Me.btnECelClinica.Size = New System.Drawing.Size(112, 30)
        Me.btnECelClinica.TabIndex = 9
        Me.btnECelClinica.Text = "Cel. Clinica"
        Me.btnECelClinica.Tooltip = "Celular de la Clinica"
        '
        'btnETelefono
        '
        Me.btnETelefono.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnETelefono.Location = New System.Drawing.Point(10, 46)
        Me.btnETelefono.Name = "btnETelefono"
        Me.btnETelefono.Size = New System.Drawing.Size(112, 30)
        Me.btnETelefono.TabIndex = 8
        Me.btnETelefono.Text = "Tel. Clinica"
        Me.btnETelefono.Tooltip = "Telefono principal de la Clinica"
        '
        'btnEprocedimiento
        '
        Me.btnEprocedimiento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEprocedimiento.Location = New System.Drawing.Point(364, 10)
        Me.btnEprocedimiento.Name = "btnEprocedimiento"
        Me.btnEprocedimiento.Size = New System.Drawing.Size(112, 30)
        Me.btnEprocedimiento.TabIndex = 7
        Me.btnEprocedimiento.Text = "Procedimiento"
        Me.btnEprocedimiento.Tooltip = "Procedimiento Asignado"
        '
        'btnEHoraCita
        '
        Me.btnEHoraCita.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEHoraCita.Location = New System.Drawing.Point(246, 10)
        Me.btnEHoraCita.Name = "btnEHoraCita"
        Me.btnEHoraCita.Size = New System.Drawing.Size(112, 30)
        Me.btnEHoraCita.TabIndex = 6
        Me.btnEHoraCita.Text = "Hora Cita"
        Me.btnEHoraCita.Tooltip = "Hora de la Cita"
        '
        'btnEDiaCita
        '
        Me.btnEDiaCita.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEDiaCita.Location = New System.Drawing.Point(128, 10)
        Me.btnEDiaCita.Name = "btnEDiaCita"
        Me.btnEDiaCita.Size = New System.Drawing.Size(112, 30)
        Me.btnEDiaCita.TabIndex = 5
        Me.btnEDiaCita.Text = "Fecha Cita"
        Me.btnEDiaCita.Tooltip = "Fecha de la cita"
        '
        'btnENomPac
        '
        Me.btnENomPac.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnENomPac.Location = New System.Drawing.Point(10, 10)
        Me.btnENomPac.Name = "btnENomPac"
        Me.btnENomPac.Size = New System.Drawing.Size(112, 30)
        Me.btnENomPac.TabIndex = 4
        Me.btnENomPac.Text = "Nombre Paciente"
        Me.btnENomPac.Tooltip = "Nombre Paciente"
        '
        'gpCrearMensaje
        '
        Me.gpCrearMensaje.BackColor = System.Drawing.Color.Transparent
        Me.gpCrearMensaje.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpCrearMensaje.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpCrearMensaje.Controls.Add(Me.LabelX1)
        Me.gpCrearMensaje.Controls.Add(Me.txtIdMensaje)
        Me.gpCrearMensaje.Controls.Add(Me.LabelX3)
        Me.gpCrearMensaje.Controls.Add(Me.cmbTitulo)
        Me.gpCrearMensaje.Controls.Add(Me.RichTxtMensaje)
        Me.gpCrearMensaje.Location = New System.Drawing.Point(25, 46)
        Me.gpCrearMensaje.Name = "gpCrearMensaje"
        Me.gpCrearMensaje.Size = New System.Drawing.Size(485, 231)
        '
        '
        '
        Me.gpCrearMensaje.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpCrearMensaje.Style.BackColorGradientAngle = 90
        Me.gpCrearMensaje.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpCrearMensaje.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCrearMensaje.Style.BorderBottomWidth = 1
        Me.gpCrearMensaje.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpCrearMensaje.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCrearMensaje.Style.BorderLeftWidth = 1
        Me.gpCrearMensaje.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCrearMensaje.Style.BorderRightWidth = 1
        Me.gpCrearMensaje.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpCrearMensaje.Style.BorderTopWidth = 1
        Me.gpCrearMensaje.Style.CornerDiameter = 4
        Me.gpCrearMensaje.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpCrearMensaje.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpCrearMensaje.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpCrearMensaje.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpCrearMensaje.TabIndex = 164
        Me.gpCrearMensaje.Text = "Crear Mensaje"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX1.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX1.ForeColor = System.Drawing.Color.Navy
        Me.LabelX1.Location = New System.Drawing.Point(18, 9)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(112, 20)
        Me.LabelX1.TabIndex = 132
        Me.LabelX1.Text = "Titulo del Mensaje"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'txtIdMensaje
        '
        '
        '
        '
        Me.txtIdMensaje.Border.Class = "TextBoxBorder"
        Me.txtIdMensaje.Location = New System.Drawing.Point(388, 36)
        Me.txtIdMensaje.Name = "txtIdMensaje"
        Me.txtIdMensaje.Size = New System.Drawing.Size(77, 20)
        Me.txtIdMensaje.TabIndex = 143
        Me.txtIdMensaje.Visible = False
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(18, 35)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(112, 20)
        Me.LabelX3.TabIndex = 133
        Me.LabelX3.Text = "Texto del Mensaje"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbTitulo
        '
        Me.cmbTitulo.DisplayMember = "Text"
        Me.cmbTitulo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTitulo.FormattingEnabled = True
        Me.cmbTitulo.ItemHeight = 15
        Me.cmbTitulo.Location = New System.Drawing.Point(141, 9)
        Me.cmbTitulo.Name = "cmbTitulo"
        Me.cmbTitulo.Size = New System.Drawing.Size(324, 21)
        Me.cmbTitulo.TabIndex = 1
        '
        'RichTxtMensaje
        '
        Me.RichTxtMensaje.Location = New System.Drawing.Point(18, 61)
        Me.RichTxtMensaje.Name = "RichTxtMensaje"
        Me.RichTxtMensaje.Size = New System.Drawing.Size(447, 136)
        Me.RichTxtMensaje.TabIndex = 2
        Me.RichTxtMensaje.Text = ""
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(217, 423)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 39)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(116, 423)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 39)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(418, 423)
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
        Me.btnEliminar.Location = New System.Drawing.Point(319, 423)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(96, 39)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "ELIMINAR"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(14, 423)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(96, 39)
        Me.btnAdicionar.TabIndex = 3
        Me.btnAdicionar.Text = "ADICIONAR"
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(25, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(485, 23)
        Me.lblTituloVentana.TabIndex = 125
        Me.lblTituloVentana.Text = "CREACION DE LOS MENSAJES"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmMensajesEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMensajesEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mensajes Email"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpEtiquetas.ResumeLayout(False)
        Me.gpCrearMensaje.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents RichTxtMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbTitulo As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIdMensaje As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents gpEtiquetas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnENomPac As DevComponents.DotNetBar.ButtonX
    Friend WithEvents gpCrearMensaje As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnENomClinica As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEDoc As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnECelClinica As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnETelefono As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEprocedimiento As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEHoraCita As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEDiaCita As DevComponents.DotNetBar.ButtonX
End Class
