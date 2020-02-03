Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class EzabatuOstatua
    Inherits System.Web.UI.Page
    Dim wf1 As New Login
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim conn As MySqlConnection
    Shared kont As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As New ArrayList()
        If kont = 0 Then
            Try
                conn = New MySqlConnection("server=192.168.13.33; database=" + wf1.bd + "; user id=root; port=3306")
                conn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar")
            End Try
            Dim sql = "SELECT sinadura FROM ostatuak"
            Dim cm = New MySqlCommand()
            cm.CommandText = sql
            cm.CommandType = CommandType.Text
            cm.Connection = conn
            Dim da = New MySqlDataAdapter(cm)

            ds = New DataSet()
            da.Fill(ds)

            For i = 0 To ds.Tables(0).Rows.Count - 1
                id.Add(ds.Tables(0).Rows(i)(0).ToString)
                DropDownList1.Items.Insert(i, id(i))
            Next
            kont = kont + 1
        End If

    End Sub

    Protected Sub aldatu(sender As Object, e As EventArgs) Handles btnEzabatu.Click
        Dim konprobatu As Boolean = True
        Try
            conn = New MySqlConnection("server=192.168.13.33; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
            konprobatu = False
        End Try

        If konprobatu = True Then
            Dim cm = New MySqlCommand()
            cm.CommandText = "DELETE FROM ostatuak WHERE sinadura = " + DropDownList1.SelectedItem.ToString
            cm.Connection = conn
            cm.ExecuteNonQuery()
            Response.Redirect("Taulak.aspx")
        End If

    End Sub
    Protected Sub btnBete_Click(sender As Object, e As EventArgs) Handles btnBete.Click
        Try
            conn = New MySqlConnection("server=192.168.13.33; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql2 = "SELECT * FROM ostatuak WHERE sinadura ='" + DropDownList1.SelectedItem.Text + "'"
        Dim cm2 = New MySqlCommand()
        cm2.CommandText = sql2
        cm2.CommandType = CommandType.Text
        cm2.Connection = conn
        Dim da2 = New MySqlDataAdapter(cm2)

        ds2 = New DataSet()
        da2.Fill(ds2)

        TextBoxIzena.Text = ds2.Tables(0).Rows(0)(1).ToString
        TextBoxDeskr.Text = ds2.Tables(0).Rows(0)(2).ToString
        TextBoxUdalerri.Text = ds2.Tables(0).Rows(0)(3).ToString
        TextBoxProbint.Text = ds2.Tables(0).Rows(0)(4).ToString
        TextBoxEmail.Text = ds2.Tables(0).Rows(0)(5).ToString
        TextBoxTelef.Text = ds2.Tables(0).Rows(0)(6).ToString
        TextBoxWeb.Text = ds2.Tables(0).Rows(0)(7).ToString
        TextBoxLongitudea.Text = ds2.Tables(0).Rows(0)(8).ToString
        TextBoxLatitudea.Text = ds2.Tables(0).Rows(0)(9).ToString

        btnEzabatu.Enabled = True
    End Sub
    Private Function balidatuEmail(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function
    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        kont = 0
        Response.Redirect("Taulak.aspx")
    End Sub
End Class