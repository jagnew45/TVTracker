Imports MySql.Data.MySqlClient

Public Class frmAddShow
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

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the form
        txtShowName.Text = ""
        cboAirDay.SelectedIndex = -1
        cboAirStatus.SelectedIndex = -1
        cboDuration.SelectedIndex = -1
        cboNetwork.SelectedIndex = -1
        cboStreamServ.SelectedIndex = -1
        dtpReturn.Value = Date.Now()
        dtpFinale.Value = Date.Now()
        txtIMDBID.Text = ""
        txtCurrSeason.Text = ""
        txtCurrEpisode.Text = ""
        txtTotalSeasons.Text = ""
        txtTotalEpisodes.Text = ""
        cboWatchStat.SelectedIndex = -1

        radRetDateYes.Checked = False
        radRetDateNo.Checked = False
        radFinDateYes.Checked = False
        radFinDateNo.Checked = False

        dtpFinale.Visible = False
        dtpFinale.Location = New Point(75, 75)
        panFinDate.Size = New System.Drawing.Size(300, 40)

        dtpReturn.Visible = False
        dtpReturn.Location = New Point(75, 75)
        panRetDate.Size = New System.Drawing.Size(300, 40)
        panFinDate.Location = New Point(420, 410)

    End Sub

    Private Function validateForm() As Boolean
        Dim msg As String
        Dim result As Boolean
        result = True
        msg = "The form cannot submit until the following errors are fixed: " + vbNewLine

        If txtShowName.Text = "" Then
            msg = msg + "Show Name cannot be empty" + vbNewLine
            result = False
        End If

        If cboAirDay.Text = "" Then
            msg = msg + "Air Day cannot be empty" + vbNewLine
            result = False
        End If

        If cboAirStatus.Text = "" Then
            msg = msg + "Air Status cannot be empty" + vbNewLine
            result = False
        End If

        If cboDuration.Text = "" Then
            msg = msg + "Duration cannot be empty" + vbNewLine
            result = False
        End If

        If cboNetwork.Text = "" Then
            msg = msg + "Network cannot be empty" + vbNewLine
            result = False
        End If

        If cboStreamServ.Text = "" Then
            msg = msg + "Streaming Service cannot be empty" + vbNewLine
            result = False
        End If

        'IMDb ID can be null, but if it has a value, it MUST be 9 characters long
        If txtIMDBID.Text <> "" Then
            If txtIMDBID.TextLength < 9 Then
                msg = msg + "IMDb ID cannot be shorter than 9 characters" + vbNewLine
                result = False
            End If
        End If

        'Season Up To can be null, but if it has a value, it MUST be numerical
        If txtCurrSeason.Text <> "" Then
            If IsNumeric(txtCurrSeason.Text) = False Then
                msg = msg + "Season Up To MUST be a NUMBER" + vbNewLine
                result = False
            End If
        End If

        'Episode Up To can be null, but if it has a value, it MUST be numerical
        If txtCurrEpisode.Text <> "" Then
            If IsNumeric(txtCurrEpisode.Text) = False Then
                msg = msg + "Episode Up To MUST be a NUMBER" + vbNewLine
                result = False
            End If
        End If

        'Total Seasons can be null, but if it has a value, it MUST be numerical
        If txtTotalSeasons.Text <> "" Then
            If IsNumeric(txtTotalSeasons.Text) = False Then
                msg = msg + "Total Seasons MUST be a NUMBER" + vbNewLine
                result = False
            End If
        End If

        'Total Episodes can be null, but if it has a value, it MUST be numerical
        If txtTotalEpisodes.Text <> "" Then
            If IsNumeric(txtTotalEpisodes.Text) = False Then
                msg = msg + "Total Episodes MUST be a NUMBER" + vbNewLine
                result = False
            End If
        End If

        If cboWatchStat.Text = "" Then
            msg = msg + "Watching Status cannot be empty" + vbNewLine
            result = False
        End If

        If radRetDateYes.Checked = False And radRetDateNo.Checked = False Then
            msg = msg + "Return Date Known must be 'Yes' or 'No'" + vbNewLine
            result = False
        End If

        If radFinDateYes.Checked = False And radFinDateNo.Checked = False Then
            msg = msg + " Finale Date Known must be 'Yes' or 'No'" + vbNewLine
            result = False
        End If

        'If any validation fails, display all of the necessary error messages
        If result = False Then
            MsgBox(msg)
        End If
        Return result
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validateForm() = True Then
            connect()
            Try
                conn.Open()
                MsgBox("Connected")
            Catch ex As Exception
            End Try

            'SHOWS table data
            Dim showName, IMDbID As String
            Dim showID, airDay, airStatus, duration, network, streamServ, currSeason, currEpisode, totalSeasons, totalEpisodes, watchStatus As Integer
            Dim retDate, finDate, sqlDateFormat As String

            'Need to do CASE/SWITCH decoding:
            showName = txtShowName.Text

            Select Case cboAirDay.Text
                Case "Monday"
                    airDay = 1
                Case "Tuesday"
                    airDay = 2
                Case "Wednesday"
                    airDay = 3
                Case "Thursday"
                    airDay = 4
                Case "Friday"
                    airDay = 5
                Case "Saturday"
                    airDay = 6
                Case "Sunday"
                    airDay = 7
                Case "*Unknown*"
                    airDay = vbNull
            End Select

            Select Case cboAirStatus.Text
                Case "Current"
                    airStatus = 1
                Case "Hiatus"
                    airStatus = 2
                Case "Catch Up"
                    airStatus = 3
                Case "Ended"
                    airStatus = 4
            End Select

            Select Case cboDuration.Text
                Case "22"
                    duration = 22
                Case "30"
                    duration = 30
                Case "42"
                    duration = 42
                Case "60"
                    duration = 60
            End Select

            Select Case cboNetwork.Text
                Case "ABC"
                    network = 1
                Case "ABC (Aus)"
                    network = 2
                Case "ABC Family"
                    network = 3
                Case "Adult Swim"
                    network = 4
                Case "Amazon"
                    network = 5
                Case "AMC"
                    network = 6
                Case "BBC"
                    network = 7
                Case "BBC America"
                    network = 8
                Case "Bravo"
                    network = 9
                Case "Cartoon Network"
                    network = 10
                Case "CBS"
                    network = 11
                Case "CMT"
                    network = 12
                Case "Comedy Central"
                    network = 13
                Case "CW"
                    network = 14
                Case "DirecTV"
                    network = 15
                Case "Disney Channel"
                    network = 16
                Case "FOX"
                    network = 17
                Case "FX"
                    network = 18
                Case "FXX"
                    network = 19
                Case "HBO"
                    network = 20
                Case "Hulu"
                    network = 21
                Case "JST"
                    network = 22
                Case "MTV"
                    network = 23
                Case "NBC"
                    network = 24
                Case "Netflix"
                    network = 25
                Case "Nickelodeon"
                    network = 26
                Case "PBS"
                    network = 27
                Case "Showtime"
                    network = 28
                Case "Spike"
                    network = 29
                Case "Starz"
                    network = 30
                Case "TBS"
                    network = 31
                Case "USA"
                    network = 32
                Case "Yahoo!"
                    network = 33
                Case "Fuji TV"
                    network = 34
                Case "*Unknown*"
                    network = vbNull
            End Select

            Select Case cboStreamServ.Text
                Case "Amazon"
                    streamServ = 1
                Case "Amazon Prime"
                    streamServ = 2
                Case "CBS"
                    streamServ = 3
                Case "Disney XD"
                    streamServ = 4
                Case "FOX"
                    streamServ = 5
                Case "FXX"
                    streamServ = 6
                Case "HBO"
                    streamServ = 7
                Case "HBO Now"
                    streamServ = 8
                Case "Hulu"
                    streamServ = 9
                Case "iView"
                    streamServ = 10
                Case "Netflix"
                    streamServ = 11
                Case "Starz"
                    streamServ = 12
                Case "Vudu"
                    streamServ = 13
                Case "Yahoo!"
                    streamServ = 14
                Case "YouTube"
                    streamServ = 15
            End Select

            'validating non-compulsory fields (setting to actual null values)
            If txtIMDBID.Text = "" Then
                IMDbID = vbNull
            Else
                IMDbID = txtIMDBID.Text
            End If

            If txtCurrSeason.Text = "" Then
                currSeason = vbNull
            Else
                currSeason = FormatNumber(txtCurrSeason.Text)
            End If

            If txtCurrEpisode.Text = "" Then
                currEpisode = vbNull
            Else
                currEpisode = FormatNumber(txtCurrEpisode.Text)
            End If

            If txtTotalSeasons.Text = "" Then
                totalSeasons = vbNull
            Else
                totalSeasons = FormatNumber(txtTotalSeasons.Text)
            End If

            If txtTotalEpisodes.Text = "" Then
                totalEpisodes = vbNull
            Else
                totalEpisodes = FormatNumber(txtTotalEpisodes.Text)
            End If

            Select Case cboWatchStat.Text
                Case "Watching"
                    watchStatus = 1 'Y
                Case "Not Watching"
                    watchStatus = 2 'N
            End Select

            'Formats the dates to strings in the mySQL date format (yyyy-mm-dd)
            sqlDateFormat = "yyyy-MM-dd"
            retDate = Format(CDate(Date.Parse(dtpReturn.Value)), sqlDateFormat)
            finDate = Format(CDate(Date.Parse(dtpFinale.Value)), sqlDateFormat)

            '******* below statement is vulnerable to sql injections - google "parameterised queries" and try to implement that instead

            Dim cmd As New MySqlCommand
            cmd.CommandText = "INSERT INTO SHOWS (show_name, air_status, watch_status, air_day, duration, network_id, service_id, season_up_to, episode_up_to, total_seasons, total_episodes, return_date, finale_date, imdb_id)
                                VALUES('" & showName & "', " & airStatus & ", " & watchStatus & ", " & airDay & ", " & duration & ", " & network & ", " & streamServ & ", " & currSeason & ", " & currEpisode & ", " & totalSeasons & ", " & totalEpisodes & ", DATE'" & retDate & "', DATE'" & finDate & "', '" & IMDbID & "')"
            cmd.Connection = conn
            MsgBox(cmd.CommandText)
            MsgBox(cmd.ExecuteNonQuery)
            MsgBox("Row Inserted Successfully :)")
            'conn.Close()

            '@ 06/09/2016 - finished up here - Insert works successfully, connects to db on successful validation (probably doesn't need to be in this firm, can move it out most likely
            'Future steps - move to next form, passing info across
            'NOTE - db does not contain renew_status column -> need to create, and add data for all shows ... great.


            'ONCE ROW IS INSERTED PROPERLY, MOVE TO NEXT FORM, AND PASS RELEVANT INFO ACROSS
            '--------------------------------------------------------------------------------
            'Shows the entered VALIDATED show name on the Add Season Information screen


            '--------------------------------------------------------------------------------
            '*** create new connection/query
            cmd.CommandText = ""
            cmd.Connection = conn
            showID = cmd.ExecuteScalar()
            '*** SELECT show_id from shows WHERE show_name = showName
            '*** user cmd.ExecuteScalar() to store SELECT value in a variable
            '*** Then pass the show id to the frmSeasonInfo form

            'Information to pass across:
            'Show id, Show name, Total seasons - so you can validate the season information that has been added

            'Assign the frmSeasonInfo label the new Name of the show...
            frmSeasonInfo.lblShowName.Text = showName

            '*** create a label to show the total number of seasons
            frmSeasonInfo.lblTotalSeasons.Text = totalSeasons

            '*** create an INVISIBLE label to store the show id
            frmSeasonInfo.lblShowID.Text = showID

            '*** on frmSeasonInfo form:     lblSeasonIncrement.Text = [initialise at 1, loop process until increment = total]
            'lblSeasonRemaining.Text = TotalSeasons - Increment
            'insert into seasons (show_id, season_id, ep_count) VALUES (lblShowID.Text, lblSeasonIncrement.Text, txtEpsInSeason.Text);

            '-------------------------------------------------------------------

            'Show the frmSeasonInfo form
            frmSeasonInfo.Show()

            ' Hide the add show form
            Me.Hide()

        End If

    End Sub

    Private Sub radRetDateYes_CheckedChanged(sender As Object, e As EventArgs) Handles radRetDateYes.CheckedChanged
        panFinDate.Location = New Point(420, 430)
        panRetDate.Size = New System.Drawing.Size(300, 90)
        dtpReturn.Location = New Point(75, 40)
        dtpReturn.Visible = True
    End Sub

    Private Sub radRetDateNo_CheckedChanged(sender As Object, e As EventArgs) Handles radRetDateNo.CheckedChanged
        dtpReturn.Visible = False
        dtpReturn.Location = New Point(75, 75)
        panRetDate.Size = New System.Drawing.Size(300, 40)
        panFinDate.Location = New Point(420, 410)
    End Sub

    Private Sub radFinDateYes_CheckedChanged(sender As Object, e As EventArgs) Handles radFinDateYes.CheckedChanged
        panFinDate.Size = New System.Drawing.Size(300, 90)
        dtpFinale.Location = New Point(75, 40)
        dtpFinale.Visible = True
    End Sub

    Private Sub radFinDateNo_CheckedChanged(sender As Object, e As EventArgs) Handles radFinDateNo.CheckedChanged
        dtpFinale.Visible = False
        dtpFinale.Location = New Point(75, 75)
        panFinDate.Size = New System.Drawing.Size(300, 40)
    End Sub
End Class
