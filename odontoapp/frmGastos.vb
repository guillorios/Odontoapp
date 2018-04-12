Imports System.Math

Public Class frmGastos

    'Variables de Clases
    Private GENE As CLASE_GENERAL
    Private EVEN As CLASE_EVENTOS
    Private GASTOS As CLASE_GASTOS

    'Variables de Control
    Private contar As Integer
    Public nfila As Integer


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmGastos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try


            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("itemsgastos", Me.dgGastos, CLASE_GENERAL.mensaje_error)

            GRIDSTYLES()

            Me.dgGastos.ClearSelection()

            GENE = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevoitemgasto")
            EVEN.limpiar("limpiargastos")
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

            With Me.dgGastos

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style1
                .Columns(0).HeaderText = "ID"
                .Columns(0).Width = 70

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "CONCEPTO"
                .Columns(1).Width = 220

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "OBSERVACION"
                .Columns(2).Width = 190

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub actualizargasto()

        Me.txtIdgasto.Text = Me.dgGastos.CurrentRow.Cells("Idgasto").Value
        Me.txtconcepto_gas.Text = Me.dgGastos.CurrentRow.Cells("concepto_gas").Value
        Me.txtobservacion_gas.Text = Me.dgGastos.CurrentRow.Cells("observacion_gas").Value

        EVEN = New CLASE_EVENTOS
        EVEN.bloquaerdesbloquear("editaritemgasto")
        EVEN = Nothing

        Me.txtIdgasto.ReadOnly = True

    End Sub

    Private Sub dgGastos_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGastos.CellEnter

        actualizargasto()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdgasto.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdgasto, "Escriba el Codigo del Item Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdgasto), MsgBoxStyle.OkOnly, "Gastos")
                Me.txtIdgasto.Focus()

            ElseIf Me.txtconcepto_gas.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtconcepto_gas, "Escriba el Concepto del Item por favor")
                MsgBox(ErrorProvider.GetError(Me.txtconcepto_gas), MsgBoxStyle.OkOnly, "Gastos")
                Me.txtconcepto_gas.Focus()


            Else

                contar = 0
                contar = CLASE_GENERAL.contar2("Idgasto", "gastos", Me.txtIdgasto.Text, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    MsgBox("El codigo ya Existe por favor verifique.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimientos")

                Else

                    GASTOS = New CLASE_GASTOS

                    GASTOS.p_Idgasto = Me.txtIdgasto.Text
                    GASTOS.p_concepto_gas = Me.txtconcepto_gas.Text
                    GASTOS.p_observacion_gas = Me.txtobservacion_gas.Text

                    GASTOS.Insertar(CLASE_GENERAL.mensaje_error)

                    GASTOS.dispose()
                    GASTOS = Nothing

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("itemsgastos", Me.dgGastos, CLASE_GENERAL.mensaje_error)
                    GENE = Nothing

                    GRIDSTYLES()

                    Me.dgGastos.Rows(Me.dgGastos.Rows.Count - 1).Selected = True


                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editaritemgasto")
                    EVEN = Nothing

                    Me.txtIdgasto.ReadOnly = True

                    ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                    For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                        If frm.Name = "frmComprobanteEgreso" Then

                            CLASE_GENERAL.cargar_combo("gastos", My.Forms.frmComprobanteEgreso.cmbItemGastos, CLASE_GENERAL.mensaje_error)
                            My.Forms.frmComprobanteEgreso.cmbItemGastos.Text = ""

                        End If

                    Next

                    MsgBox("Item Ingresado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Gastos")

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub txtIdgasto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdgasto.TextChanged

        Me.ErrorProvider.SetError(Me.txtIdgasto, "")

    End Sub

    Private Sub txtconcepto_gas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconcepto_gas.TextChanged

        Me.ErrorProvider.SetError(Me.txtconcepto_gas, "")

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar el Item", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Gastos")

            If respuesta = MsgBoxResult.Yes Then


                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProvider.BlinkRate = 200
                Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.txtIdgasto.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtIdgasto, "Escriba el Codigo del Item Por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtIdgasto), MsgBoxStyle.OkOnly, "Gastos")
                    Me.txtIdgasto.Focus()

                ElseIf Me.txtconcepto_gas.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtconcepto_gas, "Escriba el Concepto del Item por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtconcepto_gas), MsgBoxStyle.OkOnly, "Gastos")
                    Me.txtconcepto_gas.Focus()


                Else

                    GASTOS = New CLASE_GASTOS

                    GASTOS.p_Idgasto = Me.txtIdgasto.Text
                    GASTOS.p_concepto_gas = Me.txtconcepto_gas.Text
                    GASTOS.p_observacion_gas = Me.txtobservacion_gas.Text

                    GASTOS.Modificar(CLASE_GENERAL.mensaje_error)

                    GASTOS.dispose()
                    GASTOS = Nothing

                    nfila = Me.dgGastos.CurrentRow.Index

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("itemsgastos", Me.dgGastos, CLASE_GENERAL.mensaje_error)
                    GENE = Nothing

                    GRIDSTYLES()

                    Me.dgGastos.Rows(nfila).Selected = True

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editaritemgasto")
                    EVEN = Nothing

                    Me.txtIdgasto.ReadOnly = True

                    ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                    For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                        If frm.Name = "frmComprobanteEgreso" Then

                            CLASE_GENERAL.cargar_combo("gastos", My.Forms.frmComprobanteEgreso.cmbItemGastos, CLASE_GENERAL.mensaje_error)
                            My.Forms.frmComprobanteEgreso.cmbItemGastos.Text = ""

                        End If

                    Next


                    MsgBox("Item Modificado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Gastos")

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevoitemgasto")
            EVEN.limpiar("limpiargastos")
            EVEN = Nothing

            Me.txtIdgasto.ReadOnly = False

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Eliminar el Item", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Gastos")

            If respuesta = MsgBoxResult.Yes Then

                GASTOS = New CLASE_GASTOS
                GASTOS.p_Idgasto = Me.txtIdgasto.Text

                GASTOS.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("nuevoitemgasto")
                EVEN.limpiar("limpiargastos")
                EVEN = Nothing

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("itemsgastos", Me.dgGastos, CLASE_GENERAL.mensaje_error)

                GRIDSTYLES()

                Me.dgGastos.ClearSelection()

                GENE = Nothing

                Me.txtIdgasto.ReadOnly = False

                ' Cargamos el combo en la ventan activa siempre y cuando este abierta
                For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren

                    If frm.Name = "frmComprobanteEgreso" Then

                        CLASE_GENERAL.cargar_combo("gastos", My.Forms.frmComprobanteEgreso.cmbItemGastos, CLASE_GENERAL.mensaje_error)
                        My.Forms.frmComprobanteEgreso.cmbItemGastos.Text = ""

                    End If

                Next

                MsgBox("Item Elimindo con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Gastos")

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

        'Fotos Iniciales
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.dgGastos)
        ubicarcontrol(Me.gpGastos)
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmGastos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ubicarcontroles()
    End Sub
End Class