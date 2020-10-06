<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change Password.aspx.cs" Inherits="TokopediaMain.View.Change_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="UPDATE PASSWORD"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Password Sekarang :"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurrentPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCurrentPassword" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password yang Baru :"></asp:Label>
        <br />
        <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNewPassword" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression = "^[\s\S]{5,}$" runat="server" ControlToValidate="txtNewPassword" ErrorMessage="*minimal 5 huruf"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Konfirmasi Password :"></asp:Label>
        <br />
        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdateClick" Text="Update" />
    
    </div>
    </form>
</body>
</html>
