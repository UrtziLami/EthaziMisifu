Imports MySql.Data.MySqlClient

Public Class HasiSaioaLeihoa
    Dim konn As MySqlConnection
    Public kodEncDes As String = "12345"
    Private Sub aldatuLeiho()
        Dim kud As New KudeaketaLeihoa
        kud.Show()
        Hide()
        If chbErabGog.Checked Then
            My.Settings.Erabiltzailea = txtBxErabiltzailea.Text
            My.Settings.Pasahitza = txBPasahitza.Text
            My.Settings.Save()
        Else
            My.Settings.Reset()
        End If
    End Sub
    Private Sub btnHasiSaioa_Click(sender As Object, e As EventArgs) Handles btnHasiSaioa.Click
        aldaketa()
    End Sub
    Private Sub aldaketa()
        If konparatuPasahitza() = True Then
            aldatuLeiho()
        Else
            MessageBox.Show("Datuak txarto daude.")
        End If
    End Sub

    Private Function konparatuPasahitza() As Boolean
        Dim pasBD As String
        Dim eraBD As String
        Dim pswDes As String
        Dim eraDes As String
        Dim pasK As String() = New String(30) {}
        Dim eraK As String() = New String(30) {}
        Dim i As Integer = 0
        Dim ema As Boolean = False
        Dim pas As Boolean = False
        Dim erab As Boolean = False
        Dim pasT As String = txBPasahitza.Text
        Dim eraT As String = txtBxErabiltzailea.Text

        Try
            'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try

        Dim myCommand As New MySqlCommand("select * from erabiltzaileak", konn)
        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader
        While rd.Read
            eraBD = rd(3).ToString
            pasBD = rd(2).ToString
            pswDes = AES_Decrypt(pasBD, kodEncDes)
            eraDes = AES_Decrypt(eraBD, kodEncDes)
            pasK(i) = pswDes
            eraK(i) = eraDes
            i += 1
        End While
        rd.Close()

        If pasT <> Nothing And eraT <> Nothing Then
            For j As Integer = 0 To i - 1
                If pasK(j).Equals(pasT) Then
                    pas = True
                    Exit For
                End If
            Next
            For j As Integer = 0 To i - 1
                If eraK(j).Equals(eraT) Then
                    erab = True
                    Exit For
                End If
            Next
            If pas = True And erab = True Then
                ema = True
            End If
        End If

        Return ema
    End Function
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub
    Private Sub txtBxErabiltzailea_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBxErabiltzailea.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                aldaketa()
        End Select
    End Sub
    Private Sub txBPasahitza_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txBPasahitza.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                aldaketa()
        End Select
    End Sub
    Private Sub HasiSaioaLeihoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBxErabiltzailea.Text = My.Settings.Erabiltzailea
        txBPasahitza.Text = My.Settings.Pasahitza
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim pshEnc As String = AES_Encrypt(txBPasahitza.Text, kodEncDes)
        Dim eraIzEnc As String = AES_Encrypt(txtBxErabiltzailea.Text, kodEncDes)
        Dim myCommand As New MySqlCommand("insert into erabiltzaileak (pasahitza, erabIzena) values ('" & pshEnc & "', '" & eraIzEnc & "')", konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
    End Sub
End Class