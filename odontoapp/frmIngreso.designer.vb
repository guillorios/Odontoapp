<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngreso))
        Me.PanelIngreso = New DevComponents.DotNetBar.Ribbon.RibbonClientPanel
        Me.VerificationControl = New DPFP.Gui.Verification.VerificationControl
        Me.chkRecuperarSettings = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.btnRegistro = New DevExpress.XtraEditors.SimpleButton
        Me.btnConfiguracion = New DevExpress.XtraEditors.SimpleButton
        Me.btnAyuda = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX
        Me.btnIngresar = New DevComponents.DotNetBar.ButtonX
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.lblContraseña = New System.Windows.Forms.Label
        Me.cmbEmpleados = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.txtClave = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.pbFondoVentana = New System.Windows.Forms.PictureBox
        Me.PanelIngreso.SuspendLayout()
        CType(Me.pbFondoVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelIngreso
        '
        Me.PanelIngreso.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelIngreso.Controls.Add(Me.VerificationControl)
        Me.PanelIngreso.Controls.Add(Me.chkRecuperarSettings)
        Me.PanelIngreso.Controls.Add(Me.btnRegistro)
        Me.PanelIngreso.Controls.Add(Me.btnConfiguracion)
        Me.PanelIngreso.Controls.Add(Me.btnAyuda)
        Me.PanelIngreso.Controls.Add(Me.btnCancelar)
        Me.PanelIngreso.Controls.Add(Me.btnIngresar)
        Me.PanelIngreso.Controls.Add(Me.lblUsuario)
        Me.PanelIngreso.Controls.Add(Me.lblContraseña)
        Me.PanelIngreso.Controls.Add(Me.cmbEmpleados)
        Me.PanelIngreso.Controls.Add(Me.txtClave)
        Me.PanelIngreso.Controls.Add(Me.pbFondoVentana)
        Me.PanelIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelIngreso.Location = New System.Drawing.Point(0, 0)
        Me.PanelIngreso.Name = "PanelIngreso"
        Me.PanelIngreso.Size = New System.Drawing.Size(601, 417)
        '
        '
        '
        Me.PanelIngreso.Style.Class = "RibbonClientPanel"
        Me.PanelIngreso.TabIndex = 0
        Me.PanelIngreso.Text = "RibbonClientPanel1"
        '
        'VerificationControl
        '
        Me.VerificationControl.Active = True
        Me.VerificationControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.VerificationControl.Location = New System.Drawing.Point(64, 206)
        Me.VerificationControl.Name = "VerificationControl"
        Me.VerificationControl.ReaderSerialNumber = "00000000-0000-0000-0000-000000000000"
        Me.VerificationControl.Size = New System.Drawing.Size(48, 49)
        Me.VerificationControl.TabIndex = 120
        '
        'chkRecuperarSettings
        '
        Me.chkRecuperarSettings.Location = New System.Drawing.Point(154, 327)
        Me.chkRecuperarSettings.Name = "chkRecuperarSettings"
        Me.chkRecuperarSettings.Size = New System.Drawing.Size(261, 23)
        Me.chkRecuperarSettings.TabIndex = 12
        Me.chkRecuperarSettings.Text = "Recuperar Informacion de Ensamblado Anterior"
        Me.chkRecuperarSettings.Visible = False
        '
        'btnRegistro
        '
        Me.btnRegistro.Image = CType(resources.GetObject("btnRegistro.Image"), System.Drawing.Image)
        Me.btnRegistro.Location = New System.Drawing.Point(40, 328)
        Me.btnRegistro.LookAndFeel.SkinName = "Blue"
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(107, 23)
        Me.btnRegistro.TabIndex = 11
        Me.btnRegistro.Text = "Registro"
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Image = CType(resources.GetObject("btnConfiguracion.Image"), System.Drawing.Image)
        Me.btnConfiguracion.Location = New System.Drawing.Point(40, 299)
        Me.btnConfiguracion.LookAndFeel.SkinName = "Blue"
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(107, 23)
        Me.btnConfiguracion.TabIndex = 10
        Me.btnConfiguracion.Text = "Configuracion"
        '
        'btnAyuda
        '
        Me.btnAyuda.Image = CType(resources.GetObject("btnAyuda.Image"), System.Drawing.Image)
        Me.btnAyuda.Location = New System.Drawing.Point(40, 270)
        Me.btnAyuda.LookAndFeel.SkinName = "Blue"
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(107, 23)
        Me.btnAyuda.TabIndex = 9
        Me.btnAyuda.Text = "Ayuda"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(256, 206)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 27)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "CANCELAR"
        '
        'btnIngresar
        '
        Me.btnIngresar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnIngresar.Image = CType(resources.GetObject("btnIngresar.Image"), System.Drawing.Image)
        Me.btnIngresar.Location = New System.Drawing.Point(162, 206)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(88, 27)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "INGRESAR"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(37, 172)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(91, 13)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "CONTRASEÑA"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.White
        Me.lblContraseña.Location = New System.Drawing.Point(37, 137)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(63, 13)
        Me.lblContraseña.TabIndex = 4
        Me.lblContraseña.Text = "USUARIO"
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.DisplayMember = "Text"
        Me.cmbEmpleados.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpleados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.ItemHeight = 20
        Me.cmbEmpleados.Location = New System.Drawing.Point(136, 128)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(192, 26)
        Me.cmbEmpleados.TabIndex = 1
        '
        'txtClave
        '
        '
        '
        '
        Me.txtClave.Border.Class = "TextBoxBorder"
        Me.txtClave.ForeColor = System.Drawing.Color.Navy
        Me.txtClave.Location = New System.Drawing.Point(134, 162)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(192, 23)
        Me.txtClave.TabIndex = 2
        Me.txtClave.WatermarkText = "DIGITE SU CONTRASEÑA"
        '
        'pbFondoVentana
        '
        Me.pbFondoVentana.Location = New System.Drawing.Point(9, 12)
        Me.pbFondoVentana.Name = "pbFondoVentana"
        Me.pbFondoVentana.Size = New System.Drawing.Size(580, 387)
        Me.pbFondoVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFondoVentana.TabIndex = 1
        Me.pbFondoVentana.TabStop = False
        '
        'frmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 417)
        Me.Controls.Add(Me.PanelIngreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso"
        Me.PanelIngreso.ResumeLayout(False)
        Me.PanelIngreso.PerformLayout()
        CType(Me.pbFondoVentana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelIngreso As DevComponents.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents pbFondoVentana As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContraseña As System.Windows.Forms.Label
    Friend WithEvents cmbEmpleados As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtClave As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnIngresar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRegistro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConfiguracion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAyuda As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkRecuperarSettings As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents VerificationControl As DPFP.Gui.Verification.VerificationControl
End Class
