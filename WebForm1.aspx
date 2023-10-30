<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ControlsDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat ="server" />
            <asp:Button ID="Button1" runat ="server" Text="Click Me" OnClick="Button1_Click"/>
            <br/>
            <input type="text" name="TextBox2" />
            <input type="submit" name="submit1"  value="Click Me"/>
        </div>
    </form>
</body>
</html>
