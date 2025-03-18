Public Class ExampleClass
    ''' <summary>
    ''' Returns the sum of the firstNumber plus the secondNumber.
    ''' </summary>
    ''' <param name="firstNumber"></param>
    ''' <param name="secondNumber"></param>
    ''' <returns></returns>
    Shared Function SumOf(firstNumber As Integer, secondNumber As Integer) As Integer

        Return firstNumber + secondNumber
    End Function

    Public Sub DoSomething()
        MsgBox("hello")
    End Sub

End Class
