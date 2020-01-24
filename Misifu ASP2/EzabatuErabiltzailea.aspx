<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EzabatuErabiltzailea.aspx.vb" Inherits="Misifu_ASP2.EzabatuErabiltzailea" %>

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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="38pt" Text="EZABATU ERABILTZAILEA"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Size="16pt" Text="ID:"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBete" runat="server" Height="31px" Text="Bete" Width="57px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="16pt" Text="Erabiltzailea:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btnBueltatu" runat="server" Height="36px" Text="Bueltatu" Width="72px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEzabatu" runat="server" Text="Ezabatu" Height="37px" Width="101px" Enabled="False" />
        </div>
    </form>
</body>
</html>
