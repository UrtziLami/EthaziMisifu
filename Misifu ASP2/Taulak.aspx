﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Taulak.aspx.vb" Inherits="Misifu_ASP2.WebForm2" %>

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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="38pt" Text="Aukeratu taula" ForeColor="Black"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Button ID="btnErabiltzaileak" runat="server" Text="Erabiltzaileak" style="margin-left: 0px" Width="93px" Height="33px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnErreserbak" runat="server" Height="33px" Text="Erreserbak" Width="85px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Button ID="btnOstatuak" runat="server" Height="33px" Text="Ostatuak" Width="73px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="32pt" Text="Filtroa" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Size="16pt" Text="Zutabea:" Visible="False"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Size="16pt" Text="Datua:" Visible="False"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnBilatu" runat="server" Height="36px" Text="Bilatu" Visible="False" Width="72px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;<asp:Button ID="btnInsertatu" runat="server" Height="38px" Text="Insertatu" Visible="False" Width="85px" />
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnEzabatu" runat="server" Height="38px" style="margin-bottom: 0px" Text="Ezabatu" Visible="False" Width="81px" />
&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="btnAldatu" runat="server" Height="39px" Text="Aldatu" Visible="False" Width="73px" />
            <br />
            <br />
            &nbsp;
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20pt"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="Black" style="margin-left: 0px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" Width="30%"/>
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>