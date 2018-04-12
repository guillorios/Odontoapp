Imports MySql.Data.MySqlClient

Public Class CLASE_PRESUPUESTO

    Implements CLASE_GENERAL.DML

#Region "Consultas"

    Public Shared xIdpresupuesto As Integer
    Public Shared xIdpaciente As Integer
    Public Shared xnom_pres As String
    Public Shared xfecha_pres As String
    Public Shared xintervalo_pres As Integer
    Public Shared xVTotal_pres As Double
    Public Shared xNCuotasIni_pres As Double
    Public Shared xVCuotasIni_pres As Double
    Public Shared xTCuotasIni_pres As Double
    Public Shared xNCuotas_pres As Double
    Public Shared xVCuotas_pres As Double
    Public Shared xTCuotas_pres As Double
    Public Shared xVTotalPresupuesto As Double
    Public Shared xIdestado As Integer
    Public Shared xIdespecialidad As Integer
    Public Shared xIddoctor As Integer

#End Region

#Region "Atributos"

    Private Idpresupuesto As Integer
    Private Idpaciente As Integer
    Private nom_pres As String
    Private fecha_pres As String
    Private intervalo_pres As String
    Private VTotal_pres As Double
    Private NCuotasIni_pres As Double
    Private VCuotasIni_pres As Double
    Private TCuotasIni_pres As Double
    Private NCuotas_pres As Double
    Private VCuotas_pres As Double
    Private TCuotas_pres As Double
    Private VTotalPresupuesto As Double
    Private Idestado As Integer
    Private Idespecialidad As Integer
    Private Iddoctor As Integer

    Private dt As DataTable
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"

    Public Sub New()

        Me.Idpresupuesto = 0
        Me.Idpaciente = 0
        Me.nom_pres = ""
        Me.fecha_pres = ""
        Me.intervalo_pres = 0
        Me.VTotal_pres = 0
        Me.NCuotasIni_pres = 0
        Me.VCuotasIni_pres = 0
        Me.TCuotasIni_pres = 0
        Me.NCuotas_pres = 0
        Me.VCuotas_pres = 0
        Me.TCuotas_pres = 0
        Me.VTotalPresupuesto = 0
        Me.Idestado = 0
        Me.Idespecialidad = 0
        Me.Iddoctor = 0

        Me.dt = New DataTable

    End Sub

#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idpresupuesto() As Integer
        Get
            Return Me.Idpresupuesto
        End Get
        Set(ByVal Value As Integer)
            Me.Idpresupuesto = Value
        End Set
    End Property

    Public Property p_Idpaciente() As Integer
        Get
            Return Me.Idpaciente
        End Get
        Set(ByVal Value As Integer)
            Me.Idpaciente = Value
        End Set
    End Property

    Public Property p_nom_pres() As String
        Get
            Return Me.fecha_pres
        End Get
        Set(ByVal Value As String)
            Me.nom_pres = Value
        End Set
    End Property

    Public Property p_fecha_pres() As String
        Get
            Return Me.fecha_pres
        End Get
        Set(ByVal Value As String)
            Me.fecha_pres = Value
        End Set
    End Property

    Public Property p_intervalo_pres() As String
        Get
            Return Me.intervalo_pres
        End Get
        Set(ByVal Value As String)
            Me.intervalo_pres = Value
        End Set
    End Property

    Public Property p_VTotal_pres() As Double
        Get
            Return Me.VTotal_pres
        End Get
        Set(ByVal Value As Double)
            Me.VTotal_pres = Value
        End Set
    End Property

    Public Property p_NCuotasIni_pres() As Double
        Get
            Return Me.NCuotasIni_pres
        End Get
        Set(ByVal Value As Double)
            Me.NCuotasIni_pres = Value
        End Set
    End Property

    Public Property p_VCuotasIni_pres() As Double
        Get
            Return Me.VCuotasIni_pres
        End Get
        Set(ByVal Value As Double)
            Me.VCuotasIni_pres = Value
        End Set
    End Property

    Public Property p_TCuotasIni_pres() As Double
        Get
            Return Me.TCuotasIni_pres
        End Get
        Set(ByVal Value As Double)
            Me.TCuotasIni_pres = Value
        End Set
    End Property

    Public Property p_NCuotas_pres() As Double
        Get
            Return Me.NCuotas_pres
        End Get
        Set(ByVal Value As Double)
            Me.NCuotas_pres = Value
        End Set
    End Property

    Public Property p_VCuotas_pres() As Double
        Get
            Return Me.VCuotas_pres
        End Get
        Set(ByVal Value As Double)
            Me.VCuotas_pres = Value
        End Set
    End Property

    Public Property p_TCuotas_pres() As Double
        Get
            Return Me.TCuotas_pres
        End Get
        Set(ByVal Value As Double)
            Me.TCuotas_pres = Value
        End Set
    End Property

    Public Property p_VTotalPresupuesto() As Double
        Get
            Return Me.VTotalPresupuesto
        End Get
        Set(ByVal Value As Double)
            Me.VTotalPresupuesto = Value
        End Set
    End Property

    Public Property p_Idestado() As Double
        Get
            Return Me.Idestado
        End Get
        Set(ByVal Value As Double)
            Me.Idestado = Value
        End Set
    End Property

    Public Property p_Idespecialidad() As Double
        Get
            Return Me.Idespecialidad
        End Get
        Set(ByVal Value As Double)
            Me.Idespecialidad = Value
        End Set
    End Property

    Public Property p_Iddoctor() As Double
        Get
            Return Me.Iddoctor
        End Get
        Set(ByVal Value As Double)
            Me.Iddoctor = Value
        End Set
    End Property

    Public ReadOnly Property p_dt() As DataTable
        Get
            Return Me.dt
        End Get
    End Property

