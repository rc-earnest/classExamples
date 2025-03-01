'Bingo Game Program
'Client: Shady Acres
'Spring 2025

Option Strict On
Option Explicit On
'TODO
'[x] Display Bingo Board
'[x] Draw a random ball that has not already been drawn
'[x] update display to show all drawn balls
'[x] update display to show actual ball number
'[x] refresh tracking with "C" or when all balls have been drawn 
Module BingoGame

    Sub Main()
        Dim userInput As String
        Dim _lastBall(1) As Integer

        Do
            Console.Clear()
            DisplayBoard()
            Console.WriteLine()
            _lastBall = lastBall()
            Console.WriteLine($"The Last ball was {FormatBallLetter(_lastBall(1))} {FormatBallNumber(_lastBall(0), 0)}")
            Console.WriteLine("Enter what you would like to do:")
            Console.WriteLine("q to quit")
            Console.WriteLine("d to draw a bingo ball")
            Console.WriteLine("c to clear game")
            userInput = Console.ReadLine()
            Select Case userInput
                Case "d"
                    DrawBall()

                Case "c"
                    BingoTracker(0, 0,, True)
                    DrawBall(True)
                Case Else
                    'pass
            End Select

        Loop Until userInput = "q"
    End Sub

    ''' <summary>
    ''' Iterates through the traker array and displays bingo board to the console
    ''' </summary>

    Sub DisplayBoard()
        Dim displayString As String
        Dim heading() As String = {"B", "I", "N", "G", "O"}
        Dim tracker(,) As Boolean = BingoTracker(0, 0)
        Dim columnWidth As Integer = 5

        For Each letter In heading
            Console.Write(letter.PadLeft((columnWidth \ 2) + 1).PadRight(columnWidth))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(columnWidth * 5, "_"))

        For currentNumber = 0 To 14
            For currentLetter = 0 To 4
                If tracker(currentNumber, currentLetter) Then
                    displayString = $"{FormatBallNumber(currentNumber, currentLetter)} |" 'display for drawn balls
                Else
                    displayString = "|" 'display for not drawn balls
                End If
                displayString = displayString.PadLeft(columnWidth)
                Console.Write(displayString)

            Next
            Console.WriteLine()
        Next
    End Sub
    ''' <summary>
    ''' Gets two random numbers until they haven't been drawn then initializes bingo tracker to write those numbers to our tracker.
    ''' </summary>
    ''' <param name="clearCount">This clears the count of</param>
    Sub DrawBall(Optional clearCount As Boolean = False)
        Dim temp(,) As Boolean = BingoTracker(0, 0) 'create a local copy of ball tracker array
        Dim currentBallNumber As Integer
        Dim currentBallLetter As Integer
        Static ballCounter As Integer
        If clearCount Then
            ballCounter = 0
        Else
            'loop until the current random ball has not already been marked as drawn
            Do
                currentBallNumber = randomNumberBetween(0, 14) 'get the row
                currentBallLetter = randomNumberBetween(0, 4) 'get the column

            Loop Until temp(currentBallNumber, currentBallLetter) = False Or ballCounter >= 75

            'mark current ball as being drawn, updates the display
            BingoTracker(currentBallNumber, currentBallLetter, True)
            ballCounter += 1
        End If
        lastBall(currentBallNumber, currentBallLetter)
        'Console.WriteLine($"the current row is {currentBallNumber} and the column is {currentBallLetter}")
    End Sub
    Function lastBall(Optional ballNumber As Integer = -1, Optional ballLetter As Integer = -1) As Integer()
        Static _lastBall(1) As Integer

        If ballNumber <> -1 Then
            _lastBall(0) = ballNumber
            _lastBall(1) = ballLetter
        End If

        Return _lastBall
    End Function
    ''' <summary>
    ''' Contains a persistant array that tracks all possible bingo balls 
    ''' and whether they have been drawn during the current game.
    ''' </summary>
    ''' <param name="ballNumber"></param>
    ''' <param name="ballLetter"></param>
    ''' <param name="clear"></param>
    ''' <returns>Current Tracking Array</returns>

    Function BingoTracker(ballNumber As Integer,
                          ballLetter As Integer,
                          Optional Update As Boolean = False,
                          Optional clear As Boolean = False) _
                          As Boolean(,)
        Static _bingoTracker(14, 4) As Boolean

        If clear Then
            ReDim _bingoTracker(14, 4)
        ElseIf update Then
            _bingoTracker(ballNumber, ballLetter) = True
        End If

        Return _bingoTracker
    End Function

    Function FormatBallNumber(ballNumber As Integer, ballLetter As Integer) As String
        Dim _ballNumber As String
        _ballNumber = Str((ballNumber + 1) + (ballLetter * 15))
        Return _ballNumber
    End Function

    Function randomNumberBetween(min As Integer, max As Integer) As Integer
        Randomize()
        Dim randomNumber As Single
        randomNumber = Rnd()
        randomNumber *= max - min + 1
        randomNumber += min - 1
        Return CInt(Math.Ceiling(randomNumber))
    End Function

    Function FormatBallLetter(ballLetter As Integer) As String
        Dim _formatBallLetter As String
        Select Case ballLetter
            Case 0
                _formatBallLetter = "B"
            Case 1
                _formatBallLetter = "I"
            Case 2
                _formatBallLetter = "N"
            Case 3
                _formatBallLetter = "G"
            Case 4
                _formatBallLetter = "O"
        End Select
        Return _formatBallLetter
    End Function
End Module
