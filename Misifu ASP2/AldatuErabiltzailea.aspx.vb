Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class AldatuErabiltzailea
    Inherits System.Web.UI.Page
    Dim conn As MySqlConnection
    Dim wf1 As New Login
    Dim erregistratu As New Erregistratu
    Dim ds As New DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            conn = New MySqlConnection("server=192.168.13.33; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql = "SELECT * FROM erabiltzaileak WHERE erabIzena ='" + wf1.erabiltzailea.ToString + "'"
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)


        TextBoxIzenAbizena.Text = ds.Tables(0).Rows(0)(1).ToString
        TextBoxErab.Text = ds.Tables(0).Rows(0)(3).ToString

        btnAldatu.Enabled = True
        conn.Close()


    End Sub

    Protected Sub aldatu(sender As Object, e As EventArgs) Handles btnAldatu.Click
        Try
            conn = New MySqlConnection("server=192.168.13.33; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try

        Dim konprobatu As Boolean = True
        If TextBoxIzenAbizena.Text <> "" Then
            Try
                Convert.ToInt32(TextBoxIzenAbizena.Text)
                konprobatu = False
                MsgBox("Erabiltzailea ezin du zenbakiak eduki", vbCritical, "Txarto")
            Catch ex As Exception

            End Try
        Else
            konprobatu = False
            MsgBox("Erabiltzailea sartu", vbCritical, "Txarto")
        End If

        If konprobatu = True Then
            If TextBoxPasahitza.Text <> TextBoxPasahitza2.Text Or TextBoxPasahitza.Text = "" Then
                konprobatu = False
                MsgBox("Pasahitzak desberdinak dira", vbCritical, "Txarto")
            End If
        End If
        If konprobatu = True Then
            Dim cm = New MySqlCommand()
            cm.CommandText = "UPDATE erabiltzaileak SET izenAbizena = '" + TextBoxIzenAbizena.Text + "', pasahitza = '" + erregistratu.AES_Encrypt(TextBoxPasahitza.Text, wf1.kodEnc) + "', erabIzena = '" + TextBoxErab.Text + "' WHERE erabIzena = '" + wf1.erabiltzailea.ToString + "'"
            cm.Connection = conn
            cm.ExecuteNonQuery()
            Response.Redirect("Taulak.aspx")
        End If

    End Sub

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        Response.Redirect("Taulak.aspx")
    End Sub

End Class