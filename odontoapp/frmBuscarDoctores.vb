Imports System.Math

Public Class frmBuscarDoctores

    'Variable de Clases objetos
    Private GENE As CLASE_GENERAL
    Private DOC As CLASE_DOCTORES
    Private EVEN As CLASE_EVENTOS
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS

    'Variable de Imagenes
    Private iImagen As Image

    'Variables de Control
    Private indice As String
    Private control As Boolean = False
    Private iniciando As Boolean = True

    Private Sub rbtXNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXNombre.CheckedChanged

        Me.lblNomBusqueda.Text = "Nombre"
        Me.txtBusqueda.Text = ""
        Me.txtBusqueda.Focus()
        Me.listaResultados.Items.Clear()

    End Sub

    Private Sub rbtXApellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXApellido.CheckedChanged

        Me.lblNomBusqueda.Text = "Apellido"
        Me.txtBusqueda.Text = ""
        Me.txtBusqueda.Focus()
        Me.listaResultados.Items.Clear()

    End Sub

    Private Sub rbtXCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXCodigo.CheckedChanged

        Me.lblNomBusqueda.Text = "Código"
        Me.txtBusqueda.Text = ""
        Me.txtBusqueda.Focus()
        Me.listaResultados.Items.Clear()

    End Sub

    Private Sub frmBuscarDoctores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            GENE = New CLASE_GENERAL

            GENE.Cargar_Grilla("doctores", Me.dgDoctores, CLASE_GENERAL.mensaje_error)
            Me.txtCount_doc.Text = CLASE_GENERAL.contar("IdDoctor", "doctores", CLASE_GENERAL.mensaje_error)
            iniciando = False
            GRIDSTYLES()

            Me.dgDoctores.ClearSelection()

            GENE = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub txtBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.Click

        Me.txtBusqueda.Text = ""
        control = False

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Try

            If iniciando Then Exit Sub

            Dim filas() As DataRow

            If Me.rbtXNombre.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("nombres_doc LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas

                            Me.listaResultados.Items.Add(dr("Iddoctor").ToString & ", " & dr("nombres_doc").ToString & " , " & dr("apellidos_doc").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXApellido.Checked = True Then
                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("apellidos_doc LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Iddoctor").ToString & ", " & dr("apellidos_doc").ToString & " , " & dr("nombres_doc").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXCodigo.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("Iddoctor = " & Me.txtBusqueda.Text & "")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Iddoctor").ToString & ", " & dr("nombres_doc").ToString & " , " & dr("apellidos_doc").ToString)

                        Next
                    End If
                End If
            End If

        Catch ex As Exception

            MsgBox("Se Escriben caracteres no validos, verifique por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Doctores") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try



    End Sub

    Private Sub listaResultados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaResultados.SelectedIndexChanged

        Try

            'Al hacer clic, mostrar el dato y controlamos que no verifique la cadena

            iniciando = True
            control = False

            Me.txtBusqueda.Text = Me.listaResultados.SelectedItem.ToString


            ' Buscarlo en el DataGridView (de forma manual, no conozco otra forma...)
            ' Eliminar las selecciones anteriores

            Me.dgDoctores.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.dgDoctores.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("Iddoctor").Value Is Nothing _
                OrElse fila.Cells Is Nothing Then
                    Continue For
                End If

                ' Se busca el caracter hasta que coincida con "," que es el separador de la cadena

                Dim i As Integer = Me.txtBusqueda.Text.IndexOf(",")


                ' En este ejemplo, el formato es Apellidos, Nombre
                Dim Iddoctor As String
                Iddoctor = Me.txtBusqueda.Text.Substring(0, i).TrimEnd()

                If Iddoctor = fila.Cells("Iddoctor").Value.ToString Then
                    ' Seleccionamos la fila
                    Me.dgDoctores.Rows(fila.Index).Selected = True
                    indice = Iddoctor

                    ' nos aseguramos de que sea visible
                    Me.dgDoctores.FirstDisplayedScrollingRowIndex = fila.Index
                    Exit For
                End If
            Next

            iniciando = False

            Me.btnSeleccionar.Enabled = True
            Me.btnEditar.Enabled = True

        Catch ex As System.NullReferenceException

            MsgBox("No selecciono ningún Doctor, intentelo nuevamente por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Doctores") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle

            Style1.Alignment = DataGridViewContentAlignment.BottomLeft


            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter


            With Me.dgDoctores
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "NOMBRE DOCTOR"

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "APELLIDO DOCTOR"

            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Try

           
            ' Cerramos todos las ventanas que intervenga informacion de un usuario
            For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren
                If frm.Name = "frmHuellas" Then
                    frm.Close()
                End If
            Next

            'Cargamos primero la ventana

            frmDoctores.MdiParent = mdiOrthoSoft
            'Display the new form.
            frmDoctores.Show()
            frmDoctores.Activate()

            '*************************************** CARGAMOS LOS DATOS DEL DOCTOR *******************************

            DOC = New CLASE_DOCTORES
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS
            GENE = New CLASE_GENERAL

            DOC.p_Iddoctor = indice
            CON.p_IdUsuario = indice
            NOTA.p_IdUsuario = indice

            If control = True Then

                DOC.p_Iddoctor = Me.dgDoctores.CurrentRow.Cells(0).Value
                CON.p_IdUsuario = Me.dgDoctores.CurrentRow.Cells(0).Value
                NOTA.p_IdUsuario = Me.dgDoctores.CurrentRow.Cells(0).Value

            End If

            EVEN.limpiar("limpiardoctores")
            EVEN.limpiar("limpiarficha")

            DOC.Seleccionar("doctores")

            My.Forms.frmDoctores.txtIddoctor.Text = CLASE_DOCTORES.xIddoctor
            My.Forms.frmDoctores.txtapellidos_doc.Text = CLASE_DOCTORES.xapellidos_doc
            My.Forms.frmDoctores.txtnombres_doc.Text = CLASE_DOCTORES.xnombres_doc
            My.Forms.frmDoctores.txtresidencia_doc.Text = CLASE_DOCTORES.xresidencia_doc
            My.Forms.frmDoctores.txtoficina_doc.Text = CLASE_DOCTORES.xoficina_doc
            My.Forms.frmDoctores.cmbfecingreso_doc.Value = CLASE_DOCTORES.xfecingreso_doc
            My.Forms.frmDoctores.cmbEspecialidades.SelectedValue = CLASE_DOCTORES.xIdespecialidad
            My.Forms.frmDoctores.cmbfecnac_doc.Value = CLASE_DOCTORES.xfecnac_doc

            Select Case CLASE_DOCTORES.xtipodoc_doc

                Case 1
                    My.Forms.frmDoctores.cmbtipodoc_doc.Text = "T.I"
                Case 2
                    My.Forms.frmDoctores.cmbtipodoc_doc.Text = "CEDULA"
                Case 3
                    My.Forms.frmDoctores.cmbtipodoc_doc.Text = "PASAPORTE"
                Case 4
                    My.Forms.frmDoctores.cmbtipodoc_doc.Text = "C.EXTRANGERIA"

            End Select

            My.Forms.frmDoctores.txtnumdoc_doc.Text = CLASE_DOCTORES.xnumdoc_doc

            If CLASE_DOCTORES.xsexo_doc = "M" Then
                My.Forms.frmDoctores.rbtMasculino_doc.Checked = True
            Else
                My.Forms.frmDoctores.rbtFemenino_doc.Checked = True
            End If

            DOC.dispose()
            DOC = Nothing

            '******************************** CARGAMOS LOS CONTACTOS DEL DOCTOR ***********************************

            CON.p_IdTUsuario = 2 ' Lo Utilizamos porque es un doctor
            CON.Seleccionar("xdt")

            Dim i As Integer

            For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 5 Then

                    My.Forms.frmDoctores.txtTelCasa_doc.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                    My.Forms.frmDoctores.txtTelOficina_doc.Text = CLASE_GENERAL.xdt.Rows(i).Item("teloficina_con")
                    My.Forms.frmDoctores.txtFax_doc.Text = CLASE_GENERAL.xdt.Rows(i).Item("fax_con")
                    My.Forms.frmDoctores.txtCelular_doc.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                    My.Forms.frmDoctores.txtemail_doc.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                    My.Forms.frmDoctores.txtweb_doc.Text = CLASE_GENERAL.xdt.Rows(i).Item("web_con")

                End If

            Next

            CON.dispose()
            CON = Nothing

            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing

            '******************************** CARGAMOS FOTO Y NOTAS DEL PACIENTE ***********************************

            NOTA.p_IdTUsuario = 2 ' Utilizamos uno porque es de tipo Doctor
            NOTA.Seleccionar("notas")

            My.Forms.frmDoctores.RichTxtNotas_doc.Text = CLASE_NOTAS.xnota

            If Not (CLASE_NOTAS.xfotolong.Length = 0) Then
                iImagen = GENE.Bytes_Imagen(CLASE_NOTAS.xfotolong)
                My.Forms.frmDoctores.pbFoto_doc.Image = iImagen

            Else

                My.Forms.frmDoctores.pbFoto_doc.Image = My.Resources.fondodoctor

            End If

            NOTA.dispose()
            NOTA = Nothing

            GENE = Nothing

            '************************************  CARGAR LA FICHA CON LOS DATOS****************************

            My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Forms.frmDoctores.pbFoto_doc.Image
            My.Forms.mdiOrthoSoft.txtId_ficha.Text = My.Forms.frmDoctores.txtIddoctor.Text
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = My.Forms.frmDoctores.txtnombres_doc.Text & " " & My.Forms.frmDoctores.txtapellidos_doc.Text
            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = My.Forms.frmDoctores.txtCelular_doc.Text
            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = My.Forms.frmDoctores.txtTelCasa_doc.Text
            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = My.Forms.frmDoctores.txtemail_doc.Text

            'CargamosEstadoActivo y Combo Doctores del Scheduler
            My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = CLASE_DOCTORES.xnombres_doc & " " & CLASE_DOCTORES.xapellidos_doc
            My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag = CLASE_DOCTORES.xIddoctor

            'Cargamos Id especial para Huellas
            CLASE_GENERAL._Iddoctor_consec = CLASE_DOCTORES.xIddoctor

            'CargamosEstadoActivo y Combo Doctores del Scheduler
            My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue = My.Forms.frmDoctores.txtIddoctor.Text
            My.Forms.mdiOrthoSoft.btnDocSeleccionar_Click(sender, e)

            EVEN.bloquaerdesbloquear("editardoctor")
            EVEN = Nothing

            Me.Dispose()
            Me.Close()

        Catch ex As Exception

            MsgBox("Seleccione un Registro por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Doctores") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try


    End Sub
    Private Sub dgDoctores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDoctores.CellContentClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub
    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        Try

            '*************************************** CARGAMOS LOS DATOS DEL DOCTOR *******************************

            ' Cerramos todos las ventanas que intervenga informacion de un usuario
            For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren
                If frm.Name = "frmHuellas" Then
                    frm.Close()
                End If
            Next


            DOC = New CLASE_DOCTORES
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS
            GENE = New CLASE_GENERAL

            DOC.p_Iddoctor = indice
            CON.p_IdUsuario = indice
            NOTA.p_IdUsuario = indice

            If control = True Then
                DOC.p_Iddoctor = Me.dgDoctores.CurrentRow.Cells(0).Value
                CON.p_IdUsuario = Me.dgDoctores.CurrentRow.Cells(0).Value
                NOTA.p_IdUsuario = Me.dgDoctores.CurrentRow.Cells(0).Value
                control = True
            End If

            EVEN.limpiar("limpiarficha")

            DOC.Seleccionar("doctores")

            My.Forms.mdiOrthoSoft.txtId_ficha.Text = CLASE_DOCTORES.xIddoctor
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = CLASE_DOCTORES.xnombres_doc & " " & CLASE_DOCTORES.xapellidos_doc
            'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Clase_doctores.xresidencia_doc

            'CargamosEstadoActivo y Combo Doctores del Scheduler
            My.Forms.mdiOrthoSoft.lblActivoDoctor.Text = CLASE_DOCTORES.xnombres_doc & " " & CLASE_DOCTORES.xapellidos_doc
            My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag = CLASE_DOCTORES.xIddoctor

            'Cargamos Id especial para Huellas
            CLASE_GENERAL._Iddoctor_consec = CLASE_DOCTORES.xIddoctor

            My.Forms.mdiOrthoSoft.cmbDoctores.SelectedValue = CLASE_DOCTORES.xIddoctor
            My.Forms.mdiOrthoSoft.btnDocSeleccionar_Click(sender, e)

            DOC.dispose()
            DOC = Nothing

            '******************************** CARGAMOS LOS CONTACTOS DEL DOCTOR ***********************************

            CON.p_IdTUsuario = 2 ' Lo Utilizamos porque es un doctor
            CON.Seleccionar("xdt")

            Dim i As Integer

            For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 5 Then

                    My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                    My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                    My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")

                End If

            Next



            CON.dispose()
            CON = Nothing

            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing


            '************************************* CARGAMOS FOTO DEL DOCTOR **************************

            NOTA.p_IdTUsuario = 2 ' Lo Utilizamos porque es un doctor
            NOTA.Seleccionar("notas")

            If Not (CLASE_NOTAS.xfotolong.Length = 0) Then
                iImagen = GENE.Bytes_Imagen(CLASE_NOTAS.xfotolong)
                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = iImagen

            Else

                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Resources.fondodoctor

            End If

            NOTA.dispose()
            NOTA = Nothing
            GENE = Nothing

            EVEN = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Doctor") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try

    End Sub

    Private Sub dgDoctores_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgDoctores.MouseClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Try

            Me.Dispose()
            Me.Close()

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
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpOpcionBusqueda)
        ubicarcontrol(Me.lblNomBusqueda)
        ubicarcontrol(Me.txtBusqueda)
        ubicarcontrol(Me.listaResultados)
        ubicarcontrol(Me.btnSeleccionar)
        ubicarcontrol(Me.lblTotalDoctores)
        ubicarcontrol(Me.txtCount_doc)
        ubicarcontrol(Me.btnEditar)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.dgDoctores)

    End Sub

    Private Sub frmBuscarDoctores_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class