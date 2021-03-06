﻿Imports MySql.Data.MySqlClient
Public Class ErabiltzaileaSartu
    Dim konn As MySqlConnection
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub btnSartu_Click(sender As Object, e As EventArgs) Handles btnSartu.Click
        If datuakSartu() Then
            Dim lei As New ErabiltzaileLeihoa
            lei.Show()
            Hide()
        End If
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Dim klas As New ErabiltzaileLeihoa
        klas.Show()
        Hide()
    End Sub

    Private Sub txtBIzenAbi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBIzenAbi.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Function balidatuHutza() As Boolean
        Dim bal As Boolean = True
        If txtBIzenAbi.Text.Equals("") Then
            picBIzAb.Visible = True
            txtBIzenAbi.Focus()
            bal = False
        Else
            picBIzAb.Visible = False
        End If
        If txtBPas1.Text.Equals("") Then
            picBPas.Visible = True
            txtBPas1.Focus()
            bal = False
        Else
            picBPas.Visible = False
        End If
        If txtBErabIzena.Text.Equals("") Then
            picBErabIzn.Visible = True
            txtBErabIzena.Focus()
            bal = False
        Else
            picBErabIzn.Visible = False
        End If
        Return bal
    End Function

    Private Function datuakSartu() As Boolean
        Dim bal As Boolean = False
        If balidatuHutza() Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=192.168.13.33; database=ethazi_misifu; user id=root; port=3306")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim izAbEnc As String = txtBIzenAbi.Text
            Dim pshEnc As String = HasiSaioaLeihoa.AES_Encrypt(txtBPas1.Text, HasiSaioaLeihoa.kodEncDes)
            Dim eraIzEnc As String = txtBErabIzena.Text
            Dim myCommand As New MySqlCommand("insert into erabiltzaileak (izenAbizena, pasahitza, erabIzena) values ('" & izAbEnc & "', '" & pshEnc & "', '" & eraIzEnc & "')", konn)
            myCommand.ExecuteNonQuery()
            konn.Close()
            bal = True
        End If
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtBPas1.UseSystemPasswordChar = False
        Else
            txtBPas1.UseSystemPasswordChar = True
        End If
    End Sub
End Class