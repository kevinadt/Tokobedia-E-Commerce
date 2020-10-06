<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TokopediaMain.View.Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" Text="TokoBeDia"></asp:Label>
        <br />
        <br />
    
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Welcome, "></asp:Label>
        <asp:Label ID="userNameLbl" runat="server" Text="guest"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnViewProduct" runat="server" Text="View Product" OnClick="ViewProduct_Clicked" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogIn" runat="server" OnClick="btnLogIn_Click" Text="Log In" Width="68px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnViewProfile" runat="server" Text="View Profile" Width="130px" OnClick="Profile_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="Log Out" Width="84px" />
        <br />
        <br />
        <asp:Button ID="btnViewUser" runat="server" Text="View User" OnClick="ViewUser_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnInsertProduct" runat="server" Text="Insert Product" OnClick="btnInsertProduct_click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateProduct" runat="server" Text="Update Product" OnClick="updateProduct_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnViewProductType" runat="server" Text="View Product Type" OnClick="ViewProductType_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnInsertProductType" runat="server" Text="Insert Product Type" OnClick="InsertProductType_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateProductType" runat="server" Text="Update Product Type" OnClick="btnUpdate_Click" />

        <br />
        <br />

        <asp:Table ID="ProductList" runat="server">
            <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Product Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Stock</asp:TableHeaderCell>
                </asp:TableHeaderRow>
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
