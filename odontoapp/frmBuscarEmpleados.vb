Imports System.Math

Public Class frmBuscarEmpleados

    'Variable de Clases objetos
    Private GENE As CLASE_GENERAL
    Private EMP As CLASE_EMPLEADOS
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

    Private Sub frmBuscarEmpleados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("empleados", Me.dgEmpleados, CLASE_GENERAL.mensaje_error)
            Me.txtCount_Emp.Text = CLASE_GENERAL.contar("IdEmpleado", "empleados", CLASE_GENERAL.mensaje_error)
            iniciando = False
            GRIDSTYLES()

            Me.dgEmpleados.ClearSelection()

            GENE = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
    Private Sub txtBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.Click

        Me.txtBusqueda.Text = ""

    End Sub
    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Try

            If iniciando Then Exit Sub

            Dim filas() As DataRow

            If Me.rbtXNombre.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("nombres_emp LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas

                            Me.listaResultados.Items.Add(dr("Idempleado").ToString & ", " & dr("nombres_emp").ToString & " , " & dr("apellidos_emp").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXApellido.Checked = True Then
                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("apellidos_emp LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Idempleado").ToString & ", " & dr("apellidos_emp").ToString & " , " & dr("nombres_emp").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXCodigo.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("Idempleado = " & Me.txtBusqueda.Text & "")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Idempleado").ToString & ", " & dr("nombres_emp").ToString & " , " & dr("apellidos_emp").ToString)

                        Next
                    End If
                End If
            End If

        Catch ex As Exception

            MsgBox("Se Escriben caracteres no validos, verifique por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Empleados") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
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

            Me.dgEmpleados.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.dgEmpleados.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("Idempleado").Value Is Nothing _
                OrElse fila.Cells Is Nothing Then
                    Continue For
                End If

                ' Se busca el caracter hasta que coincida con "," que es el separador de la cadena

                Dim i As Integer = Me.txtBusqueda.Text.IndexOf(",")


                ' En este ejemplo, el formato es Apellidos, Nombre
                Dim Idempleado As String
                Idempleado = Me.txtBusqueda.Text.Substring(0, i).TrimEnd()

                If Idempleado = fila.Cells("Idempleado").Value.ToString Then
                    ' Seleccionamos la fila
                    Me.dgEmpleados.Rows(fila.Index).Selected = True
                    indice = Idempleado

                    ' nos aseguramos de que sea visible
                    Me.dgEmpleados.FirstDisplayedScrollingRowIndex = fila.Index
                    Exit For
                End If
            Next

            iniciando = False
            Me.btnSeleccionar.Enabled = True
            Me.btnEditar.Enabled = True

        Catch ex As System.NullReferenceException

            MsgBox("No selecciono ningún Usuario, intentelo nuevamente por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Usuario") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

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


            With Me.dgEmpleados
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "IDEMPLEADO"

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "NOMBRES EMPLEADO"

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "APELLIDOS EMPLEADO"

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


            frmUsuarios.MdiParent = mdiOrthoSoft
            'Display the new form.
            frmUsuarios.Show()
            frmUsuarios.Activate()

            '*************************************** CARGAMOS LOS DATOS DEL EMPLEADO *******************************

            EMP = New CLASE_EMPLEADOS
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS
            GENE = New CLASE_GENERAL

            EMP.p_Idempleado = indice
            CON.p_IdUsuario = indice
            NOTA.p_IdUsuario = indice

            If control = True Then

                EMP.p_Idempleado = Me.dgEmpleados.CurrentRow.Cells(0).Value
                CON.p_IdUsuario = Me.dgEmpleados.CurrentRow.Cells(0).Value
                NOTA.p_IdUsuario = Me.dgEmpleados.CurrentRow.Cells(0).Value

            End If

            EVEN.limpiar("limpiarempleados")
            EVEN.limpiar("limpiarficha")
            EMP.Seleccionar(CLASE_GENERAL.mensaje_error)


            My.Forms.frmUsuarios.txtIdempleado.Text = CLASE_EMPLEADOS.xIdempleado
            My.Forms.frmUsuarios.txtapellidos_emp.Text = CLASE_EMPLEADOS.xapellidos_emp
            My.Forms.frmUsuarios.txtnombres_emp.Text = CLASE_EMPLEADOS.xnombres_emp
            My.Forms.frmUsuarios.txtresidencia_emp.Text = CLASE_EMPLEADOS.xresidencia_emp
            My.Forms.frmUsuarios.cmbfecingreso_emp.Value = CLASE_EMPLEADOS.xfecingreso_emp
            My.Forms.frmUsuarios.txtEspecialidad_emp.Text = CLASE_EMPLEADOS.xespecialidad_emp
            My.Forms.frmUsuarios.cmbfecnac_emp.Value = CLASE_EMPLEADOS.xfecnac_emp

            Select Case CLASE_EMPLEADOS.xtipodoc_emp

                Case 1
                    My.Forms.frmUsuarios.cmbtipodoc_emp.Text = "T.I"
                Case 2
                    My.Forms.frmUsuarios.cmbtipodoc_emp.Text = "CEDULA"
                Case 3
                    My.Forms.frmUsuarios.cmbtipodoc_emp.Text = "PASAPORTE"
                Case 4
                    My.Forms.frmUsuarios.cmbtipodoc_emp.Text = "C.EXTRANGERIA"

            End Select

            My.Forms.frmUsuarios.txtnumdoc_emp.Text = CLASE_EMPLEADOS.xnumdoc_emp

            If CLASE_EMPLEADOS.xsexo_emp = "M" Then
                My.Forms.frmUsuarios.rbtMasculino_emp.Checked = True
            Else
                My.Forms.frmUsuarios.rbtFemenino_emp.Checked = True
            End If

            My.Forms.frmUsuarios.cmbPerfilAcceso.SelectedValue = CLASE_EMPLEADOS.xnivel_emp


            'Cargamos Id especial para Huellas
            CLASE_GENERAL._Idempleado_consec = CLASE_EMPLEADOS.xIdempleado


            EMP.dispose()
            EMP = Nothing

            '******************************** CARGAMOS LOS CONTACTOS DEL EMPLEADO ***********************************

            CON.p_IdTUsuario = 3 ' Lo Utilizamos porque es un empleado
            CON.Seleccionar("xdt")

            Dim i As Integer

            For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 5 Then

                    My.Forms.frmUsuarios.txtTelCasa_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                    My.Forms.frmUsuarios.txtFax_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("fax_con")
                    My.Forms.frmUsuarios.txtCelular_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                    My.Forms.frmUsuarios.txtemail_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("email_con")
                    My.Forms.frmUsuarios.txtweb_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("web_con")

                End If

                If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 1 Then

                    My.Forms.frmUsuarios.txtPadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("nom_con")
                    My.Forms.frmUsuarios.txtTelPadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                    My.Forms.frmUsuarios.txtCelPadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                    My.Forms.frmUsuarios.txtOcuPadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("ocu_con")

                End If

                If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 2 Then

                    My.Forms.frmUsuarios.txtMadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("nom_con")
                    My.Forms.frmUsuarios.txtTelMadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                    My.Forms.frmUsuarios.txtCelMadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                    My.Forms.frmUsuarios.txtOcuMadre_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("ocu_con")

                End If

                If CLASE_GENERAL.xdt.Rows(i).Item("IdTTutor") = 4 Then

                    My.Forms.frmUsuarios.txtConyuge_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("nom_con")
                    My.Forms.frmUsuarios.txtTelConyuge_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("telcasa_con")
                    My.Forms.frmUsuarios.txtCelConyuge_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("cel_con")
                    My.Forms.frmUsuarios.txtOcuConyuge_emp.Text = CLASE_GENERAL.xdt.Rows(i).Item("ocu_con")

                End If

            Next

            CON.dispose()
            CON = Nothing

            CLASE_GENERAL.xdt.Clear()
            CLASE_GENERAL.xdt = Nothing

            '******************************** CARGAMOS FOTO Y NOTAS DEL EMPLEADO ***********************************

            NOTA.p_IdTUsuario = 3 ' Utilizamos uno porque es de tipo Paciente
            NOTA.Seleccionar("notas")

            My.Forms.frmUsuarios.RichTxtNotas_emp.Text = CLASE_NOTAS.xnota

            If Not (CLASE_NOTAS.xfotolong.Length = 0) Then
                iImagen = GENE.Bytes_Imagen(CLASE_NOTAS.xfotolong)
                My.Forms.frmUsuarios.pbFoto_emp.Image = iImagen

            Else

                My.Forms.frmUsuarios.pbFoto_emp.Image = My.Resources.fondoempleado

            End If

            NOTA.dispose()
            NOTA = Nothing

            GENE = Nothing

            '************************************  CARGAR LA FICHA CON LOS DATOS****************************

            My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Forms.frmUsuarios.pbFoto_emp.Image
            My.Forms.mdiOrthoSoft.txtId_ficha.Text = My.Forms.frmUsuarios.txtIdempleado.Text
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = My.Forms.frmUsuarios.txtnombres_emp.Text & " " & My.Forms.frmUsuarios.txtapellidos_emp.Text
            My.Forms.mdiOrthoSoft.txtCelular_ficha.Text = My.Forms.frmUsuarios.txtCelular_emp.Text
            My.Forms.mdiOrthoSoft.txtTelCasa_ficha.Text = My.Forms.frmUsuarios.txtTelCasa_emp.Text
            My.Forms.mdiOrthoSoft.txtEmail_ficha.Text = My.Forms.frmUsuarios.txtemail_emp.Text

            EVEN.bloquaerdesbloquear("editarempleado")
            EVEN = Nothing

            Me.Dispose()
            Me.Close()

        Catch ex As Exception

            MsgBox("Seleccione un Registro por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Empleados") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try

    End Sub

    Private Sub dgEmpleados_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgEmpleados.CellContentClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click


        Try
            '*************************************** CARGAMOS LOS DATOS DEL PACIENTE *******************************

            ' Cerramos todos las ventanas que intervenga informacion de un usuario
            For Each frm As Form In My.Forms.mdiOrthoSoft.MdiChildren
                If frm.Name = "frmHuellas" Then
                    frm.Close()
                End If
            Next


            EMP = New CLASE_EMPLEADOS
            CON = New CLASE_CONTACTOS
            NOTA = New CLASE_NOTAS
            EVEN = New CLASE_EVENTOS
            GENE = New CLASE_GENERAL

            EMP.p_Idempleado = indice
            CON.p_IdUsuario = indice
            NOTA.p_IdUsuario = indice

            If control = True Then
                EMP.p_Idempleado = Me.dgEmpleados.CurrentRow.Cells(0).Value
                CON.p_IdUsuario = Me.dgEmpleados.CurrentRow.Cells(0).Value
                NOTA.p_IdUsuario = Me.dgEmpleados.CurrentRow.Cells(0).Value
                control = True
            End If

            EVEN.limpiar("limpiarficha")

            EMP.Seleccionar(CLASE_GENERAL.mensaje_error)

            My.Forms.mdiOrthoSoft.txtId_ficha.Text = CLASE_EMPLEADOS.xIdempleado
            My.Forms.mdiOrthoSoft.txtNombre_ficha.Text = CLASE_EMPLEADOS.xnombres_emp & " " & CLASE_EMPLEADOS.xapellidos_emp
            'My.Forms.mdiOrthoSoft.txtReferido_ficha.Text = Clase_empleados.xresidencia_emp

            'Cargamos Id especial para Huellas
            CLASE_GENERAL._Idempleado_consec = CLASE_EMPLEADOS.xIdempleado

            EMP.dispose()
            EMP = Nothing

            '******************************** CARGAMOS LOS CONTACTOS DEL EMPLEADO ***********************************

            CON.p_IdTUsuario = 3 ' Lo Utilizamos porque es un paciente
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

            '************************************* CARGAMOS FOTO DEL EMPLEDO **************************

            NOTA.p_IdTUsuario = 3 ' Lo Utilizamos porque es un paciente
            NOTA.Seleccionar("notas")

            If Not (CLASE_NOTAS.xfotolong.Length = 0) Then
                iImagen = GENE.Bytes_Imagen(CLASE_NOTAS.xfotolong)
                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = iImagen

            Else

                My.Forms.mdiOrthoSoft.pbxFoto_ficha.Image = My.Resources.fondoempleado

            End If

            NOTA.dispose()
            NOTA = Nothing
            GENE = Nothing

            EVEN = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Empleados") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Me.txtBusqueda.Text = ""
            Me.txtBusqueda.Focus()

        End Try

    End Sub

    Private Sub dgEmpleados_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgEmpleados.MouseClick

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
        ubicarcontrol(Me.lblTotalUsuarios)
        ubicarcontrol(Me.txtCount_Emp)
        ubicarcontrol(Me.btnEditar)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.dgEmpleados)

    End Sub

    Private Sub frmBuscarEmpleados_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class