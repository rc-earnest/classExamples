Option Explicit On
Option Strict On
Module classExamples

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        Console.WriteLine("Hello from Sub Main!")
        Console.WriteLine($"{myLuckyNumber}")
        MyOtherSub()
        Sandwich(myLuckyNumber)
    End Sub


    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 3
        Console.WriteLine("Hello from MyOtherSub!")
        Console.WriteLine($"{myLuckyNumber}")
    End Sub

    Sub Sandwich(ByVal myLuckyNumber As Integer)
        Console.WriteLine("Hello from Subsandwich!")
        Console.WriteLine($"{myLuckyNumber}")
    End Sub
End Module
