<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDesign.Master" AutoEventWireup="true" CodeBehind="AssignResult.aspx.cs" Inherits="StudentPortal.AssignResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 408px;
            height: 208px;
            margin-left: 164px;
        }
        .auto-style3 {
            margin-left: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">

    <table class="auto-style2">
        <tr>
            <td>
                <asp:Label Text="ID" runat="server" ID="Label11" />
            </td>
            <td>
                <asp:TextBox ID="tb1" runat="server" OnTextChanged="tb1_TextChanged" />
            </td>
            <td>
                <asp:Button ID="Search" runat="server" Text="Search" OnClick="Search_Click" />
                </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Name" runat="server" ID="Label1" />
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" ReadOnly="True" />
            </td>
        </tr>

          <tr>
            <td>
                <asp:Label Text="Semester" runat="server" ID="Label2" />
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"  />
            </td>
        </tr>
          <tr>
            <td class="auto-style1">
                <asp:Label Text="Result" runat="server" ID="Label3" />
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBox3" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                <asp:Button ID="btn1" runat="server" Text="Submit" CssClass="auto-style3" OnClick="btn1_Click" />
                </td>
            </tr>
    </table>
    <asp:Label Text="Result" runat="server" ID="Label4" />
</asp:Content>
