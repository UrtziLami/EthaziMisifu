Imports MySql.Data.MySqlClient
Public Class DatuakAldatuErre
    Private Sub DatuakAldatuErre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        erabiltzaileakAtera()
        ostatuakAtera()
        cmbBOsta.SelectedText = ostatua
        cmbBerab.SelectedText = erabiltzailea
        mCIrte.MinDate = mCSart.SelectionStart
        mCSart.MinDate = Today
        mCSart.SetDate(sartze)
        mCIrte.SetDate(irtetze)
    End Sub

    Dim erabiltzailea As String
    Dim ostatua As String
    Dim IDErre As String
    Dim sartze As DateTime
    Dim irtetze As DateTime
    Dim konn As MySqlConnection
    Public Sub datuak(erab As String, ost As String, iderr As String, sart As DateTime, irt As DateTime)
        erabiltzailea = erab
        ostatua = ost
        IDErre = iderr
        sartze = sart
        irtetze = irt
    End Sub
    Private Sub datuakAldatu()
        Try
            'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("update erreserbak set Erabiltzaileak_idBezeroak = '" & cmbBerab.SelectedText & "', Ostatuak_sinadura = '" & cmbBOsta.SelectedText & "', sartuData = '" & mCSart.SelectionStart & "', ateraData = '" & mCIrte.SelectionStart & "' where idErreserba = " & IDErre, konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
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
            cmbBOsta.Items.Add(dr(0).ToString)
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
            cmbBerab.Items.Add(dr(0).ToString)
        End While
        dr.Close()
        konn.Close()
    End Sub

    Private Sub btnGorde_Click(sender As Object, e As EventArgs) Handles btnGorde.Click
        datuakAldatu()
        Dim lei As New ErabiltzaileLeihoa
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
End Class