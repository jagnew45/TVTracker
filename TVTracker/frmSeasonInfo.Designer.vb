<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeasonInfo
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
        Me.lblSubHeading = New System.Windows.Forms.Label()
        Me.lblMainHeading = New System.Windows.Forms.Label()
        Me.grpSeasonInfo = New System.Windows.Forms.GroupBox()
        Me.txtEpisodeCount = New System.Windows.Forms.TextBox()
        Me.lblEpisodesHeading = New System.Windows.Forms.Label()
        Me.lblSeasonNum = New System.Windows.Forms.Label()
        Me.lblSeasonNumHeading = New System.Windows.Forms.Label()
        Me.btnAddInfo = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTotalHeading = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSeasonsRem = New System.Windows.Forms.Label()
        Me.lblSeasonsRemHeading = New System.Windows.Forms.Label()
        Me.lblShowName = New System.Windows.Forms.Label()
        Me.lblShowID = New System.Windows.Forms.Label()
        Me.grpSeasonInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubHeading
        '
        Me.lblSubHeading.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblSubHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubHeading.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeading.Location = New System.Drawing.Point(81, 73)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(236, 30)
        Me.lblSubHeading.TabIndex = 33
        Me.lblSubHeading.Text = "Add Season Information for :"
        Me.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainHeading
        '
        Me.lblMainHeading.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblMainHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMainHeading.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainHeading.Location = New System.Drawing.Point(64, 9)
        Me.lblMainHeading.Name = "lblMainHeading"
        Me.lblMainHeading.Size = New System.Drawing.Size(469, 53)
        Me.lblMainHeading.TabIndex = 32
        Me.lblMainHeading.Text = "TVTracker"
        Me.lblMainHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSeasonInfo
        '
        Me.grpSeasonInfo.Controls.Add(Me.txtEpisodeCount)
        Me.grpSeasonInfo.Controls.Add(Me.lblEpisodesHeading)
        Me.grpSeasonInfo.Controls.Add(Me.lblSeasonNum)
        Me.grpSeasonInfo.Controls.Add(Me.lblSeasonNumHeading)
        Me.grpSeasonInfo.Controls.Add(Me.btnAddInfo)
        Me.grpSeasonInfo.Location = New System.Drawing.Point(65, 172)
        Me.grpSeasonInfo.Name = "grpSeasonInfo"
        Me.grpSeasonInfo.Size = New System.Drawing.Size(430, 188)
        Me.grpSeasonInfo.TabIndex = 34
        Me.grpSeasonInfo.TabStop = False
        '
        'txtEpisodeCount
        '
        Me.txtEpisodeCount.Location = New System.Drawing.Point(258, 83)
        Me.txtEpisodeCount.MaxLength = 4
        Me.txtEpisodeCount.Name = "txtEpisodeCount"
        Me.txtEpisodeCount.Size = New System.Drawing.Size(73, 20)
        Me.txtEpisodeCount.TabIndex = 4
        '
        'lblEpisodesHeading
        '
        Me.lblEpisodesHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEpisodesHeading.Location = New System.Drawing.Point(17, 83)
        Me.lblEpisodesHeading.Name = "lblEpisodesHeading"
        Me.lblEpisodesHeading.Size = New System.Drawing.Size(191, 20)
        Me.lblEpisodesHeading.TabIndex = 3
        Me.lblEpisodesHeading.Text = "Episodes in Season:"
        Me.lblEpisodesHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSeasonNum
        '
        Me.lblSeasonNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeasonNum.Location = New System.Drawing.Point(258, 41)
        Me.lblSeasonNum.Name = "lblSeasonNum"
        Me.lblSeasonNum.Size = New System.Drawing.Size(73, 20)
        Me.lblSeasonNum.TabIndex = 2
        Me.lblSeasonNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSeasonNumHeading
        '
        Me.lblSeasonNumHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeasonNumHeading.Location = New System.Drawing.Point(17, 41)
        Me.lblSeasonNumHeading.Name = "lblSeasonNumHeading"
        Me.lblSeasonNumHeading.Size = New System.Drawing.Size(191, 20)
        Me.lblSeasonNumHeading.TabIndex = 1
        Me.lblSeasonNumHeading.Text = "Season Number:"
        Me.lblSeasonNumHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddInfo
        '
        Me.btnAddInfo.Location = New System.Drawing.Point(314, 136)
        Me.btnAddInfo.Name = "btnAddInfo"
        Me.btnAddInfo.Size = New System.Drawing.Size(106, 39)
        Me.btnAddInfo.TabIndex = 0
        Me.btnAddInfo.Text = "Add Season Info"
        Me.btnAddInfo.UseVisualStyleBackColor = True
        '
        'btnProceed
        '
        Me.btnProceed.Enabled = False
        Me.btnProceed.Location = New System.Drawing.Point(473, 383)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(98, 42)
        Me.btnProceed.TabIndex = 35
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(29, 383)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 42)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancel and Return"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTotalHeading
        '
        Me.lblTotalHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalHeading.Location = New System.Drawing.Point(81, 123)
        Me.lblTotalHeading.Name = "lblTotalHeading"
        Me.lblTotalHeading.Size = New System.Drawing.Size(126, 28)
        Me.lblTotalHeading.TabIndex = 5
        Me.lblTotalHeading.Text = "Total seasons of show:"
        Me.lblTotalHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(213, 123)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(60, 28)
        Me.lblTotal.TabIndex = 37
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeasonsRem
        '
        Me.lblSeasonsRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeasonsRem.Location = New System.Drawing.Point(435, 122)
        Me.lblSeasonsRem.Name = "lblSeasonsRem"
        Me.lblSeasonsRem.Size = New System.Drawing.Size(60, 28)
        Me.lblSeasonsRem.TabIndex = 39
        Me.lblSeasonsRem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeasonsRemHeading
        '
        Me.lblSeasonsRemHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSeasonsRemHeading.Location = New System.Drawing.Point(303, 122)
        Me.lblSeasonsRemHeading.Name = "lblSeasonsRemHeading"
        Me.lblSeasonsRemHeading.Size = New System.Drawing.Size(126, 28)
        Me.lblSeasonsRemHeading.TabIndex = 38
        Me.lblSeasonsRemHeading.Text = "Seasons left to enter:"
        Me.lblSeasonsRemHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShowName
        '
        Me.lblShowName.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblShowName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShowName.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowName.Location = New System.Drawing.Point(323, 73)
        Me.lblShowName.Name = "lblShowName"
        Me.lblShowName.Size = New System.Drawing.Size(172, 30)
        Me.lblShowName.TabIndex = 40
        Me.lblShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShowID
        '
        Me.lblShowID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowID.Location = New System.Drawing.Point(501, 73)
        Me.lblShowID.Name = "lblShowID"
        Me.lblShowID.Size = New System.Drawing.Size(60, 28)
        Me.lblShowID.TabIndex = 41
        Me.lblShowID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblShowID.Visible = False
        '
        'frmSeasonInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 447)
        Me.Controls.Add(Me.lblShowID)
        Me.Controls.Add(Me.lblShowName)
        Me.Controls.Add(Me.lblSeasonsRem)
        Me.Controls.Add(Me.lblSeasonsRemHeading)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalHeading)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.grpSeasonInfo)
        Me.Controls.Add(Me.lblSubHeading)
        Me.Controls.Add(Me.lblMainHeading)
        Me.Name = "frmSeasonInfo"
        Me.Text = "Season Information"
        Me.grpSeasonInfo.ResumeLayout(False)
        Me.grpSeasonInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblMainHeading As Label
    Friend WithEvents grpSeasonInfo As GroupBox
    Friend WithEvents lblSeasonNumHeading As Label
    Friend WithEvents btnAddInfo As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents txtEpisodeCount As TextBox
    Friend WithEvents lblEpisodesHeading As Label
    Friend WithEvents lblSeasonNum As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTotalHeading As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSeasonsRem As Label
    Friend WithEvents lblSeasonsRemHeading As Label
    Friend WithEvents lblShowName As Label
    Friend WithEvents lblShowID As Label
End Class
