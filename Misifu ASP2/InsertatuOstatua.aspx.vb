Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim conn As MySqlConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub insertatu(sender As Object, e As EventArgs) Handles btnInsertatu.Click
        Try
            conn = New MySqlConnection("server=localhost; database=misifu; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try

        Dim konprobatu As Boolean = True
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" Then
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
            If TextBox2.Text <> TextBox3.Text Or TextBox2.Text = "" Then
                konprobatu = False
                MsgBox("Pasahitzak desberdinak dira", vbCritical, "Txarto")
            End If
        End If
        If konprobatu = True Then
            Dim cm = New MySqlCommand()
            cm.CommandText = "INSERT INTO ostatuak (izena,deskribapena,udalerri,probintzia,email,telefonoa,web) VALUES()"
            cm.Connection = conn
            cm.ExecuteNonQuery()
            Response.Redirect("Taulak.aspx")
        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Taulak.aspx")
    End Sub
End Class