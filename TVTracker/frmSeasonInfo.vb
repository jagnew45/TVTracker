Public Class frmSeasonInfo
    Dim i As Integer
    Dim list As New ArrayList

    Private Sub frmSeasonInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialises the array counter
        i = 0
    End Sub

    Private Function validate() As Boolean

        Dim msg As String
        Dim result As Boolean = True
        msg = "The form cannot submit until the following errors are fixed: " + vbNewLine

        'Validate Season Number
        If txtSeasonNum.Text = "" Then
            msg = msg + "Season Number must have a value" + vbNewLine
            result = False
        ElseIf txtSeasonNum.Text <> "" And IsNumeric(txtSeasonNum.Text) = False Then
            msg = msg + "Season Number must be a number" + vbNewLine
            result = False
        End If

        'Validate Episode Count
        If txtEpisodeCount.Text = "" Then
            msg = msg + "Episodes in Season must have a value" + vbNewLine
            result = False
        ElseIf txtSeasonNum.Text <> "" And IsNumeric(txtEpisodeCount.Text) = False Then
            msg = msg + "Episodes in Season must be a number" + vbNewLine
            result = False
        End If

        If result = False Then
            MsgBox(msg)
        End If
        Return result
    End Function


    Private Sub btnAddInfo_Click(sender As Object, e As EventArgs) Handles btnAddInfo.Click
        'if validation is successful, store values in arraylist
        If validate() = True Then
            list.Add(txtSeasonNum.Text & ", " & txtEpisodeCount.Text) 'Values read in on one line (can be immediately used for INSERT - just need to add show_id to the front)
        End If
        Dim line As String
        For Each line In list
            MsgBox(line)
        Next

    End Sub

    Private Sub btnReturntoAdd_Click(sender As Object, e As EventArgs) Handles btnReturntoAdd.Click
        frmAddShow.Show()
        Me.Close()
    End Sub


End Class