<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDesign.Master" AutoEventWireup="true" CodeBehind="ChangePassword2.aspx.cs" Inherits="StudentPortal.ChangePassword2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">

    <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="la1" runat="server" Text="UserID"></asp:Label>
        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbox1" runat="server" Height="38px" Style="margin-left: 19px" Width="201px"></asp:TextBox>
        <br />
        <br />
    </div>
    <div class="auto-style1">
        &nbsp;<asp:Label ID="l2" runat="server" Text="Old PassWord"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="Tbox2" runat="server" Height="38px" Style="margin-left: 14px" Width="201px"></asp:TextBox>
        <br />
        <br />
        <br />
    </div>
    <div class="auto-style1">
        &nbsp;<asp:Label ID="l3" runat="server" Text="New Password"></asp:Label>
        &nbsp;<asp:TextBox ID="Tbox3" runat="server" Height="38px" Style="margin-left: 26px" Width="201px"></asp:TextBox>
        <br />
        <br />
    </div>
    <div class="auto-style1">
        <asp:Label ID="l4" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="Tbox4" runat="server" Height="38px" Style="margin-left: 17px" Width="201px"></asp:TextBox>
        <br />
    </div>
    <div></div>
    <br />
    <asp:Button CssClass="button2" ID="Bttn1" Text="Update" runat="server" Height="28px" OnClick="Bttn1_Click" Width="66px"></asp:Button>

    <asp:Label ID="Message" runat="server" />


</asp:Content>
