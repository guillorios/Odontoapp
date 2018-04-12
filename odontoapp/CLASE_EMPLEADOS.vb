Imports MySql.Data.MySqlClient

Public Class CLASE_EMPLEADOS

    Implements Clase_general.DML

#Region "Consultas"

    Public Shared xIdempleado As Integer
    Public Shared xapellidos_emp As String
    Public Shared xnombres_emp As String
    Public Shared xresidencia_emp As String
    Public Shared xfecingreso_emp As String
    Public Shared xespecialidad_emp As String
    Public Shared xfecnac_emp As String
    Public Shared xtipodoc_emp As String
    Public Shared xnumdoc_emp As String
    Public Shared xsexo_emp As String
    Public Shared xnivel_emp As Integer
    Public Shared xclave_emp As String

#End Region

#Region "Atributos"

    Private Idempleado As Integer
    Private apellidos_emp As String
    Private nombres_emp As String
    Private residencia_emp As String
    Private fecingreso_emp As String
    Private especialidad_emp As String
    Private fecnac_emp As String
    Private tipodoc_emp As String
    Private numdoc_emp As String
    Private sexo_emp As String
    Private nivel_emp As Integer
    Private clave_emp As String
    Private ds As DataSet
    Private llave(0) As DataColumn

#End Region

#Region "Constructor"
    Public Sub New()

        Me.Idempleado = 0
        Me.apellidos_emp = ""
        Me.nombres_emp = ""
        Me.residencia_emp = ""
        Me.fecingreso_emp = ""
        Me.especialidad_emp = ""
        Me.fecnac_emp = ""
        Me.tipodoc_emp = ""
        Me.numdoc_emp = ""
        Me.sexo_emp = ""
        Me.nivel_emp = 0
        Me.clave_emp = ""
        Me.ds = New DataSet

    End Sub
#End Region

#Region "destructor"
    Public Sub dispose()
        GC.Collect()
    End Sub
#End Region

#Region "Propiedades"

    Public Property p_Idempleado() As Integer
        Get
            Return Me.Idempleado
        End Get
        Set(ByVal Value As Integer)
            Me.Idempleado = Value
        End Set
    End Property
    Public Property p_apellidos_emp() As String
        Get
            Return Me.apellidos_emp
        End Get
        Set(ByVal Value As String)
            Me.apellidos_emp = Value
        End Set
    End Property

    Public Property p_nombres_emp() As String
        Get
            Return Me.nombres_emp
        End Get
        Set(ByVal Value As String)
            Me.nombres_emp = Value
        End Set
    End Property

    Public Property p_residencia_emp() As String
        Get
            Return Me.residencia_emp
        End Get
        Set(ByVal Value As String)
            Me.residencia_emp = Value
        End Set
    End Property

    Public Property p_fecingreso_emp() As String
        Get
            Return Me.fecingreso_emp
        End Get
        Set(ByVal Value As String)
            Me.fecingreso_emp = Value
        End Set
    End Property

    Public Property p_especialidad_emp() As String
        Get
            Return Me.especialidad_emp
        End Get
        Set(ByVal Value As String)
            Me.especialidad_emp = Value
        End Set
    End Property

    Public Property p_fecnac_emp() As String
        Get
            Return Me.fecnac_emp
        End Get
        Set(ByVal Value As String)
            Me.fecnac_emp = Value
        End Set
    End Property

    Public Property p_tipodoc_emp() As String
        Get
            Return Me.tipodoc_emp
        End Get
        Set(ByVal Value As String)
            Me.tipodoc_emp = Value
        End Set
    End Property

    Public Property p_numdoc_emp() As String
        Get
            Return Me.numdoc_emp
        End Get
        Set(ByVal Value As String)
            Me.numdoc_emp = Value
        End Set
    End Property

    Public Property p_sexo_emp() As String
        Get
            Return Me.sexo_emp
        End Get
        Set(ByVal Value As String)
            Me.sexo_emp = Value
        End Set
    End Property
    Public Property p_nivel_emp() As Integer
        Get
            Return Me.nivel_emp
        End Get
        Set(ByVal Value As Integer)
            Me.nivel_emp = Value
        End Set
    End Property
    Public Property p_clave_emp() As String
        Get
            Return Me.clave_emp
        End Get
        Set(ByVal Value As String)
            Me.clave_emp = Value
        End Set
    End Property

    Public ReadOnly Property p_ds() As DataSet
        Get
            Return Me.ds
        End Get
    End Property

