Imports System.Math

Public Class frmBuscarEntidad

    'Variable de Clases objetos
    Private GENE As CLASE_GENERAL
    Private ENT As CLASE_ENTIDADES
    Private EVEN As CLASE_EVENTOS
    Private CON As CLASE_CONTACTOS
    Private NOTA As CLASE_NOTAS

    'Variables de Control
    Private indice As String
    Private control As Boolean = True
    Private iniciando As Boolean = True

    Private Sub rbtXNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXNombre.CheckedChanged
        Me.lblNomBusqueda.Text = "Nombre"
        Me.txtBusqueda.Text = ""
        Me.txtBusqueda.Focus()
        Me.listaResultados.Items.Clear()
    End Sub

    Private Sub rbtXContacto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXContacto.CheckedChanged
        Me.lblNomBusqueda.Text = "Contacto"
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
                    filas = CLASE_GENERAL.xdt2.Select("nombre_ent LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas

                            Me.listaResultados.Items.Add(dr("Identidad").ToString & ", " & dr("nombre_ent").ToString & " , " & dr("contacto_ent").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXContacto.Checked = True Then
                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("contacto_ent LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Identidad").ToString & ", " & dr("contacto_ent").ToString & " , " & dr("nombre_ent").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXCodigo.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("Identidad = " & Me.txtBusqueda.Text & "")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas

                            Me.listaResultados.Items.Add(dr("Identidad").ToString & ", " & dr("nombre_ent").ToString & " , " & dr("contacto_ent").ToString)

                        Next
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Se Escriben caracteres no validos, verifique por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Entidades") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try

    End Sub
    Private Sub listaResultados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listaResultados.SelectedIndexChanged

        Try
            'Al hacer clic, mostrar el dato y controlamos que no verifique la cadena

            'If iniciando Then Exit Sub
            iniciando = True
            control = False

            Me.txtBusqueda.Text = Me.listaResultados.SelectedItem.ToString


            ' Buscarlo en el DataGridView (de forma manual, no conozco otra forma...)
            ' Eliminar las selecciones anteriores

            Me.dgEntidades.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.dgEntidades.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("Identidad").Value Is Nothing _
                OrElse fila.Cells Is Nothing Then
                    Continue For
                End If

                ' Se busca el caracter hasta que coincida con "," que es el separador de la cadena

                Dim i As Integer = Me.txtBusqueda.Text.IndexOf(",")


                ' En este ejemplo, el formato es Apellidos, Nombre
                Dim Identidad As String
                Identidad = Me.txtBusqueda.Text.Substring(0, i).TrimEnd()

                If Identidad = fila.Cells("Identidad").Value.ToString Then
                    ' Seleccionamos la fila
                    Me.dgEntidades.Rows(fila.Index).Selected = True
                    indice = Identidad

                    ' nos aseguramos de que sea visible
                    Me.dgEntidades.FirstDisplayedScrollingRowIndex = fila.Index
                    Exit For
                End If
            Next

            iniciando = False
            Me.btnSeleccionar.Enabled = True
            Me.btnEditar.Enabled = True

        Catch ex As System.NullReferenceException

            MsgBox("No selecciono ningúna Entidad, intentelo nuevamente por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Entidades") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle

            'Style1.Format = "N0"
            Style1.Alignment = DataGridViewContentAlignment.BottomLeft


            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter


            With Me.dgEntidades
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "IDENTIDAD"

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "NOMBRE ENTIDAD"

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "DIRECCION ENTIDAD"

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "NOMBRE CONTACTO"

            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia



    End Sub


    Private Sub btnEntSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Try

            Me.Dispose()
            Me.Close()

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub


    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Try

            'Abrimos la ventana Primero

            frmEntidades.MdiParent = mdiOrthoSoft
            'Display the new form.
            frmEntidades.Show()
            frmEntidades.Activate()


            '*************************************** CARGAMOS LOS DATOS DE LA ENTIDAD *******************************
            ENT = New CLASE_ENTIDADES
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS

            ENT.p_Identidad = indice
            CON.p_IdUsuario = indice
            NOTA.p_IdUsuario = indice


            If control = True Then
                ENT.p_Identidad = Me.dgEntidades.CurrentRow.Cells(0).Value
                CON.p_IdUsuario = Me.dgEntidades.CurrentRow.Cells(0).Value
                NOTA.p_IdUsuario = Me.dgEntidades.CurrentRow.Cells(0).Value
            End If


            EVEN.limpiar("limpiarentidades")
            EVEN.limpiar("limpiarficha")

            ENT.Seleccionar(CLASE_GENERAL.mensaje_error)


            My.Forms.frmEntidades.txtIdentidad.Text = CLASE_ENTIDADES.xIdentidad
            My.Forms.frmEntidades.txtnombre_ent.Text = CLASE_ENTIDADES.xnombre_ent
            My.Forms.frmEntidades.txtdireccion_ent.Text = CLASE_ENTIDADES.xdireccion_ent
            My.Forms.frmEntidades.txtcontacto_ent.Text = CLASE_ENTIDADES.xcontacto_ent
            My.Forms.frmEntidades.txtcodigo_ent.Text = CLASE_ENTIDADES.xcodigo_ent

            ENT.dispose()
            ENT = Nothing


            '******************************** CARGAMOS LOS CONTACTOS DE LA ENTIDAD ***********************************

            CON.p_IdTUsuario = 4 ' Lo Utilizamos porque es una entidad
            CON.Seleccionar("xdt")

            Dim i As Integer

            For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 5 Then

                    My.Forms.frmEntidades.txtTelOficina_ent.Text = CLASE_GENERAL.xdt.Rows(i).Item("teloficina_con")
                    My.Forms.frmEntidades.txtFax_ent.Text = CLASE_GENERAL.xdt.Rows(i).Item("fax_con")
                    My.Forms.frmEntidades.txtCelular_ent.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                    My.Forms.frmEntidades.txtemail_ent.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                    My.Forms.frmEntidades.txtweb_ent.Text = CLASE_GENERAL.xdt.Rows(i).Item("web_con")

                End If

            Next

            CON.dispose()
            CON = Nothing

            '******************************** CARGAMOS NOTAS DE LA ENTIDAD ***********************************

            NOTA.p_IdTUsuario = 4 ' Utilizamos uno porque es de tipo Entidad
            NOTA.Seleccionar("notas")

            My.Forms.frmEntidades.RichTxtNotas_ent.Text = CLASE_NOTAS.xnota

            NOTA.dispose()
            NOTA = Nothing

            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing


            '************************************  CARGAR LA FICHA CON LOS DATOS****************************

            My.Forms.mdiOrthoSoft.txtId_ficha.Text = My.Forms.frmEntidades.txtIdentidad.Text
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = My.Forms.frmEntidades.txtnombre_ent.Text & " " & My.Forms.frmEntidades.txtcontacto_ent.Text
            'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = My.Forms.frmEntidades.txtdireccion_ent.Text
            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = My.Forms.frmEntidades.txtCelular_ent.Text
            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = My.Forms.frmEntidades.txtTelOficina_ent.Text
            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = My.Forms.frmEntidades.txtemail_ent.Text

            Me.Dispose()
            Me.Close()

            EVEN.bloquaerdesbloquear("editarentidad")
            EVEN = Nothing


        Catch ex As Exception

            MsgBox("Seleccione un Registro por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Entidades") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try

    End Sub

    Private Sub dgEntidades_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEntidades.CellContentClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        Try

            ENT = New CLASE_ENTIDADES
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS

            ENT.p_Identidad = indice
            CON.p_IdUsuario = indice
            NOTA.p_IdUsuario = indice

            If control = True Then
                ENT.p_Identidad = Me.dgEntidades.CurrentRow.Cells(0).Value
                CON.p_IdUsuario = Me.dgEntidades.CurrentRow.Cells(0).Value
                NOTA.p_IdUsuario = Me.dgEntidades.CurrentRow.Cells(0).Value
                control = True
            End If

            EVEN.limpiar("limpiarficha")

            ENT.Seleccionar(CLASE_GENERAL.mensaje_error)


            My.Forms.mdiOrthoSoft.txtId_ficha.Text = CLASE_ENTIDADES.xIdentidad
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = CLASE_ENTIDADES.xnombre_ent & " " & CLASE_ENTIDADES.xcontacto_ent
            'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Clase_entidades.xdireccion_ent

            ENT.dispose()
            ENT = Nothing

            '******************************** CARGAMOS LOS CONTACTOS DE LA ENTIDAD ***********************************

            CON.p_IdTUsuario = 4 ' Lo Utilizamos porque es una entidad
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

            EVEN = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Entidades") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try

    End Sub

    Private Sub dgEntidades_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgEntidades.MouseClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub

    Private Sub frmBuscarEntidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("entidades", Me.dgEntidades, CLASE_GENERAL.mensaje_error)
            Me.txtCount_ent.Text = CLASE_GENERAL.contar("IdEntidad", "entidades", CLASE_GENERAL.mensaje_error)
            iniciando = False
            GRIDSTYLES()

            Me.dgEntidades.ClearSelection()

            GENE = Nothing

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
        ubicarcontrol(Me.lblTotaleEntidades)
        ubicarcontrol(Me.txtCount_ent)
        ubicarcontrol(Me.btnEditar)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.dgEntidades)

    End Sub

    Private Sub frmBuscarEntidad_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        ubicarcontroles()

    End Sub
End Class