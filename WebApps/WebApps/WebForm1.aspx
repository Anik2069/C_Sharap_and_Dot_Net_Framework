<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApps.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 69px;
        }
        .auto-style2 {
            margin-left: 33px;
        }
        .auto-style3 {
            margin-left: 12px;
        }
        .auto-style4 {
            margin-left: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="l1" runat="server" Text="Name" />
            <asp:TextBOX ID="T1" runat="server" CssClass="auto-style2" />
                
        </div>
         <div>
            <asp:Label ID="Label1" runat="server" Text="Password" />
            <asp:TextBOX ID="TextBOX1" runat="server" CssClass="auto-style3" />
                
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password" />
            <asp:dropdownlist ID="d1" runat="server" CssClass="auto-style4" />
                
        </div>
        <div>
            <asp:button ID="btn" runat="server" Text="Submit" CssClass="auto-style1" OnClick="btn_Click" />
           </div> 
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
