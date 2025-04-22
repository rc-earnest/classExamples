Option Strict On
Imports System.IO

Public Class SuperVideoForm
    Sub ReadFromFile()
        Dim filePath As String = "User Data.txt"
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String = ""
        Dim temp() As String ' use for splitting customer data
        Dim currentID As Integer = 699
        Try
            FileOpen(fileNumber, filePath, OpenMode.Input)

            Do Until EOF(fileNumber)
                Input(fileNumber, currentRecord) ' read exactly one record

                If currentRecord <> "" Then 'ignore blank records
                    temp = Split(currentRecord, ",")

                    'DisplayListBox.Items.Add(currentRecord) 'add the record to the list box

                    If temp.Length = 4 Then ' ignore malformed records
                        temp(0) = Replace(temp(0), "$", "") 'clean first name
                        DisplayListBox.Items.Add(temp(0))
                        WriteToFile(temp(0))
                        WriteToFile(temp(1))
                        WriteToFile("")
                        WriteToFile(temp(2))
                        WriteToFile("ID")
                        WriteToFile("")
                        WriteToFile("")
                        WriteToFile(temp(3))
                        WriteToFile($"000631{currentID}", True)
                        currentID += 1
                    End If


                End If
            Loop


            FileClose(fileNumber)
        Catch bob As FileNotFoundException

            MsgBox("Bob is sad...")

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace & vbNewLine)


        End Try

    End Sub

    Sub WriteToFile(newRecord As String, Optional insertNewLine As Boolean = False)
        Dim filePath As String = "..\..\CustomerData.txt"
        Dim fileNumber As Integer = FreeFile()

        Try
            FileOpen(fileNumber, filePath, OpenMode.Append)
            Write(fileNumber, newRecord)
            If insertNewLine Then
                WriteLine(fileNumber)
            End If

            FileClose(fileNumber)
        Catch ex As Exception
            MsgBox($"Error writing to {filePath}")
        End Try

    End Sub

    Sub LoadCustomerData()
        Dim filePath As String = "..\..CustomerDat.dat"
        Dim fileNumber As Integer = FreeFile()
        Dim currentRecord As String
        Dim invalidFileName As Boolean = True

        Do
            Try
                FileOpen(fileNumber, filePath, OpenMode.Input)
                invalidFileName = False
                Do Until EOF(fileNumber)
                    Input(fileNumber, currentRecord)
                    MsgBox(currentRecord)
                Loop
            Catch noFile As FileNotFoundException
                invalidFileName = True
                OpenFileDialog.FileName = ""
                OpenFileDialog.InitialDirectory = "C:\Users\rudyd\github\classExamples\SuperVideoStop\SuperVideoStop\bin\Debug"
                OpenFileDialog.Filter = "Text documents (.txt)|*.txt|All files(*.*)|*.*"
                OpenFileDialog.ShowDialog()
                filePath = OpenFileDialog.FileName
                MsgBox(noFile.Message)

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Loop While invalidFileName
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ReadFromFile()
    End Sub

    Private Sub OpenTopMenuItem_Click(sender As Object, e As EventArgs) Handles OpenTopMenuItem.Click
        LoadCustomerData()
    End Sub
End Class
