Imports MySql.Data.MySqlClient

Public Class frmAddShow
    Dim conn As New MySqlConnection

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
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

        'If any validation fails, display all of the necessary error messages
        If result = False Then
            MsgBox(msg)
        End If
        Return result
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validateForm() = True Then
            Try
                conn.Open()
            Catch ex As Exception
            End Try

            'SHOWS table data
            Dim showName, IMDbID, watchStatus As String
            Dim airDay, airStatus, duration, network, streamServ, currSeason, currEpisode, totalSeasons, totalEpisodes As Integer
            Dim retDate, finDate As Date

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

            IMDbID = txtIMDBID.Text
            currSeason = txtCurrSeason.Text
            currEpisode = txtCurrEpisode.Text
            totalSeasons = txtTotalSeasons.Text
            totalEpisodes = txtTotalEpisodes.Text
            retDate = Date.Parse(dtpReturn.Value)
            finDate = Date.Parse(dtpFinale.Value)

            'Have to figure out DATES (how to format properly so the value can be inserted properly) **************************
            MsgBox(retDate)
            MsgBox(finDate)

            Select Case cboWatchStat.Text
                Case "Watching"
                    watchStatus = "Y"
                Case "Not Watching"
                    watchStatus = "N"
            End Select


            Dim cmd As New MySqlCommand
            cmd.CommandText = "INSERT INTO SHOWS (show_name, air_status, watch_status, air_day, duration, network_id, service_id, season_up_to, episode_up_to, total_seasons, total_episodes, return_date, finale_date, imdb_id)
                                VALUES(" & showName & ", " & airStatus & ", " & watchStatus & ", " & airDay & ", " & duration & ", " & network & ", " & streamServ & ", " & currSeason & ", " & currEpisode & ", " & totalSeasons & ", " & totalEpisodes & ", " & retDate & ", " & finDate & ", " & IMDbID & ")"
            cmd.Connection = conn
            MsgBox(cmd.ExecuteNonQuery)
            conn.Close()

            'ONCE ROW IS INSERTED PROPERLY, MOVE TO NEXT FORM, AND PASS RELEVANT INFO ACROSS
            '--------------------------------------------------------------------------------
            'Shows the entered VALIDATED show name on the Add Season Information screen

            'Information to pass across:
            'Show name, Total seasons - so you can validate the season information that has been added
            If txtShowName.Text = "" Then
                MsgBox("Show Name must have a value")
                ' Else
                '   frmSeasonInfo.lblShowName.Text = txtShowName.Text
                '    frmSeasonInfo.Show()
                '    Me.Hide()
            End If
        End If

    End Sub


End Class