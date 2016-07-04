<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.rateBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hoursBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnameBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fnameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.endBox = New System.Windows.Forms.TextBox()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.checkHour = New System.Windows.Forms.RadioButton()
        Me.checkSal = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(22, 378)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(100, 23)
        Me.clearBtn.TabIndex = 30
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'rateBox
        '
        Me.rateBox.Location = New System.Drawing.Point(97, 94)
        Me.rateBox.Name = "rateBox"
        Me.rateBox.Size = New System.Drawing.Size(100, 20)
        Me.rateBox.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Pay Rate"
        '
        'hoursBox
        '
        Me.hoursBox.Location = New System.Drawing.Point(303, 94)
        Me.hoursBox.Name = "hoursBox"
        Me.hoursBox.Size = New System.Drawing.Size(100, 20)
        Me.hoursBox.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Hours Worked"
        '
        'lnameBox
        '
        Me.lnameBox.Location = New System.Drawing.Point(303, 59)
        Me.lnameBox.Name = "lnameBox"
        Me.lnameBox.Size = New System.Drawing.Size(100, 20)
        Me.lnameBox.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Last Name"
        '
        'fnameBox
        '
        Me.fnameBox.Location = New System.Drawing.Point(97, 59)
        Me.fnameBox.Name = "fnameBox"
        Me.fnameBox.Size = New System.Drawing.Size(100, 20)
        Me.fnameBox.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "First Name"
        '
        'idBox
        '
        Me.idBox.Location = New System.Drawing.Point(218, 21)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(100, 20)
        Me.idBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Employee ID"
        '
        'endBox
        '
        Me.endBox.Location = New System.Drawing.Point(31, 191)
        Me.endBox.Multiline = True
        Me.endBox.Name = "endBox"
        Me.endBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.endBox.Size = New System.Drawing.Size(372, 130)
        Me.endBox.TabIndex = 34
        Me.endBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(158, 162)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(122, 23)
        Me.calcBtn.TabIndex = 35
        Me.calcBtn.Text = "Calculate"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'checkHour
        '
        Me.checkHour.AutoSize = True
        Me.checkHour.Location = New System.Drawing.Point(158, 129)
        Me.checkHour.Name = "checkHour"
        Me.checkHour.Size = New System.Drawing.Size(55, 17)
        Me.checkHour.TabIndex = 36
        Me.checkHour.TabStop = True
        Me.checkHour.Text = "Hourly"
        Me.checkHour.UseVisualStyleBackColor = True
        '
        'checkSal
        '
        Me.checkSal.AutoSize = True
        Me.checkSal.Location = New System.Drawing.Point(232, 129)
        Me.checkSal.Name = "checkSal"
        Me.checkSal.Size = New System.Drawing.Size(54, 17)
        Me.checkSal.TabIndex = 37
        Me.checkSal.TabStop = True
        Me.checkSal.Text = "Salary"
        Me.checkSal.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(158, 378)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "View Employees"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(31, 325)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(372, 43)
        Me.ListBox1.TabIndex = 41
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 413)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.checkSal)
        Me.Controls.Add(Me.checkHour)
        Me.Controls.Add(Me.calcBtn)
        Me.Controls.Add(Me.endBox)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.rateBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hoursBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fnameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Calculator"
        Me.Text = "New Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents rateBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents hoursBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lnameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fnameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents endBox As System.Windows.Forms.TextBox
    Friend WithEvents calcBtn As System.Windows.Forms.Button
    Friend WithEvents checkHour As System.Windows.Forms.RadioButton
    Friend WithEvents checkSal As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
