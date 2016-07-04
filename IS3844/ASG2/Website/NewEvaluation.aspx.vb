Imports System.Data.OleDb

Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ' Create a connection to the Access database using the 'main' connection string defined in web.config
            Using connection As New OleDbConnection(ConfigurationManager.ConnectionStrings("main").ConnectionString)
                Using command As New OleDbCommand("SELECT TEAMNAME FROM Evaluation ORDER BY TEAMNAME", connection)
                    'command.Connection = connection
                    connection.Open() ' Create a command that will get all the evaluations sorted by the name of the team
                    Using reader As OleDbDataReader = command.ExecuteReader() ' Get the data returned by executing the sql command created above
                        While reader.Read
                            TeamList.Items.Add(reader("TEAMNAME"))
                        End While
                    End Using
                End Using
            End Using
        Else
        End If
    End Sub

    Protected Sub NextButton_Click(sender As Object, e As System.EventArgs) Handles NextButton.Click
        Session("EvaluationTeamName") = TeamList.SelectedValue ' Save the team that was selected for use on the next page
        If Session("EvaluationTeamName") Is Nothing Then
            Response.Redirect("~/NewEvaluation.aspx")
        Else
            Response.Redirect("~/Evaluation.aspx") ' Redirect to the evaluation page in the root of the application
        End If
    End Sub

End Class
