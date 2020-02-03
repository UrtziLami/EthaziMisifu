Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class WebForm5
    Inherits System.Web.UI.Page
    Dim wf1 As New Login
    Dim conn As MySqlConnection
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Shared kont As Integer = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If kont = 0 Then
            Dim erabiltzaileak As New ArrayList()
            Dim ostatuak As New ArrayList()
            Try
                conn = New MySqlConnection("server=localhost; database=" + wf1.bd + "; user id=root; port=3306")
                conn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar")
            End Try

            Dim sql2 = "SELECT izena FROM ostatuak"
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

            Calendar1.SelectedDate = Today
            Calendar2.SelectedDate = Today

            kont = kont + 1
        End If

    End Sub

    Protected Sub insertatu(sender As Object, e As EventArgs) Handles btnInsertatu.Click
        Dim konprobatu As Boolean = False
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
        cm3.CommandText = "INSERT INTO erreserbak (Erabiltzaileak_idBezeroak,Ostatuak_sinadura,sartuData,ateraData) VALUES('" + ds.Tables(0).Rows(0)(0).ToString + "', '" + ds2.Tables(0).Rows(0)(0).ToString + "', '" + Calendar1.SelectedDate.ToShortDateString() + "', '" + Calendar2.SelectedDate.ToShortDateString() + "')"
        cm3.Connection = conn
        cm3.ExecuteNonQuery()
        kont = 0
        Response.Redirect("Taulak.aspx")


    End Sub

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        kont = 0
        Response.Redirect("Taulak.aspx")
    End Sub
End Class