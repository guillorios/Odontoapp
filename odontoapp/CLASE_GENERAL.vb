Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.IO

Public Class CLASE_GENERAL

#Region "objetos de conexion"

    'Objetos de conexion y manupulacion de base de datos
    Public Shared xcon As MySqlConnection ' Objeto que nos permite hacer la conexion fisica con la base de datos
    Public Shared xcomando As MySqlCommand ' Objeto para ejecutar la consulta y la conexio
    Public Shared xda As MySqlDataAdapter '
    Public Shared xdr As MySqlDataReader
    Public Shared xds As DataSet
    Public Shared xdt As DataTable
    Public Shared xdt2 As DataTable
    Public Shared xdt3 As DataTable

    'Objetos de conexion grillas detalle maesto
    Public Shared xdtdetalle As DataTable
    Public Shared xdtmaestro As DataTable
    Public Shared xdamaestro As MySqlDataAdapter
    Public Shared xdadetalle As MySqlDataAdapter
    Public Shared xbsmaestro As BindingSource
    Public Shared xbsdetalle As BindingSource
    Public Shared xrelations As DataRelation

    Public Shared sql As String
    Public Shared mensaje_error As String
    Public Shared estado_conexion As Boolean

    'objetos de captura de configuracion
    Public Shared sFicINI As String
    Public Shared Servidor As String
    Public Shared BD As String
    Public Shared Usuario As String
    Public Shared Clave As String

    'objetos de captura de configuración servidor smtp
    Public Shared smtpNombre As String
    Public Shared smtpCuenta As String
    Public Shared smtpHost As String
    Public Shared smtpPort As String
    Public Shared smtpPass As String

    'objeto de captura de la Ruta de las Imagenes
    Public Shared rutaimagenes As String

    'Variables de Inicio de Configuracion
    Public Shared OpcionINI As String
    Public Shared Nivel As Integer

    'Variables de Resolucion de Configuracion
    Public Shared xheigth As Integer
    Public Shared xwidth As Integer
    Public Shared xresol As Integer
    Public Shared xmaxiwidth As Integer
    Public Shared xmaxiheigth As Integer

    'Variables de datos
    Public Shared maxi As Integer
    Public Shared count As Integer
    Public Shared count2 As Integer
    Public Shared consecutivo As Integer
    Public Shared formload As Integer = 0 ' Nos controla que formulario esta activo
    Public Shared formloadcal As Integer = 0 ' Nos controla que formulario esta activo
    Public Shared formloadrc As Integer = 0 ' Nos controla que formulario esta activo
    Public Shared controlrc As Integer = 0 'Nos controla que el rc sea uno nuevo
    Public Shared sheduler As Integer = 0 'Nos controla que el rc sea uno nuevo

    Public Shared ingreso As Integer = 0

    'Variables de Items

    Public Shared _Idpaciente_consec As Integer
    Public Shared _Iddoctor_consec As Integer
    Public Shared _Idempleado_consec As Integer
    Public Shared _Idhuella_consec As Integer
    Public Shared _Iddedo_consec As Integer
    Public Shared _TipoUsuario As Integer


    'Variables de Entorno de Consultorio

    Public Shared _Idconsultorio As Integer
    Public Shared _razonsocial_cons As String
    Public Shared _nit_cons As String
    Public Shared _direccion_cons As String
    Public Shared _web_cons As String
    Public Shared _email_cons As String
    Public Shared _actividad_cons As String
    Public Shared _rtelegal_cons As String
    Public Shared _documento_cons As String
    Public Shared _ciudaddoc_cons As String
    Public Shared _tel1_cons As String
    Public Shared _tel2_cons As String
    Public Shared _celular_cons As String
    Public Shared _fax_cons As String
    Public Shared _Iddoctor As String
    Public Shared _horaini As String
    Public Shared _horafin As String
    Public Shared _horaini2 As TimeSpan
    Public Shared _horafin2 As TimeSpan
    Public Shared _rangocal As String
    Public Shared _tipocallcenter_cons As Integer
    Public Shared _textopiecita As String
    Public Shared _topecita As Integer
    Public Shared _icono_cons As Image
    Public Shared _formatopos As String

    'Variables de procedimientos
    Public Shared _Idprocedimiento As Integer

    Public Shared CRIPTO As CLASE_ENCRIPTAR

    'Variables de Imagenes
    Public Shared SourceToImage As Bitmap

#End Region

