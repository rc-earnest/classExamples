'Rudy Earnest
'RCET 2265
'Spring 2025
'Name of Repo
'https://github.com/rc-earnest/classExamples.git
Option Strict On
Option Explicit On
Option Compare Text
Module arrayExamples

    Sub Main()

        'arrays are cool
        'Dim names() As String = {"john", "paul", "ringo", "jeff"}
        '    Dim fruits(5) As String
        '    Dim beanCounts = New Integer() {12342, 343, 1234, 4646}
        '    fruits(0) = "banana"
        '    fruits(3) = "grape"
        '    'fruits(6) = "apple"

        '    For i = LBound(names) To UBound(names)
        '        Console.WriteLine(names(i))

        '    Next

        MultiDimentionalArrays()


    End Sub

    Sub MultiDimentionalArrays()
        Dim students(14, 2) As Single
        Dim classes() As String = {"Math", "History", "Art"}
        Dim somethingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim threeDimensionArray(,,) As Integer = {{{1}, {2}, {3}}, {{4}, {5}, {6}}, {{7}, {8}, {9}}}

        students(0, 0) = 82.95
        students(0, 1) = 70
        students(0, 2) = 98.99
        For i = LBound(students) To UBound(students)
            For j = LBound(students) To UBound(students)
                Console.WriteLine(students(i, j))
            Next
        Next
        Console.WriteLine()
    End Sub

End Module
