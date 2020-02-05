Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class Login
    Inherits System.Web.UI.Page
    Dim conn As MySqlConnection
    Dim ds As New DataSet
    Public kodEnc As String = "12345"
    Public bd As String = "ethazi_misifu"
    Public Shared erabiltzailea As String
    Public server_ip As String = "192.168.13.33"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub saioaHasi(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim konprobatu As Boolean = False
        Dim izenak As ArrayList

        konprobatu = pasahitzaBalidatu(TextBoxErab.Text, TextBoxPasahitza.Text)

        If konprobatu = True Then
            erabiltzailea = TextBoxErab.Text
            Response.Redirect("Taulak.aspx")
        End If

    End Sub

    Private Function pasahitzaBalidatu(ByVal izena As String, ByVal pasahitza As String) As Boolean
        Dim konprobatu As Boolean = True
        Dim izenak(10) As String
        Try
            conn = New MySqlConnection("server=" + server_ip + "; database=" + bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            konprobatu = False
            MessageBox.Show("No se ha podido conectar")
        End Try

        If izena = "" Then
            konprobatu = False
            MsgBox("Erabiltzailea falta da", vbCritical, "Txarto")
        ElseIf pasahitza = "" Then
            konprobatu = False
            MsgBox("Pasahitza falta da", vbCritical, "Txarto")
        End If

        If konprobatu Then
            Dim query As New MySqlCommand("SELECT pasahitza FROM erabiltzaileak WHERE erabIzena like '" + izena + "'", conn)
            Dim da As New MySqlDataAdapter(query)

            ds = New DataSet()
            da.Fill(ds)

            Dim datu As String

            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    datu = ds.Tables(0).Rows(i)(j).ToString()
                Next
            Next

            If datu = "" Then
                konprobatu = False
                MsgBox("Erabiltzailea ez da existitzen", vbCritical, "Txarto")
            ElseIf AES_Decrypt(datu, kodEnc) = pasahitza And datu <> "" Then
                konprobatu = True
            Else
                konprobatu = False
                MsgBox("Pasahitza edo erabiltzailea txarto sartuta", vbCritical, "Txarto")
            End If

        End If


        conn.Close()
        Return konprobatu
    End Function

    Protected Sub erregistratu(sender As Object, e As EventArgs) Handles btnErregistratu.Click
        Response.Redirect("Erregistratu.aspx")
    End Sub

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function

    Public Function select_query(ByVal selectdatu As String, ByVal taula As String, ByVal where As String, ByVal likedatu As String) As String
        Dim sql = "SELECT " + selectdatu + " FROM " + taula + " WHERE " + where + " like '" + likedatu + "'"
        Return sql
    End Function

End Class