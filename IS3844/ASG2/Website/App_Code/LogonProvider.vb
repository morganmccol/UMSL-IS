Imports Microsoft.VisualBasic
Imports System.Web.Security.MembershipProvider
Imports System.Data.OleDb

Public MustInherit Class LogonProvider
    Inherits System.Web.Security.MembershipProvider

    Public Overrides Property ApplicationName As String

        Get
            Return "EvaluationWebApp"
        End Get
        Set(ByVal value As String)

        End Set
    End Property

End Class
