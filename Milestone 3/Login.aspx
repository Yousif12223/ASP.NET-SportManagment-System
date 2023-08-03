<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Milestone3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 367px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Please Sign In<p>
            UserName:</p>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <p>
            Password:</p> 
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="signin" runat="server" OnClick ="login" Text="log in" />
        <br />

        <asp:Label ID="valid" runat="server" Text="Label" Visible="False"></asp:Label>

        <br />
        <br />
        <asp:Button ID="registerassportsassociationmanager" runat="server" Height="74px" Text="Register as Sports Association Manager" Width="306px" OnClick="registerassportsassociationmanager_Click" />

        <asp:Button ID="registerasclubrepresentative" runat="server" Text="register as Club Representative" Height="74px" Width ="298px " style="margin-left: 15px" OnClick="registerasclubrepresentative_Click" />

        <asp:Button ID="registerasstadiummanager" runat="server" Text="Register as Stadium Manager" Height="74px " style="margin-left: 27px" Width="246px" OnClick="registerasstadiummanager_Click" />

        <asp:Button ID="registerasfan" runat="server" Text="Register as Fan" Height ="74px" Width ="250px" style="margin-left: 40px" OnClick="registerasfan_Click" />

    </form>
</body>
</html>
