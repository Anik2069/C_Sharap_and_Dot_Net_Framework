<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" AutoEventWireup="true" CodeBehind="Enrollstudent.aspx.cs" Inherits="StudentPortal.Enrollstudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
      <div style="height: 313px; width: 1002px">
   
     <img src="Capture.PNG" alt="DIu" style="margin-left: 32px; float: left; height: 185px; width: 348px; text-align: center;" />
<table style="width: 546px;text-align:center;">
    <tr>
    <td>
        <asp:Label ID="ll1" Text="Application ID:" runat="server"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="tb11" runat="server" Height="22px" style="margin-left: 0px" Width="175px"></asp:TextBox>
        </td>
        </tr>
      <tr>
    <td>
        <asp:Label ID="Ll2" Text="Name:" runat="server"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="Tb12" runat="server" Height="22px" style="margin-left: 0px" Width="175px" OnTextChanged="Tb12_TextChanged"></asp:TextBox>
        </td>
        </tr>
      <tr>
    <td>
        <asp:Label ID="Ll3" Text="Department:" runat="server"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="TextBox2" runat="server" Height="22px" style="margin-left: 0px" Width="175px"></asp:TextBox>
   
        </tr>
      <tr>
    <td>
        <asp:Label ID="Label3" Text="HomeTown:" runat="server"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="TextBox3" runat="server" Height="22px" style="margin-left: 0px" Width="175px"></asp:TextBox>
        </td>
        </tr>
      <tr>
    <td>
        <asp:Label ID="Label4" Text="Religion:" runat="server"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="TextBox4" runat="server" Height="22px" style="margin-left: 0px" Width="175px"></asp:TextBox>
        </td>
          <asp:Image ID="Image1" runat="server" />
        </tr>
      <tr>
    <td>
        <asp:Label ID="Label5" Text="Student ID:" runat="server"></asp:Label>
        </td>
         <td>
        <asp:TextBox ID="TextBox5" runat="server" Height="22px" style="margin-left: 0px" Width="175px"></asp:TextBox>
        </td>
        </tr>
      <tr>
    <td>
        PassWord</td>
         <td>
        <asp:TextBox ID="TextBox6" runat="server" Height="22px" style="margin-left: 0px" Width="175px"></asp:TextBox>
        </td>
          


        </tr>
    <tr>
        <td>
       
            </td>
        <td>
             <asp:Button ID="Buttonsubmit1" Text="Update" runat="server"></asp:Button>
        <asp:Button ID="Buttonsubmit2" Text="Save" runat="server" OnClick="Buttonsubmit2_Click"></asp:Button>
        </td>
            </tr>
</table>
    &nbsp;</div>



</asp:Content>
