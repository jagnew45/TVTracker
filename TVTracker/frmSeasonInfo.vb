Public Class frmSeasonInfo
    Dim i As Integer
    Dim list As New ArrayList

    Private Sub frmSeasonInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialises the array counter
        i = 0

        lblSeasonsRem.Text = lblTotal.Text
    End Sub

    Private Overloads Function validate() As Boolean
        Dim msg As String
        Dim result As Boolean = True
        msg = "The form cannot submit until the following errors are fixed: " + vbNewLine

        'Validate Episode Count
        If txtEpisodeCount.Text = "" Then
            msg = msg + "Episodes in Season must have a value" + vbNewLine
            result = False
        ElseIf txtEpisodeCount.Text <> "" And IsNumeric(txtEpisodeCount.Text) = False Then
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
            'Values read in on one line (can be immediately used for INSERT - just need to add show_id to the front)
            list.Add(lblSeasonNum.Text & ", " & txtEpisodeCount.Text)



            'IF SUCCESSFUL
            'Decrement Seasons Remaining
            Dim j As Integer
            Integer.TryParse(lblSeasonsRem.Text, j)
            lblSeasonsRem.Text = j - 1

        End If
    End Sub


    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'NOTE*** This should be a collective insert loop once the user is ready to proceed
        Dim line As String
        For Each line In List
            MsgBox(line)
            'INSERT ...
        Next

        'ONly once the inserts are successful, should this proceed the user to the next screen... confirmation?
        'If you're doing a confrimation screen, then all of the data should be stored in variables until it is confirmed...

        frmAddShow.Show()
        Me.Close()
    End Sub


End Class