Imports System.Data.OleDb
Imports System.Data

Partial Class ViewEvaluations
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            TeamList.Items.Add("Show All")

            Using connection As New OleDbConnection(ConfigurationManager.ConnectionStrings("main").ConnectionString)
                ' Create a connection to the Access database using the 'main' connection string defined in web.config
                Using command As New OleDbCommand("SELECT TEAMNAME FROM Evaluation ORDER BY TEAMNAME", connection)
                    connection.Open() ' Create a command that will get all the evaluations sorted by the name of the team

                    Using reader As OleDbDataReader = command.ExecuteReader() ' Get the data returned by executing the sql command created above
                        While reader.Read()
                            TeamList.Items.Add(reader("TEAMNAME"))
                        End While
                    End Using
                End Using
            End Using
        End If

        DisplayResults(Nothing)
    End Sub

    Protected Sub TeamList_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TeamList.SelectedIndexChanged
        If TeamList.SelectedIndex = 0 Then ' If the first item in the list is selected, show results from all teams
            DisplayResults(Nothing)
        Else ' If anything else is selected, we'll assume that it's a team name
            DisplayResults(TeamList.SelectedValue)
        End If
    End Sub

    Private Sub DisplayResults(TEAMNAME As String)
        Dim teamTable As New DataTable ' Create a container to hold the results
        teamTable.Columns.Add("Team Name", GetType(String))
        teamTable.Columns.Add("Question 1", GetType(Decimal))
        teamTable.Columns.Add("Question 2", GetType(Decimal))
        teamTable.Columns.Add("Question 3", GetType(Decimal))
        teamTable.Columns.Add("Question 4", GetType(Decimal))
        teamTable.Columns.Add("Comments", GetType(String))

        Using connection As New OleDbConnection(ConfigurationManager.ConnectionStrings("main").ConnectionString)
            ' Create a connection to the Access database using the 'main' connection string defined in web.config
            Using command As OleDbCommand = connection.CreateCommand ' Create a command that will get results for all teams or the specified team
                If TEAMNAME Is Nothing Then ' If a team name wasn't requested, just select all evaluations
                    command.CommandText = "SELECT * FROM Evaluation"
                Else ' If a team name was selected, make sure we filter for it
                    command.CommandText = "SELECT * FROM Evaluation WHERE TEAMNAME = ?"
                    command.Parameters.AddWithValue("@teamName", TEAMNAME)
                End If

                connection.Open()

                Using reader As OleDbDataReader = command.ExecuteReader
                    While reader.Read()
                        Dim teamRow As DataRow = teamTable.NewRow ' Populate a row in the data container that will be displayed in the grid
                        teamRow("Team Name") = reader("TEAMNAME")
                        teamRow("Question 1") = reader("Q1")
                        teamRow("Question 2") = reader("Q2")
                        teamRow("Question 3") = reader("Q3")
                        teamRow("Question 4") = reader("Q4")
                        teamRow("Comments") = reader("COMMENTS")
                        teamTable.Rows.Add(teamRow)
      
                    End While

                    teamGrid.DataSource = teamTable ' Bind the data container to the grid, which causes it to be displayed
                    teamGrid.DataBind()
                End Using
            End Using
        End Using
    End Sub
End Class
