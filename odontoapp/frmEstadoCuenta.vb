Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class frmEstadoCuenta

    'Creamos las Clases
    Private PAC As CLASE_PACIENTES
    Private PRESUPUESTO As CLASE_PRESUPUESTO
    Private PROCEDIMIENTOS As CLASE_PROCEDIMIENTOS
    Private GENE As CLASE_GENERAL
    Private CUOTA As CLASE_CUOTAS
    Private DETALLE_CUOTAS_AD As CLASE_DETALLE_CUOTAS_ADICIONALES

    'Varibles de control
    Private fecha As Date
    Private fechaaux As Date
    Private contar As Integer
    Private prefijopago As String
    Private detalle As String

    'Variables de Control de Costos
    Public xValor As Double
    Public xAbono As Double
    Public xSaldo As Double

    'Veriables de conteo
    Private Ncuotas As Integer
    Private Ncuotas_pagadas As Integer
    Private Ncuotas_Saldo As Integer
    Private Ncuotas_deuda As Integer

    Private Ncuotas_ad As Integer
    Private Ncuotas_pagadas_ad As Integer
    Private Ncuotas_Saldo_ad As Integer
    Private Ncuotas_deuda_ad As Integer

    Private Sub SetupdgCrearCuentaAd()

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
        Me.dgCrearCuentaAd.ColumnCount = 6

        With Me.dgCrearCuentaAd

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
            .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

            .Columns(0).Name = "ID"
            .Columns(0).DefaultCellStyle = Style2
            .Columns(0).Width = 50
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            .Columns(1).Name = "DETALLE"
            .Columns(1).DefaultCellStyle = Style1
            .Columns(1).Width = 150
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            .Columns(2).Name = "REF."
            .Columns(2).DefaultCellStyle = Style1
            .Columns(2).Width = 150
            .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            .Columns(3).Name = "CANT"
            .Columns(3).DefaultCellStyle = Style2
            .Columns(3).Width = 70
            .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            .Columns(4).Name = "V.UNIT."
            .Columns(4).DefaultCellStyle = Style3
            .Columns(4).Width = 70
            .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            .Columns(5).Name = "V.TOTAL"
            .Columns(5).DefaultCellStyle = Style3
            .Columns(5).Width = 70
            .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .MultiSelect = False

        End With

    End Sub


    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

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

            With Me.dgCuotas

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID.CUOTA"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 50
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "CONCEPTO"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 150
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(2).DefaultCellStyle = Style3
                .Columns(2).HeaderText = "VALOR"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 70
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(3).DefaultCellStyle = Style3
                .Columns(3).HeaderText = "ABONO"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 70
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(4).DefaultCellStyle = Style3
                .Columns(4).HeaderText = "SALDO"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 70
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(5).DefaultCellStyle = Style2
                .Columns(5).HeaderText = "FECHA"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 70
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(6).DefaultCellStyle = Style2
                .Columns(6).HeaderText = "ID.PRES"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 70
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(6).Visible = False

                .Columns(7).DefaultCellStyle = Style2
                .Columns(7).HeaderText = "ID.PROCE"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).Width = 70
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(7).Visible = False

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .MultiSelect = False


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub GRIDSTYLES2() ' crear un objeto para estilos del datagrid

        Try

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

            With Me.dgMaestroRcaja

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "RCAJA"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(0).Width = 70

                .Columns(1).DefaultCellStyle = Style2
                .Columns(1).HeaderText = "FECHA"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(1).Width = 70

                .Columns(2).DefaultCellStyle = Style3
                .Columns(2).HeaderText = "TOTAL"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(2).Width = 70

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "CONCEPTO"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(3).Width = 150

                .Columns(4).DefaultCellStyle = Style1
                .Columns(4).HeaderText = "CHEQUE"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(4).Width = 150

                .Columns(5).DefaultCellStyle = Style1
                .Columns(5).HeaderText = "BANCO"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(5).Width = 150

                .Columns(6).DefaultCellStyle = Style1
                .Columns(6).HeaderText = "OBSERVACIONES"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(6).Width = 150

                .Columns(7).DefaultCellStyle = Style1
                .Columns(7).HeaderText = "ESTADO"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(7).Width = 70

                .Columns(8).DefaultCellStyle = Style1
                .Columns(8).HeaderText = "ELABORADA POR"
                .Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(8).Width = 150

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .MultiSelect = False


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub GRIDSTYLES3() ' crear un objeto para estilos del datagrid

        Try

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
            With Me.dgDetalleRcaja

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).Name = "IDRCAJA"
                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 50

                .Columns(1).Name = "CODIGO"
                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 50

                .Columns(2).Name = "CONCEPTO"
                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 150

                .Columns(3).Name = "REF"
                .Columns(3).DefaultCellStyle = Style2
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 150

                .Columns(4).Name = "V.UNIT."
                .Columns(4).DefaultCellStyle = Style3
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 70

                .Columns(5).Name = "CANT"
                .Columns(5).DefaultCellStyle = Style1
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 70

                .Columns(6).Name = "TOTAL"
                .Columns(6).DefaultCellStyle = Style3
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 70

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .MultiSelect = False


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub GRIDSTYLES4() ' crear un objeto para estilos del datagrid

        Try

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

            With Me.dgCuentasadicionales

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID.CUOTA"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 50
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "CONCEPTO"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 150
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(2).DefaultCellStyle = Style3
                .Columns(2).HeaderText = "VALOR"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 70
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(3).DefaultCellStyle = Style3
                .Columns(3).HeaderText = "ABONO"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 70
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(4).DefaultCellStyle = Style3
                .Columns(4).HeaderText = "SALDO"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 70
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(5).DefaultCellStyle = Style2
                .Columns(5).HeaderText = "FECHA"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 70
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(6).DefaultCellStyle = Style2
                .Columns(6).HeaderText = "ID.PRES"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 70
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(6).Visible = False

                .Columns(7).DefaultCellStyle = Style2
                .Columns(7).HeaderText = "ID.PROCE"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).Width = 70
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(7).Visible = False

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .MultiSelect = False


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub frmEstadoCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'Controlamos que exista un registro 
            'si no existe creamos un nuevo registro al insertarlo en la base de datos
            contar = 0
            contar = CLASE_GENERAL.contar2("Idpaciente", "presupuesto", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

            If contar > 0 Then

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("cuotas", Me.dgCuotas, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
                GENE.Cargar_Grilla("cuotasadicionales", Me.dgCuentasadicionales, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
                GRIDSTYLES()
                GRIDSTYLES4()

                Me.dgCuotas.ClearSelection()
                Me.dgCuentasadicionales.ClearSelection()

                GENE = Nothing

                Me.cmbfecha_ad.Value = Date.Now

                'CONTAMOS Y SUMAMOS LOS TOTALES
                contarcuotas()

            Else

                MsgBox("No se ha creado un presupuesto para este paciente.", MsgBoxStyle.OkOnly, "Presupuesto")

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub contarcuotas()

        Try

            Ncuotas = 0
            Ncuotas_deuda = 0
            Ncuotas_pagadas = 0
            Ncuotas_Saldo = 0

            Ncuotas_ad = 0
            Ncuotas_deuda_ad = 0
            Ncuotas_pagadas_ad = 0
            Ncuotas_Saldo_ad = 0

            If Not (Me.dgCuotas.Rows.Count = 0) Then

                For Each row As DataGridViewRow In Me.dgCuotas.Rows

                    Ncuotas += 1

                    If CDbl(row.Cells.Item("saldo_cuota").Value) = CDbl(row.Cells.Item("valor_cuota").Value) Then

                        Ncuotas_deuda += 1

                    ElseIf CDbl(row.Cells.Item("saldo_cuota").Value) = 0 Then

                        Ncuotas_pagadas += 1

                    ElseIf CDbl(row.Cells.Item("saldo_cuota").Value) < CDbl(row.Cells.Item("valor_cuota").Value) Then

                        Ncuotas_Saldo += 1

                    End If

                Next

                Me.txtTotalPresupuesto.Text = CLASE_GENERAL.SumarColumna("valor_cuota", Me.dgCuotas)
                Me.txtTotalAbonos.Text = CLASE_GENERAL.SumarColumna("abono_cuota", Me.dgCuotas)
                Me.txtTotalSaldo.Text = CLASE_GENERAL.SumarColumna("saldo_cuota", Me.dgCuotas)

            Else

                Me.txtTotalPresupuesto.Text = "0"
                Me.txtTotalAbonos.Text = "0"
                Me.txtTotalSaldo.Text = "0"


            End If

            If Not (Me.dgCuentasadicionales.Rows.Count = 0) Then


                For Each row2 As DataGridViewRow In Me.dgCuentasadicionales.Rows

                    Ncuotas_ad += 1

                    If CDbl(row2.Cells.Item("saldo_cuota").Value) = CDbl(row2.Cells.Item("valor_cuota").Value) Then

                        Ncuotas_deuda_ad += 1

                    ElseIf CDbl(row2.Cells.Item("saldo_cuota").Value) = 0 Then

                        Ncuotas_pagadas_ad += 1

                    ElseIf CDbl(row2.Cells.Item("saldo_cuota").Value) < CDbl(row2.Cells.Item("valor_cuota").Value) Then

                        Ncuotas_Saldo_ad += 1

                    End If

                Next

                Me.txtTotalAdicionales.Text = CLASE_GENERAL.SumarColumna("valor_cuota", Me.dgCuentasadicionales)
                Me.txtTotalAbonos_ad.Text = CLASE_GENERAL.SumarColumna("abono_cuota", Me.dgCuentasadicionales)
                Me.txtTotalSaldo_ad.Text = CLASE_GENERAL.SumarColumna("saldo_cuota", Me.dgCuentasadicionales)


            Else

                Me.txtTotalAdicionales.Text = "0"
                Me.txtTotalAbonos_ad.Text = "0"
                Me.txtTotalSaldo_ad.Text = "0"

            End If

            Me.txtNcuotas.Text = Ncuotas
            Me.txtNcuotas_deuda.Text = Ncuotas_deuda
            Me.txtNcuotas_pagadas.Text = Ncuotas_pagadas
            Me.txtNcuotas_Saldo.Text = Ncuotas_Saldo

            Me.txtNcuotas_ad.Text = Ncuotas_ad
            Me.txtNcuotas_deuda_ad.Text = Ncuotas_deuda_ad
            Me.txtNcuotas_pagadas_ad.Text = Ncuotas_pagadas_ad
            Me.txtNcuotas_Saldo_ad.Text = Ncuotas_Saldo_ad

            Me.txtTotalTratamiento.Text = CDbl(Me.txtTotalPresupuesto.Text) + CDbl(Me.txtTotalAdicionales.Text)
            Me.txtTotalTratamientoAbonos.Text = CDbl(Me.txtTotalAbonos.Text) + CDbl(Me.txtTotalAbonos_ad.Text)
            Me.txtTotalTratamientoSaldo.Text = CDbl(txtTotalSaldo.Text) + CDbl(Me.txtTotalSaldo_ad.Text)

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub dgCuotas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgCuotas.CellFormatting

        If dgCuotas.Columns(e.ColumnIndex).Name.Equals("abono_cuota") Then

            xAbono = e.Value

        End If

        If dgCuotas.Columns(e.ColumnIndex).Name.Equals("valor_cuota") Then

            xValor = e.Value

        End If

        ' Set the background to red for negative values in the Balance column.
        If dgCuotas.Columns(e.ColumnIndex).Name.Equals("saldo_cuota") Then

            xsaldo = e.Value

            'Cuota Saldo
            If CInt(e.Value) = xValor Then

                e.CellStyle.BackColor = Color.LightPink
                e.CellStyle.SelectionBackColor = Color.DarkRed

            End If

            'Cuota Con Abono
            If CInt(e.Value) < xValor Then

                e.CellStyle.BackColor = Color.Yellow
                e.CellStyle.SelectionBackColor = Color.Goldenrod

            End If

            'Cuota cancelada
            If CInt(e.Value) = 0 Then

                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.SelectionBackColor = Color.Green

            End If


        End If

    End Sub

    Private Sub dgCuentasadicionales_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgCuentasadicionales.CellFormatting

        If dgCuentasadicionales.Columns(e.ColumnIndex).Name.Equals("abono_cuota") Then

            xAbono = e.Value

        End If

        If dgCuentasadicionales.Columns(e.ColumnIndex).Name.Equals("valor_cuota") Then

            xValor = e.Value

        End If

        ' Set the background to red for negative values in the Balance column.
        If dgCuentasadicionales.Columns(e.ColumnIndex).Name.Equals("saldo_cuota") Then

            xSaldo = e.Value

            'Cuota Saldo
            If CInt(e.Value) = xValor Then

                e.CellStyle.BackColor = Color.LightPink
                e.CellStyle.SelectionBackColor = Color.DarkRed

            End If

            'Cuota Con Abono
            If CInt(e.Value) < xValor Then

                e.CellStyle.BackColor = Color.Yellow
                e.CellStyle.SelectionBackColor = Color.Goldenrod

            End If

            'Cuota cancelada
            If CInt(e.Value) = 0 Then

                e.CellStyle.BackColor = Color.LightGreen
                e.CellStyle.SelectionBackColor = Color.Green

            End If

        End If
    End Sub

    Private Sub actualizarcuota()

        Try

            Me.txtCodigoCuota.Text = Me.dgCuotas.CurrentRow.Cells("Idcuota").Value
            Me.txtValorCuota.Text = Me.dgCuotas.CurrentRow.Cells("valor_cuota").Value
            Me.txtAbonoCuota.Text = Me.dgCuotas.CurrentRow.Cells("abono_cuota").Value
            Me.txtSaldoCuota.Text = Me.dgCuotas.CurrentRow.Cells("saldo_cuota").Value
            Me.txtNomCuota.Text = Me.dgCuotas.CurrentRow.Cells("procedimiento_cuota").Value

            Me.txtPagoCuota.Text = ""


            If CDbl(Me.txtSaldoCuota.Text) > 0 Then

                Me.btnPagarCuota.Enabled = True

            Else

                Me.btnPagarCuota.Enabled = False

            End If

            Me.chkdescuento.Checked = False

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub actualizarcuotaadicional()

        Try

            Me.txtCodigoCuota_ad.Text = Me.dgCuentasadicionales.CurrentRow.Cells("Idcuota").Value
            Me.txtValorCuota_ad.Text = Me.dgCuentasadicionales.CurrentRow.Cells("valor_cuota").Value
            Me.txtAbonoCuota_ad.Text = Me.dgCuentasadicionales.CurrentRow.Cells("abono_cuota").Value
            Me.txtSaldoCuota_ad.Text = Me.dgCuentasadicionales.CurrentRow.Cells("saldo_cuota").Value
            Me.txtNomCuota_ad.Text = Me.dgCuentasadicionales.CurrentRow.Cells("procedimiento_cuota").Value

            Me.txtPagoCuota_ad.Text = ""


            If CDbl(Me.txtSaldoCuota_ad.Text) > 0 Then

                Me.btnPagoCuentaAd.Enabled = True

            Else

                Me.btnPagoCuentaAd.Enabled = False

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub dgCuotas_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCuotas.CellEnter

        actualizarcuota()

    End Sub

    Private Sub dgCuentasadicionales_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCuentasadicionales.CellEnter

        actualizarcuotaadicional()

        If CDbl(txtAbonoCuota_ad.Text) = 0 Then

            Me.btnBorrarCuentaAdicional.Enabled = True

        Else

            Me.btnBorrarCuentaAdicional.Enabled = False

        End If


    End Sub

    Private Sub btnPagarCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagarCuota.Click

        Try
            If CLASE_GENERAL.controlrc = 0 Then

                If CDbl(Me.txtPagoCuota.Text) <= 0 Or (CDbl(Me.txtPagoCuota.Text) > CDbl(Me.txtSaldoCuota.Text)) Then

                    MessageBox.Show("El valor a pagar de la cuota es cero (0) o mayor que el saldo, verifique por favor", "Pago Cuotas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else

                    'Editamos el Datagrid Provisionalmente
                    Me.dgCuotas.CurrentRow.Cells("abono_cuota").Value = CDbl(Me.dgCuotas.CurrentRow.Cells("abono_cuota").Value) + CDbl(Me.txtPagoCuota.Text)
                    Me.dgCuotas.CurrentRow.Cells("saldo_cuota").Value = CDbl(Me.dgCuotas.CurrentRow.Cells("saldo_cuota").Value) - CDbl(Me.txtPagoCuota.Text)

                    'Cargamos La Ventana de la Cuenta de Cobro
                    frmRCaja.MdiParent = My.Forms.mdiOrthoSoft
                    'Display the new form.
                    frmRCaja.Show()
                    frmRCaja.Activate()

                    CLASE_GENERAL.formloadrc = 2
                    ' 1 No proviene de un estado de Cuenta
                    ' 2 Proviene del Estado de Cuenta

                    'Cargamos los datos y las lineas de la cuenta de cobro
                    My.Forms.frmRCaja.txtIdpaciente.Text = My.Forms.mdiOrthoSoft.txtId_ficha.Text
                    My.Forms.frmRCaja.txtNombre_pac.Text = My.Forms.mdiOrthoSoft.txtNombre_ficha.Text

                    If CDbl(Me.txtPagoCuota.Text) < CDbl(Me.txtSaldoCuota.Text) Then

                        prefijopago = "ABONO "

                    Else

                        prefijopago = "PAGO "

                    End If

                    My.Forms.frmRCaja.txtConcepto_rc.Text = "PAGO CUOTAS TRATAMIENTO"

                    Dim row0 As String() = {Me.dgCuotas.CurrentRow.Cells("Idprocedimiento").Value, prefijopago & Me.txtNomCuota.Text, "PAGO CUOTA", 1, Me.txtPagoCuota.Text, Me.txtPagoCuota.Text, Me.dgCuotas.CurrentRow.Cells("Idpresupuesto").Value, Me.txtCodigoCuota.Text}
                    My.Forms.frmRCaja.dgRC.Rows.Add(row0)

                    actualizarcuota()
                    contarcuotas()

                End If

            Else

                MessageBox.Show("Debe crear un Nuevo Recibo de Caja, el actual ha sido Guardado", "Pago Cuotas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

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
        ubicarcontrol(Me.dgCuotas)
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.lblPagoCuota)
        ubicarcontrol(Me.txtPagoCuota)
        ubicarcontrol(Me.btnPagarCuota)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.lblCodigoCuota)
        ubicarcontrol(Me.txtCodigoCuota)
        ubicarcontrol(Me.lblNomCuota)
        ubicarcontrol(Me.txtNomCuota)
        ubicarcontrol(Me.lblValorCuota)
        ubicarcontrol(Me.txtValorCuota)
        ubicarcontrol(Me.lblAbonoCuota)
        ubicarcontrol(Me.txtAbonoCuota)
        ubicarcontrol(Me.lblSaldoCuota)
        ubicarcontrol(Me.txtSaldoCuota)
        ubicarcontrol(Me.btnBorrarCuentaAdicional)
        ubicarcontrol(Me.chkdescuento)
        ubicarcontrol(Me.gpDescuentos)

        'Cuentas Adicionales

        ubicarcontrol(Me.lblCuentasAdicionales)
        ubicarcontrol(Me.dgCuentasadicionales)
        ubicarcontrol(Me.lblCodigoCuota_ad)
        ubicarcontrol(Me.txtCodigoCuota_ad)
        ubicarcontrol(Me.lblNomCuota_ad)
        ubicarcontrol(Me.txtNomCuota_ad)
        ubicarcontrol(Me.lblPagoCuota_ad)
        ubicarcontrol(Me.txtPagoCuota_ad)

        ubicarcontrol(Me.lblValorCuota_ad)
        ubicarcontrol(Me.txtValorCuota_ad)
        ubicarcontrol(Me.lblAbonoCuota_ad)
        ubicarcontrol(Me.txtAbonoCuota_ad)
        ubicarcontrol(Me.lblSaldoCuota_ad)
        ubicarcontrol(Me.txtSaldoCuota_ad)
        ubicarcontrol(Me.btnPagoCuentaAd)

        'Crear Cuenta adicional

        ubicarcontrol(Me.lblCrearCuentaAd)
        ubicarcontrol(Me.dgCrearCuentaAd)
        ubicarcontrol(Me.gpItems_cuentas)

        ubicarcontrol(Me.lblTotal_Cuenta_ad)
        ubicarcontrol(Me.txtTotal_Cuenta_ad)
        ubicarcontrol(Me.btnCrearCuentaAdicional)
        ubicarcontrol(Me.btnNuevaCuentaAdicional)

        ubicarcontrol(Me.btnBorrarItem)
        ubicarcontrol(Me.gpPresupuestos)

        'Resumen de Pagos

        ubicarcontrol(Me.lblResumenPagos)
        ubicarcontrol(Me.lblMaestro)
        ubicarcontrol(Me.dgMaestroRcaja)
        ubicarcontrol(Me.lblDetalle)
        ubicarcontrol(Me.dgDetalleRcaja)
        ubicarcontrol(Me.lblTotalPagos)
        ubicarcontrol(Me.txtTotalPagos)
        ubicarcontrol(Me.gpTipoInforme)
        ubicarcontrol(Me.btnImprimir)


        'Resumen de Cuentas
        ubicarcontrol(Me.lblResumenCuentas)
        ubicarcontrol(Me.gpEstadoCuenta)
        ubicarcontrol(Me.gpTotalCuotas)
        ubicarcontrol(Me.gpEstadoCuentasAd)
        ubicarcontrol(Me.gpTotalCuentasAd)
        ubicarcontrol(Me.gpTotalTratamiento)

    End Sub

    Private Sub TabControlCuentas_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControlCuentas.SelectedTabChanged

        Try

            If TabControlCuentas.SelectedTab.Text = "Resumen de Pagos" Then

                'Controlamos que exista un registro 
                'si no existe creamos un nuevo registro al insertarlo en la base de datos
                contar = 0
                contar = CLASE_GENERAL.contar2("Idpaciente", "rcaja", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla_mestrodetalle("recibosdecaja", Me.dgMaestroRcaja, Me.dgDetalleRcaja, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, 1)
                    GENE = Nothing

                    GRIDSTYLES2()
                    GRIDSTYLES3()

                    Me.dgMaestroRcaja.ClearSelection()

                    Me.txtTotalPagos.Text = CLASE_GENERAL.SumarColumna("total_rc", Me.dgMaestroRcaja)

                Else

                    MsgBox("No se han realizado pagos de este paciente.", MsgBoxStyle.OkOnly, "Estado de Cuenta")

                End If

            ElseIf TabControlCuentas.SelectedTab.Text = "Crear Cuenta Adicional" Then

                SetupdgCrearCuentaAd()

                'Cargamos las Especialidades
                CLASE_GENERAL.cargar_combo("especialidades", Me.cmbEspecialidades, CLASE_GENERAL.mensaje_error)
                Me.cmbEspecialidades.SelectedValue = 1

                'Cargamos los Items
                CLASE_GENERAL.cargar_combo("itemsespecialidad", Me.cmbItem, Me.cmbEspecialidades.SelectedValue)
                Me.cmbItem.SelectedIndex = 0

                'Cargamos los Items
                CLASE_GENERAL.cargar_combo("presupuestos", cmbPresupuestos, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)

                If Me.cmbPresupuestos.Items.Count > 0 Then
                    Me.cmbPresupuestos.SelectedIndex = 0
                Else
                    MsgBox("No hay presupuestos para este Paciente.", MsgBoxStyle.OkOnly, "Estado de Cuenta")
                End If

                If Not (Me.cmbEspecialidades.Text = "") Then
                    cmbItem_SelectionChangeCommitted(sender, e)
                End If

                Me.cmbfecha_ad.Value = Date.Now

                'Cargamos el id de la siguiente cuota
                Me.txtNCuentaAd.Text = (CLASE_GENERAL.maximo("Idcuota", "cuotas", CLASE_GENERAL.mensaje_error)) + 1

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub frmEstadoCuenta_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

    Private Sub cmbItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItem.Click

        Me.cmbItem.Text = ""
        Me.txtIdprocedimiento.Text = ""
        Me.txtvalor_proc.Text = ""
        Me.txtTotal.Text = ""
        Me.txtCantidad.Text = 1

    End Sub

    Private Sub cmbItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbItem.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper()
    End Sub

    Private Sub btnIngresar_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_Item.Click

        Try

            If Me.txtIdprocedimiento.Text.Length = 0 Or Me.cmbItem.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0 Or CDbl(Me.txtvalor_proc.Text) = 0 Or CInt(Me.txtCantidad.Text) = 0 Then

                MessageBox.Show("Existen datos erroneos del Item, verifique por favor", "Recibo de Caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else


                Dim row0 As String() = {Me.txtIdprocedimiento.Text, Me.cmbItem.Text, Me.txtreferencia_proc.Text, Me.txtCantidad.Text, Me.txtvalor_proc.Text, Me.txtTotal.Text}
                Me.dgCrearCuentaAd.Rows.Add(row0)

                Me.btnCrearCuentaAdicional.Enabled = True
                Me.btnBorrarItem.Enabled = True

                Me.txtTotal_Cuenta_ad.Text = CLASE_GENERAL.SumarColumna("V.TOTAL", Me.dgCrearCuentaAd)

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Estado de Cuenta") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbItem_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbItem.KeyUp

        If e.KeyCode = Keys.Enter Then

            e.Handled = True

            Try

                PROCEDIMIENTOS = New CLASE_PROCEDIMIENTOS
                PROCEDIMIENTOS.p_Idprocedimiento = Me.cmbItem.SelectedValue
                PROCEDIMIENTOS.Seleccionar("registro")

                Me.txtIdprocedimiento.Text = CLASE_PROCEDIMIENTOS.xIdprocedimiento
                Me.txtvalor_proc.Text = CLASE_PROCEDIMIENTOS.xvalor_proc
                Me.txtreferencia_proc.Text = CLASE_PROCEDIMIENTOS.xreferencia_proc

                If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

                    Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text

                End If

                PROCEDIMIENTOS.dispose()
                PROCEDIMIENTOS = Nothing

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Recibos de Caja") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try

        End If

    End Sub

    Private Sub cmbItem_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItem.SelectionChangeCommitted


        Try

            PROCEDIMIENTOS = New CLASE_PROCEDIMIENTOS
            PROCEDIMIENTOS.p_Idprocedimiento = Me.cmbItem.SelectedValue
            PROCEDIMIENTOS.Seleccionar("registro")

            Me.txtIdprocedimiento.Text = CLASE_PROCEDIMIENTOS.xIdprocedimiento
            Me.txtvalor_proc.Text = CLASE_PROCEDIMIENTOS.xvalor_proc
            Me.txtreferencia_proc.Text = CLASE_PROCEDIMIENTOS.xreferencia_proc

            If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

                Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text

            End If

            PROCEDIMIENTOS.dispose()
            PROCEDIMIENTOS = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Estado de Cuenta") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

        If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

            Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text

        End If

    End Sub

    Private Sub txtvalor_proc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvalor_proc.TextChanged

        If Not (Me.txtCantidad.Text.Length = 0 Or Me.txtvalor_proc.Text.Length = 0) Then

            Me.txtTotal.Text = Me.txtCantidad.Text * Me.txtvalor_proc.Text

        End If

    End Sub

    Private Sub btnCrearCuentaAdicional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearCuentaAdicional.Click

        Try

            'Adicionamos los items en el detalle de cuotas adicinales
            If Me.cmbPresupuestos.Items.Count > 0 Then

                detalle = ""

                DETALLE_CUOTAS_AD = New CLASE_DETALLE_CUOTAS_ADICIONALES
                DETALLE_CUOTAS_AD.p_Idcuota = Me.txtNCuentaAd.Text

                For Each row As DataGridViewRow In Me.dgCrearCuentaAd.Rows

                    DETALLE_CUOTAS_AD.p_Idprocedimiento = row.Cells.Item("ID").Value
                    DETALLE_CUOTAS_AD.p_detalle = row.Cells.Item("DETALLE").Value
                    DETALLE_CUOTAS_AD.p_referencia = row.Cells.Item("REF.").Value
                    DETALLE_CUOTAS_AD.p_valor = row.Cells.Item("V.UNIT.").Value
                    DETALLE_CUOTAS_AD.p_cantidad = row.Cells.Item("CANT").Value

                    DETALLE_CUOTAS_AD.Insertar(CLASE_GENERAL.mensaje_error)

                    detalle = detalle & (row.Cells.Item("CANT").Value & ": " & row.Cells.Item("DETALLE").Value & " - ")

                Next

                DETALLE_CUOTAS_AD.dispose()
                DETALLE_CUOTAS_AD = Nothing

                'creamos la Cuota Adicional
                CUOTA = New CLASE_CUOTAS

                CUOTA.p_Idcuota = Me.txtNCuentaAd.Text
                CUOTA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                CUOTA.p_Idpresupuesto = Me.cmbPresupuestos.SelectedValue
                CUOTA.p_fecha_cuota = Format(cmbfecha_ad.Value, "yyyy-MM-dd")
                CUOTA.p_valor_cuota = Me.txtTotal_Cuenta_ad.Text
                CUOTA.p_saldo_cuota = Me.txtTotal_Cuenta_ad.Text
                CUOTA.p_abono_cuota = 0
                CUOTA.p_tipo_cuota = 2 ' Tipo Cuota Adicional
                CUOTA.p_Idprocedimiento = "00001" ' Ortodoncia
                CUOTA.p_procedimiento_cuota = detalle

                CUOTA.Insertar(CLASE_GENERAL.mensaje_error)

                CUOTA.dispose()
                CUOTA = Nothing

                'Cargamos la grilla con los pagos
                GENE = New CLASE_GENERAL

                GENE.Cargar_Grilla("cuotasadicionales", Me.dgCuentasadicionales, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
                GRIDSTYLES4()

                GENE = Nothing

                Me.dgCuentasadicionales.ClearSelection()

                'Sumamos y contamos las cuotas
                contarcuotas()

                btnNuevaCuentaAdicional_Click(sender, e)

                MsgBox("Cuota Adiciona Creada con exito.", MsgBoxStyle.OkOnly, "Cuotas Adicionales")

                Me.TabControlCuentas.SelectedTabIndex = 1

            Else

                MsgBox("No hay presupuestos para este paciente.", MsgBoxStyle.OkOnly, "Cuotas Adicionales")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Estado de Cuenta") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnPagoCuentaAd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagoCuentaAd.Click

        Try

            If CLASE_GENERAL.controlrc = 0 Then

                If CDbl(Me.txtPagoCuota_ad.Text) <= 0 Or (CDbl(Me.txtPagoCuota_ad.Text) > CDbl(Me.txtSaldoCuota_ad.Text)) Then

                    MessageBox.Show("El valor a pagar de la cuota es cero (0) o mayor que el saldo, verifique por favor", "Pago Cuotas Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else

                    'Editamos el Datagrid Provisionalmente
                    Me.dgCuentasadicionales.CurrentRow.Cells("abono_cuota").Value = CDbl(Me.dgCuentasadicionales.CurrentRow.Cells("abono_cuota").Value) + CDbl(Me.txtPagoCuota_ad.Text)
                    Me.dgCuentasadicionales.CurrentRow.Cells("saldo_cuota").Value = CDbl(Me.dgCuentasadicionales.CurrentRow.Cells("saldo_cuota").Value) - CDbl(Me.txtPagoCuota_ad.Text)

                    'Cargamos La Ventana de la Cuenta de Cobro
                    frmRCaja.MdiParent = My.Forms.mdiOrthoSoft
                    'Display the new form.
                    frmRCaja.Show()
                    frmRCaja.Activate()

                    CLASE_GENERAL.formloadrc = 2
                    ' 1 No proviene de un estado de Cuenta
                    ' 2 Proviene del Estado de Cuenta

                    'Cargamos los datos y las lineas de la cuenta de cobro
                    My.Forms.frmRCaja.txtIdpaciente.Text = My.Forms.mdiOrthoSoft.txtId_ficha.Text
                    My.Forms.frmRCaja.txtNombre_pac.Text = My.Forms.mdiOrthoSoft.txtNombre_ficha.Text

                    If CDbl(Me.txtPagoCuota_ad.Text) < CDbl(Me.txtSaldoCuota_ad.Text) Then

                        prefijopago = "ABONO "

                    Else

                        prefijopago = "PAGO "

                    End If

                    My.Forms.frmRCaja.txtConcepto_rc.Text = "PAGO CUOTAS TRATAMIENTO "

                    Dim row0 As String() = {Me.dgCuentasadicionales.CurrentRow.Cells("Idprocedimiento").Value, prefijopago & Me.txtNomCuota_ad.Text, "PAGO CUOTA ADICIONAL", 1, Me.txtPagoCuota_ad.Text, Me.txtPagoCuota_ad.Text, Me.dgCuentasadicionales.CurrentRow.Cells("Idpresupuesto").Value, Me.txtCodigoCuota_ad.Text}
                    My.Forms.frmRCaja.dgRC.Rows.Add(row0)

                    actualizarcuotaadicional()
                    contarcuotas()

                End If

            Else

                MessageBox.Show("Debe crear un Nuevo Recibo de Caja, el actual ha sido Guardado", "Pago Cuotas Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub btnBorrarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarItem.Click

        If Me.dgCrearCuentaAd.SelectedRows.Count > 0 Then

            Me.dgCrearCuentaAd.Rows.RemoveAt(Me.dgCrearCuentaAd.SelectedRows(0).Index)

        End If

        If Me.dgCrearCuentaAd.Rows.Count = 0 Then

            Me.btnBorrarItem.Enabled = False

        Else

            Me.btnBorrarItem.Enabled = True

        End If

    End Sub

    Private Sub btnNuevaCuentaAdicional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaCuentaAdicional.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea un grupo de Cuenta Adicional ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuentas Adicionales")

            If respuesta = MsgBoxResult.Yes Then

                If Me.cmbPresupuestos.Items.Count > 0 Then

                    cmbItem_Click(sender, e)

                    SetupdgCrearCuentaAd()

                    'Cargamos la fecha
                    CUOTA = New CLASE_CUOTAS
                    CUOTA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                    'Seleccionamos la ultima fecha del presupuesto para aumentarle un mes
                    CUOTA.Seleccionar("ultimafecha")

                    fecha = CDate(CLASE_CUOTAS.xfecha_cuota)
                    fechaaux = CDate(CLASE_CUOTAS.xfecha_cuota)

                    fechaaux = Format((DateAdd(DateInterval.Month, 1, fecha)), "yyyy-MM-dd")

                    Me.cmbfecha_ad.Value = fechaaux

                    'Cargamos el id de la siguiente cuota
                    Me.txtNCuentaAd.Text = (CLASE_GENERAL.maximo("Idcuota", "cuotas", CLASE_GENERAL.mensaje_error)) + 1

                    'Rutina para Borrar las filas
                    If Me.dgCrearCuentaAd.RowCount >= 1 Then
                        For i As Integer = 0 To Me.dgCrearCuentaAd.RowCount - 1
                            Me.dgCrearCuentaAd.Rows.Remove(Me.dgCrearCuentaAd.CurrentRow)
                        Next
                    End If

                    Me.dgCrearCuentaAd.DataSource = Nothing
                    Me.btnBorrarItem.Enabled = False

                Else

                    MsgBox("No hay presupuestos para este paciente.", MsgBoxStyle.OkOnly, "Cuotas Adicionales")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub btnBorrarCuentaAdicional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrarCuentaAdicional.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Borra la Cuenta Adicional", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cuentas Adicionales")

            If respuesta = MsgBoxResult.Yes Then

                If CDbl(Me.txtAbonoCuota_ad.Text) = 0 Then

                    'Borramos la cuota adicional
                    CUOTA = New CLASE_CUOTAS
                    CUOTA.p_Idcuota = Me.txtCodigoCuota_ad.Text
                    CUOTA.Eliminar("porcita")

                    CUOTA.dispose()
                    CUOTA = Nothing

                    'Borramos el de Detalle de la cuota adicional

                    DETALLE_CUOTAS_AD = New CLASE_DETALLE_CUOTAS_ADICIONALES
                    DETALLE_CUOTAS_AD.p_Idcuota = Me.txtCodigoCuota_ad.Text
                    DETALLE_CUOTAS_AD.Eliminar(CLASE_GENERAL.mensaje_error)

                    DETALLE_CUOTAS_AD.dispose()
                    DETALLE_CUOTAS_AD = Nothing

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("cuotasadicionales", Me.dgCuentasadicionales, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
                    GRIDSTYLES4()

                    Me.dgCuentasadicionales.ClearSelection()

                    GENE = Nothing

                Else

                    MessageBox.Show("No puede eliminar la cuenta adicional, ya tiene un saldo", "Pago Cuotas Adicionales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


                End If


            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub chkdescuento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdescuento.CheckedChanged

        If chkdescuento.Checked = True Then

            If Me.btnPagarCuota.Enabled = True Then
                Me.gpDescuentos.Enabled = True
            End If

            Me.txtPorcDesc.Text = "0"
            Me.txtValorDesc.Text = "0"

        Else

            Me.gpDescuentos.Enabled = False
            Me.txtPorcDesc.Text = "0"
            Me.txtValorDesc.Text = "0"

        End If

    End Sub

   
    Private Sub txtPorcDesc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorcDesc.EditValueChanged

        If Me.gpDescuentos.Enabled = True Then

            Me.txtValorDesc.Text = (CDbl(Me.txtSaldoCuota.Text) * CDbl(Me.txtPorcDesc.Text)) / 100

        End If

    End Sub

    Public Sub cmbEspecialidades_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEspecialidades.SelectionChangeCommitted

        Try

            'Cargamos los Items
            Me.cmbItem.DisplayMember = Nothing
            CLASE_GENERAL.cargar_combo("itemsespecialidad", Me.cmbItem, Me.cmbEspecialidades.SelectedValue)

            If Not (Me.cmbItem.Text.Length) = 0 Then

                cmbItem_SelectionChangeCommitted(sender, e)

            End If


        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub
End Class