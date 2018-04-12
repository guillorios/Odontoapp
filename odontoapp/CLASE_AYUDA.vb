Public Class CLASE_AYUDA

    '********************

    'Presupuestos Idestados
    'Con esto controlamos el estado de un presupuesto para verificar el borrado
    'del presupuesto, que se hayan hecho movimientos o pagos

    '1 Nuevo
    '2 Saldo o Movimiento
    '3 Cancelada pagada


    '********************

    'Items desde estado de Cuotas
    'CLASE_GENERAL.formloadrc = 2
    '- Esta Variable la utilizamos para verificar que los items vienen desde el estado de las cuotas
    'de los presupuestos de un paciente o estan ingresandose solo items.

    ' 1 No proviene de un estado de Cuenta
    ' 2 Proviene del Estado de Cuenta

    '**********************

    'Tipo Cuota
    ' La utilizamos para verificar si es una cuota del presupuesto o es una cuota adicional de procedimiento

    '1 Cuota Presupuesto
    '2 Cuota Adicional

    '************** TIPO CEDULA ****************************

    'Case "T.I"
    '    PAC.p_tipodoc_pac = 1
    'Case "CEDULA"
    '    PAC.p_tipodoc_pac = 2
    'Case "PASAPORTE"
    '    PAC.p_tipodoc_pac = 3
    'Case "C.EXTRANGERIA"
    '    PAC.p_tipodoc_pac = 4

    '***************** CODIGO DE COLOCAR TEXTOS EN LOS INFORMES **********************************

    ''Definimos los otros items del Informe

    'toTexto = oRptRCaja.ReportDefinition.ReportObjects.Item("TextMoneda")
    'toTexto.Text = Me.rtxtTotalLetras.Text

    'toTexto = oRptRCaja.ReportDefinition.ReportObjects.Item("TextMoneda2")
    'toTexto.Text = Me.rtxtTotalLetras.Text

    'toTexto = oRptRCaja.ReportDefinition.ReportObjects.Item("TextMoneda3")
    'toTexto.Text = Me.rtxtTotalLetras.Text

    ''Definimos los campos de Formula Manualmente
    'orptHistoriaClinica.DataDefinition.FormulaFields.Item("Doctor").Text = "'" & CLASE_GENERAL._rtelegal_cons & "'"
    'orptHistoriaClinica.DataDefinition.FormulaFields.Item("DocDoc").Text = "'" & CLASE_GENERAL._documento_cons & "'"
    'orptHistoriaClinica.DataDefinition.FormulaFields.Item("DeDoc").Text = "'" & CLASE_GENERAL._ciudaddoc_cons & "'"

    ''Definimos El Titulo de la Clinica por Defecto
    'Dim toTexto As TextObject
    'toTexto = orptHistoriaClinica.ReportDefinition.ReportObjects.Item("txtrazonsocial_cons")
    'toTexto.Text = CLASE_GENERAL._razonsocial_cons


    '***************** CODIGO CARGAR GRILLAS MAESTRO DETALLE *************************************

    'Public Sub Cargar_Grilla_mestrodetalle(ByVal opcion As String, ByRef grillamaestro As System.Windows.Forms.DataGridView, ByRef grilladetalle As System.Windows.Forms.DataGridView, ByVal opcion1 As String, ByVal opcion2 As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

    '    Try 'sentencia para el manejo de errores

    '        xdtmaestro = New DataTable("Maestro")
    '        xdtdetalle = New DataTable("Detalle")

    '        Select Case opcion

    '            Case "recibosdecaja"

    '                'sql = "SELECT RIGHT(CONCAT('0000000000000', rcaja.Idrc), 5), rcaja.fecha_rc, rcaja.total_rc, rcaja.concepto_rc, rcaja.cheque_rc, rcaja.banco_rc , rcaja.observaciones_rc, estadodocumentos.nom_estado, CONCAT(empleados.nombres_emp,' ', empleados.apellidos_emp) as Nombres FROM Orthosoft.rcaja INNER JOIN orthosoft.estadodocumentos ON (rcaja.Idestado = estadodocumentos.Idestado) INNER JOIN orthosoft.empleados ON (empleados.Idempleado = rcaja.Idusuario) WHERE rcaja.Idpaciente = " & CInt(mensaje) & " AND rcaja.Idestado = 1 ORDER BY rcaja.fecha_rc ASC"
    '                sql = "SELECT Idrc, rcaja.fecha_rc, rcaja.total_rc, rcaja.concepto_rc, rcaja.cheque_rc, rcaja.banco_rc , rcaja.observaciones_rc, estadodocumentos.nom_estado, CONCAT(empleados.nombres_emp,' ', empleados.apellidos_emp) as Nombres FROM Orthosoft.rcaja INNER JOIN orthosoft.estadodocumentos ON (rcaja.Idestado = estadodocumentos.Idestado) INNER JOIN orthosoft.empleados ON (empleados.Idempleado = rcaja.Idusuario) WHERE rcaja.Idpaciente = " & CInt(opcion1) & " AND rcaja.Idestado = 1 ORDER BY rcaja.fecha_rc ASC"
    '                xdamaestro = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega

    '                If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
    '                xda.Fill(xdtmaestro)


    '                sql = "SELECT Idrc, Idprocedimiento, detalle, referencia, cantidad, valor, (valor*cantidad) as TOTAL FROM Orthosoft.detalle_rcaja WHERE Idrc = " & CInt(opcion2) & " "
    '                xda = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega
    '                If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
    '                xda.Fill(xdtdetalle)



    '                xds = New DataSet
    '                xds.Tables.Add(xdtdetalle)
    '                xds.Tables.Add(xdtmaestro)

    '                xds.Relations.Add("Fk", xds.Tables("Maestro").Columns("Idrc"), xds.Tables("Detalle").Columns("Idrc"))

    '                xbsmaestro = New BindingSource
    '                xbsdetalle = New BindingSource

    '                xbsmaestro.DataMember = "Maestro"
    '                xbsmaestro.DataSource = xds

    '                xbsdetalle.DataMember = "Fk"
    '                xbsdetalle.DataSource = xbsmaestro

    '                'Asignar los binding source Maestro y Detalle a su DGV

    '                grillamaestro.DataSource = xbsmaestro
    '                grillamaestro.Update()
    '                grilladetalle.DataSource = xbsdetalle
    '                grilladetalle.Update()

    '        End Select

    '        xda.Dispose()
    '        xda = Nothing

    '    Catch ex As MySqlException 'captura errores sql
    '        MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
    '    Catch ex As Exception 'captura cualquier tipo de errores
    '        MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
    '    End Try 'cierra la sentencia

    'End Sub

    '******************************* CREAR NUEVO CONCEPTO *****************************

    'Private Sub btnOtrosConceptos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtrosConceptos.Click

    '    Try

    '        '********** PARPADEO DE ERROR PROVIDER ***********************

    '        Me.ErrorProviderpac.BlinkRate = 200
    '        Me.ErrorProviderpac.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

    '        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

    '        If Me.txtConcepto_cuota.Text.Length = 0 Then
    '            ErrorProviderpac.SetError(Me.txtConcepto_cuota, "Verifique el Concepto Adicional")
    '            MsgBox(ErrorProviderpac.GetError(Me.txtConcepto_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
    '            Me.txtConcepto_cuota.Focus()

    '        ElseIf txtVConcepto_cuota.Text.Length = 0 Or CInt(Me.txtVConcepto_cuota.Text) = 0 Then
    '            ErrorProviderpac.SetError(Me.txtVConcepto_cuota, "Verifique El Valor del Concepto Adicional")
    '            MsgBox(ErrorProviderpac.GetError(Me.txtVConcepto_cuota), MsgBoxStyle.OkOnly, "Presupuesto")
    '            Me.txtVConcepto_cuota.Focus()

    '        Else

    '            ' ***** CARGAMOS EL ITEM EN LAS CUOTAS *********
    '            CUOTA = New CLASE_CUOTAS
    '            CUOTA.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

    '            'Seleccionamos la ultima fecha del presupuesto para aumentarle un mes
    '            CUOTA.Seleccionar("ultimafecha")

    '            fecha = CDate(CLASE_CUOTAS.xfecha_cuota)
    '            fechaaux = CDate(CLASE_CUOTAS.xfecha_cuota)

    '            If Me.cmbIntervaloCuotas.SelectedIndex = 0 Then

    '                fechaaux = Format((DateAdd(DateInterval.Day, 15, fecha)), "yyyy-MM-dd")

    '            ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 1 Then

    '                fechaaux = Format((DateAdd(DateInterval.Day, 20, fecha)), "yyyy-MM-dd")

    '            ElseIf Me.cmbIntervaloCuotas.SelectedIndex = 2 Then

    '                fechaaux = Format((DateAdd(DateInterval.Month, 1, fecha)), "yyyy-MM-dd")

    '            End If

    '            'Verificamos las variables para ingresar en la base de datos
    '            CUOTA.p_Idcuota = (CLASE_GENERAL.maximo("Idcuota", "cuotas", CLASE_GENERAL.mensaje_error)) + 1
    '            CUOTA.p_valor_cuota = Me.txtVConcepto_cuota.Text
    '            CUOTA.p_saldo_cuota = Me.txtVConcepto_cuota.Text
    '            CUOTA.p_tipo_cuota = 1 ' Tipo presupuesto

    '            'Verificamos si el dia que corresponde al pago no sea un domingo caso contrario se corre hasta el lunes
    '            If DatePart(DateInterval.Weekday, fechaaux) = 1 Then
    '                CUOTA.p_fecha_cuota = Format(DateAdd(DateInterval.Day, 1, fechaaux), "yyyy-MM-dd")
    '            Else
    '                CUOTA.p_fecha_cuota = Format(fechaaux, "yyyy-MM-dd")
    '            End If

    '            CUOTA.p_procedimiento_cuota = Me.txtConcepto_cuota.Text
    '            CUOTA.Insertar(CLASE_GENERAL.mensaje_error)

    '            CUOTA.dispose()
    '            CUOTA = Nothing

    '            'Cargamos la grilla con los pagos
    '            GENE = New CLASE_GENERAL
    '            GENE.Cargar_Grilla("cuotas", Me.dgCuotas, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
    '            GRIDSTYLES()
    '            GENE = Nothing

    '            'Sumamos las Columnas que necesitamos
    '            Me.txtVTotalPresupuesto.Text = CLASE_GENERAL.SumarColumna("valor_cuota", Me.dgCuotas)


    '            '****** INGRESAMOS Y ACTUALIZAMOS EL VALOR TOTAL DEL PRESUPUESTO

    '            PRESUPUESTO = New CLASE_PRESUPUESTO
    '            PRESUPUESTO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
    '            PRESUPUESTO.p_VTotalPresupuesto = Me.txtVTotalPresupuesto.Text

    '            PRESUPUESTO.Modificar("valorpresupuesto")

    '            PRESUPUESTO.dispose()
    '            PRESUPUESTO = Nothing

    '            MsgBox("Item ingresado con con exito.", MsgBoxStyle.OkOnly, "Presupuesto")

    '        End If

    '    Catch ex As Exception 'captura cualquier tipo de errores

    '        MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

    '    End Try 'cierra la sentencia

    'End Sub

    '****************************  CLASE DE DOCUMENTOS ******************************

    '1 RECIBO DE CAJA
    '2 COMPROBANTE DE EGRESO
    '3 FACTURA
    '4 RECIBO DE CAJA MENOR



End Class
