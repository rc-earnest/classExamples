Public Class Animal
    'properties
    Private _Movement As String
    Public Property Movement() As String
        Get
            Return _Movement
        End Get
        Set(ByVal value As String)
            _Movement = value
        End Set
    End Property

    Private _skinType As String
    Public Property skinType() As String
        Get
            Return _skinType
        End Get
        Set(ByVal value As String)
            _skinType = value
        End Set
    End Property

    Private _vocalization As String
    Public Property vocalization() As String
        Get
            Return _vocalization
        End Get
        Set(ByVal value As String)
            _vocalization = value
        End Set
    End Property
    'fields
    'Dim movement As String


    Sub New()
        Me.Movement = "Animals can move... except sponges..."
        Me.skinType = "I'm not sure if sponges have skin."
    End Sub


    Sub Move()
        Console.WriteLine(Me.movement)
    End Sub

End Class
