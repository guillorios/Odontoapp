<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcedimientoDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcedimientoDiario))
        Me.RibbonClientPanel1 = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.btnProcedCrear = New DevComponents.DotNetBar.ButtonX
        Me.memoProcedimiento = New System.Windows.Forms.RichTextBox
        Me.txtIdProced = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cmbProcedimientos = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.btnImprimirInforme = New DevComponents.DotNetBar.ButtonX
        Me.btnFirmaPaciente = New DevComponents.DotNetBar.ButtonX
        Me.btnFirmaOdonto = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminar = New DevComponents.DotNetBar.ButtonX
        Me.btnModificar = New DevComponents.DotNetBar.ButtonX
        Me.btnSalir = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevo = New DevComponents.DotNetBar.ButtonX
        Me.btnAdicionar = New DevComponents.DotNetBar.ButtonX
        Me.lblProcedimientos = New DevComponents.DotNetBar.LabelX
        Me.dgProcedimientos = New System.Windows.Forms.DataGridView
        Me.cmbfechaProced = New System.Windows.Forms.DateTimePicker
        Me.lblfechaProced = New DevComponents.DotNetBar.LabelX
        Me.lblTituloVentana = New DevComponents.DotNetBar.LabelX
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RibbonClientPanel1.SuspendLayout()
        CType(Me.dgProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.btnProcedCrear)
        Me.RibbonClientPanel1.Controls.Add(Me.memoProcedimiento)
        Me.RibbonClientPanel1.Controls.Add(Me.txtIdProced)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbProcedimientos)
        Me.RibbonClientPanel1.Controls.Add(Me.btnImprimirInforme)
        Me.RibbonClientPanel1.Controls.Add(Me.btnFirmaPaciente)
        Me.RibbonClientPanel1.Controls.Add(Me.btnFirmaOdonto)
        Me.RibbonClientPanel1.Controls.Add(Me.btnEliminar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnModificar)
        Me.RibbonClientPanel1.Controls.Add(Me.btnSalir)
        Me.RibbonClientPanel1.Controls.Add(Me.btnNuevo)
        Me.RibbonClientPanel1.Controls.Add(Me.btnAdicionar)
        Me.RibbonClientPanel1.Controls.Add(Me.lblProcedimientos)
        Me.RibbonClientPanel1.Controls.Add(Me.dgProcedimientos)
        Me.RibbonClientPanel1.Controls.Add(Me.cmbfechaProced)
        Me.RibbonClientPanel1.Controls.Add(Me.lblfechaProced)
        Me.RibbonClientPanel1.Controls.Add(Me.lblTituloVentana)
        resources.ApplyResources(Me.RibbonClientPanel1, "RibbonClientPanel1")
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        '
        'btnProcedCrear
        '
        Me.btnProcedCrear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnProcedCrear.Image = CType(resources.GetObject("btnProcedCrear.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnProcedCrear, "btnProcedCrear")
        Me.btnProcedCrear.Name = "btnProcedCrear"
        '
        'memoProcedimiento
        '
        resources.ApplyResources(Me.memoProcedimiento, "memoProcedimiento")
        Me.memoProcedimiento.Name = "memoProcedimiento"
        '
        'txtIdProced
        '
        '
        '
        '
        Me.txtIdProced.Border.Class = "TextBoxBorder"
        resources.ApplyResources(Me.txtIdProced, "txtIdProced")
        Me.txtIdProced.Name = "txtIdProced"
        '
        'cmbProcedimientos
        '
        Me.cmbProcedimientos.DisplayMember = "Text"
        Me.cmbProcedimientos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProcedimientos.FormattingEnabled = True
        resources.ApplyResources(Me.cmbProcedimientos, "cmbProcedimientos")
        Me.cmbProcedimientos.Name = "cmbProcedimientos"
        '
        'btnImprimirInforme
        '
        Me.btnImprimirInforme.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnImprimirInforme.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnImprimirInforme.Image = CType(resources.GetObject("btnImprimirInforme.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnImprimirInforme, "btnImprimirInforme")
        Me.btnImprimirInforme.Name = "btnImprimirInforme"
        '
        'btnFirmaPaciente
        '
        Me.btnFirmaPaciente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFirmaPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnFirmaPaciente, "btnFirmaPaciente")
        Me.btnFirmaPaciente.Image = CType(resources.GetObject("btnFirmaPaciente.Image"), System.Drawing.Image)
        Me.btnFirmaPaciente.Name = "btnFirmaPaciente"
        '
        'btnFirmaOdonto
        '
        Me.btnFirmaOdonto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnFirmaOdonto.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnFirmaOdonto, "btnFirmaOdonto")
        Me.btnFirmaOdonto.Image = CType(resources.GetObject("btnFirmaOdonto.Image"), System.Drawing.Image)
        Me.btnFirmaOdonto.Name = "btnFirmaOdonto"
        '
        'btnEliminar
        '
        Me.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.Name = "btnEliminar"
        '
        'btnModificar
        '
        Me.btnModificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnModificar, "btnModificar")
        Me.btnModificar.Name = "btnModificar"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.Name = "btnSalir"
        '
        'btnNuevo
        '
        Me.btnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnNuevo, "btnNuevo")
        Me.btnNuevo.Name = "btnNuevo"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnAdicionar, "btnAdicionar")
        Me.btnAdicionar.Name = "btnAdicionar"
        '
        'lblProcedimientos
        '
        Me.lblProcedimientos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblProcedimientos.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblProcedimientos.ForeColor = System.Drawing.Color.Navy
        resources.ApplyResources(Me.lblProcedimientos, "lblProcedimientos")
        Me.lblProcedimientos.Name = "lblProcedimientos"
        Me.lblProcedimientos.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'dgProcedimientos
        '
        Me.dgProcedimientos.AllowUserToAddRows = False
        Me.dgProcedimientos.AllowUserToDeleteRows = False
        Me.dgProcedimientos.AllowUserToResizeRows = False
        Me.dgProcedimientos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgProcedimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgProcedimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgProcedimientos.EnableHeadersVisualStyles = False
        resources.ApplyResources(Me.dgProcedimientos, "dgProcedimientos")
        Me.dgProcedimientos.MultiSelect = False
        Me.dgProcedimientos.Name = "dgProcedimientos"
        Me.dgProcedimientos.ReadOnly = True
        Me.dgProcedimientos.RowHeadersVisible = False
        Me.dgProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProcedimientos.ShowEditingIcon = False
        '
        'cmbfechaProced
        '
        resources.ApplyResources(Me.cmbfechaProced, "cmbfechaProced")
        Me.cmbfechaProced.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbfechaProced.Name = "cmbfechaProced"
        Me.cmbfechaProced.Value = New Date(2007, 11, 20, 0, 0, 0, 0)
        '
        'lblfechaProced
        '
        Me.lblfechaProced.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfechaProced.BorderType = DevComponents.DotNetBar.eBorderType.Etched
        Me.lblfechaProced.ForeColor = System.Drawing.Color.Navy
        resources.ApplyResources(Me.lblfechaProced, "lblfechaProced")
        Me.lblfechaProced.Name = "lblfechaProced"
        Me.lblfechaProced.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTituloVentana
        '
        Me.lblTituloVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        resources.ApplyResources(Me.lblTituloVentana, "lblTituloVentana")
        Me.lblTituloVentana.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTituloVentana.Name = "lblTituloVentana"
        Me.lblTituloVentana.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmProcedimientoDiario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProcedimientoDiario"
        Me.RibbonClientPanel1.ResumeLayout(False)
        CType(Me.dgProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonClientPanel1 As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents btnEliminar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnModificar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSalir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnAdicionar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblProcedimientos As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbfechaProced As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfechaProced As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTituloVentana As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnImprimirInforme As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbProcedimientos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtIdProced As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents memoProcedimiento As System.Windows.Forms.RichTextBox
    Friend WithEvents btnProcedCrear As DevComponents.DotNetBar.ButtonX
    Public WithEvents dgProcedimientos As System.Windows.Forms.DataGridView
    Public WithEvents btnFirmaOdonto As DevComponents.DotNetBar.ButtonX
    Public WithEvents btnFirmaPaciente As DevComponents.DotNetBar.ButtonX
End Class
