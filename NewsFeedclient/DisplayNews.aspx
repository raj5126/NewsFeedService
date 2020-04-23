<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayNews.aspx.cs" Inherits="NewsFeedclient.DisplayNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 115px">
    <form id="form1" runat="server">
        <asp:Label ID="newstitle" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" Font-Underline="True" Text="All News"></asp:Label>
        <br />
        <br />
         <asp:Label ID="Label1" runat="server" Text="Filter : "></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="46px" Width="476px">
                <asp:ListItem>Business</asp:ListItem>
                <asp:ListItem>Technology</asp:ListItem>
                <asp:ListItem>Sports</asp:ListItem>
                <asp:ListItem>Celebrity</asp:ListItem>
                <asp:ListItem>Science</asp:ListItem>
                <asp:ListItem>Entertaiment</asp:ListItem>
                <asp:ListItem>Style</asp:ListItem>
                <asp:ListItem>Food</asp:ListItem>
                <asp:ListItem>Travel</asp:ListItem>
                <asp:ListItem>other</asp:ListItem>
                <asp:ListItem>All</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="29px" Text="OK" Width="127px" OnClick="Button1_Click" />
            <br />
        <br />
        <asp:Panel ID="newspanel" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </asp:Panel>
    </form>
</body>
</html>
