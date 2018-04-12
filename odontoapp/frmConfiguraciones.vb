Imports System.Math

Public Class frmConfiguraciones

    'Variables de Clases
    Private CONSUL As CLASE_CONSULTORIO
    Private EVEN As CLASE_EVENTOS
    Private CONSULTA As CLASE_CONSULTA
    Private SCHE As CLASE_SCHEDULER
    Private GENE As CLASE_GENERAL
    Private ESP As CLASE_ESPECIALIDADES
    Private OPERADOR As CLASE_OPERADOR
    Private DOC As CLASE_DOCTORES
    Private UNIDAD As CLASE_UNIDADES


    'Variables de Control
    Public nfila As Integer

    'Variables de Mensajes de aprobacion
    Private respuesta As Integer
    Private contar As Integer

    'Variables de control de Archivo de Confuguracion
    Private mINI As New cIniArray
    Private sFicINI As String

    'Variables de Fechas
    Private fecha As Date

    'Variables de Control de Imagenes
    Private nombreImg As String = ""
    Private iImagen As Image

    'Variables de Auxiliares de Id Consulta
    Private auxIdTipoConsulta As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        '********** PARPADEO DE ERROR PROVIDER ***********************

        Me.ErrorProvider.BlinkRate = 200
        Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

        '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

        If Me.txtrazonsocial_cons.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtrazonsocial_cons, "Escriba la Razon Social Por favor")
            MsgBox(ErrorProvider.GetError(Me.txtrazonsocial_cons), MsgBoxStyle.OkOnly, "Consultorio")
            Me.txtrazonsocial_cons.Focus()

        ElseIf Me.txtnit_cons.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtnit_cons, "Escriba el Nit por favor")
            MsgBox(ErrorProvider.GetError(Me.txtnit_cons), MsgBoxStyle.OkOnly, "Consultorio")
            Me.txtnit_cons.Focus()

        ElseIf Me.txtdireccion_cons.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtdireccion_cons, "Escriba laDirección por favor")
            MsgBox(ErrorProvider.GetError(Me.txtdireccion_cons), MsgBoxStyle.OkOnly, "Consultorio")
            Me.txtdireccion_cons.Focus()

        ElseIf Me.txtrtelegal_cons.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txtrtelegal_cons, "Escriba el Nombre del Representante Legal por favor")
            MsgBox(ErrorProvider.GetError(Me.txtrtelegal_cons), MsgBoxStyle.OkOnly, "Consultorio")
            Me.txtrtelegal_cons.Focus()

        ElseIf Me.txttel1_cons.Text.Length = 0 Then
            ErrorProvider.SetError(Me.txttel1_cons, "Escriba el Teléfono 1 por favor")
            MsgBox(ErrorProvider.GetError(Me.txttel1_cons), MsgBoxStyle.OkOnly, "Consultorio")
            Me.txttel1_cons.Focus()

        ElseIf Me.cmbDoctores.Text.Length = 0 Then
            ErrorProvider.SetError(Me.cmbDoctores, "Escoja El Doctor por favor")
            MsgBox(ErrorProvider.GetError(Me.cmbDoctores), MsgBoxStyle.OkOnly, "Consultorio")
            Me.cmbDoctores.Focus()

        Else

            Try

                CONSUL = New CLASE_CONSULTORIO

                CONSUL.p_Idconsultorio = 1
                CONSUL.p_razonsocial_cons = Me.txtrazonsocial_cons.Text
                CONSUL.p_nit_cons = Me.txtnit_cons.Text
                CONSUL.p_direccion_cons = Me.txtdireccion_cons.Text
                CONSUL.p_ciudad_cons = Me.txtciudad_cons.Text
                CONSUL.p_web_cons = Me.txtweb_cons.Text
                CONSUL.p_email_cons = Me.txtemail_cons.Text
                CONSUL.p_actividad_cons = Me.txtactividad_cons.Text
                CONSUL.p_rtelegal_cons = Me.txtrtelegal_cons.Text
                CONSUL.p_profesionrlegal_cons = Me.txtprofesionrlegal_cons.Text
                CONSUL.p_documento_cons = Me.txtdocumento_cons.Text
                CONSUL.p_ciudaddoc_cons = Me.txtciudaddoc_cons.Text
                CONSUL.p_ciudadnacrlegal_cons = Me.txtciudadnacrlegal_cons.Text
                CONSUL.p_tel1_cons = Me.txttel1_cons.Text
                CONSUL.p_tel2_cons = Me.txttel2_cons.Text
                CONSUL.p_celular_cons = Me.txtcelular_cons.Text
                CONSUL.p_fax_cons = Me.txtfax_cons.Text
                CONSUL.p_Iddoctor = Me.cmbDoctores.SelectedValue

                CONSUL.p_horaini = Format(Me.StartTime.Value, "HH:mm:ss")
                CONSUL.p_horafin = Format(Me.EndTime.Value, "HH:mm:ss")

                If Me.rbtConfig5min.Checked = True Then
                    CONSUL.p_rangocal = "5"
                ElseIf Me.rbtConfig10min.Checked = True Then
                    CONSUL.p_rangocal = "10"
                ElseIf Me.rbtConfig15min.Checked = True Then
                    CONSUL.p_rangocal = "15"
                ElseIf Me.rbtConfig30min.Checked = True Then
                    CONSUL.p_rangocal = "30"
                End If

                If Me.rbCallCenter1.Checked = True Then

                    CONSUL.p_tipocallcenter_cons = 1

                ElseIf Me.rbCallCenter2.Checked = True Then

                    CONSUL.p_tipocallcenter_cons = 2

                End If

                CONSUL.p_textopiecita = Me.RichTxtPie_Cita.Text
                CONSUL.p_textopiercaja = Me.RichTxtPie_Rcaja.Text
                CONSUL.p_textopiefactura = Me.RichTxtPie_Factura.Text
                CONSUL.p_textodian = Me.RichTxtPie_Dian.Text

                CONSUL.p_topecita = Me.txtTopeCitas.Text

                'Insertamos en la base de datos lo correspondiente a los datos basicos del paciente

                CONSUL.Insertar(CLASE_GENERAL.mensaje_error)
                CONSUL.dispose() 'Liberamos recursos 
                CONSUL = Nothing

                'Grabamos La Configuracion en el archivo INI

                sFicINI = Application.StartupPath & "\config.ini"
                mINI.IniWrite(sFicINI, "Inicio", "Opcion", 1)
                mINI.IniWrite(sFicINI, "Rutabackup", "Ruta", Me.txtRutaBackup.Text)


                respuesta = MsgBox("CONFIGURACION GRABADA CON EXITO, SE DEBE REINICIAR LA APLICACION PARA APLICAR LOS CAMBIOS ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Consultorio")

                If respuesta = 6 Then
                    Application.Exit()
                Else
                    Me.Dispose()
                    Me.Close()
                End If

            Catch ex As Exception 'captura cualquier tipo de errores

                MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

            End Try 'cierra la sentencia

        End If

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Modificar la Configuración", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Consultorio")

        If respuesta = 6 Then

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtrazonsocial_cons.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtrazonsocial_cons, "Escriba la Razon Social Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtrazonsocial_cons), MsgBoxStyle.OkOnly, "Consultorio")
                Me.txtrazonsocial_cons.Focus()

            ElseIf Me.txtnit_cons.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnit_cons, "Escriba el Nit por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnit_cons), MsgBoxStyle.OkOnly, "Consultorio")
                Me.txtnit_cons.Focus()

            ElseIf Me.txtdireccion_cons.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtdireccion_cons, "Escriba laDirección por favor")
                MsgBox(ErrorProvider.GetError(Me.txtdireccion_cons), MsgBoxStyle.OkOnly, "Consultorio")
                Me.txtdireccion_cons.Focus()

            ElseIf Me.txtrtelegal_cons.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtrtelegal_cons, "Escriba el Nombre del Representante Legal por favor")
                MsgBox(ErrorProvider.GetError(Me.txtrtelegal_cons), MsgBoxStyle.OkOnly, "Consultorio")
                Me.txtrtelegal_cons.Focus()

            ElseIf Me.txttel1_cons.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txttel1_cons, "Escriba el Teléfono 1 por favor")
                MsgBox(ErrorProvider.GetError(Me.txttel1_cons), MsgBoxStyle.OkOnly, "Consultorio")
                Me.txttel1_cons.Focus()

            ElseIf Me.cmbDoctores.Text.Length = 0 Then
                ErrorProvider.SetError(Me.cmbDoctores, "Escoja El Doctor por favor")
                MsgBox(ErrorProvider.GetError(Me.cmbDoctores), MsgBoxStyle.OkOnly, "Consultorio")
                Me.cmbDoctores.Focus()

            Else

                Try

                    CONSUL = New CLASE_CONSULTORIO
                    GENE = New CLASE_GENERAL

                    CONSUL.p_Idconsultorio = 1
                    CONSUL.p_razonsocial_cons = Me.txtrazonsocial_cons.Text
                    CONSUL.p_nit_cons = Me.txtnit_cons.Text
                    CONSUL.p_direccion_cons = Me.txtdireccion_cons.Text
                    CONSUL.p_ciudad_cons = Me.txtciudad_cons.Text
                    CONSUL.p_web_cons = Me.txtweb_cons.Text
                    CONSUL.p_email_cons = Me.txtemail_cons.Text
                    CONSUL.p_actividad_cons = Me.txtactividad_cons.Text
                    CONSUL.p_rtelegal_cons = Me.txtrtelegal_cons.Text
                    CONSUL.p_profesionrlegal_cons = Me.txtprofesionrlegal_cons.Text
                    CONSUL.p_documento_cons = Me.txtdocumento_cons.Text
                    CONSUL.p_ciudaddoc_cons = Me.txtciudaddoc_cons.Text
                    CONSUL.p_ciudadnacrlegal_cons = Me.txtciudadnacrlegal_cons.Text
                    CONSUL.p_tel1_cons = Me.txttel1_cons.Text
                    CONSUL.p_tel2_cons = Me.txttel2_cons.Text
                    CONSUL.p_celular_cons = Me.txtcelular_cons.Text
                    CONSUL.p_fax_cons = Me.txtfax_cons.Text
                    CONSUL.p_Iddoctor = Me.cmbDoctores.SelectedValue

                    CONSUL.p_horaini = Format(Me.StartTime.Value, "HH:mm:ss")
                    CONSUL.p_horafin = Format(Me.EndTime.Value, "HH:mm:ss")

                    If Me.rbtConfig5min.Checked = True Then
                        CONSUL.p_rangocal = "5"
                    ElseIf Me.rbtConfig10min.Checked = True Then
                        CONSUL.p_rangocal = "10"
                    ElseIf Me.rbtConfig15min.Checked = True Then
                        CONSUL.p_rangocal = "15"
                    ElseIf Me.rbtConfig30min.Checked = True Then
                        CONSUL.p_rangocal = "30"
                    End If

                    If Me.rbCallCenter1.Checked = True Then

                        CONSUL.p_tipocallcenter_cons = 1

                    ElseIf Me.rbCallCenter2.Checked = True Then

                        CONSUL.p_tipocallcenter_cons = 2

                    End If


                    CONSUL.p_textopiecita = Me.RichTxtPie_Cita.Text
                    CONSUL.p_textopiercaja = Me.RichTxtPie_Rcaja.Text
                    CONSUL.p_textopiefactura = Me.RichTxtPie_Factura.Text
                    CONSUL.p_textodian = Me.RichTxtPie_Dian.Text

                    CONSUL.p_topecita = Me.txtTopeCitas.Text

                    'Grabamos los logos

                    If Not pbLogo1.Image Is Nothing Then

                        CONSUL.p_inicio_cons = GENE.Imagen_Bytes(Me.pbLogo1.Image)

                        Me.btnBuscarFotos1.Enabled = False
                        Me.btnBorrar1.Enabled = True
                        Me.btnGrabar.Enabled = False

                    End If

                    If Not pbLogo2.Image Is Nothing Then

                        CONSUL.p_portada_cons = GENE.Imagen_Bytes(Me.pbLogo2.Image)

                        Me.btnBuscarFotos2.Enabled = False
                        Me.btnBorrar2.Enabled = True
                        Me.btnGrabar.Enabled = False

                    End If

                    If Not pbLogo3.Image Is Nothing Then

                        CONSUL.p_icono_cons = GENE.Imagen_Bytes(Me.pbLogo3.Image)

                        Me.btnBuscarFotos3.Enabled = False
                        Me.btnBorrar3.Enabled = True
                        Me.btnGrabar.Enabled = False

                    End If

                    'Insertamos los consecutivos de los Documentos
                    CONSUL.p_consecrcaja_cons = Me.txtconsecrcaja_cons.Text
                    CONSUL.p_consecfactura_cons = Me.txtconsecfactura_cons.Text
                    CONSUL.p_conseccegreso_cons = Me.txtconseccegreso_cons.Text

                    CONSUL.p_formatopos = ""

                    If Me.chkPosRC.Checked = True Then
                        CONSUL.p_formatopos &= "1"
                    Else
                        CONSUL.p_formatopos &= "0"
                    End If

                    If Me.chkPosFac.Checked = True Then
                        CONSUL.p_formatopos &= "1"
                    Else
                        CONSUL.p_formatopos &= "0"
                    End If

                    If Me.chkPosCE.Checked = True Then
                        CONSUL.p_formatopos &= "1"
                    Else
                        CONSUL.p_formatopos &= "0"
                    End If

                    'Insertamos en la base de datos lo correspondiente a los datos basicos del paciente

                    CONSUL.Modificar("consultorio")
                    CONSUL.dispose() 'Liberamos recursos 
                    CONSUL = Nothing

                    GENE = Nothing

                    'Grabamos La Configuracion en el archivo INI

                    sFicINI = Application.StartupPath & "\config.ini"
                    mINI.IniWrite(sFicINI, "Rutabackup", "Ruta", Me.txtRutaBackup.Text)

                    respuesta = MsgBox("CONFIGURACION GRABADA CON EXITO, SE DEBE REINICIAR LA APLICACION PARA APLICAR LOS CAMBIOS ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Consultorio")

                    If respuesta = 6 Then
                        Application.Exit()
                    Else
                        Me.Dispose()
                        Me.Close()
                    End If

                Catch ex As Exception 'captura cualquier tipo de errores

                    MsgBox("Existen campos Importantes vacios", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

                End Try 'cierra la sentencia

            End If

        End If

    End Sub

    Private Sub frmConfiguraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            CLASE_GENERAL.cargar_combo("doctores", Me.cmbDoctores, CLASE_GENERAL.mensaje_error)
            Me.cmbDoctores.SelectedValue = 1

            If CLASE_GENERAL.OpcionINI = 1 Then

                CONSUL = New CLASE_CONSULTORIO
                GENE = New CLASE_GENERAL

                CONSUL.p_Idconsultorio = 1
                CONSUL.Seleccionar("logoclinica")

                Me.txtrazonsocial_cons.Text = CLASE_CONSULTORIO.xrazonsocial_cons
                Me.txtnit_cons.Text = CLASE_CONSULTORIO.xnit_cons
                Me.txtdireccion_cons.Text = CLASE_CONSULTORIO.xdireccion_cons
                Me.txtciudad_cons.Text = CLASE_CONSULTORIO.xciudad_cons
                Me.txtweb_cons.Text = CLASE_CONSULTORIO.xweb_cons
                Me.txtemail_cons.Text = CLASE_CONSULTORIO.xemail_cons
                Me.txtactividad_cons.Text = CLASE_CONSULTORIO.xactividad_cons
                Me.txtrtelegal_cons.Text = CLASE_CONSULTORIO.xrtelegal_cons
                Me.txtprofesionrlegal_cons.Text = CLASE_CONSULTORIO.xprofesionrlegal_cons
                Me.txtdocumento_cons.Text = CLASE_CONSULTORIO.xdocumento_cons
                Me.txtciudaddoc_cons.Text = CLASE_CONSULTORIO.xciudaddoc_cons
                Me.txtciudadnacrlegal_cons.Text = CLASE_CONSULTORIO.xciudadnacrlegal_cons
                Me.txttel1_cons.Text = CLASE_CONSULTORIO.xtel1_cons
                Me.txttel2_cons.Text = CLASE_CONSULTORIO.xtel2_cons
                Me.txtcelular_cons.Text = CLASE_CONSULTORIO.xcelular_cons
                Me.txtfax_cons.Text = CLASE_CONSULTORIO.xfax_cons
                Me.cmbDoctores.SelectedValue = CLASE_CONSULTORIO.xIddoctor

                Me.StartTime.Value = New Date(2000, 1, 1, Hour(CLASE_CONSULTORIO.xhoraini), Minute(CLASE_CONSULTORIO.xhoraini), Second(CLASE_CONSULTORIO.xhoraini), 0)
                Me.EndTime.Value = New Date(2000, 1, 1, Hour(CLASE_CONSULTORIO.xhorafin), Minute(CLASE_CONSULTORIO.xhorafin), Second(CLASE_CONSULTORIO.xhorafin), 0)

                If CLASE_CONSULTORIO.xrangocal = "5" Then
                    Me.rbtConfig5min.Checked = True
                ElseIf CLASE_CONSULTORIO.xrangocal = "10" Then
                    Me.rbtConfig10min.Checked = True
                ElseIf CLASE_CONSULTORIO.xrangocal = "15" Then
                    Me.rbtConfig15min.Checked = True
                ElseIf CLASE_CONSULTORIO.xrangocal = "30" Then
                    Me.rbtConfig30min.Checked = True
                End If

                Me.RichTxtPie_Cita.Text = CLASE_CONSULTORIO.xtextopiecita
                Me.RichTxtPie_Rcaja.Text = CLASE_CONSULTORIO.xtextopiercaja
                Me.RichTxtPie_Factura.Text = CLASE_CONSULTORIO.xtextopiefactura
                Me.RichTxtPie_Dian.Text = CLASE_CONSULTORIO.xtextodian

                Me.txtTopeCitas.Text = CLASE_CONSULTORIO.xtopecita

                'Cargamos los Logos de la Clinica desde la base de datos.

                If Not (CLASE_CONSULTORIO.xinicio_cons.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xinicio_cons)
                    Me.pbLogo1.Image = iImagen
                    Me.pbLogo1.SizeMode = PictureBoxSizeMode.Zoom

                    Me.btnBuscarFotos1.Enabled = False
                    Me.btnBorrar1.Enabled = True

                Else

                    Me.btnBuscarFotos1.Enabled = True
                    Me.btnBorrar1.Enabled = False

                End If

                If Not (CLASE_CONSULTORIO.xportada_cons.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xportada_cons)
                    Me.pbLogo2.Image = iImagen
                    Me.pbLogo2.SizeMode = PictureBoxSizeMode.Zoom


                    Me.btnBuscarFotos2.Enabled = False
                    Me.btnBorrar2.Enabled = True

                Else

                    Me.btnBuscarFotos2.Enabled = True
                    Me.btnBorrar2.Enabled = False

                End If

                If Not (CLASE_CONSULTORIO.xicono_cons.Length = 0) Then

                    iImagen = GENE.Bytes_Imagen(CLASE_CONSULTORIO.xicono_cons)
                    Me.pbLogo3.Image = iImagen
                    Me.pbLogo3.SizeMode = PictureBoxSizeMode.Zoom

                    Me.btnBuscarFotos3.Enabled = False
                    Me.btnBorrar3.Enabled = True

                Else

                    Me.btnBuscarFotos3.Enabled = True
                    Me.btnBorrar3.Enabled = False

                End If

                If CLASE_CONSULTORIO.xtipocallcenter_cons = 1 Then

                    Me.rbCallCenter1.Checked = True

                ElseIf CLASE_CONSULTORIO.xtipocallcenter_cons = 2 Then

                    Me.rbCallCenter2.Checked = True

                End If

                'Insertamos los consecutivos de los Documentos
                Me.txtconsecrcaja_cons.Text = CLASE_CONSULTORIO.xconsecrcaja_cons
                Me.txtconsecfactura_cons.Text = CLASE_CONSULTORIO.xconsecfactura_cons
                Me.txtconseccegreso_cons.Text = CLASE_CONSULTORIO.xconseccegreso_cons

                If Mid(CLASE_CONSULTORIO.xformatopos, 1, 1) = "1" Then
                    Me.chkPosRC.Checked = True
                Else
                    Me.chkPosRC.Checked = False
                End If

                If Mid(CLASE_CONSULTORIO.xformatopos, 2, 1) = "1" Then
                    Me.chkPosFac.Checked = True
                Else
                    Me.chkPosFac.Checked = False
                End If

                If Mid(CLASE_CONSULTORIO.xformatopos, 3, 1) = "1" Then
                    Me.chkPosCE.Checked = True
                Else
                    Me.chkPosCE.Checked = False
                End If

                CONSUL.dispose()
                CONSUL = Nothing

                GENE = Nothing
                'Cargamos la Ruta de los backups

                sFicINI = Application.StartupPath & "\config.ini"
                Me.txtRutaBackup.Text = mINI.IniGet(sFicINI, "Rutabackup", "Ruta")


            End If

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("editarconsulta")
            EVEN = Nothing


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub


    Private Sub btnBuscarFotos1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFotos1.Click

        GENE = New CLASE_GENERAL

        OpenFileDialogConfig = New OpenFileDialog
        OpenFileDialogConfig.Filter = "Imágenes JPG (*.jpg)|*.jpg|Mapas de bits (*.bmp)|*.bmp"
        OpenFileDialogConfig.Title = "Abre una imagen JPG o BMP"

        If OpenFileDialogConfig.ShowDialog() = DialogResult.OK Then
            nombreImg = OpenFileDialogConfig.FileName
            pbLogo1.Image = Image.FromFile(nombreImg)
            pbLogo1.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGrabar.Enabled = True

        End If

    End Sub

    Private Sub btnBuscarFotos2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFotos2.Click

        OpenFileDialogConfig = New OpenFileDialog
        OpenFileDialogConfig.Filter = "Imágenes JPG (*.jpg)|*.jpg|Mapas de bits (*.bmp)|*.bmp"
        OpenFileDialogConfig.Title = "Abre una imagen JPG o BMP"

        If OpenFileDialogConfig.ShowDialog() = DialogResult.OK Then

            nombreImg = OpenFileDialogConfig.FileName
            pbLogo2.Image = Image.FromFile(nombreImg)
            pbLogo2.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGrabar.Enabled = True

        End If
    End Sub

    Private Sub btnBuscarFotos3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFotos3.Click

        OpenFileDialogConfig = New OpenFileDialog
        OpenFileDialogConfig.Filter = "Imágenes JPG (*.jpg)|*.jpg|Mapas de bits (*.bmp)|*.bmp"
        OpenFileDialogConfig.Title = "Abre una imagen JPG o BMP"

        If OpenFileDialogConfig.ShowDialog() = DialogResult.OK Then

            nombreImg = OpenFileDialogConfig.FileName
            pbLogo3.Image = Image.FromFile(nombreImg)
            pbLogo3.SizeMode = PictureBoxSizeMode.Zoom

            Me.btnGrabar.Enabled = True

        End If

    End Sub

    Private Sub btnBorrar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar1.Click

        pbLogo1.Image.Dispose()
        pbLogo1.Image = Nothing

        Me.btnBuscarFotos1.Enabled = True
        Me.btnBorrar1.Enabled = False

    End Sub

    Private Sub btnBorrar2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrar2.Click

        pbLogo2.Image.Dispose()
        pbLogo2.Image = Nothing

        Me.btnBuscarFotos2.Enabled = True
        Me.btnBorrar2.Enabled = False

    End Sub

    Private Sub btnBorrar3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBorrar3.Click

        pbLogo3.Image.Dispose()
        pbLogo3.Image = Nothing

        Me.btnBuscarFotos3.Enabled = True
        Me.btnBorrar3.Enabled = False

    End Sub

    Private Sub cmbTipoConsulta_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoConsulta.SelectionChangeCommitted

        Try

            CONSULTA = New CLASE_CONSULTA
            CONSULTA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue

            CONSULTA.Seleccionar("tipoconsulta1")

            Me.txtNomTipoConsulta.Text = CLASE_CONSULTA.xnomconsulta
            Me.lblTipoConsulta.BackColor = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.ceColorConsulta.Color = Color.FromArgb(CLASE_CONSULTA.xcolor)
            Me.cmbespecialidades.SelectedValue = CLASE_CONSULTA.xIdespecialidad

            CONSULTA.dispose()
            CONSULTA = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub


    Private Sub btnConAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConAdicionar.Click

        Try

            If Me.txtNomTipoConsulta.Text = "" Then

                MsgBox("Debe colocarle un nombre al procedimiento", MsgBoxStyle.OkOnly, "Consultas")

            Else

                If CLASE_GENERAL.buscarcolor(Me.ceColorConsulta.Color.ToArgb) >= 1 Then

                    MsgBox("El color que escogio ya esta Utilizado escoja otro por favor", MsgBoxStyle.OkOnly, "Consultas")

                Else

                    CONSULTA = New CLASE_CONSULTA

                    CONSULTA.p_Idtconsulta = CLASE_GENERAL.maximo("Idtconsulta", "tipoconsulta", CLASE_GENERAL.mensaje_error) + 1
                    CONSULTA.p_nomconsulta = Me.txtNomTipoConsulta.Text
                    CONSULTA.p_color = Me.ceColorConsulta.Color.ToArgb
                    CONSULTA.p_Idespecialidad = Me.cmbespecialidades.SelectedValue

                    'Insertamos en la base de datos lo correspondiente a los datos basicos del paciente

                    CONSULTA.Insertar(CLASE_GENERAL.mensaje_error)
                    CONSULTA.dispose() 'Liberamos recursos 
                    CONSULTA = Nothing

                    CLASE_GENERAL.cargar_combo("tipoconsulta", Me.cmbTipoConsulta, CLASE_GENERAL.mensaje_error)
                    Me.cmbTipoConsulta.SelectedValue = CLASE_GENERAL.maximo("Idtconsulta", "tipoconsulta", CLASE_GENERAL.mensaje_error)
                    cmbTipoConsulta_SelectionChangeCommitted(sender, e)

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editarconsulta")
                    EVEN = Nothing

                    '********************************** CARGAMOS LOS TIPOS DE CONSULTA ************************


                    DOC = New CLASE_DOCTORES
                    DOC.p_Iddoctor = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue
                    DOC.Seleccionar("especialidad")

                    CLASE_GENERAL.cargar_combo("tipoconsultadoctores", My.Forms.mdiOrthoSoft.cmbTipoConsulta, CLASE_DOCTORES.xIdespecialidad)

                    DOC.dispose()
                    DOC = Nothing


                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("coloresprocedimientos", Me.dgProcedimientos, CLASE_GENERAL.mensaje_error)
                    GENE = Nothing
                    GRIDSTYLES()

                    Me.dgProcedimientos.ClearSelection()

                    '*************************** CARGAMOS EL CALENDARIO DEL SCHEDULER ********************

                    fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

                    SCHE = New CLASE_SCHEDULER
                    SCHE.llenadoscheduler(fecha)
                    SCHE = Nothing

                    MsgBox("Consulta registrado con Exito", MsgBoxStyle.OkOnly, "Consultas")

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnConModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConModificar.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar La consulta", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Consultas")

            If respuesta = 6 Then

                If Me.txtNomTipoConsulta.Text = "" Then

                    MsgBox("Debe colocarle un nombre al procedimiento", MsgBoxStyle.OkOnly, "Consultas")

                Else


                    CONSULTA = New CLASE_CONSULTA

                    'Modificamos el color a 0 para evitar un error al grabar la modificacion
                    CONSULTA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue
                    auxIdTipoConsulta = cmbTipoConsulta.SelectedValue
                    CONSULTA.p_color = 0
                    CONSULTA.Modificar(CLASE_GENERAL.mensaje_error)

                    'Ahora si modificamos el color pero antes verificamos que no este repetido elcolor que escogimos

                    CONSULTA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue
                    CONSULTA.p_nomconsulta = Me.txtNomTipoConsulta.Text
                    CONSULTA.p_color = Me.ceColorConsulta.Color.ToArgb
                    CONSULTA.p_Idespecialidad = Me.cmbespecialidades.SelectedValue

                    'Insertamos en la base de datos lo correspondiente a los datos basicos del paciente

                    CONSULTA.Modificar(CLASE_GENERAL.mensaje_error)

                    CONSULTA.dispose() 'Liberamos recursos 
                    CONSULTA = Nothing

                    CLASE_GENERAL.cargar_combo("tipoconsulta", Me.cmbTipoConsulta, CLASE_GENERAL.mensaje_error)
                    Me.cmbTipoConsulta.SelectedValue = auxIdTipoConsulta
                    cmbTipoConsulta_SelectionChangeCommitted(sender, e)

                    '********************************** CARGAMOS LOS TIPOS DE CONSULTA ************************

                    DOC = New CLASE_DOCTORES
                    DOC.p_Iddoctor = My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue
                    DOC.Seleccionar("especialidad")

                    CLASE_GENERAL.cargar_combo("tipoconsultadoctores", My.Forms.mdiOrthoSoft.cmbTipoConsulta, CLASE_DOCTORES.xIdespecialidad)

                    DOC.dispose()
                    DOC = Nothing


                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("coloresprocedimientos", Me.dgProcedimientos, CLASE_GENERAL.mensaje_error)
                    GENE = Nothing
                    GRIDSTYLES()

                    Me.dgProcedimientos.ClearSelection()

                    '*************************** CARGAMOS EL CALENDARIO DEL SCHEDULER ********************

                    fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")

                    SCHE = New CLASE_SCHEDULER
                    SCHE.llenadoscheduler(fecha)
                    SCHE = Nothing

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editarconsulta")
                    EVEN = Nothing

                    MsgBox("Consulta modificada con Exito", MsgBoxStyle.OkOnly, "Consultas")


                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnConNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConNuevo.Click

        Me.txtNomTipoConsulta.Text = ""
        Me.cmbespecialidades.SelectedValue = 1
        Me.ceColorConsulta.Color = Color.FromArgb(-1)
        Me.ceColorConsulta.Enabled = True
        Me.ceColorConsulta.Update()


        EVEN = New CLASE_EVENTOS
        EVEN.bloquaerdesbloquear("nuevaconsulta")
        EVEN = Nothing

    End Sub

    Private Sub btnConEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConEliminar.Click

        Dim respuesta As Integer

        respuesta = MsgBox("Esta seguro de Borrar la Consulta, tenga en cuenta que el borrar un procedimiento puede presentar problemas este muy seguro de esta accion ya que podrian presentarse inconsistencias.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Consulta")

        If respuesta = 6 Then

            contar = 0
            contar = CLASE_GENERAL.contar2("Idtconsulta", "citas", Me.cmbTipoConsulta.SelectedValue, CLASE_GENERAL.mensaje_error)

            If contar = 0 Or Me.cmbTipoConsulta.SelectedValue <> 3 Then

                CONSULTA = New CLASE_CONSULTA
                CONSULTA.p_Idtconsulta = Me.cmbTipoConsulta.SelectedValue

                CONSULTA.Eliminar(CLASE_GENERAL.mensaje_error)
                CONSULTA.dispose() 'Liberamos recursos 
                CONSULTA = Nothing

                'Cargamos los datos nuevamente en los controles 
                CLASE_GENERAL.cargar_combo("tipoconsulta", Me.cmbTipoConsulta, CLASE_GENERAL.mensaje_error)
                cmbTipoConsulta_SelectionChangeCommitted(sender, e)

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("coloresprocedimientos", Me.dgProcedimientos, CLASE_GENERAL.mensaje_error)
                GENE = Nothing
                GRIDSTYLES()

                Me.dgProcedimientos.ClearSelection()
                '***********************************

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarconsulta")
                EVEN = Nothing

                MsgBox("Consulta Eliminada con Exito", MsgBoxStyle.OkOnly, "Consultas")

            Else

                MsgBox("El tipo de Consulta no se puede Eliminar, ya fue asiganda a una cita", MsgBoxStyle.Critical, "Consultas")

            End If


        End If

    End Sub

    Private Sub dgProcedimientos_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgProcedimientos.CellFormatting

        If Me.dgProcedimientos.Columns(e.ColumnIndex).Name.Equals("color") Then

            e.CellStyle.BackColor = Color.FromArgb(e.Value)
            e.CellStyle.ForeColor = Color.FromArgb(e.Value)
            e.CellStyle.SelectionBackColor = Color.FromArgb(e.Value)
            e.CellStyle.SelectionForeColor = Color.FromArgb(e.Value)

        End If

    End Sub


    Private Sub TabControl_Consultorio_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles TabControl_Consultorio.SelectedTabChanged


        If TabControl_Consultorio.SelectedTab.Text = "Procedimientos" Then

            Me.btnGrabar.Visible = False
            Me.Refresh()

            'Cargamos los Procedimientos Clinicos

            '********************************** CARGAMOS LOS TIPOS DE CONSULTA ************************

            'Cargamos las Especialidades
            CLASE_GENERAL.cargar_combo("especialidades", Me.cmbespecialidades, CLASE_GENERAL.mensaje_error)
            Me.cmbespecialidades.SelectedValue = 1

            'Cargamos los Tipos de consulta
            CLASE_GENERAL.cargar_combo("tipoconsulta", Me.cmbTipoConsulta, CLASE_GENERAL.mensaje_error)
            Me.cmbTipoConsulta.SelectedValue = 1
            cmbTipoConsulta_SelectionChangeCommitted(sender, e)

            
            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("coloresprocedimientos", Me.dgProcedimientos, CLASE_GENERAL.mensaje_error)
            GENE = Nothing
            GRIDSTYLES()

            Me.dgProcedimientos.ClearSelection()

        ElseIf TabControl_Consultorio.SelectedTab.Text = "Operadores Cel" Then

            Me.btnGrabar.Visible = False
            Me.Refresh()

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("operadorescel", Me.dgOperadorCel, CLASE_GENERAL.mensaje_error)
            GENE = Nothing
            GRIDSTYLES2()

            Me.dgOperadorCel.ClearSelection()

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevooperador")
            EVEN.limpiar("limpiaroperador")
            EVEN = Nothing

            Me.txtIdoperador.Text = CLASE_GENERAL.maximo("Idoperador", "operadorcel", CLASE_GENERAL.mensaje_error) + 1


        ElseIf TabControl_Consultorio.SelectedTab.Text = "Especialidades" Then

            Me.btnGrabar.Visible = False
            Me.Refresh()

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("especialidades", Me.dgEspecialidades, CLASE_GENERAL.mensaje_error)
            GENE = Nothing
            GRIDSTYLES3()

            Me.dgEspecialidades.ClearSelection()

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevaespecialidad")
            EVEN.limpiar("limpiarespecialidad")
            EVEN = Nothing

            Me.txtIdespecialidad.Text = CLASE_GENERAL.maximo("Idespecialidad", "especialidades", CLASE_GENERAL.mensaje_error) + 1

        ElseIf TabControl_Consultorio.SelectedTab.Text = "Unidades" Then

            'Cargamos las Unidades creadas
            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("unidades", Me.dgUnidades, CLASE_GENERAL.mensaje_error)
            GENE = Nothing
            GRIDSTYLES4()

            Me.dgUnidades.ClearSelection()

            'Cargamos las Los estados de las unidades
            CLASE_GENERAL.cargar_combo("estadounidades", Me.cmbIdestado, CLASE_GENERAL.mensaje_error)
            Me.cmbespecialidades.SelectedValue = 1

            'Cargamos las Especialidades
            CLASE_GENERAL.cargar_combo("especialidades", Me.cmbIdespecialidad, CLASE_GENERAL.mensaje_error)
            Me.cmbIdespecialidad.SelectedValue = 1

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevaunidad")
            EVEN.limpiar("limpiarunidad")
            EVEN = Nothing

            Me.txtIdunidad.Text = CLASE_GENERAL.maximo("Idunidad", "unidades", CLASE_GENERAL.mensaje_error) + 1

        Else

            Me.btnGrabar.Visible = True
            Me.Refresh()

        End If

    End Sub

    Private Sub actualizarespecialidad()

        Me.txtIdespecialidad.Text = Me.dgEspecialidades.CurrentRow.Cells("Idespecialidad").Value
        Me.txtnom_especialidad.Text = Me.dgEspecialidades.CurrentRow.Cells("nom_especialidad").Value

        EVEN = New CLASE_EVENTOS
        EVEN.bloquaerdesbloquear("editarespecialidad")
        EVEN = Nothing

        Me.txtIdespecialidad.ReadOnly = True

    End Sub

    Private Sub actualizaroperador()

        Me.txtIdoperador.Text = Me.dgOperadorCel.CurrentRow.Cells("Idoperador").Value
        Me.txtnom_oper.Text = Me.dgOperadorCel.CurrentRow.Cells("nom_oper").Value
        Me.txtdominio_oper.Text = Me.dgOperadorCel.CurrentRow.Cells("dominio_oper").Value

        EVEN = New CLASE_EVENTOS
        EVEN.bloquaerdesbloquear("editaroperador")
        EVEN = Nothing

        Me.txtIdoperador.ReadOnly = True

    End Sub

    Private Sub actualizarunidad()

        Me.txtIdunidad.Text = Me.dgUnidades.CurrentRow.Cells("Idunidad").Value
        Me.cmbIdestado.Text = Me.dgUnidades.CurrentRow.Cells("nom_estado").Value
        Me.txtnom_unidad.Text = Me.dgUnidades.CurrentRow.Cells("nom_unidad").Value
        Me.cmbIdespecialidad.Text = Me.dgUnidades.CurrentRow.Cells("nom_especialidad").Value

        EVEN = New CLASE_EVENTOS
        EVEN.bloquaerdesbloquear("editarunidad")
        EVEN = Nothing

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

            With Me.dgProcedimientos

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 70

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "CONSULTA"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 320

                .Columns(2).DefaultCellStyle = Style2
                .Columns(2).HeaderText = "COLOR"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 80

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "ESPECIALIDAD"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 150

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

            With Me.dgOperadorCel

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 70

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "OPERADOR"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 90

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "DOMINIO"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 290

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

            With Me.dgEspecialidades

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 70

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "ESPECIALIDAD"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 200


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

            With Me.dgUnidades

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(0).Width = 70

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "NOMBRE"
                .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(1).Width = 200

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "ESPECIALIDAD"
                .Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(2).Width = 200

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "ESTADO"
                .Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(3).Width = 200



            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia



    End Sub

    Private Sub dgProcedimientos_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProcedimientos.CellEnter

        actualizarprocedimiento()

    End Sub

    Private Sub actualizarprocedimiento()

        Me.txtNomTipoConsulta.Text = Me.dgProcedimientos.CurrentRow.Cells("nomconsulta").Value
        Me.ceColorConsulta.Color = Color.FromArgb(Me.dgProcedimientos.CurrentRow.Cells("Color").Value)
        Me.cmbTipoConsulta.SelectedValue = Me.dgProcedimientos.CurrentRow.Cells("Idtconsulta").Value
        Me.lblTipoConsulta.BackColor = Color.FromArgb(Me.dgProcedimientos.CurrentRow.Cells("Color").Value)
        Me.cmbespecialidades.Text = Me.dgProcedimientos.CurrentRow.Cells("nom_especialidad").Value

    End Sub

    Private Sub cmbTipoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoConsulta.SelectedIndexChanged

        Try

            ' Buscarlo en el DataGridView (de forma manual, no conozco otra forma...)
            ' Eliminar las selecciones anteriores

            Me.dgProcedimientos.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.dgProcedimientos.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("Idtconsulta").Value Is Nothing _
                OrElse fila.Cells Is Nothing Then
                    Continue For
                End If

                ' En este ejemplo, el formato es Apellidos, Nombre
                Dim Idtconsulta As String
                Idtconsulta = Me.cmbTipoConsulta.SelectedValue.ToString

                If Idtconsulta = fila.Cells("Idtconsulta").Value.ToString Then
                    ' Seleccionamos la fila
                    Me.dgProcedimientos.Rows(fila.Index).Selected = True
                    ' nos aseguramos de que sea visible
                    Me.dgProcedimientos.FirstDisplayedScrollingRowIndex = fila.Index

                    Exit For
                End If
            Next


        Catch ex As System.NullReferenceException

            MsgBox("No selecciono ningún Paciente, intentelo nuevamente por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pacientes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

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

        'Datos Consultorio
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpConsultorio)
        ubicarcontrol(Me.gpDoctor)
        ubicarcontrol(Me.btnAdicionar)
        ubicarcontrol(Me.btnGrabar)
        ubicarcontrol(Me.btnSalir)

        'Config programa
        ubicarcontrol(Me.gpCallCenter)
        ubicarcontrol(Me.gpRutabackup)
        ubicarcontrol(Me.gpTopeCitas)
        ubicarcontrol(Me.gpHorarioLaboral)
        ubicarcontrol(Me.gpRangoAgenda)

        'Textos
        ubicarcontrol(Me.gpTextoPieCitas)
        ubicarcontrol(Me.gpTextoPieRcaja)
        ubicarcontrol(Me.gpTextoPieFac)
        ubicarcontrol(Me.gpTextoPieRDian)

        'logos
        ubicarcontrol(Me.gpLogoInicial)
        ubicarcontrol(Me.gpLogoPresEmpresa)
        ubicarcontrol(Me.gpLogoLoguito)
        ubicarcontrol(Me.btnBuscarFotos1)
        ubicarcontrol(Me.btnBuscarFotos2)
        ubicarcontrol(Me.btnBuscarFotos3)
        ubicarcontrol(Me.btnBorrar1)
        ubicarcontrol(Me.btnBorrar2)
        ubicarcontrol(Me.btnBorrar3)

        'Procedimientos
        ubicarcontrol(Me.lblTituloVentana2)
        ubicarcontrol(Me.gpProcedimiento)
        ubicarcontrol(Me.dgProcedimientos)
        ubicarcontrol(Me.btnConAdicionar)
        ubicarcontrol(Me.btnConModificar)
        ubicarcontrol(Me.btnConNuevo)
        ubicarcontrol(Me.btnConEliminar)
        ubicarcontrol(Me.gpConsultas)

        'Consecutivos
        ubicarcontrol(Me.gpConsecutivos)
        ubicarcontrol(Me.lblOperadoresCel)

        'Operadores de Celular
        ubicarcontrol(Me.lblOperadoresCel)
        ubicarcontrol(Me.gpOperadoresCel)

        'Especialidades
        ubicarcontrol(Me.gpEspecialidades)
        ubicarcontrol(Me.lblEspecialidades)

        'Unidades
        ubicarcontrol(Me.gpUnidades)
        ubicarcontrol(Me.lblUnidades)

        
    End Sub

    Private Sub frmConfiguraciones_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

   
    Private Sub btnAdicionarEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarEsp.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdespecialidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdespecialidad, "Escriba el Codigo del Item Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdespecialidad), MsgBoxStyle.OkOnly, "Especialidades")
                Me.txtIdespecialidad.Focus()

            ElseIf Me.txtnom_especialidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnom_especialidad, "Escriba el Nombre de la Especialidad por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnom_especialidad), MsgBoxStyle.OkOnly, "Especialidades")
                Me.txtnom_especialidad.Focus()

            Else


                ESP = New CLASE_ESPECIALIDADES

                ESP.p_Idespecialidad = Me.txtIdespecialidad.Text
                ESP.p_nom_especialidad = Me.txtnom_especialidad.Text

                ESP.Insertar(CLASE_GENERAL.mensaje_error)

                ESP.dispose()
                ESP = Nothing

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("especialidades", Me.dgEspecialidades, CLASE_GENERAL.mensaje_error)
                GENE = Nothing

                GRIDSTYLES3()

                Me.dgEspecialidades.Rows(Me.dgEspecialidades.Rows.Count - 1).Selected = True

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarespecialidad")
                EVEN = Nothing

                Me.txtIdespecialidad.ReadOnly = True

                MsgBox("Especialidad Ingresada con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Especialidades")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub dgEspecialidades_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEspecialidades.CellEnter

        actualizarespecialidad()

    End Sub

    Private Sub btnModificarEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarEsp.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Modificar el Item", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Gastos")

            If respuesta = MsgBoxResult.Yes Then


                '********** PARPADEO DE ERROR PROVIDER ***********************

                Me.ErrorProvider.BlinkRate = 200
                Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

                '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

                If Me.txtIdespecialidad.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtIdespecialidad, "Escriba el Codigo del Item Por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtIdespecialidad), MsgBoxStyle.OkOnly, "Especialidades")
                    Me.txtIdespecialidad.Focus()

                ElseIf Me.txtnom_especialidad.Text.Length = 0 Then
                    ErrorProvider.SetError(Me.txtnom_especialidad, "Escriba el Nombre de la Especialidad por favor")
                    MsgBox(ErrorProvider.GetError(Me.txtnom_especialidad), MsgBoxStyle.OkOnly, "Especialidades")
                    Me.txtnom_especialidad.Focus()



                Else

                    ESP = New CLASE_ESPECIALIDADES

                    ESP.p_Idespecialidad = Me.txtIdespecialidad.Text
                    ESP.p_nom_especialidad = Me.txtnom_especialidad.Text

                    ESP.Modificar(CLASE_GENERAL.mensaje_error)

                    ESP.dispose()
                    ESP = Nothing

                    GENE = New CLASE_GENERAL
                    GENE.Cargar_Grilla("especialidades", Me.dgEspecialidades, CLASE_GENERAL.mensaje_error)
                    GENE = Nothing

                    GRIDSTYLES3()

                    Me.dgEspecialidades.Rows(Me.dgEspecialidades.Rows.Count - 1).Selected = True

                    EVEN = New CLASE_EVENTOS
                    EVEN.bloquaerdesbloquear("editarespecialidad")
                    EVEN = Nothing

                    Me.txtIdespecialidad.ReadOnly = True

                    MsgBox("Especialidad Modificada con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Especialidades")

                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnNuevaEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaEsp.Click

        Try

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevaespecialidad")
            EVEN.limpiar("limpiarespecialidad")
            EVEN = Nothing

            Me.txtIdespecialidad.Text = CLASE_GENERAL.maximo("Idespecialidad", "especialidades", CLASE_GENERAL.mensaje_error) + 1
            Me.txtIdespecialidad.ReadOnly = True

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnEliminarEsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarEsp.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Eliminar el Item", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Especialidades")

            If respuesta = MsgBoxResult.Yes Then


                ESP = New CLASE_ESPECIALIDADES
                ESP.p_Idespecialidad = Me.txtIdespecialidad.Text

                ESP.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("nuevaespecialidad")
                EVEN.limpiar("limpiarespecialidad")
                EVEN = Nothing

                Me.txtIdespecialidad.Text = CLASE_GENERAL.maximo("Idespecialidad", "especialidades", CLASE_GENERAL.mensaje_error) + 1

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("especialidades", Me.dgEspecialidades, CLASE_GENERAL.mensaje_error)

                GRIDSTYLES()

                Me.dgEspecialidades.ClearSelection()

                GENE = Nothing

                Me.txtIdespecialidad.ReadOnly = True

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub dgOperadorCel_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgOperadorCel.CellEnter

        actualizaroperador()

    End Sub

    Private Sub txtnom_especialidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom_especialidad.TextChanged

        Me.ErrorProvider.SetError(Me.txtnom_especialidad, "")

    End Sub

    Private Sub txtnom_oper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnom_oper.TextChanged

        Me.ErrorProvider.SetError(Me.txtnom_oper, "")

    End Sub

    Private Sub txtdominio_oper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdominio_oper.TextChanged

        Me.ErrorProvider.SetError(Me.txtdominio_oper, "")

    End Sub

    Private Sub btnAdicionarCel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarCel.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdoperador.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdoperador, "Escriba el Codigo del Operador Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdoperador), MsgBoxStyle.OkOnly, "Operador Celular")
                Me.txtIdoperador.Focus()

            ElseIf Me.txtnom_oper.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnom_oper, "Escriba el nombre del Operador por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnom_oper), MsgBoxStyle.OkOnly, "Operador celular")
                Me.txtnom_oper.Focus()

            ElseIf Me.txtdominio_oper.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtdominio_oper, "Escriba el dominio del Operador por favor")
                MsgBox(ErrorProvider.GetError(Me.txtdominio_oper), MsgBoxStyle.OkOnly, "Operador celular")
                Me.txtdominio_oper.Focus()

            Else

                OPERADOR = New CLASE_OPERADOR

                OPERADOR.p_Idoperador = Me.txtIdoperador.Text()
                OPERADOR.p_nom_oper = Me.txtnom_oper.Text
                OPERADOR.p_dominio_oper = Me.txtdominio_oper.Text

                OPERADOR.Insertar(CLASE_GENERAL.mensaje_error)

                OPERADOR.dispose()
                OPERADOR = Nothing

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("operadorescel", Me.dgOperadorCel, CLASE_GENERAL.mensaje_error)
                GENE = Nothing

                GRIDSTYLES2()

                Me.dgOperadorCel.Rows(Me.dgOperadorCel.Rows.Count - 1).Selected = True

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editaroperador")
                EVEN = Nothing

                Me.txtIdoperador.ReadOnly = True

                MsgBox("Operador Ingresado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Operador Celular")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnModificarCel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarCel.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdoperador.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdoperador, "Escriba el Codigo del Operador Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdoperador), MsgBoxStyle.OkOnly, "Operador Celular")
                Me.txtIdoperador.Focus()

            ElseIf Me.txtnom_oper.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnom_oper, "Escriba el nombre del Operador por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnom_oper), MsgBoxStyle.OkOnly, "Operador celular")
                Me.txtnom_oper.Focus()

            ElseIf Me.txtdominio_oper.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtdominio_oper, "Escriba el dominio del Operador por favor")
                MsgBox(ErrorProvider.GetError(Me.txtdominio_oper), MsgBoxStyle.OkOnly, "Operador celular")
                Me.txtdominio_oper.Focus()

            Else

                OPERADOR = New CLASE_OPERADOR

                OPERADOR.p_Idoperador = Me.txtIdoperador.Text()
                OPERADOR.p_nom_oper = Me.txtnom_oper.Text
                OPERADOR.p_dominio_oper = Me.txtdominio_oper.Text

                OPERADOR.Modificar(CLASE_GENERAL.mensaje_error)

                OPERADOR.dispose()
                OPERADOR = Nothing

                nfila = Me.dgOperadorCel.CurrentRow.Index

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("operadorescel", Me.dgOperadorCel, CLASE_GENERAL.mensaje_error)
                GENE = Nothing

                GRIDSTYLES2()

                Me.dgOperadorCel.Rows(nfila).Selected = True

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editaroperador")
                EVEN = Nothing

                Me.txtIdoperador.ReadOnly = True

                MsgBox("Operador Modificado con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Operador Celular")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnNuevoCel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCel.Click

        Try

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevooperador")
            EVEN.limpiar("limpiaroperador")
            EVEN = Nothing

            Me.txtIdoperador.Text = CLASE_GENERAL.maximo("Idoperador", "operadorcel", CLASE_GENERAL.mensaje_error) + 1
            Me.txtIdoperador.ReadOnly = True

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnEliminarCel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCel.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Eliminar el Operador", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Operador Celular")

            If respuesta = MsgBoxResult.Yes Then


                OPERADOR = New CLASE_OPERADOR
                OPERADOR.p_Idoperador = Me.txtIdoperador.Text

                OPERADOR.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("nuevooperador")
                EVEN.limpiar("limpiaroperador")
                EVEN = Nothing

                Me.txtIdoperador.Text = CLASE_GENERAL.maximo("Idoperador", "operadorcel", CLASE_GENERAL.mensaje_error) + 1

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("operadorescel", Me.dgOperadorCel, CLASE_GENERAL.mensaje_error)
                GENE = Nothing

                GRIDSTYLES()

                Me.dgOperadorCel.ClearSelection()

                Me.txtIdoperador.ReadOnly = True

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnAdicionarUni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarUni.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdunidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdunidad, "Escriba el Codigo de la Unidad Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdunidad), MsgBoxStyle.OkOnly, "Unidades")
                Me.txtIdunidad.Focus()

            ElseIf Me.txtnom_unidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnom_unidad, "Escriba el nombre de la Unidad por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnom_unidad), MsgBoxStyle.OkOnly, "Unidades")
                Me.txtnom_unidad.Focus()

            ElseIf Me.cmbIdestado.Text.Length = 0 Then
                ErrorProvider.SetError(Me.cmbIdestado, "Escoja el Estado de la Unidad")
                MsgBox(ErrorProvider.GetError(Me.cmbIdestado), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Unidades")
                Me.cmbIdestado.Focus()

            ElseIf Me.cmbIdespecialidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.cmbIdespecialidad, "Escoja la Especialidad de la Unidad")
                MsgBox(ErrorProvider.GetError(Me.cmbIdespecialidad), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Unidades")
                Me.cmbIdespecialidad.Focus()

            Else

                UNIDAD = New CLASE_UNIDADES

                UNIDAD.p_Idunidad = Me.txtIdunidad.Text
                UNIDAD.p_Idestado = Me.cmbIdestado.SelectedValue
                UNIDAD.p_nom_unidad = Me.txtnom_unidad.Text
                UNIDAD.p_Idespecialidad = Me.cmbIdespecialidad.SelectedValue

                UNIDAD.Insertar(CLASE_GENERAL.mensaje_error)

                UNIDAD.dispose()
                UNIDAD = Nothing

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("unidades", Me.dgUnidades, CLASE_GENERAL.mensaje_error)
                GENE = Nothing

                GRIDSTYLES4()

                Me.dgUnidades.Rows(Me.dgUnidades.Rows.Count - 1).Selected = True

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarunidad")
                EVEN = Nothing

                MsgBox("Unidad Ingresada con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Unidades")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub btnModificarUni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarUni.Click

        Try

            '********** PARPADEO DE ERROR PROVIDER ***********************

            Me.ErrorProvider.BlinkRate = 200
            Me.ErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink

            '*********** VERIFICAMOS QUE SE INGRESEN LOS DATOS ***********

            If Me.txtIdunidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtIdunidad, "Escriba el Codigo de la Unidad Por favor")
                MsgBox(ErrorProvider.GetError(Me.txtIdunidad), MsgBoxStyle.OkOnly, "Unidades")
                Me.txtIdunidad.Focus()

            ElseIf Me.txtnom_unidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.txtnom_unidad, "Escriba el nombre de la Unidad por favor")
                MsgBox(ErrorProvider.GetError(Me.txtnom_unidad), MsgBoxStyle.OkOnly, "Unidades")
                Me.txtnom_unidad.Focus()

            ElseIf Me.cmbIdestado.Text.Length = 0 Then
                ErrorProvider.SetError(Me.cmbIdestado, "Escoja el Estado de la Unidad")
                MsgBox(ErrorProvider.GetError(Me.cmbIdestado), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Unidades")
                Me.cmbIdestado.Focus()

            ElseIf Me.cmbIdespecialidad.Text.Length = 0 Then
                ErrorProvider.SetError(Me.cmbIdespecialidad, "Escoja la Especialidad de la Unidad")
                MsgBox(ErrorProvider.GetError(Me.cmbIdespecialidad), MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Unidades")
                Me.cmbIdespecialidad.Focus()

            Else

                UNIDAD = New CLASE_UNIDADES

                UNIDAD.p_Idunidad = Me.txtIdunidad.Text
                UNIDAD.p_Idestado = Me.cmbIdestado.SelectedValue
                UNIDAD.p_nom_unidad = Me.txtnom_unidad.Text
                UNIDAD.p_Idespecialidad = Me.cmbIdespecialidad.SelectedValue

                UNIDAD.Modificar(CLASE_GENERAL.mensaje_error)

                UNIDAD.dispose()
                UNIDAD = Nothing

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("unidades", Me.dgUnidades, CLASE_GENERAL.mensaje_error)
                GENE = Nothing

                GRIDSTYLES4()

                Me.dgUnidades.Rows(Me.dgUnidades.Rows.Count - 1).Selected = True

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("editarunidad")
                EVEN = Nothing

                MsgBox("Unidad Modificada con Exito.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Unidades")

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try
    End Sub

    Private Sub btnEliminarUni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarUni.Click

        Try

            Dim respuesta As Integer

            respuesta = MsgBox("Esta seguro de Eliminar la Unidad", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Unidades")

            If respuesta = MsgBoxResult.Yes Then


                UNIDAD = New CLASE_UNIDADES
                UNIDAD.p_Idunidad = Me.txtIdunidad.Text

                UNIDAD.Eliminar(CLASE_GENERAL.mensaje_error)

                EVEN = New CLASE_EVENTOS
                EVEN.bloquaerdesbloquear("nuevaunidad")
                EVEN.limpiar("limpiarunidad")
                EVEN = Nothing

                Me.txtIdunidad.Text = CLASE_GENERAL.maximo("Idunidad", "unidades", CLASE_GENERAL.mensaje_error) + 1

                GENE = New CLASE_GENERAL
                GENE.Cargar_Grilla("unidades", Me.dgUnidades, CLASE_GENERAL.mensaje_error)

                GRIDSTYLES4()

                Me.dgUnidades.ClearSelection()

                GENE = Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try


    End Sub

    Private Sub btnNuevaUni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaUni.Click

        Try

            EVEN = New CLASE_EVENTOS
            EVEN.bloquaerdesbloquear("nuevaunidad")
            EVEN.limpiar("limpiarunidad")
            EVEN = Nothing

            Me.txtIdunidad.Text = CLASE_GENERAL.maximo("Idunidad", "unidades", CLASE_GENERAL.mensaje_error) + 1
            
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try

    End Sub

    Private Sub dgUnidades_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUnidades.CellEnter

        actualizarunidad()

    End Sub
End Class