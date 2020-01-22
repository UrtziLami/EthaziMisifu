Imports MySql.Data.MySqlClient
Public Class ErreserbaSartu
    Dim konn As MySqlConnection
    Dim aterData As String
    Dim sartuData As String
    Private Sub datuakAldatu()
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim erab As String = cmBErab.SelectedItem.ToString
        Dim ostatu As String = cmBOst.SelectedItem.ToString
        sartuData = mCSart.SelectionRange.Start.ToShortDateString
        aterData = mCIrte.SelectionRange.Start.ToShortDateString
        Dim myCommand As New MySqlCommand("insert into erreserbak (Ostatuak_sinadura, Erabiltzaileak_idBezeroak, sartuData, ateraData) values ('" & ostatu & "', '" & erab & "', '" & sartuData & "', '" & aterData & "')", konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub btnSartu_Click(sender As Object, e As EventArgs) Handles btnSartu.Click
        datuakAldatu()
        Dim lei As New ErreserbaLeihoa
        lei.Show()
        Hide()
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Dim klas As New ErreserbaLeihoa
        klas.Show()
        Hide()
    End Sub

    Private Sub mCSart_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mCSart.DateChanged
        mCIrte.MinDate = mCSart.SelectionStart
    End Sub


    Private Sub txtBErab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBOsta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub ostatuakAtera()
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("select sinadura from ostatuak", konn)
        Dim dr As MySqlDataReader
        dr = komand.ExecuteReader
        While dr.Read
            cmBOst.Items.Add(dr(0).ToString)
        End While
        dr.Close()
        konn.Close()
    End Sub
    Private Sub erabiltzaileakAtera()
        Try
            'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim komand As New MySqlCommand("select idBezeroak from erabiltzaileak", konn)
        Dim dr As MySqlDataReader
        dr = komand.ExecuteReader
        While dr.Read
            cmBErab.Items.Add(dr(0).ToString)
        End While
        dr.Close()
        konn.Close()
    End Sub
    Private Sub ErreserbaSartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        erabiltzaileakAtera()
        ostatuakAtera()
        mCIrte.MinDate = mCSart.SelectionStart
        mCSart.MinDate = Today
    End Sub
End Class