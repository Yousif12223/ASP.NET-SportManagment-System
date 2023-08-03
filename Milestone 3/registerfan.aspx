<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerfan.aspx.cs" Inherits="Milestone3.registerfan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            Name:<asp:TextBox ID="fname" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; UserName:<asp:TextBox ID="fusername" runat="server"></asp:TextBox>
&nbsp;&nbsp; Password:<asp:TextBox ID="fpassword" runat="server"></asp:TextBox>
&nbsp;&nbsp; NationalID<asp:TextBox ID="fnational" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            BirthDate:<asp:TextBox ID="fbirthdate" runat="server"></asp:TextBox>
&nbsp;&nbsp; Address:<asp:TextBox ID="faddress" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; PhoneNo:<asp:TextBox ID="fphone" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="fcreate" runat="server" Text="Create" Width="120px" OnClick="fcreate_Click" />
            <asp:Button ID="fback" runat="server" Text="Back" style="margin-left: 117px" Width="173px" OnClick="fback_Click" />
        </div>
    </form>
</body>
</html>
