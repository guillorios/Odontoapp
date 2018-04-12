Imports System.Math


Public Class frmConvertirTabla

    Private PAC As CLASE_PACIENTES
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS
    Private GENEX As CLASE_GENERAL_EXCEL
    Private GENE As CLASE_GENERAL

    Private iImagen As Image
    Private SourceToImage As Bitmap


    Public i As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click

        Dim i As Integer

        Try


            With Me.OpenFileExcel
                ' Vea btnRetriveFileNames_Click para obtener una explicación de los valores predeterminados
                ' de las propiedades.

                ' Comprobar que el archivo seleccionado existe. El cuadro de diálogo muestra
                ' una advertencia en caso contrario.
                .CheckFileExists = True

                ' Comprobar que la ruta de acceso seleccionada existe. El cuadro de diálogo muestra 
                ' una advertencia en caso contrario.
                .CheckPathExists = True

                ' Obtener o establecer una extensión predeterminada. No incluye el "." inicial.
                .DefaultExt = "xls"

                ' ¿Devolver el archivo al que hace referencia un vínculo? Si False, devuelve el archivo de vínculo
                ' seleccionado. Si True, devuelve el archivo vinculado al archivo LNK.
                .DereferenceLinks = True

                ' Al igual que en VB6, utilice un conjunto de pares de filtros, separados por "|". Cada
                ' par consta de una especificación descripción|archivo. Utilice "|" entre los pares. No es necesario
                ' poner "|" al final. Puede establecer la propiedad FilterIndex también, para seleccionar el
                ' filtro predeterminado. El primer filtro tiene el número 1 (no 0). El valor predeterminado es 1. 
                .Filter = "Archivos de Hoja de Calculo (*.xls)|*.xls"

                .InitialDirectory = "Mis Documentos"

                ' ¿Restaurar el directorio original después de seleccionar
                ' un archivo? Si False, el directorio actual cambia
                ' al directorio en el que seleccionó el archivo.
                ' Establézcalo como True para poner la carpeta actual de nuevo
                ' donde estaba cuando comenzó.
                ' El valor predeterminado es False.
                .RestoreDirectory = True

                ' ¿Mostrar el botón Ayuda y la casilla de verificación Sólo lectura?
                .ShowHelp = False


                ' ¿Comenzar con la casilla de verificación Sólo lectura activada?
                ' Esto sólo tiene sentido si ShowReadOnly es True.

                .Title = "Seleccione Un Archivo de Excel  "

                ' ¿Aceptar sólo nombres de archivo Win32 válidos?
                .ValidateNames = True

                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                    Dim respuesta As Integer
                    respuesta = MsgBox("Esta Seguro de Cargar El Archivo La Base de Datos?, esto implica el reemplazo de los registros con el archivo seleccionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cargar Excel")

                    If respuesta = 6 Then

                        GENEX = New CLASE_GENERAL_EXCEL
                        PAC = New CLASE_PACIENTES
                        CON = New CLASE_CONTACTOS
                        NOTA = New CLASE_NOTAS

                        CLASE_GENERAL_EXCEL.iniciar(CLASE_GENERAL.mensaje_error, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= '" & .FileName & "';Persist Security Info=False; Extended Properties=Excel 8.0;")
                        GENEX.seleccionar_tabla(CLASE_GENERAL_EXCEL.exmensaje_error)

                        For i = 0 To CLASE_GENERAL_EXCEL.exdt.Rows.Count - 1

                            '**************************** MODULO PARA INGRESO DEL PACIENTE BASE DE DATOS  MYSQL *******************************

                            PAC.p_IdPaciente = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident")


                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("apellidos") IsNot DBNull.Value Then
                                PAC.p_apellidos_pac = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("apellidos")
                            Else
                                PAC.p_apellidos_pac = ""
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("nombres") IsNot DBNull.Value Then
                                PAC.p_nombres_pac = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("nombres")
                            Else
                                PAC.p_nombres_pac = ""
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("residencia") IsNot DBNull.Value Then
                                PAC.p_residencia_pac = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("residencia")
                            Else
                                PAC.p_residencia_pac = ""
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("oficina") IsNot DBNull.Value Then
                                PAC.p_oficina_pac = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("oficina")
                            Else
                                PAC.p_oficina_pac = ""
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("FECHA_ING") IsNot DBNull.Value Then
                                PAC.p_fecingreso_pac = Format(CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("FECHA_ING"), "yyyy-MM-dd")
                            Else
                                PAC.p_fecingreso_pac = Format(Now(), "yyyy-MM-dd")
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ocupacion") IsNot DBNull.Value Then
                                PAC.p_ocupacion_pac = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ocupacion")
                            Else
                                PAC.p_ocupacion_pac = ""
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("referido") IsNot DBNull.Value Then
                                PAC.p_referidopor_pac = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("referido")
                            Else
                                PAC.p_referidopor_pac = ""
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("FECHA_NAC") IsNot DBNull.Value Then
                                PAC.p_fecnac_pac = Format(CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("FECHA_NAC"), "yyyy-MM-dd")
                            Else
                                PAC.p_fecnac_pac = Format(Now(), "yyyy-MM-dd")
                            End If

                            PAC.p_tipodoc_pac = 2

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ID") IsNot DBNull.Value Then
                                PAC.p_numdoc_pac = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ID")
                            Else
                                PAC.p_numdoc_pac = ""
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("SEXO") = 0 Then
                                PAC.p_sexo_pac = "M"
                            Else
                                PAC.p_sexo_pac = "F"
                            End If

                            PAC.p_Identidad = 0

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NO_AFILIACION") Is DBNull.Value Then
                                PAC.p_nhclinica = 0
                            Else
                                PAC.p_nhclinica = Int(CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NO_AFILIACION"))
                            End If

                            PAC.p_Idestado_pac = 1

                            PAC.Insertar(CLASE_GENERAL.mensaje_error)

                            '**************************** MODULO PARA INGRESO DE LOS CONTACTOS *******************************

                            CON.p_IdUsuario = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident")
                            CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                            CON.p_IdTTutor = 5 ' Utilizamos 5 Porque son los datos correspondientes al paciente mismo

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("tel_res") Is DBNull.Value Then
                                CON.p_telcasa_con = ""
                            Else
                                CON.p_telcasa_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("tel_res")
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("tel_of") Is DBNull.Value Then
                                CON.p_teloficina_con = ""
                            Else
                                CON.p_teloficina_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("tel_of")
                            End If

                            CON.p_fax_con = ""

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("celular") Is DBNull.Value Then
                                CON.p_cel_con = ""
                            Else
                                CON.p_cel_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("celular")
                            End If

                            CON.p_email_con = ""
                            CON.p_web_con = ""

                            CON.Insertar(CLASE_GENERAL.mensaje_error)

                            CON.p_IdUsuario = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident")
                            CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                            CON.p_IdTTutor = 1 ' Utilizamos 1 Porque son los datos correspondientes al Padre del Paciente

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NOMBRE_PAPA") Is DBNull.Value Then
                                CON.p_nom_con = ""
                            Else
                                CON.p_nom_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NOMBRE_PAPA")
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("TELEFONO_PAPA") Is DBNull.Value Then
                                CON.p_telcasa_con = ""
                            Else
                                CON.p_telcasa_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("TELEFONO_PAPA")
                            End If

                            CON.p_cel_con = ""
                            CON.p_ocu_con = ""

                            CON.Insertar(CLASE_GENERAL.mensaje_error)

                            CON.p_IdUsuario = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident")
                            CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                            CON.p_IdTTutor = 2 ' Utilizamos 2 Porque son los datos correspondientes la Madre del Paciente

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NOMBRE_MAMA") Is DBNull.Value Then
                                CON.p_nom_con = ""
                            Else
                                CON.p_nom_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NOMBRE_MAMA")
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("TELEFONO_MAMA") Is DBNull.Value Then
                                CON.p_telcasa_con = ""
                            Else
                                CON.p_telcasa_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("TELEFONO_MAMA")
                            End If

                            CON.p_cel_con = ""
                            CON.p_ocu_con = ""

                            CON.Insertar(CLASE_GENERAL.mensaje_error)

                            CON.p_IdUsuario = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident")
                            CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                            CON.p_IdTTutor = 3 ' Utilizamos 3 Porque son los datos correspondientes al Acudiente del Paciente

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NOMBRE_ACUDIENTE") Is DBNull.Value Then
                                CON.p_nom_con = ""
                            Else
                                CON.p_nom_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("NOMBRE_ACUDIENTE")
                            End If

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("TELEFONO_ACUDIENTE") Is DBNull.Value Then
                                CON.p_telcasa_con = ""
                            Else
                                CON.p_telcasa_con = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("TELEFONO_ACUDIENTE")
                            End If

                            CON.p_cel_con = ""
                            CON.p_ocu_con = ""

                            CON.Insertar(CLASE_GENERAL.mensaje_error)

                            CON.p_IdUsuario = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident")
                            CON.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente
                            CON.p_IdTTutor = 4 ' Utilizamos 4 Porque son los datos correspondientes al Conyuge del Paciente
                            CON.p_nom_con = ""
                            CON.p_telcasa_con = ""
                            CON.p_cel_con = ""
                            CON.p_ocu_con = ""

                            CON.Insertar(CLASE_GENERAL.mensaje_error)

                            '**************************** MODULO PARA INGRESO DE LAS NOTAS Y LA FOTOGRAFIA *******************************

                            NOTA.p_IdUsuario = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident")
                            NOTA.p_IdTUsuario = 1 ' Utilizamos uno porque es de tipo Paciente

                            If CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("notas") IsNot DBNull.Value Then
                                NOTA.p_nota = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("notas")
                            Else
                                NOTA.p_nota = ""
                            End If

                            'Me.pbFoto_pac.Image.Save(Clase_general.rutaimagenes & Clase_general_excel.exdt.Rows(i).Item("Id1") & "pac" & ".bmp")
                            'Me.pbFoto_pac.ImageLocation = Clase_general.rutaimagenes & Clase_general_excel.exdt.Rows(i).Item("Id1") & "pac" & ".bmp"

                            NOTA.p_foto = CLASE_GENERAL_EXCEL.exdt.Rows(i).Item("ident") & "pac"

                            NOTA.Insertar(CLASE_GENERAL.mensaje_error)

                            Me.ProgressBar.Value = CInt((i * 100) / CLASE_GENERAL_EXCEL.exdt.Rows.Count)
                            Me.ProgressBar.Text = CInt((i * 100) / CLASE_GENERAL_EXCEL.exdt.Rows.Count) & " %"

                        Next

                        PAC.dispose()
                        PAC = Nothing
                        CON.dispose()
                        CON = Nothing
                        NOTA.dispose()
                        NOTA = Nothing
                        GENEX = Nothing

                        MsgBox("Se lleno la Información de Pacientes con exito", MsgBoxStyle.OkOnly, "Cargar Excel")

                    End If


                End If

            End With

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia
    End Sub

    Private Sub frmConvertirTabla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ProgressBar.Value = 0
        Me.ProgressBar.Text = "0 %"
    End Sub

    Private Sub btnCargarFotos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarFotos.Click


        Try


            Dim respuesta As Integer
            respuesta = MsgBox("Esta Seguro de Cargar El Archivo La Base de Datos?, esto implica el reemplazo de los registros con el archivo seleccionado", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cargar Excel")

            If respuesta = 6 Then

                Me.ProgressBar.Value = 0
                Dim FileName As String


                NOTA = New CLASE_NOTAS
                NOTA.p_IdTUsuario = 1 'Tipo Paciente

                GENE = New CLASE_GENERAL

                NOTA.Seleccionar("todaslasnotas")

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    If My.Computer.FileSystem.FileExists(CLASE_GENERAL.rutaimagenes & CLASE_GENERAL.xdt.Rows(i).Item("IdUsuario") & "pac" & ".bmp") Then

                        NOTA.p_IdUsuario = CLASE_GENERAL.xdt.Rows(i).Item("IdUsuario")
                        NOTA.p_IdTUsuario = 1

                        FileName = CLASE_GENERAL.rutaimagenes & CLASE_GENERAL.xdt.Rows(i).Item("IdUsuario") & "pac" & ".bmp"
                        'Generar un bitmap para el origen
                        Dim SourceImage As Bitmap
                        SourceImage = New Bitmap(FileName)

                        ' Generar un bitmap para el resultado
                        SourceToImage = New Bitmap(SourceImage.Width, SourceImage.Height)
                        NOTA.p_fotolong = GENE.Imagen_Bytes(GENE.comprimir_imagen(SourceToImage, 30))

                        'NOTA.p_fotolong = GENE.Imagen_Bytes(Image.FromFile(CLASE_GENERAL.rutaimagenes & CLASE_GENERAL.xdt.Rows(i).Item("IdUsuario") & "pac" & ".bmp"))
                        NOTA.Modificar("foto")

                        Me.ProgressBar.Value = Round((i + 1 * 100) / CLASE_GENERAL.xdt.Rows.Count)
                        Me.ProgressBar.Text = Me.ProgressBar.Value & " %"
                        Me.ProgressBar.Refresh()

                    End If

                Next

                GENE = Nothing

                NOTA.dispose()
                NOTA = Nothing

                Me.ProgressBar.Value = 100
                Me.ProgressBar.Text = Me.ProgressBar.Value & " %"
                Me.ProgressBar.Refresh()

                MsgBox("Fotos Cargadas con éxito", MsgBoxStyle.OkOnly, "CCargar Datos")


            End If

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
End Class