<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ASPWEBForms.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 329px;
        }
    </style>
</head>
<body>
    <a href = "/Email.aspx">Send Email Attachment</a>
    <form id="form1" runat="server">
        <div>
            <div style="font-size:x-large;text-align:center">Student Info Page</div>
            <br />
           
        </div>
        <table style="width: 100%; height: 192px;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtName" runat="server" Height="29px" Width="169px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TBEmail" runat="server" Height="29px" Width="169px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="LblGender" runat="server" Text="Gender"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DpGend" runat="server" Height="29px" Width="169px">
                        <asp:ListItem Selected="True">Choose</asp:ListItem>
                        <asp:ListItem>M</asp:ListItem>
                        <asp:ListItem>F</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" Width="638px">
        </asp:GridView>
        <p>
            &nbsp;</p>
            <asp:Button ID="BtnAdd" runat="server" BackColor="Green" Font-Bold="True" ForeColor="White" Height="49px" Text="Add" Width="152px" OnClick="BtnAdd_Click" />
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" ForeColor="#003366" OnClick="LinkButton1_Click">Export To Excel</asp:LinkButton>
        </p>
       
    </form>
</body>
</html>
