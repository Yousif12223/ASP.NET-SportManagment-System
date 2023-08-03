<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="System Admin.aspx.cs" Inherits="Milestone3.System_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 327px;
        }
    </style>
</head>
<body style="height: 345px">
    <form id="form1" runat="server">
        <div>
            Club name :<asp:TextBox ID="cname" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ClubLocation:<asp:TextBox ID="clocation" runat="server"></asp:TextBox>
            <asp:Button ID="addclub" runat="server" Text="ADD CLUB" Height="27px" OnClick="addclub_Click" />
        </div>
        <p>
&nbsp;DClubname:<asp:TextBox ID="dclub" runat="server"></asp:TextBox>
            <asp:Button ID="delete" runat="server" Text="DeleteClub" OnClick="delete_Click" />
        </p>
        NewStadiumName:<asp:TextBox ID="sname" runat="server"></asp:TextBox>
    &nbsp;&nbsp; StadiumLocation:<asp:TextBox ID="stadlocation" runat="server"></asp:TextBox>
    &nbsp; StadiumCapacity:<asp:TextBox ID="capacity" runat="server"></asp:TextBox>
        <asp:Button ID="addstadium" runat="server" Text="ADD STADIUM" OnClick="addstadium_Click" />
        <br />
        <br />
        <br />
        DStadiumName:<asp:TextBox ID="dstadium" runat="server"></asp:TextBox>
        <asp:Button ID="deletestad" runat="server" Text="DeleteStadium" OnClick="deletestad_Click" />
        <br />
        <br />
        <br />
        National ID:<asp:TextBox ID="nationalid" runat="server"></asp:TextBox>
        <asp:Button ID="blockfan" runat="server" Text="Block" OnClick="blockfan_Click" />
    </form>
</body>
</html>
