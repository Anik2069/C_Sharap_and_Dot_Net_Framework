<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="StudentPortal.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">

       <div>
          <asp:TextBox ID="tbxID" runat="server" Height="76px" style="margin-left: 283px" Width="210px" ReadOnly="True" OnTextChanged="tbxID_TextChanged"></asp:TextBox>
          <asp:TextBox ID="TextBox1" runat="server" Height="76px" style="margin-left: 45px" Width="210px" ReadOnly="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
          <asp:TextBox ID="TextBox2" runat="server" Height="76px" style="margin-left: 38px" Width="210px" ReadOnly="True"></asp:TextBox>
        </div>
    <div>
        <asp:Label ID="TextBox3" runat="server" Text="Total Payable" style="margin-left: 350px"></asp:Label>
         <asp:Label ID="Label1" runat="server" Text="Total Due" style="margin-left: 166px"></asp:Label>
         <asp:Label ID="Label2" runat="server" Text="Total Paid" style="margin-left: 148px"></asp:Label>
                             

        
        </div>

</asp:Content>
