<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayNews.aspx.cs" Inherits="NewsFeedclient.DisplayNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="newstitle" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" Font-Underline="True" Text="All News"></asp:Label>
        <br />
        <asp:Panel ID="newspanel" runat="server">
            <br />
        </asp:Panel>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
