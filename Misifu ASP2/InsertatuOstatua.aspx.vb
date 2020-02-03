Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class InsertatuOstatua
    Inherits System.Web.UI.Page
    Dim wf1 As New Login
    Dim conn As MySqlConnection
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub insertatu(sender As Object, e As EventArgs) Handles btnInsertatu.Click
        Try
            conn = New MySqlConnection("server=192.168.13.33; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try

        Dim konprobatu As Boolean = True
        If TextBoxSinadura.Text <> "" And TextBoxIzena.Text <> "" And TextBoxDeskr.Text <> "" And TextBoxUdalerri.Text <> "" And TextBoxProbint.Text <> "" And TextBoxEmail.Text <> "" And TextBoxTelef.Text <> "" And TextBoxWeb.Text <> "" And TextBoxLongitudea.Text <> "" And TextBoxLatitudea.Text <> "" And TextBoxOstatuMota.Text <> "" Then
            Try
                Convert.ToInt32(TextBoxIzena.Text)
                konprobatu = False
                MsgBox("Ostatua ezin du zenbakiak eduki", vbCritical, "Txarto")
            Catch ex As Exception

            End Try
        Else
            konprobatu = False
            MsgBox("Eremuak falta dira", vbCritical, "Txarto")
        End If

        konprobatu = balidatuEmail(TextBoxEmail.Text)
        If konprobatu = False Then
            MsgBox("Email txarto sartuta", vbCritical, "Txarto")
        End If

        If TextBoxTelef.Text.Length = 9 Then
            Try
                Convert.ToInt32(TextBoxTelef.Text)
            Catch ex As Exception
                konprobatu = False
                MsgBox("Telefonoa ezin du letrak izan", vbCritical, "Txarto")
            End Try
        Else
            konprobatu = False
            MsgBox("Telefonoa txarto sartuta", vbCritical, "Txarto")
        End If

        If konprobatu = True Then
            Dim cm = New MySqlCommand()
            cm.CommandText = "INSERT INTO ostatuak (sinadura,izena,deskribapena,udalerri,probintzia,email,telefonoa,web,longitudea,latitudea,ostatuMota) VALUES('" + TextBoxSinadura.Text + "', '" + TextBoxIzena.Text + "', '" + TextBoxDeskr.Text + "', '" + TextBoxUdalerri.Text + "', '" + TextBoxProbint.Text + "', '" + TextBoxEmail.Text + "', '" + TextBoxTelef.Text + "', '" + TextBoxWeb.Text + "', '" + TextBoxLongitudea.Text + "', '" + TextBoxLatitudea.Text + "', '" + TextBoxOstatuMota.Text + "')"
            cm.Connection = conn
            cm.ExecuteNonQuery()
            Response.Redirect("Taulak.aspx")
        End If


    End Sub
    Private Function balidatuEmail(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        Response.Redirect("Taulak.aspx")
    End Sub
End Class