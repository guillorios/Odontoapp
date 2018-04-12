<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointment))
        Me.GroupDoctor = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbDoctores = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.GroupAsistio = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtAsistioSi = New System.Windows.Forms.RadioButton
        Me.rbtAsistioNo = New System.Windows.Forms.RadioButton
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.GroupNotaCita = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.btnCitaModificar2 = New DevComponents.DotNetBar.ButtonX
        Me.txtnotacita = New System.Windows.Forms.RichTextBox
        Me.GroupCitaCancelada = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbtCanceladaNo = New System.Windows.Forms.RadioButton
        Me.rbtCanceladaSi = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupTipoConsulta = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cmbTipoConsulta = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.lblTipoConsulta = New DevComponents.DotNetBar.LabelX
        Me.imgAppointments = New System.Windows.Forms.ImageList(Me.components)
        Me.imgMain = New System.Windows.Forms.ImageList(Me.components)
        Me.schedulePrintDocument1 = New Janus.Windows.Schedule.SchedulePrintDocument
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblapellidos_pac = New DevComponents.DotNetBar.LabelX
        Me.cmbRangoAgenda = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.gpUnidades = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.dgUnidades = New System.Windows.Forms.DataGridView
        Me.OK = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btnCitaEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnCitaImprimir = New DevComponents.DotNetBar.ButtonX
        Me.ImageScheduler = New System.Windows.Forms.ImageList(Me.components)
        Me.RibbonClientPanel2 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnCitaModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnCitaAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.ScheduleOrhosoftMulti = New Janus.Windows.Schedule.Schedule
        Me.gpVista = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.GroupDoctor.SuspendLayout()
        Me.GroupAsistio.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNotaCita.SuspendLayout()
        Me.GroupCitaCancelada.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupTipoConsulta.SuspendLayout()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpUnidades.SuspendLayout()
        CType(Me.dgUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonClientPanel2.SuspendLayout()
        CType(Me.ScheduleOrhosoftMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpVista.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupDoctor
        '
        Me.GroupDoctor.BackColor = System.Drawing.Color.Transparent
        Me.GroupDoctor.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupDoctor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupDoctor.Controls.Add(Me.cmbDoctores)
        Me.GroupDoctor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupDoctor.Location = New System.Drawing.Point(6, 4)
        Me.GroupDoctor.Name = "GroupDoctor"
        Me.GroupDoctor.Size = New System.Drawing.Size(242, 52)
        '
        '
        '
        Me.GroupDoctor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupDoctor.Style.BackColorGradientAngle = 90
        Me.GroupDoctor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupDoctor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderBottomWidth = 1
        Me.GroupDoctor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupDoctor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderLeftWidth = 1
        Me.GroupDoctor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderRightWidth = 1
        Me.GroupDoctor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupDoctor.Style.BorderTopWidth = 1
        Me.GroupDoctor.Style.CornerDiameter = 4
        Me.GroupDoctor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupDoctor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupDoctor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupDoctor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupDoctor.TabIndex = 11
        Me.GroupDoctor.Text = "Doctor"
        '
        'cmbDoctores
        '
        Me.cmbDoctores.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.cmbDoctores.DisplayMember = "Text"
        Me.cmbDoctores.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctores.FormattingEnabled = True
        Me.cmbDoctores.ItemHeight = 14
        Me.cmbDoctores.Location = New System.Drawing.Point(5, 4)
        Me.cmbDoctores.Name = "cmbDoctores"
        Me.cmbDoctores.Size = New System.Drawing.Size(226, 20)
        Me.cmbDoctores.TabIndex = 0
        '
        'GroupAsistio
        '
        Me.GroupAsistio.BackColor = System.Drawing.Color.Transparent
        Me.GroupAsistio.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupAsistio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupAsistio.Controls.Add(Me.rbtAsistioSi)
        Me.GroupAsistio.Controls.Add(Me.rbtAsistioNo)
        Me.GroupAsistio.Controls.Add(Me.PictureBox3)
        Me.GroupAsistio.Controls.Add(Me.PictureBox4)
        Me.GroupAsistio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAsistio.Location = New System.Drawing.Point(86, 243)
        Me.GroupAsistio.Name = "GroupAsistio"
        Me.GroupAsistio.Size = New System.Drawing.Size(75, 80)
        '
        '
        '
        Me.GroupAsistio.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupAsistio.Style.BackColorGradientAngle = 90
        Me.GroupAsistio.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupAsistio.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderBottomWidth = 1
        Me.GroupAsistio.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupAsistio.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderLeftWidth = 1
        Me.GroupAsistio.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderRightWidth = 1
        Me.GroupAsistio.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupAsistio.Style.BorderTopWidth = 1
        Me.GroupAsistio.Style.CornerDiameter = 4
        Me.GroupAsistio.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupAsistio.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupAsistio.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupAsistio.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupAsistio.TabIndex = 10
        Me.GroupAsistio.Text = "Asistió"
        '
        'rbtAsistioSi
        '
        Me.rbtAsistioSi.AutoSize = True
        Me.rbtAsistioSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAsistioSi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtAsistioSi.Location = New System.Drawing.Point(29, 6)
        Me.rbtAsistioSi.Name = "rbtAsistioSi"
        Me.rbtAsistioSi.Size = New System.Drawing.Size(40, 21)
        Me.rbtAsistioSi.TabIndex = 0
        Me.rbtAsistioSi.Text = "Si"
        Me.rbtAsistioSi.UseVisualStyleBackColor = True
        '
        'rbtAsistioNo
        '
        Me.rbtAsistioNo.AutoSize = True
        Me.rbtAsistioNo.Checked = True
        Me.rbtAsistioNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAsistioNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtAsistioNo.Location = New System.Drawing.Point(29, 30)
        Me.rbtAsistioNo.Name = "rbtAsistioNo"
        Me.rbtAsistioNo.Size = New System.Drawing.Size(46, 21)
        Me.rbtAsistioNo.TabIndex = 1
        Me.rbtAsistioNo.TabStop = True
        Me.rbtAsistioNo.Text = "No"
        Me.rbtAsistioNo.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(2, 31)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'GroupNotaCita
        '
        Me.GroupNotaCita.BackColor = System.Drawing.Color.Transparent
        Me.GroupNotaCita.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupNotaCita.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupNotaCita.Controls.Add(Me.btnCitaModificar2)
        Me.GroupNotaCita.Controls.Add(Me.txtnotacita)
        Me.GroupNotaCita.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupNotaCita.Location = New System.Drawing.Point(4, 327)
        Me.GroupNotaCita.Name = "GroupNotaCita"
        Me.GroupNotaCita.Size = New System.Drawing.Size(157, 58)
        '
        '
        '
        Me.GroupNotaCita.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupNotaCita.Style.BackColorGradientAngle = 90
        Me.GroupNotaCita.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupNotaCita.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderBottomWidth = 1
        Me.GroupNotaCita.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupNotaCita.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderLeftWidth = 1
        Me.GroupNotaCita.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderRightWidth = 1
        Me.GroupNotaCita.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupNotaCita.Style.BorderTopWidth = 1
        Me.GroupNotaCita.Style.CornerDiameter = 4
        Me.GroupNotaCita.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupNotaCita.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupNotaCita.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupNotaCita.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupNotaCita.TabIndex = 9
        Me.GroupNotaCita.Text = "Nota Cita"
        '
        'btnCitaModificar2
        '
        Me.btnCitaModificar2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaModificar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaModificar2.Image = CType(resources.GetObject("btnCitaModificar2.Image"), System.Drawing.Image)
        Me.btnCitaModificar2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaModificar2.Location = New System.Drawing.Point(120, 7)
        Me.btnCitaModificar2.Name = "btnCitaModificar2"
        Me.btnCitaModificar2.Size = New System.Drawing.Size(27, 26)
        Me.btnCitaModificar2.TabIndex = 3
        '
        'txtnotacita
        '
        Me.txtnotacita.Location = New System.Drawing.Point(4, 5)
        Me.txtnotacita.Name = "txtnotacita"
        Me.txtnotacita.Size = New System.Drawing.Size(112, 28)
        Me.txtnotacita.TabIndex = 0
        Me.txtnotacita.Text = ""
        '
        'GroupCitaCancelada
        '
        Me.GroupCitaCancelada.BackColor = System.Drawing.Color.Transparent
        Me.GroupCitaCancelada.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupCitaCancelada.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupCitaCancelada.Controls.Add(Me.rbtCanceladaNo)
        Me.GroupCitaCancelada.Controls.Add(Me.rbtCanceladaSi)
        Me.GroupCitaCancelada.Controls.Add(Me.PictureBox1)
        Me.GroupCitaCancelada.Controls.Add(Me.PictureBox2)
        Me.GroupCitaCancelada.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCitaCancelada.Location = New System.Drawing.Point(4, 243)
        Me.GroupCitaCancelada.Name = "GroupCitaCancelada"
        Me.GroupCitaCancelada.Size = New System.Drawing.Size(79, 80)
        '
        '
        '
        Me.GroupCitaCancelada.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupCitaCancelada.Style.BackColorGradientAngle = 90
        Me.GroupCitaCancelada.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupCitaCancelada.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderBottomWidth = 1
        Me.GroupCitaCancelada.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupCitaCancelada.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderLeftWidth = 1
        Me.GroupCitaCancelada.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderRightWidth = 1
        Me.GroupCitaCancelada.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupCitaCancelada.Style.BorderTopWidth = 1
        Me.GroupCitaCancelada.Style.CornerDiameter = 4
        Me.GroupCitaCancelada.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupCitaCancelada.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupCitaCancelada.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupCitaCancelada.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupCitaCancelada.TabIndex = 10
        Me.GroupCitaCancelada.Text = "Cancelada"
        '
        'rbtCanceladaNo
        '
        Me.rbtCanceladaNo.AutoSize = True
        Me.rbtCanceladaNo.Checked = True
        Me.rbtCanceladaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCanceladaNo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtCanceladaNo.Location = New System.Drawing.Point(30, 33)
        Me.rbtCanceladaNo.Name = "rbtCanceladaNo"
        Me.rbtCanceladaNo.Size = New System.Drawing.Size(46, 21)
        Me.rbtCanceladaNo.TabIndex = 1
        Me.rbtCanceladaNo.TabStop = True
        Me.rbtCanceladaNo.Text = "No"
        Me.rbtCanceladaNo.UseVisualStyleBackColor = True
        '
        'rbtCanceladaSi
        '
        Me.rbtCanceladaSi.AutoSize = True
        Me.rbtCanceladaSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCanceladaSi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rbtCanceladaSi.Location = New System.Drawing.Point(30, 6)
        Me.rbtCanceladaSi.Name = "rbtCanceladaSi"
        Me.rbtCanceladaSi.Size = New System.Drawing.Size(40, 21)
        Me.rbtCanceladaSi.TabIndex = 0
        Me.rbtCanceladaSi.Text = "Si"
        Me.rbtCanceladaSi.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 24)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'GroupTipoConsulta
        '
        Me.GroupTipoConsulta.BackColor = System.Drawing.Color.Transparent
        Me.GroupTipoConsulta.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupTipoConsulta.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupTipoConsulta.Controls.Add(Me.cmbTipoConsulta)
        Me.GroupTipoConsulta.Controls.Add(Me.lblTipoConsulta)
        Me.GroupTipoConsulta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTipoConsulta.Location = New System.Drawing.Point(253, 4)
        Me.GroupTipoConsulta.Name = "GroupTipoConsulta"
        Me.GroupTipoConsulta.Size = New System.Drawing.Size(277, 53)
        '
        '
        '
        Me.GroupTipoConsulta.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupTipoConsulta.Style.BackColorGradientAngle = 90
        Me.GroupTipoConsulta.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupTipoConsulta.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderBottomWidth = 1
        Me.GroupTipoConsulta.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupTipoConsulta.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderLeftWidth = 1
        Me.GroupTipoConsulta.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderRightWidth = 1
        Me.GroupTipoConsulta.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupTipoConsulta.Style.BorderTopWidth = 1
        Me.GroupTipoConsulta.Style.CornerDiameter = 4
        Me.GroupTipoConsulta.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupTipoConsulta.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupTipoConsulta.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupTipoConsulta.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupTipoConsulta.TabIndex = 8
        Me.GroupTipoConsulta.Text = "Tipo Consulta"
        '
        'cmbTipoConsulta
        '
        Me.cmbTipoConsulta.AutoCompleteCustomSource.AddRange(New String() {"Cedula", "T.I", "Pasaporte"})
        Me.cmbTipoConsulta.DisplayMember = "Text"
        Me.cmbTipoConsulta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTipoConsulta.FormattingEnabled = True
        Me.cmbTipoConsulta.ItemHeight = 14
        Me.cmbTipoConsulta.Location = New System.Drawing.Point(3, 6)
        Me.cmbTipoConsulta.Name = "cmbTipoConsulta"
        Me.cmbTipoConsulta.Size = New System.Drawing.Size(232, 20)
        Me.cmbTipoConsulta.TabIndex = 2
        '
        'lblTipoConsulta
        '
        Me.lblTipoConsulta.BackColor = System.Drawing.Color.Beige
        Me.lblTipoConsulta.BorderType = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblTipoConsulta.Location = New System.Drawing.Point(241, 4)
        Me.lblTipoConsulta.Name = "lblTipoConsulta"
        Me.lblTipoConsulta.Size = New System.Drawing.Size(26, 22)
        Me.lblTipoConsulta.TabIndex = 1
        '
        'imgAppointments
        '
        Me.imgAppointments.ImageStream = CType(resources.GetObject("imgAppointments.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgAppointments.TransparentColor = System.Drawing.Color.Transparent
        Me.imgAppointments.Images.SetKeyName(0, "")
        Me.imgAppointments.Images.SetKeyName(1, "")
        Me.imgAppointments.Images.SetKeyName(2, "")
        Me.imgAppointments.Images.SetKeyName(3, "")
        Me.imgAppointments.Images.SetKeyName(4, "")
        Me.imgAppointments.Images.SetKeyName(5, "")
        '
        'imgMain
        '
        Me.imgMain.ImageStream = CType(resources.GetObject("imgMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMain.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMain.Images.SetKeyName(0, "")
        Me.imgMain.Images.SetKeyName(1, "")
        Me.imgMain.Images.SetKeyName(2, "")
        Me.imgMain.Images.SetKeyName(3, "")
        Me.imgMain.Images.SetKeyName(4, "")
        Me.imgMain.Images.SetKeyName(5, "")
        Me.imgMain.Images.SetKeyName(6, "")
        Me.imgMain.Images.SetKeyName(7, "")
        Me.imgMain.Images.SetKeyName(8, "")
        Me.imgMain.Images.SetKeyName(9, "")
        Me.imgMain.Images.SetKeyName(10, "")
        '
        'schedulePrintDocument1
        '
        Me.schedulePrintDocument1.DayFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedulePrintDocument1.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedulePrintDocument1.FooterRight = "11/20/2001"
        Me.schedulePrintDocument1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedulePrintDocument1.MonthFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedulePrintDocument1.WeekFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.gpVista)
        Me.RibbonClientPanel1.Controls.Add(Me.lblapellidos_pac)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbRangoAgenda)
        Me.RibbonClientPanel1.Controls.Add(Me.gpUnidades)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupAsistio)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupNotaCita)
        Me.RibbonClientPanel1.Controls.Add(Me.GroupCitaCancelada)
        Me.RibbonClientPanel1.Controls.Add(Me.btnCitaEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnCitaImprimir)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(674, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(166, 489)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 12
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'lblapellidos_pac
        '
        Me.lblapellidos_pac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblapellidos_pac.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblapellidos_pac.ForeColor = System.Drawing.Color.Navy
        Me.lblapellidos_pac.Location = New System.Drawing.Point(5, 389)
        Me.lblapellidos_pac.Name = "lblapellidos_pac"
        Me.lblapellidos_pac.Size = New System.Drawing.Size(155, 20)
        Me.lblapellidos_pac.TabIndex = 13
        Me.lblapellidos_pac.Text = "Intervalo Hora Agenda"
        Me.lblapellidos_pac.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbRangoAgenda
        '
        Me.cmbRangoAgenda.DisplayMember = "Text"
        Me.cmbRangoAgenda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbRangoAgenda.FormattingEnabled = True
        Me.cmbRangoAgenda.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cmbRangoAgenda.Location = New System.Drawing.Point(6, 412)
        Me.cmbRangoAgenda.Name = "cmbRangoAgenda"
        Me.cmbRangoAgenda.Size = New System.Drawing.Size(153, 21)
        Me.cmbRangoAgenda.TabIndex = 12
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "5 Minutos"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "10 Minutos"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "15 Minutos"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "30 Minutos"
        '
        'gpUnidades
        '
        Me.gpUnidades.BackColor = System.Drawing.Color.Transparent
        Me.gpUnidades.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpUnidades.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpUnidades.Controls.Add(Me.dgUnidades)
        Me.gpUnidades.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpUnidades.Location = New System.Drawing.Point(5, 70)
        Me.gpUnidades.Name = "gpUnidades"
        Me.gpUnidades.Size = New System.Drawing.Size(155, 168)
        '
        '
        '
        Me.gpUnidades.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpUnidades.Style.BackColorGradientAngle = 90
        Me.gpUnidades.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpUnidades.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidades.Style.BorderBottomWidth = 1
        Me.gpUnidades.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpUnidades.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidades.Style.BorderLeftWidth = 1
        Me.gpUnidades.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidades.Style.BorderRightWidth = 1
        Me.gpUnidades.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpUnidades.Style.BorderTopWidth = 1
        Me.gpUnidades.Style.CornerDiameter = 4
        Me.gpUnidades.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpUnidades.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpUnidades.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpUnidades.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpUnidades.TabIndex = 11
        Me.gpUnidades.Text = "Unidades"
        '
        'dgUnidades
        '
        Me.dgUnidades.AllowUserToAddRows = False
        Me.dgUnidades.AllowUserToDeleteRows = False
        Me.dgUnidades.AllowUserToResizeColumns = False
        Me.dgUnidades.AllowUserToResizeRows = False
        Me.dgUnidades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUnidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgUnidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OK})
        Me.dgUnidades.EnableHeadersVisualStyles = False
        Me.dgUnidades.Location = New System.Drawing.Point(5, 5)
        Me.dgUnidades.MultiSelect = False
        Me.dgUnidades.Name = "dgUnidades"
        Me.dgUnidades.RowHeadersVisible = False
        Me.dgUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUnidades.Size = New System.Drawing.Size(140, 137)
        Me.dgUnidades.TabIndex = 198
        '
        'OK
        '
        Me.OK.FalseValue = "0"
        Me.OK.HeaderText = "OK"
        Me.OK.Name = "OK"
        Me.OK.TrueValue = "1"
        Me.OK.Width = 30
        '
        'btnCitaEliminar
        '
        Me.btnCitaEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaEliminar.Image = CType(resources.GetObject("btnCitaEliminar.Image"), System.Drawing.Image)
        Me.btnCitaEliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaEliminar.Location = New System.Drawing.Point(57, 437)
        Me.btnCitaEliminar.Name = "btnCitaEliminar"
        Me.btnCitaEliminar.Size = New System.Drawing.Size(50, 44)
        Me.btnCitaEliminar.TabIndex = 6
        Me.btnCitaEliminar.Text = "Eliminar"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnSalir.Location = New System.Drawing.Point(109, 437)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(50, 44)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        '
        'btnCitaImprimir
        '
        Me.btnCitaImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaImprimir.Image = CType(resources.GetObject("btnCitaImprimir.Image"), System.Drawing.Image)
        Me.btnCitaImprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaImprimir.Location = New System.Drawing.Point(5, 437)
        Me.btnCitaImprimir.Name = "btnCitaImprimir"
        Me.btnCitaImprimir.Size = New System.Drawing.Size(50, 44)
        Me.btnCitaImprimir.TabIndex = 7
        Me.btnCitaImprimir.Text = "Imprimir"
        '
        'ImageScheduler
        '
        Me.ImageScheduler.ImageStream = CType(resources.GetObject("ImageScheduler.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageScheduler.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageScheduler.Images.SetKeyName(0, "")
        Me.ImageScheduler.Images.SetKeyName(1, "")
        Me.ImageScheduler.Images.SetKeyName(2, "alarmclock_stop.png")
        Me.ImageScheduler.Images.SetKeyName(3, "alarmclock_preferences.png")
        Me.ImageScheduler.Images.SetKeyName(4, "")
        Me.ImageScheduler.Images.SetKeyName(5, "")
        Me.ImageScheduler.Images.SetKeyName(6, "")
        Me.ImageScheduler.Images.SetKeyName(7, "")
        Me.ImageScheduler.Images.SetKeyName(8, "")
        Me.ImageScheduler.Images.SetKeyName(9, "")
        Me.ImageScheduler.Images.SetKeyName(10, "")
        Me.ImageScheduler.Images.SetKeyName(11, "")
        Me.ImageScheduler.Images.SetKeyName(12, "")
        Me.ImageScheduler.Images.SetKeyName(13, "")
        Me.ImageScheduler.Images.SetKeyName(14, "")
        Me.ImageScheduler.Images.SetKeyName(15, "")
        Me.ImageScheduler.Images.SetKeyName(16, "")
        Me.ImageScheduler.Images.SetKeyName(17, "")
        Me.ImageScheduler.Images.SetKeyName(18, "")
        Me.ImageScheduler.Images.SetKeyName(19, "")
        Me.ImageScheduler.Images.SetKeyName(20, "")
        Me.ImageScheduler.Images.SetKeyName(21, "")
        Me.ImageScheduler.Images.SetKeyName(22, "")
        Me.ImageScheduler.Images.SetKeyName(23, "help2.png")
        '
        'RibbonClientPanel2
        '
        Me.RibbonClientPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel2.Controls.Add(Me.btnCitaModificar)
        Me.RibbonClientPanel2.Controls.Add(Me.btnCitaAdicionar)
        Me.RibbonClientPanel2.Controls.Add(Me.GroupTipoConsulta)
        Me.RibbonClientPanel2.Controls.Add(Me.GroupDoctor)
        Me.RibbonClientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel2.Location = New System.Drawing.Point(0, 424)
        Me.RibbonClientPanel2.Name = "RibbonClientPanel2"
        Me.RibbonClientPanel2.Size = New System.Drawing.Size(674, 65)
        '
        '
        '
        Me.RibbonClientPanel2.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel2.TabIndex = 14
        Me.RibbonClientPanel2.Text = "RibbonClientPanel2"
        '
        'btnCitaModificar
        '
        Me.btnCitaModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaModificar.Image = CType(resources.GetObject("btnCitaModificar.Image"), System.Drawing.Image)
        Me.btnCitaModificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaModificar.Location = New System.Drawing.Point(611, 13)
        Me.btnCitaModificar.Name = "btnCitaModificar"
        Me.btnCitaModificar.Size = New System.Drawing.Size(57, 44)
        Me.btnCitaModificar.TabIndex = 13
        Me.btnCitaModificar.Text = "Modificar"
        Me.btnCitaModificar.Visible = False
        '
        'btnCitaAdicionar
        '
        Me.btnCitaAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCitaAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCitaAdicionar.Image = CType(resources.GetObject("btnCitaAdicionar.Image"), System.Drawing.Image)
        Me.btnCitaAdicionar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCitaAdicionar.Location = New System.Drawing.Point(551, 13)
        Me.btnCitaAdicionar.Name = "btnCitaAdicionar"
        Me.btnCitaAdicionar.Size = New System.Drawing.Size(57, 44)
        Me.btnCitaAdicionar.TabIndex = 12
        Me.btnCitaAdicionar.Text = "Adicionar"
        Me.btnCitaAdicionar.Visible = False
        '
        'ScheduleOrhosoftMulti
        '
        Me.ScheduleOrhosoftMulti.AllowDelete = False
        Me.ScheduleOrhosoftMulti.AllowEdit = False
        Me.ScheduleOrhosoftMulti.Date = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.ScheduleOrhosoftMulti.Dates.Add(New Date(2007, 1, 1, 0, 0, 0, 0))
        Me.ScheduleOrhosoftMulti.DayStartHour = 1
        Me.ScheduleOrhosoftMulti.Dock = System.Windows.Forms.DockStyle.Top
        Me.ScheduleOrhosoftMulti.FirstVisibleTime = System.TimeSpan.Parse("01:20:00")
        Me.ScheduleOrhosoftMulti.HourBackgroundStyle.BackColor = System.Drawing.Color.Navy
        Me.ScheduleOrhosoftMulti.ImageList = Me.ImageScheduler
        Me.ScheduleOrhosoftMulti.Interval = Janus.Windows.Schedule.Interval.FiveMinutes
        Me.ScheduleOrhosoftMulti.Location = New System.Drawing.Point(0, 0)
        Me.ScheduleOrhosoftMulti.MultiOwner = True
        Me.ScheduleOrhosoftMulti.Name = "ScheduleOrhosoftMulti"
        Me.ScheduleOrhosoftMulti.ShowAllDayArea = False
        Me.ScheduleOrhosoftMulti.ShowMinutesInTimeNavigator = True
        Me.ScheduleOrhosoftMulti.Size = New System.Drawing.Size(674, 424)
        Me.ScheduleOrhosoftMulti.TabIndex = 13
        Me.ScheduleOrhosoftMulti.WorkEndTime = System.TimeSpan.Parse("19:00:00")
        Me.ScheduleOrhosoftMulti.WorkingHourBackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'gpVista
        '
        Me.gpVista.BackColor = System.Drawing.Color.Transparent
        Me.gpVista.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpVista.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpVista.Controls.Add(Me.CheckBoxX2)
        Me.gpVista.Controls.Add(Me.CheckBoxX1)
        Me.gpVista.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpVista.Location = New System.Drawing.Point(4, 4)
        Me.gpVista.Name = "gpVista"
        Me.gpVista.Size = New System.Drawing.Size(157, 62)
        '
        '
        '
        Me.gpVista.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpVista.Style.BackColorGradientAngle = 90
        Me.gpVista.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpVista.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpVista.Style.BorderBottomWidth = 1
        Me.gpVista.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpVista.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpVista.Style.BorderLeftWidth = 1
        Me.gpVista.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpVista.Style.BorderRightWidth = 1
        Me.gpVista.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpVista.Style.BorderTopWidth = 1
        Me.gpVista.Style.CornerDiameter = 4
        Me.gpVista.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpVista.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpVista.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpVista.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpVista.TabIndex = 14
        Me.gpVista.Text = "Vista Agenda"
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX1.Location = New System.Drawing.Point(5, 18)
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Size = New System.Drawing.Size(131, 23)
        Me.CheckBoxX1.TabIndex = 0
        Me.CheckBoxX1.Text = "x Doctor"
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.CheckBoxX2.Checked = True
        Me.CheckBoxX2.Location = New System.Drawing.Point(5, -1)
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Size = New System.Drawing.Size(148, 23)
        Me.CheckBoxX2.TabIndex = 1
        Me.CheckBoxX2.Text = "x Unidad / Consultorio"
        '
        'frmAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 489)
        Me.Controls.Add(Me.RibbonClientPanel2)
        Me.Controls.Add(Me.ScheduleOrhosoftMulti)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAppointment"
        Me.Text = "MultiAgenda"
        Me.GroupDoctor.ResumeLayout(False)
        Me.GroupAsistio.ResumeLayout(False)
        Me.GroupAsistio.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNotaCita.ResumeLayout(False)
        Me.GroupCitaCancelada.ResumeLayout(False)
        Me.GroupCitaCancelada.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupTipoConsulta.ResumeLayout(False)
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.gpUnidades.ResumeLayout(False)
        CType(Me.dgUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonClientPanel2.ResumeLayout(False)
        CType(Me.ScheduleOrhosoftMulti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpVista.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgMain As System.Windows.Forms.ImageList
    Friend WithEvents imgAppointments As System.Windows.Forms.ImageList
    Friend WithEvents schedulePrintDocument1 As Janus.Windows.Schedule.SchedulePrintDocument
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCitaImprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCitaEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupTipoConsulta As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblTipoConsulta As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupNotaCita As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtnotacita As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupCitaCancelada As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtCanceladaNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCanceladaSi As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupAsistio As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbtAsistioSi As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAsistioNo As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupDoctor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbDoctores As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents RibbonClientPanel2 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents gpUnidades As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cmbRangoAgenda As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ImageScheduler As System.Windows.Forms.ImageList
    Friend WithEvents btnCitaModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCitaAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbTipoConsulta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dgUnidades As System.Windows.Forms.DataGridView
    Friend WithEvents OK As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ScheduleOrhosoftMulti As Janus.Windows.Schedule.Schedule
    Friend WithEvents btnCitaModificar2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblapellidos_pac As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents gpVista As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
