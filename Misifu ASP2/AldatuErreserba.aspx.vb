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
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As New ArrayList()
        Try
            conn = New MySqlConnection("server=localhost; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try

        Dim sql2 = "SELECT sinadura FROM ostatuak"
        Dim cm2 = New MySqlCommand()
        cm2.CommandText = sql2
        cm2.CommandType = CommandType.Text
        cm2.Connection = conn
        Dim da2 = New MySqlDataAdapter(cm2)

        ds2 = New DataSet()
        da2.Fill(ds2)

        For i = 0 To ds2.Tables(0).Rows.Count - 1
            ostatuak.Add(ds2.Tables(0).Rows(i)(0).ToString)
            DropDownList2.Items.Insert(i, ostatuak(i))
        Next


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

        Calendar1.SelectedDate = Today
        Calendar2.SelectedDate = Today
    End Sub

    Protected Sub aldatu(sender As Object, e As EventArgs) Handles btnAldatu.Click
        Try
            conn = New MySqlConnection("server=localhost; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql = "SELECT idBezeroak FROM erabiltzaileak WHERE erabIzena like '" + wf1.erabiltzailea.ToString + "'"
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)

        Dim sql2 = "SELECT sinadura FROM ostatuak WHERE sinadura like '" + DropDownList2.SelectedItem.ToString + "'"
        Dim cm2 = New MySqlCommand()
        cm2.CommandText = sql2
        cm2.CommandType = CommandType.Text
        cm2.Connection = conn
        Dim da2 = New MySqlDataAdapter(cm2)

        ds2 = New DataSet()
        da2.Fill(ds2)

        Dim cm3 = New MySqlCommand()
        cm3.CommandText = "UPDATE erreserbak SET Ostatuak_sinadura = '" + DropDownList2.SelectedItem.ToString + "', sartuData = '" + Calendar1.SelectedDate.ToShortDateString() + "', ateraData = '" + Calendar2.SelectedDate.ToShortDateString() + "' WHERE idErreserba = " + DropDownList3.SelectedItem.ToString
        cm3.Connection = conn
        cm3.ExecuteNonQuery()
        Response.Redirect("Taulak.aspx")
    End Sub

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        Response.Redirect("Taulak.aspx")
    End Sub

End Class