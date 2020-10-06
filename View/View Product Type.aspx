<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View Product Type.aspx.cs" Inherits="TokopediaMain.View.View_Product_Type" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE123213" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="VIEW PRODUCT TYPE"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
        <asp:Button ID="btnInsertProductType0" runat="server" OnClick="InsertProductType_Click" Text="Insert Product Type" />


        <br />
        <br />
    
        <asp:Table ID="ProductList" runat="server">
            <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Product Type ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Type</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Description</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Update ID ke: </asp:TableHeaderCell>
                    <asp:TableHeaderCell>Delete ID ke: </asp:TableHeaderCell>
                </asp:TableHeaderRow>
        </asp:Table>


        <br />


    </div>
    </form>
</body>
</html>
