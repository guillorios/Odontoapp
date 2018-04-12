Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class frmComprobanteEgreso

    'Variables de Clases
    Private CEGRE As CLASE_CEGRESO
    Private PROVEE As CLASE_PROVEEDORES

    Private GENE As CLASE_GENERAL
    Private PRESUPUESTO As CLASE_PRESUPUESTO

    Private DETALLE_CEGRE As CLASE_DETALLE_CEGRESO
    Private EVEN As CLASE_EVENTOS
    Private GASTOS As CLASE_GASTOS

    Private CONSULT As CLASE_CONSULTORIO

    'Variables de Control
    Private contar As Integer
    Public nfila As Integer

    Private Sub SetupDataGridView()

        Dim Style1 As New DataGridViewCellStyle
        Style1.Format = "N0"
        Style1.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim Style2 As New DataGridViewCellStyle
        Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim Style3 As New DataGridViewCellStyle
        Style3.Format = "C0"
        Style3.Alignment = DataGridViewContentAlignment.MiddleRight

        'Creamos las Columnas
        Me.dgCE.ColumnCount = 5

        With Me.dgCE

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            .Columns(0).Name = "ID"
            .Columns(0).DefaultCellStyle = Style2
            .Columns(0).Width = 50
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(1).Name = "CONCEPTO"
            .Columns(1).DefaultCellStyle = Style1
            .Columns(1).Width = 160
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(2).Name = "OBSERVACION"
            .Columns(2).DefaultCellStyle = Style1
            .Columns(2).Width = 160
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(3).Name = "CANTIDAD"
            .Columns(3).DefaultCellStyle = Style2
            .Columns(3).Width = 60
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(4).Name = "VALOR"
            .Columns(4).DefaultCellStyle = Style2
            .Columns(4).Width = 100
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False

        End With

    End Sub

    Private Sub GRIDSTYLES()

        Dim Style1 As New DataGridViewCellStyle
        Style1.Format = "N0"
        Style1.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim Style2 As New DataGridViewCellStyle
        Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim Style3 As New DataGridViewCellStyle
        Style3.Format = "C0"
        Style3.Alignment = DataGridViewContentAlignment.MiddleRight

        With Me.dgCE

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            .Columns(0).Name = "ID"
            .Columns(0).DefaultCellStyle = Style2
            .Columns(0).Width = 50
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(1).Name = "CONCEPTO"
            .Columns(1).DefaultCellStyle = Style1
            .Columns(1).Width = 160
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(2).Name = "OBSERVACION"
            .Columns(2).DefaultCellStyle = Style1
            .Columns(2).Width = 160
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(3).Name = "CANTIDAD"
            .Columns(3).DefaultCellStyle = Style2
            .Columns(3).Width = 60
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns(4).Name = "VALOR"
            .Columns(4).DefaultCellStyle = Style2
            .Columns(4).Width = 100
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False

        End With

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmComprobanteEgreso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            SetupDataGridView()

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiacegreso")
            EVEN = Nothing

            Me.cmbfecha_ce.Value = Date.Now

            Me.txtIdce.Text = Format(CLASE_GENERAL.obtenerconsecutivo(1, "cegreso"), "0000#")
            CLASE_GENERAL.cargar_combo("gastos", Me.cmbItemGastos, CLASE_GENERAL.mensaje_error)
            CLASE_GENERAL.cargar_combo("proveedores", Me.cmbProveedores, CLASE_GENERAL.mensaje_error)

            Me.cmbItemGastos.Text = ""
            Me.cmbProveedores.Text = ""

            Me.btnAdicionar.Enabled = False
            Me.btnAnular.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnImprimir.Enabled = False
            Me.btnIngresar_Item.Enabled = True

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Ingresar el Comprobante de Egreso", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "C. Egreso")

            If respuesta = MsgBoxResult.Yes Then


                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProvider.BlinkRate = 200
                Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.txtIdce.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtIdce, "Escriba el Codigo del C. de Egreso por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtIdce), MsgBoxStyle.OkOnly, "C. Egreso")
                    Me.txtIdce.Focus()

                ElseIf Me.txtIdproveedor.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtIdproveedor, "Seleccione un Proveedor por favor.")
                    MsgBox(ErrorProvider.GetError(Me.txtIdproveedor), MsgBoxStyle.OkOnly, "C. Egreso")
                    Me.txtIdproveedor.Focus()

                ElseIf Me.txtconcepto_ce.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtconcepto_ce, "Escriba el Concepto General por Vavor.")
                    MsgBox(ErrorProvider.GetError(Me.txtconcepto_ce), MsgBoxStyle.OkOnly, "C. Egreso")
                    Me.txtconcepto_ce.Focus()

                ElseIf Me.txtciudad_ce.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtciudad_ce, "Escriba La ciudad por Vavor.")
                    MsgBox(ErrorProvider.GetError(Me.txtciudad_ce), MsgBoxStyle.OkOnly, "C. Egreso")
                    Me.txtciudad_ce.Focus()

                Else

                    contar = 0
                    contar = CLASE_GENERAL.contar2("Idce", "cegreso", Me.txtIdce.Text, CLASE_GENERAL.mensaje_error)

                    If contar > 0 Then

                        MsgBox("El codigo del Comprobante de Egreso ya Existe por favor verifique.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso")

                    Else

                        If Me.dgCE.Rows.Count > 0 Then

                            ' Creamos el Registro en la Tabla Recibos de Caja
                            CEGRE = New CLASE_CEGRESO
                            CEGRE.p_Idce = Me.txtIdce.Text
                            CEGRE.p_fecha_ce = Format(Me.cmbfecha_ce.Value, "yyyy-MM-dd")
                            CEGRE.p_ciudad_ce = Me.txtciudad_ce.Text
                            CEGRE.p_Idproveedor = Me.cmbProveedores.SelectedValue
                            CEGRE.p_concepto_ce = Me.txtconcepto_ce.Text
                            CEGRE.p_cheque_ce = Me.txtcheque_ce.Text
                            CEGRE.p_banco_ce = Me.txtbanco_ce.Text
                            CEGRE.p_debitesea_ce = Me.txtdebitesea_ce.Text
                            CEGRE.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                            CEGRE.p_total_ce = Me.txttotal_ce.Text
                            CEGRE.p_observaciones_ce = Me.txtobservaciones_ce.Text
                            CEGRE.p_Idestado = 1

                            ' 1 Es Activa
                            ' 0 Es Anulada

                            CEGRE.p_estado_cuadre = 0

                            ' 1 Esta Cuadrada
                            ' 0 Esta Sin Cuadrar

                            CEGRE.p_Idlibrodiario = 0

                            CEGRE.Insertar(CLASE_GENERAL.mensaje_error)

                            CEGRE.dispose()
                            CEGRE = Nothing

                            'Agregamos los Items en el detalle_recibo de caja

                            DETALLE_CEGRE = New CLASE_DETALLE_CEGRESO
                            DETALLE_CEGRE.p_Idce = Me.txtIdce.Text

                            For Each row As DataGridViewRow In Me.dgCE.Rows

                                DETALLE_CEGRE.p_Idgasto = row.Cells.Item("ID").Value
                                DETALLE_CEGRE.p_concepto = row.Cells.Item("CONCEPTO").Value
                                DETALLE_CEGRE.p_observacion = row.Cells.Item("OBSERVACION").Value
                                DETALLE_CEGRE.p_cantidad = row.Cells.Item("CANTIDAD").Value
                                DETALLE_CEGRE.p_valor = row.Cells.Item("VALOR").Value
                                DETALLE_CEGRE.Insertar(CLASE_GENERAL.mensaje_error)

                            Next

                            DETALLE_CEGRE.dispose()
                            DETALLE_CEGRE = Nothing

                            'Ahora modificamos las cuotas si existieran en el recibo

                            '************   Cambiamos el Consecutivo **********

                            CONSULT = New CLASE_CONSULTORIO
                            CONSULT.p_Idconsultorio = 1
                            CONSULT.p_conseccegreso_cons = CLASE_GENERAL.maximo("Idce", "cegreso", CLASE_GENERAL.mensaje_error) + 1
                            CONSULT.Modificar("conseccegreso")

                            For Each frm As Form In Me.MdiChildren
                                If frm.Name = "frmConfiguraciones" Then
                                    My.Forms.frmConfiguraciones.txtconseccegreso_cons.Text = CLASE_GENERAL.maximo("Idce", "cegreso", CLASE_GENERAL.mensaje_error) + 1
                                End If
                            Next

                            CONSULT.dispose()
                            CONSULT = Nothing

                            MsgBox("Comprobante de Egreso Grabado con Exito", MsgBoxStyle.OkOnly, "C. Egreso")

                            Me.btnAdicionar.Enabled = False
                            Me.btnAnular.Enabled = True
                            Me.btnNuevo.Enabled = True
                            Me.btnImprimir.Enabled = True
                            Me.btnBorrarItem.Enabled = False

                        Else

                            MsgBox("No hay items en el recibo verifique por favor.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso")

                        End If

                    End If

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            CEGRE = New CLASE_CEGRESO
            CEGRE.p_Idce = Me.txtIdce.Text
            CEGRE.Seleccionar("recibo")

            Dim orptCEgresoFormato1 As New rptCEgresoFormato1()
            ' Dim toTexto As TextObject

            frmInformes.MdiParent = My.Forms.mdiOrthoSoft
            orptCEgresoFormato1.SetDataSource(CLASE_GENERAL.xdt)
            My.Forms.frmInformes.crvOrthosoft.ReportSource = orptCEgresoFormato1

            My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
            My.Forms.frmInformes.crvOrthosoft.Zoom(70)

            'Me.rtxtTotalLetras.Text = NroEnLetras(CDbl(Me.txtGRANTOTAL.Text), False) & " PESOS M/CTE"

            'Display the new form.
            My.Forms.frmInformes.Show()
            My.Forms.frmInformes.Activate()

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            CEGRE.dispose()
            CEGRE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnCEBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCEBuscar.Click

        Try

            If Me.txtIdce_Bus.Text = "" Or Me.txtIdce_Bus.Text = "0" Then

                Me.DxError.SetError(Me.txtIdce_Bus, "Escriba el No. del Comprobante de Egreso", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
                MsgBox("Escriba el No. del recibo del Comprobante de Egresor", MsgBoxStyle.OkOnly, "C. Egreso")

            Else

                contar = CLASE_GENERAL.contar2("Idce", "cegreso", Me.txtIdce_Bus.Text, CLASE_GENERAL.mensaje_error)

                If contar = 0 Then

                    Me.txtIdce_Bus.Text = ""
                    Me.DxError.SetError(Me.txtIdce, "Escriba el No. del Comprobante de Egreso", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
                    MsgBox("El Comprobante de Egreso no Exite, digitelo nuevamente Por favor.", MsgBoxStyle.OkOnly, "C. Egreso")

                Else

                    'Limpiamos el recibo

                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiacegreso")
                    EVEN = Nothing

                    'Rutina para Borrar las filas
                    If Me.dgCE.RowCount >= 1 Then
                        For i As Integer = 0 To Me.dgCE.RowCount - 1
                            Me.dgCE.Rows.Remove(Me.dgCE.CurrentRow)
                        Next
                    End If

                    ' Buscamos la factura

                    CEGRE = New CLASE_CEGRESO
                    CEGRE.p_Idce = Me.txtIdce_Bus.Text
                    CEGRE.Seleccionar("registro")

                    Me.txtIdce.Text = Format(CLASE_CEGRESO.xIdce, "0000#")
                    Me.txtciudad_ce.Text = CLASE_CEGRESO.xciudad_ce
                    Me.cmbProveedores.SelectedValue = CLASE_CEGRESO.xIdproveedor
                    Me.txtconcepto_ce.Text = CLASE_CEGRESO.xconcepto_ce
                    Me.txtcheque_ce.Text = CLASE_CEGRESO.xcheque_ce
                    Me.txtbanco_ce.Text = CLASE_CEGRESO.xbanco_ce
                    Me.txtdebitesea_ce.Text = CLASE_CEGRESO.xdebitesea_ce
                    Me.cmbfecha_ce.Value = CLASE_CEGRESO.xfecha_ce
                    Me.txttotal_ce.Text = CLASE_CEGRESO.xtotal_ce
                    Me.txtobservaciones_ce.Text = CLASE_CEGRESO.xobservaciones_ce

                    If CLASE_CEGRESO.xIdestado = 0 Then
                        Me.lblAnulada.Visible = True
                        Me.btnAnular.Enabled = False
                    Else
                        Me.lblAnulada.Visible = False
                        Me.btnAnular.Enabled = True
                    End If

                    Me.txtobservaciones_ce.Text = CLASE_CEGRESO.xobservaciones_ce

                    CEGRE.dispose()
                    CEGRE = Nothing

                    'Cargamos el detalle

                    DETALLE_CEGRE = New CLASE_DETALLE_CEGRESO
                    DETALLE_CEGRE.p_Idce = CInt(Me.txtIdce.Text)
                    DETALLE_CEGRE.Seleccionar("tabla")

                    For i As Integer = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                        Dim row0 As String() = {CLASE_GENERAL.xdt.Rows(i).Item("Idgasto"), CLASE_GENERAL.xdt.Rows(i).Item("concepto"), CLASE_GENERAL.xdt.Rows(i).Item("observacion"), CLASE_GENERAL.xdt.Rows(i).Item("cantidad"), Format(CLASE_GENERAL.xdt.Rows(i).Item("valor"), "C0"), Format(CLASE_GENERAL.xdt.Rows(i).Item("Total"), "C0")}
                        Me.dgCE.Rows.Add(row0)

                    Next

                    Me.btnAdicionar.Enabled = False

                    Me.btnNuevo.Enabled = True
                    Me.btnImprimir.Enabled = True
                    Me.btnBorrarItem.Enabled = False
                    Me.btnIngresar_Item.Enabled = False

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Anular el Comprobante de Egreso", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "C. Egreso")

            If respuesta = MsgBoxResult.Yes Then

                'Modoficamos el Recibo
                CEGRE = New CLASE_CEGRESO
                CEGRE.p_Idce = Me.txtIdce.Text
                CEGRE.p_Idestado = 0
                ' 1 Es Activa
                ' 0 Es Anulada

                CEGRE.Modificar("estado")

                CEGRE.dispose()
                CEGRE = Nothing

                'Colocamos una etiqueta en el Recibo visible
                Me.lblAnulada.Visible = True

                MsgBox("Comprobante de Egreso Anulado con Exito", MsgBoxStyle.OkOnly, "C. Egreso")

                Me.btnAdicionar.Enabled = False
                Me.btnAnular.Enabled = False
                Me.btnNuevo.Enabled = True
                Me.btnImprimir.Enabled = True
                Me.btnBorrarItem.Enabled = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiacegreso")
            EVEN = Nothing

            Me.cmbProveedores.Text = ""
            Me.txtIdce.Text = Format(CLASE_GENERAL.obtenerconsecutivo(1, "cegreso"), "0000#")

            'Rutina para Borrar las filas
            If Me.dgCE.RowCount >= 1 Then
                For i As Integer = 0 To Me.dgCE.RowCount - 1
                    Me.dgCE.Rows.Remove(Me.dgCE.CurrentRow)
                Next
            End If

            Me.dgCE.DataSource = Nothing

            Me.lblAnulada.Visible = False

            Me.btnAdicionar.Enabled = True
            Me.btnAnular.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnImprimir.Enabled = False
            Me.btnBorrarItem.Enabled = False
            Me.btnIngresar_Item.Enabled = True

        Catch ex As InvalidOperationException ' Esta excepcion es por si ocurriera
            MsgBox("Esta fila no se puede eliminar", MsgBoxStyle.Critical, "Operación inválida : : : . . .")

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub dgCE_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgCE.RowsAdded

        SetupDataGridView()

        Me.txttotal_ce.Text = CLASE_GENERAL.SumarColumna("VALOR", Me.dgCE)

        Me.btnAdicionar.Enabled = True
        Me.btnBorrarItem.Enabled = True

    End Sub

    Private Sub cmbProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedores.Click

        Me.cmbProveedores.Text = ""
        Me.txtIdproveedor.Text = ""

    End Sub

    Private Sub cmbItemGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemGastos.Click

        Me.cmbItemGastos.Text = ""
        Me.txtvalor_gas.Text = 0
        Me.txtIdgasto.Text = ""

    End Sub

    Private Sub cmbItemGastos_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItemGastos.SelectionChangeCommitted

        Try

            GASTOS = New CLASE_GASTOS
            GASTOS.p_Idgasto = Me.cmbItemGastos.SelectedValue
            GASTOS.Seleccionar("registro")

            Me.txtIdgasto.Text = CLASE_GASTOS.xIdgasto
            Me.txtobservacion_gas.Text = CLASE_GASTOS.xobservacion_gas
           
            GASTOS.dispose()
            GASTOS = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbItemGastos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbItemGastos.KeyUp

        If e.KeyCode = Keys.Enter Then

            e.Handled = True

            Try

                GASTOS = New CLASE_GASTOS
                GASTOS.p_Idgasto = Me.cmbItemGastos.SelectedValue
                GASTOS.Seleccionar("registro")

                Me.txtIdgasto.Text = CLASE_GASTOS.xIdgasto
                Me.txtobservacion_gas.Text = CLASE_GASTOS.xobservacion_gas

                GASTOS.dispose()
                GASTOS = Nothing

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try


        End If

    End Sub

    Private Sub cmbProveedores_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProveedores.KeyUp

        If e.KeyCode = Keys.Enter Then

            e.Handled = True

            Try

                Me.txtIdproveedor.Text = Me.cmbProveedores.SelectedValue

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try


        End If
    End Sub

    Private Sub cmbProveedores_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedores.SelectionChangeCommitted

        Try

            Me.txtIdproveedor.Text = Me.cmbProveedores.SelectedValue
            
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnIngresar_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Item.Click

        Try

            If Me.txtIdgasto.Text.Length = 0 Or Me.cmbItemGastos.Text.Length = 0 Or CDbl(Me.txtvalor_gas.Text) = 0 Then

                MessageBox.Show("Existen datos erroneos del Item, verifique por favor", "C. Egreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                Dim row0 As String() = {Me.txtIdgasto.Text, Me.cmbItemGastos.Text, Me.txtobservacion_gas.Text, "1", Me.txtvalor_gas.Text}
                Me.dgCE.Rows.Add(row0)

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnBorrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarItem.Click

        Try

            If Me.dgCE.SelectedRows.Count > 0 Then

                Me.dgCE.Rows.RemoveAt(Me.dgCE.SelectedRows(0).Index)

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "C. Egreso") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub dgCE_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgCE.RowsRemoved

        SetupDataGridView()

        Me.txttotal_ce.Text = CLASE_GENERAL.SumarColumna("VALOR", Me.dgCE)


    End Sub

    Private Sub cmbProveedores_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProveedores.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper()
    End Sub

    Private Sub cmbItemGastos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbItemGastos.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper()
    End Sub

    Private Sub txtIdce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdce.TextChanged
        Me.ErrorProvider.SetError(Me.txtIdce, "")
    End Sub

    Private Sub txtIdproveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdproveedor.TextChanged
        Me.ErrorProvider.SetError(Me.txtIdproveedor, "")
    End Sub

    Private Sub txtconcepto_ce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconcepto_ce.TextChanged
        Me.ErrorProvider.SetError(Me.txtconcepto_ce, "")
    End Sub

    Private Sub txtciudad_ce_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtciudad_ce.TextChanged
        Me.ErrorProvider.SetError(Me.txtciudad_ce, "")
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

        'Estado de Cuenta
        
        ubicarcontrol(Me.lblAnulada)
        ubicarcontrol(Me.lblTituloVentana)

        ubicarcontrol(Me.rcBuscarCEgreso)
        ubicarcontrol(Me.gpIdce)
        ubicarcontrol(Me.gpfechaCE)
        ubicarcontrol(Me.lbltotal_ce)
        ubicarcontrol(Me.txttotal_ce)
        ubicarcontrol(Me.lblRecibimosde)
        ubicarcontrol(Me.lblIdproveedor)
        ubicarcontrol(Me.txtIdproveedor)
        ubicarcontrol(Me.cmbProveedores)
        ubicarcontrol(Me.lblconcepto_ce)
        ubicarcontrol(Me.txtconcepto_ce)

        ubicarcontrol(Me.lblciudad_ce)
        ubicarcontrol(Me.txtciudad_ce)

        ubicarcontrol(Me.gpItems)
        ubicarcontrol(Me.dgCE)
        ubicarcontrol(Me.txtobservaciones_ce)
        ubicarcontrol(Me.lblobservaciones_ce)
        ubicarcontrol(Me.lbldebitesea_ce)
        ubicarcontrol(Me.txtdebitesea_ce)

        ubicarcontrol(Me.gpPagoBanco)

        ubicarcontrol(Me.btnImprimir)
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnAnular)
        ubicarcontrol(Me.btnSalir)

    End Sub

    Private Sub frmComprobanteEgreso_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ubicarcontroles()
    End Sub

End Class