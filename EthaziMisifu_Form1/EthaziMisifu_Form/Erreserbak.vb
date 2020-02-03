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
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306;")
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
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("select erabIzena from erabiltzaileak where idBezeroak = " & id, konn)
        Dim dr As MySqlDataReader
        Dim erab As String
        dr = komand.ExecuteReader
        If dr.Read Then
            erab = dr(0).ToString
        End If
        dr.Close()
        konn.Close()
        Return erab
    End Function

    Private Function aldatuOst(id As String) As String
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("select izena from ostatuak where sinadura = '" & id & "'", konn)
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
    Private Sub cmBxKolumnak()
        cmBKolumna.Items.Add("Erreserbaren Id")
        cmBKolumna.Items.Add("Bezero Izen Abizena")
        cmBKolumna.Items.Add("Ostatu Izena")
        cmBKolumna.SelectedIndex = 0
    End Sub

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
        cmBxKolumnak()
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
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("delete from erreserbak where idErreserba = " & ListView1.SelectedItems(0).SubItems(0).Text, konn)
        komand.ExecuteNonQuery()
        konn.Close()
        kolumnakSortu()
        datuakKargatu()
    End Sub

    Private Sub btnSartu_Click(sender As Object, e As EventArgs) Handles btnSartu.Click
        Dim lei As New ErreserbaSartu
        lei.Show()
        Hide()
    End Sub
    Private Sub filtratuDatuak()
        kolumnakSortu()
        If cmBKolumna.SelectedItem.ToString.Equals("Erreserbaren Id") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommand As New MySqlCommand("select * from erreserbak where idErreserba like '%" & txbDatua.Text & "%'", konn)
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
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Bezero Izen Abizena") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommand As New MySqlCommand("SELECT e.* FROM `erabiltzaileak` era, `erreserbak` e WHERE erabIzena like '%" & txbDatua.Text & "%' and era.`idBezeroak` = e.`Erabiltzaileak_idBezeroak", konn)
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
        Else
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommand As New MySqlCommand("SELECT e.* FROM `ostatuak` ost, `erreserbak` e WHERE izena like '%" & txbDatua.Text & "%' and ost.`sinadura` = e.`Ostatuak_sinadura`", konn)
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
        End If
    End Sub

    Private Sub txbDatua_TextChanged(sender As Object, e As EventArgs) Handles txbDatua.TextChanged
        filtratuDatuak()
    End Sub
End Class