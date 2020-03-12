<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forget.aspx.cs" Inherits="StudentPortal.Forget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forget Password</title>
    <style type="text/css">
        h1 {
            background-color: black;
            color: white;
            text-align: center;
            height: 40px;
            width: 1403px;
            margin-bottom: 0px;
            margin-top: 0px;
        }

        .auto-style1 {
            width: 615px;
            height: 184px;
            margin-left: 323px;
            align-content: center;
        }
        .auto-style2 {
            margin-left: 9px;
        }
        .auto-style3 {
            margin-left: 588px;
        }
    </style>


</head>
<body>
    <h1>DIU Portal</h1>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td></td>
                    <td>
                          <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 20px">
            <asp:ListItem>Student</asp:ListItem>
            <asp:ListItem>Teacher</asp:ListItem>
            <asp:ListItem>Adminstration</asp:ListItem>
        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="l1" Text="UserID:" runat="server" />
                    </td>
                    <td>
                        <asp:TextBox ID="Byn1" runat="server" OnTextChanged="Byn1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btn1" Text="Submit" runat="server" OnClick="btn1_Click"></asp:Button>
                    </td>
                </tr>
                  <tr>
                    <td>
                        <asp:Label ID="Label2" Text="User Name" runat="server"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>

                
                <tr>
                    <td>
                        <asp:Label ID="Label1" Text="New Password" runat="server"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lb1" Text="Confirm Password" runat="server"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        </td>
                    <td>
                         <asp:Button ID="Button2" Text="Save" runat="server" OnClick="btn2_Click" CssClass="auto-style2" Width="57px"></asp:Button>
                        </td>
                    </tr>
            </table>
        <asp:label ID="Label3" runat="server" />
            </div>
        <div>
            <asp:button ID="Btn2" Text="Return To Home" runat="server" CssClass="auto-style3" OnClick="Btn2_Click1" />
            </div>
    </form>
</body>
</html>
