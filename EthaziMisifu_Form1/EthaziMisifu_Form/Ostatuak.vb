Imports MySql.Data.MySqlClient
Public Class OstatuLeiho
    Dim konn As MySqlConnection
    Private Sub kolumnakSortu()
        ListView1.View = View.Details
        ListView1.Clear()
        ListView1.Columns.Add("Sinadura", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Izena", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Deskribapena", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Udalerria", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Probintzia", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Email-a", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Telefonoa", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Web-a", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Longitudea", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Latitudea", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Ostatu Mota", 100, HorizontalAlignment.Center)
    End Sub
    Private Sub datuakKargatu()
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
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
            obj.SubItems.Add(rd(8).ToString)
            obj.SubItems.Add(rd(9).ToString)
            obj.SubItems.Add(rd(10).ToString)
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
        cmBxKolumnak()
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
        Dim osm As String = ListView1.SelectedItems(0).SubItems(10).Text
        Dim ostAld As New DatuakAldatuOst
        ostAld.datuak(iz, desk, udal, prob, email, telf, web, id, lat, lon, osm)
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
    Private Sub cmBxKolumnak()
        cmBKolumna.Items.Add("Sinadura")
        cmBKolumna.Items.Add("Ostatu Izena")
        cmBKolumna.Items.Add("Deskribapena")
        cmBKolumna.Items.Add("Udalerri")
        cmBKolumna.Items.Add("Probintzia")
        cmBKolumna.Items.Add("Email")
        cmBKolumna.Items.Add("Telefonoa")
        cmBKolumna.Items.Add("Web")
        cmBKolumna.Items.Add("Longitudea")
        cmBKolumna.Items.Add("Latitudea")
        cmBKolumna.Items.Add("Ostatu Mota")
        cmBKolumna.SelectedIndex = 0
    End Sub

    Private Sub btnKendu_Click(sender As Object, e As EventArgs) Handles btnKendu.Click
        Try
            'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("delete from ostatuak where sinadura = '" & ListView1.SelectedItems(0).SubItems(0).Text & "'", konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
        kolumnakSortu()
        datuakKargatu()
    End Sub

    Private Sub btnSartu_Click(sender As Object, e As EventArgs) Handles btnSartu.Click
        Dim lei As New OstatuaSartu
        lei.Show()
        Hide()
    End Sub
    Private Sub filtratuDatuak()
        kolumnakSortu()
        If cmBKolumna.SelectedItem.ToString.Equals("Sinadura") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommand As New MySqlCommand("select * from ostatuak where sinadura like '%" & txbDatua.Text & "%'", konn)
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
                obj.SubItems.Add(rd(8).ToString)
                obj.SubItems.Add(rd(9).ToString)
                obj.SubItems.Add(rd(10).ToString)
                ListView1.Items.Add(obj)
            End While
            rd.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Ostatu Izena") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommandd As New MySqlCommand("select * from ostatuak where izena like '%" & txbDatua.Text & "%'", konn)
            Dim rdd As MySqlDataReader
            rdd = myCommandd.ExecuteReader
            While (rdd.Read)
                Dim obj As New ListViewItem(rdd(0).ToString, 0)
                obj.SubItems.Add(rdd(1).ToString)
                obj.SubItems.Add(rdd(2).ToString)
                obj.SubItems.Add(rdd(3).ToString)
                obj.SubItems.Add(rdd(4).ToString)
                obj.SubItems.Add(rdd(5).ToString)
                obj.SubItems.Add(rdd(6).ToString)
                obj.SubItems.Add(rdd(7).ToString)
                obj.SubItems.Add(rdd(8).ToString)
                obj.SubItems.Add(rdd(9).ToString)
                obj.SubItems.Add(rdd(10).ToString)
                ListView1.Items.Add(obj)
            End While
            rdd.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Deskribapena") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where deskribapena like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Udalerri") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where udalerri like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Probintzia") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where probintzia like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Email") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where email like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Telefonoa") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where telefonoa like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Web") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where web like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Longitud") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where longitudea like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Latitud") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where latitudea like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Ostatu Mota") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComand As New MySqlCommand("select * from ostatuak where ostatuMota like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComand.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString)
                obj.SubItems.Add(dr(2).ToString)
                obj.SubItems.Add(dr(3).ToString)
                obj.SubItems.Add(dr(4).ToString)
                obj.SubItems.Add(dr(5).ToString)
                obj.SubItems.Add(dr(6).ToString)
                obj.SubItems.Add(dr(7).ToString)
                obj.SubItems.Add(dr(8).ToString)
                obj.SubItems.Add(dr(9).ToString)
                obj.SubItems.Add(dr(10).ToString)
                ListView1.Items.Add(obj)
            End While
            dr.Close()
            konn.Close()
        End If
    End Sub

    Private Sub txbDatua_TextChanged(sender As Object, e As EventArgs) Handles txbDatua.TextChanged
        filtratuDatuak()
    End Sub
End Class

