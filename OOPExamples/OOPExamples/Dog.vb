Public Class Dog
    Inherits Mammal

    Sub New()
        Me.Movement = "wag tail and pee on the floor"
        Me.skinType = "I have a shiny coat"
    End Sub

    Sub speak()
        Console.WriteLine("woof woof")
    End Sub

End Class
