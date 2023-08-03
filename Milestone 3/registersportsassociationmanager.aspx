<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registersportsassociationmanager.aspx.cs" Inherits="Milestone3.registersportsassociationmanager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 214px">
            UserName:<asp:TextBox ID="samusername" runat="server"></asp:TextBox>
             
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
            Password:<asp:TextBox ID="sampassword" runat="server" Width="169px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp; Name:<asp:TextBox ID="samname" runat="server"></asp:TextBox>
            <asp:Button ID="create" runat="server" style="margin-left: 55px" Text="Create" Width="137px" OnClick="create_Click" />
            <asp:Button ID="Button1" runat="server" style="margin-left: 61px" Text="Return Back" Width="141px" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
