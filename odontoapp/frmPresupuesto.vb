Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Net.Mail
Imports System.Math


Public Class frmPresupuesto

    'Variables de Clases
    Private EVEN As CLASE_EVENTOS
    Private CUOTA As CLASE_CUOTAS
    Private GENE As CLASE_GENERAL
    Private PRESUPUESTO As CLASE_PRESUPUESTO
    Private PROCEDIMIENTOS As CLASE_PROCEDIMIENTOS
    Private PAC As CLASE_PACIENTES

    'Varibles de control
    Private fecha As Date
    Private fechaaux As Date
    Private contar As Integer
    Private contar2 As Integer

    Private Sub btnPacSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProviderpac.BlinkRate = 200
            Me.ErrorProviderpac.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtVTotal_cuota.Text.Length = 0 Or CInt(Me.txtVTotal_cuota.Text) = 0 Then
                ErrorProviderpac.SetError(Me.txtVTotal_cuota, "Verifique el Valor Inicial del presupuesto")
                MsgBox(ErrorProviderpac.GetError(Me.txtVTotal_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.txtVTotal_cuota.Focus()

            ElseIf cmbItem.Text.Length = 0 Or Me.cmbItem.Text = "" Then
                ErrorProviderpac.SetError(Me.cmbItem, "Verifique el item del procedimiento")
                MsgBox(ErrorProviderpac.GetError(Me.cmbItem), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.cmbItem.Focus()

            ElseIf txtNCuotasIni_cuota.Text.Length = 0 Or CInt(Me.txtNCuotasIni_cuota.Text) = 0 Then
                ErrorProviderpac.SetError(Me.txtNCuotasIni_cuota, "Verifique las cuotas Iniciales")
                MsgBox(ErrorProviderpac.GetError(Me.txtNCuotasIni_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.txtNCuotasIni_cuota.Focus()

            ElseIf txtVCuotasIni_cuota.Text.Length = 0 Or CInt(Me.txtVCuotasIni_cuota.Text) = 0 Then
                ErrorProviderpac.SetError(Me.txtVCuotasIni_cuota, "Verifique el Valor de las cuotas Iniciales")
                MsgBox(ErrorProviderpac.GetError(Me.txtVCuotasIni_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.txtVCuotasIni_cuota.Focus()

            ElseIf txtNCuotas_cuota.Text.Length = 0 Then
                ErrorProviderpac.SetError(Me.txtNCuotas_cuota, "Verifique las cuotas Mensuales")
                MsgBox(ErrorProviderpac.GetError(Me.txtNCuotas_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.txtNCuotas_cuota.Focus()

            ElseIf txtVCuotas_cuota.Text.Length = 0 Then
                ErrorProviderpac.SetError(Me.txtVCuotas_cuota, "Verifique el Valor de las cuotas Mensuales")
                MsgBox(ErrorProviderpac.GetError(Me.txtVCuotas_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.txtVCuotas_cuota.Focus()

            Else

                '**************************** MODULO PARA INGRESO DEL PACIENTE *******************************

                'Asignamos los valores a las variables de la clase Cuotas

                CUOTA = New CLASE_CUOTAS
                CUOTA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                fecha = Me.cmbfec_cuota.Value
                fechaaux = Me.cmbfec_cuota.Value

                'Las cuotas iniciales
                For n As Integer = 1 To Me.txtNCuotasIni_cuota.Text

                    If Me.cmbIntervaloCuotas.SelectedIndex = 0 Then

                        fechaaux = Format((DateAdd(DateInterval.Day, (n - 1) * 15, fecha)), "yyyy-MM-dd")

                    ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 1 Then

                        fechaaux = Format((DateAdd(DateInterval.Day, (n - 1) * 20, fecha)), "yyyy-MM-dd")

                    ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 2 Then

                        fechaaux = Format((DateAdd(DateInterval.Month, (n - 1), fecha)), "yyyy-MM-dd")

                    End If

                    CUOTA.p_Idcuota = (CLASE_GENERAL.maximo("Idcuota", "cuotas", CLASE_GENERAL.mensaje_error)) + 1
                    CUOTA.p_valor_cuota = Me.txtVCuotasIni_cuota.Text
                    CUOTA.p_saldo_cuota = Me.txtVCuotasIni_cuota.Text
                    CUOTA.p_tipo_cuota = 1 'Cuota de presupuesto
                    CUOTA.p_Idpresupuesto = Me.txtIdPres.Text
                    CUOTA.p_Idprocedimiento = Me.cmbItem.SelectedValue

                    'Verificamos si el dia que corresponde al pago no sea un domingo caso contrario se corre hasta el lunes
                    If DatePart(DateInterval.Weekday, fechaaux) = 1 Then
                        CUOTA.p_fecha_cuota = Format(DateAdd(DateInterval.Day, 1, fechaaux), "yyyy-MM-dd")
                    Else
                        CUOTA.p_fecha_cuota = Format(fechaaux, "yyyy-MM-dd")
                    End If

                    If (CInt(Me.txtNCuotas_cuota.Text) = 0) And (CInt(Me.txtNCuotasIni_cuota.Text) > 1) Then

                        CUOTA.p_procedimiento_cuota = n & "a. " & "CUOTA" & " - " & Me.cmbItem.Text

                    ElseIf (CInt(Me.txtNCuotas_cuota.Text) = 0) And (CInt(Me.txtNCuotasIni_cuota.Text) = 1) Then

                        CUOTA.p_procedimiento_cuota = "CUOTA" & "-" & Me.cmbItem.Text

                    Else

                        CUOTA.p_procedimiento_cuota = n & "a. " & "CUOTA INICIAL" & " - " & Me.cmbItem.Text

                    End If

                    CUOTA.Insertar(CLASE_GENERAL.mensaje_error)

                Next

                'Las cuotas mensuales

                If Not (CInt(Me.txtNCuotas_cuota.Text) = 0 Or CInt(Me.txtVCuotas_cuota.Text) = 0 Or CInt(Me.txtTCuotas_cuota.Text)) Then

                    fecha = fechaaux

                    For n As Integer = 1 To Me.txtNCuotas_cuota.Text

                        If Me.cmbIntervaloCuotas.SelectedIndex = 0 Then

                            fechaaux = Format((DateAdd(DateInterval.Day, n * 15, fecha)), "yyyy-MM-dd")

                        ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 1 Then

                            fechaaux = Format((DateAdd(DateInterval.Day, n * 20, fecha)), "yyyy-MM-dd")

                        ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 2 Then

                            fechaaux = Format((DateAdd(DateInterval.Month, n, fecha)), "yyyy-MM-dd")

                        End If

                        CUOTA.p_Idcuota = (CLASE_GENERAL.maximo("Idcuota", "cuotas", CLASE_GENERAL.mensaje_error)) + 1
                        CUOTA.p_valor_cuota = Me.txtVCuotas_cuota.Text
                        CUOTA.p_saldo_cuota = Me.txtVCuotas_cuota.Text
                        CUOTA.p_tipo_cuota = 1 'Cuota de Presupuesto
                        CUOTA.p_Idpresupuesto = Me.txtIdPres.Text
                        CUOTA.p_Idprocedimiento = Me.cmbItem.SelectedValue

                        'Verificamos si el dia que corresponde al pago no sea un domingo caso contrario se corre hasta el lunes
                        If DatePart(DateInterval.Weekday, fechaaux) = 1 Then
                            CUOTA.p_fecha_cuota = Format(DateAdd(DateInterval.Day, 1, fechaaux), "yyyy-MM-dd")
                        Else
                            CUOTA.p_fecha_cuota = Format(fechaaux, "yyyy-MM-dd")
                        End If

                        CUOTA.p_procedimiento_cuota = n & "a. " & "CUOTA MENSUAL" & " - " & Me.cmbItem.Text
                        CUOTA.Insertar(CLASE_GENERAL.mensaje_error)

                    Next

                End If

                CUOTA.dispose()
                CUOTA = Nothing

                'Cargamos la grilla con los pagos

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla_Opciones("cuotas", Me.dgCuotas, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, Me.txtIdPres.Text, "", "")
                GRIDSTYLES()

                Me.dgCuotas.ClearSelection()

                GENE = Nothing

                'Sumamos las Columnas que necesitamos

                Me.txtVTotalPresupuesto.Text = CLASE_GENERAL.SumarColumna("valor_cuota", Me.dgCuotas)

                'Creamos el presupuesto en la Base de datos

                PRESUPUESTO = New CLASE_PRESUPUESTO

                PRESUPUESTO.p_Idpresupuesto = Me.txtIdPres.Text
                PRESUPUESTO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                PRESUPUESTO.p_nom_pres = Me.cmbItem.Text
                PRESUPUESTO.p_fecha_pres = Format(Me.cmbfec_cuota.Value, "yyyy-MM-dd")
                PRESUPUESTO.p_intervalo_pres = Me.cmbIntervaloCuotas.SelectedIndex
                PRESUPUESTO.p_VTotal_pres = Me.txtVTotal_cuota.Text
                PRESUPUESTO.p_NCuotasIni_pres = Me.txtNCuotasIni_cuota.Text()
                PRESUPUESTO.p_VCuotasIni_pres = Me.txtVCuotasIni_cuota.Text
                PRESUPUESTO.p_TCuotasIni_pres = Me.txtTCuotasIni_cuota.Text
                PRESUPUESTO.p_NCuotas_pres = Me.txtNCuotas_cuota.Text
                PRESUPUESTO.p_VCuotas_pres = Me.txtVCuotas_cuota.Text
                PRESUPUESTO.p_TCuotas_pres = Me.txtTCuotas_cuota.Text
                PRESUPUESTO.p_VTotalPresupuesto = Me.txtVTotalPresupuesto.Text
                PRESUPUESTO.p_Iddoctor = Me.cmbDoctores.SelectedValue
                PRESUPUESTO.p_Idespecialidad = Me.cmbEspecialidades.SelectedValue
                PRESUPUESTO.p_Idestado = 1

                ' Estado
                ' 1. NUEVA
                ' 2. CON SALDOS O PAGOS
                ' 3. CANCELADA

                PRESUPUESTO.Insertar(CLASE_GENERAL.mensaje_error)

                PRESUPUESTO.dispose()
                PRESUPUESTO = Nothing

                Me.btnAdicionar.Enabled = False
                Me.btnImprimir.Enabled = True
                Me.btnOtrosConceptos.Enabled = True

                MsgBox("Presupuesto Guardado con Exito", MsgBoxStyle.OkOnly, "Presupuesto")

            End If


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

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

            With Me.dgCuotas

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"

                .Columns(1).DefaultCellStyle = Style2
                .Columns(1).HeaderText = "CONCEPTO"

                .Columns(2).DefaultCellStyle = Style3
                .Columns(2).HeaderText = "VALOR"

                .Columns(3).DefaultCellStyle = Style3
                .Columns(3).HeaderText = "ABONO"

                .Columns(4).DefaultCellStyle = Style3
                .Columns(4).HeaderText = "SALDO"

                .Columns(5).DefaultCellStyle = Style2
                .Columns(5).HeaderText = "FECHA"


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

            With Me.dgPresupuestos

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID PRES"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 50
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "NOMBRE PRESUPUESTO"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 150
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "ESPECIALIDAD"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 150
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(3).DefaultCellStyle = Style2
                .Columns(3).HeaderText = "FECHA"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 70
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(4).DefaultCellStyle = Style3
                .Columns(4).HeaderText = "VALOR"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 70
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(5).DefaultCellStyle = Style1
                .Columns(5).HeaderText = "ESTADO"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 70
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

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

            With Me.dgCuotasPresupuestos

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID PRES"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 50
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(1).DefaultCellStyle = Style2
                .Columns(1).HeaderText = "ID CUOTA"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 50
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(2).DefaultCellStyle = Style2
                .Columns(2).HeaderText = "FECHA"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 70
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "PROCEDIMIENTO"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 150
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(4).DefaultCellStyle = Style3
                .Columns(4).HeaderText = "VALOR"
                .Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(4).Width = 70
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(5).DefaultCellStyle = Style2
                .Columns(5).HeaderText = "ABONO"
                .Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(5).Width = 70
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(6).DefaultCellStyle = Style3
                .Columns(6).HeaderText = "SALDO"
                .Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(6).Width = 70
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(7).DefaultCellStyle = Style2
                .Columns(7).HeaderText = "% DES"
                .Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(7).Width = 70
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(8).DefaultCellStyle = Style3
                .Columns(8).HeaderText = "V.DES"
                .Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(8).Width = 70
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .MultiSelect = False


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub frmPresupuesto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'Cargamos el Id de presupuesto
            Me.txtIdPres.Text = (CLASE_GENERAL.maximo("Idpresupuesto", "presupuesto", CLASE_GENERAL.mensaje_error)) + 1

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

            'Cargamos por defecto 
            Me.cmbIntervaloCuotas.SelectedIndex = 2
            Me.cmbfecha_ad.Value = Date.Now
            Me.cmbfec_cuota.Value = Date.Now

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub txtVCuotasIni_cuota_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVCuotasIni_cuota.KeyUp
        CLASE_EVENTOS.operaciones()
    End Sub

    Private Sub txtNCuotas_cuota_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNCuotas_cuota.KeyUp
        CLASE_EVENTOS.operaciones()
    End Sub

    Private Sub txtNCuotasIni_cuota_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNCuotasIni_cuota.KeyUp
        CLASE_EVENTOS.operaciones()
    End Sub

    Private Sub txtNCuotasIni_cuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNCuotasIni_cuota.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtNCuotasIni_cuota, "")
    End Sub

    Private Sub txtVCuotasIni_cuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVCuotasIni_cuota.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtVCuotasIni_cuota, "")
    End Sub

    Private Sub txtNCuotas_cuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNCuotas_cuota.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtNCuotas_cuota, "")
    End Sub

    Private Sub txtVCuotas_cuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVCuotas_cuota.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtVCuotas_cuota, "")
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Documento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Documentos")

            If respuesta = 6 Then

                CUOTA = New CLASE_CUOTAS

                CUOTA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                CUOTA.p_tipo_cuota = 1
                CUOTA.p_Idpresupuesto = Me.txtIdPres.Text
                CUOTA.Seleccionar("tabla")

                Dim orptPresupuesto As New rptPresupuesto

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptPresupuesto.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptPresupuesto

                'Definimos El Titulo de la Clinica por Defecto
                'orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoNomPaciente").Text = "'" & Me.txtnombre_pac.Text & "'"
                'orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoNumDoc").Text = "'" & Me.txtnumdoc_pac.Text & "'"

                'Definimos los textos de los campo en el informe
                Dim toTexto As TextObject

                'Definimos El Titulo de la Clinica por Defecto
                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtEmpresa")
                toTexto.Text = CLASE_GENERAL._razonsocial_cons

                'Definimos los otros items del Informe
                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtPaciente")
                toTexto.Text = My.Forms.mdiOrthoSoft.lblActivoPaciente.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtCelular_pac")
                toTexto.Text = My.Forms.mdiOrthoSoft.txtCelular_ficha.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtTelcasa_pac")
                toTexto.Text = My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text

                'Datos del Presupuesto

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtVTotalPresupuesto")
                toTexto.Text = Me.txtVTotalPresupuesto.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtNCuotasIni_cuota")
                toTexto.Text = Me.txtNCuotasIni_cuota.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtNCuotas_cuota")
                toTexto.Text = Me.txtNCuotas_cuota.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtVCuotasIni_cuota")
                toTexto.Text = Me.txtVCuotasIni_cuota.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtVCuotas_cuota")
                toTexto.Text = Me.txtVCuotas_cuota.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtTCuotasIni_cuota")
                toTexto.Text = Me.txtTCuotasIni_cuota.Text

                toTexto = orptPresupuesto.ReportDefinition.ReportObjects.Item("txtTCuotas_cuota")
                toTexto.Text = Me.txtTCuotas_cuota.Text

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                '-------------- Exportamos el documento a pdf

                Dim CrExportOptions As ExportOptions
                Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

                CrDiskFileDestinationOptions.DiskFileName = "c:\Odpp\DocumentoImportante.pdf"
                CrExportOptions = orptPresupuesto.ExportOptions

                With CrExportOptions
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    .DestinationOptions = CrDiskFileDestinationOptions
                    .FormatOptions = CrFormatTypeOptions
                End With

                My.Forms.frmInformes.lblTituloEmail.Text = "Presupuesto Paciente"
                My.Forms.frmInformes.lblMensajeEmail.Text = "Adjuntamos Documento en formato PDF del Presuuesto Tratamiento. "

                orptPresupuesto.Export()

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                EVEN = New CLASE_EVENTOS
                My.Forms.frmInformes.txtcorreos.Text = EVEN.buscarcorreos(My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
                EVEN = Nothing

                CUOTA.dispose()
                CUOTA = Nothing

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

        'Presupuesto Ortodoncia

        ubicarcontrol(Me.lblPresupuesto)
        ubicarcontrol(Me.gpCInicial_pre)
        ubicarcontrol(Me.dgCuotas)
        ubicarcontrol(Me.lblIntervalocuotas)
        ubicarcontrol(Me.cmbIntervaloCuotas)
        ubicarcontrol(Me.lblVTotalPresupuesto)
        ubicarcontrol(Me.txtVTotalPresupuesto)
        ubicarcontrol(Me.GroupOtrosConcep_cuota)
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnImprimir)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.lblDoctores)
        ubicarcontrol(Me.cmbDoctores)
        ubicarcontrol(Me.gpEspecialidades)
        ubicarcontrol(Me.txtIdPres)
        ubicarcontrol(Me.lblIdPres)

        'Tablas Presupuestos

        ubicarcontrol(Me.lblPresupuestoPaciente)
        ubicarcontrol(Me.dgPresupuestos)
        ubicarcontrol(Me.lblCuotas)
        ubicarcontrol(Me.dgCuotasPresupuestos)

        'Cotizaciones

        ubicarcontrol(Me.lblCotizaciones)
        ubicarcontrol(Me.gpItems_cuentas)
        ubicarcontrol(Me.dgCotizaciones)

    End Sub

    Private Sub frmPresupuesto_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ubicarcontroles()
    End Sub

    Private Sub txtVTotal_cuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVTotal_cuota.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtVTotal_cuota, "")
    End Sub

    Private Sub txtVTotal_cuota_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVTotal_cuota.KeyUp
        CLASE_EVENTOS.operaciones()
    End Sub

    Private Sub btnOtrosConceptos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtrosConceptos.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProviderpac.BlinkRate = 200
            Me.ErrorProviderpac.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.cmbItem.Text.Length = 0 Then
                ErrorProviderpac.SetError(Me.cmbItem, "Verifique el Concepto Adicional")
                MsgBox(ErrorProviderpac.GetError(Me.cmbItem), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.cmbItem.Focus()

            ElseIf txtVTotal_cuota.Text.Length = 0 Or CInt(Me.txtVTotal_cuota.Text) = 0 Then
                ErrorProviderpac.SetError(Me.txtVTotal_cuota, "Verifique El Valor del Concepto Adicional")
                MsgBox(ErrorProviderpac.GetError(Me.txtVTotal_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
                Me.txtVTotal_cuota.Focus()

            Else

                ' ***** CARGAMOS EL ITEM EN LAS CUOTAS *********
                CUOTA = New CLASE_CUOTAS
                CUOTA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                contar = 0
                contar = CLASE_GENERAL.contar2("Idpaciente", "cuotas", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                'VERIFICAMOS SI TIENE YA CUOTAS SI ES CIERTO MIRAMOS LA ULTIMA FECHA Y A PARTIR DE ELLA GENERAMOS EL PRESUPUESTO Y LA SIGUIENTE CUOTA

                If contar > 0 Then

                    'Seleccionamos la ultima fecha del presupuesto para aumentarle un mes
                    CUOTA.Seleccionar("ultimafecha")

                    fecha = CDate(CLASE_CUOTAS.xfecha_cuota)
                    fechaaux = CDate(CLASE_CUOTAS.xfecha_cuota)

                    If Me.cmbIntervaloCuotas.SelectedIndex = 0 Then

                        fechaaux = Format((DateAdd(DateInterval.Day, 15, fecha)), "yyyy-MM-dd")

                    ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 1 Then

                        fechaaux = Format((DateAdd(DateInterval.Day, 20, fecha)), "yyyy-MM-dd")

                    ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 2 Then

                        fechaaux = Format((DateAdd(DateInterval.Month, 1, fecha)), "yyyy-MM-dd")

                    End If

                    'Verificamos si el dia que corresponde al pago no sea un domingo caso contrario se corre hasta el lunes
                    If DatePart(DateInterval.Weekday, fechaaux) = 1 Then
                        CUOTA.p_fecha_cuota = Format(DateAdd(DateInterval.Day, 1, fechaaux), "yyyy-MM-dd")
                    Else
                        CUOTA.p_fecha_cuota = Format(fechaaux, "yyyy-MM-dd")
                    End If

                Else

                    CUOTA.p_fecha_cuota = Format(Me.cmbfec_cuota.Value, "yyyy-MM-dd")

                End If

                'Verificamos las variables para ingresar en la base de datos
                CUOTA.p_Idcuota = (CLASE_GENERAL.maximo("Idcuota", "cuotas", CLASE_GENERAL.mensaje_error)) + 1
                CUOTA.p_valor_cuota = Me.txtVTotal_cuota.Text
                CUOTA.p_saldo_cuota = Me.txtVTotal_cuota.Text
                CUOTA.p_Idprocedimiento = Me.cmbItem.SelectedValue
                CUOTA.p_procedimiento_cuota = Me.cmbItem.Text
                CUOTA.p_tipo_cuota = 1
                CUOTA.p_Idpresupuesto = Me.txtIdPres.Text

                CUOTA.Insertar(CLASE_GENERAL.mensaje_error)

                CUOTA.dispose()
                CUOTA = Nothing

                'Cargamos la grilla con los pagos
                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla_Opciones("cuotas", Me.dgCuotas, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, Me.txtIdPres.Text, "", "")
                GRIDSTYLES()

                Me.dgCuotas.ClearSelection()

                GENE = Nothing

                'Sumamos las Columnas que necesitamos
                Me.txtVTotalPresupuesto.Text = CLASE_GENERAL.SumarColumna("valor_cuota", Me.dgCuotas)

                '****** INGRESAMOS Y ACTUALIZAMOS EL VALOR TOTAL DEL PRESUPUESTO

                PRESUPUESTO = New CLASE_PRESUPUESTO
                PRESUPUESTO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                PRESUPUESTO.p_Idpresupuesto = Me.txtIdPres.Text
                PRESUPUESTO.p_VTotalPresupuesto = Me.txtVTotalPresupuesto.Text

                PRESUPUESTO.Modificar("valorpresupuesto")

                PRESUPUESTO.dispose()
                PRESUPUESTO = Nothing

                MsgBox("Item ingresado con con exito.", MsgBoxStyle.OkOnly, "Presupuesto")

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub cmbItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItem.Click

        Me.cmbItem.Text = ""
        Me.txtVTotal_cuota.Text = ""

    End Sub

    Private Sub cmbItem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbItem.KeyPress

        e.KeyChar = e.KeyChar.ToString.ToUpper()

    End Sub

    Private Sub cmbItem_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbItem.KeyUp

        If e.KeyCode = Keys.Enter Then

            e.Handled = True

            Try

                PROCEDIMIENTOS = New CLASE_PROCEDIMIENTOS
                PROCEDIMIENTOS.p_Idprocedimiento = Me.cmbItem.SelectedValue
                PROCEDIMIENTOS.Seleccionar("registro")

                Me.txtIdprocedimiento1.Text = CLASE_PROCEDIMIENTOS.xIdprocedimiento
                Me.txtVTotal_cuota.Text = CLASE_PROCEDIMIENTOS.xvalor_proc

                PROCEDIMIENTOS.dispose()
                PROCEDIMIENTOS = Nothing


            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Presupuesto") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try


        End If

    End Sub

    Private Sub cmbItem_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbItem.SelectionChangeCommitted

        Try

            PROCEDIMIENTOS = New CLASE_PROCEDIMIENTOS
            PROCEDIMIENTOS.p_Idprocedimiento = Me.cmbItem.SelectedValue
            PROCEDIMIENTOS.Seleccionar("registro")

            Me.txtIdprocedimiento1.Text = CLASE_PROCEDIMIENTOS.xIdprocedimiento
            Me.txtVTotal_cuota.Text = CLASE_PROCEDIMIENTOS.xvalor_proc

            PROCEDIMIENTOS.dispose()
            PROCEDIMIENTOS = Nothing

            CLASE_EVENTOS.operaciones()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Presupuesto") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub


    Private Sub TabPresupuesto_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabPresupuesto.SelectedTabChanged

        Try

            If TabPresupuesto.SelectedTab.Text = "Presupuestos" Then

                'Controlamos que exista un registro 
                'si no existe creamos un nuevo registro al insertarlo en la base de datos

                contar = 0
                contar = CLASE_GENERAL.contar2("Idpaciente", "presupuesto", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla_mestrodetalle("presupuestos", Me.dgPresupuestos, Me.dgCuotasPresupuestos, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, 1)
                    GENE = Nothing

                    GRIDSTYLES2()
                    GRIDSTYLES3()

                    Me.dgPresupuestos.ClearSelection()
                    Me.btnModificar.Enabled = False
                    Me.btnEliminar.Enabled = False

                    If Me.dgPresupuestos.Rows.Count = 0 Then

                        Me.btnModificar.Enabled = False
                        Me.btnEliminar.Enabled = False

                    End If


                Else

                    MsgBox("No se han creado Presupuestos de este paciente.", MsgBoxStyle.OkOnly, "Presupuestos")

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea crear un nuevo Presupuesto", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Presupuesto")

            If respuesta = MsgBoxResult.Yes Then

                'Limpiamos el presupuesto

                EVEN = New CLASE_EVENTOS
                EVEN.limpiar("limpiarpresupuesto")
                EVEN = Nothing

                'Cargamos el Id de presupuesto
                Me.txtIdPres.Text = (CLASE_GENERAL.maximo("Idpresupuesto", "presupuesto", CLASE_GENERAL.mensaje_error)) + 1

                'Cargamos la fecha del programa

                Me.cmbfec_cuota.Value = Date.Now

                Me.btnAdicionar.Enabled = True
                Me.btnImprimir.Enabled = False
                Me.btnOtrosConceptos.Enabled = False

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try

            PRESUPUESTO = New CLASE_PRESUPUESTO
            PRESUPUESTO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
            PRESUPUESTO.p_Idpresupuesto = Me.dgPresupuestos.CurrentRow.Cells("PRESUPUESTO").Value
            PRESUPUESTO.Seleccionar("registro")

            Me.cmbfec_cuota.Value = CLASE_PRESUPUESTO.xfecha_pres
            Me.cmbIntervaloCuotas.SelectedIndex = CLASE_PRESUPUESTO.xintervalo_pres
            Me.txtVTotal_cuota.Text = CLASE_PRESUPUESTO.xVTotal_pres
            Me.txtNCuotasIni_cuota.Text = CLASE_PRESUPUESTO.xNCuotasIni_pres
            Me.txtVCuotasIni_cuota.Text = CLASE_PRESUPUESTO.xVCuotasIni_pres
            Me.txtTCuotasIni_cuota.Text = CLASE_PRESUPUESTO.xTCuotasIni_pres
            Me.txtNCuotas_cuota.Text = CLASE_PRESUPUESTO.xNCuotas_pres
            Me.txtVCuotas_cuota.Text = CLASE_PRESUPUESTO.xVCuotas_pres
            Me.txtTCuotas_cuota.Text = CLASE_PRESUPUESTO.xTCuotas_pres
            Me.txtVTotalPresupuesto.Text = CLASE_PRESUPUESTO.xVTotalPresupuesto
            Me.txtIdPres.Text = CLASE_PRESUPUESTO.xIdpresupuesto

            PRESUPUESTO.dispose()
            PRESUPUESTO = Nothing

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla_Opciones("cuotas", Me.dgCuotas, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, Me.txtIdPres.Text, "", "")
            GRIDSTYLES()

            Me.dgCuotas.ClearSelection()

            GENE = Nothing

            Me.btnAdicionar.Enabled = False
            Me.btnImprimir.Enabled = True
            Me.btnOtrosConceptos.Enabled = True

            Me.TabPresupuesto.SelectedTabIndex = 0

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub dgPresupuestos_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPresupuestos.CellEnter

        Me.btnModificar.Enabled = True
        Me.btnEliminar.Enabled = True

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

    Private Sub cmbItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbItem.TextChanged
        Me.ErrorProviderpac.SetError(Me.cmbItem, "")
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Borrar el Presupuesto", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Presupuesto")

            If respuesta = MsgBoxResult.Yes Then

                contar = 0
                contar2 = 0
                contar = CLASE_GENERAL.contarpresupuestos(Me.dgPresupuestos.CurrentRow.Cells("PRESUPUESTO").Value, "2", CLASE_GENERAL.mensaje_error)
                contar2 = CLASE_GENERAL.contarpresupuestos(Me.dgPresupuestos.CurrentRow.Cells("PRESUPUESTO").Value, "3", CLASE_GENERAL.mensaje_error)

                If contar = 0 And contar2 = 0 Then

                    PRESUPUESTO = New CLASE_PRESUPUESTO
                    CUOTA = New CLASE_CUOTAS

                    PRESUPUESTO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    PRESUPUESTO.p_Idpresupuesto = Me.dgPresupuestos.CurrentRow.Cells("PRESUPUESTO").Value

                    CUOTA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    CUOTA.p_Idpresupuesto = Me.dgPresupuestos.CurrentRow.Cells("PRESUPUESTO").Value


                    PRESUPUESTO.Eliminar(CLASE_GENERAL.mensaje_error)
                    CUOTA.Eliminar("porpresupuesto")

                    PRESUPUESTO.dispose()
                    PRESUPUESTO = Nothing

                    CUOTA.dispose()
                    CUOTA = Nothing

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla_mestrodetalle("presupuestos", Me.dgPresupuestos, Me.dgCuotasPresupuestos, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, 1)
                    GENE = Nothing

                    GRIDSTYLES2()
                    GRIDSTYLES3()

                    If Me.dgPresupuestos.Rows.Count = 0 Then

                        Me.btnModificar.Enabled = False
                        Me.btnEliminar.Enabled = False

                    End If

                    GENE = Nothing

                    EVEN = New CLASE_EVENTOS
                    EVEN.limpiar("limpiarpresupuesto")
                    EVEN = Nothing

                    Me.btnAdicionar.Enabled = True
                    Me.btnImprimir.Enabled = False
                    Me.btnOtrosConceptos.Enabled = False

                    Me.cmbIntervaloCuotas.SelectedIndex = 2

                    MsgBox("Presupuesto Eliminado con exito.", MsgBoxStyle.OkOnly, "Presupuesto")

                Else

                    MsgBox("No se puede eliminar el Presupuesto, existen movimientos de la cuenta.", MsgBoxStyle.OkOnly, "Presupuesto")

                End If

            End If


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

End Class