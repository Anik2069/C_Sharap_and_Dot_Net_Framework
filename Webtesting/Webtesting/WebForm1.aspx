<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Webtesting.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
            <td>
                <asp:label ID="abc" runat="server" Text ="Customer:" />
            </td>
                <td>
                    <asp:Textbox id="fff" runat="server" />
                </td>
            </tr>
                      <tr>
            <td>
                <asp:label ID="Label1" runat="server" Text ="Password:" />
            </td>
                <td>
                    <asp:Textbox id="Textbox1" runat="server" />
                </td>
            </tr>
                      <tr>
            <td>
                
            </td>
                <td style="text-align:center">
                    <asp:button ID="btn1" Text="submit" runat="server" OnClick="btn1_Click" />
                </td>
            </tr>
        </table>
        <table>
            </table>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
