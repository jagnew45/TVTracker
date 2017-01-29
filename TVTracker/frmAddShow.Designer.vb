<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddShow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMainHeading = New System.Windows.Forms.Label()
        Me.lblSubHeading = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.txtShowName = New System.Windows.Forms.TextBox()
        Me.lblAirDay = New System.Windows.Forms.Label()
        Me.lblAirStatus = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.lblStreamServ = New System.Windows.Forms.Label()
        Me.lblCurrSeason = New System.Windows.Forms.Label()
        Me.lblNextEpisode = New System.Windows.Forms.Label()
        Me.lblTotalSeasons = New System.Windows.Forms.Label()
        Me.lblTotalEpisodes = New System.Windows.Forms.Label()
        Me.lblRetDate = New System.Windows.Forms.Label()
        Me.lblFinaleDate = New System.Windows.Forms.Label()
        Me.lblWatchStat = New System.Windows.Forms.Label()
        Me.lblIMDB = New System.Windows.Forms.Label()
        Me.txtIMDBID = New System.Windows.Forms.TextBox()
        Me.dtpFinale = New System.Windows.Forms.DateTimePicker()
        Me.cboWatchStat = New System.Windows.Forms.ComboBox()
        Me.cboAirDay = New System.Windows.Forms.ComboBox()
        Me.cboAirStatus = New System.Windows.Forms.ComboBox()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.cboNetwork = New System.Windows.Forms.ComboBox()
        Me.cboStreamServ = New System.Windows.Forms.ComboBox()
        Me.txtCurrSeason = New System.Windows.Forms.TextBox()
        Me.txtCurrEpisode = New System.Windows.Forms.TextBox()
        Me.txtTotalSeasons = New System.Windows.Forms.TextBox()
        Me.txtTotalEpisodes = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblProceed = New System.Windows.Forms.Label()
        Me.radFinDateNo = New System.Windows.Forms.RadioButton()
        Me.radFinDateYes = New System.Windows.Forms.RadioButton()
        Me.radRetDateNo = New System.Windows.Forms.RadioButton()
        Me.radRetDateYes = New System.Windows.Forms.RadioButton()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.panRetDate = New System.Windows.Forms.Panel()
        Me.panFinDate = New System.Windows.Forms.Panel()
        Me.panRetDate.SuspendLayout()
        Me.panFinDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMainHeading
        '
        Me.lblMainHeading.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblMainHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMainHeading.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainHeading.Location = New System.Drawing.Point(198, 9)
        Me.lblMainHeading.Name = "lblMainHeading"
        Me.lblMainHeading.Size = New System.Drawing.Size(469, 53)
        Me.lblMainHeading.TabIndex = 30
        Me.lblMainHeading.Text = "TVTracker"
        Me.lblMainHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubHeading
        '
        Me.lblSubHeading.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblSubHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubHeading.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeading.Location = New System.Drawing.Point(215, 73)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(414, 30)
        Me.lblSubHeading.TabIndex = 31
        Me.lblSubHeading.Text = "Add Show"
        Me.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.LightCoral
        Me.btnReturn.Location = New System.Drawing.Point(731, 9)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(95, 40)
        Me.btnReturn.TabIndex = 23
        Me.btnReturn.Text = "Return to Main"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblShowName
        '
        Me.lblShowName.BackColor = System.Drawing.SystemColors.Control
        Me.lblShowName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowName.Location = New System.Drawing.Point(60, 135)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(131, 20)
        Me.lblShowName.TabIndex = 100
        Me.lblShowName.Text = "Show Name"
        Me.lblShowName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtShowName
        '
        Me.txtShowName.Location = New System.Drawing.Point(210, 135)
        Me.txtShowName.MaxLength = 40
        Me.txtShowName.Name = "txtShowName"
        Me.txtShowName.Size = New System.Drawing.Size(174, 20)
        Me.txtShowName.TabIndex = 1
        '
        'lblAirDay
        '
        Me.lblAirDay.BackColor = System.Drawing.SystemColors.Control
        Me.lblAirDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAirDay.Location = New System.Drawing.Point(60, 181)
        Me.lblAirDay.Name = "lblAirDay"
        Me.lblAirDay.Size = New System.Drawing.Size(131, 20)
        Me.lblAirDay.TabIndex = 101
        Me.lblAirDay.Text = "Air Day"
        Me.lblAirDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAirStatus
        '
        Me.lblAirStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblAirStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAirStatus.Location = New System.Drawing.Point(60, 228)
        Me.lblAirStatus.Name = "lblAirStatus"
        Me.lblAirStatus.Size = New System.Drawing.Size(131, 20)
        Me.lblAirStatus.TabIndex = 102
        Me.lblAirStatus.Text = "Air Status"
        Me.lblAirStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDuration
        '
        Me.lblDuration.BackColor = System.Drawing.SystemColors.Control
        Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDuration.Location = New System.Drawing.Point(60, 276)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(131, 20)
        Me.lblDuration.TabIndex = 103
        Me.lblDuration.Text = "Duration (mins)"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetwork
        '
        Me.lblNetwork.BackColor = System.Drawing.SystemColors.Control
        Me.lblNetwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetwork.Location = New System.Drawing.Point(60, 324)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(131, 20)
        Me.lblNetwork.TabIndex = 104
        Me.lblNetwork.Text = "Network"
        Me.lblNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStreamServ
        '
        Me.lblStreamServ.BackColor = System.Drawing.SystemColors.Control
        Me.lblStreamServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStreamServ.Location = New System.Drawing.Point(60, 376)
        Me.lblStreamServ.Name = "lblStreamServ"
        Me.lblStreamServ.Size = New System.Drawing.Size(131, 20)
        Me.lblStreamServ.TabIndex = 105
        Me.lblStreamServ.Text = "Streaming Service"
        Me.lblStreamServ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCurrSeason
        '
        Me.lblCurrSeason.BackColor = System.Drawing.SystemColors.Control
        Me.lblCurrSeason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrSeason.Location = New System.Drawing.Point(434, 134)
        Me.lblCurrSeason.Name = "lblCurrSeason"
        Me.lblCurrSeason.Size = New System.Drawing.Size(131, 20)
        Me.lblCurrSeason.TabIndex = 23
        Me.lblCurrSeason.Text = "Season Up To"
        Me.lblCurrSeason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNextEpisode
        '
        Me.lblNextEpisode.BackColor = System.Drawing.SystemColors.Control
        Me.lblNextEpisode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNextEpisode.Location = New System.Drawing.Point(434, 180)
        Me.lblNextEpisode.Name = "lblNextEpisode"
        Me.lblNextEpisode.Size = New System.Drawing.Size(131, 20)
        Me.lblNextEpisode.TabIndex = 24
        Me.lblNextEpisode.Text = "Episode Up To"
        Me.lblNextEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalSeasons
        '
        Me.lblTotalSeasons.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalSeasons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSeasons.Location = New System.Drawing.Point(434, 227)
        Me.lblTotalSeasons.Name = "lblTotalSeasons"
        Me.lblTotalSeasons.Size = New System.Drawing.Size(131, 20)
        Me.lblTotalSeasons.TabIndex = 25
        Me.lblTotalSeasons.Text = "Total Seasons"
        Me.lblTotalSeasons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalEpisodes
        '
        Me.lblTotalEpisodes.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalEpisodes.Location = New System.Drawing.Point(434, 275)
        Me.lblTotalEpisodes.Name = "lblTotalEpisodes"
        Me.lblTotalEpisodes.Size = New System.Drawing.Size(131, 20)
        Me.lblTotalEpisodes.TabIndex = 26
        Me.lblTotalEpisodes.Text = "Total Episodes"
        Me.lblTotalEpisodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRetDate
        '
        Me.lblRetDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblRetDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetDate.Location = New System.Drawing.Point(14, 12)
        Me.lblRetDate.Name = "lblRetDate"
        Me.lblRetDate.Size = New System.Drawing.Size(131, 20)
        Me.lblRetDate.TabIndex = 27
        Me.lblRetDate.Text = "Return Date Known?"
        Me.lblRetDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFinaleDate
        '
        Me.lblFinaleDate.BackColor = System.Drawing.SystemColors.Control
        Me.lblFinaleDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinaleDate.Location = New System.Drawing.Point(14, 9)
        Me.lblFinaleDate.Name = "lblFinaleDate"
        Me.lblFinaleDate.Size = New System.Drawing.Size(131, 20)
        Me.lblFinaleDate.TabIndex = 28
        Me.lblFinaleDate.Text = "Finale Date Known?"
        Me.lblFinaleDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWatchStat
        '
        Me.lblWatchStat.BackColor = System.Drawing.SystemColors.Control
        Me.lblWatchStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWatchStat.Location = New System.Drawing.Point(434, 323)
        Me.lblWatchStat.Name = "lblWatchStat"
        Me.lblWatchStat.Size = New System.Drawing.Size(131, 20)
        Me.lblWatchStat.TabIndex = 29
        Me.lblWatchStat.Text = "Watching Status"
        Me.lblWatchStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIMDB
        '
        Me.lblIMDB.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblIMDB.BackColor = System.Drawing.SystemColors.Control
        Me.lblIMDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIMDB.Location = New System.Drawing.Point(60, 419)
        Me.lblIMDB.Name = "lblIMDB"
        Me.lblIMDB.Size = New System.Drawing.Size(131, 20)
        Me.lblIMDB.TabIndex = 22
        Me.lblIMDB.Text = "IMDb ID"
        Me.lblIMDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIMDBID
        '
        Me.txtIMDBID.Location = New System.Drawing.Point(210, 419)
        Me.txtIMDBID.MaxLength = 9
        Me.txtIMDBID.Name = "txtIMDBID"
        Me.txtIMDBID.Size = New System.Drawing.Size(174, 20)
        Me.txtIMDBID.TabIndex = 7
        '
        'dtpFinale
        '
        Me.dtpFinale.CustomFormat = ""
        Me.dtpFinale.Location = New System.Drawing.Point(55, 91)
        Me.dtpFinale.Name = "dtpFinale"
        Me.dtpFinale.Size = New System.Drawing.Size(200, 20)
        Me.dtpFinale.TabIndex = 20
        Me.dtpFinale.Visible = False
        '
        'cboWatchStat
        '
        Me.cboWatchStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWatchStat.FormattingEnabled = True
        Me.cboWatchStat.Items.AddRange(New Object() {"Watching", "Not Watching"})
        Me.cboWatchStat.Location = New System.Drawing.Point(580, 322)
        Me.cboWatchStat.Name = "cboWatchStat"
        Me.cboWatchStat.Size = New System.Drawing.Size(132, 21)
        Me.cboWatchStat.TabIndex = 12
        '
        'cboAirDay
        '
        Me.cboAirDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAirDay.FormattingEnabled = True
        Me.cboAirDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "*Unknown*"})
        Me.cboAirDay.Location = New System.Drawing.Point(210, 180)
        Me.cboAirDay.Name = "cboAirDay"
        Me.cboAirDay.Size = New System.Drawing.Size(174, 21)
        Me.cboAirDay.TabIndex = 2
        '
        'cboAirStatus
        '
        Me.cboAirStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAirStatus.FormattingEnabled = True
        Me.cboAirStatus.Items.AddRange(New Object() {"Current", "Hiatus", "Catch Up", "Ended"})
        Me.cboAirStatus.Location = New System.Drawing.Point(210, 228)
        Me.cboAirStatus.Name = "cboAirStatus"
        Me.cboAirStatus.Size = New System.Drawing.Size(174, 21)
        Me.cboAirStatus.TabIndex = 3
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"22", "30", "42", "60", "*Unknown*"})
        Me.cboDuration.Location = New System.Drawing.Point(210, 275)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(174, 21)
        Me.cboDuration.TabIndex = 4
        '
        'cboNetwork
        '
        Me.cboNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNetwork.FormattingEnabled = True
        Me.cboNetwork.Items.AddRange(New Object() {"ABC", "ABC (Aus)", "ABC Family", "Adult Swim", "Amazon", "AMC", "BBC", "BBC America", "Bravo", "Cartoon Network", "CBS", "CMT", "Comedy Central", "CW", "DirecTV", "Disney Channel", "FOX", "Fuji TV", "FX", "FXX", "HBO", "Hulu", "JST", "MTV", "NBC", "Netflix", "Nickelodeon", "PBS", "Showtime", "Spike", "Starz", "TBS", "USA", "Yahoo!", "*Unknown*"})
        Me.cboNetwork.Location = New System.Drawing.Point(210, 324)
        Me.cboNetwork.Name = "cboNetwork"
        Me.cboNetwork.Size = New System.Drawing.Size(174, 21)
        Me.cboNetwork.TabIndex = 5
        '
        'cboStreamServ
        '
        Me.cboStreamServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStreamServ.FormattingEnabled = True
        Me.cboStreamServ.Items.AddRange(New Object() {"Amazon", "Amazon Prime", "CBS", "Disney XD", "FOX", "FXX", "HBO", "HBO Now", "Hulu", "iView?", "Netflix", "Starz", "Vudu", "Yahoo!", "*Unknown*", "YouTube"})
        Me.cboStreamServ.Location = New System.Drawing.Point(210, 376)
        Me.cboStreamServ.Name = "cboStreamServ"
        Me.cboStreamServ.Size = New System.Drawing.Size(174, 21)
        Me.cboStreamServ.TabIndex = 6
        '
        'txtCurrSeason
        '
        Me.txtCurrSeason.Location = New System.Drawing.Point(580, 134)
        Me.txtCurrSeason.MaxLength = 3
        Me.txtCurrSeason.Name = "txtCurrSeason"
        Me.txtCurrSeason.Size = New System.Drawing.Size(132, 20)
        Me.txtCurrSeason.TabIndex = 8
        '
        'txtCurrEpisode
        '
        Me.txtCurrEpisode.Location = New System.Drawing.Point(580, 180)
        Me.txtCurrEpisode.MaxLength = 4
        Me.txtCurrEpisode.Name = "txtCurrEpisode"
        Me.txtCurrEpisode.Size = New System.Drawing.Size(132, 20)
        Me.txtCurrEpisode.TabIndex = 9
        '
        'txtTotalSeasons
        '
        Me.txtTotalSeasons.Location = New System.Drawing.Point(580, 227)
        Me.txtTotalSeasons.MaxLength = 3
        Me.txtTotalSeasons.Name = "txtTotalSeasons"
        Me.txtTotalSeasons.Size = New System.Drawing.Size(132, 20)
        Me.txtTotalSeasons.TabIndex = 10
        '
        'txtTotalEpisodes
        '
        Me.txtTotalEpisodes.Location = New System.Drawing.Point(580, 275)
        Me.txtTotalEpisodes.MaxLength = 4
        Me.txtTotalEpisodes.Name = "txtTotalEpisodes"
        Me.txtTotalEpisodes.Size = New System.Drawing.Size(132, 20)
        Me.txtTotalEpisodes.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightSalmon
        Me.btnAdd.Location = New System.Drawing.Point(661, 525)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 56)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add Show"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSalmon
        Me.btnClear.Location = New System.Drawing.Point(60, 526)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 55)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblProceed
        '
        Me.lblProceed.Location = New System.Drawing.Point(511, 533)
        Me.lblProceed.Name = "lblProceed"
        Me.lblProceed.Size = New System.Drawing.Size(144, 41)
        Me.lblProceed.TabIndex = 38
        Me.lblProceed.Text = "Click 'Add Show' to proceed to Season Information"
        Me.lblProceed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radFinDateNo
        '
        Me.radFinDateNo.AutoSize = True
        Me.radFinDateNo.Location = New System.Drawing.Point(235, 9)
        Me.radFinDateNo.Name = "radFinDateNo"
        Me.radFinDateNo.Size = New System.Drawing.Size(39, 17)
        Me.radFinDateNo.TabIndex = 18
        Me.radFinDateNo.TabStop = True
        Me.radFinDateNo.Text = "No"
        Me.radFinDateNo.UseVisualStyleBackColor = True
        '
        'radFinDateYes
        '
        Me.radFinDateYes.AutoSize = True
        Me.radFinDateYes.Location = New System.Drawing.Point(172, 9)
        Me.radFinDateYes.Name = "radFinDateYes"
        Me.radFinDateYes.Size = New System.Drawing.Size(43, 17)
        Me.radFinDateYes.TabIndex = 17
        Me.radFinDateYes.TabStop = True
        Me.radFinDateYes.Text = "Yes"
        Me.radFinDateYes.UseVisualStyleBackColor = True
        '
        'radRetDateNo
        '
        Me.radRetDateNo.AutoSize = True
        Me.radRetDateNo.Location = New System.Drawing.Point(235, 12)
        Me.radRetDateNo.Name = "radRetDateNo"
        Me.radRetDateNo.Size = New System.Drawing.Size(39, 17)
        Me.radRetDateNo.TabIndex = 15
        Me.radRetDateNo.TabStop = True
        Me.radRetDateNo.Text = "No"
        Me.radRetDateNo.UseVisualStyleBackColor = True
        '
        'radRetDateYes
        '
        Me.radRetDateYes.AutoSize = True
        Me.radRetDateYes.Location = New System.Drawing.Point(172, 12)
        Me.radRetDateYes.Name = "radRetDateYes"
        Me.radRetDateYes.Size = New System.Drawing.Size(43, 17)
        Me.radRetDateYes.TabIndex = 14
        Me.radRetDateYes.TabStop = True
        Me.radRetDateYes.Text = "Yes"
        Me.radRetDateYes.UseVisualStyleBackColor = True
        '
        'dtpReturn
        '
        Me.dtpReturn.CustomFormat = ""
        Me.dtpReturn.Location = New System.Drawing.Point(75, 75)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(200, 20)
        Me.dtpReturn.TabIndex = 19
        Me.dtpReturn.Visible = False
        '
        'panRetDate
        '
        Me.panRetDate.Controls.Add(Me.radRetDateNo)
        Me.panRetDate.Controls.Add(Me.lblRetDate)
        Me.panRetDate.Controls.Add(Me.radRetDateYes)
        Me.panRetDate.Controls.Add(Me.dtpReturn)
        Me.panRetDate.Location = New System.Drawing.Point(420, 364)
        Me.panRetDate.Name = "panRetDate"
        Me.panRetDate.Size = New System.Drawing.Size(300, 40)
        Me.panRetDate.TabIndex = 13
        '
        'panFinDate
        '
        Me.panFinDate.Controls.Add(Me.radFinDateNo)
        Me.panFinDate.Controls.Add(Me.lblFinaleDate)
        Me.panFinDate.Controls.Add(Me.radFinDateYes)
        Me.panFinDate.Controls.Add(Me.dtpFinale)
        Me.panFinDate.Location = New System.Drawing.Point(420, 410)
        Me.panFinDate.Name = "panFinDate"
        Me.panFinDate.Size = New System.Drawing.Size(300, 40)
        Me.panFinDate.TabIndex = 16
        '
        'frmAddShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(838, 599)
        Me.Controls.Add(Me.panFinDate)
        Me.Controls.Add(Me.panRetDate)
        Me.Controls.Add(Me.lblProceed)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtTotalEpisodes)
        Me.Controls.Add(Me.txtTotalSeasons)
        Me.Controls.Add(Me.txtCurrEpisode)
        Me.Controls.Add(Me.txtCurrSeason)
        Me.Controls.Add(Me.cboStreamServ)
        Me.Controls.Add(Me.cboNetwork)
        Me.Controls.Add(Me.cboDuration)
        Me.Controls.Add(Me.cboAirStatus)
        Me.Controls.Add(Me.cboAirDay)
        Me.Controls.Add(Me.cboWatchStat)
        Me.Controls.Add(Me.txtIMDBID)
        Me.Controls.Add(Me.lblIMDB)
        Me.Controls.Add(Me.lblWatchStat)
        Me.Controls.Add(Me.lblTotalEpisodes)
        Me.Controls.Add(Me.lblTotalSeasons)
        Me.Controls.Add(Me.lblNextEpisode)
        Me.Controls.Add(Me.lblCurrSeason)
        Me.Controls.Add(Me.lblStreamServ)
        Me.Controls.Add(Me.lblNetwork)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblAirStatus)
        Me.Controls.Add(Me.lblAirDay)
        Me.Controls.Add(Me.txtShowName)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblSubHeading)
        Me.Controls.Add(Me.lblMainHeading)
        Me.Name = "frmAddShow"
        Me.Text = "frmAddShow"
        Me.panRetDate.ResumeLayout(False)
        Me.panRetDate.PerformLayout()
        Me.panFinDate.ResumeLayout(False)
        Me.panFinDate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMainHeading As Label
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblShowName As Label
    Friend WithEvents txtShowName As TextBox
    Friend WithEvents lblAirDay As Label
    Friend WithEvents lblAirStatus As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblNetwork As Label
    Friend WithEvents lblStreamServ As Label
    Friend WithEvents lblCurrSeason As Label
    Friend WithEvents lblNextEpisode As Label
    Friend WithEvents lblTotalSeasons As Label
    Friend WithEvents lblTotalEpisodes As Label
    Friend WithEvents lblRetDate As Label
    Friend WithEvents lblFinaleDate As Label
    Friend WithEvents lblWatchStat As Label
    Friend WithEvents lblIMDB As Label
    Friend WithEvents txtIMDBID As TextBox
    Friend WithEvents dtpFinale As DateTimePicker
    Friend WithEvents cboWatchStat As ComboBox
    Friend WithEvents cboAirDay As ComboBox
    Friend WithEvents cboAirStatus As ComboBox
    Friend WithEvents cboDuration As ComboBox
    Friend WithEvents cboNetwork As ComboBox
    Friend WithEvents cboStreamServ As ComboBox
    Friend WithEvents txtCurrSeason As TextBox
    Friend WithEvents txtCurrEpisode As TextBox
    Friend WithEvents txtTotalSeasons As TextBox
    Friend WithEvents txtTotalEpisodes As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblProceed As Label
    Friend WithEvents radFinDateNo As RadioButton
    Friend WithEvents radFinDateYes As RadioButton
    Friend WithEvents radRetDateNo As RadioButton
    Friend WithEvents radRetDateYes As RadioButton
    Friend WithEvents dtpReturn As DateTimePicker
    Friend WithEvents panRetDate As Panel
    Friend WithEvents panFinDate As Panel
End Class
