<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update Profile.aspx.cs" Inherits="TokopediaMain.View.Update_Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE123213" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="UPDATE PROFILE"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
        Edit Email:<br />
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        Edit Name<br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        Edit Gender<asp:RadioButtonList ID="txtGender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtGender" ErrorMessage="*harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="Update_Clicked" Text="UPDATE" />
        <br />
    
    </div>
    </form>
</body>
</html>
