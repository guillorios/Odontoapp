'------------------------------------------------------------------------------
' ArrayControles                                                    (09/Abr/07)
'
' Clase-colecci�n para simular un array de controles de Visual Basic 6.0
' Se utilizan clases generic para contener los controles.
'
' Esta clase est� basada en ControlArray (09/Ago/2002),
' publicada en mi sitio el 14/Nov/2002:
' http://www.elguille.info/NET/dotnet/arrayControles.htm
'
' �Guillermo 'guille' Som, 2002, 2007
'------------------------------------------------------------------------------
Option Strict On

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Windows.Forms
Imports System.Drawing

Namespace elGuille.info.Utilidades

    ''' <summary>
    ''' Clase para contener controles del tipo indicado,
    ''' que debe derivarse de Control.
    ''' </summary>
    ''' <typeparam name="T">
    ''' El tipo de control que contendr� la colecci�n.
    ''' </typeparam>
    ''' <remarks>
    ''' Se deriva de List(Of T)
    ''' Autor: Guillermo 'guille' Som
    ''' Fecha: 09/Abr/2007
    ''' </remarks>
    Public Class ArrayControles(Of T As Control)
        Inherits System.Collections.Generic.List(Of T)

        Private m_Nombre As String

        ''' <summary>
        ''' En el constructor se debe indicar el nombre del control.
        ''' </summary>
        ''' <param name="elNombre">
        ''' El nombre base de los controles del array,
        ''' esos controles deben tener el nombre: elNombre_numero.
        ''' No se admite una cadena vac�a.
        ''' </param>
        ''' <remarks></remarks>
        Public Sub New(ByVal elNombre As String)
            MyBase.New()
            If String.IsNullOrEmpty(elNombre) Then
                Throw New ArgumentException( _
                            "El nombre del control no puede ser una cadena vac�a")
            End If
            ' Asignarlo a la propiedad
            ' para que se convierta en min�sculas
            ' o cualquier otra comprobaci�n.
            Me.Nombre = elNombre
        End Sub

        ''' <summary>
        ''' Constructor para inicializar directamente la colecci�n de controles
        ''' </summary>
        ''' <param name="ctrls">
        ''' Colecci�n de controles en la que est�n los que debemos usar.
        ''' </param>
        ''' <param name="elNombre">
        ''' El nombre base de los controles a tener en cuenta.
        ''' </param>
        ''' <remarks></remarks>
        Public Sub New( _
                    ByVal elNombre As String, _
                    ByVal ctrls As Control.ControlCollection)
            Me.New(elNombre)

            Me.Clear()
            asignarLosControles(ctrls)
            Me.Reorganizar()
        End Sub

        ''' <summary>
        ''' Constructor para inicializar directamente la colecci�n de controles
        ''' </summary>
        ''' <param name="contenedor">
        ''' El contenedor que tiene los controles a comprobar.
        ''' </param>
        ''' <param name="elNombre">
        ''' El nombre base de los controles a tener en cuenta.
        ''' </param>
        ''' <remarks></remarks>
        Public Sub New( _
                    ByVal elNombre As String, _
                    ByVal contenedor As ContainerControl)
            Me.New(elNombre, contenedor.Controls)
        End Sub

        ''' <summary>
        ''' Asignar los controles de la colecci�n indicada.
        ''' </summary>
        ''' <param name="ctrls">
        ''' Colecci�n de controles en la que est�n los que debemos usar.
        ''' El nombre usado ser� el indicado al crear la colecci�n.
        ''' </param>
        ''' <remarks>
        ''' La colecci�n de controles puede ser Me.Controls
        ''' ya que aqu� solo se tendr�n en cuenta los controles
        ''' que tengan el nombre usado en esta clase,
        ''' y se recorren todas las colecciones de controles que haya.
        ''' </remarks>
        Public Sub AsignarControles(ByVal ctrls As Control.ControlCollection)
            Me.Clear()
            asignarLosControles(ctrls)
            Me.Reorganizar()
        End Sub

        ''' <summary>
        ''' Asignar los controles del contenedor indicado.
        ''' </summary>
        ''' <param name="contenedor">
        ''' El contenedor de los controles en los que se buscar�n
        ''' los del tipo indicado en esta colecci�n.
        ''' </param>
        ''' <remarks></remarks>
        Public Sub AsignarControles(ByVal contenedor As ContainerControl)
            Me.Clear()
            asignarLosControles(contenedor.Controls)
            Me.Reorganizar()
        End Sub

        Private Sub asignarLosControles(ByVal ctrls As Control.ControlCollection)
            ' El tipo debe ser Control, para tener en cuenta todos los controles
            ' que haya en la colecci�n indicada.
            For Each ctr As Control In ctrls
                ' Hacer una llamada recursiva por si este control "contiene" otros
                If ctr.Controls.Count > 0 Then
                    asignarLosControles(ctr.Controls)
                End If

                If ctr.Name.ToLower().IndexOf(m_Nombre) > -1 Then
                    Me.Add(TryCast(ctr, T))
                End If
            Next
        End Sub

        ' Sobrecarga de la propiedad predeterminada (Item)

        ''' <summary>
        ''' Propiedad predeterminada para devolver
        ''' el control con el nombre indicado.
        ''' </summary>
        ''' <param name="name">
        ''' El nombre del control a buscar.
        ''' </param>
        ''' <value></value>
        ''' <returns>
        ''' El control que tiene el nombre indicado.
        ''' </returns>
        ''' <remarks></remarks>
        Default Public Overloads ReadOnly Property Item(ByVal name As String) As T
            Get
                Dim index As Integer = Me.Index(name)
                ' Si existe, devolverlo, sino, devolver un valor nulo
                If index = -1 Then
                    Return Nothing
                End If

                Return Me(index)
            End Get
        End Property

        ''' <summary>
        ''' Sobrecarga de la propiedad predeterminada
        ''' para permitir el acceso con un valor de tipo Object.
        ''' Aunque el tipo debe ser del que contiene la colecci�n,
        ''' si no es as�, se devuelve un valor nulo.
        ''' </summary>
        ''' <param name="obj">
        ''' El control a comprobar
        ''' </param>
        ''' <value></value>
        ''' <returns>
        ''' Si el par�metro es del tipo adecuado, 
        ''' se devuelve con el tipo de la colecci�n,
        ''' si no lo es, se devuelve un valor nulo.
        ''' </returns>
        ''' <remarks></remarks>
        Default Public Overloads ReadOnly Property Item(ByVal obj As Object) As T
            Get
                Dim ctrl As T = TryCast(obj, T)

                Return ctrl

                ' Quita estos comnetarios y comenta el Return anterio
                ' si quieres que se compruebe exactamente el control.

                '' Buscar ese control en la colecci�n,
                '' para asegurarnos de que en realidad est�.

                'If ctrl Is Nothing Then
                '    Return Nothing
                'End If

                'For Each c As T In Me
                '    If c Is ctrl Then
                '        Return c
                '    End If
                'Next

                'Return Nothing
            End Get
        End Property

        'Default Public Overloads ReadOnly Property Item(ByVal ctrl As T) As T
        '    Get
        '        Return ctrl
        '    End Get
        'End Property

        ''' <summary>
        ''' Devuelve el �ndice del control de esta colecci�n
        ''' que tenga el mismo �ndice que el del par�metro.
        ''' Ese par�metro puede ser cualquier control,
        ''' y lo que se tendr� en cuenta ser� el nombre usado,
        ''' el cual debe tener la forma nombre_indice,
        ''' de forma que se devolver� el control que tenga ese mismo �ndice.
        ''' </summary>
        ''' <param name="obj">
        ''' El control a comprobar si existe un �ndice como el indicado.
        ''' Al ser de tipo Object no es necesario que sea del mismo tipo
        ''' que los que contiene esta colecci�n.
        ''' </param>
        ''' <returns>
        ''' El �ndice correspondiente.
        ''' Aunque no se comprueba si existe en la colecci�n.
        ''' En el caso de que el par�metro no tenga el formato adecuado,
        ''' se devuelve -1.
        ''' </returns>
        ''' <remarks>
        ''' Esta sobrecarga se puede usar para buscar el control correspondiente
        ''' con el del �ndice de otro control, por ejemplo:
        ''' i = m_TextBox1.Index(sender)
        ''' Por supuesto, el par�metro debe ser de tipo Control.
        ''' Este m�todo podr�a estar compartido, pero debido a que su uso
        ''' ser�a ArrayControles(Of TIPO).Index(sender)
        ''' he preferido dejarlo como de instancia.
        ''' </remarks>
        Public Function Index(ByVal obj As Object) As Integer
            Dim ctrl As Control = TryCast(obj, Control)
            If ctrl Is Nothing Then
                Return -1
            End If

            Dim i As Integer = -1
            i = ctrl.Name.LastIndexOf("_")
            If i > -1 Then
                i = CInt(ctrl.Name.Substring(i + 1))
            End If

            Return i
        End Function

        'Public Shared Function Index(ByVal obj As Object) As Integer
        '    Dim ctrl As Control = TryCast(obj, Control)
        '    If ctrl Is Nothing Then
        '        Return -1
        '    End If
        '    '
        '    Dim i As Integer = -1
        '    i = ctrl.Name.LastIndexOf("_")
        '    If i > -1 Then
        '        i = CInt(ctrl.Name.Substring(i + 1))
        '    End If

        '    Return i
        'End Function

        ''' <summary>
        ''' Devuelve el �ndice del control con el nombre indicado.
        ''' </summary>
        ''' <param name="name">
        ''' Nombre del control a buscar en la colecci�n.
        ''' </param>
        ''' <returns>
        ''' Un valor de tipo entero con el �ndice del control.
        ''' </returns>
        ''' <remarks></remarks>
        Public Function Index(ByVal name As String) As Integer
            Dim hallado As Integer = -1

            For i As Integer = 0 To Me.Count - 1
                Dim ctrl As T = Me(i)
                If String.Compare(ctrl.Name, name, True) = 0 Then
                    hallado = i
                    Exit For
                End If
            Next
            Return hallado
        End Function

        ''' <summary>
        ''' Devuelve el �ndice del control indicado.
        ''' </summary>
        ''' <param name="ctrl">
        ''' El control del que queremos averiguar el �ndice.
        ''' </param>
        ''' <returns>
        ''' Un valor de tipo entero con el �ndice del control.
        ''' </returns>
        ''' <remarks></remarks>
        Public Function Index(ByVal ctrl As T) As Integer
            Dim i As Integer = ctrl.Name.LastIndexOf("_")

            ' Si el nombre no tiene el signo _
            If i = -1 Then
                i = Me.IndexOf(ctrl)
            Else
                i = CInt(ctrl.Name.Substring(i + 1))
            End If

            Return i
        End Function
        '
        ''' <summary>
        ''' La propiedad Nombre, externamente ser� de solo lectura.
        ''' </summary>
        ''' <value>El nombre de la colecci�n de controles</value>
        ''' <returns>
        ''' El nombre de la colecci�n de controles.
        ''' </returns>
        ''' <remarks>
        ''' </remarks>
        Public Property Nombre() As String
            Get
                Return m_Nombre
            End Get
            Private Set(ByVal value As String)
                m_Nombre = value.ToLower()
            End Set
        End Property
        '
        ''' <summary>
        ''' Reorganizar el contenido de la colecci�n,
        ''' ordenando por el �ndice indicado despu�s del gui�n bajo
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Reorganizar()
            Dim ca As New List(Of T)

            For i As Integer = 0 To Me.Count - 1
                For Each ctr As T In Me
                    If i = Me.Index(ctr) Then
                        ca.Add(ctr)
                        Exit For
                    End If
                Next
            Next
            '
            Me.Clear()
            For Each ctr As T In ca
                Me.Add(ctr)
            Next
        End Sub
    End Class

End Namespace