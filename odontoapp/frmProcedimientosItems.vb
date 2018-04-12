Imports System.Math

Public Class frmProcedimientosItems

    'Variables de Clases
    Private GENE As CLASE_GENERAL
    Private EVEN As CLASE_EVENTOS
    Private PROCEDIMIENTO As CLASE_PROCEDIMIENTOS

    'Variables de Control
    Private contar As Integer
    Public nfila As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmProcedimientosItems_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            'Cargamos las Especialidades
            CLASE_GENERAL.cargar_combo("especialidades", Me.cmbEspecialidades, CLASE_GENERAL.mensaje_error)
            Me.cmbEspecialidades.SelectedValue = 1


            'Cargamos la Grilla de los Procedimientos con sus valores
            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("valorprocedimientos", Me.dgProcedimientosItems, CLASE_GENERAL.mensaje_error)
            GENE = Nothing

            GRIDSTYLES()

            Me.dgProcedimientosItems.ClearSelection()


            'Ejecutamos procedimientos adicionesles de los controles y botones
            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevovalorprocedimiento")
            EVEN.limpiar("limpiarvalorprocedimientos")
            EVEN = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle
            Style1.Format = "N0"
            Style1.Alignment = DataGridViewContentAlignment.BottomLeft

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim Style3 As New DataGridViewCellStyle
            Style3.Format = "C0"
            Style3.Alignment = DataGridViewContentAlignment.BottomRight

            With Me.dgProcedimientosItems

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style1
                .Columns(0).HeaderText = "ID"
                .Columns(0).Width = 70

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "DESCRIPCION"
                .Columns(1).Width = 230

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "REFERENCIA"
                .Columns(2).Width = 100

                .Columns(3).DefaultCellStyle = Style3
                .Columns(3).HeaderText = "VALOR"
                .Columns(3).Width = 85

                .Columns(4).DefaultCellStyle = Style1
                .Columns(4).HeaderText = "ESPECIALIDAD"
                .Columns(4).Width = 150

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub actualizarprocedimiento()

        Me.txtIdprocedimiento.Text = Me.dgProcedimientosItems.CurrentRow.Cells("Idprocedimiento").Value
        Me.txtdescripcion_proc.Text = Me.dgProcedimientosItems.CurrentRow.Cells("descripcion_proc").Value
        Me.txtreferencia_proc.Text = Me.dgProcedimientosItems.CurrentRow.Cells("referencia_proc").Value
        Me.txtvalor_proc.Text = Me.dgProcedimientosItems.CurrentRow.Cells("valor_proc").Value
        Me.cmbEspecialidades.Text = Me.dgProcedimientosItems.CurrentRow.Cells("nom_especialidad").Value

        EVEN = New CLASE_EVENTOS
        EVEN.bloquaerdesbloquear("editarvalorprocedimiento")
        EVEN = Nothing

        Me.txtIdprocedimiento.ReadOnly = True

    End Sub

    Private Sub dgProcedimientosItems_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProcedimientosItems.CellEnter

        actualizarprocedimiento()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdprocedimiento.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdprocedimiento, "Escriba el Codigo del Item Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdprocedimiento), MsgBoxStyle.OkOnly, "Procedimientos")
                Me.txtIdprocedimiento.Focus()

            ElseIf Me.txtdescripcion_proc.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtdescripcion_proc, "Escriba la descripcion del item por favor")
                MsgBox(ErrorProvider.GetError(Me.txtdescripcion_proc), MsgBoxStyle.OkOnly, "Procedimientos")
                Me.txtdescripcion_proc.Focus()


            Else

                contar = 0
                contar = CLASE_GENERAL.contar2("Idprocedimiento", "procedimientos", Me.txtIdprocedimiento.Text, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    MsgBox("El codigo ya Existe por favor verifique.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimientos")

                Else

                    PROCEDIMIENTO = New CLASE_PROCEDIMIENTOS

                    PROCEDIMIENTO.p_Idprocedimiento = Me.txtIdprocedimiento.Text
                    PROCEDIMIENTO.p_descripcion_proc = Me.txtdescripcion_proc.Text
                    PROCEDIMIENTO.p_referencia_proc = Me.txtreferencia_proc.Text
                    PROCEDIMIENTO.p_valor_proc = Me.txtvalor_proc.Text
                    PROCEDIMIENTO.p_Idespecialidad = Me.cmbEspecialidades.SelectedValue

                    PROCEDIMIENTO.Insertar(CLASE_GENERAL.mensaje_error)

                    PROCEDIMIENTO.dispose()
                    PROCEDIMIENTO = Nothing

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("valorprocedimientos", Me.dgProcedimientosItems, CLASE_GENERAL.mensaje_error)

                    Me.dgProcedimientosItems.Rows(Me.dgProcedimientosItems.Rows.Count - 1).Selected = True

                    GRIDSTYLES()
                    GENE = Nothing

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editarvalorprocedimiento")
                    EVEN = Nothing

                    Me.txtIdprocedimiento.ReadOnly = True

                    ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                    For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                        If frm.Name = "frmEstadoCuenta" Then

                            My.Forms.frmEstadoCuenta.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                            'CLASE_GENERAL.cargar_combo("items", My.Forms.frmEstadoCuenta.cmbItem, CLASE_GENERAL.mensaje_error)
                            'My.Forms.frmEstadoCuenta.cmbItem.Text = ""

                        ElseIf frm.Name = "frmRCaja" Then

                            My.Forms.frmRCaja.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                            'CLASE_GENERAL.cargar_combo("items", My.Forms.frmRCaja.cmbItem, CLASE_GENERAL.mensaje_error)
                            'My.Forms.frmRCaja.cmbItem.Text = ""

                        ElseIf frm.Name = "frmPresupuesto" Then

                            My.Forms.frmPresupuesto.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                            'CLASE_GENERAL.cargar_combo("items", My.Forms.frmPresupuesto.cmbItem, CLASE_GENERAL.mensaje_error)
                            'My.Forms.frmPresupuesto.cmbItem.Text = ""

                        End If

                    Next

                    MsgBox("Item Ingresado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimientos")

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub txtdescripcion_proc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion_proc.TextChanged

        Me.ErrorProvider.SetError(Me.txtdescripcion_proc, "")

    End Sub

    Private Sub txtIdprocedimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdprocedimiento.TextChanged

        Me.ErrorProvider.SetError(Me.txtIdprocedimiento, "")

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar el Item", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Procedimientos")

            If respuesta = MsgBoxResult.Yes Then


                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProvider.BlinkRate = 200
                Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.txtIdprocedimiento.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtIdprocedimiento, "Escriba el Codigo del Item Por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtIdprocedimiento), MsgBoxStyle.OkOnly, "Procedimientos")
                    Me.txtIdprocedimiento.Focus()

                ElseIf Me.txtdescripcion_proc.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtdescripcion_proc, "Escriba la descripcion del item por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtdescripcion_proc), MsgBoxStyle.OkOnly, "Procedimientos")
                    Me.txtdescripcion_proc.Focus()

                Else

                    PROCEDIMIENTO = New CLASE_PROCEDIMIENTOS

                    PROCEDIMIENTO.p_Idprocedimiento = Me.txtIdprocedimiento.Text
                    PROCEDIMIENTO.p_descripcion_proc = Me.txtdescripcion_proc.Text
                    PROCEDIMIENTO.p_referencia_proc = Me.txtreferencia_proc.Text
                    PROCEDIMIENTO.p_valor_proc = Me.txtvalor_proc.Text
                    PROCEDIMIENTO.p_Idespecialidad = Me.cmbEspecialidades.SelectedValue

                    PROCEDIMIENTO.Modificar(CLASE_GENERAL.mensaje_error)

                    PROCEDIMIENTO.dispose()
                    PROCEDIMIENTO = Nothing

                    nfila = Me.dgProcedimientosItems.CurrentRow.Index

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("valorprocedimientos", Me.dgProcedimientosItems, CLASE_GENERAL.mensaje_error)

                    Me.dgProcedimientosItems.Rows(nfila).Selected = True

                    GRIDSTYLES()
                    GENE = Nothing

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editarvalorprocedimiento")
                    EVEN = Nothing

                    Me.txtIdprocedimiento.ReadOnly = True

                    ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                    For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                        If frm.Name = "frmEstadoCuenta" Then

                            My.Forms.frmEstadoCuenta.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                            'CLASE_GENERAL.cargar_combo("items", My.Forms.frmEstadoCuenta.cmbItem, CLASE_GENERAL.mensaje_error)
                            'My.Forms.frmEstadoCuenta.cmbItem.Text = ""

                        ElseIf frm.Name = "frmRCaja" Then

                            My.Forms.frmRCaja.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                            'CLASE_GENERAL.cargar_combo("items", My.Forms.frmRCaja.cmbItem, CLASE_GENERAL.mensaje_error)
                            'My.Forms.frmRCaja.cmbItem.Text = ""

                        ElseIf frm.Name = "frmPresupuesto" Then

                            My.Forms.frmPresupuesto.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                            'CLASE_GENERAL.cargar_combo("items", My.Forms.frmPresupuesto.cmbItem, CLASE_GENERAL.mensaje_error)
                            'My.Forms.frmPresupuesto.cmbItem.Text = ""

                        End If

                    Next

                    MsgBox("Item Modificado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimientos")

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevovalorprocedimiento")
            EVEN.limpiar("limpiarvalorprocedimientos")
            EVEN = Nothing

            Me.txtIdprocedimiento.ReadOnly = False

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Eliminar el Item", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Procedimientos")

            If respuesta = MsgBoxResult.Yes Then


                PROCEDIMIENTO = New CLASE_PROCEDIMIENTOS
                PROCEDIMIENTO.p_Idprocedimiento = Me.txtIdprocedimiento.Text

                PROCEDIMIENTO.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("nuevovalorprocedimiento")
                EVEN.limpiar("limpiarvalorprocedimientos")
                EVEN = Nothing

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("valorprocedimientos", Me.dgProcedimientosItems, CLASE_GENERAL.mensaje_error)

                GRIDSTYLES()

                Me.dgProcedimientosItems.ClearSelection()

                GENE = Nothing

                Me.txtIdprocedimiento.ReadOnly = False

                ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                    If frm.Name = "frmEstadoCuenta" Then

                        My.Forms.frmEstadoCuenta.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                        'CLASE_GENERAL.cargar_combo("items", My.Forms.frmEstadoCuenta.cmbItem, CLASE_GENERAL.mensaje_error)
                        'My.Forms.frmEstadoCuenta.cmbItem.Text = ""

                    ElseIf frm.Name = "frmRCaja" Then

                        My.Forms.frmRCaja.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                        'CLASE_GENERAL.cargar_combo("items", My.Forms.frmRCaja.cmbItem, CLASE_GENERAL.mensaje_error)
                        'My.Forms.frmRCaja.cmbItem.Text = ""

                    ElseIf frm.Name = "frmPresupuesto" Then

                        My.Forms.frmPresupuesto.cmbEspecialidades_SelectionChangeCommitted(sender, e)
                        'CLASE_GENERAL.cargar_combo("items", My.Forms.frmPresupuesto.cmbItem, CLASE_GENERAL.mensaje_error)
                        'My.Forms.frmPresupuesto.cmbItem.Text = ""

                    End If

                Next

                MsgBox("Item Elimindo con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimientos")


            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub ubicarcontrol(ByVal control As Control)

        'Este codigo nos permite hacer la ubicacion de los controles centrandolos
        Dim proporcionh As Integer
        Dim proporcionv As Integer

        Dim locationcontrolx As Integer
        Dim locationcontroly As Integer

        'Calculamos el desplazamiento del control con el valor actual de la ventana restandole una constante que es el tamaño de una resolucion de Horizontal 1024 x Vertical 768 
        Dim desplazamiento As Integer
        desplazamiento = Round((CInt(My.Forms.mdiOrthoSoft.PanelFicha.Size.Width) - 538) / 2, 0)

        locationcontrolx = control.Location.X
        locationcontroly = control.Location.Y

        'Ubicamos el control sumandole la posisicion actual mas el desplazamiento calculado
        proporcionh = locationcontrolx + desplazamiento
        proporcionv = locationcontroly
        control.Location = New System.Drawing.Point(proporcionh, proporcionv)

    End Sub

    Public Sub ubicarcontroles()

        'lblTituloVentana
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.dgProcedimientosItems)
        ubicarcontrol(Me.gpEstadoCuenta)
        ubicarcontrol(Me.gpEspecialidades)

        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmProcedimientosItems_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class