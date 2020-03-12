<%@ Page Title="" Language="C#" MasterPageFile="~/TeacherDesign.Master" AutoEventWireup="true" CodeBehind="CourseAssign.aspx.cs" Inherits="StudentPortal.CourseAssign" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 611px;
            height: 140px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMainContent" runat="server">
    <div style="height: 313px; width: 1002px">


        <table style="text-align: center;" class="auto-style1">
             <tr>
                <td>
                    <asp:Label ID="Label2" Text="Student ID" runat="server" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="165px" />
                </td>
                  <td>
                    <asp:Button ID="Btn1" runat="server" Text="Search" OnClick="Btn1_Click" style="height: 26px" />
                </td>
            </tr>
             <tr>
                <td>
                    Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="160px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lll1" Text="Select Semester" runat="server" />
                </td>
                <td>
                    <asp:DropDownlist ID="Label1" runat="server" >
                        <asp:ListItem >Semester 1</asp:ListItem>
                        <asp:ListItem>Semester 2</asp:ListItem>
                        <asp:ListItem>Semester 3</asp:ListItem>
                        <asp:ListItem>Semester 4</asp:ListItem>
                        <asp:ListItem>Semester 5</asp:ListItem>
                        <asp:ListItem>Semester 6</asp:ListItem>
                        <asp:ListItem>Semester 7</asp:ListItem>
                        <asp:ListItem>Semester 8</asp:ListItem>
                        <asp:ListItem>Semester 9</asp:ListItem>
                        <asp:ListItem>Semester 10</asp:ListItem>
                        <asp:ListItem>Semester 11</asp:ListItem>
                        <asp:ListItem>Semester 12</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Button ID="btn" Text="Assign" runat="server" OnClick="btn_Click" style="height: 26px" />
                </td>
            </tr>

        </table>
    </div>
</asp:Content>
