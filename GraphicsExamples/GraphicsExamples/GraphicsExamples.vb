
'Spring 2025
Public Class GraphicsExamples
    Function ForeGroundColor()

    End Function

    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)


        g.DrawLine(pen, oldX, oldY, newX, newY)

        g.Dispose()
    End Sub
    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black)

        'pen.Color = Color.Lime

        g.DrawLine(pen, 50, 50, 100, 100)

        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red, 3)

        g.DrawRectangle(pen, 150, 150, 300, 250)

        g.Dispose()
    End Sub

    Sub DrawEllipse()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.RoyalBlue, 5)

        g.DrawEllipse(pen, 160, 160, 280, 230)

        g.Dispose()
    End Sub

    Sub DrawString()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red, 3)
        ' Create font and brush.
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Crimson)


        g.DrawString("Graphics!", drawFont, drawBrush, 200, 200)

        g.Dispose()
    End Sub

    ' Event Handlers ----------------------------------------------------------

    Private Sub GraphicsExamples_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Static oldX, oldY As Integer
        Me.Text = $"({e.X},{e.Y})"
        DrawWithMouse(oldX, oldY, e.X, e.Y)
        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub GraphicsExamples_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawRectangle()
        DrawEllipse()
        DrawString()
    End Sub


    'Private Sub ForeGroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForeGroundColorToolStripMenuItem.Click
    '    Dim result As DialogResult = ColorDialog.ShowDialog()
    '    MsgBox(result.ToString)
    '    ForeGroundColor(ColorDialog.Color)
    'End Sub
End Class
