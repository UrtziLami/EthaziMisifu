Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class Erregistratu
    Inherits System.Web.UI.Page
    Dim conn As MySqlConnection
    Dim wf1 As New Login
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub erregistratu(sender As Object, e As EventArgs) Handles btnErregistratu.Click
        Dim konprobatu As Boolean = True
        Try
            conn = New MySqlConnection("server=localhost; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            konprobatu = False
            MessageBox.Show("No se ha podido conectar")
        End Try

        If TextBoxIzenAbizena.Text <> "" And TextBoxErab.Text <> "" Then
            Try
                Convert.ToInt32(TextBoxIzenAbizena.Text)
                konprobatu = False
                MsgBox("Erabiltzailea ezin du zenbakiak eduki", vbCritical, "Txarto")
            Catch ex As Exception

            End Try
        Else
            konprobatu = False
            MsgBox("Eremuak falta dira", vbCritical, "Txarto")
        End If

        If konprobatu = True Then
            If TextBoxPasahitza.Text <> TextBoxPasahitza2.Text Or TextBoxPasahitza.Text = "" Then
                konprobatu = False
                MsgBox("Pasahitzak desberdinak dira", vbCritical, "Txarto")
            End If
        End If
        If konprobatu = True Then
            Dim cm = New MySqlCommand()
            cm.CommandText = "INSERT INTO erabiltzaileak (izenAbizena,erabIzena,pasahitza) VALUES('" + TextBoxIzenAbizena.Text + "', '" + TextBoxErab.Text + "', '" + AES_Encrypt(TextBoxPasahitza.Text, wf1.kodEnc) + "')"
            cm.Connection = conn
            cm.ExecuteNonQuery()
            Response.Redirect("Login.aspx")
        End If

        conn.Close()
    End Sub

    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    Protected Sub bueltatu(sender As Object, e As EventArgs) Handles btnBueltatu.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class