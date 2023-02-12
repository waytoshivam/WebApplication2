<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 975px">
            <asp:Label ID="Label1" runat="server" BackColor="#99FF33" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" BackColor="#99FF33" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" BackColor="#99FF33" Text="Label"></asp:Label>
            <br />
            <br />
            Enter First Number<br />
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 288px; margin-top: 0px" Width="524px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            Enter Second Number<br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="855px"></asp:TextBox>
            <br />
            <br />
            result<br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="sum" />
            <asp:Button ID="Button2" runat="server" Text="mul" />
            <asp:Button ID="Button3" runat="server" Text="div" />
        </div>
    </form>
</body>
</html>
