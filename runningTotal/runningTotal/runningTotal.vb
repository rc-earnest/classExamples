'Rudy Earnest
'RCET 2265
'runningTotal
'Spring 2025
'link goes here
Option Strict On
Option Explicit On
'TODO
'[x] keep track of transactions in a Function called RunningTotal()
'[x] get the current total as needed
'[] provide a way to clear/zero the total
'[] display transactions and running total formatted as currency
'[] super bonus: create a method to include sales tax to the transaction amount
Module runningTotal
    Dim myGlobalNumber As Decimal
    Sub Main()
        Dim userInput As String
        Dim quit As Boolean = False
        Dim transactionAmount As Decimal
        Do
            Console.WriteLine("Enter a transaction amount or press q to quit")
            userInput = Console.ReadLine()
            Try
                transactionAmount = Decimal.Parse(userInput)
                RunningTotal(transactionAmount)
            Catch ex As Exception



                If userInput = "q" Then
                    quit = True
                Else
                    Console.WriteLine($"You entered: {userInput}")

                End If
            End Try
        Loop Until quit
        Console.Clear()
        Console.WriteLine($"The total is {RunningTotal(0)}")
        Console.WriteLine("Have a nice day!")
    End Sub

    Function RunningTotal(currentNumber As Decimal) As Decimal
        Static _runningTotal As Decimal
        _runningTotal += currentNumber




        Return _runningTotal
    End Function



End Module
