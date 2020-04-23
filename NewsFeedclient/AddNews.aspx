<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNews.aspx.cs" Inherits="NewsFeedclient.AddNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 93%;
            height: 110px;
        }
        .auto-style9 {
            height: 183px;
            width: 459px;
        }
        .auto-style13 {
            height: 183px;
            width: 241px;
        }
        .auto-style14 {
            height: 76px;
        }
        .auto-style18 {
            height: 64px;
            width: 241px;
        }
        .auto-style19 {
            height: 64px;
            width: 459px;
        }
        .auto-style20 {
            height: 57px;
            width: 241px;
        }
        .auto-style21 {
            height: 57px;
            width: 459px;
        }
        .auto-style22 {
            height: 65px;
            width: 241px;
        }
        .auto-style23 {
            height: 65px;
            width: 459px;
        }
        .auto-style24 {
            height: 59px;
            width: 241px;
        }
        .auto-style25 {
            height: 59px;
            width: 459px;
        }
        .auto-style26 {
            height: 83px;
            width: 241px;
        }
        .auto-style27 {
            height: 83px;
            width: 459px;
        }
        .auto-style28 {
            height: 87px;
            width: 241px;
        }
        .auto-style29 {
            height: 87px;
            width: 459px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="title" runat="server" Font-Size="X-Large" Text="Add News" Font-Bold="True" Font-Italic="True" Font-Underline="True"></asp:Label>
            <br />
            <br />
           
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style18">&nbsp; News ID&nbsp;</td>
                <td class="auto-style19">
                    <asp:TextBox ID="newsId" runat="server" Width="430px" Height="30px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="newsId" CssClass="auto-style1" ErrorMessage="*Required" ForeColor="#FF0066" SetFocusOnError="True" Font-Size="Medium"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">&nbsp; Author Name</td>
                <td class="auto-style21">
                    <asp:TextBox ID="author" runat="server" Width="427px" Height="30px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="author" ErrorMessage="*Required" Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp; Title</td>
                <td class="auto-style23">
                    <asp:TextBox ID="ntitle" runat="server" Width="427px" Height="30px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ntitle" ErrorMessage="*Required" Font-Size="Medium" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">&nbsp; Category&nbsp;</td>
                <td class="auto-style19">
                    <asp:DropDownList ID="categorylist" runat="server" Height="35px" Width="427px">
                        <asp:ListItem>Business</asp:ListItem>
                        <asp:ListItem>Technology</asp:ListItem>
                        <asp:ListItem>Sports</asp:ListItem>
                        <asp:ListItem>Celebrity</asp:ListItem>
                        <asp:ListItem>Science</asp:ListItem>
                        <asp:ListItem>Entertainment</asp:ListItem>
                        <asp:ListItem>Style</asp:ListItem>
                        <asp:ListItem>Food</asp:ListItem>
                        <asp:ListItem>Travel</asp:ListItem>
                        <asp:ListItem>other</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style24">&nbsp; Publish Date</td>
                <td class="auto-style25">
                    <asp:TextBox ID="publishdate" runat="server" TextMode="DateTime" Width="427px" Height="30px"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style26">&nbsp; Image&nbsp;</td>
                <td class="auto-style27">
                    <br />
                    <asp:FileUpload ID="imageUpload" runat="server" Width="427px" Height="35px" />
                    <asp:Label ID="error" runat="server"></asp:Label>
                    <br />
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp; Content</td>
                <td class="auto-style9">
                    <asp:TextBox ID="content" runat="server" Height="135px" TextMode="MultiLine" Width="427px"></asp:TextBox>
                &nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="content" ErrorMessage="*Required" Font-Size="Medium" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp; Video Link</td>
                <td class="auto-style29">
                    <asp:TextBox ID="link" runat="server" Width="427px" Height="30px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="2">
                    <asp:Button ID="add_news" runat="server" CssClass="auto-style20" Height="36px" OnClick="add_news_Click" Text="Add News" Width="121px" BackColor="#33CCCC" />
                    <asp:Label ID="success" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
