
'Spring 2025
Option Explicit On
Option Strict On

Public Class GraphicsExamples
    Function ForeGroundColor(Optional newColor As Color = Nothing) As Color
        Static _foreColor As Color = Color.Black

        If newColor <> Nothing Then
            _foreColor = newColor
        End If

        Return _foreColor
    End Function
    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 1
        If newWidth > 100 Then
            _penWidth = 100
        ElseIf newWidth > 0 Then
            _penWidth = newWidth
        End If



        Return _penWidth
    End Function

    Function BackGroundColor(Optional newColor As Color = Nothing) As Color
        Static _backColor As Color = Color.White

        If newColor <> Nothing Then
            _backColor = newColor
        End If

        Return _backColor
    End Function


    Sub DrawWithMouse(oldX As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ForeGroundColor, PenWidth)


        g.DrawLine(pen, oldX, oldY, newX, newY)

        g.Dispose()
    End Sub

    Sub DrawSinWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.IndianRed)
        Dim oldx, oldY, newY As Integer
        Dim yOffset = DrawingPictureBox.Height \ 2
        Dim yMax As Integer = yOffset
        Dim degreesPerPoint As Double = 360 / DrawingPictureBox.Width
        oldY = yOffset
        yMax *= -1
        yMax = yMax + 1
        For x = 0 To DrawingPictureBox.Width
            newY = CInt(yMax * Math.Sin((x * degreesPerPoint) * (Math.PI / 180))) + yOffset
            g.DrawLine(pen, oldx, oldY, x, newY)
            oldx = x
            oldY = newY
        Next

        g.Dispose()
    End Sub

    ' Event Handlers ----------------------------------------------------------
    Private Sub GraphicsExamplesForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove, DrawingPictureBox.MouseDown
        Static oldX, oldY As Integer
        Me.Text = $"({e.X},{e.Y}) {e.Button.ToString} FG {ForeGroundColor.ToString}"
        'TODO only draw when button is held down
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
                'ignore
            Case "Middle"
                'TODO
        End Select

        oldX = e.X
        oldY = e.Y
    End Sub

    Private Sub ChangeForegroundColor(sender As Object, e As EventArgs) Handles ForeGroundColorTopMenuItem.Click, ForegroundColorContextMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            ForeGroundColor(ColorDialog.Color)
        End If
    End Sub

    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click
        DrawingPictureBox.Refresh()
    End Sub

    Private Sub BackgroundColorContextMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorContextMenuItem.Click, BackgroundColorToolStripMenuItem.Click
        Dim result As DialogResult = ColorDialog.ShowDialog()
        If result.ToString = "OK" Then
            DrawingPictureBox.BackColor = BackGroundColor(ColorDialog.Color)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

    Private Sub GraphicsExamples_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub GraphicsExamples_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SplashForm.Show()
        Me.Hide()
    End Sub

    Private Sub SinWaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SinWaveToolStripMenuItem.Click
        DrawSinWave()
    End Sub
End Class