#Region "Funciones para iniciar terminar sesion base datos"

    Public Shared Function iniciar(ByVal mensaje As String, ByVal cadenacon As String) As Boolean
        'Control de exepcion de errores
        Try
            xcon = New MySqlConnection(cadenacon) ' El objeto recibe como parametro la cadena de conexion que nos permite trabajar con la BD
            xcon.Open()
            Return True
        Catch ex As MySqlException
            MsgBox("NO SE PUEDE CONECTAR A LA BASE DE DATOS, VERIFIQUE Y REINICIE LA APLICACION", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Shared Function terminar(ByVal mensaje As String) As Boolean
        Try
            xcon.Close()
            xcon = Nothing

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Shared Function configuracion(ByVal mensaje As String) As Boolean

        Dim mINI As New cIniArray

        CRIPTO = New CLASE_ENCRIPTAR

        'Control de exepcion de errores

        Try
            sFicINI = Application.StartupPath & "\config.ini"
            
            'Opciones Autenticación MYSQL
            Servidor = mINI.IniGet(sFicINI, "Autenticacion", "Servidor")
            BD = mINI.IniGet(sFicINI, "Autenticacion", "BD")
            Usuario = mINI.IniGet(sFicINI, "Autenticacion", "Usuario")
            Clave = CRIPTO.DesEncripta(mINI.IniGet(sFicINI, "Autenticacion", "Clave"))

            'Opciones de Inicio
            OpcionINI = mINI.IniGet(sFicINI, "Inicio", "Opcion")

            'Opciones Autenticación SMTP

            smtpNombre = mINI.IniGet(sFicINI, "Email", "Nombre")
            smtpCuenta = mINI.IniGet(sFicINI, "Email", "Cuenta")
            smtpHost = mINI.IniGet(sFicINI, "Email", "Smtphost")
            smtpPort = mINI.IniGet(sFicINI, "Email", "Smtpport")
            smtpPass = CRIPTO.DesEncripta(mINI.IniGet(sFicINI, "Email", "Clave"))

            'Opciones Captura ruta de las Imagens

            rutaimagenes = mINI.IniGet(sFicINI, "Rutaimagenes", "Ruta")

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

#End Region

#Region "Cargar_combos"

    Public Shared Function cargar_combo(ByVal opcion As String, ByRef combo As System.Windows.Forms.ComboBox, ByVal mensaje As String) As Boolean

        Try

            Select Case opcion

                Case "entidades"

                    sql = "SELECT IdEntidad, nombre_ent FROM entidades ORDER BY nombre_ent ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nombre_ent").Caption
                    combo.ValueMember = xdt.Columns("Identidad").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


                    Return True

                Case "doctores"

                    sql = "SELECT IdDoctor, CONCAT(nombres_doc,' ', apellidos_doc) as Nombres FROM doctores ORDER BY Nombres ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("Nombres").Caption
                    combo.ValueMember = xdt.Columns("Iddoctor").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


                    Return True

                Case "empleados"

                    sql = "SELECT IdEmpleado, CONCAT(nombres_emp,' ', apellidos_emp) as Nombres FROM empleados ORDER BY Nombres ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("Nombres").Caption
                    combo.ValueMember = xdt.Columns("Idempleado").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True

                Case "mensajes"

                    sql = "SELECT IdMensaje, titulo FROM mensajes ORDER BY Titulo ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("titulo").Caption
                    combo.ValueMember = xdt.Columns("Idmensaje").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True

                Case "mensajesprocedimientos"

                    sql = "SELECT IdMensaje, titulo FROM mensajesprocedimientos ORDER BY Titulo ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("titulo").Caption
                    combo.ValueMember = xdt.Columns("Idmensaje").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


                    Return True


                Case "tipoconsulta"

                    sql = "SELECT Idtconsulta, nomconsulta FROM tipoconsulta ORDER BY Idtconsulta ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nomconsulta").Caption
                    combo.ValueMember = xdt.Columns("Idtconsulta").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                Case "tipoconsultadoctores"

                    sql = "SELECT Idtconsulta, nomconsulta FROM tipoconsulta WHERE Idespecialidad = " & CInt(mensaje) & " OR Idespecialidad = '2' ORDER BY Idtconsulta ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nomconsulta").Caption
                    combo.ValueMember = xdt.Columns("Idtconsulta").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


                    Return True

                Case "perfilesacceso"

                    sql = "SELECT Idperfil, nom_perf FROM perfilesaccceso ORDER BY Idperfil ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nom_perf").Caption
                    combo.ValueMember = xdt.Columns("Idperfil").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


                    Return True

                Case "galeria"

                    sql = "SELECT IdImagen, descripcion_img FROM galeria WHERE IdTipo_img = '1' AND IdUsuario= " & CInt(mensaje) & " ORDER BY IdImagen ASC "


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("descripcion_img").Caption
                    combo.ValueMember = xdt.Columns("IdImagen").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


                    Return True

                Case "galeriageneral"

                    sql = "SELECT IdImagen, descripcion_img FROM galeria WHERE IdTipo_img = '2' ORDER BY IdImagen ASC "


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("descripcion_img").Caption
                    combo.ValueMember = xdt.Columns("IdImagen").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True


                Case "operadorescel"

                    sql = "SELECT Idoperador, nom_oper FROM orthosoft.operadorcel ORDER BY Idoperador ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nom_oper").Caption
                    combo.ValueMember = xdt.Columns("Idoperador").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


                    Return True

                Case "items"

                    sql = "SELECT Idprocedimiento, CONCAT(descripcion_proc,' ', referencia_proc) as descripcion FROM orthosoft.procedimientos WHERE ORDER BY descripcion ASC "
                    'sql = "SELECT Idprocedimiento, descripcion_proc FROM orthosoft.procedimientos ORDER BY descripcion_proc ASC "

                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("descripcion").Caption
                    combo.ValueMember = xdt.Columns("Idprocedimiento").Caption
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True


                Case "itemsespecialidad"

                    sql = "SELECT Idprocedimiento, CONCAT(descripcion_proc,' ', referencia_proc) as descripcion FROM orthosoft.procedimientos WHERE Idespecialidad = " & CInt(mensaje) & " ORDER BY descripcion ASC "
                    'sql = "SELECT Idprocedimiento, descripcion_proc FROM orthosoft.procedimientos ORDER BY descripcion_proc ASC "

                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("descripcion").Caption
                    combo.ValueMember = xdt.Columns("Idprocedimiento").Caption
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True

                Case "gastos"

                    sql = "SELECT Idgasto, concepto_gas FROM orthosoft.gastos ORDER BY concepto_gas ASC "


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("concepto_gas").Caption
                    combo.ValueMember = xdt.Columns("Idgasto").Caption
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True

                Case "proveedores"

                    sql = "SELECT Idproveedor, nombre_prov FROM orthosoft.proveedores ORDER BY nombre_prov ASC "


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nombre_prov").Caption
                    combo.ValueMember = xdt.Columns("Idproveedor").Caption
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True

                Case "especialidades"

                    sql = "SELECT Idespecialidad, nom_especialidad FROM Orthosoft.especialidades ORDER BY Idespecialidad ASC "

                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nom_especialidad").Caption
                    combo.ValueMember = xdt.Columns("Idespecialidad").Caption
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                    Return True

                Case "estadounidades"

                    sql = "SELECT  Idestado, nom_estado FROM orthosoft.estadounidades ORDER BY nom_estado ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nom_estado").Caption
                    combo.ValueMember = xdt.Columns("Idestado").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing

                Case "presupuestos"

                    sql = "SELECT Idpresupuesto, nom_pres FROM Orthosoft.presupuesto WHERE (Idpaciente = " & CInt(mensaje) & ") ORDER BY Idpresupuesto ASC"


                    xdt = New DataTable
                    xcomando = New MySqlCommand(sql, xcon)
                    xda = New MySqlDataAdapter(xcomando)

                    xda.Fill(xdt) 'Ejecutar par cargar en combo
                    combo.DataSource = xdt

                    combo.DisplayMember = xdt.Columns("nom_pres").Caption
                    combo.ValueMember = xdt.Columns("Idpresupuesto").Caption

                    xda.Dispose()
                    xda = Nothing
                    xcomando.Dispose()
                    xcomando = Nothing


            End Select

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try 'cierra la sentencia

    End Function

