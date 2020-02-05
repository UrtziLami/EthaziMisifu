Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class EzabatuErreserba
    Inherits System.Web.UI.Page
    Dim wf1 As New Login
    Dim conn As MySqlConnection
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim erabiltzaileak As New ArrayList()
    Dim ostatuak As New ArrayList()
    Shared kont As Integer = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If kont = 0 Then
            Dim id As New ArrayList()
            Try
                conn = New MySqlConnection("server=" + wf1.server_ip + "; database=" + wf1.bd + "; user id=root; port=3306")
                conn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar")
            End Try
            Dim sql = "SELECT erabIzena FROM erabiltzaileak"
            Dim cm = New MySqlCommand()
            cm.CommandText = sql
            cm.CommandType = CommandType.Text
            cm.Connection = conn
            Dim da = New MySqlDataAdapter(cm)

            ds = New DataSet()
            da.Fill(ds)

            Dim sql2 = "SELECT sinadura FROM ostatuak"
            Dim cm2 = New MySqlCommand()
            cm2.CommandText = sql2
            cm2.CommandType = CommandType.Text
            cm2.Connection = conn
            Dim da2 = New MySqlDataAdapter(cm2)

            ds2 = New DataSet()
            da2.Fill(ds2)

            Dim sql3 = "SELECT idErreserba FROM erreserbak WHERE Erabiltzaileak_idBezeroak = (SELECT idBezeroak FROM erabiltzaileak WHERE erabIzena like '" + wf1.erabiltzailea.ToString + "')"
            Dim cm3 = New MySqlCommand()
            cm3.CommandText = sql3
            cm3.CommandType = CommandType.Text
            cm3.Connection = conn
            Dim da3 = New MySqlDataAdapter(cm3)

            Dim ds3 = New DataSet()
            da3.Fill(ds3)

            For i = 0 To ds3.Tables(0).Rows.Count - 1
                id.Add(ds3.Tables(0).Rows(i)(0).ToString)
                DropDownList3.Items.Insert(i, id(i))
            Next
            kont = kont + 1
        End If

    End Sub

    Protected Sub ezabatu(sender As Object, e As EventArgs) Handles btnEzabatu.Click
        Try
            conn = New MySqlConnection("server=" + wf1.server_ip + "; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try

        Dim cm3 = New MySqlCommand()
        cm3.CommandText = "DELETE FROM erreserbak WHERE idErreserba = " + DropDownList3.SelectedItem.ToString
        cm3.Connection = conn
        cm3.ExecuteNonQuery()
        Response.Redirect("Taulak.aspx")
    End Sub

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        kont = 0
        Response.Redirect("Taulak.aspx")
    End Sub

    Protected Sub btnBete_Click(sender As Object, e As EventArgs) Handles btnBete.Click
        Try
            conn = New MySqlConnection("server=" + wf1.server_ip + "; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql = "SELECT erabIzena FROM erabiltzaileak WHERE idBezeroak = (SELECT Erabiltzaileak_idBezeroak FROM erreserbak WHERE idErreserba like '" + DropDownList3.SelectedItem.ToString + "')"
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)

        Dim sql2 = "SELECT * FROM erreserbak WHERE idErreserba = '" + DropDownList3.SelectedItem.ToString + "'"
        Dim cm2 = New MySqlCommand()
        cm2.CommandText = sql2
        cm2.CommandType = CommandType.Text
        cm2.Connection = conn
        Dim da2 = New MySqlDataAdapter(cm2)

        ds2 = New DataSet()
        da2.Fill(ds2)

        Dim sql3 = "SELECT izena FROM ostatuak WHERE sinadura = (SELECT Ostatuak_sinadura FROM erreserbak WHERE idErreserba like '" + DropDownList3.SelectedItem.ToString + "')"
        Dim cm3 = New MySqlCommand()
        cm3.CommandText = sql3
        cm3.CommandType = CommandType.Text
        cm3.Connection = conn
        Dim da3 = New MySqlDataAdapter(cm3)

        ds3 = New DataSet()
        da3.Fill(ds3)

        TextBox2.Text = ds3.Tables(0).Rows(0)(0).ToString
        TextBox3.Text = ds2.Tables(0).Rows(0)(3).ToString
        TextBox4.Text = ds2.Tables(0).Rows(0)(4).ToString
    End Sub
End Class