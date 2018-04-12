'------------------------------------------------------------------------------
' Prueba para usar la clase ArrayControles                          (09/Abr/07)
'
' Utilizando una clase generic para los controles.
' 
' Basado en el ejemplo publicado en mi sitio:
' http://www.elguille.info/NET/dotnet/arrayControles.htm
'
' ©Guillermo 'guille' Som, 2002, 2007
'------------------------------------------------------------------------------
Option Strict On

Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports Orthosoft.elGuille.info.Utilidades


Public Class Form1

    ' Colecciones (como arrays) para contener los controles


    ' De esta forma solo tendríamos que llamar al método AsignarControles
    Private m_Label1 As New ArrayControles(Of DevComponents.DotNetBar.LabelX)("Diente18")
    Private m_TextBox1 As New ArrayControles(Of TextBox)("TextBox1")
    Private m_RadioButton1 As New ArrayControles(Of RadioButton)("RadioButton1")

    ' Así no se deben declarar
    ' (salvo que después se inicialicen, pero para ese caso, mejor hacerlo bien)
    'Private m_Label1 As New ArrayControles(Of Label)(Me, "Label1")
    'Private m_TextBox1 As New ArrayControles(Of TextBox)(Me, "TextBox1")
    'Private m_RadioButton1 As New ArrayControles(Of RadioButton)(Me, "RadioButton1")

    ' De esta forma tendremos que instanciar las colecciones
    'Private m_Label1 As ArrayControles(Of Label)
    'Private m_TextBox1 As ArrayControles(Of TextBox)
    'Private m_RadioButton1 As ArrayControles(Of RadioButton)
    '
    ' Asignar los eventos a los controles
    Private Sub asignarEventos()

        ' Aquí estarán los procedimientos a asignar a cada array de controles

        For Each opt As RadioButton In m_RadioButton1
            AddHandler opt.KeyPress, AddressOf RadioButton1_KeyPress
            ' Para el evento general de recibir foco
            AddHandler opt.Enter, AddressOf control_Enter
        Next

        For Each txt As TextBox In m_TextBox1
            AddHandler txt.Enter, AddressOf TextBox1_Enter
            AddHandler txt.KeyPress, AddressOf TextBox1_KeyPress
            AddHandler txt.Leave, AddressOf TextBox1_Leave
            ' Para el evento general de recibir foco
            AddHandler txt.Enter, AddressOf control_Enter
        Next

        For Each lbl As DevComponents.DotNetBar.LabelX In m_Label1
            ' Para el evento general de recibir foco
            AddHandler lbl.Click, AddressOf m_Label1_click
        Next
        '
    End Sub

    Private Sub Form1_Load( _
                    ByVal sender As Object, ByVal e As EventArgs) _
                    Handles MyBase.Load

        ' Asignar los controles y reorganizar los índices
        ' No importa si el nombre no coincide exactamente,
        ' ya que no se diferencian las mayúsculas de las minúsculas.

        m_Label1 = New ArrayControles(Of DevComponents.DotNetBar.LabelX)("Diente18", Me)
        m_TextBox1 = New ArrayControles(Of TextBox)("textBox1", Me)
        m_RadioButton1 = New ArrayControles(Of RadioButton)("RadioButton1", Me)

        ' Esto solo usarlo si los arrays no se han creado con New
        ' aunque no importa si se han definido de esa forma,
        ' ya que vuelven a crearse las colecciones.
        '
        ' Crear directamente las colecciones y asignar los controles
        'm_Label1 = New ArrayControles(Of Label)("Label1", Me.Controls)
        'm_TextBox1 = New ArrayControles(Of TextBox)("TextBox1", Me.Controls)
        'm_RadioButton1 = New ArrayControles(Of RadioButton)("RadioButton1", Me.Controls)
        '
        ' También se puede hacer de esta forma:
        '
        ' Esto solo usarlo si las variables se han definido
        ' como As New ArrayControles(Of TIPO)(elNombre)
        'm_Label1.AsignarControles(Me.Controls)
        'm_TextBox1.AsignarControles(Me.Controls)
        'm_RadioButton1.AsignarControles(Me.Controls)

        ' Asignar sólo los eventos
        asignarEventos()

        ' Asignar unos textos a las cajas de texto
        For i As Integer = 0 To m_TextBox1.Count - 1
            m_TextBox1(i).Text = "Caja de textos " & i
        Next

    End Sub

    Private Sub control_Enter(ByVal sender As Object, ByVal e As EventArgs)

        Dim ctrl As Control = TryCast(sender, Control)
        Me.labelInfo.Text = "El control con el foco es: " & ctrl.Name

    End Sub

    Private Sub TextBox1_Enter( _
                    ByVal sender As Object, ByVal e As EventArgs)

        'Dim txt As TextBox = TryCast(sender, TextBox)
        'Dim index As Integer = m_TextBox1.Index(txt)

        'txt.SelectAll()
        '' resaltar la etiqueta
        'm_Label1(index).BackColor = Color.FromKnownColor(KnownColor.ControlDark)

        ' También se puede evaluar el índice
        ' y usar los que correspondan con ese valor.

        ' Fíjate que en el Label, los valores son _0, _1 y _2
        ' y en el TextBox son _00, _01 y _02,
        ' aunque parece que "no coinciden", 
        ' lo que importa es que el valor numérico sea el adecuado.

        Dim index As Integer = m_TextBox1.Index(sender)
        m_TextBox1(index).SelectAll()
        ' resaltar la etiqueta
        m_Label1(index).BackColor = Color.FromKnownColor(KnownColor.ControlDark)

        '' También se puede usar directamente 
        '' (para los casos que no necesitemos el índice)
        'm_TextBox1(sender).SelectAll()

    End Sub

    Private Sub TextBox1_Leave( _
                    ByVal sender As Object, ByVal e As EventArgs)

        'Dim txt As TextBox = TryCast(sender, TextBox)
        'Dim index As Integer = m_TextBox1.Index(txt)

        ' En este caso, esto es más cómodo:
        ' ya que solo queremos el índice.
        Dim index As Integer = m_TextBox1.Index(sender)

        ' poner la etiqueta con el color normal
        m_Label1(index).BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub TextBox1_KeyPress( _
                    ByVal sender As Object, ByVal e As KeyPressEventArgs)

        If e.KeyChar = ChrW(Keys.Return) Then
            Dim index As Integer

            'Dim txt As TextBox = TryCast(sender, TextBox)
            'index = m_TextBox1.Index(txt)

            ' Esto es más fácil de usar:
            index = m_TextBox1.Index(sender)

            If index = m_TextBox1.Count - 1 Then
                m_RadioButton1(0).Focus()
            Else
                m_TextBox1(index + 1).Focus()
            End If

            ' Evitar el pitido
            e.Handled = True
        End If
    End Sub
    '
    Private Sub RadioButton1_KeyPress( _
                    ByVal sender As Object, ByVal e As KeyPressEventArgs)

        If e.KeyChar = ChrW(Keys.Return) Then
            Dim index As Integer

            'Dim opt As RadioButton = TryCast(sender, RadioButton)
            'index = m_RadioButton1.Index(opt)

            ' Esto es más fácil de usar:
            index = m_RadioButton1.Index(sender)

            If index = 0 Then
                m_RadioButton1(index + 1).Focus()
            Else
                m_TextBox1(0).Focus()
            End If
        End If
    End Sub

    Private Sub m_Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim index As Integer = m_Label1.Index(sender)

        ' poner la etiqueta con el color normal
        m_Label1(index).BackColor = Color.FromKnownColor(KnownColor.Red)


    End Sub

    Private Sub btnSalir_Click( _
                    ByVal sender As Object, ByVal e As EventArgs) _
                    Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
