Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class AldatuErreserba
    Inherits System.Web.UI.Page
    Dim wf1 As New Login
    Dim conn As MySqlConnection
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim erabiltzaileak As New ArrayList()
    Dim ostatuak As New ArrayList()
    Shared kont As Integer = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            conn = New MySqlConnection("server=" + wf1.server_ip + "; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        If kont = 0 Then
            Dim id As New ArrayList()

            Dim sql = "SELECT izena FROM ostatuak"
            Dim cm = New MySqlCommand()
            cm.CommandText = sql
            cm.CommandType = CommandType.Text
            cm.Connection = conn
            Dim da = New MySqlDataAdapter(cm)

            ds = New DataSet()
            da.Fill(ds)

            For i = 0 To ds.Tables(0).Rows.Count - 1
                ostatuak.Add(ds.Tables(0).Rows(i)(0).ToString)
                DropDownList2.Items.Insert(i, ostatuak(i))
            Next


            Dim sql2 = "SELECT idErreserba FROM erreserbak WHERE Erabiltzaileak_idBezeroak = (SELECT idBezeroak FROM erabiltzaileak WHERE erabIzena like '" + wf1.erabiltzailea.ToString + "')"
            Dim cm2 = New MySqlCommand()
            cm2.CommandText = sql2
            cm2.CommandType = CommandType.Text
            cm2.Connection = conn
            Dim da2 = New MySqlDataAdapter(cm2)

            Dim ds2 = New DataSet()
            da2.Fill(ds2)

            For i = 0 To ds2.Tables(0).Rows.Count - 1
                id.Add(ds2.Tables(0).Rows(i)(0).ToString)
                DropDownList3.Items.Insert(i, id(i))
            Next

            Calendar1.SelectedDate = Today
            Calendar2.SelectedDate = Today

            kont = kont + 1
        End If

    End Sub

    Protected Sub aldatu(sender As Object, e As EventArgs) Handles btnAldatu.Click
        Dim sql = wf1.select_query("idBezeroak", "erabiltzaileak", "erabIzena", wf1.erabiltzailea.ToString)
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)

        Dim sql2 = wf1.select_query("sinadura", "ostatuak", "izena", DropDownList2.SelectedItem.ToString)
        Dim cm2 = New MySqlCommand()
        cm2.CommandText = sql2
        cm2.CommandType = CommandType.Text
        cm2.Connection = conn
        Dim da2 = New MySqlDataAdapter(cm2)

        ds2 = New DataSet()
        da2.Fill(ds2)

        Dim cm3 = New MySqlCommand()
        cm3.CommandText = "UPDATE erreserbak SET Ostatuak_sinadura = '" + ds2.Tables(0).Rows(0)(0).ToString + "', sartuData = '" + Calendar1.SelectedDate.ToShortDateString() + "', ateraData = '" + Calendar2.SelectedDate.ToShortDateString() + "' WHERE idErreserba = '" + DropDownList3.SelectedItem.ToString + "'"
        cm3.Connection = conn
        cm3.ExecuteNonQuery()
        kont = 0
        Response.Redirect("Taulak.aspx")
    End Sub

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        kont = 0
        Response.Redirect("Taulak.aspx")
    End Sub

    Protected Sub btnBete_Click(sender As Object, e As EventArgs) Handles btnBete.Click
        Dim sql3 = "SELECT izena FROM ostatuak WHERE sinadura = (SELECT ostatuak_sinadura FROM erreserbak WHERE idErreserba like '" + DropDownList3.SelectedItem.ToString + "')"
        Dim cm3 = New MySqlCommand()
        cm3.CommandText = sql3
        cm3.CommandType = CommandType.Text
        cm3.Connection = conn
        Dim da3 = New MySqlDataAdapter(cm3)

        Dim ds3 = New DataSet()
        da3.Fill(ds3)

        DropDownList2.SelectedItem.Text = ds3.Tables(0).Rows(0)(0).ToString
    End Sub
End Class