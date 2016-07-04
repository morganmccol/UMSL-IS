<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewEvaluations.aspx.vb" Inherits="ViewEvaluations" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="View Evaluations" Font-Bold="True" 
            Font-Names="Segoe UI Light" Font-Size="XX-Large" ForeColor="#009999"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx" 
            Font-Names="Segoe UI Light" Font-Size="Medium" ForeColor="#990033">Back to home page</asp:HyperLink>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Team Name: " 
            Font-Names="Segoe UI Light" Font-Size="Medium" ForeColor="Black"></asp:Label>
        <br />
        <asp:DropDownList ID="TeamList" runat="server" onselectedindexchanged= "TeamList_SelectedIndexChanged" AutoPostBack="true" Font-Names="Segoe UI Light" 
            Font-Size="Small" ForeColor="#990033" style="height: 23px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="teamGrid" runat="server" BackColor="#009999" 
            Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="White" Width="401px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
