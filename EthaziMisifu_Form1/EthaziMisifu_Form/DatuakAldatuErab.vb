Imports MySql.Data.MySqlClient
Public Class DatuakAldatuErab

    Dim izenAb As String
    Dim pasa As String
    Dim IDBe As String
    Dim konn As MySqlConnection
    Public Sub datuak(izAbi As String, pash As String, id As String)
        izenAb = izAbi
        pasa = pash
        IDBe = id
    End Sub
    Private Sub datuakAldatu()
        Try
            'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
            konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
            konn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
        Dim myCommand As New MySqlCommand("update erabiltzaileak set izenAbizena = '" & HasiSaioaLeihoa.AES_Encrypt(txtBIzenAbi.Text, HasiSaioaLeihoa.kodEncDes) & "', pasahitza = '" & HasiSaioaLeihoa.AES_Encrypt(txtBPas1.Text, HasiSaioaLeihoa.kodEncDes) & "' where idBezeroak = " & IDBe, konn)
        myCommand.ExecuteNonQuery()
        konn.Close()
    End Sub
    Private Sub DatuakAldatuErab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBIzenAbi.Text = izenAb
        txtBPas1.Text = pasa
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
        Dim klas As New ErabiltzaileLeihoa
        klas.Show()
        Hide()
    End Sub
End Class