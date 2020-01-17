Imports MySql.Data.MySqlClient
Public Class ErreserbaLeihoa
    Dim konn As MySqlConnection
    Dim idera As String
    Dim idost As String

    Private Sub kolumnakSortu()
        ListView1.View = View.Details
        ListView1.Clear()
        ListView1.Columns.Add("Id", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Erabiltzailea", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Ostatua", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Sartze Data", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Irtetze Data", 100, HorizontalAlignment.Center)
    End Sub

    Private Sub datuakKargatu()
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("select * from erreserbak", konn)
        Dim da As New MySqlDataAdapter(myCommand)
        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader
        While (rd.Read)
            Dim obj As New ListViewItem(rd(0).ToString, 0)
            idost = rd(1).ToString
            idera = rd(2).ToString
            obj.SubItems.Add(aldatuErab(idera))
            obj.SubItems.Add(aldatuOst(idost))
            obj.SubItems.Add(rd(3).ToString)
            obj.SubItems.Add(rd(4).ToString)
            ListView1.Items.Add(obj)
        End While
        rd.Close()
        konn.Close()
    End Sub

    Private Function aldatuErab(id As String) As String
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("select izenAbizena from erabiltzaileak where idBezeroak = " & id, konn)
        Dim dr As MySqlDataReader
        Dim erab As String
        dr = komand.ExecuteReader
        If dr.Read Then
            erab = HasiSaioaLeihoa.AES_Decrypt(dr(0).ToString, HasiSaioaLeihoa.kodEncDes)
        End If
        dr.Close()
        konn.Close()
        Return erab
    End Function

    Private Function aldatuOst(id As String) As String
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("select izena from ostatuak where sinadura = " & id, konn)
        Dim dr As MySqlDataReader
        Dim ost As String
        dr = komand.ExecuteReader
        If dr.Read Then
            ost = dr(0).ToString
        End If
        dr.Close()
        konn.Close()
        Return ost
    End Function

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Dim kud As New KudeaketaLeihoa
        kud.Show()
        Hide()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub
    Private Sub ErreserbaLeihoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kolumnakSortu()
        datuakKargatu()
    End Sub

    Private Sub btnAldatu_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
        aldaketa()
    End Sub
    Private Sub aldaketa()
        Dim id As String = ListView1.SelectedItems(0).SubItems(0).Text
        Dim sart As String = ListView1.SelectedItems(0).SubItems(3).Text
        Dim irt As String = ListView1.SelectedItems(0).SubItems(4).Text
        Dim sartze As DateTime = Convert.ToDateTime(sart)
        Dim irtetze As DateTime = Convert.ToDateTime(irt)
        Dim errAld As New DatuakAldatuErre
        errAld.datuak(idera, idost, id, sartze, irtetze)
        errAld.Show()
        Hide()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        btnAldatu.Enabled = True
        btnKendu.Enabled = True
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        aldaketa()
    End Sub
    Private Sub btnKendu_Click(sender As Object, e As EventArgs) Handles btnKendu.Click
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("delete from erreserbak where idErreserba = " & ListView1.SelectedItems(0).SubItems(0).Text, konn)
        komand.ExecuteNonQuery()
        konn.Close()
    End Sub
End Class