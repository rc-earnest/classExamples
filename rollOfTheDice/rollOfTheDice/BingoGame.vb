'Bingo Game Program
'Client: Shady Acres
'Spring 2025

Option Strict On
Option Explicit On
'TODO
'[] Display Bingo Board
'[] Draw a random ball that has not already been drawn
'[] update display to show all drawn balls
'[] refresh tracking with "C" or when all balls have been drawn 
Module BingoGame

    Sub Main()
        DisplayBoard()
    End Sub

    Sub DisplayBoard()
        Dim temp As String = "X |"
        Dim heading() As String = {"B", "I", "N", "G", "O"}
        For Each letter In heading
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(20, "_"))
        For i = 1 To 15
            For j = 1 To 5
                temp = temp.PadLeft(4)
                Console.Write(temp)

            Next
            Console.WriteLine()
        Next
    End Sub

    Function BingoTracker(ballNumber As Integer, ballLetter As Integer, Optional clear As Boolean = False) As Boolean(,)
        Static _bingoTracker(14, 4) As Boolean
        'actral code here
        Return _bingoTracker
    End Function

    Function randomNumberBetween(min As Integer, max As Integer) As Integer
        Randomize()
        Dim randomNumber As Single
        randomNumber = Rnd()
        randomNumber *= max - min + 1
        randomNumber += min - 1
        Return CInt(Math.Ceiling(randomNumber))
    End Function
End Module
