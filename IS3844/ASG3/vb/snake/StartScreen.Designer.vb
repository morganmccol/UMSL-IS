<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.snakeTitle1 = New System.Windows.Forms.Label()
        Me.newGame = New System.Windows.Forms.LinkLabel()
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.hard = New System.Windows.Forms.LinkLabel()
        Me.easy = New System.Windows.Forms.LinkLabel()
        Me.medium = New System.Windows.Forms.LinkLabel()
        Me.credits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'snakeTitle1
        '
        Me.snakeTitle1.AutoSize = True
        Me.snakeTitle1.BackColor = System.Drawing.Color.Transparent
        Me.snakeTitle1.Font = New System.Drawing.Font("Unibody 8 Pro Reg SmCp", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.snakeTitle1.ForeColor = System.Drawing.Color.Violet
        Me.snakeTitle1.Location = New System.Drawing.Point(-17, -42)
        Me.snakeTitle1.Name = "snakeTitle1"
        Me.snakeTitle1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 30)
        Me.snakeTitle1.Size = New System.Drawing.Size(690, 248)
        Me.snakeTitle1.TabIndex = 2
        Me.snakeTitle1.Text = "SNAKE"
        Me.snakeTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'newGame
        '
        Me.newGame.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.newGame.AutoSize = True
        Me.newGame.BackColor = System.Drawing.Color.Transparent
        Me.newGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newGame.Font = New System.Drawing.Font("Unibody 8 Pro Reg SmCp", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newGame.ForeColor = System.Drawing.Color.Thistle
        Me.newGame.LinkArea = New System.Windows.Forms.LinkArea(0, 100)
        Me.newGame.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.newGame.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newGame.Location = New System.Drawing.Point(-75, 190)
        Me.newGame.Name = "newGame"
        Me.newGame.Padding = New System.Windows.Forms.Padding(90)
        Me.newGame.Size = New System.Drawing.Size(826, 347)
        Me.newGame.TabIndex = 3
        Me.newGame.TabStop = True
        Me.newGame.Text = "new game"
        Me.newGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.newGame.UseCompatibleTextRendering = True
        '
        'tmr2
        '
        '
        'hard
        '
        Me.hard.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.hard.AutoSize = True
        Me.hard.BackColor = System.Drawing.Color.Transparent
        Me.hard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hard.Font = New System.Drawing.Font("Unibody 8 Pro Reg SmCp", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hard.ForeColor = System.Drawing.Color.Thistle
        Me.hard.LinkArea = New System.Windows.Forms.LinkArea(0, 100)
        Me.hard.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.hard.LinkColor = System.Drawing.Color.Plum
        Me.hard.Location = New System.Drawing.Point(-8, 355)
        Me.hard.Name = "hard"
        Me.hard.Padding = New System.Windows.Forms.Padding(200, 0, 200, 50)
        Me.hard.Size = New System.Drawing.Size(664, 179)
        Me.hard.TabIndex = 12
        Me.hard.TabStop = True
        Me.hard.Text = "hard"
        Me.hard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hard.UseCompatibleTextRendering = True
        Me.hard.Visible = False
        '
        'easy
        '
        Me.easy.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.easy.AutoSize = True
        Me.easy.BackColor = System.Drawing.Color.Transparent
        Me.easy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.easy.Font = New System.Drawing.Font("Unibody 8 Pro Reg SmCp", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.easy.ForeColor = System.Drawing.Color.Thistle
        Me.easy.LinkArea = New System.Windows.Forms.LinkArea(0, 100)
        Me.easy.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.easy.LinkColor = System.Drawing.Color.Plum
        Me.easy.Location = New System.Drawing.Point(-9, 179)
        Me.easy.Name = "easy"
        Me.easy.Padding = New System.Windows.Forms.Padding(200, 0, 200, 0)
        Me.easy.Size = New System.Drawing.Size(664, 129)
        Me.easy.TabIndex = 10
        Me.easy.TabStop = True
        Me.easy.Text = "easy"
        Me.easy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.easy.UseCompatibleTextRendering = True
        Me.easy.Visible = False
        '
        'medium
        '
        Me.medium.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.medium.AutoSize = True
        Me.medium.BackColor = System.Drawing.Color.Transparent
        Me.medium.Cursor = System.Windows.Forms.Cursors.Hand
        Me.medium.Font = New System.Drawing.Font("Unibody 8 Pro Reg SmCp", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.medium.ForeColor = System.Drawing.Color.Thistle
        Me.medium.LinkArea = New System.Windows.Forms.LinkArea(0, 100)
        Me.medium.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.medium.LinkColor = System.Drawing.Color.Plum
        Me.medium.Location = New System.Drawing.Point(-69, 268)
        Me.medium.Name = "medium"
        Me.medium.Padding = New System.Windows.Forms.Padding(200, 0, 200, 0)
        Me.medium.Size = New System.Drawing.Size(776, 129)
        Me.medium.TabIndex = 11
        Me.medium.TabStop = True
        Me.medium.Text = "medium"
        Me.medium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.medium.UseCompatibleTextRendering = True
        Me.medium.Visible = False
        '
        'credits
        '
        Me.credits.AutoSize = True
        Me.credits.BackColor = System.Drawing.Color.Transparent
        Me.credits.Font = New System.Drawing.Font("Unibody 8 Pro Reg SmCp", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credits.ForeColor = System.Drawing.Color.Aquamarine
        Me.credits.Location = New System.Drawing.Point(461, 470)
        Me.credits.Name = "credits"
        Me.credits.Size = New System.Drawing.Size(180, 19)
        Me.credits.TabIndex = 13
        Me.credits.Text = "by David and Morgan"
        '
        'StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.snake.My.Resources.Resources.back
        Me.ClientSize = New System.Drawing.Size(653, 498)
        Me.Controls.Add(Me.credits)
        Me.Controls.Add(Me.snakeTitle1)
        Me.Controls.Add(Me.newGame)
        Me.Controls.Add(Me.easy)
        Me.Controls.Add(Me.medium)
        Me.Controls.Add(Me.hard)
        Me.Name = "StartScreen"
        Me.Text = "COOL SNAKE GAME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents snakeTitle1 As System.Windows.Forms.Label
    Friend WithEvents newGame As System.Windows.Forms.LinkLabel
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents hard As System.Windows.Forms.LinkLabel
    Friend WithEvents easy As System.Windows.Forms.LinkLabel
    Friend WithEvents medium As System.Windows.Forms.LinkLabel
    Friend WithEvents credits As System.Windows.Forms.Label
End Class
