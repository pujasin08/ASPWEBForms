<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="ASPWEBForms.Email" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#003366" Text="Attach File"></asp:Label>
        </div>
        <p>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="To Email"></asp:Label>
            <asp:TextBox ID="ToEmail" runat="server" Height="16px" Width="157px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="#CC3300" Font-Size="Medium" ForeColor="White" OnClick="Button1_Click" Text="Send" />
        </p>
    </form>
</body>
</html>
