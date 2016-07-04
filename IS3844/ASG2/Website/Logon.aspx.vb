Imports System.Data.OleDb

Partial Class Logon
    Inherits System.Web.UI.Page

    Protected Sub Login1_Authenticate(sender As Object, e As AuthenticateEventArgs) Handles Login1.Authenticate
        If ValidataUser(Login1.UserName, Login1.Password) Then
            e.Authenticated = True
            FormsAuthentication.SetAuthCookie(Login1.UserName, False)
            Login1.Visible = False
            Response.Redirect("~/Default.aspx")
        Else
            e.Authenticated = False
        End If
    End Sub

    Public Function ValidataUser(username As String, password As String) As Boolean
        Using connection As New OleDbConnection(ConfigurationManager.ConnectionStrings("main").ConnectionString)
            ' Create a command that will check the database for a user with the given password
            Using command As New OleDbCommand("SELECT * FROM Security WHERE ID = ? AND Password = ?")
                command.Parameters.AddWithValue("@id", username) ' Set up the parameters that will replace the question marks in the sql statement.
                command.Parameters.AddWithValue("@password", password) ' These parameters must be in the same order as they appear in sql
                command.Connection = connection
                connection.Open()

                Using reader As OleDbDataReader = command.ExecuteReader() ' Get the data returned by executing the sql command created above
                    If reader.Read() Then
                        Return True ' If we were able to read a record, then the user with the specified password exists
                    Else
                        Return False ' If we didn't get any records, this is not a valid user and/or password
                    End If
                End Using
            End Using
        End Using
    End Function
End Class
