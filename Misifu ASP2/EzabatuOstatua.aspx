<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="EzabatuOstatua.aspx.vb" Inherits="Misifu_ASP2.EzabatuOstatua" %>

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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" Text="EZABATU OSTATUA"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <div style="margin-left: 760px">
            <asp:Label ID="lblID" runat="server" Text="Sinadura:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBete" runat="server" Height="29px" Text="Bete" Width="62px" />
            <br />
            <br />
            <asp:Label ID="lblIzena" runat="server" Text="Izena:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxIzena" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDeskrib" runat="server" Text="Deskribapena:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxDeskr" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblUdalerri" runat="server" Text="Udalerri:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxUdalerri" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblProbintzia" runat="server" Text="Probintzia:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxProbint" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxEmail" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblTelef" runat="server" Text="Telefonoa:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxTelef" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblWeb" runat="server" Text="Web:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxWeb" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblWeb0" runat="server" Text="Longitudea:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxLongitudea" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblWeb1" runat="server" Text="Latitudea:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxLatitudea" runat="server" Width="211px" Enabled="False"></asp:TextBox>
            <br />


            <br />


        </div>
        <div align="center">

                <asp:Button ID="btnBueltatu" runat="server" Height="36px" Text="Bueltatu" Width="70px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:Button ID="btnEzabatu" runat="server" Height="36px" Text="Ezabatu" Width="74px" Enabled="False" />

            </div>
    </form>
</body>
</html>
