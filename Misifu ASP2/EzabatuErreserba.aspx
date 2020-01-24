<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EzabatuErreserba.aspx.vb" Inherits="Misifu_ASP2.EzabatuErreserba" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" Text="EZABATU ERRESERBA"></asp:Label>
        </div>
        <div align="center">

            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Size="16pt" Text="ID:"></asp:Label>
&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBete" runat="server" Height="33px" Text="Bete" Width="57px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="16pt" Text="Alojamendu Izena:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>

            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Size="16pt" Text="Sartu Data:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Font-Size="16pt" Text="Atera Data:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>

        </div>
        <div align="center">

            <br />
            <br />
            <asp:Button ID="btnBueltatu" runat="server" Height="35px" Text="Bueltatu" Width="70px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEzabatu" runat="server" Height="35px" Text="Ezabatu" Width="66px" />

        </div>
    </form>
</body>
</html>
