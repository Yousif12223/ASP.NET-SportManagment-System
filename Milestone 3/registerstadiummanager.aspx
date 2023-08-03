<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerstadiummanager.aspx.cs" Inherits="Milestone3.registerstadiummanager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             UserName:<asp:TextBox ID="smusername" runat="server"></asp:TextBox>
             
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
            Password:<asp:TextBox ID="smpassword" runat="server" Width="169px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Name:<asp:TextBox ID="smname" runat="server" Width="187px"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Stadium Name:<asp:TextBox ID="Stadiumname" runat="server"></asp:TextBox>

            <asp:Button ID="smcreate" runat="server" style="margin-left: 74px" Text="Create" OnClick="create_Click" />
            <asp:Button ID="smreturnback" runat="server" style="margin-left: 51px" Text="Return Back" OnClick="returnbackcr_Click" />

        </div>
    </form>
</body>
</html>
