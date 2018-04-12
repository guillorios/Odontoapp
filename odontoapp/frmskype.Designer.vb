<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmskype
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmskype))
        Me.AxSkypeContactList1 = New AxSKYPECONTACTSLib.AxSkypeContactList
        CType(Me.AxSkypeContactList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxSkypeContactList1
        '
        Me.AxSkypeContactList1.Enabled = True
        Me.AxSkypeContactList1.Location = New System.Drawing.Point(12, 12)
        Me.AxSkypeContactList1.Name = "AxSkypeContactList1"
        Me.AxSkypeContactList1.OcxState = CType(resources.GetObject("AxSkypeContactList1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSkypeContactList1.Size = New System.Drawing.Size(291, 298)
        Me.AxSkypeContactList1.TabIndex = 1
        '
        'frmskype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 337)
        Me.Controls.Add(Me.AxSkypeContactList1)
        Me.Name = "frmskype"
        Me.Text = "frmskype"
        CType(Me.AxSkypeContactList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxSkypeContactList1 As AxSKYPECONTACTSLib.AxSkypeContactList
End Class
