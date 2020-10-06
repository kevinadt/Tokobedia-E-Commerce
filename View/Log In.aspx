<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log In.aspx.cs" Inherits="TokopediaMain.View.Log_In" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="LOG IN"></asp:Label>
        <br />
        <br />
        Email<br />
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="btnRememberMe" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="remember me" />
        <br />
        <br />
        <asp:Label ID="alert" runat="server" ForeColor="#CC0000" Text="Wrong Email / Password"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="btnLogIn_Click" Text="Log In" />
        <br />
        <br />
        not registered yet? <asp:Button ID="Button2" runat="server" OnClick="btnRegister_Click" Text="REGISTER" />
    
    </div>
    </form>
</body>
</html>
