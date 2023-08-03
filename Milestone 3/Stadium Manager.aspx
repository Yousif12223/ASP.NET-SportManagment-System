<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stadium Manager.aspx.cs" Inherits="Milestone3.Stadium_Manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 235px">
    <form id="form1" runat="server">
        <div>
            Stadium Name You are managing:<asp:TextBox ID="stadiumname" runat="server"></asp:TextBox>
            <asp:Button ID="stadiuminfo" runat="server" Text="View Stadium INFO" style="margin-left: 18px" OnClick="stadiuminfo_Click" />
            <br />
            <br />
            <asp:Button ID="allrequest" runat="server" Text="View All Requests" OnClick="allrequest_Click" />
            <br />
            <br />
            <br />
            Stadium Manager Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp; Host Club Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; Guest Club Name:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp; StartTime:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="accept" runat="server" Text="Accept Request" style="margin-left: 21px" OnClick="acceptbutton" />
            <br />
            <br />
            --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------<br />
            Stadium Manager Name:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp; Host Club Name:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp; Guest Club Name:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;&nbsp; StartTime:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:Button ID="reject" runat="server" Text="Reject Request" OnClick="rejectbutton" style="margin-left: 25px" />
            <br />
            <br />
            <br />
            <asp:GridView ID="Gridstadiuminfo" runat="server" OnSelectedIndexChanged="Gridstadiuminfo_SelectedIndexChanged">
            </asp:GridView>
            <asp:GridView ID="Gridallrequests" runat="server" OnSelectedIndexChanged="Gridallrequests_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
