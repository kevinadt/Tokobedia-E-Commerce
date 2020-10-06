<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="TokopediaMain.View.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="txtWelcome" runat="server" Text="Welcome" Font-Bold="False" Font-Italic="True" Font-Size="XX-Large"></asp:Label>
        ,&nbsp;
        <asp:Label ID="txtName" runat="server" Text="Label" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
        <br />
        <br />
        <asp:Label ID="txtWelcome0" runat="server" Text="My Profile" Font-Bold="False" Font-Italic="False" Font-Names="Britannic Bold" Font-Size="Larger"></asp:Label>
        <br />
        <br />
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:Label ID="txtNameProfile" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Your Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; : <asp:Label ID="txtEmail" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Your Gender&nbsp;&nbsp;&nbsp; :
        <asp:Label ID="txtGender" runat="server" Text="Label"></asp:Label>
    
        <br />
        <br />
        your current userid :
        <asp:Label ID="txtProfileID" runat="server" Text="Label"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Clicked" Text="Update Profile" />
    
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="changeButton_Click" Text="Change Password" />
    
    </div>
    </form>
</body>
</html>
