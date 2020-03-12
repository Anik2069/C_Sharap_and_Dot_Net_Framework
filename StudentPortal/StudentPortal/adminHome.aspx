<%@ Page Title="" Language="C#" MasterPageFile="~/Admin2.Master" AutoEventWireup="true" CodeBehind="adminHome.aspx.cs" Inherits="StudentPortal.adminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">


    <div runat="server">
       Log in time: <%= DateTime.Now.TimeOfDay %> 
    </div>

</asp:Content>
