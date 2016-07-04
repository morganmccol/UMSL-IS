<%@ Page Language="VB" AutoEventWireup="false" CodeFile="NewEvaluation.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="New Evaluation" Font-Bold="True" 
            Font-Names="Segoe UI Light" Font-Size="XX-Large" ForeColor="#990033"></asp:Label>
        <br />
    
        <asp:Label ID="Label2" runat="server" Text="Team Name: " Font-Bold="False" 
            Font-Names="Segoe UI Light" Font-Size="Medium"></asp:Label>
        </div>
        <asp:DropDownList ID="TeamList" runat="server" Font-Names="Segoe UI Light" 
        Font-Size="Small" ForeColor="#006666">
        </asp:DropDownList>
    
        <asp:Label ID="Label3" runat="server" Text="Team" Font-Bold="False" 
        Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="White"></asp:Label>
        <asp:Button ID="NextButton" runat="server" Text="Next" BackColor="#990033" 
        BorderColor="#660033" BorderStyle="Solid" Font-Bold="True" 
        Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="White" Height="23px" 
        Width="53px" />
    
    </form>
</body>
</html>
