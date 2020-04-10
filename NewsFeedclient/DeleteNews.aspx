<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteNews.aspx.cs" Inherits="NewsFeedclient.DeleteNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 132px;
            height: 61px;
        }
        .auto-style3 {
            height: 61px;
        }
        .auto-style4 {
            height: 114px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="dlt" runat="server" Text="Delete News"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;News ID :&nbsp;</td>
                    <td class="auto-style3">&nbsp;&nbsp;<asp:TextBox ID="TextBox" runat="server" Width="427px"></asp:TextBox>
&nbsp;&nbsp;
                        <asp:Button ID="dltbtn" runat="server" OnClick="dltbtn_Click" Text="Delete" Width="121px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">&nbsp;&nbsp;<br />
&nbsp;
                        <asp:Label ID="deletelabel" runat="server"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:GridView ID="newsgrid" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Font-Size="Small" ForeColor="Black" GridLines="Vertical">
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
