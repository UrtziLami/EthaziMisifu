Imports MySql.Data.MySqlClient
Public Class DatuakAldatuOst
    Dim izena As String
    Dim idOs As String
    Dim deskb As String
    Dim udalerri As String
    Dim probintzia As String
    Dim email As String
    Dim telefonoa As String
    Dim web As String
    Dim latit As String
    Dim longi As String
    Dim konn As MySqlConnection

    Public Sub datuak(iz As String, des As String, ud As String, pro As String, em As String, tel As String, we As String, id As String, lat As String, lon As String)
        izena = iz
        deskb = des
        udalerri = ud
        probintzia = pro
        email = em
        telefonoa = tel
        web = we
        idOs = id
        latit = lat
        longi = lon
    End Sub
    Private Sub btnGorde_Click(sender As Object, e As EventArgs) Handles btnGorde.Click
        datuakAldatu()
        Dim lei As New OstatuLeiho
        lei.Show()
        Hide()
    End Sub
    Private Function balidatuEmail(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function
    Private Sub datuakAldatu()
        If balidatuEmail(txtBEmail.Text) Then
            Try
                'konn = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim myCommand As New MySqlCommand("update ostatuak set izena = '" & txtBIzena.Text & "', deskribapena = '" & RtxtBDesk.Text & "', udalerri = '" & txtBUdalerri.Text & "', probintzia'" & txtBProbintzia.Text & "', email = '" & txtBEmail.Text & "', telefonoa = '" & txtBTelefonoa.Text & "', web = '" & txtBWeb.Text & "', longitudea = '" & txtBLon.Text & "', latitudea = '" & txtBLat.Text & "' where idOstatuak = " & idOs, konn)
            myCommand.ExecuteNonQuery()
            konn.Close()
        Else
            MessageBox.Show("Email-a txarto dago.")
        End If
    End Sub
    Private Sub DatuakAldatuOst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtxtBDesk.Text = deskb
        txtBEmail.Text = email
        txtBIzena.Text = izena
        txtBProbintzia.Text = probintzia
        txtBTelefonoa.Text = telefonoa
        txtBWeb.Text = web
        txtBUdalerri.Text = udalerri
        txtBLat.Text = latit
        txtBLon.Text = longi
    End Sub
    Private Sub txtBIzena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBIzena.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtBProbintzia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBProbintzia.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtBUdalerri_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBUdalerri.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtBTelefonoa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBTelefonoa.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Dim klas As New OstatuLeiho
        klas.Show()
        Hide()
    End Sub

    Private Sub txtBTelefonoa_TextChanged(sender As Object, e As EventArgs) Handles txtBTelefonoa.TextChanged

    End Sub
End Class