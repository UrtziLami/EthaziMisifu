Imports MySql.Data.MySqlClient
Public Class OstatuLeiho
    Dim konn As MySqlConnection
    Private Sub kolumnakSortu()
        ListView1.View = View.Details
        ListView1.Clear()
        ListView1.Columns.Add("Id", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Izena", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Deskribapena", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Udalerria", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Probintzia", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Email-a", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Telefonoa", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Web-a", 100, HorizontalAlignment.Center)
    End Sub

    Private Sub datuakKargatu()
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("select * from ostatuak", konn)
        Dim da As New MySqlDataAdapter(myCommand)
        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader
        While (rd.Read)
            Dim obj As New ListViewItem(rd(0).ToString, 0)
            obj.SubItems.Add(rd(1).ToString)
            obj.SubItems.Add(rd(2).ToString)
            obj.SubItems.Add(rd(3).ToString)
            obj.SubItems.Add(rd(4).ToString)
            obj.SubItems.Add(rd(5).ToString)
            obj.SubItems.Add(rd(6).ToString)
            obj.SubItems.Add(rd(7).ToString)
            ListView1.Items.Add(obj)
        End While
        rd.Close()
        konn.Close()
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Dim kud As New KudeaketaLeihoa
        kud.Show()
        Hide()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub AlojamenduLeiho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kolumnakSortu()
        datuakKargatu()
    End Sub

    Private Sub btnAldatu_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
        aldaketa()
    End Sub
    Private Sub aldaketa()
        Dim id As String = ListView1.SelectedItems(0).SubItems(0).Text
        Dim iz As String = ListView1.SelectedItems(0).SubItems(1).Text
        Dim desk As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim udal As String = ListView1.SelectedItems(0).SubItems(3).Text
        Dim prob As String = ListView1.SelectedItems(0).SubItems(4).Text
        Dim email As String = ListView1.SelectedItems(0).SubItems(5).Text
        Dim telf As String = ListView1.SelectedItems(0).SubItems(6).Text
        Dim web As String = ListView1.SelectedItems(0).SubItems(7).Text
        Dim lon As String = ListView1.SelectedItems(0).SubItems(8).Text
        Dim lat As String = ListView1.SelectedItems(0).SubItems(9).Text
        Dim ostAld As New DatuakAldatuOst
        ostAld.datuak(iz, desk, udal, prob, email, telf, web, id, lat, lon)
        ostAld.Show()
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
            'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("delete from ostatuak where idAlojamenduak = " & ListView1.SelectedItems(0).SubItems(0).Text, konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
    End Sub
End Class

