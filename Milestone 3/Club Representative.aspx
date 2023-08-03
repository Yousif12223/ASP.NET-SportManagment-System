<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Club Representative.aspx.cs" Inherits="Milestone3.Club_Representative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 502px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Clubrepresentative Name:<asp:TextBox ID="clubrepname" runat="server"></asp:TextBox>
        <asp:Button ID="clubinfo" runat="server" Height="63px" Text="View Club INFO" Width="135px" OnClick="clubinfo_Click" style="margin-left: 12px" />
        &nbsp; ClubName:<asp:TextBox ID="upcomingmatches" runat="server" style="margin-left: 16px" Width="165px"></asp:TextBox>
        <asp:Button ID="viewmatches" runat="server" Height="63px" style="margin-left: 24px" Text="View Upcoming Matches" Width="196px" OnClick="viewmatches_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp; DATETIME in form<asp:TextBox ID="dateandtime" runat="server" style="margin-left: 40px" ></asp:TextBox>
        <asp:Button ID="viewstadiums" runat="server" Height="65px" style="margin-left: 25px" Text="View Available Stadiums" Width="224px" OnClick="viewstadiums_Click" />
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
        </asp:GridView>
        Club Name:<asp:TextBox ID="hostclubname" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp; Stadium Name:<asp:TextBox ID="hoststadiumname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Match DateTime:<asp:TextBox ID="hostdatetime" runat="server"></asp:TextBox>
&nbsp;<asp:GridView ID="GridView2" runat="server" Height="137px" style="margin-left: 428px; margin-top: 0px" Width="449px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        </asp:GridView>
        <asp:GridView ID="GridView3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
        </asp:GridView>
        <asp:Button ID="hostrequest" runat="server" Height="122px" style="margin-left: 1161px; margin-top: 0px;" Text="Host Request" Width="286px" OnClick="hostrequest_Click" />
    </form>
</body>
</html>
