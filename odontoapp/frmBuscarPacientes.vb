Imports System.Math

Public Class frmBuscarPacientes

    'Creamos las Clases
    Private GENE As CLASE_GENERAL
    Private EVEN As CLASE_EVENTOS

    'Varibles de control
    Private indice As String
    Private control As Boolean = False
    Private fecha As Date
    Private contar As Integer
    Private iniciando As Boolean = True
    Private bandera As Integer = 1
    Private Idpaciente As Integer

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Try

            Me.Dispose()
            Me.Close()

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub

    Private Sub rbtXNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXNombres.CheckedChanged

        Me.lblNomBusqueda.Text = "Nombre"
        Me.txtBusqueda.Text = ""
        Me.txtBusqueda.Focus()
        Me.listaResultados.Items.Clear()

    End Sub

    Private Sub rbtXApellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXDocumento.CheckedChanged

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

    Private Sub rbtXHistoria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXHistoria.CheckedChanged

        Me.lblNomBusqueda.Text = "No. Historia"
        Me.txtBusqueda.Text = ""
        Me.txtBusqueda.Focus()
        Me.listaResultados.Items.Clear()

    End Sub

    Private Sub cargar_grilla()

        Try

            GENE = New CLASE_GENERAL
            GENE.Cargar_Grilla("pacientes", Me.dgPacientes, CLASE_GENERAL.mensaje_error)

            Me.txtCount_pac.Text = CLASE_GENERAL.contar("IdPaciente", "pacientes", CLASE_GENERAL.mensaje_error)

            iniciando = False
            GRIDSTYLES()

            Me.dgPacientes.ClearSelection()

            GENE = Nothing

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia


    End Sub

    Private Sub frmBuscarPacientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

       cargar_grilla()

    End Sub

    Private Sub txtBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.Click

        Me.txtBusqueda.Text = ""
        control = False

    End Sub


    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged

        Try

            If iniciando Then Exit Sub

            Dim filas() As DataRow

            If Me.rbtXNombres.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("nombres_pac LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Idpaciente").ToString & ", " & dr("nombres_pac").ToString & " , " & dr("apellidos_pac").ToString & " , " & dr("numdoc_pac").ToString & " , " & dr("nhclinica").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXApellidos.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("apellidos_pac LIKE '%" & Me.txtBusqueda.Text & "%'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Idpaciente").ToString & ", " & dr("nombres_pac").ToString & " , " & dr("apellidos_pac").ToString & " , " & dr("numdoc_pac").ToString & " , " & dr("nhclinica").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXDocumento.Checked = True Then
                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("numdoc_pac = '" & Me.txtBusqueda.Text & "'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Idpaciente").ToString & ", " & dr("nombres_pac").ToString & " , " & dr("apellidos_pac").ToString & " , " & dr("numdoc_pac").ToString & " , " & dr("nhclinica").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXCodigo.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then
                    filas = CLASE_GENERAL.xdt2.Select("Idpaciente = " & Me.txtBusqueda.Text & "")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Idpaciente").ToString & ", " & dr("nombres_pac").ToString & " , " & dr("apellidos_pac").ToString & " , " & dr("numdoc_pac").ToString & " , " & dr("nhclinica").ToString)

                        Next
                    End If
                End If
            End If

            If Me.rbtXHistoria.Checked = True Then

                If Not (Me.txtBusqueda.Text = "") Then

                    filas = CLASE_GENERAL.xdt2.Select("nhclinica = '" & Me.txtBusqueda.Text & "'")
                    Me.listaResultados.Items.Clear()
                    If filas.Length > 0 Then

                        ' Recorrer cada fila y mostrar los apellidos
                        For Each dr As DataRow In filas
                            Me.listaResultados.Items.Add(dr("Idpaciente").ToString & ", " & dr("nombres_pac").ToString & " , " & dr("apellidos_pac").ToString & " , " & dr("numdoc_pac").ToString & " , " & dr("nhclinica").ToString)

                        Next
                    End If
                End If
            End If


        Catch ex As Exception

            MsgBox("Se Escriben caracteres no validos, verifique por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pacientes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
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

            Me.dgPacientes.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.dgPacientes.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("Idpaciente").Value Is Nothing _
                OrElse fila.Cells Is Nothing Then
                    Continue For
                End If

                ' Se busca el caracter hasta que coincida con "," que es el separador de la cadena

                Dim i As Integer = Me.txtBusqueda.Text.IndexOf(",")


                ' En este ejemplo, el formato es Apellidos, Nombre
                Dim Idpaciente As String
                Idpaciente = Me.txtBusqueda.Text.Substring(0, i).TrimEnd()

                If Idpaciente = fila.Cells("IdPaciente").Value.ToString Then
                    ' Seleccionamos la fila
                    Me.dgPacientes.Rows(fila.Index).Selected = True

                    indice = Idpaciente

                    ' nos aseguramos de que sea visible
                    Me.dgPacientes.FirstDisplayedScrollingRowIndex = fila.Index
                    Exit For
                End If
            Next

            iniciando = False

            Me.btnSeleccionar.Enabled = True
            Me.btnEditar.Enabled = True

        Catch ex As System.NullReferenceException

            MsgBox("No selecciono ningún Paciente, intentelo nuevamente por favor", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Buscar Pacientes") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        Catch ex As Exception 'captura cualquier tipo de errores

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje

        End Try 'cierra la sentencia

    End Sub
    Private Sub GRIDSTYLES() ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle
            Style1.Format = "N0"
            Style1.Alignment = DataGridViewContentAlignment.BottomLeft


            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter


            With Me.dgPacientes

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                .Columns(0).DefaultCellStyle = Style2
                .Columns(0).HeaderText = "ID"

                .Columns(1).DefaultCellStyle = Style1
                .Columns(1).HeaderText = "NOMBRE PACIENTE"

                .Columns(2).DefaultCellStyle = Style1
                .Columns(2).HeaderText = "APELLIDO PACIENTE"

                .Columns(3).DefaultCellStyle = Style1
                .Columns(3).HeaderText = "No. DOCUMENTO"

                .Columns(4).DefaultCellStyle = Style2
                .Columns(4).HeaderText = "No.H.C."


            End With

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia



    End Sub


    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

        'Abrimos la Ventana Primero

        frmPacientes.MdiParent = mdiOrthoSoft
        'Display the new form.
        frmPacientes.Show()
        frmPacientes.Activate()

        '*************************************** CARGAMOS LOS DATOS DEL PACIENTE *******************************
      
        If control = True Then

            EVEN = New CLASE_EVENTOS
            EVEN.cargarpacientedatos(Me.dgPacientes.CurrentRow.Cells(0).Value)
            EVEN = Nothing

        Else

            EVEN = New CLASE_EVENTOS
            EVEN.cargarpacientedatos(indice)
            EVEN = Nothing


        End If

        Me.Dispose()
        Me.Close()


    End Sub

    Private Sub dgPacientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPacientes.CellContentClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

    End Sub

    Private Sub PacSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        '*************************************** CARGAMOS LOS DATOS DEL PACIENTE *******************************

        If control = True Then

            EVEN = New CLASE_EVENTOS
            EVEN.cargarpacienteficha(Me.dgPacientes.CurrentRow.Cells(0).Value)
            EVEN = Nothing
            control = True

        Else

            EVEN = New CLASE_EVENTOS
            EVEN.cargarpacienteficha(indice)
            EVEN = Nothing

        End If


    End Sub

    Private Sub dgPacientes_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgPacientes.MouseClick

        control = True
        Me.btnSeleccionar.Enabled = True
        Me.btnEditar.Enabled = True

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
        ubicarcontrol(Me.lblTotalPacientes)
        ubicarcontrol(Me.txtCount_pac)
        ubicarcontrol(Me.btnEditar)
        ubicarcontrol(Me.btnSalir)
        ubicarcontrol(Me.dgPacientes)

    End Sub

    Private Sub frmBuscarPacientes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

        cargar_grilla()

    End Sub

    Private Sub frmBuscarPacientes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub

    Private Sub rbtXApellidos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtXApellidos.CheckedChanged

        Me.lblNomBusqueda.Text = "Apellidos"
        Me.txtBusqueda.Text = ""
        Me.txtBusqueda.Focus()
        Me.listaResultados.Items.Clear()

    End Sub
End Class