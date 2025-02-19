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
'[x] provide a way to clear/zero the total
'[x] display transactions and running total formatted as currency
'[] super bonus: create a method to include sales tax to the transaction amount
Module runningTotal
    Dim myGlobalNumber As Decimal
    Sub Main()
        Dim userInput As String
        Dim quit As Boolean = False
        Dim transactionAmount As Decimal
        Do
            Console.WriteLine("Enter a transaction amount.")
            Console.WriteLine("Type q to quit.")
            Console.WriteLine("Type t to check total.")
            Console.WriteLine("Type c to clear.")
            userInput = Console.ReadLine()
            Console.Clear()
            Try
                transactionAmount = Decimal.Parse(userInput)
                RunningTotal(transactionAmount, False)
            Catch ex As Exception
                Select Case userInput
                    Case "q"
                        quit = True
                    Case "t"
                        Console.Clear()
                        Console.WriteLine($"The current total is {RunningTotal().ToString("C")}")
                        Console.WriteLine(StrDup(80, "*"))
                    Case "c"
                        Console.Clear()
                        RunningTotal(, True)
                End Select

            End Try
        Loop Until quit
        Console.Clear()
        Console.WriteLine($"The total is {RunningTotal().ToString("C")}")
        Console.WriteLine($"The total's tax is {CalculateSalesTax(RunningTotal()).ToString("C")}")
        Console.WriteLine("Have a nice day!")
    End Sub

    Function RunningTotal(Optional currentNumber As Decimal = 0, Optional clear As Boolean = False) As Decimal
        Static _runningTotal As Decimal

        If clear Then
            _runningTotal = 0
        Else
            _runningTotal += currentNumber

        End If

        Return _runningTotal
    End Function

    Function CalculateSalesTax(amount As Decimal) As Decimal
        Const TAXRATE = 0.06@
        Return amount * TAXRATE
    End Function


End Module
