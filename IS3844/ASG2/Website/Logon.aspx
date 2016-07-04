<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Logon.aspx.vb" Inherits="Logon" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Login ID="Login1" runat="server" BackColor="#CCFFFF" BorderColor="#990033" 
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Segoe UI Light" 
            Font-Size="Small" Width="258px" Font-Bold="False" TextLayout="TextOnTop">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="#990033" BorderColor="#CCCCCC" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="White" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#006666" Font-Bold="True" Font-Size="Medium" 
                ForeColor="White" />
        </asp:Login>
    </form>
</body>
</html>
