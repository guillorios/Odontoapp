Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Math

Public Class frmRCaja

    'Variables de Clases
    Private RCAJA As CLASE_RCAJA
    Private PAC As CLASE_PACIENTES

    Private GENE As CLASE_GENERAL
    Private PRESUPUESTO As CLASE_PRESUPUESTO

    Private DETALLE_RCAJA As CLASE_DETALLE_RCAJA
    Private EVEN As CLASE_EVENTOS
    Private PROCEDIMIENTOS As CLASE_PROCEDIMIENTOS
    Private CUOTA As CLASE_CUOTAS

    Private CONSULT As CLASE_CONSULTORIO

    'Variables de Control
    Private contar As Integer
    Public nfila As Integer

    Private Sub SetupDataGridView()

        Dim Style1 As New DataGridViewCellStyle
        Style1.Format = "N0"
        Style1.Alignment = DataGridViewContentAlignment.MiddleLeft
        Style1.WrapMode = DataGridViewTriState.True


        Dim Style2 As New DataGridViewCellStyle
        Style2.Alignment = DataGridViewContentAlignment.MiddleCenter
        Style2.WrapMode = DataGridViewTriState.True


        Dim Style3 As New DataGridViewCellStyle
        Style3.Format = "C0"
        Style3.Alignment = DataGridViewContentAlignment.MiddleRight
        Style3.WrapMode = DataGridViewTriState.True

        'Creamos las Columnas
        Me.dgRC.ColumnCount = 8

        With Me.dgRC

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            .Columns(0).Name = "ID.PROCE"
            .Columns(0).DefaultCellStyle = Style2
            .Columns(0).Width = 70
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).Name = "DETALLE"
            .Columns(1).DefaultCellStyle = Style1
            .Columns(1).Width = 160
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(2).Name = "REF."
            .Columns(2).DefaultCellStyle = Style1
            .Columns(2).Width = 90
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(3).Name = "CANT"
            .Columns(3).DefaultCellStyle = Style2
            .Columns(3).Width = 45
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(4).Name = "V.UNIT."
            .Columns(4).DefaultCellStyle = Style3
            .Columns(4).Width = 70
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(5).Name = "V.TOTAL"
            .Columns(5).DefaultCellStyle = Style3
            .Columns(5).Width = 70
            .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(6).Name = "ID.PRES"
            .Columns(6).DefaultCellStyle = Style2
            .Columns(6).Width = 70
            .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).Visible = True

            .Columns(7).Name = "ID.CUOTA"
            .Columns(7).DefaultCellStyle = Style2
            .Columns(7).Width = 50
            .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(7).Visible = True

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .MultiSelect = False

        End With

    End Sub

    Private Sub GRIDSTYLES()

        Dim Style1 As New DataGridViewCellStyle
        Style1.Format = "N0"
        Style1.Alignment = DataGridViewContentAlignment.MiddleLeft
        Style1.WrapMode = DataGridViewTriState.True


        Dim Style2 As New DataGridViewCellStyle
        Style2.Alignment = DataGridViewContentAlignment.MiddleCenter
        Style2.WrapMode = DataGridViewTriState.True


        Dim Style3 As New DataGridViewCellStyle
        Style3.Format = "C0"
        Style3.Alignment = DataGridViewContentAlignment.MiddleRight
        Style3.WrapMode = DataGridViewTriState.True


        With Me.dgRC

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            .Columns(0).Name = "ID"
            .Columns(0).DefaultCellStyle = Style2
            .Columns(0).Width = 50
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).Name = "DETALLE"
            .Columns(1).DefaultCellStyle = Style1
            .Columns(1).Width = 160
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(2).Name = "REF."
            .Columns(2).DefaultCellStyle = Style1
            .Columns(2).Width = 90
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(3).Name = "CANT"
            .Columns(3).DefaultCellStyle = Style2
            .Columns(3).Width = 45
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(4).Name = "V.UNIT."
            .Columns(4).DefaultCellStyle = Style3
            .Columns(4).Width = 70
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(5).Name = "V.TOTAL"
            .Columns(5).DefaultCellStyle = Style3
            .Columns(5).Width = 70
            .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(6).Name = "ID.PRES"
            .Columns(6).DefaultCellStyle = Style2
            .Columns(6).Width = 70
            .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .MultiSelect = False


        End With

    End Sub

    Private Sub frmRCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            SetupDataGridView()

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarrcaja")
            EVEN = Nothing

            Me.txtIdpaciente.Text = My.Forms.mdiOrthoSoft.txtId_ficha.Text
            Me.txtNombre_pac.Text = My.Forms.mdiOrthoSoft.txtNombre_ficha.Text

            Me.cmbfecha_rc.Value = Date.Now

            Me.txtIdrc.Text = Format(CLASE_GENERAL.obtenerconsecutivo(1, "rcaja"), "0000#")

            'Cargamos las Especialidades
            CLASE_GENERAL.cargar_combo("especialidades", Me.cmbEspecialidades, CLASE_GENERAL.mensaje_error)
            Me.cmbEspecialidades.SelectedValue = 1

            'Cargamos los Items
            CLASE_GENERAL.cargar_combo("itemsespecialidad", Me.cmbItem, Me.cmbEspecialidades.SelectedValue)
            Me.cmbItem.SelectedIndex = 0

            If Not (Me.cmbEspecialidades.Text = "") Then
                cmbItem_SelectionChangeCommitted(sender, e)
            End If

            'Cargamos los doctores
            CLASE_GENERAL.cargar_combo("doctores", Me.cmbDoctores, CLASE_GENERAL.mensaje_error)
            Me.cmbDoctores.SelectedValue = CInt(My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag)


            Me.btnAdicionar.Enabled = False
            Me.btnAnular.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnImprimir.Enabled = False
            Me.btnIngresar_Item.Enabled = True

            Me.txtTarjeta_rc.Properties.ReadOnly = True

            CLASE_GENERAL.controlrc = 0
            '0 Es Un Nuevo Recibo de Caja
            '1 EsUn recibo Guardado 

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Ingresar el Recibo de Caja", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Recibo de Caja")

            If respuesta = MsgBoxResult.Yes Then

                Me.ErrorProvider.BlinkRate = 200
                Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.txtIdrc.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtIdrc, "Escriba el Codigo del Recibo de Caja por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtIdrc), MsgBoxStyle.OkOnly, "Recibo de Caja")
                    Me.txtIdrc.Focus()

                ElseIf Me.txtIdpaciente.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtIdpaciente, "Seleccione un paciente por favor.")
                    MsgBox(ErrorProvider.GetError(Me.txtIdpaciente), MsgBoxStyle.OkOnly, "Recibo de Caja")
                    Me.txtIdpaciente.Focus()

                ElseIf Me.txtConcepto_rc.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtConcepto_rc, "escriba el Concepto General por Vavor.")
                    MsgBox(ErrorProvider.GetError(Me.txtConcepto_rc), MsgBoxStyle.OkOnly, "Recibo de Caja")
                    Me.txtConcepto_rc.Focus()

                Else

                    contar = 0
                    contar = CLASE_GENERAL.contar2("Idrc", "rcaja", Me.txtIdrc.Text, CLASE_GENERAL.mensaje_error)

                    If contar > 0 Then

                        MsgBox("El codigo del Recibo de Caja ya Existe por favor verifique.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibo de Caja")

                    Else

                        If Me.dgRC.Rows.Count > 0 Then

                            If CDbl(Me.txtTarjeta_rc.Text) + CDbl(Me.txtEfectivo_rc.Text) = CDbl(Me.txtTotal_rc.Text) Then

                                ' Creamos el Registro en la Tabla Recibos de Caja
                                RCAJA = New CLASE_RCAJA
                                RCAJA.p_Idrc = Me.txtIdrc.Text
                                RCAJA.p_fecha_rc = Format(Me.cmbfecha_rc.Value, "yyyy-MM-dd")

                                RCAJA.p_Idpaciente = Me.txtIdpaciente.Text
                                RCAJA.p_total_rc = Me.txtTotal_rc.Text
                                RCAJA.p_concepto_rc = Me.txtConcepto_rc.Text
                                RCAJA.p_cheque_rc = Me.txtcheque_rc.Text
                                RCAJA.p_banco_rc = Me.txtbanco_rc.Text
                                RCAJA.p_efectivo_rc = Me.txtEfectivo_rc.Text
                                RCAJA.p_tarjeta_rc = Me.txtTarjeta_rc.Text
                                RCAJA.p_Idusuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag
                                RCAJA.p_Iddoctor = Me.cmbDoctores.SelectedValue
                                RCAJA.p_Idestado = 1

                                ' 1 Es Activa
                                ' 0 Es Anulada

                                RCAJA.p_observaciones_rc = Me.txtobservaciones_rc.Text
                                RCAJA.p_estado_cuadre = 0

                                ' 1 Esta Cuadrada
                                ' 0 Esta Sin Cuadrar

                                RCAJA.p_Idlibrodiario = 0


                                RCAJA.Insertar(CLASE_GENERAL.mensaje_error)

                                RCAJA.dispose()
                                RCAJA = Nothing

                                'Agregamos los Items en el detalle_recibo de caja

                                DETALLE_RCAJA = New CLASE_DETALLE_RCAJA
                                DETALLE_RCAJA.p_Idrc = Me.txtIdrc.Text

                                For Each row As DataGridViewRow In Me.dgRC.Rows

                                    DETALLE_RCAJA.p_Idprocedimiento = row.Cells.Item("ID.PROCE").Value
                                    DETALLE_RCAJA.p_Idcuota = row.Cells.Item("ID.CUOTA").Value
                                    DETALLE_RCAJA.p_detalle = row.Cells.Item("DETALLE").Value
                                    DETALLE_RCAJA.p_referencia = row.Cells.Item("REF.").Value
                                    DETALLE_RCAJA.p_valor = row.Cells.Item("V.UNIT.").Value
                                    DETALLE_RCAJA.p_cantidad = row.Cells.Item("CANT").Value
                                    DETALLE_RCAJA.p_Iddoctor = Me.cmbDoctores.SelectedValue

                                    DETALLE_RCAJA.Insertar(CLASE_GENERAL.mensaje_error)

                                Next

                                DETALLE_RCAJA.dispose()
                                DETALLE_RCAJA = Nothing

                                'Ahora modificamos las cuotas si existieran en el recibo

                                CUOTA = New CLASE_CUOTAS

                                For Each row As DataGridViewRow In Me.dgRC.Rows

                                    If row.Cells.Item("REF.").Value = "PAGO CUOTA" Or row.Cells.Item("REF.").Value = "PAGO CUOTA ADICIONAL" Then

                                        CUOTA.p_Idcuota = row.Cells.Item("ID.CUOTA").Value
                                        CUOTA.p_abono_cuota = row.Cells.Item("V.UNIT.").Value
                                        CUOTA.p_saldo_cuota = row.Cells.Item("V.UNIT.").Value

                                        CUOTA.Modificar("abono")

                                        'Modificamos el Presupuesto

                                        PRESUPUESTO = New CLASE_PRESUPUESTO
                                        PRESUPUESTO.p_Idpaciente = Me.txtIdpaciente.Text
                                        PRESUPUESTO.p_Idpresupuesto = row.Cells.Item("ID.PRES").Value
                                        PRESUPUESTO.p_Idestado = 2

                                        PRESUPUESTO.Modificar("estadopresupuesto")

                                        PRESUPUESTO.dispose()
                                        PRESUPUESTO = Nothing

                                    End If

                                Next

                                CUOTA.dispose()
                                CUOTA = Nothing

                                '************   Cambiamos el Consecutivo **********

                                CONSULT = New CLASE_CONSULTORIO
                                CONSULT.p_Idconsultorio = 1
                                CONSULT.p_consecrcaja_cons = CLASE_GENERAL.maximo("Idrc", "rcaja", CLASE_GENERAL.mensaje_error) + 1
                                CONSULT.Modificar("consecrcaja")

                                For Each frm As Form In Me.MdiChildren
                                    If frm.Name = "frmConfiguraciones" Then
                                        My.Forms.frmConfiguraciones.txtconsecrcaja_cons.Text = CLASE_GENERAL.maximo("Idrc", "rcaja", CLASE_GENERAL.mensaje_error) + 1
                                    End If
                                Next

                                CONSULT.dispose()
                                CONSULT = Nothing

                                '*****************************

                                CLASE_GENERAL.controlrc = 1
                                '0 Es Un Nuevo Recibo de Caja
                                '1 Es Un recibo Guardado 

                                MsgBox("Recibo de Caja Grabado con Exito", MsgBoxStyle.OkOnly, "Recibo de Caja")

                                Me.btnAdicionar.Enabled = False
                                Me.btnAnular.Enabled = True
                                Me.btnNuevo.Enabled = True
                                Me.btnImprimir.Enabled = True
                                Me.btnBorrarItem.Enabled = False

                                Me.txtTarjeta_rc.Properties.ReadOnly = True

                            Else

                                MsgBox("Debe especificar el monto del pago en Efectivo o Tarajeta por favor.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibo de Caja")

                            End If

                        Else

                            MsgBox("No hay items en el recibo verifique por favor.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibo de Caja")

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

            RCAJA = New CLASE_RCAJA
            RCAJA.p_Idrc = Me.txtIdrc.Text
            RCAJA.Seleccionar("recibo")

            If Mid(CLASE_GENERAL._formatopos, 1, 1) = "0" Then

                Dim orptRCajaFormato1 As New rptRCajaFormato1()
                ' Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptRCajaFormato1.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptRCajaFormato1

                '------------sumamos los campos

                CUOTA = New CLASE_CUOTAS
                CUOTA.p_Idpaciente = Me.txtIdpaciente.Text
                CUOTA.Seleccionar("sumarcuotas")

                '------------Definimos los textos del Informe
                orptRCajaFormato1.DataDefinition.FormulaFields.Item("cTotalPresupuestos").Text = "'" & Format(CLASE_CUOTAS.xTotalCuotas, "C0") & "'"
                orptRCajaFormato1.DataDefinition.FormulaFields.Item("cTotalAbonos").Text = "'" & Format(CLASE_CUOTAS.xTotalAbonos, "C0") & "'"
                orptRCajaFormato1.DataDefinition.FormulaFields.Item("cTotalSaldos").Text = "'" & Format(CLASE_CUOTAS.xTotalSaldos, "C0") & "'"

                CUOTA.dispose()
                CUOTA = Nothing

                '------------ Exportamos el documento a pdf
                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

                CrDiskFileDestinationOptions.DiskFileName = "c:\Odpp\DocumentoImportante.pdf"
                CrExportOptions = orptRCajaFormato1.ExportOptions

                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With

                orptRCajaFormato1.Export()

            Else

                Dim orptRCajaFormato2 As New rptRCajaFormato2()
                ' Dim toTexto As TextObject

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptRCajaFormato2.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptRCajaFormato2

                '------------sumamos los campos

                CUOTA = New CLASE_CUOTAS
                CUOTA.p_Idpaciente = Me.txtIdpaciente.Text
                CUOTA.Seleccionar("sumarcuotas")

                '------------Definimos los textos del Informe
                orptRCajaFormato2.DataDefinition.FormulaFields.Item("cTotalPresupuestos").Text = "'" & Format(CLASE_CUOTAS.xTotalCuotas, "C0") & "'"
                orptRCajaFormato2.DataDefinition.FormulaFields.Item("cTotalAbonos").Text = "'" & Format(CLASE_CUOTAS.xTotalAbonos, "C0") & "'"
                orptRCajaFormato2.DataDefinition.FormulaFields.Item("cTotalSaldos").Text = "'" & Format(CLASE_CUOTAS.xTotalSaldos, "C0") & "'"

                CUOTA.dispose()
                CUOTA = Nothing

                '------------Exportamos el documento a pdf

                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

                CrDiskFileDestinationOptions.DiskFileName = "c:\Odpp\DocumentoImportante.pdf"
                CrExportOptions = orptRCajaFormato2.ExportOptions

                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With

                orptRCajaFormato2.Export()

            End If

            My.Forms.frmInformes.lblTituloEmail.Text = "Pago de Cuota"
            My.Forms.frmInformes.lblMensajeEmail.Text = "Adjuntamos Documento en formato PDF del Pago realizado de su Tratamiento"

            My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
            My.Forms.frmInformes.crvOrthosoft.Zoom(70)

            'Display the new form.
            My.Forms.frmInformes.Show()
            My.Forms.frmInformes.Activate()

            EVEN = New CLASE_EVENTOS
            My.Forms.frmInformes.txtcorreos.Text = EVEN.buscarcorreos(My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
            EVEN = Nothing

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            RCAJA.dispose()
            RCAJA = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnRCBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCBuscar.Click

        Try

            If Me.txtIdrc_Bus.Text = "" Or Me.txtIdrc_Bus.Text = "0" Then

                Me.DxError.SetError(Me.txtIdrc_Bus, "Escriba el No. del recibo de Caja", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
                MsgBox("Escriba el No. del recibo de Caja por favor", MsgBoxStyle.OkOnly, "Recibo de Caja")

            Else

                contar = CLASE_GENERAL.contar2("Idrc", "rcaja", Me.txtIdrc_Bus.Text, CLASE_GENERAL.mensaje_error)

                If contar = 0 Then

                    Me.txtIdrc_Bus.Text = ""
                    Me.DxError.SetError(Me.txtIdrc, "Escriba el No. del recibo de Caja", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
                    MsgBox("El Recibo de Caja no Exite, digitelo nuevamente Por favor.", MsgBoxStyle.OkOnly, "Recibo de Caja")

                Else

                    CLASE_GENERAL.formloadrc = 1
                    ' 1 No proviene de un estado de Cuenta
                    ' 2 Proviene del Estado de Cuenta

                    CLASE_GENERAL.controlrc = 1
                    '0 Es Un Nuevo Recibo de Caja
                    '1 Es Un recibo Guardado 

                    'Limpiamos el recibo

                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiarrcaja")
                    EVEN = Nothing

                    'Rutina para Borrar las filas
                    If Me.dgRC.RowCount >= 1 Then
                        For i As Integer = 0 To Me.dgRC.RowCount - 1
                            Me.dgRC.Rows.Remove(Me.dgRC.CurrentRow)
                        Next
                    End If

                    ' Buscamos la factura

                    RCAJA = New CLASE_RCAJA
                    RCAJA.p_Idrc = Me.txtIdrc_Bus.Text
                    RCAJA.Seleccionar("registro")

                    Me.txtIdrc.Text = Format(CLASE_RCAJA.xIdrc, "0000#")
                    Me.cmbfecha_rc.Value = CLASE_RCAJA.xfecha_rc
                    Me.txtTotal_rc.Text = CLASE_RCAJA.xtotal_rc
                    Me.txtEfectivo_rc.Text = CLASE_RCAJA.xefectivo_rc
                    Me.txtTarjeta_rc.Text = CLASE_RCAJA.xtarjeta_rc
                    Me.txtIdpaciente.Text = CLASE_RCAJA.xIdpaciente
                    Me.txtConcepto_rc.Text = CLASE_RCAJA.xconcepto_rc
                    Me.txtcheque_rc.Text = CLASE_RCAJA.xcheque_rc
                    Me.txtbanco_rc.Text = CLASE_RCAJA.xbanco_rc
                    Me.cmbDoctores.SelectedValue = CLASE_RCAJA.xIddoctor

                    If CLASE_RCAJA.xIdestado = 0 Then
                        Me.lblAnulada.Visible = True
                        Me.btnAnular.Enabled = False
                    Else
                        Me.lblAnulada.Visible = False
                        Me.btnAnular.Enabled = True
                    End If

                    Me.txtobservaciones_rc.Text = CLASE_RCAJA.xobservaciones_rc

                    RCAJA.dispose()
                    RCAJA = Nothing

                    PAC = New CLASE_PACIENTES
                    PAC.p_IdPaciente = Me.txtIdpaciente.Text
                    PAC.Seleccionar("nombrepaciente")

                    Me.txtNombre_pac.Text = CLASE_PACIENTES.xnombres_pac & " " & CLASE_PACIENTES.xapellidos_pac

                    PAC.dispose()
                    PAC = Nothing

                    'Cargamos el detalle

                    DETALLE_RCAJA = New CLASE_DETALLE_RCAJA
                    DETALLE_RCAJA.p_Idrc = CInt(Me.txtIdrc.Text)
                    DETALLE_RCAJA.Seleccionar("tabla")

                    For i As Integer = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                        Dim row0 As String() = {CLASE_GENERAL.xdt.Rows(i).Item("Idprocedimiento"), CLASE_GENERAL.xdt.Rows(i).Item("detalle"), CLASE_GENERAL.xdt.Rows(i).Item("referencia"), CLASE_GENERAL.xdt.Rows(i).Item("cantidad"), Format(CLASE_GENERAL.xdt.Rows(i).Item("valor"), "C0"), Format(CLASE_GENERAL.xdt.Rows(i).Item("Total"), "C0"), "", CLASE_GENERAL.xdt.Rows(i).Item("Idcuota")}
                        Me.dgRC.Rows.Add(row0)

                    Next

                    Me.btnAdicionar.Enabled = False

                    Me.btnNuevo.Enabled = True
                    Me.btnImprimir.Enabled = True
                    Me.btnBorrarItem.Enabled = False
                    Me.btnIngresar_Item.Enabled = False

                    Me.txtTarjeta_rc.Properties.ReadOnly = True

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Anular el Recibo de Caja", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Recibo de Caja")

            If respuesta = MsgBoxResult.Yes Then

                'Modoficamos el Recibo
                RCAJA = New CLASE_RCAJA
                RCAJA.p_Idrc = Me.txtIdrc.Text
                RCAJA.p_Idestado = 0
                ' 1 Es Activa
                ' 0 Es Anulada

                RCAJA.Modificar("estado")

                RCAJA.dispose()
                RCAJA = Nothing

                'Modificamos y reversamos las cuotas

                'Ahora modificamos las cuotas si existieran en el recibo

                CUOTA = New CLASE_CUOTAS

                For Each row As DataGridViewRow In Me.dgRC.Rows

                    If row.Cells.Item("REF.").Value = "PAGO CUOTA" Or row.Cells.Item("REF.").Value = "PAGO CUOTA ADICIONAL" Then

                        CUOTA.p_Idcuota = row.Cells.Item("ID.CUOTA").Value
                        CUOTA.p_abono_cuota = row.Cells.Item("V.UNIT.").Value
                        CUOTA.p_saldo_cuota = row.Cells.Item("V.UNIT.").Value

                        CUOTA.Modificar("reversar")

                    End If

                Next

                CUOTA.dispose()
                CUOTA = Nothing

                'Colocamos una etiqueta en el  visible
                Me.lblAnulada.Visible = True

                MsgBox("recibo de Caja Anulado con Exito", MsgBoxStyle.OkOnly, "Recibo de Caja")

                Me.btnAdicionar.Enabled = False
                Me.btnAnular.Enabled = False
                Me.btnNuevo.Enabled = True
                Me.btnImprimir.Enabled = True
                Me.btnBorrarItem.Enabled = False

                Me.txtTarjeta_rc.Properties.ReadOnly = True

                CLASE_GENERAL.controlrc = 1
                '0 Es Un Nuevo Recibo de Caja
                '1 EsUn recibo Guardado 

                'Cerramos los documentos de presupuestos o estados de cuenta activos que puedan estar abiertos
                For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren
                    If frm.Name = "frmPresupuesto" Or frm.Name = "frmEstadoCuenta" Then
                        frm.Close()
                    End If
                Next

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarrcaja")
            EVEN = Nothing

            Me.txtIdpaciente.Text = My.Forms.mdiOrthoSoft.txtId_ficha.Text
            Me.txtNombre_pac.Text = My.Forms.mdiOrthoSoft.txtNombre_ficha.Text

            Me.txtIdrc.Text = Format(CLASE_GENERAL.obtenerconsecutivo(1, "rcaja"), "0000#")

            'Rutina para Borrar las filas
            If Me.dgRC.RowCount >= 1 Then
                For i As Integer = 0 To Me.dgRC.RowCount - 1
                    Me.dgRC.Rows.Remove(Me.dgRC.CurrentRow)
                Next
            End If

            Me.dgRC.DataSource = Nothing

            Me.lblAnulada.Visible = False

            Me.btnAdicionar.Enabled = True
            Me.btnAnular.Enabled = False
            Me.btnNuevo.Enabled = True
            Me.btnImprimir.Enabled = False
            Me.btnBorrarItem.Enabled = False
            Me.btnIngresar_Item.Enabled = True

            Me.txtTarjeta_rc.Properties.ReadOnly = True

            CLASE_GENERAL.controlrc = 0
            '0 Es Un Nuevo Recibo de Caja
            '1 EsUn recibo Guardado 


        Catch ex As InvalidOperationException ' Esta excepcion es por si ocurriera
            MsgBox("Esta fila no se puede eliminar", MsgBoxStyle.Critical, "Operación inválida : : : . . .")

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub dgRC_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgRC.RowsAdded

        SetupDataGridView()

        Me.txtTotal_rc.Text = CLASE_GENERAL.SumarColumna("V.TOTAL", Me.dgRC)
        Me.txtEfectivo_rc.Text = CLASE_GENERAL.SumarColumna("V.TOTAL", Me.dgRC)

        If CLASE_GENERAL.formloadrc = 2 Then

            Dim respuesta As Integer
            respuesta = MsgBox("Desea agregar mas cuotas al la Cuenta de Cobro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pacientes")

            If respuesta = MsgBoxResult.Yes Then

                'Cargamos La Ventana de la Cuenta de Cobro
                frmEstadoCuenta.MdiParent = My.Forms.mdiOrthoSoft
                'Display the new form.
                frmEstadoCuenta.Show()
                frmEstadoCuenta.Activate()

            End If

        End If

        Me.btnAdicionar.Enabled = True
        Me.btnBorrarItem.Enabled = True

        Me.txtTarjeta_rc.Properties.ReadOnly = False

    End Sub

    Private Sub cmbItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItem.Click

        Me.cmbItem.Text = ""
        Me.txtIdprocedimiento.Text = "0000"
        Me.txtvalor_proc.Text = ""
        'Me.txtvalor_proc.Properties.ReadOnly = False
        Me.txtTotal.Text = ""

    End Sub

    Private Sub cmbItem_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItem.SelectionChangeCommitted

        CLASE_GENERAL.formloadrc = 1
        ' 1 No proviene de un estado de Cuenta
        ' 2 Proviene del Estado de Cuenta

        Try

            PROCEDIMIENTOS = New CLASE_PROCEDIMIENTOS
            PROCEDIMIENTOS.p_Idprocedimiento = Me.cmbItem.SelectedValue
            PROCEDIMIENTOS.Seleccionar("registro")

            Me.txtIdprocedimiento.Text = CLASE_PROCEDIMIENTOS.xIdprocedimiento
            Me.txtvalor_proc.Text = CLASE_PROCEDIMIENTOS.xvalor_proc
            Me.txtreferencia_proc.Text = CLASE_PROCEDIMIENTOS.xreferencia_proc

            If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

                Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text
                'Me.txtvalor_proc.Properties.ReadOnly = True

            End If

            PROCEDIMIENTOS.dispose()
            PROCEDIMIENTOS = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbItem_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbItem.KeyUp

        If e.KeyCode = Keys.Enter Then

            e.Handled = True

            CLASE_GENERAL.formloadrc = 1
            ' 1 No proviene de un estado de Cuenta
            ' 2 Proviene del Estado de Cuenta

            Try

                PROCEDIMIENTOS = New CLASE_PROCEDIMIENTOS
                PROCEDIMIENTOS.p_Idprocedimiento = Me.cmbItem.SelectedValue
                PROCEDIMIENTOS.Seleccionar("registro")

                Me.txtIdprocedimiento.Text = CLASE_PROCEDIMIENTOS.xIdprocedimiento
                Me.txtvalor_proc.Text = CLASE_PROCEDIMIENTOS.xvalor_proc
                Me.txtreferencia_proc.Text = CLASE_PROCEDIMIENTOS.xreferencia_proc

                If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

                    Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text
                    'Me.txtvalor_proc.Properties.ReadOnly = True

                End If

                PROCEDIMIENTOS.dispose()
                PROCEDIMIENTOS = Nothing


            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try


        End If

    End Sub

    Private Sub btnIngresar_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Item.Click

        If Me.txtIdprocedimiento.Text.Length = 0 Or Me.cmbItem.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0 Or CDbl(Me.txtvalor_proc.Text) = 0 Or CInt(Me.txtCantidad.Text) = 0 Then

            MessageBox.Show("Existen datos erroneos del Item, verifique por favor", "Recibo de Caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            CLASE_GENERAL.formloadrc = 1
            ' 1 No proviene de un estado de Cuenta
            ' 2 Proviene del Estado de Cuenta

            Dim row0 As String() = {Me.txtIdprocedimiento.Text, Me.cmbItem.Text, Me.txtreferencia_proc.Text, Me.txtCantidad.Text, Me.txtvalor_proc.Text, Me.txtTotal.Text}
            Me.dgRC.Rows.Add(row0)

        End If

    End Sub

    Private Sub txtCantidad_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.EditValueChanged

        If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

            Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text

        End If

    End Sub

    Private Sub btnBorrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarItem.Click

        If Me.dgRC.SelectedRows.Count > 0 Then

            If dgRC.CurrentRow.Cells("REF.").Value = "PAGO CUOTA" Then

                For Each fila As DataGridViewRow In My.Forms.frmEstadoCuenta.dgCuotas.Rows
                    ' Si es el mismo apellido del textBox

                    ' Curiosamente si no son los mismos datos
                    ' se produce un error de que d.Cells(...) es Nothing
                    ' En realidad de "curioso" no tiene nada,
                    ' es que es la última fila, que está vacía...
                    If fila.Cells("Idcuota").Value Is Nothing _
                    OrElse fila.Cells Is Nothing Then
                        Continue For
                    End If

                    ' En este ejemplo, el formato es Apellidos, Nombre
                    Dim Idcuota As String
                    Idcuota = dgRC.CurrentRow.Cells("ID").Value

                    If Idcuota = fila.Cells("Idcuota").Value.ToString Then
                        ' Seleccionamos la fila
                        My.Forms.frmEstadoCuenta.dgCuotas.Rows(fila.Index).Cells("abono_cuota").Value = CDbl(My.Forms.frmEstadoCuenta.dgCuotas.Rows(fila.Index).Cells("abono_cuota").Value) - CDbl(dgRC.CurrentRow.Cells("V.TOTAL").Value)
                        My.Forms.frmEstadoCuenta.dgCuotas.Rows(fila.Index).Cells("saldo_cuota").Value = CDbl(My.Forms.frmEstadoCuenta.dgCuotas.Rows(fila.Index).Cells("saldo_cuota").Value) + CDbl(dgRC.CurrentRow.Cells("V.TOTAL").Value)

                        'Seleccionamos la fila
                        My.Forms.frmEstadoCuenta.dgCuotas.Rows(fila.Index).Selected = True
                        ' nos aseguramos de que sea visible
                        My.Forms.frmEstadoCuenta.dgCuotas.FirstDisplayedScrollingRowIndex = fila.Index

                        Exit For

                    End If

                Next


            ElseIf dgRC.CurrentRow.Cells("REF.").Value = "PAGO CUOTA ADICIONAL" Then

                For Each fila As DataGridViewRow In My.Forms.frmEstadoCuenta.dgCuentasadicionales.Rows
                    ' Si es el mismo apellido del textBox

                    ' Curiosamente si no son los mismos datos
                    ' se produce un error de que d.Cells(...) es Nothing
                    ' En realidad de "curioso" no tiene nada,
                    ' es que es la última fila, que está vacía...
                    If fila.Cells("Idcuota").Value Is Nothing _
                    OrElse fila.Cells Is Nothing Then
                        Continue For
                    End If

                    ' En este ejemplo, el formato es Apellidos, Nombre
                    Dim Idcuota As String
                    Idcuota = dgRC.CurrentRow.Cells("ID").Value

                    If Idcuota = fila.Cells("Idcuota").Value.ToString Then
                        ' Seleccionamos la fila
                        My.Forms.frmEstadoCuenta.dgCuentasadicionales.Rows(fila.Index).Cells("abono_cuota").Value = CDbl(My.Forms.frmEstadoCuenta.dgCuentasadicionales.Rows(fila.Index).Cells("abono_cuota").Value) - CDbl(dgRC.CurrentRow.Cells("V.TOTAL").Value)
                        My.Forms.frmEstadoCuenta.dgCuentasadicionales.Rows(fila.Index).Cells("saldo_cuota").Value = CDbl(My.Forms.frmEstadoCuenta.dgCuentasadicionales.Rows(fila.Index).Cells("saldo_cuota").Value) + CDbl(dgRC.CurrentRow.Cells("V.TOTAL").Value)

                        'Seleccionamos la fila
                        My.Forms.frmEstadoCuenta.dgCuentasadicionales.Rows(fila.Index).Selected = True
                        ' nos aseguramos de que sea visible
                        My.Forms.frmEstadoCuenta.dgCuentasadicionales.FirstDisplayedScrollingRowIndex = fila.Index

                        Exit For

                    End If

                Next


            End If

            Me.dgRC.Rows.RemoveAt(Me.dgRC.SelectedRows(0).Index)

        End If

    End Sub

    Private Sub dgRC_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgRC.RowsRemoved

        SetupDataGridView()

        Me.txtTotal_rc.Text = CLASE_GENERAL.SumarColumna("V.TOTAL", Me.dgRC)
        Me.txtEfectivo_rc.Text = CLASE_GENERAL.SumarColumna("V.TOTAL", Me.dgRC)

    End Sub

    Private Sub txtvalor_proc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvalor_proc.EditValueChanged

        If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

            Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text

        End If

    End Sub

    Private Sub cmbItem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbItem.KeyPress

        e.KeyChar = e.KeyChar.ToString.ToUpper()

    End Sub

    Private Sub txtIdrc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdrc.TextChanged
        Me.ErrorProvider.SetError(Me.txtIdrc, "")
    End Sub

    Private Sub txtIdpaciente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdpaciente.TextChanged
        Me.ErrorProvider.SetError(Me.txtIdpaciente, "")
    End Sub

    Private Sub txtConcepto_rc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto_rc.TextChanged
        Me.ErrorProvider.SetError(Me.txtConcepto_rc, "")
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
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.lblDoctores)
        ubicarcontrol(Me.cmbDoctores)
        ubicarcontrol(Me.RibbonBuscar_Rc)
        ubicarcontrol(Me.gpNRcaja)
        ubicarcontrol(Me.lblTotal_rc)
        ubicarcontrol(Me.txtTotal_rc)
        ubicarcontrol(Me.btnImprimir)
        ubicarcontrol(Me.lblNombre_pac)
        ubicarcontrol(Me.txtIdpaciente)
        ubicarcontrol(Me.txtNombre_pac)
        ubicarcontrol(Me.lblConcepto_rc)
        ubicarcontrol(Me.txtConcepto_rc)
        ubicarcontrol(Me.gpItems_rc)
        ubicarcontrol(Me.dgRC)
        ubicarcontrol(Me.lblAnulada)
        ubicarcontrol(Me.lblobservaciones_rc)
        ubicarcontrol(Me.txtobservaciones_rc)
        ubicarcontrol(Me.gpbanco_rc)

        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnAnular)
        ubicarcontrol(Me.btnSalir)

        ubicarcontrol(Me.lblEfectivo_rc)
        ubicarcontrol(Me.txtEfectivo_rc)

        ubicarcontrol(Me.lblTarjeta_rc)
        ubicarcontrol(Me.txtTarjeta_rc)


    End Sub

    Private Sub frmRCaja_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

    Private Sub txtTarjeta_rc_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTarjeta_rc.KeyUp

        CLASE_EVENTOS.operaciones_rc()

    End Sub

    Public Sub cmbEspecialidades_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecialidades.SelectionChangeCommitted

        Try

            'Cargamos los Items
            Me.cmbItem.DisplayMember = Nothing
            CLASE_GENERAL.cargar_combo("itemsespecialidad", Me.cmbItem, Me.cmbEspecialidades.SelectedValue)

            If Not (Me.cmbItem.Text.Length) = 0 Then

                cmbItem_SelectionChangeCommitted(sender, e)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try

    End Sub
End Class