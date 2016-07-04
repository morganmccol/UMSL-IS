<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameLoad2
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
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.TokenLocTS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SnakeLocTS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SnakeLengthTS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TotalPointsTS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusContainer = New System.Windows.Forms.StatusStrip()
        Me.SnakeSpeedTS = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmr
        '
        Me.tmr.Enabled = True
        Me.tmr.Interval = 50
        '
        'TokenLocTS
        '
        Me.TokenLocTS.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.TokenLocTS.Name = "TokenLocTS"
        Me.TokenLocTS.Size = New System.Drawing.Size(92, 17)
        Me.TokenLocTS.Text = "Token Location:"
        Me.TokenLocTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SnakeLocTS
        '
        Me.SnakeLocTS.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.SnakeLocTS.Name = "SnakeLocTS"
        Me.SnakeLocTS.Size = New System.Drawing.Size(90, 17)
        Me.SnakeLocTS.Text = "Snake Location:"
        Me.SnakeLocTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SnakeLengthTS
        '
        Me.SnakeLengthTS.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.SnakeLengthTS.Name = "SnakeLengthTS"
        Me.SnakeLengthTS.Size = New System.Drawing.Size(81, 17)
        Me.SnakeLengthTS.Text = "Snake Length:"
        Me.SnakeLengthTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalPointsTS
        '
        Me.TotalPointsTS.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.TotalPointsTS.Name = "TotalPointsTS"
        Me.TotalPointsTS.Size = New System.Drawing.Size(268, 17)
        Me.TotalPointsTS.Spring = True
        Me.TotalPointsTS.Text = "Total Points:"
        Me.TotalPointsTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusContainer
        '
        Me.StatusContainer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TokenLocTS, Me.SnakeSpeedTS, Me.SnakeLocTS, Me.SnakeLengthTS, Me.TotalPointsTS})
        Me.StatusContainer.Location = New System.Drawing.Point(0, 476)
        Me.StatusContainer.Name = "StatusContainer"
        Me.StatusContainer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusContainer.Size = New System.Drawing.Size(653, 22)
        Me.StatusContainer.TabIndex = 0
        Me.StatusContainer.Text = "StatusStrip1"
        '
        'SnakeSpeedTS
        '
        Me.SnakeSpeedTS.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.SnakeSpeedTS.Name = "SnakeSpeedTS"
        Me.SnakeSpeedTS.Size = New System.Drawing.Size(76, 17)
        Me.SnakeSpeedTS.Text = "Snake Speed:"
        Me.SnakeSpeedTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.snake.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(653, 498)
        Me.Controls.Add(Me.StatusContainer)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(669, 537)
        Me.MinimumSize = New System.Drawing.Size(669, 537)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake"
        Me.StatusContainer.ResumeLayout(False)
        Me.StatusContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr As System.Windows.Forms.Timer
    Friend WithEvents TokenLocTS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SnakeLocTS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SnakeLengthTS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TotalPointsTS As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusContainer As System.Windows.Forms.StatusStrip
    Friend WithEvents SnakeSpeedTS As System.Windows.Forms.ToolStripStatusLabel

End Class
