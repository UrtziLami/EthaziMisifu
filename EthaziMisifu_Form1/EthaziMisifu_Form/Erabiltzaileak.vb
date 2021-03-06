﻿Imports MySql.Data.MySqlClient
Public Class ErabiltzaileLeihoa
    Dim konn As MySqlConnection
    Private Sub kolumnakSortu()
        ListView1.View = View.Details
        ListView1.Clear()
        ListView1.Columns.Add("Id", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Izen Abizena", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Pasahitza", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Erabiltzaile Izena", 100, HorizontalAlignment.Center)
    End Sub

    Private Sub datuakKargatu()
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("select * from erabiltzaileak", konn)
        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader
        While (rd.Read)
            Dim obj As New ListViewItem(rd(0).ToString, 0)
            obj.SubItems.Add(rd(1).ToString)
            obj.SubItems.Add(HasiSaioaLeihoa.AES_Decrypt(rd(2).ToString, HasiSaioaLeihoa.kodEncDes))
            obj.SubItems.Add(rd(3).ToString)
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
    Private Sub cmBxKolumnak()
        cmBKolumna.Items.Add("Id")
        cmBKolumna.Items.Add("Izen Abizena")
        cmBKolumna.Items.Add("Erabiltzaile Izena")
        cmBKolumna.SelectedIndex = 0
    End Sub

    Private Sub ErabiltzaileLeihoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim pas As String = ListView1.SelectedItems(0).SubItems(2).Text
        Dim era As String = ListView1.SelectedItems(0).SubItems(3).Text
        Dim erabAld As New DatuakAldatuErab
        erabAld.datuak(iz, pas, id, era)
        erabAld.Show()
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
            konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("delete from erabiltzaileak where idBezeroak = " & ListView1.SelectedItems(0).SubItems(0).Text, konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
        kolumnakSortu()
        datuakKargatu()
    End Sub

    Private Sub btnSartu_Click(sender As Object, e As EventArgs) Handles btnSartu.Click
        Dim lei As New ErabiltzaileaSartu
        lei.Show()
        Hide()
    End Sub
    Private Sub filtratuDatuak()
        kolumnakSortu()
        If cmBKolumna.SelectedItem.ToString.Equals("Id") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommand As New MySqlCommand("select * from erabiltzaileak where idBezeroak like '%" & txbDatua.Text & "%'", konn)
            Dim rd As MySqlDataReader
            rd = myCommand.ExecuteReader
            While (rd.Read)
                Dim obj As New ListViewItem(rd(0).ToString, 0)
                obj.SubItems.Add(rd(1).ToString())
                obj.SubItems.Add(HasiSaioaLeihoa.AES_Decrypt(rd(2).ToString(), HasiSaioaLeihoa.kodEncDes))
                obj.SubItems.Add(rd(3).ToString())
                ListView1.Items.Add(obj)
            End While
            rd.Close()
            konn.Close()
        ElseIf cmBKolumna.SelectedItem.ToString.Equals("Izen Abizena") Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommandd As New MySqlCommand("select * from erabiltzaileak where izenAbizena like '%" & txbDatua.Text & "%'", konn)
            Dim rdd As MySqlDataReader
            rdd = myCommandd.ExecuteReader
            While (rdd.Read)
                Dim obj As New ListViewItem(rdd(0).ToString, 0)
                obj.SubItems.Add(rdd(1).ToString())
                obj.SubItems.Add(HasiSaioaLeihoa.AES_Decrypt(rdd(2).ToString(), HasiSaioaLeihoa.kodEncDes))
                obj.SubItems.Add(rdd(3).ToString())
                ListView1.Items.Add(obj)
            End While
            rdd.Close()
            konn.Close()
        Else
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306; convert zero datetime = true")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myComando As New MySqlCommand("select * from erabiltzaileak where erabIzena like '%" & txbDatua.Text & "%'", konn)
            Dim dr As MySqlDataReader
            dr = myComando.ExecuteReader
            While (dr.Read)
                Dim obj As New ListViewItem(dr(0).ToString, 0)
                obj.SubItems.Add(dr(1).ToString())
                obj.SubItems.Add(HasiSaioaLeihoa.AES_Decrypt(dr(2).ToString(), HasiSaioaLeihoa.kodEncDes))
                obj.SubItems.Add(dr(3).ToString())
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