#End Region


    Public Function Eliminar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Eliminar

        Try
            Clase_general.sql = "DELETE FROM empleados WHERE Idempleado = " & Me.Idempleado & ""
            Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
            Clase_general.xcomando.ExecuteNonQuery()

            Return True

            Clase_general.xcomando.Dispose()
            Clase_general.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Insertar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Insertar

        Try

            CLASE_GENERAL.sql = "INSERT INTO empleados (Idempleado, apellidos_emp, nombres_emp, residencia_emp, fecingreso_emp, especialidad_emp, fecnac_emp, tipodoc_emp, numdoc_emp, sexo_emp, nivel_emp, clave_emp) VALUES (" & Me.Idempleado & ", '" & Me.apellidos_emp & "', '" & Me.nombres_emp & "', '" & Me.residencia_emp & "', '" & Me.fecingreso_emp & "', '" & Me.especialidad_emp & "', '" & Me.fecnac_emp & "', '" & Me.tipodoc_emp & "', '" & Me.numdoc_emp & "', '" & Me.sexo_emp & "', " & Me.nivel_emp & ", MD5('" & Me.clave_emp & "'))"
            Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
            Clase_general.xcomando.ExecuteNonQuery()

            Return True

            Clase_general.xcomando.Dispose()
            Clase_general.xcomando = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False
        End Try

    End Function

    Public Function Modificar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Modificar

        Try


            Select mensaje

                Case "conclave"

                    CLASE_GENERAL.sql = "UPDATE empleados SET apellidos_emp = '" & Me.apellidos_emp & "', nombres_emp = '" & Me.nombres_emp & "', residencia_emp = '" & Me.residencia_emp & "', fecingreso_emp = '" & Me.fecingreso_emp & "', especialidad_emp = '" & Me.especialidad_emp & "', fecnac_emp = '" & Me.fecnac_emp & "', tipodoc_emp = '" & Me.tipodoc_emp & "', numdoc_emp = '" & Me.numdoc_emp & "', sexo_emp = '" & Me.sexo_emp & "', nivel_emp = " & Me.nivel_emp & ", clave_emp = MD5('" & Me.clave_emp & "') WHERE Idempleado = " & Me.Idempleado & ""

                Case "sinclave"

                    CLASE_GENERAL.sql = "UPDATE empleados SET apellidos_emp = '" & Me.apellidos_emp & "', nombres_emp = '" & Me.nombres_emp & "', residencia_emp = '" & Me.residencia_emp & "', fecingreso_emp = '" & Me.fecingreso_emp & "', especialidad_emp = '" & Me.especialidad_emp & "', fecnac_emp = '" & Me.fecnac_emp & "', tipodoc_emp = '" & Me.tipodoc_emp & "', numdoc_emp = '" & Me.numdoc_emp & "', sexo_emp = '" & Me.sexo_emp & "', nivel_emp = " & Me.nivel_emp & " WHERE Idempleado = " & Me.Idempleado & ""

            End Select

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

    Public Function Seleccionar(ByVal mensaje As String) As Boolean Implements Clase_general.DML.Seleccionar

        Try

            CLASE_GENERAL.sql = "SELECT Idempleado, apellidos_emp, nombres_emp, residencia_emp, fecingreso_emp, especialidad_emp, fecnac_emp, tipodoc_emp, numdoc_emp, sexo_emp, nivel_emp FROM empleados WHERE Idempleado = " & Me.Idempleado & " ORDER BY idempleado ASC "
            Clase_general.xcomando = New MySqlCommand(Clase_general.sql, Clase_general.xcon)
            Clase_general.xdr = Clase_general.xcomando.ExecuteReader()

            If Clase_general.xdr.Read Then 'existen datos en el dr

                xIdempleado = Clase_general.xdr("Idempleado")
                xapellidos_emp = Clase_general.xdr("apellidos_emp")
                xnombres_emp = Clase_general.xdr("nombres_emp")
                xresidencia_emp = Clase_general.xdr("residencia_emp")
                xfecingreso_emp = Clase_general.xdr("fecingreso_emp")
                xespecialidad_emp = Clase_general.xdr("especialidad_emp")
                xfecnac_emp = Clase_general.xdr("fecnac_emp")
                xtipodoc_emp = Clase_general.xdr("tipodoc_emp")
                xnumdoc_emp = Clase_general.xdr("numdoc_emp")
                xsexo_emp = Clase_general.xdr("sexo_emp")
                xnivel_emp = CLASE_GENERAL.xdr("nivel_emp")

            End If

            Clase_general.xdr.Close()
            Clase_general.xdr = Nothing
            Clase_general.xcomando.Dispose()
            Clase_general.xcomando = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Atención") 'muestra una ventana modal(cuadro de dialogo), no permite continuar hasta quede respuesta a la peticion del mensaje
            Return False

        End Try


    End Function

End Class
