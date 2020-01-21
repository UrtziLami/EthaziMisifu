Imports System.Windows
Imports MySql.Data.MySqlClient
Public Class Taulak
    Inherits System.Web.UI.Page
    Dim conn As MySqlConnection
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim wf1 As New WebForm1
    Shared taula As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnErabiltzaileak_Click1(sender As Object, e As EventArgs) Handles btnErabiltzaileak.Click
        Dim table As New DataTable
        taula = "erabiltzaileak"
        Try
            conn = New MySqlConnection("server=localhost; database=misifu; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql = "SELECT * FROM erabiltzaileak"
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

        For i = 0 To table.Rows.Count - 1
            table.Rows(i)("pasahitza") = wf1.AES_Decrypt(table.Rows(i)("pasahitza"), wf1.kodEnc)
        Next

        GridView1.DataSource = table
        GridView1.DataBind()
        Label1.Text = "ERABILTZAILEAK"
        btnInsertatu.Visible = True
        btnEzabatu.Visible = True
        btnAldatu.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        btnBilatu.Visible = True
    End Sub

    Protected Sub btnErreserbak_Click(sender As Object, e As EventArgs) Handles btnErreserbak.Click
        Dim table As New DataTable
        taula = "erreserbak"
        Try
            conn = New MySqlConnection("server=localhost; database=misifu; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql = "SELECT * FROM erreserbak"
        Dim cm = New MySqlCommand()
        cm.CommandText = sql
        cm.CommandType = CommandType.Text
        cm.Connection = conn
        Dim da = New MySqlDataAdapter(cm)

        ds = New DataSet()
        da.Fill(ds)

        table.Columns.Add(ds.Tables(0).Columns(0).ColumnName)
        table.Columns.Add("Erabiltzailea")
        table.Columns.Add("Alojamendua")

        For i = 0 To ds.Tables(0).Rows.Count - 1
            table.Rows.Add()
            For j = 0 To ds.Tables(0).Columns.Count - 1
                table.Rows(i)(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next
        Next

        For i = 0 To ds.Tables(0).Rows.Count - 1
            Dim sql2 = "SELECT izenAbizena FROM erabiltzaileak WHERE idBezeroak = " + ds.Tables(0).Rows(i)(1).ToString
            Dim cm2 = New MySqlCommand()
            cm.CommandText = sql2
            cm.CommandType = CommandType.Text
            cm.Connection = conn
            Dim da2 = New MySqlDataAdapter(cm)

            ds2 = New DataSet()
            da2.Fill(ds2)
            table.Rows(i)(1) = ds2.Tables(0).Rows(0)(0).ToString
        Next

        For i = 0 To ds.Tables(0).Rows.Count - 1
            Dim sql2 = "SELECT izena FROM ostatuak WHERE idAlojamenduak = " + ds.Tables(0).Rows(i)(2).ToString
            Dim cm2 = New MySqlCommand()
            cm.CommandText = sql2
            cm.CommandType = CommandType.Text
            cm.Connection = conn
            Dim da2 = New MySqlDataAdapter(cm)

            ds2 = New DataSet()
            da2.Fill(ds2)
            table.Rows(i)(2) = ds2.Tables(0).Rows(0)(0).ToString
        Next

        GridView1.DataSource = table
        GridView1.DataBind()
        Label1.Text = "ERRESERBAK"
        btnInsertatu.Visible = True
        btnEzabatu.Visible = True
        btnAldatu.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        btnBilatu.Visible = True
    End Sub

    Protected Sub btnOstatuak_Click(sender As Object, e As EventArgs) Handles btnOstatuak.Click
        Dim table As New DataTable
        taula = "ostatuak"
        Try
            conn = New MySqlConnection("server=localhost; database=misifu; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        Dim sql = "SELECT * FROM ostatuak"
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

        GridView1.DataSource = table
        GridView1.DataBind()
        Label1.Text = "OSTATUAK"
        btnInsertatu.Visible = True
        btnEzabatu.Visible = True
        btnAldatu.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        btnBilatu.Visible = True
    End Sub

    Protected Sub btnBilatu_Click(sender As Object, e As EventArgs) Handles btnBilatu.Click
        Dim table As New DataTable
        Dim konprobatu As Boolean = True
        Try
            conn = New MySqlConnection("server=localhost; database=misifu; user id=root; port=3306")
            conn.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar")
        End Try
        If TextBox1.Text <> "" Then
            Try
                Dim sql = "SELECT * FROM " + taula + " WHERE " + TextBox1.Text + " like '%" + TextBox2.Text + "%'"
                Dim cm = New MySqlCommand()
                cm.CommandText = sql
                cm.CommandType = CommandType.Text
                cm.Connection = conn
                Dim da = New MySqlDataAdapter(cm)

                ds = New DataSet()
                da.Fill(ds)
            Catch ex As Exception
                MsgBox("Zutabea txarto sartuta", vbCritical, "Txarto")
                konprobatu = False
            End Try

            If konprobatu = True Then
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

        Else
            MsgBox("Zutabea sartu", vbCritical, "Txarto")
        End If

    End Sub

    Protected Sub btnInsertatu_Click(sender As Object, e As EventArgs) Handles btnInsertatu.Click
        If taula = "erabiltzaileak" Then
            Response.Redirect("InsertatuErabiltzailea.aspx")
        End If
        If taula = "erreserbak" Then
            Response.Redirect("InsertatuErreserba.aspx")
        End If
        If taula = "ostatuak" Then
            Response.Redirect("InsertatuOstatua.aspx")
        End If
    End Sub

    Protected Sub btnAldatu_Click(sender As Object, e As EventArgs) Handles btnAldatu.Click
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
        If taula = "erabiltzaileak" Then
            Response.Redirect("EzabatuErabiltzailea.aspx")
        End If
        If taula = "erreserbak" Then
            Response.Redirect("EzabatuErreserba.aspx")
        End If
        If taula = "ostatuak" Then
            Response.Redirect("EzabatuOstatua.aspx")
        End If
    End Sub
End Class