<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerclubrepresentative.aspx.cs" Inherits="Milestone3.registerclubrepresentative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            UserName:<asp:TextBox ID="crusername" runat="server"></asp:TextBox>
             
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
            Password:<asp:TextBox ID="crpassword" runat="server" Width="169px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Name:<asp:TextBox ID="crname" runat="server" Width="187px"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CLUB Name:<asp:TextBox ID="clubname" runat="server"></asp:TextBox>

            <asp:Button ID="createcr" runat="server" style="margin-left: 74px" Text="Create" OnClick="create_Click" />
            <asp:Button ID="returnbackcr" runat="server" style="margin-left: 51px" Text="Return Back" OnClick="returnbackcr_Click" />

        </div>
    </form>
</body>
</html>
