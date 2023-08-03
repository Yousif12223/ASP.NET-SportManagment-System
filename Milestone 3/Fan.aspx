<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fan.aspx.cs" Inherits="Milestone3.Fan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 492px">
            DateTime of Upcoming Matches:&nbsp; <asp:TextBox ID="upcoming" runat="server"></asp:TextBox>
            <asp:Button ID="viewmatchesbutton" runat="server" Height="119px" style="margin-left: 124px" Text="View Matches" Width="466px" OnClick="viewmatches" />
            <br />
            <br />
            <br />
            <br />
            Nationl ID:<asp:TextBox ID="fannational" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Host Club:<asp:TextBox ID="fanhost" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; Guest Club:<asp:TextBox ID="fanguest" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp; DateTime:<asp:TextBox ID="datetimee" runat="server" ></asp:TextBox>
            <asp:Button ID="purchase" runat="server" Text="Purchase" Height="36px" style="margin-left: 61px" Width="181px" OnClick="purchase_Click" />
            <asp:GridView ID="GridView1forupcomingmatches" runat="server" Height="209px" Width="284px" OnSelectedIndexChanged="GridView1forupcomingmatches_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