#End Region

#Region "Cargar_grillas"

    Public Sub Cargar_Grilla(ByVal opcion As String, ByRef grilla As System.Windows.Forms.DataGridView, ByVal mensaje As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        Try 'sentencia para el manejo de errores

            xdt2 = New DataTable
            xdt3 = New DataTable

            Select Case opcion

                Case "pacientes"

                    sql = "SELECT idpaciente, nombres_pac, apellidos_pac, replace(replace(numdoc_pac, ',', ''), '.', '' ) AS numdoc_pac, replace(replace(nhclinica, ',', ''), '.', '' ) AS nhclinica FROM PACIENTES ORDER BY idpaciente ASC"

                Case "doctores"

                    sql = "SELECT iddoctor, nombres_doc, apellidos_doc FROM DOCTORES ORDER BY iddoctor ASC"
                   
                Case "empleados"

                    sql = "SELECT idempleado, nombres_emp, apellidos_emp FROM empleados ORDER BY idempleado ASC"

                Case "entidades"

                    sql = "SELECT identidad, nombre_ent, direccion_ent, contacto_ent FROM entidades ORDER BY identidad ASC"

                Case "procedimientos"

                    sql = "Select Idproced, procedimientodiario.proced, procedimientodiario.Fecha FROM orthosoft.pacientes INNER JOIN orthosoft.procedimientodiario ON (pacientes.Idpaciente = procedimientodiario.Idpaciente) WHERE procedimientodiario.Idpaciente = " & CInt(mensaje) & " ORDER BY procedimientodiario.Fecha DESC, procedimientodiario.Idproced DESC"

                Case "cuotas"

                    sql = "SELECT Idcuota, procedimiento_cuota, valor_cuota, abono_cuota, saldo_cuota, fecha_cuota, Idpresupuesto, Idprocedimiento FROM Orthosoft.cuotas WHERE Idpaciente = " & CInt(mensaje) & " AND tipo_cuota = '1' ORDER BY Idcuota , fecha_cuota ASC"

                Case "cuotasadicionales"

                    sql = "SELECT Idcuota, procedimiento_cuota, valor_cuota, abono_cuota, saldo_cuota, fecha_cuota, Idpresupuesto, Idprocedimiento FROM Orthosoft.cuotas WHERE Idpaciente = " & CInt(mensaje) & " AND tipo_cuota = '2' ORDER BY Idcuota, fecha_cuota ASC"

                Case "valorprocedimientos"

                    sql = "SELECT procedimientos.Idprocedimiento, procedimientos.descripcion_proc, procedimientos.referencia_proc, procedimientos.valor_proc, especialidades.nom_especialidad FROM orthosoft.procedimientos INNER JOIN orthosoft.especialidades ON (procedimientos.Idespecialidad = especialidades.Idespecialidad) ORDER BY Idprocedimiento ASC"

                Case "tipoconsulta"

                    sql = "SELECT Idtconsulta, nomconsulta, Color FROM Orthosoft.tipoconsulta ORDER BY Idtconsulta ASC"

                Case "recibosdecaja"

                    sql = "SELECT Idrc, Idprocedimiento, detalle, referencia, cantidad, valor, (valor*cantidad) as TOTAL FROM Orthosoft.detalle_rcaja WHERE Idrc = " & CInt(mensaje) & ""

                Case "maestrorecibosdecaja"

                    sql = "SELECT RIGHT(CONCAT('0000000000000', rcaja.Idrc), 5), rcaja.fecha_rc, rcaja.total_rc, rcaja.concepto_rc, rcaja.cheque_rc, rcaja.banco_rc , rcaja.observaciones_rc, estadodocumentos.nom_estado, CONCAT(empleados.nombres_emp,' ', empleados.apellidos_emp) as Nombres FROM Orthosoft.rcaja INNER JOIN orthosoft.estadodocumentos ON (rcaja.Idestado = estadodocumentos.Idestado) INNER JOIN orthosoft.empleados ON (empleados.Idempleado = rcaja.Idusuario) WHERE rcaja.Idpaciente = " & CInt(mensaje) & " AND rcaja.Idestado = 1 ORDER BY rcaja.fecha_rc ASC"

                Case "coloresprocedimientos"

                    sql = "SELECT Idtconsulta, tipoconsulta.nomconsulta, tipoconsulta.color, especialidades.nom_especialidad FROM Orthosoft.tipoconsulta INNER JOIN orthosoft.especialidades ON (tipoconsulta.Idespecialidad = especialidades.Idespecialidad) ORDER BY Idtconsulta ASC"

                Case "itemsgastos"

                    sql = "SELECT Idgasto, concepto_gas, observacion_gas FROM Orthosoft.gastos"

                Case "proveedores"

                    sql = "SELECT Idproveedor, nombre_prov, direccion_prov, contacto_prov, teloficina_prov, celular_prov, fax_prov, email_prov, web_prov FROM orthosoft.proveedores"

                Case "operadorescel"

                    sql = "SELECT Idoperador, nom_oper, dominio_oper FROM Orthosoft.operadorcel"

                Case "especialidades"

                    sql = "SELECT Idespecialidad, nom_especialidad FROM Orthosoft.especialidades"
                    
                Case "unidades"

                    sql = "SELECT Idunidad, unidades.nom_unidad, especialidades.nom_especialidad, estadounidades.nom_estado FROM Orthosoft.unidades INNER JOIN orthosoft.especialidades ON (unidades.Idespecialidad = especialidades.Idespecialidad) INNER JOIN orthosoft.estadounidades ON (unidades.Idestado = estadounidades.Idestado)"

                Case "unidadesagenda"

                    sql = "SELECT Idunidad, nom_unidad FROM Orthosoft.unidades ORDER BY Idunidad ASC"


            End Select

            xda = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega
            If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
            xda.Fill(xdt2)
            grilla.DataSource = xdt2
            grilla.Update()
            xda.Dispose()
            xda = Nothing

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

    Public Sub Cargar_Grilla_mestrodetalle(ByVal opcion As String, ByRef grillamaestro As System.Windows.Forms.DataGridView, ByRef grilladetalle As System.Windows.Forms.DataGridView, ByVal opcion1 As String, ByVal opcion2 As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        Try 'sentencia para el manejo de errores

            xds = New DataSet
            xds.Locale = System.Globalization.CultureInfo.InvariantCulture

            Select Case opcion

                Case "recibosdecaja"

                    sql = "SELECT Idrc as IDRC, rcaja.fecha_rc, rcaja.total_rc, rcaja.concepto_rc, rcaja.cheque_rc, rcaja.banco_rc , rcaja.observaciones_rc, estadodocumentos.nom_estado, CONCAT(empleados.nombres_emp,' ', empleados.apellidos_emp) as Nombres FROM Orthosoft.rcaja INNER JOIN orthosoft.estadodocumentos ON (rcaja.Idestado = estadodocumentos.Idestado) INNER JOIN orthosoft.empleados ON (empleados.Idempleado = rcaja.Idusuario) WHERE rcaja.Idpaciente = " & CInt(opcion1) & " AND rcaja.Idestado = 1 ORDER BY rcaja.fecha_rc ASC"
                    xdamaestro = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega

                    If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
                    xdamaestro.Fill(xds, "Maestro")

                    sql = "SELECT detalle_rcaja.Idrc AS IDRC, detalle_rcaja.Idprocedimiento AS ITEM, detalle_rcaja.detalle AS DETALLE, detalle_rcaja.referencia AS REF, valor AS VALOR,  detalle_rcaja.cantidad AS CANT, ( detalle_rcaja.valor *  detalle_rcaja.cantidad) AS TOTAL FROM orthosoft.detalle_rcaja INNER JOIN orthosoft.rcaja ON (detalle_rcaja.Idrc = rcaja.Idrc) WHERE rcaja.Idpaciente = " & CInt(opcion1) & " AND rcaja.Idestado = 1"
                    xdadetalle = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega

                    If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
                    xdadetalle.Fill(xds, "Detalle")


                    ' Establish a relationship between the two tables.
                    xrelations = New DataRelation("FK", xds.Tables("Maestro").Columns("IDRC"), xds.Tables("Detalle").Columns("IDRC"))
                    xds.Relations.Add(xrelations)

                    xbsmaestro = New BindingSource
                    xbsdetalle = New BindingSource

                    xbsmaestro.DataSource = xds
                    xbsmaestro.DataMember = "Maestro"

                    xbsdetalle.DataSource = xbsmaestro
                    xbsdetalle.DataMember = "FK"

                    grillamaestro.DataSource = xbsmaestro
                    grillamaestro.Update()
                    grilladetalle.DataSource = xbsdetalle
                    grilladetalle.Update()

                Case "presupuestos"

                    'sql = "SELECT Idrc as IDRC, rcaja.fecha_rc, rcaja.total_rc, rcaja.concepto_rc, rcaja.cheque_rc, rcaja.banco_rc , rcaja.observaciones_rc, estadodocumentos.nom_estado, CONCAT(empleados.nombres_emp,' ', empleados.apellidos_emp) as Nombres FROM Orthosoft.rcaja INNER JOIN orthosoft.estadodocumentos ON (rcaja.Idestado = estadodocumentos.Idestado) INNER JOIN orthosoft.empleados ON (empleados.Idempleado = rcaja.Idusuario) WHERE rcaja.Idpaciente = " & CInt(opcion1) & " AND rcaja.Idestado = 1 ORDER BY rcaja.fecha_rc ASC"
                    sql = " SELECT Idpresupuesto AS PRESUPUESTO, presupuesto.nom_pres, especialidades.nom_especialidad, presupuesto.fecha_pres, presupuesto.VTotalPresupuesto, estados.nomestado FROM Orthosoft.presupuesto INNER JOIN orthosoft.especialidades ON (presupuesto.Idespecialidad = especialidades.Idespecialidad) INNER JOIN orthosoft.estados ON (presupuesto.Idestado = estados.Idestado) WHERE presupuesto.Idpaciente = " & CInt(opcion1) & " ORDER BY presupuesto.fecha_pres ASC"
                    xdamaestro = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega

                    If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
                    xdamaestro.Fill(xds, "Maestro")

                    'sql = "SELECT detalle_rcaja.Idrc AS IDRC, detalle_rcaja.Idprocedimiento AS ITEM, detalle_rcaja.detalle AS DETALLE, detalle_rcaja.referencia AS REF, valor AS VALOR,  detalle_rcaja.cantidad AS CANT, ( detalle_rcaja.valor *  detalle_rcaja.cantidad) AS TOTAL FROM orthosoft.detalle_rcaja INNER JOIN orthosoft.rcaja ON (detalle_rcaja.Idrc = rcaja.Idrc) WHERE rcaja.Idpaciente = " & CInt(opcion1) & " AND rcaja.Idestado = 1"
                    sql = "SELECT cuotas.Idpresupuesto AS PRESUPUESTO, cuotas.Idcuota AS IDCUOTA, cuotas.fecha_cuota AS FECHA, cuotas.procedimiento_cuota AS PROCEDIMIENTO, cuotas.valor_cuota AS VALOR, cuotas.abono_cuota AS ABONO, cuotas.saldo_cuota AS SALDO, cuotas.descporc_cuota AS DESCUENTO, cuotas.valorporc_cuota AS VDESCUENTO FROM orthosoft.cuotas INNER JOIN orthosoft.presupuesto ON (cuotas.Idpresupuesto = presupuesto.Idpresupuesto) WHERE cuotas.Idpaciente = " & CInt(opcion1) & ""
                    xdadetalle = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega"

                    If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
                    xdadetalle.Fill(xds, "Detalle")

                    ' Establish a relationship between the two tables.
                    xrelations = New DataRelation("FK", xds.Tables("Maestro").Columns("PRESUPUESTO"), xds.Tables("Detalle").Columns("PRESUPUESTO"))
                    xds.Relations.Add(xrelations)

                    xbsmaestro = New BindingSource
                    xbsdetalle = New BindingSource

                    xbsmaestro.DataSource = xds
                    xbsmaestro.DataMember = "Maestro"

                    xbsdetalle.DataSource = xbsmaestro
                    xbsdetalle.DataMember = "FK"

                    grillamaestro.DataSource = xbsmaestro
                    grillamaestro.Update()
                    grilladetalle.DataSource = xbsdetalle
                    grilladetalle.Update()

            End Select

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

#End Region

#Region "Cargar_grillas_opciones"

    Public Sub Cargar_Grilla_Opciones(ByVal opcion As String, ByRef grilla As System.Windows.Forms.DataGridView, ByVal mensaje As String, ByVal valor1 As String, ByVal valor2 As String, ByVal valor3 As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        Try 'sentencia para el manejo de errores

            xdt2 = New DataTable

            Select Case opcion

                Case "recibosdecaja"

                    sql = "SELECT estadodocumentos.nom_estado, Idrc, pacientes.nombres_pac, pacientes.apellidos_pac, rcaja.fecha_rc, rcaja.total_rc, rcaja.concepto_rc, rcaja.cheque_rc, rcaja.banco_rc, rcaja.efectivo_rc, rcaja.tarjeta_rc FROM Orthosoft.rcaja INNER JOIN orthosoft.pacientes ON (rcaja.Idpaciente = pacientes.Idpaciente) INNER JOIN orthosoft.estadodocumentos ON (rcaja.Idestado = estadodocumentos.Idestado) WHERE fecha_rc = '" & valor1 & "' AND estado_cuadre = " & CInt(valor2) & ""

                Case "recibosdecajacuadrados"

                    sql = "SELECT estadodocumentos.nom_estado, Idrc, pacientes.nombres_pac, pacientes.apellidos_pac, rcaja.fecha_rc, rcaja.total_rc, rcaja.concepto_rc, rcaja.cheque_rc, rcaja.banco_rc, rcaja.efectivo_rc, rcaja.tarjeta_rc FROM Orthosoft.rcaja INNER JOIN orthosoft.pacientes ON (rcaja.Idpaciente = pacientes.Idpaciente) INNER JOIN orthosoft.estadodocumentos ON (rcaja.Idestado = estadodocumentos.Idestado) WHERE Idlibrodiario = " & CInt(valor1) & ""


                Case "comprobanteegreso"

                    sql = "SELECT estadodocumentos.nom_estado, Idce, proveedores.nombre_prov, cegreso.fecha_ce, cegreso.total_ce, cegreso.concepto_ce, cegreso.cheque_ce, cegreso.banco_ce FROM Orthosoft.cegreso INNER JOIN orthosoft.proveedores ON (cegreso.Idproveedor = proveedores.Idproveedor) INNER JOIN orthosoft.estadodocumentos ON (cegreso .Idestado = estadodocumentos.Idestado) WHERE fecha_ce = '" & valor1 & "' AND estado_cuadre = " & CInt(valor2) & ""

                Case "comprobanteegresocuadrados"

                    sql = "SELECT estadodocumentos.nom_estado, Idce, proveedores.nombre_prov, cegreso.fecha_ce, cegreso.total_ce, cegreso.concepto_ce, cegreso.cheque_ce, cegreso.banco_ce FROM Orthosoft.cegreso INNER JOIN orthosoft.proveedores ON (cegreso.Idproveedor = proveedores.Idproveedor) INNER JOIN orthosoft.estadodocumentos ON (cegreso .Idestado = estadodocumentos.Idestado) WHERE Idlibrodiario = " & CInt(valor1) & ""

                Case "cuotas"

                    sql = "SELECT Idcuota, procedimiento_cuota, valor_cuota, abono_cuota, saldo_cuota, fecha_cuota FROM Orthosoft.cuotas WHERE Idpaciente = " & CInt(mensaje) & " AND Idpresupuesto = " & CInt(valor1) & " AND tipo_cuota = '1' ORDER BY fecha_cuota ASC"


            End Select

            xda = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega
            If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
            xda.Fill(xdt2)
            grilla.DataSource = xdt2
            grilla.Update()

            xda.Dispose()
            xda = Nothing

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Sub

#End Region

#Region "Funciones para tratar imagenes"

    'Comprimir una Imagen
    Public Function comprimir_imagen(ByVal SourceImage As Bitmap, ByVal compression As Integer) As Bitmap
        Try
            'si hay imagen
            If Not SourceImage Is Nothing Then

                ' Generar un bitmap para el resultado
                SourceToImage = New Bitmap(SourceImage.Width, SourceImage.Height)

                ' Generar un objeto Gráfico para el Bitmap resultante
                Dim gr_source As Graphics = Graphics.FromImage(SourceToImage)

                ' Copiar la imagen origen al Bitmap destino
                gr_source.DrawImage(SourceImage, 0, 0, _
                    SourceToImage.Width, _
                    SourceToImage.Height)

                'Liberar recursos
                gr_source.Dispose()
                SourceImage.Dispose()

                '--------------------------------------
                'comprimimos la imagen

                Dim NeedsHorizontalCrop As Boolean = True
                Dim NeedsVerticalCrop As Boolean = False

                'Determina si la imagen es Landscape o Portrait
                If SourceToImage.Height > SourceToImage.Width Then
                    NeedsHorizontalCrop = False
                    NeedsVerticalCrop = True
                End If

                'Determina si la imagen excede el ancho del PictureBox
                If SourceToImage.Width < 200 Then
                    NeedsHorizontalCrop = False
                    If SourceToImage.Height > 150 Then
                        NeedsVerticalCrop = True
                    End If
                End If

                'Calcula el Factor de Ajuste
                Dim scale_factor As Single = 1
                If SourceToImage.Width > 0 Then
                    If NeedsHorizontalCrop = True Then
                        ' Obtiene el Factor de Ajuste
                        scale_factor = 200 / SourceToImage.Width
                    End If
                End If

                If SourceToImage.Height > 0 Then
                    If NeedsVerticalCrop = True Then
                        ' Obtiene el Factor de Ajuste
                        scale_factor = 150 / SourceToImage.Height
                    End If
                End If

                ' Generar un bitmap tmp para el resultado. Ajuste Proporcional
                Dim DestTmpImage As New Bitmap( _
                    CInt(SourceToImage.Width * scale_factor), _
                    CInt(SourceToImage.Height * scale_factor))

                ' Generar un objeto Gráfico para el bitmap tmp resultante
                Dim gr_desttmp As Graphics = Graphics.FromImage(DestTmpImage)

                ' Copiar la imagen origen al bitmap tmp destino
                gr_desttmp.DrawImage(SourceToImage, 0, 0, _
                    DestTmpImage.Width, _
                    DestTmpImage.Height)

                'Comprime y Guarda un Archivo Temporal para calcular su peso en Kb
                Try
                    ImageManipulation.SaveJPGWithCompressionSetting(DestTmpImage, My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "temp.jpg", compression)
                Catch exc As Exception
                    MessageBox.Show(exc, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'La lectura del nuevo archivo no se puede hacer en forma directa y repetitiva
                'ya que está bloqueado por GDI+ la 1era vez que se lo utiliza,
                'por lo tanto resulta necesario resolver en varios pasos. 
                'Al efectuar el Dispose() se libera el recurso

                Dim DestImage As Bitmap
                DestImage = New Bitmap(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & "temp.jpg")

                ' Generar un bitmap para el resultado
                Dim DestToImage As New Bitmap(DestImage.Width, DestImage.Height)

                ' Generar un objeto Grafico para el bitmap resultante
                Dim gr_dest As Graphics = Graphics.FromImage(DestToImage)

                ' Copiar la imagen origen al bitmap destino
                gr_dest.DrawImage(DestImage, 0, 0, _
                    DestToImage.Width, _
                    DestToImage.Height)

                'con el método FroStream de Image obtenemos imagen
                'Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return DestImage

                ''Liberar recursos
                'gr_dest.Dispose()
                'DestImage.Dispose()

                'gr_desttmp.Dispose()

            Else

                Return Nothing

            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    'convertir binario a imágen
    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    'convertir imagen a binario
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Png)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Public Function UpdateLogo(ByVal Sql As String, ByVal Data() As Byte) As String

        Dim Comando As New MySqlCommand(Sql, xcon)
        Comando.Parameters.AddWithValue("?imagen", Data)

        Try
            If Not xcon Is Nothing Then xcon.Close()
            xcon.Open()
            Dim res As Integer = Comando.ExecuteNonQuery()
            Return res.ToString

        Catch ex As Exception
            Return ex.Message
        Finally
            xcon.Close()
            Comando = Nothing
        End Try
    End Function

#End Region

#Region "Selecionar tabla"

    Public Sub seleccionar_tabla(ByVal opcion As String, ByVal mensaje As String) 'llenar datagrid (llenar grilla) se encuentra en consultar y modificar

        xdt = New DataTable

        Select Case opcion

            Case "t_pacientes"

                sql = "SELECT Id1, apellidos, nombres, residencia, oficina, tel_res, tel_of, referido, ocupacion, ID, notas, NO_AFILIACION, FECHA_ING, FECHA_NAC, SEXO FROM T_PACIENTES"
                xda = New MySqlDataAdapter(sql, xcon) 'llena el adaptador con el select enviado o el que llega

                Try 'sentencia para el manejo de errores
                    If xcon.State = Data.ConnectionState.Closed Then xcon.Open()
                    xda.Fill(xdt)

                    xda.Dispose()
                    xda = Nothing

                Catch ex As MySqlException 'captura errores sql
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                Catch ex As Exception 'captura cualquier tipo de errores
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
                End Try 'cierra la sentencia

        End Select


    End Sub

#End Region

#Region "Funciones Varias"

    Public Shared Function maximo(ByVal campo As String, ByVal tabla As String, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "select max(" & campo & ") from " & tabla & " "

            xcomando = New MySqlCommand(sql, xcon)

            If xcomando.ExecuteScalar() Is DBNull.Value Then
                maxi = 0
            Else
                maxi = xcomando.ExecuteScalar()
            End If


            xcomando.Dispose()
            xcomando = Nothing

            Return maxi
        Catch ex As InvalidCastException
            MsgBox("TABLA VACIA", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contar(ByVal campo As String, ByVal tabla As String, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "select count(" & campo & ") from " & tabla & " "

            count = 0

            xcomando = New MySqlCommand(sql, xcon)
            count = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contar2(ByVal campo As String, ByVal tabla As String, ByVal busqueda As Integer, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "select count(" & campo & ") from " & tabla & " where " & campo & " = " & busqueda & "  "

            count2 = 0

            xcomando = New MySqlCommand(sql, xcon)
            count2 = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count2

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Function

    Public Shared Function contarhuellas(ByVal IdUsuario As Integer, ByVal IdTUsuario As Integer, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "SELECT COUNT(Idhuella) FROM huellas WHERE IdUsuario = " & IdUsuario & " AND IdTUsuario  = " & IdTUsuario & ""

            count2 = 0

            xcomando = New MySqlCommand(sql, xcon)
            count2 = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count2

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Function

    Public Shared Function contarcontactos(ByVal IdUsuario As Integer, ByVal IdTUsuario As Integer, ByVal IdTTutor As Integer, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "SELECT COUNT(IdUsuario) FROM contactos WHERE IdUsuario = " & IdUsuario & " AND IdTUsuario  = " & IdTUsuario & " AND IdTTutor  = " & IdTTutor & "  "

            count2 = 0

            xcomando = New MySqlCommand(sql, xcon)
            count2 = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count2

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia

    End Function

    Public Shared Function contarcontactostodos(ByVal IdUsuario As Integer, ByVal IdTUsuario As Integer, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "SELECT COUNT(IdUsuario) FROM contactos WHERE IdUsuario = " & IdUsuario & " AND IdTUsuario  = " & IdTUsuario & ""

            count2 = 0

            xcomando = New MySqlCommand(sql, xcon)
            count2 = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count2

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contarnotas(ByVal IdUsuario As Integer, ByVal IdTUsuario As Integer, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "SELECT COUNT(IdUsuario) FROM notas WHERE IdUsuario = " & IdUsuario & " AND IdTUsuario  = " & IdTUsuario & ""

            count2 = 0

            xcomando = New MySqlCommand(sql, xcon)
            count2 = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count2

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contarimagenes(ByVal IdUsuario As Integer, ByVal IdTUsuario As Integer, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "SELECT COUNT(IdUsuario) FROM imagenes WHERE IdUsuario = " & IdUsuario & " AND IdTUsuario  = " & IdTUsuario & ""

            count2 = 0

            xcomando = New MySqlCommand(sql, xcon)
            count2 = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count2

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contarcitaspacientes(ByVal fecha As String, ByVal doctor As Integer) As Integer

        Try 'sentencia para el manejo de errores

            sql = "select count(Idcita) from citas WHERE fecha = '" & fecha & "' AND Iddoctor = " & doctor & ""

            count = 0

            xcomando = New MySqlCommand(sql, xcon)
            count = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contarcalendario(ByVal fecha As String, ByVal doctor As Integer) As Integer

        Try 'sentencia para el manejo de errores

            sql = "SELECT count(Idcalendario)FROM Orthosoft.calendario WHERE fecha = '" & fecha & "' AND Iddoctor = " & doctor & ""

            count = 0
            xcomando = New MySqlCommand(sql, xcon)
            count = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contarcalendario2(ByVal fecha As String, ByVal doctor As Integer, ByVal Idcontroldia As Integer) As Integer

        Try 'sentencia para el manejo de errores

            sql = "SELECT count(Idcalendario)FROM Orthosoft.calendario WHERE fecha = '" & fecha & "' AND Iddoctor = " & doctor & " AND Idcontroldia = " & Idcontroldia & ""

            xcomando = New MySqlCommand(sql, xcon)
            count = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function contarpresupuestos(ByVal campo1 As String, ByVal campo2 As String, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            sql = "select count(Idestado) from presupuesto WHERE Idpresupuesto = " & CInt(campo1) & " AND Idestado = " & CInt(campo2) & ""

            xcomando = New MySqlCommand(sql, xcon)
            count2 = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return count2

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function obtenerconsecutivo(ByVal campo1 As String, ByVal mensaje As String) As Integer

        Try 'sentencia para el manejo de errores

            Select Case mensaje

                Case "rcaja"

                    sql = "select consecrcaja_cons from consultorio WHERE  Idconsultorio = " & CInt(campo1) & ""

                Case "factura"

                    sql = "select consecfactura_cons from consultorio WHERE  Idconsultorio = " & CInt(campo1) & ""

                Case "cegreso"

                    sql = "select conseccegreso_cons from consultorio WHERE  Idconsultorio = " & CInt(campo1) & ""

            End Select

            xcomando = New MySqlCommand(sql, xcon)
            consecutivo = xcomando.ExecuteScalar()

            xcomando.Dispose()
            xcomando = Nothing

            Return consecutivo

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


    End Function

    Public Shared Function SumarColumna(ByVal nombre_Columna As String, ByVal Dgv As DataGridView) As Double

        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try

            For i As Integer = 0 To Dgv.RowCount - 1
                total += CDbl(Dgv.Item(nombre_Columna.ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total

    End Function

#End Region

#Region "password"
    Public Shared Function buscarpassw(ByVal Idempleado As Integer, ByVal password As String) As Integer


        Try 'sentencia para el manejo de errores


            sql = "select count(IdEmpleado) AS CONTAR from empleados where IdEmpleado=" & Idempleado & " and clave_emp= MD5('" & password & "')"

            xcomando = New MySqlCommand(sql, xcon)
            xda = New MySqlDataAdapter(xcomando)
            xds = New DataSet

            xdr = xcomando.ExecuteReader()

            If xdr.Read Then 'existen datos en el dr
                ingreso = xdr("CONTAR")
                xdr.Close()

            Else
                xdr.Close()
            End If

            xds.Dispose()
            xds = Nothing

            xcomando.Dispose()
            xcomando = Nothing


        Catch ex As System.Data.Odbc.OdbcException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


        Return ingreso

    End Function

#End Region

#Region "Colores"

    Public Shared Function buscarcolor(ByVal color As Integer) As Integer


        Try 'sentencia para el manejo de errores

            sql = "select count(Idtconsulta) AS CONTAR from tipoconsulta where color=" & color & ""
            xcomando = New MySqlCommand(sql, xcon)
            xda = New MySqlDataAdapter(xcomando)
            xds = New DataSet

            xdr = xcomando.ExecuteReader()

            If xdr.Read Then 'existen datos en el dr
                ingreso = xdr("CONTAR")
                xdr.Close()

            Else
                xdr.Close()
            End If

            xds.Dispose()
            xds = Nothing

            xcomando.Dispose()
            xcomando = Nothing


        Catch ex As System.Data.Odbc.OdbcException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


        Return ingreso

    End Function

#End Region

#Region "Busquedas"

    Public Shared Function buscaritem(ByVal opcion As String, ByVal item1 As String, ByVal item2 As String, ByVal item3 As String, ByVal item4 As String) As Integer


        Try 'sentencia para el manejo de errores

            Select Case opcion

                Case "odontograma"

                    sql = "select count(IdUsuario) AS CONTAR from odontograma WHERE IdUsuario = " & CInt(item1) & " AND IdTUsuario= " & CInt(item2) & " AND pieza_ograma = '" & item3 & "' "

               
            End Select


            xcomando = New MySqlCommand(sql, xcon)
            xda = New MySqlDataAdapter(xcomando)
            xds = New DataSet

            xdr = xcomando.ExecuteReader()

            If xdr.Read Then 'existen datos en el dr
                ingreso = xdr("CONTAR")
                xdr.Close()

            Else
                xdr.Close()
            End If

            xds.Dispose()
            xds = Nothing

            xcomando.Dispose()
            xcomando = Nothing

        Catch ex As System.Data.Odbc.OdbcException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
        End Try 'cierra la sentencia


        Return ingreso

    End Function

#End Region

#Region "Operaciones DML"
    Public Interface DML
        Function Insertar(ByVal mensaje As String) As Boolean
        Function Eliminar(ByVal mensaje As String) As Boolean
        Function Seleccionar(ByVal mensaje As String) As Boolean
        Function Modificar(ByVal mensaje As String) As Boolean
    End Interface
#End Region

End Class



