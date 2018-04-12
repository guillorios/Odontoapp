Imports System.Math

Public Class frmBuscarProveedor

    'Variable de Clases objetos
    Private GENE As CLASE_GENERAL
    Private PROVEE As CLASE_PROVEEDORES
    Private EVEN As CLASE_EVENTOS

    'Variables de Control
    Private indice As String
    Private control As Boolean = True
    Private iniciando As Boolean = True

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        Try

            PROVEE = New CLASE_PROVEEDORES
            PROVEE.p_Idproveedor = indice

            If control = True Then
                PROVEE.p_Idproveedor = Me.dgProveedores.CurrentRow.Cells(0).Value
                control = True
            End If

            EVEN = New CLASE_EVENTOS
            EVEN.limpiar("limpiarficha")
            EVEN = Nothing

            PROVEE.Seleccionar("registro")

            My.Forms.mdiOrthoSoft.txtId_ficha.Text = CLASE_PROVEEDORES.xIdproveedor
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = CLASE_PROVEEDORES.xnombre_prov & " " & CLASE_PROVEEDORES.xcontacto_prov

            '******************************** CARGAMOS LOS CONTACTOS DE LA ENTIDAD ***********************************

            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = CLASE_PROVEEDORES.xcelular_prov
            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = CLASE_PROVEEDORES.xteloficina_prov
            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = CLASE_PROVEEDORES.xemail_prov

            PROVEE.dispose()
            PROVEE = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Proveedores") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try

    End Sub

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

    Private Sub txtBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.Click

        Me.txtBusqueda.Text = ""
        control = False

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Try

            If iniciando Then Exit Sub

            Dim filas() As DataRow

            If Me.rbtXNombre.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("nombre_prov LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas

                            Me.listaResultados.Items.Add(dr("Idproveedor").ToString & ", " & dr("nombre_prov").ToString & " , " & dr("contacto_prov").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXContacto.Checked = True Then
                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("contacto_prov LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas

                            Me.listaResultados.Items.Add(dr("Idproveedor").ToString & ", " & dr("nombre_prov").ToString & " , " & dr("contacto_prov").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXCodigo.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("Idproveedor = " & Me.txtBusqueda.Text & "")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas

                            Me.listaResultados.Items.Add(dr("Idproveedor").ToString & ", " & dr("nombre_prov").ToString & " , " & dr("contacto_prov").ToString)

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

            Me.dgProveedores.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.dgProveedores.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("Idproveedor").Value Is Nothing _
                OrElse fila.Cells Is Nothing Then
                    Continue For
                End If

                ' Se busca el caracter hasta que coincida con "," que es el separador de la cadena

                Dim i As Integer = Me.txtBusqueda.Text.IndexOf(",")


                ' En este ejemplo, el formato es Apellidos, Nombre
                Dim Idproveedor As String
                Idproveedor = Me.txtBusqueda.Text.Substring(0, i).TrimEnd()

                If Idproveedor = fila.Cells("Idproveedor").Value.ToString Then
                    ' Seleccionamos la fila
                    Me.dgProveedores.Rows(fila.Index).Selected = True
                    indice = Idproveedor

                    ' nos aseguramos de que sea visible
                    Me.dgProveedores.FirstDisplayedScrollingRowIndex = fila.Index
                    Exit For
                End If
            Next

            iniciando = False
            Me.btnSeleccionar.Enabled = True
            Me.btnEditar.Enabled = True

        Catch ex As System.NullReferenceException

            MsgBox("No selecciono ningún Proveedor, intentelo nuevamente por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Proveedores") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

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


            With Me.dgProveedores

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "IDENTIDAD"

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "NOMBRE PROVEEDOR"

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "DIRECCION PROVEEDOR"

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "NOMBRE CONTACTO"

            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia



    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Try

            Me.Dispose()
            Me.Close()

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub dgProveedores_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgProveedores.CellContentClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub

    Private Sub dgProveedores_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgProveedores.MouseClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub

    Private Sub frmBuscarProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("proveedores", Me.dgProveedores, CLASE_GENERAL.mensaje_error)
            Me.txtCount_ent.Text = CLASE_GENERAL.contar("Idproveedor", "proveedores ", CLASE_GENERAL.mensaje_error)
            iniciando = False
            GRIDSTYLES()

            Me.dgProveedores.ClearSelection()

            GENE = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        Try

            '*************************************** CARGAMOS LOS DATOS DE LA ENTIDAD *******************************

            PROVEE = New CLASE_PROVEEDORES
            EVEN = New CLASE_EVENTOS

            PROVEE.p_Idproveedor = indice

            If control = True Then

                PROVEE.p_Idproveedor = Me.dgProveedores.CurrentRow.Cells(0).Value

            End If


            EVEN.limpiar("limpiarproveedores")
            EVEN.limpiar("limpiarficha")

            PROVEE.Seleccionar("registro")


            My.Forms.frmProveedores.txtIdproveedor.Text = CLASE_PROVEEDORES.xIdproveedor
            My.Forms.frmProveedores.txtnombre_prov.Text = CLASE_PROVEEDORES.xnombre_prov
            My.Forms.frmProveedores.txtdireccion_prov.Text = CLASE_PROVEEDORES.xdireccion_prov
            My.Forms.frmProveedores.txtcontacto_prov.Text = CLASE_PROVEEDORES.xcontacto_prov
            My.Forms.frmProveedores.txtteloficina_prov.Text = CLASE_PROVEEDORES.xteloficina_prov
            My.Forms.frmProveedores.txtcelular_prov.Text = CLASE_PROVEEDORES.xcelular_prov
            My.Forms.frmProveedores.txtfax_prov.Text = CLASE_PROVEEDORES.xfax_prov
            My.Forms.frmProveedores.txtemail_prov.Text = CLASE_PROVEEDORES.xemail_prov
            My.Forms.frmProveedores.txtweb_prov.Text = CLASE_PROVEEDORES.xweb_prov

            '************************************  CARGAR LA FICHA CON LOS DATOS****************************

            My.Forms.mdiOrthoSoft.txtId_ficha.Text = CLASE_PROVEEDORES.xIdproveedor
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = CLASE_PROVEEDORES.xnombre_prov & " " & CLASE_PROVEEDORES.xcontacto_prov
            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = CLASE_PROVEEDORES.xcelular_prov
            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = CLASE_PROVEEDORES.xteloficina_prov
            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = CLASE_PROVEEDORES.xemail_prov

            '************************************

            PROVEE.dispose()
            PROVEE = Nothing

            Me.Dispose()
            Me.Close()

            frmProveedores.MdiParent = mdiOrthoSoft
            'Display the new form.
            frmProveedores.Show()
            frmProveedores.Activate()

            EVEN.bloquaerdesbloquear("editarproveedor")
            EVEN = Nothing

        Catch ex As Exception

            MsgBox("Seleccione un Registro por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Proveedores") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try


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
        ubicarcontrol(Me.lblTotalProveedores)
        ubicarcontrol(Me.txtCount_ent)
        ubicarcontrol(Me.btnEditar)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.dgProveedores)

    End Sub

    Private Sub frmBuscarProveedor_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class