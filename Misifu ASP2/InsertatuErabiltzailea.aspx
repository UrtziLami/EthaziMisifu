<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertatuErabiltzailea.aspx.vb" Inherits="Misifu_ASP2.InsertatuErabiltzailea" %>

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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="38pt" Text="INSERTATU ERABILTZAILEA"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="16pt" Text="Erabiltzailea:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="16pt" Text="Pasahitza:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Size="16pt" Text="Pasahitza baieztatu:"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnBueltatu" runat="server" Height="36px" Text="Bueltatu" Width="72px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsertatu" runat="server" Text="Insertatu" Height="37px" Width="101px" />
        </div>
    </form>
</body>
</html>
