Imports MySql.Data.MySqlClient

Public Class frmSeasonInfo
    Dim i As Integer
    Dim list As New ArrayList
    Dim curr_showid As Integer

    Dim conn As New MySqlConnection

    Public Sub connect()
        Dim DatabaseName As String = "tv_tracker"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = "root1234"

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()
            'MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub


    Private Sub frmSeasonInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialises the array counter
        i = 0

        lblSeasonsRem.Text = lblTotal.Text

        'initialise season number to enter
        lblSeasonNum.Text = 1

        'initialise show ID
        curr_showid = lblShowID.Text

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
        '----------------------------------------------------------------------
        'PRIVATE VARIABLES
        Dim j As Integer
        Dim last_rec As Boolean
        Dim seasonNumber As Integer

        'INITIALISE VARIABLES
        j = 0
        last_rec = False
        '----------------------------------------------------------------------

        'if validation is successful, store values in arraylist
        If validate() = True Then




            '----------------------------------------------------------------------
            'convert string to int and store in j variable
            Integer.TryParse(lblSeasonsRem.Text, j)


            '----------------------------------------------------------------------

            'Values read in on one line (can be immediately used for INSERT - just need to add show_id to the front)
            list.Add(lblSeasonNum.Text & ", " & txtEpisodeCount.Text)
            'increment array counter for every season entered into the list
            i = i + 1

            'Clear the Episodes in Season text box and set focus to the text box
            txtEpisodeCount.Text = ""
            txtEpisodeCount.Focus()

            'Decrement Seasons Remaining
            lblSeasonsRem.Text = j - 1

            'Determines if there is more season information to be added
            If lblSeasonsRem.Text = 0 Then
                'if there are no more seasons, indicate it is the last record
                last_rec = True

                'Enable proceed button
                btnProceed.Enabled = True

                're-colour the proceed button to appear highlighted
                btnProceed.BackColor = Color.PaleGreen

                'Disable text box and Season Number label
                txtEpisodeCount.Enabled = False
                lblSeasonNum.Text = ""
                btnAddInfo.Enabled = False

            Else
                'If there are more seasons to be added

                'Increment the Season Number field
                Int32.TryParse(lblSeasonNum.Text, seasonNumber)
                lblSeasonNum.Text = seasonNumber + 1

            End If


            'If last_rec is true, then the user can proceed
            'Upon proceed - INSERT all the list values into the table
            'Then proceed to the next screen --> show confirmation message --> show options (display show in list, add another show, return to home screen
        End If
    End Sub


    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'NOTE*** This should be a collective insert loop once the user is ready to proceed
        Dim line As String
        Dim insertCount As Integer
        Dim seasonFocus, epCountFocus As Integer
        insertCount = 0

        For Each line In list
            MsgBox(line)

            'Extract each part of the line into array (parts), splitting on the comma
            Dim parts As String() = line.Split(New Char() {","c})

            'For first element, convert to Int and store in seasonFocus
            Integer.TryParse(parts(0), seasonFocus)

            'For second element, convery to Int and store in epCountFocus
            Integer.TryParse(parts(1), epCountFocus)


            connect()

            Try
                conn.Open()
            Catch ex As Exception
            End Try

            Dim cmd As New MySqlCommand

            cmd.CommandText = "INSERT INTO SEASONS (show_id, season_id, ep_count)
                                VALUES(" & curr_showid & ", " & seasonFocus & ", " & epCountFocus & ")"
            cmd.Connection = conn
            MsgBox(cmd.CommandText)
            MsgBox(cmd.ExecuteNonQuery)
            MsgBox("Row Inserted Successfully :)")
            insertCount = insertCount + 1

        Next
        MsgBox("Insert Count = " & insertCount)

        'INSERT ...

        'ONly once the inserts are successful, should this proceed the user to the next screen... confirmation?
        'If you're doing a confrimation screen, then all of the data should be stored in variables until it is confirmed...

        'frmAddShow.Show()
        'Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Clear list
        list.Clear()

        'Clear variables
        i = 0
        curr_showid = vbNull

        'Return to the Show page
        frmAddShow.Show()
        Me.Close()
    End Sub
End Class