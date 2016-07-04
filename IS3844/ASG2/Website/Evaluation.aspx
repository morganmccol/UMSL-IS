<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Evaluation.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Evaluation" runat="server">
    <div>
    
        <asp:Label ID="Label3" runat="server" Font-Bold="True" 
            Text="Evaluation for " Font-Names="Segoe UI Light" 
            Font-Size="XX-Large" ForeColor="#009999"></asp:Label>
        <asp:Label ID="teamLabel" runat="server" Font-Bold="True" 
            Font-Names="Segoe UI Light" Font-Size="XX-Large" ForeColor="#009999" 
            Text="TEAMNAME"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" 
            Text="PLEASE SELECT YOUR ANSWERS BELOW" Font-Names="Segoe UI Light" 
            Font-Size="Small" ForeColor="#990033"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Q1Text" runat="server" Text="Question 1: Technicality" 
            Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="#006666"></asp:Label>
        <br />
        <asp:RadioButtonList ID="Q1" runat="server" 
            RepeatDirection="Horizontal" Font-Bold="True" Font-Names="Segoe UI" 
            Font-Size="Small" ForeColor="#990033" onselectedindexchanged= "Q1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Q2Text" runat="server" Text="Question 2: Usefulness" 
            Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="#006666"></asp:Label>
        <br />
        <asp:RadioButtonList ID="Q2" runat="server" 
            RepeatDirection="Horizontal" Font-Bold="True" Font-Names="Segoe UI" 
            Font-Size="Small" ForeColor="#990033" onselectedindexchanged= "Q2_SelectedIndexChanged" AutoPostBack="true" style="height: 26px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Q3Text" runat="server" Text="Question 3: Clarity" 
            Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="#006666"></asp:Label>
        <br />
        <asp:RadioButtonList ID="Q3" runat="server" 
            RepeatDirection="Horizontal" Font-Bold="True" Font-Names="Segoe UI" 
            Font-Size="Small" ForeColor="#990033" onselectedindexchanged=" Q3_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Q4Text" runat="server" Text="Question 4: Overall" 
            Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="#006666"></asp:Label>
        <br />
        <asp:RadioButtonList ID="Q4" runat="server" 
            RepeatDirection="Horizontal" Font-Bold="True" Font-Names="Segoe UI" 
            Font-Size="Small" ForeColor="#990033" onselectedindexchanged= "Q4_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:RadioButtonList>
        <br />
&nbsp;<asp:Label ID="avgLabel" runat="server" Text="Average:" Font-Bold="False" Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="#006666"></asp:Label>
&nbsp;<br />
        <asp:TextBox ID="avgBox" runat="server" Height="23px" Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="#990033" Width="78px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Q5Text" runat="server" Text="Comments: Member Names" Font-Names="Segoe UI Light" 
            Font-Size="Small" ForeColor="#006666"></asp:Label>
        <br />
        <asp:TextBox ID="COMMENTS" runat="server" Height="101px" TextMode="MultiLine" 
            Width="210px" Font-Names="Segoe UI Light" Font-Size="Small" ForeColor="#990033"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Label"></asp:Label>
        <asp:Button ID="submitBtn" runat="server" Text="Submit" BackColor="#990033" 
            BorderColor="#660033" BorderStyle="Solid" Font-Bold="True" 
            Font-Names="Segoe UI" Font-Size="Small" ForeColor="White" />
        <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Lab"></asp:Label>
        <asp:Button ID="clearBtn" runat="server" Text="Clear" BackColor="#009999" 
            BorderColor="#006666" BorderStyle="Solid" Font-Bold="True" 
            Font-Names="Segoe UI" Font-Size="Small" ForeColor="White" Width="66px" />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" Font-Bold="False" 
            Font-Names="Segoe UI Light" Font-Size="Medium" ForeColor="Black" 
            NavigateUrl="~/Default.aspx">Return home</asp:HyperLink>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
