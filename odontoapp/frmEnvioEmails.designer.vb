<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioEmails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvioEmails))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.prgBarraProgreso = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.gpFecha = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.cmbfecfin_email = New System.Windows.Forms.DateTimePicker
        Me.cmbfecini_email = New System.Windows.Forms.DateTimePicker
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.btnEmailCrear = New DevComponents.DotNetBar.ButtonX
        Me.lblTituloConsulta = New DevComponents.DotNetBar.LabelX
        Me.btnEmailSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnEmailEnviar = New DevComponents.DotNetBar.ButtonX
        Me.btnEmailCargar = New DevComponents.DotNetBar.ButtonX
        Me.dgConsultaEmail = New System.Windows.Forms.DataGridView
        Me.RichMensajeEmail = New System.Windows.Forms.RichTextBox
        Me.cmbTituloEmail = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblTextoMensaje = New DevComponents.DotNetBar.LabelX
        Me.lblTituloMensaje = New DevComponents.DotNetBar.LabelX
        Me.gpOpcionInforme = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtSMSTodos = New System.Windows.Forms.RadioButton
        Me.rbtEmailCumpleAños = New System.Windows.Forms.RadioButton
        Me.rbtEmailNoAsistieron = New System.Windows.Forms.RadioButton
        Me.rbtEmailCitas = New System.Windows.Forms.RadioButton
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpFecha.SuspendLayout()
        CType(Me.dgConsultaEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpOpcionInforme.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.prgBarraProgreso)
        Me.RibbonClientPanel1.Controls.Add(Me.gpFecha)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEmailCrear)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloConsulta)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEmailSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEmailEnviar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEmailCargar)
        Me.RibbonClientPanel1.Controls.Add(Me.dgConsultaEmail)
        Me.RibbonClientPanel1.Controls.Add(Me.RichMensajeEmail)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbTituloEmail)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTextoMensaje)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloMensaje)
        Me.RibbonClientPanel1.Controls.Add(Me.gpOpcionInforme)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'prgBarraProgreso
        '
        Me.prgBarraProgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prgBarraProgreso.Location = New System.Drawing.Point(25, 403)
        Me.prgBarraProgreso.Name = "prgBarraProgreso"
        Me.prgBarraProgreso.Size = New System.Drawing.Size(187, 23)
        Me.prgBarraProgreso.TabIndex = 147
        Me.prgBarraProgreso.Text = "PROGRESO %"
        Me.prgBarraProgreso.TextVisible = True
        '
        'gpFecha
        '
        Me.gpFecha.BackColor = System.Drawing.Color.Transparent
        Me.gpFecha.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFecha.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFecha.Controls.Add(Me.LabelX7)
        Me.gpFecha.Controls.Add(Me.cmbfecfin_email)
        Me.gpFecha.Controls.Add(Me.cmbfecini_email)
        Me.gpFecha.Controls.Add(Me.LabelX2)
        Me.gpFecha.Location = New System.Drawing.Point(336, 41)
        Me.gpFecha.Name = "gpFecha"
        Me.gpFecha.Size = New System.Drawing.Size(132, 131)
        '
        '
        '
        Me.gpFecha.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpFecha.Style.BackColorGradientAngle = 90
        Me.gpFecha.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpFecha.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFecha.Style.BorderBottomWidth = 1
        Me.gpFecha.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpFecha.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFecha.Style.BorderLeftWidth = 1
        Me.gpFecha.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFecha.Style.BorderRightWidth = 1
        Me.gpFecha.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpFecha.Style.BorderTopWidth = 1
        Me.gpFecha.Style.CornerDiameter = 4
        Me.gpFecha.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpFecha.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpFecha.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpFecha.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpFecha.TabIndex = 146
        Me.gpFecha.Text = "Rango fecha"
        Me.gpFecha.Visible = False
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX7.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX7.ForeColor = System.Drawing.Color.Navy
        Me.LabelX7.Location = New System.Drawing.Point(12, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(104, 20)
        Me.LabelX7.TabIndex = 143
        Me.LabelX7.Text = "Fecha Inicial"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbfecfin_email
        '
        Me.cmbfecfin_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecfin_email.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecfin_email.Location = New System.Drawing.Point(12, 79)
        Me.cmbfecfin_email.Name = "cmbfecfin_email"
        Me.cmbfecfin_email.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecfin_email.TabIndex = 144
        Me.cmbfecfin_email.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'cmbfecini_email
        '
        Me.cmbfecini_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecini_email.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecini_email.Location = New System.Drawing.Point(12, 29)
        Me.cmbfecini_email.Name = "cmbfecini_email"
        Me.cmbfecini_email.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecini_email.TabIndex = 142
        Me.cmbfecini_email.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX2.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX2.ForeColor = System.Drawing.Color.Navy
        Me.LabelX2.Location = New System.Drawing.Point(12, 56)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(104, 20)
        Me.LabelX2.TabIndex = 145
        Me.LabelX2.Text = "Fecha Final"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnEmailCrear
        '
        Me.btnEmailCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailCrear.Image = CType(resources.GetObject("btnEmailCrear.Image"), System.Drawing.Image)
        Me.btnEmailCrear.Location = New System.Drawing.Point(279, 435)
        Me.btnEmailCrear.Name = "btnEmailCrear"
        Me.btnEmailCrear.Size = New System.Drawing.Size(101, 39)
        Me.btnEmailCrear.TabIndex = 8
        Me.btnEmailCrear.Text = "CREAR MENSAJE"
        '
        'lblTituloConsulta
        '
        Me.lblTituloConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloConsulta.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloConsulta.Location = New System.Drawing.Point(25, 177)
        Me.lblTituloConsulta.Name = "lblTituloConsulta"
        Me.lblTituloConsulta.Size = New System.Drawing.Size(484, 21)
        Me.lblTituloConsulta.TabIndex = 136
        Me.lblTituloConsulta.Text = "Todos Los Pacientes Activos"
        Me.lblTituloConsulta.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnEmailSalir
        '
        Me.btnEmailSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailSalir.Image = CType(resources.GetObject("btnEmailSalir.Image"), System.Drawing.Image)
        Me.btnEmailSalir.Location = New System.Drawing.Point(406, 435)
        Me.btnEmailSalir.Name = "btnEmailSalir"
        Me.btnEmailSalir.Size = New System.Drawing.Size(101, 39)
        Me.btnEmailSalir.TabIndex = 9
        Me.btnEmailSalir.Text = "SALIR"
        '
        'btnEmailEnviar
        '
        Me.btnEmailEnviar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailEnviar.Enabled = False
        Me.btnEmailEnviar.Image = CType(resources.GetObject("btnEmailEnviar.Image"), System.Drawing.Image)
        Me.btnEmailEnviar.Location = New System.Drawing.Point(152, 435)
        Me.btnEmailEnviar.Name = "btnEmailEnviar"
        Me.btnEmailEnviar.Size = New System.Drawing.Size(101, 39)
        Me.btnEmailEnviar.TabIndex = 7
        Me.btnEmailEnviar.Text = "ENVIAR MENSAJES"
        '
        'btnEmailCargar
        '
        Me.btnEmailCargar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEmailCargar.Image = CType(resources.GetObject("btnEmailCargar.Image"), System.Drawing.Image)
        Me.btnEmailCargar.Location = New System.Drawing.Point(25, 435)
        Me.btnEmailCargar.Name = "btnEmailCargar"
        Me.btnEmailCargar.Size = New System.Drawing.Size(101, 39)
        Me.btnEmailCargar.TabIndex = 5
        Me.btnEmailCargar.Text = "CARGAR CONSULTA"
        '
        'dgConsultaEmail
        '
        Me.dgConsultaEmail.AllowUserToAddRows = False
        Me.dgConsultaEmail.AllowUserToDeleteRows = False
        Me.dgConsultaEmail.AllowUserToOrderColumns = True
        Me.dgConsultaEmail.AllowUserToResizeColumns = False
        Me.dgConsultaEmail.AllowUserToResizeRows = False
        Me.dgConsultaEmail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgConsultaEmail.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgConsultaEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgConsultaEmail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsultaEmail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConsultaEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConsultaEmail.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgConsultaEmail.EnableHeadersVisualStyles = False
        Me.dgConsultaEmail.Location = New System.Drawing.Point(25, 207)
        Me.dgConsultaEmail.MultiSelect = False
        Me.dgConsultaEmail.Name = "dgConsultaEmail"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsultaEmail.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgConsultaEmail.RowHeadersVisible = False
        Me.dgConsultaEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsultaEmail.Size = New System.Drawing.Size(484, 119)
        Me.dgConsultaEmail.TabIndex = 132
        '
        'RichMensajeEmail
        '
        Me.RichMensajeEmail.Location = New System.Drawing.Point(234, 364)
        Me.RichMensajeEmail.Name = "RichMensajeEmail"
        Me.RichMensajeEmail.ReadOnly = True
        Me.RichMensajeEmail.Size = New System.Drawing.Size(275, 65)
        Me.RichMensajeEmail.TabIndex = 131
        Me.RichMensajeEmail.Text = ""
        '
        'cmbTituloEmail
        '
        Me.cmbTituloEmail.DisplayMember = "Text"
        Me.cmbTituloEmail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTituloEmail.FormattingEnabled = True
        Me.cmbTituloEmail.ItemHeight = 20
        Me.cmbTituloEmail.Location = New System.Drawing.Point(234, 332)
        Me.cmbTituloEmail.Name = "cmbTituloEmail"
        Me.cmbTituloEmail.Size = New System.Drawing.Size(275, 26)
        Me.cmbTituloEmail.TabIndex = 130
        '
        'lblTextoMensaje
        '
        Me.lblTextoMensaje.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTextoMensaje.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTextoMensaje.ForeColor = System.Drawing.Color.Navy
        Me.lblTextoMensaje.Location = New System.Drawing.Point(25, 364)
        Me.lblTextoMensaje.Name = "lblTextoMensaje"
        Me.lblTextoMensaje.Size = New System.Drawing.Size(187, 20)
        Me.lblTextoMensaje.TabIndex = 129
        Me.lblTextoMensaje.Text = "Texto del Mensaje"
        Me.lblTextoMensaje.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloMensaje
        '
        Me.lblTituloMensaje.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTituloMensaje.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTituloMensaje.ForeColor = System.Drawing.Color.Navy
        Me.lblTituloMensaje.Location = New System.Drawing.Point(25, 332)
        Me.lblTituloMensaje.Name = "lblTituloMensaje"
        Me.lblTituloMensaje.Size = New System.Drawing.Size(187, 20)
        Me.lblTituloMensaje.TabIndex = 127
        Me.lblTituloMensaje.Text = "Titulo del Mensaje"
        Me.lblTituloMensaje.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpOpcionInforme
        '
        Me.gpOpcionInforme.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionInforme.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionInforme.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionInforme.Controls.Add(Me.rbtSMSTodos)
        Me.gpOpcionInforme.Controls.Add(Me.rbtEmailCumpleAños)
        Me.gpOpcionInforme.Controls.Add(Me.rbtEmailNoAsistieron)
        Me.gpOpcionInforme.Controls.Add(Me.rbtEmailCitas)
        Me.gpOpcionInforme.Location = New System.Drawing.Point(25, 42)
        Me.gpOpcionInforme.Name = "gpOpcionInforme"
        Me.gpOpcionInforme.Size = New System.Drawing.Size(293, 130)
        '
        '
        '
        Me.gpOpcionInforme.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpOpcionInforme.Style.BackColorGradientAngle = 90
        Me.gpOpcionInforme.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpOpcionInforme.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderBottomWidth = 1
        Me.gpOpcionInforme.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpOpcionInforme.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderLeftWidth = 1
        Me.gpOpcionInforme.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderRightWidth = 1
        Me.gpOpcionInforme.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpOpcionInforme.Style.BorderTopWidth = 1
        Me.gpOpcionInforme.Style.CornerDiameter = 4
        Me.gpOpcionInforme.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpOpcionInforme.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpOpcionInforme.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpOpcionInforme.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpOpcionInforme.TabIndex = 126
        Me.gpOpcionInforme.Text = "Opción Informe"
        '
        'rbtSMSTodos
        '
        Me.rbtSMSTodos.AutoSize = True
        Me.rbtSMSTodos.Checked = True
        Me.rbtSMSTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSMSTodos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtSMSTodos.Location = New System.Drawing.Point(15, 13)
        Me.rbtSMSTodos.Name = "rbtSMSTodos"
        Me.rbtSMSTodos.Size = New System.Drawing.Size(119, 19)
        Me.rbtSMSTodos.TabIndex = 1
        Me.rbtSMSTodos.TabStop = True
        Me.rbtSMSTodos.Text = "Pacientes Activos"
        Me.rbtSMSTodos.UseVisualStyleBackColor = True
        '
        'rbtEmailCumpleAños
        '
        Me.rbtEmailCumpleAños.AutoSize = True
        Me.rbtEmailCumpleAños.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEmailCumpleAños.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtEmailCumpleAños.Location = New System.Drawing.Point(15, 36)
        Me.rbtEmailCumpleAños.Name = "rbtEmailCumpleAños"
        Me.rbtEmailCumpleAños.Size = New System.Drawing.Size(242, 17)
        Me.rbtEmailCumpleAños.TabIndex = 2
        Me.rbtEmailCumpleAños.Text = "Pacientes que Cumplen años hoy - Calendario"
        Me.rbtEmailCumpleAños.UseVisualStyleBackColor = True
        '
        'rbtEmailNoAsistieron
        '
        Me.rbtEmailNoAsistieron.AutoSize = True
        Me.rbtEmailNoAsistieron.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEmailNoAsistieron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtEmailNoAsistieron.Location = New System.Drawing.Point(15, 82)
        Me.rbtEmailNoAsistieron.Name = "rbtEmailNoAsistieron"
        Me.rbtEmailNoAsistieron.Size = New System.Drawing.Size(241, 17)
        Me.rbtEmailNoAsistieron.TabIndex = 4
        Me.rbtEmailNoAsistieron.Text = "Pacientes que no Asistieron a su Cita - Rango"
        Me.rbtEmailNoAsistieron.UseVisualStyleBackColor = True
        '
        'rbtEmailCitas
        '
        Me.rbtEmailCitas.AutoSize = True
        Me.rbtEmailCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEmailCitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtEmailCitas.Location = New System.Drawing.Point(15, 59)
        Me.rbtEmailCitas.Name = "rbtEmailCitas"
        Me.rbtEmailCitas.Size = New System.Drawing.Size(160, 17)
        Me.rbtEmailCitas.TabIndex = 3
        Me.rbtEmailCitas.Text = "Pacientes con Citas - Rango"
        Me.rbtEmailCitas.UseVisualStyleBackColor = True
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(25, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(484, 23)
        Me.lblTituloVentana.TabIndex = 125
        Me.lblTituloVentana.Text = "ENVIO CORREO ELECTRONICO"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmEnvioEmails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnvioEmails"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = " Envio Emails"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpFecha.ResumeLayout(False)
        CType(Me.dgConsultaEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpOpcionInforme.ResumeLayout(False)
        Me.gpOpcionInforme.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpOpcionInforme As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtSMSTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEmailCumpleAños As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEmailNoAsistieron As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEmailCitas As System.Windows.Forms.RadioButton
    Friend WithEvents lblTextoMensaje As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTituloMensaje As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbTituloEmail As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents RichMensajeEmail As System.Windows.Forms.RichTextBox
    Friend WithEvents dgConsultaEmail As System.Windows.Forms.DataGridView
    Friend WithEvents btnEmailEnviar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEmailCargar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEmailSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTituloConsulta As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnEmailCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbfecfin_email As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecini_email As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpFecha As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents prgBarraProgreso As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
