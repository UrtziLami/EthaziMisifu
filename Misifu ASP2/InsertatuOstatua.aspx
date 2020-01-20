<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertatuOstatua.aspx.vb" Inherits="Misifu_ASP2.InsertatuOstatua" %>

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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="32pt" Text="INSERTATU OSTATUA"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <div style="margin-left: 760px">
            <asp:Label ID="Label2" runat="server" Text="Izena:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxIzena" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Deskribapena:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxDeskr" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Udalerri:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxUdalerri" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Probintzia:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxProbint" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Email:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxEmail" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Telefonoa:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxTelef" runat="server" Width="211px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Web:" Font-Size="16pt"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxWeb" runat="server" Width="211px"></asp:TextBox>
            <br />

        </div>
            <div align="center">

                <br />
                <br />
                <asp:Button ID="btnBueltatu" runat="server" Height="36px" Text="Bueltatu" Width="69px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnInsertatu" runat="server" Height="36px" Text="Insertatu" Width="74px" />

            </div>
        
    </form>
</body>
</html>
