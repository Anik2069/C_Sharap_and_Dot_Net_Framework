<%@ Page Title="Result" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="StudentPortal.result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <div></div>
    <div class="auto-style1">
        <asp:Label ID="Labl1" Text="Select Semester:    " runat="server"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" style="margin-left: 63px" Width="102px">
            <asp:ListItem Value="Semester1">Semester 1</asp:ListItem>
            <asp:ListItem>Semester 2</asp:ListItem>
            <asp:ListItem Value="Semester3">Semester 3</asp:ListItem>
            <asp:ListItem Value="Semester4">Semester 4</asp:ListItem>
            <asp:ListItem Value="Semester5">Semester 5</asp:ListItem>
            <asp:ListItem Value="Semester6">Semester 6</asp:ListItem>
            <asp:ListItem Value="Semester7">Semester 7</asp:ListItem>
            <asp:ListItem Value="Semester8">Semester 8</asp:ListItem>
            <asp:ListItem Value="Semester9">Semester 9</asp:ListItem>
            <asp:ListItem Value="Semester10">Semester 10</asp:ListItem>
            <asp:ListItem Value="Semester11">Semester 11</asp:ListItem>
            <asp:ListItem Value="Semester12">Semester 12</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="auto-style1">
        <br />
    </div>
    <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="l2" Text="Student Id:" runat="server"></asp:Label>
        <asp:TextBox ID="TtBox1" runat="server" Height="23px" Style="margin-left: 45px" Width="204px" OnTextChanged="TtBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
    </div>
       <div>
         <asp:button class="button button2" Text="Submit" runat="server" Height="35px" style="margin-left: 716px" Width="87px" OnClick="Unnamed1_Click"></asp:button>
           <br />
           <br />
           <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Academic Result:<br />
           <br />
           <br />
           <br />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label style="align-content:center" ID="l3" runat="server" />
           <br />
    </div>

</asp:Content>
