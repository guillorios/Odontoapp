<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvioSMS))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.gpOpcionInforme = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtSMSTodos = New System.Windows.Forms.RadioButton
        Me.rbtSMSCumpleAños = New System.Windows.Forms.RadioButton
        Me.rbtSMSNoAsistieron = New System.Windows.Forms.RadioButton
        Me.rbtSMSCitas = New System.Windows.Forms.RadioButton
        Me.prgBarraProgreso = New DevComponents.DotNetBar.Controls.ProgressBarX
        Me.gpFecha = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.cmbfecfin_SMS = New System.Windows.Forms.DateTimePicker
        Me.cmbfecini_SMS = New System.Windows.Forms.DateTimePicker
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.btnSMSCrear = New DevComponents.DotNetBar.ButtonX
        Me.lblTituloConsulta = New DevComponents.DotNetBar.LabelX
        Me.btnSMSSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnSMSEnviar = New DevComponents.DotNetBar.ButtonX
        Me.btnSMSCargar = New DevComponents.DotNetBar.ButtonX
        Me.dgConsultaSMS = New System.Windows.Forms.DataGridView
        Me.RichMensajeSMS = New System.Windows.Forms.RichTextBox
        Me.cmbTituloSMS = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblTextoMensaje = New DevComponents.DotNetBar.LabelX
        Me.lblTituloMensaje = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpOpcionInforme.SuspendLayout()
        Me.gpFecha.SuspendLayout()
        CType(Me.dgConsultaSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.gpOpcionInforme)
        Me.RibbonClientPanel1.Controls.Add(Me.prgBarraProgreso)
        Me.RibbonClientPanel1.Controls.Add(Me.gpFecha)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSMSCrear)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloConsulta)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSMSSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSMSEnviar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSMSCargar)
        Me.RibbonClientPanel1.Controls.Add(Me.dgConsultaSMS)
        Me.RibbonClientPanel1.Controls.Add(Me.RichMensajeSMS)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbTituloSMS)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTextoMensaje)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloMensaje)
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
        'gpOpcionInforme
        '
        Me.gpOpcionInforme.BackColor = System.Drawing.Color.Transparent
        Me.gpOpcionInforme.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpOpcionInforme.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpOpcionInforme.Controls.Add(Me.rbtSMSTodos)
        Me.gpOpcionInforme.Controls.Add(Me.rbtSMSCumpleAños)
        Me.gpOpcionInforme.Controls.Add(Me.rbtSMSNoAsistieron)
        Me.gpOpcionInforme.Controls.Add(Me.rbtSMSCitas)
        Me.gpOpcionInforme.Location = New System.Drawing.Point(23, 42)
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
        Me.gpOpcionInforme.TabIndex = 163
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
        'rbtSMSCumpleAños
        '
        Me.rbtSMSCumpleAños.AutoSize = True
        Me.rbtSMSCumpleAños.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSMSCumpleAños.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtSMSCumpleAños.Location = New System.Drawing.Point(15, 36)
        Me.rbtSMSCumpleAños.Name = "rbtSMSCumpleAños"
        Me.rbtSMSCumpleAños.Size = New System.Drawing.Size(242, 17)
        Me.rbtSMSCumpleAños.TabIndex = 2
        Me.rbtSMSCumpleAños.Text = "Pacientes que Cumplen años hoy - Calendario"
        Me.rbtSMSCumpleAños.UseVisualStyleBackColor = True
        '
        'rbtSMSNoAsistieron
        '
        Me.rbtSMSNoAsistieron.AutoSize = True
        Me.rbtSMSNoAsistieron.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSMSNoAsistieron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtSMSNoAsistieron.Location = New System.Drawing.Point(15, 82)
        Me.rbtSMSNoAsistieron.Name = "rbtSMSNoAsistieron"
        Me.rbtSMSNoAsistieron.Size = New System.Drawing.Size(241, 17)
        Me.rbtSMSNoAsistieron.TabIndex = 4
        Me.rbtSMSNoAsistieron.Text = "Pacientes que no Asistieron a su Cita - Rango"
        Me.rbtSMSNoAsistieron.UseVisualStyleBackColor = True
        '
        'rbtSMSCitas
        '
        Me.rbtSMSCitas.AutoSize = True
        Me.rbtSMSCitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSMSCitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbtSMSCitas.Location = New System.Drawing.Point(15, 59)
        Me.rbtSMSCitas.Name = "rbtSMSCitas"
        Me.rbtSMSCitas.Size = New System.Drawing.Size(160, 17)
        Me.rbtSMSCitas.TabIndex = 3
        Me.rbtSMSCitas.Text = "Pacientes con Citas - Rango"
        Me.rbtSMSCitas.UseVisualStyleBackColor = True
        '
        'prgBarraProgreso
        '
        Me.prgBarraProgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prgBarraProgreso.Location = New System.Drawing.Point(23, 406)
        Me.prgBarraProgreso.Name = "prgBarraProgreso"
        Me.prgBarraProgreso.Size = New System.Drawing.Size(187, 23)
        Me.prgBarraProgreso.TabIndex = 162
        Me.prgBarraProgreso.Text = "PROGRESO %"
        Me.prgBarraProgreso.TextVisible = True
        '
        'gpFecha
        '
        Me.gpFecha.BackColor = System.Drawing.Color.Transparent
        Me.gpFecha.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpFecha.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpFecha.Controls.Add(Me.LabelX7)
        Me.gpFecha.Controls.Add(Me.cmbfecfin_SMS)
        Me.gpFecha.Controls.Add(Me.cmbfecini_SMS)
        Me.gpFecha.Controls.Add(Me.LabelX2)
        Me.gpFecha.Location = New System.Drawing.Point(334, 41)
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
        Me.gpFecha.TabIndex = 161
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
        'cmbfecfin_SMS
        '
        Me.cmbfecfin_SMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecfin_SMS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecfin_SMS.Location = New System.Drawing.Point(12, 79)
        Me.cmbfecfin_SMS.Name = "cmbfecfin_SMS"
        Me.cmbfecfin_SMS.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecfin_SMS.TabIndex = 144
        Me.cmbfecfin_SMS.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'cmbfecini_SMS
        '
        Me.cmbfecini_SMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfecini_SMS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfecini_SMS.Location = New System.Drawing.Point(12, 29)
        Me.cmbfecini_SMS.Name = "cmbfecini_SMS"
        Me.cmbfecini_SMS.Size = New System.Drawing.Size(104, 23)
        Me.cmbfecini_SMS.TabIndex = 142
        Me.cmbfecini_SMS.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
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
        'btnSMSCrear
        '
        Me.btnSMSCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSMSCrear.Image = CType(resources.GetObject("btnSMSCrear.Image"), System.Drawing.Image)
        Me.btnSMSCrear.Location = New System.Drawing.Point(277, 435)
        Me.btnSMSCrear.Name = "btnSMSCrear"
        Me.btnSMSCrear.Size = New System.Drawing.Size(101, 39)
        Me.btnSMSCrear.TabIndex = 150
        Me.btnSMSCrear.Text = "CREAR MENSAJE"
        '
        'lblTituloConsulta
        '
        Me.lblTituloConsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloConsulta.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloConsulta.Location = New System.Drawing.Point(23, 177)
        Me.lblTituloConsulta.Name = "lblTituloConsulta"
        Me.lblTituloConsulta.Size = New System.Drawing.Size(484, 21)
        Me.lblTituloConsulta.TabIndex = 159
        Me.lblTituloConsulta.Text = "Todos Los Pacientes Activos"
        Me.lblTituloConsulta.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btnSMSSalir
        '
        Me.btnSMSSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSMSSalir.Image = CType(resources.GetObject("btnSMSSalir.Image"), System.Drawing.Image)
        Me.btnSMSSalir.Location = New System.Drawing.Point(404, 435)
        Me.btnSMSSalir.Name = "btnSMSSalir"
        Me.btnSMSSalir.Size = New System.Drawing.Size(101, 39)
        Me.btnSMSSalir.TabIndex = 151
        Me.btnSMSSalir.Text = "SALIR"
        '
        'btnSMSEnviar
        '
        Me.btnSMSEnviar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSMSEnviar.Enabled = False
        Me.btnSMSEnviar.Image = CType(resources.GetObject("btnSMSEnviar.Image"), System.Drawing.Image)
        Me.btnSMSEnviar.Location = New System.Drawing.Point(150, 435)
        Me.btnSMSEnviar.Name = "btnSMSEnviar"
        Me.btnSMSEnviar.Size = New System.Drawing.Size(101, 39)
        Me.btnSMSEnviar.TabIndex = 149
        Me.btnSMSEnviar.Text = "ENVIAR MENSAJES"
        '
        'btnSMSCargar
        '
        Me.btnSMSCargar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSMSCargar.Image = CType(resources.GetObject("btnSMSCargar.Image"), System.Drawing.Image)
        Me.btnSMSCargar.Location = New System.Drawing.Point(23, 435)
        Me.btnSMSCargar.Name = "btnSMSCargar"
        Me.btnSMSCargar.Size = New System.Drawing.Size(101, 39)
        Me.btnSMSCargar.TabIndex = 148
        Me.btnSMSCargar.Text = "CARGAR CONSULTA"
        '
        'dgConsultaSMS
        '
        Me.dgConsultaSMS.AllowUserToAddRows = False
        Me.dgConsultaSMS.AllowUserToDeleteRows = False
        Me.dgConsultaSMS.AllowUserToOrderColumns = True
        Me.dgConsultaSMS.AllowUserToResizeColumns = False
        Me.dgConsultaSMS.AllowUserToResizeRows = False
        Me.dgConsultaSMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgConsultaSMS.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgConsultaSMS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgConsultaSMS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsultaSMS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgConsultaSMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgConsultaSMS.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgConsultaSMS.EnableHeadersVisualStyles = False
        Me.dgConsultaSMS.Location = New System.Drawing.Point(23, 207)
        Me.dgConsultaSMS.MultiSelect = False
        Me.dgConsultaSMS.Name = "dgConsultaSMS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgConsultaSMS.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgConsultaSMS.RowHeadersVisible = False
        Me.dgConsultaSMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgConsultaSMS.Size = New System.Drawing.Size(484, 119)
        Me.dgConsultaSMS.TabIndex = 158
        '
        'RichMensajeSMS
        '
        Me.RichMensajeSMS.Location = New System.Drawing.Point(232, 364)
        Me.RichMensajeSMS.Name = "RichMensajeSMS"
        Me.RichMensajeSMS.ReadOnly = True
        Me.RichMensajeSMS.Size = New System.Drawing.Size(275, 65)
        Me.RichMensajeSMS.TabIndex = 157
        Me.RichMensajeSMS.Text = ""
        '
        'cmbTituloSMS
        '
        Me.cmbTituloSMS.DisplayMember = "Text"
        Me.cmbTituloSMS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTituloSMS.FormattingEnabled = True
        Me.cmbTituloSMS.ItemHeight = 20
        Me.cmbTituloSMS.Location = New System.Drawing.Point(232, 332)
        Me.cmbTituloSMS.Name = "cmbTituloSMS"
        Me.cmbTituloSMS.Size = New System.Drawing.Size(275, 26)
        Me.cmbTituloSMS.TabIndex = 156
        '
        'lblTextoMensaje
        '
        Me.lblTextoMensaje.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTextoMensaje.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTextoMensaje.ForeColor = System.Drawing.Color.Navy
        Me.lblTextoMensaje.Location = New System.Drawing.Point(23, 364)
        Me.lblTextoMensaje.Name = "lblTextoMensaje"
        Me.lblTextoMensaje.Size = New System.Drawing.Size(187, 20)
        Me.lblTextoMensaje.TabIndex = 155
        Me.lblTextoMensaje.Text = "Texto del Mensaje"
        Me.lblTextoMensaje.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloMensaje
        '
        Me.lblTituloMensaje.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTituloMensaje.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblTituloMensaje.ForeColor = System.Drawing.Color.Navy
        Me.lblTituloMensaje.Location = New System.Drawing.Point(23, 332)
        Me.lblTituloMensaje.Name = "lblTituloMensaje"
        Me.lblTituloMensaje.Size = New System.Drawing.Size(187, 20)
        Me.lblTituloMensaje.TabIndex = 154
        Me.lblTituloMensaje.Text = "Titulo del Mensaje"
        Me.lblTituloMensaje.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(23, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(484, 23)
        Me.lblTituloVentana.TabIndex = 152
        Me.lblTituloVentana.Text = "ENVIO MENSAJES SMS"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frmEnvioSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 486)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEnvioSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Envio SMS"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpOpcionInforme.ResumeLayout(False)
        Me.gpOpcionInforme.PerformLayout()
        Me.gpFecha.ResumeLayout(False)
        CType(Me.dgConsultaSMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Private WithEvents prgBarraProgreso As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents gpFecha As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfecfin_SMS As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbfecini_SMS As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSMSCrear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblTituloConsulta As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSMSSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSMSEnviar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSMSCargar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgConsultaSMS As System.Windows.Forms.DataGridView
    Friend WithEvents RichMensajeSMS As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbTituloSMS As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblTextoMensaje As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTituloMensaje As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents gpOpcionInforme As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtSMSTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSMSCumpleAños As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSMSNoAsistieron As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSMSCitas As System.Windows.Forms.RadioButton
End Class