#End Region

    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Eliminar

        Try

            CLASE_GENERAL.sql = "DELETE QUICK FROM orthosoft.presupuesto WHERE Idpresupuesto = " & Me.Idpresupuesto & " AND Idpaciente = " & Me.Idpaciente & ""
            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            Return True

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Insertar

        Try

            CLASE_GENERAL.sql = "INSERT INTO orthosoft.presupuesto (Idpresupuesto, Idpaciente,  nom_pres, fecha_pres, intervalo_pres, VTotal_pres, NCuotasIni_pres, " _
            & "VCuotasIni_pres, TCuotasIni_pres, NCuotas_pres, VCuotas_pres, TCuotas_pres, VTotalPresupuesto, Idestado, Idespecialidad, Iddoctor) VALUES (" & Me.Idpresupuesto & ", " _
            & "" & Me.Idpaciente & ", '" & Me.nom_pres & "', '" & Me.fecha_pres & "', " & Me.intervalo_pres & ", " & Me.VTotal_pres & ", " & Me.NCuotasIni_pres & ", " & Me.VCuotasIni_pres & ", " & Me.TCuotasIni_pres & ", " & Me.NCuotas_pres & ", " & Me.VCuotas_pres & ", " _
            & "" & Me.TCuotas_pres & ", " & Me.VTotalPresupuesto & ", " & Me.Idestado & ", " & Me.Idespecialidad & ", 	" & Me.Iddoctor & ")"

            CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
            CLASE_GENERAL.xcomando.ExecuteNonQuery()

            Return True

            CLASE_GENERAL.xcomando.Dispose()
            CLASE_GENERAL.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try


    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Modificar

        Try

            Select mensaje

                Case "registro"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.presupuesto) SET Idpresupuesto = " & Me.Idpresupuesto & " , Idpaciente = " & Me.Idpaciente & " ,  nom_pres = '" & Me.nom_pres & "', fecha_pres = '" & Me.fecha_pres & "' , intervalo_pres = " & Me.intervalo_pres & ", " _
                    & "VTotal_pres = " & Me.VTotal_pres & " , NCuotasIni_pres = " & Me.NCuotasIni_pres & " , VCuotasIni_pres = " & Me.VCuotasIni_pres & " , TCuotasIni_pres = " & Me.TCuotasIni_pres & " , " _
                    & "NCuotas_pres = " & Me.NCuotas_pres & " , VCuotas_pres = " & Me.VCuotas_pres & " , TCuotas_pres = " & Me.TCuotas_pres & " , VTotalPresupuesto = " & Me.VTotalPresupuesto & " , Idestado = " & Me.Idestado & ", Idespecialidad = " & Me.Idespecialidad & ", Iddoctor = " & Me.Iddoctor & " " _
                    & "WHERE Idpresupuesto = " & Me.Idpresupuesto & " AND Idpaciente  = " & Me.Idpaciente & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "valorpresupuesto"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.presupuesto) SET VTotalPresupuesto = " & Me.VTotalPresupuesto & " " _
                    & "WHERE Idpresupuesto = " & Me.Idpresupuesto & " AND Idpaciente  = " & Me.Idpaciente & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "estadopresupuesto"

                    CLASE_GENERAL.sql = "UPDATE(Orthosoft.presupuesto) SET Idestado = " & Me.Idestado & " " _
                    & "WHERE Idpresupuesto = " & Me.Idpresupuesto & " AND Idpaciente  = " & Me.Idpaciente & ""

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xcomando.ExecuteNonQuery()

                    Return True

                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing


            End Select


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements CLASE_GENERAL.DML.Seleccionar

        Try

            Select Case mensaje

                Case "tabla"

                    CLASE_GENERAL.xdt = New DataTable
                    CLASE_GENERAL.sql = "SELECT Idpresupuesto, Idpaciente, nom_pres, fecha_pres, intervalo_pres, VTotal_pres, NCuotasIni_pres, VCuotasIni_pres, TCuotasIni_pres, NCuotas_pres, VCuotas_pres, TCuotas_pres, VTotalPresupuesto, Idestado FROM Orthosoft.presupuesto"

                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xda = New MySqlDataAdapter(CLASE_GENERAL.xcomando)

                    CLASE_GENERAL.xda.Fill(CLASE_GENERAL.xdt) 'Ejecutar par cargar en combo

                    'CLASE_GENERAL.xds.WriteXml("C:\dataset.xml", XmlWriteMode.WriteSchema)

                    CLASE_GENERAL.xda.Dispose()
                    CLASE_GENERAL.xda = Nothing
                    CLASE_GENERAL.xcomando.Dispose()
                    CLASE_GENERAL.xcomando = Nothing

                Case "registro"

                    CLASE_GENERAL.sql = "SELECT * FROM Orthosoft.presupuesto WHERE Idpaciente = " & Me.Idpaciente & " AND Idpresupuesto = " & Me.Idpresupuesto & ""
                    CLASE_GENERAL.xcomando = New MySqlCommand(CLASE_GENERAL.sql, CLASE_GENERAL.xcon)
                    CLASE_GENERAL.xdr = CLASE_GENERAL.xcomando.ExecuteReader()

                    If CLASE_GENERAL.xdr.Read Then 'existen datos en el dr

                        xIdpresupuesto = CLASE_GENERAL.xdr("Idpresupuesto")
                        xIdpaciente = CLASE_GENERAL.xdr("Idpaciente")
                        xnom_pres = CLASE_GENERAL.xdr("nom_pres")
                        xfecha_pres = CLASE_GENERAL.xdr("fecha_pres")
                        xintervalo_pres = CLASE_GENERAL.xdr("intervalo_pres")
                        xVTotal_pres = CLASE_GENERAL.xdr("VTotal_pres")
                        xNCuotasIni_pres = CLASE_GENERAL.xdr("NCuotasIni_pres")
                        xVCuotasIni_pres = CLASE_GENERAL.xdr("VCuotasIni_pres")
                        xTCuotasIni_pres = CLASE_GENERAL.xdr("TCuotasIni_pres")
                        xNCuotas_pres = CLASE_GENERAL.xdr("NCuotas_pres")
                        xVCuotas_pres = CLASE_GENERAL.xdr("VCuotas_pres")
                        xTCuotas_pres = CLASE_GENERAL.xdr("TCuotas_pres")
                        xVTotalPresupuesto = CLASE_GENERAL.xdr("VTotalPresupuesto")
                        xIdestado = CLASE_GENERAL.xdr("Idestado")
                        xIdespecialidad = CLASE_GENERAL.xdr("Idespecialidad")
                        xIddoctor = CLASE_GENERAL.xdr("Iddoctor")

                        CLASE_GENERAL.xdr.Close()
                        CLASE_GENERAL.xdr = Nothing
                        CLASE_GENERAL.xcomando.Dispose()
                        CLASE_GENERAL.xcomando = Nothing

                    End If

            End Select

        Catch ex As MySqlException 'captura errores sql
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        Catch ex As Exception 'captura cualquier tipo de errores
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try 'cierra la sentencia

    End Function
End Class
