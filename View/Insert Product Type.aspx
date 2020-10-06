<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert Product Type.aspx.cs" Inherits="TokopediaMain.View.Insert_Product_Type" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="INSERT PRODUCT TYPE"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
    
        Product Type<br />
        <asp:TextBox ID="txtProductType" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtProductType" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationExpression = "^[\s\S]{5,}$" runat="server" ControlToValidate="txtProductType" ErrorMessage="*minimal 5 huruf"></asp:RegularExpressionValidator>
        <br />
        <br />
        Description<br />
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescription" ErrorMessage="tidak boleh kosong"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnInput" runat="server" OnClick="InputData_Click" Text="Input Data" />
    
    </div>
    </form>
</body>
</html>
