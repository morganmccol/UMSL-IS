Public Class Calculator
    Dim id As Integer
    Dim fname As String
    Dim lname As String
    Dim hours As Integer
    Dim rate As Double
    Dim skip As Boolean = False
    Friend employees(2) As Employee

    Private Sub rateBox_TextChanged(sender As Object, e As EventArgs) Handles rateBox.TextChanged
        Try
            If skip = False Then
                rate = rateBox.Text
                If rate <= 1000 Then
                    checkHour.Checked = True
                    checkSal.Checked = False
                Else
                    checkSal.Checked = True
                    hoursBox.Text = 40
                    checkHour.Checked = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Stop messing with RateBox!")
        End Try
    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click

        Dim earnings, federalTaxes, OTearnings, netpay, total As Double

        id = idBox.Text
        fname = fnameBox.Text
        lname = lnameBox.Text
        hours = hoursBox.Text
        rate = rateBox.Text

        If checkSal.Checked = True Then
            rate = (rate / 52) / 40
            earnings = hours * rate

        ElseIf checkHour.Checked = True Then
            If hours <= 40 Then
                earnings = hours * rate
            Else
                earnings = rate * 40
                OTPay(hours, rate, OTearnings)
            End If
        End If

        netpay = earnings + OTearnings
        federalTaxes = 0.15 * netpay
        total = netpay - federalTaxes

        endBox.Text = "Employee #" + CStr(id) + vbCrLf +
        fname + " " + lname + vbCrLf + vbCrLf +
        fname + " worked " + CStr(hours) + " hours at " +
        FormatMoney(rate) + " per hour and earned " + FormatMoney(netpay) + "." + vbCrLf

        If OTearnings > 0 Then
            endBox.Text += FormatMoney(OTearnings) + " was earned from overtime." + vbCrLf
        End If

        If checkSal.Checked = True And hours > 40 Then
            endBox.Text += "Salary employees don't earn overtime pay." + vbCrLf
        End If

        endBox.Text += FormatMoney(federalTaxes) + " will be withheld for taxes." + vbCrLf + vbCrLf +
        fname + "'s total pay will be " + FormatMoney(total) + "!"
    End Sub

    Private Sub OTPay(ByVal argHours As Double, argWage As Double, ByRef argEarnings As Double)
        argEarnings += (argHours - 40) * (1.5 * argWage)
    End Sub

    Private Function FormatMoney(argMoney As Double) As String
        Dim moneyFormat As String
        moneyFormat = argMoney.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-EN"))
        Return moneyFormat
    End Function

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        skip = True
        idBox.Clear()
        fnameBox.Clear()
        ListBox1.Items.Clear()
        lnameBox.Clear()
        hoursBox.Clear()
        rateBox.Clear()
        skip = False
        checkHour.Checked = False
        checkSal.Checked = False
        endBox.Clear()

        idBox.Focus()
    End Sub

    Private Sub idBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles idBox.KeyPress
        KeyCheck(sender, e)
    End Sub

    Private Sub hoursBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles hoursBox.KeyPress
        KeyCheck(sender, e)
    End Sub

    Private Sub rateBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rateBox.KeyPress
        KeyCheck(sender, e)
    End Sub

    Private Sub KeyCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ASG1_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 2
            employees(i) = Nothing
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            For i As Integer = 0 To 2
                If employees(i) Is Nothing Then
                    employees(i) = New Employee(id, fname, lname, hours, rate)
                    Exit For
                Else
                    If employees(idBox.Text) IsNot Nothing Then
                        MsgBox("That account already exists.")
                        Exit For
                    End If
                End If
            Next
        Catch ex As IndexOutOfRangeException
            MsgBox("No more than three!")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        For x As Integer = 0 To 2
            If employees(x) IsNot Nothing Then
                ListBox1.Items.Add(employees(x).ToString)
            End If
        Next x
    End Sub
End Class

<Serializable()> Class Employee

    Private mID = Calculator.idBox.Text
    Private mFName = Calculator.fnameBox.Text
    Private mLName = Calculator.lnameBox.Text
    Private mHours = Calculator.hoursBox.Text
    Private mRate = Calculator.rateBox.Text

    Public Sub New(ByVal arg_id As Integer, arg_fname As String, ByVal arg_lname As String, ByVal arg_hours As Integer, ByVal arg_rate As Double)
        mID = arg_id
        mFName = arg_fname
        mLName = arg_lname
        mHours = arg_hours
        mRate = arg_rate
    End Sub
    Sub New()
    End Sub

    'Getters/Setters
    Public Property fname() As String
        Get
            Return mFName
        End Get
        Set(ByVal Value As String)
            mFName = Value
        End Set
    End Property

    Public Property lname() As String
        Get
            Return mLName
        End Get
        Set(ByVal Value As String)
            mLName = Value
        End Set
    End Property
    Public Property id() As Int32
        Get
            Return mID
        End Get
        Set(ByVal Value As Int32)
            mID = Value
        End Set
    End Property

    Public Property rate() As Double
        Get
            Return mRate
        End Get
        Set(ByVal Value As Double)
            mRate = Value
        End Set
    End Property

    Public Property hours() As Integer
        Get
            Return mHours
        End Get
        Set(ByVal Value As Integer)
            mHours = Value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Employee id: " & id & " | " & " Name: " & lname & ", " & fname & " | " & " Payrate: " & rate & " | " & " Hours :" & hours
    End Function

End Class