<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim gbVerification As System.Windows.Forms.GroupBox
        Dim gbReturnValues As System.Windows.Forms.GroupBox
        Dim lblFalseAcceptRate As System.Windows.Forms.Label
        Dim gbEnrollment As System.Windows.Forms.GroupBox
        Dim gbEventHandlerStatus As System.Windows.Forms.GroupBox
        Dim lblMaxFingers As System.Windows.Forms.Label
        Dim lblMask As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.VerifyButton = New System.Windows.Forms.Button
        Me.FalseAcceptRate = New System.Windows.Forms.TextBox
        Me.IsFeatureSetMatched = New System.Windows.Forms.CheckBox
        Me.MaxFingers = New System.Windows.Forms.NumericUpDown
        Me.Mask = New System.Windows.Forms.NumericUpDown
        Me.EnrollButton = New System.Windows.Forms.Button
        Me.IsFailure = New System.Windows.Forms.RadioButton
        Me.IsSuccess = New System.Windows.Forms.RadioButton
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton
        gbVerification = New System.Windows.Forms.GroupBox
        gbReturnValues = New System.Windows.Forms.GroupBox
        lblFalseAcceptRate = New System.Windows.Forms.Label
        gbEnrollment = New System.Windows.Forms.GroupBox
        gbEventHandlerStatus = New System.Windows.Forms.GroupBox
        lblMaxFingers = New System.Windows.Forms.Label
        lblMask = New System.Windows.Forms.Label
        gbVerification.SuspendLayout()
        gbReturnValues.SuspendLayout()
        gbEnrollment.SuspendLayout()
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).BeginInit()
        gbEventHandlerStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbVerification
        '
        gbVerification.Controls.Add(Me.VerifyButton)
        gbVerification.Controls.Add(gbReturnValues)
        gbVerification.Location = New System.Drawing.Point(12, 198)
        gbVerification.Name = "gbVerification"
        gbVerification.Size = New System.Drawing.Size(266, 190)
        gbVerification.TabIndex = 116
        gbVerification.TabStop = False
        gbVerification.Text = "Verification"
        '
        'VerifyButton
        '
        Me.VerifyButton.Location = New System.Drawing.Point(76, 146)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(107, 23)
        Me.VerifyButton.TabIndex = 1
        Me.VerifyButton.Text = "Verify Fingerprints"
        Me.VerifyButton.UseVisualStyleBackColor = True
        '
        'gbReturnValues
        '
        gbReturnValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        gbReturnValues.Controls.Add(Me.FalseAcceptRate)
        gbReturnValues.Controls.Add(lblFalseAcceptRate)
        gbReturnValues.Controls.Add(Me.IsFeatureSetMatched)
        gbReturnValues.Location = New System.Drawing.Point(9, 40)
        gbReturnValues.Name = "gbReturnValues"
        gbReturnValues.Size = New System.Drawing.Size(251, 100)
        gbReturnValues.TabIndex = 0
        gbReturnValues.TabStop = False
        gbReturnValues.Text = "Return values"
        '
        'FalseAcceptRate
        '
        Me.FalseAcceptRate.Location = New System.Drawing.Point(132, 62)
        Me.FalseAcceptRate.Name = "FalseAcceptRate"
        Me.FalseAcceptRate.ReadOnly = True
        Me.FalseAcceptRate.Size = New System.Drawing.Size(113, 20)
        Me.FalseAcceptRate.TabIndex = 2
        '
        'lblFalseAcceptRate
        '
        lblFalseAcceptRate.Location = New System.Drawing.Point(6, 62)
        lblFalseAcceptRate.Name = "lblFalseAcceptRate"
        lblFalseAcceptRate.Size = New System.Drawing.Size(120, 20)
        lblFalseAcceptRate.TabIndex = 1
        lblFalseAcceptRate.Text = "False accept rate"
        lblFalseAcceptRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IsFeatureSetMatched
        '
        Me.IsFeatureSetMatched.AutoCheck = False
        Me.IsFeatureSetMatched.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsFeatureSetMatched.Location = New System.Drawing.Point(6, 32)
        Me.IsFeatureSetMatched.Name = "IsFeatureSetMatched"
        Me.IsFeatureSetMatched.Size = New System.Drawing.Size(139, 24)
        Me.IsFeatureSetMatched.TabIndex = 0
        Me.IsFeatureSetMatched.Text = "Feature set matched?"
        Me.IsFeatureSetMatched.UseVisualStyleBackColor = True
        '
        'gbEnrollment
        '
        gbEnrollment.Controls.Add(Me.MaxFingers)
        gbEnrollment.Controls.Add(Me.Mask)
        gbEnrollment.Controls.Add(Me.EnrollButton)
        gbEnrollment.Controls.Add(gbEventHandlerStatus)
        gbEnrollment.Controls.Add(lblMaxFingers)
        gbEnrollment.Controls.Add(lblMask)
        gbEnrollment.Location = New System.Drawing.Point(12, 12)
        gbEnrollment.Name = "gbEnrollment"
        gbEnrollment.Size = New System.Drawing.Size(266, 180)
        gbEnrollment.TabIndex = 115
        gbEnrollment.TabStop = False
        gbEnrollment.Text = "Enrollment"
        '
        'MaxFingers
        '
        Me.MaxFingers.Location = New System.Drawing.Point(160, 52)
        Me.MaxFingers.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxFingers.Name = "MaxFingers"
        Me.MaxFingers.Size = New System.Drawing.Size(94, 20)
        Me.MaxFingers.TabIndex = 3
        Me.MaxFingers.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Mask
        '
        Me.Mask.Location = New System.Drawing.Point(160, 26)
        Me.Mask.Maximum = New Decimal(New Integer() {1023, 0, 0, 0})
        Me.Mask.Name = "Mask"
        Me.Mask.Size = New System.Drawing.Size(94, 20)
        Me.Mask.TabIndex = 1
        '
        'EnrollButton
        '
        Me.EnrollButton.Location = New System.Drawing.Point(76, 145)
        Me.EnrollButton.Name = "EnrollButton"
        Me.EnrollButton.Size = New System.Drawing.Size(107, 23)
        Me.EnrollButton.TabIndex = 5
        Me.EnrollButton.Text = "Enroll Fingerprints"
        Me.EnrollButton.UseVisualStyleBackColor = True
        '
        'gbEventHandlerStatus
        '
        gbEventHandlerStatus.Controls.Add(Me.IsFailure)
        gbEventHandlerStatus.Controls.Add(Me.IsSuccess)
        gbEventHandlerStatus.Location = New System.Drawing.Point(9, 79)
        gbEventHandlerStatus.Name = "gbEventHandlerStatus"
        gbEventHandlerStatus.Size = New System.Drawing.Size(251, 60)
        gbEventHandlerStatus.TabIndex = 4
        gbEventHandlerStatus.TabStop = False
        gbEventHandlerStatus.Text = "Event handler status"
        '
        'IsFailure
        '
        Me.IsFailure.AutoSize = True
        Me.IsFailure.Location = New System.Drawing.Point(151, 29)
        Me.IsFailure.Name = "IsFailure"
        Me.IsFailure.Size = New System.Drawing.Size(57, 17)
        Me.IsFailure.TabIndex = 1
        Me.IsFailure.TabStop = True
        Me.IsFailure.Text = "Failure"
        Me.IsFailure.UseVisualStyleBackColor = True
        '
        'IsSuccess
        '
        Me.IsSuccess.AutoSize = True
        Me.IsSuccess.Location = New System.Drawing.Point(26, 29)
        Me.IsSuccess.Name = "IsSuccess"
        Me.IsSuccess.Size = New System.Drawing.Size(63, 17)
        Me.IsSuccess.TabIndex = 0
        Me.IsSuccess.TabStop = True
        Me.IsSuccess.Text = "Success"
        Me.IsSuccess.UseVisualStyleBackColor = True
        '
        'lblMaxFingers
        '
        lblMaxFingers.Location = New System.Drawing.Point(6, 53)
        lblMaxFingers.Name = "lblMaxFingers"
        lblMaxFingers.Size = New System.Drawing.Size(148, 20)
        lblMaxFingers.TabIndex = 2
        lblMaxFingers.Text = "Max. enrolled fingers count"
        lblMaxFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMask
        '
        lblMask.Location = New System.Drawing.Point(6, 27)
        lblMask.Name = "lblMask"
        lblMask.Size = New System.Drawing.Size(148, 20)
        lblMask.TabIndex = 0
        lblMask.Text = "Fingerprint Mask"
        lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(177, 394)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(104, 35)
        Me.btnSalir.TabIndex = 118
        Me.btnSalir.Text = "SALIR"
        '
        'MainForm
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 442)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(gbVerification)
        Me.Controls.Add(gbEnrollment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        gbVerification.ResumeLayout(False)
        gbReturnValues.ResumeLayout(False)
        gbReturnValues.PerformLayout()
        gbEnrollment.ResumeLayout(False)
        CType(Me.MaxFingers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mask, System.ComponentModel.ISupportInitialize).EndInit()
        gbEventHandlerStatus.ResumeLayout(False)
        gbEventHandlerStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents VerifyButton As System.Windows.Forms.Button
    Private WithEvents FalseAcceptRate As System.Windows.Forms.TextBox
    Private WithEvents IsFeatureSetMatched As System.Windows.Forms.CheckBox
    Friend WithEvents MaxFingers As System.Windows.Forms.NumericUpDown
    Friend WithEvents Mask As System.Windows.Forms.NumericUpDown
    Private WithEvents EnrollButton As System.Windows.Forms.Button
    Private WithEvents IsFailure As System.Windows.Forms.RadioButton
    Private WithEvents IsSuccess As System.Windows.Forms.RadioButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
End Class
