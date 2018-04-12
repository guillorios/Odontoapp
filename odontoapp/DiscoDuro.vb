Public Class DiscoDuro

    Private _Modelo As String
    Private _Tipo As String
    Private _Serial As String

    'Propiedad para Manejar el Modelo del Disco
    Public Property Modelo() As String
        Get
            'Retorna el Modelo del Diso Duro
            Return _Modelo
        End Get
        Set(ByVal value As String)
            'Asigna el Modelo del Disco Duro
            _Modelo = value
        End Set
    End Property

    'Propiedad para Manejar el Tipo del Disco
    Public Property Tipo() As String
        Get
            'Retorna el Tipo del Diso Duro
            Return _Tipo
        End Get
        Set(ByVal value As String)
            'Asigna el Tipo del Disco Duro
            _Tipo = value
        End Set
    End Property

    'Propiedad para Manejar el Serial del Disco
    Public Property Serial() As String
        Get
            'Retorna el Serial del Diso Duro
            Return _Serial
        End Get
        Set(ByVal value As String)
            'Asigna el Serial del Disco Duro
            _Serial = value
        End Set
    End Property


End Class
