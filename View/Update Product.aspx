<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update Product.aspx.cs" Inherits="TokopediaMain.View.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE123213" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="UPDATE PRODUCT"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
    
        <asp:Label ID="txtData" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Masukkan Nama Product yang baru :<br />
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProductName" ErrorMessage="harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        Masukkan Stock yang baru :<br />
        <asp:TextBox ID="txtProductStock" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtProductStock" ErrorMessage="minimal 1" MaximumValue="999999" MinimumValue="1"></asp:RangeValidator>
        <br />
        <br />
        Masukkan harga yang baru : <br />
        <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="DropListType" runat="server">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropListType" ErrorMessage="Pilih salah satu!"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="UpdateButton_Click" Text="Update" />
    
    </div>
    </form>
</body>
</html>
