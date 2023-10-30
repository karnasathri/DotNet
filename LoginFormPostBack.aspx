<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginFormPostBack.aspx.cs" Inherits="ControlsDemo.LoginFormPostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption>Login Form</caption>
                <tr>
                    <td>Enter User name:</td>
                    <td><asp:TextBox ID="txtName" runat="server" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Enter Possword:</td>
                    <td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="150px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td align="right"><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
                    <td><asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
