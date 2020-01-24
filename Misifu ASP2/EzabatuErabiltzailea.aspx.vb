Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class EzabatuErabiltzailea
    Inherits System.Web.UI.Page
    Dim conn As MySqlConnection
    Dim wf1 As New Login
    Dim erregistratu As New Erregistratu
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Shared kont As Integer = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If kont = 0 Then
            Dim id As New ArrayList()
            Try
                conn = New MySqlConnection("server=localhost; database=" + wf1.bd + "; user id=root; port=3306")
                conn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar")
            End Try
            Dim sql = "SELECT idBezeroak FROM erabiltzaileak"
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

    Protected Sub ezabatu(sender As Object, e As EventArgs) Handles btnEzabatu.Click
        Try
            conn = New MySqlConnection("server=localhost; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try

        Dim konprobatu As Boolean = True
        If TextBox1.Text <> "" Then
            Try
                Convert.ToInt32(TextBox1.Text)
                konprobatu = False
                MsgBox("Erabiltzailea ezin du zenbakiak eduki", vbCritical, "Txarto")
            Catch ex As Exception

            End Try
        Else
            konprobatu = False
            MsgBox("Erabiltzailea sartu", vbCritical, "Txarto")
        End If

        If konprobatu = True Then
            Dim cm = New MySqlCommand()
            cm.CommandText = "DELETE FROM erabiltzaileak WHERE idBezeroak = " + DropDownList1.SelectedItem.ToString
            cm.Connection = conn
            cm.ExecuteNonQuery()
            Response.Redirect("Taulak.aspx")
        End If

    End Sub

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        Response.Redirect("Taulak.aspx")
    End Sub

    Protected Sub btnBete_Click(sender As Object, e As EventArgs) Handles btnBete.Click
        Try
            conn = New MySqlConnection("server=localhost; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql2 = "SELECT * FROM erabIzena WHERE idBezeroak =" + DropDownList1.SelectedItem.Text
        Dim cm2 = New MySqlCommand()
        cm2.CommandText = sql2
        cm2.CommandType = CommandType.Text
        cm2.Connection = conn
        Dim da2 = New MySqlDataAdapter(cm2)

        ds2 = New DataSet()
        da2.Fill(ds2)


        TextBox1.Text = ds2.Tables(0).Rows(0)(1).ToString

        btnEzabatu.Enabled = True
        conn.Close()
    End Sub
End Class