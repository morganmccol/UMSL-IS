Imports System.Drawing.Drawing2D

Public Class GameLoad2

    Private Structure structSnake
        Dim rect As Rectangle
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Enum Direction
        Right
        Down
        Left
        Up
    End Enum

    Private Const init_snake_size As Integer = 15
    Private Const COLUMN_COUNT As Integer = 65
    Private Const ROW_COUNT As Integer = 47

    Private curRecCount As Integer
    Private rects(,) As Rectangle
    Private isSnakePart(,) As Boolean
    Private snake As Collection
    Private snakeBrush As Brush = New SolidBrush(Color.FromArgb(125, 50, 134))
    Private backBrush As Brush = New SolidBrush(Color.FromArgb(1, 1, 1))
    Private tokenBrush As Brush = New SolidBrush(Color.Aquamarine)
    Private curDirection As Direction

    Private background As Bitmap
    Private columnCount As Integer
    Private rowCount As Integer
    Dim score As Integer
    Private snakeSpeed As Double
    Private snakeLength As Integer
    Private token As Rectangle

    Private Sub initSnake()

        Dim x As Integer = 40
        Dim y As Integer = 25
        Dim sSnake As structSnake
        snake = New Collection

        Dim snakePosition As Point = New Point(x, y)

        For i = 1 To init_snake_size
            sSnake.rect = rects(x, y)
            sSnake.x = x
            sSnake.y = y
            snake.Add(sSnake)
        Next

        snakeLength = init_snake_size
        snakeSpeed = 100

        StatusContainer.Items("SnakeLengthTS").Text = "Length: " & CStr(snakeLength)
        StatusContainer.Items("SnakeSpeedTS").Text = "Speed: " & CStr(snakeSpeed) & "%"

    End Sub

    Private Sub selectRectangles()

        Dim g As Graphics = Graphics.FromImage(My.Resources.back)
        Dim sSnake As structSnake

        For i = 1 To init_snake_size
            sSnake = snake(i)
            g.FillRectangle(snakeBrush, sSnake.rect)
            isSnakePart(sSnake.x, sSnake.y) = True
        Next

        background = New Bitmap(My.Resources.back)

        g.Dispose()
        Refresh()

    End Sub

    Private Sub initRectangles()

        columnCount = COLUMN_COUNT
        rowCount = ROW_COUNT

        ReDim rects(columnCount, rowCount)
        ReDim isSnakePart(columnCount, rowCount)

        For j = 0 To rowCount
            For i = 0 To columnCount

                rects(i, j) = New Rectangle((i * 10) + 1, (j * 10) + 1, 9, 9)
                isSnakePart(i, j) = False
            Next
        Next

    End Sub

    Private Sub initialize()

        curRecCount = init_snake_size
        curDirection = Direction.Left
        score = 0
        initRectangles()
        initSnake()
        selectRectangles()
        setToken()
        setScoreSetLength()
        tmr.Interval = 50
        tmr.Enabled = True

    End Sub

    Private Sub setScoreSetLength()
        StatusContainer.Items("TotalPointsTS").Text = "Total Points: " & CStr(score)
        StatusContainer.Items("SnakeLengthTS").Text = "Snake Length: " & CStr(score + init_snake_size)
    End Sub

    Private Sub setToken()

        Randomize()
        Dim x As Integer
        Dim y As Integer
        Dim g As Graphics = Graphics.FromImage(background)

        x = CInt(Rnd() * columnCount)
        Do While x > columnCount Or isSnakePart(x, y) = True
            x = CInt(Rnd() * columnCount)
        Loop

        y = CInt(Rnd() * rowCount)
        Do While y > rowCount Or isSnakePart(x, y) = True
            y = CInt(Rnd() * rowCount)
        Loop

        token = rects(x, y)
        StatusContainer.Items("TokenLocTS").Text = "Token Location: ( " & CStr(x) & " , " & CStr(y) & " )"

        g.FillEllipse(tokenBrush, token)
        Refresh()
        g.Dispose()

    End Sub

    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        initialize()
    End Sub

    Private Sub main_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Down
                If Not (curDirection = Direction.Down Or curDirection = Direction.Up) Then
                    curDirection = Direction.Down
                End If
            Case Keys.Left
                If Not (curDirection = Direction.Left Or curDirection = Direction.Right) Then
                    curDirection = Direction.Left
                End If
            Case Keys.Right
                If Not (curDirection = Direction.Right Or curDirection = Direction.Left) Then
                    curDirection = Direction.Right
                End If
            Case Keys.Up
                If Not (curDirection = Direction.Up Or curDirection = Direction.Down) Then
                    curDirection = Direction.Up
                End If
        End Select

    End Sub

    Private Sub moveSnake()

        Dim sSnake As structSnake
        Dim x As Integer
        Dim y As Integer
        Dim rect As Rectangle = New Rectangle()
        Dim g As Graphics = Graphics.FromImage(background)

        tmr.Enabled = False

        ' Remove the last snake square.
        sSnake = snake(snake.Count)
        g.FillRectangle(backBrush, sSnake.rect)
        snake.Remove(snake.Count)
        isSnakePart(sSnake.x, sSnake.y) = False

        ' Get the index of the snake's first square.
        sSnake = snake.Item(1)

        x = sSnake.x
        y = sSnake.y

        Select Case curDirection
            Case Direction.Down
                y = y + 1
                If y > rowCount Then y = 0
            Case Direction.Left
                x = x - 1
                If x < 0 Then x = columnCount
            Case Direction.Right
                x = x + 1
                If x > columnCount Then x = 0
            Case Direction.Up
                y = y - 1
                If y < 0 Then y = rowCount
        End Select

        If isSnakePart(x, y) = True Then
            tmr.Enabled = False

            If MessageBox.Show("Ouch!", "Snake", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                initialize()
                Exit Sub
            Else
                End
            End If

        End If

        StatusContainer.Items("SnakeLocTS").Text = "Snake Location: ( " & CStr(x) & " , " & CStr(y) & " )"

        rect = rects(x, y)

        sSnake.x = x
        sSnake.y = y
        sSnake.rect = rect
        isSnakePart(x, y) = True

        g.FillRectangle(snakeBrush, sSnake.rect)
        Me.BackgroundImage = background

        ' Add the snake square to the beginning of the collection.
        snake.Add(sSnake, , 1)

        If rects(x, y).Equals(CObj(token)) Then

            score += 1
            setScoreSetLength()

            If score Mod 5 = 0 Then
                sSnake = snake.Item(snake.Count)
                Select Case curDirection
                    Case Direction.Down
                        sSnake.y -= 1
                    Case (Direction.Left)
                        sSnake.x += 1
                    Case Direction.Right
                        sSnake.x -= 1
                    Case Direction.Up
                        sSnake.y += 1
                End Select

                sSnake.rect = rects(sSnake.x, sSnake.y)
                g.FillRectangle(snakeBrush, sSnake.rect)
                Me.BackgroundImage = background
                snake.Add(sSnake, , , snake.Count)
                snakeLength = snake.Count

                tmr.Interval -= 2
                If tmr.Interval < 0 Then tmr.Interval = 1

                snakeSpeed = 100 + (((50 - tmr.Interval) / 50) * 100)
                StatusContainer.Items("SnakeSpeedTS").Text = "Speed: " & CStr(snakeSpeed) & "%"

            End If

            setToken()

        End If

        Refresh()

        tmr.Enabled = True

    End Sub

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        moveSnake()
        Application.DoEvents()
    End Sub

End Class
