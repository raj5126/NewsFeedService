<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateNews.aspx.cs" Inherits="NewsFeedclient.UpdateNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 270px;
            height: 208px;
        }
        .auto-style4 {
            width: 270px;
            height: 77px;
        }
        .auto-style6 {
            width: 270px;
            height: 46px;
        }
        .auto-style7 {
            height: 46px;
        }
        .auto-style8 {
            height: 208px;
        }
        .auto-style9 {
            width: 100%;
        }
        .auto-style10 {
            height: 71px;
        }
        .auto-style11 {
            height: 77px;
        }
        .auto-style14 {
            height: 62px;
            width: 160px;
        }
        .auto-style16 {
            height: 62px;
        }
        .auto-style17 {
            height: 44px;
        }
        .auto-style18 {
            margin-left: 51px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="title" runat="server" Font-Size="Larger" Font-Underline="True" Text="Update News"></asp:Label>
            <br />
            <br />
            <br />
            <table style="width:100%;" id="searchpanel" runat="server">
                <tr>
                    <td class="auto-style14">&nbsp; News ID :&nbsp;</td>
                    <td class="auto-style16">
                        <asp:TextBox ID="nid" runat="server" Height="26px" Width="438px"></asp:TextBox>
                        <asp:Button ID="searchbtn" runat="server" CssClass="auto-style18" Height="31px" Text="Search" Width="105px" OnClick="searchbtn_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17" colspan="2">
                        <asp:Label ID="searchmessage" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
        <table class="auto-style9" id="updatepanel" runat="server">
            <tr>
                <td class="auto-style6">&nbsp; News ID&nbsp;:</td>
                <td class="auto-style7">
                    <asp:Label ID="id" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp; News Title :&nbsp;</td>
                <td class="auto-style11">
                    <asp:TextBox ID="ntitle" runat="server" Height="42px" Width="427px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp; News Content : &nbsp;</td>
                <td class="auto-style8">
                    <asp:TextBox ID="ncontent" runat="server" Height="179px" TextMode="MultiLine" Width="427px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">
                    <asp:Button ID="updatebtn" runat="server" Height="38px" OnClick="updatebtn_Click" Text="Update" Width="141px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
