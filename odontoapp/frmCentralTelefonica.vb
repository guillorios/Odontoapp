Imports System.Math

Public Class frmCentralTelefonica

    Private CITA As CLASE_CITAS
    Private PAC As CLASE_PACIENTES
    Private CTRL As CLASE_CONTROL
    Private CALLCENTER As CLASE_CALLCENTER
    Private CALLCENTER_N As CLASE_CALLCENTER_N

    'Variables de Control
    Private fecha As Date

    Private Sub GRIDSTYLES(ByVal opcion As String) ' crear un objeto para estilos del datagrid

        Try

            Dim Style1 As New DataGridViewCellStyle

            Style1.Alignment = DataGridViewContentAlignment.BottomLeft

            Dim Style2 As New DataGridViewCellStyle
            Style2.Alignment = DataGridViewContentAlignment.MiddleCenter

            Select Case opcion


                Case "citas"

                    With Me.dgConsultaCall

                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                        .ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                        .Columns(0).DefaultCellStyle = Style1
                        .Columns(0).HeaderText = "NOMBRES"

                        .Columns(1).DefaultCellStyle = Style1
                        .Columns(1).HeaderText = "APELLIDOS"

                        .Columns(2).DefaultCellStyle = Style1
                        .Columns(2).HeaderText = "DIRECCION"

                        .Columns(3).DefaultCellStyle = Style2
                        .Columns(3).HeaderText = "No. HISTORIA"

                        .Columns(4).DefaultCellStyle = Style1
                        .Columns(4).HeaderText = "TELEFONO"

                        .Columns(5).DefaultCellStyle = Style1
                        .Columns(5).HeaderText = "EMAIL"

                        .Columns(6).DefaultCellStyle = Style1
                        .Columns(6).HeaderText = "CELULAR"

                        .Columns(7).DefaultCellStyle = Style2
                        .Columns(7).HeaderText = "HORA INI."

                        .Columns(8).DefaultCellStyle = Style2
                        .Columns(8).HeaderText = "HORA FIN."

                        .Columns(9).DefaultCellStyle = Style2
                        .Columns(9).HeaderText = "CONSULTA"


                    End With

                Case "pacientes"

                    With Me.dgConsultaCall

                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue
                        .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                        .ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                        .Columns(0).DefaultCellStyle = Style1
                        .Columns(0).HeaderText = "NOMBRES"

                        .Columns(1).DefaultCellStyle = Style1
                        .Columns(1).HeaderText = "APELLIDOS"

                        .Columns(2).DefaultCellStyle = Style1
                        .Columns(2).HeaderText = "DIRECCION"

                        .Columns(3).DefaultCellStyle = Style2
                        .Columns(3).HeaderText = "No. HISTORIA"

                        .Columns(4).DefaultCellStyle = Style1
                        .Columns(4).HeaderText = "TELEFONO"

                        .Columns(5).DefaultCellStyle = Style1
                        .Columns(5).HeaderText = "EMAIL"

                        .Columns(6).DefaultCellStyle = Style2
                        .Columns(6).HeaderText = "FECHA NAC."

                        .Columns(7).DefaultCellStyle = Style1
                        .Columns(7).HeaderText = "CELULAR"


                    End With

            End Select

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Sub

    Private Sub btnCallCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallCargar.Click

        Try

            If Me.rbtcitas.Checked = True Then

                CITA = New CLASE_CITAS
                fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
                CITA.p_fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
                CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

                CITA.Seleccionar("informecitasdiasiguiente")

                Me.dgConsultaCall.DataSource = CLASE_GENERAL.xdt
                Me.dgConsultaCall.Update()

                GRIDSTYLES("citas")

                CITA.dispose()
                CITA = Nothing

                If Me.dgConsultaCall.RowCount > 0 Then

                    Me.btnEnviarCallCenter.Enabled = True

                Else

                    Me.btnEnviarCallCenter.Enabled = False

                End If


            End If

            If Me.rbtpacCumple.Checked = True Then

                PAC = New CLASE_PACIENTES
                PAC.Seleccionar("informecumpleañoshoycallcenter")

                Me.dgConsultaCall.DataSource = CLASE_GENERAL.xdt
                Me.dgConsultaCall.Update()

                GRIDSTYLES("pacientes")

                PAC.dispose()
                PAC = Nothing

                If Me.dgConsultaCall.RowCount > 0 Then

                    Me.btnEnviarCallCenter.Enabled = True

                Else

                    Me.btnEnviarCallCenter.Enabled = False

                End If

            End If


            If Me.rbtpacNoAsistieron.Checked = True Then

                CITA = New CLASE_CITAS
                fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
                CITA.p_fecha = My.Forms.mdiOrthoSoft.CalOrthosoft.Year & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Month, "0#") & "-" & Format(My.Forms.mdiOrthoSoft.CalOrthosoft.Day, "0#")
                CITA.p_Iddoctor = My.Forms.mdiOrthoSoft.lblActivoDoctor.Tag

                CITA.Seleccionar("informecitassinasistirhoy")

                Me.dgConsultaCall.DataSource = CLASE_GENERAL.xdt
                Me.dgConsultaCall.Update()

                GRIDSTYLES("citas")

                CITA.dispose()
                CITA = Nothing

                If Me.dgConsultaCall.RowCount > 0 Then

                    Me.btnEnviarCallCenter.Enabled = True

                Else

                    Me.btnEnviarCallCenter.Enabled = False

                End If

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Private Sub cargarcitas()

        Try

            Me.prgBarraProgreso.Value = 0
            Dim i As Integer

            If Me.rbtcitas.Checked = True Then

                CLASE_GENERAL_FOX.configuracion(CLASE_GENERAL_FOX.foxmensaje_error)
                CLASE_GENERAL_FOX.iniciar(CLASE_GENERAL_FOX.foxmensaje_error, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CLASE_GENERAL_FOX.foxRuta & ";Extended Properties=dBASE IV;User ID=" & CLASE_GENERAL_FOX.foxUsuario & ";Password=" & CLASE_GENERAL_FOX.foxClave & ";")
                CALLCENTER = New CLASE_CALLCENTER

                CALLCENTER.Eliminar("citasmañana")

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    CALLCENTER.p_Telephone = CLASE_GENERAL.xdt.Rows(i).Item("Telcasa_con")
                    CALLCENTER.p_Last_name = CLASE_GENERAL.xdt.Rows(i).Item("apellidos_pac")
                    CALLCENTER.p_First_name = CLASE_GENERAL.xdt.Rows(i).Item("nombres_pac")
                    CALLCENTER.p_Address_1 = CLASE_GENERAL.xdt.Rows(i).Item("residencia_pac")
                    CALLCENTER.p_Emailaddr = CLASE_GENERAL.xdt.Rows(i).Item("email_con")

                    CALLCENTER.Insertar("citasmañana")

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaCall.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Next

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CALLCENTER.dispose()
                CALLCENTER = Nothing

                CLASE_GENERAL_FOX.terminar(CLASE_GENERAL_FOX.foxmensaje_error)
                MsgBox("Archivo e Informe Creado con éxito", MsgBoxStyle.OkOnly, "CallCenter")

            End If

            If Me.rbtpacCumple.Checked = True Then

                CLASE_GENERAL_FOX.configuracion(CLASE_GENERAL_FOX.foxmensaje_error)
                CLASE_GENERAL_FOX.iniciar(CLASE_GENERAL_FOX.foxmensaje_error, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CLASE_GENERAL_FOX.foxRuta & ";Extended Properties=dBASE IV;User ID=" & CLASE_GENERAL_FOX.foxUsuario & ";Password=" & CLASE_GENERAL_FOX.foxClave & ";")
                CALLCENTER = New CLASE_CALLCENTER

                CALLCENTER.Eliminar("cumpleaños")

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    CALLCENTER.p_Telephone = CLASE_GENERAL.xdt.Rows(i).Item("Telcasa_con")
                    CALLCENTER.p_Last_name = CLASE_GENERAL.xdt.Rows(i).Item("apellidos_pac")
                    CALLCENTER.p_First_name = CLASE_GENERAL.xdt.Rows(i).Item("nombres_pac")
                    CALLCENTER.p_Address_1 = CLASE_GENERAL.xdt.Rows(i).Item("residencia_pac")
                    CALLCENTER.p_Emailaddr = CLASE_GENERAL.xdt.Rows(i).Item("email_con")

                    CALLCENTER.Insertar("cumpleaños")

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaCall.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Next

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CALLCENTER.dispose()
                CALLCENTER = Nothing

                CLASE_GENERAL_FOX.terminar(CLASE_GENERAL_FOX.foxmensaje_error)
                MsgBox("Archivo e Informe Creado con éxito", MsgBoxStyle.OkOnly, "CallCenter")

            End If

            If Me.rbtpacNoAsistieron.Checked = True Then

                CLASE_GENERAL_FOX.configuracion(CLASE_GENERAL_FOX.foxmensaje_error)
                CLASE_GENERAL_FOX.iniciar(CLASE_GENERAL_FOX.foxmensaje_error, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CLASE_GENERAL_FOX.foxRuta & ";Extended Properties=dBASE IV;User ID=" & CLASE_GENERAL_FOX.foxUsuario & ";Password=" & CLASE_GENERAL_FOX.foxClave & ";")
                CALLCENTER = New CLASE_CALLCENTER

                CALLCENTER.Eliminar("citasna")

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    CALLCENTER.p_Telephone = CLASE_GENERAL.xdt.Rows(i).Item("Telcasa_con")
                    CALLCENTER.p_Last_name = CLASE_GENERAL.xdt.Rows(i).Item("apellidos_pac")
                    CALLCENTER.p_First_name = CLASE_GENERAL.xdt.Rows(i).Item("nombres_pac")
                    CALLCENTER.p_Address_1 = CLASE_GENERAL.xdt.Rows(i).Item("residencia_pac")
                    CALLCENTER.p_Emailaddr = CLASE_GENERAL.xdt.Rows(i).Item("email_con")

                    CALLCENTER.Insertar("citasna")

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaCall.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Next

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CALLCENTER.dispose()
                CALLCENTER = Nothing

                Me.prgBarraProgreso.Value = 100
                Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                Me.prgBarraProgreso.Refresh()

                CLASE_GENERAL_FOX.terminar(CLASE_GENERAL_FOX.foxmensaje_error)
                MsgBox("Archivo e Informe Creado con éxito", MsgBoxStyle.OkOnly, "CallCenter")

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia



    End Sub

    Private Sub cargarcitas_n()

        Try

            Me.prgBarraProgreso.Value = 0

            Dim i As Integer

            If Me.rbtcitas.Checked = True Then

                CLASE_GENERAL_ACCESS.configuracion(CLASE_GENERAL_ACCESS.accmensaje_error)
                CLASE_GENERAL_ACCESS.iniciar(CLASE_GENERAL_ACCESS.accmensaje_error, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CLASE_GENERAL_ACCESS.accRuta & ";User ID=" & CLASE_GENERAL_ACCESS.accUsuario & ";Password=" & CLASE_GENERAL_ACCESS.accClave & ";")
                CALLCENTER_N = New CLASE_CALLCENTER_N

                CALLCENTER_N.Eliminar("citasmañana")

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    CALLCENTER_N.p_Telephone = CLASE_GENERAL.xdt.Rows(i).Item("Telcasa_con")
                    CALLCENTER_N.p_Last_Name = CLASE_GENERAL.xdt.Rows(i).Item("apellidos_pac")
                    CALLCENTER_N.p_First_Name = CLASE_GENERAL.xdt.Rows(i).Item("nombres_pac")
                    CALLCENTER_N.p_Address_1 = CLASE_GENERAL.xdt.Rows(i).Item("residencia_pac")
                    CALLCENTER_N.p_Email_Address = CLASE_GENERAL.xdt.Rows(i).Item("email_con")

                    CALLCENTER_N.Insertar("citasmañana")

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaCall.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Next

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CALLCENTER_N.dispose()
                CALLCENTER_N = Nothing

                CLASE_GENERAL_ACCESS.terminar(CLASE_GENERAL_ACCESS.accmensaje_error)
                MsgBox("Archivo e Informe Creado con éxito", MsgBoxStyle.OkOnly, "Call Center")

            End If

            If Me.rbtpacCumple.Checked = True Then

                CLASE_GENERAL_ACCESS.configuracion(CLASE_GENERAL_ACCESS.accmensaje_error)
                CLASE_GENERAL_ACCESS.iniciar(CLASE_GENERAL_ACCESS.accmensaje_error, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CLASE_GENERAL_ACCESS.accRuta & ";User ID=" & CLASE_GENERAL_ACCESS.accUsuario & ";Password=" & CLASE_GENERAL_ACCESS.accClave & ";")
                CALLCENTER_N = New CLASE_CALLCENTER_N

                CALLCENTER_N.Eliminar("cumpleaños")

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    CALLCENTER_N.p_Telephone = CLASE_GENERAL.xdt.Rows(i).Item("Telcasa_con")
                    CALLCENTER_N.p_Last_Name = CLASE_GENERAL.xdt.Rows(i).Item("apellidos_pac")
                    CALLCENTER_N.p_First_Name = CLASE_GENERAL.xdt.Rows(i).Item("nombres_pac")
                    CALLCENTER_N.p_Address_1 = CLASE_GENERAL.xdt.Rows(i).Item("residencia_pac")
                    CALLCENTER_N.p_Email_Address = CLASE_GENERAL.xdt.Rows(i).Item("email_con")

                    CALLCENTER_N.Insertar("cumpleaños")

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaCall.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Next

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CALLCENTER_N.dispose()
                CALLCENTER_N = Nothing

                CLASE_GENERAL_ACCESS.terminar(CLASE_GENERAL_ACCESS.accmensaje_error)
                MsgBox("Archivo e Informe Creado con éxito", MsgBoxStyle.OkOnly, "Call Center")

            End If


            If Me.rbtpacNoAsistieron.Checked = True Then

                CLASE_GENERAL_ACCESS.configuracion(CLASE_GENERAL_ACCESS.accmensaje_error)
                CLASE_GENERAL_ACCESS.iniciar(CLASE_GENERAL_ACCESS.accmensaje_error, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & CLASE_GENERAL_ACCESS.accRuta & ";User ID=" & CLASE_GENERAL_FOX.foxUsuario & ";Password=" & CLASE_GENERAL_ACCESS.accClave & ";")
                CALLCENTER_N = New CLASE_CALLCENTER_N

                CALLCENTER_N.Eliminar("citasna")

                For i = 0 To CLASE_GENERAL.xdt.Rows.Count - 1

                    CALLCENTER_N.p_Telephone = CLASE_GENERAL.xdt.Rows(i).Item("Telcasa_con")
                    CALLCENTER_N.p_Last_Name = CLASE_GENERAL.xdt.Rows(i).Item("apellidos_pac")
                    CALLCENTER_N.p_First_Name = CLASE_GENERAL.xdt.Rows(i).Item("nombres_pac")
                    CALLCENTER_N.p_Address_1 = CLASE_GENERAL.xdt.Rows(i).Item("residencia_pac")
                    CALLCENTER_N.p_Email_Address = CLASE_GENERAL.xdt.Rows(i).Item("email_con")

                    CALLCENTER_N.Insertar("citasna")

                    Me.prgBarraProgreso.Value = Round((i + 1 * 100) / Me.dgConsultaCall.Rows.Count)
                    Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                    Me.prgBarraProgreso.Refresh()

                Next

                CLASE_GENERAL.xdt.Dispose()
                CLASE_GENERAL.xdt = Nothing

                CALLCENTER_N.dispose()
                CALLCENTER_N = Nothing

                Me.prgBarraProgreso.Value = 100
                Me.prgBarraProgreso.Text = Me.prgBarraProgreso.Value & " %"
                Me.prgBarraProgreso.Refresh()

                CLASE_GENERAL_ACCESS.terminar(CLASE_GENERAL_ACCESS.accmensaje_error)
                MsgBox("Archivo e Informe Creado con éxito", MsgBoxStyle.OkOnly, "Call Center")

            End If

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub


    Private Sub btnCallSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallSalir.Click

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub rbtcitas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtcitas.CheckedChanged

        Me.lblTituloConsulta.Text = "Informe de Citas"

        If Not (dgConsultaCall.Rows.Count = 0) Then

            Me.dgConsultaCall.DataSource = Nothing

        End If

    End Sub

    Private Sub rbtpacNoAsistieron_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtpacNoAsistieron.CheckedChanged

        Me.lblTituloConsulta.Text = "Informe de Pacietes que no Asistieron a su Cita Hoy"

        If Not (dgConsultaCall.Rows.Count = 0) Then

            Me.dgConsultaCall.DataSource = Nothing

        End If

    End Sub

    Private Sub rbtpacCumple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtpacCumple.CheckedChanged

        Me.lblTituloConsulta.Text = "Pacientes que cumplen años Hoy"

        If Not (dgConsultaCall.Rows.Count = 0) Then

            Me.dgConsultaCall.DataSource = Nothing

        End If

    End Sub

    Private Sub btnEnviarCallCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarCallCenter.Click

        If Me.rbCallCenterV1.Checked = True Then

            cargarcitas()

        ElseIf Me.rbCallCenterV2.Checked = True Then

            cargarcitas_n()
            Shell("c:\Tellacom\ExpressDialer_Settings.exe")

        End If

    End Sub

    Private Sub frmCentralTelefonica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If CLASE_GENERAL._tipocallcenter_cons = 1 Then

            Me.rbCallCenterV1.Checked = True


        ElseIf CLASE_GENERAL._tipocallcenter_cons = 2 Then

            Me.rbCallCenterV2.Checked = True

        End If

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

        'Estado de Cuenta
        ubicarcontrol(Me.lblTituloVentana)
        ubicarcontrol(Me.gpOpcionInforme)
        ubicarcontrol(Me.lblTituloConsulta)
        ubicarcontrol(Me.gpCallCenter)
        ubicarcontrol(Me.dgConsultaCall)
        ubicarcontrol(Me.prgBarraProgreso)
        ubicarcontrol(Me.btnCallCargar)
        ubicarcontrol(Me.btnEnviarCallCenter)
        ubicarcontrol(Me.btnCallSalir)

    End Sub

    Private Sub frmCentralTelefonica_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ubicarcontroles()
    End Sub
End Class