<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert Product.aspx.cs" Inherits="TokopediaMain.View.Insert_Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="INSERT PRODUCT"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
    
        Name<br />
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProductName" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        Stock<br />
        <asp:TextBox ID="txtProductStock" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtProductStock" ErrorMessage="Must at least 1 item." MaximumValue="99999" MinimumValue="1"></asp:RangeValidator>
        <br />
        <br />
        Price<br />
        <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="DropListType" runat="server" OnSelectedIndexChanged="DropListType_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropListType" ErrorMessage="Pilih salah satu!"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="InputData_Click" Text="Input Data" />
    
    </div>
    </form>
</body>
</html>
