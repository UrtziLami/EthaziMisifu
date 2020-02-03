Public Class KudeaketaLeihoa
    Private Sub btnAlojamendu_Click(sender As Object, e As EventArgs) Handles btnAlojamendu.Click
        Dim a As New OstatuLeiho
        a.Show()
        Hide()
    End Sub

    Private Sub btnErabiltzaile_Click(sender As Object, e As EventArgs) Handles btnErabiltzaile.Click
        Dim era As New ErabiltzaileLeihoa
        era.Show()
        Hide()
    End Sub

    Private Sub btnErreserba_Click(sender As Object, e As EventArgs) Handles btnErreserba.Click
        Dim err As New ErreserbaLeihoa
        err.Show()
        Hide()
    End Sub

    Private Sub btnAtzera_Click(sender As Object, e As EventArgs) Handles btnAtzera.Click
        Dim has As New HasiSaioaLeihoa
        has.Show()
        Hide()
    End Sub
    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub
End Class