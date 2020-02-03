Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class Taulak
    Inherits System.Web.UI.Page
    Dim conn As MySqlConnection
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim wf1 As New Login
    Shared kont As Integer
    Shared taula As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim konprobatu As Boolean = True
        Dim i As Integer = 0

        Try
            conn = New MySqlConnection("server=192.168.13.33; database=" + wf1.bd + "; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            konprobatu = False
            MessageBox.Show("No se ha podido conectar")
        End Try
        If kont = 0 Then
            If konprobatu = True Then
                'Dim sql = "SELECT * FROM " + taula
                'Dim cm = New MySqlCommand()
                'cm.CommandText = sql
                'cm.CommandType = CommandType.Text
                'cm.Connection = conn
                'Dim da = New MySqlDataAdapter(cm)

                'ds3 = New DataSet()
                'da.Fill(ds3)

                'For i = 0 To ds.Tables(0).Columns.Count - 1
                'DropDownList1.Items.Insert(i, ds.Tables(0).Columns(i).ColumnName)
                'i = i + 1

                If taula = "erabiltzaileak" Then
                    btnErabiltzaileak_Click1(sender, e)
                ElseIf taula = "erreserbak" Then
                    btnErreserbak_Click(sender, e)
                ElseIf taula = "ostatuak" Then
                    btnOstatuak_Click(sender, e)
                End If

            End If
        End If
        kont = kont + 1

        conn.Close()
    End Sub

    Protected Sub btnErabiltzaileak_Click1(sender As Object, e As EventArgs) Handles btnErabiltzaileak.Click
        Dim table As New DataTable
        DropDownList1.Items.Clear()
        taula = "erabiltzaileak"

        Dim sql = "SELECT * FROM erabiltzaileak WHERE erabIzena = '" + wf1.erabiltzailea.ToString + "'"
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)

        For i = 0 To ds.Tables(0).Columns.Count - 1
            DropDownList1.Items.Insert(i, ds.Tables(0).Columns(i).ColumnName)
            table.Columns.Add(ds.Tables(0).Columns(i).ColumnName)
        Next

        For i = 0 To ds.Tables(0).Rows.Count - 1
            table.Rows.Add()
            For j = 0 To ds.Tables(0).Columns.Count - 1
                table.Rows(i)(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
        Next

        For i = 0 To table.Rows.Count - 1
            table.Rows(i)("pasahitza") = wf1.AES_Decrypt(table.Rows(i)("pasahitza"), wf1.kodEnc)
        Next

        GridView1.DataSource = table
        GridView1.DataBind()
        LabelTaula.Text = "ZURE ERABILTZAILEA"
        btnInsertatu.Visible = False
        btnEzabatu.Visible = True
        btnAldatu.Visible = True
        LabelFiltroa.Visible = True
        LabelZutabea.Visible = True
        LabelDatua.Visible = True
        DropDownList1.Visible = True
        TextBoxDatua.Visible = True
        btnBilatu.Visible = True
        conn.Close()
    End Sub

    Protected Sub btnErreserbak_Click(sender As Object, e As EventArgs) Handles btnErreserbak.Click
        Dim table As New DataTable
        DropDownList1.Items.Clear()
        taula = "erreserbak"

        Dim sql = "SELECT idErreserba, Ostatuak_sinadura, sartuData, ateraData FROM erreserbak WHERE Erabiltzaileak_idBezeroak = (SELECT idBezeroak FROM erabiltzaileak WHERE erabIzena = '" + wf1.erabiltzailea.ToString + "')"
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)

        DropDownList1.Items.Insert(0, ds.Tables(0).Columns(0).ColumnName)
        DropDownList1.Items.Insert(1, "Alojamendua")
        DropDownList1.Items.Insert(2, ds.Tables(0).Columns(2).ColumnName)
        DropDownList1.Items.Insert(3, ds.Tables(0).Columns(3).ColumnName)

        table.Columns.Add(ds.Tables(0).Columns(0).ColumnName)
        table.Columns.Add("Alojamendua")
        table.Columns.Add(ds.Tables(0).Columns(2).ColumnName)
        table.Columns.Add(ds.Tables(0).Columns(3).ColumnName)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            table.Rows.Add()
            For j = 0 To ds.Tables(0).Columns.Count - 1
                table.Rows(i)(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
        Next

        For i = 0 To ds.Tables(0).Rows.Count - 1
            Dim sql2 = "SELECT izena FROM ostatuak WHERE sinadura = '" + ds.Tables(0).Rows(i)(1).ToString + "'"
            Dim cm2 = New MySqlCommand()
            cm.CommandText = sql2
            cm.CommandType = CommandType.Text
            cm.Connection = conn
            Dim da2 = New MySqlDataAdapter(cm)

            ds2 = New DataSet()
            da2.Fill(ds2)
            table.Rows(i)(1) = ds2.Tables(0).Rows(0)(0).ToString
        Next


        GridView1.DataSource = table
        GridView1.DataBind()
        LabelTaula.Text = "ERRESERBAK"
        btnInsertatu.Visible = True
        btnEzabatu.Visible = True
        btnAldatu.Visible = True
        LabelFiltroa.Visible = True
        LabelZutabea.Visible = True
        LabelDatua.Visible = True
        DropDownList1.Visible = True
        TextBoxDatua.Visible = True
        btnBilatu.Visible = True
        conn.Close()
    End Sub

    Protected Sub btnOstatuak_Click(sender As Object, e As EventArgs) Handles btnOstatuak.Click
        Dim table As New DataTable
        DropDownList1.Items.Clear()
        taula = "ostatuak"

        Dim sql = "SELECT * FROM ostatuak"
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)

        For i = 0 To ds.Tables(0).Columns.Count - 1
            DropDownList1.Items.Insert(i, ds.Tables(0).Columns(i).ColumnName)
            table.Columns.Add(ds.Tables(0).Columns(i).ColumnName)
        Next

        For i = 0 To ds.Tables(0).Rows.Count - 1
            table.Rows.Add()
            For j = 0 To ds.Tables(0).Columns.Count - 1
                table.Rows(i)(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
        Next

        GridView1.DataSource = table
        GridView1.DataBind()
        LabelTaula.Text = "OSTATUAK"
        btnInsertatu.Visible = False
        btnEzabatu.Visible = False
        btnAldatu.Visible = False
        LabelFiltroa.Visible = True
        LabelZutabea.Visible = True
        LabelDatua.Visible = True
        DropDownList1.Visible = True
        TextBoxDatua.Visible = True
        btnBilatu.Visible = True
        conn.Close()
    End Sub

    Protected Sub btnBilatu_Click(sender As Object, e As EventArgs) Handles btnBilatu.Click
        Dim table As New DataTable
        Dim konprobatu As Boolean = True
        Dim zutabea As String
        zutabea = DropDownList1.SelectedItem.ToString()

        If taula = "erreserbak" Then
            If DropDownList1.SelectedItem.ToString = "Alojamendua" Then
                zutabea = "Ostatuak_sinadura"
            End If
            If TextBoxDatua.Text = "" Then
                btnErreserbak_Click(sender, e)
            Else
                Dim sql = "SELECT idErreserba, Ostatuak_sinadura, sartuData, ateraData FROM " + taula + " WHERE " + zutabea + " = (SELECT sinadura FROM ostatuak WHERE izena like '%" + TextBoxDatua.Text + "%')"
                Dim cm = New MySqlCommand()
                cm.CommandText = sql
                cm.CommandType = CommandType.Text
                cm.Connection = conn
                Dim da = New MySqlDataAdapter(cm)

                ds = New DataSet()
                da.Fill(ds)

                table.Columns.Add(ds.Tables(0).Columns(0).ColumnName)
                table.Columns.Add("Alojamendua")
                table.Columns.Add(ds.Tables(0).Columns(2).ColumnName)
                table.Columns.Add(ds.Tables(0).Columns(3).ColumnName)

                For i = 0 To ds.Tables(0).Rows.Count - 1
                    table.Rows.Add()
                    For j = 0 To ds.Tables(0).Columns.Count - 1
                        table.Rows(i)(j) = ds.Tables(0).Rows(i)(j).ToString()
                    Next
                Next

                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Dim sql2 = "SELECT izena FROM ostatuak WHERE sinadura = '" + ds.Tables(0).Rows(i)(1).ToString + "'"
                    Dim cm2 = New MySqlCommand()
                    cm.CommandText = sql2
                    cm.CommandType = CommandType.Text
                    cm.Connection = conn
                    Dim da2 = New MySqlDataAdapter(cm)

                    ds2 = New DataSet()
                    da2.Fill(ds2)
                    table.Rows(i)(1) = ds2.Tables(0).Rows(0)(0).ToString
                Next
                GridView1.DataSource = table
                GridView1.DataBind()
            End If

        Else
            Dim sql = "SELECT * FROM " + taula + " WHERE " + zutabea + " like '%" + TextBoxDatua.Text + "%'"
            Dim cm = New MySqlCommand()
            cm.CommandText = sql
            cm.CommandType = CommandType.Text
            cm.Connection = conn
            Dim da = New MySqlDataAdapter(cm)

            ds = New DataSet()
            da.Fill(ds)

            For i = 0 To ds.Tables(0).Columns.Count - 1
                table.Columns.Add(ds.Tables(0).Columns(i).ColumnName)
            Next

            For i = 0 To ds.Tables(0).Rows.Count - 1
                table.Rows.Add()
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    table.Rows(i)(j) = ds.Tables(0).Rows(i)(j).ToString()
                Next
            Next

            If taula = "erabiltzaileak" Then
                For i = 0 To table.Rows.Count - 1
                    table.Rows(i)("pasahitza") = wf1.AES_Decrypt(table.Rows(i)("pasahitza"), wf1.kodEnc)
                Next
            End If

            GridView1.DataSource = table
            GridView1.DataBind()
        End If


        conn.Close()
    End Sub

    Protected Sub btnInsertatu_Click(sender As Object, e As EventArgs) Handles btnInsertatu.Click
        kont = 0
        If taula = "erreserbak" Then
            Response.Redirect("InsertatuErreserba.aspx")
        End If
        If taula = "ostatuak" Then
            Response.Redirect("InsertatuOstatua.aspx")
        End If
    End Sub

    Protected Sub btnAldatu_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
        kont = 0
        If taula = "erabiltzaileak" Then
            Response.Redirect("AldatuErabiltzailea.aspx")
        End If
        If taula = "erreserbak" Then
            Response.Redirect("AldatuErreserba.aspx")
        End If
        If taula = "ostatuak" Then
            Response.Redirect("AldatuOstatua.aspx")
        End If
    End Sub

    Protected Sub btnEzabatu_Click(sender As Object, e As EventArgs) Handles btnEzabatu.Click
        kont = 0
        If taula = "erabiltzaileak" Then
            If MsgBox("Erabiltzailea ezabatu nahi duzu?", vbYesNo, "Ezabatu?") = 6 Then
                Dim cm3 = New MySqlCommand()
                cm3.CommandText = "DELETE FROM erabiltzailea WHERE erabIzena = '" + wf1.erabiltzailea.ToString + "'"
                cm3.Connection = conn
                cm3.ExecuteNonQuery()
                conn.Close()
                taula = ""
                Response.Redirect("Login.aspx")
            End If
        End If
        If taula = "erreserbak" Then
            Response.Redirect("EzabatuErreserba.aspx")
        End If
        If taula = "ostatuak" Then
            Response.Redirect("EzabatuOstatua.aspx")
        End If
    End Sub

    Protected Sub btnIrten_Click(sender As Object, e As EventArgs) Handles btnIrten.Click
        taula = ""
        Response.Redirect("Login.aspx")
    End Sub

End Class