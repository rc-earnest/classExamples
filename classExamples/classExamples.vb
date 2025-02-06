Option Explicit On
Option Strict On
Option Compare Text
Module classExamples

    Sub Main()
        Dim myLuckyNumber As Integer = 7
        'Dim random As Single
        'Console.WriteLine("Hello from Sub Main!")
        'Console.WriteLine($"{myLuckyNumber}")
        ''MyOtherSub()
        ''Sandwich(myLuckyNumber)
        'Nautica(myLuckyNumber)
        'Console.WriteLine("Hello from Sub Main!")
        'Console.WriteLine($"{myLuckyNumber}")
        'random = Rnd()
        'Console.WriteLine($"{random * 5}")

        'Console.WriteLine(MyActualLuckyNumber())
        'Console.WriteLine(SumOf(5, 7))
        For i = 1 To 100
            'Console.WriteLine(RandomNumber)
            Console.WriteLine(RandomNumberBetween(3, 4))
        Next

    End Sub


    Sub MyOtherSub()
        Dim myLuckyNumber As Integer = 3
        Console.WriteLine("Hello from MyOtherSub!")
        Console.WriteLine($"{myLuckyNumber}")
    End Sub

    Sub Sandwich(ByVal myLuckyNumber As Integer)
        myLuckyNumber += 5
        Console.WriteLine("Hello from Subsandwich!")
        Console.WriteLine($"{myLuckyNumber}")
    End Sub

    Sub Nautica(ByRef myLuckyNumber As Integer)
        'myLuckyNumber += 5
        Console.WriteLine("Hello from Subnautica!")
        Console.WriteLine($"{myLuckyNumber}")
    End Sub

    Function MyActualLuckyNumber() As Integer
        Return 77
    End Function

    Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer
        Dim result As Integer

        result = firstNumber + secondNumber

        Return result

    End Function

    Function RandomNumber() As Integer
        Dim myRandomNumber As Integer
        Randomize()
        myRandomNumber = CInt(Int((10 * Rnd()) + 1))
        Return myRandomNumber
    End Function
    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function
End Module
