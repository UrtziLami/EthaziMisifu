Imports MySql.Data.MySqlClient
Public Class DatuakAldatuErre
    Private Sub DatuakAldatuErre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBErab.Text = erabiltzailea
        txtBOsta.Text = ostatua
    End Sub

    Dim erabiltzailea As String
    Dim ostatua As String
    Dim IDErre As String
    Dim konn As MySqlConnection
    Public Sub datuak(erab As String, ost As String, iderr As String)
        erabiltzailea = erab
        ostatua = ost
        IDErre = iderr
    End Sub
    Private Sub txtBErab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBErab.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub balidatuDatuak()

    End Sub

    Private Sub datuakAldatu()
        Try
            'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("update erreserbak set Erabiltzaileak_idBezeroak = '" & txtBErab.Text & "', Alojamenduak_idAlojamenduak = '" & txtBOsta.Text & "' where idReservas = " & IDErre, konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
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
End Class