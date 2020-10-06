<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View User.aspx.cs" Inherits="TokopediaMain.View.View_User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE123213" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="VIEW USER"></asp:Label>
        <br />
    
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
    
        <asp:Table ID="UserList" runat="server">
            <asp:TableHeaderRow>
                    <asp:TableHeaderCell>User ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>User Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>User Email</asp:TableHeaderCell>
                    <asp:TableHeaderCell>User Role</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Status</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Update by Role ID</asp:TableHeaderCell>
                </asp:TableHeaderRow>
        </asp:Table>

        <br />
        <br />
        USER ID<br />
        <asp:TextBox ID="txtUserId" runat="server" ReadOnly="True">null</asp:TextBox>
        <br />
        <br />
        USER ROLE<br />
        <asp:TextBox ID="txtUserRole" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtUserRole" ErrorMessage="input angka sesuai format" MaximumValue="2" MinimumValue="1"></asp:RangeValidator>
        <br />
        Keterangan<br />
        1 : Admin<br />
        2 : User<br />
        <br />
        <br />
        USER STATUS<asp:RadioButtonList ID="txtStatus" runat="server">
            <asp:ListItem>Active</asp:ListItem>
            <asp:ListItem>Blocked</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Clicked" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="Delete_Clicked" />

    </div>
    </form>
</body>
</html>
