<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ControlsDemo.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" BackColor="#FF9900" BorderStyle="Solid" Font-Size="XX-Large" ForeColor="#FF3300" Text="Button" OnClick="Button1_Click" />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        <asp:Button ID="Button3" runat="server" OnCommand="Button3_Command" Text="Button" />
        <div>
        </div>
    </form>
</body>
</html>
