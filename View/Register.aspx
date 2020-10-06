<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TokopediaMain.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="UPDATE" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="REGISTER"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
    
    </div>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        Name<br />
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="Nama harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password harus diisi"></asp:RequiredFieldValidator>
        <br />
        <br />
        Confirm Password<br />
        <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Konfirmasi password anda"></asp:RequiredFieldValidator>
        <br />
        <br />
        Gender<br />
        <asp:RadioButtonList ID="txtGender" runat="server" OnSelectedIndexChanged="txtGender_SelectedIndexChanged">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtGender" ErrorMessage="Pilih salah satu gender anda."></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="btnRegister_Clicked" Text="Register" />
    </form>
</body>
</html>
