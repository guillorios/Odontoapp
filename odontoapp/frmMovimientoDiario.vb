Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Math

Public Class frmMovimientoDiario

    'Variable de las Clases
    Private GENE As CLASE_GENERAL
    Private LIBRO As CLASE_LIBRODIARIO
    Private DETALLE_LIBRO As CLASE_DETALLE_LIBRODIARIO
    Private RCAJA As CLASE_RCAJA
    Private CEGRESO As CLASE_CEGRESO
    Private EVEN As CLASE_EVENTOS

    'Variables de fechas
    Private fecha As String
    Private control As Boolean

    'Variables de resumen
    Private Nrecibos_rc As Integer
    Private Nrecibos_ce As Integer
    Private Nrecibos_fac As Integer

    '-- Recibos de Caja
    Private NrcajaActivos As Integer
    Private NrcajaAnulados As Integer
    Private Trcajadebitos As Double
    
    '-- Comprobantes de Egreso
    Private NcegresoActivos As Integer
    Private NcegresoAnulados As Integer
    Private TcegresoCreditos As Double

    '-- Comprobantes de Facturas
    Private NfacActivos As Integer
    Private NfacAnulados As Integer
    Private TfacDebitos As Double
    
    '-- Resumen
    Private TotalDebitos As Double

    Private TCajaMenordebitos As Double

    Private TPagoEfectivodebitos As Double
    Private TPagoTarjetadebitos As Double
    Private TPagocegresocreditos As Double

    Private TMovimientoDiario As Double

    'Variables de Control
    Private contar As Integer
    Public nfila As Integer


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub frmMovimientoDiario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            control = False

            Me.txtIdlibrodiario.Text = Format(CLASE_GENERAL.maximo("Idlibrodiario", "librodiario", CLASE_GENERAL.mensaje_error) + 1, "0000#")
            Me.datefecha.Value = Date.Now

            cargarrecibos()

            Me.btnAdicionar.Enabled = True
            Me.btnAnular.Enabled = False
            Me.btnImprimir.Enabled = False

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub cargarrecibos()

        Try

            fecha = Format(Me.datefecha.Value, "yyyy-MM-dd")

            GENE = New CLASE_GENERAL

            'Cargamos recibos de caja.
            GENE.Cargar_Grilla_Opciones("recibosdecaja", Me.dgRC0, CLASE_GENERAL.mensaje_error, fecha, "0", "")
            GENE.Cargar_Grilla_Opciones("recibosdecaja", Me.dgRC1, CLASE_GENERAL.mensaje_error, fecha, "1", "")

            'Cargamos comprobantes de egreso.

            GENE.Cargar_Grilla_Opciones("comprobanteegreso", Me.dgCE0, CLASE_GENERAL.mensaje_error, fecha, "0", "")
            GENE.Cargar_Grilla_Opciones("comprobanteegreso", Me.dgCE1, CLASE_GENERAL.mensaje_error, fecha, "1", "")


            GENE = Nothing

            GRIDSTYLES()
            GRIDSTYLES2()

            GRIDSTYLES3()
            GRIDSTYLES4()

            Me.dgRC0.ClearSelection()
            Me.dgRC1.ClearSelection()

            Me.dgCE0.ClearSelection()
            Me.dgCE1.ClearSelection()

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub cargarreciboscuadrados()

        Try

            fecha = Format(Me.datefecha.Value, "yyyy-MM-dd")

            GENE = New CLASE_GENERAL

            'Cargamos recibos de caja.
            GENE.Cargar_Grilla_Opciones("recibosdecaja", Me.dgRC0, CLASE_GENERAL.mensaje_error, fecha, "0", "")
            GENE.Cargar_Grilla_Opciones("recibosdecajacuadrados", Me.dgRC1, CLASE_GENERAL.mensaje_error, Me.txtIdlibrodiario.Text, "", "")
            
            'Cargamos comprobantes de egreso.
            GENE.Cargar_Grilla_Opciones("comprobanteegreso", Me.dgCE0, CLASE_GENERAL.mensaje_error, fecha, "0", "")
            GENE.Cargar_Grilla_Opciones("comprobanteegresocuadrados", Me.dgCE1, CLASE_GENERAL.mensaje_error, Me.txtIdlibrodiario.Text, "", "")

            GENE = Nothing

            GRIDSTYLES()
            GRIDSTYLES2()

            GRIDSTYLES3()
            GRIDSTYLES4()

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle
            Style1.Format = "N0"
            Style1.Alignment = DataGridViewContentAlignment.MiddleLeft

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim Style3 As New DataGridViewCellStyle
            Style3.Format = "C0"
            Style3.Alignment = DataGridViewContentAlignment.MiddleRight

            With Me.dgRC1

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style3
                .Columns(0).HeaderText = "ESTADO"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 80

                .Columns(1).DefaultCellStyle = Style2
                .Columns(1).HeaderText = "IDRC"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 50

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "NOMBRE"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 150

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "APELLIDO"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 150

                .Columns(4).DefaultCellStyle = Style2
                .Columns(4).HeaderText = "FECHA"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 80

                .Columns(5).DefaultCellStyle = Style3
                .Columns(5).HeaderText = "TOTAL"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 80

                .Columns(6).DefaultCellStyle = Style1
                .Columns(6).HeaderText = "CONCEPTO"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 250

                .Columns(7).DefaultCellStyle = Style1
                .Columns(7).HeaderText = "CHEQUE"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).Width = 150

                .Columns(8).DefaultCellStyle = Style1
                .Columns(8).HeaderText = "BANCO"
                .Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(8).Width = 150

                .Columns(9).DefaultCellStyle = Style3
                .Columns(9).HeaderText = "EFECTIVO"
                .Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(9).Width = 80

                .Columns(10).DefaultCellStyle = Style3
                .Columns(10).HeaderText = "TARJETA"
                .Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(10).Width = 80

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

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim Style3 As New DataGridViewCellStyle
            Style3.Format = "C0"
            Style3.Alignment = DataGridViewContentAlignment.MiddleRight

            With Me.dgRC0

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).HeaderText = "OK"
                .Columns(0).Width = 50

                .Columns(1).DefaultCellStyle = Style3
                .Columns(1).HeaderText = "ESTADO"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 80

                .Columns(2).DefaultCellStyle = Style2
                .Columns(2).HeaderText = "IDRC"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 50

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "NOMBRE"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 150

                .Columns(4).DefaultCellStyle = Style1
                .Columns(4).HeaderText = "APELLIDO"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 150

                .Columns(5).DefaultCellStyle = Style2
                .Columns(5).HeaderText = "FECHA"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 80

                .Columns(6).DefaultCellStyle = Style3
                .Columns(6).HeaderText = "TOTAL"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 80

                .Columns(7).DefaultCellStyle = Style1
                .Columns(7).HeaderText = "CONCEPTO"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).Width = 250

                .Columns(8).DefaultCellStyle = Style1
                .Columns(8).HeaderText = "CHEQUE"
                .Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(8).Width = 150

                .Columns(9).DefaultCellStyle = Style1
                .Columns(9).HeaderText = "BANCO"
                .Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(9).Width = 150

                .Columns(10).DefaultCellStyle = Style3
                .Columns(10).HeaderText = "EFECTIVO"
                .Columns(10).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(10).Width = 80

                .Columns(11).DefaultCellStyle = Style3
                .Columns(11).HeaderText = "TARJETA"
                .Columns(11).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(11).Width = 80

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

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim Style3 As New DataGridViewCellStyle
            Style3.Format = "C0"
            Style3.Alignment = DataGridViewContentAlignment.MiddleRight

            With Me.dgCE0

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).HeaderText = "OK"
                .Columns(0).Width = 50

                .Columns(1).DefaultCellStyle = Style3
                .Columns(1).HeaderText = "ESTADO"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 80

                .Columns(2).DefaultCellStyle = Style2
                .Columns(2).HeaderText = "IDCE"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 50

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "PROVEEDOR"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 160

                .Columns(4).DefaultCellStyle = Style1
                .Columns(4).HeaderText = "FECHA"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 80

                .Columns(5).DefaultCellStyle = Style3
                .Columns(5).HeaderText = "TOTAL"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 80

                .Columns(6).DefaultCellStyle = Style1
                .Columns(6).HeaderText = "CONCEPTO"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 250

                .Columns(7).DefaultCellStyle = Style1
                .Columns(7).HeaderText = "CHEQUE"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).Width = 150

                .Columns(8).DefaultCellStyle = Style1
                .Columns(8).HeaderText = "BANCO"
                .Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(8).Width = 150

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

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim Style3 As New DataGridViewCellStyle
            Style3.Format = "C0"
            Style3.Alignment = DataGridViewContentAlignment.MiddleRight

            With Me.dgCE1

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style3
                .Columns(0).HeaderText = "ESTADO"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 80

                .Columns(1).DefaultCellStyle = Style2
                .Columns(1).HeaderText = "IDCE"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 50

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "PROVEEDOR"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 160

                .Columns(3).DefaultCellStyle = Style2
                .Columns(3).HeaderText = "FECHA"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 80

                .Columns(4).DefaultCellStyle = Style3
                .Columns(4).HeaderText = "TOTAL"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 80

                .Columns(5).DefaultCellStyle = Style1
                .Columns(5).HeaderText = "CONCEPTO"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 250

                .Columns(6).DefaultCellStyle = Style1
                .Columns(6).HeaderText = "CHEQUE"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 150

                .Columns(7).DefaultCellStyle = Style1
                .Columns(7).HeaderText = "BANCO"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).Width = 150

            End With

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

        'Resumen
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.RibbonBuscar_MD)
        ubicarcontrol(Me.gDatosMD)
        ubicarcontrol(Me.gpTotalesMD)
        ubicarcontrol(Me.gpPagosMD)
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnImprimir)
        ubicarcontrol(Me.btnAnular)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.btnNuevo)

        'RCaja
        ubicarcontrol(Me.lblCuadreRC)
        ubicarcontrol(Me.lblRecibosRC1)
        ubicarcontrol(Me.dgRC1)
        ubicarcontrol(Me.lblRecibosRC0)
        ubicarcontrol(Me.dgRC0)
        ubicarcontrol(Me.chkOkRC)

        'Facturas
        ubicarcontrol(Me.lblCuadreFac)
        ubicarcontrol(Me.lblRecibosFac1)
        ubicarcontrol(Me.dgFac1)
        ubicarcontrol(Me.lblRecibosFac0)
        ubicarcontrol(Me.dgFac0)

        'Cegreso
        ubicarcontrol(Me.lblCuadreCE)
        ubicarcontrol(Me.lblRecibosCE1)
        ubicarcontrol(Me.dgCE1)
        ubicarcontrol(Me.lblRecibosCE0)
        ubicarcontrol(Me.dgCE0)
        ubicarcontrol(Me.chkOkCE)


    End Sub

    Private Sub frmMovimientoDiario_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

    Private Sub operacionesmovimientodiario()

        Try

            'Contadores
            Nrecibos_rc = 0
            Nrecibos_ce = 0

            NrcajaActivos = 0
            NrcajaAnulados = 0
            Trcajadebitos = 0
          
            '-- Comprobantes de Egreso
            NcegresoActivos = 0
            NcegresoAnulados = 0
            TcegresoCreditos = 0

            '-- Comprobantes de Facturas
            NfacActivos = 0
            NfacAnulados = 0
            Tfacdebitos = 0


            '-- Resumen
            TotalDebitos = 0

            TCajaMenordebitos = 0
            TPagoEfectivodebitos = 0
            TPagoTarjetadebitos = 0

            TMovimientoDiario = 0
            TPagocegresocreditos = 0

            'Acciones con los Recibos de Caja

            If Not (Me.dgRC0.Rows.Count = 0) Then

                For Each row As DataGridViewRow In Me.dgRC0.Rows

                    If Me.dgRC0.Rows(row.Index).Cells(0).Value = True Then

                        'Contamos los recibos de Caja
                        If Me.dgRC0.Rows(row.Index).Cells("nom_estado").Value = "ANULADA" Then

                            NrcajaAnulados += 1

                        Else

                            NrcajaActivos += 1
                            Trcajadebitos += CDbl(Me.dgRC0.Rows(row.Index).Cells("total_rc").Value)

                            TPagoEfectivodebitos += CDbl(Me.dgRC0.Rows(row.Index).Cells("efectivo_rc").Value)
                            TPagoTarjetadebitos += CDbl(Me.dgRC0.Rows(row.Index).Cells("tarjeta_rc").Value)

                        End If

                        Nrecibos_rc += 1

                    End If

                Next

            End If

            'Acciones con los Comprobantes de Egreso

            If Not (Me.dgCE0.Rows.Count = 0) Then

                For Each row As DataGridViewRow In Me.dgCE0.Rows

                    If Me.dgCE0.Rows(row.Index).Cells(0).Value = True Then

                        'Contamos los recibos de Caja
                        If Me.dgCE0.Rows(row.Index).Cells("nom_estado").Value = "ANULADA" Then

                            NcegresoAnulados += 1

                        Else

                            NcegresoActivos += 1

                            Tcegresocreditos += CDbl(Me.dgCE0.Rows(row.Index).Cells("total_ce").Value)
                            TPagocegresocreditos += CDbl(Me.dgCE0.Rows(row.Index).Cells("total_ce").Value)

                        End If

                        Nrecibos_ce += 1

                    End If

                Next

            End If

            'Totalizamos

            If Me.txtTCajaMenordebitos.Text = "" Then

                Me.txtTCajaMenordebitos.Text = "0"

            End If

            TCajaMenordebitos = CDbl(Me.txtTCajaMenordebitos.Text)
            TotalDebitos = TCajaMenordebitos + TPagoEfectivodebitos + TPagoTarjetadebitos
            TMovimientoDiario = (TotalDebitos) - TPagocegresocreditos

            'Cargamos los controles

            Me.txtNrcajaActivos.Text = NrcajaActivos
            Me.txtNrcajaAnulados.Text = NrcajaAnulados

            Me.txtNcegresoActivos.Text = NcegresoActivos
            Me.txtNcegresoAnulados.Text = NcegresoAnulados

            Me.txtTrcajadebitos.Text = Trcajadebitos
            Me.txtTcegresoCreditos.Text = TcegresoCreditos
           
            Me.txtTPagoEfectivodebitos.Text = TPagoEfectivodebitos
            Me.txtTPagoTarjetadebitos.Text = TPagoTarjetadebitos

            Me.txtTotalCreditos.Text = TPagocegresocreditos

            Me.txtTMovimientoDiario.Text = TMovimientoDiario

            Me.txtTotalDebitos.Text = TotalDebitos

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub operacionesmovimientodiariocuadrado()

        Try

            'Contadores
            Nrecibos_rc = 0
            Nrecibos_ce = 0

            NrcajaActivos = 0
            NrcajaAnulados = 0
            Trcajadebitos = 0

            '-- Comprobantes de Egreso
            NcegresoActivos = 0
            NcegresoAnulados = 0
            TcegresoCreditos = 0

            '-- Comprobantes de Facturas
            NfacActivos = 0
            NfacAnulados = 0
            TfacDebitos = 0


            '-- Resumen
            TotalDebitos = 0

            TCajaMenordebitos = 0
            TPagoEfectivodebitos = 0
            TPagoTarjetadebitos = 0

            TMovimientoDiario = 0
            TPagocegresocreditos = 0

            'Acciones con los Recibos de Caja

            If Not (Me.dgRC1.Rows.Count = 0) Then

                For Each row As DataGridViewRow In Me.dgRC1.Rows

                    'Contamos los recibos de Caja
                    If Me.dgRC1.Rows(row.Index).Cells("nom_estado").Value = "ANULADA" Then

                        NrcajaAnulados += 1

                    Else

                        NrcajaActivos += 1
                        Trcajadebitos += CDbl(Me.dgRC1.Rows(row.Index).Cells("total_rc").Value)

                        TPagoEfectivodebitos += CDbl(Me.dgRC1.Rows(row.Index).Cells("efectivo_rc").Value)
                        TPagoTarjetadebitos += CDbl(Me.dgRC1.Rows(row.Index).Cells("tarjeta_rc").Value)

                    End If

                    Nrecibos_rc += 1

                Next

            End If

            'Acciones con los Comprobantes de Egreso

            If Not (Me.dgCE1.Rows.Count = 0) Then

                For Each row As DataGridViewRow In Me.dgCE1.Rows



                    'Contamos los recibos de Caja
                    If Me.dgCE1.Rows(row.Index).Cells("nom_estado").Value = "ANULADA" Then

                        NcegresoAnulados += 1

                    Else

                        NcegresoActivos += 1

                        TcegresoCreditos += CDbl(Me.dgCE1.Rows(row.Index).Cells("total_ce").Value)
                        TPagocegresocreditos += CDbl(Me.dgCE1.Rows(row.Index).Cells("total_ce").Value)

                    End If

                    Nrecibos_ce += 1

                Next

            End If

            'Totalizamos
            TCajaMenordebitos = Me.txtTCajaMenordebitos.Text
            TotalDebitos = TCajaMenordebitos + TPagoEfectivodebitos + TPagoTarjetadebitos
            TMovimientoDiario = (TotalDebitos) - TPagocegresocreditos

            'Cargamos los controles

            Me.txtNrcajaActivos.Text = NrcajaActivos
            Me.txtNrcajaAnulados.Text = NrcajaAnulados

            Me.txtNcegresoActivos.Text = NcegresoActivos
            Me.txtNcegresoAnulados.Text = NcegresoAnulados

            Me.txtTrcajadebitos.Text = Trcajadebitos
            Me.txtTcegresoCreditos.Text = TcegresoCreditos

            Me.txtTPagoEfectivodebitos.Text = TPagoEfectivodebitos
            Me.txtTPagoTarjetadebitos.Text = TPagoTarjetadebitos

            Me.txtTotalCreditos.Text = TPagocegresocreditos

            Me.txtTMovimientoDiario.Text = TMovimientoDiario

            Me.txtTotalDebitos.Text = TotalDebitos

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub


    Private Sub dgRC0_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgRC0.CellFormatting


        If dgRC0.Columns(e.ColumnIndex).Name.Equals("nom_estado") Then

            If CStr(e.Value) = "ANULADA" Then

                dgRC0.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Coral

            End If

        End If


    End Sub

    Private Sub dgRC1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgRC1.CellFormatting

        If dgRC1.Columns(e.ColumnIndex).Name.Equals("nom_estado") Then

            If CStr(e.Value) = "ANULADA" Then

                dgRC1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Coral

            End If

        End If


    End Sub

    Private Sub chkOkRC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOkRC.CheckedChanged

        If Me.chkOkRC.Checked = True Then

            For i As Integer = 0 To Me.dgRC0.Rows.Count - 1

                Me.dgRC0.Rows(i).Cells(0).Value = True

            Next

        Else

            For i As Integer = 0 To Me.dgRC0.Rows.Count - 1

                Me.dgRC0.Rows(i).Cells(0).Value = False

            Next

        End If

        operacionesmovimientodiario()

    End Sub

    Private Sub dgRC0_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRC0.CellValueChanged

        operacionesmovimientodiario()

    End Sub

    Private Sub txtSaldoInicialCMenor_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTCajaMenordebitos.KeyUp

        CLASE_EVENTOS.operaciones_mdiario()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Hacer el Movimiento  ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Movimiento Diario")

            If respuesta = MsgBoxResult.Yes Then


                If CDbl(txtTMovimientoDiario.Text) <> 0 Then

                    'Ingresamos los datos del Libro diario

                    LIBRO = New CLASE_LIBRODIARIO

                    LIBRO.p_Idlibrodiario = Me.txtIdlibrodiario.Text
                    LIBRO.p_debitos = Me.txtTotalDebitos.Text
                    LIBRO.p_creditos = Me.txtTotalCreditos.Text
                    LIBRO.p_saldocajamenor = Me.txtTCajaMenordebitos.Text
                    LIBRO.p_fecha = Format(Me.datefecha.Value, "yyyy-MM-dd")
                    LIBRO.p_Idconsultorio = 1
                    LIBRO.p_IdUsuario = My.Forms.mdiOrthoSoft.lblActivoUsuario.Tag

                    LIBRO.Insertar(CLASE_GENERAL.mensaje_error)

                    LIBRO.dispose()
                    LIBRO = Nothing


                    DETALLE_LIBRO = New CLASE_DETALLE_LIBRODIARIO

                    'Ingresamos los detalles de los Recibos de Caja
                    RCAJA = New CLASE_RCAJA

                    For Each row As DataGridViewRow In Me.dgRC0.Rows

                        DETALLE_LIBRO.p_Idlibrodiario = Me.txtIdlibrodiario.Text
                        DETALLE_LIBRO.p_Iddocumento = row.Cells.Item("Idrc").Value
                        DETALLE_LIBRO.p_concepto_doc = row.Cells.Item("concepto_rc").Value
                        DETALLE_LIBRO.p_Idbeneficiario = 1
                        DETALLE_LIBRO.p_nombeneficiario = row.Cells.Item("nombres_pac").Value & " " & row.Cells.Item("apellidos_pac").Value
                        DETALLE_LIBRO.p_Idtipodoc = 1 'Recibo de Caja
                        DETALLE_LIBRO.p_debitos = row.Cells.Item("total_rc").Value
                        DETALLE_LIBRO.p_creditos = 0

                        If row.Cells.Item("nom_estado").Value = "ANULADA" Then

                            DETALLE_LIBRO.p_Idestado = 0

                        Else

                            DETALLE_LIBRO.p_Idestado = 1

                        End If

                        DETALLE_LIBRO.Insertar(CLASE_GENERAL.mensaje_error)

                        'MODIFICAMOS EL ESTADO DE CUADRE DEL DOCUMENTO

                        RCAJA.p_Idrc = row.Cells.Item("Idrc").Value
                        RCAJA.p_Idlibrodiario = Me.txtIdlibrodiario.Text
                        RCAJA.p_estado_cuadre = 1 ' 1 Cuadrada, 0 No Cuadrada

                        RCAJA.Modificar("cuadre")

                    Next

                    RCAJA.dispose()
                    RCAJA = Nothing

                    'Ingresamos los detalles de los Comprobantes de Egreso

                    CEGRESO = New CLASE_CEGRESO

                    For Each row As DataGridViewRow In Me.dgCE0.Rows

                        DETALLE_LIBRO.p_Idlibrodiario = Me.txtIdlibrodiario.Text
                        DETALLE_LIBRO.p_Iddocumento = row.Cells.Item("Idce").Value
                        DETALLE_LIBRO.p_concepto_doc = row.Cells.Item("concepto_ce").Value
                        DETALLE_LIBRO.p_Idbeneficiario = 0
                        DETALLE_LIBRO.p_nombeneficiario = row.Cells.Item("nombre_prov").Value
                        DETALLE_LIBRO.p_Idtipodoc = 2 'Comprobante de Egreso
                        DETALLE_LIBRO.p_debitos = 0
                        DETALLE_LIBRO.p_creditos = row.Cells.Item("total_ce").Value

                        If row.Cells.Item("nom_estado").Value = "ANULADA" Then

                            DETALLE_LIBRO.p_Idestado = 0

                        Else

                            DETALLE_LIBRO.p_Idestado = 1

                        End If

                        DETALLE_LIBRO.Insertar(CLASE_GENERAL.mensaje_error)

                        'MODIFICAMOS EL ESTADO DE CUADRE DEL DOCUMENTO

                        CEGRESO.p_Idce = row.Cells.Item("Idce").Value
                        CEGRESO.p_estado_cuadre = 1 ' 1 Cuadrada, 0 No Cuadrada
                        CEGRESO.p_Idlibrodiario = Me.txtIdlibrodiario.Text

                        CEGRESO.Modificar("cuadre")

                    Next

                    CEGRESO.dispose()
                    CEGRESO = Nothing

                    DETALLE_LIBRO.dispose()
                    DETALLE_LIBRO = Nothing

                    Me.btnAdicionar.Enabled = False
                    Me.btnAnular.Enabled = True
                    Me.btnImprimir.Enabled = True

                    cargarreciboscuadrados()
                    operacionesmovimientodiariocuadrado()

                    MsgBox("Libro Diario Registrado con Exito", MsgBoxStyle.OkOnly, "Movimiento Diario")

                Else

                    MsgBox("No hay Movimientos para el cuedre verifique por favor.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Movimiento Diario")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub chkOkCE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOkCE.CheckedChanged

        If Me.chkOkCE.Checked = True Then

            For i As Integer = 0 To Me.dgCE0.Rows.Count - 1

                Me.dgCE0.Rows(i).Cells(0).Value = True

            Next

        Else

            For i As Integer = 0 To Me.dgCE0.Rows.Count - 1

                Me.dgCE0.Rows(i).Cells(0).Value = False

            Next

        End If

        operacionesmovimientodiario()

    End Sub

    Private Sub dgCE1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgCE1.CellFormatting

        If dgCE1.Columns(e.ColumnIndex).Name.Equals("nom_estado") Then

            If CStr(e.Value) = "ANULADA" Then

                dgCE1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Coral

            End If

        End If


    End Sub

    Private Sub dgCE0_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgCE0.CellFormatting

        If dgCE0.Columns(e.ColumnIndex).Name.Equals("nom_estado") Then

            If CStr(e.Value) = "ANULADA" Then

                dgCE0.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Coral

            End If

        End If

    End Sub

    Private Sub datefecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles datefecha.ValueChanged

        Try

            If Me.datefecha.Tag = 1 Then

                Me.chkOkRC.Checked = False
                Me.chkOkCE.Checked = False

                control = False

                Me.txtIdlibrodiario.Text = Format(CLASE_GENERAL.maximo("Idlibrodiario", "librodiario", CLASE_GENERAL.mensaje_error) + 1, "0000#")

                cargarrecibos()

                Me.btnAdicionar.Enabled = True
                Me.btnAnular.Enabled = False
                Me.btnImprimir.Enabled = False

                operacionesmovimientodiario()

              

            End If

            Me.datefecha.Tag = 1

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            LIBRO = New CLASE_LIBRODIARIO
            LIBRO.p_Idlibrodiario = Me.txtIdlibrodiario.Text
            LIBRO.Seleccionar("informe")

            Dim orptLibroDiario As New rptLibroDiario
            ' Dim toTexto As TextObject

            frmInformes.MdiParent = My.Forms.mdiOrthoSoft
            orptLibroDiario.SetDataSource(CLASE_GENERAL.xdt)
            My.Forms.frmInformes.crvOrthosoft.ReportSource = orptLibroDiario

            'Definimos los textos del Informe
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTRCaja").Text = "'" & Me.txtTrcajadebitos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTFacturas").Text = "'" & Me.txtTfacturasdebito.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTCegreso").Text = "'" & Me.txtTcegresoCreditos.Text & "'"

            orptLibroDiario.DataDefinition.FormulaFields.Item("campoNRcajaActivos").Text = "'" & Me.txtNrcajaActivos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoNRcajaAnulados").Text = "'" & Me.txtNrcajaAnulados.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoNFacturasActivos").Text = "'" & Me.txtNfacturasActivos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoNFacturasAnulados").Text = "'" & Me.txtNfacturasAnulados.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoNCegresoActivos").Text = "'" & Me.txtNcegresoActivos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoNCegresoAnulados").Text = "'" & Me.txtNcegresoAnulados.Text & "'"

            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTCajaMenordebitos").Text = "'" & Me.txtTCajaMenordebitos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTPagoEfectivodebitos").Text = "'" & Me.txtTPagoEfectivodebitos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTPagoTarjetadebitos").Text = "'" & Me.txtTPagoTarjetadebitos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTotalDebitos").Text = "'" & Me.txtTotalDebitos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTotalCreditos").Text = "'" & Me.txtTotalCreditos.Text & "'"
            orptLibroDiario.DataDefinition.FormulaFields.Item("campoTMovimientoDiario").Text = "'" & Me.txtTMovimientoDiario.Text & "'"


            ' ----------------   Exportamos el documento a pdf

            Dim CrExportOptions As ExportOptions
            Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
            Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

            CrDiskFileDestinationOptions.DiskFileName = "c:\Odpp\DocumentoImportante.pdf"
            CrExportOptions = orptLibroDiario.ExportOptions

            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With

            orptLibroDiario.Export()

            My.Forms.frmInformes.lblTituloEmail.Text = "Libro Diario"
            My.Forms.frmInformes.lblMensajeEmail.Text = "Adjuntamos Documento en formato PDF del Libro Diario"

            '-------- Termina Exportacion PDF

            My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
            My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
            My.Forms.frmInformes.crvOrthosoft.Zoom(70)

            'Me.rtxtTotalLetras.Text = NroEnLetras(CDbl(Me.txtGRANTOTAL.Text), False) & " PESOS M/CTE"

            ''Display the new form.
            My.Forms.frmInformes.Show()
            My.Forms.frmInformes.Activate()

            CLASE_GENERAL.xdt.Dispose()
            CLASE_GENERAL.xdt = Nothing

            LIBRO.dispose()
            LIBRO = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnLibroBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLibroBuscar.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdLibro_Bus.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdLibro_Bus, "Escriba el No. del Movimiento a Buscar Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdLibro_Bus), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "LibroDiario")
                Me.txtIdLibro_Bus.Focus()


            Else

                contar = CLASE_GENERAL.contar2("Idlibrodiario", "librodiario", Me.txtIdLibro_Bus.Text, CLASE_GENERAL.mensaje_error)

                If contar = 0 Then

                    Me.txtIdLibro_Bus.Text = ""
                    ErrorProvider.SetError(Me.txtIdLibro_Bus, "El Movimiento no Existe, Digite el Numero nuevamente por favor.")
                    MsgBox(ErrorProvider.GetError(Me.txtIdLibro_Bus), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Libro Diario")
                    Me.txtIdLibro_Bus.Focus()

                Else

                    'Limpiamos la ficha

                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiarlibro")
                    EVEN = Nothing

                    'Buscamos algunos datos del Libro Diario
                    LIBRO = New CLASE_LIBRODIARIO
                    LIBRO.p_Idlibrodiario = Me.txtIdLibro_Bus.Text
                    LIBRO.Seleccionar("registro")

                    Me.txtIdlibrodiario.Text = Format(CLASE_LIBRODIARIO.xIdlibrodiario, "0000#")

                    'Nos permite controlar que el control de fecha no cargue los datos 
                    Me.datefecha.Tag = 0

                    Me.datefecha.Value = CLASE_LIBRODIARIO.xfecha
                    Me.txtTCajaMenordebitos.Text = CLASE_LIBRODIARIO.xsaldocajamenor
                    Me.txtTCajaMenordebitos.Properties.ReadOnly = True

                    ' Cargamos los recibos Cuadrados del dia como los que quedaron sin cuadrar

                    cargarreciboscuadrados()
                    operacionesmovimientodiariocuadrado()

                    'Verificamos el estado de los botones para evitar registros duplicados
                    Me.btnAdicionar.Enabled = False
                    Me.btnAnular.Enabled = True
                    Me.btnImprimir.Enabled = True

                    'Volvemos Activar el control de fecha para evaluar las funciones de este dia al cambiar de fecha
                    Me.datefecha.Tag = 1

                    LIBRO.dispose()
                    LIBRO = Nothing

                End If


            End If


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub txtIdLibro_Bus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdLibro_Bus.TextChanged

        Me.ErrorProvider.SetError(Me.txtIdLibro_Bus, "")

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click


        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea un Nuevo Movimiento ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Movimiento Diario")

            If respuesta = MsgBoxResult.Yes Then


                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarlibro")
                EVEN = Nothing

                Me.txtIdlibrodiario.Text = Format(CLASE_GENERAL.maximo("Idlibrodiario", "librodiario", CLASE_GENERAL.mensaje_error) + 1, "0000#")
                Me.datefecha.Value = Date.Now

                cargarrecibos()

                Me.btnAdicionar.Enabled = True
                Me.btnAnular.Enabled = False
                Me.btnImprimir.Enabled = False

                Me.txtTCajaMenordebitos.Properties.ReadOnly = False

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

End Class