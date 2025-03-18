Module MainModule

    Sub Main()
        'DoSomethingInMainModule()
        'DoSomethingInSecondModule()
        ' MsgBox(ExampleClass.SumOf(4, 3))
        Dim jimmy As New Animal
        Dim bob As New Mammal
        Dim lucky As New Dog
        Dim pepe As New Dog
        Dim nemo As New Fish
        Dim tweety As New Bird


        jimmy.Move()
        Console.WriteLine(jimmy.skinType)
        bob.Move()
        Console.WriteLine(bob.skinType)
        lucky.speak()
        lucky.Move()
        Console.WriteLine(lucky.skinType)

        pepe.Movement = "shiver"
        pepe.skinType = "hairless rat"
        pepe.speak()
        pepe.Move()

        Console.WriteLine(nemo.vocalization)

        Console.WriteLine(tweety.vocalization)


    End Sub
    Sub DoSomethingInMainModule()
        MsgBox("Hello from the MainModule!")
    End Sub

End Module
