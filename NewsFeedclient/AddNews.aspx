<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="NewsFeedclient.AddNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 93%;
            height: 110px;
        }
        .auto-style2 {
            height: 39px;
            width: 805px;
        }
        .auto-style3 {
            height: 35px;
            width: 805px;
        }
        .auto-style4 {
            height: 37px;
            width: 805px;
        }
        .auto-style9 {
            height: 163px;
            width: 805px;
        }
        .auto-style10 {
            height: 39px;
            width: 241px;
        }
        .auto-style11 {
            height: 35px;
            width: 241px;
        }
        .auto-style12 {
            height: 37px;
            width: 241px;
        }
        .auto-style13 {
            height: 163px;
            width: 241px;
        }
        .auto-style14 {
            height: 52px;
        }
        .auto-style15 {
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="title" runat="server" Font-Size="Large" Text="Add News"></asp:Label>
            <br />
            <br />
&nbsp;</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style10">&nbsp; News ID&nbsp;</td>
                <td class="auto-style2">
                    <asp:TextBox ID="newsId" runat="server" Width="427px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">&nbsp; Author Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="author" runat="server" Width="427px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp; Title</td>
                <td class="auto-style4">
                    <asp:TextBox ID="ntitle" runat="server" Width="427px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp; Publish Date</td>
                <td class="auto-style4">
                    <asp:TextBox ID="publishdate" runat="server" TextMode="DateTime" Width="427px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp; Content</td>
                <td class="auto-style9">
                    <asp:TextBox ID="content" runat="server" Height="135px" TextMode="MultiLine" Width="427px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="2">
                    <asp:Button ID="add_news" runat="server" CssClass="auto-style15" Height="36px" OnClick="add_news_Click" Text="Add News" Width="121px" />
                    <asp:Label ID="success" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
