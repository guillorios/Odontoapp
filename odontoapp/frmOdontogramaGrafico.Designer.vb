<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOdontogramaGrafico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOdontogramaGrafico))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.cmbGaleria = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtPosY = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtPosX = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.RichTxtMensaje = New System.Windows.Forms.RichTextBox
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.gpHerramientas = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem
        Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem
        Me.btnConvensiones = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnIncrustacion = New DevComponents.DotNetBar.ButtonX
        Me.btnDeshacer = New DevComponents.DotNetBar.ButtonX
        Me.btnAmalgama = New DevComponents.DotNetBar.ButtonX
        Me.btnSuperficieXSellar = New DevComponents.DotNetBar.ButtonX
        Me.btnRestauracion = New DevComponents.DotNetBar.ButtonX
        Me.btnAusenteEndodoncia = New DevComponents.DotNetBar.ButtonX
        Me.btnSuperficieSellada = New DevComponents.DotNetBar.ButtonX
        Me.btnProtesis = New DevComponents.DotNetBar.ButtonX
        Me.btnNucleo = New DevComponents.DotNetBar.ButtonX
        Me.btnEndodoncia = New DevComponents.DotNetBar.ButtonX
        Me.colorButton = New DevComponents.DotNetBar.ColorPickerButton
        Me.btnCorona = New DevComponents.DotNetBar.ButtonX
        Me.btnDienteAustente = New DevComponents.DotNetBar.ButtonX
        Me.btnProtesisFija = New DevComponents.DotNetBar.ButtonX
        Me.btnProtesisRemovible = New DevComponents.DotNetBar.ButtonX
        Me.btnPunto = New DevComponents.DotNetBar.ButtonX
        Me.btnBorrar = New DevComponents.DotNetBar.ButtonX
        Me.btnExodoncia = New DevComponents.DotNetBar.ButtonX
        Me.btnExtraccion = New DevComponents.DotNetBar.ButtonX
        Me.btnSuperficies = New DevComponents.DotNetBar.ButtonX
        Me.btnLapiz = New DevComponents.DotNetBar.ButtonX
        Me.pbxOdontograma = New System.Windows.Forms.PictureBox
        Me.RibbonClientPanel1.SuspendLayout()
        Me.gpHerramientas.SuspendLayout()
        CType(Me.pbxOdontograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnConvensiones)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbGaleria)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX4)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX2)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX1)
        Me.RibbonClientPanel1.Controls.Add(Me.txtPosY)
        Me.RibbonClientPanel1.Controls.Add(Me.txtPosX)
        Me.RibbonClientPanel1.Controls.Add(Me.RichTxtMensaje)
        Me.RibbonClientPanel1.Controls.Add(Me.LabelX3)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.gpHerramientas)
        Me.RibbonClientPanel1.Controls.Add(Me.pbxOdontograma)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(757, 474)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 0
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTituloVentana.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Location = New System.Drawing.Point(14, 12)
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.Size = New System.Drawing.Size(729, 23)
        Me.lblTituloVentana.TabIndex = 783
        Me.lblTituloVentana.Text = "ODONTOGRAMA"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'cmbGaleria
        '
        Me.cmbGaleria.AutoCompleteCustomSource.AddRange(New String() {"Radiografia de Perfil", "Senos Paranasales", "Panorámica", "ATM", "Coronales", "Anteroposterior", "Posteoanterior", "Periapical 1", "Periapical 2", "Periapical 3", "periapical 4", "Periapicales Completos"})
        Me.cmbGaleria.DisplayMember = "Text"
        Me.cmbGaleria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGaleria.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGaleria.FormattingEnabled = True
        Me.cmbGaleria.ItemHeight = 14
        Me.cmbGaleria.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cmbGaleria.Location = New System.Drawing.Point(96, 321)
        Me.cmbGaleria.Name = "cmbGaleria"
        Me.cmbGaleria.Size = New System.Drawing.Size(212, 20)
        Me.cmbGaleria.TabIndex = 782
        Me.cmbGaleria.WatermarkText = "Odontograma Actual"
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Inicial"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Actual"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX4.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX4.ForeColor = System.Drawing.Color.Navy
        Me.LabelX4.Location = New System.Drawing.Point(12, 321)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(78, 20)
        Me.LabelX4.TabIndex = 781
        Me.LabelX4.Text = "Odontograma"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(423, 321)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(47, 20)
        Me.LabelX2.TabIndex = 777
        Me.LabelX2.Text = "Pos X"
        '
        'LabelX1
        '
        Me.LabelX1.Location = New System.Drawing.Point(532, 321)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(47, 20)
        Me.LabelX1.TabIndex = 776
        Me.LabelX1.Text = "Pos Y"
        '
        'txtPosY
        '
        '
        '
        '
        Me.txtPosY.Border.Class = "TextBoxBorder"
        Me.txtPosY.Location = New System.Drawing.Point(591, 321)
        Me.txtPosY.Name = "txtPosY"
        Me.txtPosY.ReadOnly = True
        Me.txtPosY.Size = New System.Drawing.Size(47, 20)
        Me.txtPosY.TabIndex = 775
        Me.txtPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPosX
        '
        '
        '
        '
        Me.txtPosX.Border.Class = "TextBoxBorder"
        Me.txtPosX.Location = New System.Drawing.Point(479, 321)
        Me.txtPosX.Name = "txtPosX"
        Me.txtPosX.ReadOnly = True
        Me.txtPosX.Size = New System.Drawing.Size(47, 20)
        Me.txtPosX.TabIndex = 774
        Me.txtPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTxtMensaje
        '
        Me.RichTxtMensaje.Location = New System.Drawing.Point(96, 355)
        Me.RichTxtMensaje.Name = "RichTxtMensaje"
        Me.RichTxtMensaje.Size = New System.Drawing.Size(542, 67)
        Me.RichTxtMensaje.TabIndex = 772
        Me.RichTxtMensaje.Text = ""
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LabelX3.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.LabelX3.ForeColor = System.Drawing.Color.Navy
        Me.LabelX3.Location = New System.Drawing.Point(11, 355)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(78, 20)
        Me.LabelX3.TabIndex = 773
        Me.LabelX3.Text = "Observaciones"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'gpHerramientas
        '
        Me.gpHerramientas.BackColor = System.Drawing.Color.Transparent
        Me.gpHerramientas.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpHerramientas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpHerramientas.Controls.Add(Me.btnIncrustacion)
        Me.gpHerramientas.Controls.Add(Me.btnDeshacer)
        Me.gpHerramientas.Controls.Add(Me.btnAmalgama)
        Me.gpHerramientas.Controls.Add(Me.btnSuperficieXSellar)
        Me.gpHerramientas.Controls.Add(Me.btnRestauracion)
        Me.gpHerramientas.Controls.Add(Me.btnAusenteEndodoncia)
        Me.gpHerramientas.Controls.Add(Me.btnSuperficieSellada)
        Me.gpHerramientas.Controls.Add(Me.btnProtesis)
        Me.gpHerramientas.Controls.Add(Me.btnNucleo)
        Me.gpHerramientas.Controls.Add(Me.btnEndodoncia)
        Me.gpHerramientas.Controls.Add(Me.colorButton)
        Me.gpHerramientas.Controls.Add(Me.btnCorona)
        Me.gpHerramientas.Controls.Add(Me.btnDienteAustente)
        Me.gpHerramientas.Controls.Add(Me.btnProtesisFija)
        Me.gpHerramientas.Controls.Add(Me.btnProtesisRemovible)
        Me.gpHerramientas.Controls.Add(Me.btnPunto)
        Me.gpHerramientas.Controls.Add(Me.btnBorrar)
        Me.gpHerramientas.Controls.Add(Me.btnExodoncia)
        Me.gpHerramientas.Controls.Add(Me.btnExtraccion)
        Me.gpHerramientas.Controls.Add(Me.btnSuperficies)
        Me.gpHerramientas.Controls.Add(Me.btnLapiz)
        Me.gpHerramientas.Location = New System.Drawing.Point(647, 51)
        Me.gpHerramientas.Name = "gpHerramientas"
        Me.gpHerramientas.Size = New System.Drawing.Size(98, 411)
        '
        '
        '
        Me.gpHerramientas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpHerramientas.Style.BackColorGradientAngle = 90
        Me.gpHerramientas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpHerramientas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHerramientas.Style.BorderBottomWidth = 1
        Me.gpHerramientas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpHerramientas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHerramientas.Style.BorderLeftWidth = 1
        Me.gpHerramientas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHerramientas.Style.BorderRightWidth = 1
        Me.gpHerramientas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHerramientas.Style.BorderTopWidth = 1
        Me.gpHerramientas.Style.CornerDiameter = 4
        Me.gpHerramientas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpHerramientas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpHerramientas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpHerramientas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpHerramientas.TabIndex = 1
        Me.gpHerramientas.Text = "Herramientas"
        '
        'LabelItem1
        '
        Me.LabelItem1.GlobalItem = False
        Me.LabelItem1.Name = "LabelItem1"
        Me.LabelItem1.Text = "LabelItem1"
        '
        'LabelItem2
        '
        Me.LabelItem2.GlobalItem = False
        Me.LabelItem2.Name = "LabelItem2"
        Me.LabelItem2.Text = "LabelItem2"
        '
        'btnConvensiones
        '
        Me.btnConvensiones.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConvensiones.Image = CType(resources.GetObject("btnConvensiones.Image"), System.Drawing.Image)
        Me.btnConvensiones.Location = New System.Drawing.Point(300, 434)
        Me.btnConvensiones.Name = "btnConvensiones"
        Me.btnConvensiones.Size = New System.Drawing.Size(128, 31)
        Me.btnConvensiones.TabIndex = 784
        Me.btnConvensiones.Text = "CONVENSIONES"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(113, 434)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(96, 31)
        Me.btnNuevo.TabIndex = 780
        Me.btnNuevo.Text = "NUEVO"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.Location = New System.Drawing.Point(11, 434)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(96, 30)
        Me.btnModificar.TabIndex = 494
        Me.btnModificar.Text = "MODIFICAR"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(542, 434)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 30)
        Me.btnSalir.TabIndex = 493
        Me.btnSalir.Text = "SALIR"
        '
        'btnIncrustacion
        '
        Me.btnIncrustacion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIncrustacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncrustacion.Image = CType(resources.GetObject("btnIncrustacion.Image"), System.Drawing.Image)
        Me.btnIncrustacion.Location = New System.Drawing.Point(13, 76)
        Me.btnIncrustacion.Name = "btnIncrustacion"
        Me.btnIncrustacion.Size = New System.Drawing.Size(32, 32)
        Me.btnIncrustacion.TabIndex = 20
        Me.btnIncrustacion.Tooltip = "Incrustacion"
        '
        'btnDeshacer
        '
        Me.btnDeshacer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDeshacer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeshacer.Image = CType(resources.GetObject("btnDeshacer.Image"), System.Drawing.Image)
        Me.btnDeshacer.Location = New System.Drawing.Point(50, 42)
        Me.btnDeshacer.Name = "btnDeshacer"
        Me.btnDeshacer.Size = New System.Drawing.Size(32, 32)
        Me.btnDeshacer.TabIndex = 19
        Me.btnDeshacer.Tooltip = "Desahacer Odontograma"
        '
        'btnAmalgama
        '
        Me.btnAmalgama.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAmalgama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAmalgama.Image = CType(resources.GetObject("btnAmalgama.Image"), System.Drawing.Image)
        Me.btnAmalgama.Location = New System.Drawing.Point(13, 280)
        Me.btnAmalgama.Name = "btnAmalgama"
        Me.btnAmalgama.Size = New System.Drawing.Size(32, 32)
        Me.btnAmalgama.TabIndex = 18
        Me.btnAmalgama.Tooltip = "Amalgama"
        '
        'btnSuperficieXSellar
        '
        Me.btnSuperficieXSellar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSuperficieXSellar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuperficieXSellar.Image = CType(resources.GetObject("btnSuperficieXSellar.Image"), System.Drawing.Image)
        Me.btnSuperficieXSellar.Location = New System.Drawing.Point(13, 212)
        Me.btnSuperficieXSellar.Name = "btnSuperficieXSellar"
        Me.btnSuperficieXSellar.Size = New System.Drawing.Size(32, 32)
        Me.btnSuperficieXSellar.TabIndex = 17
        Me.btnSuperficieXSellar.Tooltip = "Superficie por Sellar"
        '
        'btnRestauracion
        '
        Me.btnRestauracion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnRestauracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestauracion.Image = CType(resources.GetObject("btnRestauracion.Image"), System.Drawing.Image)
        Me.btnRestauracion.Location = New System.Drawing.Point(50, 76)
        Me.btnRestauracion.Name = "btnRestauracion"
        Me.btnRestauracion.Size = New System.Drawing.Size(32, 32)
        Me.btnRestauracion.TabIndex = 16
        Me.btnRestauracion.Tooltip = "Restauracion"
        '
        'btnAusenteEndodoncia
        '
        Me.btnAusenteEndodoncia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAusenteEndodoncia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAusenteEndodoncia.Image = CType(resources.GetObject("btnAusenteEndodoncia.Image"), System.Drawing.Image)
        Me.btnAusenteEndodoncia.Location = New System.Drawing.Point(13, 246)
        Me.btnAusenteEndodoncia.Name = "btnAusenteEndodoncia"
        Me.btnAusenteEndodoncia.Size = New System.Drawing.Size(32, 32)
        Me.btnAusenteEndodoncia.TabIndex = 15
        Me.btnAusenteEndodoncia.Tooltip = "Ausente Endodoncia / Incrustacion"
        '
        'btnSuperficieSellada
        '
        Me.btnSuperficieSellada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSuperficieSellada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuperficieSellada.Image = CType(resources.GetObject("btnSuperficieSellada.Image"), System.Drawing.Image)
        Me.btnSuperficieSellada.Location = New System.Drawing.Point(50, 212)
        Me.btnSuperficieSellada.Name = "btnSuperficieSellada"
        Me.btnSuperficieSellada.Size = New System.Drawing.Size(32, 32)
        Me.btnSuperficieSellada.TabIndex = 14
        Me.btnSuperficieSellada.Tooltip = "Superficie Sellada"
        '
        'btnProtesis
        '
        Me.btnProtesis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProtesis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProtesis.Image = CType(resources.GetObject("btnProtesis.Image"), System.Drawing.Image)
        Me.btnProtesis.Location = New System.Drawing.Point(50, 280)
        Me.btnProtesis.Name = "btnProtesis"
        Me.btnProtesis.Size = New System.Drawing.Size(32, 32)
        Me.btnProtesis.TabIndex = 13
        Me.btnProtesis.Tooltip = "Diente sin Erupcionar / Protesis"
        '
        'btnNucleo
        '
        Me.btnNucleo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNucleo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNucleo.Image = CType(resources.GetObject("btnNucleo.Image"), System.Drawing.Image)
        Me.btnNucleo.Location = New System.Drawing.Point(50, 178)
        Me.btnNucleo.Name = "btnNucleo"
        Me.btnNucleo.Size = New System.Drawing.Size(32, 32)
        Me.btnNucleo.TabIndex = 12
        Me.btnNucleo.Tooltip = "Nucleo / Endodoncia por Realizar"
        '
        'btnEndodoncia
        '
        Me.btnEndodoncia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEndodoncia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEndodoncia.Image = CType(resources.GetObject("btnEndodoncia.Image"), System.Drawing.Image)
        Me.btnEndodoncia.Location = New System.Drawing.Point(13, 178)
        Me.btnEndodoncia.Name = "btnEndodoncia"
        Me.btnEndodoncia.Size = New System.Drawing.Size(32, 32)
        Me.btnEndodoncia.TabIndex = 11
        Me.btnEndodoncia.Tooltip = "Endodoncia Realizada"
        '
        'colorButton
        '
        Me.colorButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.colorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.colorButton.Image = CType(resources.GetObject("colorButton.Image"), System.Drawing.Image)
        Me.colorButton.Location = New System.Drawing.Point(13, 357)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.colorButton.Size = New System.Drawing.Size(69, 24)
        Me.colorButton.TabIndex = 10
        '
        'btnCorona
        '
        Me.btnCorona.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCorona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCorona.Image = CType(resources.GetObject("btnCorona.Image"), System.Drawing.Image)
        Me.btnCorona.Location = New System.Drawing.Point(50, 144)
        Me.btnCorona.Name = "btnCorona"
        Me.btnCorona.Size = New System.Drawing.Size(32, 32)
        Me.btnCorona.TabIndex = 9
        Me.btnCorona.Tooltip = "Corona"
        '
        'btnDienteAustente
        '
        Me.btnDienteAustente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDienteAustente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDienteAustente.Image = CType(resources.GetObject("btnDienteAustente.Image"), System.Drawing.Image)
        Me.btnDienteAustente.Location = New System.Drawing.Point(50, 315)
        Me.btnDienteAustente.Name = "btnDienteAustente"
        Me.btnDienteAustente.Size = New System.Drawing.Size(32, 32)
        Me.btnDienteAustente.TabIndex = 8
        Me.btnDienteAustente.Tooltip = "Diente Ausente"
        '
        'btnProtesisFija
        '
        Me.btnProtesisFija.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProtesisFija.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProtesisFija.Image = CType(resources.GetObject("btnProtesisFija.Image"), System.Drawing.Image)
        Me.btnProtesisFija.Location = New System.Drawing.Point(50, 110)
        Me.btnProtesisFija.Name = "btnProtesisFija"
        Me.btnProtesisFija.Size = New System.Drawing.Size(32, 32)
        Me.btnProtesisFija.TabIndex = 7
        Me.btnProtesisFija.Tooltip = "Protesis Fija"
        '
        'btnProtesisRemovible
        '
        Me.btnProtesisRemovible.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProtesisRemovible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProtesisRemovible.Image = CType(resources.GetObject("btnProtesisRemovible.Image"), System.Drawing.Image)
        Me.btnProtesisRemovible.Location = New System.Drawing.Point(13, 110)
        Me.btnProtesisRemovible.Name = "btnProtesisRemovible"
        Me.btnProtesisRemovible.Size = New System.Drawing.Size(32, 32)
        Me.btnProtesisRemovible.TabIndex = 6
        Me.btnProtesisRemovible.Tooltip = " Protesis Removible"
        '
        'btnPunto
        '
        Me.btnPunto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPunto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPunto.Image = CType(resources.GetObject("btnPunto.Image"), System.Drawing.Image)
        Me.btnPunto.Location = New System.Drawing.Point(13, 144)
        Me.btnPunto.Name = "btnPunto"
        Me.btnPunto.Size = New System.Drawing.Size(32, 32)
        Me.btnPunto.TabIndex = 5
        Me.btnPunto.Tooltip = "Punto Libre"
        '
        'btnBorrar
        '
        Me.btnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(13, 42)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(32, 32)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Tooltip = "Borrar Diente"
        '
        'btnExodoncia
        '
        Me.btnExodoncia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExodoncia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExodoncia.Image = CType(resources.GetObject("btnExodoncia.Image"), System.Drawing.Image)
        Me.btnExodoncia.Location = New System.Drawing.Point(50, 246)
        Me.btnExodoncia.Name = "btnExodoncia"
        Me.btnExodoncia.Size = New System.Drawing.Size(32, 32)
        Me.btnExodoncia.TabIndex = 3
        Me.btnExodoncia.Tooltip = "Exodoncia Indicada"
        '
        'btnExtraccion
        '
        Me.btnExtraccion.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExtraccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtraccion.Image = CType(resources.GetObject("btnExtraccion.Image"), System.Drawing.Image)
        Me.btnExtraccion.Location = New System.Drawing.Point(13, 315)
        Me.btnExtraccion.Name = "btnExtraccion"
        Me.btnExtraccion.Size = New System.Drawing.Size(32, 32)
        Me.btnExtraccion.TabIndex = 2
        Me.btnExtraccion.Tooltip = "Extraccion"
        '
        'btnSuperficies
        '
        Me.btnSuperficies.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSuperficies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuperficies.Image = CType(resources.GetObject("btnSuperficies.Image"), System.Drawing.Image)
        Me.btnSuperficies.Location = New System.Drawing.Point(50, 8)
        Me.btnSuperficies.Name = "btnSuperficies"
        Me.btnSuperficies.Size = New System.Drawing.Size(32, 32)
        Me.btnSuperficies.TabIndex = 1
        Me.btnSuperficies.Tooltip = "Superficies"
        '
        'btnLapiz
        '
        Me.btnLapiz.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLapiz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLapiz.Image = CType(resources.GetObject("btnLapiz.Image"), System.Drawing.Image)
        Me.btnLapiz.Location = New System.Drawing.Point(13, 8)
        Me.btnLapiz.Name = "btnLapiz"
        Me.btnLapiz.Size = New System.Drawing.Size(32, 32)
        Me.btnLapiz.TabIndex = 0
        Me.btnLapiz.Tooltip = "Lapiz Libre"
        '
        'pbxOdontograma
        '
        Me.pbxOdontograma.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbxOdontograma.Image = Global.Orthosoft.My.Resources.Resources.OdontoIni
        Me.pbxOdontograma.Location = New System.Drawing.Point(12, 61)
        Me.pbxOdontograma.Name = "pbxOdontograma"
        Me.pbxOdontograma.Size = New System.Drawing.Size(628, 254)
        Me.pbxOdontograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxOdontograma.TabIndex = 0
        Me.pbxOdontograma.TabStop = False
        '
        'frmOdontogramaGrafico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 474)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOdontogramaGrafico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Odontograma"
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.RibbonClientPanel1.PerformLayout()
        Me.gpHerramientas.ResumeLayout(False)
        CType(Me.pbxOdontograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents pbxOdontograma As System.Windows.Forms.PictureBox
    Friend WithEvents gpHerramientas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnCorona As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnProtesisFija As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnProtesisRemovible As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPunto As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBorrar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExodoncia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExtraccion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLapiz As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colorButton As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents btnNucleo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEndodoncia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDienteAustente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSuperficies As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RichTxtMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSuperficieSellada As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnProtesis As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRestauracion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAusenteEndodoncia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPosY As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPosX As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSuperficieXSellar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAmalgama As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbGaleria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnDeshacer As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnIncrustacion As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnConvensiones As DevComponents.DotNetBar.ButtonX
End Class
