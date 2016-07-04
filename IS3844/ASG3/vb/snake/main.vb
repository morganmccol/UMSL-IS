Imports System.Drawing.Drawing2D

Public Class main

    Private Const init_size As Integer = 15, COLUMN_COUNT As Integer = 65, ROW_COUNT As Integer = 47

    Dim score As Integer
    Friend snakeSpeed As Double
    Private noms As Rectangle

    Private columnCount, rowCount, snakeLength, curRecCount As Integer

    Private rects(,) As Rectangle
    Private isSnake(,) As Boolean
    Private snake As Collection

    Private snakeBrush As Brush = New SolidBrush(Color.Violet)
    Private backBrush As Brush = New SolidBrush(Color.FromArgb(255, 0, 0, 0))
    Private nomsBrush As Brush = New SolidBrush(Color.Aquamarine)

    Private curDirection As Direction
    Private background As Bitmap

    Private Structure structSnake
        Dim rect As Rectangle
        Dim x, y As Integer
    End Structure

    Private Enum Direction
        Right
        Down
        Left
        Up
    End Enum

    Private Sub initSnake()

        'Sets snake starting position
        Dim x As Integer = 40, y = 25

        Dim sSnake As structSnake
        snake = New Collection
        snakeSpeed = 100

        Dim snakePosition As Point = New Point(x, y)

        'Sets coordinates for snake body
        For i = 1 To init_size
            sSnake.rect = rects(x, y)
            sSnake.x = x
            sSnake.y = y
            snake.Add(sSnake)
        Next

        snakeLength = init_size

        'Set initial values for length and speed toolstrips
        StatusContainer.Items("SnakeLengthTS").Text = "Length: " & CStr(snakeLength)
        StatusContainer.Items("SnakeSpeedTS").Text = "Speed: " & CStr(snakeSpeed) & "%"

    End Sub

    'Creates rectangles to fill the entire playable area
    Private Sub initGrid()

        columnCount = COLUMN_COUNT
        rowCount = ROW_COUNT

        ReDim rects(columnCount, rowCount)
        ReDim isSnake(columnCount, rowCount)

        'Creates grid
        For j = 0 To rowCount
            For i = 0 To columnCount
                rects(i, j) = New Rectangle((i * 10) + 1, (j * 10) + 1, 9, 9)
                isSnake(i, j) = False
            Next
        Next

    End Sub
    Private Sub selectRectangles()

        Dim g As Graphics = Graphics.FromImage(My.Resources.back)
        Dim sSnake As structSnake

        'Fills in snake body with brush (based on initSnake coordinates)
        For i = 1 To init_size
            sSnake = snake(i)
            g.FillRectangle(snakeBrush, sSnake.rect)
            isSnake(sSnake.x, sSnake.y) = True
        Next

        background = New Bitmap(My.Resources.back)

        g.Dispose()
        Refresh()

    End Sub

    Private Sub initialize()
        curRecCount = init_size
        curDirection = Direction.Left
        score = 0
        initGrid()
        initSnake()
        selectRectangles()
        setNoms()
        setScoreSetLength()
        snakeTime.Enabled = True

    End Sub

    'Updates toolstrips for snake length and total points
    Private Sub setScoreSetLength()
        StatusContainer.Items("TotalPointsTS").Text = "Total Points: " & CStr(score)
        StatusContainer.Items("SnakeLengthTS").Text = "Snake Length: " & CStr(score + init_size)
    End Sub

    'Random number generator
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    'Token generation (food)
    Private Sub setNoms()

        Dim g As Graphics = Graphics.FromImage(background)
        Dim x As Integer = GetRandom(0, COLUMN_COUNT), y = GetRandom(0, ROW_COUNT)

        Do While isSnake(x, y) = True
            x = GetRandom(0, COLUMN_COUNT)
        Loop

        Do While isSnake(x, y) = True
            y = GetRandom(0, ROW_COUNT)
        Loop

        noms = rects(x, y)
        StatusContainer.Items("NomsLocTS").Text = "Noms Location: ( " & CStr(x) & " , " & CStr(y) & " )"

        g.FillEllipse(nomsBrush, noms)
        Refresh()
        g.Dispose()

    End Sub

    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        initialize()
    End Sub

    'Binding enumeration values to key down events
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

    Private Sub gameOver()
        If MessageBox.Show("Restart?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            initialize()
            Exit Sub
        Else
            End
        End If
    End Sub

    Private Sub moveSnake()

        Dim sSnake As structSnake
        Dim x, y As Integer
        Dim rect As Rectangle = New Rectangle()
        Dim g As Graphics = Graphics.FromImage(background)

        snakeTime.Enabled = False

        ' Remove the last snake square.
        sSnake = snake(snake.Count)
        g.FillRectangle(backBrush, sSnake.rect)
        snake.Remove(snake.Count)
        isSnake(sSnake.x, sSnake.y) = False

        ' Get the index of the snake's first square.
        sSnake = snake.Item(1)

        x = sSnake.x
        y = sSnake.y

        Select Case curDirection
            Case Direction.Down
                y += 1
                If y > rowCount Then y = 0
            Case Direction.Left
                x += -1
                If x < 0 Then x = columnCount
            Case Direction.Right
                x += 1
                If x > columnCount Then x = 0
            Case Direction.Up
                y += -1
                If y < 0 Then y = rowCount
        End Select

        If isSnake(x, y) = True Then 'Collison detection and end game prompt
            snakeTime.Enabled = False
            gameOver()

        End If

        StatusContainer.Items("SnakeLocTS").Text = "Snake Location: ( " & CStr(x) & " , " & CStr(y) & " )"

        rect = rects(x, y)

        sSnake.x = x
        sSnake.y = y
        sSnake.rect = rect
        isSnake(x, y) = True

        g.FillRectangle(snakeBrush, sSnake.rect)
        Me.BackgroundImage = background

        'Add the snake square to the beginning of the collection.
        snake.Add(sSnake, , 1)

        If rects(x, y).Equals(CObj(noms)) Then

            score += 1
            setScoreSetLength()

            If score Mod 1 = 0 Then 'Add one to snakeLength whenever one nom is eaten
                sSnake = snake.Item(snake.Count)

                sSnake.rect = rects(sSnake.x, sSnake.y)
                g.FillRectangle(snakeBrush, sSnake.rect)
                Me.BackgroundImage = background
                snake.Add(sSnake, , , snake.Count)
                snakeLength = snake.Count

                snakeTime.Interval -= 1
                If snakeTime.Interval < 0 Then snakeTime.Interval = 1

                snakeSpeed += (((50 - snakeTime.Interval) / 50) * 100)
                StatusContainer.Items("SnakeSpeedTS").Text = "Speed: " & CStr(snakeSpeed) & "%"
            End If
            setNoms()
        End If

        Refresh()

        snakeTime.Enabled = True

    End Sub

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles snakeTime.Tick
        moveSnake()
        Application.DoEvents()
    End Sub

End Class
