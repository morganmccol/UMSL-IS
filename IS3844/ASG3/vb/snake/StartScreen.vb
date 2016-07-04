Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class StartScreen

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.back
    End Sub

    Private Sub newGame_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newGame.MouseEnter
        newGame.LinkColor = System.Drawing.Color.Aquamarine
    End Sub

    Private Sub newGame_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newGame.MouseLeave
        newGame.LinkColor = System.Drawing.Color.Plum
    End Sub

    Private Sub newGame_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles newGame.LinkClicked
        newGame.Hide()
        easy.Show()
        medium.Show()
        hard.Show()
    End Sub

    Private Sub easy_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles easy.MouseEnter
        easy.LinkColor = System.Drawing.Color.Aquamarine
    End Sub

    Private Sub medium_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles medium.MouseEnter
        medium.LinkColor = System.Drawing.Color.Aquamarine
    End Sub

    Private Sub hard_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hard.MouseEnter
        hard.LinkColor = System.Drawing.Color.Aquamarine
    End Sub

    Private Sub easy_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles easy.MouseLeave
        easy.LinkColor = System.Drawing.Color.Plum
    End Sub

    Private Sub medium_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles medium.MouseLeave
        medium.LinkColor = System.Drawing.Color.Plum
    End Sub

    Private Sub hard_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hard.MouseLeave
        hard.LinkColor = System.Drawing.Color.Plum
    End Sub

    Private Structure structSnake
        Dim rect As Rectangle
        Dim x, y As Integer
    End Structure

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

    Private background As Bitmap

    Private Sub initSnake()

        'Snake starting coordinates
        Dim x As Integer = 40, y = 14

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
    End Sub


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

        'Fills in snake body with brush
        For i = 1 To init_size
            sSnake = snake(i)
            g.FillRectangle(snakeBrush, sSnake.rect)
            isSnake(sSnake.x, sSnake.y) = True
        Next

        background = New Bitmap(My.Resources.back)

        g.Dispose()
        Refresh()

    End Sub

    Private Sub main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        curRecCount = init_size
        initGrid()
        initSnake()
        selectRectangles()
        tmr2.Interval = 50
        tmr2.Enabled = True
    End Sub

    Private Sub moveSnake()
        Dim sSnake As structSnake
        Dim x, y As Integer
        Dim rect As Rectangle = New Rectangle()
        Dim g As Graphics = Graphics.FromImage(background)

        tmr2.Enabled = False

        'Remove the last square.
        sSnake = snake(snake.Count)
        g.FillRectangle(backBrush, sSnake.rect)
        snake.Remove(snake.Count)
        isSnake(sSnake.x, sSnake.y) = False

        'Get location of first square.
        sSnake = snake.Item(1)

        x = sSnake.x
        y = sSnake.y

        x = x + 1
        If x > columnCount Then x = 0

        rect = rects(x, y)

        sSnake.x = x
        sSnake.y = y
        sSnake.rect = rect
        isSnake(x, y) = True

        g.FillRectangle(snakeBrush, sSnake.rect)
        Me.BackgroundImage = background

        'Add square to beginning
        snake.Add(sSnake, , 1)
        Refresh()
        tmr2.Enabled = True
    End Sub

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr2.Tick
        moveSnake()
        Application.DoEvents()
    End Sub

    Private Sub easy_Linkclicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles easy.LinkClicked
        main.snakeTime.Interval = 60
        main.Show()
        Me.Hide()
    End Sub

    Private Sub medium_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles medium.LinkClicked
        main.snakeTime.Interval = 50
        main.Show()
        Me.Hide()
    End Sub

    Private Sub hard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles hard.LinkClicked
        main.snakeTime.Interval = 40
        main.Show()
        Me.Hide()
    End Sub
End Class