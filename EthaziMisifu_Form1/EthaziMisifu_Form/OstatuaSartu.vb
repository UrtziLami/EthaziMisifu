Imports MySql.Data.MySqlClient
Public Class OstatuaSartu
    Dim konn As MySqlConnection
    Private Sub btnSartu_Click(sender As Object, e As EventArgs) Handles btnSartu.Click
        If balidatuEmail(txtBEmail.Text) And balidatuHutza() Then
            Try
                'conexion = New MySqlConnection("server=fdb22.runhosting.com; database=2831276_12345678; user id=2831276_12345678; password=a@12345678; port=3306")
                konn = New MySqlConnection("server=localhost; database=ethazi_misifu; user id=root; port=3306")
                konn.Open()
            Catch ex As MySqlException
                MessageBox.Show("No se ha podido conectar al servidor")
            End Try
            Dim sin As String = txtBSinadura.Text
            Dim ize As String = txtBIzena.Text
            Dim email As String = txtBEmail.Text
            Dim udalerri As String = txtBUdalerri.Text
            Dim probintzia As String = txtBProbintzia.Text
            Dim desk As String = RtxtBDesk.Text
            Dim web As String = txtBWeb.Text
            Dim lat As String = txtBLat.Text
            Dim lon As String = txtBLon.Text
            Dim telf As String = txtBTelefonoa.Text
            Dim myCommand As New MySqlCommand("insert into ostatuak values ('" & sin & "', '" & ize & "', '" & desk & "', '" & udalerri & "', '" & probintzia & "', '" & email & "', '" & telf & "', '" & web & "', '" & lon & "', '" & lat & "')", konn)
            myCommand.ExecuteNonQuery()
            konn.Close()
            Dim lei As New OstatuLeiho
            lei.Show()
            Hide()
            txtBEmail.BackColor = Color.White
        Else
            txtBEmail.BackColor = Color.Red
            MessageBox.Show("Datuak txarto dago.")
        End If
    End Sub
    Private Function balidatuHutza() As Boolean
        Dim bal As Boolean = True
        If txtBIzena.Text.Equals("") Then
            txtBIzena.BackColor = Color.Red
            bal = False
        Else
            txtBIzena.BackColor = Color.White
        End If
        If txtBProbintzia.Text.Equals("") Then
            txtBProbintzia.BackColor = Color.Red
            bal = False
        Else
            txtBProbintzia.BackColor = Color.White
        End If
        If txtBSinadura.Text.Equals("") Then
            txtBSinadura.BackColor = Color.Red
            bal = False
        Else
            txtBSinadura.BackColor = Color.White
        End If
        If txtBUdalerri.Text.Equals("") Then
            txtBUdalerri.BackColor = Color.Red
            bal = False
        Else
            txtBUdalerri.BackColor = Color.White
        End If
        If txtBLat.Text.Equals("") Then
            txtBLat.BackColor = Color.Red
            bal = False
        Else
            txtBLat.BackColor = Color.White
        End If
        If txtBLon.Text.Equals("") Then
            txtBLon.BackColor = Color.Red
            bal = False
        Else
            txtBLon.BackColor = Color.White
        End If
        If RtxtBDesk.Text.Equals("") Then
            RtxtBDesk.BackColor = Color.Red
            bal = False
        Else
            RtxtBDesk.BackColor = Color.White
        End If
        If txtBWeb.Text.Equals("") Then
            txtBWeb.BackColor = Color.Red
            bal = False
        Else
            txtBWeb.BackColor = Color.White
        End If
        If txtBTelefonoa.Text.Equals("") Or txtBTelefonoa.Text.Length < 9 Then
            txtBTelefonoa.BackColor = Color.Red
            bal = False
        Else
            txtBTelefonoa.BackColor = Color.White
        End If
        Return bal
    End Function
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
    Private Sub txtBLat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBLat.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtBLon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBLon.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
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
    Private Function balidatuEmail(strEmail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(strEmail, "^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" & "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")
    End Function

    Private Sub OstatuaSartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBTelefonoa.MaxLength = 9
        txtBSinadura.MaxLength = 8
    End Sub
End Class