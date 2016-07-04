Imports System.Data.OleDb
Imports System.Threading

Partial Class Default2
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        teamLabel.Text = Session("EvaluationTeamName") ' Copy the saved team name into the header
    End Sub
    Protected Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
            Using connection As New OleDbConnection(ConfigurationManager.ConnectionStrings("main").ConnectionString)
                ' Create a connection to the Access database using the 'main' connection string defined in web.config
                Using command As New OleDbCommand("UPDATE Evaluation SET q1 = ?, q2 = ?, q3 = ?, q4 = ?, comments = ? WHERE TEAMNAME = ?", connection)
                    ' Create a command that will update an evaluation for the specified team

                    command.Parameters.AddWithValue("@q1", Q1.SelectedValue) ' Set up the parameters that will replace the question marks in the sql statement
                    command.Parameters.AddWithValue("@q2", Q2.SelectedValue)
                    command.Parameters.AddWithValue("@q3", Q3.SelectedValue)
                    command.Parameters.AddWithValue("@q4", Q4.SelectedValue)
                    command.Parameters.AddWithValue("@COMMENTS", COMMENTS.Text)
                    command.Parameters.AddWithValue("@TEAMNAME", Session("EvaluationTeamName")) ' These parameters must be in the same order as they appear in sql

                    connection.Open()
                    command.ExecuteNonQuery() ' Execute the command which will actually perform the update in the database
                    connection.Close()
                End Using
            End Using
        Session.Remove("EvaluationTeamName") ' Clear the team name so that the evaluation cannot be accidentally taken again
        Response.Redirect("~/Default.aspx") ' Send the user back to the landing page
    End Sub

    Protected Sub clearBtn_Click(sender As Object, e As System.EventArgs) Handles clearBtn.Click
        Q1.ClearSelection()
        Q2.ClearSelection()
        Q3.ClearSelection()
        Q4.ClearSelection()
        COMMENTS.Text = ""
        avgBox.Text = ""
    End Sub

    'For some reason the average keeps getting up into the hundreds? It will be correct after the first radio selection, but after that it gets ridiculous
    Function calcAvg() As Double
        Dim avgResult, q1d, q2d, q3d, q4d As Double
        Double.TryParse(Q1.SelectedValue, q1d)
        Double.TryParse(Q2.SelectedValue, q2d)
        Double.TryParse(Q3.SelectedValue, q3d)
        Double.TryParse(Q4.SelectedValue, q4d)
        avgResult = (q1d + q2d + q3d + q4d) / 4.0
        Return avgResult
    End Function

    Protected Sub Q1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Q1.SelectedIndexChanged
        avgBox.Text = calcAvg()
    End Sub

    Protected Sub Q2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Q2.SelectedIndexChanged
        avgBox.Text = calcAvg()
    End Sub
    Protected Sub Q3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Q3.SelectedIndexChanged
        avgBox.Text = calcAvg()
    End Sub

    Protected Sub Q4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Q4.SelectedIndexChanged
        avgBox.Text = calcAvg()
    End Sub
End Class
