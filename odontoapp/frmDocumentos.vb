Imports CrystalDecisions.CrystalReports.Engine
Imports System.Math

Public Class frmDocumentos

    'Variables de las Clases
    Private PAC As CLASE_PACIENTES
    Private CONTRATO As CLASE_CONTRATOS
    Private CONSUL As CLASE_CONSULTORIO
    Private PRESUPUESTO As CLASE_PRESUPUESTO

    'Varibles de control
    Private fecha As Date
    Private contar As Integer
    Private Imagen As Object

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()

    End Sub

    Public Sub TreeInformes_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeDocumentos.AfterSelect

        Try

            If TreeDocumentos.SelectedNode.Name = "Nodo0" Or TreeDocumentos.SelectedNode.Name = "Nodo3" Then

                cargarcontrato()

            End If


            If TreeDocumentos.SelectedNode.Name = "Nodo1" Or TreeDocumentos.SelectedNode.Name = "Nodo4" Then

                Me.TabDocumentos.SelectedTabIndex = 1
                Me.TabDocumentos.Update()

                Me.dateDocumento.Value = Date.Now

                PAC = New CLASE_PACIENTES
                PAC.p_IdPaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                PAC.Seleccionar("pacientes")

                Me.txtnombre_pac2.Text = CLASE_PACIENTES.xnombres_pac & " " & CLASE_PACIENTES.xapellidos_pac
                Me.txtnumdoc_pac2.Text = CLASE_PACIENTES.xnumdoc_pac
                Me.txtdedoc_pac2.text = CLASE_PACIENTES.xdedoc_pac

                PAC.dispose()
                PAC = Nothing

            End If

            If TreeDocumentos.SelectedNode.Name = "Nodo2" Or TreeDocumentos.SelectedNode.Name = "Nodo8" Then

                Me.TabDocumentos.SelectedTabIndex = 2
                Me.TabDocumentos.Update()

                Me.dateDocumento.Value = Date.Now

            End If


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia
    End Sub

    Private Sub btnDocumento_CPS_SCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocumento_CPS_SCO.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Documento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Documentos")

            If respuesta = 6 Then

                CONSUL = New CLASE_CONSULTORIO

                CONSUL.p_Idconsultorio = 1
                CONSUL.Seleccionar("logoclinica")

                Dim orptContratoPrestServ_SCO As New rptContratoPrestServ_SCO()
                'Dim toTexto As TextObject
                'Dim toIField As Object

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptContratoPrestServ_SCO.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptContratoPrestServ_SCO

                'Definimos El Titulo de la Clinica por Defecto
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoNomPaciente").Text = "'" & Me.txtnombre_pac.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoNumDoc").Text = "'" & Me.txtnumdoc_pac.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoDeDoc").Text = "'" & Me.txtdedoc_pac.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoMesesDiag").Text = "'" & Me.txtMesesDiag.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoCostoTrat_Letras").Text = "'" & clsNumeros.NroEnLetras(CDbl(Me.txtCostoTrat.Text), False) & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoCostoTrat_Num").Text = "'" & Me.txtCostoTrat.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoNCuotaIni").Text = "'" & Me.txtNCuotaIni.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVCuotaIni").Text = "'" & Me.txtVCuotaIni.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoNCuotaMen").Text = "'" & Me.txtNCuotaMen.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVCuotaMen").Text = "'" & Me.txtVCuotaMen.Text & "'"

                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVMulta_Num").Text = "'" & Me.txtVMulta.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVMulta_Letras").Text = "'" & clsNumeros.NroEnLetras(CDbl(Me.txtVMulta.Text), False) & "'"

                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVBracket_Num").Text = "'" & Me.txtVBracket.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVBracket_Letras").Text = "'" & clsNumeros.NroEnLetras(CDbl(Me.txtVBracket.Text), False) & "'"

                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVTuboM_Num").Text = "'" & Me.txtVTuboM.Text & "'"
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoVTuboM_Letras").Text = "'" & clsNumeros.NroEnLetras(CDbl(Me.txtVTuboM.Text), False) & "'"

                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoCiudad").Text = "'" & Me.txtCiudad.Text & "'"

                Dim aux As String
                aux = "a los " & Me.dateDocumento.Value.Day & " dias del mes de " & mescovert(Me.dateDocumento.Value.Month) & " de " & Me.dateDocumento.Value.Year
                orptContratoPrestServ_SCO.DataDefinition.FormulaFields.Item("campoFecha").Text = "'" & aux & "'"

                'Definimos El Titulo de la Clinica por Defecto
                'toTexto = orptContratoPrestServ_SCO.ReportDefinition.ReportObjects.Item("txtEmpresa")
                'toTexto.Text = CLASE_GENERAL._razonsocial_cons

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CONSUL.dispose()
                CONSUL = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Function mescovert(ByVal day As Integer) As String

        Dim mes As String

        mes = ""

        Select Case day

            Case 1
                mes = "ENERO"
            Case 2
                mes = "FEBRERO"
            Case 3
                mes = "MARZO"
            Case 4
                mes = "ABRIL"
            Case 5
                mes = "MAYO"
            Case 6
                mes = "JUNIO"
            Case 7
                mes = "JULIO"
            Case 8
                mes = "AGOSTO"
            Case 9
                mes = "SEPTIEMBRE"
            Case 10
                mes = "OCTUBRE"
            Case 11
                mes = "NOVIEMBRE"
            Case 12
                mes = "DICIEMBRE"

        End Select

        Return mes

    End Function

    Private Sub btnDocumento_CINFO_SCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocumento_CINFO_SCO.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Documento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Documentos")

            If respuesta = 6 Then

                CONSUL = New CLASE_CONSULTORIO
                CONSUL.p_Idconsultorio = 1
                CONSUL.Seleccionar("logoclinica")

                Dim orptBeneficiosTratamiento As New rptBeneficiosTratamiento
                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptBeneficiosTratamiento.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptBeneficiosTratamiento

                'Definimos El Titulo de la Clinica por Defecto
                orptBeneficiosTratamiento.DataDefinition.FormulaFields.Item("campoNomPaciente").Text = "'" & Me.txtnombre_pac2.Text & "'"
                orptBeneficiosTratamiento.DataDefinition.FormulaFields.Item("campoNumDoc").Text = "'" & Me.txtnumdoc_pac2.Text & "'"
                orptBeneficiosTratamiento.DataDefinition.FormulaFields.Item("campoDedoc").Text = "'" & Me.txtdedoc_pac2.Text & "'"


                'Definimos El Titulo de la Clinica por Defecto
                'Dim toTexto As TextObject
                'toTexto = orptContratoPrestServ_SCO.ReportDefinition.ReportObjects.Item("txtEmpresa")
                'toTexto.Text = CLASE_GENERAL._razonsocial_cons

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CONSUL.dispose()
                CONSUL = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProviderpac.BlinkRate = 200
        Me.ErrorProviderpac.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtCiudad.Text.Length = 0 Then
            ErrorProviderpac.SetError(Me.txtCiudad, "Escriba la Ciudad Por favor")
            MsgBox(ErrorProviderpac.GetError(Me.txtCiudad), MsgBoxStyle.OkOnly, "Documentos")
            Me.txtCiudad.Focus()

        ElseIf Me.txtnombre_pac.Text.Length = 0 Then
            ErrorProviderpac.SetError(Me.txtnombre_pac, "Escriba el Nombre del Paciente por favor")
            MsgBox(ErrorProviderpac.GetError(Me.txtnombre_pac), MsgBoxStyle.OkOnly, "Documentos")
            Me.txtnombre_pac.Focus()

        ElseIf Me.txtnumdoc_pac.Text.Length = 0 Then
            ErrorProviderpac.SetError(Me.txtnumdoc_pac, "Escriba el Numero del Documento por favor")
            MsgBox(ErrorProviderpac.GetError(Me.txtnumdoc_pac), MsgBoxStyle.OkOnly, "Documentos")
            Me.txtnumdoc_pac.Focus()

        ElseIf Me.txtdedoc_pac.Text.Length = 0 Then
            ErrorProviderpac.SetError(Me.txtdedoc_pac, "Escriba la Ciudad del Documento favor")
            MsgBox(ErrorProviderpac.GetError(Me.txtdedoc_pac), MsgBoxStyle.OkOnly, "Documentos")
            Me.txtdedoc_pac.Focus()


        Else

            Try

                '**************************** MODULO PARA INGRESO DEL PACIENTE *******************************

                CONTRATO = New CLASE_CONTRATOS

                contar = 0
                contar = CLASE_GENERAL.contar2("Idpaciente", "contratos", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                'Asignamos los valores a las variables de la clase pacientes 

                CONTRATO.p_Idcontrato = (CLASE_GENERAL.maximo("Idcontrato", "contratos", CLASE_GENERAL.mensaje_error)) + 1
                CONTRATO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                CONTRATO.p_fecha_contr = Format(Me.dateDocumento.Value, "yyyy-MM-dd")
                CONTRATO.p_ciudad_contr = Me.txtCiudad.Text
                CONTRATO.p_nombre_pac = Me.txtnombre_pac.Text
                CONTRATO.p_dedoc_pac = Me.txtdedoc_pac.Text
                CONTRATO.p_MesesDiag = Me.txtMesesDiag.Text
                CONTRATO.p_CostoTrat = Me.txtCostoTrat.Text
                CONTRATO.p_NCuotaIni = Me.txtNCuotaIni.Text
                CONTRATO.p_VCuotaIni = Me.txtVCuotaIni.Text
                CONTRATO.p_NCuotaMen = Me.txtNCuotaMen.Text
                CONTRATO.p_VCuotaMen = Me.txtVCuotaMen.Text
                CONTRATO.p_VMulta = Me.txtVMulta.Text
                CONTRATO.p_VTuboM = Me.txtVTuboM.Text
                CONTRATO.p_VBracket = Me.txtVBracket.Text

                'Insertamos en la base de datos lo correspondiente a los datos basicos del paciente

                If contar > 0 Then
                    CONTRATO.Modificar(CLASE_GENERAL.mensaje_error)
                Else
                    CONTRATO.Insertar(CLASE_GENERAL.mensaje_error)
                End If

                CONTRATO.dispose() 'Liberamos recursos 
                CONTRATO = Nothing

                Me.btnDocumento_CPS_SCO.Enabled = True

                MsgBox("Contrato Guardado con Exito", MsgBoxStyle.OkOnly, "Documentos")


            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia


        End If


    End Sub

    Private Sub frmDocumentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cargarcontrato()

    End Sub

    Public Sub cargarcontrato()

        Try

            Me.TabDocumentos.SelectedTabIndex = 0
            Me.TabDocumentos.Update()

            'Controlamos que exista un registro de la historia clinica para modificarlo
            'si no existe creamos un nuevo registro al insertarlo en la base de datos
            contar = 0
            contar = CLASE_GENERAL.contar2("Idpaciente", "contratos", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

            If contar > 0 Then

                CONTRATO = New CLASE_CONTRATOS

                CONTRATO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                CONTRATO.Seleccionar("registro")

                Me.dateDocumento.Value = CLASE_CONTRATOS.xfecha_contr

                Me.txtCiudad.Text = CLASE_CONTRATOS.xciudad_contr
                Me.txtnombre_pac.Text = CLASE_CONTRATOS.xnombre_pac
                Me.txtdedoc_pac.Text = CLASE_CONTRATOS.xdedoc_pac
                Me.txtMesesDiag.Text = CLASE_CONTRATOS.xMesesDiag
                Me.txtCostoTrat.Text = CLASE_CONTRATOS.xCostoTrat
                Me.txtNCuotaIni.Text = CLASE_CONTRATOS.xNCuotaIni
                Me.txtVCuotaIni.Text = CLASE_CONTRATOS.xVCuotaIni
                Me.txtNCuotaMen.Text = CLASE_CONTRATOS.xNCuotaMen
                Me.txtVCuotaMen.Text = CLASE_CONTRATOS.xVCuotaMen
                Me.txtVMulta.Text = CLASE_CONTRATOS.xVMulta
                Me.txtVTuboM.Text = CLASE_CONTRATOS.xVTuboM
                Me.txtVBracket.Text = CLASE_CONTRATOS.xVBracket

                Me.btnDocumento_CPS_SCO.Enabled = True

            Else

                contar = 0
                contar = CLASE_GENERAL.contar2("Idpaciente", "presupuesto", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                If contar > 0 Then

                    'Cargamos los datos del Paciente
                    PAC = New CLASE_PACIENTES
                    PAC.p_IdPaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                    PAC.Seleccionar("pacientes")

                    Me.txtnombre_pac.Text = CLASE_PACIENTES.xnombres_pac & " " & CLASE_PACIENTES.xapellidos_pac
                    Me.txtnumdoc_pac.Text = CLASE_PACIENTES.xnumdoc_pac
                    Me.txtdedoc_pac.Text = CLASE_PACIENTES.xdedoc_pac

                    PAC.dispose()
                    PAC = Nothing

                    'Cargamos el presupuesto

                    PRESUPUESTO = New CLASE_PRESUPUESTO
                    PRESUPUESTO.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    PRESUPUESTO.Seleccionar("registro")

                    Me.dateDocumento.Value = CLASE_PRESUPUESTO.xfecha_pres
                    Me.txtCostoTrat.Text = CLASE_PRESUPUESTO.xVTotalPresupuesto
                    Me.txtNCuotaIni.Text = CLASE_PRESUPUESTO.xNCuotasIni_pres
                    Me.txtVCuotaIni.Text = CLASE_PRESUPUESTO.xVCuotasIni_pres
                    Me.txtNCuotaMen.Text = CLASE_PRESUPUESTO.xNCuotas_pres
                    Me.txtVCuotaMen.Text = CLASE_PRESUPUESTO.xVCuotas_pres
                    Me.txtMesesDiag.Text = CLASE_GENERAL.contar2("Idpaciente", "cuotas", My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, CLASE_GENERAL.mensaje_error)

                    PRESUPUESTO.dispose()
                    PRESUPUESTO = Nothing

                    Me.btnDocumento_CPS_SCO.Enabled = False
                    Me.btnAdicionar.Enabled = True

                Else

                    PAC = New CLASE_PACIENTES
                    PAC.p_IdPaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                    PAC.Seleccionar("pacientes")

                    Me.txtnombre_pac.Text = CLASE_PACIENTES.xnombres_pac & " " & CLASE_PACIENTES.xapellidos_pac
                    Me.txtnumdoc_pac.Text = CLASE_PACIENTES.xnumdoc_pac
                    Me.txtdedoc_pac.Text = CLASE_PACIENTES.xdedoc_pac
                    Me.dateDocumento.Value = CLASE_PACIENTES.xfecingreso_pac


                    PAC.dispose()
                    PAC = Nothing

                    Me.btnDocumento_CPS_SCO.Enabled = False
                    Me.btnAdicionar.Enabled = False

                    MsgBox("No se ha creado un presupuesto para este paciente.", MsgBoxStyle.OkOnly, "Presupuesto")
                    Me.btnDocumento_CPS_SCO.Enabled = False

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub txtCiudad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCiudad.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtCiudad, "")
    End Sub

    Private Sub txtnombre_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre_pac.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtnombre_pac, "")
    End Sub

    Private Sub txtnumdoc_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumdoc_pac.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtnumdoc_pac, "")
    End Sub

    Private Sub txtdedoc_pac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdedoc_pac.TextChanged
        Me.ErrorProviderpac.SetError(Me.txtdedoc_pac, "")
    End Sub

    Private Sub btnDocumento_Beneficios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocumento_Beneficios.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Documento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Documentos")

            If respuesta = 6 Then

                CONSUL = New CLASE_CONSULTORIO
                CONSUL.p_Idconsultorio = 1
                CONSUL.Seleccionar("logoclinica")

                Dim orptBeneficiosRecomedaciones As New rptBeneficiosRecomedaciones
                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptBeneficiosRecomedaciones.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptBeneficiosRecomedaciones

                ''Definimos El Titulo de la Clinica por Defecto
                'orptBeneficiosTratamiento.DataDefinition.FormulaFields.Item("campoNomPaciente").Text = "'" & Me.txtnombre_pac2.Text & "'"
                'orptBeneficiosTratamiento.DataDefinition.FormulaFields.Item("campoNumDoc").Text = "'" & Me.txtnumdoc_pac2.Text & "'"

                'Definimos El Titulo de la Clinica por Defecto
                'Dim toTexto As TextObject
                'toTexto = orptContratoPrestServ_SCO.ReportDefinition.ReportObjects.Item("txtEmpresa")
                'toTexto.Text = CLASE_GENERAL._razonsocial_cons

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(50)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CONSUL.dispose()
                CONSUL = Nothing

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

        'lblTituloVentana
        ubicarcontrol(Me.TreeDocumentos)
        ubicarcontrol(Me.TabDocumentos)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.lblTituloVentana)

    End Sub

    Private Sub frmDocumentos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

End Class