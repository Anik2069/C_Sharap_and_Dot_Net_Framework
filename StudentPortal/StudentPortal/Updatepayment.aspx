<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" AutoEventWireup="true" CodeBehind="Updatepayment.aspx.cs" Inherits="StudentPortal.Updatepayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 63px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <table runat="server">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="l1" Text="ID:" runat="server" />
            </td>
            <td>
                <asp:TextBox ID="lw" runat="server" Height="25px" Style="margin-left: 38px" Width="172px" OnTextChanged="lw_TextChanged" />
            </td>
            <td>
                <asp:Button ID="Bt" runat="server" Text="Search" Height="25px" Style="margin-left: 38px" Width="172px" OnClick="Bt_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td style="text-align: center">
                <asp:Label ID="La1" Text="Name:" runat="server" />
            </td>
            <td>
                <asp:TextBox ID="Tex1" runat="server" Height="25px" Style="margin-left: 38px" Width="172px" OnTextChanged="Tex1_TextChanged" />
            </td>
        </tr>
      <tr>
            <td class="auto-style1"></td>
            <td style="text-align: center">
                <asp:Label ID="el1" Text="Total Payable:" runat="server" />
            </td>
            <td>
                <asp:TextBox ID="ox1" runat="server" Height="25px" Style="margin-left: 38px" Width="172px" />
            </td>
        </tr>
         <tr>
            <td class="auto-style1"></td>
            <td style="text-align: center">
                <asp:Label ID="Lbel1" Text="Total DUE:" runat="server" />
            </td>
            <td>
                <asp:TextBox ID="TxtBx1" runat="server" Height="25px" Style="margin-left: 38px" Width="172px" />
            </td>
        </tr>
         <tr>
            <td class="auto-style1"></td>
            <td style="text-align: center">
                <asp:Label ID="Labe1" Text="Total Paid:" runat="server" />
            </td>
            <td>
                <asp:TextBox ID="TextBo1" runat="server" Height="25px" Style="margin-left: 38px" Width="172px" />
            </td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                </td>
            <td style="text-align:center">
                <asp:button ID="boxx" runat="server" Text="Update" OnClick="boxx_Click" style="height: 26px" />
                </td>
        </tr>
    </table>
</asp:Content>
