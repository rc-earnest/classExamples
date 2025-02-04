Option Explicit On
Option Strict On
Module classExamples

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        Dim random As Single
        Console.WriteLine("Hello from Sub Main!")
        Console.WriteLine($"{myLuckyNumber}")
        'MyOtherSub()
        'Sandwich(myLuckyNumber)
        Nautica(myLuckyNumber)
        Console.WriteLine("Hello from Sub Main!")
        Console.WriteLine($"{myLuckyNumber}")
        random = Rnd()
        Console.WriteLine($"{random * 5}")
    End Sub


    'Sub MyOtherSub()
    '    Dim myLuckyNumber As Integer = 3
    '    Console.WriteLine("Hello from MyOtherSub!")
    '    Console.WriteLine($"{myLuckyNumber}")
    'End Sub

    'Sub Sandwich(ByVal myLuckyNumber As Integer)
    '    myLuckyNumber += 5
    '    Console.WriteLine("Hello from Subsandwich!")
    '    Console.WriteLine($"{myLuckyNumber}")
    'End Sub

    Sub Nautica(ByRef myLuckyNumber As Integer)
        'myLuckyNumber += 5
        Console.WriteLine("Hello from Subnautica!")
        Console.WriteLine($"{myLuckyNumber}")
    End Sub
End Module
