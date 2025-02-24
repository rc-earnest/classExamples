'Bingo Game Program
'Client: Shady Acres
'Spring 2025

Option Strict On
Option Explicit On
'TODO
'[] Display Bingo Board
'[] Draw a random ball that has not already been drawn
'[] update display to show all drawn balls
'[] update display to show actual ball number
'[] refresh tracking with "C" or when all balls have been drawn 
Module BingoGame

    Sub Main()
        For i = 1 To 10
            DisplayBoard()
            DrawBall()
            Console.Read()
            Console.Clear()
        Next
    End Sub

    Sub DisplayBoard()
        Dim temp As String = " |"
        Dim heading() As String = {"B", "I", "N", "G", "O"}
        Dim tracker(,) As Boolean = BingoTracker(0, 0)

        For Each letter In heading
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(20, "_"))

        For currentNumber = 0 To 14
            For currentLetter = 0 To 4
                If tracker(currentNumber, currentLetter) Then
                    temp = "X |" 'display for drawn balls
                Else
                    temp = " |" 'display for not drawn balls
                End If
                temp = temp.PadLeft(4)
                Console.Write(temp)

            Next
            Console.WriteLine()
        Next
    End Sub

    Sub DrawBall()
        Dim temp(,) As Boolean = BingoTracker(0, 0) 'create a local copy of ball tracker array
        Dim currentBallNumber As Integer
        Dim currentBallLetter As Integer
        'loop until the current random ball has not already been marked as drawn
        Do
            currentBallNumber = randomNumberBetween(0, 14) 'get the row
            currentBallLetter = randomNumberBetween(0, 4) 'get the column

        Loop Until temp(currentBallNumber, currentBallLetter) = False

        'mark current ball as being drawn, updates the display
        BingoTracker(currentBallNumber, currentBallLetter)
        Console.WriteLine($"the current row is {currentBallNumber} and the column is {currentBallLetter}")
    End Sub


    Function BingoTracker(ballNumber As Integer, ballLetter As Integer, Optional clear As Boolean = False) As Boolean(,)
        Static _bingoTracker(14, 4) As Boolean
        'actral code here
        _bingoTracker(ballNumber, ballLetter) = True
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
