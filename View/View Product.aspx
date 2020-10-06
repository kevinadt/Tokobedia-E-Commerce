<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View Product.aspx.cs" Inherits="TokopediaMain.View.View_Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE123213" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="VIEW PRODUCT"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
    
        <asp:Button ID="btnInsert" runat="server" OnClick="InsertProduct_Click" Text="Insert Product" />
    
        <br />
        
        <asp:Table ID="ProductList" runat="server">
            <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Product ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Stock</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Type</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Price</asp:TableHeaderCell>
                </asp:TableHeaderRow>
        </asp:Table>

        <br />
        <br />
        
        <asp:Table ID="AdminTable" runat="server" Width="259px">
            <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Update ID ke: </asp:TableHeaderCell>
                    <asp:TableHeaderCell>Delete ID ke: </asp:TableHeaderCell>
                </asp:TableHeaderRow>
        </asp:Table>

    </div>
    </form>
</body>
</html>
