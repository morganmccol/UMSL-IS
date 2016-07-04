<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Font-Names="Segoe UI Light" 
            Font-Size="X-Large" Text="Congrats you reached the landing page!"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Names="Segoe UI Light" 
            Font-Size="Medium" Text="Would you like to:"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" 
            Font-Names="Segoe UI Light" Font-Size="Medium" ForeColor="#990033" 
            NavigateUrl="~/ViewEvaluations.aspx">View Teams</asp:HyperLink>
&nbsp;<asp:Label ID="Label1" runat="server" Font-Names="Segoe UI Light" 
            Font-Size="Small" Text="OR"></asp:Label>
&nbsp;<asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="True" 
            Font-Names="Segoe UI Light" Font-Size="Medium" ForeColor="#006666" 
            NavigateUrl="~/NewEvaluation.aspx">Edit Teams</asp:HyperLink>
        <br />
    </div>
    </form>
</body>
</html>
