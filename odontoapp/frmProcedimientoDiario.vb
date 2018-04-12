Imports System.Math
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

'Delegate Sub FunctionCall(ByVal param)

Public Class frmProcedimientoDiario

    Private PAC As CLASE_PACIENTES
    Private PROCE As CLASE_PROCEDIMIENTO_DIARIO
    Private MENSAJEPROCED As CLASE_TEXTO_PROCEDIMIENTO
    Private GENE As CLASE_GENERAL
    Private EVEN As CLASE_EVENTOS
    Private HUELLA As CLASE_HUELLAS

    Private Data As AppData
    Public WithEvents AppData As AppData


    ' Variables de las Huellas
    Public huellita1 As DPFP.Template
    Public huellita2 As DPFP.Template
    Public huellita3 As DPFP.Template
    Public huellita4 As DPFP.Template
    Public huellita5 As DPFP.Template
    Public huellita6 As DPFP.Template
    Public huellita7 As DPFP.Template
    Public huellita8 As DPFP.Template
    Public huellita9 As DPFP.Template
    Public huellita10 As DPFP.Template
    Public huellitaaux As DPFP.Template

    'Variables de Forms
    Private Verificator_Form As VerificationForm
    Private PositionChar As Integer
    Private Textauxini As String
    Private textauxfin As String


    Private Sub OnDataChange()
        ExchangeData(False)
    End Sub

    Private Sub ExchangeData(ByVal read As Boolean)

        Data.EnrolledFingersMask = 0
        Data.MaxEnrollFingerCount = 10
        Data.IsEventHandlerSucceeds = True
        Data.Update()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try


            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.cmbProcedimientos.Text.Length = 0 Then

                ErrorProvider.SetError(Me.cmbProcedimientos, "Escriba o escoja un Procedimiento por favor")
                MsgBox(ErrorProvider.GetError(Me.cmbProcedimientos), MsgBoxStyle.OkOnly, "Procedimientos")
                Me.cmbProcedimientos.Focus()

            ElseIf Me.memoProcedimiento.Text.Length = 0 Then

                ErrorProvider.SetError(Me.memoProcedimiento, "Escriba o escoja un Procedimiento por favor")
                MsgBox(ErrorProvider.GetError(Me.memoProcedimiento), MsgBoxStyle.OkOnly, "Procedimientos")
                Me.memoProcedimiento.Focus()

            Else

                PROCE = New CLASE_PROCEDIMIENTO_DIARIO
                EVEN = New CLASE_EVENTOS

                ' Cargamos Variables para ingresar el nuevo Procedimiento
                PROCE.p_Idproced = (CLASE_GENERAL.maximo("Idproced", "procedimientodiario", CLASE_GENERAL.mensaje_error)) + 1
                PROCE.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                PROCE.p_Fecha = Format(Me.cmbfechaProced.Value, "yyyy-MM-dd")
                PROCE.p_proced = Me.memoProcedimiento.Text

                PROCE.Insertar(CLASE_GENERAL.mensaje_error)

                PROCE.dispose() 'liberamos recursos
                PROCE = Nothing
                EVEN = Nothing

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("procedimientos", Me.dgProcedimientos, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)

                GENE = Nothing

                GRIDSTYLES()

                Me.dgProcedimientos.ClearSelection()

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarprocedimientodiario")
                EVEN = Nothing

                Me.btnFirmaPaciente.Enabled = False
                Me.btnFirmaOdonto.Enabled = False

                MsgBox("Prcedimiento Diario Registrado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimiento Diario") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                formatorow()

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnEmpSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmProcedimientoDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        formatorow()
    End Sub

    Private Sub frmProcedimientoDiario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        formatorow()
    End Sub

    Private Sub frmProcedimientoDiario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            ' Cargamos el combo con los mensajes existentes
            CLASE_GENERAL.cargar_combo("mensajesprocedimientos", Me.cmbProcedimientos, CLASE_GENERAL.mensaje_error)

            'Cargamos la grilla con los Procedimientos del Paciente

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("procedimientos", Me.dgProcedimientos, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
            GENE = Nothing

            GRIDSTYLES()

            Me.dgProcedimientos.ClearSelection()

            'Cargamos el control con la fecha de hoy

            Me.cmbfechaProced.Value = DateTime.Today

            'cargamos el texto del mensaje
            EVEN = New CLASE_EVENTOS
            MENSAJEPROCED = New CLASE_TEXTO_PROCEDIMIENTO

            Me.cmbProcedimientos.SelectedIndex = 0

            Me.txtIdProced.Text = Me.cmbProcedimientos.SelectedValue
            EVEN.bloquaerdesbloquear("editarmensaje")

            MENSAJEPROCED.p_IdMensaje = Me.txtIdProced.Text
            MENSAJEPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)
            Me.memoProcedimiento.Text = CLASE_MENSAJES.xMensaje

            MENSAJEPROCED.dispose()
            MENSAJEPROCED = Nothing
            EVEN = Nothing

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarprocedimientodiario")
            EVEN.bloquaerdesbloquear("nuevoprocedimientodiario")
            EVEN = Nothing


        Catch ex As System.InvalidCastException

            MsgBox("No Hay Mensajes en la Base de datos ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimientos") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimientos") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub cmbProcedimientos_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProcedimientos.SelectionChangeCommitted

        Try

            MENSAJEPROCED = New CLASE_TEXTO_PROCEDIMIENTO

            'Cargamos el texto del mensaje segun el valor seleccionado
            MENSAJEPROCED.p_IdMensaje = Me.cmbProcedimientos.SelectedValue
            MENSAJEPROCED.Seleccionar(CLASE_GENERAL.mensaje_error)

            'Cargamos el texto del mensaje

            'Procedimiento .......

            PositionChar = Me.memoProcedimiento.SelectionStart

            Me.memoProcedimiento.SelectionStart = PositionChar
            Textauxini = Mid(Me.memoProcedimiento.Text, 1, PositionChar)

            If Me.memoProcedimiento.Text.Length = 0 Then

                Me.memoProcedimiento.Text = CLASE_TEXTO_PROCEDIMIENTO.xMensaje

            Else

                Me.memoProcedimiento.Text = Textauxini & ", " & CLASE_TEXTO_PROCEDIMIENTO.xMensaje

            End If

            Me.memoProcedimiento.Focus()
            Me.memoProcedimiento.SelectionStart = PositionChar + Len(CLASE_TEXTO_PROCEDIMIENTO.xMensaje) + 3

            MENSAJEPROCED.dispose()
            MENSAJEPROCED = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Mensajes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try
    End Sub

    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle
            Style1.Alignment = DataGridViewContentAlignment.MiddleLeft
            Style1.WrapMode = DataGridViewTriState.True

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter
            Style2.WrapMode = DataGridViewTriState.True

            With Me.dgProcedimientos

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"
                .Columns(0).Width = 40
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "PROCEDIMIENTO"
                .Columns(1).Width = 380
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "FECHA"
                .Columns(2).Width = 70
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .MultiSelect = False

            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub
    Private Sub btnFirmaPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirmaPaciente.Click

        My.Forms.mdiOrthoSoft.VerificationControl.Active = False
        My.Forms.frmIngreso.VerificationControl.Active = False

        Data = New AppData()

        cargarhuellitas(My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag, 1)

        CLASE_GENERAL._TipoUsuario = 1 'Tipo Paciente

        Verificator_Form = New VerificationForm(Data)

        Verificator_Form.Show()
        Verificator_Form.Activate()


    End Sub

    Private Sub btnProcedCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcedCrear.Click

        My.Forms.frmTextoProcedimientos.MdiParent = My.Forms.mdiOrthoSoft
        'Display the new form.
        My.Forms.frmTextoProcedimientos.Show()
        My.Forms.frmTextoProcedimientos.Activate()

    End Sub

    Private Sub dgProcedimientos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProcedimientos.CellClick

        Try

            PROCE = New CLASE_PROCEDIMIENTO_DIARIO
            MENSAJEPROCED = New CLASE_TEXTO_PROCEDIMIENTO
            EVEN = New CLASE_EVENTOS

            EVEN.limpiar("limpiarprocedimientodiario")

            If Me.dgProcedimientos.CurrentRow.Cells(0).Value IsNot DBNull.Value Then

                PROCE.p_Idproced = Me.dgProcedimientos.CurrentRow.Cells(0).Value
                PROCE.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                PROCE.Seleccionar("procedimientos")

                Me.txtIdProced.Text = CLASE_PROCEDIMIENTO_DIARIO.xIdproced
                Me.memoProcedimiento.Text = CLASE_PROCEDIMIENTO_DIARIO.xproced

                comprobarfirmas(CInt(Me.dgProcedimientos.CurrentRow.Cells(0).Value))

                CLASE_GENERAL._Idprocedimiento = CInt(Me.dgProcedimientos.CurrentRow.Cells(0).Value)

            End If

            EVEN.bloquaerdesbloquear("editarprocedimientodiario")
            EVEN = Nothing


        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try


            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar el Paciente", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Procedimientos")

            If respuesta = MsgBoxResult.Yes Then


                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProvider.BlinkRate = 200
                Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.cmbProcedimientos.Text.Length = 0 Then

                    ErrorProvider.SetError(Me.cmbProcedimientos, "Escriba o escoja un Procedimiento por favor")
                    MsgBox(ErrorProvider.GetError(Me.cmbProcedimientos), MsgBoxStyle.OkOnly, "Procedimientos")
                    Me.cmbProcedimientos.Focus()

                ElseIf Me.memoProcedimiento.Text.Length = 0 Then

                    ErrorProvider.SetError(Me.memoProcedimiento, "Escriba o escoja un Procedimiento por favor")
                    MsgBox(ErrorProvider.GetError(Me.memoProcedimiento), MsgBoxStyle.OkOnly, "Procedimientos")
                    Me.memoProcedimiento.Focus()

                Else

                    PROCE = New CLASE_PROCEDIMIENTO_DIARIO
                    EVEN = New CLASE_EVENTOS

                    ' Cargamos Variables para ingresar el nuevo Procedimiento
                    PROCE.p_Idproced = Me.txtIdProced.Text
                    PROCE.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                    PROCE.p_Fecha = Format(Me.cmbfechaProced.Value, "yyyy-MM-dd")
                    PROCE.p_proced = Me.memoProcedimiento.Text

                    PROCE.Modificar("procedimiento")

                    PROCE.dispose() 'liberamos recursos
                    PROCE = Nothing
                    EVEN = Nothing

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("procedimientos", Me.dgProcedimientos, My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag)
                    GENE = Nothing

                    GRIDSTYLES()

                    Me.dgProcedimientos.ClearSelection()

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editarprocedimientodiario")
                    EVEN = Nothing

                    MsgBox("Procedimiento Diario Modificado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Procedimiento Diario") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                    formatorow()

                End If

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
        ubicarcontrol(Me.lblfechaProced)
        ubicarcontrol(Me.cmbfechaProced)
        ubicarcontrol(Me.cmbProcedimientos)
        ubicarcontrol(Me.lblProcedimientos)

        ubicarcontrol(Me.memoProcedimiento)
        ubicarcontrol(Me.btnProcedCrear)
        ubicarcontrol(Me.dgProcedimientos)

        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnModificar)
        ubicarcontrol(Me.btnNuevo)
        ubicarcontrol(Me.btnEliminar)
        ubicarcontrol(Me.btnSalir)

        ubicarcontrol(Me.lblTituloVentana)

        ubicarcontrol(Me.btnFirmaOdonto)
        ubicarcontrol(Me.btnFirmaPaciente)
        ubicarcontrol(Me.btnImprimirInforme)

        ubicarcontrol(Me.txtIdProced)

    End Sub


    Private Sub frmProcedimientoDiario_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea un Nuevo Procedimiento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Procedimientos")

            If respuesta = MsgBoxResult.Yes Then

                Me.cmbProcedimientos.Text = ""
                Me.memoProcedimiento.Text = ""

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("nuevoprocedimientodiario")
                EVEN = Nothing

                Me.btnFirmaPaciente.Enabled = True
                Me.btnFirmaOdonto.Enabled = True


            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub cmbProcedimientos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProcedimientos.TextChanged

        Me.ErrorProvider.SetError(Me.cmbProcedimientos, "")

    End Sub

    Private Sub memoProcedimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles memoProcedimiento.TextChanged

        Me.ErrorProvider.SetError(Me.memoProcedimiento, "")

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Desea eliminar el Procedimiento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Procedimientos")

            If respuesta = MsgBoxResult.Yes Then

                'Eliminar ...................

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub comprobarfirmas(ByVal procedimiento As Integer)

        Try

            PROCE = New CLASE_PROCEDIMIENTO_DIARIO

            If Me.dgProcedimientos.CurrentRow.Cells(0).Value IsNot DBNull.Value Then

                PROCE.p_Idproced = procedimiento
                PROCE.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                PROCE.Seleccionar("procedimientoshuellas")

                If CLASE_PROCEDIMIENTO_DIARIO.xfirmaodonto.Length = 0 Then

                    Me.btnFirmaOdonto.Enabled = True
                    MessageBox.Show("Verifique la Firma del Doctor en este procedimiento", "Firmas", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Me.btnFirmaOdonto.Enabled = False
                End If

                If CLASE_PROCEDIMIENTO_DIARIO.xfirmapaciente.Length = 0 Then
                    Me.btnFirmaPaciente.Enabled = True
                    MessageBox.Show("Verifique la Firma del Paciente en este procedimiento", "Firmas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Me.btnFirmaPaciente.Enabled = False
                End If

            End If



        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub cargarhuellitas(ByVal Idusuario As Integer, ByVal IdTusuario As Integer)

        Try

            ' ------------------ Inicializamos los Objetos de la BD ----------------------

            HUELLA = New CLASE_HUELLAS

            huellita1 = New DPFP.Template
            huellita2 = New DPFP.Template
            huellita3 = New DPFP.Template
            huellita4 = New DPFP.Template
            huellita5 = New DPFP.Template
            huellita6 = New DPFP.Template
            huellita7 = New DPFP.Template
            huellita8 = New DPFP.Template
            huellita9 = New DPFP.Template
            huellita10 = New DPFP.Template

            '------------------- Cargamos los Datos de la Cuenta ----------------

            HUELLA.p_IdUsuario = Idusuario
            HUELLA.p_IdTUsuario = IdTusuario ' Tipo Paciente

            HUELLA.Seleccionar("todos")

            If Not (CLASE_HUELLAS.xhuella1 = "") Then

                huellita1.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella1))
                Data.Templates(0) = huellita1

            End If

            If Not (CLASE_HUELLAS.xhuella2 = "") Then

                huellita2.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella2))
                Data.Templates(1) = huellita2

            End If

            If Not (CLASE_HUELLAS.xhuella3 = "") Then

                huellita3.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella3))
                Data.Templates(2) = huellita3

            End If

            If Not (CLASE_HUELLAS.xhuella4 = "") Then

                huellita4.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella4))
                Data.Templates(3) = huellita4

            End If

            If Not (CLASE_HUELLAS.xhuella5 = "") Then

                huellita5.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella5))
                Data.Templates(4) = huellita5

            End If

            If Not (CLASE_HUELLAS.xhuella6 = "") Then

                huellita6.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella6))
                Data.Templates(5) = huellita6

            End If

            If Not (CLASE_HUELLAS.xhuella7 = "") Then

                huellita7.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella7))
                Data.Templates(6) = huellita7

            End If

            If Not (CLASE_HUELLAS.xhuella8 = "") Then

                huellita8.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella8))
                Data.Templates(7) = huellita8

            End If

            If Not (CLASE_HUELLAS.xhuella9 = "") Then

                huellita9.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella9))
                Data.Templates(8) = huellita9

            End If

            If Not (CLASE_HUELLAS.xhuella10 = "") Then

                huellita10.DeSerialize(StringToByteArray(CLASE_HUELLAS.xhuella10))
                Data.Templates(9) = huellita10

            End If

            HUELLA.dispose()
            HUELLA = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pensionado") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Public Shared Function StringToByteArray(ByVal hex As String) As Byte()

        Dim NumberChars As Integer = hex.Length
        Dim bytes As Byte() = New Byte(NumberChars / 2 - 1) {}
        For i As Integer = 0 To NumberChars - 1 Step 2
            bytes(i / 2) = Convert.ToByte(hex.Substring(i, 2), 16)
        Next
        Return (bytes)

    End Function

    Private Sub btnImprimirInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirInforme.Click

        Try

            Dim respuesta As Integer
            respuesta = MsgBox("Desea cargar el Informe ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Procedimientos Diarios")

            If respuesta = 6 Then

                PROCE = New CLASE_PROCEDIMIENTO_DIARIO
                PROCE.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag
                PROCE.Seleccionar("informegeneral")

                Dim orptProcedimientosDiarios As New rptProcedimientosDiarios()

                frmInformes.MdiParent = My.Forms.mdiOrthoSoft
                orptProcedimientosDiarios.SetDataSource(CLASE_GENERAL.xdt)
                My.Forms.frmInformes.crvOrthosoft.ReportSource = orptProcedimientosDiarios

                'Definimos El Titulo de la Clinica por Defecto

                My.Forms.frmInformes.crvOrthosoft.ShowRefreshButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowCloseButton = False
                My.Forms.frmInformes.crvOrthosoft.ShowGroupTreeButton = False
                My.Forms.frmInformes.crvOrthosoft.Zoom(70)

                'Display the new form.
                My.Forms.frmInformes.Show()
                My.Forms.frmInformes.Activate()

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnFirmaOdonto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirmaOdonto.Click

        My.Forms.mdiOrthoSoft.VerificationControl.Active = False
        My.Forms.frmIngreso.VerificationControl.Active = False

        Data = New AppData()

        cargarhuellitas(My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag, 2)

        CLASE_GENERAL._TipoUsuario = 2 'Tipo Doctor

        Verificator_Form = New VerificationForm(Data)
        Verificator_Form.Show()
        Verificator_Form.Activate()

    End Sub

    Public Sub formatorow()

        Try

            PROCE = New CLASE_PROCEDIMIENTO_DIARIO

            If Not (Me.dgProcedimientos.Rows.Count = 0) Then

                For Each row As DataGridViewRow In Me.dgProcedimientos.Rows

                    PROCE.p_Idproced = row.Cells("Idproced").Value
                    PROCE.p_Idpaciente = My.Forms.mdiOrthoSoft.lblActivoPaciente.Tag

                    PROCE.Seleccionar("procedimientoshuellas")

                    If CLASE_PROCEDIMIENTO_DIARIO.xfirmaodonto.Length = 0 And CLASE_PROCEDIMIENTO_DIARIO.xfirmapaciente.Length = 0 Then

                        row.DefaultCellStyle.BackColor = Color.Wheat

                    ElseIf CLASE_PROCEDIMIENTO_DIARIO.xfirmaodonto.Length = 0 Or CLASE_PROCEDIMIENTO_DIARIO.xfirmapaciente.Length = 0 Then

                        row.DefaultCellStyle.BackColor = Color.LightYellow

                    ElseIf Not (CLASE_PROCEDIMIENTO_DIARIO.xfirmaodonto.Length = 0) And Not (CLASE_PROCEDIMIENTO_DIARIO.xfirmapaciente.Length = 0) Then

                        row.DefaultCellStyle.BackColor = Color.LightGreen

                    End If

                Next

                Me.dgProcedimientos.Update()
                Me.dgProcedimientos.Refresh()

                PROCE.dispose()
                PROCE = Nothing

                Me.dgProcedimientos.ClearSelection()

            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

End Class