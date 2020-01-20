Imports MySql.Data.MySqlClient
Public Class DatuakAldatuErab

    Dim izenAb As String
    Dim pasa As String
    Dim IDBe As String
    Dim era As String
    Dim konn As MySqlConnection
    Public Sub datuak(izAbi As String, pash As String, id As String, erab As String)
        izenAb = izAbi
        pasa = pash
        IDBe = id
        era = erab
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
    Private Sub datuakAldatu()
        If balidatuHutza() Then
            Try
                'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommand As New MySqlCommand("update erabiltzaileak set izenAbizena = '" & HasiSaioaLeihoa.AES_Encrypt(txtBIzenAbi.Text, HasiSaioaLeihoa.kodEncDes) & "', pasahitza = '" & HasiSaioaLeihoa.AES_Encrypt(txtBPas1.Text, HasiSaioaLeihoa.kodEncDes) & "', erabIzena = '" & HasiSaioaLeihoa.AES_Encrypt(txtBErabIzena.Text, HasiSaioaLeihoa.kodEncDes) & "' where idBezeroak = " & IDBe, konn)
            myCommand.ExecuteNonQuery()
            konn.Close()
            Dim lei As New ErabiltzaileLeihoa
            lei.Show()
            Hide()
        Else
            MessageBox.Show("Datuak txarto daude.")
        End If
    End Sub
    Private Sub DatuakAldatuErab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBIzenAbi.Text = izenAb
        txtBPas1.Text = pasa
        txtBErabIzena.Text = era
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub btnGorde_Click(sender As Object, e As EventArgs) Handles btnGorde.Click
        datuakAldatu()
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
End Class