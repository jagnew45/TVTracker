Imports MySql.Data.MySqlClient

Public Class frmMain
    Dim conn As New MySqlConnection

    Public Sub connect()
        Dim DatabaseName As String = "tracker"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = "root1234"

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()
        Catch ex As Exception
        End Try
        Dim cmd As New MySqlCommand
        cmd.CommandText = "INSERT INTO SEASONS (show_id, season_id, ep_count) VALUES(1, 8, 99)"
        cmd.Connection = conn
        MsgBox(cmd.ExecuteNonQuery)
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connect()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddShow.Show()
        Me.Hide()
    End Sub
End Class
