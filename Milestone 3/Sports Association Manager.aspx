<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sports Association Manager.aspx.cs" Inherits="Milestone3.Sports_Association_Manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 319px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Host Club Name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label2" runat="server" Text="Guest Club Name:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="StartTime:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="EndTime"></asp:Label>
            :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" style="margin-left: 42px" Text="Add New Match" Width="185px" OnClick="Button1_Click" />
        </div>
        <br />
        <br />
        Delete HostClubName:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;&nbsp; Delete GuestClubName:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Starttime:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;&nbsp; Endtime:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Delete Match" Width="142px" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="neverplayedclubs" runat="server" style="margin-left: 916px" Text="clubsNeverMatched" Width="186px" OnClick="neverplayedclubs_Click" />
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Button ID="upcomingmatches" runat="server" Text="View Upcoming Matches" Width="211px" OnClick="upcoming" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="alreadyplayed" runat="server" style="margin-left: 185px" Text="View Already Played Matches" Width="236px" OnClick="alreadyplayed_Click" />
&nbsp;<asp:GridView ID="gridviewupcoming" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <asp:GridView ID="Gridneverplayed" runat="server" OnSelectedIndexChanged="Gridneverplayed_SelectedIndexChanged">
        </asp:GridView>
        <asp:GridView ID="alreadyplayedgrid" runat="server" OnSelectedIndexChanged="alreadyplayedgrid_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
