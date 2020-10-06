<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update Product Type.aspx.cs" Inherits="TokopediaMain.View.UpdateType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE123213" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="UPDATE PRODUCT TYPE"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
    
        <asp:Label ID="txtData" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Masukkan Nama Tipe Product yang baru :<br />
        <asp:TextBox ID="txtProductTypeName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtProductTypeName" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression = "^[\s\S]{5,}$" runat="server" ControlToValidate="txtProductTypeName" ErrorMessage="*minimal 5 huruf"></asp:RegularExpressionValidator>
        &nbsp;<br />
        <br />
        Masukkan Description yang baru :<br />
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDescription" ErrorMessage="harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="UpdateButton_Click" Text="Update" />
    
    </div>
    </form>
</body>
</html>
